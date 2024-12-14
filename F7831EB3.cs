using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

public class F7831EB3
{
	private string string_0;

	private SQLiteConnection F5A8ABAD = null;

	public F7831EB3(string string_1)
	{
		string_0 = string_1;
	}

	private void method_0()
	{
		try
		{
			if (F5A8ABAD == null)
			{
				F5A8ABAD = new SQLiteConnection("Data Source=" + string_0 + ";Version=3;");
			}
			if (F5A8ABAD.State == ConnectionState.Closed)
			{
				F5A8ABAD.Open();
			}
		}
		catch (Exception exception_)
		{
			GClass8.smethod_62(exception_, "CheckConnectServer");
		}
	}

	public DataTable FA0E931A(string string_1)
	{
		DataTable dataTable = new DataTable();
		try
		{
			method_0();
			SQLiteCommand cmd = new SQLiteCommand(string_1, F5A8ABAD);
			SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(cmd);
			sQLiteDataAdapter.Fill(dataTable);
		}
		catch
		{
		}
		return dataTable;
	}

	public int method_1(string string_1)
	{
		int result = 0;
		try
		{
			method_0();
			SQLiteCommand sQLiteCommand = new SQLiteCommand(string_1, F5A8ABAD);
			result = sQLiteCommand.ExecuteNonQuery();
		}
		catch (Exception)
		{
		}
		return result;
	}

	public int method_2(string string_1)
	{
		int result = -1;
		try
		{
			method_0();
			SQLiteCommand sQLiteCommand = new SQLiteCommand(string_1, F5A8ABAD);
			long num = (long)sQLiteCommand.ExecuteScalar();
			result = (int)num;
		}
		catch
		{
		}
		return result;
	}

	public List<string> method_3()
	{
		List<string> list = new List<string>();
		DataTable dataTable = FA0E931A("select name from sqlite_master;");
		for (int i = 0; i < dataTable.Rows.Count; i++)
		{
			list.Add(dataTable.Rows[i]["name"].ToString());
		}
		return list;
	}
}
