#pragma once

#include "OgreApplicationContext.h"
#include "OgreRTShaderSystem.h"
#include "ObjectPool.h"
#include "EventSystem.h"
#include "KeyManager.h"
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
	void Close();
	void Quit();
	void Render();
	void renderOneFrame();
	EventEnum CheckQueue(event::SubSystem CurrentEvent);
	EventQueue EQ;
	ObjectPool OP;
	//maybe goes in CheckInput();
	KeyManager KM;
};