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
private:
	std::vector<event> Queue;
};

void EventQueue::ClearEventQueue()
{
	this->Queue.clear();
}

void EventQueue::AddEvent(event Evnt)
{
	Queue.push_back(Evnt);
};

void EventQueue::GetEvent()
{

};
void EventQueue::GetNextEvent()
{

};