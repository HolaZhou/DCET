﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_OriginHorizontalWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(FairyGUI.OriginHorizontal));
		L.RegConstant("Left", FairyGUI.OriginHorizontal.Left);
		L.RegConstant("Right", FairyGUI.OriginHorizontal.Right);
		L.EndEnum();
		TypeTraits<FairyGUI.OriginHorizontal>.Check = CheckType;
		StackTraits<FairyGUI.OriginHorizontal>.Push = Push;
	}

	static void Push(IntPtr L, FairyGUI.OriginHorizontal arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(FairyGUI.OriginHorizontal), L, pos);
	}
}
