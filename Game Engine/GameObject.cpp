#include "GameObject.h"

void GameObject::SetTransform(double x, double y, double z)
{
	Transform = { (float)x,(float)y,(float)z };
}
std::vector<double> GameObject::GetTransform()
{
	std::vector<double> ReturnTransform;
	ReturnTransform = {Transform.x,Transform.y,Transform.z};
	return ReturnTransform;
}
void GameObject::SetOrientation(double w, double x, double y, double z)
{
	event A;
	A.SubSystemList.push_back(SubSystem_Renderer);
	A.RenderEventType = Render_SETPOSITION;
	A.RD.Name = Name;
	A.RD.Orientation = { (float)w, (float)x,(float)y,(float)z };
	A.Empty = false;
	_EQ->AddEvent(A);
}
std::vector<double> GameObject::GetOrientation()
{
	std::vector<double> ReturnQuat = {0,0,0,0};
	return ReturnQuat;
}

void GameObject::AddCollision(std::string ObjName)
{
	for (int i = 0; i < CollidedObjects.size(); ++i)
	{
		if (ObjName == CollidedObjects[i])
		{
			return;
		}
	}
	CollidedObjects.push_back(ObjName);
}

void GameObject::RemoveCollision(std::string ObjName)
{
	for (int i = 0; i < CollidedObjects.size(); ++i)
	{
		if (ObjName == CollidedObjects[i])
		{
			CollidedObjects.erase(CollidedObjects.begin()+i);
		}
	}
}

bool GameObject::GetCollision(std::string ObjName)
{
	for (int i = 0;i<CollidedObjects.size();++i)
	{
		if (ObjName == CollidedObjects[i])
		{
			return true;
		}
	}
	return false;
}

void GameObject::ClearCollision(std::string ObjName)
{
	for (int i=0; i<CollidedObjects.size();++i)
	{
		if (CollidedObjects[i] == ObjName)
		{
			CollidedObjects.erase(CollidedObjects.begin() + i);
		}
	}
}

void GameObject::SetMass(float NewMass)
{
	event A;
	A.SubSystemList.push_back(SubSystem_Physics);
	A.PhysicsEventType = Physics_SETMASS;
	A.PD.Name = Name;
	A.PD.mass = NewMass;
	A.Empty = false;
	_EQ->AddEvent(A);
}

void GameObject::SetVelocity(float x, float y, float z)
{
	event A;
	A.SubSystemList.push_back(SubSystem_Physics);
	A.PhysicsEventType = Physics_SETVELOCITY;
	A.PD.Name = Name;
	A.PD.GenericVector.x = x;
	A.PD.GenericVector.y = y;
	A.PD.GenericVector.z = z;
	A.Empty = false;
	_EQ->AddEvent(A);
}

