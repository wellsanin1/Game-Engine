#include "GameEngine.h"
void GameEngine::ExecuteLUA()
{
	//this is here because lua does not like void* passed through reference
	if (LH.GetFinished() == true)
	{
		luaL_openlibs(LH.L());
		luabridge::LuaRef processFunc = luabridge::getGlobal(LH.L(), "GameEngine");
		if (processFunc.isFunction())
		{
			processFunc(this);
		}
	}
}
void GameEngine::LoadEntitiesIntoEngine(int Level)
{
	LH.LoadEntityData(Level,&EQ);
}
void GameEngine::Start()
{
	register_lua(LH.L());
	KM.Initiate(LH.L(),&EQ);
	LoadEntitiesIntoEngine(0);
}
void GameEngine::Game()
{
}
void GameEngine::PhysicsUpdate()
{
	PM.CheckCollisions();
	PM.PhysicsUpdate(&EQ);
}
void GameEngine::Audio()
{
	//AM.PlaySound("rain.wav");
}
void GameEngine::Network()
{
	NM.Update(&OP,&EQ);
}
void GameEngine::ObjectPoolUpdate()
{
	OP.Update(&EQ,LH.GetStateVoid());
}
void GameEngine::Reload(int Level)
{
	LH.SetFinished(false);
	NM.Restart();
	PM.Restart();
	R.Restart();
	OP.Reinitialise();
	LH.StartLevel(Level);
	LoadEntitiesIntoEngine(Level);
	LH.SetFinished(true);
}
void GameEngine::ExecuteEvents()
{;
}
LuaHelper* GameEngine::GetLevelManager()
{
	return &LH;
}
KeyManager* GameEngine::GetKeyManager()
{
	return &KM;
}
GameObject* GameEngine::GetGameObjectWithName(std::string Name)
{
	return OP.GetObjectFromPool(Name);
}
void GameEngine::LuaStringOUT(std::string Value)
{
	std::cout << "LUA:" << Value << std::endl;
}
void GameEngine::LuaIntOUT(int Value)
{
	std::cout << "LUA:" << Value << std::endl;
}
void GameEngine::CheckInput()
{
	KM.InputRead();
}
void GameEngine::Render()
{
	R.Update(&EQ);
}
void GameEngine::Update()
{
	Network();
	CheckInput();
	ObjectPoolUpdate();
	PhysicsUpdate();
	Render();
	ExecuteLUA();
}

void GameEngine::Initialise()
{
	NM.Initiate();
	R.initApp();
	if (SDL_Init(SDL_INIT_VIDEO | SDL_INIT_AUDIO) != 0) 
	{
		SDL_Log("Unable to initialize SDL: %s", SDL_GetError());
		return;
	}
	AM.Loader();
	Start();
}

void GameEngine::Close()
{
	SDL_Quit();
	PM.dealloc();
}