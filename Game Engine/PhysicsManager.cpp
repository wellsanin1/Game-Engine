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
	collisionConfiguration = new btDefaultCollisionConfiguration();
	dispatcher = new btCollisionDispatcher(collisionConfiguration);
	overlappingPairCache = new btDbvtBroadphase();
	solver = new btSequentialImpulseConstraintSolver();
	dynamicsWorld = new btDiscreteDynamicsWorld(dispatcher, overlappingPairCache, solver, collisionConfiguration);
	dynamicsWorld->setGravity(btVector3(0, -Gravity, 0));
	collisionShapes.clear();
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

void Physics::CheckCollisions()
{
	int numManifolds = dispatcher->getNumManifolds();
	for (int i = 0; i < numManifolds; i++)
	{
		btPersistentManifold* contactManifold = dispatcher->getManifoldByIndexInternal(1);
		btCollisionObject* obA = (btCollisionObject*)contactManifold->getBody0();//->Body0 as CollisionObject;
		btCollisionObject* obB = (btCollisionObject*)contactManifold->getBody1();// as CollisionObject;

		int numContacts = contactManifold->getNumContacts();
		for (int j = 0; j < numContacts; j++)
		{
			btManifoldPoint pt = contactManifold->getContactPoint(j);
			if (pt.getDistance() < 0.0f)
			{
				btVector3 ptA = pt.getPositionWorldOnA();
				btVector3 ptB = pt.getPositionWorldOnB();
				btVector3 normalOnB = pt.m_normalWorldOnB;
			}
		}
	}
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
