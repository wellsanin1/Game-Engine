#include "PhysicsManager.h"

void Physics::dealloc()
{
	delete dynamicsWorld;
	delete solver;
	delete collisionConfiguration;
	delete dispatcher;
	delete overlappingPairCache;
}

void Physics::Restart()
{
	//clear all information for loading later generic bullet ones
	collisionConfiguration = new btDefaultCollisionConfiguration();
	dispatcher = new btCollisionDispatcher(collisionConfiguration);
	overlappingPairCache = new btDbvtBroadphase();
	solver = new btSequentialImpulseConstraintSolver();
	dynamicsWorld = new btDiscreteDynamicsWorld(dispatcher, overlappingPairCache, solver, collisionConfiguration);
	dynamicsWorld->setGravity(btVector3(0, -Gravity, 0));

	//Clear all accessors for gameobjects
	physicsAccessors.erase(physicsAccessors.begin(), physicsAccessors.end());
	ReversePhysicsAccessors.erase(ReversePhysicsAccessors.begin(), ReversePhysicsAccessors.end());
	collisionShapes.clear();
}

void Physics::CreateEntity(PhysicsData PD)
{
	//create entity data in bullet, works for lights cameras and entities becaues they are all treated the same in bullet
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
	ReversePhysicsAccessors.insert({ Bdy,PD.Name });

	//attach to gameobject. done this way because of time constraints
	std::cout << "created Physics obj with name: " << PD.Name << std::endl;
}

void Physics::SetMass(PhysicsData PD)
{
	//set mass of object, remove object then re-add it. Setting 0 makes an object static
	btRigidBody* RB = physicsAccessors.at(PD.Name);

	physicsAccessors.erase(PD.Name);
	ReversePhysicsAccessors.erase(RB);
	dynamicsWorld->removeRigidBody(RB);

	for (int i = 0; i < collisionShapes.size(); ++i)
	{
		if (collisionShapes[i] == RB->getCollisionShape())
		{
			collisionShapes.erase(collisionShapes.begin() + i);
		}
	}

	RB->getCollisionShape()->calculateLocalInertia(PD.mass, RB->getLocalInertia());
	btRigidBody::btRigidBodyConstructionInfo BodyInfo(PD.mass, RB->getMotionState(), RB->getCollisionShape(),RB->getLocalInertia());

	btRigidBody* RB2 = new btRigidBody(BodyInfo);

	collisionShapes.push_back(RB2->getCollisionShape());
	dynamicsWorld->addRigidBody(RB2);
	physicsAccessors.insert({PD.Name, RB2});
	ReversePhysicsAccessors.insert({ RB2,PD.Name });
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
	btTransform Transform;
	Transform.setOrigin({ PD.positions.x,PD.positions.y,PD.positions.z });
	btRigidBody* RB = physicsAccessors.at(PD.Name);
	RB->setWorldTransform(Transform);
	RB->getMotionState()->setWorldTransform(Transform);
}

void Physics::SetGravity(PhysicsData PD)
{
	//different from static still moves when collided with but doesn't get affected by gravity
	physicsAccessors.at(PD.Name)->setGravity({ PD.GenericVector.x,PD.GenericVector.y,PD.GenericVector.z });
}

Physics::Physics(ObjectPool* OP,EventQueue*EQ)
{
	//takes in object pool for interfacing with gameobject
	_EQ = EQ;
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
	//collision loop

	//numManifolds = number of close to collisions
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
			//need to access gameobject through body requires name
			GameObject* A = _OP->GetObjectFromPool(ReversePhysicsAccessors.at(bodyA));
			GameObject* B = _OP->GetObjectFromPool(ReversePhysicsAccessors.at(bodyB));
			btManifoldPoint pt = contactManifold->getContactPoint(j);
			//if collided
			if (pt.getDistance() < 0.0f)
			{
				//lets you see where an object has collided. Not currently using them
				//basic collision
				A->AddCollision(B->Name);
				B->AddCollision(A->Name);
			}
			else
			{
				//if not collided
				A->ClearCollision(B->Name);
				B->ClearCollision(A->Name);
			}
		}
	}
}

void Physics::PhysicsUpdate(EventQueue* EQ)
{
	//function pointer loop
	for (int i = 0;i<EQ->Queue.size();++i)
	{
		event EV = EQ->CheckQueueReturnEvent(SubSystem_Physics);
		if (EV.Empty == false)
		{
			Reactions A = EventReactions[(int)EV.PhysicsEventType];
			(this->*A)(EV.PD);
			EQ->RemoveFromQueue(SubSystem_Physics);
		}
		else
		{
			break;
		}

	}

	//how much the simulation is moving each time, lower is more distance.
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
			//sets vector in gameobject
			_OP->GetObjectFromPool(ReversePhysicsAccessors.at(body))->SetTransform(trans.getOrigin().getX(), trans.getOrigin().getY(), trans.getOrigin().getZ());
			std::cout << "test";
		}
	}
}
