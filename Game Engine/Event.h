#pragma once
#include <vector>
#include "EventEnum.h"
#include "EventStructs.h"

struct event
{
public:
	PhysicsData PD;
	//EventData
	enum SubSystem {NONE,TEST,Renderer,Audio,Input,Netcode,Physics,Load,ObjectPool};
	EventEnum EventType = EventEnum::NONE;
	std::vector<SubSystem> SubSystemList;
};
