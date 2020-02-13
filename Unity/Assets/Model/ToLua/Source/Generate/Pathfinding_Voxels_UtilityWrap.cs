﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Pathfinding_Voxels_UtilityWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Pathfinding.Voxels.Utility), typeof(System.Object));
		L.RegFunction("Min", Min);
		L.RegFunction("Max", Max);
		L.RegFunction("CopyVector", CopyVector);
		L.RegFunction("RemoveDuplicateVertices", RemoveDuplicateVertices);
		L.RegFunction("New", _CreatePathfinding_Voxels_Utility);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePathfinding_Voxels_Utility(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Pathfinding.Voxels.Utility obj = new Pathfinding.Voxels.Utility();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Pathfinding.Voxels.Utility.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Min(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 1);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
				float o = Pathfinding.Voxels.Utility.Min(arg0, arg1, arg2);
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else if (count == 4)
			{
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 1);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
				float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
				float o = Pathfinding.Voxels.Utility.Min(arg0, arg1, arg2, arg3);
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Pathfinding.Voxels.Utility.Min");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Max(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 1);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
				float o = Pathfinding.Voxels.Utility.Max(arg0, arg1, arg2);
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else if (count == 4)
			{
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 1);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
				float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
				float o = Pathfinding.Voxels.Utility.Max(arg0, arg1, arg2, arg3);
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Pathfinding.Voxels.Utility.Max");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CopyVector(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			float[] arg0 = ToLua.CheckNumberArray<float>(L, 1);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Vector3 arg2 = ToLua.ToVector3(L, 3);
			Pathfinding.Voxels.Utility.CopyVector(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveDuplicateVertices(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PF.Int3[] arg0 = ToLua.CheckStructArray<PF.Int3>(L, 1);
			int[] arg1 = ToLua.CheckNumberArray<int>(L, 2);
			PF.Int3[] o = Pathfinding.Voxels.Utility.RemoveDuplicateVertices(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
