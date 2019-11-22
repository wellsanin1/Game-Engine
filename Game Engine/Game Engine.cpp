#include "GameEngine.h"

void GameEngine::Game()
{

}
void GameEngine::LuaTestFunction()
{
	std::cout << "Hello fsdfsdf World"<<std::endl;
}
void GameEngine::ExecuteLUA()
{
	GameEngine::register_lua(LH.L());
	LH.ExecuteFile("test.lua");
	return;
}
void GameEngine::register_lua(lua_State* L)
{
	using namespace luabridge;
	getGlobalNamespace(L) //global namespace to lua
		.beginNamespace("Engine") //our defined namespace (w.e we want to call it)
		.beginClass<GameEngine>("GameEngine") //define class object
		.addConstructor<void (*)(void)>() //reg. empty constructor
		.addFunction("LuaTestFunction", &GameEngine::LuaTestFunction) //reg. setName function
		.endClass() //end class
		.endNamespace(); //end namespace
}
void GameEngine::Start()
{
	for (int i = 0;i< LH.entityList.size();++i)
	{
		if (LH.entityList[i]->UnionType == "Entity")
		{
			LuaGenStruct::LuaGeneric GenEnt = LH.entityList[i]->GenericStore;
			OP.CreateEntity(GenEnt.Entity->Name, GenEnt.Entity->Mesh, GenEnt.Entity->x, GenEnt.Entity->y, GenEnt.Entity->z, &PM, &R);
			OP.GetObject(GenEnt.Entity->Name)->register_lua(LH.L());
		}
		if (LH.entityList[i]->UnionType == "Camera")
		{
			LuaGenStruct::LuaGeneric GenEnt = LH.entityList[i]->GenericStore;
			OP.CreateCamera(GenEnt.Camera->Name,GenEnt.Camera->x, GenEnt.Camera->y, GenEnt.Camera->z, &PM, &R);
			R.getRenderWindow()->addViewport(OP.GetObject(GenEnt.Camera->Name)->StoredObject.Camera);
			OP.GetObject(GenEnt.Camera->Name)->register_lua(LH.L());
		}
		if (LH.entityList[i]->UnionType == "Light")
		{
			LuaGenStruct::LuaGeneric GenEnt = LH.entityList[i]->GenericStore;
			OP.CreateLight(GenEnt.Light->Name, GenEnt.Light->x, GenEnt.Light->y, GenEnt.Light->z,&PM,&R);
			OP.GetObject(GenEnt.Light->Name)->register_lua(LH.L());
		}
	}
	OP.GetObject("penguin")->SetMass(0,&PM);
	ExecuteLUA();
}

void GameEngine::PhysicsUpdate()
{
	PM.PhysicsUpdate(&OP);
}

void GameEngine::Audio()
{
	//AM.PlaySound("rain.wav");
}

void GameEngine::CheckInput()
{
	KM.InputRead(&EQ);


	while (EventEnum Enum = EQ.CheckQueue(event::TEST))
	{
		switch (Enum)
		{
		case NONE:
			break;
		case UP:
			std::cout << "UP" << std::endl;
			OP.GetObject("OgreHead")->AddVelocity(0, -100, 0);
			break;
		case LEFT:
			std::cout << "LEFT" << std::endl;
			OP.GetObject("OgreHead")->AddVelocity(0, 100, 0);
			break;
		case QUIT:
			std::cout << "QUIT" << std::endl;
			break;
		}
	}
}

void GameEngine::Render()
{
	R.Update();
}

void GameEngine::Quit()
{

}

void GameEngine::Update()
{
	CheckInput();
	PhysicsUpdate();
	Render();
	Game();
	Audio();
}

void GameEngine::Initialise()
{
	R.initApp();
	if (SDL_Init(SDL_INIT_VIDEO | SDL_INIT_AUDIO) != 0) 
	{
		SDL_Log("Unable to initialize SDL: %s", SDL_GetError());
		return;
	}
	AM.Loader();
	Start();
}

void GameEngine::Close()
{
	SDL_Quit();
	PM.dealloc();
}