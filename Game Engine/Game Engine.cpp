#include "OgreApplicationContext.h"
#include "OgreRTShaderSystem.h"
#include "ObjectPool.h"
#include "EventSystem.h"
#include "InputManager.h"
#include <iostream>

using namespace Ogre;
using namespace OgreBites;

EventQueue EQ;

class GameEngine
	: public ApplicationContext
{
public:
	GameEngine();
	virtual ~GameEngine() {};
	void setup();
	void Update();
	void CheckInput();
	void InitialiseSDL();
	void Render();
	void CloseSDL();
};

GameEngine::GameEngine():ApplicationContext("GameEngine")
{
}

void GameEngine::setup()
{

	ObjectPool ObjPool;

	ApplicationContext::setup();
	Root* root = getRoot();
	SceneManager* scnMgr = root->createSceneManager();

	RTShader::ShaderGenerator* shadergen = RTShader::ShaderGenerator::getSingletonPtr();
	shadergen->addSceneManager(scnMgr);

	scnMgr->setAmbientLight(ColourValue(0.5, 0.5, 0.5));

	Light* light = scnMgr->createLight("MainLight");
	SceneNode* lightNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	ObjPool.StoreObject(light, lightNode);
	ObjPool.GetObject("MainLight")->Node->setPosition(20, 80, 50);;

	SceneNode* camNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	Camera* cam = scnMgr->createCamera("myCam");
	ObjPool.StoreObject(cam, camNode);
	ObjPool.GetObject("myCam")->Node->setPosition(0, 47, 222);
	ObjPool.GetObject("myCam")->StoredObject.Camera->setAutoAspectRatio(true);
	ObjPool.GetObject("myCam")->StoredObject.Camera->setNearClipDistance(5);
	getRenderWindow()->addViewport(ObjPool.GetObject("myCam")->StoredObject.Camera);

	Entity* OgreHead = scnMgr->createEntity("OgreHead","ogrehead.mesh");
	SceneNode* OgreNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	ObjPool.StoreObject(OgreHead, OgreNode);
}

void GameEngine::CheckInput()
{
	InputManager IM;
	IM.InputRead();
	int size = sizeof(IM.KeyArray) / sizeof(*IM.KeyArray);
	for (int i = 0;i<size;++i)
	{
	/*	if (IM.KeyArray[i] != KeyManager::NONE)
		{
			EventType A = INPUT;
			event e(Input,);
		}*/
	}
	IM.ClearKeys();
}

void GameEngine::Render()
{

}

void GameEngine::Update()
{
	CheckInput();
	//Render();
	getRoot()->renderOneFrame();
}

void GameEngine::InitialiseSDL()
{
	if (SDL_Init(SDL_INIT_VIDEO | SDL_INIT_AUDIO) != 0) 
	{
		SDL_Log("Unable to initialize SDL: %s", SDL_GetError());
		return;
	}
}
void GameEngine::CloseSDL()
{
	SDL_Quit();
}

int main(int argc, char** argv)
{
	try
	{
		GameEngine app;
		app.InitialiseSDL();
		app.initApp();
		while (1)
		{
			app.Update();
		}
		app.closeApp();
		app.CloseSDL();
	}
	catch (const std::exception & e)
	{
		std::cerr << "Error occurred during execution: " << e.what() << '\n';
		return 1;
	}
	return 0;
}
