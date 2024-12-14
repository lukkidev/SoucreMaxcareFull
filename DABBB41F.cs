using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using Newtonsoft.Json.Linq;

public class DABBB41F
{
	public static string smethod_0(int int_0, string string_0)
	{
		string result = "";
		switch (int_0)
		{
		case 4:
			result = GClass24.FEA62D06(string_0, "6LeyIlkaAAAAAE-EjcALU28lwxWPusUvGL3e0avS", "https://fbsbx.com/captcha/recaptcha/iframe/");
			break;
		case 7:
			result = Class18.DBB1CD92(string_0, "6LeyIlkaAAAAAE-EjcALU28lwxWPusUvGL3e0avS", "https://fbsbx.com/captcha/recaptcha/iframe/");
			break;
		case 8:
			result = GClass13.smethod_0(string_0, "6LeyIlkaAAAAAE-EjcALU28lwxWPusUvGL3e0avS", "https://fbsbx.com/captcha/recaptcha/iframe/");
			break;
		case 0:
		case 1:
			result = F801AD0A.E8112C8F(int_0, string_0, "6LeyIlkaAAAAAE-EjcALU28lwxWPusUvGL3e0avS", "https://fbsbx.com/captcha/recaptcha/iframe/");
			break;
		}
		return result;
	}

	public static string D390252C(int int_0, string CB066E37, string F098070A)
	{
		string result = "";
		if (GClass24.smethod_2(GClass25.smethod_0("configCheckpoint").C0288288("txtCaptcha_4")))
		{
			return GClass24.smethod_0(GClass25.smethod_0("configCheckpoint").C0288288("txtCaptcha_4"), F098070A);
		}
		if (int_0 == 0)
		{
			result = F801AD0A.smethod_0(int_0, CB066E37, F098070A);
		}
		return result;
	}

	public static string CC8A2029(int ED859210, string string_0, int int_0, string B8B6BB1E = "", string BE3ECDBA = "")
	{
		string result = "";
		switch (ED859210)
		{
		case 1:
			result = smethod_49(string_0, int_0);
			break;
		case 2:
			result = B425953F(string_0, int_0);
			break;
		case 3:
			result = BD909328(string_0, int_0);
			break;
		case 4:
			result = smethod_43(string_0, int_0);
			break;
		case 5:
			result = smethod_45(string_0, int_0);
			break;
		case 6:
			result = smethod_47(string_0, int_0);
			break;
		case 8:
			result = smethod_3(string_0, int_0);
			break;
		case 9:
			result = smethod_9(string_0, int_0);
			break;
		case 10:
			result = DC9E39B7(string_0, int_0, B8B6BB1E);
			break;
		case 12:
			result = smethod_30(string_0, int_0);
			break;
		case 13:
			result = smethod_24(string_0, int_0);
			break;
		case 14:
			result = E317F8B9(string_0, int_0);
			break;
		case 15:
			result = smethod_29(string_0, int_0);
			break;
		case 16:
			result = E6212EA5(string_0, int_0);
			break;
		case 17:
			result = A00F49AF(string_0, int_0);
			break;
		case 18:
			result = smethod_23(string_0, int_0);
			break;
		case 19:
			result = smethod_2(string_0, int_0);
			break;
		case 21:
			result = E8A0D1B2(string_0, int_0);
			break;
		case 23:
			result = smethod_1(string_0, int_0);
			break;
		case 25:
			result = smethod_27(string_0, int_0);
			break;
		case 26:
			result = smethod_28(string_0, int_0);
			break;
		case 27:
			result = A50C440C(string_0, int_0);
			break;
		case 28:
			result = BFAE1884(string_0, int_0);
			break;
		case 29:
			result = B3BC51B3(string_0, int_0);
			break;
		case 30:
			result = CE28E280(string_0, int_0);
			break;
		case 31:
			result = smethod_25(string_0, int_0);
			break;
		case 32:
			result = smethod_26(string_0, int_0);
			break;
		case 33:
			result = smethod_31(string_0, int_0);
			break;
		case 34:
			result = smethod_4(string_0, int_0);
			break;
		case 35:
			result = smethod_5(string_0, int_0);
			break;
		case 36:
			result = smethod_6(string_0, int_0);
			break;
		case 38:
			result = C2284FAE(string_0, int_0, 1);
			break;
		case 39:
			result = DA37EBB5(string_0, int_0);
			break;
		case 40:
			result = smethod_8(string_0, int_0);
			break;
		case 41:
			result = CE28E280(string_0, int_0, 428);
			break;
		case 42:
			result = smethod_7(string_0, int_0);
			break;
		case 43:
			result = C2284FAE(string_0, int_0, 6);
			break;
		case 45:
			result = smethod_30(string_0, int_0, "facebook_ru");
			break;
		case 46:
			result = E59036AF(string_0, int_0);
			break;
		case 47:
			result = BABB652E(string_0, int_0);
			break;
		case 48:
			result = smethod_9(string_0, int_0, 133);
			break;
		case 49:
			result = smethod_10(string_0, int_0);
			break;
		case 52:
			result = smethod_24(string_0, int_0, "facebook_us");
			break;
		case 53:
			result = F618718C(string_0, int_0);
			break;
		case 54:
			result = CE28E280(string_0, int_0, 440);
			break;
		case 56:
			result = smethod_38(string_0, int_0);
			break;
		case 59:
			result = D4935296(string_0, int_0);
			break;
		case 61:
			result = smethod_39(string_0, int_0);
			break;
		case 62:
			result = smethod_40(string_0, int_0);
			break;
		}
		return result;
	}

