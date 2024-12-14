using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class AA365D0E : Form
{
	private GClass11 gclass11_0;

	private string ED87A1AF;

	private string E03D932C;

	private string string_0;

	private int int_0;

	public static bool bool_0;

	private IContainer D4BB02AC = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel FFA60C02;

	private TextBox A321ED2D;

	private Label label1;

	private Button btnCancel;

	private Button A29D0ABD;

	private BunifuCards bunifuCards1;

	private Panel E5107D0E;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel A21640BC;

	private Panel plComment;

	private Label lblStatus;

	private Panel plInteract;

	private Label label25;

	private Label label26;

	private Label label27;

	private Label label28;

	private Label label29;

	private Label BE3B670A;

	private CheckBox DD2F60A2;

	private CheckBox EEB8310C;

	private CheckBox ckbWow;

	private CheckBox ckbHaha;

	private CheckBox E9153BAD;

	private CheckBox ckbTym;

	private CheckBox ED3DF59F;

	private Label A32EF625;

	private CheckBox B1AE7AA4;

	private CheckBox ckbInteract;

	private TextBox txtComment;

	private Button button2;

	private Label E518A4BA;

	private Label label2;

	private TextBox txtLinkStory;

	public AA365D0E(string string_1, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		ED87A1AF = string_1;
		string_0 = string_2;
		int_0 = int_1;
		if (Class147.smethod_7("", "HDXemStoryChiDinh").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDXemStoryChiDinh','Xem story chỉ định');");
		}
		string string_3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDXemStoryChiDinh");
			string_3 = dataTable2.Rows[0]["CauHinh"].ToString();
			E03D932C = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			A321ED2D.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_2);
			string_3 = dataTable.Rows[0]["CauHinh"].ToString();
			A29D0ABD.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			A321ED2D.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(string_3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void A7025A89()
	{
		F7AB102E.smethod_1(A21640BC);
		F7AB102E.smethod_1(label1);
		F7AB102E.smethod_1(label2);
		F7AB102E.smethod_1(ckbInteract);
		F7AB102E.smethod_1(label26);
		F7AB102E.smethod_1(label27);
		F7AB102E.smethod_1(BE3B670A);
		F7AB102E.smethod_1(A32EF625);
		F7AB102E.smethod_1(B1AE7AA4);
		F7AB102E.smethod_1(lblStatus);
		F7AB102E.smethod_1(button2);
		F7AB102E.smethod_1(E518A4BA);
		F7AB102E.smethod_1(A29D0ABD);
		F7AB102E.smethod_1(btnCancel);
	}

	private void FD95AAAB(object sender, EventArgs e)
	{
		try
		{
			txtLinkStory.Text = gclass11_0.C0288288("txtLinkStory");
			ckbInteract.Checked = gclass11_0.method_3("ckbInteract");
			string text = gclass11_0.C0288288("typeReaction");
			List<CheckBox> list = new List<CheckBox> { ED3DF59F, ckbTym, E9153BAD, ckbHaha, ckbWow, EEB8310C, DD2F60A2 };
			for (int i = 0; i < list.Count; i++)
			{
				if (text.Contains(i.ToString()))
				{
					list[i].Checked = true;
				}
			}
			B1AE7AA4.Checked = gclass11_0.method_3("ckbComment");
			txtComment.Text = gclass11_0.C0288288("txtComment");
		}
		catch
		{
		}
		EA86D098();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C21E5E97(object sender, EventArgs e)
	{
		string text = A321ED2D.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		if (B1AE7AA4.Checked)
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
		gClass.method_4("txtLinkStory", txtLinkStory.Text);
		gClass.method_4("ckbInteract", ckbInteract.Checked);
		string text2 = "";
		List<CheckBox> list = new List<CheckBox> { ED3DF59F, ckbTym, E9153BAD, ckbHaha, ckbWow, EEB8310C, DD2F60A2 };
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].Checked)
			{
				text2 += i;
			}
		}
		gClass.method_4("typeReaction", text2);
		gClass.method_4("ckbComment", B1AE7AA4.Checked);
		gClass.method_4("txtComment", txtComment.Text.Trim());
		string text3 = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(ED87A1AF, text, E03D932C, text3))
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
			if (Class147.smethod_13(string_0, text, text3))
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

	private void FFA60C02_Paint(object sender, PaintEventArgs e)
	{
		if (FFA60C02.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, FFA60C02.ClientSize.Width - num, FFA60C02.ClientSize.Height - num));
		}
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtComment.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			lblStatus.Text = string.Format(F7AB102E.smethod_0("Nội dung bình luận ({0}):"), e03C713E.Count.ToString());
		}
		catch
		{
		}
	}

	private void EA86D098()
	{
		ckbInteract_CheckedChanged(null, null);
		B1AE7AA4_CheckedChanged(null, null);
	}

	private void ckbInteract_CheckedChanged(object sender, EventArgs e)
	{
		plInteract.Enabled = ckbInteract.Checked;
	}

	private void B1AE7AA4_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = B1AE7AA4.Checked;
	}

	private void label25_Click(object sender, EventArgs e)
	{
		ED3DF59F.Checked = !ED3DF59F.Checked;
	}

	private void label26_Click(object sender, EventArgs e)
	{
		ckbTym.Checked = !ckbTym.Checked;
	}

	private void F5BCEF14(object sender, EventArgs e)
	{
		E9153BAD.Checked = !E9153BAD.Checked;
	}

	private void D1AD5C37(object sender, EventArgs e)
	{
		ckbHaha.Checked = !ckbHaha.Checked;
	}

	private void B49E2F37(object sender, EventArgs e)
	{
		ckbWow.Checked = !ckbWow.Checked;
	}

	private void BE3B670A_Click(object sender, EventArgs e)
	{
		EEB8310C.Checked = !EEB8310C.Checked;
	}

	private void A32EF625_Click(object sender, EventArgs e)
	{
		DD2F60A2.Checked = !DD2F60A2.Checked;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		GClass29.smethod_0("Có thể dùng [u] để thay thế tên của người đăng story!");
	}

	private void C62AEEB6(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtLinkStory.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			label2.Text = string.Format(F7AB102E.smethod_0("Danh sách link ({0}):"), e03C713E.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && D4BB02AC != null)
		{
			D4BB02AC.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		D4BB02AC = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AA365D0E));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(D4BB02AC);
		A21640BC = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(D4BB02AC);
		E5107D0E = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		FFA60C02 = new System.Windows.Forms.Panel();
		txtLinkStory = new System.Windows.Forms.TextBox();
		plComment = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		E518A4BA = new System.Windows.Forms.Label();
		txtComment = new System.Windows.Forms.TextBox();
		lblStatus = new System.Windows.Forms.Label();
		plInteract = new System.Windows.Forms.Panel();
		label25 = new System.Windows.Forms.Label();
		label26 = new System.Windows.Forms.Label();
		label27 = new System.Windows.Forms.Label();
		label28 = new System.Windows.Forms.Label();
		label29 = new System.Windows.Forms.Label();
		BE3B670A = new System.Windows.Forms.Label();
		DD2F60A2 = new System.Windows.Forms.CheckBox();
		EEB8310C = new System.Windows.Forms.CheckBox();
		ckbWow = new System.Windows.Forms.CheckBox();
		ckbHaha = new System.Windows.Forms.CheckBox();
		E9153BAD = new System.Windows.Forms.CheckBox();
		ckbTym = new System.Windows.Forms.CheckBox();
		ED3DF59F = new System.Windows.Forms.CheckBox();
		A32EF625 = new System.Windows.Forms.Label();
		B1AE7AA4 = new System.Windows.Forms.CheckBox();
		ckbInteract = new System.Windows.Forms.CheckBox();
		A321ED2D = new System.Windows.Forms.TextBox();
		label2 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		A29D0ABD = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		E5107D0E.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		FFA60C02.SuspendLayout();
		plComment.SuspendLayout();
		plInteract.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = A21640BC;
		bunifuDragControl_0.Vertical = true;
		A21640BC.BackColor = System.Drawing.Color.Transparent;
		A21640BC.Cursor = System.Windows.Forms.Cursors.SizeAll;
		A21640BC.Dock = System.Windows.Forms.DockStyle.Fill;
		A21640BC.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A21640BC.ForeColor = System.Drawing.Color.Black;
		A21640BC.Location = new System.Drawing.Point(0, 0);
		A21640BC.Name = "bunifuCustomLabel1";
		A21640BC.Size = new System.Drawing.Size(359, 31);
		A21640BC.TabIndex = 12;
		A21640BC.Text = "Cấu hình Xem Story";
		A21640BC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = E5107D0E;
		bunifuDragControl_1.Vertical = true;
		E5107D0E.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		E5107D0E.BackColor = System.Drawing.Color.White;
		E5107D0E.Controls.Add(button1);
		E5107D0E.Controls.Add(pictureBox1);
		E5107D0E.Controls.Add(A21640BC);
		E5107D0E.Cursor = System.Windows.Forms.Cursors.SizeAll;
		E5107D0E.Location = new System.Drawing.Point(0, 3);
		E5107D0E.Name = "pnlHeader";
		E5107D0E.Size = new System.Drawing.Size(359, 31);
		E5107D0E.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(328, 1);
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
		FFA60C02.BackColor = System.Drawing.Color.White;
		FFA60C02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		FFA60C02.Controls.Add(txtLinkStory);
		FFA60C02.Controls.Add(plComment);
		FFA60C02.Controls.Add(plInteract);
		FFA60C02.Controls.Add(B1AE7AA4);
		FFA60C02.Controls.Add(ckbInteract);
		FFA60C02.Controls.Add(A321ED2D);
		FFA60C02.Controls.Add(label2);
		FFA60C02.Controls.Add(label1);
		FFA60C02.Controls.Add(btnCancel);
		FFA60C02.Controls.Add(A29D0ABD);
		FFA60C02.Controls.Add(bunifuCards1);
		FFA60C02.Cursor = System.Windows.Forms.Cursors.Arrow;
		FFA60C02.Dock = System.Windows.Forms.DockStyle.Fill;
		FFA60C02.Location = new System.Drawing.Point(0, 0);
		FFA60C02.Name = "panel1";
		FFA60C02.Size = new System.Drawing.Size(362, 266);
		FFA60C02.TabIndex = 0;
		FFA60C02.Paint += new System.Windows.Forms.PaintEventHandler(FFA60C02_Paint);
		txtLinkStory.Location = new System.Drawing.Point(30, 98);
		txtLinkStory.Multiline = true;
		txtLinkStory.Name = "txtLinkStory";
		txtLinkStory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		txtLinkStory.Size = new System.Drawing.Size(296, 111);
		txtLinkStory.TabIndex = 32;
		txtLinkStory.WordWrap = false;
		txtLinkStory.TextChanged += new System.EventHandler(C62AEEB6);
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(button2);
		plComment.Controls.Add(E518A4BA);
		plComment.Controls.Add(txtComment);
		plComment.Controls.Add(lblStatus);
		plComment.Location = new System.Drawing.Point(48, 378);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(278, 164);
		plComment.TabIndex = 8;
		button2.Cursor = System.Windows.Forms.Cursors.Help;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(246, 2);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(23, 23);
		button2.TabIndex = 3;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		E518A4BA.AutoSize = true;
		E518A4BA.Location = new System.Drawing.Point(3, 141);
		E518A4BA.Name = "label8";
		E518A4BA.Size = new System.Drawing.Size(265, 16);
		E518A4BA.TabIndex = 2;
		E518A4BA.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		txtComment.Location = new System.Drawing.Point(7, 27);
		txtComment.Multiline = true;
		txtComment.Name = "txtComment";
		txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		txtComment.Size = new System.Drawing.Size(261, 111);
		txtComment.TabIndex = 1;
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(3, 5);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(139, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Nội dung bình luận (0):";
		plInteract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plInteract.Controls.Add(label25);
		plInteract.Controls.Add(label26);
		plInteract.Controls.Add(label27);
		plInteract.Controls.Add(label28);
		plInteract.Controls.Add(label29);
		plInteract.Controls.Add(BE3B670A);
		plInteract.Controls.Add(DD2F60A2);
		plInteract.Controls.Add(EEB8310C);
		plInteract.Controls.Add(ckbWow);
		plInteract.Controls.Add(ckbHaha);
		plInteract.Controls.Add(E9153BAD);
		plInteract.Controls.Add(ckbTym);
		plInteract.Controls.Add(ED3DF59F);
		plInteract.Controls.Add(A32EF625);
		plInteract.Location = new System.Drawing.Point(48, 309);
		plInteract.Name = "plInteract";
		plInteract.Size = new System.Drawing.Size(278, 40);
		plInteract.TabIndex = 6;
		label25.Cursor = System.Windows.Forms.Cursors.Hand;
		label25.Location = new System.Drawing.Point(4, 1);
		label25.Name = "label25";
		label25.Size = new System.Drawing.Size(30, 16);
		label25.TabIndex = 0;
		label25.Text = "Like";
		label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label25.Click += new System.EventHandler(label25_Click);
		label26.Cursor = System.Windows.Forms.Cursors.Hand;
		label26.Location = new System.Drawing.Point(40, 1);
		label26.Name = "label26";
		label26.Size = new System.Drawing.Size(33, 16);
		label26.TabIndex = 2;
		label26.Text = "Tym";
		label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label26.Click += new System.EventHandler(label26_Click);
		label27.Cursor = System.Windows.Forms.Cursors.Hand;
		label27.Location = new System.Drawing.Point(75, 1);
		label27.Name = "label27";
		label27.Size = new System.Drawing.Size(52, 16);
		label27.TabIndex = 4;
		label27.Text = "Thương";
		label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label27.Click += new System.EventHandler(F5BCEF14);
		label28.Cursor = System.Windows.Forms.Cursors.Hand;
		label28.Location = new System.Drawing.Point(128, 1);
		label28.Name = "label28";
		label28.Size = new System.Drawing.Size(37, 16);
		label28.TabIndex = 6;
		label28.Text = "Haha";
		label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label28.Click += new System.EventHandler(D1AD5C37);
		label29.Cursor = System.Windows.Forms.Cursors.Hand;
		label29.Location = new System.Drawing.Point(167, 1);
		label29.Name = "label29";
		label29.Size = new System.Drawing.Size(37, 16);
		label29.TabIndex = 8;
		label29.Text = "Wow";
		label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label29.Click += new System.EventHandler(B49E2F37);
		BE3B670A.Cursor = System.Windows.Forms.Cursors.Hand;
		BE3B670A.Location = new System.Drawing.Point(206, 1);
		BE3B670A.Name = "label30";
		BE3B670A.Size = new System.Drawing.Size(36, 16);
		BE3B670A.TabIndex = 10;
		BE3B670A.Text = "Buồn";
		BE3B670A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		BE3B670A.Click += new System.EventHandler(BE3B670A_Click);
		DD2F60A2.AutoSize = true;
		DD2F60A2.Cursor = System.Windows.Forms.Cursors.Hand;
		DD2F60A2.Location = new System.Drawing.Point(252, 20);
		DD2F60A2.Name = "ckbGian";
		DD2F60A2.Size = new System.Drawing.Size(15, 14);
		DD2F60A2.TabIndex = 13;
		DD2F60A2.UseVisualStyleBackColor = true;
		EEB8310C.AutoSize = true;
		EEB8310C.Cursor = System.Windows.Forms.Cursors.Hand;
		EEB8310C.Location = new System.Drawing.Point(218, 20);
		EEB8310C.Name = "ckbBuon";
		EEB8310C.Size = new System.Drawing.Size(15, 14);
		EEB8310C.TabIndex = 11;
		EEB8310C.UseVisualStyleBackColor = true;
		ckbWow.AutoSize = true;
		ckbWow.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbWow.Location = new System.Drawing.Point(179, 20);
		ckbWow.Name = "ckbWow";
		ckbWow.Size = new System.Drawing.Size(15, 14);
		ckbWow.TabIndex = 9;
		ckbWow.UseVisualStyleBackColor = true;
		ckbHaha.AutoSize = true;
		ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHaha.Location = new System.Drawing.Point(139, 20);
		ckbHaha.Name = "ckbHaha";
		ckbHaha.Size = new System.Drawing.Size(15, 14);
		ckbHaha.TabIndex = 7;
		ckbHaha.UseVisualStyleBackColor = true;
		E9153BAD.AutoSize = true;
		E9153BAD.Cursor = System.Windows.Forms.Cursors.Hand;
		E9153BAD.Location = new System.Drawing.Point(94, 20);
		E9153BAD.Name = "ckbThuong";
		E9153BAD.Size = new System.Drawing.Size(15, 14);
		E9153BAD.TabIndex = 5;
		E9153BAD.UseVisualStyleBackColor = true;
		ckbTym.AutoSize = true;
		ckbTym.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTym.Location = new System.Drawing.Point(48, 20);
		ckbTym.Name = "ckbTym";
		ckbTym.Size = new System.Drawing.Size(15, 14);
		ckbTym.TabIndex = 3;
		ckbTym.UseVisualStyleBackColor = true;
		ED3DF59F.AutoSize = true;
		ED3DF59F.Cursor = System.Windows.Forms.Cursors.Hand;
		ED3DF59F.Location = new System.Drawing.Point(11, 20);
		ED3DF59F.Name = "ckbLike";
		ED3DF59F.Size = new System.Drawing.Size(15, 14);
		ED3DF59F.TabIndex = 1;
		ED3DF59F.UseVisualStyleBackColor = true;
		A32EF625.Cursor = System.Windows.Forms.Cursors.Hand;
		A32EF625.Location = new System.Drawing.Point(242, 1);
		A32EF625.Name = "label32";
		A32EF625.Size = new System.Drawing.Size(33, 16);
		A32EF625.TabIndex = 12;
		A32EF625.Text = "Giận";
		A32EF625.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		A32EF625.Click += new System.EventHandler(A32EF625_Click);
		B1AE7AA4.AutoSize = true;
		B1AE7AA4.Cursor = System.Windows.Forms.Cursors.Hand;
		B1AE7AA4.Location = new System.Drawing.Point(30, 353);
		B1AE7AA4.Name = "ckbComment";
		B1AE7AA4.Size = new System.Drawing.Size(130, 20);
		B1AE7AA4.TabIndex = 7;
		B1AE7AA4.Text = "Tư\u0323 đô\u0323ng bi\u0300nh luâ\u0323n";
		B1AE7AA4.UseVisualStyleBackColor = true;
		B1AE7AA4.CheckedChanged += new System.EventHandler(B1AE7AA4_CheckedChanged);
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(30, 285);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(112, 20);
		ckbInteract.TabIndex = 5;
		ckbInteract.Text = "Ba\u0300y to\u0309 ca\u0309m xu\u0301c";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += new System.EventHandler(ckbInteract_CheckedChanged);
		A321ED2D.Location = new System.Drawing.Point(132, 49);
		A321ED2D.Name = "txtTenHanhDong";
		A321ED2D.Size = new System.Drawing.Size(194, 23);
		A321ED2D.TabIndex = 0;
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 78);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(115, 16);
		label2.TabIndex = 31;
		label2.Text = "Danh sách link (0):";
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
		btnCancel.Location = new System.Drawing.Point(189, 224);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		A29D0ABD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		A29D0ABD.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		A29D0ABD.Cursor = System.Windows.Forms.Cursors.Hand;
		A29D0ABD.FlatAppearance.BorderSize = 0;
		A29D0ABD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A29D0ABD.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A29D0ABD.ForeColor = System.Drawing.Color.White;
		A29D0ABD.Location = new System.Drawing.Point(82, 224);
		A29D0ABD.Name = "btnAdd";
		A29D0ABD.Size = new System.Drawing.Size(92, 29);
		A29D0ABD.TabIndex = 9;
		A29D0ABD.Text = "Thêm";
		A29D0ABD.UseVisualStyleBackColor = false;
		A29D0ABD.Click += new System.EventHandler(C21E5E97);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(E5107D0E);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 266);
		base.Controls.Add(FFA60C02);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDXemStoryChiDinh";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(FD95AAAB);
		E5107D0E.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		FFA60C02.ResumeLayout(false);
		FFA60C02.PerformLayout();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		plInteract.ResumeLayout(false);
		plInteract.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
