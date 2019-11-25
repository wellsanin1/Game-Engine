#include "ObjectPool.h"

ObjectPool::ObjectPool()
{
	int size = sizeof(PoolStorage) / sizeof(*PoolStorage);
	for (int i = 0; i < size; i++)
	{
		PoolStorage[i] = new GameObject();
	}
};

void ObjectPool::Reinitialise()
{
	int size = sizeof(PoolStorage) / sizeof(*PoolStorage);
	for (int i = 0; i < size; i++)
	{
		PoolStorage[i] = new GameObject();
	}
}

void ObjectPool::ClearPool(Renderer *R, Physics*PM)
{
	std::fill(PoolStorage, PoolStorage + PoolSize, nullptr);
	R->Restart();
	PM->Restart();
	Reinitialise();
}

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
	return nullptr;
};

GameObject* ObjectPool::GetObject(btRigidBody* RigidBody)
{
	int size = sizeof(PoolStorage) / sizeof(*PoolStorage);
	for (int i = 0; i < size; i++)
	{
		if (PoolStorage[i]->RigidBody3d == RigidBody)
		{
			return PoolStorage[i];
		}
	}
	throw std::invalid_argument("Object Rigidbody does not exist");
	return nullptr;
};

void ObjectPool::CreateCamera(std::string Name, int PosX, int PosY, int PosZ,Physics* PM,Renderer* R, LuaHelper* LH)
{
	GameObject* a = new GameObject();
	a->CreateCamera(PM, R, LH, Name, PosX, PosY, PosZ);
	StoreObject(a);
}
void ObjectPool::CreateEntity(std::string Name, std::string MeshName, std::string MaterialName, int PosX, int PosY, int PosZ, Physics* PM, Renderer* R,LuaHelper* LH)
{
	GameObject* a = new GameObject();
	a->CreateEntity(PM, R, LH, Name, MeshName,MaterialName, PosX, PosY, PosZ);
	StoreObject(a);
}
void ObjectPool::CreateLight(std::string Name, int PosX, int PosY, int PosZ, Physics* PM, Renderer* R,LuaHelper* LH)
{
	GameObject* a = new GameObject();
	a->CreateLight(PM,R,LH,Name, PosX, PosY, PosZ);
	StoreObject(a);
}