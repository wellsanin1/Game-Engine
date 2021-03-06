#include "AudioManager.h"

void AudioManager::PlaySound(AudioData AD)
{
	for (int i = 0;i < SoundArraySize;++i)
	{
		if (SoundArray[i]->Name == AD.Name)
		{
			FmodSystem->playSound(SoundArray[i]->Clip, NULL, false, 0);
			std::cout << "Sound Played: "<< SoundArray[i]->Name<<std::endl;
			return;
		}
	}
	std::cout << "Sound " + AD.Name + " does not exist" << std::endl;
}
//Loads all files from the folder Project/Media/Audio
void AudioManager::Loader()
{
	const std::string path = "Media/Audio";
	int i = 0;
	for (const auto& entry : std::filesystem::directory_iterator(path))
	{
		std::string StringPath = entry.path().string();
		FmodSystem->createSound(StringPath.c_str(), FMOD_DEFAULT, 0, &SoundArray[i]->Clip);
		SoundArray[i]->Name = StringPath.erase(0, path.length() + 1);
		std::cout << SoundArray[i]->Name << std::endl;
		++i;
	}
	std::cout << "Audio File Load Finished" << std::endl;
}

void AudioManager::Update(EventQueue* EQ)
{
	for (int i = 0; i < EQ->Queue.size(); ++i)
	{
		event EV = EQ->CheckQueueReturnEvent(SubSystem_Audio);
		if (EV.Empty == false)
		{
			Reactions A = EventReactions[(int)EV.AudioEventType];
			(this->*A)(EV.AD);
			EQ->RemoveFromQueue(SubSystem_Audio);
		}
		else
		{
			break;
		}
	}
}

void AudioManager::Dealloc()
{
	delete SoundArray;
	delete FmodSystem;
	delete EventReactions;
}

AudioManager::AudioManager()
{
	FMOD_RESULT result;
	result = FMOD::System_Create(&FmodSystem); // Create the Studio System object.
	if (result != FMOD_OK)
	{
		printf("FMOD error! (%d) %s\n", result, FMOD_ErrorString(result));
		exit(-1);
	}
	// Initialize FMOD Studio, which will also initialize FMOD Low Level
	result = FmodSystem->init(32, FMOD_INIT_NORMAL, 0);
	if (result != FMOD_OK)
	{
		printf("FMOD error! (%d) %s\n", result, FMOD_ErrorString(result));
		exit(-1);
	}
	for (int i = 0 ; i<SoundArraySize ; ++i)
	{
		AudioClip* emptyclip = new AudioClip();
		SoundArray[i] = emptyclip;
	}
}
void AudioManager::Close()
{
	FmodSystem->release();
}