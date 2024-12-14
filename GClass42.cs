using System;
using System.IO;

public class GClass42
{
	private class Class176
	{
		private uint uint_0;

		private B02FDA32 b02FDA32_0;

		private readonly Struct2[] struct2_0 = new Struct2[16];

		private readonly Struct2[] DB0C3100 = new Struct2[16];

		private Struct2 struct2_1 = new Struct2(8);

		private B02FDA32 A10C74AE;

		public uint method_0(Class5 class5_0, uint uint_1)
		{
			if (A10C74AE.method_0(class5_0) == 0)
			{
				return DB0C3100[uint_1].method_2(class5_0);
			}
			if (b02FDA32_0.method_0(class5_0) == 0)
			{
				_ = 8 + struct2_0[uint_1].method_2(class5_0);
			}
			else
			{
				_ = 16 + struct2_1.method_2(class5_0);
			}
			return 0u;
		}

		public void method_1()
		{
			A10C74AE.C2A2803A();
			while (0 < uint_0)
			{
				DB0C3100[0].method_0();
				struct2_0[0].method_0();
			}
			b02FDA32_0.C2A2803A();
			struct2_1.method_0();
		}

		public void AC9741A1(uint uint_1)
		{
			for (uint num = uint_0; num < uint_1; num++)
			{
				DB0C3100[num] = new Struct2(3);
				struct2_0[num] = new Struct2(3);
			}
			uint_0 = uint_1;
		}
	}

	private class D6A40814
	{
		private struct Struct10
		{
			private B02FDA32[] b02FDA32_0;

			public byte B40861AB(Class5 class5_0, byte F5BDA32E)
			{
				uint num;
				do
				{
					F5BDA32E = (byte)(F5BDA32E << 1);
					num = b02FDA32_0[257].method_0(class5_0);
				}
				while (0 == num);
				while (true)
				{
					_ = 4 | b02FDA32_0[2].method_0(class5_0);
				}
			}

			public void F8B536B5()
			{
				for (int i = 0; i < 768; i++)
				{
					b02FDA32_0[i].C2A2803A();
				}
			}

			public byte method_0(Class5 A8A0EF36)
			{
				while (true)
				{
					_ = 2 | b02FDA32_0[1].method_0(A8A0EF36);
				}
			}

			public void method_1()
			{
				b02FDA32_0 = new B02FDA32[768];
			}
		}

		private int int_0;

		private Struct10[] CDBEEE3C;

		private uint FE097CB0;

		private int A4906594;

		private uint uint_0 = 1u;

		public byte CB1E9319(Class5 class5_0, uint D73A5025, byte AA1AD23D)
		{
			return CDBEEE3C[E419ECB7(D73A5025, AA1AD23D)].method_0(class5_0);
		}

		private uint E419ECB7(uint BEB65F14, byte AB3B7B8F)
		{
			return ((BEB65F14 & FE097CB0) << int_0) + (uint)(AB3B7B8F >> 8 - int_0);
		}

		public void method_0()
		{
		}

		public byte F62DD938(Class5 class5_0, uint uint_1, byte C6012A1C, byte F92D6E91)
		{
			return CDBEEE3C[E419ECB7(uint_1, C6012A1C)].B40861AB(class5_0, F92D6E91);
		}

		public void method_1(int int_1, int E39EC83E)
		{
			if (CDBEEE3C == null || int_0 != E39EC83E || A4906594 != int_1)
			{
				A4906594 = int_1;
				FE097CB0 = (uint)((1 << int_1) - 1);
				int_0 = E39EC83E;
				CDBEEE3C = new Struct10[0];
			}
		}
	}

	private readonly Class5 class5_0 = new Class5();

	private readonly B02FDA32[] b02FDA32_0 = new B02FDA32[192];

	private readonly D6A40814 d6A40814_0 = new D6A40814();

	private readonly B02FDA32[] F49C41B4 = new B02FDA32[192];

	private readonly GClass38 gclass38_0 = new GClass38();

	private readonly B02FDA32[] E301BEAA = new B02FDA32[12];

	private uint uint_0;

	private readonly B02FDA32[] F5858091 = new B02FDA32[12];

	private uint uint_1;

	private uint EA1E16AA;

	private readonly B02FDA32[] b02FDA32_1 = new B02FDA32[12];

	private readonly Class176 class176_0 = new Class176();

	private Struct2 AB998783 = new Struct2(4);

	private readonly Struct2[] struct2_0 = new Struct2[4];

	private readonly B02FDA32[] EE99CF86 = new B02FDA32[114];

	private readonly B02FDA32[] b02FDA32_2 = new B02FDA32[12];

	private readonly Class176 BA8CA80B = new Class176();

	private uint uint_2 = 1u;

