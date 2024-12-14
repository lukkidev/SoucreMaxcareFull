using System;
using System.Collections.Generic;
using System.Reflection;

public class GClass43
{
	private readonly Dictionary<string, uint> C50B8C90;

	private GClass40 gclass40_0;

	private void method_0(ref byte[] F32C551C, uint uint_0)
	{
		for (int i = 0; i < F32C551C.Length; i++)
		{
			F32C551C[i] = (byte)(F32C551C[i] ^ (A2189C36.smethod_1(uint_0, i) + i));
		}
	}

	private Assembly method_1(object object_0, ResolveEventArgs A6859390)
	{
		return (Assembly)new GClass34().method_46(new object[3] { this, object_0, A6859390 }, 25551);
	}

	public GClass43()
	{
		new GClass34().method_46(new object[1] { this }, 14463);
	}
}
