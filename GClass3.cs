using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

public class GClass3
{
	[Serializable]
	[CompilerGenerated]
	private sealed class FD0F9117
	{
		public static readonly FD0F9117 _003C_003E9 = new FD0F9117();

		public static Func<string, string> _003C_003E9__172_0;

		public static Func<string, string, string> _003C_003E9__172_1;

		public static Func<string, Guid> _003C_003E9__302_0;

		public static Func<string, Guid> _003C_003E9__302_1;

		public static Func<string, Guid> _003C_003E9__302_2;

		public static Func<KeyValuePair<string, string>, string> _003C_003E9__407_0;

		internal string method_0(string string_0)
		{
			return string_0.Trim();
		}

		internal string method_1(string F223B6B4, string string_0)
		{
			return F223B6B4 + " " + (string_0.Contains(" ") ? ("\"" + string_0 + "\"") : string_0);
		}

		internal Guid method_2(string string_0)
		{
			return Guid.NewGuid();
		}

		internal Guid E8028583(string string_0)
		{
			return Guid.NewGuid();
		}

		internal Guid method_3(string C18C919B)
		{
			return Guid.NewGuid();
		}

		internal string method_4(KeyValuePair<string, string> keyValuePair_0)
		{
			return WebUtility.UrlEncode(keyValuePair_0.Key) + "=" + WebUtility.UrlEncode(keyValuePair_0.Value);
		}
	}

	[CompilerGenerated]
	private sealed class Class6
	{
		public string string_0;

		public Func<Process, bool> func_0;

		internal bool F9AE7FB3(Process D02C5803)
		{
			return D02C5803.MainWindowTitle.Contains(string_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class7
	{
		public List<string> E02BDC8B;

		public List<string> list_0;
	}

	[CompilerGenerated]
	private sealed class A09AF4B5
	{
		public string string_0;

		public string D9210C95;

		public string string_1;

		public int EAA44998;

		public int int_0;

		public Class7 CB872DB9;
	}

	[CompilerGenerated]
	private sealed class Class8
	{
		public int int_0;

		public A09AF4B5 B7065308;

		internal void method_0()
		{
			try
			{
				bool flag = false;
				string text = B7065308.CB872DB9.E02BDC8B[int_0].Split('|')[0];
				F3958F9B f3958F9B = new F3958F9B(B7065308.string_0, B7065308.D9210C95, B7065308.string_1, B7065308.EAA44998);
				string text2 = f3958F9B.method_0("https://mbasic.facebook.com/groups/" + text + "/madminpanel");
				if (text2.Contains("/help/contact/571927962827151") || text2.Contains("madminpanel/pending/"))
				{
					flag = true;
				}
				lock (B7065308.CB872DB9.list_0)
				{
					B7065308.CB872DB9.list_0.Add(B7065308.CB872DB9.E02BDC8B[int_0] + "|" + flag);
				}
			}
			catch
			{
			}
			Interlocked.Decrement(ref B7065308.int_0);
		}
	}

	public int int_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Process process_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Process process_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ChromeDriver F68BD006;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool F426D01A;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool AF08743A;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal bool A988A490;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal bool bool_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal Point C139D32A;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Point point_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_2;

	public bool D8B82A92 = false;

	private string string_2;

	private int B89B8128;

	private string E599E997 = "";

	private string string_3 = "";

	private string string_4 = "";

	private string string_5 = "";

	private string B9AD3E2A = "";

	private string string_6 = "";

	private string B0094F8A = "";

	private string DFA50A09 = "";

	private bool bool_3 = false;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool C93E1E9E = false;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal bool bool_4 = false;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_5 = false;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string DEB7B718;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string F0ABC297;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal bool bool_6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal bool bool_7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string E62D880A;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal double F299D896;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal Point F0A48904;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_9;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private GEnum3 genum3_0;

	private Class52 class52_0;

	private string string_10 = "";

	public bool bool_8 = false;

	public int FE879F1A = -1;

	public bool A218C3AD = false;

	private int BE02F7AB = 0;

	private int int_4 = 0;

	private int int_5 = 0;

	private int AC1BE00A = 0;

	private string string_11 = "";

	public Process EC234D1D
	{
		[CompilerGenerated]
		get
		{
			return process_0;
		}
		[CompilerGenerated]
		set
		{
			process_0 = value;
		}
	}

	public Process Process_0
	{
		[CompilerGenerated]
		get
		{
			return process_1;
		}
		[CompilerGenerated]
		set
		{
			process_1 = value;
		}
	}

	public ChromeDriver ChromeDriver_0
	{
		[CompilerGenerated]
		get
		{
			return F68BD006;
		}
		[CompilerGenerated]
		set
		{
			F68BD006 = value;
		}
	}

	public bool Boolean_0
	{
		[CompilerGenerated]
		get
		{
			return F426D01A;
		}
		[CompilerGenerated]
		set
		{
			F426D01A = value;
		}
	}

	public bool Boolean_1
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public bool Boolean_2
	{
		[CompilerGenerated]
		get
		{
			return AF08743A;
		}
		[CompilerGenerated]
		set
		{
			AF08743A = value;
		}
	}

	public bool Boolean_3
	{
		[CompilerGenerated]
		get
		{
			return A988A490;
		}
		[CompilerGenerated]
		set
		{
			A988A490 = value;
		}
	}

	public bool Boolean_4
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public string DEB56B05
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public Point D780F8B7
	{
		[CompilerGenerated]
		get
		{
			return C139D32A;
		}
		[CompilerGenerated]
		set
		{
			C139D32A = value;
		}
	}

	public Point B0B3B9A3
	{
		[CompilerGenerated]
		get
		{
			return point_0;
		}
		[CompilerGenerated]
		set
		{
			point_0 = value;
		}
	}

	public bool EA39AD33
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	public string String_1
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
		}
	}

	public int D491453C
	{
		get
		{
			return B89B8128;
		}
		set
		{
			B89B8128 = value;
		}
	}

	public string String_2
	{
		get
		{
			return E599E997;
		}
		set
		{
			E599E997 = value;
		}
	}

	public string String_3
	{
		get
		{
			return string_3;
		}
		set
		{
			string_3 = value;
		}
	}

	public string CCBE39A8
	{
		get
		{
			return string_4;
		}
		set
		{
			string_4 = value;
		}
	}

	public string String_4
	{
		get
		{
			return string_5;
		}
		set
		{
			string_5 = value;
		}
	}

	public string String_5
	{
		get
		{
			return B9AD3E2A;
		}
		set
		{
			B9AD3E2A = value;
		}
	}

	public string D32E1816
	{
		get
		{
			return string_6;
		}
		set
		{
			string_6 = value;
		}
	}

	public string String_6
	{
		get
		{
			return B0094F8A;
		}
		set
		{
			B0094F8A = value;
		}
	}

	public string String_7
	{
		get
		{
			return DFA50A09;
		}
		set
		{
			DFA50A09 = value;
		}
	}

