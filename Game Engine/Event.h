#pragma once
#include <vector>

struct event
{
public:
	event(int EventID, int SystemID){};
	~event();
	int EventID;
	int SystemID;
};

event::event(int EventID, int SystemID)
{
	EventID = EventID;
	SystemID = SystemID;
};