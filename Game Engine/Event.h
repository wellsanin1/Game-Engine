#pragma once
#include <vector>
#include "EventEnum.h"
#include "EventStructs.h"

struct event
{
public:
	PhysicsData PD;
	RendererData RD;
	ObjectPoolData OD;
	AudioData AD;
	NetworkData ND;
	//EventData
	PhysicsEnum PhysicsEventType;
	RenderEnum RenderEventType;
	ObjectPoolEnum ObjectPoolEventEnum;
	KeyManagerEnum InputEventEnum;
	AudioEnum AudioEventType;
	NetworkEnum NetworkEventType;
	//GameObjectEnum GameObjectEventEnum;

	std::vector<SubSystem> SubSystemList;
	bool Empty = true;
};
