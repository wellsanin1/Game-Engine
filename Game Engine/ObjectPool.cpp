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

void ObjectPool::Update(EventQueue*EQ, Physics* PM, Renderer* R, LuaHelper* LH,NetworkManager* NM)
{
	EventQueue E = EventQueue();
	E = EQ[0];
	event EV = E.CheckQueueNoRemoval(event::ObjectPool);
	if (EV.EventType != NONE)
	{
		CreateEntity(EV.PD.Name, EV.PD.MeshName, EV.PD.Material
			, EV.PD.positions.x, EV.PD.positions.y, EV.PD.positions.z
			, EV.PD.Colliders.x, EV.PD.Colliders.y, EV.PD.Colliders.z
			, PM, R, LH,NM);
		EQ->CheckQueue(event::ObjectPool,true);
	}
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

GameObject* ObjectPool::GetObjectFromPool(std::string ObjectName)
{
	int size = sizeof(PoolStorage) / sizeof(*PoolStorage);
	for (int i = 0; i < size; i++)
	{
		if (PoolStorage[i]->Name == ObjectName)
		{
			return PoolStorage[i];
		}
	}
	GameObject* GO = new GameObject();
	return GO;
};

GameObject* ObjectPool::GetObjectFromPool(btRigidBody* RigidBody)
{
	int size = sizeof(PoolStorage) / sizeof(*PoolStorage);
	for (int i = 0; i < size; i++)
	{
		if (PoolStorage[i]->RigidBody3d == RigidBody)
		{

			return PoolStorage[i];
		}
	}
	GameObject* GO = new GameObject();
	return GO;
};

void ObjectPool::CreateCamera(std::string Name, int PosX, int PosY, int PosZ,Physics* PM,Renderer* R, LuaHelper* LH,NetworkManager* NM)
{
	GameObject* a = new GameObject();
	a->CreateCamera(PM, R, LH,NM, Name, PosX, PosY, PosZ);
	StoreObject(a);
}
void ObjectPool::CreateEntity(std::string Name, std::string MeshName, std::string MaterialName, int PosX, int PosY, int PosZ, int ColX, int ColY, int ColZ, Physics* PM, Renderer* R,LuaHelper* LH, NetworkManager* NM)
{
	GameObject* a = new GameObject();
	a->CreateEntity(PM, R, LH,NM, Name, MeshName,MaterialName, PosX, PosY, PosZ, ColX, ColY, ColZ);
	StoreObject(a);
}
void ObjectPool::CreateLight(std::string Name, int PosX, int PosY, int PosZ, Physics* PM, Renderer* R,LuaHelper* LH,NetworkManager* NM)
{
	GameObject* a = new GameObject();
	a->CreateLight(PM,R,LH,NM,Name, PosX, PosY, PosZ);
	StoreObject(a);
}