#pragma once
#include "KeyInput.h"


class InputManager : KeyManager
{
public:
	InputManager() 
	{ 	
		int i = 0; 
	};
	~InputManager() {};
	void GetKeyDown(SDL_Event Key) ;
	void GetKeyUp(SDL_Event Key) ;
	void GetKeyHeld() {};
	void InputRead();
	void ClearKeys();
};

void InputManager::InputRead()
{
	SDL_Event event;
	while (SDL_PollEvent(&event)) {
		switch (event.type)
		{
		case SDL_KEYDOWN:
			GetKeyDown(event);
			break;
		case SDL_KEYUP:
			GetKeyUp(event);
			break;
		}
	}
	return;
};

void InputManager::ClearKeys()
{
	KeyManager::InputClearKeys();
};

void InputManager::GetKeyDown(SDL_Event Key)
{
};
void InputManager::GetKeyUp(SDL_Event Key)
{
};