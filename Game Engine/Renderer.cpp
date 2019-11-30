#include "Renderer.h"

Renderer::Renderer(ObjectPool* OP) :OgreBites::ApplicationContext("GameEngine")
{
	_OP = OP;
}

void Renderer::Update(EventQueue* EQ)
{
	for (int i = 0; i < EQ->Queue.size(); ++i)
	{
		event EV = EQ->CheckQueueReturnEvent(SubSystem_Renderer);
		if (EV.Empty == false)
		{
			for (int j = 0; j < EV.SubSystemList.size(); ++j)
			{
				if (EV.SubSystemList[j] == SubSystem_Renderer)
				{
					Reactions A = EventReactions[(int)EV.RenderEventType];
					(this->*A)(EV.RD);
					EQ->RemoveFromQueue(SubSystem_Renderer);
				}
			}
		}
		else
		{
			break;
		}
	}
	//General Render Update
	for (std::unordered_map<std::string,Ogre::SceneNode*>::iterator it = RendererAccessors.begin(); it != RendererAccessors.end(); ++it)
	{
		std::vector<double> Vector =_OP->GetObjectFromPool(it->first)->GetTransform();
		it->second->setPosition(Vector[0],Vector[1],Vector[2]);
	}

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

void Renderer::Restart()
{
	scnMgr = root->createSceneManager();
	shadergen->addSceneManager(scnMgr);
	scnMgr->setAmbientLight(Ogre::ColourValue(0.5, 0.5, 0.5));
	RendererAccessors.erase(RendererAccessors.begin(),RendererAccessors.end());
}

void Renderer::CreateEntity(RendererData RD)
{
	Ogre::Entity* OgreEntity = scnMgr->createEntity(RD.Name, RD.MeshName);
	Ogre::SceneNode* OgreNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	OgreNode->attachObject(OgreEntity);

	RendererAccessors.insert({ RD.Name,OgreNode});

	_OP->GetObjectFromPool(RD.Name)->entity = OgreEntity;
	_OP->GetObjectFromPool(RD.Name)->OgreAttached = true;

	std::cout << "created renderer obj with name: " << RD.Name << std::endl;
}
void Renderer::CreateCamera(RendererData RD)
{
	Ogre::SceneNode* camNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	Ogre::Camera* cam = scnMgr->createCamera(RD.Name);
	camNode->attachObject(cam);

	cam->setAutoAspectRatio(true);
	cam->setNearClipDistance(NearCamClipDistance);

	getRenderWindow()->removeAllViewports();
	getRenderWindow()->addViewport(cam);

	RendererAccessors.insert({ RD.Name,camNode });

	_OP->GetObjectFromPool(RD.Name)->Camera = cam;
	_OP->GetObjectFromPool(RD.Name)->OgreAttached = true;

	std::cout << "created renderer obj with name: " << RD.Name << std::endl;
}
void Renderer::CreateLight(RendererData RD)
{
	Ogre::Light* light = scnMgr->createLight(RD.Name);
	Ogre::SceneNode* lightNode = scnMgr->getRootSceneNode()->createChildSceneNode();
	lightNode->attachObject(light);


	RendererAccessors.insert({ RD.Name, lightNode });

	_OP->GetObjectFromPool(RD.Name)->Light = light;
	_OP->GetObjectFromPool(RD.Name)->OgreAttached = true;

	std::cout << "created renderer obj with name: " << RD.Name << std::endl;
}
void Renderer::LookAt(RendererData RD)
{
	Ogre::SceneNode* SN = RendererAccessors.at(RD.Name);
	SN->lookAt(Ogre::Vector3(RD.positions.x, RD.positions.y, RD.positions.z), Ogre::Node::TS_WORLD, Ogre::Vector3::NEGATIVE_UNIT_Z);
}

void Renderer::SetPosition(RendererData RD)
{
	Ogre::SceneNode* SN = RendererAccessors.at(RD.Name);
	SN->setPosition(RD.positions.x,RD.positions.y,RD.positions.z);
}

void Renderer::SetOrientation(RendererData RD)
{
	Ogre::SceneNode* SN = RendererAccessors.at(RD.Name);
	SN->setOrientation(Ogre::Quaternion(RD.Orientation.w
										,RD.Orientation.x
										,RD.Orientation.y
										,RD.Orientation.z));
}
