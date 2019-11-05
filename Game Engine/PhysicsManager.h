//#pragma once
//#include <btBulletDynamicsCommon.h>
//#include "GameEngineDefinitions.h"
//#include "GameObject.h"
//#include <iostream>
//
//class PhysicsManager
//{
//
//public:
//	PhysicsManager() {};
//	~PhysicsManager() {};
//	void Movement(GameObject* ObjPool[PoolSize]);
//	//void Collision(GameObject* ObjPool[PoolSize]);
//	//void CreateRigidbody(GameObject* ObjPool[PoolSize]);
//	void Update(GameObject* ObjPool[PoolSize]);
//};
//
////class Physics {
////	btDefaultCollisionConfiguration* collisionConfiguration;
////	btCollisionDispatcher* dispatcher;
////	btBroadphaseInterface* overlappingPairCache;
////	btSequentialImpulseConstraintSolver* solver;
////	btDiscreteDynamicsWorld* dynamicsWorld;
////	std::vector<btCollisionShape*> collisionShapes;
////	std::map<std::string, btRigidBody*> physicsAccessors;
////public:
////	void initObjects();
////};
//
////void Physics::initObjects() {
////	collisionConfiguration = new btDefaultCollisionConfiguration();
////	dispatcher = new btCollisionDispatcher(collisionConfiguration);
////	overlappingPairCache = new btDbvtBroadphase();
////	solver = new btSequentialImpulseConstraintSolver();
////	dynamicsWorld = new btDiscreteDynamicsWorld(dispatcher, overlappingPairCache, solver, collisionConfiguration);
////}
//
//class Physics {
//	//Skipped...
//
//	//New variables
//	btBroadphaseInterface* _broadphase;
//	btDefaultCollisionConfiguration* _collisionConfiguration;
//	btCollisionDispatcher* _dispatcher;
//	btSequentialImpulseConstraintSolver* _solver;
//	btDiscreteDynamicsWorld* _world;
//public:
//	void initialise();
//	void dealloc();
//};