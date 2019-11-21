#include "LUAHelper.h"

LuaHelper::LuaHelper(const std::string& filename)
{
	L = luaL_newstate();
	if (luaL_loadfile(L, filename.c_str()) || lua_pcall(L, 0, 0, 0)) {
		std::cout << "Error: script not loaded (" << filename << ")" << std::endl;
		L = 0;
	}
}

LuaHelper::~LuaHelper()
{
	if (L) lua_close(L);
}

void LuaHelper::printError(const std::string& variableName, const std::string& reason)
{
	std::cout << "Error: can't get [" << variableName << "]. " << reason << std::endl;
}

template<typename T>
T LuaHelper::get(const std::string& variableName) 
{
	if (!L) {
		printError(variableName, "Script is not loaded");
		return lua_getdefault<T>();
	}

	T result;
	if (lua_gettostack(variableName)) { // variable succesfully on top of stack
		result = lua_get<T>(variableName);
	}
	else {
		result = lua_getdefault<T>();
	}

	lua_pop(L, level + 1); // pop all existing elements from stack
	return result;
}
