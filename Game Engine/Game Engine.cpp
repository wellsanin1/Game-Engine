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

	//LIGHT
	Ogre::Light* light = scnMgr->createLight("MainLight");
	Ogre::SceneNode* lightNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	btBoxShape* box1 = new btBoxShape(btVector3(0.0f, 0.0f, 0.0f));
	GameObject* GO1 = new GameObject();

	btTransform startTransform2;
	startTransform2.setIdentity();
	startTransform2.setRotation(btQuaternion(1.0f, 1.0f, 1.0f, 0));
	startTransform2.setOrigin(btVector3(20, 80, 50));

	GO1->initiate(box1, light, lightNode, "MainLight",startTransform2);
	OP.StoreObject(GO1);


	//Camera
	Ogre::SceneNode* camNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	Ogre::Camera* cam = scnMgr->createCamera("myCam");
	btBoxShape* box2 = new btBoxShape(btVector3(0.f, 0.f, 0.f));
	GameObject* GO2 = new GameObject();

	btTransform startTransform1;
	startTransform1.setIdentity();
	startTransform1.setRotation(btQuaternion(1.0f, 1.0f, 1.0f, 0));
	startTransform1.setOrigin(btVector3(0, 47, 222));

	GO2->initiate(box2, cam, camNode, "myCam",startTransform1);
	OP.StoreObject(GO2);

	//OP.GetObject("myCam")->RigidBody3d->setActivationState(DISABLE_DEACTIVATION);
	//OP.GetObject("myCam")->Transform.setIdentity();
	//OP.GetObject("myCam")->Transform.setOrigin(btVector3(0, 47, 222));
	OP.GetObject("myCam")->StoredObject.Camera->setAutoAspectRatio(true);
	OP.GetObject("myCam")->StoredObject.Camera->setNearClipDistance(5);


	getRenderWindow()->addViewport(OP.GetObject("myCam")->StoredObject.Camera);

	PMTESTING.collisionShapes.push_back(OP.GetObject("myCam")->CollisionShape);
	PMTESTING.physicsAccessors.insert({std::string("myCam"), OP.GetObject("myCam")->RigidBody3d});
	PMTESTING.dynamicsWorld->addRigidBody(OP.GetObject("myCam")->RigidBody3d);

	/*PMTESTING.collisionShapes.push_back(OP.GetObject("MainLight")->CollisionShape);
	PMTESTING.physicsAccessors.insert({ std::string("MainLight"), OP.GetObject("MainLight")->RigidBody3d });*/
	/*
	#######################################################################
	#######################################################################
	Below here lies sample code
	#######################################################################
	#######################################################################
	*/
	//create the actual plane in Ogre3D

	//create the actual plane in Ogre3D
	Ogre::Plane plane(Ogre::Vector3::UNIT_Y, 0);
	Ogre::MeshPtr planePtr = Ogre::MeshManager::getSingleton().createPlane("ground", Ogre::ResourceGroupManager::DEFAULT_RESOURCE_GROUP_NAME, plane, 1500, 1500, 20, 20, true, 1, 5, 5, Ogre::Vector3::UNIT_Z);
	Ogre::Entity* entGround = scnMgr->createEntity("GroundEntity", "ground");
	Ogre::SceneNode* groundNode = scnMgr->getRootSceneNode()->createChildSceneNode("groundNode");

	groundNode->attachObject(entGround);

	//create the plane entity to the physics engine, and attach it to the node

	btTransform groundTransform;
	groundTransform.setIdentity();
	groundTransform.setOrigin(btVector3(0, -50, 0));



	btScalar groundMass(0.); //the mass is 0, because the ground is immovable (static)
	btVector3 localGroundInertia(0, 0, 0);

	btCollisionShape* groundShape = new btBoxShape(btVector3(btScalar(50.), btScalar(50.), btScalar(50.)));
	btDefaultMotionState* groundMotionState = new btDefaultMotionState(groundTransform);

	groundShape->calculateLocalInertia(groundMass, localGroundInertia);

	btRigidBody::btRigidBodyConstructionInfo groundRBInfo(groundMass, groundMotionState, groundShape, localGroundInertia);
	btRigidBody* groundBody = new btRigidBody(groundRBInfo);

	GameObject* GO3 = new GameObject();
	btBoxShape* box3 = new btBoxShape(btVector3(0.0f, 0.0f, 0.0f));
	GO2->initiate(box3, entGround, groundNode, "myCam",groundTransform);
	OP.StoreObject(GO3);

	PMTESTING.collisionShapes.push_back(groundShape);

	//add the body to the dynamics world
	PMTESTING.dynamicsWorld->addRigidBody(groundBody);

	PMTESTING.physicsAccessors.insert({std::string("groundNode"), groundBody });

	/*
	#######################################################################
	#######################################################################
	Below here lies more sample code
	#######################################################################
	#######################################################################
	*/

	//btTransform TEST2;
	//btCollisionShape* newRigidShape = new btBoxShape(btVector3(15.0f, 15.0f, 15.0f));
	//GameObject a;
	//btBoxShape* box = new btBoxShape(btVector3(15.0f, 15.0f, 15.0f));
	//a.initiate(box);

	Ogre::Entity* entity = scnMgr->createEntity("Cube", "ogrehead.mesh");
	Ogre::SceneNode* newNode = scnMgr->getRootSceneNode()->createChildSceneNode("CubeNode");
	newNode->attachObject(entity);
	//create the new shape, and tell the physics that is a Box
	btCollisionShape* newRigidShape = new btBoxShape(btVector3(15.0f, 15.0f, 15.0f));
	PMTESTING.collisionShapes.push_back(newRigidShape);

	//set the initial position and transform. For this demo, we set the tranform to be none
	btTransform startTransform;
	startTransform.setIdentity();
	startTransform.setRotation(btQuaternion(1.0f, 1.0f, 1.0f, 0));

	//set the mass of the object. a mass of "0" means that it is an immovable object
	btScalar mass = 10.f;
	btVector3 localInertia(0, 0, 0);

	startTransform.setOrigin({ 0,200,0 });
	newRigidShape->calculateLocalInertia(mass, localInertia);

	//actually contruct the body and add it to the dynamics world
	btDefaultMotionState* myMotionState = new btDefaultMotionState(startTransform);

	btRigidBody::btRigidBodyConstructionInfo rbInfo(mass, myMotionState, newRigidShape, localInertia);
	btRigidBody* body = new btRigidBody(rbInfo);
	body->setRestitution(1);
	body->setUserPointer(newNode);


	PMTESTING.dynamicsWorld->addRigidBody(body);
	PMTESTING.physicsAccessors.insert({std::string("CubeNode"), body });

}

void GameEngine::PhysicsUpdate()
{
	//PM.Update(OP.PoolStorage);
	PMTESTING.PhysicsUpdate();

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