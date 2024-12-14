using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;

public class E31BC589
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A5803F38
	{
		public static readonly A5803F38 _003C_003E9 = new A5803F38();

		public static Func<string, bool> _003C_003E9__24_0;

		public static Func<string, bool> _003C_003E9__25_0;

		public static Func<string, string> _003C_003E9__25_1;

		public static Func<string, string> _003C_003E9__25_2;

		public static Func<string, string> _003C_003E9__25_3;

		public static Func<string, string> _003C_003E9__25_4;

		public static Func<string, string> _003C_003E9__25_5;

		public static Func<string, string> _003C_003E9__25_6;

		public static Func<string, string> _003C_003E9__25_7;

		public static Func<string, string> _003C_003E9__25_8;

		public static Func<string, string> _003C_003E9__25_9;

		public static Func<string, string> _003C_003E9__25_10;

		public static Func<string, string> _003C_003E9__25_11;

		public static Func<string, bool> _003C_003E9__25_12;

		public static Func<string, string> _003C_003E9__25_13;

		internal bool method_0(string string_0)
		{
			return string_0.EndsWith("_all");
		}

		internal bool method_1(string string_0)
		{
			return string_0 != "";
		}

		internal string D53A84AE(string string_0)
		{
			return string_0 += "_indo";
		}

		internal string AD9C1D99(string E0B9CDB3)
		{
			return E0B9CDB3 += "_thailand";
		}

		internal string method_2(string string_0)
		{
			return string_0 += "_thailand";
		}

		internal string D112B61A(string C5A6F9B6)
		{
			return C5A6F9B6 += "_thailand_via";
		}

		internal string method_3(string string_0)
		{
			return string_0 += "_philippines";
		}

		internal string A8959F9F(string C13FFF91)
		{
			return C13FFF91 += "_philippines";
		}

		internal string method_4(string FB93C421)
		{
			return FB93C421 += "_us";
		}

		internal string method_5(string string_0)
		{
			return string_0 += "_thailand";
		}

		internal string method_6(string string_0)
		{
			return string_0 += "_thailand";
		}

		internal string method_7(string string_0)
		{
			return string_0 += "_thailand_via";
		}

		internal string method_8(string string_0)
		{
			return string_0 += "_indo";
		}

		internal bool method_9(string A189209A)
		{
			return !A189209A.Contains("job_all");
		}

		internal string BD1EA8AD(string string_0)
		{
			return string_0 += "_all";
		}
	}

	private A6BA4B90 BA039CBC;

	public bool bool_0;

	public int int_0 = 0;

	public string E8173DA6 = "";

	public string string_0 = "";

	public string F2827A92 = "";

	public string string_1 = "";

	public string string_2 = "";

	public string string_3 = "";

	public string A72C7A28 = "";

	public string string_4 = "";

	public string E389669B = "";

	public int int_1 = 0;

	public bool bool_1 = false;

	private GClass3 gclass3_0 = null;

	private Class54 AEA0369A = null;

	public int int_2;

	public int int_3;

	public E31BC589(A6BA4B90 F50A0CB3, int int_4)
	{
		BA039CBC = F50A0CB3;
		int_0 = int_4;
		E8173DA6 = BA039CBC.method_60(int_4, "cId");
		string_0 = BA039CBC.method_60(int_4, "cUid");
		F2827A92 = BA039CBC.method_60(int_4, "cName");
		string_1 = BA039CBC.method_60(int_4, "cPassword");
		string_2 = BA039CBC.method_60(int_4, "cFa2");
		string_3 = BA039CBC.method_60(int_4, "cEmail");
		A72C7A28 = BA039CBC.method_60(int_4, "cCookies");
		bool_1 = BA039CBC.method_60(int_4, "cFbBlock") == "Yes";
		string string_ = BA039CBC.method_60(int_4, "cToken");
		if (Convert.ToInt32(BA039CBC.E9B4CF8B("cbbChangeIP")) == 1)
		{
			E389669B = BA039CBC.method_60(int_4, "cProxy");
			int_1 = (E389669B.EndsWith("*1") ? 1 : 0);
			if (E389669B.EndsWith("*0") || E389669B.EndsWith("*1"))
			{
				E389669B = E389669B.Substring(0, E389669B.Length - 2);
			}
		}
		if (F2827A92 == "")
		{
			F2827A92 = Class14.smethod_5(string_0, E389669B, int_1);
		}
		AEA0369A = new Class54(string_0, A72C7A28, string_4, E389669B, int_1, string_);
	}

	public void method_0(int int_4, string string_5, int B418352A = -1)
	{
		if (B418352A == -1)
		{
			BA039CBC.A1BF1713(int_4, string_5);
			return;
		}
		int tickCount = Environment.TickCount;
		while ((Environment.TickCount - tickCount) / 1000 - B418352A < 0 && !Class57.smethod_5())
		{
			BA039CBC.A1BF1713(int_4, string_5.Replace("{time}", (B418352A - (Environment.TickCount - tickCount) / 1000).ToString()));
			B98564A8(0.5);
		}
	}

	public int method_1()
	{
		try
		{
			string text = BA039CBC.method_60(int_0, "cJob").Trim();
			if (text == "")
			{
				return 0;
			}
			string text2 = DateTime.Now.ToString("dd/MM/yyyy").Replace(" ", "/");
			string text3 = Regex.Match(text, "\\((.*?)\\)").Groups[1].Value.Replace(" ", "/");
			if (text3 != text2)
			{
				return 0;
			}
			return Convert.ToInt32(text.Split(')')[1].Trim());
		}
		catch (Exception)
		{
		}
		return 0;
	}

	public void B91EDB96(int int_4)
	{
		int num = method_1();
		string eC2D049B = "(" + DateTime.Now.ToString("dd/MM/yyyy") + ") " + (int_4 + num);
		BA039CBC.F0A99AA5(int_0, "cJob", eC2D049B, "job");
	}

	private bool DD376799()
	{
		int num = Convert.ToInt32(BA039CBC.E9B4CF8B("nudMaxJobToday"));
		if (method_1() >= num)
		{
			BA039CBC.A1BF1713(int_0, "Max Job Today!");
			return true;
		}
		return false;
	}

	private void method_2(List<GClass19> list_0)
	{
		try
		{
			foreach (GClass19 item in list_0)
			{
				if (!item.FFBDE098)
				{
					item.ED286D22(bool_0: false, "skip");
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public void FB2B639E()
	{
		try
		{
			int num = 0;
			Class57.A39EDD1D(bool_9: false);
			List<GClass19> list = new List<GClass19>();
			string text = "";
			int num2 = Convert.ToInt32(BA039CBC.E9B4CF8B("typeRunBy"));
			if (Convert.ToBoolean(BA039CBC.E9B4CF8B("ckbCheckProxy")))
			{
				method_0(int_0, "Check proxy...");
				string text2 = GClass8.smethod_59(E389669B);
				if (text2 == "")
				{
					method_0(int_0, "Proxy die!");
					goto IL_0de7;
				}
			}
			if (Convert.ToBoolean(BA039CBC.E9B4CF8B("ckbCheckLiveUid")))
			{
				method_0(int_0, "Check wall...");
				if (GClass8.smethod_42(string_0) && Class14.EABAA59C(string_0, E389669B).Split('|')[0] != "1")
				{
					method_0(int_0, "Tài khoản Die!");
					BA039CBC.FD062316(int_0, "Die");
					goto IL_0de7;
				}
			}
			if (Class57.bool_0)
			{
				method_0(int_0, "Check job...");
				if (!GClass19.D622BE23(BA039CBC.E9B4CF8B("txtApiKey").ToString(), string_0, "", "", method_3(Convert.ToInt32(BA039CBC.E9B4CF8B("cbbServer"))), 2))
				{
					method_0(int_0, "Tạm thời hết job cho UID này");
					goto IL_0de7;
				}
			}
			string text3 = "";
			if (num2 == 0)
			{
				string value = "";
				switch (Convert.ToInt32(BA039CBC.E9B4CF8B("cbbTypeGetToken")))
				{
				case 0:
					value = "EAAG";
					break;
				case 1:
					value = "EAAAAU";
					break;
				case 2:
					value = "EAABs";
					break;
				}
				if (AEA0369A.string_1.StartsWith(value))
				{
					method_0(int_0, "Check token...");
					text3 = GClass8.smethod_88($"GetNameByToken('{AEA0369A.AABEBA86}','{string_4}','{E389669B}',{int_1}, '{AEA0369A.string_1}')");
					if (text3 == "")
					{
						AEA0369A.string_1 = "";
					}
				}
				if (!AEA0369A.string_1.StartsWith(value) && !method_9())
				{
					goto IL_0de7;
				}
			}
			else if (num2 == 1)
			{
				if (AEA0369A.AABEBA86 != "")
				{
					method_0(int_0, "Check cookie...");
					AEA0369A.string_2 = GClass8.smethod_8(AEA0369A.AABEBA86, string_4, E389669B, int_1);
					if (AEA0369A.string_2 == "")
					{
						AEA0369A.AABEBA86 = "";
					}
				}
				if (AEA0369A.AABEBA86 == "" && !method_8())
				{
					goto IL_0de7;
				}
			}
			else if (num2 == 2)
			{
				if (!method_7(int_0))
				{
					goto IL_0de7;
				}
				gclass3_0.method_52();
				gclass3_0.method_48();
			}
			if (text3 == "")
			{
				method_0(int_0, "Check name...");
				text3 = Class14.smethod_5(string_0, E389669B, int_1);
				if (text3 == "")
				{
					switch (num2)
					{
					case 0:
						break;
					case 1:
						text3 = GClass8.smethod_88($"GetNameByCookie('{AEA0369A.AABEBA86}','{string_4}','{E389669B}',{int_1})");
						goto IL_0506;
					default:
						goto IL_0506;
					}
					text3 = GClass8.smethod_88($"GetNameByToken('{AEA0369A.AABEBA86}','{string_4}','{E389669B}',{int_1}, '{AEA0369A.string_1}')");
					string text4 = text3.Split('|')[0];
					if (!(text4 != "") || !(text4 != string_0))
					{
						goto IL_0506;
					}
					BA039CBC.A1BF1713(int_0, F7AB102E.smethod_0("Uid không khơ\u0301p vơ\u0301i ta\u0300i khoa\u0309n!"));
					goto IL_0de7;
				}
			}
			goto IL_0535;
			IL_0de7:
			method_2(list);
			if (num2 == 2)
			{
				F932531E();
			}
			if (Class57.smethod_5())
			{
				BA039CBC.A1BF1713(int_0, "Đã dừng!");
			}
			BA039CBC.method_79(int_0);
			bool flag = false;
			if (!Convert.ToBoolean(BA039CBC.E9B4CF8B("ckbRepeatAll")))
			{
				flag = true;
			}
			else
			{
				string text5 = BA039CBC.C5151C09(int_0);
				if (text5 != "Live" && text5 != "unknow")
				{
					flag = true;
				}
				if (!flag)
				{
					string text6 = BA039CBC.E01F1137(int_0).ToLower();
					flag = text6.Contains("checkpoint") || text6.Contains("invalid username or password") || text6.Contains("fb block") || text6.Contains("Max Job Today".ToLower()) || text6.Contains("Token die".ToLower()) || text6.Contains("Không lấy được token!".ToLower()) || text6.Contains("Không ti\u0300m thâ\u0301y Cookie!".ToLower()) || text6.Contains(F7AB102E.smethod_0("Không ti\u0300m thâ\u0301y Cookie!").ToLower()) || text6.Contains("Không ti\u0300m thâ\u0301y Uid hoă\u0323c Pass!".ToLower()) || text6.Contains(F7AB102E.smethod_0("Không ti\u0300m thâ\u0301y Uid hoă\u0323c Pass!").ToLower()) || text6.Contains("Không lâ\u0301y đươ\u0323c tên!".ToLower()) || text6.Contains(F7AB102E.smethod_0("Không lâ\u0301y đươ\u0323c tên!").ToLower()) || text6.Contains("Tên không hợp lệ - Yêu cầu tên Việt!".ToLower()) || (text6.Contains("job fail") && !text6.Contains("hết job") && !text6.Contains("502 bad gateway"));
				}
			}
			if (flag)
			{
				if (BA039CBC.method_63(int_0) == 2)
				{
					BA039CBC.method_62(int_0, 0);
				}
				BA039CBC.method_58(int_0, "cChose", false);
				BA039CBC.E6042218();
			}
			BA039CBC.F0A99AA5(int_0, "cInteractEnd", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "interactEnd");
			goto end_IL_0001;
			IL_0535:
			if (text3.Split('|').Length > 1)
			{
				text3 = text3.Split('|')[1];
			}
			BA039CBC.F0A99AA5(int_0, "cName", text3, "name", bool_2: false);
			int num3 = 0;
			if (GClass8.smethod_68(text3))
			{
				num3 = 1;
			}
			else if (GClass8.smethod_69(text3))
			{
				num3 = 2;
			}
			while (!method_4() && !DD376799() && !method_4())
			{
				list = new List<GClass19>();
				text = "";
				int tickCount = Environment.TickCount;
				while (!method_4())
				{
					if (text != "")
					{
						text += ", ";
					}
					method_0(int_0, text + "Get job...");
					int num4 = Convert.ToInt32(BA039CBC.E9B4CF8B("cbbServer"));
					string text7 = method_3(num4);
					if (!(text7 == ""))
					{
						if (num4 != 3 && num4 != 4 && num4 != 5 && !Class57.bool_5 && !Class57.bool_6 && !Class57.bool_4 && !Class57.bool_7 && ((num4 == 0 && num3 != 1) || (num4 != 0 && num3 == 1)))
						{
							List<string> list2 = (from string_0 in text7.Split(',')
								where string_0.EndsWith("_all")
								select string_0).ToList();
							if (list2.Count == 0)
							{
								goto IL_0d87;
							}
							text7 = string.Join(",", list2);
						}
						(list, text) = GClass19.smethod_0(BA039CBC.E9B4CF8B("txtApiKey").ToString(), string_0, text3, "", text7);
						if (list.Count <= 0)
						{
							int num5 = Convert.ToInt32(BA039CBC.E9B4CF8B("nudTimeoutGetJob")) - (Environment.TickCount - tickCount) / 1000;
							if (num5 >= 0)
							{
								string value2 = Regex.Match(text, "Vui lòng chờ (\\d+) giây").Groups[1].Value;
								int num6 = (string.IsNullOrEmpty(value2) ? 5 : Convert.ToInt32(value2));
								if (num5 >= num6)
								{
									if (!string.IsNullOrEmpty(value2))
									{
										method_0(int_0, text.Replace(value2, "{time}"), num6);
									}
									else
									{
										method_0(int_0, "Get job sau {time}s...", num6);
									}
									text = "";
									continue;
								}
								text = "Tạm thời hết job cho UID này";
							}
							else
							{
								text = "Tạm thời hết job cho UID này";
							}
						}
						if (text != "")
						{
							BA039CBC.A1BF1713(int_0, "Get job fail: " + text);
							break;
						}
						goto IL_07fe;
					}
					method_0(int_0, "Vui lo\u0300ng cho\u0323n job!");
					break;
				}
				break;
				IL_0d87:
				if (num3 == 2)
				{
					method_0(int_0, "Tên không hợp lệ - Yêu cầu tên Việt!");
				}
				else
				{
					method_0(int_0, "Tên không hợp lệ - Yêu cầu tên ngoa\u0323i!");
				}
				break;
				IL_07fe:
				if (method_4())
				{
					break;
				}
				for (int i = 0; i < list.Count; i++)
				{
					(bool, string, string) tuple2;
					if (!method_4())
					{
						GClass19 gClass = list[i];
						if (gClass.F63D2D1F.StartsWith("via_"))
						{
							gClass.F63D2D1F = gClass.F63D2D1F.Replace("via_", "");
						}
						if (gClass.F63D2D1F.EndsWith("_all"))
						{
							gClass.F63D2D1F = gClass.F63D2D1F.Replace("_all", "");
						}
						if (gClass.F63D2D1F.EndsWith("_thailand"))
						{
							gClass.F63D2D1F = gClass.F63D2D1F.Replace("_thailand", "");
						}
						if (gClass.F63D2D1F.EndsWith("_thailand_via"))
						{
							gClass.F63D2D1F = gClass.F63D2D1F.Replace("_thailand_via", "");
						}
						if (gClass.F63D2D1F.EndsWith("_philippines"))
						{
							gClass.F63D2D1F = gClass.F63D2D1F.Replace("_philippines", "");
						}
						if (gClass.F63D2D1F.EndsWith("_us"))
						{
							gClass.F63D2D1F = gClass.F63D2D1F.Replace("_us", "");
						}
						if (gClass.F63D2D1F.EndsWith("_indo"))
						{
							gClass.F63D2D1F = gClass.F63D2D1F.Replace("_indo", "");
						}
						method_0(int_0, gClass.F63D2D1F + "...");
						GClass11 gClass2 = new GClass11();
						gClass2.method_4("id", gClass.A68CE239);
						gClass2.method_4("content", gClass.AEB2CFB2);
						tuple2 = AEA0369A.method_6(gClass.F63D2D1F, gClass2, Convert.ToInt32(BA039CBC.E9B4CF8B("typeRunBy")), gclass3_0);
						method_0(int_0, gClass.F63D2D1F + " " + (tuple2.Item1 ? "success" : "fail") + "...");
						if (tuple2.Item1)
						{
							if (bool_1)
							{
								bool_1 = false;
								BA039CBC.F0A99AA5(int_0, "cFbBlock", "", "fbBlock");
							}
							gClass.ED286D22(tuple2.Item1);
							num++;
							int_2 = 0;
							BA039CBC.method_62(int_0, 2);
							B91EDB96(1);
							if (!DD376799())
							{
								if (Convert.ToBoolean(BA039CBC.E9B4CF8B("ckbBreakTime")) && num % Convert.ToInt32(BA039CBC.E9B4CF8B("nudBreakTimeJob")) == 0)
								{
									i = list.Count;
									method_0(int_0, string.Format("Nghỉ sau {0} job success, đợi {{time}}s...", Convert.ToInt32(BA039CBC.E9B4CF8B("nudBreakTimeJob"))), Convert.ToInt32(BA039CBC.E9B4CF8B("nudBreakTime")));
								}
								else
								{
									method_0(int_0, gClass.F63D2D1F + " success, đợi {time}s...", GClass8.B7A07C09(Convert.ToInt32(BA039CBC.E9B4CF8B("nudDelayFrom")), Convert.ToInt32(BA039CBC.E9B4CF8B("nudDelayTo"))));
								}
								goto IL_0cae;
							}
						}
						else
						{
							bool flag2 = false;
							if (!tuple2.Item2.Contains("again") && !tuple2.Item3.Contains("A connection attempt failed because the connected party did not properly respond after a period of time") && !tuple2.Item2.Contains("token_die") && !tuple2.Item2.Contains("cookie_die"))
							{
								if (tuple2.Item2.Contains("job_die"))
								{
									flag2 = true;
									tuple2.Item2 = "job_die";
								}
								else if (tuple2.Item2.Contains("fb_blocked"))
								{
									int_3++;
									tuple2.Item2 = "skip";
								}
							}
							else
							{
								tuple2.Item2 = "skip";
							}
							GClass19.smethod_1(gClass, tuple2.Item2 + "\n" + tuple2.Item3, string_0);
							gClass.ED286D22(tuple2.Item1, tuple2.Item2, flag2, tuple2.Item3);
							if (!method_4() && !method_5())
							{
								if (!flag2)
								{
									int_2++;
									if (B7284583())
									{
										goto IL_0de7;
									}
								}
								goto IL_0cae;
							}
						}
					}
					goto IL_0de7;
					IL_0cae:
					if (num2 == 0)
					{
						if (!(AEA0369A.string_1 == ""))
						{
							continue;
						}
						if (method_9())
						{
							method_2(list);
							break;
						}
					}
					else if (num2 == 1)
					{
						if (!(AEA0369A.AABEBA86 == ""))
						{
							continue;
						}
						if (method_8())
						{
							method_2(list);
							break;
						}
					}
					else
					{
						if (num2 != 2 || (!(tuple2.Item2 == "cookie_die") && !gclass3_0.method_1()))
						{
							continue;
						}
						BA039CBC.method_75();
						if (method_7(int_0))
						{
							method_2(list);
							break;
						}
					}
					goto IL_0de7;
				}
			}
			goto IL_0de7;
			IL_0506:
			if (!(text3 == ""))
			{
				goto IL_0535;
			}
			BA039CBC.A1BF1713(int_0, F7AB102E.smethod_0("Không lâ\u0301y đươ\u0323c tên!"));
			goto IL_0de7;
			end_IL_0001:;
		}
		catch (Exception)
		{
		}
	}

    private string method_3(int int_4)
    {
        string text = BA039CBC.E9B4CF8B("jobType").ToString();
        text = text.Replace("commentfb_", "comment__");
        text = text.Replace("commentfb", "commentfb,comment_campaign,commentfb_livestream");
        text = text.Replace("comment__", "commentfb_");
        text = text.Replace("share", "share,share_content");

        if (Class57.bool_3)
        {
            text = text.Replace("review_page", "review_page1");
        }

        if (!Class57.bool_2)
        {
            text = text.Replace("commentfb_full_avatar2", "");
        }

        if (!Class57.bool_1)
        {
            text = text.Replace("commentfb_via_female2", "");
            text = text.Replace("commentfb_via_male2", "");
            text = text.Replace("commentfb_via2", "");
        }

        // Xóa các mục trống
        text = string.Join(",", text.Split(',').Where(s => !string.IsNullOrEmpty(s)));

        // Xử lý dựa trên int_4 và các giá trị của Class57
        if (!Class57.bool_4 && !Class57.bool_5 && !Class57.bool_6 && !Class57.bool_7)
        {
            switch (int_4)
            {
                case 1:
                    text = string.Join(",", text.Split(',').Select(s => s + "_philippines"));
                    break;
                case 2:
                    text = string.Join(",", text.Split(',').Select(s => s + "_us"));
                    break;
                case 3:
                    text = string.Join(",", text.Split(',').Select(s => s + "_thailand"));
                    break;
                case 4:
                    text = string.Join(",", text.Split(',').Select(s => s + "_thailand")) + "," +
                           string.Join(",", text.Split(',').Select(s => s + "_thailand_via"));
                    break;
                case 5:
                    text = string.Join(",", text.Split(',').Select(s => s + "_indo"));
                    break;
            }
        }
        else
        {
            if (Class57.bool_4)
            {
                text = string.Join(",", text.Split(',').Select(s => s + "_indo"));
            }
            else if (Class57.bool_5)
            {
                text = string.Join(",", text.Split(',').Select(s => s + "_thailand"));
            }
            else if (Class57.bool_6)
            {
                text = string.Join(",", text.Split(',').Select(s => s + "_thailand")) + "," +
                       string.Join(",", text.Split(',').Select(s => s + "_thailand_via"));
            }
            else if (Class57.bool_7)
            {
                text = string.Join(",", text.Split(',').Select(s => s + "_philippines"));
            }
        }

        // Xử lý khi chứa "job_all"
        if (text.Contains("job_all"))
        {
            text = string.Join(",", text.Split(',').Where(s => !s.Contains("job_all")));

            // Loại bỏ hậu tố và thêm "_all"
            string text2 = text.Replace("_philippines", "")
                               .Replace("_us", "")
                               .Replace("_thailand_via", "")
                               .Replace("_thailand", "")
                               .Replace("_indo", "");
            text2 = string.Join(",", text2.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                          .Select(s => s + "_all"));

            text = text.TrimEnd(',') + "," + text2;
        }

        return text;
    }


    private bool method_4()
	{
		if (Class57.smethod_5())
		{
			BA039CBC.A1BF1713(int_0, "Đã dừng!");
			return true;
		}
		return false;
	}

	private bool method_5()
	{
		if (int_3 >= 1)
		{
			BA039CBC.A1BF1713(int_0, "Fb blocked!");
			BA039CBC.F0A99AA5(int_0, "cFbBlock", "Yes", "fbBlock");
			return true;
		}
		return false;
	}

	private bool B7284583()
	{
		int num = Convert.ToInt32(BA039CBC.E9B4CF8B("nudMaxJobFailLienTiep"));
		if (int_2 >= num)
		{
			BA039CBC.F0A99AA5(int_0, "cFbBlock", "Yes", "fbBlock");
			BA039CBC.A1BF1713(int_0, num + " job fail!");
			return true;
		}
		return false;
	}

	public void CD326A89()
	{
		Class57.A39EDD1D(bool_9: true);
	}

	public void B98564A8(double F6BEBA1E)
	{
		int tickCount = Environment.TickCount;
		while (!Class57.smethod_5() && !((double)(Environment.TickCount - tickCount) > F6BEBA1E * 1000.0))
		{
			Thread.Sleep(500);
		}
	}

	private GClass3 method_6()
	{
		GClass3 gClass = new GClass3();
		try
		{
			method_0(int_0, F7AB102E.smethod_0("Chờ mơ\u0309 chrome..."));
			lock (BA039CBC.object_8)
			{
				if (!Class57.smethod_5())
				{
					while (true)
					{
						if (BA039CBC.B190710B() < Convert.ToInt32(BA039CBC.E9B4CF8B("nudMaxChrome")))
						{
							BA039CBC.method_76();
							break;
						}
						if (!Class57.smethod_5())
						{
							B98564A8(1.0);
							continue;
						}
						goto end_IL_002c;
					}
					goto IL_009a;
				}
				end_IL_002c:;
			}
			goto end_IL_0006;
			IL_009a:
			if (!Class57.smethod_5())
			{
				lock (BA039CBC.object_7)
				{
					if (BA039CBC.int_2 > 0)
					{
						int b418352A = GClass8.B7A07C09(Convert.ToInt32(BA039CBC.E9B4CF8B("nudDelayOpenChromeFrom")), Convert.ToInt32(BA039CBC.E9B4CF8B("nudDelayOpenChromeTo")));
						method_0(int_0, "Open chrome {time}s...", b418352A);
					}
					else
					{
						BA039CBC.int_2++;
					}
				}
				if (!Class57.smethod_5())
				{
					method_0(int_0, "Open chrome...");
					string string_ = "data:,";
					Point b0B3B9A = GClass8.smethod_57(int_0 % 10, 5, 2);
					Point point2 = (gClass.D780F8B7 = GClass8.smethod_56(5, 2));
					gClass.B0B3B9A3 = b0B3B9A;
					gClass.String_9 = string_;
					gClass.Boolean_2 = !Convert.ToBoolean(BA039CBC.E9B4CF8B("ckbShowImageInteract"));
					gClass.Boolean_0 = Convert.ToBoolean(BA039CBC.E9B4CF8B("ckbHideBrowser"));
					gClass.int_0 = int_0;
					gClass.String_8 = E389669B;
					gClass.Int32_1 = int_1;
					gClass.String_1 = E8173DA6;
					gClass.String_2 = string_0;
					gClass.String_3 = string_1;
					gClass.CCBE39A8 = string_2;
					gClass.DEB56B05 = string_4;
					string text = GClass25.smethod_2();
					string text2 = "";
					if (text != "" && gClass.String_2 != "")
					{
						text2 = text + "\\" + gClass.String_2;
					}
					if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbCreateProfile"))
					{
						text2 = "";
					}
					gClass.String_0 = text2;
					if (!Class57.smethod_5())
					{
						var (flag, text3) = gClass.method_0();
						if (!flag)
						{
							method_0(int_0, F7AB102E.smethod_0("Lỗi mở trình duyệt!") + ((text3 != "") ? (" (" + text3 + ")") : ""));
							gClass = null;
						}
					}
				}
			}
			end_IL_0006:;
		}
		catch (Exception)
		{
		}
		return gClass;
	}

	private void F932531E()
	{
		if (gclass3_0 != null)
		{
			gclass3_0.B7841719();
		}
		gclass3_0 = null;
		BA039CBC.method_75();
	}

	private bool method_7(int int_4)
	{
		bool flag = false;
		try
		{
			if (gclass3_0 == null || gclass3_0.method_1())
			{
				gclass3_0 = method_6();
			}
			gclass3_0.D491453C = int_4;
			gclass3_0.String_1 = E8173DA6;
			gclass3_0.String_2 = string_0;
			gclass3_0.String_3 = string_1;
			gclass3_0.CCBE39A8 = string_2;
			gclass3_0.String_4 = A72C7A28;
			gclass3_0.D32E1816 = string_3;
			string text;
			if (!method_4())
			{
				if (gclass3_0 != null)
				{
					method_0(int_4, "Login...");
					text = "https://www.facebook.com/";
					switch (Convert.ToInt32(BA039CBC.E9B4CF8B("cbbFacebookWeb")))
					{
					case 0:
						text = "https://mobile.facebook.com/";
						break;
					case 2:
						text = "https://mbasic.facebook.com";
						break;
					}
					if (!gclass3_0.method_9().Contains("facebook.com"))
					{
						gclass3_0.method_10(text);
						if (gclass3_0.method_36().Contains("i_user"))
						{
							gclass3_0.method_35("i_user");
							gclass3_0.method_10(text);
							gclass3_0.method_53();
							gclass3_0.method_51();
						}
					}
					if (gclass3_0.String_8 != "")
					{
						gclass3_0.method_40(2.0);
						if (gclass3_0.C12B8625() == "<html><head></head><body></body></html>")
						{
							method_0(int_4, "Proxy yêu cầu User/Pass!");
							return flag;
						}
					}
					if (!(gclass3_0.String_0.Trim() != ""))
					{
						goto IL_02fa;
					}
					gclass3_0.method_59();
					switch (gclass3_0.method_131(text))
					{
					case -3:
						method_0(int_4, "No internet!");
						return flag;
					case -2:
						method_0(int_4, "Chrome bị đóng!");
						return flag;
					case 1:
						flag = true;
						goto IL_02fa;
					case 2:
						break;
					default:
						goto IL_02fa;
					}
					method_0(int_4, "Checkpoint!");
					BA039CBC.FD062316(int_4, "Checkpoint");
					if (GClass25.smethod_0("configInteractGeneral").method_3("ckbGetCookie") || A72C7A28 == "")
					{
						A72C7A28 = gclass3_0.method_36();
						if (A72C7A28 != "")
						{
							BA039CBC.F0A99AA5(int_4, "cCookies", A72C7A28, "cookie1");
						}
					}
					goto IL_0782;
				}
				return flag;
			}
			return flag;
			IL_06e4:
			string text2;
			if (text2.Contains("Invalid username or password") || text2.Contains("Tên người dùng hoặc mật khẩu không hợp lệ"))
			{
				BA039CBC.FD062316(int_4, "Changed pass");
			}
			method_0(int_4, text2);
			goto IL_0782;
			IL_02fa:
			if (!method_4())
			{
				if (!flag)
				{
					int num = Convert.ToInt32(BA039CBC.E9B4CF8B("cbbTypeLogin"));
					switch (num)
					{
					case 1:
						method_0(int_4, F7AB102E.smethod_0("Đăng nhâ\u0323p bă\u0300ng email|pass..."));
						goto default;
					case 2:
					case 3:
						method_0(int_4, F7AB102E.smethod_0("Đăng nhâ\u0323p bă\u0300ng cookie..."));
						goto default;
					case 0:
						method_0(int_4, F7AB102E.smethod_0("Đăng nhâ\u0323p bă\u0300ng uid|pass..."));
						goto default;
					default:
					{
						text2 = gclass3_0.method_129(num, text);
						if (num != 3 || new List<string> { "1", "2", "8" }.Contains(text2))
						{
							break;
						}
						num = 0;
						int num2 = 0;
						int num3 = 0;
						goto case 0;
					}
					}
					A72C7A28 = gclass3_0.method_36();
					string text3 = text2;
					string text4 = text3;
					uint num4 = C43AF739.smethod_0(text4);
					if (num4 <= 856466825)
					{
						if (num4 <= 382537041)
						{
							if (num4 != 365759422)
							{
								if (num4 != 382537041 || !(text4 == "-3"))
								{
									goto IL_06e4;
								}
								method_0(int_4, "No internet!");
							}
							else
							{
								if (!(text4 == "-2"))
								{
									goto IL_06e4;
								}
								method_0(int_4, "Chrome bị đóng!");
							}
						}
						else if (num4 != 806133968)
						{
							if (num4 != 822911587)
							{
								if (num4 != 856466825 || !(text4 == "6"))
								{
									goto IL_06e4;
								}
								method_0(int_4, F7AB102E.smethod_0("Mã 2fa không đúng!"));
							}
							else
							{
								if (!(text4 == "4"))
								{
									goto IL_06e4;
								}
								method_0(int_4, F7AB102E.smethod_0("Tài khoản không đúng!"));
							}
						}
						else
						{
							if (!(text4 == "5"))
							{
								goto IL_06e4;
							}
							method_0(int_4, F7AB102E.smethod_0("Mật khẩu không đúng!"));
							BA039CBC.FD062316(int_4, "Changed pass");
						}
					}
					else if (num4 <= 906799682)
					{
						if (num4 != 873244444)
						{
							if (num4 != 890022063)
							{
								if (num4 != 906799682 || !(text4 == "3"))
								{
									goto IL_06e4;
								}
								if (num != 2)
								{
									method_0(int_4, F7AB102E.smethod_0("Không có 2fa!"));
								}
								else
								{
									flag = true;
								}
							}
							else
							{
								if (!(text4 == "0"))
								{
									goto IL_06e4;
								}
								method_0(int_4, F7AB102E.smethod_0("Đăng nhập thất bại!"));
							}
						}
						else
						{
							if (!(text4 == "1"))
							{
								goto IL_06e4;
							}
							flag = true;
							if (GClass25.smethod_0("configInteractGeneral").method_3("ckbGetCookie") && A72C7A28 != "")
							{
								BA039CBC.F0A99AA5(int_4, "cCookies", A72C7A28, "cookie1");
							}
						}
					}
					else if (num4 != 923577301)
					{
						if (num4 != 1007465396)
						{
							if (num4 != 1024243015 || !(text4 == "8"))
							{
								goto IL_06e4;
							}
							BA039CBC.FD062316(int_4, "Live");
							BA039CBC.method_62(int_4, 2);
							if (GClass25.smethod_0("configInteractGeneral").method_3("ckbGetCookie") && A72C7A28 != "")
							{
								BA039CBC.F0A99AA5(int_4, "cCookies", A72C7A28, "cookie1");
							}
							method_0(int_4, "Account Novery!");
						}
						else
						{
							if (!(text4 == "9"))
							{
								goto IL_06e4;
							}
							method_0(int_4, "Facebook blocked!");
						}
					}
					else
					{
						if (!(text4 == "2"))
						{
							goto IL_06e4;
						}
						method_0(int_4, "Checkpoint!");
						BA039CBC.FD062316(int_4, "Checkpoint");
						if (GClass25.smethod_0("configInteractGeneral").method_3("ckbGetCookie") && A72C7A28 != "")
						{
							BA039CBC.F0A99AA5(int_4, "cCookies", A72C7A28, "cookie1");
						}
					}
				}
				goto IL_0782;
			}
			return flag;
			IL_0782:
			if (BA039CBC.method_60(int_4, "cInfo").Contains("Checkpoint"))
			{
				method_0(int_4, "Checking...");
				BA039CBC.method_22(int_4, "", A72C7A28, E389669B, int_1);
				string text5 = BA039CBC.E01F1137(int_4);
				if (text5.Contains("956") && Convert.ToBoolean(BA039CBC.E9B4CF8B("ckbUnlock956")))
				{
					F3958F9B f3958F9B_ = new F3958F9B(A72C7A28, string_4, E389669B, int_1);
					BA039CBC.B4A21198(int_4, "", f3958F9B_);
					flag = BA039CBC.C5151C09(int_4).Contains("Live");
				}
			}
			if (!flag)
			{
				BA039CBC.method_62(int_4, 1);
				return flag;
			}
			BA039CBC.FD062316(int_4, "Live");
			method_0(int_4, F7AB102E.smethod_0("Đăng nhâ\u0323p tha\u0300nh công!"));
			BA039CBC.method_62(int_4, 2);
			if (!method_4())
			{
				if (!gclass3_0.CD003D3F("[href=\"/\"]"))
				{
					gclass3_0.method_59();
					if (gclass3_0.method_9().Contains("facebook.com/si/actor_experience/actor_gateway") && gclass3_0.CD003D3F("[data-nt=\"NT:IMAGE\"]", 15.0))
					{
						gclass3_0.method_19("[data-nt=\"NT:IMAGE\"]");
						gclass3_0.method_40(2.0);
					}
					if (gclass3_0.CD003D3F("[data-cookiebanner=\"accept_button\"]"))
					{
						gclass3_0.method_19("[data-cookiebanner=\"accept_button\"]");
					}
					if (gclass3_0.AFABF4B7() == 2)
					{
						gclass3_0.BB963890(0, "[href^=\"/a/preferences.php?fast_switch_site\"]");
					}
					if (gclass3_0.method_9().StartsWith("https://free.facebook.com/") || gclass3_0.CD003D3F("[href^=\"/upsell/advanced_upsell/in_line\"]"))
					{
						gclass3_0.BB963890(0, "[href^=\"/upsell/advanced_upsell/in_line\"]");
						gclass3_0.BB963890(5, "#upsell_upgrade_confirm_button");
						return flag;
					}
					return flag;
				}
				return flag;
			}
			return flag;
		}
		catch (Exception)
		{
			return flag;
		}
	}

	public bool method_8()
	{
		string text = "";
		bool flag;
		if ((flag = method_7(int_0)) && !method_4())
		{
			text = gclass3_0.method_36();
			AEA0369A.string_2 = gclass3_0.B8B3CA97();
		}
		F932531E();
		if (text != "")
		{
			AEA0369A.AABEBA86 = text;
			BA039CBC.F0A99AA5(int_0, "cCookies", text, "cookie1");
		}
		else if (!Class57.smethod_5() && flag)
		{
			BA039CBC.A1BF1713(int_0, "Không lấy được cookie!");
		}
		return text != "";
	}

	public bool method_9()
	{
		BA039CBC.F0A99AA5(int_0, "cToken", "", "token");
		if (!Convert.ToBoolean(BA039CBC.E9B4CF8B("ckbGetTokenWhenDie")))
		{
			BA039CBC.A1BF1713(int_0, F7AB102E.smethod_0("Token die!"));
			return false;
		}
		string text = "";
		int num = Convert.ToInt32(BA039CBC.E9B4CF8B("cbbTypeGetToken"));
		string text2 = BA039CBC.E9B4CF8B("cbbGetTokenBy").ToString();
		bool flag = true;
		switch (text2)
		{
		case "chrome":
			if ((flag = method_7(int_0)) && !method_4())
			{
				AEA0369A.AABEBA86 = gclass3_0.method_36();
				BA039CBC.F0A99AA5(int_0, "cCookies", AEA0369A.AABEBA86, "cookie1");
				AEA0369A.string_2 = gclass3_0.B8B3CA97();
				BA039CBC.A1BF1713(int_0, "Get token...");
				switch (num)
				{
				case 0:
					text = gclass3_0.method_82();
					break;
				case 1:
					text = gclass3_0.F61C0617();
					break;
				case 2:
					text = gclass3_0.method_81();
					break;
				}
			}
			break;
		case "uid":
		case "cookie":
			{
				if (text2 == "uid" && (string_0 == "" || string_1 == ""))
				{
					method_0(int_0, F7AB102E.smethod_0("Không ti\u0300m thâ\u0301y Uid hoă\u0323c Pass!"));
					break;
				}
				if (text2 == "cookie" && A72C7A28 == "")
				{
					method_0(int_0, F7AB102E.smethod_0("Không ti\u0300m thâ\u0301y Cookie!"));
					break;
				}
				method_0(int_0, F7AB102E.smethod_0("Chờ get token..."));
				lock (BA039CBC.object_8)
				{
					if (Class57.smethod_5())
					{
						break;
					}
					while (true)
					{
						if (BA039CBC.B190710B() >= 100)
						{
							if (Class57.smethod_5())
							{
								goto end_IL_009e;
							}
							B98564A8(1.0);
							continue;
						}
						BA039CBC.method_76();
						break;
					}
					goto IL_02a4;
				}
			}
			IL_02a4:
			method_0(int_0, "Get token...");
			switch (num)
			{
			case 1:
				if (text2 == "uid")
				{
					string text5 = GClass8.C499D098(string_0, string_1, string_2, E389669B, int_1);
					if (text5.Contains("|") && text5 != "|")
					{
						text = text5.Split('|')[0];
						AEA0369A.AABEBA86 = text5.Split('|')[1];
						BA039CBC.F0A99AA5(int_0, "cCookies", AEA0369A.AABEBA86, "cookie1");
					}
					else if (text5 == "Invalid username or password")
					{
						BA039CBC.FD062316(int_0, "Changed pass");
					}
					else if (text5.Contains("temporarily blocked"))
					{
						BA039CBC.A1BF1713(int_0, "Không lấy được token (IP bi\u0323 spam, vui lo\u0300ng đô\u0309i IP)!");
					}
				}
				else if (text2 == "cookie")
				{
					text = GClass8.FE2F1036(A72C7A28, E389669B, int_1);
				}
				break;
			case 0:
			case 2:
			{
				for (int i = 0; i < 3; i++)
				{
					switch (num)
					{
					case 0:
						text = GClass8.smethod_7(A72C7A28, string_4, E389669B, int_1, string_2);
						break;
					case 2:
						text = GClass8.smethod_9(A72C7A28, string_4, E389669B, int_1);
						break;
					}
					if (text != "")
					{
						break;
					}
					if (string.IsNullOrEmpty(AEA0369A.string_2))
					{
						AEA0369A.string_2 = GClass8.smethod_8(AEA0369A.AABEBA86, string_4, E389669B, int_1);
					}
					string text3 = "av=" + string_0 + "&__user=" + string_0 + "&__a=1&__req=7&__hs=20015.HYP%3Acomet_pkg.2.1..2.1&dpr=3&__ccg=EXCELLENT&__rev=1017496172&__s=pljtfv%3Aznp1jt%3Apkw3sx&__hsi=7427386731673553225&__dyn=7xeXxa1mxu1syaxG4Vp41twWwIxu13w8CewSwAyUco2qwJyE2OwpUe8hwaG0Z82_CwjE1xoswMwto2awgo9oO0n24oaEd82lwv89k2C1Fwc60D8vwRwlE-U2exi4UaEW0Loco4i5o2eUlwhE2Lx-0luVEbUGdG1Jw9h08O321Lwqo5B0bK1Iwqo2swEwkFU-4EdrwsUbUaU3yw&__csr=hJEJaIggyTtZ5RZlhdL8J9bviP5h6nkNpkhp2tltppFl-AaBykJprVbCghKjAgS8KcppWyECqq5pqDKQWVomwVxG3K4E5S0LUdpodEaHwpo5u0h-0A9U-09swqo4-m0PE1do0Rh1q3F0UUhw9m0d6w14K0tu03bC06q-00hl208Nw0Nzw4ZwwwjU0Ci1exe5WoK06So0De0709orx2ECp2otCga805vSew38o08NGa3e2Je9m&__comet_req=15&fb_dtsg=" + AEA0369A.string_2 + "&jazoest=25772&lsd=&__spin_r=1017496172&__spin_b=trunk&__spin_t=1729323233&fb_api_caller_class=RelayModern&";
					string d510F3A = text3 + "fb_api_req_friendly_name=FBScrapingWarningMutation&variables=%7B%7D&server_timestamps=true&doc_id=6339492849481770";
					string text4 = AEA0369A.f3958F9B_0.B51DA5A0("https://www.facebook.com/api/graphql/", d510F3A, "application/x-www-form-urlencoded", new string[1] { "x-fb-friendly-name: FBScrapingWarningMutation" });
					if (text4.Contains("828281030927956") || text4.Contains("1501092823525282"))
					{
						break;
					}
				}
				break;
			}
			}
			break;
			end_IL_009e:
			break;
		}
		F932531E();
		if (text != "")
		{
			AEA0369A.string_1 = text;
			BA039CBC.F0A99AA5(int_0, "cToken", text, "token");
			if (string.IsNullOrEmpty(AEA0369A.string_2))
			{
				AEA0369A.string_2 = GClass8.smethod_8(AEA0369A.AABEBA86, string_4, E389669B, int_1);
			}
		}
		else if (!Class57.smethod_5() && flag)
		{
			BA039CBC.A1BF1713(int_0, "Không lấy được token!");
		}
		return text != "";
	}
}
