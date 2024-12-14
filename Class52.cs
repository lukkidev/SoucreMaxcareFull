using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;

internal class Class52
{
	private string F8BE89BB;

	private string string_0;

	public string string_1;

	private string EC8A6EBA;

	private F3958F9B C6971692;

	public string D603E4A5;

	public string string_2;

	private string string_3;

	public string method_0()
	{
		return string_3;
	}

	public static bool smethod_0()
	{
		return GClass25.smethod_0("configGeneral").method_3("ckbGpmLogin") || GClass25.smethod_0("configGeneral").method_3("ckbGemLogin");
	}

	public static string smethod_1()
	{
		if (GClass25.smethod_0("configGeneral").method_3("ckbGpmLogin"))
		{
			return GClass25.smethod_0("configGeneral").C0288288("txtGpmApiUrl").TrimEnd('/') + "/api/v3/";
		}
		if (GClass25.smethod_0("configGeneral").method_3("ckbGemLogin"))
		{
			return GClass25.smethod_0("configGeneral").C0288288("txtGemApiUrl").TrimEnd('/') + "/api/";
		}
		return "";
	}

	public static List<string> A91D1699()
	{
		List<string> list = new List<string>();
		try
		{
			string json = new F3958F9B().method_0(smethod_1() + "profiles?per_page=100000");
			foreach (JToken item in (IEnumerable<JToken>)(JObject.Parse(json)["data"]!))
			{
				list.Add(item["name"]!.ToString());
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	public static Dictionary<string, string> smethod_2()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		try
		{
			GClass25.smethod_0("configGeneral").C0288288("txtGpmApiUrl").TrimEnd('/');
			string json = new F3958F9B().method_0(smethod_1() + "profiles?per_page=100000");
			foreach (JToken item in (IEnumerable<JToken>)(JObject.Parse(json)["data"]!))
			{
				dictionary.Add(item["name"]!.ToString(), item["id"]!.ToString());
			}
		}
		catch (Exception)
		{
		}
		return dictionary;
	}

	public static Dictionary<string, string> smethod_3()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		try
		{
			string json = new F3958F9B().method_0(smethod_1() + "profiles?per_page=100000");
			string text = "";
			if (GClass25.smethod_0("configGeneral").method_3("ckbGpmLogin"))
			{
				text = E50E99B1() + "\\";
			}
			foreach (JToken item in (IEnumerable<JToken>)(JObject.Parse(json)["data"]!))
			{
				dictionary.Add(item["name"]!.ToString(), text + item["profile_path"]!.ToString());
			}
		}
		catch (Exception)
		{
		}
		return dictionary;
	}

	public static bool smethod_4(string A114D93F)
	{
		smethod_5(A114D93F);
		try
		{
			string json = new F3958F9B().method_0(smethod_1() + "profiles/delete/" + A114D93F + "?mode=2");
			return Convert.ToBoolean(JObject.Parse(json)["success"]);
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static bool smethod_5(string string_4)
	{
		try
		{
			string json = new F3958F9B().method_0(smethod_1() + "profiles/close/" + string_4);
			return Convert.ToBoolean(JObject.Parse(json)["success"]);
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static string E50E99B1()
	{
		try
		{
			string result = "";
			if (GClass25.smethod_0("configGeneral").method_3("ckbGpmLogin"))
			{
				string json = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\GPMLogin\\setting.dat");
				result = JObject.Parse(json)["ProfileSavePath"]!.ToString();
			}
			if (GClass25.smethod_0("configGeneral").method_3("ckbGemLogin"))
			{
				result = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.gemlogin\\profile\\profiles";
			}
			return result;
		}
		catch (Exception)
		{
		}
		return "";
	}

	public Class52(string string_4)
	{
		C6971692 = new F3958F9B();
		string_0 = string_4;
		EC8A6EBA = GClass25.smethod_0("configGeneral").C0288288("cbbBrowserVersion", "121.0.6167.140");
		F8BE89BB = smethod_1();
		string_1 = "";
		method_1();
	}

	private void method_1()
	{
		try
		{
			string json = C6971692.method_0(F8BE89BB + "profiles?per_page=100000&search=" + string_0.Trim('+'));
			foreach (JToken item in (IEnumerable<JToken>)(JObject.Parse(json)["data"]!))
			{
				if (item["name"]!.ToString() == string_0)
				{
					string_1 = item["id"]!.ToString();
					break;
				}
			}
			if (string.IsNullOrEmpty(string_1))
			{
				method_2();
			}
		}
		catch (Exception)
		{
			string_3 = "Check profile fail";
		}
	}

	private void method_2()
	{
		string text = F8BE89BB + "profiles/create";
		try
		{
			string text2 = "";
			if (GClass25.smethod_0("configGeneral").method_3("ckbGpmLogin"))
			{
				text2 = "{\r\n    \"profile_name\" : \"{profileName}\",\r\n    \"group_name\": \"All\",\r\n    \"browser_core\": \"chromium\",\r\n    \"browser_name\": \"Chrome\",\r\n    \"browser_version\": \"{browser_version}\",\r\n    \"is_random_browser_version\": false,\r\n    \"raw_proxy\" : \"\",\r\n    \"startup_urls\": \"\",\r\n    \"is_masked_font\": true,\r\n    \"is_noise_canvas\": true,\r\n    \"is_noise_webgl\": true,\r\n    \"is_noise_client_rect\": true,\r\n    \"is_noise_audio_context\": true,\r\n    \"is_random_screen\": true,\r\n    \"is_masked_webgl_data\": true,\r\n    \"is_masked_media_device\": true,\r\n    \"is_random_os\": true,\r\n    \"os\": \"Windows 11\",\r\n    \"webrtc_mode\": 1,\r\n    \"user_agent\": \"\"\r\n}";
			}
			if (GClass25.smethod_0("configGeneral").method_3("ckbGemLogin"))
			{
				text2 = "{\r\n    \"profile_name\": \"{profileName}\",\r\n    \"group_name\": \"All\",\r\n    \"raw_proxy\": \"\",\r\n    \"startup_urls\": \"\",\r\n    \"is_masked_font\": true,\r\n    \"is_noise_canvas\": true,\r\n    \"is_noise_webgl\": true,\r\n    \"is_noise_client_rect\": true,\r\n    \"is_noise_audio_context\": true,\r\n    \"is_random_screen\": true,\r\n    \"is_masked_webgl_data\": true,\r\n    \"is_masked_media_device\": true,\r\n    \"is_random_os\": true,\r\n    \"os\": {\r\n        \"type\": \"Windows\",\r\n        \"version\": \"Windows 10\"\r\n    },\r\n    \"webrtc_mode\": 1,\r\n    \"user_agent\": \"\"\r\n}";
			}
			text2 = text2.Replace("{profileName}", string_0);
			text2 = text2.Replace("{browser_version}", EC8A6EBA);
			string json = C6971692.A6321D97(text, text2, "application/json");
			string_1 = JObject.Parse(json)["data"]!["id"]!.ToString();
		}
		catch (Exception)
		{
			string_3 = "Create profile fail";
		}
	}

	public void method_3(string string_4, string string_5)
	{
		string text = F8BE89BB + "profiles/update/" + string_1;
		string text2 = "";
		if (GClass25.smethod_0("configGeneral").method_3("ckbGpmLogin"))
		{
			text2 = "{\"raw_proxy\" : \"{proxy}\", \"user_agent\": \"{useragent}\", \"browser_version\":\"{browser_version}\", \"webrtc_mode\":1}";
		}
		if (GClass25.smethod_0("configGeneral").method_3("ckbGemLogin"))
		{
			text2 = "{\"raw_proxy\": \"http://{proxy}\",\r\n  \"user_agent\": \"{useragent}\", \"webrtc_mode\":1}";
		}
		text2 = text2.Replace("{proxy}", string_4);
		text2 = text2.Replace("{useragent}", string_5);
		text2 = text2.Replace("{browser_version}", GClass25.smethod_0("configGeneral").C0288288("cbbBrowserVersion", "127.0.6533.73"));
		try
		{
			C6971692.A6321D97(text, text2, "application/json");
		}
		catch (Exception)
		{
			string_3 = "Update profile fail";
		}
	}

	public void method_4(string string_4 = "")
	{
		method_5();
		string text = F8BE89BB + "profiles/start/" + string_1 + "?skip_proxy_check=true";
		if (string_4 != "")
		{
			text = text + "&addination_args=" + string_4;
		}
		try
		{
			string json = C6971692.method_0(text);
			string_2 = JObject.Parse(json)["data"]!["driver_path"]!.ToString();
			D603E4A5 = JObject.Parse(json)["data"]!["remote_debugging_address"]!.ToString();
		}
		catch (Exception)
		{
			string_3 = "Open profile fail";
		}
	}

	public void method_5()
	{
		smethod_5(string_1);
	}
}
