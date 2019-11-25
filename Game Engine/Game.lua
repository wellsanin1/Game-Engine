function GameEngine(Engine)
	require "Variables"
	if (Engine:GetLevelManager():GetCurrentLevel() == 0)
	then 
		--Initialise level 1
		Engine:GetLevelManager():StartLevel(1) 
		Engine:LoadEntitiesIntoEngine(1)
		Engine:GetGameObjectWithName("penguin"):SetMass(0)
		Engine:GetGameObjectWithName("plane"):SetMass(0)
	end
	if(Engine:GetLevelManager():GetCurrentLevel() == 1)
	then
		--Level 1 Logic
		if Engine:GetGameObjectWithName("penguin"):IsColliding("OgreHead")
		then
			Engine:GetLevelManager():SetFinished(true)
		end
	end
	
	
	if (Engine:GetLevelManager():GetFinished() == true and Engine:GetLevelManager():GetCurrentLevel() == 1)
	then 
		--Initialise level 2
		Engine:GetLevelManager():StartLevel(2)
		Engine:LoadEntitiesIntoEngine(2)
		Engine:GetGameObjectWithName("penguin"):SetMass(0)
		Engine:GetGameObjectWithName("plane"):SetMass(0)
	end
	if(Engine:GetLevelManager():GetCurrentLevel() == 2)
	then
		--Level 2 Logic
		if Engine:GetGameObjectWithName("penguin"):IsColliding("OgreHead")
		then
			--Engine:LuaIntOUT(CollectableCount)
		end
	end
end