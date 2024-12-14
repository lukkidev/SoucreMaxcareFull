using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTuongTacNhomv2 : Form
{
	private GClass11 gclass11_0;

	private string AEA66D2E;

	private string CA2C452A;

	private string string_0;

	private int int_0;

	public static bool bool_0;

	private EFBBE9AB B71FFC07;

	private IContainer BF999D1C = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel D58E312A;

	private Button D52D4B97;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel C1896F00;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown C9B35CB0;

	private NumericUpDown nudDelayFrom;

	private TextBox txtTenHanhDong;

	private Label F9B52EA0;

	private Label label5;

	private Label A32CF1B3;

	private Panel plTuongTacBaiViet;

	private Panel D313FCAA;

	private TabControl tabOptionsPost;

	private TabPage tabPage1;

	private Label label2;

	private Label label3;

	private NumericUpDown nudSoLuongFrom;

	private NumericUpDown nudSoLuongTo;

	private TabPage tabPage2;

	private Label B6240DAF;

	private Label label9;

	private NumericUpDown F5B803B8;

	private NumericUpDown E2237109;

	private ComboBox cbbOptionsPost;

	private Label label4;

	public fHDTuongTacNhomv2(string AFABF329, int D383CC88 = 0, string BB379D29 = "")
	{
		InitializeComponent();
		bool_0 = false;
		AEA66D2E = AFABF329;
		string_0 = BB379D29;
		int_0 = D383CC88;
		string string_ = base.Name.Substring(1);
		string string_2 = "Bài viết Nhóm (www)";
		Class147.smethod_8(string_, string_2);
		string string_3 = "";
		switch (D383CC88)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", string_);
			CA2C452A = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(BB379D29);
			string_3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(string_3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void A1901D8D(object sender, EventArgs e)
	{
		method_0();
		try
		{
			cbbOptionsPost.SelectedIndex = gclass11_0.method_2("cbbOptionsPost");
			nudSoLuongFrom.Value = gclass11_0.method_2("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass11_0.method_2("nudSoLuongTo", 2);
			F5B803B8.Value = gclass11_0.method_2("nudThoiGianFrom", 30);
			E2237109.Value = gclass11_0.method_2("nudThoiGianTo", 30);
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom", 3);
			C9B35CB0.Value = gclass11_0.method_2("nudDelayTo", 5);
			B71FFC07 = new EFBBE9AB(gclass11_0);
			plTuongTacBaiViet.Controls.Add(B71FFC07);
		}
		catch
		{
		}
	}

	private void method_0()
	{
		List<string> list_ = new List<string> { "Giơ\u0301i ha\u0323n sô\u0301 ba\u0300i viê\u0301t tương ta\u0301c", "Giơ\u0301i ha\u0323n thơ\u0300i gian tương ta\u0301c" };
		GClass8.smethod_22(cbbOptionsPost, list_);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = B71FFC07.F0B0B700();
		gClass.method_4("cbbOptionsPost", cbbOptionsPost.SelectedIndex);
		gClass.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudThoiGianFrom", F5B803B8.Value);
		gClass.method_4("nudThoiGianTo", E2237109.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", C9B35CB0.Value);
		string text2 = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(AEA66D2E, text, CA2C452A, text2))
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
			if (Class147.smethod_13(string_0, text, text2))
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

	private void D52D4B97_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C79A8F90(object sender, PaintEventArgs e)
	{
		if (D58E312A.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, D58E312A.ClientSize.Width - num, D58E312A.ClientSize.Height - num));
		}
	}

	private void CE015994(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void DAA6E22F(object sender, EventArgs e)
	{
		tabOptionsPost.SelectedIndex = cbbOptionsPost.SelectedIndex;
	}

	protected override void Dispose(bool E8821185)
	{
		if (E8821185 && BF999D1C != null)
		{
			BF999D1C.Dispose();
		}
		base.Dispose(E8821185);
	}

	private void InitializeComponent()
	{
		BF999D1C = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTuongTacNhomv2));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(BF999D1C);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(BF999D1C);
		C1896F00 = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		D58E312A = new System.Windows.Forms.Panel();
		plTuongTacBaiViet = new System.Windows.Forms.Panel();
		C9B35CB0 = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		F9B52EA0 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		A32CF1B3 = new System.Windows.Forms.Label();
		D52D4B97 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		D313FCAA = new System.Windows.Forms.Panel();
		tabOptionsPost = new System.Windows.Forms.TabControl();
		tabPage1 = new System.Windows.Forms.TabPage();
		label2 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		tabPage2 = new System.Windows.Forms.TabPage();
		B6240DAF = new System.Windows.Forms.Label();
		label9 = new System.Windows.Forms.Label();
		F5B803B8 = new System.Windows.Forms.NumericUpDown();
		E2237109 = new System.Windows.Forms.NumericUpDown();
		cbbOptionsPost = new System.Windows.Forms.ComboBox();
		label4 = new System.Windows.Forms.Label();
		C1896F00.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		D58E312A.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C9B35CB0).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		D313FCAA.SuspendLayout();
		tabOptionsPost.SuspendLayout();
		tabPage1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		tabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)F5B803B8).BeginInit();
		((System.ComponentModel.ISupportInitialize)E2237109).BeginInit();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(713, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Bài viết Nhóm (www)";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = C1896F00;
		bunifuDragControl_1.Vertical = true;
		C1896F00.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		C1896F00.BackColor = System.Drawing.Color.White;
		C1896F00.Controls.Add(button1);
		C1896F00.Controls.Add(pictureBox1);
		C1896F00.Controls.Add(bunifuCustomLabel1);
		C1896F00.Cursor = System.Windows.Forms.Cursors.SizeAll;
		C1896F00.Location = new System.Drawing.Point(0, 3);
		C1896F00.Name = "pnlHeader";
		C1896F00.Size = new System.Drawing.Size(713, 31);
		C1896F00.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(682, 1);
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
		pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		D58E312A.BackColor = System.Drawing.Color.White;
		D58E312A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D58E312A.Controls.Add(D313FCAA);
		D58E312A.Controls.Add(cbbOptionsPost);
		D58E312A.Controls.Add(label4);
		D58E312A.Controls.Add(plTuongTacBaiViet);
		D58E312A.Controls.Add(C9B35CB0);
		D58E312A.Controls.Add(nudDelayFrom);
		D58E312A.Controls.Add(txtTenHanhDong);
		D58E312A.Controls.Add(F9B52EA0);
		D58E312A.Controls.Add(label5);
		D58E312A.Controls.Add(A32CF1B3);
		D58E312A.Controls.Add(D52D4B97);
		D58E312A.Controls.Add(btnAdd);
		D58E312A.Controls.Add(bunifuCards1);
		D58E312A.Cursor = System.Windows.Forms.Cursors.Arrow;
		D58E312A.Dock = System.Windows.Forms.DockStyle.Fill;
		D58E312A.Location = new System.Drawing.Point(0, 0);
		D58E312A.Name = "panel1";
		D58E312A.Size = new System.Drawing.Size(716, 490);
		D58E312A.TabIndex = 0;
		D58E312A.Click += new System.EventHandler(CE015994);
		D58E312A.Paint += new System.Windows.Forms.PaintEventHandler(C79A8F90);
		plTuongTacBaiViet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plTuongTacBaiViet.Location = new System.Drawing.Point(28, 167);
		plTuongTacBaiViet.Name = "plTuongTacBaiViet";
		plTuongTacBaiViet.Size = new System.Drawing.Size(657, 266);
		plTuongTacBaiViet.TabIndex = 204;
		C9B35CB0.Location = new System.Drawing.Point(234, 138);
		C9B35CB0.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C9B35CB0.Name = "nudDelayTo";
		C9B35CB0.Size = new System.Drawing.Size(56, 23);
		C9B35CB0.TabIndex = 198;
		nudDelayFrom.Location = new System.Drawing.Point(137, 138);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 197;
		txtTenHanhDong.Location = new System.Drawing.Point(137, 50);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(153, 23);
		txtTenHanhDong.TabIndex = 194;
		F9B52EA0.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F9B52EA0.Location = new System.Drawing.Point(199, 140);
		F9B52EA0.Name = "label7";
		F9B52EA0.Size = new System.Drawing.Size(29, 16);
		F9B52EA0.TabIndex = 203;
		F9B52EA0.Text = ">";
		F9B52EA0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(25, 140);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(87, 16);
		label5.TabIndex = 201;
		label5.Text = "Gia\u0303n ca\u0301ch (s):";
		A32CF1B3.AutoSize = true;
		A32CF1B3.Location = new System.Drawing.Point(25, 53);
		A32CF1B3.Name = "label1";
		A32CF1B3.Size = new System.Drawing.Size(98, 16);
		A32CF1B3.TabIndex = 199;
		A32CF1B3.Text = "Tên ha\u0300nh đô\u0323ng:";
		D52D4B97.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		D52D4B97.BackColor = System.Drawing.Color.Maroon;
		D52D4B97.Cursor = System.Windows.Forms.Cursors.Hand;
		D52D4B97.FlatAppearance.BorderSize = 0;
		D52D4B97.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D52D4B97.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D52D4B97.ForeColor = System.Drawing.Color.White;
		D52D4B97.Location = new System.Drawing.Point(364, 448);
		D52D4B97.Name = "btnCancel";
		D52D4B97.Size = new System.Drawing.Size(92, 29);
		D52D4B97.TabIndex = 10;
		D52D4B97.Text = "Đóng";
		D52D4B97.UseVisualStyleBackColor = false;
		D52D4B97.Click += new System.EventHandler(D52D4B97_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(257, 448);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(C1896F00);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(713, 37);
		bunifuCards1.TabIndex = 28;
		D313FCAA.Controls.Add(tabOptionsPost);
		D313FCAA.Location = new System.Drawing.Point(26, 109);
		D313FCAA.Name = "panel2";
		D313FCAA.Size = new System.Drawing.Size(266, 23);
		D313FCAA.TabIndex = 207;
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
		tabPage1.Controls.Add(nudSoLuongTo);
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
		nudSoLuongTo.Location = new System.Drawing.Point(209, 1);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		tabPage2.Controls.Add(B6240DAF);
		tabPage2.Controls.Add(label9);
		tabPage2.Controls.Add(F5B803B8);
		tabPage2.Controls.Add(E2237109);
		tabPage2.Location = new System.Drawing.Point(4, 4);
		tabPage2.Name = "tabPage2";
		tabPage2.Padding = new System.Windows.Forms.Padding(3);
		tabPage2.Size = new System.Drawing.Size(268, 25);
		tabPage2.TabIndex = 1;
		tabPage2.Text = "tabPage2";
		tabPage2.UseVisualStyleBackColor = true;
		B6240DAF.AutoSize = true;
		B6240DAF.Location = new System.Drawing.Point(0, 3);
		B6240DAF.Name = "label8";
		B6240DAF.Size = new System.Drawing.Size(85, 16);
		B6240DAF.TabIndex = 40;
		B6240DAF.Text = "Thơ\u0300i gian (s):";
		label9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label9.Location = new System.Drawing.Point(174, 3);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(29, 16);
		label9.TabIndex = 41;
		label9.Text = ">";
		label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F5B803B8.Location = new System.Drawing.Point(112, 1);
		F5B803B8.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F5B803B8.Name = "nudThoiGianFrom";
		F5B803B8.Size = new System.Drawing.Size(56, 23);
		F5B803B8.TabIndex = 38;
		E2237109.Location = new System.Drawing.Point(209, 1);
		E2237109.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E2237109.Name = "nudThoiGianTo";
		E2237109.Size = new System.Drawing.Size(56, 23);
		E2237109.TabIndex = 39;
		cbbOptionsPost.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbOptionsPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbOptionsPost.DropDownWidth = 200;
		cbbOptionsPost.FormattingEnabled = true;
		cbbOptionsPost.Location = new System.Drawing.Point(137, 79);
		cbbOptionsPost.Name = "cbbOptionsPost";
		cbbOptionsPost.Size = new System.Drawing.Size(153, 24);
		cbbOptionsPost.TabIndex = 205;
		cbbOptionsPost.SelectedIndexChanged += new System.EventHandler(DAA6E22F);
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(25, 82);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(64, 16);
		label4.TabIndex = 206;
		label4.Text = "Tu\u0300y cho\u0323n:";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(716, 490);
		base.Controls.Add(D58E312A);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacNhomv2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(A1901D8D);
		C1896F00.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		D58E312A.ResumeLayout(false);
		D58E312A.PerformLayout();
		((System.ComponentModel.ISupportInitialize)C9B35CB0).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		D313FCAA.ResumeLayout(false);
		tabOptionsPost.ResumeLayout(false);
		tabPage1.ResumeLayout(false);
		tabPage1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		tabPage2.ResumeLayout(false);
		tabPage2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)F5B803B8).EndInit();
		((System.ComponentModel.ISupportInitialize)E2237109).EndInit();
		ResumeLayout(false);
	}
}
