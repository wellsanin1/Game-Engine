#pragma once
#include "KeyInput.h"

class InputManager : KeyManager
{
public:
	InputManager() {};
	~InputManager() {};
	void GetKeyHeld() {};
	void InputRead();
	void ClearKeys();
	bool GetKey(KeyPressEnum Key);
};