#pragma once
#include <vector>
#include "EventEnum.h"

struct event
{
public:
	//EventData
	enum SubSystem {NONE,TEST,Renderer,Audio,Input,Netcode,Physics,Load,ObjectPool};
	EventEnum EventType = EventEnum::NONE;
	std::vector<SubSystem> SubSystemList;
};
