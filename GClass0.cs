using System;
using Newtonsoft.Json.Linq;

public class GClass0
{
	private string EB2D8D30;

	private string string_0;

	private string string_1;

	private int A0934835;

	private string AA31AA03;

	private string string_2;

	public GClass0(string B00872A4 = "", string AC996D8B = "", string string_3 = "", int int_0 = 0)
	{
		EB2D8D30 = B00872A4;
		string_0 = AC996D8B;
		string_1 = string_3;
		A0934835 = int_0;
	}

	public void method_0(string C20767B0)
	{
		string_0 = C20767B0;
	}

	public string method_1(string string_3)
	{
		for (int i = 0; i < 5; i++)
		{
			if (Class57.smethod_5())
			{
				break;
			}
			string json = GClass8.smethod_3(EB2D8D30, string_0, string_1, A0934835, string_3);
			JObject jObject = JObject.Parse(json);
			if (!Convert.ToBoolean(jObject["success"]))
			{
				string text = jObject["error"]!.ToString();
				if (!text.Contains("A connection attempt failed because the connected party did not properly respond after a period of time"))
				{
					if (text.Contains(".facebook.com/dialog/unsupported_browser/"))
					{
						AA31AA03 = "https://www.facebook.com";
					}
					break;
				}
				continue;
			}
			AA31AA03 = jObject["url"]!.ToString();
			EB2D8D30 = jObject["cookie"]!.ToString();
			string_2 = jObject["response"]!.ToString();
			return string_2;
		}
		return "";
	}

	public string method_2(string D5A04A13, string AB335AA5 = "")
	{
		for (int i = 0; i < 5; i++)
		{
			if (Class57.smethod_5())
			{
				break;
			}
			string json = GClass8.FB24729A(EB2D8D30, string_0, string_1, A0934835, D5A04A13, AB335AA5);
			JObject jObject = JObject.Parse(json);
			if (!Convert.ToBoolean(jObject["success"]))
			{
				string text = jObject["error"]!.ToString();
				if (!(D5A04A13 == "https://www.facebook.com/api/graphql/") || !text.Contains("A connection attempt failed because the connected party did not properly respond after a period of time"))
				{
					break;
				}
				continue;
			}
			AA31AA03 = jObject["url"]!.ToString();
			EB2D8D30 = jObject["cookie"]!.ToString();
			string_2 = jObject["response"]!.ToString();
			return string_2;
		}
		return "";
	}

	public string method_3(string EE3E1220, string string_3, string AE378C94)
	{
		for (int i = 0; i < 5; i++)
		{
			if (Class57.smethod_5())
			{
				break;
			}
			string json = GClass8.smethod_4(EB2D8D30, string_0, string_1, A0934835, EE3E1220, string_3, AE378C94);
			JObject jObject = JObject.Parse(json);
			if (!Convert.ToBoolean(jObject["success"]))
			{
				string text = jObject["error"]!.ToString();
				if (!(EE3E1220 == "https://www.facebook.com/api/graphql/") || !text.Contains("A connection attempt failed because the connected party did not properly respond after a period of time"))
				{
					break;
				}
				continue;
			}
			AA31AA03 = jObject["url"]!.ToString();
			EB2D8D30 = jObject["cookie"]!.ToString();
			string_2 = jObject["response"]!.ToString();
			return string_2;
		}
		return "";
	}

	public string method_4(string string_3, string string_4, string CEA27B2C, string[] string_5)
	{
		for (int i = 0; i < 5; i++)
		{
			if (Class57.smethod_5())
			{
				break;
			}
			string json = GClass8.F797A0AE(EB2D8D30, string_0, string_1, A0934835, string_3, string_4, CEA27B2C, string_5);
			JObject jObject = JObject.Parse(json);
			if (!Convert.ToBoolean(jObject["success"]))
			{
				string text = jObject["error"]!.ToString();
				if (!(string_3 == "https://www.facebook.com/api/graphql/") || !text.Contains("A connection attempt failed because the connected party did not properly respond after a period of time"))
				{
					break;
				}
				continue;
			}
			AA31AA03 = jObject["url"]!.ToString();
			EB2D8D30 = jObject["cookie"]!.ToString();
			string_2 = jObject["response"]!.ToString();
			return string_2;
		}
		return "";
	}

	public string C8A33013()
	{
		return EB2D8D30;
	}

	public string method_5()
	{
		return AA31AA03;
	}

	public F3958F9B method_6()
	{
		return new F3958F9B(EB2D8D30, string_0, string_1, A0934835);
	}
}
