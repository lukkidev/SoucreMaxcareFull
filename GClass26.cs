using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

public static class GClass26
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A487B1A5
	{
		public static readonly A487B1A5 _003C_003E9 = new A487B1A5();

		public static Func<string, Guid> _003C_003E9__10_0;

		internal Guid method_0(string string_0)
		{
			return Guid.NewGuid();
		}
	}

	public static bool smethod_0(List<string> AE168D31, List<string> CD85CAA0)
	{
		List<string> source = AE168D31.Except(CD85CAA0).ToList();
		List<string> source2 = CD85CAA0.Except(AE168D31).ToList();
		return !source.Any() && !source2.Any();
	}

	public static List<string> F98CC09D(List<string> list_0)
	{
		string text = "";
		int num = list_0.Count;
		int num2 = 0;
		while (num != 0)
		{
			num2 = Class57.random_0.Next(0, list_0.Count);
			num--;
			text = list_0[num];
			list_0[num] = list_0[num2];
			list_0[num2] = text;
		}
		return list_0;
	}

	public static List<string> F1136602(List<string> E98A8132)
	{
		List<string> list = new List<string>();
		try
		{
			for (int i = 0; i < E98A8132.Count; i++)
			{
				list.Add(E98A8132[i]);
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<List<string>> A8039737(List<string> AAB73F07, int C29BDC95)
	{
		List<List<string>> list = new List<List<string>>();
		try
		{
			int num = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)AAB73F07.Count * 1.0 / (double)C29BDC95)));
			for (int i = 0; i < num; i++)
			{
				list.Add(AAB73F07.GetRange(C29BDC95 * i, (C29BDC95 * i + C29BDC95 <= AAB73F07.Count) ? C29BDC95 : (AAB73F07.Count % C29BDC95)));
			}
		}
		catch
		{
		}
		return list;
	}

	public static string smethod_1(List<string> AF901426, string string_0 = "\r\n")
	{
		return string.Join(string_0, AF901426);
	}

	public static string smethod_2(List<string> B588C01D)
	{
		string result = "";
		if (B588C01D.Count > 0)
		{
			result = B588C01D.Last();
			B588C01D.RemoveAt(B588C01D.Count - 1);
		}
		return result;
	}

	public static List<string> BA13E1A6(List<string> D222542F, List<string> list_0)
	{
		foreach (string item in list_0)
		{
			D222542F.Remove(item);
		}
		return D222542F;
	}

	public static int smethod_3(int int_0)
	{
		return smethod_4(0, int_0 - 1);
	}

	public static int smethod_4(int A6108799, int int_0)
	{
		return Class57.random_0.Next(A6108799, int_0 + 1);
	}

	public static int smethod_5(this List<string> C9A56A80)
	{
		return smethod_3(C9A56A80.Count);
	}

	public static string smethod_6(this List<string> list_0)
	{
		if (list_0.Count == 0)
		{
			return null;
		}
		return list_0.OrderBy((string string_0) => Guid.NewGuid()).First();
	}
}
