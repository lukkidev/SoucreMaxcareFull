using System;
using Newtonsoft.Json.Linq;

public class GClass24
{
	public static string smethod_0(string BA1D9BAC, string string_0)
	{
		string text = "https://omocaptcha.com";
		try
		{
			string text2 = GClass8.A2307E3B("ewoJImFwaV90b2tlbiI6ICJ7YXBpS2V5fSIsCgkiZGF0YSI6IHsKCQkidHlwZV9qb2JfaWQiOiAiMzAiLAoJCSJpbWFnZV9iYXNlNjQiOiAie2ltYWdlQmFzZTY0fSIKCX0KfQ==");
			text2 = text2.Replace("{apiKey}", BA1D9BAC);
			text2 = text2.Replace("{imageBase64}", string_0);
			string text3 = new F3958F9B().A6321D97(text + "/api/createJob", text2, "application/json").ToString();
			string newValue = JObject.Parse(text3)["job_id"]!.ToString();
			text2 = GClass8.A2307E3B("ewoJImFwaV90b2tlbiI6ICJ7YXBpS2V5fSIsCgkiam9iX2lkIjoge2pvYl9pZH0KfQ==");
			text2 = text2.Replace("{apiKey}", BA1D9BAC);
			text2 = text2.Replace("{job_id}", newValue);
			int tickCount = Environment.TickCount;
			do
			{
				try
				{
					text3 = new F3958F9B().A6321D97(text + "/api/getJobResult", text2, "application/json");
				}
				catch (Exception)
				{
					continue;
				}
				switch (JObject.Parse(text3)["status"]!.ToString())
				{
				default:
					GClass8.smethod_53(1.0);
					continue;
				case "success":
					break;
				case "fail":
				case "timeout":
					return "";
				}
				break;
			}
			while (Environment.TickCount - tickCount < 300000);
			if (!text3.Contains("result"))
			{
				return "";
			}
			return JObject.Parse(text3)["result"]!.ToString();
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string smethod_1(string string_0, string D819F202, int int_0 = 0)
	{
		string text = "https://omocaptcha.com";
		if (int_0 == 1)
		{
			text = "https://mincaptcha.com";
		}
		try
		{
			string text2 = GClass8.A2307E3B("ewoJImFwaV90b2tlbiI6ICJ7YXBpS2V5fSIsCgkiZGF0YSI6IHsKCQkidHlwZV9qb2JfaWQiOiAiNDEiLAoJCSJpbnB1dCI6ICJ7aW5wdXR9IgoJfQp9");
			text2 = text2.Replace("{apiKey}", string_0);
			text2 = text2.Replace("{input}", D819F202);
			string text3 = "";
			string text4 = "";
			int tickCount = Environment.TickCount;
			do
			{
				try
				{
					text3 = new F3958F9B().A6321D97(text + "/api/createJob", text2, "application/json");
					text4 = JObject.Parse(text3)["job_id"]!.ToString();
					if (text4 != "")
					{
						break;
					}
				}
				catch
				{
				}
				GClass8.smethod_53(3.0);
			}
			while (Environment.TickCount - tickCount < 300000);
			if (text4 == "")
			{
				return "";
			}
			text2 = GClass8.A2307E3B("ewoJImFwaV90b2tlbiI6ICJ7YXBpS2V5fSIsCgkiam9iX2lkIjoge2pvYl9pZH0KfQ==");
			text2 = text2.Replace("{apiKey}", string_0);
			text2 = text2.Replace("{job_id}", text4);
			while (true)
			{
				text3 = new F3958F9B().A6321D97(text + "/api/getJobResult", text2, "application/json");
				switch (JObject.Parse(text3)["status"]!.ToString())
				{
				default:
					GClass8.smethod_53(3.0);
					if (Environment.TickCount - tickCount < 300000)
					{
						break;
					}
					goto case "success";
				case "success":
					if (!text3.Contains("result"))
					{
						return "";
					}
					return JObject.Parse(text3)["result"]!.ToString();
				case "fail":
				case "timeout":
					return "";
				}
			}
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string FEA62D06(string string_0, string string_1, string string_2)
	{
		string text = "https://omocaptcha.com";
		try
		{
			string text2 = GClass8.A2307E3B("ewoJImFwaV90b2tlbiI6ICJ7YXBpS2V5fSIsCgkiZGF0YSI6IHsKCQkidHlwZV9qb2JfaWQiOiAiMiIsCgkJIndlYnNpdGVfdXJsIjogInt3ZWJzaXRlVVJMfSIsCgkJIndlYnNpdGVfa2V5IjogInt3ZWJzaXRlS2V5fSIKCX0KfQ==");
			text2 = text2.Replace("{apiKey}", string_0);
			text2 = text2.Replace("{websiteKey}", string_1);
			text2 = text2.Replace("{websiteURL}", string_2);
			string text3 = "";
			string text4 = "";
			int tickCount = Environment.TickCount;
			do
			{
				try
				{
					text3 = new F3958F9B().A6321D97(text + "/api/createJob", text2, "application/json");
					text4 = JObject.Parse(text3)["job_id"]!.ToString();
					if (text4 != "")
					{
						break;
					}
				}
				catch
				{
				}
				GClass8.smethod_53(3.0);
			}
			while (Environment.TickCount - tickCount < 300000);
			if (text4 == "")
			{
				return "";
			}
			text2 = GClass8.A2307E3B("ewoJImFwaV90b2tlbiI6ICJ7YXBpS2V5fSIsCgkiam9iX2lkIjoge2pvYl9pZH0KfQ==");
			text2 = text2.Replace("{apiKey}", string_0);
			text2 = text2.Replace("{job_id}", text4);
			while (true)
			{
				text3 = new F3958F9B().A6321D97(text + "/api/getJobResult", text2, "application/json");
				switch (JObject.Parse(text3)["status"]!.ToString())
				{
				default:
					GClass8.smethod_53(3.0);
					if (Environment.TickCount - tickCount < 300000)
					{
						break;
					}
					goto case "success";
				case "success":
					if (!text3.Contains("result"))
					{
						return "";
					}
					return JObject.Parse(text3)["result"]!.ToString();
				case "fail":
				case "timeout":
					return "";
				}
			}
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static bool smethod_2(string F1B66291)
	{
		if (F1B66291 == "")
		{
			return false;
		}
		string text = GClass8.smethod_0("https://omocaptcha.com/", F1B66291);
		return text != "";
	}
}
