#pragma once
#include "ObjectPool.h"
#include "EventSystem.h"
#include "KeyManager.h"
#include "AudioManager.h"
#include <iostream>

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
	void Quit();
	void Render();
	void Start();
	void Audio();
	void renderOneFrame();
	void Game();


	void CreateEntity(std::string Name, std::string MeshName);
	void CreateLight(std::string Name);
	void CreateCamera(std::string Name);

	EventQueue EQ;
	ObjectPool OP = ObjectPool();
	Renderer R = Renderer();
	AudioManager AM;
	Physics PM = Physics();
	KeyManager KM = KeyManager();
};