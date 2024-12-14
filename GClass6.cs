using System;
using System.Threading;
using Newtonsoft.Json.Linq;

public class GClass6 : FC9552BB
{
	public int int_0;

	private string string_0;

	public string string_1;

	public string string_2 = "";

	public bool F9B6CAB2 = true;

	public int C6B64DA2 = 0;

	public int C7BFB190 = 0;

	public int int_1 = 3;

	private string string_3 = "";

	public GClass6(string BA239FB3, string string_4, int int_2, int F53BD5B5, string E23D518A)
	{
		string_0 = BA239FB3;
		string_1 = string_4;
		int_1 = F53BD5B5;
		string_2 = "";
		int_0 = int_2;
		method_3(E23D518A);
	}

	private void A71430B5(string string_4)
	{
	}

	public bool method_0()
	{
		bool result = false;
		try
		{
			_ = Environment.TickCount;
			string_0 = string_0.TrimEnd('/');
			string text = string_0 + "/reset?proxy=" + string_1;
			F3958F9B f3958F9B = new F3958F9B();
			string text2 = f3958F9B.method_0(text);
			A71430B5(text + ": " + text2);
			JObject jObject = JObject.Parse(text2);
			if (jObject.ContainsKey("msg") && (JObject.Parse(text2)["msg"]!.ToString() == "command_sent" || JObject.Parse(text2)["msg"]!.ToString() == "OK" || JObject.Parse(text2)["msg"]!.ToString().ToLower() == "ok"))
			{
				result = true;
				return result;
			}
			if (jObject.ContainsKey("error_code"))
			{
				if (JObject.Parse(text2)["error_code"]!.ToString().ToLower() == "0")
				{
					result = true;
					return result;
				}
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public bool method_1()
	{
		bool result = false;
		try
		{
			_ = Environment.TickCount;
			string_0 = string_0.TrimEnd('/');
			string text = string_0 + "/reset?proxy=" + string_1;
			F3958F9B f3958F9B = new F3958F9B();
			string text2 = f3958F9B.method_0(text);
			A71430B5(text + ": " + text2);
			JObject jObject = JObject.Parse(text2);
			bool flag = false;
			if (jObject.ContainsKey("msg") && (JObject.Parse(text2)["msg"]!.ToString() == "command_sent" || JObject.Parse(text2)["msg"]!.ToString() == "OK" || JObject.Parse(text2)["msg"]!.ToString().ToLower() == "ok"))
			{
				flag = true;
			}
			else if (jObject.ContainsKey("error_code") && JObject.Parse(text2)["error_code"]!.ToString().ToLower() == "0")
			{
				flag = true;
			}
			if (flag)
			{
				return D99A0B34();
			}
		}
		catch
		{
			result = false;
		}
		return result;
	}

	public void CAA6C2B8(int int_2 = 1)
	{
		C6B64DA2--;
		if (int_2 == 0 && C6B64DA2 == 0 && C7BFB190 == int_1)
		{
			C7BFB190 = 0;
		}
	}

	public bool D99A0B34(int int_2 = -1)
	{
		if (int_2 == -1)
		{
			int_2 = GClass25.smethod_0("configGeneral").method_2("nudDelayCheckIPObcProxy", 5) * 60;
		}
		int tickCount = Environment.TickCount;
		bool flag = false;
		try
		{
			string_0 = string_0.TrimEnd('/');
			string text = string_0 + "/status?proxy=" + string_1;
			F3958F9B f3958F9B = new F3958F9B();
			string text2 = "";
			do
			{
				text2 = f3958F9B.method_0(text);
				A71430B5(text + ": " + text2);
				try
				{
					if (!text2.Contains("public_ip_v6") && !text2.Contains("public_ip"))
					{
						flag = Convert.ToBoolean(JObject.Parse(text2)["status"]!.ToString());
					}
					else
					{
						string text3 = string_1.Split(':')[1];
						if (!text3.StartsWith("4") && !text3.StartsWith("5"))
						{
							if (text3.StartsWith("6") || text3.StartsWith("7"))
							{
								flag = JObject.Parse(text2)["public_ip_v6"]!.ToString() != "" && JObject.Parse(text2)["public_ip_v6"]!.ToString() != "CONNECT_INTERNET_ERROR";
							}
						}
						else
						{
							flag = JObject.Parse(text2)["public_ip"]!.ToString() != "" && JObject.Parse(text2)["public_ip"]!.ToString() != "CONNECT_INTERNET_ERROR";
						}
					}
				}
				catch
				{
					flag = JObject.Parse(text2)["error_code"]!.ToString() == "0";
				}
				Thread.Sleep(1000);
				if (flag)
				{
					return flag;
				}
			}
			while (Environment.TickCount - tickCount < int_2 * 1000);
			return flag;
		}
		catch
		{
			return flag;
		}
	}

	public string method_2()
	{
		return string_3;
	}

	public void method_3(string string_4)
	{
		string_3 = string_4;
	}

	public string method_4()
	{
		return string_0;
	}

	public string method_5()
	{
		return string_1.Split(':')[1];
	}
}
