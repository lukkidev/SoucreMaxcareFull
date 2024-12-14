using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

internal class Class15
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A301403D
	{
		public static readonly A301403D _003C_003E9 = new A301403D();

		public static Func<string, string> _003C_003E9__20_0;

		public static Func<string, string> _003C_003E9__20_1;

		public static Func<DataRow, BBA6CAB0> _003C_003E9__34_0;

		public static Func<DataRow, BBA6CAB0> _003C_003E9__36_0;

		public static Func<DataRow, BBA6CAB0> _003C_003E9__41_0;

		internal string method_0(string string_0)
		{
			return string_0.ToLower();
		}

		internal string method_1(string B913120C)
		{
			return B913120C.ToLower();
		}

		internal BBA6CAB0 ADA6901E(DataRow dataRow_0)
		{
			return new BBA6CAB0
			{
				Int32_0 = Convert.ToInt32(dataRow_0["id"]),
				String_0 = Convert.ToString(dataRow_0["tenChuDe"]),
				BF907F85 = Convert.ToString(dataRow_0["ngaytao"]),
				EF0AA8B3 = Convert.ToString(dataRow_0["anh"]),
				D52B6012 = Convert.ToString(dataRow_0["video"]),
				BA2E9E33 = Convert.ToString(dataRow_0["tieude"]),
				String_1 = Convert.ToString(dataRow_0["noidung"])
			};
		}

		internal BBA6CAB0 B2B97020(DataRow FABEA829)
		{
			return new BBA6CAB0
			{
				Int32_0 = Convert.ToInt32(FABEA829["id"]),
				String_0 = Convert.ToString(FABEA829["tenChuDe"]),
				BF907F85 = Convert.ToString(FABEA829["ngaytao"]),
				EF0AA8B3 = Convert.ToString(FABEA829["anh"]),
				D52B6012 = Convert.ToString(FABEA829["video"]),
				BA2E9E33 = Convert.ToString(FABEA829["tieude"]),
				String_1 = Convert.ToString(FABEA829["noidung"])
			};
		}

		internal BBA6CAB0 method_2(DataRow E6993B86)
		{
			return new BBA6CAB0
			{
				Int32_0 = Convert.ToInt32(E6993B86["id"]),
				String_0 = Convert.ToString(E6993B86["tenChuDe"]),
				BF907F85 = Convert.ToString(E6993B86["ngaytao"]),
				EF0AA8B3 = Convert.ToString(E6993B86["anh"]),
				D52B6012 = Convert.ToString(E6993B86["video"]),
				BA2E9E33 = Convert.ToString(E6993B86["tieude"]),
				String_1 = Convert.ToString(E6993B86["noidung"])
			};
		}
	}

	public static bool smethod_0(string string_0)
	{
		return Class53.smethod_2("SELECT COUNT(*) FROM files WHERE name='" + string_0 + "' AND active=1;") > 0;
	}

	public static DataTable smethod_1(bool bool_0 = false, bool bool_1 = false)
	{
		DataTable result = new DataTable();
		try
		{
			string text = "";
			text = (bool_1 ? (bool_0 ? ("select id, name, STT from files WHERE id IN (SELECT DISTINCT idfile FROM accounts WHERE active=0) UNION SELECT -2 AS id, '" + F7AB102E.smethod_0("[Tất cả thư mục]") + "' AS name, -2 AS STT UNION SELECT 999999 AS id, '" + F7AB102E.smethod_0("[Chọn nhiều thư mục]") + "' AS name, 999999 AS STT ORDER BY STT") : "select id, name from files WHERE id IN (SELECT DISTINCT idfile FROM accounts WHERE active=0) ORDER BY STT") : (bool_0 ? ("select id, name, STT from files where active=1 UNION SELECT -2 AS id, '" + F7AB102E.smethod_0("[Tất cả thư mục]") + "' AS name, -2 AS STT UNION SELECT 999999 AS id, '" + F7AB102E.smethod_0("[Chọn nhiều thư mục]") + "' AS name, 999999 AS STT ORDER BY STT") : "select id, name from files where active=1 ORDER BY STT"));
			result = Class53.C3BFFDBD(text);
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static DataTable E888F681()
	{
		DataTable result = new DataTable();
		try
		{
			string aA8B3E = (GClass25.D311242C() ? "DROP TEMPORARY TABLE IF EXISTS tmp;CREATE TEMPORARY TABLE tmp (Stt INT AUTO_INCREMENT PRIMARY KEY, id INT, name TEXT);INSERT INTO tmp (id, name)SELECT id, name FROM files WHERE active = 1 ORDER BY Stt;SELECT id, CONCAT(Stt, '. ', name) AS Ten FROM tmp;" : "DROP TABLE IF EXISTS tmp;CREATE TEMPORARY TABLE tmp(Stt INTEGER PRIMARY KEY AUTOINCREMENT, id INTEGER, name TEXT);INSERT INTO tmp (id, name) select id, name from files where active=1 ORDER BY STT;SELECT id, (Stt||'. '||name) AS Ten FROM tmp;");
			result = Class53.C3BFFDBD(aA8B3E);
		}
		catch
		{
		}
		return result;
	}

	public static bool DE31880F(string string_0)
	{
		bool result = true;
		try
		{
			int num = Class53.smethod_2("SELECT IFNULL(MAX(STT),0) FROM files");
			string aA8B3E = "INSERT INTO files (name, createddate, active, STT) values('" + string_0 + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',1," + (num + 1) + ")";
			Class53.C3BFFDBD(aA8B3E);
			return result;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_2(string E83D0B3B, string string_0)
	{
		try
		{
			string string_ = "UPDATE files SET name='" + string_0 + "' where id=" + E83D0B3B;
			return Class53.smethod_1(string_) > 0;
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_3(string DF80E0A5)
	{
		bool result = false;
		try
		{
			if (Class53.smethod_2("SELECT COUNT(idfile) FROM accounts WHERE idfile=" + DF80E0A5) == 0)
			{
				result = Class53.smethod_1("delete from files where id=" + DF80E0A5) > 0;
				return result;
			}
			if (Class53.smethod_1("UPDATE files SET active=0 where id=" + DF80E0A5) > 0)
			{
				result = EF358DA6(DF80E0A5);
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_4(string string_0, List<string> B9033194, string F639F0A3 = "accounts")
	{
		List<string> list = new List<string>();
		string text = "";
		string text2 = "";
		string text3 = "";
		for (int i = 0; i < B9033194.Count; i++)
		{
			text = B9033194[i].Split('|')[0];
			text2 = B9033194[i].Split('|')[1];
			if (!string.IsNullOrEmpty(text))
			{
				list.Add(text);
				text3 = text3 + "WHEN '" + text + "' THEN '" + text2 + "' ";
			}
		}
		string string_ = "UPDATE " + F639F0A3 + " SET " + string_0 + " = CASE id " + text3 + "END WHERE id IN('" + string.Join("','", list) + "'); ";
		return Class53.smethod_1(string_) > 0;
	}

	public static bool smethod_5(JArray jarray_0, string FA20611A = "uid")
	{
		List<string> list = new List<string>();
		Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
		foreach (JObject item in jarray_0)
		{
			string text = item[FA20611A]!.ToString();
			if (text == "")
			{
				continue;
			}
			list.Add(text);
			foreach (JProperty item2 in item.Properties())
			{
				if (!(item2.Name == FA20611A))
				{
					if (!dictionary.ContainsKey(item2.Name))
					{
						dictionary.Add(item2.Name, new List<string>());
					}
					dictionary[item2.Name].Add("WHEN '" + text + "' THEN '" + item2.Value?.ToString() + "' ");
				}
			}
		}
		string text2 = "UPDATE accounts SET ";
		foreach (KeyValuePair<string, List<string>> item3 in dictionary)
		{
			string key = item3.Key;
			text2 = text2 + key + " = CASE " + FA20611A + " " + string.Join(" ", item3.Value) + " END, ";
		}
		text2 = text2.TrimEnd(' ', ',') + " WHERE " + FA20611A + " IN('" + string.Join("','", list) + "'); ";
		return Class53.smethod_1(text2) > 0;
	}

	public static bool smethod_6()
	{
		bool result = false;
		try
		{
			result = Class53.smethod_1("delete from files where id NOT IN (SELECT DISTINCT idfile FROM accounts) AND active=0") > 0;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static DataTable smethod_7()
	{
		DataTable result = new DataTable();
		try
		{
			string aA8B3E = "SELECT id, status FROM accounts";
			result = Class53.C3BFFDBD(aA8B3E);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable E62BDA25(List<string> list_0, bool A3966D0C = true)
	{
		DataTable result = new DataTable();
		try
		{
			string text = "";
			text = ((list_0 == null || list_0.Count == 0) ? ("where active=" + (A3966D0C ? 1 : 0)) : ("where idfile IN (" + string.Join(",", list_0) + ") AND active=" + (A3966D0C ? 1 : 0)));
			string aA8B3E = "SELECT '-1' as id, '" + F7AB102E.smethod_0("[Tất cả tình trạng]") + "' AS name UNION select DISTINCT '0' as id,info from accounts " + text + " ORDER BY id,name ASC";
			result = Class53.C3BFFDBD(aA8B3E);
		}
		catch
		{
		}
		return result;
	}

	public static List<string> smethod_8(List<string> B28F69B5)
	{
		List<string> list = new List<string>();
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)B28F69B5.Count * 1.0 / 100.0)));
			string text = "";
			for (int i = 0; i < num2; i++)
			{
				text = "INSERT INTO accounts(uid, pass,token,cookie1,email,name,friends,groups,birthday,gender,info,fa2,idfile,passmail,useragent,proxy,dateCreateAcc,dateImport,mailrecovery,passmailrecovery,active,ghiChu,location,backup) VALUES " + string.Join(",", B28F69B5.GetRange(num * i, (num * i + num <= B28F69B5.Count) ? num : (B28F69B5.Count % num)));
				list.Add(text);
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	public static string smethod_9(string B83A7F1A, string string_0, string B4AD46B2, string string_1, string string_2, string string_3, string string_4, string string_5, string FA83289E, string CA06689F, string string_6, string string_7, string string_8, string string_9, string C531A716, string string_10, string EB320F94, string string_11, string B717ADAF, string string_12, string string_13, string string_14)
	{
		string text = "";
		try
		{
			text = "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}',1,'{20}','{21}','{22}')";
			text = string.Format(text, B83A7F1A.Replace("'", "''"), string_0.Replace("'", "''"), B4AD46B2, string_1, string_2, string_3.Replace("'", "''"), string_4, string_5, FA83289E, CA06689F, string_6, string_7, string_8, string_9.Replace("'", "''"), C531A716, string_10, EB320F94, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), string_11, B717ADAF, string_12, string_13, string_14);
		}
		catch
		{
		}
		return text;
	}

	public static bool EB34450D(string E00DDFA3, string C29A7685, string AC0C299F)
	{
		bool result = false;
		try
		{
			if (GClass25.D311242C())
			{
				List<string> list = new List<string> { "pass", "interactEnd", "info", "status282" };
				if (!list.Contains(C29A7685))
				{
					return true;
				}
			}
			string text = "";
			if (C29A7685 == "pass")
			{
				text += ",pass_old=pass";
			}
			if (C29A7685 == "email")
			{
				text += ",email_old=email";
			}
			if (C29A7685 == "uid" && AC0C299F.ToString().Trim() == "")
			{
				return false;
			}
			if (C29A7685 == "cookie1" && AC0C299F.ToString().Trim() == "")
			{
				return false;
			}
			string string_ = "update accounts set " + C29A7685 + " = '" + AC0C299F.Replace("'", "''") + "'" + text + " where id=" + E00DDFA3;
			return Class53.smethod_1(string_) > 0;
		}
		catch
		{
		}
		return result;
	}

	public static bool C888252E(string B512372F, string B0A2D805, string D92B1A28, bool bool_0 = true)
	{
		bool result = false;
		try
		{
			if (B0A2D805.Split('|').Length == D92B1A28.Split('|').Length)
			{
				int num = B0A2D805.Split('|').Length;
				string text = "";
				for (int i = 0; i < num; i++)
				{
					if (bool_0 || !(D92B1A28.Split('|')[i].Trim() == ""))
					{
						text = text + B0A2D805.Split('|')[i] + "='" + D92B1A28.Split('|')[i].Replace("'", "''") + "',";
					}
				}
				text = text.TrimEnd(',');
				string string_ = "update accounts set " + text + " where id=" + B512372F;
				result = Class53.smethod_1(string_) > 0;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool A49A61BA(List<string> list_0, string string_0, string EA82C338)
	{
		bool result = false;
		try
		{
			if (string_0.Split('|').Length == EA82C338.Split('|').Length)
			{
				int num = string_0.Split('|').Length;
				string text = "";
				for (int i = 0; i < num; i++)
				{
					string text2 = string_0.Split('|')[i];
					text = text + text2 + "='" + EA82C338.Split('|')[i].Replace("'", "''") + "',";
					if (text2 == "email")
					{
						text += "email_old=email,";
					}
				}
				text = text.TrimEnd(',');
				int num2 = 100;
				int num3 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
				List<string> list = new List<string>();
				string text3 = "";
				for (int j = 0; j < num3; j++)
				{
					text3 = "update accounts set " + text + " where id IN (" + string.Join(",", list_0.GetRange(num2 * j, (num2 * j + num2 <= list_0.Count) ? num2 : (list_0.Count % num2))) + ")";
					list.Add(text3);
				}
				if (Class53.smethod_0(list) > 0)
				{
					result = true;
					return result;
				}
				result = false;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_10(string string_0, string F8BFD810, string string_1)
	{
		bool result = false;
		try
		{
			string string_2 = "update files set " + F8BFD810 + " = '" + string_1.Replace("'", "''") + "' where id=" + string_0;
			if (Class53.smethod_1(string_2) > 0)
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool DB0FC1AC(List<string> CE059389, string string_0, string B69D49A9)
	{
		bool result = false;
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)CE059389.Count * 1.0 / 100.0)));
			List<string> list = new List<string>();
			string text = "";
			string text2 = "";
			if (string_0 == "pass")
			{
				text2 = ",pass_old=pass";
			}
			if (string_0 == "email")
			{
				text2 = ",email_old=email";
			}
			for (int i = 0; i < num2; i++)
			{
				text = "update accounts set " + string_0 + " = '" + B69D49A9.Replace("'", "''") + "'" + text2 + " where id IN (" + string.Join(",", CE059389.GetRange(num * i, (num * i + num <= CE059389.Count) ? num : (CE059389.Count % num))) + ")";
				list.Add(text);
			}
			return Class53.smethod_0(list) > 0;
		}
		catch (Exception ex)
		{
			GClass8.smethod_62(null, ex.ToString());
		}
		return result;
	}

	public static bool smethod_11(List<string> list_0, string EC042991, string CA24E612)
	{
		bool result = true;
		try
		{
			string string_ = "update files set " + EC042991 + " = '" + CA24E612 + "' where id IN (" + string.Join(",", list_0) + ")";
			if (Class53.smethod_1(string_) > 0)
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static DataTable E2B3A014(List<string> AEA1E0A2 = null, string C80D0802 = "", bool bool_0 = true)
	{
		DataTable result = new DataTable();
		try
		{
			string text = "WHERE ";
			string text2 = ((AEA1E0A2 == null || AEA1E0A2.Count <= 0) ? "" : ("t1.idFile IN (" + string.Join(",", AEA1E0A2) + ")"));
			if (text2 != "")
			{
				text = text + text2 + " AND ";
			}
			string text3 = ((C80D0802 != "") ? ("t1.info = '" + C80D0802 + "'") : "");
			if (text3 != "")
			{
				text = text + text3 + " AND ";
			}
			string text4 = $"t1.active = '{(bool_0 ? 1 : 0)}'";
			text += text4;
			string aA8B3E = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id " + text + " ORDER BY t1.idfile";
			result = Class53.C3BFFDBD(aA8B3E);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable C52782A9(List<string> A6826E90, bool bool_0 = true, bool bool_1 = false)
	{
		DataTable result = new DataTable();
		try
		{
			if (A6826E90[0].Contains("Mozilla") || bool_1)
			{
				int num = 100;
				int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)A6826E90.Count * 1.0 / 100.0)));
				List<string> list = new List<string>();
				string text = "";
				for (int i = 0; i < num2; i++)
				{
					text = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.useragent IN ('" + string.Join("','", A6826E90.GetRange(num * i, (num * i + num <= A6826E90.Count) ? num : (A6826E90.Count % num))) + "') and t1.active=" + (bool_0 ? "1" : "0") + " ORDER BY t1.useragent";
					list.Add(text);
				}
				result = Class53.F93D3308(list);
			}
			else if (A6826E90[0].StartsWith("@"))
			{
				A6826E90 = A6826E90.Select((string string_0) => string_0.ToLower()).ToList();
				List<string> list2 = new List<string>();
				string text2 = "";
				for (int j = 0; j < A6826E90.Count; j++)
				{
					text2 = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.email Like ('%" + A6826E90[j] + "%') and t1.active=" + (bool_0 ? "1" : "0");
					list2.Add(text2);
				}
				result = Class53.F93D3308(list2);
			}
			else if (A6826E90[0].Contains("@"))
			{
				A6826E90 = A6826E90.Select((string B913120C) => B913120C.ToLower()).ToList();
				int num3 = 100;
				int num4 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)A6826E90.Count * 1.0 / 100.0)));
				List<string> list3 = new List<string>();
				string text3 = "";
				for (int k = 0; k < num4; k++)
				{
					text3 = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.email IN ('" + string.Join("','", A6826E90.GetRange(num3 * k, (num3 * k + num3 <= A6826E90.Count) ? num3 : (A6826E90.Count % num3))) + "') and t1.active=" + (bool_0 ? "1" : "0") + " ORDER BY t1.email";
					list3.Add(text3);
				}
				result = Class53.F93D3308(list3);
			}
			else
			{
				int num5 = 5000;
				int num6 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)A6826E90.Count * 1.0 / 5000.0)));
				List<string> list4 = new List<string>();
				string text4 = "";
				for (int l = 0; l < num6; l++)
				{
					text4 = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.uid IN ('" + string.Join("','", A6826E90.GetRange(num5 * l, (num5 * l + num5 <= A6826E90.Count) ? num5 : (A6826E90.Count % num5))) + "') and t1.active=" + (bool_0 ? "1" : "0") + " ORDER BY t1.uid";
					list4.Add(text4);
				}
				result = Class53.F93D3308(list4);
			}
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA, "GetAccFromFile");
		}
		return result;
	}

	public static DataTable smethod_12(List<string> D582FA85)
	{
		DataTable result = new DataTable();
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)D582FA85.Count * 1.0 / 100.0)));
			List<string> list = new List<string>();
			string text = "";
			for (int i = 0; i < num2; i++)
			{
				text = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.email IN ('" + string.Join("','", D582FA85.GetRange(num * i, (num * i + num <= D582FA85.Count) ? num : (D582FA85.Count % num))) + "') and t1.active=1 ORDER BY t1.email";
				list.Add(text);
			}
			result = Class53.F93D3308(list);
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA, "GetAccFromFile");
		}
		return result;
	}

	public static DataTable smethod_13(bool bool_0 = true)
	{
		DataTable result = new DataTable();
		try
		{
			string aA8B3E = $"select uid from accounts where active={(bool_0 ? 1 : 0)};";
			result = Class53.C3BFFDBD(aA8B3E);
		}
		catch
		{
		}
		return result;
	}

	public static bool EF358DA6(string string_0)
	{
		bool result = true;
		try
		{
			if (Class53.smethod_1("UPDATE accounts SET active=0, dateDelete='" + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "' where idfile=" + string_0) > 0)
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool DCAE2192(string string_0)
	{
		try
		{
			return Class53.smethod_1("UPDATE accounts SET active=0, dateDelete='" + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "' where id=" + string_0) > 0;
		}
		catch
		{
		}
		return false;
	}

	public static DataTable smethod_14(List<string> list_0)
	{
		DataTable result = new DataTable();
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
			List<string> list = new List<string>();
			string text = "";
			for (int i = 0; i < num2; i++)
			{
				text = "SELECT uid, pass, token, cookie1,email, passmail, fa2 FROM accounts WHERE id IN ('" + string.Join("','", list_0.GetRange(num * i, (num * i + num <= list_0.Count) ? num : (list_0.Count % num))) + "')";
				list.Add(text);
			}
			result = Class53.F93D3308(list);
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA, "GetAccFromFile");
		}
		return result;
	}

	public static bool A7BEDD3C(List<string> list_0, bool C1A3C025 = false)
	{
		if (C1A3C025)
		{
			List<string> list = new List<string>();
			DataTable dataTable = smethod_14(list_0);
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				string text = "";
				for (int j = 0; j < dataTable.Columns.Count; j++)
				{
					text = text + dataTable.Rows[i][j].ToString() + "|";
				}
				text = text.Substring(0, text.Length - 1);
				list.Add(text);
			}
			File.AppendAllText("bin.txt", "======" + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "======\r\n");
			File.AppendAllLines("bin.txt", list);
		}
		bool result = true;
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
			List<string> list2 = new List<string>();
			string text2 = "";
			for (int k = 0; k < num2; k++)
			{
				text2 = ((!C1A3C025) ? ("UPDATE accounts SET active=0, dateDelete='" + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "' where id IN (" + string.Join(",", list_0.GetRange(num * k, (num * k + num <= list_0.Count) ? num : (list_0.Count % num))) + ")") : ("delete from accounts where id IN (" + string.Join(",", list_0.GetRange(num * k, (num * k + num <= list_0.Count) ? num : (list_0.Count % num))) + ")"));
				list2.Add(text2);
			}
			for (int l = 0; l < list2.Count; l++)
			{
				result = Class53.smethod_1(list2[l]) > 0;
			}
			return result;
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA, "DeleteAccountToDatabase");
			return result;
		}
	}

	public static bool smethod_15(string string_0)
	{
		string[] array = string_0.Split('|');
		string text = array[0];
		if (text.Trim() == "")
		{
			return false;
		}
		string text2 = array[1];
		string text3 = array[2];
		string text4 = array[3];
		string text5 = array[4];
		string text6 = array[5];
		string text7 = array[6];
		string text8 = array[7];
		string text9 = array[8];
		string text10 = array[9];
		string text11 = array[10];
		string text12 = array[11];
		string text13 = array[12];
		string text14 = array[13];
		string text15 = array[14];
		string text16 = array[15];
		string text17 = array[16];
		List<string> list = new List<string>();
		list.Add((text2 != "") ? ("pass|" + text2) : "");
		list.Add((text3 != "") ? ("token|" + text3) : "");
		list.Add((text4 != "") ? ("cookie1|" + text4) : "");
		list.Add((text5 != "") ? ("email|" + text5) : "");
		list.Add((text6 != "") ? ("passmail|" + text6) : "");
		list.Add((text7 != "") ? ("fa2|" + text7) : "");
		list.Add((text8 != "") ? ("useragent|" + text8) : "");
		list.Add((text9 != "") ? ("proxy|" + text9) : "");
		list.Add((text10 != "") ? ("birthday|" + text10) : "");
		list.Add((text11 != "") ? ("friends|" + text11) : "");
		list.Add((text12 != "") ? ("gender|" + text12) : "");
		list.Add((text13 != "") ? ("dateCreateAcc|" + text13) : "");
		list.Add((text14 != "") ? ("mailrecovery|" + text14) : "");
		list.Add((text15 != "") ? ("passmailrecovery|" + text15) : "");
		list.Add((text16 != "") ? ("ghiChu|" + text16) : "");
		list.Add((text17 != "") ? ("interactEnd|" + text17) : "");
		string text18 = "update accounts set";
		foreach (string item in list)
		{
			if (!(item == ""))
			{
				text18 = text18 + " " + item.Split('|')[0] + "='" + item.Split('|')[1] + "',";
				if (item.Split('|')[0] == "pass")
				{
					text18 += "pass_old=pass,";
				}
				if (item.Split('|')[0] == "email")
				{
					text18 += "email_old=email,";
				}
			}
		}
		text18 = text18.TrimEnd(',');
		text18 = text18 + " where uid='" + text + "'";
		return Class53.smethod_1(text18) > 0;
	}

	public static JObject B90DCC85(string D5B3271A)
	{
		string[] array = D5B3271A.Split('|');
		string text = array[0].Trim();
		string text2 = array[4].Trim();
		if (text == "" && text2 == "")
		{
			return null;
		}
		string text3 = array[1];
		string text4 = array[2];
		string text5 = array[3];
		string text6 = array[5];
		string text7 = array[6];
		string text8 = array[7];
		string text9 = array[8];
		string text10 = array[9];
		string text11 = array[10];
		string text12 = array[11];
		string text13 = array[12];
		string text14 = array[13];
		string text15 = array[14];
		string text16 = array[15];
		string text17 = array[16];
		string text18 = array[17];
		string text19 = array[18];
		JObject jObject = new JObject();
		if (text != "")
		{
			jObject["uid"] = (JToken)text;
		}
		if (text3 != "")
		{
			jObject["pass"] = (JToken)text3;
		}
		if (text4 != "")
		{
			jObject["token"] = (JToken)text4;
		}
		if (text5 != "")
		{
			jObject["cookie1"] = (JToken)text5;
		}
		if (text2 != "")
		{
			jObject["email"] = (JToken)text2;
		}
		if (text6 != "")
		{
			jObject["passmail"] = (JToken)text6;
		}
		if (text7 != "")
		{
			jObject["fa2"] = (JToken)text7;
		}
		if (text8 != "")
		{
			jObject["useragent"] = (JToken)text8;
		}
		if (text9 != "")
		{
			jObject["proxy"] = (JToken)text9;
		}
		if (text10 != "")
		{
			jObject["birthday"] = (JToken)text10;
		}
		if (text11 != "")
		{
			jObject["friends"] = (JToken)text11;
		}
		if (text12 != "")
		{
			jObject["gender"] = (JToken)text12;
		}
		if (text13 != "")
		{
			jObject["dateCreateAcc"] = (JToken)text13;
		}
		if (text14 != "")
		{
			jObject["mailrecovery"] = (JToken)text14;
		}
		if (text15 != "")
		{
			jObject["passmailrecovery"] = (JToken)text15;
		}
		if (text16 != "")
		{
			jObject["ghiChu"] = (JToken)text16;
		}
		if (text17 != "")
		{
			jObject["interactEnd"] = (JToken)text17;
		}
		if (text18 + "|" + text19 != "|")
		{
			jObject["backup"] = (JToken)(text18 + "|" + text19);
		}
		return jObject;
	}

	public static string smethod_16(string E821830B)
	{
		try
		{
			return Class53.smethod_2("SELECT idFile FROM accounts WHERE id='" + E821830B + "'").ToString();
		}
		catch
		{
		}
		return "";
	}

	public static bool ADBBA9AA(string EB0AA908, string string_0)
	{
		return Class53.smethod_2("SELECT COUNT(*) AS count FROM pragma_table_info('" + EB0AA908 + "') WHERE name='" + string_0 + "'") > 0;
	}

	public static bool B8BC5C08(string B3BFF8A0)
	{
		return Class53.smethod_2("SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name='" + B3BFF8A0 + "';") > 0;
	}

	public static bool smethod_17(string string_0, string CD2FF80B, int B08EBE20)
	{
		bool result = false;
		try
		{
			if (ADBBA9AA(string_0, CD2FF80B))
			{
				return true;
			}
			if (Class53.smethod_1("ALTER TABLE " + string_0 + " ADD COLUMN '" + CD2FF80B + "' " + ((B08EBE20 == 0) ? "INT" : "TEXT") + ";") > 0)
			{
				result = true;
			}
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_18(string string_0, string string_1, string FE393AA9)
	{
		bool result = true;
		try
		{
			string aA8B3E = "INSERT INTO interacts(uid, timeInteract,hanhDong,cauHinh) VALUES ('" + string_0 + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + string_1 + "','" + FE393AA9 + "')";
			Class53.C3BFFDBD(aA8B3E);
			return result;
		}
		catch
		{
			return false;
		}
	}

	public static List<BBA6CAB0> smethod_19(string A43C819B)
	{
		List<BBA6CAB0> result = new List<BBA6CAB0>();
		try
		{
			string string_ = "select id, tenChuDe,ngaytao,tieude,anh,video,noidung from BaiViet WHERE id = " + A43C819B;
			DataTable source = C009781E.C009781E_0.method_0(string_);
			result = (from dataRow_0 in source.AsEnumerable()
				select new BBA6CAB0
				{
					Int32_0 = Convert.ToInt32(dataRow_0["id"]),
					String_0 = Convert.ToString(dataRow_0["tenChuDe"]),
					BF907F85 = Convert.ToString(dataRow_0["ngaytao"]),
					EF0AA8B3 = Convert.ToString(dataRow_0["anh"]),
					D52B6012 = Convert.ToString(dataRow_0["video"]),
					BA2E9E33 = Convert.ToString(dataRow_0["tieude"]),
					String_1 = Convert.ToString(dataRow_0["noidung"])
				}).ToList();
		}
		catch
		{
		}
		return result;
	}

	public static List<string> smethod_20()
	{
		List<string> list = new List<string>();
		try
		{
			string string_ = "select ten from ChuDe;";
			DataTable dataTable = C009781E.C009781E_0.method_0(string_);
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				list.Add(dataTable.Rows[i][0].ToString());
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<BBA6CAB0> smethod_21(string D28AEE84 = "")
	{
		List<BBA6CAB0> result = new List<BBA6CAB0>();
		try
		{
			string text = "";
			text = ((!(D28AEE84 != "")) ? "select id,tenchude,ngaytao,tieude,anh,video,noidung from BaiViet" : ("select id,tenchude,ngaytao,tieude,anh,video,noidung from BaiViet WHERE tenchude='" + D28AEE84 + "'"));
			DataTable source = C009781E.C009781E_0.method_0(text);
			result = (from FABEA829 in source.AsEnumerable()
				select new BBA6CAB0
				{
					Int32_0 = Convert.ToInt32(FABEA829["id"]),
					String_0 = Convert.ToString(FABEA829["tenChuDe"]),
					BF907F85 = Convert.ToString(FABEA829["ngaytao"]),
					EF0AA8B3 = Convert.ToString(FABEA829["anh"]),
					D52B6012 = Convert.ToString(FABEA829["video"]),
					BA2E9E33 = Convert.ToString(FABEA829["tieude"]),
					String_1 = Convert.ToString(FABEA829["noidung"])
				}).ToList();
		}
		catch
		{
		}
		return result;
	}

	public static bool CC321085(int DB165480)
	{
		bool result = false;
		if (C009781E.C009781E_0.method_1("delete from BaiViet where id=" + DB165480) > 0)
		{
			result = true;
		}
		return result;
	}

	public static bool smethod_22(string string_0)
	{
		bool flag = false;
		try
		{
			string string_ = "delete from ChuDe where ten='" + string_0 + "'";
			if (C009781E.C009781E_0.method_1(string_) > 0)
			{
				smethod_23(string_0);
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_23(string string_0)
	{
		bool result = false;
		if (C009781E.C009781E_0.method_1("delete from BaiViet where tenchude='" + string_0 + "'") > 0)
		{
			result = true;
		}
		return result;
	}

	public static bool E4044697(string string_0)
	{
		bool result = true;
		try
		{
			string string_ = "insert into ChuDe values('" + string_0 + "')";
			C009781E.C009781E_0.method_1(string_);
			return result;
		}
		catch
		{
			return false;
		}
	}

	public static List<BBA6CAB0> E53433A4()
	{
		List<BBA6CAB0> result = new List<BBA6CAB0>();
		try
		{
			string string_ = "select id, tenChuDe,ngaytao,tieude,anh,video,noidung from BaiViet ORDER BY id DESC LIMIT 1";
			DataTable source = C009781E.C009781E_0.method_0(string_);
			result = (from E6993B86 in source.AsEnumerable()
				select new BBA6CAB0
				{
					Int32_0 = Convert.ToInt32(E6993B86["id"]),
					String_0 = Convert.ToString(E6993B86["tenChuDe"]),
					BF907F85 = Convert.ToString(E6993B86["ngaytao"]),
					EF0AA8B3 = Convert.ToString(E6993B86["anh"]),
					D52B6012 = Convert.ToString(E6993B86["video"]),
					BA2E9E33 = Convert.ToString(E6993B86["tieude"]),
					String_1 = Convert.ToString(E6993B86["noidung"])
				}).ToList();
		}
		catch
		{
		}
		return result;
	}

	public static bool B200A787(int int_0, BBA6CAB0 bba6CAB0_0)
	{
		bool result = true;
		try
		{
			string text = "";
			if (bba6CAB0_0.BA2E9E33 != null)
			{
				text = text + "tieude = '" + bba6CAB0_0.BA2E9E33.Replace("'", "''") + "',";
			}
			if (bba6CAB0_0.EF0AA8B3 != null)
			{
				text = text + "anh = '" + bba6CAB0_0.EF0AA8B3 + "',";
			}
			if (bba6CAB0_0.String_1 != null)
			{
				text = text + "noidung = '" + bba6CAB0_0.String_1.Replace("'", "''") + "',";
			}
			if (bba6CAB0_0.BF907F85 != null)
			{
				text = text + "ngaytao = '" + bba6CAB0_0.BF907F85 + "',";
			}
			if (bba6CAB0_0.String_0 != null)
			{
				text = text + "tenchude = '" + bba6CAB0_0.String_0 + "',";
			}
			if (bba6CAB0_0.D52B6012 != null)
			{
				text = text + "video = '" + bba6CAB0_0.D52B6012 + "',";
			}
			text = text.TrimEnd(',');
			if (text != "")
			{
				string string_ = "UPDATE BaiViet SET " + text + " WHERE id=" + int_0;
				C009781E.C009781E_0.method_1(string_);
				return true;
			}
			return result;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_24(string string_0, string E809F526)
	{
		bool result = true;
		try
		{
			string string_ = "UPDATE ChuDe SET ten = '" + E809F526 + "' WHERE ten='" + string_0 + "'";
			if (C009781E.C009781E_0.method_1(string_) > 0)
			{
				List<BBA6CAB0> list = smethod_21(string_0);
				for (int i = 0; i < list.Count; i++)
				{
					B200A787(list[i].Int32_0, new BBA6CAB0
					{
						String_0 = E809F526
					});
				}
				return result;
			}
			return result;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_25(string string_0, BBA6CAB0 F19D0B29)
	{
		bool result = true;
		try
		{
			string string_ = "insert into BaiViet(tenChuDe, tieude, noidung, ngaytao, anh,video) values('" + string_0 + "','" + F19D0B29.BA2E9E33.Replace("'", "''") + "','" + F19D0B29.String_1.Replace("'", "''") + "','" + F19D0B29.BF907F85 + "','" + F19D0B29.EF0AA8B3 + "','" + F19D0B29.D52B6012 + "')";
			C009781E.C009781E_0.method_1(string_);
			return result;
		}
		catch
		{
			return false;
		}
	}

	internal static DataTable BF947E9E(string string_0)
	{
		DataTable result = new DataTable();
		try
		{
			string aA8B3E = "SELECT pass, cookie1, email, fa2, proxy FROM accounts WHERE uid='" + string_0 + "'AND active=1";
			result = Class53.C3BFFDBD(aA8B3E);
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA, "GetPassByUid");
		}
		return result;
	}

	public static DataTable smethod_26(List<string> list_0, bool bool_0 = true)
	{
		DataTable result = new DataTable();
		try
		{
			if (list_0[0].StartsWith("@"))
			{
				List<string> list = new List<string>();
				string text = "";
				for (int i = 0; i < list_0.Count; i++)
				{
					text = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.email Like ('%" + list_0[i] + "%') and t1.active=" + (bool_0 ? 1 : 0);
					list.Add(text);
				}
				result = Class53.F93D3308(list);
			}
			else if (list_0[0].Contains("@"))
			{
				int num = 100;
				int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
				List<string> list2 = new List<string>();
				string text2 = "";
				for (int j = 0; j < num2; j++)
				{
					text2 = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.email IN ('" + string.Join("','", list_0.GetRange(num * j, (num * j + num <= list_0.Count) ? num : (list_0.Count % num))) + "') and t1.active=" + (bool_0 ? 1 : 0) + " ORDER BY t1.email";
					list2.Add(text2);
				}
				result = Class53.F93D3308(list2);
			}
			else
			{
				int num3 = 100;
				int num4 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
				List<string> list3 = new List<string>();
				string text3 = "";
				for (int k = 0; k < num4; k++)
				{
					text3 = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.uid IN ('" + string.Join("','", list_0.GetRange(num3 * k, (num3 * k + num3 <= list_0.Count) ? num3 : (list_0.Count % num3))) + "') and t1.active=" + (bool_0 ? 1 : 0) + " ORDER BY t1.uid";
					list3.Add(text3);
				}
				result = Class53.F93D3308(list3);
			}
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA, "GetAccFromFile");
		}
		return result;
	}

	public static string smethod_27(string DFAE71A6)
	{
		try
		{
			DataTable dataTable = Class53.C3BFFDBD("SELECT email, passmail FROM accounts WHERE id = " + DFAE71A6);
			return dataTable.Rows[0]["email"]?.ToString() + "|" + dataTable.Rows[0]["passmail"];
		}
		catch (Exception)
		{
		}
		return "|";
	}

	public static bool smethod_28(List<string> list_0)
	{
		bool result = false;
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
			List<string> list = new List<string>();
			string text = "";
			for (int i = 0; i < num2; i++)
			{
				text = "update accounts set pass=pass_old, pass_old=pass where id IN (" + string.Join(",", list_0.GetRange(num * i, (num * i + num <= list_0.Count) ? num : (list_0.Count % num))) + ")";
				list.Add(text);
			}
			result = Class53.smethod_0(list) > 0;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_29(List<string> list_0)
	{
		bool result = false;
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
			List<string> list = new List<string>();
			string text = "";
			for (int i = 0; i < num2; i++)
			{
				text = "update accounts set email=email_old, email_old=email where id IN (" + string.Join(",", list_0.GetRange(num * i, (num * i + num <= list_0.Count) ? num : (list_0.Count % num))) + ")";
				list.Add(text);
			}
			result = Class53.smethod_0(list) > 0;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_30(string B9822435, string string_0)
	{
		bool result = false;
		try
		{
			string text = Class53.C3BFFDBD("SELECT STT FROM files WHERE id = " + B9822435).Rows[0]["STT"].ToString();
			string text2 = Class53.C3BFFDBD("SELECT STT FROM files WHERE id = " + string_0).Rows[0]["STT"].ToString();
			string string_ = "UPDATE files SET STT = " + text2 + " WHERE id = " + B9822435;
			string string_2 = "UPDATE files SET STT = " + text + " WHERE id = " + string_0;
			if (Class53.smethod_1(string_) > 0)
			{
				if (Class53.smethod_1(string_2) > 0)
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
}
