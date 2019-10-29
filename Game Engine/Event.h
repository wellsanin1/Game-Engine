#pragma once
#include <vector>
#include <Ogre.h>

struct event
{
public:
	enum EventSort {KeyPresses};
	enum SubSystem {Renderer,Audio,Input,Netcode,Physics};
	event(EventSort Event, std::vector<event::SubSystem> ListedSystems);
	~event() {};
	EventSort EventType;
	std::vector<SubSystem> SubSystemList;
};
