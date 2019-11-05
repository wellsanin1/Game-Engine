#include "GameEngine.h"

GameEngine::GameEngine():OgreBites::ApplicationContext("GameEngine")
{
}

void GameEngine::renderOneFrame()
{

}

void GameEngine::setup()
{
	OgreBites::ApplicationContext::setup();
	Ogre::Root* root = getRoot();
	Ogre::SceneManager* scnMgr = root->createSceneManager();

	Ogre::RTShader::ShaderGenerator* shadergen = Ogre::RTShader::ShaderGenerator::getSingletonPtr();
	shadergen->addSceneManager(scnMgr);

	scnMgr->setAmbientLight(Ogre::ColourValue(0.5, 0.5, 0.5));

	Ogre::Light* light = scnMgr->createLight("MainLight");
	Ogre::SceneNode* lightNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	OP.StoreObject(light, lightNode);
	OP.GetObject("MainLight")->Node->setPosition(20, 80, 50);;

	Ogre::SceneNode* camNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	Ogre::Camera* cam = scnMgr->createCamera("myCam");
	OP.StoreObject(cam, camNode);
	OP.GetObject("myCam")->Node->setPosition(0, 47, 222);
	OP.GetObject("myCam")->StoredObject.Camera->setAutoAspectRatio(true);
	OP.GetObject("myCam")->StoredObject.Camera->setNearClipDistance(5);
	getRenderWindow()->addViewport(OP.GetObject("myCam")->StoredObject.Camera);

	Ogre::Entity* OgreHead = scnMgr->createEntity("OgreHead", "ogrehead.mesh");
	Ogre::SceneNode* OgreNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	OP.StoreObject(OgreHead, OgreNode);
}

void GameEngine::PhysicsUpdate()
{
	//switch (EQ.CheckQueue(event::Physics))
	//{
	//case NONE:
	//	break;
	//case UP:
	//	std::cout << "UP";
	//	//PM.Movement(&OP);
	//	break;
	//case QUIT:
	//	std::cout << "QUIT";
	//	break;
	//}
}

void GameEngine::PhysicsEvents()
{
	switch (EQ.CheckQueue(event::Physics))
	{
	case NONE:
		break;
	case UP:
		std::cout << "UP";
		//PM.Movement(&OP);
		break;
	case QUIT:
		std::cout << "QUIT";
		break;
	}
}

void GameEngine::Audio()
{

}

void GameEngine::CheckInput()
{
	KM.InputRead(&EQ);
}

void GameEngine::Render()
{
	/*switch (EQ.CheckQueue(event::Renderer))
	{
	case NONE:
		break;
	case UP:
		std::cout << "UP";
		break;
	case QUIT:
		std::cout << "QUIT";
		break;
	}*/

	getRoot()->renderOneFrame();
}

void GameEngine::Quit()
{
	switch (EQ.CheckQueue(event::TEST))
	{
		case NONE:
			break;
		case UP:
			std::cout << "UP";
			break;
		case QUIT:
			std::cout << "QUIT";
			break;
	}
}

void GameEngine::Update()
{
	CheckInput();
	PhysicsUpdate();
	PhysicsEvents();
	Render();
	Quit();
}

void GameEngine::Initialise()
{
	if (SDL_Init(SDL_INIT_VIDEO | SDL_INIT_AUDIO) != 0) 
	{
		SDL_Log("Unable to initialize SDL: %s", SDL_GetError());
		return;
	}
	initApp();
	//PM.GetObjectPool(&OP);
}

void GameEngine::Close()
{
	closeApp();
	SDL_Quit();
}