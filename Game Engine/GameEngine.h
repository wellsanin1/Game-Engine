#pragma once
#include "ObjectPool.h"
#include "EventSystem.h"
#include "KeyManager.h"
#include "AudioManager.h"
#include <iostream>
#include "LUAHelper.h"
#include "NetworkManager.h"
#include <LuaBridge/RefCountedPtr.h>

class GameEngine
{
public:
	GameEngine() {};
	virtual ~GameEngine() {};
	void Update();
	void CheckInput();
	void Initialise();
	void PhysicsUpdate();
	void Close();
	void Render();
	void Start();
	void Game();
	void Audio();
	void Network();
	void ObjectPoolUpdate();
	void Reload(int Level);
	void ExecuteEvents();

	void ExecuteLUA();
	void LoadEntitiesIntoEngine(int Level);
	EventQueue EQ;
	ObjectPool OP = ObjectPool();
	Renderer R = Renderer();
	AudioManager AM;
	Physics PM = Physics();
	KeyManager KM = KeyManager();
	LuaHelper LH = LuaHelper();
	NetworkManager NM = NetworkManager();
	//LUA interface
	void register_lua(lua_State* L)
	{
		using namespace luabridge;
		getGlobalNamespace(L)
			.beginNamespace("Engine")
			.beginClass<GameEngine>("GameEngine")
			.addFunction("GetLevelManager", &GameEngine::GetLevelManager)
			.addFunction("GetKeyManager", &GameEngine::GetKeyManager)
			.addFunction("GetGameObjectWithName", &GameEngine::GetGameObjectWithName)
			.addFunction("LoadEntitiesIntoEngine", &GameEngine::LoadEntitiesIntoEngine)
			.addFunction("LuaStringOUT", &GameEngine::LuaStringOUT)
			.addFunction("LuaIntOUT", &GameEngine::LuaIntOUT)
			.addFunction("Reload", &GameEngine::Reload)
			.endClass()
			.endNamespace();
	}

	//LUA interface functions
	KeyManager* GetKeyManager();
	LuaHelper* GetLevelManager();
	GameObject* GetGameObjectWithName(std::string Name);
	void LuaStringOUT(std::string Value);
	void LuaIntOUT(int Value);
};