using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public class F31742AD : UserControl
{
	private GClass11 C118B60B;

	private List<CheckBox> list_0;

	private IContainer icontainer_0 = null;

	private Panel BB967D0C;

	private CheckBox ckbAutoDeleteComment;

	private Button F0938001;

	private LinkLabel linkLabel1;

	private Panel panel3;

	private RadioButton B01FD614;

	private RadioButton B7BB5E12;

	private Label F1B93633;

	private Label CB3D9305;

	private RichTextBox txtTTPComment;

	private Label CFA1DF08;

	private Label lblComment;

	private Panel plCommentImage;

	private TextBox CFA61E0F;

	private Label B5249A39;

	private CheckBox B984AE96;

	private CheckBox C832278B;

	private CheckBox ckbTTPShareWall;

	private CheckBox ckbTTPInteract;

	private ComboBox cbbTTPTuyChonNoiDung;

	private Panel plInteract;

	private CheckBox D68CA61B;

	private CheckBox A2262816;

	private CheckBox ckbWow;

	private CheckBox ckbHaha;

	private CheckBox EC2AA393;

	private CheckBox ckbTym;

	private CheckBox ckbLike;

	private Panel AB80E4AD;

	private RadioButton radioButton3;

	private RadioButton radioButton4;

	private Label label26;

	private Button btnSave;

	private Button AA1C5824;

	private Label C006B09B;

	private NumericUpDown nudTTPDelayTo;

	private NumericUpDown nudTTPSoLuongTo;

	private NumericUpDown nudTTPDelayFrom;

	private NumericUpDown nudTTPSoLuongFrom;

	private Label label3;

	private Label E7AFA732;

	private Label label1;

	public F31742AD(GClass11 BD28830A)
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		C118B60B = BD28830A;
		list_0 = new List<CheckBox> { ckbLike, ckbTym, EC2AA393, ckbHaha, ckbWow, A2262816, D68CA61B };
		B71476AC();
	}

	private void txtTTPComment_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtTTPComment, lblComment, cbbTTPTuyChonNoiDung.SelectedIndex);
	}

	private void B71476AC()
	{
		List<string> list = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		GClass8.smethod_22(cbbTTPTuyChonNoiDung, list);
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.smethod_33(new E3962B82());
	}

	private void F0938001_Click(object sender, EventArgs e)
	{
		if (cbbTTPTuyChonNoiDung.SelectedIndex == 0)
		{
			GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			GClass8.smethod_33(new fHelpNhapComment());
		}
		txtTTPComment.Focus();
	}

	private void CB33E098(object sender, EventArgs e)
	{
		plInteract.Enabled = ckbTTPInteract.Checked;
	}

	private void A9127DB6(object sender, EventArgs e)
	{
		BB967D0C.Enabled = C832278B.Checked;
	}

	private void D61696B0(object sender, EventArgs e)
	{
		plCommentImage.Enabled = B984AE96.Checked;
	}

	private void AA1C5824_Click(object sender, EventArgs e)
	{
		Hide();
	}

	private void F38E143A(object sender, EventArgs e)
	{
		method_0();
		CB33E098(null, null);
		A9127DB6(null, null);
		D61696B0(null, null);
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		method_1();
		Hide();
	}

	private void method_0()
	{
		nudTTPSoLuongFrom.Value = C118B60B.method_2("nudTTPSoLuongFrom", 1);
		nudTTPSoLuongTo.Value = C118B60B.method_2("nudTTPSoLuongTo", 1);
		nudTTPDelayFrom.Value = C118B60B.method_2("nudTTPDelayFrom", 3);
		nudTTPDelayTo.Value = C118B60B.method_2("nudTTPDelayTo", 5);
		ckbTTPInteract.Checked = C118B60B.method_3("ckbTTPInteract");
		string text = C118B60B.C0288288("TTPtypeReaction", "0");
		for (int i = 0; i < list_0.Count; i++)
		{
			list_0[i].Checked = text.Split('|').Contains(i.ToString());
		}
		C832278B.Checked = C118B60B.method_3("ckbTTPCommentText");
		txtTTPComment.Text = C118B60B.C0288288("txtTTPComment");
		cbbTTPTuyChonNoiDung.SelectedIndex = C118B60B.method_2("cbbTTPTuyChonNoiDung");
		B984AE96.Checked = C118B60B.method_3("ckbTTPCommentImage");
		CFA61E0F.Text = C118B60B.C0288288("txtTTPImagePath");
		ckbTTPShareWall.Checked = C118B60B.method_3("ckbTTPShareWall");
	}

	private void method_1()
	{
		C118B60B.method_4("nudTTPSoLuongFrom", nudTTPSoLuongFrom.Value);
		C118B60B.method_4("nudTTPSoLuongTo", nudTTPSoLuongTo.Value);
		C118B60B.method_4("nudTTPDelayFrom", nudTTPDelayFrom.Value);
		C118B60B.method_4("nudTTPDelayTo", nudTTPDelayTo.Value);
		C118B60B.method_4("ckbTTPInteract", ckbTTPInteract.Checked);
		string text = "";
		for (int i = 0; i < list_0.Count; i++)
		{
			if (list_0[i].Checked)
			{
				text = text + i + "|";
			}
		}
		C118B60B.method_4("TTPtypeReaction", text.TrimEnd('|'));
		C118B60B.method_4("ckbTTPCommentText", C832278B.Checked);
		C118B60B.method_4("txtTTPComment", txtTTPComment.Text);
		C118B60B.method_4("cbbTTPTuyChonNoiDung", cbbTTPTuyChonNoiDung.SelectedIndex);
		C118B60B.method_4("ckbTTPCommentImage", B984AE96.Checked);
		C118B60B.method_4("txtTTPImagePath", CFA61E0F.Text);
		C118B60B.method_4("ckbTTPShareWall", ckbTTPShareWall.Checked);
	}

	private void D987770C(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtTTPComment, lblComment, cbbTTPTuyChonNoiDung.SelectedIndex);
	}

	private void F31742AD_VisibleChanged(object sender, EventArgs e)
	{
		if (base.Visible)
		{
			method_0();
		}
	}

	protected override void Dispose(bool ED9B9F84)
	{
		if (ED9B9F84 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(ED9B9F84);
	}

	private void InitializeComponent()
	{
		BB967D0C = new System.Windows.Forms.Panel();
		cbbTTPTuyChonNoiDung = new System.Windows.Forms.ComboBox();
		ckbAutoDeleteComment = new System.Windows.Forms.CheckBox();
		F0938001 = new System.Windows.Forms.Button();
		linkLabel1 = new System.Windows.Forms.LinkLabel();
		panel3 = new System.Windows.Forms.Panel();
		B01FD614 = new System.Windows.Forms.RadioButton();
		B7BB5E12 = new System.Windows.Forms.RadioButton();
		F1B93633 = new System.Windows.Forms.Label();
		txtTTPComment = new System.Windows.Forms.RichTextBox();
		CFA1DF08 = new System.Windows.Forms.Label();
		CB3D9305 = new System.Windows.Forms.Label();
		lblComment = new System.Windows.Forms.Label();
		plCommentImage = new System.Windows.Forms.Panel();
		CFA61E0F = new System.Windows.Forms.TextBox();
		B5249A39 = new System.Windows.Forms.Label();
		B984AE96 = new System.Windows.Forms.CheckBox();
		C832278B = new System.Windows.Forms.CheckBox();
		ckbTTPShareWall = new System.Windows.Forms.CheckBox();
		ckbTTPInteract = new System.Windows.Forms.CheckBox();
		plInteract = new System.Windows.Forms.Panel();
		D68CA61B = new System.Windows.Forms.CheckBox();
		A2262816 = new System.Windows.Forms.CheckBox();
		ckbWow = new System.Windows.Forms.CheckBox();
		ckbHaha = new System.Windows.Forms.CheckBox();
		EC2AA393 = new System.Windows.Forms.CheckBox();
		ckbTym = new System.Windows.Forms.CheckBox();
		ckbLike = new System.Windows.Forms.CheckBox();
		AB80E4AD = new System.Windows.Forms.Panel();
		radioButton3 = new System.Windows.Forms.RadioButton();
		radioButton4 = new System.Windows.Forms.RadioButton();
		label26 = new System.Windows.Forms.Label();
		btnSave = new System.Windows.Forms.Button();
		AA1C5824 = new System.Windows.Forms.Button();
		C006B09B = new System.Windows.Forms.Label();
		nudTTPDelayTo = new System.Windows.Forms.NumericUpDown();
		nudTTPSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudTTPDelayFrom = new System.Windows.Forms.NumericUpDown();
		nudTTPSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		label3 = new System.Windows.Forms.Label();
		E7AFA732 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		BB967D0C.SuspendLayout();
		panel3.SuspendLayout();
		plCommentImage.SuspendLayout();
		plInteract.SuspendLayout();
		AB80E4AD.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudTTPDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTTPSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTTPDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTTPSoLuongFrom).BeginInit();
		SuspendLayout();
		BB967D0C.Anchor = System.Windows.Forms.AnchorStyles.None;
		BB967D0C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		BB967D0C.Controls.Add(cbbTTPTuyChonNoiDung);
		BB967D0C.Controls.Add(ckbAutoDeleteComment);
		BB967D0C.Controls.Add(F0938001);
		BB967D0C.Controls.Add(linkLabel1);
		BB967D0C.Controls.Add(panel3);
		BB967D0C.Controls.Add(F1B93633);
		BB967D0C.Controls.Add(txtTTPComment);
		BB967D0C.Controls.Add(CFA1DF08);
		BB967D0C.Controls.Add(CB3D9305);
		BB967D0C.Controls.Add(lblComment);
		BB967D0C.Location = new System.Drawing.Point(39, 154);
		BB967D0C.Name = "plCommentText";
		BB967D0C.Size = new System.Drawing.Size(310, 184);
		BB967D0C.TabIndex = 176;
		cbbTTPTuyChonNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTTPTuyChonNoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTTPTuyChonNoiDung.FormattingEnabled = true;
		cbbTTPTuyChonNoiDung.Location = new System.Drawing.Point(82, 153);
		cbbTTPTuyChonNoiDung.Name = "cbbTTPTuyChonNoiDung";
		cbbTTPTuyChonNoiDung.Size = new System.Drawing.Size(190, 24);
		cbbTTPTuyChonNoiDung.TabIndex = 177;
		cbbTTPTuyChonNoiDung.SelectedIndexChanged += new System.EventHandler(D987770C);
		ckbAutoDeleteComment.AutoSize = true;
		ckbAutoDeleteComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAutoDeleteComment.Location = new System.Drawing.Point(8, 182);
		ckbAutoDeleteComment.Name = "ckbAutoDeleteComment";
		ckbAutoDeleteComment.Size = new System.Drawing.Size(225, 20);
		ckbAutoDeleteComment.TabIndex = 176;
		ckbAutoDeleteComment.Text = "Tự động xóa nội dung đã bình luận";
		ckbAutoDeleteComment.UseVisualStyleBackColor = true;
		F0938001.Cursor = System.Windows.Forms.Cursors.Hand;
		F0938001.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F0938001.Location = new System.Drawing.Point(278, 152);
		F0938001.Name = "btnHuongDanNhapNoiDung";
		F0938001.Size = new System.Drawing.Size(26, 26);
		F0938001.TabIndex = 173;
		F0938001.Text = "?";
		F0938001.UseVisualStyleBackColor = true;
		F0938001.Click += new System.EventHandler(F0938001_Click);
		linkLabel1.AutoSize = true;
		linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		linkLabel1.Location = new System.Drawing.Point(223, 129);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new System.Drawing.Size(81, 16);
		linkLabel1.TabIndex = 175;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "Random icon";
		linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		panel3.Controls.Add(B01FD614);
		panel3.Controls.Add(B7BB5E12);
		panel3.Location = new System.Drawing.Point(66, 397);
		panel3.Name = "panel3";
		panel3.Size = new System.Drawing.Size(200, 43);
		panel3.TabIndex = 43;
		B01FD614.AutoSize = true;
		B01FD614.Checked = true;
		B01FD614.Cursor = System.Windows.Forms.Cursors.Hand;
		B01FD614.Location = new System.Drawing.Point(3, 2);
		B01FD614.Name = "rbCommentTheoThuTu";
		B01FD614.Size = new System.Drawing.Size(201, 20);
		B01FD614.TabIndex = 3;
		B01FD614.TabStop = true;
		B01FD614.Text = "Comment theo thứ tự nội dung";
		B01FD614.UseVisualStyleBackColor = true;
		B7BB5E12.AutoSize = true;
		B7BB5E12.Cursor = System.Windows.Forms.Cursors.Hand;
		B7BB5E12.Location = new System.Drawing.Point(3, 23);
		B7BB5E12.Name = "rbCommentNgauNhien";
		B7BB5E12.Size = new System.Drawing.Size(200, 20);
		B7BB5E12.TabIndex = 3;
		B7BB5E12.Text = "Comment ngẫu nhiên nội dung";
		B7BB5E12.UseVisualStyleBackColor = true;
		F1B93633.AutoSize = true;
		F1B93633.Location = new System.Drawing.Point(3, 399);
		F1B93633.Name = "label13";
		F1B93633.Size = new System.Drawing.Size(64, 16);
		F1B93633.TabIndex = 2;
		F1B93633.Text = "Tùy chọn:";
		txtTTPComment.Location = new System.Drawing.Point(7, 24);
		txtTTPComment.Name = "txtTTPComment";
		txtTTPComment.Size = new System.Drawing.Size(297, 102);
		txtTTPComment.TabIndex = 1;
		txtTTPComment.Text = "";
		txtTTPComment.WordWrap = false;
		txtTTPComment.TextChanged += new System.EventHandler(txtTTPComment_TextChanged);
		CFA1DF08.AutoSize = true;
		CFA1DF08.Location = new System.Drawing.Point(5, 129);
		CFA1DF08.Name = "label11";
		CFA1DF08.Size = new System.Drawing.Size(143, 16);
		CFA1DF08.TabIndex = 0;
		CFA1DF08.Text = "(Spin nội dung {a|b|c})";
		CB3D9305.AutoSize = true;
		CB3D9305.Location = new System.Drawing.Point(5, 156);
		CB3D9305.Name = "label8";
		CB3D9305.Size = new System.Drawing.Size(64, 16);
		CB3D9305.TabIndex = 2;
		CB3D9305.Text = "Tùy chọn:";
		lblComment.AutoSize = true;
		lblComment.Location = new System.Drawing.Point(3, 4);
		lblComment.Name = "lblComment";
		lblComment.Size = new System.Drawing.Size(139, 16);
		lblComment.TabIndex = 0;
		lblComment.Text = "Nội dung bình luận (0):";
		plCommentImage.Anchor = System.Windows.Forms.AnchorStyles.None;
		plCommentImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plCommentImage.Controls.Add(CFA61E0F);
		plCommentImage.Controls.Add(B5249A39);
		plCommentImage.Enabled = false;
		plCommentImage.Location = new System.Drawing.Point(39, 366);
		plCommentImage.Name = "plCommentImage";
		plCommentImage.Size = new System.Drawing.Size(310, 31);
		plCommentImage.TabIndex = 178;
		CFA61E0F.Location = new System.Drawing.Point(82, 3);
		CFA61E0F.Name = "txtTTPImagePath";
		CFA61E0F.Size = new System.Drawing.Size(222, 23);
		CFA61E0F.TabIndex = 155;
		B5249A39.AutoSize = true;
		B5249A39.Location = new System.Drawing.Point(3, 6);
		B5249A39.Name = "label12";
		B5249A39.Size = new System.Drawing.Size(73, 16);
		B5249A39.TabIndex = 39;
		B5249A39.Text = "Folder ảnh:";
		B984AE96.Anchor = System.Windows.Forms.AnchorStyles.None;
		B984AE96.AutoSize = true;
		B984AE96.Cursor = System.Windows.Forms.Cursors.Hand;
		B984AE96.Location = new System.Drawing.Point(21, 343);
		B984AE96.Name = "ckbTTPCommentImage";
		B984AE96.Size = new System.Drawing.Size(103, 20);
		B984AE96.TabIndex = 177;
		B984AE96.Text = "Bình luận ảnh";
		B984AE96.UseVisualStyleBackColor = true;
		B984AE96.CheckedChanged += new System.EventHandler(D61696B0);
		C832278B.Anchor = System.Windows.Forms.AnchorStyles.None;
		C832278B.AutoSize = true;
		C832278B.Cursor = System.Windows.Forms.Cursors.Hand;
		C832278B.Location = new System.Drawing.Point(21, 132);
		C832278B.Name = "ckbTTPCommentText";
		C832278B.Size = new System.Drawing.Size(127, 20);
		C832278B.TabIndex = 174;
		C832278B.Text = "Bi\u0300nh luâ\u0323n văn bản";
		C832278B.UseVisualStyleBackColor = true;
		C832278B.CheckedChanged += new System.EventHandler(A9127DB6);
		ckbTTPShareWall.Anchor = System.Windows.Forms.AnchorStyles.None;
		ckbTTPShareWall.AutoSize = true;
		ckbTTPShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTTPShareWall.Location = new System.Drawing.Point(21, 401);
		ckbTTPShareWall.Name = "ckbTTPShareWall";
		ckbTTPShareWall.Size = new System.Drawing.Size(143, 20);
		ckbTTPShareWall.TabIndex = 170;
		ckbTTPShareWall.Text = "Chia sẻ bài về tường";
		ckbTTPShareWall.UseVisualStyleBackColor = true;
		ckbTTPInteract.Anchor = System.Windows.Forms.AnchorStyles.None;
		ckbTTPInteract.AutoSize = true;
		ckbTTPInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTTPInteract.Location = new System.Drawing.Point(21, 73);
		ckbTTPInteract.Name = "ckbTTPInteract";
		ckbTTPInteract.Size = new System.Drawing.Size(112, 20);
		ckbTTPInteract.TabIndex = 169;
		ckbTTPInteract.Text = "Bày tỏ cảm xúc";
		ckbTTPInteract.UseVisualStyleBackColor = true;
		ckbTTPInteract.CheckedChanged += new System.EventHandler(CB33E098);
		plInteract.Anchor = System.Windows.Forms.AnchorStyles.None;
		plInteract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plInteract.Controls.Add(D68CA61B);
		plInteract.Controls.Add(A2262816);
		plInteract.Controls.Add(ckbWow);
		plInteract.Controls.Add(ckbHaha);
		plInteract.Controls.Add(EC2AA393);
		plInteract.Controls.Add(ckbTym);
		plInteract.Controls.Add(ckbLike);
		plInteract.Controls.Add(AB80E4AD);
		plInteract.Controls.Add(label26);
		plInteract.Location = new System.Drawing.Point(39, 94);
		plInteract.Name = "plInteract";
		plInteract.Size = new System.Drawing.Size(310, 33);
		plInteract.TabIndex = 179;
		D68CA61B.Cursor = System.Windows.Forms.Cursors.Hand;
		D68CA61B.Image = C50FB39E.ABB95605;
		D68CA61B.Location = new System.Drawing.Point(266, 1);
		D68CA61B.Name = "ckbGian";
		D68CA61B.Size = new System.Drawing.Size(40, 30);
		D68CA61B.TabIndex = 179;
		D68CA61B.UseVisualStyleBackColor = true;
		A2262816.Cursor = System.Windows.Forms.Cursors.Hand;
		A2262816.Image = C50FB39E.Bitmap_163;
		A2262816.Location = new System.Drawing.Point(222, 1);
		A2262816.Name = "ckbBuon";
		A2262816.Size = new System.Drawing.Size(40, 30);
		A2262816.TabIndex = 178;
		A2262816.UseVisualStyleBackColor = true;
		ckbWow.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbWow.Image = C50FB39E.F10C2BBC;
		ckbWow.Location = new System.Drawing.Point(178, 1);
		ckbWow.Name = "ckbWow";
		ckbWow.Size = new System.Drawing.Size(40, 30);
		ckbWow.TabIndex = 177;
		ckbWow.UseVisualStyleBackColor = true;
		ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHaha.Image = C50FB39E.Bitmap_47;
		ckbHaha.Location = new System.Drawing.Point(134, 1);
		ckbHaha.Name = "ckbHaha";
		ckbHaha.Size = new System.Drawing.Size(40, 30);
		ckbHaha.TabIndex = 176;
		ckbHaha.UseVisualStyleBackColor = true;
		EC2AA393.Cursor = System.Windows.Forms.Cursors.Hand;
		EC2AA393.Image = C50FB39E.Bitmap_14;
		EC2AA393.Location = new System.Drawing.Point(90, 1);
		EC2AA393.Name = "ckbThuong";
		EC2AA393.Size = new System.Drawing.Size(40, 30);
		EC2AA393.TabIndex = 175;
		EC2AA393.UseVisualStyleBackColor = true;
		ckbTym.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTym.Image = C50FB39E.Bitmap_153;
		ckbTym.Location = new System.Drawing.Point(46, 1);
		ckbTym.Name = "ckbTym";
		ckbTym.Size = new System.Drawing.Size(40, 30);
		ckbTym.TabIndex = 174;
		ckbTym.UseVisualStyleBackColor = true;
		ckbLike.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLike.Image = C50FB39E.F2069B3C;
		ckbLike.Location = new System.Drawing.Point(2, 1);
		ckbLike.Name = "ckbLike";
		ckbLike.Size = new System.Drawing.Size(40, 30);
		ckbLike.TabIndex = 173;
		ckbLike.UseVisualStyleBackColor = true;
		AB80E4AD.Controls.Add(radioButton3);
		AB80E4AD.Controls.Add(radioButton4);
		AB80E4AD.Location = new System.Drawing.Point(67, 300);
		AB80E4AD.Name = "panel7";
		AB80E4AD.Size = new System.Drawing.Size(200, 43);
		AB80E4AD.TabIndex = 43;
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
		radioButton4.AutoSize = true;
		radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
		radioButton4.Location = new System.Drawing.Point(3, 23);
		radioButton4.Name = "radioButton4";
		radioButton4.Size = new System.Drawing.Size(200, 20);
		radioButton4.TabIndex = 3;
		radioButton4.Text = "Comment ngẫu nhiên nội dung";
		radioButton4.UseVisualStyleBackColor = true;
		label26.AutoSize = true;
		label26.Location = new System.Drawing.Point(4, 302);
		label26.Name = "label26";
		label26.Size = new System.Drawing.Size(64, 16);
		label26.TabIndex = 2;
		label26.Text = "Tùy chọn:";
		btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnSave.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
		btnSave.FlatAppearance.BorderSize = 0;
		btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnSave.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnSave.ForeColor = System.Drawing.Color.White;
		btnSave.Location = new System.Drawing.Point(84, 433);
		btnSave.Name = "btnSave";
		btnSave.Size = new System.Drawing.Size(92, 29);
		btnSave.TabIndex = 180;
		btnSave.Text = "Lưu";
		btnSave.UseVisualStyleBackColor = false;
		btnSave.Click += new System.EventHandler(btnSave_Click);
		AA1C5824.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		AA1C5824.BackColor = System.Drawing.Color.Maroon;
		AA1C5824.Cursor = System.Windows.Forms.Cursors.Hand;
		AA1C5824.FlatAppearance.BorderSize = 0;
		AA1C5824.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		AA1C5824.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		AA1C5824.ForeColor = System.Drawing.Color.White;
		AA1C5824.Location = new System.Drawing.Point(194, 433);
		AA1C5824.Name = "btnCancel";
		AA1C5824.Size = new System.Drawing.Size(92, 29);
		AA1C5824.TabIndex = 181;
		AA1C5824.Text = "Đóng";
		AA1C5824.UseVisualStyleBackColor = false;
		AA1C5824.Click += new System.EventHandler(AA1C5824_Click);
		C006B09B.Anchor = System.Windows.Forms.AnchorStyles.None;
		C006B09B.AutoSize = true;
		C006B09B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		C006B09B.Location = new System.Drawing.Point(18, 17);
		C006B09B.Name = "label19";
		C006B09B.Size = new System.Drawing.Size(72, 16);
		C006B09B.TabIndex = 191;
		C006B09B.Text = "Sô\u0301 ba\u0300i viết:";
		nudTTPDelayTo.Anchor = System.Windows.Forms.AnchorStyles.None;
		nudTTPDelayTo.Location = new System.Drawing.Point(230, 44);
		nudTTPDelayTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudTTPDelayTo.Name = "nudTTPDelayTo";
		nudTTPDelayTo.Size = new System.Drawing.Size(56, 23);
		nudTTPDelayTo.TabIndex = 185;
		nudTTPSoLuongTo.Anchor = System.Windows.Forms.AnchorStyles.None;
		nudTTPSoLuongTo.Location = new System.Drawing.Point(230, 15);
		nudTTPSoLuongTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudTTPSoLuongTo.Name = "nudTTPSoLuongTo";
		nudTTPSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudTTPSoLuongTo.TabIndex = 183;
		nudTTPDelayFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
		nudTTPDelayFrom.Location = new System.Drawing.Point(133, 44);
		nudTTPDelayFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudTTPDelayFrom.Name = "nudTTPDelayFrom";
		nudTTPDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudTTPDelayFrom.TabIndex = 184;
		nudTTPSoLuongFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
		nudTTPSoLuongFrom.Location = new System.Drawing.Point(133, 15);
		nudTTPSoLuongFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudTTPSoLuongFrom.Name = "nudTTPSoLuongFrom";
		nudTTPSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudTTPSoLuongFrom.TabIndex = 182;
		label3.Anchor = System.Windows.Forms.AnchorStyles.None;
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(195, 17);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 189;
		label3.Text = ">";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		E7AFA732.Anchor = System.Windows.Forms.AnchorStyles.None;
		E7AFA732.AutoSize = true;
		E7AFA732.Location = new System.Drawing.Point(18, 46);
		E7AFA732.Name = "label5";
		E7AFA732.Size = new System.Drawing.Size(109, 16);
		E7AFA732.TabIndex = 186;
		E7AFA732.Text = "Thơ\u0300i gian chơ\u0300 (s):";
		label1.Anchor = System.Windows.Forms.AnchorStyles.None;
		label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label1.Location = new System.Drawing.Point(195, 46);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(29, 16);
		label1.TabIndex = 189;
		label1.Text = ">";
		label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		BackColor = System.Drawing.Color.White;
		base.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		base.Controls.Add(C006B09B);
		base.Controls.Add(nudTTPDelayTo);
		base.Controls.Add(nudTTPSoLuongTo);
		base.Controls.Add(nudTTPDelayFrom);
		base.Controls.Add(nudTTPSoLuongFrom);
		base.Controls.Add(label1);
		base.Controls.Add(label3);
		base.Controls.Add(E7AFA732);
		base.Controls.Add(btnSave);
		base.Controls.Add(AA1C5824);
		base.Controls.Add(plInteract);
		base.Controls.Add(BB967D0C);
		base.Controls.Add(plCommentImage);
		base.Controls.Add(B984AE96);
		base.Controls.Add(C832278B);
		base.Controls.Add(ckbTTPShareWall);
		base.Controls.Add(ckbTTPInteract);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Name = "ucTuongTacProfile";
		base.Size = new System.Drawing.Size(367, 475);
		base.Load += new System.EventHandler(F38E143A);
		base.VisibleChanged += new System.EventHandler(F31742AD_VisibleChanged);
		BB967D0C.ResumeLayout(false);
		BB967D0C.PerformLayout();
		panel3.ResumeLayout(false);
		panel3.PerformLayout();
		plCommentImage.ResumeLayout(false);
		plCommentImage.PerformLayout();
		plInteract.ResumeLayout(false);
		plInteract.PerformLayout();
		AB80E4AD.ResumeLayout(false);
		AB80E4AD.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudTTPDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTTPSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTTPDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTTPSoLuongFrom).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
