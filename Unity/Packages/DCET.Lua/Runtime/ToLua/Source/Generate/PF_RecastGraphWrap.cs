﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class PF_RecastGraphWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(PF.RecastGraph), typeof(PF.NavmeshBase));
		L.RegFunction("CalculateTransform", CalculateTransform);
		L.RegFunction("InitializeTileInfo", InitializeTileInfo);
		L.RegFunction("New", _CreatePF_RecastGraph);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("characterRadius", get_characterRadius, set_characterRadius);
		L.RegVar("contourMaxError", get_contourMaxError, set_contourMaxError);
		L.RegVar("cellSize", get_cellSize, set_cellSize);
		L.RegVar("walkableHeight", get_walkableHeight, set_walkableHeight);
		L.RegVar("walkableClimb", get_walkableClimb, set_walkableClimb);
		L.RegVar("maxSlope", get_maxSlope, set_maxSlope);
		L.RegVar("maxEdgeLength", get_maxEdgeLength, set_maxEdgeLength);
		L.RegVar("minRegionSize", get_minRegionSize, set_minRegionSize);
		L.RegVar("editorTileSize", get_editorTileSize, set_editorTileSize);
		L.RegVar("tileSizeX", get_tileSizeX, set_tileSizeX);
		L.RegVar("tileSizeZ", get_tileSizeZ, set_tileSizeZ);
		L.RegVar("useTiles", get_useTiles, set_useTiles);
		L.RegVar("scanEmptyGraph", get_scanEmptyGraph, set_scanEmptyGraph);
		L.RegVar("relevantGraphSurfaceMode", get_relevantGraphSurfaceMode, set_relevantGraphSurfaceMode);
		L.RegVar("rasterizeColliders", get_rasterizeColliders, set_rasterizeColliders);
		L.RegVar("rasterizeMeshes", get_rasterizeMeshes, set_rasterizeMeshes);
		L.RegVar("rasterizeTerrain", get_rasterizeTerrain, set_rasterizeTerrain);
		L.RegVar("rasterizeTrees", get_rasterizeTrees, set_rasterizeTrees);
		L.RegVar("colliderRasterizeDetail", get_colliderRasterizeDetail, set_colliderRasterizeDetail);
		L.RegVar("mask", get_mask, set_mask);
		L.RegVar("tagMask", get_tagMask, set_tagMask);
		L.RegVar("terrainSampleSize", get_terrainSampleSize, set_terrainSampleSize);
		L.RegVar("rotation", get_rotation, set_rotation);
		L.RegVar("forcedBoundsCenter", get_forcedBoundsCenter, set_forcedBoundsCenter);
		L.RegConstant("BorderVertexMask", 1);
		L.RegConstant("BorderVertexOffset", 31);
		L.RegVar("TileWorldSizeX", get_TileWorldSizeX, null);
		L.RegFunction("getTileWorldSizeX", get_TileWorldSizeX);
		L.RegVar("TileWorldSizeZ", get_TileWorldSizeZ, null);
		L.RegFunction("getTileWorldSizeZ", get_TileWorldSizeZ);
		L.RegVar("CellHeight", get_CellHeight, null);
		L.RegFunction("getCellHeight", get_CellHeight);
		L.RegVar("CharacterRadiusInVoxels", get_CharacterRadiusInVoxels, null);
		L.RegFunction("getCharacterRadiusInVoxels", get_CharacterRadiusInVoxels);
		L.RegVar("TileBorderSizeInVoxels", get_TileBorderSizeInVoxels, null);
		L.RegFunction("getTileBorderSizeInVoxels", get_TileBorderSizeInVoxels);
		L.RegVar("TileBorderSizeInWorldUnits", get_TileBorderSizeInWorldUnits, null);
		L.RegFunction("getTileBorderSizeInWorldUnits", get_TileBorderSizeInWorldUnits);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePF_RecastGraph(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				PF.RecastGraph obj = new PF.RecastGraph();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: PF.RecastGraph.New");
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
			PF.RecastGraph obj = (PF.RecastGraph)ToLua.CheckObject<PF.RecastGraph>(L, 1);
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
	static int InitializeTileInfo(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)ToLua.CheckObject<PF.RecastGraph>(L, 1);
			obj.InitializeTileInfo();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_characterRadius(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			float ret = obj.characterRadius;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index characterRadius on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_contourMaxError(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			float ret = obj.contourMaxError;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index contourMaxError on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cellSize(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			float ret = obj.cellSize;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cellSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_walkableHeight(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			float ret = obj.walkableHeight;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index walkableHeight on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_walkableClimb(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			float ret = obj.walkableClimb;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index walkableClimb on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maxSlope(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			float ret = obj.maxSlope;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maxSlope on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maxEdgeLength(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			float ret = obj.maxEdgeLength;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maxEdgeLength on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_minRegionSize(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			float ret = obj.minRegionSize;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index minRegionSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_editorTileSize(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			int ret = obj.editorTileSize;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index editorTileSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tileSizeX(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			int ret = obj.tileSizeX;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tileSizeX on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tileSizeZ(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			int ret = obj.tileSizeZ;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tileSizeZ on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_useTiles(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			bool ret = obj.useTiles;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index useTiles on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_scanEmptyGraph(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			bool ret = obj.scanEmptyGraph;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index scanEmptyGraph on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_relevantGraphSurfaceMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			PF.RecastGraph.RelevantGraphSurfaceMode ret = obj.relevantGraphSurfaceMode;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index relevantGraphSurfaceMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rasterizeColliders(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			bool ret = obj.rasterizeColliders;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rasterizeColliders on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rasterizeMeshes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			bool ret = obj.rasterizeMeshes;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rasterizeMeshes on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rasterizeTerrain(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			bool ret = obj.rasterizeTerrain;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rasterizeTerrain on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rasterizeTrees(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			bool ret = obj.rasterizeTrees;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rasterizeTrees on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_colliderRasterizeDetail(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			float ret = obj.colliderRasterizeDetail;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index colliderRasterizeDetail on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mask(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			int ret = obj.mask;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mask on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tagMask(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			System.Collections.Generic.List<string> ret = obj.tagMask;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tagMask on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_terrainSampleSize(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			int ret = obj.terrainSampleSize;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index terrainSampleSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rotation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			UnityEngine.Vector3 ret = obj.rotation;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rotation on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_forcedBoundsCenter(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			UnityEngine.Vector3 ret = obj.forcedBoundsCenter;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index forcedBoundsCenter on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TileWorldSizeX(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
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
			PF.RecastGraph obj = (PF.RecastGraph)o;
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
	static int get_CellHeight(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			float ret = obj.CellHeight;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CellHeight on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CharacterRadiusInVoxels(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			int ret = obj.CharacterRadiusInVoxels;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CharacterRadiusInVoxels on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TileBorderSizeInVoxels(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			int ret = obj.TileBorderSizeInVoxels;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index TileBorderSizeInVoxels on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TileBorderSizeInWorldUnits(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			float ret = obj.TileBorderSizeInWorldUnits;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index TileBorderSizeInWorldUnits on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_characterRadius(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.characterRadius = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index characterRadius on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_contourMaxError(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.contourMaxError = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index contourMaxError on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cellSize(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.cellSize = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index cellSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_walkableHeight(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.walkableHeight = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index walkableHeight on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_walkableClimb(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.walkableClimb = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index walkableClimb on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maxSlope(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.maxSlope = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maxSlope on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maxEdgeLength(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.maxEdgeLength = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maxEdgeLength on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_minRegionSize(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.minRegionSize = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index minRegionSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_editorTileSize(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.editorTileSize = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index editorTileSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_tileSizeX(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.tileSizeX = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tileSizeX on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_tileSizeZ(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.tileSizeZ = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tileSizeZ on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_useTiles(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.useTiles = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index useTiles on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_scanEmptyGraph(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.scanEmptyGraph = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index scanEmptyGraph on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_relevantGraphSurfaceMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			PF.RecastGraph.RelevantGraphSurfaceMode arg0 = (PF.RecastGraph.RelevantGraphSurfaceMode)LuaDLL.luaL_checknumber(L, 2);
			obj.relevantGraphSurfaceMode = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index relevantGraphSurfaceMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_rasterizeColliders(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.rasterizeColliders = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rasterizeColliders on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_rasterizeMeshes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.rasterizeMeshes = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rasterizeMeshes on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_rasterizeTerrain(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.rasterizeTerrain = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rasterizeTerrain on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_rasterizeTrees(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.rasterizeTrees = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rasterizeTrees on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_colliderRasterizeDetail(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.colliderRasterizeDetail = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index colliderRasterizeDetail on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mask(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.mask = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mask on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_tagMask(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			System.Collections.Generic.List<string> arg0 = (System.Collections.Generic.List<string>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<string>));
			obj.tagMask = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tagMask on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_terrainSampleSize(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.terrainSampleSize = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index terrainSampleSize on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_rotation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.rotation = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rotation on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_forcedBoundsCenter(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RecastGraph obj = (PF.RecastGraph)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.forcedBoundsCenter = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index forcedBoundsCenter on a nil value");
		}
	}
}
