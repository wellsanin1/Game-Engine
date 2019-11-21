#pragma once
#include <string>
struct LuaEntity
{
	LuaEntity() {};
	~LuaEntity() {};
	std::string Name;
	std::string Mesh;
	int x = 0;
	int y = 0;
	int z = 0;
};
struct LuaLight
{
	LuaLight() {};
	~LuaLight() {};
	std::string Name;
	int x = 0;
	int y = 0;
	int z = 0;
};
struct LuaCamera
{
	LuaCamera() {};
	~LuaCamera() {};
	std::string Name;
	int x = 0;
	int y = 0;
	int z = 0;
};
struct LuaGenStruct
{
	LuaGenStruct() {};
	~LuaGenStruct() {};
	std::string UnionType;
	union LuaGeneric
	{
		LuaGeneric() {};
		~LuaGeneric() {};
		LuaLight* Light;
		LuaCamera* Camera;
		LuaEntity* Entity;
	};
	LuaGeneric GenericStore;
};