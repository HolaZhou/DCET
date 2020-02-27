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
local MongoDBBsonIO
System.import(function (out)
  MongoDBBson = MongoDB.Bson
  MongoDBBsonIO = MongoDB.Bson.IO
end)
System.namespace("MongoDB.Bson", function (namespace)
  -- <summary>
  -- Represents a BSON timestamp value.
  -- </summary>
  namespace.class("BsonTimestamp", function (namespace)
    local op_Inequality1, op_Equality1, getBsonType, getValue, getIncrement, getTimestamp, Create1, CompareTo, 
    CompareTo1, Equals, EqualsObj, GetHashCode, ToString, class, __ctor1__, __ctor2__
    -- <summary>
    -- Initializes a new instance of the BsonTimestamp class.
    -- </summary>
    __ctor1__ = function (this, value)
      MongoDBBson.BsonValue.__ctor__(this)
      this._value = value
    end
    -- <summary>
    -- Initializes a new instance of the BsonTimestamp class.
    -- </summary>
    -- <param name="increment">The increment.</param>
    __ctor2__ = function (this, timestamp, increment)
      MongoDBBson.BsonValue.__ctor__(this)
      this._value = System.toInt64(System.bor((System.sl(System.toUInt32(timestamp), 32)), System.toUInt32(increment)))
    end
    -- <summary>
    -- Compares two BsonTimestamp values.
    -- </summary>
    -- <param name="rhs">The other BsonTimestamp.</param>
    -- <returns>True if the two BsonTimestamp values are not equal according to ==.</returns>
    op_Inequality1 = function (lhs, rhs)
      return not (op_Equality1(lhs, rhs))
    end
    -- <summary>
    -- Compares two BsonTimestamp values.
    -- </summary>
    -- <param name="rhs">The other BsonTimestamp.</param>
    -- <returns>True if the two BsonTimestamp values are equal according to ==.</returns>
    op_Equality1 = function (lhs, rhs)
      if System.Object.ReferenceEquals(lhs) then
        return System.Object.ReferenceEquals(rhs)
      end
      return Equals(lhs, rhs)
    end
    getBsonType = function (this)
      return 17 --[[BsonType.Timestamp]]
    end
    getValue = function (this)
      return this._value
    end
    getIncrement = function (this)
      return System.toInt32(this._value)
    end
    getTimestamp = function (this)
      return System.toInt32(System.sr(this._value, 32))
    end
    -- <summary>
    -- Creates a new BsonTimestamp.
    -- </summary>
    -- <returns>A BsonTimestamp or null.</returns>
    Create1 = function (value)
      if value == nil then
        System.throw(System.ArgumentNullException("value"))
      end

      return System.cast(class, MongoDBBson.BsonTypeMapper.MapToBsonValue1(value, 17 --[[BsonType.Timestamp]]))
    end
    -- <summary>
    -- Compares this BsonTimestamp to another BsonTimestamp.
    -- </summary>
    -- <returns>A 32-bit signed integer that indicates whether this BsonTimestamp is less than, equal to, or greather than the other.</returns>
    CompareTo = function (this, other)
      if op_Equality1(other, nil) then
        return 1
      end
      return this._value:CompareTo(other._value)
    end
    -- <summary>
    -- Compares the BsonTimestamp to another BsonValue.
    -- </summary>
    -- <returns>A 32-bit signed integer that indicates whether this BsonTimestamp is less than, equal to, or greather than the other BsonValue.</returns>
    CompareTo1 = function (this, other)
      if MongoDBBson.BsonValue.op_Equality(other, nil) then
        return 1
      end
      local otherTimestamp = System.as(other, class)
      if op_Inequality1(otherTimestamp, nil) then
        return this._value:CompareTo(otherTimestamp._value)
      end
      local otherDateTime = System.as(other, MongoDBBson.BsonDateTime)
      if MongoDBBson.BsonDateTime.op_Inequality1(otherDateTime, nil) then
        local seconds = System.toInt32(System.div(otherDateTime:getMillisecondsSinceEpoch(), 1000))
        local otherTimestampValue = System.sl(seconds, 32)
        return this._value:CompareTo(otherTimestampValue)
      end
      return this:CompareTypeTo(other)
    end
    -- <summary>
    -- Compares this BsonTimestamp to another BsonTimestamp.
    -- </summary>
    -- <returns>True if the two BsonTimestamp values are equal.</returns>
    Equals = function (this, rhs)
      if System.Object.ReferenceEquals(rhs) or this:GetType() ~= rhs:GetType() then
        return false
      end
      return this._value == rhs._value
    end
    -- <summary>
    -- Compares this BsonTimestamp to another object.
    -- </summary>
    -- <returns>True if the other object is a BsonTimestamp and equal to this one.</returns>
    EqualsObj = function (this, obj)
      return Equals(this, System.as(obj, class))
      -- works even if obj is null or of a different type
    end
    -- <summary>
    -- Gets the hash code.
    -- </summary>
    GetHashCode = function (this)
      -- see Effective Java by Joshua Bloch
      local hash = 17
      hash = 37 * hash + this:getBsonType():GetHashCode()
      hash = 37 * hash + this._value:GetHashCode()
      return hash
    end
    -- <summary>
    -- Returns a string representation of the value.
    -- </summary>
    ToString = function (this)
      return MongoDBBsonIO.JsonConvert.ToString8(this._value)
    end
    class = {
      base = function (out)
        return {
          out.MongoDB.Bson.BsonValue,
          System.IComparable_1(out.MongoDB.Bson.BsonTimestamp),
          System.IEquatable_1(out.MongoDB.Bson.BsonTimestamp)
        }
      end,
      _value = 0,
      op_Inequality1 = op_Inequality1,
      op_Equality1 = op_Equality1,
      getBsonType = getBsonType,
      getValue = getValue,
      getIncrement = getIncrement,
      getTimestamp = getTimestamp,
      Create1 = Create1,
      CompareTo = CompareTo,
      CompareTo1 = CompareTo1,
      Equals = Equals,
      EqualsObj = EqualsObj,
      GetHashCode = GetHashCode,
      ToString = ToString,
      __ctor__ = {
        __ctor1__,
        __ctor2__
      },
      __metadata__ = function (out)
        return {
          fields = {
            { "_value", 0x1, System.Int64 }
          },
          properties = {
            { "BsonType", 0x206, System.Int32, getBsonType },
            { "Increment", 0x206, System.Int32, getIncrement },
            { "Timestamp", 0x206, System.Int32, getTimestamp },
            { "Value", 0x206, System.Int64, getValue }
          },
          class = { 0x6, System.SerializableAttribute() }
        }
      end
    }
    return class
  end)
end)