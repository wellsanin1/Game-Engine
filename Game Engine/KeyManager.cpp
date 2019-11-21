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
	E.SubSystemList.push_back(event::Renderer);
	E.SubSystemList.push_back(event::TEST);
	E.EventType = KeyPressed;
	return E;
}

void KeyManager::InputRead(EventQueue* EQ)
{
	SDL_Event event;
	while (SDL_PollEvent(&event))
	{
		EventEnum KeyPressed = MapConvert(event.key.keysym.sym);
		if (event.type == SDL_KEYDOWN && KeyPressed != NONE)
		{
			EQ->AddEvent(CreateEvent(KeyPressed));
		}
	}
	return;
};