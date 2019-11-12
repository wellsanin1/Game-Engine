#pragma once
#include "OgreApplicationContext.h"
#include "OgreRTShaderSystem.h"
#include "Ogre.h"

class Renderer : public OgreBites::ApplicationContext
{
public:

	Ogre::Root* root = new Ogre::Root();
	Ogre::SceneManager* scnMgr;
	Ogre::RTShader::ShaderGenerator* shadergen;

	Renderer();
	~Renderer() {};

	void Update();
	void Setup();
	void Start();
	void End();
};