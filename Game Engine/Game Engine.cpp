#include "OgreApplicationContext.h"
#include "OgreInput.h"
#include "OgreRTShaderSystem.h"
#include "ObjectPool.h"
#include <iostream>

using namespace Ogre;
using namespace OgreBites;

class GameEngine
	: public ApplicationContext
	, public InputListener
{
public:
	GameEngine();
	virtual ~GameEngine() {};

	void setup();
	bool keyPressed(const KeyboardEvent& evt);
};

GameEngine::GameEngine():ApplicationContext("OgreTutorialApp")
{
}

void GameEngine::setup()
{
	ObjectPool ObjPool;
	// do not forget to call the base first
	ApplicationContext::setup();
	addInputListener(this);

	// get a pointer to the already created root
	Root* root = getRoot();
	SceneManager* scnMgr = root->createSceneManager();

	// register our scene with the RTSS
	RTShader::ShaderGenerator* shadergen = RTShader::ShaderGenerator::getSingletonPtr();
	shadergen->addSceneManager(scnMgr);

	// -- tutorial section start --

	scnMgr->setAmbientLight(ColourValue(0.5, 0.5, 0.5));

	Light* light = scnMgr->createLight("MainLight");
	SceneNode* lightNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	lightNode->attachObject(light);
	lightNode->setPosition(20, 80, 50);
	ObjPool.StoreObject(light, lightNode);

	SceneNode* camNode = scnMgr->getRootSceneNode()->createChildSceneNode();

	// create the camera
	Camera* cam = scnMgr->createCamera("myCam");
	cam->setNearClipDistance(5); // specific to this sample
	cam->setAutoAspectRatio(true);
	camNode->attachObject(cam);
	camNode->setPosition(0, 0, 140);

	ObjPool.StoreObject(cam, camNode);

	// and tell it to render into the main window
	getRenderWindow()->addViewport(cam);
	//! [camera]

	Entity* a = scnMgr->createEntity("ogrehead.mesh");
	SceneNode* b = scnMgr->getRootSceneNode()->createChildSceneNode();
	b->attachObject(a);
	ObjPool.StoreObject(a, b);

	//! [cameramove]
	camNode->setPosition(0, 47, 222);
	//! [cameramove]

	PooledObject* ObjectPoolGet = ObjPool.GetObject("Ogre");
}


bool GameEngine::keyPressed(const KeyboardEvent& evt)
{
	if (evt.keysym.sym == SDLK_ESCAPE)
	{
		getRoot()->queueEndRendering();
	}
	return true;
}


int main(int argc, char** argv)
{
	try
	{
		GameEngine app;
		app.initApp();
		app.getRoot()->startRendering();
		app.closeApp();
	}
	catch (const std::exception & e)
	{
		std::cerr << "Error occurred during execution: " << e.what() << '\n';
		return 1;
	}

	return 0;
}

//! [fullsource]
