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
	OP.ClearPool(&EQ);
	for (int i = 0; i < LH.entityList.size(); ++i)
	{
		if (LH.entityList[i]->UnionType == "Entity")
		{
			LuaGenStruct::LuaGeneric GenEnt = LH.entityList[i]->GenericStore;
			event E;
			E.SubSystemList.push_back(SubSystem_ObjectPool);
			E.ObjectPoolEventEnum = ObjectPool_CREATEENTITY;

			E.OD.MeshName = GenEnt.Entity->Mesh;
			E.OD.Name = GenEnt.Entity->Name;
			E.OD.Material = GenEnt.Entity->Material;

			E.OD.positions.x = GenEnt.Entity->x;
			E.OD.positions.y = GenEnt.Entity->y;
			E.OD.positions.z = GenEnt.Entity->z;

			E.OD.Colliders.x = GenEnt.Entity->ColX;
			E.OD.Colliders.y = GenEnt.Entity->ColY;
			E.OD.Colliders.z = GenEnt.Entity->ColZ;
			E.Empty = false;
			EQ.AddEvent(E);
		}
		if (LH.entityList[i]->UnionType == "Camera")
		{
			LuaGenStruct::LuaGeneric GenEnt = LH.entityList[i]->GenericStore;
			event E;
			E.SubSystemList.push_back(SubSystem_ObjectPool);
			E.ObjectPoolEventEnum = ObjectPool_CREATECAMERA;
			E.OD.Name = GenEnt.Camera->Name;
			E.OD.positions.x = GenEnt.Camera->x;
			E.OD.positions.y = GenEnt.Camera->y;
			E.OD.positions.z = GenEnt.Camera->z;
			E.Empty = false;
			EQ.AddEvent(E);
		}
		if (LH.entityList[i]->UnionType == "Light")
		{
			LuaGenStruct::LuaGeneric GenEnt = LH.entityList[i]->GenericStore;
			event E;
			E.SubSystemList.push_back(SubSystem_ObjectPool);
			E.ObjectPoolEventEnum = ObjectPool_CREATELIGHT;
			E.OD.Name = GenEnt.Light->Name;
			E.OD.positions.x = GenEnt.Light->x;
			E.OD.positions.y = GenEnt.Light->y;
			E.OD.positions.z = GenEnt.Light->z;
			E.Empty = false;
			EQ.AddEvent(E);
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
	OP.Update(&EQ);
}
void GameEngine::Reload(int Level)
{
	LH.StartLevel(Level);
	LoadEntitiesIntoEngine(Level);
	NM.Restart();
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
	if (1)
	{
		KM.InputRead();
	}
}
void GameEngine::Render()
{
	R.Update(&EQ);
}
void GameEngine::Update()
{
	Network();
	CheckInput();
	PhysicsUpdate();
	Render();
	ObjectPoolUpdate();
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