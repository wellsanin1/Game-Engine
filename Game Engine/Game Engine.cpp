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

static glm::mat4 projMat = glm::mat4(1.0);
static unsigned int projMatLoc;

static glm::mat4 modelViewMat = glm::mat4(1.0);
static unsigned int modelViewMatLoc;

static glm::mat3 normalMat = glm::mat3(1.0);
static unsigned int NormalMatLoc;

static unsigned int
vertexShaderId,
fragmentShaderId;

//Render flag
bool gRenderQuad = true;

//Graphics program
GLuint gProgramID = 0;
GLint gVertexPos3DLocation = -1;
GLuint gVBO = 0;
GLuint gIBO = 0;

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
		projMatLoc = glGetUniformLocation(gProgramID, "projMat");
		projMat = glm::frustum(-5.0, 5.0, -5.0, 5.0, 5.0, 100.0);
		glUniformMatrix4fv(projMatLoc, 1, GL_FALSE, glm::value_ptr(projMat));
		modelViewMatLoc = glGetUniformLocation(gProgramID, "modelViewMat");
		normalMat = glm::transpose(glm::inverse(glm::mat3(modelViewMat)));

		//Success flag
		bool success = true;

		//Generate program
		gProgramID = glCreateProgram();

		//Create vertex shader
		//GLuint vertexShader = glCreateShader(GL_VERTEX_SHADER);

		//Get vertex source
		char* vertexShader = readTextFile((char*)"vertexShader.glsl");
		GLuint vertexShaderId = glCreateShader(GL_VERTEX_SHADER);
		glShaderSource(vertexShaderId, 1, (const char**) &vertexShader, NULL);
		glCompileShader(vertexShaderId);

		//printf("test");

		//const GLchar* vertexShaderSource[] =
		//{
		//	"#version 140\nin vec3 LVertexPos3D; void main() { gl_Position = vec4( LVertexPos3D.x, LVertexPos3D.y, LVertexPos3D.z, 1 ); }"
		//};
		////Set vertex source
		//glShaderSource(vertexShader, 1, vertexShaderSource, NULL);
		////Compile vertex source
		//glCompileShader(vertexShader);

		//Check vertex shader for errors
		GLint vShaderCompiled = GL_FALSE;
		glGetShaderiv(vertexShaderId, GL_COMPILE_STATUS, &vShaderCompiled);
		if (vShaderCompiled != GL_TRUE)
		{
			printf("Unable to compile vertex shader %d!\n", vertexShaderId);
			//printShaderLog(vertexShader);
			return false;
		}
		else
		{
			//Attach vertex shader to program
			glAttachShader(gProgramID, vertexShaderId);


			//Create fragment shader
			GLuint fragmentShader = glCreateShader(GL_FRAGMENT_SHADER);

			//Get fragment source
			const GLchar* fragmentShaderSource[] =
			{
				"#version 140\nout vec4 LFragment; void main() { LFragment = vec4( 1.0, 1.0, 1.0, 1.0 ); }"
			};

			//Set fragment source
			glShaderSource(fragmentShader, 1, fragmentShaderSource, NULL);

			//Compile fragment source
			glCompileShader(fragmentShader);

			//Check fragment shader for errors
			GLint fShaderCompiled = GL_FALSE;
			glGetShaderiv(fragmentShader, GL_COMPILE_STATUS, &fShaderCompiled);
			if (fShaderCompiled != GL_TRUE)
			{
				printf("Unable to compile fragment shader %d!\n", fragmentShader);
				//printShaderLog(fragmentShader);
				return false;
			}
			else
			{
				//Attach fragment shader to program
				glAttachShader(gProgramID, fragmentShader);


				//Link program
				glLinkProgram(gProgramID);

				//Check for errors
				GLint programSuccess = GL_TRUE;
				glGetProgramiv(gProgramID, GL_LINK_STATUS, &programSuccess);
				if (programSuccess != GL_TRUE)
				{
					printf("Error linking program %d!\n", gProgramID);
					//printProgramLog(gProgramID);
					return false;
				}
				else
				{
					//Get vertex attribute location
					gVertexPos3DLocation = glGetAttribLocation(gProgramID, "LVertexPos3D");
					if (gVertexPos3DLocation == -100000)
					{
						printf("LVertexPos3D is not a valid glsl program variable!\n");
						return false;
					}
					else
					{
						//Initialize clear color
						glClearColor(0.f, 0.f, 0.f, 1.f);



						//VBO data
						GLfloat vertexData[] =
						{
							-0.5f, -0.5f ,  0.5f
							, -0.5f , 0.5f, 0.5f 
							,-0.5f,  0.5f , 0.5f
						};

					
						//IBO data
						GLuint indexData[] = { 0, 1, 2, 4};

						//Create VBO
						glGenBuffers(1, &gVBO);
						glBindBuffer(GL_ARRAY_BUFFER, gVBO);
						glBufferData(GL_ARRAY_BUFFER, 2 * 4 * sizeof(GLfloat), squareVertices, GL_STATIC_DRAW);

						//Create IBO
						glGenBuffers(1, &gIBO);
						glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, gIBO);
						glBufferData(GL_ELEMENT_ARRAY_BUFFER, 4 * sizeof(GLuint), indexData, GL_STATIC_DRAW);
					}
				}
			}
		}

		return success;
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

		//Enable vertex position
		glEnableVertexAttribArray(gVertexPos3DLocation);

		//Set vertex data
		glBindBuffer(GL_ARRAY_BUFFER, gVBO);
		glVertexAttribPointer(gVertexPos3DLocation, 2, GL_FLOAT, GL_FALSE, 2 * sizeof(GLfloat), NULL);

		//Set index data and render
		glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, gIBO);
		glDrawElements(GL_TRIANGLE_STRIP, 4, GL_UNSIGNED_INT, NULL);

		//Disable vertex position
		glDisableVertexAttribArray(gVertexPos3DLocation);

		//Unbind program
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