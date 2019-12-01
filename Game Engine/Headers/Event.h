#pragma once
#include <vector>
#include "EventEnum.h"
#include "EventStructs.h"

struct event
{
public:
	//Subsystem data/enums are split out so that I don't have to worry about lining up all of the different subsystems with eachother

	//Individual subsystem structs
	PhysicsData PD;
	RendererData RD;
	ObjectPoolData OD;
	AudioData AD;
	NetworkData ND;

	//individual event enums
	PhysicsEnum PhysicsEventType;
	RenderEnum RenderEventType;
	ObjectPoolEnum ObjectPoolEventEnum;
	KeyManagerEnum InputEventEnum;
	AudioEnum AudioEventType;
	NetworkEnum NetworkEventType;

	//list of subsystems to act on event
	std::vector<SubSystem> SubSystemList;
	bool Empty = true;
};
