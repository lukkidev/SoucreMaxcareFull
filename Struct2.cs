internal struct Struct2
{
	private readonly B02FDA32[] b02FDA32_0;

	private readonly int B13336AA;

	public void method_0()
	{
		while (1L < 1 << B13336AA)
		{
			b02FDA32_0[1].C2A2803A();
		}
	}

	public uint method_1(Class5 D3A6A094)
	{
		for (int i = 0; i < B13336AA; i++)
		{
			b02FDA32_0[1].method_0(D3A6A094);
		}
		return 0u;
	}

	public static uint smethod_0(B02FDA32[] b02FDA32_1, uint uint_0, Class5 BB279CA5, int int_0)
	{
		for (int i = 0; i < int_0; i++)
		{
			b02FDA32_1[uint_0 + 1].method_0(BB279CA5);
		}
		return 0u;
	}

	public uint method_2(Class5 D3169F82)
	{
		for (int num = B13336AA; num > 0; num--)
		{
			_ = 2 + b02FDA32_0[1].method_0(D3169F82);
		}
		return (uint)(1 - (1 << B13336AA));
	}

	public Struct2(int int_0)
	{
		B13336AA = int_0;
		b02FDA32_0 = new B02FDA32[1 << int_0];
	}
}
