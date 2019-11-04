#include "EventSystem.h"

void EventQueue::ClearEventQueue()
{
	this->Queue.clear();
}

void EventQueue::AddEvent(event Evnt)
{
	if (Evnt.EventType != NONE)
	{
		Queue.push_back(Evnt);
	}
};

void EventQueue::GetEvent()
{

};

void EventQueue::PopEvent()
{

};

void EventQueue::GetNextEvent()
{

};