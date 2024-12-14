using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDBuffTinNhanProfile : Form
{
	private F31742AD f31742AD_0;

	private GClass11 gclass11_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int FF2332B3;

	public static bool E50B7319;

	private IContainer E1B91D00 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown DD38D5B9;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label label5;

	private Label label1;

	private Button btnCancel;

	private Button B233FB09;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel BE154E3B;

	private Label DDA872BA;

	private CheckBox ckbNhanTinVanBan;

	private Label label49;

	private NumericUpDown C49E3E90;

	private NumericUpDown FD8C1910;

	private Label E4AEDFBB;

	private RichTextBox txtUid;

	private Panel CE2B1B87;

	private CheckBox ckbSendAnh;

	private CheckBox E00A40B6;

	private ToolTip FB31C094;

	private Label label3;

	private Label label9;

	private NumericUpDown B093BE30;

	private NumericUpDown nudSoLuongAnhTo;

	private Label D018FB8B;

	private Panel plTuongTacTruocKhiNhanTin;

	private CheckBox ckbTuongTacKhiNhanTin;

	private Label label10;

	private TextBox txtAnh;

	private RichTextBox txtNoiDung;

	private ComboBox cbbTuyChonNoiDung;

	private Button FBB6F236;

	private ComboBox cbbDoiTuongNhanTin;

	private Label label2;

	private Panel plUid;

	private Label D132A913;

	private ComboBox cbbTuongTac;

	private LinkLabel DC0042A7;

	private CheckBox ckbAutoDeleteComment;

	public fHDBuffTinNhanProfile(string string_3, int int_0 = 0, string string_4 = "")
	{
		InitializeComponent();
		E50B7319 = false;
		string_0 = string_3;
		string_2 = string_4;
		FF2332B3 = int_0;
		string text = base.Name.Substring(1);
		string text2 = "Nhắn tin";
		Class147.smethod_8(text, text2);
		string text3 = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_4);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			B233FB09.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
		f31742AD_0 = new F31742AD(gclass11_0)
		{
			Visible = false
		};
		base.Controls.Add(f31742AD_0);
		f31742AD_0.smethod_0(bool_0: true);
	}

	private void fHDBuffTinNhanProfile_Load(object sender, EventArgs e)
	{
		D2135788();
		B09FE71B();
		method_0();
		try
		{
			C49E3E90.Value = gclass11_0.method_2("nudSoLuongUidFrom", 1);
			FD8C1910.Value = gclass11_0.method_2("nudSoLuongUidTo", 1);
			B093BE30.Value = gclass11_0.method_2("nudSoLuongAnhFrom", 1);
			nudSoLuongAnhTo.Value = gclass11_0.method_2("nudSoLuongAnhTo", 1);
			DD38D5B9.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
			txtUid.Text = gclass11_0.C0288288("txtUid");
			ckbNhanTinVanBan.Checked = gclass11_0.method_3("ckbNhanTinVanBan");
			txtNoiDung.Text = gclass11_0.C0288288("txtNoiDung");
			ckbAutoDeleteComment.Checked = gclass11_0.method_3("ckbAutoDeleteComment");
			ckbSendAnh.Checked = gclass11_0.method_3("ckbSendAnh");
			txtAnh.Text = gclass11_0.C0288288("txtAnh");
			ckbTuongTacKhiNhanTin.Checked = gclass11_0.method_3("ckbTuongTacKhiNhanTin");
			cbbTuongTac.SelectedIndex = gclass11_0.method_2("typeTuongTacKhiNhanTin");
			E00A40B6.Checked = gclass11_0.method_3("ckbTuDongXoaUid");
			cbbTuyChonNoiDung.SelectedIndex = gclass11_0.method_2("typeNganCach");
			cbbDoiTuongNhanTin.SelectedValue = gclass11_0.C0288288("typeDoiTuong", "0");
		}
		catch
		{
		}
		E7308E12();
	}

	private void D2135788()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "UID chỉ định");
		dictionary.Add("1", "Ngẫu nhiên danh sách bạn");
		dictionary.Add("5", "Ngẫu nhiên trong hộp thư");
		dictionary.Add("4", "Tin nhắn Chờ");
		dictionary.Add("3", "Tin nhắn Spam");
		dictionary.Add("2", "Đang trực tuyến");
		GClass8.smethod_23(cbbDoiTuongNhanTin, dictionary);
	}

	private void B09FE71B()
	{
		List<string> list_ = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		GClass8.smethod_22(cbbTuyChonNoiDung, list_);
	}

	private void method_0()
	{
		List<string> list_ = new List<string> { "Tương ta\u0301c trươ\u0301c khi nhă\u0301n tin", "Tương ta\u0301c sau khi nhă\u0301n tin" };
		GClass8.smethod_22(cbbTuongTac, list_);
	}

	private void ECB7EB38(object sender, EventArgs e)
	{
		Close();
	}

	private void B233FB09_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		gclass11_0.method_4("nudSoLuongUidFrom", C49E3E90.Value);
		gclass11_0.method_4("nudSoLuongUidTo", FD8C1910.Value);
		gclass11_0.method_4("nudSoLuongAnhFrom", B093BE30.Value);
		gclass11_0.method_4("nudSoLuongAnhTo", nudSoLuongAnhTo.Value);
		gclass11_0.method_4("nudDelayFrom", DD38D5B9.Value);
		gclass11_0.method_4("nudDelayTo", nudDelayTo.Value);
		gclass11_0.method_4("txtUid", txtUid.Text.Trim());
		gclass11_0.method_4("ckbNhanTinVanBan", ckbNhanTinVanBan.Checked);
		gclass11_0.method_4("txtNoiDung", txtNoiDung.Text.Trim());
		gclass11_0.method_4("ckbAutoDeleteComment", ckbAutoDeleteComment.Checked);
		gclass11_0.method_4("ckbSendAnh", ckbSendAnh.Checked);
		gclass11_0.method_4("txtAnh", txtAnh.Text.Trim());
		gclass11_0.method_4("ckbTuDongXoaUid", E00A40B6.Checked);
		gclass11_0.method_4("ckbTuongTacKhiNhanTin", ckbTuongTacKhiNhanTin.Checked);
		gclass11_0.method_4("typeTuongTacKhiNhanTin", cbbTuongTac.SelectedIndex);
		gclass11_0.method_4("typeNganCach", cbbTuyChonNoiDung.SelectedIndex);
		gclass11_0.method_4("typeDoiTuong", cbbDoiTuongNhanTin.SelectedValue);
		string text2 = gclass11_0.method_7();
		if (FF2332B3 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, text2))
				{
					E50B7319 = true;
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
				E50B7319 = true;
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

	private void E7308E12()
	{
		BB16AE09(null, null);
		ckbNhanTinVanBan_CheckedChanged(null, null);
		ckbTuongTacKhiNhanTin_CheckedChanged(null, null);
		cbbDoiTuongNhanTin_SelectedIndexChanged(null, null);
	}

	private void BB16AE09(object sender, EventArgs e)
	{
	}

	private void ckbNhanTinVanBan_CheckedChanged(object sender, EventArgs e)
	{
		BE154E3B.Enabled = ckbNhanTinVanBan.Checked;
	}

	private void txtUid_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtUid, D132A913);
	}

	private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
	{
		CE2B1B87.Enabled = ckbSendAnh.Checked;
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void ckbTuongTacKhiNhanTin_CheckedChanged(object sender, EventArgs e)
	{
		plTuongTacTruocKhiNhanTin.Enabled = ckbTuongTacKhiNhanTin.Checked;
	}

	private void FBB6F236_Click(object sender, EventArgs e)
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

	private void cbbTuyChonNoiDung_SelectedIndexChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtNoiDung, DDA872BA, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void BC10B4AF(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtNoiDung, DDA872BA, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void cbbDoiTuongNhanTin_SelectedIndexChanged(object sender, EventArgs e)
	{
		plUid.Enabled = cbbDoiTuongNhanTin.SelectedValue.ToString() == "0";
		if (new List<string> { "0", "1", "2" }.Contains(cbbDoiTuongNhanTin.SelectedValue.ToString()))
		{
			ckbTuongTacKhiNhanTin.Enabled = true;
			return;
		}
		ckbTuongTacKhiNhanTin.Enabled = false;
		ckbTuongTacKhiNhanTin.Checked = false;
	}

	private void DC0042A7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.BFBFBD05(f31742AD_0, this);
	}

	private void cbbTuongTac_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool EE376CA2)
	{
		if (EE376CA2 && E1B91D00 != null)
		{
			E1B91D00.Dispose();
		}
		base.Dispose(EE376CA2);
	}

	private void InitializeComponent()
	{
		E1B91D00 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDBuffTinNhanProfile));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(E1B91D00);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(E1B91D00);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		plUid = new System.Windows.Forms.Panel();
		D132A913 = new System.Windows.Forms.Label();
		txtUid = new System.Windows.Forms.RichTextBox();
		E00A40B6 = new System.Windows.Forms.CheckBox();
		cbbDoiTuongNhanTin = new System.Windows.Forms.ComboBox();
		label2 = new System.Windows.Forms.Label();
		plTuongTacTruocKhiNhanTin = new System.Windows.Forms.Panel();
		DC0042A7 = new System.Windows.Forms.LinkLabel();
		cbbTuongTac = new System.Windows.Forms.ComboBox();
		BE154E3B = new System.Windows.Forms.Panel();
		ckbAutoDeleteComment = new System.Windows.Forms.CheckBox();
		cbbTuyChonNoiDung = new System.Windows.Forms.ComboBox();
		FBB6F236 = new System.Windows.Forms.Button();
		txtNoiDung = new System.Windows.Forms.RichTextBox();
		D018FB8B = new System.Windows.Forms.Label();
		DDA872BA = new System.Windows.Forms.Label();
		CE2B1B87 = new System.Windows.Forms.Panel();
		label9 = new System.Windows.Forms.Label();
		B093BE30 = new System.Windows.Forms.NumericUpDown();
		nudSoLuongAnhTo = new System.Windows.Forms.NumericUpDown();
		label10 = new System.Windows.Forms.Label();
		txtAnh = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		ckbSendAnh = new System.Windows.Forms.CheckBox();
		label49 = new System.Windows.Forms.Label();
		C49E3E90 = new System.Windows.Forms.NumericUpDown();
		FD8C1910 = new System.Windows.Forms.NumericUpDown();
		E4AEDFBB = new System.Windows.Forms.Label();
		ckbTuongTacKhiNhanTin = new System.Windows.Forms.CheckBox();
		ckbNhanTinVanBan = new System.Windows.Forms.CheckBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		DD38D5B9 = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label7 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		B233FB09 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		FB31C094 = new System.Windows.Forms.ToolTip(E1B91D00);
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plUid.SuspendLayout();
		plTuongTacTruocKhiNhanTin.SuspendLayout();
		BE154E3B.SuspendLayout();
		CE2B1B87.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)B093BE30).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongAnhTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)C49E3E90).BeginInit();
		((System.ComponentModel.ISupportInitialize)FD8C1910).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)DD38D5B9).BeginInit();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(638, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Nhắn tin";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(638, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(607, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(ECB7EB38);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(plUid);
		panel1.Controls.Add(cbbDoiTuongNhanTin);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(plTuongTacTruocKhiNhanTin);
		panel1.Controls.Add(BE154E3B);
		panel1.Controls.Add(CE2B1B87);
		panel1.Controls.Add(ckbSendAnh);
		panel1.Controls.Add(label49);
		panel1.Controls.Add(C49E3E90);
		panel1.Controls.Add(FD8C1910);
		panel1.Controls.Add(E4AEDFBB);
		panel1.Controls.Add(ckbTuongTacKhiNhanTin);
		panel1.Controls.Add(ckbNhanTinVanBan);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(DD38D5B9);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(B233FB09);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(641, 495);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		plUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plUid.Controls.Add(D132A913);
		plUid.Controls.Add(txtUid);
		plUid.Controls.Add(E00A40B6);
		plUid.Location = new System.Drawing.Point(30, 167);
		plUid.Name = "plUid";
		plUid.Size = new System.Drawing.Size(265, 209);
		plUid.TabIndex = 194;
		D132A913.AutoSize = true;
		D132A913.Location = new System.Drawing.Point(0, 3);
		D132A913.Name = "lblUid";
		D132A913.Size = new System.Drawing.Size(114, 16);
		D132A913.TabIndex = 0;
		D132A913.Text = "Danh sách Uid (0):";
		txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtUid.Location = new System.Drawing.Point(3, 22);
		txtUid.Name = "txtUid";
		txtUid.Size = new System.Drawing.Size(257, 160);
		txtUid.TabIndex = 117;
		txtUid.Text = "";
		txtUid.WordWrap = false;
		txtUid.TextChanged += new System.EventHandler(txtUid_TextChanged);
		E00A40B6.AutoSize = true;
		E00A40B6.Cursor = System.Windows.Forms.Cursors.Hand;
		E00A40B6.Location = new System.Drawing.Point(3, 184);
		E00A40B6.Name = "ckbTuDongXoaUid";
		E00A40B6.Size = new System.Drawing.Size(188, 20);
		E00A40B6.TabIndex = 8;
		E00A40B6.Text = "Tự động xóa Uid đã nhắn tin";
		E00A40B6.UseVisualStyleBackColor = true;
		cbbDoiTuongNhanTin.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDoiTuongNhanTin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDoiTuongNhanTin.DropDownWidth = 200;
		cbbDoiTuongNhanTin.FormattingEnabled = true;
		cbbDoiTuongNhanTin.Location = new System.Drawing.Point(131, 137);
		cbbDoiTuongNhanTin.Name = "cbbDoiTuongNhanTin";
		cbbDoiTuongNhanTin.Size = new System.Drawing.Size(164, 24);
		cbbDoiTuongNhanTin.TabIndex = 193;
		cbbDoiTuongNhanTin.SelectedIndexChanged += new System.EventHandler(cbbDoiTuongNhanTin_SelectedIndexChanged);
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 140);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(64, 16);
		label2.TabIndex = 192;
		label2.Text = "Tùy chọn:";
		plTuongTacTruocKhiNhanTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plTuongTacTruocKhiNhanTin.Controls.Add(DC0042A7);
		plTuongTacTruocKhiNhanTin.Controls.Add(cbbTuongTac);
		plTuongTacTruocKhiNhanTin.Enabled = false;
		plTuongTacTruocKhiNhanTin.Location = new System.Drawing.Point(30, 403);
		plTuongTacTruocKhiNhanTin.Name = "plTuongTacTruocKhiNhanTin";
		plTuongTacTruocKhiNhanTin.Size = new System.Drawing.Size(265, 32);
		plTuongTacTruocKhiNhanTin.TabIndex = 163;
		DC0042A7.AutoSize = true;
		DC0042A7.Cursor = System.Windows.Forms.Cursors.Hand;
		DC0042A7.Location = new System.Drawing.Point(212, 6);
		DC0042A7.Name = "lblTuongTacNhom";
		DC0042A7.Size = new System.Drawing.Size(47, 16);
		DC0042A7.TabIndex = 184;
		DC0042A7.TabStop = true;
		DC0042A7.Text = "Cài đặt";
		DC0042A7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(DC0042A7_LinkClicked);
		cbbTuongTac.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTuongTac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTuongTac.FormattingEnabled = true;
		cbbTuongTac.Location = new System.Drawing.Point(3, 3);
		cbbTuongTac.Name = "cbbTuongTac";
		cbbTuongTac.Size = new System.Drawing.Size(203, 24);
		cbbTuongTac.TabIndex = 107;
		cbbTuongTac.SelectedIndexChanged += new System.EventHandler(cbbTuongTac_SelectedIndexChanged);
		BE154E3B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		BE154E3B.Controls.Add(ckbAutoDeleteComment);
		BE154E3B.Controls.Add(cbbTuyChonNoiDung);
		BE154E3B.Controls.Add(FBB6F236);
		BE154E3B.Controls.Add(txtNoiDung);
		BE154E3B.Controls.Add(D018FB8B);
		BE154E3B.Controls.Add(DDA872BA);
		BE154E3B.Location = new System.Drawing.Point(328, 73);
		BE154E3B.Name = "plComment";
		BE154E3B.Size = new System.Drawing.Size(281, 274);
		BE154E3B.TabIndex = 10;
		ckbAutoDeleteComment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		ckbAutoDeleteComment.AutoSize = true;
		ckbAutoDeleteComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAutoDeleteComment.Location = new System.Drawing.Point(5, 248);
		ckbAutoDeleteComment.Name = "ckbAutoDeleteComment";
		ckbAutoDeleteComment.Size = new System.Drawing.Size(169, 20);
		ckbAutoDeleteComment.TabIndex = 198;
		ckbAutoDeleteComment.Text = "Xóa nội dung đã sư\u0309 du\u0323ng";
		ckbAutoDeleteComment.UseVisualStyleBackColor = true;
		cbbTuyChonNoiDung.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		cbbTuyChonNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTuyChonNoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTuyChonNoiDung.FormattingEnabled = true;
		cbbTuyChonNoiDung.Location = new System.Drawing.Point(68, 219);
		cbbTuyChonNoiDung.Name = "cbbTuyChonNoiDung";
		cbbTuyChonNoiDung.Size = new System.Drawing.Size(174, 24);
		cbbTuyChonNoiDung.TabIndex = 197;
		cbbTuyChonNoiDung.SelectedIndexChanged += new System.EventHandler(cbbTuyChonNoiDung_SelectedIndexChanged);
		FBB6F236.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		FBB6F236.Cursor = System.Windows.Forms.Cursors.Hand;
		FBB6F236.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		FBB6F236.Location = new System.Drawing.Point(248, 218);
		FBB6F236.Name = "btnHuongDanNhapNoiDung";
		FBB6F236.Size = new System.Drawing.Size(26, 26);
		FBB6F236.TabIndex = 196;
		FBB6F236.Text = "?";
		FBB6F236.UseVisualStyleBackColor = true;
		FBB6F236.Click += new System.EventHandler(FBB6F236_Click);
		txtNoiDung.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		txtNoiDung.Location = new System.Drawing.Point(6, 23);
		txtNoiDung.Name = "txtNoiDung";
		txtNoiDung.Size = new System.Drawing.Size(269, 190);
		txtNoiDung.TabIndex = 165;
		txtNoiDung.Text = "";
		txtNoiDung.WordWrap = false;
		txtNoiDung.TextChanged += new System.EventHandler(BC10B4AF);
		D018FB8B.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		D018FB8B.AutoSize = true;
		D018FB8B.Location = new System.Drawing.Point(2, 222);
		D018FB8B.Name = "label11";
		D018FB8B.Size = new System.Drawing.Size(64, 16);
		D018FB8B.TabIndex = 8;
		D018FB8B.Text = "Tùy chọn:";
		DDA872BA.AutoSize = true;
		DDA872BA.Location = new System.Drawing.Point(2, 4);
		DDA872BA.Name = "lblNoiDung";
		DDA872BA.Size = new System.Drawing.Size(133, 16);
		DDA872BA.TabIndex = 0;
		DDA872BA.Text = "Nội dung tin nhắn (0):";
		CE2B1B87.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		CE2B1B87.Controls.Add(label9);
		CE2B1B87.Controls.Add(B093BE30);
		CE2B1B87.Controls.Add(nudSoLuongAnhTo);
		CE2B1B87.Controls.Add(label10);
		CE2B1B87.Controls.Add(txtAnh);
		CE2B1B87.Controls.Add(label3);
		CE2B1B87.Enabled = false;
		CE2B1B87.Location = new System.Drawing.Point(328, 375);
		CE2B1B87.Name = "plAnh";
		CE2B1B87.Size = new System.Drawing.Size(281, 61);
		CE2B1B87.TabIndex = 162;
		label9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label9.Location = new System.Drawing.Point(152, 34);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(29, 16);
		label9.TabIndex = 38;
		label9.Text = ">";
		label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B093BE30.Location = new System.Drawing.Point(106, 32);
		B093BE30.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		B093BE30.Name = "nudSoLuongAnhFrom";
		B093BE30.Size = new System.Drawing.Size(43, 23);
		B093BE30.TabIndex = 5;
		nudSoLuongAnhTo.Location = new System.Drawing.Point(183, 32);
		nudSoLuongAnhTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongAnhTo.Name = "nudSoLuongAnhTo";
		nudSoLuongAnhTo.Size = new System.Drawing.Size(43, 23);
		nudSoLuongAnhTo.TabIndex = 6;
		label10.AutoSize = true;
		label10.Location = new System.Drawing.Point(3, 7);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(73, 16);
		label10.TabIndex = 159;
		label10.Text = "Folder ảnh:";
		txtAnh.Location = new System.Drawing.Point(106, 4);
		txtAnh.Name = "txtAnh";
		txtAnh.Size = new System.Drawing.Size(169, 23);
		txtAnh.TabIndex = 158;
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(3, 34);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(103, 16);
		label3.TabIndex = 34;
		label3.Text = "Số ảnh/tin nhắn:";
		ckbSendAnh.AutoSize = true;
		ckbSendAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbSendAnh.Location = new System.Drawing.Point(328, 353);
		ckbSendAnh.Name = "ckbSendAnh";
		ckbSendAnh.Size = new System.Drawing.Size(70, 20);
		ckbSendAnh.TabIndex = 161;
		ckbSendAnh.Text = "Gửi ảnh";
		ckbSendAnh.UseVisualStyleBackColor = true;
		ckbSendAnh.CheckedChanged += new System.EventHandler(ckbSendAnh_CheckedChanged);
		label49.AutoSize = true;
		label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label49.Location = new System.Drawing.Point(27, 81);
		label49.Name = "label49";
		label49.Size = new System.Drawing.Size(85, 16);
		label49.TabIndex = 92;
		label49.Text = "Sô\u0301 lươ\u0323ng Uid:";
		FB31C094.SetToolTip(label49, "Mỗi tài khoản chỉ nhắn tin được tối đa 50 người tại 1 thời điểm!");
		C49E3E90.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		C49E3E90.Location = new System.Drawing.Point(131, 79);
		C49E3E90.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		C49E3E90.Name = "nudSoLuongUidFrom";
		C49E3E90.Size = new System.Drawing.Size(56, 23);
		C49E3E90.TabIndex = 1;
		C49E3E90.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		FD8C1910.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		FD8C1910.Location = new System.Drawing.Point(239, 79);
		FD8C1910.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		FD8C1910.Name = "nudSoLuongUidTo";
		FD8C1910.Size = new System.Drawing.Size(56, 23);
		FD8C1910.TabIndex = 2;
		FD8C1910.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		E4AEDFBB.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		E4AEDFBB.Location = new System.Drawing.Point(199, 81);
		E4AEDFBB.Name = "label66";
		E4AEDFBB.Size = new System.Drawing.Size(29, 16);
		E4AEDFBB.TabIndex = 105;
		E4AEDFBB.Text = ">";
		E4AEDFBB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		ckbTuongTacKhiNhanTin.AutoSize = true;
		ckbTuongTacKhiNhanTin.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuongTacKhiNhanTin.Location = new System.Drawing.Point(30, 380);
		ckbTuongTacKhiNhanTin.Name = "ckbTuongTacKhiNhanTin";
		ckbTuongTacKhiNhanTin.Size = new System.Drawing.Size(154, 20);
		ckbTuongTacKhiNhanTin.TabIndex = 9;
		ckbTuongTacKhiNhanTin.Text = "Tương tác khi nhắn tin";
		ckbTuongTacKhiNhanTin.UseVisualStyleBackColor = true;
		ckbTuongTacKhiNhanTin.CheckedChanged += new System.EventHandler(ckbTuongTacKhiNhanTin_CheckedChanged);
		ckbNhanTinVanBan.AutoSize = true;
		ckbNhanTinVanBan.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbNhanTinVanBan.Location = new System.Drawing.Point(328, 51);
		ckbNhanTinVanBan.Name = "ckbNhanTinVanBan";
		ckbNhanTinVanBan.Size = new System.Drawing.Size(122, 20);
		ckbNhanTinVanBan.TabIndex = 9;
		ckbNhanTinVanBan.Text = "Nhắn tin văn bản";
		ckbNhanTinVanBan.UseVisualStyleBackColor = true;
		ckbNhanTinVanBan.CheckedChanged += new System.EventHandler(ckbNhanTinVanBan_CheckedChanged);
		nudDelayTo.Location = new System.Drawing.Point(239, 108);
		nudDelayTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 6;
		DD38D5B9.Location = new System.Drawing.Point(131, 108);
		DD38D5B9.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		DD38D5B9.Name = "nudDelayFrom";
		DD38D5B9.Size = new System.Drawing.Size(56, 23);
		DD38D5B9.TabIndex = 5;
		txtTenHanhDong.Location = new System.Drawing.Point(131, 50);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(164, 23);
		txtTenHanhDong.TabIndex = 0;
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label7.Location = new System.Drawing.Point(199, 110);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = ">";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 110);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(87, 16);
		label5.TabIndex = 34;
		label5.Text = "Gia\u0303n ca\u0301ch (s):";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 53);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(319, 453);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 12;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		B233FB09.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		B233FB09.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		B233FB09.Cursor = System.Windows.Forms.Cursors.Hand;
		B233FB09.FlatAppearance.BorderSize = 0;
		B233FB09.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B233FB09.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B233FB09.ForeColor = System.Drawing.Color.White;
		B233FB09.Location = new System.Drawing.Point(212, 453);
		B233FB09.Name = "btnAdd";
		B233FB09.Size = new System.Drawing.Size(92, 29);
		B233FB09.TabIndex = 11;
		B233FB09.Text = "Thêm";
		B233FB09.UseVisualStyleBackColor = false;
		B233FB09.Click += new System.EventHandler(B233FB09_Click);
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
		bunifuCards1.Size = new System.Drawing.Size(638, 37);
		bunifuCards1.TabIndex = 28;
		FB31C094.AutomaticDelay = 0;
		FB31C094.AutoPopDelay = 20000;
		FB31C094.InitialDelay = 0;
		FB31C094.ReshowDelay = 0;
		FB31C094.ToolTipTitle = "Chú ý";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(641, 495);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBuffTinNhanProfile";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDBuffTinNhanProfile_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plUid.ResumeLayout(false);
		plUid.PerformLayout();
		plTuongTacTruocKhiNhanTin.ResumeLayout(false);
		plTuongTacTruocKhiNhanTin.PerformLayout();
		BE154E3B.ResumeLayout(false);
		BE154E3B.PerformLayout();
		CE2B1B87.ResumeLayout(false);
		CE2B1B87.PerformLayout();
		((System.ComponentModel.ISupportInitialize)B093BE30).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongAnhTo).EndInit();
		((System.ComponentModel.ISupportInitialize)C49E3E90).EndInit();
		((System.ComponentModel.ISupportInitialize)FD8C1910).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)DD38D5B9).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
