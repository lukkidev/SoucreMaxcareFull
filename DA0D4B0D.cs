using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class DA0D4B0D : Form
{
	private GClass11 C99810B6;

	private string CF8BB3B8;

	private string string_0;

	private string string_1;

	private int int_0;

	public static bool E7831214;

	private List<string> A1B60685 = new List<string>();

	private List<string> list_0 = new List<string>();

	private List<string> list_1 = new List<string>();

	private List<string> list_2 = new List<string>();

	private List<string> CDBB7F11 = new List<string>();

	private List<string> E1A95B17 = new List<string>();

	private List<string> list_3 = new List<string>();

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox BB079D35;

	private Label label1;

	private Button CD987D28;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox E137AD84;

	private BunifuCustomLabel D4082506;

	private CheckBox ckbXoaMailCu;

	private ToolTip A62C1D81;

	private Panel D32C858E;

	private CheckBox B2AF1F88;

	private Panel plMatKhauMoi;

	private Label AE0F9C13;

	private TextBox txtNewPass;

	private ComboBox DD87FF18;

	private ComboBox D813AC8A;

	private ComboBox cbbAddMail;

	private Button F8243518;

	private Label label3;

	private Label CE2C398C;

	private CheckBox ckbAnMail;

	private Button button2;

	private NumericUpDown nudDelayOtp;

	private Label FE2E20BE;

	public DA0D4B0D(string string_2, int int_1 = 0, string D32926A1 = "")
	{
		InitializeComponent();
		E7831214 = false;
		CF8BB3B8 = string_2;
		string_1 = D32926A1;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Add mail";
		if (Class147.smethod_7("", text).Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			BB079D35.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(D32926A1);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			BB079D35.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		C99810B6 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void DA0D4B0D_Load(object sender, EventArgs e)
	{
		try
		{
			method_1();
			method_2();
			method_0();
			B2AF1F88.Checked = C99810B6.method_3("ckbAddMail");
			cbbAddMail.SelectedValue = C99810B6.C0288288("typeAddMail", "7");
			try
			{
				DD87FF18.SelectedValue = C99810B6.C0288288("cbbTypeMail", "0");
			}
			catch
			{
				DD87FF18.SelectedIndex = 0;
			}
			A1B60685 = C99810B6.C5A69DA0("lstHotmail");
			list_0 = C99810B6.C5A69DA0("lstMailDomain");
			list_1 = C99810B6.C5A69DA0("lstDomain");
			list_2 = C99810B6.C5A69DA0("lstDomainUnlimitMail");
			if (list_2.Count == 0)
			{
				list_2.Add("otpgmail.com");
			}
			CDBB7F11 = C99810B6.C5A69DA0("lstDomainDonglaomail");
			if (CDBB7F11.Count == 0)
			{
				CDBB7F11.Add("cristionel.com");
			}
			E1A95B17 = C99810B6.C5A69DA0("lstDomain1secmail");
			if (E1A95B17.Count == 0)
			{
				E1A95B17.Add("1secmail.com");
			}
			list_3 = C99810B6.C5A69DA0("lstDomainMailtm");
			if (list_3.Count == 0)
			{
				list_3.Add("starmail.net");
			}
			nudDelayOtp.Value = C99810B6.method_2("nudDelayOtp", 60);
			ckbXoaMailCu.Checked = C99810B6.method_3("ckbXoaMailCu");
			D813AC8A.SelectedValue = C99810B6.C0288288("typeXoaMail", "0");
			txtNewPass.Text = C99810B6.C0288288("txtNewPass");
			ckbAnMail.Checked = C99810B6.method_3("ckbAnMail");
			B2AF1F88_CheckedChanged(null, null);
			ckbXoaMailCu_CheckedChanged(null, null);
			A1810AAF();
			method_4();
		}
		catch
		{
		}
	}

	private void method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Sử dụng m.fb");
		dictionary.Add("1", "Sử dụng link hacked");
		dictionary.Add("2", "Sử dụng www");
		dictionary.Add("3", "Sử dụng tut không pass");
		GClass8.smethod_23(D813AC8A, dictionary);
	}

	private void method_1()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("6", "Sư\u0309 du\u0323ng Account Center");
		dictionary.Add("7", "Tut không câ\u0300n lâ\u0301y otp tư\u0300 email cu\u0303");
		GClass8.smethod_23(cbbAddMail, dictionary);
	}

	private void method_2()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Hotmail");
		dictionary.Add("2", "https://generator.email/");
		dictionary.Add("3", "https://unlimitmail.com/");
		dictionary.Add("5", "https://hotmail9.com/");
		dictionary.Add("6", "https://1secmail.com/");
		dictionary.Add("8", "https://donglaomail.com/");
		GClass8.smethod_23(DD87FF18, dictionary);
	}

	private void A905550D(object sender, EventArgs e)
	{
		Close();
	}

	private void FA3E6080(object sender, EventArgs e)
	{
		string text = BB079D35.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("ckbAddMail", B2AF1F88.Checked);
		gClass.method_4("typeAddMail", cbbAddMail.SelectedValue);
		gClass.method_4("cbbTypeMail", DD87FF18.SelectedValue);
		gClass.method_5("lstHotmail", A1B60685);
		gClass.method_5("lstMailDomain", list_0);
		gClass.method_5("lstDomain", list_1);
		gClass.method_5("lstDomainUnlimitMail", list_2);
		gClass.method_5("lstDomainDonglaomail", CDBB7F11);
		gClass.method_5("lstDomain1secmail", E1A95B17);
		gClass.method_5("lstDomainMailtm", list_3);
		gClass.method_4("nudDelayOtp", nudDelayOtp.Value);
		gClass.method_4("ckbXoaMailCu", ckbXoaMailCu.Checked);
		gClass.method_4("typeXoaMail", D813AC8A.SelectedValue);
		gClass.method_4("txtNewPass", txtNewPass.Text.Trim());
		gClass.method_4("ckbAnMail", ckbAnMail.Checked);
		string string_ = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(CF8BB3B8, text, string_0, string_))
				{
					E7831214 = true;
					Close();
				}
				else
				{
					GClass29.smethod_0("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
				}
			}
		}
		else if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") == DialogResult.Yes)
		{
			if (Class147.smethod_13(string_1, text, string_))
			{
				E7831214 = true;
				Close();
			}
			else
			{
				GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void CD987D28_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void BC325F3D(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void B2AF1F88_CheckedChanged(object sender, EventArgs e)
	{
		D32C858E.Enabled = B2AF1F88.Checked;
		A1810AAF();
	}

	private void ckbXoaMailCu_CheckedChanged(object sender, EventArgs e)
	{
		D813AC8A.Enabled = ckbXoaMailCu.Checked;
		A1810AAF();
	}

	private void method_3(object sender, EventArgs e)
	{
	}

	private void EA939C30(object sender, EventArgs e)
	{
		A1810AAF();
	}

	private void A1810AAF()
	{
		plMatKhauMoi.Enabled = (cbbAddMail.Enabled && cbbAddMail.Text.ToLower().Contains("hacked")) || (D813AC8A.Enabled && D813AC8A.Text.ToLower().Contains("hacked"));
	}

	private void EA21AE21(object sender, EventArgs e)
	{
		method_4();
	}

	private void method_4()
	{
		string text = DD87FF18.SelectedValue.ToString();
		string text2 = text;
		string text3 = text2;
		switch (C43AF739.smethod_0(text3))
		{
		case 873244444u:
			if (text3 == "1")
			{
				GClass8.smethod_61(F8243518, list_0.Count);
			}
			break;
		case 856466825u:
			if (text3 == "6")
			{
				GClass8.smethod_61(F8243518, E1A95B17.Count);
			}
			break;
		case 839689206u:
			if (text3 == "7")
			{
				GClass8.smethod_61(F8243518, list_3.Count);
			}
			break;
		case 906799682u:
			if (text3 == "3")
			{
				GClass8.smethod_61(F8243518, list_2.Count);
			}
			break;
		case 890022063u:
			if (text3 == "0")
			{
				GClass8.smethod_61(F8243518, A1B60685.Count);
			}
			break;
		case 1024243015u:
			if (text3 == "8")
			{
				GClass8.smethod_61(F8243518, CDBB7F11.Count);
			}
			break;
		case 923577301u:
			if (text3 == "2")
			{
				GClass8.smethod_61(F8243518, list_1.Count);
			}
			break;
		}
		F8243518.Enabled = text != "4" && text != "5";
	}

	private void F8243518_Click(object sender, EventArgs e)
	{
		string text = DD87FF18.SelectedValue.ToString();
		string text2 = text;
		string text3 = text2;
		switch (C43AF739.smethod_0(text3))
		{
		case 873244444u:
			if (text3 == "1")
			{
				fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_0, "Nhâ\u0323p danh sa\u0301ch link mail domain", "Danh sa\u0301ch link mail domain", "(Mô\u0303i nội dung 1 do\u0300ng)");
				GClass8.smethod_33(fNhapDuLieu4);
				list_0 = fNhapDuLieu4.C6009CA1;
				GClass8.smethod_61(F8243518, list_0.Count);
			}
			break;
		case 856466825u:
			if (text3 == "6")
			{
				fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(E1A95B17, "Nhâ\u0323p danh sa\u0301ch domain", "Danh sa\u0301ch domain", "(Mô\u0303i nội dung 1 do\u0300ng)");
				GClass8.smethod_33(fNhapDuLieu4);
				E1A95B17 = fNhapDuLieu4.C6009CA1;
				GClass8.smethod_61(F8243518, E1A95B17.Count);
			}
			break;
		case 839689206u:
			if (text3 == "7")
			{
				fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_3, "Nhâ\u0323p danh sa\u0301ch domain", "Danh sa\u0301ch domain", "(Mô\u0303i nội dung 1 do\u0300ng)");
				GClass8.smethod_33(fNhapDuLieu4);
				list_3 = fNhapDuLieu4.C6009CA1;
				GClass8.smethod_61(F8243518, list_3.Count);
			}
			break;
		case 906799682u:
			if (text3 == "3")
			{
				fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_2, "Nhâ\u0323p danh sa\u0301ch domain", "Danh sa\u0301ch domain", "(Mô\u0303i nội dung 1 do\u0300ng)");
				GClass8.smethod_33(fNhapDuLieu4);
				list_2 = fNhapDuLieu4.C6009CA1;
				GClass8.smethod_61(F8243518, list_2.Count);
			}
			break;
		case 890022063u:
			if (text3 == "0")
			{
				fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(A1B60685, "Nhâ\u0323p danh sa\u0301ch hotmail", "Danh sa\u0301ch email|password hoă\u0323c email|password|refresh_token|client_id", "(Mô\u0303i nội dung 1 do\u0300ng)");
				GClass8.smethod_33(fNhapDuLieu4);
				A1B60685 = fNhapDuLieu4.C6009CA1;
				GClass8.smethod_61(F8243518, A1B60685.Count);
			}
			break;
		case 1024243015u:
			if (text3 == "8")
			{
				fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(CDBB7F11, "Nhâ\u0323p danh sa\u0301ch domain", "Danh sa\u0301ch domain", "(Mô\u0303i nội dung 1 do\u0300ng)");
				GClass8.smethod_33(fNhapDuLieu4);
				CDBB7F11 = fNhapDuLieu4.C6009CA1;
				GClass8.smethod_61(F8243518, CDBB7F11.Count);
			}
			break;
		case 923577301u:
			if (text3 == "2")
			{
				fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_1, "Nhâ\u0323p danh sa\u0301ch domain", "Danh sa\u0301ch domain", "(Mô\u0303i nội dung 1 do\u0300ng)");
				GClass8.smethod_33(fNhapDuLieu4);
				list_1 = fNhapDuLieu4.C6009CA1;
				GClass8.smethod_61(F8243518, list_1.Count);
			}
			break;
		}
	}

	private void cbbAddMail_Click(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		string eD = "Có thể sử dụng ký tự * để random 1 ký tự ngẫu nhiên!\r\nVí dụ: MIN****** => MINdfghta";
		GClass29.smethod_0(eD);
	}

	private void BE09F5A9(object sender, EventArgs e)
	{
		A1810AAF();
	}

	private void panel1_ParentChanged(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DA0D4B0D));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		D4082506 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		E137AD84 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		D32C858E = new System.Windows.Forms.Panel();
		nudDelayOtp = new System.Windows.Forms.NumericUpDown();
		cbbAddMail = new System.Windows.Forms.ComboBox();
		F8243518 = new System.Windows.Forms.Button();
		DD87FF18 = new System.Windows.Forms.ComboBox();
		label3 = new System.Windows.Forms.Label();
		FE2E20BE = new System.Windows.Forms.Label();
		CE2C398C = new System.Windows.Forms.Label();
		D813AC8A = new System.Windows.Forms.ComboBox();
		plMatKhauMoi = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		AE0F9C13 = new System.Windows.Forms.Label();
		txtNewPass = new System.Windows.Forms.TextBox();
		B2AF1F88 = new System.Windows.Forms.CheckBox();
		ckbAnMail = new System.Windows.Forms.CheckBox();
		ckbXoaMailCu = new System.Windows.Forms.CheckBox();
		BB079D35 = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		CD987D28 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		A62C1D81 = new System.Windows.Forms.ToolTip(icontainer_0);
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)E137AD84).BeginInit();
		panel1.SuspendLayout();
		D32C858E.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayOtp).BeginInit();
		plMatKhauMoi.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = D4082506;
		bunifuDragControl_0.Vertical = true;
		D4082506.BackColor = System.Drawing.Color.Transparent;
		D4082506.Cursor = System.Windows.Forms.Cursors.SizeAll;
		D4082506.Dock = System.Windows.Forms.DockStyle.Fill;
		D4082506.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D4082506.ForeColor = System.Drawing.Color.Black;
		D4082506.Location = new System.Drawing.Point(0, 0);
		D4082506.Name = "bunifuCustomLabel1";
		D4082506.Size = new System.Drawing.Size(356, 31);
		D4082506.TabIndex = 12;
		D4082506.Text = "Cấu hình Add Mail";
		D4082506.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(E137AD84);
		pnlHeader.Controls.Add(D4082506);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(356, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(325, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(A905550D);
		E137AD84.Cursor = System.Windows.Forms.Cursors.Default;
		E137AD84.Image = C50FB39E.Bitmap_5;
		E137AD84.Location = new System.Drawing.Point(3, 2);
		E137AD84.Name = "pictureBox1";
		E137AD84.Size = new System.Drawing.Size(34, 27);
		E137AD84.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		E137AD84.TabIndex = 76;
		E137AD84.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(D32C858E);
		panel1.Controls.Add(D813AC8A);
		panel1.Controls.Add(plMatKhauMoi);
		panel1.Controls.Add(B2AF1F88);
		panel1.Controls.Add(ckbAnMail);
		panel1.Controls.Add(ckbXoaMailCu);
		panel1.Controls.Add(BB079D35);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(CD987D28);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(359, 246);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(BC325F3D);
		panel1.ParentChanged += new System.EventHandler(panel1_ParentChanged);
		D32C858E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D32C858E.Controls.Add(nudDelayOtp);
		D32C858E.Controls.Add(cbbAddMail);
		D32C858E.Controls.Add(F8243518);
		D32C858E.Controls.Add(DD87FF18);
		D32C858E.Controls.Add(label3);
		D32C858E.Controls.Add(FE2E20BE);
		D32C858E.Controls.Add(CE2C398C);
		D32C858E.Location = new System.Drawing.Point(23, 100);
		D32C858E.Name = "plAddMail";
		D32C858E.Size = new System.Drawing.Size(311, 63);
		D32C858E.TabIndex = 115;
		nudDelayOtp.Location = new System.Drawing.Point(101, 34);
		nudDelayOtp.Maximum = new decimal(new int[4] { 99999999, 0, 0, 0 });
		nudDelayOtp.Name = "nudDelayOtp";
		nudDelayOtp.Size = new System.Drawing.Size(68, 23);
		nudDelayOtp.TabIndex = 118;
		cbbAddMail.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbAddMail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbAddMail.FormattingEnabled = true;
		cbbAddMail.Location = new System.Drawing.Point(101, 99);
		cbbAddMail.Name = "cbbAddMail";
		cbbAddMail.Size = new System.Drawing.Size(205, 24);
		cbbAddMail.TabIndex = 116;
		cbbAddMail.SelectionChangeCommitted += new System.EventHandler(BE09F5A9);
		cbbAddMail.Click += new System.EventHandler(cbbAddMail_Click);
		F8243518.Cursor = System.Windows.Forms.Cursors.Hand;
		F8243518.Location = new System.Drawing.Point(220, 3);
		F8243518.Name = "btnNhapMail";
		F8243518.Size = new System.Drawing.Size(86, 26);
		F8243518.TabIndex = 117;
		F8243518.Text = "Nhập (0)";
		F8243518.UseVisualStyleBackColor = true;
		F8243518.Click += new System.EventHandler(F8243518_Click);
		DD87FF18.Cursor = System.Windows.Forms.Cursors.Hand;
		DD87FF18.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		DD87FF18.DropDownWidth = 200;
		DD87FF18.FormattingEnabled = true;
		DD87FF18.Location = new System.Drawing.Point(101, 4);
		DD87FF18.Name = "cbbTypeMail";
		DD87FF18.Size = new System.Drawing.Size(113, 24);
		DD87FF18.TabIndex = 116;
		DD87FF18.SelectedIndexChanged += new System.EventHandler(EA21AE21);
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(1, 102);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(64, 16);
		label3.TabIndex = 31;
		label3.Text = "Tùy chọn:";
		FE2E20BE.AutoSize = true;
		FE2E20BE.Location = new System.Drawing.Point(1, 36);
		FE2E20BE.Name = "label5";
		FE2E20BE.Size = new System.Drawing.Size(96, 16);
		FE2E20BE.TabIndex = 31;
		FE2E20BE.Text = "Chờ lấy otp (s):";
		CE2C398C.AutoSize = true;
		CE2C398C.Location = new System.Drawing.Point(1, 7);
		CE2C398C.Name = "label4";
		CE2C398C.Size = new System.Drawing.Size(63, 16);
		CE2C398C.TabIndex = 31;
		CE2C398C.Text = "Loại mail:";
		D813AC8A.Cursor = System.Windows.Forms.Cursors.Hand;
		D813AC8A.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		D813AC8A.FormattingEnabled = true;
		D813AC8A.Location = new System.Drawing.Point(125, 400);
		D813AC8A.Name = "cbbXoaMailCu";
		D813AC8A.Size = new System.Drawing.Size(209, 24);
		D813AC8A.TabIndex = 116;
		D813AC8A.SelectedIndexChanged += new System.EventHandler(EA939C30);
		plMatKhauMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plMatKhauMoi.Controls.Add(button2);
		plMatKhauMoi.Controls.Add(AE0F9C13);
		plMatKhauMoi.Controls.Add(txtNewPass);
		plMatKhauMoi.Location = new System.Drawing.Point(23, 430);
		plMatKhauMoi.Name = "plMatKhauMoi";
		plMatKhauMoi.Size = new System.Drawing.Size(311, 31);
		plMatKhauMoi.TabIndex = 115;
		button2.Cursor = System.Windows.Forms.Cursors.Help;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(282, 3);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(24, 24);
		button2.TabIndex = 151;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		AE0F9C13.AutoSize = true;
		AE0F9C13.Location = new System.Drawing.Point(2, 6);
		AE0F9C13.Name = "label2";
		AE0F9C13.Size = new System.Drawing.Size(89, 16);
		AE0F9C13.TabIndex = 31;
		AE0F9C13.Text = "Mật khẩu mới:";
		txtNewPass.Location = new System.Drawing.Point(101, 3);
		txtNewPass.Name = "txtNewPass";
		txtNewPass.Size = new System.Drawing.Size(178, 23);
		txtNewPass.TabIndex = 0;
		B2AF1F88.AutoSize = true;
		B2AF1F88.Cursor = System.Windows.Forms.Cursors.Hand;
		B2AF1F88.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		B2AF1F88.Location = new System.Drawing.Point(23, 78);
		B2AF1F88.Name = "ckbAddMail";
		B2AF1F88.Size = new System.Drawing.Size(75, 20);
		B2AF1F88.TabIndex = 113;
		B2AF1F88.Text = "Add Mail";
		B2AF1F88.UseVisualStyleBackColor = true;
		B2AF1F88.CheckedChanged += new System.EventHandler(B2AF1F88_CheckedChanged);
		ckbAnMail.AutoSize = true;
		ckbAnMail.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAnMail.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		ckbAnMail.Location = new System.Drawing.Point(23, 321);
		ckbAnMail.Name = "ckbAnMail";
		ckbAnMail.Size = new System.Drawing.Size(69, 20);
		ckbAnMail.TabIndex = 113;
		ckbAnMail.Text = "Ẩn mail";
		ckbAnMail.UseVisualStyleBackColor = true;
		ckbXoaMailCu.AutoSize = true;
		ckbXoaMailCu.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbXoaMailCu.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		ckbXoaMailCu.Location = new System.Drawing.Point(23, 169);
		ckbXoaMailCu.Name = "ckbXoaMailCu";
		ckbXoaMailCu.Size = new System.Drawing.Size(183, 20);
		ckbXoaMailCu.TabIndex = 113;
		ckbXoaMailCu.Text = "Xóa mail không co\u0301 trên tool";
		ckbXoaMailCu.UseVisualStyleBackColor = true;
		ckbXoaMailCu.CheckedChanged += new System.EventHandler(ckbXoaMailCu_CheckedChanged);
		BB079D35.Location = new System.Drawing.Point(125, 49);
		BB079D35.Name = "txtTenHanhDong";
		BB079D35.Size = new System.Drawing.Size(209, 23);
		BB079D35.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(20, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		CD987D28.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		CD987D28.BackColor = System.Drawing.Color.Maroon;
		CD987D28.Cursor = System.Windows.Forms.Cursors.Hand;
		CD987D28.FlatAppearance.BorderSize = 0;
		CD987D28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		CD987D28.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CD987D28.ForeColor = System.Drawing.Color.White;
		CD987D28.Location = new System.Drawing.Point(189, 203);
		CD987D28.Name = "btnCancel";
		CD987D28.Size = new System.Drawing.Size(92, 29);
		CD987D28.TabIndex = 7;
		CD987D28.Text = "Đóng";
		CD987D28.UseVisualStyleBackColor = false;
		CD987D28.Click += new System.EventHandler(CD987D28_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(82, 203);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(FA3E6080);
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
		bunifuCards1.Size = new System.Drawing.Size(356, 37);
		bunifuCards1.TabIndex = 28;
		A62C1D81.AutomaticDelay = 0;
		A62C1D81.AutoPopDelay = 0;
		A62C1D81.InitialDelay = 0;
		A62C1D81.ReshowDelay = 0;
		A62C1D81.ShowAlways = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(359, 246);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDAddMail";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(DA0D4B0D_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)E137AD84).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		D32C858E.ResumeLayout(false);
		D32C858E.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayOtp).EndInit();
		plMatKhauMoi.ResumeLayout(false);
		plMatKhauMoi.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
