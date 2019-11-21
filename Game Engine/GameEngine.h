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
	void CreateEntity(std::string Name, std::string MeshName, int PosX, int PosY, int PosZ);
	void CreateLight(std::string Name, int PosX, int PosY, int PosZ);
	void CreateCamera(std::string Name, int PosX, int PosY, int PosZ);
	EventQueue EQ;
	ObjectPool OP = ObjectPool();
	Renderer R = Renderer();
	AudioManager AM;
	Physics PM = Physics();
	KeyManager KM = KeyManager();
	LuaHelper LH = LuaHelper();
};