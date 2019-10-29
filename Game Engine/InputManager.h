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
	KeyManager::KeyArray;
};

void InputManager::InputRead()
{
	SDL_Event event;
	while (SDL_PollEvent(&event)) 
	{
		switch (event.type)
		{
		case SDL_KEYDOWN:
			AddInput(event.key.keysym.sym);
			break;
		case SDL_KEYUP:
			AddInput(event.key.keysym.sym);
			break;
		}
	}
	return;
};

bool InputManager::GetKey(KeyPressEnum Key)
{
	int size = sizeof(KeyArray) / sizeof(*KeyArray);
	for (int i =0;i<size;++i)
	{
		if (Key == KeyArray[i])
		{
			return true;
		}
	}
	return false;
};

void InputManager::ClearKeys()
{
	KeyManager::InputClearKeys();
};