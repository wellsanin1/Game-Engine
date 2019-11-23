function GameEngine(Engine)
	if (Engine:GetLevelManager():GetFinished() == true and Engine:GetLevelManager():GetCurrentLevel() == 0)
	then 
		Engine:GetLevelManager():StartLevel(1) 
		Engine:LoadEntitiesIntoEngine(1);
	end
	if (Engine:GetLevelManager():GetFinished() == true and Engine:GetLevelManager():GetCurrentLevel() == 1)
	then 
		Engine:GetLevelManager():StartLevel(2)
		Engine:LoadEntitiesIntoEngine(2);
		Engine:GetGameObjectWithName("penguin"):SetMass(0);
	end

	if(Engine:GetLevelManager():GetCurrentLevel() == 1)
	then
		--Level 1 Logic
	end
	if(Engine:GetLevelManager():GetCurrentLevel() == 1)
	then
		--Level 2 Logic
	end
end