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

GameEngine::GameEngine():ApplicationContext("GameEngine")
{
}

void GameEngine::setup()
{
	ObjectPool ObjPool;
	ApplicationContext::setup();
	addInputListener(this);

	Root* root = getRoot();
	SceneManager* scnMgr = root->createSceneManager();

	RTShader::ShaderGenerator* shadergen = RTShader::ShaderGenerator::getSingletonPtr();
	shadergen->addSceneManager(scnMgr);

	scnMgr->setAmbientLight(ColourValue(0.5, 0.5, 0.5));

	Light* light = scnMgr->createLight("MainLight");
	SceneNode* lightNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	ObjPool.GetObject("MainLight")->Node->setPosition(20, 80, 50);;
	ObjPool.StoreObject(light, lightNode);

	SceneNode* camNode = scnMgr->getRootSceneNode()->createChildSceneNode();

	Camera* cam = scnMgr->createCamera("myCam");
	ObjPool.GetObject("myCam")->Node->setPosition(0, 47, 222);

	ObjPool.GetObject("myCam")->Obj->setAutoAspectRatio(true);

	cam->setNearClipDistance(5);
	cam->setAutoAspectRatio(true);
	ObjPool.StoreObject(cam, camNode);

	getRenderWindow()->addViewport(cam);

	Entity* a = scnMgr->createEntity("OgreHead1","ogrehead.mesh");

	SceneNode* b = scnMgr->getRootSceneNode()->createChildSceneNode();

	ObjPool.StoreObject(a, b);

	ObjPool.GetObject("myCam")->Node->setPosition(0, 47, 222);
	
	//camNode->setPosition(0, 47, 222);

	PooledObject* ObjectPoolGet = ObjPool.GetObject("OgreHead1");
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
