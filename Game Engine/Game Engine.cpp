#include "GameEngine.h"



void GameEngine::renderOneFrame()
{

}

void GameEngine::CreateCamera(std::string Name)
{
	GameObject* a = new GameObject();
	a->Subsystems(&PM, &R);
	a->CreateCamera(Name);
	OP.StoreObject(a);
}
void GameEngine::CreateEntity(std::string Name,std::string MeshName)
{
	GameObject* a = new GameObject();
	a->Subsystems(&PM, &R);
	a->CreateEntity(Name,MeshName);
	OP.StoreObject(a);
}
void GameEngine::CreateLight(std::string Name)
{
	GameObject* a = new GameObject();
	a->Subsystems(&PM, &R);
	a->CreateLight(Name);
	OP.StoreObject(a);
}
void GameEngine::Game()
{

}

void GameEngine::Start()
{
	CreateCamera("myCam");

	OP.GetObject("myCam")->StoredObject.Camera->setAutoAspectRatio(true);
	OP.GetObject("myCam")->StoredObject.Camera->setNearClipDistance(5);
	R.getRenderWindow()->addViewport(OP.GetObject("myCam")->StoredObject.Camera);
	CreateLight("mainLight");
	CreateEntity("OgreHead", "ogrehead.mesh");

	//PLANE
	//Ogre::Plane plane(Ogre::Vector3::UNIT_Y, 0);
	//Ogre::MeshPtr planePtr = Ogre::MeshManager::getSingleton().createPlane("ground", Ogre::ResourceGroupManager::DEFAULT_RESOURCE_GROUP_NAME, plane, 1500, 1500, 20, 20, true, 1, 5, 5, Ogre::Vector3::UNIT_Z);
	//Ogre::Entity* entGround = R.scnMgr->createEntity("GroundEntity", "ground");
	//Ogre::SceneNode* groundNode = R.scnMgr->getRootSceneNode()->createChildSceneNode("groundNode");

	//btTransform groundTransform;
	//groundTransform.setIdentity();
	//groundTransform.setOrigin(btVector3(0, -50, 0));
	//GameObject* GO3 = new GameObject();
	//GO3->initiate(new btBoxShape(btVector3(50, 50, 50)), entGround, groundNode, "Ground", groundTransform, 0);
	//OP.StoreObject(GO3);
}

void GameEngine::PhysicsUpdate()
{
	PM.PhysicsUpdate();
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
	//getRoot()->renderOneFrame();
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
}

void GameEngine::Close()
{

	SDL_Quit();
	PM.dealloc();
}