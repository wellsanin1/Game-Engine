#pragma once
#include "ObjectPool.fwd.h"
#include "GameObject.fwd.h"
#include "PhysicsManager.fwd.h"

#include <Ogre.h>
#include "GameObject.h"
#include "GameEngineDefinitions.h"
#include <iostream>

class ObjectPool
{
public:
	ObjectPool();
	GameObject* PoolStorage[PoolSize];
	virtual ~ObjectPool() {};
	void StoreObject(GameObject* Object);
	GameObject* GetObject(Ogre::String ObjectName);
	GameObject* GetObject(btRigidBody* RigidBody);
};