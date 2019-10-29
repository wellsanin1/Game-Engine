#pragma once
#include <SDL.h>
#include <SDL_keyboard.h>
#include <SDL_events.h>
#include <iostream>
#include <map>
//#include "KeyPress.h"
class KeyManager {
private:
	enum KeyPressEnum
	{
		NONE,
		UP,
		DOWN,
		LEFT,
		RIGHT,
		QUIT
	};
	KeyPressEnum MapConvert(SDL_Keycode KeyCode);
public:
	std::map<SDL_Keycode,KeyPressEnum> EnumMap;
	KeyManager();
	~KeyManager() {};
	KeyPressEnum KeyArray[40];
	void AddInput(SDL_Keycode KeyCode);
	void InputClearKeys();
	void DisplayKeys();
};

KeyManager::KeyManager()
{
	EnumMap = { {::SDLK_UP,UP}
				,{::SDLK_DOWN,DOWN}
				,{::SDLK_LEFT,LEFT}
				,{::SDLK_RIGHT,RIGHT}
				,{::SDLK_ESCAPE,QUIT}
	};
};

KeyManager::KeyPressEnum KeyManager::MapConvert(SDL_Keycode KeyCode)
{
	KeyPressEnum KeyPressed = EnumMap.at(KeyCode);
	return(KeyPressed);
};

void KeyManager::DisplayKeys()
{
	int size = sizeof(KeyArray) / sizeof(*KeyArray);
	for (int i = 0; i < size; i++)
	{
		std::cout << KeyArray[i] + " ";
	}
}

void KeyManager::AddInput(SDL_Keycode KeyCode)
{
	KeyPressEnum ConvertedEnum = MapConvert(KeyCode);
	int size = sizeof(KeyArray) / sizeof(*KeyArray);
	for (int i = 0; i < size; i++)
	{
		if (KeyArray[i] == NONE)
		{
			KeyArray[i] = ConvertedEnum;
			return;
		}
	}
};

void KeyManager::InputClearKeys()
{
	int size = sizeof(KeyArray) / sizeof(*KeyArray);
	for (int i = 0; i < size; i++)
	{
		KeyArray[i] = NONE;
	}
	return;
}
