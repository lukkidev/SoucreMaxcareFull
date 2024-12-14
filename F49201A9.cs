using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class F49201A9 : Form
{
	private GClass11 gclass11_0;

	private string D18A72AB;

	private string string_0;

	private string string_1;

	private int int_0;

	public static bool AB829622;

	private EFBBE9AB BC2BB93B;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudDelayFrom;

	private NumericUpDown FC2B390D;

	private TextBox DAB46892;

	private Label label7;

	private Label label3;

	private Label C81FBD11;

	private Label E31540BA;

	private Label A7A34E81;

	private Button btnCancel;

	private Button A59E38B8;

	private BunifuCards bunifuCards1;

	private Panel EE0BC428;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel plTuongTacBaiViet;

	private CheckBox B5161709;

	private Panel plDieuKien;

	private RichTextBox txtTuKhoa;

	private Label lblTuKhoa;

	private Label E31F0087;

	private Label label6;

	private NumericUpDown nudLuotToiDa;

	private ComboBox cbbOptionsPost;

	private Label label4;

	private Panel panel2;

	private TabControl tabOptionsPost;

	private TabPage E4AD5082;

	private TabPage AE00C396;

	private Label label8;

	private Label DE8C2706;

	private NumericUpDown nudThoiGianFrom;

	private NumericUpDown A532FE8B;

	private Panel A298B239;

	private Label DB374492;

	private Label F7011897;

	private NumericUpDown nudFeedAdsLuotToiDa;

	private CheckBox ckbFeedAds;

	private Panel B2334796;

	private RichTextBox FF203483;

	private Label CD24E115;

	private Label label14;

	private Label label15;

	private NumericUpDown FCA0B22C;

	private CheckBox C3B6C694;

	private Panel plClickXemAnh;

	private NumericUpDown EDBC5293;

	private NumericUpDown nudDelayXemAnhFrom;

	private Label label11;

	private Label label16;

	private Panel plClickXemThem;

	private NumericUpDown nudDelayXemThemTo;

	private NumericUpDown nudDelayXemThemFrom;

	private Label B421AE9B;

	private Label BFBB3924;

	private CheckBox ckbClickXemAnh;

	private CheckBox ckbClickXemThem;

	public F49201A9(string string_2, int int_1 = 0, string D62841A8 = "")
	{
		FF8B9CB2();
		AB829622 = false;
		D18A72AB = string_2;
		string_1 = D62841A8;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Bài viết Newsfeed";
		Class147.smethod_8(text, text2);
		string text3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			DAB46892.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(D62841A8);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			A59E38B8.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			DAB46892.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void EABF3E21(object sender, EventArgs e)
	{
		method_0();
		try
		{
			cbbOptionsPost.SelectedIndex = gclass11_0.method_2("cbbOptionsPost");
			FC2B390D.Value = gclass11_0.method_2("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass11_0.method_2("nudSoLuongTo", 2);
			nudThoiGianFrom.Value = gclass11_0.method_2("nudThoiGianFrom", 30);
			A532FE8B.Value = gclass11_0.method_2("nudThoiGianTo", 30);
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
			BC2BB93B = new EFBBE9AB(gclass11_0);
			plTuongTacBaiViet.Controls.Add(BC2BB93B);
			B5161709.Checked = gclass11_0.method_3("ckbDieuKien");
			txtTuKhoa.Text = gclass11_0.C0288288("txtTuKhoa");
			nudLuotToiDa.Value = gclass11_0.method_2("nudLuotToiDa", 50);
			ckbFeedAds.Checked = gclass11_0.method_3("ckbFeedAds");
			nudFeedAdsLuotToiDa.Value = gclass11_0.method_2("nudFeedAdsLuotToiDa", 50);
			C3B6C694.Checked = gclass11_0.method_3("ckbFeedGroup");
			FF203483.Text = gclass11_0.C0288288("txtIdNhom");
			FCA0B22C.Value = gclass11_0.method_2("nudFeedGroupLuotToiDa", 50);
			ckbClickXemThem.Checked = gclass11_0.method_3("ckbClickXemThem");
			nudDelayXemThemFrom.Value = gclass11_0.method_2("nudDelayXemThemFrom", 3);
			nudDelayXemThemTo.Value = gclass11_0.method_2("nudDelayXemThemTo", 3);
			ckbClickXemAnh.Checked = gclass11_0.method_3("ckbClickXemAnh");
			nudDelayXemAnhFrom.Value = gclass11_0.method_2("nudDelayXemAnhFrom", 3);
			EDBC5293.Value = gclass11_0.method_2("nudDelayXemAnhTo", 3);
		}
		catch
		{
		}
		method_1();
	}

	private void method_0()
	{
		List<string> list_ = new List<string> { "Giơ\u0301i ha\u0323n sô\u0301 ba\u0300i viê\u0301t tương ta\u0301c", "Giơ\u0301i ha\u0323n thơ\u0300i gian tương ta\u0301c" };
		GClass8.smethod_22(cbbOptionsPost, list_);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A59E38B8_Click(object sender, EventArgs e)
	{
		string text = DAB46892.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = BC2BB93B.F0B0B700();
		gClass.method_4("cbbOptionsPost", cbbOptionsPost.SelectedIndex);
		gClass.method_4("nudSoLuongFrom", FC2B390D.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudThoiGianFrom", nudThoiGianFrom.Value);
		gClass.method_4("nudThoiGianTo", A532FE8B.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		gClass.method_4("ckbDieuKien", B5161709.Checked);
		gClass.method_4("txtTuKhoa", txtTuKhoa.Text.Trim());
		gClass.method_4("nudLuotToiDa", nudLuotToiDa.Value);
		gClass.method_4("ckbFeedAds", ckbFeedAds.Checked);
		gClass.method_4("nudFeedAdsLuotToiDa", nudFeedAdsLuotToiDa.Value);
		gClass.method_4("ckbFeedGroup", C3B6C694.Checked);
		gClass.method_4("txtIdNhom", FF203483.Text.Trim());
		gClass.method_4("nudFeedGroupLuotToiDa", FCA0B22C.Value);
		gClass.method_4("ckbClickXemThem", ckbClickXemThem.Checked);
		gClass.method_4("nudDelayXemThemFrom", nudDelayXemThemFrom.Value);
		gClass.method_4("nudDelayXemThemTo", nudDelayXemThemTo.Value);
		gClass.method_4("ckbClickXemAnh", ckbClickXemAnh.Checked);
		gClass.method_4("nudDelayXemAnhFrom", nudDelayXemAnhFrom.Value);
		gClass.method_4("nudDelayXemAnhTo", EDBC5293.Value);
		string string_ = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(D18A72AB, text, string_0, string_))
				{
					AB829622 = true;
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
				AB829622 = true;
				Close();
			}
			else
			{
				GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void F0ACFC1E(object sender, EventArgs e)
	{
		Close();
	}

	private void D2B6B604(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void method_1()
	{
		B4B2AE07(null, null);
		ckbFeedAds_CheckedChanged(null, null);
		A41CFF91(null, null);
		ckbClickXemThem_CheckedChanged(null, null);
		ckbClickXemAnh_CheckedChanged(null, null);
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void B4B2AE07(object sender, EventArgs e)
	{
		plDieuKien.Enabled = B5161709.Checked;
	}

	private void CAAB1C06(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtTuKhoa, lblTuKhoa);
	}

	private void cbbOptionsPost_SelectedIndexChanged(object sender, EventArgs e)
	{
		tabOptionsPost.SelectedIndex = cbbOptionsPost.SelectedIndex;
	}

	private void txtTuKhoa_MouseEnter(object sender, EventArgs e)
	{
		plDieuKien.Height = 205;
	}

	private void txtTuKhoa_MouseLeave(object sender, EventArgs e)
	{
		plDieuKien.Height = 86;
	}

	private void ckbFeedAds_CheckedChanged(object sender, EventArgs e)
	{
		A298B239.Enabled = ckbFeedAds.Checked;
	}

	private void A41CFF91(object sender, EventArgs e)
	{
		B2334796.Enabled = C3B6C694.Checked;
	}

	private void DA800287(object sender, EventArgs e)
	{
		GClass8.smethod_60(FF203483, CD24E115);
	}

	private void ckbClickXemThem_CheckedChanged(object sender, EventArgs e)
	{
		plClickXemThem.Enabled = ckbClickXemThem.Checked;
	}

	private void ckbClickXemAnh_CheckedChanged(object sender, EventArgs e)
	{
		plClickXemAnh.Enabled = ckbClickXemAnh.Checked;
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void FF8B9CB2()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(F49201A9));
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(icontainer_0);
		EE0BC428 = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		plTuongTacBaiViet = new Panel();
		plClickXemAnh = new Panel();
		EDBC5293 = new NumericUpDown();
		nudDelayXemAnhFrom = new NumericUpDown();
		label11 = new Label();
		label16 = new Label();
		plClickXemThem = new Panel();
		nudDelayXemThemTo = new NumericUpDown();
		nudDelayXemThemFrom = new NumericUpDown();
		B421AE9B = new Label();
		BFBB3924 = new Label();
		ckbClickXemAnh = new CheckBox();
		ckbClickXemThem = new CheckBox();
		panel2 = new Panel();
		tabOptionsPost = new TabControl();
		E4AD5082 = new TabPage();
		E31540BA = new Label();
		label3 = new Label();
		FC2B390D = new NumericUpDown();
		nudSoLuongTo = new NumericUpDown();
		AE00C396 = new TabPage();
		label8 = new Label();
		DE8C2706 = new Label();
		nudThoiGianFrom = new NumericUpDown();
		A532FE8B = new NumericUpDown();
		cbbOptionsPost = new ComboBox();
		nudDelayTo = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		DAB46892 = new TextBox();
		label7 = new Label();
		C81FBD11 = new Label();
		label4 = new Label();
		A7A34E81 = new Label();
		btnCancel = new Button();
		A59E38B8 = new Button();
		bunifuCards1 = new BunifuCards();
		B2334796 = new Panel();
		FF203483 = new RichTextBox();
		CD24E115 = new Label();
		label14 = new Label();
		label15 = new Label();
		FCA0B22C = new NumericUpDown();
		plDieuKien = new Panel();
		txtTuKhoa = new RichTextBox();
		lblTuKhoa = new Label();
		E31F0087 = new Label();
		label6 = new Label();
		nudLuotToiDa = new NumericUpDown();
		C3B6C694 = new CheckBox();
		B5161709 = new CheckBox();
		A298B239 = new Panel();
		DB374492 = new Label();
		F7011897 = new Label();
		nudFeedAdsLuotToiDa = new NumericUpDown();
		ckbFeedAds = new CheckBox();
		EE0BC428.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plClickXemAnh.SuspendLayout();
		((ISupportInitialize)EDBC5293).BeginInit();
		((ISupportInitialize)nudDelayXemAnhFrom).BeginInit();
		plClickXemThem.SuspendLayout();
		((ISupportInitialize)nudDelayXemThemTo).BeginInit();
		((ISupportInitialize)nudDelayXemThemFrom).BeginInit();
		panel2.SuspendLayout();
		tabOptionsPost.SuspendLayout();
		E4AD5082.SuspendLayout();
		((ISupportInitialize)FC2B390D).BeginInit();
		((ISupportInitialize)nudSoLuongTo).BeginInit();
		AE00C396.SuspendLayout();
		((ISupportInitialize)nudThoiGianFrom).BeginInit();
		((ISupportInitialize)A532FE8B).BeginInit();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		B2334796.SuspendLayout();
		((ISupportInitialize)FCA0B22C).BeginInit();
		plDieuKien.SuspendLayout();
		((ISupportInitialize)nudLuotToiDa).BeginInit();
		A298B239.SuspendLayout();
		((ISupportInitialize)nudFeedAdsLuotToiDa).BeginInit();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(716, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Bài viết Newsfeed";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = EE0BC428;
		bunifuDragControl_1.Vertical = true;
		EE0BC428.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		EE0BC428.BackColor = Color.White;
		EE0BC428.Controls.Add(button1);
		EE0BC428.Controls.Add(pictureBox1);
		EE0BC428.Controls.Add(bunifuCustomLabel1);
		EE0BC428.Cursor = Cursors.SizeAll;
		EE0BC428.Location = new Point(0, 3);
		EE0BC428.Name = "pnlHeader";
		EE0BC428.Size = new Size(716, 31);
		EE0BC428.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(685, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += button1_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += pictureBox1_Click;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(plTuongTacBaiViet);
		panel1.Controls.Add(plClickXemAnh);
		panel1.Controls.Add(plClickXemThem);
		panel1.Controls.Add(ckbClickXemAnh);
		panel1.Controls.Add(ckbClickXemThem);
		panel1.Controls.Add(panel2);
		panel1.Controls.Add(cbbOptionsPost);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(DAB46892);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(C81FBD11);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(A7A34E81);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(A59E38B8);
		panel1.Controls.Add(bunifuCards1);
		panel1.Controls.Add(B2334796);
		panel1.Controls.Add(plDieuKien);
		panel1.Controls.Add(C3B6C694);
		panel1.Controls.Add(B5161709);
		panel1.Controls.Add(A298B239);
		panel1.Controls.Add(ckbFeedAds);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(719, 490);
		panel1.TabIndex = 0;
		panel1.Paint += D2B6B604;
		plTuongTacBaiViet.BorderStyle = BorderStyle.FixedSingle;
		plTuongTacBaiViet.Location = new Point(28, 166);
		plTuongTacBaiViet.Name = "plTuongTacBaiViet";
		plTuongTacBaiViet.Size = new Size(657, 266);
		plTuongTacBaiViet.TabIndex = 193;
		plClickXemAnh.BorderStyle = BorderStyle.FixedSingle;
		plClickXemAnh.Controls.Add(EDBC5293);
		plClickXemAnh.Controls.Add(nudDelayXemAnhFrom);
		plClickXemAnh.Controls.Add(label11);
		plClickXemAnh.Controls.Add(label16);
		plClickXemAnh.Location = new Point(379, 336);
		plClickXemAnh.Name = "plClickXemAnh";
		plClickXemAnh.Size = new Size(306, 33);
		plClickXemAnh.TabIndex = 204;
		EDBC5293.Location = new Point(198, 4);
		EDBC5293.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		EDBC5293.Name = "nudDelayXemAnhTo";
		EDBC5293.Size = new Size(56, 23);
		EDBC5293.TabIndex = 40;
		nudDelayXemAnhFrom.Location = new Point(101, 4);
		nudDelayXemAnhFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayXemAnhFrom.Name = "nudDelayXemAnhFrom";
		nudDelayXemAnhFrom.Size = new Size(56, 23);
		nudDelayXemAnhFrom.TabIndex = 39;
		label11.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label11.Location = new Point(163, 6);
		label11.Name = "label11";
		label11.Size = new Size(29, 16);
		label11.TabIndex = 43;
		label11.Text = ">";
		label11.TextAlign = ContentAlignment.MiddleCenter;
		label16.AutoSize = true;
		label16.Location = new Point(3, 6);
		label16.Name = "label16";
		label16.Size = new Size(92, 16);
		label16.TabIndex = 41;
		label16.Text = "Delay time (s):";
		plClickXemThem.BorderStyle = BorderStyle.FixedSingle;
		plClickXemThem.Controls.Add(nudDelayXemThemTo);
		plClickXemThem.Controls.Add(nudDelayXemThemFrom);
		plClickXemThem.Controls.Add(B421AE9B);
		plClickXemThem.Controls.Add(BFBB3924);
		plClickXemThem.Location = new Point(28, 336);
		plClickXemThem.Name = "plClickXemThem";
		plClickXemThem.Size = new Size(262, 33);
		plClickXemThem.TabIndex = 205;
		nudDelayXemThemTo.Location = new Point(198, 4);
		nudDelayXemThemTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayXemThemTo.Name = "nudDelayXemThemTo";
		nudDelayXemThemTo.Size = new Size(56, 23);
		nudDelayXemThemTo.TabIndex = 40;
		nudDelayXemThemFrom.Location = new Point(101, 4);
		nudDelayXemThemFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayXemThemFrom.Name = "nudDelayXemThemFrom";
		nudDelayXemThemFrom.Size = new Size(56, 23);
		nudDelayXemThemFrom.TabIndex = 39;
		B421AE9B.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		B421AE9B.Location = new Point(163, 6);
		B421AE9B.Name = "label17";
		B421AE9B.Size = new Size(29, 16);
		B421AE9B.TabIndex = 43;
		B421AE9B.Text = ">";
		B421AE9B.TextAlign = ContentAlignment.MiddleCenter;
		BFBB3924.AutoSize = true;
		BFBB3924.Location = new Point(3, 6);
		BFBB3924.Name = "label18";
		BFBB3924.Size = new Size(92, 16);
		BFBB3924.TabIndex = 41;
		BFBB3924.Text = "Delay time (s):";
		ckbClickXemAnh.AutoSize = true;
		ckbClickXemAnh.Cursor = Cursors.Hand;
		ckbClickXemAnh.Location = new Point(379, 314);
		ckbClickXemAnh.Name = "ckbClickXemAnh";
		ckbClickXemAnh.Size = new Size(88, 20);
		ckbClickXemAnh.TabIndex = 202;
		ckbClickXemAnh.Text = "Click Photo";
		ckbClickXemAnh.UseVisualStyleBackColor = true;
		ckbClickXemAnh.CheckedChanged += ckbClickXemAnh_CheckedChanged;
		ckbClickXemThem.AutoSize = true;
		ckbClickXemThem.Cursor = Cursors.Hand;
		ckbClickXemThem.Location = new Point(28, 314);
		ckbClickXemThem.Name = "ckbClickXemThem";
		ckbClickXemThem.Size = new Size(112, 20);
		ckbClickXemThem.TabIndex = 203;
		ckbClickXemThem.Text = "Click See more";
		ckbClickXemThem.UseVisualStyleBackColor = true;
		ckbClickXemThem.CheckedChanged += ckbClickXemThem_CheckedChanged;
		panel2.Controls.Add(tabOptionsPost);
		panel2.Location = new Point(28, 108);
		panel2.Name = "panel2";
		panel2.Size = new Size(266, 23);
		panel2.TabIndex = 199;
		tabOptionsPost.Alignment = TabAlignment.Bottom;
		tabOptionsPost.Controls.Add(E4AD5082);
		tabOptionsPost.Controls.Add(AE00C396);
		tabOptionsPost.Location = new Point(-5, -5);
		tabOptionsPost.Name = "tabOptionsPost";
		tabOptionsPost.SelectedIndex = 0;
		tabOptionsPost.Size = new Size(276, 54);
		tabOptionsPost.TabIndex = 198;
		E4AD5082.Controls.Add(E31540BA);
		E4AD5082.Controls.Add(label3);
		E4AD5082.Controls.Add(FC2B390D);
		E4AD5082.Controls.Add(nudSoLuongTo);
		E4AD5082.Location = new Point(4, 4);
		E4AD5082.Name = "tabPage1";
		E4AD5082.Padding = new Padding(3);
		E4AD5082.Size = new Size(268, 25);
		E4AD5082.TabIndex = 0;
		E4AD5082.Text = "tabPage1";
		E4AD5082.UseVisualStyleBackColor = true;
		E31540BA.AutoSize = true;
		E31540BA.Location = new Point(0, 3);
		E31540BA.Name = "label2";
		E31540BA.Size = new Size(84, 16);
		E31540BA.TabIndex = 32;
		E31540BA.Text = "Sô\u0301 lươ\u0323ng ba\u0300i:";
		label3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label3.Location = new Point(172, 3);
		label3.Name = "label3";
		label3.Size = new Size(29, 16);
		label3.TabIndex = 1;
		label3.Text = ">";
		label3.TextAlign = ContentAlignment.MiddleCenter;
		FC2B390D.Location = new Point(110, 1);
		FC2B390D.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		FC2B390D.Name = "nudSoLuongFrom";
		FC2B390D.Size = new Size(56, 23);
		FC2B390D.TabIndex = 0;
		nudSoLuongTo.Location = new Point(207, 1);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		AE00C396.Controls.Add(label8);
		AE00C396.Controls.Add(DE8C2706);
		AE00C396.Controls.Add(nudThoiGianFrom);
		AE00C396.Controls.Add(A532FE8B);
		AE00C396.Location = new Point(4, 4);
		AE00C396.Name = "tabPage2";
		AE00C396.Padding = new Padding(3);
		AE00C396.Size = new Size(268, 28);
		AE00C396.TabIndex = 1;
		AE00C396.Text = "tabPage2";
		AE00C396.UseVisualStyleBackColor = true;
		label8.AutoSize = true;
		label8.Location = new Point(0, 3);
		label8.Name = "label8";
		label8.Size = new Size(85, 16);
		label8.TabIndex = 40;
		label8.Text = "Thơ\u0300i gian (s):";
		DE8C2706.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		DE8C2706.Location = new Point(172, 3);
		DE8C2706.Name = "label9";
		DE8C2706.Size = new Size(29, 16);
		DE8C2706.TabIndex = 41;
		DE8C2706.Text = ">";
		DE8C2706.TextAlign = ContentAlignment.MiddleCenter;
		nudThoiGianFrom.Location = new Point(110, 1);
		nudThoiGianFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudThoiGianFrom.Name = "nudThoiGianFrom";
		nudThoiGianFrom.Size = new Size(56, 23);
		nudThoiGianFrom.TabIndex = 38;
		A532FE8B.Location = new Point(207, 1);
		A532FE8B.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A532FE8B.Name = "nudThoiGianTo";
		A532FE8B.Size = new Size(56, 23);
		A532FE8B.TabIndex = 39;
		cbbOptionsPost.Cursor = Cursors.Hand;
		cbbOptionsPost.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbOptionsPost.DropDownWidth = 200;
		cbbOptionsPost.FormattingEnabled = true;
		cbbOptionsPost.Location = new Point(137, 78);
		cbbOptionsPost.Name = "cbbOptionsPost";
		cbbOptionsPost.Size = new Size(153, 24);
		cbbOptionsPost.TabIndex = 1;
		cbbOptionsPost.SelectedIndexChanged += cbbOptionsPost_SelectedIndexChanged;
		nudDelayTo.Location = new Point(234, 137);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudDelayFrom.Location = new Point(137, 137);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 2;
		DAB46892.Location = new Point(137, 49);
		DAB46892.Name = "txtTenHanhDong";
		DAB46892.Size = new Size(153, 23);
		DAB46892.TabIndex = 0;
		label7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label7.Location = new Point(199, 139);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 3;
		label7.Text = ">";
		label7.TextAlign = ContentAlignment.MiddleCenter;
		C81FBD11.AutoSize = true;
		C81FBD11.Location = new Point(27, 139);
		C81FBD11.Name = "label5";
		C81FBD11.Size = new Size(87, 16);
		C81FBD11.TabIndex = 34;
		C81FBD11.Text = "Gia\u0303n ca\u0301ch (s):";
		label4.AutoSize = true;
		label4.Location = new Point(27, 81);
		label4.Name = "label4";
		label4.Size = new Size(64, 16);
		label4.TabIndex = 32;
		label4.Text = "Tu\u0300y cho\u0323n:";
		A7A34E81.AutoSize = true;
		A7A34E81.Location = new Point(27, 52);
		A7A34E81.Name = "label1";
		A7A34E81.Size = new Size(98, 16);
		A7A34E81.TabIndex = 31;
		A7A34E81.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(367, 447);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += F0ACFC1E;
		A59E38B8.Anchor = AnchorStyles.Bottom;
		A59E38B8.BackColor = Color.FromArgb(53, 120, 229);
		A59E38B8.Cursor = Cursors.Hand;
		A59E38B8.FlatAppearance.BorderSize = 0;
		A59E38B8.FlatStyle = FlatStyle.Flat;
		A59E38B8.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		A59E38B8.ForeColor = Color.White;
		A59E38B8.Location = new Point(260, 447);
		A59E38B8.Name = "btnAdd";
		A59E38B8.Size = new Size(92, 29);
		A59E38B8.TabIndex = 9;
		A59E38B8.Text = "Thêm";
		A59E38B8.UseVisualStyleBackColor = false;
		A59E38B8.Click += A59E38B8_Click;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(EE0BC428);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(716, 37);
		bunifuCards1.TabIndex = 28;
		B2334796.BorderStyle = BorderStyle.FixedSingle;
		B2334796.Controls.Add(FF203483);
		B2334796.Controls.Add(CD24E115);
		B2334796.Controls.Add(label14);
		B2334796.Controls.Add(label15);
		B2334796.Controls.Add(FCA0B22C);
		B2334796.Location = new Point(28, 222);
		B2334796.Name = "plFeedGroup";
		B2334796.Size = new Size(306, 86);
		B2334796.TabIndex = 195;
		FF203483.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		FF203483.Location = new Point(7, 25);
		FF203483.Name = "txtIdNhom";
		FF203483.Size = new Size(291, 55);
		FF203483.TabIndex = 0;
		FF203483.Text = "";
		FF203483.WordWrap = false;
		FF203483.TextChanged += DA800287;
		CD24E115.AutoSize = true;
		CD24E115.Location = new Point(3, 5);
		CD24E115.Name = "lblIdNhom";
		CD24E115.Size = new Size(143, 16);
		CD24E115.TabIndex = 0;
		CD24E115.Text = "Danh sa\u0301ch Id nho\u0301m (0):";
		label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		label14.AutoSize = true;
		label14.Location = new Point(276, 5);
		label14.Name = "label14";
		label14.Size = new Size(24, 16);
		label14.TabIndex = 32;
		label14.Text = "ba\u0300i";
		label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		label15.AutoSize = true;
		label15.Location = new Point(161, 5);
		label15.Name = "label15";
		label15.Size = new Size(73, 16);
		label15.TabIndex = 32;
		label15.Text = "Lươ\u0301t tô\u0301i đa:";
		FCA0B22C.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		FCA0B22C.Location = new Point(234, 1);
		FCA0B22C.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		FCA0B22C.Name = "nudFeedGroupLuotToiDa";
		FCA0B22C.Size = new Size(42, 23);
		FCA0B22C.TabIndex = 1;
		FCA0B22C.Value = new decimal(new int[4] { 50, 0, 0, 0 });
		plDieuKien.BorderStyle = BorderStyle.FixedSingle;
		plDieuKien.Controls.Add(txtTuKhoa);
		plDieuKien.Controls.Add(lblTuKhoa);
		plDieuKien.Controls.Add(E31F0087);
		plDieuKien.Controls.Add(label6);
		plDieuKien.Controls.Add(nudLuotToiDa);
		plDieuKien.Location = new Point(379, 222);
		plDieuKien.Name = "plDieuKien";
		plDieuKien.Size = new Size(306, 86);
		plDieuKien.TabIndex = 195;
		plDieuKien.Visible = false;
		txtTuKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		txtTuKhoa.Location = new Point(7, 25);
		txtTuKhoa.Name = "txtTuKhoa";
		txtTuKhoa.Size = new Size(291, 55);
		txtTuKhoa.TabIndex = 0;
		txtTuKhoa.Text = "";
		txtTuKhoa.WordWrap = false;
		txtTuKhoa.TextChanged += CAAB1C06;
		txtTuKhoa.MouseEnter += txtTuKhoa_MouseEnter;
		txtTuKhoa.MouseLeave += txtTuKhoa_MouseLeave;
		lblTuKhoa.AutoSize = true;
		lblTuKhoa.Location = new Point(3, 5);
		lblTuKhoa.Name = "lblTuKhoa";
		lblTuKhoa.Size = new Size(114, 16);
		lblTuKhoa.TabIndex = 0;
		lblTuKhoa.Text = "Danh sa\u0301ch tên (0):";
		E31F0087.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		E31F0087.AutoSize = true;
		E31F0087.Location = new Point(276, 5);
		E31F0087.Name = "label10";
		E31F0087.Size = new Size(24, 16);
		E31F0087.TabIndex = 32;
		E31F0087.Text = "ba\u0300i";
		label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		label6.AutoSize = true;
		label6.Location = new Point(148, 5);
		label6.Name = "label6";
		label6.Size = new Size(73, 16);
		label6.TabIndex = 32;
		label6.Text = "Lươ\u0301t tô\u0301i đa:";
		nudLuotToiDa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		nudLuotToiDa.Location = new Point(222, 1);
		nudLuotToiDa.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudLuotToiDa.Name = "nudLuotToiDa";
		nudLuotToiDa.Size = new Size(54, 23);
		nudLuotToiDa.TabIndex = 1;
		nudLuotToiDa.Value = new decimal(new int[4] { 500, 0, 0, 0 });
		C3B6C694.AutoSize = true;
		C3B6C694.Cursor = Cursors.Hand;
		C3B6C694.Location = new Point(28, 199);
		C3B6C694.Name = "ckbFeedGroup";
		C3B6C694.Size = new Size(257, 20);
		C3B6C694.TabIndex = 196;
		C3B6C694.Text = "Chi\u0309 tương ta\u0301c vơ\u0301i ba\u0300i viê\u0301t cu\u0309a group sau:";
		C3B6C694.UseVisualStyleBackColor = true;
		C3B6C694.CheckedChanged += A41CFF91;
		B5161709.AutoSize = true;
		B5161709.Cursor = Cursors.Hand;
		B5161709.Location = new Point(379, 199);
		B5161709.Name = "ckbDieuKien";
		B5161709.Size = new Size(293, 20);
		B5161709.TabIndex = 196;
		B5161709.Text = "Chi\u0309 tương ta\u0301c khi tên page co\u0301 chư\u0301a ca\u0301c tư\u0300 sau:";
		B5161709.UseVisualStyleBackColor = true;
		B5161709.Visible = false;
		B5161709.CheckedChanged += B4B2AE07;
		A298B239.BorderStyle = BorderStyle.FixedSingle;
		A298B239.Controls.Add(DB374492);
		A298B239.Controls.Add(F7011897);
		A298B239.Controls.Add(nudFeedAdsLuotToiDa);
		A298B239.Location = new Point(379, 74);
		A298B239.Name = "plFeedAds";
		A298B239.Size = new Size(306, 33);
		A298B239.TabIndex = 200;
		A298B239.Visible = false;
		DB374492.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		DB374492.AutoSize = true;
		DB374492.Location = new Point(132, 6);
		DB374492.Name = "label12";
		DB374492.Size = new Size(24, 16);
		DB374492.TabIndex = 32;
		DB374492.Text = "ba\u0300i";
		F7011897.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		F7011897.AutoSize = true;
		F7011897.Location = new Point(4, 6);
		F7011897.Name = "label13";
		F7011897.Size = new Size(73, 16);
		F7011897.TabIndex = 32;
		F7011897.Text = "Lươ\u0301t tô\u0301i đa:";
		nudFeedAdsLuotToiDa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		nudFeedAdsLuotToiDa.Location = new Point(78, 4);
		nudFeedAdsLuotToiDa.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudFeedAdsLuotToiDa.Name = "nudFeedAdsLuotToiDa";
		nudFeedAdsLuotToiDa.Size = new Size(54, 23);
		nudFeedAdsLuotToiDa.TabIndex = 1;
		nudFeedAdsLuotToiDa.Value = new decimal(new int[4] { 500, 0, 0, 0 });
		ckbFeedAds.AutoSize = true;
		ckbFeedAds.Cursor = Cursors.Hand;
		ckbFeedAds.Location = new Point(379, 51);
		ckbFeedAds.Name = "ckbFeedAds";
		ckbFeedAds.Size = new Size(167, 20);
		ckbFeedAds.TabIndex = 201;
		ckbFeedAds.Text = "Chi\u0309 tương ta\u0301c vơ\u0301i ba\u0300i ads";
		ckbFeedAds.UseVisualStyleBackColor = true;
		ckbFeedAds.Visible = false;
		ckbFeedAds.CheckedChanged += ckbFeedAds_CheckedChanged;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(719, 490);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDBaiVietNewsfeed";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += EABF3E21;
		EE0BC428.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		plClickXemAnh.ResumeLayout(performLayout: false);
		plClickXemAnh.PerformLayout();
		((ISupportInitialize)EDBC5293).EndInit();
		((ISupportInitialize)nudDelayXemAnhFrom).EndInit();
		plClickXemThem.ResumeLayout(performLayout: false);
		plClickXemThem.PerformLayout();
		((ISupportInitialize)nudDelayXemThemTo).EndInit();
		((ISupportInitialize)nudDelayXemThemFrom).EndInit();
		panel2.ResumeLayout(performLayout: false);
		tabOptionsPost.ResumeLayout(performLayout: false);
		E4AD5082.ResumeLayout(performLayout: false);
		E4AD5082.PerformLayout();
		((ISupportInitialize)FC2B390D).EndInit();
		((ISupportInitialize)nudSoLuongTo).EndInit();
		AE00C396.ResumeLayout(performLayout: false);
		AE00C396.PerformLayout();
		((ISupportInitialize)nudThoiGianFrom).EndInit();
		((ISupportInitialize)A532FE8B).EndInit();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		B2334796.ResumeLayout(performLayout: false);
		B2334796.PerformLayout();
		((ISupportInitialize)FCA0B22C).EndInit();
		plDieuKien.ResumeLayout(performLayout: false);
		plDieuKien.PerformLayout();
		((ISupportInitialize)nudLuotToiDa).EndInit();
		A298B239.ResumeLayout(performLayout: false);
		A298B239.PerformLayout();
		((ISupportInitialize)nudFeedAdsLuotToiDa).EndInit();
		ResumeLayout(performLayout: false);
	}
}
