using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;

public class GClass34
{
	private sealed class Class169 : Class168
	{
		private int int_0;

		private List<Class149> list_0 = new List<Class149>();

		public Class149 F2061289()
		{
			int index = list_0.Count - 1;
			return list_0[index];
		}

		public void method_0(Class149 E48A273A)
		{
			list_0.Add(E48A273A.vmethod_5());
		}

		public void method_1()
		{
			while (list_0.Count > int_0)
			{
				list_0.RemoveAt(int_0);
			}
		}

		public Class149 BA317A20(int int_1, Class149 class149_0)
		{
			if (int_1 < 0)
			{
				int_1 += list_0.Count - 1;
			}
			return list_0[int_1] = class149_0;
		}

		public Class149 F90CF8B2()
		{
			int index = list_0.Count - 1;
			Class149 result = list_0[index];
			list_0.RemoveAt(index);
			return result;
		}

		public override void vmethod_0(int A6B49F3B)
		{
			int_0 = A6B49F3B;
			for (int i = 0; i < int_0; i++)
			{
				list_0.Insert(0, null);
			}
		}

		public Class149 method_2(int BE00170C)
		{
			if (BE00170C < 0)
			{
				BE00170C += list_0.Count - 1;
			}
			return list_0[BE00170C];
		}

		public override int vmethod_1()
		{
			return list_0.Count;
		}
	}

	private sealed class Class156 : Class155
	{
		private Class149 class149_0;

		private Enum D9A17C03;

		public override Class149 FB97EC11()
		{
			return new Class156(D9A17C03);
		}

		public override int vmethod_11()
		{
			return class149_0.vmethod_11();
		}

		public override ulong B0B223A4()
		{
			return class149_0.B0B223A4();
		}

		public override short vmethod_14()
		{
			return class149_0.vmethod_14();
		}

		public override ushort vmethod_8()
		{
			return class149_0.vmethod_8();
		}

		public override sbyte EFB8C6AD()
		{
			return class149_0.EFB8C6AD();
		}

		public override IntPtr F786FC2B()
		{
			return new IntPtr((IntPtr.Size == 4) ? vmethod_11() : vmethod_3());
		}

		public override double vmethod_6()
		{
			return class149_0.vmethod_6();
		}

		public override Type vmethod_13()
		{
			return D9A17C03.GetType();
		}

		private static Class149 CD1B7800(Enum CE9A80A8)
		{
			switch (CE9A80A8.GetTypeCode())
			{
			default:
				throw new InvalidOperationException();
			case TypeCode.SByte:
			case TypeCode.Int16:
			case TypeCode.Int32:
				return new Class158(Convert.ToInt32(CE9A80A8));
			case TypeCode.Byte:
			case TypeCode.UInt16:
			case TypeCode.UInt32:
				return new Class158((int)Convert.ToUInt32(CE9A80A8));
			case TypeCode.Int64:
				return new C489BE26(Convert.ToInt64(CE9A80A8));
			case TypeCode.UInt64:
				return new C489BE26((long)Convert.ToUInt64(CE9A80A8));
			}
		}

		public override uint vmethod_2()
		{
			return class149_0.vmethod_2();
		}

		public override void vmethod_12(object BAB172A7)
		{
			if (BAB172A7 == null)
			{
				throw new ArgumentException();
			}
			D9A17C03 = (Enum)BAB172A7;
			class149_0 = CD1B7800(D9A17C03);
		}

		public override object E8BD6697()
		{
			return D9A17C03;
		}

		public override UIntPtr vmethod_4()
		{
			return new UIntPtr((IntPtr.Size == 4) ? vmethod_2() : B0B223A4());
		}

		public override byte vmethod_15()
		{
			return class149_0.vmethod_15();
		}

		public override long vmethod_3()
		{
			return class149_0.vmethod_3();
		}

		public override float vmethod_1()
		{
			return class149_0.vmethod_1();
		}

		public Class156(Enum B21C4BB8)
		{
			if (B21C4BB8 == null)
			{
				throw new ArgumentException();
			}
			D9A17C03 = B21C4BB8;
			class149_0 = CD1B7800(D9A17C03);
		}
	}

	private sealed class Class150 : Class149
	{
		private byte byte_0;

		public override Type vmethod_13()
		{
			return typeof(byte);
		}

		public override ushort vmethod_8()
		{
			return byte_0;
		}

		public override Class155 vmethod_5()
		{
			return new Class158(vmethod_11());
		}

		public override sbyte EFB8C6AD()
		{
			return (sbyte)byte_0;
		}

		public override object E8BD6697()
		{
			return byte_0;
		}

		public override uint vmethod_2()
		{
			return byte_0;
		}

		public override int vmethod_11()
		{
			return byte_0;
		}

		public override short vmethod_14()
		{
			return byte_0;
		}

		public override void vmethod_12(object A29A8B8D)
		{
			byte_0 = Convert.ToByte(A29A8B8D);
		}

		public override byte vmethod_15()
		{
			return byte_0;
		}

		public override Class149 FB97EC11()
		{
			return new Class150(byte_0);
		}

		public Class150(byte B53B673F)
		{
			byte_0 = B53B673F;
		}
	}

	private sealed class Class151 : Class149
	{
		private ulong CB21020A;

		public override Class149 FB97EC11()
		{
			return new Class151(CB21020A);
		}

		public override ushort vmethod_8()
		{
			return (ushort)CB21020A;
		}

		public override int vmethod_11()
		{
			return (int)CB21020A;
		}

		public static Class149 smethod_1(Class149 F001CE06)
		{
			return new C489BE26((long)F001CE06.B0B223A4());
		}

		public override byte vmethod_15()
		{
			return (byte)CB21020A;
		}

		public override sbyte EFB8C6AD()
		{
			return (sbyte)CB21020A;
		}

		public override ulong B0B223A4()
		{
			return CB21020A;
		}

		public override short vmethod_14()
		{
			return (short)CB21020A;
		}

		public override object E8BD6697()
		{
			return CB21020A;
		}

		public override uint vmethod_2()
		{
			return (uint)CB21020A;
		}

		public override void vmethod_12(object BAB172A7)
		{
			CB21020A = Convert.ToUInt64(BAB172A7);
		}

		public override Type vmethod_13()
		{
			return typeof(ulong);
		}

		public override long vmethod_3()
		{
			return (long)CB21020A;
		}

		public override Class155 vmethod_5()
		{
			return new C489BE26(vmethod_3());
		}

		public Class151(ulong ulong_0)
		{
			CB21020A = ulong_0;
		}
	}

	private sealed class B4397D18 : Class155
	{
		private object object_0;

		public override Class149 FB97EC11()
		{
			object obj;
			if (object_0 == null)
			{
				obj = null;
			}
			else
			{
				Type type = object_0.GetType();
				FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				obj = Activator.CreateInstance(type);
				FieldInfo[] array = fields;
				foreach (FieldInfo fieldInfo in array)
				{
					fieldInfo.SetValue(obj, fieldInfo.GetValue(object_0));
				}
			}
			return new B4397D18(obj);
		}

		public override object E8BD6697()
		{
			return object_0;
		}

		public override void vmethod_12(object BAB172A7)
		{
			if (BAB172A7 != null && !(BAB172A7 is ValueType))
			{
				throw new ArgumentException();
			}
			object_0 = BAB172A7;
		}

		public override Type vmethod_13()
		{
			return typeof(ValueType);
		}

		public B4397D18(object CDBE2399)
		{
			if (CDBE2399 != null && !(CDBE2399 is ValueType))
			{
				throw new ArgumentException();
			}
			object_0 = CDBE2399;
		}
	}

	private sealed class C489BE26 : Class155
	{
		private long long_0;

		public static Class149 smethod_1(Class149 B20BAB05, Class149 class149_0)
		{
			ulong num = ~B20BAB05.B0B223A4();
			ulong num2 = ~class149_0.B0B223A4();
			return new C489BE26((long)(num | num2));
		}

		public override char vmethod_10()
		{
			return (char)long_0;
		}

		public override byte vmethod_15()
		{
			return (byte)long_0;
		}

		public override short vmethod_14()
		{
			return (short)long_0;
		}

		public static Class149 E6AC84AA(Class149 class149_0, Class149 class149_1)
		{
			ulong num = ~class149_0.B0B223A4();
			ulong num2 = ~class149_1.B0B223A4();
			return new C489BE26((long)(num & num2));
		}

		public override double vmethod_6()
		{
			return long_0;
		}

		public static Class149 C4AF3B31(Class149 class149_0, Class149 class149_1)
		{
			if (((uint)class149_1.F201FE8B() & 8u) != 0)
			{
				ulong ulong_ = class149_0.B0B223A4();
				ulong ulong_2 = class149_1.B0B223A4();
				Class173 @class = new Class173();
				@class.method_0(ulong_, ulong_2);
				C489BE26 c489BE = new C489BE26((long)@class.B22D7A33);
				if (@class.ulong_0 != 0L)
				{
					c489BE.F003DD86(32);
				}
				return c489BE;
			}
			long num = class149_0.vmethod_3();
			long long_ = class149_1.vmethod_3();
			Class173 class2 = new Class173();
			class2.A0328606(num, long_);
			C489BE26 c489BE2 = new C489BE26((long)class2.B22D7A33);
			ulong ulong_3 = class2.ulong_0;
			if ((long)class2.B22D7A33 >= 0L)
			{
				if (ulong_3 != 0L)
				{
					goto IL_00a3;
				}
			}
			else if (ulong_3 != ulong.MaxValue)
			{
				goto IL_00a3;
			}
			goto IL_00ab;
			IL_00a3:
			c489BE2.F003DD86(1);
			goto IL_00ab;
			IL_00ab:
			return c489BE2;
		}

		public override sbyte EFB8C6AD()
		{
			return (sbyte)long_0;
		}

		public static Class149 smethod_2(Class149 class149_0, Class149 class149_1)
		{
			long num = class149_0.vmethod_3();
			int num2 = class149_1.vmethod_11();
			return new C489BE26(num << num2);
		}

		public override ushort vmethod_8()
		{
			return (ushort)long_0;
		}

