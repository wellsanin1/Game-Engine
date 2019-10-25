#pragma once
#include <vector>
#include <Ogre.h>

enum SubSystem{string};

struct event
{
public:
	event(int EventID, int SystemID){};
	~event();
	int EventID;
	enum SubSystem Enum[10];
};

event::event(int EventID, int SystemID)
{
	EventID = EventID;
	SystemID = SystemID;
};