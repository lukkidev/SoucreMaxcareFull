using System;

internal static class Class61
{
	internal static void smethod_0<T>(ref T E0021E28, ref T gparam_0)
	{
		T val = E0021E28;
		E0021E28 = gparam_0;
		gparam_0 = val;
	}

	private static uint[] E218EABA(uint[] uint_0, int int_0)
	{
		if (uint_0.Length == int_0)
		{
			return uint_0;
		}
		uint[] array = new uint[int_0];
		int num = Math.Min(uint_0.Length, int_0);
		for (int i = 0; i < num; i++)
		{
			array[i] = uint_0[i];
		}
		return array;
	}

	internal static int FD17112C(int A3A4238E, int int_0)
	{
		return (int)B604872F((uint)A3A4238E, (uint)int_0);
	}

	internal static int E4B9A49E(uint B6270429)
	{
		if (B6270429 == 0)
		{
			return 32;
		}
		int num = 0;
		if ((B6270429 & 0xFFFF0000u) == 0)
		{
			num += 16;
			B6270429 <<= 16;
		}
		if ((B6270429 & 0xFF000000u) == 0)
		{
			num += 8;
			B6270429 <<= 8;
		}
		if ((B6270429 & 0xF0000000u) == 0)
		{
			num += 4;
			B6270429 <<= 4;
		}
		if ((B6270429 & 0xC0000000u) == 0)
		{
			num += 2;
			B6270429 <<= 2;
		}
		if ((B6270429 & 0x80000000u) == 0)
		{
			num++;
		}
		return num;
	}

	internal static uint D40A1921(ulong B910333D)
	{
		return (uint)B910333D;
	}

	internal static ulong A22FF281(uint E7AC0A0E, uint uint_0)
	{
		return ((ulong)E7AC0A0E << 32) | uint_0;
	}

	private static uint B604872F(uint B60E1982, uint FE1FB2AF)
	{
		return ((B60E1982 << 7) | (B60E1982 >> 25)) ^ FE1FB2AF;
	}

	internal static uint smethod_1(ulong C9223237)
	{
		return (uint)(C9223237 >> 32);
	}

	internal static void D3349836(uint[] uint_0)
	{
		for (int i = 0; i < uint_0.Length; i++)
		{
			uint_0[i] = 0u;
		}
		uint_0 = E218EABA(uint_0, uint_0.Length + 1);
		uint_0[uint_0.Length - 1] = 1u;
	}
}
