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


	//Propriatory
	void AttachSystems(EventQueue*EQ);
	//BULLET
	EventQueue* _EQ;
	float _ColliderSize[3];
	std::vector<std::string> CollidedObjects;


public:
	bool Empty = true;

	Ogre::Camera* Camera;
	Ogre::Light* Light;
	Ogre::Entity* entity;
	btRigidBody* RigidBody3d;

	bool IsEmpty() { return Empty; };
	void ClearObject();
	std::string Etype;

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
	void CreateEntity(EventQueue* EQ, std::string EntityName, std::string MeshName,std::string MaterialName, int PosX, int PosY, int PosZ,int ColX,int ColY,int ColZ);
	void CreateLight(EventQueue* EQ, std::string LightName, int PosX, int PosY, int PosZ);
	void CreateCamera(EventQueue* EQ, std::string CameraName, int PosX, int PosY, int PosZ);
	void Teleport(double x, double y, double z);
	void Update();
	std::vector<double> GetLinearVelocity();

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