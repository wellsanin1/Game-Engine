#include "GameEngine.h"

void GameEngine::CreateCamera(std::string Name, int PosX, int PosY, int PosZ)
{
	GameObject* a = new GameObject();
	a->CreateCamera(&PM,&R,Name, PosX, PosY, PosZ);
	OP.StoreObject(a);
}
void GameEngine::CreateEntity(std::string Name, std::string MeshName, int PosX, int PosY, int PosZ)
{
	GameObject* a = new GameObject();
	a->CreateEntity(&PM,&R,Name,MeshName,PosX,PosY,PosZ);
	OP.StoreObject(a);
}
void GameEngine::CreateLight(std::string Name, int PosX, int PosY, int PosZ)
{
	GameObject* a = new GameObject();
	a->CreateLight(&PM,&R,Name, PosX, PosY, PosZ);
	OP.StoreObject(a);
}
void GameEngine::Game()
{

}
void GameEngine::Start()
{
	for (int i = 0;i< LH.entityList.size();++i)
	{
		if (LH.entityList[i]->UnionType == "Entity")
		{
			LuaGenStruct::LuaGeneric GenEnt = LH.entityList[i]->GenericStore;
			CreateEntity(GenEnt.Entity->Name, GenEnt.Entity->Mesh, GenEnt.Entity->x, GenEnt.Entity->y, GenEnt.Entity->z);
		}
		if (LH.entityList[i]->UnionType == "Camera")
		{
			LuaGenStruct::LuaGeneric GenEnt = LH.entityList[i]->GenericStore;
			CreateCamera(GenEnt.Camera->Name,GenEnt.Camera->x, GenEnt.Camera->y, GenEnt.Camera->z);
			R.getRenderWindow()->addViewport(OP.GetObject(GenEnt.Camera->Name)->StoredObject.Camera);
		}
		if (LH.entityList[i]->UnionType == "Light")
		{
			LuaGenStruct::LuaGeneric GenEnt = LH.entityList[i]->GenericStore;
			CreateLight(GenEnt.Light->Name, GenEnt.Light->x, GenEnt.Light->y, GenEnt.Light->z);
		}
	}
	OP.GetObject("penguin")->SetMass(0, &PM);
}

void GameEngine::PhysicsUpdate()
{
	PM.PhysicsUpdate(&OP);
}

void GameEngine::Audio()
{
	//AM.PlaySound("rain.wav");
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
			OP.GetObject("OgreHead")->AddVelocity(0, -100, 0);
			break;
		case LEFT:
			std::cout << "LEFT" << std::endl;
			OP.GetObject("OgreHead")->AddVelocity(0, 100, 0);
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

void GameEngine::Quit()
{

}

void GameEngine::Update()
{
	CheckInput();
	PhysicsUpdate();
	Render();
	Game();
	Audio();
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