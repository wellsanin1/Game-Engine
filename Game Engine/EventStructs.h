#pragma once
#include "GameEngineDefinitions.h"
#include "FunctionPointers.h"
#include <Ogre.h>
#include <btBulletCollisionCommon.h>
#include "NetworkingStructs.h"
struct PhysicsData
{
	std::string Name;
	std::string Material;
	int mass;
	Vector3 positions;
	Vector3 Colliders;
	Vector3 GenericVector;
};
struct RendererData
{
	std::string Name;
	std::string MeshName;
	Vector3 positions;
	Vector4 Orientation;
};
struct ObjectPoolData
{
	std::string Name;
	std::string MeshName;
	std::string e_type;
	std::string Material;
	int mass;
	Vector3 positions;
	Vector3 Colliders;
	Vector3 GenericVector;

};
struct AudioData
{
	std::string Name;
};