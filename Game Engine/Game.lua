function GameEngine(Engine)
	require ("GlobalVariables")
	if (Engine:GetLevelManager():GetCurrentLevel() == 0)
	then 
		--Initialise level 1
		Engine:Reload(1)
		return
	end
	if(Engine:GetLevelManager():GetCurrentLevel() == 1)
	then
		require("Level1Variables")
		Engine:GetGameObjectWithName("plane"):SetMass(0)
		Engine:GetGameObjectWithName("Barrel"):SetMass(0)
		Engine:GetGameObjectWithName("myCam"):SetGravity(0,0,0)

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
		if (KeyManager:GetKey(QUIT) == true)
		then
			Engine:Quit()
		end

		if (Engine:GetGameObjectWithName("OgreHead"):GetCollision("Barrel"))
		then
			SendData = true
		end
		if(SendData == true)
		then
			Engine:GetGameObjectWithName("OgreHead"):SendToClient()
		end
		
		if (Engine:GetGameObjectWithName("OgreHead"):GetCollision("Cube1") and cube1 == false )
		then
			cube1 = true
			Engine:LuaStringOUT("CUBE1")
			CollectableCount = CollectableCount+1
			Engine:GetGameObjectWithName("Cube1"):Teleport(0,-1000,0)
		end
		if (Engine:GetGameObjectWithName("OgreHead"):GetCollision("Cube2") and cube2 == false)
		then
		cube2 = true
			CollectableCount = CollectableCount+1
			Engine:GetGameObjectWithName("Cube2"):Teleport(0,-1100,0)
			Engine:LuaStringOUT("CUBE2")
		end
		if (CollectableCount == 2)
		then
			SendData = false
			Engine:Reload(2)
			return
		end
		
		
	end
	if(Engine:GetLevelManager():GetCurrentLevel() ==2)
	then
		Engine:GetGameObjectWithName("plane"):SetMass(0)
		Engine:GetGameObjectWithName("Barrel"):SetMass(0)
		Engine:GetGameObjectWithName("myCam"):SetGravity(0,0,0)

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
		if (KeyManager:GetKey(QUIT) == true)
		then
			Engine:Quit()
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