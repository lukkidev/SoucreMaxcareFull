using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDDoiTen : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool BC264AAD;

	private List<string> F3339C85 = new List<string>();

	private List<string> C4993F3D = new List<string>();

	private List<string> list_0 = new List<string>();

	private List<string> list_1 = new List<string>();

	private IContainer icontainer_0 = null;

	private BunifuDragControl AF042D01;

	private BunifuDragControl bunifuDragControl_0;

	private Panel A920CEB4;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel AC33B6A7;

	private Button FABC4E30;

	private Button CD0EF825;

	private Button button6;

	private RadioButton rdTenTuDat;

	private RadioButton F8010F2D;

	private Panel plTenNgauNhien;

	private RadioButton rdTenRandomNgoai;

	private RadioButton A91E43B9;

	private Panel D505EEB7;

	private RadioButton rdTenTuDat2;

	private RadioButton rdTenTuDat1;

	private Panel A720E9BB;

	private Button button2;

	private CheckBox ckbTuDongXoaNoiDung;

	public fHDDoiTen(string string_3, int int_1 = 0, string CE2D58A8 = "")
	{
		InitializeComponent();
		BC264AAD = false;
		string_0 = string_3;
		string_2 = CE2D58A8;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Đổi tên";
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
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(CE2D58A8);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void F8B15DA1(object sender, EventArgs e)
	{
		try
		{
			if (gclass11_0.method_2("typeDatTen") == 0)
			{
				F8010F2D.Checked = true;
			}
			else
			{
				rdTenTuDat.Checked = true;
			}
			if (gclass11_0.method_2("typeTenRandom") == 0)
			{
				A91E43B9.Checked = true;
			}
			else
			{
				rdTenRandomNgoai.Checked = true;
			}
			if (gclass11_0.method_2("typeTenTuDat") == 0)
			{
				rdTenTuDat1.Checked = true;
			}
			else
			{
				rdTenTuDat2.Checked = true;
			}
			F3339C85 = gclass11_0.C5A69DA0("lstHo");
			C4993F3D = gclass11_0.C5A69DA0("lstTenDem");
			list_0 = gclass11_0.C5A69DA0("lstTen");
			list_1 = gclass11_0.C5A69DA0("lstHoTen");
			ckbTuDongXoaNoiDung.Checked = gclass11_0.method_3("ckbTuDongXoaNoiDung");
			F8010F2D_CheckedChanged(null, null);
			FA3156AC(null, null);
			rdTenTuDat1_CheckedChanged(null, null);
			rdTenTuDat2_CheckedChanged(null, null);
		}
		catch
		{
		}
	}

	private void CE3B9590(object sender, EventArgs e)
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
		GClass11 gClass = new GClass11();
		int num = 0;
		if (rdTenTuDat.Checked)
		{
			num = 1;
		}
		gClass.method_4("typeDatTen", num);
		int num2 = 0;
		if (rdTenRandomNgoai.Checked)
		{
			num2 = 1;
		}
		gClass.method_4("typeTenRandom", num2);
		int num3 = 0;
		if (rdTenTuDat2.Checked)
		{
			num3 = 1;
		}
		gClass.method_4("typeTenTuDat", num3);
		gClass.method_5("lstHo", F3339C85);
		gClass.method_5("lstTenDem", C4993F3D);
		gClass.method_5("lstTen", list_0);
		gClass.method_5("lstHoTen", list_1);
		gClass.method_4("ckbTuDongXoaNoiDung", ckbTuDongXoaNoiDung.Checked);
		string text2 = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1(F7AB102E.smethod_0("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, text2))
				{
					BC264AAD = true;
					Close();
				}
				else
				{
					GClass29.smethod_0(F7AB102E.smethod_0("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
				}
			}
		}
		else if (GClass29.smethod_1(F7AB102E.smethod_0("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?")) == DialogResult.Yes)
		{
			if (Class147.smethod_13(string_2, text, text2))
			{
				BC264AAD = true;
				Close();
			}
			else
			{
				GClass29.smethod_0(F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void CFBC6B0F(object sender, PaintEventArgs e)
	{
		if (A920CEB4.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, A920CEB4.ClientSize.Width - num, A920CEB4.ClientSize.Height - num));
		}
	}

	private void FA3156AC(object sender, EventArgs e)
	{
		D505EEB7.Enabled = rdTenTuDat.Checked;
	}

	private void F8010F2D_CheckedChanged(object sender, EventArgs e)
	{
		plTenNgauNhien.Enabled = F8010F2D.Checked;
	}

	private void C92C6D07(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(F3339C85, "Nhâ\u0323p danh sa\u0301ch Họ", "Danh sa\u0301ch Họ", "(Mô\u0303i nội dung 1 do\u0300ng)");
		GClass8.smethod_33(fNhapDuLieu4);
		F3339C85 = fNhapDuLieu4.C6009CA1;
	}

	private void E590D619(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(C4993F3D, "Nhâ\u0323p danh sa\u0301ch Tên đệm", "Danh sa\u0301ch Tên đệm", "(Mô\u0303i nội dung 1 do\u0300ng)");
		GClass8.smethod_33(fNhapDuLieu4);
		C4993F3D = fNhapDuLieu4.C6009CA1;
	}

	private void B1914C95(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_0, "Nhâ\u0323p danh sa\u0301ch Tên", "Danh sa\u0301ch Tên", "(Mô\u0303i nội dung 1 do\u0300ng)");
		GClass8.smethod_33(fNhapDuLieu4);
		list_0 = fNhapDuLieu4.C6009CA1;
	}

	private void rdTenTuDat1_CheckedChanged(object sender, EventArgs e)
	{
		AC33B6A7.Enabled = rdTenTuDat1.Checked;
	}

	private void rdTenTuDat2_CheckedChanged(object sender, EventArgs e)
	{
		A720E9BB.Enabled = rdTenTuDat2.Checked;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_1, "Nhập danh sách họ tên", "Danh sách họ tên", "(Mô\u0303i nội dung 1 do\u0300ng)");
		GClass8.smethod_33(fNhapDuLieu4);
		list_1 = fNhapDuLieu4.C6009CA1;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDDoiTen));
		AF042D01 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		A920CEB4 = new System.Windows.Forms.Panel();
		rdTenTuDat = new System.Windows.Forms.RadioButton();
		F8010F2D = new System.Windows.Forms.RadioButton();
		D505EEB7 = new System.Windows.Forms.Panel();
		A720E9BB = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		AC33B6A7 = new System.Windows.Forms.Panel();
		FABC4E30 = new System.Windows.Forms.Button();
		CD0EF825 = new System.Windows.Forms.Button();
		button6 = new System.Windows.Forms.Button();
		rdTenTuDat2 = new System.Windows.Forms.RadioButton();
		rdTenTuDat1 = new System.Windows.Forms.RadioButton();
		plTenNgauNhien = new System.Windows.Forms.Panel();
		rdTenRandomNgoai = new System.Windows.Forms.RadioButton();
		A91E43B9 = new System.Windows.Forms.RadioButton();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		ckbTuDongXoaNoiDung = new System.Windows.Forms.CheckBox();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		A920CEB4.SuspendLayout();
		D505EEB7.SuspendLayout();
		A720E9BB.SuspendLayout();
		AC33B6A7.SuspendLayout();
		plTenNgauNhien.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		AF042D01.Fixed = true;
		AF042D01.Horizontal = true;
		AF042D01.TargetControl = bunifuCustomLabel1;
		AF042D01.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(341, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Đổi tên";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(341, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(310, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(CE3B9590);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		A920CEB4.BackColor = System.Drawing.Color.White;
		A920CEB4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		A920CEB4.Controls.Add(rdTenTuDat);
		A920CEB4.Controls.Add(F8010F2D);
		A920CEB4.Controls.Add(D505EEB7);
		A920CEB4.Controls.Add(plTenNgauNhien);
		A920CEB4.Controls.Add(txtTenHanhDong);
		A920CEB4.Controls.Add(label1);
		A920CEB4.Controls.Add(btnCancel);
		A920CEB4.Controls.Add(btnAdd);
		A920CEB4.Controls.Add(bunifuCards1);
		A920CEB4.Cursor = System.Windows.Forms.Cursors.Arrow;
		A920CEB4.Dock = System.Windows.Forms.DockStyle.Fill;
		A920CEB4.Location = new System.Drawing.Point(0, 0);
		A920CEB4.Name = "panel1";
		A920CEB4.Size = new System.Drawing.Size(344, 317);
		A920CEB4.TabIndex = 0;
		A920CEB4.Paint += new System.Windows.Forms.PaintEventHandler(CFBC6B0F);
		rdTenTuDat.AutoSize = true;
		rdTenTuDat.Checked = true;
		rdTenTuDat.Cursor = System.Windows.Forms.Cursors.Hand;
		rdTenTuDat.Location = new System.Drawing.Point(29, 131);
		rdTenTuDat.Name = "rdTenTuDat";
		rdTenTuDat.Size = new System.Drawing.Size(155, 20);
		rdTenTuDat.TabIndex = 138;
		rdTenTuDat.TabStop = true;
		rdTenTuDat.Text = "Tên do người dùng đặt";
		rdTenTuDat.UseVisualStyleBackColor = true;
		rdTenTuDat.CheckedChanged += new System.EventHandler(FA3156AC);
		F8010F2D.AutoSize = true;
		F8010F2D.Cursor = System.Windows.Forms.Cursors.Hand;
		F8010F2D.Location = new System.Drawing.Point(29, 78);
		F8010F2D.Name = "rdTenRandom";
		F8010F2D.Size = new System.Drawing.Size(114, 20);
		F8010F2D.TabIndex = 137;
		F8010F2D.Text = "Tên ngẫu nhiên";
		F8010F2D.UseVisualStyleBackColor = true;
		F8010F2D.CheckedChanged += new System.EventHandler(F8010F2D_CheckedChanged);
		D505EEB7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D505EEB7.Controls.Add(A720E9BB);
		D505EEB7.Controls.Add(AC33B6A7);
		D505EEB7.Controls.Add(rdTenTuDat2);
		D505EEB7.Controls.Add(rdTenTuDat1);
		D505EEB7.Location = new System.Drawing.Point(44, 153);
		D505EEB7.Name = "plTenTuDat";
		D505EEB7.Size = new System.Drawing.Size(266, 101);
		D505EEB7.TabIndex = 139;
		A720E9BB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		A720E9BB.Controls.Add(ckbTuDongXoaNoiDung);
		A720E9BB.Controls.Add(button2);
		A720E9BB.Location = new System.Drawing.Point(21, 38);
		A720E9BB.Name = "plTenTuDat2";
		A720E9BB.Size = new System.Drawing.Size(240, 56);
		A720E9BB.TabIndex = 136;
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.Location = new System.Drawing.Point(0, 0);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(238, 27);
		button2.TabIndex = 124;
		button2.Text = "Nhập danh sách họ tên";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		AC33B6A7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		AC33B6A7.Controls.Add(FABC4E30);
		AC33B6A7.Controls.Add(CD0EF825);
		AC33B6A7.Controls.Add(button6);
		AC33B6A7.Location = new System.Drawing.Point(21, 3);
		AC33B6A7.Name = "plTenTuDat1";
		AC33B6A7.Size = new System.Drawing.Size(240, 29);
		AC33B6A7.TabIndex = 136;
		FABC4E30.Cursor = System.Windows.Forms.Cursors.Hand;
		FABC4E30.Location = new System.Drawing.Point(171, 0);
		FABC4E30.Name = "button8";
		FABC4E30.Size = new System.Drawing.Size(67, 27);
		FABC4E30.TabIndex = 124;
		FABC4E30.Text = "Nhập tên";
		FABC4E30.UseVisualStyleBackColor = true;
		FABC4E30.Click += new System.EventHandler(B1914C95);
		CD0EF825.Cursor = System.Windows.Forms.Cursors.Hand;
		CD0EF825.Location = new System.Drawing.Point(69, 0);
		CD0EF825.Name = "button7";
		CD0EF825.Size = new System.Drawing.Size(96, 27);
		CD0EF825.TabIndex = 124;
		CD0EF825.Text = "Nhập tên đệm";
		CD0EF825.UseVisualStyleBackColor = true;
		CD0EF825.Click += new System.EventHandler(E590D619);
		button6.Cursor = System.Windows.Forms.Cursors.Hand;
		button6.Location = new System.Drawing.Point(0, 0);
		button6.Name = "button6";
		button6.Size = new System.Drawing.Size(63, 27);
		button6.TabIndex = 124;
		button6.Text = "Nhập họ";
		button6.UseVisualStyleBackColor = true;
		button6.Click += new System.EventHandler(C92C6D07);
		rdTenTuDat2.AutoSize = true;
		rdTenTuDat2.Cursor = System.Windows.Forms.Cursors.Hand;
		rdTenTuDat2.Location = new System.Drawing.Point(3, 46);
		rdTenTuDat2.Name = "rdTenTuDat2";
		rdTenTuDat2.Size = new System.Drawing.Size(14, 13);
		rdTenTuDat2.TabIndex = 134;
		rdTenTuDat2.UseVisualStyleBackColor = true;
		rdTenTuDat2.CheckedChanged += new System.EventHandler(rdTenTuDat2_CheckedChanged);
		rdTenTuDat1.AutoSize = true;
		rdTenTuDat1.Checked = true;
		rdTenTuDat1.Cursor = System.Windows.Forms.Cursors.Hand;
		rdTenTuDat1.Location = new System.Drawing.Point(3, 11);
		rdTenTuDat1.Name = "rdTenTuDat1";
		rdTenTuDat1.Size = new System.Drawing.Size(14, 13);
		rdTenTuDat1.TabIndex = 134;
		rdTenTuDat1.TabStop = true;
		rdTenTuDat1.UseVisualStyleBackColor = true;
		rdTenTuDat1.CheckedChanged += new System.EventHandler(rdTenTuDat1_CheckedChanged);
		plTenNgauNhien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plTenNgauNhien.Controls.Add(rdTenRandomNgoai);
		plTenNgauNhien.Controls.Add(A91E43B9);
		plTenNgauNhien.Location = new System.Drawing.Point(44, 100);
		plTenNgauNhien.Name = "plTenNgauNhien";
		plTenNgauNhien.Size = new System.Drawing.Size(266, 25);
		plTenNgauNhien.TabIndex = 139;
		rdTenRandomNgoai.AutoSize = true;
		rdTenRandomNgoai.Cursor = System.Windows.Forms.Cursors.Hand;
		rdTenRandomNgoai.Location = new System.Drawing.Point(80, 1);
		rdTenRandomNgoai.Name = "rdTenRandomNgoai";
		rdTenRandomNgoai.Size = new System.Drawing.Size(82, 20);
		rdTenRandomNgoai.TabIndex = 134;
		rdTenRandomNgoai.Text = "Tên ngoại";
		rdTenRandomNgoai.UseVisualStyleBackColor = true;
		A91E43B9.AutoSize = true;
		A91E43B9.Checked = true;
		A91E43B9.Cursor = System.Windows.Forms.Cursors.Hand;
		A91E43B9.Location = new System.Drawing.Point(2, 1);
		A91E43B9.Name = "rdTenRandomViet";
		A91E43B9.Size = new System.Drawing.Size(71, 20);
		A91E43B9.TabIndex = 134;
		A91E43B9.TabStop = true;
		A91E43B9.Text = "Tên việt";
		A91E43B9.UseVisualStyleBackColor = true;
		txtTenHanhDong.Location = new System.Drawing.Point(125, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(185, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(26, 52);
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
		btnCancel.Location = new System.Drawing.Point(179, 272);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
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
		btnAdd.Location = new System.Drawing.Point(72, 272);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
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
		bunifuCards1.Size = new System.Drawing.Size(341, 37);
		bunifuCards1.TabIndex = 28;
		ckbTuDongXoaNoiDung.AutoSize = true;
		ckbTuDongXoaNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuDongXoaNoiDung.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		ckbTuDongXoaNoiDung.Location = new System.Drawing.Point(2, 30);
		ckbTuDongXoaNoiDung.Name = "ckbTuDongXoaNoiDung";
		ckbTuDongXoaNoiDung.Size = new System.Drawing.Size(138, 20);
		ckbTuDongXoaNoiDung.TabIndex = 133;
		ckbTuDongXoaNoiDung.Text = "Xo\u0301a tên đa\u0303 sư\u0309 du\u0323ng";
		ckbTuDongXoaNoiDung.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(344, 317);
		base.Controls.Add(A920CEB4);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDoiTen";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(F8B15DA1);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		A920CEB4.ResumeLayout(false);
		A920CEB4.PerformLayout();
		D505EEB7.ResumeLayout(false);
		D505EEB7.PerformLayout();
		A720E9BB.ResumeLayout(false);
		A720E9BB.PerformLayout();
		AC33B6A7.ResumeLayout(false);
		plTenNgauNhien.ResumeLayout(false);
		plTenNgauNhien.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
