﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MongoDB_Bson_Serialization_Serializers_StructSerializerBase_System_GuidWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MongoDB.Bson.Serialization.Serializers.StructSerializerBase<System.Guid>), typeof(MongoDB.Bson.Serialization.Serializers.SerializerBase<System.Guid>), "StructSerializerBase_System_Guid");
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}
}
