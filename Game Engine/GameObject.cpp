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
	//Transform.setOrigin({ x,y,z });
	Node->setPosition(x,y,z);
}
std::vector<double> GameObject::GetTransform()
{
	std::vector<double> ReturnTransform;
	btVector3 Origin = Transform.getOrigin();
	ReturnTransform = {Origin.getX(),Origin.getY(),Origin.getZ()};
	return ReturnTransform;
}

void GameObject::SetOrientation(double w, double x, double y, double z)
{
	Node->setOrientation(Ogre::Quaternion(w, x, y, z));
}
std::vector<double> GameObject::GetOrientation()
{

}

void GameObject::SetMass(float NewMass, Physics* PM)
{
	PM->dynamicsWorld->removeRigidBody(RigidBody3d);
	mass = NewMass;
	CollisionShape->calculateLocalInertia(mass,localInertia);
	btRigidBody::btRigidBodyConstructionInfo BodyInfo(mass, myMotionState, CollisionShape, localInertia);
	btRigidBody* RB = new btRigidBody(BodyInfo);
	AssignRigidBody(RB);
	RigidBody3d->setUserPointer(Node);
	AddtoPhysicsSystem(PM);
	PM->dynamicsWorld->addRigidBody(RigidBody3d);
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
	Velocity[1] = Velocity[0] + y;
	Velocity[2] = Velocity[0] + z;
	RigidBody3d->setLinearVelocity({ Velocity[0],Velocity[1],Velocity[2] });
}
void GameObject::CreateEntity(Physics*PM,Renderer* R,std::string EntityName,std::string MeshName, int PosX, int PosY, int PosZ)
{
	Ogre::Entity* OgreEntity = R->scnMgr->createEntity(EntityName, MeshName);
	Ogre::SceneNode* OgreNode = R->scnMgr->getRootSceneNode()->createChildSceneNode();
	btTransform NewTransform;
	NewTransform.setIdentity();
	NewTransform.setOrigin({ (btScalar)PosX,(btScalar)PosY,(btScalar)PosZ });
	FillObject(OgreEntity, OgreNode, EntityName);
	InitiationAbstraction(PM, OgreNode, new btBoxShape(btVector3(15.0f, 15.0f, 15.0f)), NewTransform, 10);
}
void GameObject::CreateLight(Physics* PM, Renderer* R,std::string LightName, int PosX, int PosY, int PosZ)
{
	Ogre::Light* light = R->scnMgr->createLight(LightName);
	Ogre::SceneNode* lightNode = R->scnMgr->getRootSceneNode()->createChildSceneNode();
	btTransform NewTransform;
	NewTransform.setIdentity();
	NewTransform.setOrigin({ (btScalar)PosX,(btScalar)PosY,(btScalar)PosZ });
	FillObject(light, lightNode, LightName);
	InitiationAbstraction(PM, lightNode, new btBoxShape(btVector3(0.0f, 0.0f, 0.0f)), NewTransform, 0);
}
void GameObject::CreateCamera(Physics* PM, Renderer* R,std::string CameraName, int PosX, int PosY, int PosZ)
{
	Ogre::SceneNode* camNode = R->scnMgr->getRootSceneNode()->createChildSceneNode();
	Ogre::Camera* cam = R->scnMgr->createCamera(CameraName);
	cam->setAutoAspectRatio(true);
	cam->setNearClipDistance(NearCamClipDistance);
	btTransform NewTransform;
	NewTransform.setIdentity();
	NewTransform.setOrigin({ (btScalar)PosX,(btScalar)PosY,(btScalar)PosZ });
	FillObject(cam, camNode, CameraName);
	InitiationAbstraction(PM, camNode, new btBoxShape(btVector3(0.0f, 0.0f, 0.0f)), NewTransform, 0);
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


void GameObject::AssignTransform()
{
	this->myMotionState = new btDefaultMotionState(Transform);
}
void GameObject::AssignCollisionShape(btCollisionShape* CollisionShape)
{
	this->CollisionShape = CollisionShape;
	this->CollisionShape->calculateLocalInertia(mass, localInertia);
};

void GameObject::AddtoPhysicsSystem(Physics * PM)
{
	PM->collisionShapes.push_back(CollisionShape);
	PM->dynamicsWorld->addRigidBody(RigidBody3d);
}
void GameObject::InitiationAbstraction(Physics * PM,Ogre::SceneNode* ScnNode,btBoxShape* ColliderShape, btTransform DefaultTransform, int ObjMass)
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
	AddtoPhysicsSystem(PM);
}