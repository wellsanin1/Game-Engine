#include <Ogre.h>
#include <OgreTextAreaOverlayElement.h> 
#include <OgreFontManager.h> 
Ogre::RenderWindow *renderWindow = NULL;
class FrameListener : public Ogre::FrameListener
{
public:
	FrameListener(){}
	bool frameStarted(const Ogre::FrameEvent& evt)
    {
		// stop render in main window is closed
        if(renderWindow->isClosed()){return false;}
		return true;
	}
	bool frameEnded(const Ogre::FrameEvent &evt){return true;}
};

int main(int argc, char* argv[])
{
	try
	{
		//************************************************
		// Ogre Initialization
		//************************************************
		// create the root
		Ogre::Root *root = new Ogre::Root();

		// configure the renderer
		root->showConfigDialog();
		// init root
		root->initialise(false);
		// create the main window
		renderWindow = root->createRenderWindow("Main",640,480,false);
		// create a scene
		Ogre::SceneManager *sceneMan = root->getSceneManager(Ogre::ST_GENERIC);
		// createa a camera		
		Ogre::Camera *cam = sceneMan->createCamera("mainCam");
		// create a view port		
		Ogre::Viewport *vp = renderWindow->addViewport(cam);

		//************************************************
		// Load a font
		//************************************************
		// get the resource manager
		Ogre::ResourceGroupManager &resgroup = Ogre::ResourceGroupManager::getSingleton();
		// tell it to look at this location
		resgroup.addResourceLocation("<.ttf folder>", "FileSystem");
		// get the font manager
		Ogre::FontManager &fman = Ogre::FontManager::getSingleton();
		// create a font resource
		Ogre::ResourcePtr resource = fman.create("Arial",Ogre::ResourceGroupManager::DEFAULT_RESOURCE_GROUP_NAME);
		// set as truetype
		resource->setParameter("type","truetype");
		// set the .ttf file name
		resource->setParameter("source","<somefont.ttf>");
		// set the size
		resource->setParameter("size","16");
		// set the dpi
		resource->setParameter("resolution","96");
		// load the ttf
		resource->load();
		
		//************************************************
		// Create the text area
		//************************************************
		// adapted from http://www.ogre3d.org/wiki/index.php/Creating_Overlays_via_Code
		// credit to DWORD
		Ogre::OverlayManager& overlayManager = Ogre::OverlayManager::getSingleton();

		// Create a panel
		Ogre::OverlayContainer* panel = static_cast<Ogre::OverlayContainer*>(
			overlayManager.createOverlayElement("Panel", "PanelName"));
		panel->setMetricsMode(Ogre::GMM_PIXELS);
		panel->setPosition(10, 10);
		panel->setDimensions(100, 100);
		
		// Create a text area
		Ogre::TextAreaOverlayElement* textArea = static_cast<Ogre::TextAreaOverlayElement*>(
			overlayManager.createOverlayElement("TextArea", "TextAreaName"));
		textArea->setMetricsMode(Ogre::GMM_PIXELS);
		textArea->setPosition(0, 0);
		textArea->setDimensions(100, 100);
		textArea->setCharHeight(16);
		// set the font name to the font resource that you just created.
		textArea->setFontName("Arial");
		// say something
		textArea->setCaption("Hello, World!");
		
		// Add the text area to the panel
		panel->addChild(textArea);
		// Create an overlay, and add the panel
		Ogre::Overlay* overlay = overlayManager.create("OverlayName");
		overlay->add2D(panel);
		// Show the overlay
		overlay->show();

		//************************************************
		// Set the frame listener and start rendering
		//************************************************
		// add the simple frame listener
		FrameListener listener;
		root->addFrameListener(&listener);
		
		// start rendering
		root->startRendering();

	} catch(Ogre::Exception& e ) {
        printf("An exception has occured: %s\n",
                e.getFullDescription().c_str());
    }
	return 0;
}