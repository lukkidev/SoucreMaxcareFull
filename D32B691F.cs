using System;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq;

public class D32B691F
{
	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetInfo(byte[] byte_0);

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetInfo2(byte[] byte_0);

	public static string CBAB1D17(string string_0)
	{
		string text = "fail";
		string text2 = "";
		try
		{
			text2 = GClass8.smethod_10(GetInfo2(GClass8.smethod_11(string_0)));
			return F7AB102E.smethod_0("Số dư") + ": " + JObject.Parse(text2)["user"]!["current_points"]!.ToString();
		}
		catch
		{
			if (text2.Contains("Vui lòng nhập thông tin để đăng nhập"))
			{
				text2 = F7AB102E.smethod_0("API không đúng!");
			}
			return text2;
		}
	}
}
