using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDKetBanNewfeed : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string F122F614;

	private string string_1;

	private int FD0EDD2D;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel A7128F05;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label D5B70D0A;

	private Label label4;

	private Label label2;

	private Label F396C12B;

	private Button CE8725A9;

	private Button B9B74D17;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox C19D1F13;

	private BunifuCustomLabel EE8965B6;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label6;

	private Label DBB09D9A;

	private NumericUpDown FEB3B62B;

	private Label label9;

	private Label label8;

	public fHDKetBanNewfeed(string string_2, int BEB18B21 = 0, string string_3 = "")
	{
		BB325924();
		bool_0 = false;
		string_0 = string_2;
		string_1 = string_3;
		FD0EDD2D = BEB18B21;
		if (Class147.smethod_7("", "HDKetBanNewfeed").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDKetBanNewfeed', 'Kết bạn Newfeed');");
		}
		string text = "";
		switch (BEB18B21)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDKetBanNewfeed");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			F122F614 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			B9B74D17.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(EE8965B6);
		F7AB102E.smethod_1(F396C12B);
		F7AB102E.smethod_1(label2);
		F7AB102E.smethod_1(D5B70D0A);
		F7AB102E.smethod_1(label4);
		F7AB102E.smethod_1(DBB09D9A);
		F7AB102E.smethod_1(label7);
		F7AB102E.smethod_1(label6);
		F7AB102E.smethod_1(B9B74D17);
		F7AB102E.smethod_1(CE8725A9);
	}

	private void fHDKetBanNewfeed_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = gclass11_0.method_2("nudSoLuongFrom", 3);
			nudSoLuongTo.Value = gclass11_0.method_2("nudSoLuongTo", 5);
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
			FEB3B62B.Value = gclass11_0.method_2("nudTimesWarning", 3);
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B9B74D17_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		gClass.method_4("nudTimesWarning", FEB3B62B.Value);
		string string_ = gClass.method_7();
		if (FD0EDD2D == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, F122F614, string_))
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
			if (Class147.smethod_13(string_1, text, string_))
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

	private void CE8725A9_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A7128F05_Paint(object sender, PaintEventArgs e)
	{
		if (A7128F05.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, A7128F05.ClientSize.Width - num, A7128F05.ClientSize.Height - num));
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

	private void BB325924()
	{
		icontainer_0 = new Container();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		EE8965B6 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		button1 = new Button();
		C19D1F13 = new PictureBox();
		A7128F05 = new Panel();
		FEB3B62B = new NumericUpDown();
		nudDelayTo = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		label9 = new Label();
		label7 = new Label();
		label6 = new Label();
		label8 = new Label();
		DBB09D9A = new Label();
		nudSoLuongTo = new NumericUpDown();
		nudSoLuongFrom = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		D5B70D0A = new Label();
		label4 = new Label();
		label2 = new Label();
		F396C12B = new Label();
		CE8725A9 = new Button();
		B9B74D17 = new Button();
		bunifuCards1 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)C19D1F13).BeginInit();
		A7128F05.SuspendLayout();
		((ISupportInitialize)FEB3B62B).BeginInit();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		((ISupportInitialize)nudSoLuongTo).BeginInit();
		((ISupportInitialize)nudSoLuongFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = EE8965B6;
		bunifuDragControl_0.Vertical = true;
		EE8965B6.BackColor = Color.Transparent;
		EE8965B6.Cursor = Cursors.SizeAll;
		EE8965B6.Dock = DockStyle.Fill;
		EE8965B6.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		EE8965B6.ForeColor = Color.Black;
		EE8965B6.Location = new Point(0, 0);
		EE8965B6.Name = "bunifuCustomLabel1";
		EE8965B6.Size = new Size(359, 31);
		EE8965B6.TabIndex = 12;
		EE8965B6.Text = "Cấu hình Kết bạn Newfeed";
		EE8965B6.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(C19D1F13);
		pnlHeader.Controls.Add(EE8965B6);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(359, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = C50FB39E.Bitmap_12;
		button1.Location = new Point(328, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += button1_Click;
		C19D1F13.Cursor = Cursors.Default;
		C19D1F13.Image = C50FB39E.Bitmap_5;
		C19D1F13.Location = new Point(3, 2);
		C19D1F13.Name = "pictureBox1";
		C19D1F13.Size = new Size(34, 27);
		C19D1F13.SizeMode = PictureBoxSizeMode.Zoom;
		C19D1F13.TabIndex = 76;
		C19D1F13.TabStop = false;
		A7128F05.BackColor = Color.White;
		A7128F05.BorderStyle = BorderStyle.FixedSingle;
		A7128F05.Controls.Add(FEB3B62B);
		A7128F05.Controls.Add(nudDelayTo);
		A7128F05.Controls.Add(nudDelayFrom);
		A7128F05.Controls.Add(label9);
		A7128F05.Controls.Add(label7);
		A7128F05.Controls.Add(label6);
		A7128F05.Controls.Add(label8);
		A7128F05.Controls.Add(DBB09D9A);
		A7128F05.Controls.Add(nudSoLuongTo);
		A7128F05.Controls.Add(nudSoLuongFrom);
		A7128F05.Controls.Add(txtTenHanhDong);
		A7128F05.Controls.Add(D5B70D0A);
		A7128F05.Controls.Add(label4);
		A7128F05.Controls.Add(label2);
		A7128F05.Controls.Add(F396C12B);
		A7128F05.Controls.Add(CE8725A9);
		A7128F05.Controls.Add(B9B74D17);
		A7128F05.Controls.Add(bunifuCards1);
		A7128F05.Cursor = Cursors.Arrow;
		A7128F05.Dock = DockStyle.Fill;
		A7128F05.Location = new Point(0, 0);
		A7128F05.Name = "panel1";
		A7128F05.Size = new Size(362, 192);
		A7128F05.TabIndex = 0;
		A7128F05.Paint += A7128F05_Paint;
		FEB3B62B.Location = new Point(253, 221);
		FEB3B62B.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		FEB3B62B.Name = "nudTimesWarning";
		FEB3B62B.Size = new Size(43, 23);
		FEB3B62B.TabIndex = 4;
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
		label9.AutoSize = true;
		label9.Location = new Point(299, 223);
		label9.Name = "label9";
		label9.Size = new Size(25, 16);
		label9.TabIndex = 45;
		label9.Text = "lần";
		label7.AutoSize = true;
		label7.Location = new Point(194, 114);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		label6.AutoSize = true;
		label6.Location = new Point(290, 114);
		label6.Name = "label6";
		label6.Size = new Size(31, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		label8.AutoSize = true;
		label8.Location = new Point(27, 223);
		label8.Name = "label8";
		label8.Size = new Size(226, 16);
		label8.TabIndex = 44;
		label8.Text = "Dừng khi gặp cảnh báo của Facebook:";
		DBB09D9A.AutoSize = true;
		DBB09D9A.Location = new Point(27, 114);
		DBB09D9A.Name = "label5";
		DBB09D9A.Size = new Size(90, 16);
		DBB09D9A.TabIndex = 44;
		DBB09D9A.Text = "Thơ\u0300i gian chơ\u0300:";
		nudSoLuongTo.Location = new Point(229, 81);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudSoLuongFrom.Location = new Point(132, 81);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		D5B70D0A.AutoSize = true;
		D5B70D0A.Location = new Point(194, 83);
		D5B70D0A.Name = "label3";
		D5B70D0A.Size = new Size(29, 16);
		D5B70D0A.TabIndex = 37;
		D5B70D0A.Text = "đê\u0301n";
		label4.AutoSize = true;
		label4.Location = new Point(290, 83);
		label4.Name = "label4";
		label4.Size = new Size(29, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0323n";
		label2.AutoSize = true;
		label2.Location = new Point(27, 83);
		label2.Name = "label2";
		label2.Size = new Size(89, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		F396C12B.AutoSize = true;
		F396C12B.Location = new Point(27, 52);
		F396C12B.Name = "label1";
		F396C12B.Size = new Size(99, 16);
		F396C12B.TabIndex = 31;
		F396C12B.Text = "Tên ha\u0300nh đô\u0323ng:";
		CE8725A9.BackColor = Color.Maroon;
		CE8725A9.Cursor = Cursors.Hand;
		CE8725A9.FlatAppearance.BorderSize = 0;
		CE8725A9.FlatStyle = FlatStyle.Flat;
		CE8725A9.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		CE8725A9.ForeColor = Color.White;
		CE8725A9.Location = new Point(191, 148);
		CE8725A9.Name = "btnCancel";
		CE8725A9.Size = new Size(92, 29);
		CE8725A9.TabIndex = 7;
		CE8725A9.Text = "Đóng";
		CE8725A9.UseVisualStyleBackColor = false;
		CE8725A9.Click += CE8725A9_Click;
		B9B74D17.BackColor = Color.FromArgb(53, 120, 229);
		B9B74D17.Cursor = Cursors.Hand;
		B9B74D17.FlatAppearance.BorderSize = 0;
		B9B74D17.FlatStyle = FlatStyle.Flat;
		B9B74D17.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		B9B74D17.ForeColor = Color.White;
		B9B74D17.Location = new Point(84, 148);
		B9B74D17.Name = "btnAdd";
		B9B74D17.Size = new Size(92, 29);
		B9B74D17.TabIndex = 6;
		B9B74D17.Text = "Thêm";
		B9B74D17.UseVisualStyleBackColor = false;
		B9B74D17.Click += B9B74D17_Click;
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
		bunifuCards1.Size = new Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(362, 192);
		base.Controls.Add(A7128F05);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanNewfeed";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDKetBanNewfeed_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)C19D1F13).EndInit();
		A7128F05.ResumeLayout(performLayout: false);
		A7128F05.PerformLayout();
		((ISupportInitialize)FEB3B62B).EndInit();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		((ISupportInitialize)nudSoLuongTo).EndInit();
		((ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
