#pragma once
#include <SDL.h>
#include <SDL_keyboard.h>
#include <SDL_events.h>
#include "KeyPressEnum.h"
#include "EventSystem.h"
//#include "Event.h"
#include <iostream>
#include <map>

class KeyManager {
public:
	KeyPressEnum MapConvert(SDL_Keycode KeyCode);
	std::map<SDL_Keycode,KeyPressEnum> EnumMap;
	KeyManager();
	~KeyManager() {};
	void InputRead(EventQueue* EQ);
	event CreateEvent(SDL_Keycode KeyCode);
};