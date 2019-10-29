#pragma once
#include <vector>
#include <Ogre.h>

struct event
{
private:
	enum EventType {Input};
	enum SubSystem {Renderer,Audio,UI,Netcode,Physics};
public:
	event(EventType EventID, SubSystem Sub[10]){};
	~event() {};
	EventType EventID;
	SubSystem SubSystemLink[10];
};

event::event(EventType EventID, SubSystem System[10])
{
	EventID = EventID;
	std::memcpy(SubSystemLink, System, sizeof(SubSystemLink));
};