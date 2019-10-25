#include "Ogre.h"
struct PooledObject
{
private:
	bool Empty = true;
	union StoredObj
	{
		StoredObj() {};
		~StoredObj() {};
		Camera Camera;
		Light Light;
		Entity Entity;
	};


public:
	Ogre::MovableObject* Obj;
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
	Obj = Object;
	Node = ScnNode;
	Name = ObjName;
	StoredObject.Camera = Object;

	Empty = false;
}
void PooledObject::FillObject(Ogre::Light* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName)
{
	Obj = Object;
	Node = ScnNode;
	Name = ObjName;
	StoredObject.Light = Object;
}
void PooledObject::FillObject(Ogre::Entity* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName)
{
	Obj = Object;
	Node = ScnNode;
	Name = ObjName;
	StoredObject.Entity = Object;
}

void PooledObject::ClearObject()
{
	Obj = NULL;
	Node = NULL;
	Name = "";
	Empty = true;
};