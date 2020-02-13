﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MongoDB_Bson_IO_JsonTokenWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MongoDB.Bson.IO.JsonToken), typeof(System.Object));
		L.RegFunction("New", _CreateMongoDB_Bson_IO_JsonToken);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Type", get_Type, null);
		L.RegFunction("getType", get_Type);
		L.RegVar("Lexeme", get_Lexeme, null);
		L.RegFunction("getLexeme", get_Lexeme);
		L.RegVar("DateTimeValue", get_DateTimeValue, null);
		L.RegFunction("getDateTimeValue", get_DateTimeValue);
		L.RegVar("DoubleValue", get_DoubleValue, null);
		L.RegFunction("getDoubleValue", get_DoubleValue);
		L.RegVar("Int32Value", get_Int32Value, null);
		L.RegFunction("getInt32Value", get_Int32Value);
		L.RegVar("Int64Value", get_Int64Value, null);
		L.RegFunction("getInt64Value", get_Int64Value);
		L.RegVar("IsNumber", get_IsNumber, null);
		L.RegFunction("getIsNumber", get_IsNumber);
		L.RegVar("ObjectIdValue", get_ObjectIdValue, null);
		L.RegFunction("getObjectIdValue", get_ObjectIdValue);
		L.RegVar("RegularExpressionValue", get_RegularExpressionValue, null);
		L.RegFunction("getRegularExpressionValue", get_RegularExpressionValue);
		L.RegVar("StringValue", get_StringValue, null);
		L.RegFunction("getStringValue", get_StringValue);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateMongoDB_Bson_IO_JsonToken(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				MongoDB.Bson.IO.JsonTokenType arg0 = (MongoDB.Bson.IO.JsonTokenType)LuaDLL.luaL_checknumber(L, 1);
				string arg1 = ToLua.CheckString(L, 2);
				MongoDB.Bson.IO.JsonToken obj = new MongoDB.Bson.IO.JsonToken(arg0, arg1);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: MongoDB.Bson.IO.JsonToken.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Type(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.IO.JsonToken obj = (MongoDB.Bson.IO.JsonToken)o;
			MongoDB.Bson.IO.JsonTokenType ret = obj.Type;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Type on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Lexeme(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.IO.JsonToken obj = (MongoDB.Bson.IO.JsonToken)o;
			string ret = obj.Lexeme;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Lexeme on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DateTimeValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.IO.JsonToken obj = (MongoDB.Bson.IO.JsonToken)o;
			MongoDB.Bson.BsonDateTime ret = obj.DateTimeValue;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index DateTimeValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DoubleValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.IO.JsonToken obj = (MongoDB.Bson.IO.JsonToken)o;
			double ret = obj.DoubleValue;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index DoubleValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Int32Value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.IO.JsonToken obj = (MongoDB.Bson.IO.JsonToken)o;
			int ret = obj.Int32Value;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Int32Value on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Int64Value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.IO.JsonToken obj = (MongoDB.Bson.IO.JsonToken)o;
			long ret = obj.Int64Value;
			LuaDLL.tolua_pushint64(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Int64Value on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsNumber(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.IO.JsonToken obj = (MongoDB.Bson.IO.JsonToken)o;
			bool ret = obj.IsNumber;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsNumber on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ObjectIdValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.IO.JsonToken obj = (MongoDB.Bson.IO.JsonToken)o;
			MongoDB.Bson.ObjectId ret = obj.ObjectIdValue;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ObjectIdValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_RegularExpressionValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.IO.JsonToken obj = (MongoDB.Bson.IO.JsonToken)o;
			MongoDB.Bson.BsonRegularExpression ret = obj.RegularExpressionValue;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index RegularExpressionValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_StringValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.IO.JsonToken obj = (MongoDB.Bson.IO.JsonToken)o;
			string ret = obj.StringValue;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index StringValue on a nil value");
		}
	}
}
