using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

public class GClass11
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A30FC284
	{
		public static readonly A30FC284 _003C_003E9 = new A30FC284();

		public static Func<KeyValuePair<string, object>, global::ACBAA713<KeyValuePair<string, object>, string>> _003C_003E9__3_0;

		public static Func<global::ACBAA713<KeyValuePair<string, object>, string>, Class0<global::ACBAA713<KeyValuePair<string, object>, string>, object>> _003C_003E9__3_1;

		public static Func<Class0<global::ACBAA713<KeyValuePair<string, object>, string>, object>, bool> _003C_003E9__3_2;

		public static Func<Class0<global::ACBAA713<KeyValuePair<string, object>, string>, object>, string> _003C_003E9__3_3;

		public static Func<KeyValuePair<string, object>, global::ACBAA713<KeyValuePair<string, object>, string>> _003C_003E9__3_4;

		public static Func<global::ACBAA713<KeyValuePair<string, object>, string>, Class0<global::ACBAA713<KeyValuePair<string, object>, string>, object>> _003C_003E9__3_5;

		public static Func<Class0<global::ACBAA713<KeyValuePair<string, object>, string>, object>, bool> _003C_003E9__3_6;

		public static Func<Class0<global::ACBAA713<KeyValuePair<string, object>, string>, object>, string> _003C_003E9__3_7;

		public static Func<JToken, object> _003C_003E9__3_10;

		public static Func<string, bool> _003C_003E9__11_0;

		internal global::ACBAA713<KeyValuePair<string, object>, string> method_0(KeyValuePair<string, object> keyValuePair_0)
		{
			KeyValuePair<string, object> keyValuePair = keyValuePair_0;
			return new global::ACBAA713<KeyValuePair<string, object>, string>(keyValuePair_0, keyValuePair.Key);
		}

		internal Class0<global::ACBAA713<KeyValuePair<string, object>, string>, object> method_1(global::ACBAA713<KeyValuePair<string, object>, string> CA9DA639)
		{
			return new Class0<global::ACBAA713<KeyValuePair<string, object>, string>, object>(CA9DA639, CA9DA639.EEAD6F95.Value);
		}

		internal bool method_2(Class0<global::ACBAA713<KeyValuePair<string, object>, string>, object> CE36800F)
		{
			return CE36800F.Prop_0.GetType() == typeof(JObject);
		}

		internal string method_3(Class0<global::ACBAA713<KeyValuePair<string, object>, string>, object> class0_0)
		{
			return class0_0.BA238E0F.C7296323;
		}

		internal global::ACBAA713<KeyValuePair<string, object>, string> F231009D(KeyValuePair<string, object> keyValuePair_0)
		{
			KeyValuePair<string, object> keyValuePair = keyValuePair_0;
			return new global::ACBAA713<KeyValuePair<string, object>, string>(keyValuePair_0, keyValuePair.Key);
		}

		internal Class0<global::ACBAA713<KeyValuePair<string, object>, string>, object> method_4(global::ACBAA713<KeyValuePair<string, object>, string> acbaa713_0)
		{
			return new Class0<global::ACBAA713<KeyValuePair<string, object>, string>, object>(acbaa713_0, acbaa713_0.EEAD6F95.Value);
		}

		internal bool B5AEFE39(Class0<global::ACBAA713<KeyValuePair<string, object>, string>, object> class0_0)
		{
			return class0_0.Prop_0.GetType() == typeof(JArray);
		}

		internal string method_5(Class0<global::ACBAA713<KeyValuePair<string, object>, string>, object> class0_0)
		{
			return class0_0.BA238E0F.C7296323;
		}

		internal object method_6(JToken jtoken_0)
		{
			return ((JValue)jtoken_0).Value;
		}

		internal bool BDB2B41F(string B398398E)
		{
			return B398398E.Contains("\n");
		}
	}

	[CompilerGenerated]
	private sealed class Class16
	{
		public Dictionary<string, object> dictionary_0;

		public GClass11 gclass11_0;

		internal void C3237D81(string string_0)
		{
			dictionary_0[string_0] = (from jtoken_0 in ((JArray)dictionary_0[string_0]).Values()
				select ((JValue)jtoken_0).Value).ToArray();
		}

		internal void method_0(string F42B8499)
		{
			dictionary_0[F42B8499] = gclass11_0.method_0(dictionary_0[F42B8499] as JObject);
		}
	}

	private string string_0;

	private JObject jobject_0;

	public GClass11(string string_1, bool bool_0 = false)
	{
		try
		{
			if (bool_0)
			{
				if (string_1.Trim() == "")
				{
					string_1 = "{}";
				}
				jobject_0 = JObject.Parse(string_1);
				return;
			}
			string_0 = "settings\\" + string_1 + ".json";
			if (!File.Exists(string_0))
			{
				using (File.AppendText(string_0))
				{
				}
			}
			jobject_0 = JObject.Parse(File.ReadAllText(string_0));
		}
		catch
		{
			jobject_0 = new JObject();
		}
	}

	public Dictionary<string, object> method_0(JObject jobject_1 = null)
	{
		Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();
		try
		{
			if (jobject_1 == null)
			{
				jobject_1 = jobject_0;
			}
			dictionary_0 = jobject_1.ToObject<Dictionary<string, object>>();
			List<string> list = (from CA9DA639 in dictionary_0.Select(delegate(KeyValuePair<string, object> keyValuePair_0)
				{
					KeyValuePair<string, object> keyValuePair2 = keyValuePair_0;
					return new global::ACBAA713<KeyValuePair<string, object>, string>(keyValuePair_0, keyValuePair2.Key);
				})
				select new Class0<global::ACBAA713<KeyValuePair<string, object>, string>, object>(CA9DA639, CA9DA639.EEAD6F95.Value) into CE36800F
				where CE36800F.Prop_0.GetType() == typeof(JObject)
				select CE36800F into class0_0
				select class0_0.BA238E0F.C7296323).ToList();
			List<string> list2 = (from acbaa713_0 in dictionary_0.Select(delegate(KeyValuePair<string, object> keyValuePair_0)
				{
					KeyValuePair<string, object> keyValuePair = keyValuePair_0;
					return new global::ACBAA713<KeyValuePair<string, object>, string>(keyValuePair_0, keyValuePair.Key);
				})
				select new Class0<global::ACBAA713<KeyValuePair<string, object>, string>, object>(acbaa713_0, acbaa713_0.EEAD6F95.Value) into class0_0
				where class0_0.Prop_0.GetType() == typeof(JArray)
				select class0_0.BA238E0F.C7296323).ToList();
			list2.ForEach(delegate(string string_0)
			{
				dictionary_0[string_0] = (from jtoken_0 in ((JArray)dictionary_0[string_0]).Values()
					select ((JValue)jtoken_0).Value).ToArray();
			});
			list.ForEach(delegate(string F42B8499)
			{
				dictionary_0[F42B8499] = method_0(dictionary_0[F42B8499] as JObject);
			});
		}
		catch
		{
		}
		return dictionary_0;
	}

	public GClass11()
	{
		jobject_0 = new JObject();
	}

	public string C0288288(string string_1, string string_2 = "")
	{
		string result = string_2;
		try
		{
			result = ((jobject_0[string_1] == null) ? string_2 : jobject_0[string_1]!.ToString());
		}
		catch
		{
		}
		return result;
	}

	public bool method_1(string string_1)
	{
		return jobject_0.ContainsKey(string_1);
	}

	public List<string> C5A69DA0(string string_1, int int_0 = 0)
	{
		List<string> list = new List<string>();
		try
		{
			list = ((int_0 != 0) ? C0288288(string_1).Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : C0288288(string_1).Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList());
			list = GClass8.smethod_36(list);
		}
		catch
		{
		}
		return list;
	}

	public int method_2(string C339CFA5, int BF9CC61B = 0)
	{
		int result = BF9CC61B;
		try
		{
			result = ((jobject_0[C339CFA5] == null) ? BF9CC61B : Convert.ToInt32(jobject_0[C339CFA5]!.ToString()));
		}
		catch
		{
		}
		return result;
	}

	public bool method_3(string string_1, bool bool_0 = false)
	{
		bool result = bool_0;
		try
		{
			result = ((jobject_0[string_1] == null) ? bool_0 : Convert.ToBoolean(jobject_0[string_1]!.ToString()));
			return result;
		}
		catch
		{
			return result;
		}
	}

	public void method_4(string string_1, object object_0)
	{
		try
		{
			if (object_0.GetType() == typeof(bool))
			{
				jobject_0[string_1] = (JToken)object_0.ToString().ToLower();
			}
			else
			{
				jobject_0[string_1] = (JToken)object_0.ToString();
			}
		}
		catch
		{
		}
	}

	public void method_5(string string_1, List<string> list_0)
	{
		try
		{
			if (list_0.Any((string B398398E) => B398398E.Contains("\n")))
			{
				jobject_0[string_1] = (JToken)string.Join("\n|\n", list_0).ToString();
			}
			else
			{
				jobject_0[string_1] = (JToken)string.Join("\n", list_0).ToString();
			}
		}
		catch
		{
		}
	}

	public void C230DBBF(string string_1)
	{
		try
		{
			jobject_0.Remove(string_1);
		}
		catch
		{
		}
	}

	public void method_6(string D3ACC51A = "")
	{
		for (int i = 0; i < 5; i++)
		{
			try
			{
				if (D3ACC51A == "")
				{
					D3ACC51A = string_0;
				}
				File.WriteAllText(D3ACC51A, jobject_0.ToString());
				return;
			}
			catch
			{
			}
			GClass8.smethod_53(1.0);
		}
	}

	public string method_7()
	{
		string result = "";
		try
		{
			result = jobject_0.ToString().Replace("\r\n", "");
		}
		catch (Exception)
		{
		}
		return result;
	}
}
