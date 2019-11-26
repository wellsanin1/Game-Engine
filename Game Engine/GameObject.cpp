#include "GameObject.h"

void GameObject::FillObject(Ogre::Camera* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName)
{
	Node = ScnNode;
	ScnNode->attachObject(Object);
	Name = ObjName;
	StoredObject.Camera = Object;
	Empty = false;
}
void GameObject::FillObject(Ogre::Light* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName)
{
	Node = ScnNode;
	ScnNode->attachObject(Object);
	Name = ObjName;
	StoredObject.Light = Object;
	Empty = false;
}
void GameObject::FillObject(Ogre::Entity* Object, Ogre::SceneNode* ScnNode, Ogre::String ObjName)
{
	Node = ScnNode;
	ScnNode->attachObject(Object);
	Name = ObjName;
	StoredObject.entity = Object;
	Empty = false;
}
void GameObject::SetTransform(double x, double y, double z)
{
	Node->setPosition(x,y,z);
}
std::vector<double> GameObject::GetTransform()
{
	std::vector<double> ReturnTransform;
	Ogre::Vector3 Pos = Node->getPosition();//  Transform.getOrigin();
	ReturnTransform = {Pos.x,Pos.y,Pos.z};
	return ReturnTransform;
}
void GameObject::SetOrientation(double w, double x, double y, double z)
{
	Node->setOrientation(Ogre::Quaternion(w, x, y, z));
}
std::vector<double> GameObject::GetOrientation()
{
	Ogre::Quaternion Orien = Node->getOrientation();
	std::vector<double> ReturnQuat = {Orien.w,Orien.x,Orien.y,Orien.z};
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
	_PM->dynamicsWorld->removeRigidBody(RigidBody3d);
	mass = NewMass;
	CollisionShape->calculateLocalInertia(mass,localInertia);
	btRigidBody::btRigidBodyConstructionInfo BodyInfo(mass, myMotionState, CollisionShape, localInertia);
	btRigidBody* RB = new btRigidBody(BodyInfo);
	AssignRigidBody(RB);
	RigidBody3d->setUserPointer(Node);
	AddtoPhysicsSystem(_PM);
	_PM->dynamicsWorld->addRigidBody(RigidBody3d);
}

void GameObject::SetVelocity(float x, float y, float z)
{
	Velocity[0] = x;
	Velocity[1] = y;
	Velocity[2] = z;
	RigidBody3d->setLinearVelocity({ Velocity[0],Velocity[1],Velocity[2]});
}

