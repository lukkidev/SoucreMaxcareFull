using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDReport : Form
{
	private GClass11 gclass11_0;

	private string A10C5087;

	private string string_0;

	private string A0820632;

	private int AC1419B0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl CCB5F3A7;

	private Panel panel1;

	private NumericUpDown F7050226;

	private NumericUpDown BF07E808;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label C22B9AA7;

	private Label label2;

	private Label D32C04BB;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards DD006C96;

	private Panel B01A1393;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel CB3241A3;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label6;

	private Label label5;

	private CheckBox ckbLuaDao;

	private CheckBox CA883F1F;

	private Label B3A50C2C;

	private Panel panel2;

	private CheckBox ckbTinGia;

	private CheckBox D81E7238;

	private CheckBox A135309F;

	private CheckBox BA1B9688;

	private CheckBox ckbXucPham;

	private CheckBox A0897539;

	private Label label8;

	private RichTextBox B524EC9C;

	public fHDReport(string BB9F458B, int int_0 = 0, string string_1 = "")
	{
		B7852D9E();
		bool_0 = false;
		A10C5087 = BB9F458B;
		A0820632 = string_1;
		AC1419B0 = int_0;
		if (Class147.smethod_7("", "HDReport").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDReport', 'Report');");
		}
		string string_2 = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDReport");
			string_2 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_1);
			string_2 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(string_2, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void F336F7B0()
	{
		F7AB102E.smethod_1(CB3241A3);
		F7AB102E.smethod_1(D32C04BB);
		F7AB102E.smethod_1(label2);
		F7AB102E.smethod_1(label3);
		F7AB102E.smethod_1(C22B9AA7);
		F7AB102E.smethod_1(label5);
		F7AB102E.smethod_1(label7);
		F7AB102E.smethod_1(label6);
		F7AB102E.smethod_1(ckbLuaDao);
		F7AB102E.smethod_1(CA883F1F);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(btnCancel);
	}

	private void C4932F90(object sender, EventArgs e)
	{
		try
		{
			BF07E808.Value = gclass11_0.method_2("nudSoLuongFrom", 1);
			F7050226.Value = gclass11_0.method_2("nudSoLuongTo", 1);
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom", 10);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 15);
			B524EC9C.Text = gclass11_0.C0288288("txtIdAds");
			ckbLuaDao.Checked = gclass11_0.C0288288("typeReport").Contains("1");
			CA883F1F.Checked = gclass11_0.C0288288("typeReport").Contains("2");
			ckbXucPham.Checked = gclass11_0.C0288288("typeReport").Contains("3");
			A0897539.Checked = gclass11_0.C0288288("typeReport").Contains("4");
			A135309F.Checked = gclass11_0.C0288288("typeReport").Contains("5");
			BA1B9688.Checked = gclass11_0.C0288288("typeReport").Contains("6");
			ckbTinGia.Checked = gclass11_0.C0288288("typeReport").Contains("7");
			D81E7238.Checked = gclass11_0.C0288288("typeReport").Contains("8");
		}
		catch
		{
		}
	}

	private void D78C9FB6(object sender, EventArgs e)
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
		gClass.method_4("nudSoLuongFrom", BF07E808.Value);
		gClass.method_4("nudSoLuongTo", F7050226.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		gClass.method_4("txtIdAds", B524EC9C.Text);
		List<int> list = new List<int>();
		if (ckbLuaDao.Checked)
		{
			list.Add(1);
		}
		if (CA883F1F.Checked)
		{
			list.Add(2);
		}
		if (ckbXucPham.Checked)
		{
			list.Add(3);
		}
		if (A0897539.Checked)
		{
			list.Add(4);
		}
		if (A135309F.Checked)
		{
			list.Add(5);
		}
		if (BA1B9688.Checked)
		{
			list.Add(6);
		}
		if (ckbTinGia.Checked)
		{
			list.Add(7);
		}
		if (D81E7238.Checked)
		{
			list.Add(8);
		}
		gClass.method_4("typeReport", string.Join("\n", list));
		string text2 = gClass.method_7();
		if (AC1419B0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(A10C5087, text, string_0, text2))
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
			if (Class147.smethod_13(A0820632, text, text2))
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

	private void B598D78A(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void B524EC9C_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = B524EC9C.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			label8.Text = string.Format(F7AB102E.smethod_0("Danh sách ID ({0}):"), e03C713E.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void B7852D9E()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDReport));
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		CB3241A3 = new BunifuCustomLabel();
		CCB5F3A7 = new BunifuDragControl(icontainer_0);
		B01A1393 = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		B3A50C2C = new Label();
		panel2 = new Panel();
		ckbTinGia = new CheckBox();
		D81E7238 = new CheckBox();
		A135309F = new CheckBox();
		BA1B9688 = new CheckBox();
		ckbXucPham = new CheckBox();
		A0897539 = new CheckBox();
		ckbLuaDao = new CheckBox();
		CA883F1F = new CheckBox();
		label8 = new Label();
		B524EC9C = new RichTextBox();
		nudDelayTo = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		label7 = new Label();
		label6 = new Label();
		label5 = new Label();
		F7050226 = new NumericUpDown();
		BF07E808 = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		label3 = new Label();
		C22B9AA7 = new Label();
		label2 = new Label();
		D32C04BB = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		DD006C96 = new BunifuCards();
		B01A1393.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		panel2.SuspendLayout();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		((ISupportInitialize)F7050226).BeginInit();
		((ISupportInitialize)BF07E808).BeginInit();
		DD006C96.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = CB3241A3;
		bunifuDragControl_0.Vertical = true;
		CB3241A3.BackColor = Color.Transparent;
		CB3241A3.Cursor = Cursors.SizeAll;
		CB3241A3.Dock = DockStyle.Fill;
		CB3241A3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		CB3241A3.ForeColor = Color.Black;
		CB3241A3.Location = new Point(0, 0);
		CB3241A3.Name = "bunifuCustomLabel1";
		CB3241A3.Size = new Size(672, 31);
		CB3241A3.TabIndex = 12;
		CB3241A3.Text = "Cấu hình Report";
		CB3241A3.TextAlign = ContentAlignment.MiddleCenter;
		CCB5F3A7.Fixed = true;
		CCB5F3A7.Horizontal = true;
		CCB5F3A7.TargetControl = B01A1393;
		CCB5F3A7.Vertical = true;
		B01A1393.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		B01A1393.BackColor = Color.White;
		B01A1393.Controls.Add(button1);
		B01A1393.Controls.Add(pictureBox1);
		B01A1393.Controls.Add(CB3241A3);
		B01A1393.Cursor = Cursors.SizeAll;
		B01A1393.Location = new Point(0, 3);
		B01A1393.Name = "pnlHeader";
		B01A1393.Size = new Size(672, 31);
		B01A1393.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(641, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += D78C9FB6;
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
		panel1.Controls.Add(B3A50C2C);
		panel1.Controls.Add(panel2);
		panel1.Controls.Add(label8);
		panel1.Controls.Add(B524EC9C);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(F7050226);
		panel1.Controls.Add(BF07E808);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(C22B9AA7);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(D32C04BB);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(DD006C96);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(675, 454);
		panel1.TabIndex = 0;
		panel1.Paint += B598D78A;
		B3A50C2C.AutoSize = true;
		B3A50C2C.Location = new Point(347, 144);
		B3A50C2C.Name = "label9";
		B3A50C2C.Size = new Size(64, 16);
		B3A50C2C.TabIndex = 51;
		B3A50C2C.Text = "Tùy chọn:";
		panel2.BorderStyle = BorderStyle.FixedSingle;
		panel2.Controls.Add(ckbTinGia);
		panel2.Controls.Add(D81E7238);
		panel2.Controls.Add(A135309F);
		panel2.Controls.Add(BA1B9688);
		panel2.Controls.Add(ckbXucPham);
		panel2.Controls.Add(A0897539);
		panel2.Controls.Add(ckbLuaDao);
		panel2.Controls.Add(CA883F1F);
		panel2.Location = new Point(364, 169);
		panel2.Name = "panel2";
		panel2.Size = new Size(246, 213);
		panel2.TabIndex = 50;
		ckbTinGia.AutoSize = true;
		ckbTinGia.Cursor = Cursors.Hand;
		ckbTinGia.Location = new Point(3, 159);
		ckbTinGia.Name = "ckbTinGia";
		ckbTinGia.Size = new Size(65, 20);
		ckbTinGia.TabIndex = 52;
		ckbTinGia.Text = "Tin giả";
		ckbTinGia.UseVisualStyleBackColor = true;
		D81E7238.AutoSize = true;
		D81E7238.Cursor = Cursors.Hand;
		D81E7238.Location = new Point(3, 185);
		D81E7238.Name = "ckbKhac";
		D81E7238.Size = new Size(53, 20);
		D81E7238.TabIndex = 53;
		D81E7238.Text = "Khác";
		D81E7238.UseVisualStyleBackColor = true;
		A135309F.AutoSize = true;
		A135309F.Cursor = Cursors.Hand;
		A135309F.Location = new Point(3, 107);
		A135309F.Name = "ckbNoiDungCam";
		A135309F.Size = new Size(118, 20);
		A135309F.TabIndex = 50;
		A135309F.Text = "Nội dung bị cấm";
		A135309F.UseVisualStyleBackColor = true;
		BA1B9688.AutoSize = true;
		BA1B9688.Cursor = Cursors.Hand;
		BA1B9688.Location = new Point(3, 133);
		BA1B9688.Name = "ckbSpam";
		BA1B9688.Size = new Size(59, 20);
		BA1B9688.TabIndex = 51;
		BA1B9688.Text = "Spam";
		BA1B9688.UseVisualStyleBackColor = true;
		ckbXucPham.AutoSize = true;
		ckbXucPham.Cursor = Cursors.Hand;
		ckbXucPham.Location = new Point(3, 55);
		ckbXucPham.Name = "ckbXucPham";
		ckbXucPham.Size = new Size(83, 20);
		ckbXucPham.TabIndex = 48;
		ckbXucPham.Text = "Xúc phạm";
		ckbXucPham.UseVisualStyleBackColor = true;
		A0897539.AutoSize = true;
		A0897539.Cursor = Cursors.Hand;
		A0897539.Location = new Point(3, 81);
		A0897539.Name = "ckbBaoLuc";
		A0897539.Size = new Size(68, 20);
		A0897539.TabIndex = 49;
		A0897539.Text = "Bạo lực";
		A0897539.UseVisualStyleBackColor = true;
		ckbLuaDao.AutoSize = true;
		ckbLuaDao.Cursor = Cursors.Hand;
		ckbLuaDao.Location = new Point(3, 3);
		ckbLuaDao.Name = "ckbLuaDao";
		ckbLuaDao.Size = new Size(189, 20);
		ckbLuaDao.TabIndex = 47;
		ckbLuaDao.Text = "Gây hiểu nhầm hoặc lừa đảo";
		ckbLuaDao.UseVisualStyleBackColor = true;
		CA883F1F.AutoSize = true;
		CA883F1F.Cursor = Cursors.Hand;
		CA883F1F.Location = new Point(3, 29);
		CA883F1F.Name = "ckbTinhDuc";
		CA883F1F.Size = new Size(208, 20);
		CA883F1F.TabIndex = 47;
		CA883F1F.Text = "Thiếu đứng đắn về mặt tình dục";
		CA883F1F.UseVisualStyleBackColor = true;
		label8.AutoSize = true;
		label8.Location = new Point(27, 150);
		label8.Name = "label8";
		label8.Size = new Size(108, 16);
		label8.TabIndex = 49;
		label8.Text = "Danh sách ID (0):";
		B524EC9C.Location = new Point(30, 169);
		B524EC9C.Name = "txtIdAds";
		B524EC9C.Size = new Size(276, 213);
		B524EC9C.TabIndex = 48;
		B524EC9C.Text = "";
		B524EC9C.TextChanged += B524EC9C_TextChanged;
		nudDelayTo.Location = new Point(229, 112);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudDelayFrom.Location = new Point(132, 112);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		label7.Location = new Point(194, 114);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		label7.TextAlign = ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new Point(287, 114);
		label6.Name = "label6";
		label6.Size = new Size(30, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new Point(27, 114);
		label5.Name = "label5";
		label5.Size = new Size(89, 16);
		label5.TabIndex = 44;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		F7050226.Location = new Point(229, 81);
		F7050226.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F7050226.Name = "nudSoLuongTo";
		F7050226.Size = new Size(56, 23);
		F7050226.TabIndex = 2;
		BF07E808.Location = new Point(132, 81);
		BF07E808.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		BF07E808.Name = "nudSoLuongFrom";
		BF07E808.Size = new Size(56, 23);
		BF07E808.TabIndex = 1;
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label3.Location = new Point(194, 83);
		label3.Name = "label3";
		label3.Size = new Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = ContentAlignment.MiddleCenter;
		C22B9AA7.AutoSize = true;
		C22B9AA7.Location = new Point(287, 83);
		C22B9AA7.Name = "label4";
		C22B9AA7.Size = new Size(28, 16);
		C22B9AA7.TabIndex = 35;
		C22B9AA7.Text = "ba\u0323n";
		label2.AutoSize = true;
		label2.Location = new Point(27, 83);
		label2.Name = "label2";
		label2.Size = new Size(63, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng:";
		D32C04BB.AutoSize = true;
		D32C04BB.Location = new Point(27, 52);
		D32C04BB.Name = "label1";
		D32C04BB.Size = new Size(98, 16);
		D32C04BB.TabIndex = 31;
		D32C04BB.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(343, 416);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 7;
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
		btnAdd.Location = new Point(236, 416);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		DD006C96.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		DD006C96.BackColor = Color.White;
		DD006C96.BorderRadius = 0;
		DD006C96.BottomSahddow = true;
		DD006C96.color = Color.DarkViolet;
		DD006C96.Controls.Add(B01A1393);
		DD006C96.LeftSahddow = false;
		DD006C96.Location = new Point(1, 0);
		DD006C96.Name = "bunifuCards1";
		DD006C96.RightSahddow = true;
		DD006C96.ShadowDepth = 20;
		DD006C96.Size = new Size(672, 37);
		DD006C96.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(675, 454);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDReport";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += C4932F90;
		B01A1393.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		panel2.ResumeLayout(performLayout: false);
		panel2.PerformLayout();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		((ISupportInitialize)F7050226).EndInit();
		((ISupportInitialize)BF07E808).EndInit();
		DD006C96.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
