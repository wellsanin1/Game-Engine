#pragma once
#include "OgreApplicationContext.h"
#include "Ogre.h"
#include "EventSystem.h"
#include "ObjectPool.h"
#include <iostream>

class Renderer : public OgreBites::ApplicationContext
{
private:
	ObjectPool* _OP;
public:
	Ogre::Root* root;
	Ogre::SceneManager* scnMgr;
	Ogre::RTShader::ShaderGenerator* shadergen;

	std::unordered_map<std::string,Ogre::SceneNode*> RendererAccessors;

	Renderer(ObjectPool*OP);
	~Renderer() {};
	void Update(EventQueue* EQ);
	void setup();
	void Start();
	void End();
	void Restart();
	void CreateEntity(RendererData RD);
	void CreateCamera(RendererData RD);
	void CreateLight(RendererData RD);
	void LookAt(RendererData RD);
	void SetPosition(RendererData RD);
	void SetOrientation(RendererData RD);
	typedef void (Renderer::* Reactions)(RendererData);

	Reactions EventReactions[7] = { &Renderer::CreateEntity
									,&Renderer::CreateLight
									,&Renderer::CreateCamera
									,&Renderer::LookAt
									,&Renderer::SetPosition
									,&Renderer::SetOrientation
									};
};