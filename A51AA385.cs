internal abstract class A51AA385
{
	public struct Struct8
	{
		public uint uint_0;

		public void method_0()
		{
			uint_0 = ((uint_0 < 7) ? 9u : 11u);
		}

		public bool method_1()
		{
			return uint_0 < 7;
		}

		public void method_2()
		{
			if (uint_0 < 4)
			{
				uint_0 = 0u;
			}
			else if (uint_0 < 10)
			{
				uint_0 -= 3u;
			}
			else
			{
				uint_0 -= 6u;
			}
		}

		public void method_3()
		{
			uint_0 = ((uint_0 < 7) ? 8u : 11u);
		}

		public void A6A08703()
		{
			uint_0 = ((uint_0 < 7) ? 7u : 10u);
		}

		public void method_4()
		{
			uint_0 = 0u;
		}
	}

	public static uint smethod_0(uint E6BA2722)
	{
		E6BA2722 -= 2;
		if (E6BA2722 < 4)
		{
			return E6BA2722;
		}
		return 3u;
	}
}
