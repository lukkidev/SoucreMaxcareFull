using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

internal class Class54
{
	public string B787518D;

	public string AABEBA86;

	private string string_0;

	private string DEB3D6A0;

	private int int_0;

	public string string_1;

	public string string_2;

	public F3958F9B f3958F9B_0;

	public bool bool_0 = false;

	public string D01A7533 = "";

	public string string_3 = "";

	public string BDB0A18F = "";

	private int int_1 = 0;

	public Class54(string string_4, string string_5, string A11B4185, string EE12D111, int int_2, string string_6)
	{
		if (Regex.Match(string_5, "i_user=\\d+").Success)
		{
			string_5 = string_5.Replace(Regex.Match(string_5, "i_user=\\d+").Value, "");
		}
		B787518D = string_4;
		AABEBA86 = string_5;
		string_0 = A11B4185;
		DEB3D6A0 = EE12D111;
		int_0 = int_2;
		string_1 = string_6;
		f3958F9B_0 = new F3958F9B(string_5, A11B4185, EE12D111, int_2);
	}

	public bool method_0(bool bool_1)
	{
		bool_0 = bool_1;
		if (bool_1)
		{
			string text = Class14.smethod_12(AABEBA86, "", DEB3D6A0, int_0, string_1);
			if (text == "")
			{
				return false;
			}
			D01A7533 = text.Split('|')[0];
			string_3 = text.Split('|')[1];
			BDB0A18F = AABEBA86.TrimEnd(';') + ";i_user=" + D01A7533;
		}
		return true;
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr Like(byte[] AD226E05, byte[] byte_0, byte[] DD3AA6A0, byte[] DD970CBC, byte[] byte_1, byte[] byte_2);

	public string method_1(string string_4)
	{
		string text = (bool_0 ? BDB0A18F : AABEBA86);
		string text2 = (bool_0 ? string_3 : string_1);
		return GClass8.smethod_10(Like(GClass8.smethod_11(text), GClass8.smethod_11(string_0), GClass8.smethod_11(DEB3D6A0), GClass8.smethod_11(int_0.ToString()), GClass8.smethod_11(text2), GClass8.smethod_11(string_4)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr Comment(byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] E581DAA0, byte[] byte_3, byte[] byte_4, byte[] byte_5);

	public string EA8C2F30(string string_4, string string_5)
	{
		string text = (bool_0 ? BDB0A18F : AABEBA86);
		string text2 = (bool_0 ? string_3 : string_1);
		return GClass8.smethod_10(Comment(GClass8.smethod_11(text), GClass8.smethod_11(string_0), GClass8.smethod_11(DEB3D6A0), GClass8.smethod_11(int_0.ToString()), GClass8.smethod_11(text2), GClass8.smethod_11(string_4), GClass8.smethod_11(string_5)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr ShareWall(byte[] byte_0, byte[] E2BB2AAB, byte[] byte_1, byte[] F5AE403D, byte[] FB0B65A2, byte[] byte_2, byte[] byte_3);

	public string A41D6503(string string_4, string ED199098)
	{
		string text = (bool_0 ? BDB0A18F : AABEBA86);
		string text2 = (bool_0 ? string_3 : string_1);
		return GClass8.smethod_10(ShareWall(GClass8.smethod_11(text), GClass8.smethod_11(string_0), GClass8.smethod_11(DEB3D6A0), GClass8.smethod_11(int_0.ToString()), GClass8.smethod_11(text2), GClass8.smethod_11(string_4), GClass8.smethod_11(ED199098)));
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetFullPostId(byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] byte_3, byte[] byte_4, byte[] byte_5);

	public string FD01BD17(string string_4)
	{
		return GClass8.smethod_10(GetFullPostId(GClass8.smethod_11(AABEBA86), GClass8.smethod_11(string_0), GClass8.smethod_11(DEB3D6A0), GClass8.smethod_11(int_0.ToString()), GClass8.smethod_11(string_1), GClass8.smethod_11(string_4)));
	}

	public bool CE21BE8C(string string_4)
	{
		return false;
	}

	public bool method_2(string string_4)
	{
		return string_4.Contains("The user is enrolled in a blocking, logged-in checkpoint") || string_4.Contains("The session has been invalidated") || string_4.Contains("Sessions for the user are not allowed") || string_4.Contains("Malformed access token") || string_4.Contains("Error loading application") || string_4.Contains("This Page access token belongs to a Page that is not accessible") || string_4.Contains("Invalid OAuth access token - Cannot parse access token");
	}

	public bool method_3(string string_4)
	{
		return string_4.Contains("Service temporarily unavailable") || string_4.Contains("User cannot subscribe to this profile") || string_4.Contains("does not exist") || string_4.Contains("The url you supplied is invalid") || string_4.Contains("Cannot access object_id") || string_4.Contains("\"code\":1446034,") || string_4.Contains("\"code\":1357006,") || string_4.Contains("Error finding the requested comment") || string_4.Contains("nonexisting field");
	}

	public bool method_4(string string_4)
	{
		return string_4.Contains("temporarily restricted") || string_4.Contains("The action attempted has been deemed abusive or is otherwise disallowed") || string_4.Contains("sentry_block_data");
	}

	private string method_5(string string_4)
	{
		string result = "";
		if (method_3(string_4))
		{
			result = "job_die";
		}
		else if (method_4(string_4))
		{
			result = "fb_blocked";
		}
		else if (!string_4.Contains("You cannot access the app till you log in to www.facebook.com and follow the instructions given") && !string_4.Contains("601051028565049"))
		{
			if (method_2(string_4))
			{
				result = "token_die";
				string_1 = "";
			}
			else if (string_4.Contains("singular statuses API is deprecated for versions v2.4 and higher"))
			{
				result = "skip";
			}
		}
		else
		{
			if (B3A08A1A())
			{
				return "again";
			}
			result = "token_die";
			string_1 = "";
		}
		return result;
	}

	public bool B3A08A1A()
	{
		if (string.IsNullOrEmpty(string_2))
		{
			string_2 = GClass8.smethod_8(AABEBA86, string_0, DEB3D6A0, int_0);
		}
		string text = "av=" + B787518D + "&__user=" + B787518D + "&__a=1&__req=7&__hs=20015.HYP%3Acomet_pkg.2.1..2.1&dpr=3&__ccg=EXCELLENT&__rev=1017496172&__s=pljtfv%3Aznp1jt%3Apkw3sx&__hsi=7427386731673553225&__dyn=7xeXxa1mxu1syaxG4Vp41twWwIxu13w8CewSwAyUco2qwJyE2OwpUe8hwaG0Z82_CwjE1xoswMwto2awgo9oO0n24oaEd82lwv89k2C1Fwc60D8vwRwlE-U2exi4UaEW0Loco4i5o2eUlwhE2Lx-0luVEbUGdG1Jw9h08O321Lwqo5B0bK1Iwqo2swEwkFU-4EdrwsUbUaU3yw&__csr=hJEJaIggyTtZ5RZlhdL8J9bviP5h6nkNpkhp2tltppFl-AaBykJprVbCghKjAgS8KcppWyECqq5pqDKQWVomwVxG3K4E5S0LUdpodEaHwpo5u0h-0A9U-09swqo4-m0PE1do0Rh1q3F0UUhw9m0d6w14K0tu03bC06q-00hl208Nw0Nzw4ZwwwjU0Ci1exe5WoK06So0De0709orx2ECp2otCga805vSew38o08NGa3e2Je9m&__comet_req=15&fb_dtsg=" + string_2 + "&jazoest=25772&lsd=&__spin_r=1017496172&__spin_b=trunk&__spin_t=1729323233&fb_api_caller_class=RelayModern&";
		string text2 = "FBScrapingWarningMutation";
		string d510F3A = text + "fb_api_req_friendly_name=" + text2 + "&variables=%7B%7D&server_timestamps=true&doc_id=6339492849481770";
		string text3 = f3958F9B_0.B51DA5A0("https://www.facebook.com/api/graphql/", d510F3A, "application/x-www-form-urlencoded", new string[1] { "x-fb-friendly-name: " + text2 });
		return text3.Contains("\"success\":true");
	}

	private string D50BA68A(string B419EF03)
	{
		string result = "";
		if (!(B419EF03 == "acc_noveri") && !(B419EF03 == "cookie_not_login"))
		{
			if (method_3(B419EF03))
			{
				result = "job_die";
			}
			else if (method_4(B419EF03))
			{
				result = "fb_blocked";
			}
			else if (!B419EF03.Contains("You cannot access the app till you log in to www.facebook.com and follow the instructions given") && !B419EF03.Contains("601051028565049"))
			{
				if (CE21BE8C(B419EF03))
				{
					result = "cookie_die";
					AABEBA86 = "";
				}
			}
			else
			{
				if (B3A08A1A())
				{
					return "again";
				}
				result = "cookie_die";
				AABEBA86 = "";
			}
		}
		else
		{
			result = "cookie_die";
			AABEBA86 = "";
		}
		return result;
	}

	public (bool isSuccess, string error, string rq) method_6(string D384E088, GClass11 gclass11_0, int CBBB2002, GClass3 gclass3_0)
	{
		string text = gclass11_0.C0288288("id");
		string text2 = gclass11_0.C0288288("content");
		bool flag = false;
		string text3 = "";
		string text4 = (bool_0 ? BDB0A18F : AABEBA86);
		string text5 = (bool_0 ? string_3 : string_1);
		string text6 = (bool_0 ? D01A7533 : B787518D);
		string text7 = "";
		string text8 = D384E088;
		string text9 = text8;
		uint num = C43AF739.smethod_0(text9);
		if (num <= 2483252068u)
		{
			if (num <= 1533824880)
			{
				if (num <= 725844792)
				{
					if (num != 199741238)
					{
						if (num != 585688324)
						{
							if (num == 725844792 && text9 == "likegiare")
							{
								goto IL_091d;
							}
						}
						else if (text9 == "wow")
						{
							goto IL_091d;
						}
					}
					else if (text9 == "like")
					{
						goto IL_091d;
					}
				}
				else if (num != 777061347)
				{
					if (num != 1041904999)
					{
						if (num == 1533824880 && text9 == "follow")
						{
							switch (CBBB2002)
							{
							case 0:
								text7 = GClass8.smethod_88($"FollowByToken('{text4}', '{string_0}', '{DEB3D6A0}', {int_0}, '{text5}', '{text}')");
								if (!(text7 == "true"))
								{
									text3 = method_5(text7);
								}
								break;
							case 1:
								text7 = GClass8.smethod_88($"Follow('{text4}', '{string_0}', '{DEB3D6A0}', {int_0}, '{string_2}', '{text}', 1)");
								text3 = D50BA68A(text7);
								break;
							}
						}
					}
					else if (text9 == "commentfb_test")
					{
						goto IL_0b78;
					}
				}
				else if (text9 == "like_page1")
				{
					goto IL_0815;
				}
			}
			else if (num <= 1918038936)
			{
				if (num != 1738982494)
				{
					if (num != 1776724361)
					{
						if (num == 1918038936 && text9 == "commentfb_full_avatar2")
						{
							goto IL_0b78;
						}
					}
					else if (text9 == "commentfb_livestream")
					{
						goto IL_0b78;
					}
				}
				else if (text9 == "comment")
				{
					goto IL_0b78;
				}
			}
			else if (num <= 2267502540u)
			{
				if (num != 2099285507)
				{
					if (num == 2267502540u && text9 == "care" && CBBB2002 == 1)
					{
						text7 = GClass8.smethod_88($"Reaction('{text4}', '{string_0}', '{DEB3D6A0}', {int_0}, '{text}', '{D384E088}', '{string_2}')");
						text3 = D50BA68A(text7);
					}
				}
				else if (text9 == "like_page_pageprofile")
				{
					goto IL_0815;
				}
			}
			else if (num != 2458671617u)
			{
				if (num == 2483252068u && text9 == "commentfb_via_female2")
				{
					goto IL_0b78;
				}
			}
			else if (text9 == "review_page")
			{
				goto IL_0737;
			}
		}
		else if (num <= 3777140709u)
		{
			if (num <= 3037376254u)
			{
				if (num != 2638291356u)
				{
					if (num != 2848586808u)
					{
						if (num == 3037376254u && text9 == "angry")
						{
							goto IL_091d;
						}
					}
					else if (text9 == "share")
					{
						goto IL_06a2;
					}
				}
				else if (text9 == "like_comment")
				{
					if (GClass8.smethod_42(text))
					{
						text3 = "job_die";
						text7 = "post id is uid";
					}
					else
					{
						switch (CBBB2002)
						{
						case 0:
							text7 = GClass8.smethod_88($"LikePostByToken('{text4}', '{string_0}', '{DEB3D6A0}', {int_0}, '{text5}', '{text}')");
							if (!(text7 == "true") && !text7.Contains("\"success\": true"))
							{
								text3 = method_5(text7);
							}
							else
							{
								flag = true;
							}
							break;
						case 1:
							text7 = GClass8.smethod_88($"Reaction('{text4}', '{string_0}', '{DEB3D6A0}', {int_0}, '{text}', 'like_comment', '{string_2}')");
							text3 = D50BA68A(text7);
							break;
						}
					}
				}
			}
			else if (num <= 3424911119u)
			{
				if (num != 3400491709u)
				{
					if (num == 3424911119u && text9 == "commentfb_via_male2")
					{
						goto IL_0b78;
					}
				}
				else if (text9 == "comment_campaign")
				{
					goto IL_0b78;
				}
			}
			else if (num != 3576140497u)
			{
				if (num == 3777140709u && text9 == "join_group")
				{
					switch (CBBB2002)
					{
					case 0:
						text7 = GClass8.smethod_88($"JoinGroupByToken('{text4}', '{string_0}', '{DEB3D6A0}', {int_0}, '{text5}', '{text}', '{text6}')");
						if (!(text7 == "true"))
						{
							text3 = method_5(text7);
						}
						break;
					case 1:
						text7 = GClass8.smethod_88($"JoinGroup('{text4}', '{string_0}', '{DEB3D6A0}', {int_0}, '{string_2}', '{text}', 1)");
						text3 = D50BA68A(text7);
						break;
					}
				}
			}
			else if (text9 == "love")
			{
				goto IL_091d;
			}
		}
		else if (num <= 3808982946u)
		{
			if (num != 3779005937u)
			{
				if (num != 3807508880u)
				{
					if (num == 3808982946u && text9 == "share_content")
					{
						goto IL_06a2;
					}
				}
				else if (text9 == "review_page1")
				{
					goto IL_0737;
				}
			}
			else if (text9 == "commentfb_via2")
			{
				goto IL_0b78;
			}
		}
		else if (num <= 3983124032u)
		{
			if (num != 3860638727u)
			{
				if (num == 3983124032u && text9 == "like_page")
				{
					goto IL_0815;
				}
			}
			else if (text9 == "sad")
			{
				goto IL_091d;
			}
		}
		else if (num != 4149829758u)
		{
			if (num == 4256463021u && text9 == "haha")
			{
				goto IL_091d;
			}
		}
		else if (text9 == "commentfb")
		{
			goto IL_0b78;
		}
		goto IL_0be6;
		IL_0737:
		if (CBBB2002 == 1)
		{
			text7 = GClass8.smethod_88(string.Format("ReviewPage('{0}', '{1}', '{2}', {3}, '{4}', '{5}', '{6}')", text4, string_0, DEB3D6A0, int_0, string_2, text, text2.Replace("\\", "\\\\\\\\").Replace("\"", "\\\\\"").Replace("'", "\\'")));
			text3 = D50BA68A(text7);
		}
		goto IL_0be6;
		IL_0815:
		switch (CBBB2002)
		{
		case 0:
			text7 = GClass8.smethod_88($"LikePageByToken('{text4}', '{string_0}', '{DEB3D6A0}', {int_0}, '{text5}', '{text}')");
			if (!(text7 == "true"))
			{
				text3 = method_5(text7);
			}
			break;
		case 1:
			text7 = GClass8.smethod_88($"LikePage('{text4}', '{string_0}', '{DEB3D6A0}', {int_0}, '{string_2}', '{text}', 1)");
			text3 = D50BA68A(text7);
			break;
		}
		goto IL_0be6;
		IL_091d:
		if (D384E088 == "likegiare")
		{
			D384E088 = "like";
		}
		switch (CBBB2002)
		{
		case 0:
		{
			string text10 = text;
			int num2 = 3;
			for (int i = 0; i < 2; i++)
			{
				text7 = ((!(D384E088 == "like")) ? GClass8.smethod_88($"ReactionByToken('{text4}', '{string_0}', '{DEB3D6A0}', {int_0}, '{text5}', '{text10}', '{D384E088}')") : GClass8.smethod_88($"LikePostByToken('{text4}', '{string_0}', '{DEB3D6A0}', {int_0}, '{text5}', '{text10}', '{D384E088}')"));
				if (!(text7 == "true") && !text7.Contains("\"success\": true,"))
				{
					if (text3.Contains("A connection attempt failed because the connected party did not properly respond after a period of time"))
					{
						num2--;
						if (num2 >= 0)
						{
							i--;
							continue;
						}
						text3 = "skip";
						break;
					}
					text3 = method_5(text7);
					if (text3 == "again")
					{
						num2--;
						if (num2 >= 0)
						{
							i--;
							continue;
						}
						text3 = "skip";
						break;
					}
					if (text3 != "")
					{
						if (text3 == "skip" && D384E088 == "like")
						{
							D384E088 = "LIKE";
							continue;
						}
						if (text3 != "job_die" || text10.Contains("_"))
						{
							break;
						}
					}
					text10 = FD01BD17(text10);
					if (!text10.Contains("_"))
					{
						break;
					}
					continue;
				}
				text7 = "true";
				break;
			}
			break;
		}
		case 1:
			text7 = GClass8.smethod_88($"Reaction('{text4}', '{string_0}', '{DEB3D6A0}', {int_0}, '{text}', '{D384E088}', '{string_2}')");
			text3 = D50BA68A(text7);
			break;
		}
		goto IL_0be6;
		IL_06a2:
		if (GClass8.smethod_42(text))
		{
			text3 = "job_die";
			text7 = "post id is uid";
		}
		else if (CBBB2002 == 0)
		{
			if (D384E088 == "share")
			{
				text2 = "";
			}
			if (!text.StartsWith("http"))
			{
				text = "https://www.facebook.com/" + text;
			}
			text7 = A41D6503(text, GClass8.FBA19A19(text2));
			if (text7.Contains("\"id\""))
			{
				flag = true;
			}
			else
			{
				text3 = method_5(text7);
			}
		}
		goto IL_0be6;
		IL_0b78:
		if (GClass8.smethod_42(text))
		{
			text3 = "job_die";
			text7 = "post id is uid";
		}
		else
		{
			switch (CBBB2002)
			{
			case 0:
				text7 = EA8C2F30(text, GClass8.FBA19A19(text2));
				if (text7.Contains("\"id\""))
				{
					flag = true;
				}
				else
				{
					text3 = method_5(text7);
				}
				break;
			case 2:
				(flag, text3, text7) = method_7(gclass3_0, text, text2);
				break;
			}
		}
		goto IL_0be6;
		IL_0be6:
		if (text7 == "true" || flag)
		{
			flag = true;
			return (true, text3, text7);
		}
		if (text3 != "")
		{
			return (flag, text3, text7);
		}
		switch (text7)
		{
		default:
			text3 = text7;
			break;
		case "cant_get_fb_dtsg":
			int_1++;
			if (int_1 > 3)
			{
				int_1 = 0;
				text3 = "token_die";
				string_1 = "";
			}
			break;
		case "cookie_not_login":
		case "checkpoint":
			text3 = "token_die";
			string_1 = "";
			AABEBA86 = "";
			break;
		}
		return (flag, text3, text7);
	}

	private (bool isSuccess, string error, string rq) method_7(GClass3 gclass3_0, string string_4, string string_5)
	{
		bool item = false;
		string item2 = "";
		string text = "";
		try
		{
			gclass3_0.method_52();
			JObject jObject;
			while (true)
			{
				gclass3_0.method_10("https://facebook.com/" + string_4);
				int num = gclass3_0.E433E10F();
				if (num != 1)
				{
					if (new List<int> { -3, -2, -1, 2 }.Contains(num))
					{
						return (false, "cookie_die", text);
					}
					string_5 = string_5.Replace("\r\n", "\n").Replace("\n", "\\\\n").Replace("\"", "\\\"");
					string string_6 = "[{\"name\":\"content\", \"value\":\"" + string_5 + "\", \"type\":\"text\"},{\"name\":\"indexPost\", \"value\":\"1\", \"type\":\"number\"}]";
					string string_7 = "CommentWWW";
					text = gclass3_0.E9B89BB8(string_7, string_6);
					jObject = JObject.Parse(text);
					if (Convert.ToBoolean(jObject["success"]) && jObject["commentId"]!.ToString() != "")
					{
						item = true;
						break;
					}
					if (!gclass3_0.DFA46D3A())
					{
						break;
					}
				}
			}
			if (jObject["error"]!.ToString() == "fb_blocked" || gclass3_0.method_94())
			{
				item2 = "fb_blocked";
			}
			if (jObject["error"]!.ToString().Contains("not_exist_"))
			{
				item2 = "job_die";
			}
		}
		catch (Exception)
		{
		}
		return (item, item2, text);
	}
}
