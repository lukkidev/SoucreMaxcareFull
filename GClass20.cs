using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

public class GClass20
{
	private string string_0;

	private string string_1 = Assembly.GetExecutingAssembly().GetName().Name;

	[DllImport("kernel32", CharSet = CharSet.Unicode)]
	private static extern long WritePrivateProfileString(string string_2, string B0A4E58F, string string_3, string string_4);

	[DllImport("kernel32", CharSet = CharSet.Unicode)]
	private static extern int GetPrivateProfileString(string string_2, string string_3, string CB21F38F, StringBuilder stringBuilder_0, int int_0, string string_4);

	[DllImport("KERNEL32.DLL", CharSet = CharSet.Unicode)]
	private static extern uint GetPrivateProfileStringW(string string_2, string C53DA98C, string string_3, byte[] D4923593, uint uint_0, string string_4);

	public GClass20(string string_2 = null)
	{
		string_0 = new FileInfo(string_2 ?? (string_1 + ".ini")).FullName.ToString();
	}

	public string method_0(string E223E093, string string_2 = null)
	{
		byte[] array = new byte[1024];
		uint privateProfileStringW = GetPrivateProfileStringW(string_2 ?? string_1, E223E093, "", array, (uint)array.Length, string_0);
		return Encoding.Unicode.GetString(array, 0, (int)(privateProfileStringW * 2));
	}

	public string BF22A80E(string B999E8A6, string C296D114 = null)
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		GetPrivateProfileString(C296D114 ?? string_1, B999E8A6, "", stringBuilder, 255, string_0);
		return stringBuilder.ToString();
	}

	public void CD037E9D(string F89ABD29, string string_2, string string_3 = null)
	{
		WritePrivateProfileString(string_3 ?? string_1, F89ABD29, string_2, string_0);
	}

	public void method_1(string string_2, string string_3 = null)
	{
		CD037E9D(string_2, null, string_3 ?? string_1);
	}

	public void method_2(string string_2 = null)
	{
		CD037E9D(null, null, string_2 ?? string_1);
	}

	public bool method_3(string string_2, string BB9A9BB0 = null)
	{
		return BF22A80E(string_2, BB9A9BB0).Length > 0;
	}
}
