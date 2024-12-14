using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

public class GClass7
{
	private static GClass7 gclass7_0;

	private string string_0 = "Data Source=" + Class57.string_0 + "\\database\\db_maxcare.sqlite;Version=3;";

	private SQLiteConnection sqliteConnection_0 = null;

	public static GClass7 FC31D586
	{
		get
		{
			if (gclass7_0 == null)
			{
				gclass7_0 = new GClass7();
			}
			return gclass7_0;
		}
		private set
		{
			gclass7_0 = value;
		}
	}

	private GClass7()
	{
	}

	private void C48D7CAD()
	{
		try
		{
			string text = "Data Source=" + Class57.string_0 + "\\database\\db_maxcare.sqlite;Version=3;";
			if (text != string_0)
			{
				string_0 = text;
				if (sqliteConnection_0.State == ConnectionState.Open)
				{
					sqliteConnection_0.Close();
				}
				sqliteConnection_0.ConnectionString = string_0;
				sqliteConnection_0.Open();
			}
			else
			{
				if (sqliteConnection_0 == null)
				{
					sqliteConnection_0 = new SQLiteConnection(string_0);
				}
				if (sqliteConnection_0.State == ConnectionState.Closed)
				{
					sqliteConnection_0.Open();
				}
			}
		}
		catch (Exception exception_)
		{
			GClass8.smethod_62(exception_, "CheckConnectServer");
		}
	}

	public DataTable EE0E992F(string EA183832)
	{
		DataTable dataTable = new DataTable();
		try
		{
			C48D7CAD();
			SQLiteCommand cmd = new SQLiteCommand(EA183832, sqliteConnection_0);
			SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(cmd);
			sQLiteDataAdapter.Fill(dataTable);
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA, "ExecuteQuery");
		}
		return dataTable;
	}

	public DataTable method_0(List<string> list_0)
	{
		DataTable dataTable = new DataTable();
		try
		{
			C48D7CAD();
			for (int i = 0; i < list_0.Count; i++)
			{
				string commandText = list_0[i];
				SQLiteCommand cmd = new SQLiteCommand(commandText, sqliteConnection_0);
				SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(cmd);
				sQLiteDataAdapter.Fill(dataTable);
			}
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA, "ExecuteQuery");
		}
		return dataTable;
	}

	public int method_1(List<string> A5B25A20)
	{
		int result = 0;
		try
		{
			C48D7CAD();
			for (int i = 0; i < A5B25A20.Count; i++)
			{
				string commandText = A5B25A20[i];
				SQLiteCommand sQLiteCommand = new SQLiteCommand(commandText, sqliteConnection_0);
				result = sQLiteCommand.ExecuteNonQuery();
			}
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA, "ExecuteNonQuery");
		}
		return result;
	}

	public int E79BF93A(string D70D0BBC)
	{
		int result = 0;
		try
		{
			C48D7CAD();
			SQLiteCommand sQLiteCommand = new SQLiteCommand(D70D0BBC, sqliteConnection_0);
			result = sQLiteCommand.ExecuteNonQuery();
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA, "ExecuteNonQuery: " + D70D0BBC);
		}
		return result;
	}

	public int AC15A506(string B71DF39A)
	{
		int result = 0;
		try
		{
			C48D7CAD();
			SQLiteCommand sQLiteCommand = new SQLiteCommand(B71DF39A, sqliteConnection_0);
			long num = (long)sQLiteCommand.ExecuteScalar();
			result = (int)num;
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA, "ExecuteScalar: " + B71DF39A);
		}
		return result;
	}
}
