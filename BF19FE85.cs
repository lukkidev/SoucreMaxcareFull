using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class BF19FE85 : Form
{
	private IContainer A50D9215 = null;

	private BunifuCards bunifuCards1;

	private Panel panel1;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip toolTip_0;

	private BunifuCards E30AAC99;

	private Panel pnlHeader;

	private Button button2;

	private PictureBox A30CB409;

	private Button E5301FA6;

	private BunifuCustomLabel lblTitle;

	private Button B10488AB;

	private RichTextBox CC10410A;

	private GroupBox C29F723D;

	private RichTextBox BF32C415;

	private GroupBox E3314611;

	public BF19FE85()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B10488AB_Click(object sender, EventArgs e)
	{
		try
		{
			string string_ = CC10410A.Text;
			BF32C415.Text = GClass8.smethod_29(string_);
		}
		catch (Exception)
		{
			GClass29.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void E8B3D49A(object sender, EventArgs e)
	{
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void BF32C415_TextChanged(object sender, EventArgs e)
	{
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void BF19FE85_Load(object sender, EventArgs e)
	{
		method_0(null, null);
		method_1(null, null);
	}

	protected override void Dispose(bool BC843A1A)
	{
		if (BC843A1A && A50D9215 != null)
		{
			A50D9215.Dispose();
		}
		base.Dispose(BC843A1A);
	}

	private void InitializeComponent()
	{
		A50D9215 = new System.ComponentModel.Container();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		panel1 = new System.Windows.Forms.Panel();
		C29F723D = new System.Windows.Forms.GroupBox();
		BF32C415 = new System.Windows.Forms.RichTextBox();
		E3314611 = new System.Windows.Forms.GroupBox();
		CC10410A = new System.Windows.Forms.RichTextBox();
		B10488AB = new System.Windows.Forms.Button();
		E30AAC99 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		A30CB409 = new System.Windows.Forms.PictureBox();
		E5301FA6 = new System.Windows.Forms.Button();
		lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(A50D9215);
		toolTip_0 = new System.Windows.Forms.ToolTip(A50D9215);
		panel1.SuspendLayout();
		C29F723D.SuspendLayout();
		E3314611.SuspendLayout();
		E30AAC99.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)A30CB409).BeginInit();
		SuspendLayout();
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 5;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(509, 47);
		bunifuCards1.TabIndex = 12;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(C29F723D);
		panel1.Controls.Add(E3314611);
		panel1.Controls.Add(B10488AB);
		panel1.Controls.Add(E30AAC99);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(838, 586);
		panel1.TabIndex = 37;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		C29F723D.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		C29F723D.Controls.Add(BF32C415);
		C29F723D.Location = new System.Drawing.Point(469, 40);
		C29F723D.Name = "groupBox2";
		C29F723D.Size = new System.Drawing.Size(361, 539);
		C29F723D.TabIndex = 51;
		C29F723D.TabStop = false;
		C29F723D.Text = "Output";
		BF32C415.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		BF32C415.Location = new System.Drawing.Point(6, 22);
		BF32C415.Name = "txtOutput";
		BF32C415.Size = new System.Drawing.Size(349, 510);
		BF32C415.TabIndex = 50;
		BF32C415.Text = "";
		BF32C415.WordWrap = false;
		BF32C415.TextChanged += new System.EventHandler(BF32C415_TextChanged);
		E3314611.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		E3314611.Controls.Add(CC10410A);
		E3314611.Location = new System.Drawing.Point(6, 40);
		E3314611.Name = "groupBox1";
		E3314611.Size = new System.Drawing.Size(361, 539);
		E3314611.TabIndex = 51;
		E3314611.TabStop = false;
		E3314611.Text = "Input";
		CC10410A.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		CC10410A.Location = new System.Drawing.Point(6, 22);
		CC10410A.Name = "txtInput";
		CC10410A.Size = new System.Drawing.Size(349, 510);
		CC10410A.TabIndex = 50;
		CC10410A.Text = "";
		CC10410A.WordWrap = false;
		CC10410A.TextChanged += new System.EventHandler(E8B3D49A);
		B10488AB.BackColor = System.Drawing.Color.Green;
		B10488AB.Cursor = System.Windows.Forms.Cursors.Hand;
		B10488AB.FlatAppearance.BorderSize = 0;
		B10488AB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B10488AB.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B10488AB.ForeColor = System.Drawing.Color.White;
		B10488AB.Location = new System.Drawing.Point(379, 138);
		B10488AB.Name = "btnAdd";
		B10488AB.Size = new System.Drawing.Size(78, 29);
		B10488AB.TabIndex = 45;
		B10488AB.Text = "Spin";
		B10488AB.UseVisualStyleBackColor = false;
		B10488AB.Click += new System.EventHandler(B10488AB_Click);
		E30AAC99.BackColor = System.Drawing.Color.White;
		E30AAC99.BorderRadius = 0;
		E30AAC99.BottomSahddow = true;
		E30AAC99.color = System.Drawing.Color.SaddleBrown;
		E30AAC99.Controls.Add(pnlHeader);
		E30AAC99.Dock = System.Windows.Forms.DockStyle.Top;
		E30AAC99.LeftSahddow = false;
		E30AAC99.Location = new System.Drawing.Point(0, 0);
		E30AAC99.Name = "bunifuCards2";
		E30AAC99.RightSahddow = true;
		E30AAC99.ShadowDepth = 20;
		E30AAC99.Size = new System.Drawing.Size(836, 37);
		E30AAC99.TabIndex = 43;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button2);
		pnlHeader.Controls.Add(A30CB409);
		pnlHeader.Controls.Add(E5301FA6);
		pnlHeader.Controls.Add(lblTitle);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(836, 31);
		pnlHeader.TabIndex = 9;
		button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button2.ForeColor = System.Drawing.Color.White;
		button2.Image = C50FB39E.Bitmap_12;
		button2.Location = new System.Drawing.Point(805, 1);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		A30CB409.Cursor = System.Windows.Forms.Cursors.Default;
		A30CB409.Image = C50FB39E.Bitmap_5;
		A30CB409.Location = new System.Drawing.Point(3, 2);
		A30CB409.Name = "pictureBox1";
		A30CB409.Size = new System.Drawing.Size(34, 27);
		A30CB409.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		A30CB409.TabIndex = 76;
		A30CB409.TabStop = false;
		E5301FA6.Cursor = System.Windows.Forms.Cursors.Hand;
		E5301FA6.FlatAppearance.BorderSize = 0;
		E5301FA6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E5301FA6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		E5301FA6.ForeColor = System.Drawing.Color.White;
		E5301FA6.Location = new System.Drawing.Point(899, 1);
		E5301FA6.Name = "btnMinimize";
		E5301FA6.Size = new System.Drawing.Size(30, 30);
		E5301FA6.TabIndex = 9;
		E5301FA6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		E5301FA6.UseVisualStyleBackColor = true;
		lblTitle.BackColor = System.Drawing.Color.Transparent;
		lblTitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
		lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
		lblTitle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblTitle.ForeColor = System.Drawing.Color.Black;
		lblTitle.Location = new System.Drawing.Point(0, 0);
		lblTitle.Name = "lblTitle";
		lblTitle.Size = new System.Drawing.Size(836, 31);
		lblTitle.TabIndex = 12;
		lblTitle.Text = "Test Spin Content";
		lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = lblTitle;
		bunifuDragControl_0.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(838, 586);
		base.Controls.Add(panel1);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fTienIchTestSpinContent";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(BF19FE85_Load);
		panel1.ResumeLayout(false);
		C29F723D.ResumeLayout(false);
		E3314611.ResumeLayout(false);
		E30AAC99.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)A30CB409).EndInit();
		ResumeLayout(false);
	}
}
