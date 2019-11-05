#include "AudioManager.h"

void AudioManager::PlaySound()
{
	FmodSystem->playSound(Sound1, NULL, false, 0);
}
void AudioManager::CreateSound()
{

}
void AudioManager::Loader()
{
	std::string path = "Media/Audio";
	for (const auto& entry : std::experimental::filesystem::directory_iterator(path))
	{
		const char* cstr = entry.path().string().c_str();
		FmodSystem->createSound(cstr, FMOD_DEFAULT, 0, &Sound1);
	}
	std::cout << "Audio File Load Finished" << std::endl;
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
}
void AudioManager::Close()
{
	FmodSystem->release();
}