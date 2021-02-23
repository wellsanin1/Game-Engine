#include "Renderer.h"

Renderer::Renderer(ObjectPool* OP) : OgreBites::ApplicationContext("GameEngine")
{
	_OP = OP;
}

void Renderer::Update(EventQueue* EQ)
{
	FrameTimer.reset();
	root->renderOneFrame();
	//run function pointers based on enum from EventEnum.h
	for (int i = 0; i < EQ->Queue.size(); ++i)
	{
		event EV = EQ->CheckQueueReturnEvent(SubSystem_Renderer);
		if (EV.Empty == false)
		{
			if (EV.RenderEventType == Render_REMOVETEXTBOX)
			{
				std::cout << "TEST" << std::endl;
			}

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

	//OverlayMgr = OGRE_NEW Ogre::OverlayManager();
	Traymgr = new OgreBites::TrayManager("InterfaceName", getRenderWindow());
	addInputListener(Traymgr);
	scnMgr->addRenderQueueListener(getOverlaySystem());
	Traymgr->hideCursor();
}

void Renderer::Start()
{

}

void Renderer::End()
{
	delete Traymgr;
	closeApp();
}

void Renderer::Restart()
{
	//Restart renderer
	scnMgr = root->createSceneManager();
	shadergen->addSceneManager(scnMgr);
	scnMgr->setAmbientLight(Ogre::ColourValue(0.5, 0.5, 0.5));
	RendererAccessors.erase(RendererAccessors.begin(),RendererAccessors.end());
	TextAccessors.erase(TextAccessors.begin(), TextAccessors.end());
	Traymgr->destroyAllWidgets();
	addInputListener(Traymgr);
	scnMgr->addRenderQueueListener(getOverlaySystem());
	Traymgr->hideCursor();
}

void Renderer::Animation(RendererData RD)
{
	Ogre::Entity* MO = static_cast<Ogre::Entity*>(RendererAccessors.at(RD.Name)->getAttachedObject(0));
	Ogre::AnimationState* AS = MO->getAnimationState(RD.AnimationName);
	if (!AS->getEnabled())
	{
		AS->setLoop(true);
		AS->setEnabled(true);
	}
	AS->addTime(FrameTimer.getMilliseconds());
}

float Renderer::GetFPS()
{
	return getRenderWindow()->getStatistics().avgFPS;
}

void Renderer::CreateTextBox(RendererData RD)
{
	if (TextAccessors.find(RD.Name) == TextAccessors.end()) 
	{
		OgreBites::TextBox* TB = Traymgr->createTextBox((OgreBites::TrayLocation)RD.TextPosition, RD.Name, RD.Text, RD.Width, RD.Height);
		TextAccessors.insert({ RD.Name,TB });
	}
	else 
	{
		Traymgr->destroyWidget(RD.Name);
		TextAccessors.erase(RD.Name);
		OgreBites::TextBox* TB = Traymgr->createTextBox((OgreBites::TrayLocation)RD.TextPosition, RD.Name, RD.Text, RD.Width, RD.Height);
		TextAccessors.insert({ RD.Name,TB });
	}
}
void Renderer::RemoveTextBox(RendererData RD)
{
	if (TextAccessors.find(RD.Name) == TextAccessors.end())
	{
		Traymgr->destroyWidget(RD.Name);
		TextAccessors.erase(RD.Name);
	}
	else
	{
		std::cout << "TextBox with name:" << RD.Name << "does not exist" << std::endl;
	}
}

void Renderer::SetText(RendererData RD)
{
	//Ogre::OverlayElement* textBox = OverlayMgr->getOverlayElement(RD.Name);
	//textBox->setCaption(RD.Text);
}

std::string Renderer::GetText(std::string Name)
{
	//Ogre::OverlayElement* textBox = OverlayMgr->getOverlayElement(Name);
	//return textBox->getCaption();
}

void Renderer::CreateEntity(RendererData RD)
{
	//Ogre requires both scene nodes and entities/cameras/lights
	Ogre::Entity* OgreEntity = scnMgr->createEntity(RD.Name, RD.MeshName);
	Ogre::SceneNode* OgreNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	OgreNode->attachObject(OgreEntity);

	RendererAccessors.insert({ RD.Name,OgreNode});

	//attach to gameobject. quick fix, can be removed with more time

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
	getRenderWindow()->getViewport(0)->setOverlaysEnabled(true);
	
	RendererAccessors.insert({ RD.Name,camNode });

	//attach to gameobject. quick fix, can be removed with more time

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
