﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MongoDB_Bson_BsonNullWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MongoDB.Bson.BsonNull), typeof(MongoDB.Bson.BsonValue));
		L.RegFunction("CompareTo", CompareTo);
		L.RegFunction("Equals", Equals);
		L.RegFunction("GetHashCode", GetHashCode);
		L.RegFunction("ToBoolean", ToBoolean);
		L.RegFunction("ToNullableLocalTime", ToNullableLocalTime);
		L.RegFunction("ToNullableUniversalTime", ToNullableUniversalTime);
		L.RegFunction("ToString", ToString);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Value", get_Value, null);
		L.RegFunction("getValue", get_Value);
		L.RegVar("BsonType", get_BsonType, null);
		L.RegFunction("getBsonType", get_BsonType);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.BsonNull arg0 = (MongoDB.Bson.BsonNull)ToLua.ToObject(L, 1);
			MongoDB.Bson.BsonNull arg1 = (MongoDB.Bson.BsonNull)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CompareTo(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<MongoDB.Bson.BsonNull>(L, 2))
			{
				MongoDB.Bson.BsonNull obj = (MongoDB.Bson.BsonNull)ToLua.CheckObject<MongoDB.Bson.BsonNull>(L, 1);
				MongoDB.Bson.BsonNull arg0 = (MongoDB.Bson.BsonNull)ToLua.ToObject(L, 2);
				int o = obj.CompareTo(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<MongoDB.Bson.BsonValue>(L, 2))
			{
				MongoDB.Bson.BsonNull obj = (MongoDB.Bson.BsonNull)ToLua.CheckObject<MongoDB.Bson.BsonNull>(L, 1);
				MongoDB.Bson.BsonValue arg0 = (MongoDB.Bson.BsonValue)ToLua.ToObject(L, 2);
				int o = obj.CompareTo(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: MongoDB.Bson.BsonNull.CompareTo");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Equals(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<MongoDB.Bson.BsonNull>(L, 2))
			{
				MongoDB.Bson.BsonNull obj = (MongoDB.Bson.BsonNull)ToLua.CheckObject<MongoDB.Bson.BsonNull>(L, 1);
				MongoDB.Bson.BsonNull arg0 = (MongoDB.Bson.BsonNull)ToLua.ToObject(L, 2);
				bool o = obj != null ? obj.Equals(arg0) : arg0 == null;
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<MongoDB.Bson.BsonValue>(L, 2))
			{
				MongoDB.Bson.BsonNull obj = (MongoDB.Bson.BsonNull)ToLua.CheckObject<MongoDB.Bson.BsonNull>(L, 1);
				MongoDB.Bson.BsonValue arg0 = (MongoDB.Bson.BsonValue)ToLua.ToObject(L, 2);
				bool o = obj != null ? obj.Equals(arg0) : arg0 == null;
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<object>(L, 2))
			{
				MongoDB.Bson.BsonNull obj = (MongoDB.Bson.BsonNull)ToLua.CheckObject<MongoDB.Bson.BsonNull>(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				bool o = obj != null ? obj.Equals(arg0) : arg0 == null;
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: MongoDB.Bson.BsonNull.Equals");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHashCode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			MongoDB.Bson.BsonNull obj = (MongoDB.Bson.BsonNull)ToLua.CheckObject<MongoDB.Bson.BsonNull>(L, 1);
			int o = obj.GetHashCode();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToBoolean(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			MongoDB.Bson.BsonNull obj = (MongoDB.Bson.BsonNull)ToLua.CheckObject<MongoDB.Bson.BsonNull>(L, 1);
			bool o = obj.ToBoolean();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToNullableLocalTime(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			MongoDB.Bson.BsonNull obj = (MongoDB.Bson.BsonNull)ToLua.CheckObject<MongoDB.Bson.BsonNull>(L, 1);
			System.Nullable<System.DateTime> o = obj.ToNullableLocalTime();
			ToLua.PusNullable(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToNullableUniversalTime(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			MongoDB.Bson.BsonNull obj = (MongoDB.Bson.BsonNull)ToLua.CheckObject<MongoDB.Bson.BsonNull>(L, 1);
			System.Nullable<System.DateTime> o = obj.ToNullableUniversalTime();
			ToLua.PusNullable(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			MongoDB.Bson.BsonNull obj = (MongoDB.Bson.BsonNull)ToLua.CheckObject<MongoDB.Bson.BsonNull>(L, 1);
			string o = obj.ToString();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Value(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, MongoDB.Bson.BsonNull.Value);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BsonType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.BsonNull obj = (MongoDB.Bson.BsonNull)o;
			MongoDB.Bson.BsonType ret = obj.BsonType;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index BsonType on a nil value");
		}
	}
}
