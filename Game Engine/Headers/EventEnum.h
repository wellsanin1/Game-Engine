#pragma once
enum PhysicsEnum
{
	Physics_CREATEENTITY
	, Physics_SETMASS
	, Physics_TRANSLATELOCALLY
	, Physics_SETVELOCITY
	, Physics_ADDVELOCITY
	, Physics_TELEPORT
	, Physics_SETGRAVITY
};
enum AudioEnum
{
	Audio_PLAYSOUND
};
enum RenderEnum
{
	Render_CREATEENTITY
	, Render_CREATELIGHT
	, Render_CREATECAMERA
	, Render_LOOKAT
	, Render_SETPOSITION
	, Render_SETORIENTATION
	, Render_CREATETEXTBOX
	, Render_REMOVETEXTBOX
	, Render_SETTEXT
	, Render_PLAYANIMATION
};
enum ObjectPoolEnum
{
	ObjectPool_CREATEENTITY
	,ObjectPool_CREATECAMERA
	,ObjectPool_CREATELIGHT
};
enum KeyManagerEnum
{
	KeyManager_NONE,
	KeyManager_UP,
	KeyManager_DOWN,
	KeyManager_LEFT,
	KeyManager_RIGHT,
	KeyManager_QUIT,

};
enum NetworkEnum
{
	Network_SENDPACKET
};
enum SubSystem 
{ 
	SubSystem_NONE, 
	SubSystem_TEST,
	SubSystem_Renderer,
	SubSystem_Audio,
	SubSystem_Input,
	SubSystem_Network,
	SubSystem_Physics,
	SubSystem_Load,
	SubSystem_ObjectPool,
	SubSystem_EventQueue,
	Subsystem_GameObject
};