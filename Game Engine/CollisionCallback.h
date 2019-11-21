#pragma once
#include <btBulletCollisionCommon.h>
#include <btBulletDynamicsCommon.h>
struct CollisionCallback : public btCollisionWorld::ContactResultCallback
{
	btScalar CollisionCallback::addSingleResult(btManifoldPoint& cp, const btCollisionObject* colObj0, int partId0, int index0, const btCollisionObject* colObj1, int partId1, int index1);
};