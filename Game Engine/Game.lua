function GameEngine(Engine)
	require ("Variables")
	if (Engine:GetLevelManager():GetCurrentLevel() == 0)
	then 
		--Initialise level 1
		Engine:Reload(1)
		return
	end
	if(Engine:GetLevelManager():GetCurrentLevel() == 1)
	then
		Engine:GetGameObjectWithName("plane"):SetMass(0)
		Engine:GetGameObjectWithName("myCam"):SetGravity(0,0,0)
		
		local a = Engine:GetGameObjectWithName("OgreHead"):GetTransform()
		Engine:GetGameObjectWithName("myCam"):LookAt(a[1],a[2],a[3])
		
		local KeyManager = Engine:GetKeyManager()
		if (KeyManager:GetKey(UP) == true)
		then
			Engine:GetGameObjectWithName("OgreHead"):TranslateLocally(0,0,100);
		end
		if (KeyManager:GetKey(DOWN) == true)
		then
			Engine:GetGameObjectWithName("OgreHead"):TranslateLocally(0,0,-100);
		end
		if (KeyManager:GetKey(LEFT) == true)
		then
			Engine:GetGameObjectWithName("OgreHead"):TranslateLocally(-100,0,0);
		end
		if (KeyManager:GetKey(RIGHT) == true)
		then
			Engine:GetGameObjectWithName("OgreHead"):TranslateLocally(100,0,0);
		end

		if (Engine:GetGameObjectWithName("OgreHead"):GetCollision("Barrel"))
		then
			SendData = true
		end
		if(SendData == true)
		then
			Engine:GetGameObjectWithName("OgreHead"):SendToClient()
		end
	end
	
end