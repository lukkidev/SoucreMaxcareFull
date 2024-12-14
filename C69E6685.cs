using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class C69E6685 : Form
{
	private GClass11 F8AC2A1C;

	private string CC9EF8A5;

	private string string_0;

	private string string_1;

	private int F0132D21;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl D8105DB2;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label label2;

	private Label label1;

	private Button C58ABA34;

	private Button E5861609;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button B382CE31;

	private PictureBox DC9612A2;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown C4B9DD3B;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label5;

	private RichTextBox txtPageName;

	private RichTextBox CD2BB519;

	private Label D399D8B5;

	private Label lblCatagory;

	private TextBox txtToCookie;

	private Label BE99C6AD;

	private CheckBox C631D0A7;

	public C69E6685(string string_2, int int_0 = 0, string F6ACC8B2 = "")
	{
		A2B0D9BF();
		bool_0 = false;
		CC9EF8A5 = string_2;
		string_1 = F6ACC8B2;
		F0132D21 = int_0;
		if (Class147.smethod_7("", "HDTaoPage").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTaoPage', 'Tạo Page');");
		}
		string text = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDTaoPage");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = dataTable2.Rows[0]["MoTa"].ToString();
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(F6ACC8B2);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			E5861609.Text = "Câ\u0323p nhâ\u0323t";
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		F8AC2A1C = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
		BE99C6AD.Visible = Class57.bool_0;
		txtToCookie.Visible = Class57.bool_0;
	}

	private void C69E6685_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = F8AC2A1C.method_2("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = F8AC2A1C.method_2("nudSoLuongTo", 1);
			nudDelayFrom.Value = F8AC2A1C.method_2("nudDelayFrom", 3);
			C4B9DD3B.Value = F8AC2A1C.method_2("nudDelayTo", 5);
			txtPageName.Text = F8AC2A1C.C0288288("txtPageName");
			CD2BB519.Text = F8AC2A1C.C0288288("txtCatagory");
			C631D0A7.Checked = F8AC2A1C.method_3("ckbAutoDeleteContent");
			txtToCookie.Text = F8AC2A1C.C0288288("txtToCookie");
		}
		catch
		{
		}
		txtPageName.smethod_2("Nhập tên page (có thể sử dụng ký tự * để random 1 số từ 0 -> 9, ví dụ: Phần mềm nuôi nick ***)...");
		CD2BB519.smethod_2("Nhập tên danh mục page bằng tiếng anh (ví dụ: digital creator, creator)...");
	}

	private void B382CE31_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E5861609_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", C4B9DD3B.Value);
		gClass.method_4("txtPageName", (txtPageName.Text == "Nhập tên page (có thể sử dụng ký tự * để random 1 số từ 0 -> 9, ví dụ: Phần mềm nuôi nick ***)...") ? "" : txtPageName.Text);
		gClass.method_4("txtCatagory", (CD2BB519.Text == "Nhập tên danh mục page bằng tiếng anh (ví dụ: digital creator, creator)...") ? "" : CD2BB519.Text);
		gClass.method_4("ckbAutoDeleteContent", C631D0A7.Checked);
		gClass.method_4("txtToCookie", txtToCookie.Text);
		string string_ = gClass.method_7();
		if (F0132D21 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(CC9EF8A5, text, string_0, string_))
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
			if (Class147.smethod_13(string_1, text, string_))
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

	private void D48A633B(object sender, EventArgs e)
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

	private void txtPageName_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtPageName, D399D8B5);
	}

	private void CD2BB519_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(CD2BB519, lblCatagory);
	}

	protected override void Dispose(bool EA3BD887)
	{
		if (EA3BD887 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(EA3BD887);
	}

	private void A2B0D9BF()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(C69E6685));
		D8105DB2 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		B382CE31 = new Button();
		DC9612A2 = new PictureBox();
		panel1 = new Panel();
		txtPageName = new RichTextBox();
		CD2BB519 = new RichTextBox();
		C4B9DD3B = new NumericUpDown();
		D399D8B5 = new Label();
		lblCatagory = new Label();
		nudDelayFrom = new NumericUpDown();
		label7 = new Label();
		label5 = new Label();
		nudSoLuongTo = new NumericUpDown();
		nudSoLuongFrom = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		label3 = new Label();
		label2 = new Label();
		label1 = new Label();
		C58ABA34 = new Button();
		E5861609 = new Button();
		bunifuCards1 = new BunifuCards();
		txtToCookie = new TextBox();
		BE99C6AD = new Label();
		C631D0A7 = new CheckBox();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)DC9612A2).BeginInit();
		panel1.SuspendLayout();
		((ISupportInitialize)C4B9DD3B).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		((ISupportInitialize)nudSoLuongTo).BeginInit();
		((ISupportInitialize)nudSoLuongFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		D8105DB2.Fixed = true;
		D8105DB2.Horizontal = true;
		D8105DB2.TargetControl = bunifuCustomLabel1;
		D8105DB2.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(352, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Tạo page";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(B382CE31);
		pnlHeader.Controls.Add(DC9612A2);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(352, 31);
		pnlHeader.TabIndex = 9;
		B382CE31.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		B382CE31.Cursor = Cursors.Hand;
		B382CE31.FlatAppearance.BorderSize = 0;
		B382CE31.FlatStyle = FlatStyle.Flat;
		B382CE31.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		B382CE31.ForeColor = Color.White;
		B382CE31.Image = (Image)componentResourceManager.GetObject("button1.Image");
		B382CE31.Location = new Point(321, 1);
		B382CE31.Name = "button1";
		B382CE31.Size = new Size(30, 30);
		B382CE31.TabIndex = 77;
		B382CE31.TextImageRelation = TextImageRelation.ImageBeforeText;
		B382CE31.UseVisualStyleBackColor = true;
		B382CE31.Click += B382CE31_Click;
		DC9612A2.Cursor = Cursors.Default;
		DC9612A2.Image = C50FB39E.Bitmap_5;
		DC9612A2.Location = new Point(3, 2);
		DC9612A2.Name = "pictureBox1";
		DC9612A2.Size = new Size(34, 27);
		DC9612A2.SizeMode = PictureBoxSizeMode.Zoom;
		DC9612A2.TabIndex = 76;
		DC9612A2.TabStop = false;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(C631D0A7);
		panel1.Controls.Add(txtPageName);
		panel1.Controls.Add(CD2BB519);
		panel1.Controls.Add(C4B9DD3B);
		panel1.Controls.Add(D399D8B5);
		panel1.Controls.Add(lblCatagory);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(C58ABA34);
		panel1.Controls.Add(E5861609);
		panel1.Controls.Add(bunifuCards1);
		panel1.Controls.Add(txtToCookie);
		panel1.Controls.Add(BE99C6AD);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(355, 438);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		txtPageName.Location = new Point(30, 153);
		txtPageName.Name = "txtPageName";
		txtPageName.Size = new Size(295, 98);
		txtPageName.TabIndex = 47;
		txtPageName.Text = "";
		txtPageName.WordWrap = false;
		txtPageName.TextChanged += txtPageName_TextChanged;
		CD2BB519.Location = new Point(30, 272);
		CD2BB519.Name = "txtCatagory";
		CD2BB519.Size = new Size(295, 98);
		CD2BB519.TabIndex = 47;
		CD2BB519.Text = "";
		CD2BB519.WordWrap = false;
		CD2BB519.TextChanged += CD2BB519_TextChanged;
		C4B9DD3B.Location = new Point(229, 107);
		C4B9DD3B.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C4B9DD3B.Name = "nudDelayTo";
		C4B9DD3B.Size = new Size(56, 23);
		C4B9DD3B.TabIndex = 4;
		D399D8B5.AutoSize = true;
		D399D8B5.Location = new Point(27, 135);
		D399D8B5.Name = "lblPageName";
		D399D8B5.Size = new Size(87, 16);
		D399D8B5.TabIndex = 0;
		D399D8B5.Text = "Tên page (0):";
		lblCatagory.AutoSize = true;
		lblCatagory.Location = new Point(27, 254);
		lblCatagory.Name = "lblCatagory";
		lblCatagory.Size = new Size(122, 16);
		lblCatagory.TabIndex = 0;
		lblCatagory.Text = "Danh mục page (0):";
		nudDelayFrom.Location = new Point(132, 107);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		label7.AutoSize = true;
		label7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label7.Location = new Point(199, 109);
		label7.Name = "label7";
		label7.Size = new Size(18, 16);
		label7.TabIndex = 46;
		label7.Text = ">";
		label5.AutoSize = true;
		label5.Location = new Point(27, 109);
		label5.Name = "label5";
		label5.Size = new Size(92, 16);
		label5.TabIndex = 44;
		label5.Text = "Delay time (s):";
		nudSoLuongTo.Location = new Point(229, 78);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudSoLuongFrom.Location = new Point(132, 78);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label3.AutoSize = true;
		label3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label3.Location = new Point(199, 80);
		label3.Name = "label3";
		label3.Size = new Size(18, 16);
		label3.TabIndex = 37;
		label3.Text = ">";
		label2.AutoSize = true;
		label2.Location = new Point(27, 80);
		label2.Name = "label2";
		label2.Size = new Size(95, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng page:";
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		C58ABA34.Anchor = AnchorStyles.Bottom;
		C58ABA34.BackColor = Color.Maroon;
		C58ABA34.Cursor = Cursors.Hand;
		C58ABA34.FlatAppearance.BorderSize = 0;
		C58ABA34.FlatStyle = FlatStyle.Flat;
		C58ABA34.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C58ABA34.ForeColor = Color.White;
		C58ABA34.Location = new Point(184, 394);
		C58ABA34.Name = "btnCancel";
		C58ABA34.Size = new Size(92, 29);
		C58ABA34.TabIndex = 7;
		C58ABA34.Text = "Đóng";
		C58ABA34.UseVisualStyleBackColor = false;
		C58ABA34.Click += D48A633B;
		E5861609.Anchor = AnchorStyles.Bottom;
		E5861609.BackColor = Color.FromArgb(53, 120, 229);
		E5861609.Cursor = Cursors.Hand;
		E5861609.FlatAppearance.BorderSize = 0;
		E5861609.FlatStyle = FlatStyle.Flat;
		E5861609.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		E5861609.ForeColor = Color.White;
		E5861609.Location = new Point(77, 394);
		E5861609.Name = "btnAdd";
		E5861609.Size = new Size(92, 29);
		E5861609.TabIndex = 6;
		E5861609.Text = "Thêm";
		E5861609.UseVisualStyleBackColor = false;
		E5861609.Click += E5861609_Click;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(352, 37);
		bunifuCards1.TabIndex = 28;
		txtToCookie.Location = new Point(147, 375);
		txtToCookie.Name = "txtToCookie";
		txtToCookie.Size = new Size(178, 23);
		txtToCookie.TabIndex = 0;
		BE99C6AD.AutoSize = true;
		BE99C6AD.Location = new Point(27, 377);
		BE99C6AD.Name = "lblToCookie";
		BE99C6AD.Size = new Size(114, 16);
		BE99C6AD.TabIndex = 31;
		BE99C6AD.Text = "Cookie nhận page:";
		C631D0A7.AutoSize = true;
		C631D0A7.Cursor = Cursors.Hand;
		C631D0A7.Location = new Point(132, 133);
		C631D0A7.Name = "ckbAutoDeleteContent";
		C631D0A7.Size = new Size(169, 20);
		C631D0A7.TabIndex = 177;
		C631D0A7.Text = "Xóa nội dung đã sư\u0309 du\u0323ng";
		C631D0A7.UseVisualStyleBackColor = true;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(355, 438);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDTaoPage";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += C69E6685_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)DC9612A2).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		((ISupportInitialize)C4B9DD3B).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		((ISupportInitialize)nudSoLuongTo).EndInit();
		((ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
