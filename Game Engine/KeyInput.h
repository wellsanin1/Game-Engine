#pragma once
#include <SDL.h>
#include <SDL_keyboard.h>
#include <SDL_events.h>
#include <iostream>
#include <map>

class KeyManager {
public:
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
	std::map<SDL_Keycode,KeyPressEnum> EnumMap;
	KeyManager();
	~KeyManager() {};
	KeyPressEnum KeyArray[20];
	void AddInput(SDL_Keycode KeyCode);
	void InputClearKeys();
};