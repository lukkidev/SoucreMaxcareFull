using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fThemHanhDong : Form
{
	public string string_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl E0266596;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuCards bunifuCards1;

	private Panel B69ACF04;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel panel1;

	private ToolTip toolTip_0;

	private Button EA82E519;

	private Panel B7A64910;

	private Label B0B743B4;

	private GClass14 ckbGiaoDienMoi;

	public fThemHanhDong(string CF31D58B)
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		string_0 = CF31D58B;
	}

	private void fThemHanhDong_Load(object sender, EventArgs e)
	{
		ckbGiaoDienMoi.Checked = false;
		ckbGiaoDienMoi_CheckedChanged(null, null);
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			base.Height = 508;
		}
	}

	private void D795B1BE(object sender, EventArgs e)
	{
		Close();
	}

	private void ckbGiaoDienMoi_CheckedChanged(object sender, EventArgs e)
	{
		base.Width = 1180;
		B7A64910.Controls.Clear();
		B7A64910.Controls.Add(new ucThemHanhDong(this));
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemHanhDong));
		E0266596 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		B69ACF04 = new System.Windows.Forms.Panel();
		EA82E519 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		panel1 = new System.Windows.Forms.Panel();
		B7A64910 = new System.Windows.Forms.Panel();
		toolTip_0 = new System.Windows.Forms.ToolTip(icontainer_0);
		ckbGiaoDienMoi = new GClass14();
		B0B743B4 = new System.Windows.Forms.Label();
		B69ACF04.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		bunifuCards1.SuspendLayout();
		panel1.SuspendLayout();
		SuspendLayout();
		E0266596.Fixed = true;
		E0266596.Horizontal = true;
		E0266596.TargetControl = bunifuCustomLabel1;
		E0266596.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(1178, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Danh sách hành động";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = B69ACF04;
		bunifuDragControl_0.Vertical = true;
		B69ACF04.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		B69ACF04.BackColor = System.Drawing.Color.White;
		B69ACF04.Controls.Add(EA82E519);
		B69ACF04.Controls.Add(pictureBox1);
		B69ACF04.Controls.Add(bunifuCustomLabel1);
		B69ACF04.Cursor = System.Windows.Forms.Cursors.SizeAll;
		B69ACF04.Location = new System.Drawing.Point(0, 3);
		B69ACF04.Name = "pnlHeader";
		B69ACF04.Size = new System.Drawing.Size(1178, 31);
		B69ACF04.TabIndex = 9;
		EA82E519.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		EA82E519.Cursor = System.Windows.Forms.Cursors.Hand;
		EA82E519.FlatAppearance.BorderSize = 0;
		EA82E519.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		EA82E519.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EA82E519.ForeColor = System.Drawing.Color.White;
		EA82E519.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
		EA82E519.Location = new System.Drawing.Point(1147, 0);
		EA82E519.Name = "btnClose";
		EA82E519.Size = new System.Drawing.Size(32, 31);
		EA82E519.TabIndex = 77;
		EA82E519.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		EA82E519.UseVisualStyleBackColor = true;
		EA82E519.Click += new System.EventHandler(D795B1BE);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(B69ACF04);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(1180, 37);
		bunifuCards1.TabIndex = 12;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(B7A64910);
		panel1.Controls.Add(B0B743B4);
		panel1.Controls.Add(ckbGiaoDienMoi);
		panel1.Controls.Add(bunifuCards1);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(1183, 546);
		panel1.TabIndex = 25;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		B7A64910.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		B7A64910.Location = new System.Drawing.Point(3, 38);
		B7A64910.Name = "plDanhSachHanhDong";
		B7A64910.Size = new System.Drawing.Size(1174, 476);
		B7A64910.TabIndex = 16;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 0;
		toolTip_0.InitialDelay = 500;
		toolTip_0.ReshowDelay = 0;
		ckbGiaoDienMoi.AutoSize = true;
		ckbGiaoDienMoi.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbGiaoDienMoi.Location = new System.Drawing.Point(93, 518);
		ckbGiaoDienMoi.MinimumSize = new System.Drawing.Size(45, 22);
		ckbGiaoDienMoi.Name = "ckbGiaoDienMoi";
		ckbGiaoDienMoi.Color_0 = System.Drawing.Color.Gray;
		ckbGiaoDienMoi.Color_1 = System.Drawing.Color.Gainsboro;
		ckbGiaoDienMoi.AC1798A0 = System.Drawing.Color.MediumSlateBlue;
		ckbGiaoDienMoi.FCB37134 = System.Drawing.Color.WhiteSmoke;
		ckbGiaoDienMoi.Size = new System.Drawing.Size(45, 22);
		ckbGiaoDienMoi.TabIndex = 14;
		ckbGiaoDienMoi.UseVisualStyleBackColor = true;
		ckbGiaoDienMoi.Visible = false;
		ckbGiaoDienMoi.CheckedChanged += new System.EventHandler(ckbGiaoDienMoi_CheckedChanged);
		B0B743B4.AutoSize = true;
		B0B743B4.Location = new System.Drawing.Point(3, 520);
		B0B743B4.Name = "label1";
		B0B743B4.Size = new System.Drawing.Size(90, 16);
		B0B743B4.TabIndex = 15;
		B0B743B4.Text = "Giao diê\u0323n mơ\u0301i:";
		B0B743B4.Visible = false;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1183, 546);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fThemHanhDong";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fThemHanhDong_Load);
		B69ACF04.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		bunifuCards1.ResumeLayout(false);
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		ResumeLayout(false);
	}
}
