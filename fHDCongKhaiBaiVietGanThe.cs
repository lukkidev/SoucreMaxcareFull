using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDCongKhaiBaiVietGanThe : Form
{
	private GClass11 gclass11_0 = null;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private IContainer AB0A8A84 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl B08F462E;

	private Panel FD02CC90;

	private TextBox txtTenHanhDong;

	private Label CF34AE0D;

	private Button B9B55C8F;

	private Button btnAdd;

	private BunifuCards B894149C;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	public fHDCongKhaiBaiVietGanThe(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		if (Class147.smethod_7("", "HDCongKhaiBaiVietGanThe").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDCongKhaiBaiVietGanThe', 'Công khai bài viết gắn thẻ');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDCongKhaiBaiVietGanThe");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_4);
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
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(CF34AE0D);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(B9B55C8F);
	}

	private void fHDCongKhaiBaiVietGanThe_Load(object sender, EventArgs e)
	{
		try
		{
		}
		catch
		{
		}
	}

	private void D117213B(object sender, EventArgs e)
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
		string text2 = gClass.method_7();
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

	private void B9B55C8F_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FD02CC90_Paint(object sender, PaintEventArgs e)
	{
		if (FD02CC90.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, FD02CC90.ClientSize.Width - num, FD02CC90.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && AB0A8A84 != null)
		{
			AB0A8A84.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		AB0A8A84 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDCongKhaiBaiVietGanThe));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(AB0A8A84);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		B08F462E = new Bunifu.Framework.UI.BunifuDragControl(AB0A8A84);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		FD02CC90 = new System.Windows.Forms.Panel();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		CF34AE0D = new System.Windows.Forms.Label();
		B9B55C8F = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		B894149C = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		FD02CC90.SuspendLayout();
		B894149C.SuspendLayout();
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
		bunifuCustomLabel1.Text = "Cấu hình Công khai bài viết gắn thẻ";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B08F462E.Fixed = true;
		B08F462E.Horizontal = true;
		B08F462E.TargetControl = pnlHeader;
		B08F462E.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(359, 31);
		pnlHeader.TabIndex = 9;
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
		button1.Click += new System.EventHandler(D117213B);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		FD02CC90.BackColor = System.Drawing.Color.White;
		FD02CC90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		FD02CC90.Controls.Add(txtTenHanhDong);
		FD02CC90.Controls.Add(CF34AE0D);
		FD02CC90.Controls.Add(B9B55C8F);
		FD02CC90.Controls.Add(btnAdd);
		FD02CC90.Controls.Add(B894149C);
		FD02CC90.Cursor = System.Windows.Forms.Cursors.Arrow;
		FD02CC90.Dock = System.Windows.Forms.DockStyle.Fill;
		FD02CC90.Location = new System.Drawing.Point(0, 0);
		FD02CC90.Name = "panel1";
		FD02CC90.Size = new System.Drawing.Size(362, 160);
		FD02CC90.TabIndex = 0;
		FD02CC90.Paint += new System.Windows.Forms.PaintEventHandler(FD02CC90_Paint);
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		CF34AE0D.AutoSize = true;
		CF34AE0D.Location = new System.Drawing.Point(27, 52);
		CF34AE0D.Name = "label1";
		CF34AE0D.Size = new System.Drawing.Size(98, 16);
		CF34AE0D.TabIndex = 31;
		CF34AE0D.Text = "Tên ha\u0300nh đô\u0323ng:";
		B9B55C8F.BackColor = System.Drawing.Color.Maroon;
		B9B55C8F.Cursor = System.Windows.Forms.Cursors.Hand;
		B9B55C8F.FlatAppearance.BorderSize = 0;
		B9B55C8F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B9B55C8F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B9B55C8F.ForeColor = System.Drawing.Color.White;
		B9B55C8F.Location = new System.Drawing.Point(189, 116);
		B9B55C8F.Name = "btnCancel";
		B9B55C8F.Size = new System.Drawing.Size(92, 29);
		B9B55C8F.TabIndex = 10;
		B9B55C8F.Text = "Đóng";
		B9B55C8F.UseVisualStyleBackColor = false;
		B9B55C8F.Click += new System.EventHandler(B9B55C8F_Click);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(82, 116);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		B894149C.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		B894149C.BackColor = System.Drawing.Color.White;
		B894149C.BorderRadius = 0;
		B894149C.BottomSahddow = true;
		B894149C.color = System.Drawing.Color.DarkViolet;
		B894149C.Controls.Add(pnlHeader);
		B894149C.LeftSahddow = false;
		B894149C.Location = new System.Drawing.Point(1, 0);
		B894149C.Name = "bunifuCards1";
		B894149C.RightSahddow = true;
		B894149C.ShadowDepth = 20;
		B894149C.Size = new System.Drawing.Size(359, 37);
		B894149C.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 160);
		base.Controls.Add(FD02CC90);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDCongKhaiBaiVietGanThe";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDCongKhaiBaiVietGanThe_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		FD02CC90.ResumeLayout(false);
		FD02CC90.PerformLayout();
		B894149C.ResumeLayout(false);
		ResumeLayout(false);
	}
}
