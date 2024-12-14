using System;
using System.Runtime.CompilerServices;

[Serializable]
internal struct Struct11
{
	private readonly int DC06BCAB;

	private readonly uint[] uint_0;

	private static readonly Struct11 struct11_0 = new Struct11(-1, new uint[1] { 2147483648u });

	private static readonly Struct11 struct11_1 = new Struct11(1);

	private static readonly Struct11 struct11_2 = new Struct11(0);

	private static readonly Struct11 struct11_3 = new Struct11(-1);

	private int C2AFCAAB => (DC06BCAB >> 31) - (-DC06BCAB >> 31);

	internal int D82A7EAC => DC06BCAB;

	internal uint[] UInt32_0 => uint_0;

	private bool Boolean_0
	{
		get
		{
			if (uint_0 != null)
			{
				return (uint_0[0] & 1) == 0;
			}
			return (DC06BCAB & 1) == 0;
		}
	}

	private static Struct11 D3B58E1E => struct11_1;

	private static void D0A003A0(uint ED1A24AA, ref Struct7 struct7_0, ref Struct7 struct7_1, ref Struct7 struct7_2, ref Struct7 struct7_3)
	{
		for (int i = 0; i < 32; i++)
		{
			if ((ED1A24AA & 1) == 1)
			{
				E12F1A94(ref struct7_0, ref struct7_1, ref struct7_2, ref struct7_3);
			}
			smethod_0(ref struct7_1, ref struct7_2, ref struct7_3);
			ED1A24AA >>= 1;
		}
	}

	private static void E12F1A94(ref Struct7 E2893692, ref Struct7 struct7_0, ref Struct7 FA9DBBA9, ref Struct7 struct7_1)
	{
		Class61.smethod_0(ref E2893692, ref struct7_1);
		E2893692.F498C1A6(ref struct7_1, ref struct7_0);
		E2893692.method_5(ref FA9DBBA9);
	}

	

	public override bool Equals(object obj)
	{
		if (!(obj is Struct11))
		{
			return false;
		}
		return Equals((Struct11)obj);
	}

	[SpecialName]
	public static bool DB1A13B7(Struct11 struct11_4, Struct11 struct11_5)
	{
		return !struct11_4.Equals(struct11_5);
	}

	[SpecialName]
	public static bool AB8B7B87(Struct11 struct11_4, Struct11 E70C1A3F)
	{
		return struct11_4.Equals(E70C1A3F);
	}

	private static void smethod_0(ref Struct7 struct7_0, ref Struct7 struct7_1, ref Struct7 struct7_2)
	{
		Class61.smethod_0(ref struct7_0, ref struct7_2);
		struct7_0.F498C1A6(ref struct7_2, ref struct7_2);
		struct7_0.method_5(ref struct7_1);
	}

	internal byte[] B29D3EAE()
	{
		if (uint_0 == null && DC06BCAB == 0)
		{
			return new byte[1];
		}
		uint[] array;
		byte b;
		if (uint_0 == null)
		{
			array = new uint[1] { (uint)DC06BCAB };
			b = (byte)((DC06BCAB < 0) ? 255u : 0u);
		}
		else if (DC06BCAB == -1)
		{
			array = (uint[])uint_0.Clone();
			Class61.D3349836(array);
			b = byte.MaxValue;
		}
		else
		{
			array = uint_0;
			b = 0;
		}
		byte[] array2 = new byte[checked(4 * array.Length)];
		int num = 0;
		uint[] array3 = array;
		for (int i = 0; i < array3.Length; i++)
		{
			uint num2 = array3[i];
			for (int j = 0; j < 4; j++)
			{
				array2[num++] = (byte)(num2 & 0xFFu);
				num2 >>= 8;
			}
		}
		if ((array2[array2.Length - 1] & 0x80) == (b & 0x80))
		{
			return array2;
		}
		byte[] array4 = new byte[array2.Length + 1];
		Array.Copy(array2, array4, array2.Length);
		array4[array4.Length - 1] = b;
		return array4;
	}

