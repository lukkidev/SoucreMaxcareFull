using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDXoaThietBiTinCay : Form
{
	private GClass11 FF922D2F = null;

	private string string_0;

	private string string_1;

	private string B93EF18E;

	private int int_0;

	public static bool A0AC0C13;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel BB2E773D;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards E2A2CA3D;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox F21BAB8D;

	private BunifuCustomLabel DFBB2F3A;

	public fHDXoaThietBiTinCay(string E92DF235, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		A0AC0C13 = false;
		string_0 = E92DF235;
		B93EF18E = string_2;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Xóa thiết bị tin cậy";
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
			DataTable dataTable = Class147.F3057616(string_2);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		FF922D2F = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(DFBB2F3A);
		F7AB102E.smethod_1(label1);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(btnCancel);
	}

	private void fHDXoaThietBiTinCay_Load(object sender, EventArgs e)
	{
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
		string string_ = FF922D2F.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, string_))
				{
					A0AC0C13 = true;
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
			if (Class147.smethod_13(B93EF18E, text, string_))
			{
				A0AC0C13 = true;
				Close();
			}
			else
			{
				GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void AD3A60A5(object sender, EventArgs e)
	{
		Close();
	}

	private void FF92A429(object sender, PaintEventArgs e)
	{
		if (BB2E773D.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, BB2E773D.ClientSize.Width - num, BB2E773D.ClientSize.Height - num));
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDXoaThietBiTinCay));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		DFBB2F3A = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		F21BAB8D = new System.Windows.Forms.PictureBox();
		BB2E773D = new System.Windows.Forms.Panel();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		E2A2CA3D = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)F21BAB8D).BeginInit();
		BB2E773D.SuspendLayout();
		E2A2CA3D.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = DFBB2F3A;
		bunifuDragControl_0.Vertical = true;
		DFBB2F3A.BackColor = System.Drawing.Color.Transparent;
		DFBB2F3A.Cursor = System.Windows.Forms.Cursors.SizeAll;
		DFBB2F3A.Dock = System.Windows.Forms.DockStyle.Fill;
		DFBB2F3A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DFBB2F3A.ForeColor = System.Drawing.Color.Black;
		DFBB2F3A.Location = new System.Drawing.Point(0, 0);
		DFBB2F3A.Name = "bunifuCustomLabel1";
		DFBB2F3A.Size = new System.Drawing.Size(359, 31);
		DFBB2F3A.TabIndex = 12;
		DFBB2F3A.Text = "Cấu hình Xóa thiết bị tin cậy";
		DFBB2F3A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(F21BAB8D);
		pnlHeader.Controls.Add(DFBB2F3A);
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
		button1.Click += new System.EventHandler(button1_Click);
		F21BAB8D.Cursor = System.Windows.Forms.Cursors.Default;
		F21BAB8D.Image = C50FB39E.Bitmap_5;
		F21BAB8D.Location = new System.Drawing.Point(3, 2);
		F21BAB8D.Name = "pictureBox1";
		F21BAB8D.Size = new System.Drawing.Size(34, 27);
		F21BAB8D.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		F21BAB8D.TabIndex = 76;
		F21BAB8D.TabStop = false;
		BB2E773D.BackColor = System.Drawing.Color.White;
		BB2E773D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		BB2E773D.Controls.Add(txtTenHanhDong);
		BB2E773D.Controls.Add(label1);
		BB2E773D.Controls.Add(btnCancel);
		BB2E773D.Controls.Add(btnAdd);
		BB2E773D.Controls.Add(E2A2CA3D);
		BB2E773D.Cursor = System.Windows.Forms.Cursors.Arrow;
		BB2E773D.Dock = System.Windows.Forms.DockStyle.Fill;
		BB2E773D.Location = new System.Drawing.Point(0, 0);
		BB2E773D.Name = "panel1";
		BB2E773D.Size = new System.Drawing.Size(362, 135);
		BB2E773D.TabIndex = 0;
		BB2E773D.Paint += new System.Windows.Forms.PaintEventHandler(FF92A429);
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
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
		btnCancel.Location = new System.Drawing.Point(189, 91);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(AD3A60A5);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(82, 91);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		E2A2CA3D.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		E2A2CA3D.BackColor = System.Drawing.Color.White;
		E2A2CA3D.BorderRadius = 0;
		E2A2CA3D.BottomSahddow = true;
		E2A2CA3D.color = System.Drawing.Color.DarkViolet;
		E2A2CA3D.Controls.Add(pnlHeader);
		E2A2CA3D.LeftSahddow = false;
		E2A2CA3D.Location = new System.Drawing.Point(1, 0);
		E2A2CA3D.Name = "bunifuCards1";
		E2A2CA3D.RightSahddow = true;
		E2A2CA3D.ShadowDepth = 20;
		E2A2CA3D.Size = new System.Drawing.Size(359, 37);
		E2A2CA3D.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 135);
		base.Controls.Add(BB2E773D);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDXoaThietBiTinCay";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDXoaThietBiTinCay_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)F21BAB8D).EndInit();
		BB2E773D.ResumeLayout(false);
		BB2E773D.PerformLayout();
		E2A2CA3D.ResumeLayout(false);
		ResumeLayout(false);
	}
}
