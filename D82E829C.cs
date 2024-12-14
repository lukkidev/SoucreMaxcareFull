using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class D82E829C : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string string_1;

	private string E0AF5B0C;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label D8357B39;

	private Label label2;

	private Label E92A111B;

	private Button btnCancel;

	private Button FC812886;

	private BunifuCards bunifuCards1;

	private Panel FB867689;

	private Button button1;

	private PictureBox DB92D62E;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label lblTuKhoa;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label A694931F;

	private Label label5;

	private RichTextBox txtTuKhoa;

	public D82E829C(string string_2, int int_1 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_2;
		E0AF5B0C = string_3;
		int_0 = int_1;
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDKetBanTheoTuKhoa");
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			FC812886.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void C53FC136(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = gclass11_0.method_2("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass11_0.method_2("nudSoLuongTo", 1);
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
			txtTuKhoa.Text = gclass11_0.C0288288("txtTuKhoa");
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FC812886_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> e03C713E = txtTuKhoa.Lines.ToList();
		e03C713E = GClass8.smethod_36(e03C713E);
		if (e03C713E.Count == 0)
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p từ khóa!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		gClass.method_4("txtTuKhoa", txtTuKhoa.Text.Trim());
		string string_ = gClass.method_7();
		if (int_0 == 0)
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
			if (Class147.smethod_13(E0AF5B0C, text, string_))
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

	private void btnCancel_Click(object sender, EventArgs e)
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

	private void AA2B1680(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtTuKhoa, lblTuKhoa);
	}

	protected override void Dispose(bool C2A3B32C)
	{
		if (C2A3B32C && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C2A3B32C);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(D82E829C));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		FB867689 = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		DB92D62E = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		lblTuKhoa = new System.Windows.Forms.Label();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		A694931F = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		D8357B39 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		E92A111B = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		FC812886 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		txtTuKhoa = new System.Windows.Forms.RichTextBox();
		FB867689.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)DB92D62E).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(320, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Kết bạn theo từ khóa";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = FB867689;
		bunifuDragControl_1.Vertical = true;
		FB867689.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		FB867689.BackColor = System.Drawing.Color.White;
		FB867689.Controls.Add(button1);
		FB867689.Controls.Add(DB92D62E);
		FB867689.Controls.Add(bunifuCustomLabel1);
		FB867689.Cursor = System.Windows.Forms.Cursors.SizeAll;
		FB867689.Location = new System.Drawing.Point(0, 3);
		FB867689.Name = "pnlHeader";
		FB867689.Size = new System.Drawing.Size(320, 31);
		FB867689.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(289, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		DB92D62E.Cursor = System.Windows.Forms.Cursors.Default;
		DB92D62E.Image = C50FB39E.Bitmap_5;
		DB92D62E.Location = new System.Drawing.Point(3, 2);
		DB92D62E.Name = "pictureBox1";
		DB92D62E.Size = new System.Drawing.Size(34, 27);
		DB92D62E.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		DB92D62E.TabIndex = 76;
		DB92D62E.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(txtTuKhoa);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(lblTuKhoa);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(A694931F);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(D8357B39);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(E92A111B);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(FC812886);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(323, 361);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		nudDelayTo.Location = new System.Drawing.Point(229, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		lblTuKhoa.AutoSize = true;
		lblTuKhoa.Location = new System.Drawing.Point(28, 134);
		lblTuKhoa.Name = "lblTuKhoa";
		lblTuKhoa.Size = new System.Drawing.Size(139, 16);
		lblTuKhoa.TabIndex = 0;
		lblTuKhoa.Text = "Danh sa\u0301ch từ khóa (0):";
		nudDelayFrom.Location = new System.Drawing.Point(132, 107);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		A694931F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A694931F.Location = new System.Drawing.Point(194, 109);
		A694931F.Name = "label7";
		A694931F.Size = new System.Drawing.Size(29, 16);
		A694931F.TabIndex = 46;
		A694931F.Text = ">";
		A694931F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 109);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(87, 16);
		label5.TabIndex = 44;
		label5.Text = "Gia\u0303n ca\u0301ch (s):";
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
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(153, 23);
		txtTenHanhDong.TabIndex = 0;
		D8357B39.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D8357B39.Location = new System.Drawing.Point(194, 80);
		D8357B39.Name = "label3";
		D8357B39.Size = new System.Drawing.Size(29, 16);
		D8357B39.TabIndex = 37;
		D8357B39.Text = ">";
		D8357B39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 80);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(88, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		E92A111B.AutoSize = true;
		E92A111B.Location = new System.Drawing.Point(27, 52);
		E92A111B.Name = "label1";
		E92A111B.Size = new System.Drawing.Size(98, 16);
		E92A111B.TabIndex = 31;
		E92A111B.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(167, 319);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		FC812886.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		FC812886.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		FC812886.Cursor = System.Windows.Forms.Cursors.Hand;
		FC812886.FlatAppearance.BorderSize = 0;
		FC812886.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		FC812886.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		FC812886.ForeColor = System.Drawing.Color.White;
		FC812886.Location = new System.Drawing.Point(60, 319);
		FC812886.Name = "btnAdd";
		FC812886.Size = new System.Drawing.Size(92, 29);
		FC812886.TabIndex = 6;
		FC812886.Text = "Thêm";
		FC812886.UseVisualStyleBackColor = false;
		FC812886.Click += new System.EventHandler(FC812886_Click);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(FB867689);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(320, 37);
		bunifuCards1.TabIndex = 28;
		txtTuKhoa.Location = new System.Drawing.Point(31, 154);
		txtTuKhoa.Name = "txtTuKhoa";
		txtTuKhoa.Size = new System.Drawing.Size(254, 151);
		txtTuKhoa.TabIndex = 47;
		txtTuKhoa.Text = "";
		txtTuKhoa.WordWrap = false;
		txtTuKhoa.TextChanged += new System.EventHandler(AA2B1680);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(323, 361);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanTheoTuKhoa";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(C53FC136);
		FB867689.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)DB92D62E).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
