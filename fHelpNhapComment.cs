using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHelpNhapComment : Form
{
	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button BCBBA30B;

	private Button btnCancel;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private Label label1;

	private PictureBox F6363D12;

	private Panel panel1;

	public fHelpNhapComment()
	{
		AE972C2B();
		F7AB102E.D6B70A35(this);
		method_0();
	}

	private void method_0()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(label1);
		F7AB102E.smethod_1(btnCancel);
	}

	private void BCBBA30B_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void ED137103(object sender, EventArgs e)
	{
		Close();
	}

	protected override void Dispose(bool BEAD373B)
	{
		if (BEAD373B && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(BEAD373B);
	}

	private void AE972C2B()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHelpNhapComment));
		bunifuCards1 = new BunifuCards();
		pnlHeader = new Panel();
		pictureBox1 = new PictureBox();
		BCBBA30B = new Button();
		bunifuCustomLabel1 = new BunifuCustomLabel();
		btnCancel = new Button();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		label1 = new Label();
		F6363D12 = new PictureBox();
		panel1 = new Panel();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)F6363D12).BeginInit();
		SuspendLayout();
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.SaddleBrown;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(577, 38);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(BCBBA30B);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(577, 32);
		pnlHeader.TabIndex = 9;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 17;
		pictureBox1.TabStop = false;
		BCBBA30B.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		BCBBA30B.Cursor = Cursors.Hand;
		BCBBA30B.FlatAppearance.BorderSize = 0;
		BCBBA30B.FlatStyle = FlatStyle.Flat;
		BCBBA30B.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		BCBBA30B.ForeColor = Color.White;
		BCBBA30B.Image = (Image)componentResourceManager.GetObject("btnMinimize.Image");
		BCBBA30B.Location = new Point(544, -1);
		BCBBA30B.Name = "btnMinimize";
		BCBBA30B.Size = new Size(32, 32);
		BCBBA30B.TabIndex = 9;
		BCBBA30B.TextImageRelation = TextImageRelation.ImageBeforeText;
		BCBBA30B.UseVisualStyleBackColor = true;
		BCBBA30B.Click += BCBBA30B_Click;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(577, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Hướng dẫn nhập Nội dung có nhiều dòng";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(246, 380);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += ED137103;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		label1.AutoSize = true;
		label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label1.Location = new Point(28, 60);
		label1.Name = "label1";
		label1.Size = new Size(366, 16);
		label1.TabIndex = 5;
		label1.Text = "Vui lòng nhập các nội dung ngăn cách nhau bởi dấu | như sau:";
		F6363D12.BorderStyle = BorderStyle.FixedSingle;
		F6363D12.Image = (Image)componentResourceManager.GetObject("pictureBox2.Image");
		F6363D12.Location = new Point(31, 86);
		F6363D12.Name = "pictureBox2";
		F6363D12.Size = new Size(516, 273);
		F6363D12.TabIndex = 6;
		F6363D12.TabStop = false;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(578, 421);
		panel1.TabIndex = 7;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(578, 421);
		base.Controls.Add(F6363D12);
		base.Controls.Add(label1);
		base.Controls.Add(btnCancel);
		base.Controls.Add(bunifuCards1);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fHelpNhapComment";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fAddFile";
		bunifuCards1.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)F6363D12).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
