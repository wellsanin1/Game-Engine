function GameEngine(Engine)
	require ("Variables")
	if (Engine:GetLevelManager():GetCurrentLevel() == 0)
	then 
		--Initialise level 1
		Engine:Reload(1)
	end
	if(Engine:GetLevelManager():GetCurrentLevel() == 1)
	then
		--Engine:GetGameObjectWithName("plane"):SetMass(0)
		--Engine:GetGameObjectWithName("Barrel"):SetMass(0)
	end
	
end