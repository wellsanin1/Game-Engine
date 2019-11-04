#include "GameObject.h"
#include <iostream>

class ObjectPool
{
public:
	ObjectPool();
	GameObject* PoolStorage[100];
	virtual ~ObjectPool() {};
	void StoreObject(Ogre::Entity* CreatedEntity, Ogre::SceneNode* CreatedNode);
	void StoreObject(Ogre::Light* CreatedEntity, Ogre::SceneNode* CreatedNode);
	void StoreObject(Ogre::Camera* CreatedEntity, Ogre::SceneNode* CreatedNode);
	GameObject* GetObject(Ogre::String ObjectName);

};