	private static string A00F49AF(string string_0, int C81421B6)
	{
		GClass12 gClass = new GClass12();
		string text = "";
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		List<string> list = new List<string>();
		do
		{
			for (int num = 4; num > 0; num--)
			{
				try
				{
					string string_ = $"https://2ndline.pro/apiv1/order?apikey={string_0}&serviceId=275&networkId={num}&allowVoiceSms=false";
					text = gClass.method_0(string_);
					JObject jObject = JObject.Parse(text);
					text3 = jObject["id"]!.ToString();
					text2 = jObject["phone"]!.ToString();
					if (text3 != "" && text2 != "")
					{
						return text3 + "|" + text2;
					}
					if (text3 != "")
					{
						list.Add(text3);
					}
				}
				catch (Exception)
				{
				}
			}
		}
		while (list.Count <= 0);
		do
		{
			for (int i = 0; i < list.Count; i++)
			{
				text3 = list[i];
				try
				{
					text = gClass.method_0("https://2ndline.pro/apiv1/ordercheck?apikey=" + string_0 + "&id=" + text3);
					JObject jObject2 = JObject.Parse(text);
					text2 = jObject2["data"]!["phone"]!.ToString();
					if (text3 != "" && text2 != "")
					{
						return text3 + "|" + text2;
					}
				}
				catch (Exception)
				{
				}
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < C81421B6 * 1000);
		return text3 + "|" + text2;
	}

	private static string E6212EA5(string string_0, int DC93E88F)
	{
		GClass12 gClass = new GClass12();
		string text = "";
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text = gClass.method_0("https://otp282.com/api/createRequestOTP/" + string_0 + "/service_id/1");
				JObject jObject = JObject.Parse(text);
				text3 = jObject["data"]![0]!["request_id"]!.ToString();
				text2 = jObject["data"]![0]!["phone"]!.ToString();
				if (text3 != "" && text2 != "")
				{
					break;
				}
			}
			catch (Exception)
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < DC93E88F * 1000);
		return text3 + "|" + text2;
	}

	private static string smethod_1(string string_0, int E2246D39)
	{
		GClass12 gClass = new GClass12();
		string text = "";
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text = gClass.A9AEE5A7("https://codeotp.site/api/getphone", "token=" + string_0 + "&appid=9");
				JObject jObject = JObject.Parse(text);
				text3 = jObject["msg"]!["id"]!.ToString();
				text2 = jObject["msg"]!["number"]!.ToString();
				if (text3 != "" && text2 != "")
				{
					break;
				}
			}
			catch (Exception)
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < E2246D39 * 1000);
		return text3 + "|" + text2;
	}

	private static string smethod_2(string string_0, int FF071035)
	{
		GClass12 gClass = new GClass12();
		string text = "";
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text = gClass.method_0("http://hcotp.com/api/v2/createrequest?token=" + string_0 + "&serviceId=1&carrier=all");
				JObject jObject = JObject.Parse(text);
				text3 = jObject["id"]!.ToString();
				text2 = jObject["phoneNum"]!.ToString();
				if (text3 != "" && text2 != "")
				{
					break;
				}
			}
			catch (Exception)
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < FF071035 * 1000);
		return text3 + "|" + text2;
	}

	public static string smethod_3(string BCBBFCA6, int int_0, int int_1 = 7)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("https://api.viotp.com/request/getv2?token=" + BCBBFCA6 + "&serviceId=" + int_1);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["data"]!["request_id"]!.ToString();
				if (text3 != "")
				{
					text = jObject["data"]!["phone_number"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string A50C440C(string CC80CC07, int E727CB24)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("http://otptele.com/json/request/getv2.php?token=" + CC80CC07 + "&serviceId=63c1131b0e33b");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["data"]!["request_id"]!.ToString();
				if (text3 != "")
				{
					text = jObject["data"]!["phone_number"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < E727CB24 * 1000);
		return text3 + "|" + text;
	}

	public static string B3BC51B3(string string_0, int int_0)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("https://otpngon.com/public/api/getNumber?api_key=" + string_0 + "&service_id=1");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["Data"]![0]!["Request_ID"]!.ToString();
				if (text3 != "")
				{
					text = jObject["Data"]![0]!["Phone"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_4(string string_0, int B5AB0C05)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("https://atmteamfb.com/public/api/getNumber?api_key=" + string_0 + "&service_id=1");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["Data"]![0]!["Request_ID"]!.ToString();
				if (text3 != "")
				{
					text = jObject["Data"]![0]!["Phone"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < B5AB0C05 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_5(string string_0, int A10C6B95)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("https://tskvb.com/pick_isdn?service=Facebook&apikey=" + string_0);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["id"]!.ToString();
				if (text3 != "")
				{
					text = jObject["isdn"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < A10C6B95 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_6(string string_0, int int_0)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("https://api.usotp.xyz/create-request?apikey=" + string_0 + "&service=facebook&softid=tungmin");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["id"]!.ToString();
				if (text3 != "")
				{
					text = jObject["phone"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string BABB652E(string F28B2D82, int D1121B92)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("http://otp.vocfor.site/pick_isdn?Brand=facebook&Token=" + F28B2D82);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["isdn"]!.ToString();
				if (text3 != "")
				{
					text = jObject["isdn"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < D1121B92 * 1000);
		return text3 + "|" + text;
	}

	public static string E59036AF(string string_0, int int_0)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("http://live24h.shop/api/w1/BuyService?api_token=" + string_0 + "&service_id=6");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["data"]!["id"]!.ToString();
				if (text3 != "")
				{
					text = jObject["data"]!["phone"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_7(string string_0, int FF08FFAF)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("https://api.thuesim.cloud/utils/request-number-for-tool?clientId=" + string_0 + "&appCode=Facebook");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["requestId"]!.ToString();
				if (text3 != "")
				{
					text = jObject["number"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < FF08FFAF * 1000);
		return text3 + "|" + text;
	}

	public static string DA37EBB5(string E9B07CBB, int int_0)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("http://api.smartotp.net:3001/api/facebook/" + E9B07CBB);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["id"]!.ToString();
				if (text3 != "")
				{
					text = jObject["phoneNumber"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_8(string DA27578F, int int_0)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("https://access.thuesimgiare.com/api/sim-request?token=" + DA27578F + "&service=19");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["id"]!.ToString();
				if (text3 != "")
				{
					text = jObject["phone"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string C2284FAE(string string_0, int int_0, int C8B31D9F)
	{
		string text = "";
		F3958F9B f3958F9B = new F3958F9B();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				f3958F9B.httpRequest_0.AddHeader("code", "maxcarecutevippro");
				text2 = f3958F9B.method_0($"https://fullcode.me/api/public/user/sim/buy/v2?appId={C8B31D9F}&apiKey={string_0}");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["resultObj"]!["value"]!["id"]!.ToString();
				text = jObject["resultObj"]!["value"]!["number"]!.ToString();
				if (text3 != "" && text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_9(string string_0, int int_0, int int_1 = 1)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("http://otptextnow.com/api/?key=" + string_0 + "&action=get_number&id=" + int_1);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["request_id"]!.ToString();
				if (text3 != "")
				{
					text = jObject["number"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string F618718C(string B4B59335, int ADBCFE3D, int int_0 = 1)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("https://fastsim.online/api/sim/buy?key=" + B4B59335 + "&app=1");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["data"]!["id"]!.ToString();
				if (text3 != "")
				{
					text = jObject["data"]!["number"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < ADBCFE3D * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_10(string string_0, int B4371A38)
	{
		string text = "";
		F3958F9B f3958F9B = new F3958F9B();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string bFA79D3C = "{ \"api_key\":\"" + string_0 + "\", \"appId\":9}";
				text2 = f3958F9B.A6321D97("https://api.233io9.info/api/dangkysim", bFA79D3C, "application/json");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["Result"]!["id"]!.ToString();
				if (text3 != "")
				{
					text = jObject["Result"]!["number"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < B4371A38 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_11(string EF077EA4, string F8016736, int int_0 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = gClass.method_0("https://api.viotp.com/session/getv2?requestId=" + F8016736 + "&token=" + EF077EA4);
				JObject jObject = JObject.Parse(json);
				if (jObject["status_code"]!.ToString() == "200")
				{
					try
					{
						text = Regex.Match(jObject["data"]!["Code"]!.ToString(), "\\d+").Value;
						if (text != "")
						{
							return text;
						}
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string BD9D9282(string string_0, string string_1, int int_0 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = gClass.method_0("http://mthgroup.vn:8066/api2/?key=" + string_0 + "&phone=" + string_1 + "&excludeLayout&brand=Facebook");
				JObject jObject = JObject.Parse(json);
				text = Regex.Match(jObject["content"]!.ToString(), "\\d+").Value;
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string smethod_12(string string_0, string string_1, int int_0 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = gClass.method_0("https://fastsim.online/api/sim/check?key=" + string_0 + "&id=" + string_1);
				JObject jObject = JObject.Parse(json);
				text = Regex.Match(jObject["data"]!["code"]!.ToString(), "\\d+").Value;
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string smethod_13(string string_0, string AB9028A0, int int_0 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = gClass.method_0("https://api.random-otp.io.vn:8450/sms/getStatusCode?apiKey=" + string_0 + "&idPhoneNumber=" + AB9028A0);
				JObject jObject = JObject.Parse(json);
				text = Regex.Match(jObject["otp"]!.ToString(), "\\d+").Value;
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string smethod_14(string A0AC0E85, string string_0, int int_0 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = gClass.method_0("https://muasms.com/api/order.php?token=" + A0AC0E85 + "&trans_id=" + string_0);
				JObject jObject = JObject.Parse(json);
				text = Regex.Match(jObject["data"]!["otp"]!.ToString(), "\\d+").Value;
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string smethod_15(string string_0, string EA93843E, int AC3A5034 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= AC3A5034 * 1000)
		{
			try
			{
				string json = gClass.method_0("https://apisim.codesim.net/otp/get_otp_by_phone_api_key?otp_id=" + EA93843E + "&api_key=" + string_0);
				JObject jObject = JObject.Parse(json);
				text = Regex.Match(jObject["data"]!["code"]!.ToString(), "\\d+").Value;
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(5000);
		}
		return text;
	}

	public static string C1981B13(string string_0, string E7ADB4AD, int int_0 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = gClass.method_0("http://otptele.com/json/session/getv2.php?requestId=" + E7ADB4AD + "&token=" + string_0);
				JObject jObject = JObject.Parse(json);
				text = jObject["data"]!["Code"]!.ToString();
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string C7B0599F(string F49AEE94, string string_0, int ADA9F803 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= ADA9F803 * 1000)
		{
			try
			{
				string json = gClass.method_0("https://otpngon.com/public/api/getOTP?api_key=" + F49AEE94 + "&request_id=" + string_0);
				JObject jObject = JObject.Parse(json);
				text = jObject["Data"]![0]!["OTP"]!.ToString();
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string D1865106(string string_0, string string_1, int int_0 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = gClass.method_0("https://atmteamfb.com/public/api/getOTP?api_key=" + string_0 + "&request_id=" + string_1);
				JObject jObject = JObject.Parse(json);
				text = jObject["Data"]![0]!["OTP"]!.ToString();
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string C41131B5(string string_0, string string_1, int ACA0C93C = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= ACA0C93C * 1000)
		{
			try
			{
				string json = gClass.method_0("https://tskvb.com/get_otp?id_order=" + string_1 + "&apikey=" + string_0);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = Regex.Match(jObject["data"]![0]!["content"]!.ToString(), "\\d+").Value;
					if (text != "")
					{
						return text;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string E326EE18(string string_0, string E30D1193, int int_0 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = gClass.method_0("https://api.usotp.xyz/get-request?apikey=" + string_0 + "&id=" + E30D1193);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = Regex.Match(jObject["code"]!.ToString(), "\\d+").Value;
					if (text != "")
					{
						return text;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string A02C62A8(string B93BFB22, string BA959AB3, int int_0 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = gClass.method_0("http://live24h.shop/api/w1/SessionData?api_token=" + B93BFB22 + "&id=" + BA959AB3);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = Regex.Match(jObject["data"]!["code"]!.ToString(), "\\d+").Value;
					if (text != "")
					{
						return text;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string smethod_16(string string_0, string string_1, int int_0 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = gClass.method_0("http://otp.vocfor.site/get_otp?Brand=facebook&Token=" + string_0 + "&Isdn=" + string_1);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = Regex.Match(jObject["otp"]!.ToString(), "\\d+").Value;
					if (text != "")
					{
						return text;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string smethod_17(string string_0, string string_1, int int_0 = 120)
	{
		string text = "";
		F3958F9B f3958F9B = new F3958F9B();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string bFA79D3C = "{ \"api_key\":\"" + string_0 + "\", \"id\":" + string_1 + "}";
				string json = f3958F9B.A6321D97("https://api.233io9.info/api/layotpByID", bFA79D3C, "application/json");
				JObject jObject = JObject.Parse(json);
				try
				{
					text = Regex.Match(jObject["Result"]![0]!["otp"]!.ToString(), "\\d+").Value;
					if (text != "")
					{
						return text;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string smethod_18(string F433BB84, string AFB2C72F, int int_0 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = gClass.method_0("https://api.thuesim.cloud/utils/get-code-for-tool?clientId=" + F433BB84 + "&requestId=" + AFB2C72F);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = Regex.Match(jObject["content"]!.ToString(), "\\d+").Value;
					if (text != "")
					{
						return text;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string smethod_19(string string_0, string string_1, int int_0 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = gClass.method_0("http://api.smartotp.net:3001/api/order/" + string_1 + "/" + string_0);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = Regex.Match(jObject["content"]!.ToString(), "\\d+").Value;
					if (text != "")
					{
						return text;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string smethod_20(string string_0, string D4012C20, int EE3B3E87 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= EE3B3E87 * 1000)
		{
			try
			{
				string json = gClass.method_0("https://access.thuesimgiare.com/api/get-message?token=" + string_0 + "&phone=" + D4012C20);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = Regex.Match(jObject["message"]!.ToString(), "\\d+").Value;
					if (text != "")
					{
						return text;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string smethod_21(string string_0, string string_1, int C70D022D)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= C70D022D * 1000)
		{
			try
			{
				string json = gClass.method_0("https://fullcode.me/api/public/user/sim/v2?orderId=" + string_1 + "&apiKey=" + string_0);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = Regex.Match(jObject["resultObj"]!["code"]!.ToString(), "\\d+").Value;
					if (text != "")
					{
						return text;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string smethod_22(string string_0, string string_1, int int_0 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = gClass.method_0("http://otptextnow.com/api/?key=" + string_0 + "&action=get_code&id=" + string_1);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = Regex.Match(jObject["otp_code"]!.ToString(), "\\d+").Value;
					if (text != "")
					{
						return text;
					}
				}
				catch
				{
				}
				Thread.Sleep(3000);
			}
			catch
			{
			}
		}
		return text;
	}

	public static string E317F8B9(string FB1C1035, int A3BED116)
	{
		F3958F9B f3958F9B = new F3958F9B();
		string text = "";
		string text2 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text = f3958F9B.method_0("https://administrator.codetext247.com/api/sim-request?token=" + FB1C1035 + "&service=19");
				JObject jObject = JObject.Parse(text);
				text2 = jObject["phone"]!.ToString();
				if (text2 != "")
				{
					return text2;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < A3BED116 * 1000);
		return text2;
	}

	public static string smethod_23(string C1B5E70A, int C69FBB83)
	{
		GClass12 gClass = new GClass12();
		string text = "";
		string text2 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text = gClass.method_0("https://sosotps.com/get_sdt.php?apikey=" + C1B5E70A + "&dichvu=10");
				if (text.Split('|')[0] == "OK")
				{
					text2 = text.Split('|')[1];
				}
				if (text2 != "")
				{
					return text2;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < C69FBB83 * 1000);
		return text2;
	}

	public static string BFAE1884(string D6B5F48E, int B436E503)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("http://171.244.56.172:9152/pick_isdn?service=Facebook&apikey=" + D6B5F48E);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["id"]!.ToString();
				if (text3 != "")
				{
					text = jObject["isdn"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < B436E503 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_24(string string_0, int E91F2607, string B09EA700 = "facebook")
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("https://funotp.com/api?action=number&service=" + B09EA700 + "&apikey=" + string_0);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["Result"]!["id"]!.ToString();
				if (text3 != "")
				{
					text = jObject["Result"]!["number"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < E91F2607 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_25(string string_0, int int_0)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				if (text3 == "")
				{
					text2 = gClass.method_0("https://sell282.xyz/api/sim/buy?api_key=" + string_0 + "&service=9");
					JObject jObject = JObject.Parse(text2);
					text3 = jObject["data"]!["code_order"]!.ToString();
					text = jObject["data"]!["phone"]!.ToString();
				}
				if (text3 != "" && text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_26(string string_0, int int_0)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				if (text3 == "")
				{
					text2 = gClass.method_0("https://api.thuesim.app/api/facebook/" + string_0);
					JObject jObject = JObject.Parse(text2);
					text3 = jObject["id"]!.ToString();
					text = jObject["phoneNumber"]!.ToString();
				}
				if (text3 != "" && text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_27(string string_0, int int_0)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				if (text3 == "")
				{
					text2 = gClass.method_0("https://numberotp.co/public/api/gsm/order/facebook/" + string_0);
					JObject jObject = JObject.Parse(text2);
					text3 = jObject["id"]!.ToString();
					text = jObject["phoneNumber"]!.ToString();
				}
				if (text3 != "" && text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string E8A0D1B2(string string_0, int FC0F9A2E)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				if (text3 == "")
				{
					gClass.requestHTTP_0.SetDefaultHeaders(new string[1] { "Authorization: Basic " + string_0 });
					text2 = gClass.method_0("https://zimablue.click/zimablue/getmsisdn/Facebook");
					JObject jObject = JObject.Parse(text2);
					text3 = jObject["request_id"]!.ToString();
					text = jObject["msisdn"]!.ToString();
				}
				if (text3 != "")
				{
					if (text != "")
					{
						break;
					}
					gClass.requestHTTP_0.SetDefaultHeaders(new string[1] { "Authorization: Basic " + string_0 });
					text2 = gClass.method_0("https://zimablue.click/zimablue/getcontent/" + text3);
					JObject jObject2 = JObject.Parse(text2);
					text = jObject2["msisdn"]!.ToString();
					if (text != "")
					{
						break;
					}
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < FC0F9A2E * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_28(string CB21F3A7, int int_0)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				gClass.requestHTTP_0.SetDefaultHeaders(new string[1] { "Authorization: OTP " + CB21F3A7 });
				text2 = gClass.A9AEE5A7("https://trumotpvn.com/api/v1/order", "service=9");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["data"]!["id"]!.ToString();
				text = jObject["data"]!["phoneNumber"]!.ToString();
				if (text3 != "" && text != "")
				{
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_29(string DA9EEBA1, int int_0)
	{
		string text = "";
		F3958F9B f3958F9B = new F3958F9B();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		string text4 = GClass8.A2307E3B("ewkKCSJhcGlfa2V5Ijoie2FwaV9rZXl9IiwKCSJhcHBJZCI6InthcHBJZH0iCn0=");
		text4 = text4.Replace("{api_key}", DA9EEBA1);
		text4 = text4.Replace("{appId}", "9");
		do
		{
			try
			{
				text2 = f3958F9B.A6321D97("https://api.goodotp.xyz/api/dangkysim", text4, "application/json");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["Result"]!["id"]!.ToString();
				if (text3 != "")
				{
					text = jObject["Result"]!["number"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_30(string E281D335, int int_0, string D9A9AFBC = "facebook")
	{
		GClass12 gClass = new GClass12();
		string text = "";
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				if (text2 == "")
				{
					text = gClass.method_0("https://api.winmail.shop/phone/rent?clientId=" + E281D335 + "&serviceId=" + D9A9AFBC);
					JObject jObject = JObject.Parse(text);
					text3 = jObject["email"]!["phone"]!.ToString();
					text2 = jObject["email"]!["phoneId"]!.ToString();
				}
				if (text2 != "")
				{
					if (text3 != "")
					{
						break;
					}
					text = gClass.method_0("https://api.winmail.shop/phone/code?clientId=" + E281D335 + "&phoneId=" + text2);
					JObject jObject2 = JObject.Parse(text);
					text3 = jObject2["result"]!["phone"]!.ToString();
					if (text3 != "")
					{
						break;
					}
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text2 + "|" + text3;
	}

	public static string smethod_31(string string_0, int D21BFDBE)
	{
		GClass12 gClass = new GClass12();
		string text = "";
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				if (text2 == "")
				{
					text = gClass.method_0("https://api.tempsms.co/create?api_key=" + string_0 + "&service_id=13");
					JObject jObject = JObject.Parse(text);
					text2 = jObject["request_id"]!.ToString();
				}
				if (text2 != "")
				{
					if (text3 != "")
					{
						break;
					}
					text = gClass.method_0("https://api.tempsms.co/detail?api_key=" + string_0 + "&request_id=" + text2);
					JObject jObject2 = JObject.Parse(text);
					text3 = jObject2["phone"]!.ToString();
					if (text3 != "")
					{
						break;
					}
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < D21BFDBE * 1000);
		return text2 + "|" + text3;
	}

	public static string smethod_32(string string_0, string C53BC215, int int_0 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string json = gClass.method_0("https://api.winmail.shop/phone/code?clientId=" + string_0 + "&phoneId=" + C53BC215);
				JObject jObject = JObject.Parse(json);
				text = Regex.Match(jObject["result"]!["code"]!.ToString(), "\\d+").Value;
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(5000);
		}
		while (Environment.TickCount - tickCount <= int_0 * 1000);
		return text;
	}

	public static string smethod_33(string string_0, string A3AFC98A, int int_0 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string json = gClass.method_0("https://api.tempsms.co/detail?api_key=" + string_0 + "&request_id=" + A3AFC98A);
				JObject jObject = JObject.Parse(json);
				text = Regex.Match(jObject["otp"]!.ToString(), "\\d+").Value;
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(5000);
		}
		while (Environment.TickCount - tickCount <= int_0 * 1000);
		return text;
	}

	public static string smethod_34(string string_0, string BE97081A, int int_0 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		do
		{
			string text2 = "";
			try
			{
				text2 = gClass.method_0("https://funotp.com/api?action=code&id=" + BE97081A + "&apikey=" + string_0);
				JObject jObject = JObject.Parse(text2);
				if (!(jObject["ResponseCode"]!.ToString() == "2"))
				{
					text = Regex.Match(jObject["Result"]!["otp"]!.ToString(), "\\d+").Value;
					if (!(text != ""))
					{
						goto IL_00a6;
					}
				}
			}
			catch
			{
				goto IL_00a6;
			}
			break;
			IL_00a6:
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount <= int_0 * 1000);
		return text;
	}

	public static string smethod_35(string E893FD97, string string_0, int C209BB2C = 120)
	{
		string text = "";
		new F3958F9B();
		int tickCount = Environment.TickCount;
		string text2 = GClass8.A2307E3B("ewkKCSJhcGlfa2V5Ijoie2FwaV9rZXl9IiwKCSJpZCI6IntpZH0iCn0=");
		text2 = text2.Replace("{api_key}", E893FD97);
		text2 = text2.Replace("{id}", string_0);
		do
		{
			try
			{
				string json = new F3958F9B().A6321D97("https://api.goodotp.xyz/api/layotpByID", text2, "application/json");
				JObject jObject = JObject.Parse(json);
				text = Regex.Match(jObject["Result"]![0]!["message"]!.ToString(), "\\d+").Value;
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount <= C209BB2C * 1000);
		return text;
	}

	public static string FF027029(string string_0, string string_1, int int_0 = 120)
	{
		string text = "";
		F3958F9B f3958F9B = new F3958F9B();
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string json = f3958F9B.method_0("https://administrator.codetext247.com/api/get-message?token=" + string_0 + "&phone=" + string_1);
				JObject jObject = JObject.Parse(json);
				text = Regex.Match(jObject["message"]!.ToString(), "\\d+").Value;
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount <= int_0 * 1000);
		return text;
	}

	public static string A91DFA35(string string_0, string B586B38A, int int_0 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string json = gClass.A9AEE5A7("https://codeotp.site/api/getotp", "token=" + string_0 + "&id=" + B586B38A);
				JObject jObject = JObject.Parse(json);
				text = jObject["msg"]!["otp"]!.ToString();
				if (text == "")
				{
					text = Regex.Match(jObject["msg"]!["msg"]!.ToString(), "\\d+").Value;
				}
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount <= int_0 * 1000);
		return text;
	}

	public static string smethod_36(string string_0, string string_1, int int_0 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string text2 = gClass.method_0("https://sosotps.com/get_code.php?apikey=" + string_0 + "&dichvu=10&sdt=" + string_1);
				text2 = text2.Replace("NO|||", "");
				if (text2.Split('|')[0] == "OK")
				{
					text = text2.Split('|')[2];
				}
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount <= int_0 * 1000);
		return text;
	}

	public static string F1051B98(string B5ACDB0E, string E02D0215, int D181F193 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string json = gClass.method_0("http://171.244.56.172:9152/get_otp?id_order=" + E02D0215 + "&apikey=" + B5ACDB0E);
				text = Regex.Match(JObject.Parse(json)["data"]![0]!["content"]!.ToString(), "\\d+").Value;
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount <= D181F193 * 1000);
		return text;
	}

	public static string DC9E39B7(string string_0, int int_0, string EF875296)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.A9AEE5A7("https://tempcode.co/api/orders.php", "api_key=" + string_0 + "&act=buy_number&service_id=" + EF875296);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["data"]!["order_id"]!.ToString();
				if (text3 != "")
				{
					text = (jObject["data"]!["phonenumber"]!.ToString().Contains("+") ? jObject["data"]!["phonenumber"]!.ToString().Remove(0, 2) : jObject["data"]!["phonenumber"]!.ToString().Remove(0, 1));
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_37(string string_0, string string_1, int int_0 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = gClass.A9AEE5A7("https://tempcode.co/api/orders.php", "api_key=" + string_0 + "&act=read_message&order_id=" + string_1);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = Regex.Match(jObject["data"]!["otp"]!.ToString(), "\\d+").Value;
					if (text != "")
					{
						return text;
					}
				}
				catch
				{
				}
				Thread.Sleep(3000);
			}
			catch
			{
			}
		}
		return text;
	}

	public static string CE28E280(string D79E7E09, int int_0, int int_1 = 7)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("https://ironsim.com/api/phone/new-session?token=" + D79E7E09 + "&service=" + int_1);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["data"]!["session"]!.ToString();
				if (text3 != "")
				{
					text = jObject["data"]!["phone_number"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(1000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_38(string string_0, int FA33CE86)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("https://api.random-otp.io.vn:8450/sms/getNumber?apiKey=" + string_0 + "&country=6&service=fb");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["id"]!.ToString();
				if (text3 != "")
				{
					text = jObject["phoneNumber"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(1000);
		}
		while (Environment.TickCount - tickCount < FA33CE86 * 1000);
		return text3 + "|" + text;
	}

	public static string D4935296(string F818E41F, int F496FFA4)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("https://muasms.com/api/create-request.php?token=" + F818E41F + "&id=3");
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["trans_id"]!.ToString();
				if (text3 != "")
				{
					text = jObject["sdt"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(1000);
		}
		while (Environment.TickCount - tickCount < F496FFA4 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_39(string A1BA6B12, int int_0)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("https://apisim.codesim.net/sim/get_sim?service_id=1&api_key=" + A1BA6B12);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["data"]!["otpId"]!.ToString();
				if (text3 != "")
				{
					text = jObject["data"]!["phone"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(1000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_40(string string_0, int int_0)
	{
		string text = "";
		GClass0 gClass = new GClass0();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_1("https://sms.dichvummo.org/api.php?action=createNew&country=39&service=fb&apikey=" + string_0);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["data"]!["id"]!.ToString();
				if (text3 != "")
				{
					text = jObject["data"]!["phone_number"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(1000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string C186F0AD(string string_0, string F0B38988, int E3140B1D = 90)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string json = gClass.method_0("https://ironsim.com/api/session/" + F0B38988 + "/get-otp?token=" + string_0);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = jObject["data"]!["messages"]![0]!["otp"]!.ToString();
					if (text != "")
					{
						return text;
					}
				}
				catch
				{
				}
				Thread.Sleep(3000);
			}
			catch
			{
			}
		}
		while (Environment.TickCount - tickCount <= E3140B1D * 1000);
		return text;
	}

	public static string smethod_41(string string_0, string string_1, int C234CA09 = 90)
	{
		string text = "";
		GClass0 gClass = new GClass0();
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string json = gClass.method_1("https://sms.dichvummo.org/api.php?action=getSMS&apikey=" + string_0 + "&id=" + string_1);
				JObject jObject = JObject.Parse(json);
				try
				{
					text = jObject["data"]!["otp"]!.ToString();
					if (text != "")
					{
						return text;
					}
				}
				catch
				{
				}
				Thread.Sleep(3000);
			}
			catch
			{
			}
		}
		while (Environment.TickCount - tickCount <= C234CA09 * 1000);
		return text;
	}

	public static string BD909328(string string_0, int B790A99E)
	{
		GClass12 gClass = new GClass12();
		string text = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text = gClass.method_0("https://otpmmo.xyz/textnow/api.php?apikey=" + string_0 + "&type=getphone&qty=1");
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < B790A99E * 1000);
		return "";
	}

	public static string smethod_42(string string_0, string string_1, int int_0 = 60)
	{
		GClass12 gClass = new GClass12();
		string text = "";
		string text2 = "";
		for (int i = 0; i < int_0; i++)
		{
			try
			{
				text = gClass.method_0("https://otpmmo.xyz/textnow/api.php?apikey=" + string_0 + "&type=getotp&sdt=" + string_1);
				if (text != "")
				{
					text = text.Remove(0, 1);
					text = text.Remove(text.Length - 1, 1);
					JObject jObject = JObject.Parse(text);
					text2 = jObject["otp"]!.ToString();
					if (text2 != "")
					{
						return Regex.Match(text2, "\\d+").Value;
					}
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return "";
	}

	public static string smethod_43(string A897BCA3, int int_0)
	{
		GClass12 gClass = new GClass12();
		string text = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text = gClass.method_0("http://primeotp.me/api.php?apikey=" + A897BCA3 + "&action=create-request&serviceId=1&count=1");
				if (text != "")
				{
					JObject jObject = JObject.Parse(text);
					return jObject["results"]!["data"]![0]!["requestId"]!.ToString() + "|" + jObject["results"]!["data"]![0]!["sdt"]!.ToString();
				}
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return "";
	}

	public static string smethod_44(string A2BB4AB4, string A71AD5B3, int int_0 = 60)
	{
		GClass12 gClass = new GClass12();
		string text = "";
		string text2 = "";
		for (int i = 0; i < int_0; i++)
		{
			try
			{
				text = gClass.method_0("http://primeotp.me/api.php?apikey=" + A2BB4AB4 + "&action=data-request&requestId=" + A71AD5B3);
				if (text != "")
				{
					JObject jObject = JObject.Parse(text);
					text2 = jObject["data"]![0]!["otp"]!.ToString();
					if (text2 != "")
					{
						return Regex.Match(text2, "\\d+").Value;
					}
				}
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
		return "";
	}

	public static string smethod_45(string B937E725, int int_0, string CC813AB7 = "servertextnow.xyz")
	{
		GClass12 gClass = new GClass12();
		string text = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text = gClass.method_0("http://" + CC813AB7 + "/api/get-phone/?access_token=" + B937E725);
				if (text != "")
				{
					JObject jObject = JObject.Parse(text);
					return jObject["phone"]!.ToString();
				}
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return "";
	}

	public static string smethod_46(string string_0, string BC838989, string F2913431 = "servertextnow.xyz", int BFBA4411 = 60)
	{
		GClass12 gClass = new GClass12();
		string text = "";
		string text2 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text = gClass.method_0("http://" + F2913431 + "/api/get-otp/?access_token=" + string_0 + "&phone=" + BC838989);
				if (text != "")
				{
					JObject jObject = JObject.Parse(text);
					text2 = jObject["otp"]!.ToString();
					if (text2 != "")
					{
						return Regex.Match(text2, "\\d+").Value;
					}
				}
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
		while (Environment.TickCount - tickCount < BFBA4411 * 1000);
		return "";
	}

	public static string smethod_47(string string_0, int int_0)
	{
		GClass12 gClass = new GClass12();
		string text = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text = gClass.method_0("http://otpfb.com/api.php?apikey=" + string_0 + "&action=create-request&serviceId=1&count=1");
				if (text != "")
				{
					JObject jObject = JObject.Parse(text);
					return jObject["results"]!["data"]![0]!["requestId"]!.ToString() + "|" + jObject["results"]!["data"]![0]!["sdt"]!.ToString();
				}
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return "";
	}

	public static string CC9A2D35(string string_0, string string_1, int AA069528 = 60)
	{
		GClass12 gClass = new GClass12();
		string text = "";
		string text2 = "";
		for (int i = 0; i < AA069528; i++)
		{
			try
			{
				text = gClass.method_0("http://otpfb.com/api.php?apikey=" + string_0 + "&action=data-request&requestId=" + string_1);
				if (text != "")
				{
					JObject jObject = JObject.Parse(text);
					text2 = jObject["data"]![0]!["otp"]!.ToString();
					if (text2 != "")
					{
						return Regex.Match(text2, "\\d+").Value;
					}
				}
				Thread.Sleep(1000);
			}
			catch
			{
			}
		}
		return "";
	}

	public static string E6B4C6A8(string string_0, string F8AD6D9E, int int_0 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= int_0 * 1000)
		{
			try
			{
				string json = gClass.method_0("http://otpsim.com/api/sessions/" + F8AD6D9E + "?token=" + string_0);
				JObject jObject = JObject.Parse(json);
				if (Convert.ToBoolean(jObject["success"]!.ToString()))
				{
					try
					{
						text = JObject.Parse(json)["data"]!["messages"]![0]!["otp"]!.ToString();
						if (text != "")
						{
							return text;
						}
					}
					catch
					{
					}
				}
				Thread.Sleep(3000);
			}
			catch
			{
			}
		}
		return text;
	}

	public static string B425953F(string string_0, int int_0, int int_1 = 1001)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("https://chaycodeso3.com/api?act=number&apik=" + string_0 + "&appId=" + int_1);
				JObject jObject = JObject.Parse(text2);
				text3 = jObject["Result"]!["Id"]!.ToString();
				if (text3 != "")
				{
					text = jObject["Result"]!["Number"]!.ToString();
					break;
				}
			}
			catch
			{
			}
			Thread.Sleep(1000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_48(string B700F495, string string_0, int A23D2125 = 120)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= A23D2125 * 1000)
		{
			try
			{
				string json = gClass.method_0("https://chaycodeso3.com/api?act=code&apik=" + B700F495 + "&id=" + string_0);
				JObject jObject = JObject.Parse(json);
				if (jObject["ResponseCode"]!.ToString() == "0")
				{
					try
					{
						text = jObject["Result"]!["Code"]!.ToString();
						if (text != "")
						{
							return text;
						}
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		return text;
	}

	public static string smethod_49(string string_0, int int_0, int BA24CA86 = 7)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			text2 = gClass.method_0("http://otpsim.com/api/phones/request?token=" + string_0 + "&service=" + BA24CA86);
			try
			{
				JObject jObject = JObject.Parse(text2);
				if (!Convert.ToBoolean(jObject["success"]!.ToString()))
				{
					goto IL_00c9;
				}
				text = JObject.Parse(text2)["data"]!["phone_number"]!.ToString();
				text3 = JObject.Parse(text2)["data"]!["session"]!.ToString();
				if (!(text != "") || !(text3 != ""))
				{
					goto IL_00c9;
				}
				goto end_IL_004d;
				IL_00c9:
				Thread.Sleep(5000);
				continue;
				end_IL_004d:;
			}
			catch
			{
				continue;
			}
			break;
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text3 + "|" + text;
	}

	public static string smethod_50(int int_0, string string_0, string string_1, string string_2, int FEB3280F)
	{
		string result = "";
		switch (int_0)
		{
		case 1:
			result = E6B4C6A8(string_0, string_1, FEB3280F);
			break;
		case 2:
			result = smethod_48(string_0, string_1, FEB3280F);
			break;
		case 3:
			result = smethod_42(string_0, string_2, FEB3280F);
			break;
		case 4:
			result = smethod_44(string_0, string_1, FEB3280F);
			break;
		case 5:
			result = smethod_46(string_0, string_2, "servertextnow.xyz", FEB3280F);
			break;
		case 6:
			result = CC9A2D35(string_0, string_1, FEB3280F);
			break;
		case 8:
			result = smethod_11(string_0, string_1, FEB3280F);
			break;
		case 10:
			result = smethod_37(string_0, string_1, FEB3280F);
			break;
		case 14:
			result = FF027029(string_0, string_2, FEB3280F);
			break;
		case 15:
			result = smethod_35(string_0, string_1, FEB3280F);
			break;
		case 16:
			result = FC9EA501(string_0, string_1, FEB3280F);
			break;
		case 17:
			result = A425729B(string_0, string_1, FEB3280F);
			break;
		case 18:
			result = smethod_36(string_0, string_2, FEB3280F);
			break;
		case 19:
			result = smethod_51(string_0, string_1, FEB3280F);
			break;
		case 21:
			result = smethod_58(string_0, string_1, FEB3280F);
			break;
		case 23:
			result = A91DFA35(string_0, string_1, FEB3280F);
			break;
		case 25:
			result = A0311CA3(string_0, string_1, FEB3280F);
			break;
		case 26:
			result = smethod_59(string_0, string_1, FEB3280F);
			break;
		case 27:
			result = C1981B13(string_0, string_1, FEB3280F);
			break;
		case 28:
			result = F1051B98(string_0, string_1, FEB3280F);
			break;
		case 29:
			result = C7B0599F(string_0, string_1, FEB3280F);
			break;
		case 31:
			result = smethod_56(string_0, string_1, FEB3280F);
			break;
		case 32:
			result = smethod_57(string_0, string_1, FEB3280F);
			break;
		case 33:
			result = smethod_33(string_0, string_1, FEB3280F);
			break;
		case 34:
			result = D1865106(string_0, string_1, FEB3280F);
			break;
		case 35:
			result = C41131B5(string_0, string_1, FEB3280F);
			break;
		case 36:
			result = E326EE18(string_0, string_1, FEB3280F);
			break;
		case 39:
			result = smethod_19(string_0, string_1, FEB3280F);
			break;
		case 40:
			result = smethod_20(string_0, string_2, FEB3280F);
			break;
		case 42:
			result = smethod_18(string_0, string_1, FEB3280F);
			break;
		case 38:
		case 43:
			result = smethod_21(string_0, string_1, FEB3280F);
			break;
		case 12:
		case 45:
			result = smethod_32(string_0, string_1, FEB3280F);
			break;
		case 46:
			result = A02C62A8(string_0, string_1, FEB3280F);
			break;
		case 47:
			result = smethod_16(string_0, string_1, FEB3280F);
			break;
		case 9:
		case 48:
			result = smethod_22(string_0, string_1, FEB3280F);
			break;
		case 49:
			result = smethod_17(string_0, string_1, FEB3280F);
			break;
		case 50:
			result = BD9D9282(string_0, string_2, FEB3280F);
			break;
		case 13:
		case 52:
			result = smethod_34(string_0, string_1, FEB3280F);
			break;
		case 53:
			result = smethod_12(string_0, string_1, FEB3280F);
			break;
		case 30:
		case 41:
		case 54:
			result = C186F0AD(string_0, string_1, FEB3280F);
			break;
		case 56:
			result = smethod_13(string_0, string_1, FEB3280F);
			break;
		case 59:
			result = smethod_14(string_0, string_1, FEB3280F);
			break;
		case 61:
			result = smethod_15(string_0, string_1, FEB3280F);
			break;
		case 62:
			result = smethod_41(string_0, string_1, FEB3280F);
			break;
		}
		return result;
	}

	private static string A425729B(string E2B09428, string EC13BE91, int int_0)
	{
		GClass12 gClass = new GClass12();
		string text = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string json = gClass.method_0("https://2ndline.pro/apiv1/ordercheck?apikey=" + E2B09428 + "&id=" + EC13BE91);
				JObject jObject = JObject.Parse(json);
				text = Regex.Match(jObject["data"]!["message"]!.ToString(), "\\d+").Value;
				if (text != "")
				{
					return text;
				}
			}
			catch (Exception)
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text;
	}

	private static string FC9EA501(string string_0, string B81F2D31, int int_0)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string json = gClass.method_0("https://otp282.com/api/getOTPCode/" + string_0 + "/request_id/" + B81F2D31);
				JObject jObject = JObject.Parse(json);
				text = jObject["otpcode"]!.ToString();
				if (text == "")
				{
					text = Regex.Match(jObject["message"]!.ToString(), "\\d+").Value;
				}
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount <= int_0 * 1000);
		return text;
	}

	private static string smethod_51(string C5890A35, string string_0, int F33972A3)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				string json = gClass.method_0("http://hcotp.com/api/v2/getcode?token=" + C5890A35 + "&requestId=" + string_0);
				JObject jObject = JObject.Parse(json);
				text = jObject["code"]!.ToString();
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount <= F33972A3 * 1000);
		return text;
	}

	internal static void smethod_52(int int_0, string string_0, string string_1, string string_2)
	{
		switch (int_0)
		{
		case 15:
			DB8B419D(string_0, string_1);
			break;
		case 12:
			smethod_54(string_0, string_2);
			break;
		case 36:
			smethod_53(string_0, string_2);
			break;
		case 33:
			smethod_55(string_0, string_2);
			break;
		case 30:
			C2124338(string_0, string_2);
			break;
		}
	}

	public static bool smethod_53(string B40BC5A3, string string_0, int E7B2E433 = 120)
	{
		GClass12 gClass = new GClass12();
		try
		{
			string text = gClass.method_0("https://api.usotp.xyz/cancel-request?apikey=" + B40BC5A3 + "&id=" + string_0);
			return text.Trim() == "{}";
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_54(string string_0, string string_1, int FD922E3F = 120)
	{
		GClass12 gClass = new GClass12();
		try
		{
			string json = gClass.method_0("https://api.winmail.shop/phone/cancel?clientId=" + string_0 + "&phoneId=" + string_1);
			JObject jObject = JObject.Parse(json);
			return jObject["status"]!.ToString() == "canceled";
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_55(string string_0, string string_1, int DE9B97B2 = 120)
	{
		GClass12 gClass = new GClass12();
		try
		{
			string json = gClass.method_0("https://api.tempsms.co/cancel?api_key=" + string_0 + "&request_id=" + string_1);
			JObject jObject = JObject.Parse(json);
			return jObject["status_code"]!.ToString() == "0";
		}
		catch
		{
		}
		return false;
	}

	public static string DB8B419D(string A339C924, string F993C10B)
	{
		string result = "";
		new F3958F9B();
		string text = GClass8.A2307E3B("ewkKCSJhcGlfa2V5Ijoie2FwaV9rZXl9IiwKCSJhcHBfaWQiOiJ7YXBwX2lkfSIsCiAgICAgICAgIm51bWJlciI6IntudW1iZXJ9Igp9");
		text = text.Replace("{api_key}", A339C924);
		text = text.Replace("{app_id}", "9");
		text = text.Replace("{number}", F993C10B);
		try
		{
			string json = new F3958F9B().A6321D97("https://api.goodotp.xyz/api/huydangky", text, "application/json");
			JObject.Parse(json);
		}
		catch
		{
		}
		return result;
	}

	public static string C2124338(string string_0, string string_1)
	{
		string result = "";
		GClass12 gClass = new GClass12();
		try
		{
			string json = gClass.method_0("https://ironsim.com/api/session/cancel?token=" + string_0 + "&session=" + string_1);
			JObject jObject = JObject.Parse(json);
			result = jObject["success"]!.ToString();
		}
		catch
		{
		}
		return result;
	}

	public static string smethod_56(string string_0, string string_1, int A7A9EF06)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("https://sell282.xyz/api/sim/code?api_key=" + string_0 + "&code_order=" + string_1);
				JObject jObject = JObject.Parse(text2);
				text = Regex.Match(jObject["data"]!["code"]!.ToString(), "\\d+").Value;
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < A7A9EF06 * 1000);
		return text;
	}

	public static string smethod_57(string string_0, string string_1, int int_0)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("https://api.thuesim.app/api/order/" + string_1 + "/" + string_0);
				JObject jObject = JObject.Parse(text2);
				text = Regex.Match(jObject["content"]!.ToString(), "\\d+").Value;
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text;
	}

	public static string A0311CA3(string string_0, string string_1, int int_0)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				text2 = gClass.method_0("https://numberotp.co/public/api/gsm/get-order/" + string_1 + "/" + string_0);
				JObject jObject = JObject.Parse(text2);
				text = Regex.Match(jObject["content"]!.ToString(), "\\d+").Value;
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text;
	}

	public static string smethod_58(string string_0, string E78DC1BE, int C3B148A1)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				gClass.requestHTTP_0.SetDefaultHeaders(new string[1] { "Authorization: Basic " + string_0 });
				text2 = gClass.method_0("https://zimablue.click/zimablue/getcontent/" + E78DC1BE);
				JObject jObject = JObject.Parse(text2);
				text = jObject["otp"]!.ToString();
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < C3B148A1 * 1000);
		return text;
	}

	public static string smethod_59(string string_0, string string_1, int int_0)
	{
		string text = "";
		GClass12 gClass = new GClass12();
		string text2 = "";
		int tickCount = Environment.TickCount;
		do
		{
			try
			{
				gClass.requestHTTP_0.SetDefaultHeaders(new string[1] { "Authorization: OTP " + string_0 });
				text2 = gClass.method_0("https://trumotpvn.com/api/v1/order/" + string_1);
				JObject jObject = JObject.Parse(text2);
				text = jObject["data"]!["content"]!.ToString();
				text = Regex.Match(text, "\\d+").Value;
				if (text != "")
				{
					return text;
				}
			}
			catch
			{
			}
			Thread.Sleep(3000);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return text;
	}
}
