﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class System_IO_StreamWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(System.IO.Stream), typeof(System.MarshalByRefObject));
		L.RegFunction("CopyToAsync", CopyToAsync);
		L.RegFunction("CopyTo", CopyTo);
		L.RegFunction("Close", Close);
		L.RegFunction("Dispose", Dispose);
		L.RegFunction("Flush", Flush);
		L.RegFunction("FlushAsync", FlushAsync);
		L.RegFunction("BeginRead", BeginRead);
		L.RegFunction("EndRead", EndRead);
		L.RegFunction("ReadAsync", ReadAsync);
		L.RegFunction("BeginWrite", BeginWrite);
		L.RegFunction("EndWrite", EndWrite);
		L.RegFunction("WriteAsync", WriteAsync);
		L.RegFunction("Seek", Seek);
		L.RegFunction("SetLength", SetLength);
		L.RegFunction("Read", Read);
		L.RegFunction("ReadByte", ReadByte);
		L.RegFunction("Write", Write);
		L.RegFunction("WriteByte", WriteByte);
		L.RegFunction("Synchronized", Synchronized);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Null", get_Null, null);
		L.RegVar("CanRead", get_CanRead, null);
		L.RegFunction("getCanRead", get_CanRead);
		L.RegVar("CanSeek", get_CanSeek, null);
		L.RegFunction("getCanSeek", get_CanSeek);
		L.RegVar("CanTimeout", get_CanTimeout, null);
		L.RegFunction("getCanTimeout", get_CanTimeout);
		L.RegVar("CanWrite", get_CanWrite, null);
		L.RegFunction("getCanWrite", get_CanWrite);
		L.RegVar("Length", get_Length, null);
		L.RegFunction("getLength", get_Length);
		L.RegVar("Position", get_Position, set_Position);
		L.RegFunction("getPosition", get_Position);
		L.RegFunction("setPosition", set_Position);
		L.RegVar("ReadTimeout", get_ReadTimeout, set_ReadTimeout);
		L.RegFunction("getReadTimeout", get_ReadTimeout);
		L.RegFunction("setReadTimeout", set_ReadTimeout);
		L.RegVar("WriteTimeout", get_WriteTimeout, set_WriteTimeout);
		L.RegFunction("getWriteTimeout", get_WriteTimeout);
		L.RegFunction("setWriteTimeout", set_WriteTimeout);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CopyToAsync(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
				System.IO.Stream arg0 = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 2);
				System.Threading.Tasks.Task o = obj.CopyToAsync(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3)
			{
				System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
				System.IO.Stream arg0 = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				System.Threading.Tasks.Task o = obj.CopyToAsync(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 4)
			{
				System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
				System.IO.Stream arg0 = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				System.Threading.CancellationToken arg2 = StackTraits<System.Threading.CancellationToken>.Check(L, 4);
				System.Threading.Tasks.Task o = obj.CopyToAsync(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.IO.Stream.CopyToAsync");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CopyTo(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
				System.IO.Stream arg0 = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 2);
				obj.CopyTo(arg0);
				return 0;
			}
			else if (count == 3)
			{
				System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
				System.IO.Stream arg0 = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				obj.CopyTo(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.IO.Stream.CopyTo");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Close(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
			obj.Close();
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
			System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
			obj.Dispose();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Flush(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
			obj.Flush();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FlushAsync(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
				System.Threading.Tasks.Task o = obj.FlushAsync();
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2)
			{
				System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
				System.Threading.CancellationToken arg0 = StackTraits<System.Threading.CancellationToken>.Check(L, 2);
				System.Threading.Tasks.Task o = obj.FlushAsync(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.IO.Stream.FlushAsync");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BeginRead(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 6);
			System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
			byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
			System.AsyncCallback arg3 = (System.AsyncCallback)ToLua.CheckDelegate<System.AsyncCallback>(L, 5);
			object arg4 = ToLua.ToVarObject(L, 6);
			System.IAsyncResult o = obj.BeginRead(arg0, arg1, arg2, arg3, arg4);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EndRead(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
			System.IAsyncResult arg0 = (System.IAsyncResult)ToLua.CheckObject<System.IAsyncResult>(L, 2);
			int o = obj.EndRead(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadAsync(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4)
			{
				System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
				byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
				System.Threading.Tasks.Task<int> o = obj.ReadAsync(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 5)
			{
				System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
				byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
				System.Threading.CancellationToken arg3 = StackTraits<System.Threading.CancellationToken>.Check(L, 5);
				System.Threading.Tasks.Task<int> o = obj.ReadAsync(arg0, arg1, arg2, arg3);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.IO.Stream.ReadAsync");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BeginWrite(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 6);
			System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
			byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
			System.AsyncCallback arg3 = (System.AsyncCallback)ToLua.CheckDelegate<System.AsyncCallback>(L, 5);
			object arg4 = ToLua.ToVarObject(L, 6);
			System.IAsyncResult o = obj.BeginWrite(arg0, arg1, arg2, arg3, arg4);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EndWrite(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
			System.IAsyncResult arg0 = (System.IAsyncResult)ToLua.CheckObject<System.IAsyncResult>(L, 2);
			obj.EndWrite(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteAsync(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4)
			{
				System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
				byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
				System.Threading.Tasks.Task o = obj.WriteAsync(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 5)
			{
				System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
				byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
				System.Threading.CancellationToken arg3 = StackTraits<System.Threading.CancellationToken>.Check(L, 5);
				System.Threading.Tasks.Task o = obj.WriteAsync(arg0, arg1, arg2, arg3);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: System.IO.Stream.WriteAsync");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Seek(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
			long arg0 = LuaDLL.tolua_checkint64(L, 2);
			System.IO.SeekOrigin arg1 = (System.IO.SeekOrigin)LuaDLL.luaL_checknumber(L, 3);
			long o = obj.Seek(arg0, arg1);
			LuaDLL.tolua_pushint64(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLength(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
			long arg0 = LuaDLL.tolua_checkint64(L, 2);
			obj.SetLength(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Read(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
			byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
			int o = obj.Read(arg0, arg1, arg2);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadByte(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
			int o = obj.ReadByte();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Write(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
			byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
			obj.Write(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteByte(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			System.IO.Stream obj = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
			byte arg0 = (byte)LuaDLL.luaL_checknumber(L, 2);
			obj.WriteByte(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Synchronized(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.IO.Stream arg0 = (System.IO.Stream)ToLua.CheckObject<System.IO.Stream>(L, 1);
			System.IO.Stream o = System.IO.Stream.Synchronized(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Null(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, System.IO.Stream.Null);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CanRead(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.IO.Stream obj = (System.IO.Stream)o;
			bool ret = obj.CanRead;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CanRead on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CanSeek(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.IO.Stream obj = (System.IO.Stream)o;
			bool ret = obj.CanSeek;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CanSeek on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CanTimeout(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.IO.Stream obj = (System.IO.Stream)o;
			bool ret = obj.CanTimeout;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CanTimeout on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CanWrite(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.IO.Stream obj = (System.IO.Stream)o;
			bool ret = obj.CanWrite;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CanWrite on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Length(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.IO.Stream obj = (System.IO.Stream)o;
			long ret = obj.Length;
			LuaDLL.tolua_pushint64(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Length on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Position(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.IO.Stream obj = (System.IO.Stream)o;
			long ret = obj.Position;
			LuaDLL.tolua_pushint64(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Position on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ReadTimeout(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.IO.Stream obj = (System.IO.Stream)o;
			int ret = obj.ReadTimeout;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ReadTimeout on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_WriteTimeout(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.IO.Stream obj = (System.IO.Stream)o;
			int ret = obj.WriteTimeout;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index WriteTimeout on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Position(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.IO.Stream obj = (System.IO.Stream)o;
			long arg0 = LuaDLL.tolua_checkint64(L, 2);
			obj.Position = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Position on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ReadTimeout(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.IO.Stream obj = (System.IO.Stream)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.ReadTimeout = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ReadTimeout on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_WriteTimeout(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			System.IO.Stream obj = (System.IO.Stream)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.WriteTimeout = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index WriteTimeout on a nil value");
		}
	}
}
