#include "Ogre.h"
struct PooledObject
{
private:
	bool Empty = true;
	union StoredObj
	{
		StoredObj() {};
		~StoredObj() {};
		Ogre::Camera* Camera;
		Ogre::Light* Light;
		Ogre::Entity* entity;
	};

public:
	Ogre::SceneNode* Node;
	Ogre::String Name;
	StoredObj StoredObject;
	bool IsEmpty() { return Empty; };
	void FillObject(Ogre::Camera* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName);
	void FillObject(Ogre::Light* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName);
	void FillObject(Ogre::Entity* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName);
	void ClearObject();
};

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