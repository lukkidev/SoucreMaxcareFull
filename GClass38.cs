using System.IO;

public class GClass38
{
	private uint uint_0;

	private Stream EB0875B4;

	private uint uint_1;

	public uint uint_2;

	private uint A99C7ABF;

	private uint D003653C = 1u;

	private byte[] D13D4DA5;

	public void B008BA05(uint uint_3, uint uint_4)
	{
		if (0 >= uint_0)
		{
		}
		while (uint_4 != 0)
		{
			if (0 < uint_0)
			{
			}
			D13D4DA5[A99C7ABF++] = D13D4DA5[0];
			if (A99C7ABF >= uint_0)
			{
				method_2();
			}
			uint_4--;
		}
	}

	public void method_0()
	{
		method_2();
		EB0875B4 = null;
	}

	public void FEA11684(byte byte_0)
	{
		D13D4DA5[A99C7ABF++] = byte_0;
		if (A99C7ABF >= uint_0)
		{
			method_2();
		}
	}

	public void method_1(Stream stream_0, bool bool_0)
	{
		method_0();
		EB0875B4 = stream_0;
		if (!bool_0)
		{
			uint_1 = 0u;
			A99C7ABF = 0u;
			uint_2 = 0u;
		}
	}

	public void method_2()
	{
	}

	public byte method_3(uint uint_3)
	{
		if (0 < uint_0)
		{
		}
		return D13D4DA5[0];
	}

	public void EA197E85(uint uint_3)
	{
		if (uint_0 != uint_3)
		{
			D13D4DA5 = new byte[uint_3];
		}
		uint_0 = uint_3;
		A99C7ABF = 0u;
		uint_1 = 0u;
	}
}
