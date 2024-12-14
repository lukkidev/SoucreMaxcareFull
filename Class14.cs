using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

internal class Class14
{
	[CompilerGenerated]
	private sealed class FD340E80
	{
		public string string_0;

		internal bool A2894093(string string_1)
		{
			return string_1.Contains(string_0);
		}
	}

	private static object BD8F7E03 = new object();

	public static string C5302E20(string string_0, string string_1, string DE1EC1A7, int BB8B8398)
	{
		string result = "0|0";
		try
		{
			(string status, string info) tuple = C600032E(string_0, "", 0);
			_ = tuple.status;
			string item = tuple.info;
			if (item == "Live")
			{
				result = "1|1";
			}
		}
		catch
		{
		}
		return result;
	}

	public static List<string> FEAB4823(string AE89518C, string F109B189, string F81D8F16, string string_0, int CAAEB81D)
	{
		List<string> list = new List<string>();
		try
		{
			string value = Regex.Match(AE89518C, "c_user=(\\d+)").Groups[1].Value;
			F3958F9B f3958F9B = new F3958F9B(AE89518C, F81D8F16, string_0, CAAEB81D);
			f3958F9B.httpRequest_0.AddHeader("Authorization", "OAuth " + F109B189);
			string json = f3958F9B.method_0("https://graph.facebook.com/?ids=" + value + "&fields=friends{id,name}");
			JObject jObject = JObject.Parse(json);
			JToken jToken = jObject[value]!["friends"];
			if (jToken["data"].Count() > 0)
			{
				for (int i = 0; i < jToken["data"].Count(); i++)
				{
					string item = jToken["data"]![i]!["id"]!.ToString();
					list.Add(item);
				}
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	public static List<string> smethod_0(string string_0, string string_1, string BB813B94, string string_2, string D706F5B5, int int_0, int D2A84D29 = 20, bool D70872BD = false)
	{
		List<string> list = new List<string>();
		try
		{
			Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
			string[] array = string_0.Split(',');
			for (int i = 0; i < array.Length; i++)
			{
				dictionary.Add(array[i], new List<string>());
			}
			try
			{
				F3958F9B f3958F9B = new F3958F9B(string_1, string_2, D706F5B5, int_0);
				f3958F9B.httpRequest_0.AddHeader("Authorization", "OAuth " + BB813B94);
				string string_3 = "https://graph.facebook.com/?ids=" + string_0 + "&pretty=0&fields=id,name,photos.limit(" + D2A84D29 + "){images}";
				string text = f3958F9B.method_0(string_3);
				JObject jObject = JObject.Parse(text);
				if (jObject != null && text.Contains("images"))
				{
					string[] array2 = string_0.Split(',');
					foreach (string text2 in array2)
					{
						string text3 = jObject[text2]!["name"]!.ToString();
						try
						{
							foreach (JToken item in (IEnumerable<JToken>)(jObject[text2]!["photos"]!["data"]!))
							{
								try
								{
									int num = item["images"].ToList().Count - 1;
									dictionary[text2].Add(text2 + "*" + text3 + "*" + item["images"]![num]!["source"]?.ToString() + "|" + item["images"]![num]!["width"]?.ToString() + "|" + item["images"]![num]!["height"]);
								}
								catch
								{
								}
							}
						}
						catch
						{
						}
					}
				}
			}
			catch
			{
			}
			if (D70872BD)
			{
				try
				{
					F3958F9B f3958F9B2 = new F3958F9B(string_1, string_2, D706F5B5, int_0);
					f3958F9B2.httpRequest_0.AddHeader("Authorization", "OAuth " + BB813B94);
					string string_4 = "https://graph.facebook.com/?ids=" + string_0 + "&pretty=0&fields=name,albums.limit(3){photos.limit(10){width,height,images}}";
					string text4 = f3958F9B2.method_0(string_4);
					JObject jObject2 = JObject.Parse(text4);
					if (jObject2 != null && text4.Contains("images"))
					{
						string[] array3 = string_0.Split(',');
						foreach (string text5 in array3)
						{
							string text6 = jObject2[text5]!["name"]!.ToString();
							foreach (JToken item2 in (IEnumerable<JToken>)(jObject2[text5]!["albums"]!["data"]!))
							{
								try
								{
									foreach (JToken item3 in (IEnumerable<JToken>)(item2["photos"]!["data"]!))
									{
										try
										{
											int num2 = item3["images"].ToList().Count - 1;
											if (dictionary[text5].Count < D2A84D29)
											{
												dictionary[text5].Add(text5 + "*" + text6 + "*" + item3["images"]![num2]!["source"]?.ToString() + "|" + item3["images"]![num2]!["width"]?.ToString() + "|" + item3["images"]![num2]!["height"]);
												continue;
											}
										}
										catch (Exception)
										{
											continue;
										}
										goto IL_04bd;
									}
								}
								catch (Exception)
								{
								}
							}
							IL_04bd:;
						}
					}
				}
				catch
				{
				}
			}
			foreach (KeyValuePair<string, List<string>> item4 in dictionary)
			{
				if (item4.Value.Count > 0)
				{
					list.AddRange(item4.Value);
					list.Add("");
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public static Bitmap smethod_1(string string_0, bool bool_0 = false)
	{
		try
		{
			F3958F9B f3958F9B = new F3958F9B();
			string string_ = "https://graph.facebook.com/" + string_0 + "/picture?height=500&access_token=6628568379%7Cc1e620fa708a1d5696fb991c1bde5662";
			byte[] array = f3958F9B.F204C69A(string_);
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(array, 0, Convert.ToInt32(array.Length));
			Bitmap bitmap = new Bitmap(memoryStream, useIcm: false);
			if (bool_0)
			{
				string text = GClass28.smethod_0() + "\\avatar";
				GClass8.smethod_32(text);
				bitmap.Save(text + "\\" + string_0 + ".png");
			}
			return bitmap;
		}
		catch
		{
		}
		return null;
	}

	public static string smethod_2(string C7A3E7AE, string string_0, string string_1 = "", int int_0 = 0)
	{
		try
		{
			string string_2 = "https://graph.facebook.com/" + C7A3E7AE + "/picture?width=9999&access_token=6628568379|c1e620fa708a1d5696fb991c1bde5662&redirect=false";
			F3958F9B f3958F9B = new F3958F9B("", "", string_1, int_0);
			string text = f3958F9B.method_0(string_2);
			text = text.Trim('"');
			return smethod_4(text, string_0, C7A3E7AE);
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA, "Error DownLoadImageByUid");
		}
		return "";
	}

	public static string smethod_3(string string_0)
	{
		string result = "";
		try
		{
			using WebClient webClient = new WebClient();
			byte[] inArray = webClient.DownloadData(string_0);
			result = Convert.ToBase64String(inArray);
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static string smethod_4(string string_0, string string_1 = "", string E3396CB8 = "")
	{
		string_1 = ((string_1 == "") ? (GClass28.smethod_0() + "\\photos") : string_1.Trim('\\')) + "\\";
		string text = "";
		for (int i = 0; i < 2; i++)
		{
			try
			{
				using WebClient webClient = new WebClient();
				byte[] buffer = webClient.DownloadData(string_0);
				using MemoryStream stream = new MemoryStream(buffer);
				using Image image = Image.FromStream(stream);
				text = string_1 + ((E3396CB8 == "") ? Guid.NewGuid().ToString() : E3396CB8);
				try
				{
					image.Save(text + ".png", ImageFormat.Png);
					text += ".png";
				}
				catch
				{
					image.Save(text + ".jpg", ImageFormat.Jpeg);
					text += ".jpg";
				}
			}
			catch (Exception)
			{
			}
			if (text != "")
			{
				break;
			}
			string input = new F3958F9B().method_0(string_0);
			string_0 = Regex.Match(input, "src=\"(.*?)\"").Groups[1].Value;
			if (string_0 == "")
			{
				break;
			}
		}
		return text;
	}

	public static string EABAA59C(string CA02E40A, string string_0 = "")
	{
		string text = GClass8.smethod_88("CheckWall('" + CA02E40A + "','')");
		if (text != "1")
		{
			text = GClass8.smethod_88("CheckWall('" + CA02E40A + "','" + string_0 + "')");
		}
		return text + "|";
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckAvatar(byte[] CFBBD718, byte[] CEB2883E, byte[] byte_0);

	public static string F4B2E309(string string_0, string string_1 = "", int F8BA9D14 = 0)
	{
		byte[] cFBBD = GClass8.smethod_11(string_0);
		byte[] cEB2883E = GClass8.smethod_11(string_1);
		byte[] byte_ = GClass8.smethod_11(F8BA9D14.ToString());
		return GClass8.smethod_10(CheckAvatar(cFBBD, cEB2883E, byte_));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetName(byte[] CD142D98, byte[] byte_0, byte[] byte_1);

	public static string smethod_5(string string_0, string string_1 = "", int int_0 = 0)
	{
		byte[] cD142D = GClass8.smethod_11(string_0);
		byte[] byte_ = GClass8.smethod_11(string_1);
		byte[] byte_2 = GClass8.smethod_11(int_0.ToString());
		string text = GClass8.smethod_10(GetName(cD142D, GClass8.smethod_11(""), byte_2));
		if (text == "")
		{
			text = GClass8.smethod_10(GetName(cD142D, byte_, byte_2));
		}
		return text;
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckInfoUid(byte[] byte_0, byte[] byte_1, byte[] FB3C613C);

	public static string A61BB104(string A7A2882F, string string_0 = "", int int_0 = 0)
	{
		byte[] byte_ = GClass8.smethod_11(A7A2882F);
		byte[] byte_2 = GClass8.smethod_11("");
		byte[] fB3C613C = GClass8.smethod_11(int_0.ToString());
		string text = GClass8.smethod_10(CheckInfoUid(byte_, byte_2, fB3C613C));
		return ((text == "||||") ? "0" : "1") + "|" + text;
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckToken(byte[] byte_0, byte[] C6A54F33, byte[] byte_1, byte[] D8B6142C, byte[] byte_2);

	public static bool smethod_6(string string_0, string string_1, string A72F7830, string string_2, int int_0 = 0)
	{
		if (string_1 == "")
		{
			return false;
		}
		string text = GClass8.smethod_10(CheckToken(GClass8.smethod_11(string_1), GClass8.smethod_11(string_0), GClass8.smethod_11(A72F7830), GClass8.smethod_11(string_2), GClass8.smethod_11(int_0.ToString())));
		if (text == "1")
		{
			return true;
		}
		return false;
	}

	public static string B5A9F5BD(string string_0, string F038EC12, string string_1, int int_0 = 0)
	{
		string text = "";
		try
		{
			F3958F9B f3958F9B = new F3958F9B(string_0, "", string_1, int_0);
			f3958F9B.httpRequest_0.AddHeader("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
			f3958F9B.httpRequest_0.AddHeader("accept-language", "en-US,en;q=0.9");
			f3958F9B.httpRequest_0.AddHeader("sec-ch-ua", "\"Google Chrome\";v=\"95\", \"Chromium\";v=\"95\", \";Not A Brand\";v=\"99\"");
			f3958F9B.httpRequest_0.AddHeader("sec-ch-ua-mobile", "?0");
			f3958F9B.httpRequest_0.AddHeader("sec-ch-ua-platform", "\"Windows\"");
			f3958F9B.httpRequest_0.AddHeader("sec-fetch-dest", "document");
			f3958F9B.httpRequest_0.AddHeader("sec-fetch-mode", "navigate");
			f3958F9B.httpRequest_0.AddHeader("sec-fetch-site", "none");
			f3958F9B.httpRequest_0.AddHeader("sec-fetch-user", "?1");
			f3958F9B.httpRequest_0.AddHeader("upgrade-insecure-requests", "1");
			f3958F9B.httpRequest_0.AddHeader("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/95.0.4638.69 Safari/537.36");
			string input = f3958F9B.method_0("https://www.facebook.com/adsmanager/manage/campaigns?act=");
			text = Regex.Match(input, "EAAB(.*?)\"").Value.Replace("\"", "").Replace("\\", "");
		}
		catch
		{
			if (!C5302E20(string_0, F038EC12, string_1, int_0).StartsWith("1|"))
			{
				return "-1";
			}
		}
		if (text == "" && !C5302E20(string_0, F038EC12, string_1, int_0).StartsWith("1|"))
		{
			return "-1";
		}
		return text;
	}

	public static string smethod_7(string string_0)
	{
		string result = "";
		int num = 0;
		uint num2 = C43AF739.smethod_0(string_0);
		if (num2 <= 1315429348)
		{
			if (num2 <= 822911587)
			{
				if (num2 != 334175660)
				{
					if (num2 != 401286136)
					{
						if (num2 == 822911587 && string_0 == "4")
						{
							goto IL_01c8;
						}
					}
					else if (string_0 == "14")
					{
						result = ((num != 0) ? "Device" : "Thiết bị");
						goto IL_02c6;
					}
				}
				else if (string_0 == "18")
				{
					result = ((num != 0) ? "comment" : "Bình luận");
					goto IL_02c6;
				}
				goto IL_02a5;
			}
			if (num2 <= 923577301)
			{
				if (num2 != 906799682)
				{
					if (num2 != 923577301 || !(string_0 == "2"))
					{
						goto IL_02a5;
					}
					result = ((num != 0) ? "Birthday" : "Ngày sinh");
				}
				else
				{
					if (!(string_0 == "3"))
					{
						goto IL_02a5;
					}
					result = ((num != 0) ? "Image" : "Ảnh");
				}
			}
			else if (num2 != 1153637868)
			{
				if (num2 != 1315429348 || !(string_0 == "id_upload"))
				{
					goto IL_02a5;
				}
				result = "Up a\u0309nh";
			}
			else
			{
				if (!(string_0 == "72h"))
				{
					goto IL_02a5;
				}
				result = ((num != 0) ? "72 hours" : "72h");
			}
		}
		else
		{
			if (num2 <= 2347784130u)
			{
				if (num2 != 1718322808)
				{
					if (num2 != 2331006511u)
					{
						if (num2 == 2347784130u && string_0 == "34")
						{
							goto IL_01c8;
						}
					}
					else if (string_0 == "37")
					{
						result = "Otp mail";
						goto IL_02c6;
					}
				}
				else if (string_0 == "2fa")
				{
					result = "Co\u0301 2fa";
					goto IL_02c6;
				}
				goto IL_02a5;
			}
			if (num2 <= 2364561749u)
			{
				if (num2 != 2347931225u)
				{
					if (num2 != 2364561749u || !(string_0 == "35"))
					{
						goto IL_02a5;
					}
					result = "Login google";
				}
				else
				{
					if (!(string_0 == "26"))
					{
						goto IL_02a5;
					}
					result = ((num != 0) ? "Friend" : "Nhơ\u0300 bạn bè");
				}
			}
			else if (num2 != 2381486463u)
			{
				if (num2 != 2517938561u || !(string_0 == "vhh"))
				{
					goto IL_02a5;
				}
				result = ((num != 0) ? "disable" : "Vô hiệu hóa");
			}
			else
			{
				if (!(string_0 == "20"))
				{
					goto IL_02a5;
				}
				result = ((num != 0) ? "Message" : "Tin nhắn");
			}
		}
		goto IL_02c6;
		IL_01c8:
		result = "Otp phone";
		goto IL_02c6;
		IL_02a5:
		File.AppendAllText("data\\dangcp.txt", string_0);
		goto IL_02c6;
		IL_02c6:
		return result;
	}

	public static string smethod_8(string string_0, string string_1, string string_2, string string_3, int int_0)
	{
		string text = "";
		try
		{
			string bFA79D3C = "email=" + WebUtility.UrlEncode(string_0) + "&pass=" + WebUtility.UrlEncode(string_1);
			F3958F9B f3958F9B = new F3958F9B("", string_2, string_3, int_0);
			string text2 = f3958F9B.A6321D97("https://mbasic.facebook.com/login/device-based/regular/login/?refsrc=https%3A%2F%2Fmbasic.facebook.com%2F&lwv=100&refid=8", bFA79D3C).ToString();
			if (text2.Contains("id=\"checkpointSubmitButton\""))
			{
				if (text2.Contains("id=\"approvals_code\""))
				{
					text = "5|";
				}
				else
				{
					text = "2|";
					f3958F9B = new F3958F9B("", string_2, string_3, int_0);
					f3958F9B.method_0("https://www.facebook.com").ToString();
					text2 = f3958F9B.A6321D97("https://www.facebook.com/login/device-based/regular/login/?login_attempt=1&lwv=100", bFA79D3C).ToString();
					string value = Regex.Match(text2, "name=\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
					string value2 = Regex.Match(text2, "name=\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
					string value3 = Regex.Match(text2, "name=\"nh\" value=\"(.*?)\"").Groups[1].Value;
					string value4 = Regex.Match(text2, "\"__spin_r\":(.*?),").Groups[1].Value;
					string value5 = Regex.Match(text2, "\"__spin_t\":(.*?),").Groups[1].Value;
					string bFA79D3C2 = "jazoest=" + value2 + "&fb_dtsg=" + value + "&nh=" + value3 + "&submit[Continue]=Ti%E1%BA%BFp%20t%E1%BB%A5c&__user=0&__a=1&__dyn=7xe6Fo4OQ1PyUhxOnFwn84a2i5U4e1Fx-ewSwMxW0DUeUhw5cx60Vo1upE4W0OE2WxO0SobEa87i0n2US1vw4Ugao881FU3rw&__csr=&__req=5&__beoa=0&__pc=PHASED%3ADEFAULT&dpr=1&__rev=" + value4 + "&__s=op5tkm%3A2d4a9m%3A37z92b&__hsi=6789153697588537525-0&__spin_r=" + value4 + "&__spin_b=trunk&__spin_t=" + value5;
					text2 = f3958F9B.A6321D97("https://www.facebook.com/checkpoint/async?next=https%3A%2F%2Fwww.facebook.com%2F", bFA79D3C2);
					text2 = f3958F9B.method_0("https://www.facebook.com/checkpoint/?next");
					MatchCollection matchCollection = Regex.Matches(text2, "verification_method\" value=\"(.*?)\"");
					if (matchCollection.Count > 0)
					{
						for (int i = 0; i < matchCollection.Count; i++)
						{
							text = text + smethod_7(matchCollection[i].Groups[1].Value) + "-";
						}
						text = text.TrimEnd('-');
					}
					else if (text2.Contains("/checkpoint/dyi/?referrer=disabled_checkpoint"))
					{
						text += smethod_7("vhh");
					}
					else if (text2.Contains("captcha-recaptcha"))
					{
						text += smethod_7("72h");
					}
					else if (!text2.Contains("name=\"submit[Log Out]\"") && !text2.Contains("name=\"submit[__placeholder__]\""))
					{
						if (text2.Contains("name=\"submit[Continue]\""))
						{
							text += "Thiê\u0301t bi\u0323";
						}
					}
					else
					{
						text += "không thê\u0309 xmdt";
					}
				}
			}
			else if (text2.Contains("login_error"))
			{
				text = ((!text2.Contains("m_login_email")) ? "0|" : "3|");
			}
			else if (text2.Contains("action_set_contact_point"))
			{
				text = "2|" + smethod_7("34");
			}
			else
			{
				string text3 = f3958F9B.method_3();
				text = ((!C5302E20(text3, string_2, string_3, int_0).StartsWith("1|")) ? "2|" : (text + "1|" + text3));
			}
		}
		catch
		{
			text = "0|";
		}
		return text;
	}

	public static string smethod_9(string string_0, string string_1, string string_2, string CF3E6F88, string A52AFDAC, int D78ACC13)
	{
		string text = "";
		bool flag = false;
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		string text8 = "";
		try
		{
			F3958F9B f3958F9B = new F3958F9B(string_0, CF3E6F88, A52AFDAC, D78ACC13);
			if (string_2 == "")
			{
				string_2 = "me";
			}
			string json = f3958F9B.method_0("https://graph.facebook.com/v2.11/" + string_2 + "?fields=name,email,gender,birthday,friends.limit(0)&access_token=" + string_1);
			JObject jObject = JObject.Parse(json);
			flag = true;
			text2 = jObject["name"]!.ToString();
			try
			{
				text3 = jObject["gender"]!.ToString();
			}
			catch
			{
			}
			try
			{
				text4 = jObject["birthday"]!.ToString();
			}
			catch
			{
			}
			try
			{
				text6 = jObject["email"]!.ToString();
			}
			catch
			{
			}
			try
			{
				text7 = jObject["friends"]!["summary"]!["total_count"]!.ToString();
			}
			catch
			{
			}
		}
		catch
		{
			if (!smethod_6(string_0, string_1, "", ""))
			{
				return "-1";
			}
		}
		return $"{flag}|{text2}|{text3}|{text4}|{text5}|{text6}|{text7}|{text8}";
	}

	private static void smethod_10(string DF07AC32)
	{
		List<string> list = new List<string>();
		foreach (JToken item in (IEnumerable<JToken>)(JObject.Parse(DF07AC32)["friends"]!["data"]!))
		{
			list.Add(item["id"]!.ToString());
		}
		list = list.Distinct().ToList();
		File.WriteAllText("D:\\test.txt", string.Join("\n", list));
	}

	public static string A2A4FE27(string string_0, string string_1, string FFA5A703, int int_0)
	{
		string text = "";
		bool flag = false;
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		string text8 = "";
		string text9 = "";
		string text10 = "";
		try
		{
			string value = Regex.Match(string_0, "c_user=(\\d+)").Groups[1].Value;
			F3958F9B f3958F9B = new F3958F9B(string_0, string_1, FFA5A703, int_0);
			string string_2 = "https://business.facebook.com/business_locations/";
			string input = f3958F9B.method_0(string_2);
			string value2 = Regex.Match(input, "dtsg\":{\"token\":\"(.*?)\"").Groups[1].Value;
			text9 = Regex.Match(input, "EAAA(.*?)\"").Value.TrimEnd('"', '\\');
			text2 = JObject.Parse("{" + Regex.Match(input, "\"NAME\":\"(.*?)\"").Value + "}")["NAME"]!.ToString();
			text2 = WebUtility.HtmlDecode(text2);
			string text11 = GClass8.A2307E3B("LS0tLS0tV2ViS2l0Rm9ybUJvdW5kYXJ5MnlnMEV6RHBTWk9DWGdCUgpDb250ZW50LURpc3Bvc2l0aW9uOiBmb3JtLWRhdGE7IG5hbWU9ImZiX2R0c2ciCgp7e2ZiX2R0c2d9fQotLS0tLS1XZWJLaXRGb3JtQm91bmRhcnkyeWcwRXpEcFNaT0NYZ0JSCkNvbnRlbnQtRGlzcG9zaXRpb246IGZvcm0tZGF0YTsgbmFtZT0icSIKCm5vZGUoe3t1aWR9fSl7ZnJpZW5kc3tjb3VudH0sc3Vic2NyaWJlcnN7Y291bnR9LGdyb3VwcyxjcmVhdGVkX3RpbWV9Ci0tLS0tLVdlYktpdEZvcm1Cb3VuZGFyeTJ5ZzBFekRwU1pPQ1hnQlItLQ==");
			text11 = text11.Replace("{{fb_dtsg}}", value2);
			text11 = text11.Replace("{{uid}}", value);
			input = f3958F9B.A6321D97("https://www.facebook.com/api/graphql/", text11, "multipart/form-data; boundary=----WebKitFormBoundary2yg0EzDpSZOCXgBR");
			JObject jObject = JObject.Parse(input);
			text7 = jObject[value]!["friends"]!["count"]!.ToString();
			text8 = jObject[value]!["groups"]!["count"]!.ToString();
			text10 = jObject[value]!["created_time"]!.ToString();
			if (text7 == "")
			{
				text7 = "0";
			}
			if (text8 == "")
			{
				text8 = "0";
			}
		}
		catch
		{
			if (!C5302E20(string_0, string_1, FFA5A703, int_0).Contains("1|"))
			{
				return "-1";
			}
		}
		return $"{flag}|{text2}|{text3}|{text4}|{text5}|{text6}|{text7}|{text8}|{text9}|{text10}";
	}

	public static string BD0DD421(string string_0, string string_1)
	{
		string text = "";
		bool flag = false;
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		string text8 = "";
		string text9 = "";
		string text10 = "";
		try
		{
			string text11 = "c_user=" + Regex.Match(string_1 + ";", "c_user=(\\d+)").Groups[1].Value + "; xs=xs=" + Regex.Match(string_1 + ";", "xs=(.*?);").Groups[1].Value + ";";
			F3958F9B f3958F9B = new F3958F9B(text11 + " useragent=TW96aWxsYS81LjAgKFdpbmRvd3MgTlQgMTAuMDsgV2luNjQ7IHg2NCkgQXBwbGVXZWJLaXQvNTM3LjM2IChLSFRNTCwgbGlrZSBHZWNrbykgQ2hyb21lLzc0LjAuMjMwMi42MSBTYWZhcmkvNTM3LjM2", "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:50.0) Gecko/20100101 Firefox/50.0");
			string string_2 = "https://www.facebook.com/api/graphql";
			string bFA79D3C = "q=user(" + string_0 + ")%7Bfriends%7Bcount%7D%2Cgroups%7Bcount%7D%2Cid%2Cname%2Cgender%2Cbirthday%2Cemail_addresses%2Cusername%7D";
			string json = f3958F9B.A6321D97(string_2, bFA79D3C);
			JObject jObject = JObject.Parse(json);
			text7 = jObject[string_0]!["friends"]!["count"]!.ToString();
			text8 = jObject[string_0]!["groups"]!["count"]!.ToString();
			text2 = jObject[string_0]!["name"]!.ToString();
			text4 = ((jObject[string_0]!["birthday"] != null) ? jObject[string_0]!["birthday"]!.ToString() : "");
			text3 = jObject[string_0]!["gender"]!.ToString().ToLower();
			if (text7 == "")
			{
				text7 = "0";
			}
			if (text8 == "")
			{
				text8 = "0";
			}
			flag = true;
		}
		catch
		{
			if (!C5302E20(string_1, "", "", 0).StartsWith("1|"))
			{
				return "-1";
			}
			flag = false;
		}
		return $"{flag}|{text2}|{text3}|{text4}|{text5}|{text6}|{text7}|{text8}|{text9}|{text10}";
	}

	internal static (string status, string info) C600032E(string A51AE190, string string_0, int F90E3720)
	{
		string item = "";
		string item2 = "";
		try
		{
			F3958F9B f3958F9B = new F3958F9B(A51AE190, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36", string_0, F90E3720);
			string text = "";
			for (int i = 0; i < 5; i++)
			{
				if (Class57.smethod_5())
				{
					break;
				}
				try
				{
					text = f3958F9B.method_0("https://www.facebook.com/");
				}
				catch (Exception)
				{
				}
				if (text != "")
				{
					break;
				}
			}
			if (text == "")
			{
				item = "Không check được";
			}
			else
			{
				string text2 = f3958F9B.method_4();
				if (text2.Contains("601051028565049"))
				{
					text2 = Regex.Match(text2, "https://(.*?)facebook.com").Value + "/checkpoint/601051028565049/submit/";
					string value = Regex.Match(text, "name=\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
					string value2 = Regex.Match(text, "name=\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
					text = f3958F9B.A6321D97(text2, "jazoest=" + value2 + "&fb_dtsg=" + value);
					text2 = f3958F9B.method_4();
				}
				if (text2.Contains("checkpoint/disabled"))
				{
					item = "Vô hiệu hóa";
					item2 = "Checkpoint: vhh";
				}
				else if (text2.Contains("828281030927956"))
				{
					string text3 = "956";
					item = "Checkpoint: " + text3;
					item2 = "Checkpoint: " + text3;
				}
				else
				{
					if (text2.Contains("1501092823525282"))
					{
						string text4 = GClass8.smethod_78(text, new List<string>
						{
							"name=\"action_proceed\"", "id=\"captcha\"", "name=\"code\"", "name=\"contact_point\"", "id=\"mobile_image_data\"", "name=\"contact_point_index\"", "id=\"m_login_email\"", "name=\"action_set_contact_point\"", "/help/contact/571927962827151", "qV0ToI14MZv.png",
							"tGIsE6jdnU6.png", "bfCKqoUg0E4.png", "CdZCxLZ7L5L.png"
						});
						string text5 = text4;
						string text6 = text5;
						uint num = C43AF739.smethod_0(text6);
						if (num <= 1962905460)
						{
							switch (num)
							{
							case 896415299u:
								if (text6 == "id=\"captcha\"")
								{
									item = "Captcha-" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
								}
								break;
							case 467237996u:
								if (text6 == "name=\"contact_point\"")
								{
									item = ((!text.Contains("email") || text.Contains("name=\"country_code\"")) ? ("Phone-" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")) : ("Email-" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")));
								}
								break;
							case 238436553u:
								if (text6 == "name=\"contact_point_index\"")
								{
									item = ((!text.Contains("name=\"action_use_different_phone\"")) ? ("Phone Old-" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")) : ("Phone-" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")));
								}
								break;
							case 1962905460u:
								if (text6 == "name=\"action_set_contact_point\"")
								{
								}
								break;
							case 1370698424u:
								if (text6 == "name=\"action_proceed\"")
								{
								}
								break;
							case 1064600637u:
								if (text6 == "/help/contact/571927962827151")
								{
									item = "Spam-" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
								}
								break;
							}
						}
						else if (num <= 2576475206u)
						{
							if (num != 2263203229u)
							{
								if (num != 2439781595u)
								{
									if (num == 2576475206u && text6 == "CdZCxLZ7L5L.png")
									{
										goto IL_04d6;
									}
								}
								else if (text6 == "tGIsE6jdnU6.png")
								{
									goto IL_04d6;
								}
							}
							else if (text6 == "bfCKqoUg0E4.png")
							{
								goto IL_04d6;
							}
						}
						else if (num != 3244666871u)
						{
							switch (num)
							{
							case 3830140182u:
								if (text6 == "name=\"code\"")
								{
									item = "Phone-" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
								}
								break;
							case 3647932414u:
								if (text6 == "id=\"mobile_image_data\"")
								{
									item = "Image-" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
								}
								break;
							}
						}
						else if (text6 == "qV0ToI14MZv.png")
						{
							goto IL_04d6;
						}
						goto IL_04f9;
					}
					if (!text.Contains("facebook.com/login.php") && !text.Contains("id=\"login_form\"") && !text.Contains("name=\"login\"") && !text.Contains("/login/device-based/validate-pin/"))
					{
						if (!text2.Contains("facebook.com/gettingstarted") && (!text.Contains("href=\"/menu/bookmarks/") || !text.Contains("id=\"mbasic_logout_button\"")) && (!text.Contains("id=\"MComposer\"") || !text.Contains("id=\"MBackNavBar\"")) && !text.Contains("\"is_checkpointed\":false"))
						{
							item = ((text.Contains("confirmation") && !text.Contains("preconfirmation")) ? "Novery Live" : ((text.Contains("/help/117450615006715") || text.Contains("eid=147943945047188")) ? "Checkpoint: login" : "Dạng Checkpoint khác"));
						}
						else
						{
							item2 = "Live";
							item = "Tài khoản live";
						}
					}
					else
					{
						item = "No login";
					}
				}
			}
			goto end_IL_000c;
			IL_04d6:
			item = "Đợi xét duyệt (" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ")";
			goto IL_04f9;
			IL_04f9:
			item2 = "Checkpoint: 282";
			end_IL_000c:;
		}
		catch (Exception)
		{
			item = "Không check được";
		}
		return (item, item2);
	}

	public static void smethod_11(int int_0, string string_0, int int_1 = -1)
	{
		fMain.fMain_0.F69B6909(int_0, string_0, int_1);
	}

	public static (string status, string info, string newPass) AC88689B(int int_0, string A7932585, F3958F9B f3958F9B_0, string A723BA98, string B12D5A3C, string string_0, string B0A94F96, string string_1)
	{
		string item = "";
		string item2 = "";
		string item3 = "";
		bool flag = false;
		try
		{
			int num = 0;
			int num2 = 3;
			string text = "";
			int num3 = 3;
			string text2 = "";
			string text3 = "";
			text2 = f3958F9B_0.method_0("https://www.facebook.com/checkpoint/828281030927956/?next=https%3A%2F%2Fwww.facebook.com%2F");
			string text4 = GClass8.smethod_96(text2, "\"LSD\",\\[\\],{\"token\":\"(.*?)\"");
			string text5 = GClass8.smethod_96(text2, "\"DTSGInitialData\",\\[\\],{\"token\":\"(.*?)\"");
			if (text5 == "")
			{
				item = "Unlock 956 Fail (Please try again 1)";
			}
			else
			{
				A723BA98 = GClass8.smethod_96(f3958F9B_0.method_3(), "c_user=(\\d+)");
				string text6 = "av=" + A723BA98 + "&__user=" + A723BA98 + "&__a=1&__req=7&__hs=20015.HYP%3Acomet_pkg.2.1..2.1&dpr=3&__ccg=EXCELLENT&__rev=1017496172&__s=pljtfv%3Aznp1jt%3Apkw3sx&__hsi=7427386731673553225&__dyn=7xeXxa1mxu1syaxG4Vp41twWwIxu13w8CewSwAyUco2qwJyE2OwpUe8hwaG0Z82_CwjE1xoswMwto2awgo9oO0n24oaEd82lwv89k2C1Fwc60D8vwRwlE-U2exi4UaEW0Loco4i5o2eUlwhE2Lx-0luVEbUGdG1Jw9h08O321Lwqo5B0bK1Iwqo2swEwkFU-4EdrwsUbUaU3yw&__csr=hJEJaIggyTtZ5RZlhdL8J9bviP5h6nkNpkhp2tltppFl-AaBykJprVbCghKjAgS8KcppWyECqq5pqDKQWVomwVxG3K4E5S0LUdpodEaHwpo5u0h-0A9U-09swqo4-m0PE1do0Rh1q3F0UUhw9m0d6w14K0tu03bC06q-00hl208Nw0Nzw4ZwwwjU0Ci1exe5WoK06So0De0709orx2ECp2otCga805vSew38o08NGa3e2Je9m&__comet_req=15&fb_dtsg=" + text5 + "&jazoest=25772&lsd=" + text4 + "&__spin_r=1017496172&__spin_b=trunk&__spin_t=1729323233&fb_api_caller_class=RelayModern&";
				string text7 = "";
				while (true)
				{
					IL_00d5:
					string text8 = "useEpsilonNavigateMutation";
					string text9 = "STEPPER_CONFIRMATION";
					string text10 = "";
					string text11 = "";
					string text12 = "";
					JObject jObject = null;
					text7 = text6 + "fb_api_req_friendly_name=" + text8 + "&variables=%7B%22input%22%3A%7B%22client_mutation_id%22%3A%221%22%2C%22actor_id%22%3A%22" + A723BA98 + "%22%2C%22step%22%3A%22" + text9 + "%22%2C%22token%22%3A%7B%22sensitive_string_value%22%3A%22" + text10 + "%22%7D%7D%2C%22scale%22%3A3%7D&server_timestamps=true&doc_id=9385152714844566";
					text2 = f3958F9B_0.B51DA5A0("https://www.facebook.com/api/graphql/", text7, "application/x-www-form-urlencoded", new string[2]
					{
						"x-fb-friendly-name: " + text8,
						"x-fb-lsd: " + text4
					});
					if (!text2.Contains("errorSummary"))
					{
						List<string> list = new List<string>();
						int tickCount = Environment.TickCount;
						while (!Class57.smethod_5())
						{
							try
							{
								jObject = JObject.Parse(text2);
							}
							catch (Exception)
							{
							}
							string text13 = GClass8.smethod_78(text2, new List<string>
							{
								"EpsilonIntroScreen", "EpsilonStepperScreen", "EpsilonAntiScriptingCaptcha", "EpsilonChallengeChooser", "EpsilonMessageCodeCaptcha", "IXTAuthenticityWizardContactPointSelectionScreenViewModel", "EpsilonEnterMessageCodeCaptcha", "IXTAuthenticityWizardContactPointConfirmationScreenViewModel", "IXTCustomRedirectScreenViewModel", "EpsilonProfilesReview",
								"EpsilonContactPointReview", "EpsilonLoginDetailsConfirmationScreen", "EpsilonOutroScreen"
							});
							list.Add(text13);
							string text14 = text13;
							string text15 = text14;
							uint num4 = C43AF739.smethod_0(text15);
							if (num4 <= 1651936736)
							{
								if (num4 > 1086481527)
								{
									if (num4 != 1525447425)
									{
										if (num4 != 1566447917)
										{
											if (num4 != 1651936736 || !(text15 == "IXTAuthenticityWizardContactPointSelectionScreenViewModel"))
											{
												goto IL_103d;
											}
											text12 = jObject["data"]!["ixt_xfac_universal_trigger"]!["screen"]!["view_model"]!["serialized_state"]!.ToString();
											text8 = "CometFacebookWithLoggedOutIXTNextMutation";
											text7 = text6 + "fb_api_req_friendly_name=" + text8 + "&variables=%7B%22input%22%3A%7B%22authenticity_wizard_contact_point_selection%22%3A%7B%22contact_point%22%3A%22" + text11 + "%22%2C%22contact_point_type%22%3A%22EMAIL%22%2C%22serialized_state%22%3A%22" + text12 + "%22%7D%2C%22actor_id%22%3A%22" + A723BA98 + "%22%2C%22client_mutation_id%22%3A%221%22%7D%2C%22scale%22%3A3%7D&server_timestamps=true&doc_id=8760610473984639";
											text2 = f3958F9B_0.B51DA5A0("https://www.facebook.com/api/graphql/", text7, "application/x-www-form-urlencoded", new string[2]
											{
												"x-fb-friendly-name: " + text8,
												"x-fb-lsd: " + text4
											});
										}
										else
										{
											if (!(text15 == "EpsilonIntroScreen"))
											{
												goto IL_103d;
											}
											smethod_11(int_0, A7932585 + "Get start...");
											text10 = GClass8.smethod_96(text2, "\"token\":\"(.*?)\"");
											if (text9 != "STEPPER_CONFIRMATION")
											{
												item = ((num <= 0) ? "Unlock 956 Fail (Intro)" : "Unlock 956 Fail (Verify Otp fail)");
												break;
											}
											text8 = "useEpsilonNavigateMutation";
											text7 = text6 + "fb_api_req_friendly_name=" + text8 + "&variables=%7B%22input%22%3A%7B%22client_mutation_id%22%3A%221%22%2C%22actor_id%22%3A%22" + A723BA98 + "%22%2C%22step%22%3A%22" + text9 + "%22%2C%22token%22%3A%7B%22sensitive_string_value%22%3A%22" + text10 + "%22%7D%7D%2C%22scale%22%3A3%7D&server_timestamps=true&doc_id=9385152714844566";
											text2 = f3958F9B_0.B51DA5A0("https://www.facebook.com/api/graphql/", text7, "application/x-www-form-urlencoded", new string[2]
											{
												"x-fb-friendly-name: " + text8,
												"x-fb-lsd: " + text4
											});
										}
									}
									else
									{
										if (!(text15 == "EpsilonLoginDetailsConfirmationScreen"))
										{
											goto IL_103d;
										}
										smethod_11(int_0, A7932585 + "Click done...");
										text10 = GClass8.smethod_96(text2, "\"token\":\"(.*?)\"");
										text8 = "useEpsilonNavigateMutation";
										text9 = "OUTRO";
										text7 = text6 + "fb_api_req_friendly_name=" + text8 + "&variables=%7B%22input%22%3A%7B%22client_mutation_id%22%3A%221%22%2C%22actor_id%22%3A%22" + A723BA98 + "%22%2C%22step%22%3A%22" + text9 + "%22%2C%22token%22%3A%7B%22sensitive_string_value%22%3A%22" + text10 + "%22%7D%7D%2C%22scale%22%3A3%7D&server_timestamps=true&doc_id=9385152714844566";
										text2 = f3958F9B_0.B51DA5A0("https://www.facebook.com/api/graphql/", text7, "application/x-www-form-urlencoded", new string[2]
										{
											"x-fb-friendly-name: " + text8,
											"x-fb-lsd: " + text4
										});
									}
									goto IL_1400;
								}
								if (num4 != 55629439)
								{
									if (num4 != 531998945)
									{
										if (num4 == 1086481527 && text15 == "EpsilonChallengeChooser")
										{
											smethod_11(int_0, A7932585 + "Choose challenge...");
											List<string> list2 = new List<string>();
											JArray jArray = null;
											jArray = ((!text2.Contains("verify_anti_scripting_captcha_code")) ? (jObject["data"]!["epsilon_navigate"]!["epsilon_checkpoint"]!["screen"]!["available_challenges"] as JArray) : (jObject["data"]!["verify_anti_scripting_captcha_code"]!["epsilon_checkpoint"]!["screen"]!["available_challenges"] as JArray));
											foreach (JToken item4 in jArray)
											{
												list2.Add(item4["type"]!.ToString().ToLower());
											}
											if (list2.Count != 0)
											{
												if (list2.Contains("email_captcha") && B12D5A3C != "")
												{
													text10 = GClass8.smethod_96(text2, "\"token\":\"(.*?)\"");
													text9 = "EMAIL_CAPTCHA";
													text8 = "useEpsilonNavigateMutation";
													text7 = text6 + "fb_api_req_friendly_name=" + text8 + "&variables=%7B%22input%22%3A%7B%22client_mutation_id%22%3A%221%22%2C%22actor_id%22%3A%22" + A723BA98 + "%22%2C%22step%22%3A%22" + text9 + "%22%2C%22token%22%3A%7B%22sensitive_string_value%22%3A%22" + text10 + "%22%7D%7D%2C%22scale%22%3A3%7D&server_timestamps=true&doc_id=9385152714844566";
													text2 = f3958F9B_0.B51DA5A0("https://www.facebook.com/api/graphql/", text7, "application/x-www-form-urlencoded", new string[2]
													{
														"x-fb-friendly-name: " + text8,
														"x-fb-lsd: " + text4
													});
													goto IL_1400;
												}
												string text16 = "";
												if (list2.Contains("email_captcha"))
												{
													text16 += "-Otp mail";
												}
												if (list2.Contains("text_message_captcha"))
												{
													text16 += "-Phone";
												}
												if (list2.Contains("credit_card_captcha"))
												{
													text16 += "-Card";
												}
												if (list2.Contains("birthday_captcha"))
												{
													text16 += "-Birthday";
												}
												if (list2.Contains("id_captcha"))
												{
													text16 += "-Xmdt";
												}
												if (text16 != "")
												{
													text16 = text16.Substring(1);
													item2 = (item = "Checkpoint: 956 (" + text16 + ")");
												}
												else
												{
													item2 = (item = "Checkpoint: 956 (" + string.Join(",", list2) + ")");
												}
												break;
											}
											item2 = (item = "Checkpoint: 956-Tìm hiểu thêm");
											break;
										}
									}
									else if (text15 == "EpsilonEnterMessageCodeCaptcha")
									{
										goto IL_10ec;
									}
								}
								else if (text15 == "IXTCustomRedirectScreenViewModel")
								{
									text10 = jObject["data"]!["ixt_screen_next"]!["view_model"]!["updated_token"]!.ToString();
									text8 = "useEpsilonXFACAuthenticityNavigationMutation";
									text7 = text6 + "fb_api_req_friendly_name=" + text8 + "&variables=%7B%22input%22%3A%7B%22client_mutation_id%22%3A%224%22%2C%22actor_id%22%3A%22" + A723BA98 + "%22%2C%22is_karma_limit_reached%22%3Afalse%2C%22token%22%3A%7B%22sensitive_string_value%22%3A%22" + text10 + "%22%7D%7D%2C%22scale%22%3A3%7D&server_timestamps=true&doc_id=8403843123055846";
									text2 = f3958F9B_0.B51DA5A0("https://www.facebook.com/api/graphql/", text7, "application/x-www-form-urlencoded", new string[2]
									{
										"x-fb-friendly-name: " + text8,
										"x-fb-lsd: " + text4
									});
									goto IL_1400;
								}
							}
							else if (num4 <= 1796792119)
							{
								if (num4 != 1660330020)
								{
									if (num4 != 1692771796)
									{
										if (num4 == 1796792119 && text15 == "EpsilonProfilesReview")
										{
											smethod_11(int_0, A7932585 + "Review profile...");
											text10 = GClass8.smethod_96(text2, "\"token\":\"(.*?)\"");
											text9 = "CONTACT_POINT_REVIEW";
											text8 = "useEpsilonNavigateMutation";
											text7 = text6 + "fb_api_req_friendly_name=" + text8 + "&variables=%7B%22input%22%3A%7B%22client_mutation_id%22%3A%221%22%2C%22actor_id%22%3A%22" + A723BA98 + "%22%2C%22step%22%3A%22" + text9 + "%22%2C%22token%22%3A%7B%22sensitive_string_value%22%3A%22" + text10 + "%22%7D%7D%2C%22scale%22%3A3%7D&server_timestamps=true&doc_id=8466618156761750";
											text2 = f3958F9B_0.B51DA5A0("https://www.facebook.com/api/graphql/", text7, "application/x-www-form-urlencoded", new string[2]
											{
												"x-fb-friendly-name: " + text8,
												"x-fb-lsd: " + text4
											});
											goto IL_1400;
										}
									}
									else if (text15 == "EpsilonOutroScreen")
									{
										flag = true;
										break;
									}
								}
								else if (text15 == "EpsilonAntiScriptingCaptcha")
								{
									smethod_11(int_0, A7932585 + "Bypass captcha...");
									num3--;
									if (num3 > 0)
									{
										string text17 = jObject["data"]!["epsilon_navigate"]!["epsilon_checkpoint"]!["screen"]!["captcha_data"]!["captcha_uri"]!.ToString();
										text17 = text17.Replace("&amp;", "&");
										int int_ = GClass25.smethod_0("configCheckpoint").method_2("typeCaptcha");
										string text18 = GClass25.smethod_0("configCheckpoint").C0288288("txtCaptcha_" + int_);
										if (!(text18 == "") || GClass24.smethod_2(GClass25.smethod_0("configCheckpoint").C0288288("txtCaptcha_4")))
										{
											string text19 = GClass8.smethod_94(f3958F9B_0.method_3(), text17);
											if (text19 == "")
											{
												goto IL_00d5;
											}
											string text20 = DABBB41F.D390252C(int_, text18, text19);
											if (text20 == "")
											{
												goto IL_00d5;
											}
											string text21 = jObject["data"]!["epsilon_navigate"]!["epsilon_checkpoint"]!["screen"]!["captcha_data"]!["captcha_persisted_data"]!.ToString();
											text10 = GClass8.smethod_96(text2, "\"token\":\"(.*?)\"");
											text8 = "useVerifyAntiScriptingCaptchaCodeMutation";
											text7 = text6 + "fb_api_req_friendly_name=" + text8 + "&variables=%7B%22input%22%3A%7B%22client_mutation_id%22%3A%224%22%2C%22actor_id%22%3A%22" + A723BA98 + "%22%2C%22captcha_persisted_data%22%3A%22" + text21 + "%22%2C%22code%22%3A%22" + text20 + "%22%2C%22token%22%3A%7B%22sensitive_string_value%22%3A%22" + text10 + "%22%7D%7D%2C%22scale%22%3A1%7D&server_timestamps=true&doc_id=8931784676832161";
											text2 = f3958F9B_0.B51DA5A0("https://www.facebook.com/api/graphql/", text7, "application/x-www-form-urlencoded", new string[2]
											{
												"x-fb-friendly-name: " + text8,
												"x-fb-lsd: " + text4
											});
											if (text2.Contains("\"errors\""))
											{
												goto IL_00d5;
											}
											goto IL_1400;
										}
										item = "Unlock 956 Fail (Captcha)";
										break;
									}
									item = "Unlock 956 Fail (Bypass captcha fail)";
									break;
								}
							}
							else
							{
								if (num4 <= 3198980747u)
								{
									if (num4 != 3141059881u)
									{
										if (num4 != 3198980747u || !(text15 == "EpsilonContactPointReview"))
										{
											goto IL_103d;
										}
										smethod_11(int_0, A7932585 + "Review contact...");
										string text22 = "";
										string text23 = "";
										if (GClass25.smethod_0("configCheckpoint").method_3("ckbDeleteContact"))
										{
											foreach (JToken item5 in (IEnumerable<JToken>)(jObject["data"]!["epsilon_navigate"]!["epsilon_checkpoint"]!["screen"]!["contact_points"]!))
											{
												if (item5["label"]!.ToString() != B12D5A3C.ToLower())
												{
													text22 += string.Format("\"{0}\",", item5["label"]);
													text23 += string.Format("\"{0}\",", item5["id"]);
												}
											}
											if (text22 != "")
											{
												text22 = text22.TrimEnd(',');
											}
											if (text23 != "")
											{
												text23 = text23.TrimEnd(',');
											}
										}
										text10 = GClass8.smethod_96(text2, "\"token\":\"(.*?)\"");
										text8 = "useRemoveContactPointsMutation";
										text7 = text6 + "fb_api_req_friendly_name=" + text8 + "&variables=%7B%22input%22%3A%7B%22client_mutation_id%22%3A%223%22%2C%22actor_id%22%3A%22" + A723BA98 + "%22%2C%22cps_to_remove%22%3A%5B" + text22 + "%5D%2C%22ids_to_remove%22%3A%5B" + text23 + "%5D%2C%22token%22%3A%7B%22sensitive_string_value%22%3A%22" + text10 + "%22%7D%7D%2C%22scale%22%3A1%7D&server_timestamps=true&doc_id=8880988131920703";
										text2 = f3958F9B_0.B51DA5A0("https://www.facebook.com/api/graphql/", text7, "application/x-www-form-urlencoded", new string[2]
										{
											"x-fb-friendly-name: " + text8,
											"x-fb-lsd: " + text4
										});
									}
									else
									{
										if (!(text15 == "EpsilonMessageCodeCaptcha"))
										{
											goto IL_103d;
										}
										smethod_11(int_0, A7932585 + "Select email...");
										List<string> list3 = new List<string>();
										foreach (JToken item6 in (IEnumerable<JToken>)(jObject["data"]!["epsilon_navigate"]!["epsilon_checkpoint"]!["screen"]!["eligible_contact_points"]!))
										{
											if (item6["medium"]!.ToString().ToLower() == "email")
											{
												list3.Add(item6["contact_point"]!.ToString().ToLower());
											}
										}
										string string_2 = B12D5A3C.Substring(B12D5A3C.IndexOf('@') - 1, 3);
										text11 = list3.Where((string string_1) => string_1.Contains(string_2)).FirstOrDefault();
										if (text11 == null)
										{
											item = "Unlock 956 Fail (" + F7AB102E.smethod_0("Fb bắt xác minh email không có trên tool") + ")";
											break;
										}
										text = Class98.A1A49D95(1, B12D5A3C, string_0, B0A94F96, 0, A723BA98, "");
										if (text == "fail")
										{
											item = "Unlock 956 Fail (" + F7AB102E.smethod_0("Không thể kết nối mail!") + ")";
											break;
										}
										text10 = GClass8.smethod_96(text2, "\"token\":\"(.*?)\"");
										text8 = "CometIXTFacebookXfacUniversalTriggerRootQuery";
										text7 = text6 + "fb_api_req_friendly_name=" + text8 + "&variables=%7B%22input%22%3A%7B%22client_token%22%3A%22" + text10 + "%22%2C%22trigger_event_type%22%3A%22XFAC_UNIVERSAL_ENTRY%22%2C%22xfac_appeal_type%22%3A%22CHECKPOINT_EPSILON%22%2C%22xfac_config%22%3A%22XFAC_EPSILON_EMAIL_OTP%22%2C%22nt_context%22%3Anull%2C%22trigger_session_id%22%3A%226b1db461-5391-4c8a-a0b8-63d303e4ef95%22%7D%2C%22scale%22%3A3%7D&server_timestamps=true&doc_id=7916320065138329";
										text2 = f3958F9B_0.B51DA5A0("https://www.facebook.com/api/graphql/", text7, "application/x-www-form-urlencoded", new string[2]
										{
											"x-fb-friendly-name: " + text8,
											"x-fb-lsd: " + text4
										});
										if (text2.Contains("\"errors\""))
										{
											text8 = "useSendCaptchaCodeMutation";
											text7 = text6 + "fb_api_req_friendly_name=" + text8 + "&variables=%7B%22input%22%3A%7B%22client_mutation_id%22%3A%224%22%2C%22actor_id%22%3A%22" + A723BA98 + "%22%2C%22contact_point%22%3A%22" + text11 + "%22%2C%22index%22%3A0%2C%22medium%22%3A%22EMAIL%22%2C%22token%22%3A%7B%22sensitive_string_value%22%3A%22" + text10 + "%22%7D%7D%2C%22scale%22%3A1%7D&server_timestamps=true&doc_id=8453582888028888";
											text2 = f3958F9B_0.B51DA5A0("https://www.facebook.com/api/graphql/", text7, "application/x-www-form-urlencoded", new string[2]
											{
												"x-fb-friendly-name: " + text8,
												"x-fb-lsd: " + text4
											});
										}
									}
									goto IL_1400;
								}
								if (num4 != 3318294281u)
								{
									if (num4 == 3760394666u && text15 == "EpsilonStepperScreen")
									{
										smethod_11(int_0, A7932585 + "Click next...");
										text10 = GClass8.smethod_96(text2, "\"token\":\"(.*?)\"");
										text9 = GClass8.smethod_96(text2, "\"next_screen\":\"(.*?)\"");
										text8 = "useEpsilonNavigateMutation";
										text7 = text6 + "fb_api_req_friendly_name=" + text8 + "&variables=%7B%22input%22%3A%7B%22client_mutation_id%22%3A%221%22%2C%22actor_id%22%3A%22" + A723BA98 + "%22%2C%22step%22%3A%22" + text9 + "%22%2C%22token%22%3A%7B%22sensitive_string_value%22%3A%22" + text10 + "%22%7D%7D%2C%22scale%22%3A3%7D&server_timestamps=true&doc_id=";
										text7 = ((!(text9 == "PROFILE_REVIEW")) ? (text7 + "9385152714844566") : (text7 + "8466618156761750"));
										text2 = f3958F9B_0.B51DA5A0("https://www.facebook.com/api/graphql/", text7, "application/x-www-form-urlencoded", new string[2]
										{
											"x-fb-friendly-name: " + text8,
											"x-fb-lsd: " + text4
										});
										goto IL_1400;
									}
								}
								else if (text15 == "IXTAuthenticityWizardContactPointConfirmationScreenViewModel")
								{
									goto IL_10ec;
								}
							}
							goto IL_103d;
							IL_10ec:
							num++;
							if (num < num2)
							{
								smethod_11(int_0, A7932585 + "Get otp...");
								string text24 = Class98.A1A49D95(1, B12D5A3C, string_0, B0A94F96, 60, A723BA98, text);
								if (!(text24 == "fail"))
								{
									if (text24 == "")
									{
										text8 = "useSendCaptchaCodeMutation";
										text7 = text6 + "fb_api_req_friendly_name=" + text8 + "&variables=%7B%22input%22%3A%7B%22client_mutation_id%22%3A%224%22%2C%22actor_id%22%3A%22" + A723BA98 + "%22%2C%22contact_point%22%3A%22" + text11 + "%22%2C%22index%22%3A0%2C%22medium%22%3A%22EMAIL%22%2C%22token%22%3A%7B%22sensitive_string_value%22%3A%22" + text10 + "%22%7D%7D%2C%22scale%22%3A1%7D&server_timestamps=true&doc_id=8453582888028888";
										text2 = f3958F9B_0.B51DA5A0("https://www.facebook.com/api/graphql/", text7, "application/x-www-form-urlencoded", new string[2]
										{
											"x-fb-friendly-name: " + text8,
											"x-fb-lsd: " + text4
										});
									}
									else
									{
										text = text24;
										smethod_11(int_0, A7932585 + "Submit otp...");
										if (text13 == "EpsilonEnterMessageCodeCaptcha")
										{
											text10 = GClass8.smethod_96(text2, "\"token\":\"(.*?)\"");
											text8 = "useVerifyCaptchaCodeMutation";
											text7 = text6 + "fb_api_req_friendly_name=" + text8 + "&variables=%7B%22input%22%3A%7B%22client_mutation_id%22%3A%225%22%2C%22actor_id%22%3A%22" + A723BA98 + "%22%2C%22code%22%3A%22" + text24 + "%22%2C%22medium%22%3A%22EMAIL%22%2C%22token%22%3A%7B%22sensitive_string_value%22%3A%22" + text10 + "%22%7D%7D%2C%22scale%22%3A1%7D&server_timestamps=true&doc_id=7309059885884471";
											text2 = f3958F9B_0.B51DA5A0("https://www.facebook.com/api/graphql/", text7, "application/x-www-form-urlencoded", new string[2]
											{
												"x-fb-friendly-name: " + text8,
												"x-fb-lsd: " + text4
											});
											if (text2.Contains("\"errors\""))
											{
												text8 = "useSendCaptchaCodeMutation";
												text7 = text6 + "fb_api_req_friendly_name=" + text8 + "&variables=%7B%22input%22%3A%7B%22client_mutation_id%22%3A%224%22%2C%22actor_id%22%3A%22" + A723BA98 + "%22%2C%22contact_point%22%3A%22" + text11 + "%22%2C%22index%22%3A0%2C%22medium%22%3A%22EMAIL%22%2C%22token%22%3A%7B%22sensitive_string_value%22%3A%22" + text10 + "%22%7D%7D%2C%22scale%22%3A1%7D&server_timestamps=true&doc_id=8453582888028888";
												text2 = f3958F9B_0.B51DA5A0("https://www.facebook.com/api/graphql/", text7, "application/x-www-form-urlencoded", new string[2]
												{
													"x-fb-friendly-name: " + text8,
													"x-fb-lsd: " + text4
												});
											}
										}
										else
										{
											text12 = jObject["data"]!["ixt_screen_next"]!["view_model"]!["serialized_state"]!.ToString();
											text8 = "CometFacebookWithLoggedOutIXTNextMutation";
											text7 = text6 + "fb_api_req_friendly_name=" + text8 + "&variables=%7B%22input%22%3A%7B%22authenticity_wizard_contact_point_confirmation%22%3A%7B%22confirmation_code%22%3A%22" + text24 + "%22%2C%22serialized_state%22%3A%22" + text12 + "%22%7D%2C%22actor_id%22%3A%22" + A723BA98 + "%22%2C%22client_mutation_id%22%3A%222%22%7D%2C%22scale%22%3A3%7D&server_timestamps=true&doc_id=8760610473984639";
											text2 = f3958F9B_0.B51DA5A0("https://www.facebook.com/api/graphql/", text7, "application/x-www-form-urlencoded", new string[2]
											{
												"x-fb-friendly-name: " + text8,
												"x-fb-lsd: " + text4
											});
										}
									}
									goto IL_1400;
								}
								item = "Unlock 956 Fail (" + F7AB102E.smethod_0("Không thể kết nối mail!") + ")";
								break;
							}
							item = "Unlock 956 Fail (Không lấy được otp)";
							break;
							IL_103d:
							if (!text2.Contains("571927962827151"))
							{
								if (!text2.Contains("1501092823525282"))
								{
									if (!text2.Contains("m_login_email"))
									{
										if (text2.Contains("601051028565049"))
										{
											smethod_11(int_0, A7932585 + "Click dismiss...");
											text8 = "FBScrapingWarningMutation";
											text7 = text6 + "fb_api_req_friendly_name=" + text8 + "&variables=%7B%7D&server_timestamps=true&doc_id=6339492849481770";
											text2 = f3958F9B_0.B51DA5A0("https://www.facebook.com/api/graphql/", text7, "application/x-www-form-urlencoded", new string[2]
											{
												"x-fb-friendly-name: " + text8,
												"x-fb-lsd: " + text4
											});
											goto IL_1400;
										}
										text2 = f3958F9B_0.method_0("https://www.facebook.com/");
										text3 = f3958F9B_0.method_4();
										if (text3.Contains("1501092823525282"))
										{
											item2 = (item = "Checkpoint: 282");
										}
										else if (!text3.Contains("facebook.com/gettingstarted") && (!text2.Contains("href=\"/menu/bookmarks/") || !text2.Contains("id=\"mbasic_logout_button\"")) && (!text2.Contains("id=\"MComposer\"") || !text2.Contains("id=\"MBackNavBar\"")) && !text2.Contains("\"is_checkpointed\":false"))
										{
											item = "Unlock 956 Fail (Please try again 3)";
										}
										else
										{
											flag = true;
										}
										break;
									}
									item = "Unlock 956 Fail (1)";
									break;
								}
								item2 = (item = "Checkpoint: 282");
								break;
							}
							item = "Unlock 956 Fail (Spam)";
							break;
							IL_1400:
							if (Environment.TickCount - tickCount < 600000)
							{
								GClass8.smethod_53(1.0);
								continue;
							}
							item = "Unlock 956 Fail (Timeout)";
							break;
						}
					}
					else
					{
						item = "Unlock 956 Fail (Please try again 2)";
					}
					break;
				}
			}
		}
		catch (Exception ex2)
		{
			F9AF1B3C(ex2.ToString(), A723BA98);
			item = "Unlock 956 Fail (Please try again)";
		}
		if (flag)
		{
			item2 = "Live";
			item = "Unlock checkpoint success";
		}
		return (item, item2, item3);
	}

	public static void F9AF1B3C(string F33612B6, string string_0)
	{
		string path = "log\\unlock956.txt";
		lock (BD8F7E03)
		{
			try
			{
				File.AppendAllText(path, "------------------ " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\r\n");
				if (string_0 != "")
				{
					File.AppendAllText(path, "Uid: " + string_0 + "\r\n");
				}
				File.AppendAllText(path, F33612B6 + "\r\n");
			}
			catch (Exception)
			{
			}
		}
	}

	public static GClass11 E48B5826(string string_0, string string_1, string string_2, string string_3, string BBA37503, int B68E4290)
	{
		GClass11 gClass = new GClass11();
		gClass.method_4("success", false);
		gClass.method_4("error", "");
		F3958F9B f3958F9B = new F3958F9B("", "", BBA37503, B68E4290);
		string text = "";
		f3958F9B.method_0("https://www.facebook.com/");
		text = f3958F9B.method_0("https://www.facebook.com/login/?next=https%3A%2F%2Fwww.facebook.com%2F");
		string value = Regex.Match(text, "\"LSD\",\\[\\],{\"token\":\"(.*?)\"}").Groups[1].Value;
		string bFA79D3C = "jazoest=2111&lsd=" + value + "&email=" + string_0 + "&login_source=comet_headerless_login&next=&encpass=%23PWD_BROWSER%3A0%3A" + Convert.ToInt32(GClass8.AE08EC26(DateTime.Now)) + "%3A" + string_1;
		f3958F9B.httpRequest_0.AddHeader("x-fb-lsd", value);
		text = f3958F9B.A6321D97("https://www.facebook.com/login/?privacy_mutation_token=", bFA79D3C);
		int num = 3;
		int num2 = 3;
		bool flag = false;
		for (int i = 0; i < 20; i++)
		{
			string value2 = Regex.Match(text, "name=\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
			string value3 = Regex.Match(text, "name=\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
			string value4 = Regex.Match(text, "name=\"nh\" value=\"(.*?)\"").Groups[1].Value;
			if (text.Contains("approvals_code"))
			{
				num2--;
				if (num2 < 0)
				{
					gClass.method_4("error", "Sai 2fa");
					break;
				}
				string text2 = GClass8.smethod_66(string_2);
				bFA79D3C = "jazoest=" + value3 + "&fb_dtsg=" + value2 + "&nh=" + value4 + "&no_fido=true&approvals_code=" + text2 + "&submit%5BContinue%5D=Continue";
			}
			else if (text.Contains("save_device"))
			{
				bFA79D3C = "jazoest=" + value3 + "&fb_dtsg=" + value2 + "&nh=" + value4 + "&name_action_selected=save_device&submit%5BContinue%5D=Continue";
			}
			else if (text.Contains("submit[Continue]"))
			{
				bFA79D3C = "jazoest=" + value3 + "&fb_dtsg=" + value2 + "&nh=" + value4 + "&submit%5BContinue%5D=Continue";
			}
			else if (text.Contains("submit[This was me]"))
			{
				bFA79D3C = "jazoest=" + value3 + "&fb_dtsg=" + value2 + "&nh=" + value4 + "&submit%5BThis+wasn%27t+me%5D=This+wasn%27t+me";
			}
			else if (text.Contains("password_new"))
			{
				gClass.method_4("newPass", string_3);
				bFA79D3C = "jazoest=" + value3 + "&fb_dtsg=" + value2 + "&nh=" + value4 + "&password_new=" + string_3 + "&password_confirm=" + string_3 + "&submit%5BChange+Password%5D=Change+Password";
			}
			else
			{
				if (text.Contains("/login/identify/"))
				{
					gClass.method_4("error", "Sai user");
					break;
				}
				if (text.Contains("not_me_link") || text.Contains("/recover/initiate/"))
				{
					gClass.method_4("error", "Sai pass");
					break;
				}
				Match match = Regex.Match(text, "CurrentUserInitialData\",\\[\\],{\"ACCOUNT_ID\":\"(\\d+)\",\"USER_ID\":\"(\\d+)\",\"NAME\":\"(.*?)\"");
				if (match.Success && match.Groups[1].Value == match.Groups[2].Value && match.Groups[3].Value != "")
				{
					gClass.method_4("success", true);
					break;
				}
				num--;
				if (num < 0)
				{
					if (!flag)
					{
						flag = true;
						f3958F9B = new F3958F9B();
						text = f3958F9B.method_0("https://www.facebook.com/");
						string value5 = Regex.Match(text, "privacy_mutation_token=(.*?)\"").Groups[1].Value;
						if (value5 != "")
						{
							f3958F9B = new F3958F9B(f3958F9B.method_3(), "", BBA37503, B68E4290);
							value = Regex.Match(text, "\"LSD\",\\[\\],{\"token\":\"(.*?)\"}").Groups[1].Value;
							bFA79D3C = "jazoest=2111&lsd=" + value + "&email=" + string_0 + "&login_source=comet_headerless_login&next=&encpass=%23PWD_BROWSER%3A0%3A" + Convert.ToInt32(GClass8.AE08EC26(DateTime.Now)) + "%3A" + string_1;
							f3958F9B.httpRequest_0.AddHeader("x-fb-lsd", value);
							text = f3958F9B.A6321D97("https://www.facebook.com/login/?privacy_mutation_token=" + value5, bFA79D3C);
							continue;
						}
					}
					gClass.method_4("error", "try_again");
					break;
				}
			}
			text = f3958F9B.A6321D97("https://www.facebook.com/checkpoint/?next", bFA79D3C);
		}
		if (gClass.method_3("success") && gClass.C0288288("newPass") == "")
		{
			gClass.method_4("success", false);
			gClass.method_4("error", "Không co\u0301 tu\u0300y cho\u0323n đô\u0309i pass");
		}
		return gClass;
	}

	internal static string smethod_12(string string_0, string string_1, string string_2, int AB3A71A1, string AB9BD481)
	{
		string result = "";
		try
		{
			string json = GClass8.smethod_88($"GetPageProfile2('{string_0}','{string_1}','{string_2}',{AB3A71A1}, '{AB9BD481}')");
			JArray jArray = JArray.Parse(json);
			result = jArray[0]["uid"]!.ToString() + "|" + jArray[0]["token"]!.ToString();
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static int C0AF38BF(string CE07A691)
	{
		int result = 0;
		if (!CE07A691.StartsWith("https://www.facebook") && !CE07A691.StartsWith("https://facebook") && !CE07A691.StartsWith("https://web.facebook"))
		{
			if (!CE07A691.StartsWith("https://m.facebook") && !CE07A691.StartsWith("https://mobile.facebook"))
			{
				if (CE07A691.StartsWith("https://mbasic.facebook") || CE07A691.StartsWith("https://d.facebook"))
				{
					result = 3;
				}
			}
			else
			{
				result = 2;
			}
		}
		else
		{
			result = 1;
		}
		return result;
	}

	internal static string A63995B8(string string_0, string E2384832, int int_0)
	{
		try
		{
			string text = "https://www.facebook.com";
			F3958F9B f3958F9B = new F3958F9B("", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.5359.71 Safari/537.36", E2384832, int_0);
			string input = f3958F9B.method_0(text + "/login/identify/?ctx=recover&from_login_screen=0");
			string value = Regex.Match(input, "name=\"lsd\" value=\"(.*?)\"").Groups[1].Value;
			if (value == "")
			{
				text = "https://web.facebook.com";
				input = f3958F9B.method_0(text + "/login/identify/?ctx=recover&from_login_screen=0");
				value = Regex.Match(input, "name=\"lsd\" value=\"(.*?)\"").Groups[1].Value;
			}
			if (value == "")
			{
				return F7AB102E.smethod_0("Gư\u0309i yêu câ\u0300u thâ\u0301t ba\u0323i!");
			}
			string string_ = text + "/ajax/login/help/identify.php?ctx=recover";
			string bFA79D3C = "jazoest=2111&lsd=" + value + "&email=" + string_0 + "&did_submit=1&__user=0&__a=1&__dyn=&__csr=&__req=8&__hs=&dpr=1&__ccg=EXCELLENT&__rev=&__s=&__hsi=&__comet_req=0&__spin_r=&__spin_b=trunk&__spin_t=";
			f3958F9B.httpRequest_0.AddHeader("x-fb-lsd", value);
			input = f3958F9B.A6321D97(string_, bFA79D3C);
			if (input.Contains("571927962827151"))
			{
				return F7AB102E.smethod_0("Chặn tính năng!");
			}
			string value2 = Regex.Match(input, "ldata=(.*?)\"").Groups[1].Value;
			if (value2 == "")
			{
				return F7AB102E.smethod_0("Gư\u0309i yêu câ\u0300u thâ\u0301t ba\u0323i!");
			}
			input = f3958F9B.method_0(text + "/recover/initiate/?ldata=" + value2);
			input = f3958F9B.method_0(text + "/login/web/?email=" + GClass8.FBA19A19(string_0) + "&is_from_lara=1");
			value = Regex.Match(input, "name=\"lsd\" value=\"(.*?)\"").Groups[1].Value;
			if (value == "")
			{
				return F7AB102E.smethod_0("Gư\u0309i yêu câ\u0300u thâ\u0301t ba\u0323i!");
			}
			f3958F9B.httpRequest_0.AddHeader("x-fb-lsd", value);
			input = f3958F9B.A6321D97(text + "/ajax/recover/initiate/?lara=0", "jazoest=2111&lsd=" + value + "&openid_provider_id=&openid_provider_name=&recover_method=send_email&reset_action=1&__user=0&__a=1&__dyn=&__csr=&__req=8&__hs=&dpr=1&__ccg=EXCELLENT&__rev=&__s=&__hsi=&__comet_req=0&__spin_r=&__spin_b=trunk&__spin_t=");
			string_ = Regex.Match(input, "redirectPageTo\",\\[\\],\\[\"(.*?)\"").Groups[1].Value;
			if (string_ == "")
			{
				try
				{
					string text2 = JObject.Parse(input.Replace("for (;;);", ""))["errorSummary"]!.ToString();
					if (text2 != "")
					{
						return text2;
					}
				}
				catch (Exception)
				{
				}
				return F7AB102E.smethod_0("Gư\u0309i yêu câ\u0300u thâ\u0301t ba\u0323i!");
			}
			string_ = JObject.Parse("{\"data\":\"" + string_ + "\"}")["data"]!.ToString();
			input = f3958F9B.method_0(string_);
			if (input.Contains(GClass8.FBA19A19(string_0)))
			{
				return "true";
			}
		}
		catch (Exception)
		{
		}
		return F7AB102E.smethod_0("Lô\u0303i gửi yêu cầu!");
	}
}
