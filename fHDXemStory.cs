using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDXemStory : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string string_1;

	private string F8AF498D;

	private int int_0;

	public static bool bool_0;

	private List<CheckBox> list_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl FBADC49C;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudDelayFrom;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label E8BBC295;

	private Label label3;

	private Label E08183A3;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button F5145CBC;

	private BunifuCards B83C3401;

	private Panel DDBC610B;

	private Button button1;

	private PictureBox BA32D922;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel plComment;

	private CheckBox EA830C3E;

	private CheckBox ckbInteract;

	private RichTextBox txtComment;

	private Label C49DFC05;

	private Panel plInteract;

	private Panel D4AA3B9E;

	private RadioButton radioButton3;

	private RadioButton radioButton4;

	private Label C68D3235;

	private CheckBox ckbAngry;

	private CheckBox ckbSad;

	private CheckBox A8359096;

	private CheckBox ckbHaha;

	private CheckBox ckbCare;

	private CheckBox ckbLove;

	private CheckBox ckbLike;

	public fHDXemStory(string DE1DFB2E, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = DE1DFB2E;
		F8AF498D = string_2;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "";
		switch (int_1)
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
			DataTable dataTable = Class147.F3057616(string_2);
			text2 = dataTable.Rows[0]["CauHinh"].ToString();
			F5145CBC.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text2, bool_0: true);
		F7AB102E.D6B70A35(this);
		list_0 = new List<CheckBox> { ckbLike, ckbLove, ckbCare, ckbHaha, A8359096, ckbSad, ckbAngry };
	}

	private void fHDXemStory_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = gclass11_0.method_2("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass11_0.method_2("nudSoLuongTo", 3);
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
			ckbInteract.Checked = gclass11_0.method_3("ckbInteract");
			string text = gclass11_0.C0288288("typeReaction", "Like");
			if (GClass8.smethod_44(text.Replace("|", "")))
			{
				if (!text.Contains("|"))
				{
					text = string.Join("|", text.ToArray());
				}
				List<string> list = new List<string> { "Like", "Love", "Care", "Haha", "Wow", "Sad", "Angry" };
				for (int i = 0; i < list.Count; i++)
				{
					text = text.Replace(i.ToString(), list[i]);
				}
			}
			List<string> list2 = text.Split('|').ToList();
			for (int j = 0; j < list2.Count; j++)
			{
				foreach (CheckBox item in list_0)
				{
					if (item.Name.Substring(3) == list2[j])
					{
						item.Checked = true;
					}
				}
			}
			EA830C3E.Checked = gclass11_0.method_3("ckbComment");
			txtComment.Text = gclass11_0.C0288288("txtComment");
		}
		catch
		{
		}
		method_0();
	}

	private void A52B96AE(object sender, EventArgs e)
	{
		Close();
	}

	private void F5145CBC_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		if (EA830C3E.Checked)
		{
			List<string> e03C713E = txtComment.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			if (e03C713E.Count == 0)
			{
				GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
				return;
			}
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		gClass.method_4("ckbInteract", ckbInteract.Checked);
		string text2 = "";
		for (int i = 0; i < list_0.Count; i++)
		{
			if (list_0[i].Checked)
			{
				text2 = text2 + list_0[i].Name.Substring(3) + "|";
			}
		}
		gClass.method_4("typeReaction", text2.TrimEnd('|'));
		gClass.method_4("ckbComment", EA830C3E.Checked);
		gClass.method_4("txtComment", txtComment.Text.Trim());
		string string_ = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, string_))
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
			if (Class147.smethod_13(F8AF498D, text, string_))
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

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void D228FB21(object sender, PaintEventArgs e)
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
		ckbInteract_CheckedChanged(null, null);
		ED80A917(null, null);
	}

	private void ckbInteract_CheckedChanged(object sender, EventArgs e)
	{
		plInteract.Enabled = ckbInteract.Checked;
	}

	private void ED80A917(object sender, EventArgs e)
	{
		plComment.Enabled = EA830C3E.Checked;
	}

	private void B4920FB8(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtComment, C49DFC05);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDXemStory));
		FBADC49C = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		DDBC610B = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		BA32D922 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		plComment = new System.Windows.Forms.Panel();
		EA830C3E = new System.Windows.Forms.CheckBox();
		ckbInteract = new System.Windows.Forms.CheckBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		E8BBC295 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		E08183A3 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		F5145CBC = new System.Windows.Forms.Button();
		B83C3401 = new Bunifu.Framework.UI.BunifuCards();
		txtComment = new System.Windows.Forms.RichTextBox();
		C49DFC05 = new System.Windows.Forms.Label();
		plInteract = new System.Windows.Forms.Panel();
		D4AA3B9E = new System.Windows.Forms.Panel();
		radioButton3 = new System.Windows.Forms.RadioButton();
		radioButton4 = new System.Windows.Forms.RadioButton();
		C68D3235 = new System.Windows.Forms.Label();
		ckbAngry = new System.Windows.Forms.CheckBox();
		ckbSad = new System.Windows.Forms.CheckBox();
		A8359096 = new System.Windows.Forms.CheckBox();
		ckbHaha = new System.Windows.Forms.CheckBox();
		ckbCare = new System.Windows.Forms.CheckBox();
		ckbLove = new System.Windows.Forms.CheckBox();
		ckbLike = new System.Windows.Forms.CheckBox();
		DDBC610B.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)BA32D922).BeginInit();
		panel1.SuspendLayout();
		plComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		B83C3401.SuspendLayout();
		plInteract.SuspendLayout();
		D4AA3B9E.SuspendLayout();
		SuspendLayout();
		FBADC49C.Fixed = true;
		FBADC49C.Horizontal = true;
		FBADC49C.TargetControl = bunifuCustomLabel1;
		FBADC49C.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(391, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Xem Story";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = DDBC610B;
		bunifuDragControl_0.Vertical = true;
		DDBC610B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DDBC610B.BackColor = System.Drawing.Color.White;
		DDBC610B.Controls.Add(button1);
		DDBC610B.Controls.Add(BA32D922);
		DDBC610B.Controls.Add(bunifuCustomLabel1);
		DDBC610B.Cursor = System.Windows.Forms.Cursors.SizeAll;
		DDBC610B.Location = new System.Drawing.Point(0, 3);
		DDBC610B.Name = "pnlHeader";
		DDBC610B.Size = new System.Drawing.Size(391, 31);
		DDBC610B.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(360, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(A52B96AE);
		BA32D922.Cursor = System.Windows.Forms.Cursors.Default;
		BA32D922.Image = C50FB39E.Bitmap_5;
		BA32D922.Location = new System.Drawing.Point(3, 2);
		BA32D922.Name = "pictureBox1";
		BA32D922.Size = new System.Drawing.Size(34, 27);
		BA32D922.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		BA32D922.TabIndex = 76;
		BA32D922.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(plInteract);
		panel1.Controls.Add(plComment);
		panel1.Controls.Add(EA830C3E);
		panel1.Controls.Add(ckbInteract);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(E8BBC295);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(E08183A3);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(F5145CBC);
		panel1.Controls.Add(B83C3401);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(394, 438);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(D228FB21);
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(txtComment);
		plComment.Controls.Add(C49DFC05);
		plComment.Location = new System.Drawing.Point(48, 217);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(310, 164);
		plComment.TabIndex = 8;
		EA830C3E.AutoSize = true;
		EA830C3E.Cursor = System.Windows.Forms.Cursors.Hand;
		EA830C3E.Location = new System.Drawing.Point(30, 195);
		EA830C3E.Name = "ckbComment";
		EA830C3E.Size = new System.Drawing.Size(127, 20);
		EA830C3E.TabIndex = 7;
		EA830C3E.Text = "Bi\u0300nh luâ\u0323n văn bản";
		EA830C3E.UseVisualStyleBackColor = true;
		EA830C3E.CheckedChanged += new System.EventHandler(ED80A917);
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(30, 135);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(112, 20);
		ckbInteract.TabIndex = 5;
		ckbInteract.Text = "Ba\u0300y to\u0309 ca\u0309m xu\u0301c";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += new System.EventHandler(ckbInteract_CheckedChanged);
		nudDelayTo.Location = new System.Drawing.Point(229, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudSoLuongTo.Location = new System.Drawing.Point(229, 78);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudDelayFrom.Location = new System.Drawing.Point(132, 107);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 78);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(153, 23);
		txtTenHanhDong.TabIndex = 0;
		E8BBC295.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E8BBC295.Location = new System.Drawing.Point(194, 109);
		E8BBC295.Name = "label7";
		E8BBC295.Size = new System.Drawing.Size(29, 16);
		E8BBC295.TabIndex = 38;
		E8BBC295.Text = ">";
		E8BBC295.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(194, 80);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = ">";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		E08183A3.AutoSize = true;
		E08183A3.Location = new System.Drawing.Point(27, 109);
		E08183A3.Name = "label5";
		E08183A3.Size = new System.Drawing.Size(87, 16);
		E08183A3.TabIndex = 34;
		E08183A3.Text = "Gia\u0303n ca\u0301ch (s):";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 80);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(95, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng story:";
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
		btnCancel.Location = new System.Drawing.Point(207, 396);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		F5145CBC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		F5145CBC.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		F5145CBC.Cursor = System.Windows.Forms.Cursors.Hand;
		F5145CBC.FlatAppearance.BorderSize = 0;
		F5145CBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		F5145CBC.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F5145CBC.ForeColor = System.Drawing.Color.White;
		F5145CBC.Location = new System.Drawing.Point(100, 396);
		F5145CBC.Name = "btnAdd";
		F5145CBC.Size = new System.Drawing.Size(92, 29);
		F5145CBC.TabIndex = 9;
		F5145CBC.Text = "Thêm";
		F5145CBC.UseVisualStyleBackColor = false;
		F5145CBC.Click += new System.EventHandler(F5145CBC_Click);
		B83C3401.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		B83C3401.BackColor = System.Drawing.Color.White;
		B83C3401.BorderRadius = 0;
		B83C3401.BottomSahddow = true;
		B83C3401.color = System.Drawing.Color.DarkViolet;
		B83C3401.Controls.Add(DDBC610B);
		B83C3401.LeftSahddow = false;
		B83C3401.Location = new System.Drawing.Point(1, 0);
		B83C3401.Name = "bunifuCards1";
		B83C3401.RightSahddow = true;
		B83C3401.ShadowDepth = 20;
		B83C3401.Size = new System.Drawing.Size(391, 37);
		B83C3401.TabIndex = 28;
		txtComment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtComment.Location = new System.Drawing.Point(5, 24);
		txtComment.Name = "txtComment";
		txtComment.Size = new System.Drawing.Size(298, 135);
		txtComment.TabIndex = 3;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(B4920FB8);
		C49DFC05.AutoSize = true;
		C49DFC05.Location = new System.Drawing.Point(1, 4);
		C49DFC05.Name = "lblComment";
		C49DFC05.Size = new System.Drawing.Size(139, 16);
		C49DFC05.TabIndex = 2;
		C49DFC05.Text = "Nội dung bình luận (0):";
		plInteract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plInteract.Controls.Add(ckbAngry);
		plInteract.Controls.Add(ckbSad);
		plInteract.Controls.Add(A8359096);
		plInteract.Controls.Add(ckbHaha);
		plInteract.Controls.Add(ckbCare);
		plInteract.Controls.Add(ckbLove);
		plInteract.Controls.Add(ckbLike);
		plInteract.Controls.Add(D4AA3B9E);
		plInteract.Controls.Add(C68D3235);
		plInteract.Location = new System.Drawing.Point(48, 157);
		plInteract.Name = "plInteract";
		plInteract.Size = new System.Drawing.Size(310, 33);
		plInteract.TabIndex = 180;
		D4AA3B9E.Controls.Add(radioButton3);
		D4AA3B9E.Controls.Add(radioButton4);
		D4AA3B9E.Location = new System.Drawing.Point(67, 300);
		D4AA3B9E.Name = "panel7";
		D4AA3B9E.Size = new System.Drawing.Size(200, 43);
		D4AA3B9E.TabIndex = 43;
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
		C68D3235.AutoSize = true;
		C68D3235.Location = new System.Drawing.Point(4, 302);
		C68D3235.Name = "label26";
		C68D3235.Size = new System.Drawing.Size(64, 16);
		C68D3235.TabIndex = 2;
		C68D3235.Text = "Tùy chọn:";
		ckbAngry.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		ckbAngry.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAngry.Image = C50FB39E.ABB95605;
		ckbAngry.Location = new System.Drawing.Point(266, 0);
		ckbAngry.Name = "ckbAngry";
		ckbAngry.Size = new System.Drawing.Size(40, 30);
		ckbAngry.TabIndex = 186;
		ckbAngry.Tag = "Angry";
		ckbAngry.UseVisualStyleBackColor = true;
		ckbSad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		ckbSad.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbSad.Image = C50FB39E.Bitmap_163;
		ckbSad.Location = new System.Drawing.Point(222, 0);
		ckbSad.Name = "ckbSad";
		ckbSad.Size = new System.Drawing.Size(40, 30);
		ckbSad.TabIndex = 185;
		ckbSad.Tag = "Sad";
		ckbSad.UseVisualStyleBackColor = true;
		A8359096.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		A8359096.Cursor = System.Windows.Forms.Cursors.Hand;
		A8359096.Image = C50FB39E.F10C2BBC;
		A8359096.Location = new System.Drawing.Point(178, 0);
		A8359096.Name = "ckbWow";
		A8359096.Size = new System.Drawing.Size(40, 30);
		A8359096.TabIndex = 184;
		A8359096.Tag = "Wow";
		A8359096.UseVisualStyleBackColor = true;
		ckbHaha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHaha.Image = C50FB39E.Bitmap_47;
		ckbHaha.Location = new System.Drawing.Point(134, 0);
		ckbHaha.Name = "ckbHaha";
		ckbHaha.Size = new System.Drawing.Size(40, 30);
		ckbHaha.TabIndex = 183;
		ckbHaha.Tag = "Haha";
		ckbHaha.UseVisualStyleBackColor = true;
		ckbCare.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		ckbCare.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCare.Image = C50FB39E.Bitmap_14;
		ckbCare.Location = new System.Drawing.Point(90, 0);
		ckbCare.Name = "ckbCare";
		ckbCare.Size = new System.Drawing.Size(40, 30);
		ckbCare.TabIndex = 182;
		ckbCare.Tag = "Care";
		ckbCare.UseVisualStyleBackColor = true;
		ckbLove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		ckbLove.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLove.Image = C50FB39E.Bitmap_153;
		ckbLove.Location = new System.Drawing.Point(46, 0);
		ckbLove.Name = "ckbLove";
		ckbLove.Size = new System.Drawing.Size(40, 30);
		ckbLove.TabIndex = 181;
		ckbLove.Tag = "Love";
		ckbLove.UseVisualStyleBackColor = true;
		ckbLike.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		ckbLike.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLike.Image = C50FB39E.F2069B3C;
		ckbLike.Location = new System.Drawing.Point(2, 0);
		ckbLike.Name = "ckbLike";
		ckbLike.Size = new System.Drawing.Size(40, 30);
		ckbLike.TabIndex = 180;
		ckbLike.Tag = "Like";
		ckbLike.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(394, 438);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDXemStory";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDXemStory_Load);
		DDBC610B.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)BA32D922).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		B83C3401.ResumeLayout(false);
		plInteract.ResumeLayout(false);
		plInteract.PerformLayout();
		D4AA3B9E.ResumeLayout(false);
		D4AA3B9E.PerformLayout();
		ResumeLayout(false);
	}
}
