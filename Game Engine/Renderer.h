#pragma once
#include "OgreApplicationContext.h"
#include "OgreRTShaderSystem.h"
#include "Ogre.h"

class Renderer : public OgreBites::ApplicationContext
{
public:
	Ogre::Root* root;
	Ogre::SceneManager* scnMgr;
	Ogre::RTShader::ShaderGenerator* shadergen;
	Renderer();
	~Renderer() {};
	void Update();
	void setup();
	void Start();
	void End();
};