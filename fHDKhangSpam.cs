using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDKhangSpam : Form
{
	private GClass11 gclass11_0 = null;

	private string C42A939B;

	private string string_0;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer AF982485 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl A69F2B2C;

	private Panel B61A7D05;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private TextBox txtTenHanhDong;

	private Label EB13B59C;

	private Label label6;

	private Label C2840CA9;

	private Label label1;

	private Button B59B2F0D;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel C0826834;

	private Button B3B37612;

	private PictureBox DBAD1B36;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown A4115F37;

	private Label label2;

	private Label label3;

	private Label label4;

	public fHDKhangSpam(string B8928C26, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		C42A939B = B8928C26;
		string_1 = string_2;
		int_0 = int_1;
		if (Class147.smethod_7("", "HDKhangSpam").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDKhangSpam', 'Kháng spam');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDKhangSpam");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_2);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void EE3FAE98()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(label1);
		F7AB102E.smethod_1(C2840CA9);
		F7AB102E.smethod_1(EB13B59C);
		F7AB102E.smethod_1(label6);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(B59B2F0D);
	}

	private void fHDKhangSpam_Load(object sender, EventArgs e)
	{
		try
		{
			A4115F37.Value = gclass11_0.method_2("nudSoLuongFrom", 3);
			nudSoLuongTo.Value = gclass11_0.method_2("nudSoLuongTo", 3);
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
		}
		catch
		{
		}
	}

	private void B3B37612_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E9178092(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", A4115F37.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		string string_ = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(C42A939B, text, string_0, string_))
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

	private void B59B2F0D_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C02C700C(object sender, PaintEventArgs e)
	{
		if (B61A7D05.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, B61A7D05.ClientSize.Width - num, B61A7D05.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool A7033D34)
	{
		if (A7033D34 && AF982485 != null)
		{
			AF982485.Dispose();
		}
		base.Dispose(A7033D34);
	}

	private void InitializeComponent()
	{
		AF982485 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDKhangSpam));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(AF982485);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		A69F2B2C = new Bunifu.Framework.UI.BunifuDragControl(AF982485);
		C0826834 = new System.Windows.Forms.Panel();
		B3B37612 = new System.Windows.Forms.Button();
		DBAD1B36 = new System.Windows.Forms.PictureBox();
		B61A7D05 = new System.Windows.Forms.Panel();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		A4115F37 = new System.Windows.Forms.NumericUpDown();
		label2 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		EB13B59C = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		C2840CA9 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		B59B2F0D = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		C0826834.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)DBAD1B36).BeginInit();
		B61A7D05.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)A4115F37).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
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
		bunifuCustomLabel1.Text = "Cấu hình Kháng spam";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		A69F2B2C.Fixed = true;
		A69F2B2C.Horizontal = true;
		A69F2B2C.TargetControl = C0826834;
		A69F2B2C.Vertical = true;
		C0826834.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		C0826834.BackColor = System.Drawing.Color.White;
		C0826834.Controls.Add(B3B37612);
		C0826834.Controls.Add(DBAD1B36);
		C0826834.Controls.Add(bunifuCustomLabel1);
		C0826834.Cursor = System.Windows.Forms.Cursors.SizeAll;
		C0826834.Location = new System.Drawing.Point(0, 3);
		C0826834.Name = "pnlHeader";
		C0826834.Size = new System.Drawing.Size(359, 31);
		C0826834.TabIndex = 9;
		B3B37612.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		B3B37612.Cursor = System.Windows.Forms.Cursors.Hand;
		B3B37612.FlatAppearance.BorderSize = 0;
		B3B37612.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B3B37612.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B3B37612.ForeColor = System.Drawing.Color.White;
		B3B37612.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		B3B37612.Location = new System.Drawing.Point(328, 1);
		B3B37612.Name = "button1";
		B3B37612.Size = new System.Drawing.Size(30, 30);
		B3B37612.TabIndex = 77;
		B3B37612.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		B3B37612.UseVisualStyleBackColor = true;
		B3B37612.Click += new System.EventHandler(B3B37612_Click);
		DBAD1B36.Cursor = System.Windows.Forms.Cursors.Default;
		DBAD1B36.Image = C50FB39E.Bitmap_5;
		DBAD1B36.Location = new System.Drawing.Point(3, 2);
		DBAD1B36.Name = "pictureBox1";
		DBAD1B36.Size = new System.Drawing.Size(34, 27);
		DBAD1B36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		DBAD1B36.TabIndex = 76;
		DBAD1B36.TabStop = false;
		B61A7D05.BackColor = System.Drawing.Color.White;
		B61A7D05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		B61A7D05.Controls.Add(nudSoLuongTo);
		B61A7D05.Controls.Add(A4115F37);
		B61A7D05.Controls.Add(label2);
		B61A7D05.Controls.Add(label3);
		B61A7D05.Controls.Add(label4);
		B61A7D05.Controls.Add(nudDelayTo);
		B61A7D05.Controls.Add(nudDelayFrom);
		B61A7D05.Controls.Add(txtTenHanhDong);
		B61A7D05.Controls.Add(EB13B59C);
		B61A7D05.Controls.Add(label6);
		B61A7D05.Controls.Add(C2840CA9);
		B61A7D05.Controls.Add(label1);
		B61A7D05.Controls.Add(B59B2F0D);
		B61A7D05.Controls.Add(btnAdd);
		B61A7D05.Controls.Add(bunifuCards1);
		B61A7D05.Cursor = System.Windows.Forms.Cursors.Arrow;
		B61A7D05.Dock = System.Windows.Forms.DockStyle.Fill;
		B61A7D05.Location = new System.Drawing.Point(0, 0);
		B61A7D05.Name = "panel1";
		B61A7D05.Size = new System.Drawing.Size(362, 158);
		B61A7D05.TabIndex = 0;
		B61A7D05.Paint += new System.Windows.Forms.PaintEventHandler(C02C700C);
		nudSoLuongTo.Location = new System.Drawing.Point(229, 78);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 40;
		A4115F37.Location = new System.Drawing.Point(132, 78);
		A4115F37.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A4115F37.Name = "nudSoLuongFrom";
		A4115F37.Size = new System.Drawing.Size(56, 23);
		A4115F37.TabIndex = 39;
		label2.Location = new System.Drawing.Point(194, 80);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(29, 16);
		label2.TabIndex = 43;
		label2.Text = "đê\u0301n";
		label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(287, 214);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(0, 16);
		label3.TabIndex = 42;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(27, 80);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(63, 16);
		label4.TabIndex = 41;
		label4.Text = "Số lượng:";
		nudDelayTo.Location = new System.Drawing.Point(229, 242);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(132, 242);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		EB13B59C.Location = new System.Drawing.Point(194, 244);
		EB13B59C.Name = "label7";
		EB13B59C.Size = new System.Drawing.Size(29, 16);
		EB13B59C.TabIndex = 38;
		EB13B59C.Text = "đê\u0301n";
		EB13B59C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(287, 244);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		C2840CA9.AutoSize = true;
		C2840CA9.Location = new System.Drawing.Point(27, 244);
		C2840CA9.Name = "label5";
		C2840CA9.Size = new System.Drawing.Size(89, 16);
		C2840CA9.TabIndex = 34;
		C2840CA9.Text = "Thơ\u0300i gian chơ\u0300:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		B59B2F0D.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		B59B2F0D.BackColor = System.Drawing.Color.Maroon;
		B59B2F0D.Cursor = System.Windows.Forms.Cursors.Hand;
		B59B2F0D.FlatAppearance.BorderSize = 0;
		B59B2F0D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B59B2F0D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B59B2F0D.ForeColor = System.Drawing.Color.White;
		B59B2F0D.Location = new System.Drawing.Point(190, 116);
		B59B2F0D.Name = "btnCancel";
		B59B2F0D.Size = new System.Drawing.Size(92, 29);
		B59B2F0D.TabIndex = 10;
		B59B2F0D.Text = "Đóng";
		B59B2F0D.UseVisualStyleBackColor = false;
		B59B2F0D.Click += new System.EventHandler(B59B2F0D_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(83, 116);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(E9178092);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(C0826834);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 158);
		base.Controls.Add(B61A7D05);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKhangSpam";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDKhangSpam_Load);
		C0826834.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)DBAD1B36).EndInit();
		B61A7D05.ResumeLayout(false);
		B61A7D05.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)A4115F37).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
