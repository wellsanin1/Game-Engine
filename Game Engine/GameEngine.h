#pragma once

#include "OgreApplicationContext.h"
#include "OgreRTShaderSystem.h"
#include "ObjectPool.h"
#include "EventSystem.h"
#include "InputManager.h"
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
	bool CheckQueue(event::SubSystem CurrentEvent);
	EventQueue EQ;
	ObjectPool OP;
	//maybe goes in CheckInput();
	InputManager IM;
};