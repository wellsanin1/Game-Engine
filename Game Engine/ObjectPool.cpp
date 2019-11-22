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

void ObjectPool::CreateCamera(std::string Name, int PosX, int PosY, int PosZ,Physics* PM,Renderer* R)
{
	GameObject* a = new GameObject();
	a->CreateCamera(PM, R, Name, PosX, PosY, PosZ);
	StoreObject(a);
}
void ObjectPool::CreateEntity(std::string Name, std::string MeshName, int PosX, int PosY, int PosZ, Physics* PM, Renderer* R)
{
	GameObject* a = new GameObject();
	a->CreateEntity(PM, R, Name, MeshName, PosX, PosY, PosZ);
	StoreObject(a);
}
void ObjectPool::CreateLight(std::string Name, int PosX, int PosY, int PosZ, Physics* PM, Renderer* R)
{
	GameObject* a = new GameObject();
	a->CreateLight(PM, R, Name, PosX, PosY, PosZ);
	StoreObject(a);
}

void ObjectPool::register_lua(lua_State* L)
{
	using namespace luabridge;
	getGlobalNamespace(L) //global namespace to lua
		.beginNamespace("Pool") //our defined namespace (w.e we want to call it)
		.beginClass<ObjectPool>("ObjectPool") //define class object
		.addConstructor<void (*)(void)>() //reg. empty constructor
		.addFunction("CreateCamera", &ObjectPool::CreateCamera) //reg. setName function
		.addFunction("CreateEntity", &ObjectPool::CreateEntity) //reg. setName function
		.addFunction("CreateLight", &ObjectPool::CreateLight) //reg. setName function
		.endClass() //end class
		.endNamespace(); //end namespace
}
