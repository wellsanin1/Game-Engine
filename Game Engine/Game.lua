function GameEngine(Engine)
	require ("Variables")
	if (Engine:GetLevelManager():GetCurrentLevel() == 0)
	then 
		--Initialise level 1
		Engine:Reload(1)
		Engine:GetGameObjectWithName("plane"):SetMass(0)
		Engine:GetGameObjectWithName("Barrel"):SetMass(0)
	end
	if(Engine:GetLevelManager():GetCurrentLevel() == 1)
	then
		--Level 1 Logic
		local a = Engine:GetGameObjectWithName("OgreHead"):GetTransform()
		Engine:GetGameObjectWithName("myCam"):LookAt(a[1],a[2],a[3])

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
		if (Engine:GetGameObjectWithName("OgreHead"):GetCollision("Barrel") == true)
		then
			Level1Client = true
		end
		if Level1Client == true
		then
			Engine:GetGameObjectWithName("OgreHead"):SendToClient()
		end
	end
	
	
	if (Engine:GetLevelManager():GetFinished() == true and Engine:GetLevelManager():GetCurrentLevel() == 1)
	then 
		--Initialise level 2
		Engine:Reload(2)
		Engine:GetGameObjectWithName("plane"):SetMass(0)
		Engine:GetGameObjectWithName("Barrel"):SetMass(0)
	end
	if(Engine:GetLevelManager():GetCurrentLevel() == 2)
	then
		--Level 2 Logic
		
		
		local a = Engine:GetGameObjectWithName("OgreHead"):GetTransform()
		Engine:GetGameObjectWithName("myCam"):LookAt(a[1],a[2],a[3])
		
		
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
		if (Engine:GetGameObjectWithName("OgreHead"):GetCollision("Barrel") == true)
		then
			Level2Client = true
		end
		if Level2Client == true
		then
			Engine:GetGameObjectWithName("OgreHead"):SendToClient()
		end
	end
end