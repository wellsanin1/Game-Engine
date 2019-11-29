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
	//EventData
	PhysicsEnum PhysicsEventType;
	RenderEnum RenderEventType;
	ObjectPoolEnum ObjectPoolEventEnum;
	KeyManagerEnum InputEventEnum;
	AudioEnum AudioEventType;
	//GameObjectEnum GameObjectEventEnum;

	std::vector<SubSystem> SubSystemList;
	bool Empty = true;
};
