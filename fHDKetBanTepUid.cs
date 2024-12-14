using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDKetBanTepUid : Form
{
	private F31742AD f31742AD_0;

	private GClass11 D7385196;

	private string string_0;

	private string string_1;

	private string C6904507;

	private int int_0;

	public static bool bool_0;

	private IContainer FC13FE0E = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel EE077F2C;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox E2B03DAE;

	private Label D1131B3E;

	private Label E5280AA6;

	private Label label1;

	private Button btnCancel;

	private Button D6A5EF14;

	private BunifuCards F114B585;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label AD3D1D82;

	private Label D19D8E2E;

	private ToolTip toolTip_0;

	private CheckBox ckbTuongTac;

	private NumericUpDown BE2137A3;

	private Label E2A47CA4;

	private Label label8;

	private CheckBox F22ED932;

	private LinkLabel F0908A0D;

	private Panel plUid;

	private Label lblUid;

	private CheckBox ckbTuDongXoaUid;

	private RichTextBox txtUid;

	private CheckBox DC15EB93;

	public fHDKetBanTepUid(string string_2, int int_1 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_2;
		C6904507 = string_3;
		int_0 = int_1;
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDKetBanTepUid");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			E2B03DAE.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			D6A5EF14.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			E2B03DAE.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		D7385196 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
		f31742AD_0 = new F31742AD(D7385196)
		{
			Visible = false
		};
		base.Controls.Add(f31742AD_0);
		f31742AD_0.smethod_0(bool_0: true);
	}

	private void fHDKetBanTepUid_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = D7385196.method_2("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = D7385196.method_2("nudSoLuongTo", 1);
			nudDelayFrom.Value = D7385196.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = D7385196.method_2("nudDelayTo", 5);
			ckbTuDongXoaUid.Checked = D7385196.method_3("ckbKetBanTrungNhau");
			txtUid.Text = D7385196.C0288288("txtUid");
			ckbTuongTac.Checked = D7385196.method_3("ckbTuongTac");
			ckbTuDongXoaUid.Checked = D7385196.method_3("ckbTuDongXoaUid");
			F22ED932.Checked = D7385196.method_3("ckbAddFriendApi");
			BE2137A3.Value = D7385196.method_2("nudTimesWarning", 1);
			DC15EB93.Checked = D7385196.method_2("cbbFacebookWeb") == 1;
		}
		catch
		{
		}
		FB12F418();
	}

	private void FB12F418()
	{
		E431A5BC(null, null);
		method_1(null, null);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A12F3E1C(object sender, EventArgs e)
	{
		string text = E2B03DAE.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> e03C713E = txtUid.Lines.ToList();
		e03C713E = GClass8.smethod_36(e03C713E);
		if (e03C713E.Count == 0)
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sách uid cần kết bạn!", 3);
			return;
		}
		D7385196.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		D7385196.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		D7385196.method_4("nudDelayFrom", nudDelayFrom.Value);
		D7385196.method_4("nudDelayTo", nudDelayTo.Value);
		D7385196.method_4("ckbKetBanTrungNhau", ckbTuDongXoaUid.Checked);
		D7385196.method_4("txtUid", txtUid.Text.Trim());
		D7385196.method_4("ckbTuongTac", ckbTuongTac.Checked);
		D7385196.method_4("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
		D7385196.method_4("ckbAddFriendApi", F22ED932.Checked);
		D7385196.method_4("nudTimesWarning", BE2137A3.Value);
		D7385196.method_4("cbbFacebookWeb", DC15EB93.Checked ? 1 : 0);
		string string_ = D7385196.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, string_))
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
			if (Class147.smethod_13(C6904507, text, string_))
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

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void BD81E938(object sender, PaintEventArgs e)
	{
		if (EE077F2C.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, EE077F2C.ClientSize.Width - num, EE077F2C.ClientSize.Height - num));
		}
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void txtUid_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtUid, lblUid);
	}

	private void E431A5BC(object sender, EventArgs e)
	{
		F0908A0D.Enabled = ckbTuongTac.Checked;
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void F0908A0D_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.BFBFBD05(f31742AD_0, this);
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && FC13FE0E != null)
		{
			FC13FE0E.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		FC13FE0E = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDKetBanTepUid));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(FC13FE0E);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(FC13FE0E);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		EE077F2C = new System.Windows.Forms.Panel();
		plUid = new System.Windows.Forms.Panel();
		lblUid = new System.Windows.Forms.Label();
		ckbTuDongXoaUid = new System.Windows.Forms.CheckBox();
		txtUid = new System.Windows.Forms.RichTextBox();
		F0908A0D = new System.Windows.Forms.LinkLabel();
		BE2137A3 = new System.Windows.Forms.NumericUpDown();
		E2A47CA4 = new System.Windows.Forms.Label();
		label8 = new System.Windows.Forms.Label();
		ckbTuongTac = new System.Windows.Forms.CheckBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		AD3D1D82 = new System.Windows.Forms.Label();
		D19D8E2E = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		E2B03DAE = new System.Windows.Forms.TextBox();
		D1131B3E = new System.Windows.Forms.Label();
		E5280AA6 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		D6A5EF14 = new System.Windows.Forms.Button();
		F114B585 = new Bunifu.Framework.UI.BunifuCards();
		DC15EB93 = new System.Windows.Forms.CheckBox();
		F22ED932 = new System.Windows.Forms.CheckBox();
		toolTip_0 = new System.Windows.Forms.ToolTip(FC13FE0E);
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		EE077F2C.SuspendLayout();
		plUid.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)BE2137A3).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		F114B585.SuspendLayout();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(569, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Kết bạn theo tệp UID";
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
		pnlHeader.Size = new System.Drawing.Size(569, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(538, 1);
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
		EE077F2C.BackColor = System.Drawing.Color.White;
		EE077F2C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		EE077F2C.Controls.Add(plUid);
		EE077F2C.Controls.Add(F0908A0D);
		EE077F2C.Controls.Add(BE2137A3);
		EE077F2C.Controls.Add(E2A47CA4);
		EE077F2C.Controls.Add(label8);
		EE077F2C.Controls.Add(ckbTuongTac);
		EE077F2C.Controls.Add(nudDelayTo);
		EE077F2C.Controls.Add(nudDelayFrom);
		EE077F2C.Controls.Add(AD3D1D82);
		EE077F2C.Controls.Add(D19D8E2E);
		EE077F2C.Controls.Add(nudSoLuongTo);
		EE077F2C.Controls.Add(nudSoLuongFrom);
		EE077F2C.Controls.Add(E2B03DAE);
		EE077F2C.Controls.Add(D1131B3E);
		EE077F2C.Controls.Add(E5280AA6);
		EE077F2C.Controls.Add(label1);
		EE077F2C.Controls.Add(btnCancel);
		EE077F2C.Controls.Add(D6A5EF14);
		EE077F2C.Controls.Add(F114B585);
		EE077F2C.Controls.Add(DC15EB93);
		EE077F2C.Controls.Add(F22ED932);
		EE077F2C.Cursor = System.Windows.Forms.Cursors.Arrow;
		EE077F2C.Dock = System.Windows.Forms.DockStyle.Fill;
		EE077F2C.Location = new System.Drawing.Point(0, 0);
		EE077F2C.Name = "panel1";
		EE077F2C.Size = new System.Drawing.Size(572, 495);
		EE077F2C.TabIndex = 0;
		EE077F2C.Paint += new System.Windows.Forms.PaintEventHandler(BD81E938);
		plUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plUid.Controls.Add(lblUid);
		plUid.Controls.Add(ckbTuDongXoaUid);
		plUid.Controls.Add(txtUid);
		plUid.Location = new System.Drawing.Point(28, 136);
		plUid.Name = "plUid";
		plUid.Size = new System.Drawing.Size(255, 305);
		plUid.TabIndex = 195;
		lblUid.AutoSize = true;
		lblUid.Location = new System.Drawing.Point(1, 4);
		lblUid.Name = "lblUid";
		lblUid.Size = new System.Drawing.Size(114, 16);
		lblUid.TabIndex = 0;
		lblUid.Text = "Danh sa\u0301ch Uid (0):";
		ckbTuDongXoaUid.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		ckbTuDongXoaUid.AutoSize = true;
		ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuDongXoaUid.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		ckbTuDongXoaUid.Location = new System.Drawing.Point(5, 280);
		ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		ckbTuDongXoaUid.Size = new System.Drawing.Size(170, 20);
		ckbTuDongXoaUid.TabIndex = 113;
		ckbTuDongXoaUid.Text = "Tư\u0323 đô\u0323ng xo\u0301a Uid đa\u0303 dùng";
		ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		txtUid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtUid.Location = new System.Drawing.Point(5, 23);
		txtUid.Name = "txtUid";
		txtUid.Size = new System.Drawing.Size(243, 255);
		txtUid.TabIndex = 114;
		txtUid.Text = "";
		txtUid.WordWrap = false;
		txtUid.TextChanged += new System.EventHandler(txtUid_TextChanged);
		F0908A0D.AutoSize = true;
		F0908A0D.Cursor = System.Windows.Forms.Cursors.Hand;
		F0908A0D.Location = new System.Drawing.Point(500, 133);
		F0908A0D.Name = "lblCaiDat";
		F0908A0D.Size = new System.Drawing.Size(47, 16);
		F0908A0D.TabIndex = 194;
		F0908A0D.TabStop = true;
		F0908A0D.Text = "Cài đặt";
		F0908A0D.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(F0908A0D_LinkClicked);
		BE2137A3.Location = new System.Drawing.Point(456, 153);
		BE2137A3.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		BE2137A3.Name = "nudTimesWarning";
		BE2137A3.Size = new System.Drawing.Size(43, 23);
		BE2137A3.TabIndex = 117;
		E2A47CA4.AutoSize = true;
		E2A47CA4.Location = new System.Drawing.Point(502, 155);
		E2A47CA4.Name = "label9";
		E2A47CA4.Size = new System.Drawing.Size(24, 16);
		E2A47CA4.TabIndex = 119;
		E2A47CA4.Text = "lần";
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(314, 155);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(136, 16);
		label8.TabIndex = 118;
		label8.Text = "Dừng khi Fb cảnh báo:";
		ckbTuongTac.AutoSize = true;
		ckbTuongTac.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuongTac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		ckbTuongTac.Location = new System.Drawing.Point(317, 132);
		ckbTuongTac.Name = "ckbTuongTac";
		ckbTuongTac.Size = new System.Drawing.Size(184, 20);
		ckbTuongTac.TabIndex = 115;
		ckbTuongTac.Text = "Tương tác trước khi kết bạn";
		ckbTuongTac.UseVisualStyleBackColor = true;
		ckbTuongTac.CheckedChanged += new System.EventHandler(E431A5BC);
		nudDelayTo.Location = new System.Drawing.Point(227, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(130, 107);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		AD3D1D82.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		AD3D1D82.Location = new System.Drawing.Point(192, 109);
		AD3D1D82.Name = "label7";
		AD3D1D82.Size = new System.Drawing.Size(29, 16);
		AD3D1D82.TabIndex = 46;
		AD3D1D82.Text = ">";
		AD3D1D82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D19D8E2E.AutoSize = true;
		D19D8E2E.Location = new System.Drawing.Point(25, 109);
		D19D8E2E.Name = "label5";
		D19D8E2E.Size = new System.Drawing.Size(87, 16);
		D19D8E2E.TabIndex = 44;
		D19D8E2E.Text = "Gia\u0303n ca\u0301ch (s):";
		nudSoLuongTo.Location = new System.Drawing.Point(227, 78);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudSoLuongFrom.Location = new System.Drawing.Point(130, 78);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		E2B03DAE.Location = new System.Drawing.Point(130, 49);
		E2B03DAE.Name = "txtTenHanhDong";
		E2B03DAE.Size = new System.Drawing.Size(153, 23);
		E2B03DAE.TabIndex = 0;
		D1131B3E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D1131B3E.Location = new System.Drawing.Point(192, 80);
		D1131B3E.Name = "label3";
		D1131B3E.Size = new System.Drawing.Size(29, 16);
		D1131B3E.TabIndex = 37;
		D1131B3E.Text = ">";
		D1131B3E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		E5280AA6.AutoSize = true;
		E5280AA6.Location = new System.Drawing.Point(25, 80);
		E5280AA6.Name = "label2";
		E5280AA6.Size = new System.Drawing.Size(88, 16);
		E5280AA6.TabIndex = 32;
		E5280AA6.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(25, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(292, 453);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		D6A5EF14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		D6A5EF14.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		D6A5EF14.Cursor = System.Windows.Forms.Cursors.Hand;
		D6A5EF14.FlatAppearance.BorderSize = 0;
		D6A5EF14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D6A5EF14.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D6A5EF14.ForeColor = System.Drawing.Color.White;
		D6A5EF14.Location = new System.Drawing.Point(185, 453);
		D6A5EF14.Name = "btnAdd";
		D6A5EF14.Size = new System.Drawing.Size(92, 29);
		D6A5EF14.TabIndex = 6;
		D6A5EF14.Text = "Thêm";
		D6A5EF14.UseVisualStyleBackColor = false;
		D6A5EF14.Click += new System.EventHandler(A12F3E1C);
		F114B585.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		F114B585.BackColor = System.Drawing.Color.White;
		F114B585.BorderRadius = 0;
		F114B585.BottomSahddow = true;
		F114B585.color = System.Drawing.Color.DarkViolet;
		F114B585.Controls.Add(pnlHeader);
		F114B585.LeftSahddow = false;
		F114B585.Location = new System.Drawing.Point(1, 0);
		F114B585.Name = "bunifuCards1";
		F114B585.RightSahddow = true;
		F114B585.ShadowDepth = 20;
		F114B585.Size = new System.Drawing.Size(569, 37);
		F114B585.TabIndex = 28;
		DC15EB93.AutoSize = true;
		DC15EB93.Cursor = System.Windows.Forms.Cursors.Hand;
		DC15EB93.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		DC15EB93.Location = new System.Drawing.Point(317, 179);
		DC15EB93.Name = "ckbUuTienWWW";
		DC15EB93.Size = new System.Drawing.Size(163, 20);
		DC15EB93.TabIndex = 113;
		DC15EB93.Text = "Ưu tiên chạy bằng www";
		DC15EB93.UseVisualStyleBackColor = true;
		F22ED932.AutoSize = true;
		F22ED932.Cursor = System.Windows.Forms.Cursors.Hand;
		F22ED932.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		F22ED932.Location = new System.Drawing.Point(317, 205);
		F22ED932.Name = "ckbAddFriendApi";
		F22ED932.Size = new System.Drawing.Size(99, 20);
		F22ED932.TabIndex = 113;
		F22ED932.Text = "Run API (ẩn)";
		F22ED932.UseVisualStyleBackColor = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 0;
		toolTip_0.InitialDelay = 0;
		toolTip_0.ReshowDelay = 0;
		toolTip_0.ShowAlways = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(572, 495);
		base.Controls.Add(EE077F2C);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanTepUid";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDKetBanTepUid_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		EE077F2C.ResumeLayout(false);
		EE077F2C.PerformLayout();
		plUid.ResumeLayout(false);
		plUid.PerformLayout();
		((System.ComponentModel.ISupportInitialize)BE2137A3).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		F114B585.ResumeLayout(false);
		ResumeLayout(false);
	}
}
