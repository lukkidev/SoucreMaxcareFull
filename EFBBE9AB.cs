using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public class EFBBE9AB : UserControl
{
	private GClass11 gclass11_0;

	private List<CheckBox> list_0;

	private IContainer AD10A10A = null;

	private Panel panel2;

	private Panel plShareWall;

	private NumericUpDown BC33D127;

	private Label F11A429E;

	private Label label4;

	private NumericUpDown AE005632;

	private CheckBox ckbInteract;

	private NumericUpDown nudTimeFrom;

	private Label label9;

	private CheckBox ckbComment;

	private CheckBox ckbShareWall;

	private CheckBox A9ACC58A;

	private Panel B8026A04;

	private NumericUpDown nudPercentLike;

	private CheckBox ckbAngry;

	private Label label11;

	private CheckBox CC0DA8AC;

	private CheckBox ckbWow;

	private CheckBox D6ABAF81;

	private CheckBox B3AFCFB7;

	private CheckBox ckbLove;

	private CheckBox ckbLike;

	private Panel CD35E50A;

	private RadioButton B48C6830;

	private RadioButton radioButton4;

	private Label EC0C0000;

	private Panel plAnh;

	private NumericUpDown D8981D99;

	private TextBox txtAnh;

	private Label label14;

	private Label label12;

	private Panel plComment;

	private NumericUpDown DFAED832;

	private ComboBox cbbTuyChonNoiDung;

	private Label label13;

	private Button btnHuongDanNhapNoiDung;

	private Label CC9749A9;

	private Button btnDown;

	private Button E59B0705;

	private RichTextBox txtComment;

	private Label DF22B201;

	private CheckBox B9BDE7AA;

	public EFBBE9AB()
	{
		InitializeComponent();
	}

	public EFBBE9AB(GClass11 gclass11_1)
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		gclass11_0 = gclass11_1;
		list_0 = new List<CheckBox> { ckbLike, ckbLove, B3AFCFB7, D6ABAF81, ckbWow, CC0DA8AC, ckbAngry };
	}

	private void ckbInteract_CheckedChanged(object sender, EventArgs e)
	{
		B8026A04.Enabled = ckbInteract.Checked;
	}

	private void A9ACC58A_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = A9ACC58A.Checked;
	}

	private void B71081A6(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void ckbShareWall_CheckedChanged(object sender, EventArgs e)
	{
		plShareWall.Enabled = ckbShareWall.Checked;
	}

	private void C9B3319D(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtComment, DF22B201, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void cbbTuyChonNoiDung_SelectedIndexChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtComment, DF22B201, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void btnHuongDanNhapNoiDung_Click(object sender, EventArgs e)
	{
		if (cbbTuyChonNoiDung.SelectedIndex == 0)
		{
			GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			GClass8.smethod_33(new fHelpNhapComment());
		}
		txtComment.Focus();
	}

	private void EFBBE9AB_Load(object sender, EventArgs e)
	{
		method_0();
		try
		{
			nudTimeFrom.Value = gclass11_0.method_2("nudTimeFrom", 3);
			AE005632.Value = gclass11_0.method_2("nudTimeTo", 5);
			ckbInteract.Checked = gclass11_0.method_3("ckbInteract");
			nudPercentLike.Value = gclass11_0.method_2("nudPercentLike", 100);
			string text = gclass11_0.C0288288("typeReaction", "Like");
			List<string> list = text.Split('|').ToList();
			for (int i = 0; i < list.Count; i++)
			{
				foreach (CheckBox item in list_0)
				{
					if (item.Name.Substring(3) == list[i])
					{
						item.Checked = true;
					}
				}
			}
			ckbShareWall.Checked = gclass11_0.method_3("ckbShareWall");
			BC33D127.Value = gclass11_0.method_2("nudPercentShareWall", 100);
			A9ACC58A.Checked = gclass11_0.method_3("ckbSendAnh");
			D8981D99.Value = gclass11_0.method_2("nudPercentCommentImage", 100);
			txtAnh.Text = gclass11_0.C0288288("txtAnh");
			ckbComment.Checked = gclass11_0.method_3("ckbComment");
			DFAED832.Value = gclass11_0.method_2("nudPercentCommentText", 100);
			txtComment.Text = gclass11_0.C0288288("txtComment");
			cbbTuyChonNoiDung.SelectedIndex = gclass11_0.method_2("typeNganCach");
		}
		catch
		{
		}
		BA877C3A();
	}

	private void method_0()
	{
		List<string> list = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		GClass8.smethod_22(cbbTuyChonNoiDung, list);
	}

	private void BA877C3A()
	{
		ckbInteract_CheckedChanged(null, null);
		B71081A6(null, null);
		A9ACC58A_CheckedChanged(null, null);
		ckbShareWall_CheckedChanged(null, null);
	}

	public GClass11 F0B0B700()
	{
		gclass11_0.method_4("nudTimeFrom", nudTimeFrom.Value);
		gclass11_0.method_4("nudTimeTo", AE005632.Value);
		gclass11_0.method_4("ckbInteract", ckbInteract.Checked);
		gclass11_0.method_4("nudPercentLike", nudPercentLike.Value);
		string text = "";
		for (int i = 0; i < list_0.Count; i++)
		{
			if (list_0[i].Checked)
			{
				text = text + list_0[i].Name.Substring(3) + "|";
			}
		}
		gclass11_0.method_4("typeReaction", text.TrimEnd('|'));
		gclass11_0.method_4("ckbSendAnh", A9ACC58A.Checked);
		gclass11_0.method_4("nudPercentCommentImage", D8981D99.Value);
		gclass11_0.method_4("txtAnh", txtAnh.Text.Trim());
		gclass11_0.method_4("ckbShareWall", ckbShareWall.Checked);
		gclass11_0.method_4("nudPercentShareWall", BC33D127.Value);
		gclass11_0.method_4("ckbComment", ckbComment.Checked);
		gclass11_0.method_4("nudPercentCommentText", DFAED832.Value);
		gclass11_0.method_4("txtComment", txtComment.Text.Trim());
		gclass11_0.method_4("typeNganCach", cbbTuyChonNoiDung.SelectedIndex);
		return gclass11_0;
	}

	protected override void Dispose(bool CE0C273A)
	{
		if (CE0C273A && AD10A10A != null)
		{
			AD10A10A.Dispose();
		}
		base.Dispose(CE0C273A);
	}

	private void InitializeComponent()
	{
		panel2 = new System.Windows.Forms.Panel();
		plShareWall = new System.Windows.Forms.Panel();
		BC33D127 = new System.Windows.Forms.NumericUpDown();
		F11A429E = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		AE005632 = new System.Windows.Forms.NumericUpDown();
		ckbInteract = new System.Windows.Forms.CheckBox();
		nudTimeFrom = new System.Windows.Forms.NumericUpDown();
		label9 = new System.Windows.Forms.Label();
		ckbComment = new System.Windows.Forms.CheckBox();
		ckbShareWall = new System.Windows.Forms.CheckBox();
		A9ACC58A = new System.Windows.Forms.CheckBox();
		B8026A04 = new System.Windows.Forms.Panel();
		nudPercentLike = new System.Windows.Forms.NumericUpDown();
		ckbAngry = new System.Windows.Forms.CheckBox();
		label11 = new System.Windows.Forms.Label();
		CC0DA8AC = new System.Windows.Forms.CheckBox();
		ckbWow = new System.Windows.Forms.CheckBox();
		D6ABAF81 = new System.Windows.Forms.CheckBox();
		B3AFCFB7 = new System.Windows.Forms.CheckBox();
		ckbLove = new System.Windows.Forms.CheckBox();
		ckbLike = new System.Windows.Forms.CheckBox();
		CD35E50A = new System.Windows.Forms.Panel();
		B48C6830 = new System.Windows.Forms.RadioButton();
		radioButton4 = new System.Windows.Forms.RadioButton();
		EC0C0000 = new System.Windows.Forms.Label();
		plAnh = new System.Windows.Forms.Panel();
		D8981D99 = new System.Windows.Forms.NumericUpDown();
		txtAnh = new System.Windows.Forms.TextBox();
		label14 = new System.Windows.Forms.Label();
		label12 = new System.Windows.Forms.Label();
		plComment = new System.Windows.Forms.Panel();
		DFAED832 = new System.Windows.Forms.NumericUpDown();
		cbbTuyChonNoiDung = new System.Windows.Forms.ComboBox();
		label13 = new System.Windows.Forms.Label();
		btnHuongDanNhapNoiDung = new System.Windows.Forms.Button();
		CC9749A9 = new System.Windows.Forms.Label();
		btnDown = new System.Windows.Forms.Button();
		E59B0705 = new System.Windows.Forms.Button();
		txtComment = new System.Windows.Forms.RichTextBox();
		DF22B201 = new System.Windows.Forms.Label();
		B9BDE7AA = new System.Windows.Forms.CheckBox();
		panel2.SuspendLayout();
		plShareWall.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)BC33D127).BeginInit();
		((System.ComponentModel.ISupportInitialize)AE005632).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).BeginInit();
		B8026A04.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudPercentLike).BeginInit();
		CD35E50A.SuspendLayout();
		plAnh.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)D8981D99).BeginInit();
		plComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)DFAED832).BeginInit();
		SuspendLayout();
		panel2.Controls.Add(plShareWall);
		panel2.Controls.Add(label4);
		panel2.Controls.Add(AE005632);
		panel2.Controls.Add(ckbInteract);
		panel2.Controls.Add(nudTimeFrom);
		panel2.Controls.Add(label9);
		panel2.Controls.Add(ckbComment);
		panel2.Controls.Add(ckbShareWall);
		panel2.Controls.Add(A9ACC58A);
		panel2.Controls.Add(B8026A04);
		panel2.Controls.Add(plAnh);
		panel2.Controls.Add(plComment);
		panel2.Location = new System.Drawing.Point(0, 0);
		panel2.Name = "panel2";
		panel2.Size = new System.Drawing.Size(656, 266);
		panel2.TabIndex = 194;
		plShareWall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plShareWall.Controls.Add(BC33D127);
		plShareWall.Controls.Add(F11A429E);
		plShareWall.Location = new System.Drawing.Point(6, 230);
		plShareWall.Name = "plShareWall";
		plShareWall.Size = new System.Drawing.Size(313, 29);
		plShareWall.TabIndex = 197;
		BC33D127.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		BC33D127.Location = new System.Drawing.Point(112, 2);
		BC33D127.Name = "nudPercentShareWall";
		BC33D127.Size = new System.Drawing.Size(42, 23);
		BC33D127.TabIndex = 189;
		BC33D127.Value = new decimal(new int[4] { 100, 0, 0, 0 });
		F11A429E.AutoSize = true;
		F11A429E.Location = new System.Drawing.Point(1, 5);
		F11A429E.Name = "label15";
		F11A429E.Size = new System.Drawing.Size(112, 16);
		F11A429E.TabIndex = 191;
		F11A429E.Text = "Xa\u0301c suâ\u0301t la\u0300m (%):";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(3, 7);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(103, 16);
		label4.TabIndex = 191;
		label4.Text = "Xem bài viết (s):";
		AE005632.Location = new System.Drawing.Point(205, 5);
		AE005632.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		AE005632.Name = "nudTimeTo";
		AE005632.Size = new System.Drawing.Size(56, 23);
		AE005632.TabIndex = 190;
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(6, 30);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(99, 20);
		ckbInteract.TabIndex = 182;
		ckbInteract.Text = "Thả cảm xúc";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += new System.EventHandler(ckbInteract_CheckedChanged);
		nudTimeFrom.Location = new System.Drawing.Point(108, 5);
		nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeFrom.Name = "nudTimeFrom";
		nudTimeFrom.Size = new System.Drawing.Size(56, 23);
		nudTimeFrom.TabIndex = 189;
		label9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label9.Location = new System.Drawing.Point(170, 7);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(29, 16);
		label9.TabIndex = 192;
		label9.Text = ">";
		label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		ckbComment.AutoSize = true;
		ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbComment.Location = new System.Drawing.Point(347, 30);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new System.Drawing.Size(127, 20);
		ckbComment.TabIndex = 184;
		ckbComment.Text = "Bi\u0300nh luâ\u0323n văn bản";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += new System.EventHandler(B71081A6);
		ckbShareWall.AutoSize = true;
		ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbShareWall.Location = new System.Drawing.Point(6, 208);
		ckbShareWall.Name = "ckbShareWall";
		ckbShareWall.Size = new System.Drawing.Size(87, 20);
		ckbShareWall.TabIndex = 183;
		ckbShareWall.Text = "Share wall";
		ckbShareWall.UseVisualStyleBackColor = true;
		ckbShareWall.CheckedChanged += new System.EventHandler(ckbShareWall_CheckedChanged);
		A9ACC58A.AutoSize = true;
		A9ACC58A.Cursor = System.Windows.Forms.Cursors.Hand;
		A9ACC58A.Location = new System.Drawing.Point(6, 118);
		A9ACC58A.Name = "ckbSendAnh";
		A9ACC58A.Size = new System.Drawing.Size(103, 20);
		A9ACC58A.TabIndex = 186;
		A9ACC58A.Text = "Bình luận ảnh";
		A9ACC58A.UseVisualStyleBackColor = true;
		A9ACC58A.CheckedChanged += new System.EventHandler(A9ACC58A_CheckedChanged);
		B8026A04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		B8026A04.Controls.Add(nudPercentLike);
		B8026A04.Controls.Add(ckbAngry);
		B8026A04.Controls.Add(label11);
		B8026A04.Controls.Add(CC0DA8AC);
		B8026A04.Controls.Add(ckbWow);
		B8026A04.Controls.Add(D6ABAF81);
		B8026A04.Controls.Add(B3AFCFB7);
		B8026A04.Controls.Add(ckbLove);
		B8026A04.Controls.Add(ckbLike);
		B8026A04.Controls.Add(CD35E50A);
		B8026A04.Controls.Add(EC0C0000);
		B8026A04.Location = new System.Drawing.Point(6, 52);
		B8026A04.Name = "plInteract";
		B8026A04.Size = new System.Drawing.Size(313, 60);
		B8026A04.TabIndex = 188;
		nudPercentLike.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		nudPercentLike.Location = new System.Drawing.Point(112, 4);
		nudPercentLike.Name = "nudPercentLike";
		nudPercentLike.Size = new System.Drawing.Size(42, 23);
		nudPercentLike.TabIndex = 189;
		nudPercentLike.Value = new decimal(new int[4] { 100, 0, 0, 0 });
		ckbAngry.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		ckbAngry.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAngry.Image = C50FB39E.ABB95605;
		ckbAngry.Location = new System.Drawing.Point(269, 28);
		ckbAngry.Name = "ckbAngry";
		ckbAngry.Size = new System.Drawing.Size(40, 30);
		ckbAngry.TabIndex = 179;
		ckbAngry.Tag = "Angry";
		ckbAngry.UseVisualStyleBackColor = true;
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(3, 6);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(112, 16);
		label11.TabIndex = 191;
		label11.Text = "Xa\u0301c suâ\u0301t la\u0300m (%):";
		CC0DA8AC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		CC0DA8AC.Cursor = System.Windows.Forms.Cursors.Hand;
		CC0DA8AC.Image = C50FB39E.Bitmap_163;
		CC0DA8AC.Location = new System.Drawing.Point(225, 28);
		CC0DA8AC.Name = "ckbSad";
		CC0DA8AC.Size = new System.Drawing.Size(40, 30);
		CC0DA8AC.TabIndex = 178;
		CC0DA8AC.Tag = "Sad";
		CC0DA8AC.UseVisualStyleBackColor = true;
		ckbWow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		ckbWow.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbWow.Image = C50FB39E.F10C2BBC;
		ckbWow.Location = new System.Drawing.Point(181, 28);
		ckbWow.Name = "ckbWow";
		ckbWow.Size = new System.Drawing.Size(40, 30);
		ckbWow.TabIndex = 177;
		ckbWow.Tag = "Wow";
		ckbWow.UseVisualStyleBackColor = true;
		D6ABAF81.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		D6ABAF81.Cursor = System.Windows.Forms.Cursors.Hand;
		D6ABAF81.Image = C50FB39E.Bitmap_47;
		D6ABAF81.Location = new System.Drawing.Point(137, 28);
		D6ABAF81.Name = "ckbHaha";
		D6ABAF81.Size = new System.Drawing.Size(40, 30);
		D6ABAF81.TabIndex = 176;
		D6ABAF81.Tag = "Haha";
		D6ABAF81.UseVisualStyleBackColor = true;
		B3AFCFB7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		B3AFCFB7.Cursor = System.Windows.Forms.Cursors.Hand;
		B3AFCFB7.Image = C50FB39E.Bitmap_14;
		B3AFCFB7.Location = new System.Drawing.Point(93, 28);
		B3AFCFB7.Name = "ckbCare";
		B3AFCFB7.Size = new System.Drawing.Size(40, 30);
		B3AFCFB7.TabIndex = 175;
		B3AFCFB7.Tag = "Care";
		B3AFCFB7.UseVisualStyleBackColor = true;
		ckbLove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		ckbLove.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLove.Image = C50FB39E.Bitmap_153;
		ckbLove.Location = new System.Drawing.Point(49, 28);
		ckbLove.Name = "ckbLove";
		ckbLove.Size = new System.Drawing.Size(40, 30);
		ckbLove.TabIndex = 174;
		ckbLove.Tag = "Love";
		ckbLove.UseVisualStyleBackColor = true;
		ckbLike.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		ckbLike.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLike.Image = C50FB39E.F2069B3C;
		ckbLike.Location = new System.Drawing.Point(5, 28);
		ckbLike.Name = "ckbLike";
		ckbLike.Size = new System.Drawing.Size(40, 30);
		ckbLike.TabIndex = 173;
		ckbLike.Tag = "Like";
		ckbLike.UseVisualStyleBackColor = true;
		CD35E50A.Controls.Add(B48C6830);
		CD35E50A.Controls.Add(radioButton4);
		CD35E50A.Location = new System.Drawing.Point(67, 300);
		CD35E50A.Name = "panel7";
		CD35E50A.Size = new System.Drawing.Size(200, 43);
		CD35E50A.TabIndex = 43;
		B48C6830.AutoSize = true;
		B48C6830.Checked = true;
		B48C6830.Cursor = System.Windows.Forms.Cursors.Hand;
		B48C6830.Location = new System.Drawing.Point(3, 2);
		B48C6830.Name = "radioButton3";
		B48C6830.Size = new System.Drawing.Size(201, 20);
		B48C6830.TabIndex = 3;
		B48C6830.TabStop = true;
		B48C6830.Text = "Comment theo thứ tự nội dung";
		B48C6830.UseVisualStyleBackColor = true;
		radioButton4.AutoSize = true;
		radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
		radioButton4.Location = new System.Drawing.Point(3, 23);
		radioButton4.Name = "radioButton4";
		radioButton4.Size = new System.Drawing.Size(200, 20);
		radioButton4.TabIndex = 3;
		radioButton4.Text = "Comment ngẫu nhiên nội dung";
		radioButton4.UseVisualStyleBackColor = true;
		EC0C0000.AutoSize = true;
		EC0C0000.Location = new System.Drawing.Point(4, 302);
		EC0C0000.Name = "label26";
		EC0C0000.Size = new System.Drawing.Size(64, 16);
		EC0C0000.TabIndex = 2;
		EC0C0000.Text = "Tùy chọn:";
		plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plAnh.Controls.Add(D8981D99);
		plAnh.Controls.Add(txtAnh);
		plAnh.Controls.Add(label14);
		plAnh.Controls.Add(label12);
		plAnh.Enabled = false;
		plAnh.Location = new System.Drawing.Point(6, 140);
		plAnh.Name = "plAnh";
		plAnh.Size = new System.Drawing.Size(313, 63);
		plAnh.TabIndex = 187;
		D8981D99.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		D8981D99.Location = new System.Drawing.Point(112, 5);
		D8981D99.Name = "nudPercentCommentImage";
		D8981D99.Size = new System.Drawing.Size(42, 23);
		D8981D99.TabIndex = 189;
		D8981D99.Value = new decimal(new int[4] { 100, 0, 0, 0 });
		txtAnh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtAnh.Location = new System.Drawing.Point(112, 33);
		txtAnh.Name = "txtAnh";
		txtAnh.Size = new System.Drawing.Size(193, 23);
		txtAnh.TabIndex = 159;
		label14.AutoSize = true;
		label14.Location = new System.Drawing.Point(3, 7);
		label14.Name = "label14";
		label14.Size = new System.Drawing.Size(112, 16);
		label14.TabIndex = 191;
		label14.Text = "Xa\u0301c suâ\u0301t la\u0300m (%):";
		label12.AutoSize = true;
		label12.Location = new System.Drawing.Point(3, 36);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(73, 16);
		label12.TabIndex = 158;
		label12.Text = "Folder ảnh:";
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(DFAED832);
		plComment.Controls.Add(cbbTuyChonNoiDung);
		plComment.Controls.Add(label13);
		plComment.Controls.Add(btnHuongDanNhapNoiDung);
		plComment.Controls.Add(CC9749A9);
		plComment.Controls.Add(btnDown);
		plComment.Controls.Add(E59B0705);
		plComment.Controls.Add(txtComment);
		plComment.Controls.Add(DF22B201);
		plComment.Controls.Add(B9BDE7AA);
		plComment.Location = new System.Drawing.Point(347, 52);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(302, 207);
		plComment.TabIndex = 185;
		DFAED832.Location = new System.Drawing.Point(112, 5);
		DFAED832.Name = "nudPercentCommentText";
		DFAED832.Size = new System.Drawing.Size(42, 23);
		DFAED832.TabIndex = 189;
		DFAED832.Value = new decimal(new int[4] { 100, 0, 0, 0 });
		cbbTuyChonNoiDung.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		cbbTuyChonNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTuyChonNoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTuyChonNoiDung.FormattingEnabled = true;
		cbbTuyChonNoiDung.Location = new System.Drawing.Point(69, 175);
		cbbTuyChonNoiDung.Name = "cbbTuyChonNoiDung";
		cbbTuyChonNoiDung.Size = new System.Drawing.Size(193, 24);
		cbbTuyChonNoiDung.TabIndex = 195;
		cbbTuyChonNoiDung.SelectedIndexChanged += new System.EventHandler(cbbTuyChonNoiDung_SelectedIndexChanged);
		label13.AutoSize = true;
		label13.Location = new System.Drawing.Point(3, 7);
		label13.Name = "label13";
		label13.Size = new System.Drawing.Size(112, 16);
		label13.TabIndex = 191;
		label13.Text = "Xa\u0301c suâ\u0301t la\u0300m (%):";
		btnHuongDanNhapNoiDung.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		btnHuongDanNhapNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		btnHuongDanNhapNoiDung.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnHuongDanNhapNoiDung.Location = new System.Drawing.Point(268, 174);
		btnHuongDanNhapNoiDung.Name = "btnHuongDanNhapNoiDung";
		btnHuongDanNhapNoiDung.Size = new System.Drawing.Size(26, 26);
		btnHuongDanNhapNoiDung.TabIndex = 194;
		btnHuongDanNhapNoiDung.Text = "?";
		btnHuongDanNhapNoiDung.UseVisualStyleBackColor = true;
		btnHuongDanNhapNoiDung.Click += new System.EventHandler(btnHuongDanNhapNoiDung_Click);
		CC9749A9.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		CC9749A9.AutoSize = true;
		CC9749A9.Location = new System.Drawing.Point(3, 178);
		CC9749A9.Name = "label8";
		CC9749A9.Size = new System.Drawing.Size(64, 16);
		CC9749A9.TabIndex = 193;
		CC9749A9.Text = "Tùy chọn:";
		btnDown.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		btnDown.BackgroundImage = C50FB39E.Bitmap_89;
		btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnDown.Location = new System.Drawing.Point(245, -1);
		btnDown.Name = "btnDown";
		btnDown.Size = new System.Drawing.Size(25, 25);
		btnDown.TabIndex = 191;
		btnDown.Visible = false;
		E59B0705.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		E59B0705.BackgroundImage = C50FB39E.Bitmap_74;
		E59B0705.Cursor = System.Windows.Forms.Cursors.Hand;
		E59B0705.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		E59B0705.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E59B0705.Location = new System.Drawing.Point(276, -1);
		E59B0705.Name = "btnUp";
		E59B0705.Size = new System.Drawing.Size(25, 25);
		E59B0705.TabIndex = 192;
		E59B0705.Visible = false;
		txtComment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtComment.Location = new System.Drawing.Point(7, 52);
		txtComment.Name = "txtComment";
		txtComment.Size = new System.Drawing.Size(287, 118);
		txtComment.TabIndex = 1;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(C9B3319D);
		DF22B201.AutoSize = true;
		DF22B201.Location = new System.Drawing.Point(3, 32);
		DF22B201.Name = "lblComment";
		DF22B201.Size = new System.Drawing.Size(139, 16);
		DF22B201.TabIndex = 0;
		DF22B201.Text = "Nội dung bình luận (0):";
		B9BDE7AA.AutoSize = true;
		B9BDE7AA.Cursor = System.Windows.Forms.Cursors.Hand;
		B9BDE7AA.Location = new System.Drawing.Point(7, 213);
		B9BDE7AA.Name = "ckbAutoDeleteComment";
		B9BDE7AA.Size = new System.Drawing.Size(169, 20);
		B9BDE7AA.TabIndex = 8;
		B9BDE7AA.Text = "Xóa nội dung đã sư\u0309 du\u0323ng";
		B9BDE7AA.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(panel2);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "ucTuongTacBaiVietv2";
		base.Size = new System.Drawing.Size(656, 266);
		base.Load += new System.EventHandler(EFBBE9AB_Load);
		panel2.ResumeLayout(false);
		panel2.PerformLayout();
		plShareWall.ResumeLayout(false);
		plShareWall.PerformLayout();
		((System.ComponentModel.ISupportInitialize)BC33D127).EndInit();
		((System.ComponentModel.ISupportInitialize)AE005632).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).EndInit();
		B8026A04.ResumeLayout(false);
		B8026A04.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudPercentLike).EndInit();
		CD35E50A.ResumeLayout(false);
		CD35E50A.PerformLayout();
		plAnh.ResumeLayout(false);
		plAnh.PerformLayout();
		((System.ComponentModel.ISupportInitialize)D8981D99).EndInit();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)DFAED832).EndInit();
		ResumeLayout(false);
	}
}
