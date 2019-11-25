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
	EventEnum CheckQueue(event::SubSystem CurrentEvent,bool Delete);
	event CheckQueueNoRemoval(event::SubSystem CurrentEvent);
	void RemoveFromQueue(event::SubSystem CurrentEvent, EventEnum EventType);
	std::vector<event> Queue;
};
