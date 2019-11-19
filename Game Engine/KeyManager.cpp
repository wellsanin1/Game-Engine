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
		E.EventType = KeyPressed;
	}
	return E;
}

void KeyManager::InputRead(EventQueue* EQ)
{
	SDL_Event event;
	while (SDL_PollEvent(&event))
	{
		if (event.type == SDL_KEYDOWN)
		{
			EQ->AddEvent(CreateEvent(event.key.keysym.sym));
		}
		std::cout << std::endl;
	}
	return;
};