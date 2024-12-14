using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class BD963B00 : Form
{
	private GClass11 gclass11_0;

	private string E8142D9A;

	private string string_0;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl B98E672B;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox B1A547B2;

	private Label AAA67891;

	private Label FA8CB894;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards EAA21018;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel D0886DBE;

	private Label lblTuKhoa;

	private NumericUpDown A40A14A0;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label6;

	private Label F2B43F1F;

	private RichTextBox txtTuKhoa;

	private ToolTip ABBDDE0C;

	private Panel plTuongTac;

	private CheckBox CAA3049B;

	private Label AA844B2C;

	private RichTextBox txtCauTraLoi;

	private Panel B90DA88D;

	private RichTextBox txtGroupId;

	private Label lblGroupId;

	private CheckBox C8BA8586;

	public BD963B00(string B5027B20, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		E8142D9A = B5027B20;
		string_1 = string_2;
		int_0 = int_1;
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDThamGiaNhomTuKhoa");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			B1A547B2.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_2);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			B1A547B2.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void BD963B00_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = gclass11_0.method_2("nudSoLuongFrom", 3);
			nudSoLuongTo.Value = gclass11_0.method_2("nudSoLuongTo", 3);
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom", 3);
			A40A14A0.Value = gclass11_0.method_2("nudDelayTo", 5);
			txtTuKhoa.Text = gclass11_0.C0288288("txtTuKhoa");
			CAA3049B.Checked = gclass11_0.method_3("ckbTuDongTraLoiCauHoi");
			txtCauTraLoi.Text = gclass11_0.C0288288("txtCauTraLoi");
			C8BA8586.Checked = gclass11_0.method_3("ckbGroupId");
			txtGroupId.Text = gclass11_0.C0288288("txtGroupId");
		}
		catch
		{
		}
		method_0();
	}

	private void method_0()
	{
		CAA3049B_CheckedChanged(null, null);
		B6A52211(null, null);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = B1A547B2.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> e03C713E = txtTuKhoa.Lines.ToList();
		e03C713E = GClass8.smethod_36(e03C713E);
		if (e03C713E.Count == 0)
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sách từ khóa!", 3);
			return;
		}
		if (CAA3049B.Checked)
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
		gClass.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", A40A14A0.Value);
		gClass.method_4("txtTuKhoa", txtTuKhoa.Text.Trim());
		gClass.method_4("ckbTuDongTraLoiCauHoi", CAA3049B.Checked);
		gClass.method_4("txtCauTraLoi", txtCauTraLoi.Text.Trim());
		gClass.method_4("ckbGroupId", C8BA8586.Checked);
		gClass.method_4("txtGroupId", txtGroupId.Text.Trim());
		string string_ = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(E8142D9A, text, string_0, string_))
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

	private void EE111704(object sender, EventArgs e)
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

	private void txtTuKhoa_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(sender as RichTextBox, lblTuKhoa);
	}

	private void CAA3049B_CheckedChanged(object sender, EventArgs e)
	{
		plTuongTac.Enabled = CAA3049B.Checked;
	}

	private void txtCauTraLoi_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(sender as RichTextBox, AA844B2C);
	}

	private void txtGroupId_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(sender as RichTextBox, lblGroupId);
	}

	private void B6A52211(object sender, EventArgs e)
	{
		B90DA88D.Enabled = C8BA8586.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BD963B00));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		D0886DBE = new Bunifu.Framework.UI.BunifuCustomLabel();
		B98E672B = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		B90DA88D = new System.Windows.Forms.Panel();
		txtGroupId = new System.Windows.Forms.RichTextBox();
		lblGroupId = new System.Windows.Forms.Label();
		plTuongTac = new System.Windows.Forms.Panel();
		txtCauTraLoi = new System.Windows.Forms.RichTextBox();
		AA844B2C = new System.Windows.Forms.Label();
		C8BA8586 = new System.Windows.Forms.CheckBox();
		CAA3049B = new System.Windows.Forms.CheckBox();
		txtTuKhoa = new System.Windows.Forms.RichTextBox();
		A40A14A0 = new System.Windows.Forms.NumericUpDown();
		lblTuKhoa = new System.Windows.Forms.Label();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		F2B43F1F = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		B1A547B2 = new System.Windows.Forms.TextBox();
		AAA67891 = new System.Windows.Forms.Label();
		FA8CB894 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		EAA21018 = new Bunifu.Framework.UI.BunifuCards();
		ABBDDE0C = new System.Windows.Forms.ToolTip(icontainer_0);
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		B90DA88D.SuspendLayout();
		plTuongTac.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)A40A14A0).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		EAA21018.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = D0886DBE;
		bunifuDragControl_0.Vertical = true;
		D0886DBE.BackColor = System.Drawing.Color.Transparent;
		D0886DBE.Cursor = System.Windows.Forms.Cursors.SizeAll;
		D0886DBE.Dock = System.Windows.Forms.DockStyle.Fill;
		D0886DBE.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D0886DBE.ForeColor = System.Drawing.Color.Black;
		D0886DBE.Location = new System.Drawing.Point(0, 0);
		D0886DBE.Name = "bunifuCustomLabel1";
		D0886DBE.Size = new System.Drawing.Size(352, 31);
		D0886DBE.TabIndex = 12;
		D0886DBE.Text = "Cấu hình Tham gia nhóm theo từ khóa";
		D0886DBE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B98E672B.Fixed = true;
		B98E672B.Horizontal = true;
		B98E672B.TargetControl = pnlHeader;
		B98E672B.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(D0886DBE);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(352, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(321, 1);
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
		panel1.Controls.Add(B90DA88D);
		panel1.Controls.Add(plTuongTac);
		panel1.Controls.Add(C8BA8586);
		panel1.Controls.Add(CAA3049B);
		panel1.Controls.Add(txtTuKhoa);
		panel1.Controls.Add(A40A14A0);
		panel1.Controls.Add(lblTuKhoa);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(F2B43F1F);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(B1A547B2);
		panel1.Controls.Add(AAA67891);
		panel1.Controls.Add(FA8CB894);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(EAA21018);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(355, 532);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		B90DA88D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		B90DA88D.Controls.Add(txtGroupId);
		B90DA88D.Controls.Add(lblGroupId);
		B90DA88D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		B90DA88D.Location = new System.Drawing.Point(365, 159);
		B90DA88D.Name = "plGroupId";
		B90DA88D.Size = new System.Drawing.Size(278, 306);
		B90DA88D.TabIndex = 116;
		txtGroupId.Location = new System.Drawing.Point(6, 23);
		txtGroupId.Name = "txtGroupId";
		txtGroupId.Size = new System.Drawing.Size(266, 278);
		txtGroupId.TabIndex = 117;
		txtGroupId.Text = "";
		txtGroupId.WordWrap = false;
		txtGroupId.TextChanged += new System.EventHandler(txtGroupId_TextChanged);
		lblGroupId.AutoSize = true;
		lblGroupId.Location = new System.Drawing.Point(3, 4);
		lblGroupId.Name = "lblGroupId";
		lblGroupId.Size = new System.Drawing.Size(143, 16);
		lblGroupId.TabIndex = 0;
		lblGroupId.Text = "Danh sách Id nhóm (0):";
		plTuongTac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plTuongTac.Controls.Add(txtCauTraLoi);
		plTuongTac.Controls.Add(AA844B2C);
		plTuongTac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		plTuongTac.Location = new System.Drawing.Point(30, 324);
		plTuongTac.Name = "plTuongTac";
		plTuongTac.Size = new System.Drawing.Size(296, 141);
		plTuongTac.TabIndex = 116;
		txtCauTraLoi.Location = new System.Drawing.Point(6, 23);
		txtCauTraLoi.Name = "txtCauTraLoi";
		txtCauTraLoi.Size = new System.Drawing.Size(266, 113);
		txtCauTraLoi.TabIndex = 117;
		txtCauTraLoi.Text = "";
		txtCauTraLoi.WordWrap = false;
		txtCauTraLoi.TextChanged += new System.EventHandler(txtCauTraLoi_TextChanged);
		AA844B2C.AutoSize = true;
		AA844B2C.Location = new System.Drawing.Point(3, 4);
		AA844B2C.Name = "lblCauTraLoi";
		AA844B2C.Size = new System.Drawing.Size(153, 16);
		AA844B2C.TabIndex = 0;
		AA844B2C.Text = "Danh sách câu trả lời (0):";
		C8BA8586.AutoSize = true;
		C8BA8586.Cursor = System.Windows.Forms.Cursors.Hand;
		C8BA8586.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		C8BA8586.Location = new System.Drawing.Point(365, 138);
		C8BA8586.Name = "ckbGroupId";
		C8BA8586.Size = new System.Drawing.Size(260, 20);
		C8BA8586.TabIndex = 115;
		C8BA8586.Text = "Chỉ tham gia nhóm thuộc danh sách sau:";
		C8BA8586.UseVisualStyleBackColor = true;
		C8BA8586.CheckedChanged += new System.EventHandler(B6A52211);
		CAA3049B.AutoSize = true;
		CAA3049B.Cursor = System.Windows.Forms.Cursors.Hand;
		CAA3049B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		CAA3049B.Location = new System.Drawing.Point(30, 302);
		CAA3049B.Name = "ckbTuDongTraLoiCauHoi";
		CAA3049B.Size = new System.Drawing.Size(156, 20);
		CAA3049B.TabIndex = 115;
		CAA3049B.Text = "Tự động trả lời câu hỏi";
		CAA3049B.UseVisualStyleBackColor = true;
		CAA3049B.CheckedChanged += new System.EventHandler(CAA3049B_CheckedChanged);
		txtTuKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtTuKhoa.Location = new System.Drawing.Point(31, 159);
		txtTuKhoa.Name = "txtTuKhoa";
		txtTuKhoa.Size = new System.Drawing.Size(295, 136);
		txtTuKhoa.TabIndex = 114;
		txtTuKhoa.Text = "";
		txtTuKhoa.WordWrap = false;
		txtTuKhoa.TextChanged += new System.EventHandler(txtTuKhoa_TextChanged);
		A40A14A0.Location = new System.Drawing.Point(229, 107);
		A40A14A0.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A40A14A0.Name = "nudDelayTo";
		A40A14A0.Size = new System.Drawing.Size(56, 23);
		A40A14A0.TabIndex = 4;
		lblTuKhoa.AutoSize = true;
		lblTuKhoa.Location = new System.Drawing.Point(27, 139);
		lblTuKhoa.Name = "lblTuKhoa";
		lblTuKhoa.Size = new System.Drawing.Size(139, 16);
		lblTuKhoa.TabIndex = 0;
		lblTuKhoa.Text = "Danh sa\u0301ch từ khóa (0):";
		nudDelayFrom.Location = new System.Drawing.Point(132, 107);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		label7.Location = new System.Drawing.Point(194, 109);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(287, 109);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		F2B43F1F.AutoSize = true;
		F2B43F1F.Location = new System.Drawing.Point(27, 109);
		F2B43F1F.Name = "label5";
		F2B43F1F.Size = new System.Drawing.Size(89, 16);
		F2B43F1F.TabIndex = 44;
		F2B43F1F.Text = "Thơ\u0300i gian chơ\u0300:";
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
		B1A547B2.Location = new System.Drawing.Point(132, 49);
		B1A547B2.Name = "txtTenHanhDong";
		B1A547B2.Size = new System.Drawing.Size(194, 23);
		B1A547B2.TabIndex = 0;
		AAA67891.Location = new System.Drawing.Point(194, 80);
		AAA67891.Name = "label3";
		AAA67891.Size = new System.Drawing.Size(29, 16);
		AAA67891.TabIndex = 37;
		AAA67891.Text = "đê\u0301n";
		AAA67891.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		FA8CB894.AutoSize = true;
		FA8CB894.Location = new System.Drawing.Point(287, 80);
		FA8CB894.Name = "label4";
		FA8CB894.Size = new System.Drawing.Size(39, 16);
		FA8CB894.TabIndex = 35;
		FA8CB894.Text = "nhóm";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 80);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(63, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng:";
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
		btnCancel.Location = new System.Drawing.Point(186, 486);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(EE111704);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(79, 486);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		EAA21018.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		EAA21018.BackColor = System.Drawing.Color.White;
		EAA21018.BorderRadius = 0;
		EAA21018.BottomSahddow = true;
		EAA21018.color = System.Drawing.Color.DarkViolet;
		EAA21018.Controls.Add(pnlHeader);
		EAA21018.LeftSahddow = false;
		EAA21018.Location = new System.Drawing.Point(1, 0);
		EAA21018.Name = "bunifuCards1";
		EAA21018.RightSahddow = true;
		EAA21018.ShadowDepth = 20;
		EAA21018.Size = new System.Drawing.Size(352, 37);
		EAA21018.TabIndex = 28;
		ABBDDE0C.AutomaticDelay = 0;
		ABBDDE0C.AutoPopDelay = 0;
		ABBDDE0C.InitialDelay = 0;
		ABBDDE0C.ReshowDelay = 0;
		ABBDDE0C.ShowAlways = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(355, 532);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDThamGiaNhomTuKhoa";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(BD963B00_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		B90DA88D.ResumeLayout(false);
		B90DA88D.PerformLayout();
		plTuongTac.ResumeLayout(false);
		plTuongTac.PerformLayout();
		((System.ComponentModel.ISupportInitialize)A40A14A0).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		EAA21018.ResumeLayout(false);
		ResumeLayout(false);
	}
}
