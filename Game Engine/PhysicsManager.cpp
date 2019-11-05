#include "PhysicsManager.h"

void PhysicsManager::Movement(ObjectPool* OP)
{
	std::cout << "test" << std::endl;
	int PoolSize = sizeof(OP->PoolStorage) / sizeof(OP->PoolStorage);
	for (int i = 0; i<PoolSize; ++i)
	{
		OP->PoolStorage[i]->Node->translate(OP->PoolStorage[i]->Velocity[0], OP->PoolStorage[i]->Velocity[1], OP->PoolStorage[i]->Velocity[2]);
	}
}

void PhysicsManager::Collision()
{

}
void PhysicsManager::CreateRigidbody()
{

}

void PhysicsManager::GetObjectPool(ObjectPool* EnginePool)
{
	ObjPool = EnginePool;
}
