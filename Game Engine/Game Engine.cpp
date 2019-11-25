#include "GameEngine.h"
void GameEngine::ExecuteLUA()
{
	luabridge::LuaRef processFunc = luabridge::getGlobal(LH.L(), "GameEngine");
	if (processFunc.isFunction()) {
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
							, &PM, &R,&LH);
		}
		if (LH.entityList[i]->UnionType == "Camera")
		{
			LuaGenStruct::LuaGeneric GenEnt = LH.entityList[i]->GenericStore;
			OP.CreateCamera(GenEnt.Camera->Name, GenEnt.Camera->x, GenEnt.Camera->y, GenEnt.Camera->z, &PM, &R, &LH);
			R.getRenderWindow()->removeAllViewports();
			R.getRenderWindow()->addViewport(OP.GetObject(GenEnt.Camera->Name)->StoredObject.Camera);
		}
		if (LH.entityList[i]->UnionType == "Light")
		{
			LuaGenStruct::LuaGeneric GenEnt = LH.entityList[i]->GenericStore;
			OP.CreateLight(GenEnt.Light->Name, GenEnt.Light->x, GenEnt.Light->y, GenEnt.Light->z, &PM, &R, &LH);
		}
	}
}
void GameEngine::Start()
{
	register_lua(LH.L());
	KM.Initiate(LH.L());
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
	return OP.GetObject(Name);
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
	KM.InputRead(&EQ);
	while (EventEnum Enum = EQ.CheckQueue(event::TEST))
	{
		switch (Enum)
		{
		case NONE:
			break;
		case UP:
			std::cout << "UP" << std::endl;
			break;
		case LEFT:
			std::cout << "LEFT" << std::endl;
			break;
		case QUIT:
			std::cout << "QUIT" << std::endl;
			break;
		}
	}
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
}

void GameEngine::Initialise()
{
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