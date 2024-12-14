using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDXoaNhatKyHoatDong : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string F5BA6838;

	private string string_1;

	private int C8082A0F;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel C79BD3B5;

	private NumericUpDown nudSoLuong;

	private TextBox txtTenHanhDong;

	private Label label4;

	private Label F5A74BA1;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards B5365B92;

	private Panel BA99BE16;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel BC12870D;

	private NumericUpDown nudDelayTo;

	private NumericUpDown A7A78F18;

	private Label C5ACA09B;

	private Label E18A9C30;

	private Label label5;

	private CheckBox ckbXoaThangNay;

	public fHDXoaNhatKyHoatDong(string string_2, int AD26B11A = 0, string string_3 = "")
	{
		A0B91DBE();
		bool_0 = false;
		string_0 = string_2;
		string_1 = string_3;
		C8082A0F = AD26B11A;
		string text = "";
		if (Class147.smethod_7("", "HDXoaNhatKyHoatDong").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDXoaNhatKyHoatDong', 'Xóa nhật ký hoạt động');");
		}
		switch (AD26B11A)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDXoaNhatKyHoatDong");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			F5BA6838 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(BC12870D);
		F7AB102E.smethod_1(label1);
		F7AB102E.smethod_1(F5A74BA1);
		F7AB102E.smethod_1(label4);
		F7AB102E.smethod_1(label5);
		F7AB102E.smethod_1(C5ACA09B);
		F7AB102E.smethod_1(E18A9C30);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(btnCancel);
	}

	private void fHDXoaNhatKyHoatDong_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuong.Value = gclass11_0.method_2("nudSoLuong");
			A7A78F18.Value = gclass11_0.method_2("nudDelayFrom");
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo");
			ckbXoaThangNay.Checked = gclass11_0.method_3("ckbXoaThangNay");
		}
		catch
		{
		}
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
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuong", nudSoLuong.Value);
		gClass.method_4("nudDelayFrom", A7A78F18.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		gClass.method_4("ckbXoaThangNay", ckbXoaThangNay.Checked);
		string string_ = gClass.method_7();
		if (C8082A0F == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, F5BA6838, string_))
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

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void BA13B311(object sender, PaintEventArgs e)
	{
		if (C79BD3B5.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, C79BD3B5.ClientSize.Width - num, C79BD3B5.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void A0B91DBE()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDXoaNhatKyHoatDong));
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		BC12870D = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(icontainer_0);
		BA99BE16 = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		C79BD3B5 = new Panel();
		ckbXoaThangNay = new CheckBox();
		nudDelayTo = new NumericUpDown();
		A7A78F18 = new NumericUpDown();
		C5ACA09B = new Label();
		E18A9C30 = new Label();
		label5 = new Label();
		nudSoLuong = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		label4 = new Label();
		F5A74BA1 = new Label();
		label1 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		B5365B92 = new BunifuCards();
		BA99BE16.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		C79BD3B5.SuspendLayout();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)A7A78F18).BeginInit();
		((ISupportInitialize)nudSoLuong).BeginInit();
		B5365B92.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = BC12870D;
		bunifuDragControl_0.Vertical = true;
		BC12870D.BackColor = Color.Transparent;
		BC12870D.Cursor = Cursors.SizeAll;
		BC12870D.Dock = DockStyle.Fill;
		BC12870D.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		BC12870D.ForeColor = Color.Black;
		BC12870D.Location = new Point(0, 0);
		BC12870D.Name = "bunifuCustomLabel1";
		BC12870D.Size = new Size(359, 31);
		BC12870D.TabIndex = 12;
		BC12870D.Text = "Cấu hình Xóa nhật ký hoạt động";
		BC12870D.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = BA99BE16;
		bunifuDragControl_1.Vertical = true;
		BA99BE16.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		BA99BE16.BackColor = Color.White;
		BA99BE16.Controls.Add(button1);
		BA99BE16.Controls.Add(pictureBox1);
		BA99BE16.Controls.Add(BC12870D);
		BA99BE16.Cursor = Cursors.SizeAll;
		BA99BE16.Location = new Point(0, 3);
		BA99BE16.Name = "pnlHeader";
		BA99BE16.Size = new Size(359, 31);
		BA99BE16.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(328, 1);
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
		C79BD3B5.BackColor = Color.White;
		C79BD3B5.BorderStyle = BorderStyle.FixedSingle;
		C79BD3B5.Controls.Add(ckbXoaThangNay);
		C79BD3B5.Controls.Add(nudDelayTo);
		C79BD3B5.Controls.Add(A7A78F18);
		C79BD3B5.Controls.Add(C5ACA09B);
		C79BD3B5.Controls.Add(E18A9C30);
		C79BD3B5.Controls.Add(label5);
		C79BD3B5.Controls.Add(nudSoLuong);
		C79BD3B5.Controls.Add(txtTenHanhDong);
		C79BD3B5.Controls.Add(label4);
		C79BD3B5.Controls.Add(F5A74BA1);
		C79BD3B5.Controls.Add(label1);
		C79BD3B5.Controls.Add(btnCancel);
		C79BD3B5.Controls.Add(btnAdd);
		C79BD3B5.Controls.Add(B5365B92);
		C79BD3B5.Cursor = Cursors.Arrow;
		C79BD3B5.Dock = DockStyle.Fill;
		C79BD3B5.Location = new Point(0, 0);
		C79BD3B5.Name = "panel1";
		C79BD3B5.Size = new Size(362, 274);
		C79BD3B5.TabIndex = 0;
		C79BD3B5.Paint += BA13B311;
		ckbXoaThangNay.AutoSize = true;
		ckbXoaThangNay.Location = new Point(30, 148);
		ckbXoaThangNay.Name = "ckbXoaThangNay";
		ckbXoaThangNay.Size = new Size(130, 20);
		ckbXoaThangNay.TabIndex = 47;
		ckbXoaThangNay.Text = "Xóa tháng hiện tại";
		ckbXoaThangNay.UseVisualStyleBackColor = true;
		nudDelayTo.Location = new Point(229, 112);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		A7A78F18.Location = new Point(132, 112);
		A7A78F18.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A7A78F18.Name = "nudDelayFrom";
		A7A78F18.Size = new Size(56, 23);
		A7A78F18.TabIndex = 3;
		C5ACA09B.Location = new Point(194, 114);
		C5ACA09B.Name = "label7";
		C5ACA09B.Size = new Size(29, 16);
		C5ACA09B.TabIndex = 46;
		C5ACA09B.Text = "đê\u0301n";
		C5ACA09B.TextAlign = ContentAlignment.MiddleCenter;
		E18A9C30.AutoSize = true;
		E18A9C30.Location = new Point(287, 114);
		E18A9C30.Name = "label6";
		E18A9C30.Size = new Size(30, 16);
		E18A9C30.TabIndex = 45;
		E18A9C30.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new Point(27, 114);
		label5.Name = "label5";
		label5.Size = new Size(89, 16);
		label5.TabIndex = 44;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		nudSoLuong.Location = new Point(132, 81);
		nudSoLuong.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuong.Name = "nudSoLuong";
		nudSoLuong.Size = new Size(56, 23);
		nudSoLuong.TabIndex = 1;
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label4.AutoSize = true;
		label4.Location = new Point(194, 83);
		label4.Name = "label4";
		label4.Size = new Size(39, 16);
		label4.TabIndex = 35;
		label4.Text = "tháng";
		F5A74BA1.AutoSize = true;
		F5A74BA1.Location = new Point(27, 83);
		F5A74BA1.Name = "label2";
		F5A74BA1.Size = new Size(63, 16);
		F5A74BA1.TabIndex = 32;
		F5A74BA1.Text = "Sô\u0301 lươ\u0323ng:";
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(187, 230);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(80, 230);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		B5365B92.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		B5365B92.BackColor = Color.White;
		B5365B92.BorderRadius = 0;
		B5365B92.BottomSahddow = true;
		B5365B92.color = Color.DarkViolet;
		B5365B92.Controls.Add(BA99BE16);
		B5365B92.LeftSahddow = false;
		B5365B92.Location = new Point(1, 0);
		B5365B92.Name = "bunifuCards1";
		B5365B92.RightSahddow = true;
		B5365B92.ShadowDepth = 20;
		B5365B92.Size = new Size(359, 37);
		B5365B92.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(362, 274);
		base.Controls.Add(C79BD3B5);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDXoaNhatKyHoatDong";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDXoaNhatKyHoatDong_Load;
		BA99BE16.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		C79BD3B5.ResumeLayout(performLayout: false);
		C79BD3B5.PerformLayout();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)A7A78F18).EndInit();
		((ISupportInitialize)nudSoLuong).EndInit();
		B5365B92.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
