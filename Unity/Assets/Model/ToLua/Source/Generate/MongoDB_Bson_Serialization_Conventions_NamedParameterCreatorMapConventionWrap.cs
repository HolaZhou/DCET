﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MongoDB_Bson_Serialization_Conventions_NamedParameterCreatorMapConventionWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MongoDB.Bson.Serialization.Conventions.NamedParameterCreatorMapConvention), typeof(MongoDB.Bson.Serialization.Conventions.ConventionBase));
		L.RegFunction("Apply", Apply);
		L.RegFunction("New", _CreateMongoDB_Bson_Serialization_Conventions_NamedParameterCreatorMapConvention);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateMongoDB_Bson_Serialization_Conventions_NamedParameterCreatorMapConvention(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				MongoDB.Bson.Serialization.Conventions.NamedParameterCreatorMapConvention obj = new MongoDB.Bson.Serialization.Conventions.NamedParameterCreatorMapConvention();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: MongoDB.Bson.Serialization.Conventions.NamedParameterCreatorMapConvention.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Apply(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.Serialization.Conventions.NamedParameterCreatorMapConvention obj = (MongoDB.Bson.Serialization.Conventions.NamedParameterCreatorMapConvention)ToLua.CheckObject<MongoDB.Bson.Serialization.Conventions.NamedParameterCreatorMapConvention>(L, 1);
			MongoDB.Bson.Serialization.BsonCreatorMap arg0 = (MongoDB.Bson.Serialization.BsonCreatorMap)ToLua.CheckObject<MongoDB.Bson.Serialization.BsonCreatorMap>(L, 2);
			obj.Apply(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
