#pragma once
#include "Event.h"

class EventQueue
{
public:
	EventQueue() {};
	~EventQueue();
	void addevent(event a)
	{
		this->Queue.push_back(a);
	};
	void ClearEventQueue() { this->Queue.clear(); };
	void RemoveEvent() {/*Put stuff here when Ideas are thought of*/ };
private:
	std::vector<event> Queue;
};
