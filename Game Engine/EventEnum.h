#pragma once
enum EventEnum
{
	NONE,
	UP,
	DOWN,
	LEFT,
	RIGHT,
	QUIT,
	PHYSICS,
	LOAD,
	ENTITY,
	CREATEENTITY,
	CREATELIGHT,
	CREATECAMERA,
	FUNCTION
};
enum PhysicsEnum
{
	Physics_CREATEENTITY
	, Physics_SETMASS
	, Physics_TRANSLATELOCALLY
	, Physics_SETVELOCITY
	, Physics_ADDVELOCITY
	, Physics_TELEPORT
	, Physics_RESTART
};
enum RenderEnum
{
	Render_CREATEENTITY
	, Render_CREATELIGHT
	, Render_CREATECAMERA
	, Render_RESTART
	, Render_LOOKAT
	, Render_SETPOSITION
};
enum ObjectPoolEnum
{
	ObjectPool_CREATEENTITY
	,ObjectPool_CREATECAMERA
	,ObjectPool_CREATELIGHT
};
enum SubSystem 
{ 
	SubSystem_NONE, 
	SubSystem_TEST,
	SubSystem_Renderer,
	SubSystem_Audio,
	SubSystem_Input,
	SubSystem_Netcode,
	SubSystem_Physics,
	SubSystem_Load,
	SubSystem_ObjectPool,
	SubSystem_EventQueue
};