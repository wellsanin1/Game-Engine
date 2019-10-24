#include "Ogre.h"
#include <iostream>

struct PooledObject
{
	Ogre::MovableObject* Obj;
	Ogre::SceneNode* Node;
	Ogre::String Name;
};

class ObjectPool
{
public:
	ObjectPool() { PooledObject* PoolStorage[100]; };
	PooledObject* PoolStorage[100];
	virtual ~ObjectPool() {};
	void StoreObject(Ogre::MovableObject* CreatedEntity, Ogre::SceneNode* CreatedNode);
	PooledObject* GetObject(Ogre::String ObjectName);
};

PooledObject* ObjectPool::GetObject(Ogre::String ObjectName)
{
	int size = sizeof(PoolStorage) / sizeof(*PoolStorage);
	for (int i = 1; i < size; i++)
	{
		if (&PoolStorage[i]->Name == &ObjectName)
		{
			return PoolStorage[i];
		}
	}
	std::cerr << "Object with name" + ObjectName + " Does not exist";
	PooledObject* ErrorReturn = new PooledObject();
	return ErrorReturn;
};

void ObjectPool::StoreObject(Ogre::MovableObject* CreatedEntity, Ogre::SceneNode* CreatedNode)
{
	int size = sizeof(PoolStorage) / sizeof(*PoolStorage);
	for (int i = 1; i < size; i++)
	{
		if (&PoolStorage[i]->Obj == NULL && &PoolStorage[i]->Node == NULL)
		{
			PoolStorage[i]->Obj = CreatedEntity;
			PoolStorage[i]->Node = CreatedNode;
			PoolStorage[i]->Name = CreatedEntity->getName();
			std::cerr << "Object " + CreatedEntity->getName() + " Stored";
			return;
		}
	}
	std::cerr << "Nothing Stored";
	return;
};
