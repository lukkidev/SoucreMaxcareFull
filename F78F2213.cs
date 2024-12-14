using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class F78F2213 : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string D6328634;

	private string string_1;

	private int C809CFAF;

	public static bool bool_0;

	private IContainer EF8FB5A1 = null;

	private BunifuDragControl A989E69D;

	private BunifuDragControl bunifuDragControl_0;

	private Panel A1852C0E;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox EEB7BE80;

	private Label label3;

	private Label D00CB98B;

	private Label BD85FD26;

	private Button A215E036;

	private Button E302D607;

	private BunifuCards bunifuCards1;

	private Panel FDA16331;

	private Button A5980A8F;

	private PictureBox F037840F;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown D528348F;

	private NumericUpDown nudDelayFrom;

	private Label E58D382D;

	private Label BB037B17;

	private NumericUpDown nudTimesWarning;

	private Label label9;

	private Label label8;

	private CheckBox ckbChiKetBanTenCoDau;

	private CheckBox F21EE23F;

	public F78F2213(string string_2, int B5B9EA2C = 0, string F30B263B = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_2;
		string_1 = F30B263B;
		C809CFAF = B5B9EA2C;
		string text = "";
		switch (B5B9EA2C)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDKetBanGoiY");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			D6328634 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			EEB7BE80.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(F30B263B);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			E302D607.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			EEB7BE80.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void F78F2213_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = gclass11_0.method_2("nudSoLuongFrom");
			nudSoLuongTo.Value = gclass11_0.method_2("nudSoLuongTo");
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom");
			D528348F.Value = gclass11_0.method_2("nudDelayTo");
			ckbChiKetBanTenCoDau.Checked = gclass11_0.method_3("ckbChiKetBanTenCoDau");
			F21EE23F.Checked = gclass11_0.method_3("ckbOnlyAddFriendWithMutualFriends");
			nudTimesWarning.Value = gclass11_0.method_2("nudTimesWarning", 5);
		}
		catch
		{
		}
	}

	private void D1B8921F(object sender, EventArgs e)
	{
		Close();
	}

	private void E302D607_Click(object sender, EventArgs e)
	{
		string text = EEB7BE80.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", D528348F.Value);
		gClass.method_4("ckbChiKetBanTenCoDau", ckbChiKetBanTenCoDau.Checked);
		gClass.method_4("ckbOnlyAddFriendWithMutualFriends", F21EE23F.Checked);
		gClass.method_4("nudTimesWarning", nudTimesWarning.Value);
		string string_ = gClass.method_7();
		if (C809CFAF == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, D6328634, string_))
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

	private void A0A766B3(object sender, EventArgs e)
	{
		Close();
	}

	private void F608450E(object sender, PaintEventArgs e)
	{
		if (A1852C0E.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, A1852C0E.ClientSize.Width - num, A1852C0E.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool A608F60F)
	{
		if (A608F60F && EF8FB5A1 != null)
		{
			EF8FB5A1.Dispose();
		}
		base.Dispose(A608F60F);
	}

	private void InitializeComponent()
	{
		EF8FB5A1 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F78F2213));
		A989E69D = new Bunifu.Framework.UI.BunifuDragControl(EF8FB5A1);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(EF8FB5A1);
		FDA16331 = new System.Windows.Forms.Panel();
		A5980A8F = new System.Windows.Forms.Button();
		F037840F = new System.Windows.Forms.PictureBox();
		A1852C0E = new System.Windows.Forms.Panel();
		F21EE23F = new System.Windows.Forms.CheckBox();
		ckbChiKetBanTenCoDau = new System.Windows.Forms.CheckBox();
		nudTimesWarning = new System.Windows.Forms.NumericUpDown();
		D528348F = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		label9 = new System.Windows.Forms.Label();
		E58D382D = new System.Windows.Forms.Label();
		label8 = new System.Windows.Forms.Label();
		BB037B17 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		EEB7BE80 = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		D00CB98B = new System.Windows.Forms.Label();
		BD85FD26 = new System.Windows.Forms.Label();
		A215E036 = new System.Windows.Forms.Button();
		E302D607 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		FDA16331.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)F037840F).BeginInit();
		A1852C0E.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudTimesWarning).BeginInit();
		((System.ComponentModel.ISupportInitialize)D528348F).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		A989E69D.Fixed = true;
		A989E69D.Horizontal = true;
		A989E69D.TargetControl = bunifuCustomLabel1;
		A989E69D.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Kết bạn gợi ý";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = FDA16331;
		bunifuDragControl_0.Vertical = true;
		FDA16331.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		FDA16331.BackColor = System.Drawing.Color.White;
		FDA16331.Controls.Add(A5980A8F);
		FDA16331.Controls.Add(F037840F);
		FDA16331.Controls.Add(bunifuCustomLabel1);
		FDA16331.Cursor = System.Windows.Forms.Cursors.SizeAll;
		FDA16331.Location = new System.Drawing.Point(0, 3);
		FDA16331.Name = "pnlHeader";
		FDA16331.Size = new System.Drawing.Size(359, 31);
		FDA16331.TabIndex = 9;
		A5980A8F.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		A5980A8F.Cursor = System.Windows.Forms.Cursors.Hand;
		A5980A8F.FlatAppearance.BorderSize = 0;
		A5980A8F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A5980A8F.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A5980A8F.ForeColor = System.Drawing.Color.White;
		A5980A8F.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		A5980A8F.Location = new System.Drawing.Point(328, 1);
		A5980A8F.Name = "button1";
		A5980A8F.Size = new System.Drawing.Size(30, 30);
		A5980A8F.TabIndex = 77;
		A5980A8F.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		A5980A8F.UseVisualStyleBackColor = true;
		A5980A8F.Click += new System.EventHandler(D1B8921F);
		F037840F.Cursor = System.Windows.Forms.Cursors.Default;
		F037840F.Image = C50FB39E.Bitmap_5;
		F037840F.Location = new System.Drawing.Point(3, 2);
		F037840F.Name = "pictureBox1";
		F037840F.Size = new System.Drawing.Size(34, 27);
		F037840F.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		F037840F.TabIndex = 76;
		F037840F.TabStop = false;
		A1852C0E.BackColor = System.Drawing.Color.White;
		A1852C0E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		A1852C0E.Controls.Add(F21EE23F);
		A1852C0E.Controls.Add(ckbChiKetBanTenCoDau);
		A1852C0E.Controls.Add(nudTimesWarning);
		A1852C0E.Controls.Add(D528348F);
		A1852C0E.Controls.Add(nudDelayFrom);
		A1852C0E.Controls.Add(label9);
		A1852C0E.Controls.Add(E58D382D);
		A1852C0E.Controls.Add(label8);
		A1852C0E.Controls.Add(BB037B17);
		A1852C0E.Controls.Add(nudSoLuongTo);
		A1852C0E.Controls.Add(nudSoLuongFrom);
		A1852C0E.Controls.Add(EEB7BE80);
		A1852C0E.Controls.Add(label3);
		A1852C0E.Controls.Add(D00CB98B);
		A1852C0E.Controls.Add(BD85FD26);
		A1852C0E.Controls.Add(A215E036);
		A1852C0E.Controls.Add(E302D607);
		A1852C0E.Controls.Add(bunifuCards1);
		A1852C0E.Cursor = System.Windows.Forms.Cursors.Arrow;
		A1852C0E.Dock = System.Windows.Forms.DockStyle.Fill;
		A1852C0E.Location = new System.Drawing.Point(0, 0);
		A1852C0E.Name = "panel1";
		A1852C0E.Size = new System.Drawing.Size(362, 222);
		A1852C0E.TabIndex = 0;
		A1852C0E.Paint += new System.Windows.Forms.PaintEventHandler(F608450E);
		F21EE23F.AutoSize = true;
		F21EE23F.Cursor = System.Windows.Forms.Cursors.Hand;
		F21EE23F.Location = new System.Drawing.Point(30, 297);
		F21EE23F.Name = "ckbOnlyAddFriendWithMutualFriends";
		F21EE23F.Size = new System.Drawing.Size(226, 20);
		F21EE23F.TabIndex = 47;
		F21EE23F.Text = "Chỉ kết bạn với người có bạn chung";
		F21EE23F.UseVisualStyleBackColor = true;
		ckbChiKetBanTenCoDau.AutoSize = true;
		ckbChiKetBanTenCoDau.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbChiKetBanTenCoDau.Location = new System.Drawing.Point(30, 271);
		ckbChiKetBanTenCoDau.Name = "ckbChiKetBanTenCoDau";
		ckbChiKetBanTenCoDau.Size = new System.Drawing.Size(211, 20);
		ckbChiKetBanTenCoDau.TabIndex = 47;
		ckbChiKetBanTenCoDau.Text = "Chỉ kết bạn với người có tên Việt";
		ckbChiKetBanTenCoDau.UseVisualStyleBackColor = true;
		nudTimesWarning.Location = new System.Drawing.Point(253, 137);
		nudTimesWarning.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimesWarning.Name = "nudTimesWarning";
		nudTimesWarning.Size = new System.Drawing.Size(43, 23);
		nudTimesWarning.TabIndex = 4;
		D528348F.Location = new System.Drawing.Point(229, 107);
		D528348F.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D528348F.Name = "nudDelayTo";
		D528348F.Size = new System.Drawing.Size(56, 23);
		D528348F.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(132, 107);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(299, 139);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(24, 16);
		label9.TabIndex = 45;
		label9.Text = "lần";
		E58D382D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E58D382D.Location = new System.Drawing.Point(194, 109);
		E58D382D.Name = "label7";
		E58D382D.Size = new System.Drawing.Size(29, 16);
		E58D382D.TabIndex = 46;
		E58D382D.Text = ">";
		E58D382D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(27, 139);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(225, 16);
		label8.TabIndex = 44;
		label8.Text = "Dừng khi gặp cảnh báo của Facebook:";
		BB037B17.AutoSize = true;
		BB037B17.Location = new System.Drawing.Point(27, 109);
		BB037B17.Name = "label5";
		BB037B17.Size = new System.Drawing.Size(87, 16);
		BB037B17.TabIndex = 44;
		BB037B17.Text = "Gia\u0303n ca\u0301ch (s):";
		nudSoLuongTo.Location = new System.Drawing.Point(229, 78);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 78);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		EEB7BE80.Location = new System.Drawing.Point(132, 49);
		EEB7BE80.Name = "txtTenHanhDong";
		EEB7BE80.Size = new System.Drawing.Size(194, 23);
		EEB7BE80.TabIndex = 0;
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(194, 80);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = ">";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D00CB98B.AutoSize = true;
		D00CB98B.Location = new System.Drawing.Point(27, 80);
		D00CB98B.Name = "label2";
		D00CB98B.Size = new System.Drawing.Size(88, 16);
		D00CB98B.TabIndex = 32;
		D00CB98B.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		BD85FD26.AutoSize = true;
		BD85FD26.Location = new System.Drawing.Point(27, 52);
		BD85FD26.Name = "label1";
		BD85FD26.Size = new System.Drawing.Size(98, 16);
		BD85FD26.TabIndex = 31;
		BD85FD26.Text = "Tên ha\u0300nh đô\u0323ng:";
		A215E036.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		A215E036.BackColor = System.Drawing.Color.Maroon;
		A215E036.Cursor = System.Windows.Forms.Cursors.Hand;
		A215E036.FlatAppearance.BorderSize = 0;
		A215E036.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A215E036.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A215E036.ForeColor = System.Drawing.Color.White;
		A215E036.Location = new System.Drawing.Point(187, 178);
		A215E036.Name = "btnCancel";
		A215E036.Size = new System.Drawing.Size(92, 29);
		A215E036.TabIndex = 7;
		A215E036.Text = "Đóng";
		A215E036.UseVisualStyleBackColor = false;
		A215E036.Click += new System.EventHandler(A0A766B3);
		E302D607.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		E302D607.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		E302D607.Cursor = System.Windows.Forms.Cursors.Hand;
		E302D607.FlatAppearance.BorderSize = 0;
		E302D607.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E302D607.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E302D607.ForeColor = System.Drawing.Color.White;
		E302D607.Location = new System.Drawing.Point(80, 178);
		E302D607.Name = "btnAdd";
		E302D607.Size = new System.Drawing.Size(92, 29);
		E302D607.TabIndex = 6;
		E302D607.Text = "Thêm";
		E302D607.UseVisualStyleBackColor = false;
		E302D607.Click += new System.EventHandler(E302D607_Click);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(FDA16331);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 222);
		base.Controls.Add(A1852C0E);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanGoiY";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(F78F2213_Load);
		FDA16331.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)F037840F).EndInit();
		A1852C0E.ResumeLayout(false);
		A1852C0E.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudTimesWarning).EndInit();
		((System.ComponentModel.ISupportInitialize)D528348F).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
