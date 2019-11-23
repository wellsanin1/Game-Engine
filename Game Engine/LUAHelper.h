#pragma once
#ifndef LUAHelper_H
#define LUAHelper_H

#include <string>
#include <vector>
#include <iostream>
#include "LuaStructs.h"

extern "C" {
# include "lua.h"
# include "lauxlib.h"
# include "lualib.h"
}
#include <LuaBridge/LuaBridge.h>
#include <lua.hpp>

class LuaHelper 
{
private:
	std::vector<std::string> elementList;
	std::vector<std::string> getElements(std::string& table, lua_State* L);
	lua_State* F = luaL_newstate();
	void report_errors(int state);
public:
	lua_State* L();
	std::vector<LuaGenStruct*> entityList;
	LuaHelper();
	void Load(int Level);
	~LuaHelper();
	void ExecuteFile(const char* file);
	void ExecuteString(const char* expression);
	LuaHelper(const LuaHelper& other);  //non-construction copy
	LuaHelper& operator=(const LuaHelper&); //non-copy

//LEVEL MANAGEMENT

public:
	int CurrentLevel = 0;
	void StartLevel(int Level);
	bool IsFinished();
	void SetFinished(bool Value);
private:
	bool Finished = false;
};
#endif