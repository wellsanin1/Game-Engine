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


KeyPressEnum KeyManager::MapConvert(SDL_Keycode KeyCode)
{
	KeyPressEnum KeyPressed = EnumMap.at(KeyCode);
	return(KeyPressed);
};

event KeyManager::CreateEvent(SDL_Keycode KeyCode)
{
	KeyPressEnum KeyPressed = MapConvert(KeyCode);
	std::vector<event::SubSystem> SubSystemVector;
	SubSystemVector.push_back(event::Renderer);
	SubSystemVector.push_back(event::Audio);
	SubSystemVector.push_back(event::Input);
	SubSystemVector.push_back(event::Netcode);
	SubSystemVector.push_back(event::Physics);
	//hard coded temporerily
	InputData Input = { KeyPressed };
	event::EventData Evntdata;
	Evntdata.Input = Input;
	return{event::KeyPresses,SubSystemVector,Evntdata};
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