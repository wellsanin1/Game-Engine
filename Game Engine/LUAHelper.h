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
	//Execute Lua File
	void ExecuteFile(const char* file);
	//Execute Lua Expression (contained in string)
	void ExecuteString(const char* expression);
	//LuaHelper(void) : F(luaL_newstate()) { luaL_openlibs(F); }
	LuaHelper(const LuaHelper& other);  //non-construction copy
	LuaHelper& operator=(const LuaHelper&); //non-copy
	//~LuaHelper(void) { lua_close(F); } //Destructor clean-up
};
#endif