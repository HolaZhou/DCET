﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_PageOptionWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.PageOption), typeof(System.Object));
		L.RegFunction("Clear", Clear);
		L.RegFunction("New", _CreateFairyGUI_PageOption);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("controller", null, set_controller);
		L.RegFunction("setcontroller", set_controller);
		L.RegVar("index", get_index, set_index);
		L.RegFunction("getindex", get_index);
		L.RegFunction("setindex", set_index);
		L.RegVar("name", get_name, set_name);
		L.RegFunction("getname", get_name);
		L.RegFunction("setname", set_name);
		L.RegVar("id", get_id, set_id);
		L.RegFunction("getid", get_id);
		L.RegFunction("setid", set_id);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFairyGUI_PageOption(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FairyGUI.PageOption obj = new FairyGUI.PageOption();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FairyGUI.PageOption.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Clear(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.PageOption obj = (FairyGUI.PageOption)ToLua.CheckObject<FairyGUI.PageOption>(L, 1);
			obj.Clear();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_index(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.PageOption obj = (FairyGUI.PageOption)o;
			int ret = obj.index;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index index on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_name(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.PageOption obj = (FairyGUI.PageOption)o;
			string ret = obj.name;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index name on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_id(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.PageOption obj = (FairyGUI.PageOption)o;
			string ret = obj.id;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index id on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_controller(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.PageOption obj = (FairyGUI.PageOption)o;
			FairyGUI.Controller arg0 = (FairyGUI.Controller)ToLua.CheckObject<FairyGUI.Controller>(L, 2);
			obj.controller = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index controller on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_index(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.PageOption obj = (FairyGUI.PageOption)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.index = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index index on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_name(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.PageOption obj = (FairyGUI.PageOption)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.name = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index name on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_id(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.PageOption obj = (FairyGUI.PageOption)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.id = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index id on a nil value");
		}
	}
}
