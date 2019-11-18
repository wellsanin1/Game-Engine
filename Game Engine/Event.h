#pragma once
#include <vector>
#include "EventEnum.h"

struct event
{
public:
	//Function pointers
	//typedef void* (*Function)(double[3], double[4], void*);
	//Function FunctionArray[FunctionArraySize];

	//EventData
	enum SubSystem {NONE,TEST,Renderer,Audio,Input,Netcode,Physics};
	EventEnum EventType = EventEnum::NONE;
	std::vector<SubSystem> SubSystemList;
};
