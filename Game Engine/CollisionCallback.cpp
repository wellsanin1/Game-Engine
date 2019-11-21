#include "CollisionCallback.h"

btScalar CollisionCallback::addSingleResult(btManifoldPoint& cp, const btCollisionObject* colObj0, int partId0, int index0, const btCollisionObject* colObj1, int partId1, int index1)
{
	btVector3 ptA = cp.getPositionWorldOnA();
	btVector3 ptB = cp.getPositionWorldOnB();
	return 0;
	//return btScalar();
}
