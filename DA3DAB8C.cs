using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class DA3DAB8C : Form
{
	public static string string_0 = "";

	private IContainer icontainer_0 = null;

	private BunifuCards A13458A7;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button F68BE8B1;

	private Button btnAdd;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private Label label2;

	private TextBox txtPathFolder;

	private Button metroButton1;

	public DA3DAB8C()
	{
		D5A0E08D();
		F7AB102E.D6B70A35(this);
		string_0 = "";
	}

	private void D3AC3989()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(label2);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(F68BE8B1);
	}

	private void F09C8A3E(object sender, EventArgs e)
	{
		Close();
	}

	private void B810D535(object sender, EventArgs e)
	{
		string_0 = txtPathFolder.Text.Trim();
		if (string_0 == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p đươ\u0300ng dâ\u0303n Folder!", 2);
			txtPathFolder.Focus();
		}
		else
		{
			Close();
		}
	}

	private void CC05D38D(object sender, EventArgs e)
	{
		Close();
	}

	private void DA3DAB8C_Load(object sender, EventArgs e)
	{
		string_0 = "";
	}

	private void D0A91796(object sender, EventArgs e)
	{
		string value = GClass8.smethod_40();
		if (!string.IsNullOrEmpty(value))
		{
			txtPathFolder.Text = value;
		}
	}

	protected override void Dispose(bool FA018705)
	{
		if (FA018705 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(FA018705);
	}

	private void D5A0E08D()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DA3DAB8C));
		A13458A7 = new BunifuCards();
		pnlHeader = new Panel();
		pictureBox1 = new PictureBox();
		btnMinimize = new Button();
		bunifuCustomLabel1 = new BunifuCustomLabel();
		F68BE8B1 = new Button();
		btnAdd = new Button();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		label2 = new Label();
		txtPathFolder = new TextBox();
		metroButton1 = new Button();
		A13458A7.SuspendLayout();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		A13458A7.BackColor = Color.White;
		A13458A7.BorderRadius = 0;
		A13458A7.BottomSahddow = true;
		A13458A7.color = Color.SaddleBrown;
		A13458A7.Controls.Add(pnlHeader);
		A13458A7.Dock = DockStyle.Top;
		A13458A7.LeftSahddow = false;
		A13458A7.Location = new Point(0, 0);
		A13458A7.Name = "bunifuCards1";
		A13458A7.RightSahddow = true;
		A13458A7.ShadowDepth = 20;
		A13458A7.Size = new Size(449, 34);
		A13458A7.TabIndex = 0;
		pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(449, 28);
		pnlHeader.TabIndex = 9;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 17;
		pictureBox1.TabStop = false;
		btnMinimize.Cursor = Cursors.Hand;
		btnMinimize.Dock = DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = FlatStyle.Flat;
		btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = Color.White;
		btnMinimize.Image = (Image)componentResourceManager.GetObject("btnMinimize.Image");
		btnMinimize.Location = new Point(417, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new Size(32, 28);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += F09C8A3E;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(449, 28);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Cho\u0323n nơi lưu";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		F68BE8B1.BackColor = Color.Maroon;
		F68BE8B1.Cursor = Cursors.Hand;
		F68BE8B1.FlatAppearance.BorderSize = 0;
		F68BE8B1.FlatStyle = FlatStyle.Flat;
		F68BE8B1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		F68BE8B1.ForeColor = Color.White;
		F68BE8B1.Location = new Point(230, 108);
		F68BE8B1.Name = "btnCancel";
		F68BE8B1.Size = new Size(92, 29);
		F68BE8B1.TabIndex = 4;
		F68BE8B1.Text = "Đo\u0301ng";
		F68BE8B1.UseVisualStyleBackColor = false;
		F68BE8B1.Click += CC05D38D;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(126, 108);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += B810D535;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		label2.AutoSize = true;
		label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label2.Location = new Point(31, 61);
		label2.Name = "label2";
		label2.Size = new Size(146, 16);
		label2.TabIndex = 36;
		label2.Text = "Nhâ\u0323p đươ\u0300ng dâ\u0303n Folder:";
		txtPathFolder.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		txtPathFolder.Location = new Point(184, 58);
		txtPathFolder.Name = "txtPathFolder";
		txtPathFolder.Size = new Size(172, 23);
		txtPathFolder.TabIndex = 35;
		metroButton1.Cursor = Cursors.Hand;
		metroButton1.Location = new Point(362, 57);
		metroButton1.Name = "metroButton1";
		metroButton1.Size = new Size(61, 25);
		metroButton1.TabIndex = 38;
		metroButton1.Text = "Chọn";
		metroButton1.Click += D0A91796;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(449, 159);
		base.Controls.Add(metroButton1);
		base.Controls.Add(label2);
		base.Controls.Add(txtPathFolder);
		base.Controls.Add(F68BE8B1);
		base.Controls.Add(btnAdd);
		base.Controls.Add(A13458A7);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fSelectFolder";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += DA3DAB8C_Load;
		A13458A7.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
