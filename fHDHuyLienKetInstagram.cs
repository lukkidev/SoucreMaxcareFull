using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDHuyLienKetInstagram : Form
{
	private GClass11 gclass11_0 = null;

	private string string_0;

	private string C003E685;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl AC9564B2;

	private BunifuDragControl B5842EB3;

	private Panel DCB8B28F;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button E30AD78E;

	private Button btnAdd;

	private BunifuCards FEA92080;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel C326FC30;

	public fHDHuyLienKetInstagram(string C135F694, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = C135F694;
		string_1 = string_2;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Hủy liên kết Instagram";
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
			C003E685 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
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
		gclass11_0 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(C326FC30);
		F7AB102E.smethod_1(label1);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(E30AD78E);
	}

	private void FE2620B3(object sender, EventArgs e)
	{
	}

	private void B13EEABB(object sender, EventArgs e)
	{
		Close();
	}

	private void CF1B710D(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		string string_ = gclass11_0.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, C003E685, string_))
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

	private void E30AD78E_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E00EB794(object sender, PaintEventArgs e)
	{
		if (DCB8B28F.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, DCB8B28F.ClientSize.Width - num, DCB8B28F.ClientSize.Height - num));
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDHuyLienKetInstagram));
		AC9564B2 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		C326FC30 = new Bunifu.Framework.UI.BunifuCustomLabel();
		B5842EB3 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		DCB8B28F = new System.Windows.Forms.Panel();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		E30AD78E = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		FEA92080 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		DCB8B28F.SuspendLayout();
		FEA92080.SuspendLayout();
		SuspendLayout();
		AC9564B2.Fixed = true;
		AC9564B2.Horizontal = true;
		AC9564B2.TargetControl = C326FC30;
		AC9564B2.Vertical = true;
		C326FC30.BackColor = System.Drawing.Color.Transparent;
		C326FC30.Cursor = System.Windows.Forms.Cursors.SizeAll;
		C326FC30.Dock = System.Windows.Forms.DockStyle.Fill;
		C326FC30.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C326FC30.ForeColor = System.Drawing.Color.Black;
		C326FC30.Location = new System.Drawing.Point(0, 0);
		C326FC30.Name = "bunifuCustomLabel1";
		C326FC30.Size = new System.Drawing.Size(359, 31);
		C326FC30.TabIndex = 12;
		C326FC30.Text = "Cấu hình Hủy liên kết Instagram";
		C326FC30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B5842EB3.Fixed = true;
		B5842EB3.Horizontal = true;
		B5842EB3.TargetControl = pnlHeader;
		B5842EB3.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(C326FC30);
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
		button1.Click += new System.EventHandler(B13EEABB);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		DCB8B28F.BackColor = System.Drawing.Color.White;
		DCB8B28F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		DCB8B28F.Controls.Add(txtTenHanhDong);
		DCB8B28F.Controls.Add(label1);
		DCB8B28F.Controls.Add(E30AD78E);
		DCB8B28F.Controls.Add(btnAdd);
		DCB8B28F.Controls.Add(FEA92080);
		DCB8B28F.Cursor = System.Windows.Forms.Cursors.Arrow;
		DCB8B28F.Dock = System.Windows.Forms.DockStyle.Fill;
		DCB8B28F.Location = new System.Drawing.Point(0, 0);
		DCB8B28F.Name = "panel1";
		DCB8B28F.Size = new System.Drawing.Size(362, 132);
		DCB8B28F.TabIndex = 0;
		DCB8B28F.Paint += new System.Windows.Forms.PaintEventHandler(E00EB794);
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
		E30AD78E.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		E30AD78E.BackColor = System.Drawing.Color.Maroon;
		E30AD78E.Cursor = System.Windows.Forms.Cursors.Hand;
		E30AD78E.FlatAppearance.BorderSize = 0;
		E30AD78E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E30AD78E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E30AD78E.ForeColor = System.Drawing.Color.White;
		E30AD78E.Location = new System.Drawing.Point(189, 88);
		E30AD78E.Name = "btnCancel";
		E30AD78E.Size = new System.Drawing.Size(92, 29);
		E30AD78E.TabIndex = 10;
		E30AD78E.Text = "Đóng";
		E30AD78E.UseVisualStyleBackColor = false;
		E30AD78E.Click += new System.EventHandler(E30AD78E_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(82, 88);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(CF1B710D);
		FEA92080.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		FEA92080.BackColor = System.Drawing.Color.White;
		FEA92080.BorderRadius = 0;
		FEA92080.BottomSahddow = true;
		FEA92080.color = System.Drawing.Color.DarkViolet;
		FEA92080.Controls.Add(pnlHeader);
		FEA92080.LeftSahddow = false;
		FEA92080.Location = new System.Drawing.Point(1, 0);
		FEA92080.Name = "bunifuCards1";
		FEA92080.RightSahddow = true;
		FEA92080.ShadowDepth = 20;
		FEA92080.Size = new System.Drawing.Size(359, 37);
		FEA92080.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 132);
		base.Controls.Add(DCB8B28F);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDHuyLienKetInstagram";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(FE2620B3);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		DCB8B28F.ResumeLayout(false);
		DCB8B28F.PerformLayout();
		FEA92080.ResumeLayout(false);
		ResumeLayout(false);
	}
}
