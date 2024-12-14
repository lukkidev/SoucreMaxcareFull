using System;
using System.Data;
using System.Data.SQLite;

public class GClass32
{
	private static GClass32 A0157A0B;

	private string string_0 = "Data Source=interact\\interact.sqlite;Version=3;";

	private SQLiteConnection sqliteConnection_0 = null;

	public static GClass32 BC97849E
	{
		get
		{
			if (A0157A0B == null)
			{
				A0157A0B = new GClass32();
			}
			return A0157A0B;
		}
		private set
		{
			A0157A0B = value;
		}
	}

	private GClass32()
	{
	}

	private void method_0()
	{
		try
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
		catch (Exception exception_)
		{
			GClass8.smethod_62(exception_, "CheckConnectServer");
		}
	}

	public DataTable method_1(string string_1)
	{
		DataTable dataTable = new DataTable();
		try
		{
			method_0();
			SQLiteCommand cmd = new SQLiteCommand(string_1, sqliteConnection_0);
			SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(cmd);
			sQLiteDataAdapter.Fill(dataTable);
		}
		catch
		{
		}
		return dataTable;
	}

	public int D61A7A94(string DA98720E)
	{
		int result = 0;
		try
		{
			method_0();
			SQLiteCommand sQLiteCommand = new SQLiteCommand(DA98720E, sqliteConnection_0);
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
			SQLiteCommand sQLiteCommand = new SQLiteCommand(string_1, sqliteConnection_0);
			long num = (long)sQLiteCommand.ExecuteScalar();
			result = (int)num;
		}
		catch
		{
		}
		return result;
	}
}
