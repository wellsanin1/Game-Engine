#pragma once
#include "Event.h"

class EventQueue
{
public:
	EventQueue() {};
	~EventQueue() {};
	void AddEvent(event Evnt)
	{
		this->Queue.push_back(Evnt);
	};
	void ClearEventQueue();
	void RemoveEvent() {/*Put stuff here when Ideas are thought of*/ };
	void GetNextEvent();
	void GetEvent();
private:
	std::vector<event> Queue;
};

void EventQueue::ClearEventQueue()
{
	this->Queue.clear();
}
void EventQueue::AddEvent(event a)
{
	Queue.push_back(a);
};

void EventQueue::GetEvent()
{

};
void EventQueue::GetNextEvent()
{

};