using System;
using System.Threading;
using Newtonsoft.Json.Linq;

internal class Class9 : FC9552BB
{
	public int int_0;

	private string AF12DABE;

	public string string_0;

	public string string_1 = "";

	public bool bool_0 = true;

	public int int_1 = 0;

	public int DBA0C4A7 = 0;

	public int int_2 = 3;

	public Class9(string F430C40D, string string_2, int int_3, int int_4)
	{
		AF12DABE = F430C40D;
		string_0 = string_2;
		int_2 = int_4;
		string_1 = "";
		int_0 = int_3;
	}

	private void C6B3EEB5(string string_2)
	{
	}

	public int method_0()
	{
		bool flag = false;
		try
		{
			_ = Environment.TickCount;
			AF12DABE = AF12DABE.TrimEnd('/');
			string text = AF12DABE + "/reset?proxy=" + string_0.Split(':')[0] + ":" + string_0.Split(':')[1];
			F3958F9B f3958F9B = new F3958F9B();
			string text2 = f3958F9B.method_0(text);
			if (text2.Contains("reset_too_much"))
			{
				Thread.Sleep(5000);
				return 2;
			}
			JObject jObject = JObject.Parse(text2);
			if (jObject.ContainsKey("msg") && (JObject.Parse(text2)["msg"]!.ToString() == "command_sent" || JObject.Parse(text2)["msg"]!.ToString() == "OK" || JObject.Parse(text2)["msg"]!.ToString().ToLower() == "ok"))
			{
				flag = true;
			}
			else if (jObject.ContainsKey("error_code") && JObject.Parse(text2)["error_code"]!.ToString().ToLower() == "0")
			{
				flag = true;
			}
			else
			{
				C6B3EEB5(text + ": " + text2);
			}
		}
		catch (Exception)
		{
		}
		return flag ? 1 : 0;
	}

	public int D4B3360B()
	{
		try
		{
			int num = 0;
			for (int i = 0; i < 5; i++)
			{
				num = method_0();
				if (num == 1)
				{
					GClass8.smethod_53(3.0);
					num = (method_1() ? 1 : 0);
				}
				if (num == 1)
				{
					break;
				}
			}
			return num;
		}
		catch
		{
		}
		return 0;
	}

	public bool method_1(int int_3 = -1)
	{
		if (int_3 == -1)
		{
			int_3 = GClass25.smethod_0("configGeneral").method_2("nudDelayResetXProxy", 5) * 60;
		}
		int tickCount = Environment.TickCount;
		bool flag = false;
		try
		{
			AF12DABE = AF12DABE.TrimEnd('/');
			string text = AF12DABE + "/status?proxy=" + string_0.Split(':')[0] + ":" + string_0.Split(':')[1];
			F3958F9B f3958F9B = new F3958F9B();
			string text2 = "";
			do
			{
				text2 = f3958F9B.method_0(text);
				try
				{
					if (!text2.Contains("public_ip_v6") && !text2.Contains("public_ip"))
					{
						if (flag = Convert.ToBoolean(JObject.Parse(text2)["status"]!.ToString()))
						{
							flag = JObject.Parse(text2)["msg"]!.ToString() == "MODEM_READY";
						}
					}
					else
					{
						string text3 = string_0.Split(':')[1];
						flag = ((text3.StartsWith("4") || text3.StartsWith("5")) ? (JObject.Parse(text2)["public_ip"]!.ToString() != "" && JObject.Parse(text2)["public_ip"]!.ToString() != "CONNECT_INTERNET_ERROR") : ((text3.StartsWith("6") || text3.StartsWith("7")) ? (JObject.Parse(text2)["public_ip_v6"]!.ToString() != "" && JObject.Parse(text2)["public_ip_v6"]!.ToString() != "CONNECT_INTERNET_ERROR") : Convert.ToBoolean(JObject.Parse(text2)["status"]!.ToString())));
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
			while (Environment.TickCount - tickCount < int_3 * 1000);
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public void E0232229()
	{
		int_1--;
		if (GClass25.smethod_0("configGeneral").method_2("typeRunXproxy") == 0 && int_1 == 0 && DBA0C4A7 == int_2)
		{
			DBA0C4A7 = 0;
		}
	}
}
