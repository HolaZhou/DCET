﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MongoDB_Bson_Serialization_Conventions_AttributeConventionPackWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MongoDB.Bson.Serialization.Conventions.AttributeConventionPack), typeof(System.Object));
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Instance", get_Instance, null);
		L.RegFunction("getInstance", get_Instance);
		L.RegVar("Conventions", get_Conventions, null);
		L.RegFunction("getConventions", get_Conventions);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, MongoDB.Bson.Serialization.Conventions.AttributeConventionPack.Instance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Conventions(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.Serialization.Conventions.AttributeConventionPack obj = (MongoDB.Bson.Serialization.Conventions.AttributeConventionPack)o;
			System.Collections.Generic.IEnumerable<MongoDB.Bson.Serialization.Conventions.IConvention> ret = obj.Conventions;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Conventions on a nil value");
		}
	}
}
