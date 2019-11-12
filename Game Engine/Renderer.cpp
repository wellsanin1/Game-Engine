#include "Renderer.h"

Renderer::Renderer()
{
	initApp();
}

void Renderer::Update()
{

}

void Renderer::Setup()
{
	OgreBites::ApplicationContext::setup();
	root = getRoot();
	scnMgr = root->createSceneManager();
	shadergen = Ogre::RTShader::ShaderGenerator::getSingletonPtr();
	shadergen->addSceneManager(scnMgr);
	scnMgr->setAmbientLight(Ogre::ColourValue(0.5, 0.5, 0.5));
}

void Renderer::Start()
{
	//LIGHT

}

void Renderer::End()
{
	closeApp();
}