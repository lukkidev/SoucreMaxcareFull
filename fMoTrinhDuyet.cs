using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fMoTrinhDuyet : Form
{
	public static bool bool_0;

	private IContainer FDB48110 = null;

	private BunifuCards C798C73F;

	private Panel pnlHeader;

	private BunifuCustomLabel B9B00C9B;

	private Button btnMinimize;

	private Button ADAF7E8A;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private Panel panel1;

	private Button BC951101;

	private Label label3;

	private Button B10D1987;

	private CheckBox DD3EA98D;

	private TextBox txtLink;

	private CheckBox A13F98AA;

	private CheckBox ckbLoginHotmail;

	private Panel A32C7F3B;

	private NumericUpDown BA29FBBD;

	private Label label35;

	private Label F40EDA81;

	private NumericUpDown nudHeighChrome;

	private CheckBox ckbAddChromeIntoForm;

	private Panel A11393BA;

	private Label label10;

	private Label D09833B9;

	private ComboBox cbbColumnChrome;

	private ComboBox cbbRowChrome;

	private Panel panel3;

	private RadioButton rbSuDungProfile;

	private RadioButton rbKhongDungProfile;

	private Label EEA78230;

	public fMoTrinhDuyet()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		bool_0 = false;
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void D08EE919(object sender, EventArgs e)
	{
		Close();
	}

	private void BC951101_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fCauHinhChung());
	}

	private void fMoTrinhDuyet_Load(object sender, EventArgs e)
	{
		if (GClass25.smethod_0("configOpenBrowser").method_3("isUseProfile", bool_0: true))
		{
			rbSuDungProfile.Checked = true;
		}
		else
		{
			rbKhongDungProfile.Checked = true;
		}
		ckbAddChromeIntoForm.Checked = GClass25.smethod_0("configOpenBrowser").method_3("ckbAddChromeIntoForm");
		BA29FBBD.Value = GClass25.smethod_0("configOpenBrowser").method_2("nudWidthChrome", 520);
		nudHeighChrome.Value = GClass25.smethod_0("configOpenBrowser").method_2("nudHeighChrome", 480);
		cbbColumnChrome.Text = GClass25.smethod_0("configOpenBrowser").C0288288("cbbColumnChrome", "5");
		cbbRowChrome.Text = GClass25.smethod_0("configOpenBrowser").C0288288("cbbRowChrome", "2");
		DD3EA98D.Checked = GClass25.smethod_0("configOpenBrowser").method_3("isAutoCloseChromeLoginFail");
		A13F98AA.Checked = GClass25.smethod_0("configOpenBrowser").method_3("ckbAutoOpenLink");
		txtLink.Text = GClass25.smethod_0("configOpenBrowser").C0288288("txtLink");
		ckbLoginHotmail.Checked = GClass25.smethod_0("configOpenBrowser").method_3("ckbLoginHotmail");
		D83FC889(null, null);
		E2912594(null, null);
		ckbAddChromeIntoForm_CheckedChanged(null, null);
	}

	private void E9A419BD(object sender, EventArgs e)
	{
		if (rbSuDungProfile.Checked)
		{
			GClass25.smethod_0("configOpenBrowser").method_4("isUseProfile", true);
		}
		else
		{
			GClass25.smethod_0("configOpenBrowser").method_4("isUseProfile", false);
		}
		GClass25.smethod_0("configOpenBrowser").method_4("ckbAddChromeIntoForm", ckbAddChromeIntoForm.Checked);
		GClass25.smethod_0("configOpenBrowser").method_4("nudWidthChrome", BA29FBBD.Value);
		GClass25.smethod_0("configOpenBrowser").method_4("nudHeighChrome", nudHeighChrome.Value);
		GClass25.smethod_0("configOpenBrowser").method_4("cbbColumnChrome", cbbColumnChrome.Text);
		GClass25.smethod_0("configOpenBrowser").method_4("cbbRowChrome", cbbRowChrome.Text);
		GClass25.smethod_0("configOpenBrowser").method_4("isAutoCloseChromeLoginFail", DD3EA98D.Checked);
		GClass25.smethod_0("configOpenBrowser").method_4("ckbAutoOpenLink", A13F98AA.Checked);
		GClass25.smethod_0("configOpenBrowser").method_4("txtLink", txtLink.Text);
		GClass25.smethod_0("configOpenBrowser").method_4("ckbLoginHotmail", ckbLoginHotmail.Checked);
		GClass25.B3B73732("configOpenBrowser");
		bool_0 = true;
		Close();
	}

	private void DCA5C708(object sender, EventArgs e)
	{
	}

	private void D83FC889(object sender, EventArgs e)
	{
		txtLink.Enabled = A13F98AA.Checked;
	}

	private void E2912594(object sender, EventArgs e)
	{
	}

	private void ckbAddChromeIntoForm_CheckedChanged(object sender, EventArgs e)
	{
		A32C7F3B.Enabled = ckbAddChromeIntoForm.Checked;
		A11393BA.Enabled = !ckbAddChromeIntoForm.Checked;
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && FDB48110 != null)
		{
			FDB48110.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		FDB48110 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMoTrinhDuyet));
		C798C73F = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		B9B00C9B = new Bunifu.Framework.UI.BunifuCustomLabel();
		ADAF7E8A = new System.Windows.Forms.Button();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(FDB48110);
		panel1 = new System.Windows.Forms.Panel();
		A11393BA = new System.Windows.Forms.Panel();
		label10 = new System.Windows.Forms.Label();
		D09833B9 = new System.Windows.Forms.Label();
		cbbColumnChrome = new System.Windows.Forms.ComboBox();
		cbbRowChrome = new System.Windows.Forms.ComboBox();
		A32C7F3B = new System.Windows.Forms.Panel();
		BA29FBBD = new System.Windows.Forms.NumericUpDown();
		label35 = new System.Windows.Forms.Label();
		F40EDA81 = new System.Windows.Forms.Label();
		nudHeighChrome = new System.Windows.Forms.NumericUpDown();
		ckbAddChromeIntoForm = new System.Windows.Forms.CheckBox();
		ckbLoginHotmail = new System.Windows.Forms.CheckBox();
		txtLink = new System.Windows.Forms.TextBox();
		BC951101 = new System.Windows.Forms.Button();
		A13F98AA = new System.Windows.Forms.CheckBox();
		DD3EA98D = new System.Windows.Forms.CheckBox();
		B10D1987 = new System.Windows.Forms.Button();
		panel3 = new System.Windows.Forms.Panel();
		rbSuDungProfile = new System.Windows.Forms.RadioButton();
		rbKhongDungProfile = new System.Windows.Forms.RadioButton();
		label3 = new System.Windows.Forms.Label();
		EEA78230 = new System.Windows.Forms.Label();
		C798C73F.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		A11393BA.SuspendLayout();
		A32C7F3B.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)BA29FBBD).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudHeighChrome).BeginInit();
		panel3.SuspendLayout();
		SuspendLayout();
		C798C73F.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		C798C73F.BackColor = System.Drawing.Color.White;
		C798C73F.BorderRadius = 0;
		C798C73F.BottomSahddow = true;
		C798C73F.color = System.Drawing.Color.SaddleBrown;
		C798C73F.Controls.Add(pnlHeader);
		C798C73F.LeftSahddow = false;
		C798C73F.Location = new System.Drawing.Point(1, 0);
		C798C73F.Name = "bunifuCards1";
		C798C73F.RightSahddow = true;
		C798C73F.ShadowDepth = 20;
		C798C73F.Size = new System.Drawing.Size(452, 38);
		C798C73F.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(B9B00C9B);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(452, 32);
		pnlHeader.TabIndex = 9;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 17;
		pictureBox1.TabStop = false;
		btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(419, -1);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		B9B00C9B.BackColor = System.Drawing.Color.Transparent;
		B9B00C9B.Cursor = System.Windows.Forms.Cursors.SizeAll;
		B9B00C9B.Dock = System.Windows.Forms.DockStyle.Fill;
		B9B00C9B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B9B00C9B.ForeColor = System.Drawing.Color.Black;
		B9B00C9B.Location = new System.Drawing.Point(0, 0);
		B9B00C9B.Name = "bunifuCustomLabel1";
		B9B00C9B.Size = new System.Drawing.Size(452, 32);
		B9B00C9B.TabIndex = 1;
		B9B00C9B.Text = "Cấu hình Mở trình duyệt";
		B9B00C9B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		ADAF7E8A.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		ADAF7E8A.BackColor = System.Drawing.Color.Maroon;
		ADAF7E8A.Cursor = System.Windows.Forms.Cursors.Hand;
		ADAF7E8A.FlatAppearance.BorderSize = 0;
		ADAF7E8A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		ADAF7E8A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		ADAF7E8A.ForeColor = System.Drawing.Color.White;
		ADAF7E8A.Location = new System.Drawing.Point(233, 258);
		ADAF7E8A.Name = "btnCancel";
		ADAF7E8A.Size = new System.Drawing.Size(92, 29);
		ADAF7E8A.TabIndex = 4;
		ADAF7E8A.Text = "Đo\u0301ng";
		ADAF7E8A.UseVisualStyleBackColor = false;
		ADAF7E8A.Click += new System.EventHandler(D08EE919);
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = B9B00C9B;
		bunifuDragControl_0.Vertical = true;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(A11393BA);
		panel1.Controls.Add(A32C7F3B);
		panel1.Controls.Add(ckbAddChromeIntoForm);
		panel1.Controls.Add(ckbLoginHotmail);
		panel1.Controls.Add(txtLink);
		panel1.Controls.Add(BC951101);
		panel1.Controls.Add(A13F98AA);
		panel1.Controls.Add(DD3EA98D);
		panel1.Controls.Add(B10D1987);
		panel1.Controls.Add(ADAF7E8A);
		panel1.Controls.Add(panel3);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(EEA78230);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(453, 300);
		panel1.TabIndex = 5;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		A11393BA.Controls.Add(label10);
		A11393BA.Controls.Add(D09833B9);
		A11393BA.Controls.Add(cbbColumnChrome);
		A11393BA.Controls.Add(cbbRowChrome);
		A11393BA.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A11393BA.Location = new System.Drawing.Point(32, 145);
		A11393BA.Name = "plSapXepCuaSoChrome";
		A11393BA.Size = new System.Drawing.Size(358, 28);
		A11393BA.TabIndex = 159;
		label10.AutoSize = true;
		label10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label10.Location = new System.Drawing.Point(3, 4);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(147, 16);
		label10.TabIndex = 33;
		label10.Text = "Sắp xếp cửa sổ chrome:";
		D09833B9.AutoSize = true;
		D09833B9.Font = new System.Drawing.Font("Tahoma", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D09833B9.Location = new System.Drawing.Point(245, 2);
		D09833B9.Name = "label11";
		D09833B9.Size = new System.Drawing.Size(23, 23);
		D09833B9.TabIndex = 33;
		D09833B9.Text = "X";
		cbbColumnChrome.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbColumnChrome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbColumnChrome.FormattingEnabled = true;
		cbbColumnChrome.Items.AddRange(new object[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
		cbbColumnChrome.Location = new System.Drawing.Point(200, 2);
		cbbColumnChrome.Name = "cbbColumnChrome";
		cbbColumnChrome.Size = new System.Drawing.Size(41, 24);
		cbbColumnChrome.TabIndex = 145;
		cbbRowChrome.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbRowChrome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbRowChrome.FormattingEnabled = true;
		cbbRowChrome.Items.AddRange(new object[5] { "1", "2", "3", "4", "5" });
		cbbRowChrome.Location = new System.Drawing.Point(272, 2);
		cbbRowChrome.Name = "cbbRowChrome";
		cbbRowChrome.Size = new System.Drawing.Size(41, 24);
		cbbRowChrome.TabIndex = 145;
		A32C7F3B.Controls.Add(BA29FBBD);
		A32C7F3B.Controls.Add(label35);
		A32C7F3B.Controls.Add(F40EDA81);
		A32C7F3B.Controls.Add(nudHeighChrome);
		A32C7F3B.Location = new System.Drawing.Point(224, 118);
		A32C7F3B.Name = "plAddChromeVaoFormView";
		A32C7F3B.Size = new System.Drawing.Size(175, 27);
		A32C7F3B.TabIndex = 158;
		BA29FBBD.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		BA29FBBD.Location = new System.Drawing.Point(41, 2);
		BA29FBBD.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		BA29FBBD.Name = "nudWidthChrome";
		BA29FBBD.Size = new System.Drawing.Size(53, 23);
		BA29FBBD.TabIndex = 151;
		BA29FBBD.Value = new decimal(new int[4] { 516, 0, 0, 0 });
		label35.AutoSize = true;
		label35.Font = new System.Drawing.Font("Tahoma", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label35.Location = new System.Drawing.Point(95, 2);
		label35.Name = "label35";
		label35.Size = new System.Drawing.Size(23, 23);
		label35.TabIndex = 33;
		label35.Text = "X";
		F40EDA81.AutoSize = true;
		F40EDA81.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		F40EDA81.Location = new System.Drawing.Point(3, 4);
		F40EDA81.Name = "label33";
		F40EDA81.Size = new System.Drawing.Size(36, 16);
		F40EDA81.TabIndex = 33;
		F40EDA81.Text = "Size:";
		nudHeighChrome.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		nudHeighChrome.Location = new System.Drawing.Point(118, 2);
		nudHeighChrome.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudHeighChrome.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		nudHeighChrome.Name = "nudHeighChrome";
		nudHeighChrome.Size = new System.Drawing.Size(53, 23);
		nudHeighChrome.TabIndex = 151;
		nudHeighChrome.Value = new decimal(new int[4] { 480, 0, 0, 0 });
		ckbAddChromeIntoForm.AutoSize = true;
		ckbAddChromeIntoForm.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAddChromeIntoForm.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbAddChromeIntoForm.Location = new System.Drawing.Point(37, 120);
		ckbAddChromeIntoForm.Name = "ckbAddChromeIntoForm";
		ckbAddChromeIntoForm.Size = new System.Drawing.Size(187, 20);
		ckbAddChromeIntoForm.TabIndex = 157;
		ckbAddChromeIntoForm.Text = "Add Chrome vào Form View";
		ckbAddChromeIntoForm.UseVisualStyleBackColor = true;
		ckbAddChromeIntoForm.CheckedChanged += new System.EventHandler(ckbAddChromeIntoForm_CheckedChanged);
		ckbLoginHotmail.AutoSize = true;
		ckbLoginHotmail.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLoginHotmail.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbLoginHotmail.Location = new System.Drawing.Point(37, 229);
		ckbLoginHotmail.Name = "ckbLoginHotmail";
		ckbLoginHotmail.Size = new System.Drawing.Size(184, 20);
		ckbLoginHotmail.TabIndex = 25;
		ckbLoginHotmail.Text = "Tự động đăng nhập hotmail";
		ckbLoginHotmail.UseVisualStyleBackColor = true;
		txtLink.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		txtLink.Location = new System.Drawing.Point(183, 201);
		txtLink.Name = "txtLink";
		txtLink.Size = new System.Drawing.Size(233, 23);
		txtLink.TabIndex = 24;
		txtLink.TextChanged += new System.EventHandler(DCA5C708);
		BC951101.Cursor = System.Windows.Forms.Cursors.Hand;
		BC951101.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		BC951101.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BC951101.Location = new System.Drawing.Point(157, 60);
		BC951101.Name = "btnCauHinh";
		BC951101.Size = new System.Drawing.Size(75, 25);
		BC951101.TabIndex = 5;
		BC951101.Text = "Cấu hình";
		BC951101.Click += new System.EventHandler(BC951101_Click);
		A13F98AA.AutoSize = true;
		A13F98AA.Cursor = System.Windows.Forms.Cursors.Hand;
		A13F98AA.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A13F98AA.Location = new System.Drawing.Point(37, 203);
		A13F98AA.Name = "ckbAutoOpenLink";
		A13F98AA.Size = new System.Drawing.Size(149, 20);
		A13F98AA.TabIndex = 21;
		A13F98AA.Text = "Tự động mở website:";
		A13F98AA.UseVisualStyleBackColor = true;
		A13F98AA.CheckedChanged += new System.EventHandler(D83FC889);
		DD3EA98D.AutoSize = true;
		DD3EA98D.Cursor = System.Windows.Forms.Cursors.Hand;
		DD3EA98D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		DD3EA98D.Location = new System.Drawing.Point(37, 177);
		DD3EA98D.Name = "ckbAutoCloseChromeLoginFail";
		DD3EA98D.Size = new System.Drawing.Size(326, 20);
		DD3EA98D.TabIndex = 21;
		DD3EA98D.Text = "Tự động đóng những tab chrome đăng nhập thất bại";
		DD3EA98D.UseVisualStyleBackColor = true;
		B10D1987.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		B10D1987.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		B10D1987.Cursor = System.Windows.Forms.Cursors.Hand;
		B10D1987.FlatAppearance.BorderSize = 0;
		B10D1987.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B10D1987.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B10D1987.ForeColor = System.Drawing.Color.White;
		B10D1987.Location = new System.Drawing.Point(125, 258);
		B10D1987.Name = "btnSave";
		B10D1987.Size = new System.Drawing.Size(92, 29);
		B10D1987.TabIndex = 20;
		B10D1987.Text = "Lưu";
		B10D1987.UseVisualStyleBackColor = false;
		B10D1987.Click += new System.EventHandler(E9A419BD);
		panel3.Controls.Add(rbSuDungProfile);
		panel3.Controls.Add(rbKhongDungProfile);
		panel3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		panel3.Location = new System.Drawing.Point(157, 88);
		panel3.Name = "panel3";
		panel3.Size = new System.Drawing.Size(273, 26);
		panel3.TabIndex = 8;
		rbSuDungProfile.AutoSize = true;
		rbSuDungProfile.Checked = true;
		rbSuDungProfile.Cursor = System.Windows.Forms.Cursors.Hand;
		rbSuDungProfile.Location = new System.Drawing.Point(3, 3);
		rbSuDungProfile.Name = "rbSuDungProfile";
		rbSuDungProfile.Size = new System.Drawing.Size(113, 20);
		rbSuDungProfile.TabIndex = 4;
		rbSuDungProfile.TabStop = true;
		rbSuDungProfile.Text = "Sử dụng Profile";
		rbSuDungProfile.UseVisualStyleBackColor = true;
		rbKhongDungProfile.AutoSize = true;
		rbKhongDungProfile.Cursor = System.Windows.Forms.Cursors.Hand;
		rbKhongDungProfile.Location = new System.Drawing.Point(127, 3);
		rbKhongDungProfile.Name = "rbKhongDungProfile";
		rbKhongDungProfile.Size = new System.Drawing.Size(132, 20);
		rbKhongDungProfile.TabIndex = 4;
		rbKhongDungProfile.Text = "Không dùng Profile";
		rbKhongDungProfile.UseVisualStyleBackColor = true;
		label3.AutoSize = true;
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(34, 64);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(98, 16);
		label3.TabIndex = 7;
		label3.Text = "Cấu hình đổi IP:";
		EEA78230.AutoSize = true;
		EEA78230.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EEA78230.Location = new System.Drawing.Point(34, 93);
		EEA78230.Name = "label1";
		EEA78230.Size = new System.Drawing.Size(104, 16);
		EEA78230.TabIndex = 7;
		EEA78230.Text = "Tùy chọn Profile:";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(453, 300);
		base.Controls.Add(C798C73F);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fMoTrinhDuyet";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(fMoTrinhDuyet_Load);
		C798C73F.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		A11393BA.ResumeLayout(false);
		A11393BA.PerformLayout();
		A32C7F3B.ResumeLayout(false);
		A32C7F3B.PerformLayout();
		((System.ComponentModel.ISupportInitialize)BA29FBBD).EndInit();
		((System.ComponentModel.ISupportInitialize)nudHeighChrome).EndInit();
		panel3.ResumeLayout(false);
		panel3.PerformLayout();
		ResumeLayout(false);
	}
}
