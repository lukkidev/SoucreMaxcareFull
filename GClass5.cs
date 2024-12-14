using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class GClass5
{
	private string ED9E3D8C = "";

	private string string_0 = "";

	private string string_1 = "";

	private List<GClass6> list_0;

	public GClass5(string string_2)
	{
		string_1 = string_2;
		list_0 = new List<GClass6>();
	}

	public string method_0()
	{
		return string_1;
	}

	public void method_1(GClass6 C70C091C)
	{
		ED9E3D8C = C70C091C.method_4();
		string_0 = C70C091C.method_5();
		list_0.Add(C70C091C);
	}

	public List<GClass6> method_2()
	{
		return list_0;
	}

	public List<GClass6> method_3()
	{
		List<GClass6> list = new List<GClass6>();
		for (int i = 0; i < list_0.Count; i++)
		{
			GClass6 gClass = list_0[i];
			if (gClass.F9B6CAB2 && gClass.C7BFB190 < gClass.int_1)
			{
				list.Add(gClass);
			}
		}
		return list;
	}

	public bool method_4()
	{
		bool result = false;
		try
		{
			_ = Environment.TickCount;
			string text = ED9E3D8C.TrimEnd('/') + "/reset?proxy=" + string_0 + "&type=deep";
			F3958F9B f3958F9B = new F3958F9B();
			string json = f3958F9B.method_0(text);
			JObject jObject = JObject.Parse(json);
			if (jObject.ContainsKey("msg") && (JObject.Parse(json)["msg"]!.ToString() == "command_sent" || JObject.Parse(json)["msg"]!.ToString() == "OK" || JObject.Parse(json)["msg"]!.ToString().ToLower() == "ok"))
			{
				result = true;
			}
			else if (jObject.ContainsKey("error_code") && JObject.Parse(json)["error_code"]!.ToString().ToLower() == "0")
			{
				result = true;
			}
		}
		catch
		{
		}
		foreach (GClass6 item in list_0)
		{
			item.C7BFB190 = 0;
		}
		return result;
	}

	public bool method_5()
	{
		int num = 0;
		while (true)
		{
			if (num < list_0.Count)
			{
				GClass6 gClass = list_0[num];
				if (gClass.F9B6CAB2 && (gClass.C7BFB190 != gClass.int_1 || gClass.C6B64DA2 != 0))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static Dictionary<string, List<string>> smethod_0(string string_2)
	{
		Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
		try
		{
			string_2 = string_2.TrimEnd('/') + "/api/v1/dongles/all";
			string text = new F3958F9B().method_0(string_2);
			text = "{data:" + text + "}";
			JObject jObject = JObject.Parse(text);
			foreach (JToken item2 in (IEnumerable<JToken>)(jObject["data"]!))
			{
				string key = item2["rootId"]!.ToString();
				string item = item2["httpPortV6"]!.ToString();
				if (!dictionary.ContainsKey(key))
				{
					dictionary.Add(key, new List<string>());
				}
				dictionary[key].Add(item);
			}
		}
		catch (Exception)
		{
		}
		return dictionary;
	}

	public static GClass5 smethod_1(List<GClass5> list_1, string A2BF19B2)
	{
		GClass5 result = null;
		for (int i = 0; i < list_1.Count; i++)
		{
			if (list_1[i].method_0() == A2BF19B2)
			{
				result = list_1[i];
				break;
			}
		}
		return result;
	}
}
