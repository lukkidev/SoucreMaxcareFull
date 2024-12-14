using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDHuyLoiMoiKetBan : Form
{
	private JObject jobject_0;

	private string A88C56AD;

	private string string_0;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl A0148F39;

	private BunifuDragControl DA1CEDAF;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown ADA0D48B;

	private TextBox B12E6A9F;

	private Label EE155E35;

	private Label label4;

	private Label F1887B0F;

	private Label C30437B9;

	private Button C92AFEA6;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel B236653A;

	private NumericUpDown E806FA86;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label6;

	private Label E116CFB1;

	public fHDHuyLoiMoiKetBan(string string_2, int int_1 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		A88C56AD = string_2;
		string_1 = string_3;
		int_0 = int_1;
		string json = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDHuyLoiMoiKetBan");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			B12E6A9F.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_3);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			B12E6A9F.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
		F7AB102E.D6B70A35(this);
	}

	private void A5881413()
	{
		F7AB102E.smethod_1(B236653A);
		F7AB102E.smethod_1(C30437B9);
		F7AB102E.smethod_1(F1887B0F);
		F7AB102E.smethod_1(EE155E35);
		F7AB102E.smethod_1(label4);
		F7AB102E.smethod_1(E116CFB1);
		F7AB102E.smethod_1(label7);
		F7AB102E.smethod_1(label6);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(C92AFEA6);
	}

	private void D914C08B(object sender, EventArgs e)
	{
		try
		{
			ADA0D48B.Value = Convert.ToInt32(jobject_0["nudSoLuongFrom"]);
			nudSoLuongTo.Value = Convert.ToInt32(jobject_0["nudSoLuongTo"]);
			nudDelayFrom.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			E806FA86.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
		}
		catch
		{
		}
	}

	private void D7A5CBAE(object sender, EventArgs e)
	{
		Close();
	}

	private void B0B1418A(object sender, EventArgs e)
	{
		string text = B12E6A9F.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", ADA0D48B.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", E806FA86.Value);
		string string_ = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(A88C56AD, text, string_0, string_))
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

	private void A890558D(object sender, EventArgs e)
	{
		Close();
	}

	private void B23EA295(object sender, PaintEventArgs e)
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDHuyLoiMoiKetBan));
		A0148F39 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		B236653A = new Bunifu.Framework.UI.BunifuCustomLabel();
		DA1CEDAF = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		E806FA86 = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		E116CFB1 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		ADA0D48B = new System.Windows.Forms.NumericUpDown();
		B12E6A9F = new System.Windows.Forms.TextBox();
		EE155E35 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		F1887B0F = new System.Windows.Forms.Label();
		C30437B9 = new System.Windows.Forms.Label();
		C92AFEA6 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)E806FA86).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)ADA0D48B).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		A0148F39.Fixed = true;
		A0148F39.Horizontal = true;
		A0148F39.TargetControl = B236653A;
		A0148F39.Vertical = true;
		B236653A.BackColor = System.Drawing.Color.Transparent;
		B236653A.Cursor = System.Windows.Forms.Cursors.SizeAll;
		B236653A.Dock = System.Windows.Forms.DockStyle.Fill;
		B236653A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B236653A.ForeColor = System.Drawing.Color.Black;
		B236653A.Location = new System.Drawing.Point(0, 0);
		B236653A.Name = "bunifuCustomLabel1";
		B236653A.Size = new System.Drawing.Size(359, 31);
		B236653A.TabIndex = 12;
		B236653A.Text = "Cấu hình Hủy lời mời kết bạn";
		B236653A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		DA1CEDAF.Fixed = true;
		DA1CEDAF.Horizontal = true;
		DA1CEDAF.TargetControl = pnlHeader;
		DA1CEDAF.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(B236653A);
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
		button1.Click += new System.EventHandler(D7A5CBAE);
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
		panel1.Controls.Add(E806FA86);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(E116CFB1);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(ADA0D48B);
		panel1.Controls.Add(B12E6A9F);
		panel1.Controls.Add(EE155E35);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(F1887B0F);
		panel1.Controls.Add(C30437B9);
		panel1.Controls.Add(C92AFEA6);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 206);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(B23EA295);
		E806FA86.Location = new System.Drawing.Point(223, 112);
		E806FA86.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E806FA86.Name = "nudDelayTo";
		E806FA86.Size = new System.Drawing.Size(56, 23);
		E806FA86.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(132, 112);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		label7.Location = new System.Drawing.Point(191, 114);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(280, 114);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		E116CFB1.AutoSize = true;
		E116CFB1.Location = new System.Drawing.Point(27, 114);
		E116CFB1.Name = "label5";
		E116CFB1.Size = new System.Drawing.Size(89, 16);
		E116CFB1.TabIndex = 44;
		E116CFB1.Text = "Thơ\u0300i gian chơ\u0300:";
		nudSoLuongTo.Location = new System.Drawing.Point(223, 81);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		ADA0D48B.Location = new System.Drawing.Point(132, 81);
		ADA0D48B.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		ADA0D48B.Name = "nudSoLuongFrom";
		ADA0D48B.Size = new System.Drawing.Size(56, 23);
		ADA0D48B.TabIndex = 1;
		B12E6A9F.Location = new System.Drawing.Point(132, 49);
		B12E6A9F.Name = "txtTenHanhDong";
		B12E6A9F.Size = new System.Drawing.Size(194, 23);
		B12E6A9F.TabIndex = 0;
		EE155E35.Location = new System.Drawing.Point(191, 83);
		EE155E35.Name = "label3";
		EE155E35.Size = new System.Drawing.Size(29, 16);
		EE155E35.TabIndex = 37;
		EE155E35.Text = "đê\u0301n";
		EE155E35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(280, 83);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(45, 16);
		label4.TabIndex = 35;
		label4.Text = "lời mời";
		F1887B0F.AutoSize = true;
		F1887B0F.Location = new System.Drawing.Point(27, 83);
		F1887B0F.Name = "label2";
		F1887B0F.Size = new System.Drawing.Size(63, 16);
		F1887B0F.TabIndex = 32;
		F1887B0F.Text = "Sô\u0301 lươ\u0323ng:";
		C30437B9.AutoSize = true;
		C30437B9.Location = new System.Drawing.Point(27, 52);
		C30437B9.Name = "label1";
		C30437B9.Size = new System.Drawing.Size(98, 16);
		C30437B9.TabIndex = 31;
		C30437B9.Text = "Tên ha\u0300nh đô\u0323ng:";
		C92AFEA6.BackColor = System.Drawing.Color.Maroon;
		C92AFEA6.Cursor = System.Windows.Forms.Cursors.Hand;
		C92AFEA6.FlatAppearance.BorderSize = 0;
		C92AFEA6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C92AFEA6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C92AFEA6.ForeColor = System.Drawing.Color.White;
		C92AFEA6.Location = new System.Drawing.Point(191, 158);
		C92AFEA6.Name = "btnCancel";
		C92AFEA6.Size = new System.Drawing.Size(92, 29);
		C92AFEA6.TabIndex = 7;
		C92AFEA6.Text = "Đóng";
		C92AFEA6.UseVisualStyleBackColor = false;
		C92AFEA6.Click += new System.EventHandler(A890558D);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(84, 158);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(B0B1418A);
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
		base.Name = "fHDHuyLoiMoiKetBan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(D914C08B);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)E806FA86).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)ADA0D48B).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
