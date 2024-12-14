using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDBaiVietNhom : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string AB2B1D29;

	private string D3375B8F;

	private int E0090A9F;

	public static bool bool_0;

	private EFBBE9AB B7290081;

	private IContainer C024582A = null;

	private BunifuDragControl D78EDE15;

	private BunifuDragControl E63AE581;

	private Panel panel1;

	private TextBox E423351A;

	private Label label1;

	private Button C9A51A1F;

	private Button btnAdd;

	private BunifuCards B014E30F;

	private Panel pnlHeader;

	private Button E68C4E9B;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label FDA5ED89;

	private NumericUpDown nudSoLuongNhomFrom;

	private NumericUpDown E49F2F91;

	private Label label66;

	private CheckBox F7932309;

	private CheckBox C2A4BC16;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label5;

	private Panel E4A2B7B8;

	private Panel B79754B7;

	private TabControl CFA7AC37;

	private TabPage F38D5AA8;

	private Label label19;

	private Label label3;

	private NumericUpDown E71CC1AC;

	private NumericUpDown C327498C;

	private TabPage tabPage2;

	private Label label8;

	private Label label9;

	private NumericUpDown nudThoiGianFrom;

	private NumericUpDown nudThoiGianTo;

	private ComboBox C80AC12E;

	private Label B5033784;

	public fHDBaiVietNhom(string B19F86B5, int int_0 = 0, string string_1 = "")
	{
		F707D1AB();
		bool_0 = false;
		string_0 = B19F86B5;
		D3375B8F = string_1;
		E0090A9F = int_0;
		string string_2 = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDBaiVietNhom");
			AB2B1D29 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			E423351A.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_1);
			string_2 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			E423351A.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(string_2, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void fHDBaiVietNhom_Load(object sender, EventArgs e)
	{
		C392CE93();
		try
		{
			nudSoLuongNhomFrom.Value = gclass11_0.method_2("nudSoLuongNhomFrom", 1);
			E49F2F91.Value = gclass11_0.method_2("nudSoLuongNhomTo", 1);
			C80AC12E.SelectedIndex = gclass11_0.method_2("cbbOptionsPost");
			E71CC1AC.Value = gclass11_0.method_2("nudSoLuongBaiVietFrom", 1);
			C327498C.Value = gclass11_0.method_2("nudSoLuongBaiVietTo", 2);
			nudThoiGianFrom.Value = gclass11_0.method_2("nudThoiGianFrom", 30);
			nudThoiGianTo.Value = gclass11_0.method_2("nudThoiGianTo", 30);
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
			B7290081 = new EFBBE9AB(gclass11_0);
			E4A2B7B8.Controls.Add(B7290081);
			C2A4BC16.Checked = gclass11_0.method_3("ckbKhongCommentTrungBaiCu");
			F7932309.Checked = gclass11_0.method_3("ckbNangCao");
		}
		catch
		{
		}
	}

	private void C392CE93()
	{
		List<string> list_ = new List<string> { "Giơ\u0301i ha\u0323n sô\u0301 ba\u0300i viê\u0301t tương ta\u0301c", "Giơ\u0301i ha\u0323n thơ\u0300i gian tương ta\u0301c" };
		GClass8.smethod_22(C80AC12E, list_);
	}

	private void E68C4E9B_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C225C4AF(object sender, EventArgs e)
	{
		string text = E423351A.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = B7290081.F0B0B700();
		gClass.method_4("nudSoLuongNhomFrom", nudSoLuongNhomFrom.Value);
		gClass.method_4("nudSoLuongNhomTo", E49F2F91.Value);
		gClass.method_4("cbbOptionsPost", C80AC12E.SelectedIndex);
		gClass.method_4("nudSoLuongBaiVietFrom", E71CC1AC.Value);
		gClass.method_4("nudSoLuongBaiVietTo", C327498C.Value);
		gClass.method_4("nudThoiGianFrom", nudThoiGianFrom.Value);
		gClass.method_4("nudThoiGianTo", nudThoiGianTo.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		string text2 = gClass.method_7();
		if (E0090A9F == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, AB2B1D29, text2))
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
			if (Class147.smethod_13(D3375B8F, text, text2))
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

	private void C9A51A1F_Click(object sender, EventArgs e)
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

	private void FEABCF1C(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
		}
	}

	private void AFABA43C(object sender, EventArgs e)
	{
		CFA7AC37.SelectedIndex = C80AC12E.SelectedIndex;
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && C024582A != null)
		{
			C024582A.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void F707D1AB()
	{
		C024582A = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDBaiVietNhom));
		D78EDE15 = new BunifuDragControl(C024582A);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		E63AE581 = new BunifuDragControl(C024582A);
		pnlHeader = new Panel();
		E68C4E9B = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		E4A2B7B8 = new Panel();
		nudDelayTo = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		label7 = new Label();
		label5 = new Label();
		C2A4BC16 = new CheckBox();
		F7932309 = new CheckBox();
		FDA5ED89 = new Label();
		nudSoLuongNhomFrom = new NumericUpDown();
		E49F2F91 = new NumericUpDown();
		label66 = new Label();
		E423351A = new TextBox();
		label1 = new Label();
		C9A51A1F = new Button();
		btnAdd = new Button();
		B014E30F = new BunifuCards();
		B79754B7 = new Panel();
		CFA7AC37 = new TabControl();
		F38D5AA8 = new TabPage();
		label19 = new Label();
		label3 = new Label();
		E71CC1AC = new NumericUpDown();
		C327498C = new NumericUpDown();
		tabPage2 = new TabPage();
		label8 = new Label();
		label9 = new Label();
		nudThoiGianFrom = new NumericUpDown();
		nudThoiGianTo = new NumericUpDown();
		C80AC12E = new ComboBox();
		B5033784 = new Label();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		((ISupportInitialize)nudSoLuongNhomFrom).BeginInit();
		((ISupportInitialize)E49F2F91).BeginInit();
		B014E30F.SuspendLayout();
		B79754B7.SuspendLayout();
		CFA7AC37.SuspendLayout();
		F38D5AA8.SuspendLayout();
		((ISupportInitialize)E71CC1AC).BeginInit();
		((ISupportInitialize)C327498C).BeginInit();
		tabPage2.SuspendLayout();
		((ISupportInitialize)nudThoiGianFrom).BeginInit();
		((ISupportInitialize)nudThoiGianTo).BeginInit();
		SuspendLayout();
		D78EDE15.Fixed = true;
		D78EDE15.Horizontal = true;
		D78EDE15.TargetControl = bunifuCustomLabel1;
		D78EDE15.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(716, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Bài viết Nhóm";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		E63AE581.Fixed = true;
		E63AE581.Horizontal = true;
		E63AE581.TargetControl = pnlHeader;
		E63AE581.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(E68C4E9B);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(716, 31);
		pnlHeader.TabIndex = 9;
		E68C4E9B.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		E68C4E9B.Cursor = Cursors.Hand;
		E68C4E9B.FlatAppearance.BorderSize = 0;
		E68C4E9B.FlatStyle = FlatStyle.Flat;
		E68C4E9B.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		E68C4E9B.ForeColor = Color.White;
		E68C4E9B.Image = (Image)componentResourceManager.GetObject("button1.Image");
		E68C4E9B.Location = new Point(685, 1);
		E68C4E9B.Name = "button1";
		E68C4E9B.Size = new Size(30, 30);
		E68C4E9B.TabIndex = 77;
		E68C4E9B.TextImageRelation = TextImageRelation.ImageBeforeText;
		E68C4E9B.UseVisualStyleBackColor = true;
		E68C4E9B.Click += E68C4E9B_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += FEABCF1C;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(B79754B7);
		panel1.Controls.Add(C80AC12E);
		panel1.Controls.Add(B5033784);
		panel1.Controls.Add(E4A2B7B8);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(C2A4BC16);
		panel1.Controls.Add(F7932309);
		panel1.Controls.Add(FDA5ED89);
		panel1.Controls.Add(nudSoLuongNhomFrom);
		panel1.Controls.Add(E49F2F91);
		panel1.Controls.Add(label66);
		panel1.Controls.Add(E423351A);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(C9A51A1F);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(B014E30F);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(719, 518);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		E4A2B7B8.BorderStyle = BorderStyle.FixedSingle;
		E4A2B7B8.Location = new Point(30, 195);
		E4A2B7B8.Name = "plTuongTacBaiViet";
		E4A2B7B8.Size = new Size(657, 266);
		E4A2B7B8.TabIndex = 203;
		nudDelayTo.Location = new Point(236, 166);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 200;
		nudDelayFrom.Location = new Point(139, 166);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 199;
		label7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label7.Location = new Point(201, 168);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 202;
		label7.Text = ">";
		label7.TextAlign = ContentAlignment.MiddleCenter;
		label5.AutoSize = true;
		label5.Location = new Point(27, 168);
		label5.Name = "label5";
		label5.Size = new Size(87, 16);
		label5.TabIndex = 201;
		label5.Text = "Gia\u0303n ca\u0301ch (s):";
		C2A4BC16.AutoSize = true;
		C2A4BC16.Cursor = Cursors.Hand;
		C2A4BC16.Location = new Point(30, 532);
		C2A4BC16.Name = "ckbKhongCommentTrungBaiCu";
		C2A4BC16.Size = new Size(152, 20);
		C2A4BC16.TabIndex = 169;
		C2A4BC16.Text = "Không comment trùng";
		C2A4BC16.UseVisualStyleBackColor = true;
		F7932309.AutoSize = true;
		F7932309.Cursor = Cursors.Hand;
		F7932309.Location = new Point(30, 558);
		F7932309.Name = "ckbNangCao";
		F7932309.Size = new Size(129, 20);
		F7932309.TabIndex = 168;
		F7932309.Text = "Random nâng cao";
		F7932309.UseVisualStyleBackColor = true;
		FDA5ED89.AutoSize = true;
		FDA5ED89.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		FDA5ED89.Location = new Point(27, 80);
		FDA5ED89.Name = "label49";
		FDA5ED89.Size = new Size(99, 16);
		FDA5ED89.TabIndex = 92;
		FDA5ED89.Text = "Sô\u0301 lươ\u0323ng nhóm:";
		nudSoLuongNhomFrom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		nudSoLuongNhomFrom.Location = new Point(139, 78);
		nudSoLuongNhomFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongNhomFrom.Name = "nudSoLuongNhomFrom";
		nudSoLuongNhomFrom.Size = new Size(56, 23);
		nudSoLuongNhomFrom.TabIndex = 1;
		nudSoLuongNhomFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		E49F2F91.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		E49F2F91.Location = new Point(236, 78);
		E49F2F91.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		E49F2F91.Name = "nudSoLuongNhomTo";
		E49F2F91.Size = new Size(56, 23);
		E49F2F91.TabIndex = 2;
		E49F2F91.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		label66.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 163);
		label66.Location = new Point(201, 80);
		label66.Name = "label66";
		label66.Size = new Size(29, 16);
		label66.TabIndex = 105;
		label66.Text = ">";
		label66.TextAlign = ContentAlignment.MiddleCenter;
		E423351A.Location = new Point(139, 49);
		E423351A.Name = "txtTenHanhDong";
		E423351A.Size = new Size(153, 23);
		E423351A.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		C9A51A1F.Anchor = AnchorStyles.Bottom;
		C9A51A1F.BackColor = Color.Maroon;
		C9A51A1F.Cursor = Cursors.Hand;
		C9A51A1F.FlatAppearance.BorderSize = 0;
		C9A51A1F.FlatStyle = FlatStyle.Flat;
		C9A51A1F.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C9A51A1F.ForeColor = Color.White;
		C9A51A1F.Location = new Point(366, 475);
		C9A51A1F.Name = "btnCancel";
		C9A51A1F.Size = new Size(92, 29);
		C9A51A1F.TabIndex = 12;
		C9A51A1F.Text = "Đóng";
		C9A51A1F.UseVisualStyleBackColor = false;
		C9A51A1F.Click += C9A51A1F_Click;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(259, 475);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 11;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += C225C4AF;
		B014E30F.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		B014E30F.BackColor = Color.White;
		B014E30F.BorderRadius = 0;
		B014E30F.BottomSahddow = true;
		B014E30F.color = Color.DarkViolet;
		B014E30F.Controls.Add(pnlHeader);
		B014E30F.LeftSahddow = false;
		B014E30F.Location = new Point(1, 0);
		B014E30F.Name = "bunifuCards1";
		B014E30F.RightSahddow = true;
		B014E30F.ShadowDepth = 20;
		B014E30F.Size = new Size(716, 37);
		B014E30F.TabIndex = 28;
		B79754B7.Controls.Add(CFA7AC37);
		B79754B7.Location = new Point(28, 137);
		B79754B7.Name = "panel2";
		B79754B7.Size = new Size(266, 23);
		B79754B7.TabIndex = 206;
		CFA7AC37.Alignment = TabAlignment.Bottom;
		CFA7AC37.Controls.Add(F38D5AA8);
		CFA7AC37.Controls.Add(tabPage2);
		CFA7AC37.Location = new Point(-5, -5);
		CFA7AC37.Name = "tabOptionsPost";
		CFA7AC37.SelectedIndex = 0;
		CFA7AC37.Size = new Size(276, 54);
		CFA7AC37.TabIndex = 198;
		F38D5AA8.Controls.Add(label19);
		F38D5AA8.Controls.Add(label3);
		F38D5AA8.Controls.Add(E71CC1AC);
		F38D5AA8.Controls.Add(C327498C);
		F38D5AA8.Location = new Point(4, 4);
		F38D5AA8.Name = "tabPage1";
		F38D5AA8.Padding = new Padding(3);
		F38D5AA8.Size = new Size(268, 25);
		F38D5AA8.TabIndex = 0;
		F38D5AA8.Text = "tabPage1";
		F38D5AA8.UseVisualStyleBackColor = true;
		label19.AutoSize = true;
		label19.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label19.Location = new Point(0, 3);
		label19.Name = "label19";
		label19.Size = new Size(109, 16);
		label19.TabIndex = 101;
		label19.Text = "Sô\u0301 ba\u0300i viê\u0301t/nho\u0301m:";
		label3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label3.Location = new Point(174, 3);
		label3.Name = "label3";
		label3.Size = new Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = ">";
		label3.TextAlign = ContentAlignment.MiddleCenter;
		E71CC1AC.Location = new Point(112, 1);
		E71CC1AC.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		E71CC1AC.Name = "nudSoLuongBaiVietFrom";
		E71CC1AC.Size = new Size(56, 23);
		E71CC1AC.TabIndex = 3;
		C327498C.Location = new Point(209, 1);
		C327498C.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		C327498C.Name = "nudSoLuongBaiVietTo";
		C327498C.Size = new Size(56, 23);
		C327498C.TabIndex = 4;
		tabPage2.Controls.Add(nudThoiGianFrom);
		tabPage2.Controls.Add(label8);
		tabPage2.Controls.Add(label9);
		tabPage2.Controls.Add(nudThoiGianTo);
		tabPage2.Location = new Point(4, 4);
		tabPage2.Name = "tabPage2";
		tabPage2.Padding = new Padding(3);
		tabPage2.Size = new Size(268, 25);
		tabPage2.TabIndex = 1;
		tabPage2.Text = "tabPage2";
		tabPage2.UseVisualStyleBackColor = true;
		label8.AutoSize = true;
		label8.Location = new Point(0, 3);
		label8.Name = "label8";
		label8.Size = new Size(122, 16);
		label8.TabIndex = 40;
		label8.Text = "Thơ\u0300i gian/nho\u0301m (s):";
		label9.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label9.Location = new Point(174, 3);
		label9.Name = "label9";
		label9.Size = new Size(29, 16);
		label9.TabIndex = 41;
		label9.Text = ">";
		label9.TextAlign = ContentAlignment.MiddleCenter;
		nudThoiGianFrom.Location = new Point(112, 1);
		nudThoiGianFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudThoiGianFrom.Name = "nudThoiGianFrom";
		nudThoiGianFrom.Size = new Size(56, 23);
		nudThoiGianFrom.TabIndex = 38;
		nudThoiGianTo.Location = new Point(209, 1);
		nudThoiGianTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudThoiGianTo.Name = "nudThoiGianTo";
		nudThoiGianTo.Size = new Size(56, 23);
		nudThoiGianTo.TabIndex = 39;
		C80AC12E.Cursor = Cursors.Hand;
		C80AC12E.DropDownStyle = ComboBoxStyle.DropDownList;
		C80AC12E.DropDownWidth = 200;
		C80AC12E.FormattingEnabled = true;
		C80AC12E.Location = new Point(139, 107);
		C80AC12E.Name = "cbbOptionsPost";
		C80AC12E.Size = new Size(153, 24);
		C80AC12E.TabIndex = 204;
		C80AC12E.SelectedIndexChanged += AFABA43C;
		B5033784.AutoSize = true;
		B5033784.Location = new Point(27, 110);
		B5033784.Name = "label6";
		B5033784.Size = new Size(64, 16);
		B5033784.TabIndex = 205;
		B5033784.Text = "Tu\u0300y cho\u0323n:";
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(719, 518);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDBaiVietNhom";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDBaiVietNhom_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		((ISupportInitialize)nudSoLuongNhomFrom).EndInit();
		((ISupportInitialize)E49F2F91).EndInit();
		B014E30F.ResumeLayout(performLayout: false);
		B79754B7.ResumeLayout(performLayout: false);
		CFA7AC37.ResumeLayout(performLayout: false);
		F38D5AA8.ResumeLayout(performLayout: false);
		F38D5AA8.PerformLayout();
		((ISupportInitialize)E71CC1AC).EndInit();
		((ISupportInitialize)C327498C).EndInit();
		tabPage2.ResumeLayout(performLayout: false);
		tabPage2.PerformLayout();
		((ISupportInitialize)nudThoiGianFrom).EndInit();
		((ISupportInitialize)nudThoiGianTo).EndInit();
		ResumeLayout(performLayout: false);
	}
}
