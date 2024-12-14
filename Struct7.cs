using System;

internal struct Struct7
{
	private int int_0;

	private uint uint_0;

	private uint[] ADB4BB8A;

	private bool bool_0;

	private int Int32_0
	{
		get
		{
			int num = 0;
			for (int num2 = int_0; num2 >= 0; num2--)
			{
				if (ADB4BB8A[num2] != 0)
				{
					num++;
				}
			}
			return num;
		}
	}

	internal int Int32_1 => int_0 + 1;

	private static uint B9160529(ref Struct7 A792113A, uint uint_1)
	{
		if (uint_1 == 1)
		{
			return 0u;
		}
		if (A792113A.int_0 == 0)
		{
			return A792113A.uint_0 % uint_1;
		}
		ulong num = 0uL;
		for (int num2 = A792113A.int_0; num2 >= 0; num2--)
		{
			num = Class61.A22FF281((uint)num, A792113A.ADB4BB8A[num2]);
			num %= uint_1;
		}
		return (uint)num;
	}

	private void A6AC2A0C(uint uint_1)
	{
		switch (uint_1)
		{
		case 0u:
			method_8(0u);
			return;
		case 1u:
			return;
		}
		if (int_0 == 0)
		{
			method_7((ulong)uint_0 * (ulong)uint_1);
			return;
		}
		method_6(1);
		uint num = 0u;
		for (int i = 0; i <= int_0; i++)
		{
			num = C4118F3F(ref ADB4BB8A[i], uint_1, num);
		}
		if (num != 0)
		{
			method_0(int_0 + 2, 0);
			ADB4BB8A[int_0] = num;
		}
	}

	private static uint F1325C0F(ref uint uint_1, uint uint_2, uint EDBB83BE)
	{
		ulong num = (ulong)((long)uint_1 + (long)uint_2 + EDBB83BE);
		uint_1 = (uint)num;
		return (uint)(num >> 32);
	}

	private void method_0(int int_1, int int_2)
	{
		if (int_1 <= 1)
		{
			if (int_0 > 0)
			{
				uint_0 = ADB4BB8A[0];
			}
			int_0 = 0;
			return;
		}
		if (bool_0 && ADB4BB8A.Length >= int_1)
		{
			if (int_0 + 1 < int_1)
			{
				Array.Clear(ADB4BB8A, int_0 + 1, int_1 - int_0 - 1);
				if (int_0 == 0)
				{
					ADB4BB8A[0] = uint_0;
				}
			}
		}
		else
		{
			uint[] array = new uint[int_1 + int_2];
			if (int_0 == 0)
			{
				array[0] = uint_0;
			}
			else
			{
				Array.Copy(ADB4BB8A, array, Math.Min(int_1, int_0 + 1));
			}
			ADB4BB8A = array;
			bool_0 = true;
		}
		int_0 = int_1 - 1;
	}

	private void method_1(int int_1)
	{
		if (int_1 <= 1)
		{
			int_0 = 0;
			return;
		}
		if (!bool_0 || ADB4BB8A.Length < int_1)
		{
			ADB4BB8A = new uint[int_1];
			bool_0 = true;
		}
		int_0 = int_1 - 1;
	}

	private static uint C4118F3F(ref uint uint_1, uint CCB6EE09, uint uint_2)
	{
		ulong num = (ulong)((long)uint_1 * (long)CCB6EE09 + uint_2);
		uint_1 = (uint)num;
		return (uint)(num >> 32);
	}

	private void method_2()
	{
		if (int_0 > 0 && ADB4BB8A[int_0] == 0)
		{
			uint_0 = ADB4BB8A[0];
			while (--int_0 > 0 && ADB4BB8A[int_0] == 0)
			{
			}
		}
	}

	internal Struct11 method_3(int int_1)
	{
		method_4(int_1, out int_1, out var uint_);
		return new Struct11(int_1, uint_);
	}

	internal Struct7(Struct11 struct11_0, ref int int_1)
	{
		bool_0 = false;
		ADB4BB8A = struct11_0.UInt32_0;
		int d82A7EAC = struct11_0.D82A7EAC;
		int num = d82A7EAC >> 31;
		int_1 = (int_1 ^ num) - num;
		if (ADB4BB8A == null)
		{
			int_0 = 0;
			uint_0 = (uint)((d82A7EAC ^ num) - num);
			return;
		}
		int_0 = ADB4BB8A.Length - 1;
		uint_0 = ADB4BB8A[0];
		while (int_0 > 0 && ADB4BB8A[int_0] == 0)
		{
			int_0--;
		}
	}

	internal Struct7(int int_1)
	{
		int_0 = 0;
		uint_0 = 0u;
		if (int_1 > 1)
		{
			ADB4BB8A = new uint[int_1];
			bool_0 = true;
		}
		else
		{
			ADB4BB8A = null;
			bool_0 = false;
		}
	}

