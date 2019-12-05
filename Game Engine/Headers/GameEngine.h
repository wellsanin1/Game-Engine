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
	bool _Active = false;
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
	void PlayAudio(std::string FileName);
	void Network();
	void ObjectPoolUpdate();
	void Reload(int Level);
	void ExecuteLUA();
	void LoadEntitiesIntoEngine(int Level);
	void Quit();
	bool IsActive();
	void EngineDrawText(int position, std::string TEXT,std::string Name);
	void EngineStopDrawingText(std::string Name);
	float GetFPS();
	void PlayAnimation(std::string Name,std::string Animation);
	

	EventQueue EQ;
	ObjectPool OP = ObjectPool();
	AudioManager AM;
	Physics PM = Physics(&OP);
	Renderer R = Renderer(&OP);
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
			.addFunction("PlayAudio", &GameEngine::PlayAudio)
			.addFunction("Quit", &GameEngine::Quit)
			.addFunction("EngineDrawText", &GameEngine::EngineDrawText)
			.addFunction("EngineStopDrawingText", &GameEngine::EngineStopDrawingText)
			.addFunction("GetFPS", &GameEngine::GetFPS)
			.addFunction("PlayAnimation", &GameEngine::PlayAnimation)
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