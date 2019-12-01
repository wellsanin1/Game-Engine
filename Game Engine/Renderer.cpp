#include "Renderer.h"

Renderer::Renderer(ObjectPool* OP) :OgreBites::ApplicationContext("GameEngine")
{
	_OP = OP;
}

void Renderer::Update(EventQueue* EQ)
{
	//run function pointers based on enum from EventEnum.h
	for (int i = 0; i < EQ->Queue.size(); ++i)
	{
		event EV = EQ->CheckQueueReturnEvent(SubSystem_Renderer);
		if (EV.Empty == false)
		{
			Reactions A = EventReactions[(int)EV.RenderEventType];
			(this->*A)(EV.RD);
			EQ->RemoveFromQueue(SubSystem_Renderer);
		}
		else
		{
			break;
		}
	}
	//General Render Update from gameobjects. Not using events to not clog up the queue
	for (std::map<std::string, Ogre::SceneNode*>::iterator it = RendererAccessors.begin(); it != RendererAccessors.end(); ++it)
	{
			std::vector<double> Vector = _OP->GetObjectFromPool(it->first)->GetTransform();
			it->second->setPosition(Vector[0], Vector[1], Vector[2]);
	}

	root->renderOneFrame();
}

void Renderer::setup()
{
	//Ogre setup



	OgreBites::ApplicationContext::setup();
	root = getRoot();
	scnMgr = root->createSceneManager();
	shadergen = Ogre::RTShader::ShaderGenerator::getSingletonPtr();
	shadergen->addSceneManager(scnMgr);
	scnMgr->setAmbientLight(Ogre::ColourValue(0.5, 0.5, 0.5));

	OverlayMgr = Ogre::OverlayManager::getSingletonPtr();
	Overlay = OverlayMgr->create("overlay1");
	panel = static_cast<Ogre::OverlayContainer*>(OverlayMgr->createOverlayElement("Panel", "container1"));
	panel->setDimensions(1, 1);
	panel->setPosition(0, 0);
	Overlay->add2D(panel);
	Overlay->show();
}

void Renderer::Start()
{

}

void Renderer::End()
{
	closeApp();
}

void Renderer::Restart()
{
	//Restart renderer
	scnMgr = root->createSceneManager();
	shadergen->addSceneManager(scnMgr);
	scnMgr->setAmbientLight(Ogre::ColourValue(0.5, 0.5, 0.5));
	RendererAccessors.erase(RendererAccessors.begin(),RendererAccessors.end());
}

void Renderer::CreateTextBox(RendererData RD)
{
	if (!panel->getChild(RD.Name))
	{
		Ogre::OverlayElement* textBox = OverlayMgr->createOverlayElement("TextArea", RD.Name);
		textBox->setDimensions(RD.Width, RD.Height);
		textBox->setMetricsMode(Ogre::GMM_PIXELS);
		textBox->setPosition(RD.TextPosX, RD.TextPosY);
		textBox->setWidth(RD.Width);
		textBox->setHeight(RD.Height);
		textBox->setParameter("font_name", "MyFont");
		textBox->setParameter("char_height", "0.3");
		textBox->setColour(Ogre::ColourValue::Blue);
		textBox->setCaption(RD.Text);
		panel->addChild(textBox);
	}
}
void Renderer::RemoveTextBox(RendererData RD)
{
	panel->removeChild(RD.Name);
	OverlayMgr->destroyOverlayElement(RD.Name);
}

void Renderer::SetText(RendererData RD)
{
	Ogre::OverlayElement* textBox = OverlayMgr->getOverlayElement(RD.Name);
	textBox->setCaption(RD.Text);
}

std::string Renderer::GetText(std::string Name)
{
	Ogre::OverlayElement* textBox = OverlayMgr->getOverlayElement(Name);
	return textBox->getCaption();
}

void Renderer::CreateEntity(RendererData RD)
{
	//Ogre requires both scene nodes and entities/cameras/lights
	Ogre::Entity* OgreEntity = scnMgr->createEntity(RD.Name, RD.MeshName);
	Ogre::SceneNode* OgreNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	OgreNode->attachObject(OgreEntity);

	RendererAccessors.insert({ RD.Name,OgreNode});

	//attach to gameobject. quick fix, can be removed with more time
	_OP->GetObjectFromPool(RD.Name)->entity = OgreEntity;
	_OP->GetObjectFromPool(RD.Name)->OgreAttached = true;

	std::cout << "created renderer obj with name: " << RD.Name << std::endl;
}
void Renderer::CreateCamera(RendererData RD)
{
	//Ogre requires both scene nodes and entities/cameras/lights
	Ogre::SceneNode* camNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	Ogre::Camera* cam = scnMgr->createCamera(RD.Name);
	camNode->attachObject(cam);

	camNode->setFixedYawAxis(true);
	cam->setAutoAspectRatio(true);
	cam->setNearClipDistance(NearCamClipDistance);

	getRenderWindow()->removeAllViewports();
	getRenderWindow()->addViewport(cam);
	

	RendererAccessors.insert({ RD.Name,camNode });

	//attach to gameobject. quick fix, can be removed with more time
	_OP->GetObjectFromPool(RD.Name)->Camera = cam;
	_OP->GetObjectFromPool(RD.Name)->OgreAttached = true;

	std::cout << "created renderer obj with name: " << RD.Name << std::endl;
}
void Renderer::CreateLight(RendererData RD)
{
	//Ogre requires both scene nodes and entities/cameras/lights
	Ogre::Light* light = scnMgr->createLight(RD.Name);
	Ogre::SceneNode* lightNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	lightNode->attachObject(light);


	RendererAccessors.insert({ RD.Name, lightNode });

	//attach to gameobject. quick fix, can be removed with more time
	_OP->GetObjectFromPool(RD.Name)->Light = light;
	_OP->GetObjectFromPool(RD.Name)->OgreAttached = true;

	std::cout << "created renderer obj with name: " << RD.Name << std::endl;
}
void Renderer::LookAt(RendererData RD)
{
	//Look at object in scene at position
	Ogre::SceneNode* SN = RendererAccessors.at(RD.Name);
	SN->lookAt(Ogre::Vector3(RD.positions.x, RD.positions.y, RD.positions.z), Ogre::Node::TS_WORLD, Ogre::Vector3::NEGATIVE_UNIT_Z);
}

void Renderer::SetPosition(RendererData RD)
{
	//Teleport object to position using events
	Ogre::SceneNode* SN = RendererAccessors.at(RD.Name);
	SN->setPosition(RD.positions.x,RD.positions.y,RD.positions.z);
}

void Renderer::SetOrientation(RendererData RD)
{
	//Set orientation of object using events
	Ogre::SceneNode* SN = RendererAccessors.at(RD.Name);
	SN->setOrientation(Ogre::Quaternion(RD.Orientation.w
										,RD.Orientation.x
										,RD.Orientation.y
										,RD.Orientation.z));
}
