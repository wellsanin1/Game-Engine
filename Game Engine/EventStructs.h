#pragma once
#include "FunctionPointers.h"
struct PhysicsPointers
{
	void (*p[FunctionArraySize]) (btRigidBody* RB, float x, float y, float z);
};
struct RendererPointers
{
	void (*p[FunctionArraySize]) (btRigidBody* RB, float x, float y, float z);
};
struct AudioPointers
{
	void (*p[FunctionArraySize]) (btRigidBody* RB, float x, float y, float z);
};