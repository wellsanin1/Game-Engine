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

class LuaHelper 
{
	std::vector<std::string> elementList;
	std::vector<std::string> getElements(std::string& table, lua_State* L);
	lua_State* F = luaL_newstate();
public:
	std::vector<LuaGenStruct*> entityList;
	LuaHelper();
	~LuaHelper();
};
#endif