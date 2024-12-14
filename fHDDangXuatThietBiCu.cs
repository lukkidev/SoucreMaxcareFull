using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDDangXuatThietBiCu : Form
{
	private GClass11 gclass11_0 = null;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl EF9A6E00;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label DD90C214;

	private Button B92411B6;

	private Button D925708E;

	private BunifuCards F51528B0;

	private Panel F20E578C;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	public fHDDangXuatThietBiCu(string D0354433, int int_1 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = D0354433;
		string_2 = string_3;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Đăng xuất thiết bị cũ";
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
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_3);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			D925708E.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void D793B80E()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(DD90C214);
		F7AB102E.smethod_1(D925708E);
		F7AB102E.smethod_1(B92411B6);
	}

	private void EB132021(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void D925708E_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		string text2 = gclass11_0.method_7();
		if (int_0 == 0)
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

	private void E784D78B(object sender, EventArgs e)
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDDangXuatThietBiCu));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		EF9A6E00 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		F20E578C = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		DD90C214 = new System.Windows.Forms.Label();
		B92411B6 = new System.Windows.Forms.Button();
		D925708E = new System.Windows.Forms.Button();
		F51528B0 = new Bunifu.Framework.UI.BunifuCards();
		F20E578C.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		F51528B0.SuspendLayout();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Đăng xuất thiết bị cũ";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		EF9A6E00.Fixed = true;
		EF9A6E00.Horizontal = true;
		EF9A6E00.TargetControl = F20E578C;
		EF9A6E00.Vertical = true;
		F20E578C.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		F20E578C.BackColor = System.Drawing.Color.White;
		F20E578C.Controls.Add(button1);
		F20E578C.Controls.Add(pictureBox1);
		F20E578C.Controls.Add(bunifuCustomLabel1);
		F20E578C.Cursor = System.Windows.Forms.Cursors.SizeAll;
		F20E578C.Location = new System.Drawing.Point(0, 3);
		F20E578C.Name = "pnlHeader";
		F20E578C.Size = new System.Drawing.Size(359, 31);
		F20E578C.TabIndex = 9;
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
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(DD90C214);
		panel1.Controls.Add(B92411B6);
		panel1.Controls.Add(D925708E);
		panel1.Controls.Add(F51528B0);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 132);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		DD90C214.AutoSize = true;
		DD90C214.Location = new System.Drawing.Point(27, 52);
		DD90C214.Name = "label1";
		DD90C214.Size = new System.Drawing.Size(98, 16);
		DD90C214.TabIndex = 31;
		DD90C214.Text = "Tên ha\u0300nh đô\u0323ng:";
		B92411B6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		B92411B6.BackColor = System.Drawing.Color.Maroon;
		B92411B6.Cursor = System.Windows.Forms.Cursors.Hand;
		B92411B6.FlatAppearance.BorderSize = 0;
		B92411B6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B92411B6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B92411B6.ForeColor = System.Drawing.Color.White;
		B92411B6.Location = new System.Drawing.Point(189, 88);
		B92411B6.Name = "btnCancel";
		B92411B6.Size = new System.Drawing.Size(92, 29);
		B92411B6.TabIndex = 10;
		B92411B6.Text = "Đóng";
		B92411B6.UseVisualStyleBackColor = false;
		B92411B6.Click += new System.EventHandler(E784D78B);
		D925708E.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		D925708E.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		D925708E.Cursor = System.Windows.Forms.Cursors.Hand;
		D925708E.FlatAppearance.BorderSize = 0;
		D925708E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D925708E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D925708E.ForeColor = System.Drawing.Color.White;
		D925708E.Location = new System.Drawing.Point(82, 88);
		D925708E.Name = "btnAdd";
		D925708E.Size = new System.Drawing.Size(92, 29);
		D925708E.TabIndex = 9;
		D925708E.Text = "Thêm";
		D925708E.UseVisualStyleBackColor = false;
		D925708E.Click += new System.EventHandler(D925708E_Click);
		F51528B0.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		F51528B0.BackColor = System.Drawing.Color.White;
		F51528B0.BorderRadius = 0;
		F51528B0.BottomSahddow = true;
		F51528B0.color = System.Drawing.Color.DarkViolet;
		F51528B0.Controls.Add(F20E578C);
		F51528B0.LeftSahddow = false;
		F51528B0.Location = new System.Drawing.Point(1, 0);
		F51528B0.Name = "bunifuCards1";
		F51528B0.RightSahddow = true;
		F51528B0.ShadowDepth = 20;
		F51528B0.Size = new System.Drawing.Size(359, 37);
		F51528B0.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 132);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDangXuatThietBiCu";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(EB132021);
		F20E578C.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		F51528B0.ResumeLayout(false);
		ResumeLayout(false);
	}
}
