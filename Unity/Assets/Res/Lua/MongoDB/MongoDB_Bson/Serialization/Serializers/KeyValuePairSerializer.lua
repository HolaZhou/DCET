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
local MongoDBBson
local MongoDBBsonSerialization
local MongoDBSerializers
local MongoDBSerializerHelper
System.import(function (out)
  MongoDBBson = MongoDB.Bson
  MongoDBBsonSerialization = MongoDB.Bson.Serialization
  MongoDBSerializers = MongoDB.Bson.Serialization.Serializers
  MongoDBSerializerHelper = MongoDB.Bson.Serialization.Serializers.SerializerHelper
end)
System.namespace("MongoDB.Bson.Serialization.Serializers", function (namespace)
  -- <summary>
  -- Represents a serializer for KeyValuePairs.
  -- </summary>
  -- <typeparam name="TValue">The type of the values.</typeparam>
  namespace.class("KeyValuePairSerializer_2", function (namespace)
    namespace.class("Flags", function (namespace)
      return function (TKey, TValue)
        return {}
      end
    end)
    return function (TKey, TValue)
      local getKeySerializer, getRepresentation, getValueSerializer, Deserialize, Serialize, TryGetMemberSerializationInfo, DeserializeArrayRepresentation, DeserializeDocumentRepresentation, 
      SerializeArrayRepresentation, SerializeDocumentRepresentation, __ctor1__, __ctor2__, __ctor3__, __ctor4__, __ctor5__
      local IBsonSerializer_1TKey = MongoDB.Bson.Serialization.IBsonSerializer_1(TKey)
      local KeyValuePairTKeyTValue = System.KeyValuePair(TKey, TValue)
      local IBsonSerializer_1TValue = MongoDB.Bson.Serialization.IBsonSerializer_1(TValue)
      local LazyIBsonSerializer_1TKey = System.Lazy(IBsonSerializer_1TKey)
      local LazyIBsonSerializer_1TValue = System.Lazy(IBsonSerializer_1TValue)
      -- <summary>
      -- Initializes a new instance of the <see cref="KeyValuePairSerializer{TKey, TValue}"/> class.
      -- </summary>
      __ctor1__ = function (this)
        __ctor2__(this, 3 --[[BsonType.Document]])
      end
      -- <summary>
      -- Initializes a new instance of the <see cref="KeyValuePairSerializer{TKey, TValue}"/> class.
      -- </summary>
      __ctor2__ = function (this, representation)
        __ctor4__(this, representation, MongoDBBsonSerialization.BsonSerializer.getSerializerRegistry())
      end
      -- <summary>
      -- Initializes a new instance of the <see cref="KeyValuePairSerializer{TKey, TValue}"/> class.
      -- </summary>
      -- <param name="keySerializer">The key serializer.</param>
      -- <param name="valueSerializer">The value serializer.</param>
      __ctor3__ = function (this, representation, keySerializer, valueSerializer)
        __ctor5__(this, representation, LazyIBsonSerializer_1TKey(function ()
          return keySerializer
        end), LazyIBsonSerializer_1TValue(function ()
          return valueSerializer
        end))
        if keySerializer == nil then
          System.throw(System.ArgumentNullException("keySerializer"))
        end
        if valueSerializer == nil then
          System.throw(System.ArgumentNullException("valueSerializer"))
        end
      end
      -- <summary>
      -- Initializes a new instance of the <see cref="KeyValuePairSerializer{TKey, TValue}" /> class.
      -- </summary>
      -- <param name="serializerRegistry">The serializer registry.</param>
      __ctor4__ = function (this, representation, serializerRegistry)
        __ctor5__(this, representation, LazyIBsonSerializer_1TKey(function ()
          return serializerRegistry:GetSerializer1(TKey)
        end), LazyIBsonSerializer_1TValue(function ()
          return serializerRegistry:GetSerializer1(TValue)
        end))
        if serializerRegistry == nil then
          System.throw(System.ArgumentNullException("serializerRegistry"))
        end
      end
      __ctor5__ = function (this, representation, lazyKeySerializer, lazyValueSerializer)
        repeat
          local default = representation
          if default == 4 --[[BsonType.Array]] or default == 3 --[[BsonType.Document]] then
            break
          else
            local message = System.String.Format("{0} is not a valid representation for a KeyValuePairSerializer.", representation)
            System.throw(System.ArgumentException(message))
          end
        until 1

        this._representation = representation
        this._lazyKeySerializer = lazyKeySerializer
        this._lazyValueSerializer = lazyValueSerializer

        this._helper = MongoDBSerializers.SerializerHelper(System.Array(MongoDBSerializerHelper.Member)(MongoDBSerializerHelper.Member("k", 1 --[[Flags.Key]], false), MongoDBSerializerHelper.Member("v", 2 --[[Flags.Value]], false)))
      end
      getKeySerializer = function (this)
        return this._lazyKeySerializer:getValue()
      end
      getRepresentation = function (this)
        return this._representation
      end
      getValueSerializer = function (this)
        return this._lazyValueSerializer:getValue()
      end
      -- <summary>
      -- Deserializes a value.
      -- </summary>
      -- <param name="args">The deserialization args.</param>
      -- <returns>A deserialized value.</returns>
      Deserialize = function (this, context, args)
        local bsonReader = context:getReader()
        local bsonType = bsonReader:GetCurrentBsonType()
        repeat
          local default = bsonType
          if default == 4 --[[BsonType.Array]] then
            return DeserializeArrayRepresentation(this, context)
          elseif default == 3 --[[BsonType.Document]] then
            return DeserializeDocumentRepresentation(this, context)
          else
            System.throw(this:CreateCannotDeserializeFromBsonTypeException(bsonType))
          end
        until 1
      end
      -- <summary>
      -- Serializes a value.
      -- </summary>
      -- <param name="args">The serialization args.</param>
      -- <param name="value">The object.</param>
      Serialize = function (this, context, args, value)
        repeat
          local default = this._representation
          if default == 4 --[[BsonType.Array]] then
            SerializeArrayRepresentation(this, context, value)
            break
          elseif default == 3 --[[BsonType.Document]] then
            SerializeDocumentRepresentation(this, context, value)
            break
          else
            local message = System.String.Format("'{0}' is not a valid {1} representation.", this._representation, MongoDBBson.BsonUtils.GetFriendlyTypeName(System.typeof(KeyValuePairTKeyTValue)))
            System.throw(System.new(MongoDBBson.BsonSerializationException, 2, message))
          end
        until 1
      end
      TryGetMemberSerializationInfo = function (this, memberName, serializationInfo)
        if this._representation ~= 3 --[[BsonType.Document]] then
          serializationInfo = nil
          return false, serializationInfo
        end

        repeat
          local default = memberName
          if default == "Key" then
            serializationInfo = MongoDBBsonSerialization.BsonSerializationInfo("k", this._lazyKeySerializer:getValue(), this._lazyKeySerializer:getValue():getValueType())
            return true, serializationInfo
          elseif default == "Value" then
            serializationInfo = MongoDBBsonSerialization.BsonSerializationInfo("v", this._lazyValueSerializer:getValue(), this._lazyValueSerializer:getValue():getValueType())
            return true, serializationInfo
          end
        until 1

        serializationInfo = nil
        return false, serializationInfo
      end
      DeserializeArrayRepresentation = function (this, context)
        local bsonReader = context:getReader()
        bsonReader:ReadStartArray()
        local key = MongoDBBsonSerialization.IBsonSerializerExtensions.Deserialize1(this._lazyKeySerializer:getValue(), context, TKey)
        local value = MongoDBBsonSerialization.IBsonSerializerExtensions.Deserialize1(this._lazyValueSerializer:getValue(), context, TValue)
        bsonReader:ReadEndArray()
        return KeyValuePairTKeyTValue(key, value)
      end
      DeserializeDocumentRepresentation = function (this, context)
        local key = System.default(TKey)
        local value = System.default(TValue)
        this._helper:DeserializeMembers(context, function (elementName, flag)
          repeat
            local default = flag
            if default == 1 --[[Flags.Key]] then
              key = MongoDBBsonSerialization.IBsonSerializerExtensions.Deserialize1(this._lazyKeySerializer:getValue(), context, TKey)
              break
            elseif default == 2 --[[Flags.Value]] then
              value = MongoDBBsonSerialization.IBsonSerializerExtensions.Deserialize1(this._lazyValueSerializer:getValue(), context, TValue)
              break
            end
          until 1
        end)
        return KeyValuePairTKeyTValue(key, value)
      end
      SerializeArrayRepresentation = function (this, context, value)
        local bsonWriter = context:getWriter()
        bsonWriter:WriteStartArray()
        MongoDBBsonSerialization.IBsonSerializerExtensions.Serialize1(this._lazyKeySerializer:getValue(), context, value.Key, TKey)
        MongoDBBsonSerialization.IBsonSerializerExtensions.Serialize1(this._lazyValueSerializer:getValue(), context, value.Value, TValue)
        bsonWriter:WriteEndArray()
      end
      SerializeDocumentRepresentation = function (this, context, value)
        local bsonWriter = context:getWriter()
        bsonWriter:WriteStartDocument()
        bsonWriter:WriteName("k")
        MongoDBBsonSerialization.IBsonSerializerExtensions.Serialize1(this._lazyKeySerializer:getValue(), context, value.Key, TKey)
        bsonWriter:WriteName("v")
        MongoDBBsonSerialization.IBsonSerializerExtensions.Serialize1(this._lazyValueSerializer:getValue(), context, value.Value, TValue)
        bsonWriter:WriteEndDocument()
      end
      return {
        base = function (out)
          return {
            out.MongoDB.Bson.Serialization.Serializers.StructSerializerBase_1(System.KeyValuePair(TKey, TValue)),
            out.MongoDB.Bson.Serialization.IBsonDocumentSerializer
          }
        end,
        _representation = 0,
        getKeySerializer = getKeySerializer,
        getRepresentation = getRepresentation,
        getValueSerializer = getValueSerializer,
        Deserialize = Deserialize,
        Serialize = Serialize,
        TryGetMemberSerializationInfo = TryGetMemberSerializationInfo,
        __ctor__ = {
          __ctor1__,
          __ctor2__,
          __ctor3__,
          __ctor4__,
          __ctor5__
        }
      }
    end
  end)
end)