using System;
using System.Collections.Generic;

public class GClass17
{
	private string D2380997;

	public GClass17()
	{
		D2380997 = "LogAddPhone";
		List<string> list = new List<string> { "timeCreated", "idOder", "phone", "otp", "status" };
		if (!Class57.A0BD9AA4.method_3().Contains(D2380997))
		{
			string text = "";
			for (int i = 0; i < list.Count; i++)
			{
				text = text + list[i] + " TEXT,";
			}
			string string_ = "\r\n                    CREATE TABLE " + D2380997 + " (\r\n\t                id INTEGER,\r\n\t                " + text + "\r\n\t                PRIMARY KEY(id AUTOINCREMENT)\r\n                )\r\n                ";
			Class57.A0BD9AA4.method_1(string_);
		}
	}

	public bool method_0(string E8B469B5, string string_0)
	{
		string string_ = "INSERT INTO " + D2380997 + " (timeCreated, idOder, phone) VALUES ('" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + E8B469B5 + "', '" + string_0 + "')";
		return Class57.A0BD9AA4.method_1(string_) > 0;
	}

	public bool method_1(string B5AE7E9C, string string_0)
	{
		string string_ = "UPDATE " + D2380997 + " SET otp = '" + string_0 + "' WHERE idOder = '" + B5AE7E9C + "'";
		return Class57.A0BD9AA4.method_1(string_) > 0;
	}

	public bool method_2(string A9BAEB06, string string_0)
	{
		string string_ = "UPDATE " + D2380997 + " SET status = '" + string_0 + "' WHERE idOder = '" + A9BAEB06 + "'";
		return Class57.A0BD9AA4.method_1(string_) > 0;
	}
}
