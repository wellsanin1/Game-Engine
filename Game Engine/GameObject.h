#pragma once
#include "PhysicsManager.h"
#include "Renderer.h"

struct GameObject
{
private:
	bool Empty = true;
	union StoredObj
	{
		StoredObj() {};
		~StoredObj() {};
		Ogre::Camera* Camera;
		Ogre::Light* Light;
		Ogre::Entity* entity;
	};
	//Propriatory
	void AssignRigidBody(btRigidBody* Rigidbody);
	void AssignTransform();
	void AssignCollisionShape(btCollisionShape* CollisionShape);
	void AddtoPhysicsSystem();
	void InitiationAbstraction(Ogre::SceneNode* ScnNode,btBoxShape* ColliderShape, btTransform DefaultTransform, int ObjMass);
	Physics* PM;
	Renderer* R;

public:
	//BULLET
	btCollisionShape* CollisionShape;
	btTransform Transform;
	btScalar mass = (0); //0 is static
	btVector3 localInertia = { 0, 0, 0 };
	btDefaultMotionState* myMotionState; //initialise = new btDefaultMotionState(startTransform);
	btRigidBody::btRigidBodyConstructionInfo* BodyInfo;
	btRigidBody* RigidBody3d;

	//OGRE
	Ogre::SceneNode* Node;
	Ogre::String Name;
	bool IsEmpty() { return Empty; };
	void FillObject(Ogre::Camera* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName);
	void FillObject(Ogre::Light* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName);
	void FillObject(Ogre::Entity* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName);
	void ClearObject();

	//Propriatory

	void CreateEntity(std::string EntityName, std::string MeshName);
	void CreateLight(std::string LightName);
	void CreateCamera(std::string CameraName);

	StoredObj StoredObject;
	std::vector<float> Velocity = {0,0,0};

	void initiate(btBoxShape* ColliderShape, Ogre::Entity* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName,btTransform DefaultTransform, int ObjMass);
	void initiate(btBoxShape* ColliderShape, Ogre::Light* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName, btTransform DefaultTransform, int ObjMass);
	void initiate(btBoxShape* ColliderShape, Ogre::Camera* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName, btTransform DefaultTransform, int ObjMass);

	void Subsystems (Physics* PhysicsManager,Renderer* renderer);
	GameObject() {};
	~GameObject() {};
};