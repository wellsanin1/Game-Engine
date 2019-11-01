#include "GameEngine.h"

bool GameEngine::CheckQueue(event::SubSystem CurrentEvent)
{
	bool Run = false;
	for (int i = 0; i < EQ.Queue.size(); ++i)
	{
		if (Run == false)
		{
			std::vector<event::SubSystem> SystemList = EQ.Queue[i].SubSystemList;
			for (int i = 0; i < SystemList.size(); ++i)
			{
				if (SystemList[i] == event::Input)
				{
					Run = true;
					break;
				}
			}
		}
		else
		{
			break;
		}
	}
	return Run;
}

GameEngine::GameEngine():OgreBites::ApplicationContext("GameEngine")
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

	Ogre::Entity* OgreHead = scnMgr->createEntity("OgreHead","ogrehead.mesh");
	Ogre::SceneNode* OgreNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	OP.StoreObject(OgreHead, OgreNode);
}

void GameEngine::CheckInput()
{
	//If needed then uncomment
	/*if (CheckQueue(event::Input))
	{*/

	//Maybe goes here
	//InputManager IM;
	KM.InputRead(&EQ);
	//}
}

void GameEngine::Render()
{
	getRoot()->renderOneFrame();
	//if (CheckQueue(event::Renderer))
	//{
	//getRoot()->renderOneFrame();
	//}
}

void GameEngine::Quit()
{
	if(CheckQueue(event::Input))
	{
		closeApp();
	}

}

void GameEngine::Update()
{
	CheckInput();
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
}
void GameEngine::Close()
{
	closeApp();
	SDL_Quit();
}