using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDXoaTinNhan : Form
{
	private GClass11 gclass11_0 = null;

	private string string_0;

	private string string_1;

	private string EFAACA26;

	private int EF83BDB2;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl CD08FF02;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private TextBox txtTenHanhDong;

	private Label A6AAB08D;

	private Label label6;

	private Label label5;

	private Label label1;

	private Button D703F23C;

	private Button F283C7BB;

	private BunifuCards FC26F49B;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown D9146BA2;

	private NumericUpDown nudSoLuongFrom;

	private Label label2;

	private Label E32F9DA0;

	private Label C42E1716;

	public fHDXoaTinNhan(string string_2, int int_0 = 0, string string_3 = "")
	{
		BCBA3E33();
		bool_0 = false;
		string_0 = string_2;
		EFAACA26 = string_3;
		EF83BDB2 = int_0;
		if (Class147.smethod_7("", "HDXoaTinNhan").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDXoaTinNhan', 'Xóa tin nhắn');");
		}
		string text = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDXoaTinNhan");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			F283C7BB.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(label1);
		F7AB102E.smethod_1(label5);
		F7AB102E.smethod_1(A6AAB08D);
		F7AB102E.smethod_1(label6);
		F7AB102E.smethod_1(F283C7BB);
		F7AB102E.smethod_1(D703F23C);
	}

	private void fHDXoaTinNhan_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = gclass11_0.method_2("nudSoLuongFrom", 3);
			D9146BA2.Value = gclass11_0.method_2("nudSoLuongTo", 3);
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F283C7BB_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_4("nudSoLuongTo", D9146BA2.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		string string_ = gClass.method_7();
		if (EF83BDB2 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, string_))
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
			if (Class147.smethod_13(EFAACA26, text, string_))
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

	private void D703F23C_Click(object sender, EventArgs e)
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

	protected override void Dispose(bool B10405B7)
	{
		if (B10405B7 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B10405B7);
	}

	private void BCBA3E33()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDXoaTinNhan));
		CD08FF02 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		D9146BA2 = new NumericUpDown();
		nudSoLuongFrom = new NumericUpDown();
		label2 = new Label();
		E32F9DA0 = new Label();
		C42E1716 = new Label();
		nudDelayTo = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		A6AAB08D = new Label();
		label6 = new Label();
		label5 = new Label();
		label1 = new Label();
		D703F23C = new Button();
		F283C7BB = new Button();
		FC26F49B = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((ISupportInitialize)D9146BA2).BeginInit();
		((ISupportInitialize)nudSoLuongFrom).BeginInit();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		FC26F49B.SuspendLayout();
		SuspendLayout();
		CD08FF02.Fixed = true;
		CD08FF02.Horizontal = true;
		CD08FF02.TargetControl = bunifuCustomLabel1;
		CD08FF02.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Xóa tin nhắn";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
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
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(328, 1);
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
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(D9146BA2);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(E32F9DA0);
		panel1.Controls.Add(C42E1716);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(A6AAB08D);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(D703F23C);
		panel1.Controls.Add(F283C7BB);
		panel1.Controls.Add(FC26F49B);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(362, 182);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		D9146BA2.Location = new Point(229, 78);
		D9146BA2.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D9146BA2.Name = "nudSoLuongTo";
		D9146BA2.Size = new Size(56, 23);
		D9146BA2.TabIndex = 40;
		nudSoLuongFrom.Location = new Point(132, 78);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new Size(56, 23);
		nudSoLuongFrom.TabIndex = 39;
		label2.Location = new Point(194, 80);
		label2.Name = "label2";
		label2.Size = new Size(29, 16);
		label2.TabIndex = 43;
		label2.Text = "đê\u0301n";
		label2.TextAlign = ContentAlignment.MiddleCenter;
		E32F9DA0.AutoSize = true;
		E32F9DA0.Location = new Point(287, 80);
		E32F9DA0.Name = "label3";
		E32F9DA0.Size = new Size(53, 16);
		E32F9DA0.TabIndex = 42;
		E32F9DA0.Text = "tin nhắn";
		C42E1716.AutoSize = true;
		C42E1716.Location = new Point(27, 80);
		C42E1716.Name = "label4";
		C42E1716.Size = new Size(63, 16);
		C42E1716.TabIndex = 41;
		C42E1716.Text = "Số lượng:";
		nudDelayTo.Location = new Point(229, 108);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudDelayFrom.Location = new Point(132, 108);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		A6AAB08D.Location = new Point(194, 110);
		A6AAB08D.Name = "label7";
		A6AAB08D.Size = new Size(29, 16);
		A6AAB08D.TabIndex = 38;
		A6AAB08D.Text = "đê\u0301n";
		A6AAB08D.TextAlign = ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new Point(287, 110);
		label6.Name = "label6";
		label6.Size = new Size(30, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new Point(27, 110);
		label5.Name = "label5";
		label5.Size = new Size(89, 16);
		label5.TabIndex = 34;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		D703F23C.BackColor = Color.Maroon;
		D703F23C.Cursor = Cursors.Hand;
		D703F23C.FlatAppearance.BorderSize = 0;
		D703F23C.FlatStyle = FlatStyle.Flat;
		D703F23C.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		D703F23C.ForeColor = Color.White;
		D703F23C.Location = new Point(190, 140);
		D703F23C.Name = "btnCancel";
		D703F23C.Size = new Size(92, 29);
		D703F23C.TabIndex = 10;
		D703F23C.Text = "Đóng";
		D703F23C.UseVisualStyleBackColor = false;
		D703F23C.Click += D703F23C_Click;
		F283C7BB.BackColor = Color.FromArgb(53, 120, 229);
		F283C7BB.Cursor = Cursors.Hand;
		F283C7BB.FlatAppearance.BorderSize = 0;
		F283C7BB.FlatStyle = FlatStyle.Flat;
		F283C7BB.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		F283C7BB.ForeColor = Color.White;
		F283C7BB.Location = new Point(83, 140);
		F283C7BB.Name = "btnAdd";
		F283C7BB.Size = new Size(92, 29);
		F283C7BB.TabIndex = 9;
		F283C7BB.Text = "Thêm";
		F283C7BB.UseVisualStyleBackColor = false;
		F283C7BB.Click += F283C7BB_Click;
		FC26F49B.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		FC26F49B.BackColor = Color.White;
		FC26F49B.BorderRadius = 0;
		FC26F49B.BottomSahddow = true;
		FC26F49B.color = Color.DarkViolet;
		FC26F49B.Controls.Add(pnlHeader);
		FC26F49B.LeftSahddow = false;
		FC26F49B.Location = new Point(1, 0);
		FC26F49B.Name = "bunifuCards1";
		FC26F49B.RightSahddow = true;
		FC26F49B.ShadowDepth = 20;
		FC26F49B.Size = new Size(359, 37);
		FC26F49B.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(362, 182);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDXoaTinNhan";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDXoaTinNhan_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		((ISupportInitialize)D9146BA2).EndInit();
		((ISupportInitialize)nudSoLuongFrom).EndInit();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		FC26F49B.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