		public override IntPtr F786FC2B()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((int)long_0) : long_0);
		}

		public override uint vmethod_2()
		{
			return (uint)long_0;
		}

		public override UIntPtr vmethod_4()
		{
			return new UIntPtr((ulong)((UIntPtr.Size == 4) ? ((uint)long_0) : long_0));
		}

		public override int vmethod_11()
		{
			return (int)long_0;
		}

		public static Class149 A4141B3A(Class149 class149_0, Class149 class149_1)
		{
			int num = 0;
			if (((uint)class149_1.F201FE8B() & 8u) != 0)
			{
				ulong num2 = class149_0.B0B223A4();
				ulong num3 = class149_1.B0B223A4();
				if (num2 == num3)
				{
					num |= 4;
				}
				else if (num2 < num3)
				{
					num |= 0x40;
				}
			}
			else
			{
				long num4 = class149_0.vmethod_3();
				long num5 = class149_1.vmethod_3();
				if (num4 == num5)
				{
					num |= 4;
				}
				else if (num4 < num5)
				{
					num |= 0x40;
				}
			}
			return new Class158(num);
		}

		public override Class149 FB97EC11()
		{
			C489BE26 c489BE = new C489BE26(long_0);
			c489BE.F003DD86(F201FE8B());
			return c489BE;
		}

		public static Class149 smethod_3(Class149 class149_0, Class149 FDA81998)
		{
			ulong num = class149_0.B0B223A4();
			ulong num2 = FDA81998.B0B223A4();
			return new C489BE26((long)(num + num2));
		}

		public override bool vmethod_9()
		{
			return (ulong)long_0 > 0uL;
		}

		public static Class149 smethod_4(Class149 C5B9C62D, Class149 class149_0)
		{
			if (((uint)class149_0.F201FE8B() & 8u) != 0)
			{
				ulong num = C5B9C62D.B0B223A4();
				int num2 = class149_0.vmethod_11();
				return new C489BE26((long)(num >> num2));
			}
			long num3 = C5B9C62D.vmethod_3();
			int num4 = class149_0.vmethod_11();
			return new C489BE26(num3 >> num4);
		}

		public override object E8BD6697()
		{
			return long_0;
		}

		public override long vmethod_3()
		{
			return long_0;
		}

		public override float vmethod_1()
		{
			return long_0;
		}

		public override ulong B0B223A4()
		{
			return (ulong)long_0;
		}

		public static Class149 smethod_5(Class149 F40386A6, Class149 class149_0)
		{
			long aD1B3B;
			if (((uint)class149_0.F201FE8B() & 8u) != 0)
			{
				ulong num = F40386A6.B0B223A4();
				ulong num2 = class149_0.B0B223A4();
				aD1B3B = (long)(num / num2);
			}
			else
			{
				long num3 = F40386A6.vmethod_3();
				long num4 = class149_0.vmethod_3();
				aD1B3B = num3 / num4;
			}
			return new C489BE26(aD1B3B);
		}

		public override void vmethod_12(object BAB172A7)
		{
			long_0 = Convert.ToInt64(BAB172A7);
		}

		public static Class149 CB18189A(Class149 class149_0, Class149 class149_1)
		{
			if (((uint)class149_1.F201FE8B() & 8u) != 0)
			{
				ulong num = class149_0.B0B223A4();
				ulong num2 = class149_1.B0B223A4();
				return new C489BE26((long)(num % num2));
			}
			long num3 = class149_0.vmethod_3();
			long num4 = class149_1.vmethod_3();
			return new C489BE26(num3 % num4);
		}

		public override Type vmethod_13()
		{
			return typeof(long);
		}

		public static Class149 smethod_6(Class149 A399C816)
		{
			return new C489BE26(A399C816.vmethod_3());
		}

		public C489BE26(long AD1B3B82)
		{
			long_0 = AD1B3B82;
		}
	}

	private sealed class Class160 : DF12521F
	{
		private Class149 class149_0;

		private FieldInfo fieldInfo_0;

		public override void vmethod_12(object BAB172A7)
		{
			class149_0.vmethod_7(fieldInfo_0, BAB172A7);
		}

		public override object E8BD6697()
		{
			return class149_0.D42BD616(fieldInfo_0);
		}

		public override Type vmethod_13()
		{
			return fieldInfo_0.FieldType;
		}

		public override Class149 FB97EC11()
		{
			return new Class160(fieldInfo_0, class149_0);
		}

		public Class160(FieldInfo fieldInfo_1, Class149 class149_1)
		{
			fieldInfo_0 = fieldInfo_1;
			class149_0 = class149_1;
		}
	}

	private sealed class Class157 : Class155
	{
		private Class149 C32A2911;

		public override object D42BD616(FieldInfo A51CCF2C)
		{
			object result = C32A2911.D42BD616(A51CCF2C);
			Thread.MemoryBarrier();
			return result;
		}

		public override void vmethod_7(FieldInfo fieldInfo_0, object C8191691)
		{
			Thread.MemoryBarrier();
			C32A2911.vmethod_7(fieldInfo_0, C8191691);
		}

		public override Class149 FB97EC11()
		{
			throw new InvalidOperationException();
		}

		public override void vmethod_12(object BAB172A7)
		{
			Thread.MemoryBarrier();
			C32A2911.vmethod_12(BAB172A7);
		}

		public override sbyte EFB8C6AD()
		{
			sbyte result = C32A2911.EFB8C6AD();
			Thread.MemoryBarrier();
			return result;
		}

		public override object E8BD6697()
		{
			object result = C32A2911.E8BD6697();
			Thread.MemoryBarrier();
			return result;
		}

		public override ushort vmethod_8()
		{
			ushort result = C32A2911.vmethod_8();
			Thread.MemoryBarrier();
			return result;
		}

		public override uint vmethod_2()
		{
			uint result = C32A2911.vmethod_2();
			Thread.MemoryBarrier();
			return result;
		}

		public override int vmethod_11()
		{
			int result = C32A2911.vmethod_11();
			Thread.MemoryBarrier();
			return result;
		}

		public override byte vmethod_15()
		{
			byte result = C32A2911.vmethod_15();
			Thread.MemoryBarrier();
			return result;
		}

		public override short vmethod_14()
		{
			short result = C32A2911.vmethod_14();
			Thread.MemoryBarrier();
			return result;
		}

		public override bool vmethod_0()
		{
			return C32A2911.vmethod_0();
		}

		public override bool vmethod_9()
		{
			bool result = C32A2911.vmethod_9();
			Thread.MemoryBarrier();
			return result;
		}

		public override Type vmethod_13()
		{
			return C32A2911.vmethod_13();
		}

		public override long vmethod_3()
		{
			long result = C32A2911.vmethod_3();
			Thread.MemoryBarrier();
			return result;
		}

		public override double vmethod_6()
		{
			double result = C32A2911.vmethod_6();
			Thread.MemoryBarrier();
			return result;
		}

		public override ulong B0B223A4()
		{
			ulong result = C32A2911.B0B223A4();
			Thread.MemoryBarrier();
			return result;
		}

		public override float vmethod_1()
		{
			float result = C32A2911.vmethod_1();
			Thread.MemoryBarrier();
			return result;
		}

		public Class157(Class149 class149_0)
		{
			C32A2911 = class149_0;
		}
	}

	private sealed class C31D7396 : Class155
	{
		private MethodBase F62C6B9B;

		public override void vmethod_12(object BAB172A7)
		{
			F62C6B9B = (MethodBase)BAB172A7;
		}

		public override Class149 FB97EC11()
		{
			return new C31D7396(F62C6B9B);
		}

		public override IntPtr F786FC2B()
		{
			return F62C6B9B.MethodHandle.GetFunctionPointer();
		}

		public override Type vmethod_13()
		{
			return typeof(MethodBase);
		}

		public override object E8BD6697()
		{
			return F62C6B9B;
		}

		public C31D7396(MethodBase AB10510F)
		{
			F62C6B9B = AB10510F;
		}
	}

	private sealed class Class161 : DF12521F
	{
		private Class149 class149_0;

		private Class149 class149_1;

		public override object E8BD6697()
		{
			return class149_1.E8BD6697();
		}

		public override void vmethod_12(object BAB172A7)
		{
			class149_1.vmethod_12(BAB172A7);
			class149_0.vmethod_12(class149_1.E8BD6697());
		}

		public override Class149 FB97EC11()
		{
			return new Class161(class149_1, class149_0);
		}

		public override Type vmethod_13()
		{
			return class149_1.vmethod_13();
		}

		public Class161(Class149 class149_2, Class149 D9A0AA9D)
		{
			class149_1 = class149_2;
			class149_0 = D9A0AA9D;
		}
	}

	private sealed class Class152 : Class149
	{
		private sbyte D885D49E;

		public override uint vmethod_2()
		{
			return (uint)D885D49E;
		}

		public override byte vmethod_15()
		{
			return (byte)D885D49E;
		}

		public override Class149 FB97EC11()
		{
			return new Class152(D885D49E);
		}

		public override Type vmethod_13()
		{
			return typeof(sbyte);
		}

		public override object E8BD6697()
		{
			return D885D49E;
		}

		public override void vmethod_12(object BAB172A7)
		{
			D885D49E = Convert.ToSByte(BAB172A7);
		}

		public override ushort vmethod_8()
		{
			return (ushort)D885D49E;
		}

		public override int vmethod_11()
		{
			return D885D49E;
		}

		public override short vmethod_14()
		{
			return D885D49E;
		}

		public override sbyte EFB8C6AD()
		{
			return D885D49E;
		}

		public override Class155 vmethod_5()
		{
			return new Class158(vmethod_11());
		}

		public Class152(sbyte sbyte_0)
		{
			D885D49E = sbyte_0;
		}
	}

	private sealed class EB0EA089 : IDisposable
	{
		private List<GCHandle> AA8054A0 = new List<GCHandle>();

		public void Dispose()
		{
			foreach (GCHandle item in AA8054A0)
			{
				item.Free();
			}
			AA8054A0.Clear();
		}

		public IntPtr E7B233AA(object E887CD8B)
		{
			GCHandle item = GCHandle.Alloc(E887CD8B, GCHandleType.Pinned);
			AA8054A0.Add(item);
			return item.AddrOfPinnedObject();
		}
	}

	private sealed class B2A5B022
	{
		private int C30719AC;

		private int int_0;

		private byte F52238AF;

		public byte CD9C8000()
		{
			return F52238AF;
		}

		public int method_0()
		{
			return C30719AC;
		}

		public int method_1()
		{
			return int_0;
		}

		public B2A5B022(byte byte_0, int B8061924, int int_1)
		{
			F52238AF = byte_0;
			C30719AC = B8061924;
			int_0 = int_1;
		}
	}

	private sealed class Class162 : DF12521F
	{
		private int int_1;

		private Array array_0;

		public override Class149 FB97EC11()
		{
			return new Class162(array_0, int_1);
		}

		public override object E8BD6697()
		{
			return array_0.GetValue(int_1);
		}

		public override Type vmethod_13()
		{
			return array_0.GetType().GetElementType();
		}

		public override void vmethod_12(object B816711B)
		{
			switch (Type.GetTypeCode(vmethod_13()))
			{
			case TypeCode.Char:
				B816711B = Convert.ToChar(B816711B);
				break;
			case TypeCode.SByte:
				B816711B = Convert.ToSByte(B816711B);
				break;
			case TypeCode.Byte:
				B816711B = Convert.ToByte(B816711B);
				break;
			case TypeCode.Int16:
				B816711B = Convert.ToInt16(B816711B);
				break;
			case TypeCode.UInt16:
				B816711B = Convert.ToUInt16(B816711B);
				break;
			case TypeCode.Int32:
				B816711B = Convert.ToInt32(B816711B);
				break;
			case TypeCode.UInt32:
				B816711B = Convert.ToUInt32(B816711B);
				break;
			case TypeCode.Int64:
				B816711B = Convert.ToInt64(B816711B);
				break;
			case TypeCode.UInt64:
				B816711B = Convert.ToUInt64(B816711B);
				break;
			}
			array_0.SetValue(B816711B, int_1);
		}

		public Class162(Array array_1, int F794F21E)
		{
			array_0 = array_1;
			int_1 = F794F21E;
		}
	}

	private sealed class Class153 : Class149
	{
		private char char_0;

		public override ushort vmethod_8()
		{
			return char_0;
		}

		public override int vmethod_11()
		{
			return char_0;
		}

		public override byte vmethod_15()
		{
			return (byte)char_0;
		}

		public override Type vmethod_13()
		{
			return typeof(char);
		}

		public override Class149 FB97EC11()
		{
			return new Class153(char_0);
		}

		public override Class155 vmethod_5()
		{
			return new Class158(vmethod_11());
		}

		public override void vmethod_12(object BAB172A7)
		{
			char_0 = Convert.ToChar(BAB172A7);
		}

		public override uint vmethod_2()
		{
			return char_0;
		}

		public override object E8BD6697()
		{
			return char_0;
		}

		public override short vmethod_14()
		{
			return (short)char_0;
		}

		public override sbyte EFB8C6AD()
		{
			return (sbyte)char_0;
		}

		public Class153(char char_1)
		{
			char_0 = char_1;
		}
	}

	private sealed class A2B1602B : DF12521F
	{
		private Type type_0;

		private IntPtr intptr_0;

		public override long vmethod_3()
		{
			return Marshal.ReadInt64(intptr_0);
		}

		public override sbyte EFB8C6AD()
		{
			return (sbyte)Marshal.ReadByte(intptr_0);
		}

		public override IntPtr F786FC2B()
		{
			return new IntPtr((IntPtr.Size == 4) ? Marshal.ReadInt32(intptr_0) : Marshal.ReadInt64(intptr_0));
		}

		public override UIntPtr vmethod_4()
		{
			return new UIntPtr((ulong)((IntPtr.Size == 4) ? ((uint)Marshal.ReadInt32(intptr_0)) : Marshal.ReadInt64(intptr_0)));
		}

		public override Class149 FB97EC11()
		{
			return new A2B1602B(intptr_0, type_0);
		}

		public override char vmethod_10()
		{
			return (char)Marshal.ReadInt16(intptr_0);
		}

		public override ushort vmethod_8()
		{
			return (ushort)Marshal.ReadInt16(intptr_0);
		}

		public override double vmethod_6()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override Type vmethod_13()
		{
			return typeof(Pointer);
		}

		public override ulong B0B223A4()
		{
			return (ulong)Marshal.ReadInt64(intptr_0);
		}

		public override short vmethod_14()
		{
			return Marshal.ReadInt16(intptr_0);
		}

		public override byte vmethod_15()
		{
			return Marshal.ReadByte(intptr_0);
		}

		public override void vmethod_12(object BDAD5A28)
		{
			if (BDAD5A28 == null)
			{
				throw new ArgumentException();
			}
			if (type_0.IsValueType)
			{
				Marshal.StructureToPtr(BDAD5A28, intptr_0, fDeleteOld: false);
				return;
			}
			switch (Type.GetTypeCode(BDAD5A28.GetType()))
			{
			default:
				throw new ArgumentException();
			case (TypeCode)286262196:
				Marshal.WriteInt16(intptr_0, Convert.ToChar(BDAD5A28));
				break;
			case (TypeCode)286262197:
				Marshal.WriteByte(intptr_0, (byte)Convert.ToSByte(BDAD5A28));
				break;
			case (TypeCode)286262198:
				Marshal.WriteByte(intptr_0, Convert.ToByte(BDAD5A28));
				break;
			case (TypeCode)286262199:
				Marshal.WriteInt16(intptr_0, Convert.ToInt16(BDAD5A28));
				break;
			case (TypeCode)286262200:
				Marshal.WriteInt16(intptr_0, (short)Convert.ToUInt16(BDAD5A28));
				break;
			case (TypeCode)286262201:
				Marshal.WriteInt32(intptr_0, Convert.ToInt32(BDAD5A28));
				break;
			case (TypeCode)286262202:
				Marshal.WriteInt32(intptr_0, (int)Convert.ToUInt32(BDAD5A28));
				break;
			case (TypeCode)286262203:
				Marshal.WriteInt64(intptr_0, Convert.ToInt64(BDAD5A28));
				break;
			case (TypeCode)286262204:
				Marshal.WriteInt64(intptr_0, (long)Convert.ToUInt64(BDAD5A28));
				break;
			case (TypeCode)286262205:
				Marshal.WriteInt32(intptr_0, BitConverter.ToInt32(BitConverter.GetBytes(Convert.ToSingle(BDAD5A28)), 0));
				break;
			case (TypeCode)286262206:
				Marshal.WriteInt64(intptr_0, BitConverter.ToInt64(BitConverter.GetBytes(Convert.ToDouble(BDAD5A28)), 0));
				break;
			}
		}

		public override float vmethod_1()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(intptr_0)), 0);
		}

		public override int vmethod_11()
		{
			return Marshal.ReadInt32(intptr_0);
		}

		public override uint vmethod_2()
		{
			return (uint)Marshal.ReadInt32(intptr_0);
		}

		public override object E8BD6697()
		{
			if (type_0.IsValueType)
			{
				return Marshal.PtrToStructure(intptr_0, type_0);
			}
			return Type.GetTypeCode(type_0) switch
			{
				TypeCode.Char => (char)Marshal.ReadInt16(intptr_0), 
				TypeCode.SByte => (sbyte)Marshal.ReadByte(intptr_0), 
				TypeCode.Byte => Marshal.ReadByte(intptr_0), 
				TypeCode.Int16 => Marshal.ReadInt16(intptr_0), 
				TypeCode.UInt16 => (ushort)Marshal.ReadInt16(intptr_0), 
				TypeCode.Int32 => Marshal.ReadInt32(intptr_0), 
				TypeCode.UInt32 => (uint)Marshal.ReadInt32(intptr_0), 
				TypeCode.Int64 => Marshal.ReadInt64(intptr_0), 
				TypeCode.UInt64 => (ulong)Marshal.ReadInt64(intptr_0), 
				TypeCode.Single => BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(intptr_0)), 0), 
				TypeCode.Double => BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0), 
				_ => throw new ArgumentException(), 
			};
		}

		public A2B1602B(IntPtr intptr_1, Type AF36279B)
		{
			intptr_0 = intptr_1;
			type_0 = AF36279B;
		}
	}

	private sealed class Class158 : Class155
	{
		private int FE8F980F;

		public override char vmethod_10()
		{
			return (char)FE8F980F;
		}

		public override UIntPtr vmethod_4()
		{
			return new UIntPtr((uint)FE8F980F);
		}

		public override byte vmethod_15()
		{
			return (byte)FE8F980F;
		}

		public override int vmethod_11()
		{
			return FE8F980F;
		}

		public static Class149 smethod_1(Class149 class149_0, Class149 A98B4E9F)
		{
			uint num = class149_0.vmethod_2();
			uint num2 = A98B4E9F.vmethod_2();
			return new Class158((int)(num + num2));
		}

		public override object E8BD6697()
		{
			return FE8F980F;
		}

		public static Class149 smethod_2(Class149 class149_0, Class149 class149_1)
		{
			uint num = ~class149_0.vmethod_2();
			_ = ~class149_1.vmethod_2();
			return new Class158((int)num | -1);
		}

		public static Class149 F5936B84(Class149 A582E2A3, Class149 class149_0)
		{
			if (((uint)class149_0.F201FE8B() & 8u) != 0)
			{
				uint num = A582E2A3.vmethod_2();
				uint num2 = class149_0.vmethod_2();
				return new Class158((int)(num % num2));
			}
			int num3 = A582E2A3.vmethod_11();
			int num4 = class149_0.vmethod_11();
			return new Class158(num3 % num4);
		}

		public override sbyte EFB8C6AD()
		{
			return (sbyte)FE8F980F;
		}

		public static Class149 smethod_3(Class149 class149_0, Class149 ED8EA7AA)
		{
			uint num = ~class149_0.vmethod_2();
			_ = ~ED8EA7AA.vmethod_2();
			return new Class158((int)num & -1);
		}

		public override double vmethod_6()
		{
			return FE8F980F;
		}

		public static Class149 smethod_4(Class149 class149_0, Class149 class149_1)
		{
			if ((class149_1.F201FE8B() & 8) == 0)
			{
			}
			uint num = class149_0.vmethod_2();
			int num2 = class149_1.vmethod_11();
			return new Class158((int)(num >> num2));
		}

		public override uint vmethod_2()
		{
			return (uint)FE8F980F;
		}

		public override IntPtr F786FC2B()
		{
			return new IntPtr(FE8F980F);
		}

		public override Class149 FB97EC11()
		{
			Class158 @class = new Class158(FE8F980F);
			@class.F003DD86(F201FE8B());
			return @class;
		}

		public static Class149 smethod_5(Class149 CD87A326, Class149 class149_0)
		{
			int num = 0;
			if (((uint)class149_0.F201FE8B() & 8u) != 0)
			{
				uint num2 = CD87A326.vmethod_2();
				uint num3 = class149_0.vmethod_2();
				if (num2 == num3)
				{
					num |= 4;
				}
				else if (num2 < num3)
				{
					num |= 0x40;
				}
			}
			else
			{
				int num4 = CD87A326.vmethod_11();
				int num5 = class149_0.vmethod_11();
				if (num4 == num5)
				{
					num |= 4;
				}
				else if (num4 < num5)
				{
					num |= 0x40;
				}
			}
			return new Class158(num);
		}

		public override ushort vmethod_8()
		{
			return (ushort)FE8F980F;
		}

		public override ulong B0B223A4()
		{
			return (uint)FE8F980F;
		}

		public static Class149 smethod_6(Class149 AC9E73A4)
		{
			return new Class158(AC9E73A4.vmethod_11());
		}

		public static Class149 smethod_7(Class149 class149_0, Class149 DE2DD58E)
		{
			if (((uint)DE2DD58E.F201FE8B() & 8u) != 0)
			{
				uint num = class149_0.vmethod_2();
				uint num2 = DE2DD58E.vmethod_2();
				return new Class158((int)(num / num2));
			}
			int num3 = class149_0.vmethod_11();
			int num4 = DE2DD58E.vmethod_11();
			return new Class158(num3 / num4);
		}

		public override long vmethod_3()
		{
			return FE8F980F;
		}

		public override short vmethod_14()
		{
			return (short)FE8F980F;
		}

		public override Type vmethod_13()
		{
			return typeof(int);
		}

		public static Class149 smethod_8(Class149 A796D79E, Class149 D0251B20)
		{
			if (((uint)D0251B20.F201FE8B() & 8u) != 0)
			{
				long num = A796D79E.vmethod_2();
				ulong num2 = D0251B20.vmethod_2();
				long num3 = num * (long)num2;
				Class158 @class = new Class158((int)num3);
				if (num3 != (uint)num3)
				{
					@class.F003DD86(32);
				}
				return @class;
			}
			long num4 = A796D79E.vmethod_11();
			long num5 = D0251B20.vmethod_11();
			long num6 = num4 * num5;
			Class158 class2 = new Class158((int)num6);
			if (num6 != (int)num6)
			{
				class2.F003DD86(1);
			}
			return class2;
		}

		public override void vmethod_12(object BAB172A7)
		{
			FE8F980F = Convert.ToInt32(BAB172A7);
		}

		public override float vmethod_1()
		{
			return FE8F980F;
		}

		public static Class149 C2965D3D(Class149 class149_0, Class149 class149_1)
		{
			int num = class149_0.vmethod_11();
			int num2 = class149_1.vmethod_11();
			return new Class158(num << num2);
		}

		public override bool vmethod_9()
		{
			return FE8F980F != 0;
		}

		public Class158(int int_1)
		{
			FE8F980F = int_1;
		}
	}

	private sealed class Class170 : Class168
	{
		private Stack<int> FD9E019F = new Stack<int>();

		private List<Class175> CF880C80 = new List<Class175>();

		public int method_0()
		{
			return FD9E019F.Count;
		}

		public Class175 method_1()
		{
			return CF880C80[FD9E019F.Peek()];
		}

		public Class175 method_2()
		{
			return CF880C80[FD9E019F.Pop()];
		}

		public override int vmethod_1()
		{
			return 0;
		}

		public override void vmethod_0(int A6B49F3B)
		{
			for (int i = 0; i < CF880C80.Count; i++)
			{
				if (CF880C80[i].A015A326() == A6B49F3B)
				{
					FD9E019F.Push(i);
				}
			}
		}

		public void method_3(int D6AB8E33, int C93E1514, byte C1B438BF, int DC023703, int int_0)
		{
			Class175 @class = null;
			for (int i = 0; i < CF880C80.Count; i++)
			{
				Class175 class2 = CF880C80[i];
				if (class2.A015A326() == D6AB8E33 && class2.D606C3A8() == C93E1514)
				{
					@class = class2;
					break;
				}
			}
			if (@class == null)
			{
				bool flag = false;
				@class = new Class175(D6AB8E33, C93E1514);
				for (int j = 0; j < CF880C80.Count; j++)
				{
					Class175 b48A = CF880C80[j];
					if (@class.method_0(b48A) < 0)
					{
						CF880C80.Insert(j, @class);
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					CF880C80.Add(@class);
				}
			}
			@class.C203AE36(C1B438BF, DC023703, int_0);
		}
	}

	private sealed class Class159 : Class155
	{
		private object object_0;

		public static Class149 smethod_1(Class149 DB340C11, Class149 class149_0)
		{
			object obj = DB340C11.E8BD6697();
			object obj2 = class149_0.E8BD6697();
			int num = 0;
			if (obj == obj2)
			{
				num |= 4;
			}
			else if (obj == null)
			{
				num |= 0x40;
			}
			return new Class158(num);
		}

		public override void vmethod_12(object BAB172A7)
		{
			object_0 = BAB172A7;
		}

		public override Type vmethod_13()
		{
			return typeof(object);
		}

		public override Class149 FB97EC11()
		{
			return new Class159(object_0);
		}

		public override object E8BD6697()
		{
			return object_0;
		}

		public Class159(object A2A6108F)
		{
			object_0 = A2A6108F;
		}
	}

	private abstract class Class149
	{
		private int int_0;

		public virtual bool vmethod_0()
		{
			return false;
		}

		public virtual float vmethod_1()
		{
			return Convert.ToSingle(E8BD6697());
		}

		public virtual uint vmethod_2()
		{
			return Convert.ToUInt32(E8BD6697());
		}

		public abstract object E8BD6697();

		public virtual long vmethod_3()
		{
			return Convert.ToInt64(E8BD6697());
		}

		public virtual UIntPtr vmethod_4()
		{
			object obj = E8BD6697();
			if (!(obj?.GetType() == typeof(UIntPtr)))
			{
				throw new InvalidOperationException();
			}
			return (UIntPtr)obj;
		}

		public virtual Class155 vmethod_5()
		{
			throw new InvalidOperationException();
		}

		public virtual object D42BD616(FieldInfo A51CCF2C)
		{
			object obj = E8BD6697();
			if (obj != null && A51CCF2C.DeclaringType.IsValueType && obj.GetType().IsPrimitive)
			{
				obj = Marshal.PtrToStructure(F786FC2B(), A51CCF2C.DeclaringType);
			}
			return A51CCF2C.GetValue(obj);
		}

		public virtual double vmethod_6()
		{
			return Convert.ToDouble(E8BD6697());
		}

		public virtual void vmethod_7(FieldInfo fieldInfo_0, object CF806824)
		{
			object obj = E8BD6697();
			if (obj != null && fieldInfo_0.DeclaringType.IsValueType && obj.GetType().IsPrimitive)
			{
				obj = Marshal.PtrToStructure(F786FC2B(), fieldInfo_0.DeclaringType);
			}
			fieldInfo_0.SetValue(obj, CF806824);
			if (obj is ValueType)
			{
				vmethod_12(obj);
			}
		}

		public virtual sbyte EFB8C6AD()
		{
			return Convert.ToSByte(E8BD6697());
		}

		public virtual ushort vmethod_8()
		{
			return Convert.ToUInt16(E8BD6697());
		}

		public virtual bool vmethod_9()
		{
			return Convert.ToBoolean(E8BD6697());
		}

		public virtual char vmethod_10()
		{
			return Convert.ToChar(E8BD6697());
		}

		public virtual int vmethod_11()
		{
			return Convert.ToInt32(E8BD6697());
		}

		public static Class149 C7B9E73B(Class149 class149_0, Type B28F9D98)
		{
			object obj = class149_0.E8BD6697();
			int num = 0;
			if (obj == null)
			{
				num |= 4;
			}
			else
			{
				Type type = obj.GetType();
				if (type == B28F9D98 || B28F9D98.IsAssignableFrom(type))
				{
					num |= 4;
				}
			}
			return new Class158(num);
		}

		public virtual void F003DD86(int B82CE3BE)
		{
			int_0 = B82CE3BE;
		}

		public abstract void vmethod_12(object BAB172A7);

		public virtual ulong B0B223A4()
		{
			return Convert.ToUInt64(E8BD6697());
		}

		public virtual IntPtr F786FC2B()
		{
			object obj = E8BD6697();
			if (!(obj?.GetType() == typeof(IntPtr)))
			{
				throw new InvalidOperationException();
			}
			return (IntPtr)obj;
		}

		public unsafe Class149 method_0(Type E7B62534)
		{
			if (E7B62534.IsEnum)
			{
				object obj = E8BD6697();
				if (obj != null && !(obj is Enum))
				{
					obj = Enum.ToObject(E7B62534, obj);
				}
				return new Class156((Enum)obj);
			}
			switch (Type.GetTypeCode(E7B62534))
			{
			default:
				if (E7B62534 == typeof(IntPtr))
				{
					return new C3ADD934(F786FC2B());
				}
				if (E7B62534 == typeof(UIntPtr))
				{
					return new Class165(vmethod_4());
				}
				if (E7B62534.IsValueType)
				{
					return new B4397D18(E8BD6697());
				}
				if (E7B62534.IsPointer)
				{
					return new AA1B6114(Pointer.Box(F786FC2B().ToPointer(), E7B62534), E7B62534);
				}
				return new Class159(E8BD6697());
			case TypeCode.Boolean:
				return new Class167(vmethod_9());
			case TypeCode.Char:
				return new Class153(vmethod_10());
			case TypeCode.SByte:
				return new Class152(EFB8C6AD());
			case TypeCode.Byte:
				return new Class150(vmethod_15());
			case TypeCode.Int16:
				return new D62331BF(vmethod_14());
			case TypeCode.UInt16:
				return new Class154(vmethod_8());
			case TypeCode.Int32:
				return new Class158(vmethod_11());
			case TypeCode.UInt32:
				return new Class166(vmethod_2());
			case TypeCode.Int64:
				return new C489BE26(vmethod_3());
			case TypeCode.UInt64:
				return new Class151(B0B223A4());
			case TypeCode.Single:
				return new DAA2CBAF(vmethod_1());
			case TypeCode.Double:
				return new AA0E549A(vmethod_6());
			}
		}

		public virtual Type vmethod_13()
		{
			throw new InvalidOperationException();
		}

		public static Class149 smethod_0(Class149 class149_0)
		{
			int num = 0;
			if (((uint)class149_0.F201FE8B() & 8u) != 0)
			{
				float f = class149_0.vmethod_1();
				if (float.IsNaN(f) || float.IsInfinity(f))
				{
					num |= 1;
				}
			}
			else
			{
				double d = class149_0.vmethod_6();
				if (double.IsNaN(d) || double.IsInfinity(d))
				{
					num |= 1;
				}
			}
			return new Class158(num);
		}

		public virtual int F201FE8B()
		{
			return int_0;
		}

		public static Class149 C6208FB5(object D426FBA4, Type C2279CAF)
		{
			if (C2279CAF.IsEnum)
			{
				if (D426FBA4 == null)
				{
					goto IL_0061;
				}
			}
			else
			{
				switch (Type.GetTypeCode(C2279CAF))
				{
				case (TypeCode)(-1870672439):
					return new Class167(Convert.ToBoolean(D426FBA4));
				case (TypeCode)(-1870672438):
					return new Class153(Convert.ToChar(D426FBA4));
				case (TypeCode)(-1870672437):
					return new Class152(Convert.ToSByte(D426FBA4));
				case (TypeCode)(-1870672436):
					return new Class150(Convert.ToByte(D426FBA4));
				case (TypeCode)(-1870672435):
					return new D62331BF(Convert.ToInt16(D426FBA4));
				case (TypeCode)(-1870672434):
					return new Class154(Convert.ToUInt16(D426FBA4));
				case (TypeCode)(-1870672433):
					return new Class158(Convert.ToInt32(D426FBA4));
				case (TypeCode)(-1870672432):
					return new Class166(Convert.ToUInt32(D426FBA4));
				case (TypeCode)(-1870672431):
					return new C489BE26(Convert.ToInt64(D426FBA4));
				case (TypeCode)(-1870672430):
					return new Class151(Convert.ToUInt64(D426FBA4));
				case (TypeCode)(-1870672429):
					return new DAA2CBAF(Convert.ToSingle(D426FBA4));
				case (TypeCode)(-1870672428):
					return new AA0E549A(Convert.ToDouble(D426FBA4));
				}
			}
			if (!(D426FBA4 is Enum))
			{
				D426FBA4 = Enum.ToObject(C2279CAF, D426FBA4);
			}
			goto IL_0061;
			IL_0061:
			return new Class156((Enum)D426FBA4);
		}

		public virtual short vmethod_14()
		{
			return Convert.ToInt16(E8BD6697());
		}

		public virtual byte vmethod_15()
		{
			return Convert.ToByte(E8BD6697());
		}

		public abstract Class149 FB97EC11();
	}

	private sealed class Class171 : Class168
	{
		private uint uint_0;

		private Stack<int> B68C1C88 = new Stack<int>();

		private uint uint_1;

		public float B0263A0F()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(BB883E02()), 0);
		}

		public int method_0()
		{
			return B68C1C88.Count;
		}

		public override void vmethod_0(int A6B49F3B)
		{
			uint_0 = (uint)A6B49F3B;
			uint_1 = uint_0;
		}

		public void BCADAFBF()
		{
			vmethod_0(B68C1C88.Pop());
		}

		public unsafe byte method_1()
		{
			uint_0--;
			byte b = *(byte*)(void*)Class177.D19FF531(uint_0);
			b = (byte)(b ^ uint_1);
			b = (byte)(b + 150);
			b = (byte)(~(((uint)b >> 1) | (uint)(b << 7)));
			b = (byte)((uint)(b << 1) | ((uint)b >> 7));
			uint_1 ^= b;
			return b;
		}

		public unsafe short method_2()
		{
			uint_0 -= 2u;
			ushort num = *(ushort*)(void*)Class177.D19FF531(uint_0);
			num = (ushort)(num ^ uint_1);
			num = (ushort)((~(num + 54590) ^ 0xA823) + 57896);
			uint_1 ^= num;
			return (short)num;
		}

		public void method_3(int int_0)
		{
			B68C1C88.Push(int_0);
		}

		public unsafe byte method_4()
		{
			uint_0--;
			byte b = *(byte*)(void*)Class177.D19FF531(uint_0);
			b = (byte)(b ^ uint_1);
			b = (byte)(~(((uint)b >> 1) | (uint)(b << 7)) - 150);
			b = (byte)(~((((uint)(b << 1) | ((uint)b >> 7)) - 1) ^ 9));
			uint_1 ^= b;
			return b;
		}

		public double method_5()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(method_7()), 0);
		}

		public void method_6()
		{
			B68C1C88.Clear();
			uint_1 = 0u;
			uint_0 = 0u;
		}

		public unsafe long method_7()
		{
			uint_0 -= 8u;
			return *(long*)(void*)Class177.D19FF531(uint_0);
		}

		public unsafe int BB883E02()
		{
			uint_0 -= 4u;
			uint num = *(uint*)(void*)Class177.D19FF531(uint_0);
			num ^= uint_1;
			num = 0 - (num + 1361972268);
			num = 0 - ~(((num & 0xFF000000u) >> 24) | ((num & 0xFF0000) >> 8) | ((num & 0xFF00) << 8) | ((num & 0xFF) << 24));
			uint_1 ^= num;
			return (int)num;
		}

		public override int vmethod_1()
		{
			return (int)uint_0;
		}
	}

	private abstract class Class168
	{
		public abstract void vmethod_0(int A6B49F3B);

		public abstract int vmethod_1();
	}

	private abstract class DF12521F : Class155
	{
		public override bool vmethod_0()
		{
			return true;
		}
	}

	private sealed class DAA2CBAF : Class155
	{
		private float float_0;

		public override uint vmethod_2()
		{
			return (uint)float_0;
		}

		public override void vmethod_12(object A30E85BD)
		{
			float_0 = Convert.ToSingle(A30E85BD);
		}

		public static Class149 smethod_1(Class149 E6B538AB, Class149 BA0AE832)
		{
			float num = E6B538AB.vmethod_1();
			float num2 = BA0AE832.vmethod_1();
			return new DAA2CBAF(num + num2);
		}

		public override byte vmethod_15()
		{
			return (byte)float_0;
		}

		public override short vmethod_14()
		{
			return (short)float_0;
		}

		public override int vmethod_11()
		{
			return (int)float_0;
		}

		public override IntPtr F786FC2B()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((int)float_0) : ((long)float_0));
		}

		public override bool vmethod_9()
		{
			return Convert.ToBoolean(float_0);
		}

		public override ulong B0B223A4()
		{
			return (ulong)float_0;
		}

		public override long vmethod_3()
		{
			return (long)float_0;
		}

		public override float vmethod_1()
		{
			return float_0;
		}

		public override Class149 FB97EC11()
		{
			return new DAA2CBAF(float_0);
		}

		public override UIntPtr vmethod_4()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((uint)float_0) : ((ulong)float_0));
		}

		public override ushort vmethod_8()
		{
			return (ushort)float_0;
		}

		public override double vmethod_6()
		{
			return float_0;
		}

		public override Type vmethod_13()
		{
			return typeof(float);
		}

		public override char vmethod_10()
		{
			return (char)float_0;
		}

		public override object E8BD6697()
		{
			return float_0;
		}

		public static Class149 A7876229(Class149 class149_0)
		{
			return new DAA2CBAF(0f - class149_0.vmethod_1());
		}

		public override sbyte EFB8C6AD()
		{
			return (sbyte)float_0;
		}

		public static Class149 CF117A89(Class149 class149_0, Class149 class149_1)
		{
			float num = class149_0.vmethod_1();
			float num2 = class149_1.vmethod_1();
			return new DAA2CBAF(num % num2);
		}

		public static Class149 smethod_2(Class149 F02E6328)
		{
			ulong num = F02E6328.B0B223A4();
			return new DAA2CBAF((((uint)F02E6328.F201FE8B() & 8u) != 0) ? ((float)num) : ((float)(long)num));
		}

		public static Class149 smethod_3(Class149 D03B8385, Class149 class149_0)
		{
			float num = D03B8385.vmethod_1();
			float num2 = class149_0.vmethod_1();
			return new DAA2CBAF(num / num2);
		}

		public static Class149 smethod_4(Class149 class149_0, Class149 class149_1)
		{
			float num = class149_0.vmethod_1();
			float num2 = class149_1.vmethod_1();
			return new DAA2CBAF(num / num2);
		}

		public static Class149 smethod_5(Class149 A60F4AA6)
		{
			return new DAA2CBAF(A60F4AA6.vmethod_1());
		}

		public static Class149 smethod_6(Class149 class149_0, Class149 C12BC9B2)
		{
			float num = class149_0.vmethod_1();
			float num2 = C12BC9B2.vmethod_1();
			int num3 = 0;
			if (num == num2)
			{
				num3 |= 4;
			}
			else if (num < num2)
			{
				num3 |= 0x40;
			}
			return new Class158(num3);
		}

		public DAA2CBAF(float float_1)
		{
			float_0 = float_1;
		}
	}

	private sealed class Class154 : Class149
	{
		private ushort B3BEF615;

		public override Type vmethod_13()
		{
			return typeof(ushort);
		}

		public override int vmethod_11()
		{
			return B3BEF615;
		}

		public override byte vmethod_15()
		{
			return (byte)B3BEF615;
		}

		public override sbyte EFB8C6AD()
		{
			return (sbyte)B3BEF615;
		}

		public override ushort vmethod_8()
		{
			return B3BEF615;
		}

		public override Class149 FB97EC11()
		{
			return new Class154(B3BEF615);
		}

		public override short vmethod_14()
		{
			return (short)B3BEF615;
		}

		public override Class155 vmethod_5()
		{
			return new Class158(vmethod_11());
		}

		public override object E8BD6697()
		{
			return B3BEF615;
		}

		public override uint vmethod_2()
		{
			return B3BEF615;
		}

		public override void vmethod_12(object BAB172A7)
		{
			B3BEF615 = Convert.ToUInt16(BAB172A7);
		}

		public Class154(ushort ushort_0)
		{
			B3BEF615 = ushort_0;
		}
	}

	private sealed class Class172
	{
		private enum E12E6097
		{
			F28D1A81 = 3,
			D43F8C00 = 10,
			F30357AA = 0x20,
			const_3 = 21,
			const_4 = 0xF,
			F813D626 = 65,
			const_6 = 24,
			B91A488E = 0x1F,
			const_8 = 69,
			const_9 = 8,
			const_10 = 1,
			const_11 = 14,
			D727CB9F = 9,
			const_13 = 26,
			A007C6BB = 13,
			F685D282 = 0x10,
			const_16 = 28,
			const_17 = 20,
			const_18 = 6,
			const_19 = 19,
			const_20 = 29,
			const_21 = 22,
			const_22 = 17,
			AA843719 = 0,
			CD0A2C10 = 7,
			const_25 = 18,
			E82497B7 = 11,
			EDB2878A = 23,
			const_28 = 30,
			const_29 = 12,
			const_30 = 25,
			const_31 = 2,
			AD1FF6BE = 5,
			E7037138 = 27,
			const_34 = 4
		}

		private int C407C730;

		private byte[] byte_0;

		public Type method_0(Module module_0)
		{
			bool flag = false;
			bool flag2 = true;
			while (flag2)
			{
				E12E6097 e12E = (E12E6097)method_1();
				if (e12E <= (E12E6097)1452710918)
				{
					switch (e12E)
					{
					case (E12E6097)(-1595347707):
					case (E12E6097)(-1595347706):
						F78A4DB3();
						continue;
					case (E12E6097)(-1595347702):
						flag = true;
						continue;
					}
				}
				else if (e12E == (E12E6097)3522512 || e12E == (E12E6097)1854450)
				{
					continue;
				}
				flag2 = false;
				C407C730--;
			}
			Type type;
			switch (F78A4DB3())
			{
			case 0u:
				type = null;
				break;
			case 1u:
				type = typeof(void);
				break;
			case 2u:
				type = typeof(bool);
				break;
			case 3u:
				type = typeof(char);
				break;
			case 4u:
				type = typeof(sbyte);
				break;
			case 5u:
				type = typeof(byte);
				break;
			case 6u:
				type = typeof(short);
				break;
			case 7u:
				type = typeof(ushort);
				break;
			case 8u:
				type = typeof(int);
				break;
			case 9u:
				type = typeof(uint);
				break;
			case 10u:
				type = typeof(long);
				break;
			case 11u:
				type = typeof(ulong);
				break;
			case 12u:
				type = typeof(float);
				break;
			case 13u:
				type = typeof(double);
				break;
			case 14u:
				type = typeof(string);
				break;
			case 15u:
				type = method_0(module_0).MakePointerType();
				break;
			case 17u:
			case 18u:
			{
				uint num = F78A4DB3();
				switch (num & 3)
				{
				}
				type = module_0.ResolveType((int)(0 | (num >> 2)));
				break;
			}
			case 24u:
				type = typeof(IntPtr);
				break;
			case 25u:
				type = typeof(UIntPtr);
				break;
			default:
				throw new COMException(null, -2146233785);
			case 28u:
				type = typeof(object);
				break;
			case 29u:
				type = method_0(module_0).MakeArrayType();
				break;
			}
			if (flag)
			{
				type = type.MakeByRefType();
			}
			return type;
		}

		public byte method_1()
		{
			return byte_0[C407C730++];
		}

		public uint F78A4DB3()
		{
			byte b = byte_0[C407C730];
			if ((b & 0x80) == 0)
			{
				C407C730++;
			}
			else if ((b & 0x40) == 0)
			{
				C407C730 += 2;
			}
			else
			{
				C407C730 += 4;
			}
			return 0u;
		}

		public Class172(byte[] A89E8DBF)
		{
			byte_0 = A89E8DBF;
		}
	}

	private enum Enum2
	{
		const_0 = 0x20,
		F505E1AA = 9,
		const_2 = 8,
		C6399396 = 7,
		const_4 = 1,
		C2A120A3 = 3,
		C4ABB685 = 0x10,
		const_7 = 4,
		EE9996A9 = 11,
		const_9 = 10,
		const_10 = 2,
		const_11 = 0,
		const_12 = 6,
		F58BE91A = 0xF,
		E195FAB3 = 0x40,
		F036E39A = 5
	}

	private sealed class AA1B6114 : Class149
	{
		private Type type_0;

		private object object_0;

		public unsafe override Class155 vmethod_5()
		{
			return new C3ADD934((object_0 == null) ? IntPtr.Zero : new IntPtr(Pointer.Unbox(object_0)));
		}

		public override void vmethod_12(object BAB172A7)
		{
			object_0 = BAB172A7;
		}

		public override Type vmethod_13()
		{
			return type_0;
		}

		public override Class149 FB97EC11()
		{
			return new AA1B6114(object_0, type_0);
		}

		public override object E8BD6697()
		{
			return object_0;
		}

		public AA1B6114(object object_1, Type FF129603)
		{
			object_0 = object_1;
			type_0 = FF129603;
		}
	}

	private sealed class Class163 : DF12521F
	{
		private Class149 class149_0;

		public override Type vmethod_13()
		{
			return class149_0.vmethod_13();
		}

		public override void vmethod_12(object BAB172A7)
		{
			class149_0.vmethod_12(BAB172A7);
		}

		public override object E8BD6697()
		{
			return class149_0.E8BD6697();
		}

		public override Class149 FB97EC11()
		{
			return new Class163(class149_0);
		}

		public override object D42BD616(FieldInfo A51CCF2C)
		{
			return class149_0.D42BD616(A51CCF2C);
		}

		public override void vmethod_7(FieldInfo fieldInfo_0, object C8191691)
		{
			class149_0.vmethod_7(fieldInfo_0, C8191691);
		}

		public Class163(Class149 class149_1)
		{
			class149_0 = class149_1;
		}
	}

	private sealed class AA0E549A : Class155
	{
		private double double_0;

		public override uint vmethod_2()
		{
			return (uint)double_0;
		}

		public override ushort vmethod_8()
		{
			return (ushort)double_0;
		}

		public override long vmethod_3()
		{
			return (long)double_0;
		}

		public override double vmethod_6()
		{
			return double_0;
		}

		public static Class149 smethod_1(Class149 class149_0, Class149 BE8A9602)
		{
			double num = class149_0.vmethod_6();
			double num2 = BE8A9602.vmethod_6();
			return new AA0E549A(num * num2);
		}

		public static Class149 smethod_2(Class149 class149_0)
		{
			double num = class149_0.vmethod_6();
			ulong num2 = (ulong)(long)num;
			int num3 = 0;
			if (((uint)class149_0.F201FE8B() & 8u) != 0)
			{
				if (!(num > -1.0) || !(num < 1.8446744073709552E+19))
				{
					num3 |= 1;
				}
				if (!((double)num2 < 9.2233720368547758E+18))
				{
					num2 = (ulong)((double)(long)num2 - 9.2233720368547758E+18) + 9223372036854775808uL;
				}
			}
			else if (!(num > -9.2233720368547779E+18) || !(num < 9.2233720368547758E+18))
			{
				num3 |= 1;
			}
			class149_0 = new C489BE26((long)num2);
			class149_0.F003DD86(num3);
			return class149_0;
		}

		public override bool vmethod_9()
		{
			return Convert.ToBoolean(double_0);
		}

		public override short vmethod_14()
		{
			return (short)double_0;
		}

		public override Class149 FB97EC11()
		{
			return new AA0E549A(double_0);
		}

		public override IntPtr F786FC2B()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((int)double_0) : ((long)double_0));
		}

		public override object E8BD6697()
		{
			return double_0;
		}

		public override char vmethod_10()
		{
			return (char)double_0;
		}

		public static Class149 smethod_3(Class149 class149_0, Class149 class149_1)
		{
			double num = class149_0.vmethod_6();
			double num2 = class149_1.vmethod_6();
			return new AA0E549A(num % num2);
		}

		public static Class149 smethod_4(Class149 D8098DB8, Class149 class149_0)
		{
			double num = D8098DB8.vmethod_6();
			double num2 = class149_0.vmethod_6();
			return new AA0E549A(num / num2);
		}

		public override float vmethod_1()
		{
			return (float)double_0;
		}

		public override int vmethod_11()
		{
			return (int)double_0;
		}

		public override Type vmethod_13()
		{
			return typeof(double);
		}

		public override UIntPtr vmethod_4()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((uint)double_0) : ((ulong)double_0));
		}

		public static Class149 D89C8F03(Class149 FC2CC087)
		{
			return new AA0E549A(FC2CC087.vmethod_6());
		}

		public static Class149 F604B2BD(Class149 F789D02A)
		{
			ulong num = F789D02A.B0B223A4();
			return new AA0E549A((((uint)F789D02A.F201FE8B() & 8u) != 0) ? ((double)num) : ((double)(long)num));
		}

		public static Class149 smethod_5(Class149 B38FEFB2, Class149 ADB47933)
		{
			double num = B38FEFB2.vmethod_6();
			double num2 = ADB47933.vmethod_6();
			return new AA0E549A(num + num2);
		}

		public override sbyte EFB8C6AD()
		{
			return (sbyte)double_0;
		}

		public override byte vmethod_15()
		{
			return (byte)double_0;
		}

		public override void vmethod_12(object E5805B93)
		{
			double_0 = (double)E5805B93;
		}

		public static Class149 smethod_6(Class149 class149_0, Class149 class149_1)
		{
			double num = class149_0.vmethod_6();
			double num2 = class149_1.vmethod_6();
			int num3 = 0;
			if (num == num2)
			{
				num3 |= 4;
			}
			else if (num < num2)
			{
				num3 |= 0x40;
			}
			return new Class158(num3);
		}

		public override ulong B0B223A4()
		{
			return (ulong)double_0;
		}

		public static Class149 smethod_7(Class149 B0B1C528)
		{
			return new AA0E549A(0.0 - B0B1C528.vmethod_6());
		}

		public AA0E549A(double FB99DE1F)
		{
			double_0 = FB99DE1F;
		}
	}

	private abstract class Class155 : Class149
	{
		public override Class155 vmethod_5()
		{
			return this;
		}
	}

	internal delegate void Delegate1();

	private sealed class C3ADD934 : Class155
	{
		private Class149 class149_0;

		private IntPtr intptr_0;

		public override long vmethod_3()
		{
			return class149_0.vmethod_3();
		}

		public static Class149 smethod_1(Class149 A22C6509, Class149 class149_1)
		{
			if (IntPtr.Size != 4)
			{
				return C489BE26.smethod_2(A22C6509, class149_1);
			}
			return Class158.C2965D3D(A22C6509, class149_1);
		}

		public override Type vmethod_13()
		{
			return typeof(IntPtr);
		}

		public override ushort vmethod_8()
		{
			return class149_0.vmethod_8();
		}

		public static Class149 E6B4ED25(Class149 class149_1, Class149 class149_2)
		{
			if (IntPtr.Size != 4)
			{
				return C489BE26.smethod_5(class149_1, class149_2);
			}
			return Class158.smethod_7(class149_1, class149_2);
		}

		public override int vmethod_11()
		{
			return class149_0.vmethod_11();
		}

		public override bool vmethod_9()
		{
			return intptr_0 != IntPtr.Zero;
		}

		public override short vmethod_14()
		{
			return class149_0.vmethod_14();
		}

		public static Class149 E4B3FE2A(Class149 A4AA0913, Class149 B22C2184)
		{
			if (IntPtr.Size != 4)
			{
				return C489BE26.CB18189A(A4AA0913, B22C2184);
			}
			return Class158.F5936B84(A4AA0913, B22C2184);
		}

		public static Class149 smethod_2(Class149 C60F0225, Class149 class149_1)
		{
			if (IntPtr.Size != 4)
			{
				return C489BE26.A4141B3A(C60F0225, class149_1);
			}
			return Class158.smethod_5(C60F0225, class149_1);
		}

		public static Class149 smethod_3(Class149 F301E43E, Class149 F1B4D6A0)
		{
			if (IntPtr.Size != 4)
			{
				return C489BE26.smethod_4(F301E43E, F1B4D6A0);
			}
			return Class158.smethod_4(F301E43E, F1B4D6A0);
		}

		public static Class149 C6A8D19D(Class149 class149_1, Class149 class149_2)
		{
			if (IntPtr.Size != 4)
			{
				return C489BE26.smethod_3(class149_1, class149_2);
			}
			return Class158.smethod_1(class149_1, class149_2);
		}

		public static Class149 smethod_4(Class149 DD9A9BB0, Class149 class149_1)
		{
			if (IntPtr.Size != 4)
			{
				return C489BE26.C4AF3B31(DD9A9BB0, class149_1);
			}
			return Class158.smethod_8(DD9A9BB0, class149_1);
		}

		public override byte vmethod_15()
		{
			return class149_0.vmethod_15();
		}

		public override double vmethod_6()
		{
			return class149_0.vmethod_6();
		}

		public static Class149 smethod_5(Class149 AD2E8683, Class149 F492A49F)
		{
			if (IntPtr.Size != 4)
			{
				return C489BE26.smethod_1(AD2E8683, F492A49F);
			}
			return Class158.smethod_2(AD2E8683, F492A49F);
		}

		public override void vmethod_12(object BAB172A7)
		{
			intptr_0 = (IntPtr)BAB172A7;
			class149_0 = smethod_6(intptr_0);
		}

		public override UIntPtr vmethod_4()
		{
			return class149_0.vmethod_4();
		}

		public override IntPtr F786FC2B()
		{
			return intptr_0;
		}

		private static Class149 smethod_6(IntPtr intptr_1)
		{
			if (IntPtr.Size == 4)
			{
				return new Class158(intptr_1.ToInt32());
			}
			return new C489BE26(intptr_1.ToInt64());
		}

		public override float vmethod_1()
		{
			return class149_0.vmethod_1();
		}

		public override object E8BD6697()
		{
			return intptr_0;
		}

		public override ulong B0B223A4()
		{
			return class149_0.B0B223A4();
		}

		public static Class149 smethod_7(Class149 AE196D13)
		{
			if (IntPtr.Size != 4)
			{
				return C489BE26.smethod_6(AE196D13);
			}
			return Class158.smethod_6(AE196D13);
		}

		public override uint vmethod_2()
		{
			return class149_0.vmethod_2();
		}

		public override Class149 FB97EC11()
		{
			return new C3ADD934(intptr_0);
		}

		public override sbyte EFB8C6AD()
		{
			return class149_0.EFB8C6AD();
		}

		public static Class149 A51173A3(Class149 class149_1, Class149 class149_2)
		{
			if (IntPtr.Size != 4)
			{
				return C489BE26.E6AC84AA(class149_1, class149_2);
			}
			return Class158.smethod_3(class149_1, class149_2);
		}

		public C3ADD934(IntPtr intptr_1)
		{
			intptr_0 = intptr_1;
			class149_0 = smethod_6(intptr_0);
		}
	}

	private sealed class Class165 : Class155
	{
		private Class149 class149_0;

		private UIntPtr uintptr_0;

		public override ushort vmethod_8()
		{
			return class149_0.vmethod_8();
		}

		public override double vmethod_6()
		{
			return class149_0.vmethod_6();
		}

		public override uint vmethod_2()
		{
			return class149_0.vmethod_2();
		}

		public override byte vmethod_15()
		{
			return class149_0.vmethod_15();
		}

		private static Class149 D1A6DB9B(UIntPtr uintptr_1)
		{
			if (IntPtr.Size == 4)
			{
				return new Class158((int)uintptr_1.ToUInt32());
			}
			return new C489BE26((long)uintptr_1.ToUInt64());
		}

		public override void vmethod_12(object BAB172A7)
		{
			uintptr_0 = (UIntPtr)BAB172A7;
			class149_0 = D1A6DB9B(uintptr_0);
		}

		public static Class149 BF9D3F03(Class149 ECA3E234)
		{
			if (IntPtr.Size != 4)
			{
				return Class151.smethod_1(ECA3E234);
			}
			return Class166.smethod_1(ECA3E234);
		}

		public override Type vmethod_13()
		{
			return typeof(UIntPtr);
		}

		public override bool vmethod_9()
		{
			return uintptr_0 != UIntPtr.Zero;
		}

		public override ulong B0B223A4()
		{
			return class149_0.B0B223A4();
		}

		public override float vmethod_1()
		{
			return class149_0.vmethod_1();
		}

		public override short vmethod_14()
		{
			return class149_0.vmethod_14();
		}

		public override UIntPtr vmethod_4()
		{
			return uintptr_0;
		}

		public override Class149 FB97EC11()
		{
			return new Class165(uintptr_0);
		}

		public override IntPtr F786FC2B()
		{
			return class149_0.F786FC2B();
		}

		public override int vmethod_11()
		{
			return class149_0.vmethod_11();
		}

		public override sbyte EFB8C6AD()
		{
			return class149_0.EFB8C6AD();
		}

		public override object E8BD6697()
		{
			return uintptr_0;
		}

		public override long vmethod_3()
		{
			return class149_0.vmethod_3();
		}

		public Class165(UIntPtr D21C1038)
		{
			uintptr_0 = D21C1038;
			class149_0 = D1A6DB9B(uintptr_0);
		}
	}

	private sealed class Class173
	{
		public ulong ulong_0;

		public ulong B22D7A33;

		public void DC186E9D()
		{
			ulong b22D7A = B22D7A33;
			B22D7A33 = 0L - B22D7A33;
			if (b22D7A - 1L > b22D7A)
			{
				ulong_0--;
			}
			ulong_0 = ~ulong_0;
		}

		public void method_0(ulong ulong_1, ulong ulong_2)
		{
			uint[] array = new uint[2];
			uint[] array2 = new uint[2];
			uint[] array3 = new uint[5];
			array[0] = (uint)ulong_1;
			array[1] = (uint)(ulong_1 >> 32);
			array2[0] = (uint)ulong_2;
			array2[1] = (uint)(ulong_2 >> 32);
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					ulong num = (ulong)array[i] * (ulong)array2[j];
					int num2 = i + j;
					uint num3 = method_1(ref array3[num2++], (uint)num);
					num3 = method_1(ref array3[num2++], (uint)(int)(num >> 32) + num3);
					while (num2 < 4 && num3 != 0)
					{
						num3 = method_1(ref array3[num2++], num3);
					}
				}
			}
			B22D7A33 = array3[0] + ((ulong)array3[1] << 32);
			ulong_0 = array3[2] + ((ulong)array3[3] << 32);
		}

		public void A0328606(long long_0, long long_1)
		{
			bool num = long_0 < 0L;
			if (num)
			{
				long_0 = -long_0;
			}
			bool flag;
			if (flag = long_1 < 0L)
			{
				long_1 = -long_1;
			}
			method_0((ulong)long_0, (ulong)long_1);
			if (num ^ flag)
			{
				DC186E9D();
			}
		}

		private uint method_1(ref uint C9925A8E, uint uint_0)
		{
			uint num = C9925A8E;
			C9925A8E += uint_0;
			if (C9925A8E >= num)
			{
				return 0u;
			}
			return 1u;
		}
	}

	private sealed class Class174
	{
		private Type[] type_0;

		private uint uint_0;

		private Type type_1;

		private Enum2 D8A6DCB2;

		public bool Boolean_0
		{
			get
			{
				switch (D8A6DCB2 & Enum2.F58BE91A)
				{
				default:
					return false;
				case Enum2.const_11:
				case Enum2.const_4:
				case Enum2.const_10:
				case Enum2.C2A120A3:
				case Enum2.const_7:
				case Enum2.F036E39A:
				case Enum2.F505E1AA:
				case Enum2.EE9996A9:
					return true;
				}
			}
		}

		public CallingConvention CallingConvention_0 => (D8A6DCB2 & Enum2.F58BE91A) switch
		{
			Enum2.const_4 => CallingConvention.Cdecl, 
			Enum2.const_10 => CallingConvention.StdCall, 
			Enum2.C2A120A3 => CallingConvention.ThisCall, 
			Enum2.const_7 => CallingConvention.FastCall, 
			_ => CallingConvention.Winapi, 
		};

		public Type DD9A9DB6 => type_1;

		public void method_0(byte[] byte_0, Module B39ECB80)
		{
			Class172 @class = new Class172(byte_0);
			D8A6DCB2 = (Enum2)@class.method_1();
			if ((D8A6DCB2 & Enum2.C4ABB685) != 0)
			{
				uint_0 = @class.F78A4DB3();
			}
			switch (D8A6DCB2 & Enum2.F58BE91A)
			{
			default:
				throw new COMException(null, -2146233799);
			case Enum2.const_12:
				type_1 = @class.method_0(B39ECB80);
				break;
			case Enum2.C6399396:
			case Enum2.const_9:
			{
				uint num2 = @class.F78A4DB3();
				type_0 = new Type[num2];
				for (int j = 0; j < num2; j++)
				{
					type_0[j] = @class.method_0(B39ECB80);
				}
				break;
			}
			case Enum2.const_11:
			case Enum2.const_4:
			case Enum2.const_10:
			case Enum2.C2A120A3:
			case Enum2.const_7:
			case Enum2.F036E39A:
			case Enum2.const_2:
			case Enum2.F505E1AA:
			case Enum2.EE9996A9:
			{
				uint num = @class.F78A4DB3();
				type_1 = @class.method_0(B39ECB80);
				type_0 = new Type[num];
				for (int i = 0; i < num; i++)
				{
					type_0[i] = @class.method_0(B39ECB80);
				}
				break;
			}
			}
		}

		public Type[] B8188D2D()
		{
			return type_0;
		}
	}

	private sealed class Class166 : Class149
	{
		private uint D5097807;

		public override byte vmethod_15()
		{
			return (byte)D5097807;
		}

		public override Class155 vmethod_5()
		{
			return new Class158(vmethod_11());
		}

		public override int vmethod_11()
		{
			return (int)D5097807;
		}

		public static Class149 smethod_1(Class149 C6ACA5AC)
		{
			return new Class158((int)C6ACA5AC.vmethod_2());
		}

		public override sbyte EFB8C6AD()
		{
			return (sbyte)D5097807;
		}

		public override short vmethod_14()
		{
			return (short)D5097807;
		}

		public override ushort vmethod_8()
		{
			return (ushort)D5097807;
		}

		public override void vmethod_12(object BAB172A7)
		{
			D5097807 = Convert.ToUInt32(BAB172A7);
		}

		public override object E8BD6697()
		{
			return D5097807;
		}

		public override Class149 FB97EC11()
		{
			return new Class166(D5097807);
		}

		public override uint vmethod_2()
		{
			return D5097807;
		}

		public override Type vmethod_13()
		{
			return typeof(uint);
		}

		public Class166(uint uint_0)
		{
			D5097807 = uint_0;
		}
	}

	private sealed class Class175
	{
		private List<B2A5B022> C09023AE = new List<B2A5B022>();

		private int B18727B0;

		private int int_0;

		public void C203AE36(byte B9396830, int int_1, int int_2)
		{
			C09023AE.Add(new B2A5B022(B9396830, int_1, int_2));
		}

		public int A015A326()
		{
			return int_0;
		}

		public int method_0(Class175 B48A1384)
		{
			if (B48A1384 == null)
			{
				return 1;
			}
			int num = int_0.CompareTo(B48A1384.A015A326());
			if (num == 0)
			{
				num = B48A1384.D606C3A8().CompareTo(B18727B0);
			}
			return num;
		}

		public int D606C3A8()
		{
			return B18727B0;
		}

		public List<B2A5B022> method_1()
		{
			return C09023AE;
		}

		public Class175(int int_1, int int_2)
		{
			int_0 = int_1;
			B18727B0 = int_2;
		}
	}

	private sealed class D62331BF : Class149
	{
		private short short_0;

		public override void vmethod_12(object BAB172A7)
		{
			short_0 = Convert.ToInt16(BAB172A7);
		}

		public override byte vmethod_15()
		{
			return (byte)short_0;
		}

		public override object E8BD6697()
		{
			return short_0;
		}

		public override sbyte EFB8C6AD()
		{
			return (sbyte)short_0;
		}

		public override short vmethod_14()
		{
			return short_0;
		}

		public override Class155 vmethod_5()
		{
			return new Class158(vmethod_11());
		}

		public override ushort vmethod_8()
		{
			return (ushort)short_0;
		}

		public override Type vmethod_13()
		{
			return typeof(short);
		}

		public override Class149 FB97EC11()
		{
			return new D62331BF(short_0);
		}

		public override uint vmethod_2()
		{
			return (uint)short_0;
		}

		public override int vmethod_11()
		{
			return short_0;
		}

		public D62331BF(short short_1)
		{
			short_0 = short_1;
		}
	}

	private sealed class Class167 : Class149
	{
		private bool bool_0;

		public override void vmethod_12(object BAB172A7)
		{
			bool_0 = Convert.ToBoolean(BAB172A7);
		}

		public override Type vmethod_13()
		{
			return typeof(bool);
		}

		public override int vmethod_11()
		{
			if (!bool_0)
			{
				return 0;
			}
			return 1;
		}

		public override Class149 FB97EC11()
		{
			return new Class167(bool_0);
		}

		public override object E8BD6697()
		{
			return bool_0;
		}

		public override Class155 vmethod_5()
		{
			return new Class158(vmethod_11());
		}

		public Class167(bool bool_1)
		{
			bool_0 = bool_1;
		}
	}

	private sealed class Class164 : DF12521F
	{
		private object object_0;

		private FieldInfo fieldInfo_0;

		public override void vmethod_12(object BAB172A7)
		{
			((Class168)fieldInfo_0.GetValue(object_0)).vmethod_0((int)BAB172A7);
		}

		public override Class149 FB97EC11()
		{
			return new Class164(fieldInfo_0, object_0);
		}

		public override object E8BD6697()
		{
			return ((Class168)fieldInfo_0.GetValue(object_0)).vmethod_1();
		}

		public override Type vmethod_13()
		{
			return typeof(int);
		}

		public Class164(FieldInfo D2B15BA1, object object_1)
		{
			fieldInfo_0 = D2B15BA1;
			object_0 = object_1;
		}
	}

	private Class170 class170_0 = new Class170();

	private Class171 C3BB4EA7 = new Class171();

	private static readonly Module BE9BD6A5 = typeof(GClass34).Module;

	private List<IntPtr> list_0 = new List<IntPtr>();

	private Class169 A42C7380 = new Class169();

	private static readonly Dictionary<object, DynamicMethod> dictionary_0 = new Dictionary<object, DynamicMethod>();

	private B2A5B022 F912610E;

	private Exception exception_0;

	private static readonly Dictionary<uint, object> AF36060D = new Dictionary<uint, object>();

	private readonly Dictionary<uint, Delegate1> DFB3CD1C = new Dictionary<uint, Delegate1>();

	private void method_0()
	{
		if (A42C7380.F90CF8B2().vmethod_11() != 0)
		{
			class170_0.method_2();
			A42C7380.method_0(new Class159(exception_0));
			C3BB4EA7.vmethod_0(F912610E.method_0());
			F912610E = null;
		}
		else
		{
			method_39();
		}
	}

	private unsafe object method_1(int E9AA389F)
	{
		if (E9AA389F == 0)
		{
			return null;
		}
		lock (AF36060D)
		{
			if (AF36060D.TryGetValue(2147483648u, out var value))
			{
				return value;
			}
			byte* ptr = (byte*)(void*)Class177.D19FF531((uint)E9AA389F);
			uint num = 1561136571u;
			int num2 = *(int*)ptr ^ 0x5D0D0DBB;
			string text;
			if (num2 == 0)
			{
				text = string.Empty;
			}
			else
			{
				ptr += 4;
				byte[] array = new byte[num2];
				for (int i = 0; i < num2; i++)
				{
					array[i] = (byte)(ptr[i] ^ ((num << i) | (num >> 32 - i)));
				}
				text = Encoding.UTF8.GetString(array);
			}
			AF36060D.Add(2147483648u, text);
			return text;
		}
	}

	private void method_2()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 dB340C = A42C7380.F90CF8B2();
		A42C7380.method_0(Class159.smethod_1(dB340C, class149_));
	}

	private void method_3()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 class149_2 = A42C7380.F90CF8B2();
		A42C7380.method_0(C489BE26.CB18189A(class149_2, class149_));
	}

	private void method_4()
	{
		Class149 f1B4D6A = A42C7380.F90CF8B2();
		Class149 f301E43E = A42C7380.F90CF8B2();
		A42C7380.method_0(C3ADD934.smethod_3(f301E43E, f1B4D6A));
	}

	private void DE9FA007()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 d03B = A42C7380.F90CF8B2();
		A42C7380.method_0(DAA2CBAF.smethod_3(d03B, class149_));
	}

	private void method_5()
	{
		A42C7380.F90CF8B2();
	}

	private void method_6()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 class149_2 = A42C7380.F90CF8B2();
		A42C7380.method_0(Class158.smethod_2(class149_2, class149_));
	}

	private void method_7()
	{
		IntPtr intPtr = Marshal.AllocHGlobal(A42C7380.F90CF8B2().F786FC2B());
		list_0.Add(intPtr);
		A42C7380.method_0(new C3ADD934(intPtr));
	}

	private void method_8()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 class149_2 = A42C7380.F90CF8B2();
		A42C7380.method_0(C489BE26.E6AC84AA(class149_2, class149_));
	}

	private void method_9()
	{
		Class149 a399C = A42C7380.F90CF8B2();
		A42C7380.method_0(C489BE26.smethod_6(a399C));
	}

	private void method_10()
	{
		Type b28F9D = method_26(C3BB4EA7.BB883E02());
		Class149 class149_ = A42C7380.F90CF8B2();
		A42C7380.method_0(Class149.C7B9E73B(class149_, b28F9D));
	}

	private void method_11()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 class149_2 = A42C7380.F90CF8B2();
		A42C7380.method_0(DAA2CBAF.smethod_4(class149_2, class149_));
	}

	private void D288DE9F()
	{
		object a2A6108F = method_1(C3BB4EA7.BB883E02());
		A42C7380.method_0(new Class159(a2A6108F));
	}

	private void FC23B886()
	{
		Class149 bA0AE = A42C7380.F90CF8B2();
		Class149 e6B538AB = A42C7380.F90CF8B2();
		A42C7380.method_0(DAA2CBAF.smethod_1(e6B538AB, bA0AE));
	}

	private void method_12()
	{
		Class149 @class = A42C7380.F90CF8B2();
		A42C7380.method_0(new Class158(@class.F201FE8B()));
	}

	private void F3AF08B0()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 c5B9C62D = A42C7380.F90CF8B2();
		A42C7380.method_0(C489BE26.smethod_4(c5B9C62D, class149_));
	}

	private void A0B7A8BE()
	{
		Class149 aDB = A42C7380.F90CF8B2();
		Class149 b38FEFB = A42C7380.F90CF8B2();
		A42C7380.method_0(AA0E549A.smethod_5(b38FEFB, aDB));
	}

	private Class174 method_13(int int_0)
	{
		lock (AF36060D)
		{
			if (AF36060D.TryGetValue(1073741824u, out var value))
			{
				return (Class174)value;
			}
			byte[] byte_ = BE9BD6A5.ResolveSignature(int_0);
			Class174 @class = new Class174();
			@class.method_0(byte_, BE9BD6A5);
			AF36060D.Add(1073741824u, @class);
			return @class;
		}
	}

	private FieldInfo C08FB588(int int_0)
	{
		MemberInfo memberInfo = method_43(int_0);
		if (!(memberInfo is FieldInfo))
		{
			throw new InvalidOperationException();
		}
		return (FieldInfo)memberInfo;
	}

	private void method_14()
	{
		Class149 a98B4E9F = A42C7380.F90CF8B2();
		Class149 class149_ = A42C7380.F90CF8B2();
		A42C7380.method_0(Class158.smethod_1(class149_, a98B4E9F));
	}

	private void method_15()
	{
		byte c1B438BF = C3BB4EA7.method_1();
		int d6AB8E = C3BB4EA7.BB883E02();
		int c93E = C3BB4EA7.BB883E02();
		int dC = C3BB4EA7.BB883E02();
		int int_ = C3BB4EA7.BB883E02();
		class170_0.method_3(d6AB8E, c93E, c1B438BF, dC, int_);
	}

	private void method_16()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 b20BAB = A42C7380.F90CF8B2();
		A42C7380.method_0(C489BE26.smethod_1(b20BAB, class149_));
	}

	private void FEB7B290()
	{
		Class149 f789D02A = A42C7380.F90CF8B2();
		A42C7380.method_0(AA0E549A.F604B2BD(f789D02A));
	}

	private void method_17()
	{
		A42C7380.method_0(new C489BE26(C3BB4EA7.method_7()));
	}

	private void method_18()
	{
		Class174 @class = method_13(C3BB4EA7.BB883E02());
		if (!@class.Boolean_0)
		{
			throw new ArgumentException();
		}
		BindingFlags invokeAttr = BindingFlags.Default;
		Type[] array = @class.B8188D2D();
		Type[] array2 = new Type[array.Length + 1];
		array.CopyTo(array2, 0);
		array2[array.Length] = typeof(IntPtr);
		object[] array3 = new object[array2.Length];
		Dictionary<int, Class149> dictionary = new Dictionary<int, Class149>();
		EB0EA089 eB0EA = new EB0EA089();
		try
		{
			for (int num = array3.Length - 1; num >= 0; num--)
			{
				Type type = array2[num];
				Class149 class2 = A42C7380.F90CF8B2();
				if (class2.vmethod_0())
				{
					if (!type.IsByRef)
					{
						array3[num] = eB0EA.E7B233AA(class2.E8BD6697());
						continue;
					}
					dictionary[num] = class2;
				}
				array3[num] = class2.method_0(type).E8BD6697();
			}
			DynamicMethod value;
			lock (dictionary_0)
			{
				if (!dictionary_0.TryGetValue(@class, out value))
				{
					value = new DynamicMethod("", (@class.DD9A9DB6 != typeof(void)) ? @class.DD9A9DB6 : null, array2, typeof(GClass34).Module, skipVisibility: true);
					ILGenerator iLGenerator = value.GetILGenerator();
					for (int i = 0; i < array2.Length; i++)
					{
						iLGenerator.Emit(dictionary.ContainsKey(i) ? OpCodes.Ldarga : OpCodes.Ldarg, i);
					}
					iLGenerator.EmitCalli(OpCodes.Calli, @class.CallingConvention_0, @class.DD9A9DB6, array);
					iLGenerator.Emit(OpCodes.Ret);
					dictionary_0.Add(@class, value);
				}
			}
			object d426FBA = value.Invoke(null, invokeAttr, null, array3, null);
			foreach (KeyValuePair<int, Class149> item in dictionary)
			{
				item.Value.vmethod_12(array3[item.Key]);
			}
			if (@class.DD9A9DB6 != typeof(void))
			{
				A42C7380.method_0(Class149.C6208FB5(d426FBA, @class.DD9A9DB6));
			}
		}
		finally
		{
			eB0EA.Dispose();
		}
	}

	private void method_19()
	{
		Class149 @class = A42C7380.F90CF8B2();
		A42C7380.method_0(@class.method_0(@class.vmethod_13()));
	}

	private void F21A098B()
	{
		Class149 @class = A42C7380.F90CF8B2();
		Class171 class2 = new Class171();
		class2.vmethod_0(@class.vmethod_11());
		int num = @class.F201FE8B();
		ushort num2 = (ushort)class2.method_2();
		Dictionary<int, Class149> dictionary = new Dictionary<int, Class149>();
		object[] array = null;
		if (num2 > 0)
		{
			array = new object[num2];
			for (int num3 = num2 - 1; num3 >= 0; num3--)
			{
				@class = A42C7380.F90CF8B2();
				if (@class.vmethod_0())
				{
					dictionary[num3] = @class;
				}
				array[num3] = @class.method_0(method_26(class2.BB883E02())).E8BD6697();
			}
		}
		int num4 = class2.BB883E02();
		if (((uint)num & 0x10u) != 0 && (array == null || array[0] == null))
		{
			throw new NullReferenceException();
		}
		class2.BB883E02();
		object d426FBA = new GClass34().method_46(array, class2.vmethod_1());
		foreach (KeyValuePair<int, Class149> item in dictionary)
		{
			item.Value.vmethod_12(array[item.Key]);
		}
		if (num4 != 0)
		{
			Type type = method_26(num4);
			if (type != typeof(void))
			{
				A42C7380.method_0(Class149.C6208FB5(d426FBA, type));
			}
		}
	}

	private void FC9FD932()
	{
		Class149 f02E = A42C7380.F90CF8B2();
		A42C7380.method_0(DAA2CBAF.smethod_2(f02E));
	}

	private void CD89DE3D()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 class149_2 = A42C7380.F90CF8B2();
		A42C7380.method_0(C489BE26.C4AF3B31(class149_2, class149_));
	}

	private void method_20()
	{
		Class149 bE8A = A42C7380.F90CF8B2();
		Class149 class149_ = A42C7380.F90CF8B2();
		A42C7380.method_0(AA0E549A.smethod_1(class149_, bE8A));
	}

	private void method_21()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 dD9A9BB = A42C7380.F90CF8B2();
		A42C7380.method_0(C3ADD934.smethod_4(dD9A9BB, class149_));
	}

	private void method_22()
	{
		Class149 dE2DD58E = A42C7380.F90CF8B2();
		Class149 class149_ = A42C7380.F90CF8B2();
		A42C7380.method_0(Class158.smethod_7(class149_, dE2DD58E));
	}

	private void BA2B4B3F()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 class149_2 = A42C7380.F90CF8B2();
		A42C7380.method_0(C3ADD934.A51173A3(class149_2, class149_));
	}

	private void method_23()
	{
		A42C7380.method_0(new AA0E549A(C3BB4EA7.method_5()));
	}

	private void method_24()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 class149_2 = A42C7380.F90CF8B2();
		A42C7380.method_0(C489BE26.smethod_2(class149_2, class149_));
	}

	private void A7034409()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 class149_2 = A42C7380.F90CF8B2();
		A42C7380.method_0(AA0E549A.smethod_6(class149_2, class149_));
	}

	private void DDB99BAF()
	{
		Class149 aE196D = A42C7380.F90CF8B2();
		A42C7380.method_0(C3ADD934.smethod_7(aE196D));
	}

	private void method_25()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 class149_2 = A42C7380.F90CF8B2();
		A42C7380.method_0(Class158.C2965D3D(class149_2, class149_));
	}

	private Type method_26(int int_0)
	{
		MemberInfo memberInfo = method_43(int_0);
		if (!(memberInfo is Type))
		{
			throw new InvalidOperationException();
		}
		return (Type)memberInfo;
	}

	private void CA9E4889()
	{
		Class149 aC9E73A = A42C7380.F90CF8B2();
		A42C7380.method_0(Class158.smethod_6(aC9E73A));
	}

	private void method_27()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 a22C = A42C7380.F90CF8B2();
		A42C7380.method_0(C3ADD934.smethod_1(a22C, class149_));
	}

	private void FFBFA28B()
	{
		A42C7380.method_0(new DAA2CBAF(C3BB4EA7.B0263A0F()));
	}

	private void method_28()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 class149_2 = A42C7380.F90CF8B2();
		A42C7380.method_0(AA0E549A.smethod_3(class149_2, class149_));
	}

	private void EB3E943E()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 class149_2 = A42C7380.F90CF8B2();
		A42C7380.method_0(DAA2CBAF.CF117A89(class149_2, class149_));
	}

	private void method_29()
	{
		Class149 c6ACA5AC = A42C7380.F90CF8B2();
		A42C7380.method_0(Class166.smethod_1(c6ACA5AC));
	}

	private void method_30()
	{
		int int_ = C3BB4EA7.BB883E02();
		MemberInfo memberInfo = method_43(int_);
		if (memberInfo is Type)
		{
			A42C7380.method_0(new B4397D18(((Type)memberInfo).TypeHandle));
			return;
		}
		if (memberInfo is MethodBase)
		{
			A42C7380.method_0(new B4397D18(((MethodBase)memberInfo).MethodHandle));
			return;
		}
		if (!(memberInfo is FieldInfo))
		{
			throw new InvalidOperationException();
		}
		A42C7380.method_0(new B4397D18(((FieldInfo)memberInfo).FieldHandle));
	}

	private void method_31()
	{
		Type e7B = method_26(C3BB4EA7.BB883E02());
		Class149 @class = A42C7380.F90CF8B2();
		A42C7380.method_0(new Class159(@class.method_0(e7B).E8BD6697()));
	}

	private void F7109728()
	{
		Type type = method_26(C3BB4EA7.BB883E02());
		Class149 @class = A42C7380.F90CF8B2();
		Class149 class2 = A42C7380.F90CF8B2();
		@class = @class.method_0(type);
		if (class2.vmethod_0())
		{
			if (class2.vmethod_13() != type)
			{
				@class = @class.method_0(class2.vmethod_13());
			}
		}
		else
		{
			class2 = new A2B1602B(class2.F786FC2B(), type);
		}
		class2.vmethod_12(@class.E8BD6697());
	}

	private void method_32()
	{
		Type c2279CAF = method_26(C3BB4EA7.BB883E02());
		Class149 @class = A42C7380.F90CF8B2();
		Array array = A42C7380.F90CF8B2().E8BD6697() as Array;
		if (array == null)
		{
			throw new ArgumentException();
		}
		A42C7380.method_0(Class149.C6208FB5(array.GetValue(@class.vmethod_11()), c2279CAF));
	}

	private void F9377803()
	{
		A42C7380.method_0(new Class158(C3BB4EA7.BB883E02()));
	}

	private void method_33()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 f40386A = A42C7380.F90CF8B2();
		A42C7380.method_0(C489BE26.smethod_5(f40386A, class149_));
	}

	private void D830C3BF()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 class149_2 = A42C7380.F90CF8B2();
		A42C7380.method_0(Class158.smethod_4(class149_2, class149_));
	}

	private void EA27FA8A()
	{
		Class149 fC2CC = A42C7380.F90CF8B2();
		A42C7380.method_0(AA0E549A.D89C8F03(fC2CC));
	}

	private void D79DB0A9()
	{
		Class149 fDA = A42C7380.F90CF8B2();
		Class149 class149_ = A42C7380.F90CF8B2();
		A42C7380.method_0(C489BE26.smethod_3(class149_, fDA));
	}

	private void method_34()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 class149_2 = A42C7380.F90CF8B2();
		A42C7380.method_0(C489BE26.A4141B3A(class149_2, class149_));
	}

	private void B19ECE19()
	{
		Class149 c12BC9B = A42C7380.F90CF8B2();
		Class149 class149_ = A42C7380.F90CF8B2();
		A42C7380.method_0(DAA2CBAF.smethod_6(class149_, c12BC9B));
	}

	private void CBB5C4B9()
	{
		Class149 eD8EA7AA = A42C7380.F90CF8B2();
		Class149 class149_ = A42C7380.F90CF8B2();
		A42C7380.method_0(Class158.smethod_3(class149_, eD8EA7AA));
	}

	private void F9898DB8()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 a582E2A = A42C7380.F90CF8B2();
		A42C7380.method_0(Class158.F5936B84(a582E2A, class149_));
	}

	private void method_35()
	{
		Class149 d0251B = A42C7380.F90CF8B2();
		Class149 a796D79E = A42C7380.F90CF8B2();
		A42C7380.method_0(Class158.smethod_8(a796D79E, d0251B));
	}

	private void method_36()
	{
		Type type = method_26(C3BB4EA7.BB883E02());
		Class149 @class = A42C7380.F90CF8B2();
		object bAB172A = null;
		if (type.IsValueType && Nullable.GetUnderlyingType(type) == null)
		{
			bAB172A = FormatterServices.GetUninitializedObject(type);
		}
		@class.vmethod_12(bAB172A);
	}

	private void AF1D5903()
	{
		int b82CE3BE = C3BB4EA7.method_1();
		A42C7380.F2061289().F003DD86(b82CE3BE);
	}

	private void method_37()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 d8098DB = A42C7380.F90CF8B2();
		A42C7380.method_0(AA0E549A.smethod_4(d8098DB, class149_));
	}

	private void DD8D6D22()
	{
		Class149 eCA3E = A42C7380.F90CF8B2();
		A42C7380.method_0(Class165.BF9D3F03(eCA3E));
	}

	private void method_38()
	{
		Class149 f001CE = A42C7380.F90CF8B2();
		A42C7380.method_0(Class151.smethod_1(f001CE));
	}

	private void method_39()
	{
		A42C7380.method_1();
		C3BB4EA7.method_6();
		do
		{
			if (class170_0.method_0() != 0)
			{
				List<B2A5B022> list = class170_0.method_1().method_1();
				int num = ((F912610E != null) ? (list.IndexOf(F912610E) + 1) : 0);
				F912610E = null;
				for (int i = num; i < list.Count; i++)
				{
					B2A5B022 b2A5B = list[i];
					switch (b2A5B.CD9C8000())
					{
					case 0:
					{
						Type type = exception_0.GetType();
						Type type2 = method_26(b2A5B.method_1());
						if (type == type2 || type.IsSubclassOf(type2))
						{
							class170_0.method_2();
							A42C7380.method_0(new Class159(exception_0));
							C3BB4EA7.vmethod_0(b2A5B.method_0());
							return;
						}
						break;
					}
					case 1:
						F912610E = b2A5B;
						A42C7380.method_0(new Class159(exception_0));
						C3BB4EA7.vmethod_0(b2A5B.method_1());
						return;
					}
				}
				class170_0.method_2();
				for (int num2 = list.Count; num2 > 0; num2--)
				{
					B2A5B022 b2A5B2 = list[num2 - 1];
					if (b2A5B2.CD9C8000() == 2 || b2A5B2.CD9C8000() == 4)
					{
						C3BB4EA7.method_3(b2A5B2.method_0());
					}
				}
				continue;
			}
			throw exception_0;
		}
		while (C3BB4EA7.method_0() == 0);
		C3BB4EA7.BCADAFBF();
	}

	private void AA215612()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 class149_2 = A42C7380.F90CF8B2();
		A42C7380.method_0(C3ADD934.E6B4ED25(class149_2, class149_));
	}

	private MethodBase method_40(int ED22DF32)
	{
		MemberInfo memberInfo = method_43(ED22DF32);
		if (!(memberInfo is MethodBase))
		{
			throw new InvalidOperationException();
		}
		return (MethodBase)memberInfo;
	}

	private void method_41()
	{
		Type type = method_26(C3BB4EA7.BB883E02());
		Class149 @class = A42C7380.F90CF8B2();
		Class149 class2 = A42C7380.F90CF8B2();
		Array obj = (A42C7380.F90CF8B2().E8BD6697() as Array) ?? throw new ArgumentException();
		@class = @class.method_0(type);
		Type elementType = obj.GetType().GetElementType();
		if (type != elementType)
		{
			@class = @class.method_0(elementType);
		}
		obj.SetValue(@class.E8BD6697(), class2.vmethod_11());
	}

	private void method_42()
	{
		FieldInfo fieldInfo_ = C08FB588(C3BB4EA7.BB883E02());
		Class149 class149_ = A42C7380.F90CF8B2();
		A42C7380.method_0(new Class160(fieldInfo_, class149_));
	}

	private MemberInfo method_43(int int_0)
	{
		lock (AF36060D)
		{
			if (AF36060D.TryGetValue((uint)int_0, out var value))
			{
				return (MemberInfo)value;
			}
			MemberInfo memberInfo = BE9BD6A5.ResolveMember(int_0);
			AF36060D.Add((uint)int_0, memberInfo);
			return memberInfo;
		}
	}

	private void B590D8BA()
	{
		short int_ = C3BB4EA7.method_2();
		Type type = method_26(A42C7380.F90CF8B2().vmethod_11());
		Class149 @class = A42C7380.F90CF8B2();
		Class149 class2 = A42C7380.F90CF8B2();
		object obj = class2.E8BD6697();
		if (obj == null && type.IsValueType)
		{
			obj = Activator.CreateInstance(type);
		}
		class2 = Class149.C6208FB5(obj, type);
		if (@class.vmethod_0())
		{
			class2 = new Class161(class2, @class);
		}
		A42C7380.BA317A20(int_, class2);
	}

	private void method_44()
	{
		MethodBase methodBase = method_40(C3BB4EA7.BB883E02());
		object obj = A42C7380.F90CF8B2().E8BD6697();
		if (obj != null)
		{
			Type type = obj.GetType();
			Type declaringType = methodBase.DeclaringType;
			ParameterInfo[] parameters = methodBase.GetParameters();
			Type[] array = new Type[parameters.Length];
			int num = 0;
			ParameterInfo[] array2 = parameters;
			foreach (ParameterInfo parameterInfo in array2)
			{
				array[num++] = parameterInfo.ParameterType;
			}
			while (type != null && type != declaringType)
			{
				MethodInfo method = type.GetMethod(methodBase.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
				if (!(method != null) || !(method.GetBaseDefinition() == methodBase))
				{
					type = type.BaseType;
					continue;
				}
				methodBase = method;
				break;
			}
		}
		A42C7380.method_0(new C31D7396(methodBase));
	}

	private void method_45()
	{
		int num = C3BB4EA7.method_2();
		Class149 @class = A42C7380.F90CF8B2();
		if (num < 0)
		{
			A42C7380.BA317A20(num + A42C7380.vmethod_1(), @class);
			return;
		}
		Class149 class2 = A42C7380.method_2(num);
		if (class2 == null)
		{
			if (!@class.vmethod_0())
			{
				throw new ArgumentException();
			}
			A42C7380.BA317A20(num, @class);
		}
		else
		{
			class2.vmethod_12(@class.method_0(class2.vmethod_13()).E8BD6697());
		}
	}

	public object method_46(object[] D6227511, int E00A0AB4)
	{
		C3BB4EA7.vmethod_0(E00A0AB4);
		A42C7380.method_0(new Class159(D6227511));
		try
		{
			while (true)
			{
				try
				{
					DFB3CD1C[C3BB4EA7.method_4()]();
					if (C3BB4EA7.vmethod_1() == 0)
					{
						break;
					}
				}
				catch (Exception ex)
				{
					if (F912610E == null)
					{
						exception_0 = ex;
					}
					method_39();
				}
			}
			return A42C7380.F90CF8B2().E8BD6697();
		}
		finally
		{
			foreach (IntPtr item in list_0)
			{
				Marshal.FreeHGlobal(item);
			}
			list_0.Clear();
		}
	}

	private void BD875B2B()
	{
		Type type = method_26(C3BB4EA7.BB883E02());
		DynamicMethod value;
		lock (dictionary_0)
		{
			if (!dictionary_0.TryGetValue(type, out value))
			{
				value = new DynamicMethod("", typeof(int), null, typeof(GClass34).Module, skipVisibility: true);
				ILGenerator iLGenerator = value.GetILGenerator();
				iLGenerator.Emit(OpCodes.Sizeof, type);
				iLGenerator.Emit(OpCodes.Ret);
				dictionary_0.Add(type, value);
			}
		}
		A42C7380.method_0(new Class158((int)value.Invoke(null, null)));
	}

	private void method_47()
	{
		Class149 b22C = A42C7380.F90CF8B2();
		Class149 a4AA = A42C7380.F90CF8B2();
		A42C7380.method_0(C3ADD934.E4B3FE2A(a4AA, b22C));
	}

	private void DD85BC89()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		A42C7380.method_0(Class149.smethod_0(class149_));
	}

	private void FB97A798()
	{
		Type elementType = method_26(C3BB4EA7.BB883E02());
		A42C7380.method_0(new Class159(Array.CreateInstance(elementType, A42C7380.F90CF8B2().vmethod_11())));
	}

	private void method_48()
	{
		Type type = method_26(C3BB4EA7.BB883E02());
		Class149 @class = A42C7380.F90CF8B2();
		if (!@class.vmethod_0())
		{
			@class = new A2B1602B(@class.F786FC2B(), type);
		}
		A42C7380.method_0(@class.method_0(type));
	}

	private void method_49()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		A42C7380.method_0(new Class157(class149_));
	}

	private void BC8DE100()
	{
		Class149 a60F4AA = A42C7380.F90CF8B2();
		A42C7380.method_0(DAA2CBAF.smethod_5(a60F4AA));
	}

	private void DB36699E()
	{
		Class149 f492A49F = A42C7380.F90CF8B2();
		Class149 aD2E = A42C7380.F90CF8B2();
		A42C7380.method_0(C3ADD934.smethod_5(aD2E, f492A49F));
	}

	private void DA0C7424()
	{
		int num = C3BB4EA7.BB883E02();
		C3BB4EA7.method_3(A42C7380.F90CF8B2().vmethod_11());
		List<int> list = new List<int>();
		while (class170_0.method_0() != 0 && num > class170_0.method_1().D606C3A8())
		{
			List<B2A5B022> list2 = class170_0.method_2().method_1();
			for (int i = 0; i < list2.Count; i++)
			{
				B2A5B022 b2A5B = list2[i];
				if (b2A5B.CD9C8000() == 2)
				{
					list.Add(b2A5B.method_0());
				}
			}
		}
		for (int num2 = list.Count; num2 > 0; num2--)
		{
			C3BB4EA7.method_3(list[num2 - 1]);
		}
		exception_0 = null;
		A42C7380.method_1();
		C3BB4EA7.BCADAFBF();
	}

	private void method_50()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 cD87A = A42C7380.F90CF8B2();
		A42C7380.method_0(Class158.smethod_5(cD87A, class149_));
	}

	private void D09E3E9A()
	{
		A42C7380.method_0(A42C7380.F2061289().FB97EC11());
	}

	private void method_51()
	{
		FieldInfo d2B15BA = C08FB588(C3BB4EA7.BB883E02());
		A42C7380.method_0(new Class164(d2B15BA, this));
	}

	private void method_52()
	{
		Class149 @class = A42C7380.F90CF8B2();
		Array array = A42C7380.F90CF8B2().E8BD6697() as Array;
		if (array == null)
		{
			throw new ArgumentException();
		}
		A42C7380.method_0(new Class162(array, @class.vmethod_11()));
	}

	private void method_53()
	{
		Class149 @class = A42C7380.F90CF8B2();
		int num = @class.vmethod_11();
		MethodBase methodBase = method_40(num);
		int num2 = @class.F201FE8B();
		Type[] array;
		if (methodBase.CallingConvention == CallingConventions.VarArgs)
		{
			Class174 class2 = method_13(num);
			if (!class2.Boolean_0)
			{
				throw new ArgumentException();
			}
			array = class2.B8188D2D();
		}
		else
		{
			ParameterInfo[] parameters = methodBase.GetParameters();
			array = new Type[parameters.Length];
			for (int i = 0; i < parameters.Length; i++)
			{
				array[i] = parameters[i].ParameterType;
			}
		}
		if (((uint)num2 & 2u) != 0)
		{
			MethodInfo method = method_26(A42C7380.F90CF8B2().vmethod_11()).GetMethod(methodBase.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, null, array, null);
			if (method != null)
			{
				methodBase = method;
			}
		}
		BindingFlags invokeAttr = BindingFlags.Default;
		MethodInfo methodInfo = methodBase as MethodInfo;
		Dictionary<int, Class149> dictionary = new Dictionary<int, Class149>();
		object[] array2 = new object[array.Length];
		EB0EA089 eB0EA = new EB0EA089();
		try
		{
			Class149 class3 = null;
			if (((uint)num2 & 8u) != 0)
			{
				class3 = A42C7380.F90CF8B2();
			}
			for (int num3 = array2.Length - 1; num3 >= 0; num3--)
			{
				Type type = array[num3];
				@class = A42C7380.F90CF8B2();
				if (@class.vmethod_0())
				{
					if (!type.IsByRef)
					{
						array2[num3] = eB0EA.E7B233AA(@class.E8BD6697());
						continue;
					}
					dictionary[num3] = @class;
				}
				array2[num3] = @class.method_0(type).E8BD6697();
			}
			if (class3 == null && !methodBase.IsStatic)
			{
				class3 = A42C7380.F90CF8B2();
			}
			object obj;
			if (class3 == null)
			{
				obj = null;
			}
			else
			{
				obj = class3.E8BD6697();
				if (obj != null)
				{
					goto IL_01a1;
				}
			}
			obj = null;
			goto IL_01a1;
			IL_01a1:
			object obj2 = obj;
			bool flag;
			if ((flag = (num2 & 0x10) != 0) && obj2 == null)
			{
				throw new NullReferenceException();
			}
			object d426FBA = null;
			if (methodBase.CallingConvention == CallingConventions.VarArgs)
			{
				DynamicMethod value;
				lock (dictionary_0)
				{
					if (!dictionary_0.TryGetValue(num, out value))
					{
						int num4 = methodInfo.GetParameters().Length;
						Type[] array3 = new Type[array.Length - num4];
						Array.Copy(array, num4, array3, 0, array.Length - num4);
						value = new DynamicMethod("", (!(methodInfo != null) || !(methodInfo.ReturnType != typeof(void))) ? null : methodInfo.ReturnType, array, typeof(GClass34).Module, skipVisibility: true);
						ILGenerator iLGenerator = value.GetILGenerator();
						for (int j = 0; j < array.Length; j++)
						{
							iLGenerator.Emit(OpCodes.Ldarg, j);
						}
						iLGenerator.EmitCall(OpCodes.Call, methodInfo, array3);
						iLGenerator.Emit(OpCodes.Ret);
						dictionary_0.Add(num, value);
					}
				}
				d426FBA = value.Invoke(null, invokeAttr, null, array2, null);
			}
			else if (!flag && methodBase.IsVirtual && !methodBase.IsFinal)
			{
				object[] array4 = new object[array.Length + 1];
				array4[0] = obj2;
				for (int k = 0; k < array.Length; k++)
				{
					array4[k + 1] = array2[k];
				}
				DynamicMethod value2;
				lock (dictionary_0)
				{
					if (!dictionary_0.TryGetValue(methodBase, out value2))
					{
						Type[] array5 = new Type[array4.Length];
						array5[0] = methodBase.DeclaringType;
						for (int l = 0; l < array.Length; l++)
						{
							array5[l + 1] = array[l];
						}
						value2 = new DynamicMethod("", (!(methodInfo != null) || !(methodInfo.ReturnType != typeof(void))) ? null : methodInfo.ReturnType, array5, typeof(GClass34).Module, skipVisibility: true);
						ILGenerator iLGenerator2 = value2.GetILGenerator();
						for (int m = 0; m < array5.Length; m++)
						{
							if (m == 0 && methodBase.DeclaringType.IsValueType)
							{
								iLGenerator2.Emit(OpCodes.Ldarga, m);
							}
							else
							{
								iLGenerator2.Emit(OpCodes.Ldarg, m);
							}
						}
						iLGenerator2.Emit(OpCodes.Call, methodInfo);
						iLGenerator2.Emit(OpCodes.Ret);
						dictionary_0.Add(methodBase, value2);
					}
				}
				d426FBA = value2.Invoke(null, invokeAttr, null, array4, null);
				foreach (KeyValuePair<int, Class149> item in dictionary)
				{
					item.Value.vmethod_12(array4[item.Key + 1]);
				}
				dictionary.Clear();
			}
			else
			{
				if (methodBase.IsConstructor && methodBase.DeclaringType.IsValueType && Nullable.GetUnderlyingType(methodBase.DeclaringType) != null)
				{
					obj2 = ((ConstructorInfo)methodBase).Invoke(invokeAttr, null, array2, null);
				}
				else
				{
					d426FBA = methodBase.Invoke(obj2, invokeAttr, null, array2, null);
				}
				if (class3 != null && class3.vmethod_0() && methodBase.DeclaringType.IsValueType)
				{
					class3.vmethod_12(obj2);
				}
			}
			foreach (KeyValuePair<int, Class149> item2 in dictionary)
			{
				item2.Value.vmethod_12(array2[item2.Key]);
			}
			if (methodInfo != null && methodInfo.ReturnType != typeof(void))
			{
				A42C7380.method_0(Class149.C6208FB5(d426FBA, methodInfo.ReturnType));
			}
		}
		finally
		{
			eB0EA.Dispose();
		}
	}

	private void method_54()
	{
		MethodBase methodBase = method_40(C3BB4EA7.BB883E02());
		ParameterInfo[] parameters = methodBase.GetParameters();
		Dictionary<int, Class149> dictionary = new Dictionary<int, Class149>();
		object[] array = new object[parameters.Length];
		EB0EA089 eB0EA = new EB0EA089();
		try
		{
			for (int num = parameters.Length - 1; num >= 0; num--)
			{
				Type parameterType = parameters[num].ParameterType;
				Class149 @class = A42C7380.F90CF8B2();
				if (@class.vmethod_0())
				{
					if (!parameterType.IsByRef)
					{
						array[num] = eB0EA.E7B233AA(@class.E8BD6697());
						continue;
					}
					dictionary[num] = @class;
				}
				array[num] = @class.method_0(parameterType).E8BD6697();
			}
			object d426FBA = ((ConstructorInfo)methodBase).Invoke(array);
			foreach (KeyValuePair<int, Class149> item in dictionary)
			{
				item.Value.vmethod_12(array[item.Key]);
			}
			A42C7380.method_0(Class149.C6208FB5(d426FBA, methodBase.DeclaringType));
		}
		finally
		{
			eB0EA.Dispose();
		}
	}

	private void CD293984()
	{
		throw (A42C7380.F90CF8B2().E8BD6697() as Exception) ?? throw new ArgumentException();
	}

	private void B82DF99A()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 c60F = A42C7380.F90CF8B2();
		A42C7380.method_0(C3ADD934.smethod_2(c60F, class149_));
	}

	private void method_55()
	{
		Class149 b0B1C = A42C7380.F90CF8B2();
		A42C7380.method_0(AA0E549A.smethod_7(b0B1C));
	}

	private void method_56()
	{
		short bE00170C = C3BB4EA7.method_2();
		Class149 @class = A42C7380.method_2(bE00170C);
		A42C7380.method_0(@class.FB97EC11());
	}

	private void method_57()
	{
		Class149 @class = A42C7380.F90CF8B2();
		Class149 class2 = A42C7380.F90CF8B2();
		@class.vmethod_12(class2.method_0(@class.vmethod_13()).E8BD6697());
	}

	private void method_58()
	{
		Type type = method_26(C3BB4EA7.BB883E02());
		object obj = A42C7380.F90CF8B2().E8BD6697();
		Type type2 = obj.GetType();
		if (type2 != type && !type.IsAssignableFrom(type2))
		{
			throw new InvalidCastException();
		}
		A42C7380.method_0(Class149.C6208FB5(obj, type));
	}

	private void method_59()
	{
		if (exception_0 == null)
		{
			C3BB4EA7.BCADAFBF();
		}
		else
		{
			method_39();
		}
	}

	private void method_60()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		A42C7380.method_0(AA0E549A.smethod_2(class149_));
	}

	private void method_61()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		A42C7380.method_0(DAA2CBAF.A7876229(class149_));
	}

	private void C4037280()
	{
		if (exception_0 == null)
		{
			throw new InvalidOperationException();
		}
		throw exception_0;
	}

	private void AFA4C096()
	{
		Array array = A42C7380.F90CF8B2().E8BD6697() as Array;
		if (array == null)
		{
			throw new ArgumentException();
		}
		A42C7380.method_0(new Class158(array.Length));
	}

	private void F2B20B8B()
	{
		short bE00170C = C3BB4EA7.method_2();
		Class149 @class = A42C7380.method_2(bE00170C);
		if (@class.vmethod_0())
		{
			throw new ArgumentException();
		}
		A42C7380.method_0(new Class163(@class));
	}

	private void method_62()
	{
		Class149 class149_ = A42C7380.F90CF8B2();
		Class149 class149_2 = A42C7380.F90CF8B2();
		A42C7380.method_0(C3ADD934.C6A8D19D(class149_2, class149_));
	}

	public GClass34()
	{
		DFB3CD1C[0u] = method_14;
		DFB3CD1C[1u] = method_60;
		DFB3CD1C[2u] = F21A098B;
		DFB3CD1C[3u] = method_15;
		DFB3CD1C[4u] = method_32;
		DFB3CD1C[5u] = method_11;
		DFB3CD1C[6u] = F2B20B8B;
		DFB3CD1C[7u] = EA27FA8A;
		DFB3CD1C[8u] = method_44;
		DFB3CD1C[9u] = method_31;
		DFB3CD1C[10u] = B82DF99A;
		DFB3CD1C[11u] = method_22;
		DFB3CD1C[12u] = method_34;
		DFB3CD1C[13u] = method_17;
		DFB3CD1C[14u] = method_48;
		DFB3CD1C[15u] = method_22;
		DFB3CD1C[16u] = CBB5C4B9;
		DFB3CD1C[17u] = D09E3E9A;
		DFB3CD1C[18u] = method_59;
		DFB3CD1C[19u] = method_62;
		DFB3CD1C[20u] = method_53;
		DFB3CD1C[21u] = method_30;
		DFB3CD1C[22u] = FC9FD932;
		DFB3CD1C[23u] = F9898DB8;
		DFB3CD1C[24u] = CA9E4889;
		DFB3CD1C[25u] = method_33;
		DFB3CD1C[26u] = method_2;
		DFB3CD1C[27u] = method_61;
		DFB3CD1C[28u] = BA2B4B3F;
		DFB3CD1C[29u] = method_18;
		DFB3CD1C[30u] = method_4;
		DFB3CD1C[31u] = F9898DB8;
		DFB3CD1C[32u] = B19ECE19;
		DFB3CD1C[33u] = method_3;
		DFB3CD1C[34u] = method_0;
		DFB3CD1C[35u] = A0B7A8BE;
		DFB3CD1C[36u] = method_38;
		DFB3CD1C[37u] = FEB7B290;
		DFB3CD1C[38u] = DE9FA007;
		DFB3CD1C[39u] = DDB99BAF;
		DFB3CD1C[40u] = method_25;
		DFB3CD1C[41u] = FC23B886;
		DFB3CD1C[42u] = DA0C7424;
		DFB3CD1C[43u] = method_12;
		DFB3CD1C[44u] = F9377803;
		DFB3CD1C[45u] = method_49;
		DFB3CD1C[46u] = EB3E943E;
		DFB3CD1C[47u] = AFA4C096;
		DFB3CD1C[48u] = B590D8BA;
		DFB3CD1C[49u] = method_36;
		DFB3CD1C[50u] = method_57;
		DFB3CD1C[51u] = method_55;
		DFB3CD1C[52u] = FB97A798;
		DFB3CD1C[53u] = CD293984;
		DFB3CD1C[54u] = method_42;
		DFB3CD1C[55u] = method_5;
		DFB3CD1C[56u] = DD8D6D22;
		DFB3CD1C[57u] = method_52;
		DFB3CD1C[58u] = D288DE9F;
		DFB3CD1C[59u] = method_8;
		DFB3CD1C[60u] = method_37;
		DFB3CD1C[61u] = method_45;
		DFB3CD1C[62u] = A7034409;
		DFB3CD1C[63u] = F7109728;
		DFB3CD1C[64u] = method_9;
		DFB3CD1C[65u] = C4037280;
		DFB3CD1C[66u] = method_28;
		DFB3CD1C[67u] = method_20;
		DFB3CD1C[68u] = method_24;
		DFB3CD1C[69u] = D830C3BF;
		DFB3CD1C[70u] = method_58;
		DFB3CD1C[71u] = method_50;
		DFB3CD1C[72u] = method_21;
		DFB3CD1C[73u] = method_23;
		DFB3CD1C[74u] = method_41;
		DFB3CD1C[75u] = BC8DE100;
		DFB3CD1C[76u] = D79DB0A9;
		DFB3CD1C[77u] = method_16;
		DFB3CD1C[78u] = CD89DE3D;
		DFB3CD1C[79u] = method_35;
		DFB3CD1C[80u] = FFBFA28B;
		DFB3CD1C[81u] = method_6;
		DFB3CD1C[82u] = DB36699E;
		DFB3CD1C[83u] = DD85BC89;
		DFB3CD1C[84u] = method_19;
		DFB3CD1C[85u] = method_56;
		DFB3CD1C[86u] = method_10;
		DFB3CD1C[87u] = method_29;
		DFB3CD1C[88u] = F3AF08B0;
		DFB3CD1C[89u] = method_27;
		DFB3CD1C[90u] = BD875B2B;
		DFB3CD1C[91u] = method_54;
		DFB3CD1C[92u] = method_51;
		DFB3CD1C[93u] = method_7;
		DFB3CD1C[94u] = AF1D5903;
		DFB3CD1C[95u] = BC8DE100;
		DFB3CD1C[96u] = method_49;
		DFB3CD1C[97u] = AF1D5903;
		DFB3CD1C[98u] = FB97A798;
		DFB3CD1C[99u] = C4037280;
		DFB3CD1C[100u] = AFA4C096;
		DFB3CD1C[101u] = method_30;
		DFB3CD1C[102u] = BD875B2B;
		DFB3CD1C[103u] = method_38;
		DFB3CD1C[104u] = D79DB0A9;
		DFB3CD1C[105u] = method_52;
		DFB3CD1C[106u] = C4037280;
		DFB3CD1C[107u] = method_3;
		DFB3CD1C[108u] = BC8DE100;
		DFB3CD1C[109u] = F9898DB8;
		DFB3CD1C[110u] = F9377803;
		DFB3CD1C[111u] = DD85BC89;
		DFB3CD1C[112u] = BC8DE100;
		DFB3CD1C[113u] = method_37;
		DFB3CD1C[114u] = method_19;
		DFB3CD1C[115u] = F9898DB8;
		DFB3CD1C[116u] = method_5;
		DFB3CD1C[117u] = method_4;
		DFB3CD1C[118u] = method_51;
		DFB3CD1C[119u] = method_41;
		DFB3CD1C[120u] = CA9E4889;
		DFB3CD1C[121u] = BC8DE100;
		DFB3CD1C[122u] = CA9E4889;
		DFB3CD1C[123u] = method_56;
		DFB3CD1C[124u] = method_34;
		DFB3CD1C[125u] = B19ECE19;
		DFB3CD1C[126u] = method_11;
		DFB3CD1C[127u] = B590D8BA;
		DFB3CD1C[128u] = method_51;
		DFB3CD1C[129u] = method_19;
		DFB3CD1C[130u] = method_24;
		DFB3CD1C[131u] = method_28;
		DFB3CD1C[132u] = method_24;
		DFB3CD1C[133u] = EA27FA8A;
		DFB3CD1C[134u] = DB36699E;
		DFB3CD1C[135u] = method_50;
		DFB3CD1C[136u] = method_61;
		DFB3CD1C[137u] = method_0;
		DFB3CD1C[138u] = method_11;
		DFB3CD1C[139u] = B590D8BA;
		DFB3CD1C[140u] = B19ECE19;
		DFB3CD1C[141u] = BC8DE100;
		DFB3CD1C[142u] = B19ECE19;
		DFB3CD1C[143u] = method_5;
		DFB3CD1C[144u] = B590D8BA;
		DFB3CD1C[145u] = B590D8BA;
		DFB3CD1C[146u] = B590D8BA;
		DFB3CD1C[147u] = method_50;
		DFB3CD1C[148u] = method_57;
		DFB3CD1C[149u] = method_16;
		DFB3CD1C[150u] = method_22;
		DFB3CD1C[151u] = BD875B2B;
		DFB3CD1C[152u] = method_38;
		DFB3CD1C[153u] = CA9E4889;
		DFB3CD1C[154u] = B590D8BA;
		DFB3CD1C[155u] = method_30;
		DFB3CD1C[156u] = method_32;
		DFB3CD1C[157u] = method_24;
		DFB3CD1C[158u] = FC9FD932;
		DFB3CD1C[159u] = B19ECE19;
		DFB3CD1C[160u] = method_27;
		DFB3CD1C[161u] = method_11;
		DFB3CD1C[162u] = CD89DE3D;
		DFB3CD1C[163u] = CD293984;
		DFB3CD1C[164u] = method_55;
		DFB3CD1C[165u] = CD89DE3D;
		DFB3CD1C[166u] = B82DF99A;
		DFB3CD1C[167u] = method_24;
		DFB3CD1C[168u] = method_49;
		DFB3CD1C[169u] = EA27FA8A;
		DFB3CD1C[170u] = B590D8BA;
		DFB3CD1C[171u] = method_31;
		DFB3CD1C[172u] = C4037280;
		DFB3CD1C[173u] = CBB5C4B9;
		DFB3CD1C[174u] = method_0;
		DFB3CD1C[175u] = method_15;
		DFB3CD1C[176u] = B590D8BA;
		DFB3CD1C[177u] = method_16;
		DFB3CD1C[178u] = B82DF99A;
		DFB3CD1C[179u] = F9377803;
		DFB3CD1C[180u] = method_55;
		DFB3CD1C[181u] = method_51;
		DFB3CD1C[182u] = method_22;
		DFB3CD1C[183u] = method_33;
		DFB3CD1C[184u] = BC8DE100;
		DFB3CD1C[185u] = method_49;
		DFB3CD1C[186u] = F9377803;
		DFB3CD1C[187u] = CA9E4889;
		DFB3CD1C[188u] = method_61;
		DFB3CD1C[189u] = D288DE9F;
		DFB3CD1C[190u] = method_36;
		DFB3CD1C[191u] = EA27FA8A;
		DFB3CD1C[192u] = method_45;
		DFB3CD1C[193u] = method_24;
		DFB3CD1C[194u] = method_55;
		DFB3CD1C[195u] = method_17;
		DFB3CD1C[196u] = BC8DE100;
		DFB3CD1C[197u] = method_5;
		DFB3CD1C[198u] = method_19;
		DFB3CD1C[199u] = method_54;
		DFB3CD1C[200u] = F21A098B;
		DFB3CD1C[201u] = method_28;
		DFB3CD1C[202u] = method_34;
		DFB3CD1C[203u] = method_61;
		DFB3CD1C[204u] = method_55;
		DFB3CD1C[205u] = CD89DE3D;
		DFB3CD1C[206u] = method_54;
		DFB3CD1C[207u] = A0B7A8BE;
		DFB3CD1C[208u] = method_52;
		DFB3CD1C[209u] = CA9E4889;
		DFB3CD1C[210u] = method_51;
		DFB3CD1C[211u] = method_19;
		DFB3CD1C[212u] = EA27FA8A;
		DFB3CD1C[213u] = method_55;
		DFB3CD1C[214u] = CD89DE3D;
		DFB3CD1C[215u] = method_17;
		DFB3CD1C[216u] = method_37;
		DFB3CD1C[217u] = method_33;
		DFB3CD1C[218u] = B19ECE19;
		DFB3CD1C[219u] = method_31;
		DFB3CD1C[220u] = method_16;
		DFB3CD1C[221u] = C4037280;
		DFB3CD1C[222u] = A0B7A8BE;
		DFB3CD1C[223u] = method_52;
		DFB3CD1C[224u] = method_11;
		DFB3CD1C[225u] = CA9E4889;
		DFB3CD1C[226u] = CA9E4889;
		DFB3CD1C[227u] = method_41;
		DFB3CD1C[228u] = CD293984;
		DFB3CD1C[229u] = method_41;
		DFB3CD1C[230u] = BC8DE100;
		DFB3CD1C[231u] = D288DE9F;
		DFB3CD1C[232u] = method_31;
		DFB3CD1C[233u] = BD875B2B;
		DFB3CD1C[234u] = method_32;
		DFB3CD1C[235u] = method_36;
		DFB3CD1C[236u] = FFBFA28B;
		DFB3CD1C[237u] = method_22;
		DFB3CD1C[238u] = AFA4C096;
		DFB3CD1C[239u] = method_51;
		DFB3CD1C[240u] = EB3E943E;
		DFB3CD1C[241u] = method_30;
		DFB3CD1C[242u] = EA27FA8A;
		DFB3CD1C[243u] = method_7;
		DFB3CD1C[244u] = CBB5C4B9;
		DFB3CD1C[245u] = BD875B2B;
		DFB3CD1C[246u] = method_6;
		DFB3CD1C[247u] = method_28;
		DFB3CD1C[248u] = F9377803;
		DFB3CD1C[249u] = method_28;
		DFB3CD1C[250u] = B590D8BA;
		DFB3CD1C[251u] = CA9E4889;
		DFB3CD1C[252u] = method_41;
		DFB3CD1C[253u] = D288DE9F;
		DFB3CD1C[254u] = method_11;
		DFB3CD1C[255u] = B590D8BA;
	}
}
