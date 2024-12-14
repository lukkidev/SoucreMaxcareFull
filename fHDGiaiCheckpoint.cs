using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDGiaiCheckpoint : Form
{
	private GClass11 gclass11_0;

	private string CF054B8E;

	private string string_0;

	private string AF18B4A1;

	private int FA9C2E8C;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl FF30DCB9;

	private BunifuDragControl bunifuDragControl_0;

	private Panel AA81E232;

	private TextBox A61E1419;

	private Label label1;

	private Button B7B45099;

	private Button E6A2D33E;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button EAA2E7A5;

	private PictureBox E30A91A5;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox ckbCaptcha;

	private TextBox txtImage;

	private CheckBox ckbImage;

	private TextBox txtPhone;

	private CheckBox EC32B937;

	private TextBox txtCaptcha;

	public fHDGiaiCheckpoint(string DE8AF006, int int_0 = 0, string FD105F9F = "")
	{
		InitializeComponent();
		bool_0 = false;
		CF054B8E = DE8AF006;
		AF18B4A1 = FD105F9F;
		FA9C2E8C = int_0;
		if (Class147.smethod_7("", "HDGiaiCheckpoint").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDGiaiCheckpoint', 'Giải checkpoint');");
		}
		string string_ = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDGiaiCheckpoint");
			string_ = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			A61E1419.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(FD105F9F);
			string_ = dataTable.Rows[0]["CauHinh"].ToString();
			E6A2D33E.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			A61E1419.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(string_, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void E530E10C()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(label1);
		F7AB102E.smethod_1(E6A2D33E);
		F7AB102E.smethod_1(B7B45099);
	}

	private void E6057C3D(object sender, EventArgs e)
	{
		try
		{
			ckbCaptcha.Checked = gclass11_0.method_3("ckbCaptcha");
			txtCaptcha.Text = gclass11_0.C0288288("txtCaptcha");
			EC32B937.Checked = gclass11_0.method_3("ckbPhone");
			txtPhone.Text = gclass11_0.C0288288("txtPhone");
			ckbImage.Checked = gclass11_0.method_3("ckbImage");
			txtImage.Text = gclass11_0.C0288288("txtImage");
		}
		catch
		{
		}
		method_0();
	}

	private void EAA2E7A5_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E6A2D33E_Click(object sender, EventArgs e)
	{
		string text = A61E1419.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("ckbCaptcha", ckbCaptcha.Checked);
		gClass.method_4("txtCaptcha", txtCaptcha.Text);
		gClass.method_4("ckbPhone", EC32B937.Checked);
		gClass.method_4("txtPhone", txtPhone.Text);
		gClass.method_4("ckbImage", ckbImage.Checked);
		gClass.method_4("txtImage", txtImage.Text);
		string text2 = gClass.method_7();
		if (FA9C2E8C == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(CF054B8E, text, string_0, text2))
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
			if (Class147.smethod_13(AF18B4A1, text, text2))
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

	private void method_0()
	{
		BC2AB71A(null, null);
		EC32B937_CheckedChanged(null, null);
		ckbImage_CheckedChanged(null, null);
	}

	private void B7B45099_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void AA81E232_Paint(object sender, PaintEventArgs e)
	{
		if (AA81E232.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, AA81E232.ClientSize.Width - num, AA81E232.ClientSize.Height - num));
		}
	}

	private void BC2AB71A(object sender, EventArgs e)
	{
		txtCaptcha.Enabled = ckbCaptcha.Checked;
	}

	private void EC32B937_CheckedChanged(object sender, EventArgs e)
	{
		txtPhone.Enabled = EC32B937.Checked;
	}

	private void ckbImage_CheckedChanged(object sender, EventArgs e)
	{
		txtImage.Enabled = ckbImage.Checked;
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
		FF30DCB9 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		EAA2E7A5 = new System.Windows.Forms.Button();
		E30A91A5 = new System.Windows.Forms.PictureBox();
		AA81E232 = new System.Windows.Forms.Panel();
		txtImage = new System.Windows.Forms.TextBox();
		ckbImage = new System.Windows.Forms.CheckBox();
		txtPhone = new System.Windows.Forms.TextBox();
		EC32B937 = new System.Windows.Forms.CheckBox();
		txtCaptcha = new System.Windows.Forms.TextBox();
		ckbCaptcha = new System.Windows.Forms.CheckBox();
		A61E1419 = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		B7B45099 = new System.Windows.Forms.Button();
		E6A2D33E = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)E30A91A5).BeginInit();
		AA81E232.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		FF30DCB9.Fixed = true;
		FF30DCB9.Horizontal = true;
		FF30DCB9.TargetControl = bunifuCustomLabel1;
		FF30DCB9.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Giải Checkpoint";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(EAA2E7A5);
		pnlHeader.Controls.Add(E30A91A5);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(359, 31);
		pnlHeader.TabIndex = 9;
		EAA2E7A5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		EAA2E7A5.Cursor = System.Windows.Forms.Cursors.Hand;
		EAA2E7A5.FlatAppearance.BorderSize = 0;
		EAA2E7A5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		EAA2E7A5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EAA2E7A5.ForeColor = System.Drawing.Color.White;
		EAA2E7A5.Image = C50FB39E.Bitmap_13;
		EAA2E7A5.Location = new System.Drawing.Point(328, 1);
		EAA2E7A5.Name = "button1";
		EAA2E7A5.Size = new System.Drawing.Size(30, 30);
		EAA2E7A5.TabIndex = 77;
		EAA2E7A5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		EAA2E7A5.UseVisualStyleBackColor = true;
		EAA2E7A5.Click += new System.EventHandler(EAA2E7A5_Click);
		E30A91A5.Cursor = System.Windows.Forms.Cursors.Default;
		E30A91A5.Image = C50FB39E.Bitmap_5;
		E30A91A5.Location = new System.Drawing.Point(3, 2);
		E30A91A5.Name = "pictureBox1";
		E30A91A5.Size = new System.Drawing.Size(34, 27);
		E30A91A5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		E30A91A5.TabIndex = 76;
		E30A91A5.TabStop = false;
		AA81E232.BackColor = System.Drawing.Color.White;
		AA81E232.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		AA81E232.Controls.Add(txtImage);
		AA81E232.Controls.Add(ckbImage);
		AA81E232.Controls.Add(txtPhone);
		AA81E232.Controls.Add(EC32B937);
		AA81E232.Controls.Add(txtCaptcha);
		AA81E232.Controls.Add(ckbCaptcha);
		AA81E232.Controls.Add(A61E1419);
		AA81E232.Controls.Add(label1);
		AA81E232.Controls.Add(B7B45099);
		AA81E232.Controls.Add(E6A2D33E);
		AA81E232.Controls.Add(bunifuCards1);
		AA81E232.Cursor = System.Windows.Forms.Cursors.Arrow;
		AA81E232.Dock = System.Windows.Forms.DockStyle.Fill;
		AA81E232.Location = new System.Drawing.Point(0, 0);
		AA81E232.Name = "panel1";
		AA81E232.Size = new System.Drawing.Size(362, 222);
		AA81E232.TabIndex = 0;
		AA81E232.Paint += new System.Windows.Forms.PaintEventHandler(AA81E232_Paint);
		txtImage.Location = new System.Drawing.Point(122, 138);
		txtImage.Name = "txtImage";
		txtImage.Size = new System.Drawing.Size(220, 23);
		txtImage.TabIndex = 37;
		ckbImage.AutoSize = true;
		ckbImage.Location = new System.Drawing.Point(20, 140);
		ckbImage.Name = "ckbImage";
		ckbImage.Size = new System.Drawing.Size(72, 20);
		ckbImage.TabIndex = 36;
		ckbImage.Text = "Up ảnh:";
		ckbImage.UseVisualStyleBackColor = true;
		ckbImage.CheckedChanged += new System.EventHandler(ckbImage_CheckedChanged);
		txtPhone.Location = new System.Drawing.Point(122, 109);
		txtPhone.Name = "txtPhone";
		txtPhone.Size = new System.Drawing.Size(220, 23);
		txtPhone.TabIndex = 35;
		EC32B937.AutoSize = true;
		EC32B937.Location = new System.Drawing.Point(20, 111);
		EC32B937.Name = "ckbPhone";
		EC32B937.Size = new System.Drawing.Size(94, 20);
		EC32B937.TabIndex = 34;
		EC32B937.Text = "Thêm SĐT:";
		EC32B937.UseVisualStyleBackColor = true;
		EC32B937.CheckedChanged += new System.EventHandler(EC32B937_CheckedChanged);
		txtCaptcha.Location = new System.Drawing.Point(122, 80);
		txtCaptcha.Name = "txtCaptcha";
		txtCaptcha.Size = new System.Drawing.Size(220, 23);
		txtCaptcha.TabIndex = 33;
		ckbCaptcha.AutoSize = true;
		ckbCaptcha.Location = new System.Drawing.Point(20, 82);
		ckbCaptcha.Name = "ckbCaptcha";
		ckbCaptcha.Size = new System.Drawing.Size(101, 20);
		ckbCaptcha.TabIndex = 32;
		ckbCaptcha.Text = "Giải captcha:";
		ckbCaptcha.UseVisualStyleBackColor = true;
		ckbCaptcha.CheckedChanged += new System.EventHandler(BC2AB71A);
		A61E1419.Location = new System.Drawing.Point(122, 49);
		A61E1419.Name = "txtTenHanhDong";
		A61E1419.Size = new System.Drawing.Size(220, 23);
		A61E1419.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(17, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(99, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		B7B45099.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		B7B45099.BackColor = System.Drawing.Color.Maroon;
		B7B45099.Cursor = System.Windows.Forms.Cursors.Hand;
		B7B45099.FlatAppearance.BorderSize = 0;
		B7B45099.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B7B45099.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B7B45099.ForeColor = System.Drawing.Color.White;
		B7B45099.Location = new System.Drawing.Point(191, 180);
		B7B45099.Name = "btnCancel";
		B7B45099.Size = new System.Drawing.Size(92, 29);
		B7B45099.TabIndex = 10;
		B7B45099.Text = "Đóng";
		B7B45099.UseVisualStyleBackColor = false;
		B7B45099.Click += new System.EventHandler(B7B45099_Click);
		E6A2D33E.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		E6A2D33E.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		E6A2D33E.Cursor = System.Windows.Forms.Cursors.Hand;
		E6A2D33E.FlatAppearance.BorderSize = 0;
		E6A2D33E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E6A2D33E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E6A2D33E.ForeColor = System.Drawing.Color.White;
		E6A2D33E.Location = new System.Drawing.Point(84, 180);
		E6A2D33E.Name = "btnAdd";
		E6A2D33E.Size = new System.Drawing.Size(92, 29);
		E6A2D33E.TabIndex = 9;
		E6A2D33E.Text = "Thêm";
		E6A2D33E.UseVisualStyleBackColor = false;
		E6A2D33E.Click += new System.EventHandler(E6A2D33E_Click);
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
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 222);
		base.Controls.Add(AA81E232);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDGiaiCheckpoint";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(E6057C3D);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)E30A91A5).EndInit();
		AA81E232.ResumeLayout(false);
		AA81E232.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
