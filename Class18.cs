using System;
using Newtonsoft.Json.Linq;

internal class Class18
{
	public static string smethod_0(string EE1B6A9A, string FBB6C38A)
	{
		try
		{
			string text = GClass8.A2307E3B("ewogICAgICJBcGlrZXkiOiAie2FwaUtleX0iLAogICAgICJUeXBlIjogImltYWdldG90ZXh0IiwKICAgICAiSW1hZ2UiOiAie2ltYWdlQmFzZTY0fSIsCiAgICAgIkN1c3RvbWl6ZSI6ICJGQUNFQk9PSyIKfQ==");
			text = text.Replace("{apiKey}", EE1B6A9A);
			text = text.Replace("{imageBase64}", FBB6C38A);
			string text2 = "";
			string text3 = "";
			int tickCount = Environment.TickCount;
			do
			{
				try
				{
					text2 = new F3958F9B().httpRequest_0.Post("https://api.rockcaptcha.com/recognition", text, "application/json").ToString();
					text3 = JObject.Parse(text2)["TaskId"]!.ToString();
					if (text3 != "")
					{
						break;
					}
				}
				catch
				{
				}
				GClass8.smethod_53(1.0);
			}
			while (Environment.TickCount - tickCount < 300000);
			if (text3 == "")
			{
				return "";
			}
			text = GClass8.A2307E3B("ewoJImFwaV90b2tlbiI6ICJ7YXBpS2V5fSIsCgkiam9iX2lkIjoge2pvYl9pZH0KfQ==");
			text = text.Replace("{apiKey}", EE1B6A9A);
			text = text.Replace("{job_id}", text3);
			do
			{
				text2 = new F3958F9B().method_0("https://api.rockcaptcha.com/getresult?apikey=" + EE1B6A9A + "&taskid=" + text3);
				string text4 = JObject.Parse(text2)["Status"]!.ToString();
				if (!(text4 == "ERROR"))
				{
					if (text4 == "SUCCESS")
					{
						break;
					}
					GClass8.smethod_53(1.0);
					continue;
				}
				return "";
			}
			while (Environment.TickCount - tickCount < 300000);
			if (!text2.Contains("Data"))
			{
				return "";
			}
			return JObject.Parse(text2)["Data"]!.ToString();
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string DBB1CD92(string string_0, string string_1, string string_2)
	{
		try
		{
			string text = "https://api.rockcaptcha.com/recaptchav2?apikey={apiKey}&sitekey={websiteKey}&siteurl={websiteURL}&invisible=false&affiliateid=36495";
			text = text.Replace("{apiKey}", string_0);
			text = text.Replace("{websiteKey}", string_1);
			text = text.Replace("{websiteURL}", string_2);
			string text2 = "";
			string text3 = "";
			int tickCount = Environment.TickCount;
			do
			{
				try
				{
					text2 = new F3958F9B().method_0(text);
					text3 = JObject.Parse(text2)["TaskId"]!.ToString();
					if (text3 != "")
					{
						break;
					}
				}
				catch
				{
				}
				GClass8.smethod_53(1.0);
			}
			while (Environment.TickCount - tickCount < 300000);
			if (text3 == "")
			{
				return "";
			}
			text = "https://api.rockcaptcha.com/getresult?apikey={apiKey}&taskid={job_id}";
			text = text.Replace("{apiKey}", string_0);
			text = text.Replace("{job_id}", text3);
			do
			{
				text2 = new F3958F9B().method_0(text);
				string text4 = JObject.Parse(text2)["Status"]!.ToString();
				if (!(text4 == "ERROR"))
				{
					if (text4 == "SUCCESS")
					{
						break;
					}
					GClass8.smethod_53(3.0);
					continue;
				}
				return "";
			}
			while (Environment.TickCount - tickCount < 300000);
			if (!text2.Contains("Data"))
			{
				return "";
			}
			return JObject.Parse(text2)["Data"]!["Token"]!.ToString();
		}
		catch (Exception)
		{
		}
		return "";
	}
}
