using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using Microsoft.Win32;

public class GClass8
{
	[Serializable]
	[CompilerGenerated]
	private sealed class B995DD91
	{
		public static readonly B995DD91 _003C_003E9 = new B995DD91();

		public static Func<bool, bool, bool> _003C_003E9__55_0;

		public static Func<bool, bool> _003C_003E9__55_1;

		public static Func<DataRow, int> _003C_003E9__125_0;

		public static Func<Control, IEnumerable<Control>> _003C_003E9__139_0;

		internal bool AAAF4B22(bool bool_0, bool A7A7AC0B)
		{
			return bool_0 == A7A7AC0B;
		}

		internal bool B33C81AD(bool bool_0)
		{
			return bool_0;
		}

		internal int CDAE339F(DataRow dataRow_0)
		{
			return Class57.random_0.Next();
		}

		internal IEnumerable<Control> method_0(Control control_0)
		{
			return smethod_75(control_0);
		}
	}

	[CompilerGenerated]
	private sealed class C1375117
	{
		public StringBuilder D4920C94;

		internal void method_0(object sender, DataReceivedEventArgs e)
		{
			if (!string.IsNullOrEmpty(e.Data))
			{
				D4920C94.Append(e.Data + "\n");
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class11
	{
		public DataGridView dataGridView_0;

		public int int_0;

		public string string_0;

		public object object_0;

		internal void method_0()
		{
			dataGridView_0.Rows[int_0].Cells[string_0].Value = object_0;
		}
	}

	[CompilerGenerated]
	private sealed class Class12
	{
		public string AE9E70AD;

		internal void method_0()
		{
			byte[] byte_ = smethod_11(AE9E70AD);
			MessageBox(byte_);
		}
	}

	[CompilerGenerated]
	private static class BEBEC096
	{
		public static CallSite<Func<CallSite, object, F8B2F53A>> B59CE927;
	}

	[CompilerGenerated]
	private static class Class13
	{
		public static CallSite<Func<CallSite, object, F8B2F53A>> callSite_0;
	}

	private static Random E717621A = new Random();

	private static string string_0 = "C:\\";

	private static int D81AD20A = Screen.PrimaryScreen.WorkingArea.Width;

	private static int int_0 = Screen.PrimaryScreen.WorkingArea.Height;

	private static object B336D0B3 = new object();

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetBalance(byte[] byte_0, byte[] byte_1);

	public static string smethod_0(string string_1, string string_2)
	{
		return smethod_10(GetBalance(smethod_11(string_1), smethod_11(string_2)));
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RequestGet(byte[] byte_0);

	public static string smethod_1(string string_1)
	{
		return smethod_10(RequestGet(smethod_11(string_1)));
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RequestPost(byte[] byte_0, byte[] byte_1);

	public static string smethod_2(string string_1, string string_2)
	{
		return smethod_10(RequestPost(smethod_11(string_1), smethod_11(string_2)));
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RequestGet2(byte[] byte_0, byte[] byte_1, byte[] A60BCE3B, byte[] C203208D, byte[] BB3865AF);

	public static string DC95A028(string C3BF713C, string C436A72D, string string_1, int FA196D30, string C038F319)
	{
		return smethod_10(RequestGet2(smethod_11(C3BF713C), smethod_11(C436A72D), smethod_11(string_1), smethod_11(FA196D30.ToString()), smethod_11(C038F319)));
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RequestPost2(byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] byte_3, byte[] byte_4, byte[] C0BF083D);

	public static string D38FA111(string ABAE0A2B, string string_1, string string_2, int int_1, string A50F4824, string string_3)
	{
		return smethod_10(RequestPost2(smethod_11(ABAE0A2B), smethod_11(string_1), smethod_11(string_2), smethod_11(int_1.ToString()), smethod_11(A50F4824), smethod_11(string_3)));
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RequestGet3(byte[] E7B0B2AA, byte[] byte_0, byte[] byte_1, byte[] E324EB0E, byte[] A3B5DD17);

	public static string smethod_3(string string_1, string string_2, string string_3, int CC887092, string string_4)
	{
		return smethod_10(RequestGet3(smethod_11(string_1), smethod_11(string_2), smethod_11(string_3), smethod_11(CC887092.ToString()), smethod_11(string_4)));
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RequestPost3(byte[] FE307213, byte[] BF1D2D34, byte[] byte_0, byte[] E619AA2F, byte[] byte_1, byte[] D29FB9B5);

	public static string FB24729A(string A7BFBFAF, string string_1, string string_2, int int_1, string string_3, string string_4)
	{
		return smethod_10(RequestPost3(smethod_11(A7BFBFAF), smethod_11(string_1), smethod_11(string_2), smethod_11(int_1.ToString()), smethod_11(string_3), smethod_11(string_4)));
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RequestPost4(byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] D59CBC1E, byte[] D1BE39BA, byte[] byte_3, byte[] BA19309F);

	public static string smethod_4(string string_1, string string_2, string FE1ACCB7, int int_1, string string_3, string DC1EA6AA, string BB99A08B)
	{
		return smethod_10(RequestPost4(smethod_11(string_1), smethod_11(string_2), smethod_11(FE1ACCB7), smethod_11(int_1.ToString()), smethod_11(string_3), smethod_11(DC1EA6AA), smethod_11(BB99A08B)));
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RequestPost5(byte[] B7B06A8E, byte[] byte_0, byte[] byte_1, byte[] A913AD87, byte[] byte_2, byte[] byte_3, byte[] byte_4, byte[] byte_5);

	public static string F797A0AE(string string_1, string C92AC900, string string_2, int int_1, string CD27ECAE, string F92D6834, string string_3, string[] string_4)
	{
		return smethod_10(RequestPost5(smethod_11(string_1), smethod_11(C92AC900), smethod_11(string_2), smethod_11(int_1.ToString()), smethod_11(CD27ECAE), smethod_11(F92D6834), smethod_11(string_3), smethod_11(string.Join("\n", string_4))));
	}

	public static string C499D098(string string_1, string FA8CAA0B, string string_2, string string_3, int int_1)
	{
		return smethod_88($"GetTokenEAAAAU('{string_1}','{FA8CAA0B}','{string_2}','{string_3}',{int_1})");
	}

	public static string smethod_5(string E58EF110, string CC2FF7A7, string A815A6AE, string string_1, int D4B24A8F)
	{
		return smethod_88($"GetTokenEAAAAY('{E58EF110}','{CC2FF7A7}','{A815A6AE}','{string_1}',{D4B24A8F})");
	}

	public static string FE2F1036(string string_1, string string_2, int int_1)
	{
		return smethod_88($"GetTokenEAAAAUByCookie('{string_1}','{string_2}',{int_1})");
	}

	public static string smethod_6(string string_1, string string_2, int int_1)
	{
		return smethod_88($"GetTokenEAAAAYByCookie('{string_1}','{string_2}',{int_1})");
	}

	public static string smethod_7(string string_1, string B12C37AC, string string_2, int int_1, string string_3)
	{
		return smethod_88($"GetTokenEAAG('{string_1}','{B12C37AC}','{string_2}',{int_1},'{string_3}')");
	}

	public static string smethod_8(string string_1, string DB1EF62C, string E5895B9F, int int_1)
	{
		return smethod_88($"Getfbdtsg('{string_1}','{DB1EF62C}','{E5895B9F}',{int_1})");
	}

	public static string smethod_9(string string_1, string EDB04416, string FD337121, int D4894E1C)
	{
		return smethod_88($"GetTokenEAABs('{string_1}','{EDB04416}','{FD337121}',{D4894E1C})");
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetText(byte[] byte_0);

	public static string AC8B8F9C(string string_1)
	{
		byte[] byte_ = smethod_11(string_1);
		return smethod_10(GetText(byte_));
	}

	public static string smethod_10(IntPtr intptr_0)
	{
		try
		{
			string s = Marshal.PtrToStringAnsi(intptr_0);
			byte[] bytes = Encoding.Default.GetBytes(s);
			return Encoding.UTF8.GetString(bytes);
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static byte[] smethod_11(string string_1)
	{
		return Encoding.UTF8.GetBytes(string_1);
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern void FreeCString(IntPtr intptr_0);

	public static void smethod_12(IntPtr intptr_0)
	{
		if (!(intptr_0 == IntPtr.Zero))
		{
			FreeCString(intptr_0);
		}
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetDeviceId();

	public static string BB845FB4()
	{
		return smethod_10(GetDeviceId());
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckLicense2(byte[] byte_0, byte[] A6A142A2, byte[] byte_1, byte[] byte_2, byte[] byte_3);

	public static string BA2E8F14(string DB15632A, string C290A616)
	{
		string text = Class57.E0AE7DB2();
		string text2 = "";
		string text3 = "";
		switch (text)
		{
		default:
			text2 = "11";
			break;
		case "3":
		case "4":
			text2 = "1";
			break;
		case "2":
			text2 = "61";
			break;
		}
		string text4 = text;
		string text5 = text4;
		text3 = ((text5 == "3") ? "https://app.minsoftcambodia.com" : ((text5 == "4") ? "https://app.minsoftthailand.com" : "https://app.minsoftware.xyz"));
		return "1|Lukki|Lukki|05/15/2030 00:00:00|MINHBH12341234123"; // Nhớ để 1| không được xóa
    }

	public static void smethod_13(string FFBFAE8D)
	{
		BF16B7AA bF16B7AA = new BF16B7AA(FFBFAE8D);
		bF16B7AA.ShowInTaskbar = false;
		bF16B7AA.ShowDialog();
	}

	public static double AE08EC26(DateTime dateTime_0)
	{
		return (dateTime_0 - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime()).TotalSeconds;
	}

	public static string smethod_14(object AF315CA7)
	{
		string text = "";
		try
		{
			PropertyInfo[] properties = AF315CA7.GetType().GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				text = text + propertyInfo.GetValue(AF315CA7)?.ToString() + ",";
			}
			text = text.TrimEnd(',');
		}
		catch
		{
		}
		return text;
	}

	public static List<string> smethod_15(List<string> list_0, List<string> list_1)
	{
		List<string> result = new List<string>();
		try
		{
			result = list_0.Intersect(list_1).ToList();
		}
		catch
		{
		}
		return result;
	}

	public static List<string> smethod_16(List<string> E3920E3B, List<string> list_0)
	{
		List<string> result = new List<string>();
		try
		{
			result = E3920E3B.Except(list_0).ToList();
		}
		catch
		{
		}
		return result;
	}

	private static void smethod_17(string B42DC195)
	{
		ProcessStartInfo startInfo = new ProcessStartInfo("netsh", "interface set interface \"" + B42DC195 + "\" enable");
		Process process = new Process();
		process.StartInfo = startInfo;
		process.Start();
	}

	private static void smethod_18(string C8388D98)
	{
		ProcessStartInfo startInfo = new ProcessStartInfo("netsh", "interface set interface \"" + C8388D98 + "\" disable");
		Process process = new Process();
		process.StartInfo = startInfo;
		process.Start();
	}

	public static string smethod_19(string string_1)
	{
		try
		{
			return Directory.GetCreationTime(string_1).ToString("yyyy/MM/dd HH:mm:ss");
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string smethod_20(string string_1)
	{
		try
		{
			return File.GetCreationTime(string_1).ToString("yyyy/MM/dd HH:mm:ss");
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string smethod_21(ref List<string> list_0, Random random_0)
	{
		string text = "";
		try
		{
			text = list_0[random_0.Next(0, list_0.Count)];
			list_0.Remove(text);
		}
		catch (Exception)
		{
			throw;
		}
		return text;
	}

	public static void C539C921()
	{
		ManagementClass managementClass = new ManagementClass("Win32_OperatingSystem");
		managementClass.Get();
		managementClass.Scope.Options.EnablePrivileges = true;
		ManagementBaseObject methodParameters = managementClass.GetMethodParameters("Win32Shutdown");
		methodParameters["Flags"] = "1";
		methodParameters["Reserved"] = "0";
		foreach (ManagementObject instance in managementClass.GetInstances())
		{
			instance.InvokeMethod("Win32Shutdown", methodParameters, null);
		}
	}

	public static void smethod_22(ComboBox C096F010, List<string> list_0)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		for (int i = 0; i < list_0.Count; i++)
		{
			dictionary.Add(i.ToString() ?? "", F7AB102E.smethod_0(list_0[i]));
		}
		C096F010.DataSource = new BindingSource(dictionary, null);
		C096F010.DisplayMember = "Value";
		C096F010.ValueMember = "Key";
	}

	public static void smethod_23(ComboBox comboBox_0, Dictionary<string, string> C413BE2B)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		foreach (KeyValuePair<string, string> item in C413BE2B)
		{
			dictionary.Add(item.Key, F7AB102E.smethod_0(item.Value));
		}
		comboBox_0.DataSource = new BindingSource(dictionary, null);
		comboBox_0.DisplayMember = "Value";
		comboBox_0.ValueMember = "Key";
	}

	public static string smethod_24(int int_1)
	{
		try
		{
			TimeSpan.FromSeconds(int_1);
			if (int_1 < 60)
			{
				return TimeSpan.FromSeconds(int_1).ToString("ss");
			}
			if (int_1 < 3600)
			{
				return TimeSpan.FromSeconds(int_1).ToString("mm\\:ss");
			}
			return TimeSpan.FromSeconds(int_1).ToString("hh\\:mm\\:ss");
		}
		catch
		{
			return "";
		}
	}

	public static void BFBFBD05(UserControl userControl_0, ContainerControl containerControl_0)
	{
		userControl_0.Left = (containerControl_0.ClientSize.Width - userControl_0.Width) / 2;
		userControl_0.Top = (containerControl_0.ClientSize.Height - userControl_0.Height) / 2;
		userControl_0.BringToFront();
		userControl_0.Visible = true;
	}

	public static bool CF3A2293(string string_1, string string_2, string string_3, string A80B858A = "C:\\Users\\Xuan Tung\\Desktop\\MaxUid\\images\\icon_64.ico", string E13FF09C = "\"C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe\"")
	{
		bool result = false;
		try
		{
			smethod_25(string_1, string_2, E13FF09C, "--user-data-dir=\"" + string_3 + "\"", E13FF09C.Substring(0, E13FF09C.LastIndexOf("\\")), A80B858A);
			result = true;
			return result;
		}
		catch (Exception f4295AA)
		{
			BFBDF687(null, f4295AA, "chrome.CreateShortcut(" + string_1 + "," + string_2 + "," + E13FF09C + ")select");
			return result;
		}
	}

	public static void smethod_25(string string_1, string D1B4A33F, string string_2, string BD889FA9, string string_3 = "C:\\Program Files (x86)\\Google\\Chrome\\Application", string A912FD21 = "C:\\Users\\Xuan Tung\\Desktop\\MaxUid\\images\\icon_64.ico")
	{
		string d4A = Path.Combine(D1B4A33F, string_1 + ".lnk");
		GInterface3 gInterface = (GInterface3)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
		F8B2F53A f8B2F53A = (F8B2F53A)(dynamic)gInterface.imethod_0(d4A);
		f8B2F53A.E9BBD437 = "Shortcut Chrome MIN Software";
		f8B2F53A.String_2 = string_3;
		f8B2F53A.E2AB093A = A912FD21;
		f8B2F53A.String_1 = string_2;
		f8B2F53A.String_0 = BD889FA9;
		f8B2F53A.imethod_0();
	}

	public static void EC84CE39()
	{
		string location = Assembly.GetExecutingAssembly().Location;
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(location);
		string directoryName = Path.GetDirectoryName(location);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string text = Path.Combine(folderPath, fileNameWithoutExtension + ".lnk");
		if (!File.Exists(text))
		{
			GInterface3 gInterface = (GInterface3)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
			F8B2F53A f8B2F53A = (F8B2F53A)(dynamic)gInterface.imethod_0(text);
			f8B2F53A.E9BBD437 = fileNameWithoutExtension;
			f8B2F53A.String_1 = location;
			f8B2F53A.String_2 = directoryName;
			f8B2F53A.E2AB093A = directoryName + "\\images\\icon_64.ico";
			f8B2F53A.imethod_0();
		}
	}

	public static void B3866B9B(DataGridView FFAF67BA, int int_1, string string_1, object object_0)
	{
		try
		{
			Application.DoEvents();
			FFAF67BA.Invoke((MethodInvoker)delegate
			{
				FFAF67BA.Rows[int_1].Cells[string_1].Value = object_0;
			});
		}
		catch
		{
		}
	}

	public static int smethod_26(string BD1C2F32, string string_1)
	{
		int result = 0;
		try
		{
			List<bool> first = D00F8592(new Bitmap(BD1C2F32));
			List<bool> second = D00F8592(new Bitmap(BD1C2F32));
			result = first.Zip(second, (bool bool_0, bool A7A7AC0B) => bool_0 == A7A7AC0B).Count((bool bool_0) => bool_0);
		}
		catch
		{
		}
		return result;
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr SetTextToClipboard(byte[] byte_0);

	public static bool smethod_27(string string_1)
	{
		bool result = false;
		try
		{
			SetTextToClipboard(smethod_11(string_1));
			result = true;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static List<bool> D00F8592(Bitmap AE2A790B)
	{
		List<bool> list = new List<bool>();
		Bitmap bitmap = new Bitmap(AE2A790B, new System.Drawing.Size(16, 16));
		for (int i = 0; i < bitmap.Height; i++)
		{
			for (int j = 0; j < bitmap.Width; j++)
			{
				list.Add(bitmap.GetPixel(j, i).GetBrightness() < 0.5f);
			}
		}
		return list;
	}

	public static List<string> smethod_28(List<string> DA343EA6)
	{
		List<string> list = new List<string>();
		try
		{
			for (int i = 0; i < DA343EA6.Count; i++)
			{
				list.Add(DA343EA6[i]);
			}
		}
		catch
		{
		}
		return list;
	}

	public static string smethod_29(string string_1)
	{
		string pattern = "{[^{}]*}";
		Match match = Regex.Match(string_1, pattern);
		while (match.Success)
		{
			string text = match.Value.Substring(1, match.Length - 2);
			string[] array = text.Split('|');
			string_1 = string_1.Substring(0, match.Index) + array[Class57.random_0.Next(array.Length)] + string_1.Substring(match.Index + match.Length);
			match = Regex.Match(string_1, pattern);
		}
		string_1 = Class55.smethod_2(string_1);
		return string_1;
	}

	public static void BBA93818(string E11FCFBF, string string_1 = "Nhập danh sách Uid cần clone", string C8AC74B2 = "Danh sách Uid", string A0905814 = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})")
	{
		try
		{
			if (!File.Exists(E11FCFBF))
			{
				smethod_31(E11FCFBF);
			}
			smethod_33(new fNhapDuLieu1(E11FCFBF, string_1, C8AC74B2, A0905814));
		}
		catch
		{
		}
	}

	public static DateTime smethod_30(double double_0)
	{
		return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(double_0).ToLocalTime();
	}

	public static void smethod_31(string string_1)
	{
		try
		{
			if (!File.Exists(string_1))
			{
				File.AppendAllText(string_1, "");
			}
		}
		catch
		{
		}
	}

	public static void D204BB36(DataGridView dataGridView_0)
	{
		for (int i = 0; i < dataGridView_0.RowCount; i++)
		{
			dataGridView_0.Rows[i].Selected = false;
		}
	}

	public static void smethod_32(string string_1)
	{
		try
		{
			if (!Directory.Exists(string_1))
			{
				Directory.CreateDirectory(string_1);
			}
		}
		catch
		{
		}
	}

	public static void smethod_33(Form form_0)
	{
		try
		{
			form_0.ShowInTaskbar = false;
			form_0.ShowDialog();
		}
		catch (Exception)
		{
		}
	}

	public static List<int> smethod_34(List<int> list_0)
	{
		int num = 0;
		int num2 = list_0.Count;
		int num3 = 0;
		while (num2 != 0)
		{
			num3 = Class57.random_0.Next(0, list_0.Count);
			num2--;
			num = list_0[num2];
			list_0[num2] = list_0[num3];
			list_0[num3] = num;
		}
		return list_0;
	}

	public static List<string> smethod_35(List<string> BF03A33A)
	{
		string text = "";
		int num = BF03A33A.Count;
		int num2 = 0;
		while (num != 0)
		{
			num2 = Class57.random_0.Next(0, BF03A33A.Count);
			num--;
			text = BF03A33A[num];
			BF03A33A[num] = BF03A33A[num2];
			BF03A33A[num2] = text;
		}
		return BF03A33A;
	}

	public static List<string> smethod_36(List<string> E03C713E)
	{
		List<string> list = new List<string>();
		string text = "";
		for (int i = 0; i < E03C713E.Count; i++)
		{
			text = E03C713E[i].Trim();
			if (text != "")
			{
				list.Add(text);
			}
		}
		return list;
	}

	public static string smethod_37(string string_1, string string_2)
	{
		if (!string_1.EndsWith(string_2))
		{
			return string_1;
		}
		return string_1.Remove(string_1.LastIndexOf(string_2));
	}

	public static void smethod_38(DataGridView A6B37B2C, string string_1, char char_0 = '|')
	{
		List<string> list = new List<string>();
		string text = "";
		object obj = null;
		for (int i = 0; i < A6B37B2C.RowCount; i++)
		{
			text = "";
			for (int j = 0; j < A6B37B2C.ColumnCount; j++)
			{
				obj = A6B37B2C.Rows[i].Cells[j].Value;
				text += ((obj == null) ? char_0.ToString() : (obj?.ToString() + char_0));
			}
			text = text.TrimEnd(char_0);
			list.Add(text);
		}
		File.WriteAllLines(string_1, list);
	}

	public static void smethod_39(DataGridView dataGridView_0, string F427C995, char char_0 = '|')
	{
		if (!File.Exists(F427C995))
		{
			smethod_31(F427C995);
		}
		List<string> list = File.ReadAllLines(F427C995).ToList();
		string text = "";
		if (list.Count > 0)
		{
			for (int i = 0; i < list.Count; i++)
			{
				text = list[i];
				DataGridViewRowCollection rows = dataGridView_0.Rows;
				object[] values = text.Split(char_0);
				rows.Add(values);
			}
		}
	}

	public static string smethod_40(string string_1 = "")
	{
		string result = "";
		try
		{
			GClass1 gClass = new GClass1
			{
				B3274D19 = "Select a folder"
			};
			if (!string.IsNullOrEmpty(string_1) && Directory.Exists(string_1))
			{
				gClass.D316343E = string_1;
			}
			else
			{
				gClass.D316343E = string_1;
			}
			if (gClass.method_0())
			{
				result = (string_0 = gClass.BE267DBD);
			}
		}
		catch
		{
		}
		return result;
	}

	public static string AD2D2BA4(string string_1 = "Chọn File txt", string C493F014 = "txt Files (*.txt)|*.txt|")
	{
		string text = "";
		try
		{
			using OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = C493F014 + "All files (*.*)|*.*";
			openFileDialog.InitialDirectory = string_0;
			openFileDialog.Title = string_1;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				text = openFileDialog.FileName;
				if (!string.IsNullOrEmpty(text))
				{
					string_0 = Path.GetDirectoryName(text);
				}
			}
		}
		catch
		{
		}
		return text;
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr KillProcess(byte[] F93C5988);

	public static void smethod_41(string string_1)
	{
		byte[] f93C = smethod_11(string_1);
		KillProcess(f93C);
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr MessageBox(byte[] byte_0);

	public static void F89A7C00(string string_1)
	{
		new Thread((ThreadStart)delegate
		{
			byte[] byte_ = smethod_11(string_1);
			MessageBox(byte_);
		}).Start();
		smethod_53(1.0);
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr IsUid(byte[] byte_0);

	public static bool smethod_42(string string_1)
	{
		try
		{
			byte[] byte_ = smethod_11(string_1);
			return Convert.ToBoolean(smethod_10(IsUid(byte_)));
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static bool BA95518F(string string_1)
	{
		bool result = true;
		foreach (char c in string_1)
		{
			if ((c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && c != '.')
			{
				result = false;
				break;
			}
		}
		return result;
	}

	public static string smethod_43(string string_1)
	{
		string text = "";
		for (int i = 0; i < string_1.Length; i++)
		{
			char c = string_1[i];
			if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
			{
				text += c;
			}
		}
		return text;
	}

	public static string A8975A36(string string_1)
	{
		byte[] bytes = Encoding.Default.GetBytes(string_1);
		string_1 = Encoding.UTF8.GetString(bytes);
		return string_1;
	}

	public static bool smethod_44(string F7B5773D)
	{
		if (F7B5773D == "")
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < F7B5773D.Length)
			{
				char c = F7B5773D[num];
				if (!char.IsDigit(c))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static bool smethod_45(string string_1)
	{
		int num = 0;
		while (true)
		{
			if (num < string_1.Length)
			{
				char c = string_1[num];
				if (char.IsDigit(c))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static void C3280AAA(string B5392227)
	{
		string text = "zzz999.html";
		File.WriteAllText(text, B5392227);
		Process.Start(text);
	}

	public static string smethod_46(string string_1)
	{
		try
		{
			return new GClass12().method_0(string_1);
		}
		catch
		{
			return null;
		}
	}

	public static bool smethod_47(string string_1)
	{
		try
		{
			new MailAddress(string_1);
			return true;
		}
		catch (FormatException)
		{
			return false;
		}
	}

	public static string smethod_48(string string_1, string D904B98E = "X2")
	{
		MD5 mD = MD5.Create();
		byte[] array = mD.ComputeHash(Encoding.UTF8.GetBytes(string_1));
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString(D904B98E));
		}
		return stringBuilder.ToString();
	}

	public static string CF09EFB3(string B881C592)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(B881C592);
		return Convert.ToBase64String(bytes);
	}

	public static string A2307E3B(string string_1)
	{
		if (string_1 == "")
		{
			return "";
		}
		try
		{
			byte[] bytes = Convert.FromBase64String(string_1);
			return Encoding.UTF8.GetString(bytes);
		}
		catch (Exception)
		{
		}
		return "";
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RandomBool(byte[] byte_0);

	public static bool smethod_49(int DE1074A3)
	{
		return smethod_10(RandomBool(smethod_11(DE1074A3.ToString()))) == "true";
	}

	public static string smethod_50(int int_1)
	{
		return smethod_93(int_1, "a_A_0");
	}

	public static string smethod_51(int int_1)
	{
		return smethod_93(int_1, "a");
	}

	public static string smethod_52(int int_1)
	{
		return smethod_93(int_1, "0");
	}

	public static string DF233915(string string_1)
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/c " + string_1;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			string text = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			if (string.IsNullOrEmpty(text))
			{
				return "";
			}
			return text;
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static void smethod_53(double C1BD4CB3)
	{
		Application.DoEvents();
		Thread.Sleep(Convert.ToInt32(C1BD4CB3 * 1000.0));
	}

	public static string smethod_54(string string_1)
	{
		return WebUtility.HtmlDecode(string_1);
	}

	public static string smethod_55(string string_1)
	{
		return WebUtility.HtmlEncode(string_1);
	}

	public static string C629FF38(string string_1)
	{
		return WebUtility.UrlDecode(string_1);
	}

	public static string FBA19A19(string B8041723)
	{
		return WebUtility.UrlEncode(B8041723);
	}

	public static System.Drawing.Point smethod_56(int DF1BD385, int E72A9AA5)
	{
		if (GClass25.smethod_0("configChrome").method_2("width") == 0)
		{
			GClass25.smethod_0("configChrome").method_4("width", D81AD20A);
			GClass25.smethod_0("configChrome").method_4("heigh", int_0);
			GClass25.B3B73732("configChrome");
		}
		D81AD20A = GClass25.smethod_0("configChrome").method_2("width");
		int_0 = GClass25.smethod_0("configChrome").method_2("heigh");
		int x = D81AD20A / DF1BD385 + 15;
		int y = int_0 / E72A9AA5 + 10;
		return new System.Drawing.Point(x, y);
	}

	public static System.Drawing.Point smethod_57(int int_1, int DEB4EFBC, int int_2)
	{
		if (GClass25.smethod_0("configChrome").method_2("width") == 0)
		{
			GClass25.smethod_0("configChrome").method_4("width", D81AD20A);
			GClass25.smethod_0("configChrome").method_4("heigh", int_0);
			GClass25.B3B73732("configChrome");
		}
		D81AD20A = GClass25.smethod_0("configChrome").method_2("width");
		int_0 = GClass25.smethod_0("configChrome").method_2("heigh");
		System.Drawing.Point result = default(System.Drawing.Point);
		while (int_1 >= DEB4EFBC * int_2)
		{
			int_1 -= DEB4EFBC * int_2;
		}
		switch (int_2)
		{
		case 1:
			result.Y = 0;
			break;
		case 2:
			if (int_1 < DEB4EFBC)
			{
				result.Y = 0;
			}
			else if (int_1 < DEB4EFBC * 2)
			{
				result.Y = int_0 / 2;
				int_1 -= DEB4EFBC;
			}
			break;
		case 3:
			if (int_1 < DEB4EFBC)
			{
				result.Y = 0;
			}
			else if (int_1 < DEB4EFBC * 2)
			{
				result.Y = int_0 / 3;
				int_1 -= DEB4EFBC;
			}
			else if (int_1 < DEB4EFBC * 3)
			{
				result.Y = int_0 / 3 * 2;
				int_1 -= DEB4EFBC * 2;
			}
			break;
		case 4:
			if (int_1 < DEB4EFBC)
			{
				result.Y = 0;
			}
			else if (int_1 < DEB4EFBC * 2)
			{
				result.Y = int_0 / 4;
				int_1 -= DEB4EFBC;
			}
			else if (int_1 < DEB4EFBC * 3)
			{
				result.Y = int_0 / 4 * 2;
				int_1 -= DEB4EFBC * 2;
			}
			else if (int_1 < DEB4EFBC * 4)
			{
				result.Y = int_0 / 4 * 3;
				int_1 -= DEB4EFBC * 3;
			}
			break;
		case 5:
			if (int_1 < DEB4EFBC)
			{
				result.Y = 0;
			}
			else if (int_1 < DEB4EFBC * 2)
			{
				result.Y = int_0 / 5;
				int_1 -= DEB4EFBC;
			}
			else if (int_1 < DEB4EFBC * 3)
			{
				result.Y = int_0 / 5 * 2;
				int_1 -= DEB4EFBC * 2;
			}
			else if (int_1 < DEB4EFBC * 4)
			{
				result.Y = int_0 / 5 * 3;
				int_1 -= DEB4EFBC * 3;
			}
			else
			{
				result.Y = int_0 / 5 * 4;
				int_1 -= DEB4EFBC * 4;
			}
			break;
		}
		int num = D81AD20A / DEB4EFBC;
		result.X = int_1 * num - 10;
		return result;
	}

	public static int smethod_58(ref List<int> list_0)
	{
		int result = 0;
		lock (list_0)
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				if (list_0[i] == 0)
				{
					result = i;
					list_0[i] = 1;
					break;
				}
			}
		}
		return result;
	}

	public static void EA9695BD(ref List<int> list_0, int AA291A15)
	{
		lock (list_0)
		{
			list_0[AA291A15] = 0;
		}
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckIP(byte[] byte_0);

	public static string smethod_59(string string_1 = "", int int_1 = 0, int B2172314 = 60)
	{
		string text = "";
		byte[] byte_ = smethod_11(string_1 + "*" + int_1);
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount <= B2172314 * 1000)
		{
			text = smethod_10(CheckIP(byte_));
			if (text != "")
			{
				break;
			}
		}
		return text;
	}

	public static void smethod_60(RichTextBox richTextBox_0, Label B40D3010, int C639ED82 = 0)
	{
		try
		{
			string text = B40D3010.Text;
			List<string> list = new List<string>();
			B40D3010.Text = text.Replace(newValue: "(" + ((C639ED82 != 0) ? richTextBox_0.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : richTextBox_0.Text.Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList()).Count + ")", oldValue: Regex.Match(text, "\\((.*?)\\)").Value);
		}
		catch
		{
		}
	}

	public static void smethod_61(Control EF9B2397, int int_1)
	{
		try
		{
			string text = EF9B2397.Text;
			EF9B2397.Text = text.Replace(Regex.Match(text, "\\((.*?)\\)").Value, "(" + int_1 + ")");
		}
		catch
		{
		}
	}

	public static void E814B702(RichTextBox richTextBox_0, Control control_0, int FEA6FBA3 = 0)
	{
		try
		{
			string text = control_0.Text;
			List<string> list = richTextBox_0.Lines.ToList();
			control_0.Text = text.Replace(newValue: "(" + ((FEA6FBA3 != 0) ? richTextBox_0.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : richTextBox_0.Text.Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList()).Count + ")", oldValue: Regex.Match(text, "\\((.*?)\\)").Value);
		}
		catch
		{
		}
	}

	public static void BFBDF687(GClass3 gclass3_0, Exception F4295AA7, string string_1 = "")
	{
		try
		{
			if (!Directory.Exists("log"))
			{
				Directory.CreateDirectory("log");
			}
			if (!Directory.Exists("log\\html"))
			{
				Directory.CreateDirectory("log\\html");
			}
			if (!Directory.Exists("log\\images"))
			{
				Directory.CreateDirectory("log\\images");
			}
			Random random = new Random();
			string text = DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + random.Next(1000, 9999);
			if (gclass3_0 != null)
			{
				string contents = gclass3_0.C12B8625();
				gclass3_0.method_33("log\\images\\", text);
				File.WriteAllText("log\\html\\" + text + ".html", contents);
			}
			using StreamWriter streamWriter = new StreamWriter("log\\log.txt", append: true);
			streamWriter.WriteLine("-----------------------------------------------------------------------------");
			streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
			streamWriter.WriteLine("File: " + text);
			if (string_1 != "")
			{
				streamWriter.WriteLine("Error: " + string_1);
			}
			streamWriter.WriteLine();
			if (F4295AA7 != null)
			{
				streamWriter.WriteLine("Type: " + F4295AA7.GetType().FullName);
				streamWriter.WriteLine("Message: " + F4295AA7.Message);
				streamWriter.WriteLine("StackTrace: " + F4295AA7.StackTrace);
				F4295AA7 = F4295AA7.InnerException;
			}
		}
		catch
		{
		}
	}

	public static void smethod_62(Exception exception_0, string D494F505 = "")
	{
		try
		{
			using StreamWriter streamWriter = new StreamWriter("log\\log.txt", append: true);
			streamWriter.WriteLine("-----------------------------------------------------------------------------");
			streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
			if (D494F505 != "")
			{
				streamWriter.WriteLine("Error: " + D494F505);
			}
			streamWriter.WriteLine();
			if (exception_0 != null)
			{
				streamWriter.WriteLine("Type: " + exception_0.GetType().FullName);
				streamWriter.WriteLine("Message: " + exception_0.Message);
				streamWriter.WriteLine("StackTrace: " + exception_0.StackTrace);
				exception_0 = exception_0.InnerException;
			}
		}
		catch
		{
		}
	}

	public static string smethod_63(string string_1, string string_2, int A7042DBD = 10)
	{
		Process process = new Process();
		process.StartInfo.FileName = string_1;
		process.StartInfo.Arguments = string_2;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardError = true;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
		process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
		StringBuilder D4920C94 = new StringBuilder();
		process.OutputDataReceived += delegate(object sender, DataReceivedEventArgs e)
		{
			if (!string.IsNullOrEmpty(e.Data))
			{
				D4920C94.Append(e.Data + "\n");
			}
		};
		process.Start();
		process.BeginOutputReadLine();
		if (A7042DBD < 0)
		{
			process.WaitForExit();
		}
		else
		{
			process.WaitForExit(A7042DBD * 1000);
		}
		process.Close();
		return D4920C94.ToString();
	}

	public static bool F118978B(string string_1)
	{
		bool flag = false;
		string text = smethod_63("rasdial.exe", "\"" + string_1 + "\"");
		if (text.Contains("Successfully connected to "))
		{
			flag = true;
		}
		else if (text.Contains("You are already connected to "))
		{
			for (int i = 0; i < 5; i++)
			{
				text = smethod_63("rasdial.exe", "\"" + string_1 + "\" /disconnect");
				if (!(text.Trim() == "Command completed successfully."))
				{
					smethod_53(2.0);
					continue;
				}
				flag = true;
				break;
			}
			smethod_53(2.0);
			if (flag)
			{
				for (int j = 0; j < 5; j++)
				{
					text = smethod_63("rasdial.exe", "\"" + string_1 + "\"");
					if (!text.Contains("Successfully connected to ") && !text.Contains("You are already connected to "))
					{
						smethod_53(2.0);
						continue;
					}
					flag = true;
					break;
				}
			}
			smethod_53(2.0);
		}
		else
		{
			flag = false;
		}
		return flag;
	}

	public static bool DB05192A(int CD3AF511, int FE88690E, string E0887CAE, string string_1, int D1B54CA1, string AABB7BAB)
	{
		bool result = false;
		string text = "";
		try
		{
			switch (CD3AF511)
			{
			case 0:
				return true;
			case 1:
			{
				string text2 = smethod_59();
				IntPtr intptr_ = GClass2.smethod_1(null, "HMA VPN");
				GClass2.ShowWindow(intptr_, 1);
				GClass2.smethod_0(intptr_);
				Thread.Sleep(1000);
				GClass2.FC09A4AA(GClass2.D281CD36(intptr_, "Chrome_RenderWidgetHostHWND", "Chrome Legacy Window"), 356, 286);
				Thread.Sleep(5000);
				string text3 = smethod_59();
				GClass2.FC09A4AA(GClass2.D281CD36(intptr_, "Chrome_RenderWidgetHostHWND", "Chrome Legacy Window"), 356, 286);
				int tickCount = Environment.TickCount;
				do
				{
					text = smethod_59();
				}
				while (Environment.TickCount - tickCount <= 20000 && (text == text2 || text == text3));
				if (text != text2)
				{
					result = true;
				}
				break;
			}
			case 2:
			{
				if (FE88690E == 0)
				{
					result = F118978B(E0887CAE);
					break;
				}
				int num = smethod_64(string_1);
				if (num == 0)
				{
					Thread.Sleep(2000);
					num = smethod_64(string_1);
				}
				result = num == 1;
				break;
			}
			}
		}
		catch (Exception f4295AA)
		{
			BFBDF687(null, f4295AA, "Error ChangeIP");
		}
		return result;
	}

	public static int smethod_64(string AD330D86)
	{
		int result = -1;
		try
		{
			string value = Regex.Match(AD330D86, "(http://.*?)/").Groups[1].Value;
			if (value == "")
			{
				value = Regex.Match(AD330D86, "(https://.*?)/").Groups[1].Value;
			}
			GClass12 gClass = new GClass12("", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/89.0.4389.90 Safari/537.36");
			string input = gClass.method_0(value);
			string text = "";
			try
			{
				text = Regex.Matches(input, "csrf_token\" content=\"(.*?)\"")[1].Groups[1].Value;
			}
			catch
			{
				text = Regex.Match(gClass.method_0(value + "/api/webserver/token"), "<token>(.*?)</token>").Groups[1].Value;
			}
			input = gClass.method_0(value + "/api/dialup/mobile-dataswitch");
			string text2 = "";
			if (input.Contains("dataswitch>1"))
			{
				text2 = input.Replace("response", "request").Replace("dataswitch>1", "dataswitch>0");
			}
			else
			{
				if (!input.Contains("dataswitch>0"))
				{
					return -1;
				}
				text2 = input.Replace("response", "request").Replace("dataswitch>0", "dataswitch>1");
			}
			gClass.requestHTTP_0.SetDefaultHeaders(new string[2]
			{
				"__RequestVerificationToken: " + text,
				"content-type: text/xml"
			});
			string text3 = gClass.A9AEE5A7(value + "/api/dialup/mobile-dataswitch", text2);
			if (text3.Contains("OK"))
			{
				input = gClass.method_0(value + "/api/dialup/mobile-dataswitch");
				if (input.Contains("dataswitch>1<"))
				{
					for (int i = 0; i < 10; i++)
					{
						string text4 = gClass.method_0(value + "/api/monitoring/traffic-statistics");
						if (!text4.Contains("<CurrentUpload>0"))
						{
							break;
						}
						Thread.Sleep(1000);
					}
				}
				return Convert.ToInt32(Regex.Match(input, "dataswitch>(.*?)<").Groups[1].Value);
			}
			result = -1;
		}
		catch
		{
		}
		return result;
	}

	public static DateTime smethod_65(string string_1, string string_2 = "dd/MM/yyyy HH:mm:ss")
	{
		return DateTime.ParseExact(string_1, string_2, CultureInfo.InvariantCulture);
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetTotp(byte[] C517822E);

	public static string smethod_66(string string_1)
	{
		return smethod_10(GetTotp(smethod_11(string_1)));
	}

	public static DataTable FA3CA29C(DataTable dataTable_0)
	{
		DataTable result = new DataTable();
		try
		{
			result = (from DataRow dataRow_0 in dataTable_0.Rows
				orderby Class57.random_0.Next()
				select dataRow_0).CopyToDataTable();
		}
		catch
		{
		}
		return result;
	}

	public static bool B41DE232(string A63AF195, string string_1)
	{
		try
		{
			smethod_32(string_1);
			string[] directories = Directory.GetDirectories(A63AF195, "*", SearchOption.AllDirectories);
			foreach (string text in directories)
			{
				Directory.CreateDirectory(text.Replace(A63AF195, string_1));
			}
			string[] files = Directory.GetFiles(A63AF195, "*.*", SearchOption.AllDirectories);
			foreach (string text2 in files)
			{
				File.Copy(text2, text2.Replace(A63AF195, string_1), overwrite: true);
			}
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static bool EF9599B0(string string_1, string B32F6BBD)
	{
		try
		{
			Directory.Move(string_1, B32F6BBD);
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static bool smethod_67(string string_1)
	{
		try
		{
			Directory.Delete(string_1, recursive: true);
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static void B32C4106(string string_1, string string_2)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_1);
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				if (directoryInfo2.Name.StartsWith(string_2))
				{
					smethod_67(string_1 + "\\" + directoryInfo2.Name);
				}
			}
		}
		catch
		{
		}
	}

	public static bool smethod_68(string string_1)
	{
		try
		{
			if (string_1.Trim().Length == 0)
			{
				return false;
			}
			string_1 = string_1.Replace("\"", "\\\"");
			string value = smethod_88("IsVNName(\"" + string_1 + "\")");
			return Convert.ToBoolean(value);
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static bool smethod_69(string CA2EC98E)
	{
		return new Regex("^[a-zA-Z .]+$").IsMatch(CA2EC98E) && !smethod_68(CA2EC98E);
	}

	public static string smethod_70(string string_1)
	{
		Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
		string input = string_1.Normalize(NormalizationForm.FormD);
		return regex.Replace(input, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
	}

	public static bool smethod_71(string string_1)
	{
		try
		{
			File.Delete(string_1);
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_72(List<string> list_0)
	{
		try
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				smethod_71(list_0[i]);
			}
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static string smethod_73()
	{
		string result = "";
		string newValue = "chrome.exe";
		object value = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\<executableFileName>".Replace("<executableFileName>", newValue), "", null);
		if (value == null)
		{
			value = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\App Paths\\<executableFileName>".Replace("<executableFileName>", newValue), "", null);
			if (value != null)
			{
				result = value.ToString();
			}
		}
		else
		{
			result = value.ToString();
		}
		return result;
	}

	public static string smethod_74()
	{
		return FileVersionInfo.GetVersionInfo(smethod_73().ToString()).FileVersion;
	}

	internal static int B7A07C09(int int_1, int E002AC93)
	{
		if (int_1 > E002AC93)
		{
			return Class57.random_0.Next(E002AC93, int_1 + 1);
		}
		return Class57.random_0.Next(int_1, E002AC93 + 1);
	}

	public static Form D2138C0F(string string_1, params object[] DC3F46B1)
	{
		Type type = Type.GetType("maxcare." + string_1);
		if (type != null)
		{
			try
			{
				return (Form)Activator.CreateInstance(type, DC3F46B1);
			}
			catch (Exception)
			{
			}
		}
		return null;
	}

	public static IEnumerable<Control> smethod_75(Control control_0)
	{
		IEnumerable<Control> enumerable = control_0.Controls.Cast<Control>();
		return enumerable.SelectMany((Control control_0) => smethod_75(control_0)).Concat(enumerable);
	}

	internal static void smethod_76(string string_1, string EDA26E87, bool bool_0)
	{
		try
		{
			File.Copy(string_1, EDA26E87, bool_0);
		}
		catch
		{
		}
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckMD5(byte[] E019D414);

	public static string DE8498B3(string string_1)
	{
		return smethod_10(CheckMD5(smethod_11(string_1)));
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr ChangeMD5(byte[] byte_0);

	public static void smethod_77(string string_1)
	{
		ChangeMD5(smethod_11(string_1));
	}

	public static string smethod_78(string string_1, List<string> list_0)
	{
		int num = 0;
		while (true)
		{
			if (num < list_0.Count)
			{
				if (string_1.Contains(list_0[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return "";
		}
		return list_0[num];
	}

	public static void smethod_79(ref DataGridView dataGridView_0, int int_1, int int_2, int CE3870A1 = 1)
	{
		string text = "";
		for (int i = CE3870A1; i < dataGridView_0.Columns.Count; i++)
		{
			text = GClass27.smethod_2(dataGridView_0, int_1, i);
			GClass27.smethod_4(dataGridView_0, int_1, i, GClass27.smethod_2(dataGridView_0, int_2, i));
			GClass27.smethod_4(dataGridView_0, int_2, i, text);
		}
	}

	internal static List<string> smethod_80(string D505DC39)
	{
		if (Directory.Exists(D505DC39))
		{
			return Directory.GetFiles(D505DC39).ToList();
		}
		return new List<string>();
	}

	internal static void FB0F49A9(string EE9BBA81)
	{
		try
		{
			Process.Start("chrome.exe", EE9BBA81);
		}
		catch
		{
			Process.Start(EE9BBA81);
		}
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CloneDatabase(byte[] BCBB9FB9, byte[] byte_0);

	public static bool CD2DD527()
	{
		string text = Class57.string_0 + "\\database\\db_maxcare.sqlite";
		string fileName = Path.GetFileName(text);
		string text2 = GClass25.smethod_0("configInteractGeneral").C0288288("txtBackupDBPath", Environment.GetEnvironmentVariable("LocalAppData") + "\\database");
		smethod_32(text2);
		if (!Directory.Exists(text2))
		{
			text2 = Environment.GetEnvironmentVariable("LocalAppData") + "\\database";
			smethod_32(text2);
		}
		string string_ = text2 + "\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + fileName;
		string text3 = smethod_10(CloneDatabase(smethod_11(text), smethod_11(string_)));
		return text3.ToLower().Contains("true");
	}

	public static string smethod_81()
	{
		string text = DateTime.Now.ToString("yyMMdd") + smethod_52(4) + smethod_51(5);
		if (GClass25.smethod_0("configCheckpoint").method_2("typePass") == 0)
		{
			text = GClass25.smethod_0("configCheckpoint").C0288288("txtPass");
		}
		return text.A3A66D03(1);
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr DownloadImage282(byte[] byte_0, byte[] byte_1);

	internal static string smethod_82(string string_1, string D4A86139)
	{
		return smethod_10(DownloadImage282(smethod_11(string_1), smethod_11(D4A86139)));
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CreateProfile(byte[] D392BD2E, byte[] C61A591B);

	internal static string smethod_83(string string_1, string string_2 = "", string D618CF03 = "", string string_3 = "")
	{
		string fileName = Path.GetFileName(string_1);
		string_1 = Path.GetDirectoryName(string_1);
		GClass11 gClass = new GClass11();
		gClass.method_4("profileName", fileName);
		gClass.method_4("useragent", string_2);
		gClass.method_4("startupPage", D618CF03);
		gClass.method_4("proxy", string_3);
		return smethod_10(CreateProfile(smethod_11(string_1), smethod_11(gClass.method_7())));
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr ExportCrx(byte[] B186FBBD);

	internal static string F893209E(string string_1)
	{
		return smethod_10(ExportCrx(smethod_11(string_1)));
	}

	public static string smethod_84(string string_1)
	{
		return Regex.Replace(string_1, "\\p{Cs}", "");
	}

	public static bool F410A322(string FA2010A4)
	{
		return FA2010A4.Length != Regex.Replace(FA2010A4, "\\p{Cs}", "").Length;
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr DeleteTempFile();

	internal static void smethod_85()
	{
		DeleteTempFile();
	}

	public static void B4A7A29C(int int_1 = 3)
	{
		Process.Start(Application.ExecutablePath);
		smethod_53(int_1);
		Process.GetCurrentProcess().Kill();
	}

	internal static void smethod_86(string string_1, string string_2, string string_3 = "", string string_4 = "")
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo(string_1);
		string_4 = "G:\\SourceCode\\MaxCare\\maxcare\\bin\\Debug\\extension\\getcookiefplus.crx";
		string text = " --user-data-dir=\"" + string_2 + "\"";
		if (!string.IsNullOrEmpty(string_3))
		{
			text = text + " --proxy-server=" + string_3 + " --host-resolver-rules=\"MAP * 0.0.0.0 , EXCLUDE " + string_3.Split(':')[0] + "\"";
		}
		if (!string.IsNullOrEmpty(string_4))
		{
			F893209E(string_4);
			string_4 = string_4.Replace(".crx", "");
			text = text + " --load-extension=" + string_4;
		}
		process.StartInfo.Arguments = text;
		process.Start();
		process.WaitForExit();
		process.Close();
	}

	public static void smethod_87(string string_1)
	{
		try
		{
			if (string_1.Trim() == "")
			{
				return;
			}
			Process[] processesByName = Process.GetProcessesByName("chrome");
			foreach (Process process in processesByName)
			{
				string queryString = "SELECT CommandLine FROM Win32_Process WHERE ProcessId = " + process.Id;
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(queryString);
				foreach (ManagementBaseObject item in managementObjectSearcher.Get())
				{
					try
					{
						ManagementObject managementObject = item as ManagementObject;
						if (managementObject != null && managementObject != null)
						{
							object obj = managementObject["CommandLine"];
							if (obj != null && obj.ToString().Contains(string_1))
							{
								process.Kill();
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RunCode2(byte[] byte_0);

	public static string smethod_88(string string_1)
	{
		return smethod_10(RunCode2(smethod_11(string_1)));
	}

	public static int smethod_89()
	{
		int result = 0;
		Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		try
		{
			IPEndPoint localEP = new IPEndPoint(IPAddress.Any, 0);
			socket.Bind(localEP);
			localEP = (IPEndPoint)socket.LocalEndPoint;
			result = localEP.Port;
		}
		finally
		{
			socket.Close();
		}
		return result;
	}

	public static string smethod_90(string B38881BB)
	{
		int num = 0;
		string text;
		while (true)
		{
			if (num < 3)
			{
				text = smethod_88("FindIdFacebook('" + B38881BB + "')");
				if (text != "")
				{
					break;
				}
				smethod_53(1.0);
				num++;
				continue;
			}
			return "";
		}
		return text;
	}

	public static bool C23C7090(string B0B7520F)
	{
		return B0B7520F.Contains("KGOvhWyM65Y.png") || B0B7520F.Contains("CCnQRnuNDBB.png") || B0B7520F.Contains("FpkwdkKVsK1.png") || B0B7520F.Contains("grA_kEpJlYT.png") || B0B7520F.Contains("46WQRa5uPUD.png") || B0B7520F.Contains("/help/203305893040179") || B0B7520F.Contains("/images/checkpoint/epsilon/comet/limbo-dark.png") || B0B7520F.Contains("/images/checkpoint/epsilon/comet/limbo-light.png");
	}

	internal static bool smethod_91(string string_1)
	{
		return string_1.Contains("/x/checkpoint/828281030927956/stepper/") || string_1.Contains("BJIhXF-EEq9.png");
	}

	internal static void CD18FD80(string C7B2ADAC)
	{
		try
		{
			try
			{
				Process.Start("chrome.exe", C7B2ADAC);
			}
			catch
			{
				Process.Start(C7B2ADAC);
			}
		}
		catch (Exception)
		{
		}
	}

	public static bool smethod_92(string string_1, List<string> F39BD5AF)
	{
		int num = 0;
		while (true)
		{
			if (num < F39BD5AF.Count)
			{
				if (Regex.IsMatch(string_1, F39BD5AF[num]) || string_1.Contains(F39BD5AF[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RandomString(byte[] byte_0, byte[] B3970D0A);

	public static string smethod_93(int EA031B87, string string_1)
	{
		return smethod_10(RandomString(smethod_11(EA031B87.ToString()), smethod_11(string_1)));
	}

	internal static string smethod_94(string EB0858A9, string string_1)
	{
		string text = "";
		for (int i = 0; i < 5; i++)
		{
			try
			{
				byte[] inArray = new F3958F9B().F204C69A(string_1);
				text = Convert.ToBase64String(inArray);
				if (text != "")
				{
					return text;
				}
			}
			catch (Exception)
			{
				text = "";
			}
			smethod_53(1.0);
		}
		return text;
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr DeleteCacheProfile(byte[] byte_0);

	internal static void BF940611(string string_1)
	{
		DeleteCacheProfile(smethod_11(string_1));
	}

	public static System.Drawing.Point smethod_95(Process process_0)
	{
		IntPtr mainWindowHandle = process_0.MainWindowHandle;
		Rect C0174C = default(Rect);
		C13DF1B3.GetWindowRect(mainWindowHandle, ref C0174C);
		return new System.Drawing.Point((int)C0174C.Width, (int)C0174C.Height);
	}

	public static string smethod_96(string A5AD82BB, string C387CC15)
	{
		return Regex.Match(A5AD82BB, C387CC15).Groups[1].Value;
	}
}
