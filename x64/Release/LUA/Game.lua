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
		
		if(BackgroundMusic == false)
		then
			Engine:PlayAudio("WayBackHome.wav")
			BackgroundMusic = true
		end
		
		Engine:EngineDrawText(0,Engine:GetFPS(),"TextBox1")
		Engine:GetGameObjectWithName("myCam"):SetGravity(0,0,0)

		local a = Engine:GetGameObjectWithName("Character"):GetTransform()
		Engine:GetGameObjectWithName("myCam"):LookAt(a[1],a[2],a[3])
		
		Engine:PlayAnimation("Robot","Idle")

		local KeyManager = Engine:GetKeyManager()
		if (KeyManager:GetKey(UP) == true)
		then
			Engine:GetGameObjectWithName("Character"):TranslateLocally(0,0,-100);
		end
		if (KeyManager:GetKey(DOWN) == true)
		then
			Engine:GetGameObjectWithName("Character"):TranslateLocally(0,0,100);
		end
		if (KeyManager:GetKey(LEFT) == true)
		then
			Engine:GetGameObjectWithName("Character"):TranslateLocally(-100,0,0);
		end
		if (KeyManager:GetKey(RIGHT) == true)
		then
			Engine:GetGameObjectWithName("Character"):TranslateLocally(100,0,0);
		end
		if (KeyManager:GetKey(QUIT) == true)
		then
			Engine:Quit()
		end

		if (Engine:GetGameObjectWithName("Character"):GetCollision("Camera1"))
		then
			SendData = true
		end
		if(SendData == true)
		then
			Engine:GetGameObjectWithName("Character"):SendToClient()
		end
		if (Engine:GetGameObjectWithName("Character"):GetCollision("Camera1") and cube1 == false )
		then
			Engine:PlayAudio("Audio1.wav")
			cube1 = true
			Engine:LuaStringOUT("Camera1")
			CollectableCount = CollectableCount+1
			Engine:GetGameObjectWithName("Camera1"):Teleport(0,-1000,0)
		end
		if (Engine:GetGameObjectWithName("Character"):GetCollision("Camera2") and cube2 == false)
		then
			Engine:PlayAudio("Audio2.wav")
			cube2 = true
			CollectableCount = CollectableCount+1
			Engine:GetGameObjectWithName("Camera2"):Teleport(0,-1100,0)
			Engine:LuaStringOUT("Camera2")
		end
		if (CollectableCount == 2)
		then
			SendData = false
			Engine:Reload(2)
			return
		end
		
		
	end
	if(Engine:GetLevelManager():GetCurrentLevel() == 2)
	then
		require("Level2Variables")
		if(BackgroundMusic == false)
		then
			Engine:PlayAudio("WayBackHome.wav")
			BackgroundMusic = true
		end
		
		Engine:EngineDrawText(0,Engine:GetFPS(),"TextBox1")
		Engine:GetGameObjectWithName("myCam"):SetGravity(0,0,0)

		local a = Engine:GetGameObjectWithName("Character"):GetTransform()
		Engine:GetGameObjectWithName("myCam"):LookAt(a[1],a[2],a[3])
		
		Engine:PlayAnimation("Robot","Idle")

		local KeyManager = Engine:GetKeyManager()
		if (KeyManager:GetKey(UP) == true)
		then
			Engine:GetGameObjectWithName("Character"):TranslateLocally(0,0,-100);
		end
		if (KeyManager:GetKey(DOWN) == true)
		then
			Engine:GetGameObjectWithName("Character"):TranslateLocally(0,0,100);
		end
		if (KeyManager:GetKey(LEFT) == true)
		then
			Engine:GetGameObjectWithName("Character"):TranslateLocally(-100,0,0);
		end
		if (KeyManager:GetKey(RIGHT) == true)
		then
			Engine:GetGameObjectWithName("Character"):TranslateLocally(100,0,0);
		end
		if (KeyManager:GetKey(QUIT) == true)
		then
			Engine:Quit()
		end

		if (Engine:GetGameObjectWithName("Character"):GetCollision("Camera1"))
		then
			SendData = true
		end
		if(SendData == true)
		then
			Engine:GetGameObjectWithName("Character"):SendToClient()
		end
		if (Engine:GetGameObjectWithName("Character"):GetCollision("Camera1") and cube1 == false )
		then
			Engine:PlayAudio("Audio1.wav")
			cube1 = true
			Engine:LuaStringOUT("Camera1")
			CollectableCount = CollectableCount+1
			Engine:GetGameObjectWithName("Camera1"):Teleport(0,-1000,0)
		end
		if (Engine:GetGameObjectWithName("Character"):GetCollision("Camera2") and cube2 == false)
		then
			Engine:PlayAudio("Audio2.wav")
			cube2 = true
			CollectableCount = CollectableCount+1
			Engine:GetGameObjectWithName("Camera2"):Teleport(0,-1100,0)
			Engine:LuaStringOUT("Camera2")
		end
		if (CollectableCount == 2)
		then
			SendData = false
			Engine:Reload(3)
			Engine:Quit()
			return
		end
		
		
	end
	
end