#include "GameObject.h"

void GameObject::FillObject(Ogre::Camera* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName)
{
	Node = ScnNode;
	Name = ObjName;
	StoredObject.Camera = Object;
	Empty = false;
}
void GameObject::FillObject(Ogre::Light* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName)
{
	Node = ScnNode;
	Name = ObjName;
	StoredObject.Light = Object;
	Empty = false;
}
void GameObject::FillObject(Ogre::Entity* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName)
{
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
};
void GameObject::initiate(btBoxShape* ColliderShape, Ogre::Entity* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName)
{
	FillObject(Object,ScnNode, ObjName);
	AssignTransform();
	btCollisionShape* newRigidShape = ColliderShape;
	AssignCollisionShape(newRigidShape);
	btRigidBody::btRigidBodyConstructionInfo BodyInfo(mass, myMotionState, CollisionShape, localInertia);
	btRigidBody* Bdy = new btRigidBody(BodyInfo);
	AssignRigidBody(Bdy);
}
void GameObject::initiate(btBoxShape* ColliderShape, Ogre::Light* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName)
{
	FillObject(Object, ScnNode, ObjName);
	AssignTransform();
	btCollisionShape* newRigidShape = ColliderShape;
	AssignCollisionShape(newRigidShape);
	btRigidBody::btRigidBodyConstructionInfo BodyInfo(mass, myMotionState, CollisionShape, localInertia);
	btRigidBody* Bdy = new btRigidBody(BodyInfo);
	AssignRigidBody(Bdy);
}
void GameObject::initiate(btBoxShape* ColliderShape, Ogre::Camera* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName)
{
	FillObject(Object, ScnNode, ObjName);
	AssignTransform();
	btCollisionShape* newRigidShape = ColliderShape;
	AssignCollisionShape(newRigidShape);
	btRigidBody::btRigidBodyConstructionInfo BodyInfo(mass, myMotionState, CollisionShape, localInertia);
	btRigidBody* Bdy = new btRigidBody(BodyInfo);
	AssignRigidBody(Bdy);
}