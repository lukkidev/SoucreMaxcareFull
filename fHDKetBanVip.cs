using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDKetBanVip : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string string_1;

	private string FB1F5F16;

	private int A49EAB23;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl B52C7A39;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox A8861BB4;

	private Label F6A14694;

	private Label label4;

	private Label label2;

	private Label label1;

	private Button F0B7740E;

	private Button btnAdd;

	private BunifuCards EDBD643B;

	private Panel pnlHeader;

	private Button BB9A948D;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label6;

	private Label label5;

	private RichTextBox A6B2B891;

	private Label label8;

	private TextBox CF1AFCB7;

	private Label label9;

	public fHDKetBanVip(string string_2, int int_0 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_2;
		FB1F5F16 = string_3;
		A49EAB23 = int_0;
		string text = base.Name.Substring(1);
		string text2 = "Kết bạn vip";
		if (Class147.smethod_7("", text).Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			A8861BB4.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_3);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			A8861BB4.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void fHDKetBanVip_Load(object sender, EventArgs e)
	{
		try
		{
			CF1AFCB7.Text = gclass11_0.C0288288("txtLink");
			nudSoLuongFrom.Value = gclass11_0.method_2("nudSoLuongFrom");
			nudSoLuongTo.Value = gclass11_0.method_2("nudSoLuongTo");
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom");
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo");
			A6B2B891.Text = gclass11_0.C0288288("txtCode");
		}
		catch
		{
		}
	}

	private void BB9A948D_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E602C02C(object sender, EventArgs e)
	{
		string text = A8861BB4.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("txtLink", CF1AFCB7.Text);
		gClass.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		gClass.method_4("txtCode", A6B2B891.Text);
		string string_ = gClass.method_7();
		if (A49EAB23 == 0)
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
			if (Class147.smethod_13(FB1F5F16, text, string_))
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

	private void F0B7740E_Click(object sender, EventArgs e)
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDKetBanVip));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		B52C7A39 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		BB9A948D = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		A6B2B891 = new System.Windows.Forms.RichTextBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label8 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		CF1AFCB7 = new System.Windows.Forms.TextBox();
		A8861BB4 = new System.Windows.Forms.TextBox();
		F6A14694 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label9 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		F0B7740E = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		EDBD643B = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		EDBD643B.SuspendLayout();
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
		bunifuCustomLabel1.Text = "Cấu hình Kết bạn vip";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B52C7A39.Fixed = true;
		B52C7A39.Horizontal = true;
		B52C7A39.TargetControl = pnlHeader;
		B52C7A39.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(BB9A948D);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(359, 31);
		pnlHeader.TabIndex = 9;
		BB9A948D.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		BB9A948D.Cursor = System.Windows.Forms.Cursors.Hand;
		BB9A948D.FlatAppearance.BorderSize = 0;
		BB9A948D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BB9A948D.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		BB9A948D.ForeColor = System.Drawing.Color.White;
		BB9A948D.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		BB9A948D.Location = new System.Drawing.Point(328, 1);
		BB9A948D.Name = "button1";
		BB9A948D.Size = new System.Drawing.Size(30, 30);
		BB9A948D.TabIndex = 77;
		BB9A948D.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		BB9A948D.UseVisualStyleBackColor = true;
		BB9A948D.Click += new System.EventHandler(BB9A948D_Click);
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
		panel1.Controls.Add(A6B2B891);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label8);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(CF1AFCB7);
		panel1.Controls.Add(A8861BB4);
		panel1.Controls.Add(F6A14694);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label9);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(F0B7740E);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(EDBD643B);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 303);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		A6B2B891.Location = new System.Drawing.Point(141, 165);
		A6B2B891.Name = "txtCode";
		A6B2B891.Size = new System.Drawing.Size(185, 79);
		A6B2B891.TabIndex = 47;
		A6B2B891.Text = "";
		A6B2B891.WordWrap = false;
		nudDelayTo.Location = new System.Drawing.Point(218, 136);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(141, 136);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label7.Location = new System.Drawing.Point(194, 138);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = ">";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(276, 138);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(27, 165);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(95, 16);
		label8.TabIndex = 44;
		label8.Text = "Code cần chạy:";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 138);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(109, 16);
		label5.TabIndex = 44;
		label5.Text = "Delay cuộn chuột:";
		nudSoLuongTo.Location = new System.Drawing.Point(218, 107);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudSoLuongFrom.Location = new System.Drawing.Point(141, 107);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		CF1AFCB7.Location = new System.Drawing.Point(141, 78);
		CF1AFCB7.Name = "txtLink";
		CF1AFCB7.Size = new System.Drawing.Size(185, 23);
		CF1AFCB7.TabIndex = 0;
		A8861BB4.Location = new System.Drawing.Point(141, 49);
		A8861BB4.Name = "txtTenHanhDong";
		A8861BB4.Size = new System.Drawing.Size(185, 23);
		A8861BB4.TabIndex = 0;
		F6A14694.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F6A14694.Location = new System.Drawing.Point(194, 109);
		F6A14694.Name = "label3";
		F6A14694.Size = new System.Drawing.Size(29, 16);
		F6A14694.TabIndex = 37;
		F6A14694.Text = ">";
		F6A14694.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(276, 109);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(24, 16);
		label4.TabIndex = 35;
		label4.Text = "lần";
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(27, 81);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(92, 16);
		label9.TabIndex = 31;
		label9.Text = "Nhập link web:";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 109);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(114, 16);
		label2.TabIndex = 32;
		label2.Text = "Số lần cuộn chuột:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		F0B7740E.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		F0B7740E.BackColor = System.Drawing.Color.Maroon;
		F0B7740E.Cursor = System.Windows.Forms.Cursors.Hand;
		F0B7740E.FlatAppearance.BorderSize = 0;
		F0B7740E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		F0B7740E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F0B7740E.ForeColor = System.Drawing.Color.White;
		F0B7740E.Location = new System.Drawing.Point(187, 259);
		F0B7740E.Name = "btnCancel";
		F0B7740E.Size = new System.Drawing.Size(92, 29);
		F0B7740E.TabIndex = 7;
		F0B7740E.Text = "Đóng";
		F0B7740E.UseVisualStyleBackColor = false;
		F0B7740E.Click += new System.EventHandler(F0B7740E_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(80, 259);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(E602C02C);
		EDBD643B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		EDBD643B.BackColor = System.Drawing.Color.White;
		EDBD643B.BorderRadius = 0;
		EDBD643B.BottomSahddow = true;
		EDBD643B.color = System.Drawing.Color.DarkViolet;
		EDBD643B.Controls.Add(pnlHeader);
		EDBD643B.LeftSahddow = false;
		EDBD643B.Location = new System.Drawing.Point(1, 0);
		EDBD643B.Name = "bunifuCards1";
		EDBD643B.RightSahddow = true;
		EDBD643B.ShadowDepth = 20;
		EDBD643B.Size = new System.Drawing.Size(359, 37);
		EDBD643B.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 303);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanVip";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDKetBanVip_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		EDBD643B.ResumeLayout(false);
		ResumeLayout(false);
	}
}
