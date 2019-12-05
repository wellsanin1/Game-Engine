#pragma once
#include "ObjectPool.fwd.h"
#include "GameObject.fwd.h"
#include "PhysicsManager.fwd.h"
#include "LUAHelper.fwd.h"
#include "Renderer.fwd.h"

#include "EventSystem.h"
#include <Ogre.h>

#include "EventSystem.h"
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
	//same logic returns nullptr if doesn't exist
	GameObject* GetObjectFromPool(std::string ObjectName);
	//same logic returns blank GameObject if doesn't exist
	GameObject* IfObjectExists(std::string ObjectName);
	void CreateCamera(ObjectPoolData OP,EventQueue*EQ);
	void CreateEntity(ObjectPoolData OP, EventQueue* EQ);
	void CreateLight(ObjectPoolData OP, EventQueue* EQ);
	void Reinitialise();
	void DeallocPool();
	void Update(EventQueue* EQ, void*LuaState);
	typedef void (ObjectPool::* Reactions)(ObjectPoolData,EventQueue*);
	Reactions EventReactions[3] = { &ObjectPool::CreateEntity
									,& ObjectPool::CreateCamera
									,& ObjectPool::CreateLight};
};