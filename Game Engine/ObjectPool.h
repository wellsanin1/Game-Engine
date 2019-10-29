#include "PooledObject.h"
#include <iostream>

class ObjectPool
{
public:
	ObjectPool();
	PooledObject* PoolStorage[100];
	virtual ~ObjectPool() {};
	void StoreObject(Ogre::Entity* CreatedEntity, Ogre::SceneNode* CreatedNode);
	void StoreObject(Ogre::Light* CreatedEntity, Ogre::SceneNode* CreatedNode);
	void StoreObject(Ogre::Camera* CreatedEntity, Ogre::SceneNode* CreatedNode);
	PooledObject* GetObject(Ogre::String ObjectName);

};