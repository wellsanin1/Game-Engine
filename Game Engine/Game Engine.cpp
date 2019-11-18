#include "GameEngine.h"

void GameEngine::CreateCamera(std::string Name, int PosX, int PosY, int PosZ)
{
	GameObject* a = new GameObject();
	a->Subsystems(&PM, &R);
	a->CreateCamera(Name, PosX, PosY, PosZ);
	OP.StoreObject(a);
}
void GameEngine::CreateEntity(std::string Name, std::string MeshName, int PosX, int PosY, int PosZ)
{
	GameObject* a = new GameObject();
	a->Subsystems(&PM, &R);
	a->CreateEntity(Name,MeshName,PosX,PosY,PosZ);
	OP.StoreObject(a);
}
void GameEngine::CreateLight(std::string Name, int PosX, int PosY, int PosZ)
{
	GameObject* a = new GameObject();
	a->Subsystems(&PM, &R);
	a->CreateLight(Name, PosX, PosY, PosZ);
	OP.StoreObject(a);
}
void GameEngine::Game()
{

}

void GameEngine::Start()
{
	CreateCamera("myCam",0,50,200);
	R.getRenderWindow()->addViewport(OP.GetObject("myCam")->StoredObject.Camera);
	CreateLight("mainLight",20,50,80);
	CreateEntity("OgreHead", "ogrehead.mesh",0,200,0);
	CreateEntity("Barrel", "Barrel.mesh", 0, 100, 0);
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
}

void GameEngine::Render()
{
	R.Update();

}

void GameEngine::Quit()
{
	switch (EQ.CheckQueue(event::TEST))
	{
		case NONE:
			break;
		case UP:
			std::cout << "UP" << std::endl;

			break;
		case QUIT:
			std::cout << "QUIT" << std::endl;
			AM.PlaySound("rain.wav");
			break;
	}
}

void GameEngine::Update()
{
	CheckInput();
	PhysicsUpdate();
	Render();
	Game();
	Audio();
	Quit();
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