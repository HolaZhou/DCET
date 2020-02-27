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
local MongoDBConventions
System.import(function (out)
  MongoDBConventions = MongoDB.Bson.Serialization.Conventions
end)
System.namespace("MongoDB.Bson.Serialization.Conventions", function (namespace)
  -- <summary>
  -- A convention that sets whether to ignore nulls during serialization.
  -- </summary>
  namespace.class("IgnoreIfNullConvention", function (namespace)
    local Apply2, __ctor__
    -- <summary>
    -- Initializes a new instance of the <see cref="IgnoreIfNullConvention" /> class.
    -- </summary>
    __ctor__ = function (this, ignoreIfNull)
      MongoDBConventions.ConventionBase.__ctor__[1](this)
      this._ignoreIfNull = ignoreIfNull
    end
    -- <summary>
    -- Applies a modification to the member map.
    -- </summary>
    Apply2 = function (this, memberMap)
      memberMap:SetIgnoreIfNull(this._ignoreIfNull)
    end
    return {
      base = function (out)
        return {
          out.MongoDB.Bson.Serialization.Conventions.ConventionBase,
          out.MongoDB.Bson.Serialization.Conventions.IMemberMapConvention
        }
      end,
      _ignoreIfNull = false,
      Apply2 = Apply2,
      __ctor__ = __ctor__
    }
  end)
end)