using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class DBA4A1B0 : Form
{
	private GClass11 EE2BECAC;

	private List<CheckBox> ED36B027;

	private string string_0;

	private string string_1;

	private string string_2;

	private int DA9BC427;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown A9AAA63C;

	private NumericUpDown nudTimeFrom;

	private TextBox txtTenHanhDong;

	private Label C0340B24;

	private Label A19A91A6;

	private Label F989DE39;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button DCB4F101;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel plComment;

	private CheckBox F1A9DE33;

	private CheckBox F68AEC2B;

	private NumericUpDown nudLapLaiTuongTacDelayTo;

	private Label C7879CBF;

	private NumericUpDown nudLapLaiTuongTacDelayFrom;

	private Label EE2CDFB6;

	private TextBox txtLinkVideo;

	private Label label9;

	private CheckBox ckbTuDongXoaNoiDung;

	private Panel B0B72D99;

	private CheckBox ckbGian;

	private CheckBox ckbBuon;

	private CheckBox ckbWow;

	private CheckBox ckbHaha;

	private CheckBox DBAAD908;

	private CheckBox BB277C9B;

	private CheckBox ckbLike;

	private Panel BD3920BA;

	private RadioButton radioButton3;

	private RadioButton radioButton4;

	private Label AA33D637;

	private RichTextBox txtComment;

	private Label label11;

	private Label F4B6BFAF;

	private Panel plLapLaiTuongTac;

	private Panel panel3;

	private RadioButton AFB1B282;

	private RadioButton radioButton2;

	private CheckBox ckbLapLaiTuongTacInteract;

	private CheckBox ckbLapLaiTuongTacComment;

	private Label label4;

	private CheckBox ckbLapLaiTuongTac;

	public DBA4A1B0(string string_3, int D43C2912 = 0, string string_4 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		DA9BC427 = D43C2912;
		string text = base.Name.Substring(1);
		string text2 = "Tương tác Livestream";
		if (Class147.smethod_7("", text).Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\",\"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (D43C2912)
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
			DataTable dataTable = Class147.F3057616(string_4);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		EE2BECAC = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
		ED36B027 = new List<CheckBox> { ckbLike, BB277C9B, DBAAD908, ckbHaha, ckbWow, ckbBuon, ckbGian };
	}

	private void AEBDBCBD(object sender, EventArgs e)
	{
		try
		{
			txtLinkVideo.Text = EE2BECAC.C0288288("txtLinkVideo");
			nudTimeFrom.Value = EE2BECAC.method_2("nudTimeFrom", 30);
			A9AAA63C.Value = EE2BECAC.method_2("nudTimeTo", 30);
			F68AEC2B.Checked = EE2BECAC.method_3("ckbInteract");
			string text = EE2BECAC.C0288288("typeReaction");
			new List<CheckBox> { ckbLike, BB277C9B, ckbHaha, ckbWow, ckbBuon, ckbGian };
			for (int i = 0; i < ED36B027.Count; i++)
			{
				ED36B027[i].Checked = text.Split('|').Contains(i.ToString());
			}
			F1A9DE33.Checked = EE2BECAC.method_3("ckbComment");
			txtComment.Text = EE2BECAC.C0288288("txtComment");
			ckbTuDongXoaNoiDung.Checked = EE2BECAC.method_3("ckbTuDongXoaNoiDung");
			ckbLapLaiTuongTac.Checked = EE2BECAC.method_3("ckbLapLaiTuongTac");
			nudLapLaiTuongTacDelayFrom.Value = EE2BECAC.method_2("nudLapLaiTuongTacDelayFrom", 10);
			nudLapLaiTuongTacDelayTo.Value = EE2BECAC.method_2("nudLapLaiTuongTacDelayTo", 10);
			ckbLapLaiTuongTacInteract.Checked = EE2BECAC.method_3("ckbLapLaiTuongTacInteract");
			ckbLapLaiTuongTacComment.Checked = EE2BECAC.method_3("ckbLapLaiTuongTacComment");
		}
		catch
		{
		}
		method_0();
	}

	private void DCB4F101_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C9A26AA5(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!");
			return;
		}
		if (F1A9DE33.Checked)
		{
			List<string> e03C713E = txtComment.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			if (e03C713E.Count == 0)
			{
				GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!");
				return;
			}
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("txtLinkVideo", txtLinkVideo.Text.Trim());
		gClass.method_4("nudTimeFrom", nudTimeFrom.Value);
		gClass.method_4("nudTimeTo", A9AAA63C.Value);
		gClass.method_4("ckbInteract", F68AEC2B.Checked);
		string text2 = "";
		for (int i = 0; i < ED36B027.Count; i++)
		{
			if (ED36B027[i].Checked)
			{
				text2 = text2 + i + "|";
			}
		}
		gClass.method_4("typeReaction", text2.TrimEnd('|'));
		gClass.method_4("ckbComment", F1A9DE33.Checked);
		gClass.method_4("txtComment", txtComment.Text.Trim());
		gClass.method_4("ckbTuDongXoaNoiDung", ckbTuDongXoaNoiDung.Checked);
		gClass.method_4("ckbLapLaiTuongTac", ckbLapLaiTuongTac.Checked);
		gClass.method_4("nudLapLaiTuongTacDelayFrom", nudLapLaiTuongTacDelayFrom.Value);
		gClass.method_4("nudLapLaiTuongTacDelayTo", nudLapLaiTuongTacDelayTo.Value);
		gClass.method_4("ckbLapLaiTuongTacInteract", ckbLapLaiTuongTacInteract.Checked);
		gClass.method_4("ckbLapLaiTuongTacComment", ckbLapLaiTuongTacComment.Checked);
		string text3 = gClass.method_7();
		if (DA9BC427 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, text3))
				{
					bool_0 = true;
					Close();
				}
				else
				{
					GClass29.smethod_0("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!");
				}
			}
		}
		else if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") == DialogResult.Yes)
		{
			if (Class147.smethod_13(string_2, text, text3))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!");
			}
		}
	}

	private void E4A16B28(object sender, EventArgs e)
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

	private void method_0()
	{
		F68AEC2B_CheckedChanged(null, null);
		D294CD8F(null, null);
		C9822E10(null, null);
	}

	private void F68AEC2B_CheckedChanged(object sender, EventArgs e)
	{
		B0B72D99.Enabled = F68AEC2B.Checked;
		if (F68AEC2B.Checked)
		{
			ckbLapLaiTuongTacInteract.Enabled = true;
			return;
		}
		ckbLapLaiTuongTacInteract.Checked = false;
		ckbLapLaiTuongTacInteract.Enabled = false;
	}

	private void D294CD8F(object sender, EventArgs e)
	{
		plComment.Enabled = F1A9DE33.Checked;
		if (F1A9DE33.Checked)
		{
			ckbLapLaiTuongTacComment.Enabled = true;
			return;
		}
		ckbLapLaiTuongTacComment.Checked = false;
		ckbLapLaiTuongTacComment.Enabled = false;
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtComment, F4B6BFAF);
	}

	private void C9822E10(object sender, EventArgs e)
	{
		plLapLaiTuongTac.Enabled = ckbLapLaiTuongTac.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBA4A1B0));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		DCB4F101 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		plLapLaiTuongTac = new System.Windows.Forms.Panel();
		nudLapLaiTuongTacDelayTo = new System.Windows.Forms.NumericUpDown();
		panel3 = new System.Windows.Forms.Panel();
		AFB1B282 = new System.Windows.Forms.RadioButton();
		radioButton2 = new System.Windows.Forms.RadioButton();
		ckbLapLaiTuongTacInteract = new System.Windows.Forms.CheckBox();
		C7879CBF = new System.Windows.Forms.Label();
		ckbLapLaiTuongTacComment = new System.Windows.Forms.CheckBox();
		nudLapLaiTuongTacDelayFrom = new System.Windows.Forms.NumericUpDown();
		label4 = new System.Windows.Forms.Label();
		EE2CDFB6 = new System.Windows.Forms.Label();
		B0B72D99 = new System.Windows.Forms.Panel();
		ckbGian = new System.Windows.Forms.CheckBox();
		ckbBuon = new System.Windows.Forms.CheckBox();
		ckbWow = new System.Windows.Forms.CheckBox();
		ckbHaha = new System.Windows.Forms.CheckBox();
		DBAAD908 = new System.Windows.Forms.CheckBox();
		BB277C9B = new System.Windows.Forms.CheckBox();
		ckbLike = new System.Windows.Forms.CheckBox();
		BD3920BA = new System.Windows.Forms.Panel();
		radioButton3 = new System.Windows.Forms.RadioButton();
		radioButton4 = new System.Windows.Forms.RadioButton();
		AA33D637 = new System.Windows.Forms.Label();
		plComment = new System.Windows.Forms.Panel();
		txtComment = new System.Windows.Forms.RichTextBox();
		label11 = new System.Windows.Forms.Label();
		F4B6BFAF = new System.Windows.Forms.Label();
		ckbTuDongXoaNoiDung = new System.Windows.Forms.CheckBox();
		ckbLapLaiTuongTac = new System.Windows.Forms.CheckBox();
		F1A9DE33 = new System.Windows.Forms.CheckBox();
		F68AEC2B = new System.Windows.Forms.CheckBox();
		A9AAA63C = new System.Windows.Forms.NumericUpDown();
		nudTimeFrom = new System.Windows.Forms.NumericUpDown();
		txtLinkVideo = new System.Windows.Forms.TextBox();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		C0340B24 = new System.Windows.Forms.Label();
		label9 = new System.Windows.Forms.Label();
		A19A91A6 = new System.Windows.Forms.Label();
		F989DE39 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plLapLaiTuongTac.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudLapLaiTuongTacDelayTo).BeginInit();
		panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudLapLaiTuongTacDelayFrom).BeginInit();
		B0B72D99.SuspendLayout();
		BD3920BA.SuspendLayout();
		plComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)A9AAA63C).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).BeginInit();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(388, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Tương tác Livestream";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(DCB4F101);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(388, 31);
		pnlHeader.TabIndex = 9;
		DCB4F101.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		DCB4F101.Cursor = System.Windows.Forms.Cursors.Hand;
		DCB4F101.FlatAppearance.BorderSize = 0;
		DCB4F101.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		DCB4F101.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		DCB4F101.ForeColor = System.Drawing.Color.White;
		DCB4F101.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		DCB4F101.Location = new System.Drawing.Point(357, 1);
		DCB4F101.Name = "button1";
		DCB4F101.Size = new System.Drawing.Size(30, 30);
		DCB4F101.TabIndex = 77;
		DCB4F101.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		DCB4F101.UseVisualStyleBackColor = true;
		DCB4F101.Click += new System.EventHandler(DCB4F101_Click);
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
		panel1.Controls.Add(plLapLaiTuongTac);
		panel1.Controls.Add(B0B72D99);
		panel1.Controls.Add(plComment);
		panel1.Controls.Add(ckbLapLaiTuongTac);
		panel1.Controls.Add(F1A9DE33);
		panel1.Controls.Add(F68AEC2B);
		panel1.Controls.Add(A9AAA63C);
		panel1.Controls.Add(nudTimeFrom);
		panel1.Controls.Add(txtLinkVideo);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(C0340B24);
		panel1.Controls.Add(label9);
		panel1.Controls.Add(A19A91A6);
		panel1.Controls.Add(F989DE39);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(391, 544);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		plLapLaiTuongTac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plLapLaiTuongTac.Controls.Add(nudLapLaiTuongTacDelayTo);
		plLapLaiTuongTac.Controls.Add(panel3);
		plLapLaiTuongTac.Controls.Add(ckbLapLaiTuongTacInteract);
		plLapLaiTuongTac.Controls.Add(C7879CBF);
		plLapLaiTuongTac.Controls.Add(ckbLapLaiTuongTacComment);
		plLapLaiTuongTac.Controls.Add(nudLapLaiTuongTacDelayFrom);
		plLapLaiTuongTac.Controls.Add(label4);
		plLapLaiTuongTac.Controls.Add(EE2CDFB6);
		plLapLaiTuongTac.Location = new System.Drawing.Point(48, 426);
		plLapLaiTuongTac.Name = "plLapLaiTuongTac";
		plLapLaiTuongTac.Size = new System.Drawing.Size(310, 59);
		plLapLaiTuongTac.TabIndex = 180;
		nudLapLaiTuongTacDelayTo.Cursor = System.Windows.Forms.Cursors.Hand;
		nudLapLaiTuongTacDelayTo.Location = new System.Drawing.Point(185, 4);
		nudLapLaiTuongTacDelayTo.Maximum = new decimal(new int[4] { 100000000, 0, 0, 0 });
		nudLapLaiTuongTacDelayTo.Name = "nudLapLaiTuongTacDelayTo";
		nudLapLaiTuongTacDelayTo.Size = new System.Drawing.Size(56, 23);
		nudLapLaiTuongTacDelayTo.TabIndex = 22;
		panel3.Controls.Add(AFB1B282);
		panel3.Controls.Add(radioButton2);
		panel3.Location = new System.Drawing.Point(67, 300);
		panel3.Name = "panel3";
		panel3.Size = new System.Drawing.Size(200, 43);
		panel3.TabIndex = 43;
		AFB1B282.AutoSize = true;
		AFB1B282.Checked = true;
		AFB1B282.Cursor = System.Windows.Forms.Cursors.Hand;
		AFB1B282.Location = new System.Drawing.Point(3, 2);
		AFB1B282.Name = "radioButton1";
		AFB1B282.Size = new System.Drawing.Size(201, 20);
		AFB1B282.TabIndex = 3;
		AFB1B282.TabStop = true;
		AFB1B282.Text = "Comment theo thứ tự nội dung";
		AFB1B282.UseVisualStyleBackColor = true;
		radioButton2.AutoSize = true;
		radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
		radioButton2.Location = new System.Drawing.Point(3, 23);
		radioButton2.Name = "radioButton2";
		radioButton2.Size = new System.Drawing.Size(200, 20);
		radioButton2.TabIndex = 3;
		radioButton2.Text = "Comment ngẫu nhiên nội dung";
		radioButton2.UseVisualStyleBackColor = true;
		ckbLapLaiTuongTacInteract.AutoSize = true;
		ckbLapLaiTuongTacInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLapLaiTuongTacInteract.Location = new System.Drawing.Point(6, 32);
		ckbLapLaiTuongTacInteract.Name = "ckbLapLaiTuongTacInteract";
		ckbLapLaiTuongTacInteract.Size = new System.Drawing.Size(112, 20);
		ckbLapLaiTuongTacInteract.TabIndex = 5;
		ckbLapLaiTuongTacInteract.Text = "Ba\u0300y to\u0309 ca\u0309m xu\u0301c";
		ckbLapLaiTuongTacInteract.UseVisualStyleBackColor = true;
		ckbLapLaiTuongTacInteract.CheckedChanged += new System.EventHandler(F68AEC2B_CheckedChanged);
		C7879CBF.AutoSize = true;
		C7879CBF.Location = new System.Drawing.Point(2, 6);
		C7879CBF.Name = "lblmc1";
		C7879CBF.Size = new System.Drawing.Size(92, 16);
		C7879CBF.TabIndex = 18;
		C7879CBF.Text = "Delay time (s):";
		ckbLapLaiTuongTacComment.AutoSize = true;
		ckbLapLaiTuongTacComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLapLaiTuongTacComment.Location = new System.Drawing.Point(134, 32);
		ckbLapLaiTuongTacComment.Name = "ckbLapLaiTuongTacComment";
		ckbLapLaiTuongTacComment.Size = new System.Drawing.Size(81, 20);
		ckbLapLaiTuongTacComment.TabIndex = 7;
		ckbLapLaiTuongTacComment.Text = "Comment";
		ckbLapLaiTuongTacComment.UseVisualStyleBackColor = true;
		ckbLapLaiTuongTacComment.CheckedChanged += new System.EventHandler(D294CD8F);
		nudLapLaiTuongTacDelayFrom.Cursor = System.Windows.Forms.Cursors.Hand;
		nudLapLaiTuongTacDelayFrom.Location = new System.Drawing.Point(94, 4);
		nudLapLaiTuongTacDelayFrom.Maximum = new decimal(new int[4] { 100000000, 0, 0, 0 });
		nudLapLaiTuongTacDelayFrom.Name = "nudLapLaiTuongTacDelayFrom";
		nudLapLaiTuongTacDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudLapLaiTuongTacDelayFrom.TabIndex = 21;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(4, 302);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(64, 16);
		label4.TabIndex = 2;
		label4.Text = "Tùy chọn:";
		EE2CDFB6.AutoSize = true;
		EE2CDFB6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		EE2CDFB6.Location = new System.Drawing.Point(159, 5);
		EE2CDFB6.Name = "label6";
		EE2CDFB6.Size = new System.Drawing.Size(18, 16);
		EE2CDFB6.TabIndex = 20;
		EE2CDFB6.Text = ">";
		B0B72D99.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		B0B72D99.Controls.Add(ckbGian);
		B0B72D99.Controls.Add(ckbBuon);
		B0B72D99.Controls.Add(ckbWow);
		B0B72D99.Controls.Add(ckbHaha);
		B0B72D99.Controls.Add(DBAAD908);
		B0B72D99.Controls.Add(BB277C9B);
		B0B72D99.Controls.Add(ckbLike);
		B0B72D99.Controls.Add(BD3920BA);
		B0B72D99.Controls.Add(AA33D637);
		B0B72D99.Location = new System.Drawing.Point(48, 159);
		B0B72D99.Name = "plInteract";
		B0B72D99.Size = new System.Drawing.Size(310, 33);
		B0B72D99.TabIndex = 180;
		ckbGian.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbGian.Image = C50FB39E.ABB95605;
		ckbGian.Location = new System.Drawing.Point(266, 1);
		ckbGian.Name = "ckbGian";
		ckbGian.Size = new System.Drawing.Size(40, 30);
		ckbGian.TabIndex = 179;
		ckbGian.UseVisualStyleBackColor = true;
		ckbBuon.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbBuon.Image = C50FB39E.Bitmap_163;
		ckbBuon.Location = new System.Drawing.Point(222, 1);
		ckbBuon.Name = "ckbBuon";
		ckbBuon.Size = new System.Drawing.Size(40, 30);
		ckbBuon.TabIndex = 178;
		ckbBuon.UseVisualStyleBackColor = true;
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
		DBAAD908.Cursor = System.Windows.Forms.Cursors.Hand;
		DBAAD908.Image = C50FB39E.Bitmap_14;
		DBAAD908.Location = new System.Drawing.Point(90, 1);
		DBAAD908.Name = "ckbThuong";
		DBAAD908.Size = new System.Drawing.Size(40, 30);
		DBAAD908.TabIndex = 175;
		DBAAD908.UseVisualStyleBackColor = true;
		BB277C9B.Cursor = System.Windows.Forms.Cursors.Hand;
		BB277C9B.Image = C50FB39E.Bitmap_153;
		BB277C9B.Location = new System.Drawing.Point(46, 1);
		BB277C9B.Name = "ckbTym";
		BB277C9B.Size = new System.Drawing.Size(40, 30);
		BB277C9B.TabIndex = 174;
		BB277C9B.UseVisualStyleBackColor = true;
		ckbLike.Checked = true;
		ckbLike.CheckState = System.Windows.Forms.CheckState.Checked;
		ckbLike.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLike.Image = C50FB39E.F2069B3C;
		ckbLike.Location = new System.Drawing.Point(2, 1);
		ckbLike.Name = "ckbLike";
		ckbLike.Size = new System.Drawing.Size(40, 30);
		ckbLike.TabIndex = 173;
		ckbLike.UseVisualStyleBackColor = true;
		BD3920BA.Controls.Add(radioButton3);
		BD3920BA.Controls.Add(radioButton4);
		BD3920BA.Location = new System.Drawing.Point(67, 300);
		BD3920BA.Name = "panel7";
		BD3920BA.Size = new System.Drawing.Size(200, 43);
		BD3920BA.TabIndex = 43;
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
		AA33D637.AutoSize = true;
		AA33D637.Location = new System.Drawing.Point(4, 302);
		AA33D637.Name = "label26";
		AA33D637.Size = new System.Drawing.Size(64, 16);
		AA33D637.TabIndex = 2;
		AA33D637.Text = "Tùy chọn:";
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(txtComment);
		plComment.Controls.Add(label11);
		plComment.Controls.Add(F4B6BFAF);
		plComment.Controls.Add(ckbTuDongXoaNoiDung);
		plComment.Location = new System.Drawing.Point(48, 221);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(310, 176);
		plComment.TabIndex = 8;
		txtComment.Location = new System.Drawing.Point(6, 24);
		txtComment.Name = "txtComment";
		txtComment.Size = new System.Drawing.Size(297, 102);
		txtComment.TabIndex = 199;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(4, 129);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(143, 16);
		label11.TabIndex = 197;
		label11.Text = "(Spin nội dung {a|b|c})";
		F4B6BFAF.AutoSize = true;
		F4B6BFAF.Location = new System.Drawing.Point(2, 4);
		F4B6BFAF.Name = "lblComment";
		F4B6BFAF.Size = new System.Drawing.Size(139, 16);
		F4B6BFAF.TabIndex = 198;
		F4B6BFAF.Text = "Nội dung bình luận (0):";
		ckbTuDongXoaNoiDung.AutoSize = true;
		ckbTuDongXoaNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuDongXoaNoiDung.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		ckbTuDongXoaNoiDung.Location = new System.Drawing.Point(7, 151);
		ckbTuDongXoaNoiDung.Name = "ckbTuDongXoaNoiDung";
		ckbTuDongXoaNoiDung.Size = new System.Drawing.Size(201, 20);
		ckbTuDongXoaNoiDung.TabIndex = 196;
		ckbTuDongXoaNoiDung.Text = "Tư\u0323 đô\u0323ng xo\u0301a nô\u0323i dung đa\u0303 dùng";
		ckbTuDongXoaNoiDung.UseVisualStyleBackColor = true;
		ckbLapLaiTuongTac.AutoSize = true;
		ckbLapLaiTuongTac.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLapLaiTuongTac.Location = new System.Drawing.Point(30, 403);
		ckbLapLaiTuongTac.Name = "ckbLapLaiTuongTac";
		ckbLapLaiTuongTac.Size = new System.Drawing.Size(121, 20);
		ckbLapLaiTuongTac.TabIndex = 7;
		ckbLapLaiTuongTac.Text = "Lặp lại tương tác";
		ckbLapLaiTuongTac.UseVisualStyleBackColor = true;
		ckbLapLaiTuongTac.CheckedChanged += new System.EventHandler(C9822E10);
		F1A9DE33.AutoSize = true;
		F1A9DE33.Cursor = System.Windows.Forms.Cursors.Hand;
		F1A9DE33.Location = new System.Drawing.Point(30, 198);
		F1A9DE33.Name = "ckbComment";
		F1A9DE33.Size = new System.Drawing.Size(81, 20);
		F1A9DE33.TabIndex = 7;
		F1A9DE33.Text = "Comment";
		F1A9DE33.UseVisualStyleBackColor = true;
		F1A9DE33.CheckedChanged += new System.EventHandler(D294CD8F);
		F68AEC2B.AutoSize = true;
		F68AEC2B.Cursor = System.Windows.Forms.Cursors.Hand;
		F68AEC2B.Location = new System.Drawing.Point(30, 136);
		F68AEC2B.Name = "ckbInteract";
		F68AEC2B.Size = new System.Drawing.Size(112, 20);
		F68AEC2B.TabIndex = 5;
		F68AEC2B.Text = "Ba\u0300y to\u0309 ca\u0309m xu\u0301c";
		F68AEC2B.UseVisualStyleBackColor = true;
		F68AEC2B.CheckedChanged += new System.EventHandler(F68AEC2B_CheckedChanged);
		A9AAA63C.Location = new System.Drawing.Point(236, 107);
		A9AAA63C.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A9AAA63C.Name = "nudTimeTo";
		A9AAA63C.Size = new System.Drawing.Size(56, 23);
		A9AAA63C.TabIndex = 2;
		nudTimeFrom.Location = new System.Drawing.Point(143, 107);
		nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeFrom.Name = "nudTimeFrom";
		nudTimeFrom.Size = new System.Drawing.Size(56, 23);
		nudTimeFrom.TabIndex = 1;
		txtLinkVideo.Location = new System.Drawing.Point(143, 78);
		txtLinkVideo.Name = "txtLinkVideo";
		txtLinkVideo.Size = new System.Drawing.Size(215, 23);
		txtLinkVideo.TabIndex = 0;
		txtTenHanhDong.Location = new System.Drawing.Point(143, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(215, 23);
		txtTenHanhDong.TabIndex = 0;
		C0340B24.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C0340B24.Location = new System.Drawing.Point(203, 109);
		C0340B24.Name = "label3";
		C0340B24.Size = new System.Drawing.Size(29, 16);
		C0340B24.TabIndex = 37;
		C0340B24.Text = ">";
		C0340B24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(27, 81);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(97, 16);
		label9.TabIndex = 31;
		label9.Text = "Link livestream:";
		A19A91A6.AutoSize = true;
		A19A91A6.Location = new System.Drawing.Point(27, 109);
		A19A91A6.Name = "label2";
		A19A91A6.Size = new System.Drawing.Size(113, 16);
		A19A91A6.TabIndex = 32;
		A19A91A6.Text = "Thời gian xem (s):";
		F989DE39.AutoSize = true;
		F989DE39.Location = new System.Drawing.Point(27, 52);
		F989DE39.Name = "label1";
		F989DE39.Size = new System.Drawing.Size(98, 16);
		F989DE39.TabIndex = 31;
		F989DE39.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(203, 500);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(E4A16B28);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(96, 500);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(C9A26AA5);
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
		bunifuCards1.Size = new System.Drawing.Size(388, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(391, 544);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacLivestream";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(AEBDBCBD);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plLapLaiTuongTac.ResumeLayout(false);
		plLapLaiTuongTac.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudLapLaiTuongTacDelayTo).EndInit();
		panel3.ResumeLayout(false);
		panel3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudLapLaiTuongTacDelayFrom).EndInit();
		B0B72D99.ResumeLayout(false);
		B0B72D99.PerformLayout();
		BD3920BA.ResumeLayout(false);
		BD3920BA.PerformLayout();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)A9AAA63C).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
