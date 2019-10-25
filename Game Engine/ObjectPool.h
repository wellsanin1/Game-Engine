#include "PooledObject.h"
#include <iostream>


class ObjectPool
{
public:
	ObjectPool();
	PooledObject* PoolStorage[100];
	virtual ~ObjectPool() {};
	void StoreObject(Ogre::MovableObject* CreatedEntity, Ogre::SceneNode* CreatedNode);
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

void ObjectPool::StoreObject(Ogre::MovableObject* CreatedEntity, Ogre::SceneNode* CreatedNode)
{
	int size = sizeof(PoolStorage) / sizeof(*PoolStorage);
	for (int i = 0; i < size; i++)
	{
		if (PoolStorage[i]->IsEmpty() == true)
		{
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
