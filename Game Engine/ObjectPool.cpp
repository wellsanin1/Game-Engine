#include "ObjectPool.h"

ObjectPool::ObjectPool()
{
	int size = sizeof(PoolStorage) / sizeof(*PoolStorage);
	for (int i = 0; i < size; i++)
	{
		PoolStorage[i] = new GameObject();
	}
};

void ObjectPool::StoreObject(GameObject* Object)
{
	int size = sizeof(PoolStorage) / sizeof(*PoolStorage);
	for (int i = 0; i < size; i++)
	{
		if (PoolStorage[i]->IsEmpty() == true)
		{
			PoolStorage[i] = Object;
			return;
		}
	}
	std::cerr << "Nothing Stored";
	return;
};

GameObject* ObjectPool::GetObject(Ogre::String ObjectName)
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