#include "EventSystem.h"

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

void EventQueue::PopEvent()
{

};

void EventQueue::GetNextEvent()
{

};
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
	return empty;
}
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
				}
			}
		}
	}
}
