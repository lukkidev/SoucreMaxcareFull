using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTemplateForm : Form
{
	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button B301C115;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private Panel E6A046A7;

	public fTemplateForm()
	{
		E6A992BB();
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(B301C115);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void D4AC529A(object sender, EventArgs e)
	{
		Close();
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void E6A992BB()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fTemplateForm));
		bunifuCards1 = new BunifuCards();
		pnlHeader = new Panel();
		pictureBox1 = new PictureBox();
		btnMinimize = new Button();
		bunifuCustomLabel1 = new BunifuCustomLabel();
		B301C115 = new Button();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		E6A046A7 = new Panel();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
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
		bunifuCards1.Size = new Size(832, 38);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(832, 32);
		pnlHeader.TabIndex = 9;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 17;
		pictureBox1.TabStop = false;
		btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		btnMinimize.Cursor = Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = FlatStyle.Flat;
		btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = Color.White;
		btnMinimize.Image = (Image)componentResourceManager.GetObject("btnMinimize.Image");
		btnMinimize.Location = new Point(799, -1);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += btnMinimize_Click;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(832, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Hướng dẫn nhập Nội dung có nhiều dòng";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		B301C115.Anchor = AnchorStyles.Bottom;
		B301C115.BackColor = Color.Maroon;
		B301C115.Cursor = Cursors.Hand;
		B301C115.FlatAppearance.BorderSize = 0;
		B301C115.FlatStyle = FlatStyle.Flat;
		B301C115.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		B301C115.ForeColor = Color.White;
		B301C115.Location = new Point(370, 501);
		B301C115.Name = "btnCancel";
		B301C115.Size = new Size(92, 29);
		B301C115.TabIndex = 4;
		B301C115.Text = "Đo\u0301ng";
		B301C115.UseVisualStyleBackColor = false;
		B301C115.Click += D4AC529A;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		E6A046A7.BorderStyle = BorderStyle.FixedSingle;
		E6A046A7.Dock = DockStyle.Fill;
		E6A046A7.Location = new Point(0, 0);
		E6A046A7.Name = "panel1";
		E6A046A7.Size = new Size(833, 542);
		E6A046A7.TabIndex = 5;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(833, 542);
		base.Controls.Add(B301C115);
		base.Controls.Add(bunifuCards1);
		base.Controls.Add(E6A046A7);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fTemplateForm";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fAddFile";
		bunifuCards1.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(performLayout: false);
	}
}
