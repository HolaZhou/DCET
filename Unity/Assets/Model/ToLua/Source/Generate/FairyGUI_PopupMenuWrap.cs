﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_PopupMenuWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.PopupMenu), typeof(System.Object));
		L.RegFunction("AddItem", AddItem);
		L.RegFunction("AddItemAt", AddItemAt);
		L.RegFunction("AddSeperator", AddSeperator);
		L.RegFunction("GetItemName", GetItemName);
		L.RegFunction("SetItemText", SetItemText);
		L.RegFunction("SetItemVisible", SetItemVisible);
		L.RegFunction("SetItemGrayed", SetItemGrayed);
		L.RegFunction("SetItemCheckable", SetItemCheckable);
		L.RegFunction("SetItemChecked", SetItemChecked);
		L.RegFunction("isItemChecked", isItemChecked);
		L.RegFunction("RemoveItem", RemoveItem);
		L.RegFunction("ClearItems", ClearItems);
		L.RegFunction("Dispose", Dispose);
		L.RegFunction("Show", Show);
		L.RegFunction("New", _CreateFairyGUI_PopupMenu);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("itemCount", get_itemCount, null);
		L.RegFunction("getitemCount", get_itemCount);
		L.RegVar("contentPane", get_contentPane, null);
		L.RegFunction("getcontentPane", get_contentPane);
		L.RegVar("list", get_list, null);
		L.RegFunction("getlist", get_list);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFairyGUI_PopupMenu(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FairyGUI.PopupMenu obj = new FairyGUI.PopupMenu();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1)
			{
				string arg0 = ToLua.CheckString(L, 1);
				FairyGUI.PopupMenu obj = new FairyGUI.PopupMenu(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FairyGUI.PopupMenu.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddItem(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3 && TypeChecker.CheckTypes<FairyGUI.EventCallback0>(L, 3))
			{
				FairyGUI.PopupMenu obj = (FairyGUI.PopupMenu)ToLua.CheckObject<FairyGUI.PopupMenu>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				FairyGUI.EventCallback0 arg1 = (FairyGUI.EventCallback0)ToLua.ToObject(L, 3);
				FairyGUI.GButton o = obj.AddItem(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes<FairyGUI.EventCallback1>(L, 3))
			{
				FairyGUI.PopupMenu obj = (FairyGUI.PopupMenu)ToLua.CheckObject<FairyGUI.PopupMenu>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				FairyGUI.EventCallback1 arg1 = (FairyGUI.EventCallback1)ToLua.ToObject(L, 3);
				FairyGUI.GButton o = obj.AddItem(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.PopupMenu.AddItem");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddItemAt(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4 && TypeChecker.CheckTypes<FairyGUI.EventCallback0>(L, 4))
			{
				FairyGUI.PopupMenu obj = (FairyGUI.PopupMenu)ToLua.CheckObject<FairyGUI.PopupMenu>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				FairyGUI.EventCallback0 arg2 = (FairyGUI.EventCallback0)ToLua.ToObject(L, 4);
				FairyGUI.GButton o = obj.AddItemAt(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes<FairyGUI.EventCallback1>(L, 4))
			{
				FairyGUI.PopupMenu obj = (FairyGUI.PopupMenu)ToLua.CheckObject<FairyGUI.PopupMenu>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				FairyGUI.EventCallback1 arg2 = (FairyGUI.EventCallback1)ToLua.ToObject(L, 4);
				FairyGUI.GButton o = obj.AddItemAt(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.PopupMenu.AddItemAt");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddSeperator(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.PopupMenu obj = (FairyGUI.PopupMenu)ToLua.CheckObject<FairyGUI.PopupMenu>(L, 1);
			obj.AddSeperator();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetItemName(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.PopupMenu obj = (FairyGUI.PopupMenu)ToLua.CheckObject<FairyGUI.PopupMenu>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			string o = obj.GetItemName(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetItemText(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.PopupMenu obj = (FairyGUI.PopupMenu)ToLua.CheckObject<FairyGUI.PopupMenu>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			obj.SetItemText(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetItemVisible(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.PopupMenu obj = (FairyGUI.PopupMenu)ToLua.CheckObject<FairyGUI.PopupMenu>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			obj.SetItemVisible(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetItemGrayed(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.PopupMenu obj = (FairyGUI.PopupMenu)ToLua.CheckObject<FairyGUI.PopupMenu>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			obj.SetItemGrayed(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetItemCheckable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.PopupMenu obj = (FairyGUI.PopupMenu)ToLua.CheckObject<FairyGUI.PopupMenu>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			obj.SetItemCheckable(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetItemChecked(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.PopupMenu obj = (FairyGUI.PopupMenu)ToLua.CheckObject<FairyGUI.PopupMenu>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			obj.SetItemChecked(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int isItemChecked(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.PopupMenu obj = (FairyGUI.PopupMenu)ToLua.CheckObject<FairyGUI.PopupMenu>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			bool o = obj.isItemChecked(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveItem(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.PopupMenu obj = (FairyGUI.PopupMenu)ToLua.CheckObject<FairyGUI.PopupMenu>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			bool o = obj.RemoveItem(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearItems(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.PopupMenu obj = (FairyGUI.PopupMenu)ToLua.CheckObject<FairyGUI.PopupMenu>(L, 1);
			obj.ClearItems();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Dispose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.PopupMenu obj = (FairyGUI.PopupMenu)ToLua.CheckObject<FairyGUI.PopupMenu>(L, 1);
			obj.Dispose();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Show(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				FairyGUI.PopupMenu obj = (FairyGUI.PopupMenu)ToLua.CheckObject<FairyGUI.PopupMenu>(L, 1);
				obj.Show();
				return 0;
			}
			else if (count == 3)
			{
				FairyGUI.PopupMenu obj = (FairyGUI.PopupMenu)ToLua.CheckObject<FairyGUI.PopupMenu>(L, 1);
				FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.CheckObject<FairyGUI.GObject>(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				obj.Show(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.PopupMenu.Show");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_itemCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.PopupMenu obj = (FairyGUI.PopupMenu)o;
			int ret = obj.itemCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index itemCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_contentPane(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.PopupMenu obj = (FairyGUI.PopupMenu)o;
			FairyGUI.GComponent ret = obj.contentPane;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index contentPane on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_list(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.PopupMenu obj = (FairyGUI.PopupMenu)o;
			FairyGUI.GList ret = obj.list;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index list on a nil value");
		}
	}
}
