using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

public class GClass10
{
	public static void smethod_0(GClass3 gclass3_0, List<string> E48E8DA4)
	{
		List<string> list = new List<string>();
		int num = gclass3_0.E22B0917("textarea");
		string text = "";
		for (int i = 0; i < num; i++)
		{
			if (list.Count == 0)
			{
				list = GClass8.smethod_28(E48E8DA4);
			}
			text = list[Class57.random_0.Next(0, list.Count)];
			text = GClass8.smethod_29(text);
			list.Remove(text);
			gclass3_0.A403470E("textarea|" + i);
			gclass3_0.method_41(1, 2);
			gclass3_0.method_20("textarea|" + i, text);
			gclass3_0.method_41(1, 2);
		}
	}

	public static string C1981EA7(GClass3 gclass3_0)
	{
		string text = gclass3_0.BEA5E4BB("var x='';document.querySelectorAll('[property=\"og:title\"]').length>0&&(x=document.querySelector('[property=\"og:title\"]').getAttribute('content')),''==x&&document.querySelectorAll('[data-gt] a').length>0&&(x=document.querySelector('[data-gt] a').innerText),''==x&&document.querySelectorAll('.actor').length>0&&(x=document.querySelector('.actor').innerText), x+''; return x;").ToString();
		if (text == "")
		{
			text = gclass3_0.BEA5E4BB("return document.title").ToString().Split('-', '|')[0].Trim();
		}
		return text;
	}

	public static string smethod_1(GClass3 gclass3_0)
	{
		return gclass3_0.BEA5E4BB("var x='';document.querySelectorAll('.overflowText').length>0&&(x=document.querySelector('.overflowText').innerText), x+''; return x;").ToString();
	}

