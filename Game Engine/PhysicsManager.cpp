#include "PhysicsManager.h"

void Physics::dealloc()
{
	delete dynamicsWorld;
	delete solver;
	delete collisionConfiguration;
	delete dispatcher;
	delete overlappingPairCache;
}

void Physics::Restart(PhysicsData PD)
{
	collisionConfiguration = new btDefaultCollisionConfiguration();
	dispatcher = new btCollisionDispatcher(collisionConfiguration);
	overlappingPairCache = new btDbvtBroadphase();
	solver = new btSequentialImpulseConstraintSolver();
	dynamicsWorld = new btDiscreteDynamicsWorld(dispatcher, overlappingPairCache, solver, collisionConfiguration);
	dynamicsWorld->setGravity(btVector3(0, -Gravity, 0));
	collisionShapes.clear();
}

void Physics::CreateEntity(PhysicsData PD)
{
	btTransform NewTransform;
	NewTransform.setIdentity();
	NewTransform.setOrigin({ (btScalar)PD.positions.x,(btScalar)PD.positions.y,(btScalar)PD.positions.z});
	btCollisionShape* newRigidShape = new btBoxShape({PD.Colliders.x,PD.Colliders.y,PD.Colliders.z});
	newRigidShape->calculateLocalInertia(PD.mass, btVector3({ 0,0,0 }));
	btMotionState* myMotionState = new btDefaultMotionState(NewTransform);
	btRigidBody::btRigidBodyConstructionInfo BodyInfo(PD.mass, myMotionState, newRigidShape, btVector3({ 0,0,0 }));
	btRigidBody* Bdy = new btRigidBody(BodyInfo);
	collisionShapes.push_back(newRigidShape);
	dynamicsWorld->addRigidBody(Bdy);
	physicsAccessors.insert({ PD.Name,Bdy });
	_OP->GetObjectFromPool(PD.Name)->RigidBody3d = Bdy;
	_OP->GetObjectFromPool(PD.Name)->Empty = false;
}

void Physics::SetMass(PhysicsData PD)
{
	btRigidBody* RB = physicsAccessors.at(PD.Name);
	dynamicsWorld->removeRigidBody(RB);
	RB->getCollisionShape()->calculateLocalInertia(PD.mass,btVector3({0,0,0}));
	btRigidBody::btRigidBodyConstructionInfo BodyInfo(PD.mass, RB->getMotionState(), RB->getCollisionShape(), btVector3({ 0,0,0 }));
	RB = new btRigidBody(BodyInfo);
	//RigidBody3d->setUserPointer(Node);
	collisionShapes.push_back(RB->getCollisionShape());
	dynamicsWorld->addRigidBody(RB);
	physicsAccessors.at(PD.Name) = RB;

	_OP->GetObjectFromPool(PD.Name)->RigidBody3d = RB;
}

void Physics::TranslateLocally(PhysicsData PD)
{
	physicsAccessors.at(PD.Name)->activate();
	physicsAccessors.at(PD.Name)->applyCentralImpulse({PD.GenericVector.x,PD.GenericVector.y,PD.GenericVector.z});
}

void Physics::SetVelocity(PhysicsData PD)
{
	btRigidBody* RB = physicsAccessors.at(PD.Name);
	RB->activate();
	RB->setLinearVelocity({ PD.GenericVector.x,PD.GenericVector.y,PD.GenericVector.z });
}

void Physics::AddVelocity(PhysicsData PD)
{

	btRigidBody* RB = physicsAccessors.at(PD.Name);
	RB->activate();
	btVector3 Velo = RB->getLinearVelocity();
	RB->setLinearVelocity({ Velo.getX()+PD.GenericVector.x
							,Velo.getY() + PD.GenericVector.y
							,Velo.getZ() + PD.GenericVector.z });
}

void Physics::Teleport(PhysicsData PD)
{
	btRigidBody* RB = physicsAccessors.at(PD.Name);
	btTransform Transform;
	Transform.setOrigin({ PD.positions.x,PD.positions.y,PD.positions.z });
	RB->setWorldTransform(Transform);
	RB->getMotionState()->setWorldTransform(Transform);
}

Physics::Physics(ObjectPool* OP)
{
	_OP = OP;
	collisionConfiguration = new btDefaultCollisionConfiguration();
	dispatcher = new btCollisionDispatcher(collisionConfiguration);
	overlappingPairCache = new btDbvtBroadphase();
	solver = new btSequentialImpulseConstraintSolver();
	dynamicsWorld = new btDiscreteDynamicsWorld(dispatcher, overlappingPairCache, solver, collisionConfiguration);
	dynamicsWorld->setGravity(btVector3(0, -Gravity, 0));
}

void Physics::CheckCollisions()
{
	int numManifolds = dispatcher->getNumManifolds();
	for (int i = 0; i < numManifolds; i++)
	{
		btPersistentManifold* contactManifold = dispatcher->getManifoldByIndexInternal(i);
		btCollisionObject* obA = (btCollisionObject*)contactManifold->getBody0();
		btCollisionObject* obB = (btCollisionObject*)contactManifold->getBody1();
		int numContacts = contactManifold->getNumContacts();
		for (int j = 0; j < numContacts; j++)
		{
			btRigidBody* bodyA = btRigidBody::upcast(obA);
			btRigidBody* bodyB = btRigidBody::upcast(obB);
			GameObject* A = _OP->GetObjectFromPool(bodyA);
			GameObject* B = _OP->GetObjectFromPool(bodyB);
			btManifoldPoint pt = contactManifold->getContactPoint(j);
			if (pt.getDistance() < 0.0f)
			{
				btVector3 ptA = pt.getPositionWorldOnA();
				btVector3 ptB = pt.getPositionWorldOnB();
				btVector3 normalOnB = pt.m_normalWorldOnB;
				A->AddCollision(B->Name);
				B->AddCollision(A->Name);
			}
			else
			{
				A->ClearCollision(B->Name);
				B->ClearCollision(A->Name);
			}
		}
	}
}

void Physics::PhysicsUpdate(EventQueue* EQ)
{
	EventQueue E = EventQueue();
	E = EQ[0];
	for (int i = 0;i<EQ->Queue.size();++i)
	{
		event EV = E.CheckQueueReturnEvent(SubSystem_Physics);
		if (EV.Empty == false)
		{
			for (int j = 0; j < EV.SubSystemList.size(); ++j)
			{
				if (EV.SubSystemList.at(j) == SubSystem_Physics)
				{
					Reactions A = EventReactions[(int)EV.PhysicsEventType];
					(this->*A)(EV.PD);
					EQ->RemoveFromQueue(SubSystem_Physics);
				}
			}
		}
		else
		{
			break;
		}

	}



	dynamicsWorld->stepSimulation(1.0f / (float)PhysicsPollRate);
	for (int i = 0; i < collisionShapes.size(); i++) 
	{
		btCollisionObject* obj = dynamicsWorld->getCollisionObjectArray()[i];
		btRigidBody* body = btRigidBody::upcast(obj);

		if (body && body->getMotionState()) 
		{
			btTransform trans;
			body->getMotionState()->getWorldTransform(trans);
			void* userPointer = body->getUserPointer();
			if (userPointer) 
			{
				_OP->GetObjectFromPool(body)->SetTransform(trans.getOrigin().getX(), trans.getOrigin().getY(), trans.getOrigin().getZ());
			}
		}
	}
}
