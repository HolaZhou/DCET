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
local DictStringBsonSerializationInfo
System.import(function (out)
  MongoDBBson = MongoDB.Bson
  MongoDBBsonSerialization = MongoDB.Bson.Serialization
  MongoDBSerializers = MongoDB.Bson.Serialization.Serializers
  DictStringBsonSerializationInfo = System.Dictionary(System.String, MongoDBBsonSerialization.BsonSerializationInfo)
end)
System.namespace("MongoDB.Bson.Serialization", function (namespace)
  -- <summary>
  -- Represents a serializer for TClass (a subclass of BsonDocumentBackedClass).
  -- </summary>
  namespace.class("BsonDocumentBackedClassSerializer_1", function (namespace)
    return function (TClass)
      local TryGetMemberSerializationInfo, DeserializeValue, RegisterMember, SerializeValue, __ctor__
      -- <summary>
      -- Initializes a new instance of the <see cref="BsonDocumentBackedClassSerializer{TClass}"/> class.
      -- </summary>
      __ctor__ = function (this)
        this._memberSerializationInfo = DictStringBsonSerializationInfo()
      end
      -- <summary>
      -- Tries to get the serialization info for a member.
      -- </summary>
      -- <param name="serializationInfo">The serialization information.</param>
      -- <returns>
      -- <c>true</c> if the serialization info exists; otherwise <c>false</c>.
      -- </returns>
      TryGetMemberSerializationInfo = function (this, memberName, serializationInfo)
        local default
        default, serializationInfo = this._memberSerializationInfo:TryGetValue(memberName)
        return default, serializationInfo
      end
      DeserializeValue = function (this, context, args)
        local backingDocument = MongoDBBsonSerialization.IBsonSerializerExtensions.Deserialize1(MongoDBSerializers.BsonDocumentSerializer.getInstance(), context, MongoDBBson.BsonDocument)
        return this:CreateInstance(backingDocument)
      end
      -- <summary>
      -- Registers a member.
      -- </summary>
      -- <param name="elementName">The element name.</param>
      -- <param name="serializer">The serializer.</param>
      RegisterMember = function (this, memberName, elementName, serializer)
        if memberName == nil then
          System.throw(System.ArgumentNullException("memberName"))
        end
        if elementName == nil then
          System.throw(System.ArgumentNullException("elementName"))
        end
        if serializer == nil then
          System.throw(System.ArgumentNullException("serializer"))
        end

        local info = MongoDBBsonSerialization.BsonSerializationInfo(elementName, serializer, serializer:getValueType())
        this._memberSerializationInfo:AddKeyValue(memberName, info)
      end
      SerializeValue = function (this, context, args, value)
        local backingDocument = (System.cast(MongoDBBsonSerialization.BsonDocumentBackedClass, value)):getBackingDocument()
        MongoDBBsonSerialization.IBsonSerializerExtensions.Serialize1(MongoDBSerializers.BsonDocumentSerializer.getInstance(), context, backingDocument, MongoDBBson.BsonDocument)
      end
      return {
        base = function (out)
          return {
            out.MongoDB.Bson.Serialization.Serializers.ClassSerializerBase_1(TClass),
            out.MongoDB.Bson.Serialization.IBsonDocumentSerializer
          }
        end,
        TryGetMemberSerializationInfo = TryGetMemberSerializationInfo,
        DeserializeValue = DeserializeValue,
        RegisterMember = RegisterMember,
        SerializeValue = SerializeValue,
        __ctor__ = __ctor__
      }
    end
  end)
end)