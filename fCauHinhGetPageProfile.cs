using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhGetPageProfile : Form
{
	public bool DE820BAD = false;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel DDB9E8AF;

	private Button btnMinimize;

	private Button F33F8ABF;

	private Button EE17E3A9;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox BF83009A;

	private ComboBox cbbGetToken;

	private Label label1;

	public fCauHinhGetPageProfile()
	{
		InitializeComponent();
		DE820BAD = false;
		F7AB102E.D6B70A35(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void EE17E3A9_Click(object sender, EventArgs e)
	{
		GClass25.smethod_0("configGetPageProfile").method_4("cbbGetToken", cbbGetToken.SelectedIndex);
		GClass25.B3B73732("configGetPageProfile");
		DE820BAD = true;
		Close();
	}

	private void F33F8ABF_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fCauHinhGetPageProfile_Load(object sender, EventArgs e)
	{
		cbbGetToken.SelectedIndex = GClass25.smethod_0("configGetPageProfile").method_2("cbbGetToken");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhGetPageProfile));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		BF83009A = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		DDB9E8AF = new Bunifu.Framework.UI.BunifuCustomLabel();
		F33F8ABF = new System.Windows.Forms.Button();
		EE17E3A9 = new System.Windows.Forms.Button();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		cbbGetToken = new System.Windows.Forms.ComboBox();
		label1 = new System.Windows.Forms.Label();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)BF83009A).BeginInit();
		SuspendLayout();
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(304, 38);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(BF83009A);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(DDB9E8AF);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(304, 32);
		pnlHeader.TabIndex = 9;
		BF83009A.Cursor = System.Windows.Forms.Cursors.Default;
		BF83009A.Image = C50FB39E.Bitmap_5;
		BF83009A.Location = new System.Drawing.Point(3, 2);
		BF83009A.Name = "pictureBox1";
		BF83009A.Size = new System.Drawing.Size(34, 27);
		BF83009A.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		BF83009A.TabIndex = 17;
		BF83009A.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(272, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		DDB9E8AF.BackColor = System.Drawing.Color.Transparent;
		DDB9E8AF.Cursor = System.Windows.Forms.Cursors.SizeAll;
		DDB9E8AF.Dock = System.Windows.Forms.DockStyle.Fill;
		DDB9E8AF.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DDB9E8AF.ForeColor = System.Drawing.Color.Black;
		DDB9E8AF.Location = new System.Drawing.Point(0, 0);
		DDB9E8AF.Name = "bunifuCustomLabel1";
		DDB9E8AF.Size = new System.Drawing.Size(304, 32);
		DDB9E8AF.TabIndex = 1;
		DDB9E8AF.Text = "Câ\u0301u hi\u0300nh Get Page Profile";
		DDB9E8AF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F33F8ABF.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		F33F8ABF.BackColor = System.Drawing.Color.Maroon;
		F33F8ABF.Cursor = System.Windows.Forms.Cursors.Hand;
		F33F8ABF.FlatAppearance.BorderSize = 0;
		F33F8ABF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		F33F8ABF.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F33F8ABF.ForeColor = System.Drawing.Color.White;
		F33F8ABF.Location = new System.Drawing.Point(160, 100);
		F33F8ABF.Name = "btnCancel";
		F33F8ABF.Size = new System.Drawing.Size(92, 29);
		F33F8ABF.TabIndex = 4;
		F33F8ABF.Text = "Đo\u0301ng";
		F33F8ABF.UseVisualStyleBackColor = false;
		F33F8ABF.Click += new System.EventHandler(F33F8ABF_Click);
		EE17E3A9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		EE17E3A9.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		EE17E3A9.Cursor = System.Windows.Forms.Cursors.Hand;
		EE17E3A9.FlatAppearance.BorderSize = 0;
		EE17E3A9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		EE17E3A9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		EE17E3A9.ForeColor = System.Drawing.Color.White;
		EE17E3A9.Location = new System.Drawing.Point(56, 100);
		EE17E3A9.Name = "btnAdd";
		EE17E3A9.Size = new System.Drawing.Size(92, 29);
		EE17E3A9.TabIndex = 3;
		EE17E3A9.Text = "Lưu";
		EE17E3A9.UseVisualStyleBackColor = false;
		EE17E3A9.Click += new System.EventHandler(EE17E3A9_Click);
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = DDB9E8AF;
		bunifuDragControl_0.Vertical = true;
		cbbGetToken.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbGetToken.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbGetToken.FormattingEnabled = true;
		cbbGetToken.Items.AddRange(new object[2] { "EAAG", "EAAAAU" });
		cbbGetToken.Location = new System.Drawing.Point(126, 54);
		cbbGetToken.Name = "cbbGetToken";
		cbbGetToken.Size = new System.Drawing.Size(131, 24);
		cbbGetToken.TabIndex = 6;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(50, 57);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(70, 16);
		label1.TabIndex = 7;
		label1.Text = "Loa\u0323i token:";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(304, 142);
		base.Controls.Add(label1);
		base.Controls.Add(cbbGetToken);
		base.Controls.Add(F33F8ABF);
		base.Controls.Add(EE17E3A9);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhGetPageProfile";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(fCauHinhGetPageProfile_Load);
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)BF83009A).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
