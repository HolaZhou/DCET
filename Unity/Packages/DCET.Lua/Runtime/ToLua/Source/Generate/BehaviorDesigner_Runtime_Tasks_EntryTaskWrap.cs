﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class BehaviorDesigner_Runtime_Tasks_EntryTaskWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(BehaviorDesigner.Runtime.Tasks.EntryTask), typeof(BehaviorDesigner.Runtime.Tasks.ParentTask));
		L.RegFunction("MaxChildren", MaxChildren);
		L.RegFunction("New", _CreateBehaviorDesigner_Runtime_Tasks_EntryTask);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateBehaviorDesigner_Runtime_Tasks_EntryTask(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				BehaviorDesigner.Runtime.Tasks.EntryTask obj = new BehaviorDesigner.Runtime.Tasks.EntryTask();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: BehaviorDesigner.Runtime.Tasks.EntryTask.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MaxChildren(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.EntryTask obj = (BehaviorDesigner.Runtime.Tasks.EntryTask)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.EntryTask>(L, 1);
			int o = obj.MaxChildren();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
