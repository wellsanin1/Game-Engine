#pragma once
#include <SDL.h>
#include <SDL_keyboard.h>
#include <SDL_events.h>
#include "EventEnum.h"
#include "EventSystem.h"
#include <iostream>
#include <map>

class KeyManager {
public:
	EventEnum MapConvert(SDL_Keycode KeyCode);
	std::map<SDL_Keycode, EventEnum> EnumMap;
	KeyManager();
	~KeyManager() {};
	void InputRead(EventQueue* EQ);
	event CreateEvent(EventEnum KeyPressed);
};