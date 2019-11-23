#include "Renderer.h"

Renderer::Renderer() :OgreBites::ApplicationContext("GameEngine")
{
}

void Renderer::Update()
{
	root->renderOneFrame();
}

void Renderer::setup()
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

}


void Renderer::End()
{
	closeApp();
}