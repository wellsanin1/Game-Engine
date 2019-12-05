#pragma once
#include "Event.h"
#include <iostream>

class EventQueue
{
public:
	EventQueue() {};
	~EventQueue() {};
	void AddEvent(event Evnt);
	void ClearEventQueue();
	event CheckQueueReturnEvent(SubSystem CurrentEvent);
	void RemoveFromQueue(SubSystem CurrentEvent);
	std::vector<event> Queue;
};
