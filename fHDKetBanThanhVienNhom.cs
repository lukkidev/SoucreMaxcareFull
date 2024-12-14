using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDKetBanThanhVienNhom : Form
{
	private GClass11 A6910B1B;

	private string B50B6A15;

	private string string_0;

	private string CE059D0E;

	private int BE30CA94;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl ABB78481;

	private BunifuDragControl A5A0B804;

	private Panel panel1;

	private NumericUpDown E61F3714;

	private NumericUpDown nudSoLuongFrom;

	private TextBox D22E1725;

	private Label label2;

	private Label label1;

	private Button A735F21D;

	private Button DB037582;

	private BunifuCards BABB6FB1;

	private Panel pnlHeader;

	private Button B903FCBA;

	private PictureBox BA30EA9D;

	private BunifuCustomLabel ACAD590F;

	private Label C31B168F;

	private NumericUpDown C402B795;

	private NumericUpDown nudDelayFrom;

	private RichTextBox ECB2E1A5;

	private ToolTip FB9A0DAA;

	private Label label7;

	private Label label3;

	private Label label5;

	private ComboBox cbbFacebookWeb;

	private Label label4;

	private CheckBox ckbChiKetBanTenCoDau;

	public fHDKetBanThanhVienNhom(string B8B9EE28, int int_0 = 0, string A1AFF88C = "")
	{
		InitializeComponent();
		bool_0 = false;
		B50B6A15 = B8B9EE28;
		CE059D0E = A1AFF88C;
		BE30CA94 = int_0;
		string text = base.Name.Substring(1);
		string text2 = "Kết bạn thành viên nhóm";
		if (Class147.smethod_7("", text).Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string string_ = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			string_ = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			D22E1725.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(A1AFF88C);
			string_ = dataTable.Rows[0]["CauHinh"].ToString();
			DB037582.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			D22E1725.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		A6910B1B = new GClass11(string_, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void CA80B339(object sender, EventArgs e)
	{
		method_0();
		try
		{
			nudSoLuongFrom.Value = A6910B1B.method_2("nudSoLuongFrom", 1);
			E61F3714.Value = A6910B1B.method_2("nudSoLuongTo", 3);
			nudDelayFrom.Value = A6910B1B.method_2("nudDelayFrom", 3);
			C402B795.Value = A6910B1B.method_2("nudDelayTo", 5);
			ckbChiKetBanTenCoDau.Checked = A6910B1B.method_3("ckbChiKetBanTenCoDau");
			ECB2E1A5.Text = A6910B1B.C0288288("txtUid");
			cbbFacebookWeb.SelectedValue = A6910B1B.C0288288("cbbFacebookWeb", "2");
		}
		catch
		{
		}
	}

	private void method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("2", "https://m.facebook.com/");
		dictionary.Add("1", "https://www.facebook.com/");
		GClass8.smethod_23(cbbFacebookWeb, dictionary);
	}

	private void B903FCBA_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DB037582_Click(object sender, EventArgs e)
	{
		string text = D22E1725.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> e03C713E = ECB2E1A5.Lines.ToList();
		e03C713E = GClass8.smethod_36(e03C713E);
		if (e03C713E.Count == 0)
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sách uid nhóm!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_4("nudSoLuongTo", E61F3714.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", C402B795.Value);
		gClass.method_4("ckbChiKetBanTenCoDau", ckbChiKetBanTenCoDau.Checked);
		gClass.method_4("txtUid", ECB2E1A5.Text.Trim());
		gClass.method_4("cbbFacebookWeb", cbbFacebookWeb.SelectedValue);
		string text2 = gClass.method_7();
		if (BE30CA94 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(B50B6A15, text, string_0, text2))
				{
					bool_0 = true;
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
			if (Class147.smethod_13(CE059D0E, text, text2))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void A735F21D_Click(object sender, EventArgs e)
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

	private void ECB2E1A5_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(ECB2E1A5, C31B168F);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDKetBanThanhVienNhom));
		ABB78481 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		ACAD590F = new Bunifu.Framework.UI.BunifuCustomLabel();
		A5A0B804 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		B903FCBA = new System.Windows.Forms.Button();
		BA30EA9D = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		label5 = new System.Windows.Forms.Label();
		label7 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		ECB2E1A5 = new System.Windows.Forms.RichTextBox();
		C402B795 = new System.Windows.Forms.NumericUpDown();
		C31B168F = new System.Windows.Forms.Label();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		E61F3714 = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		D22E1725 = new System.Windows.Forms.TextBox();
		label2 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		A735F21D = new System.Windows.Forms.Button();
		DB037582 = new System.Windows.Forms.Button();
		BABB6FB1 = new Bunifu.Framework.UI.BunifuCards();
		FB9A0DAA = new System.Windows.Forms.ToolTip(icontainer_0);
		cbbFacebookWeb = new System.Windows.Forms.ComboBox();
		label4 = new System.Windows.Forms.Label();
		ckbChiKetBanTenCoDau = new System.Windows.Forms.CheckBox();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)BA30EA9D).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C402B795).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)E61F3714).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		BABB6FB1.SuspendLayout();
		SuspendLayout();
		ABB78481.Fixed = true;
		ABB78481.Horizontal = true;
		ABB78481.TargetControl = ACAD590F;
		ABB78481.Vertical = true;
		ACAD590F.BackColor = System.Drawing.Color.Transparent;
		ACAD590F.Cursor = System.Windows.Forms.Cursors.SizeAll;
		ACAD590F.Dock = System.Windows.Forms.DockStyle.Fill;
		ACAD590F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		ACAD590F.ForeColor = System.Drawing.Color.Black;
		ACAD590F.Location = new System.Drawing.Point(0, 0);
		ACAD590F.Name = "bunifuCustomLabel1";
		ACAD590F.Size = new System.Drawing.Size(353, 31);
		ACAD590F.TabIndex = 12;
		ACAD590F.Text = "Cấu hình Kết bạn thành viên nhóm";
		ACAD590F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		A5A0B804.Fixed = true;
		A5A0B804.Horizontal = true;
		A5A0B804.TargetControl = pnlHeader;
		A5A0B804.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(B903FCBA);
		pnlHeader.Controls.Add(BA30EA9D);
		pnlHeader.Controls.Add(ACAD590F);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(353, 31);
		pnlHeader.TabIndex = 9;
		B903FCBA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		B903FCBA.Cursor = System.Windows.Forms.Cursors.Hand;
		B903FCBA.FlatAppearance.BorderSize = 0;
		B903FCBA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B903FCBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B903FCBA.ForeColor = System.Drawing.Color.White;
		B903FCBA.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		B903FCBA.Location = new System.Drawing.Point(322, 1);
		B903FCBA.Name = "button1";
		B903FCBA.Size = new System.Drawing.Size(30, 30);
		B903FCBA.TabIndex = 77;
		B903FCBA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		B903FCBA.UseVisualStyleBackColor = true;
		B903FCBA.Click += new System.EventHandler(B903FCBA_Click);
		BA30EA9D.Cursor = System.Windows.Forms.Cursors.Default;
		BA30EA9D.Image = C50FB39E.Bitmap_5;
		BA30EA9D.Location = new System.Drawing.Point(3, 2);
		BA30EA9D.Name = "pictureBox1";
		BA30EA9D.Size = new System.Drawing.Size(34, 27);
		BA30EA9D.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		BA30EA9D.TabIndex = 76;
		BA30EA9D.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(ckbChiKetBanTenCoDau);
		panel1.Controls.Add(cbbFacebookWeb);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(ECB2E1A5);
		panel1.Controls.Add(C402B795);
		panel1.Controls.Add(C31B168F);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(E61F3714);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(D22E1725);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(A735F21D);
		panel1.Controls.Add(DB037582);
		panel1.Controls.Add(BABB6FB1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(356, 404);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 109);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(87, 16);
		label5.TabIndex = 118;
		label5.Text = "Gia\u0303n ca\u0301ch (s):";
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label7.Location = new System.Drawing.Point(194, 109);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 117;
		label7.Text = ">";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(194, 80);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 116;
		label3.Text = ">";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		ECB2E1A5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		ECB2E1A5.Location = new System.Drawing.Point(31, 156);
		ECB2E1A5.Name = "txtUid";
		ECB2E1A5.Size = new System.Drawing.Size(295, 136);
		ECB2E1A5.TabIndex = 114;
		ECB2E1A5.Text = "";
		ECB2E1A5.WordWrap = false;
		ECB2E1A5.TextChanged += new System.EventHandler(ECB2E1A5_TextChanged);
		C402B795.Location = new System.Drawing.Point(229, 107);
		C402B795.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C402B795.Name = "nudDelayTo";
		C402B795.Size = new System.Drawing.Size(56, 23);
		C402B795.TabIndex = 4;
		C31B168F.AutoSize = true;
		C31B168F.Location = new System.Drawing.Point(27, 137);
		C31B168F.Name = "lblStatus";
		C31B168F.Size = new System.Drawing.Size(143, 16);
		C31B168F.TabIndex = 0;
		C31B168F.Text = "Danh sa\u0301ch Id nhóm (0):";
		nudDelayFrom.Location = new System.Drawing.Point(132, 107);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		E61F3714.Location = new System.Drawing.Point(229, 78);
		E61F3714.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E61F3714.Name = "nudSoLuongTo";
		E61F3714.Size = new System.Drawing.Size(56, 23);
		E61F3714.TabIndex = 2;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 78);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		D22E1725.Location = new System.Drawing.Point(132, 49);
		D22E1725.Name = "txtTenHanhDong";
		D22E1725.Size = new System.Drawing.Size(194, 23);
		D22E1725.TabIndex = 0;
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 80);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(88, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		A735F21D.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		A735F21D.BackColor = System.Drawing.Color.Maroon;
		A735F21D.Cursor = System.Windows.Forms.Cursors.Hand;
		A735F21D.FlatAppearance.BorderSize = 0;
		A735F21D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A735F21D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A735F21D.ForeColor = System.Drawing.Color.White;
		A735F21D.Location = new System.Drawing.Point(190, 362);
		A735F21D.Name = "btnCancel";
		A735F21D.Size = new System.Drawing.Size(92, 29);
		A735F21D.TabIndex = 7;
		A735F21D.Text = "Đóng";
		A735F21D.UseVisualStyleBackColor = false;
		A735F21D.Click += new System.EventHandler(A735F21D_Click);
		DB037582.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		DB037582.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		DB037582.Cursor = System.Windows.Forms.Cursors.Hand;
		DB037582.FlatAppearance.BorderSize = 0;
		DB037582.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		DB037582.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DB037582.ForeColor = System.Drawing.Color.White;
		DB037582.Location = new System.Drawing.Point(83, 362);
		DB037582.Name = "btnAdd";
		DB037582.Size = new System.Drawing.Size(92, 29);
		DB037582.TabIndex = 6;
		DB037582.Text = "Thêm";
		DB037582.UseVisualStyleBackColor = false;
		DB037582.Click += new System.EventHandler(DB037582_Click);
		BABB6FB1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		BABB6FB1.BackColor = System.Drawing.Color.White;
		BABB6FB1.BorderRadius = 0;
		BABB6FB1.BottomSahddow = true;
		BABB6FB1.color = System.Drawing.Color.DarkViolet;
		BABB6FB1.Controls.Add(pnlHeader);
		BABB6FB1.LeftSahddow = false;
		BABB6FB1.Location = new System.Drawing.Point(1, 0);
		BABB6FB1.Name = "bunifuCards1";
		BABB6FB1.RightSahddow = true;
		BABB6FB1.ShadowDepth = 20;
		BABB6FB1.Size = new System.Drawing.Size(353, 37);
		BABB6FB1.TabIndex = 28;
		FB9A0DAA.AutomaticDelay = 0;
		FB9A0DAA.AutoPopDelay = 0;
		FB9A0DAA.InitialDelay = 0;
		FB9A0DAA.ReshowDelay = 0;
		FB9A0DAA.ShowAlways = true;
		cbbFacebookWeb.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbFacebookWeb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbFacebookWeb.DropDownWidth = 120;
		cbbFacebookWeb.FormattingEnabled = true;
		cbbFacebookWeb.Location = new System.Drawing.Point(132, 324);
		cbbFacebookWeb.Name = "cbbFacebookWeb";
		cbbFacebookWeb.Size = new System.Drawing.Size(194, 24);
		cbbFacebookWeb.TabIndex = 120;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(27, 327);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(96, 16);
		label4.TabIndex = 119;
		label4.Text = "Facebook Web:";
		ckbChiKetBanTenCoDau.AutoSize = true;
		ckbChiKetBanTenCoDau.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbChiKetBanTenCoDau.Location = new System.Drawing.Point(31, 297);
		ckbChiKetBanTenCoDau.Name = "ckbChiKetBanTenCoDau";
		ckbChiKetBanTenCoDau.Size = new System.Drawing.Size(211, 20);
		ckbChiKetBanTenCoDau.TabIndex = 121;
		ckbChiKetBanTenCoDau.Text = "Chỉ kết bạn với người có tên Việt";
		ckbChiKetBanTenCoDau.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(356, 404);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanThanhVienNhom";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(CA80B339);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)BA30EA9D).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)C402B795).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)E61F3714).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		BABB6FB1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
