#pragma once
#include <SDL.h>
#include <SDL_keyboard.h>
#include <SDL_events.h>
#include "EventEnum.h"
#include "EventSystem.h"
#include <iostream>
#include <map>

//LUA Includes required because doesnt like linking from LUAHelper
#include "LUAHelper.h"
extern "C" {
# include "lua.h"
# include "lauxlib.h"
# include "lualib.h"
}
#include <LuaBridge/RefCountedPtr.h>
#include <LuaBridge/LuaBridge.h>
#include <lua.hpp>

class KeyManager {
public:
	EventQueue* _EQ;
	EventEnum MapConvert(SDL_Keycode KeyCode);
	std::map<SDL_Keycode, EventEnum> EnumMap;
	KeyManager();
	~KeyManager() {};
	void InputRead();
	event CreateEvent(EventEnum KeyPressed);
	void Initiate(lua_State* F, EventQueue* EQ);
	//LUA REGISTRATION AND FUNCTIONS
	void register_lua(lua_State* L)
	{
		using namespace luabridge;
		getGlobalNamespace(L)
			.beginNamespace("Key")
			.beginClass<KeyManager>("KeyManager")
			.addFunction("GetKey", &KeyManager::GetKey)
			.endClass()
			.endNamespace();
	}
	bool GetKey(int Input);
};