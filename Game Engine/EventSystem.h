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
	void GetNextEvent();
	void GetEvent();
	void PopEvent();
	event CheckQueueReturnEvent(SubSystem CurrentEvent);
	void RemoveFromQueue(SubSystem CurrentEvent);
	std::vector<event> Queue;
};
