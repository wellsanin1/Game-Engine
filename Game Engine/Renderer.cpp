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

void Renderer::Restart(RendererData RD)
{
	scnMgr = root->createSceneManager();
	shadergen->addSceneManager(scnMgr);
	scnMgr->setAmbientLight(Ogre::ColourValue(0.5, 0.5, 0.5));
}

void Renderer::CreateEntity(RendererData RD)
{
	Ogre::Entity* OgreEntity = scnMgr->createEntity(RD.Name, RD.MeshName);
	Ogre::SceneNode* OgreNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	btTransform NewTransform;
	OgreNode->attachObject(OgreEntity);
	OgreObject* Object = new OgreObject();
	Object->Entity = OgreEntity;
	JoinedStore JS = JoinedStore();;
	JS.Node = OgreNode;
	JS.Object->Entity = OgreEntity;
	RendererAccessors.insert(std::pair<std::string,JoinedStore>(RD.Name, JS));
}

void Renderer::CreateCamera(RendererData RD)
{
	Ogre::Light* light = scnMgr->createLight(RD.Name);
	Ogre::SceneNode* lightNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	JoinedStore JS = JoinedStore();;
	JS.Node = lightNode;
	JS.Object->Light = light;
	RendererAccessors.insert(std::pair<std::string, JoinedStore>(RD.Name, JS));
	getRenderWindow()->removeAllViewports();
	getRenderWindow()->addViewport(RendererAccessors.at(RD.Name).Object->Camera);
}

void Renderer::CreateLight(RendererData RD)
{
	Ogre::SceneNode* camNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	Ogre::Camera* cam = scnMgr->createCamera(RD.Name);
	cam->setAutoAspectRatio(true);
	cam->setNearClipDistance(NearCamClipDistance);
	JoinedStore JS = JoinedStore();
	JS.Node = camNode;
	JS.Object->Camera = cam;
	RendererAccessors.insert(std::pair<std::string, JoinedStore>(RD.Name, JS));
}

void Renderer::LookAt(RendererData RD)
{
	Ogre::SceneNode* SN = RendererAccessors.at(RD.Name).Node;
	SN->lookAt(Ogre::Vector3(RD.positions.x, RD.positions.y, RD.positions.z), Ogre::Node::TS_WORLD, Ogre::Vector3::NEGATIVE_UNIT_Z);
}

void Renderer::SetPosition(RendererData RD)
{
	Ogre::SceneNode* SN = RendererAccessors.at(RD.Name).Node;
	SN->setPosition(RD.positions.x,RD.positions.y,RD.positions.z);
}

void Renderer::SetOrientation(RendererData RD)
{
	Ogre::SceneNode* SN = RendererAccessors.at(RD.Name).Node;
	SN->setOrientation(Ogre::Quaternion(RD.Orientation.w
										,RD.Orientation.x
										,RD.Orientation.y
										,RD.Orientation.z));
}
