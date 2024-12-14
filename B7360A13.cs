using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class B7360A13 : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string B5A9020E;

	private string EB22529D;

	private int int_0;

	public static bool CB17C7A0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl FB3E22A1;

	private Panel BB9AED1D;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown CE237784;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label label2;

	private Label B1933122;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards F894A9B9;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel C382FD90;

	private Label lblUid;

	private NumericUpDown nudDelayTo;

	private NumericUpDown AC30B518;

	private Label FDA6709B;

	private Label label5;

	private RichTextBox txtUid;

	private CheckBox ckbTuDongXoaUid;

	private ToolTip FA94FAB1;

	private Panel E60AB696;

	private CheckBox ckbTuDongTraLoiCauHoi;

	private Label lblCauTraLoi;

	private RichTextBox txtCauTraLoi;

	private Label label8;

	private ComboBox E3A55513;

	private Panel panel2;

	private CheckBox ckbUuTienMbasic;

	public B7360A13(string AA9E4701, int int_1 = 0, string BD87562F = "")
	{
		InitializeComponent();
		CB17C7A0 = false;
		string_0 = AA9E4701;
		EB22529D = BD87562F;
		int_0 = int_1;
		string string_ = base.Name.Substring(1);
		string string_2 = "Tham gia nhóm chi\u0309 đi\u0323nh";
		Class147.smethod_8(string_, string_2);
		string string_3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", string_);
			B5A9020E = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = dataTable2.Rows[0]["MoTa"].ToString();
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(BD87562F);
			string_3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = "Câ\u0323p nhâ\u0323t";
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(string_3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void B7360A13_Load(object sender, EventArgs e)
	{
		method_0();
		try
		{
			CE237784.Value = gclass11_0.method_2("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass11_0.method_2("nudSoLuongTo", 1);
			AC30B518.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
			txtUid.Text = gclass11_0.C0288288("txtUid");
			ckbTuDongTraLoiCauHoi.Checked = gclass11_0.method_3("ckbTuDongTraLoiCauHoi");
			ckbTuDongXoaUid.Checked = gclass11_0.method_3("ckbTuDongXoaUid");
			txtCauTraLoi.Text = gclass11_0.C0288288("txtCauTraLoi");
			E3A55513.SelectedIndex = gclass11_0.method_2("cbbCauTraLoi", 1);
			ckbUuTienMbasic.Checked = gclass11_0.method_3("ckbUuTienMbasic", bool_0: true);
		}
		catch
		{
		}
		B207D49C();
	}

	private void B207D49C()
	{
		A30A609C(null, null);
	}

	private void button1_Click(object sender, EventArgs e)
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
		List<string> e03C713E = txtUid.Lines.ToList();
		e03C713E = GClass8.smethod_36(e03C713E);
		if (e03C713E.Count == 0)
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sách uid nhóm!", 3);
			return;
		}
		if (ckbTuDongTraLoiCauHoi.Checked)
		{
			e03C713E = txtCauTraLoi.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			if (e03C713E.Count == 0)
			{
				GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sách câu trả lời!", 3);
				return;
			}
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", CE237784.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudDelayFrom", AC30B518.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		gClass.method_4("txtUid", txtUid.Text.Trim());
		gClass.method_4("ckbTuDongTraLoiCauHoi", ckbTuDongTraLoiCauHoi.Checked);
		gClass.method_4("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
		gClass.method_4("txtCauTraLoi", txtCauTraLoi.Text.Trim());
		gClass.method_4("cbbCauTraLoi", E3A55513.SelectedIndex);
		gClass.method_4("ckbUuTienMbasic", ckbUuTienMbasic.Checked);
		string text2 = gClass.method_7();
		if (int_0 == 0)
		{
			if (MessageBox.Show("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?", "Thông ba\u0301o", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, B5A9020E, text2))
				{
					CB17C7A0 = true;
					Close();
				}
				else
				{
					GClass29.smethod_0("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
				}
			}
		}
		else if (MessageBox.Show("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?", "Thông ba\u0301o", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		{
			if (Class147.smethod_13(EB22529D, text, text2))
			{
				CB17C7A0 = true;
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

	private void BB9AED1D_Paint(object sender, PaintEventArgs e)
	{
		if (BB9AED1D.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, BB9AED1D.ClientSize.Width - num, BB9AED1D.ClientSize.Height - num));
		}
	}

	private void D52C4806(object sender, EventArgs e)
	{
	}

	private void txtUid_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtUid, lblUid);
	}

	private void A30A609C(object sender, EventArgs e)
	{
		E60AB696.Enabled = ckbTuDongTraLoiCauHoi.Checked;
	}

	private void lblUid_Click(object sender, EventArgs e)
	{
	}

	private void txtCauTraLoi_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtCauTraLoi, lblCauTraLoi);
	}

	private void method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Random câu trả lời");
		dictionary.Add("1", "Trả lời theo thứ tự");
		GClass8.smethod_23(E3A55513, dictionary);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B7360A13));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		C382FD90 = new Bunifu.Framework.UI.BunifuCustomLabel();
		FB3E22A1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		BB9AED1D = new System.Windows.Forms.Panel();
		panel2 = new System.Windows.Forms.Panel();
		lblUid = new System.Windows.Forms.Label();
		ckbTuDongXoaUid = new System.Windows.Forms.CheckBox();
		txtUid = new System.Windows.Forms.RichTextBox();
		E60AB696 = new System.Windows.Forms.Panel();
		E3A55513 = new System.Windows.Forms.ComboBox();
		label8 = new System.Windows.Forms.Label();
		txtCauTraLoi = new System.Windows.Forms.RichTextBox();
		lblCauTraLoi = new System.Windows.Forms.Label();
		ckbTuDongTraLoiCauHoi = new System.Windows.Forms.CheckBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		AC30B518 = new System.Windows.Forms.NumericUpDown();
		FDA6709B = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		CE237784 = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		B1933122 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		F894A9B9 = new Bunifu.Framework.UI.BunifuCards();
		FA94FAB1 = new System.Windows.Forms.ToolTip(icontainer_0);
		ckbUuTienMbasic = new System.Windows.Forms.CheckBox();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		BB9AED1D.SuspendLayout();
		panel2.SuspendLayout();
		E60AB696.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)AC30B518).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)CE237784).BeginInit();
		F894A9B9.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = C382FD90;
		bunifuDragControl_0.Vertical = true;
		C382FD90.BackColor = System.Drawing.Color.Transparent;
		C382FD90.Cursor = System.Windows.Forms.Cursors.SizeAll;
		C382FD90.Dock = System.Windows.Forms.DockStyle.Fill;
		C382FD90.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C382FD90.ForeColor = System.Drawing.Color.Black;
		C382FD90.Location = new System.Drawing.Point(0, 0);
		C382FD90.Name = "bunifuCustomLabel1";
		C382FD90.Size = new System.Drawing.Size(557, 31);
		C382FD90.TabIndex = 12;
		C382FD90.Text = "Cấu hình Tham gia nhóm chi\u0309 đi\u0323nh";
		C382FD90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		FB3E22A1.Fixed = true;
		FB3E22A1.Horizontal = true;
		FB3E22A1.TargetControl = pnlHeader;
		FB3E22A1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(C382FD90);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(557, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(526, 1);
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
		BB9AED1D.BackColor = System.Drawing.Color.White;
		BB9AED1D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		BB9AED1D.Controls.Add(ckbUuTienMbasic);
		BB9AED1D.Controls.Add(panel2);
		BB9AED1D.Controls.Add(E60AB696);
		BB9AED1D.Controls.Add(ckbTuDongTraLoiCauHoi);
		BB9AED1D.Controls.Add(nudDelayTo);
		BB9AED1D.Controls.Add(AC30B518);
		BB9AED1D.Controls.Add(FDA6709B);
		BB9AED1D.Controls.Add(label5);
		BB9AED1D.Controls.Add(nudSoLuongTo);
		BB9AED1D.Controls.Add(CE237784);
		BB9AED1D.Controls.Add(txtTenHanhDong);
		BB9AED1D.Controls.Add(label3);
		BB9AED1D.Controls.Add(label2);
		BB9AED1D.Controls.Add(B1933122);
		BB9AED1D.Controls.Add(btnCancel);
		BB9AED1D.Controls.Add(btnAdd);
		BB9AED1D.Controls.Add(F894A9B9);
		BB9AED1D.Cursor = System.Windows.Forms.Cursors.Arrow;
		BB9AED1D.Dock = System.Windows.Forms.DockStyle.Fill;
		BB9AED1D.Location = new System.Drawing.Point(0, 0);
		BB9AED1D.Name = "panel1";
		BB9AED1D.Size = new System.Drawing.Size(560, 369);
		BB9AED1D.TabIndex = 0;
		BB9AED1D.Paint += new System.Windows.Forms.PaintEventHandler(BB9AED1D_Paint);
		panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel2.Controls.Add(lblUid);
		panel2.Controls.Add(ckbTuDongXoaUid);
		panel2.Controls.Add(txtUid);
		panel2.Location = new System.Drawing.Point(290, 49);
		panel2.Name = "panel2";
		panel2.Size = new System.Drawing.Size(234, 236);
		panel2.TabIndex = 117;
		lblUid.AutoSize = true;
		lblUid.Location = new System.Drawing.Point(1, 3);
		lblUid.Name = "lblUid";
		lblUid.Size = new System.Drawing.Size(113, 16);
		lblUid.TabIndex = 0;
		lblUid.Text = "Nhâ\u0323p Id nho\u0301m (0):";
		lblUid.Click += new System.EventHandler(lblUid_Click);
		ckbTuDongXoaUid.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		ckbTuDongXoaUid.AutoSize = true;
		ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuDongXoaUid.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		ckbTuDongXoaUid.Location = new System.Drawing.Point(4, 211);
		ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		ckbTuDongXoaUid.Size = new System.Drawing.Size(167, 20);
		ckbTuDongXoaUid.TabIndex = 113;
		ckbTuDongXoaUid.Text = "Xo\u0301a Id nho\u0301m đa\u0303 sư\u0309 du\u0323ng";
		ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		txtUid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtUid.Location = new System.Drawing.Point(4, 23);
		txtUid.Name = "txtUid";
		txtUid.Size = new System.Drawing.Size(224, 187);
		txtUid.TabIndex = 114;
		txtUid.Text = "";
		txtUid.WordWrap = false;
		txtUid.TextChanged += new System.EventHandler(txtUid_TextChanged);
		E60AB696.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		E60AB696.Controls.Add(E3A55513);
		E60AB696.Controls.Add(label8);
		E60AB696.Controls.Add(txtCauTraLoi);
		E60AB696.Controls.Add(lblCauTraLoi);
		E60AB696.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		E60AB696.Location = new System.Drawing.Point(30, 156);
		E60AB696.Name = "plTuongTac";
		E60AB696.Size = new System.Drawing.Size(244, 155);
		E60AB696.TabIndex = 116;
		E3A55513.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		E3A55513.Cursor = System.Windows.Forms.Cursors.Hand;
		E3A55513.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		E3A55513.FormattingEnabled = true;
		E3A55513.Location = new System.Drawing.Point(73, 159);
		E3A55513.Name = "cbbCauTraLoi";
		E3A55513.Size = new System.Drawing.Size(164, 24);
		E3A55513.TabIndex = 4;
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(3, 152);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(64, 16);
		label8.TabIndex = 3;
		label8.Text = "Tùy chọn:";
		txtCauTraLoi.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtCauTraLoi.Location = new System.Drawing.Point(4, 22);
		txtCauTraLoi.Name = "txtCauTraLoi";
		txtCauTraLoi.Size = new System.Drawing.Size(235, 128);
		txtCauTraLoi.TabIndex = 2;
		txtCauTraLoi.Text = "";
		txtCauTraLoi.WordWrap = false;
		txtCauTraLoi.TextChanged += new System.EventHandler(txtCauTraLoi_TextChanged);
		lblCauTraLoi.AutoSize = true;
		lblCauTraLoi.Location = new System.Drawing.Point(1, 3);
		lblCauTraLoi.Name = "lblCauTraLoi";
		lblCauTraLoi.Size = new System.Drawing.Size(153, 16);
		lblCauTraLoi.TabIndex = 0;
		lblCauTraLoi.Text = "Danh sách câu trả lời (0):";
		ckbTuDongTraLoiCauHoi.AutoSize = true;
		ckbTuDongTraLoiCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuDongTraLoiCauHoi.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		ckbTuDongTraLoiCauHoi.Location = new System.Drawing.Point(30, 134);
		ckbTuDongTraLoiCauHoi.Name = "ckbTuDongTraLoiCauHoi";
		ckbTuDongTraLoiCauHoi.Size = new System.Drawing.Size(156, 20);
		ckbTuDongTraLoiCauHoi.TabIndex = 115;
		ckbTuDongTraLoiCauHoi.Text = "Tự động trả lời câu hỏi";
		ckbTuDongTraLoiCauHoi.UseVisualStyleBackColor = true;
		ckbTuDongTraLoiCauHoi.CheckedChanged += new System.EventHandler(A30A609C);
		nudDelayTo.Location = new System.Drawing.Point(218, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		AC30B518.Location = new System.Drawing.Point(132, 107);
		AC30B518.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		AC30B518.Name = "nudDelayFrom";
		AC30B518.Size = new System.Drawing.Size(56, 23);
		AC30B518.TabIndex = 3;
		FDA6709B.AutoSize = true;
		FDA6709B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		FDA6709B.Location = new System.Drawing.Point(194, 109);
		FDA6709B.Name = "label7";
		FDA6709B.Size = new System.Drawing.Size(18, 16);
		FDA6709B.TabIndex = 46;
		FDA6709B.Text = ">";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 109);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(87, 16);
		label5.TabIndex = 44;
		label5.Text = "Gia\u0303n ca\u0301ch (s):";
		nudSoLuongTo.Location = new System.Drawing.Point(218, 78);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		CE237784.Location = new System.Drawing.Point(132, 78);
		CE237784.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		CE237784.Name = "nudSoLuongFrom";
		CE237784.Size = new System.Drawing.Size(56, 23);
		CE237784.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(142, 23);
		txtTenHanhDong.TabIndex = 0;
		label3.AutoSize = true;
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(194, 80);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(18, 16);
		label3.TabIndex = 37;
		label3.Text = ">";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 80);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(99, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng nho\u0301m:";
		B1933122.AutoSize = true;
		B1933122.Location = new System.Drawing.Point(27, 52);
		B1933122.Name = "label1";
		B1933122.Size = new System.Drawing.Size(98, 16);
		B1933122.TabIndex = 31;
		B1933122.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(290, 326);
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
		btnAdd.Location = new System.Drawing.Point(183, 326);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		F894A9B9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		F894A9B9.BackColor = System.Drawing.Color.White;
		F894A9B9.BorderRadius = 0;
		F894A9B9.BottomSahddow = true;
		F894A9B9.color = System.Drawing.Color.DarkViolet;
		F894A9B9.Controls.Add(pnlHeader);
		F894A9B9.LeftSahddow = false;
		F894A9B9.Location = new System.Drawing.Point(1, 0);
		F894A9B9.Name = "bunifuCards1";
		F894A9B9.RightSahddow = true;
		F894A9B9.ShadowDepth = 20;
		F894A9B9.Size = new System.Drawing.Size(557, 37);
		F894A9B9.TabIndex = 28;
		FA94FAB1.AutomaticDelay = 0;
		FA94FAB1.AutoPopDelay = 0;
		FA94FAB1.InitialDelay = 0;
		FA94FAB1.ReshowDelay = 0;
		FA94FAB1.ShowAlways = true;
		ckbUuTienMbasic.AutoSize = true;
		ckbUuTienMbasic.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbUuTienMbasic.Location = new System.Drawing.Point(290, 291);
		ckbUuTienMbasic.Name = "ckbUuTienMbasic";
		ckbUuTienMbasic.Size = new System.Drawing.Size(173, 20);
		ckbUuTienMbasic.TabIndex = 199;
		ckbUuTienMbasic.Text = "Ưu tiên chạy bằng mbasic";
		ckbUuTienMbasic.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(560, 369);
		base.Controls.Add(BB9AED1D);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDThamGiaNhomUid";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(B7360A13_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		BB9AED1D.ResumeLayout(false);
		BB9AED1D.PerformLayout();
		panel2.ResumeLayout(false);
		panel2.PerformLayout();
		E60AB696.ResumeLayout(false);
		E60AB696.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)AC30B518).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)CE237784).EndInit();
		F894A9B9.ResumeLayout(false);
		ResumeLayout(false);
	}
}