void GameObject::AddVelocity(float x, float y, float z)
{
	event A;
	A.SubSystemList.push_back(SubSystem_Physics);
	A.PhysicsEventType = Physics_ADDVELOCITY;
	A.PD.Name = Name;
	A.PD.GenericVector.x = x;
	A.PD.GenericVector.y = y;
	A.PD.GenericVector.z = z;
	A.Empty = false;
	_EQ->AddEvent(A);
}
bool GameObject::IsColliding()
{
	if (!CollidedObjects.empty())
	{
		return true;
	}
	return false;
}
void GameObject::ChangeTexture(std::string TextureName)
{
	//event A;
	//A.SubSystemList.push_back(SubSystem_Renderer);
	//A.SubSystemList.push_back(SubSystem_Physics);
	//A.RenderEventType = Render_LOOKAT;
	//A.PD.Name = Name;
	//A.PD.Material = TextureName;
	//A.Empty = false;
	//_EQ->AddEvent(A);
}
void GameObject::LookAt(float X,float Y,float Z)
{
	event A;
	A.SubSystemList.push_back(SubSystem_Renderer);
	A.RenderEventType = Render_LOOKAT;
	A.RD.Name = Name;
	A.RD.positions.x = X;
	A.RD.positions.y = Y;
	A.RD.positions.z = Z;
	A.Empty = false;
	_EQ->AddEvent(A);
}
void GameObject::CreateEntity(EventQueue* EQ, std::string EntityName,std::string MeshName,std::string MaterialName, int PosX, int PosY, int PosZ,int ColX, int ColY, int ColZ)
{
	this->Name = EntityName;
	this->Etype = "Entity";
	this->Empty = false;
	AttachSystems(EQ);
	event A;
	A.SubSystemList.push_back(SubSystem_Renderer);
	A.SubSystemList.push_back(SubSystem_Physics);
	A.PhysicsEventType = Physics_CREATEENTITY;
	A.RenderEventType = Render_CREATEENTITY;
	A.PD.Name = EntityName;

	A.PD.Colliders.x = ColX;
	A.PD.Colliders.y = ColY;
	A.PD.Colliders.z = ColZ;

	A.PD.positions.x = PosX;
	A.PD.positions.y = PosY;
	A.PD.positions.z = PosZ;

	A.PD.mass = 10;

	A.RD.Name = EntityName;
	A.RD.MeshName = MeshName;
	A.Empty = false;
	EQ->AddEvent(A);
}
void GameObject::CreateLight(EventQueue* EQ, std::string LightName, int PosX, int PosY, int PosZ)
{
	this->Name = LightName;
	this->Etype = "Light";
	this->Empty = false;
	AttachSystems(EQ);
	event A;
	A.SubSystemList.push_back(SubSystem_Renderer);
	A.SubSystemList.push_back(SubSystem_Physics);
	A.PhysicsEventType = Physics_CREATEENTITY;
	A.RenderEventType = Render_CREATELIGHT;
	A.PD.Name = LightName;
	A.PD.positions.x = PosX;
	A.PD.positions.y = PosY;
	A.PD.positions.z = PosZ;
	A.PD.Colliders.x = 0;
	A.PD.Colliders.y = 0;
	A.PD.Colliders.z = 0;
	A.PD.mass = 10;

	A.RD.Name = LightName;
	A.Empty = false;
	EQ->AddEvent(A);
}
void GameObject::CreateCamera(EventQueue*EQ,std::string CameraName, int PosX, int PosY, int PosZ)
{
	this->Name = CameraName;
	this->Etype = "Camera";
	this->Empty = false;
	AttachSystems(EQ);
	event A;
	A.SubSystemList.push_back(SubSystem_Renderer);
	A.SubSystemList.push_back(SubSystem_Physics);
	A.PhysicsEventType = Physics_CREATEENTITY;
	A.RenderEventType = Render_CREATECAMERA;
	A.PD.Name = CameraName;
	A.PD.positions.x = PosX;
	A.PD.positions.y = PosY;
	A.PD.positions.z = PosZ;
	A.PD.Colliders.x = 0;
	A.PD.Colliders.y = 0;
	A.PD.Colliders.z = 0;
	A.PD.mass = 10;

	A.RD.Name = CameraName;
	A.Empty = false;
	EQ->AddEvent(A);
}
void GameObject::Teleport(double x, double y, double z)
{
	event A;
	A.SubSystemList.push_back(SubSystem_Physics);
	A.PhysicsEventType = Physics_TELEPORT;
	A.PD.Name = Name;
	A.PD.positions.x = x;
	A.PD.positions.y = y;
	A.PD.positions.z = z;
	A.Empty = false;
	_EQ->AddEvent(A);
}
void GameObject::Update()
{
	if (PhysicsAttached == true && OgreAttached == true && _linked == false)
	{
		_linked = true;
		std::cout << Name << ": IFcheck"<<std::endl;
		if(Etype == "Entity")
		{ 
			std::cout << Name << ": EntityLINKED" << std::endl;
			RigidBody3d->setUserPointer(entity->getParentSceneNode());
			std::cout << entity->getParentSceneNode()->getPosition().x;
			std::cout << ":";
			std::cout << entity->getParentSceneNode()->getPosition().y;
			std::cout << ":";
			std::cout << entity->getParentSceneNode()->getPosition().z;
			std::cout << std::endl;
		}
		else if(Etype == "Light")
		{
			std::cout << Name << ": LightLINKED" << std::endl;
			RigidBody3d->setUserPointer(Light->getParentSceneNode());
			std::cout << Light->getParentSceneNode()->getPosition().x;
			std::cout << ":";
			std::cout << Light->getParentSceneNode()->getPosition().y;
			std::cout << ":";
			std::cout << Light->getParentSceneNode()->getPosition().z;
			std::cout << std::endl;
		}
		else if (Etype == "Camera")
		{
			std::cout << Name << ": CameraLINKED" << std::endl;
			RigidBody3d->setUserPointer(Camera->getParentSceneNode());
			std::cout << Camera->getParentSceneNode()->getPosition().x;
			std::cout << ":";
			std::cout << Camera->getParentSceneNode()->getPosition().y;
			std::cout << ":";
			std::cout << Camera->getParentSceneNode()->getPosition().z;
			std::cout << std::endl;
		}
	}
}
void GameObject::SetGravity(float x, float y, float z)
{
	event A;
	A.SubSystemList.push_back(SubSystem_Physics);
	A.PhysicsEventType = Physics_SETGRAVITY;
	A.PD.Name = Name;
	A.PD.GenericVector.x = x;
	A.PD.GenericVector.y = y;
	A.PD.GenericVector.z = z;
	A.Empty = false;
	_EQ->AddEvent(A);
}

std::vector<double> GameObject::GetLinearVelocity()
{
	//btVector3 a = RigidBody3d->getLinearVelocity();
	std::vector<double> Vector = {Velocity[0],Velocity[1],Velocity[2]};
	return Vector;
}

void GameObject::AttachSystems(EventQueue* EQ)
{
	_EQ = EQ;
	//register_lua(_LH->L());
}

void GameObject::ClearObject()
{
	/*Node = nullptr;
	Name = "";
	Empty = true;*/
}

void GameObject::TranslateLocally(float X, float Y, float Z)
{
	event A;
	A.SubSystemList.push_back(SubSystem_Physics);
	A.PhysicsEventType = Physics_TRANSLATELOCALLY;
	A.PD.Name = Name;
	A.PD.GenericVector.x = X;
	A.PD.GenericVector.y = Y;
	A.PD.GenericVector.z = Z;
	A.Empty = false;
	_EQ->AddEvent(A);
}
void GameObject::SendToClient()
{
	/*Vector3 a = Vector3{ Node->getPosition().x, Node->getPosition().y, Node->getPosition().z };
	Vector3 b = Vector3{ _ColliderSize[0], _ColliderSize[1], _ColliderSize[2] };
	std::vector<double> Vector = GetLinearVelocity();
	Vector3 c = { Vector[0],Vector[1],Vector[2] };*/

	//_NM->SendPacket(Name,_MeshName,_Material,a,b,c);
}