	[SpecialName]
	public static bool smethod_1(Struct11 struct11_4, Struct11 struct11_5)
	{
		return struct11_4.method_0(struct11_5) >= 0;
	}

	internal Struct11(byte[] E882282A)
	{
		if (E882282A == null)
		{
			throw new ArgumentNullException("value");
		}
		int num = E882282A.Length;
		bool flag = num > 0 && (E882282A[num - 1] & 0x80) == 128;
		while (num > 0 && E882282A[num - 1] == 0)
		{
			num--;
		}
		if (num == 0)
		{
			DC06BCAB = 0;
			uint_0 = null;
			return;
		}
		if (num <= 4)
		{
			if (flag)
			{
				DC06BCAB = -1;
			}
			else
			{
				DC06BCAB = 0;
			}
			for (int num2 = num - 1; num2 >= 0; num2--)
			{
				DC06BCAB <<= 8;
				DC06BCAB |= E882282A[num2];
			}
			uint_0 = null;
			if (DC06BCAB < 0 && !flag)
			{
				uint_0 = new uint[1];
				uint_0[0] = (uint)DC06BCAB;
				DC06BCAB = 1;
			}
			if (DC06BCAB == int.MinValue)
			{
				this = struct11_0;
			}
			return;
		}
		int num3 = num % 4;
		int num4 = num / 4 + ((num3 != 0) ? 1 : 0);
		bool flag2 = true;
		uint[] array = new uint[num4];
		int num5 = 3;
		int i;
		for (i = 0; i < num4 - ((num3 != 0) ? 1 : 0); i++)
		{
			for (int j = 0; j < 4; j++)
			{
				if (E882282A[num5] != 0)
				{
					flag2 = false;
				}
				array[i] <<= 8;
				array[i] |= E882282A[num5];
				num5--;
			}
			num5 += 8;
		}
		if (num3 != 0)
		{
			if (flag)
			{
				array[num4 - 1] = uint.MaxValue;
			}
			for (num5 = num - 1; num5 >= num - num3; num5--)
			{
				if (E882282A[num5] != 0)
				{
					flag2 = false;
				}
				array[i] <<= 8;
				array[i] |= E882282A[num5];
			}
		}
		if (flag2)
		{
			this = struct11_2;
		}
		else if (flag)
		{
			Class61.D3349836(array);
			int num6 = array.Length;
			while (num6 > 0 && array[num6 - 1] == 0)
			{
				num6--;
			}
			if (num6 == 1 && (int)array[0] > 0)
			{
				if (array[0] == 1)
				{
					this = struct11_3;
					return;
				}
				if (array[0] == 2147483648u)
				{
					this = struct11_0;
					return;
				}
				DC06BCAB = -1 * (int)array[0];
				uint_0 = null;
			}
			else if (num6 != array.Length)
			{
				DC06BCAB = -1;
				uint_0 = new uint[num6];
				Array.Copy(array, uint_0, num6);
			}
			else
			{
				DC06BCAB = -1;
				uint_0 = array;
			}
		}
		else
		{
			DC06BCAB = 1;
			uint_0 = array;
		}
	}

	private static int smethod_2(uint[] uint_1, uint[] ADA8153D, int int_0)
	{
		int num = int_0;
		do
		{
			if (--num < 0)
			{
				return 0;
			}
		}
		while (uint_1[num] == ADA8153D[num]);
		return num + 1;
	}

	private Struct11(int int_0)
	{
		if (int_0 == int.MinValue)
		{
			this = struct11_0;
			return;
		}
		DC06BCAB = int_0;
		uint_0 = null;
	}

	[SpecialName]
	public static bool smethod_3(Struct11 struct11_4, Struct11 struct11_5)
	{
		return struct11_4.method_0(struct11_5) < 0;
	}

	internal Struct11(int C2897D8E, uint[] uint_1)
	{
		DC06BCAB = C2897D8E;
		uint_0 = uint_1;
	}

