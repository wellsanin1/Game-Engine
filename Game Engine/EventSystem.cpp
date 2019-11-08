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

EventEnum EventQueue::CheckQueue(event::SubSystem CurrentEvent)
{
	for (int i = 0; i < Queue.size(); ++i)
	{
		for (int j = 0; j < Queue[i].SubSystemList.size(); ++j)
		{
			if (Queue[i].SubSystemList[j] == CurrentEvent)
			{
				EventEnum Store = Queue[i].EventType;
				Queue[i].SubSystemList.erase(Queue[i].SubSystemList.begin() + j);
				if (Queue[i].SubSystemList.empty())
				{
					Queue.erase(Queue.begin() + j);
				}
				return Store;
			}
		}
	}
	return NONE;
}