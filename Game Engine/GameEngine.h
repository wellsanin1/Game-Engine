#pragma once
#include "OgreApplicationContext.h"
#include "OgreRTShaderSystem.h"
#include "ObjectPool.h"
#include "EventSystem.h"
#include "KeyManager.h"
#include "AudioManager.h"
#include "PhysicsManager.h"
#include <iostream>

class GameEngine : public EventQueue, public OgreBites::ApplicationContext
{
public:
	GameEngine();
	virtual ~GameEngine() {};
	void setup();
	void Update();
	void CheckInput();
	void Initialise();
	void PhysicsUpdate();
	void Close();
	void Quit();
	void Render();
	void Audio();
	void renderOneFrame();
	EventQueue EQ = EventQueue();
	ObjectPool OP = ObjectPool();
	AudioManager AM = AudioManager();
	//PhysicsManager PM;
	Physics PM = Physics();
	//maybe goes in CheckInput();
	KeyManager KM = KeyManager();
};