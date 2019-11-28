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

EventEnum EventQueue::CheckQueue(SubSystem CurrentEvent, bool Delete)
{
	for (int i = 0; i < Queue.size(); ++i)
	{
		for (int j = 0; j < Queue[i].SubSystemList.size(); ++j)
		{
			if (Queue[i].SubSystemList[j] == CurrentEvent)
			{
				EventEnum Store = Queue[i].EventType;
				if (Delete)
				{
					Queue[i].SubSystemList.erase(Queue[i].SubSystemList.begin() + j);
					if (Queue[i].SubSystemList.empty())
					{
						Queue.erase(Queue.begin() + j);
					}
				}
				return Store;
			}
		}
	}
	return EventEnum::NONE;
}
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
	empty.EventType == NONE;
	return empty;
}
void EventQueue::RemoveFromQueue(SubSystem CurrentEvent,EventEnum EventType)
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
			}
		}
	}
	return;
}
