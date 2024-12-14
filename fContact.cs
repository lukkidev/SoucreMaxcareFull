using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fContact : Form
{
	private IContainer icontainer_0 = null;

	private BunifuCards C68A7639;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button B308DCA3;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox A09E561E;

	private Panel C5B0980F;

	private ucContact ucContact1;

	private ucContact2 FF9DD82B;

	public fContact()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
	}

	private void B308DCA3_Click(object sender, EventArgs e)
	{
		Close();
	}

	protected override void Dispose(bool B723DE9B)
	{
		if (B723DE9B && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B723DE9B);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fContact));
		C68A7639 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		A09E561E = new System.Windows.Forms.PictureBox();
		B308DCA3 = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		C5B0980F = new System.Windows.Forms.Panel();
		ucContact1 = new ucContact();
		FF9DD82B = new ucContact2();
		C68A7639.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)A09E561E).BeginInit();
		C5B0980F.SuspendLayout();
		SuspendLayout();
		C68A7639.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		C68A7639.BackColor = System.Drawing.Color.White;
		C68A7639.BorderRadius = 0;
		C68A7639.BottomSahddow = true;
		C68A7639.color = System.Drawing.Color.SaddleBrown;
		C68A7639.Controls.Add(pnlHeader);
		C68A7639.LeftSahddow = false;
		C68A7639.Location = new System.Drawing.Point(1, 0);
		C68A7639.Name = "bunifuCards1";
		C68A7639.RightSahddow = true;
		C68A7639.ShadowDepth = 20;
		C68A7639.Size = new System.Drawing.Size(742, 38);
		C68A7639.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(A09E561E);
		pnlHeader.Controls.Add(B308DCA3);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(742, 32);
		pnlHeader.TabIndex = 9;
		A09E561E.Cursor = System.Windows.Forms.Cursors.Default;
		A09E561E.Image = C50FB39E.Bitmap_5;
		A09E561E.Location = new System.Drawing.Point(3, 2);
		A09E561E.Name = "pictureBox1";
		A09E561E.Size = new System.Drawing.Size(34, 27);
		A09E561E.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		A09E561E.TabIndex = 17;
		A09E561E.TabStop = false;
		B308DCA3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		B308DCA3.Cursor = System.Windows.Forms.Cursors.Hand;
		B308DCA3.FlatAppearance.BorderSize = 0;
		B308DCA3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B308DCA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B308DCA3.ForeColor = System.Drawing.Color.White;
		B308DCA3.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		B308DCA3.Location = new System.Drawing.Point(709, -1);
		B308DCA3.Name = "btnMinimize";
		B308DCA3.Size = new System.Drawing.Size(32, 32);
		B308DCA3.TabIndex = 9;
		B308DCA3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		B308DCA3.UseVisualStyleBackColor = true;
		B308DCA3.Click += new System.EventHandler(B308DCA3_Click);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(742, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Thông tin liên hệ";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		C5B0980F.BackColor = System.Drawing.Color.White;
		C5B0980F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C5B0980F.Controls.Add(ucContact1);
		C5B0980F.Controls.Add(FF9DD82B);
		C5B0980F.Dock = System.Windows.Forms.DockStyle.Fill;
		C5B0980F.Location = new System.Drawing.Point(0, 0);
		C5B0980F.Name = "panel1";
		C5B0980F.Size = new System.Drawing.Size(743, 531);
		C5B0980F.TabIndex = 5;
		ucContact1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ucContact1.Location = new System.Drawing.Point(12, 44);
		ucContact1.Margin = new System.Windows.Forms.Padding(4);
		ucContact1.Name = "ucContact1";
		ucContact1.Size = new System.Drawing.Size(714, 470);
		ucContact1.TabIndex = 0;
		FF9DD82B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		FF9DD82B.Location = new System.Drawing.Point(12, 44);
		FF9DD82B.Margin = new System.Windows.Forms.Padding(4);
		FF9DD82B.Name = "ucContact21";
		FF9DD82B.Size = new System.Drawing.Size(714, 470);
		FF9DD82B.TabIndex = 1;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(743, 531);
		base.Controls.Add(C68A7639);
		base.Controls.Add(C5B0980F);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fContact";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		C68A7639.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)A09E561E).EndInit();
		C5B0980F.ResumeLayout(false);
		ResumeLayout(false);
	}
}
