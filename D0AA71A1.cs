using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

public class D0AA71A1 : FC9552BB
{
	[CompilerGenerated]
	private sealed class Class10
	{
		public string string_0;

		internal Task<string> method_0()
		{
			return F81F408C(new Uri(string_0));
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string B70FC3A7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string EF297A23;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string FE1FA202;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int E402EF31;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int F03BC5AF;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string FE36722C;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_0;

	private object object_0 = new object();

	private object object_1 = new object();

	private int A4367416 = 0;

	public int int_3 = 0;

	public int AD29C081 = 0;

	public int int_4 = 3;

	public bool BB10CE1A = true;

	public int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return B70FC3A7;
		}
		[CompilerGenerated]
		set
		{
			B70FC3A7 = value;
		}
	}

	public string BC2790A7
	{
		[CompilerGenerated]
		get
		{
			return EF297A23;
		}
		[CompilerGenerated]
		set
		{
			EF297A23 = value;
		}
	}

	public int D98B06B2
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	public string String_1
	{
		[CompilerGenerated]
		get
		{
			return FE1FA202;
		}
		[CompilerGenerated]
		set
		{
			FE1FA202 = value;
		}
	}

	public int Int32_1
	{
		[CompilerGenerated]
		get
		{
			return E402EF31;
		}
		[CompilerGenerated]
		set
		{
			E402EF31 = value;
		}
	}

