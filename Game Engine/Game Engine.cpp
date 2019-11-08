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


	//OP.GetObject("myCam")->Velocity = {0,1,0};

	Ogre::SceneNode* OgreNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	OP.StoreObject(OgreHead, OgreNode);

	/*
	#######################################################################
	#######################################################################
	Below here lies sample code
	#######################################################################
	#######################################################################
	*/

	////create the actual plane in Ogre3D
	//Ogre::Plane plane(Ogre::Vector3::UNIT_Y, 0);
	//Ogre::MeshPtr planePtr = Ogre::MeshManager::getSingleton().createPlane("ground", Ogre::ResourceGroupManager::DEFAULT_RESOURCE_GROUP_NAME, plane, 1500, 1500, 20, 20, true, 1, 5, 5, Ogre::Vector3::UNIT_Z);

	//Ogre::Entity* entGround = scnMgr->createEntity("GroundEntity", "ground");
	//Ogre::SceneNode* groundNode = scnMgr->getRootSceneNode()->createChildSceneNode("groundNode");

	//groundNode->attachObject(entGround);

	////create the plane entity to the physics engine, and attach it to the node

	//btTransform groundTransform;
	//groundTransform.setIdentity();
	//groundTransform.setOrigin(btVector3(0, -50, 0));

	//btScalar groundMass(0.); //the mass is 0, because the ground is immovable (static)
	//btVector3 localGroundInertia(0, 0, 0);

	//btCollisionShape* groundShape = new btBoxShape(btVector3(btScalar(50.), btScalar(50.), btScalar(50.)));
	//btDefaultMotionState* groundMotionState = new btDefaultMotionState(groundTransform);

	//groundShape->calculateLocalInertia(groundMass, localGroundInertia);

	//btRigidBody::btRigidBodyConstructionInfo groundRBInfo(groundMass, groundMotionState, groundShape, localGroundInertia);
	//btRigidBody* groundBody = new btRigidBody(groundRBInfo);

	//add the body to the dynamics world
	//PMTESTING->getDynamicsWorld()->addRigidBody(groundBody);
}

void GameEngine::PhysicsUpdate()
{
	//PM.Update(OP.PoolStorage);

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
	//PMTESTING.initialise();
	initApp();
	AM.Loader();

	//PM.FindObjectPool(&OP);
}

void GameEngine::Close()
{
	closeApp();
	SDL_Quit();
	//PMTESTING.dealloc();
}