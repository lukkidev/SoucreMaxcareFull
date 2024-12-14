using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class BA26EC99 : Form
{
	private GClass11 gclass11_0 = null;

	private string F4937F3C;

	private string string_0;

	private string string_1;

	private int A6934431;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label CC25A615;

	private Button B127450C;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button D031149D;

	private PictureBox E59D5918;

	private BunifuCustomLabel B9B5C316;

	public BA26EC99(string FB9D5290, int DCBFC912 = 0, string D524A631 = "")
	{
		InitializeComponent();
		bool_0 = false;
		F4937F3C = FB9D5290;
		string_1 = D524A631;
		A6934431 = DCBFC912;
		string text = base.Name.Substring(1);
		string text2 = "Unlock profile";
		if (Class147.smethod_7("", text).Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (DCBFC912)
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
			DataTable dataTable = Class147.F3057616(D524A631);
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
		F7AB102E.smethod_1(B9B5C316);
		F7AB102E.smethod_1(CC25A615);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(B127450C);
	}

	private void BA26EC99_Load(object sender, EventArgs e)
	{
	}

	private void D031149D_Click(object sender, EventArgs e)
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
		string string_ = gclass11_0.method_7();
		if (A6934431 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(F4937F3C, text, string_0, string_))
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

	private void B127450C_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DA243101(object sender, PaintEventArgs e)
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BA26EC99));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		B9B5C316 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		D031149D = new System.Windows.Forms.Button();
		E59D5918 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		CC25A615 = new System.Windows.Forms.Label();
		B127450C = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)E59D5918).BeginInit();
		panel1.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = B9B5C316;
		bunifuDragControl_0.Vertical = true;
		B9B5C316.BackColor = System.Drawing.Color.Transparent;
		B9B5C316.Cursor = System.Windows.Forms.Cursors.SizeAll;
		B9B5C316.Dock = System.Windows.Forms.DockStyle.Fill;
		B9B5C316.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B9B5C316.ForeColor = System.Drawing.Color.Black;
		B9B5C316.Location = new System.Drawing.Point(0, 0);
		B9B5C316.Name = "bunifuCustomLabel1";
		B9B5C316.Size = new System.Drawing.Size(359, 31);
		B9B5C316.TabIndex = 12;
		B9B5C316.Text = "Cấu hình Unlock profile";
		B9B5C316.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(D031149D);
		pnlHeader.Controls.Add(E59D5918);
		pnlHeader.Controls.Add(B9B5C316);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(359, 31);
		pnlHeader.TabIndex = 9;
		D031149D.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		D031149D.Cursor = System.Windows.Forms.Cursors.Hand;
		D031149D.FlatAppearance.BorderSize = 0;
		D031149D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D031149D.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D031149D.ForeColor = System.Drawing.Color.White;
		D031149D.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		D031149D.Location = new System.Drawing.Point(328, 1);
		D031149D.Name = "button1";
		D031149D.Size = new System.Drawing.Size(30, 30);
		D031149D.TabIndex = 77;
		D031149D.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		D031149D.UseVisualStyleBackColor = true;
		D031149D.Click += new System.EventHandler(D031149D_Click);
		E59D5918.Cursor = System.Windows.Forms.Cursors.Default;
		E59D5918.Image = C50FB39E.Bitmap_5;
		E59D5918.Location = new System.Drawing.Point(3, 2);
		E59D5918.Name = "pictureBox1";
		E59D5918.Size = new System.Drawing.Size(34, 27);
		E59D5918.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		E59D5918.TabIndex = 76;
		E59D5918.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(CC25A615);
		panel1.Controls.Add(B127450C);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 132);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(DA243101);
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		CC25A615.AutoSize = true;
		CC25A615.Location = new System.Drawing.Point(27, 52);
		CC25A615.Name = "label1";
		CC25A615.Size = new System.Drawing.Size(98, 16);
		CC25A615.TabIndex = 31;
		CC25A615.Text = "Tên ha\u0300nh đô\u0323ng:";
		B127450C.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		B127450C.BackColor = System.Drawing.Color.Maroon;
		B127450C.Cursor = System.Windows.Forms.Cursors.Hand;
		B127450C.FlatAppearance.BorderSize = 0;
		B127450C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B127450C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B127450C.ForeColor = System.Drawing.Color.White;
		B127450C.Location = new System.Drawing.Point(189, 88);
		B127450C.Name = "btnCancel";
		B127450C.Size = new System.Drawing.Size(92, 29);
		B127450C.TabIndex = 10;
		B127450C.Text = "Đóng";
		B127450C.UseVisualStyleBackColor = false;
		B127450C.Click += new System.EventHandler(B127450C_Click);
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
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 132);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDUnlockProfile";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(BA26EC99_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)E59D5918).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
