#pragma once
#include "OgreApplicationContext.h"
#include "Ogre.h"
#include "EventSystem.h"
#include "ObjectPool.h"
#include <iostream>
struct JoinedStore
{
	Ogre::SceneNode* Node;
	Ogre::Camera* Camera;
	Ogre::Light* Light;
	Ogre::Entity* Entity;
};

class Renderer : public OgreBites::ApplicationContext
{
private:
	ObjectPool* _OP;
public:
	Ogre::Root* root;
	Ogre::SceneManager* scnMgr;
	Ogre::RTShader::ShaderGenerator* shadergen;

	std::map<std::string,JoinedStore> RendererAccessors;

	Renderer(ObjectPool*OP);
	~Renderer() {};
	void Update(EventQueue* EQ);
	void setup();
	void Start();
	void End();
	void Restart(RendererData RD);
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
									,&Renderer::Restart
									,&Renderer::LookAt
									,&Renderer::SetPosition
									,&Renderer::SetOrientation
									};
};