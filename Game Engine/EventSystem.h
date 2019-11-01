#pragma once
#include "Event.h"

class EventQueue
{
public:
	EventQueue() {};
	~EventQueue() {};
	void AddEvent(event Evnt);
	void ClearEventQueue();
	void GetNextEvent();
	void GetEvent();
	void PopEvent();
	std::vector<event> Queue;
};
