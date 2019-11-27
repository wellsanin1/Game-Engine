function GameEngine(Engine)
	require ("Variables")
	if (Engine:GetLevelManager():GetCurrentLevel() == 0)
	then 
		--Initialise level 1
		Engine:GetLevelManager():StartLevel(1) 
		Engine:LoadEntitiesIntoEngine(1)
		Engine:GetGameObjectWithName("penguin"):SetMass(0)
		--Engine:GetGameObjectWithName("plane"):SetMass(0)
	end
	if(Engine:GetLevelManager():GetCurrentLevel() == 1)
	then
		--Level 1 Logic
		local a = Engine:GetGameObjectWithName("OgreHead"):GetTransform()
		Engine:GetGameObjectWithName("myCam"):LookAt(a[1],a[2],a[3])
		if (Engine:GetGameObjectWithName("OgreHead"):GetCollision("Barrel") == true)
		then
			Engine:LuaStringOUT("Colliding")
			Engine:GetLevelManager():SetFinished(true)
		end

		local KeyManager = Engine:GetKeyManager()
		if (KeyManager:GetKey(UP) == true)
		then
			Engine:LuaStringOUT("UP")
		end
		if (KeyManager:GetKey(DOWN) == true)
		then
			Engine:LuaStringOUT("DOWN")
		end
	end
	
	
	if (Engine:GetLevelManager():GetFinished() == true and Engine:GetLevelManager():GetCurrentLevel() == 1)
	then 
		--Initialise level 2
		Engine:GetLevelManager():StartLevel(2)
		Engine:LoadEntitiesIntoEngine(2)
		Engine:GetGameObjectWithName("penguin"):SetMass(0)
		--Engine:GetGameObjectWithName("plane"):SetMass(0)
	end
	if(Engine:GetLevelManager():GetCurrentLevel() == 2)
	then
		--Level 2 Logic
		
		
		local a = Engine:GetGameObjectWithName("OgreHead"):GetTransform()
		Engine:GetGameObjectWithName("myCam"):LookAt(a[1],a[2],a[3])
		Engine:GetGameObjectWithName("OgreHead"):SendToClient()
		local KeyManager = Engine:GetKeyManager()
		if (KeyManager:GetKey(UP) == true)
		then
			Engine:GetGameObjectWithName("OgreHead"):TranslateLocally(0,0,-100);
		end
		if (KeyManager:GetKey(DOWN) == true)
		then
			Engine:GetGameObjectWithName("OgreHead"):TranslateLocally(0,0,100);
		end
		if (KeyManager:GetKey(LEFT) == true)
		then
			Engine:GetGameObjectWithName("OgreHead"):TranslateLocally(-100,0,0);
		end
		if (KeyManager:GetKey(RIGHT) == true)
		then
			Engine:GetGameObjectWithName("OgreHead"):TranslateLocally(100,0,0);
		end
		if (Engine:GetGameObjectWithName("penguin"):GetCollision("OgreHead") == true)
		then
			Engine:LuaIntOUT(CollectableCount)
		end
	end
end