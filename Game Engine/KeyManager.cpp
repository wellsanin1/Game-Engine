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

event KeyManager::CreateEvent(SDL_Keycode KeyCode)
{
	EventEnum KeyPressed = MapConvert(KeyCode);
	event E;
	if (KeyPressed != NONE)
	{
		E.SubSystemList.push_back(event::Renderer);
		E.SubSystemList.push_back(event::TEST);
		//E.SubSystemList.push_back(event::Audio);
		//E.SubSystemList.push_back(event::Input);
		//E.SubSystemList.push_back(event::Netcode);
		//E.SubSystemList.push_back(event::Physics);
		E.EventType = KeyPressed;
	}
	return E;
}

void KeyManager::InputRead(EventQueue* EQ)
{
	SDL_Event event;
	while (SDL_PollEvent(&event))
	{
		switch (event.type)
		{
		case SDL_KEYDOWN:
			EQ->AddEvent(CreateEvent(event.key.keysym.sym));
			break;
	/*	case SDL_KEYUP:
			EQ->AddEvent(CreateEvent(event.key.keysym.sym));
			break;*/
		}
	}
	return;
};