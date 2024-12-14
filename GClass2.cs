using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public class GClass2
{
	public delegate bool GDelegate0(IntPtr intptr_0, IntPtr A2B5F5B3);

	private delegate bool Delegate0(IntPtr intptr_0, IntPtr intptr_1);

	[Flags]
	public enum FBA2733C : uint
	{
		C6980D13 = 0x2u,
		flag_1 = 0x4u,
		flag_2 = 0x20u,
		flag_3 = 0x40u,
		flag_4 = 0x1u,
		BBA9D823 = 0x8000u,
		C400A53E = 0x8u,
		flag_7 = 0x10u,
		E38BCA01 = 0x800u,
		flag_9 = 0x80u,
		E2BB049B = 0x100u,
		flag_11 = 0x1u,
		FF8016B8 = 0x2u
	}

	private struct Struct1
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int F1012F0E;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class A69BB30C
	{
		public static readonly A69BB30C _003C_003E9 = new A69BB30C();

		public static Func<Process, bool> _003C_003E9__25_0;

		public static Func<Process, bool> _003C_003E9__26_0;

		public static Delegate0 _003C_003E9__30_0;

		internal bool method_0(Process CD35D899)
		{
			return CD35D899.MainWindowHandle != IntPtr.Zero;
		}

		internal bool method_1(Process ECAE8729)
		{
			return ECAE8729.MainWindowHandle != IntPtr.Zero;
		}

		internal bool method_2(IntPtr intptr_0, IntPtr FB953B02)
		{
			GCHandle gCHandle = GCHandle.FromIntPtr(FB953B02);
			if (gCHandle.Target == null)
			{
				return false;
			}
			List<IntPtr> list = gCHandle.Target as List<IntPtr>;
			list.Add(intptr_0);
			return true;
		}
	}

	[CompilerGenerated]
	private sealed class AB9F011A
	{
		public string D03FC581;

		public string string_0;

		internal bool method_0(IntPtr intptr_0)
		{
			string text = smethod_28(intptr_0);
			string text2 = C1165C36(intptr_0);
			return text == D03FC581 || text2 == string_0;
		}
	}

	[CompilerGenerated]
	private sealed class CE087691
	{
		public string D6A39403;

		public string string_0;

		internal bool BE2E6D1E(IntPtr intptr_0)
		{
			string text = smethod_28(intptr_0);
			string text2 = C1165C36(intptr_0);
			return text == D6A39403 || text2 == string_0;
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string C08F5B3A);

	[DllImport("User32.dll")]
	public static extern bool EnumChildWindows(IntPtr intptr_0, GDelegate0 gdelegate0_0, IntPtr intptr_1);

	[DllImport("User32.dll")]
	public static extern int GetWindowText(IntPtr intptr_0, StringBuilder ECBD32A0, int E807E3BE);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetClassName(IntPtr F90F1433, StringBuilder BA85C82C, int int_0);

	[DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
	private static extern IntPtr FindWindow_1(IntPtr intptr_0, string E0AFCE89);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr C081DF04);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "SendMessage")]
	private static extern IntPtr SendMessage_1(IntPtr intptr_0, int int_0, int int_1, IntPtr intptr_1);

	[DllImport("user32.dll", EntryPoint = "SendMessage")]
	private static extern IntPtr SendMessage_2(IntPtr A981522A, int CB0C899E, IntPtr C9AB9A98, IntPtr intptr_0);

	[DllImport("user32.dll", EntryPoint = "SendMessage")]
	private static extern IntPtr SendMessage_3(IntPtr DD1A103A, int int_0, IntPtr intptr_0, string string_0);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "SendMessage")]
	public static extern int SendMessage_4(IntPtr intptr_0, int C635BA91, int int_0, string string_0);

	[DllImport("user32.dll")]
	private static extern IntPtr GetDlgItem(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll")]
	private static extern bool SetDlgItemTextA(IntPtr B58D60BA, int int_0, string string_0);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr BF372AA1, string A6A68AB7, string FE3E8D90);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PostMessage(IntPtr EE8FB68D, int E01EC4BD, IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("user32.dll", EntryPoint = "PostMessage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PostMessage_1(IntPtr intptr_0, int int_0, IntPtr EA1B87BD, string D8B7B40E);

	[DllImport("user32.dll")]
	private static extern bool SetForegroundWindow(IntPtr intptr_0);

	[DllImport("user32", EntryPoint = "EnumChildWindows")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool EnumChildWindows_1(IntPtr intptr_0, Delegate0 FD02D820, IntPtr C6AAFD28);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	public static extern void mouse_event(uint uint_0, int int_0, int int_1, int B0B174B5, UIntPtr uintptr_0);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool MoveWindow(IntPtr D9BE21BA, int E3A76B0D, int int_0, int E82B1B9D, int int_1, bool bool_0);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint SendInput(uint AD8DB983, GStruct0[] D80F7F91, int int_0);

	public static IntPtr E992CF95(string B800E68F, string string_0 = null)
	{
		IntPtr intPtr = FindWindow(B800E68F, string_0);
		SetForegroundWindow(intPtr);
		return intPtr;
	}

	public static IntPtr smethod_0(IntPtr intptr_0)
	{
		SetForegroundWindow(intptr_0);
		return intptr_0;
	}

	public static bool A2B6453A(IntPtr intptr_0)
	{
		return IsWindowVisible(intptr_0);
	}

	public static IntPtr smethod_1(string E1168F28, string string_0)
	{
		return FindWindow(E1168F28, string_0);
	}

	[DllImport("User32.dll")]
	public static extern bool ShowWindow(IntPtr intptr_0, int int_0);

	public static List<IntPtr> smethod_2(string string_0, string string_1, int int_0 = 1)
	{
		Process[] processes = Process.GetProcesses();
		List<IntPtr> list = new List<IntPtr>();
		int num = 0;
		foreach (Process item in processes.Where((Process CD35D899) => CD35D899.MainWindowHandle != IntPtr.Zero))
		{
			IntPtr mainWindowHandle = item.MainWindowHandle;
			string text = smethod_28(mainWindowHandle);
			string text2 = C1165C36(mainWindowHandle);
			if (text == string_0 || text2 == string_1)
			{
				list.Add(mainWindowHandle);
				if (num >= int_0)
				{
					break;
				}
				num++;
			}
		}
		return list;
	}

	public static IntPtr F6A1CAA8(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		IntPtr result = IntPtr.Zero;
		foreach (Process item in processes.Where((Process ECAE8729) => ECAE8729.MainWindowHandle != IntPtr.Zero))
		{
			IntPtr mainWindowHandle = item.MainWindowHandle;
			string text = smethod_28(mainWindowHandle);
			string text2 = C1165C36(mainWindowHandle);
			Console.WriteLine("className2: " + text);
			Console.WriteLine("text: " + text2);
			Console.WriteLine("=========================");
			if (text == string_0 || text2 == string_1)
			{
				result = mainWindowHandle;
				break;
			}
		}
		return result;
	}

	public static IntPtr smethod_3(IntPtr D6261C2F, string E8BC1505, string A53C319F)
	{
		return FindWindowEx(D6261C2F, IntPtr.Zero, A53C319F, E8BC1505);
	}

	private static IntPtr smethod_4(IntPtr intptr_0, int BD1B4617)
	{
		if (BD1B4617 == 0)
		{
			return intptr_0;
		}
		int num = 0;
		IntPtr intPtr = IntPtr.Zero;
		do
		{
			intPtr = FindWindowEx(intptr_0, intPtr, "Button", null);
			if (intPtr != IntPtr.Zero)
			{
				num++;
			}
		}
		while (num < BD1B4617 && intPtr != IntPtr.Zero);
		return intPtr;
	}

	public static IntPtr smethod_5(IntPtr E4B670A7, int int_0)
	{
		return GetDlgItem(E4B670A7, int_0);
	}

	public static List<IntPtr> smethod_6(IntPtr intptr_0)
	{
		List<IntPtr> list = new List<IntPtr>();
		GCHandle value = GCHandle.Alloc(list);
		IntPtr c6AAFD = GCHandle.ToIntPtr(value);
		try
		{
			Delegate0 fD02D = delegate(IntPtr intptr_0, IntPtr FB953B02)
			{
				GCHandle gCHandle = GCHandle.FromIntPtr(FB953B02);
				if (gCHandle.Target == null)
				{
					return false;
				}
				List<IntPtr> list2 = gCHandle.Target as List<IntPtr>;
				list2.Add(intptr_0);
				return true;
			};
			EnumChildWindows_1(intptr_0, fD02D, c6AAFD);
		}
		finally
		{
			value.Free();
		}
		return list;
	}

	[DllImport("user32.dll")]
	public static extern bool ShowWindowAsync(HandleRef handleRef_0, int int_0);

	public static IntPtr smethod_7(List<IntPtr> BE90180D, string string_0, string B21F5C8F)
	{
		return BE90180D.Find(delegate(IntPtr intptr_0)
		{
			string text = smethod_28(intptr_0);
			string text2 = C1165C36(intptr_0);
			return text == string_0 || text2 == B21F5C8F;
		});
	}

	public static List<IntPtr> smethod_8(List<IntPtr> F20A699E, string B1BBC1BC, string string_0)
	{
		new List<IntPtr>();
		IEnumerable<IntPtr> source = F20A699E.Where(delegate(IntPtr intptr_0)
		{
			string text = smethod_28(intptr_0);
			string text2 = C1165C36(intptr_0);
			return text == B1BBC1BC || text2 == string_0;
		});
		return source.ToList();
	}

	public static IntPtr D281CD36(IntPtr intptr_0, string BB849F9A, string string_0)
	{
		return smethod_7(smethod_6(intptr_0), BB849F9A, string_0);
	}

	public static List<IntPtr> A313BD88(IntPtr intptr_0, string string_0, string string_1)
	{
		return smethod_8(smethod_6(intptr_0), string_0, string_1);
	}

	public static bool smethod_9(IntPtr DCB616AE, IntPtr intptr_0)
	{
		string text = C1165C36(DCB616AE);
		string text2 = smethod_28(DCB616AE);
		if (text == "&Options >>" && text2.StartsWith("ToolbarWindow32"))
		{
			SendMessage_2(DCB616AE, 0, IntPtr.Zero, IntPtr.Zero);
			return false;
		}
		return true;
	}

	public static void A088D93B(IntPtr intptr_0, int A60E4E35)
	{
		IntPtr dlgItem = GetDlgItem(intptr_0, A60E4E35);
		int int_ = 0 | (A60E4E35 & 0xFFFF);
		SendMessage_1(intptr_0, 273, int_, dlgItem);
	}

	public static void smethod_10(IntPtr intptr_0)
	{
		SendMessage_2(intptr_0, 513, IntPtr.Zero, IntPtr.Zero);
		SendMessage_2(intptr_0, 514, IntPtr.Zero, IntPtr.Zero);
	}

	public static void FC09A4AA(IntPtr DC96EE21, int int_0, int int_1, GEnum1 genum1_0 = GEnum1.const_0, int int_2 = 1)
	{
		int e01EC4BD = 0;
		int e01EC4BD2 = 0;
		if (genum1_0 == GEnum1.const_0)
		{
			e01EC4BD = 513;
			e01EC4BD2 = 514;
		}
		if (genum1_0 == GEnum1.FC3FF90C)
		{
			e01EC4BD = 516;
			e01EC4BD2 = 517;
		}
		IntPtr intptr_ = E428C019(int_0, int_1);
		if (genum1_0 != 0 && genum1_0 != GEnum1.FC3FF90C)
		{
			if (genum1_0 == GEnum1.ED1B0B21)
			{
				e01EC4BD = 515;
				e01EC4BD2 = 514;
			}
			if (genum1_0 == GEnum1.const_3)
			{
				e01EC4BD = 518;
				e01EC4BD2 = 517;
			}
			PostMessage(DC96EE21, e01EC4BD, new IntPtr(1), intptr_);
			PostMessage(DC96EE21, e01EC4BD2, new IntPtr(0), intptr_);
		}
		else
		{
			for (int i = 0; i < int_2; i++)
			{
				PostMessage(DC96EE21, 6, new IntPtr(1), intptr_);
				PostMessage(DC96EE21, e01EC4BD, new IntPtr(1), intptr_);
				PostMessage(DC96EE21, e01EC4BD2, new IntPtr(0), intptr_);
			}
		}
	}

	public static void E8A1413A(IntPtr A62A0185, int int_0, int int_1, int DB260122, int D6875881, int int_2 = 10, int int_3 = 10, double double_0 = 0.05)
	{
		int e01EC4BD = 513;
		int e01EC4BD2 = 514;
		IntPtr intptr_ = E428C019(int_0, int_1);
		IntPtr intptr_2 = E428C019(DB260122, D6875881);
		if (DB260122 < int_0)
		{
			int_2 *= -1;
		}
		if (D6875881 < int_1)
		{
			int_3 *= -1;
		}
		PostMessage(A62A0185, 6, new IntPtr(1), intptr_);
		PostMessage(A62A0185, e01EC4BD, new IntPtr(1), intptr_);
		bool flag = false;
		bool flag2 = false;
		while (true)
		{
			PostMessage(A62A0185, 512, new IntPtr(1), E428C019(int_0, int_1));
			if (int_2 <= 0)
			{
				if (int_0 > DB260122)
				{
					int_0 += int_2;
				}
				else
				{
					flag = true;
				}
			}
			else if (int_0 < DB260122)
			{
				int_0 += int_2;
			}
			else
			{
				flag = true;
			}
			if (int_3 > 0)
			{
				if (int_1 < D6875881)
				{
					int_1 += int_3;
				}
				else
				{
					flag2 = true;
				}
			}
			else if (int_1 > D6875881)
			{
				int_1 += int_3;
			}
			else
			{
				flag2 = true;
			}
			if (flag && flag2)
			{
				break;
			}
			Thread.Sleep(TimeSpan.FromSeconds(double_0));
		}
		PostMessage(A62A0185, e01EC4BD2, new IntPtr(0), intptr_2);
	}

	public static void smethod_11(IntPtr B3BC5EB0, int C5890EA0, int int_0, GEnum1 genum1_0 = GEnum1.const_0, int int_1 = 1)
	{
		int e01EC4BD = 0;
		if (genum1_0 == GEnum1.const_0)
		{
			e01EC4BD = 513;
		}
		if (genum1_0 == GEnum1.FC3FF90C)
		{
			e01EC4BD = 516;
		}
		IntPtr intptr_ = E428C019(C5890EA0, int_0);
		for (int i = 0; i < int_1; i++)
		{
			PostMessage(B3BC5EB0, 6, new IntPtr(1), intptr_);
			PostMessage(B3BC5EB0, e01EC4BD, new IntPtr(1), intptr_);
		}
	}

	public static void smethod_12(IntPtr intptr_0, int int_0, int int_1, GEnum1 F61F4C31 = GEnum1.const_0, int int_2 = 1)
	{
		int cB0C899E = 0;
		if (F61F4C31 == GEnum1.const_0)
		{
			cB0C899E = 514;
		}
		if (F61F4C31 == GEnum1.FC3FF90C)
		{
			cB0C899E = 517;
		}
		IntPtr intPtr = E428C019(int_0, int_1);
		for (int i = 0; i < int_2; i++)
		{
			PostMessage(intptr_0, 6, new IntPtr(1), intPtr);
			SendMessage_2(intptr_0, cB0C899E, new IntPtr(0), intPtr);
		}
	}

	public static void smethod_13(IntPtr intptr_0, string string_0)
	{
		SendMessage_4(intptr_0, 12, 0, string_0);
	}

	public static void smethod_14(IntPtr intptr_0, GEnum0 genum0_0)
	{
		PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(intptr_0, 256, new IntPtr((int)genum0_0), new IntPtr(1));
		PostMessage(intptr_0, 257, new IntPtr((int)genum0_0), new IntPtr(0));
	}

	public static void CFBE3F24(IntPtr intptr_0, string string_0, float float_0 = 0.1f)
	{
		string text = string_0.ToLower();
		foreach (char c in text)
		{
			GEnum0 genum0_ = GEnum0.const_31;
			char c2 = c;
			switch (c2)
			{
			default:
				switch (c2)
				{
				case 'a':
					genum0_ = GEnum0.const_41;
					break;
				case 'b':
					genum0_ = GEnum0.const_42;
					break;
				case 'c':
					genum0_ = GEnum0.E681DCB7;
					break;
				case 'd':
					genum0_ = GEnum0.const_44;
					break;
				case 'e':
					genum0_ = GEnum0.D920F188;
					break;
				case 'f':
					genum0_ = GEnum0.const_46;
					break;
				case 'g':
					genum0_ = GEnum0.const_47;
					break;
				case 'h':
					genum0_ = GEnum0.B702A013;
					break;
				case 'i':
					genum0_ = GEnum0.const_49;
					break;
				case 'j':
					genum0_ = GEnum0.const_50;
					break;
				case 'k':
					genum0_ = GEnum0.const_51;
					break;
				case 'l':
					genum0_ = GEnum0.const_52;
					break;
				case 'm':
					genum0_ = GEnum0.AEBE889C;
					break;
				case 'n':
					genum0_ = GEnum0.const_54;
					break;
				case 'o':
					genum0_ = GEnum0.const_55;
					break;
				case 'p':
					genum0_ = GEnum0.F306210D;
					break;
				case 'q':
					genum0_ = GEnum0.const_57;
					break;
				case 'r':
					genum0_ = GEnum0.F510E9B1;
					break;
				case 's':
					genum0_ = GEnum0.CF19E03C;
					break;
				case 't':
					genum0_ = GEnum0.const_60;
					break;
				case 'u':
					genum0_ = GEnum0.EB9B3589;
					break;
				case 'v':
					genum0_ = GEnum0.E681DCB7;
					break;
				case 'w':
					genum0_ = GEnum0.const_63;
					break;
				case 'x':
					genum0_ = GEnum0.const_64;
					break;
				case 'y':
					genum0_ = GEnum0.const_65;
					break;
				case 'z':
					genum0_ = GEnum0.CB00FD10;
					break;
				}
				break;
			case '0':
				genum0_ = GEnum0.const_31;
				break;
			case '1':
				genum0_ = GEnum0.D8897EBA;
				break;
			case '2':
				genum0_ = GEnum0.CF2CB0AB;
				break;
			case '3':
				genum0_ = GEnum0.const_34;
				break;
			case '4':
				genum0_ = GEnum0.const_35;
				break;
			case '5':
				genum0_ = GEnum0.const_36;
				break;
			case '6':
				genum0_ = GEnum0.E4B747AD;
				break;
			case '7':
				genum0_ = GEnum0.const_38;
				break;
			case '8':
				genum0_ = GEnum0.const_39;
				break;
			case '9':
				genum0_ = GEnum0.const_40;
				break;
			}
			smethod_14(intptr_0, genum0_);
			Thread.Sleep(TimeSpan.FromSeconds(float_0));
		}
	}

	public static void smethod_15(IntPtr C93A0E85, GEnum0 genum0_0)
	{
		PostMessage(C93A0E85, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(C93A0E85, 257, new IntPtr((int)genum0_0), new IntPtr(0));
	}

	public static void smethod_16(IntPtr intptr_0, GEnum0 D1036FBD)
	{
		PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(intptr_0, 258, new IntPtr((int)D1036FBD), new IntPtr(0));
	}

	public static void smethod_17(IntPtr intptr_0, int D40A67A2)
	{
		PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(intptr_0, 258, new IntPtr(D40A67A2), new IntPtr(0));
	}

	public static void smethod_18(IntPtr BE3A59A0, GEnum0 A598ACB9)
	{
		PostMessage(BE3A59A0, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(BE3A59A0, 256, new IntPtr((int)A598ACB9), new IntPtr(0));
	}

	public static void EA8130A3(IntPtr intptr_0, string A33177A9, float C5262CBF = 0.1f)
	{
		string text = A33177A9.ToLower();
		foreach (char d40A67A in text)
		{
			smethod_17(intptr_0, d40A67A);
		}
	}

	public static void smethod_19(B524A18B B32A54B5)
	{
		smethod_21(B32A54B5);
	}

	public static void smethod_20(B524A18B[] DCBF2B99)
	{
		foreach (B524A18B b524A18B_ in DCBF2B99)
		{
			smethod_22(b524A18B_);
		}
		foreach (B524A18B dCA9FA3E in DCBF2B99)
		{
			smethod_23(dCA9FA3E);
		}
	}

	public static void E212A62B(string CD96F200)
	{
		Clipboard.SetText(CD96F200);
		smethod_20(new B524A18B[2]
		{
			B524A18B.const_107,
			B524A18B.const_94
		});
	}

	public static void smethod_21(B524A18B D9A61E9A)
	{
		GStruct0 gStruct = default(GStruct0);
		gStruct.uint_0 = 1u;
		GStruct0 gStruct2 = gStruct;
		ref CF1FA40C eF81D4B = ref gStruct2.EF81D4B6;
		BE0C668C be0C668C_ = new BE0C668C
		{
			ushort_0 = (ushort)D9A61E9A,
			D712C199 = 0,
			uint_0 = 0u,
			B18B480C = 0u,
			intptr_0 = IntPtr.Zero
		};
		eF81D4B.be0C668C_0 = be0C668C_;
		gStruct = default(GStruct0);
		gStruct.uint_0 = 1u;
		GStruct0 gStruct3 = gStruct;
		ref CF1FA40C eF81D4B2 = ref gStruct3.EF81D4B6;
		be0C668C_ = new BE0C668C
		{
			ushort_0 = (ushort)D9A61E9A,
			D712C199 = 0,
			uint_0 = 2u,
			B18B480C = 0u,
			intptr_0 = IntPtr.Zero
		};
		eF81D4B2.be0C668C_0 = be0C668C_;
		GStruct0[] d80F7F = new GStruct0[2] { gStruct2, gStruct3 };
		if (SendInput(2u, d80F7F, Marshal.SizeOf(typeof(GStruct0))) == 0)
		{
			throw new Exception();
		}
	}

	public static void C2B6768A(string A786981D, double A4815094 = 0.5)
	{
		for (int i = 0; i < A786981D.Length; i++)
		{
			switch (A786981D[i])
			{
			case '0':
				smethod_21(B524A18B.B934D920);
				break;
			case '1':
				smethod_21(B524A18B.const_64);
				break;
			case '2':
				smethod_21(B524A18B.const_65);
				break;
			case '3':
				smethod_21(B524A18B.E280AF3C);
				break;
			case '4':
				smethod_21(B524A18B.const_67);
				break;
			case '5':
				smethod_21(B524A18B.A90BBB36);
				break;
			case '6':
				smethod_21(B524A18B.DA376ABF);
				break;
			case '7':
				smethod_21(B524A18B.const_70);
				break;
			case '8':
				smethod_21(B524A18B.const_71);
				break;
			case '9':
				smethod_21(B524A18B.const_72);
				break;
			}
			Thread.Sleep(TimeSpan.FromSeconds(A4815094));
		}
	}

	public static void smethod_22(B524A18B b524A18B_0)
	{
		GStruct0 gStruct = default(GStruct0);
		gStruct.uint_0 = 1u;
		GStruct0 gStruct2 = gStruct;
		gStruct2.EF81D4B6.be0C668C_0 = default(BE0C668C);
		gStruct2.EF81D4B6.be0C668C_0.ushort_0 = (ushort)b524A18B_0;
		gStruct2.EF81D4B6.be0C668C_0.D712C199 = 0;
		gStruct2.EF81D4B6.be0C668C_0.uint_0 = 0u;
		gStruct2.EF81D4B6.be0C668C_0.B18B480C = 0u;
		gStruct2.EF81D4B6.be0C668C_0.intptr_0 = IntPtr.Zero;
		GStruct0[] d80F7F = new GStruct0[1] { gStruct2 };
		if (SendInput(1u, d80F7F, Marshal.SizeOf(typeof(GStruct0))) == 0)
		{
			throw new Exception();
		}
	}

	public static void smethod_23(B524A18B DCA9FA3E)
	{
		GStruct0 gStruct = default(GStruct0);
		gStruct.uint_0 = 1u;
		GStruct0 gStruct2 = gStruct;
		gStruct2.EF81D4B6.be0C668C_0 = default(BE0C668C);
		gStruct2.EF81D4B6.be0C668C_0.ushort_0 = (ushort)DCA9FA3E;
		gStruct2.EF81D4B6.be0C668C_0.D712C199 = 0;
		gStruct2.EF81D4B6.be0C668C_0.uint_0 = 2u;
		gStruct2.EF81D4B6.be0C668C_0.B18B480C = 0u;
		gStruct2.EF81D4B6.be0C668C_0.intptr_0 = IntPtr.Zero;
		GStruct0[] d80F7F = new GStruct0[1] { gStruct2 };
		if (SendInput(1u, d80F7F, Marshal.SizeOf(typeof(GStruct0))) == 0)
		{
			throw new Exception();
		}
	}

	public static void smethod_24(int F3B211A1, int int_0, GEnum1 genum1_0 = GEnum1.const_0)
	{
		Cursor.Position = new Point(F3B211A1, int_0);
		FCB176B3(genum1_0);
	}

	public static void smethod_25(Point point_0, int int_0, bool AB90A83E = false)
	{
		Cursor.Position = point_0;
		mouse_event(2u, 0, 0, 0, UIntPtr.Zero);
		for (int i = 0; i < int_0; i++)
		{
			if (!AB90A83E)
			{
				mouse_event(1u, 1, 0, 0, UIntPtr.Zero);
			}
			else
			{
				mouse_event(1u, -1, 0, 0, UIntPtr.Zero);
			}
		}
		mouse_event(32772u, 0, 0, 0, UIntPtr.Zero);
	}

	public static void smethod_26(Point point_0, int AF22162C, bool bool_0 = false)
	{
		Cursor.Position = point_0;
		mouse_event(2u, 0, 0, 0, UIntPtr.Zero);
		for (int i = 0; i < AF22162C; i++)
		{
			if (!bool_0)
			{
				mouse_event(1u, 0, 1, 0, UIntPtr.Zero);
			}
			else
			{
				mouse_event(1u, 0, -1, 0, UIntPtr.Zero);
			}
		}
		mouse_event(32772u, 0, 0, 0, UIntPtr.Zero);
	}

	public static void smethod_27(Point point_0, int int_0, bool bool_0 = false)
	{
		Cursor.Position = point_0;
		mouse_event(2048u, 0, 0, int_0, UIntPtr.Zero);
	}

	public static void B83BDFBA(Point E4974388, GEnum1 genum1_0 = GEnum1.const_0)
	{
		Cursor.Position = E4974388;
		FCB176B3(genum1_0);
	}

	public static void FCB176B3(GEnum1 genum1_0 = GEnum1.const_0)
	{
		switch (genum1_0)
		{
		case GEnum1.const_0:
			mouse_event(32774u, 0, 0, 0, UIntPtr.Zero);
			break;
		case GEnum1.FC3FF90C:
			mouse_event(32792u, 0, 0, 0, UIntPtr.Zero);
			break;
		case GEnum1.ED1B0B21:
			mouse_event(32774u, 0, 0, 0, UIntPtr.Zero);
			mouse_event(32774u, 0, 0, 0, UIntPtr.Zero);
			break;
		case GEnum1.const_3:
			mouse_event(32792u, 0, 0, 0, UIntPtr.Zero);
			mouse_event(32792u, 0, 0, 0, UIntPtr.Zero);
			break;
		}
	}

	public static string C1165C36(IntPtr B43A5987)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		GetWindowText(B43A5987, stringBuilder, 256);
		return stringBuilder.ToString().Trim();
	}

	public static string smethod_28(IntPtr D892A813)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		GetClassName(D892A813, stringBuilder, 256);
		return stringBuilder.ToString().Trim();
	}

	public static IntPtr smethod_29(int F718D903, int B738B92A)
	{
		return (IntPtr)((B738B92A << 16) | (F718D903 & 0xFFFF));
	}

	public static IntPtr E428C019(int F12C2728, int int_0)
	{
		return (IntPtr)((int_0 << 16) | F12C2728);
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool PrintWindow(IntPtr intptr_0, IntPtr A00D0625, uint uint_0);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool GetWindowRect(IntPtr F29F5A21, out Struct1 C33A7B01);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool IsWindowVisible(IntPtr D703C236);

	[DllImport("gdi32.dll", SetLastError = true)]
	private static extern bool BitBlt(IntPtr A59099AF, int int_0, int B3B4AD09, int int_1, int CE12D836, IntPtr intptr_0, int int_2, int int_3, CopyPixelOperation E0326C80);

	[DllImport("user32.dll")]
	private static extern IntPtr GetDC(IntPtr intptr_0);

	[DllImport("gdi32.dll")]
	private static extern IntPtr CreateCompatibleDC(IntPtr F7A7D018);

	[DllImport("gdi32.dll")]
	private static extern IntPtr CreateCompatibleBitmap(IntPtr A3AF46B4, int int_0, int int_1);

	[DllImport("gdi32.dll")]
	private static extern IntPtr SelectObject(IntPtr C6AA6D1B, IntPtr intptr_0);

	[DllImport("gdi32.dll")]
	private static extern bool DeleteObject(IntPtr intptr_0);

	[DllImport("gdi32.dll")]
	private static extern bool DeleteDC(IntPtr intptr_0);

	[DllImport("user32.dll")]
	private static extern int ReleaseDC(IntPtr CF02CFA9, IntPtr B393C08C);

	public static Bitmap smethod_30(IntPtr intptr_0)
	{
		GetWindowRect(intptr_0, out var C33A7B);
		int num = C33A7B.int_2 - C33A7B.int_0;
		int num2 = C33A7B.F1012F0E - C33A7B.int_1;
		Bitmap bitmap = new Bitmap(num, num2, PixelFormat.Format32bppArgb);
		using (Graphics graphics = Graphics.FromImage(bitmap))
		{
			IntPtr hdc = graphics.GetHdc();
			IntPtr dC = GetDC(intptr_0);
			BitBlt(hdc, 0, 0, num, num2, dC, 0, 0, (CopyPixelOperation)1087111200);
			graphics.ReleaseHdc(hdc);
			ReleaseDC(intptr_0, dC);
		}
		return bitmap;
	}
}
