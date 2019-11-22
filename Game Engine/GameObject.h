#pragma once
//Forward declare headers to avoid circular dependancy
#include "GameObject.fwd.h"
#include "PhysicsManager.fwd.h"


#include "LuaStructs.h"
extern "C" {
# include "lua.h"
# include "lauxlib.h"
# include "lualib.h"
}
#include <LuaBridge/LuaBridge.h>
#include <lua.hpp>

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
	void AddtoPhysicsSystem(Physics* PM);
	void InitiationAbstraction(Physics* PM,Ogre::SceneNode* ScnNode,btBoxShape* ColliderShape, btTransform DefaultTransform, int ObjMass);
	void FillObject(Ogre::Camera* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName);
	void FillObject(Ogre::Light* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName);
	void FillObject(Ogre::Entity* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName);
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

	bool IsEmpty() { return Empty; };
	void ClearObject();

	//Propriatory
	void SetTransform(double x,double y, double z);
	std::vector<double> GetTransform();
	void SetOrientation(double w, double x, double y, double z);
	std::vector<double> GetOrientation();
	void SetMass(float NewMass,Physics* PM);
	void SetVelocity(float x, float y, float z);
	void AddVelocity(float x, float y, float z);


	void CreateEntity(Physics* PM, Renderer*R,std::string EntityName, std::string MeshName, int PosX, int PosY, int PosZ);
	void CreateLight(Physics* PM, Renderer* R,std::string LightName, int PosX, int PosY, int PosZ);
	void CreateCamera(Physics* PM, Renderer* R,std::string CameraName, int PosX, int PosY, int PosZ);

	StoredObj StoredObject;
	float Velocity[3] = {0,0,0};

	std::string Name = "";

	GameObject() {};
	~GameObject() {};

};