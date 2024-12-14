using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDDangReel : Form
{
	private ucTuongTacReel A58777A5;

	private GClass11 CA965D27;

	private string string_0;

	private string string_1;

	private string string_2;

	private int FB0E9922;

	public static bool C721C088;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel A0A8B913;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards F8308227;

	private Panel ED314422;

	private Button button1;

	private PictureBox E387B41D;

	private BunifuCustomLabel F028E98B;

	private CheckBox BC300DAF;

	private Panel plVanBan;

	private Label label8;

	private Label lblNoiDung;

	private RichTextBox txtNoiDung;

	private Label C486BA0E;

	private NumericUpDown C5B91D2C;

	private NumericUpDown nudKhoangCachFrom;

	private Label B52D5CBD;

	private NumericUpDown F996B39B;

	private NumericUpDown ACB05C27;

	private Label D4A10B80;

	private Label label15;

	private CheckBox F8A58CA8;

	private LinkLabel linkLabel1;

	private TextBox txtPathAnh;

	private Label label3;

	private NumericUpDown C314B02D;

	private Label AFBC4312;

	private Label label4;

	private CheckBox ckbHashtag;

	private Panel CC8D61B2;

	private RichTextBox EE2E0A0F;

	private Label A98D26B3;

	private Label label6;

	private NumericUpDown nudSoHashtagFrom;

	private NumericUpDown AF25239F;

	private Label label7;

	private CheckBox CA3C0D10;

	private LinkLabel lblCaiDatTuongTacReel;

	private CheckBox ckbXuatLinkReel;

	private TextBox txtKhoNoiDung;

	private CheckBox ckbKhoNoiDung;

	private TextBox DABA7A28;

	private CheckBox D62E9915;

	private Button button2;

	private Label label9;

	private ComboBox cbbTuyChonNoiDung;

	public fHDDangReel(string F6804599, int int_0 = 0, string A3913D29 = "")
	{
		InitializeComponent();
		C721C088 = false;
		string_0 = F6804599;
		string_2 = A3913D29;
		FB0E9922 = int_0;
		string text = base.Name.Substring(1);
		string text2 = "Đăng Reel";
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
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(A3913D29);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		CA965D27 = new GClass11(text3, bool_0: true);
		A58777A5 = new ucTuongTacReel(CA965D27)
		{
			Visible = false
		};
		base.Controls.Add(A58777A5);
		A58777A5.smethod_0(bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void fHDDangReel_Load(object sender, EventArgs e)
	{
		method_0();
		try
		{
			ACB05C27.Value = CA965D27.method_2("nudSoLuongFrom", 1);
			F996B39B.Value = CA965D27.method_2("nudSoLuongTo", 1);
			nudKhoangCachFrom.Value = CA965D27.method_2("nudKhoangCachFrom", 5);
			C5B91D2C.Value = CA965D27.method_2("nudKhoangCachTo", 10);
			BC300DAF.Checked = CA965D27.method_3("ckbVanBan");
			F8A58CA8.Checked = CA965D27.method_3("ckbXoaNguyenLieuDaDung");
			txtNoiDung.Text = CA965D27.C0288288("txtNoiDung");
			cbbTuyChonNoiDung.SelectedIndex = CA965D27.method_2("typeNganCach");
			ckbHashtag.Checked = CA965D27.method_3("ckbHashtag");
			EE2E0A0F.Text = CA965D27.C0288288("txtHashtag");
			nudSoHashtagFrom.Value = CA965D27.method_2("nudSoHashtagFrom", 1);
			AF25239F.Value = CA965D27.method_2("nudSoHashtagTo", 1);
			txtPathAnh.Text = CA965D27.C0288288("txtPathAnh");
			CA3C0D10.Checked = CA965D27.method_3("ckbXoaVideoDaDang");
			C314B02D.Value = CA965D27.method_2("nudTimeOutLoadVideo", 300);
			ckbXuatLinkReel.Checked = CA965D27.method_3("ckbXuatLinkReel");
			ckbKhoNoiDung.Checked = CA965D27.method_3("ckbKhoNoiDung");
			txtKhoNoiDung.Text = CA965D27.C0288288("txtKhoNoiDung");
			D62E9915.Checked = CA965D27.method_3("ckbThuMucMedia");
			DABA7A28.Text = CA965D27.C0288288("txtThuMucMedia");
		}
		catch (Exception)
		{
		}
		D21CDD05();
	}

	private void method_0()
	{
		List<string> list_ = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		GClass8.smethod_22(cbbTuyChonNoiDung, list_);
	}

	private void CA9F592A(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0(F7AB102E.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		CA965D27.method_4("nudSoLuongFrom", ACB05C27.Value);
		CA965D27.method_4("nudSoLuongTo", F996B39B.Value);
		CA965D27.method_4("nudKhoangCachFrom", nudKhoangCachFrom.Value);
		CA965D27.method_4("nudKhoangCachTo", C5B91D2C.Value);
		CA965D27.method_4("ckbVanBan", BC300DAF.Checked);
		CA965D27.method_4("ckbXoaNguyenLieuDaDung", F8A58CA8.Checked);
		CA965D27.method_4("txtNoiDung", txtNoiDung.Text.Trim());
		CA965D27.method_4("typeNganCach", cbbTuyChonNoiDung.SelectedIndex);
		CA965D27.method_4("ckbHashtag", ckbHashtag.Checked);
		CA965D27.method_4("txtHashtag", EE2E0A0F.Text.Trim());
		CA965D27.method_4("nudSoHashtagFrom", nudSoHashtagFrom.Value);
		CA965D27.method_4("nudSoHashtagTo", AF25239F.Value);
		CA965D27.method_4("txtPathAnh", txtPathAnh.Text.Trim());
		CA965D27.method_4("ckbXoaVideoDaDang", CA3C0D10.Checked);
		CA965D27.method_4("nudTimeOutLoadVideo", C314B02D.Value);
		CA965D27.method_4("ckbXuatLinkReel", ckbXuatLinkReel.Checked);
		CA965D27.method_4("ckbThuMucMedia", D62E9915.Checked);
		CA965D27.method_4("txtThuMucMedia", DABA7A28.Text);
		CA965D27.method_4("ckbKhoNoiDung", ckbKhoNoiDung.Checked);
		CA965D27.method_4("txtKhoNoiDung", txtKhoNoiDung.Text);
		string text2 = CA965D27.method_7();
		if (FB0E9922 == 0)
		{
			if (GClass29.smethod_1(F7AB102E.smethod_0("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, text2))
				{
					C721C088 = true;
					Close();
				}
				else
				{
					GClass29.smethod_0(F7AB102E.smethod_0("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
				}
			}
		}
		else if (GClass29.smethod_1(F7AB102E.smethod_0("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?")) == DialogResult.Yes)
		{
			if (Class147.smethod_13(string_2, text, text2))
			{
				C721C088 = true;
				Close();
			}
			else
			{
				GClass29.smethod_0(F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E4B74687(object sender, PaintEventArgs e)
	{
		if (A0A8B913.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, A0A8B913.ClientSize.Width - num, A0A8B913.ClientSize.Height - num));
		}
	}

	private void D21CDD05()
	{
		D7BE5019(null, null);
		A49E353B(null, null);
		ckbHashtag_CheckedChanged(null, null);
		ckbXuatLinkReel_CheckedChanged(null, null);
		DD009B91(null, null);
		D62E9915_CheckedChanged(null, null);
	}

	private void D7BE5019(object sender, EventArgs e)
	{
		plVanBan.Enabled = BC300DAF.Checked;
	}

	private void txtNoiDung_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtNoiDung, lblNoiDung, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void DBAA7917(object sender, EventArgs e)
	{
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.smethod_33(new E3962B82());
	}

	private void button2_Click(object sender, EventArgs e)
	{
		if (cbbTuyChonNoiDung.SelectedIndex == 0)
		{
			GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			GClass8.smethod_33(new fHelpNhapComment());
		}
		txtNoiDung.Focus();
	}

	private void A49E353B(object sender, EventArgs e)
	{
	}

	private void EE2E0A0F_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(EE2E0A0F, A98D26B3);
	}

	private void ckbHashtag_CheckedChanged(object sender, EventArgs e)
	{
		CC8D61B2.Enabled = ckbHashtag.Checked;
	}

	private void lblCaiDatTuongTacReel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = GClass28.smethod_0() + "\\output\\LinkReel.txt";
		if (!File.Exists(text))
		{
			GClass8.smethod_31(text);
		}
		Process.Start(text);
	}

	private void ckbXuatLinkReel_CheckedChanged(object sender, EventArgs e)
	{
		lblCaiDatTuongTacReel.Enabled = ckbXuatLinkReel.Checked;
	}

	private void DD009B91(object sender, EventArgs e)
	{
		txtKhoNoiDung.Enabled = ckbKhoNoiDung.Checked;
	}

	private void D62E9915_CheckedChanged(object sender, EventArgs e)
	{
		DABA7A28.Enabled = D62E9915.Checked;
	}

	private void cbbTuyChonNoiDung_SelectedIndexChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtNoiDung, lblNoiDung, cbbTuyChonNoiDung.SelectedIndex);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDDangReel));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		F028E98B = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		ED314422 = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		E387B41D = new System.Windows.Forms.PictureBox();
		A0A8B913 = new System.Windows.Forms.Panel();
		DABA7A28 = new System.Windows.Forms.TextBox();
		txtKhoNoiDung = new System.Windows.Forms.TextBox();
		txtPathAnh = new System.Windows.Forms.TextBox();
		C486BA0E = new System.Windows.Forms.Label();
		C5B91D2C = new System.Windows.Forms.NumericUpDown();
		label3 = new System.Windows.Forms.Label();
		nudKhoangCachFrom = new System.Windows.Forms.NumericUpDown();
		CA3C0D10 = new System.Windows.Forms.CheckBox();
		B52D5CBD = new System.Windows.Forms.Label();
		F996B39B = new System.Windows.Forms.NumericUpDown();
		C314B02D = new System.Windows.Forms.NumericUpDown();
		ACB05C27 = new System.Windows.Forms.NumericUpDown();
		AFBC4312 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		D4A10B80 = new System.Windows.Forms.Label();
		label15 = new System.Windows.Forms.Label();
		plVanBan = new System.Windows.Forms.Panel();
		cbbTuyChonNoiDung = new System.Windows.Forms.ComboBox();
		linkLabel1 = new System.Windows.Forms.LinkLabel();
		button2 = new System.Windows.Forms.Button();
		label9 = new System.Windows.Forms.Label();
		txtNoiDung = new System.Windows.Forms.RichTextBox();
		label8 = new System.Windows.Forms.Label();
		lblNoiDung = new System.Windows.Forms.Label();
		F8A58CA8 = new System.Windows.Forms.CheckBox();
		ckbHashtag = new System.Windows.Forms.CheckBox();
		CC8D61B2 = new System.Windows.Forms.Panel();
		nudSoHashtagFrom = new System.Windows.Forms.NumericUpDown();
		AF25239F = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		EE2E0A0F = new System.Windows.Forms.RichTextBox();
		A98D26B3 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		D62E9915 = new System.Windows.Forms.CheckBox();
		btnAdd = new System.Windows.Forms.Button();
		ckbKhoNoiDung = new System.Windows.Forms.CheckBox();
		BC300DAF = new System.Windows.Forms.CheckBox();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		F8308227 = new Bunifu.Framework.UI.BunifuCards();
		lblCaiDatTuongTacReel = new System.Windows.Forms.LinkLabel();
		ckbXuatLinkReel = new System.Windows.Forms.CheckBox();
		ED314422.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)E387B41D).BeginInit();
		A0A8B913.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C5B91D2C).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudKhoangCachFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)F996B39B).BeginInit();
		((System.ComponentModel.ISupportInitialize)C314B02D).BeginInit();
		((System.ComponentModel.ISupportInitialize)ACB05C27).BeginInit();
		plVanBan.SuspendLayout();
		CC8D61B2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoHashtagFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)AF25239F).BeginInit();
		F8308227.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = F028E98B;
		bunifuDragControl_0.Vertical = true;
		F028E98B.BackColor = System.Drawing.Color.Transparent;
		F028E98B.Cursor = System.Windows.Forms.Cursors.SizeAll;
		F028E98B.Dock = System.Windows.Forms.DockStyle.Fill;
		F028E98B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F028E98B.ForeColor = System.Drawing.Color.Black;
		F028E98B.Location = new System.Drawing.Point(0, 0);
		F028E98B.Name = "bunifuCustomLabel1";
		F028E98B.Size = new System.Drawing.Size(593, 31);
		F028E98B.TabIndex = 12;
		F028E98B.Text = "Cấu hình Đăng Reel";
		F028E98B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = ED314422;
		bunifuDragControl_1.Vertical = true;
		ED314422.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		ED314422.BackColor = System.Drawing.Color.White;
		ED314422.Controls.Add(button1);
		ED314422.Controls.Add(E387B41D);
		ED314422.Controls.Add(F028E98B);
		ED314422.Cursor = System.Windows.Forms.Cursors.SizeAll;
		ED314422.Location = new System.Drawing.Point(0, 3);
		ED314422.Name = "pnlHeader";
		ED314422.Size = new System.Drawing.Size(593, 31);
		ED314422.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(562, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 0;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(CA9F592A);
		E387B41D.Cursor = System.Windows.Forms.Cursors.Default;
		E387B41D.Image = C50FB39E.Bitmap_5;
		E387B41D.Location = new System.Drawing.Point(3, 2);
		E387B41D.Name = "pictureBox1";
		E387B41D.Size = new System.Drawing.Size(34, 27);
		E387B41D.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		E387B41D.TabIndex = 76;
		E387B41D.TabStop = false;
		E387B41D.Click += new System.EventHandler(DBAA7917);
		A0A8B913.BackColor = System.Drawing.Color.White;
		A0A8B913.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		A0A8B913.Controls.Add(DABA7A28);
		A0A8B913.Controls.Add(txtKhoNoiDung);
		A0A8B913.Controls.Add(txtPathAnh);
		A0A8B913.Controls.Add(C486BA0E);
		A0A8B913.Controls.Add(C5B91D2C);
		A0A8B913.Controls.Add(label3);
		A0A8B913.Controls.Add(nudKhoangCachFrom);
		A0A8B913.Controls.Add(CA3C0D10);
		A0A8B913.Controls.Add(B52D5CBD);
		A0A8B913.Controls.Add(F996B39B);
		A0A8B913.Controls.Add(C314B02D);
		A0A8B913.Controls.Add(ACB05C27);
		A0A8B913.Controls.Add(AFBC4312);
		A0A8B913.Controls.Add(label4);
		A0A8B913.Controls.Add(D4A10B80);
		A0A8B913.Controls.Add(label15);
		A0A8B913.Controls.Add(plVanBan);
		A0A8B913.Controls.Add(D62E9915);
		A0A8B913.Controls.Add(btnAdd);
		A0A8B913.Controls.Add(ckbKhoNoiDung);
		A0A8B913.Controls.Add(BC300DAF);
		A0A8B913.Controls.Add(txtTenHanhDong);
		A0A8B913.Controls.Add(label1);
		A0A8B913.Controls.Add(btnCancel);
		A0A8B913.Controls.Add(F8308227);
		A0A8B913.Controls.Add(lblCaiDatTuongTacReel);
		A0A8B913.Controls.Add(ckbXuatLinkReel);
		A0A8B913.Cursor = System.Windows.Forms.Cursors.Arrow;
		A0A8B913.Dock = System.Windows.Forms.DockStyle.Fill;
		A0A8B913.Location = new System.Drawing.Point(0, 0);
		A0A8B913.Name = "panel1";
		A0A8B913.Size = new System.Drawing.Size(596, 701);
		A0A8B913.TabIndex = 0;
		A0A8B913.Paint += new System.Windows.Forms.PaintEventHandler(E4B74687);
		DABA7A28.Location = new System.Drawing.Point(168, 772);
		DABA7A28.Name = "txtThuMucMedia";
		DABA7A28.Size = new System.Drawing.Size(393, 23);
		DABA7A28.TabIndex = 1;
		txtKhoNoiDung.Location = new System.Drawing.Point(168, 801);
		txtKhoNoiDung.Name = "txtKhoNoiDung";
		txtKhoNoiDung.Size = new System.Drawing.Size(393, 23);
		txtKhoNoiDung.TabIndex = 1;
		txtPathAnh.Location = new System.Drawing.Point(168, 136);
		txtPathAnh.Name = "txtPathAnh";
		txtPathAnh.Size = new System.Drawing.Size(260, 23);
		txtPathAnh.TabIndex = 1;
		C486BA0E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C486BA0E.Location = new System.Drawing.Point(222, 109);
		C486BA0E.Name = "label20";
		C486BA0E.Size = new System.Drawing.Size(29, 16);
		C486BA0E.TabIndex = 42;
		C486BA0E.Text = ">";
		C486BA0E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C5B91D2C.Location = new System.Drawing.Point(253, 107);
		C5B91D2C.Name = "nudKhoangCachTo";
		C5B91D2C.Size = new System.Drawing.Size(51, 23);
		C5B91D2C.TabIndex = 41;
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(30, 139);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(97, 16);
		label3.TabIndex = 0;
		label3.Text = "Thư mu\u0323c video:";
		nudKhoangCachFrom.Location = new System.Drawing.Point(168, 107);
		nudKhoangCachFrom.Name = "nudKhoangCachFrom";
		nudKhoangCachFrom.Size = new System.Drawing.Size(51, 23);
		nudKhoangCachFrom.TabIndex = 40;
		CA3C0D10.AutoSize = true;
		CA3C0D10.Cursor = System.Windows.Forms.Cursors.Hand;
		CA3C0D10.Location = new System.Drawing.Point(436, 138);
		CA3C0D10.Name = "ckbXoaVideoDaDang";
		CA3C0D10.Size = new System.Drawing.Size(132, 20);
		CA3C0D10.TabIndex = 32;
		CA3C0D10.Text = "Xóa video đã đăng";
		CA3C0D10.UseVisualStyleBackColor = true;
		CA3C0D10.CheckedChanged += new System.EventHandler(D7BE5019);
		B52D5CBD.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B52D5CBD.Location = new System.Drawing.Point(222, 83);
		B52D5CBD.Name = "label17";
		B52D5CBD.Size = new System.Drawing.Size(29, 16);
		B52D5CBD.TabIndex = 38;
		B52D5CBD.Text = ">";
		B52D5CBD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F996B39B.Location = new System.Drawing.Point(253, 78);
		F996B39B.Name = "nudSoLuongTo";
		F996B39B.Size = new System.Drawing.Size(51, 23);
		F996B39B.TabIndex = 37;
		C314B02D.Location = new System.Drawing.Point(168, 625);
		C314B02D.Maximum = new decimal(new int[4] { 9999, 0, 0, 0 });
		C314B02D.Name = "nudTimeOutLoadVideo";
		C314B02D.Size = new System.Drawing.Size(51, 23);
		C314B02D.TabIndex = 36;
		ACB05C27.Location = new System.Drawing.Point(168, 78);
		ACB05C27.Name = "nudSoLuongFrom";
		ACB05C27.Size = new System.Drawing.Size(51, 23);
		ACB05C27.TabIndex = 36;
		AFBC4312.AutoSize = true;
		AFBC4312.Location = new System.Drawing.Point(225, 627);
		AFBC4312.Name = "label5";
		AFBC4312.Size = new System.Drawing.Size(30, 16);
		AFBC4312.TabIndex = 34;
		AFBC4312.Text = "giây";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(30, 627);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(132, 16);
		label4.TabIndex = 34;
		label4.Text = "Chờ load video tối đa:";
		D4A10B80.AutoSize = true;
		D4A10B80.Location = new System.Drawing.Point(30, 109);
		D4A10B80.Name = "label16";
		D4A10B80.Size = new System.Drawing.Size(136, 16);
		D4A10B80.TabIndex = 35;
		D4A10B80.Text = "Khoảng cách đăng (s):";
		label15.AutoSize = true;
		label15.Location = new System.Drawing.Point(30, 80);
		label15.Name = "label15";
		label15.Size = new System.Drawing.Size(89, 16);
		label15.TabIndex = 34;
		label15.Text = "Số lượng reel:";
		plVanBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plVanBan.Controls.Add(cbbTuyChonNoiDung);
		plVanBan.Controls.Add(linkLabel1);
		plVanBan.Controls.Add(button2);
		plVanBan.Controls.Add(label9);
		plVanBan.Controls.Add(txtNoiDung);
		plVanBan.Controls.Add(label8);
		plVanBan.Controls.Add(lblNoiDung);
		plVanBan.Controls.Add(F8A58CA8);
		plVanBan.Controls.Add(ckbHashtag);
		plVanBan.Controls.Add(CC8D61B2);
		plVanBan.Location = new System.Drawing.Point(47, 186);
		plVanBan.Name = "plVanBan";
		plVanBan.Size = new System.Drawing.Size(514, 434);
		plVanBan.TabIndex = 33;
		cbbTuyChonNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTuyChonNoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTuyChonNoiDung.DropDownWidth = 180;
		cbbTuyChonNoiDung.FormattingEnabled = true;
		cbbTuyChonNoiDung.Location = new System.Drawing.Point(325, 197);
		cbbTuyChonNoiDung.Name = "cbbTuyChonNoiDung";
		cbbTuyChonNoiDung.Size = new System.Drawing.Size(154, 24);
		cbbTuyChonNoiDung.TabIndex = 196;
		cbbTuyChonNoiDung.SelectedIndexChanged += new System.EventHandler(cbbTuyChonNoiDung_SelectedIndexChanged);
		linkLabel1.AutoSize = true;
		linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		linkLabel1.Location = new System.Drawing.Point(154, 197);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new System.Drawing.Size(81, 16);
		linkLabel1.TabIndex = 195;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "Random icon";
		linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		button2.Cursor = System.Windows.Forms.Cursors.Help;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(485, 197);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(21, 24);
		button2.TabIndex = 194;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(261, 200);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(64, 16);
		label9.TabIndex = 35;
		label9.Text = "Tùy chọn:";
		txtNoiDung.Location = new System.Drawing.Point(7, 23);
		txtNoiDung.Name = "txtNoiDung";
		txtNoiDung.Size = new System.Drawing.Size(499, 172);
		txtNoiDung.TabIndex = 34;
		txtNoiDung.Text = "";
		txtNoiDung.WordWrap = false;
		txtNoiDung.TextChanged += new System.EventHandler(txtNoiDung_TextChanged);
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(4, 197);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(143, 16);
		label8.TabIndex = 0;
		label8.Text = "(Spin nội dung {a|b|c})";
		lblNoiDung.AutoSize = true;
		lblNoiDung.Location = new System.Drawing.Point(3, 4);
		lblNoiDung.Name = "lblNoiDung";
		lblNoiDung.Size = new System.Drawing.Size(145, 16);
		lblNoiDung.TabIndex = 0;
		lblNoiDung.Text = "Danh sa\u0301ch nô\u0323i dung (0):";
		F8A58CA8.AutoSize = true;
		F8A58CA8.Cursor = System.Windows.Forms.Cursors.Hand;
		F8A58CA8.Location = new System.Drawing.Point(7, 220);
		F8A58CA8.Name = "ckbXoaNguyenLieuDaDung";
		F8A58CA8.Size = new System.Drawing.Size(151, 20);
		F8A58CA8.TabIndex = 32;
		F8A58CA8.Text = "Xóa nội dung đã đăng";
		F8A58CA8.UseVisualStyleBackColor = true;
		F8A58CA8.CheckedChanged += new System.EventHandler(D7BE5019);
		ckbHashtag.AutoSize = true;
		ckbHashtag.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHashtag.Location = new System.Drawing.Point(7, 246);
		ckbHashtag.Name = "ckbHashtag";
		ckbHashtag.Size = new System.Drawing.Size(101, 20);
		ckbHashtag.TabIndex = 32;
		ckbHashtag.Text = "Kèm Hashtag";
		ckbHashtag.UseVisualStyleBackColor = true;
		ckbHashtag.CheckedChanged += new System.EventHandler(ckbHashtag_CheckedChanged);
		CC8D61B2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		CC8D61B2.Controls.Add(nudSoHashtagFrom);
		CC8D61B2.Controls.Add(AF25239F);
		CC8D61B2.Controls.Add(label7);
		CC8D61B2.Controls.Add(EE2E0A0F);
		CC8D61B2.Controls.Add(A98D26B3);
		CC8D61B2.Controls.Add(label6);
		CC8D61B2.Location = new System.Drawing.Point(19, 271);
		CC8D61B2.Name = "plHashtag";
		CC8D61B2.Size = new System.Drawing.Size(487, 156);
		CC8D61B2.TabIndex = 33;
		nudSoHashtagFrom.Location = new System.Drawing.Point(170, 127);
		nudSoHashtagFrom.Name = "nudSoHashtagFrom";
		nudSoHashtagFrom.Size = new System.Drawing.Size(51, 23);
		nudSoHashtagFrom.TabIndex = 40;
		AF25239F.Location = new System.Drawing.Point(255, 127);
		AF25239F.Name = "nudSoHashtagTo";
		AF25239F.Size = new System.Drawing.Size(51, 23);
		AF25239F.TabIndex = 41;
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label7.Location = new System.Drawing.Point(224, 129);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 42;
		label7.Text = ">";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		EE2E0A0F.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		EE2E0A0F.Location = new System.Drawing.Point(7, 22);
		EE2E0A0F.Name = "txtHashtag";
		EE2E0A0F.Size = new System.Drawing.Size(472, 102);
		EE2E0A0F.TabIndex = 34;
		EE2E0A0F.Text = "";
		EE2E0A0F.WordWrap = false;
		EE2E0A0F.TextChanged += new System.EventHandler(EE2E0A0F_TextChanged);
		A98D26B3.AutoSize = true;
		A98D26B3.Location = new System.Drawing.Point(3, 3);
		A98D26B3.Name = "lblHashtag";
		A98D26B3.Size = new System.Drawing.Size(141, 16);
		A98D26B3.TabIndex = 0;
		A98D26B3.Text = "Danh sa\u0301ch hashtag (0):";
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(4, 129);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(166, 16);
		label6.TabIndex = 35;
		label6.Text = "Số lượng hashtag/nội dung:";
		D62E9915.AutoSize = true;
		D62E9915.Cursor = System.Windows.Forms.Cursors.Hand;
		D62E9915.Location = new System.Drawing.Point(33, 774);
		D62E9915.Name = "ckbThuMucMedia";
		D62E9915.Size = new System.Drawing.Size(121, 20);
		D62E9915.TabIndex = 32;
		D62E9915.Text = "Thư mục media:";
		D62E9915.UseVisualStyleBackColor = true;
		D62E9915.CheckedChanged += new System.EventHandler(D62E9915_CheckedChanged);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(205, 659);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		ckbKhoNoiDung.AutoSize = true;
		ckbKhoNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbKhoNoiDung.Location = new System.Drawing.Point(33, 803);
		ckbKhoNoiDung.Name = "ckbKhoNoiDung";
		ckbKhoNoiDung.Size = new System.Drawing.Size(140, 20);
		ckbKhoNoiDung.TabIndex = 32;
		ckbKhoNoiDung.Text = "Kho video/nội dung:";
		ckbKhoNoiDung.UseVisualStyleBackColor = true;
		ckbKhoNoiDung.CheckedChanged += new System.EventHandler(DD009B91);
		BC300DAF.AutoSize = true;
		BC300DAF.Cursor = System.Windows.Forms.Cursors.Hand;
		BC300DAF.Location = new System.Drawing.Point(33, 164);
		BC300DAF.Name = "ckbVanBan";
		BC300DAF.Size = new System.Drawing.Size(113, 20);
		BC300DAF.TabIndex = 32;
		BC300DAF.Text = "Nội dung mô tả";
		BC300DAF.UseVisualStyleBackColor = true;
		BC300DAF.CheckedChanged += new System.EventHandler(D7BE5019);
		txtTenHanhDong.Location = new System.Drawing.Point(168, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(174, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(30, 52);
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
		btnCancel.Location = new System.Drawing.Point(304, 659);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		F8308227.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		F8308227.BackColor = System.Drawing.Color.White;
		F8308227.BorderRadius = 0;
		F8308227.BottomSahddow = true;
		F8308227.color = System.Drawing.Color.DarkViolet;
		F8308227.Controls.Add(ED314422);
		F8308227.LeftSahddow = false;
		F8308227.Location = new System.Drawing.Point(1, 0);
		F8308227.Name = "bunifuCards1";
		F8308227.RightSahddow = true;
		F8308227.ShadowDepth = 20;
		F8308227.Size = new System.Drawing.Size(593, 37);
		F8308227.TabIndex = 28;
		lblCaiDatTuongTacReel.AutoSize = true;
		lblCaiDatTuongTacReel.Cursor = System.Windows.Forms.Cursors.Hand;
		lblCaiDatTuongTacReel.Location = new System.Drawing.Point(492, 627);
		lblCaiDatTuongTacReel.Name = "lblCaiDatTuongTacReel";
		lblCaiDatTuongTacReel.Size = new System.Drawing.Size(73, 16);
		lblCaiDatTuongTacReel.TabIndex = 184;
		lblCaiDatTuongTacReel.TabStop = true;
		lblCaiDatTuongTacReel.Text = "File kê\u0301t qua\u0309";
		lblCaiDatTuongTacReel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(lblCaiDatTuongTacReel_LinkClicked);
		ckbXuatLinkReel.AutoSize = true;
		ckbXuatLinkReel.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbXuatLinkReel.Location = new System.Drawing.Point(316, 626);
		ckbXuatLinkReel.Name = "ckbXuatLinkReel";
		ckbXuatLinkReel.Size = new System.Drawing.Size(177, 20);
		ckbXuatLinkReel.TabIndex = 32;
		ckbXuatLinkReel.Text = "Xuâ\u0301t link reel sau khi đăng";
		ckbXuatLinkReel.UseVisualStyleBackColor = true;
		ckbXuatLinkReel.CheckedChanged += new System.EventHandler(ckbXuatLinkReel_CheckedChanged);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(596, 701);
		base.Controls.Add(A0A8B913);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDangReel";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDDangReel_Load);
		ED314422.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)E387B41D).EndInit();
		A0A8B913.ResumeLayout(false);
		A0A8B913.PerformLayout();
		((System.ComponentModel.ISupportInitialize)C5B91D2C).EndInit();
		((System.ComponentModel.ISupportInitialize)nudKhoangCachFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)F996B39B).EndInit();
		((System.ComponentModel.ISupportInitialize)C314B02D).EndInit();
		((System.ComponentModel.ISupportInitialize)ACB05C27).EndInit();
		plVanBan.ResumeLayout(false);
		plVanBan.PerformLayout();
		CC8D61B2.ResumeLayout(false);
		CC8D61B2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoHashtagFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)AF25239F).EndInit();
		F8308227.ResumeLayout(false);
		ResumeLayout(false);
	}
}
