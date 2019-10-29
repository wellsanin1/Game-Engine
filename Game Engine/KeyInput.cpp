#include "KeyInput.h"

KeyManager::KeyManager()
{
	EnumMap = { {SDLK_UP,UP}
				,{SDLK_DOWN,DOWN}
				,{SDLK_LEFT,LEFT}
				,{SDLK_RIGHT,RIGHT}
				,{SDLK_ESCAPE,QUIT}
	};
};

KeyManager::KeyPressEnum KeyManager::MapConvert(SDL_Keycode KeyCode)
{
	KeyPressEnum KeyPressed = EnumMap.at(KeyCode);
	return(KeyPressed);
};

void KeyManager::AddInput(SDL_Keycode KeyCode)
{
	KeyPressEnum ConvertedEnum = MapConvert(KeyCode);
	int size = sizeof(KeyArray) / sizeof(*KeyArray);
	for (int i = 0; i < size; i++)
	{
		if (KeyArray[i] == NONE)
		{
			KeyArray[i] = ConvertedEnum;
			return;
		}
	}
};

void KeyManager::InputClearKeys()
{
	int size = sizeof(KeyArray) / sizeof(*KeyArray);
	for (int i = 0; i < size; i++)
	{
		KeyArray[i] = NONE;
	}
	return;
}
