#pragma once
#include <iostream>
#include <string>
#include <filesystem>
#include "GameEngineDefinitions.h"
#include "AudioClip.h"
#include "EventSystem.h"

class AudioManager
{
public:
	AudioClip* SoundArray[SoundArraySize];
	FMOD::System* FmodSystem = NULL;
	AudioManager();
	~AudioManager() {};
	void PlaySound(AudioData AD);
	void Close();
	void Loader();
	void Update(EventQueue*EQ);

	typedef void (AudioManager::* Reactions)(AudioData);
	Reactions EventReactions[1] = { &AudioManager::PlaySound};

};

