#include "PhysicsManager.h"

void Physics::dealloc()
{
	delete dynamicsWorld;
	delete solver;
	delete collisionConfiguration;
	delete dispatcher;
	delete overlappingPairCache;
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

void Physics::PhysicsUpdate(ObjectPool* OP)
{
		dynamicsWorld->stepSimulation(1.0f / (float)PhysicsPollRate); //suppose you have 60 frames per second
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
					OP->GetObject(body)->SetTransform(trans.getOrigin().getX(), trans.getOrigin().getY(), trans.getOrigin().getZ());
				}
			}
		}
	}
