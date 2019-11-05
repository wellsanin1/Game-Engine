#pragma once
#include <btBulletDynamicsCommon.h>
#include "ObjectPool.h"

class PhysicsManager
{
	ObjectPool* ObjPool;
public:
	PhysicsManager() {};
	~PhysicsManager() {};
	void Movement(ObjectPool* OP);
	void GetObjectPool(ObjectPool* EnginePool);
	void Collision();
	void CreateRigidbody();
};