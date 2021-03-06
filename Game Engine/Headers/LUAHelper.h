#pragma once
#ifndef LUAHelper_H
#define LUAHelper_H

#include <string>
#include <vector>
#include <iostream>
#include "LuaStructs.h"
#include "EventSystem.h"

extern "C" {
# include "lua.h"
# include "lauxlib.h"
# include "lualib.h"
}
#include <LuaBridge/RefCountedPtr.h>
#include <LuaBridge/LuaBridge.h>
#include <lua.hpp>

class LuaHelper 
{
private:
	std::vector<std::string> elementList;
	std::vector<std::string> getElements(std::string& table, lua_State* L);
	lua_State* F = luaL_newstate();
	void report_errors(int state);
	EventQueue* _EQ;
public:
	lua_State* L();
	void * GetStateVoid();
	std::vector<LuaGenStruct*> entityList;
	LuaHelper();
	void LoadEntityData(int Level,EventQueue*EQ);
	~LuaHelper();
	void Dealloc();
	void ExecuteFile(const char* file);
	void ExecuteString(const char* expression);
	void Update(void* Engine);

	LuaHelper(const LuaHelper& other);  //non-construction copy
	LuaHelper& operator=(const LuaHelper&); //non-copy
	void RegisterEventQueue(EventQueue* EQ);
//LEVEL MANAGEMENT

void register_lua(lua_State* L)
{
	using namespace luabridge;
	getGlobalNamespace(L)
		.beginNamespace("Lua")
		.beginClass<LuaHelper>("LuaHelper")
		.addConstructor<void(*)(), luabridge::RefCountedPtr<LuaHelper>>()
		.addFunction("StartLevel", &LuaHelper::StartLevel)
		.addFunction("SetFinished", &LuaHelper::SetFinished)
		.addFunction("GetFinished", &LuaHelper::GetFinished)
		.addFunction("GetCurrentLevel", &LuaHelper::GetCurrentLevel)
		.endClass()
		.endNamespace();
}

public:
	int GetCurrentLevel();
	void StartLevel(int Level);
	bool GetFinished();
	void SetFinished(bool Value);
private:
	int CurrentLevel = 0;
	bool Finished = true;
};
#endif