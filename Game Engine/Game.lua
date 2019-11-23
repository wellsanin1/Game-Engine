function GameEngine(object)
	if (object:GetLevelManager():IsFinished() == true and object:GetLevelManager():GetCurrentLevel() == 0)
	then 
		object:GetLevelManager():StartLevel(1) 
	end
	if (object:GetLevelManager():IsFinished() == true and object:GetLevelManager():GetCurrentLevel() == 1)
	then 
		object:GetLevelManager():StartLevel(2)
		object:GetGameObjectWithName("penguin"):SetMass(0);
	end
end