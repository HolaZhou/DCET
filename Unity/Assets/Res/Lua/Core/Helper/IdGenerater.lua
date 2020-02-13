-- Generated by CSharp.lua Compiler
local System = System
local DCETHotfix
System.import(function (out)
  DCETHotfix = DCET.Hotfix
end)
System.namespace("DCET.Hotfix", function (namespace)
  namespace.class("IdGenerater", function (namespace)
    local appId, setAppId, getAppId, value, sceneId, GenerateSceneId, GenerateSceneInstanceId, GenerateId, 
    GetProcessId, class
    appId = 0
    setAppId = function (value)
      appId = value
      class.Head = System.sl(value, 50 --[[IdGenerater.HeadPos]])
    end
    getAppId = function ()
      return appId
    end
    value = 0
    sceneId = 100000
    GenerateSceneId = function ()
      local default = sceneId + 1
      sceneId = default
      return default
    end
    GenerateSceneInstanceId = function (id)
      return class.Head + id
    end
    GenerateId = function ()
      local time = DCETHotfix.TimeHelper.ClientNowSeconds()

      local default = value + 1
      value = default
      return class.Head + (System.sl(time, 18)) + default
    end
    GetProcessId = function (v)
      return System.toInt32(System.sr(v, 50 --[[IdGenerater.HeadPos]]))
    end
    class = {
      Head = 0,
      setAppId = setAppId,
      getAppId = getAppId,
      HeadMask = 0x0003ffffffffffff,
      GenerateSceneId = GenerateSceneId,
      GenerateSceneInstanceId = GenerateSceneInstanceId,
      GenerateId = GenerateId,
      GetProcessId = GetProcessId
    }
    return class
  end)
end)