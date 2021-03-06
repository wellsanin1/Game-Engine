#pragma once
#include "OgreApplicationContext.h"
#include "Ogre.h"
#include "OgreTrays.h"
#include "EventSystem.h"
#include "ObjectPool.h"
#include <OgreTimer.h>
#include <iostream>

//Ogre uses depricated string iterator, required or wont run
//Define done in Properties->C++->commandline
//#define _SILENCE_CXX17_ITERATOR_BASE_CLASS_DEPRECATION_WARNING

class Renderer : public OgreBites::ApplicationContext
{
private:
	//ObjectPool.h
	ObjectPool* _OP;
	Ogre::Root* root;
	Ogre::SceneManager* scnMgr;
	Ogre::RTShader::ShaderGenerator* shadergen;
	Ogre::Timer FrameTimer;
	//Text related
	OgreBites::TrayManager* Traymgr;
	std::map<std::string, Ogre::SceneNode*> RendererAccessors;
	std::map<std::string, OgreBites::TextBox*> TextAccessors;

	//Nececcary Ogre objects
public:



	//to access Renderer objects by name


	//takes object pool to iterate through gameobjects
	Renderer(ObjectPool*OP);
	~Renderer() {};

	//Bunch of self explanatory functions
	void Update(EventQueue* EQ);
	void setup();
	void Start();
	void End();
	void Restart();
	void Animation(RendererData RD);
	float GetFPS();

	//Text related
	void CreateTextBox(RendererData RD);
	void RemoveTextBox(RendererData RD);
	void SetText(RendererData RD);
	std::string GetText(std::string Name);

	void CreateEntity(RendererData RD);
	void CreateCamera(RendererData RD);
	void CreateLight(RendererData RD);
	void LookAt(RendererData RD);
	void SetPosition(RendererData RD);
	void SetOrientation(RendererData RD);

	//Array of function pointers
	typedef void (Renderer::* Reactions)(RendererData);
	Reactions EventReactions[10] = { &Renderer::CreateEntity
									,&Renderer::CreateLight
									,&Renderer::CreateCamera
									,&Renderer::LookAt
									,&Renderer::SetPosition
									,&Renderer::SetOrientation
									,&Renderer::CreateTextBox
									,&Renderer::RemoveTextBox
									,&Renderer::SetText
									,&Renderer::Animation
									};
};