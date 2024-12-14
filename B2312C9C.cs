using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class B2312C9C : Form
{
	private GClass11 gclass11_0 = null;

	private string CF0C263F;

	private string string_0;

	private string E804C62C;

	private int int_0;

	public static bool bool_0;

	private IContainer CD15FB9D = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl C49B4595;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label BA92A434;

	private Button EC83408E;

	private Button DC2565B7;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button CEBFDB1C;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox CC287A8D;

	private TextBox txtPath;

	private TextBox txtApi;

	private Label B9857A1F;

	public B2312C9C(string string_1, int D49D991B = 0, string D7B187A6 = "")
	{
		E6A6D219();
		bool_0 = false;
		CF0C263F = string_1;
		E804C62C = D7B187A6;
		int_0 = D49D991B;
		if (Class147.smethod_7("", "fHDVerify").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDVerify', 'Verify Phone');");
		}
		string string_2 = "";
		switch (D49D991B)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDVerify");
			string_2 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(D7B187A6);
			string_2 = dataTable.Rows[0]["CauHinh"].ToString();
			DC2565B7.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(string_2, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(BA92A434);
		F7AB102E.smethod_1(DC2565B7);
		F7AB102E.smethod_1(EC83408E);
	}

	private void DD02EA83(object sender, EventArgs e)
	{
		try
		{
			txtApi.Text = gclass11_0.C0288288("txtApi");
			CC287A8D.Checked = gclass11_0.method_3("ckbUpAvatar");
			txtPath.Text = gclass11_0.C0288288("txtPath");
		}
		catch
		{
		}
	}

	private void CEBFDB1C_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DE2BB989(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("txtApi", txtApi.Text);
		gClass.method_4("ckbUpAvatar", CC287A8D.Checked);
		gClass.method_4("txtPath", txtPath.Text);
		string text2 = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(CF0C263F, text, string_0, text2))
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
			if (Class147.smethod_13(E804C62C, text, text2))
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

	private void EC83408E_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FA8DBDB8(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void C63A1C32(object sender, EventArgs e)
	{
		txtPath.Enabled = CC287A8D.Checked;
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && CD15FB9D != null)
		{
			CD15FB9D.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void E6A6D219()
	{
		CD15FB9D = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(B2312C9C));
		bunifuDragControl_0 = new BunifuDragControl(CD15FB9D);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		C49B4595 = new BunifuDragControl(CD15FB9D);
		pnlHeader = new Panel();
		CEBFDB1C = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		txtTenHanhDong = new TextBox();
		BA92A434 = new Label();
		EC83408E = new Button();
		DC2565B7 = new Button();
		bunifuCards1 = new BunifuCards();
		B9857A1F = new Label();
		txtApi = new TextBox();
		CC287A8D = new CheckBox();
		txtPath = new TextBox();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(424, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Verify";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		C49B4595.Fixed = true;
		C49B4595.Horizontal = true;
		C49B4595.TargetControl = pnlHeader;
		C49B4595.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(CEBFDB1C);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(424, 31);
		pnlHeader.TabIndex = 9;
		CEBFDB1C.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		CEBFDB1C.Cursor = Cursors.Hand;
		CEBFDB1C.FlatAppearance.BorderSize = 0;
		CEBFDB1C.FlatStyle = FlatStyle.Flat;
		CEBFDB1C.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		CEBFDB1C.ForeColor = Color.White;
		CEBFDB1C.Image = (Image)componentResourceManager.GetObject("button1.Image");
		CEBFDB1C.Location = new Point(393, 1);
		CEBFDB1C.Name = "button1";
		CEBFDB1C.Size = new Size(30, 30);
		CEBFDB1C.TabIndex = 77;
		CEBFDB1C.TextImageRelation = TextImageRelation.ImageBeforeText;
		CEBFDB1C.UseVisualStyleBackColor = true;
		CEBFDB1C.Click += CEBFDB1C_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(CC287A8D);
		panel1.Controls.Add(txtPath);
		panel1.Controls.Add(txtApi);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(B9857A1F);
		panel1.Controls.Add(BA92A434);
		panel1.Controls.Add(EC83408E);
		panel1.Controls.Add(DC2565B7);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(427, 294);
		panel1.TabIndex = 0;
		panel1.Paint += FA8DBDB8;
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(274, 23);
		txtTenHanhDong.TabIndex = 0;
		BA92A434.AutoSize = true;
		BA92A434.Location = new Point(27, 52);
		BA92A434.Name = "label1";
		BA92A434.Size = new Size(98, 16);
		BA92A434.TabIndex = 31;
		BA92A434.Text = "Tên ha\u0300nh đô\u0323ng:";
		EC83408E.BackColor = Color.Maroon;
		EC83408E.Cursor = Cursors.Hand;
		EC83408E.FlatAppearance.BorderSize = 0;
		EC83408E.FlatStyle = FlatStyle.Flat;
		EC83408E.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		EC83408E.ForeColor = Color.White;
		EC83408E.Location = new Point(220, 252);
		EC83408E.Name = "btnCancel";
		EC83408E.Size = new Size(92, 29);
		EC83408E.TabIndex = 10;
		EC83408E.Text = "Đóng";
		EC83408E.UseVisualStyleBackColor = false;
		EC83408E.Click += EC83408E_Click;
		DC2565B7.BackColor = Color.FromArgb(53, 120, 229);
		DC2565B7.Cursor = Cursors.Hand;
		DC2565B7.FlatAppearance.BorderSize = 0;
		DC2565B7.FlatStyle = FlatStyle.Flat;
		DC2565B7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		DC2565B7.ForeColor = Color.White;
		DC2565B7.Location = new Point(113, 252);
		DC2565B7.Name = "btnAdd";
		DC2565B7.Size = new Size(92, 29);
		DC2565B7.TabIndex = 9;
		DC2565B7.Text = "Thêm";
		DC2565B7.UseVisualStyleBackColor = false;
		DC2565B7.Click += DE2BB989;
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
		bunifuCards1.Size = new Size(424, 37);
		bunifuCards1.TabIndex = 28;
		B9857A1F.AutoSize = true;
		B9857A1F.Location = new Point(27, 87);
		B9857A1F.Name = "label2";
		B9857A1F.Size = new Size(54, 16);
		B9857A1F.TabIndex = 31;
		B9857A1F.Text = "Api sim:";
		txtApi.Location = new Point(132, 84);
		txtApi.Name = "txtApi";
		txtApi.Size = new Size(274, 23);
		txtApi.TabIndex = 0;
		CC287A8D.AutoSize = true;
		CC287A8D.Location = new Point(30, 123);
		CC287A8D.Name = "ckbUpAvatar";
		CC287A8D.Size = new Size(78, 20);
		CC287A8D.TabIndex = 32;
		CC287A8D.Text = "UpAvatar";
		CC287A8D.UseVisualStyleBackColor = true;
		CC287A8D.CheckedChanged += C63A1C32;
		txtPath.Location = new Point(132, 121);
		txtPath.Name = "txtPath";
		txtPath.Size = new Size(274, 23);
		txtPath.TabIndex = 0;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(427, 294);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDVerify";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += DD02EA83;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
