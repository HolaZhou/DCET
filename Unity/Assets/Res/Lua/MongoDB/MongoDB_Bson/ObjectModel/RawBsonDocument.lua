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
local ListIDisposable = System.List(System.IDisposable)
local MongoDBBson
local MongoDBBsonIO
local MongoDBBsonSerialization
local MongoDBSerializers
System.import(function (out)
  MongoDBBson = MongoDB.Bson
  MongoDBBsonIO = MongoDB.Bson.IO
  MongoDBBsonSerialization = MongoDB.Bson.Serialization
  MongoDBSerializers = MongoDB.Bson.Serialization.Serializers
end)
System.namespace("MongoDB.Bson", function (namespace)
  -- <summary>
  -- Represents an immutable BSON document that is represented using only the raw bytes.
  -- </summary>
  namespace.class("RawBsonDocument", function (namespace)
    local getElementCount, getElements, getNames, getRawValues, getSlice, getValues, get, set, 
    get2, get1, set1, Add, Add1, Add2, Add3, Add4, 
    Add5, Add6, Add7, Add8, Add9, Add10, AddRange, AddRange1, 
    AddRange2, AddRange3, Clear, Clone, Contains, ContainsValue, DeepClone, Dispose, 
    GetElement, GetElement1, GetEnumerator, GetValue, GetValue1, GetValue2, InsertAt, Materialize, 
    Merge, Merge1, Remove, RemoveAt, RemoveElement, Set, Set1, SetElement1, 
    SetElement, TryGetElement, TryGetValue, Dispose1, ThrowIfDisposed, CloneSlice, DeserializeRawBsonArray, DeserializeRawBsonDocument, 
    DeserializeBsonValue, class, internal, __ctor1__, __ctor2__
    internal = function (this)
      this._disposableItems = ListIDisposable()
      this._readerSettings = MongoDBBsonIO.BsonBinaryReaderSettings.getDefaults()
    end
    -- <summary>
    -- Initializes a new instance of the <see cref="RawBsonDocument"/> class.
    -- </summary>
    -- <exception cref="System.ArgumentNullException">slice</exception>
    -- <exception cref="System.ArgumentException">RawBsonDocument cannot be used with an IByteBuffer that needs disposing.</exception>
    __ctor1__ = function (this, slice)
      internal(this)
      MongoDBBson.BsonDocument.__ctor__[1](this)
      if slice == nil then
        System.throw(System.ArgumentNullException("slice"))
      end

      this._slice = slice
    end
    -- <summary>
    -- Initializes a new instance of the <see cref="RawBsonDocument"/> class.
    -- </summary>
    __ctor2__ = function (this, bytes)
      __ctor1__(this, MongoDBBsonIO.ByteArrayBuffer(bytes, true))
    end
    getElementCount = function (this)
      ThrowIfDisposed(this)
      local default, extern = System.using(MongoDBBsonIO.ByteBufferStream(this._slice, false), function (stream)
        local default, extern = System.using(System.new(MongoDBBsonIO.BsonBinaryReader, 2, stream, this._readerSettings), function (bsonReader)
          local elementCount = 0

          bsonReader:ReadStartDocument()
          while bsonReader:ReadBsonType() ~= 0 --[[BsonType.EndOfDocument]] do
            bsonReader:SkipName()
            bsonReader:SkipValue()
            elementCount = elementCount + 1
          end
          bsonReader:ReadEndDocument()

          return true, elementCount
        end)
        if default then
          return true, extern
        end
      end)
      if default then
        return extern
      end
    end
    getElements = function (this)
      return System.yieldIEnumerable(function (this)
        ThrowIfDisposed(this)
        System.using(MongoDBBsonIO.ByteBufferStream(this._slice, false), function (stream)
          System.using(System.new(MongoDBBsonIO.BsonBinaryReader, 2, stream, this._readerSettings), function (bsonReader)
            local context = MongoDBBsonSerialization.BsonDeserializationContext.CreateRoot(bsonReader)

            bsonReader:ReadStartDocument()
            while bsonReader:ReadBsonType() ~= 0 --[[BsonType.EndOfDocument]] do
              local name = bsonReader:ReadName1()
              local value = DeserializeBsonValue(this, context)
              System.yield(System.new(MongoDBBson.BsonElement, 2, name, value))
            end
            bsonReader:ReadEndDocument()
          end)
        end)
      end, MongoDBBson.BsonElement, this)
    end
    getNames = function (this)
      return System.yieldIEnumerable(function (this)
        ThrowIfDisposed(this)
        System.using(MongoDBBsonIO.ByteBufferStream(this._slice, false), function (stream)
          System.using(System.new(MongoDBBsonIO.BsonBinaryReader, 2, stream, this._readerSettings), function (bsonReader)
            bsonReader:ReadStartDocument()
            while bsonReader:ReadBsonType() ~= 0 --[[BsonType.EndOfDocument]] do
              System.yield(bsonReader:ReadName1())
              bsonReader:SkipValue()
            end
            bsonReader:ReadEndDocument()
          end)
        end)
      end, System.String, this)
    end
    getRawValues = function (this)
      return System.yieldIEnumerable(function (this)
        ThrowIfDisposed(this)
        System.using(MongoDBBsonIO.ByteBufferStream(this._slice, false), function (stream)
          System.using(System.new(MongoDBBsonIO.BsonBinaryReader, 2, stream, this._readerSettings), function (bsonReader)
            local context = MongoDBBsonSerialization.BsonDeserializationContext.CreateRoot(bsonReader)

            bsonReader:ReadStartDocument()
            while bsonReader:ReadBsonType() ~= 0 --[[BsonType.EndOfDocument]] do
              bsonReader:SkipName()
              System.yield(DeserializeBsonValue(this, context):getRawValue())
            end
            bsonReader:ReadEndDocument()
          end)
        end)
      end, System.Object, this)
    end
    getSlice = function (this)
      ThrowIfDisposed(this)
      return this._slice
    end
    getValues = function (this)
      return System.yieldIEnumerable(function (this)
        ThrowIfDisposed(this)
        System.using(MongoDBBsonIO.ByteBufferStream(this._slice, false), function (stream)
          System.using(System.new(MongoDBBsonIO.BsonBinaryReader, 2, stream, this._readerSettings), function (bsonReader)
            local context = MongoDBBsonSerialization.BsonDeserializationContext.CreateRoot(bsonReader)

            bsonReader:ReadStartDocument()
            while bsonReader:ReadBsonType() ~= 0 --[[BsonType.EndOfDocument]] do
              bsonReader:SkipName()
              System.yield(DeserializeBsonValue(this, context))
            end
            bsonReader:ReadEndDocument()
          end)
        end)
      end, MongoDBBson.BsonValue, this)
    end
    get = function (this, index)
      return this:GetValue(index)
    end
    set = function (this, index, value)
      this:Set(index, value)
    end
    get2 = function (this, name, defaultValue)
      return this:GetValue2(name, defaultValue)
    end
    get1 = function (this, name)
      return this:GetValue1(name)
    end
    set1 = function (this, name, value)
      this:Set1(name, value)
    end
    -- <summary>
    -- Adds an element to the document.
    -- </summary>
    -- <returns>
    -- The document (so method calls can be chained).
    -- </returns>
    Add = function (this, element)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Adds elements to the document from a dictionary of key/value pairs.
    -- </summary>
    -- <returns>The document (so method calls can be chained).</returns>
    Add1 = function (this, dictionary)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Adds elements to the document from a dictionary of key/value pairs.
    -- </summary>
    -- <param name="keys">Which keys of the hash table to add.</param>
    -- <returns>The document (so method calls can be chained).</returns>
    Add2 = function (this, dictionary, keys)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Adds elements to the document from a dictionary of key/value pairs.
    -- </summary>
    -- <returns>The document (so method calls can be chained).</returns>
    Add3 = function (this, dictionary)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Adds elements to the document from a dictionary of key/value pairs.
    -- </summary>
    -- <param name="keys">Which keys of the hash table to add.</param>
    -- <returns>The document (so method calls can be chained).</returns>
    Add4 = function (this, dictionary, keys)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Adds elements to the document from a dictionary of key/value pairs.
    -- </summary>
    -- <returns>The document (so method calls can be chained).</returns>
    Add5 = function (this, dictionary)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Adds elements to the document from a dictionary of key/value pairs.
    -- </summary>
    -- <param name="keys">Which keys of the hash table to add.</param>
    -- <returns>The document (so method calls can be chained).</returns>
    Add6 = function (this, dictionary, keys)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Adds a list of elements to the document.
    -- </summary>
    -- <returns>The document (so method calls can be chained).</returns>
    Add7 = function (this, elements)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Adds a list of elements to the document.
    -- </summary>
    -- <returns>The document (so method calls can be chained).</returns>
    Add8 = function (this, elements)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Creates and adds an element to the document.
    -- </summary>
    -- <param name="value">The value of the element.</param>
    -- <returns>
    -- The document (so method calls can be chained).
    -- </returns>
    Add9 = function (this, name, value)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Creates and adds an element to the document, but only if the condition is true.
    -- </summary>
    -- <param name="value">The value of the element.</param>
    -- <param name="condition">Whether to add the element to the document.</param>
    -- <returns>The document (so method calls can be chained).</returns>
    Add10 = function (this, name, value, condition)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Adds elements to the document from a dictionary of key/value pairs.
    -- </summary>
    -- <returns>
    -- The document (so method calls can be chained).
    -- </returns>
    AddRange = function (this, dictionary)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Adds elements to the document from a dictionary of key/value pairs.
    -- </summary>
    -- <returns>
    -- The document (so method calls can be chained).
    -- </returns>
    AddRange1 = function (this, dictionary)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Adds a list of elements to the document.
    -- </summary>
    -- <returns>
    -- The document (so method calls can be chained).
    -- </returns>
    AddRange2 = function (this, elements)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Adds elements to the document from a dictionary of key/value pairs.
    -- </summary>
    -- <returns>
    -- The document (so method calls can be chained).
    -- </returns>
    AddRange3 = function (this, dictionary)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Clears the document (removes all elements).
    -- </summary>
    Clear = function (this)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Creates a shallow clone of the document (see also DeepClone).
    -- </summary>
    -- A shallow clone of the document.
    -- </returns>
    Clone = function (this)
      ThrowIfDisposed(this)
      return class(CloneSlice(this))
    end
    -- <summary>
    -- Tests whether the document contains an element with the specified name.
    -- </summary>
    -- <returns>
    -- True if the document contains an element with the specified name.
    -- </returns>
    Contains = function (this, name)
      if name == nil then
        System.throw(System.ArgumentNullException("name"))
      end
      ThrowIfDisposed(this)

      local default, extern = System.using(MongoDBBsonIO.ByteBufferStream(this._slice, false), function (stream)
        local default, extern = System.using(System.new(MongoDBBsonIO.BsonBinaryReader, 2, stream, this._readerSettings), function (bsonReader)
          bsonReader:ReadStartDocument()
          while bsonReader:ReadBsonType() ~= 0 --[[BsonType.EndOfDocument]] do
            if bsonReader:ReadName1() == name then
              return true, true
            end
            bsonReader:SkipValue()
          end
          bsonReader:ReadEndDocument()

          return true, false
        end)
        if default then
          return true, extern
        end
      end)
      if default then
        return extern
      end
    end
    -- <summary>
    -- Tests whether the document contains an element with the specified value.
    -- </summary>
    -- <returns>
    -- True if the document contains an element with the specified value.
    -- </returns>
    ContainsValue = function (this, value)
      ThrowIfDisposed(this)
      local default, extern = System.using(MongoDBBsonIO.ByteBufferStream(this._slice, false), function (stream)
        local default, extern = System.using(System.new(MongoDBBsonIO.BsonBinaryReader, 2, stream, this._readerSettings), function (bsonReader)
          local context = MongoDBBsonSerialization.BsonDeserializationContext.CreateRoot(bsonReader)

          bsonReader:ReadStartDocument()
          while bsonReader:ReadBsonType() ~= 0 --[[BsonType.EndOfDocument]] do
            bsonReader:SkipName()
            if DeserializeBsonValue(this, context):Equals1(value) then
              return true, true
            end
          end
          bsonReader:ReadEndDocument()

          return true, false
        end)
        if default then
          return true, extern
        end
      end)
      if default then
        return extern
      end
    end
    -- <summary>
    -- Creates a deep clone of the document (see also Clone).
    -- </summary>
    -- A deep clone of the document.
    -- </returns>
    DeepClone = function (this)
      ThrowIfDisposed(this)
      return class(CloneSlice(this))
    end
    -- <summary>
    -- Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
    -- </summary>
    Dispose = function (this)
      this:Dispose1(true)
      System.GC.SuppressFinalize(this)
    end
    -- <summary>
    -- Gets an element of this document.
    -- </summary>
    -- <returns>
    -- The element.
    -- </returns>
    GetElement = function (this, index)
      if index < 0 then
        System.throw(System.ArgumentOutOfRangeException("index"))
      end
      ThrowIfDisposed(this)

      local default, extern = System.using(MongoDBBsonIO.ByteBufferStream(this._slice, false), function (stream)
        local default, extern = System.using(System.new(MongoDBBsonIO.BsonBinaryReader, 2, stream, this._readerSettings), function (bsonReader)
          local context = MongoDBBsonSerialization.BsonDeserializationContext.CreateRoot(bsonReader)

          bsonReader:ReadStartDocument()
          local i = 0
          while bsonReader:ReadBsonType() ~= 0 --[[BsonType.EndOfDocument]] do
            if i == index then
              local name = bsonReader:ReadName1()
              local value = DeserializeBsonValue(this, context)
              return true, System.new(MongoDBBson.BsonElement, 2, name, value)
            end

            bsonReader:SkipName()
            bsonReader:SkipValue()
            i = i + 1
          end
          bsonReader:ReadEndDocument()

          System.throw(System.ArgumentOutOfRangeException("index"))
        end)
        if default then
          return true, extern
        end
      end)
      if default then
        return extern
      end
    end
    -- <summary>
    -- Gets an element of this document.
    -- </summary>
    -- <returns>
    -- A BsonElement.
    -- </returns>
    GetElement1 = function (this, name)
      ThrowIfDisposed(this)
      local element
      local default
      default, element = this:TryGetElement(name)
      if default then
        return element:__clone__()
      end

      local message = System.String.Format("Element '{0}' not found.", name)
      System.throw(System.KeyNotFoundException(message))
    end
    -- <summary>
    -- Gets an enumerator that can be used to enumerate the elements of this document.
    -- </summary>
    -- An enumerator.
    -- </returns>
    GetEnumerator = function (this)
      return System.yieldIEnumerator(function (this)
        ThrowIfDisposed(this)
        System.using(MongoDBBsonIO.ByteBufferStream(this._slice, false), function (stream)
          System.using(System.new(MongoDBBsonIO.BsonBinaryReader, 2, stream, this._readerSettings), function (bsonReader)
            local context = MongoDBBsonSerialization.BsonDeserializationContext.CreateRoot(bsonReader)

            bsonReader:ReadStartDocument()
            while bsonReader:ReadBsonType() ~= 0 --[[BsonType.EndOfDocument]] do
              local name = bsonReader:ReadName1()
              local value = DeserializeBsonValue(this, context)
              System.yield(System.new(MongoDBBson.BsonElement, 2, name, value))
            end
            bsonReader:ReadEndDocument()
          end)
        end)
      end, MongoDBBson.BsonElement, this)
    end
    -- <summary>
    -- Gets the value of an element.
    -- </summary>
    -- <returns>
    -- The value of the element.
    -- </returns>
    GetValue = function (this, index)
      if index < 0 then
        System.throw(System.ArgumentOutOfRangeException("index"))
      end
      ThrowIfDisposed(this)

      local default, extern = System.using(MongoDBBsonIO.ByteBufferStream(this._slice, false), function (stream)
        local default, extern = System.using(System.new(MongoDBBsonIO.BsonBinaryReader, 2, stream, this._readerSettings), function (bsonReader)
          local context = MongoDBBsonSerialization.BsonDeserializationContext.CreateRoot(bsonReader)

          bsonReader:ReadStartDocument()
          local i = 0
          while bsonReader:ReadBsonType() ~= 0 --[[BsonType.EndOfDocument]] do
            bsonReader:SkipName()
            if i == index then
              return true, DeserializeBsonValue(this, context)
            end

            bsonReader:SkipValue()
            i = i + 1
          end
          bsonReader:ReadEndDocument()

          System.throw(System.ArgumentOutOfRangeException("index"))
        end)
        if default then
          return true, extern
        end
      end)
      if default then
        return extern
      end
    end
    -- <summary>
    -- Gets the value of an element.
    -- </summary>
    -- <returns>
    -- The value of the element.
    -- </returns>
    GetValue1 = function (this, name)
      ThrowIfDisposed(this)
      local value
      local default
      default, value = this:TryGetValue(name)
      if default then
        return value
      end

      local message = System.String.Format("Element '{0}' not found.", name)
      System.throw(System.KeyNotFoundException(message))
    end
    -- <summary>
    -- Gets the value of an element or a default value if the element is not found.
    -- </summary>
    -- <param name="defaultValue">The default value returned if the element is not found.</param>
    -- <returns>
    -- The value of the element or the default value if the element is not found.
    -- </returns>
    GetValue2 = function (this, name, defaultValue)
      ThrowIfDisposed(this)
      local value
      local default
      default, value = this:TryGetValue(name)
      if default then
        return value
      end

      return defaultValue
    end
    -- <summary>
    -- Inserts a new element at a specified position.
    -- </summary>
    -- <param name="element">The element.</param>
    InsertAt = function (this, index, element)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Materializes the RawBsonDocument into a regular BsonDocument.
    -- </summary>
    -- <returns>A BsonDocument.</returns>
    Materialize = function (this, binaryReaderSettings)
      ThrowIfDisposed(this)
      local default, extern = System.using(MongoDBBsonIO.ByteBufferStream(this._slice, false), function (stream)
        local default, extern = System.using(System.new(MongoDBBsonIO.BsonBinaryReader, 2, stream, binaryReaderSettings), function (reader)
          local context = MongoDBBsonSerialization.BsonDeserializationContext.CreateRoot(reader)
          return true, MongoDBBsonSerialization.IBsonSerializerExtensions.Deserialize1(MongoDBSerializers.BsonDocumentSerializer.getInstance(), context, MongoDBBson.BsonDocument)
        end)
        if default then
          return true, extern
        end
      end)
      if default then
        return extern
      end
    end
    -- <summary>
    -- Merges another document into this one. Existing elements are not overwritten.
    -- </summary>
    -- <returns>
    -- The document (so method calls can be chained).
    -- </returns>
    Merge = function (this, document)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Merges another document into this one, specifying whether existing elements are overwritten.
    -- </summary>
    -- <param name="overwriteExistingElements">Whether to overwrite existing elements.</param>
    -- <returns>
    -- The document (so method calls can be chained).
    -- </returns>
    Merge1 = function (this, document, overwriteExistingElements)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Removes an element from this document (if duplicate element names are allowed
    -- then all elements with this name will be removed).
    -- </summary>
    Remove = function (this, name)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Removes an element from this document.
    -- </summary>
    RemoveAt = function (this, index)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Removes an element from this document.
    -- </summary>
    RemoveElement = function (this, element)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Sets the value of an element.
    -- </summary>
    -- <param name="value">The new value.</param>
    -- <returns>
    -- The document (so method calls can be chained).
    -- </returns>
    Set = function (this, index, value)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Sets the value of an element (an element will be added if no element with this name is found).
    -- </summary>
    -- <param name="value">The new value.</param>
    -- <returns>
    -- The document (so method calls can be chained).
    -- </returns>
    Set1 = function (this, name, value)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Sets an element of the document (replaces any existing element with the same name or adds a new element if an element with the same name is not found).
    -- </summary>
    -- <returns>
    -- The document.
    -- </returns>
    SetElement1 = function (this, element)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Sets an element of the document (replacing the existing element at that position).
    -- </summary>
    -- <param name="element">The new element.</param>
    -- <returns>
    -- The document.
    -- </returns>
    SetElement = function (this, index, element)
      System.throw(System.NotSupportedException("RawBsonDocument instances are immutable."))
    end
    -- <summary>
    -- Tries to get an element of this document.
    -- </summary>
    -- <param name="element">The element.</param>
    -- <returns>
    -- True if an element with that name was found.
    -- </returns>
    TryGetElement = function (this, name, element)
      ThrowIfDisposed(this)
      local default, extern = System.using(MongoDBBsonIO.ByteBufferStream(this._slice, false), function (stream)
        local default, extern = System.using(System.new(MongoDBBsonIO.BsonBinaryReader, 2, stream, this._readerSettings), function (bsonReader)
          local context = MongoDBBsonSerialization.BsonDeserializationContext.CreateRoot(bsonReader)

          bsonReader:ReadStartDocument()
          while bsonReader:ReadBsonType() ~= 0 --[[BsonType.EndOfDocument]] do
            if bsonReader:ReadName1() == name then
              local value = DeserializeBsonValue(this, context)
              element = System.new(MongoDBBson.BsonElement, 2, name, value)
              return true, true
            end

            bsonReader:SkipValue()
          end
          bsonReader:ReadEndDocument()

          element = System.default(MongoDBBson.BsonElement)
          return true, false
        end)
        if default then
          return true, extern
        end
      end)
      if default then
        return extern, element
      end
    end
    -- <summary>
    -- Tries to get the value of an element of this document.
    -- </summary>
    -- <param name="value">The value of the element.</param>
    -- <returns>
    -- True if an element with that name was found.
    -- </returns>
    TryGetValue = function (this, name, value)
      ThrowIfDisposed(this)
      local default, extern = System.using(MongoDBBsonIO.ByteBufferStream(this._slice, false), function (stream)
        local default, extern = System.using(System.new(MongoDBBsonIO.BsonBinaryReader, 2, stream, this._readerSettings), function (bsonReader)
          local context = MongoDBBsonSerialization.BsonDeserializationContext.CreateRoot(bsonReader)

          bsonReader:ReadStartDocument()
          while bsonReader:ReadBsonType() ~= 0 --[[BsonType.EndOfDocument]] do
            if bsonReader:ReadName1() == name then
              value = DeserializeBsonValue(this, context)
              return true, true
            end

            bsonReader:SkipValue()
          end
          bsonReader:ReadEndDocument()

          value = nil
          return true, false
        end)
        if default then
          return true, extern
        end
      end)
      if default then
        return extern, value
      end
    end
    -- <summary>
    -- Releases unmanaged and - optionally - managed resources.
    -- </summary>
    Dispose1 = function (this, disposing)
      if not this._disposed then
        if disposing then
          if this._slice ~= nil then
            this._slice:Dispose()
            this._slice = nil
          end
          if this._disposableItems ~= nil then
            this._disposableItems:ForEach(function (x)
              x:Dispose()
            end)
            this._disposableItems = nil
          end
        end
        this._disposed = true
      end
    end
    -- <summary>
    -- Throws if disposed.
    -- </summary>
    ThrowIfDisposed = function (this)
      if this._disposed then
        System.throw(System.ObjectDisposedException("RawBsonDocument"))
      end
    end
    CloneSlice = function (this)
      return this._slice:GetSlice(0, this._slice:getLength())
    end
    DeserializeRawBsonArray = function (this, bsonReader)
      local slice = bsonReader:ReadRawBsonArray()
      local nestedArray = MongoDBBson.RawBsonArray(slice)
      this._disposableItems:Add(nestedArray)
      return nestedArray
    end
    DeserializeRawBsonDocument = function (this, bsonReader)
      local slice = bsonReader:ReadRawBsonDocument()
      local nestedDocument = class(slice)
      this._disposableItems:Add(nestedDocument)
      return nestedDocument
    end
    DeserializeBsonValue = function (this, context)
      local bsonReader = context:getReader()
      repeat
        local default = bsonReader:GetCurrentBsonType()
        if default == 4 --[[BsonType.Array]] then
          return DeserializeRawBsonArray(this, bsonReader)
        elseif default == 3 --[[BsonType.Document]] then
          return DeserializeRawBsonDocument(this, bsonReader)
        else
          return MongoDBBsonSerialization.IBsonSerializerExtensions.Deserialize1(MongoDBSerializers.BsonValueSerializer.getInstance(), context, MongoDBBson.BsonValue)
        end
      until 1
    end
    class = {
      base = function (out)
        return {
          out.MongoDB.Bson.BsonDocument,
          System.IDisposable
        }
      end,
      _disposed = false,
      getElementCount = getElementCount,
      getElements = getElements,
      getNames = getNames,
      getRawValues = getRawValues,
      getSlice = getSlice,
      getValues = getValues,
      get = get,
      set = set,
      get2 = get2,
      get1 = get1,
      set1 = set1,
      Add = Add,
      Add1 = Add1,
      Add2 = Add2,
      Add3 = Add3,
      Add4 = Add4,
      Add5 = Add5,
      Add6 = Add6,
      Add7 = Add7,
      Add8 = Add8,
      Add9 = Add9,
      Add10 = Add10,
      AddRange = AddRange,
      AddRange1 = AddRange1,
      AddRange2 = AddRange2,
      AddRange3 = AddRange3,
      Clear = Clear,
      Clone = Clone,
      Contains = Contains,
      ContainsValue = ContainsValue,
      DeepClone = DeepClone,
      Dispose = Dispose,
      GetElement = GetElement,
      GetElement1 = GetElement1,
      GetEnumerator = GetEnumerator,
      GetValue = GetValue,
      GetValue1 = GetValue1,
      GetValue2 = GetValue2,
      InsertAt = InsertAt,
      Materialize = Materialize,
      Merge = Merge,
      Merge1 = Merge1,
      Remove = Remove,
      RemoveAt = RemoveAt,
      RemoveElement = RemoveElement,
      Set = Set,
      Set1 = Set1,
      SetElement1 = SetElement1,
      SetElement = SetElement,
      TryGetElement = TryGetElement,
      TryGetValue = TryGetValue,
      Dispose1 = Dispose1,
      ThrowIfDisposed = ThrowIfDisposed,
      __ctor__ = {
        __ctor1__,
        __ctor2__
      },
      __metadata__ = function (out)
        return {
          properties = {
            { "RawValues", 0x206, System.IEnumerable_1(System.Object), getRawValues, System.ObsoleteAttribute("Use Values instead.") }
          },
          methods = {
            { "Add", 0x186, Add1, System.Dictionary(System.String, System.Object), out.MongoDB.Bson.BsonDocument, System.ObsoleteAttribute("Use AddRange instead.") },
            { "Add", 0x286, Add2, System.Dictionary(System.String, System.Object), System.IEnumerable_1(System.String), out.MongoDB.Bson.BsonDocument, System.ObsoleteAttribute("Use AddRange(IEnumerable<BsonElement> elements) instead.") },
            { "Add", 0x186, Add3, System.IDictionary_2(System.String, System.Object), out.MongoDB.Bson.BsonDocument, System.ObsoleteAttribute("Use AddRange instead.") },
            { "Add", 0x286, Add4, System.IDictionary_2(System.String, System.Object), System.IEnumerable_1(System.String), out.MongoDB.Bson.BsonDocument, System.ObsoleteAttribute("Use AddRange(IEnumerable<BsonElement> elements) instead.") },
            { "Add", 0x186, Add5, System.IDictionary, out.MongoDB.Bson.BsonDocument, System.ObsoleteAttribute("Use AddRange instead.") },
            { "Add", 0x286, Add6, System.IDictionary, System.IEnumerable, out.MongoDB.Bson.BsonDocument, System.ObsoleteAttribute("Use AddRange(IEnumerable<BsonElement> elements) instead.") },
            { "Add", 0x186, Add7, System.IEnumerable_1(out.MongoDB.Bson.BsonElement), out.MongoDB.Bson.BsonDocument, System.ObsoleteAttribute("Use AddRange instead.") },
            { "Add", 0x186, Add8, System.Array(out.MongoDB.Bson.BsonElement), out.MongoDB.Bson.BsonDocument, System.ObsoleteAttribute("Use AddRange(IEnumerable<BsonElement> elements) instead.") }
          },
          class = { 0x6, System.new(out.MongoDB.Bson.Serialization.Attributes.BsonSerializerAttribute, 2, System.typeof(MongoDBSerializers.RawBsonDocumentSerializer)) }
        }
      end
    }
    return class
  end)
end)