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
	//EventData
	PhysicsEnum PhysicsEventType;
	RenderEnum RenderEventType;
	ObjectPoolEnum ObjectPoolEventEnum;

	EventEnum EventType = EventEnum::NONE;
	std::vector<SubSystem> SubSystemList;
};
