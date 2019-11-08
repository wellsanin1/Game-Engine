#pragma once
#include <iostream>
#include <string>
#include <filesystem>
#include "GameEngineDefinitions.h"
//#include <FMODStudio/Public/FMOD/fmod_studio.hpp>
#include "AudioClip.h"
//#include <>

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

