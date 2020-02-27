﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_UIConfig_ConfigValueWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.UIConfig.ConfigValue), typeof(System.Object));
		L.RegFunction("Reset", Reset);
		L.RegFunction("New", _CreateFairyGUI_UIConfig_ConfigValue);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("valid", get_valid, set_valid);
		L.RegVar("s", get_s, set_s);
		L.RegVar("i", get_i, set_i);
		L.RegVar("f", get_f, set_f);
		L.RegVar("b", get_b, set_b);
		L.RegVar("c", get_c, set_c);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFairyGUI_UIConfig_ConfigValue(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FairyGUI.UIConfig.ConfigValue obj = new FairyGUI.UIConfig.ConfigValue();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FairyGUI.UIConfig.ConfigValue.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Reset(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.UIConfig.ConfigValue obj = (FairyGUI.UIConfig.ConfigValue)ToLua.CheckObject<FairyGUI.UIConfig.ConfigValue>(L, 1);
			obj.Reset();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_valid(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.UIConfig.ConfigValue obj = (FairyGUI.UIConfig.ConfigValue)o;
			bool ret = obj.valid;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index valid on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_s(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.UIConfig.ConfigValue obj = (FairyGUI.UIConfig.ConfigValue)o;
			string ret = obj.s;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index s on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_i(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.UIConfig.ConfigValue obj = (FairyGUI.UIConfig.ConfigValue)o;
			int ret = obj.i;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index i on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_f(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.UIConfig.ConfigValue obj = (FairyGUI.UIConfig.ConfigValue)o;
			float ret = obj.f;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index f on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_b(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.UIConfig.ConfigValue obj = (FairyGUI.UIConfig.ConfigValue)o;
			bool ret = obj.b;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index b on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_c(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.UIConfig.ConfigValue obj = (FairyGUI.UIConfig.ConfigValue)o;
			UnityEngine.Color ret = obj.c;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index c on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_valid(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.UIConfig.ConfigValue obj = (FairyGUI.UIConfig.ConfigValue)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.valid = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index valid on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_s(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.UIConfig.ConfigValue obj = (FairyGUI.UIConfig.ConfigValue)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.s = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index s on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_i(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.UIConfig.ConfigValue obj = (FairyGUI.UIConfig.ConfigValue)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.i = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index i on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_f(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.UIConfig.ConfigValue obj = (FairyGUI.UIConfig.ConfigValue)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.f = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index f on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_b(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.UIConfig.ConfigValue obj = (FairyGUI.UIConfig.ConfigValue)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.b = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index b on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_c(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.UIConfig.ConfigValue obj = (FairyGUI.UIConfig.ConfigValue)o;
			UnityEngine.Color arg0 = ToLua.ToColor(L, 2);
			obj.c = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index c on a nil value");
		}
	}
}
