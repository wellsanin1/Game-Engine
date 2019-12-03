#include "ObjectPool.h"

ObjectPool::ObjectPool()
{
	//initiate objectpool with empty objects
	int size = sizeof(PoolStorage) / sizeof(*PoolStorage);
	for (int i = 0; i < size; i++)
	{
		PoolStorage[i] = new GameObject();
	}
};

void ObjectPool::Reinitialise()
{
	//Empty objectpool and reload for new level
	std::fill(PoolStorage, PoolStorage + PoolSize, nullptr);
	for (int i = 0; i < PoolSize; i++)
	{
		PoolStorage[i] = new GameObject();
	}
}

void ObjectPool::DeallocPool()
{
	for (int i = 0; i < PoolSize; i++)
	{
		delete PoolStorage[i];
	}
}

void ObjectPool::Update(EventQueue*EQ,void*LuaState)
{
	//function pointer loop
	for (int i = 0; i < EQ->Queue.size(); ++i)
	{
		event EV = EQ->CheckQueueReturnEvent(SubSystem_ObjectPool);
		if (EV.Empty == false)
		{
			Reactions A = EventReactions[(int)EV.ObjectPoolEventEnum];
			(this->*A)(EV.OD, EQ);
			EQ->RemoveFromQueue(SubSystem_ObjectPool);
		}
		else
		{
			break;
		}
	}

	//some propriatory stuff, done here because of time but can probably be removed later
	for (int i = 0;i<PoolSize;++i)
	{
		if (PoolStorage[i]->Empty == false)
		{
			PoolStorage[i]->Update();
			PoolStorage[i]->register_lua(LuaState);
		}
	}
}

//Put Gameobject at first empty spot in objectpool
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

//return GameObject by name, returns nullptr
GameObject* ObjectPool::GetObjectFromPool(std::string ObjectName)
{
	for (int i = 0; i < PoolSize; i++)
	{
		if (PoolStorage[i]->Name == ObjectName)
		{
			return PoolStorage[i];
		}
	}
	return nullptr;
}
//return GameObject by name, returns Empty Gameobject
GameObject* ObjectPool::IfObjectExists(std::string ObjectName)
{
	for (int i = 0; i < PoolSize; i++)
	{
		if (PoolStorage[i]->Name == ObjectName)
		{
			return PoolStorage[i];
		}
	}
	GameObject* a = new GameObject();
	return a;
};
void ObjectPool::CreateCamera(ObjectPoolData OD, EventQueue* EQ)
{
	GameObject* a = new GameObject();
	a->CreateCamera(EQ,OD.Name,OD.mass, OD.positions.x, OD.positions.z, OD.positions.z);
	StoreObject(a);
}
void ObjectPool::CreateEntity(ObjectPoolData OD, EventQueue* EQ)
{
	GameObject* a = new GameObject();
	a->CreateEntity(EQ,OD.Name, OD.MeshName,OD.Material,OD.mass
				, OD.positions.x, OD.positions.y, OD.positions.z
				, OD.Colliders.x, OD.Colliders.y, OD.Colliders.z);
	StoreObject(a);
}
void ObjectPool::CreateLight(ObjectPoolData OD, EventQueue* EQ)
{
	GameObject* a = new GameObject();
	a->CreateLight(EQ,OD.Name, OD.mass, OD.positions.x, OD.positions.y, OD.positions.z);
	StoreObject(a);
}