	public bool DA0E8786
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
		}
	}

	public bool F89E3721
	{
		[CompilerGenerated]
		get
		{
			return C93E1E9E;
		}
		[CompilerGenerated]
		set
		{
			C93E1E9E = value;
		}
	}

	public bool Boolean_5
	{
		[CompilerGenerated]
		get
		{
			return bool_4;
		}
		[CompilerGenerated]
		set
		{
			bool_4 = value;
		}
	}

	public bool Boolean_6
	{
		[CompilerGenerated]
		get
		{
			return bool_5;
		}
		[CompilerGenerated]
		set
		{
			bool_5 = value;
		}
	}

	public string String_8
	{
		[CompilerGenerated]
		get
		{
			return DEB7B718;
		}
		[CompilerGenerated]
		set
		{
			DEB7B718 = value;
		}
	}

	public int Int32_1
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		set
		{
			int_2 = value;
		}
	}

	public string String_9
	{
		[CompilerGenerated]
		get
		{
			return F0ABC297;
		}
		[CompilerGenerated]
		set
		{
			F0ABC297 = value;
		}
	}

	public string String_10
	{
		[CompilerGenerated]
		get
		{
			return string_7;
		}
		[CompilerGenerated]
		set
		{
			string_7 = value;
		}
	}

	public string String_11
	{
		[CompilerGenerated]
		get
		{
			return string_8;
		}
		[CompilerGenerated]
		set
		{
			string_8 = value;
		}
	}

	public bool Boolean_7
	{
		[CompilerGenerated]
		get
		{
			return bool_6;
		}
		[CompilerGenerated]
		set
		{
			bool_6 = value;
		}
	}

	public bool A21FAE98
	{
		[CompilerGenerated]
		get
		{
			return bool_7;
		}
		[CompilerGenerated]
		set
		{
			bool_7 = value;
		}
	}

	public string B220C71B
	{
		[CompilerGenerated]
		get
		{
			return E62D880A;
		}
		[CompilerGenerated]
		set
		{
			E62D880A = value;
		}
	}

	public double BF0BDA27
	{
		[CompilerGenerated]
		get
		{
			return F299D896;
		}
		[CompilerGenerated]
		set
		{
			F299D896 = value;
		}
	}

	public Point D301B0B2
	{
		[CompilerGenerated]
		get
		{
			return F0A48904;
		}
		[CompilerGenerated]
		set
		{
			F0A48904 = value;
		}
	}

	public int Int32_2
	{
		[CompilerGenerated]
		get
		{
			return int_3;
		}
		[CompilerGenerated]
		set
		{
			int_3 = value;
		}
	}

	public string A294ABA3
	{
		[CompilerGenerated]
		get
		{
			return string_9;
		}
		[CompilerGenerated]
		set
		{
			string_9 = value;
		}
	}

	public GEnum3 GEnum3_0
	{
		[CompilerGenerated]
		get
		{
			return genum3_0;
		}
		[CompilerGenerated]
		set
		{
			genum3_0 = value;
		}
	}

	public GClass3()
	{
		int_0 = 0;
		Boolean_0 = false;
		Boolean_2 = false;
		Boolean_3 = true;
		Boolean_1 = false;
		DEB56B05 = "";
		String_0 = "";
		D780F8B7 = new Point(300, 300);
		D780F8B7 = new Point(D780F8B7.X, D780F8B7.Y);
		String_8 = "";
		Int32_1 = 0;
		B0B3B9A3 = new Point(B0B3B9A3.X, B0B3B9A3.Y);
		String_9 = "";
		Boolean_4 = false;
		String_10 = "";
		String_11 = "data\\extension";
		Boolean_7 = false;
		D301B0B2 = new Point(300, 300);
		GEnum3_0 = GEnum3.BAA111A3;
		A21FAE98 = false;
		B220C71B = "";
		BF0BDA27 = 1.0;
		EA39AD33 = true;
	}

	public (bool success, string error) method_0()
	{
		int num = 3;
		bool item;
		while (true)
		{
			if (GClass25.smethod_0("configGeneral").C0288288("sizeChrome").Contains("x"))
			{
				Boolean_7 = true;
				string text = GClass25.smethod_0("configGeneral").C0288288("sizeChrome").Substring(0, GClass25.smethod_0("configGeneral").C0288288("sizeChrome").LastIndexOf('x'));
				int int32_ = Convert.ToInt32(GClass25.smethod_0("configGeneral").C0288288("sizeChrome").Split('x')[2]);
				D301B0B2 = new Point(Convert.ToInt32(text.Split('x')[0]), Convert.ToInt32(text.Split('x')[1]));
				Int32_0 = int32_;
				DEB56B05 = DEB56B05;
			}
			String_10 = GClass25.smethod_0("configGeneral").C0288288("txtLinkToOtherBrowser").Trim();
			A21FAE98 = GClass25.smethod_0("configGeneral").method_3("ckbUsePortable");
			B220C71B = GClass25.smethod_0("configGeneral").C0288288("txtPathToPortableZip");
			if (!Boolean_0)
			{
				Boolean_0 = GClass25.smethod_0("configGeneral").method_3("ckbHideBrowser");
			}
			if (F89E3721 || Boolean_5 || Boolean_6)
			{
				Boolean_2 = false;
				if (!F89E3721)
				{
					Boolean_0 = false;
				}
			}
			if (Boolean_0)
			{
				Boolean_2 = true;
			}
			item = false;
			try
			{
				ChromeOptions chromeOptions = new ChromeOptions();
				int_5 = D780F8B7.X;
				AC1BE00A = D780F8B7.Y;
				BE02F7AB = B0B3B9A3.X;
				int_4 = B0B3B9A3.Y;
				chromeOptions.AddArguments("--window-size=" + D780F8B7.X + "," + D780F8B7.Y, "--window-position=" + B0B3B9A3.X + "," + B0B3B9A3.Y);
				chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.geolocation", 0);
				chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.images", 0);
				if (Boolean_3)
				{
					chromeOptions.AddArgument("--mute-audio");
				}
				chromeOptions.AddArgument("--disable-blink-features=AutomationControlled");
				chromeOptions.AddAdditionalCapability("useAutomationExtension", false);
				chromeOptions.AddExcludedArgument("enable-automation");
				chromeOptions.AddUserProfilePreference("credentials_enable_service", false);
				chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);
				if (BF0BDA27 == 1.0)
				{
					BF0BDA27 = (double)GClass25.smethod_0("configGeneral").method_2("nudChromeScale", 100) * 1.0 / 100.0;
				}
				if (BF0BDA27 != 1.0)
				{
					chromeOptions.AddArgument("--force-device-scale-factor=" + BF0BDA27);
				}
				if (String_10 != "")
				{
					string text2 = String_10;
					if (!text2.EndsWith(".exe"))
					{
						text2 = (File.Exists(text2 + ".exe") ? (text2 + ".exe") : ((!File.Exists(text2 + "\\chrome.exe")) ? "" : (text2 + "\\chrome.exe")));
					}
					if (text2 != "" && File.Exists(text2))
					{
						chromeOptions.BinaryLocation = text2;
					}
				}
				if (Boolean_0)
				{
					chromeOptions.AddArgument("--headless=new");
				}
				if (Boolean_2)
				{
					chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
				}
				if (!string.IsNullOrEmpty(String_0.Trim()))
				{
					if (GClass25.smethod_0("configInteractGeneral").method_3("ckbXoaProfile"))
					{
						GClass8.smethod_67(String_0);
					}
					if (A21FAE98)
					{
						if (!Directory.Exists(String_0))
						{
							ZipFile.ExtractToDirectory(B220C71B, String_0);
						}
						chromeOptions.BinaryLocation = String_0 + "\\App\\Chrome-bin\\chrome.exe";
						chromeOptions.AddArgument("--user-data-dir=" + String_0 + "\\Data\\profile");
					}
					else
					{
						try
						{
							chromeOptions.AddArgument("--user-data-dir=" + String_0);
						}
						catch (Exception)
						{
						}
					}
				}
				if (Boolean_1)
				{
					chromeOptions.AddArguments("--incognito");
				}
				if (String_11.Trim() != "")
				{
					if (!Directory.Exists(String_11))
					{
						Directory.CreateDirectory(String_11);
					}
					List<string> list = GClass8.smethod_80(String_11);
					for (int i = 0; i < list.Count; i++)
					{
						chromeOptions.AddExtension(list[i]);
					}
				}
				if (!string.IsNullOrEmpty(String_9.Trim()))
				{
					chromeOptions.AddArgument("--app=" + String_9);
				}
				if (Boolean_4)
				{
					chromeOptions.AddArgument("--autoplay-policy=no-user-gesture-required");
				}
				chromeOptions.AddArguments("--disable-background-networking", "--disable-bundled-ppapi-flash", "--disable-client-side-phishing-detection", "--disable-default-apps", "--disable-hang-monitor", "--disable-prompt-on-repost", "--disable-sync", "--enable-blink-features=ShadowDOMV0", "--disable-notifications", "--no-sandbox", "--disable-gpu", "--disable-dev-shm-usage", "--disable-web-security", "--disable-rtc-smoothness-algorithm", "--disable-webrtc-hw-decoding", "--disable-webrtc-hw-encoding", "--disable-webrtc-multiple-routes", "--disable-webrtc-hw-vp8-encoding", "--enforce-webrtc-ip-permission-check", "--force-webrtc-ip-handling-policy", "--ignore-certificate-errors", "--disable-infobars", "--disable-blink-features=BlockCredentialedSubresources", "--disable-popup-blocking", "--no-default-browser-check", "--no-first-run", "--lang=en_US", "--hide-crash-restore-bubble");
				if (!string.IsNullOrEmpty(DEB56B05) && !F89E3721 && !Boolean_5)
				{
					chromeOptions.AddArgument("--user-agent=" + DEB56B05);
				}
				string text3 = "";
				String_8 = String_8.Trim().TrimEnd(':');
				if (!string.IsNullOrEmpty(String_8))
				{
					if (String_8.Split(':').Length == 1)
					{
						String_8 = "127.0.0.1:" + String_8;
					}
					if (GClass25.smethod_0("configGeneral").method_3("ckbUseExtensionProxy"))
					{
						chromeOptions.AddArgument("--load-extension=" + GClass28.smethod_0() + "\\extension\\Proxy");
						switch (String_8.Split(':').Length)
						{
						case 4:
							text3 = DFAD1D17(Int32_1, String_8.Split(':')[0], Convert.ToInt32(String_8.Split(':')[1]), String_8.Split(':')[2], String_8.Split(':')[3]);
							break;
						case 2:
							text3 = DFAD1D17(Int32_1, String_8.Split(':')[0], Convert.ToInt32(String_8.Split(':')[1]));
							break;
						}
					}
					else
					{
						chromeOptions.AddArgument("--proxy-server=" + ((Int32_1 == 0) ? "" : "socks5://") + String_8.Split(':')[0] + ":" + String_8.Split(':')[1]);
					}
				}
				ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
				if (!string.IsNullOrEmpty(chromeOptions.BinaryLocation))
				{
					string directoryName = Path.GetDirectoryName(chromeOptions.BinaryLocation);
					chromeDriverService = ((!File.Exists(directoryName + "\\chromedriver.exe")) ? ChromeDriverService.CreateDefaultService(GClass28.smethod_0()) : ChromeDriverService.CreateDefaultService(directoryName));
				}
				bool flag = GClass25.smethod_0("configGeneral").method_3("ckbGologin") && String_0 != "";
				bool flag2 = Class52.smethod_0();
				if (flag || flag2)
				{
					if (flag)
					{
						string path = (chromeOptions.BinaryLocation = GClass25.smethod_0("configGeneral").C0288288("txtOrbitaPath"));
						chromeDriverService = ChromeDriverService.CreateDefaultService(Path.GetDirectoryName(path));
						string text5 = String_0 + "\\Default\\Preferences";
						if (!File.Exists(text5) || !File.ReadAllText(text5).Contains("gologin"))
						{
							GClass8.smethod_83(String_0);
						}
						try
						{
							string text6 = "gologin\\" + E599E997 + ".config";
							string text7 = File.ReadAllText(File.Exists(text6) ? text6 : text5);
							if (DEB56B05 == "")
							{
								DEB56B05 = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/113.0.0.0 Safari/537.36";
							}
							string value = Regex.Match(text7, "\"userAgent\":.*?\"(.*?)\"").Groups[1].Value;
							if (value != DEB56B05)
							{
								text7 = text7.Replace(value, DEB56B05);
							}
							string value2 = Regex.Match(text7, "\"proxy\":.*?\\{.*?\\},", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.CultureInvariant).Value;
							text7 = ((String_8.Split(':').Length != 4) ? text7.Replace(value2, "\"proxy\": { \"password\": \"\", \"username\": \"\" },") : text7.Replace(value2, "\"proxy\": { \"password\": \"" + String_8.Split(':')[3] + "\", \"username\": \"" + String_8.Split(':')[2] + "\" },"));
							File.WriteAllText(text5, text7);
							File.WriteAllText(text6, text7);
						}
						catch (Exception)
						{
						}
					}
					else if (flag2)
					{
						class52_0 = new Class52(E599E997);
						class52_0.method_3(String_8, DEB56B05);
					}
				}
				else
				{
					chromeOptions.AddArgument("--disable-3d-apis");
					chromeOptions.AddArgument("--disable-webgl");
					if (String_0 != "")
					{
						GClass8.smethod_71(String_0 + "\\Default\\Preferences");
					}
					if (!GClass25.smethod_0("configGeneral").method_3("ckbUseExtensionProxy") && String_8.Split(':').Length == 4)
					{
						chromeOptions.AddExtension("extension\\proxy1.crx");
					}
				}
				List<string> list2 = new List<string>();
				if (String_11.Trim() != "")
				{
					List<string> list3 = Directory.GetDirectories(String_11).ToList();
					for (int j = 0; j < list3.Count; j++)
					{
						list2.Add(GClass28.smethod_0() + "\\" + list3[j]);
					}
				}
				if (list2.Count > 0)
				{
					chromeOptions.AddArgument("--load-extension=" + string.Join(",", list2));
				}
				if (flag2)
				{
					string text8 = chromeOptions.Arguments.Select((string string_0) => string_0.Trim()).Aggregate("", (string F223B6B4, string string_0) => F223B6B4 + " " + (string_0.Contains(" ") ? ("\"" + string_0 + "\"") : string_0));
					text8 = text8.Replace("--no-sandbox", "");
					text8 = text8.Replace("--disable-web-security", "");
					text8 = text8.Replace("--ignore-certificate-errors", "");
					text8 = text8.Replace("--disable-blink-features=BlockCredentialedSubresources", "");
					text8 = text8.Replace("--disable-blink-features=AutomationControlled", "");
					text8 = text8.Replace("--enable-blink-features=ShadowDOMV0", "");
					text8 = text8.Trim() + " ";
					if (text8.Contains("--proxy-server="))
					{
						text8 = text8.Replace(Regex.Match(text8, "--proxy-server=(.*?) ").Value, "");
					}
					if (text8.Contains("--user-data-dir="))
					{
						text8 = text8.Replace(Regex.Match(text8, "--user-data-dir=(.*?) ").Value, "");
					}
					text8 = Regex.Replace(text8, "\\s+", " ").Trim();
					class52_0.method_4(text8);
					if (string.IsNullOrEmpty(class52_0.string_2))
					{
						return (item, class52_0.method_0());
					}
					chromeDriverService = ChromeDriverService.CreateDefaultService(Path.GetDirectoryName(class52_0.string_2), Path.GetFileName(class52_0.string_2));
					chromeOptions = new ChromeOptions();
					chromeOptions.DebuggerAddress = class52_0.D603E4A5;
				}
				chromeDriverService.HideCommandPromptWindow = true;
				ChromeDriver_0 = new ChromeDriver(chromeDriverService, chromeOptions, TimeSpan.FromMinutes(3.0));
				Process_0 = Process.GetProcessById(chromeDriverService.ProcessId);
				ChromeDriver_0.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3.0);
				ChromeDriver_0.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60.0);
				ChromeDriver_0.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(60.0);
				A294ABA3 = ChromeDriver_0.SessionId.ToString();
				Int32_2 = chromeDriverService.Port;
				EA39AD33 = false;
				if (!Boolean_0)
				{
					method_45();
				}
				if (flag || flag2)
				{
					method_52(D780F8B7.X, D780F8B7.Y);
					method_50(B0B3B9A3.X, B0B3B9A3.Y);
					goto IL_100e;
				}
				if (GClass25.smethod_0("configGeneral").method_3("ckbUseExtensionProxy"))
				{
					for (int k = 0; k < 4; k++)
					{
						if (!CD003D3F("textarea[id=\"proxyConfig\"]", 5.0))
						{
							method_11();
							item = false;
							continue;
						}
						if (text3 != "")
						{
							BEA5E4BB("document.querySelector(\"#proxyConfig\").value = `" + text3 + "`;\r\ndocument.querySelector(\"#import\").click();");
						}
						break;
					}
					goto IL_100e;
				}
				if (String_8.Split(':').Length != 4)
				{
					goto IL_100e;
				}
				BEA5E4BB("document.title=\"proxyauth=" + String_8 + "\"");
				int num2 = GClass25.smethod_0("configGeneral").method_2("nudDelayCheckIP");
				method_40((num2 < 3) ? 3 : num2);
				method_10("https://ifconfig.co/ip");
				if (!(C12B8625() == "<html><head></head><body></body></html>"))
				{
					goto IL_100e;
				}
				B7841719(60);
				num--;
				if (num > 0)
				{
					continue;
				}
				return (item, "Proxy yêu cầu User/Pass!");
				IL_100e:
				item = true;
				break;
			}
			catch (Exception ex3)
			{
				if (ex3.ToString().Contains("This version of ChromeDriver only supports Chrome version"))
				{
					return (item, "Update chromedriver");
				}
				if (!ex3.ToString().Contains("ChromeDriver is assuming that Chrome has crashed"))
				{
					goto IL_1069;
				}
				num--;
				if (num <= 0)
				{
					goto IL_1069;
				}
				GClass8.smethod_87(String_2);
				goto end_IL_1015;
				IL_1069:
				if (ex3.ToString().Contains("session timed out after"))
				{
					GClass8.smethod_41("chrome");
					GClass8.smethod_41("chromedriver");
				}
				method_42(ex3, "chrome.Open()");
				break;
				end_IL_1015:;
			}
		}
		return (item, "");
	}

	private string DFAD1D17(int int_6, string CC0CC5B6, int AC1358A4, string string_12 = "", string C1BC4B11 = "")
	{
		string text = "http";
		if (int_6 == 1)
		{
			text = "socks5";
		}
		return $"{{\r\n            \"scheme\": \"{text}\",\r\n            \"host\": \"{CC0CC5B6}\",\r\n            \"port\": \"{AC1358A4}\",\r\n            \"username\": \"{string_12}\",\r\n            \"password\": \"{C1BC4B11}\"\r\n        }}";
	}

	public void C42D3215()
	{
		if (!method_1() && !BBA51B98())
		{
			C13DF1B3.ShowWindow(EC234D1D.MainWindowHandle, 6);
		}
	}

	public bool method_1()
	{
		if (EA39AD33)
		{
			return true;
		}
		if (EC234D1D != null && EC234D1D.HasExited)
		{
			EA39AD33 = true;
		}
		return EA39AD33;
	}

	public bool BBA51B98()
	{
		return Class57.smethod_5();
	}

	public string C12B8625()
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				return ChromeDriver_0.PageSource;
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
			return "";
		}
		return "";
	}

	private string method_2(string C428578C)
	{
		C428578C = C428578C.Replace("\\", "\\\\\\\\");
		C428578C = C428578C.Replace("'", "\\'");
		C428578C = C428578C.Replace("\n", "\\\\n");
		return C428578C;
	}

	private string B5134B19(bool bool_9)
	{
		return bool_9.ToString().ToLower();
	}

	private bool A207F22C(string string_12)
	{
		string_12 = method_2(string_12);
		string text = method_62("IsXpath('" + string_12 + "')");
		return text.ToLower() == "true";
	}

	public string method_3(string string_12)
	{
		string_12 = method_2(string_12);
		return method_62("ToJSDom('" + string_12 + "')");
	}

	public string method_4(string string_12, string string_13)
	{
		return BEA5E4BB("return " + method_3(string_12) + ".getAttribute('" + string_13 + "')");
	}

	public string method_5(string string_12)
	{
		return BEA5E4BB("return " + method_3(string_12) + ".value");
	}

	public string method_6(string DCB00704)
	{
		return BEA5E4BB("return " + method_3(DCB00704) + ".innerText");
	}

	public string A10C283B(string C7889911)
	{
		return BEA5E4BB("return " + method_3(C7889911) + ".innerHTML");
	}

	public string B7A4071C(string string_12)
	{
		return BEA5E4BB("return " + method_3(string_12) + ".outerHTML");
	}

	public void method_7(int D6142504)
	{
		BEA5E4BB("window.scrollBy({ top: " + D6142504 + ",behavior: 'smooth'});");
	}

	public string AE2E53B3()
	{
		return BEA5E4BB("return navigator.userAgent");
	}

	public bool method_8(string EBA0A4AA)
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				IWebElement webElement = FC32B61C(EBA0A4AA);
				webElement.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
				return true;
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
			return false;
		}
		return false;
	}

	public string method_9()
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				return ChromeDriver_0.Url;
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
			return "";
		}
		return "";
	}

	public void method_10(string string_12)
	{
		bool flag = false;
		for (int i = 0; i < 2 && !method_1() && !BBA51B98(); i++)
		{
			try
			{
				if (i == 0)
				{
					ChromeDriver_0.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5.0);
				}
				else
				{
					ChromeDriver_0.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60.0);
				}
				ChromeDriver_0.Navigate().GoToUrl(string_12);
				flag = true;
			}
			catch (Exception exception_)
			{
				method_42(exception_);
				continue;
			}
			break;
		}
		ChromeDriver_0.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60.0);
		if (flag && !method_1())
		{
			method_76();
			DFA46D3A();
		}
	}

	public void method_11()
	{
		try
		{
			ChromeDriver_0.Navigate().Refresh();
		}
		catch (Exception exception_)
		{
			method_42(exception_);
		}
	}

	public void method_12(int int_6 = 1)
	{
		try
		{
			for (int i = 0; i < int_6; i++)
			{
				if (method_1())
				{
					break;
				}
				if (BBA51B98())
				{
					break;
				}
				ChromeDriver_0.Navigate().Back();
				method_40(1.0);
			}
		}
		catch (Exception exception_)
		{
			method_42(exception_, "chrome.GotoBackPage()");
		}
	}

	public string BEA5E4BB(string string_12)
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				string text = ChromeDriver_0.ExecuteScript(string_12).ToString();
				return text ?? "";
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
			return "";
		}
		return "";
	}

	public string method_13(double double_0, List<string> list_0)
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				int num = 0;
				string text = "";
				text = ((!A207F22C(list_0[0])) ? ("var arr='" + string.Join("|", list_0) + "'.split('|');var output=0;for(i=0;i<arr.length;i++){ if (document.querySelectorAll(arr[i]).length > 0) { output = i + 1; break;}; }return (output + ''); ") : ("var arr='" + string.Join("|", list_0) + "'.split('|');var output=0;for(i=0;i<arr.length;i++){ if (document.evaluate(arr[i], document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue != null) { output = i + 1; break;}; } return (output + '');"));
				int tickCount = Environment.TickCount;
				while (true)
				{
					num = Convert.ToInt32(BEA5E4BB(text));
					if (num == 0)
					{
						if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
						{
							Thread.Sleep(1000);
							continue;
						}
						break;
					}
					return list_0[num - 1];
				}
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
			return "";
		}
		return "";
	}

	public bool method_14(int B50B9A8E, string[] string_12)
	{
		if (!method_1() && !BBA51B98())
		{
			string text = method_13(B50B9A8E, string_12.ToList());
			if (text == "")
			{
				return false;
			}
			bool result;
			if (!(result = method_16(text)))
			{
				result = method_19(text);
			}
			return result;
		}
		return false;
	}

	public bool BB963890(int int_6 = 0, params string[] E7866381)
	{
		if (!method_1() && !BBA51B98())
		{
			string text = method_13(int_6, E7866381.ToList());
			if (text == "")
			{
				return false;
			}
			return method_19(text);
		}
		return false;
	}

	public bool method_15(string string_12)
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				IWebElement onElement = ChromeDriver_0.FindElement(By.CssSelector(string_12));
				new Actions(ChromeDriver_0).Click(onElement).Perform();
				return true;
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
			return false;
		}
		return false;
	}

	public bool BE358C3C(string string_12)
	{
		if (!method_1() && !BBA51B98())
		{
			if (!method_16(string_12))
			{
				return method_19(string_12);
			}
			return true;
		}
		return false;
	}

	public IWebElement FC32B61C(string string_12)
	{
		if (A207F22C(string_12))
		{
			return ChromeDriver_0.FindElement(By.XPath(string_12));
		}
		string cssSelectorToFind = "";
		string text = "";
		int index = 0;
		int index2 = 0;
		string[] array = string_12.Split('|');
		switch (array.Length)
		{
		case 1:
			cssSelectorToFind = array[0].Trim();
			break;
		case 2:
			cssSelectorToFind = array[0].Trim();
			index = Convert.ToInt32(array[1].Trim());
			break;
		case 3:
			cssSelectorToFind = array[0].Trim();
			index = Convert.ToInt32(array[1].Trim());
			text = array[2].Trim();
			break;
		case 4:
			cssSelectorToFind = array[0].Trim();
			index = Convert.ToInt32(array[1].Trim());
			text = array[2].Trim();
			index2 = Convert.ToInt32(array[3].Trim());
			break;
		}
		if (text == "")
		{
			return ChromeDriver_0.FindElements(By.CssSelector(cssSelectorToFind))[index];
		}
		return ChromeDriver_0.FindElements(By.CssSelector(cssSelectorToFind))[index].FindElements(By.CssSelector(text))[index2];
	}

	public bool method_16(string CA1F5B31)
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				IWebElement webElement = FC32B61C(CA1F5B31);
				webElement.Click();
				return true;
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
			return false;
		}
		return false;
	}

	public bool method_17(string string_12)
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				method_18(string_12);
				return method_16(string_12);
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
			return false;
		}
		return false;
	}

	public bool method_18(string string_12, int int_6 = 1)
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				if (!A403470E(string_12))
				{
					return false;
				}
				method_40(int_6);
				return true;
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
			return false;
		}
		return false;
	}

	public bool method_19(string BB300B84)
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				ChromeDriver_0.ExecuteScript(method_3(BB300B84) + ".click()");
				return true;
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
			return false;
		}
		return false;
	}

	public bool D1260A22(string string_12)
	{
		if (!method_1() && !BBA51B98())
		{
			BEA5E4BB(method_3(string_12) + ".play()");
			return true;
		}
		return false;
	}

	public bool method_20(string string_12, string string_13)
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				string_13 = GClass8.smethod_29(string_13);
				IWebElement webElement = FC32B61C(string_12);
				if (GClass8.F410A322(string_13))
				{
					method_16(string_12);
					string_13 = string_13.Replace("\r\n", "*rr*nn").Replace("\n", "*rr*nn");
					string_13 = string_13.Replace("*rr*nn", "\\r\\n").Replace("\"", "\\\"");
					BEA5E4BB(method_3(string_12) + ".value=\"" + string_13 + "\"");
					webElement.SendKeys(" ");
				}
				else
				{
					webElement.SendKeys(string_13);
					if (string_13.Contains(" "))
					{
						webElement.SendKeys(" ");
					}
				}
				return true;
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
			return false;
		}
		return false;
	}

	public bool method_21(string BE183429, string string_12)
	{
		if (!method_1() && !BBA51B98())
		{
			BEA5E4BB(method_3(BE183429) + ".value = '" + string_12.Replace("'", "\\'") + "'");
			return true;
		}
		return false;
	}

	public bool method_22(string string_12, string string_13, bool bool_9 = false)
	{
		if (!method_1() && !BBA51B98())
		{
			string_12 = method_2(string_12);
			string_13 = method_2(string_13);
			string text = method_62("SendKeys2('" + string_12 + "','" + string_13 + "', " + B5134B19(bool_9) + ")");
			return text.ToLower() == "true";
		}
		return false;
	}

	public bool method_23(string string_12, string F1A66193)
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				IWebElement webElement = FC32B61C(string_12);
				webElement.SendKeys(F1A66193);
				return true;
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
			return false;
		}
		return false;
	}

	public bool method_24(string EF979A37)
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				IWebElement webElement = FC32B61C(EF979A37);
				webElement.SendKeys(OpenQA.Selenium.Keys.Enter);
				return true;
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
			return false;
		}
		return false;
	}

	public string method_25(string D703F92B, string F6370638 = "")
	{
		if (!method_1() && !BBA51B98())
		{
			if (F6370638 == "")
			{
				F6370638 = method_9();
			}
			string newValue = D789C71C(F6370638);
			string oldValue = D789C71C(D703F92B);
			return D703F92B.Replace(oldValue, newValue);
		}
		return "";
	}

	public string D789C71C(string string_12 = "")
	{
		if (!method_1() && !BBA51B98())
		{
			if (string_12 == "")
			{
				string_12 = method_9();
			}
			return Regex.Match(string_12, "https://(.*?)facebook.com").Value;
		}
		return "";
	}

	public string method_26(string D5A7B527, string string_12 = "https://mobile.facebook.com")
	{
		return method_62("GetLinkFromId('" + D5A7B527 + "','" + string_12 + "')");
	}

	public bool D997803F(string string_12)
	{
		if (!method_1() && !BBA51B98())
		{
			string_12 = method_2(string_12);
			string text = method_62("IsElementVisible('" + string_12 + "')");
			return text == "true";
		}
		return false;
	}

	public bool AF93AB8B(string string_12, string string_13, double E02C662C, bool bool_9 = true, double double_0 = 0.1)
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				if (bool_9)
				{
					method_16(string_12);
					method_40(double_0);
					method_29(string_12);
				}
				switch (GClass25.smethod_0("configGeneral").method_2("tocDoGoVanBan"))
				{
				case 2:
					ChromeDriver_0.FindElement(By.CssSelector(string_12)).SendKeys(string_13);
					break;
				case 0:
				case 1:
				{
					IWebElement webElement = FC32B61C(string_12);
					for (int i = 0; i < string_13.Length; i++)
					{
						webElement.SendKeys(string_13[i].ToString());
						if (E02C662C > 0.0)
						{
							int num = Convert.ToInt32(E02C662C * 1000.0);
							if (num < 100)
							{
								num = 100;
							}
							Thread.Sleep(Class57.random_0.Next(num, num + 50));
						}
					}
					break;
				}
				}
			}
			catch (Exception exception_)
			{
				method_42(exception_);
				return false;
			}
			return true;
		}
		return false;
	}

	public bool method_27(string string_12)
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				IWebElement webElement = FC32B61C(string_12);
				webElement.SendKeys(OpenQA.Selenium.Keys.Backspace);
				return true;
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
			return false;
		}
		return false;
	}

	public bool method_28(string string_12)
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				IWebElement webElement = FC32B61C(string_12);
				webElement.SendKeys(OpenQA.Selenium.Keys.Control + "a");
				return true;
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
			return false;
		}
		return false;
	}

	public bool method_29(string B0286B2F)
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				IWebElement webElement = FC32B61C(B0286B2F);
				webElement.Clear();
				return true;
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
			return false;
		}
		return false;
	}

	public bool AC9778A4(string string_12)
	{
		if (method_1())
		{
			return false;
		}
		method_28(string_12);
		method_27(string_12);
		return true;
	}

	public int E22B0917(string CF2AEC98)
	{
		if (!method_1() && !BBA51B98())
		{
			int result = 0;
			try
			{
				result = ((!A207F22C(CF2AEC98)) ? Convert.ToInt32(ChromeDriver_0.ExecuteScript("return document.querySelectorAll('" + CF2AEC98.Replace("'", "\\'") + "').length+''").ToString()) : Convert.ToInt32(ChromeDriver_0.ExecuteScript("return document.evaluate('count(" + CF2AEC98.Replace("'", "\\'") + ")', document, null, XPathResult.NUMBER_TYPE, null).numberValue").ToString()));
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
			return result;
		}
		return 0;
	}

	public bool method_30(string C339D805)
	{
		if (!method_1() && !BBA51B98())
		{
			BEA5E4BB(method_3(C339D805) + ".remove();");
			return true;
		}
		return false;
	}

	public bool CD003D3F(string D627A998, double double_0 = 0.0)
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				string text = method_3(D627A998);
				int tickCount = Environment.TickCount;
				while (true)
				{
					if (!(BEA5E4BB("return " + text + "!=null").ToLower() == "true"))
					{
						if (!method_1() && !BBA51B98())
						{
							if (!((double)(Environment.TickCount - tickCount) >= double_0 * 1000.0))
							{
								method_40(1.0);
								continue;
							}
							break;
						}
						return false;
					}
					return true;
				}
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
			return false;
		}
		return false;
	}

	public bool C439D0A9(string AB901823, double E8B86701 = 0.0)
	{
		if (!method_1() && !BBA51B98())
		{
			AB901823 = AB901823.ToLower();
			return CD003D3F("//*[translate(text(), 'ABCDEFGHIJKLMNOPQRSTUVWXYZ', 'abcdefghijklmnopqrstuvwxyz')=\"" + AB901823 + "\"]", E8B86701);
		}
		return false;
	}

	public bool A487A5AD(int BD8C00A0, int AFB4F09E)
	{
		if (!method_1() && !BBA51B98())
		{
			BEA5E4BB($"window.scrollTo({BD8C00A0}, {AFB4F09E})");
			return true;
		}
		return false;
	}

	public bool method_31(string string_12, int int_6)
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				string text = method_3(string_12);
				int tickCount = Environment.TickCount;
				while (true)
				{
					if (!(BEA5E4BB("return " + text + "!=null").ToLower() == "false"))
					{
						if (!method_1() && !BBA51B98())
						{
							if (Environment.TickCount - tickCount < int_6 * 1000)
							{
								method_40(1.0);
								continue;
							}
							break;
						}
						return false;
					}
					return true;
				}
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
			return false;
		}
		return false;
	}

	public bool A403470E(string string_12)
	{
		if (!method_1() && !BBA51B98())
		{
			BEA5E4BB(method_3(string_12) + ".scrollIntoView({ behavior: 'smooth', block: 'center'});");
			return true;
		}
		return false;
	}

	public bool method_32(string string_12)
	{
		if (!method_1() && !BBA51B98())
		{
			if (!B8341519(string_12))
			{
				return A403470E(string_12);
			}
			return true;
		}
		return false;
	}

	public bool B8341519(string EA1C81BA, int int_6 = 0)
	{
		if (!method_1() && !BBA51B98())
		{
			EA1C81BA = method_2(EA1C81BA);
			string text = method_62($"IsElementOnScreen('{EA1C81BA}',{int_6})");
			return text.ToLower() == "true";
		}
		return false;
	}

	public bool B7841719(int int_6 = 5)
	{
		try
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				try
				{
					ChromeDriver_0.Quit();
				}
				catch (Exception)
				{
				}
			});
			thread.IsBackground = true;
			thread.Start();
			if (!thread.Join(int_6 * 1000))
			{
				thread.Abort();
			}
		}
		catch
		{
		}
		try
		{
			if (EC234D1D != null && !EC234D1D.HasExited)
			{
				EC234D1D.Kill();
			}
			if (Process_0 != null && !Process_0.HasExited)
			{
				Process_0.Kill();
			}
		}
		catch
		{
		}
		EC234D1D = null;
		Process_0 = null;
		EA39AD33 = true;
		if (!string.IsNullOrEmpty(String_0.Trim()) && GClass25.smethod_0("configInteractGeneral").method_3("ckbXoaProfile"))
		{
			for (int i = 0; i < 10; i++)
			{
				if (GClass8.smethod_67(String_0))
				{
					break;
				}
				GClass8.smethod_53(1.0);
			}
		}
		return true;
	}

	public bool D886D510()
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				new Actions(ChromeDriver_0).KeyDown(OpenQA.Selenium.Keys.Shift).SendKeys(OpenQA.Selenium.Keys.ArrowUp).SendKeys(OpenQA.Selenium.Keys.ArrowUp)
					.SendKeys(OpenQA.Selenium.Keys.ArrowUp)
					.SendKeys(OpenQA.Selenium.Keys.Delete)
					.KeyUp(OpenQA.Selenium.Keys.Shift)
					.Build()
					.Perform();
			}
			catch (Exception exception_)
			{
				method_42(exception_);
				return false;
			}
			return true;
		}
		return false;
	}

	public int method_33(string string_12, string string_13)
	{
		bool flag = false;
		if (!method_1() && !BBA51B98())
		{
			try
			{
				Screenshot screenshot = ((ITakesScreenshot)ChromeDriver_0).GetScreenshot();
				screenshot.SaveAsFile(string_12 + (string_12.EndsWith("\\") ? "" : "\\") + string_13 + ".png");
				flag = true;
			}
			catch (Exception exception_)
			{
				method_42(exception_, "chrome.ScreenCapture(" + string_12 + "," + string_13 + ")");
			}
			return flag ? 1 : 0;
		}
		return -2;
	}

	public bool method_34(string string_12, string string_13 = ".facebook.com")
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				string[] array = string_12.Split(';');
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text.Trim() != "")
					{
						string[] array3 = text.Split('=');
						if (array3.Count() > 1 && array3[0].Trim() != "")
						{
							OpenQA.Selenium.Cookie cookie = null;
							cookie = new OpenQA.Selenium.Cookie(array3[0].Trim(), text.Substring(text.IndexOf('=') + 1).Trim(), string_13, "/", DateTime.Now.AddDays(10.0));
							ChromeDriver_0.Manage().Cookies.AddCookie(cookie);
						}
					}
				}
				method_35("i_user");
				return true;
			}
			catch (Exception exception_)
			{
				method_42(exception_, "chrome.AddCookieIntoChrome(" + string_12 + "," + string_13 + ")");
			}
			return false;
		}
		return false;
	}

	public bool method_35(string string_12)
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				ChromeDriver_0.Manage().Cookies.DeleteCookieNamed(string_12);
				return true;
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
			return false;
		}
		return false;
	}

	public string method_36(string string_12 = "facebook")
	{
		string text = "";
		try
		{
			OpenQA.Selenium.Cookie[] array = ChromeDriver_0.Manage().Cookies.AllCookies.ToArray();
			OpenQA.Selenium.Cookie[] array2 = array;
			foreach (OpenQA.Selenium.Cookie cookie in array2)
			{
				if (cookie.Domain.Contains(string_12))
				{
					text = text + cookie.Name + "=" + cookie.Value + ";";
				}
			}
		}
		catch (Exception exception_)
		{
			method_42(exception_, "chrome.GetCookieFromChrome(" + string_12 + ")");
		}
		return text;
	}

	public string method_37()
	{
		return Regex.Match(method_36(), "c_user=(\\d+)").Groups[1].Value;
	}

	public string B8B3CA97()
	{
		return E9B89BB8("Getfb_dtsg");
	}

	public bool method_38(string string_12 = "", bool bool_9 = true)
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				BEA5E4BB("window.open('" + string_12 + "', '_blank').focus();");
				if (bool_9)
				{
					ChromeDriver_0.SwitchTo().Window(ChromeDriver_0.WindowHandles.Last());
				}
			}
			catch (Exception exception_)
			{
				method_42(exception_, $"chrome.OpenNewTab({string_12},{bool_9})");
				return false;
			}
			return true;
		}
		return false;
	}

	public bool E308501D()
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				ChromeDriver_0.Close();
			}
			catch (Exception exception_)
			{
				method_42(exception_, "chrome.CloseCurrentTab()");
				return false;
			}
			return true;
		}
		return false;
	}

	public bool method_39()
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				ChromeDriver_0.SwitchTo().Window(ChromeDriver_0.WindowHandles.First());
			}
			catch (Exception exception_)
			{
				method_42(exception_, "chrome.SwitchToFirstTab()");
				return false;
			}
			return true;
		}
		return false;
	}

	public bool A512912F()
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				ChromeDriver_0.SwitchTo().Window(ChromeDriver_0.WindowHandles.Last());
			}
			catch (Exception exception_)
			{
				method_42(exception_, "chrome.SwitchToLastTab()");
				return false;
			}
			return true;
		}
		return false;
	}

	public void method_40(double CC861DBA)
	{
		CC861DBA = Math.Floor(CC861DBA);
		for (int i = 0; (double)i < CC861DBA; i++)
		{
			if (method_1())
			{
				break;
			}
			if (BBA51B98())
			{
				break;
			}
			GClass8.smethod_53(1.0);
		}
	}

	public void method_41(int int_6, int int_7)
	{
		int num = method_49(int_6, int_7);
		method_40(num);
	}

	public void method_42(Exception exception_0, string B19394AA = "")
	{
		try
		{
			if (exception_0 != null && (exception_0.ToString().Contains("timed out") || exception_0.ToString().Contains("disconnected") || exception_0.ToString().Contains("Unable to connect to the remote server") || exception_0.ToString().Contains("target window already closed")))
			{
				EA39AD33 = true;
			}
			if (!(B19394AA == "chrome.Open()"))
			{
				return;
			}
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
			if (ChromeDriver_0 != null)
			{
				string contents = BEA5E4BB("var markup = document.documentElement.innerHTML;return markup;").ToString();
				method_33("log\\images\\", text);
				File.WriteAllText("log\\html\\" + text + ".html", contents);
			}
			using StreamWriter streamWriter = new StreamWriter("log\\log.txt", append: true);
			streamWriter.WriteLine("-----------------------------------------------------------------------------");
			streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
			streamWriter.WriteLine("File: " + text);
			if (B19394AA != "")
			{
				streamWriter.WriteLine("Error: " + B19394AA);
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

	public bool method_43(string string_12, string string_13)
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				new SelectElement(ChromeDriver_0.FindElement(By.CssSelector(string_12))).SelectByValue(string_13);
			}
			catch (Exception exception_)
			{
				method_42(exception_);
				return false;
			}
			return true;
		}
		return false;
	}

	public void method_44()
	{
		int num = ChromeDriver_0.WindowHandles.Count();
		if (num > 1)
		{
			for (int i = 0; i < num - 1; i++)
			{
				method_39();
				E308501D();
			}
			method_39();
		}
	}

	public void F3275600()
	{
		int num = ChromeDriver_0.WindowHandles.Count();
		if (num > 1)
		{
			for (int i = 0; i < num - 1; i++)
			{
				A512912F();
				E308501D();
			}
			method_39();
		}
	}

	private bool method_45()
	{
		try
		{
			if (EC234D1D != null)
			{
				return true;
			}
			method_44();
			string string_0 = "";
			for (int i = 0; i < 10; i++)
			{
				if (BBA51B98())
				{
					break;
				}
				try
				{
					try
					{
						string_0 = ChromeDriver_0.CurrentWindowHandle;
					}
					catch
					{
						string_0 = GClass8.smethod_50(15);
					}
					if (string_0 != "")
					{
						for (int j = 0; j < 3; j++)
						{
							BEA5E4BB("document.title='" + string_0 + "'");
							method_40(1.0);
							EC234D1D = (from D02C5803 in Process.GetProcessesByName("chrome")
								where D02C5803.MainWindowTitle.Contains(string_0)
								select D02C5803).FirstOrDefault();
							if (EC234D1D != null)
							{
								return true;
							}
						}
						F3275600();
					}
				}
				catch (Exception exception_)
				{
					method_42(exception_);
				}
				method_40(1.0);
			}
		}
		catch (Exception exception_2)
		{
			method_42(exception_2);
		}
		return false;
	}

	public bool method_46()
	{
		string text = method_9();
		if (text.Contains("checkpoint/disabled"))
		{
			return false;
		}
		string text2 = D789C71C(text);
		text = BEA5E4BB("async function Request(){try{let a=await fetch(\"" + text2 + "/me\"),b=\"\";return a.ok&&(b=a.url),b}catch{}}var c=await Request();return c").ToString();
		if (!text.Contains("checkpoint/disabled") && !text.Contains("828281030927956") && !text.Contains("1501092823525282"))
		{
			bool flag = false;
			List<string> list = BEA5E4BB("arrAction = []; document.querySelectorAll('form[method]').forEach(e => arrAction.push(e.getAttribute('action'))); return arrAction.join('|');").ToString().Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
			for (int i = 0; i < list.Count; i++)
			{
				if (!list[i].StartsWith("/a/home.php?") && !list[i].StartsWith("/search/?") && !list[i].StartsWith("/composer/mbasic/?"))
				{
					if (list[i].Equals("/logout.php?button_location=settings&button_name=logout") && Class14.EABAA59C(String_2).StartsWith("1"))
					{
						flag = true;
						break;
					}
					continue;
				}
				flag = true;
				break;
			}
			if (!flag)
			{
				text2 = D789C71C();
				string text3 = D129B30F(text2 + "/home.php").ToString();
				flag = text3.Contains("href=\"/menu/bookmarks/") && text3.Contains("id=\"mbasic_logout_button\"");
			}
			return flag;
		}
		return false;
	}

	public string D129B30F(string string_12)
	{
		return method_62("RequestGet('" + string_12 + "')");
	}

	public string method_47(string ABA1A28C, string string_12)
	{
		return method_62("RequestPost('" + ABA1A28C + "','" + string_12 + "')");
	}

	internal int method_48(string string_12 = "en_US")
	{
		string text = "";
		for (int i = 0; i < 3; i++)
		{
			text = method_62("SetFbLanguage('" + string_12 + "')");
			if (!(text == "0"))
			{
				break;
			}
		}
		return Convert.ToInt32(text);
	}

	public int method_49(int A5158B84, int B3375FBD)
	{
		return Class57.random_0.Next(A5158B84, B3375FBD + 1);
	}

	public void method_50(int int_6 = 0, int F5BCF8A8 = 0)
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				BE02F7AB = ChromeDriver_0.Manage().Window.Position.X;
				int_4 = ChromeDriver_0.Manage().Window.Position.Y;
				ChromeDriver_0.Manage().Window.Position = new Point(int_6, F5BCF8A8);
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
		}
	}

	public void method_51()
	{
		if (!method_1() && !BBA51B98())
		{
			try
			{
				ChromeDriver_0.Manage().Window.Position = new Point(BE02F7AB, int_4);
			}
			catch (Exception exception_)
			{
				method_42(exception_);
			}
		}
	}

	public void method_52(int BA1A9803 = 500, int int_6 = 700)
	{
		if (BA1A9803 < D780F8B7.X && int_6 < D780F8B7.Y)
		{
			return;
		}
		if (BA1A9803 >= 500 && int_6 >= 700)
		{
			bool_8 = true;
		}
		if (method_1() || BBA51B98())
		{
			return;
		}
		try
		{
			int_5 = ChromeDriver_0.Manage().Window.Size.Width;
			AC1BE00A = ChromeDriver_0.Manage().Window.Size.Height;
			ChromeDriver_0.Manage().Window.Size = new Size(BA1A9803, int_6);
			if (D8B82A92)
			{
				method_50(-10, -30);
			}
		}
		catch (Exception exception_)
		{
			method_42(exception_);
		}
	}

	public void method_53()
	{
		if ((int_5 < D780F8B7.X && AC1BE00A < D780F8B7.Y) || method_1() || BBA51B98())
		{
			return;
		}
		try
		{
			ChromeDriver_0.Manage().Window.Size = new Size(int_5, AC1BE00A);
			if (D8B82A92)
			{
				method_50(-10, -30);
			}
		}
		catch (Exception exception_)
		{
			method_42(exception_);
		}
	}

	internal string F28A771E(string string_12)
	{
		string text = "";
		List<string> list = new List<string> { "Like", "Love", "Care", "Haha", "Wow", "Sad", "Angry" };
		try
		{
			int index = Convert.ToInt32(string_12.Split('|').ToList().smethod_6());
			text = list[index];
		}
		catch (Exception)
		{
			text = list.First();
		}
		return $"//*[@aria-label=\"Reactions\" and not(ancestor::*/@hidden)]//*[contains(@aria-label,\"{text}\")]";
	}

	private List<string> method_54(List<string> CB3CBB20)
	{
		List<string> list_0 = new List<string>();
		try
		{
			int int_ = 0;
			int num = ((CB3CBB20.Count < 100) ? CB3CBB20.Count : 100);
			string string_0 = method_36();
			string D9210C95 = AE2E53B3();
			string string_1 = String_8;
			int EAA44998 = Int32_1;
			int num2 = 0;
			while (num2 < CB3CBB20.Count)
			{
				if (int_ < num)
				{
					Interlocked.Increment(ref int_);
					int int_0 = num2++;
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							bool flag = false;
							string text = CB3CBB20[int_0].Split('|')[0];
							F3958F9B f3958F9B = new F3958F9B(string_0, D9210C95, string_1, EAA44998);
							string text2 = f3958F9B.method_0("https://mbasic.facebook.com/groups/" + text + "/madminpanel");
							if (text2.Contains("/help/contact/571927962827151") || text2.Contains("madminpanel/pending/"))
							{
								flag = true;
							}
							lock (list_0)
							{
								list_0.Add(CB3CBB20[int_0] + "|" + flag);
							}
						}
						catch
						{
						}
						Interlocked.Decrement(ref int_);
					});
					thread.IsBackground = true;
					thread.Start();
				}
				else
				{
					Application.DoEvents();
					Thread.Sleep(200);
				}
			}
			while (int_ > 0)
			{
				Application.DoEvents();
				Thread.Sleep(1000);
			}
		}
		catch
		{
		}
		return list_0;
	}

	public List<string> method_55(bool bool_9)
	{
		List<string> list = new List<string>();
		try
		{
			method_36();
			string text = method_37();
			if (!bool_9)
			{
				string input = D129B30F(D789C71C() + "/help/");
				string value = Regex.Match(input, GClass8.A2307E3B("ImR0c2dfYWciOnsidG9rZW4iOiIoLio/KSI=")).Groups[1].Value;
				if (value == "")
				{
					value = Regex.Match(input, "\"async_get_token\":\"(.*?)\"").Groups[1].Value;
				}
				if (value == "")
				{
					input = D129B30F("https://www.facebook.com/help");
					value = Regex.Match(input, GClass8.A2307E3B("ImR0c2dfYWciOnsidG9rZW4iOiIoLio/KSI=")).Groups[1].Value;
					if (value == "")
					{
						value = Regex.Match(input, "\"async_get_token\":\"(.*?)\"").Groups[1].Value;
					}
				}
				string string_ = "https://www.facebook.com/ajax/typeahead/first_degree.php?fb_dtsg_ag=" + value + "&filter%5B0%5D=group&viewer=" + text + "&__user=" + text + "&__a=1&__dyn=&__comet_req=0&jazoest=26581";
				input = D129B30F(string_).Replace("for (;;);", "");
				JObject jObject = JObject.Parse(input);
				if (jObject["redirect"] != null)
				{
					string_ = jObject["redirect"]!.ToString();
					input = D129B30F(string_).Replace("for (;;);", "");
					jObject = JObject.Parse(input);
				}
				foreach (JToken item in (IEnumerable<JToken>)(jObject["payload"]!["entries"]!))
				{
					try
					{
						list.Add(string.Format("{0}|{1}|{2}", item["uid"], item["text"], item["size"]));
					}
					catch
					{
					}
				}
				if (bool_9)
				{
					list = method_54(list);
				}
			}
			else
			{
				string text2 = method_81();
				string json = D129B30F("https://graph.facebook.com/graphql?q=nodes(" + text + "){groups{nodes{id,name,viewer_post_status,visibility,group_member_profiles{count}}}}&method=post&access_token=" + text2);
				JObject jObject2 = JObject.Parse(json);
				foreach (JToken item2 in (IEnumerable<JToken>)(jObject2[text]!["groups"]!["nodes"]!))
				{
					try
					{
						list.Add(string.Format("{0}|{1}|{2}|{3}", item2["id"], item2["name"], item2["group_member_profiles"]!["count"], (item2["viewer_post_status"]!.ToString() == "CAN_POST_WITHOUT_APPROVAL") ? "False" : "True"));
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public List<string> method_56(int int_6 = 0)
	{
		List<string> list = new List<string>();
		try
		{
			string propertyName = method_37();
			string text = B8B3CA97();
			if (!method_9().Contains("https://www.facebook.com/api/graphql"))
			{
				method_10("https://www.facebook.com/api/graphql");
			}
			string json = BEA5E4BB("async function RequestPost() { var output = ''; try { var response = await fetch('https://www.facebook.com/api/graphql', { method: 'POST', body: 'q=me(){friends}&fb_dtsg=" + text + "', headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestPost(); return c;");
			JObject jObject = JObject.Parse(json);
			int num = jObject[propertyName]!["friends"]!["nodes"].Count();
			for (int i = 0; i < num; i++)
			{
				if (int_6 != 0)
				{
					try
					{
						string text2 = jObject[propertyName]!["friends"]!["nodes"]![i]!["name"]!.ToString();
						if ((int_6 == 1 && GClass8.smethod_68(text2)) || (int_6 == 2 && !GClass8.smethod_68(text2)))
						{
							list.Add(jObject[propertyName]!["friends"]!["nodes"]![i]!["id"]!.ToString());
						}
					}
					catch
					{
					}
				}
				else
				{
					list.Add(jObject[propertyName]!["friends"]!["nodes"]![i]!["id"]!.ToString());
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public List<string> F92F0981()
	{
		List<string> list = new List<string>();
		try
		{
			string text = B8B3CA97();
			string json = method_47("https://mobile.facebook.com/buddylist.php", "data_fetch=true&send_full_data=true&fb_dtsg=" + text + "&jazoest=&lsd=r&__dyn=&__csr=&__req=a&__a=&__user=" + E599E997).Replace("for (;;);", "");
			JObject jObject = JObject.Parse(json);
			foreach (JToken item in (IEnumerable<JToken>)(jObject["payload"]!["buddylist"]!))
			{
				list.Add(item["id"]!.ToString());
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	public List<string> DC94C78C()
	{
		List<string> list = new List<string>();
		try
		{
			string text = "/messages/?folder=other";
			do
			{
				string input = D129B30F("https://mobile.facebook.com" + text).Replace("&amp;", "&");
				text = Regex.Match(input, "href=\"(/messages/\\?pageNum=.*?)\"").Groups[1].Value;
				MatchCollection matchCollection = Regex.Matches(input, "/messages/read/\\?tid=cid\\.c\\.(.*?)%");
				foreach (Match item in matchCollection)
				{
					list.Add(item.Groups[1].Value);
				}
			}
			while (text != "");
		}
		catch (Exception)
		{
		}
		list.Remove(E599E997);
		return list;
	}

	public List<string> method_57()
	{
		List<string> list = new List<string>();
		try
		{
			string text = "/messages/?folder=pending";
			do
			{
				string input = D129B30F("https://mobile.facebook.com" + text).Replace("&amp;", "&");
				text = Regex.Match(input, "href=\"(/messages/\\?pageNum=.*?)\"").Groups[1].Value;
				MatchCollection matchCollection = Regex.Matches(input, "/messages/read/\\?tid=cid\\.c\\.(.*?)%");
				foreach (Match item in matchCollection)
				{
					list.Add(item.Groups[1].Value);
				}
			}
			while (text != "");
		}
		catch (Exception)
		{
		}
		list.Remove(E599E997);
		return list;
	}

	public bool DFA46D3A()
	{
		string text = method_9();
		if (!text.Contains("601051028565049"))
		{
			return false;
		}
		string text2 = method_13(0.0, new List<string> { "//div[@role=\"button\"][.//div/div and not(ancestor::*[@role=\"dialog\"])]", "//*[@action=\"/checkpoint/601051028565049/submit/\"]//*[@type=\"submit\"]" });
		if (text2 == "")
		{
			return false;
		}
		method_17(text2);
		method_40(2.0);
		return true;
	}

	public void method_58()
	{
		try
		{
			if (DFA46D3A() || method_76())
			{
				return;
			}
			for (int i = 0; i < 3; i++)
			{
				string text = method_13(0.0, new List<string>
				{
					"[role=\"dialog\"] [aria-label=\"[object Object]\"]", "[role=\"dialog\"] [aria-label=\"Not Now\"]", "[role=\"dialog\"] [aria-label=\"Use Page\"]", "[role=\"dialog\"] [aria-label=\"Close\"],[role=\"dialog\"] [aria-label=\"Đóng\"]", "[aria-label=\"Done\"]", "[aria-label=\"Xong\"]", "[data-visualcompletion=\"ignore\"] [role=\"dialog\"] [role=\"button\"]", "[style=\"transform: translateX(0%) translateZ(1px);\"]>div>div:nth-child(2)>div:nth-child(3)>div", "[style=\"transform: translate(16px, 0px);\"] [role=\"button\"]", "[style=\"padding-top: 40px;\"]>div>div>[role=\"button\"]",
					"[style=\"transform: translateX(0%) translateZ(1px);\"] [role=\"button\"]", "[role=\"dialog\"]>div>div>div:nth-child(3)>div", "[role=\"dialog\"] [style*=\"transform: translate\"]>div>div>div [role=\"button\"]", "[data-testid=\"cookie-policy-manage-dialog\"] > [role=\"dialog\"] [aria-label]:not([aria-disabled=\"true\"])"
				});
				string text2 = text;
				string text3 = text2;
				switch (C43AF739.smethod_0(text3))
				{
				default:
					return;
				case 716036627u:
					if (!(text3 == "[style=\"transform: translateX(0%) translateZ(1px);\"] [role=\"button\"]"))
					{
						return;
					}
					goto IL_0350;
				case 615184787u:
					if (!(text3 == "[role=\"dialog\"]>div>div>div:nth-child(3)>div"))
					{
						return;
					}
					goto IL_0350;
				case 458653063u:
					if (!(text3 == "[style=\"transform: translateX(0%) translateZ(1px);\"]>div>div:nth-child(2)>div:nth-child(3)>div"))
					{
						return;
					}
					goto IL_0350;
				case 1692541720u:
					if (!(text3 == "[aria-label=\"Xong\"]"))
					{
						return;
					}
					goto IL_0350;
				case 737127231u:
					if (!(text3 == "[style=\"transform: translate(16px, 0px);\"] [role=\"button\"]"))
					{
						return;
					}
					goto IL_0350;
				case 2528427641u:
					if (!(text3 == "[role=\"dialog\"] [aria-label=\"Close\"],[role=\"dialog\"] [aria-label=\"Đóng\"]"))
					{
						return;
					}
					goto IL_0350;
				case 1817943238u:
					if (text3 == "[data-testid=\"cookie-policy-manage-dialog\"] > [role=\"dialog\"] [aria-label]:not([aria-disabled=\"true\"])")
					{
						method_17(text + "|" + (E22B0917(text) - 1));
						break;
					}
					return;
				case 2721477684u:
					if (!(text3 == "[role=\"dialog\"] [style*=\"transform: translate\"]>div>div>div [role=\"button\"]"))
					{
						return;
					}
					goto IL_0350;
				case 2690410623u:
					if (!(text3 == "[data-visualcompletion=\"ignore\"] [role=\"dialog\"] [role=\"button\"]"))
					{
						return;
					}
					goto IL_0350;
				case 2615523657u:
					if (!(text3 == "[role=\"dialog\"] [aria-label=\"[object Object]\"]"))
					{
						return;
					}
					if (CD003D3F("[role=\"dialog\"] [aria-label=\"Close\"],[role=\"dialog\"] [aria-label=\"Đóng\"]"))
					{
						method_19("[role=\"dialog\"] [aria-label=\"Close\"],[role=\"dialog\"] [aria-label=\"Đóng\"]");
						break;
					}
					if (CD003D3F("(//*[@role=\"dialog\"]//*[@role=\"radio\"])[last()]"))
					{
						method_19("(//*[@role=\"dialog\"]//*[@role=\"radio\"])[last()]");
					}
					method_19("(//*[@role=\"dialog\"]//*[@aria-label=\"[object Object]\"])[last()]");
					break;
				case 3408643542u:
					if (!(text3 == "[style=\"padding-top: 40px;\"]>div>div>[role=\"button\"]"))
					{
						return;
					}
					goto IL_0350;
				case 3199891620u:
					if (!(text3 == "[role=\"dialog\"] [aria-label=\"Not Now\"]"))
					{
						return;
					}
					goto IL_0350;
				case 4207376459u:
					if (!(text3 == "[role=\"dialog\"] [aria-label=\"Use Page\"]"))
					{
						return;
					}
					goto IL_0350;
				case 3896031394u:
					{
						if (!(text3 == "[aria-label=\"Done\"]"))
						{
							return;
						}
						goto IL_0350;
					}
					IL_0350:
					if (D997803F(text))
					{
						string text4 = method_9();
						if (!text4.Contains("facebook.com/messages/") && !text4.Contains("&rdid=") && !text4.Contains("/posts/") && !text4.Contains("?story_fbid="))
						{
							A403470E(text);
							method_40(1.0);
							method_19(text);
							break;
						}
						return;
					}
					return;
				}
				method_40(1.0);
			}
		}
		catch
		{
		}
	}

	public int AFABF4B7(string string_12 = "")
	{
		if (string_12 == "")
		{
			string_12 = method_9();
		}
		return Class14.C0AF38BF(string_12);
	}

	internal void method_59()
	{
		if (DFA46D3A() || (CD003D3F("[href=\"/\"]") && !method_9().Contains("facebook.com/privacy/consent_framework/prompt/")))
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < 4; i++)
		{
			if (AFABF4B7() == 1)
			{
				for (int j = 0; j < 10; j++)
				{
					if (!method_9().Contains(".facebook.com/privacy/consent/"))
					{
						break;
					}
					method_121();
					method_40(2.0);
				}
				if (CD003D3F("[role=\"dialog\"] [aria-label=\"Close\"],[role=\"dialog\"] [aria-label][role=\"button\"]:has(svg)") && method_19("[role=\"dialog\"] [aria-label=\"Close\"],[role=\"dialog\"] [aria-label][role=\"button\"]:has(svg)"))
				{
					method_40(2.0);
				}
				if (method_9().Contains("facebook.com/checkpoint/block") && CD003D3F("[href*=\"facebook.com/communitystandards\"]") && method_16("#checkpointBottomBar button, #checkpointSubmitButton button"))
				{
					continue;
				}
				break;
			}
			if (CD003D3F("[data-cookiebanner=\"accept_button\"]"))
			{
				BEA5E4BB("document.querySelector('[data-cookiebanner=\"accept_button\"]').click()");
				continue;
			}
			if (CD003D3F("#nux-nav-button,[href^=\"/a/nux/wizard/nav.php\"]"))
			{
				method_16("#nux-nav-button,[href^=\"/a/nux/wizard/nav.php\"]");
				continue;
			}
			string text = method_9();
			if (text.Contains("facebook.com/si/actor_experience/actor_gateway"))
			{
				string text2 = method_13(10.0, new List<string> { "[data-nt=\"NT:IMAGE\"]", "button[data-sigil=\"touchable\"]" });
				if (text2 == "[data-nt=\"NT:IMAGE\"]")
				{
					num++;
					if (num <= 1)
					{
						method_19(text2);
						method_40(2.0);
						continue;
					}
					break;
				}
				if (text2 == "button[data-sigil=\"touchable\"]")
				{
					method_16(text2);
					method_40(2.0);
					break;
				}
			}
			if (text.Contains("facebook.com/legal_consent"))
			{
				method_19("button[type=\"submit\"]");
				method_40(1.0);
				method_19("button[type=\"submit\"]:last-child");
				method_40(1.0);
				method_19("button[type=\"submit\"]");
				method_40(1.0);
				method_19("#consent-page-container button[type=\"submit\"]:last-child");
				method_40(1.0);
				continue;
			}
			if (!text.Contains("facebook.com/privacy/consent_framework/prompt/"))
			{
				break;
			}
			if (CD003D3F("[href=\"/\"]"))
			{
				method_10("https://www.facebook.com/");
				continue;
			}
			if (CD003D3F("[type=\"checkbox\"][name=\"personal_data_toggle\"]"))
			{
				BEA5E4BB("document.querySelector('[type=\"checkbox\"][name=\"personal_data_toggle\"]').checked=true;");
			}
			if (CD003D3F("[type=\"checkbox\"][name=\"data_shared_3pd_toggle\"]"))
			{
				BEA5E4BB("document.querySelector('[type=\"checkbox\"][name=\"data_shared_3pd_toggle\"]').checked=true;");
			}
			if (CD003D3F("[type=\"checkbox\"][name=\"cross_border_data_transfer_toggle\"]"))
			{
				BEA5E4BB("document.querySelector('[type=\"checkbox\"][name=\"cross_border_data_transfer_toggle\"]').checked=true;");
			}
			if (CD003D3F("[type=\"checkbox\"][name=\"location_info_toggle\"]"))
			{
				BEA5E4BB("document.querySelector('[type=\"checkbox\"][name=\"location_info_toggle\"]').checked=true;");
			}
			method_19("button[name=\"primary_consent_button\"]");
			method_40(2.0);
		}
	}

	public void method_60(string AE39B713 = "")
	{
		if (AE39B713 == "")
		{
			AE39B713 = method_9();
		}
		string_11 = AE39B713;
	}

	public bool BB1DB70A(int E4301198, string D78DF003 = "")
	{
		int tickCount = Environment.TickCount;
		while (!method_1() && !BBA51B98())
		{
			if (D78DF003 == "")
			{
				D78DF003 = method_9();
			}
			if (!(string_11 != D78DF003))
			{
				if (E4301198 == 0)
				{
					break;
				}
				method_40(1.0);
				D78DF003 = "";
				if (Environment.TickCount - tickCount >= E4301198 * 1000)
				{
					break;
				}
				continue;
			}
			return true;
		}
		return false;
	}

	internal void method_61()
	{
		string text = "300645083384735";
		method_10("https://mobile.facebook.com/privacy/touch/composer/selector/?logging_source=composer_options&paipv=0");
		if (BEA5E4BB("return document.querySelector('[href^=\"/privacy/save/\"] [name=\"privacyx\"][value=\"" + text + "\"]').checked").ToString().ToLower() != "true")
		{
			string text2 = BEA5E4BB("return document.querySelector('[href^=\"/privacy/save/?privacy_x=" + text + "\"]').getAttribute('href')").ToString();
			if (text2 != "")
			{
				string text3 = D789C71C(method_9());
				text2 = text3 + text2;
				method_10(text2);
			}
			else if (CD003D3F("#modalDialogView [type=\"submit\"]", 5.0))
			{
				method_19("#modalDialog [data-sigil=\"audience-options-list\"] input[type=\"radio\"]");
				method_40(2.0);
				method_19("#modalDialogView [type=\"submit\"]");
				method_40(2.0);
			}
		}
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RunScript(byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] byte_3, byte[] byte_4);

	public string E9B89BB8(string string_12, string string_13 = "")
	{
		if (!method_1() && !BBA51B98())
		{
			string text = "";
			if (GClass25.smethod_0("configDebug").method_3("ckbUseScriptFile"))
			{
				text = GClass25.smethod_0("configDebug").C0288288("txtFilePath");
			}
			string text2 = GClass8.smethod_10(RunScript(GClass8.smethod_11(Int32_2.ToString()), GClass8.smethod_11(A294ABA3), GClass8.smethod_11(text), GClass8.smethod_11(string_12), GClass8.smethod_11(string_13)));
			try
			{
				JObject jObject = JObject.Parse(text2);
				if (Convert.ToBoolean(jObject["closed"]))
				{
					EA39AD33 = true;
				}
				text2 = jObject["result"]!.ToString();
				if (text2 == "")
				{
					text2 = jObject["error"]!.ToString();
				}
			}
			catch (Exception)
			{
			}
			return text2;
		}
		return "";
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr RunCode(byte[] byte_0, byte[] byte_1, byte[] byte_2);

	public string method_62(string string_12)
	{
		IntPtr intptr_ = IntPtr.Zero;
		if (!method_1() && !BBA51B98())
		{
			try
			{
				intptr_ = RunCode(GClass8.smethod_11(Int32_2.ToString()), GClass8.smethod_11(A294ABA3), GClass8.smethod_11(string_12));
				string json = GClass8.smethod_10(intptr_);
				JObject jObject = JObject.Parse(json);
				if (Convert.ToBoolean(jObject["closed"]))
				{
					EA39AD33 = true;
				}
				json = jObject["result"]!.ToString();
				if (json == "")
				{
					json = jObject["error"]!.ToString();
				}
				return json;
			}
			catch (Exception)
			{
				return "";
			}
			finally
			{
				GClass8.smethod_12(intptr_);
			}
		}
		return "";
	}

	[DllImport("lukkioidungbaonua", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr StopCode(byte[] C731360B, byte[] byte_0);

	public string DFACBCA6()
	{
		return GClass8.smethod_10(StopCode(GClass8.smethod_11(Int32_2.ToString()), GClass8.smethod_11(A294ABA3)));
	}

	public void method_63(int int_6 = 2)
	{
		List<string> list = new List<string>();
		switch (int_6)
		{
		case 1:
			list = new List<string> { "https://facebook.com", "https://www.facebook.com", "https://web.facebook.com" };
			break;
		case 2:
			list = new List<string> { "https://mobile.facebook.com", "https://m.facebook.com" };
			break;
		case 3:
			list = new List<string> { "https://mbasic.facebook.com", "https://d.facebook.com" };
			break;
		}
		foreach (string item in list)
		{
			string text = method_9();
			if (AFABF4B7(text) != int_6)
			{
				string value = Regex.Match(text, "https://(.*?)facebook.com").Value;
				text = ((value == "") ? item : text.Replace(value, item));
				if (text.Contains("?") && !text.Contains("?id=") && !text.Contains("?story_fbid") && !text.Contains("recover/password") && !text.Contains("?fbid=") && !text.Contains("?v=") && !text.Contains("/si/actor_experience/actor_gateway/nt/?flow_id=") && !text.Contains("1501092823525282"))
				{
					text = text.Split('?')[0].TrimEnd('/');
				}
				method_10(text);
				method_40(2.0);
				continue;
			}
			break;
		}
	}

	internal List<string> method_64()
	{
		string text = E9B89BB8("GetPhone");
		return text.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
	}

	internal List<string> A30A3019()
	{
		if (!method_9().StartsWith("https://www.facebook.com"))
		{
			method_10("https://www.facebook.com/api/graphql/");
		}
		string string_ = GClass8.AC8B8F9C("GetEmail");
		string text = BEA5E4BB(string_).ToString();
		return text.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
	}

	internal List<string> C1A09286(bool E03D9E1E = false)
	{
		List<string> list = new List<string>();
		string json = method_62("GetContact()");
		try
		{
			JArray jArray = JArray.Parse(json);
			foreach (JToken item in jArray)
			{
				if (!(item["type"]!.ToString() != "email"))
				{
					if (!E03D9E1E)
					{
						list.Add(item["contact"]!.ToString());
					}
					else if (!Convert.ToBoolean(item["pending"]))
					{
						list.Add(item["contact"]!.ToString());
					}
				}
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	internal string F6B2B404(string string_12)
	{
		if (!method_9().StartsWith("https://www.facebook.com"))
		{
			method_10("https://www.facebook.com/api/graphql/");
		}
		string string_13 = GClass8.AC8B8F9C("CheckGroup").Replace("{fb_dtsg}", string_12);
		return BEA5E4BB(string_13).ToString();
	}

	internal string method_65(string string_12)
	{
		if (!method_9().StartsWith("https://graph.facebook.com/"))
		{
			method_10("https://graph.facebook.com/");
		}
		string string_13 = GClass8.AC8B8F9C("CheckGroup2").Replace("{token}", string_12);
		return BEA5E4BB(string_13).ToString();
	}

	internal string method_66(string B6BFA726)
	{
		if (!method_9().StartsWith("https://graph.facebook.com/"))
		{
			method_10("https://graph.facebook.com/");
		}
		string string_ = GClass8.AC8B8F9C("CheckBM").Replace("{token}", B6BFA726);
		return BEA5E4BB(string_).ToString();
	}

	internal string method_67(string string_12)
	{
		if (!method_9().StartsWith("https://graph.facebook.com/"))
		{
			method_10("https://graph.facebook.com/");
		}
		string string_13 = GClass8.AC8B8F9C("CheckNgayTao_Friend").Replace("{token}", string_12);
		return BEA5E4BB(string_13).ToString();
	}

	internal string ABB255BA(string string_12, string A02A8402, string string_13, string string_14)
	{
		if (!method_9().StartsWith("https://graph.facebook.com/"))
		{
			method_10("https://graph.facebook.com/");
		}
		string string_15 = GClass8.AC8B8F9C("Check_friend_page_ads").Replace("{token}", string_12).Replace("{friend}", A02A8402)
			.Replace("{page}", string_13)
			.Replace("{ads}", string_14);
		return BEA5E4BB(string_15).ToString();
	}

	internal string method_68()
	{
		if (!method_9().StartsWith("https://www.facebook.com"))
		{
			method_10("https://www.facebook.com/api/graphql/");
		}
		string string_ = GClass8.AC8B8F9C("CheckDating");
		return BEA5E4BB(string_).ToString();
	}

	internal void F99DAA26(List<string> list_0)
	{
		if (!method_9().StartsWith("https://www.facebook.com") || method_9().Contains("https://www.facebook.com/api/graphql"))
		{
			method_10("https://www.facebook.com/");
		}
		string text = GClass8.AC8B8F9C("DeletePhone");
		foreach (string item in list_0)
		{
			if (BEA5E4BB(text.Replace("{phone}", item)).ToString().Contains("Confirmation Required"))
			{
				break;
			}
		}
	}

	public string method_69()
	{
		string result = "";
		try
		{
			if (!method_9().StartsWith("https://www.facebook.com") || method_9().Contains("https://www.facebook.com/api/graphql"))
			{
				method_10("https://www.facebook.com/");
			}
			string string_ = GClass8.AC8B8F9C("CheckLocation");
			result = BEA5E4BB(string_).ToString();
		}
		catch
		{
		}
		return result;
	}

	public string method_70()
	{
		string result = "";
		try
		{
			if (!method_9().StartsWith("https://www.facebook.com"))
			{
				method_10("https://www.facebook.com/api/graphql");
			}
			string string_ = GClass8.AC8B8F9C("CheckPrimaryLocation");
			result = BEA5E4BB(string_).ToString();
		}
		catch
		{
		}
		return result;
	}

	internal void FDB9B1B0(List<string> F58DCAB8)
	{
		if (!method_9().StartsWith("https://accountscenter.facebook.com/"))
		{
			method_10("https://accountscenter.facebook.com/");
		}
		string text = GClass8.AC8B8F9C("DeletePhone2");
		foreach (string item in F58DCAB8)
		{
			BEA5E4BB(text.Replace("{phone}", item)).ToString();
		}
	}

	internal bool method_71(string string_12)
	{
		string_12 = string_12.ToLower();
		string string_13 = "[{\"name\":\"email\", \"value\":\"" + string_12 + "\", \"type\":\"text\"}]";
		string json = E9B89BB8("AddEmail", string_13);
		try
		{
			JObject jObject = JObject.Parse(json);
			return Convert.ToBoolean(jObject["success"]);
		}
		catch
		{
		}
		return false;
	}

	internal bool method_72(string string_12)
	{
		string_12 = string_12.ToLower();
		string string_13 = "[{\"name\":\"email\", \"value\":\"" + string_12 + "\", \"type\":\"text\"}]";
		string json = E9B89BB8("AddEmail2", string_13);
		try
		{
			JObject jObject = JObject.Parse(json);
			return Convert.ToBoolean(jObject["success"]);
		}
		catch
		{
		}
		return false;
	}

	internal bool method_73(string string_12)
	{
		string_12 = string_12.ToLower();
		List<string> list = C1A09286();
		list.Remove(string_12);
		if (list.Count == 0)
		{
			return true;
		}
		string text = method_62("ReauthPassword('" + String_3 + "')");
		if (text != "true")
		{
			return false;
		}
		foreach (string item in list)
		{
			method_62("DeleteEmail2('" + String_3 + "','" + item + "')");
		}
		list = C1A09286();
		list.Remove(string_12);
		return list.Count == 0;
	}

	internal void EF078B24(List<string> BF1DB812)
	{
		string text = GClass8.AC8B8F9C("DeleteMail2");
		if (!method_9().StartsWith("https://accountscenter.facebook.com/"))
		{
			method_10("https://accountscenter.facebook.com/");
		}
		foreach (string item in BF1DB812)
		{
			BEA5E4BB(text.Replace("{email}", item)).ToString();
		}
	}

	internal void method_74(bool bool_9, bool E82BB1BF)
	{
		string text = "";
		string string_ = GClass8.AC8B8F9C("CheckSessionFb");
		if (!method_9().StartsWith("https://www.facebook.com") || method_9().Contains("https://www.facebook.com/api/graphql"))
		{
			method_10("https://www.facebook.com/");
		}
		text = BEA5E4BB(string_).ToString();
		string_ = GClass8.AC8B8F9C("LogoutOldDevice");
		try
		{
			string text2 = "";
			JObject jObject = JObject.Parse(text);
			JToken jToken = jObject["data"]!["security_settings"]!["sessions"]!["edges"];
			foreach (JToken item in (IEnumerable<JToken>)jToken)
			{
				try
				{
					bool flag = Convert.ToBoolean(item["node"]!["is_active"]!.ToString());
					string text3 = item["node"]!["sid"]!.ToString();
					if (text3 != "")
					{
						if (flag && E82BB1BF)
						{
							text2 = text3;
						}
						if (!flag && bool_9)
						{
							text = BEA5E4BB(string_.Replace("{sid}", text3)).ToString();
						}
					}
				}
				catch
				{
				}
			}
			if (text2 != "")
			{
				text = BEA5E4BB(string_.Replace("{sid}", text2)).ToString();
			}
		}
		catch
		{
		}
	}

	public bool B5993C91(string string_12, string A6957F1A)
	{
		bool result = false;
		try
		{
			F3958F9B f3958F9B = new F3958F9B(string_12);
			string input = f3958F9B.method_0("https://www.facebook.com/profile.php?id=" + A6957F1A);
			string value = Regex.Match(input, "\"profile_admin_invite_id\":\"(\\d+)").Groups[1].Value;
			string value2 = Regex.Match(input, "DTSGInitData\",\\[\\],{\"token\":\"(.*?)\"").Groups[1].Value;
			string value3 = Regex.Match(input, "LSD\",\\[\\],{\"token\":\"(.*?)\"").Groups[1].Value;
			if (value != "")
			{
				string value4 = Regex.Match(string_12, "c_user=(\\d+)").Groups[1].Value;
				string text = "https://www.facebook.com/api/graphql/";
				string bFA79D3C = "av=" + value4 + "&__user=" + value4 + "&__a=1&__dyn=&__csr=&__req=&__hs=&dpr=&__ccg=&__rev=&__s=&__hsi=&__comet_req=15&fb_dtsg=" + value2 + "&jazoest=22037&lsd=" + value3 + "&__spin_r=&__spin_b=&__spin_t=&fb_api_caller_class=RelayModern&fb_api_req_friendly_name=ProfilePlusCometAcceptOrDeclineAdminInviteMutation&variables=%7B%22input%22%3A%7B%22client_mutation_id%22%3A%222%22%2C%22actor_id%22%3A%22" + value4 + "%22%2C%22is_accept%22%3Atrue%2C%22profile_admin_invite_id%22%3A%22" + value + "%22%2C%22user_id%22%3A%22" + A6957F1A + "%22%7D%2C%22scale%22%3A1%7D&server_timestamps=true&doc_id=6438160746194698";
				input = f3958F9B.A6321D97(text, bFA79D3C);
				result = input.Contains("accept_or_decline_profile_plus_admin_invite") && !input.Contains("\"errors\"");
				return result;
			}
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	internal string method_75(string string_12, string string_13)
	{
		string text = "";
		string_12 = string_12.A3A66D03();
		if (string_12 == "")
		{
			string text2 = (from string_0 in Class17.smethod_4()
				orderby Guid.NewGuid()
				select string_0).First();
			string text3 = (from string_0 in Class17.smethod_5()
				orderby Guid.NewGuid()
				select string_0).First().Trim();
			string text4 = (from C18C919B in Class17.smethod_6()
				orderby Guid.NewGuid()
				select C18C919B).First();
			string_12 = text2 + ((text3 == "") ? " " : (" " + text3 + " ")) + text4;
		}
		if (string_13 == "")
		{
			string_13 = GClass8.smethod_93(1, "a_A");
		}
		if (GClass8.smethod_44(string_13))
		{
			if (!method_9().StartsWith("https://www.facebook.com") || method_9().Contains("https://www.facebook.com/api/graphql"))
			{
				method_10("https://www.facebook.com/");
			}
			string string_14 = GClass8.AC8B8F9C("CreatePagePro5").Replace("{pageName}", string_12).Replace("{catagoryId}", string_13);
			text = BEA5E4BB(string_14).ToString();
		}
		else
		{
			string text5 = "[aria-label^=\"Category\"] input";
			string text6 = "[role=\"listbox\"] [role=\"option\"]";
			string cA1F5B = "[aria-label=\"Create Page\"]";
			string string_15 = "[aria-label=\"Create Page\"] [role=\"progressbar\"], [aria-label=\"Create Page\"] [data-visualcompletion=\"loading-state\"]";
			method_48();
			method_52();
			while (true)
			{
				method_10("https://www.facebook.com/pages/?category=your_pages&ref=bookmarks");
				method_40(2.0);
				int num = E433E10F();
				if (num == 1)
				{
					continue;
				}
				if (new List<int> { -3, -2, -1, 2 }.Contains(num))
				{
					break;
				}
				List<string> second = method_79();
				if (!method_9().StartsWith("https://www.facebook.com"))
				{
					method_10("https://www.facebook.com/pages/?category=your_pages&ref=bookmarks");
					method_40(2.0);
					method_76();
				}
				int tickCount = Environment.TickCount;
				int num2 = 60;
				while (true)
				{
					string text7 = method_13(0.0, new List<string> { "[aria-label^=\"Page name\"] input", "[href^=\"/pages/creation/\"],[aria-label^=\"Create new \" i]" });
					string text8 = text7;
					string text9 = text8;
					if (text9 == "[href^=\"/pages/creation/\"],[aria-label^=\"Create new \" i]")
					{
						if (CD003D3F("[href^=\"/pages/creation/?profile_switcher_unified_creation\"]"))
						{
							method_16("[href^=\"/pages/creation/?profile_switcher_unified_creation\"]");
						}
						else if (CD003D3F("//*[text()=\"Public Page\"]"))
						{
							method_16("//*[text()=\"Public Page\"]");
							method_40(1.0);
							method_17("[aria-label=\"Next\"]");
						}
						else
						{
							method_16(text7);
						}
					}
					else if (!(text9 == "[aria-label^=\"Page name\"] input"))
					{
						method_58();
						num = E433E10F();
						if (num == 1)
						{
							break;
						}
						if (new List<int> { -3, -2, -1, 2 }.Contains(num))
						{
							goto end_IL_0410;
						}
					}
					else
					{
						method_16(text7);
						method_28(text7);
						method_20(text7, string_12);
						method_40(2.0);
						method_16(text5);
						method_20(text5, string_13);
						method_40(2.0);
						if (!CD003D3F(text6, 10.0))
						{
							D886D510();
						}
						else
						{
							method_16(text6);
							method_40(2.0);
							method_16(cA1F5B);
							method_40(2.0);
							if (method_31(string_15, 60))
							{
								text = method_79().Except(second).FirstOrDefault();
								if (!string.IsNullOrEmpty(text))
								{
									method_11();
									method_76(10);
								}
								goto end_IL_0410;
							}
						}
					}
					if (Environment.TickCount - tickCount > num2 * 1000)
					{
						goto end_IL_0410;
					}
					method_40(2.0);
				}
				continue;
				end_IL_0410:
				break;
			}
			method_53();
		}
		return text;
	}

	public bool method_76(int int_6 = 0)
	{
		try
		{
			if (int_6 > 0)
			{
				WebDriverWait webDriverWait = new WebDriverWait(ChromeDriver_0, TimeSpan.FromSeconds(int_6));
				webDriverWait.Until(ExpectedConditions.AlertIsPresent());
			}
			ChromeDriver_0.SwitchTo().Alert().Accept();
			return true;
		}
		catch
		{
		}
		return false;
	}

	internal bool method_77(string C81D2BBC, string string_12)
	{
		if (!method_9().StartsWith("https://www.facebook.com") || method_9().Contains("https://www.facebook.com/api/graphql"))
		{
			method_10("https://www.facebook.com/");
		}
		BFB4D2B2(C81D2BBC);
		method_10("https://www.facebook.com/settings/?tab=profile_access");
		string string_13 = "[{\"name\":\"pageId\", \"value\":\"" + C81D2BBC + "\", \"type\":\"text\"},{\"name\":\"toUid\", \"value\":\"" + string_12 + "\", \"type\":\"text\"},{\"name\":\"pass\", \"value\":\"" + String_3 + "\", \"type\":\"text\"}]";
		string json = E9B89BB8("ShareAdminPagePro5", string_13);
		JObject jObject = JObject.Parse(json);
		bool result = Convert.ToBoolean(jObject["success"]);
		BFB4D2B2("");
		return result;
	}

	public string method_78()
	{
		return Regex.Match(method_36(), "i_user=(\\d+)").Groups[1].Value;
	}

	internal bool F386B728(string string_12, string CF140D2F)
	{
		if (!method_9().StartsWith("https://www.facebook.com") || method_9().Contains("https://www.facebook.com/api/graphql"))
		{
			method_10("https://www.facebook.com/");
		}
		if (method_78() != string_12)
		{
			BFB4D2B2(string_12);
			method_10("https://www.facebook.com/settings/?tab=profile_access");
		}
		string string_13 = "[{\"name\":\"pageId\", \"value\":\"" + string_12 + "\", \"type\":\"text\"},{\"name\":\"toUid\", \"value\":\"" + CF140D2F + "\", \"type\":\"text\"},{\"name\":\"pass\", \"value\":\"" + String_3 + "\", \"type\":\"text\"}]";
		string json = E9B89BB8("RemoveAdminPagePro5", string_13);
		JObject jObject = JObject.Parse(json);
		bool result = Convert.ToBoolean(jObject["success"]);
		BFB4D2B2("");
		return result;
	}

	public List<string> method_79()
	{
		List<string> list = new List<string>();
		if (!method_9().StartsWith("https://www.facebook.com"))
		{
			method_10("https://www.facebook.com/api/graphql");
		}
		string string_ = GClass8.AC8B8F9C("GetPagePro5");
		string text = BEA5E4BB(string_).ToString();
		return text.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
	}

	public void BFB4D2B2(string F09BE38F)
	{
		try
		{
			OpenQA.Selenium.Cookie cookie = new OpenQA.Selenium.Cookie("i_user", F09BE38F, ".facebook.com", "/", DateTime.Now.AddDays(10.0));
			ChromeDriver_0.Manage().Cookies.AddCookie(cookie);
			method_11();
		}
		catch (Exception exception_)
		{
			method_42(exception_);
		}
	}

	public void method_80()
	{
		if (AFABF4B7() != 1)
		{
			method_10("https://www.facebook.com/");
		}
		try
		{
			string string_ = GClass8.AC8B8F9C("IncomingCallSounds");
			BEA5E4BB(string_).ToString();
			string_ = GClass8.AC8B8F9C("MessageSounds");
			BEA5E4BB(string_).ToString();
			string_ = GClass8.AC8B8F9C("PopupNewMessages");
			BEA5E4BB(string_).ToString();
			string_ = GClass8.AC8B8F9C("ShowContacts");
			BEA5E4BB(string_).ToString();
		}
		catch (Exception)
		{
		}
	}

	public string method_81()
	{
		string text = E9B89BB8("GetTokenEAABs");
		if (!text.StartsWith("EAA"))
		{
			text = "";
		}
		return text;
	}

	public string F61C0617()
	{
		string text = E9B89BB8("GetTokenEAAAAU");
		if (text.StartsWith("EAA"))
		{
			return text;
		}
		int num = 0;
		while (true)
		{
			if (num < 3)
			{
				text = GClass8.C499D098(String_2, String_3, CCBE39A8, String_8, Int32_1).Split('|')[0];
				if (text.StartsWith("EAA"))
				{
					break;
				}
				num++;
				continue;
			}
			return "";
		}
		return text;
	}

	public string method_82()
	{
		string text = "";
		if (!text.StartsWith("EAA"))
		{
			for (int i = 0; i < 3; i++)
			{
				string cCBE39A = CCBE39A8;
				string string_ = "[{\"name\":\"fa2\", \"value\":\"" + cCBE39A + "\", \"type\":\"text\"}]";
				text = E9B89BB8("GetTokenEAAG", string_);
				if (text.StartsWith("EAA"))
				{
					break;
				}
				DFA46D3A();
				method_40(3.0);
			}
		}
		return text;
	}

	public string F2061D97()
	{
		string text = E9B89BB8("GetTokenEAAAAY");
		if (text.StartsWith("EAA"))
		{
			return text;
		}
		text = GClass8.smethod_5(String_2, String_3, CCBE39A8, String_8, Int32_1).Split('|')[0];
		if (text.StartsWith("EAA"))
		{
			return text;
		}
		return "";
	}

	public string method_83()
	{
		string text = E9B89BB8("GetTokenEAABw");
		if (!text.StartsWith("EAA"))
		{
			text = "";
		}
		return text;
	}

	public string method_84(string E087E10C, int int_6)
	{
		try
		{
			string string_ = $"[{{\"name\":\"tuKhoa\", \"value\":\"{E087E10C}\", \"type\":\"text\"}}, {{\"name\":\"limit\", \"value\":\"{int_6}\", \"type\":\"number\"}}]";
			return E9B89BB8("SearchGroup", string_);
		}
		catch (Exception)
		{
		}
		return "";
	}

	public bool method_85()
	{
		try
		{
			string json = E9B89BB8("Logout");
			JObject jObject = JObject.Parse(json);
			return Convert.ToBoolean(jObject["success"]);
		}
		catch (Exception)
		{
		}
		return false;
	}

	public string AF856F86()
	{
		return E9B89BB8("UnlinkInstagram");
	}

	public string A5995C87(string string_12)
	{
		string string_13 = "[{\"name\":\"password\", \"value\":\"" + string_12 + "\", \"type\":\"text\"}]";
		string json = E9B89BB8("LinkInstagram", string_13);
		JObject jObject = JObject.Parse(json);
		return string.Format("{0}|{1}|{2}|{3}", jObject["success"], jObject["username"], jObject["password"], jObject["email"]);
	}

	private string method_86(int E0B22726, string string_12)
	{
		return GClass8.smethod_93(E0B22726, string_12);
	}

	private string D88F3A8B(string F02E4FAF, string string_12, int int_6, string F1113900, string string_13)
	{
		if (method_1())
		{
			return "";
		}
		int tickCount = Environment.TickCount;
		while (true)
		{
			string text = method_62($"GetOtpMailKhoiPhuc('{F02E4FAF}','{string_12}', {int_6}, '{F1113900}')");
			if (!(text != string_13))
			{
				if (Environment.TickCount - tickCount > int_6 * 1000 || method_1())
				{
					break;
				}
				method_40(3.0);
				continue;
			}
			return text;
		}
		return "";
	}

	private string method_87(int F3048583, string string_12, string string_13, int BC0CF001)
	{
		if (!method_1() && !BBA51B98())
		{
			return method_62($"ResolveImageMicrosoft({F3048583}, '{string_12}', '{string_13}', {BC0CF001})");
		}
		return "";
	}

	private string A6A47F88()
	{
		int num = GClass25.smethod_0("configHotmail").method_2("typePassword");
		string text = GClass25.smethod_0("configHotmail").C0288288("txtPassChiDinh");
		if (num == 0)
		{
			return method_86(15, "a_A_0");
		}
		return text.A3A66D03(2);
	}

	private (string mailKp, string passMailKp) method_88(string string_12)
	{
		bool bool_ = GClass25.smethod_0("configHotmail").method_3("ckbThemKyTuGetnada");
		int num = GClass25.smethod_0("configHotmail").method_2("typeKyTu");
		string text = GClass25.smethod_0("configHotmail").C0288288("txtKyTuChiDinh");
		string text2 = "";
		string item = "";
		switch (GClass25.smethod_0("configHotmail").method_2("cbbTypeEmail"))
		{
		case 0:
			text2 = GClass25.smethod_0("configHotmail").C0288288("cbbDomainGetnada", "getnada.com");
			break;
		case 1:
			text2 = GClass25.smethod_0("configHotmail").C0288288("cbbDomainMoakt", "teml.net");
			break;
		case 2:
			text2 = GClass25.smethod_0("configHotmail").C0288288("txtDomainGenerator");
			break;
		case 3:
			text2 = "otpgmail.com";
			break;
		case 4:
			text2 = "mailnesia.com";
			break;
		case 5:
			text2 = "smvmail.com";
			break;
		case 8:
			text2 = GClass25.smethod_0("configHotmail").C0288288("cbbDomainMailtula", "mailtula.com");
			break;
		case 9:
			text2 = GClass25.smethod_0("configHotmail").C0288288("txtDomainMailtm");
			item = GClass8.smethod_93(10, "a_A_0");
			break;
		}
		string item2 = method_62($"GenerateRecoveryMail('{string_12}', {B5134B19(bool_)}, {num}, '{text}', '{text2}')");
		return (item2, item);
	}

	public string F7060B1F(string string_12, string string_13, string string_14, string string_15, GClass11 gclass11_0 = null)
	{
		string_12 = string_12.Trim();
		string_13 = string_13.Trim();
		string_14 = string_14.Trim();
		string_15 = string_15.Trim();
		if (gclass11_0 == null)
		{
			gclass11_0 = new GClass11();
		}
		bool flag = gclass11_0.method_3("UnlockHotmail");
		bool flag2 = gclass11_0.method_3("ThemMailKhoiPhuc2");
		int f = GClass25.smethod_0("configRegHotmail").method_2("typeCaptcha");
		string string_16 = GClass25.smethod_0("configRegHotmail").C0288288("txtCaptcha_" + f);
		int num = GClass25.smethod_0("configHotmail").method_2("nudTimeoutGetOtpGetnada", 60);
		string text = GClass25.smethod_0("configHotmail").C5A69DA0("lstProxyGetnada").smethod_6();
		if (string.IsNullOrEmpty(text))
		{
			text = DEB7B718;
		}
		int num2 = num + 60;
		int num3 = num;
		int bC0CF = 60;
		GClass11 gClass = new GClass11();
		gClass.method_4("success", false);
		gClass.method_4("error", "");
		gClass.method_4("mailRecover", string_14);
		gClass.method_4("passMailRecover", string_15);
		gClass.method_4("passmail", string_13);
		if (flag2)
		{
			method_10("https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=159&ct=1725608543&rver=7.5.2156.0&wp=SA_20MIN&wreply=https%3A%2F%2Faccount.live.com%2Fpassword%2Fchange%3Frefd%3Daccount.microsoft.com%26fref%3Dhome.banner.changepwd%26uaid%3D0a801d2df34b466a81ca4fd348ad36c5&lc=1033&id=38936&mkt=en-US&uaid=0a801d2df34b466a81ca4fd348ad36c5");
		}
		else if (flag)
		{
			method_10(GClass25.smethod_0("configHotmail").C0288288("cbbWebLogin", "https://www.microsoft.com/vi-vn/microsoft-365/"));
		}
		else
		{
			method_10("https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=15&ct=1691141884&rver=7.0.6737.0&wp=MBI_SSL&wreply=https%3a%2f%2foutlook.live.com%2fowa%2f%3fnlp%3d1%26RpsCsrfState%3dd7a5dc50-1baa-7441-e411-465bdcd16528&id=292841&aadredir=1&CBCXT=out&lw=1&fl=dob%2cflname%2cwld&cobrandid=90015");
		}
		method_40(1.0);
		int num4 = 0;
		int num5 = 10;
		int num6 = 0;
		int num7 = num3 / 10;
		string text2 = "";
		int num8 = 0;
		int num9 = 2;
		int num10 = 0;
		int num11 = 3;
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string string_17 = "https://outlook.live.com/mail/0/";
		int tickCount = Environment.TickCount;
		while (true)
		{
			string text7 = method_13(0.0, new List<string>
			{
				"[name=\"loginfmt\"][aria-required=\"true\"]", "[name=\"passwd\"][aria-required=\"true\"]", "#iLandingViewAction", "#btnAskLater", "[name=\"iProofEmail\"]", "[name=\"EmailAddress\"]", "[name=\"DontShowAgain\"]", "#O365_MainLink_Me,#mectrl_viewAccount", "#StartAction", "#iOttText",
				"#iCancel", "#iLooksGood", "[data-task=\"signin\"],#mectrl_main_trigger", "#idA_PWD_SwitchToPassword", "#loadingScreen", "#iSelectProofAction", "#iVerifyText", "#iResetPasswordAction", "#iResetSuccessAction", "[name=\"passwd\"]",
				"[name=\"loginfmt\"]", "#idDiv_SAOTCS_Proofs", "[id^=\"c-shellmenu_custom_outline_newtab_signin_\"]"
			});
			if (text7 != "")
			{
				num4 = 0;
			}
			string text8 = text7;
			string text9 = text8;
			uint num12 = C43AF739.smethod_0(text9);
			if (num12 <= 2053805095)
			{
				if (num12 <= 926608917)
				{
					if (num12 <= 160560651)
					{
						if (num12 != 61418301)
						{
							if (num12 == 160560651 && text9 == "#iLandingViewAction")
							{
								goto IL_0491;
							}
						}
						else if (text9 == "#iResetSuccessAction")
						{
							method_16(text7);
							goto IL_11a6;
						}
					}
					else if (num12 != 261348265)
					{
						if (num12 != 853575775)
						{
							if (num12 == 926608917 && text9 == "[name=\"passwd\"][aria-required=\"true\"]")
							{
								goto IL_0b3f;
							}
						}
						else if (text9 == "[name=\"loginfmt\"]")
						{
							goto IL_0349;
						}
					}
					else if (text9 == "[name=\"DontShowAgain\"]")
					{
						method_16(text7);
						method_40(1.0);
						method_16("#idSIButton9, #acceptButton");
						goto IL_11a6;
					}
				}
				else if (num12 <= 1208005370)
				{
					if (num12 != 1020151071)
					{
						if (num12 != 1144402631)
						{
							if (num12 == 1208005370 && text9 == "#loadingScreen")
							{
								num4++;
								if (num4 >= 5)
								{
									num4 = 0;
									method_11();
								}
								goto IL_11a6;
							}
						}
						else if (text9 == "[name=\"loginfmt\"][aria-required=\"true\"]")
						{
							goto IL_0349;
						}
					}
					else if (text9 == "#iCancel")
					{
						method_16(text7);
						goto IL_11a6;
					}
				}
				else if (num12 != 1311303583)
				{
					if (num12 != 1599624365)
					{
						if (num12 == 2053805095 && text9 == "#O365_MainLink_Me,#mectrl_viewAccount")
						{
							if (!method_9().Contains("https://outlook.live.com/"))
							{
								method_10(string_17);
							}
							gClass.method_4("success", true);
							break;
						}
					}
					else if (text9 == "[data-task=\"signin\"],#mectrl_main_trigger")
					{
						if (CD003D3F("a[id*=\"_rememberedAccount_\"]") && D997803F("a[id*=\"_rememberedAccount_\"]"))
						{
							method_10(string_17);
						}
						else
						{
							method_16(text7);
						}
						goto IL_11a6;
					}
				}
				else if (text9 == "#btnAskLater")
				{
					goto IL_0491;
				}
				goto IL_1053;
			}
			if (num12 <= 2668522881u)
			{
				if (num12 > 2440571791u)
				{
					if (num12 != 2548005543u)
					{
						if (num12 != 2620677736u)
						{
							if (num12 == 2668522881u && text9 == "#iOttText")
							{
								if (CD003D3F("#iFinishViewAction") && D997803F("#iFinishViewAction"))
								{
									method_16("#iFinishViewAction");
								}
								else if (CD003D3F("#iCollectProofsViewAlternate") && D997803F("#iCollectProofsViewAlternate"))
								{
									method_16("#iCollectProofsViewAlternate");
								}
								else if (CD003D3F("#iReviewProofsViewAction") && D997803F("#iReviewProofsViewAction"))
								{
									method_16("#iReviewProofsViewAction");
								}
								else if (CD003D3F("#iRepeatCompromisedViewAction") && D997803F("#iRepeatCompromisedViewAction"))
								{
									method_16("#iRepeatCompromisedViewAction");
								}
								else if (CD003D3F("#iShowSkip") && D997803F("#iShowSkip"))
								{
									method_16("#iShowSkip");
								}
								else if (CD003D3F("[name=\"proof\"]") && D997803F("[name=\"proof\"]"))
								{
									string text10 = BEA5E4BB("var x=[]; document.querySelectorAll('[name=\"proof\"]').forEach(e => {x.push(e.value)}); return x.join('|');");
									if (!text10.Contains("@"))
									{
										gClass.method_4("error", "Xác minh phone");
										break;
									}
									if (string_14 == "")
									{
										gClass.method_4("error", "Xác minh mail khôi phục");
										break;
									}
									string text11 = "";
									MatchCollection matchCollection = Regex.Matches(text10, "\\@(.*?)\\|");
									foreach (Match item in matchCollection)
									{
										if (string_14.Split('@')[1] == item.Groups[1].Value)
										{
											text11 = item.Groups[1].Value;
											break;
										}
									}
									if (text11 == "")
									{
										gClass.method_4("error", "Mail khôi phục không khớp");
										break;
									}
									BEA5E4BB("document.querySelectorAll('[name=\"proof\"]').forEach(e=>{if(e.getAttribute('value').includes('" + text11 + "')) e.click()})");
									method_40(1.0);
									method_16("#iNext");
								}
								else if (CD003D3F("#maincontent #iPassword") && D997803F("#maincontent #iPassword"))
								{
									if (method_5("#maincontent #iPassword") == "")
									{
										string_13 = A6A47F88();
										gClass.method_4("passmail", string_13);
										method_20("#maincontent #iPassword", string_13);
										method_40(1.0);
									}
									method_16("#iPasswordViewAction");
								}
								else if (!(string_14 == ""))
								{
									num6++;
									text5 = D88F3A8B(string_14, string_15, 10, text, text2);
									switch (text5)
									{
									case "":
										break;
									default:
										goto IL_09a2;
									case "too_many_requests":
										goto IL_1407;
									case "fail":
										goto IL_141d;
									}
									if (num6 >= num7)
									{
										gClass.method_4("error", "Không lấy được otp");
										break;
									}
								}
								goto IL_11a6;
							}
						}
						else if (text9 == "#StartAction")
						{
							gClass.method_4("error", "Hotmail bị khóa (1)");
							break;
						}
					}
					else if (text9 == "#iSelectProofAction")
					{
						text3 = method_6("#proofInput0Error");
						if (!(text3 != ""))
						{
							if (CD003D3F("//input[contains(@name,\"ProofOption\")][./following-sibling::span[contains(text(),'" + string_14.Split('@')[1] + "')]]"))
							{
								method_16("//input[contains(@name,\"ProofOption\")][./following-sibling::span[contains(text(),'" + string_14.Split('@')[1] + "')]]");
								method_40(2.0);
								text2 = D88F3A8B(string_14, string_15, 0, text, "");
								if (!(text2 == "fail"))
								{
									method_29("input[name*=\"Email\"], input[type=\"email\"]");
									method_20("input[name*=\"Email\"], input[type=\"email\"]", string_14.Split('@')[0]);
									method_40(2.0);
									method_16(text7);
									goto IL_11a6;
								}
								gClass.method_4("error", "Không kê\u0301t nô\u0301i đươ\u0323c mail kp");
								break;
							}
							gClass.method_4("error", "Mail khôi phục không đu\u0301ng");
							break;
						}
						gClass.method_4("error", "Lô\u0303i reset pass");
						break;
					}
					goto IL_1053;
				}
				if (num12 != 2170474919u)
				{
					if (num12 != 2221530851u)
					{
						if (num12 != 2440571791u || !(text9 == "#iVerifyText"))
						{
							goto IL_1053;
						}
						num6++;
						text5 = D88F3A8B(string_14, string_15, 10, text, text2);
						switch (text5)
						{
						case "":
							break;
						default:
							goto IL_0548;
						case "too_many_requests":
							goto IL_136d;
						case "fail":
							goto IL_1383;
						}
						if (num6 >= num7)
						{
							gClass.method_4("error", "Không lấy được otp");
							break;
						}
					}
					else
					{
						if (!(text9 == "#idA_PWD_SwitchToPassword"))
						{
							goto IL_1053;
						}
						method_16(text7);
					}
				}
				else
				{
					if (!(text9 == "#iResetPasswordAction"))
					{
						goto IL_1053;
					}
					text3 = BEA5E4BB("return document.querySelector('#pNewPwdErrorArea').innerText");
					if (text3 != "" && D997803F("#pNewPwdErrorArea"))
					{
						gClass.method_4("error", "Lỗi khi nhập pass mới");
						break;
					}
					if (method_5("#iPassword") == "")
					{
						string_13 = A6A47F88();
						gClass.method_4("passmail", string_13);
						method_20("#iPassword", string_13);
						method_40(1.0);
						method_20("#iRetypePassword", string_13);
						method_40(1.0);
					}
					method_16(text7);
				}
			}
			else
			{
				if (num12 <= 3815666825u)
				{
					if (num12 != 3002727654u)
					{
						if (num12 != 3751185834u)
						{
							if (num12 == 3815666825u && text9 == "[name=\"passwd\"]")
							{
								goto IL_0b3f;
							}
						}
						else if (text9 == "#iLooksGood")
						{
							method_16(text7);
							goto IL_11a6;
						}
					}
					else if (text9 == "[name=\"iProofEmail\"]")
					{
						method_40(3.0);
						text3 = method_6("#iProofInputError");
						if (!(text3 != ""))
						{
							if (!CD003D3F("#iCollectPhoneViewSkip") || !D997803F("#iCollectPhoneViewSkip"))
							{
								if (CD003D3F("[name=\"proof\"]"))
								{
									string text12 = BEA5E4BB("var x=[]; document.querySelectorAll('[name=\"proof\"]').forEach(e => {x.push(e.value)}); return x.join('|');");
									if (!text12.Contains("@"))
									{
										gClass.method_4("error", "Xác minh phone");
										break;
									}
									if (string_14 == "")
									{
										gClass.method_4("error", "Xác minh mail khôi phục");
										break;
									}
									string text13 = "";
									MatchCollection matchCollection2 = Regex.Matches(text12, "\\@(.*?)\\|");
									foreach (Match item2 in matchCollection2)
									{
										if (string_14.Split('@')[1] == item2.Groups[1].Value)
										{
											text13 = item2.Groups[1].Value;
											break;
										}
									}
									if (text13 == "")
									{
										gClass.method_4("error", "Mail khôi phục không khớp");
										break;
									}
									BEA5E4BB("document.querySelectorAll('[name=\"proof\"]').forEach(e=>{if(e.getAttribute('value').includes('" + text13 + "')) e.click()})");
									method_40(1.0);
								}
								if (!(string_14 == ""))
								{
									text2 = D88F3A8B(string_14, string_15, 0, text, "");
									if (!(text2 == "fail"))
									{
										method_20(text7, string_14.Split('@')[0]);
										method_40(1.0);
										method_16("#iSelectProofAction");
										goto IL_11a6;
									}
									gClass.method_4("error", "Không kê\u0301t nô\u0301i đươ\u0323c mail kp");
									break;
								}
								gClass.method_4("error", "Xác minh mail khôi phục");
								break;
							}
							gClass.method_4("error", "Hotmail bị khóa (2)");
							break;
						}
						gClass.method_4("error", "Sai mail khôi phục");
						break;
					}
					goto IL_1053;
				}
				if (num12 != 3911541265u)
				{
					if (num12 != 4022600828u)
					{
						if (num12 != 4109521859u || !(text9 == "[name=\"EmailAddress\"]"))
						{
							goto IL_1053;
						}
						if (CD003D3F("#iEmailSection") && !D997803F("#iEmailSection"))
						{
							method_30("#iEmailSection");
						}
						else if (CD003D3F("#iShowSkip") && D997803F("#iShowSkip"))
						{
							method_16("#iShowSkip");
						}
						else
						{
							string text14 = method_89(string_12, string_13, string_14, string_15);
							GClass11 gClass2 = new GClass11(text14, bool_0: true);
							if (!gClass2.method_3("success"))
							{
								gClass.method_4("error", "Yêu cầu add mail khôi phục");
								break;
							}
							string_14 = gClass2.C0288288("mailRecover");
							string_15 = gClass2.C0288288("passMailRecover");
							gClass.method_4("mailRecover", string_14);
							gClass.method_4("passMailRecover", string_15);
							method_10(string_17);
						}
					}
					else if (!(text9 == "#idDiv_SAOTCS_Proofs"))
					{
						goto IL_1053;
					}
				}
				else
				{
					if (!(text9 == "[id^=\"c-shellmenu_custom_outline_newtab_signin_\"]"))
					{
						goto IL_1053;
					}
					method_10(string_17);
				}
			}
			goto IL_11a6;
			IL_136d:
			gClass.method_4("error", "Getnada block ip, vui lo\u0300ng đô\u0309i ip kha\u0301c");
			break;
			IL_1383:
			gClass.method_4("error", "Không kê\u0301t nô\u0301i đươ\u0323c mail kp");
			break;
			IL_0548:
			text2 = text5;
			method_29(text7);
			method_20(text7, text5);
			method_40(1.0);
			method_16("#iVerifyIdentityAction");
			goto IL_11a6;
			IL_1053:
			if (CD003D3F("#iNext") && D997803F("#iNext"))
			{
				method_16("#iNext");
			}
			else
			{
				string text15 = method_9();
				if (text15.StartsWith("https://privacynotice.account.microsoft.com/notice"))
				{
					method_16("button");
				}
				else
				{
					string text16 = C12B8625();
					if (!text15.StartsWith("https://account.microsoft.com/auth/complete-client-signin-oauth-silent?state=") && !text15.StartsWith("https://account.live.com/error.aspx?errcode=") && !text15.Contains("chrome-error://chromewebdata/") && !text16.Contains("Ref A:") && !text16.Contains("Service Unavailable"))
					{
						if (text15.StartsWith("https://www.office.com/?auth="))
						{
							method_10(string_17);
						}
						else if (CD003D3F("#app button"))
						{
							method_16("#app button");
						}
						else if (CD003D3F(".refreshPageButton"))
						{
							BEA5E4BB("refreshPage();");
						}
						else
						{
							if (num4 >= num5)
							{
								break;
							}
							num4++;
						}
					}
					else
					{
						num4++;
						if (num4 >= 5)
						{
							num4 = 0;
							method_10(string_17);
						}
					}
				}
			}
			goto IL_11a6;
			IL_0b3f:
			if (CD003D3F("[id^=\"wlspispHIPBimg\"]"))
			{
				string text17 = BEA5E4BB("var img=document.querySelector('[id^=\"wlspispHIPBimg\"]');var d=document.createElement('canvas');d.height=96;d.width=216;var ctx=d.getContext('2d');ctx.drawImage(img,0,0);var x=d.toDataURL(); return x").Replace("data:image/png;base64,", "");
				if (!(text17 == "") && !(text17 == "iVBORw0KGgoAAAANSUhEUgAAANgAAABgCAYAAAB/ubz1AAAAAXNSR0IArs4c6QAAAjZJREFUeF7t0zERAAAIAzHq3zQqfgsCOuT4nSNAIBNYtmyYAIETmCcgEAoILMQ1TUBgfoBAKCCwENc0AYH5AQKhgMBCXNMEBOYHCIQCAgtxTRMQmB8gEAoILMQ1TUBgfoBAKCCwENc0AYH5AQKhgMBCXNMEBOYHCIQCAgtxTRMQmB8gEAoILMQ1TUBgfoBAKCCwENc0AYH5AQKhgMBCXNMEBOYHCIQCAgtxTRMQmB8gEAoILMQ1TUBgfoBAKCCwENc0AYH5AQKhgMBCXNMEBOYHCIQCAgtxTRMQmB8gEAoILMQ1TUBgfoBAKCCwENc0AYH5AQKhgMBCXNMEBOYHCIQCAgtxTRMQmB8gEAoILMQ1TUBgfoBAKCCwENc0AYH5AQKhgMBCXNMEBOYHCIQCAgtxTRMQmB8gEAoILMQ1TUBgfoBAKCCwENc0AYH5AQKhgMBCXNMEBOYHCIQCAgtxTRMQmB8gEAoILMQ1TUBgfoBAKCCwENc0AYH5AQKhgMBCXNMEBOYHCIQCAgtxTRMQmB8gEAoILMQ1TUBgfoBAKCCwENc0AYH5AQKhgMBCXNMEBOYHCIQCAgtxTRMQmB8gEAoILMQ1TUBgfoBAKCCwENc0AYH5AQKhgMBCXNMEBOYHCIQCAgtxTRMQmB8gEAoILMQ1TUBgfoBAKCCwENc0AYH5AQKhgMBCXNMEBOYHCIQCAgtxTRMQmB8gEAoILMQ1TUBgfoBAKCCwENc0AYH5AQKhgMBCXNMEHrwyAGGfbFR9AAAAAElFTkSuQmCC"))
				{
					num10++;
					if (num10 > num11)
					{
						gClass.method_4("error", "Captcha");
						break;
					}
					text4 = method_87(f, string_16, text17, bC0CF);
					if (text4 == "")
					{
						method_16("[id^=\"wlspispHIPNew\"]");
					}
					else
					{
						method_20("[id^=\"wlspispSolutionElement\"]", text4);
						method_40(1.0);
						method_20(text7, string_13);
						method_40(1.0);
						method_16("#idSIButton9");
					}
				}
			}
			else
			{
				text6 = method_13(0.0, new List<string> { "#passwordError", "[data-testid=\"inputComponentWrapper\"] [role=\"alert\"]" });
				text3 = method_6(text6);
				if (text3 != "")
				{
					string text18 = method_13(0.0, new List<string>
					{
						"#idA_IL_ForgotPassword0",
						text6 + " span"
					});
					if (text18 != "" && string_14 != "")
					{
						method_16(text18);
						goto IL_11a6;
					}
					num8++;
					if (num8 >= num9)
					{
						gClass.method_4("error", "Sai passmail");
						break;
					}
				}
				if (!(method_5(text7) != ""))
				{
					method_20(text7, string_13);
					method_40(1.0);
					method_16("#idSIButton9");
				}
			}
			goto IL_11a6;
			IL_0491:
			method_16(text7);
			goto IL_11a6;
			IL_11a6:
			if (!method_1())
			{
				if (Environment.TickCount - tickCount < num2 * 1000)
				{
					method_40(1.0);
					continue;
				}
				gClass.method_4("error", "timeout");
				break;
			}
			gClass.method_4("error", "chrome_closed");
			break;
			IL_1407:
			gClass.method_4("error", "Getnada block ip, vui lo\u0300ng đô\u0309i ip kha\u0301c");
			break;
			IL_141d:
			gClass.method_4("error", "Không kê\u0301t nô\u0301i đươ\u0323c mail kp");
			break;
			IL_09a2:
			text2 = text5;
			method_29(text7);
			method_20(text7, text5);
			method_40(1.0);
			method_16("#iVerifyCodeAction,#iNext");
			goto IL_11a6;
			IL_0349:
			if (method_5(text7) != "")
			{
				text6 = method_13(0.0, new List<string> { "#usernameError", "[data-testid=\"inputComponentWrapper\"] [role=\"alert\"]" });
				text3 = method_6(text6);
				if (text3 != "")
				{
					gClass.method_4("error", "Sai email");
					break;
				}
			}
			else
			{
				method_29(text7);
				method_20(text7, string_12);
				method_40(1.0);
				method_16("#idSIButton9");
			}
			goto IL_11a6;
		}
		if (!gClass.method_3("success") && gClass.C0288288("error") == "")
		{
			gClass.method_4("error", "fail");
		}
		return gClass.method_7();
	}

	public string method_89(string EC337CB4, string string_12, string string_13, string string_14)
	{
		int num = GClass25.smethod_0("configHotmail").method_2("nudTimeoutGetOtpGetnada", 60);
		string text = GClass25.smethod_0("configHotmail").C5A69DA0("lstProxyGetnada").smethod_6();
		if (string.IsNullOrEmpty(text))
		{
			text = DEB7B718;
		}
		int num2 = num + 60;
		int num3 = num;
		GClass11 gClass = new GClass11();
		gClass.method_4("success", false);
		gClass.method_4("error", "");
		gClass.method_4("mailRecover", string_13);
		gClass.method_4("passMailRecover", string_14);
		gClass.method_4("passmail", string_12);
		string string_15 = "https://account.live.com/proofs/Add?uaid=50148bd952d946c6bfd5a8e09f28f510&mpSplit=2&apt=2";
		method_10(string_15);
		method_40(1.0);
		int tickCount = Environment.TickCount;
		int num4 = 0;
		int num5 = 10;
		int num6 = 0;
		int num7 = num3 / 10;
		string text2 = "";
		bool flag = false;
		string text3 = "";
		string text4 = "";
		while (true)
		{
			string text5 = method_13(0.0, new List<string> { "[name=\"EmailAddress\"]", "#iOttText,#otc-confirmation-input,[name=\"otc\"]", "#idDiv_SAOTCS_Proofs,[aria-labelledby^=\"errorText \"][data-testid=\"tileList\"]", "#idTxtBx_SAOTCS_ProofConfirmation,#proof-confirmation", "#idTxtBx_SAOTCC_OTC", "#O365_MainLink_Me", "#iCancel", "[name=\"passwd\"][aria-required=\"true\"]" });
			if (text5 != "")
			{
				num4 = 0;
			}
			string text6 = text5;
			string text7 = text6;
			uint num8 = C43AF739.smethod_0(text7);
			if (num8 <= 3797872910u)
			{
				if (num8 > 1020151071)
				{
					if (num8 != 3188555620u)
					{
						if (num8 == 3797872910u && text7 == "#O365_MainLink_Me")
						{
							break;
						}
					}
					else if (text7 == "#idTxtBx_SAOTCS_ProofConfirmation,#proof-confirmation")
					{
						text3 = BEA5E4BB("return document.querySelector('#id_SAOTCS_Error_ProofConfirmation,#proof-confirmationError').innerText");
						if (!(text3 != ""))
						{
							text2 = D88F3A8B(string_13, string_14, 0, text, "");
							if (!(text2 == "fail"))
							{
								method_29(text5);
								method_20(text5, string_13.Split('*')[0]);
								method_40(1.0);
								method_16("#idSubmit_SAOTCS_SendCode,[name=\"proof-confirmation\"] button[type=\"submit\"]");
								goto IL_0662;
							}
							gClass.method_4("error", "Không kê\u0301t nô\u0301i đươ\u0323c mail kp");
							break;
						}
						gClass.method_4("error", "Xác minh mail khôi phục cũ");
						break;
					}
					goto IL_04bd;
				}
				if (num8 != 926608917)
				{
					if (num8 != 1020151071 || !(text7 == "#iCancel"))
					{
						goto IL_04bd;
					}
					method_16(text5);
				}
				else
				{
					if (!(text7 == "[name=\"passwd\"][aria-required=\"true\"]"))
					{
						goto IL_04bd;
					}
					text3 = BEA5E4BB("return document.querySelector('#passwordError').innerText");
					if (text3 != "")
					{
						gClass.method_4("error", "Sai passmail");
						break;
					}
					if (!(method_5(text5) != ""))
					{
						method_20(text5, string_12);
						method_40(1.0);
						method_16("#idSIButton9");
					}
				}
			}
			else if (num8 <= 3966638439u)
			{
				if (num8 != 3858357123u)
				{
					if (num8 != 3966638439u || !(text7 == "#iOttText,#otc-confirmation-input,[name=\"otc\"]"))
					{
						goto IL_04bd;
					}
					flag = false;
					num6++;
					text4 = D88F3A8B(string_13, string_14, 10, text, text2);
					switch (text4)
					{
					case "":
						break;
					default:
						goto IL_0314;
					case "too_many_requests":
						goto IL_077b;
					case "fail":
						goto IL_0791;
					}
					if (num6 >= num7)
					{
						gClass.method_4("error", "Không lấy được otp");
						break;
					}
				}
				else
				{
					if (!(text7 == "#idDiv_SAOTCS_Proofs,[aria-labelledby^=\"errorText \"][data-testid=\"tileList\"]"))
					{
						goto IL_04bd;
					}
					if (flag)
					{
						break;
					}
					if (string_13 == "")
					{
						gClass.method_4("error", "Xác minh mail khôi phục cũ");
						if (method_6(text5).Contains("+"))
						{
							gClass.method_4("error", "Xác minh phone cũ");
						}
						break;
					}
					if (E22B0917("[role=\"listitem\"]") > 1)
					{
						text5 = "//*[@role='listitem'][.//*[contains(text(),'" + string_13.Split('@')[1] + "')]]";
						if (!CD003D3F(text5))
						{
							gClass.method_4("error", "Xác minh mail khôi phục cũ");
							break;
						}
						method_16(text5);
					}
					else
					{
						method_16(text5);
					}
				}
			}
			else if (num8 != 4109521859u)
			{
				if (num8 != 4138054670u || !(text7 == "#idTxtBx_SAOTCC_OTC"))
				{
					goto IL_04bd;
				}
				if (!(string_13 == ""))
				{
					num6++;
					text4 = D88F3A8B(string_13, string_14, 10, text, text2);
					switch (text4)
					{
					case "":
						break;
					default:
						goto IL_0474;
					case "too_many_requests":
						goto IL_0811;
					case "fail":
						goto IL_0824;
					}
					if (num6 >= num7)
					{
						gClass.method_4("error", "Không lấy được otp");
						break;
					}
				}
			}
			else
			{
				if (!(text7 == "[name=\"EmailAddress\"]"))
				{
					goto IL_04bd;
				}
				text3 = BEA5E4BB("return document.querySelector('#EmailError').innerText");
				if (text3 != "")
				{
					if (!(text3.Contains("This is already part of your security info") && flag))
					{
						flag = false;
						gClass.method_4("error", "Lỗi khi nhập mail khôi phục");
					}
					break;
				}
				if (method_5(text5) == "")
				{
					(string mailKp, string passMailKp) tuple = method_88(EC337CB4);
					string_13 = tuple.mailKp;
					string_14 = tuple.passMailKp;
					text2 = D88F3A8B(string_13, string_14, 0, text, "");
					if (text2 == "fail")
					{
						gClass.method_4("error", "Không kê\u0301t nô\u0301i đươ\u0323c mail kp");
						break;
					}
					method_29(text5);
					method_20(text5, string_13);
					method_40(1.0);
				}
				method_16("#iNext");
			}
			goto IL_0662;
			IL_0662:
			if (!method_1())
			{
				if (Environment.TickCount - tickCount < num2 * 1000)
				{
					method_40(1.0);
					continue;
				}
				gClass.method_4("error", "timeout");
				break;
			}
			gClass.method_4("error", "chrome_closed");
			break;
			IL_0314:
			text2 = text4;
			method_29(text5);
			method_20(text5, text4);
			method_40(1.0);
			method_16("#iNext,[name=\"otc-confirmation\"] button[type=\"submit\"],[name=\"OneTimeCodeViewForm\"] button[type=\"submit\"],#idSubmit_SAOTCC_Continue");
			flag = true;
			goto IL_0662;
			IL_077b:
			gClass.method_4("error", "Getnada block ip, vui lo\u0300ng đô\u0309i ip kha\u0301c");
			break;
			IL_0474:
			text2 = text4;
			method_29(text5);
			method_20(text5, text4);
			method_40(1.0);
			method_16("#idSubmit_SAOTCC_Continue");
			goto IL_0662;
			IL_0824:
			gClass.method_4("error", "Không kê\u0301t nô\u0301i đươ\u0323c mail kp");
			break;
			IL_0811:
			gClass.method_4("error", "Getnada block ip, vui lo\u0300ng đô\u0309i ip kha\u0301c");
			break;
			IL_0791:
			gClass.method_4("error", "Không kê\u0301t nô\u0301i đươ\u0323c mail kp");
			break;
			IL_04bd:
			if (CD003D3F("#iNext") && D997803F("#iNext"))
			{
				method_16("#iNext");
			}
			else
			{
				string text8 = method_9();
				if (text8.StartsWith("https://privacynotice.account.microsoft.com/notice"))
				{
					method_16("button");
				}
				else
				{
					string text9 = C12B8625();
					if (!text8.StartsWith("https://account.microsoft.com/auth/complete-client-signin-oauth-silent?state=") && !text8.StartsWith("https://account.live.com/error.aspx?errcode=") && !text8.Contains("chrome-error://chromewebdata/") && !text9.Contains("Ref A:") && !text9.Contains("Service Unavailable"))
					{
						if (CD003D3F(".refreshPageButton"))
						{
							BEA5E4BB("refreshPage();");
						}
						else
						{
							if (num4 >= num5)
							{
								break;
							}
							num4++;
						}
					}
					else
					{
						num4++;
						if (num4 >= 5)
						{
							num4 = 0;
							method_10(string_15);
						}
					}
				}
			}
			goto IL_0662;
		}
		if (!gClass.method_3("success") && gClass.C0288288("error") == "")
		{
			if (flag)
			{
				gClass.method_4("success", true);
				gClass.method_4("mailRecover", string_13);
				gClass.method_4("passMailRecover", string_14);
			}
			else
			{
				gClass.method_4("error", "Add mail khôi phục thất bại");
			}
		}
		return gClass.method_7();
	}

	public string D58D8697(string string_12, string string_13, string EA037F05, string string_14)
	{
		string text = GClass25.smethod_0("configHotmail").C5A69DA0("lstProxyGetnada").smethod_6();
		if (string.IsNullOrEmpty(text))
		{
			text = DEB7B718;
		}
		int num = 120;
		GClass11 gClass = new GClass11();
		gClass.method_4("success", false);
		gClass.method_4("error", "");
		gClass.method_4("passmail", string_13);
		gClass.method_4("mailRecover", EA037F05);
		gClass.method_4("passMailRecover", string_14);
		string string_15 = "https://account.live.com/proofs/manage/additional?mkt=en-US&refd=account.microsoft.com&refp=security";
		method_10(string_15);
		method_40(1.0);
		int tickCount = Environment.TickCount;
		int num2 = 0;
		int num3 = 10;
		int num4 = 0;
		int num5 = 6;
		string text2 = "";
		string text3 = "";
		string text4 = "";
		while (true)
		{
			string text5 = method_13(0.0, new List<string> { "[id*=\"Email\"]", "#iOttText,#otc-confirmation-input,[name=\"otc\"]", "#idDiv_SAOTCS_Proofs,[aria-labelledby=\"errorText Verify your identity\"]", "#idTxtBx_SAOTCS_ProofConfirmation,#proof-confirmation", "#idTxtBx_SAOTCC_OTC", "#iCancel", "[name=\"passwd\"][aria-required=\"true\"]" });
			if (text5 != "")
			{
				num2 = 0;
			}
			string text6 = text5;
			string text7 = text6;
			uint num6 = C43AF739.smethod_0(text7);
			if (num6 <= 2372484142u)
			{
				if (num6 != 926608917)
				{
					if (num6 != 1020151071)
					{
						if (num6 != 2372484142u || !(text7 == "#idDiv_SAOTCS_Proofs,[aria-labelledby=\"errorText Verify your identity\"]"))
						{
							goto IL_04be;
						}
						if (EA037F05 == "")
						{
							gClass.method_4("error", "Xác minh mail khôi phục cũ");
							if (method_6(text5).Contains("+"))
							{
								gClass.method_4("error", "Xác minh phone cũ");
							}
							break;
						}
						if (E22B0917("[role=\"listitem\"]") > 1)
						{
							text5 = "//*[@role='listitem'][.//*[contains(text(),'" + EA037F05.Split('@')[1] + "')]]";
							if (!CD003D3F(text5))
							{
								gClass.method_4("error", "Xác minh mail khôi phục cũ");
								break;
							}
							method_16(text5);
						}
						else
						{
							method_16(text5);
						}
					}
					else
					{
						if (!(text7 == "#iCancel"))
						{
							goto IL_04be;
						}
						method_16(text5);
					}
				}
				else
				{
					if (!(text7 == "[name=\"passwd\"][aria-required=\"true\"]"))
					{
						goto IL_04be;
					}
					text3 = BEA5E4BB("return document.querySelector('#passwordError').innerText");
					if (text3 != "")
					{
						gClass.method_4("error", "Sai passmail");
						break;
					}
					if (!(method_5(text5) != ""))
					{
						method_29(text5);
						method_20(text5, string_13);
						method_40(1.0);
						method_16("#idSIButton9");
					}
				}
			}
			else if (num6 <= 3966638439u)
			{
				if (num6 != 3188555620u)
				{
					if (num6 != 3966638439u || !(text7 == "#iOttText,#otc-confirmation-input,[name=\"otc\"]"))
					{
						goto IL_04be;
					}
					num4++;
					text4 = D88F3A8B(EA037F05, string_14, 10, text, text2);
					switch (text4)
					{
					case "":
						break;
					default:
						goto IL_02bb;
					case "too_many_requests":
						goto IL_0791;
					case "fail":
						goto IL_07a6;
					}
					if (num4 >= num5)
					{
						gClass.method_4("error", "Không lấy được otp");
						break;
					}
				}
				else
				{
					if (!(text7 == "#idTxtBx_SAOTCS_ProofConfirmation,#proof-confirmation"))
					{
						goto IL_04be;
					}
					text3 = BEA5E4BB("return document.querySelector('#id_SAOTCS_Error_ProofConfirmation,#proof-confirmationError').innerText");
					if (text3 != "")
					{
						gClass.method_4("error", "Xác minh mail khôi phục cũ");
						break;
					}
					text2 = D88F3A8B(EA037F05, string_14, 0, text, "");
					if (text2 == "fail")
					{
						gClass.method_4("error", "Không kê\u0301t nô\u0301i đươ\u0323c mail kp");
						break;
					}
					method_29(text5);
					method_20(text5, EA037F05.Split('*')[0]);
					method_40(1.0);
					method_16("#idSubmit_SAOTCS_SendCode,[name=\"proof-confirmation\"] button[type=\"submit\"]");
				}
			}
			else if (num6 != 4138054670u)
			{
				if (num6 != 4170035877u || !(text7 == "[id*=\"Email\"]"))
				{
					goto IL_04be;
				}
				if (CD003D3F("[name=\"EmailAddress\"]") && D997803F("[name='EmailAddress']"))
				{
					text5 = "[name='EmailAddress']";
					text3 = BEA5E4BB("return document.querySelector('#EmailError').innerText");
					if (text3 != "")
					{
						EA037F05 = "";
						gClass.method_4("error", "Lỗi khi nhập mail khôi phục");
						break;
					}
					if (method_5(text5) == "")
					{
						(string mailKp, string passMailKp) tuple = method_88(string_12);
						EA037F05 = tuple.mailKp;
						string_14 = tuple.passMailKp;
						text2 = D88F3A8B(EA037F05, string_14, 0, text, "");
						if (text2 == "fail")
						{
							gClass.method_4("error", "Không kê\u0301t nô\u0301i đươ\u0323c mail kp");
							break;
						}
						method_29(text5);
						method_20(text5, EA037F05);
						method_40(1.0);
					}
					method_16("#iNext");
				}
				else
				{
					if (!CD003D3F("#iBtn_action"))
					{
						for (int i = 0; i < 2; i++)
						{
							List<string> list = JArray.Parse(method_62("GetMailKhoiPhuc()")).Values<string>().ToList();
							if (list.Count != 0)
							{
								if (list.Count != 1)
								{
									method_62("XoaMailKhoiPhuc('" + EA037F05 + "')");
									method_11();
									continue;
								}
								gClass.method_4("success", true);
								break;
							}
							gClass.method_4("error", "Không ti\u0300m thâ\u0301y mail kp");
							break;
						}
						break;
					}
					method_16("#iBtn_action");
				}
			}
			else
			{
				if (!(text7 == "#idTxtBx_SAOTCC_OTC"))
				{
					goto IL_04be;
				}
				if (!(EA037F05 == ""))
				{
					num4++;
					text4 = D88F3A8B(EA037F05, string_14, 10, text, text2);
					switch (text4)
					{
					case "":
						break;
					default:
						goto IL_0630;
					case "too_many_requests":
						goto IL_08b2;
					case "fail":
						goto IL_08c4;
					}
					if (num4 >= num5)
					{
						gClass.method_4("error", "Không lấy được otp");
						break;
					}
				}
			}
			goto IL_0663;
			IL_04be:
			if (CD003D3F("#iNext") && D997803F("#iNext"))
			{
				method_16("#iNext");
			}
			else
			{
				string text8 = method_9();
				if (text8.StartsWith("https://privacynotice.account.microsoft.com/notice"))
				{
					method_16("button");
				}
				else
				{
					string text9 = C12B8625();
					if (!text8.StartsWith("https://account.microsoft.com/auth/complete-client-signin-oauth-silent?state=") && !text8.StartsWith("https://account.live.com/error.aspx?errcode=") && !text8.Contains("chrome-error://chromewebdata/") && !text9.Contains("Ref A:") && !text9.Contains("Service Unavailable"))
					{
						if (CD003D3F(".refreshPageButton"))
						{
							BEA5E4BB("refreshPage();");
						}
						else
						{
							if (num2 >= num3)
							{
								break;
							}
							num2++;
						}
					}
					else
					{
						num2++;
						if (num2 >= 5)
						{
							num2 = 0;
							method_10(string_15);
						}
					}
				}
			}
			goto IL_0663;
			IL_02bb:
			text2 = text4;
			method_29(text5);
			method_20(text5, text4);
			method_40(1.0);
			method_16("#iNext,[name=\"otc-confirmation\"] button[type=\"submit\"],[name=\"OneTimeCodeViewForm\"] button[type=\"submit\"],#idSubmit_SAOTCC_Continue");
			goto IL_0663;
			IL_0630:
			text2 = text4;
			method_29(text5);
			method_20(text5, text4);
			method_40(1.0);
			method_16("#idSubmit_SAOTCC_Continue");
			goto IL_0663;
			IL_08b2:
			gClass.method_4("error", "Getnada block ip, vui lo\u0300ng đô\u0309i ip kha\u0301c");
			break;
			IL_0663:
			if (!method_1())
			{
				if (Environment.TickCount - tickCount < num * 1000)
				{
					method_40(1.0);
					continue;
				}
				gClass.method_4("error", "timeout");
				break;
			}
			gClass.method_4("error", "chrome_closed");
			break;
			IL_08c4:
			gClass.method_4("error", "Không kê\u0301t nô\u0301i đươ\u0323c mail kp");
			break;
			IL_07a6:
			gClass.method_4("error", "Không kê\u0301t nô\u0301i đươ\u0323c mail kp");
			break;
			IL_0791:
			gClass.method_4("error", "Getnada block ip, vui lo\u0300ng đô\u0309i ip kha\u0301c");
			break;
		}
		if (!gClass.method_3("success") && gClass.C0288288("error") == "")
		{
			gClass.method_4("error", "Xóa mail khôi phục thất bại");
		}
		gClass.method_4("mailRecover", EA037F05);
		gClass.method_4("passMailRecover", string_14);
		return gClass.method_7();
	}

	public string B116F9B3(string string_12, string BE0B20B3, string string_13, string BC83DD86)
	{
		int num = GClass25.smethod_0("configHotmail").method_2("nudTimeoutGetOtpGetnada", 60);
		string text = GClass25.smethod_0("configHotmail").C5A69DA0("lstProxyGetnada").smethod_6();
		if (string.IsNullOrEmpty(text))
		{
			text = DEB7B718;
		}
		int num2 = num + 60;
		int num3 = num;
		GClass11 gClass = new GClass11();
		gClass.method_4("success", false);
		gClass.method_4("error", "");
		gClass.method_4("passmail", BE0B20B3);
		gClass.method_4("mailRecover", string_13);
		gClass.method_4("passMailRecover", BC83DD86);
		string string_14 = "https://account.live.com/password/change?refd=account.microsoft.com&fref=home.banner.changepwd";
		method_10(string_14);
		method_40(1.0);
		int tickCount = Environment.TickCount;
		int num4 = 0;
		int num5 = 10;
		int num6 = 0;
		int num7 = num3 / 10;
		bool flag = false;
		string text2 = "";
		string text3 = "";
		while (true)
		{
			string text4 = method_13(0.0, new List<string> { "[name=\"EmailAddress\"]", "#iOttText,#otc-confirmation-input,[name=\"otc\"]", "#idDiv_SAOTCS_Proofs,[aria-labelledby=\"errorText Verify your identity\"]", "#idTxtBx_SAOTCS_ProofConfirmation,#proof-confirmation", "#idTxtBx_SAOTCC_OTC", "#iCancel", "#iCurPassword", "#O365_MainLink_Me", "[name=\"passwd\"]" });
			if (text4 != "")
			{
				num4 = 0;
			}
			string text5 = text4;
			string text6 = text5;
			uint num8 = C43AF739.smethod_0(text6);
			if (num8 <= 3508380156u)
			{
				if (num8 <= 2372484142u)
				{
					if (num8 != 1020151071)
					{
						if (num8 != 2372484142u || !(text6 == "#idDiv_SAOTCS_Proofs,[aria-labelledby=\"errorText Verify your identity\"]"))
						{
							goto IL_05da;
						}
						if (string_13 == "")
						{
							gClass.method_4("error", "Xác minh mail khôi phục cũ");
							if (method_6(text4).Contains("+"))
							{
								gClass.method_4("error", "Xác minh phone cũ");
							}
							break;
						}
						if (E22B0917("[role=\"listitem\"]") > 1)
						{
							text4 = "//*[@role='listitem'][.//*[contains(text(),'" + string_13.Split('@')[1] + "')]]";
							if (!CD003D3F(text4))
							{
								gClass.method_4("error", "Xác minh mail khôi phục cũ");
								break;
							}
							method_16(text4);
						}
						else
						{
							method_16(text4);
						}
					}
					else
					{
						if (!(text6 == "#iCancel"))
						{
							goto IL_05da;
						}
						method_16(text4);
					}
				}
				else if (num8 != 3188555620u)
				{
					if (num8 != 3508380156u || !(text6 == "#iCurPassword"))
					{
						goto IL_05da;
					}
					string text7 = BEA5E4BB("return document.querySelector('#pPwdErrorArea').innerText");
					if (text7 != "" && D997803F("#pPwdErrorArea"))
					{
						flag = false;
						gClass.method_4("error", "Lỗi khi nhập pass mới");
						break;
					}
					text7 = BEA5E4BB("return document.querySelector('#pNewPwdErrorArea').innerText");
					if (text7 != "" && D997803F("#pNewPwdErrorArea"))
					{
						flag = false;
						gClass.method_4("error", "Lỗi khi nhập pass mới");
						break;
					}
					if (method_5(text4) == "")
					{
						method_20(text4, BE0B20B3);
						method_40(1.0);
						string text8 = A6A47F88();
						method_20("#iPassword", text8);
						method_40(1.0);
						method_20("#iRetypePassword", text8);
						method_40(1.0);
						gClass.method_4("passmail", text8);
					}
					if (method_16("#UpdatePasswordAction"))
					{
						flag = true;
					}
				}
				else
				{
					if (!(text6 == "#idTxtBx_SAOTCS_ProofConfirmation,#proof-confirmation"))
					{
						goto IL_05da;
					}
					string text7 = BEA5E4BB("return document.querySelector('#id_SAOTCS_Error_ProofConfirmation,#proof-confirmationError').innerText");
					if (text7 != "")
					{
						gClass.method_4("error", "Xác minh mail khôi phục cũ");
						break;
					}
					text2 = D88F3A8B(string_13, BC83DD86, 0, text, "");
					if (text2 == "fail")
					{
						gClass.method_4("error", "Không kê\u0301t nô\u0301i đươ\u0323c mail kp");
						break;
					}
					method_29(text4);
					method_20(text4, string_13.Split('*')[0]);
					method_40(1.0);
					method_16("#idSubmit_SAOTCS_SendCode,[name=\"proof-confirmation\"] button[type=\"submit\"]");
				}
			}
			else if (num8 <= 3815666825u)
			{
				if (num8 != 3797872910u)
				{
					if (num8 != 3815666825u || !(text6 == "[name=\"passwd\"]"))
					{
						goto IL_05da;
					}
					if (flag)
					{
						break;
					}
					string text7 = BEA5E4BB("return document.querySelector('#passwordError').innerText");
					if (text7 != "")
					{
						gClass.method_4("error", "Sai passmail");
						break;
					}
					if (!(method_5(text4) != ""))
					{
						method_20(text4, BE0B20B3);
						method_40(1.0);
						method_16("#idSIButton9");
					}
				}
				else
				{
					if (!(text6 == "#O365_MainLink_Me"))
					{
						goto IL_05da;
					}
					if (flag)
					{
						break;
					}
					method_10(string_14);
				}
			}
			else if (num8 != 3966638439u)
			{
				if (num8 != 4109521859u)
				{
					if (num8 != 4138054670u || !(text6 == "#idTxtBx_SAOTCC_OTC"))
					{
						goto IL_05da;
					}
					if (!(string_13 == ""))
					{
						num6++;
						text3 = D88F3A8B(string_13, BC83DD86, 10, text, text2);
						switch (text3)
						{
						case "":
							break;
						default:
							goto IL_04e2;
						case "too_many_requests":
							goto IL_0919;
						case "fail":
							goto IL_092f;
						}
						if (num6 >= num7)
						{
							gClass.method_4("error", "Không lấy được otp");
							break;
						}
					}
				}
				else
				{
					if (!(text6 == "[name=\"EmailAddress\"]"))
					{
						goto IL_05da;
					}
					string text7 = BEA5E4BB("return document.querySelector('#EmailError').innerText");
					if (text7 != "")
					{
						string_13 = "";
						gClass.method_4("error", "Lỗi khi nhập mail khôi phục");
						break;
					}
					if (method_5(text4) == "")
					{
						(string mailKp, string passMailKp) tuple = method_88(string_12);
						string_13 = tuple.mailKp;
						BC83DD86 = tuple.passMailKp;
						text2 = D88F3A8B(string_13, BC83DD86, 0, text, "");
						if (text2 == "fail")
						{
							gClass.method_4("error", "Không kê\u0301t nô\u0301i đươ\u0323c mail kp");
							break;
						}
						method_29(text4);
						method_20(text4, string_13);
						method_40(1.0);
					}
					method_16("#iNext");
				}
			}
			else
			{
				if (!(text6 == "#iOttText,#otc-confirmation-input,[name=\"otc\"]"))
				{
					goto IL_05da;
				}
				num6++;
				text3 = D88F3A8B(string_13, BC83DD86, 10, text, text2);
				switch (text3)
				{
				case "":
					break;
				default:
					goto IL_073c;
				case "too_many_requests":
					goto IL_09ab;
				case "fail":
					goto IL_09be;
				}
				if (num6 >= num7)
				{
					gClass.method_4("error", "Không lấy được otp");
					break;
				}
			}
			goto IL_076f;
			IL_05da:
			if (CD003D3F("#iNext") && D997803F("#iNext"))
			{
				method_16("#iNext");
			}
			else
			{
				string text9 = method_9();
				if (text9.StartsWith("https://privacynotice.account.microsoft.com/notice"))
				{
					method_16("button");
				}
				else
				{
					string text10 = C12B8625();
					if (!text9.StartsWith("https://account.microsoft.com/auth/complete-client-signin-oauth-silent?state=") && !text9.StartsWith("https://account.live.com/error.aspx?errcode=") && !text9.Contains("chrome-error://chromewebdata/") && !text10.Contains("Ref A:") && !text10.Contains("Service Unavailable"))
					{
						if (CD003D3F(".refreshPageButton"))
						{
							BEA5E4BB("refreshPage();");
						}
						else
						{
							if (num4 >= num5)
							{
								break;
							}
							num4++;
						}
					}
					else
					{
						num4++;
						if (num4 >= 5)
						{
							num4 = 0;
							method_10(string_14);
						}
					}
				}
			}
			goto IL_076f;
			IL_09be:
			gClass.method_4("error", "Không kê\u0301t nô\u0301i đươ\u0323c mail kp");
			break;
			IL_09ab:
			gClass.method_4("error", "Getnada block ip, vui lo\u0300ng đô\u0309i ip kha\u0301c");
			break;
			IL_0919:
			gClass.method_4("error", "Getnada block ip, vui lo\u0300ng đô\u0309i ip kha\u0301c");
			break;
			IL_076f:
			if (!method_1())
			{
				if (Environment.TickCount - tickCount < num2 * 1000)
				{
					method_40(1.0);
					continue;
				}
				gClass.method_4("error", "timeout");
				break;
			}
			gClass.method_4("error", "chrome_closed");
			break;
			IL_092f:
			gClass.method_4("error", "Không kê\u0301t nô\u0301i đươ\u0323c mail kp");
			break;
			IL_04e2:
			text2 = text3;
			method_29(text4);
			method_20(text4, text3);
			method_40(1.0);
			method_16("#idSubmit_SAOTCC_Continue");
			goto IL_076f;
			IL_073c:
			text2 = text3;
			method_29(text4);
			method_20(text4, text3);
			method_40(1.0);
			method_16("#iNext,[name=\"otc-confirmation\"] button[type=\"submit\"],[name=\"OneTimeCodeViewForm\"] button[type=\"submit\"],#idSubmit_SAOTCC_Continue");
			goto IL_076f;
		}
		if (flag)
		{
			gClass.method_4("success", true);
		}
		if (!gClass.method_3("success") && gClass.C0288288("error") == "")
		{
			gClass.method_4("error", "Đổi pass thất bại");
		}
		gClass.method_4("mailRecover", string_13);
		gClass.method_4("passMailRecover", BC83DD86);
		return gClass.method_7();
	}

	public string method_90()
	{
		return E9B89BB8("UnlockProfile");
	}

	public bool method_91(bool CC871F94)
	{
		string string_ = $"[{{\"name\":\"isEnable\", \"value\":\"{CC871F94}\", \"type\":\"bool\"}}]";
		string json = E9B89BB8("ProfessionalMode", string_);
		JObject jObject = JObject.Parse(json);
		return Convert.ToBoolean(jObject["success"]);
	}

	public void CB10A9B2(string A8A1BB11, string string_12, string E9A5C3A1)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>
		{
			{ "1", "January" },
			{ "2", "February" },
			{ "3", "March" },
			{ "4", "April" },
			{ "5", "May" },
			{ "6", "June" },
			{ "7", "July" },
			{ "8", "August" },
			{ "9", "September" },
			{ "10", "October" },
			{ "11", "November" },
			{ "12", "December" }
		};
		A8A1BB11 = A8A1BB11.Trim();
		string_12 = dictionary[string_12.Trim()];
		E9A5C3A1 = E9A5C3A1.Trim();
		method_10("https://accountscenter.facebook.com/personal_info/birthday/?entrypoint=edit_basic_info&locale=en_US");
		method_40(2.0);
		int tickCount = Environment.TickCount;
		int num = 60;
		while (!method_1() && !BBA51B98() && Environment.TickCount - tickCount < num * 1000)
		{
			string text = method_13(0.0, new List<string> { "//*[@role=\"dialog\"]//*[text()=\"Your birthday was updated\"]", "//*[@role=\"dialog\"][.//*[text()=\"Birthday\"]]//*[@role=\"button\"][.//*[text()=\"Edit\"]]" });
			string text2 = text;
			string text3 = text2;
			if (!(text3 == "//*[@role=\"dialog\"]//*[text()=\"Your birthday was updated\"]"))
			{
				if (text3 == "//*[@role=\"dialog\"][.//*[text()=\"Birthday\"]]//*[@role=\"button\"][.//*[text()=\"Edit\"]]")
				{
					if (CD003D3F("//*[@role=\"combobox\"][.//*[text()=\"Month\"]]"))
					{
						if (CD003D3F("//*[@role=\"dialog\"]//*[@role=\"button\"][.//*[text()=\"Confirm\"]]"))
						{
							method_16("//*[@role=\"dialog\"]//*[@role=\"button\"][.//*[text()=\"Confirm\"]]");
							method_40(2.0);
							method_31("//*[@role=\"dialog\"]//*[@role=\"button\"][.//*[text()=\"Confirm\"]]", 60);
							break;
						}
						method_16("//*[@role=\"combobox\"][.//*[text()=\"Month\"]]");
						method_40(2.0);
						method_17("//*[@aria-label=\"Select Month\" and @role=\"listbox\"]//*[@role=\"option\"][.//*[text()=\"" + string_12 + "\"]]");
						method_40(1.0);
						method_16("//*[@role=\"combobox\"][.//*[text()=\"Day\"]]");
						method_40(2.0);
						method_17("//*[@aria-label=\"Select Day\" and @role=\"listbox\"]//*[@role=\"option\"][.//*[text()=\"" + A8A1BB11 + "\"]]");
						method_40(1.0);
						method_16("//*[@role=\"combobox\"][.//*[text()=\"Year\"]]");
						method_40(2.0);
						method_17("//*[@aria-label=\"Select Year\" and @role=\"listbox\"]//*[@role=\"option\"][.//*[text()=\"" + E9A5C3A1 + "\"]]");
						method_40(1.0);
						method_17("//*[@role=\"button\"][.//*[text()=\"Save\"]]");
						method_40(2.0);
					}
					else
					{
						if (CD003D3F("//*[@role=\"dialog\"]//*[contains(text(),\"limit to how many times you can change your birthday\")]"))
						{
							break;
						}
						method_16(text);
					}
				}
			}
			else
			{
				method_16("//*[@role=\"dialog\"][.//*[text()=\"Your birthday was updated\"]]//*[@aria-label=\"Close\"]");
			}
			method_40(2.0);
		}
	}

	public void AF053F26(string D0233BA6)
	{
		method_10("https://accountscenter.facebook.com/profiles/" + method_37() + "/username/?entrypoint=fb_account_center&locale=en_US");
		method_40(2.0);
		int tickCount = Environment.TickCount;
		int num = 60;
		while (!method_1() && !BBA51B98() && Environment.TickCount - tickCount < num * 1000)
		{
			string text = method_13(0.0, new List<string> { "//input[./following-sibling::*[text()=\"Username\"]]" });
			string text2 = text;
			string text3 = text2;
			if (text3 == "//input[./following-sibling::*[text()=\"Username\"]]")
			{
				if (CD003D3F("//*[contains(text(),\"currently unable to choose a username\")]"))
				{
					break;
				}
				if (method_5(text) == D0233BA6)
				{
					if (!CD003D3F("//*[@role=\"button\" and @aria-disabled=\"true\"]//*[text()=\"Done\"]"))
					{
						method_60();
						method_17("//*[@role=\"button\"]//*[text()=\"Done\"]");
						method_40(2.0);
						BB1DB70A(60);
						break;
					}
				}
				else
				{
					AC9778A4(text);
					method_20(text, D0233BA6);
				}
			}
			method_40(2.0);
		}
	}

	public string method_92()
	{
		return E9B89BB8("XoaThietBiTinCay");
	}

	public string A3962EA2()
	{
		return E9B89BB8("AllowFollow");
	}

	public string C2B3E9A1(string AEAAEA21, string A685602E)
	{
		string string_ = "[{\"name\":\"password\", \"value\":\"" + AEAAEA21 + "\", \"type\":\"text\"},{\"name\":\"email\", \"value\":\"" + A685602E + "\", \"type\":\"text\"}]";
		return E9B89BB8("RemoveEmailMfb", string_);
	}

	public string method_93(string D710BC9F, int int_6)
	{
		string string_ = $"[{{\"name\":\"password\", \"value\":\"{D710BC9F}\", \"type\":\"text\"}},{{\"name\":\"typeWeb\", \"value\":\"{int_6}\", \"type\":\"number\"}}]";
		return E9B89BB8("RemovePhone", string_);
	}

	public bool method_94()
	{
		if (DA0E8786)
		{
			return true;
		}
		if (method_9().Contains("1501092823525282"))
		{
			return false;
		}
		bool result;
		if (result = E9B89BB8("CheckFbBlock") == "true")
		{
			DA0E8786 = true;
		}
		return result;
	}

	internal string method_95(string FA9DB5B0)
	{
		if (!GClass8.smethod_44(FA9DB5B0))
		{
			FA9DB5B0 = GClass8.smethod_90("https://facebook.com/" + FA9DB5B0);
		}
		if (GClass8.smethod_44(FA9DB5B0))
		{
			string string_ = "[{\"name\":\"id\", \"value\":\"" + FA9DB5B0 + "\", \"type\":\"text\"},{\"name\":\"fa2\", \"value\":\"" + CCBE39A8 + "\", \"type\":\"text\"}]";
			return E9B89BB8("CrawlPostWWW", string_);
		}
		string string_2 = "[{\"name\":\"id\", \"value\":\"" + FA9DB5B0 + "\", \"type\":\"text\"},{\"name\":\"fa2\", \"value\":\"" + CCBE39A8 + "\", \"type\":\"text\"}]";
		return E9B89BB8("CrawlPost", string_2);
	}

	internal bool D91F52AE(int int_6, GClass11 gclass11_0, int int_7 = -1)
	{
		string text = gclass11_0.C0288288("reaction");
		bool flag = gclass11_0.method_3("postAds");
		string string_ = "[{\"name\":\"reaction\", \"value\":\"" + text + "\", \"type\":\"text\"}" + $",{{\"name\":\"indexPost\", \"value\":\"{int_7}\", \"type\":\"number\"}}" + $",{{\"name\":\"postAds\", \"value\":\"{flag}\", \"type\":\"bool\"}}]";
		string string_2 = "";
		switch (int_6)
		{
		case 1:
			string_2 = "ReactionWWW";
			break;
		case 2:
			string_2 = "ReactionMfb";
			break;
		case 3:
			string_2 = "ReactionMbasic";
			break;
		}
		string json = E9B89BB8(string_2, string_);
		JObject jObject = JObject.Parse(json);
		bool result;
		if (!(result = Convert.ToBoolean(jObject["success"])))
		{
			DA0E8786 = jObject["error"]!.ToString() == "fb_blocked";
		}
		return result;
	}

	internal bool method_96(string string_12)
	{
		string_12 = string_12.Replace("\r\n", "\n").Replace("\n", "\\\\n").Replace("\"", "\\\"");
		string string_13 = "[{\"name\":\"content\", \"value\":\"" + string_12 + "\", \"type\":\"text\"}]";
		string json = E9B89BB8("DanhGiaPageWWW", string_13);
		JObject jObject = JObject.Parse(json);
		bool result;
		if (!(result = Convert.ToBoolean(jObject["success"])))
		{
			DA0E8786 = jObject["error"]!.ToString() == "fb_blocked";
		}
		return result;
	}

	internal string F4083699(bool DC95C60D, List<string> list_0)
	{
		string string_ = $"[{{\"name\":\"isAnswer\", \"value\":\"{DC95C60D}\", \"type\":\"bool\"}}" + ",{\"name\":\"answer\", \"value\":\"" + string.Join("\\\\n", list_0).Replace("\"", "\\\"") + "\", \"type\":\"text\"}]";
		int num = AFABF4B7();
		string json = "";
		switch (num)
		{
		case 1:
			json = E9B89BB8("JoinGroupWWW", string_);
			break;
		case 3:
			json = E9B89BB8("JoinGroupMbasic", string_);
			break;
		}
		JObject jObject = JObject.Parse(json);
		if (!Convert.ToBoolean(jObject["success"]))
		{
			DA0E8786 = jObject["error"]!.ToString() == "fb_blocked";
			return jObject["error"]!.ToString();
		}
		return "success";
	}

	internal string method_97(int CB3CD388, int int_6, int ED10D13E, int int_7, bool bool_9, List<string> list_0)
	{
		string string_ = $"[{{\"name\":\"nudSoLuongFrom\", \"value\":\"{CB3CD388}\", \"type\":\"number\"}}" + $",{{\"name\":\"nudSoLuongTo\", \"value\":\"{int_6}\", \"type\":\"number\"}}" + $",{{\"name\":\"nudDelayFrom\", \"value\":\"{ED10D13E}\", \"type\":\"number\"}}" + $",{{\"name\":\"nudDelayTo\", \"value\":\"{int_7}\", \"type\":\"number\"}}" + $",{{\"name\":\"ckbTuDongTraLoiCauHoi\", \"value\":\"{bool_9}\", \"type\":\"bool\"}}" + ",{\"name\":\"lstCauTraLoi\", \"value\":\"" + string.Join("\\\\n", list_0).Replace("\"", "\\\"") + "\", \"type\":\"text\"}]";
		string json = E9B89BB8("JoinGroupDeXuatWWW", string_);
		JObject jObject = JObject.Parse(json);
		if (!Convert.ToBoolean(jObject["success"]))
		{
			DA0E8786 = jObject["error"]!.ToString() == "fb_blocked";
			return jObject["error"]!.ToString();
		}
		return "success";
	}

	internal bool method_98(string string_12)
	{
		string string_13 = "[{\"name\":\"name\", \"value\":\"" + string_12 + "\", \"type\":\"text\"}]";
		string json = E9B89BB8("Rename", string_13);
		JObject jObject = JObject.Parse(json);
		return Convert.ToBoolean(jObject["success"]);
	}

	internal bool method_99(string DB8C7328, string string_12)
	{
		bool result = false;
		string_12 = GClass8.smethod_29(string_12);
		while (true)
		{
			if (String_5 == "")
			{
				String_5 = method_82();
				if (String_5 == "")
				{
					break;
				}
			}
			string string_13 = "https://graph.beta.facebook.com/" + DB8C7328 + "/comments?access_token=" + String_5 + "&method=post&message=" + GClass8.FBA19A19(string_12);
			method_10(string_13);
			string text = C12B8625();
			if (!text.Contains("\"id\""))
			{
				if (new Class54("", "", "", "", 0, "").method_2(text))
				{
					String_5 = "";
					continue;
				}
				if (new Class54("", "", "", "", 0, "").method_4(text))
				{
					DA0E8786 = true;
				}
				break;
			}
			result = true;
			break;
		}
		return result;
	}

	internal bool method_100(string string_12, string string_13)
	{
		bool result = false;
		string_13 = GClass8.smethod_29(string_13);
		while (true)
		{
			if (String_5 == "")
			{
				String_5 = method_82();
				if (String_5 == "")
				{
					break;
				}
			}
			string string_14 = "https://graph.facebook.com/me/feed?link=" + GClass8.FBA19A19(string_12.StartsWith("https:") ? string_12 : ("https://facebook.com/" + string_12)) + "&access_token=" + String_5 + "&method=post&privacy={'value':'EVERYONE'}&message=" + GClass8.FBA19A19(string_13);
			method_10(string_14);
			string text = C12B8625();
			if (!text.Contains("\"id\""))
			{
				if (new Class54("", "", "", "", 0, "").method_2(text))
				{
					String_5 = "";
					continue;
				}
				if (new Class54("", "", "", "", 0, "").method_4(text))
				{
					DA0E8786 = true;
				}
				break;
			}
			result = true;
			break;
		}
		return result;
	}

	internal bool method_101(int int_6, GClass11 gclass11_0, int int_7 = -1)
	{
		string text = gclass11_0.C0288288("content").Replace("\r\n", "\n").Replace("\n", "\\\\n")
			.Replace("\"", "\\\"");
		string text2 = gclass11_0.C0288288("image").Replace("\\", "\\\\\\\\");
		bool flag = gclass11_0.method_3("ckbDeleteComment");
		int num = gclass11_0.method_2("nudDelayDeleteFrom");
		int num2 = gclass11_0.method_2("nudDelayDeleteTo");
		bool flag2 = gclass11_0.method_3("ckbEditComment");
		int num3 = gclass11_0.method_2("nudDelayEditFrom");
		int num4 = gclass11_0.method_2("nudDelayEditTo");
		string text3 = gclass11_0.C0288288("contentEdit").Replace("\r\n", "\n").Replace("\n", "\\\\n")
			.Replace("\"", "\\\"");
		bool flag3 = gclass11_0.method_3("postAds");
		string string_ = "[{\"name\":\"content\", \"value\":\"" + text + "\", \"type\":\"text\"},{\"name\":\"image\", \"value\":\"" + text2 + "\", \"type\":\"text\"}" + $",{{\"name\":\"ckbDeleteComment\", \"value\":\"{flag}\", \"type\":\"bool\"}}" + $",{{\"name\":\"nudDelayDeleteFrom\", \"value\":\"{num}\", \"type\":\"number\"}}" + $",{{\"name\":\"nudDelayDeleteTo\", \"value\":\"{num2}\", \"type\":\"number\"}}" + $",{{\"name\":\"ckbEditComment\", \"value\":\"{flag2}\", \"type\":\"bool\"}}" + $",{{\"name\":\"nudDelayEditFrom\", \"value\":\"{num3}\", \"type\":\"number\"}}" + $",{{\"name\":\"nudDelayEditTo\", \"value\":\"{num4}\", \"type\":\"number\"}}" + ",{\"name\":\"contentEdit\", \"value\":\"" + text3 + "\", \"type\":\"text\"}" + $",{{\"name\":\"indexPost\", \"value\":\"{int_7}\", \"type\":\"number\"}}" + $",{{\"name\":\"postAds\", \"value\":\"{flag3}\", \"type\":\"bool\"}}]";
		string string_2 = "";
		switch (int_6)
		{
		case 1:
			string_2 = "CommentWWW";
			break;
		case 2:
			string_2 = "CommentMfb";
			break;
		case 3:
			string_2 = "CommentMbasic";
			break;
		}
		string json = E9B89BB8(string_2, string_);
		JObject jObject = JObject.Parse(json);
		bool result;
		if ((result = Convert.ToBoolean(jObject["success"])) && jObject["commentId"]!.ToString() != "" && !flag)
		{
			lock (Class57.object_0)
			{
				File.AppendAllText("output\\comment_" + DateTime.Now.ToString("dd_MM_yyyy") + ".txt", String_2 + "|https://fb.com/" + jObject["commentId"]?.ToString() + Environment.NewLine);
				return result;
			}
		}
		DA0E8786 = jObject["error"]!.ToString() == "fb_blocked";
		return result;
	}

	internal bool C4827F98(int int_6, GClass11 gclass11_0, int EC26B1A8 = -1)
	{
		bool flag = gclass11_0.method_3("postAds");
		string text = gclass11_0.C0288288("content").Replace("\r\n", "\n").Replace("\n", "\\\\n")
			.Replace("\"", "\\\"");
		string string_ = "[{\"name\":\"content\", \"value\":\"" + text + "\", \"type\":\"text\"}" + $",{{\"name\":\"indexPost\", \"value\":\"{EC26B1A8}\", \"type\":\"number\"}}" + $",{{\"name\":\"postAds\", \"value\":\"{flag}\", \"type\":\"bool\"}}]";
		string string_2 = "";
		switch (int_6)
		{
		case 1:
			string_2 = "ShareWallWWW";
			break;
		case 2:
			string_2 = "ShareWallMfb";
			break;
		case 3:
			string_2 = "ShareWallMbasic";
			break;
		}
		string json = E9B89BB8(string_2, string_);
		JObject jObject = JObject.Parse(json);
		bool result;
		if (!(result = Convert.ToBoolean(jObject["success"])))
		{
			DA0E8786 = jObject["error"]!.ToString() == "fb_blocked";
		}
		return result;
	}

	internal bool method_102(int B4BEDF17, GClass11 gclass11_0, int int_6 = -1)
	{
		int num = gclass11_0.method_2("soLuongFrom");
		int num2 = gclass11_0.method_2("soLuongTo");
		int num3 = gclass11_0.method_2("delayFrom");
		int num4 = gclass11_0.method_2("delayTo");
		string text = gclass11_0.C0288288("content").Replace("\r\n", "\n").Replace("\n", "\\\\n")
			.Replace("\"", "\\\"");
		string string_ = "[{\"name\":\"content\", \"value\":\"" + text + "\", \"type\":\"text\"}" + $",{{\"name\":\"soLuongFrom\", \"value\":\"{num}\", \"type\":\"number\"}}" + $",{{\"name\":\"soLuongTo\", \"value\":\"{num2}\", \"type\":\"number\"}}" + $",{{\"name\":\"delayFrom\", \"value\":\"{num3}\", \"type\":\"number\"}}" + $",{{\"name\":\"delayTo\", \"value\":\"{num4}\", \"type\":\"number\"}}" + $",{{\"name\":\"indexPost\", \"value\":\"{int_6}\", \"type\":\"number\"}}]";
		string string_2 = "";
		switch (B4BEDF17)
		{
		case 1:
			string_2 = "ShareMessWWW";
			break;
		case 2:
			string_2 = "ShareMessMfb";
			break;
		case 3:
			string_2 = "ShareMessMbasic";
			break;
		}
		string json = E9B89BB8(string_2, string_);
		JObject jObject = JObject.Parse(json);
		bool result;
		if (!(result = Convert.ToBoolean(jObject["success"])))
		{
			DA0E8786 = jObject["error"]!.ToString() == "fb_blocked";
		}
		return result;
	}

	internal bool D3B04B12(int int_6, string string_12, string string_13, bool bool_9 = false, List<string> CA14C535 = null)
	{
		string_13 = string_13.Replace("\r\n", "\n").Replace("\n", "\\\\n").Replace("\"", "\\\"");
		string text = "";
		if (CA14C535 != null)
		{
			text = string.Join("|", CA14C535);
			text = text.Replace("\\", "\\\\\\\\");
		}
		string string_14 = "[{\"name\":\"content\", \"value\":\"" + string_13 + "\", \"type\":\"text\"},{\"name\":\"image\", \"value\":\"" + text + "\", \"type\":\"text\"}" + $",{{\"name\":\"isUseBackground\", \"value\":\"{bool_9}\", \"type\":\"bool\"}}" + ",{\"name\":\"link\", \"value\":\"" + string_12 + "\", \"type\":\"text\"}" + $",{{\"name\":\"typeObject\", \"value\":\"{int_6}\", \"type\":\"number\"}}]";
		string json = E9B89BB8("DangBaiWWW", string_14);
		JObject jObject = JObject.Parse(json);
		bool result;
		if (!(result = Convert.ToBoolean(jObject["success"])))
		{
			DA0E8786 = jObject["error"]!.ToString() == "fb_blocked";
			if (DA0E8786)
			{
			}
		}
		return result;
	}

	internal bool method_103(string C71F79BA, List<string> list_0 = null)
	{
		C71F79BA = C71F79BA.Replace("\r\n", "\n").Replace("\n", "\\\\n").Replace("\"", "\\\"");
		string text = "";
		if (list_0 != null)
		{
			text = string.Join("|", list_0);
			text = text.Replace("\\", "\\\\\\\\");
		}
		string string_ = "[{\"name\":\"content\", \"value\":\"" + C71F79BA + "\", \"type\":\"text\"},{\"name\":\"image\", \"value\":\"" + text + "\", \"type\":\"text\"}]";
		string json = E9B89BB8("DangBaiMbasic", string_);
		JObject jObject = JObject.Parse(json);
		bool result;
		if (!(result = Convert.ToBoolean(jObject["success"])))
		{
			DA0E8786 = jObject["error"]!.ToString() == "fb_blocked";
		}
		return result;
	}

	internal bool method_104(string string_12, string string_13)
	{
		string_12 = string_12.Replace("\r\n", "\n").Replace("\n", "\\\\n").Replace("\"", "\\\"");
		string_13 = string_13.Replace("\\", "\\\\\\\\");
		string string_14 = "[{\"name\":\"content\", \"value\":\"" + string_12 + "\", \"type\":\"text\"},{\"name\":\"image\", \"value\":\"" + string_13 + "\", \"type\":\"text\"}" + $",{{\"name\":\"timeout\", \"value\":\"{60}\", \"type\":\"bool\"}}]";
		int num = AFABF4B7();
		string json = "";
		switch (num)
		{
		case 1:
			json = E9B89BB8("UpAvatarWWW", string_14);
			break;
		case 3:
			json = E9B89BB8("UpAvatarMbasic", string_14);
			break;
		}
		JObject jObject = JObject.Parse(json);
		bool result;
		if (!(result = Convert.ToBoolean(jObject["success"])))
		{
			DA0E8786 = jObject["error"]!.ToString() == "fb_blocked";
		}
		return result;
	}

	internal bool B49112B0(string AF90C988, string string_12)
	{
		AF90C988 = AF90C988.Replace("\r\n", "\n").Replace("\n", "\\\\n").Replace("\"", "\\\"");
		string_12 = string_12.Replace("\\", "\\\\\\\\");
		string string_13 = "[{\"name\":\"image\", \"value\":\"" + string_12 + "\", \"type\":\"text\"}]";
		int num = AFABF4B7();
		string json = "";
		switch (num)
		{
		case 1:
			json = E9B89BB8("UpCoverWWW", string_13);
			break;
		case 3:
			json = E9B89BB8("UpCoverMbasic", string_13);
			break;
		}
		JObject jObject = JObject.Parse(json);
		bool result;
		if (!(result = Convert.ToBoolean(jObject["success"])))
		{
			DA0E8786 = jObject["error"]!.ToString() == "fb_blocked";
		}
		return result;
	}

	internal bool method_105()
	{
		string json = E9B89BB8("RoiNhomWWW");
		JObject jObject = JObject.Parse(json);
		bool result;
		if (!(result = Convert.ToBoolean(jObject["success"])))
		{
			DA0E8786 = jObject["error"]!.ToString() == "fb_blocked";
		}
		return result;
	}

	internal bool method_106()
	{
		string json = E9B89BB8("HuyKetBanWWW");
		JObject jObject = JObject.Parse(json);
		bool result;
		if (!(result = Convert.ToBoolean(jObject["success"])))
		{
			DA0E8786 = jObject["error"]!.ToString() == "fb_blocked";
		}
		return result;
	}

	internal bool method_107(string CA307C3C)
	{
		CA307C3C = CA307C3C.Replace("\r\n", "\n").Replace("\n", "\\\\n").Replace("\"", "\\\"");
		string string_ = "[{\"name\":\"content\", \"value\":\"" + CA307C3C + "\", \"type\":\"text\"}" + $",{{\"name\":\"timeout\", \"value\":\"{60}\", \"type\":\"bool\"}}]";
		string json = E9B89BB8("AddFrameAvatarWWW", string_);
		JObject jObject = JObject.Parse(json);
		bool result;
		if (!(result = Convert.ToBoolean(jObject["success"])))
		{
			DA0E8786 = jObject["error"]!.ToString() == "fb_blocked";
		}
		return result;
	}

	internal bool B8323F85(GClass11 A4843C86)
	{
		int num = A4843C86.method_2("nudSoLuongBaiFrom");
		int num2 = A4843C86.method_2("nudSoLuongBaiTo");
		int num3 = A4843C86.method_2("nudDelayFrom");
		int num4 = A4843C86.method_2("nudDelayTo");
		bool flag = A4843C86.method_3("ckbOnlyDeleteTagPost");
		string string_ = $"[{{\"name\":\"nudSoLuongFrom\", \"value\":\"{num}\", \"type\":\"number\"}}" + $",{{\"name\":\"nudSoLuongTo\", \"value\":\"{num2}\", \"type\":\"number\"}}" + $",{{\"name\":\"nudDelayFrom\", \"value\":\"{num3}\", \"type\":\"number\"}}" + $",{{\"name\":\"nudDelayTo\", \"value\":\"{num4}\", \"type\":\"number\"}}" + $",{{\"name\":\"ckbOnlyDeleteTagPost\", \"value\":\"{flag}\", \"type\":\"bool\"}}]";
		string json = E9B89BB8("DeletePost", string_);
		JObject jObject = JObject.Parse(json);
		return Convert.ToBoolean(jObject["success"]);
	}

	internal bool method_108(GClass11 gclass11_0)
	{
		int num = gclass11_0.method_2("nudSoLuongFrom");
		int num2 = gclass11_0.method_2("nudSoLuongTo");
		int num3 = gclass11_0.method_2("nudDelayFrom");
		int num4 = gclass11_0.method_2("nudDelayTo");
		string string_ = $"[{{\"name\":\"soLuongFrom\", \"value\":\"{num}\", \"type\":\"number\"}}" + $",{{\"name\":\"soLuongTo\", \"value\":\"{num2}\", \"type\":\"number\"}}" + $",{{\"name\":\"delayFrom\", \"value\":\"{num3}\", \"type\":\"number\"}}" + $",{{\"name\":\"delayTo\", \"value\":\"{num4}\", \"type\":\"number\"}}]";
		string json = E9B89BB8("PokeFriendWWW", string_);
		JObject jObject = JObject.Parse(json);
		return Convert.ToBoolean(jObject["success"]);
	}

	internal bool method_109()
	{
		method_10("https://www.facebook.com");
		string text = method_13(10.0, new List<string> { "[aria-label=\"Lựa chọn khác\"]", "[aria-label=\"Tùy chọn khác\"]", "i[style*=\"XF71Ye-dfez.png\"]", "i[style*=\"Puy01JAc-41.png\"]", "i[style*=\"3aeionTfVlK.png\"]" });
		if (text == "")
		{
			return false;
		}
		method_40(1.0);
		method_16(text);
		if (method_13(10.0, new List<string> { "//span[text()=\"Check my account\"]", "//i[contains(@style,\"nwrCcydySV3.png\") or contains(@style,\"xs4o8GcFCU6.png\")]" }) == "")
		{
			return false;
		}
		E9B89BB8("Switch282To956");
		return true;
	}

	internal List<string> method_110(string B53C62BE, int int_6)
	{
		List<string> list = new List<string>();
		if (!method_9().StartsWith("https://mbasic.facebook.com/"))
		{
			method_10("https://mbasic.facebook.com/");
		}
		string text = "https://mbasic.facebook.com/" + B53C62BE;
		if (B53C62BE.Contains("https://"))
		{
			text = B53C62BE.Replace(Regex.Match(B53C62BE, "https://.*?facebook").Value, "https://mbasic.facebook");
			B53C62BE = "";
		}
		do
		{
			string input = D129B30F(text);
			MatchCollection matchCollection = Regex.Matches(input, "top_level_post_id&quot;:&quot;(.*?)&quot;");
			if (matchCollection.Count == 0)
			{
				matchCollection = Regex.Matches(input, "/story\\.php\\?story_fbid=(.*?)&");
			}
			foreach (Match item2 in matchCollection)
			{
				string item = B53C62BE + "_" + item2.Groups[1].Value;
				if (!list.Contains(item))
				{
					list.Add(item);
					if (int_6 <= list.Count)
					{
						return list;
					}
				}
			}
			if (list.Count == 0 && !text.Contains("timeline"))
			{
				text = "https://mbasic.facebook.com/" + B53C62BE + "?v=timeline";
				continue;
			}
			text = Regex.Match(input, "href=\"(/groups/\\d+\\?bacr.*?)\"").Groups[1].Value;
			if (text == "")
			{
				text = Regex.Match(input, "href=\"(/profile/timeline/stream/\\?cursor=.*?)\"").Groups[1].Value;
			}
			if (text == "" && B53C62BE == "")
			{
				text = Regex.Match(input, "href=\"(/watch/\\?cursor=.*?)\"").Groups[1].Value;
			}
			if (text != "")
			{
				text = "https://mbasic.facebook.com" + text.Replace("&amp;", "&");
			}
		}
		while (text != "" && int_6 > list.Count);
		return list;
	}

	internal List<string> method_111(string string_12)
	{
		string text = method_62("GetNewPostIdFromGroup('" + string_12 + "')");
		return text.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
	}

	public string method_112(string string_12, ref string B8BAC595, ref string string_13, ref string string_14)
	{
		if (string_10 != "")
		{
			return string_10;
		}
		string_10 = GClass21.CE9B89B6(string_12, B8BAC595);
		if (string_10 != "")
		{
			return string_10;
		}
		if (method_1() || BBA51B98())
		{
			(bool success, string error) tuple = method_0();
			var (flag, _) = tuple;
			_ = tuple.error;
			if (!flag)
			{
				return "fail";
			}
		}
		string json = F7060B1F(string_12, B8BAC595, string_13, string_14);
		JObject jObject = JObject.Parse(json);
		if (!Convert.ToBoolean(jObject["success"]))
		{
			return "fail";
		}
		if (jObject["mailRecover"]!.ToString() != "" && jObject["mailRecover"]!.ToString() != string_13)
		{
			string_13 = jObject["mailRecover"]!.ToString();
			string_14 = jObject["passMailRecover"]!.ToString();
		}
		if (B8BAC595 != jObject["passmail"]!.ToString())
		{
			B8BAC595 = jObject["passmail"]!.ToString();
		}
		string_10 = method_36("live.com");
		return string_10;
	}

	internal void method_113(int E9966D2D, string string_12, string string_13, int int_6, int int_7)
	{
		string_13 = string_13.Replace("\r\n", "\n").Replace("\n", "\\\\n").Replace("\"", "\\\"");
		string string_14 = $"[{{\"name\":\"soLuong\", \"value\":\"{E9966D2D}\", \"type\":\"number\"}}" + ",{\"name\":\"reaction\", \"value\":\"" + string_12 + "\", \"type\":\"text\"},{\"name\":\"content\", \"value\":\"" + string_13 + "\", \"type\":\"text\"}" + $",{{\"name\":\"delayFrom\", \"value\":\"{int_6}\", \"type\":\"number\"}}" + $",{{\"name\":\"delayTo\", \"value\":\"{int_7}\", \"type\":\"number\"}}]";
		E9B89BB8("XemStoryWWW", string_14);
	}

	internal void method_114(int int_6, string FDBAD288, string string_12, int FE9B6E95, int int_7)
	{
		string_12 = string_12.Replace("\r\n", "\n").Replace("\n", "\\\\n").Replace("\"", "\\\"");
		string string_13 = $"[{{\"name\":\"soLuong\", \"value\":\"{int_6}\", \"type\":\"number\"}}" + ",{\"name\":\"reaction\", \"value\":\"" + FDBAD288 + "\", \"type\":\"text\"},{\"name\":\"content\", \"value\":\"" + string_12 + "\", \"type\":\"text\"}" + $",{{\"name\":\"delayFrom\", \"value\":\"{FE9B6E95}\", \"type\":\"number\"}}" + $",{{\"name\":\"delayTo\", \"value\":\"{int_7}\", \"type\":\"number\"}}]";
		E9B89BB8("XemStoryMfb", string_13);
	}

	internal void BD94043F(string string_12, string string_13 = "")
	{
		string_13 = string_13.Replace("\r\n", "\n").Replace("\n", "\\\\n").Replace("\"", "\\\"");
		string_12 = string_12.Replace("\\", "\\\\\\\\");
		string string_14 = "[{\"name\":\"image\", \"value\":\"" + string_12 + "\", \"type\":\"text\"},{\"name\":\"content\", \"value\":\"" + string_13 + "\", \"type\":\"text\"}]";
		E9B89BB8("DangStoryWWW", string_14);
	}

	internal bool method_115(string string_12, string EE9A25A1, string string_13, string AE03202C)
	{
		GClass11 gClass = new GClass11();
		gClass.method_4("success", false);
		gClass.method_4("error", "");
		gClass.method_4("commentId", "");
		string text = "[href^=\"/reactions/picker/?ft_id=" + string_12 + "\"]";
		string text2 = "[href^=\"/comment/replies/?ctoken=\"][href*=\"" + string_12 + "\"]";
		string text3 = "[href^=\"/mbasic/comment/advanced/\"][href*=\"at=edit\"]";
		string string_14 = "[name=\"comment_text\"]";
		string string_15 = "input[name=\"view_photo\"]";
		string string_16 = "[data-sigil=\"m-raw-file-input\"],[type=\"file\"]";
		if (EE9A25A1 != "" && CD003D3F(text))
		{
			method_17(text);
			method_40(2.0);
			if (GClass8.smethod_44(EE9A25A1))
			{
				EE9A25A1 = "Like|Love|Care|Haha|Wow|Sad|Angry".Split('|')[Convert.ToInt32(EE9A25A1)];
			}
			else if (EE9A25A1.Contains("|"))
			{
				EE9A25A1 = EE9A25A1.Split('|').ToList().smethod_6();
			}
			string text4 = EE9A25A1.ToLower();
			string text5 = text4;
			switch (C43AF739.smethod_0(text5))
			{
			case 2267502540u:
				if (text5 == "care")
				{
					EE9A25A1 = "16";
				}
				break;
			case 585688324u:
				if (text5 == "wow")
				{
					EE9A25A1 = "3";
				}
				break;
			case 199741238u:
				if (text5 == "like")
				{
					EE9A25A1 = "1";
				}
				break;
			case 3576140497u:
				if (text5 == "love")
				{
					EE9A25A1 = "2";
				}
				break;
			case 3037376254u:
				if (text5 == "angry")
				{
					EE9A25A1 = "8";
				}
				break;
			case 4256463021u:
				if (text5 == "haha")
				{
					EE9A25A1 = "4";
				}
				break;
			case 3860638727u:
				if (text5 == "sad")
				{
					EE9A25A1 = "7";
				}
				break;
			}
			string text6 = "[href^=\"/ufi/reaction/?ft_ent_identifier=" + string_12 + "&reaction_type=" + EE9A25A1 + "&\"]";
			if (CD003D3F(text6) && method_16(text6))
			{
				gClass.method_4("success", true);
				method_40(2.0);
			}
			else
			{
				method_12();
			}
		}
		if ((string_13 != "" || AE03202C != "") && CD003D3F(text2))
		{
			method_17(text2);
			method_40(2.0);
			int num = E22B0917(text3);
			List<string> list = new List<string>();
			for (int i = 0; i < num; i++)
			{
				string item = method_117(method_4(text3 + "|" + i, "href"), "ctoken=(.*?)&");
				list.Add(item);
			}
			if (AE03202C != "")
			{
				method_17(string_15);
				method_40(1.0);
				method_23(string_16, AE03202C);
				method_40(2.0);
			}
			if (string_13 != "")
			{
				method_20(string_14, string_13 + " ");
				method_40(2.0);
			}
			string string_17 = method_13(0.0, new List<string> { "form [name=\"post\"]", "form [type=\"submit\"]" });
			method_17(string_17);
			int num2 = 60;
			int tickCount = Environment.TickCount;
			while (true)
			{
				if (!method_1() && !BBA51B98())
				{
					if (E22B0917(text3) > 0)
					{
						num = E22B0917(text3);
						for (int j = 0; j < num; j++)
						{
							string text7 = method_117(method_4(text3 + "|" + j, "href"), "ctoken=(.*?)&");
							if (!list.Contains(text7))
							{
								gClass.method_4("commentId", text7);
								gClass.method_4("success", true);
								break;
							}
						}
						if (gClass.method_3("success"))
						{
							break;
						}
					}
					if (!method_94())
					{
						if (Environment.TickCount - tickCount >= num2 * 1000)
						{
							break;
						}
						method_40(1.0);
						continue;
					}
					gClass.method_4("error", "fb_blocked");
					break;
				}
				gClass.method_4("error", "chrome_closed");
				break;
			}
		}
		bool result;
		if (!(result = Convert.ToBoolean(gClass.method_3("success"))))
		{
			DA0E8786 = gClass.C0288288("error") == "fb_blocked";
		}
		return result;
	}

	internal bool method_116(string F926F109, string B227A425, string string_12, string string_13)
	{
		if (F926F109.StartsWith("https://"))
		{
			F926F109 = Regex.Match(F926F109, "comment_id=(\\d+)").Groups[1].Value;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("success", false);
		gClass.method_4("error", "");
		gClass.method_4("commentId", "");
		bool flag = ((string_12 != "") ? true : false);
		bool flag2 = ((string_13 != "") ? true : false);
		if (CD003D3F("[aria-label=\"See all\"]"))
		{
			method_17("[aria-label=\"See all\"]");
			method_40(2.0);
		}
		string text = method_13(0.0, new List<string>
		{
			"//*[contains(@aria-label, \"Comment by\") or contains(@aria-label, \"Comment as\")][.//*[contains(@href,\"comment_id=" + F926F109 + "\")]]",
			"//*[(contains(@aria-label, \"Comment by\") or contains(@aria-label, \"Comment as\")) and parent::*//*[contains(@aria-label,\"Reply to\") or contains(@aria-label,\"Reply as\") or contains(@aria-label,\"Write a\")]]"
		});
		if (text == "")
		{
			gClass.method_4("error", "not_found_post");
		}
		else
		{
			string text2 = text + "//*[(@aria-label=\"React\" or (contains(@aria-label,\"Change \") and contains(@aria-label,\" reaction\")))]";
			string text3 = text + "//*[text()=\"Reply\"]";
			string text4 = text + "//parent::*//parent::*";
			string string_14 = text4 + "//*[contains(@aria-label,\"Reply to\") or contains(@aria-label,\"Reply as\") or contains(@aria-label,\"Write a\")]";
			string text5 = "(" + text4 + "//input[@type=\"file\"])[last()]";
			string string_15 = text4 + "//*[@aria-label=\"Comment\"]";
			string text6 = text4 + "//*[@aria-label=\"Edit or delete this\"]";
			if (B227A425 != "" && CD003D3F(text2))
			{
				method_18(text2, 2);
				method_19(text2);
				method_40(2.0);
				if (GClass8.smethod_44(B227A425))
				{
					B227A425 = "Like|Love|Care|Haha|Wow|Sad|Angry".Split('|')[Convert.ToInt32(B227A425)];
				}
				else if (B227A425.Contains("|"))
				{
					B227A425 = B227A425.Split('|').ToList().smethod_6();
				}
				string text7 = "(//*[@aria-label=\"Reactions\"]//*[contains(@aria-label,\"" + B227A425 + "\")])[last()]";
				if (CD003D3F(text7, 5.0) && method_17(text7))
				{
					gClass.method_4("success", true);
					method_40(2.0);
				}
			}
			if ((flag || flag2) && CD003D3F(text3))
			{
				int num = E22B0917(text6);
				List<string> list = new List<string>();
				for (int i = 1; i < num + 1; i++)
				{
					string item = method_117(B7A4071C("(" + text6 + "//ancestor::*[contains(@aria-label,\"Reply by\")])[" + i + "]"), "reply_comment_id=(\\d+)&");
					list.Add(item);
				}
				method_17(text3);
				method_40(2.0);
				if (flag)
				{
					method_18(string_14);
					method_22(string_14, string_12 + " ", bool_9: true);
					method_40(2.0);
				}
				if (flag2 && CD003D3F(text5))
				{
					method_23(text5, string_13);
					method_13(60.0, new List<string>
					{
						text4 + "//img[contains(@class,\"scaledImageFit\")]",
						text4 + "//*[@aria-live=\"polite\"]"
					});
					method_40(2.0);
				}
				method_17(string_15);
				int num2 = 60;
				int tickCount = Environment.TickCount;
				while (true)
				{
					if (!method_1() && !BBA51B98())
					{
						if (E22B0917(text6) <= num)
						{
							if (!method_94())
							{
								if (Environment.TickCount - tickCount >= num2 * 1000)
								{
									break;
								}
								method_40(1.0);
								continue;
							}
							gClass.method_4("error", "fb_blocked");
							break;
						}
						num = E22B0917(text6);
						for (int j = 1; j < num + 1; j++)
						{
							string text8 = method_117(B7A4071C("(" + text6 + "//ancestor::*[contains(@aria-label,\"Reply by\")])[" + j + "]"), "reply_comment_id=(\\d+)&");
							if (!list.Contains(text8))
							{
								gClass.method_4("commentId", text8);
								break;
							}
						}
						gClass.method_4("success", true);
						break;
					}
					gClass.method_4("error", "chrome_closed");
					break;
				}
			}
		}
		bool result;
		if (!(result = Convert.ToBoolean(gClass.method_3("success"))))
		{
			DA0E8786 = gClass.C0288288("error") == "fb_blocked";
		}
		return result;
	}

	private string method_117(string C1393BA8, string string_12)
	{
		return Regex.Match(C1393BA8, string_12).Groups[1].Value;
	}

	internal bool method_118(int AA308C2E, int AA3A6C1A, List<string> list_0)
	{
		string string_ = "[{\"name\":\"id\", \"value\":\"\", \"type\":\"text\"}" + $",{{\"name\":\"count\", \"value\":\"{AA308C2E}\", \"type\":\"number\"}}" + $",{{\"name\":\"typeInvite\", \"value\":\"{AA3A6C1A}\", \"type\":\"number\"}}" + ",{\"name\":\"arrNames\", \"value\":\"" + string.Join("|", list_0) + "\", \"type\":\"text\"}]";
		string json = E9B89BB8("MoiBanBeVaoNhomWWW", string_);
		JObject jObject = JObject.Parse(json);
		bool result;
		if (!(result = Convert.ToBoolean(jObject["success"])))
		{
			DA0E8786 = jObject["error"]!.ToString() == "fb_blocked";
		}
		return result;
	}

	internal bool EB044200(string string_12, string string_13)
	{
		string_12 = string_12.Replace("\r\n", "\n").Replace("\n", "\\\\n").Replace("\"", "\\\"");
		string_13 = string_13.Replace("\\", "\\\\\\\\");
		string string_14 = "[{\"name\":\"image\", \"value\":\"" + string_13 + "\", \"type\":\"text\"},{\"name\":\"content\", \"value\":\"" + string_12 + "\", \"type\":\"text\"}]";
		string json = E9B89BB8("NhanTinUidWWW", string_14);
		JObject jObject = JObject.Parse(json);
		bool result;
		if (!(result = Convert.ToBoolean(jObject["success"])))
		{
			DA0E8786 = jObject["error"]!.ToString() == "fb_blocked";
		}
		return result;
	}

	internal bool E9A78003(string string_12, string string_13)
	{
		string_12 = string_12.Replace("\r\n", "\n").Replace("\n", "\\\\n").Replace("\"", "\\\"");
		string_13 = string_13.Replace("\\", "\\\\\\\\");
		string string_14 = "[{\"name\":\"image\", \"value\":\"" + string_13 + "\", \"type\":\"text\"},{\"name\":\"content\", \"value\":\"" + string_12 + "\", \"type\":\"text\"}]";
		string json = E9B89BB8("NhanTinUidMfb", string_14);
		JObject jObject = JObject.Parse(json);
		bool result;
		if (!(result = Convert.ToBoolean(jObject["success"])))
		{
			DA0E8786 = jObject["error"]!.ToString() == "fb_blocked";
		}
		return result;
	}

	public bool method_119()
	{
		if (CD003D3F("[data-sigil$=\"m-overlay-layer\"] form button") && CD003D3F("[style=\"display: none;\"]>[data-sigil$=\"m-overlay-layer\"] form button"))
		{
			return false;
		}
		return BB963890(0, "[action*=\"facebook.com/a/friends/profile/add\"] [type=\"submit\"]", "[data-sigil$=\"m-overlay-layer\"] [value=\"OK\"]", "[data-sigil$=\"m-overlay-layer\"] form button", "[data-sigil$=\"m-error-overlay-done\"]", "[data-sigil$=\"m-overlay-layer\"]", "[data-sigil$=\"m-error-overlay-cancel\"]", "[role=\"dialog\"] [aria-label^=\"Add \"]", "div[aria-label=\"OK\" i][role=\"button\"]");
	}

	public List<string> method_120(bool bool_9 = false)
	{
		string propertyName = method_37();
		List<string> list = new List<string>();
		try
		{
			string text = B8B3CA97();
			if (!method_9().Contains("https://www.facebook.com/api/graphql"))
			{
				method_10("https://www.facebook.com/api/graphql");
			}
			string json = BEA5E4BB("async function RequestPost() { var output = ''; try { var response = await fetch('https://www.facebook.com/api/graphql', { method: 'POST', body: 'q=me(){friends}&fb_dtsg=" + text + "', headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestPost(); return c;");
			JObject jObject = JObject.Parse(json);
			int num = jObject[propertyName]!["friends"]!["nodes"].Count();
			for (int i = 0; i < num; i++)
			{
				if (bool_9)
				{
					try
					{
						string text2 = jObject[propertyName]!["friends"]!["nodes"]![i]!["name"]!.ToString();
						if (GClass8.smethod_68(text2))
						{
							list.Add(jObject[propertyName]!["friends"]!["nodes"]![i]!["name"]!.ToString());
						}
					}
					catch
					{
					}
				}
				else
				{
					list.Add(jObject[propertyName]!["friends"]!["nodes"]![i]!["name"]!.ToString());
				}
			}
		}
		catch
		{
		}
		return list;
	}

	internal void method_121()
	{
		if (CD003D3F("input[role=\"switch\"]"))
		{
			BEA5E4BB("document.querySelectorAll('input[role=\"switch\"]').forEach(elm => {if (elm.checked!==true) {elm.click();}})");
		}
		method_17("(//div[@role=\"button\"])[last()]");
	}

	internal void method_122(string BBB6C93E)
	{
		method_10("https://www.facebook.com/profile.php?locale=en_US");
		method_40(2.0);
		method_58();
		int tickCount = Environment.TickCount;
		int num = 300;
		while (!BBA51B98() && Environment.TickCount - tickCount <= num * 1000 && !method_1())
		{
			string text = method_13(0.0, new List<string> { "[aria-label=\"Edit bio\" i]", "[aria-label=\"Add bio\" i]", "textarea[aria-label]" });
			switch (text)
			{
			case "[aria-label=\"Edit bio\" i]":
			case "[aria-label=\"Add bio\" i]":
				method_17(text);
				break;
			case "textarea[aria-label]":
				AC9778A4(text);
				method_20(text, BBB6C93E);
				method_40(2.0);
				method_17("[aria-label=\"Save\" i]");
				method_40(2.0);
				method_31("[aria-label=\"Save\" i]", 60);
				return;
			}
			method_40(2.0);
		}
	}

	internal bool CE97BD33()
	{
		if (String_8.Split(':').Length > 1)
		{
			method_10("https://ifconfig.co/ip");
			method_40(1.0);
			string text = method_6("body").Trim();
			if (text.Split('.').Length != 4 && text.Split(':').Length != 8)
			{
				return false;
			}
		}
		return true;
	}

	internal void method_123(bool DB2A5F10)
	{
		int int_ = 0;
		method_124(DB2A5F10, ref int_);
	}

	internal void method_124(bool bool_9, ref int int_6)
	{
		try
		{
			if (!method_1() && !BBA51B98())
			{
				method_58();
				DFA46D3A();
				if (method_125())
				{
					GEnum3_0 = GEnum3.const_2;
				}
				else if (method_127())
				{
					GEnum3_0 = GEnum3.E02E9820;
				}
				else
				{
					if ((AFABF4B7() != 1 && CD003D3F("[href=\"/\"]")) || method_94())
					{
						return;
					}
					if (AFABF4B7() == 2 && CD003D3F("[href^=\"/a/preferences.php?fast_switch_site\"]"))
					{
						BB963890(0, "[href^=\"/a/preferences.php?fast_switch_site\"]");
					}
					if (method_9().StartsWith("https://free.facebook.com/") || CD003D3F("[href^=\"/upsell/advanced_upsell/in_line\"]"))
					{
						BB963890(0, "[href^=\"/upsell/advanced_upsell/in_line\"]");
						BB963890(5, "#upsell_upgrade_confirm_button");
						int_6 = 1;
					}
					string text = method_9();
					if (text.Contains("facebook.com/error/index.php"))
					{
						method_10("https://www.facebook.com/notifications");
						method_40(2.0);
						if (method_16("[role=\"complementary\"] [role=\"toolbar\"] [aria-pressed]|1"))
						{
							method_40(2.0);
						}
						if (method_16("[role=\"complementary\"] [role=\"grid\"] [role=\"row\"] a|0"))
						{
							method_40(2.0);
						}
						method_10(text);
						method_40(2.0);
					}
					if (CD003D3F("[href^=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]"))
					{
						method_19("[href^=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]");
						BB963890(5, "[action^=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button");
						int_6 = 1;
					}
					if (CD003D3F("#nux-nav-button,[href^=\"/a/nux/wizard/nav.php\"]"))
					{
						method_15("#nux-nav-button,[href^=\"/a/nux/wizard/nav.php\"]");
						if (CD003D3F("#qf_skip_dialog_skip_link", 5.0))
						{
							method_15("#qf_skip_dialog_skip_link");
						}
						int_6 = 1;
					}
					if (CD003D3F("[href^=\"/a/nux/wizard/nav.php?step=search&skip\"]"))
					{
						method_15("[href^=\"/a/nux/wizard/nav.php?step=search&skip\"]");
						int_6 = 1;
					}
					if (method_125())
					{
						GEnum3_0 = GEnum3.const_2;
						return;
					}
					if (method_128())
					{
						GEnum3_0 = GEnum3.C520DC29;
						return;
					}
					string text2 = "";
					if (bool_9)
					{
						text = D789C71C() + "/login";
						text2 = D129B30F(text);
					}
					if (text2 == "")
					{
						text2 = C12B8625();
					}
					if (text2 == "-2")
					{
						GEnum3_0 = GEnum3.DC10881C;
					}
					else if (!Regex.IsMatch(text2, "login_form") && !text2.Contains("/login/?next"))
					{
						if (!Regex.IsMatch(text2, "login_profile_form") && !Regex.IsMatch(text2, "/login/device-based/validate-p") && !Regex.IsMatch(text2, "aria-label=\"Log in\"") && !Convert.ToBoolean(BEA5E4BB("var kq=false;if(document.querySelector('#mErrorView')!=null && !document.querySelector('#mErrorView').getAttribute('style').includes('display:none')) kq=true;return kq+''")) && !Regex.IsMatch(text2, "href=\"https://m.facebook.com/login.php") && !Regex.IsMatch(text2, "href=\"https://mobile.facebook.com/login.php"))
						{
							if (method_126())
							{
								GEnum3_0 = GEnum3.const_7;
							}
							else if (method_127())
							{
								GEnum3_0 = GEnum3.E02E9820;
							}
							else if (text2.Contains("error-information-popup-content") || text2.Contains("suggestionsSummaryList"))
							{
								GEnum3_0 = GEnum3.const_5;
							}
						}
						else
						{
							GEnum3_0 = GEnum3.const_2;
						}
					}
					else
					{
						if (CD003D3F("[href*=\"/login/?next\"]"))
						{
							method_16("[href*=\"/login/?next\"]");
						}
						GEnum3_0 = GEnum3.const_2;
					}
					return;
				}
			}
			else
			{
				GEnum3_0 = GEnum3.DC10881C;
			}
		}
		catch
		{
		}
	}

	private bool method_125()
	{
		return method_62("CheckFbLogout()").ToLower() == "true";
	}

	public bool method_126(string BEB57BBA = "")
	{
		if (BEB57BBA == "")
		{
			BEB57BBA = method_9();
		}
		List<string> f39BD5AF = new List<string> { "facebook.com/confirmemail", "facebook.com/confirmation", "facebook.com/conf/strongrec/?contact=" };
		if (GClass8.smethod_92(BEB57BBA, f39BD5AF))
		{
			return true;
		}
		List<string> list_ = new List<string> { "[name=\"c\"]" };
		if (method_13(0.0, list_) != "")
		{
			return true;
		}
		return false;
	}

	public bool method_127()
	{
		string text = method_9();
		List<string> f39BD5AF = new List<string> { "facebook.com/checkpoint/828281030927956", "facebook.com/checkpoint/1501092823525282", "facebook.com/checkpoint/465803052217681", "facebook.com/checkpoint/588324129567771", "facebook.com/x/checkpoint/", "facebook.com/checkpoint/block" };
		if (GClass8.smethod_92(text, f39BD5AF))
		{
			return true;
		}
		if (text.Contains("facebook.com/nt/screen/?params=") && text.Contains("checkpoint"))
		{
			return true;
		}
		string text2 = C12B8625();
		List<string> f39BD5AF2 = new List<string> { "verification_method", "send_code", "/checkpoint/dyi", "facebook.com/communitystandards/", "help/121104481304395", "help/166863010078512", "help/117450615006715", "checkpoint/1501092823525282", "checkpoint/828281030927956", "name=\"code_1\"" };
		if (GClass8.smethod_92(text2, f39BD5AF2))
		{
			return true;
		}
		List<string> list_ = new List<string> { "[name=\"verification_method\"]", "[name=\"submit[Yes]\"]", "[name=\"send_code\"]", "[href*=\"facebook.com/communitystandards/\"]", "[name=\"code_1\"]", "[action=\"/login/checkpoint/\"] [name=\"contact_index\"]" };
		if (method_13(0.0, list_) != "")
		{
			return true;
		}
		return false;
	}

	public bool method_128()
	{
		try
		{
			if (AFABF4B7() == 2 && CD003D3F("[href^=\"/a/preferences.php?fast_switch_site\"]"))
			{
				BB963890(0, "[href^=\"/a/preferences.php?fast_switch_site\"]");
			}
			if (method_127())
			{
				return false;
			}
			if (method_13(0.0, new List<string> { "[action^=\"/login/\"]", "[name=\"email\"]", "[name=\"pass\"]" }) != "")
			{
				return false;
			}
			string text = method_9();
			List<string> f39BD5AF = new List<string> { "facebook.com/home.php" };
			if (GClass8.smethod_92(text, f39BD5AF))
			{
				return true;
			}
			string text2 = C12B8625();
			List<string> f39BD5AF2 = new List<string> { "/friends/", "/logout.php?button_location=settings&amp;button_name=logout", "\"is_checkpointed\":false" };
			if (GClass8.smethod_92(text2, f39BD5AF2))
			{
				return true;
			}
			List<string> list_ = new List<string> { "a[href*=\"/friends/\"]", "[action=\"/logout.php?button_location=settings&button_name=logout\"]" };
			if (method_13(0.0, list_) != "")
			{
				return true;
			}
			if (CD003D3F("[name=\"email\"]") && CD003D3F("[name=\"pass\"]"))
			{
				return false;
			}
			return method_46();
		}
		catch (Exception)
		{
		}
		return false;
	}

	public int E433E10F(bool bool_9 = false)
	{
		int int_ = 0;
		method_124(bool_9, ref int_);
		if (int_ == 0)
		{
			switch (GEnum3_0)
			{
			case GEnum3.DC10881C:
				int_ = -2;
				break;
			case GEnum3.const_2:
			{
				string dB3A262D = "https://www.facebook.com/";
				if (GClass25.smethod_0("configInteractGeneral").method_2("typeBrowserLogin") == 0)
				{
					dB3A262D = "https://m.facebook.com/";
				}
				else if (GClass25.smethod_0("configInteractGeneral").method_2("typeBrowserLogin") == 2)
				{
					dB3A262D = "https://mbasic.facebook.com";
				}
				string text = method_129(-1, dB3A262D);
				if (text == "1")
				{
					GEnum3_0 = GEnum3.BAA111A3;
					int_ = 1;
				}
				else
				{
					int_ = 2;
				}
				break;
			}
			case GEnum3.E02E9820:
				int_ = -1;
				break;
			case GEnum3.const_5:
				int_ = -3;
				break;
			}
		}
		return int_;
	}

	public string method_129(int C19E479C = -1, string DB3A262D = "https://mobile.facebook.com")
	{
		bool flag = GClass25.smethod_0("configInteractGeneral").method_2("typeBrowserLogin") == 3;
		string e599E = E599E997;
		if (C19E479C == -1)
		{
			C19E479C = GClass25.smethod_0("configInteractGeneral").method_2("typeLogin");
		}
		if (!A218C3AD)
		{
			string result = "";
			switch (C19E479C)
			{
			case 0:
				if (!(E599E997.Trim() == "") && !(string_3.Trim() == ""))
				{
					e599E = E599E997;
					break;
				}
				if (E599E997.Trim() == "")
				{
					result = F7AB102E.smethod_0("Không ti\u0300m thâ\u0301y UID!");
				}
				else if (string_3.Trim() == "")
				{
					result = F7AB102E.smethod_0("Không ti\u0300m thâ\u0301y Pass!");
				}
				return result;
			case 1:
				if (!(string_6.Trim() == "") && !(string_3.Trim() == ""))
				{
					e599E = string_6;
					break;
				}
				if (string_6.Trim() == "")
				{
					result = F7AB102E.smethod_0("Không ti\u0300m thâ\u0301y Email!");
				}
				else if (string_3.Trim() == "")
				{
					result = F7AB102E.smethod_0("Không ti\u0300m thâ\u0301y Pass!");
				}
				return result;
			case 2:
			case 3:
				if (string_5.Trim() == "")
				{
					return F7AB102E.smethod_0("Không ti\u0300m thâ\u0301y Cookie!");
				}
				method_10(DB3A262D);
				method_34(string_5);
				method_11();
				return method_131().ToString();
			}
		}
		bool flag2 = GClass25.smethod_0("configInteractGeneral").method_3("ckbDontSaveBrowser");
		string text = method_9();
		if (!text.Contains("1501092823525282") && !text.Contains("828281030927956") && (!text.Contains("facebook.com/nt/screen/?params=") || !text.Contains("checkpoint")))
		{
			bool flag3 = false;
			int tickCount = Environment.TickCount;
			int num = 120;
			try
			{
				if (AFABF4B7() != AFABF4B7(DB3A262D))
				{
					method_10(DB3A262D);
				}
				while (true)
				{
					IL_1f7f:
					if (!CD003D3F("[name='email']") || !CD003D3F("[name='pass']") || !CD003D3F("[name='login'],#loginbutton,div[role=\"button\"]:not([aria-label])") || CD003D3F("[data-cookiebanner=\"accept_button\"]"))
					{
						if (method_9().Contains("facebook.com/user_cookie_prompt"))
						{
							method_10("https://mobile.facebook.com/");
						}
						if (CD003D3F("[name=\"accept_only_essential\"][value=\"0\"]"))
						{
							method_16("[name=\"accept_only_essential\"][value=\"0\"]");
						}
						BEA5E4BB("document.querySelector('[name=\"primary_consent_button\"]').click()");
						BEA5E4BB("document.querySelector('[data-cookiebanner=\"accept_button\"]').click()");
						BEA5E4BB("document.querySelectorAll('[data-testid=\"cookie-policy-manage-dialog-accept-button\"]')[1].click()");
						if (!CD003D3F("[name=\"pass\"]"))
						{
							method_10(DB3A262D + "/login");
							BEA5E4BB("document.querySelector('[data-cookiebanner=\"accept_button\"]').click()");
							BEA5E4BB("document.querySelectorAll('[data-testid=\"cookie-policy-manage-dialog-accept-button\"]')[1].click()");
						}
					}
					if (AFABF4B7() == 1)
					{
						if (method_14(0, new string[2] { "[data-userid] [name=\"login\"]", "[data-userid]" }) && CD003D3F("[role=\"dialog\"] [name=\"pass\"]", 5.0))
						{
							method_40(1.0);
							AF93AB8B("[role=\"dialog\"] [name=\"pass\"]", string_3, 0.1);
							method_40(1.0);
							method_19("[role=\"dialog\"] [name=\"login\"]");
						}
					}
					else if (!CD003D3F("[name='email']") || !CD003D3F("[name='pass']") || !CD003D3F("[name='login']"))
					{
						if (method_14(0, new string[2] { "[data-sigil=\"login_profile_form\"] div[role=\"button\"]", "[action*=\"/login/device-based/\"] [type=\"submit\"]" }))
						{
							if (method_13(5.0, new List<string> { "[name=\"pass\"]", "#approvals_code" }) == "[name=\"pass\"]")
							{
								method_40(1.0);
								AF93AB8B("[name=\"pass\"]", string_3, 0.1);
								method_40(1.0);
								method_24("[name=\"pass\"]");
							}
						}
						else if (AFABF4B7() > 1 && CD003D3F("#nux-nav-button,[href^=\"/a/nux/wizard/nav.php\"]", 4.0))
						{
							method_16("#nux-nav-button,[href^=\"/a/nux/wizard/nav.php\"]");
						}
					}
					if (CD003D3F("[name='email']") && CD003D3F("[name='pass']") && CD003D3F("[name='login'],#loginbutton,div[role=\"button\"]:not([aria-label])"))
					{
						flag3 = true;
						string text2 = method_9();
						method_29("[name='email']");
						AF93AB8B("[name='email']", e599E, 0.1);
						method_40(1.0);
						method_29("[name='pass']");
						AF93AB8B("[name='pass']", string_3, 0.1);
						method_40(1.0);
						method_16("[name='login'],#loginbutton,div[role=\"button\"]:not([aria-label])");
						method_40(2.0);
						for (int i = 0; i < 10; i++)
						{
							if (method_9() != text2)
							{
								break;
							}
							if (method_5("[name=\"pass\"]") == "")
							{
								break;
							}
							method_40(2.0);
						}
					}
					int num2 = 0;
					int num3 = 5;
					int num4 = 0;
					int num5 = 2;
					int num6 = 0;
					int num7 = 2;
					int num8 = 0;
					while (!method_1() && !BBA51B98() && Environment.TickCount - tickCount < num * 1000)
					{
                        string text3 = method_13(0.0, new List<string>
{
    "[name=\"login\"],[name=\"email\"],[name=\"pass\"]", "#loginbutton", "[name=\"approvals_code\"]", "[name=\"verification_method\"]", "#checkpointSubmitButton", "#qf_skip_dialog_skip_link", "#nux-nav-button,[href^=\"/a/nux/wizard/nav.php\"]", "[name=\"n\"]", "[name=\"reset_action\"]", "#checkpointBottomBar",
    "[name=\"primary_consent_button\"]", "#identify_search_text_input", "[action*=\"/login/device-based/update-nonce/\"]", "[href^=\"/a/nux/wizard/nav.php\"]", "[data-testid=\"yes_continue_button\"]", "[action^=\"/login/account_recovery/name_search/\"]", "[action^=\"/ajax/recover/initiate/?recover_method=send_email&selected_cuid\"]", "[src*=\"facebook.com/captcha/tfbimage\"]"
});

                        string text5 = text3;

						if (text5 == "[action*=\"/login/device-based/update-nonce/\"]")
						{
							method_16("[action*=\"/login/device-based/update-nonce/\"] [type=\"submit\"]");
						}
						else if (text5 == "[action^=\"/ajax/recover/initiate/?recover_method=send_email&selected_cuid\"]")
						{
							return "5";
						}
						else if (text5 == "[src*=\"facebook.com/captcha/tfbimage\"]")
						{
							if (!method_9().Contains("facebook.com/checkpoint/1501092823525282/") && !method_9().Contains("checkpoint/828281030927956"))
							{
								string string_ = "input[type^=\"text\"]";
								if (method_5(string_) != "")
								{
									method_11();
								}
								else
								{
									int num11 = GClass25.smethod_0("configCheckpoint").method_2("typeCaptcha");
									string text7 = GClass25.smethod_0("configCheckpoint").C0288288("txtCaptcha_" + num11);

									if (text7 == "" && !GClass24.smethod_2(GClass25.smethod_0("configCheckpoint").C0288288("txtCaptcha_4")))
									{
										return "captcha";
									}

									string value = Regex.Match(C12B8625(), "src=\"(https://(?:[a-z]+)\\.facebook\\.com/captcha/tfbimage.*?)\"").Groups[1].Value;
									if (value != "")
									{
										string text8 = GClass8.smethod_94(method_36(), value);
										if (text8 == "")
										{
											method_11();
										}
										else
										{
											string text9 = DABBB41F.D390252C(num11, text7, text8);
											if (text9 == "")
											{
												method_11();
											}
											else
											{
												method_20(string_, text9);
												method_40(1.0);
												method_14(0, new string[] { "[role=\"button\"]>[role=\"none\"]", "[role=\"button\"]>[style*=\"justify-content\"]" });
												method_40(3.0);
												method_31("[aria-label$=\"...\"]", 30);
											}
										}
									}
								}
							}
							return "2";
						}
						else if (text5 == "#checkpointSubmitButton")
						{
							if (CD003D3F("[name=\"checkpointU2Fauth\"]"))
							{
								method_10("https://www.facebook.com/checkpoint/?next&no_fido=true");
							}
							else
							{
								if (method_13(0.0, new List<string> { "#SupportFormRow\\.382907505152522", "[href=\"/help/117450615006715\"]" }) != "")
								{
									num2++;
									if (num2 < num3)
									{
										if (CD003D3F("[value=\"dont_save\"]") && flag2)
										{
											method_16("[value=\"dont_save\"]");
										}

										string text6 = "";
										if (CD003D3F("[name=\"password_new\"]"))
										{
											text6 = GClass8.smethod_81();
											method_20("[name=\"password_new\"]", text6);
											method_40(1.0);
											method_20("[name=\"password_confirm\"]", text6);
											method_40(1.0);
										}

										if (CD003D3F("[name=\"submit[Confirm identity another way]\"]"))
										{
											method_16("[name=\"submit[Confirm identity another way]\"]");
										}
										else if (CD003D3F("#checkpointSubmitButton>input"))
										{
											method_19("#checkpointSubmitButton>input");
										}
										else if (CD003D3F("button[name=\"submit[Done]\"]"))
										{
											method_19("button[name=\"submit[Done]\"]");
										}
										else if (CD003D3F("button[name=\"submit[Delete]\"]"))
										{
											method_19("button[name=\"submit[Delete]\"]");
										}
										else if (CD003D3F("#checkpointSubmitButton>button"))
										{
											if (CD003D3F("[action=\"/login/checkpoint/\"]") && CD003D3F("[name=\"send_code\"]"))
											{
												method_19("#checkpointSubmitButton>button");
												method_40(2.0);
												method_31("#checkpointSubmitButton>button [role=\"progressbar\"]", 30);
											}
										}
										else
										{
											if (CD003D3F("button[name=\"submit[This was me]\"]"))
											{
												num2--;
												num4++;
												if (num4 <= num5)
												{
													method_16("button[name=\"submit[This was me]\"]");
												}
												else
												{
													method_16("button[name=\"submit[This wasn't me]\"]");
												}
											}
											else
											{
												method_19("#checkpointSubmitButton");
											}

											method_40(2.0);
											method_31("#checkpointSubmitButton[disabled]", 30);
										}

										method_40(1.0);
										if (!method_9().Contains("facebook.com/secured_action/block/") && text6 != "")
										{
											fMain.fMain_0.method_143(this.string_2, "pass", B89B8128, "cPassword", text6);
											String_3 = text6;
										}
									}
								}
							}
						}
						else if (text5 == "[name=\"n\"]")
						{
							return "5";
						}
						else if (text5 == "#checkpointBottomBar")
						{
							if (num6 <= 1)
							{
								if (method_13(0.0, new List<string> { "[name=\"verification_method\"]", "[name=\"submit[Yes]\"]", "[name=\"send_code\"]", "#captcha_response", "[href=\"https://www.facebook.com/communitystandards/\"]" }) != "")
								{
									text3 = method_13(0.0, new List<string> { "button#checkpointSubmitButton", "#checkpointSubmitButton [type=\"submit\"]" });
									if (num8 < 10)
									{
										if (CD003D3F("[value=\"dont_save\"]") && flag2)
										{
											method_16("[value=\"dont_save\"]");
										}
										num8++;
										if (text3 == "button#checkpointSubmitButton")
										{
											method_16(text3);
										}
										else
										{
											method_14(0, new string[] { "#checkpointSubmitButton [type=\"submit\"]", "[name=\"submit[Get Started]\"]", "#checkpointBottomBar [name=\"submit[Continue]\"]" });
											method_40(2.0);
											method_31("#hcs_prog_o>#hcs_prog_i[style]", 60);
										}
										method_40(1.0);
									}
								}
							}
							else if (text5 == "[name=\"login\"],[name=\"email\"],[name=\"pass\"]")
							{
								if (CD003D3F(text5))
								{
									string inputValue = method_5(text5);
									if (!string.IsNullOrEmpty(inputValue))
									{
										method_20(text5, inputValue);
										method_16("#loginbutton");
									}
								}
							}
						}








                            goto IL_162c;
						IL_162c:
						text = method_9();
						if (text.Contains("?rcs="))
						{
							if (CD003D3F("[aria-label=\"Remove profiles from this browser\"]") && CD003D3F("[aria-label=\"Continue\"]") && CD003D3F("[aria-label=\"Use another profile\"]"))
							{
								method_16("[aria-label=\"Continue\"]");
								continue;
							}
							text += "&locale=en_US";
							method_10(text);
							continue;
						}
						if (!text.Contains("facebook.com/secured_action/block/"))
						{
							if (!text.Contains("checkpoint/disabled"))
							{
								if (text.Contains("facebook.com/checkpoint/465803052217681"))
								{
									if (AFABF4B7() == 1)
									{
										method_52();
										bool flag4 = method_130();
										method_53();
										if (flag4)
										{
											continue;
										}
										return "2";
									}
									return "2";
								}
								if (text.Contains("facebook.com/checkpoint/588324129567771"))
								{
									if (AFABF4B7() == 1)
									{
										method_52();
										bool flag5 = EB3968B5();
										method_53();
										if (flag5)
										{
											continue;
										}
										return "2";
									}
									return "2";
								}
								if (text.Contains("facebook.com/two_step_verification/two_factor/"))
								{
									string text12 = "input[type=\"text\"]";
									if (CD003D3F(text12))
									{
										if (string_4 == "")
										{
											return "3";
										}
										if (num6 >= num7)
										{
											return "6";
										}
										string text13 = GClass8.smethod_66(string_4.Replace(" ", "").Replace("\n", "").Trim());
										if (text13 == "")
										{
											return "6";
										}
										num6++;
										method_28(text12);
										method_20(text12, text13);
										method_40(1.0);
										method_24(text12);
										method_40(3.0);
										method_31("svg[aria-label$=\"...\"]", 30);
									}
									else if (CD003D3F("[role=\"dialog\"]"))
									{
										method_17("input[type=\"radio\"][aria-checked=\"false\"]");
										method_40(1.0);
										method_17("[role=\"dialog\"] [role=\"button\"]|" + (E22B0917("[role=\"dialog\"] [role=\"button\"]") - 1));
									}
									else
									{
										method_17("[role=\"button\"]");
									}
									continue;
								}
								if (text.Contains("facebook.com/auth_platform/"))
								{
									if (AFABF4B7() == 1)
									{
										method_52();
										bool flag6 = A5385682();
										method_53();
										if (flag6)
										{
											continue;
										}
										return "2";
									}
									return "2";
								}
								if (text.Contains("facebook.com/two_factor/remember_browser/"))
								{
									if (CD003D3F("[role=\"dialog\"] [aria-label]"))
									{
										method_16("[role=\"dialog\"] [role=\"button\"]");
										method_40(2.0);
									}
									else
									{
										BEA5E4BB("HTMLInputElement.prototype.click = function() { if(this.type !== 'file') HTMLElement.prototype.click.call(this); };");
										method_17("div[role=\"button\"]|" + (E22B0917("div[role=\"button\"]") - 2));
									}
									continue;
								}
								if (!text.Contains("facebook.com/checkpoint/1501092823525282/") && !text.Contains("checkpoint/828281030927956"))
								{
									if (text.Contains("facebook.com/user_cookie_prompt"))
									{
										method_10("https://mobile.facebook.com/");
										continue;
									}
									if (text.Contains("facebook.com/two_step_verification/authentication/") && AFABF4B7(text) == 2)
									{
										string text14 = "input[data-bloks-name=\"bk.components.TextInput\"]";
										if (CD003D3F(text14))
										{
											if (string_4 == "")
											{
												return "3";
											}
											if (num6 >= num7)
											{
												return "6";
											}
											string text15 = GClass8.smethod_66(string_4.Replace(" ", "").Replace("\n", "").Trim());
											if (text15 == "")
											{
												return "6";
											}
											num6++;
											method_28(text14);
											method_20(text14, text15);
											method_40(1.0);
											method_16("[role=\"button\"]>[style*=\"justify-content\"]");
											method_40(3.0);
											method_31("[aria-label$=\"...\"]", 30);
										}
										else
										{
											method_10("https://m.facebook.com/");
											flag3 = false;
										}
										continue;
									}
									if (!method_126(text))
									{
										if (!text.Contains("facebook.com/nt/screen/?params=%7B%22token") && !(method_13(0.0, new List<string> { "[name=\"verification_method\"]", "[name=\"submit[Yes]\"]", "[name=\"send_code\"]", "#captcha_response", "[href=\"https://www.facebook.com/communitystandards/\"]" }) != "") && !GClass8.smethod_92(C12B8625(), new List<string> { "/checkpoint/dyi", "https://www.facebook.com/communitystandards/", "help/121104481304395" }))
										{
											if (!(method_13(0.0, new List<string> { "[href=\"/help/103873106370583\"]", "[href=\"/help/121104481304395\"]" }) != ""))
											{
												if (!method_94())
												{
													if (AFABF4B7(text) == 1 && text.Contains(".facebook.com/privacy/consent/"))
													{
														method_121();
													}
													else
													{
														if (DFA46D3A())
														{
															continue;
														}
														string text16 = BEA5E4BB("async function checkCookie(){try{let a=await fetch(\"https://www.facebook.com/me\"),b=\"0|0\";if(a.ok){if(a.url.includes(\"checkpoint\"))b=\"0|1\";else if(a.url.includes(\"com/?refsrc\")||\"https://www.facebook.com/\"==a.url)b=\"0|2\";else{let d=await a.text();if(d.includes(\"/photos/change/profile_picture\"))b=\"1|1\";else{let e=d.match(/\"USER_ID\"\\:\"([0-9]{0,})\"/)[1],f=document.cookie.match(/c_user\\=([0-9]{0,})/)[1];e==f&&(b=\"1|1\")}}}return b}catch{}}var c=await checkCookie(); return c") ?? "";
														if (text16.ToString().StartsWith("0|"))
														{
															return "2";
														}
														if (CD003D3F("[href=\"/\"]") && text.Contains("facebook.com/privacy/consent_framework/prompt/"))
														{
															method_10("https://www.facebook.com/");
															continue;
														}
														if (method_128())
														{
															return "1";
														}
														if (AFABF4B7(text) == 2)
														{
															if (text.StartsWith("https://mobile.facebook.com/zero/policy/optin"))
															{
																method_40(1.0);
																BEA5E4BB("document.querySelector('a[data-sigil=\"touchable\"]').click()");
																method_40(3.0);
																if (CD003D3F("button[data-sigil=\"touchable\"]", 10.0))
																{
																	method_40(1.0);
																	BEA5E4BB("document.querySelector('button[data-sigil=\"touchable\"]').click()");
																	method_40(3.0);
																}
															}
															if (Convert.ToBoolean(BEA5E4BB("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
															{
																for (int l = 0; l < 5; l++)
																{
																	GClass8.smethod_53(2.0);
																	if (!Convert.ToBoolean(BEA5E4BB("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
																	{
																		break;
																	}
																}
																for (int m = 0; m < 5; m++)
																{
																	GClass8.smethod_53(2.0);
																	if (!Convert.ToBoolean(BEA5E4BB("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('consent/basic/log')){x[i].click();break;check='true'}} return check")))
																	{
																		break;
																	}
																}
																if (CD003D3F("[href=\"/home.php\"]"))
																{
																	method_16("[href=\"/home.php\"]");
																}
															}
															if (text.Contains("facebook.com/legal_consent"))
															{
																BEA5E4BB("document.querySelector('button').click()");
																method_40(1.0);
																BEA5E4BB("document.querySelectorAll('button')[1].click()");
																method_40(1.0);
																BEA5E4BB("document.querySelector('button').click()");
																method_40(1.0);
																BEA5E4BB("document.querySelectorAll('button')[1].click()");
																method_40(1.0);
															}
															if (text.Contains("facebook.com/si/actor_experience/actor_gateway"))
															{
																method_16("[data-sigil=\"touchable\"]");
																method_40(1.0);
															}
															if (CD003D3F("button[value=\"OK\"]"))
															{
																method_16("button[value=\"OK\"]");
																method_40(1.0);
															}
															if (CD003D3F("[data-store-id=\"2\"]>span"))
															{
																method_16("[data-store-id=\"2\"]>span");
																method_40(1.0);
															}
															if (CD003D3F("[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span"))
															{
																method_16("[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span");
																method_40(3.0);
															}
														}
														else
														{
															if (!text.StartsWith("https://www.facebook.com/legal_consent"))
															{
																continue;
															}
															for (int n = 0; n < 5; n++)
															{
																if (!CD003D3F("button"))
																{
																	break;
																}
																method_19("button");
																method_40(1.0);
															}
														}
													}
													continue;
												}
												return "9";
											}
											return "vhh";
										}
										return "2";
									}
									return "8";
								}
								return "2";
							}
							return "vhh";
						}
						return "21";
						IL_1f0e:
						method_10("https://www.facebook.com/login");
						method_40(1.0);
						DB3A262D = "https://www.facebook.com";
						goto IL_1f7f;
						IL_1160:
						if (!method_9().Contains("facebook.com/auth_platform/"))
						{
							if (num6 == 0 && num8 == 0)
							{
								if (flag3 && !method_9().Contains("facebook.com/login/web/?email="))
								{
									string text17 = "";
									switch (AFABF4B7())
									{
									case 2:
									case 3:
										text17 = BEA5E4BB("var out='';var x=document.querySelector('#login_error');if(x!=null) out=x.innerText;return out;").ToString();
										break;
									case 1:
										text17 = method_6("#error_box");
										text17 = ((text17.Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries).Count() > 1) ? text17.Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries)[1].Trim() : text17);
										break;
									}
									if (!(text17 != ""))
									{
										if (!CD003D3F("[href*=\"/login/identify/\"]"))
										{
											if (!CD003D3F("#account_recovery_initiate_view_label"))
											{
												if (AFABF4B7() == 1 || AFABF4B7() == 3)
												{
													if (CD003D3F("[name=\"email\"]") && method_5("[name=\"email\"]") == "")
													{
														return "4";
													}
													if (CD003D3F("[name=\"pass\"]") && method_5("[name=\"pass\"]") == "")
													{
														return "5";
													}
												}
												continue;
											}
											return "5";
										}
										return "4";
									}
									return text17;
								}
								flag3 = true;
								method_60();
								if (CD003D3F("[name='email']"))
								{
									method_29("[name='email']");
									AF93AB8B("[name='email']", e599E, 0.1);
									method_40(1.0);
								}
								if (CD003D3F("[name='pass']"))
								{
									method_29("[name='pass']");
									AF93AB8B("[name='pass']", string_3, 0.1);
									method_40(1.0);
								}
								string string_2 = method_13(0.0, new List<string> { "#aymh_password_entry_view [role=\"button\"]:not([aria-label])", "[name=\"login\"]", "#loginbutton", "[aria-label=\"Log in\"]", "div[role=\"button\"]:not([aria-label])" });
								BE358C3C(string_2);
								method_40(2.0);
								for (int num12 = 0; num12 < 10; num12++)
								{
									if (BB1DB70A(0))
									{
										break;
									}
									if (method_5("[name=\"pass\"]") == "")
									{
										break;
									}
									if (CD003D3F("[href*=\"/login/identify/\"]"))
									{
										break;
									}
									method_40(2.0);
								}
							}
							else if (method_5("[name=\"email\"]") == "")
							{
								return "0";
							}
							continue;
						}
						goto IL_162c;
					}
					break;
				}
			}
			catch (Exception f4295AA)
			{
				GClass8.BFBDF687(this, f4295AA, "Error Login Uid Pass");
			}
			return "0";
		}
		return "2";
	}

	public bool method_130()
	{
		int num = 0;
		int num2 = 3;
		string text = "";
		bool result = false;
		int tickCount = Environment.TickCount;
		int num3 = 120;
		string text2 = GClass8.A2307E3B("CmZ1bmN0aW9uIGdldEVtYWlscyh0ZXh0KSB7CiAgICB2YXIgYXJyRW1haWxzID0gdGV4dC5tYXRjaCgvXGJbYS16QS1aMC05Kl0rQFthLXpBLVowLTkqLi1dK1wuW2EtekEtWl17Mix9XGIvZykgfHwgW107CiAgICBpZiAoYXJyRW1haWxzLmxlbmd0aCA9PT0gMCkKICAgICAgICBhcnJFbWFpbHMgPSB0ZXh0Lm1hdGNoKC9cYlthLXpBLVpdXCorKFthLXpBLVowLTkuXyUrLV0rKT9AW0EtWmEtejAtOS4tXStcLltBLVp8YS16XXsyLH1cYi9nKSB8fCBbXTsKICAgIGFyckVtYWlscyA9IGFyckVtYWlscy5maWx0ZXIoKGl0ZW0sIGluZGV4KSA9PiBhcnJFbWFpbHMuaW5kZXhPZihpdGVtKSA9PT0gaW5kZXgpOwogICAgcmV0dXJuIGFyckVtYWlsczsKfQoKCmZ1bmN0aW9uIGNvbXBhcmVFbWFpbHMoZW1haWwsIGFyckVtYWlscykgewogICAgZm9yICh2YXIgaiA9IDA7IGogPCBhcnJFbWFpbHMubGVuZ3RoOyBqKyspIHsKICAgICAgICB2YXIgdGVtcCA9IGFyckVtYWlsc1tqXTsKICAgICAgICBpZiAoZW1haWwuc3Vic3RyaW5nKGVtYWlsLmluZGV4T2YoJ0AnKSAtIDEsIGVtYWlsLmluZGV4T2YoJ0AnKSArIDEpID09PSB0ZW1wLnN1YnN0cmluZyh0ZW1wLmluZGV4T2YoJ0AnKSAtIDEsIHRlbXAuaW5kZXhPZignQCcpICsgMSkpIHsKICAgICAgICAgICAgcmV0dXJuIHRydWU7CiAgICAgICAgfQogICAgfQogICAgcmV0dXJuIGZhbHNlOwp9Ow==");
		while (method_9().Contains("facebook.com/checkpoint/465803052217681"))
		{
			string text3 = method_13(0.0, new List<string> { "form input[type=\"text\"]", "[role=\"dialog\"] div>label", "[role=\"button\"]>[role=\"none\"]" });
			switch (text3)
			{
			case "form input[type=\"text\"]":
				if (method_5(text3) != "" && !CD003D3F("form div span"))
				{
					break;
				}
				if (!("false" == BEA5E4BB(text2 + ";var email = \"" + string_6.ToLower() + "\"; var isSuccess = false; var arrEmails = getEmails(document.documentElement.innerText); for (var j = 0; j < arrEmails.length; j++) { var temp = arrEmails[j]; if (compareEmails(email, arrEmails)) { isSuccess = true; break; }}; return isSuccess;").ToString().ToLower()))
				{
					method_40(3.0);
					num++;
					if (num < num2)
					{
						string text4 = Class98.A1A49D95(1, string_6, B0094F8A, DFA50A09, 60, "", text);
						if (!(text4 == "fail"))
						{
							if (text4 == "")
							{
								BE358C3C("span div[role=\"button\"]");
							}
							else if (GClass8.smethod_44(text4))
							{
								text = text4;
								if (method_5(text3) != "")
								{
									method_16(text3);
									method_16("//form//input[@type=\"text\"]/parent::*//*[@role=\"button\"]");
								}
								method_20(text3, text4);
								method_24(text3);
								result = true;
							}
							break;
						}
						return false;
					}
					return false;
				}
				return false;
			case "[role=\"dialog\"] div>label":
				if (!(string_6 == ""))
				{
					if (!("false" == BEA5E4BB(text2 + "; var isSuccess = false; var email = \"" + string_6 + "\"; var labels = document.querySelectorAll('[role=\"dialog\"] div>label'); for (let i = 0; i < labels.length; i++) { var e = labels[i]; var text = e.innerText; if (!text.includes('@')) continue; var arrEmails = getEmails(text); if (arrEmails.length === 0) continue; for (var j = 0; j < arrEmails.length; j++) { var temp = arrEmails[j]; if (compareEmails(email, arrEmails)) { e.click(); isSuccess = true; break; } } if (isSuccess) break; } return isSuccess;").ToString().ToLower()))
					{
						text = Class98.A1A49D95(1, string_6, B0094F8A, DFA50A09, 0, "", "");
						if (!(text == "fail"))
						{
							method_19("[role=\"dialog\"] [role=\"none\"]>[role=\"none\"]");
							break;
						}
						return false;
					}
					return false;
				}
				return false;
			case "[role=\"button\"]>[role=\"none\"]":
				method_16(text3);
				break;
			}
			if (Environment.TickCount - tickCount > num3 * 1000)
			{
				break;
			}
			method_40(1.0);
		}
		return result;
	}

	public bool A5385682()
	{
		int num = 0;
		int num2 = 3;
		string text = "";
		bool result = false;
		int tickCount = Environment.TickCount;
		int num3 = 120;
		string text2 = GClass8.A2307E3B("CmZ1bmN0aW9uIGdldEVtYWlscyh0ZXh0KSB7CiAgICB2YXIgYXJyRW1haWxzID0gdGV4dC5tYXRjaCgvXGJbYS16QS1aMC05Kl0rQFthLXpBLVowLTkqLi1dK1wuW2EtekEtWl17Mix9XGIvZykgfHwgW107CiAgICBpZiAoYXJyRW1haWxzLmxlbmd0aCA9PT0gMCkKICAgICAgICBhcnJFbWFpbHMgPSB0ZXh0Lm1hdGNoKC9cYlthLXpBLVpdXCorKFthLXpBLVowLTkuXyUrLV0rKT9AW0EtWmEtejAtOS4tXStcLltBLVp8YS16XXsyLH1cYi9nKSB8fCBbXTsKICAgIGFyckVtYWlscyA9IGFyckVtYWlscy5maWx0ZXIoKGl0ZW0sIGluZGV4KSA9PiBhcnJFbWFpbHMuaW5kZXhPZihpdGVtKSA9PT0gaW5kZXgpOwogICAgcmV0dXJuIGFyckVtYWlsczsKfQoKCmZ1bmN0aW9uIGNvbXBhcmVFbWFpbHMoZW1haWwsIGFyckVtYWlscykgewogICAgZm9yICh2YXIgaiA9IDA7IGogPCBhcnJFbWFpbHMubGVuZ3RoOyBqKyspIHsKICAgICAgICB2YXIgdGVtcCA9IGFyckVtYWlsc1tqXTsKICAgICAgICBpZiAoZW1haWwuc3Vic3RyaW5nKGVtYWlsLmluZGV4T2YoJ0AnKSAtIDEsIGVtYWlsLmluZGV4T2YoJ0AnKSArIDEpID09PSB0ZW1wLnN1YnN0cmluZyh0ZW1wLmluZGV4T2YoJ0AnKSAtIDEsIHRlbXAuaW5kZXhPZignQCcpICsgMSkpIHsKICAgICAgICAgICAgcmV0dXJuIHRydWU7CiAgICAgICAgfQogICAgfQogICAgcmV0dXJuIGZhbHNlOwp9Ow==");
		while (method_9().Contains("facebook.com/auth_platform/"))
		{
			string text3 = method_13(0.0, new List<string> { "//form//input[@type=\"text\"]", "//div/label", "//*[@role=\"button\"]/*[@role=\"none\"]" });
			switch (text3)
			{
			case "//*[@role=\"button\"]/*[@role=\"none\"]":
				BE358C3C("(" + text3 + ")[last()]");
				break;
			case "//div/label":
				if (!(string_6 == ""))
				{
					if (!("false" == BEA5E4BB(text2 + "; var isSuccess = false; var email = \"" + string_6 + "\"; var labels = document.querySelectorAll('div>label'); for (let i = 0; i < labels.length; i++) { var e = labels[i]; var text = e.innerText; if (!text.includes('@')) continue; var arrEmails = getEmails(text); if (arrEmails.length === 0) continue; for (var j = 0; j < arrEmails.length; j++) { var temp = arrEmails[j]; if (compareEmails(email, arrEmails)) { e.click(); isSuccess = true; break; } } if (isSuccess) break; } return isSuccess;").ToString().ToLower()))
					{
						text = Class98.A1A49D95(1, string_6, B0094F8A, DFA50A09, 0, "", "");
						if (!(text == "fail"))
						{
							BE358C3C("(//*[@role=\"button\"]/*[@role=\"none\"])[last()]");
							break;
						}
						return false;
					}
					return false;
				}
				return false;
			case "//form//input[@type=\"text\"]":
				if (method_5(text3) != "" && !CD003D3F("form div span"))
				{
					break;
				}
				if (!("false" == BEA5E4BB(text2 + ";var email = \"" + string_6.ToLower() + "\"; var isSuccess = false; var arrEmails = getEmails(document.documentElement.innerText); for (var j = 0; j < arrEmails.length; j++) { var temp = arrEmails[j]; if (compareEmails(email, arrEmails)) { isSuccess = true; break; }}; return isSuccess;").ToString().ToLower()))
				{
					method_40(3.0);
					num++;
					if (num < num2)
					{
						string text4 = Class98.A1A49D95(1, string_6, B0094F8A, DFA50A09, 60, "", text);
						if (!(text4 == "fail"))
						{
							if (text4 == "")
							{
								BE358C3C("span div[role=\"button\"]");
							}
							else if (GClass8.smethod_44(text4))
							{
								text = text4;
								if (method_5(text3) != "")
								{
									method_16(text3);
									method_16("//form//input[@type=\"text\"]/parent::*//*[@role=\"button\"]");
								}
								method_20(text3, text4);
								method_24(text3);
								result = true;
							}
							break;
						}
						return false;
					}
					return false;
				}
				return false;
			}
			if (Environment.TickCount - tickCount > num3 * 1000)
			{
				break;
			}
			method_40(1.0);
		}
		return result;
	}

	public bool EB3968B5()
	{
		return false;
	}

	public int method_131(string A30C0C0E = "https://mobile.facebook.com")
	{
		try
		{
			if (method_1() || BBA51B98())
			{
				return -2;
			}
			if (CD003D3F("#m_login_email,#m_login_password,[name=\"login\"]"))
			{
				return 0;
			}
			if (method_127())
			{
				return 2;
			}
			if (method_94())
			{
				return 9;
			}
			DFA46D3A();
			if (AFABF4B7() != AFABF4B7(A30C0C0E))
			{
				method_10(A30C0C0E);
			}
			if (AFABF4B7() == 2 && CD003D3F("[href^=\"/a/preferences.php?fast_switch_site\"]"))
			{
				BB963890(0, "[href^=\"/a/preferences.php?fast_switch_site\"]");
			}
			if (method_126())
			{
				return 8;
			}
			if (method_128())
			{
				return 1;
			}
			string text = method_9();
			if (text.Contains("facebook.com/checkpoint/") || text.Contains("facebook.com/nt/screen/?params=%7B%22token") || text.Contains("facebook.com/x/checkpoint/"))
			{
				return 2;
			}
			if (method_9().Contains("facebook.com/user_cookie_prompt"))
			{
				method_10("https://mobile.facebook.com/");
			}
			switch (AFABF4B7(A30C0C0E))
			{
			case 2:
			{
				for (int i = 0; i < 30; i++)
				{
					if (method_9().Contains("facebook.com/si/actor_experience/actor_gateway/nt/?flow_id="))
					{
						break;
					}
					method_123(DB2A5F10: true);
					switch (GEnum3_0)
					{
					case GEnum3.DC10881C:
						return -2;
					case GEnum3.const_2:
						return 0;
					case GEnum3.E02E9820:
						return 2;
					case GEnum3.C520DC29:
						return 1;
					case GEnum3.const_5:
						return -3;
					case GEnum3.const_7:
						return 3;
					}
					method_59();
					if (CD003D3F("a[href*=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]", 5.0))
					{
						BEA5E4BB("document.querySelector('a[href*=\"/zero/optin/write/?action=cancel&page=dialtone_optin_page\"]').click()");
						method_40(3.0);
						if (CD003D3F("[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button", 10.0))
						{
							BEA5E4BB("document.querySelector('[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button').click()");
							method_40(3.0);
						}
					}
					if (method_9().Contains("facebook.com/zero/optin/write/"))
					{
						method_40(1.0);
						BEA5E4BB("document.querySelector('[action=\"/zero/optin/write/?action=confirm&page=reconsider_optin_dialog\"] button').click()");
						method_40(3.0);
					}
					if (method_9().Contains("facebook.com/zero/policy/optin"))
					{
						method_40(1.0);
						BEA5E4BB("document.querySelector('a[data-sigil=\"touchable\"]').click()");
						method_40(3.0);
						if (CD003D3F("button[data-sigil=\"touchable\"]", 10.0))
						{
							method_40(1.0);
							BEA5E4BB("document.querySelector('button[data-sigil=\"touchable\"]').click()");
							method_40(3.0);
						}
					}
					if (Convert.ToBoolean(BEA5E4BB("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
					{
						for (int j = 0; j < 5; j++)
						{
							GClass8.smethod_53(2.0);
							if (!Convert.ToBoolean(BEA5E4BB("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
							{
								break;
							}
						}
						for (int k = 0; k < 5; k++)
						{
							GClass8.smethod_53(2.0);
							if (!Convert.ToBoolean(BEA5E4BB("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('consent/basic/log')){x[i].click();break;check='true'}} return check")))
							{
								break;
							}
						}
						if (CD003D3F("[href=\"/home.php\"]"))
						{
							method_16("[href=\"/home.php\"]");
						}
					}
					if (method_9().Contains("facebook.com/si/actor_experience/actor_gateway"))
					{
						method_16("[data-sigil=\"touchable\"]");
						method_40(1.0);
					}
					if (CD003D3F("button[value=\"OK\"]"))
					{
						method_16("button[value=\"OK\"]");
						method_40(1.0);
					}
					if (CD003D3F("[data-store-id=\"2\"]>span"))
					{
						method_16("[data-store-id=\"2\"]>span");
						method_40(1.0);
					}
					if (CD003D3F("[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span"))
					{
						method_16("[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span");
						method_40(3.0);
					}
					if (CD003D3F("#nux-nav-button,[href^=\"/a/nux/wizard/nav.php\"]"))
					{
						bool flag = false;
						for (int l = 0; l < 5; l++)
						{
							if (flag)
							{
								break;
							}
							string text2 = method_13(3.0, new List<string> { "#qf_skip_dialog_skip_link", "#nux-nav-button,[href^=\"/a/nux/wizard/nav.php\"]" });
							string text3 = text2;
							string text4 = text3;
							if (!(text4 == "#qf_skip_dialog_skip_link"))
							{
								if (!(text4 == "#nux-nav-button,[href^=\"/a/nux/wizard/nav.php\"]"))
								{
									flag = true;
									continue;
								}
								method_16(text2);
								method_40(2.0);
							}
							else
							{
								method_19(text2);
								method_40(1.0);
							}
						}
					}
					method_16("[name=\"primary_consent_button\"]");
					method_40(2.0);
					if (CD003D3F("#nux-nav-button,[href^=\"/a/nux/wizard/nav.php\"]"))
					{
						method_16("#nux-nav-button,[href^=\"/a/nux/wizard/nav.php\"]");
						if (CD003D3F("#qf_skip_dialog_skip_link", 10.0) && !method_15("#qf_skip_dialog_skip_link"))
						{
							BEA5E4BB("document.getElementById('qf_skip_dialog_skip_link').click()");
						}
					}
				}
				break;
			}
			case 1:
			{
				if (!method_9().StartsWith("https://www.facebook.com/legal_consent"))
				{
					break;
				}
				for (int m = 0; m < 5; m++)
				{
					if (!CD003D3F("button"))
					{
						break;
					}
					method_19("button");
					method_40(1.0);
				}
				break;
			}
			case 3:
				if (CD003D3F("[name=\"accept_only_essential\"][value=\"0\"]"))
				{
					method_16("[name=\"accept_only_essential\"][value=\"0\"]");
				}
				break;
			}
			method_123(DB2A5F10: true);
			switch (GEnum3_0)
			{
			case GEnum3.DC10881C:
				return -2;
			case GEnum3.const_2:
				return 0;
			case GEnum3.E02E9820:
				return 2;
			case GEnum3.C520DC29:
				return 1;
			case GEnum3.const_5:
				return -3;
			case GEnum3.BE941416:
				break;
			case GEnum3.const_7:
				return 3;
			}
		}
		catch
		{
		}
		return 0;
	}

	internal string method_132(string DFB4188D)
	{
		string string_ = "[{\"name\":\"password\", \"value\":\"" + String_3 + "\", \"type\":\"text\"},{\"name\":\"otp\", \"value\":\"" + DFB4188D + "\", \"type\":\"text\"}]";
		return E9B89BB8("TurnOn2FA", string_);
	}

	internal string D70F5623(string string_12)
	{
		string string_13 = "[{\"name\":\"password\", \"value\":\"" + String_3 + "\", \"type\":\"text\"},{\"name\":\"otp\", \"value\":\"" + string_12 + "\", \"type\":\"text\"}]";
		return E9B89BB8("TurnOff2FA", string_13);
	}

	internal string B993861D(string string_12, string E6AEBA33)
	{
		string string_13 = "[{\"name\":\"password\", \"value\":\"" + String_3 + "\", \"type\":\"text\"},{\"name\":\"newpassword\", \"value\":\"" + string_12 + "\", \"type\":\"text\"},{\"name\":\"otp\", \"value\":\"" + E6AEBA33 + "\", \"type\":\"text\"}]";
		return E9B89BB8("ChangePass", string_13);
	}

	internal string FD30D409(string string_12)
	{
		string string_13 = "[{\"name\":\"password\", \"value\":\"" + String_3 + "\", \"type\":\"text\"},{\"name\":\"otp\", \"value\":\"" + string_12 + "\", \"type\":\"text\"}]";
		return E9B89BB8("DeletePhone", string_13);
	}

	internal string method_133(string string_12, string string_13)
	{
		string string_14 = "[{\"name\":\"password\", \"value\":\"" + String_3 + "\", \"type\":\"text\"},{\"name\":\"email\", \"value\":\"" + string_12.ToLower() + "\", \"type\":\"text\"},{\"name\":\"otp\", \"value\":\"" + string_13 + "\", \"type\":\"text\"}]";
		return E9B89BB8("DeleteOtherEmail", string_14);
	}

	internal string method_134(string CAA2319A, string string_12)
	{
		string string_13 = "[{\"name\":\"password\", \"value\":\"" + String_3 + "\", \"type\":\"text\"},{\"name\":\"email\", \"value\":\"" + CAA2319A.ToLower() + "\", \"type\":\"text\"},{\"name\":\"otp\", \"value\":\"" + string_12 + "\", \"type\":\"text\"}]";
		return E9B89BB8("AddMailAccountCenter", string_13);
	}

	internal string method_135(string string_12, string string_13)
	{
		string string_14 = "[{\"name\":\"email\", \"value\":\"" + string_12.ToLower() + "\", \"type\":\"text\"},{\"name\":\"otp\", \"value\":\"" + string_13 + "\", \"type\":\"text\"}]";
		return E9B89BB8("SubmitOtpAddMail", string_14);
	}

	internal bool method_136(string string_12)
	{
		method_10("https://mbasic.facebook.com/entercode.php?cp=" + string_12.E0050019() + "&source_verified=m_settings&redirect_to_unified_contact_setting_page");
		string text = "[href*=\"/entercode.php\"][href*=\"step=resend\"]";
		if (CD003D3F(text, 30.0))
		{
			method_40(2.0);
			method_19(text);
			return true;
		}
		return false;
	}

	public string BA19F93D(string string_12, string string_13, string string_14, string BCB1B60B, int int_6)
	{
		if (method_1())
		{
			return "";
		}
		return method_62($"ResolveFunCaptcha('{string_12}', '{string_13}', '{string_14}', '{BCB1B60B}', {int_6})");
	}

	public bool F92D241C(int FD9B260A)
	{
		if (method_1())
		{
			return false;
		}
		string text = method_62($"SwitchToFrame({FD9B260A})");
		return text.ToLower() == "true";
	}

	public bool method_137()
	{
		if (method_1())
		{
			return false;
		}
		string text = method_62("SwitchToParentFrame()");
		return text.ToLower() == "true";
	}

	internal void method_138(string C81E2F9D, int int_6)
	{
		method_10("https://www.facebook.com/profile.php?sk=about_work_and_education&locale=en_US");
		method_40(2.0);
		int tickCount = Environment.TickCount;
		for (int num = 60; !method_1() && !BBA51B98() && Environment.TickCount - tickCount < num * 1000; method_40(2.0))
		{
			string text = method_13(0.0, new List<string> { "//*[text()=\"Add a workplace\"]", "//*[@aria-label=\"Company\"]//input" });
			string text2 = text;
			string text3 = text2;
			if (!(text3 == "//*[text()=\"Add a workplace\"]"))
			{
				if (text3 == "//*[@aria-label=\"Company\"]//input")
				{
					if (CD003D3F("[role=\"listbox\"]>li"))
					{
						method_16("[role=\"listbox\"]>li");
						method_40(2.0);
						method_17("[aria-label=\"Save\" i]");
						method_40(2.0);
						method_31("//*[@aria-label=\"Company\"]//input", 60);
						break;
					}
					AC9778A4(text);
					method_20(text, C81E2F9D);
					method_40(2.0);
				}
				continue;
			}
			if (CD003D3F("//*[starts-with(text(),\"Works at \")]"))
			{
				switch (int_6)
				{
				case 2:
					if (CD003D3F("//*[@role=\"menuitem\"]//*[text()=\"Delete workplace\"]"))
					{
						method_16("//*[@role=\"menuitem\"]//*[text()=\"Delete workplace\"]");
					}
					else if (CD003D3F("[role=\"dialog\"] [aria-label=\"Confirm\"]"))
					{
						method_16("[role=\"dialog\"] [aria-label=\"Confirm\"]");
					}
					else
					{
						method_16("//*[@aria-label=\"Options\"][./parent::*/parent::*//*[starts-with(text(),\"Works at \")]]");
					}
					continue;
				case 1:
					return;
				}
			}
			method_17(text);
		}
	}

	private void method_139()
	{
		int tickCount = Environment.TickCount;
		int num = 60;
		while (!method_1() && !BBA51B98() && Environment.TickCount - tickCount < num * 1000)
		{
			string text = method_13(0.0, new List<string> { "[href^=\"/profile/edit/exp/work/detail/\"]", "[href*=\"/editprofile/experience/delete/\"]" });
			if (!(text == ""))
			{
				method_16(text);
				method_40(1.0);
				continue;
			}
			break;
		}
	}

	internal void method_140(string string_12, int A3A99280)
	{
		method_10("https://www.facebook.com/profile.php?sk=about_work_and_education&locale=en_US");
		method_40(2.0);
		int tickCount = Environment.TickCount;
		for (int num = 60; !method_1() && !BBA51B98() && Environment.TickCount - tickCount < num * 1000; method_40(2.0))
		{
			string text = method_13(0.0, new List<string> { "//*[text()=\"Add high school\"]", "//*[@aria-label=\"School\"]//input" });
			string text2 = text;
			string text3 = text2;
			if (!(text3 == "//*[text()=\"Add high school\"]"))
			{
				if (text3 == "//*[@aria-label=\"School\"]//input")
				{
					if (CD003D3F("[role=\"listbox\"]>li"))
					{
						method_16("[role=\"listbox\"]>li");
						method_40(2.0);
						method_17("[aria-label=\"Save\" i]");
						method_40(2.0);
						method_31("//*[@aria-label=\"School\"]//input", 60);
						break;
					}
					AC9778A4(text);
					method_20(text, string_12);
					method_40(2.0);
				}
				continue;
			}
			if (CD003D3F("//*[starts-with(text(),\"Went to \")]"))
			{
				switch (A3A99280)
				{
				case 2:
					if (CD003D3F("//*[@role=\"menuitem\"]//*[text()=\"Delete school\"]"))
					{
						method_16("//*[@role=\"menuitem\"]//*[text()=\"Delete school\"]");
					}
					else if (CD003D3F("[role=\"dialog\"] [aria-label=\"Confirm\"]"))
					{
						method_16("[role=\"dialog\"] [aria-label=\"Confirm\"]");
					}
					else
					{
						method_16("//*[@aria-label=\"Options\"][./parent::*/parent::*//*[starts-with(text(),\"Went to \")]]");
					}
					continue;
				case 1:
					return;
				}
			}
			method_17(text);
		}
	}

	private void C40F3E34()
	{
		int tickCount = Environment.TickCount;
		int num = 60;
		while (!method_1() && !BBA51B98() && Environment.TickCount - tickCount < num * 1000)
		{
			string text = method_13(0.0, new List<string> { "#education [href^=\"/profile/edit/exp/edu/detail/\"]", "[href*=\"/editprofile/experience/delete/\"]" });
			if (!(text == ""))
			{
				method_16(text);
				method_40(1.0);
				continue;
			}
			break;
		}
	}

	internal void method_141(string F7BEB90A, int int_6)
	{
		method_10("https://www.facebook.com/profile.php?sk=about_work_and_education&locale=en_US");
		method_40(2.0);
		int tickCount = Environment.TickCount;
		for (int num = 60; !method_1() && !BBA51B98() && Environment.TickCount - tickCount < num * 1000; method_40(2.0))
		{
			string text = method_13(0.0, new List<string> { "//*[text()=\"Add college\"]", "//*[@aria-label=\"School\"]//input" });
			string text2 = text;
			string text3 = text2;
			if (!(text3 == "//*[text()=\"Add college\"]"))
			{
				if (text3 == "//*[@aria-label=\"School\"]//input")
				{
					if (CD003D3F("[role=\"listbox\"]>li"))
					{
						method_16("[role=\"listbox\"]>li");
						method_40(2.0);
						method_17("[aria-label=\"Save\" i]");
						method_40(2.0);
						method_31("//*[@aria-label=\"School\"]//input", 60);
						break;
					}
					AC9778A4(text);
					method_20(text, F7BEB90A);
					method_40(2.0);
				}
				continue;
			}
			if (CD003D3F("//*[starts-with(text(),\"Studied at \")]"))
			{
				switch (int_6)
				{
				case 2:
					if (CD003D3F("//*[@role=\"menuitem\"]//*[text()=\"Delete school\"]"))
					{
						method_16("//*[@role=\"menuitem\"]//*[text()=\"Delete school\"]");
					}
					else if (CD003D3F("[role=\"dialog\"] [aria-label=\"Confirm\"]"))
					{
						method_16("[role=\"dialog\"] [aria-label=\"Confirm\"]");
					}
					else
					{
						method_16("//*[@aria-label=\"Options\"][./parent::*/parent::*//*[starts-with(text(),\"Studied at \")]]");
					}
					continue;
				case 1:
					return;
				}
			}
			method_17(text);
		}
	}

	internal void method_142(string F12D943C)
	{
		method_10("https://www.facebook.com/profile.php?sk=about_places&locale=en_US");
		method_40(2.0);
		int tickCount = Environment.TickCount;
		int num = 60;
		while (!method_1() && !BBA51B98() && Environment.TickCount - tickCount < num * 1000)
		{
			string text = method_13(0.0, new List<string> { "//*[text()=\"Add current city\"]", "//input[@aria-label=\"Current city\"]", "//*[@aria-label=\"Options\"][./parent::*/parent::*//*[text()=\"Current city\"]]" });
			switch (text)
			{
			case "//*[@aria-label=\"Options\"][./parent::*/parent::*//*[text()=\"Current city\"]]":
				if (CD003D3F("//*[text()=\"Edit current city\"]"))
				{
					method_16("//*[text()=\"Edit current city\"]");
				}
				else
				{
					method_17(text);
				}
				break;
			case "//input[@aria-label=\"Current city\"]":
				if (!CD003D3F("[role=\"listbox\"]>li"))
				{
					AC9778A4(text);
					method_20(text, F12D943C);
					method_40(2.0);
					break;
				}
				method_16("[role=\"listbox\"]>li");
				method_40(2.0);
				method_17("[aria-label=\"Save\" i]");
				method_40(2.0);
				method_31(text, 60);
				return;
			case "//*[text()=\"Add current city\"]":
				method_17(text);
				break;
			}
			method_40(2.0);
		}
	}

	internal void method_143(string string_12)
	{
		method_10("https://www.facebook.com/profile.php?sk=about_places&locale=en_US");
		method_40(2.0);
		int tickCount = Environment.TickCount;
		int num = 60;
		while (!method_1() && !BBA51B98() && Environment.TickCount - tickCount < num * 1000)
		{
			string text = method_13(0.0, new List<string> { "//*[text()=\"Add hometown\"]", "//input[@aria-label=\"Hometown\"]", "//*[@aria-label=\"Options\"][./parent::*/parent::*//*[text()=\"Hometown\"]]" });
			switch (text)
			{
			case "//*[@aria-label=\"Options\"][./parent::*/parent::*//*[text()=\"Hometown\"]]":
				if (CD003D3F("//*[text()=\"Edit hometown\"]"))
				{
					method_16("//*[text()=\"Edit hometown\"]");
				}
				else
				{
					method_17(text);
				}
				break;
			case "//input[@aria-label=\"Hometown\"]":
				if (!CD003D3F("[role=\"listbox\"]>li"))
				{
					AC9778A4(text);
					method_20(text, string_12);
					method_40(2.0);
					break;
				}
				method_16("[role=\"listbox\"]>li");
				method_40(2.0);
				method_17("[aria-label=\"Save\" i]");
				method_40(2.0);
				method_31(text, 60);
				return;
			case "//*[text()=\"Add hometown\"]":
				method_17(text);
				break;
			}
			method_40(2.0);
		}
	}

	internal bool FE34702B(string E11152B5)
	{
		if (CD003D3F("[type=\"file\"]", 15.0))
		{
			method_40(1.0);
			method_23("[type=\"file\"]", E11152B5);
			method_40(1.0);
			method_31(".html-div [role=\"button\"][aria-disabled=\"true\"]", 60);
			method_16(".html-div [role=\"button\"]:has(div>[role=\"none\"])");
			method_40(2.0);
			method_31(".html-div [role=\"button\"][aria-disabled=\"true\"]", 60);
			return true;
		}
		return false;
	}

	public string method_144()
	{
		string text = "9e5f94bc-e8a4-4e73-b8be-63364c29d753";
		string string_ = "https://login.microsoftonline.com/common/oauth2/v2.0/authorize?client_id=" + text + "&response_type=code&redirect_uri=https%3A%2F%2Flocalhost%2F&response_mode=query&scope=offline_access https://outlook.office.com/IMAP.AccessAsUser.All https://outlook.office.com/POP.AccessAsUser.All https://outlook.office.com/EWS.AccessAsUser.All https://outlook.office.com/SMTP.Send&state=PvCYEqIiGX";
		method_10(string_);
		string text2 = "";
		for (int i = 0; i < 30; i++)
		{
			text2 = GClass8.smethod_96(method_9(), "code=(.*?)&");
			if (text2 != "")
			{
				break;
			}
			string text3 = method_13(0.0, new List<string> { "#idBtn_Accept", "#iLandingViewAction" });
			if (text3 != "")
			{
				BE358C3C(text3);
			}
			method_40(2.0);
		}
		if (text2 == "")
		{
			return "";
		}
		GClass0 gClass = new GClass0();
		string_ = "https://login.microsoftonline.com/common/oauth2/v2.0/token";
		List<KeyValuePair<string, string>> f18715B = new List<KeyValuePair<string, string>>
		{
			new KeyValuePair<string, string>("client_id", text),
			new KeyValuePair<string, string>("code", text2),
			new KeyValuePair<string, string>("redirect_uri", "https://localhost/"),
			new KeyValuePair<string, string>("grant_type", "authorization_code")
		};
		string aB335AA = DB335BB8(f18715B);
		string input = gClass.method_2(string_, aB335AA);
		string value = Regex.Match(input, "\"refresh_token\":\"(.*?)\"").Groups[1].Value;
		return value + "|" + text;
	}

	public string DB335BB8(List<KeyValuePair<string, string>> F18715B0)
	{
		return string.Join("&", F18715B0.Select((KeyValuePair<string, string> keyValuePair_0) => WebUtility.UrlEncode(keyValuePair_0.Key) + "=" + WebUtility.UrlEncode(keyValuePair_0.Value)));
	}

	internal void method_145(List<string> list_0)
	{
		string text = "[aria-label$=\" questions\"][role=\"dialog\"]";
		if (CD003D3F(text + " input[type=\"radio\"]"))
		{
			int num = E22B0917(text + " input[type=\"radio\"]");
			for (int i = 0; i < num; i++)
			{
				method_17(text + " input[type=\"radio\"]|" + i);
			}
		}
		if (CD003D3F(text + " textarea"))
		{
			int num2 = E22B0917(text + " textarea");
			for (int j = 0; j < num2; j++)
			{
				string string_ = list_0[j % list_0.Count];
				method_18(text + " textarea|" + j);
				method_20(text + " textarea|" + j, string_);
			}
		}
		if (CD003D3F(text + " input[type=\"checkbox\"]"))
		{
			int num3 = E22B0917(text + " input[type=\"checkbox\"]");
			for (int k = 0; k < num3; k++)
			{
				method_17(text + " input[type=\"checkbox\"]|" + k);
			}
		}
		method_17("(//*[contains(@aria-label,\" questions\") and @role=\"dialog\"]//*[@aria-label=\"Submit\"])[last()]");
	}

	internal void E1A35786(string string_12)
	{
		try
		{
			IWebElement toElement = FC32B61C(string_12);
			Actions actions = new Actions(ChromeDriver_0);
			actions.MoveToElement(toElement).Perform();
		}
		catch (Exception)
		{
		}
	}

	internal void method_146(string string_12)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>
		{
			{ "1", "Single" },
			{ "2", "In a relationship" },
			{ "5", "Engaged" },
			{ "4", "Married" },
			{ "10", "In a civil union" },
			{ "11", "In a domestic partnership" },
			{ "3", "In an open relationship" },
			{ "6", "It's complicated" },
			{ "8", "Separated" },
			{ "9", "Divorced" },
			{ "7", "Widowed" }
		};
		string text = dictionary[string_12];
		method_10("https://www.facebook.com/profile.php?sk=about_family_and_relationships&locale=en_US");
		method_40(2.0);
		int tickCount = Environment.TickCount;
		int num = 60;
		while (!method_1() && !BBA51B98() && Environment.TickCount - tickCount < num * 1000)
		{
			string text2 = method_13(0.0, new List<string> { "//*[text()=\"Add a relationship status\"]", "//*[text()=\"Relationship\"]/ancestor::*//*[@role=\"combobox\"]//span", "//*[@aria-label=\"Edit relationship\"]" });
			switch (text2)
			{
			case "//*[@aria-label=\"Edit relationship\"]":
				if (!CD003D3F("//*[text()=\"" + text + "\"]"))
				{
					method_17(text2);
					break;
				}
				return;
			case "//*[text()=\"Relationship\"]/ancestor::*//*[@role=\"combobox\"]//span":
				if (!CD003D3F("//*[@role=\"option\"]//*[text()=\"" + text + "\"]"))
				{
					method_16(text2);
					break;
				}
				method_16("//*[@role=\"option\"]//*[text()=\"" + text + "\"]");
				method_40(2.0);
				method_17("[aria-label=\"Save\" i]");
				method_40(2.0);
				method_31(text2, 60);
				return;
			case "//*[text()=\"Add a relationship status\"]":
				method_17(text2);
				break;
			}
			method_40(2.0);
		}
	}

	internal void method_147(string CB2FEE8A)
	{
		string text = "";
		string text2 = "";
		if (!(CB2FEE8A == "1"))
		{
			if (CB2FEE8A == "2")
			{
				text = "Male";
				text2 = "he/him";
			}
		}
		else
		{
			text = "Female";
			text2 = "she/her";
		}
		method_10("https://www.facebook.com/profile.php?sk=about_contact_and_basic_info&locale=en_US");
		method_40(2.0);
		int tickCount = Environment.TickCount;
		int num = 60;
		while (!method_1() && !BBA51B98() && Environment.TickCount - tickCount < num * 1000)
		{
			string text3 = method_13(0.0, new List<string> { "[aria-label=\"Add your gender\"]", "[aria-haspopup=\"listbox\"][role=\"combobox\"]" });
			string text4 = text3;
			string text5 = text4;
			if (!(text5 == "[aria-label=\"Add your gender\"]"))
			{
				if (text5 == "[aria-haspopup=\"listbox\"][role=\"combobox\"]")
				{
					if (CD003D3F("//*[@role=\"option\"]//*[text()=\"" + text + "\"]"))
					{
						method_16("//*[@role=\"option\"]//*[text()=\"" + text + "\"]");
						method_40(2.0);
						method_17("[aria-label=\"Save\" i]");
						method_40(2.0);
						method_31("[aria-label=\"Save\" i]", 60);
					}
					else
					{
						method_16(text3);
					}
				}
			}
			else if (CD003D3F("//*[@aria-label=\"Add your gender\"]/ancestor::*//*[text()=\"" + text + "\"]"))
			{
				if (CD003D3F("//*[text()=\"" + text2 + "\"]"))
				{
					if (!CD003D3F("//*[@role=\"option\"]//*[text()=\"" + text2 + "\"]"))
					{
						break;
					}
					method_16("//*[@role=\"option\"]//*[text()=\"" + text2 + "\"]");
					method_40(2.0);
					method_17("[aria-label=\"Save\" i]");
					method_40(2.0);
					method_31("[aria-label=\"Save\" i]", 60);
				}
				else if (CD003D3F("[aria-haspopup=\"listbox\"][role=\"combobox\"]"))
				{
					method_17("[aria-haspopup=\"listbox\"][role=\"combobox\"]");
				}
				else
				{
					method_16("[aria-label=\"Edit\"]");
				}
			}
			else
			{
				method_17(text3);
			}
			method_40(2.0);
		}
	}

	public void method_148(string F3AA2E05, string C907509D, int int_6)
	{
		if (class52_0 == null)
		{
			return;
		}
		F3958F9B f3958F9B = new F3958F9B();
		string text = "{\r\n                \"profileId\": {profileId},\r\n                \"closeBrowser\": false,\r\n                \"parameters\": {input}\r\n            }";
		text = text.Replace("{profileId}", class52_0.string_1);
		text = text.Replace("{input}", C907509D);
		string json = f3958F9B.A6321D97("http://localhost:1010/api/scripts/execute/" + F3AA2E05, text, "application/json");
		if (!Convert.ToBoolean(JObject.Parse(json)["success"]))
		{
			return;
		}
		method_40(3.0);
		text = "{\r\n                \"profileId\": {profileId}\r\n            }";
		text = text.Replace("{profileId}", class52_0.string_1);
		int tickCount = Environment.TickCount;
		while (!method_1())
		{
			if (Environment.TickCount - tickCount < int_6 * 1000 && !BBA51B98())
			{
				json = f3958F9B.A6321D97("http://localhost:1010/api/scripts/check-status/" + F3AA2E05, text, "application/json");
				if (Convert.ToBoolean(JObject.Parse(json)["is_running"]))
				{
					method_40(3.0);
					continue;
				}
				break;
			}
			text = "{\r\n                        \"profileId\": {profileId},\r\n                        \"closeBrowser\": false,\r\n                    }";
			text = text.Replace("{profileId}", class52_0.string_1);
			json = f3958F9B.A6321D97("http://localhost:1010/api/scripts/kill-excute/" + F3AA2E05, text, "application/json");
			break;
		}
	}

	[CompilerGenerated]
	private void method_149()
	{
		try
		{
			ChromeDriver_0.Quit();
		}
		catch (Exception)
		{
		}
	}
}
