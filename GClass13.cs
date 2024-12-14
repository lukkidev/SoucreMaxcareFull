using System;
using Newtonsoft.Json.Linq;

public class GClass13
{
	public static string smethod_0(string string_0, string string_1, string DB080ABA)
	{
		try
		{
			string text = "";
			string text2 = "";
			string text3 = "{\r\n\t              \"clientKey\": \"{apiKey}\",\r\n                  \"appId\": \"655D40FB-5EB9-4A9C-8846-CC7A7C276246\",\r\n\t              \"task\": {\r\n\t\t            \"websiteURL\": \"{websiteURL}\",\r\n\t\t            \"websiteKey\": \"{websiteKey}\",\r\n\t\t            \"type\": \"ReCaptchaV2Task\"\r\n\t              }\r\n\t            }";
			text3 = text3.Replace("{apiKey}", string_0);
			text3 = text3.Replace("{websiteKey}", string_1);
			text3 = text3.Replace("{websiteURL}", DB080ABA);
			int tickCount = Environment.TickCount;
			do
			{
				try
				{
					text = new F3958F9B().A6321D97("https://api.capsolver.com/createTask", text3, "application/json");
					text2 = JObject.Parse(text)["taskId"]!.ToString();
					if (text2 != "")
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
			if (text2 == "")
			{
				return "";
			}
			text3 = "{\r\n\t\t            \"clientKey\": \"{apiKey}\",\r\n\t\t            \"taskId\": \"{jobId}\"\r\n\t            }";
			text3 = text3.Replace("{apiKey}", string_0);
			text3 = text3.Replace("{jobId}", text2);
			do
			{
				text = new F3958F9B().A6321D97("https://api.capsolver.com/getTaskResult", text3, "application/json");
				try
				{
					string text4 = JObject.Parse(text)["solution"]!["gRecaptchaResponse"]!.ToString();
					if (text4 != "")
					{
						return text4;
					}
				}
				catch (Exception)
				{
				}
				GClass8.smethod_53(3.0);
			}
			while (Environment.TickCount - tickCount < 300000);
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string C9A42A0F(string string_0, string A922361C)
	{
		try
		{
			string text = "";
			string text2 = "{\r\n\t              \"clientKey\": \"{apiKey}\",\r\n\t              \"task\": {\r\n\t\t            \"body\": \"{body}\",\r\n\t\t            \"module\": \"queueit\",\r\n\t\t            \"type\": \"ImageToTextTask\"\r\n\t              }\r\n\t            }";
			text2 = text2.Replace("{apiKey}", string_0);
			text2 = text2.Replace("{body}", A922361C);
			int tickCount = Environment.TickCount;
			do
			{
				try
				{
					text = new F3958F9B().A6321D97("https://api.capsolver.com/createTask", text2, "application/json");
					string text3 = JObject.Parse(text)["solution"]!["text"]!.ToString();
					if (text3 != "")
					{
						return text3;
					}
				}
				catch
				{
				}
				GClass8.smethod_53(3.0);
			}
			while (Environment.TickCount - tickCount < 300000);
		}
		catch (Exception)
		{
		}
		return "";
	}
}
