using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class AD243E2E : Form
{
	private GClass11 EEB48913;

	private string string_0;

	private string string_1;

	private string string_2;

	private int A6980732;

	public static bool bool_0;

	private EFBBE9AB efbbe9AB_0;

	private IContainer A22587AA = null;

	private BunifuDragControl C48256A9;

	private BunifuDragControl CB9D0E86;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private TextBox E3064E9F;

	private Label label7;

	private Label label5;

	private Label D8013210;

	private Button ABBD6123;

	private Button btnAdd;

	private BunifuCards CB331D20;

	private Panel F729DB20;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel C2080801;

	private Label label49;

	private NumericUpDown nudSoLuongPageFrom;

	private NumericUpDown C48D580A;

	private Label F31E2318;

	private Label E2A2382F;

	private RichTextBox txtUid;

	private CheckBox ckbLikePage;

	private Panel plTuongTacBaiViet;

	private Panel panel2;

	private TabControl E2273100;

	private TabPage AD937F89;

	private Label label19;

	private Label label3;

	private NumericUpDown nudSoLuongBaiVietFrom;

	private NumericUpDown nudSoLuongBaiVietTo;

	private TabPage EE1D0FBD;

	private Label label8;

	private Label label9;

	private NumericUpDown FA17288A;

	private NumericUpDown AC3588B7;

	private ComboBox DD104E1B;

	private Label label6;

	public AD243E2E(string string_3, int int_0 = 0, string B03AFEAF = "")
	{
		A00923B5();
		bool_0 = false;
		string_0 = string_3;
		string_2 = B03AFEAF;
		A6980732 = int_0;
		string text = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDBaiVietFanpage");
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			E3064E9F.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(B03AFEAF);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			E3064E9F.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		EEB48913 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void D603528C(object sender, EventArgs e)
	{
		A5987822();
		try
		{
			nudSoLuongPageFrom.Value = EEB48913.method_2("nudSoLuongPageFrom", 1);
			C48D580A.Value = EEB48913.method_2("nudSoLuongPageTo", 1);
			DD104E1B.SelectedIndex = EEB48913.method_2("cbbOptionsPost");
			nudSoLuongBaiVietFrom.Value = EEB48913.method_2("nudSoLuongBaiVietFrom", 1);
			nudSoLuongBaiVietTo.Value = EEB48913.method_2("nudSoLuongBaiVietTo", 2);
			FA17288A.Value = EEB48913.method_2("nudThoiGianFrom", 30);
			AC3588B7.Value = EEB48913.method_2("nudThoiGianTo", 30);
			nudDelayFrom.Value = EEB48913.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = EEB48913.method_2("nudDelayTo", 5);
			txtUid.Text = EEB48913.C0288288("txtUid");
			ckbLikePage.Checked = EEB48913.method_3("ckbLikePage");
			efbbe9AB_0 = new EFBBE9AB(EEB48913);
			plTuongTacBaiViet.Controls.Add(efbbe9AB_0);
		}
		catch
		{
		}
	}

	private void A5987822()
	{
		List<string> list_ = new List<string> { "Giơ\u0301i ha\u0323n sô\u0301 ba\u0300i viê\u0301t tương ta\u0301c", "Giơ\u0301i ha\u0323n thơ\u0300i gian tương ta\u0301c" };
		GClass8.smethod_22(DD104E1B, list_);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void ED0A3600(object sender, EventArgs e)
	{
		string text = E3064E9F.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> e03C713E = txtUid.Lines.ToList();
		e03C713E = GClass8.smethod_36(e03C713E);
		if (e03C713E.Count == 0)
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Id page!", 3);
			return;
		}
		GClass11 gClass = efbbe9AB_0.F0B0B700();
		gClass.method_4("nudSoLuongPageFrom", nudSoLuongPageFrom.Value);
		gClass.method_4("nudSoLuongPageTo", C48D580A.Value);
		gClass.method_4("cbbOptionsPost", DD104E1B.SelectedIndex);
		gClass.method_4("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
		gClass.method_4("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
		gClass.method_4("nudThoiGianFrom", FA17288A.Value);
		gClass.method_4("nudThoiGianTo", AC3588B7.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		gClass.method_4("txtUid", txtUid.Text.Trim());
		gClass.method_4("ckbLikePage", ckbLikePage.Checked);
		string text2 = gClass.method_7();
		if (A6980732 == 0)
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

	private void ABBD6123_Click(object sender, EventArgs e)
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

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
		}
	}

	private void txtUid_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtUid, E2A2382F);
	}

	private void DD104E1B_SelectedIndexChanged(object sender, EventArgs e)
	{
		E2273100.SelectedIndex = DD104E1B.SelectedIndex;
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && A22587AA != null)
		{
			A22587AA.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void A00923B5()
	{
		A22587AA = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AD243E2E));
		C48256A9 = new BunifuDragControl(A22587AA);
		C2080801 = new BunifuCustomLabel();
		CB9D0E86 = new BunifuDragControl(A22587AA);
		F729DB20 = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		panel2 = new Panel();
		E2273100 = new TabControl();
		AD937F89 = new TabPage();
		label19 = new Label();
		label3 = new Label();
		nudSoLuongBaiVietFrom = new NumericUpDown();
		nudSoLuongBaiVietTo = new NumericUpDown();
		EE1D0FBD = new TabPage();
		FA17288A = new NumericUpDown();
		label8 = new Label();
		label9 = new Label();
		AC3588B7 = new NumericUpDown();
		plTuongTacBaiViet = new Panel();
		DD104E1B = new ComboBox();
		label6 = new Label();
		txtUid = new RichTextBox();
		E2A2382F = new Label();
		label49 = new Label();
		nudSoLuongPageFrom = new NumericUpDown();
		C48D580A = new NumericUpDown();
		F31E2318 = new Label();
		ckbLikePage = new CheckBox();
		nudDelayTo = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		E3064E9F = new TextBox();
		label7 = new Label();
		label5 = new Label();
		D8013210 = new Label();
		ABBD6123 = new Button();
		btnAdd = new Button();
		CB331D20 = new BunifuCards();
		F729DB20.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		panel2.SuspendLayout();
		E2273100.SuspendLayout();
		AD937F89.SuspendLayout();
		((ISupportInitialize)nudSoLuongBaiVietFrom).BeginInit();
		((ISupportInitialize)nudSoLuongBaiVietTo).BeginInit();
		EE1D0FBD.SuspendLayout();
		((ISupportInitialize)FA17288A).BeginInit();
		((ISupportInitialize)AC3588B7).BeginInit();
		((ISupportInitialize)nudSoLuongPageFrom).BeginInit();
		((ISupportInitialize)C48D580A).BeginInit();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		CB331D20.SuspendLayout();
		SuspendLayout();
		C48256A9.Fixed = true;
		C48256A9.Horizontal = true;
		C48256A9.TargetControl = C2080801;
		C48256A9.Vertical = true;
		C2080801.BackColor = Color.Transparent;
		C2080801.Cursor = Cursors.SizeAll;
		C2080801.Dock = DockStyle.Fill;
		C2080801.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C2080801.ForeColor = Color.Black;
		C2080801.Location = new Point(0, 0);
		C2080801.Name = "bunifuCustomLabel1";
		C2080801.Size = new Size(713, 31);
		C2080801.TabIndex = 12;
		C2080801.Text = "Cấu hình Bài viết Fanpage";
		C2080801.TextAlign = ContentAlignment.MiddleCenter;
		CB9D0E86.Fixed = true;
		CB9D0E86.Horizontal = true;
		CB9D0E86.TargetControl = F729DB20;
		CB9D0E86.Vertical = true;
		F729DB20.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		F729DB20.BackColor = Color.White;
		F729DB20.Controls.Add(button1);
		F729DB20.Controls.Add(pictureBox1);
		F729DB20.Controls.Add(C2080801);
		F729DB20.Cursor = Cursors.SizeAll;
		F729DB20.Location = new Point(0, 3);
		F729DB20.Name = "pnlHeader";
		F729DB20.Size = new Size(713, 31);
		F729DB20.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(682, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += button1_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += pictureBox1_Click;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(panel2);
		panel1.Controls.Add(plTuongTacBaiViet);
		panel1.Controls.Add(DD104E1B);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(txtUid);
		panel1.Controls.Add(E2A2382F);
		panel1.Controls.Add(label49);
		panel1.Controls.Add(nudSoLuongPageFrom);
		panel1.Controls.Add(C48D580A);
		panel1.Controls.Add(F31E2318);
		panel1.Controls.Add(ckbLikePage);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(E3064E9F);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(D8013210);
		panel1.Controls.Add(ABBD6123);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(CB331D20);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(716, 524);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		panel2.Controls.Add(E2273100);
		panel2.Location = new Point(28, 137);
		panel2.Name = "panel2";
		panel2.Size = new Size(266, 23);
		panel2.TabIndex = 205;
		E2273100.Alignment = TabAlignment.Bottom;
		E2273100.Controls.Add(AD937F89);
		E2273100.Controls.Add(EE1D0FBD);
		E2273100.Location = new Point(-5, -5);
		E2273100.Name = "tabOptionsPost";
		E2273100.SelectedIndex = 0;
		E2273100.Size = new Size(276, 54);
		E2273100.TabIndex = 198;
		AD937F89.Controls.Add(label19);
		AD937F89.Controls.Add(label3);
		AD937F89.Controls.Add(nudSoLuongBaiVietFrom);
		AD937F89.Controls.Add(nudSoLuongBaiVietTo);
		AD937F89.Location = new Point(4, 4);
		AD937F89.Name = "tabPage1";
		AD937F89.Padding = new Padding(3);
		AD937F89.Size = new Size(268, 25);
		AD937F89.TabIndex = 0;
		AD937F89.Text = "tabPage1";
		AD937F89.UseVisualStyleBackColor = true;
		label19.AutoSize = true;
		label19.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label19.Location = new Point(0, 3);
		label19.Name = "label19";
		label19.Size = new Size(105, 16);
		label19.TabIndex = 101;
		label19.Text = "Sô\u0301 ba\u0300i viê\u0301t/page:";
		label3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label3.Location = new Point(174, 3);
		label3.Name = "label3";
		label3.Size = new Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = ">";
		label3.TextAlign = ContentAlignment.MiddleCenter;
		nudSoLuongBaiVietFrom.Location = new Point(112, 1);
		nudSoLuongBaiVietFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBaiVietFrom.Name = "nudSoLuongBaiVietFrom";
		nudSoLuongBaiVietFrom.Size = new Size(56, 23);
		nudSoLuongBaiVietFrom.TabIndex = 3;
		nudSoLuongBaiVietTo.Location = new Point(209, 1);
		nudSoLuongBaiVietTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBaiVietTo.Name = "nudSoLuongBaiVietTo";
		nudSoLuongBaiVietTo.Size = new Size(56, 23);
		nudSoLuongBaiVietTo.TabIndex = 4;
		EE1D0FBD.Controls.Add(FA17288A);
		EE1D0FBD.Controls.Add(label8);
		EE1D0FBD.Controls.Add(label9);
		EE1D0FBD.Controls.Add(AC3588B7);
		EE1D0FBD.Location = new Point(4, 4);
		EE1D0FBD.Name = "tabPage2";
		EE1D0FBD.Padding = new Padding(3);
		EE1D0FBD.Size = new Size(268, 28);
		EE1D0FBD.TabIndex = 1;
		EE1D0FBD.Text = "tabPage2";
		EE1D0FBD.UseVisualStyleBackColor = true;
		FA17288A.Location = new Point(112, 1);
		FA17288A.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		FA17288A.Name = "nudThoiGianFrom";
		FA17288A.Size = new Size(56, 23);
		FA17288A.TabIndex = 38;
		label8.AutoSize = true;
		label8.Location = new Point(0, 3);
		label8.Name = "label8";
		label8.Size = new Size(118, 16);
		label8.TabIndex = 40;
		label8.Text = "Thơ\u0300i gian/page (s):";
		label9.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label9.Location = new Point(174, 3);
		label9.Name = "label9";
		label9.Size = new Size(29, 16);
		label9.TabIndex = 41;
		label9.Text = ">";
		label9.TextAlign = ContentAlignment.MiddleCenter;
		AC3588B7.Location = new Point(209, 1);
		AC3588B7.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		AC3588B7.Name = "nudThoiGianTo";
		AC3588B7.Size = new Size(56, 23);
		AC3588B7.TabIndex = 39;
		plTuongTacBaiViet.BorderStyle = BorderStyle.FixedSingle;
		plTuongTacBaiViet.Location = new Point(30, 196);
		plTuongTacBaiViet.Name = "plTuongTacBaiViet";
		plTuongTacBaiViet.Size = new Size(657, 266);
		plTuongTacBaiViet.TabIndex = 194;
		DD104E1B.Cursor = Cursors.Hand;
		DD104E1B.DropDownStyle = ComboBoxStyle.DropDownList;
		DD104E1B.DropDownWidth = 200;
		DD104E1B.FormattingEnabled = true;
		DD104E1B.Location = new Point(139, 107);
		DD104E1B.Name = "cbbOptionsPost";
		DD104E1B.Size = new Size(153, 24);
		DD104E1B.TabIndex = 203;
		DD104E1B.SelectedIndexChanged += DD104E1B_SelectedIndexChanged;
		label6.AutoSize = true;
		label6.Location = new Point(27, 110);
		label6.Name = "label6";
		label6.Size = new Size(64, 16);
		label6.TabIndex = 204;
		label6.Text = "Tu\u0300y cho\u0323n:";
		txtUid.BorderStyle = BorderStyle.FixedSingle;
		txtUid.Location = new Point(380, 71);
		txtUid.Name = "txtUid";
		txtUid.Size = new Size(307, 90);
		txtUid.TabIndex = 7;
		txtUid.Text = "";
		txtUid.WordWrap = false;
		txtUid.TextChanged += txtUid_TextChanged;
		E2A2382F.AutoSize = true;
		E2A2382F.Location = new Point(377, 51);
		E2A2382F.Name = "lblStatusUid";
		E2A2382F.Size = new Size(171, 16);
		E2A2382F.TabIndex = 116;
		E2A2382F.Text = "Nhâ\u0323p danh sa\u0301ch Id page (0):";
		label49.AutoSize = true;
		label49.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label49.Location = new Point(27, 80);
		label49.Name = "label49";
		label49.Size = new Size(95, 16);
		label49.TabIndex = 92;
		label49.Text = "Sô\u0301 lươ\u0323ng page:";
		nudSoLuongPageFrom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		nudSoLuongPageFrom.Location = new Point(139, 78);
		nudSoLuongPageFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongPageFrom.Name = "nudSoLuongPageFrom";
		nudSoLuongPageFrom.Size = new Size(56, 23);
		nudSoLuongPageFrom.TabIndex = 1;
		nudSoLuongPageFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		C48D580A.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		C48D580A.Location = new Point(236, 78);
		C48D580A.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		C48D580A.Name = "nudSoLuongPageTo";
		C48D580A.Size = new Size(56, 23);
		C48D580A.TabIndex = 2;
		C48D580A.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		F31E2318.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 163);
		F31E2318.Location = new Point(201, 80);
		F31E2318.Name = "label66";
		F31E2318.Size = new Size(29, 16);
		F31E2318.TabIndex = 105;
		F31E2318.Text = ">";
		F31E2318.TextAlign = ContentAlignment.MiddleCenter;
		ckbLikePage.AutoSize = true;
		ckbLikePage.Cursor = Cursors.Hand;
		ckbLikePage.Location = new Point(379, 167);
		ckbLikePage.Name = "ckbLikePage";
		ckbLikePage.Size = new Size(182, 20);
		ckbLikePage.TabIndex = 8;
		ckbLikePage.Text = "Like page sau khi tương ta\u0301c";
		ckbLikePage.UseVisualStyleBackColor = true;
		nudDelayTo.Location = new Point(236, 166);
		nudDelayTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 6;
		nudDelayFrom.Location = new Point(139, 166);
		nudDelayFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 5;
		E3064E9F.Location = new Point(139, 49);
		E3064E9F.Name = "txtTenHanhDong";
		E3064E9F.Size = new Size(153, 23);
		E3064E9F.TabIndex = 0;
		label7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label7.Location = new Point(201, 168);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = ">";
		label7.TextAlign = ContentAlignment.MiddleCenter;
		label5.AutoSize = true;
		label5.Location = new Point(27, 168);
		label5.Name = "label5";
		label5.Size = new Size(87, 16);
		label5.TabIndex = 34;
		label5.Text = "Gia\u0303n ca\u0301ch (s):";
		D8013210.AutoSize = true;
		D8013210.Location = new Point(27, 52);
		D8013210.Name = "label1";
		D8013210.Size = new Size(98, 16);
		D8013210.TabIndex = 31;
		D8013210.Text = "Tên ha\u0300nh đô\u0323ng:";
		ABBD6123.Anchor = AnchorStyles.Bottom;
		ABBD6123.BackColor = Color.Maroon;
		ABBD6123.Cursor = Cursors.Hand;
		ABBD6123.FlatAppearance.BorderSize = 0;
		ABBD6123.FlatStyle = FlatStyle.Flat;
		ABBD6123.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		ABBD6123.ForeColor = Color.White;
		ABBD6123.Location = new Point(365, 478);
		ABBD6123.Name = "btnCancel";
		ABBD6123.Size = new Size(92, 29);
		ABBD6123.TabIndex = 12;
		ABBD6123.Text = "Đóng";
		ABBD6123.UseVisualStyleBackColor = false;
		ABBD6123.Click += ABBD6123_Click;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(258, 478);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 11;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += ED0A3600;
		CB331D20.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		CB331D20.BackColor = Color.White;
		CB331D20.BorderRadius = 0;
		CB331D20.BottomSahddow = true;
		CB331D20.color = Color.DarkViolet;
		CB331D20.Controls.Add(F729DB20);
		CB331D20.LeftSahddow = false;
		CB331D20.Location = new Point(1, 0);
		CB331D20.Name = "bunifuCards1";
		CB331D20.RightSahddow = true;
		CB331D20.ShadowDepth = 20;
		CB331D20.Size = new Size(713, 37);
		CB331D20.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(716, 524);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDBaiVietFanpage";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += D603528C;
		F729DB20.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		panel2.ResumeLayout(performLayout: false);
		E2273100.ResumeLayout(performLayout: false);
		AD937F89.ResumeLayout(performLayout: false);
		AD937F89.PerformLayout();
		((ISupportInitialize)nudSoLuongBaiVietFrom).EndInit();
		((ISupportInitialize)nudSoLuongBaiVietTo).EndInit();
		EE1D0FBD.ResumeLayout(performLayout: false);
		EE1D0FBD.PerformLayout();
		((ISupportInitialize)FA17288A).EndInit();
		((ISupportInitialize)AC3588B7).EndInit();
		((ISupportInitialize)nudSoLuongPageFrom).EndInit();
		((ISupportInitialize)C48D580A).EndInit();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		CB331D20.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
