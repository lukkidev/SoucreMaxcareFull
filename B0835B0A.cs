using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class B0835B0A : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown DD17898A;

	private NumericUpDown CC058220;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label FF0BFC1F;

	private Label label1;

	private Button A8201192;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel F53210B2;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label C22D3484;

	private ToolTip toolTip_0;

	private CheckBox ckbTuDongTraLoiCauHoi;

	private Panel plTuDongTraLoiCauHoi;

	private ComboBox cbbCauTraLoi;

	private Label E4223F0C;

	private RichTextBox txtCauTraLoi;

	private Label D819C523;

	public B0835B0A(string string_3, int B99A2DA7 = 0, string string_4 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = B99A2DA7;
		if (Class147.smethod_7("", "HDThamGiaNhomGoiY").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDThamGiaNhomGoiY', 'Tham gia nhóm gợi ý');");
		}
		string text = "";
		switch (B99A2DA7)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDThamGiaNhomGoiY");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_4);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void B0835B0A_Load(object sender, EventArgs e)
	{
		try
		{
			CC058220.Value = gclass11_0.method_2("nudSoLuongFrom", 3);
			DD17898A.Value = gclass11_0.method_2("nudSoLuongTo", 5);
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
			ckbTuDongTraLoiCauHoi.Checked = gclass11_0.method_3("ckbTuDongTraLoiCauHoi");
			txtCauTraLoi.Text = gclass11_0.C0288288("txtCauTraLoi");
		}
		catch
		{
		}
		method_0();
	}

	private void method_0()
	{
		F59D7283(null, null);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void CD1EAA36(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		if (ckbTuDongTraLoiCauHoi.Checked)
		{
			List<string> e03C713E = txtCauTraLoi.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			if (e03C713E.Count == 0)
			{
				GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sách câu trả lời!", 3);
				return;
			}
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", CC058220.Value);
		gClass.method_4("nudSoLuongTo", DD17898A.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		gClass.method_4("ckbTuDongTraLoiCauHoi", ckbTuDongTraLoiCauHoi.Checked);
		gClass.method_4("txtCauTraLoi", txtCauTraLoi.Text.Trim());
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

	private void A8201192_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FF261F32(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void F59D7283(object sender, EventArgs e)
	{
		plTuDongTraLoiCauHoi.Enabled = ckbTuDongTraLoiCauHoi.Checked;
	}

	private void txtCauTraLoi_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtCauTraLoi, D819C523);
	}

	protected override void Dispose(bool BB8A0B0A)
	{
		if (BB8A0B0A && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(BB8A0B0A);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		F53210B2 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		ckbTuDongTraLoiCauHoi = new System.Windows.Forms.CheckBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		C22D3484 = new System.Windows.Forms.Label();
		DD17898A = new System.Windows.Forms.NumericUpDown();
		CC058220 = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		FF0BFC1F = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		A8201192 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		toolTip_0 = new System.Windows.Forms.ToolTip(icontainer_0);
		plTuDongTraLoiCauHoi = new System.Windows.Forms.Panel();
		cbbCauTraLoi = new System.Windows.Forms.ComboBox();
		E4223F0C = new System.Windows.Forms.Label();
		txtCauTraLoi = new System.Windows.Forms.RichTextBox();
		D819C523 = new System.Windows.Forms.Label();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)DD17898A).BeginInit();
		((System.ComponentModel.ISupportInitialize)CC058220).BeginInit();
		bunifuCards1.SuspendLayout();
		plTuDongTraLoiCauHoi.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = F53210B2;
		bunifuDragControl_0.Vertical = true;
		F53210B2.BackColor = System.Drawing.Color.Transparent;
		F53210B2.Cursor = System.Windows.Forms.Cursors.SizeAll;
		F53210B2.Dock = System.Windows.Forms.DockStyle.Fill;
		F53210B2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F53210B2.ForeColor = System.Drawing.Color.Black;
		F53210B2.Location = new System.Drawing.Point(0, 0);
		F53210B2.Name = "bunifuCustomLabel1";
		F53210B2.Size = new System.Drawing.Size(317, 31);
		F53210B2.TabIndex = 12;
		F53210B2.Text = "Cấu hình Tham gia nhóm gợi ý";
		F53210B2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(F53210B2);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(317, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = C50FB39E.Bitmap_12;
		button1.Location = new System.Drawing.Point(286, 1);
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
		panel1.Controls.Add(plTuDongTraLoiCauHoi);
		panel1.Controls.Add(ckbTuDongTraLoiCauHoi);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(C22D3484);
		panel1.Controls.Add(DD17898A);
		panel1.Controls.Add(CC058220);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(FF0BFC1F);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(A8201192);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(320, 370);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(FF261F32);
		ckbTuDongTraLoiCauHoi.AutoSize = true;
		ckbTuDongTraLoiCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuDongTraLoiCauHoi.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		ckbTuDongTraLoiCauHoi.Location = new System.Drawing.Point(30, 136);
		ckbTuDongTraLoiCauHoi.Name = "ckbTuDongTraLoiCauHoi";
		ckbTuDongTraLoiCauHoi.Size = new System.Drawing.Size(156, 20);
		ckbTuDongTraLoiCauHoi.TabIndex = 115;
		ckbTuDongTraLoiCauHoi.Text = "Tự động trả lời câu hỏi";
		ckbTuDongTraLoiCauHoi.UseVisualStyleBackColor = true;
		ckbTuDongTraLoiCauHoi.CheckedChanged += new System.EventHandler(F59D7283);
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
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label7.Location = new System.Drawing.Point(194, 109);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = ">";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C22D3484.AutoSize = true;
		C22D3484.Location = new System.Drawing.Point(27, 109);
		C22D3484.Name = "label5";
		C22D3484.Size = new System.Drawing.Size(89, 16);
		C22D3484.TabIndex = 44;
		C22D3484.Text = "Thơ\u0300i gian chơ\u0300:";
		DD17898A.Location = new System.Drawing.Point(229, 78);
		DD17898A.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		DD17898A.Name = "nudSoLuongTo";
		DD17898A.Size = new System.Drawing.Size(56, 23);
		DD17898A.TabIndex = 2;
		CC058220.Location = new System.Drawing.Point(132, 78);
		CC058220.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		CC058220.Name = "nudSoLuongFrom";
		CC058220.Size = new System.Drawing.Size(56, 23);
		CC058220.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(153, 23);
		txtTenHanhDong.TabIndex = 0;
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(194, 80);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = ">";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		FF0BFC1F.AutoSize = true;
		FF0BFC1F.Location = new System.Drawing.Point(27, 80);
		FF0BFC1F.Name = "label2";
		FF0BFC1F.Size = new System.Drawing.Size(99, 16);
		FF0BFC1F.TabIndex = 32;
		FF0BFC1F.Text = "Sô\u0301 lươ\u0323ng nhóm:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		A8201192.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		A8201192.BackColor = System.Drawing.Color.Maroon;
		A8201192.Cursor = System.Windows.Forms.Cursors.Hand;
		A8201192.FlatAppearance.BorderSize = 0;
		A8201192.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A8201192.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A8201192.ForeColor = System.Drawing.Color.White;
		A8201192.Location = new System.Drawing.Point(170, 327);
		A8201192.Name = "btnCancel";
		A8201192.Size = new System.Drawing.Size(92, 29);
		A8201192.TabIndex = 7;
		A8201192.Text = "Đóng";
		A8201192.UseVisualStyleBackColor = false;
		A8201192.Click += new System.EventHandler(A8201192_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(63, 327);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(CD1EAA36);
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
		bunifuCards1.Size = new System.Drawing.Size(317, 37);
		bunifuCards1.TabIndex = 28;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 0;
		toolTip_0.InitialDelay = 0;
		toolTip_0.ReshowDelay = 0;
		toolTip_0.ShowAlways = true;
		plTuDongTraLoiCauHoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plTuDongTraLoiCauHoi.Controls.Add(cbbCauTraLoi);
		plTuDongTraLoiCauHoi.Controls.Add(E4223F0C);
		plTuDongTraLoiCauHoi.Controls.Add(txtCauTraLoi);
		plTuDongTraLoiCauHoi.Controls.Add(D819C523);
		plTuDongTraLoiCauHoi.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		plTuDongTraLoiCauHoi.Location = new System.Drawing.Point(51, 158);
		plTuDongTraLoiCauHoi.Name = "plTuDongTraLoiCauHoi";
		plTuDongTraLoiCauHoi.Size = new System.Drawing.Size(234, 155);
		plTuDongTraLoiCauHoi.TabIndex = 117;
		cbbCauTraLoi.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		cbbCauTraLoi.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbCauTraLoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbCauTraLoi.FormattingEnabled = true;
		cbbCauTraLoi.Location = new System.Drawing.Point(73, 159);
		cbbCauTraLoi.Name = "cbbCauTraLoi";
		cbbCauTraLoi.Size = new System.Drawing.Size(154, 24);
		cbbCauTraLoi.TabIndex = 4;
		E4223F0C.AutoSize = true;
		E4223F0C.Location = new System.Drawing.Point(3, 152);
		E4223F0C.Name = "label8";
		E4223F0C.Size = new System.Drawing.Size(64, 16);
		E4223F0C.TabIndex = 3;
		E4223F0C.Text = "Tùy chọn:";
		txtCauTraLoi.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtCauTraLoi.Location = new System.Drawing.Point(4, 22);
		txtCauTraLoi.Name = "txtCauTraLoi";
		txtCauTraLoi.Size = new System.Drawing.Size(225, 128);
		txtCauTraLoi.TabIndex = 2;
		txtCauTraLoi.Text = "";
		txtCauTraLoi.TextChanged += new System.EventHandler(txtCauTraLoi_TextChanged);
		D819C523.AutoSize = true;
		D819C523.Location = new System.Drawing.Point(1, 3);
		D819C523.Name = "lblCauTraLoi";
		D819C523.Size = new System.Drawing.Size(153, 16);
		D819C523.TabIndex = 0;
		D819C523.Text = "Danh sách câu trả lời (0):";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(320, 370);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDThamGiaNhomGoiY";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = " ";
		base.Load += new System.EventHandler(B0835B0A_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)DD17898A).EndInit();
		((System.ComponentModel.ISupportInitialize)CC058220).EndInit();
		bunifuCards1.ResumeLayout(false);
		plTuDongTraLoiCauHoi.ResumeLayout(false);
		plTuDongTraLoiCauHoi.PerformLayout();
		ResumeLayout(false);
	}
}