void GameObject::AddVelocity(float x, float y, float z)
{
	Velocity[0] = Velocity[0] + x;
	Velocity[1] = Velocity[1] + y;
	Velocity[2] = Velocity[2] + z;
	RigidBody3d->setLinearVelocity({ Velocity[0],Velocity[1],Velocity[2] });
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
	this->StoredObject.entity->getSubEntity(0)->setMaterialName(TextureName);
}
void GameObject::LookAt(float X,float Y,float Z)
{
	Node->lookAt( Ogre::Vector3(X,Y,Z), Ogre::Node::TS_WORLD, Ogre::Vector3::NEGATIVE_UNIT_Z );
}
void GameObject::CreateEntity(Physics*PM,Renderer*R,LuaHelper* LH,std::string EntityName,std::string MeshName,std::string MaterialName, int PosX, int PosY, int PosZ,int ColX, int ColY, int ColZ)
{
	AttachSystems(PM,R,LH);
	_Material = MaterialName;
	_MeshName = MeshName;
	Ogre::Entity* OgreEntity = _R->scnMgr->createEntity(EntityName, MeshName);
	Ogre::SceneNode* OgreNode = _R->scnMgr->getRootSceneNode()->createChildSceneNode();
	btTransform NewTransform;
	NewTransform.setIdentity();
	NewTransform.setOrigin({ (btScalar)PosX,(btScalar)PosY,(btScalar)PosZ });
	FillObject(OgreEntity, OgreNode, EntityName);
	_ColliderSize[0] = ColX;
	_ColliderSize[1] = ColY;
	_ColliderSize[2] = ColZ;
	InitiationAbstraction(OgreNode, new btBoxShape(btVector3(ColX, ColY, ColZ)), NewTransform, 10);
}
void GameObject::CreateLight(Physics* PM, Renderer* R, LuaHelper* LH, std::string LightName, int PosX, int PosY, int PosZ)
{
	AttachSystems(PM, R,LH);
	Ogre::Light* light = _R->scnMgr->createLight(LightName);
	Ogre::SceneNode* lightNode = _R->scnMgr->getRootSceneNode()->createChildSceneNode();
	btTransform NewTransform;
	NewTransform.setIdentity();
	NewTransform.setOrigin({ (btScalar)PosX,(btScalar)PosY,(btScalar)PosZ });
	FillObject(light, lightNode, LightName);
	InitiationAbstraction(lightNode, new btBoxShape(btVector3(0.0f, 0.0f, 0.0f)), NewTransform, 0);
}
void GameObject::CreateCamera(Physics* PM, Renderer* R, LuaHelper* LH, std::string CameraName, int PosX, int PosY, int PosZ)
{
	AttachSystems(PM, R,LH);
	Name = "";
	Ogre::SceneNode* camNode = _R->scnMgr->getRootSceneNode()->createChildSceneNode();
	Ogre::Camera* cam = _R->scnMgr->createCamera(CameraName);
	cam->setAutoAspectRatio(true);
	cam->setNearClipDistance(NearCamClipDistance);
	btTransform NewTransform;
	NewTransform.setIdentity();
	NewTransform.setOrigin({ (btScalar)PosX,(btScalar)PosY,(btScalar)PosZ });
	FillObject(cam, camNode, CameraName);
	InitiationAbstraction(camNode, new btBoxShape(btVector3(0.0f, 0.0f, 0.0f)), NewTransform, 0);
}

void GameObject::AttachSystems(Physics* PM, Renderer* R,LuaHelper* LH)
{
	_PM = PM;
	_R = R;
	_LH = LH;
	register_lua(_LH->L());
}

GameObject GameObject::CollideObject()
{
	return GameObject();
}

void GameObject::ClearObject()
{
	Node = nullptr;
	Name = "";
	Empty = true;
}
void GameObject::AssignRigidBody(btRigidBody* Rigidbody)
{
	RigidBody3d = Rigidbody;
}

void GameObject::TranslateLocally(float X, float Y, float Z)
{
	RigidBody3d->applyCentralImpulse({ X,Y,Z });
}
void GameObject::AssignTransform()
{
	this->myMotionState = new btDefaultMotionState(Transform);
}
void GameObject::AssignCollisionShape(btCollisionShape* CollisionShape)
{
	this->CollisionShape = CollisionShape;
	this->CollisionShape->calculateLocalInertia(mass, localInertia);
};

void GameObject::AddtoPhysicsSystem(Physics * _PM)
{
	_PM->collisionShapes.push_back(CollisionShape);
	_PM->dynamicsWorld->addRigidBody(RigidBody3d);
}
void GameObject::InitiationAbstraction(Ogre::SceneNode* ScnNode,btBoxShape* ColliderShape, btTransform DefaultTransform, int ObjMass)
{
	mass = ObjMass;
	Transform = DefaultTransform;
	AssignTransform();
	btCollisionShape* newRigidShape = ColliderShape;
	AssignCollisionShape(newRigidShape);
	CollisionShape->calculateLocalInertia(mass, localInertia);
	btRigidBody::btRigidBodyConstructionInfo BodyInfo(mass, myMotionState, CollisionShape, localInertia);
	btRigidBody* Bdy = new btRigidBody(BodyInfo);
	AssignRigidBody(Bdy);
	RigidBody3d->setUserPointer(ScnNode);
	AddtoPhysicsSystem(_PM);
}
void GameObject::SendToClient(NetworkManager* NM)
{
	Vector3* a = new Vector3{ Node->getPosition().x, Node->getPosition().y, Node->getPosition().z };
	Vector3* b = new Vector3{ _ColliderSize[0], _ColliderSize[1], _ColliderSize[2] };
	NM->SendPacket(Name,_MeshName,_Material,a,b);
}