using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDDoiMatKhau : Form
{
	private GClass11 E5B94A9A;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private IContainer F1A86530 = null;

	private BunifuDragControl A8A7EE1F;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label D8B14613;

	private Button F39DAA1D;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel C4129326;

	private Button BE3CB204;

	private PictureBox DBAB0D88;

	private BunifuCustomLabel ED38F6B8;

	private ToolTip toolTip_0;

	private Label label2;

	private TextBox txtNewPass;

	private Button button2;

	private ComboBox cbbTypeDoiMatKhau;

	private Label ECBDA3A4;

	public fHDDoiMatKhau(string DA92D6B1, int int_1 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = DA92D6B1;
		string_2 = string_3;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Đổi mật khẩu";
		if (Class147.smethod_7("", text).Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (int_1)
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
			DataTable dataTable = Class147.F3057616(string_3);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		E5B94A9A = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void E223D424(object sender, EventArgs e)
	{
		method_0();
		try
		{
			cbbTypeDoiMatKhau.SelectedValue = E5B94A9A.C0288288("cbbTypeDoiMatKhau", "2");
			txtNewPass.Text = E5B94A9A.C0288288("txtNewPass");
		}
		catch
		{
		}
	}

	private void method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("2", "Sư\u0309 du\u0323ng Account Center");
		dictionary.Add("1", "Sử dụng link hacked");
		dictionary.Add("3", "Tut không câ\u0300n xa\u0301c minh otp");
		GClass8.smethod_23(cbbTypeDoiMatKhau, dictionary);
	}

	private void F4AE1416(object sender, EventArgs e)
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
		gClass.method_4("txtNewPass", txtNewPass.Text.Trim());
		gClass.method_4("cbbTypeDoiMatKhau", cbbTypeDoiMatKhau.SelectedValue);
		string text2 = gClass.method_7();
		if (int_0 == 0)
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

	private void F39DAA1D_Click(object sender, EventArgs e)
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

	private void method_1(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		string eD = "Có thể sử dụng ký tự * để random 1 ký tự ngẫu nhiên!\r\nVí dụ: MIN****** => MINdfghta";
		GClass29.smethod_0(eD);
	}

	protected override void Dispose(bool E92DADA0)
	{
		if (E92DADA0 && F1A86530 != null)
		{
			F1A86530.Dispose();
		}
		base.Dispose(E92DADA0);
	}

	private void InitializeComponent()
	{
		F1A86530 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDDoiMatKhau));
		A8A7EE1F = new Bunifu.Framework.UI.BunifuDragControl(F1A86530);
		ED38F6B8 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(F1A86530);
		C4129326 = new System.Windows.Forms.Panel();
		BE3CB204 = new System.Windows.Forms.Button();
		DBAB0D88 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		cbbTypeDoiMatKhau = new System.Windows.Forms.ComboBox();
		button2 = new System.Windows.Forms.Button();
		ECBDA3A4 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		txtNewPass = new System.Windows.Forms.TextBox();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		D8B14613 = new System.Windows.Forms.Label();
		F39DAA1D = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		toolTip_0 = new System.Windows.Forms.ToolTip(F1A86530);
		C4129326.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)DBAB0D88).BeginInit();
		panel1.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		A8A7EE1F.Fixed = true;
		A8A7EE1F.Horizontal = true;
		A8A7EE1F.TargetControl = ED38F6B8;
		A8A7EE1F.Vertical = true;
		ED38F6B8.BackColor = System.Drawing.Color.Transparent;
		ED38F6B8.Cursor = System.Windows.Forms.Cursors.SizeAll;
		ED38F6B8.Dock = System.Windows.Forms.DockStyle.Fill;
		ED38F6B8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		ED38F6B8.ForeColor = System.Drawing.Color.Black;
		ED38F6B8.Location = new System.Drawing.Point(0, 0);
		ED38F6B8.Name = "bunifuCustomLabel1";
		ED38F6B8.Size = new System.Drawing.Size(345, 31);
		ED38F6B8.TabIndex = 12;
		ED38F6B8.Text = "Cấu hình Đổi mật khẩu";
		ED38F6B8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = C4129326;
		bunifuDragControl_0.Vertical = true;
		C4129326.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		C4129326.BackColor = System.Drawing.Color.White;
		C4129326.Controls.Add(BE3CB204);
		C4129326.Controls.Add(DBAB0D88);
		C4129326.Controls.Add(ED38F6B8);
		C4129326.Cursor = System.Windows.Forms.Cursors.SizeAll;
		C4129326.Location = new System.Drawing.Point(0, 3);
		C4129326.Name = "pnlHeader";
		C4129326.Size = new System.Drawing.Size(345, 31);
		C4129326.TabIndex = 9;
		BE3CB204.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		BE3CB204.Cursor = System.Windows.Forms.Cursors.Hand;
		BE3CB204.FlatAppearance.BorderSize = 0;
		BE3CB204.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BE3CB204.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		BE3CB204.ForeColor = System.Drawing.Color.White;
		BE3CB204.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		BE3CB204.Location = new System.Drawing.Point(314, 1);
		BE3CB204.Name = "button1";
		BE3CB204.Size = new System.Drawing.Size(30, 30);
		BE3CB204.TabIndex = 77;
		BE3CB204.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		BE3CB204.UseVisualStyleBackColor = true;
		BE3CB204.Click += new System.EventHandler(F4AE1416);
		DBAB0D88.Cursor = System.Windows.Forms.Cursors.Default;
		DBAB0D88.Image = C50FB39E.Bitmap_5;
		DBAB0D88.Location = new System.Drawing.Point(3, 2);
		DBAB0D88.Name = "pictureBox1";
		DBAB0D88.Size = new System.Drawing.Size(34, 27);
		DBAB0D88.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		DBAB0D88.TabIndex = 76;
		DBAB0D88.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(cbbTypeDoiMatKhau);
		panel1.Controls.Add(button2);
		panel1.Controls.Add(ECBDA3A4);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(txtNewPass);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(D8B14613);
		panel1.Controls.Add(F39DAA1D);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(348, 191);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		cbbTypeDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTypeDoiMatKhau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTypeDoiMatKhau.FormattingEnabled = true;
		cbbTypeDoiMatKhau.Location = new System.Drawing.Point(125, 78);
		cbbTypeDoiMatKhau.Name = "cbbTypeDoiMatKhau";
		cbbTypeDoiMatKhau.Size = new System.Drawing.Size(194, 24);
		cbbTypeDoiMatKhau.TabIndex = 153;
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(295, 107);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(24, 24);
		button2.TabIndex = 152;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		ECBDA3A4.AutoSize = true;
		ECBDA3A4.Location = new System.Drawing.Point(20, 81);
		ECBDA3A4.Name = "label3";
		ECBDA3A4.Size = new System.Drawing.Size(64, 16);
		ECBDA3A4.TabIndex = 31;
		ECBDA3A4.Text = "Tùy chọn:";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(20, 111);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(89, 16);
		label2.TabIndex = 31;
		label2.Text = "Mật khẩu mới:";
		txtNewPass.Location = new System.Drawing.Point(125, 108);
		txtNewPass.Name = "txtNewPass";
		txtNewPass.Size = new System.Drawing.Size(167, 23);
		txtNewPass.TabIndex = 0;
		txtTenHanhDong.Location = new System.Drawing.Point(125, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		D8B14613.AutoSize = true;
		D8B14613.Location = new System.Drawing.Point(20, 52);
		D8B14613.Name = "label1";
		D8B14613.Size = new System.Drawing.Size(98, 16);
		D8B14613.TabIndex = 31;
		D8B14613.Text = "Tên ha\u0300nh đô\u0323ng:";
		F39DAA1D.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		F39DAA1D.BackColor = System.Drawing.Color.Maroon;
		F39DAA1D.Cursor = System.Windows.Forms.Cursors.Hand;
		F39DAA1D.FlatAppearance.BorderSize = 0;
		F39DAA1D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		F39DAA1D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F39DAA1D.ForeColor = System.Drawing.Color.White;
		F39DAA1D.Location = new System.Drawing.Point(184, 148);
		F39DAA1D.Name = "btnCancel";
		F39DAA1D.Size = new System.Drawing.Size(92, 29);
		F39DAA1D.TabIndex = 7;
		F39DAA1D.Text = "Đóng";
		F39DAA1D.UseVisualStyleBackColor = false;
		F39DAA1D.Click += new System.EventHandler(F39DAA1D_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(77, 148);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(C4129326);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(345, 37);
		bunifuCards1.TabIndex = 28;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 0;
		toolTip_0.InitialDelay = 0;
		toolTip_0.ReshowDelay = 0;
		toolTip_0.ShowAlways = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(348, 191);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDoiMatKhau";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(E223D424);
		C4129326.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)DBAB0D88).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
