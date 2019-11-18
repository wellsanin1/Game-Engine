#pragma once
#include "GameObject.h"
#include "GameEngineDefinitions.h"
#include <iostream>

class ObjectPool
{
public:
	ObjectPool();
	GameObject* PoolStorage[PoolSize];
	virtual ~ObjectPool() {};
	//void StoreObject(Ogre::Entity* CreatedEntity, Ogre::SceneNode* CreatedNode);
	//void StoreObject(Ogre::Light* CreatedEntity, Ogre::SceneNode* CreatedNode);
	//void StoreObject(Ogre::Camera* CreatedEntity, Ogre::SceneNode* CreatedNode);
	void StoreObject(GameObject* Object);
	GameObject* GetObject(Ogre::String ObjectName);
	GameObject* GetObject(btRigidBody* RigidBody);
};