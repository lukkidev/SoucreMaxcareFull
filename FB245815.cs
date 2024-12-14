using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class FB245815 : Form
{
	private GClass11 B9B10A0C = null;

	private string DF36A103;

	private string E095C103;

	private string string_0;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl D3ADB627;

	private BunifuDragControl B3A8A93F;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label E007C12C;

	private Label label1;

	private Button BF001DAB;

	private Button F69FE2B3;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox CC10D6AA;

	private BunifuCustomLabel DE0020A7;

	private TextBox txtPathFolder;

	private CheckBox ckbXoaAnhDaDung;

	private CheckBox ckbSkipIfHave;

	private CheckBox D1319E34;

	public FB245815(string B8979E93, int B711CF00 = 0, string F29774AB = "")
	{
		InitializeComponent();
		bool_0 = false;
		DF36A103 = B8979E93;
		string_0 = F29774AB;
		int_0 = B711CF00;
		string text = base.Name.Substring(1);
		string text2 = "Up Cover";
		if (Class147.smethod_7("", text).Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string string_ = "";
		switch (B711CF00)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			string_ = dataTable2.Rows[0]["CauHinh"].ToString();
			E095C103 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(F29774AB);
			string_ = dataTable.Rows[0]["CauHinh"].ToString();
			F69FE2B3.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		B9B10A0C = new GClass11(string_, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void FB245815_Load(object sender, EventArgs e)
	{
		try
		{
			txtPathFolder.Text = B9B10A0C.C0288288("txtPathFolder");
			ckbXoaAnhDaDung.Checked = B9B10A0C.method_3("ckbXoaAnhDaDung");
			ckbSkipIfHave.Checked = B9B10A0C.method_3("ckbSkipIfHave");
			D1319E34.Checked = B9B10A0C.method_3("ckbUuTienMbasic", bool_0: true);
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C8220CB4(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		_ = txtPathFolder.Text;
		GClass11 gClass = new GClass11();
		gClass.method_4("txtPathFolder", txtPathFolder.Text);
		gClass.method_4("ckbXoaAnhDaDung", ckbXoaAnhDaDung.Checked);
		gClass.method_4("ckbSkipIfHave", ckbSkipIfHave.Checked);
		gClass.method_4("ckbUuTienMbasic", D1319E34.Checked);
		string text2 = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(DF36A103, text, E095C103, text2))
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
			if (Class147.smethod_13(string_0, text, text2))
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

	private void D0A7C624(object sender, EventArgs e)
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FB245815));
		D3ADB627 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		DE0020A7 = new Bunifu.Framework.UI.BunifuCustomLabel();
		B3A8A93F = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		CC10D6AA = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		ckbSkipIfHave = new System.Windows.Forms.CheckBox();
		ckbXoaAnhDaDung = new System.Windows.Forms.CheckBox();
		txtPathFolder = new System.Windows.Forms.TextBox();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		E007C12C = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		BF001DAB = new System.Windows.Forms.Button();
		F69FE2B3 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		D1319E34 = new System.Windows.Forms.CheckBox();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)CC10D6AA).BeginInit();
		panel1.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		D3ADB627.Fixed = true;
		D3ADB627.Horizontal = true;
		D3ADB627.TargetControl = DE0020A7;
		D3ADB627.Vertical = true;
		DE0020A7.BackColor = System.Drawing.Color.Transparent;
		DE0020A7.Cursor = System.Windows.Forms.Cursors.SizeAll;
		DE0020A7.Dock = System.Windows.Forms.DockStyle.Fill;
		DE0020A7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DE0020A7.ForeColor = System.Drawing.Color.Black;
		DE0020A7.Location = new System.Drawing.Point(0, 0);
		DE0020A7.Name = "bunifuCustomLabel1";
		DE0020A7.Size = new System.Drawing.Size(359, 31);
		DE0020A7.TabIndex = 12;
		DE0020A7.Text = "Cấu hình Up Cover";
		DE0020A7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B3A8A93F.Fixed = true;
		B3A8A93F.Horizontal = true;
		B3A8A93F.TargetControl = pnlHeader;
		B3A8A93F.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(CC10D6AA);
		pnlHeader.Controls.Add(DE0020A7);
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
		CC10D6AA.Cursor = System.Windows.Forms.Cursors.Default;
		CC10D6AA.Image = C50FB39E.Bitmap_5;
		CC10D6AA.Location = new System.Drawing.Point(3, 2);
		CC10D6AA.Name = "pictureBox1";
		CC10D6AA.Size = new System.Drawing.Size(34, 27);
		CC10D6AA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		CC10D6AA.TabIndex = 76;
		CC10D6AA.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(D1319E34);
		panel1.Controls.Add(ckbSkipIfHave);
		panel1.Controls.Add(ckbXoaAnhDaDung);
		panel1.Controls.Add(txtPathFolder);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(E007C12C);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(BF001DAB);
		panel1.Controls.Add(F69FE2B3);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 239);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		ckbSkipIfHave.AutoSize = true;
		ckbSkipIfHave.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbSkipIfHave.Location = new System.Drawing.Point(132, 134);
		ckbSkipIfHave.Name = "ckbSkipIfHave";
		ckbSkipIfHave.Size = new System.Drawing.Size(171, 20);
		ckbSkipIfHave.TabIndex = 36;
		ckbSkipIfHave.Text = "Bỏ qua nếu đã có ảnh bìa";
		ckbSkipIfHave.UseVisualStyleBackColor = true;
		ckbXoaAnhDaDung.AutoSize = true;
		ckbXoaAnhDaDung.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbXoaAnhDaDung.Location = new System.Drawing.Point(132, 108);
		ckbXoaAnhDaDung.Name = "ckbXoaAnhDaDung";
		ckbXoaAnhDaDung.Size = new System.Drawing.Size(173, 20);
		ckbXoaAnhDaDung.TabIndex = 35;
		ckbXoaAnhDaDung.Text = "Tự động xóa ảnh đã dùng";
		ckbXoaAnhDaDung.UseVisualStyleBackColor = true;
		txtPathFolder.Location = new System.Drawing.Point(132, 79);
		txtPathFolder.Name = "txtPathFolder";
		txtPathFolder.Size = new System.Drawing.Size(194, 23);
		txtPathFolder.TabIndex = 0;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		E007C12C.AutoSize = true;
		E007C12C.Location = new System.Drawing.Point(27, 82);
		E007C12C.Name = "label5";
		E007C12C.Size = new System.Drawing.Size(73, 16);
		E007C12C.TabIndex = 34;
		E007C12C.Text = "Folder ảnh:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		BF001DAB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		BF001DAB.BackColor = System.Drawing.Color.Maroon;
		BF001DAB.Cursor = System.Windows.Forms.Cursors.Hand;
		BF001DAB.FlatAppearance.BorderSize = 0;
		BF001DAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BF001DAB.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		BF001DAB.ForeColor = System.Drawing.Color.White;
		BF001DAB.Location = new System.Drawing.Point(189, 194);
		BF001DAB.Name = "btnCancel";
		BF001DAB.Size = new System.Drawing.Size(92, 29);
		BF001DAB.TabIndex = 10;
		BF001DAB.Text = "Đóng";
		BF001DAB.UseVisualStyleBackColor = false;
		BF001DAB.Click += new System.EventHandler(D0A7C624);
		F69FE2B3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		F69FE2B3.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		F69FE2B3.Cursor = System.Windows.Forms.Cursors.Hand;
		F69FE2B3.FlatAppearance.BorderSize = 0;
		F69FE2B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		F69FE2B3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F69FE2B3.ForeColor = System.Drawing.Color.White;
		F69FE2B3.Location = new System.Drawing.Point(82, 194);
		F69FE2B3.Name = "btnAdd";
		F69FE2B3.Size = new System.Drawing.Size(92, 29);
		F69FE2B3.TabIndex = 9;
		F69FE2B3.Text = "Thêm";
		F69FE2B3.UseVisualStyleBackColor = false;
		F69FE2B3.Click += new System.EventHandler(C8220CB4);
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
		D1319E34.AutoSize = true;
		D1319E34.Cursor = System.Windows.Forms.Cursors.Hand;
		D1319E34.Location = new System.Drawing.Point(132, 160);
		D1319E34.Name = "ckbUuTienMbasic";
		D1319E34.Size = new System.Drawing.Size(173, 20);
		D1319E34.TabIndex = 199;
		D1319E34.Text = "Ưu tiên chạy bằng mbasic";
		D1319E34.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 239);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDUpCover";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(FB245815_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)CC10D6AA).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
