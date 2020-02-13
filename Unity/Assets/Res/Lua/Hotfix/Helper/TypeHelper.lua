-- Generated by CSharp.lua Compiler
local System = System
System.namespace("DCET.Hotfix", function (namespace)
  namespace.class("TypeHelper", function (namespace)
    local InitHotfixType, InitHotfixTypeByLua
    InitHotfixType = function ()
      InitHotfixTypeByLua()
    end
    InitHotfixTypeByLua = function ()
      for k,v in pairs(DCET.Hotfix) do
      	if v.__metadata__ and v.__metadata__.class then
      		DCET.Hotfix.Game.getHotfix():AddHotfixType(System.typeof(v))
      	end
      end
    end
    return {
      InitHotfixType = InitHotfixType
    }
  end)
end)