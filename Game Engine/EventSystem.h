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
	EventEnum CheckQueue(SubSystem CurrentEvent,bool Delete);
	event CheckQueueReturnEvent(SubSystem CurrentEvent);
	void RemoveFromQueue(SubSystem CurrentEvent, EventEnum EventType);
	std::vector<event> Queue;
};
