using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDKetBanVoiBanBeCuaUid : Form
{
	private GClass11 gclass11_0;

	private string FA3D419E;

	private string string_0;

	private string string_1;

	private int FB0F7C84;

	public static bool A2A0E122;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl C4AC5025;

	private Panel panel1;

	private NumericUpDown E7251D3E;

	private NumericUpDown FA0515B8;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label label4;

	private Label label2;

	private Label label1;

	private Button E23DB088;

	private Button E20933AE;

	private BunifuCards BB84E81C;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel BC0D83BB;

	private Label FD130E0D;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label6;

	private Label CBB1400F;

	private RichTextBox txtUid;

	private ToolTip A2B9A83E;

	private CheckBox ckbTuDongXoaUid;

	public fHDKetBanVoiBanBeCuaUid(string DABF8828, int int_0 = 0, string C53A8B34 = "")
	{
		InitializeComponent();
		A2A0E122 = false;
		FA3D419E = DABF8828;
		string_1 = C53A8B34;
		FB0F7C84 = int_0;
		if (Class147.smethod_7("", "HDKetBanVoiBanBeCuaUid").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDKetBanVoiBanBeCuaUid', 'Kết bạn với bạn bè của Uid');");
		}
		string text = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDKetBanVoiBanBeCuaUid");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(C53A8B34);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			E20933AE.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void fHDKetBanVoiBanBeCuaUid_Load(object sender, EventArgs e)
	{
		try
		{
			FA0515B8.Value = gclass11_0.method_2("nudSoLuongFrom", 3);
			E7251D3E.Value = gclass11_0.method_2("nudSoLuongTo", 5);
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
			txtUid.Text = gclass11_0.C0288288("txtUid");
			ckbTuDongXoaUid.Checked = gclass11_0.method_3("ckbTuDongXoaUid");
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E20933AE_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> e03C713E = txtUid.Lines.ToList();
		e03C713E = GClass8.smethod_36(e03C713E);
		if (e03C713E.Count == 0)
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sách uid!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", FA0515B8.Value);
		gClass.method_4("nudSoLuongTo", E7251D3E.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		gClass.method_4("txtUid", txtUid.Text.Trim());
		gClass.method_4("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
		string string_ = gClass.method_7();
		if (FB0F7C84 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(FA3D419E, text, string_0, string_))
				{
					A2A0E122 = true;
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
				A2A0E122 = true;
				Close();
			}
			else
			{
				GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void A8B45A92(object sender, EventArgs e)
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

	private void BF283C20(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtUid, FD130E0D);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDKetBanVoiBanBeCuaUid));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		BC0D83BB = new Bunifu.Framework.UI.BunifuCustomLabel();
		C4AC5025 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		ckbTuDongXoaUid = new System.Windows.Forms.CheckBox();
		txtUid = new System.Windows.Forms.RichTextBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		FD130E0D = new System.Windows.Forms.Label();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		CBB1400F = new System.Windows.Forms.Label();
		E7251D3E = new System.Windows.Forms.NumericUpDown();
		FA0515B8 = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		E23DB088 = new System.Windows.Forms.Button();
		E20933AE = new System.Windows.Forms.Button();
		BB84E81C = new Bunifu.Framework.UI.BunifuCards();
		A2B9A83E = new System.Windows.Forms.ToolTip(icontainer_0);
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)E7251D3E).BeginInit();
		((System.ComponentModel.ISupportInitialize)FA0515B8).BeginInit();
		BB84E81C.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = BC0D83BB;
		bunifuDragControl_0.Vertical = true;
		BC0D83BB.BackColor = System.Drawing.Color.Transparent;
		BC0D83BB.Cursor = System.Windows.Forms.Cursors.SizeAll;
		BC0D83BB.Dock = System.Windows.Forms.DockStyle.Fill;
		BC0D83BB.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		BC0D83BB.ForeColor = System.Drawing.Color.Black;
		BC0D83BB.Location = new System.Drawing.Point(0, 0);
		BC0D83BB.Name = "bunifuCustomLabel1";
		BC0D83BB.Size = new System.Drawing.Size(359, 31);
		BC0D83BB.TabIndex = 12;
		BC0D83BB.Text = "Cấu hình Kết bạn với bạn bè của Uid";
		BC0D83BB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C4AC5025.Fixed = true;
		C4AC5025.Horizontal = true;
		C4AC5025.TargetControl = pnlHeader;
		C4AC5025.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(BC0D83BB);
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
		panel1.Controls.Add(ckbTuDongXoaUid);
		panel1.Controls.Add(txtUid);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(FD130E0D);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(CBB1400F);
		panel1.Controls.Add(E7251D3E);
		panel1.Controls.Add(FA0515B8);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(E23DB088);
		panel1.Controls.Add(E20933AE);
		panel1.Controls.Add(BB84E81C);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 383);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		ckbTuDongXoaUid.AutoSize = true;
		ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuDongXoaUid.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		ckbTuDongXoaUid.Location = new System.Drawing.Point(30, 300);
		ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		ckbTuDongXoaUid.Size = new System.Drawing.Size(170, 20);
		ckbTuDongXoaUid.TabIndex = 115;
		ckbTuDongXoaUid.Text = "Tư\u0323 đô\u0323ng xo\u0301a Uid đa\u0303 dùng";
		ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtUid.Location = new System.Drawing.Point(31, 159);
		txtUid.Name = "txtUid";
		txtUid.Size = new System.Drawing.Size(295, 136);
		txtUid.TabIndex = 114;
		txtUid.Text = "";
		txtUid.WordWrap = false;
		txtUid.TextChanged += new System.EventHandler(BF283C20);
		nudDelayTo.Location = new System.Drawing.Point(229, 111);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		FD130E0D.AutoSize = true;
		FD130E0D.Location = new System.Drawing.Point(27, 139);
		FD130E0D.Name = "lblStatus";
		FD130E0D.Size = new System.Drawing.Size(114, 16);
		FD130E0D.TabIndex = 0;
		FD130E0D.Text = "Danh sa\u0301ch Uid (0):";
		nudDelayFrom.Location = new System.Drawing.Point(132, 111);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		label7.AutoSize = true;
		label7.Location = new System.Drawing.Point(194, 113);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(28, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(290, 113);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		CBB1400F.AutoSize = true;
		CBB1400F.Location = new System.Drawing.Point(27, 113);
		CBB1400F.Name = "label5";
		CBB1400F.Size = new System.Drawing.Size(89, 16);
		CBB1400F.TabIndex = 44;
		CBB1400F.Text = "Thơ\u0300i gian chơ\u0300:";
		E7251D3E.Location = new System.Drawing.Point(229, 80);
		E7251D3E.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E7251D3E.Name = "nudSoLuongTo";
		E7251D3E.Size = new System.Drawing.Size(56, 23);
		E7251D3E.TabIndex = 2;
		FA0515B8.Location = new System.Drawing.Point(132, 80);
		FA0515B8.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		FA0515B8.Name = "nudSoLuongFrom";
		FA0515B8.Size = new System.Drawing.Size(56, 23);
		FA0515B8.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(194, 82);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(28, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(290, 82);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(28, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0323n";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 82);
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
		E23DB088.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		E23DB088.BackColor = System.Drawing.Color.Maroon;
		E23DB088.Cursor = System.Windows.Forms.Cursors.Hand;
		E23DB088.FlatAppearance.BorderSize = 0;
		E23DB088.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E23DB088.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E23DB088.ForeColor = System.Drawing.Color.White;
		E23DB088.Location = new System.Drawing.Point(190, 337);
		E23DB088.Name = "btnCancel";
		E23DB088.Size = new System.Drawing.Size(92, 29);
		E23DB088.TabIndex = 7;
		E23DB088.Text = "Đóng";
		E23DB088.UseVisualStyleBackColor = false;
		E23DB088.Click += new System.EventHandler(A8B45A92);
		E20933AE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		E20933AE.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		E20933AE.Cursor = System.Windows.Forms.Cursors.Hand;
		E20933AE.FlatAppearance.BorderSize = 0;
		E20933AE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E20933AE.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E20933AE.ForeColor = System.Drawing.Color.White;
		E20933AE.Location = new System.Drawing.Point(83, 337);
		E20933AE.Name = "btnAdd";
		E20933AE.Size = new System.Drawing.Size(92, 29);
		E20933AE.TabIndex = 6;
		E20933AE.Text = "Thêm";
		E20933AE.UseVisualStyleBackColor = false;
		E20933AE.Click += new System.EventHandler(E20933AE_Click);
		BB84E81C.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		BB84E81C.BackColor = System.Drawing.Color.White;
		BB84E81C.BorderRadius = 0;
		BB84E81C.BottomSahddow = true;
		BB84E81C.color = System.Drawing.Color.DarkViolet;
		BB84E81C.Controls.Add(pnlHeader);
		BB84E81C.LeftSahddow = false;
		BB84E81C.Location = new System.Drawing.Point(1, 0);
		BB84E81C.Name = "bunifuCards1";
		BB84E81C.RightSahddow = true;
		BB84E81C.ShadowDepth = 20;
		BB84E81C.Size = new System.Drawing.Size(359, 37);
		BB84E81C.TabIndex = 28;
		A2B9A83E.AutomaticDelay = 0;
		A2B9A83E.AutoPopDelay = 0;
		A2B9A83E.InitialDelay = 0;
		A2B9A83E.ReshowDelay = 0;
		A2B9A83E.ShowAlways = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 383);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanVoiBanBeCuaUid";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDKetBanVoiBanBeCuaUid_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)E7251D3E).EndInit();
		((System.ComponentModel.ISupportInitialize)FA0515B8).EndInit();
		BB84E81C.ResumeLayout(false);
		ResumeLayout(false);
	}
}
