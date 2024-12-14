using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

internal class A8322F29 : FC9552BB
{
	[CompilerGenerated]
	private sealed class DD8E2E03
	{
		public string F2959C1F;

		internal Task<string> method_0()
		{
			return smethod_1(new Uri(F2959C1F));
		}
	}

	[CompilerGenerated]
	private sealed class Class1
	{
		public string string_0;
	}

	[CompilerGenerated]
	private sealed class Class2
	{
		public HttpContent E89D6F03;

		public Class1 AB1E791C;

		internal Task<string> method_0()
		{
			return smethod_3(new Uri(AB1E791C.string_0), E89D6F03);
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string F710FD8A;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_1;

	private object object_0 = new object();

	private int int_0 = 0;

	public bool bool_0 = true;

	public int D092EB86 = 0;

	public int F2A3993B = 0;

	public int C43E85AC = 3;

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return F710FD8A;
		}
		[CompilerGenerated]
		set
		{
			F710FD8A = value;
		}
	}

	public string String_1
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public string String_2
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public A8322F29(string string_2, int int_1)
	{
		String_0 = string_2;
		String_1 = "";
		String_2 = GClass25.smethod_0("configGeneral").C0288288("ip_iTypeChangeIp");
		C43E85AC = int_1;
		D092EB86 = 0;
		F2A3993B = 0;
		bool_0 = true;
	}

	public void method_0()
	{
		lock (object_0)
		{
			D092EB86--;
			if (D092EB86 == 0 && F2A3993B == C43E85AC)
			{
				F2A3993B = 0;
			}
		}
	}

	public bool method_1()
	{
		if (!F496F426())
		{
			return false;
		}
		String_1 = "";
		try
		{
			string text = string_1;
			string text2 = text;
			switch (C43AF739.smethod_0(text2))
			{
			case 418063755u:
				if (text2 == "15")
				{
					string text3 = new F3958F9B().method_0("http://api.proxyfb.com/api/changeProxy.php?key=" + F710FD8A);
					GClass11 gClass = new GClass11(text3, bool_0: true);
					if (gClass.method_3("success"))
					{
						B007BE2E(text3);
					}
				}
				break;
			case 350953279u:
				if (text2 == "19")
				{
					string text3 = new F3958F9B().method_0("https://api.netproxy.io/api/rotateProxy/getNewProxy?apiKey=" + F710FD8A + "&country=all&type=all");
					GClass11 gClass = new GClass11(text3, bool_0: true);
					if (gClass.method_3("success"))
					{
						B007BE2E(text3);
					}
				}
				break;
			case 334175660u:
				if (text2 == "18")
				{
					string text3 = new F3958F9B().method_0("https://proxymxh.com/api/GetNew.php?api_key=" + F710FD8A + "&location=0");
					GClass11 gClass = new GClass11(text3, bool_0: true);
					if (gClass.method_3("success"))
					{
						B007BE2E(text3);
					}
				}
				break;
			case 468396612u:
				if (text2 == "10")
				{
					string string_ = "{\"api_key\": \"" + F710FD8A + "\"}";
					string text3 = smethod_2("https://tmproxy.com/api/proxy/get-new-proxy", string_);
					GClass11 gClass = new GClass11(text3, bool_0: true);
					string value = Regex.Match(gClass.C0288288("message"), "\\d+").Value;
					if (value == "" || int.Parse(value) == 0)
					{
						String_1 = JObject.Parse(text3)["data"]!["https"]!.ToString();
					}
				}
				break;
			case 451618993u:
				if (text2 == "17")
				{
					string text3 = new F3958F9B().method_0("https://api.kiotproxy.com/api/v1/proxies/new?key=" + F710FD8A);
					GClass11 gClass = new GClass11(text3, bool_0: true);
					if (gClass.method_3("success"))
					{
						B007BE2E(text3);
					}
				}
				break;
			case 434841374u:
				if (text2 == "16")
				{
					string text3 = new F3958F9B().method_0("https://wwproxy.com/api/client/proxy/available?key=" + F710FD8A + "&provinceId=-1");
					GClass11 gClass = new GClass11(text3, bool_0: true);
					if (gClass.C0288288("message") == "success")
					{
						B007BE2E(text3);
					}
				}
				break;
			case 839689206u:
				if (text2 == "7")
				{
					string text3 = new F3958F9B().method_0("http://proxy.tinsoftsv.com/api/changeProxy.php?key=" + F710FD8A);
					GClass11 gClass = new GClass11(text3, bool_0: true);
					if (gClass.method_3("success"))
					{
						B007BE2E(text3);
					}
				}
				break;
			case 501951850u:
				if (text2 == "12")
				{
					string text3 = smethod_0("http://proxy.shoplike.vn/Api/getNewProxy?access_token=" + F710FD8A);
					GClass11 gClass = new GClass11(text3, bool_0: true);
					if (gClass.C0288288("status") == "success")
					{
						String_1 = JObject.Parse(text3)["data"]!["proxy"]!.ToString();
					}
				}
				break;
			case 485174231u:
			{
				if (!(text2 == "11"))
				{
					break;
				}
				string text3;
				GClass11 gClass;
				while (true)
				{
					text3 = GClass8.smethod_1("https://api.proxyv6.net/key/get-new-ip?api_key_rotating=" + F710FD8A + "&authIp=" + GClass8.smethod_59());
					gClass = new GClass11(text3, bool_0: true);
					if (!(gClass.C0288288("message") == "GET_IP_TOO_FAST"))
					{
						break;
					}
					int num = Convert.ToInt32(JObject.Parse(text3)["data"]!["remainTime"]!.ToString());
					GClass8.smethod_53(num + 1);
				}
				if (gClass.C0288288("message") == "SUCCESS")
				{
					String_1 = JObject.Parse(text3)["data"]!["host"]!.ToString() + ":" + JObject.Parse(text3)["data"]!["port"]!.ToString();
				}
				break;
			}
			case 2381486463u:
				if (text2 == "20")
				{
					string text3 = new F3958F9B().method_0("https://be.raiproxy.com/api/package/" + F710FD8A + "/reload");
					GClass11 gClass = new GClass11(text3, bool_0: true);
					if (gClass.method_3("success") || gClass.method_3("status"))
					{
						B007BE2E(text3);
					}
				}
				break;
			case 2364708844u:
				if (text2 == "21")
				{
					string text3 = new F3958F9B().method_0("https://api.nortonproxy.com/get-new-proxy?api_key=" + F710FD8A + "&id_location=1");
					GClass11 gClass = new GClass11(text3, bool_0: true);
					if (gClass.method_2("code") == 0)
					{
						B007BE2E(text3);
					}
				}
				break;
			case 2415041701u:
				if (text2 == "22")
				{
					string text3 = new F3958F9B().A6321D97("https://fproxy.vn/api/items/get-new-proxy", "api_key=" + F710FD8A);
					GClass11 gClass = new GClass11(text3, bool_0: true);
					if (gClass.method_3("status"))
					{
						B007BE2E(text3);
					}
				}
				break;
			case 2398264082u:
				if (text2 == "23")
				{
					string text3 = new F3958F9B().method_0("https://betacaptcha.com/api/change_proxy?api_key=" + F710FD8A);
					GClass11 gClass = new GClass11(text3, bool_0: true);
					if (gClass.method_3("success"))
					{
						String_1 = gClass.C0288288("proxy");
					}
				}
				break;
			}
		}
		catch
		{
		}
		return !string.IsNullOrEmpty(string_0);
	}

