#pragma once
#include <vector>
class Event
{
public:
	Event(int EventID, int SystemID)
	{
		this->EventID = EventID;
		this->SystemID = SystemID;
	};
	~Event();
	int EventID;
	int SystemID;
};

class EventQueue
{
public:
	EventQueue() {};
	~EventQueue();
	void addevent(Event a)
	{
		this->Queue.push_back(a);
	};
	void ClearEventQueue() { this->Queue.clear(); };
	void RemoveEvent() {/*Put stuff here when Ideas are thought of*/ };
private:
	std::vector<Event> Queue;
};
