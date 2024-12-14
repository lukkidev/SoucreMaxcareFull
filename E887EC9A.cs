using System;

public static class E887EC9A
{
	public static bool C323DB3B(string BA216CBE)
	{
		try
		{
			Convert.ToInt32(BA216CBE);
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static string A3A66D03(this string string_0, int D63FA226 = 0, char char_0 = '*')
	{
		try
		{
			string text = "";
			for (int i = 0; i < string_0.Length; i++)
			{
				if (string_0[i] != char_0)
				{
					text += string_0[i];
					continue;
				}
				switch (D63FA226)
				{
				case 0:
					text += GClass8.smethod_52(1);
					break;
				case 1:
					text += GClass8.smethod_51(1);
					break;
				case 2:
					text += GClass8.smethod_50(1);
					break;
				}
			}
			return text;
		}
		catch
		{
		}
		return "";
	}
}
