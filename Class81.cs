using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;

internal class Class81
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A72C4215
	{
		public static readonly A72C4215 _003C_003E9 = new A72C4215();

		public static Func<DataRow, string> _003C_003E9__4_0;

		public static Func<DataRow, string> _003C_003E9__4_1;

		public static Func<DataRow, string> _003C_003E9__4_2;

		public static Func<IGrouping<string, DataRow>, string> _003C_003E9__4_3;

		public static Func<IGrouping<string, DataRow>, string> _003C_003E9__4_4;

		public static Func<KeyValuePair<string, string>, bool> _003C_003E9__5_0;

		public static Func<KeyValuePair<string, string>, string> _003C_003E9__5_1;

		internal string method_0(DataRow dataRow_0)
		{
			return dataRow_0[0].ToString();
		}

		internal string method_1(DataRow dataRow_0)
		{
			return dataRow_0[1].ToString();
		}

		internal string C492EA0B(DataRow dataRow_0)
		{
			return dataRow_0[0].ToString();
		}

		internal string F0A7DE0F(IGrouping<string, DataRow> igrouping_0)
		{
			return igrouping_0.Key;
		}

		internal string method_2(IGrouping<string, DataRow> igrouping_0)
		{
			return igrouping_0.First()[1].ToString();
		}

		internal bool method_3(KeyValuePair<string, string> F5250A14)
		{
			KeyValuePair<string, string> keyValuePair = F5250A14;
			return keyValuePair.Value.Trim() != "";
		}

		internal string B3AC472C(KeyValuePair<string, string> BDAB9D8C)
		{
			KeyValuePair<string, string> keyValuePair = BDAB9D8C;
			string key = keyValuePair.Key;
			keyValuePair = BDAB9D8C;
			return key + "|" + keyValuePair.Value;
		}
	}

	private static Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();

	public static bool bool_0 = false;

	public static string F7B1DA8C(string E93C4433)
	{
		if (!bool_0)
		{
			return "";
		}
		string result = "";
		if (dictionary_0.ContainsKey(E93C4433))
		{
			result = dictionary_0[E93C4433];
		}
		return result;
	}

	public static void smethod_0(string string_0, string string_1)
	{
		if (bool_0)
		{
			if (dictionary_0.ContainsKey(string_0))
			{
				dictionary_0[string_0] = string_1;
			}
			else
			{
				dictionary_0.Add(string_0, string_1);
			}
		}
	}

	public static void smethod_1()
	{
		if (!bool_0)
		{
			return;
		}
		DataTable source = Class15.smethod_7();
		try
		{
			dictionary_0 = source.AsEnumerable().ToDictionary((DataRow dataRow_0) => dataRow_0[0].ToString(), (DataRow dataRow_0) => dataRow_0[1].ToString());
		}
		catch
		{
			dictionary_0 = (from dataRow_0 in source.AsEnumerable()
				group dataRow_0 by dataRow_0[0].ToString()).ToDictionary((IGrouping<string, DataRow> igrouping_0) => igrouping_0.Key, (IGrouping<string, DataRow> igrouping_0) => igrouping_0.First()[1].ToString());
		}
	}

	public static void smethod_2()
	{
		if (bool_0)
		{
			List<string> b = dictionary_0.Where(delegate(KeyValuePair<string, string> F5250A14)
			{
				KeyValuePair<string, string> keyValuePair2 = F5250A14;
				return keyValuePair2.Value.Trim() != "";
			}).Select(delegate(KeyValuePair<string, string> BDAB9D8C)
			{
				KeyValuePair<string, string> keyValuePair = BDAB9D8C;
				string key = keyValuePair.Key;
				keyValuePair = BDAB9D8C;
				return key + "|" + keyValuePair.Value;
			}).ToList();
			Class15.smethod_4("status", b);
		}
	}
}
