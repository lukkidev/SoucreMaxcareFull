using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDHuyLikePage : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string C1AA2FB7;

	private string string_1;

	private int int_0;

	public static bool A708DA8E;

	private IContainer icontainer_0 = null;

	private BunifuDragControl F82159AA;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label A0A78809;

	private Label D08B569D;

	private Label label1;

	private Button btnCancel;

	private Button A2922805;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button E8A86A0A;

	private PictureBox pictureBox1;

	private BunifuCustomLabel D7966625;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label DB3ACB0D;

	private Label label6;

	private Label label5;

	public fHDHuyLikePage(string string_2, int int_1 = 0, string string_3 = "")
	{
		InitializeComponent();
		A708DA8E = false;
		string_0 = string_2;
		string_1 = string_3;
		int_0 = int_1;
		if (Class147.smethod_7("", "HDHuyLikePage").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDHuyLikePage', 'Hủy like page');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDHuyLikePage");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			C1AA2FB7 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			A2922805.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void AC23AA3F()
	{
		F7AB102E.smethod_1(D7966625);
		F7AB102E.smethod_1(label1);
		F7AB102E.smethod_1(D08B569D);
		F7AB102E.smethod_1(label3);
		F7AB102E.smethod_1(A0A78809);
		F7AB102E.smethod_1(label5);
		F7AB102E.smethod_1(DB3ACB0D);
		F7AB102E.smethod_1(label6);
		F7AB102E.smethod_1(A2922805);
		F7AB102E.smethod_1(btnCancel);
	}

	private void fHDHuyLikePage_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = gclass11_0.method_2("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass11_0.method_2("nudSoLuongTo", 3);
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
		}
		catch
		{
		}
	}

	private void E8A86A0A_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A2922805_Click(object sender, EventArgs e)
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
		string string_ = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, C1AA2FB7, string_))
				{
					A708DA8E = true;
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
				A708DA8E = true;
				Close();
			}
			else
			{
				GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void D835BC09(object sender, EventArgs e)
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDHuyLikePage));
		F82159AA = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		D7966625 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		E8A86A0A = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		DB3ACB0D = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		A0A78809 = new System.Windows.Forms.Label();
		D08B569D = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		A2922805 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		F82159AA.Fixed = true;
		F82159AA.Horizontal = true;
		F82159AA.TargetControl = D7966625;
		F82159AA.Vertical = true;
		D7966625.BackColor = System.Drawing.Color.Transparent;
		D7966625.Cursor = System.Windows.Forms.Cursors.SizeAll;
		D7966625.Dock = System.Windows.Forms.DockStyle.Fill;
		D7966625.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D7966625.ForeColor = System.Drawing.Color.Black;
		D7966625.Location = new System.Drawing.Point(0, 0);
		D7966625.Name = "bunifuCustomLabel1";
		D7966625.Size = new System.Drawing.Size(359, 31);
		D7966625.TabIndex = 12;
		D7966625.Text = "Cấu hình Hủy like page";
		D7966625.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(E8A86A0A);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(D7966625);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(359, 31);
		pnlHeader.TabIndex = 9;
		E8A86A0A.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		E8A86A0A.Cursor = System.Windows.Forms.Cursors.Hand;
		E8A86A0A.FlatAppearance.BorderSize = 0;
		E8A86A0A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E8A86A0A.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		E8A86A0A.ForeColor = System.Drawing.Color.White;
		E8A86A0A.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		E8A86A0A.Location = new System.Drawing.Point(328, 1);
		E8A86A0A.Name = "button1";
		E8A86A0A.Size = new System.Drawing.Size(30, 30);
		E8A86A0A.TabIndex = 77;
		E8A86A0A.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		E8A86A0A.UseVisualStyleBackColor = true;
		E8A86A0A.Click += new System.EventHandler(E8A86A0A_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(DB3ACB0D);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(A0A78809);
		panel1.Controls.Add(D08B569D);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(A2922805);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 206);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		nudDelayTo.Location = new System.Drawing.Point(223, 112);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(132, 112);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		DB3ACB0D.Location = new System.Drawing.Point(191, 114);
		DB3ACB0D.Name = "label7";
		DB3ACB0D.Size = new System.Drawing.Size(29, 16);
		DB3ACB0D.TabIndex = 46;
		DB3ACB0D.Text = "đê\u0301n";
		DB3ACB0D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(280, 114);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 114);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(89, 16);
		label5.TabIndex = 44;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		nudSoLuongTo.Location = new System.Drawing.Point(223, 81);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 81);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label3.Location = new System.Drawing.Point(191, 83);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		A0A78809.AutoSize = true;
		A0A78809.Location = new System.Drawing.Point(280, 83);
		A0A78809.Name = "label4";
		A0A78809.Size = new System.Drawing.Size(35, 16);
		A0A78809.TabIndex = 35;
		A0A78809.Text = "page";
		D08B569D.AutoSize = true;
		D08B569D.Location = new System.Drawing.Point(27, 83);
		D08B569D.Name = "label2";
		D08B569D.Size = new System.Drawing.Size(63, 16);
		D08B569D.TabIndex = 32;
		D08B569D.Text = "Sô\u0301 lươ\u0323ng:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(191, 158);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(D835BC09);
		A2922805.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		A2922805.Cursor = System.Windows.Forms.Cursors.Hand;
		A2922805.FlatAppearance.BorderSize = 0;
		A2922805.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A2922805.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A2922805.ForeColor = System.Drawing.Color.White;
		A2922805.Location = new System.Drawing.Point(84, 158);
		A2922805.Name = "btnAdd";
		A2922805.Size = new System.Drawing.Size(92, 29);
		A2922805.TabIndex = 6;
		A2922805.Text = "Thêm";
		A2922805.UseVisualStyleBackColor = false;
		A2922805.Click += new System.EventHandler(A2922805_Click);
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
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 206);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDHuyLikePage";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDHuyLikePage_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
