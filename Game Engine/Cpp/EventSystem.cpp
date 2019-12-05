#include "EventSystem.h"
//completely empty event queue
void EventQueue::ClearEventQueue()
{
	this->Queue.clear();
}
//add new event
void EventQueue::AddEvent(event Evnt)
{
	Evnt.Empty = false;
	Queue.push_back(Evnt);
};
//returns an event based on subsystem, event is empty if it doesn't exist
event EventQueue::CheckQueueReturnEvent(SubSystem CurrentEvent)
{
	for (int i = 0; i < Queue.size(); ++i)
	{
		for (int j = 0; j < Queue[i].SubSystemList.size(); ++j)
		{
			if (Queue[i].SubSystemList[j] == CurrentEvent)
			{
				return Queue[i];
			}
		}
	}
	event empty = event();
	empty.Empty = true;
	return empty;
}
//Remove Subsystem from event, if event is finished remove event
void EventQueue::RemoveFromQueue(SubSystem CurrentEvent)
{
	for (int i = 0; i < Queue.size(); ++i)
	{
		for (int j = 0; j < Queue[i].SubSystemList.size(); ++j)
		{
			if (Queue[i].SubSystemList[j] == CurrentEvent)
			{
				Queue[i].SubSystemList.erase(Queue[i].SubSystemList.begin() + j);
				if (Queue[i].SubSystemList.empty())
				{
					Queue.erase(Queue.begin() + i);
					return;
				}
				return;
			}
		}
	}
}
