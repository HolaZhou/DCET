-- Generated by CSharp.lua Compiler
local System = System
local DCETHotfix
System.import(function (out)
  DCETHotfix = DCET.Hotfix
end)
System.namespace("DCET.Hotfix", function (namespace)
  namespace.class("NetOuterComponentAwakeSystem", function (namespace)
    local Awake
    Awake = function (this, self)
      self:Awake(self.Protocol, 4)
      self.MessagePacker = DCETHotfix.ProtobufPacker()
      self.MessageDispatcher = DCETHotfix.OuterMessageDispatcher()
    end
    return {
      base = function (out)
        return {
          out.DCET.Hotfix.AwakeSystem_1(out.DCET.Hotfix.NetOuterComponent)
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

  namespace.class("NetOuterComponentAwake1System", function (namespace)
    local Awake
    Awake = function (this, self, address)
      self:Awake1(self.Protocol, address, 4)
      self.MessagePacker = DCETHotfix.ProtobufPacker()
      self.MessageDispatcher = DCETHotfix.OuterMessageDispatcher()
    end
    return {
      base = function (out)
        return {
          out.DCET.Hotfix.AwakeSystem_2(out.DCET.Hotfix.NetOuterComponent, System.String)
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

  namespace.class("NetOuterComponentLoadSystem", function (namespace)
    local Load
    Load = function (this, self)
      self.MessagePacker = DCETHotfix.ProtobufPacker()
      self.MessageDispatcher = DCETHotfix.OuterMessageDispatcher()
    end
    return {
      base = function (out)
        return {
          out.DCET.Hotfix.LoadSystem_1(out.DCET.Hotfix.NetOuterComponent)
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

  namespace.class("NetOuterComponentUpdateSystem", function (namespace)
    local Update
    Update = function (this, self)
      self:Update()
    end
    return {
      base = function (out)
        return {
          out.DCET.Hotfix.UpdateSystem_1(out.DCET.Hotfix.NetOuterComponent)
        }
      end,
      Update = Update,
      __metadata__ = function (out)
        return {
          class = { 0x6, out.DCET.Hotfix.ObjectSystemAttribute() }
        }
      end
    }
  end)
end)