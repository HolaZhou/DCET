﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MongoDB_Bson_Serialization_Serializers_BsonDocumentWrapperSerializerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MongoDB.Bson.Serialization.Serializers.BsonDocumentWrapperSerializer), typeof(MongoDB.Bson.Serialization.Serializers.BsonValueSerializerBase<MongoDB.Bson.BsonDocumentWrapper>));
		L.RegFunction("Deserialize", Deserialize);
		L.RegFunction("New", _CreateMongoDB_Bson_Serialization_Serializers_BsonDocumentWrapperSerializer);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Instance", get_Instance, null);
		L.RegFunction("getInstance", get_Instance);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateMongoDB_Bson_Serialization_Serializers_BsonDocumentWrapperSerializer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				MongoDB.Bson.Serialization.Serializers.BsonDocumentWrapperSerializer obj = new MongoDB.Bson.Serialization.Serializers.BsonDocumentWrapperSerializer();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: MongoDB.Bson.Serialization.Serializers.BsonDocumentWrapperSerializer.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Deserialize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			MongoDB.Bson.Serialization.Serializers.BsonDocumentWrapperSerializer obj = (MongoDB.Bson.Serialization.Serializers.BsonDocumentWrapperSerializer)ToLua.CheckObject<MongoDB.Bson.Serialization.Serializers.BsonDocumentWrapperSerializer>(L, 1);
			MongoDB.Bson.Serialization.BsonDeserializationContext arg0 = (MongoDB.Bson.Serialization.BsonDeserializationContext)ToLua.CheckObject<MongoDB.Bson.Serialization.BsonDeserializationContext>(L, 2);
			MongoDB.Bson.Serialization.BsonDeserializationArgs arg1 = StackTraits<MongoDB.Bson.Serialization.BsonDeserializationArgs>.Check(L, 3);
			MongoDB.Bson.BsonDocumentWrapper o = obj.Deserialize(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, MongoDB.Bson.Serialization.Serializers.BsonDocumentWrapperSerializer.Instance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
