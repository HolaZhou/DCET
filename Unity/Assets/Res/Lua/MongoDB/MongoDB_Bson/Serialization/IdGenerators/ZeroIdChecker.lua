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
System.namespace("MongoDB.Bson.Serialization.IdGenerators", function (namespace)
  -- TODO: is it worth trying to remove the dependency on IEquatable<T>?
  -- <summary>
  -- Represents an Id generator that only checks that the Id is not all zeros.
  -- </summary>
  namespace.class("ZeroIdChecker_1", function (namespace)
    return function (T)
      local GenerateId, IsEmpty
      -- <summary>
      -- Generates an Id for a document.
      -- </summary>
      -- <param name="document">The document.</param>
      -- <returns>An Id.</returns>
      GenerateId = function (this, container, document)
        System.throw(System.InvalidOperationException("Id cannot be default value (all zeros)."))
      end
      -- <summary>
      -- Tests whether an Id is empty.
      -- </summary>
      -- <returns>True if the Id is empty.</returns>
      IsEmpty = function (this, id)
        return id == nil or (System.cast(T, id)):Equals(System.default(T))
      end
      return {
        base = function (out)
          return {
            out.MongoDB.Bson.Serialization.IIdGenerator
          }
        end,
        GenerateId = GenerateId,
        IsEmpty = IsEmpty
      }
    end
  end)
end)