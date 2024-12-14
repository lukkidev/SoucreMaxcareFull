using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDChaySeeding : Form
{
	private GClass11 gclass11_0 = null;

	private string D0BCDB21;

	private string string_0;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private List<CheckBox> list_0 = null;

	private IContainer icontainer_0 = null;

	private BunifuDragControl A394B792;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label B3993C1B;

	private Button CB840339;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel AD2F0613;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label C011BE0A;

	private Label E808C622;

	private NumericUpDown nudLimitTo;

	private NumericUpDown nudLimitFrom;

	private Label label4;

	private Label label3;

	private TextBox txtApiKey;

	private Label label6;

	private NumericUpDown nudChoLayJobTo;

	private Label label8;

	private Label label10;

	private CheckBox EB290929;

	private LinkLabel D9B00F82;

	private NumericUpDown nudMaxJobFail;

	private Label label12;

	private Label label11;

	private CheckBox ckbRunByToken;

	private NumericUpDown nudMaxJobToday;

	private GroupBox groupBox2;

	private CheckBox E10EBBBC;

	private CheckBox EB878635;

	private CheckBox ckbComment;

	private CheckBox C981E515;

	private CheckBox BB9B8F3B;

	private CheckBox ckbWow;

	private CheckBox ckbLikePage;

	private CheckBox E52D3E03;

	private CheckBox ckbLikeComment;

	private CheckBox F39978B3;

	private CheckBox E281C4B8;

	private CheckBox ckbHaha;

	private CheckBox ckbCare;

	private CheckBox ckbAngry;

	private Label label13;

	private Label label14;

	private Label E8343F09;

	private Label label15;

	private NumericUpDown CF21F2B7;

	private Label label9;

	private Button button3;

	public fHDChaySeeding(string string_2, int int_1 = 0, string E7255110 = "")
	{
		InitializeComponent();
		bool_0 = false;
		D0BCDB21 = string_2;
		string_1 = E7255110;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Kiếm tiền Golike";
		if (Class147.smethod_7("", text).Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(E7255110);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void fHDChaySeeding_Load(object sender, EventArgs e)
	{
		list_0 = new List<CheckBox>
		{
			C981E515, F39978B3, ckbCare, ckbHaha, ckbWow, E52D3E03, ckbAngry, EB878635, ckbLikePage, E281C4B8,
			ckbLikeComment, ckbComment, BB9B8F3B
		};
		txtApiKey.Text = gclass11_0.C0288288("txtApiKey");
		nudLimitFrom.Value = gclass11_0.method_2("nudLimitFrom", 3);
		nudLimitTo.Value = gclass11_0.method_2("nudLimitTo", 3);
		CF21F2B7.Value = gclass11_0.method_2("nudChoLayJobFrom", 5);
		nudChoLayJobTo.Value = gclass11_0.method_2("nudChoLayJobTo", 5);
		nudDelayFrom.Value = ((gclass11_0.method_2("nudDelayFrom", 10) < 10) ? 10 : gclass11_0.method_2("nudDelayFrom", 10));
		nudDelayTo.Value = ((gclass11_0.method_2("nudDelayTo", 10) < 10) ? 10 : gclass11_0.method_2("nudDelayTo", 10));
		nudMaxJobFail.Value = gclass11_0.method_2("nudMaxJobFail", 5);
		nudMaxJobToday.Value = gclass11_0.method_2("nudMaxJobToday");
		List<string> list = gclass11_0.C0288288("lstType").Split(',').ToList();
		for (int i = 0; i < list_0.Count; i++)
		{
			if (list.Contains(list_0[i].Text))
			{
				list_0[i].Checked = true;
			}
		}
		ckbRunByToken.Checked = gclass11_0.method_3("ckbRunByToken", bool_0: true);
		EB290929.Checked = gclass11_0.method_3("ckbUnlock956");
		EB290929_CheckedChanged(null, null);
		F293E804(null, null);
	}

	private void button1_Click(object sender, EventArgs e)
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
		gclass11_0.method_4("txtApiKey", txtApiKey.Text);
		gclass11_0.method_4("nudLimitFrom", nudLimitFrom.Value);
		gclass11_0.method_4("nudLimitTo", nudLimitTo.Value);
		gclass11_0.method_4("nudChoLayJobFrom", CF21F2B7.Value);
		gclass11_0.method_4("nudChoLayJobTo", nudChoLayJobTo.Value);
		gclass11_0.method_4("nudDelayFrom", nudDelayFrom.Value);
		gclass11_0.method_4("nudDelayTo", nudDelayTo.Value);
		gclass11_0.method_4("nudMaxJobFail", nudMaxJobFail.Value);
		gclass11_0.method_4("nudMaxJobToday", nudMaxJobToday.Value);
		gclass11_0.method_4("ckbUnlock956", EB290929.Checked);
		gclass11_0.method_4("ckbRunByToken", ckbRunByToken.Checked);
		string text2 = "";
		foreach (CheckBox item in list_0)
		{
			text2 += (item.Checked ? (item.Text + ",") : "");
		}
		gclass11_0.method_4("lstType", text2.TrimEnd(','));
		string string_ = gclass11_0.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1(F7AB102E.smethod_0("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class147.smethod_12(D0BCDB21, text, string_0, string_))
				{
					bool_0 = true;
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
			if (Class147.smethod_13(string_1, text, string_))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				GClass29.smethod_0(F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void B530752F(object sender, EventArgs e)
	{
		Close();
	}

	private void C129AA97(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void F7105239(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.smethod_33(new C4B7D633());
	}

	private void method_0(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.FB0F49A9("https://auto.golike.net/");
	}

	private void EB290929_CheckedChanged(object sender, EventArgs e)
	{
		D9B00F82.Enabled = EB290929.Checked;
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			nudMaxJobToday.Visible = !nudMaxJobToday.Visible;
		}
	}

	private void E10EBBBC_CheckedChanged(object sender, EventArgs e)
	{
		foreach (CheckBox item in list_0)
		{
			item.Checked = E10EBBBC.Checked;
		}
	}

	private void F293E804(object sender, EventArgs e)
	{
	}

	private void D10C5E24(object sender, EventArgs e)
	{
		string text = txtApiKey.Text.Trim();
		string eD = D32B691F.CBAB1D17(text);
		GClass29.smethod_0(eD);
	}

	protected override void Dispose(bool D79F8E84)
	{
		if (D79F8E84 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(D79F8E84);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDChaySeeding));
		A394B792 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		AD2F0613 = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		button3 = new System.Windows.Forms.Button();
		groupBox2 = new System.Windows.Forms.GroupBox();
		E10EBBBC = new System.Windows.Forms.CheckBox();
		EB878635 = new System.Windows.Forms.CheckBox();
		ckbComment = new System.Windows.Forms.CheckBox();
		C981E515 = new System.Windows.Forms.CheckBox();
		BB9B8F3B = new System.Windows.Forms.CheckBox();
		ckbWow = new System.Windows.Forms.CheckBox();
		ckbLikePage = new System.Windows.Forms.CheckBox();
		E52D3E03 = new System.Windows.Forms.CheckBox();
		ckbLikeComment = new System.Windows.Forms.CheckBox();
		F39978B3 = new System.Windows.Forms.CheckBox();
		E281C4B8 = new System.Windows.Forms.CheckBox();
		ckbHaha = new System.Windows.Forms.CheckBox();
		ckbCare = new System.Windows.Forms.CheckBox();
		ckbAngry = new System.Windows.Forms.CheckBox();
		ckbRunByToken = new System.Windows.Forms.CheckBox();
		D9B00F82 = new System.Windows.Forms.LinkLabel();
		EB290929 = new System.Windows.Forms.CheckBox();
		nudLimitTo = new System.Windows.Forms.NumericUpDown();
		nudLimitFrom = new System.Windows.Forms.NumericUpDown();
		label4 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		nudChoLayJobTo = new System.Windows.Forms.NumericUpDown();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		CF21F2B7 = new System.Windows.Forms.NumericUpDown();
		label9 = new System.Windows.Forms.Label();
		nudMaxJobToday = new System.Windows.Forms.NumericUpDown();
		nudMaxJobFail = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		C011BE0A = new System.Windows.Forms.Label();
		label13 = new System.Windows.Forms.Label();
		label15 = new System.Windows.Forms.Label();
		label12 = new System.Windows.Forms.Label();
		label14 = new System.Windows.Forms.Label();
		label10 = new System.Windows.Forms.Label();
		label8 = new System.Windows.Forms.Label();
		E8343F09 = new System.Windows.Forms.Label();
		label11 = new System.Windows.Forms.Label();
		E808C622 = new System.Windows.Forms.Label();
		txtApiKey = new System.Windows.Forms.TextBox();
		label6 = new System.Windows.Forms.Label();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		B3993C1B = new System.Windows.Forms.Label();
		CB840339 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		AD2F0613.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudLimitTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudLimitFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudChoLayJobTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)CF21F2B7).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudMaxJobToday).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudMaxJobFail).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		A394B792.Fixed = true;
		A394B792.Horizontal = true;
		A394B792.TargetControl = bunifuCustomLabel1;
		A394B792.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(627, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Kiếm tiền Golike";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = AD2F0613;
		bunifuDragControl_0.Vertical = true;
		AD2F0613.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		AD2F0613.BackColor = System.Drawing.Color.White;
		AD2F0613.Controls.Add(button1);
		AD2F0613.Controls.Add(pictureBox1);
		AD2F0613.Controls.Add(bunifuCustomLabel1);
		AD2F0613.Cursor = System.Windows.Forms.Cursors.SizeAll;
		AD2F0613.Location = new System.Drawing.Point(0, 3);
		AD2F0613.Name = "pnlHeader";
		AD2F0613.Size = new System.Drawing.Size(627, 31);
		AD2F0613.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(596, 1);
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
		pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(button3);
		panel1.Controls.Add(groupBox2);
		panel1.Controls.Add(ckbRunByToken);
		panel1.Controls.Add(D9B00F82);
		panel1.Controls.Add(EB290929);
		panel1.Controls.Add(nudLimitTo);
		panel1.Controls.Add(nudLimitFrom);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(nudChoLayJobTo);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(CF21F2B7);
		panel1.Controls.Add(label9);
		panel1.Controls.Add(nudMaxJobToday);
		panel1.Controls.Add(nudMaxJobFail);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(C011BE0A);
		panel1.Controls.Add(label13);
		panel1.Controls.Add(label15);
		panel1.Controls.Add(label12);
		panel1.Controls.Add(label14);
		panel1.Controls.Add(label10);
		panel1.Controls.Add(label8);
		panel1.Controls.Add(E8343F09);
		panel1.Controls.Add(label11);
		panel1.Controls.Add(E808C622);
		panel1.Controls.Add(txtApiKey);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(B3993C1B);
		panel1.Controls.Add(CB840339);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(630, 355);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(C129AA97);
		button3.Cursor = System.Windows.Forms.Cursors.Hand;
		button3.Location = new System.Drawing.Point(302, 77);
		button3.Name = "button3";
		button3.Size = new System.Drawing.Size(51, 25);
		button3.TabIndex = 92;
		button3.Text = "Check";
		button3.UseVisualStyleBackColor = true;
		button3.Click += new System.EventHandler(D10C5E24);
		groupBox2.Controls.Add(E10EBBBC);
		groupBox2.Controls.Add(EB878635);
		groupBox2.Controls.Add(ckbComment);
		groupBox2.Controls.Add(C981E515);
		groupBox2.Controls.Add(BB9B8F3B);
		groupBox2.Controls.Add(ckbWow);
		groupBox2.Controls.Add(ckbLikePage);
		groupBox2.Controls.Add(E52D3E03);
		groupBox2.Controls.Add(ckbLikeComment);
		groupBox2.Controls.Add(F39978B3);
		groupBox2.Controls.Add(E281C4B8);
		groupBox2.Controls.Add(ckbHaha);
		groupBox2.Controls.Add(ckbCare);
		groupBox2.Controls.Add(ckbAngry);
		groupBox2.Location = new System.Drawing.Point(389, 78);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new System.Drawing.Size(210, 202);
		groupBox2.TabIndex = 48;
		groupBox2.TabStop = false;
		groupBox2.Text = " ";
		E10EBBBC.AutoSize = true;
		E10EBBBC.Cursor = System.Windows.Forms.Cursors.Hand;
		E10EBBBC.Location = new System.Drawing.Point(16, -1);
		E10EBBBC.Name = "ckbCheckAll";
		E10EBBBC.Size = new System.Drawing.Size(78, 20);
		E10EBBBC.TabIndex = 1;
		E10EBBBC.Text = "Chọn Job";
		E10EBBBC.UseVisualStyleBackColor = true;
		E10EBBBC.CheckedChanged += new System.EventHandler(E10EBBBC_CheckedChanged);
		EB878635.AutoSize = true;
		EB878635.Cursor = System.Windows.Forms.Cursors.Hand;
		EB878635.Location = new System.Drawing.Point(98, 23);
		EB878635.Name = "ckbFollow";
		EB878635.Size = new System.Drawing.Size(60, 20);
		EB878635.TabIndex = 0;
		EB878635.Text = "follow";
		EB878635.UseVisualStyleBackColor = true;
		ckbComment.AutoSize = true;
		ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbComment.Location = new System.Drawing.Point(98, 125);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new System.Drawing.Size(79, 20);
		ckbComment.TabIndex = 0;
		ckbComment.Text = "comment";
		ckbComment.UseVisualStyleBackColor = true;
		C981E515.AutoSize = true;
		C981E515.Cursor = System.Windows.Forms.Cursors.Hand;
		C981E515.Location = new System.Drawing.Point(16, 23);
		C981E515.Name = "ckbLike";
		C981E515.Size = new System.Drawing.Size(45, 20);
		C981E515.TabIndex = 0;
		C981E515.Text = "like";
		C981E515.UseVisualStyleBackColor = true;
		BB9B8F3B.AutoSize = true;
		BB9B8F3B.Cursor = System.Windows.Forms.Cursors.Hand;
		BB9B8F3B.Location = new System.Drawing.Point(98, 151);
		BB9B8F3B.Name = "ckbShare";
		BB9B8F3B.Size = new System.Drawing.Size(58, 20);
		BB9B8F3B.TabIndex = 0;
		BB9B8F3B.Text = "share";
		BB9B8F3B.UseVisualStyleBackColor = true;
		ckbWow.AutoSize = true;
		ckbWow.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbWow.Location = new System.Drawing.Point(16, 125);
		ckbWow.Name = "ckbWow";
		ckbWow.Size = new System.Drawing.Size(53, 20);
		ckbWow.TabIndex = 0;
		ckbWow.Text = "wow";
		ckbWow.UseVisualStyleBackColor = true;
		ckbLikePage.AutoSize = true;
		ckbLikePage.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLikePage.Location = new System.Drawing.Point(98, 48);
		ckbLikePage.Name = "ckbLikePage";
		ckbLikePage.Size = new System.Drawing.Size(80, 20);
		ckbLikePage.TabIndex = 0;
		ckbLikePage.Text = "like_page";
		ckbLikePage.UseVisualStyleBackColor = true;
		E52D3E03.AutoSize = true;
		E52D3E03.Cursor = System.Windows.Forms.Cursors.Hand;
		E52D3E03.Location = new System.Drawing.Point(16, 151);
		E52D3E03.Name = "ckbSad";
		E52D3E03.Size = new System.Drawing.Size(46, 20);
		E52D3E03.TabIndex = 0;
		E52D3E03.Text = "sad";
		E52D3E03.UseVisualStyleBackColor = true;
		ckbLikeComment.AutoSize = true;
		ckbLikeComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLikeComment.Location = new System.Drawing.Point(98, 100);
		ckbLikeComment.Name = "ckbLikeComment";
		ckbLikeComment.Size = new System.Drawing.Size(105, 20);
		ckbLikeComment.TabIndex = 0;
		ckbLikeComment.Text = "like_comment";
		ckbLikeComment.UseVisualStyleBackColor = true;
		F39978B3.AutoSize = true;
		F39978B3.Cursor = System.Windows.Forms.Cursors.Hand;
		F39978B3.Location = new System.Drawing.Point(16, 48);
		F39978B3.Name = "ckbLove";
		F39978B3.Size = new System.Drawing.Size(49, 20);
		F39978B3.TabIndex = 0;
		F39978B3.Text = "love";
		F39978B3.UseVisualStyleBackColor = true;
		E281C4B8.AutoSize = true;
		E281C4B8.Cursor = System.Windows.Forms.Cursors.Hand;
		E281C4B8.Location = new System.Drawing.Point(98, 74);
		E281C4B8.Name = "ckbJoinGroup";
		E281C4B8.Size = new System.Drawing.Size(87, 20);
		E281C4B8.TabIndex = 0;
		E281C4B8.Text = "join_group";
		E281C4B8.UseVisualStyleBackColor = true;
		ckbHaha.AutoSize = true;
		ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHaha.Location = new System.Drawing.Point(16, 100);
		ckbHaha.Name = "ckbHaha";
		ckbHaha.Size = new System.Drawing.Size(54, 20);
		ckbHaha.TabIndex = 0;
		ckbHaha.Text = "haha";
		ckbHaha.UseVisualStyleBackColor = true;
		ckbCare.AutoSize = true;
		ckbCare.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCare.Location = new System.Drawing.Point(16, 74);
		ckbCare.Name = "ckbCare";
		ckbCare.Size = new System.Drawing.Size(51, 20);
		ckbCare.TabIndex = 0;
		ckbCare.Text = "care";
		ckbCare.UseVisualStyleBackColor = true;
		ckbAngry.AutoSize = true;
		ckbAngry.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAngry.Location = new System.Drawing.Point(16, 177);
		ckbAngry.Name = "ckbAngry";
		ckbAngry.Size = new System.Drawing.Size(58, 20);
		ckbAngry.TabIndex = 0;
		ckbAngry.Text = "angry";
		ckbAngry.UseVisualStyleBackColor = true;
		ckbRunByToken.AutoSize = true;
		ckbRunByToken.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbRunByToken.Location = new System.Drawing.Point(31, 250);
		ckbRunByToken.Name = "ckbRunByToken";
		ckbRunByToken.Size = new System.Drawing.Size(121, 20);
		ckbRunByToken.TabIndex = 47;
		ckbRunByToken.Text = "Chạy bằng token";
		ckbRunByToken.UseVisualStyleBackColor = true;
		ckbRunByToken.CheckedChanged += new System.EventHandler(F293E804);
		D9B00F82.AutoSize = true;
		D9B00F82.Cursor = System.Windows.Forms.Cursors.Hand;
		D9B00F82.Location = new System.Drawing.Point(260, 277);
		D9B00F82.Name = "lblUnlock956";
		D9B00F82.Size = new System.Drawing.Size(57, 16);
		D9B00F82.TabIndex = 46;
		D9B00F82.TabStop = true;
		D9B00F82.Text = "Cấu hình";
		D9B00F82.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(F7105239);
		EB290929.AutoSize = true;
		EB290929.Cursor = System.Windows.Forms.Cursors.Hand;
		EB290929.Location = new System.Drawing.Point(31, 276);
		EB290929.Name = "ckbUnlock956";
		EB290929.Size = new System.Drawing.Size(224, 20);
		EB290929.TabIndex = 45;
		EB290929.Text = "Tự động Unlock 956 khi checkpoint";
		EB290929.UseVisualStyleBackColor = true;
		EB290929.CheckedChanged += new System.EventHandler(EB290929_CheckedChanged);
		nudLimitTo.Location = new System.Drawing.Point(263, 107);
		nudLimitTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudLimitTo.Name = "nudLimitTo";
		nudLimitTo.Size = new System.Drawing.Size(56, 23);
		nudLimitTo.TabIndex = 40;
		nudLimitFrom.Location = new System.Drawing.Point(166, 107);
		nudLimitFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudLimitFrom.Name = "nudLimitFrom";
		nudLimitFrom.Size = new System.Drawing.Size(56, 23);
		nudLimitFrom.TabIndex = 39;
		label4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label4.Location = new System.Drawing.Point(228, 109);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(29, 16);
		label4.TabIndex = 43;
		label4.Text = ">";
		label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(27, 109);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(133, 16);
		label3.TabIndex = 41;
		label3.Text = "Số lượng job success:";
		nudChoLayJobTo.Location = new System.Drawing.Point(263, 136);
		nudChoLayJobTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudChoLayJobTo.Name = "nudChoLayJobTo";
		nudChoLayJobTo.Size = new System.Drawing.Size(56, 23);
		nudChoLayJobTo.TabIndex = 40;
		nudDelayTo.Location = new System.Drawing.Point(263, 165);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Minimum = new decimal(new int[4] { 10, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 40;
		nudDelayTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		CF21F2B7.Location = new System.Drawing.Point(166, 136);
		CF21F2B7.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		CF21F2B7.Name = "nudChoLayJobFrom";
		CF21F2B7.Size = new System.Drawing.Size(56, 23);
		CF21F2B7.TabIndex = 39;
		label9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label9.Location = new System.Drawing.Point(228, 138);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(29, 16);
		label9.TabIndex = 43;
		label9.Text = ">";
		label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudMaxJobToday.Location = new System.Drawing.Point(263, 223);
		nudMaxJobToday.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudMaxJobToday.Name = "nudMaxJobToday";
		nudMaxJobToday.Size = new System.Drawing.Size(56, 23);
		nudMaxJobToday.TabIndex = 39;
		nudMaxJobFail.Location = new System.Drawing.Point(263, 194);
		nudMaxJobFail.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudMaxJobFail.Name = "nudMaxJobFail";
		nudMaxJobFail.Size = new System.Drawing.Size(56, 23);
		nudMaxJobFail.TabIndex = 39;
		nudDelayFrom.Location = new System.Drawing.Point(166, 165);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Minimum = new decimal(new int[4] { 10, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 39;
		nudDelayFrom.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		C011BE0A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C011BE0A.Location = new System.Drawing.Point(228, 167);
		C011BE0A.Name = "label7";
		C011BE0A.Size = new System.Drawing.Size(29, 16);
		C011BE0A.TabIndex = 43;
		C011BE0A.Text = ">";
		C011BE0A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label13.AutoSize = true;
		label13.Location = new System.Drawing.Point(322, 225);
		label13.Name = "label13";
		label13.Size = new System.Drawing.Size(31, 16);
		label13.TabIndex = 41;
		label13.Text = "jobs";
		label15.AutoSize = true;
		label15.Location = new System.Drawing.Point(322, 109);
		label15.Name = "label15";
		label15.Size = new System.Drawing.Size(31, 16);
		label15.TabIndex = 41;
		label15.Text = "jobs";
		label12.AutoSize = true;
		label12.Location = new System.Drawing.Point(322, 196);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(31, 16);
		label12.TabIndex = 41;
		label12.Text = "jobs";
		label14.AutoSize = true;
		label14.Location = new System.Drawing.Point(322, 167);
		label14.Name = "label14";
		label14.Size = new System.Drawing.Size(30, 16);
		label14.TabIndex = 41;
		label14.Text = "giây";
		label10.AutoSize = true;
		label10.Location = new System.Drawing.Point(322, 138);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(32, 16);
		label10.TabIndex = 41;
		label10.Text = "phút";
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(27, 138);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(125, 16);
		label8.TabIndex = 41;
		label8.Text = "Timeout chờ lấy job:";
		E8343F09.AutoSize = true;
		E8343F09.Location = new System.Drawing.Point(27, 225);
		E8343F09.Name = "label2";
		E8343F09.Size = new System.Drawing.Size(174, 16);
		E8343F09.TabIndex = 41;
		E8343F09.Text = "Số job tối đa/tài khoản/ngày:";
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(27, 196);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(132, 16);
		label11.TabIndex = 41;
		label11.Text = "Dừng khi fail liên tiếp:";
		E808C622.AutoSize = true;
		E808C622.Location = new System.Drawing.Point(27, 167);
		E808C622.Name = "label5";
		E808C622.Size = new System.Drawing.Size(99, 16);
		E808C622.TabIndex = 41;
		E808C622.Text = "Nghỉ giữa 2 job:";
		txtApiKey.Location = new System.Drawing.Point(166, 78);
		txtApiKey.Name = "txtApiKey";
		txtApiKey.Size = new System.Drawing.Size(130, 23);
		txtApiKey.TabIndex = 0;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(27, 81);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(54, 16);
		label6.TabIndex = 31;
		label6.Text = "Api Key:";
		txtTenHanhDong.Location = new System.Drawing.Point(166, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(186, 23);
		txtTenHanhDong.TabIndex = 0;
		B3993C1B.AutoSize = true;
		B3993C1B.Location = new System.Drawing.Point(27, 52);
		B3993C1B.Name = "label1";
		B3993C1B.Size = new System.Drawing.Size(98, 16);
		B3993C1B.TabIndex = 31;
		B3993C1B.Text = "Tên ha\u0300nh đô\u0323ng:";
		CB840339.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		CB840339.BackColor = System.Drawing.Color.Maroon;
		CB840339.Cursor = System.Windows.Forms.Cursors.Hand;
		CB840339.FlatAppearance.BorderSize = 0;
		CB840339.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		CB840339.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CB840339.ForeColor = System.Drawing.Color.White;
		CB840339.Location = new System.Drawing.Point(323, 311);
		CB840339.Name = "btnCancel";
		CB840339.Size = new System.Drawing.Size(92, 29);
		CB840339.TabIndex = 10;
		CB840339.Text = "Đóng";
		CB840339.UseVisualStyleBackColor = false;
		CB840339.Click += new System.EventHandler(B530752F);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(216, 311);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(AD2F0613);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(627, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(630, 355);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDChaySeeding";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDChaySeeding_Load);
		AD2F0613.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		groupBox2.ResumeLayout(false);
		groupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudLimitTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudLimitFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudChoLayJobTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)CF21F2B7).EndInit();
		((System.ComponentModel.ISupportInitialize)nudMaxJobToday).EndInit();
		((System.ComponentModel.ISupportInitialize)nudMaxJobFail).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
