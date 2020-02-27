-- Generated by CSharp.lua Compiler
--[[ Copyright 2016-present MongoDB Inc.
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
local MongoDBBson
local MongoDBSerializers
local BsonValueSerializerBase_1BsonDecimal128
System.import(function (out)
  MongoDBBson = MongoDB.Bson
  MongoDBSerializers = MongoDB.Bson.Serialization.Serializers
  BsonValueSerializerBase_1BsonDecimal128 = MongoDBSerializers.BsonValueSerializerBase_1(MongoDBBson.BsonDecimal128)
end)
System.namespace("MongoDB.Bson.Serialization.Serializers", function (namespace)
  -- <summary>
  -- Represents a serializer for BsonDecimal128s.
  -- </summary>
  namespace.class("BsonDecimal128Serializer", function (namespace)
    local __instance, getInstance, DeserializeValue, SerializeValue, class, static, __ctor__
    static = function (this)
      __instance = class()
    end
    -- <summary>
    -- Initializes a new instance of the BsonBooleanSerializer class.
    -- </summary>
    __ctor__ = function (this)
      BsonValueSerializerBase_1BsonDecimal128.__ctor__(this, 19 --[[BsonType.Decimal128]])
    end
    getInstance = function ()
      return __instance
    end
    -- <summary>
    -- Deserializes a value.
    -- </summary>
    -- <param name="args">The deserialization args.</param>
    -- <returns>A deserialized value.</returns>
    DeserializeValue = function (this, context, args)
      local bsonReader = context:getReader()
      return MongoDBBson.BsonDecimal128.op_Implicit22(bsonReader:ReadDecimal128())
    end
    -- <summary>
    -- Serializes a value.
    -- </summary>
    -- <param name="args">The serialization args.</param>
    -- <param name="value">The object.</param>
    SerializeValue = function (this, context, args, value)
      local bsonWriter = context:getWriter()
      bsonWriter:WriteDecimal128(value:getValue())
    end
    class = {
      base = function (out)
        return {
          out.MongoDB.Bson.Serialization.Serializers.BsonValueSerializerBase_1(out.MongoDB.Bson.BsonDecimal128)
        }
      end,
      getInstance = getInstance,
      DeserializeValue = DeserializeValue,
      SerializeValue = SerializeValue,
      static = static,
      __ctor__ = __ctor__
    }
    return class
  end)
end)