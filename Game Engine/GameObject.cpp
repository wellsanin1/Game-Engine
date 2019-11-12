#include "GameObject.h"

void GameObject::FillObject(Ogre::Camera* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName)
{
	Node = ScnNode;
	ScnNode->attachObject(Object);
	Name = ObjName;
	StoredObject.Camera = Object;
	Empty = false;
}
void GameObject::FillObject(Ogre::Light* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName)
{
	Node = ScnNode;
	ScnNode->attachObject(Object);
	Name = ObjName;
	StoredObject.Light = Object;
	Empty = false;
}
void GameObject::FillObject(Ogre::Entity* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName)
{
	Node = ScnNode;
	ScnNode->attachObject(Object);
	Name = ObjName;
	StoredObject.entity = Object;
	Empty = false;
}
void GameObject::CreateEntity(std::string EntityName,std::string MeshName)
{
	Ogre::Entity* OgreEntity = R->scnMgr->createEntity(EntityName, MeshName);
	Ogre::SceneNode* OgreNode = R->scnMgr->getRootSceneNode()->createChildSceneNode();

	btTransform OgreTransform;
	OgreTransform.setIdentity();
	OgreTransform.setRotation(btQuaternion(1, 1, 1, 0));
	OgreTransform.setOrigin({ 0,200,0 });
	initiate(new btBoxShape(btVector3(15.0f, 15.0f, 15.0f)), OgreEntity, OgreNode, EntityName, OgreTransform, 10);
}
void GameObject::CreateLight(std::string LightName)
{
	Ogre::Light* light = R->scnMgr->createLight(LightName);
	Ogre::SceneNode* lightNode = R->scnMgr->getRootSceneNode()->createChildSceneNode();

	btTransform LightTransform;
	LightTransform.setIdentity();
	LightTransform.setOrigin({ 20, 50, 80 });
	initiate(new btBoxShape(btVector3(0.0f, 0.0f, 0.0f)), light, lightNode, LightName, LightTransform, 0);
}
void GameObject::CreateCamera(std::string CameraName)
{
	Ogre::SceneNode* camNode = R->scnMgr->getRootSceneNode()->createChildSceneNode();
	Ogre::Camera* cam = R->scnMgr->createCamera(CameraName);

	btTransform camTransform;
	camTransform.setIdentity();
	camTransform.setOrigin({ 0, 50, 200 });
	initiate(new btBoxShape(btVector3(0.f, 0.f, 0.f)), cam, camNode, CameraName, camTransform, 0);
}
void GameObject::ClearObject()
{
	Node = NULL;
	Name = "";
	Empty = true;
}
void GameObject::AssignRigidBody(btRigidBody* Rigidbody)
{
	RigidBody3d = Rigidbody;
}
void GameObject::AssignTransform()
{
	this->myMotionState = new btDefaultMotionState(Transform);
}
void GameObject::AssignCollisionShape(btCollisionShape* CollisionShape)
{
	this->CollisionShape = CollisionShape;
	this->CollisionShape->calculateLocalInertia(mass, localInertia);
};

void GameObject::AddtoPhysicsSystem()
{
	PM->collisionShapes.push_back(CollisionShape);
	PM->dynamicsWorld->addRigidBody(RigidBody3d);
}
void GameObject::initiate(btBoxShape* ColliderShape, Ogre::Entity* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName, btTransform DefaultTransform,int ObjMass)
{
	FillObject(Object,ScnNode, ObjName);
	InitiationAbstraction(ScnNode,ColliderShape,DefaultTransform,ObjMass);
}
void GameObject::initiate(btBoxShape* ColliderShape, Ogre::Light* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName, btTransform DefaultTransform, int ObjMass)
{
	FillObject(Object, ScnNode, ObjName);
	InitiationAbstraction(ScnNode, ColliderShape, DefaultTransform, ObjMass);
}
void GameObject::initiate(btBoxShape* ColliderShape, Ogre::Camera* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName, btTransform DefaultTransform, int ObjMass)
{
	FillObject(Object, ScnNode, ObjName);
	InitiationAbstraction(ScnNode, ColliderShape, DefaultTransform, ObjMass);
}
void GameObject::Subsystems(Physics* PhysicsManager, Renderer* renderer)
{
	PM = PhysicsManager;
	R = renderer;
}
void GameObject::InitiationAbstraction(Ogre::SceneNode* ScnNode,btBoxShape* ColliderShape, btTransform DefaultTransform, int ObjMass)
{
	mass = ObjMass;
	Transform = DefaultTransform;
	AssignTransform();
	btCollisionShape* newRigidShape = ColliderShape;
	AssignCollisionShape(newRigidShape);
	CollisionShape->calculateLocalInertia(mass, localInertia);
	btRigidBody::btRigidBodyConstructionInfo BodyInfo(mass, myMotionState, CollisionShape, localInertia);
	btRigidBody* Bdy = new btRigidBody(BodyInfo);
	AssignRigidBody(Bdy);
	RigidBody3d->setUserPointer(ScnNode);
	AddtoPhysicsSystem();
}