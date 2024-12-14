using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class C4B7D633 : Form
{
	public static bool bool_0;

	private List<string> list_0 = new List<string>();

	private List<string> E5A02209 = new List<string>();

	private List<string> list_1 = new List<string>();

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel BD8C2AA8;

	private Button btnCancel;

	private Button E8364B1A;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox ckbCaptcha;

	private TextBox B2336005;

	private CheckBox ckbImage;

	private CheckBox ckbPhone;

	private Panel FEBB10A9;

	private NumericUpDown BE121727;

	private Label label2;

	private BackgroundWorker EF9EEEB6;

	private Panel plImage;

	private RadioButton rbWeb;

	private RadioButton CC863B85;

	private Panel plCaptcha;

	private ComboBox cbbCaptcha;

	private TextBox C13DD199;

	private Panel plServiceId;

	private TextBox txtServiceId;

	private Label C52B6813;

	private ComboBox cbbTypePhone;

	private TextBox txtApiPhone;

	private CheckBox ckbLanguage;

	private LinkLabel linkLabel1;

	private Label label3;

	private GroupBox A080B5BC;

	private RadioButton rbPassTuDat;

	private RadioButton D7A40399;

	private TextBox A12DB691;

	private GroupBox grCheckpoint282;

	private Button AE16A211;

	private NumericUpDown nudLimitCountGetPhone;

	private Label FBA647A4;

	private Label label5;

	private NumericUpDown nudLimitTimeGetPhone;

	private CheckBox ckbAddMail;

	private Panel plMail;

	private Button E0B309A5;

	private ComboBox cbbTypeMail;

	private Label label7;

	private CheckBox B8102C1A;

	private CheckBox C9B897AF;

	private ComboBox cbbLanguageSauKhiUnlock;

	private CheckBox BCA97838;

	private Button button3;

	private LinkLabel linkLabel2;

	private CheckBox B51ED7AA;

	private TextBox txtLanguage;

	private ComboBox cbbImageUrl;

	private Button button4;

	private Panel plNhapSdt;

	private RichTextBox txtSdt;

	private Label AC393BB5;

	private CheckBox ckbSwitch282To956;

	private CheckBox ckbDeleteContact;

	private CheckBox ckbSkipRecaptcha;

	private Panel ABB8DF23;

	private Button button11;

	private TextBox txtFolderLink956;

	private NumericUpDown nudCountLink956;

	private Label CC9A6B23;

	private Label E7AB291E;

	private CheckBox ckbXuatLink956;

	private TextBox AC000EAE;

	private Label label6;

	private Button button5;

	public C4B7D633(string string_0 = "")
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		bool_0 = false;
		grCheckpoint282.Enabled = string_0.Contains("282");
		ckbDeleteContact.Visible = string_0.Contains("956");
	}

	private void C4B7D633_Load(object sender, EventArgs e)
	{
		method_0();
		EF211AA0();
		try
		{
			if (GClass25.smethod_0("configCheckpoint").method_2("typePass", 1) == 0)
			{
				rbPassTuDat.Checked = true;
			}
			else
			{
				D7A40399.Checked = true;
			}
			A12DB691.Text = GClass25.smethod_0("configCheckpoint").C0288288("txtPass");
			ckbCaptcha.Checked = GClass25.smethod_0("configCheckpoint").method_3("ckbCaptcha");
			ckbSkipRecaptcha.Checked = GClass25.smethod_0("configCheckpoint").method_3("ckbSkipRecaptcha");
			int num = GClass25.smethod_0("configCheckpoint").method_2("typeCaptcha", 8);
			if (num == 4)
			{
				num = 8;
			}
			try
			{
				cbbCaptcha.SelectedValue = num.ToString();
			}
			catch
			{
			}
			AC000EAE.Text = GClass25.smethod_0("configCheckpoint").C0288288("txtCaptcha_4");
			C13DD199.Text = GClass25.smethod_0("configCheckpoint").C0288288("txtCaptcha_" + num);
			if (C13DD199.Text == "")
			{
				switch (num)
				{
				case 2:
					C13DD199.Text = GClass25.smethod_0("configCheckpoint").C0288288("txtAnyCaptcha");
					break;
				case 0:
					C13DD199.Text = GClass25.smethod_0("configCheckpoint").C0288288("txt2Captcha");
					break;
				}
			}
			ckbSwitch282To956.Checked = GClass25.smethod_0("configCheckpoint").method_3("ckbSwitch282To956");
			ckbPhone.Checked = GClass25.smethod_0("configCheckpoint").method_3("ckbPhone");
			int num2 = GClass25.smethod_0("configCheckpoint").method_2("typeSim");
			try
			{
				cbbTypePhone.SelectedValue = num2.ToString();
			}
			catch
			{
			}
			txtApiPhone.Text = GClass25.smethod_0("configCheckpoint").C0288288("txtApiPhone_" + num2);
			if (txtApiPhone.Text == "")
			{
				switch (num2)
				{
				case 0:
					txtApiPhone.Text = GClass25.smethod_0("configCheckpoint").C0288288("txtAhaSim");
					break;
				case 2:
					txtApiPhone.Text = GClass25.smethod_0("configCheckpoint").C0288288("txtSimCode");
					break;
				case 4:
					txtApiPhone.Text = GClass25.smethod_0("configCheckpoint").C0288288("txtPrimeOtp");
					break;
				case 6:
					txtApiPhone.Text = GClass25.smethod_0("configCheckpoint").C0288288("txtOtpfb");
					break;
				case 8:
					txtApiPhone.Text = GClass25.smethod_0("configCheckpoint").C0288288("txtViotp");
					break;
				case 9:
					txtApiPhone.Text = GClass25.smethod_0("configCheckpoint").C0288288("txtOtpTextnow");
					break;
				case 10:
					txtApiPhone.Text = GClass25.smethod_0("configCheckpoint").C0288288("txtTempCode");
					break;
				}
			}
			txtServiceId.Text = GClass25.smethod_0("configCheckpoint").C0288288("txtServiceId", "fb_tn");
			BE121727.Value = GClass25.smethod_0("configCheckpoint").method_2("nudTime", 120);
			nudLimitCountGetPhone.Value = GClass25.smethod_0("configCheckpoint").method_2("nudLimitCountGetPhone", 3);
			nudLimitTimeGetPhone.Value = GClass25.smethod_0("configCheckpoint").method_2("nudLimitTimeGetPhone", 100);
			ckbLanguage.Checked = GClass25.smethod_0("configCheckpoint").method_3("ckbLanguage");
			txtLanguage.Text = GClass25.smethod_0("configCheckpoint").C0288288("txtLanguage", "en_US,th_TH,my_MM");
			BCA97838.Checked = GClass25.smethod_0("configCheckpoint").method_3("ckbDoiNgonNguSauKhiUnlock");
			cbbLanguageSauKhiUnlock.Text = GClass25.smethod_0("configCheckpoint").C0288288("cbbLanguageSauKhiUnlock", "en_US");
			txtSdt.Text = GClass25.smethod_0("configCheckpoint").C0288288("txtSdt");
			ckbAddMail.Checked = GClass25.smethod_0("configCheckpoint").method_3("ckbAddMail");
			cbbTypeMail.SelectedIndex = GClass25.smethod_0("configCheckpoint").method_2("cbbTypeMail");
			list_0 = GClass25.smethod_0("configCheckpoint").C5A69DA0("lstHotmail");
			E5A02209 = GClass25.smethod_0("configCheckpoint").C5A69DA0("lstMailDomain");
			list_1 = GClass25.smethod_0("configCheckpoint").C5A69DA0("lstDomain");
			ckbImage.Checked = GClass25.smethod_0("configCheckpoint").method_3("ckbImage");
			B8102C1A.Checked = GClass25.smethod_0("configCheckpoint").method_3("ckbBackupAnh");
			C9B897AF.Checked = GClass25.smethod_0("configCheckpoint").method_3("ckbChangeMD5");
			if (GClass25.smethod_0("configCheckpoint").method_2("typeImage") == 0)
			{
				CC863B85.Checked = true;
			}
			else
			{
				rbWeb.Checked = true;
			}
			B2336005.Text = GClass25.smethod_0("configCheckpoint").C0288288("txtImage");
			cbbImageUrl.Text = GClass25.smethod_0("configCheckpoint").C0288288("txtImageUrl", "https://thispersondoesnotexist.com/");
			ckbDeleteContact.Checked = GClass25.smethod_0("configCheckpoint").method_3("ckbDeleteContact");
			ckbXuatLink956.Checked = GClass25.smethod_0("configCheckpoint").method_3("ckbXuatLink956");
			nudCountLink956.Value = GClass25.smethod_0("configCheckpoint").method_2("nudCountLink956", 1);
			txtFolderLink956.Text = GClass25.smethod_0("configCheckpoint").C0288288("txtFolderLink956");
		}
		catch
		{
		}
		method_1();
	}

	private void method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "https://2captcha.com/");
		dictionary.Add("8", "https://capsolver.com/");
		cbbCaptcha.DataSource = new BindingSource(dictionary, null);
		cbbCaptcha.DisplayMember = "Value";
		cbbCaptcha.ValueMember = "Key";
	}

	private void EF211AA0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("36", "https://usotp.xyz/");
		dictionary.Add("62", "https://sms.dichvummo.org/");
		dictionary.Add("59", "https://muasms.com/");
		dictionary.Add("56", "https://random-otp.io.vn/");
		if (Class57.bool_0)
		{
			dictionary.Add("50", "http://mthgroup.vn");
		}
		dictionary.Add("12", "https://winmail.shop/");
		dictionary.Add("45", "https://winmail.shop/ RU");
		dictionary.Add("30", "https://ironsim.com/ VN");
		dictionary.Add("41", "https://ironsim.com/ US");
		dictionary.Add("54", "https://ironsim.com/ Canada");
		dictionary.Add("17", "https://2ndline.pro/");
		dictionary.Add("19", "http://hcotp.com/");
		dictionary.Add("13", "https://sim24.cc/ -> https://funotp.com/");
		dictionary.Add("52", "https://sim24.cc/ US -> https://funotp.com/ US");
		dictionary.Add("14", "https://codetext247.com/");
		dictionary.Add("2", "http://chothuesimcode.com/ -> https://chaycodeso3.com/");
		dictionary.Add("8", "https://viotp.com/");
		dictionary.Add("48", "https://otptextnow.com/ 500đ");
		dictionary.Add("9", "https://otptextnow.com/");
		dictionary.Add("32", "https://thuesim.app/");
		dictionary.Add("23", "https://codeotp.site/");
		dictionary.Add("16", "https://otp282.com/");
		dictionary.Add("53", "https://fastsim.online/");
		cbbTypePhone.DataSource = new BindingSource(dictionary, null);
		cbbTypePhone.DisplayMember = "Value";
		cbbTypePhone.ValueMember = "Key";
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E8364B1A_Click(object sender, EventArgs e)
	{
		try
		{
			int num = 0;
			if (D7A40399.Checked)
			{
				num = 1;
			}
			GClass25.smethod_0("configCheckpoint").method_4("typePass", num);
			GClass25.smethod_0("configCheckpoint").method_4("txtPass", A12DB691.Text);
			GClass25.smethod_0("configCheckpoint").method_4("ckbCaptcha", ckbCaptcha.Checked);
			GClass25.smethod_0("configCheckpoint").method_4("ckbSkipRecaptcha", ckbSkipRecaptcha.Checked);
			int num2 = 0;
			try
			{
				num2 = Convert.ToInt32(cbbCaptcha.SelectedValue);
			}
			catch (Exception)
			{
			}
			GClass25.smethod_0("configCheckpoint").method_4("typeCaptcha", num2);
			GClass25.smethod_0("configCheckpoint").method_4("txtCaptcha_4", AC000EAE.Text);
			GClass25.smethod_0("configCheckpoint").method_4("txtCaptcha_" + num2, C13DD199.Text);
			GClass25.smethod_0("configCheckpoint").method_4("ckbSwitch282To956", ckbSwitch282To956.Checked);
			GClass25.smethod_0("configCheckpoint").method_4("ckbPhone", ckbPhone.Checked);
			int num3 = 0;
			try
			{
				num3 = Convert.ToInt32(cbbTypePhone.SelectedValue);
			}
			catch
			{
			}
			GClass25.smethod_0("configCheckpoint").method_4("typeSim", num3);
			GClass25.smethod_0("configCheckpoint").method_4("txtApiPhone_" + num3, txtApiPhone.Text);
			GClass25.smethod_0("configCheckpoint").method_4("txtServiceId", txtServiceId.Text);
			GClass25.smethod_0("configCheckpoint").method_4("nudTime", BE121727.Value);
			GClass25.smethod_0("configCheckpoint").method_4("nudLimitCountGetPhone", nudLimitCountGetPhone.Value);
			GClass25.smethod_0("configCheckpoint").method_4("nudLimitTimeGetPhone", nudLimitTimeGetPhone.Value);
			GClass25.smethod_0("configCheckpoint").method_4("ckbLanguage", ckbLanguage.Checked);
			GClass25.smethod_0("configCheckpoint").method_4("txtLanguage", txtLanguage.Text);
			GClass25.smethod_0("configCheckpoint").method_4("ckbDoiNgonNguSauKhiUnlock", BCA97838.Checked);
			GClass25.smethod_0("configCheckpoint").method_4("cbbLanguageSauKhiUnlock", cbbLanguageSauKhiUnlock.Text.Split('|')[0]);
			GClass25.smethod_0("configCheckpoint").method_4("txtSdt", txtSdt.Text);
			GClass25.smethod_0("configCheckpoint").method_4("ckbAddMail", ckbAddMail.Checked);
			GClass25.smethod_0("configCheckpoint").method_4("cbbTypeMail", cbbTypeMail.SelectedIndex);
			GClass25.smethod_0("configCheckpoint").method_5("lstHotmail", list_0);
			GClass25.smethod_0("configCheckpoint").method_5("lstMailDomain", E5A02209);
			GClass25.smethod_0("configCheckpoint").method_5("lstDomain", list_1);
			GClass25.smethod_0("configCheckpoint").method_4("ckbImage", ckbImage.Checked);
			GClass25.smethod_0("configCheckpoint").method_4("ckbBackupAnh", B8102C1A.Checked);
			GClass25.smethod_0("configCheckpoint").method_4("ckbChangeMD5", C9B897AF.Checked);
			int num4 = 0;
			if (rbWeb.Checked)
			{
				num4 = 1;
			}
			GClass25.smethod_0("configCheckpoint").method_4("typeImage", num4);
			GClass25.smethod_0("configCheckpoint").method_4("txtImage", B2336005.Text);
			GClass25.smethod_0("configCheckpoint").method_4("txtImageUrl", cbbImageUrl.Text);
			GClass25.smethod_0("configCheckpoint").method_4("ckbXuatLink956", ckbXuatLink956.Checked);
			GClass25.smethod_0("configCheckpoint").method_4("nudCountLink956", nudCountLink956.Value);
			GClass25.smethod_0("configCheckpoint").method_4("txtFolderLink956", txtFolderLink956.Text);
			GClass25.B3B73732("configCheckpoint");
			bool_0 = true;
			GClass25.smethod_0("configCheckpoint").method_4("ckbDeleteContact", ckbDeleteContact.Checked);
			Close();
		}
		catch
		{
			GClass29.smethod_0("Vui lòng thử lại sau!", 2);
		}
	}

	private void method_1()
	{
		ckbCaptcha_CheckedChanged(null, null);
		ckbPhone_CheckedChanged(null, null);
		ckbImage_CheckedChanged(null, null);
		CC863B85_CheckedChanged(null, null);
		A4B36B35(null, null);
		B8102C1A_CheckedChanged(null, null);
		CFA53F2C(null, null);
		method_2();
		F1A249AE(null, null);
		cbbTypePhone_SelectedIndexChanged(null, null);
		txtSdt_TextChanged(null, null);
		D416F3BB(null, null);
	}

	private void method_2()
	{
		switch (cbbTypeMail.SelectedIndex)
		{
		case 0:
			GClass8.smethod_61(E0B309A5, list_0.Count);
			break;
		case 1:
			GClass8.smethod_61(E0B309A5, E5A02209.Count);
			break;
		case 2:
			GClass8.smethod_61(E0B309A5, list_1.Count);
			break;
		}
	}

	private void B8923884(object sender, EventArgs e)
	{
		Close();
	}

	private void BD8C2AA8_Paint(object sender, PaintEventArgs e)
	{
		if (BD8C2AA8.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, BD8C2AA8.ClientSize.Width - num, BD8C2AA8.ClientSize.Height - num));
		}
	}

	private void ckbCaptcha_CheckedChanged(object sender, EventArgs e)
	{
		plCaptcha.Enabled = ckbCaptcha.Checked;
	}

	private void ckbPhone_CheckedChanged(object sender, EventArgs e)
	{
		FEBB10A9.Enabled = ckbPhone.Checked;
	}

	private void ckbImage_CheckedChanged(object sender, EventArgs e)
	{
		plImage.Enabled = ckbImage.Checked;
	}

	private void CC863B85_CheckedChanged(object sender, EventArgs e)
	{
		B2336005.Enabled = CC863B85.Checked;
	}

	private void E10F0C8C(object sender, EventArgs e)
	{
		try
		{
			C13DD199.Text = GClass25.smethod_0("configCheckpoint").C0288288("txtCaptcha_" + cbbCaptcha.SelectedValue.ToString());
		}
		catch
		{
		}
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = "https://minsoftware.vn/tong-hop-ma-danh-sach-ngon-ngu-giai-checkpoint282-facebook/#4_Doi_ngon_ngu_khi_giai";
		try
		{
			Process.Start("chrome.exe", text);
		}
		catch
		{
			Process.Start(text);
		}
	}

	private void B8102C1A_CheckedChanged(object sender, EventArgs e)
	{
		txtLanguage.Enabled = ckbLanguage.Checked;
	}

	private void cbbTypePhone_SelectedIndexChanged(object sender, EventArgs e)
	{
		string text = "0";
		try
		{
			text = cbbTypePhone.SelectedValue.ToString();
		}
		catch (Exception)
		{
		}
		txtApiPhone.Text = GClass25.smethod_0("configCheckpoint").C0288288("txtApiPhone_" + text);
		plServiceId.Visible = text == "10";
		plNhapSdt.Visible = text == "37" || text == "50";
	}

	private void C8815005(object sender, EventArgs e)
	{
		A12DB691.Enabled = rbPassTuDat.Checked;
	}

	private void AE16A211_Click(object sender, EventArgs e)
	{
		string eD = "Có thể sử dụng ký tự * để random 1 ký tự ngẫu nhiên!\r\nVí dụ: MIN****** => MINdfghta";
		GClass29.smethod_0(eD);
	}

	private void CFA53F2C(object sender, EventArgs e)
	{
		plMail.Enabled = ckbAddMail.Checked;
	}

	private void E0B309A5_Click(object sender, EventArgs e)
	{
		switch (cbbTypeMail.SelectedIndex)
		{
		case 0:
		{
			fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_0, "Nhâ\u0323p danh sa\u0301ch hotmail (mail|pass mail)", "Danh sa\u0301ch mail|pass mail", "(Mô\u0303i nội dung 1 do\u0300ng)");
			GClass8.smethod_33(fNhapDuLieu4);
			list_0 = fNhapDuLieu4.C6009CA1;
			GClass8.smethod_61(E0B309A5, list_0.Count);
			break;
		}
		case 1:
		{
			fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(E5A02209, "Nhâ\u0323p danh sa\u0301ch link mail domain", "Danh sa\u0301ch link mail domain", "(Mô\u0303i nội dung 1 do\u0300ng)");
			GClass8.smethod_33(fNhapDuLieu4);
			E5A02209 = fNhapDuLieu4.C6009CA1;
			GClass8.smethod_61(E0B309A5, E5A02209.Count);
			break;
		}
		case 2:
		{
			fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_1, "Nhâ\u0323p danh sa\u0301ch domain", "Danh sa\u0301ch domain", "(Mô\u0303i nội dung 1 do\u0300ng)");
			GClass8.smethod_33(fNhapDuLieu4);
			list_1 = fNhapDuLieu4.C6009CA1;
			GClass8.smethod_61(E0B309A5, list_1.Count);
			break;
		}
		}
	}

	private void A4B36B35(object sender, EventArgs e)
	{
		cbbImageUrl.Enabled = rbWeb.Checked;
	}

	private void cbbTypeMail_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_2();
	}

	private void F1A249AE(object sender, EventArgs e)
	{
		cbbLanguageSauKhiUnlock.Enabled = BCA97838.Checked;
	}

	private void button3_Click(object sender, EventArgs e)
	{
		int num = GClass25.smethod_0("configCheckpoint").method_2("typeSim");
		string eD = DABBB41F.CC8A2029(GClass25.smethod_0("configCheckpoint").method_2("typeSim"), GClass25.smethod_0("configCheckpoint").C0288288("txtApiPhone_" + num), GClass25.smethod_0("configCheckpoint").method_2("nudLimitTimeGetPhone"), GClass25.smethod_0("configCheckpoint").C0288288("txtServiceId"), GClass25.smethod_0("configCheckpoint").C0288288("txtCustom").Split('*')[0]);
		GClass29.smethod_0(eD);
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.FB0F49A9("https://s3-hcm5-r1.longvan.net/19425302-download.minsoftware.vn/download/MaxDownloadImage.zip");
	}

	private void button4_Click(object sender, EventArgs e)
	{
		string text = "";
		text = ((!(cbbCaptcha.Text == "https://capsolver.com/")) ? GClass8.smethod_0(cbbCaptcha.Text.ToString(), C13DD199.Text.Trim()) : GClass8.smethod_0("https://www.capsolver.com", C13DD199.Text.Trim()));
		GClass29.smethod_0(text);
	}

	private void txtSdt_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtSdt, AC393BB5);
	}

	private void D7A91D34(object sender, EventArgs e)
	{
		string text = GClass8.smethod_40(txtFolderLink956.Text);
		if (text != "")
		{
			txtFolderLink956.Text = text;
		}
	}

	private void D416F3BB(object sender, EventArgs e)
	{
		ABB8DF23.Enabled = ckbXuatLink956.Checked;
	}

	private void button5_Click(object sender, EventArgs e)
	{
		string eD = GClass8.smethod_0("https://omocaptcha.com/", AC000EAE.Text.Trim());
		GClass29.smethod_0(eD);
	}

	protected override void Dispose(bool D40CF406)
	{
		if (D40CF406 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(D40CF406);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		BD8C2AA8 = new System.Windows.Forms.Panel();
		ABB8DF23 = new System.Windows.Forms.Panel();
		button11 = new System.Windows.Forms.Button();
		txtFolderLink956 = new System.Windows.Forms.TextBox();
		nudCountLink956 = new System.Windows.Forms.NumericUpDown();
		CC9A6B23 = new System.Windows.Forms.Label();
		E7AB291E = new System.Windows.Forms.Label();
		ckbXuatLink956 = new System.Windows.Forms.CheckBox();
		plNhapSdt = new System.Windows.Forms.Panel();
		txtSdt = new System.Windows.Forms.RichTextBox();
		AC393BB5 = new System.Windows.Forms.Label();
		A080B5BC = new System.Windows.Forms.GroupBox();
		AE16A211 = new System.Windows.Forms.Button();
		rbPassTuDat = new System.Windows.Forms.RadioButton();
		D7A40399 = new System.Windows.Forms.RadioButton();
		A12DB691 = new System.Windows.Forms.TextBox();
		grCheckpoint282 = new System.Windows.Forms.GroupBox();
		linkLabel2 = new System.Windows.Forms.LinkLabel();
		cbbLanguageSauKhiUnlock = new System.Windows.Forms.ComboBox();
		FEBB10A9 = new System.Windows.Forms.Panel();
		txtLanguage = new System.Windows.Forms.TextBox();
		txtApiPhone = new System.Windows.Forms.TextBox();
		button3 = new System.Windows.Forms.Button();
		linkLabel1 = new System.Windows.Forms.LinkLabel();
		plServiceId = new System.Windows.Forms.Panel();
		txtServiceId = new System.Windows.Forms.TextBox();
		C52B6813 = new System.Windows.Forms.Label();
		nudLimitTimeGetPhone = new System.Windows.Forms.NumericUpDown();
		nudLimitCountGetPhone = new System.Windows.Forms.NumericUpDown();
		BE121727 = new System.Windows.Forms.NumericUpDown();
		label5 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		FBA647A4 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		ckbLanguage = new System.Windows.Forms.CheckBox();
		cbbTypePhone = new System.Windows.Forms.ComboBox();
		ckbSwitch282To956 = new System.Windows.Forms.CheckBox();
		ckbPhone = new System.Windows.Forms.CheckBox();
		ckbAddMail = new System.Windows.Forms.CheckBox();
		ckbImage = new System.Windows.Forms.CheckBox();
		plMail = new System.Windows.Forms.Panel();
		E0B309A5 = new System.Windows.Forms.Button();
		cbbTypeMail = new System.Windows.Forms.ComboBox();
		label7 = new System.Windows.Forms.Label();
		plImage = new System.Windows.Forms.Panel();
		cbbImageUrl = new System.Windows.Forms.ComboBox();
		rbWeb = new System.Windows.Forms.RadioButton();
		CC863B85 = new System.Windows.Forms.RadioButton();
		B2336005 = new System.Windows.Forms.TextBox();
		C9B897AF = new System.Windows.Forms.CheckBox();
		B8102C1A = new System.Windows.Forms.CheckBox();
		BCA97838 = new System.Windows.Forms.CheckBox();
		plCaptcha = new System.Windows.Forms.Panel();
		cbbCaptcha = new System.Windows.Forms.ComboBox();
		AC000EAE = new System.Windows.Forms.TextBox();
		C13DD199 = new System.Windows.Forms.TextBox();
		ckbSkipRecaptcha = new System.Windows.Forms.CheckBox();
		label6 = new System.Windows.Forms.Label();
		button5 = new System.Windows.Forms.Button();
		button4 = new System.Windows.Forms.Button();
		ckbDeleteContact = new System.Windows.Forms.CheckBox();
		ckbCaptcha = new System.Windows.Forms.CheckBox();
		btnCancel = new System.Windows.Forms.Button();
		E8364B1A = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		B51ED7AA = new System.Windows.Forms.CheckBox();
		EF9EEEB6 = new System.ComponentModel.BackgroundWorker();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		BD8C2AA8.SuspendLayout();
		ABB8DF23.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountLink956).BeginInit();
		plNhapSdt.SuspendLayout();
		A080B5BC.SuspendLayout();
		grCheckpoint282.SuspendLayout();
		FEBB10A9.SuspendLayout();
		plServiceId.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudLimitTimeGetPhone).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudLimitCountGetPhone).BeginInit();
		((System.ComponentModel.ISupportInitialize)BE121727).BeginInit();
		plMail.SuspendLayout();
		plImage.SuspendLayout();
		plCaptcha.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(873, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Giải Checkpoint";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(873, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = C50FB39E.Bitmap_13;
		button1.Location = new System.Drawing.Point(842, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		BD8C2AA8.BackColor = System.Drawing.Color.White;
		BD8C2AA8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		BD8C2AA8.Controls.Add(ABB8DF23);
		BD8C2AA8.Controls.Add(ckbXuatLink956);
		BD8C2AA8.Controls.Add(plNhapSdt);
		BD8C2AA8.Controls.Add(A080B5BC);
		BD8C2AA8.Controls.Add(grCheckpoint282);
		BD8C2AA8.Controls.Add(plCaptcha);
		BD8C2AA8.Controls.Add(ckbDeleteContact);
		BD8C2AA8.Controls.Add(ckbCaptcha);
		BD8C2AA8.Controls.Add(btnCancel);
		BD8C2AA8.Controls.Add(E8364B1A);
		BD8C2AA8.Controls.Add(bunifuCards1);
		BD8C2AA8.Controls.Add(B51ED7AA);
		BD8C2AA8.Cursor = System.Windows.Forms.Cursors.Arrow;
		BD8C2AA8.Dock = System.Windows.Forms.DockStyle.Fill;
		BD8C2AA8.Location = new System.Drawing.Point(0, 0);
		BD8C2AA8.Name = "panel1";
		BD8C2AA8.Size = new System.Drawing.Size(876, 515);
		BD8C2AA8.TabIndex = 0;
		BD8C2AA8.Paint += new System.Windows.Forms.PaintEventHandler(BD8C2AA8_Paint);
		ABB8DF23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		ABB8DF23.Controls.Add(button11);
		ABB8DF23.Controls.Add(txtFolderLink956);
		ABB8DF23.Controls.Add(nudCountLink956);
		ABB8DF23.Controls.Add(CC9A6B23);
		ABB8DF23.Controls.Add(E7AB291E);
		ABB8DF23.Location = new System.Drawing.Point(45, 281);
		ABB8DF23.Name = "plXuatLink956";
		ABB8DF23.Size = new System.Drawing.Size(367, 61);
		ABB8DF23.TabIndex = 202;
		ABB8DF23.Visible = false;
		button11.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button11.Cursor = System.Windows.Forms.Cursors.Hand;
		button11.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		button11.ForeColor = System.Drawing.Color.Black;
		button11.Location = new System.Drawing.Point(303, 31);
		button11.Name = "button11";
		button11.Size = new System.Drawing.Size(59, 25);
		button11.TabIndex = 150;
		button11.Text = "...";
		button11.UseVisualStyleBackColor = true;
		button11.Click += new System.EventHandler(D7A91D34);
		txtFolderLink956.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtFolderLink956.Location = new System.Drawing.Point(95, 32);
		txtFolderLink956.Name = "txtFolderLink956";
		txtFolderLink956.Size = new System.Drawing.Size(202, 23);
		txtFolderLink956.TabIndex = 151;
		nudCountLink956.Location = new System.Drawing.Point(95, 4);
		nudCountLink956.Name = "nudCountLink956";
		nudCountLink956.Size = new System.Drawing.Size(78, 23);
		nudCountLink956.TabIndex = 1;
		CC9A6B23.AutoSize = true;
		CC9A6B23.Location = new System.Drawing.Point(3, 34);
		CC9A6B23.Name = "label9";
		CC9A6B23.Size = new System.Drawing.Size(70, 16);
		CC9A6B23.TabIndex = 0;
		CC9A6B23.Text = "Folder lưu:";
		E7AB291E.AutoSize = true;
		E7AB291E.Location = new System.Drawing.Point(3, 5);
		E7AB291E.Name = "label8";
		E7AB291E.Size = new System.Drawing.Size(86, 16);
		E7AB291E.TabIndex = 0;
		E7AB291E.Text = "Sô\u0301 lươ\u0323ng link:";
		ckbXuatLink956.AutoSize = true;
		ckbXuatLink956.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbXuatLink956.Location = new System.Drawing.Point(24, 259);
		ckbXuatLink956.Name = "ckbXuatLink956";
		ckbXuatLink956.Size = new System.Drawing.Size(164, 20);
		ckbXuatLink956.TabIndex = 201;
		ckbXuatLink956.Text = "Xuâ\u0301t link checkpoint 956";
		ckbXuatLink956.UseVisualStyleBackColor = true;
		ckbXuatLink956.Visible = false;
		ckbXuatLink956.CheckedChanged += new System.EventHandler(D416F3BB);
		plNhapSdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plNhapSdt.Controls.Add(txtSdt);
		plNhapSdt.Controls.Add(AC393BB5);
		plNhapSdt.Location = new System.Drawing.Point(24, 520);
		plNhapSdt.Name = "plNhapSdt";
		plNhapSdt.Size = new System.Drawing.Size(388, 103);
		plNhapSdt.TabIndex = 200;
		plNhapSdt.Visible = false;
		txtSdt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtSdt.Location = new System.Drawing.Point(7, 24);
		txtSdt.Name = "txtSdt";
		txtSdt.Size = new System.Drawing.Size(374, 74);
		txtSdt.TabIndex = 3;
		txtSdt.Text = "";
		txtSdt.WordWrap = false;
		txtSdt.TextChanged += new System.EventHandler(txtSdt_TextChanged);
		AC393BB5.AutoSize = true;
		AC393BB5.Location = new System.Drawing.Point(3, 4);
		AC393BB5.Name = "lblSdt";
		AC393BB5.Size = new System.Drawing.Size(113, 16);
		AC393BB5.TabIndex = 2;
		AC393BB5.Text = "Danh sách sđt (0):";
		A080B5BC.Controls.Add(AE16A211);
		A080B5BC.Controls.Add(rbPassTuDat);
		A080B5BC.Controls.Add(D7A40399);
		A080B5BC.Controls.Add(A12DB691);
		A080B5BC.Location = new System.Drawing.Point(24, 58);
		A080B5BC.Name = "groupBox2";
		A080B5BC.Size = new System.Drawing.Size(388, 73);
		A080B5BC.TabIndex = 198;
		A080B5BC.TabStop = false;
		A080B5BC.Text = "Mật khẩu mới";
		AE16A211.Cursor = System.Windows.Forms.Cursors.Hand;
		AE16A211.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		AE16A211.Location = new System.Drawing.Point(358, 21);
		AE16A211.Name = "button2";
		AE16A211.Size = new System.Drawing.Size(24, 24);
		AE16A211.TabIndex = 197;
		AE16A211.Text = "?";
		AE16A211.UseVisualStyleBackColor = true;
		AE16A211.Click += new System.EventHandler(AE16A211_Click);
		rbPassTuDat.AutoSize = true;
		rbPassTuDat.Checked = true;
		rbPassTuDat.Cursor = System.Windows.Forms.Cursors.Hand;
		rbPassTuDat.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		rbPassTuDat.Location = new System.Drawing.Point(19, 22);
		rbPassTuDat.Name = "rbPassTuDat";
		rbPassTuDat.Size = new System.Drawing.Size(115, 20);
		rbPassTuDat.TabIndex = 195;
		rbPassTuDat.TabStop = true;
		rbPassTuDat.Text = "Mật khẩu tự đặt";
		rbPassTuDat.UseVisualStyleBackColor = true;
		rbPassTuDat.CheckedChanged += new System.EventHandler(C8815005);
		D7A40399.AutoSize = true;
		D7A40399.Cursor = System.Windows.Forms.Cursors.Hand;
		D7A40399.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D7A40399.Location = new System.Drawing.Point(19, 47);
		D7A40399.Name = "rbPassNgauNhien";
		D7A40399.Size = new System.Drawing.Size(125, 20);
		D7A40399.TabIndex = 194;
		D7A40399.Text = "Mật khẩu random";
		D7A40399.UseVisualStyleBackColor = true;
		A12DB691.Location = new System.Drawing.Point(142, 21);
		A12DB691.Name = "txtPass";
		A12DB691.Size = new System.Drawing.Size(210, 23);
		A12DB691.TabIndex = 196;
		grCheckpoint282.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		grCheckpoint282.Controls.Add(linkLabel2);
		grCheckpoint282.Controls.Add(cbbLanguageSauKhiUnlock);
		grCheckpoint282.Controls.Add(FEBB10A9);
		grCheckpoint282.Controls.Add(ckbSwitch282To956);
		grCheckpoint282.Controls.Add(ckbPhone);
		grCheckpoint282.Controls.Add(ckbAddMail);
		grCheckpoint282.Controls.Add(ckbImage);
		grCheckpoint282.Controls.Add(plMail);
		grCheckpoint282.Controls.Add(plImage);
		grCheckpoint282.Controls.Add(BCA97838);
		grCheckpoint282.Location = new System.Drawing.Point(435, 58);
		grCheckpoint282.Name = "grCheckpoint282";
		grCheckpoint282.Size = new System.Drawing.Size(415, 401);
		grCheckpoint282.TabIndex = 197;
		grCheckpoint282.TabStop = false;
		grCheckpoint282.Text = "Checkpoint 282";
		linkLabel2.Location = new System.Drawing.Point(238, 261);
		linkLabel2.Name = "linkLabel2";
		linkLabel2.Size = new System.Drawing.Size(170, 18);
		linkLabel2.TabIndex = 197;
		linkLabel2.TabStop = true;
		linkLabel2.Text = "Phần mềm tải ảnh miễn phí!";
		linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel2_LinkClicked);
		cbbLanguageSauKhiUnlock.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		cbbLanguageSauKhiUnlock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		cbbLanguageSauKhiUnlock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		cbbLanguageSauKhiUnlock.DropDownWidth = 150;
		cbbLanguageSauKhiUnlock.FormattingEnabled = true;
		cbbLanguageSauKhiUnlock.Items.AddRange(new object[112]
		{
			"so_SO|Tiếng Somali", "af_ZA|Tiếng Afrikaans", "az_AZ|Tiếng Azerbaijan", "id_ID|Tiếng Indo", "ms_MY|Tiếng Mã Lai", "jv_ID|Tiếng Java", "cx_PH|Tiếng Cebuano", "bs_BA|Tiếng Bosnia", "br_FR|Tiếng Breton", "ca_ES|Tiếng Ca-ta-lăng",
			"co_FR|Tiếng Corse", "cy_GB|Tiếng Wales", "da_DK|Tiếng Đan Mạch", "de_DE|Tiếng Đức", "et_EE|Tiếng Estonia", "en_GB|Tiếng Anh (Anh)", "en_US|Tiếng Anh (Mỹ)", "es_LA|Tiếng Tây Ban Nha", "es_ES|Tiếng Tây Ban Nha (Tây Ban Nha)", "eo_EO|Tiếng Esperanto",
			"eu_ES|Tiếng Basque", "tl_PH|Tiếng Philippines", "fr_CA|Tiếng Pháp (Canada)", "fr_FR|Tiếng Pháp (Pháp)", "fy_NL|Tiếng Frisia", "ff_NG|Tiếng Fula", "fo_FO|Tiếng Faroe", "ga_IE|Tiếng Ai-len", "gl_ES|Tiếng Galic", "gn_PY|Tiếng Guarani",
			"ha_NG|Tiếng Hausa", "hr_HR|Tiếng Croatia", "rw_RW|Tiếng Kinyarwanda", "iu_CA|Tiếng Inuktitut", "it_IT|Tiếng Ý", "ik_US|Tiếng Inupiaq", "sw_KE|Tiếng Swahili", "ht_HT|Tiếng Haitian Creole", "ku_TR|Tiếng Kurdish (Kurmanji)", "lv_LV|Tiếng Latvia",
			"lt_LT|Tiếng Lithuania", "hu_HU|Tiếng Hungary", "mg_MG|Tiếng Malagasy", "mt_MT|Tiếng Malta", "nl_NL|Tiếng Hà Lan", "nb_NO|Tiếng Na Uy (bokmal)", "nn_NO|Tiếng Na-uy (nynorsk)", "uz_UZ|Tiếng Uzbek", "pl_PL|Tiếng Ba Lan", "pt_BR|Tiếng Bồ Đào Nha (Brazil)",
			"pt_PT|Tiếng Bồ Đào Nha (Bồ Đào Nha)", "ro_RO|Tiếng Rumani", "sc_IT|Tiếng Sardinia", "sn_ZW|Tiếng Shona", "sq_AL|Tiếng Albani", "sk_SK|Tiếng Slovakia", "sl_SI|Tiếng Sloven", "fi_FI|Tiếng Phần Lan", "sv_SE|Tiếng Thụy Điển", "vi_VN|Tiếng Việt",
			"tr_TR|Tiếng Thổ Nhĩ Kỳ", "nl_BE|Tiếng Hà Lan-Bỉ", "zz_TR|Tiếng Zaza", "is_IS|Tiếng Iceland", "cs_CZ|Tiếng Séc", "sz_PL|Tiếng Silesia", "el_GR|Tiếng Hy Lạp", "be_BY|Tiếng Belarus", "bg_BG|Tiếng Bungari", "mk_MK|Tiếng Macedoni",
			"mn_MN|Tiếng Mông Cổ", "ru_RU|Tiếng Nga", "sr_RS|Tiếng Serbia", "tt_RU|Tiê\u0301ng Tatar", "tg_TJ|Tiếng Tajik", "uk_UA|Tiếng U-krai-na", "ky_KG|Tiếng Kyrgyz", "kk_KZ|Tiếng Kazakh", "hy_AM|Tiếng Armenia", "he_IL|Tiếng Do Thái",
			"ur_PK|Tiếng Urdu", "ar_AR|Tiếng Ả Rập", "fa_IR|Tiếng Ba Tư", "ps_AF|Tiếng Pashto", "cb_IQ|Tiếng Kurd Sorani", "sy_SY|Tiếng Syria", "ne_NP|Tiếng Nepan", "mr_IN|Tiếng Marathi", "hi_IN|Tiếng Hin-di (Ấn Độ)", "as_IN|Tiếng Assam",
			"bn_IN|Tiếng Bengali", "pa_IN|Tiếng Punjabi", "gu_IN|Tiếng Gujarati", "or_IN|Tiếng Oriya", "ta_IN|Tiếng Tamil", "te_IN|Tiếng Telugu", "kn_IN|Tiếng Kannada", "ml_IN|Tiếng Malayalam", "si_LK|Tiếng Sinhala", "th_TH|Tiếng Thái",
			"lo_LA|Tiếng Lào", "my_MM|Tiếng Miến Điện", "ka_GE|Tiếng Georgia", "am_ET|Tiếng Amhara", "km_KH|Tiếng Khơ-me", "tz_MA|Tiếng Tamazight", "zh_TW|Tiếng Trung phồn thể (Đài Loan)", "zh_CN|Tiếng Trung giản thể (Trung Quốc)", "zh_HK|Tiếng Trung phồn thể (Hồng Kông)", "ja_JP|Tiếng Nhật",
			"ja_KS|Tiếng Nhật (Kansai)", "ko_KR|Tiếng Hàn"
		});
		cbbLanguageSauKhiUnlock.Location = new System.Drawing.Point(197, 371);
		cbbLanguageSauKhiUnlock.Name = "cbbLanguageSauKhiUnlock";
		cbbLanguageSauKhiUnlock.Size = new System.Drawing.Size(205, 24);
		cbbLanguageSauKhiUnlock.TabIndex = 196;
		FEBB10A9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		FEBB10A9.Controls.Add(txtLanguage);
		FEBB10A9.Controls.Add(txtApiPhone);
		FEBB10A9.Controls.Add(button3);
		FEBB10A9.Controls.Add(linkLabel1);
		FEBB10A9.Controls.Add(plServiceId);
		FEBB10A9.Controls.Add(nudLimitTimeGetPhone);
		FEBB10A9.Controls.Add(nudLimitCountGetPhone);
		FEBB10A9.Controls.Add(BE121727);
		FEBB10A9.Controls.Add(label5);
		FEBB10A9.Controls.Add(label3);
		FEBB10A9.Controls.Add(FBA647A4);
		FEBB10A9.Controls.Add(label2);
		FEBB10A9.Controls.Add(ckbLanguage);
		FEBB10A9.Controls.Add(cbbTypePhone);
		FEBB10A9.Location = new System.Drawing.Point(35, 45);
		FEBB10A9.Name = "plPhone";
		FEBB10A9.Size = new System.Drawing.Size(367, 150);
		FEBB10A9.TabIndex = 38;
		txtLanguage.Location = new System.Drawing.Point(223, 62);
		txtLanguage.Name = "txtLanguage";
		txtLanguage.Size = new System.Drawing.Size(118, 23);
		txtLanguage.TabIndex = 45;
		txtLanguage.Text = "en_US,th_TH,my_MM";
		txtApiPhone.Location = new System.Drawing.Point(161, 5);
		txtApiPhone.Name = "txtApiPhone";
		txtApiPhone.Size = new System.Drawing.Size(199, 23);
		txtApiPhone.TabIndex = 34;
		button3.Cursor = System.Windows.Forms.Cursors.Hand;
		button3.Location = new System.Drawing.Point(319, 4);
		button3.Name = "button3";
		button3.Size = new System.Drawing.Size(42, 25);
		button3.TabIndex = 197;
		button3.Text = "Test";
		button3.UseVisualStyleBackColor = true;
		button3.Click += new System.EventHandler(button3_Click);
		linkLabel1.AutoSize = true;
		linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		linkLabel1.Location = new System.Drawing.Point(347, 65);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new System.Drawing.Size(13, 16);
		linkLabel1.TabIndex = 195;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "?";
		linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		plServiceId.Controls.Add(txtServiceId);
		plServiceId.Controls.Add(C52B6813);
		plServiceId.Location = new System.Drawing.Point(148, 32);
		plServiceId.Name = "plServiceId";
		plServiceId.Size = new System.Drawing.Size(213, 25);
		plServiceId.TabIndex = 194;
		txtServiceId.Location = new System.Drawing.Point(75, 1);
		txtServiceId.Name = "txtServiceId";
		txtServiceId.Size = new System.Drawing.Size(137, 23);
		txtServiceId.TabIndex = 45;
		C52B6813.AutoSize = true;
		C52B6813.Location = new System.Drawing.Point(8, 4);
		C52B6813.Name = "label1";
		C52B6813.Size = new System.Drawing.Size(69, 16);
		C52B6813.TabIndex = 44;
		C52B6813.Text = "service_id:";
		nudLimitTimeGetPhone.Location = new System.Drawing.Point(223, 120);
		nudLimitTimeGetPhone.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudLimitTimeGetPhone.Name = "nudLimitTimeGetPhone";
		nudLimitTimeGetPhone.Size = new System.Drawing.Size(137, 23);
		nudLimitTimeGetPhone.TabIndex = 38;
		nudLimitCountGetPhone.Location = new System.Drawing.Point(223, 91);
		nudLimitCountGetPhone.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudLimitCountGetPhone.Name = "nudLimitCountGetPhone";
		nudLimitCountGetPhone.Size = new System.Drawing.Size(137, 23);
		nudLimitCountGetPhone.TabIndex = 38;
		BE121727.Location = new System.Drawing.Point(58, 34);
		BE121727.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		BE121727.Name = "nudTime";
		BE121727.Size = new System.Drawing.Size(56, 23);
		BE121727.TabIndex = 38;
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(0, 122);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(172, 16);
		label5.TabIndex = 37;
		label5.Text = "Giới hạn thời gian lấy sđt (s):";
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(114, 36);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(30, 16);
		label3.TabIndex = 37;
		label3.Text = "giây";
		FBA647A4.AutoSize = true;
		FBA647A4.Location = new System.Drawing.Point(0, 93);
		FBA647A4.Name = "label4";
		FBA647A4.Size = new System.Drawing.Size(137, 16);
		FBA647A4.TabIndex = 37;
		FBA647A4.Text = "Giới hạn số lần lấy sđt:";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(0, 36);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(56, 16);
		label2.TabIndex = 37;
		label2.Text = "Chờ otp:";
		ckbLanguage.AutoSize = true;
		ckbLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLanguage.Location = new System.Drawing.Point(4, 64);
		ckbLanguage.Name = "ckbLanguage";
		ckbLanguage.Size = new System.Drawing.Size(205, 20);
		ckbLanguage.TabIndex = 34;
		ckbLanguage.Text = "Đổi ngôn ngữ trước khi lấy Sđt:";
		ckbLanguage.UseVisualStyleBackColor = true;
		ckbLanguage.CheckedChanged += new System.EventHandler(B8102C1A_CheckedChanged);
		cbbTypePhone.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTypePhone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTypePhone.DropDownWidth = 350;
		cbbTypePhone.FormattingEnabled = true;
		cbbTypePhone.Location = new System.Drawing.Point(4, 4);
		cbbTypePhone.Name = "cbbTypePhone";
		cbbTypePhone.Size = new System.Drawing.Size(151, 24);
		cbbTypePhone.TabIndex = 193;
		cbbTypePhone.SelectedIndexChanged += new System.EventHandler(cbbTypePhone_SelectedIndexChanged);
		ckbSwitch282To956.AutoSize = true;
		ckbSwitch282To956.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbSwitch282To956.Location = new System.Drawing.Point(276, 22);
		ckbSwitch282To956.Name = "ckbSwitch282To956";
		ckbSwitch282To956.Size = new System.Drawing.Size(119, 20);
		ckbSwitch282To956.TabIndex = 34;
		ckbSwitch282To956.Text = "Đa\u0301 956 (nê\u0301u co\u0301)";
		ckbSwitch282To956.UseVisualStyleBackColor = true;
		ckbPhone.AutoSize = true;
		ckbPhone.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbPhone.Location = new System.Drawing.Point(14, 22);
		ckbPhone.Name = "ckbPhone";
		ckbPhone.Size = new System.Drawing.Size(88, 20);
		ckbPhone.TabIndex = 34;
		ckbPhone.Text = "Thêm SĐT";
		ckbPhone.UseVisualStyleBackColor = true;
		ckbPhone.CheckedChanged += new System.EventHandler(ckbPhone_CheckedChanged);
		ckbAddMail.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		ckbAddMail.AutoSize = true;
		ckbAddMail.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAddMail.Location = new System.Drawing.Point(14, 199);
		ckbAddMail.Name = "ckbAddMail";
		ckbAddMail.Size = new System.Drawing.Size(76, 20);
		ckbAddMail.TabIndex = 36;
		ckbAddMail.Text = "Add mail";
		ckbAddMail.UseVisualStyleBackColor = true;
		ckbAddMail.CheckedChanged += new System.EventHandler(CFA53F2C);
		ckbImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		ckbImage.AutoSize = true;
		ckbImage.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbImage.Location = new System.Drawing.Point(14, 260);
		ckbImage.Name = "ckbImage";
		ckbImage.Size = new System.Drawing.Size(66, 20);
		ckbImage.TabIndex = 36;
		ckbImage.Text = "Up ảnh";
		ckbImage.UseVisualStyleBackColor = true;
		ckbImage.CheckedChanged += new System.EventHandler(ckbImage_CheckedChanged);
		plMail.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		plMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plMail.Controls.Add(E0B309A5);
		plMail.Controls.Add(cbbTypeMail);
		plMail.Controls.Add(label7);
		plMail.Location = new System.Drawing.Point(35, 221);
		plMail.Name = "plMail";
		plMail.Size = new System.Drawing.Size(367, 34);
		plMail.TabIndex = 49;
		E0B309A5.Cursor = System.Windows.Forms.Cursors.Hand;
		E0B309A5.Location = new System.Drawing.Point(274, 3);
		E0B309A5.Name = "btnNhapMail";
		E0B309A5.Size = new System.Drawing.Size(86, 26);
		E0B309A5.TabIndex = 122;
		E0B309A5.Text = "Nhập (0)";
		E0B309A5.UseVisualStyleBackColor = true;
		E0B309A5.Click += new System.EventHandler(E0B309A5_Click);
		cbbTypeMail.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTypeMail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTypeMail.DropDownWidth = 200;
		cbbTypeMail.FormattingEnabled = true;
		cbbTypeMail.Items.AddRange(new object[3] { "Hotmail", "Mail domain", "https://generator.email/" });
		cbbTypeMail.Location = new System.Drawing.Point(74, 4);
		cbbTypeMail.Name = "cbbTypeMail";
		cbbTypeMail.Size = new System.Drawing.Size(194, 24);
		cbbTypeMail.TabIndex = 121;
		cbbTypeMail.SelectedIndexChanged += new System.EventHandler(cbbTypeMail_SelectedIndexChanged);
		label7.AutoSize = true;
		label7.Location = new System.Drawing.Point(4, 7);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(63, 16);
		label7.TabIndex = 119;
		label7.Text = "Loại mail:";
		plImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		plImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plImage.Controls.Add(cbbImageUrl);
		plImage.Controls.Add(rbWeb);
		plImage.Controls.Add(CC863B85);
		plImage.Controls.Add(B2336005);
		plImage.Controls.Add(C9B897AF);
		plImage.Controls.Add(B8102C1A);
		plImage.Location = new System.Drawing.Point(35, 282);
		plImage.Name = "plImage";
		plImage.Size = new System.Drawing.Size(367, 85);
		plImage.TabIndex = 49;
		cbbImageUrl.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbImageUrl.DropDownWidth = 250;
		cbbImageUrl.FormattingEnabled = true;
		cbbImageUrl.Items.AddRange(new object[4] { "https://thispersondoesnotexist.com", "https://this-person-does-not-exist.com", "https://www.unrealperson.com", "https://boredhumans.com" });
		cbbImageUrl.Location = new System.Drawing.Point(161, 33);
		cbbImageUrl.Name = "cbbImageUrl";
		cbbImageUrl.Size = new System.Drawing.Size(200, 24);
		cbbImageUrl.TabIndex = 200;
		rbWeb.AutoSize = true;
		rbWeb.Cursor = System.Windows.Forms.Cursors.Hand;
		rbWeb.Location = new System.Drawing.Point(7, 34);
		rbWeb.Name = "rbWeb";
		rbWeb.Size = new System.Drawing.Size(88, 20);
		rbWeb.TabIndex = 38;
		rbWeb.Text = "Lấy từ web";
		rbWeb.UseVisualStyleBackColor = true;
		rbWeb.CheckedChanged += new System.EventHandler(A4B36B35);
		CC863B85.AutoSize = true;
		CC863B85.Checked = true;
		CC863B85.Cursor = System.Windows.Forms.Cursors.Hand;
		CC863B85.Location = new System.Drawing.Point(7, 5);
		CC863B85.Name = "rbFolder";
		CC863B85.Size = new System.Drawing.Size(144, 20);
		CC863B85.TabIndex = 38;
		CC863B85.TabStop = true;
		CC863B85.Text = "Đường dẫn thư mục:";
		CC863B85.UseVisualStyleBackColor = true;
		CC863B85.CheckedChanged += new System.EventHandler(CC863B85_CheckedChanged);
		B2336005.Location = new System.Drawing.Point(161, 4);
		B2336005.Name = "txtImage";
		B2336005.Size = new System.Drawing.Size(200, 23);
		B2336005.TabIndex = 37;
		C9B897AF.AutoSize = true;
		C9B897AF.Cursor = System.Windows.Forms.Cursors.Hand;
		C9B897AF.Location = new System.Drawing.Point(7, 60);
		C9B897AF.Name = "ckbChangeMD5";
		C9B897AF.Size = new System.Drawing.Size(138, 20);
		C9B897AF.TabIndex = 34;
		C9B897AF.Text = "Change MD5 Image";
		C9B897AF.UseVisualStyleBackColor = true;
		C9B897AF.CheckedChanged += new System.EventHandler(B8102C1A_CheckedChanged);
		B8102C1A.AutoSize = true;
		B8102C1A.Cursor = System.Windows.Forms.Cursors.Hand;
		B8102C1A.Location = new System.Drawing.Point(161, 60);
		B8102C1A.Name = "ckbBackupAnh";
		B8102C1A.Size = new System.Drawing.Size(176, 20);
		B8102C1A.TabIndex = 34;
		B8102C1A.Text = "Ưu tiên gửi ảnh đã backup";
		B8102C1A.UseVisualStyleBackColor = true;
		B8102C1A.CheckedChanged += new System.EventHandler(B8102C1A_CheckedChanged);
		BCA97838.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		BCA97838.AutoSize = true;
		BCA97838.Cursor = System.Windows.Forms.Cursors.Hand;
		BCA97838.Location = new System.Drawing.Point(14, 373);
		BCA97838.Name = "ckbDoiNgonNguSauKhiUnlock";
		BCA97838.Size = new System.Drawing.Size(187, 20);
		BCA97838.TabIndex = 34;
		BCA97838.Text = "Đổi ngôn ngữ sau khi unlock";
		BCA97838.UseVisualStyleBackColor = true;
		BCA97838.CheckedChanged += new System.EventHandler(F1A249AE);
		plCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plCaptcha.Controls.Add(cbbCaptcha);
		plCaptcha.Controls.Add(AC000EAE);
		plCaptcha.Controls.Add(C13DD199);
		plCaptcha.Controls.Add(ckbSkipRecaptcha);
		plCaptcha.Controls.Add(label6);
		plCaptcha.Controls.Add(button5);
		plCaptcha.Controls.Add(button4);
		plCaptcha.Location = new System.Drawing.Point(45, 163);
		plCaptcha.Name = "plCaptcha";
		plCaptcha.Size = new System.Drawing.Size(367, 64);
		plCaptcha.TabIndex = 48;
		cbbCaptcha.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbCaptcha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbCaptcha.DropDownWidth = 200;
		cbbCaptcha.FormattingEnabled = true;
		cbbCaptcha.Location = new System.Drawing.Point(6, 33);
		cbbCaptcha.Name = "cbbCaptcha";
		cbbCaptcha.Size = new System.Drawing.Size(148, 24);
		cbbCaptcha.TabIndex = 193;
		cbbCaptcha.SelectedIndexChanged += new System.EventHandler(E10F0C8C);
		AC000EAE.Location = new System.Drawing.Point(160, 5);
		AC000EAE.Name = "txtCaptcha_4";
		AC000EAE.Size = new System.Drawing.Size(147, 23);
		AC000EAE.TabIndex = 34;
		C13DD199.Location = new System.Drawing.Point(160, 34);
		C13DD199.Name = "txtCaptcha";
		C13DD199.Size = new System.Drawing.Size(147, 23);
		C13DD199.TabIndex = 34;
		ckbSkipRecaptcha.AutoSize = true;
		ckbSkipRecaptcha.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbSkipRecaptcha.Location = new System.Drawing.Point(6, 64);
		ckbSkipRecaptcha.Name = "ckbSkipRecaptcha";
		ckbSkipRecaptcha.Size = new System.Drawing.Size(170, 20);
		ckbSkipRecaptcha.TabIndex = 32;
		ckbSkipRecaptcha.Text = "Bo\u0309 qua khi gă\u0323p recaptcha";
		ckbSkipRecaptcha.UseVisualStyleBackColor = true;
		ckbSkipRecaptcha.CheckedChanged += new System.EventHandler(ckbCaptcha_CheckedChanged);
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(3, 7);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(130, 16);
		label6.TabIndex = 0;
		label6.Text = "API Key Omocaptcha:";
		button5.Cursor = System.Windows.Forms.Cursors.Hand;
		button5.Location = new System.Drawing.Point(312, 4);
		button5.Name = "button5";
		button5.Size = new System.Drawing.Size(49, 25);
		button5.TabIndex = 122;
		button5.Text = "Check";
		button5.UseVisualStyleBackColor = true;
		button5.Click += new System.EventHandler(button5_Click);
		button4.Cursor = System.Windows.Forms.Cursors.Hand;
		button4.Location = new System.Drawing.Point(312, 33);
		button4.Name = "button4";
		button4.Size = new System.Drawing.Size(49, 25);
		button4.TabIndex = 122;
		button4.Text = "Check";
		button4.UseVisualStyleBackColor = true;
		button4.Click += new System.EventHandler(button4_Click);
		ckbDeleteContact.AutoSize = true;
		ckbDeleteContact.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbDeleteContact.Location = new System.Drawing.Point(24, 233);
		ckbDeleteContact.Name = "ckbDeleteContact";
		ckbDeleteContact.Size = new System.Drawing.Size(261, 20);
		ckbDeleteContact.TabIndex = 32;
		ckbDeleteContact.Text = "Xo\u0301a thông tin liên hê\u0323 kha\u0301c email trên tool";
		ckbDeleteContact.UseVisualStyleBackColor = true;
		ckbDeleteContact.CheckedChanged += new System.EventHandler(ckbCaptcha_CheckedChanged);
		ckbCaptcha.AutoSize = true;
		ckbCaptcha.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCaptcha.Location = new System.Drawing.Point(24, 137);
		ckbCaptcha.Name = "ckbCaptcha";
		ckbCaptcha.Size = new System.Drawing.Size(95, 20);
		ckbCaptcha.TabIndex = 32;
		ckbCaptcha.Text = "Giải captcha";
		ckbCaptcha.UseVisualStyleBackColor = true;
		ckbCaptcha.CheckedChanged += new System.EventHandler(ckbCaptcha_CheckedChanged);
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(435, 470);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(B8923884);
		E8364B1A.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		E8364B1A.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		E8364B1A.Cursor = System.Windows.Forms.Cursors.Hand;
		E8364B1A.FlatAppearance.BorderSize = 0;
		E8364B1A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E8364B1A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E8364B1A.ForeColor = System.Drawing.Color.White;
		E8364B1A.Location = new System.Drawing.Point(328, 470);
		E8364B1A.Name = "btnAdd";
		E8364B1A.Size = new System.Drawing.Size(92, 29);
		E8364B1A.TabIndex = 9;
		E8364B1A.Text = "Lưu";
		E8364B1A.UseVisualStyleBackColor = false;
		E8364B1A.Click += new System.EventHandler(E8364B1A_Click);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(873, 37);
		bunifuCards1.TabIndex = 28;
		B51ED7AA.AutoSize = true;
		B51ED7AA.Font = new System.Drawing.Font("Tahoma", 8.75f);
		B51ED7AA.Location = new System.Drawing.Point(441, 431);
		B51ED7AA.Name = "ckbXoaMailCu";
		B51ED7AA.Size = new System.Drawing.Size(167, 18);
		B51ED7AA.TabIndex = 199;
		B51ED7AA.Text = "Xóa email cũ (Nếu Fb hỏi)";
		B51ED7AA.UseVisualStyleBackColor = true;
		B51ED7AA.Visible = false;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(876, 515);
		base.Controls.Add(BD8C2AA8);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fCauHinhCheckPoint";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(C4B7D633_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		BD8C2AA8.ResumeLayout(false);
		BD8C2AA8.PerformLayout();
		ABB8DF23.ResumeLayout(false);
		ABB8DF23.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudCountLink956).EndInit();
		plNhapSdt.ResumeLayout(false);
		plNhapSdt.PerformLayout();
		A080B5BC.ResumeLayout(false);
		A080B5BC.PerformLayout();
		grCheckpoint282.ResumeLayout(false);
		grCheckpoint282.PerformLayout();
		FEBB10A9.ResumeLayout(false);
		FEBB10A9.PerformLayout();
		plServiceId.ResumeLayout(false);
		plServiceId.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudLimitTimeGetPhone).EndInit();
		((System.ComponentModel.ISupportInitialize)nudLimitCountGetPhone).EndInit();
		((System.ComponentModel.ISupportInitialize)BE121727).EndInit();
		plMail.ResumeLayout(false);
		plMail.PerformLayout();
		plImage.ResumeLayout(false);
		plImage.PerformLayout();
		plCaptcha.ResumeLayout(false);
		plCaptcha.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