	public static int B02AE100(GClass3 B7B9D79F)
	{
		try
		{
			if (B7B9D79F == null)
			{
				return -1;
			}
			int tickCount = Environment.TickCount;
			int num = 30;
			do
			{
				if (!B7B9D79F.method_1())
				{
					string text = B7B9D79F.method_9();
					if (!text.StartsWith(B7B9D79F.method_25("https://mobile.facebook.com/home.php", text)) && !(text == B7B9D79F.method_25("https://mobile.facebook.com", text)))
					{
						if (!B7B9D79F.method_16("#feed_jewel a"))
						{
							B7B9D79F.method_10("https://mobile.facebook.com/home.php");
						}
						if (B7B9D79F.CD003D3F("#nux-nav-button,[href^=\"/a/nux/wizard/nav.php\"]"))
						{
							B7B9D79F.method_15("#nux-nav-button,[href^=\"/a/nux/wizard/nav.php\"]");
							if (B7B9D79F.CD003D3F("#qf_skip_dialog_skip_link", 5.0))
							{
								B7B9D79F.method_15("#qf_skip_dialog_skip_link");
							}
						}
						B7B9D79F.method_40(1.0);
						continue;
					}
					return 1;
				}
				return -2;
			}
			while (Environment.TickCount - tickCount < num * 1000);
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_2(GClass3 gclass3_0)
	{
		try
		{
			if (gclass3_0 != null)
			{
				if (gclass3_0.method_1())
				{
					return -2;
				}
				gclass3_0.method_10("https://mobile.facebook.com/watch/?ref=bookmarks");
				gclass3_0.method_63();
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_3(GClass3 gclass3_0)
	{
		gclass3_0.method_10("https://mobile.facebook.com/messages/?folder=unread&ref=bookmarks");
		return 1;
	}

	public static int smethod_4(GClass3 gclass3_0)
	{
		try
		{
			if (gclass3_0 != null)
			{
				gclass3_0.method_10("https://mobile.facebook.com/browse/birthdays/");
				gclass3_0.method_41(2, 5);
				return 1;
			}
		}
		catch
		{
		}
		return 0;
	}

	public static string smethod_5(GClass3 EBBF448E, string AFB92931, string D039D525 = "https://www.facebook.com")
	{
		try
		{
			EBBF448E.method_10(D039D525);
			EBBF448E.method_34(AFB92931);
			EBBF448E.method_11();
			return EBBF448E.method_131().ToString() ?? "";
		}
		catch
		{
		}
		return "0";
	}

	public static string smethod_6(GClass3 gclass3_0, string D3BA9E37)
	{
		string result = "";
		try
		{
			if (!gclass3_0.method_9().Contains("https://graph.facebook.com/"))
			{
				gclass3_0.method_10("https://graph.facebook.com/");
			}
			string json = gclass3_0.BEA5E4BB("async function RequestGet() { var output = ''; try { var response = await fetch('https://graph.facebook.com/me?fields=id,birthday,name&access_token=" + D3BA9E37 + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestGet(); return c;");
			JObject jObject = JObject.Parse(json);
			return jObject["id"]!.ToString() + "|" + jObject["birthday"]!.ToString() + "|" + jObject["name"]!.ToString();
		}
		catch
		{
		}
		return result;
	}

	public static List<string> D03857B4(GClass3 D535D13C)
	{
		List<string> list = new List<string>();
		try
		{
			if (!D535D13C.method_9().Contains("https://mbasic.facebook.com/"))
			{
				D535D13C.method_10("https://mbasic.facebook.com/");
			}
			string input = D535D13C.BEA5E4BB("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://mbasic.facebook.com/messages/'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
			int num = 1;
			string text = "";
			string text2 = "";
			do
			{
				MatchCollection matchCollection = Regex.Matches(input, "#fua\">(.*?)<");
				for (int i = 0; i < matchCollection.Count; i++)
				{
					try
					{
						text2 = matchCollection[i].Groups[1].Value.Replace("\"", "");
						text2 = WebUtility.HtmlDecode(text2);
						if (!list.Contains(text2))
						{
							list.Add(text2);
						}
					}
					catch
					{
					}
				}
				text = Regex.Match(input, "/messages/.pageNum=(.*?)\"").Value.Replace("amp;", "");
				input = D535D13C.BEA5E4BB("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://mbasic.facebook.com" + text + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
				num++;
			}
			while (num < 5 && text != "");
		}
		catch
		{
		}
		return list;
	}

	public static List<string> smethod_7(GClass3 F51F4C01, int FE8A0816)
	{
		List<string> list = new List<string>();
		try
		{
			if (!F51F4C01.method_9().Contains("https://mbasic.facebook.com/"))
			{
				F51F4C01.method_10("https://mbasic.facebook.com/");
			}
			string format = "https://mbasic.facebook.com/{0}/allactivity/?category_key=commentscluster&timestart={1}&timeend={2}";
			string text = F51F4C01.BEA5E4BB("return (document.cookie + ';').match(new RegExp('c_user=(.*?);'))[1]").ToString();
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = "";
			MatchCollection matchCollection = null;
			List<string> list2 = new List<string>();
			for (int i = 0; i < FE8A0816; i++)
			{
				DateTime dateTime = DateTime.Now.AddMonths(2 - i);
				DateTime dateTime2 = DateTime.Now.AddMonths(1 - i);
				text2 = GClass8.AE08EC26(new DateTime(dateTime.Year, dateTime.Month, 1)).ToString();
				text3 = GClass8.AE08EC26(new DateTime(dateTime2.Year, dateTime2.Month, 1)).ToString();
				text4 = string.Format(format, text, text2, text3);
				list2.Add(text4);
			}
			for (int j = 0; j < list2.Count; j++)
			{
				text4 = list2[j];
				bool flag = false;
				do
				{
					flag = false;
					text5 = F51F4C01.D129B30F(text4);
					text5 = WebUtility.HtmlDecode(text5);
					matchCollection = Regex.Matches(text5, "<span>(.*?)</h4>");
					for (int k = 0; k < matchCollection.Count; k++)
					{
						string value = matchCollection[k].Groups[1].Value;
						value = value.Substring(0, value.LastIndexOf('<'));
						MatchCollection matchCollection2 = Regex.Matches(value, "<(.*?)>");
						for (int l = 0; l < matchCollection2.Count; l++)
						{
							value = value.Replace(matchCollection2[l].Value, "");
						}
						if (value != "" && !list.Contains(value))
						{
							list.Add(value);
						}
					}
					if (Regex.IsMatch(text5, "/" + text + "/allactivity/\\?category_key=commentscluster&timeend(.*?)\""))
					{
						text4 = "https://mbasic.facebook.com" + Regex.Match(text5, "/" + text + "/allactivity/\\?category_key=commentscluster&timeend(.*?)\"").Value.Replace("\"", "");
						flag = true;
					}
				}
				while (flag);
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<string> smethod_8(GClass3 CE8084B2, string B58F1381, string string_0, string string_1, int FC12033A = 20)
	{
		List<string> list = new List<string>();
		try
		{
			if (!CE8084B2.method_9().Contains("https://graph.facebook.com/"))
			{
				CE8084B2.method_10("https://graph.facebook.com/");
			}
			string text = CE8084B2.BEA5E4BB("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://graph.facebook.com/" + B58F1381 + "/photos?fields=images&limit=" + FC12033A + "&access_token=" + string_1 + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
			JObject jObject = JObject.Parse(text);
			int num = 0;
			if (jObject != null && text.Contains("images"))
			{
				for (int i = 0; i < jObject["data"].Count(); i++)
				{
					num = jObject["data"]![i]!["images"].ToList().Count - 1;
					list.Add(B58F1381 + "*" + string_0 + "*" + jObject["data"]![i]!["images"]![num]!["source"]?.ToString() + "|" + jObject["data"]![i]!["images"]![num]!["width"]?.ToString() + "|" + jObject["data"]![i]!["images"]![num]!["height"]);
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<string> smethod_9(GClass3 F398CF34)
	{
		_ = F398CF34.CCBE39A8;
		List<string> result = new List<string>();
		try
		{
			string input = F398CF34.D129B30F("https://mbasic.facebook.com/pages/?viewallpywo=1");
			List<string> list = new List<string>();
			MatchCollection matchCollection = Regex.Matches(input, "page_suggestion_(\\d+)\"");
			foreach (Match item in matchCollection)
			{
				list.Add(item.Groups[1].Value);
			}
			List<string> list2 = new List<string>();
			matchCollection = Regex.Matches(input, "id=(\\d+)&");
			foreach (Match item2 in matchCollection)
			{
				list2.Add(item2.Groups[1].Value);
			}
			result = list.Except(list2).ToList();
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static List<string> D6B143AB(GClass3 gclass3_0, bool bool_0 = false)
	{
		List<string> list = new List<string>();
		try
		{
			string propertyName = gclass3_0.method_37();
			string text = gclass3_0.B8B3CA97();
			if (!gclass3_0.method_9().Contains("https://www.facebook.com/api/graphql"))
			{
				gclass3_0.method_10("https://www.facebook.com/api/graphql");
			}
			string json = gclass3_0.BEA5E4BB("async function RequestPost() { var output = ''; try { var response = await fetch('https://www.facebook.com/api/graphql', { method: 'POST', body: 'q=me(){friends}&fb_dtsg=" + text + "', headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestPost(); return c;");
			JObject jObject = JObject.Parse(json);
			int num = jObject[propertyName]!["friends"]!["nodes"].Count();
			for (int i = 0; i < num; i++)
			{
				try
				{
					string text2 = jObject[propertyName]!["friends"]!["nodes"]![i]!["name"]!.ToString();
					if (bool_0)
					{
						if (GClass8.smethod_68(text2))
						{
							list.Add(text2);
						}
					}
					else
					{
						list.Add(text2);
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
		if (list.Count == 0)
		{
			try
			{
				string text3 = gclass3_0.method_81();
				if (!gclass3_0.method_9().Contains("https://graph.facebook.com/"))
				{
					gclass3_0.method_10("https://graph.facebook.com/");
				}
				string json2 = gclass3_0.BEA5E4BB("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://graph.facebook.com/me/friends?limit=5000&fields=name&access_token=" + text3 + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
				JObject jObject2 = JObject.Parse(json2);
				for (int j = 0; j < jObject2["data"].Count(); j++)
				{
					try
					{
						string text4 = jObject2["data"]![j]!["name"]!.ToString();
						if (bool_0)
						{
							if (GClass8.smethod_68(text4))
							{
								list.Add(text4);
							}
						}
						else
						{
							list.Add(text4);
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
		}
		return list;
	}

	public static string smethod_10(GClass3 gclass3_0)
	{
		return "";
	}
}
