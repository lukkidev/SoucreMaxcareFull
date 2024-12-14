using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDSharePage : Form
{
	private GClass11 gclass11_0;

	private string BE95F90C;

	private string D5031B2D;

	private string string_0;

	private int int_0;

	public static bool B72DD8B9;

	private IContainer EEAEAD22 = null;

	private BunifuDragControl D096370F;

	private BunifuDragControl bunifuDragControl_0;

	private Panel AB826239;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label C638F222;

	private Label label4;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button A2236A0B;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label6;

	private Label label5;

	private TextBox txtToCookie;

	private Label D2351BB7;

	private CheckBox A8147DBD;

	public fHDSharePage(string string_1, int A68E9498 = 0, string string_2 = "")
	{
		InitializeComponent();
		B72DD8B9 = false;
		BE95F90C = string_1;
		string_0 = string_2;
		int_0 = A68E9498;
		if (Class147.smethod_7("", "HDSharePage").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDSharePage', 'Share page');");
		}
		string string_3 = "";
		switch (A68E9498)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDSharePage");
			string_3 = dataTable2.Rows[0]["CauHinh"].ToString();
			D5031B2D = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = dataTable2.Rows[0]["MoTa"].ToString();
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_2);
			string_3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = "Câ\u0323p nhâ\u0323t";
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(string_3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void A1B666A8(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = gclass11_0.method_2("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass11_0.method_2("nudSoLuongTo", 1);
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
			txtToCookie.Text = gclass11_0.C0288288("txtToCookie");
			A8147DBD.Checked = gclass11_0.method_3("ckbLeavePage");
		}
		catch
		{
		}
	}

	private void A2236A0B_Click(object sender, EventArgs e)
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
		gClass.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		gClass.method_4("txtToCookie", txtToCookie.Text);
		gClass.method_4("ckbLeavePage", A8147DBD.Checked);
		string text2 = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(BE95F90C, text, D5031B2D, text2))
				{
					B72DD8B9 = true;
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
			if (Class147.smethod_13(string_0, text, text2))
			{
				B72DD8B9 = true;
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

	private void AB826239_Paint(object sender, PaintEventArgs e)
	{
		if (AB826239.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, AB826239.ClientSize.Width - num, AB826239.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && EEAEAD22 != null)
		{
			EEAEAD22.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		EEAEAD22 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDSharePage));
		D096370F = new Bunifu.Framework.UI.BunifuDragControl(EEAEAD22);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(EEAEAD22);
		pnlHeader = new System.Windows.Forms.Panel();
		A2236A0B = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		AB826239 = new System.Windows.Forms.Panel();
		A8147DBD = new System.Windows.Forms.CheckBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		txtToCookie = new System.Windows.Forms.TextBox();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		C638F222 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		D2351BB7 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		AB826239.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		D096370F.Fixed = true;
		D096370F.Horizontal = true;
		D096370F.TargetControl = bunifuCustomLabel1;
		D096370F.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(352, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Share page";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(A2236A0B);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(352, 31);
		pnlHeader.TabIndex = 9;
		A2236A0B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		A2236A0B.Cursor = System.Windows.Forms.Cursors.Hand;
		A2236A0B.FlatAppearance.BorderSize = 0;
		A2236A0B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A2236A0B.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A2236A0B.ForeColor = System.Drawing.Color.White;
		A2236A0B.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		A2236A0B.Location = new System.Drawing.Point(321, 1);
		A2236A0B.Name = "button1";
		A2236A0B.Size = new System.Drawing.Size(30, 30);
		A2236A0B.TabIndex = 77;
		A2236A0B.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		A2236A0B.UseVisualStyleBackColor = true;
		A2236A0B.Click += new System.EventHandler(A2236A0B_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		AB826239.BackColor = System.Drawing.Color.White;
		AB826239.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		AB826239.Controls.Add(A8147DBD);
		AB826239.Controls.Add(nudDelayTo);
		AB826239.Controls.Add(nudDelayFrom);
		AB826239.Controls.Add(label7);
		AB826239.Controls.Add(label6);
		AB826239.Controls.Add(label5);
		AB826239.Controls.Add(nudSoLuongTo);
		AB826239.Controls.Add(nudSoLuongFrom);
		AB826239.Controls.Add(txtToCookie);
		AB826239.Controls.Add(txtTenHanhDong);
		AB826239.Controls.Add(C638F222);
		AB826239.Controls.Add(label4);
		AB826239.Controls.Add(D2351BB7);
		AB826239.Controls.Add(label2);
		AB826239.Controls.Add(label1);
		AB826239.Controls.Add(btnCancel);
		AB826239.Controls.Add(btnAdd);
		AB826239.Controls.Add(bunifuCards1);
		AB826239.Cursor = System.Windows.Forms.Cursors.Arrow;
		AB826239.Dock = System.Windows.Forms.DockStyle.Fill;
		AB826239.Location = new System.Drawing.Point(0, 0);
		AB826239.Name = "panel1";
		AB826239.Size = new System.Drawing.Size(355, 240);
		AB826239.TabIndex = 0;
		AB826239.Paint += new System.Windows.Forms.PaintEventHandler(AB826239_Paint);
		A8147DBD.AutoSize = true;
		A8147DBD.Cursor = System.Windows.Forms.Cursors.Hand;
		A8147DBD.Location = new System.Drawing.Point(30, 164);
		A8147DBD.Name = "ckbLeavePage";
		A8147DBD.Size = new System.Drawing.Size(223, 20);
		A8147DBD.TabIndex = 47;
		A8147DBD.Text = "Rời page sau khi share thành công";
		A8147DBD.UseVisualStyleBackColor = true;
		nudDelayTo.Location = new System.Drawing.Point(229, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(132, 107);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		label7.AutoSize = true;
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label7.Location = new System.Drawing.Point(199, 109);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(18, 16);
		label7.TabIndex = 46;
		label7.Text = ">";
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(290, 109);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(13, 16);
		label6.TabIndex = 45;
		label6.Text = "s";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 109);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(92, 16);
		label5.TabIndex = 44;
		label5.Text = "Delay time (s):";
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
		txtToCookie.Location = new System.Drawing.Point(132, 135);
		txtToCookie.Name = "txtToCookie";
		txtToCookie.Size = new System.Drawing.Size(194, 23);
		txtToCookie.TabIndex = 0;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		C638F222.AutoSize = true;
		C638F222.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C638F222.Location = new System.Drawing.Point(199, 80);
		C638F222.Name = "label3";
		C638F222.Size = new System.Drawing.Size(18, 16);
		C638F222.TabIndex = 37;
		C638F222.Text = ">";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(290, 80);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(35, 16);
		label4.TabIndex = 35;
		label4.Text = "page";
		D2351BB7.AutoSize = true;
		D2351BB7.Location = new System.Drawing.Point(27, 137);
		D2351BB7.Name = "label10";
		D2351BB7.Size = new System.Drawing.Size(82, 16);
		D2351BB7.TabIndex = 31;
		D2351BB7.Text = "Cookie nhận:";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 80);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(95, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng page:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(184, 196);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(77, 196);
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
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(352, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(355, 240);
		base.Controls.Add(AB826239);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDSharePage";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(A1B666A8);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		AB826239.ResumeLayout(false);
		AB826239.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
