#pragma once
#include "OgreApplicationContext.h"
#include "Ogre.h"
#include <iostream>

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
	void Restart();
};