	public int Int32_2
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		set
		{
			int_2 = value;
		}
	}

	public int D8271EA4
	{
		[CompilerGenerated]
		get
		{
			return F03BC5AF;
		}
		[CompilerGenerated]
		set
		{
			F03BC5AF = value;
		}
	}

	public string String_2
	{
		[CompilerGenerated]
		get
		{
			return FE36722C;
		}
		[CompilerGenerated]
		set
		{
			FE36722C = value;
		}
	}

	public string String_3
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

	public D0AA71A1(int CDA75835, string string_1, int int_5, int DF0E8C85)
	{
		Int32_0 = CDA75835;
		String_0 = string_1;
		BC2790A7 = "";
		String_1 = "";
		Int32_2 = 0;
		D8271EA4 = 0;
		D98B06B2 = int_5;
		int_4 = DF0E8C85;
		A4367416 = 0;
		int_3 = 0;
		AD29C081 = 0;
		String_2 = "";
		String_3 = "";
	}

	public static bool FE03F5BE(int int_5, string string_1)
	{
		string text = "";
		text = ((int_5 != 0) ? B3A4553F("http://dash.minproxy.vn/api/rotating/v1/proxy_v4/get-status?api_key=" + string_1) : B3A4553F("http://dash.minproxy.vn/api/rotating/v1/proxy/get-status?api_key=" + string_1));
		if (text != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text);
				if (jObject["code"]!.ToString() == "1")
				{
					return true;
				}
			}
			catch
			{
			}
		}
		return false;
	}

	public string method_0()
	{
		lock (object_0)
		{
			if (int_3 == 0)
			{
				if (AD29C081 > 0 && AD29C081 < int_4)
				{
					if (CD3DD183() < 30 && F6956018() != 1)
					{
						return "0";
					}
				}
				else if (F6956018() != 1)
				{
					return "0";
				}
			}
			else
			{
				if (AD29C081 >= int_4)
				{
					return "2";
				}
				if (CD3DD183() < 30 && F6956018() != 1)
				{
					return "0";
				}
			}
			AD29C081++;
			int_3++;
			return "1";
		}
	}

	public int CD3DD183()
	{
		D48D5A17();
		return Int32_1;
	}

	public void method_1()
	{
		lock (object_1)
		{
			int_3--;
			if (int_3 == 0 && AD29C081 == int_4)
			{
				BB10CE1A = true;
				AD29C081 = 0;
			}
		}
	}

	public int F6956018()
	{
		BC2790A7 = "";
		String_1 = "";
		Int32_2 = 0;
		string text = "";
		text = ((Int32_0 != 0) ? B3A4553F("http://dash.minproxy.vn/api/rotating/v1/proxy_v4/get-new-proxy?api_key=" + String_0) : B3A4553F("http://dash.minproxy.vn/api/rotating/v1/proxy/get-new-proxy?api_key=" + String_0));
		if (text != "")
		{
			if (text.Contains("api expired"))
			{
				return -1;
			}
			if (text.Contains("api wrong") || text.Contains("error"))
			{
				return -2;
			}
			try
			{
				JObject jObject = JObject.Parse(text);
				string value = Regex.Match(jObject["data"]!["next_request"]!.ToString(), "\\d+").Value;
				D8271EA4 = ((!(value == "")) ? int.Parse(value) : 0);
				if (jObject["code"]!.ToString() == "2")
				{
					String_2 = jObject["data"]!["ip_allow"]!.ToString();
					String_3 = jObject["data"]!["your_ip"]!.ToString();
					if (Int32_0 == 0)
					{
						BC2790A7 = jObject["data"]!["http_proxy"]!.ToString();
						string[] array = BC2790A7.Split(':');
						String_1 = array[0];
						Int32_2 = int.Parse(array[1]);
						return 1;
					}
					if (Int32_0 == 1)
					{
						if (D98B06B2 == 0)
						{
							BC2790A7 = jObject["data"]!["http_proxy_ipv4"]!.ToString();
							string[] array2 = BC2790A7.Split(':');
							String_1 = array2[0];
							Int32_2 = int.Parse(array2[1]);
						}
						else if (D98B06B2 == 1)
						{
							BC2790A7 = jObject["data"]!["http_proxy_ipv6"]!.ToString();
							string[] array3 = BC2790A7.Split(':');
							String_1 = array3[0];
							Int32_2 = int.Parse(array3[1]);
						}
						else if (D98B06B2 == 2)
						{
							BC2790A7 = jObject["data"]!["sock_proxy_ipv4"]!.ToString();
							string[] array4 = BC2790A7.Split(':');
							String_1 = array4[0];
							Int32_2 = int.Parse(array4[1]);
						}
						else
						{
							BC2790A7 = jObject["data"]!["sock_proxy_ipv6"]!.ToString();
							string[] array5 = BC2790A7.Split(':');
							String_1 = array5[0];
							Int32_2 = int.Parse(array5[1]);
						}
						return 1;
					}
				}
				return 0;
			}
			catch
			{
			}
		}
		D8271EA4 = 0;
		return 0;
	}

	public bool D48D5A17()
	{
		D8271EA4 = 0;
		BC2790A7 = "";
		String_1 = "";
		Int32_2 = 0;
		Int32_1 = 0;
		string text = "";
		text = ((Int32_0 != 0) ? B3A4553F("http://dash.minproxy.vn/api/rotating/v1/proxy_v4/get-current-proxy?api_key=" + String_0) : B3A4553F("http://dash.minproxy.vn/api/rotating/v1/proxy/get-current-proxy?api_key=" + String_0));
		if (text != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text);
				if (jObject["code"]!.ToString() == "1")
				{
					D8271EA4 = Convert.ToInt32(jObject["data"]!["next_request"]!.ToString());
					Int32_1 = Convert.ToInt32(jObject["data"]!["timeout"]!.ToString());
					String_2 = jObject["data"]!["ip_allow"]!.ToString();
					String_3 = jObject["data"]!["your_ip"]!.ToString();
					if (Int32_0 == 0)
					{
						BC2790A7 = jObject["data"]!["http_proxy"]!.ToString();
						string[] array = BC2790A7.Split(':');
						String_1 = array[0];
						Int32_2 = int.Parse(array[1]);
						return true;
					}
					if (Int32_0 == 1)
					{
						if (D98B06B2 == 0)
						{
							BC2790A7 = jObject["data"]!["http_proxy_ipv4"]!.ToString();
							string[] array2 = BC2790A7.Split(':');
							String_1 = array2[0];
							Int32_2 = int.Parse(array2[1]);
						}
						else if (D98B06B2 == 1)
						{
							BC2790A7 = jObject["data"]!["http_proxy_ipv6"]!.ToString();
							string[] array3 = BC2790A7.Split(':');
							String_1 = array3[0];
							Int32_2 = int.Parse(array3[1]);
						}
						else if (D98B06B2 == 2)
						{
							BC2790A7 = jObject["data"]!["sock_proxy_ipv4"]!.ToString();
							string[] array4 = BC2790A7.Split(':');
							String_1 = array4[0];
							Int32_2 = int.Parse(array4[1]);
						}
						else
						{
							BC2790A7 = jObject["data"]!["sock_proxy_ipv6"]!.ToString();
							string[] array5 = BC2790A7.Split(':');
							String_1 = array5[0];
							Int32_2 = int.Parse(array5[1]);
						}
						return true;
					}
				}
			}
			catch
			{
			}
		}
		return false;
	}

	public string method_2()
	{
		while (!D48D5A17())
		{
		}
		return BC2790A7;
	}

	public static string B3A4553F(string string_1)
	{
		string text = "";
		try
		{
			new HttpClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			Task<string> task = Task.Run(() => F81F408C(new Uri(string_1)));
			task.Wait();
			return task.Result;
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA, "Request get");
			return "";
		}
	}


	private static Task<string> F81F408C(Uri B439AA81)
	{
        return null;
    }
}
