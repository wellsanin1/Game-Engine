/*This source code copyrighted by Lazy Foo' Productions (2004-2019)
and may not be redistributed without written permission.*/

//Using SDL, SDL OpenGL, GLEW, standard IO, and strings

#define _CRT_SECURE_NO_WARNINGS

#include <SDL.h>
#include <gl\glew.h>
#include <SDL_opengl.h>
#include <gl\glu.h>
#include <stdio.h>
#include <string>
#include <vector>
#include <iostream>
#include <glm/glm/mat4x4.hpp>
#include <glm/glm/gtc/matrix_transform.hpp>
#include <glm/glm/gtc/type_ptr.hpp>

#include "EventSystem.h"



//Screen dimension constants
const int SCREEN_WIDTH = 640;
const int SCREEN_HEIGHT = 480;

//The window we'll be rendering to
SDL_Window* gWindow = NULL;

//OpenGL context
SDL_GLContext gContext;

static unsigned int projMatLoc;
static unsigned int modelViewMatLoc;
static unsigned int NormalMatLoc;

static unsigned int
vertexShaderId,
fragmentShaderId,
vao[1],
buffer[1];

//Render flag
bool gRenderQuad = true;

//Graphics program
GLuint gProgramID = 0;
GLuint gVBO = 0;

static enum buffer { SQUARE_VERTICES };
static enum object { SQUARE };

struct Matrix4x4
{
	float entries[16];
};

static const Matrix4x4 IDENTITY_MATRIX4x4 =
{
   {
	  1.0, 0.0, 0.0, 0.0,
	  0.0, 1.0, 0.0, 0.0,
	  0.0, 0.0, 1.0, 0.0,
	  0.0, 0.0, 0.0, 1.0
   }
};
	
struct Vertex
{
	float coords[4];
	float colors[4];
};

static Vertex squareVertices[] =
{
   { { 20.0, 20.0, 0.0, 1.0 }, { 0.0, 0.0, 0.0, 1.0 } },
   { { 80.0, 20.0, 0.0, 1.0 }, { 0.0, 0.0, 0.0, 1.0 } },
   { { 20.0, 80.0, 0.0, 1.0 }, { 0.0, 0.0, 0.0, 1.0 } },
   { { 80.0, 80.0, 0.0, 1.0 }, { 0.0, 0.0, 0.0, 1.0 } }
};

bool OpenGL();


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
				return false;
			}

			//Use Vsync
			if (SDL_GL_SetSwapInterval(1) < 0)
			{
				printf("Warning: Unable to set VSync! SDL Error: %s\n", SDL_GetError());
				return false;
			}

			//Initialize OpenGL
			if (!OpenGL())
			{
				printf("Unable to initialize OpenGL!\n");
				return false;
			}
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

char* readTextFile(char* aTextFile)
{
	FILE* filePointer = fopen(aTextFile, "rb");
	char* content = NULL;
	long numVal = 0;

	fseek(filePointer, 0L, SEEK_END);
	numVal = ftell(filePointer);
	fseek(filePointer, 0L, SEEK_SET);
	content = (char*)malloc((numVal + 1) * sizeof(char));
	fread(content, 1, numVal, filePointer);
	content[numVal] = '\0';
	fclose(filePointer);
	return content;
}

