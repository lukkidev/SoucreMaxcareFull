using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using Newtonsoft.Json.Linq;

public static class A5BB222F
{
	private static List<string> D508A1AA = new List<string> { "https://auto-api.golike.net/api/config/info", "http://auto-api-config.golike.net/api/config" };

	public static int int_0 = 5;

	public static int int_1 = 100;

	public static int int_2 = 300;

	private static List<string> list_0 = new List<string>();

	private static List<string> list_1 = new List<string>();

	private static int int_3 = 0;

	private static int int_4 = 300;

	private static object B8985433 = new object();

	private static bool smethod_0()
	{
		return Environment.TickCount - int_3 > int_4 * 1000;
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetConfigs(byte[] byte_0);

	public static object C13DF3A1(string B1BC3418)
	{
		while (true)
		{
			if (smethod_0() && Monitor.TryEnter(B8985433))
			{
				int_3 = Environment.TickCount;
				lock (B8985433)
				{
					foreach (string item in D508A1AA)
					{
						string json = GClass8.smethod_10(GetConfigs(GClass8.smethod_11(item)));
						try
						{
							JObject jObject = JObject.Parse(json);
							int_0 = Convert.ToInt32(jObject["delay_action_jobs_min"]);
							int_1 = Convert.ToInt32(jObject["delay_action_jobs_max"]);
							int_2 = Convert.ToInt32(jObject["max_jobs_daily"]);
							list_0 = jObject["get_jobs_url"]!.ToString().Split('|').ToList();
							list_1 = jObject["complete_jobs_url"]!.ToString().Split('|').ToList();
						}
						catch (Exception)
						{
							continue;
						}
						break;
					}
				}
			}
			switch (B1BC3418)
			{
			case "urlUpdateJobs":
			{
				string text2 = list_1.smethod_6();
				if (string.IsNullOrEmpty(text2))
				{
					GClass8.smethod_53(10.0);
					break;
				}
				return text2;
			}
			case "urlGetJobs":
			{
				string text = list_0.smethod_6();
				if (string.IsNullOrEmpty(text))
				{
					GClass8.smethod_53(10.0);
					break;
				}
				return text;
			}
			default:
				return "";
			case "max_jobs_daily":
				return int_2;
			case "delay_action_jobs_max":
				return int_1;
			case "delay_action_jobs_min":
				return int_0;
			}
		}
	}
}
