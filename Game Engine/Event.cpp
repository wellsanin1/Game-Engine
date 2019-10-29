#include "Event.h"

event::event(EventSort Event, std::vector<event::SubSystem> ListedSystems)
{
	EventType = Event;
	SubSystemList = ListedSystems;
};