	private static uint smethod_0(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4)
	{
		ulong num = (ulong)((long)uint_2 * (long)uint_3 + uint_1 + uint_4);
		uint_1 = (uint)num;
		return (uint)(num >> 32);
	}

	private void method_4(int AF35403F, out int int_1, out uint[] uint_1)
	{
		if (int_0 == 0)
		{
			if (uint_0 <= int.MaxValue)
			{
				int_1 = AF35403F * (int)uint_0;
				uint_1 = null;
				return;
			}
			if (ADB4BB8A == null)
			{
				ADB4BB8A = new uint[1] { uint_0 };
			}
			else if (bool_0)
			{
				ADB4BB8A[0] = uint_0;
			}
			else if (ADB4BB8A[0] != uint_0)
			{
				ADB4BB8A = new uint[1] { uint_0 };
			}
		}
		int_1 = AF35403F;
		int num = ADB4BB8A.Length - int_0 - 1;
		if (num <= 1)
		{
			if (num == 0 || ADB4BB8A[int_0 + 1] == 0)
			{
				bool_0 = false;
				uint_1 = ADB4BB8A;
				return;
			}
			if (bool_0)
			{
				ADB4BB8A[int_0 + 1] = 0u;
				bool_0 = false;
				uint_1 = ADB4BB8A;
				return;
			}
		}
		uint_1 = ADB4BB8A;
		Array.Resize(ref uint_1, int_0 + 1);
		if (!bool_0)
		{
			ADB4BB8A = uint_1;
		}
	}

	internal void F498C1A6(ref Struct7 CE2367AD, ref Struct7 struct7_0)
	{
		if (CE2367AD.int_0 == 0)
		{
			if (struct7_0.int_0 == 0)
			{
				method_7((ulong)CE2367AD.uint_0 * (ulong)struct7_0.uint_0);
				return;
			}
			D20C4AAA(ref struct7_0, 1);
			A6AC2A0C(CE2367AD.uint_0);
			return;
		}
		if (struct7_0.int_0 == 0)
		{
			D20C4AAA(ref CE2367AD, 1);
			A6AC2A0C(struct7_0.uint_0);
			return;
		}
		B09FF0A3(CE2367AD.int_0 + struct7_0.int_0 + 2);
		uint[] aDB4BB8A;
		int num;
		uint[] aDB4BB8A2;
		int num2;
		if (CE2367AD.Int32_0 <= struct7_0.Int32_0)
		{
			aDB4BB8A = CE2367AD.ADB4BB8A;
			num = CE2367AD.int_0 + 1;
			aDB4BB8A2 = struct7_0.ADB4BB8A;
			num2 = struct7_0.int_0 + 1;
		}
		else
		{
			aDB4BB8A = struct7_0.ADB4BB8A;
			num = struct7_0.int_0 + 1;
			aDB4BB8A2 = CE2367AD.ADB4BB8A;
			num2 = CE2367AD.int_0 + 1;
		}
		for (int i = 0; i < num; i++)
		{
			uint num3 = aDB4BB8A[i];
			if (num3 != 0)
			{
				uint num4 = 0u;
				int num5 = i;
				int num6 = 0;
				while (num6 < num2)
				{
					num4 = smethod_0(ref ADB4BB8A[num5], num3, aDB4BB8A2[num6], num4);
					num6++;
					num5++;
				}
				while (num4 != 0)
				{
					num4 = F1325C0F(ref ADB4BB8A[num5++], 0u, num4);
				}
			}
		}
		method_2();
	}

	internal void method_5(ref Struct7 A61841B6)
	{
		if (A61841B6.int_0 == 0)
		{
			method_8(B9160529(ref this, A61841B6.uint_0));
		}
		else if (int_0 != 0)
		{
			Struct7 struct7_ = default(Struct7);
			smethod_1(ref this, ref A61841B6, bool_1: false, ref struct7_);
		}
	}

	private void D20C4AAA(ref Struct7 struct7_0, int int_1)
	{
		if (struct7_0.int_0 == 0)
		{
			uint_0 = struct7_0.uint_0;
			int_0 = 0;
			return;
		}
		if (!bool_0 || ADB4BB8A.Length <= struct7_0.int_0)
		{
			ADB4BB8A = new uint[struct7_0.int_0 + 1 + int_1];
			bool_0 = true;
		}
		int_0 = struct7_0.int_0;
		Array.Copy(struct7_0.ADB4BB8A, ADB4BB8A, int_0 + 1);
	}

