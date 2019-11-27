#include "GameEngine.h"
void GameEngine::ExecuteLUA()
{
	luaL_openlibs(LH.L());
	luabridge::LuaRef processFunc = luabridge::getGlobal(LH.L(), "GameEngine");
	if (processFunc.isFunction()) 
	{
		processFunc(this);
	}
}
void GameEngine::LoadEntitiesIntoEngine(int Level)
{
	LH.LoadEntityData(Level);
	OP.ClearPool(&R,&PM);
	for (int i = 0; i < LH.entityList.size(); ++i)
	{
		if (LH.entityList[i]->UnionType == "Entity")
		{
			LuaGenStruct::LuaGeneric GenEnt = LH.entityList[i]->GenericStore;
			OP.CreateEntity(GenEnt.Entity->Name, GenEnt.Entity->Mesh,GenEnt.Entity->Material
							,GenEnt.Entity->x, GenEnt.Entity->y, GenEnt.Entity->z
							,GenEnt.Entity->ColX, GenEnt.Entity->ColY, GenEnt.Entity->ColZ
							, &PM,&R,&LH,&NM);
		}
		if (LH.entityList[i]->UnionType == "Camera")
		{
			LuaGenStruct::LuaGeneric GenEnt = LH.entityList[i]->GenericStore;
			OP.CreateCamera(GenEnt.Camera->Name, GenEnt.Camera->x, GenEnt.Camera->y, GenEnt.Camera->z, &PM, &R, &LH, &NM);
			R.getRenderWindow()->removeAllViewports();
			R.getRenderWindow()->addViewport(OP.GetObjectFromPool(GenEnt.Camera->Name)->StoredObject.Camera);
		}
		if (LH.entityList[i]->UnionType == "Light")
		{
			LuaGenStruct::LuaGeneric GenEnt = LH.entityList[i]->GenericStore;
			OP.CreateLight(GenEnt.Light->Name, GenEnt.Light->x, GenEnt.Light->y, GenEnt.Light->z, &PM, &R, &LH, &NM);
		}
	}
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
	PM.CheckCollisions(&OP);
	PM.PhysicsUpdate(&OP);
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
	OP.Update(&EQ,&PM,&R,&LH,&NM);
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
	R.Update();
}

void GameEngine::Update()
{
	CheckInput();
	PhysicsUpdate();
	Render();
	Audio();
	Game();
	ExecuteLUA();
	ObjectPoolUpdate();
	Network();

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