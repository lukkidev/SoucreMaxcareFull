using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTuongTacBaiVietTuKhoa : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string DD34943C;

	private string string_1;

	private int int_0;

	public static bool F70E8C2A;

	private EFBBE9AB AD90BD0B;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl E0318538;

	private Panel panel1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards B8B38C2D;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox CE055198;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown D986A230;

	private NumericUpDown A984B72E;

	private TextBox B788EB37;

	private Label label7;

	private Label label5;

	private Label label1;

	private Panel plTuongTacBaiViet;

	private Panel F8391934;

	private TabControl tabOptionsPost;

	private TabPage tabPage1;

	private Label label2;

	private Label label3;

	private NumericUpDown nudSoLuongFrom;

	private NumericUpDown F8333386;

	private TabPage tabPage2;

	private Label A8B88B11;

	private Label label9;

	private NumericUpDown D9A4A4BF;

	private NumericUpDown DD33718A;

	private ComboBox B0087694;

	private Label A70F2897;

	private RichTextBox txtTuKhoa;

	private Label B31A2213;

	private CheckBox ckbPostAds;

	public fHDTuongTacBaiVietTuKhoa(string string_2, int int_1 = 0, string C611EEA2 = "")
	{
		InitializeComponent();
		F70E8C2A = false;
		string_0 = string_2;
		string_1 = C611EEA2;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Tương tác bài viết từ khóa";
		Class147.smethod_8(text, text2);
		string text3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDTuongTacBaiVietTuKhoa");
			DD34943C = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			B788EB37.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(C611EEA2);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			B788EB37.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void A63E3A1D(object sender, EventArgs e)
	{
		method_0();
		try
		{
			B0087694.SelectedIndex = gclass11_0.method_2("cbbOptionsPost");
			nudSoLuongFrom.Value = gclass11_0.method_2("nudSoLuongFrom", 1);
			F8333386.Value = gclass11_0.method_2("nudSoLuongTo", 2);
			D9A4A4BF.Value = gclass11_0.method_2("nudThoiGianFrom", 30);
			DD33718A.Value = gclass11_0.method_2("nudThoiGianTo", 30);
			A984B72E.Value = gclass11_0.method_2("nudDelayFrom", 3);
			D986A230.Value = gclass11_0.method_2("nudDelayTo", 5);
			txtTuKhoa.Text = gclass11_0.C0288288("txtTuKhoa");
			ckbPostAds.Checked = gclass11_0.method_3("ckbPostAds");
			AD90BD0B = new EFBBE9AB(gclass11_0);
			plTuongTacBaiViet.Controls.Add(AD90BD0B);
		}
		catch
		{
		}
	}

	private void method_0()
	{
		List<string> list_ = new List<string> { "Giơ\u0301i ha\u0323n sô\u0301 ba\u0300i viê\u0301t tương ta\u0301c", "Giơ\u0301i ha\u0323n thơ\u0300i gian tương ta\u0301c" };
		GClass8.smethod_22(B0087694, list_);
	}

	private void BCBD850B(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = B788EB37.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = AD90BD0B.F0B0B700();
		gClass.method_4("cbbOptionsPost", B0087694.SelectedIndex);
		gClass.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_4("nudSoLuongTo", F8333386.Value);
		gClass.method_4("nudThoiGianFrom", D9A4A4BF.Value);
		gClass.method_4("nudThoiGianTo", DD33718A.Value);
		gClass.method_4("nudDelayFrom", A984B72E.Value);
		gClass.method_4("nudDelayTo", D986A230.Value);
		gClass.method_4("txtTuKhoa", txtTuKhoa.Text);
		gClass.method_4("ckbPostAds", ckbPostAds.Checked);
		string string_ = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, DD34943C, string_))
				{
					F70E8C2A = true;
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
				F70E8C2A = true;
				Close();
			}
			else
			{
				GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void E5BA75B8(object sender, EventArgs e)
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

	private void CE055198_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
		}
	}

	private void B0087694_SelectedIndexChanged(object sender, EventArgs e)
	{
		tabOptionsPost.SelectedIndex = B0087694.SelectedIndex;
	}

	private void CDBEB1BD(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtTuKhoa, B31A2213);
	}

	protected override void Dispose(bool F4986B36)
	{
		if (F4986B36 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(F4986B36);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTuongTacBaiVietTuKhoa));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		E0318538 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		CE055198 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		ckbPostAds = new System.Windows.Forms.CheckBox();
		txtTuKhoa = new System.Windows.Forms.RichTextBox();
		B31A2213 = new System.Windows.Forms.Label();
		F8391934 = new System.Windows.Forms.Panel();
		tabOptionsPost = new System.Windows.Forms.TabControl();
		tabPage1 = new System.Windows.Forms.TabPage();
		label2 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		F8333386 = new System.Windows.Forms.NumericUpDown();
		tabPage2 = new System.Windows.Forms.TabPage();
		A8B88B11 = new System.Windows.Forms.Label();
		label9 = new System.Windows.Forms.Label();
		D9A4A4BF = new System.Windows.Forms.NumericUpDown();
		DD33718A = new System.Windows.Forms.NumericUpDown();
		plTuongTacBaiViet = new System.Windows.Forms.Panel();
		B0087694 = new System.Windows.Forms.ComboBox();
		A70F2897 = new System.Windows.Forms.Label();
		D986A230 = new System.Windows.Forms.NumericUpDown();
		A984B72E = new System.Windows.Forms.NumericUpDown();
		B788EB37 = new System.Windows.Forms.TextBox();
		label7 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		B8B38C2D = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)CE055198).BeginInit();
		panel1.SuspendLayout();
		F8391934.SuspendLayout();
		tabOptionsPost.SuspendLayout();
		tabPage1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)F8333386).BeginInit();
		tabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)D9A4A4BF).BeginInit();
		((System.ComponentModel.ISupportInitialize)DD33718A).BeginInit();
		((System.ComponentModel.ISupportInitialize)D986A230).BeginInit();
		((System.ComponentModel.ISupportInitialize)A984B72E).BeginInit();
		B8B38C2D.SuspendLayout();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(717, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Tương tác bài viết từ khóa";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		E0318538.Fixed = true;
		E0318538.Horizontal = true;
		E0318538.TargetControl = pnlHeader;
		E0318538.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(CE055198);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(717, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(686, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(BCBD850B);
		CE055198.Cursor = System.Windows.Forms.Cursors.Default;
		CE055198.Image = C50FB39E.Bitmap_5;
		CE055198.Location = new System.Drawing.Point(3, 2);
		CE055198.Name = "pictureBox1";
		CE055198.Size = new System.Drawing.Size(34, 27);
		CE055198.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		CE055198.TabIndex = 76;
		CE055198.TabStop = false;
		CE055198.Click += new System.EventHandler(CE055198_Click);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(ckbPostAds);
		panel1.Controls.Add(txtTuKhoa);
		panel1.Controls.Add(B31A2213);
		panel1.Controls.Add(F8391934);
		panel1.Controls.Add(plTuongTacBaiViet);
		panel1.Controls.Add(B0087694);
		panel1.Controls.Add(A70F2897);
		panel1.Controls.Add(D986A230);
		panel1.Controls.Add(A984B72E);
		panel1.Controls.Add(B788EB37);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(B8B38C2D);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(720, 493);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		ckbPostAds.AutoSize = true;
		ckbPostAds.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbPostAds.Location = new System.Drawing.Point(619, 54);
		ckbPostAds.Name = "ckbPostAds";
		ckbPostAds.Size = new System.Drawing.Size(75, 20);
		ckbPostAds.TabIndex = 207;
		ckbPostAds.Text = "Post Ads";
		ckbPostAds.UseVisualStyleBackColor = true;
		ckbPostAds.Visible = false;
		txtTuKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtTuKhoa.Location = new System.Drawing.Point(380, 75);
		txtTuKhoa.Name = "txtTuKhoa";
		txtTuKhoa.Size = new System.Drawing.Size(309, 88);
		txtTuKhoa.TabIndex = 205;
		txtTuKhoa.Text = "";
		txtTuKhoa.WordWrap = false;
		txtTuKhoa.TextChanged += new System.EventHandler(CDBEB1BD);
		B31A2213.AutoSize = true;
		B31A2213.Location = new System.Drawing.Point(377, 55);
		B31A2213.Name = "lblTuKhoa";
		B31A2213.Size = new System.Drawing.Size(171, 16);
		B31A2213.TabIndex = 206;
		B31A2213.Text = "Nhâ\u0323p danh sa\u0301ch từ khóa (0):";
		F8391934.Controls.Add(tabOptionsPost);
		F8391934.Location = new System.Drawing.Point(30, 111);
		F8391934.Name = "panel2";
		F8391934.Size = new System.Drawing.Size(266, 23);
		F8391934.TabIndex = 202;
		tabOptionsPost.Alignment = System.Windows.Forms.TabAlignment.Bottom;
		tabOptionsPost.Controls.Add(tabPage1);
		tabOptionsPost.Controls.Add(tabPage2);
		tabOptionsPost.Location = new System.Drawing.Point(-5, -5);
		tabOptionsPost.Name = "tabOptionsPost";
		tabOptionsPost.SelectedIndex = 0;
		tabOptionsPost.Size = new System.Drawing.Size(276, 54);
		tabOptionsPost.TabIndex = 198;
		tabPage1.Controls.Add(label2);
		tabPage1.Controls.Add(label3);
		tabPage1.Controls.Add(nudSoLuongFrom);
		tabPage1.Controls.Add(F8333386);
		tabPage1.Location = new System.Drawing.Point(4, 4);
		tabPage1.Name = "tabPage1";
		tabPage1.Padding = new System.Windows.Forms.Padding(3);
		tabPage1.Size = new System.Drawing.Size(268, 25);
		tabPage1.TabIndex = 0;
		tabPage1.Text = "tabPage1";
		tabPage1.UseVisualStyleBackColor = true;
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(0, 3);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(84, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng ba\u0300i:";
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(174, 3);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 1;
		label3.Text = ">";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudSoLuongFrom.Location = new System.Drawing.Point(112, 1);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 0;
		F8333386.Location = new System.Drawing.Point(209, 1);
		F8333386.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F8333386.Name = "nudSoLuongTo";
		F8333386.Size = new System.Drawing.Size(56, 23);
		F8333386.TabIndex = 2;
		tabPage2.Controls.Add(A8B88B11);
		tabPage2.Controls.Add(label9);
		tabPage2.Controls.Add(D9A4A4BF);
		tabPage2.Controls.Add(DD33718A);
		tabPage2.Location = new System.Drawing.Point(4, 4);
		tabPage2.Name = "tabPage2";
		tabPage2.Padding = new System.Windows.Forms.Padding(3);
		tabPage2.Size = new System.Drawing.Size(268, 28);
		tabPage2.TabIndex = 1;
		tabPage2.Text = "tabPage2";
		tabPage2.UseVisualStyleBackColor = true;
		A8B88B11.AutoSize = true;
		A8B88B11.Location = new System.Drawing.Point(0, 3);
		A8B88B11.Name = "label8";
		A8B88B11.Size = new System.Drawing.Size(85, 16);
		A8B88B11.TabIndex = 40;
		A8B88B11.Text = "Thơ\u0300i gian (s):";
		label9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label9.Location = new System.Drawing.Point(174, 3);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(29, 16);
		label9.TabIndex = 41;
		label9.Text = ">";
		label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D9A4A4BF.Location = new System.Drawing.Point(112, 1);
		D9A4A4BF.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D9A4A4BF.Name = "nudThoiGianFrom";
		D9A4A4BF.Size = new System.Drawing.Size(56, 23);
		D9A4A4BF.TabIndex = 38;
		DD33718A.Location = new System.Drawing.Point(209, 1);
		DD33718A.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		DD33718A.Name = "nudThoiGianTo";
		DD33718A.Size = new System.Drawing.Size(56, 23);
		DD33718A.TabIndex = 39;
		plTuongTacBaiViet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plTuongTacBaiViet.Location = new System.Drawing.Point(32, 169);
		plTuongTacBaiViet.Name = "plTuongTacBaiViet";
		plTuongTacBaiViet.Size = new System.Drawing.Size(657, 266);
		plTuongTacBaiViet.TabIndex = 204;
		B0087694.Cursor = System.Windows.Forms.Cursors.Hand;
		B0087694.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		B0087694.DropDownWidth = 200;
		B0087694.FormattingEnabled = true;
		B0087694.Location = new System.Drawing.Point(141, 81);
		B0087694.Name = "cbbOptionsPost";
		B0087694.Size = new System.Drawing.Size(153, 24);
		B0087694.TabIndex = 200;
		B0087694.SelectedIndexChanged += new System.EventHandler(B0087694_SelectedIndexChanged);
		A70F2897.AutoSize = true;
		A70F2897.Location = new System.Drawing.Point(29, 84);
		A70F2897.Name = "label4";
		A70F2897.Size = new System.Drawing.Size(64, 16);
		A70F2897.TabIndex = 201;
		A70F2897.Text = "Tu\u0300y cho\u0323n:";
		D986A230.Location = new System.Drawing.Point(238, 140);
		D986A230.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D986A230.Name = "nudDelayTo";
		D986A230.Size = new System.Drawing.Size(56, 23);
		D986A230.TabIndex = 198;
		A984B72E.Location = new System.Drawing.Point(141, 140);
		A984B72E.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A984B72E.Name = "nudDelayFrom";
		A984B72E.Size = new System.Drawing.Size(56, 23);
		A984B72E.TabIndex = 197;
		B788EB37.Location = new System.Drawing.Point(141, 52);
		B788EB37.Name = "txtTenHanhDong";
		B788EB37.Size = new System.Drawing.Size(153, 23);
		B788EB37.TabIndex = 194;
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label7.Location = new System.Drawing.Point(203, 142);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 203;
		label7.Text = ">";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(29, 142);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(87, 16);
		label5.TabIndex = 201;
		label5.Text = "Gia\u0303n ca\u0301ch (s):";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(29, 55);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 199;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(368, 450);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(E5BA75B8);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(261, 450);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		B8B38C2D.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		B8B38C2D.BackColor = System.Drawing.Color.White;
		B8B38C2D.BorderRadius = 0;
		B8B38C2D.BottomSahddow = true;
		B8B38C2D.color = System.Drawing.Color.DarkViolet;
		B8B38C2D.Controls.Add(pnlHeader);
		B8B38C2D.LeftSahddow = false;
		B8B38C2D.Location = new System.Drawing.Point(1, 0);
		B8B38C2D.Name = "bunifuCards1";
		B8B38C2D.RightSahddow = true;
		B8B38C2D.ShadowDepth = 20;
		B8B38C2D.Size = new System.Drawing.Size(717, 37);
		B8B38C2D.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(720, 493);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacBaiVietTuKhoa";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(A63E3A1D);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)CE055198).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		F8391934.ResumeLayout(false);
		tabOptionsPost.ResumeLayout(false);
		tabPage1.ResumeLayout(false);
		tabPage1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)F8333386).EndInit();
		tabPage2.ResumeLayout(false);
		tabPage2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)D9A4A4BF).EndInit();
		((System.ComponentModel.ISupportInitialize)DD33718A).EndInit();
		((System.ComponentModel.ISupportInitialize)D986A230).EndInit();
		((System.ComponentModel.ISupportInitialize)A984B72E).EndInit();
		B8B38C2D.ResumeLayout(false);
		ResumeLayout(false);
	}
}