	private void B09FF0A3(int int_1)
	{
		if (int_1 <= 1)
		{
			int_0 = 0;
			uint_0 = 0u;
			return;
		}
		if (bool_0 && ADB4BB8A.Length >= int_1)
		{
			Array.Clear(ADB4BB8A, 0, int_1);
		}
		else
		{
			ADB4BB8A = new uint[int_1];
			bool_0 = true;
		}
		int_0 = int_1 - 1;
	}

	private void method_6(int int_1 = 0)
	{
		if (!bool_0)
		{
			uint[] array = new uint[int_0 + 1 + int_1];
			Array.Copy(ADB4BB8A, array, int_0 + 1);
			ADB4BB8A = array;
			bool_0 = true;
		}
	}

	private void method_7(ulong ulong_0)
	{
		uint num = Class61.smethod_1(ulong_0);
		if (num == 0)
		{
			uint_0 = Class61.D40A1921(ulong_0);
			int_0 = 0;
		}
		else
		{
			method_1(2);
			ADB4BB8A[0] = (uint)ulong_0;
			ADB4BB8A[1] = num;
		}
	}

	private void method_8(uint uint_1)
	{
		uint_0 = uint_1;
		int_0 = 0;
	}

	private static void smethod_1(ref Struct7 struct7_0, ref Struct7 struct7_1, bool bool_1, ref Struct7 struct7_2)
	{
		struct7_2.method_8(0u);
		if (struct7_0.int_0 < struct7_1.int_0)
		{
			return;
		}
		int num = struct7_1.int_0 + 1;
		int num2 = struct7_0.int_0 - struct7_1.int_0;
		int num3 = num2;
		int num4 = struct7_0.int_0;
		while (true)
		{
			if (num4 >= num2)
			{
				if (struct7_1.ADB4BB8A[num4 - num2] == struct7_0.ADB4BB8A[num4])
				{
					num4--;
					continue;
				}
				if (struct7_1.ADB4BB8A[num4 - num2] < struct7_0.ADB4BB8A[num4])
				{
					num3++;
				}
				break;
			}
			num3++;
			break;
		}
		if (num3 == 0)
		{
			return;
		}
		if (bool_1)
		{
			struct7_2.method_1(num3);
		}
		uint num5 = struct7_1.ADB4BB8A[num - 1];
		uint num6 = struct7_1.ADB4BB8A[num - 2];
		int num7 = Class61.E4B9A49E(num5);
		int num8 = 32 - num7;
		if (num7 > 0)
		{
			num5 = (num5 << num7) | (num6 >> num8);
			num6 <<= num7;
			if (num > 2)
			{
				num6 |= struct7_1.ADB4BB8A[num - 3] >> num8;
			}
		}
		struct7_0.method_6();
		int num9 = num3;
		while (--num9 >= 0)
		{
			uint num10 = ((num9 + num <= struct7_0.int_0) ? struct7_0.ADB4BB8A[num9 + num] : 0u);
			ulong num11 = Class61.A22FF281(num10, struct7_0.ADB4BB8A[num9 + num - 1]);
			uint num12 = struct7_0.ADB4BB8A[num9 + num - 2];
			if (num7 > 0)
			{
				num11 = (num11 << num7) | (num12 >> num8);
				num12 <<= num7;
				if (num9 + num >= 3)
				{
					num12 |= struct7_0.ADB4BB8A[num9 + num - 3] >> num8;
				}
			}
			ulong num13 = num11 / num5;
			ulong num14 = (uint)(num11 % num5);
			if (num13 > 4294967295L)
			{
				num14 += num5 * (num13 - 4294967295L);
				num13 = 4294967295uL;
			}
			for (; num14 <= 4294967295L && num13 * num6 > Class61.A22FF281((uint)num14, num12); num14 += num5)
			{
				num13--;
			}
			if (num13 > 0L)
			{
				ulong num15 = 0uL;
				for (int i = 0; i < num; i++)
				{
					num15 += struct7_1.ADB4BB8A[i] * num13;
					uint num16 = (uint)num15;
					num15 >>= 32;
					if (struct7_0.ADB4BB8A[num9 + i] < num16)
					{
						num15++;
					}
					struct7_0.ADB4BB8A[num9 + i] -= num16;
				}
				if (num10 < num15)
				{
					uint eDBB83BE = 0u;
					for (int j = 0; j < num; j++)
					{
						eDBB83BE = F1325C0F(ref struct7_0.ADB4BB8A[num9 + j], struct7_1.ADB4BB8A[j], eDBB83BE);
					}
					num13--;
				}
				struct7_0.int_0 = num9 + num - 1;
			}
			if (bool_1)
			{
				if (num3 == 1)
				{
					struct7_2.uint_0 = (uint)num13;
				}
				else
				{
					struct7_2.ADB4BB8A[num9] = (uint)num13;
				}
			}
		}
		struct7_0.int_0 = num - 1;
		struct7_0.method_2();
	}

	private void B103BF94(bool bool_1)
	{
	}
}
