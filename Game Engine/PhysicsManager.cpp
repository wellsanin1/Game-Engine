#include "PhysicsManager.h"

//void PhysicsManager::Movement(GameObject* ObjPool[PoolSize])
//{
//	for (int i = 0; i < PoolSize; ++i)
//	{
//		if (ObjPool[i]->IsEmpty() == false)
//		{
//			ObjPool[i]->Node->translate(ObjPool[i]->Velocity[0], ObjPool[i]->Velocity[1], ObjPool[i]->Velocity[2]);
//		}
//	}
//}

//void PhysicsManager::Collision(GameObject* ObjPool[PoolSize])
//{
//
//}
//void PhysicsManager::CreateRigidbody(GameObject* ObjPool[PoolSize])
//{
//
//}

//void Physics::dealloc()
//{
//	delete dynamicsWorld;
//	delete solver;
//	delete collisionConfiguration;
//	delete dispatcher;
//	delete overlappingPairCache;
//}

Physics::Physics()
{
	collisionConfiguration = new btDefaultCollisionConfiguration();
	dispatcher = new btCollisionDispatcher(collisionConfiguration);
	overlappingPairCache = new btDbvtBroadphase();
	solver = new btSequentialImpulseConstraintSolver();
	dynamicsWorld = new btDiscreteDynamicsWorld(dispatcher, overlappingPairCache, solver, collisionConfiguration);
	dynamicsWorld->setGravity(btVector3(0, -9.81, 0));
}

void Physics::PhysicsUpdate()
{
		dynamicsWorld->stepSimulation(1.0f / 60.0f); //suppose you have 60 frames per second
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

					btQuaternion orientation = trans.getRotation();
					Ogre::SceneNode* sceneNode = static_cast<Ogre::SceneNode*>(userPointer);
					sceneNode->setPosition(Ogre::Vector3(trans.getOrigin().getX(), trans.getOrigin().getY(), trans.getOrigin().getZ()));
					sceneNode->setOrientation(Ogre::Quaternion(orientation.getW(), orientation.getX(), orientation.getY(), orientation.getZ()));
				}
			}
		}
	}
