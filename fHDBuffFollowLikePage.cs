using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDBuffFollowLikePage : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int F4819024;

	public static bool bool_0;

	private IContainer F125B03D = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl F2899592;

	private Panel panel1;

	private NumericUpDown F58E9A92;

	private NumericUpDown nudDelayFrom;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label label5;

	private Label BAB924BD;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards B299B809;

	private Panel FCAE8C93;

	private Button BC30AB38;

	private PictureBox pictureBox1;

	private BunifuCustomLabel C32CF8B4;

	private Label label2;

	private RichTextBox txtUid;

	public fHDBuffFollowLikePage(string B489A52C, int int_0 = 0, string string_3 = "")
	{
		FE018B97();
		bool_0 = false;
		string_0 = B489A52C;
		string_2 = string_3;
		F4819024 = int_0;
		string text = base.Name.Substring(1);
		string text2 = "Like page";
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
			DataTable dataTable = Class147.F3057616(string_3);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void fHDBuffFollowLikePage_Load(object sender, EventArgs e)
	{
		try
		{
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom", 3);
			F58E9A92.Value = gclass11_0.method_2("nudDelayTo", 5);
			txtUid.Text = gclass11_0.C0288288("txtUid");
		}
		catch
		{
		}
	}

	private void C730650C(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", F58E9A92.Value);
		gClass.method_4("txtUid", txtUid.Text.Trim());
		string text2 = gClass.method_7();
		if (F4819024 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, text2))
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
			if (Class147.smethod_13(string_2, text, text2))
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

	private void E5B5643A(object sender, EventArgs e)
	{
		Close();
	}

	private void D70310BF(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void F68BA43B(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtUid, label2);
	}

	protected override void Dispose(bool B82B461B)
	{
		if (B82B461B && F125B03D != null)
		{
			F125B03D.Dispose();
		}
		base.Dispose(B82B461B);
	}

	private void FE018B97()
	{
		F125B03D = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDBuffFollowLikePage));
		bunifuDragControl_0 = new BunifuDragControl(F125B03D);
		C32CF8B4 = new BunifuCustomLabel();
		F2899592 = new BunifuDragControl(F125B03D);
		FCAE8C93 = new Panel();
		BC30AB38 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		txtUid = new RichTextBox();
		label2 = new Label();
		F58E9A92 = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		label7 = new Label();
		label5 = new Label();
		BAB924BD = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		B299B809 = new BunifuCards();
		FCAE8C93.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((ISupportInitialize)F58E9A92).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		B299B809.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = C32CF8B4;
		bunifuDragControl_0.Vertical = true;
		C32CF8B4.BackColor = Color.Transparent;
		C32CF8B4.Cursor = Cursors.SizeAll;
		C32CF8B4.Dock = DockStyle.Fill;
		C32CF8B4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C32CF8B4.ForeColor = Color.Black;
		C32CF8B4.Location = new Point(0, 0);
		C32CF8B4.Name = "bunifuCustomLabel1";
		C32CF8B4.Size = new Size(315, 31);
		C32CF8B4.TabIndex = 12;
		C32CF8B4.Text = "Cấu hình Like page";
		C32CF8B4.TextAlign = ContentAlignment.MiddleCenter;
		F2899592.Fixed = true;
		F2899592.Horizontal = true;
		F2899592.TargetControl = FCAE8C93;
		F2899592.Vertical = true;
		FCAE8C93.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		FCAE8C93.BackColor = Color.White;
		FCAE8C93.Controls.Add(BC30AB38);
		FCAE8C93.Controls.Add(pictureBox1);
		FCAE8C93.Controls.Add(C32CF8B4);
		FCAE8C93.Cursor = Cursors.SizeAll;
		FCAE8C93.Location = new Point(0, 3);
		FCAE8C93.Name = "pnlHeader";
		FCAE8C93.Size = new Size(315, 31);
		FCAE8C93.TabIndex = 9;
		BC30AB38.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		BC30AB38.Cursor = Cursors.Hand;
		BC30AB38.FlatAppearance.BorderSize = 0;
		BC30AB38.FlatStyle = FlatStyle.Flat;
		BC30AB38.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BC30AB38.ForeColor = Color.White;
		BC30AB38.Image = (Image)componentResourceManager.GetObject("button1.Image");
		BC30AB38.Location = new Point(284, 1);
		BC30AB38.Name = "button1";
		BC30AB38.Size = new Size(30, 30);
		BC30AB38.TabIndex = 77;
		BC30AB38.TextImageRelation = TextImageRelation.ImageBeforeText;
		BC30AB38.UseVisualStyleBackColor = true;
		BC30AB38.Click += C730650C;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(txtUid);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(F58E9A92);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(BAB924BD);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(B299B809);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(318, 327);
		panel1.TabIndex = 0;
		panel1.Paint += D70310BF;
		txtUid.Location = new Point(31, 124);
		txtUid.Name = "txtUid";
		txtUid.Size = new Size(253, 146);
		txtUid.TabIndex = 50;
		txtUid.Text = "";
		txtUid.TextChanged += F68BA43B;
		label2.AutoSize = true;
		label2.Location = new Point(27, 104);
		label2.Name = "label2";
		label2.Size = new Size(140, 16);
		label2.TabIndex = 40;
		label2.Text = "Nhập danh sách ID (0):";
		F58E9A92.Location = new Point(228, 78);
		F58E9A92.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F58E9A92.Name = "nudDelayTo";
		F58E9A92.Size = new Size(56, 23);
		F58E9A92.TabIndex = 4;
		nudDelayFrom.Location = new Point(131, 78);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		txtTenHanhDong.Location = new Point(131, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(153, 23);
		txtTenHanhDong.TabIndex = 0;
		label7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label7.Location = new Point(193, 80);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = ">";
		label7.TextAlign = ContentAlignment.MiddleCenter;
		label5.AutoSize = true;
		label5.Location = new Point(27, 80);
		label5.Name = "label5";
		label5.Size = new Size(87, 16);
		label5.TabIndex = 34;
		label5.Text = "Gia\u0303n ca\u0301ch (s):";
		BAB924BD.AutoSize = true;
		BAB924BD.Location = new Point(27, 52);
		BAB924BD.Name = "label1";
		BAB924BD.Size = new Size(98, 16);
		BAB924BD.TabIndex = 31;
		BAB924BD.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(167, 285);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += E5B5643A;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(60, 285);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		B299B809.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		B299B809.BackColor = Color.White;
		B299B809.BorderRadius = 0;
		B299B809.BottomSahddow = true;
		B299B809.color = Color.DarkViolet;
		B299B809.Controls.Add(FCAE8C93);
		B299B809.LeftSahddow = false;
		B299B809.Location = new Point(1, 0);
		B299B809.Name = "bunifuCards1";
		B299B809.RightSahddow = true;
		B299B809.ShadowDepth = 20;
		B299B809.Size = new Size(315, 37);
		B299B809.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(318, 327);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDBuffFollowLikePage";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDBuffFollowLikePage_Load;
		FCAE8C93.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		((ISupportInitialize)F58E9A92).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		B299B809.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
