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
ObjectPool::ObjectPool()
{
	int size = sizeof(PoolStorage) / sizeof(*PoolStorage);
	for (int i = 0; i < size; i++)
	{
		PoolStorage[i] = new PooledObject();
	}
};

//Put Fill object with generic data
void ObjectPool::StoreObject(Ogre::Entity* CreatedEntity, Ogre::SceneNode* CreatedNode)
{
	int size = sizeof(PoolStorage) / sizeof(*PoolStorage);
	for (int i = 0; i < size; i++)
	{
		if (PoolStorage[i]->IsEmpty() == true)
		{
			CreatedNode->attachObject(CreatedEntity);
			PoolStorage[i]->FillObject(CreatedEntity, CreatedNode, CreatedEntity->getName());
			return;
		}
	}
	std::cerr << "Nothing Stored";
	return;
};

void ObjectPool::StoreObject(Ogre::Light* CreatedEntity, Ogre::SceneNode* CreatedNode)
{
	int size = sizeof(PoolStorage) / sizeof(*PoolStorage);
	for (int i = 0; i < size; i++)
	{
		if (PoolStorage[i]->IsEmpty() == true)
		{
			CreatedNode->attachObject(CreatedEntity);
			PoolStorage[i]->FillObject(CreatedEntity, CreatedNode, CreatedEntity->getName());
			return;
		}
	}
	std::cerr << "Nothing Stored";
	return;
};

void ObjectPool::StoreObject(Ogre::Camera* CreatedEntity, Ogre::SceneNode* CreatedNode)
{
	int size = sizeof(PoolStorage) / sizeof(*PoolStorage);
	for (int i = 0; i < size; i++)
	{
		if (PoolStorage[i]->IsEmpty() == true)
		{
			CreatedNode->attachObject(CreatedEntity);
			PoolStorage[i]->FillObject(CreatedEntity, CreatedNode, CreatedEntity->getName());
			return;
		}
	}
	std::cerr << "Nothing Stored";
	return;
};

PooledObject* ObjectPool::GetObject(Ogre::String ObjectName)
{
	int size = sizeof(PoolStorage) / sizeof(*PoolStorage);
	for (int i = 0; i < size; i++)
	{
		if (PoolStorage[i]->Name == ObjectName)
		{
			return PoolStorage[i];
		}
	}
	throw std::invalid_argument("Object with name " + ObjectName + " does not exist");
};