#pragma once
#ifndef LUASCRIPT_H
#define LUASCRIPT_H

#include <string>
#include <vector>
#include <iostream>

extern "C" {
# include "lua.h"
# include "lauxlib.h"
# include "lualib.h"
}

class LuaHelper {
public:
	LuaHelper(const std::string& filename);
	~LuaHelper();
	void printError(const std::string& variableName, const std::string& reason);

	template<typename T>
	T get(const std::string& variableName) {
		// will be implemented later in tutorial
	}
	bool lua_gettostack(const std::string& variableName) {
		// will be explained later too
	}
	// Generic get
	template<typename T>
	T lua_get(const std::string& variableName) {
		return 0;
	}
	// Generic default get
	template<typename T>
	T lua_getdefault(const std::string& variableName) {
		return 0;
	}
	template<typename T>
	T get(const std::string& variableName);

	private:
		lua_State* L;
};

#endif