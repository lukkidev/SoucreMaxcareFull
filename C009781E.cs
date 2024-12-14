using System.Data;
using System.Data.SQLite;

public class C009781E
{
	private static C009781E c009781E_0;

	private string string_0 = "Data Source=database/db_post.db;Version=3;";

	public static C009781E C009781E_0
	{
		get
		{
			if (c009781E_0 == null)
			{
				c009781E_0 = new C009781E();
			}
			return c009781E_0;
		}
		private set
		{
			c009781E_0 = value;
		}
	}

	private C009781E()
	{
	}

	public DataTable method_0(string string_1)
	{
		DataTable dataTable = new DataTable();
		using (SQLiteConnection sQLiteConnection = new SQLiteConnection(string_0))
		{
			sQLiteConnection.Open();
			SQLiteCommand cmd = new SQLiteCommand(string_1, sQLiteConnection);
			SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(cmd);
			sQLiteDataAdapter.Fill(dataTable);
			sQLiteConnection.Close();
		}
		return dataTable;
	}

	public int method_1(string string_1)
	{
		int result = 0;
		try
		{
			using SQLiteConnection sQLiteConnection = new SQLiteConnection(string_0);
			sQLiteConnection.Open();
			SQLiteCommand sQLiteCommand = new SQLiteCommand(string_1, sQLiteConnection);
			result = sQLiteCommand.ExecuteNonQuery();
			sQLiteConnection.Close();
		}
		catch
		{
		}
		return result;
	}

	public object B482EB9A(string string_1)
	{
		object result = 0;
		using (SQLiteConnection sQLiteConnection = new SQLiteConnection(string_0))
		{
			sQLiteConnection.Open();
			SQLiteCommand sQLiteCommand = new SQLiteCommand(string_1, sQLiteConnection);
			long num = (long)sQLiteCommand.ExecuteScalar();
			result = (int)num;
			sQLiteConnection.Close();
		}
		return result;
	}
}
