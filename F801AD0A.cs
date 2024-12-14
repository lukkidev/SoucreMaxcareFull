using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

public class F801AD0A
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string DA09B989;

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return DA09B989;
		}
		[CompilerGenerated]
		private set
		{
			DA09B989 = value;
		}
	}

	public F801AD0A(string D13FDC93)
	{
		String_0 = D13FDC93;
	}

	public bool method_0(int AD0FCC11, string string_0, out string AC98BC26)
	{
		string text = "";
		string text2 = "";
		text2 = ((AD0FCC11 != 0) ? "api.captcha.guru" : "2captcha.com");
		using (WebClient webClient = new WebClient())
		{
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["method"] = "base64";
			nameValueCollection["key"] = String_0;
			nameValueCollection["body"] = string_0;
			byte[] bytes = webClient.UploadValues("http://" + text2 + "/in.php", nameValueCollection);
			text = Encoding.Default.GetString(bytes);
		}
		Thread.Sleep(TimeSpan.FromSeconds(5.0));
		if (text.Substring(0, 3) == "OK|")
		{
			string text3 = text.Remove(0, 3);
			for (int i = 0; i < 24; i++)
			{
				WebRequest webRequest = WebRequest.Create("http://" + text2 + "/res.php?key=" + String_0 + "&action=get&id=" + text3);
				using (WebResponse webResponse = webRequest.GetResponse())
				{
					using StreamReader streamReader = new StreamReader(webResponse.GetResponseStream());
					string text4 = streamReader.ReadToEnd();
					if (text4.Length < 3)
					{
						AC98BC26 = text4;
						return false;
					}
					if (text4.Substring(0, 3) == "OK|")
					{
						AC98BC26 = text4.Remove(0, 3);
						return true;
					}
					if (text4 != "CAPCHA_NOT_READY")
					{
						AC98BC26 = text4;
						return false;
					}
				}
				Thread.Sleep(5000);
			}
			AC98BC26 = "Timeout";
			return false;
		}
		AC98BC26 = text;
		return false;
	}

	public static string smethod_0(int int_0, string string_0, string D79C4C38)
	{
		string AC98BC = "";
		F801AD0A f801AD0A = new F801AD0A(string_0);
		bool flag = f801AD0A.method_0(int_0, D79C4C38, out AC98BC);
		while (!flag)
		{
			flag = f801AD0A.method_0(int_0, D79C4C38, out AC98BC);
			Thread.Sleep(TimeSpan.FromSeconds(2.0));
		}
		return AC98BC;
	}

	public static string D9A69281(string string_0, string string_1, int int_0, string CC9D40A3 = "", string A0B504B9 = "")
	{
		string string_2 = "";
		F801AD0A f801AD0A = new F801AD0A(string_0);
		f801AD0A.method_1(string_1, int_0, out string_2, CC9D40A3, A0B504B9);
		return string_2;
	}

	private bool method_1(string string_0, int int_0, out string string_1, string string_2 = "", string CD3B8233 = "")
	{
		string text = "";
		using (WebClient webClient = new WebClient())
		{
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["method"] = "base64";
			nameValueCollection["key"] = String_0;
			nameValueCollection["body"] = string_0;
			nameValueCollection["type"] = int_0.ToString();
			nameValueCollection["code"] = string_2;
			nameValueCollection["hash"] = CD3B8233;
			byte[] bytes = webClient.UploadValues("http://captchafb.xyz/in.php", nameValueCollection);
			text = Encoding.Default.GetString(bytes);
		}
		Thread.Sleep(TimeSpan.FromSeconds(1.0));
		if (text.Substring(0, 3) == "OK|")
		{
			string text2 = text.Remove(0, 3);
			for (int i = 0; i < 24; i++)
			{
				WebRequest webRequest = WebRequest.Create("http://captchafb.xyz/res.php?id=" + text2);
				using (WebResponse webResponse = webRequest.GetResponse())
				{
					using StreamReader streamReader = new StreamReader(webResponse.GetResponseStream());
					string text3 = streamReader.ReadToEnd();
					if (text3.Length < 3)
					{
						string_1 = text3;
						return false;
					}
					if (text3.Substring(0, 3) == "OK|")
					{
						string_1 = text3.Remove(0, 3);
						return true;
					}
					if (text3 != "CAPCHA_NOT_READY")
					{
						string_1 = text3;
						return false;
					}
				}
				Thread.Sleep(2000);
			}
			string_1 = "Timeout";
			return false;
		}
		string_1 = text;
		return false;
	}

	public bool method_2(int int_0, string string_0, string CAABF31D, out string C0A39AAB, string AFA3C412 = "")
	{
		string text = "";
		switch (int_0)
		{
		case 0:
			text = "2captcha.com";
			break;
		case 1:
			text = "api.captcha.guru";
			break;
		case 3:
			text = AFA3C412.Split('*')[0];
			String_0 = AFA3C412.Split('*')[1];
			break;
		}
		string requestUriString = "http://" + text + "/in.php?key=" + String_0 + "&method=userrecaptcha&googlekey=" + string_0 + "&pageurl=" + CAABF31D;
		try
		{
			WebRequest webRequest = WebRequest.Create(requestUriString);
			using WebResponse webResponse = webRequest.GetResponse();
			using StreamReader streamReader = new StreamReader(webResponse.GetResponseStream());
			string text2 = streamReader.ReadToEnd();
			if (text2.Length < 3)
			{
				C0A39AAB = text2;
				return false;
			}
			if (text2.Substring(0, 3) == "OK|")
			{
				string text3 = text2.Remove(0, 3);
				for (int i = 0; i < 24; i++)
				{
					WebRequest webRequest2 = WebRequest.Create("http://" + text + "/res.php?key=" + String_0 + "&action=get&id=" + text3);
					using (WebResponse webResponse2 = webRequest2.GetResponse())
					{
						using StreamReader streamReader2 = new StreamReader(webResponse2.GetResponseStream());
						string text4 = streamReader2.ReadToEnd();
						if (text4.Length < 3)
						{
							C0A39AAB = text4;
							return false;
						}
						if (text4.Substring(0, 3) == "OK|")
						{
							C0A39AAB = text4.Remove(0, 3);
							return true;
						}
						if (text4 != "CAPCHA_NOT_READY")
						{
							C0A39AAB = text4;
							return false;
						}
					}
					Thread.Sleep(5000);
				}
				C0A39AAB = "Timeout";
				return false;
			}
			C0A39AAB = text2;
			return false;
		}
		catch
		{
		}
		C0A39AAB = "Unknown error";
		return false;
	}

	public static string E8112C8F(int D488052C, string string_0, string string_1, string D3083A03)
	{
		string C0A39AAB = "";
		F801AD0A f801AD0A = null;
		f801AD0A = ((!string_0.Contains("*")) ? new F801AD0A(string_0) : new F801AD0A(string_0.Split('*')[1]));
		bool flag = f801AD0A.method_2(D488052C, string_1, D3083A03, out C0A39AAB, string_0);
		while (!flag)
		{
			flag = f801AD0A.method_2(D488052C, string_1, D3083A03, out C0A39AAB, string_0);
			Thread.Sleep(TimeSpan.FromSeconds(2.0));
		}
		return C0A39AAB;
	}
}
