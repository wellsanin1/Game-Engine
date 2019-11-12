#pragma once
#include <iostream>
#include <string>
#include <filesystem>
#include "GameEngineDefinitions.h"
#include "AudioClip.h"

class AudioManager
{
public:
	AudioClip* SoundArray[SoundArraySize];
	FMOD::System* FmodSystem = NULL;
	AudioManager();
	~AudioManager() {};
	void PlaySound(std::string);
	void Close();
	void Loader();
};

