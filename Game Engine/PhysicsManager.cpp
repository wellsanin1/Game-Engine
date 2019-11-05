//#include "PhysicsManager.h"
//
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
//
////void PhysicsManager::Collision(GameObject* ObjPool[PoolSize])
////{
////
////}
////void PhysicsManager::CreateRigidbody(GameObject* ObjPool[PoolSize])
////{
////
////}
//
//void PhysicsManager::Update(GameObject* ObjPool[PoolSize])
//{
//	Movement(ObjPool);
//}
//
//void Physics::initialise()
//{
//	//1
//	_broadphase = new btDbvtBroadphase();
//	//2
//	_collisionConfiguration = new btDefaultCollisionConfiguration();
//	_dispatcher = new btCollisionDispatcher(_collisionConfiguration);
//	//3
//	_solver = new btSequentialImpulseConstraintSolver();
//	//4
//	_world = new btDiscreteDynamicsWorld(_dispatcher, _broadphase, _solver, _collisionConfiguration);
//	//5
//	_world->setGravity(btVector3(0, -9.8, 0));
//}
//
//void Physics::dealloc()
//{
//	delete _world;
//	delete _solver;
//	delete _collisionConfiguration;
//	delete _dispatcher;
//	delete _broadphase;
//}