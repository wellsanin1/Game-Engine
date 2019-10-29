#include "GameEngine.h"

int main(int argc, char** argv)
{
	try
	{
		GameEngine app;
		app.Initialise();
		while (1)
		{
			app.Update();
		}
		app.Close();
	}
	catch (const std::exception& e)
	{
		std::cerr << "Error occurred during execution: " << e.what() << '\n';
		return 1;
	}
	return 0;
}
