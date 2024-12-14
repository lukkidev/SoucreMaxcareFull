using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq;

internal class Class98
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A63E808B
	{
		public static readonly A63E808B _003C_003E9 = new A63E808B();

		public static Func<string, Guid> _003C_003E9__41_0;

		public static Func<string, Guid> _003C_003E9__41_1;

		internal Guid method_0(string string_0)
		{
			return Guid.NewGuid();
		}

		internal Guid C73B4120(string A5A6F111)
		{
			return Guid.NewGuid();
		}
	}

	internal static string smethod_0(int B6A673B9, string A8BFAC91, string D726D181, string C50DBBAD = "", int F192BD03 = 60)
	{
		F3958F9B f3958F9B = new F3958F9B();
		A8BFAC91 = A8BFAC91.Substring(0, A8BFAC91.LastIndexOf("=") + 1) + D726D181;
		int tickCount = Environment.TickCount;
		do
		{
			string text = f3958F9B.method_0(A8BFAC91);
			try
			{
				text = "{\"data\":" + text + "}";
				JObject jObject = JObject.Parse(text);
				int num = jObject["data"].Count() - 1;
				while (num >= 0)
				{
					jObject["data"]![num]!["created_at"]!.ToString();
					string bF1BE = jObject["data"]![num]!["body"]!.ToString();
					string text2 = smethod_1(bF1BE, B6A673B9, C50DBBAD);
					if (!(text2 != ""))
					{
						num--;
						continue;
					}
					return text2;
				}
			}
			catch
			{
			}
			GClass8.smethod_53(3.0);
		}
		while (Environment.TickCount - tickCount < F192BD03 * 1000);
		return "";
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetOtp(byte[] byte_0, byte[] byte_1, byte[] byte_2);

	public static string smethod_1(string BF1BE333, int int_0, string EA255135)
	{
		return GClass8.smethod_10(GetOtp(GClass8.smethod_11(int_0.ToString()), GClass8.smethod_11(BF1BE333), GClass8.smethod_11(EA255135)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetOtpHotmailByDongVan(byte[] byte_0, byte[] byte_1, byte[] AD25DA94, byte[] byte_2, byte[] EB027410, byte[] byte_3);

	public static string smethod_2(int int_0, string F4BA3594, string string_0, int int_1 = 60, string string_1 = "", string string_2 = "")
	{
		return GClass8.smethod_10(GetOtpHotmailByDongVan(GClass8.smethod_11(int_0.ToString()), GClass8.smethod_11(F4BA3594), GClass8.smethod_11(string_0), GClass8.smethod_11(int_1.ToString()), GClass8.smethod_11(string_1), GClass8.smethod_11(string_2)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckDonglaomail(byte[] byte_0);

	public static bool ED2A0894(string DF0165B6)
	{
		string value = GClass8.smethod_10(CheckDonglaomail(GClass8.smethod_11(DF0165B6)));
		bool result = false;
		bool.TryParse(value, out result);
		return result;
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetOtpByDonglaomail(byte[] byte_0, byte[] byte_1, byte[] C10D3F22, byte[] C12AB5A2, byte[] E5AEDD21, byte[] D2866C34, byte[] byte_2);

	public static string smethod_3(int C293891D, string string_0, string string_1, int C7840313 = 60, string string_2 = "", string D73F3639 = "")
	{
		string string_3 = GClass25.smethod_0("configGeneral").C0288288("txtTokenDonglaomail");
		return GClass8.smethod_10(GetOtpByDonglaomail(GClass8.smethod_11(C293891D.ToString()), GClass8.smethod_11(string_0), GClass8.smethod_11(string_1), GClass8.smethod_11(string_3), GClass8.smethod_11(C7840313.ToString()), GClass8.smethod_11(string_2), GClass8.smethod_11(D73F3639)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr Check1secMail(byte[] byte_0);

	public static bool smethod_4(string AF03E61E)
	{
		string value = GClass8.smethod_10(Check1secMail(GClass8.smethod_11(AF03E61E)));
		bool result = false;
		bool.TryParse(value, out result);
		return result;
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetOtp1secMail(byte[] byte_0, byte[] FF86AFAF, byte[] byte_1, byte[] AB0FF53A, byte[] D703D331);

	public static string smethod_5(int int_0, string string_0, int B2AA9EAA = 60, string string_1 = "", string string_2 = "")
	{
		return GClass8.smethod_10(GetOtp1secMail(GClass8.smethod_11(int_0.ToString()), GClass8.smethod_11(string_0), GClass8.smethod_11(B2AA9EAA.ToString()), GClass8.smethod_11(string_1), GClass8.smethod_11(string_2)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckMailtula(byte[] byte_0);

	public static bool smethod_6(string string_0)
	{
		string value = GClass8.smethod_10(CheckMailtula(GClass8.smethod_11(string_0)));
		bool result = false;
		bool.TryParse(value, out result);
		return result;
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetOtpMailtula(byte[] CCBE9221, byte[] byte_0, byte[] D88C19BE, byte[] EABD68A2, byte[] byte_1);

	public static string smethod_7(int int_0, string F9233088, int F49B1616 = 60, string string_0 = "", string A03214A7 = "")
	{
		return GClass8.smethod_10(GetOtpMailtula(GClass8.smethod_11(int_0.ToString()), GClass8.smethod_11(F9233088), GClass8.smethod_11(F49B1616.ToString()), GClass8.smethod_11(string_0), GClass8.smethod_11(A03214A7)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckUnlimitMail(byte[] byte_0);

	public static bool smethod_8(string string_0)
	{
		string value = GClass8.smethod_10(CheckUnlimitMail(GClass8.smethod_11(string_0)));
		bool result = false;
		bool.TryParse(value, out result);
		return result;
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetOtpByUnlimitMail(byte[] byte_0, byte[] byte_1, byte[] F334C090, byte[] byte_2, byte[] byte_3, byte[] byte_4, byte[] F3A801AC);

	public static string smethod_9(int A486A181, string C113AB22, string EA1AFC82, int int_0 = 60, string B13C461E = "", string string_0 = "")
	{
		string string_ = GClass25.smethod_0("configGeneral").C0288288("txtTokenUnlimitMail");
		return GClass8.smethod_10(GetOtpByUnlimitMail(GClass8.smethod_11(A486A181.ToString()), GClass8.smethod_11(C113AB22), GClass8.smethod_11(EA1AFC82), GClass8.smethod_11(string_), GClass8.smethod_11(int_0.ToString()), GClass8.smethod_11(B13C461E), GClass8.smethod_11(string_0)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CreateUnlimitMail(byte[] C9A41198, byte[] E6913D2C, byte[] byte_0);

	public static string smethod_10(string string_0, string string_1)
	{
		string string_2 = GClass25.smethod_0("configGeneral").C0288288("txtTokenUnlimitMail");
		return GClass8.smethod_10(CreateUnlimitMail(GClass8.smethod_11(string_0), GClass8.smethod_11(string_1), GClass8.smethod_11(string_2)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckHotmail9(byte[] AC021B98);

	public static bool A3009823(string DCAC2312)
	{
		string value = GClass8.smethod_10(CheckHotmail9(GClass8.smethod_11(DCAC2312)));
		bool result = false;
		bool.TryParse(value, out result);
		return result;
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetOtpByHotmail9(byte[] byte_0, byte[] byte_1, byte[] D024DE2C, byte[] byte_2, byte[] byte_3, byte[] E2BB1C0B);

	public static string smethod_11(int int_0, string F48B291A, string string_0, int int_1 = 60, string string_1 = "", string string_2 = "")
	{
		return GClass8.smethod_10(GetOtpByHotmail9(GClass8.smethod_11(int_0.ToString()), GClass8.smethod_11(F48B291A), GClass8.smethod_11(string_0), GClass8.smethod_11(int_1.ToString()), GClass8.smethod_11(string_1), GClass8.smethod_11(string_2)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CreateHotmail9(byte[] byte_0, byte[] byte_1);

	public static string C7A5BAB9(string AEBA3E20, string string_0)
	{
		return GClass8.smethod_10(CreateHotmail9(GClass8.smethod_11(AEBA3E20), GClass8.smethod_11(string_0)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetTokenHotmail9(byte[] byte_0, byte[] D0926304);

	public static string FF118212(string string_0, string E306C512)
	{
		return GClass8.smethod_10(GetTokenHotmail9(GClass8.smethod_11(string_0), GClass8.smethod_11(E306C512)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckMailtm(byte[] CD2CF5A9);

	public static bool D286A92E(string F79F12B4)
	{
		string value = GClass8.smethod_10(CheckMailtm(GClass8.smethod_11(F79F12B4)));
		bool result = false;
		bool.TryParse(value, out result);
		return result;
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetOtpByMailtm(byte[] byte_0, byte[] D42962B6, byte[] byte_1, byte[] byte_2, byte[] byte_3, byte[] byte_4);

	public static string smethod_12(int int_0, string string_0, string string_1, int E00F7FB9 = 60, string string_2 = "", string string_3 = "")
	{
		return GClass8.smethod_10(GetOtpByMailtm(GClass8.smethod_11(int_0.ToString()), GClass8.smethod_11(string_0), GClass8.smethod_11(string_1), GClass8.smethod_11(E00F7FB9.ToString()), GClass8.smethod_11(string_2), GClass8.smethod_11(string_3)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CreateMailtm(byte[] A037853F, byte[] byte_0);

	public static string AB9E80B9(string AC0B233A, string FD9343A8)
	{
		return GClass8.smethod_10(CreateMailtm(GClass8.smethod_11(AC0B233A), GClass8.smethod_11(FD9343A8)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetTokenMailtm(byte[] byte_0, byte[] byte_1);

	public static string smethod_13(string string_0, string string_1)
	{
		return GClass8.smethod_10(GetTokenMailtm(GClass8.smethod_11(string_0), GClass8.smethod_11(string_1)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetOtpGenerator(byte[] D6AAFA19, byte[] byte_0, byte[] A4273503, byte[] byte_1, byte[] byte_2);

	public static string smethod_14(int int_0, string A115FD87, int int_1, string string_0, string string_1)
	{
		return GClass8.smethod_10(GetOtpGenerator(GClass8.smethod_11(int_0.ToString()), GClass8.smethod_11(A115FD87), GClass8.smethod_11(int_1.ToString()), GClass8.smethod_11(string_0), GClass8.smethod_11(string_1)));
	}

	public static string smethod_15(string string_0)
	{
        string text = GClass8.smethod_70((from string_1 in Class17.smethod_4()
                                          orderby Guid.NewGuid()
                                          select string_0).First() + (from A5A6F111 in Class17.smethod_6()
                                                                      orderby Guid.NewGuid()
                                                                      select A5A6F111).First()).Replace(" ", "").ToLower() + GClass8.smethod_52(6);
        return text + "@" + string_0;
    }

	public static string A1A49D95(int C80E1294, string string_0, string B40C6AA3, string string_1, int C30BFE99, string string_2, string string_3)
	{
		string text = "";
		if (smethod_4(string_0))
		{
			text = smethod_5(C80E1294, string_0, C30BFE99, string_2, string_3);
		}
		else if (smethod_6(string_0))
		{
			text = smethod_7(C80E1294, string_0, C30BFE99, string_2, string_3);
		}
		else if (ED2A0894(string_0))
		{
			text = smethod_3(C80E1294, string_0, B40C6AA3, C30BFE99, string_2, string_3);
		}
		else if (A3009823(string_0))
		{
			text = smethod_11(C80E1294, string_0, B40C6AA3, C30BFE99, string_2, string_3);
		}
		else if (D286A92E(string_0))
		{
			text = smethod_12(C80E1294, string_0, B40C6AA3, C30BFE99, string_2, string_3);
		}
		else if (smethod_8(string_0))
		{
			text = smethod_9(C80E1294, string_0, B40C6AA3, C30BFE99, string_2, string_3);
		}
		else if (GClass8.smethod_78(string_0, GClass25.smethod_0("configGeneral").C5A69DA0("txtGeneratorDomain")) != "")
		{
			text = smethod_14(C80E1294, string_0, C30BFE99, string_2, string_3);
		}
		else
		{
			if (string_1 != "")
			{
				text = GClass21.smethod_2(C80E1294, string_0, string_1, C30BFE99, string_2, string_3);
			}
			if (text == "" || text == "fail")
			{
				text = GClass21.smethod_0(C80E1294, string_0, B40C6AA3, C30BFE99, string_2, string_3);
				if (text == "fail" && string_1 != "")
				{
					text = "";
				}
			}
		}
		if (text == "")
		{
			text = string_3;
		}
		return text;
	}
}
