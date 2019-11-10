#pragma once
#include "btBulletDynamicsCommon.h"
#include "Bullet3Common/b3Vector3.h"
#include "GameEngineDefinitions.h"
#include "GameObject.h"
#include <iostream>

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

class Physics {
public:
	Physics();
	~Physics() {};
	btDefaultCollisionConfiguration* collisionConfiguration;
	btCollisionDispatcher* dispatcher;
	btBroadphaseInterface* overlappingPairCache;
	btSequentialImpulseConstraintSolver* solver;
	btDiscreteDynamicsWorld* dynamicsWorld;
	std::vector<btCollisionShape*> collisionShapes;
	std::map<std::string, btRigidBody*> physicsAccessors;
	void PhysicsUpdate();
	//void initialise();
	//void dealloc();
};