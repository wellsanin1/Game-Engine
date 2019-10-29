#include "PooledObject.h"

void PooledObject::FillObject(Ogre::Camera* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName)
{
	Node = ScnNode;
	Name = ObjName;
	StoredObject.Camera = Object;
	Empty = false;
}
void PooledObject::FillObject(Ogre::Light* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName)
{
	Node = ScnNode;
	Name = ObjName;
	StoredObject.Light = Object;
	Empty = false;
}
void PooledObject::FillObject(Ogre::Entity* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName)
{
	Node = ScnNode;
	Name = ObjName;
	StoredObject.entity = Object;
	Empty = false;
}

void PooledObject::ClearObject()
{
	Node = NULL;
	Name = "";
	Empty = true;
};