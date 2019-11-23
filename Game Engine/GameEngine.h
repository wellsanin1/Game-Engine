#pragma once
#include "ObjectPool.h"
#include "EventSystem.h"
#include "KeyManager.h"
#include "AudioManager.h"
#include <iostream>
#include "LUAHelper.h"
#include <LuaBridge/RefCountedPtr.h>

class GameEngine
{
private:
	bool Started = false;
public:
	GameEngine() {};
	virtual ~GameEngine() {};
	void Update();
	void CheckInput();
	void Initialise();
	void PhysicsUpdate();
	void Close();
	void Quit();
	void Render();
	void Start();
	void Game();
	void Audio();

	void StartLevel(int Level);
	bool LevelFinished();
	void SetLevelFinished();
	void ExecuteLUA();
	void LoadLevel(int Level);
	EventQueue EQ;
	ObjectPool OP = ObjectPool();
	Renderer R = Renderer();
	AudioManager AM;
	Physics PM = Physics();
	KeyManager KM = KeyManager();
	LuaHelper LH = LuaHelper();
	void register_lua(lua_State* L);

};