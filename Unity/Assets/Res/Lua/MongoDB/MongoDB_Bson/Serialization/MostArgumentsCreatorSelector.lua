-- Generated by CSharp.lua Compiler
--[[ Copyright 2010-present MongoDB Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
]]
local System = System
System.namespace("MongoDB.Bson.Serialization", function (namespace)
  namespace.class("MostArgumentsCreatorSelector", function (namespace)
    local SelectCreator, IsBetterMatch, Match, class
    namespace.class("MatchData", function (namespace)
      return {
        ArgumentCount = 0,
        DefaultValueCount = 0
      }
    end)
    SelectCreator = function (this, classMap, values)
      local bestMatch = nil

      for _, creatorMap in System.each(classMap:getCreatorMaps()) do
        local match = Match(this, creatorMap, values)
        if match ~= nil then
          if bestMatch == nil or IsBetterMatch(this, match, bestMatch) then
            bestMatch = match
          end
        end
      end

      local default
      if (bestMatch == nil) then
        default = nil
      else
        default = bestMatch.CreatorMap
      end
      return default
    end
    IsBetterMatch = function (this, lhs, rhs)
      if lhs.ArgumentCount < rhs.ArgumentCount then
        return false
      elseif lhs.ArgumentCount > rhs.ArgumentCount then
        return true
      elseif lhs.DefaultValueCount < rhs.DefaultValueCount then
        return false
      elseif lhs.DefaultValueCount > rhs.DefaultValueCount then
        return true
      else
        return false
      end
    end
    Match = function (this, creatorMap, values)
      local argumentCount = 0
      local defaultValueCount = 0

      -- a creator is a match if we have a value for each parameter (either a deserialized value or a default value)
      for _, elementName in System.each(creatorMap:getElementNames()) do
        if values:ContainsKey(elementName) then
          argumentCount = argumentCount + 1
        elseif creatorMap:HasDefaultValue(elementName) then
          defaultValueCount = defaultValueCount + 1
        else
          return nil
        end
      end

      local default = class.MatchData()
      default.CreatorMap = creatorMap
      default.ArgumentCount = argumentCount
      default.DefaultValueCount = defaultValueCount
      return default
    end
    class = {
      base = function (out)
        return {
          out.MongoDB.Bson.Serialization.ICreatorSelector
        }
      end,
      SelectCreator = SelectCreator
    }
    return class
  end)
end)