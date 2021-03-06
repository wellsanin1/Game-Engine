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
	//Set _EQ
	EventQueue* _EQ;
	float _ColliderSize[3];
	//vector of objects colliding with *this* by name
	std::vector<std::string> CollidedObjects;

	bool _Enabled = true;
	bool _LuaRegistered = false;
	Vector3 _Transform;
	Vector3 _Velocity;
	std::string _MeshName = "";
	int _Mass = 0;

public:
	//Has object been initialised
	bool Empty = true;
	bool linked = false;

	std::string Etype;
	float Velocity[3] = { 0,0,0 };
	std::string Name = "";


	GameObject() {};
	~GameObject() {};
	void Update();
	void AttachSystems(EventQueue* EQ);

	//Propriatory
	//returns vectors to interface with lua
	void SetTransform(double x,double y, double z);
	std::vector<double> GetTransform();
	void SetOrientation(double w, double x, double y, double z);
	std::vector<double> GetOrientation();

	//collison functions
	int GetMass();

	void AddCollision(std::string ObjName);
	void RemoveCollision(std::string ObjName);
	bool GetCollision(std::string ObjName);
	void ClearCollision(std::string ObjName);

	//All of these functions create related events for their respective subsystems 
	//Some are obsolete and aren't being used but they remain in case they are needed
	void SetMass(float NewMass);
	void SetVelocity(float x, float y, float z);
	void AddVelocity(float x, float y, float z);
	bool IsColliding();
	void ChangeTexture(std::string TextureName);
	void LookAt(float X, float Y, float Z);
	void TranslateLocally(float X, float Y, float Z);
	void SendToClient();
	void CreateEntity(EventQueue* EQ, std::string EntityName,std::string MeshName,std::string MaterialName, int mass, int PosX, int PosY, int PosZ,int ColX,int ColY,int ColZ);
	void CreateLight(EventQueue* EQ, std::string LightName, int mass, int PosX, int PosY, int PosZ);
	void CreateCamera(EventQueue* EQ, std::string CameraName, int mass, int PosX, int PosY, int PosZ);
	void Teleport(double x, double y, double z);
	void SetGravity(float x,float y,float z);

	bool IsEmpty() { return Empty; };
	void ClearObject();
	std::vector<double> GetLinearVelocity();

	//LUA Interface here because lua needs to access specific GameObjects
	void register_lua(void* L)
	{
		if (_LuaRegistered == false)
		{
			_LuaRegistered = true;
			using namespace luabridge;
			lua_State* LS = static_cast<lua_State*>(L);
			getGlobalNamespace(LS)
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
				.addFunction("SetGravity",&GameObject::SetGravity)
				.addFunction("Teleport", &GameObject::Teleport)
				.endClass()
				.endNamespace();
		}
	}
};