bool OpenGL()
{

		/*projMatLoc = glGetUniformLocation(gProgramID, "projMat");
		projMat = glm::frustum(-5.0, 5.0, -5.0, 5.0, 5.0, 100.0);
		glUniformMatrix4fv(projMatLoc, 1, GL_FALSE, glm::value_ptr(projMat));
		modelViewMatLoc = glGetUniformLocation(gProgramID, "modelViewMat");
		normalMat = glm::transpose(glm::inverse(glm::mat3(modelViewMat)));
*/
		//Generate program
		gProgramID = glCreateProgram();


		//Get vertex source
		char* vertexShader = readTextFile((char*)"vertexShader.glsl");
		GLuint vertexShaderId = glCreateShader(GL_VERTEX_SHADER);
		glShaderSource(vertexShaderId, 1, (const char**) &vertexShader, NULL);
		glCompileShader(vertexShaderId);

		//Check vertex shader for errors
		GLint vShaderCompiled = GL_FALSE;
		glGetShaderiv(vertexShaderId, GL_COMPILE_STATUS, &vShaderCompiled);
		if (vShaderCompiled != GL_TRUE)
		{
			printf("Unable to compile vertex shader %d!\n", vertexShaderId);
			return false;
		}
		else
		{
			//Attach vertex shader to program
			glAttachShader(gProgramID, vertexShaderId);


			//Get Fragment Source
			char* fragmentShader = readTextFile((char*)"fragmentShader.glsl");
			GLuint fragmentShaderId = glCreateShader(GL_FRAGMENT_SHADER);
			glShaderSource(fragmentShaderId, 1, (const char**)& fragmentShader, NULL);
			glCompileShader(fragmentShaderId);

			//Check fragment shader for errors
			GLint fShaderCompiled = GL_FALSE;
			glGetShaderiv(fragmentShaderId, GL_COMPILE_STATUS, &fShaderCompiled);
			if (fShaderCompiled != GL_TRUE)
			{
				printf("Unable to compile fragment shader %d!\n", fragmentShader);
				return false;
			}
			else
			{
				//Attach fragment shader to program
				glAttachShader(gProgramID, fragmentShaderId);
				//Link program
				glLinkProgram(gProgramID);

				//Check for errors
				GLint programSuccess = GL_TRUE;
				glGetProgramiv(gProgramID, GL_LINK_STATUS, &programSuccess);
				if (programSuccess != GL_TRUE)
				{
					printf("Error linking program %d!\n", gProgramID);
					return false;
				}
				else
				{
					//Get vertex attribute location
					GLint SquareCoords = glGetAttribLocation(gProgramID, "squareCoords");
					GLint SquareColours = glGetAttribLocation(gProgramID, "squareColors");
					if (SquareCoords == -1 || SquareColours == -1)
					{
						printf("Program has a non valid variable \n");
						return false;
					}
					else
					{
						//Initialize clear color
						glClearColor(1.0, 1.0, 1.0, 0.0);

						glGenVertexArrays(1, vao);
						glGenBuffers(1, buffer);
						glBindVertexArray(vao[SQUARE]);
						glBindBuffer(GL_ARRAY_BUFFER, buffer[SQUARE_VERTICES]);
						glBufferData(GL_ARRAY_BUFFER, sizeof(squareVertices), squareVertices, GL_STATIC_DRAW);

						glVertexAttribPointer(0, 4, GL_FLOAT, GL_FALSE, sizeof(squareVertices[0]), 0);
						glEnableVertexAttribArray(0);
						glVertexAttribPointer(1, 4, GL_FLOAT, GL_FALSE, sizeof(squareVertices[0]), (GLvoid*)sizeof(squareVertices[0].coords));
						glEnableVertexAttribArray(1);
					}
				}
			}
		}

		///////////////////////////////////////

		// Obtain projection matrix uniform location and set value.
		Matrix4x4 projMat =
		{
		   {
			  0.02, 0.0,  0.0, -1.0,
			  0.0,  0.02, 0.0, -1.0,
			  0.0,  0.0, -1.0,  0.0,
			  0.0,  0.0,  0.0,  1.0
		   }
		};
		projMatLoc = glGetUniformLocation(gProgramID, "projMat");
		glUniformMatrix4fv(projMatLoc, 1, GL_TRUE, projMat.entries);
		///////////////////////////////////////

		// Obtain modelview matrix uniform location and set value.
		Matrix4x4 modelViewMat = {	1.0, 0.0, 0.0, 0.0,
									0.0, 1.0, 0.0, 0.0,
									0.0, 0.0, 1.0, 0.0,
									0.0, 0.0, 0.0, 1.0
									};
		modelViewMatLoc = glGetUniformLocation(gProgramID, "modelViewMat");
		glUniformMatrix4fv(modelViewMatLoc, 1, GL_TRUE, modelViewMat.entries);
		///////////////////////////////////////

		return true;
}

void ErrorHandler()
{

}

void RenderScene()
{
	//Clear color buffer
	glClear(GL_COLOR_BUFFER_BIT);

	//Render quad
	if (gRenderQuad)
	{
		//Bind program
		glUseProgram(gProgramID);

		glDrawElements(GL_TRIANGLE_STRIP, 4, GL_UNSIGNED_INT, NULL);

		glUseProgram(NULL);
	}
	glFlush();
}

void InputHandler()
{

}

int main(int argc, char* args[])
{

	SDL_GL_SetAttribute(SDL_GL_CONTEXT_MAJOR_VERSION, 3);
	SDL_GL_SetAttribute(SDL_GL_CONTEXT_MINOR_VERSION, 1);
	SDL_GL_SetAttribute(SDL_GL_CONTEXT_PROFILE_MASK, SDL_GL_CONTEXT_PROFILE_CORE);

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