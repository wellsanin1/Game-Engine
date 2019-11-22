#pragma once
#include "ObjectPool.h"
#include "EventSystem.h"
#include "KeyManager.h"
#include "AudioManager.h"
#include <iostream>
#include "LUAHelper.h"

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
	void Audio();
	void Game();
	void LuaTestFunction();
	void ExecuteLUA();
	EventQueue EQ;
	ObjectPool OP = ObjectPool();
	Renderer R = Renderer();
	AudioManager AM;
	Physics PM = Physics();
	KeyManager KM = KeyManager();
	LuaHelper LH = LuaHelper();
	static void register_lua(lua_State* L);

};