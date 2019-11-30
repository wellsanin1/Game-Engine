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
	std::fill(PoolStorage, PoolStorage + PoolSize, nullptr);
	int size = sizeof(PoolStorage) / sizeof(*PoolStorage);
	for (int i = 0; i < size; i++)
	{
		PoolStorage[i] = new GameObject();
	}
}

void ObjectPool::ClearPool(EventQueue*EQ)
{

}

void ObjectPool::Update(EventQueue*EQ,void*LuaState)
{
	for (int i = 0; i < EQ->Queue.size(); ++i)
	{
		event EV = EQ->CheckQueueReturnEvent(SubSystem_ObjectPool);
		if (EV.Empty == false)
		{
			for (int j = 0; j < EV.SubSystemList.size(); ++j)
			{
				if (EV.SubSystemList[j] == SubSystem_ObjectPool)
				{
					Reactions A = EventReactions[(int)EV.ObjectPoolEventEnum];
					(this->*A)(EV.OD, EQ);
					EQ->RemoveFromQueue(SubSystem_ObjectPool);
				}
			}
		}
		else
		{
			break;
		}
	}

	for (int i = 0;i<PoolSize;++i)
	{
		if (PoolStorage[i]->Empty== false)
		{
			PoolStorage[i]->Update();
			PoolStorage[i]->register_lua(LuaState);
		}
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
	return nullptr;
};

void ObjectPool::CreateCamera(ObjectPoolData OD, EventQueue* EQ)
{
	GameObject* a = new GameObject();
	a->CreateCamera(EQ,OD.Name, OD.positions.x, OD.positions.z, OD.positions.z);
	StoreObject(a);
}
void ObjectPool::CreateEntity(ObjectPoolData OD, EventQueue* EQ)
{
	GameObject* a = new GameObject();
	a->CreateEntity(EQ,OD.Name, OD.MeshName,OD.Material
				, OD.positions.x, OD.positions.y, OD.positions.z
				, OD.Colliders.x, OD.Colliders.y, OD.Colliders.z);
	StoreObject(a);
}
void ObjectPool::CreateLight(ObjectPoolData OD, EventQueue* EQ)
{
	GameObject* a = new GameObject();
	a->CreateLight(EQ,OD.Name, OD.positions.x, OD.positions.y, OD.positions.z);
	StoreObject(a);
}