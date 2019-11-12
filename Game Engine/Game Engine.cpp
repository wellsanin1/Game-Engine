#include "GameEngine.h"

GameEngine::GameEngine():OgreBites::ApplicationContext("GameEngine")
{
}

void GameEngine::renderOneFrame()
{

}

void GameEngine::setup()
{
	//SETUP
	OgreBites::ApplicationContext::setup();
	root = getRoot();
	scnMgr = root->createSceneManager();
	shadergen = Ogre::RTShader::ShaderGenerator::getSingletonPtr();
	shadergen->addSceneManager(scnMgr);
	scnMgr->setAmbientLight(Ogre::ColourValue(0.5, 0.5, 0.5));
}

void GameEngine::Game()
{
	//LIGHT
	Ogre::Light* light = scnMgr->createLight("MainLight");
	Ogre::SceneNode* lightNode = scnMgr->getRootSceneNode()->createChildSceneNode();

	btTransform LightTransform;
	LightTransform.setIdentity();
	LightTransform.setOrigin({ 20, 50, 80 });

	GameObject* GO1 = new GameObject(&PM);
	GO1->initiate(new btBoxShape(btVector3(0.0f, 0.0f, 0.0f)), light, lightNode, "MainLight", LightTransform, 0);
	OP.StoreObject(GO1);


	//CAMERA
	Ogre::SceneNode* camNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	Ogre::Camera* cam = scnMgr->createCamera("myCam");

	btTransform camTransform;
	camTransform.setIdentity();
	camTransform.setOrigin({ 0, 50, 200 });
	GameObject* GO2 = new GameObject(&PM);
	GO2->initiate(new btBoxShape(btVector3(0.f, 0.f, 0.f)), cam, camNode, "myCam", camTransform, 0);
	OP.StoreObject(GO2);

	OP.GetObject("myCam")->StoredObject.Camera->setAutoAspectRatio(true);
	OP.GetObject("myCam")->StoredObject.Camera->setNearClipDistance(5);

	getRenderWindow()->addViewport(OP.GetObject("myCam")->StoredObject.Camera);


	//PLANE
	Ogre::Plane plane(Ogre::Vector3::UNIT_Y, 0);
	Ogre::MeshPtr planePtr = Ogre::MeshManager::getSingleton().createPlane("ground", Ogre::ResourceGroupManager::DEFAULT_RESOURCE_GROUP_NAME, plane, 1500, 1500, 20, 20, true, 1, 5, 5, Ogre::Vector3::UNIT_Z);
	Ogre::Entity* entGround = scnMgr->createEntity("GroundEntity", "ground");
	Ogre::SceneNode* groundNode = scnMgr->getRootSceneNode()->createChildSceneNode("groundNode");

	//create the plane entity to the physics engine, and attach it to the node
	btTransform groundTransform;
	groundTransform.setIdentity();
	groundTransform.setOrigin(btVector3(0, -50, 0));
	//GO2->initiate(box2, cam, camNode, "myCam", startTransform1);
	GameObject* GO3 = new GameObject(&PM);
	GO3->initiate(new btBoxShape(btVector3(50, 50, 50)), entGround, groundNode, "Ground", groundTransform, 0);
	OP.StoreObject(GO3);

	//OGRE

	Ogre::Entity* OgreEntity = scnMgr->createEntity("OgreHead", "ogrehead.mesh");
	Ogre::SceneNode* OgreNode = scnMgr->getRootSceneNode()->createChildSceneNode("OgreNode");

	btTransform OgreTransform;
	OgreTransform.setIdentity();
	OgreTransform.setOrigin({ 0,200,0 });

	GameObject* GO4 = new GameObject(&PM);
	GO4->initiate(new btBoxShape(btVector3(15.0f, 15.0f, 15.0f)), OgreEntity, OgreNode, "OgreHead", OgreTransform, 10);
	OP.StoreObject(GO4);
}

void GameEngine::PhysicsUpdate()
{
	//PM.Update(OP.PoolStorage);
	PM.PhysicsUpdate();

}

void GameEngine::Audio()
{
	//AM
}

void GameEngine::CheckInput()
{
	KM.InputRead(&EQ);
}

void GameEngine::Render()
{

	getRoot()->renderOneFrame();
}

void GameEngine::Quit()
{
	switch (EQ.CheckQueue(event::TEST))
	{
		case NONE:
			break;
		case UP:
			std::cout << "UP" << std::endl;
			AM.PlaySound("rain.wav");
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
	Audio();
	Quit();
}

void GameEngine::Initialise()
{
	if (SDL_Init(SDL_INIT_VIDEO | SDL_INIT_AUDIO) != 0) 
	{
		SDL_Log("Unable to initialize SDL: %s", SDL_GetError());
		return;
	}
	//PM.initialise();
	initApp();
	AM.Loader();
	//PM.FindObjectPool(&OP);
}

void GameEngine::Close()
{
	closeApp();
	SDL_Quit();
	//PM.dealloc();
}