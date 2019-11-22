a = Engine.GameEngine()
a:LuaTestFunction()

function penguin(object)
   object:SetVelocity(0,100,0)
   return object.value * a;
end