using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDXemWatch : Form
{
	private GClass11 gclass11_0;

	private string C0AC7A07;

	private string string_0;

	private string E6959038;

	private int C0BAFD99;

	public static bool bool_0;

	private EFBBE9AB efbbe9AB_0;

	private IContainer F2884005 = null;

	private BunifuDragControl E708C524;

	private BunifuDragControl F0B9AC9A;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudDelayFrom;

	private NumericUpDown nudSoLuongFrom;

	private TextBox C8BF900F;

	private Label DD1C7014;

	private Label label3;

	private Label label5;

	private Label label2;

	private Label BA187A17;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards F1B63C99;

	private Panel pnlHeader;

	private Button BB198109;

	private PictureBox AD20E713;

	private BunifuCustomLabel E4A2F5AC;

	private Panel plTuongTacBaiViet;

	private ComboBox cbbOptionsPost;

	private Label label4;

	private Panel panel2;

	private TabControl tabOptionsPost;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private Label AF8F3521;

	private Label CD0178BD;

	private NumericUpDown nudThoiGianFrom;

	private NumericUpDown nudThoiGianTo;

	private Panel plDieuKien;

	private RichTextBox txtTuKhoa;

	private Label D10B7205;

	private Label C4A7EDB9;

	private Label B03830AB;

	private NumericUpDown nudLuotToiDa;

	private CheckBox BD8E1C0C;

	public fHDXemWatch(string string_1, int AF91D325 = 0, string E9A79C33 = "")
	{
		BA109F83();
		bool_0 = false;
		C0AC7A07 = string_1;
		E6959038 = E9A79C33;
		C0BAFD99 = AF91D325;
		string string_2 = base.Name.Substring(1);
		string string_3 = "Xem Watch";
		Class147.smethod_8(string_2, string_3);
		string string_4 = "";
		switch (AF91D325)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", string_2);
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			C8BF900F.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(E9A79C33);
			string_4 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			C8BF900F.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(string_4, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void fHDXemWatch_Load(object sender, EventArgs e)
	{
		method_0();
		try
		{
			cbbOptionsPost.SelectedIndex = gclass11_0.method_2("cbbOptionsPost");
			nudSoLuongFrom.Value = gclass11_0.method_2("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass11_0.method_2("nudSoLuongTo", 2);
			nudThoiGianFrom.Value = gclass11_0.method_2("nudThoiGianFrom", 30);
			nudThoiGianTo.Value = gclass11_0.method_2("nudThoiGianTo", 30);
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
			efbbe9AB_0 = new EFBBE9AB(gclass11_0);
			plTuongTacBaiViet.Controls.Add(efbbe9AB_0);
			BD8E1C0C.Checked = gclass11_0.method_3("ckbDieuKien");
			txtTuKhoa.Text = gclass11_0.C0288288("txtTuKhoa");
			nudLuotToiDa.Value = gclass11_0.method_2("nudLuotToiDa", 50);
		}
		catch
		{
		}
		method_1();
	}

	private void method_0()
	{
		List<string> list_ = new List<string> { "Giơ\u0301i ha\u0323n sô\u0301 ba\u0300i viê\u0301t tương ta\u0301c", "Giơ\u0301i ha\u0323n thơ\u0300i gian tương ta\u0301c" };
		GClass8.smethod_22(cbbOptionsPost, list_);
	}

	private void BB198109_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = C8BF900F.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = efbbe9AB_0.F0B0B700();
		gClass.method_4("cbbOptionsPost", cbbOptionsPost.SelectedIndex);
		gClass.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudThoiGianFrom", nudThoiGianFrom.Value);
		gClass.method_4("nudThoiGianTo", nudThoiGianTo.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		gClass.method_4("ckbDieuKien", BD8E1C0C.Checked);
		gClass.method_4("txtTuKhoa", txtTuKhoa.Text.Trim());
		gClass.method_4("nudLuotToiDa", nudLuotToiDa.Value);
		string text2 = gClass.method_7();
		if (C0BAFD99 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(C0AC7A07, text, string_0, text2))
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
			if (Class147.smethod_13(E6959038, text, text2))
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

	private void D18BDB14(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void method_1()
	{
		BD8E1C0C_CheckedChanged(null, null);
	}

	private void AD20E713_Click(object sender, EventArgs e)
	{
	}

	private void CAA87594(object sender, EventArgs e)
	{
		tabOptionsPost.SelectedIndex = cbbOptionsPost.SelectedIndex;
	}

	private void BD8E1C0C_CheckedChanged(object sender, EventArgs e)
	{
		plDieuKien.Enabled = BD8E1C0C.Checked;
	}

	private void txtTuKhoa_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtTuKhoa, D10B7205);
	}

	private void C48B5091(object sender, EventArgs e)
	{
		plDieuKien.Height = 205;
	}

	private void txtTuKhoa_MouseLeave(object sender, EventArgs e)
	{
		plDieuKien.Height = 86;
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && F2884005 != null)
		{
			F2884005.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void BA109F83()
	{
		F2884005 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDXemWatch));
		E708C524 = new BunifuDragControl(F2884005);
		E4A2F5AC = new BunifuCustomLabel();
		F0B9AC9A = new BunifuDragControl(F2884005);
		pnlHeader = new Panel();
		BB198109 = new Button();
		AD20E713 = new PictureBox();
		panel1 = new Panel();
		plDieuKien = new Panel();
		txtTuKhoa = new RichTextBox();
		D10B7205 = new Label();
		C4A7EDB9 = new Label();
		B03830AB = new Label();
		nudLuotToiDa = new NumericUpDown();
		BD8E1C0C = new CheckBox();
		panel2 = new Panel();
		tabOptionsPost = new TabControl();
		tabPage1 = new TabPage();
		label2 = new Label();
		label3 = new Label();
		nudSoLuongFrom = new NumericUpDown();
		nudSoLuongTo = new NumericUpDown();
		tabPage2 = new TabPage();
		AF8F3521 = new Label();
		CD0178BD = new Label();
		nudThoiGianFrom = new NumericUpDown();
		nudThoiGianTo = new NumericUpDown();
		cbbOptionsPost = new ComboBox();
		plTuongTacBaiViet = new Panel();
		nudDelayTo = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		C8BF900F = new TextBox();
		DD1C7014 = new Label();
		label5 = new Label();
		label4 = new Label();
		BA187A17 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		F1B63C99 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)AD20E713).BeginInit();
		panel1.SuspendLayout();
		plDieuKien.SuspendLayout();
		((ISupportInitialize)nudLuotToiDa).BeginInit();
		panel2.SuspendLayout();
		tabOptionsPost.SuspendLayout();
		tabPage1.SuspendLayout();
		((ISupportInitialize)nudSoLuongFrom).BeginInit();
		((ISupportInitialize)nudSoLuongTo).BeginInit();
		tabPage2.SuspendLayout();
		((ISupportInitialize)nudThoiGianFrom).BeginInit();
		((ISupportInitialize)nudThoiGianTo).BeginInit();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		F1B63C99.SuspendLayout();
		SuspendLayout();
		E708C524.Fixed = true;
		E708C524.Horizontal = true;
		E708C524.TargetControl = E4A2F5AC;
		E708C524.Vertical = true;
		E4A2F5AC.BackColor = Color.Transparent;
		E4A2F5AC.Cursor = Cursors.SizeAll;
		E4A2F5AC.Dock = DockStyle.Fill;
		E4A2F5AC.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		E4A2F5AC.ForeColor = Color.Black;
		E4A2F5AC.Location = new Point(0, 0);
		E4A2F5AC.Name = "bunifuCustomLabel1";
		E4A2F5AC.Size = new Size(716, 31);
		E4A2F5AC.TabIndex = 12;
		E4A2F5AC.Text = "Cấu hình Xem Watch";
		E4A2F5AC.TextAlign = ContentAlignment.MiddleCenter;
		F0B9AC9A.Fixed = true;
		F0B9AC9A.Horizontal = true;
		F0B9AC9A.TargetControl = pnlHeader;
		F0B9AC9A.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(BB198109);
		pnlHeader.Controls.Add(AD20E713);
		pnlHeader.Controls.Add(E4A2F5AC);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(716, 31);
		pnlHeader.TabIndex = 9;
		BB198109.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		BB198109.Cursor = Cursors.Hand;
		BB198109.FlatAppearance.BorderSize = 0;
		BB198109.FlatStyle = FlatStyle.Flat;
		BB198109.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BB198109.ForeColor = Color.White;
		BB198109.Image = (Image)componentResourceManager.GetObject("button1.Image");
		BB198109.Location = new Point(685, 1);
		BB198109.Name = "button1";
		BB198109.Size = new Size(30, 30);
		BB198109.TabIndex = 77;
		BB198109.TextImageRelation = TextImageRelation.ImageBeforeText;
		BB198109.UseVisualStyleBackColor = true;
		BB198109.Click += BB198109_Click;
		AD20E713.Cursor = Cursors.Default;
		AD20E713.Image = C50FB39E.Bitmap_5;
		AD20E713.Location = new Point(3, 2);
		AD20E713.Name = "pictureBox1";
		AD20E713.Size = new Size(34, 27);
		AD20E713.SizeMode = PictureBoxSizeMode.Zoom;
		AD20E713.TabIndex = 76;
		AD20E713.TabStop = false;
		AD20E713.Click += AD20E713_Click;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(plDieuKien);
		panel1.Controls.Add(BD8E1C0C);
		panel1.Controls.Add(panel2);
		panel1.Controls.Add(cbbOptionsPost);
		panel1.Controls.Add(plTuongTacBaiViet);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(C8BF900F);
		panel1.Controls.Add(DD1C7014);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(BA187A17);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(F1B63C99);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(719, 489);
		panel1.TabIndex = 0;
		panel1.Paint += D18BDB14;
		plDieuKien.BorderStyle = BorderStyle.FixedSingle;
		plDieuKien.Controls.Add(txtTuKhoa);
		plDieuKien.Controls.Add(D10B7205);
		plDieuKien.Controls.Add(C4A7EDB9);
		plDieuKien.Controls.Add(B03830AB);
		plDieuKien.Controls.Add(nudLuotToiDa);
		plDieuKien.Location = new Point(381, 74);
		plDieuKien.Name = "plDieuKien";
		plDieuKien.Size = new Size(306, 86);
		plDieuKien.TabIndex = 200;
		plDieuKien.Visible = false;
		txtTuKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		txtTuKhoa.Location = new Point(7, 25);
		txtTuKhoa.Name = "txtTuKhoa";
		txtTuKhoa.Size = new Size(291, 55);
		txtTuKhoa.TabIndex = 0;
		txtTuKhoa.Text = "";
		txtTuKhoa.WordWrap = false;
		txtTuKhoa.TextChanged += txtTuKhoa_TextChanged;
		txtTuKhoa.MouseEnter += C48B5091;
		txtTuKhoa.MouseLeave += txtTuKhoa_MouseLeave;
		D10B7205.AutoSize = true;
		D10B7205.Location = new Point(3, 5);
		D10B7205.Name = "lblTuKhoa";
		D10B7205.Size = new Size(114, 16);
		D10B7205.TabIndex = 0;
		D10B7205.Text = "Danh sa\u0301ch tên (0):";
		C4A7EDB9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		C4A7EDB9.AutoSize = true;
		C4A7EDB9.Location = new Point(276, 3);
		C4A7EDB9.Name = "label10";
		C4A7EDB9.Size = new Size(24, 16);
		C4A7EDB9.TabIndex = 32;
		C4A7EDB9.Text = "ba\u0300i";
		B03830AB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		B03830AB.AutoSize = true;
		B03830AB.Location = new Point(148, 3);
		B03830AB.Name = "label6";
		B03830AB.Size = new Size(73, 16);
		B03830AB.TabIndex = 32;
		B03830AB.Text = "Lươ\u0301t tô\u0301i đa:";
		nudLuotToiDa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		nudLuotToiDa.Location = new Point(222, 1);
		nudLuotToiDa.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudLuotToiDa.Name = "nudLuotToiDa";
		nudLuotToiDa.Size = new Size(54, 23);
		nudLuotToiDa.TabIndex = 1;
		nudLuotToiDa.Value = new decimal(new int[4] { 500, 0, 0, 0 });
		BD8E1C0C.AutoSize = true;
		BD8E1C0C.Cursor = Cursors.Hand;
		BD8E1C0C.Location = new Point(381, 51);
		BD8E1C0C.Name = "ckbDieuKien";
		BD8E1C0C.Size = new Size(293, 20);
		BD8E1C0C.TabIndex = 201;
		BD8E1C0C.Text = "Chi\u0309 tương ta\u0301c khi tên page co\u0301 chư\u0301a ca\u0301c tư\u0300 sau:";
		BD8E1C0C.UseVisualStyleBackColor = true;
		BD8E1C0C.Visible = false;
		BD8E1C0C.CheckedChanged += BD8E1C0C_CheckedChanged;
		panel2.Controls.Add(tabOptionsPost);
		panel2.Location = new Point(28, 108);
		panel2.Name = "panel2";
		panel2.Size = new Size(266, 23);
		panel2.TabIndex = 199;
		tabOptionsPost.Alignment = TabAlignment.Bottom;
		tabOptionsPost.Controls.Add(tabPage1);
		tabOptionsPost.Controls.Add(tabPage2);
		tabOptionsPost.Location = new Point(-5, -5);
		tabOptionsPost.Name = "tabOptionsPost";
		tabOptionsPost.SelectedIndex = 0;
		tabOptionsPost.Size = new Size(276, 54);
		tabOptionsPost.TabIndex = 198;
		tabPage1.Controls.Add(label2);
		tabPage1.Controls.Add(label3);
		tabPage1.Controls.Add(nudSoLuongFrom);
		tabPage1.Controls.Add(nudSoLuongTo);
		tabPage1.Location = new Point(4, 4);
		tabPage1.Name = "tabPage1";
		tabPage1.Padding = new Padding(3);
		tabPage1.Size = new Size(268, 25);
		tabPage1.TabIndex = 0;
		tabPage1.Text = "tabPage1";
		tabPage1.UseVisualStyleBackColor = true;
		label2.AutoSize = true;
		label2.Location = new Point(0, 3);
		label2.Name = "label2";
		label2.Size = new Size(84, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng ba\u0300i:";
		label3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label3.Location = new Point(174, 3);
		label3.Name = "label3";
		label3.Size = new Size(29, 16);
		label3.TabIndex = 1;
		label3.Text = ">";
		label3.TextAlign = ContentAlignment.MiddleCenter;
		nudSoLuongFrom.Location = new Point(112, 1);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new Size(56, 23);
		nudSoLuongFrom.TabIndex = 0;
		nudSoLuongTo.Location = new Point(209, 1);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		tabPage2.Controls.Add(AF8F3521);
		tabPage2.Controls.Add(CD0178BD);
		tabPage2.Controls.Add(nudThoiGianFrom);
		tabPage2.Controls.Add(nudThoiGianTo);
		tabPage2.Location = new Point(4, 4);
		tabPage2.Name = "tabPage2";
		tabPage2.Padding = new Padding(3);
		tabPage2.Size = new Size(268, 28);
		tabPage2.TabIndex = 1;
		tabPage2.Text = "tabPage2";
		tabPage2.UseVisualStyleBackColor = true;
		AF8F3521.AutoSize = true;
		AF8F3521.Location = new Point(0, 3);
		AF8F3521.Name = "label8";
		AF8F3521.Size = new Size(85, 16);
		AF8F3521.TabIndex = 40;
		AF8F3521.Text = "Thơ\u0300i gian (s):";
		CD0178BD.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		CD0178BD.Location = new Point(174, 3);
		CD0178BD.Name = "label9";
		CD0178BD.Size = new Size(29, 16);
		CD0178BD.TabIndex = 41;
		CD0178BD.Text = ">";
		CD0178BD.TextAlign = ContentAlignment.MiddleCenter;
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
		cbbOptionsPost.Cursor = Cursors.Hand;
		cbbOptionsPost.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbOptionsPost.DropDownWidth = 200;
		cbbOptionsPost.FormattingEnabled = true;
		cbbOptionsPost.Location = new Point(139, 78);
		cbbOptionsPost.Name = "cbbOptionsPost";
		cbbOptionsPost.Size = new Size(153, 24);
		cbbOptionsPost.TabIndex = 1;
		cbbOptionsPost.SelectedIndexChanged += CAA87594;
		plTuongTacBaiViet.BorderStyle = BorderStyle.FixedSingle;
		plTuongTacBaiViet.Location = new Point(30, 166);
		plTuongTacBaiViet.Name = "plTuongTacBaiViet";
		plTuongTacBaiViet.Size = new Size(657, 266);
		plTuongTacBaiViet.TabIndex = 193;
		nudDelayTo.Location = new Point(236, 137);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudDelayFrom.Location = new Point(139, 137);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 2;
		C8BF900F.Location = new Point(139, 49);
		C8BF900F.Name = "txtTenHanhDong";
		C8BF900F.Size = new Size(153, 23);
		C8BF900F.TabIndex = 0;
		DD1C7014.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		DD1C7014.Location = new Point(201, 139);
		DD1C7014.Name = "label7";
		DD1C7014.Size = new Size(29, 16);
		DD1C7014.TabIndex = 3;
		DD1C7014.Text = ">";
		DD1C7014.TextAlign = ContentAlignment.MiddleCenter;
		label5.AutoSize = true;
		label5.Location = new Point(27, 139);
		label5.Name = "label5";
		label5.Size = new Size(87, 16);
		label5.TabIndex = 34;
		label5.Text = "Gia\u0303n ca\u0301ch (s):";
		label4.AutoSize = true;
		label4.Location = new Point(27, 81);
		label4.Name = "label4";
		label4.Size = new Size(64, 16);
		label4.TabIndex = 32;
		label4.Text = "Tu\u0300y cho\u0323n:";
		BA187A17.AutoSize = true;
		BA187A17.Location = new Point(27, 52);
		BA187A17.Name = "label1";
		BA187A17.Size = new Size(98, 16);
		BA187A17.TabIndex = 31;
		BA187A17.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(367, 446);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 10;
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
		btnAdd.Location = new Point(260, 446);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		F1B63C99.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		F1B63C99.BackColor = Color.White;
		F1B63C99.BorderRadius = 0;
		F1B63C99.BottomSahddow = true;
		F1B63C99.color = Color.DarkViolet;
		F1B63C99.Controls.Add(pnlHeader);
		F1B63C99.LeftSahddow = false;
		F1B63C99.Location = new Point(1, 0);
		F1B63C99.Name = "bunifuCards1";
		F1B63C99.RightSahddow = true;
		F1B63C99.ShadowDepth = 20;
		F1B63C99.Size = new Size(716, 37);
		F1B63C99.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(719, 489);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDXemWatch";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDXemWatch_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)AD20E713).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		plDieuKien.ResumeLayout(performLayout: false);
		plDieuKien.PerformLayout();
		((ISupportInitialize)nudLuotToiDa).EndInit();
		panel2.ResumeLayout(performLayout: false);
		tabOptionsPost.ResumeLayout(performLayout: false);
		tabPage1.ResumeLayout(performLayout: false);
		tabPage1.PerformLayout();
		((ISupportInitialize)nudSoLuongFrom).EndInit();
		((ISupportInitialize)nudSoLuongTo).EndInit();
		tabPage2.ResumeLayout(performLayout: false);
		tabPage2.PerformLayout();
		((ISupportInitialize)nudThoiGianFrom).EndInit();
		((ISupportInitialize)nudThoiGianTo).EndInit();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		F1B63C99.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
