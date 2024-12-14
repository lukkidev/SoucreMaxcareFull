using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class C620FC22 : Form
{
	public bool D2381713 = false;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl CD827120;

	private PictureBox pictureBox1;

	private CheckBox ckbGetCookie;

	private ComboBox A9906406;

	private Label label1;

	private CheckBox DB929803;

	private ComboBox cbbRunBy;

	private Label B8805C81;

	public C620FC22()
	{
		InitializeComponent();
		D2381713 = false;
		F7AB102E.D6B70A35(this);
	}

	private void DB8C0C80(object sender, EventArgs e)
	{
		Close();
	}

	private void A9921CB3(object sender, EventArgs e)
	{
		GClass25.smethod_0("configGetToken").method_4("cbbGetToken", A9906406.SelectedIndex);
		GClass25.smethod_0("configGetToken").method_4("cbbRunBy", cbbRunBy.SelectedIndex);
		GClass25.smethod_0("configGetToken").method_4("ckbCheckWall", DB929803.Checked);
		GClass25.smethod_0("configGetToken").method_4("ckbGetCookie", ckbGetCookie.Checked);
		GClass25.B3B73732("configGetToken");
		D2381713 = true;
		Close();
	}

	private void EC020A04(object sender, EventArgs e)
	{
		Close();
	}

	private void AB3CF392(object sender, EventArgs e)
	{
		A9906406.SelectedIndex = GClass25.smethod_0("configGetToken").method_2("cbbGetToken");
		cbbRunBy.SelectedIndex = GClass25.smethod_0("configGetToken").method_2("cbbRunBy");
		DB929803.Checked = GClass25.smethod_0("configGetToken").method_3("ckbCheckWall");
		ckbGetCookie.Checked = GClass25.smethod_0("configGetToken").method_3("ckbGetCookie");
	}

	private void cbbRunBy_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (cbbRunBy.SelectedIndex == 1)
		{
			ckbGetCookie.Enabled = false;
			ckbGetCookie.Checked = false;
		}
		else
		{
			ckbGetCookie.Enabled = true;
		}
	}

	protected override void Dispose(bool F41BB825)
	{
		if (F41BB825 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(F41BB825);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C620FC22));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		CD827120 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		ckbGetCookie = new System.Windows.Forms.CheckBox();
		A9906406 = new System.Windows.Forms.ComboBox();
		label1 = new System.Windows.Forms.Label();
		DB929803 = new System.Windows.Forms.CheckBox();
		cbbRunBy = new System.Windows.Forms.ComboBox();
		B8805C81 = new System.Windows.Forms.Label();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(304, 32);
		pnlHeader.TabIndex = 9;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 17;
		pictureBox1.TabStop = false;
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
		btnMinimize.Click += new System.EventHandler(DB8C0C80);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(304, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Câ\u0301u hi\u0300nh Get Token";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(160, 148);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(EC020A04);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(56, 148);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(A9921CB3);
		CD827120.Fixed = true;
		CD827120.Horizontal = true;
		CD827120.TargetControl = bunifuCustomLabel1;
		CD827120.Vertical = true;
		ckbGetCookie.AutoSize = true;
		ckbGetCookie.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbGetCookie.Location = new System.Drawing.Point(175, 115);
		ckbGetCookie.Name = "ckbGetCookie";
		ckbGetCookie.Size = new System.Drawing.Size(85, 20);
		ckbGetCookie.TabIndex = 5;
		ckbGetCookie.Text = "Get cookie";
		ckbGetCookie.UseVisualStyleBackColor = true;
		A9906406.Cursor = System.Windows.Forms.Cursors.Hand;
		A9906406.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		A9906406.FormattingEnabled = true;
		A9906406.Items.AddRange(new object[2] { "EAAAAU", "EAAAAY" });
		A9906406.Location = new System.Drawing.Point(129, 55);
		A9906406.Name = "cbbGetToken";
		A9906406.Size = new System.Drawing.Size(131, 24);
		A9906406.TabIndex = 6;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(53, 58);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(70, 16);
		label1.TabIndex = 7;
		label1.Text = "Loa\u0323i token:";
		DB929803.AutoSize = true;
		DB929803.Cursor = System.Windows.Forms.Cursors.Hand;
		DB929803.Location = new System.Drawing.Point(56, 115);
		DB929803.Name = "ckbCheckWall";
		DB929803.Size = new System.Drawing.Size(89, 20);
		DB929803.TabIndex = 5;
		DB929803.Text = "Check Wall";
		DB929803.UseVisualStyleBackColor = true;
		cbbRunBy.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbRunBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbRunBy.FormattingEnabled = true;
		cbbRunBy.Items.AddRange(new object[3] { "Uid|pass", "Cookie", "Cookie>Uid|pass" });
		cbbRunBy.Location = new System.Drawing.Point(129, 85);
		cbbRunBy.Name = "cbbRunBy";
		cbbRunBy.Size = new System.Drawing.Size(131, 24);
		cbbRunBy.TabIndex = 6;
		cbbRunBy.SelectedIndexChanged += new System.EventHandler(cbbRunBy_SelectedIndexChanged);
		B8805C81.AutoSize = true;
		B8805C81.Location = new System.Drawing.Point(53, 88);
		B8805C81.Name = "label2";
		B8805C81.Size = new System.Drawing.Size(72, 16);
		B8805C81.TabIndex = 7;
		B8805C81.Text = "Chạy bằng:";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(304, 190);
		base.Controls.Add(B8805C81);
		base.Controls.Add(label1);
		base.Controls.Add(cbbRunBy);
		base.Controls.Add(A9906406);
		base.Controls.Add(DB929803);
		base.Controls.Add(ckbGetCookie);
		base.Controls.Add(btnCancel);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhGetToken";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(AB3CF392);
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
