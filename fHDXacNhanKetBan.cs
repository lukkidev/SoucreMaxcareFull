using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDXacNhanKetBan : Form
{
	private GClass11 gclass11_0;

	private string D0B75229;

	private string E507A0AF;

	private string string_0;

	private int BEB59527;

	public static bool ACA1A2AC;

	private IContainer D683E38D = null;

	private BunifuDragControl B4B76CA1;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private NumericUpDown AC92231F;

	private NumericUpDown nudSoLuongFrom;

	private TextBox B72ED49D;

	private Label DD231024;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown B39C8737;

	private NumericUpDown AC0CD01D;

	private Label FA0E3BB7;

	private Label label5;

	private CheckBox ckbChiKetBanTenCoDau;

	private CheckBox D9162C27;

	private NumericUpDown E3353189;

	private Label label9;

	private Label CBBCB58E;

	private CheckBox ckbAddFriendApi;

	private ComboBox cbbFacebookWeb;

	private Label B72A3D9F;

	public fHDXacNhanKetBan(string C1160803, int int_0 = 0, string F8341A89 = "")
	{
		InitializeComponent();
		ACA1A2AC = false;
		D0B75229 = C1160803;
		string_0 = F8341A89;
		BEB59527 = int_0;
		string string_ = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDXacNhanKetBan");
			string_ = dataTable2.Rows[0]["CauHinh"].ToString();
			E507A0AF = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			B72ED49D.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(F8341A89);
			string_ = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			B72ED49D.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(string_, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void fHDXacNhanKetBan_Load(object sender, EventArgs e)
	{
		method_0();
		try
		{
			nudSoLuongFrom.Value = gclass11_0.method_2("nudSoLuongFrom", 3);
			AC92231F.Value = gclass11_0.method_2("nudSoLuongTo", 3);
			AC0CD01D.Value = gclass11_0.method_2("nudDelayFrom", 3);
			B39C8737.Value = gclass11_0.method_2("nudDelayTo", 5);
			ckbChiKetBanTenCoDau.Checked = gclass11_0.method_3("ckbChiKetBanTenCoDau");
			D9162C27.Checked = gclass11_0.method_3("ckbOnlyAddFriendWithMutualFriends");
			E3353189.Value = gclass11_0.method_2("nudTimesWarning", 5);
			ckbAddFriendApi.Checked = gclass11_0.method_3("ckbAddFriendApi");
			cbbFacebookWeb.SelectedValue = gclass11_0.C0288288("cbbFacebookWeb", "1");
		}
		catch
		{
		}
	}

	private void method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("3", "https://mbasic.facebook.com/");
		dictionary.Add("1", "https://www.facebook.com/");
		dictionary.Add("2", "https://m.facebook.com/");
		GClass8.smethod_23(cbbFacebookWeb, dictionary);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = B72ED49D.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_4("nudSoLuongTo", AC92231F.Value);
		gClass.method_4("nudDelayFrom", AC0CD01D.Value);
		gClass.method_4("nudDelayTo", B39C8737.Value);
		gClass.method_4("ckbChiKetBanTenCoDau", ckbChiKetBanTenCoDau.Checked);
		gClass.method_4("ckbOnlyAddFriendWithMutualFriends", D9162C27.Checked);
		gClass.method_4("nudTimesWarning", E3353189.Value);
		gClass.method_4("ckbAddFriendApi", ckbAddFriendApi.Checked);
		gClass.method_4("cbbFacebookWeb", cbbFacebookWeb.SelectedValue);
		string text2 = gClass.method_7();
		if (BEB59527 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(D0B75229, text, E507A0AF, text2))
				{
					ACA1A2AC = true;
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
				ACA1A2AC = true;
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

	private void D53F8530(object sender, PaintEventArgs e)
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
		if (B803E003 && D683E38D != null)
		{
			D683E38D.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		D683E38D = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDXacNhanKetBan));
		B4B76CA1 = new Bunifu.Framework.UI.BunifuDragControl(D683E38D);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(D683E38D);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		cbbFacebookWeb = new System.Windows.Forms.ComboBox();
		btnAdd = new System.Windows.Forms.Button();
		E3353189 = new System.Windows.Forms.NumericUpDown();
		label9 = new System.Windows.Forms.Label();
		B72A3D9F = new System.Windows.Forms.Label();
		CBBCB58E = new System.Windows.Forms.Label();
		D9162C27 = new System.Windows.Forms.CheckBox();
		ckbChiKetBanTenCoDau = new System.Windows.Forms.CheckBox();
		B39C8737 = new System.Windows.Forms.NumericUpDown();
		AC0CD01D = new System.Windows.Forms.NumericUpDown();
		FA0E3BB7 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		AC92231F = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		B72ED49D = new System.Windows.Forms.TextBox();
		DD231024 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		ckbAddFriendApi = new System.Windows.Forms.CheckBox();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)E3353189).BeginInit();
		((System.ComponentModel.ISupportInitialize)B39C8737).BeginInit();
		((System.ComponentModel.ISupportInitialize)AC0CD01D).BeginInit();
		((System.ComponentModel.ISupportInitialize)AC92231F).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		B4B76CA1.Fixed = true;
		B4B76CA1.Horizontal = true;
		B4B76CA1.TargetControl = bunifuCustomLabel1;
		B4B76CA1.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Xác nhận kết bạn";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
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
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
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
		panel1.Controls.Add(cbbFacebookWeb);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(E3353189);
		panel1.Controls.Add(label9);
		panel1.Controls.Add(B72A3D9F);
		panel1.Controls.Add(CBBCB58E);
		panel1.Controls.Add(D9162C27);
		panel1.Controls.Add(ckbChiKetBanTenCoDau);
		panel1.Controls.Add(B39C8737);
		panel1.Controls.Add(AC0CD01D);
		panel1.Controls.Add(FA0E3BB7);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(AC92231F);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(B72ED49D);
		panel1.Controls.Add(DD231024);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(bunifuCards1);
		panel1.Controls.Add(ckbAddFriendApi);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 297);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(D53F8530);
		cbbFacebookWeb.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbFacebookWeb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbFacebookWeb.DropDownWidth = 120;
		cbbFacebookWeb.FormattingEnabled = true;
		cbbFacebookWeb.Location = new System.Drawing.Point(132, 212);
		cbbFacebookWeb.Name = "cbbFacebookWeb";
		cbbFacebookWeb.Size = new System.Drawing.Size(194, 24);
		cbbFacebookWeb.TabIndex = 115;
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(82, 253);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		E3353189.Location = new System.Drawing.Point(253, 183);
		E3353189.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E3353189.Name = "nudTimesWarning";
		E3353189.Size = new System.Drawing.Size(43, 23);
		E3353189.TabIndex = 50;
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(299, 185);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(24, 16);
		label9.TabIndex = 52;
		label9.Text = "lần";
		B72A3D9F.AutoSize = true;
		B72A3D9F.Location = new System.Drawing.Point(27, 215);
		B72A3D9F.Name = "label4";
		B72A3D9F.Size = new System.Drawing.Size(96, 16);
		B72A3D9F.TabIndex = 51;
		B72A3D9F.Text = "Facebook Web:";
		CBBCB58E.AutoSize = true;
		CBBCB58E.Location = new System.Drawing.Point(27, 185);
		CBBCB58E.Name = "label8";
		CBBCB58E.Size = new System.Drawing.Size(225, 16);
		CBBCB58E.TabIndex = 51;
		CBBCB58E.Text = "Dừng khi gặp cảnh báo của Facebook:";
		D9162C27.AutoSize = true;
		D9162C27.Cursor = System.Windows.Forms.Cursors.Hand;
		D9162C27.Location = new System.Drawing.Point(30, 160);
		D9162C27.Name = "ckbOnlyAddFriendWithMutualFriends";
		D9162C27.Size = new System.Drawing.Size(226, 20);
		D9162C27.TabIndex = 49;
		D9162C27.Text = "Chỉ kết bạn với người có bạn chung";
		D9162C27.UseVisualStyleBackColor = true;
		ckbChiKetBanTenCoDau.AutoSize = true;
		ckbChiKetBanTenCoDau.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbChiKetBanTenCoDau.Location = new System.Drawing.Point(30, 136);
		ckbChiKetBanTenCoDau.Name = "ckbChiKetBanTenCoDau";
		ckbChiKetBanTenCoDau.Size = new System.Drawing.Size(211, 20);
		ckbChiKetBanTenCoDau.TabIndex = 48;
		ckbChiKetBanTenCoDau.Text = "Chỉ kết bạn với người có tên Việt";
		ckbChiKetBanTenCoDau.UseVisualStyleBackColor = true;
		B39C8737.Location = new System.Drawing.Point(229, 107);
		B39C8737.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		B39C8737.Name = "nudDelayTo";
		B39C8737.Size = new System.Drawing.Size(56, 23);
		B39C8737.TabIndex = 4;
		AC0CD01D.Location = new System.Drawing.Point(132, 107);
		AC0CD01D.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		AC0CD01D.Name = "nudDelayFrom";
		AC0CD01D.Size = new System.Drawing.Size(56, 23);
		AC0CD01D.TabIndex = 3;
		FA0E3BB7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		FA0E3BB7.Location = new System.Drawing.Point(194, 109);
		FA0E3BB7.Name = "label7";
		FA0E3BB7.Size = new System.Drawing.Size(29, 16);
		FA0E3BB7.TabIndex = 46;
		FA0E3BB7.Text = ">";
		FA0E3BB7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 109);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(87, 16);
		label5.TabIndex = 44;
		label5.Text = "Gia\u0303n ca\u0301ch (s):";
		AC92231F.Location = new System.Drawing.Point(229, 78);
		AC92231F.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		AC92231F.Name = "nudSoLuongTo";
		AC92231F.Size = new System.Drawing.Size(56, 23);
		AC92231F.TabIndex = 2;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 78);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		B72ED49D.Location = new System.Drawing.Point(132, 49);
		B72ED49D.Name = "txtTenHanhDong";
		B72ED49D.Size = new System.Drawing.Size(194, 23);
		B72ED49D.TabIndex = 0;
		DD231024.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DD231024.Location = new System.Drawing.Point(194, 80);
		DD231024.Name = "label3";
		DD231024.Size = new System.Drawing.Size(29, 16);
		DD231024.TabIndex = 37;
		DD231024.Text = ">";
		DD231024.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 80);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(88, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
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
		btnCancel.Location = new System.Drawing.Point(189, 253);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
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
		ckbAddFriendApi.AutoSize = true;
		ckbAddFriendApi.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAddFriendApi.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		ckbAddFriendApi.Location = new System.Drawing.Point(30, 337);
		ckbAddFriendApi.Name = "ckbAddFriendApi";
		ckbAddFriendApi.Size = new System.Drawing.Size(99, 20);
		ckbAddFriendApi.TabIndex = 114;
		ckbAddFriendApi.Text = "Run API (ẩn)";
		ckbAddFriendApi.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 297);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDXacNhanKetBan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDXacNhanKetBan_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)E3353189).EndInit();
		((System.ComponentModel.ISupportInitialize)B39C8737).EndInit();
		((System.ComponentModel.ISupportInitialize)AC0CD01D).EndInit();
		((System.ComponentModel.ISupportInitialize)AC92231F).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
