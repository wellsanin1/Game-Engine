#include "KeyManager.h"

KeyManager::KeyManager()
{
	EnumMap = { {SDLK_UP,UP}
				,{SDLK_DOWN,DOWN}
				,{SDLK_LEFT,LEFT}
				,{SDLK_RIGHT,RIGHT}
				,{SDLK_ESCAPE,QUIT}
	};
};

EventEnum KeyManager::MapConvert(SDL_Keycode KeyCode)
{
	std::map<SDL_Keycode,EventEnum>::const_iterator it = EnumMap.find(KeyCode);
	if (it != EnumMap.end())
	{
		EventEnum KeyPressed = EnumMap.at(KeyCode);
		return(KeyPressed);
	}
	return NONE;
};

event KeyManager::CreateEvent(EventEnum KeyPressed)
{
	event E;
	E.SubSystemList.push_back(SubSystem_Input);
	E.EventType = KeyPressed;
	return E;
}

void KeyManager::InputRead()
{
	SDL_Event event;
	while (SDL_PollEvent(&event))
	{
		EventEnum KeyPressed = MapConvert(event.key.keysym.sym);
		if (event.type == SDL_KEYDOWN && KeyPressed != NONE)
		{
			_EQ->AddEvent(CreateEvent(KeyPressed));
		}
	}
	return;
}
void KeyManager::Initiate(lua_State* F,EventQueue* EQ)
{
	_EQ = EQ;
	register_lua(F);
}
bool KeyManager::GetKey(int Input)
{
	//Create Temp versin of event queue to iterate on
	EventQueue E =  EventQueue();
	E = _EQ[0];

	while (EventEnum Enum = E.CheckQueue(SubSystem_Input,true))
	{
		if (Enum == Input)
		{
			_EQ->CheckQueue(SubSystem_Input, true);
			return true;
		}
	}
	return false;
};