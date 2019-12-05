#include "KeyManager.h"

KeyManager::KeyManager()
{
	EnumMap = { {SDLK_UP,KeyManager_UP}
				,{SDLK_DOWN,KeyManager_DOWN}
				,{SDLK_LEFT,KeyManager_LEFT}
				,{SDLK_RIGHT,KeyManager_RIGHT}
				,{SDLK_ESCAPE,KeyManager_QUIT}
	};
};

//Convert SDLKeycode to KeymanagerEnums
KeyManagerEnum KeyManager::MapConvert(SDL_Keycode KeyCode)
{
	std::map<SDL_Keycode, KeyManagerEnum>::const_iterator it = EnumMap.find(KeyCode);
	if (it != EnumMap.end())
	{
		KeyManagerEnum KeyPressed = EnumMap.at(KeyCode);
		return(KeyPressed);
	}
	return KeyManager_NONE;
};
//create input event
event KeyManager::CreateEvent(KeyManagerEnum KeyPressed)
{
	event E;
	E.SubSystemList.push_back(SubSystem_Input);
	E.InputEventEnum = KeyPressed;
	E.Empty = false;
	return E;
}

void KeyManager::InputRead()
{
	//clear queue of previous loops inputs before adding more
	for (int i = 0; i < _EQ->Queue.size(); ++i)
	{
		event EV = _EQ->CheckQueueReturnEvent(SubSystem_Input);
		if (EV.Empty == false)
		{
			_EQ->RemoveFromQueue(SubSystem_Input);
		}
		else
		{
			break;
		}
	}

	//add this frames inputs through events
	SDL_Event event;
	while (SDL_PollEvent(&event))
	{
		KeyManagerEnum KeyPressed = MapConvert(event.key.keysym.sym);
		if (event.type == SDL_KEYDOWN && KeyPressed != KeyManager_NONE)
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
	//return true of false based on if a key input is in the event queue
	for (int i = 0; i < _EQ->Queue.size(); ++i)
	{
		event EV = _EQ->CheckQueueReturnEvent(SubSystem_Input);
		if (EV.Empty == false)
		{
			if (EV.InputEventEnum == Input)
			{
				_EQ->RemoveFromQueue(SubSystem_Input);
				return true;
			}
		}
	}
	return false;
};