	private static int B7AE0B86(uint[] uint_1)
	{
		int num = uint_1.Length;
		if (uint_1[num - 1] != 0)
		{
			return num;
		}
		return num - 1;
	}

	private int method_0(Struct11 struct11_4)
	{
		if ((DC06BCAB ^ struct11_4.DC06BCAB) < 0)
		{
			if (DC06BCAB >= 0)
			{
				return 1;
			}
			return -1;
		}
		if (uint_0 == null)
		{
			if (struct11_4.uint_0 == null)
			{
				if (DC06BCAB >= struct11_4.DC06BCAB)
				{
					if (DC06BCAB <= struct11_4.DC06BCAB)
					{
						return 0;
					}
					return 1;
				}
				return -1;
			}
			return -struct11_4.DC06BCAB;
		}
		int num;
		int num2;
		if (struct11_4.uint_0 != null && (num = B7AE0B86(uint_0)) <= (num2 = B7AE0B86(struct11_4.uint_0)))
		{
			if (num < num2)
			{
				return -DC06BCAB;
			}
			int num3 = smethod_2(uint_0, struct11_4.uint_0, num);
			if (num3 == 0)
			{
				return 0;
			}
			if (uint_0[num3 - 1] >= struct11_4.uint_0[num3 - 1])
			{
				return DC06BCAB;
			}
			return -DC06BCAB;
		}
		return DC06BCAB;
	}

	[SpecialName]
	public static bool smethod_4(Struct11 B9141688, Struct11 AB964900)
	{
		return B9141688.method_0(AB964900) <= 0;
	}

	[SpecialName]
	public static bool FF226832(Struct11 struct11_4, Struct11 EDA8FFA3)
	{
		return struct11_4.method_0(EDA8FFA3) > 0;
	}

	private static void F5B409BC(uint uint_1, ref Struct7 struct7_0, ref Struct7 BEA63324, ref Struct7 struct7_1, ref Struct7 BC921435)
	{
		while (uint_1 != 0)
		{
			if ((uint_1 & 1) == 1)
			{
				E12F1A94(ref struct7_0, ref BEA63324, ref struct7_1, ref BC921435);
			}
			if (uint_1 != 1)
			{
				smethod_0(ref BEA63324, ref struct7_1, ref BC921435);
				uint_1 >>= 1;
				continue;
			}
			break;
		}
	}

	internal static Struct11 smethod_5(Struct11 FE90CB28, Struct11 FE91E019, Struct11 struct11_4)
	{
		if (FE91E019.C2AFCAAB < 0)
		{
			throw new ArgumentOutOfRangeException("exponent", "ArgumentOutOfRange must be non negative");
		}
		int int_ = 1;
		int int_2 = 1;
		int int_3 = 1;
		bool boolean_ = FE91E019.Boolean_0;
		Struct7 struct7_ = new Struct7(struct11_1, ref int_);
		Struct7 BEA = new Struct7(FE90CB28, ref int_2);
		Struct7 A61841B = new Struct7(struct11_4, ref int_3);
		Struct7 BC = new Struct7(BEA.Int32_1);
		struct7_.method_5(ref A61841B);
		if (FE91E019.uint_0 == null)
		{
			F5B409BC((uint)FE91E019.DC06BCAB, ref struct7_, ref BEA, ref A61841B, ref BC);
		}
		else
		{
			int num = B7AE0B86(FE91E019.uint_0);
			for (int i = 0; i < num - 1; i++)
			{
				D0A003A0(FE91E019.uint_0[i], ref struct7_, ref BEA, ref A61841B, ref BC);
			}
			F5B409BC(FE91E019.uint_0[num - 1], ref struct7_, ref BEA, ref A61841B, ref BC);
		}
		return struct7_.method_3((FE90CB28.DC06BCAB > 0) ? 1 : (boolean_ ? 1 : (-1)));
	}

	private void method_1()
	{
		if (uint_0 != null)
		{
			B7AE0B86(uint_0);
		}
	}
}
