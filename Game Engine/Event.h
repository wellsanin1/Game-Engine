#pragma once
#include <vector>
#include "EventEnum.h"

struct event
{
public:
	enum SubSystem {NONE,TEST,Renderer,Audio,Input,Netcode,Physics};
	EventEnum EventType = EventEnum::NONE;
	std::vector<SubSystem> SubSystemList;
};
