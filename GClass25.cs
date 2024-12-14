using System.Collections.Generic;
using System.IO;
using System.Linq;

public class GClass25
{
	public static Dictionary<string, GClass11> dictionary_0 = new Dictionary<string, GClass11>();

	public static GClass11 smethod_0(string string_0, bool BE8528BA = false)
	{
		if (BE8528BA)
		{
			smethod_1(string_0);
		}
		else
		{
			lock (dictionary_0)
			{
				if (!dictionary_0.ContainsKey(string_0))
				{
					dictionary_0.Add(string_0, new GClass11(string_0));
				}
			}
		}
		return dictionary_0[string_0];
	}

	private static void smethod_1(string string_0)
	{
		if (dictionary_0.ContainsKey(string_0))
		{
			dictionary_0[string_0] = new GClass11(string_0);
		}
		else
		{
			dictionary_0.Add(string_0, new GClass11(string_0));
		}
	}

	public static void B3B73732(string string_0)
	{
		if (dictionary_0.ContainsKey(string_0))
		{
			dictionary_0[string_0].method_6();
		}
		smethod_1(string_0);
	}

	public static string smethod_2()
	{
		string text = dictionary_0["configGeneral"].C0288288("txbPathProfile");
		if (!text.Contains('\\'))
		{
			text = GClass28.smethod_0() + "\\" + ((text == "") ? "profiles" : text);
		}
		if (!Directory.Exists(text))
		{
			return GClass28.smethod_0() + "\\profiles";
		}
		return text;
	}

	public static string FEB70BB9()
	{
		return GClass28.smethod_0() + "\\backup";
	}

	public static bool D311242C()
	{
		return smethod_0("configGeneral").method_3("ckbMysqlServer") && smethod_0("configGeneral").C0288288("txtMysqlServer") != "";
	}
}