	public string method_2()
	{
		while (!B007BE2E())
		{
		}
		return String_1;
	}

	public bool B007BE2E(string CF2FE621 = "")
	{
		String_1 = "";
		try
		{
			string text = string_1;
			string text2 = text;
			switch (C43AF739.smethod_0(text2))
			{
			case 350953279u:
				if (text2 == "19")
				{
					if (CF2FE621 == "")
					{
						CF2FE621 = new F3958F9B().method_0("https://api.netproxy.io/api/rotateProxy/getCurrentProxy?apiKey=" + F710FD8A);
					}
					GClass11 gClass = new GClass11(CF2FE621, bool_0: true);
					if (gClass.method_3("success"))
					{
						String_1 = JObject.Parse(CF2FE621)["data"]!["proxy"]!.ToString();
					}
				}
				break;
			case 334175660u:
				if (text2 == "18")
				{
					if (CF2FE621 == "")
					{
						CF2FE621 = new F3958F9B().method_0("https://fproxy.me/api/GetCurrent.php?api_key=" + F710FD8A);
					}
					GClass11 gClass = new GClass11(CF2FE621, bool_0: true);
					if (gClass.method_3("success"))
					{
						String_1 = JObject.Parse(CF2FE621)["data"]!["proxy"]!.ToString();
					}
				}
				break;
			case 451618993u:
				if (text2 == "17")
				{
					if (CF2FE621 == "")
					{
						CF2FE621 = new F3958F9B().method_0("https://api.kiotproxy.com/api/v1/proxies/current?key=" + F710FD8A);
					}
					GClass11 gClass = new GClass11(CF2FE621, bool_0: true);
					if (gClass.method_3("success"))
					{
						String_1 = JObject.Parse(CF2FE621)["data"]!["http"]!.ToString();
					}
				}
				break;
			case 434841374u:
				if (text2 == "16")
				{
					if (CF2FE621 == "")
					{
						CF2FE621 = new F3958F9B().method_0("https://wwproxy.com/api/client/proxy/current?key=" + F710FD8A);
					}
					GClass11 gClass = new GClass11(CF2FE621, bool_0: true);
					if (gClass.C0288288("message") == "success")
					{
						String_1 = JObject.Parse(CF2FE621)["data"]!["proxy"]!.ToString();
					}
				}
				break;
			case 418063755u:
				if (text2 == "15")
				{
					if (CF2FE621 == "")
					{
						CF2FE621 = new F3958F9B().method_0("http://api.proxyfb.com/api/getProxy.php?key=" + F710FD8A);
					}
					GClass11 gClass = new GClass11(CF2FE621, bool_0: true);
					if (gClass.method_3("success"))
					{
						String_1 = gClass.C0288288("proxy");
					}
				}
				break;
			case 839689206u:
				if (text2 == "7")
				{
					if (CF2FE621 == "")
					{
						CF2FE621 = new F3958F9B().method_0("http://proxy.tinsoftsv.com/api/getProxy.php?key=" + F710FD8A);
					}
					GClass11 gClass = new GClass11(CF2FE621, bool_0: true);
					if (gClass.method_3("success"))
					{
						String_1 = gClass.C0288288("proxy");
					}
				}
				break;
			case 501951850u:
				if (text2 == "12")
				{
					CF2FE621 = smethod_0("http://proxy.shoplike.vn/Api/getCurrentProxy?access_token=" + F710FD8A);
					GClass11 gClass = new GClass11(CF2FE621, bool_0: true);
					if (gClass.C0288288("status") == "success")
					{
						String_1 = JObject.Parse(CF2FE621)["data"]!["proxy"]!.ToString();
					}
				}
				break;
			case 468396612u:
				if (text2 == "10")
				{
					string string_ = "{\"api_key\": \"" + F710FD8A + "\"}";
					CF2FE621 = smethod_2("https://tmproxy.com/api/proxy/get-current-proxy", string_);
					GClass11 gClass = new GClass11(CF2FE621, bool_0: true);
					if (gClass.C0288288("code") == "0")
					{
						String_1 = JObject.Parse(CF2FE621)["data"]!["https"]!.ToString();
					}
				}
				break;
			case 2415041701u:
				if (text2 == "22")
				{
					if (CF2FE621 == "")
					{
						CF2FE621 = new F3958F9B().A6321D97("https://fproxy.vn/api/items/get-current-proxy", "api_key=" + F710FD8A);
					}
					GClass11 gClass = new GClass11(CF2FE621, bool_0: true);
					if (gClass.method_3("status") || gClass.method_2("code") == 0)
					{
						String_1 = JObject.Parse(CF2FE621)["data"]!["http"]!.ToString();
					}
				}
				break;
			case 2381486463u:
				if (text2 == "20")
				{
					if (CF2FE621 == "")
					{
						CF2FE621 = new F3958F9B().method_0("https://be.raiproxy.com/api/package/" + F710FD8A);
					}
					GClass11 gClass = new GClass11(CF2FE621, bool_0: true);
					if (gClass.method_3("success"))
					{
						String_1 = JObject.Parse(CF2FE621)["data"]!["proxy"]!.ToString();
					}
					else if (gClass.method_3("status"))
					{
						String_1 = JObject.Parse(CF2FE621)["result"]!["http"]!.ToString();
					}
				}
				break;
			case 2364708844u:
				if (text2 == "21")
				{
					if (CF2FE621 == "")
					{
						CF2FE621 = new F3958F9B().method_0("https://api.nortonproxy.com/get-current-proxy?api_key=" + F710FD8A);
					}
					GClass11 gClass = new GClass11(CF2FE621, bool_0: true);
					if (gClass.method_2("code") == 0)
					{
						String_1 = JObject.Parse(CF2FE621)["data"]!["https"]!.ToString();
					}
				}
				break;
			}
		}
		catch (Exception)
		{
		}
		return !string.IsNullOrEmpty(string_0);
	}

	private bool F496F426(int int_1 = 10)
	{
		try
		{
			DateTime dateTime = new DateTime(2001, 1, 1);
			long ticks = DateTime.Now.Ticks - dateTime.Ticks;
			int num = (int)new TimeSpan(ticks).TotalSeconds;
			if (num - int_0 >= int_1)
			{
				int_0 = num;
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static string smethod_0(string string_2)
	{
		string text = "";
		try
		{
			new HttpClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			Task<string> task = Task.Run(() => smethod_1(new Uri(string_2)));
			task.Wait();
			return task.Result;
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA, "Request get");
			return "";
		}
	}


	private static Task<string> smethod_1(Uri C416A707)
	{
        return null;
    }

	private static string smethod_2(string AFBCCC1A, string string_2)
	{
		string text = "";
		try
		{
			new HttpClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			HttpContent E89D6F3 = new StringContent(string_2, Encoding.UTF8, "application/json");
			Task<string> task = Task.Run(() => smethod_3(new Uri(AFBCCC1A), E89D6F3));
			task.Wait();
			return task.Result;
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA, "Request Post");
			return "";
		}
	}


	private static Task<string> smethod_3(Uri F9251FB0, HttpContent httpContent_0)
	{
		return null;
	}
}
