using System;
using System.Reflection;
using System.Runtime.InteropServices;

internal static class Class177
{
	private static readonly A8BFB809.Struct3[] struct3_0;

	public static readonly long long_0;

	public static IntPtr D19FF531(uint uint_0)
	{
		uint num;
		if (struct3_0 != null)
		{
			num = 0u;
			for (int i = 0; i < struct3_0.Length; i++)
			{
				A8BFB809.Struct3 @struct = struct3_0[i];
				if (uint_0 >= @struct.uint_0)
				{
					if (uint_0 >= @struct.uint_0 && uint_0 < @struct.uint_0 + @struct.C58998B8)
					{
						num = @struct.uint_1 + uint_0 - @struct.uint_0;
						break;
					}
					continue;
				}
				if (i == 0)
				{
					num = uint_0;
				}
				break;
			}
			if (num == 0)
			{
				throw new BadImageFormatException();
			}
		}
		else
		{
			num = uint_0;
		}
		return new IntPtr(long_0 + num);
	}

	public static long FC9B07BF()
	{
		return long_0;
	}

	unsafe static Class177()
	{
		Module module = typeof(A8BFB809).Module;
		long_0 = Marshal.GetHINSTANCE(module).ToInt64();
		if (long_0 == -1L)
		{
			throw new PlatformNotSupportedException();
		}
		if (module.Assembly.Location.Length != 0)
		{
			return;
		}
		A8BFB809.CAB185A7* ptr = (A8BFB809.CAB185A7*)long_0;
		if (ptr->ushort_0 == 23117)
		{
			uint d536E7A = ptr->D536E7A3;
			A8BFB809.Struct5* ptr2 = (A8BFB809.Struct5*)(long_0 + d536E7A);
			if (ptr2->uint_0 == 17744)
			{
				d536E7A += (uint)(Marshal.SizeOf(typeof(A8BFB809.Struct5)) + ptr2->f7063708_0.ushort_1);
				struct3_0 = new A8BFB809.Struct3[ptr2->f7063708_0.ushort_0];
				A8BFB809.Struct3* ptr3 = (A8BFB809.Struct3*)(long_0 + d536E7A);
				for (int i = 0; i < struct3_0.Length; i++)
				{
					struct3_0[i] = ptr3[i];
				}
			}
		}
		if (struct3_0 == null)
		{
			throw new BadImageFormatException();
		}
	}
}
