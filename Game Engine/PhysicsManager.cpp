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
	int mass = 10;
	btCollisionShape* newRigidShape = new btBoxShape({PD.Colliders.x,PD.Colliders.y,PD.Colliders.z});
	newRigidShape->calculateLocalInertia(mass, btVector3({ 0,0,0 }));
	btMotionState* myMotionState = new btDefaultMotionState(NewTransform);
	btRigidBody::btRigidBodyConstructionInfo BodyInfo(mass, myMotionState, newRigidShape, btVector3({ 0,0,0 }));
	btRigidBody* Bdy = new btRigidBody(BodyInfo);
	collisionShapes.push_back(newRigidShape);
	dynamicsWorld->addRigidBody(Bdy);
	physicsAccessors.insert({ PD.Name,Bdy });
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

Physics::Physics()
{
	collisionConfiguration = new btDefaultCollisionConfiguration();
	dispatcher = new btCollisionDispatcher(collisionConfiguration);
	overlappingPairCache = new btDbvtBroadphase();
	solver = new btSequentialImpulseConstraintSolver();
	dynamicsWorld = new btDiscreteDynamicsWorld(dispatcher, overlappingPairCache, solver, collisionConfiguration);
	dynamicsWorld->setGravity(btVector3(0, -Gravity, 0));
}

void Physics::CheckCollisions(ObjectPool* OP)
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
			GameObject* A = OP->GetObjectFromPool(bodyA);
			GameObject* B = OP->GetObjectFromPool(bodyB);
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

void Physics::PhysicsUpdate(ObjectPool* OP,EventQueue* EQ)
{
	EventQueue E = EventQueue();
	E = EQ[0];
	event EV = E.CheckQueueReturnEvent(SubSystem_Physics);
	for (int i= 0;i<EV.SubSystemList.size();++i)
	{
		if (EV.SubSystemList.at(i) == SubSystem_Physics)
		{
			Reactions A = EventReactions[(int)EV.EventType];
			(this->*A)(EV.PD);
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
				OP->GetObjectFromPool(body)->SetTransform(trans.getOrigin().getX(), trans.getOrigin().getY(), trans.getOrigin().getZ());
			}
		}
	}
}
