using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDRoiNhom : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private IContainer C7A3552F = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox A8A94083;

	private Label label3;

	private Label label4;

	private Label BEBAED9F;

	private Label label1;

	private Button D929D2B4;

	private Button btnAdd;

	private BunifuCards DC9BEF15;

	private Panel BF1FE213;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown C70E0630;

	private Label FB38F292;

	private Label label6;

	private Label C3361713;

	private Label label9;

	private Panel C127222B;

	private Label label10;

	private Label BAA53F00;

	private Panel plDieuKienTuKhoa;

	private CheckBox ckbDieuKienTuKhoa;

	private CheckBox ckbDieuKienThanhVien;

	private NumericUpDown DB162806;

	private RichTextBox C6243B9D;

	private Label lblIDNhomGiuLai;

	private Panel panel2;

	private Label B5330B83;

	private Label label13;

	private CheckBox AE35653F;

	private RichTextBox txtTuKhoa;

	private RichTextBox txtIdNhomRoi;

	private ComboBox cbbTypeRoiNhom;

	public fHDRoiNhom(string B227712C, int A19B6C1C = 0, string EFB65020 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = B227712C;
		string_2 = EFB65020;
		int_0 = A19B6C1C;
		string text = "";
		switch (A19B6C1C)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDRoiNhom");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			A8A94083.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(EFB65020);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			A8A94083.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(label1);
		F7AB102E.smethod_1(BEBAED9F);
		F7AB102E.smethod_1(label3);
		F7AB102E.smethod_1(label4);
		F7AB102E.smethod_1(C3361713);
		F7AB102E.smethod_1(FB38F292);
		F7AB102E.smethod_1(label6);
		F7AB102E.smethod_1(label9);
		F7AB102E.smethod_1(ckbDieuKienThanhVien);
		F7AB102E.smethod_1(ckbDieuKienTuKhoa);
		F7AB102E.smethod_1(BAA53F00);
		F7AB102E.smethod_1(label10);
		F7AB102E.smethod_1(lblIDNhomGiuLai);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(D929D2B4);
	}

	private void fHDRoiNhom_Load(object sender, EventArgs e)
	{
		method_1();
		try
		{
			nudSoLuongFrom.Value = gclass11_0.method_2("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass11_0.method_2("nudSoLuongTo", 1);
			C70E0630.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
			cbbTypeRoiNhom.SelectedIndex = gclass11_0.method_2("typeRoiNhom");
			ckbDieuKienThanhVien.Checked = gclass11_0.method_3("ckbDieuKienThanhVien");
			DB162806.Value = gclass11_0.method_2("nudThanhVienToiDa");
			ckbDieuKienTuKhoa.Checked = gclass11_0.method_3("ckbDieuKienTuKhoa");
			txtTuKhoa.Text = gclass11_0.C0288288("txtTuKhoa");
			C6243B9D.Text = gclass11_0.C0288288("txtIDNhomGiuLai");
			AE35653F.Checked = gclass11_0.method_3("ckbDieuKienID");
			txtIdNhomRoi.Text = gclass11_0.C0288288("txtIdNhomRoi");
		}
		catch
		{
		}
		F917E418();
	}

	private void method_1()
	{
		List<string> list_ = new List<string> { "Ngẫu nhiên danh sách nhóm", "Rời nhóm kiểm duyệt bài viết", "Rời nhóm theo điều kiện" };
		GClass8.smethod_22(cbbTypeRoiNhom, list_);
	}

	private void E7332090(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = A8A94083.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		if (cbbTypeRoiNhom.SelectedIndex == 2)
		{
			if (!ckbDieuKienThanhVien.Checked && !ckbDieuKienTuKhoa.Checked && !AE35653F.Checked)
			{
				GClass29.smethod_0("Vui lo\u0300ng cho\u0323n i\u0301t nhâ\u0301t mô\u0323t điê\u0300u kiê\u0323n rơ\u0300i nho\u0301m!", 3);
				return;
			}
			if (ckbDieuKienTuKhoa.Checked)
			{
				List<string> e03C713E = txtTuKhoa.Lines.ToList();
				e03C713E = GClass8.smethod_36(e03C713E);
				if (e03C713E.Count == 0)
				{
					GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch tư\u0300 kho\u0301a!", 3);
					return;
				}
			}
			else if (AE35653F.Checked)
			{
				List<string> e03C713E2 = txtIdNhomRoi.Lines.ToList();
				e03C713E2 = GClass8.smethod_36(e03C713E2);
				if (e03C713E2.Count == 0)
				{
					GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch nhóm cần rời!", 3);
					return;
				}
			}
		}
		gclass11_0.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gclass11_0.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gclass11_0.method_4("nudDelayFrom", C70E0630.Value);
		gclass11_0.method_4("nudDelayTo", nudDelayTo.Value);
		gclass11_0.method_4("typeRoiNhom", cbbTypeRoiNhom.SelectedIndex);
		gclass11_0.method_4("ckbDieuKienThanhVien", ckbDieuKienThanhVien.Checked);
		gclass11_0.method_4("nudThanhVienToiDa", DB162806.Value);
		gclass11_0.method_4("ckbDieuKienTuKhoa", ckbDieuKienTuKhoa.Checked);
		gclass11_0.method_4("txtTuKhoa", txtTuKhoa.Text.Trim());
		gclass11_0.method_4("txtIDNhomGiuLai", C6243B9D.Text);
		gclass11_0.method_4("ckbDieuKienID", AE35653F.Checked);
		gclass11_0.method_4("txtIdNhomRoi", txtIdNhomRoi.Text.Trim());
		string text2 = gclass11_0.method_7();
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

	private void D929D2B4_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void AFB0E0AB(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void F917E418()
	{
		ckbDieuKienThanhVien_CheckedChanged(null, null);
		ckbDieuKienTuKhoa_CheckedChanged(null, null);
		method_2(null, null);
		CEA00706(null, null);
	}

	private void ckbDieuKienThanhVien_CheckedChanged(object sender, EventArgs e)
	{
		DB162806.Enabled = ckbDieuKienThanhVien.Checked;
	}

	private void ckbDieuKienTuKhoa_CheckedChanged(object sender, EventArgs e)
	{
		plDieuKienTuKhoa.Enabled = ckbDieuKienTuKhoa.Checked;
	}

	private void CC946498(object sender, EventArgs e)
	{
	}

	private void A903D08C(object sender, EventArgs e)
	{
		GClass8.smethod_60(C6243B9D, lblIDNhomGiuLai);
	}

	private void method_2(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtIdNhomRoi.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			B5330B83.Text = string.Format(F7AB102E.smethod_0("Danh sách ID nhóm ({0}):"), e03C713E.Count.ToString());
		}
		catch
		{
		}
	}

	private void CEA00706(object sender, EventArgs e)
	{
		panel2.Enabled = AE35653F.Checked;
	}

	private void B3AEFE33(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtTuKhoa, BAA53F00);
	}

	private void txtIdNhomRoi_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtIdNhomRoi, B5330B83);
	}

	private void cbbTypeRoiNhom_SelectedIndexChanged(object sender, EventArgs e)
	{
		C127222B.Enabled = cbbTypeRoiNhom.SelectedIndex == 2;
	}

	protected override void Dispose(bool B208751F)
	{
		if (B208751F && C7A3552F != null)
		{
			C7A3552F.Dispose();
		}
		base.Dispose(B208751F);
	}

	private void InitializeComponent()
	{
		C7A3552F = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDRoiNhom));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(C7A3552F);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(C7A3552F);
		BF1FE213 = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		cbbTypeRoiNhom = new System.Windows.Forms.ComboBox();
		C6243B9D = new System.Windows.Forms.RichTextBox();
		lblIDNhomGiuLai = new System.Windows.Forms.Label();
		C127222B = new System.Windows.Forms.Panel();
		panel2 = new System.Windows.Forms.Panel();
		txtIdNhomRoi = new System.Windows.Forms.RichTextBox();
		B5330B83 = new System.Windows.Forms.Label();
		label13 = new System.Windows.Forms.Label();
		AE35653F = new System.Windows.Forms.CheckBox();
		plDieuKienTuKhoa = new System.Windows.Forms.Panel();
		txtTuKhoa = new System.Windows.Forms.RichTextBox();
		BAA53F00 = new System.Windows.Forms.Label();
		label10 = new System.Windows.Forms.Label();
		ckbDieuKienTuKhoa = new System.Windows.Forms.CheckBox();
		ckbDieuKienThanhVien = new System.Windows.Forms.CheckBox();
		DB162806 = new System.Windows.Forms.NumericUpDown();
		label9 = new System.Windows.Forms.Label();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		C70E0630 = new System.Windows.Forms.NumericUpDown();
		FB38F292 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		C3361713 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		A8A94083 = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		BEBAED9F = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		D929D2B4 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		DC9BEF15 = new Bunifu.Framework.UI.BunifuCards();
		BF1FE213.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		C127222B.SuspendLayout();
		panel2.SuspendLayout();
		plDieuKienTuKhoa.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)DB162806).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)C70E0630).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		DC9BEF15.SuspendLayout();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(676, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Rơ\u0300i nho\u0301m";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = BF1FE213;
		bunifuDragControl_1.Vertical = true;
		BF1FE213.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		BF1FE213.BackColor = System.Drawing.Color.White;
		BF1FE213.Controls.Add(button1);
		BF1FE213.Controls.Add(pictureBox1);
		BF1FE213.Controls.Add(bunifuCustomLabel1);
		BF1FE213.Cursor = System.Windows.Forms.Cursors.SizeAll;
		BF1FE213.Location = new System.Drawing.Point(0, 3);
		BF1FE213.Name = "pnlHeader";
		BF1FE213.Size = new System.Drawing.Size(676, 31);
		BF1FE213.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(645, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(E7332090);
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
		panel1.Controls.Add(cbbTypeRoiNhom);
		panel1.Controls.Add(C6243B9D);
		panel1.Controls.Add(lblIDNhomGiuLai);
		panel1.Controls.Add(C127222B);
		panel1.Controls.Add(label9);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(C70E0630);
		panel1.Controls.Add(FB38F292);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(C3361713);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(A8A94083);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(BEBAED9F);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(D929D2B4);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(DC9BEF15);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(679, 575);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(AFB0E0AB);
		cbbTypeRoiNhom.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTypeRoiNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTypeRoiNhom.FormattingEnabled = true;
		cbbTypeRoiNhom.Location = new System.Drawing.Point(420, 79);
		cbbTypeRoiNhom.Name = "cbbTypeRoiNhom";
		cbbTypeRoiNhom.Size = new System.Drawing.Size(229, 24);
		cbbTypeRoiNhom.TabIndex = 121;
		cbbTypeRoiNhom.SelectedIndexChanged += new System.EventHandler(cbbTypeRoiNhom_SelectedIndexChanged);
		C6243B9D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C6243B9D.Location = new System.Drawing.Point(30, 158);
		C6243B9D.Name = "txtIDNhomGiuLai";
		C6243B9D.Size = new System.Drawing.Size(296, 361);
		C6243B9D.TabIndex = 120;
		C6243B9D.Text = "";
		C6243B9D.WordWrap = false;
		C6243B9D.TextChanged += new System.EventHandler(A903D08C);
		lblIDNhomGiuLai.AutoSize = true;
		lblIDNhomGiuLai.Location = new System.Drawing.Point(27, 139);
		lblIDNhomGiuLai.Name = "lblIDNhomGiuLai";
		lblIDNhomGiuLai.Size = new System.Drawing.Size(207, 16);
		lblIDNhomGiuLai.TabIndex = 118;
		lblIDNhomGiuLai.Text = "Danh sách ID nhóm cần giữ lại (0):";
		lblIDNhomGiuLai.Click += new System.EventHandler(CC946498);
		C127222B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C127222B.Controls.Add(panel2);
		C127222B.Controls.Add(AE35653F);
		C127222B.Controls.Add(plDieuKienTuKhoa);
		C127222B.Controls.Add(ckbDieuKienTuKhoa);
		C127222B.Controls.Add(ckbDieuKienThanhVien);
		C127222B.Controls.Add(DB162806);
		C127222B.Location = new System.Drawing.Point(354, 111);
		C127222B.Name = "plUidChiDinh";
		C127222B.Size = new System.Drawing.Size(295, 408);
		C127222B.TabIndex = 49;
		panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel2.Controls.Add(txtIdNhomRoi);
		panel2.Controls.Add(B5330B83);
		panel2.Controls.Add(label13);
		panel2.Location = new System.Drawing.Point(20, 241);
		panel2.Name = "panel2";
		panel2.Size = new System.Drawing.Size(269, 160);
		panel2.TabIndex = 52;
		txtIdNhomRoi.Location = new System.Drawing.Point(6, 22);
		txtIdNhomRoi.Name = "txtIdNhomRoi";
		txtIdNhomRoi.Size = new System.Drawing.Size(258, 114);
		txtIdNhomRoi.TabIndex = 1;
		txtIdNhomRoi.Text = "";
		txtIdNhomRoi.WordWrap = false;
		txtIdNhomRoi.TextChanged += new System.EventHandler(txtIdNhomRoi_TextChanged);
		B5330B83.AutoSize = true;
		B5330B83.Location = new System.Drawing.Point(3, 3);
		B5330B83.Name = "lblIdNhomRoi";
		B5330B83.Size = new System.Drawing.Size(144, 16);
		B5330B83.TabIndex = 0;
		B5330B83.Text = "Danh sách ID nhóm (0):";
		label13.AutoSize = true;
		label13.Location = new System.Drawing.Point(3, 138);
		label13.Name = "label13";
		label13.Size = new System.Drawing.Size(132, 16);
		label13.TabIndex = 0;
		label13.Text = "(Mỗi ID nhóm 1 dòng)";
		AE35653F.AutoSize = true;
		AE35653F.Cursor = System.Windows.Forms.Cursors.Hand;
		AE35653F.Location = new System.Drawing.Point(6, 218);
		AE35653F.Name = "ckbDieuKienID";
		AE35653F.Size = new System.Drawing.Size(125, 20);
		AE35653F.TabIndex = 51;
		AE35653F.Text = "Rời theo ID nhóm";
		AE35653F.UseVisualStyleBackColor = true;
		AE35653F.CheckedChanged += new System.EventHandler(CEA00706);
		plDieuKienTuKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plDieuKienTuKhoa.Controls.Add(txtTuKhoa);
		plDieuKienTuKhoa.Controls.Add(BAA53F00);
		plDieuKienTuKhoa.Controls.Add(label10);
		plDieuKienTuKhoa.Location = new System.Drawing.Point(24, 55);
		plDieuKienTuKhoa.Name = "plDieuKienTuKhoa";
		plDieuKienTuKhoa.Size = new System.Drawing.Size(265, 160);
		plDieuKienTuKhoa.TabIndex = 50;
		txtTuKhoa.Location = new System.Drawing.Point(6, 22);
		txtTuKhoa.Name = "txtTuKhoa";
		txtTuKhoa.Size = new System.Drawing.Size(254, 114);
		txtTuKhoa.TabIndex = 1;
		txtTuKhoa.Text = "";
		txtTuKhoa.WordWrap = false;
		txtTuKhoa.TextChanged += new System.EventHandler(B3AEFE33);
		BAA53F00.AutoSize = true;
		BAA53F00.Location = new System.Drawing.Point(3, 3);
		BAA53F00.Name = "lblTuKhoa";
		BAA53F00.Size = new System.Drawing.Size(139, 16);
		BAA53F00.TabIndex = 0;
		BAA53F00.Text = "Danh sách tư\u0300 kho\u0301a (0):";
		label10.AutoSize = true;
		label10.Location = new System.Drawing.Point(4, 139);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(127, 16);
		label10.TabIndex = 0;
		label10.Text = "(Mỗi tư\u0300 kho\u0301a 1 dòng)";
		ckbDieuKienTuKhoa.AutoSize = true;
		ckbDieuKienTuKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbDieuKienTuKhoa.Location = new System.Drawing.Point(6, 29);
		ckbDieuKienTuKhoa.Name = "ckbDieuKienTuKhoa";
		ckbDieuKienTuKhoa.Size = new System.Drawing.Size(209, 20);
		ckbDieuKienTuKhoa.TabIndex = 2;
		ckbDieuKienTuKhoa.Text = "Tên nho\u0301m co\u0301 chư\u0301a tư\u0300 kho\u0301a sau:";
		ckbDieuKienTuKhoa.UseVisualStyleBackColor = true;
		ckbDieuKienTuKhoa.CheckedChanged += new System.EventHandler(ckbDieuKienTuKhoa_CheckedChanged);
		ckbDieuKienThanhVien.AutoSize = true;
		ckbDieuKienThanhVien.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbDieuKienThanhVien.Location = new System.Drawing.Point(6, 3);
		ckbDieuKienThanhVien.Name = "ckbDieuKienThanhVien";
		ckbDieuKienThanhVien.Size = new System.Drawing.Size(181, 20);
		ckbDieuKienThanhVien.TabIndex = 2;
		ckbDieuKienThanhVien.Text = "Sô\u0301 lươ\u0323ng tha\u0300nh viên i\u0301t hơn:";
		ckbDieuKienThanhVien.UseVisualStyleBackColor = true;
		ckbDieuKienThanhVien.CheckedChanged += new System.EventHandler(ckbDieuKienThanhVien_CheckedChanged);
		DB162806.Location = new System.Drawing.Point(197, 2);
		DB162806.Maximum = new decimal(new int[4] { 999999999, 0, 0, 0 });
		DB162806.Name = "nudThanhVienToiDa";
		DB162806.Size = new System.Drawing.Size(92, 23);
		DB162806.TabIndex = 1;
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(351, 82);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(64, 16);
		label9.TabIndex = 47;
		label9.Text = "Tùy chọn:";
		nudDelayTo.Location = new System.Drawing.Point(229, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		C70E0630.Location = new System.Drawing.Point(132, 107);
		C70E0630.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C70E0630.Name = "nudDelayFrom";
		C70E0630.Size = new System.Drawing.Size(56, 23);
		C70E0630.TabIndex = 3;
		FB38F292.Location = new System.Drawing.Point(194, 109);
		FB38F292.Name = "label7";
		FB38F292.Size = new System.Drawing.Size(29, 16);
		FB38F292.TabIndex = 46;
		FB38F292.Text = "đê\u0301n";
		FB38F292.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(287, 109);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		C3361713.AutoSize = true;
		C3361713.Location = new System.Drawing.Point(27, 109);
		C3361713.Name = "label5";
		C3361713.Size = new System.Drawing.Size(89, 16);
		C3361713.TabIndex = 44;
		C3361713.Text = "Thơ\u0300i gian chơ\u0300:";
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
		A8A94083.Location = new System.Drawing.Point(132, 49);
		A8A94083.Name = "txtTenHanhDong";
		A8A94083.Size = new System.Drawing.Size(194, 23);
		A8A94083.TabIndex = 0;
		label3.Location = new System.Drawing.Point(194, 80);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(287, 80);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(39, 16);
		label4.TabIndex = 35;
		label4.Text = "nho\u0301m";
		BEBAED9F.AutoSize = true;
		BEBAED9F.Location = new System.Drawing.Point(27, 80);
		BEBAED9F.Name = "label2";
		BEBAED9F.Size = new System.Drawing.Size(99, 16);
		BEBAED9F.TabIndex = 32;
		BEBAED9F.Text = "Sô\u0301 lươ\u0323ng nhóm:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		D929D2B4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		D929D2B4.BackColor = System.Drawing.Color.Maroon;
		D929D2B4.Cursor = System.Windows.Forms.Cursors.Hand;
		D929D2B4.FlatAppearance.BorderSize = 0;
		D929D2B4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D929D2B4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D929D2B4.ForeColor = System.Drawing.Color.White;
		D929D2B4.Location = new System.Drawing.Point(347, 533);
		D929D2B4.Name = "btnCancel";
		D929D2B4.Size = new System.Drawing.Size(92, 29);
		D929D2B4.TabIndex = 7;
		D929D2B4.Text = "Đóng";
		D929D2B4.UseVisualStyleBackColor = false;
		D929D2B4.Click += new System.EventHandler(D929D2B4_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(242, 533);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		DC9BEF15.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DC9BEF15.BackColor = System.Drawing.Color.White;
		DC9BEF15.BorderRadius = 0;
		DC9BEF15.BottomSahddow = true;
		DC9BEF15.color = System.Drawing.Color.DarkViolet;
		DC9BEF15.Controls.Add(BF1FE213);
		DC9BEF15.LeftSahddow = false;
		DC9BEF15.Location = new System.Drawing.Point(1, 0);
		DC9BEF15.Name = "bunifuCards1";
		DC9BEF15.RightSahddow = true;
		DC9BEF15.ShadowDepth = 20;
		DC9BEF15.Size = new System.Drawing.Size(676, 37);
		DC9BEF15.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(679, 575);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDRoiNhom";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDRoiNhom_Load);
		BF1FE213.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		C127222B.ResumeLayout(false);
		C127222B.PerformLayout();
		panel2.ResumeLayout(false);
		panel2.PerformLayout();
		plDieuKienTuKhoa.ResumeLayout(false);
		plDieuKienTuKhoa.PerformLayout();
		((System.ComponentModel.ISupportInitialize)DB162806).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)C70E0630).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		DC9BEF15.ResumeLayout(false);
		ResumeLayout(false);
	}
}
