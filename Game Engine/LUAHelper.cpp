#include "LUAHelper.h"

LuaHelper::LuaHelper()
{
	luaL_dofile(F, "Game.lua");
	luaL_openlibs(F);
	register_lua(F);
}

void LuaHelper::LoadEntityData(int Level , EventQueue*EQ)
{
	entityList.clear();
	elementList.clear();
	std::string LevelString = std::string("Level") + std::to_string(Level)+std::string(".lua");
	luaL_dofile(F, LevelString.c_str());
	luaL_openlibs(F);
	lua_pcall(F, 0, 0, 0);
	elementList = getElements((std::string)"elementList", F);
	luabridge::LuaRef elementsRef = luabridge::getGlobal(F, "elementList");
	std::string checker;
	for (int i = 0; i < elementList.size(); i++)
	{
		luabridge::LuaRef entityCheck = elementsRef[elementList[i]];
		checker = entityCheck["e_type"].cast<std::string>();
		if (checker == "Camera")
		{
			event E;
			E.SubSystemList.push_back(SubSystem_ObjectPool);
			E.ObjectPoolEventEnum = ObjectPool_CREATECAMERA;
			E.OD.Name = entityCheck["name"].cast<std::string>();
			E.OD.positions.x = entityCheck["PosX"].cast<int>();
			E.OD.positions.y = entityCheck["PosY"].cast<int>();
			E.OD.positions.z = entityCheck["PosZ"].cast<int>();
			E.Empty = false;
			EQ->AddEvent(E);
		}
		if (checker == "Light")
		{
			LuaGenStruct::LuaGeneric GenEnt = entityList[i]->GenericStore;
			event E;
			E.SubSystemList.push_back(SubSystem_ObjectPool);
			E.ObjectPoolEventEnum = ObjectPool_CREATELIGHT;
			E.OD.Name = entityCheck["name"].cast<std::string>();
			E.OD.positions.x = entityCheck["PosX"].cast<int>();
			E.OD.positions.y = entityCheck["PosY"].cast<int>();
			E.OD.positions.z = entityCheck["PosZ"].cast<int>();
			E.Empty = false;
			EQ->AddEvent(E);
		}
		if (checker == "Entity")
		{
			event E;
			E.SubSystemList.push_back(SubSystem_ObjectPool);
			E.ObjectPoolEventEnum = ObjectPool_CREATEENTITY;

			E.OD.MeshName = entityCheck["mesh"].cast<std::string>();
			E.OD.Name = entityCheck["name"].cast<std::string>();
			E.OD.Material = entityCheck["material"].cast<std::string>();

			E.OD.positions.x = entityCheck["PosX"].cast<int>();
			E.OD.positions.y = entityCheck["PosY"].cast<int>();
			E.OD.positions.z = entityCheck["PosZ"].cast<int>();

			E.OD.Colliders.x = entityCheck["ColX"].cast<int>();
			E.OD.Colliders.y = entityCheck["ColY"].cast<int>();
			E.OD.Colliders.z = entityCheck["ColZ"].cast<int>();
			E.Empty = false;
			EQ->AddEvent(E);
		}
	}

	return;
}

LuaHelper::~LuaHelper()
{
}

void LuaHelper::Dealloc()
{
	lua_close(F);
}

std::vector<std::string> LuaHelper::getElements(std::string& table, lua_State* L)
{
	std::string source =
		"function getElements(table) "
		"s = \"\""
		"for k, v in pairs(_G[table]) do "
		"    s = s..k..\"|\" "
		"    end "
		"return s "
		"end";

	luaL_loadstring(L, source.c_str());
	lua_pcall(L, 0, 0, 0);
	lua_getglobal(L, "getElements");
	lua_pushstring(L, table.c_str());
	lua_pcall(L, 1, 1, 0);

	std::string ans = lua_tostring(L, -1);
	std::vector<std::string> elements;
	std::string temp = "";
	for (unsigned int i = 0; i < ans.size(); i++) {
		if (ans[i] != '|') {
			temp += ans[i];
		}
		else {
			elements.push_back(temp);
			temp = "";
		}
	}

	/* We clean up after ourselves as best we can. */

	int n = lua_gettop(L);
	lua_pop(L, 1);

	/* Lastly, return the list of elements. With thanks to Elias Daler.*/

	return elements;
}

//returns lua state object
lua_State* LuaHelper::L()
{
	return F;
}

void* LuaHelper::GetStateVoid()
{
	return F;
}

//helper function to report errors in evaluated lua scripts
void LuaHelper::report_errors(int state)
{
	if (state != 0)
	{
		std::cerr << "ERR: " << lua_tostring(F, state) << std::endl; 
		lua_pop(F, 1); //remove error
	}
}

//executes a lua script file
void LuaHelper::ExecuteFile(const char* file)
{
	if (file == NULL)
		return;

	int state = luaL_dofile(F, file);
	report_errors(state);
}

//(could contain a full script with line breaks)
void LuaHelper::ExecuteString(const char* expression)
{
	if (expression == NULL)
	{
		std::cerr << "ERR: null expression passed to script engine!" << std::endl;
		return;
	}

	int state = luaL_dostring(F, expression);
	report_errors(state);
}

void LuaHelper::Update(void* Engine)
{

}

int LuaHelper::GetCurrentLevel()
{
	return CurrentLevel;
}

void LuaHelper::StartLevel(int Level)
{
	CurrentLevel = Level;
}
bool LuaHelper::GetFinished()
{
	return Finished;
}

void LuaHelper::SetFinished(bool Value)
{
	Finished = Value;
}