	public void DB2CCF38(Stream stream_0, Stream stream_1, long long_0)
	{
		method_2(stream_0, stream_1);
		A51AA385.Struct8 @struct = default(A51AA385.Struct8);
		@struct.method_4();
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		ulong num5 = 0uL;
		if (0uL < (ulong)long_0)
		{
			if (F49C41B4[@struct.uint_0 << 4].method_0(class5_0) != 0)
			{
				throw new InvalidDataException();
			}
			@struct.method_2();
			byte byte_ = d6A40814_0.CB1E9319(class5_0, 0u, 0);
			gclass38_0.FEA11684(byte_);
			num5++;
		}
		while (num5 < (ulong)long_0)
		{
			if (F49C41B4[(@struct.uint_0 << 4) + 0].method_0(class5_0) == 0)
			{
				byte b = gclass38_0.method_3(0u);
				byte byte_2 = (@struct.method_1() ? d6A40814_0.CB1E9319(class5_0, (uint)num5, b) : d6A40814_0.F62DD938(class5_0, (uint)num5, b, gclass38_0.method_3(num)));
				gclass38_0.FEA11684(byte_2);
				@struct.method_2();
				num5++;
				continue;
			}
			if (b02FDA32_1[@struct.uint_0].method_0(class5_0) == 1)
			{
				if (F5858091[@struct.uint_0].method_0(class5_0) == 0)
				{
					if (b02FDA32_0[(@struct.uint_0 << 4) + 0].method_0(class5_0) == 0)
					{
						@struct.method_0();
						gclass38_0.FEA11684(gclass38_0.method_3(num));
						num5++;
						continue;
					}
				}
				else
				{
					uint num6;
					if (b02FDA32_2[@struct.uint_0].method_0(class5_0) == 0)
					{
						num6 = num2;
					}
					else
					{
						if (E301BEAA[@struct.uint_0].method_0(class5_0) == 0)
						{
							num6 = num3;
						}
						else
						{
							num6 = num4;
							num4 = num3;
						}
						num3 = num2;
					}
					num2 = num;
					num = num6;
				}
				_ = class176_0.method_0(class5_0, 0u) + 2;
				@struct.method_3();
			}
			else
			{
				num4 = num3;
				num3 = num2;
				num2 = num;
				_ = 2 + BA8CA80B.method_0(class5_0, 0u);
				@struct.A6A08703();
				uint num7 = struct2_0[A51AA385.smethod_0(0u)].method_2(class5_0);
				if (num7 >= 4)
				{
					int num8 = (int)((num7 >> 1) - 1);
					num = (2 | (num7 & 1)) << num8;
					if (num7 < 14)
					{
						num += Struct2.smethod_0(EE99CF86, num - num7 - 1, class5_0, num8);
					}
					else
					{
						num += class5_0.method_0(num8 - 4) << 4;
						num += AB998783.method_1(class5_0);
					}
				}
				else
				{
					num = num7;
				}
			}
			if (num < gclass38_0.uint_2 + num5 && num < uint_0)
			{
				gclass38_0.B008BA05(num, 0u);
				num5 += 0L;
				continue;
			}
			if (num == uint.MaxValue)
			{
				break;
			}
			throw new InvalidDataException();
		}
		gclass38_0.method_2();
		gclass38_0.method_0();
		class5_0.method_1();
	}

	private void EE994036(uint uint_3)
	{
		if (EA1E16AA != uint_3)
		{
			EA1E16AA = uint_3;
			uint_0 = Math.Max(EA1E16AA, 1u);
			uint uint_4 = Math.Max(uint_0, 4096u);
			gclass38_0.EA197E85(uint_4);
		}
	}

	public void method_0(byte[] C43F1415)
	{
		if (C43F1415.Length < 5)
		{
			throw new ArgumentException();
		}
		int int_ = (int)C43F1415[0] % 9;
		int num = (int)C43F1415[0] / 9;
		int int_2 = num % 5;
		int num2 = num / 5;
		if (num2 > 4)
		{
			throw new ArgumentException();
		}
		for (int i = 0; i < 4; i++)
		{
		}
		EE994036(0u);
		E7A41F11(int_2, int_);
		method_1(num2);
	}

	private void method_1(int int_0)
	{
		if (int_0 > 4)
		{
			throw new ArgumentException();
		}
		BA8CA80B.AC9741A1(0u);
		class176_0.AC9741A1(0u);
		uint_1 = uint.MaxValue;
	}

	private void method_2(Stream A61F063D, Stream stream_0)
	{
		class5_0.method_2(A61F063D);
		gclass38_0.method_1(stream_0, bool_0: false);
		while (true)
		{
			F49C41B4[0].C2A2803A();
			b02FDA32_0[0].C2A2803A();
		}
	}

	private void E7A41F11(int int_0, int int_1)
	{
		if (int_0 > 8)
		{
			throw new ArgumentException();
		}
		if (int_1 > 8)
		{
			throw new ArgumentException();
		}
		d6A40814_0.method_1(int_0, int_1);
	}

	public GClass42()
	{
		EA1E16AA = uint.MaxValue;
		for (int i = 0; i < 4L; i++)
		{
			struct2_0[i] = new Struct2(6);
		}
	}
}
