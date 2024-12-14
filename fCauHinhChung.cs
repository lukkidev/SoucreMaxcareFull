using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhChung : Form
{
	private string string_0 = "";

	private string AEA56A06 = "";

	private GClass11 B223510E = new GClass11();

	private List<CheckBox> list_0 = null;

	private string string_1 = "";

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Label label3;

	private NumericUpDown nudInteractThread;

	private Label label4;

	private Label label5;

	private NumericUpDown nudHideThread;

	private Label label6;

	private Label D42AFB34;

	private TextBox txbPathProfile;

	private Panel panel1;

	private GroupBox grCauHinhChung;

	private CheckBox ckbShowImageInteract;

	private ComboBox cbbHostpot;

	private Panel FF152B09;

	private Label B9B6C73C;

	private TextBox txtNordVPN;

	private Button btnSSH;

	private RadioButton rbSSH;

	private RadioButton C49ACD35;

	private RadioButton rbNordVPN;

	private RadioButton rbHotspot;

	private BunifuDragControl BD3BF494;

	private ToolTip CDADBC94;

	private Button btnCancel;

	private Button btnSave;

	private BunifuCards A200A21D;

	private Panel pnlHeader;

	private PictureBox B7B5A3AC;

	private BunifuCustomLabel B49F18BB;

	private Button CA3ADC0D;

	private ComboBox cbbRowChrome;

	private ComboBox cbbColumnChrome;

	private Label label10;

	private Label label11;

	private Panel panel2;

	private Label label12;

	private TextBox ABB4F9A6;

	private RadioButton CD04A99E;

	private RadioButton radioButton4;

	private RadioButton radioButton3;

	private RadioButton radioButton2;

	private GroupBox grCauHinhChrome;

	private TextBox A184BE1A;

	private Label D98C5BB4;

	private NumericUpDown nudDelayOpenChromeTo;

	private Label label20;

	private GroupBox grCauHinhKhac;

	private Label C28D9186;

	private NumericUpDown DE26B731;

	private Label label29;

	private NumericUpDown nudDelayCloseChromeFrom;

	private NumericUpDown nudDelayCloseChromeTo;

	private ComboBox cbbSizeChrome;

	private Label EE983832;

	private Button AddFileAccount;

	private Panel AE0FFF89;

	private Label label30;

	private NumericUpDown nudHeighChrome;

	private NumericUpDown nudWidthChrome;

	private CheckBox ckbAddChromeIntoForm;

	private Label EC82A387;

	private Panel FAB3AA84;

	private Panel plSapXepCuaSoChrome;

	private Panel D238682D;

	private Label B213D1B8;

	private CheckBox ckbUsePortable;

	private TextBox txtPathToPortableZip;

	private Panel plVitech;

	private RichTextBox txtListProxyVitech;

	private RadioButton D60D659C;

	private RadioButton radioButton10;

	private Label label40;

	private Label label41;

	private Label label42;

	private NumericUpDown nudLuongPerIPVitech;

	private Label label46;

	private TextBox txtApiVitech;

	private RadioButton C7B4508F;

	private CheckBox C91FC226;

	private GroupBox groupBox3;

	private TabControl tabChangeIP;

	private TabPage AA2E82A1;

	private Panel F61EF227;

	private Button button4;

	private TextBox txtUrlHilink;

	private TextBox txtProfileNameDcom;

	private RadioButton rbDcomHilink;

	private Label FE23060C;

	private RadioButton rbDcomThuong;

	private TabPage A796A8A8;

	private Panel plXproxy;

	private TabPage tabObcProxy;

	private Panel F99B120B;

	private Label A8817A07;

	private RadioButton rbObcSock5Proxy;

	private RadioButton rbObcHttpProxy;

	private Label label55;

	private RichTextBox txtListObcProxy;

	private Label C4959598;

	private Label label69;

	private NumericUpDown E534B69E;

	private Label C539AA1A;

	private TextBox D70B2F26;

	private TabPage tabNone;

	private Panel panel16;

	private TabPage B1A94238;

	private Panel panel5;

	private RadioButton rbProxyDanCu;

	private RadioButton rbProxyDong;

	private Button button10;

	private RichTextBox txtApiKeyMinProxy;

	private Label label49;

	private Label label50;

	private NumericUpDown nudLuongPerIPMinProxy;

	private Label BB8D0B22;

	private NumericUpDown nudDelayCheckIP;

	private Panel C3B1BB87;

	private Button button5;

	private Label label26;

	private NumericUpDown EEA657B1;

	private Label C8A53894;

	private CheckBox D9A706B5;

	private Label label53;

	private CheckBox CBB0A68E;

	private RichTextBox txtListProxy;

	private RadioButton rbSock5Proxy;

	private RadioButton rbHttpProxy;

	private Label DC0CE7BC;

	private Label B125179D;

	private Label F5B33A1A;

	private NumericUpDown AF97B79E;

	private Label label13;

	private TextBox txtServiceURLXProxy;

	private Panel panel3;

	private Panel plDelayCloseChrome;

	private Label label2;

	private CheckBox ckbDelayCloseChrome;

	private ComboBox cbbTocDoGoVanBan;

	private Button btnDown;

	private Button D027A8A9;

	private ComboBox cbbTypePhanBietMau;

	private Button C923B88E;

	private Button D49F1407;

	private ComboBox cbbChangeIP;

	private ComboBox cbbTypeRunXproxy;

	private ComboBox CD26BF3A;

	private ComboBox cbbTypeProxyMin;

	private Label FD36AF17;

	private Label label15;

	private Panel plTypeProxy;

	private Panel FBA38325;

	private CheckBox ckbUseExtensionProxy;

	private Panel plDongBoMaxCare;

	private Label label22;

	private TextBox txtPathMaxCare;

	private CheckBox E51ADA30;

	private TabPage tabProxy;

	private ComboBox cbbProxy;

	private RichTextBox txtProxy;

	private Label CDAA4326;

	private Label label33;

	private Panel plTuyChonProxy;

	private Button DD824319;

	private Button A6A6CA1E;

	private TextBox txtTokenDonglaomail;

	private Label D5154C8C;

	private CheckBox EB0A133E;

	private LinkLabel D132643A;

	private CheckBox ckbBackupDB;

	private CheckBox ckbGologin;

	private Panel BE32A023;

	private Label label51;

	private TextBox B8A56C10;

	private LinkLabel CE8CD509;

	private GroupBox grEmailConfigs;

	private Label F795862C;

	private Panel FE01E21E;

	private CheckBox D18B4C95;

	private Label BF98EA14;

	private Panel CF2A9AA2;

	private Label D6AB5A82;

	private Label D33B3D3E;

	private TextBox txtMysqlServer;

	private CheckBox ckbMysqlServer;

	private Label label31;

	private Panel BC1D18BF;

	private Label label57;

	private TextBox txtTokenUnlimitMail;

	private TabPage tabProxyWeb;

	private RichTextBox E8A62C1C;

	private Label lblApiKeyProxy;

	private Label label65;

	private NumericUpDown nudLuongPerIP;

	private Panel plGpmLogin;

	private Button EEB05838;

	private TextBox EA2FA52B;

	private Label E5805987;

	private CheckBox ckbGpmLogin;

	private ComboBox cbbBrowserVersion;

	private Label label68;

	private NumericUpDown nudChromeScale;

	private Label lblChromeScale;

	private Panel D1269480;

	private Button button11;

	private TextBox txtGemApiUrl;

	private Label label62;

	private CheckBox DCADBCB4;

	private Label label38;

	private ComboBox cbbProxyType;

	private Label F8B84EB1;

	public fCauHinhChung()
	{
		InitializeComponent();
		grEmailConfigs.Height = (Class57.bool_0 ? 134 : 166);
		F7AB102E.D6B70A35(this);
	}

	public fCauHinhChung(ref GClass11 FE0C4A02)
	{
		InitializeComponent();
		grEmailConfigs.Height = (Class57.bool_0 ? 134 : 166);
		F7AB102E.D6B70A35(this);
		B223510E = FE0C4A02;
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F189AAB8(object sender, EventArgs e)
	{
		list_0 = new List<CheckBox> { ckbGologin, ckbGpmLogin, DCADBCB4 };
		method_1();
		method_2();
		method_4();
		FC1CD022();
		A1074D92();
		D99CC99C();
		method_3();
		nudInteractThread.Value = GClass25.smethod_0("configGeneral").method_2("nudInteractThread", 3);
		nudHideThread.Value = GClass25.smethod_0("configGeneral").method_2("nudHideThread", 5);
		txbPathProfile.Text = GClass25.smethod_2();
		if (!Directory.Exists(txbPathProfile.Text) || txbPathProfile.Text.Trim() == "profiles")
		{
			txbPathProfile.Text = GClass28.smethod_0() + "\\profiles";
		}
		GClass25.smethod_0("configGeneral").method_4("txbPathProfile", txbPathProfile.Text);
		ckbShowImageInteract.Checked = GClass25.smethod_0("configGeneral").method_3("ckbShowImageInteract");
		ckbUseExtensionProxy.Checked = GClass25.smethod_0("configGeneral").method_3("ckbUseExtensionProxy");
		E51ADA30.Checked = GClass25.smethod_0("configGeneral").method_3("ckbDongBoMaxCare");
		txtPathMaxCare.Text = GClass25.smethod_0("configGeneral").C0288288("txtPathMaxCare");
		string_0 = (E51ADA30.Checked ? txtPathMaxCare.Text : "");
		EB0A133E.Checked = GClass25.smethod_0("configGeneral").method_3("ckbHideBrowser");
		ckbAddChromeIntoForm.Checked = GClass25.smethod_0("configGeneral").method_3("ckbAddChromeIntoForm");
		nudWidthChrome.Value = GClass25.smethod_0("configGeneral").method_2("nudWidthChrome", 320);
		nudHeighChrome.Value = GClass25.smethod_0("configGeneral").method_2("nudHeighChrome", 480);
		DE26B731.Value = GClass25.smethod_0("configGeneral").method_2("nudDelayOpenChromeFrom", 1);
		nudDelayOpenChromeTo.Value = GClass25.smethod_0("configGeneral").method_2("nudDelayOpenChromeTo", 1);
		nudDelayCloseChromeFrom.Value = GClass25.smethod_0("configGeneral").method_2("nudDelayCloseChromeFrom");
		nudDelayCloseChromeTo.Value = GClass25.smethod_0("configGeneral").method_2("nudDelayCloseChromeTo");
		ckbDelayCloseChrome.Checked = GClass25.smethod_0("configGeneral").method_3("ckbDelayCloseChrome");
		cbbColumnChrome.Text = ((GClass25.smethod_0("configGeneral").C0288288("cbbColumnChrome") == "") ? "3" : GClass25.smethod_0("configGeneral").C0288288("cbbColumnChrome"));
		cbbRowChrome.Text = ((GClass25.smethod_0("configGeneral").C0288288("cbbRowChrome") == "") ? "2" : GClass25.smethod_0("configGeneral").C0288288("cbbRowChrome"));
		A184BE1A.Text = GClass25.smethod_0("configGeneral").C0288288("txtLinkToOtherBrowser");
		ckbUsePortable.Checked = GClass25.smethod_0("configGeneral").method_3("ckbUsePortable");
		txtPathToPortableZip.Text = GClass25.smethod_0("configGeneral").C0288288("txtPathToPortableZip");
		cbbSizeChrome.SelectedValue = GClass25.smethod_0("configGeneral").C0288288("sizeChrome", "default").ToString();
		if (cbbSizeChrome.SelectedValue == null)
		{
			cbbSizeChrome.SelectedValue = "default";
		}
		nudChromeScale.Value = GClass25.smethod_0("configGeneral").method_2("nudChromeScale", 100);
		cbbTocDoGoVanBan.SelectedIndex = GClass25.smethod_0("configGeneral").method_2("tocDoGoVanBan");
		ckbGologin.Checked = GClass25.smethod_0("configGeneral").method_3("ckbGologin");
		B8A56C10.Text = GClass25.smethod_0("configGeneral").C0288288("txtOrbitaPath");
		ckbGpmLogin.Checked = GClass25.smethod_0("configGeneral").method_3("ckbGpmLogin");
		EA2FA52B.Text = GClass25.smethod_0("configGeneral").C0288288("txtGpmApiUrl");
		cbbBrowserVersion.Text = GClass25.smethod_0("configGeneral").C0288288("cbbBrowserVersion", "129.0.6533.73");
		DCADBCB4.Checked = GClass25.smethod_0("configGeneral").method_3("ckbGemLogin");
		txtGemApiUrl.Text = GClass25.smethod_0("configGeneral").C0288288("txtGemApiUrl");
		D9A706B5.Checked = GClass25.smethod_0("configGeneral").method_3("ckbKhongCheckIP");
		EEA657B1.Value = GClass25.smethod_0("configGeneral").method_2("ip_nudChangeIpCount", 1);
		nudDelayCheckIP.Value = GClass25.smethod_0("configGeneral").method_2("nudDelayCheckIP");
		cbbChangeIP.SelectedValue = GClass25.smethod_0("configGeneral").C0288288("ip_iTypeChangeIp");
		if (GClass25.smethod_0("configGeneral").method_2("typeDcom") == 0)
		{
			rbDcomThuong.Checked = true;
		}
		else
		{
			rbDcomHilink.Checked = true;
		}
		txtProfileNameDcom.Text = GClass25.smethod_0("configGeneral").C0288288("ip_txtProfileNameDcom");
		txtUrlHilink.Text = GClass25.smethod_0("configGeneral").C0288288("txtUrlHilink", "http://192.168.1.1/html/home.html");
		txtNordVPN.Text = GClass25.smethod_0("configGeneral").C0288288("ip_txtNordVPN");
		cbbHostpot.SelectedIndex = GClass25.smethod_0("configGeneral").method_2("ip_cbbHostpot");
		txtServiceURLXProxy.Text = GClass25.smethod_0("configGeneral").C0288288("txtServiceURLXProxy");
		if (GClass25.smethod_0("configGeneral").method_2("typeProxy") == 0)
		{
			rbHttpProxy.Checked = true;
		}
		else
		{
			rbSock5Proxy.Checked = true;
		}
		txtListProxy.Text = GClass25.smethod_0("configGeneral").C0288288("txtListProxy");
		AF97B79E.Value = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPXProxy");
		CBB0A68E.Checked = GClass25.smethod_0("configGeneral").method_3("ckbWaitDoneAllXproxy");
		cbbTypeRunXproxy.SelectedIndex = GClass25.smethod_0("configGeneral").method_2("typeRunXproxy");
		cbbProxy.SelectedValue = GClass25.smethod_0("configGeneral").C0288288("cbbProxy", "0");
		txtProxy.Text = GClass25.smethod_0("configGeneral").C0288288("txtProxy");
		cbbProxyType.SelectedValue = GClass25.smethod_0("configGeneral").C0288288("cbbProxyType", "0");
		if (GClass25.smethod_0("configGeneral").method_2("typeMin") == 0)
		{
			rbProxyDong.Checked = true;
		}
		else
		{
			rbProxyDanCu.Checked = true;
		}
		cbbTypeProxyMin.SelectedIndex = GClass25.smethod_0("configGeneral").method_2("typeProxyMin");
		txtApiKeyMinProxy.Text = GClass25.smethod_0("configGeneral").C0288288("txtApiKeyMinProxy");
		nudLuongPerIPMinProxy.Value = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPMinProxy");
		D70B2F26.Text = GClass25.smethod_0("configGeneral").C0288288("txtLinkWebObcProxy");
		txtListObcProxy.Text = GClass25.smethod_0("configGeneral").C0288288("txtListObcProxy");
		E534B69E.Value = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPObcProxy", 1);
		CD26BF3A.SelectedIndex = GClass25.smethod_0("configGeneral").method_2("typeRunObcProxy");
		method_0();
		D18B4C95.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbGetOtpHotmailChrome");
		ckbBackupDB.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbBackupDB", bool_0: true);
		string_1 = GClass25.smethod_0("configInteractGeneral").C0288288("txtBackupDBPath");
		GClass8.smethod_32(string_1);
		if (!Directory.Exists(string_1))
		{
			string_1 = Environment.GetEnvironmentVariable("LocalAppData") + "\\database";
			GClass8.smethod_32(string_1);
		}
		cbbTypePhanBietMau.SelectedIndex = GClass25.smethod_0("configGeneral").method_2("typePhanBietMau");
		C91FC226.Checked = GClass25.smethod_0("configGeneral").method_3("ckbLuuTrangThai");
		txtTokenUnlimitMail.Text = GClass25.smethod_0("configGeneral").C0288288("txtTokenUnlimitMail");
		txtTokenDonglaomail.Text = GClass25.smethod_0("configGeneral").C0288288("txtTokenDonglaomail");
		ckbMysqlServer.Checked = GClass25.smethod_0("configGeneral").method_3("ckbMysqlServer");
		txtMysqlServer.Text = GClass25.smethod_0("configGeneral").C0288288("txtMysqlServer");
		AEA56A06 = (ckbMysqlServer.Checked ? txtMysqlServer.Text : "");
		AA0A3A10();
	}

	private void method_0()
	{
		int num = 0;
		try
		{
			num = Convert.ToInt32(cbbChangeIP.SelectedValue);
		}
		catch (Exception)
		{
		}
		if (num == 0 || num == 1 || num == 2 || num == 8 || num == 9 || num == 13 || num == 14)
		{
			return;
		}
		List<string> values = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiKey_" + num);
		int num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIP_" + num, -1);
		if (num2 == -1)
		{
			switch (num)
			{
			case 7:
				values = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiProxy");
				num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPTinsoft", 1);
				break;
			case 10:
				values = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiKeyTMProxy");
				num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPTMProxy", 1);
				break;
			case 11:
				values = GClass25.smethod_0("configGeneral").C5A69DA0("txtListProxyv6");
				num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPProxyv6", 1);
				break;
			case 12:
				values = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiShopLike");
				num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPShopLike", 1);
				break;
			default:
				num2 = 1;
				break;
			case 15:
				values = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiKeyProxyFb");
				num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPProxyFb", 1);
				break;
			case 16:
				values = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiKeyWWProxy");
				num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPWWProxy", 1);
				break;
			case 17:
				values = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiKeyKiotProxy");
				num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPKiotProxy", 1);
				break;
			case 18:
				values = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiKeyFProxy");
				num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPFProxy", 1);
				break;
			case 19:
				values = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiKeyNetProxy");
				num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPNetProxy", 1);
				break;
			case 20:
				values = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiKeyRaiProxy");
				num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPRaiProxy", 1);
				break;
			case 21:
				values = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiKeyNortonProxy");
				num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPNortonProxy", 1);
				break;
			}
		}
		E8A62C1C.Text = string.Join("\n", values);
		nudLuongPerIP.Value = num2;
	}

	private void method_1()
	{
		List<string> list = new List<string> { "Chậm", "Bình thường", "Nhanh" };
		GClass8.smethod_22(cbbTocDoGoVanBan, list);
	}

	private void D99CC99C()
	{
		List<string> list = new List<string> { "Đổi màu nền dòng", "Đổi màu chữ" };
		GClass8.smethod_22(cbbTypePhanBietMau, list);
	}

	private void method_2()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Không đổi IP");
		dictionary.Add("2", "Dcom");
		dictionary.Add("1", "HMA");
		dictionary.Add("9", "Proxy");
		dictionary.Add("13", "https://minproxy.vn/");
		dictionary.Add("19", "https://netproxy.io/");
		dictionary.Add("20", "https://raiproxy.com/");
		dictionary.Add("22", "https://fproxy.vn/");
		dictionary.Add("21", "https://nortonproxy.com/");
		dictionary.Add("17", "https://kiotproxy.com/");
		dictionary.Add("18", "https://fproxy.me/");
		dictionary.Add("16", "https://wwproxy.com/");
		dictionary.Add("15", "https://proxyfb.com/");
		dictionary.Add("7", "https://tinsoftproxy.com/");
		dictionary.Add("12", "http://proxy.shoplike.vn/");
		dictionary.Add("11", "https://proxyv6.net/");
		dictionary.Add("10", "https://tmproxy.com/");
		dictionary.Add("8", "Xproxy, Mobi, Eager, S Proxy, OBC, Proxy Machine");
		dictionary.Add("14", "OBC Proxy");
		GClass8.smethod_23(cbbChangeIP, dictionary);
		cbbChangeIP.SelectedIndexChanged += D734A982;
	}

	private void method_3()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("129.0.6533.73", "129.0.6533.73");
		dictionary.Add("127.0.6533.73", "127.0.6533.73");
		dictionary.Add("124.0.6367.29", "124.0.6367.29");
		dictionary.Add("121.0.6167.140", "121.0.6167.140");
		dictionary.Add("119.0.6045.124", "119.0.6045.124");
		GClass8.smethod_23(cbbBrowserVersion, dictionary);
	}

	private void method_4()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Đã gán vào mỗi tài khoản");
		dictionary.Add("1", "Ngẫu nhiên trong danh sách");
		GClass8.smethod_23(cbbProxy, dictionary);
	}

	private void FC1CD022()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Http");
		dictionary.Add("1", "Sock5");
		GClass8.smethod_23(cbbProxyType, dictionary);
	}

	private void D69A6C8A(object sender, EventArgs e)
	{
		try
		{
			GClass25.smethod_0("configGeneral").method_4("nudInteractThread", nudInteractThread.Value);
			GClass25.smethod_0("configGeneral").method_4("nudHideThread", nudHideThread.Value);
			GClass25.smethod_0("configGeneral").method_4("txbPathProfile", txbPathProfile.Text);
			GClass25.smethod_0("configGeneral").method_4("ckbShowImageInteract", ckbShowImageInteract.Checked);
			GClass25.smethod_0("configGeneral").method_4("ckbUseExtensionProxy", ckbUseExtensionProxy.Checked);
			GClass25.smethod_0("configGeneral").method_4("ckbDongBoMaxCare", E51ADA30.Checked);
			string text = txtPathMaxCare.Text.Trim();
			if (E51ADA30.Checked && !File.Exists(text + "\\database\\db_maxcare.sqlite"))
			{
				GClass29.smethod_0("Đươ\u0300ng dâ\u0303n MaxCare không hơ\u0323p lê\u0323!", 3);
				return;
			}
			GClass25.smethod_0("configGeneral").method_4("txtPathMaxCare", text);
			if (!E51ADA30.Checked)
			{
				text = "";
			}
			GClass25.smethod_0("configGeneral").method_4("ckbHideBrowser", EB0A133E.Checked);
			GClass25.smethod_0("configGeneral").method_4("ckbAddChromeIntoForm", ckbAddChromeIntoForm.Checked);
			GClass25.smethod_0("configGeneral").method_4("nudWidthChrome", nudWidthChrome.Value);
			GClass25.smethod_0("configGeneral").method_4("nudHeighChrome", nudHeighChrome.Value);
			GClass25.smethod_0("configGeneral").method_4("nudDelayOpenChromeFrom", DE26B731.Value);
			GClass25.smethod_0("configGeneral").method_4("nudDelayOpenChromeTo", nudDelayOpenChromeTo.Value);
			GClass25.smethod_0("configGeneral").method_4("nudDelayCloseChromeFrom", nudDelayCloseChromeFrom.Value);
			GClass25.smethod_0("configGeneral").method_4("nudDelayCloseChromeTo", nudDelayCloseChromeTo.Value);
			GClass25.smethod_0("configGeneral").method_4("ckbDelayCloseChrome", ckbDelayCloseChrome.Checked);
			GClass25.smethod_0("configGeneral").method_4("cbbColumnChrome", cbbColumnChrome.Text);
			GClass25.smethod_0("configGeneral").method_4("cbbRowChrome", cbbRowChrome.Text);
			GClass25.smethod_0("configGeneral").method_4("txtLinkToOtherBrowser", A184BE1A.Text.Trim());
			GClass25.smethod_0("configGeneral").method_4("ckbUsePortable", ckbUsePortable.Checked);
			GClass25.smethod_0("configGeneral").method_4("txtPathToPortableZip", txtPathToPortableZip.Text.Trim());
			if (cbbSizeChrome.Items.Count > 0 && cbbSizeChrome.SelectedValue.ToString() != "")
			{
				GClass25.smethod_0("configGeneral").method_4("sizeChrome", cbbSizeChrome.SelectedValue.ToString());
			}
			GClass25.smethod_0("configGeneral").method_4("nudChromeScale", nudChromeScale.Value);
			GClass25.smethod_0("configGeneral").method_4("tocDoGoVanBan", cbbTocDoGoVanBan.SelectedIndex);
			GClass25.smethod_0("configGeneral").method_4("ckbGologin", ckbGologin.Checked);
			GClass25.smethod_0("configGeneral").method_4("txtOrbitaPath", B8A56C10.Text.Trim());
			GClass25.smethod_0("configGeneral").method_4("ckbGpmLogin", ckbGpmLogin.Checked);
			GClass25.smethod_0("configGeneral").method_4("txtGpmApiUrl", EA2FA52B.Text.Trim());
			GClass25.smethod_0("configGeneral").method_4("cbbBrowserVersion", cbbBrowserVersion.Text);
			GClass25.smethod_0("configGeneral").method_4("ckbGemLogin", DCADBCB4.Checked);
			GClass25.smethod_0("configGeneral").method_4("txtGemApiUrl", txtGemApiUrl.Text.Trim());
			GClass25.smethod_0("configGeneral").method_4("ckbKhongCheckIP", D9A706B5.Checked);
			GClass25.smethod_0("configGeneral").method_4("ip_nudChangeIpCount", EEA657B1.Value);
			GClass25.smethod_0("configGeneral").method_4("nudDelayCheckIP", nudDelayCheckIP.Value);
			GClass25.smethod_0("configGeneral").method_4("ip_iTypeChangeIp", cbbChangeIP.SelectedValue);
			if (rbDcomThuong.Checked)
			{
				GClass25.smethod_0("configGeneral").method_4("typeDcom", 0);
			}
			else
			{
				GClass25.smethod_0("configGeneral").method_4("typeDcom", 1);
			}
			GClass25.smethod_0("configGeneral").method_4("txtUrlHilink", txtUrlHilink.Text);
			GClass25.smethod_0("configGeneral").method_4("ip_txtProfileNameDcom", txtProfileNameDcom.Text);
			GClass25.smethod_0("configGeneral").method_4("ip_txtNordVPN", txtNordVPN.Text);
			GClass25.smethod_0("configGeneral").method_4("ip_cbbHostpot", cbbHostpot.SelectedIndex);
			GClass25.smethod_0("configGeneral").method_4("txtServiceURLXProxy", txtServiceURLXProxy.Text);
			int num = 0;
			if (rbSock5Proxy.Checked)
			{
				num = 1;
			}
			GClass25.smethod_0("configGeneral").method_4("typeProxy", num);
			GClass25.smethod_0("configGeneral").method_4("txtListProxy", txtListProxy.Text);
			GClass25.smethod_0("configGeneral").method_4("nudLuongPerIPXProxy", AF97B79E.Value);
			GClass25.smethod_0("configGeneral").method_4("ckbWaitDoneAllXproxy", CBB0A68E.Checked);
			GClass25.smethod_0("configGeneral").method_4("typeRunXproxy", cbbTypeRunXproxy.SelectedIndex);
			GClass25.smethod_0("configGeneral").method_4("cbbProxy", cbbProxy.SelectedValue);
			GClass25.smethod_0("configGeneral").method_4("txtProxy", txtProxy.Text);
			GClass25.smethod_0("configGeneral").method_4("cbbProxyType", cbbProxyType.SelectedValue);
			int num2 = 0;
			if (rbProxyDanCu.Checked)
			{
				num2 = 1;
			}
			GClass25.smethod_0("configGeneral").method_4("typeMin", cbbTypeRunXproxy.SelectedIndex);
			GClass25.smethod_0("configGeneral").method_4("typeMin", num2);
			GClass25.smethod_0("configGeneral").method_4("typeProxyMin", cbbTypeProxyMin.SelectedIndex);
			GClass25.smethod_0("configGeneral").method_4("txtApiKeyMinProxy", txtApiKeyMinProxy.Text);
			GClass25.smethod_0("configGeneral").method_4("nudLuongPerIPMinProxy", nudLuongPerIPMinProxy.Value);
			GClass25.smethod_0("configGeneral").method_4("txtLinkWebObcProxy", D70B2F26.Text);
			GClass25.smethod_0("configGeneral").method_4("txtListObcProxy", txtListObcProxy.Text);
			GClass25.smethod_0("configGeneral").method_4("nudLuongPerIPObcProxy", E534B69E.Value);
			GClass25.smethod_0("configGeneral").method_4("typeRunObcProxy", CD26BF3A.SelectedIndex);
			GClass25.smethod_0("configGeneral").method_4("txtApiKey_" + cbbChangeIP.SelectedValue, E8A62C1C.Text);
			GClass25.smethod_0("configGeneral").method_4("nudLuongPerIP_" + cbbChangeIP.SelectedValue, nudLuongPerIP.Value);
			GClass25.smethod_0("configInteractGeneral").method_4("ckbGetOtpHotmailChrome", D18B4C95.Checked);
			GClass25.smethod_0("configInteractGeneral").method_4("ckbBackupDB", ckbBackupDB.Checked);
			GClass25.smethod_0("configInteractGeneral").method_4("txtBackupDBPath", string_1);
			GClass25.smethod_0("configInteractGeneral").method_6();
			GClass25.smethod_0("configGeneral").method_4("typePhanBietMau", cbbTypePhanBietMau.SelectedIndex);
			GClass25.smethod_0("configGeneral").method_4("ckbLuuTrangThai", C91FC226.Checked);
			Class81.bool_0 = C91FC226.Checked;
			GClass25.smethod_0("configGeneral").method_4("txtTokenUnlimitMail", txtTokenUnlimitMail.Text);
			GClass25.smethod_0("configGeneral").method_4("txtTokenDonglaomail", txtTokenDonglaomail.Text);
			GClass25.smethod_0("configGeneral").method_4("ckbMysqlServer", ckbMysqlServer.Checked);
			string text2 = txtMysqlServer.Text.Trim();
			if (ckbMysqlServer.Checked && txtMysqlServer.Text.Trim() == "")
			{
				GClass29.smethod_0("Vui lòng nhập MysqlServer!", 3);
				return;
			}
			GClass25.smethod_0("configGeneral").method_4("txtMysqlServer", text2);
			if (!ckbMysqlServer.Checked)
			{
				text2 = "";
			}
			GClass25.B3B73732("configGeneral");
			if (GClass29.smethod_1("Lưu thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?") == DialogResult.Yes)
			{
				Close();
			}
			if (string_0 != text || AEA56A06 != text2)
			{
				Class57.string_0 = Class57.smethod_0();
				B223510E.method_4("isChangePathDatabase", true);
			}
		}
		catch
		{
			GClass29.smethod_0("Lỗi!");
		}
	}

	private void button5_Click(object sender, EventArgs e)
	{
		if (Convert.ToInt32(cbbChangeIP.SelectedValue) == 0)
		{
			GClass29.smethod_0("Vui lòng chọn loại đổi IP", 3);
			return;
		}
		int fE88690E = 0;
		if (rbDcomHilink.Checked)
		{
			fE88690E = 1;
		}
		if (GClass8.DB05192A(Convert.ToInt32(cbbChangeIP.SelectedValue), fE88690E, txtProfileNameDcom.Text.Trim(), txtUrlHilink.Text.Trim(), cbbHostpot.SelectedIndex, txtNordVPN.Text.Trim()))
		{
			GClass29.smethod_0("Đổi IP thành công!");
		}
		else
		{
			GClass29.smethod_0("Đổi IP thất bại!", 2);
		}
	}

	private void btnSSH_Click(object sender, EventArgs e)
	{
		Process.Start("changeip\\ssh.txt");
	}

	private void B82C2691(object sender, EventArgs e)
	{
		panel2.Enabled = rbNordVPN.Checked;
	}

	private void AA0A3A10()
	{
		ckbAddChromeIntoForm_CheckedChanged(null, null);
		E5251224(null, null);
		rbDcomHilink_CheckedChanged(null, null);
		rbDcomThuong_CheckedChanged(null, null);
		ckbDelayCloseChrome_CheckedChanged(null, null);
		E51ADA30_CheckedChanged(null, null);
		rbProxyDanCu_CheckedChanged(null, null);
		D3AD878F(null, null);
		BEB56D19(null, null);
		CE373314(null, null);
		txtListProxy_TextChanged(null, null);
		C7B31609(null, null);
		txtApiKeyMinProxy_TextChanged(null, null);
		method_5(null, null);
		txtProxy_TextChanged(null, null);
		ED3875B2(null, null);
		ckbGpmLogin_CheckedChanged(null, null);
		DCADBCB4_CheckedChanged(null, null);
	}

	private void F30AB03C(object sender, EventArgs e)
	{
		try
		{
			ProcessStartInfo startInfo = new ProcessStartInfo("rasdial.exe")
			{
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			};
			Process process = Process.Start(startInfo);
			string text = process.StandardOutput.ReadToEnd();
			if (text.Split('\n').Length <= 3)
			{
				GClass29.smethod_0("Vui lòng kết nối Dcom trước!", 2);
				return;
			}
			txtProfileNameDcom.Text = text.Split('\n').ToList()[1];
			GClass29.smethod_0("Lấy tên cấu hình Dcom thành công!");
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA, "change ip dcom");
			GClass29.smethod_0("Có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void C48C2237(object sender, EventArgs e)
	{
		if (((e as MouseEventArgs).Button != MouseButtons.Right || Control.ModifierKeys != Keys.Control) && (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Alt)
		{
			AE0FFF89.Visible = false;
		}
	}

	private void A8A80421(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			CBB0A68E.Visible = true;
		}
	}

	private void AddFileAccount_Click(object sender, EventArgs e)
	{
	}

	private void A1074D92()
	{
	}

	private void txtListProxy_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtListProxy.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			B125179D.Text = string.Format(F7AB102E.smethod_0("Nhập Proxy ({0}):"), e03C713E.Count.ToString());
		}
		catch
		{
		}
	}

	private void txtPathToPortableZip_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			Process.Start(txbPathProfile.Text.Trim());
		}
	}

	private void ckbAddChromeIntoForm_CheckedChanged(object sender, EventArgs e)
	{
		FAB3AA84.Enabled = ckbAddChromeIntoForm.Checked;
		plSapXepCuaSoChrome.Enabled = !ckbAddChromeIntoForm.Checked;
	}

	private void D238682D_Paint(object sender, PaintEventArgs e)
	{
	}

	private void E5251224(object sender, EventArgs e)
	{
		B213D1B8.Enabled = ckbUsePortable.Checked;
		txtPathToPortableZip.Enabled = ckbUsePortable.Checked;
	}

	private void panel3_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			D238682D.BringToFront();
		}
	}

	private void rbDcomThuong_CheckedChanged(object sender, EventArgs e)
	{
		button4.Enabled = rbDcomThuong.Checked;
		txtProfileNameDcom.Enabled = rbDcomThuong.Checked;
	}

	private void rbDcomHilink_CheckedChanged(object sender, EventArgs e)
	{
		FE23060C.Enabled = rbDcomHilink.Checked;
		txtUrlHilink.Enabled = rbDcomHilink.Checked;
	}

	private void method_5(object sender, EventArgs e)
	{
	}

	private void txtListProxyVitech_TextChanged(object sender, EventArgs e)
	{
		List<string> e03C713E = txtListProxyVitech.Lines.ToList();
		e03C713E = GClass8.smethod_36(e03C713E);
		label41.Text = string.Format(F7AB102E.smethod_0("Nhập Proxy ({0}):"), e03C713E.Count.ToString());
	}

	private void E0A14EB1(object sender, PaintEventArgs e)
	{
	}

	private void txbPathProfile_TextChanged(object sender, EventArgs e)
	{
	}

	private void txtApiKeyMinProxy_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtApiKeyMinProxy, label49);
	}

	private void button10_Click(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		List<string> e03C713E = txtApiKeyMinProxy.Lines.ToList();
		e03C713E = GClass8.smethod_36(e03C713E);
		int int_ = 0;
		if (rbProxyDanCu.Checked)
		{
			int_ = 1;
		}
		foreach (string item in e03C713E)
		{
			if (D0AA71A1.FE03F5BE(int_, item))
			{
				list.Add(item);
			}
		}
		txtApiKeyMinProxy.Lines = list.ToArray();
		if (list.Count > 0)
		{
			GClass29.smethod_0(string.Format(F7AB102E.smethod_0("Đang có {0} proxy khả dụng!"), list.Count));
		}
		else
		{
			GClass29.smethod_0("Không có proxy khả dụng!", 2);
		}
	}

	private void C7B31609(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtListObcProxy, C4959598);
	}

	private void rbProxyDanCu_CheckedChanged(object sender, EventArgs e)
	{
		plTypeProxy.Enabled = rbProxyDanCu.Checked;
	}

	private void ckbDelayCloseChrome_CheckedChanged(object sender, EventArgs e)
	{
		plDelayCloseChrome.Enabled = ckbDelayCloseChrome.Checked;
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			EB0A133E.Visible = true;
			lblChromeScale.Visible = true;
			nudChromeScale.Visible = true;
		}
		grCauHinhChrome.Height = 309;
	}

	private void F014E611(object sender, EventArgs e)
	{
		grCauHinhChrome.Height = 137;
	}

	private void C923B88E_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			grCauHinhChung.Height = 159;
		}
		else
		{
			grCauHinhChung.Height = 111;
		}
	}

	private void D49F1407_Click(object sender, EventArgs e)
	{
		grCauHinhChung.Height = 53;
	}

	private void D330E488(object sender, EventArgs e)
	{
		FBA38325.Visible = true;
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			DD824319.Visible = true;
		}
	}

	private void D734A982(object sender, EventArgs e)
	{
		if (cbbChangeIP.SelectedValue == null)
		{
			return;
		}
		object selectedValue = cbbChangeIP.SelectedValue;
		object obj = selectedValue;
		string text = obj as string;
		if (text != null)
		{
			uint num = C43AF739.smethod_0(text);
			if (num <= 873244444)
			{
				if (num != 401286136)
				{
					if (num != 518729469)
					{
						if (num == 873244444 && text == "1")
						{
							goto IL_0116;
						}
					}
					else if (text == "13")
					{
						tabChangeIP.SelectedTab = B1A94238;
						goto IL_0194;
					}
				}
				else if (text == "14")
				{
					tabChangeIP.SelectedTab = tabObcProxy;
					goto IL_0194;
				}
			}
			else
			{
				if (num > 923577301)
				{
					if (num != 1007465396)
					{
						if (num != 1024243015 || !(text == "8"))
						{
							goto IL_017d;
						}
						tabChangeIP.SelectedTab = A796A8A8;
					}
					else
					{
						if (!(text == "9"))
						{
							goto IL_017d;
						}
						tabChangeIP.SelectedTab = tabProxy;
					}
					goto IL_0194;
				}
				if (num != 890022063)
				{
					if (num == 923577301 && text == "2")
					{
						tabChangeIP.SelectedTab = AA2E82A1;
						goto IL_0194;
					}
				}
				else if (text == "0")
				{
					goto IL_0116;
				}
			}
		}
		goto IL_017d;
		IL_0116:
		tabChangeIP.SelectedTab = tabNone;
		goto IL_0194;
		IL_017d:
		tabChangeIP.SelectedTab = tabProxyWeb;
		method_0();
		goto IL_0194;
		IL_0194:
		C3B1BB87.Enabled = cbbChangeIP.SelectedValue.ToString() == "1" || cbbChangeIP.SelectedValue.ToString() == "2";
	}

	private void E51ADA30_CheckedChanged(object sender, EventArgs e)
	{
		plDongBoMaxCare.Enabled = E51ADA30.Checked;
	}

	private void FB9F8518(object sender, EventArgs e)
	{
		try
		{
			if (cbbProxy.SelectedValue != null)
			{
				plTuyChonProxy.Enabled = cbbProxy.SelectedValue.ToString() == "1";
			}
		}
		catch (Exception)
		{
		}
	}

	private void txtProxy_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtProxy, label33);
	}

	private void DD824319_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fCauHinhDomainGenerator());
	}

	private void A6A6CA1E_Click(object sender, EventArgs e)
	{
		if (GClass29.smethod_1("Bạn có muốn cập nhật ChromeDriver không?") != DialogResult.Yes)
		{
			return;
		}
		try
		{
			GClass8.smethod_41("chromedriver");
			string text = GClass8.smethod_74();
			if (!(text == ""))
			{
				string text2 = "";
				string input = new F3958F9B().method_0("https://api.nuget.org/v3-flatcontainer/Selenium.WebDriver.ChromeDriver/index.json");
				foreach (Match item in Regex.Matches(input, "\"(\\d+\\.0\\.\\d+\\.\\d+)\""))
				{
					if (item.Groups[1].Value == text || item.Groups[1].Value.StartsWith(text.Split('.')[0]))
					{
						text2 = item.Groups[1].Value;
						break;
					}
				}
				if (!(text2 == ""))
				{
					GClass8.smethod_71(GClass28.smethod_0() + "\\chromedriver.exe");
					string fFBFAE8D = "https://api.nuget.org/v3-flatcontainer/Selenium.WebDriver.ChromeDriver/" + text2 + "/selenium.webdriver.chromedriver." + text2 + ".nupkg";
					GClass8.smethod_13(fFBFAE8D);
					GClass29.smethod_0("Cập nhật ChromeDriver thành công!");
					return;
				}
			}
		}
		catch
		{
		}
		GClass29.smethod_0("Cập nhật ChromeDriver thất bại!", 2);
	}

	private void D132643A_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = GClass8.smethod_40(string_1);
		if (text != "")
		{
			string_1 = text;
		}
	}

	private void D3AD878F(object sender, EventArgs e)
	{
		D132643A.Enabled = ckbBackupDB.Checked;
	}

	private void BEB56D19(object sender, EventArgs e)
	{
		BE32A023.Enabled = ckbGologin.Checked;
		method_6(sender as CheckBox);
	}

	private void B51DA58E(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.smethod_13("https://s3-hcm5-r1.longvan.net/19425302-download.minsoftware.vn/download/gologin.zip");
		if (File.Exists(GClass28.smethod_0() + "\\orbita-browser\\chrome.exe"))
		{
			B8A56C10.Text = GClass28.smethod_0() + "\\orbita-browser\\chrome.exe";
		}
	}

	private void CE373314(object sender, EventArgs e)
	{
		txtMysqlServer.Enabled = ckbMysqlServer.Checked;
		if (ckbMysqlServer.Checked)
		{
			ckbBackupDB.Checked = false;
			ckbBackupDB.Enabled = false;
		}
		else
		{
			ckbBackupDB.Enabled = true;
		}
	}

	private void ED3875B2(object sender, EventArgs e)
	{
		GClass8.smethod_60(E8A62C1C, lblApiKeyProxy);
	}

	private void ckbGpmLogin_CheckedChanged(object sender, EventArgs e)
	{
		plGpmLogin.Enabled = ckbGpmLogin.Checked;
		method_6(sender as CheckBox);
	}

	private void method_6(CheckBox checkBox_0)
	{
		if (checkBox_0 == null || !checkBox_0.Checked)
		{
			return;
		}
		foreach (CheckBox item in list_0)
		{
			if (item != checkBox_0)
			{
				item.Checked = false;
			}
		}
	}

	private void D8BEB100(object sender, EventArgs e)
	{
		bool flag = false;
		try
		{
			string text = EA2FA52B.Text.Trim();
			string text2 = new F3958F9B().method_0(text.TrimEnd('/') + "/api/v3/profiles");
			if (text2 != "")
			{
				flag = true;
			}
		}
		catch (Exception)
		{
		}
		GClass29.smethod_0("Connect " + (flag ? "Success" : "Fail") + "!", flag ? 1 : 2);
	}

	private void button11_Click(object sender, EventArgs e)
	{
		bool flag = false;
		try
		{
			string text = txtGemApiUrl.Text.Trim();
			string text2 = new F3958F9B().method_0(text.TrimEnd('/') + "/api/profiles");
			if (text2 != "")
			{
				flag = true;
			}
		}
		catch (Exception ex)
		{
			GClass29.smethod_0(ex.ToString());
		}
		GClass29.smethod_0("Connect " + (flag ? "Success" : "Fail") + "!", flag ? 1 : 2);
	}

	private void DCADBCB4_CheckedChanged(object sender, EventArgs e)
	{
		D1269480.Enabled = DCADBCB4.Checked;
		method_6(sender as CheckBox);
	}

	protected override void Dispose(bool A70C7EB9)
	{
		if (A70C7EB9 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(A70C7EB9);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhChung));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		label3 = new System.Windows.Forms.Label();
		nudInteractThread = new System.Windows.Forms.NumericUpDown();
		label4 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		nudHideThread = new System.Windows.Forms.NumericUpDown();
		label6 = new System.Windows.Forms.Label();
		D42AFB34 = new System.Windows.Forms.Label();
		txbPathProfile = new System.Windows.Forms.TextBox();
		panel1 = new System.Windows.Forms.Panel();
		groupBox3 = new System.Windows.Forms.GroupBox();
		tabChangeIP = new System.Windows.Forms.TabControl();
		tabNone = new System.Windows.Forms.TabPage();
		panel16 = new System.Windows.Forms.Panel();
		tabProxy = new System.Windows.Forms.TabPage();
		plTuyChonProxy = new System.Windows.Forms.Panel();
		cbbProxyType = new System.Windows.Forms.ComboBox();
		F8B84EB1 = new System.Windows.Forms.Label();
		label33 = new System.Windows.Forms.Label();
		txtProxy = new System.Windows.Forms.RichTextBox();
		cbbProxy = new System.Windows.Forms.ComboBox();
		CDAA4326 = new System.Windows.Forms.Label();
		AA2E82A1 = new System.Windows.Forms.TabPage();
		F61EF227 = new System.Windows.Forms.Panel();
		button4 = new System.Windows.Forms.Button();
		txtUrlHilink = new System.Windows.Forms.TextBox();
		txtProfileNameDcom = new System.Windows.Forms.TextBox();
		rbDcomHilink = new System.Windows.Forms.RadioButton();
		FE23060C = new System.Windows.Forms.Label();
		rbDcomThuong = new System.Windows.Forms.RadioButton();
		A796A8A8 = new System.Windows.Forms.TabPage();
		plXproxy = new System.Windows.Forms.Panel();
		label53 = new System.Windows.Forms.Label();
		CBB0A68E = new System.Windows.Forms.CheckBox();
		cbbTypeRunXproxy = new System.Windows.Forms.ComboBox();
		txtListProxy = new System.Windows.Forms.RichTextBox();
		rbSock5Proxy = new System.Windows.Forms.RadioButton();
		rbHttpProxy = new System.Windows.Forms.RadioButton();
		DC0CE7BC = new System.Windows.Forms.Label();
		B125179D = new System.Windows.Forms.Label();
		F5B33A1A = new System.Windows.Forms.Label();
		AF97B79E = new System.Windows.Forms.NumericUpDown();
		label13 = new System.Windows.Forms.Label();
		txtServiceURLXProxy = new System.Windows.Forms.TextBox();
		tabObcProxy = new System.Windows.Forms.TabPage();
		F99B120B = new System.Windows.Forms.Panel();
		CD26BF3A = new System.Windows.Forms.ComboBox();
		A8817A07 = new System.Windows.Forms.Label();
		rbObcSock5Proxy = new System.Windows.Forms.RadioButton();
		rbObcHttpProxy = new System.Windows.Forms.RadioButton();
		label55 = new System.Windows.Forms.Label();
		txtListObcProxy = new System.Windows.Forms.RichTextBox();
		C4959598 = new System.Windows.Forms.Label();
		label69 = new System.Windows.Forms.Label();
		E534B69E = new System.Windows.Forms.NumericUpDown();
		C539AA1A = new System.Windows.Forms.Label();
		D70B2F26 = new System.Windows.Forms.TextBox();
		B1A94238 = new System.Windows.Forms.TabPage();
		panel5 = new System.Windows.Forms.Panel();
		rbProxyDanCu = new System.Windows.Forms.RadioButton();
		rbProxyDong = new System.Windows.Forms.RadioButton();
		button10 = new System.Windows.Forms.Button();
		txtApiKeyMinProxy = new System.Windows.Forms.RichTextBox();
		label49 = new System.Windows.Forms.Label();
		label50 = new System.Windows.Forms.Label();
		plTypeProxy = new System.Windows.Forms.Panel();
		cbbTypeProxyMin = new System.Windows.Forms.ComboBox();
		FD36AF17 = new System.Windows.Forms.Label();
		nudLuongPerIPMinProxy = new System.Windows.Forms.NumericUpDown();
		tabProxyWeb = new System.Windows.Forms.TabPage();
		E8A62C1C = new System.Windows.Forms.RichTextBox();
		lblApiKeyProxy = new System.Windows.Forms.Label();
		label65 = new System.Windows.Forms.Label();
		nudLuongPerIP = new System.Windows.Forms.NumericUpDown();
		cbbChangeIP = new System.Windows.Forms.ComboBox();
		label15 = new System.Windows.Forms.Label();
		BB8D0B22 = new System.Windows.Forms.Label();
		nudDelayCheckIP = new System.Windows.Forms.NumericUpDown();
		label38 = new System.Windows.Forms.Label();
		C3B1BB87 = new System.Windows.Forms.Panel();
		button5 = new System.Windows.Forms.Button();
		label26 = new System.Windows.Forms.Label();
		EEA657B1 = new System.Windows.Forms.NumericUpDown();
		C8A53894 = new System.Windows.Forms.Label();
		D9A706B5 = new System.Windows.Forms.CheckBox();
		grCauHinhChung = new System.Windows.Forms.GroupBox();
		plDongBoMaxCare = new System.Windows.Forms.Panel();
		label22 = new System.Windows.Forms.Label();
		txtPathMaxCare = new System.Windows.Forms.TextBox();
		E51ADA30 = new System.Windows.Forms.CheckBox();
		C923B88E = new System.Windows.Forms.Button();
		D49F1407 = new System.Windows.Forms.Button();
		grCauHinhChrome = new System.Windows.Forms.GroupBox();
		D1269480 = new System.Windows.Forms.Panel();
		button11 = new System.Windows.Forms.Button();
		txtGemApiUrl = new System.Windows.Forms.TextBox();
		label62 = new System.Windows.Forms.Label();
		DCADBCB4 = new System.Windows.Forms.CheckBox();
		plGpmLogin = new System.Windows.Forms.Panel();
		EEB05838 = new System.Windows.Forms.Button();
		EA2FA52B = new System.Windows.Forms.TextBox();
		E5805987 = new System.Windows.Forms.Label();
		cbbBrowserVersion = new System.Windows.Forms.ComboBox();
		label68 = new System.Windows.Forms.Label();
		ckbGpmLogin = new System.Windows.Forms.CheckBox();
		BE32A023 = new System.Windows.Forms.Panel();
		B8A56C10 = new System.Windows.Forms.TextBox();
		CE8CD509 = new System.Windows.Forms.LinkLabel();
		label51 = new System.Windows.Forms.Label();
		A6A6CA1E = new System.Windows.Forms.Button();
		AE0FFF89 = new System.Windows.Forms.Panel();
		nudDelayOpenChromeTo = new System.Windows.Forms.NumericUpDown();
		DE26B731 = new System.Windows.Forms.NumericUpDown();
		label20 = new System.Windows.Forms.Label();
		plDelayCloseChrome = new System.Windows.Forms.Panel();
		nudDelayCloseChromeTo = new System.Windows.Forms.NumericUpDown();
		nudDelayCloseChromeFrom = new System.Windows.Forms.NumericUpDown();
		label2 = new System.Windows.Forms.Label();
		label29 = new System.Windows.Forms.Label();
		ckbDelayCloseChrome = new System.Windows.Forms.CheckBox();
		btnDown = new System.Windows.Forms.Button();
		D027A8A9 = new System.Windows.Forms.Button();
		cbbTocDoGoVanBan = new System.Windows.Forms.ComboBox();
		label30 = new System.Windows.Forms.Label();
		plSapXepCuaSoChrome = new System.Windows.Forms.Panel();
		cbbColumnChrome = new System.Windows.Forms.ComboBox();
		label10 = new System.Windows.Forms.Label();
		cbbRowChrome = new System.Windows.Forms.ComboBox();
		label11 = new System.Windows.Forms.Label();
		nudChromeScale = new System.Windows.Forms.NumericUpDown();
		FAB3AA84 = new System.Windows.Forms.Panel();
		nudWidthChrome = new System.Windows.Forms.NumericUpDown();
		nudHeighChrome = new System.Windows.Forms.NumericUpDown();
		EC82A387 = new System.Windows.Forms.Label();
		lblChromeScale = new System.Windows.Forms.Label();
		AddFileAccount = new System.Windows.Forms.Button();
		ckbGologin = new System.Windows.Forms.CheckBox();
		ckbUseExtensionProxy = new System.Windows.Forms.CheckBox();
		EB0A133E = new System.Windows.Forms.CheckBox();
		ckbShowImageInteract = new System.Windows.Forms.CheckBox();
		ckbAddChromeIntoForm = new System.Windows.Forms.CheckBox();
		cbbSizeChrome = new System.Windows.Forms.ComboBox();
		EE983832 = new System.Windows.Forms.Label();
		panel3 = new System.Windows.Forms.Panel();
		D98C5BB4 = new System.Windows.Forms.Label();
		A184BE1A = new System.Windows.Forms.TextBox();
		D238682D = new System.Windows.Forms.Panel();
		txtPathToPortableZip = new System.Windows.Forms.TextBox();
		B213D1B8 = new System.Windows.Forms.Label();
		ckbUsePortable = new System.Windows.Forms.CheckBox();
		grEmailConfigs = new System.Windows.Forms.GroupBox();
		label31 = new System.Windows.Forms.Label();
		BC1D18BF = new System.Windows.Forms.Panel();
		label57 = new System.Windows.Forms.Label();
		txtTokenUnlimitMail = new System.Windows.Forms.TextBox();
		F795862C = new System.Windows.Forms.Label();
		FE01E21E = new System.Windows.Forms.Panel();
		D18B4C95 = new System.Windows.Forms.CheckBox();
		BF98EA14 = new System.Windows.Forms.Label();
		D5154C8C = new System.Windows.Forms.Label();
		CF2A9AA2 = new System.Windows.Forms.Panel();
		D6AB5A82 = new System.Windows.Forms.Label();
		DD824319 = new System.Windows.Forms.Button();
		FBA38325 = new System.Windows.Forms.Panel();
		D33B3D3E = new System.Windows.Forms.Label();
		txtTokenDonglaomail = new System.Windows.Forms.TextBox();
		txtMysqlServer = new System.Windows.Forms.TextBox();
		grCauHinhKhac = new System.Windows.Forms.GroupBox();
		D132643A = new System.Windows.Forms.LinkLabel();
		ckbBackupDB = new System.Windows.Forms.CheckBox();
		C91FC226 = new System.Windows.Forms.CheckBox();
		cbbTypePhanBietMau = new System.Windows.Forms.ComboBox();
		C28D9186 = new System.Windows.Forms.Label();
		plVitech = new System.Windows.Forms.Panel();
		txtListProxyVitech = new System.Windows.Forms.RichTextBox();
		D60D659C = new System.Windows.Forms.RadioButton();
		radioButton10 = new System.Windows.Forms.RadioButton();
		label40 = new System.Windows.Forms.Label();
		label41 = new System.Windows.Forms.Label();
		label42 = new System.Windows.Forms.Label();
		nudLuongPerIPVitech = new System.Windows.Forms.NumericUpDown();
		label46 = new System.Windows.Forms.Label();
		txtApiVitech = new System.Windows.Forms.TextBox();
		cbbHostpot = new System.Windows.Forms.ComboBox();
		ckbMysqlServer = new System.Windows.Forms.CheckBox();
		C7B4508F = new System.Windows.Forms.RadioButton();
		A200A21D = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		CA3ADC0D = new System.Windows.Forms.Button();
		B7B5A3AC = new System.Windows.Forms.PictureBox();
		B49F18BB = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		panel2 = new System.Windows.Forms.Panel();
		label12 = new System.Windows.Forms.Label();
		ABB4F9A6 = new System.Windows.Forms.TextBox();
		btnSave = new System.Windows.Forms.Button();
		FF152B09 = new System.Windows.Forms.Panel();
		B9B6C73C = new System.Windows.Forms.Label();
		txtNordVPN = new System.Windows.Forms.TextBox();
		btnSSH = new System.Windows.Forms.Button();
		radioButton4 = new System.Windows.Forms.RadioButton();
		rbHotspot = new System.Windows.Forms.RadioButton();
		CD04A99E = new System.Windows.Forms.RadioButton();
		rbNordVPN = new System.Windows.Forms.RadioButton();
		radioButton2 = new System.Windows.Forms.RadioButton();
		rbSSH = new System.Windows.Forms.RadioButton();
		radioButton3 = new System.Windows.Forms.RadioButton();
		C49ACD35 = new System.Windows.Forms.RadioButton();
		BD3BF494 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		CDADBC94 = new System.Windows.Forms.ToolTip(icontainer_0);
		((System.ComponentModel.ISupportInitialize)nudInteractThread).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudHideThread).BeginInit();
		panel1.SuspendLayout();
		groupBox3.SuspendLayout();
		tabChangeIP.SuspendLayout();
		tabNone.SuspendLayout();
		tabProxy.SuspendLayout();
		plTuyChonProxy.SuspendLayout();
		AA2E82A1.SuspendLayout();
		F61EF227.SuspendLayout();
		A796A8A8.SuspendLayout();
		plXproxy.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)AF97B79E).BeginInit();
		tabObcProxy.SuspendLayout();
		F99B120B.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)E534B69E).BeginInit();
		B1A94238.SuspendLayout();
		panel5.SuspendLayout();
		plTypeProxy.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudLuongPerIPMinProxy).BeginInit();
		tabProxyWeb.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudLuongPerIP).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayCheckIP).BeginInit();
		C3B1BB87.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)EEA657B1).BeginInit();
		grCauHinhChung.SuspendLayout();
		plDongBoMaxCare.SuspendLayout();
		grCauHinhChrome.SuspendLayout();
		D1269480.SuspendLayout();
		plGpmLogin.SuspendLayout();
		BE32A023.SuspendLayout();
		AE0FFF89.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayOpenChromeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)DE26B731).BeginInit();
		plDelayCloseChrome.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayCloseChromeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayCloseChromeFrom).BeginInit();
		plSapXepCuaSoChrome.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudChromeScale).BeginInit();
		FAB3AA84.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudWidthChrome).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudHeighChrome).BeginInit();
		panel3.SuspendLayout();
		D238682D.SuspendLayout();
		grEmailConfigs.SuspendLayout();
		BC1D18BF.SuspendLayout();
		FE01E21E.SuspendLayout();
		CF2A9AA2.SuspendLayout();
		FBA38325.SuspendLayout();
		grCauHinhKhac.SuspendLayout();
		plVitech.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudLuongPerIPVitech).BeginInit();
		A200A21D.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)B7B5A3AC).BeginInit();
		panel2.SuspendLayout();
		FF152B09.SuspendLayout();
		SuspendLayout();
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 5;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(476, 38);
		bunifuCards1.TabIndex = 12;
		label3.AutoSize = true;
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(32, 26);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(111, 16);
		label3.TabIndex = 23;
		label3.Text = "Số luồng Chrome:";
		nudInteractThread.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		nudInteractThread.Location = new System.Drawing.Point(173, 24);
		nudInteractThread.Maximum = new decimal(new int[4] { 1410065407, 2, 0, 0 });
		nudInteractThread.Name = "nudInteractThread";
		nudInteractThread.Size = new System.Drawing.Size(89, 23);
		nudInteractThread.TabIndex = 24;
		label4.AutoSize = true;
		label4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label4.Location = new System.Drawing.Point(265, 26);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(41, 16);
		label4.TabIndex = 25;
		label4.Text = "Luồng";
		label5.AutoSize = true;
		label5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label5.Location = new System.Drawing.Point(265, 55);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(41, 16);
		label5.TabIndex = 28;
		label5.Text = "Luồng";
		nudHideThread.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		nudHideThread.Location = new System.Drawing.Point(173, 53);
		nudHideThread.Maximum = new decimal(new int[4] { 1410065407, 2, 0, 0 });
		nudHideThread.Name = "nudHideThread";
		nudHideThread.Size = new System.Drawing.Size(89, 23);
		nudHideThread.TabIndex = 27;
		label6.AutoSize = true;
		label6.Cursor = System.Windows.Forms.Cursors.Help;
		label6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label6.Location = new System.Drawing.Point(32, 55);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(125, 16);
		label6.TabIndex = 26;
		label6.Text = "Số luồng Check info:";
		CDADBC94.SetToolTip(label6, "La\u0300 sô\u0301 luô\u0300ng khi cha\u0323y ca\u0301c chư\u0301c năng không liên quan gi\u0300 đê\u0301n tri\u0300nh duyê\u0323t.\r\nVi\u0301 du\u0323 như: Check wall, Check Avatar,...\r\n(Khuyê\u0301n ca\u0301o nên đê\u0309 10 luô\u0300ng)");
		D42AFB34.AutoSize = true;
		D42AFB34.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D42AFB34.Location = new System.Drawing.Point(32, 85);
		D42AFB34.Name = "label9";
		D42AFB34.Size = new System.Drawing.Size(94, 16);
		D42AFB34.TabIndex = 33;
		D42AFB34.Text = "Folder profiles:";
		txbPathProfile.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		txbPathProfile.Location = new System.Drawing.Point(173, 82);
		txbPathProfile.Name = "txbPathProfile";
		txbPathProfile.Size = new System.Drawing.Size(386, 23);
		txbPathProfile.TabIndex = 32;
		txbPathProfile.Click += new System.EventHandler(txtPathToPortableZip_Click);
		txbPathProfile.TextChanged += new System.EventHandler(txbPathProfile_TextChanged);
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(groupBox3);
		panel1.Controls.Add(grCauHinhChung);
		panel1.Controls.Add(grCauHinhChrome);
		panel1.Controls.Add(grEmailConfigs);
		panel1.Controls.Add(txtMysqlServer);
		panel1.Controls.Add(grCauHinhKhac);
		panel1.Controls.Add(plVitech);
		panel1.Controls.Add(cbbHostpot);
		panel1.Controls.Add(ckbMysqlServer);
		panel1.Controls.Add(C7B4508F);
		panel1.Controls.Add(A200A21D);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(panel2);
		panel1.Controls.Add(btnSave);
		panel1.Controls.Add(FF152B09);
		panel1.Controls.Add(btnSSH);
		panel1.Controls.Add(radioButton4);
		panel1.Controls.Add(rbHotspot);
		panel1.Controls.Add(CD04A99E);
		panel1.Controls.Add(rbNordVPN);
		panel1.Controls.Add(radioButton2);
		panel1.Controls.Add(rbSSH);
		panel1.Controls.Add(radioButton3);
		panel1.Controls.Add(C49ACD35);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(1059, 460);
		panel1.TabIndex = 37;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(E0A14EB1);
		groupBox3.Controls.Add(tabChangeIP);
		groupBox3.Controls.Add(cbbChangeIP);
		groupBox3.Controls.Add(label15);
		groupBox3.Controls.Add(BB8D0B22);
		groupBox3.Controls.Add(nudDelayCheckIP);
		groupBox3.Controls.Add(label38);
		groupBox3.Controls.Add(C3B1BB87);
		groupBox3.Controls.Add(D9A706B5);
		groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		groupBox3.Location = new System.Drawing.Point(580, 38);
		groupBox3.Name = "groupBox3";
		groupBox3.Size = new System.Drawing.Size(471, 289);
		groupBox3.TabIndex = 39;
		groupBox3.TabStop = false;
		groupBox3.Text = "Cấu hình đổi IP";
		tabChangeIP.Alignment = System.Windows.Forms.TabAlignment.Bottom;
		tabChangeIP.Controls.Add(tabNone);
		tabChangeIP.Controls.Add(tabProxy);
		tabChangeIP.Controls.Add(AA2E82A1);
		tabChangeIP.Controls.Add(A796A8A8);
		tabChangeIP.Controls.Add(tabObcProxy);
		tabChangeIP.Controls.Add(B1A94238);
		tabChangeIP.Controls.Add(tabProxyWeb);
		tabChangeIP.Cursor = System.Windows.Forms.Cursors.Hand;
		tabChangeIP.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		tabChangeIP.Location = new System.Drawing.Point(30, 107);
		tabChangeIP.Name = "tabChangeIP";
		tabChangeIP.SelectedIndex = 0;
		tabChangeIP.Size = new System.Drawing.Size(440, 206);
		tabChangeIP.TabIndex = 146;
		tabNone.Controls.Add(panel16);
		tabNone.Location = new System.Drawing.Point(4, 4);
		tabNone.Name = "tabNone";
		tabNone.Padding = new System.Windows.Forms.Padding(3);
		tabNone.Size = new System.Drawing.Size(432, 177);
		tabNone.TabIndex = 7;
		tabNone.Text = "tabNone";
		tabNone.UseVisualStyleBackColor = true;
		panel16.Dock = System.Windows.Forms.DockStyle.Fill;
		panel16.Location = new System.Drawing.Point(3, 3);
		panel16.Name = "panel16";
		panel16.Size = new System.Drawing.Size(426, 171);
		panel16.TabIndex = 0;
		tabProxy.Controls.Add(plTuyChonProxy);
		tabProxy.Controls.Add(cbbProxy);
		tabProxy.Controls.Add(CDAA4326);
		tabProxy.Location = new System.Drawing.Point(4, 4);
		tabProxy.Name = "tabProxy";
		tabProxy.Size = new System.Drawing.Size(432, 177);
		tabProxy.TabIndex = 10;
		tabProxy.Text = "tabProxy";
		tabProxy.UseVisualStyleBackColor = true;
		plTuyChonProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plTuyChonProxy.Controls.Add(cbbProxyType);
		plTuyChonProxy.Controls.Add(F8B84EB1);
		plTuyChonProxy.Controls.Add(label33);
		plTuyChonProxy.Controls.Add(txtProxy);
		plTuyChonProxy.Location = new System.Drawing.Point(70, 46);
		plTuyChonProxy.Name = "plTuyChonProxy";
		plTuyChonProxy.Size = new System.Drawing.Size(304, 116);
		plTuyChonProxy.TabIndex = 161;
		cbbProxyType.Anchor = System.Windows.Forms.AnchorStyles.None;
		cbbProxyType.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbProxyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbProxyType.DropDownWidth = 150;
		cbbProxyType.FormattingEnabled = true;
		cbbProxyType.Items.AddRange(new object[2] { "Http", "Sock5" });
		cbbProxyType.Location = new System.Drawing.Point(215, 3);
		cbbProxyType.Name = "cbbProxyType";
		cbbProxyType.Size = new System.Drawing.Size(84, 24);
		cbbProxyType.TabIndex = 162;
		F8B84EB1.Anchor = System.Windows.Forms.AnchorStyles.None;
		F8B84EB1.AutoSize = true;
		F8B84EB1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		F8B84EB1.Location = new System.Drawing.Point(142, 6);
		F8B84EB1.Name = "label45";
		F8B84EB1.Size = new System.Drawing.Size(70, 16);
		F8B84EB1.TabIndex = 161;
		F8B84EB1.Text = "Loại Proxy:";
		label33.Anchor = System.Windows.Forms.AnchorStyles.None;
		label33.AutoSize = true;
		label33.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label33.Location = new System.Drawing.Point(3, 6);
		label33.Name = "label33";
		label33.Size = new System.Drawing.Size(97, 16);
		label33.TabIndex = 147;
		label33.Text = "Nhập Proxy (0):";
		txtProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		txtProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtProxy.Location = new System.Drawing.Point(6, 30);
		txtProxy.Name = "txtProxy";
		txtProxy.Size = new System.Drawing.Size(294, 82);
		txtProxy.TabIndex = 148;
		txtProxy.Text = "";
		txtProxy.WordWrap = false;
		txtProxy.TextChanged += new System.EventHandler(txtProxy_TextChanged);
		cbbProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		cbbProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbProxy.DropDownWidth = 150;
		cbbProxy.FormattingEnabled = true;
		cbbProxy.Location = new System.Drawing.Point(137, 16);
		cbbProxy.Name = "cbbProxy";
		cbbProxy.Size = new System.Drawing.Size(237, 24);
		cbbProxy.TabIndex = 160;
		cbbProxy.SelectedIndexChanged += new System.EventHandler(FB9F8518);
		CDAA4326.Anchor = System.Windows.Forms.AnchorStyles.None;
		CDAA4326.AutoSize = true;
		CDAA4326.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		CDAA4326.Location = new System.Drawing.Point(67, 19);
		CDAA4326.Name = "label39";
		CDAA4326.Size = new System.Drawing.Size(64, 16);
		CDAA4326.TabIndex = 159;
		CDAA4326.Text = "Tùy chọn:";
		AA2E82A1.Controls.Add(F61EF227);
		AA2E82A1.Location = new System.Drawing.Point(4, 4);
		AA2E82A1.Name = "tabDcom";
		AA2E82A1.Padding = new System.Windows.Forms.Padding(3);
		AA2E82A1.Size = new System.Drawing.Size(432, 177);
		AA2E82A1.TabIndex = 0;
		AA2E82A1.Text = "Dcom";
		AA2E82A1.UseVisualStyleBackColor = true;
		F61EF227.Controls.Add(button4);
		F61EF227.Controls.Add(txtUrlHilink);
		F61EF227.Controls.Add(txtProfileNameDcom);
		F61EF227.Controls.Add(rbDcomHilink);
		F61EF227.Controls.Add(FE23060C);
		F61EF227.Controls.Add(rbDcomThuong);
		F61EF227.Dock = System.Windows.Forms.DockStyle.Fill;
		F61EF227.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		F61EF227.Location = new System.Drawing.Point(3, 3);
		F61EF227.Name = "plDcom";
		F61EF227.Size = new System.Drawing.Size(426, 171);
		F61EF227.TabIndex = 131;
		button4.Anchor = System.Windows.Forms.AnchorStyles.None;
		button4.Cursor = System.Windows.Forms.Cursors.Hand;
		button4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		button4.ForeColor = System.Drawing.Color.Black;
		button4.Location = new System.Drawing.Point(279, 57);
		button4.Name = "button4";
		button4.Size = new System.Drawing.Size(93, 25);
		button4.TabIndex = 143;
		button4.Text = "Lâ\u0301y tên Dcom";
		CDADBC94.SetToolTip(button4, "Lâ\u0301y tên dcom");
		button4.UseVisualStyleBackColor = true;
		button4.Click += new System.EventHandler(F30AB03C);
		txtUrlHilink.Anchor = System.Windows.Forms.AnchorStyles.None;
		txtUrlHilink.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		txtUrlHilink.ForeColor = System.Drawing.Color.Black;
		txtUrlHilink.Location = new System.Drawing.Point(151, 106);
		txtUrlHilink.Name = "txtUrlHilink";
		txtUrlHilink.Size = new System.Drawing.Size(221, 23);
		txtUrlHilink.TabIndex = 81;
		txtProfileNameDcom.Anchor = System.Windows.Forms.AnchorStyles.None;
		txtProfileNameDcom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		txtProfileNameDcom.ForeColor = System.Drawing.Color.Black;
		txtProfileNameDcom.Location = new System.Drawing.Point(87, 58);
		txtProfileNameDcom.Name = "txtProfileNameDcom";
		txtProfileNameDcom.Size = new System.Drawing.Size(186, 23);
		txtProfileNameDcom.TabIndex = 81;
		rbDcomHilink.Anchor = System.Windows.Forms.AnchorStyles.None;
		rbDcomHilink.AutoSize = true;
		rbDcomHilink.Cursor = System.Windows.Forms.Cursors.Hand;
		rbDcomHilink.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		rbDcomHilink.Location = new System.Drawing.Point(68, 85);
		rbDcomHilink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		rbDcomHilink.Name = "rbDcomHilink";
		rbDcomHilink.Size = new System.Drawing.Size(55, 20);
		rbDcomHilink.TabIndex = 136;
		rbDcomHilink.Text = "Hilink";
		rbDcomHilink.UseVisualStyleBackColor = true;
		rbDcomHilink.CheckedChanged += new System.EventHandler(rbDcomHilink_CheckedChanged);
		FE23060C.Anchor = System.Windows.Forms.AnchorStyles.None;
		FE23060C.AutoSize = true;
		FE23060C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		FE23060C.Location = new System.Drawing.Point(84, 109);
		FE23060C.Name = "label36";
		FE23060C.Size = new System.Drawing.Size(64, 16);
		FE23060C.TabIndex = 79;
		FE23060C.Text = "Link Web:";
		rbDcomThuong.Anchor = System.Windows.Forms.AnchorStyles.None;
		rbDcomThuong.AutoSize = true;
		rbDcomThuong.Cursor = System.Windows.Forms.Cursors.Hand;
		rbDcomThuong.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		rbDcomThuong.Location = new System.Drawing.Point(68, 34);
		rbDcomThuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		rbDcomThuong.Name = "rbDcomThuong";
		rbDcomThuong.Size = new System.Drawing.Size(69, 20);
		rbDcomThuong.TabIndex = 136;
		rbDcomThuong.Text = "Thươ\u0300ng";
		rbDcomThuong.UseVisualStyleBackColor = true;
		rbDcomThuong.CheckedChanged += new System.EventHandler(rbDcomThuong_CheckedChanged);
		A796A8A8.Controls.Add(plXproxy);
		A796A8A8.Location = new System.Drawing.Point(4, 4);
		A796A8A8.Name = "tabXProxy";
		A796A8A8.Padding = new System.Windows.Forms.Padding(3);
		A796A8A8.Size = new System.Drawing.Size(432, 177);
		A796A8A8.TabIndex = 2;
		A796A8A8.Text = "Xproxy";
		A796A8A8.UseVisualStyleBackColor = true;
		plXproxy.Controls.Add(label53);
		plXproxy.Controls.Add(CBB0A68E);
		plXproxy.Controls.Add(cbbTypeRunXproxy);
		plXproxy.Controls.Add(txtListProxy);
		plXproxy.Controls.Add(rbSock5Proxy);
		plXproxy.Controls.Add(rbHttpProxy);
		plXproxy.Controls.Add(DC0CE7BC);
		plXproxy.Controls.Add(B125179D);
		plXproxy.Controls.Add(F5B33A1A);
		plXproxy.Controls.Add(AF97B79E);
		plXproxy.Controls.Add(label13);
		plXproxy.Controls.Add(txtServiceURLXProxy);
		plXproxy.Dock = System.Windows.Forms.DockStyle.Fill;
		plXproxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		plXproxy.Location = new System.Drawing.Point(3, 3);
		plXproxy.Name = "plXproxy";
		plXproxy.Size = new System.Drawing.Size(426, 171);
		plXproxy.TabIndex = 142;
		plXproxy.Click += new System.EventHandler(A8A80421);
		label53.Anchor = System.Windows.Forms.AnchorStyles.None;
		label53.AutoSize = true;
		label53.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label53.Location = new System.Drawing.Point(244, 139);
		label53.Name = "label53";
		label53.Size = new System.Drawing.Size(82, 16);
		label53.TabIndex = 155;
		label53.Text = "Chế độ chạy:";
		CBB0A68E.Anchor = System.Windows.Forms.AnchorStyles.None;
		CBB0A68E.AutoSize = true;
		CBB0A68E.Cursor = System.Windows.Forms.Cursors.Hand;
		CBB0A68E.Location = new System.Drawing.Point(115, 60);
		CBB0A68E.Name = "ckbWaitDoneAllXproxy";
		CBB0A68E.Size = new System.Drawing.Size(128, 20);
		CBB0A68E.TabIndex = 145;
		CBB0A68E.Text = "Đợi chạy xong hết";
		CBB0A68E.UseVisualStyleBackColor = true;
		CBB0A68E.Visible = false;
		cbbTypeRunXproxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		cbbTypeRunXproxy.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTypeRunXproxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTypeRunXproxy.DropDownWidth = 150;
		cbbTypeRunXproxy.FormattingEnabled = true;
		cbbTypeRunXproxy.Items.AddRange(new object[2] { "Reset từng proxy", "Reset tất cả proxy" });
		cbbTypeRunXproxy.Location = new System.Drawing.Point(332, 135);
		cbbTypeRunXproxy.Name = "cbbTypeRunXproxy";
		cbbTypeRunXproxy.Size = new System.Drawing.Size(84, 24);
		cbbTypeRunXproxy.TabIndex = 34;
		txtListProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		txtListProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtListProxy.Location = new System.Drawing.Point(9, 82);
		txtListProxy.Name = "txtListProxy";
		txtListProxy.Size = new System.Drawing.Size(229, 78);
		txtListProxy.TabIndex = 144;
		txtListProxy.Text = "";
		txtListProxy.WordWrap = false;
		txtListProxy.TextChanged += new System.EventHandler(txtListProxy_TextChanged);
		rbSock5Proxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		rbSock5Proxy.AutoSize = true;
		rbSock5Proxy.Cursor = System.Windows.Forms.Cursors.Hand;
		rbSock5Proxy.Location = new System.Drawing.Point(156, 36);
		rbSock5Proxy.Name = "rbSock5Proxy";
		rbSock5Proxy.Size = new System.Drawing.Size(59, 20);
		rbSock5Proxy.TabIndex = 82;
		rbSock5Proxy.Text = "Sock5";
		rbSock5Proxy.UseVisualStyleBackColor = true;
		rbHttpProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		rbHttpProxy.AutoSize = true;
		rbHttpProxy.Checked = true;
		rbHttpProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		rbHttpProxy.Location = new System.Drawing.Point(93, 36);
		rbHttpProxy.Name = "rbHttpProxy";
		rbHttpProxy.Size = new System.Drawing.Size(48, 20);
		rbHttpProxy.TabIndex = 82;
		rbHttpProxy.TabStop = true;
		rbHttpProxy.Text = "Http";
		rbHttpProxy.UseVisualStyleBackColor = true;
		DC0CE7BC.Anchor = System.Windows.Forms.AnchorStyles.None;
		DC0CE7BC.AutoSize = true;
		DC0CE7BC.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		DC0CE7BC.Location = new System.Drawing.Point(6, 36);
		DC0CE7BC.Name = "label16";
		DC0CE7BC.Size = new System.Drawing.Size(70, 16);
		DC0CE7BC.TabIndex = 79;
		DC0CE7BC.Text = "Loại Proxy:";
		B125179D.Anchor = System.Windows.Forms.AnchorStyles.None;
		B125179D.AutoSize = true;
		B125179D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		B125179D.Location = new System.Drawing.Point(6, 61);
		B125179D.Name = "label17";
		B125179D.Size = new System.Drawing.Size(97, 16);
		B125179D.TabIndex = 79;
		B125179D.Text = "Nhập Proxy (0):";
		F5B33A1A.Anchor = System.Windows.Forms.AnchorStyles.None;
		F5B33A1A.AutoSize = true;
		F5B33A1A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		F5B33A1A.Location = new System.Drawing.Point(244, 108);
		F5B33A1A.Name = "label18";
		F5B33A1A.Size = new System.Drawing.Size(78, 16);
		F5B33A1A.TabIndex = 139;
		F5B33A1A.Text = "Số luồng/IP:";
		AF97B79E.Anchor = System.Windows.Forms.AnchorStyles.None;
		AF97B79E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		AF97B79E.Location = new System.Drawing.Point(332, 106);
		AF97B79E.Name = "nudLuongPerIPXProxy";
		AF97B79E.Size = new System.Drawing.Size(84, 23);
		AF97B79E.TabIndex = 140;
		AF97B79E.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		label13.Anchor = System.Windows.Forms.AnchorStyles.None;
		label13.AutoSize = true;
		label13.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label13.Location = new System.Drawing.Point(6, 12);
		label13.Name = "label13";
		label13.Size = new System.Drawing.Size(80, 16);
		label13.TabIndex = 79;
		label13.Text = "Service URL:";
		txtServiceURLXProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		txtServiceURLXProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		txtServiceURLXProxy.ForeColor = System.Drawing.Color.Black;
		txtServiceURLXProxy.Location = new System.Drawing.Point(93, 9);
		txtServiceURLXProxy.Name = "txtServiceURLXProxy";
		txtServiceURLXProxy.Size = new System.Drawing.Size(327, 23);
		txtServiceURLXProxy.TabIndex = 81;
		tabObcProxy.Controls.Add(F99B120B);
		tabObcProxy.Location = new System.Drawing.Point(4, 4);
		tabObcProxy.Name = "tabObcProxy";
		tabObcProxy.Padding = new System.Windows.Forms.Padding(3);
		tabObcProxy.Size = new System.Drawing.Size(432, 177);
		tabObcProxy.TabIndex = 3;
		tabObcProxy.Text = "OBC";
		tabObcProxy.UseVisualStyleBackColor = true;
		F99B120B.Controls.Add(CD26BF3A);
		F99B120B.Controls.Add(A8817A07);
		F99B120B.Controls.Add(rbObcSock5Proxy);
		F99B120B.Controls.Add(rbObcHttpProxy);
		F99B120B.Controls.Add(label55);
		F99B120B.Controls.Add(txtListObcProxy);
		F99B120B.Controls.Add(C4959598);
		F99B120B.Controls.Add(label69);
		F99B120B.Controls.Add(E534B69E);
		F99B120B.Controls.Add(C539AA1A);
		F99B120B.Controls.Add(D70B2F26);
		F99B120B.Dock = System.Windows.Forms.DockStyle.Fill;
		F99B120B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		F99B120B.Location = new System.Drawing.Point(3, 3);
		F99B120B.Name = "plObcProxy";
		F99B120B.Size = new System.Drawing.Size(426, 171);
		F99B120B.TabIndex = 142;
		CD26BF3A.Anchor = System.Windows.Forms.AnchorStyles.None;
		CD26BF3A.Cursor = System.Windows.Forms.Cursors.Hand;
		CD26BF3A.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		CD26BF3A.DropDownWidth = 150;
		CD26BF3A.FormattingEnabled = true;
		CD26BF3A.Items.AddRange(new object[2] { "Reset từng IP", "Reset cả dải IP" });
		CD26BF3A.Location = new System.Drawing.Point(336, 136);
		CD26BF3A.Name = "cbbTypeRunObcProxy";
		CD26BF3A.Size = new System.Drawing.Size(84, 24);
		CD26BF3A.TabIndex = 157;
		A8817A07.Anchor = System.Windows.Forms.AnchorStyles.None;
		A8817A07.AutoSize = true;
		A8817A07.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		A8817A07.Location = new System.Drawing.Point(244, 139);
		A8817A07.Name = "label54";
		A8817A07.Size = new System.Drawing.Size(82, 16);
		A8817A07.TabIndex = 155;
		A8817A07.Text = "Chế độ chạy:";
		rbObcSock5Proxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		rbObcSock5Proxy.AutoSize = true;
		rbObcSock5Proxy.Cursor = System.Windows.Forms.Cursors.Hand;
		rbObcSock5Proxy.Enabled = false;
		rbObcSock5Proxy.Location = new System.Drawing.Point(156, 37);
		rbObcSock5Proxy.Name = "rbObcSock5Proxy";
		rbObcSock5Proxy.Size = new System.Drawing.Size(59, 20);
		rbObcSock5Proxy.TabIndex = 154;
		rbObcSock5Proxy.Text = "Sock5";
		rbObcSock5Proxy.UseVisualStyleBackColor = true;
		rbObcHttpProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		rbObcHttpProxy.AutoSize = true;
		rbObcHttpProxy.Checked = true;
		rbObcHttpProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		rbObcHttpProxy.Location = new System.Drawing.Point(93, 37);
		rbObcHttpProxy.Name = "rbObcHttpProxy";
		rbObcHttpProxy.Size = new System.Drawing.Size(48, 20);
		rbObcHttpProxy.TabIndex = 155;
		rbObcHttpProxy.TabStop = true;
		rbObcHttpProxy.Text = "Http";
		rbObcHttpProxy.UseVisualStyleBackColor = true;
		label55.Anchor = System.Windows.Forms.AnchorStyles.None;
		label55.AutoSize = true;
		label55.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label55.Location = new System.Drawing.Point(6, 37);
		label55.Name = "label55";
		label55.Size = new System.Drawing.Size(70, 16);
		label55.TabIndex = 153;
		label55.Text = "Loại Proxy:";
		txtListObcProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		txtListObcProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtListObcProxy.Location = new System.Drawing.Point(9, 77);
		txtListObcProxy.Name = "txtListObcProxy";
		txtListObcProxy.Size = new System.Drawing.Size(229, 81);
		txtListObcProxy.TabIndex = 144;
		txtListObcProxy.Text = "";
		txtListObcProxy.WordWrap = false;
		txtListObcProxy.TextChanged += new System.EventHandler(C7B31609);
		C4959598.Anchor = System.Windows.Forms.AnchorStyles.None;
		C4959598.AutoSize = true;
		C4959598.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		C4959598.Location = new System.Drawing.Point(6, 58);
		C4959598.Name = "label67";
		C4959598.Size = new System.Drawing.Size(97, 16);
		C4959598.TabIndex = 79;
		C4959598.Text = "Nhập Proxy (0):";
		label69.Anchor = System.Windows.Forms.AnchorStyles.None;
		label69.AutoSize = true;
		label69.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label69.Location = new System.Drawing.Point(246, 108);
		label69.Name = "label69";
		label69.Size = new System.Drawing.Size(78, 16);
		label69.TabIndex = 139;
		label69.Text = "Số luồng/IP:";
		E534B69E.Anchor = System.Windows.Forms.AnchorStyles.None;
		E534B69E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		E534B69E.Location = new System.Drawing.Point(336, 107);
		E534B69E.Name = "nudLuongPerIPObcProxy";
		E534B69E.Size = new System.Drawing.Size(84, 23);
		E534B69E.TabIndex = 140;
		E534B69E.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		C539AA1A.Anchor = System.Windows.Forms.AnchorStyles.None;
		C539AA1A.AutoSize = true;
		C539AA1A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		C539AA1A.Location = new System.Drawing.Point(6, 15);
		C539AA1A.Name = "label71";
		C539AA1A.Size = new System.Drawing.Size(64, 16);
		C539AA1A.TabIndex = 79;
		C539AA1A.Text = "Link Web:";
		D70B2F26.Anchor = System.Windows.Forms.AnchorStyles.None;
		D70B2F26.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		D70B2F26.ForeColor = System.Drawing.Color.Black;
		D70B2F26.Location = new System.Drawing.Point(93, 12);
		D70B2F26.Name = "txtLinkWebObcProxy";
		D70B2F26.Size = new System.Drawing.Size(326, 23);
		D70B2F26.TabIndex = 81;
		B1A94238.Controls.Add(panel5);
		B1A94238.Location = new System.Drawing.Point(4, 4);
		B1A94238.Name = "tabMinProxy";
		B1A94238.Padding = new System.Windows.Forms.Padding(3);
		B1A94238.Size = new System.Drawing.Size(432, 177);
		B1A94238.TabIndex = 8;
		B1A94238.Text = "minproxy";
		B1A94238.UseVisualStyleBackColor = true;
		panel5.Controls.Add(rbProxyDanCu);
		panel5.Controls.Add(rbProxyDong);
		panel5.Controls.Add(button10);
		panel5.Controls.Add(txtApiKeyMinProxy);
		panel5.Controls.Add(label49);
		panel5.Controls.Add(label50);
		panel5.Controls.Add(plTypeProxy);
		panel5.Controls.Add(nudLuongPerIPMinProxy);
		panel5.Dock = System.Windows.Forms.DockStyle.Fill;
		panel5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		panel5.Location = new System.Drawing.Point(3, 3);
		panel5.Name = "panel5";
		panel5.Size = new System.Drawing.Size(426, 171);
		panel5.TabIndex = 153;
		rbProxyDanCu.Anchor = System.Windows.Forms.AnchorStyles.None;
		rbProxyDanCu.AutoSize = true;
		rbProxyDanCu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbProxyDanCu.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		rbProxyDanCu.Location = new System.Drawing.Point(211, 8);
		rbProxyDanCu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		rbProxyDanCu.Name = "rbProxyDanCu";
		rbProxyDanCu.Size = new System.Drawing.Size(99, 20);
		rbProxyDanCu.TabIndex = 154;
		rbProxyDanCu.Text = "Proxy dân cư";
		rbProxyDanCu.UseVisualStyleBackColor = true;
		rbProxyDanCu.CheckedChanged += new System.EventHandler(rbProxyDanCu_CheckedChanged);
		rbProxyDong.Anchor = System.Windows.Forms.AnchorStyles.None;
		rbProxyDong.AutoSize = true;
		rbProxyDong.Checked = true;
		rbProxyDong.Cursor = System.Windows.Forms.Cursors.Hand;
		rbProxyDong.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		rbProxyDong.Location = new System.Drawing.Point(92, 8);
		rbProxyDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		rbProxyDong.Name = "rbProxyDong";
		rbProxyDong.Size = new System.Drawing.Size(107, 20);
		rbProxyDong.TabIndex = 153;
		rbProxyDong.TabStop = true;
		rbProxyDong.Text = "Proxy V6 động";
		rbProxyDong.UseVisualStyleBackColor = true;
		button10.Anchor = System.Windows.Forms.AnchorStyles.None;
		button10.Cursor = System.Windows.Forms.Cursors.Hand;
		button10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		button10.ForeColor = System.Drawing.Color.Black;
		button10.Location = new System.Drawing.Point(310, 136);
		button10.Name = "button10";
		button10.Size = new System.Drawing.Size(52, 27);
		button10.TabIndex = 145;
		button10.Text = "Check";
		button10.UseVisualStyleBackColor = true;
		button10.Click += new System.EventHandler(button10_Click);
		txtApiKeyMinProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		txtApiKeyMinProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtApiKeyMinProxy.Location = new System.Drawing.Point(92, 59);
		txtApiKeyMinProxy.Name = "txtApiKeyMinProxy";
		txtApiKeyMinProxy.Size = new System.Drawing.Size(270, 76);
		txtApiKeyMinProxy.TabIndex = 144;
		txtApiKeyMinProxy.Text = "";
		txtApiKeyMinProxy.WordWrap = false;
		txtApiKeyMinProxy.TextChanged += new System.EventHandler(txtApiKeyMinProxy_TextChanged);
		label49.Anchor = System.Windows.Forms.AnchorStyles.None;
		label49.AutoSize = true;
		label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label49.Location = new System.Drawing.Point(89, 35);
		label49.Name = "label49";
		label49.Size = new System.Drawing.Size(110, 16);
		label49.TabIndex = 79;
		label49.Text = "Nhập API KEY (0):";
		label50.Anchor = System.Windows.Forms.AnchorStyles.None;
		label50.AutoSize = true;
		label50.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label50.Location = new System.Drawing.Point(89, 141);
		label50.Name = "label50";
		label50.Size = new System.Drawing.Size(78, 16);
		label50.TabIndex = 139;
		label50.Text = "Số luồng/IP:";
		plTypeProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		plTypeProxy.Controls.Add(cbbTypeProxyMin);
		plTypeProxy.Controls.Add(FD36AF17);
		plTypeProxy.Location = new System.Drawing.Point(202, 32);
		plTypeProxy.Name = "plTypeProxy";
		plTypeProxy.Size = new System.Drawing.Size(164, 25);
		plTypeProxy.TabIndex = 146;
		cbbTypeProxyMin.Anchor = System.Windows.Forms.AnchorStyles.None;
		cbbTypeProxyMin.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTypeProxyMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTypeProxyMin.DropDownWidth = 150;
		cbbTypeProxyMin.FormattingEnabled = true;
		cbbTypeProxyMin.Items.AddRange(new object[4] { "Http Ipv4", "Http Ipv6", "Sock Ipv4", "Sock Ipv6" });
		cbbTypeProxyMin.Location = new System.Drawing.Point(75, 1);
		cbbTypeProxyMin.Name = "cbbTypeProxyMin";
		cbbTypeProxyMin.Size = new System.Drawing.Size(84, 24);
		cbbTypeProxyMin.TabIndex = 160;
		FD36AF17.Anchor = System.Windows.Forms.AnchorStyles.None;
		FD36AF17.AutoSize = true;
		FD36AF17.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		FD36AF17.Location = new System.Drawing.Point(2, 4);
		FD36AF17.Name = "label21";
		FD36AF17.Size = new System.Drawing.Size(70, 16);
		FD36AF17.TabIndex = 159;
		FD36AF17.Text = "Loại Proxy:";
		nudLuongPerIPMinProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		nudLuongPerIPMinProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudLuongPerIPMinProxy.Location = new System.Drawing.Point(174, 139);
		nudLuongPerIPMinProxy.Name = "nudLuongPerIPMinProxy";
		nudLuongPerIPMinProxy.Size = new System.Drawing.Size(67, 23);
		nudLuongPerIPMinProxy.TabIndex = 140;
		nudLuongPerIPMinProxy.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		tabProxyWeb.Controls.Add(E8A62C1C);
		tabProxyWeb.Controls.Add(lblApiKeyProxy);
		tabProxyWeb.Controls.Add(label65);
		tabProxyWeb.Controls.Add(nudLuongPerIP);
		tabProxyWeb.Location = new System.Drawing.Point(4, 4);
		tabProxyWeb.Name = "tabProxyWeb";
		tabProxyWeb.Padding = new System.Windows.Forms.Padding(3);
		tabProxyWeb.Size = new System.Drawing.Size(432, 177);
		tabProxyWeb.TabIndex = 14;
		tabProxyWeb.Text = "tabProxyWeb";
		tabProxyWeb.UseVisualStyleBackColor = true;
		E8A62C1C.Anchor = System.Windows.Forms.AnchorStyles.None;
		E8A62C1C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		E8A62C1C.Location = new System.Drawing.Point(63, 34);
		E8A62C1C.Name = "txtApiKeyProxy";
		E8A62C1C.Size = new System.Drawing.Size(310, 101);
		E8A62C1C.TabIndex = 166;
		E8A62C1C.Text = "";
		E8A62C1C.WordWrap = false;
		E8A62C1C.TextChanged += new System.EventHandler(ED3875B2);
		lblApiKeyProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		lblApiKeyProxy.AutoSize = true;
		lblApiKeyProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		lblApiKeyProxy.Location = new System.Drawing.Point(60, 13);
		lblApiKeyProxy.Name = "lblApiKeyProxy";
		lblApiKeyProxy.Size = new System.Drawing.Size(110, 16);
		lblApiKeyProxy.TabIndex = 163;
		lblApiKeyProxy.Text = "Nhập API KEY (0):";
		label65.Anchor = System.Windows.Forms.AnchorStyles.None;
		label65.AutoSize = true;
		label65.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label65.Location = new System.Drawing.Point(60, 142);
		label65.Name = "label65";
		label65.Size = new System.Drawing.Size(78, 16);
		label65.TabIndex = 164;
		label65.Text = "Số luồng/IP:";
		nudLuongPerIP.Anchor = System.Windows.Forms.AnchorStyles.None;
		nudLuongPerIP.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudLuongPerIP.Location = new System.Drawing.Point(142, 140);
		nudLuongPerIP.Name = "nudLuongPerIP";
		nudLuongPerIP.Size = new System.Drawing.Size(67, 23);
		nudLuongPerIP.TabIndex = 165;
		nudLuongPerIP.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		cbbChangeIP.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbChangeIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbChangeIP.FormattingEnabled = true;
		cbbChangeIP.Location = new System.Drawing.Point(167, 79);
		cbbChangeIP.Name = "cbbChangeIP";
		cbbChangeIP.Size = new System.Drawing.Size(299, 24);
		cbbChangeIP.TabIndex = 34;
		label15.AutoSize = true;
		label15.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label15.Location = new System.Drawing.Point(27, 82);
		label15.Name = "label15";
		label15.Size = new System.Drawing.Size(126, 16);
		label15.TabIndex = 139;
		label15.Text = "Tùy chọn Change IP:";
		BB8D0B22.AutoSize = true;
		BB8D0B22.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		BB8D0B22.Location = new System.Drawing.Point(27, 51);
		BB8D0B22.Name = "label37";
		BB8D0B22.Size = new System.Drawing.Size(123, 16);
		BB8D0B22.TabIndex = 139;
		BB8D0B22.Text = "Delay sau khi đô\u0309i IP:";
		nudDelayCheckIP.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudDelayCheckIP.Location = new System.Drawing.Point(167, 49);
		nudDelayCheckIP.Maximum = new decimal(new int[4] { 99999999, 0, 0, 0 });
		nudDelayCheckIP.Name = "nudDelayCheckIP";
		nudDelayCheckIP.Size = new System.Drawing.Size(36, 23);
		nudDelayCheckIP.TabIndex = 140;
		label38.AutoSize = true;
		label38.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label38.Location = new System.Drawing.Point(202, 51);
		label38.Name = "label38";
		label38.Size = new System.Drawing.Size(13, 16);
		label38.TabIndex = 141;
		label38.Text = "s";
		C3B1BB87.Controls.Add(button5);
		C3B1BB87.Controls.Add(label26);
		C3B1BB87.Controls.Add(EEA657B1);
		C3B1BB87.Controls.Add(C8A53894);
		C3B1BB87.Enabled = false;
		C3B1BB87.Location = new System.Drawing.Point(233, 46);
		C3B1BB87.Name = "plCheckDoiIP";
		C3B1BB87.Size = new System.Drawing.Size(237, 27);
		C3B1BB87.TabIndex = 146;
		button5.Cursor = System.Windows.Forms.Cursors.Hand;
		button5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		button5.ForeColor = System.Drawing.Color.Black;
		button5.Location = new System.Drawing.Point(183, 0);
		button5.Name = "button5";
		button5.Size = new System.Drawing.Size(50, 27);
		button5.TabIndex = 143;
		button5.Text = "Test";
		button5.UseVisualStyleBackColor = true;
		button5.Click += new System.EventHandler(button5_Click);
		label26.AutoSize = true;
		label26.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label26.Location = new System.Drawing.Point(3, 5);
		label26.Name = "label26";
		label26.Size = new System.Drawing.Size(100, 16);
		label26.TabIndex = 139;
		label26.Text = "Thay đổi IP sau:";
		EEA657B1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		EEA657B1.Location = new System.Drawing.Point(104, 3);
		EEA657B1.Name = "nudChangeIpCount";
		EEA657B1.Size = new System.Drawing.Size(46, 23);
		EEA657B1.TabIndex = 140;
		EEA657B1.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		C8A53894.AutoSize = true;
		C8A53894.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		C8A53894.Location = new System.Drawing.Point(152, 5);
		C8A53894.Name = "label27";
		C8A53894.Size = new System.Drawing.Size(29, 16);
		C8A53894.TabIndex = 141;
		C8A53894.Text = "lượt";
		D9A706B5.AutoSize = true;
		D9A706B5.Cursor = System.Windows.Forms.Cursors.Hand;
		D9A706B5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D9A706B5.Location = new System.Drawing.Point(30, 25);
		D9A706B5.Name = "ckbKhongCheckIP";
		D9A706B5.Size = new System.Drawing.Size(198, 20);
		D9A706B5.TabIndex = 112;
		D9A706B5.Text = "Không Check IP trước khi chạy";
		D9A706B5.UseVisualStyleBackColor = true;
		grCauHinhChung.Controls.Add(plDongBoMaxCare);
		grCauHinhChung.Controls.Add(E51ADA30);
		grCauHinhChung.Controls.Add(C923B88E);
		grCauHinhChung.Controls.Add(label5);
		grCauHinhChung.Controls.Add(D49F1407);
		grCauHinhChung.Controls.Add(nudHideThread);
		grCauHinhChung.Controls.Add(label6);
		grCauHinhChung.Controls.Add(D42AFB34);
		grCauHinhChung.Controls.Add(txbPathProfile);
		grCauHinhChung.Controls.Add(label4);
		grCauHinhChung.Controls.Add(nudInteractThread);
		grCauHinhChung.Controls.Add(label3);
		grCauHinhChung.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		grCauHinhChung.Location = new System.Drawing.Point(7, 39);
		grCauHinhChung.Name = "grCauHinhChung";
		grCauHinhChung.Size = new System.Drawing.Size(568, 53);
		grCauHinhChung.TabIndex = 38;
		grCauHinhChung.TabStop = false;
		grCauHinhChung.Text = "Cấu hình chung";
		plDongBoMaxCare.Controls.Add(label22);
		plDongBoMaxCare.Controls.Add(txtPathMaxCare);
		plDongBoMaxCare.Location = new System.Drawing.Point(48, 129);
		plDongBoMaxCare.Name = "plDongBoMaxCare";
		plDongBoMaxCare.Size = new System.Drawing.Size(517, 23);
		plDongBoMaxCare.TabIndex = 168;
		label22.AutoSize = true;
		label22.Location = new System.Drawing.Point(3, 3);
		label22.Name = "label22";
		label22.Size = new System.Drawing.Size(102, 16);
		label22.TabIndex = 158;
		label22.Text = "Folder MaxCare:";
		txtPathMaxCare.Location = new System.Drawing.Point(125, 0);
		txtPathMaxCare.Name = "txtPathMaxCare";
		txtPathMaxCare.Size = new System.Drawing.Size(386, 23);
		txtPathMaxCare.TabIndex = 159;
		E51ADA30.AutoSize = true;
		E51ADA30.Cursor = System.Windows.Forms.Cursors.Hand;
		E51ADA30.Location = new System.Drawing.Point(35, 108);
		E51ADA30.Name = "ckbDongBoMaxCare";
		E51ADA30.Size = new System.Drawing.Size(191, 20);
		E51ADA30.TabIndex = 167;
		E51ADA30.Text = "Đô\u0300ng bô\u0323 dư\u0303 liê\u0323u vơ\u0301i MaxCare";
		E51ADA30.UseVisualStyleBackColor = true;
		E51ADA30.CheckedChanged += new System.EventHandler(E51ADA30_CheckedChanged);
		C923B88E.BackgroundImage = C50FB39E.Bitmap_89;
		C923B88E.Cursor = System.Windows.Forms.Cursors.Hand;
		C923B88E.Location = new System.Drawing.Point(512, 8);
		C923B88E.Name = "metroButton2";
		C923B88E.Size = new System.Drawing.Size(25, 25);
		C923B88E.TabIndex = 158;
		C923B88E.Click += new System.EventHandler(C923B88E_Click);
		D49F1407.BackgroundImage = C50FB39E.Bitmap_74;
		D49F1407.Cursor = System.Windows.Forms.Cursors.Hand;
		D49F1407.Location = new System.Drawing.Point(543, 8);
		D49F1407.Name = "metroButton1";
		D49F1407.Size = new System.Drawing.Size(25, 25);
		D49F1407.TabIndex = 159;
		D49F1407.Click += new System.EventHandler(D49F1407_Click);
		grCauHinhChrome.Controls.Add(D1269480);
		grCauHinhChrome.Controls.Add(DCADBCB4);
		grCauHinhChrome.Controls.Add(plGpmLogin);
		grCauHinhChrome.Controls.Add(ckbGpmLogin);
		grCauHinhChrome.Controls.Add(BE32A023);
		grCauHinhChrome.Controls.Add(A6A6CA1E);
		grCauHinhChrome.Controls.Add(AE0FFF89);
		grCauHinhChrome.Controls.Add(btnDown);
		grCauHinhChrome.Controls.Add(D027A8A9);
		grCauHinhChrome.Controls.Add(cbbTocDoGoVanBan);
		grCauHinhChrome.Controls.Add(label30);
		grCauHinhChrome.Controls.Add(plSapXepCuaSoChrome);
		grCauHinhChrome.Controls.Add(nudChromeScale);
		grCauHinhChrome.Controls.Add(FAB3AA84);
		grCauHinhChrome.Controls.Add(lblChromeScale);
		grCauHinhChrome.Controls.Add(AddFileAccount);
		grCauHinhChrome.Controls.Add(ckbGologin);
		grCauHinhChrome.Controls.Add(ckbUseExtensionProxy);
		grCauHinhChrome.Controls.Add(EB0A133E);
		grCauHinhChrome.Controls.Add(ckbShowImageInteract);
		grCauHinhChrome.Controls.Add(ckbAddChromeIntoForm);
		grCauHinhChrome.Controls.Add(cbbSizeChrome);
		grCauHinhChrome.Controls.Add(EE983832);
		grCauHinhChrome.Controls.Add(panel3);
		grCauHinhChrome.Controls.Add(D238682D);
		grCauHinhChrome.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		grCauHinhChrome.Location = new System.Drawing.Point(7, 98);
		grCauHinhChrome.Name = "grCauHinhChrome";
		grCauHinhChrome.Size = new System.Drawing.Size(568, 137);
		grCauHinhChrome.TabIndex = 38;
		grCauHinhChrome.TabStop = false;
		grCauHinhChrome.Text = "Cấu hình chrome";
		D1269480.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D1269480.Controls.Add(button11);
		D1269480.Controls.Add(txtGemApiUrl);
		D1269480.Controls.Add(label62);
		D1269480.Location = new System.Drawing.Point(173, 198);
		D1269480.Name = "plGemLogin";
		D1269480.Size = new System.Drawing.Size(390, 33);
		D1269480.TabIndex = 164;
		button11.Cursor = System.Windows.Forms.Cursors.Hand;
		button11.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		button11.ForeColor = System.Drawing.Color.Black;
		button11.Location = new System.Drawing.Point(326, 3);
		button11.Name = "button11";
		button11.Size = new System.Drawing.Size(59, 25);
		button11.TabIndex = 143;
		button11.Text = "Check";
		button11.UseVisualStyleBackColor = true;
		button11.Click += new System.EventHandler(button11_Click);
		txtGemApiUrl.Location = new System.Drawing.Point(116, 4);
		txtGemApiUrl.Name = "txtGemApiUrl";
		txtGemApiUrl.Size = new System.Drawing.Size(204, 23);
		txtGemApiUrl.TabIndex = 149;
		label62.AutoSize = true;
		label62.Location = new System.Drawing.Point(5, 8);
		label62.Name = "label62";
		label62.Size = new System.Drawing.Size(57, 16);
		label62.TabIndex = 148;
		label62.Text = "API URL:";
		DCADBCB4.AutoSize = true;
		DCADBCB4.Cursor = System.Windows.Forms.Cursors.Hand;
		DCADBCB4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		DCADBCB4.Location = new System.Drawing.Point(32, 205);
		DCADBCB4.Name = "ckbGemLogin";
		DCADBCB4.Size = new System.Drawing.Size(137, 20);
		DCADBCB4.TabIndex = 163;
		DCADBCB4.Text = "Sư\u0309 du\u0323ng GEM Login";
		DCADBCB4.UseVisualStyleBackColor = true;
		DCADBCB4.CheckedChanged += new System.EventHandler(DCADBCB4_CheckedChanged);
		plGpmLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plGpmLogin.Controls.Add(EEB05838);
		plGpmLogin.Controls.Add(EA2FA52B);
		plGpmLogin.Controls.Add(E5805987);
		plGpmLogin.Controls.Add(cbbBrowserVersion);
		plGpmLogin.Controls.Add(label68);
		plGpmLogin.Location = new System.Drawing.Point(173, 237);
		plGpmLogin.Name = "plGpmLogin";
		plGpmLogin.Size = new System.Drawing.Size(390, 64);
		plGpmLogin.TabIndex = 162;
		EEB05838.Cursor = System.Windows.Forms.Cursors.Hand;
		EEB05838.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		EEB05838.ForeColor = System.Drawing.Color.Black;
		EEB05838.Location = new System.Drawing.Point(326, 3);
		EEB05838.Name = "button12";
		EEB05838.Size = new System.Drawing.Size(59, 25);
		EEB05838.TabIndex = 143;
		EEB05838.Text = "Check";
		EEB05838.UseVisualStyleBackColor = true;
		EEB05838.Click += new System.EventHandler(D8BEB100);
		EA2FA52B.Location = new System.Drawing.Point(116, 4);
		EA2FA52B.Name = "txtGpmApiUrl";
		EA2FA52B.Size = new System.Drawing.Size(204, 23);
		EA2FA52B.TabIndex = 149;
		E5805987.AutoSize = true;
		E5805987.Location = new System.Drawing.Point(5, 8);
		E5805987.Name = "label66";
		E5805987.Size = new System.Drawing.Size(57, 16);
		E5805987.TabIndex = 148;
		E5805987.Text = "API URL:";
		cbbBrowserVersion.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbBrowserVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbBrowserVersion.FormattingEnabled = true;
		cbbBrowserVersion.Location = new System.Drawing.Point(116, 33);
		cbbBrowserVersion.Name = "cbbBrowserVersion";
		cbbBrowserVersion.Size = new System.Drawing.Size(204, 24);
		cbbBrowserVersion.TabIndex = 34;
		label68.AutoSize = true;
		label68.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label68.Location = new System.Drawing.Point(5, 36);
		label68.Name = "label68";
		label68.Size = new System.Drawing.Size(106, 16);
		label68.TabIndex = 33;
		label68.Text = "Browser Version:";
		ckbGpmLogin.AutoSize = true;
		ckbGpmLogin.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbGpmLogin.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbGpmLogin.Location = new System.Drawing.Point(32, 244);
		ckbGpmLogin.Name = "ckbGpmLogin";
		ckbGpmLogin.Size = new System.Drawing.Size(137, 20);
		ckbGpmLogin.TabIndex = 161;
		ckbGpmLogin.Text = "Sư\u0309 du\u0323ng GPM Login";
		ckbGpmLogin.UseVisualStyleBackColor = true;
		ckbGpmLogin.CheckedChanged += new System.EventHandler(ckbGpmLogin_CheckedChanged);
		BE32A023.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		BE32A023.Controls.Add(B8A56C10);
		BE32A023.Controls.Add(CE8CD509);
		BE32A023.Controls.Add(label51);
		BE32A023.Location = new System.Drawing.Point(173, 165);
		BE32A023.Name = "plGologin";
		BE32A023.Size = new System.Drawing.Size(390, 27);
		BE32A023.TabIndex = 156;
		BE32A023.Click += new System.EventHandler(panel3_Click);
		B8A56C10.Location = new System.Drawing.Point(116, 1);
		B8A56C10.Name = "txtOrbitaPath";
		B8A56C10.Size = new System.Drawing.Size(204, 23);
		B8A56C10.TabIndex = 149;
		CE8CD509.AutoSize = true;
		CE8CD509.Location = new System.Drawing.Point(322, 4);
		CE8CD509.Name = "linkLabel1";
		CE8CD509.Size = new System.Drawing.Size(62, 16);
		CE8CD509.TabIndex = 150;
		CE8CD509.TabStop = true;
		CE8CD509.Text = "download";
		CE8CD509.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(B51DA58E);
		label51.AutoSize = true;
		label51.Location = new System.Drawing.Point(-1, 5);
		label51.Name = "label51";
		label51.Size = new System.Drawing.Size(118, 16);
		label51.TabIndex = 148;
		label51.Text = "Orbita chrome.exe:";
		A6A6CA1E.Cursor = System.Windows.Forms.Cursors.Hand;
		A6A6CA1E.Location = new System.Drawing.Point(429, 107);
		A6A6CA1E.Name = "button9";
		A6A6CA1E.Size = new System.Drawing.Size(137, 26);
		A6A6CA1E.TabIndex = 160;
		A6A6CA1E.Text = "Update Chromedriver";
		A6A6CA1E.UseVisualStyleBackColor = true;
		A6A6CA1E.Click += new System.EventHandler(A6A6CA1E_Click);
		AE0FFF89.Controls.Add(nudDelayOpenChromeTo);
		AE0FFF89.Controls.Add(DE26B731);
		AE0FFF89.Controls.Add(label20);
		AE0FFF89.Controls.Add(plDelayCloseChrome);
		AE0FFF89.Controls.Add(label29);
		AE0FFF89.Controls.Add(ckbDelayCloseChrome);
		AE0FFF89.Location = new System.Drawing.Point(31, 77);
		AE0FFF89.Name = "plSizeChrome";
		AE0FFF89.Size = new System.Drawing.Size(535, 25);
		AE0FFF89.TabIndex = 155;
		nudDelayOpenChromeTo.Location = new System.Drawing.Point(204, 1);
		nudDelayOpenChromeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayOpenChromeTo.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		nudDelayOpenChromeTo.Name = "nudDelayOpenChromeTo";
		nudDelayOpenChromeTo.Size = new System.Drawing.Size(41, 23);
		nudDelayOpenChromeTo.TabIndex = 151;
		nudDelayOpenChromeTo.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		DE26B731.Location = new System.Drawing.Point(142, 1);
		DE26B731.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		DE26B731.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		DE26B731.Name = "nudDelayOpenChromeFrom";
		DE26B731.Size = new System.Drawing.Size(41, 23);
		DE26B731.TabIndex = 151;
		DE26B731.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		label20.AutoSize = true;
		label20.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label20.Location = new System.Drawing.Point(-3, 3);
		label20.Name = "label20";
		label20.Size = new System.Drawing.Size(144, 16);
		label20.TabIndex = 33;
		label20.Text = "Delay Open chrome (s):";
		plDelayCloseChrome.Controls.Add(nudDelayCloseChromeTo);
		plDelayCloseChrome.Controls.Add(nudDelayCloseChromeFrom);
		plDelayCloseChrome.Controls.Add(label2);
		plDelayCloseChrome.Location = new System.Drawing.Point(425, 0);
		plDelayCloseChrome.Name = "plDelayCloseChrome";
		plDelayCloseChrome.Size = new System.Drawing.Size(111, 24);
		plDelayCloseChrome.TabIndex = 159;
		nudDelayCloseChromeTo.Location = new System.Drawing.Point(66, 1);
		nudDelayCloseChromeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayCloseChromeTo.Name = "nudDelayCloseChromeTo";
		nudDelayCloseChromeTo.Size = new System.Drawing.Size(43, 23);
		nudDelayCloseChromeTo.TabIndex = 151;
		nudDelayCloseChromeFrom.Location = new System.Drawing.Point(1, 1);
		nudDelayCloseChromeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayCloseChromeFrom.Name = "nudDelayCloseChromeFrom";
		nudDelayCloseChromeFrom.Size = new System.Drawing.Size(44, 23);
		nudDelayCloseChromeFrom.TabIndex = 151;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label2.Location = new System.Drawing.Point(44, 4);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(23, 16);
		label2.TabIndex = 33;
		label2.Text = ">";
		label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label29.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label29.Location = new System.Drawing.Point(182, 4);
		label29.Name = "label29";
		label29.Size = new System.Drawing.Size(23, 16);
		label29.TabIndex = 33;
		label29.Text = ">";
		label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		ckbDelayCloseChrome.AutoSize = true;
		ckbDelayCloseChrome.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbDelayCloseChrome.Location = new System.Drawing.Point(264, 2);
		ckbDelayCloseChrome.Name = "ckbDelayCloseChrome";
		ckbDelayCloseChrome.Size = new System.Drawing.Size(166, 20);
		ckbDelayCloseChrome.TabIndex = 158;
		ckbDelayCloseChrome.Text = "Delay Close Chrome (s):";
		ckbDelayCloseChrome.UseVisualStyleBackColor = true;
		ckbDelayCloseChrome.CheckedChanged += new System.EventHandler(ckbDelayCloseChrome_CheckedChanged);
		btnDown.BackgroundImage = C50FB39E.Bitmap_89;
		btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		btnDown.Location = new System.Drawing.Point(512, 8);
		btnDown.Name = "btnDown";
		btnDown.Size = new System.Drawing.Size(25, 25);
		btnDown.TabIndex = 158;
		btnDown.Click += new System.EventHandler(btnDown_Click);
		D027A8A9.BackgroundImage = C50FB39E.Bitmap_74;
		D027A8A9.Cursor = System.Windows.Forms.Cursors.Hand;
		D027A8A9.Location = new System.Drawing.Point(543, 8);
		D027A8A9.Name = "btnUp";
		D027A8A9.Size = new System.Drawing.Size(25, 25);
		D027A8A9.TabIndex = 159;
		D027A8A9.Click += new System.EventHandler(F014E611);
		cbbTocDoGoVanBan.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTocDoGoVanBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTocDoGoVanBan.FormattingEnabled = true;
		cbbTocDoGoVanBan.Items.AddRange(new object[3] { "Chậm", "Bình thường", "Nhanh" });
		cbbTocDoGoVanBan.Location = new System.Drawing.Point(173, 107);
		cbbTocDoGoVanBan.Name = "cbbTocDoGoVanBan";
		cbbTocDoGoVanBan.Size = new System.Drawing.Size(102, 24);
		cbbTocDoGoVanBan.TabIndex = 34;
		label30.AutoSize = true;
		label30.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label30.Location = new System.Drawing.Point(28, 110);
		label30.Name = "label30";
		label30.Size = new System.Drawing.Size(118, 16);
		label30.TabIndex = 33;
		label30.Text = "Tốc độ gõ văn bản:";
		plSapXepCuaSoChrome.Controls.Add(cbbColumnChrome);
		plSapXepCuaSoChrome.Controls.Add(label10);
		plSapXepCuaSoChrome.Controls.Add(cbbRowChrome);
		plSapXepCuaSoChrome.Controls.Add(label11);
		plSapXepCuaSoChrome.Location = new System.Drawing.Point(25, 44);
		plSapXepCuaSoChrome.Name = "plSapXepCuaSoChrome";
		plSapXepCuaSoChrome.Size = new System.Drawing.Size(251, 29);
		plSapXepCuaSoChrome.TabIndex = 157;
		cbbColumnChrome.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbColumnChrome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbColumnChrome.FormattingEnabled = true;
		cbbColumnChrome.Items.AddRange(new object[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
		cbbColumnChrome.Location = new System.Drawing.Point(148, 2);
		cbbColumnChrome.Name = "cbbColumnChrome";
		cbbColumnChrome.Size = new System.Drawing.Size(40, 24);
		cbbColumnChrome.TabIndex = 145;
		label10.AutoSize = true;
		label10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label10.Location = new System.Drawing.Point(3, 5);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(147, 16);
		label10.TabIndex = 33;
		label10.Text = "Sắp xếp cửa sổ chrome:";
		cbbRowChrome.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbRowChrome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbRowChrome.FormattingEnabled = true;
		cbbRowChrome.Items.AddRange(new object[5] { "1", "2", "3", "4", "5" });
		cbbRowChrome.Location = new System.Drawing.Point(210, 2);
		cbbRowChrome.Name = "cbbRowChrome";
		cbbRowChrome.Size = new System.Drawing.Size(40, 24);
		cbbRowChrome.TabIndex = 145;
		label11.AutoSize = true;
		label11.Font = new System.Drawing.Font("Tahoma", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label11.Location = new System.Drawing.Point(188, 2);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(23, 23);
		label11.TabIndex = 33;
		label11.Text = "X";
		nudChromeScale.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		nudChromeScale.Location = new System.Drawing.Point(378, 108);
		nudChromeScale.Minimum = new decimal(new int[4] { 10, 0, 0, 0 });
		nudChromeScale.Name = "nudChromeScale";
		nudChromeScale.Size = new System.Drawing.Size(45, 23);
		nudChromeScale.TabIndex = 24;
		nudChromeScale.Value = new decimal(new int[4] { 100, 0, 0, 0 });
		nudChromeScale.Visible = false;
		FAB3AA84.Controls.Add(nudWidthChrome);
		FAB3AA84.Controls.Add(nudHeighChrome);
		FAB3AA84.Controls.Add(EC82A387);
		FAB3AA84.Location = new System.Drawing.Point(456, 45);
		FAB3AA84.Name = "plAddChromeVaoFormView";
		FAB3AA84.Size = new System.Drawing.Size(110, 27);
		FAB3AA84.TabIndex = 156;
		nudWidthChrome.Location = new System.Drawing.Point(1, 2);
		nudWidthChrome.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudWidthChrome.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		nudWidthChrome.Name = "nudWidthChrome";
		nudWidthChrome.Size = new System.Drawing.Size(43, 23);
		nudWidthChrome.TabIndex = 151;
		nudWidthChrome.Value = new decimal(new int[4] { 320, 0, 0, 0 });
		nudHeighChrome.Location = new System.Drawing.Point(66, 2);
		nudHeighChrome.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudHeighChrome.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		nudHeighChrome.Name = "nudHeighChrome";
		nudHeighChrome.Size = new System.Drawing.Size(43, 23);
		nudHeighChrome.TabIndex = 151;
		nudHeighChrome.Value = new decimal(new int[4] { 480, 0, 0, 0 });
		EC82A387.AutoSize = true;
		EC82A387.Font = new System.Drawing.Font("Tahoma", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		EC82A387.Location = new System.Drawing.Point(44, 2);
		EC82A387.Name = "label35";
		EC82A387.Size = new System.Drawing.Size(23, 23);
		EC82A387.TabIndex = 33;
		EC82A387.Text = "X";
		lblChromeScale.AutoSize = true;
		lblChromeScale.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblChromeScale.Location = new System.Drawing.Point(292, 110);
		lblChromeScale.Name = "lblChromeScale";
		lblChromeScale.Size = new System.Drawing.Size(86, 16);
		lblChromeScale.TabIndex = 23;
		lblChromeScale.Text = "Ty\u0309 lê\u0323 hiê\u0309n thi\u0323:";
		lblChromeScale.Visible = false;
		AddFileAccount.BackgroundImage = C50FB39E.C61A8C30;
		AddFileAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		AddFileAccount.Cursor = System.Windows.Forms.Cursors.Hand;
		AddFileAccount.Location = new System.Drawing.Point(414, 77);
		AddFileAccount.Name = "AddFileAccount";
		AddFileAccount.Size = new System.Drawing.Size(25, 25);
		AddFileAccount.TabIndex = 154;
		AddFileAccount.Click += new System.EventHandler(AddFileAccount_Click);
		ckbGologin.AutoSize = true;
		ckbGologin.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbGologin.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbGologin.Location = new System.Drawing.Point(32, 169);
		ckbGologin.Name = "ckbGologin";
		ckbGologin.Size = new System.Drawing.Size(120, 20);
		ckbGologin.TabIndex = 112;
		ckbGologin.Text = "Sư\u0309 du\u0323ng Gologin";
		ckbGologin.UseVisualStyleBackColor = true;
		ckbGologin.CheckedChanged += new System.EventHandler(BEB56D19);
		ckbUseExtensionProxy.AutoSize = true;
		ckbUseExtensionProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbUseExtensionProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbUseExtensionProxy.Location = new System.Drawing.Point(32, 324);
		ckbUseExtensionProxy.Name = "ckbUseExtensionProxy";
		ckbUseExtensionProxy.Size = new System.Drawing.Size(140, 20);
		ckbUseExtensionProxy.TabIndex = 112;
		ckbUseExtensionProxy.Text = "Use extension proxy";
		ckbUseExtensionProxy.UseVisualStyleBackColor = true;
		EB0A133E.AutoSize = true;
		EB0A133E.Cursor = System.Windows.Forms.Cursors.Hand;
		EB0A133E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EB0A133E.Location = new System.Drawing.Point(295, 22);
		EB0A133E.Name = "ckbHideBrowser";
		EB0A133E.Size = new System.Drawing.Size(88, 20);
		EB0A133E.TabIndex = 112;
		EB0A133E.Text = "Ẩn chrome";
		EB0A133E.UseVisualStyleBackColor = true;
		EB0A133E.Visible = false;
		ckbShowImageInteract.AutoSize = true;
		ckbShowImageInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbShowImageInteract.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbShowImageInteract.Location = new System.Drawing.Point(32, 22);
		ckbShowImageInteract.Name = "ckbShowImageInteract";
		ckbShowImageInteract.Size = new System.Drawing.Size(183, 20);
		ckbShowImageInteract.TabIndex = 112;
		ckbShowImageInteract.Text = "Hiê\u0323n a\u0309nh khi mơ\u0309 tri\u0300nh duyê\u0323t";
		ckbShowImageInteract.UseVisualStyleBackColor = true;
		ckbAddChromeIntoForm.AutoSize = true;
		ckbAddChromeIntoForm.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAddChromeIntoForm.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbAddChromeIntoForm.Location = new System.Drawing.Point(295, 48);
		ckbAddChromeIntoForm.Name = "ckbAddChromeIntoForm";
		ckbAddChromeIntoForm.Size = new System.Drawing.Size(163, 20);
		ckbAddChromeIntoForm.TabIndex = 112;
		ckbAddChromeIntoForm.Text = "Add Chrome Form View";
		ckbAddChromeIntoForm.UseVisualStyleBackColor = true;
		ckbAddChromeIntoForm.CheckedChanged += new System.EventHandler(ckbAddChromeIntoForm_CheckedChanged);
		cbbSizeChrome.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbSizeChrome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbSizeChrome.DropDownWidth = 200;
		cbbSizeChrome.FormattingEnabled = true;
		cbbSizeChrome.Location = new System.Drawing.Point(225, 78);
		cbbSizeChrome.Name = "cbbSizeChrome";
		cbbSizeChrome.Size = new System.Drawing.Size(183, 24);
		cbbSizeChrome.TabIndex = 145;
		EE983832.AutoSize = true;
		EE983832.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EE983832.Location = new System.Drawing.Point(28, 83);
		EE983832.Name = "label34";
		EE983832.Size = new System.Drawing.Size(160, 16);
		EE983832.TabIndex = 33;
		EE983832.Text = "Kích thước cửa số chrome:";
		panel3.Controls.Add(D98C5BB4);
		panel3.Controls.Add(A184BE1A);
		panel3.Location = new System.Drawing.Point(30, 136);
		panel3.Name = "panel3";
		panel3.Size = new System.Drawing.Size(535, 25);
		panel3.TabIndex = 156;
		panel3.Click += new System.EventHandler(panel3_Click);
		D98C5BB4.AutoSize = true;
		D98C5BB4.Location = new System.Drawing.Point(-3, 4);
		D98C5BB4.Name = "label19";
		D98C5BB4.Size = new System.Drawing.Size(108, 16);
		D98C5BB4.TabIndex = 148;
		D98C5BB4.Text = "Path chrome.exe:";
		A184BE1A.Location = new System.Drawing.Point(143, 1);
		A184BE1A.Name = "txtLinkToOtherBrowser";
		A184BE1A.Size = new System.Drawing.Size(390, 23);
		A184BE1A.TabIndex = 149;
		D238682D.Controls.Add(txtPathToPortableZip);
		D238682D.Controls.Add(B213D1B8);
		D238682D.Controls.Add(ckbUsePortable);
		D238682D.Location = new System.Drawing.Point(30, 136);
		D238682D.Name = "plUsePortable";
		D238682D.Size = new System.Drawing.Size(502, 25);
		D238682D.TabIndex = 155;
		D238682D.Paint += new System.Windows.Forms.PaintEventHandler(D238682D_Paint);
		txtPathToPortableZip.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		txtPathToPortableZip.Location = new System.Drawing.Point(194, 1);
		txtPathToPortableZip.Name = "txtPathToPortableZip";
		txtPathToPortableZip.Size = new System.Drawing.Size(305, 23);
		txtPathToPortableZip.TabIndex = 32;
		txtPathToPortableZip.Click += new System.EventHandler(txtPathToPortableZip_Click);
		B213D1B8.AutoSize = true;
		B213D1B8.Location = new System.Drawing.Point(139, 4);
		B213D1B8.Name = "lblFileZip";
		B213D1B8.Size = new System.Drawing.Size(52, 16);
		B213D1B8.TabIndex = 113;
		B213D1B8.Text = "File zip:";
		ckbUsePortable.AutoSize = true;
		ckbUsePortable.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbUsePortable.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbUsePortable.Location = new System.Drawing.Point(0, 3);
		ckbUsePortable.Name = "ckbUsePortable";
		ckbUsePortable.Size = new System.Drawing.Size(125, 20);
		ckbUsePortable.TabIndex = 112;
		ckbUsePortable.Text = "Sử dụng Portable";
		ckbUsePortable.UseVisualStyleBackColor = true;
		ckbUsePortable.CheckedChanged += new System.EventHandler(E5251224);
		grEmailConfigs.Controls.Add(label31);
		grEmailConfigs.Controls.Add(BC1D18BF);
		grEmailConfigs.Controls.Add(F795862C);
		grEmailConfigs.Controls.Add(FE01E21E);
		grEmailConfigs.Controls.Add(BF98EA14);
		grEmailConfigs.Controls.Add(D5154C8C);
		grEmailConfigs.Controls.Add(CF2A9AA2);
		grEmailConfigs.Controls.Add(FBA38325);
		grEmailConfigs.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		grEmailConfigs.Location = new System.Drawing.Point(7, 241);
		grEmailConfigs.Name = "grEmailConfigs";
		grEmailConfigs.Size = new System.Drawing.Size(568, 166);
		grEmailConfigs.TabIndex = 38;
		grEmailConfigs.TabStop = false;
		grEmailConfigs.Text = "Cấu hình email";
		label31.AutoSize = true;
		label31.Location = new System.Drawing.Point(29, 97);
		label31.Name = "label31";
		label31.Size = new System.Drawing.Size(145, 16);
		label31.TabIndex = 153;
		label31.Text = "https://unlimitmail.com/";
		BC1D18BF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		BC1D18BF.Controls.Add(label57);
		BC1D18BF.Controls.Add(txtTokenUnlimitMail);
		BC1D18BF.Location = new System.Drawing.Point(187, 92);
		BC1D18BF.Name = "panel7";
		BC1D18BF.Size = new System.Drawing.Size(375, 31);
		BC1D18BF.TabIndex = 154;
		label57.AutoSize = true;
		label57.Location = new System.Drawing.Point(-1, 6);
		label57.Name = "label57";
		label57.Size = new System.Drawing.Size(76, 16);
		label57.TabIndex = 46;
		label57.Text = "Nhập token:";
		txtTokenUnlimitMail.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtTokenUnlimitMail.Location = new System.Drawing.Point(86, 3);
		txtTokenUnlimitMail.Name = "txtTokenUnlimitMail";
		txtTokenUnlimitMail.Size = new System.Drawing.Size(284, 23);
		txtTokenUnlimitMail.TabIndex = 47;
		F795862C.AutoSize = true;
		F795862C.Location = new System.Drawing.Point(29, 23);
		F795862C.Name = "label58";
		F795862C.Size = new System.Drawing.Size(55, 16);
		F795862C.TabIndex = 46;
		F795862C.Text = "Hotmail:";
		FE01E21E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		FE01E21E.Controls.Add(D18B4C95);
		FE01E21E.Location = new System.Drawing.Point(187, 18);
		FE01E21E.Name = "panel4";
		FE01E21E.Size = new System.Drawing.Size(375, 31);
		FE01E21E.TabIndex = 152;
		D18B4C95.AutoSize = true;
		D18B4C95.Cursor = System.Windows.Forms.Cursors.Hand;
		D18B4C95.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D18B4C95.Location = new System.Drawing.Point(2, 5);
		D18B4C95.Name = "ckbGetOtpHotmailChrome";
		D18B4C95.Size = new System.Drawing.Size(310, 20);
		D18B4C95.TabIndex = 157;
		D18B4C95.Text = "Mở chrome để lấy otp nếu không thể kết nối Imap";
		D18B4C95.UseVisualStyleBackColor = true;
		BF98EA14.AutoSize = true;
		BF98EA14.Location = new System.Drawing.Point(29, 60);
		BF98EA14.Name = "label60";
		BF98EA14.Size = new System.Drawing.Size(140, 16);
		BF98EA14.TabIndex = 46;
		BF98EA14.Text = "http://generator.email/";
		D5154C8C.AutoSize = true;
		D5154C8C.Location = new System.Drawing.Point(29, 134);
		D5154C8C.Name = "label56";
		D5154C8C.Size = new System.Drawing.Size(152, 16);
		D5154C8C.TabIndex = 46;
		D5154C8C.Text = "https://donglaomail.com/";
		CF2A9AA2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		CF2A9AA2.Controls.Add(D6AB5A82);
		CF2A9AA2.Controls.Add(DD824319);
		CF2A9AA2.Location = new System.Drawing.Point(187, 55);
		CF2A9AA2.Name = "panel6";
		CF2A9AA2.Size = new System.Drawing.Size(375, 31);
		CF2A9AA2.TabIndex = 152;
		D6AB5A82.AutoSize = true;
		D6AB5A82.Location = new System.Drawing.Point(-1, 6);
		D6AB5A82.Name = "label59";
		D6AB5A82.Size = new System.Drawing.Size(87, 16);
		D6AB5A82.TabIndex = 46;
		D6AB5A82.Text = "Nhập domain:";
		DD824319.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DD824319.Cursor = System.Windows.Forms.Cursors.Hand;
		DD824319.Location = new System.Drawing.Point(86, 2);
		DD824319.Name = "button6";
		DD824319.Size = new System.Drawing.Size(285, 25);
		DD824319.TabIndex = 35;
		DD824319.Text = "Nhập";
		DD824319.UseVisualStyleBackColor = true;
		DD824319.Click += new System.EventHandler(DD824319_Click);
		FBA38325.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		FBA38325.Controls.Add(D33B3D3E);
		FBA38325.Controls.Add(txtTokenDonglaomail);
		FBA38325.Location = new System.Drawing.Point(187, 129);
		FBA38325.Name = "plGetCode2FA";
		FBA38325.Size = new System.Drawing.Size(375, 31);
		FBA38325.TabIndex = 152;
		D33B3D3E.AutoSize = true;
		D33B3D3E.Location = new System.Drawing.Point(-1, 6);
		D33B3D3E.Name = "label52";
		D33B3D3E.Size = new System.Drawing.Size(76, 16);
		D33B3D3E.TabIndex = 46;
		D33B3D3E.Text = "Nhập token:";
		txtTokenDonglaomail.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtTokenDonglaomail.Location = new System.Drawing.Point(86, 3);
		txtTokenDonglaomail.Name = "txtTokenDonglaomail";
		txtTokenDonglaomail.Size = new System.Drawing.Size(284, 23);
		txtTokenDonglaomail.TabIndex = 47;
		txtMysqlServer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtMysqlServer.Location = new System.Drawing.Point(194, 379);
		txtMysqlServer.Name = "txtMysqlServer";
		txtMysqlServer.Size = new System.Drawing.Size(375, 23);
		txtMysqlServer.TabIndex = 47;
		grCauHinhKhac.Controls.Add(D132643A);
		grCauHinhKhac.Controls.Add(ckbBackupDB);
		grCauHinhKhac.Controls.Add(C91FC226);
		grCauHinhKhac.Controls.Add(cbbTypePhanBietMau);
		grCauHinhKhac.Controls.Add(C28D9186);
		grCauHinhKhac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		grCauHinhKhac.Location = new System.Drawing.Point(580, 332);
		grCauHinhKhac.Name = "grCauHinhKhac";
		grCauHinhKhac.Size = new System.Drawing.Size(470, 75);
		grCauHinhKhac.TabIndex = 38;
		grCauHinhKhac.TabStop = false;
		grCauHinhKhac.Text = "Cấu hình khác";
		D132643A.AutoSize = true;
		D132643A.Location = new System.Drawing.Point(351, 50);
		D132643A.Name = "lblSelectBackupDB";
		D132643A.Size = new System.Drawing.Size(42, 16);
		D132643A.TabIndex = 153;
		D132643A.TabStop = true;
		D132643A.Text = "Select";
		D132643A.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(D132643A_LinkClicked);
		ckbBackupDB.AutoSize = true;
		ckbBackupDB.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbBackupDB.Location = new System.Drawing.Point(229, 49);
		ckbBackupDB.Name = "ckbBackupDB";
		ckbBackupDB.Size = new System.Drawing.Size(127, 20);
		ckbBackupDB.TabIndex = 152;
		ckbBackupDB.Text = "Backup Database ";
		ckbBackupDB.UseVisualStyleBackColor = true;
		ckbBackupDB.CheckedChanged += new System.EventHandler(D3AD878F);
		C91FC226.AutoSize = true;
		C91FC226.Cursor = System.Windows.Forms.Cursors.Hand;
		C91FC226.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C91FC226.Location = new System.Drawing.Point(32, 49);
		C91FC226.Name = "ckbLuuTrangThai";
		C91FC226.Size = new System.Drawing.Size(184, 20);
		C91FC226.TabIndex = 157;
		C91FC226.Text = "Lưu dư\u0303 liê\u0323u cô\u0323t [Tra\u0323ng tha\u0301i]";
		C91FC226.UseVisualStyleBackColor = true;
		cbbTypePhanBietMau.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTypePhanBietMau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTypePhanBietMau.FormattingEnabled = true;
		cbbTypePhanBietMau.Location = new System.Drawing.Point(229, 19);
		cbbTypePhanBietMau.Name = "cbbTypePhanBietMau";
		cbbTypePhanBietMau.Size = new System.Drawing.Size(161, 24);
		cbbTypePhanBietMau.TabIndex = 34;
		C28D9186.AutoSize = true;
		C28D9186.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C28D9186.Location = new System.Drawing.Point(29, 22);
		C28D9186.Name = "label23";
		C28D9186.Size = new System.Drawing.Size(194, 16);
		C28D9186.TabIndex = 33;
		C28D9186.Text = "Phân biệt [Tình trạng tài khoản]:";
		plVitech.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plVitech.Controls.Add(txtListProxyVitech);
		plVitech.Controls.Add(D60D659C);
		plVitech.Controls.Add(radioButton10);
		plVitech.Controls.Add(label40);
		plVitech.Controls.Add(label41);
		plVitech.Controls.Add(label42);
		plVitech.Controls.Add(nudLuongPerIPVitech);
		plVitech.Controls.Add(label46);
		plVitech.Controls.Add(txtApiVitech);
		plVitech.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		plVitech.Location = new System.Drawing.Point(11, 909);
		plVitech.Name = "plVitech";
		plVitech.Size = new System.Drawing.Size(266, 170);
		plVitech.TabIndex = 151;
		plVitech.Visible = false;
		txtListProxyVitech.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtListProxyVitech.Location = new System.Drawing.Point(6, 71);
		txtListProxyVitech.Name = "txtListProxyVitech";
		txtListProxyVitech.Size = new System.Drawing.Size(255, 68);
		txtListProxyVitech.TabIndex = 144;
		txtListProxyVitech.Text = "";
		txtListProxyVitech.WordWrap = false;
		txtListProxyVitech.TextChanged += new System.EventHandler(txtListProxyVitech_TextChanged);
		D60D659C.AutoSize = true;
		D60D659C.Cursor = System.Windows.Forms.Cursors.Hand;
		D60D659C.Enabled = false;
		D60D659C.Location = new System.Drawing.Point(137, 28);
		D60D659C.Name = "radioButton9";
		D60D659C.Size = new System.Drawing.Size(59, 20);
		D60D659C.TabIndex = 82;
		D60D659C.Text = "Sock5";
		D60D659C.UseVisualStyleBackColor = true;
		radioButton10.AutoSize = true;
		radioButton10.Checked = true;
		radioButton10.Cursor = System.Windows.Forms.Cursors.Hand;
		radioButton10.Location = new System.Drawing.Point(74, 28);
		radioButton10.Name = "radioButton10";
		radioButton10.Size = new System.Drawing.Size(48, 20);
		radioButton10.TabIndex = 82;
		radioButton10.TabStop = true;
		radioButton10.Text = "Http";
		radioButton10.UseVisualStyleBackColor = true;
		label40.AutoSize = true;
		label40.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label40.Location = new System.Drawing.Point(3, 28);
		label40.Name = "label40";
		label40.Size = new System.Drawing.Size(70, 16);
		label40.TabIndex = 79;
		label40.Text = "Loại Proxy:";
		label41.AutoSize = true;
		label41.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label41.Location = new System.Drawing.Point(3, 50);
		label41.Name = "label41";
		label41.Size = new System.Drawing.Size(97, 16);
		label41.TabIndex = 79;
		label41.Text = "Nhập Proxy (0):";
		label42.AutoSize = true;
		label42.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label42.Location = new System.Drawing.Point(5, 143);
		label42.Name = "label42";
		label42.Size = new System.Drawing.Size(78, 16);
		label42.TabIndex = 139;
		label42.Text = "Số luồng/IP:";
		nudLuongPerIPVitech.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudLuongPerIPVitech.Location = new System.Drawing.Point(90, 142);
		nudLuongPerIPVitech.Name = "nudLuongPerIPVitech";
		nudLuongPerIPVitech.Size = new System.Drawing.Size(67, 23);
		nudLuongPerIPVitech.TabIndex = 140;
		nudLuongPerIPVitech.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		label46.AutoSize = true;
		label46.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label46.Location = new System.Drawing.Point(3, 5);
		label46.Name = "label46";
		label46.Size = new System.Drawing.Size(55, 16);
		label46.TabIndex = 79;
		label46.Text = "API Key:";
		txtApiVitech.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		txtApiVitech.ForeColor = System.Drawing.Color.Black;
		txtApiVitech.Location = new System.Drawing.Point(74, 2);
		txtApiVitech.Name = "txtApiVitech";
		txtApiVitech.Size = new System.Drawing.Size(187, 23);
		txtApiVitech.TabIndex = 81;
		cbbHostpot.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbHostpot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbHostpot.Enabled = false;
		cbbHostpot.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		cbbHostpot.ForeColor = System.Drawing.Color.Black;
		cbbHostpot.FormattingEnabled = true;
		cbbHostpot.Items.AddRange(new object[2] { "Chi\u0309 trong quô\u0301c gia đang cho\u0323n", "Toa\u0300n bô\u0323 quô\u0301c gia" });
		cbbHostpot.Location = new System.Drawing.Point(1177, 563);
		cbbHostpot.Name = "cbbHostpot";
		cbbHostpot.Size = new System.Drawing.Size(229, 24);
		cbbHostpot.TabIndex = 144;
		ckbMysqlServer.AutoSize = true;
		ckbMysqlServer.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbMysqlServer.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbMysqlServer.Location = new System.Drawing.Point(37, 381);
		ckbMysqlServer.Name = "ckbMysqlServer";
		ckbMysqlServer.Size = new System.Drawing.Size(110, 20);
		ckbMysqlServer.TabIndex = 112;
		ckbMysqlServer.Text = "MySQL server:";
		ckbMysqlServer.UseVisualStyleBackColor = true;
		ckbMysqlServer.CheckedChanged += new System.EventHandler(CE373314);
		C7B4508F.AutoSize = true;
		C7B4508F.Cursor = System.Windows.Forms.Cursors.Hand;
		C7B4508F.Enabled = false;
		C7B4508F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		C7B4508F.Location = new System.Drawing.Point(11, 885);
		C7B4508F.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		C7B4508F.Name = "rbVitech";
		C7B4508F.Size = new System.Drawing.Size(145, 20);
		C7B4508F.TabIndex = 150;
		C7B4508F.Text = "VitechCheap(Sắp có)";
		C7B4508F.UseVisualStyleBackColor = true;
		C7B4508F.Visible = false;
		A200A21D.BackColor = System.Drawing.Color.White;
		A200A21D.BorderRadius = 0;
		A200A21D.BottomSahddow = true;
		A200A21D.color = System.Drawing.Color.SaddleBrown;
		A200A21D.Controls.Add(pnlHeader);
		A200A21D.Dock = System.Windows.Forms.DockStyle.Top;
		A200A21D.LeftSahddow = false;
		A200A21D.Location = new System.Drawing.Point(0, 0);
		A200A21D.Name = "bunifuCards2";
		A200A21D.RightSahddow = true;
		A200A21D.ShadowDepth = 20;
		A200A21D.Size = new System.Drawing.Size(1057, 37);
		A200A21D.TabIndex = 40;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(CA3ADC0D);
		pnlHeader.Controls.Add(B7B5A3AC);
		pnlHeader.Controls.Add(B49F18BB);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(1057, 31);
		pnlHeader.TabIndex = 9;
		CA3ADC0D.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		CA3ADC0D.Cursor = System.Windows.Forms.Cursors.Hand;
		CA3ADC0D.FlatAppearance.BorderSize = 0;
		CA3ADC0D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		CA3ADC0D.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		CA3ADC0D.ForeColor = System.Drawing.Color.White;
		CA3ADC0D.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
		CA3ADC0D.Location = new System.Drawing.Point(1026, 1);
		CA3ADC0D.Name = "button2";
		CA3ADC0D.Size = new System.Drawing.Size(30, 30);
		CA3ADC0D.TabIndex = 77;
		CA3ADC0D.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		CA3ADC0D.UseVisualStyleBackColor = true;
		CA3ADC0D.Click += new System.EventHandler(btnCancel_Click);
		B7B5A3AC.Cursor = System.Windows.Forms.Cursors.Default;
		B7B5A3AC.Image = C50FB39E.Bitmap_5;
		B7B5A3AC.Location = new System.Drawing.Point(3, 2);
		B7B5A3AC.Name = "pictureBox1";
		B7B5A3AC.Size = new System.Drawing.Size(34, 27);
		B7B5A3AC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		B7B5A3AC.TabIndex = 76;
		B7B5A3AC.TabStop = false;
		B7B5A3AC.Click += new System.EventHandler(C48C2237);
		B49F18BB.BackColor = System.Drawing.Color.Transparent;
		B49F18BB.Cursor = System.Windows.Forms.Cursors.SizeAll;
		B49F18BB.Dock = System.Windows.Forms.DockStyle.Fill;
		B49F18BB.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B49F18BB.ForeColor = System.Drawing.Color.Black;
		B49F18BB.Location = new System.Drawing.Point(0, 0);
		B49F18BB.Name = "bunifuCustomLabel1";
		B49F18BB.Size = new System.Drawing.Size(1057, 31);
		B49F18BB.TabIndex = 12;
		B49F18BB.Text = "Câ\u0301u hi\u0300nh chung";
		B49F18BB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(580, 417);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 20;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel2.Controls.Add(label12);
		panel2.Controls.Add(ABB4F9A6);
		panel2.Enabled = false;
		panel2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		panel2.Location = new System.Drawing.Point(1176, 475);
		panel2.Name = "panel2";
		panel2.Size = new System.Drawing.Size(232, 30);
		panel2.TabIndex = 142;
		label12.AutoSize = true;
		label12.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label12.Location = new System.Drawing.Point(3, 5);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(75, 16);
		label12.TabIndex = 82;
		label12.Text = "Đường dẫn:";
		ABB4F9A6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		ABB4F9A6.ForeColor = System.Drawing.Color.Black;
		ABB4F9A6.Location = new System.Drawing.Point(87, 2);
		ABB4F9A6.Name = "textBox1";
		ABB4F9A6.Size = new System.Drawing.Size(142, 23);
		ABB4F9A6.TabIndex = 83;
		btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		btnSave.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
		btnSave.FlatAppearance.BorderSize = 0;
		btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnSave.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnSave.ForeColor = System.Drawing.Color.White;
		btnSave.Location = new System.Drawing.Point(483, 417);
		btnSave.Name = "btnSave";
		btnSave.Size = new System.Drawing.Size(92, 29);
		btnSave.TabIndex = 19;
		btnSave.Text = "Lưu";
		btnSave.UseVisualStyleBackColor = false;
		btnSave.Click += new System.EventHandler(D69A6C8A);
		FF152B09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		FF152B09.Controls.Add(B9B6C73C);
		FF152B09.Controls.Add(txtNordVPN);
		FF152B09.Enabled = false;
		FF152B09.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		FF152B09.Location = new System.Drawing.Point(1176, 475);
		FF152B09.Name = "plNordVPN";
		FF152B09.Size = new System.Drawing.Size(232, 30);
		FF152B09.TabIndex = 142;
		B9B6C73C.AutoSize = true;
		B9B6C73C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		B9B6C73C.Location = new System.Drawing.Point(3, 5);
		B9B6C73C.Name = "label14";
		B9B6C73C.Size = new System.Drawing.Size(75, 16);
		B9B6C73C.TabIndex = 82;
		B9B6C73C.Text = "Đường dẫn:";
		txtNordVPN.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		txtNordVPN.ForeColor = System.Drawing.Color.Black;
		txtNordVPN.Location = new System.Drawing.Point(87, 2);
		txtNordVPN.Name = "txtNordVPN";
		txtNordVPN.Size = new System.Drawing.Size(142, 23);
		txtNordVPN.TabIndex = 83;
		btnSSH.Cursor = System.Windows.Forms.Cursors.Hand;
		btnSSH.Enabled = false;
		btnSSH.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		btnSSH.ForeColor = System.Drawing.Color.Black;
		btnSSH.Location = new System.Drawing.Point(1263, 508);
		btnSSH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		btnSSH.Name = "btnSSH";
		btnSSH.Size = new System.Drawing.Size(106, 26);
		btnSSH.TabIndex = 130;
		btnSSH.Text = "Nhập IP SSH";
		btnSSH.UseVisualStyleBackColor = true;
		btnSSH.Click += new System.EventHandler(btnSSH_Click);
		radioButton4.AutoSize = true;
		radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
		radioButton4.Enabled = false;
		radioButton4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		radioButton4.Location = new System.Drawing.Point(1162, 426);
		radioButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		radioButton4.Name = "radioButton4";
		radioButton4.Size = new System.Drawing.Size(130, 20);
		radioButton4.TabIndex = 133;
		radioButton4.Text = "Đổi IP ExpressVPN";
		radioButton4.UseVisualStyleBackColor = true;
		rbHotspot.AutoSize = true;
		rbHotspot.Enabled = false;
		rbHotspot.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		rbHotspot.Location = new System.Drawing.Point(1162, 539);
		rbHotspot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		rbHotspot.Name = "rbHotspot";
		rbHotspot.Size = new System.Drawing.Size(145, 20);
		rbHotspot.TabIndex = 135;
		rbHotspot.Text = "Đổi IP Hotspot Shield";
		rbHotspot.UseVisualStyleBackColor = true;
		CD04A99E.AutoSize = true;
		CD04A99E.Cursor = System.Windows.Forms.Cursors.Hand;
		CD04A99E.Enabled = false;
		CD04A99E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		CD04A99E.Location = new System.Drawing.Point(1162, 511);
		CD04A99E.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		CD04A99E.Name = "radioButton5";
		CD04A99E.Size = new System.Drawing.Size(87, 20);
		CD04A99E.TabIndex = 132;
		CD04A99E.Text = "Đổi IP SSH";
		CD04A99E.UseVisualStyleBackColor = true;
		rbNordVPN.AutoSize = true;
		rbNordVPN.Enabled = false;
		rbNordVPN.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		rbNordVPN.Location = new System.Drawing.Point(1162, 451);
		rbNordVPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		rbNordVPN.Name = "rbNordVPN";
		rbNordVPN.Size = new System.Drawing.Size(113, 20);
		rbNordVPN.TabIndex = 134;
		rbNordVPN.Text = "Đổi IP NordVPN";
		rbNordVPN.UseVisualStyleBackColor = true;
		rbNordVPN.CheckedChanged += new System.EventHandler(B82C2691);
		radioButton2.AutoSize = true;
		radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
		radioButton2.Enabled = false;
		radioButton2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		radioButton2.Location = new System.Drawing.Point(1162, 539);
		radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		radioButton2.Name = "radioButton2";
		radioButton2.Size = new System.Drawing.Size(145, 20);
		radioButton2.TabIndex = 135;
		radioButton2.Text = "Đổi IP Hotspot Shield";
		radioButton2.UseVisualStyleBackColor = true;
		rbSSH.AutoSize = true;
		rbSSH.Enabled = false;
		rbSSH.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		rbSSH.Location = new System.Drawing.Point(1162, 511);
		rbSSH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		rbSSH.Name = "rbSSH";
		rbSSH.Size = new System.Drawing.Size(87, 20);
		rbSSH.TabIndex = 132;
		rbSSH.Text = "Đổi IP SSH";
		rbSSH.UseVisualStyleBackColor = true;
		radioButton3.AutoSize = true;
		radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
		radioButton3.Enabled = false;
		radioButton3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		radioButton3.Location = new System.Drawing.Point(1162, 451);
		radioButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		radioButton3.Name = "radioButton3";
		radioButton3.Size = new System.Drawing.Size(113, 20);
		radioButton3.TabIndex = 134;
		radioButton3.Text = "Đổi IP NordVPN";
		radioButton3.UseVisualStyleBackColor = true;
		radioButton3.CheckedChanged += new System.EventHandler(B82C2691);
		C49ACD35.AutoSize = true;
		C49ACD35.Enabled = false;
		C49ACD35.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		C49ACD35.Location = new System.Drawing.Point(1162, 426);
		C49ACD35.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		C49ACD35.Name = "rbExpressVPN";
		C49ACD35.Size = new System.Drawing.Size(130, 20);
		C49ACD35.TabIndex = 133;
		C49ACD35.Text = "Đổi IP ExpressVPN";
		C49ACD35.UseVisualStyleBackColor = true;
		BD3BF494.Fixed = true;
		BD3BF494.Horizontal = true;
		BD3BF494.TargetControl = B49F18BB;
		BD3BF494.Vertical = true;
		CDADBC94.AutomaticDelay = 0;
		CDADBC94.AutoPopDelay = 10000;
		CDADBC94.InitialDelay = 200;
		CDADBC94.ReshowDelay = 40;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1059, 460);
		base.Controls.Add(panel1);
		base.Controls.Add(bunifuCards1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhChung";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(F189AAB8);
		((System.ComponentModel.ISupportInitialize)nudInteractThread).EndInit();
		((System.ComponentModel.ISupportInitialize)nudHideThread).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		groupBox3.ResumeLayout(false);
		groupBox3.PerformLayout();
		tabChangeIP.ResumeLayout(false);
		tabNone.ResumeLayout(false);
		tabProxy.ResumeLayout(false);
		tabProxy.PerformLayout();
		plTuyChonProxy.ResumeLayout(false);
		plTuyChonProxy.PerformLayout();
		AA2E82A1.ResumeLayout(false);
		F61EF227.ResumeLayout(false);
		F61EF227.PerformLayout();
		A796A8A8.ResumeLayout(false);
		plXproxy.ResumeLayout(false);
		plXproxy.PerformLayout();
		((System.ComponentModel.ISupportInitialize)AF97B79E).EndInit();
		tabObcProxy.ResumeLayout(false);
		F99B120B.ResumeLayout(false);
		F99B120B.PerformLayout();
		((System.ComponentModel.ISupportInitialize)E534B69E).EndInit();
		B1A94238.ResumeLayout(false);
		panel5.ResumeLayout(false);
		panel5.PerformLayout();
		plTypeProxy.ResumeLayout(false);
		plTypeProxy.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudLuongPerIPMinProxy).EndInit();
		tabProxyWeb.ResumeLayout(false);
		tabProxyWeb.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudLuongPerIP).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayCheckIP).EndInit();
		C3B1BB87.ResumeLayout(false);
		C3B1BB87.PerformLayout();
		((System.ComponentModel.ISupportInitialize)EEA657B1).EndInit();
		grCauHinhChung.ResumeLayout(false);
		grCauHinhChung.PerformLayout();
		plDongBoMaxCare.ResumeLayout(false);
		plDongBoMaxCare.PerformLayout();
		grCauHinhChrome.ResumeLayout(false);
		grCauHinhChrome.PerformLayout();
		D1269480.ResumeLayout(false);
		D1269480.PerformLayout();
		plGpmLogin.ResumeLayout(false);
		plGpmLogin.PerformLayout();
		BE32A023.ResumeLayout(false);
		BE32A023.PerformLayout();
		AE0FFF89.ResumeLayout(false);
		AE0FFF89.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayOpenChromeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)DE26B731).EndInit();
		plDelayCloseChrome.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)nudDelayCloseChromeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayCloseChromeFrom).EndInit();
		plSapXepCuaSoChrome.ResumeLayout(false);
		plSapXepCuaSoChrome.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudChromeScale).EndInit();
		FAB3AA84.ResumeLayout(false);
		FAB3AA84.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudWidthChrome).EndInit();
		((System.ComponentModel.ISupportInitialize)nudHeighChrome).EndInit();
		panel3.ResumeLayout(false);
		panel3.PerformLayout();
		D238682D.ResumeLayout(false);
		D238682D.PerformLayout();
		grEmailConfigs.ResumeLayout(false);
		grEmailConfigs.PerformLayout();
		BC1D18BF.ResumeLayout(false);
		BC1D18BF.PerformLayout();
		FE01E21E.ResumeLayout(false);
		FE01E21E.PerformLayout();
		CF2A9AA2.ResumeLayout(false);
		CF2A9AA2.PerformLayout();
		FBA38325.ResumeLayout(false);
		FBA38325.PerformLayout();
		grCauHinhKhac.ResumeLayout(false);
		grCauHinhKhac.PerformLayout();
		plVitech.ResumeLayout(false);
		plVitech.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudLuongPerIPVitech).EndInit();
		A200A21D.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)B7B5A3AC).EndInit();
		panel2.ResumeLayout(false);
		panel2.PerformLayout();
		FF152B09.ResumeLayout(false);
		FF152B09.PerformLayout();
		ResumeLayout(false);
	}
}
