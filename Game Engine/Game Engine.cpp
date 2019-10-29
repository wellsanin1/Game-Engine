#include "OgreApplicationContext.h"
#include "OgreRTShaderSystem.h"
#include "ObjectPool.h"
#include "EventSystem.h"
#include "InputManager.h"
#include <iostream>

using namespace Ogre;
using namespace OgreBites;

class GameEngine
	: public ApplicationContext
{
public:
	GameEngine();
	virtual ~GameEngine() {};
	void setup();
};

//void OgreView::resizeEvent(QResizeEvent*)
//{
//	if (NULL != m_render_window) {
//		// Need to let Ogre know about the resize...
//		m_render_window->resize(width(), height());
//		// Alter the camera aspect ratio to match the viewport
//		m_camera->setAspectRatio(Ogre::Real(width()) / Ogre::Real(height()));
//	}
//}

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


int main(int argc, char** argv)
{

	try
	{
		if (SDL_Init(SDL_INIT_VIDEO | SDL_INIT_AUDIO) != 0) {
			SDL_Log("Unable to initialize SDL: %s", SDL_GetError());
			return 1;
		}
		InputManager IM;
		GameEngine app;
		app.initApp();
		//Game Logic
		while (1)
		{
			IM.InputRead();
			app.getRoot()->renderOneFrame();
		
			IM.ClearKeys();
		}
		app.closeApp();
		SDL_Quit();
	}
	catch (const std::exception & e)
	{
		std::cerr << "Error occurred during execution: " << e.what() << '\n';
		return 1;
	}

	return 0;
}
