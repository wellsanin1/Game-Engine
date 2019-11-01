#include "InputManager.h"

void InputManager::InputRead()
{
	SDL_Event event;
	while (SDL_PollEvent(&event))
	{
		switch (event.type)
		{
		case SDL_KEYDOWN:
			AddInput(event.key.keysym.sym);
			break;
		case SDL_KEYUP:
			AddInput(event.key.keysym.sym);
			break;
		}
	}
	return;
};

void InputManager::ClearKeys()
{
	KeyManager::InputClearKeys();
};