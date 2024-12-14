using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDKetBanVoiBanCuaBanBe : Form
{
	private GClass11 E9A682B0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool EE22CB0E;

	private IContainer B9A4FE27 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl D091FE08;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown EE86FEB8;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label label4;

	private Label B531662A;

	private Label C70C818B;

	private Button B2166C99;

	private Button B0107A0B;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown CC920DA7;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label A93ADB3A;

	private Label label5;

	private NumericUpDown A439E184;

	private Label label9;

	private Label BCB14B98;

	public fHDKetBanVoiBanCuaBanBe(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		EE22CB0E = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		if (Class147.smethod_7("", "HDKetBanVoiBanCuaBanBe").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDKetBanVoiBanCuaBanBe', 'Kết bạn với bạn của Bạn bè');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDKetBanVoiBanCuaBanBe");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_4);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			B0107A0B.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		E9A682B0 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(C70C818B);
		F7AB102E.smethod_1(B531662A);
		F7AB102E.smethod_1(label3);
		F7AB102E.smethod_1(label4);
		F7AB102E.smethod_1(label5);
		F7AB102E.smethod_1(label7);
		F7AB102E.smethod_1(A93ADB3A);
		F7AB102E.smethod_1(B0107A0B);
		F7AB102E.smethod_1(B2166C99);
	}

	private void fHDKetBanVoiBanCuaBanBe_Load(object sender, EventArgs e)
	{
		try
		{
			EE86FEB8.Value = E9A682B0.method_2("nudSoLuongFrom", 3);
			nudSoLuongTo.Value = E9A682B0.method_2("nudSoLuongTo", 5);
			nudDelayFrom.Value = E9A682B0.method_2("nudDelayFrom", 3);
			CC920DA7.Value = E9A682B0.method_2("nudDelayTo", 5);
			A439E184.Value = E9A682B0.method_2("nudTimesWarning", 3);
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void D7229F00(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", EE86FEB8.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", CC920DA7.Value);
		gClass.method_4("nudTimesWarning", A439E184.Value);
		string text2 = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, text2))
				{
					EE22CB0E = true;
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
				EE22CB0E = true;
				Close();
			}
			else
			{
				GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void B2166C99_Click(object sender, EventArgs e)
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
		if (B803E003 && B9A4FE27 != null)
		{
			B9A4FE27.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		B9A4FE27 = new System.ComponentModel.Container();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(B9A4FE27);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		D091FE08 = new Bunifu.Framework.UI.BunifuDragControl(B9A4FE27);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		A439E184 = new System.Windows.Forms.NumericUpDown();
		CC920DA7 = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		label9 = new System.Windows.Forms.Label();
		label7 = new System.Windows.Forms.Label();
		A93ADB3A = new System.Windows.Forms.Label();
		BCB14B98 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		EE86FEB8 = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		B531662A = new System.Windows.Forms.Label();
		C70C818B = new System.Windows.Forms.Label();
		B2166C99 = new System.Windows.Forms.Button();
		B0107A0B = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)A439E184).BeginInit();
		((System.ComponentModel.ISupportInitialize)CC920DA7).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)EE86FEB8).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Kết bạn với bạn của Bạn bè";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D091FE08.Fixed = true;
		D091FE08.Horizontal = true;
		D091FE08.TargetControl = pnlHeader;
		D091FE08.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(359, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = C50FB39E.Bitmap_12;
		button1.Location = new System.Drawing.Point(328, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
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
		panel1.Controls.Add(A439E184);
		panel1.Controls.Add(CC920DA7);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(label9);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(A93ADB3A);
		panel1.Controls.Add(BCB14B98);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(EE86FEB8);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(B531662A);
		panel1.Controls.Add(C70C818B);
		panel1.Controls.Add(B2166C99);
		panel1.Controls.Add(B0107A0B);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 187);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		A439E184.Location = new System.Drawing.Point(253, 220);
		A439E184.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A439E184.Name = "nudTimesWarning";
		A439E184.Size = new System.Drawing.Size(43, 23);
		A439E184.TabIndex = 4;
		CC920DA7.Location = new System.Drawing.Point(229, 112);
		CC920DA7.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		CC920DA7.Name = "nudDelayTo";
		CC920DA7.Size = new System.Drawing.Size(56, 23);
		CC920DA7.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(132, 112);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(299, 222);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(25, 16);
		label9.TabIndex = 45;
		label9.Text = "lần";
		label7.AutoSize = true;
		label7.Location = new System.Drawing.Point(194, 114);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		A93ADB3A.AutoSize = true;
		A93ADB3A.Location = new System.Drawing.Point(290, 114);
		A93ADB3A.Name = "label6";
		A93ADB3A.Size = new System.Drawing.Size(31, 16);
		A93ADB3A.TabIndex = 45;
		A93ADB3A.Text = "giây";
		BCB14B98.AutoSize = true;
		BCB14B98.Location = new System.Drawing.Point(27, 222);
		BCB14B98.Name = "label8";
		BCB14B98.Size = new System.Drawing.Size(226, 16);
		BCB14B98.TabIndex = 44;
		BCB14B98.Text = "Dừng khi gặp cảnh báo của Facebook:";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 114);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(90, 16);
		label5.TabIndex = 44;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		nudSoLuongTo.Location = new System.Drawing.Point(229, 81);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		EE86FEB8.Location = new System.Drawing.Point(132, 81);
		EE86FEB8.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		EE86FEB8.Name = "nudSoLuongFrom";
		EE86FEB8.Size = new System.Drawing.Size(56, 23);
		EE86FEB8.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(194, 83);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(290, 83);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(29, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0323n";
		B531662A.AutoSize = true;
		B531662A.Location = new System.Drawing.Point(27, 83);
		B531662A.Name = "label2";
		B531662A.Size = new System.Drawing.Size(89, 16);
		B531662A.TabIndex = 32;
		B531662A.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		C70C818B.AutoSize = true;
		C70C818B.Location = new System.Drawing.Point(27, 52);
		C70C818B.Name = "label1";
		C70C818B.Size = new System.Drawing.Size(99, 16);
		C70C818B.TabIndex = 31;
		C70C818B.Text = "Tên ha\u0300nh đô\u0323ng:";
		B2166C99.BackColor = System.Drawing.Color.Maroon;
		B2166C99.Cursor = System.Windows.Forms.Cursors.Hand;
		B2166C99.FlatAppearance.BorderSize = 0;
		B2166C99.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B2166C99.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B2166C99.ForeColor = System.Drawing.Color.White;
		B2166C99.Location = new System.Drawing.Point(193, 146);
		B2166C99.Name = "btnCancel";
		B2166C99.Size = new System.Drawing.Size(92, 29);
		B2166C99.TabIndex = 7;
		B2166C99.Text = "Đóng";
		B2166C99.UseVisualStyleBackColor = false;
		B2166C99.Click += new System.EventHandler(B2166C99_Click);
		B0107A0B.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		B0107A0B.Cursor = System.Windows.Forms.Cursors.Hand;
		B0107A0B.FlatAppearance.BorderSize = 0;
		B0107A0B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B0107A0B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B0107A0B.ForeColor = System.Drawing.Color.White;
		B0107A0B.Location = new System.Drawing.Point(86, 146);
		B0107A0B.Name = "btnAdd";
		B0107A0B.Size = new System.Drawing.Size(92, 29);
		B0107A0B.TabIndex = 6;
		B0107A0B.Text = "Thêm";
		B0107A0B.UseVisualStyleBackColor = false;
		B0107A0B.Click += new System.EventHandler(D7229F00);
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
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 187);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanVoiBanCuaBanBe";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDKetBanVoiBanCuaBanBe_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)A439E184).EndInit();
		((System.ComponentModel.ISupportInitialize)CC920DA7).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)EE86FEB8).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
