#pragma once
//Forward declare headers to avoid circular dependancy
#include "GameObject.fwd.h"
#include "PhysicsManager.fwd.h"
#include "LUAHelper.fwd.h"
#include "NetworkManager.fwd.h"



#include "LuaStructs.h"
extern "C" {
# include "lua.h"
# include "lauxlib.h"
# include "lualib.h"
}
#include <LuaBridge/LuaBridge.h>
#include <LuaBridge/Vector.h>
#include <lua.hpp>
#include <LuaBridge/RefCountedPtr.h>

#include "NetworkManager.h"
#include "LUAHelper.h"
#include "PhysicsManager.h"
#include "Renderer.h"
#include <OgreVector3.h>
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
	void InitiationAbstraction(Ogre::SceneNode* ScnNode,btBoxShape* ColliderShape, btTransform DefaultTransform, int ObjMass);
	void FillObject(Ogre::Camera* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName);
	void FillObject(Ogre::Light* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName);
	void FillObject(Ogre::Entity* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName);
	void AttachSystems(Physics* PM, Renderer* R, LuaHelper* LH, NetworkManager* NM);
	//BULLET
	btTransform Transform;

	Physics* _PM;
	Renderer* _R;
	LuaHelper* _LH;
	NetworkManager* _NM;
	std::string _MeshName;
	std::string _Material;
	float _ColliderSize[3];
	std::vector<std::string> CollidedObjects;
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

	void AddCollision(std::string ObjName);
	void RemoveCollision(std::string ObjName);
	bool GetCollision(std::string ObjName);
	void ClearCollision(std::string ObjName);

	void SetMass(float NewMass);
	void SetVelocity(float x, float y, float z);
	void AddVelocity(float x, float y, float z);
	bool IsColliding();
	void ChangeTexture(std::string TextureName);
	void LookAt(float X, float Y, float Z);
	void TranslateLocally(float X, float Y, float Z);
	void SendToClient();
	void CreateEntity(Physics* PM, Renderer* R, LuaHelper* LH, NetworkManager* NM, std::string EntityName, std::string MeshName,std::string MaterialName, int PosX, int PosY, int PosZ,int ColX,int ColY,int ColZ);
	void CreateLight(Physics* PM, Renderer* R, LuaHelper* LH, NetworkManager* NM, std::string LightName, int PosX, int PosY, int PosZ);
	void CreateCamera(Physics* PM, Renderer* R, LuaHelper* LH, NetworkManager* NM, std::string CameraName, int PosX, int PosY, int PosZ);

	GameObject CollideObject();

	StoredObj StoredObject;
	float Velocity[3] = {0,0,0};

	std::string Name = "";

	GameObject() {};
	~GameObject() {};

	//LUA Interface
	void register_lua(lua_State* L)
	{
		using namespace luabridge;
		getGlobalNamespace(L)
			.beginNamespace("GObject")
			.beginClass<GameObject>("GameObject")
			.addFunction("SetMass", &GameObject::SetMass)
			.addFunction("SetVelocity", &GameObject::SetVelocity)
			.addFunction("AddVelocity", &GameObject::AddVelocity)
			.addFunction("IsColliding", &GameObject::IsColliding)
			.addFunction("GetCollision", &GameObject::GetCollision)
			.addFunction("ChangeTexture", &GameObject::ChangeTexture)
			.addFunction("GetTransform", &GameObject::GetTransform)
			.addFunction("SetTransform", &GameObject::SetTransform)
			.addFunction("GetOrientation", &GameObject::GetOrientation)
			.addFunction("TranslateLocally", &GameObject::TranslateLocally)
			.addFunction("SendToClient", &GameObject::SendToClient)
			.addFunction("LookAt", &GameObject::LookAt)
			.endClass()
			.endNamespace();
	}
};