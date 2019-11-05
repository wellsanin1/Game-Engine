#pragma once
#include "Ogre.h"
//#include "btBulletDynamicsCommon.h"
struct GameObject
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
	//btRigidBody RigidBody3d;
	Ogre::SceneNode* Node;
	Ogre::String Name;
	StoredObj StoredObject;
	bool IsEmpty() { return Empty; };
	void FillObject(Ogre::Camera* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName);
	void FillObject(Ogre::Light* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName);
	void FillObject(Ogre::Entity* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName);
	void ClearObject();
	std::vector<float> Velocity = {0,0,0};
};