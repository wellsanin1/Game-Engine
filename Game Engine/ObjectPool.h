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
	GameObject* GetObjectFromPool(std::string ObjectName);
	GameObject* GetObjectFromPool(btRigidBody* RigidBody);
	void CreateCamera(std::string Name, int PosX, int PosY, int PosZ
						, Physics* PM, Renderer* R, LuaHelper* LH, NetworkManager* NM);
	void CreateEntity(std::string Name, std::string MeshName, std::string MaterialName, int PosX, int PosY, int PosZ, int ColX, int ColY, int ColZ
						,Physics* PM, Renderer* R, LuaHelper* LH, NetworkManager* NM);
	void CreateLight(std::string Name, int PosX, int PosY, int PosZ
						,Physics* PM, Renderer* R, LuaHelper* LH, NetworkManager* NM);
	void Reinitialise();
	void ClearPool(Renderer* R, Physics* PM);
	void Update(EventQueue* EQ, Physics* PM, Renderer* R, LuaHelper* LH,NetworkManager* NM);
};