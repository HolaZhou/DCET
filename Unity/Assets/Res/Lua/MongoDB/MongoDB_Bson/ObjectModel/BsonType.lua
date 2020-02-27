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
System.namespace("MongoDB.Bson", function (namespace)
  -- <summary>
  -- Represents the type of a BSON element.
  -- </summary>
  namespace.enum("BsonType", function ()
    return {
      EndOfDocument = 0,
      Double = 1,
      String = 2,
      Document = 3,
      Array = 4,
      Binary = 5,
      Undefined = 6,
      ObjectId = 7,
      Boolean = 8,
      DateTime = 9,
      Null = 10,
      RegularExpression = 11,
      JavaScript = 13,
      Symbol = 14,
      JavaScriptWithScope = 15,
      Int32 = 16,
      Timestamp = 17,
      Int64 = 18,
      Decimal128 = 19,
      MinKey = 255,
      MaxKey = 127
    }
  end)
end)