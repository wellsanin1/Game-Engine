#pragma once
#include <vector>
#include "EventData.h"
#include <Ogre.h>

struct event
{
public:
	enum EventSort {KeyPresses};
	enum SubSystem {Renderer,Audio,Input,Netcode,Physics};
	union EventData {
		EventData() {};
		~EventData() {};
		InputData Input;
		PhysicsData Physics;
	};

	EventSort EventType;
	std::vector<SubSystem> SubSystemList;
	EventData EvntData;
};
