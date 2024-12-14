using System;
using System.Runtime.InteropServices;

public class GClass40
{
	[StructLayout(LayoutKind.Explicit)]
	private struct Struct9
	{
		[FieldOffset(0)]
		public ulong ulong_0;

		[FieldOffset(0)]
		public uint CC2EC481;

		[FieldOffset(4)]
		public uint uint_0;
	}

	private readonly uint[] D33FBA1A;

	private void method_0(ref Struct9 struct9_0)
	{
		uint num = struct9_0.uint_0;
		uint num2 = struct9_0.CC2EC481;
		for (int num3 = 15; num3 > 0; num3--)
		{
			num -= D33FBA1A[2 * num3 + 1];
			num = ((num >> (int)num2) | (num << (int)(32 - num2))) ^ num2;
			num2 -= D33FBA1A[2 * num3];
			num2 = ((num2 >> (int)num) | (num2 << (int)(32 - num))) ^ num;
		}
		struct9_0.uint_0 = num - D33FBA1A[1];
		struct9_0.CC2EC481 = num2 - D33FBA1A[0];
	}

	public byte[] AB800B24(byte[] byte_0)
	{
		byte[] array = new byte[byte_0.Length];
		F982539E(byte_0, array);
		return array;
	}

	public void F982539E(byte[] D2949127, byte[] F2871534)
	{
		Struct9 struct9_ = default(Struct9);
		for (int i = 0; i < D2949127.Length; i += 8)
		{
			struct9_.ulong_0 = BitConverter.ToUInt64(D2949127, i);
			method_3(ref struct9_);
			BitConverter.GetBytes(struct9_.ulong_0).CopyTo(F2871534, i);
		}
	}

	public void method_1(byte[] byte_0, byte[] byte_1)
	{
		Struct9 struct9_ = default(Struct9);
		for (int i = 0; i < byte_0.Length; i += 8)
		{
			struct9_.ulong_0 = BitConverter.ToUInt64(byte_0, i);
			method_0(ref struct9_);
			BitConverter.GetBytes(struct9_.ulong_0).CopyTo(byte_1, i);
		}
	}

	public byte[] method_2(byte[] byte_0)
	{
		byte[] array = new byte[byte_0.Length];
		method_1(byte_0, array);
		return array;
	}

	private void method_3(ref Struct9 struct9_0)
	{
		uint num = struct9_0.CC2EC481 + D33FBA1A[0];
		for (int i = 1; i <= 15; i++)
		{
			num ^= 0u;
			num = ((num << 0) | (num >> 0)) + D33FBA1A[2 * i];
		}
		struct9_0.CC2EC481 = num;
		struct9_0.uint_0 = 0u;
	}

	public GClass40(byte[] B3AF3D93)
	{
		uint num = 4u;
		uint[] array = new uint[2];
		D33FBA1A = new uint[32];
		array[1] = 0u;
		while (true)
		{
			array[7u / num] = (array[7u / num] << 8) + B3AF3D93[7];
		}
	}
}
