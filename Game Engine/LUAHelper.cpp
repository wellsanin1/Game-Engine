#include "LUAHelper.h"

LuaHelper::LuaHelper()
{
	luaL_dofile(F, "test.lua");
	luaL_openlibs(F);
}

void LuaHelper::Load(int Level)
{

	std::string LevelString = std::string("Level") + std::to_string(Level)+std::string(".lua");
	luaL_dofile(F, LevelString.c_str());
	luaL_openlibs(F);
	lua_pcall(F, 0, 0, 0);
	elementList = getElements((std::string)"elementList", F);
	luabridge::LuaRef elementsRef = luabridge::getGlobal(F, "elementList");
	std::string checker;
	for (int i = 0; i < elementList.size(); i++)
	{
		luabridge::LuaRef entityCheck = elementsRef[elementList.at(i)];
		checker = entityCheck["e_type"].cast<std::string>();
		if (checker == "Camera")
		{
			LuaCamera* NewCamera = new LuaCamera();
			NewCamera->Name = entityCheck["name"].cast<std::string>();
			NewCamera->x = entityCheck["x"].cast<int>();
			NewCamera->y = entityCheck["y"].cast<int>();
			NewCamera->z = entityCheck["z"].cast<int>();
			LuaGenStruct* NewGeneric = new LuaGenStruct();
			NewGeneric->UnionType = checker;
			NewGeneric->GenericStore.Camera = NewCamera;
			entityList.push_back(NewGeneric);
		}
		if (checker == "Light")
		{
			LuaLight* NewLight = new LuaLight();
			NewLight->Name = entityCheck["name"].cast<std::string>();
			NewLight->x = entityCheck["x"].cast<int>();
			NewLight->y = entityCheck["y"].cast<int>();
			NewLight->z = entityCheck["z"].cast<int>();
			LuaGenStruct* NewGeneric = new LuaGenStruct();
			NewGeneric->UnionType = checker;
			NewGeneric->GenericStore.Light = NewLight;
			entityList.push_back(NewGeneric);
		}
		if (checker == "Entity")
		{
			LuaEntity* NewEntity = new LuaEntity();
			NewEntity->Name = entityCheck["name"].cast<std::string>();
			NewEntity->Mesh = entityCheck["mesh"].cast<std::string>();
			NewEntity->x = entityCheck["x"].cast<int>();
			NewEntity->y = entityCheck["y"].cast<int>();
			NewEntity->z = entityCheck["z"].cast<int>();
			LuaGenStruct* NewGeneric = new LuaGenStruct();
			NewGeneric->UnionType = checker;
			NewGeneric->GenericStore.Entity = NewEntity;
			entityList.push_back(NewGeneric);
		}
	}
	return;
}

LuaHelper::~LuaHelper()
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

	/* We load the function using the loadstring function, then set up our
	default preamble. We then use getGlobal to access the getElements
	function, and pass in the name of the table we wish to explore (in this
	case, elementList, or 'tab'). The second lua_pcall executes the function
	we've loaded. */

	luaL_loadstring(L, source.c_str());
	lua_pcall(L, 0, 0, 0);
	lua_getglobal(L, "getElements");
	lua_pushstring(L, table.c_str());
	lua_pcall(L, 1, 1, 0);

	/* The return from the function will be a single string, so we'll need to
	parse it.  This is why we added the separation character in the function
	code. We simply iterate through ans, populating a temp string, and push
	temp onto elements whenever the separation character is reached. */

	std::string ans = lua_tostring(L, -1);
	std::vector<std::string> elements;
	std::string temp = "";
	for (unsigned int i = 0; i < ans.size(); i++) {
		if (ans.at(i) != '|') {
			temp += ans.at(i);
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

//execute a lua expression contained in string
//
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

void LuaHelper::StartLevel(int Level)
{
	Load(Level);
	CurrentLevel = Level;
}
bool LuaHelper::IsFinished()
{
	return Finished;
}

void LuaHelper::SetFinished(bool Value)
{
	Finished = Value;
}
