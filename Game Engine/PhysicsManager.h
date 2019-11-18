#pragma once
#include "btBulletDynamicsCommon.h"
#include "Bullet3Common/b3Vector3.h"
#include "GameEngineDefinitions.h"
#include "ObjectPool.h"
#include <iostream>
#include <vector>
#include <map>


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
	//ERROR IS HERE. Circular reference within this code.
	void PhysicsUpdate(ObjectPool* OP);
	void dealloc();
};