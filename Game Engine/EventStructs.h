#pragma once
#include "GameEngineDefinitions.h"
#include "FunctionPointers.h"
#include <Ogre.h>
#include <btBulletCollisionCommon.h>
#include "NetworkingStructs.h"
struct PhysicsData
{
	std::string Name;
	std::string MeshName;
	std::string Material;
	int packetType = 1;
	int clients;
	Vector3 positions;
	Vector3 Colliders;
	void (*p[FunctionArraySize]) (btRigidBody* RB, float x, float y, float z);
};
struct RendererData
{

};
struct AudioData
{

};