﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class PF_NavmeshBaseWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(PF.NavmeshBase), typeof(PF.NavGraph));
		L.RegFunction("GetTile", GetTile);
		L.RegFunction("GetVertex", GetVertex);
		L.RegFunction("GetVertexInGraphSpace", GetVertexInGraphSpace);
		L.RegFunction("GetTileIndex", GetTileIndex);
		L.RegFunction("GetVertexArrayIndex", GetVertexArrayIndex);
		L.RegFunction("GetTileCoordinates", GetTileCoordinates);
		L.RegFunction("GetTiles", GetTiles);
		L.RegFunction("GetNodes", GetNodes);
		L.RegFunction("GetNearest", GetNearest);
		L.RegFunction("GetNearestForce", GetNearestForce);
		L.RegFunction("FillWithEmptyTiles", FillWithEmptyTiles);
		L.RegFunction("CreateNodeConnections", CreateNodeConnections);
		L.RegFunction("ConnectTiles", ConnectTiles);
		L.RegFunction("CreateNodes", CreateNodes);
		L.RegFunction("Linecast", Linecast);
		L.RegFunction("CalculateTransform", CalculateTransform);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegConstant("VertexIndexMask", 4095);
		L.RegConstant("TileIndexMask", 524287);
		L.RegConstant("TileIndexOffset", 12);
		L.RegVar("forcedBoundsSize", get_forcedBoundsSize, set_forcedBoundsSize);
		L.RegVar("showMeshOutline", get_showMeshOutline, set_showMeshOutline);
		L.RegVar("showNodeConnections", get_showNodeConnections, set_showNodeConnections);
		L.RegVar("showMeshSurface", get_showMeshSurface, set_showMeshSurface);
		L.RegVar("tileXCount", get_tileXCount, set_tileXCount);
		L.RegVar("tileZCount", get_tileZCount, set_tileZCount);
		L.RegVar("tiles", get_tiles, set_tiles);
		L.RegVar("nearestSearchOnlyXZ", get_nearestSearchOnlyXZ, set_nearestSearchOnlyXZ);
		L.RegVar("transform", get_transform, set_transform);
		L.RegVar("OnRecalculatedTiles", get_OnRecalculatedTiles, set_OnRecalculatedTiles);
		L.RegVar("TileWorldSizeX", get_TileWorldSizeX, null);
		L.RegFunction("getTileWorldSizeX", get_TileWorldSizeX);
		L.RegVar("TileWorldSizeZ", get_TileWorldSizeZ, null);
		L.RegFunction("getTileWorldSizeZ", get_TileWorldSizeZ);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTile(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			PF.NavmeshBase obj = (PF.NavmeshBase)ToLua.CheckObject<PF.NavmeshBase>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			PF.NavmeshTile o = obj.GetTile(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVertex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PF.NavmeshBase obj = (PF.NavmeshBase)ToLua.CheckObject<PF.NavmeshBase>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			PF.Int3 o = obj.GetVertex(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVertexInGraphSpace(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PF.NavmeshBase obj = (PF.NavmeshBase)ToLua.CheckObject<PF.NavmeshBase>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			PF.Int3 o = obj.GetVertexInGraphSpace(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTileIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			int o = PF.NavmeshBase.GetTileIndex(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVertexArrayIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PF.NavmeshBase obj = (PF.NavmeshBase)ToLua.CheckObject<PF.NavmeshBase>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int o = obj.GetVertexArrayIndex(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTileCoordinates(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				PF.NavmeshBase obj = (PF.NavmeshBase)ToLua.CheckObject<PF.NavmeshBase>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				PF.Int2 o = obj.GetTileCoordinates(arg0);
				ToLua.PushValue(L, o);
				return 1;
			}
			else if (count == 4)
			{
				PF.NavmeshBase obj = (PF.NavmeshBase)ToLua.CheckObject<PF.NavmeshBase>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg1;
				int arg2;
				obj.GetTileCoordinates(arg0, out arg1, out arg2);
				LuaDLL.lua_pushinteger(L, arg1);
				LuaDLL.lua_pushinteger(L, arg2);
				return 2;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: PF.NavmeshBase.GetTileCoordinates");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTiles(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)ToLua.CheckObject<PF.NavmeshBase>(L, 1);
			PF.NavmeshTile[] o = obj.GetTiles();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNodes(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<System.Action<PF.GraphNode>>(L, 2))
			{
				PF.NavmeshBase obj = (PF.NavmeshBase)ToLua.CheckObject<PF.NavmeshBase>(L, 1);
				System.Action<PF.GraphNode> arg0 = (System.Action<PF.GraphNode>)ToLua.ToObject(L, 2);
				obj.GetNodes(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<System.Func<PF.GraphNode,bool>>(L, 2))
			{
				PF.NavmeshBase obj = (PF.NavmeshBase)ToLua.CheckObject<PF.NavmeshBase>(L, 1);
				System.Func<PF.GraphNode,bool> arg0 = (System.Func<PF.GraphNode,bool>)ToLua.ToObject(L, 2);
				obj.GetNodes(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: PF.NavmeshBase.GetNodes");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNearest(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				PF.NavmeshBase obj = (PF.NavmeshBase)ToLua.CheckObject<PF.NavmeshBase>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				PF.NNConstraint arg1 = (PF.NNConstraint)ToLua.CheckObject<PF.NNConstraint>(L, 3);
				PF.NNInfoInternal o = obj.GetNearest(arg0, arg1);
				ToLua.PushValue(L, o);
				return 1;
			}
			else if (count == 4)
			{
				PF.NavmeshBase obj = (PF.NavmeshBase)ToLua.CheckObject<PF.NavmeshBase>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				PF.NNConstraint arg1 = (PF.NNConstraint)ToLua.CheckObject<PF.NNConstraint>(L, 3);
				PF.GraphNode arg2 = (PF.GraphNode)ToLua.CheckObject<PF.GraphNode>(L, 4);
				PF.NNInfoInternal o = obj.GetNearest(arg0, arg1, arg2);
				ToLua.PushValue(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: PF.NavmeshBase.GetNearest");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNearestForce(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			PF.NavmeshBase obj = (PF.NavmeshBase)ToLua.CheckObject<PF.NavmeshBase>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			PF.NNConstraint arg1 = (PF.NNConstraint)ToLua.CheckObject<PF.NNConstraint>(L, 3);
			PF.NNInfoInternal o = obj.GetNearestForce(arg0, arg1);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FillWithEmptyTiles(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)ToLua.CheckObject<PF.NavmeshBase>(L, 1);
			obj.FillWithEmptyTiles();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateNodeConnections(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			PF.TriangleMeshNode[] arg0 = ToLua.CheckObjectArray<PF.TriangleMeshNode>(L, 1);
			PF.NavmeshBase.CreateNodeConnections(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ConnectTiles(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			PF.NavmeshBase obj = (PF.NavmeshBase)ToLua.CheckObject<PF.NavmeshBase>(L, 1);
			PF.NavmeshTile arg0 = (PF.NavmeshTile)ToLua.CheckObject<PF.NavmeshTile>(L, 2);
			PF.NavmeshTile arg1 = (PF.NavmeshTile)ToLua.CheckObject<PF.NavmeshTile>(L, 3);
			obj.ConnectTiles(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateNodes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			PF.NavmeshBase obj = (PF.NavmeshBase)ToLua.CheckObject<PF.NavmeshBase>(L, 1);
			PF.TriangleMeshNode[] arg0 = ToLua.CheckObjectArray<PF.TriangleMeshNode>(L, 2);
			int[] arg1 = ToLua.CheckNumberArray<int>(L, 3);
			int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
			uint arg3 = (uint)LuaDLL.luaL_checknumber(L, 5);
			obj.CreateNodes(arg0, arg1, arg2, arg3);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Linecast(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				PF.NavmeshBase obj = (PF.NavmeshBase)ToLua.CheckObject<PF.NavmeshBase>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
				bool o = obj.Linecast(arg0, arg1);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 4)
			{
				PF.NavmeshBase obj = (PF.NavmeshBase)ToLua.CheckObject<PF.NavmeshBase>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
				PF.GraphNode arg2 = (PF.GraphNode)ToLua.CheckObject<PF.GraphNode>(L, 4);
				bool o = obj.Linecast(arg0, arg1, arg2);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 5)
			{
				PF.NavmeshBase obj = (PF.NavmeshBase)ToLua.CheckObject<PF.NavmeshBase>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
				PF.GraphNode arg2 = (PF.GraphNode)ToLua.CheckObject<PF.GraphNode>(L, 4);
				PF.GraphHitInfo arg3;
				bool o = obj.Linecast(arg0, arg1, arg2, out arg3);
				LuaDLL.lua_pushboolean(L, o);
				ToLua.PushValue(L, arg3);
				return 2;
			}
			else if (count == 6)
			{
				PF.NavmeshBase obj = (PF.NavmeshBase)ToLua.CheckObject<PF.NavmeshBase>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
				PF.GraphNode arg2 = (PF.GraphNode)ToLua.CheckObject<PF.GraphNode>(L, 4);
				PF.GraphHitInfo arg3;
				System.Collections.Generic.List<PF.GraphNode> arg4 = (System.Collections.Generic.List<PF.GraphNode>)ToLua.CheckObject(L, 6, typeof(System.Collections.Generic.List<PF.GraphNode>));
				bool o = obj.Linecast(arg0, arg1, arg2, out arg3, arg4);
				LuaDLL.lua_pushboolean(L, o);
				ToLua.PushValue(L, arg3);
				return 2;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: PF.NavmeshBase.Linecast");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateTransform(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)ToLua.CheckObject<PF.NavmeshBase>(L, 1);
			PF.GraphTransform o = obj.CalculateTransform();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_forcedBoundsSize(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			UnityEngine.Vector3 ret = obj.forcedBoundsSize;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index forcedBoundsSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_showMeshOutline(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			bool ret = obj.showMeshOutline;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index showMeshOutline on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_showNodeConnections(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			bool ret = obj.showNodeConnections;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index showNodeConnections on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_showMeshSurface(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			bool ret = obj.showMeshSurface;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index showMeshSurface on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tileXCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			int ret = obj.tileXCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tileXCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tileZCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			int ret = obj.tileZCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tileZCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tiles(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			PF.NavmeshTile[] ret = obj.tiles;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tiles on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_nearestSearchOnlyXZ(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			bool ret = obj.nearestSearchOnlyXZ;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index nearestSearchOnlyXZ on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_transform(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			PF.GraphTransform ret = obj.transform;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index transform on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnRecalculatedTiles(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			System.Action<PF.NavmeshTile[]> ret = obj.OnRecalculatedTiles;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index OnRecalculatedTiles on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TileWorldSizeX(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			float ret = obj.TileWorldSizeX;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index TileWorldSizeX on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TileWorldSizeZ(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			float ret = obj.TileWorldSizeZ;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index TileWorldSizeZ on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_forcedBoundsSize(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.forcedBoundsSize = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index forcedBoundsSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_showMeshOutline(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.showMeshOutline = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index showMeshOutline on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_showNodeConnections(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.showNodeConnections = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index showNodeConnections on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_showMeshSurface(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.showMeshSurface = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index showMeshSurface on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_tileXCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.tileXCount = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tileXCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_tileZCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.tileZCount = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tileZCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_tiles(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			PF.NavmeshTile[] arg0 = ToLua.CheckObjectArray<PF.NavmeshTile>(L, 2);
			obj.tiles = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tiles on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_nearestSearchOnlyXZ(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.nearestSearchOnlyXZ = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index nearestSearchOnlyXZ on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_transform(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			PF.GraphTransform arg0 = (PF.GraphTransform)ToLua.CheckObject<PF.GraphTransform>(L, 2);
			obj.transform = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index transform on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnRecalculatedTiles(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.NavmeshBase obj = (PF.NavmeshBase)o;
			System.Action<PF.NavmeshTile[]> arg0 = (System.Action<PF.NavmeshTile[]>)ToLua.CheckDelegate<System.Action<PF.NavmeshTile[]>>(L, 2);
			obj.OnRecalculatedTiles = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index OnRecalculatedTiles on a nil value");
		}
	}
}
