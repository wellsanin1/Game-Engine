#pragma once
#include <iostream>
#include <string>
#include <filesystem>
#include "GameEngineDefinitions.h"
//#include <FMODStudio/Public/FMOD/fmod_studio.hpp>
#include <FMODStudio/Public/FMOD/fmod.hpp>
#include <FMODStudio/Public/FMOD/fmod_errors.h>
//#include <>

class AudioManager
{
public:
	FMOD::Sound* SoundArray[SoundArraySize];
	FMOD::Sound* Sound1;
	FMOD::System* FmodSystem = NULL;
	AudioManager();
	~AudioManager() {};
	void PlaySound();
	void CreateSound();
	void Close();
	void Loader();
};

