#pragma once
#include "ObjectPool.fwd.h"
#include "GameObject.fwd.h"
#include "PhysicsManager.fwd.h"

#include <Ogre.h>

#include "LuaStructs.h"
extern "C" {
# include "lua.h"
# include "lauxlib.h"
# include "lualib.h"
}
#include <LuaBridge/LuaBridge.h>
#include <lua.hpp>

#include "GameObject.h"
#include "Renderer.h"
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
	void CreateCamera(std::string Name, int PosX, int PosY, int PosZ, Physics* PM, Renderer* R, LuaHelper* LH);
	void CreateEntity(std::string Name, std::string MeshName, std::string MaterialName, int PosX, int PosY, int PosZ, int ColX, int ColY, int ColZ, Physics* PM, Renderer* R, LuaHelper* LH);
	void CreateLight(std::string Name, int PosX, int PosY, int PosZ, Physics* PM, Renderer* R, LuaHelper* LH);
	void Reinitialise();
	void ClearPool(Renderer* R, Physics* PM);
};