/*This source code copyrighted by Lazy Foo' Productions (2004-2019)
and may not be redistributed without written permission.*/

//Using SDL, SDL OpenGL, GLEW, standard IO, and strings
#include <SDL.h>
#include <gl\glew.h>
#include <SDL_opengl.h>
#include <gl\glu.h>
#include <stdio.h>
#include <string>
#include <vector>
#include <iostream>
#include "EventSystem.h"

//Screen dimension constants
const int SCREEN_WIDTH = 640;
const int SCREEN_HEIGHT = 480;

//The window we'll be rendering to
SDL_Window* gWindow = NULL;

//OpenGL context
SDL_GLContext gContext;

//Render flag
bool gRenderQuad = true;

//Graphics program
GLuint gProgramID = 0;
GLint gVertexPos3DLocation = -1;
GLuint gVBO = 0;
GLuint gIBO = 0;


void eventListner()
{
	
}

void update()
{
	//No per frame update needed
}

bool Initialise()
{
	if (SDL_Init(SDL_INIT_VIDEO | SDL_INIT_AUDIO) != 0) 
	{
		SDL_Log("Unable to initialize SDL: %s", SDL_GetError());
		return false;
	}

	gWindow = SDL_CreateWindow("A SDL Screen", 100, 100, SCREEN_WIDTH, SCREEN_HEIGHT, SDL_WINDOW_OPENGL);
	if (gWindow == NULL)
	{
		printf("Window could not be created! SDL Error: %s\n", SDL_GetError());
		return false;
	}
	else
	{
		gContext = SDL_GL_CreateContext(gWindow);
		if (gContext == NULL)
		{
			printf("OpenGL context could not be created! SDL Error: %s\n", SDL_GetError());
			return false;
		}
		else 
		{
			glewExperimental = GL_TRUE;
			GLenum glewError = glewInit();
			if (glewError != GLEW_OK)
			{
				printf("Error initializing GLEW! %s\n", glewGetErrorString(glewError));
			}

			//Use Vsync
			if (SDL_GL_SetSwapInterval(1) < 0)
			{
				printf("Warning: Unable to set VSync! SDL Error: %s\n", SDL_GetError());
			}

			//Initialize OpenGL
			/*if (!initGL())
			{
				printf("Unable to initialize OpenGL!\n");
				success = false;
			}*/
		}
	}
	
	printf("SDL Initialised \n");
	printf("OpenGL version supported by this platform (%s): \n", glGetString(GL_VERSION));
	return true;
}

void closeSDL()
{
	//Deallocate program
	glDeleteProgram(gProgramID);

	//Destroy window	
	SDL_DestroyWindow(gWindow);
	gWindow = NULL;

	//Quit SDL subsystems
	SDL_Quit();
}

void OpenGL()
{

}

void ErrorHandler()
{

}

void RenderScene()
{

}

void InputHandler()
{

}

int main(int argc, char* args[])
{
	EventQueue* EQ = new EventQueue();
	//Event* a = new Event(1, 1);
	//Start up SDL and create window
	if (!Initialise())
	{
		printf("Failed to initialize program!\n");
	}
	else
	{
		//Main loop flag
		bool quit = false;

		//Event handler
		SDL_Event e;

		//Enable text input
		SDL_StartTextInput();

		//While application is running
		while (!quit)
		{
			//Handle events on queue
			while (SDL_PollEvent(&e) != 0)
			{
				//User requests quit
				if (e.type == SDL_QUIT)
				{
					quit = true;
				}
				//Handle keypress with current mouse position
				else if (e.type == SDL_TEXTINPUT)
				{
					int x = 0, y = 0;
					SDL_GetMouseState(&x, &y);
					//handleKeys(e.text.text[0], x, y);
				}
			}

			//Render quad
			RenderScene();

			//Update screen
			SDL_GL_SwapWindow(gWindow);
		}

		//Disable text input
		SDL_StopTextInput();
	}

	//Free resources and close SDL
	closeSDL();

	return 0;
}