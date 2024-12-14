using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public class ucTuongTacBaiViet : UserControl
{
	private GClass11 DA3CDC2E;

	private List<CheckBox> D4853D27;

	private IContainer F82E4191 = null;

	private Panel plCommentText;

	private CheckBox ckbTTBVAutoDeleteComment;

	private Button BCB71F05;

	private LinkLabel D30421A2;

	private Panel panel3;

	private RadioButton rbCommentTheoThuTu;

	private RadioButton EF19C116;

	private Label FF97843C;

	private Label label8;

	private RichTextBox txtTTBVComment;

	private Label label11;

	private Label lblComment;

	private Panel C131D085;

	private TextBox txtTTBVImagePath;

	private Label label12;

	private CheckBox ckbTTBVCommentImage;

	private CheckBox ckbTTBVCommentText;

	private CheckBox A73FAC17;

	private CheckBox ckbTTBVInteract;

	private NumericUpDown F91FB8AA;

	private NumericUpDown nudTTBVTimeFrom;

	private Label label9;

	private Label A695199D;

	private ComboBox cbbTTBVTuyChonNoiDung;

	private Panel A1233898;

	private CheckBox F22940AF;

	private CheckBox CFB0E492;

	private CheckBox F9B33E81;

	private CheckBox ckbHaha;

	private CheckBox ckbThuong;

	private CheckBox ckbTym;

	private CheckBox ckbLike;

	private Panel panel7;

	private RadioButton radioButton3;

	private RadioButton FB9DA63A;

	private Label FB1BE71E;

	private Button btnSave;

	private Button btnCancel;

	private Button btnDown;

	private Button btnUp;

	public ucTuongTacBaiViet(GClass11 gclass11_0)
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		DA3CDC2E = gclass11_0;
		D4853D27 = new List<CheckBox> { ckbLike, ckbTym, ckbThuong, ckbHaha, F9B33E81, CFB0E492, F22940AF };
		FD959D35();
	}

	private void txtTTBVComment_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtTTBVComment, lblComment, cbbTTBVTuyChonNoiDung.SelectedIndex);
	}

	private void FD959D35()
	{
		List<string> list_ = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		GClass8.smethod_22(cbbTTBVTuyChonNoiDung, list_);
	}

	private void D30421A2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.smethod_33(new E3962B82());
	}

	private void E6BB9B8B(object sender, EventArgs e)
	{
		if (cbbTTBVTuyChonNoiDung.SelectedIndex == 0)
		{
			GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			GClass8.smethod_33(new fHelpNhapComment());
		}
		txtTTBVComment.Focus();
	}

	private void ckbTTBVInteract_CheckedChanged(object sender, EventArgs e)
	{
		A1233898.Enabled = ckbTTBVInteract.Checked;
	}

	private void B3A3D6A4(object sender, EventArgs e)
	{
		plCommentText.Enabled = ckbTTBVCommentText.Checked;
	}

	private void ckbTTBVCommentImage_CheckedChanged(object sender, EventArgs e)
	{
		C131D085.Enabled = ckbTTBVCommentImage.Checked;
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Hide();
	}

	private void AB8A6788(object sender, EventArgs e)
	{
		method_1();
		Hide();
	}

	private void method_0()
	{
		nudTTBVTimeFrom.Value = DA3CDC2E.method_2("nudTTBVTimeFrom", 3);
		F91FB8AA.Value = DA3CDC2E.method_2("nudTTBVTimeTo", 5);
		ckbTTBVInteract.Checked = DA3CDC2E.method_3("ckbTTBVInteract");
		string text = DA3CDC2E.C0288288("TTBVtypeReaction", "0");
		for (int i = 0; i < D4853D27.Count; i++)
		{
			D4853D27[i].Checked = text.Split('|').Contains(i.ToString());
		}
		ckbTTBVCommentText.Checked = DA3CDC2E.method_3("ckbTTBVCommentText");
		txtTTBVComment.Text = DA3CDC2E.C0288288("txtTTBVComment");
		cbbTTBVTuyChonNoiDung.SelectedIndex = DA3CDC2E.method_2("cbbTTBVTuyChonNoiDung");
		ckbTTBVAutoDeleteComment.Checked = DA3CDC2E.method_3("ckbTTBVAutoDeleteComment");
		ckbTTBVCommentImage.Checked = DA3CDC2E.method_3("ckbTTBVCommentImage");
		txtTTBVImagePath.Text = DA3CDC2E.C0288288("txtTTBVImagePath");
		A73FAC17.Checked = DA3CDC2E.method_3("ckbTTBVShareWall");
	}

	private void method_1()
	{
		DA3CDC2E.method_4("nudTTBVTimeFrom", nudTTBVTimeFrom.Value);
		DA3CDC2E.method_4("nudTTBVTimeTo", F91FB8AA.Value);
		DA3CDC2E.method_4("ckbTTBVInteract", ckbTTBVInteract.Checked);
		string text = "";
		for (int i = 0; i < D4853D27.Count; i++)
		{
			if (D4853D27[i].Checked)
			{
				text = text + i + "|";
			}
		}
		DA3CDC2E.method_4("TTBVtypeReaction", text.TrimEnd('|'));
		DA3CDC2E.method_4("ckbTTBVCommentText", ckbTTBVCommentText.Checked);
		DA3CDC2E.method_4("txtTTBVComment", txtTTBVComment.Text);
		DA3CDC2E.method_4("cbbTTBVTuyChonNoiDung", cbbTTBVTuyChonNoiDung.SelectedIndex);
		DA3CDC2E.method_4("ckbTTBVAutoDeleteComment", ckbTTBVAutoDeleteComment.Checked);
		DA3CDC2E.method_4("ckbTTBVCommentImage", ckbTTBVCommentImage.Checked);
		DA3CDC2E.method_4("txtTTBVImagePath", txtTTBVImagePath.Text);
		DA3CDC2E.method_4("ckbTTBVShareWall", A73FAC17.Checked);
	}

	private void ucTuongTacBaiViet_Load(object sender, EventArgs e)
	{
		method_0();
		ckbTTBVInteract_CheckedChanged(null, null);
		B3A3D6A4(null, null);
		ckbTTBVCommentImage_CheckedChanged(null, null);
	}

	private void CD23A0BD(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtTTBVComment, lblComment, cbbTTBVTuyChonNoiDung.SelectedIndex);
	}

	private void B817E015(object sender, EventArgs e)
	{
		if (base.Visible)
		{
			method_0();
		}
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		plCommentText.Height = 183;
	}

	private void AB2022B4(object sender, EventArgs e)
	{
		plCommentText.Height = 208;
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && F82E4191 != null)
		{
			F82E4191.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		plCommentText = new System.Windows.Forms.Panel();
		cbbTTBVTuyChonNoiDung = new System.Windows.Forms.ComboBox();
		ckbTTBVAutoDeleteComment = new System.Windows.Forms.CheckBox();
		BCB71F05 = new System.Windows.Forms.Button();
		D30421A2 = new System.Windows.Forms.LinkLabel();
		panel3 = new System.Windows.Forms.Panel();
		rbCommentTheoThuTu = new System.Windows.Forms.RadioButton();
		EF19C116 = new System.Windows.Forms.RadioButton();
		FF97843C = new System.Windows.Forms.Label();
		txtTTBVComment = new System.Windows.Forms.RichTextBox();
		label11 = new System.Windows.Forms.Label();
		label8 = new System.Windows.Forms.Label();
		lblComment = new System.Windows.Forms.Label();
		C131D085 = new System.Windows.Forms.Panel();
		txtTTBVImagePath = new System.Windows.Forms.TextBox();
		label12 = new System.Windows.Forms.Label();
		ckbTTBVCommentImage = new System.Windows.Forms.CheckBox();
		ckbTTBVCommentText = new System.Windows.Forms.CheckBox();
		A73FAC17 = new System.Windows.Forms.CheckBox();
		ckbTTBVInteract = new System.Windows.Forms.CheckBox();
		F91FB8AA = new System.Windows.Forms.NumericUpDown();
		nudTTBVTimeFrom = new System.Windows.Forms.NumericUpDown();
		label9 = new System.Windows.Forms.Label();
		A695199D = new System.Windows.Forms.Label();
		A1233898 = new System.Windows.Forms.Panel();
		F22940AF = new System.Windows.Forms.CheckBox();
		CFB0E492 = new System.Windows.Forms.CheckBox();
		F9B33E81 = new System.Windows.Forms.CheckBox();
		ckbHaha = new System.Windows.Forms.CheckBox();
		ckbThuong = new System.Windows.Forms.CheckBox();
		ckbTym = new System.Windows.Forms.CheckBox();
		ckbLike = new System.Windows.Forms.CheckBox();
		panel7 = new System.Windows.Forms.Panel();
		radioButton3 = new System.Windows.Forms.RadioButton();
		FB9DA63A = new System.Windows.Forms.RadioButton();
		FB1BE71E = new System.Windows.Forms.Label();
		btnSave = new System.Windows.Forms.Button();
		btnCancel = new System.Windows.Forms.Button();
		btnDown = new System.Windows.Forms.Button();
		btnUp = new System.Windows.Forms.Button();
		plCommentText.SuspendLayout();
		panel3.SuspendLayout();
		C131D085.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)F91FB8AA).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTTBVTimeFrom).BeginInit();
		A1233898.SuspendLayout();
		panel7.SuspendLayout();
		SuspendLayout();
		plCommentText.Anchor = System.Windows.Forms.AnchorStyles.None;
		plCommentText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plCommentText.Controls.Add(btnDown);
		plCommentText.Controls.Add(btnUp);
		plCommentText.Controls.Add(cbbTTBVTuyChonNoiDung);
		plCommentText.Controls.Add(ckbTTBVAutoDeleteComment);
		plCommentText.Controls.Add(BCB71F05);
		plCommentText.Controls.Add(D30421A2);
		plCommentText.Controls.Add(panel3);
		plCommentText.Controls.Add(FF97843C);
		plCommentText.Controls.Add(txtTTBVComment);
		plCommentText.Controls.Add(label11);
		plCommentText.Controls.Add(label8);
		plCommentText.Controls.Add(lblComment);
		plCommentText.Location = new System.Drawing.Point(37, 122);
		plCommentText.Name = "plCommentText";
		plCommentText.Size = new System.Drawing.Size(310, 183);
		plCommentText.TabIndex = 176;
		cbbTTBVTuyChonNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTTBVTuyChonNoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTTBVTuyChonNoiDung.FormattingEnabled = true;
		cbbTTBVTuyChonNoiDung.Location = new System.Drawing.Point(81, 153);
		cbbTTBVTuyChonNoiDung.Name = "cbbTTBVTuyChonNoiDung";
		cbbTTBVTuyChonNoiDung.Size = new System.Drawing.Size(190, 24);
		cbbTTBVTuyChonNoiDung.TabIndex = 177;
		cbbTTBVTuyChonNoiDung.SelectedIndexChanged += new System.EventHandler(CD23A0BD);
		ckbTTBVAutoDeleteComment.AutoSize = true;
		ckbTTBVAutoDeleteComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTTBVAutoDeleteComment.Location = new System.Drawing.Point(8, 182);
		ckbTTBVAutoDeleteComment.Name = "ckbTTBVAutoDeleteComment";
		ckbTTBVAutoDeleteComment.Size = new System.Drawing.Size(225, 20);
		ckbTTBVAutoDeleteComment.TabIndex = 176;
		ckbTTBVAutoDeleteComment.Text = "Tự động xóa nội dung đã bình luận";
		ckbTTBVAutoDeleteComment.UseVisualStyleBackColor = true;
		BCB71F05.Cursor = System.Windows.Forms.Cursors.Hand;
		BCB71F05.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		BCB71F05.Location = new System.Drawing.Point(277, 152);
		BCB71F05.Name = "btnHuongDanNhapNoiDung";
		BCB71F05.Size = new System.Drawing.Size(26, 26);
		BCB71F05.TabIndex = 173;
		BCB71F05.Text = "?";
		BCB71F05.UseVisualStyleBackColor = true;
		BCB71F05.Click += new System.EventHandler(E6BB9B8B);
		D30421A2.AutoSize = true;
		D30421A2.Cursor = System.Windows.Forms.Cursors.Hand;
		D30421A2.Location = new System.Drawing.Point(222, 129);
		D30421A2.Name = "linkLabel1";
		D30421A2.Size = new System.Drawing.Size(81, 16);
		D30421A2.TabIndex = 175;
		D30421A2.TabStop = true;
		D30421A2.Text = "Random icon";
		D30421A2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(D30421A2_LinkClicked);
		panel3.Controls.Add(rbCommentTheoThuTu);
		panel3.Controls.Add(EF19C116);
		panel3.Location = new System.Drawing.Point(66, 397);
		panel3.Name = "panel3";
		panel3.Size = new System.Drawing.Size(200, 43);
		panel3.TabIndex = 43;
		rbCommentTheoThuTu.AutoSize = true;
		rbCommentTheoThuTu.Checked = true;
		rbCommentTheoThuTu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbCommentTheoThuTu.Location = new System.Drawing.Point(3, 2);
		rbCommentTheoThuTu.Name = "rbCommentTheoThuTu";
		rbCommentTheoThuTu.Size = new System.Drawing.Size(201, 20);
		rbCommentTheoThuTu.TabIndex = 3;
		rbCommentTheoThuTu.TabStop = true;
		rbCommentTheoThuTu.Text = "Comment theo thứ tự nội dung";
		rbCommentTheoThuTu.UseVisualStyleBackColor = true;
		EF19C116.AutoSize = true;
		EF19C116.Cursor = System.Windows.Forms.Cursors.Hand;
		EF19C116.Location = new System.Drawing.Point(3, 23);
		EF19C116.Name = "rbCommentNgauNhien";
		EF19C116.Size = new System.Drawing.Size(200, 20);
		EF19C116.TabIndex = 3;
		EF19C116.Text = "Comment ngẫu nhiên nội dung";
		EF19C116.UseVisualStyleBackColor = true;
		FF97843C.AutoSize = true;
		FF97843C.Location = new System.Drawing.Point(3, 399);
		FF97843C.Name = "label13";
		FF97843C.Size = new System.Drawing.Size(64, 16);
		FF97843C.TabIndex = 2;
		FF97843C.Text = "Tùy chọn:";
		txtTTBVComment.Location = new System.Drawing.Point(6, 24);
		txtTTBVComment.Name = "txtTTBVComment";
		txtTTBVComment.Size = new System.Drawing.Size(297, 102);
		txtTTBVComment.TabIndex = 1;
		txtTTBVComment.Text = "";
		txtTTBVComment.WordWrap = false;
		txtTTBVComment.TextChanged += new System.EventHandler(txtTTBVComment_TextChanged);
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(4, 129);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(143, 16);
		label11.TabIndex = 0;
		label11.Text = "(Spin nội dung {a|b|c})";
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(4, 156);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(64, 16);
		label8.TabIndex = 2;
		label8.Text = "Tùy chọn:";
		lblComment.AutoSize = true;
		lblComment.Location = new System.Drawing.Point(2, 4);
		lblComment.Name = "lblComment";
		lblComment.Size = new System.Drawing.Size(139, 16);
		lblComment.TabIndex = 0;
		lblComment.Text = "Nội dung bình luận (0):";
		C131D085.Anchor = System.Windows.Forms.AnchorStyles.None;
		C131D085.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C131D085.Controls.Add(txtTTBVImagePath);
		C131D085.Controls.Add(label12);
		C131D085.Enabled = false;
		C131D085.Location = new System.Drawing.Point(37, 334);
		C131D085.Name = "plCommentImage";
		C131D085.Size = new System.Drawing.Size(310, 31);
		C131D085.TabIndex = 178;
		txtTTBVImagePath.Location = new System.Drawing.Point(82, 3);
		txtTTBVImagePath.Name = "txtTTBVImagePath";
		txtTTBVImagePath.Size = new System.Drawing.Size(222, 23);
		txtTTBVImagePath.TabIndex = 155;
		label12.AutoSize = true;
		label12.Location = new System.Drawing.Point(3, 6);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(73, 16);
		label12.TabIndex = 39;
		label12.Text = "Folder ảnh:";
		ckbTTBVCommentImage.Anchor = System.Windows.Forms.AnchorStyles.None;
		ckbTTBVCommentImage.AutoSize = true;
		ckbTTBVCommentImage.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTTBVCommentImage.Location = new System.Drawing.Point(19, 311);
		ckbTTBVCommentImage.Name = "ckbTTBVCommentImage";
		ckbTTBVCommentImage.Size = new System.Drawing.Size(103, 20);
		ckbTTBVCommentImage.TabIndex = 177;
		ckbTTBVCommentImage.Text = "Bình luận ảnh";
		ckbTTBVCommentImage.UseVisualStyleBackColor = true;
		ckbTTBVCommentImage.CheckedChanged += new System.EventHandler(ckbTTBVCommentImage_CheckedChanged);
		ckbTTBVCommentText.Anchor = System.Windows.Forms.AnchorStyles.None;
		ckbTTBVCommentText.AutoSize = true;
		ckbTTBVCommentText.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTTBVCommentText.Location = new System.Drawing.Point(19, 100);
		ckbTTBVCommentText.Name = "ckbTTBVCommentText";
		ckbTTBVCommentText.Size = new System.Drawing.Size(127, 20);
		ckbTTBVCommentText.TabIndex = 174;
		ckbTTBVCommentText.Text = "Bi\u0300nh luâ\u0323n văn bản";
		ckbTTBVCommentText.UseVisualStyleBackColor = true;
		ckbTTBVCommentText.CheckedChanged += new System.EventHandler(B3A3D6A4);
		A73FAC17.Anchor = System.Windows.Forms.AnchorStyles.None;
		A73FAC17.AutoSize = true;
		A73FAC17.Cursor = System.Windows.Forms.Cursors.Hand;
		A73FAC17.Location = new System.Drawing.Point(19, 369);
		A73FAC17.Name = "ckbTTBVShareWall";
		A73FAC17.Size = new System.Drawing.Size(143, 20);
		A73FAC17.TabIndex = 170;
		A73FAC17.Text = "Chia sẻ bài về tường";
		A73FAC17.UseVisualStyleBackColor = true;
		ckbTTBVInteract.Anchor = System.Windows.Forms.AnchorStyles.None;
		ckbTTBVInteract.AutoSize = true;
		ckbTTBVInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTTBVInteract.Location = new System.Drawing.Point(19, 41);
		ckbTTBVInteract.Name = "ckbTTBVInteract";
		ckbTTBVInteract.Size = new System.Drawing.Size(112, 20);
		ckbTTBVInteract.TabIndex = 169;
		ckbTTBVInteract.Text = "Bày tỏ cảm xúc";
		ckbTTBVInteract.UseVisualStyleBackColor = true;
		ckbTTBVInteract.CheckedChanged += new System.EventHandler(ckbTTBVInteract_CheckedChanged);
		F91FB8AA.Anchor = System.Windows.Forms.AnchorStyles.None;
		F91FB8AA.Location = new System.Drawing.Point(258, 11);
		F91FB8AA.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F91FB8AA.Name = "nudTTBVTimeTo";
		F91FB8AA.Size = new System.Drawing.Size(51, 23);
		F91FB8AA.TabIndex = 168;
		nudTTBVTimeFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
		nudTTBVTimeFrom.Location = new System.Drawing.Point(180, 11);
		nudTTBVTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTTBVTimeFrom.Name = "nudTTBVTimeFrom";
		nudTTBVTimeFrom.Size = new System.Drawing.Size(51, 23);
		nudTTBVTimeFrom.TabIndex = 167;
		label9.Anchor = System.Windows.Forms.AnchorStyles.None;
		label9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label9.Location = new System.Drawing.Point(231, 13);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(29, 16);
		label9.TabIndex = 173;
		label9.Text = ">";
		label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		A695199D.Anchor = System.Windows.Forms.AnchorStyles.None;
		A695199D.AutoSize = true;
		A695199D.Location = new System.Drawing.Point(16, 13);
		A695199D.Name = "label3";
		A695199D.Size = new System.Drawing.Size(158, 16);
		A695199D.TabIndex = 171;
		A695199D.Text = "Thơ\u0300i gian xem bài viết (s):";
		A1233898.Anchor = System.Windows.Forms.AnchorStyles.None;
		A1233898.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		A1233898.Controls.Add(F22940AF);
		A1233898.Controls.Add(CFB0E492);
		A1233898.Controls.Add(F9B33E81);
		A1233898.Controls.Add(ckbHaha);
		A1233898.Controls.Add(ckbThuong);
		A1233898.Controls.Add(ckbTym);
		A1233898.Controls.Add(ckbLike);
		A1233898.Controls.Add(panel7);
		A1233898.Controls.Add(FB1BE71E);
		A1233898.Location = new System.Drawing.Point(37, 61);
		A1233898.Name = "plInteract";
		A1233898.Size = new System.Drawing.Size(310, 33);
		A1233898.TabIndex = 179;
		F22940AF.Cursor = System.Windows.Forms.Cursors.Hand;
		F22940AF.Image = C50FB39E.ABB95605;
		F22940AF.Location = new System.Drawing.Point(266, 1);
		F22940AF.Name = "ckbGian";
		F22940AF.Size = new System.Drawing.Size(40, 30);
		F22940AF.TabIndex = 179;
		F22940AF.UseVisualStyleBackColor = true;
		CFB0E492.Cursor = System.Windows.Forms.Cursors.Hand;
		CFB0E492.Image = C50FB39E.Bitmap_163;
		CFB0E492.Location = new System.Drawing.Point(222, 1);
		CFB0E492.Name = "ckbBuon";
		CFB0E492.Size = new System.Drawing.Size(40, 30);
		CFB0E492.TabIndex = 178;
		CFB0E492.UseVisualStyleBackColor = true;
		F9B33E81.Cursor = System.Windows.Forms.Cursors.Hand;
		F9B33E81.Image = C50FB39E.F10C2BBC;
		F9B33E81.Location = new System.Drawing.Point(178, 1);
		F9B33E81.Name = "ckbWow";
		F9B33E81.Size = new System.Drawing.Size(40, 30);
		F9B33E81.TabIndex = 177;
		F9B33E81.UseVisualStyleBackColor = true;
		ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHaha.Image = C50FB39E.Bitmap_47;
		ckbHaha.Location = new System.Drawing.Point(134, 1);
		ckbHaha.Name = "ckbHaha";
		ckbHaha.Size = new System.Drawing.Size(40, 30);
		ckbHaha.TabIndex = 176;
		ckbHaha.UseVisualStyleBackColor = true;
		ckbThuong.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbThuong.Image = C50FB39E.Bitmap_14;
		ckbThuong.Location = new System.Drawing.Point(90, 1);
		ckbThuong.Name = "ckbThuong";
		ckbThuong.Size = new System.Drawing.Size(40, 30);
		ckbThuong.TabIndex = 175;
		ckbThuong.UseVisualStyleBackColor = true;
		ckbTym.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTym.Image = C50FB39E.Bitmap_153;
		ckbTym.Location = new System.Drawing.Point(46, 1);
		ckbTym.Name = "ckbTym";
		ckbTym.Size = new System.Drawing.Size(40, 30);
		ckbTym.TabIndex = 174;
		ckbTym.UseVisualStyleBackColor = true;
		ckbLike.Checked = true;
		ckbLike.CheckState = System.Windows.Forms.CheckState.Checked;
		ckbLike.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLike.Image = C50FB39E.F2069B3C;
		ckbLike.Location = new System.Drawing.Point(2, 1);
		ckbLike.Name = "ckbLike";
		ckbLike.Size = new System.Drawing.Size(40, 30);
		ckbLike.TabIndex = 173;
		ckbLike.UseVisualStyleBackColor = true;
		panel7.Controls.Add(radioButton3);
		panel7.Controls.Add(FB9DA63A);
		panel7.Location = new System.Drawing.Point(67, 300);
		panel7.Name = "panel7";
		panel7.Size = new System.Drawing.Size(200, 43);
		panel7.TabIndex = 43;
		radioButton3.AutoSize = true;
		radioButton3.Checked = true;
		radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
		radioButton3.Location = new System.Drawing.Point(3, 2);
		radioButton3.Name = "radioButton3";
		radioButton3.Size = new System.Drawing.Size(201, 20);
		radioButton3.TabIndex = 3;
		radioButton3.TabStop = true;
		radioButton3.Text = "Comment theo thứ tự nội dung";
		radioButton3.UseVisualStyleBackColor = true;
		FB9DA63A.AutoSize = true;
		FB9DA63A.Cursor = System.Windows.Forms.Cursors.Hand;
		FB9DA63A.Location = new System.Drawing.Point(3, 23);
		FB9DA63A.Name = "radioButton4";
		FB9DA63A.Size = new System.Drawing.Size(200, 20);
		FB9DA63A.TabIndex = 3;
		FB9DA63A.Text = "Comment ngẫu nhiên nội dung";
		FB9DA63A.UseVisualStyleBackColor = true;
		FB1BE71E.AutoSize = true;
		FB1BE71E.Location = new System.Drawing.Point(4, 302);
		FB1BE71E.Name = "label26";
		FB1BE71E.Size = new System.Drawing.Size(64, 16);
		FB1BE71E.TabIndex = 2;
		FB1BE71E.Text = "Tùy chọn:";
		btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnSave.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
		btnSave.FlatAppearance.BorderSize = 0;
		btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnSave.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnSave.ForeColor = System.Drawing.Color.White;
		btnSave.Location = new System.Drawing.Point(84, 402);
		btnSave.Name = "btnSave";
		btnSave.Size = new System.Drawing.Size(92, 29);
		btnSave.TabIndex = 180;
		btnSave.Text = "Lưu";
		btnSave.UseVisualStyleBackColor = false;
		btnSave.Click += new System.EventHandler(AB8A6788);
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(194, 402);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 181;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnDown.BackgroundImage = C50FB39E.Bitmap_89;
		btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnDown.Location = new System.Drawing.Point(253, -1);
		btnDown.Name = "btnDown";
		btnDown.Size = new System.Drawing.Size(25, 25);
		btnDown.TabIndex = 201;
		btnDown.Click += new System.EventHandler(AB2022B4);
		btnUp.BackgroundImage = C50FB39E.Bitmap_74;
		btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnUp.Location = new System.Drawing.Point(284, -1);
		btnUp.Name = "btnUp";
		btnUp.Size = new System.Drawing.Size(25, 25);
		btnUp.TabIndex = 202;
		btnUp.Click += new System.EventHandler(btnUp_Click);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		BackColor = System.Drawing.Color.White;
		base.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		base.Controls.Add(btnSave);
		base.Controls.Add(btnCancel);
		base.Controls.Add(A1233898);
		base.Controls.Add(plCommentText);
		base.Controls.Add(C131D085);
		base.Controls.Add(ckbTTBVCommentImage);
		base.Controls.Add(ckbTTBVCommentText);
		base.Controls.Add(A73FAC17);
		base.Controls.Add(ckbTTBVInteract);
		base.Controls.Add(F91FB8AA);
		base.Controls.Add(nudTTBVTimeFrom);
		base.Controls.Add(label9);
		base.Controls.Add(A695199D);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Name = "ucTuongTacBaiViet";
		base.Size = new System.Drawing.Size(367, 444);
		base.Load += new System.EventHandler(ucTuongTacBaiViet_Load);
		base.VisibleChanged += new System.EventHandler(B817E015);
		plCommentText.ResumeLayout(false);
		plCommentText.PerformLayout();
		panel3.ResumeLayout(false);
		panel3.PerformLayout();
		C131D085.ResumeLayout(false);
		C131D085.PerformLayout();
		((System.ComponentModel.ISupportInitialize)F91FB8AA).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTTBVTimeFrom).EndInit();
		A1233898.ResumeLayout(false);
		A1233898.PerformLayout();
		panel7.ResumeLayout(false);
		panel7.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}
}
