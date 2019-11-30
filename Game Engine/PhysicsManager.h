#pragma once
//Forward declare headers to avoid circular dependancy
#include "PhysicsManager.fwd.h"
#include "GameObject.fwd.h"
#include "ObjectPool.fwd.h"

#include "btBulletDynamicsCommon.h"
#include "Bullet3Common/b3Vector3.h"
#include "GameEngineDefinitions.h"
#include "ObjectPool.h"
#include "EventSystem.h"
#include <vector>
#include <map>



class Physics {
private:
	ObjectPool* _OP;
public:
	Physics(ObjectPool* OP);
	~Physics() {};
	btDefaultCollisionConfiguration* collisionConfiguration;
	btCollisionDispatcher* dispatcher;
	btBroadphaseInterface* overlappingPairCache;
	btSequentialImpulseConstraintSolver* solver;
	btDiscreteDynamicsWorld* dynamicsWorld;
	std::vector<btCollisionShape*> collisionShapes;
	std::map<std::string, btRigidBody*> physicsAccessors;
	std::map<btRigidBody*, std::string> ReversePhysicsAccessors;


	void PhysicsUpdate(EventQueue* EQ);
	void CheckCollisions();
	void dealloc();

	void Restart();
	void CreateEntity(PhysicsData PD);
	void SetMass(PhysicsData PD);
	void TranslateLocally(PhysicsData PD);
	void SetVelocity(PhysicsData PD);
	void AddVelocity(PhysicsData PD);
	void Teleport(PhysicsData PD);
	void SetGravity(PhysicsData PD);

	typedef void (Physics::* Reactions)(PhysicsData);
	Reactions EventReactions[7] = 
	{
		&Physics::CreateEntity
		,&Physics::SetMass
		,&Physics::TranslateLocally
		,&Physics::SetVelocity
		,&Physics::AddVelocity
		,&Physics::Teleport
		,&Physics::SetGravity
	};

};