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

//btQuaternion orientation = trans.getRotation();
//Ogre::SceneNode* sceneNode = static_cast<Ogre::SceneNode*>(userPointer);
//sceneNode->setPosition(Ogre::Vector3(trans.getOrigin().getX(), trans.getOrigin().getY(), trans.getOrigin().getZ()));
//sceneNode->setOrientation(Ogre::Quaternion(orientation.getW(), orientation.getX(), orientation.getY(), orientation.getZ()));

void Renderer::Start()
{

}


void Renderer::End()
{
	closeApp();
}