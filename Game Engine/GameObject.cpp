#include "GameObject.h"

void GameObject::SetTransform(double x, double y, double z)
{
	_Transform = { (float)x,(float)y,(float)z };
}
std::vector<double> GameObject::GetTransform()
{
	std::vector<double> ReturnTransform;
	ReturnTransform = {_Transform.x,_Transform.y,_Transform.z};
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
	_Velocity = { x,y,z };
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
	_Velocity = {_Velocity.x+x,_Velocity.y+y,_Velocity.z+z};
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
	_Transform.x = x;
	_Transform.y = y;
	_Transform.z = z;
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
	//Link ogre to bullet. Done because of time constraints easy to fix
	if (PhysicsAttached == true && OgreAttached == true && _linked == false)
	{
		_linked = true;
		std::cout << Name << ": IFcheck"<<std::endl;
		if(Etype == "Entity")
		{ 
			std::cout << Name << ": EntityLINKED" << std::endl;
			RigidBody3d->setUserPointer(entity->getParentSceneNode());
		}
		else if(Etype == "Light")
		{
			std::cout << Name << ": LightLINKED" << std::endl;
			RigidBody3d->setUserPointer(Light->getParentSceneNode());
		}
		else if (Etype == "Camera")
		{
			std::cout << Name << ": CameraLINKED" << std::endl;
			RigidBody3d->setUserPointer(Camera->getParentSceneNode());
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
	event A;
	A.SubSystemList.push_back(SubSystem_Network);
	A.NetworkEventType = Network_SENDPACKET;
	A.ND.Name = Name;
	A.ND.position.x = _Transform.x;
	A.ND.position.y = _Transform.y;
	A.ND.position.z = _Transform.z;
	A.ND.collider.x = _ColliderSize[0];
	A.ND.collider.y = _ColliderSize[1];
	A.ND.collider.z = _ColliderSize[2];
	A.ND.Velocity.x = _Velocity.x;
	A.ND.Velocity.y = _Velocity.y;
	A.ND.Velocity.z = _Velocity.z;
	A.Empty = false;
	_EQ->AddEvent(A);
}