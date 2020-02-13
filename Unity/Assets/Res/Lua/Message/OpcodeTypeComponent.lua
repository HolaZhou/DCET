-- Generated by CSharp.lua Compiler
local System = System
local DCETHotfix = DCET.Hotfix
local DictUInt16Object = System.Dictionary(System.UInt16, System.Object)
local DoubleMap_2UInt16Type = DCETHotfix.DoubleMap_2(System.UInt16, System.Type)
local DCETHotfix
System.import(function (out)
  DCETHotfix = DCET.Hotfix
end)
System.namespace("DCET.Hotfix", function (namespace)
  namespace.class("OpcodeTypeComponentAwakeSystem", function (namespace)
    local Awake
    Awake = function (this, self)
      DCETHotfix.OpcodeTypeComponent.Instance = self
      self:Load()
    end
    return {
      base = function (out)
        return {
          out.DCET.Hotfix.AwakeSystem_1(out.DCET.Hotfix.OpcodeTypeComponent)
        }
      end,
      Awake = Awake,
      __metadata__ = function (out)
        return {
          class = { 0x6, out.DCET.Hotfix.ObjectSystemAttribute() }
        }
      end
    }
  end)

  namespace.class("OpcodeTypeComponentLoadSystem", function (namespace)
    local Load
    Load = function (this, self)
      self:Load()
    end
    return {
      base = function (out)
        return {
          out.DCET.Hotfix.LoadSystem_1(out.DCET.Hotfix.OpcodeTypeComponent)
        }
      end,
      Load = Load,
      __metadata__ = function (out)
        return {
          class = { 0x6, out.DCET.Hotfix.ObjectSystemAttribute() }
        }
      end
    }
  end)

  namespace.class("OpcodeTypeComponentDestroySystem", function (namespace)
    local Destroy
    Destroy = function (this, self)
      DCETHotfix.OpcodeTypeComponent.Instance = nil
    end
    return {
      base = function (out)
        return {
          out.DCET.Hotfix.DestroySystem_1(out.DCET.Hotfix.OpcodeTypeComponent)
        }
      end,
      Destroy = Destroy,
      __metadata__ = function (out)
        return {
          class = { 0x6, out.DCET.Hotfix.ObjectSystemAttribute() }
        }
      end
    }
  end)

  namespace.class("OpcodeTypeComponent", function (namespace)
    local Load, GetOpcode, GetType1, GetInstance, __ctor__
    __ctor__ = function (this)
      this.opcodeTypes = DoubleMap_2UInt16Type()
      this.typeMessages = DictUInt16Object()
      DCETHotfix.Entity.__ctor__(this)
    end
    Load = function (this)
      this.opcodeTypes:Clear()
      this.typeMessages:Clear()

      local types = DCETHotfix.Game.getEventSystem():GetTypes(System.typeof(DCETHotfix.MessageAttribute))
      for _, type in System.each(types) do
        local continue
        repeat
          local attrs = type:GetCustomAttributes(System.typeof(DCETHotfix.MessageAttribute), false)
          if #attrs == 0 then
            continue = true
            break
          end

          local messageAttribute = System.as(attrs:get(0), DCETHotfix.MessageAttribute)
          if messageAttribute == nil then
            continue = true
            break
          end

          this.opcodeTypes:Add(messageAttribute.Opcode, type)
          this.typeMessages:AddKeyValue(messageAttribute.Opcode, System.Activator.CreateInstance(type))
          continue = true
        until 1
        if not continue then
          break
        end
      end
    end
    GetOpcode = function (this, type)
      return this.opcodeTypes:GetKeyByValue(type)
    end
    GetType1 = function (this, opcode)
      return this.opcodeTypes:GetValueByKey(opcode)
    end
    GetInstance = function (this, opcode)
      return this.typeMessages:get(opcode)
    end
    return {
      base = function (out)
        return {
          out.DCET.Hotfix.Entity
        }
      end,
      Load = Load,
      GetOpcode = GetOpcode,
      GetType1 = GetType1,
      GetInstance = GetInstance,
      __ctor__ = __ctor__
    }
  end)
end)