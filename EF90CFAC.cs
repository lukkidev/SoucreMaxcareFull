using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class EF90CFAC : Form
{
	private GClass11 B4AC4209;

	private string string_0;

	private string string_1;

	private string B537E8AB;

	private int EF184B16;

	public static bool bool_0;

	private IContainer A4299E3B = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label D698DA05;

	private Button EB938406;

	private Button btnAdd;

	private BunifuCards EFA72502;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox EE18678F;

	private BunifuCustomLabel EE1C5B32;

	private RadioButton rbBat2FA;

	private RadioButton rbTat2FA;

	private Panel plBat2FA;

	private RadioButton rbXoa2FACu;

	private RadioButton E18B5D1D;

	private RadioButton FCA965A4;

	private Label C601C91E;

	private ComboBox C1A75E21;

	private Label E4BD8C12;

	public EF90CFAC(string D6AD7785, int CF0C589A = 0, string A8B6ECA3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = D6AD7785;
		B537E8AB = A8B6ECA3;
		EF184B16 = CF0C589A;
		string text = base.Name.Substring(1);
		string text2 = "Bật - Tắt 2FA";
		if (Class147.smethod_7("", text).Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (CF0C589A)
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
			DataTable dataTable = Class147.F3057616(A8B6ECA3);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		B4AC4209 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void F12EB386(object sender, EventArgs e)
	{
		try
		{
			List<string> list_ = new List<string> { "Bật", "Tắt" };
			GClass8.smethod_22(C1A75E21, list_);
			C1A75E21.SelectedIndex = B4AC4209.method_2("cbbTuyChon");
			if (B4AC4209.method_2("typeOnOff2FA") == 0)
			{
				rbTat2FA.Checked = true;
			}
			else
			{
				rbBat2FA.Checked = true;
			}
			if (B4AC4209.method_2("neuDaCo2FA") == 0)
			{
				FCA965A4.Checked = true;
			}
			else if (B4AC4209.method_2("neuDaCo2FA") == 1)
			{
				E18B5D1D.Checked = true;
			}
			else
			{
				rbXoa2FACu.Checked = true;
			}
			method_0(null, null);
			rbBat2FA_CheckedChanged(null, null);
		}
		catch
		{
		}
	}

	private void E6A2FC8F(object sender, EventArgs e)
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
		GClass11 gClass = new GClass11();
		gClass.method_4("cbbTuyChon", C1A75E21.SelectedIndex);
		if (rbTat2FA.Checked)
		{
			gClass.method_4("typeOnOff2FA", 0);
		}
		else
		{
			gClass.method_4("typeOnOff2FA", 1);
		}
		if (FCA965A4.Checked)
		{
			gClass.method_4("neuDaCo2FA", 0);
		}
		else if (E18B5D1D.Checked)
		{
			gClass.method_4("neuDaCo2FA", 1);
		}
		else
		{
			gClass.method_4("neuDaCo2FA", 2);
		}
		string string_ = gClass.method_7();
		if (EF184B16 == 0)
		{
			if (GClass29.smethod_1(F7AB102E.smethod_0("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, string_))
				{
					bool_0 = true;
					Close();
				}
				else
				{
					GClass29.smethod_0(F7AB102E.smethod_0("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
				}
			}
		}
		else if (GClass29.smethod_1(F7AB102E.smethod_0("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?")) == DialogResult.Yes)
		{
			if (Class147.smethod_13(B537E8AB, text, string_))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				GClass29.smethod_0(F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void EEB6270B(object sender, EventArgs e)
	{
		Close();
	}

	private void FCB97035(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void rbBat2FA_CheckedChanged(object sender, EventArgs e)
	{
		plBat2FA.Enabled = rbBat2FA.Checked;
	}

	private void EE18678F_Click(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && A4299E3B != null)
		{
			A4299E3B.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		A4299E3B = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EF90CFAC));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(A4299E3B);
		EE1C5B32 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(A4299E3B);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		EE18678F = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		C1A75E21 = new System.Windows.Forms.ComboBox();
		E4BD8C12 = new System.Windows.Forms.Label();
		plBat2FA = new System.Windows.Forms.Panel();
		rbXoa2FACu = new System.Windows.Forms.RadioButton();
		E18B5D1D = new System.Windows.Forms.RadioButton();
		FCA965A4 = new System.Windows.Forms.RadioButton();
		C601C91E = new System.Windows.Forms.Label();
		rbBat2FA = new System.Windows.Forms.RadioButton();
		rbTat2FA = new System.Windows.Forms.RadioButton();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		D698DA05 = new System.Windows.Forms.Label();
		EB938406 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		EFA72502 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)EE18678F).BeginInit();
		panel1.SuspendLayout();
		plBat2FA.SuspendLayout();
		EFA72502.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = EE1C5B32;
		bunifuDragControl_0.Vertical = true;
		EE1C5B32.BackColor = System.Drawing.Color.Transparent;
		EE1C5B32.Cursor = System.Windows.Forms.Cursors.SizeAll;
		EE1C5B32.Dock = System.Windows.Forms.DockStyle.Fill;
		EE1C5B32.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		EE1C5B32.ForeColor = System.Drawing.Color.Black;
		EE1C5B32.Location = new System.Drawing.Point(0, 0);
		EE1C5B32.Name = "bunifuCustomLabel1";
		EE1C5B32.Size = new System.Drawing.Size(358, 31);
		EE1C5B32.TabIndex = 12;
		EE1C5B32.Text = "Cấu hình Bật - Tắt 2FA";
		EE1C5B32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(EE18678F);
		pnlHeader.Controls.Add(EE1C5B32);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(358, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(327, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(E6A2FC8F);
		EE18678F.Cursor = System.Windows.Forms.Cursors.Default;
		EE18678F.Image = C50FB39E.Bitmap_5;
		EE18678F.Location = new System.Drawing.Point(3, 2);
		EE18678F.Name = "pictureBox1";
		EE18678F.Size = new System.Drawing.Size(34, 27);
		EE18678F.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		EE18678F.TabIndex = 76;
		EE18678F.TabStop = false;
		EE18678F.Click += new System.EventHandler(EE18678F_Click);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(C1A75E21);
		panel1.Controls.Add(E4BD8C12);
		panel1.Controls.Add(plBat2FA);
		panel1.Controls.Add(rbBat2FA);
		panel1.Controls.Add(rbTat2FA);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(D698DA05);
		panel1.Controls.Add(EB938406);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(EFA72502);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(361, 167);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(FCB97035);
		C1A75E21.Cursor = System.Windows.Forms.Cursors.Hand;
		C1A75E21.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		C1A75E21.FormattingEnabled = true;
		C1A75E21.Location = new System.Drawing.Point(131, 78);
		C1A75E21.Name = "cbbTuyChon";
		C1A75E21.Size = new System.Drawing.Size(194, 24);
		C1A75E21.TabIndex = 50;
		E4BD8C12.AutoSize = true;
		E4BD8C12.Location = new System.Drawing.Point(26, 81);
		E4BD8C12.Name = "label3";
		E4BD8C12.Size = new System.Drawing.Size(64, 16);
		E4BD8C12.TabIndex = 49;
		E4BD8C12.Text = "Tùy chọn:";
		plBat2FA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plBat2FA.Controls.Add(rbXoa2FACu);
		plBat2FA.Controls.Add(E18B5D1D);
		plBat2FA.Controls.Add(FCA965A4);
		plBat2FA.Controls.Add(C601C91E);
		plBat2FA.Location = new System.Drawing.Point(131, 297);
		plBat2FA.Name = "plBat2FA";
		plBat2FA.Size = new System.Drawing.Size(204, 97);
		plBat2FA.TabIndex = 48;
		rbXoa2FACu.AutoSize = true;
		rbXoa2FACu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbXoa2FACu.Location = new System.Drawing.Point(6, 72);
		rbXoa2FACu.Name = "rbXoa2FACu";
		rbXoa2FACu.Size = new System.Drawing.Size(193, 20);
		rbXoa2FACu.TabIndex = 34;
		rbXoa2FACu.TabStop = true;
		rbXoa2FACu.Text = "Xóa 2FA cũ rồi thêm 2FA mới";
		rbXoa2FACu.UseVisualStyleBackColor = true;
		E18B5D1D.AutoSize = true;
		E18B5D1D.Cursor = System.Windows.Forms.Cursors.Hand;
		E18B5D1D.Location = new System.Drawing.Point(6, 47);
		E18B5D1D.Name = "rbGiu2FACu";
		E18B5D1D.Size = new System.Drawing.Size(188, 20);
		E18B5D1D.TabIndex = 33;
		E18B5D1D.TabStop = true;
		E18B5D1D.Text = "Giữ 2FA cũ và thêm 2FA mới";
		E18B5D1D.UseVisualStyleBackColor = true;
		FCA965A4.AutoSize = true;
		FCA965A4.Cursor = System.Windows.Forms.Cursors.Hand;
		FCA965A4.Location = new System.Drawing.Point(6, 22);
		FCA965A4.Name = "rbKhongBat2FA";
		FCA965A4.Size = new System.Drawing.Size(134, 20);
		FCA965A4.TabIndex = 32;
		FCA965A4.TabStop = true;
		FCA965A4.Text = "Không bật 2FA nữa";
		FCA965A4.UseVisualStyleBackColor = true;
		C601C91E.AutoSize = true;
		C601C91E.Location = new System.Drawing.Point(3, 2);
		C601C91E.Name = "label2";
		C601C91E.Size = new System.Drawing.Size(169, 16);
		C601C91E.TabIndex = 31;
		C601C91E.Text = "Nếu tài khoản đã có 2FA thì:";
		rbBat2FA.AutoSize = true;
		rbBat2FA.Cursor = System.Windows.Forms.Cursors.Hand;
		rbBat2FA.Location = new System.Drawing.Point(30, 297);
		rbBat2FA.Name = "rbBat2FA";
		rbBat2FA.Size = new System.Drawing.Size(69, 20);
		rbBat2FA.TabIndex = 47;
		rbBat2FA.Text = "Bật 2FA";
		rbBat2FA.UseVisualStyleBackColor = true;
		rbBat2FA.CheckedChanged += new System.EventHandler(rbBat2FA_CheckedChanged);
		rbTat2FA.AutoSize = true;
		rbTat2FA.Checked = true;
		rbTat2FA.Cursor = System.Windows.Forms.Cursors.Hand;
		rbTat2FA.Location = new System.Drawing.Point(29, 273);
		rbTat2FA.Name = "rbTat2FA";
		rbTat2FA.Size = new System.Drawing.Size(70, 20);
		rbTat2FA.TabIndex = 47;
		rbTat2FA.TabStop = true;
		rbTat2FA.Text = "Tắt 2FA";
		rbTat2FA.UseVisualStyleBackColor = true;
		txtTenHanhDong.Location = new System.Drawing.Point(131, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		D698DA05.AutoSize = true;
		D698DA05.Location = new System.Drawing.Point(26, 52);
		D698DA05.Name = "label1";
		D698DA05.Size = new System.Drawing.Size(98, 16);
		D698DA05.TabIndex = 31;
		D698DA05.Text = "Tên ha\u0300nh đô\u0323ng:";
		EB938406.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		EB938406.BackColor = System.Drawing.Color.Maroon;
		EB938406.Cursor = System.Windows.Forms.Cursors.Hand;
		EB938406.FlatAppearance.BorderSize = 0;
		EB938406.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		EB938406.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		EB938406.ForeColor = System.Drawing.Color.White;
		EB938406.Location = new System.Drawing.Point(187, 122);
		EB938406.Name = "btnCancel";
		EB938406.Size = new System.Drawing.Size(92, 29);
		EB938406.TabIndex = 7;
		EB938406.Text = "Đóng";
		EB938406.UseVisualStyleBackColor = false;
		EB938406.Click += new System.EventHandler(EEB6270B);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(80, 122);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		EFA72502.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		EFA72502.BackColor = System.Drawing.Color.White;
		EFA72502.BorderRadius = 0;
		EFA72502.BottomSahddow = true;
		EFA72502.color = System.Drawing.Color.DarkViolet;
		EFA72502.Controls.Add(pnlHeader);
		EFA72502.LeftSahddow = false;
		EFA72502.Location = new System.Drawing.Point(1, 0);
		EFA72502.Name = "bunifuCards1";
		EFA72502.RightSahddow = true;
		EFA72502.ShadowDepth = 20;
		EFA72502.Size = new System.Drawing.Size(358, 37);
		EFA72502.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(361, 167);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDOnOff2FA";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(F12EB386);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)EE18678F).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plBat2FA.ResumeLayout(false);
		plBat2FA.PerformLayout();
		EFA72502.ResumeLayout(false);
		ResumeLayout(false);
	}
}
