#include "Ogre.h"
struct PooledObject
{
public:
	Ogre::MovableObject* Obj;
	Ogre::SceneNode* Node;
	Ogre::String Name;
	bool IsEmpty() { return Empty; };
	void FillObject(Ogre::MovableObject* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName);
	void ClearObject();
private:
	bool Empty = true;
};

void PooledObject::FillObject(Ogre::MovableObject* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName)
{
	Obj = Object;
	Node = ScnNode;
	Name = ObjName;
	Empty = false;
}

void PooledObject::ClearObject()
{
	Obj = NULL;
	Node = NULL;
	Name = "";
	Empty = true;
};