using System;
using System.Collections.Generic;
using System.Data;

internal class Class147
{
	public static bool smethod_0(string string_0, string string_1)
	{
		bool result = false;
		try
		{
			int num = GClass32.BC97849E.method_2("SELECT COUNT(*) AS count FROM pragma_table_info('" + string_0 + "') WHERE name='" + string_1 + "'");
			if (num > 0)
			{
				result = true;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool DF112787(string string_0, string EA281710, int int_0)
	{
		bool result = false;
		try
		{
			if (smethod_0(string_0, EA281710))
			{
				return true;
			}
			if (GClass32.BC97849E.D61A7A94("ALTER TABLE " + string_0 + " ADD COLUMN '" + EA281710 + "' " + ((int_0 == 0) ? "INT" : "TEXT") + ";") > 0)
			{
				result = true;
			}
		}
		catch
		{
		}
		return result;
	}

	public static DataTable smethod_1(string BF9AC233)
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT * FROM Kich_Ban WHERE Id_KichBan = " + BF9AC233;
			result = GClass32.BC97849E.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static string E1199583(string B7A0A405)
	{
		string result = "";
		try
		{
			string string_ = "SELECT TenKichBan FROM Kich_Ban WHERE Id_KichBan = " + B7A0A405;
			result = GClass32.BC97849E.method_1(string_).Rows[0][0].ToString();
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static DataTable CD078893()
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "DROP TABLE IF EXISTS tmp;CREATE TEMPORARY TABLE tmp(Stt INTEGER PRIMARY KEY AUTOINCREMENT, Id_KichBan INTEGER, TenKichBan TEXT);INSERT INTO tmp (Id_KichBan, TenKichBan) SELECT Id_KichBan, TenKichBan FROM Kich_Ban ORDER BY STT;SELECT Id_KichBan, TenKichBan, (Stt||'. '||TenKichBan) AS Ten FROM tmp;";
			result = GClass32.BC97849E.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable smethod_2()
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT * FROM Kich_Ban ORDER BY Id_KichBan DESC LIMIT 1";
			result = GClass32.BC97849E.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static string C594AD33(string BCB93224)
	{
		string result = "";
		try
		{
			string string_ = "SELECT CauHinh FROM Kich_Ban WHERE Id_KichBan = " + BCB93224;
			result = GClass32.BC97849E.method_1(string_).Rows[0]["CauHinh"].ToString();
		}
		catch
		{
		}
		return result;
	}

	public static bool D606CE11(string E4A5E635, string string_0)
	{
		try
		{
			string dA98720E = "UPDATE Kich_Ban SET CauHinh = '" + string_0.Replace("'", "''") + "' WHERE Id_KichBan = " + E4A5E635;
			return GClass32.BC97849E.D61A7A94(dA98720E) > 0;
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_3(string E9A0062D)
	{
		try
		{
			string string_ = "SELECT Id_KichBan FROM Kich_Ban WHERE TenKichBan = '" + E9A0062D.Replace("'", "''") + "'";
			if (GClass32.BC97849E.method_1(string_).Rows.Count > 0)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool C49AC90F(string string_0, string string_1)
	{
		bool result = false;
		try
		{
			string dA98720E = "INSERT INTO Kich_Ban (TenKichBan, STT) VALUES ('" + string_0 + "', " + string_1 + ")";
			if (GClass32.BC97849E.D61A7A94(dA98720E) > 0)
			{
				result = true;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_4(string B8A2B2BC, string string_0)
	{
		bool result = false;
		try
		{
			string dA98720E = "UPDATE Kich_Ban SET TenKichBan = '" + string_0.Replace("'", "''") + "' WHERE Id_KichBan = " + B8A2B2BC;
			if (GClass32.BC97849E.D61A7A94(dA98720E) > 0)
			{
				result = true;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_5(string string_0)
	{
		bool result = false;
		try
		{
			string dA98720E = "DELETE FROM Kich_Ban WHERE Id_KichBan = " + string_0;
			if (GClass32.BC97849E.D61A7A94(dA98720E) > 0)
			{
				FDA04F8C(string_0);
				result = true;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_6(string string_0, string string_1)
	{
		bool result = false;
		try
		{
			string text = "";
			try
			{
				text = GClass32.BC97849E.method_1("SELECT STT FROM Kich_Ban ORDER BY STT DESC LIMIT 1").Rows[0]["STT"].ToString();
			}
			catch
			{
			}
			text = ((text == "") ? "1" : (Convert.ToInt32(text) + 1).ToString());
			if (C49AC90F(string_1, text))
			{
				string text2 = smethod_2().Rows[0]["Id_KichBan"].ToString();
				DataTable dataTable = GClass32.BC97849E.method_1("SELECT * FROM Hanh_Dong WHERE Id_KichBan = " + string_0);
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					string dA98720E = "INSERT INTO Hanh_Dong (STT,Id_KichBan, TenHanhDong, Id_TuongTac, CauHinh) VALUES (" + dataTable.Rows[i]["STT"].ToString() + "," + text2 + ", '" + dataTable.Rows[i]["TenHanhDong"].ToString() + "', " + dataTable.Rows[i]["Id_TuongTac"].ToString() + ", '" + dataTable.Rows[i]["CauHinh"].ToString().Replace("'", "''") + "')";
					GClass32.BC97849E.D61A7A94(dA98720E);
				}
				result = true;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static DataTable smethod_7(string string_0 = "", string string_1 = "")
	{
		DataTable result = new DataTable();
		try
		{
			string text = "";
			if (string_0 != "")
			{
				text = text + "Id_TuongTac = " + string_0 + " AND ";
			}
			if (string_1 != "")
			{
				text = text + "TenTuongTac = '" + string_1.Replace("'", "''") + "'";
			}
			if (text != "")
			{
				if (text.EndsWith(" AND "))
				{
					text = text.Replace(" AND ", "");
				}
				string string_2 = "SELECT * FROM Tuong_Tac WHERE " + text;
				result = GClass32.BC97849E.method_1(string_2);
			}
		}
		catch
		{
		}
		return result;
	}

	internal static void smethod_8(string string_0, string string_1)
	{
		DataTable dataTable = smethod_7("", string_0);
		if (dataTable.Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO main.Tuong_Tac (TenTuongTac, MoTa) VALUES ('" + string_0.Replace("'", "''") + "', '" + string_1.Replace("'", "''") + "');");
		}
		else
		{
			string text = dataTable.Rows[0]["MoTa"].ToString();
			if (text != string_1)
			{
				GClass32.BC97849E.D61A7A94(string.Format("UPDATE main.Tuong_Tac SET MoTa='{0}' WHERE Id_TuongTac={1};", string_1.Replace("'", "''"), dataTable.Rows[0]["Id_TuongTac"]));
			}
		}
	}

	public static DataTable smethod_9(string C30B3F84)
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT t1.Id_HanhDong, t1.TenHanhDong,t2.Id_TuongTac,t2.TenTuongTac, t2.MoTa FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac WHERE t1.Id_KichBan = " + C30B3F84 + " ORDER BY t1.STT";
			result = GClass32.BC97849E.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable F3057616(string C3887536)
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT t1.TenHanhDong,t1.CauHinh,t2.Id_TuongTac,t2.TenTuongTac, t2.MoTa FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac WHERE t1.Id_HanhDong = " + C3887536;
			result = GClass32.BC97849E.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable smethod_10()
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT t1.Id_HanhDong,t1.TenHanhDong,t1.CauHinh,t2.Id_TuongTac,t2.TenTuongTac, t2.MoTa FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac ORDER BY Id_HanhDong DESC LIMIT 1";
			result = GClass32.BC97849E.method_1(string_);
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_11(string C48161BB)
	{
		try
		{
			string string_ = "SELECT Id_HanhDong FROM Hanh_Dong WHERE TenHanhDong = '" + C48161BB.Replace("'", "''") + "'";
			if (GClass32.BC97849E.method_1(string_).Rows.Count > 0)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_12(string EE8D5B87, string DE1561B3, string string_0, string string_1)
	{
		bool result = false;
		try
		{
			string text = "";
			try
			{
				text = GClass32.BC97849E.method_1("SELECT STT FROM Hanh_Dong WHERE Id_KichBan = " + EE8D5B87 + " ORDER BY STT DESC LIMIT 1").Rows[0]["STT"].ToString();
			}
			catch
			{
			}
			text = ((text == "") ? "1" : (Convert.ToInt32(text) + 1).ToString());
			string_1 = string_1.Replace("'", "''");
			string dA98720E = "INSERT INTO Hanh_Dong (STT,Id_KichBan, TenHanhDong, Id_TuongTac, CauHinh) VALUES (" + text + "," + EE8D5B87 + ", '" + DE1561B3.Replace("'", "''") + "', " + string_0 + ", '" + string_1.Replace("'", "''") + "')";
			if (GClass32.BC97849E.D61A7A94(dA98720E) > 0)
			{
				result = true;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool B7065637(string string_0, string string_1)
	{
		bool result = false;
		try
		{
			DataTable dataTable = GClass32.BC97849E.method_1("SELECT * FROM Hanh_Dong WHERE Id_HanhDong = " + string_0);
			string text = "";
			try
			{
				text = GClass32.BC97849E.method_1("SELECT STT FROM Hanh_Dong WHERE Id_KichBan = " + dataTable.Rows[0]["Id_KichBan"].ToString() + " ORDER BY STT DESC LIMIT 1").Rows[0]["STT"].ToString();
			}
			catch
			{
			}
			text = ((text == "") ? "1" : (Convert.ToInt32(text) + 1).ToString());
			string dA98720E = "INSERT INTO Hanh_Dong (STT,Id_KichBan, TenHanhDong, Id_TuongTac, CauHinh) VALUES (" + text + "," + dataTable.Rows[0]["Id_KichBan"].ToString() + ", '" + string_1.Replace("'", "''") + "', " + dataTable.Rows[0]["Id_TuongTac"].ToString() + ", '" + dataTable.Rows[0]["CauHinh"].ToString() + "')";
			if (GClass32.BC97849E.D61A7A94(dA98720E) > 0)
			{
				result = true;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_13(string string_0, string string_1 = "", string string_2 = "")
	{
		bool result = false;
		try
		{
			string text = "";
			if (string_1 != "")
			{
				text = text + "TenHanhDong = '" + string_1.Replace("'", "''") + "',";
			}
			if (string_2 != "")
			{
				text = text + "CauHinh = '" + string_2.Replace("'", "''") + "'";
			}
			if (text != "")
			{
				text = text.TrimEnd(',');
				string dA98720E = "UPDATE Hanh_Dong SET " + text + " WHERE Id_HanhDong = " + string_0;
				if (GClass32.BC97849E.D61A7A94(dA98720E) > 0)
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

	public static bool E416FA1A(string string_0, string AE9650AA)
	{
		bool result = false;
		try
		{
			string text = GClass32.BC97849E.method_1("SELECT STT FROM Kich_Ban WHERE Id_KichBan = " + string_0).Rows[0]["STT"].ToString();
			string text2 = GClass32.BC97849E.method_1("SELECT STT FROM Kich_Ban WHERE Id_KichBan = " + AE9650AA).Rows[0]["STT"].ToString();
			string dA98720E = "UPDATE Kich_Ban SET STT = " + text2 + " WHERE Id_KichBan = " + string_0;
			string dA98720E2 = "UPDATE Kich_Ban SET STT = " + text + " WHERE Id_KichBan = " + AE9650AA;
			if (GClass32.BC97849E.D61A7A94(dA98720E) > 0)
			{
				if (GClass32.BC97849E.D61A7A94(dA98720E2) > 0)
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

	public static bool smethod_14(string string_0, string string_1)
	{
		bool result = false;
		try
		{
			string text = GClass32.BC97849E.method_1("SELECT STT FROM Hanh_Dong WHERE Id_HanhDong = " + string_0).Rows[0]["STT"].ToString();
			string text2 = GClass32.BC97849E.method_1("SELECT STT FROM Hanh_Dong WHERE Id_HanhDong = " + string_1).Rows[0]["STT"].ToString();
			string dA98720E = "UPDATE Hanh_Dong SET STT = " + text2 + " WHERE Id_HanhDong = " + string_0;
			string dA98720E2 = "UPDATE Hanh_Dong SET STT = " + text + " WHERE Id_HanhDong = " + string_1;
			if (GClass32.BC97849E.D61A7A94(dA98720E) > 0)
			{
				if (GClass32.BC97849E.D61A7A94(dA98720E2) > 0)
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

	public static bool B5BAE58E(string string_0)
	{
		bool result = false;
		try
		{
			string dA98720E = "DELETE FROM Hanh_Dong WHERE Id_HanhDong = " + string_0;
			if (GClass32.BC97849E.D61A7A94(dA98720E) > 0)
			{
				result = true;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool FDA04F8C(string FDB531A7)
	{
		bool result = false;
		try
		{
			string dA98720E = "DELETE FROM Hanh_Dong WHERE Id_KichBan = " + FDB531A7;
			if (GClass32.BC97849E.D61A7A94(dA98720E) > 0)
			{
				result = true;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static List<string> smethod_15(string B6186183, string string_0)
	{
		List<string> list = new List<string>();
		try
		{
			string string_ = "SELECT t1.Id_HanhDong FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac WHERE t1.Id_KichBan = " + B6186183 + " AND t2.TenTuongTac = '" + string_0.Replace("'", "''") + "'";
			DataTable dataTable = GClass32.BC97849E.method_1(string_);
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				list.Add(dataTable.Rows[i]["Id_HanhDong"].ToString());
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<string> DCBEC933(string string_0, string A3137485)
	{
		List<string> list = new List<string>();
		try
		{
			string string_ = "SELECT t1.Id_HanhDong FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac WHERE t1.Id_KichBan = " + string_0;
			DataTable dataTable = GClass32.BC97849E.method_1(string_);
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				list.Add(dataTable.Rows[i]["Id_HanhDong"].ToString());
			}
		}
		catch
		{
		}
		return list;
	}

	public static string smethod_16(string F13E6A9B)
	{
		string result = "";
		try
		{
			string string_ = "SELECT CauHinh FROM Hanh_Dong WHERE Id_HanhDong = " + F13E6A9B;
			result = GClass32.BC97849E.method_1(string_).Rows[0]["CauHinh"].ToString();
		}
		catch
		{
		}
		return result;
	}
}
