#pragma once
#include "PhysicsManager.h"
#include "Renderer.h"
#include <vector>

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
	void FillObject(Ogre::Camera* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName);
	void FillObject(Ogre::Light* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName);
	void FillObject(Ogre::Entity* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName);
	Physics* PM;
	Renderer* R;
	//BULLET
	btTransform Transform;

public:
	//BULLET
	btCollisionShape* CollisionShape;
	btScalar mass = (0); //0 is static
	btVector3 localInertia = { 0, 0, 0 };
	btDefaultMotionState* myMotionState; //initialise = new btDefaultMotionState(startTransform);
	btRigidBody::btRigidBodyConstructionInfo* BodyInfo;
	btRigidBody* RigidBody3d;

	//OGRE
	Ogre::SceneNode* Node;
	Ogre::String Name;
	bool IsEmpty() { return Empty; };
	void ClearObject();

	//Propriatory
	void SetTransform(double x,double y, double z);
	std::vector<double> GetTransform();
	void SetOrientation(double w, double x, double y, double z);
	std::vector<double> GetOrientation();

	void CreateEntity(std::string EntityName, std::string MeshName, int PosX, int PosY, int PosZ);
	void CreateLight(std::string LightName, int PosX, int PosY, int PosZ);
	void CreateCamera(std::string CameraName, int PosX, int PosY, int PosZ);

	StoredObj StoredObject;
	std::vector<float> Velocity = {0,0,0};

	void initiate(btBoxShape* ColliderShape, Ogre::Entity* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName,btTransform DefaultTransform, int ObjMass);
	void initiate(btBoxShape* ColliderShape, Ogre::Light* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName, btTransform DefaultTransform, int ObjMass);
	void initiate(btBoxShape* ColliderShape, Ogre::Camera* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName, btTransform DefaultTransform, int ObjMass);

	void Subsystems (Physics* PhysicsManager,Renderer* renderer);
	GameObject() {};
	~GameObject() {};
};