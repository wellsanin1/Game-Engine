#include "GameObject.h"

void GameObject::FillObject(Ogre::Camera* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName)
{
	ScnNode->attachObject(Object);
	Node = ScnNode;
	Name = ObjName;
	StoredObject.Camera = Object;
	Empty = false;
}
void GameObject::FillObject(Ogre::Light* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName)
{
	ScnNode->attachObject(Object);
	Node = ScnNode;
	Name = ObjName;
	StoredObject.Light = Object;
	Empty = false;
}
void GameObject::FillObject(Ogre::Entity* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName)
{
	ScnNode->attachObject(Object);
	Node = ScnNode;
	Name = ObjName;
	StoredObject.entity = Object;
	Empty = false;
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
	mass = ObjMass;
	Transform = DefaultTransform;
	FillObject(Object,ScnNode, ObjName);
	AssignTransform();
	btCollisionShape* newRigidShape = ColliderShape;
	AssignCollisionShape(newRigidShape);
	this->CollisionShape->calculateLocalInertia(mass, localInertia);
	btRigidBody::btRigidBodyConstructionInfo BodyInfo(mass, myMotionState, CollisionShape, localInertia);
	btRigidBody* Bdy = new btRigidBody(BodyInfo);
	AssignRigidBody(Bdy);
	RigidBody3d->setUserPointer(ScnNode);
	AddtoPhysicsSystem();

}
void GameObject::initiate(btBoxShape* ColliderShape, Ogre::Light* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName, btTransform DefaultTransform, int ObjMass)
{
	mass = ObjMass;
	Transform = DefaultTransform;
	FillObject(Object, ScnNode, ObjName);
	AssignTransform();
	btCollisionShape* newRigidShape = ColliderShape;
	AssignCollisionShape(newRigidShape);
	this->CollisionShape->calculateLocalInertia(mass, localInertia);
	btRigidBody::btRigidBodyConstructionInfo BodyInfo(mass, myMotionState, CollisionShape, localInertia);
	btRigidBody* Bdy = new btRigidBody(BodyInfo);
	AssignRigidBody(Bdy);
	RigidBody3d->setUserPointer(ScnNode);
	AddtoPhysicsSystem();
}
void GameObject::initiate(btBoxShape* ColliderShape, Ogre::Camera* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName, btTransform DefaultTransform, int ObjMass)
{
	mass = ObjMass;
	Transform = DefaultTransform;
	FillObject(Object, ScnNode, ObjName);
	AssignTransform();
	btCollisionShape* newRigidShape = ColliderShape;
	AssignCollisionShape(newRigidShape);
	this->CollisionShape->calculateLocalInertia(mass,localInertia);
	btRigidBody::btRigidBodyConstructionInfo BodyInfo(mass, myMotionState, CollisionShape, localInertia);
	btRigidBody* Bdy = new btRigidBody(BodyInfo);
	AssignRigidBody(Bdy);
	RigidBody3d->setUserPointer(ScnNode);
	AddtoPhysicsSystem();
}
GameObject::GameObject(Physics* PhysicsManager)
{
	PM = PhysicsManager;
}