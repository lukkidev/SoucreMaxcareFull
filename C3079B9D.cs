using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class C3079B9D : Form
{
	private ucTuongTacBaiViet ucTuongTacBaiViet_0;

	private F31742AD f31742AD_0;

	private GClass11 gclass11_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private IContainer F0A3CF83 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label C78CE6B2;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel EEB44CA1;

	private Button D8353ABB;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox DF283D02;

	private Panel BABA6199;

	private NumericUpDown nudDelayTo;

	private NumericUpDown EA3ED8BC;

	private Label label20;

	private Label label15;

	private GroupBox groupBox2;

	private Panel D711C130;

	private Label F62421A7;

	private NumericUpDown C0B5538C;

	private Label label23;

	private NumericUpDown nudCountPageFrom;

	private Panel E620A73E;

	private NumericUpDown FAA14233;

	private NumericUpDown nudCountGroupFrom;

	private Label A9AD5915;

	private Label B31F5B87;

	private CheckBox ckbShareBaiLenPage;

	private CheckBox A800D51B;

	private CheckBox BBAF7986;

	private Label lblLinkChiaSe;

	private CheckBox ckbOnlyShareNhomKhongKiemDuyet;

	private Label label3;

	private CheckBox ckbTuongTacNhom;

	private CheckBox DC2E5426;

	private CheckBox B6292704;

	private Panel E0387120;

	private RadioButton rbTuNhap;

	private RadioButton rbRandom;

	private Label B6204B8E;

	private ToolTip toolTip_0;

	private Panel AAA6278A;

	private RichTextBox txtNhomTuNhap;

	private CheckBox BA2401A7;

	private ComboBox F18D27BF;

	private RichTextBox F9BFD692;

	private CheckBox ckbTuongTacBaiViet;

	private ComboBox BB270C95;

	private Button btnHuongDanNhapNoiDung;

	private RichTextBox txtNoiDung;

	private Label label8;

	private Label B32FD80B;

	private LinkLabel EB23492D;

	private LinkLabel CB015296;

	private CheckBox ckbTuDongXoaNoiDung;

	private GroupBox DE3CBBBC;

	public C3079B9D(string string_3, int FABB7A03 = 0, string string_4 = "")
	{
		B503AAA7();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = FABB7A03;
		string text = base.Name.Substring(1);
		string text2 = "Share bài";
		if (Class147.smethod_7("", text).Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\",\"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (FABB7A03)
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
			DataTable dataTable = Class147.F3057616(string_4);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
		ucTuongTacBaiViet_0 = new ucTuongTacBaiViet(gclass11_0)
		{
			Visible = false
		};
		base.Controls.Add(ucTuongTacBaiViet_0);
		ucTuongTacBaiViet_0.smethod_0(bool_0: true);
		f31742AD_0 = new F31742AD(gclass11_0)
		{
			Visible = false
		};
		base.Controls.Add(f31742AD_0);
		f31742AD_0.smethod_0(bool_0: true);
	}

	private void D934FCB6(object sender, EventArgs e)
	{
		BC34FD36();
		F006F817();
		try
		{
			EA3ED8BC.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
			F9BFD692.Text = gclass11_0.C0288288("txtLinkChiaSe");
			F18D27BF.SelectedIndex = gclass11_0.method_2("cbbKieuShare");
			DF283D02.Checked = gclass11_0.method_3("ckbVanBan");
			txtNoiDung.Text = gclass11_0.C0288288("txtNoiDung");
			BB270C95.SelectedIndex = gclass11_0.method_2("typeNganCach");
			ckbTuDongXoaNoiDung.Checked = gclass11_0.method_3("ckbTuDongXoaNoiDung");
			ckbTuongTacBaiViet.Checked = gclass11_0.method_3("ckbTuongTacBaiViet");
			BBAF7986.Checked = gclass11_0.method_3("ckbShareBaiLenTuong");
			A800D51B.Checked = gclass11_0.method_3("ckbShareBaiLenNhom");
			nudCountGroupFrom.Value = gclass11_0.method_2("nudCountGroupFrom", 1);
			FAA14233.Value = gclass11_0.method_2("nudCountGroupTo", 1);
			if (gclass11_0.method_2("typeShare") == 0)
			{
				rbRandom.Checked = true;
			}
			else
			{
				rbTuNhap.Checked = true;
			}
			txtNhomTuNhap.Text = gclass11_0.C0288288("lstNhomTuNhap");
			BA2401A7.Checked = gclass11_0.method_3("ckbChiShareNhomDaThamGia");
			ckbOnlyShareNhomKhongKiemDuyet.Checked = gclass11_0.method_3("ckbOnlyShareNhomKhongKiemDuyet");
			B6292704.Checked = gclass11_0.method_3("ckbUuTienNhomNhieuThanhVien");
			DC2E5426.Checked = gclass11_0.method_3("ckbKhongShareTrung");
			ckbTuongTacNhom.Checked = gclass11_0.method_3("ckbTuongTacNhom");
			ckbShareBaiLenPage.Checked = gclass11_0.method_3("ckbShareBaiLenPage");
			nudCountPageFrom.Value = gclass11_0.method_2("nudCountPageFrom", 1);
			C0B5538C.Value = gclass11_0.method_2("nudCountPageTo", 1);
		}
		catch (Exception)
		{
		}
		F0BD9A2B();
	}

	private void BC34FD36()
	{
		List<string> list_ = new List<string> { "(www) Đăng link", "(m.fb) Đăng link", "(m.fb) Mở Link > click Chia sẻ" };
		GClass8.smethod_22(F18D27BF, list_);
	}

	private void F006F817()
	{
		List<string> list_ = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		GClass8.smethod_22(BB270C95, list_);
	}

	private void D8353ABB_Click(object sender, EventArgs e)
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
		gclass11_0.method_4("nudDelayFrom", EA3ED8BC.Value);
		gclass11_0.method_4("nudDelayTo", nudDelayTo.Value);
		gclass11_0.method_4("txtLinkChiaSe", F9BFD692.Text.Trim());
		gclass11_0.method_4("cbbKieuShare", F18D27BF.SelectedIndex);
		gclass11_0.method_4("ckbVanBan", DF283D02.Checked);
		gclass11_0.method_4("txtNoiDung", txtNoiDung.Text.Trim());
		gclass11_0.method_4("typeNganCach", BB270C95.SelectedIndex);
		gclass11_0.method_4("ckbTuDongXoaNoiDung", ckbTuDongXoaNoiDung.Checked);
		gclass11_0.method_4("ckbTuongTacBaiViet", ckbTuongTacBaiViet.Checked);
		gclass11_0.method_4("ckbShareBaiLenTuong", BBAF7986.Checked);
		gclass11_0.method_4("ckbShareBaiLenNhom", A800D51B.Checked);
		gclass11_0.method_4("nudCountGroupFrom", nudCountGroupFrom.Value);
		gclass11_0.method_4("nudCountGroupTo", FAA14233.Value);
		int num = 0;
		if (rbTuNhap.Checked)
		{
			num = 1;
		}
		gclass11_0.method_4("typeShare", num);
		gclass11_0.method_4("lstNhomTuNhap", txtNhomTuNhap.Text);
		gclass11_0.method_4("ckbChiShareNhomDaThamGia", BA2401A7.Checked);
		gclass11_0.method_4("ckbOnlyShareNhomKhongKiemDuyet", ckbOnlyShareNhomKhongKiemDuyet.Checked);
		gclass11_0.method_4("ckbUuTienNhomNhieuThanhVien", B6292704.Checked);
		gclass11_0.method_4("ckbKhongShareTrung", DC2E5426.Checked);
		gclass11_0.method_4("ckbTuongTacNhom", ckbTuongTacNhom.Checked);
		gclass11_0.method_4("ckbShareBaiLenPage", ckbShareBaiLenPage.Checked);
		gclass11_0.method_4("nudCountPageFrom", nudCountPageFrom.Value);
		gclass11_0.method_4("nudCountPageTo", C0B5538C.Value);
		string text2 = gclass11_0.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, text2))
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
			if (Class147.smethod_13(string_2, text, text2))
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

	private void DA296331(object sender, EventArgs e)
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

	private void F0BD9A2B()
	{
		A800D51B_CheckedChanged(null, null);
		ckbShareBaiLenPage_CheckedChanged(null, null);
		DF283D02_CheckedChanged(null, null);
		ckbTuongTacNhom_CheckedChanged(null, null);
		ckbTuongTacBaiViet_CheckedChanged(null, null);
		F8884695(null, null);
	}

	private void DF283D02_CheckedChanged(object sender, EventArgs e)
	{
		BABA6199.Enabled = DF283D02.Checked;
	}

	private void A800D51B_CheckedChanged(object sender, EventArgs e)
	{
		E620A73E.Enabled = A800D51B.Checked;
	}

	private void ckbShareBaiLenPage_CheckedChanged(object sender, EventArgs e)
	{
		D711C130.Enabled = ckbShareBaiLenPage.Checked;
	}

	private void ckbTuongTacNhom_CheckedChanged(object sender, EventArgs e)
	{
		CB015296.Enabled = ckbTuongTacNhom.Checked;
	}

	private void F8884695(object sender, EventArgs e)
	{
		AAA6278A.Enabled = rbTuNhap.Checked;
		if (rbTuNhap.Checked)
		{
			if (!BA2401A7.Checked)
			{
				ckbOnlyShareNhomKhongKiemDuyet.Checked = false;
				ckbOnlyShareNhomKhongKiemDuyet.Enabled = false;
				B6292704.Checked = false;
				B6292704.Enabled = false;
			}
		}
		else
		{
			ckbOnlyShareNhomKhongKiemDuyet.Enabled = true;
			B6292704.Enabled = true;
		}
	}

	private void F5A16495(object sender, EventArgs e)
	{
		GClass8.E814B702(sender as RichTextBox, rbTuNhap);
	}

	private void BA2401A7_CheckedChanged(object sender, EventArgs e)
	{
		if (!BA2401A7.Checked)
		{
			ckbOnlyShareNhomKhongKiemDuyet.Checked = false;
			ckbOnlyShareNhomKhongKiemDuyet.Enabled = false;
			B6292704.Checked = false;
			B6292704.Enabled = false;
		}
		else
		{
			ckbOnlyShareNhomKhongKiemDuyet.Enabled = true;
			B6292704.Enabled = true;
		}
	}

	private void F9BFD692_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(F9BFD692, lblLinkChiaSe);
	}

	private void A208583C(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtNoiDung, B32FD80B, BB270C95.SelectedIndex);
	}

	private void btnHuongDanNhapNoiDung_Click(object sender, EventArgs e)
	{
		if (BB270C95.SelectedIndex == 0)
		{
			GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			GClass8.smethod_33(new fHelpNhapComment());
		}
		txtNoiDung.Focus();
	}

	private void method_0(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.smethod_33(new E3962B82());
	}

	private void ckbTuongTacBaiViet_CheckedChanged(object sender, EventArgs e)
	{
		EB23492D.Enabled = ckbTuongTacBaiViet.Checked;
	}

	private void EB23492D_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.BFBFBD05(ucTuongTacBaiViet_0, this);
	}

	private void CB015296_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.BFBFBD05(f31742AD_0, this);
	}

	private void F788C4BC(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtNoiDung, B32FD80B, BB270C95.SelectedIndex);
	}

	private void B984A02E(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool B0B34FB0)
	{
		if (B0B34FB0 && F0A3CF83 != null)
		{
			F0A3CF83.Dispose();
		}
		base.Dispose(B0B34FB0);
	}

	private void B503AAA7()
	{
		F0A3CF83 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(C3079B9D));
		bunifuDragControl_0 = new BunifuDragControl(F0A3CF83);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(F0A3CF83);
		EEB44CA1 = new Panel();
		D8353ABB = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		DE3CBBBC = new GroupBox();
		lblLinkChiaSe = new Label();
		ckbTuongTacBaiViet = new CheckBox();
		DF283D02 = new CheckBox();
		F9BFD692 = new RichTextBox();
		BABA6199 = new Panel();
		ckbTuDongXoaNoiDung = new CheckBox();
		BB270C95 = new ComboBox();
		btnHuongDanNhapNoiDung = new Button();
		txtNoiDung = new RichTextBox();
		label8 = new Label();
		B32FD80B = new Label();
		EB23492D = new LinkLabel();
		label3 = new Label();
		F18D27BF = new ComboBox();
		groupBox2 = new GroupBox();
		D711C130 = new Panel();
		F62421A7 = new Label();
		C0B5538C = new NumericUpDown();
		label23 = new Label();
		nudCountPageFrom = new NumericUpDown();
		E620A73E = new Panel();
		DC2E5426 = new CheckBox();
		B6292704 = new CheckBox();
		CB015296 = new LinkLabel();
		ckbOnlyShareNhomKhongKiemDuyet = new CheckBox();
		E0387120 = new Panel();
		AAA6278A = new Panel();
		txtNhomTuNhap = new RichTextBox();
		BA2401A7 = new CheckBox();
		rbTuNhap = new RadioButton();
		rbRandom = new RadioButton();
		B6204B8E = new Label();
		FAA14233 = new NumericUpDown();
		ckbTuongTacNhom = new CheckBox();
		nudCountGroupFrom = new NumericUpDown();
		A9AD5915 = new Label();
		B31F5B87 = new Label();
		ckbShareBaiLenPage = new CheckBox();
		A800D51B = new CheckBox();
		BBAF7986 = new CheckBox();
		nudDelayTo = new NumericUpDown();
		EA3ED8BC = new NumericUpDown();
		label20 = new Label();
		label15 = new Label();
		btnAdd = new Button();
		txtTenHanhDong = new TextBox();
		C78CE6B2 = new Label();
		btnCancel = new Button();
		bunifuCards1 = new BunifuCards();
		toolTip_0 = new ToolTip(F0A3CF83);
		EEB44CA1.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		DE3CBBBC.SuspendLayout();
		BABA6199.SuspendLayout();
		groupBox2.SuspendLayout();
		D711C130.SuspendLayout();
		((ISupportInitialize)C0B5538C).BeginInit();
		((ISupportInitialize)nudCountPageFrom).BeginInit();
		E620A73E.SuspendLayout();
		E0387120.SuspendLayout();
		AAA6278A.SuspendLayout();
		((ISupportInitialize)FAA14233).BeginInit();
		((ISupportInitialize)nudCountGroupFrom).BeginInit();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)EA3ED8BC).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(738, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Share bài";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = EEB44CA1;
		bunifuDragControl_1.Vertical = true;
		EEB44CA1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		EEB44CA1.BackColor = Color.White;
		EEB44CA1.Controls.Add(D8353ABB);
		EEB44CA1.Controls.Add(pictureBox1);
		EEB44CA1.Controls.Add(bunifuCustomLabel1);
		EEB44CA1.Cursor = Cursors.SizeAll;
		EEB44CA1.Location = new Point(0, 3);
		EEB44CA1.Name = "pnlHeader";
		EEB44CA1.Size = new Size(738, 31);
		EEB44CA1.TabIndex = 9;
		D8353ABB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		D8353ABB.Cursor = Cursors.Hand;
		D8353ABB.FlatAppearance.BorderSize = 0;
		D8353ABB.FlatStyle = FlatStyle.Flat;
		D8353ABB.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		D8353ABB.ForeColor = Color.White;
		D8353ABB.Image = (Image)componentResourceManager.GetObject("button1.Image");
		D8353ABB.Location = new Point(707, 1);
		D8353ABB.Name = "button1";
		D8353ABB.Size = new Size(30, 30);
		D8353ABB.TabIndex = 0;
		D8353ABB.TextImageRelation = TextImageRelation.ImageBeforeText;
		D8353ABB.UseVisualStyleBackColor = true;
		D8353ABB.Click += D8353ABB_Click;
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
		panel1.Controls.Add(DE3CBBBC);
		panel1.Controls.Add(groupBox2);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(EA3ED8BC);
		panel1.Controls.Add(label20);
		panel1.Controls.Add(label15);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(C78CE6B2);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(741, 565);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		DE3CBBBC.Controls.Add(BABA6199);
		DE3CBBBC.Controls.Add(lblLinkChiaSe);
		DE3CBBBC.Controls.Add(ckbTuongTacBaiViet);
		DE3CBBBC.Controls.Add(DF283D02);
		DE3CBBBC.Controls.Add(F9BFD692);
		DE3CBBBC.Controls.Add(EB23492D);
		DE3CBBBC.Controls.Add(label3);
		DE3CBBBC.Controls.Add(F18D27BF);
		DE3CBBBC.Location = new Point(33, 105);
		DE3CBBBC.Name = "groupBox1";
		DE3CBBBC.Size = new Size(354, 410);
		DE3CBBBC.TabIndex = 184;
		DE3CBBBC.TabStop = false;
		DE3CBBBC.Text = "Nội dung";
		lblLinkChiaSe.AutoSize = true;
		lblLinkChiaSe.Location = new Point(11, 21);
		lblLinkChiaSe.Name = "lblLinkChiaSe";
		lblLinkChiaSe.Size = new Size(136, 16);
		lblLinkChiaSe.TabIndex = 64;
		lblLinkChiaSe.Text = "Link bài cần share (0):";
		ckbTuongTacBaiViet.AutoSize = true;
		ckbTuongTacBaiViet.Cursor = Cursors.Hand;
		ckbTuongTacBaiViet.Location = new Point(34, 384);
		ckbTuongTacBaiViet.Name = "ckbTuongTacBaiViet";
		ckbTuongTacBaiViet.Size = new Size(219, 20);
		ckbTuongTacBaiViet.TabIndex = 107;
		ckbTuongTacBaiViet.Text = "Tương ta\u0301c bài viết trươ\u0301c khi share";
		ckbTuongTacBaiViet.UseVisualStyleBackColor = true;
		ckbTuongTacBaiViet.CheckedChanged += ckbTuongTacBaiViet_CheckedChanged;
		DF283D02.AutoSize = true;
		DF283D02.Cursor = Cursors.Hand;
		DF283D02.Location = new Point(14, 151);
		DF283D02.Name = "ckbVanBan";
		DF283D02.Size = new Size(76, 20);
		DF283D02.TabIndex = 32;
		DF283D02.Text = "Nội dung";
		DF283D02.UseVisualStyleBackColor = true;
		DF283D02.CheckedChanged += DF283D02_CheckedChanged;
		F9BFD692.BorderStyle = BorderStyle.FixedSingle;
		F9BFD692.Location = new Point(14, 39);
		F9BFD692.Name = "txtLinkChiaSe";
		F9BFD692.Size = new Size(331, 108);
		F9BFD692.TabIndex = 34;
		F9BFD692.Text = "";
		F9BFD692.WordWrap = false;
		F9BFD692.TextChanged += F9BFD692_TextChanged;
		BABA6199.BorderStyle = BorderStyle.FixedSingle;
		BABA6199.Controls.Add(ckbTuDongXoaNoiDung);
		BABA6199.Controls.Add(BB270C95);
		BABA6199.Controls.Add(btnHuongDanNhapNoiDung);
		BABA6199.Controls.Add(txtNoiDung);
		BABA6199.Controls.Add(label8);
		BABA6199.Controls.Add(B32FD80B);
		BABA6199.Location = new Point(33, 173);
		BABA6199.Name = "plVanBan";
		BABA6199.Size = new Size(312, 231);
		BABA6199.TabIndex = 33;
		ckbTuDongXoaNoiDung.Anchor = AnchorStyles.Bottom;
		ckbTuDongXoaNoiDung.AutoSize = true;
		ckbTuDongXoaNoiDung.Cursor = Cursors.Hand;
		ckbTuDongXoaNoiDung.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		ckbTuDongXoaNoiDung.Location = new Point(7, 207);
		ckbTuDongXoaNoiDung.Name = "ckbTuDongXoaNoiDung";
		ckbTuDongXoaNoiDung.Size = new Size(169, 20);
		ckbTuDongXoaNoiDung.TabIndex = 197;
		ckbTuDongXoaNoiDung.Text = "Xóa nội dung đã sử dụng";
		ckbTuDongXoaNoiDung.UseVisualStyleBackColor = true;
		BB270C95.Anchor = AnchorStyles.Bottom;
		BB270C95.Cursor = Cursors.Hand;
		BB270C95.DropDownStyle = ComboBoxStyle.DropDownList;
		BB270C95.FormattingEnabled = true;
		BB270C95.Location = new Point(81, 179);
		BB270C95.Name = "cbbTuyChonNoiDung";
		BB270C95.Size = new Size(190, 24);
		BB270C95.TabIndex = 184;
		BB270C95.SelectedIndexChanged += F788C4BC;
		btnHuongDanNhapNoiDung.Anchor = AnchorStyles.Bottom;
		btnHuongDanNhapNoiDung.Cursor = Cursors.Hand;
		btnHuongDanNhapNoiDung.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnHuongDanNhapNoiDung.Location = new Point(277, 178);
		btnHuongDanNhapNoiDung.Name = "btnHuongDanNhapNoiDung";
		btnHuongDanNhapNoiDung.Size = new Size(26, 26);
		btnHuongDanNhapNoiDung.TabIndex = 182;
		btnHuongDanNhapNoiDung.Text = "?";
		btnHuongDanNhapNoiDung.UseVisualStyleBackColor = true;
		btnHuongDanNhapNoiDung.Click += btnHuongDanNhapNoiDung_Click;
		txtNoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		txtNoiDung.Location = new Point(7, 24);
		txtNoiDung.Name = "txtNoiDung";
		txtNoiDung.Size = new Size(297, 149);
		txtNoiDung.TabIndex = 180;
		txtNoiDung.Text = "";
		txtNoiDung.WordWrap = false;
		txtNoiDung.TextChanged += A208583C;
		label8.Anchor = AnchorStyles.Bottom;
		label8.AutoSize = true;
		label8.Location = new Point(4, 182);
		label8.Name = "label8";
		label8.Size = new Size(64, 16);
		label8.TabIndex = 181;
		label8.Text = "Tùy chọn:";
		B32FD80B.AutoSize = true;
		B32FD80B.Location = new Point(3, 4);
		B32FD80B.Name = "lblNoiDung";
		B32FD80B.Size = new Size(83, 16);
		B32FD80B.TabIndex = 179;
		B32FD80B.Text = "Nội dung (0):";
		EB23492D.AutoSize = true;
		EB23492D.Cursor = Cursors.Hand;
		EB23492D.Location = new Point(249, 385);
		EB23492D.Name = "lblCaiDatTuongTacBaiViet";
		EB23492D.Size = new Size(47, 16);
		EB23492D.TabIndex = 183;
		EB23492D.TabStop = true;
		EB23492D.Text = "Cài đặt";
		EB23492D.LinkClicked += EB23492D_LinkClicked;
		label3.AutoSize = true;
		label3.Location = new Point(11, 126);
		label3.Name = "label3";
		label3.Size = new Size(72, 16);
		label3.TabIndex = 66;
		label3.Text = "Kiểu share:";
		F18D27BF.Cursor = Cursors.Hand;
		F18D27BF.DropDownStyle = ComboBoxStyle.DropDownList;
		F18D27BF.FormattingEnabled = true;
		F18D27BF.Location = new Point(89, 123);
		F18D27BF.Name = "cbbKieuShare";
		F18D27BF.Size = new Size(256, 24);
		F18D27BF.TabIndex = 106;
		F18D27BF.SelectedIndexChanged += B984A02E;
		groupBox2.Controls.Add(D711C130);
		groupBox2.Controls.Add(E620A73E);
		groupBox2.Controls.Add(ckbShareBaiLenPage);
		groupBox2.Controls.Add(A800D51B);
		groupBox2.Controls.Add(BBAF7986);
		groupBox2.Location = new Point(393, 105);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new Size(311, 410);
		groupBox2.TabIndex = 62;
		groupBox2.TabStop = false;
		groupBox2.Text = "Tùy chọn";
		D711C130.BorderStyle = BorderStyle.FixedSingle;
		D711C130.Controls.Add(F62421A7);
		D711C130.Controls.Add(C0B5538C);
		D711C130.Controls.Add(label23);
		D711C130.Controls.Add(nudCountPageFrom);
		D711C130.Location = new Point(33, 447);
		D711C130.Name = "plDangBaiLenPage";
		D711C130.Size = new Size(270, 27);
		D711C130.TabIndex = 1;
		F62421A7.AutoSize = true;
		F62421A7.Location = new Point(3, 3);
		F62421A7.Name = "label21";
		F62421A7.Size = new Size(95, 16);
		F62421A7.TabIndex = 49;
		F62421A7.Text = "Số lượng page:";
		C0B5538C.Location = new Point(187, 1);
		C0B5538C.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C0B5538C.Name = "nudCountPageTo";
		C0B5538C.Size = new Size(56, 23);
		C0B5538C.TabIndex = 48;
		label23.AutoSize = true;
		label23.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label23.Location = new Point(166, 3);
		label23.Name = "label23";
		label23.Size = new Size(18, 16);
		label23.TabIndex = 51;
		label23.Text = ">";
		nudCountPageFrom.Location = new Point(108, 1);
		nudCountPageFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountPageFrom.Name = "nudCountPageFrom";
		nudCountPageFrom.Size = new Size(56, 23);
		nudCountPageFrom.TabIndex = 47;
		E620A73E.BorderStyle = BorderStyle.FixedSingle;
		E620A73E.Controls.Add(DC2E5426);
		E620A73E.Controls.Add(B6292704);
		E620A73E.Controls.Add(CB015296);
		E620A73E.Controls.Add(ckbOnlyShareNhomKhongKiemDuyet);
		E620A73E.Controls.Add(E0387120);
		E620A73E.Controls.Add(B6204B8E);
		E620A73E.Controls.Add(FAA14233);
		E620A73E.Controls.Add(ckbTuongTacNhom);
		E620A73E.Controls.Add(nudCountGroupFrom);
		E620A73E.Controls.Add(A9AD5915);
		E620A73E.Controls.Add(B31F5B87);
		E620A73E.Location = new Point(33, 70);
		E620A73E.Name = "plDangBaiLenNhom";
		E620A73E.Size = new Size(270, 334);
		E620A73E.TabIndex = 1;
		DC2E5426.AutoSize = true;
		DC2E5426.Cursor = Cursors.Hand;
		DC2E5426.Location = new Point(6, 281);
		DC2E5426.Name = "ckbKhongShareTrung";
		DC2E5426.Size = new Size(167, 20);
		DC2E5426.TabIndex = 2;
		DC2E5426.Text = "Không share trùng nhóm";
		DC2E5426.UseVisualStyleBackColor = true;
		B6292704.AutoSize = true;
		B6292704.Cursor = Cursors.Hand;
		B6292704.Location = new Point(6, 255);
		B6292704.Name = "ckbUuTienNhomNhieuThanhVien";
		B6292704.Size = new Size(254, 20);
		B6292704.TabIndex = 1;
		B6292704.Text = "Ưu tiên share nhóm có nhiều thành viên";
		B6292704.UseVisualStyleBackColor = true;
		CB015296.AutoSize = true;
		CB015296.Cursor = Cursors.Hand;
		CB015296.Location = new Point(213, 308);
		CB015296.Name = "lblTuongTacNhom";
		CB015296.Size = new Size(47, 16);
		CB015296.TabIndex = 183;
		CB015296.TabStop = true;
		CB015296.Text = "Cài đặt";
		CB015296.LinkClicked += CB015296_LinkClicked;
		ckbOnlyShareNhomKhongKiemDuyet.AutoSize = true;
		ckbOnlyShareNhomKhongKiemDuyet.Cursor = Cursors.Hand;
		ckbOnlyShareNhomKhongKiemDuyet.Location = new Point(6, 229);
		ckbOnlyShareNhomKhongKiemDuyet.Name = "ckbOnlyShareNhomKhongKiemDuyet";
		ckbOnlyShareNhomKhongKiemDuyet.Size = new Size(220, 20);
		ckbOnlyShareNhomKhongKiemDuyet.TabIndex = 0;
		ckbOnlyShareNhomKhongKiemDuyet.Text = "Chỉ share nhóm không kiểm duyệt";
		ckbOnlyShareNhomKhongKiemDuyet.UseVisualStyleBackColor = true;
		E0387120.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		E0387120.BorderStyle = BorderStyle.FixedSingle;
		E0387120.Controls.Add(AAA6278A);
		E0387120.Controls.Add(rbTuNhap);
		E0387120.Controls.Add(rbRandom);
		E0387120.Location = new Point(6, 52);
		E0387120.Name = "panel3";
		E0387120.Size = new Size(257, 171);
		E0387120.TabIndex = 67;
		AAA6278A.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		AAA6278A.BorderStyle = BorderStyle.FixedSingle;
		AAA6278A.Controls.Add(txtNhomTuNhap);
		AAA6278A.Controls.Add(BA2401A7);
		AAA6278A.Location = new Point(22, 49);
		AAA6278A.Name = "plTuNhap";
		AAA6278A.Size = new Size(230, 117);
		AAA6278A.TabIndex = 193;
		txtNhomTuNhap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		txtNhomTuNhap.Location = new Point(3, 3);
		txtNhomTuNhap.Name = "txtNhomTuNhap";
		txtNhomTuNhap.Size = new Size(222, 88);
		txtNhomTuNhap.TabIndex = 34;
		txtNhomTuNhap.Text = "";
		txtNhomTuNhap.WordWrap = false;
		txtNhomTuNhap.TextChanged += F5A16495;
		BA2401A7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		BA2401A7.AutoSize = true;
		BA2401A7.Cursor = Cursors.Hand;
		BA2401A7.Location = new Point(3, 92);
		BA2401A7.Name = "ckbChiShareNhomDaThamGia";
		BA2401A7.Size = new Size(190, 20);
		BA2401A7.TabIndex = 33;
		BA2401A7.Text = "Chỉ Share nhóm đã tham gia";
		BA2401A7.UseVisualStyleBackColor = true;
		BA2401A7.CheckedChanged += BA2401A7_CheckedChanged;
		rbTuNhap.AutoSize = true;
		rbTuNhap.Cursor = Cursors.Hand;
		rbTuNhap.Location = new Point(3, 27);
		rbTuNhap.Name = "rbTuNhap";
		rbTuNhap.Size = new Size(197, 20);
		rbTuNhap.TabIndex = 1;
		rbTuNhap.Text = "Nhóm do người dùng nhập (0)";
		rbTuNhap.UseVisualStyleBackColor = true;
		rbTuNhap.CheckedChanged += F8884695;
		rbRandom.AutoSize = true;
		rbRandom.Checked = true;
		rbRandom.Cursor = Cursors.Hand;
		rbRandom.Location = new Point(3, 3);
		rbRandom.Name = "rbRandom";
		rbRandom.Size = new Size(197, 20);
		rbRandom.TabIndex = 0;
		rbRandom.TabStop = true;
		rbRandom.Text = "Ngẫu nhiên nhóm đã tham gia";
		rbRandom.UseVisualStyleBackColor = true;
		B6204B8E.AutoSize = true;
		B6204B8E.Location = new Point(3, 31);
		B6204B8E.Name = "label11";
		B6204B8E.Size = new Size(100, 16);
		B6204B8E.TabIndex = 66;
		B6204B8E.Text = "Tùy chọn nhóm:";
		FAA14233.Location = new Point(187, 4);
		FAA14233.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		FAA14233.Name = "nudCountGroupTo";
		FAA14233.Size = new Size(56, 23);
		FAA14233.TabIndex = 53;
		ckbTuongTacNhom.AutoSize = true;
		ckbTuongTacNhom.Cursor = Cursors.Hand;
		ckbTuongTacNhom.Location = new Point(6, 307);
		ckbTuongTacNhom.Name = "ckbTuongTacNhom";
		ckbTuongTacNhom.Size = new Size(210, 20);
		ckbTuongTacNhom.TabIndex = 57;
		ckbTuongTacNhom.Text = "Tương tác nhóm trước khi share";
		ckbTuongTacNhom.UseVisualStyleBackColor = true;
		ckbTuongTacNhom.CheckedChanged += ckbTuongTacNhom_CheckedChanged;
		nudCountGroupFrom.Location = new Point(108, 4);
		nudCountGroupFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountGroupFrom.Name = "nudCountGroupFrom";
		nudCountGroupFrom.Size = new Size(56, 23);
		nudCountGroupFrom.TabIndex = 52;
		A9AD5915.AutoSize = true;
		A9AD5915.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		A9AD5915.Location = new Point(166, 6);
		A9AD5915.Name = "label24";
		A9AD5915.Size = new Size(18, 16);
		A9AD5915.TabIndex = 56;
		A9AD5915.Text = ">";
		B31F5B87.AutoSize = true;
		B31F5B87.Location = new Point(3, 6);
		B31F5B87.Name = "label26";
		B31F5B87.Size = new Size(99, 16);
		B31F5B87.TabIndex = 54;
		B31F5B87.Text = "Số lượng nhóm:";
		ckbShareBaiLenPage.AutoSize = true;
		ckbShareBaiLenPage.Cursor = Cursors.Hand;
		ckbShareBaiLenPage.Location = new Point(10, 425);
		ckbShareBaiLenPage.Name = "ckbShareBaiLenPage";
		ckbShareBaiLenPage.Size = new Size(134, 20);
		ckbShareBaiLenPage.TabIndex = 0;
		ckbShareBaiLenPage.Text = "Share bài lên page";
		ckbShareBaiLenPage.UseVisualStyleBackColor = true;
		ckbShareBaiLenPage.CheckedChanged += ckbShareBaiLenPage_CheckedChanged;
		A800D51B.AutoSize = true;
		A800D51B.Cursor = Cursors.Hand;
		A800D51B.Location = new Point(10, 46);
		A800D51B.Name = "ckbShareBaiLenNhom";
		A800D51B.Size = new Size(138, 20);
		A800D51B.TabIndex = 0;
		A800D51B.Text = "Share bài lên nhóm";
		A800D51B.UseVisualStyleBackColor = true;
		A800D51B.CheckedChanged += A800D51B_CheckedChanged;
		BBAF7986.AutoSize = true;
		BBAF7986.Cursor = Cursors.Hand;
		BBAF7986.Location = new Point(10, 20);
		BBAF7986.Name = "ckbShareBaiLenTuong";
		BBAF7986.Size = new Size(139, 20);
		BBAF7986.TabIndex = 0;
		BBAF7986.Text = "Share bài lên tường";
		BBAF7986.UseVisualStyleBackColor = true;
		nudDelayTo.Location = new Point(220, 76);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 58;
		EA3ED8BC.Location = new Point(134, 76);
		EA3ED8BC.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		EA3ED8BC.Name = "nudDelayFrom";
		EA3ED8BC.Size = new Size(56, 23);
		EA3ED8BC.TabIndex = 57;
		label20.AutoSize = true;
		label20.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label20.Location = new Point(196, 78);
		label20.Name = "label20";
		label20.Size = new Size(18, 16);
		label20.TabIndex = 61;
		label20.Text = ">";
		label15.AutoSize = true;
		label15.Location = new Point(30, 78);
		label15.Name = "label15";
		label15.Size = new Size(87, 16);
		label15.TabIndex = 59;
		label15.Text = "Gia\u0303n ca\u0301ch (s):";
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(295, 523);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		txtTenHanhDong.Location = new Point(134, 47);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(142, 23);
		txtTenHanhDong.TabIndex = 0;
		C78CE6B2.AutoSize = true;
		C78CE6B2.Location = new Point(30, 50);
		C78CE6B2.Name = "label1";
		C78CE6B2.Size = new Size(98, 16);
		C78CE6B2.TabIndex = 31;
		C78CE6B2.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(393, 523);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += DA296331;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(EEB44CA1);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(738, 37);
		bunifuCards1.TabIndex = 28;
		toolTip_0.AutomaticDelay = 100;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(741, 565);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDShareBai";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += D934FCB6;
		EEB44CA1.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		DE3CBBBC.ResumeLayout(performLayout: false);
		DE3CBBBC.PerformLayout();
		BABA6199.ResumeLayout(performLayout: false);
		BABA6199.PerformLayout();
		groupBox2.ResumeLayout(performLayout: false);
		groupBox2.PerformLayout();
		D711C130.ResumeLayout(performLayout: false);
		D711C130.PerformLayout();
		((ISupportInitialize)C0B5538C).EndInit();
		((ISupportInitialize)nudCountPageFrom).EndInit();
		E620A73E.ResumeLayout(performLayout: false);
		E620A73E.PerformLayout();
		E0387120.ResumeLayout(performLayout: false);
		E0387120.PerformLayout();
		AAA6278A.ResumeLayout(performLayout: false);
		AAA6278A.PerformLayout();
		((ISupportInitialize)FAA14233).EndInit();
		((ISupportInitialize)nudCountGroupFrom).EndInit();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)EA3ED8BC).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
