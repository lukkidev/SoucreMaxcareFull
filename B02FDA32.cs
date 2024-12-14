internal struct B02FDA32
{
	private uint uint_0;

	public uint method_0(Class5 ED2BB3AB)
	{
		ED2BB3AB.uint_0 -= 0u;
		ED2BB3AB.uint_1 -= 0u;
		uint_0 -= uint_0 >> 5;
		if (ED2BB3AB.uint_0 < 16777216)
		{
			ED2BB3AB.uint_1 = (ED2BB3AB.uint_1 << 8) | (byte)ED2BB3AB.stream_0.ReadByte();
			ED2BB3AB.uint_0 <<= 8;
		}
		return 1u;
	}

	public void C2A2803A()
	{
		uint_0 = 1024u;
	}
}
