using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class A52F8229 : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string string_1;

	private string CFB11336;

	private int int_0;

	public static bool D81D80A2;

	private EFBBE9AB efbbe9AB_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl FB078D34;

	private BunifuDragControl B51AAE20;

	private Panel FB05F939;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label label49;

	private NumericUpDown DABE7AA4;

	private Label label19;

	private NumericUpDown EC128098;

	private Label label66;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label C09828AD;

	private Panel plTuongTacBaiViet;

	private NumericUpDown nudSoLuongBaiVietTo;

	private NumericUpDown B18EC88C;

	private Label DD897E37;

	private Panel ED05661D;

	private TabControl tabOptionsPost;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private Label label8;

	private Label label9;

	private NumericUpDown nudThoiGianFrom;

	private NumericUpDown BF1CEFA7;

	private ComboBox cbbOptionsPost;

	private Label label6;

	public A52F8229(string string_2, int int_1 = 0, string string_3 = "")
	{
		InitializeComponent();
		D81D80A2 = false;
		string_0 = string_2;
		CFB11336 = string_3;
		int_0 = int_1;
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDBaiVietBanBe");
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void A52F8229_Load(object sender, EventArgs e)
	{
		E3B55A2C();
		try
		{
			DABE7AA4.Value = gclass11_0.method_2("nudSoLuongBanBeFrom", 1);
			EC128098.Value = gclass11_0.method_2("nudSoLuongBanBeTo", 1);
			cbbOptionsPost.SelectedIndex = gclass11_0.method_2("cbbOptionsPost");
			B18EC88C.Value = gclass11_0.method_2("nudSoLuongBaiVietFrom", 1);
			nudSoLuongBaiVietTo.Value = gclass11_0.method_2("nudSoLuongBaiVietTo", 2);
			nudThoiGianFrom.Value = gclass11_0.method_2("nudThoiGianFrom", 30);
			BF1CEFA7.Value = gclass11_0.method_2("nudThoiGianTo", 30);
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
			efbbe9AB_0 = new EFBBE9AB(gclass11_0);
			plTuongTacBaiViet.Controls.Add(efbbe9AB_0);
		}
		catch
		{
		}
	}

	private void E3B55A2C()
	{
		List<string> list_ = new List<string> { "Giơ\u0301i ha\u0323n sô\u0301 ba\u0300i viê\u0301t tương ta\u0301c", "Giơ\u0301i ha\u0323n thơ\u0300i gian tương ta\u0301c" };
		GClass8.smethod_22(cbbOptionsPost, list_);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F78AB0AC(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = efbbe9AB_0.F0B0B700();
		gClass.method_4("nudSoLuongBanBeFrom", DABE7AA4.Value);
		gClass.method_4("nudSoLuongBanBeTo", EC128098.Value);
		gClass.method_4("cbbOptionsPost", cbbOptionsPost.SelectedIndex);
		gClass.method_4("nudSoLuongBaiVietFrom", B18EC88C.Value);
		gClass.method_4("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
		gClass.method_4("nudThoiGianFrom", nudThoiGianFrom.Value);
		gClass.method_4("nudThoiGianTo", BF1CEFA7.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		string string_ = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, string_))
				{
					D81D80A2 = true;
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
			if (Class147.smethod_13(CFB11336, text, string_))
			{
				D81D80A2 = true;
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

	private void FB05F939_Paint(object sender, PaintEventArgs e)
	{
		if (FB05F939.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, FB05F939.ClientSize.Width - num, FB05F939.ClientSize.Height - num));
		}
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
		}
	}

	private void FC3CDF38(object sender, EventArgs e)
	{
		tabOptionsPost.SelectedIndex = cbbOptionsPost.SelectedIndex;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A52F8229));
		FB078D34 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		B51AAE20 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		FB05F939 = new System.Windows.Forms.Panel();
		plTuongTacBaiViet = new System.Windows.Forms.Panel();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		C09828AD = new System.Windows.Forms.Label();
		label49 = new System.Windows.Forms.Label();
		DABE7AA4 = new System.Windows.Forms.NumericUpDown();
		label19 = new System.Windows.Forms.Label();
		EC128098 = new System.Windows.Forms.NumericUpDown();
		label66 = new System.Windows.Forms.Label();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		DD897E37 = new System.Windows.Forms.Label();
		B18EC88C = new System.Windows.Forms.NumericUpDown();
		nudSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
		ED05661D = new System.Windows.Forms.Panel();
		tabOptionsPost = new System.Windows.Forms.TabControl();
		tabPage1 = new System.Windows.Forms.TabPage();
		tabPage2 = new System.Windows.Forms.TabPage();
		label8 = new System.Windows.Forms.Label();
		label9 = new System.Windows.Forms.Label();
		nudThoiGianFrom = new System.Windows.Forms.NumericUpDown();
		BF1CEFA7 = new System.Windows.Forms.NumericUpDown();
		cbbOptionsPost = new System.Windows.Forms.ComboBox();
		label6 = new System.Windows.Forms.Label();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		FB05F939.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)DABE7AA4).BeginInit();
		((System.ComponentModel.ISupportInitialize)EC128098).BeginInit();
		bunifuCards1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)B18EC88C).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietTo).BeginInit();
		ED05661D.SuspendLayout();
		tabOptionsPost.SuspendLayout();
		tabPage1.SuspendLayout();
		tabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudThoiGianFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)BF1CEFA7).BeginInit();
		SuspendLayout();
		FB078D34.Fixed = true;
		FB078D34.Horizontal = true;
		FB078D34.TargetControl = bunifuCustomLabel1;
		FB078D34.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(716, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Bài viết Bạn bè";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B51AAE20.Fixed = true;
		B51AAE20.Horizontal = true;
		B51AAE20.TargetControl = pnlHeader;
		B51AAE20.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(716, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(685, 1);
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
		FB05F939.BackColor = System.Drawing.Color.White;
		FB05F939.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		FB05F939.Controls.Add(ED05661D);
		FB05F939.Controls.Add(cbbOptionsPost);
		FB05F939.Controls.Add(label6);
		FB05F939.Controls.Add(plTuongTacBaiViet);
		FB05F939.Controls.Add(nudDelayTo);
		FB05F939.Controls.Add(nudDelayFrom);
		FB05F939.Controls.Add(label7);
		FB05F939.Controls.Add(C09828AD);
		FB05F939.Controls.Add(label49);
		FB05F939.Controls.Add(DABE7AA4);
		FB05F939.Controls.Add(EC128098);
		FB05F939.Controls.Add(label66);
		FB05F939.Controls.Add(txtTenHanhDong);
		FB05F939.Controls.Add(label1);
		FB05F939.Controls.Add(btnCancel);
		FB05F939.Controls.Add(btnAdd);
		FB05F939.Controls.Add(bunifuCards1);
		FB05F939.Cursor = System.Windows.Forms.Cursors.Arrow;
		FB05F939.Dock = System.Windows.Forms.DockStyle.Fill;
		FB05F939.Location = new System.Drawing.Point(0, 0);
		FB05F939.Name = "panel1";
		FB05F939.Size = new System.Drawing.Size(719, 522);
		FB05F939.TabIndex = 0;
		FB05F939.Paint += new System.Windows.Forms.PaintEventHandler(FB05F939_Paint);
		plTuongTacBaiViet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plTuongTacBaiViet.Location = new System.Drawing.Point(30, 196);
		plTuongTacBaiViet.Name = "plTuongTacBaiViet";
		plTuongTacBaiViet.Size = new System.Drawing.Size(657, 266);
		plTuongTacBaiViet.TabIndex = 198;
		nudDelayTo.Location = new System.Drawing.Point(236, 167);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 195;
		nudDelayFrom.Location = new System.Drawing.Point(139, 167);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 194;
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label7.Location = new System.Drawing.Point(201, 169);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 197;
		label7.Text = ">";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C09828AD.AutoSize = true;
		C09828AD.Location = new System.Drawing.Point(27, 169);
		C09828AD.Name = "label5";
		C09828AD.Size = new System.Drawing.Size(87, 16);
		C09828AD.TabIndex = 196;
		C09828AD.Text = "Gia\u0303n ca\u0301ch (s):";
		label49.AutoSize = true;
		label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label49.Location = new System.Drawing.Point(27, 80);
		label49.Name = "label49";
		label49.Size = new System.Drawing.Size(88, 16);
		label49.TabIndex = 92;
		label49.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		DABE7AA4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		DABE7AA4.Location = new System.Drawing.Point(139, 78);
		DABE7AA4.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		DABE7AA4.Name = "nudSoLuongBanBeFrom";
		DABE7AA4.Size = new System.Drawing.Size(56, 23);
		DABE7AA4.TabIndex = 1;
		DABE7AA4.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		label19.AutoSize = true;
		label19.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label19.Location = new System.Drawing.Point(0, 3);
		label19.Name = "label19";
		label19.Size = new System.Drawing.Size(98, 16);
		label19.TabIndex = 101;
		label19.Text = "Sô\u0301 ba\u0300i viê\u0301t/ba\u0323n:";
		EC128098.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		EC128098.Location = new System.Drawing.Point(236, 78);
		EC128098.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		EC128098.Name = "nudSoLuongBanBeTo";
		EC128098.Size = new System.Drawing.Size(56, 23);
		EC128098.TabIndex = 2;
		EC128098.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		label66.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		label66.Location = new System.Drawing.Point(201, 80);
		label66.Name = "label66";
		label66.Size = new System.Drawing.Size(29, 16);
		label66.TabIndex = 105;
		label66.Text = ">";
		label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		txtTenHanhDong.Location = new System.Drawing.Point(139, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(153, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
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
		btnCancel.Location = new System.Drawing.Point(367, 477);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 12;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(260, 477);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 11;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(F78AB0AC);
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
		bunifuCards1.Size = new System.Drawing.Size(716, 37);
		bunifuCards1.TabIndex = 28;
		DD897E37.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DD897E37.Location = new System.Drawing.Point(174, 3);
		DD897E37.Name = "label3";
		DD897E37.Size = new System.Drawing.Size(29, 16);
		DD897E37.TabIndex = 37;
		DD897E37.Text = ">";
		DD897E37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B18EC88C.Location = new System.Drawing.Point(112, 1);
		B18EC88C.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		B18EC88C.Name = "nudSoLuongBaiVietFrom";
		B18EC88C.Size = new System.Drawing.Size(56, 23);
		B18EC88C.TabIndex = 3;
		nudSoLuongBaiVietTo.Location = new System.Drawing.Point(209, 1);
		nudSoLuongBaiVietTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBaiVietTo.Name = "nudSoLuongBaiVietTo";
		nudSoLuongBaiVietTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongBaiVietTo.TabIndex = 4;
		ED05661D.Controls.Add(tabOptionsPost);
		ED05661D.Location = new System.Drawing.Point(28, 137);
		ED05661D.Name = "panel2";
		ED05661D.Size = new System.Drawing.Size(266, 23);
		ED05661D.TabIndex = 202;
		tabOptionsPost.Alignment = System.Windows.Forms.TabAlignment.Bottom;
		tabOptionsPost.Controls.Add(tabPage1);
		tabOptionsPost.Controls.Add(tabPage2);
		tabOptionsPost.Location = new System.Drawing.Point(-5, -5);
		tabOptionsPost.Name = "tabOptionsPost";
		tabOptionsPost.SelectedIndex = 0;
		tabOptionsPost.Size = new System.Drawing.Size(276, 54);
		tabOptionsPost.TabIndex = 198;
		tabPage1.Controls.Add(label19);
		tabPage1.Controls.Add(DD897E37);
		tabPage1.Controls.Add(B18EC88C);
		tabPage1.Controls.Add(nudSoLuongBaiVietTo);
		tabPage1.Location = new System.Drawing.Point(4, 4);
		tabPage1.Name = "tabPage1";
		tabPage1.Padding = new System.Windows.Forms.Padding(3);
		tabPage1.Size = new System.Drawing.Size(268, 25);
		tabPage1.TabIndex = 0;
		tabPage1.Text = "tabPage1";
		tabPage1.UseVisualStyleBackColor = true;
		tabPage2.Controls.Add(label8);
		tabPage2.Controls.Add(label9);
		tabPage2.Controls.Add(nudThoiGianFrom);
		tabPage2.Controls.Add(BF1CEFA7);
		tabPage2.Location = new System.Drawing.Point(4, 4);
		tabPage2.Name = "tabPage2";
		tabPage2.Padding = new System.Windows.Forms.Padding(3);
		tabPage2.Size = new System.Drawing.Size(268, 25);
		tabPage2.TabIndex = 1;
		tabPage2.Text = "tabPage2";
		tabPage2.UseVisualStyleBackColor = true;
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(0, 3);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(111, 16);
		label8.TabIndex = 40;
		label8.Text = "Thơ\u0300i gian/ba\u0323n (s):";
		label9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label9.Location = new System.Drawing.Point(174, 3);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(29, 16);
		label9.TabIndex = 41;
		label9.Text = ">";
		label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudThoiGianFrom.Location = new System.Drawing.Point(112, 1);
		nudThoiGianFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudThoiGianFrom.Name = "nudThoiGianFrom";
		nudThoiGianFrom.Size = new System.Drawing.Size(56, 23);
		nudThoiGianFrom.TabIndex = 38;
		BF1CEFA7.Location = new System.Drawing.Point(209, 1);
		BF1CEFA7.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		BF1CEFA7.Name = "nudThoiGianTo";
		BF1CEFA7.Size = new System.Drawing.Size(56, 23);
		BF1CEFA7.TabIndex = 39;
		cbbOptionsPost.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbOptionsPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbOptionsPost.DropDownWidth = 200;
		cbbOptionsPost.FormattingEnabled = true;
		cbbOptionsPost.Location = new System.Drawing.Point(139, 107);
		cbbOptionsPost.Name = "cbbOptionsPost";
		cbbOptionsPost.Size = new System.Drawing.Size(153, 24);
		cbbOptionsPost.TabIndex = 200;
		cbbOptionsPost.SelectedIndexChanged += new System.EventHandler(FC3CDF38);
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(27, 110);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(64, 16);
		label6.TabIndex = 201;
		label6.Text = "Tu\u0300y cho\u0323n:";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(719, 522);
		base.Controls.Add(FB05F939);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBaiVietBanBe";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(A52F8229_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		FB05F939.ResumeLayout(false);
		FB05F939.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)DABE7AA4).EndInit();
		((System.ComponentModel.ISupportInitialize)EC128098).EndInit();
		bunifuCards1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)B18EC88C).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietTo).EndInit();
		ED05661D.ResumeLayout(false);
		tabOptionsPost.ResumeLayout(false);
		tabPage1.ResumeLayout(false);
		tabPage1.PerformLayout();
		tabPage2.ResumeLayout(false);
		tabPage2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudThoiGianFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)BF1CEFA7).EndInit();
		ResumeLayout(false);
	}
}
