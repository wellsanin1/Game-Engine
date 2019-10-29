#pragma once
#include "Event.h"

class EventQueue
{
public:
	EventQueue() {};
	~EventQueue() {};
	void AddEvent(event Evnt);
	void ClearEventQueue();
	void RemoveEvent() {/*Put stuff here when Ideas are thought of*/ };
	void GetNextEvent();
	void GetEvent();
	void PopEvent();
	std::vector<event> Queue;
};
