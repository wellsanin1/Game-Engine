#pragma once
#include <FMODStudio/Public/FMOD/fmod.hpp>
#include <FMODStudio/Public/FMOD/fmod_errors.h>

struct AudioClip 
{
	FMOD::Sound* Clip;
	std::string Name;
};