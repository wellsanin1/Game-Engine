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
	KeyManagerEnum InputEventEnum;
	//GameObjectEnum GameObjectEventEnum;

	std::vector<SubSystem> SubSystemList;
	bool Empty = true;
};
