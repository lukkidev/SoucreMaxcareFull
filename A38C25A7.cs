using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class A38C25A7 : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string C70CDE85;

	private string string_1;

	private int DC84F696;

	public static bool AA8340A6;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl D3388E38;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown A02CE11C;

	private TextBox ACAA17B7;

	private Label label7;

	private Label label5;

	private Label CE8200BE;

	private Button F1A5268E;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel DD10609A;

	private Label label2;

	private NumericUpDown nudTimeTo;

	private NumericUpDown nudTimeFrom;

	private Label F6979612;

	private Label C48764B3;

	private Panel plCommentText;

	private RichTextBox txtComment;

	private Label lblComment;

	private RichTextBox txtIdPost;

	private Label label49;

	private NumericUpDown BA3CEE19;

	private NumericUpDown C72C673F;

	private Label label66;

	private CheckBox BE8AC0B5;

	private ComboBox cbbTuyChonNoiDung;

	private Button btnHuongDanNhapNoiDung;

	private Label label8;

	private CheckBox A498A30D;

	private Panel E893BF37;

	private CheckBox ckbUuTienMbasic;

	private Label CA2ED20E;

	private Label E7BDA408;

	private NumericUpDown nudDelayDeleteFrom;

	private NumericUpDown F1A3658C;

	public A38C25A7(string string_2, int D33B011C = 0, string E439A728 = "")
	{
		BDA3D39D();
		AA8340A6 = false;
		string_0 = string_2;
		string_1 = E439A728;
		DC84F696 = D33B011C;
		string text = base.Name.Substring(1);
		string text2 = "Uptop ba\u0300i viê\u0301t";
		Class147.smethod_8(text, text2);
		string text3 = "";
		switch (D33B011C)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			C70CDE85 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			ACAA17B7.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(E439A728);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			ACAA17B7.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void A38C25A7_Load(object sender, EventArgs e)
	{
		method_0();
		try
		{
			BA3CEE19.Value = gclass11_0.method_2("nudSoLuongUidFrom", 1);
			C72C673F.Value = gclass11_0.method_2("nudSoLuongUidTo", 1);
			A02CE11C.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
			txtIdPost.Text = gclass11_0.C0288288("txtIdPost");
			A498A30D.Checked = gclass11_0.method_3("ckbTuDongXoa");
			ckbUuTienMbasic.Checked = gclass11_0.method_3("ckbUuTienMbasic");
			nudTimeFrom.Value = gclass11_0.method_2("nudTimeFrom", 3);
			nudTimeTo.Value = gclass11_0.method_2("nudTimeTo", 5);
			txtComment.Text = gclass11_0.C0288288("txtComment");
			cbbTuyChonNoiDung.SelectedIndex = gclass11_0.method_2("typeNganCach");
			BE8AC0B5.Checked = gclass11_0.method_3("ckbAutoDeleteComment");
			nudDelayDeleteFrom.Value = gclass11_0.method_2("nudDelayDeleteFrom", 1);
			F1A3658C.Value = gclass11_0.method_2("nudDelayDeleteTo", 1);
		}
		catch
		{
		}
		method_1();
	}

	private void method_0()
	{
		List<string> list_ = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		GClass8.smethod_22(cbbTuyChonNoiDung, list_);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = ACAA17B7.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongUidFrom", BA3CEE19.Value);
		gClass.method_4("nudSoLuongUidTo", C72C673F.Value);
		gClass.method_4("nudDelayFrom", A02CE11C.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		gClass.method_4("txtIdPost", txtIdPost.Text.Trim());
		gClass.method_4("ckbTuDongXoa", A498A30D.Checked);
		gClass.method_4("ckbUuTienMbasic", ckbUuTienMbasic.Checked);
		gClass.method_4("nudTimeFrom", nudTimeFrom.Value);
		gClass.method_4("nudTimeTo", nudTimeTo.Value);
		gClass.method_4("txtComment", txtComment.Text.Trim());
		gClass.method_4("typeNganCach", cbbTuyChonNoiDung.SelectedIndex);
		gClass.method_4("ckbAutoDeleteComment", BE8AC0B5.Checked);
		gClass.method_4("nudDelayDeleteFrom", nudDelayDeleteFrom.Value);
		gClass.method_4("nudDelayDeleteTo", F1A3658C.Value);
		string string_ = gClass.method_7();
		if (DC84F696 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, C70CDE85, string_))
				{
					AA8340A6 = true;
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
				AA8340A6 = true;
				Close();
			}
			else
			{
				GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void B6B3B68E(object sender, EventArgs e)
	{
		Close();
	}

	private void FA9EA11D(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void BF3D1D28(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtComment, lblComment, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void method_1()
	{
		BF3D1D28(null, null);
	}

	private void txtIdPost_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtIdPost, label2);
	}

	private void DEA797BD(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void B2AC3A20(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtComment, lblComment, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void btnHuongDanNhapNoiDung_Click(object sender, EventArgs e)
	{
		if (cbbTuyChonNoiDung.SelectedIndex == 0)
		{
			GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			GClass8.smethod_33(new fHelpNhapComment());
		}
		txtComment.Focus();
	}

	private void plCommentText_Paint(object sender, PaintEventArgs e)
	{
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void BDA3D39D()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(A38C25A7));
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		DD10609A = new BunifuCustomLabel();
		D3388E38 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		CA2ED20E = new Label();
		E7BDA408 = new Label();
		plCommentText = new Panel();
		cbbTuyChonNoiDung = new ComboBox();
		btnHuongDanNhapNoiDung = new Button();
		label8 = new Label();
		BE8AC0B5 = new CheckBox();
		txtComment = new RichTextBox();
		lblComment = new Label();
		nudDelayDeleteFrom = new NumericUpDown();
		E893BF37 = new Panel();
		label2 = new Label();
		txtIdPost = new RichTextBox();
		A498A30D = new CheckBox();
		F1A3658C = new NumericUpDown();
		label49 = new Label();
		BA3CEE19 = new NumericUpDown();
		C72C673F = new NumericUpDown();
		label66 = new Label();
		nudTimeTo = new NumericUpDown();
		nudDelayTo = new NumericUpDown();
		nudTimeFrom = new NumericUpDown();
		A02CE11C = new NumericUpDown();
		ACAA17B7 = new TextBox();
		F6979612 = new Label();
		label7 = new Label();
		C48764B3 = new Label();
		label5 = new Label();
		CE8200BE = new Label();
		F1A5268E = new Button();
		btnAdd = new Button();
		bunifuCards1 = new BunifuCards();
		ckbUuTienMbasic = new CheckBox();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plCommentText.SuspendLayout();
		((ISupportInitialize)nudDelayDeleteFrom).BeginInit();
		E893BF37.SuspendLayout();
		((ISupportInitialize)F1A3658C).BeginInit();
		((ISupportInitialize)BA3CEE19).BeginInit();
		((ISupportInitialize)C72C673F).BeginInit();
		((ISupportInitialize)nudTimeTo).BeginInit();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudTimeFrom).BeginInit();
		((ISupportInitialize)A02CE11C).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = DD10609A;
		bunifuDragControl_0.Vertical = true;
		DD10609A.BackColor = Color.Transparent;
		DD10609A.Cursor = Cursors.SizeAll;
		DD10609A.Dock = DockStyle.Fill;
		DD10609A.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		DD10609A.ForeColor = Color.Black;
		DD10609A.Location = new Point(0, 0);
		DD10609A.Name = "bunifuCustomLabel1";
		DD10609A.Size = new Size(660, 31);
		DD10609A.TabIndex = 12;
		DD10609A.Text = "Câ\u0301u hi\u0300nh Uptop ba\u0300i viê\u0301t";
		DD10609A.TextAlign = ContentAlignment.MiddleCenter;
		D3388E38.Fixed = true;
		D3388E38.Horizontal = true;
		D3388E38.TargetControl = pnlHeader;
		D3388E38.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(DD10609A);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(660, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(629, 1);
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
		panel1.Controls.Add(CA2ED20E);
		panel1.Controls.Add(E7BDA408);
		panel1.Controls.Add(plCommentText);
		panel1.Controls.Add(nudDelayDeleteFrom);
		panel1.Controls.Add(E893BF37);
		panel1.Controls.Add(F1A3658C);
		panel1.Controls.Add(label49);
		panel1.Controls.Add(BA3CEE19);
		panel1.Controls.Add(C72C673F);
		panel1.Controls.Add(label66);
		panel1.Controls.Add(nudTimeTo);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudTimeFrom);
		panel1.Controls.Add(A02CE11C);
		panel1.Controls.Add(ACAA17B7);
		panel1.Controls.Add(F6979612);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(C48764B3);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(CE8200BE);
		panel1.Controls.Add(F1A5268E);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Controls.Add(ckbUuTienMbasic);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(663, 476);
		panel1.TabIndex = 0;
		panel1.Click += DEA797BD;
		panel1.Paint += FA9EA11D;
		CA2ED20E.AutoSize = true;
		CA2ED20E.Location = new Point(314, 108);
		CA2ED20E.Name = "label25";
		CA2ED20E.Size = new Size(135, 16);
		CA2ED20E.TabIndex = 34;
		CA2ED20E.Text = "Chơ\u0300 xo\u0301a comment (s):";
		E7BDA408.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		E7BDA408.Location = new Point(526, 108);
		E7BDA408.Name = "label27";
		E7BDA408.Size = new Size(29, 16);
		E7BDA408.TabIndex = 38;
		E7BDA408.Text = ">";
		E7BDA408.TextAlign = ContentAlignment.MiddleCenter;
		plCommentText.BorderStyle = BorderStyle.FixedSingle;
		plCommentText.Controls.Add(cbbTuyChonNoiDung);
		plCommentText.Controls.Add(btnHuongDanNhapNoiDung);
		plCommentText.Controls.Add(label8);
		plCommentText.Controls.Add(BE8AC0B5);
		plCommentText.Controls.Add(txtComment);
		plCommentText.Controls.Add(lblComment);
		plCommentText.Location = new Point(317, 135);
		plCommentText.Name = "plCommentText";
		plCommentText.Size = new Size(311, 273);
		plCommentText.TabIndex = 164;
		plCommentText.Paint += plCommentText_Paint;
		cbbTuyChonNoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		cbbTuyChonNoiDung.Cursor = Cursors.Hand;
		cbbTuyChonNoiDung.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbTuyChonNoiDung.FormattingEnabled = true;
		cbbTuyChonNoiDung.Location = new Point(69, 219);
		cbbTuyChonNoiDung.Name = "cbbTuyChonNoiDung";
		cbbTuyChonNoiDung.Size = new Size(202, 24);
		cbbTuyChonNoiDung.TabIndex = 180;
		cbbTuyChonNoiDung.SelectedIndexChanged += B2AC3A20;
		btnHuongDanNhapNoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		btnHuongDanNhapNoiDung.Cursor = Cursors.Hand;
		btnHuongDanNhapNoiDung.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnHuongDanNhapNoiDung.Location = new Point(277, 218);
		btnHuongDanNhapNoiDung.Name = "btnHuongDanNhapNoiDung";
		btnHuongDanNhapNoiDung.Size = new Size(26, 26);
		btnHuongDanNhapNoiDung.TabIndex = 179;
		btnHuongDanNhapNoiDung.Text = "?";
		btnHuongDanNhapNoiDung.UseVisualStyleBackColor = true;
		btnHuongDanNhapNoiDung.Click += btnHuongDanNhapNoiDung_Click;
		label8.AutoSize = true;
		label8.Location = new Point(3, 222);
		label8.Name = "label8";
		label8.Size = new Size(64, 16);
		label8.TabIndex = 178;
		label8.Text = "Tùy chọn:";
		BE8AC0B5.AutoSize = true;
		BE8AC0B5.Cursor = Cursors.Hand;
		BE8AC0B5.Location = new Point(6, 247);
		BE8AC0B5.Name = "ckbAutoDeleteComment";
		BE8AC0B5.Size = new Size(169, 20);
		BE8AC0B5.TabIndex = 176;
		BE8AC0B5.Text = "Xóa nội dung đã sư\u0309 du\u0323ng";
		BE8AC0B5.UseVisualStyleBackColor = true;
		txtComment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		txtComment.Location = new Point(7, 26);
		txtComment.Name = "txtComment";
		txtComment.Size = new Size(296, 186);
		txtComment.TabIndex = 1;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += BF3D1D28;
		lblComment.AutoSize = true;
		lblComment.Location = new Point(3, 6);
		lblComment.Name = "lblComment";
		lblComment.Size = new Size(139, 16);
		lblComment.TabIndex = 0;
		lblComment.Text = "Nội dung bình luận (0):";
		nudDelayDeleteFrom.Location = new Point(455, 106);
		nudDelayDeleteFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayDeleteFrom.Name = "nudDelayDeleteFrom";
		nudDelayDeleteFrom.Size = new Size(56, 23);
		nudDelayDeleteFrom.TabIndex = 5;
		E893BF37.BorderStyle = BorderStyle.FixedSingle;
		E893BF37.Controls.Add(label2);
		E893BF37.Controls.Add(txtIdPost);
		E893BF37.Controls.Add(A498A30D);
		E893BF37.Location = new Point(30, 135);
		E893BF37.Name = "panel2";
		E893BF37.Size = new Size(252, 273);
		E893BF37.TabIndex = 181;
		label2.AutoSize = true;
		label2.Location = new Point(3, 4);
		label2.Name = "label2";
		label2.Size = new Size(176, 16);
		label2.TabIndex = 40;
		label2.Text = "Nhâ\u0323p Id hoă\u0323c link ba\u0300i viê\u0301t (0):";
		txtIdPost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		txtIdPost.Location = new Point(6, 24);
		txtIdPost.Name = "txtIdPost";
		txtIdPost.Size = new Size(238, 220);
		txtIdPost.TabIndex = 1;
		txtIdPost.Text = "";
		txtIdPost.WordWrap = false;
		txtIdPost.TextChanged += txtIdPost_TextChanged;
		A498A30D.Anchor = AnchorStyles.Bottom;
		A498A30D.AutoSize = true;
		A498A30D.Cursor = Cursors.Hand;
		A498A30D.Location = new Point(6, 247);
		A498A30D.Name = "ckbTuDongXoa";
		A498A30D.Size = new Size(192, 20);
		A498A30D.TabIndex = 176;
		A498A30D.Text = "Xóa link ba\u0300i viê\u0301t đã tương tác";
		A498A30D.UseVisualStyleBackColor = true;
		F1A3658C.Location = new Point(572, 106);
		F1A3658C.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		F1A3658C.Name = "nudDelayDeleteTo";
		F1A3658C.Size = new Size(56, 23);
		F1A3658C.TabIndex = 6;
		label49.AutoSize = true;
		label49.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label49.Location = new Point(27, 79);
		label49.Name = "label49";
		label49.Size = new Size(84, 16);
		label49.TabIndex = 169;
		label49.Text = "Sô\u0301 lươ\u0323ng ba\u0300i:";
		BA3CEE19.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		BA3CEE19.Location = new Point(129, 77);
		BA3CEE19.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		BA3CEE19.Name = "nudSoLuongUidFrom";
		BA3CEE19.Size = new Size(56, 23);
		BA3CEE19.TabIndex = 167;
		BA3CEE19.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		C72C673F.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		C72C673F.Location = new Point(226, 77);
		C72C673F.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		C72C673F.Name = "nudSoLuongUidTo";
		C72C673F.Size = new Size(56, 23);
		C72C673F.TabIndex = 168;
		C72C673F.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		label66.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 163);
		label66.Location = new Point(191, 79);
		label66.Name = "label66";
		label66.Size = new Size(29, 16);
		label66.TabIndex = 171;
		label66.Text = ">";
		label66.TextAlign = ContentAlignment.MiddleCenter;
		nudTimeTo.Location = new Point(572, 77);
		nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeTo.Name = "nudTimeTo";
		nudTimeTo.Size = new Size(56, 23);
		nudTimeTo.TabIndex = 4;
		nudDelayTo.Location = new Point(226, 106);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudTimeFrom.Location = new Point(455, 77);
		nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeFrom.Name = "nudTimeFrom";
		nudTimeFrom.Size = new Size(56, 23);
		nudTimeFrom.TabIndex = 3;
		A02CE11C.Location = new Point(129, 106);
		A02CE11C.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A02CE11C.Name = "nudDelayFrom";
		A02CE11C.Size = new Size(56, 23);
		A02CE11C.TabIndex = 3;
		ACAA17B7.Location = new Point(129, 49);
		ACAA17B7.Name = "txtTenHanhDong";
		ACAA17B7.Size = new Size(153, 23);
		ACAA17B7.TabIndex = 0;
		F6979612.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		F6979612.Location = new Point(526, 79);
		F6979612.Name = "label9";
		F6979612.Size = new Size(29, 16);
		F6979612.TabIndex = 38;
		F6979612.Text = ">";
		F6979612.TextAlign = ContentAlignment.MiddleCenter;
		label7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label7.Location = new Point(191, 108);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = ">";
		label7.TextAlign = ContentAlignment.MiddleCenter;
		C48764B3.AutoSize = true;
		C48764B3.Location = new Point(314, 79);
		C48764B3.Name = "label3";
		C48764B3.Size = new Size(103, 16);
		C48764B3.TabIndex = 34;
		C48764B3.Text = "Xem bài viết (s):";
		label5.AutoSize = true;
		label5.Location = new Point(27, 108);
		label5.Name = "label5";
		label5.Size = new Size(87, 16);
		label5.TabIndex = 34;
		label5.Text = "Gia\u0303n ca\u0301ch (s):";
		CE8200BE.AutoSize = true;
		CE8200BE.Location = new Point(27, 52);
		CE8200BE.Name = "label1";
		CE8200BE.Size = new Size(98, 16);
		CE8200BE.TabIndex = 31;
		CE8200BE.Text = "Tên ha\u0300nh đô\u0323ng:";
		F1A5268E.Anchor = AnchorStyles.Bottom;
		F1A5268E.BackColor = Color.Maroon;
		F1A5268E.Cursor = Cursors.Hand;
		F1A5268E.FlatAppearance.BorderSize = 0;
		F1A5268E.FlatStyle = FlatStyle.Flat;
		F1A5268E.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		F1A5268E.ForeColor = Color.White;
		F1A5268E.Location = new Point(317, 434);
		F1A5268E.Name = "btnCancel";
		F1A5268E.Size = new Size(92, 29);
		F1A5268E.TabIndex = 10;
		F1A5268E.Text = "Đóng";
		F1A5268E.UseVisualStyleBackColor = false;
		F1A5268E.Click += B6B3B68E;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(210, 434);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(660, 37);
		bunifuCards1.TabIndex = 28;
		ckbUuTienMbasic.AutoSize = true;
		ckbUuTienMbasic.Cursor = Cursors.Hand;
		ckbUuTienMbasic.Location = new Point(30, 414);
		ckbUuTienMbasic.Name = "ckbUuTienMbasic";
		ckbUuTienMbasic.Size = new Size(173, 20);
		ckbUuTienMbasic.TabIndex = 176;
		ckbUuTienMbasic.Text = "Ưu tiên chạy bằng mbasic";
		ckbUuTienMbasic.UseVisualStyleBackColor = true;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(663, 476);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDUptopBaiViet";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += A38C25A7_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		plCommentText.ResumeLayout(performLayout: false);
		plCommentText.PerformLayout();
		((ISupportInitialize)nudDelayDeleteFrom).EndInit();
		E893BF37.ResumeLayout(performLayout: false);
		E893BF37.PerformLayout();
		((ISupportInitialize)F1A3658C).EndInit();
		((ISupportInitialize)BA3CEE19).EndInit();
		((ISupportInitialize)C72C673F).EndInit();
		((ISupportInitialize)nudTimeTo).EndInit();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudTimeFrom).EndInit();
		((ISupportInitialize)A02CE11C).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
