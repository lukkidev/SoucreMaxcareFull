using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fDownloadAvatar : Form
{
	public static bool D60D051A;

	private IContainer icontainer_0 = null;

	private BunifuCards EB99B6AF;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button CD2C8CA0;

	private BunifuDragControl A0AB7383;

	private PictureBox DB27AF16;

	private Button metroButton1;

	private TextBox txtPathFolder;

	private Label D8938F1D;

	private CheckBox ckbUseProxy;

	public fDownloadAvatar()
	{
		B6BCB630();
		F7AB102E.D6B70A35(this);
		D60D051A = false;
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void CD2C8CA0_Click(object sender, EventArgs e)
	{
		GClass25.smethod_0("configGeneral").method_4("pathFolderAvatar", txtPathFolder.Text);
		GClass25.smethod_0("configGeneral").method_4("ckbDownAvatarUseProxy", ckbUseProxy.Checked);
		GClass25.B3B73732("configGeneral");
		D60D051A = true;
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fDownloadAvatar_Load(object sender, EventArgs e)
	{
		txtPathFolder.Text = GClass25.smethod_0("configGeneral").C0288288("pathFolderAvatar");
		ckbUseProxy.Checked = GClass25.smethod_0("configGeneral").method_3("ckbDownAvatarUseProxy");
	}

	private void F58A573D(object sender, EventArgs e)
	{
		string value = GClass8.smethod_40();
		if (!string.IsNullOrEmpty(value))
		{
			txtPathFolder.Text = value;
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

	private void B6BCB630()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fDownloadAvatar));
		EB99B6AF = new BunifuCards();
		pnlHeader = new Panel();
		DB27AF16 = new PictureBox();
		btnMinimize = new Button();
		bunifuCustomLabel1 = new BunifuCustomLabel();
		btnCancel = new Button();
		CD2C8CA0 = new Button();
		A0AB7383 = new BunifuDragControl(icontainer_0);
		metroButton1 = new Button();
		txtPathFolder = new TextBox();
		D8938F1D = new Label();
		ckbUseProxy = new CheckBox();
		EB99B6AF.SuspendLayout();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)DB27AF16).BeginInit();
		SuspendLayout();
		EB99B6AF.BackColor = Color.White;
		EB99B6AF.BorderRadius = 0;
		EB99B6AF.BottomSahddow = true;
		EB99B6AF.color = Color.SaddleBrown;
		EB99B6AF.Controls.Add(pnlHeader);
		EB99B6AF.Dock = DockStyle.Top;
		EB99B6AF.LeftSahddow = false;
		EB99B6AF.Location = new Point(0, 0);
		EB99B6AF.Name = "bunifuCards1";
		EB99B6AF.RightSahddow = true;
		EB99B6AF.ShadowDepth = 20;
		EB99B6AF.Size = new Size(449, 34);
		EB99B6AF.TabIndex = 0;
		pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(DB27AF16);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(449, 28);
		pnlHeader.TabIndex = 9;
		DB27AF16.Cursor = Cursors.Default;
		DB27AF16.Image = C50FB39E.Bitmap_5;
		DB27AF16.Location = new Point(3, 2);
		DB27AF16.Name = "pictureBox1";
		DB27AF16.Size = new Size(34, 27);
		DB27AF16.SizeMode = PictureBoxSizeMode.Zoom;
		DB27AF16.TabIndex = 17;
		DB27AF16.TabStop = false;
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
		btnMinimize.Click += btnMinimize_Click;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(449, 28);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Cấu hình Tải xuống avatar";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(231, 122);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		CD2C8CA0.Anchor = AnchorStyles.Bottom;
		CD2C8CA0.BackColor = Color.FromArgb(53, 120, 229);
		CD2C8CA0.Cursor = Cursors.Hand;
		CD2C8CA0.FlatAppearance.BorderSize = 0;
		CD2C8CA0.FlatStyle = FlatStyle.Flat;
		CD2C8CA0.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		CD2C8CA0.ForeColor = Color.White;
		CD2C8CA0.Location = new Point(127, 122);
		CD2C8CA0.Name = "btnAdd";
		CD2C8CA0.Size = new Size(92, 29);
		CD2C8CA0.TabIndex = 3;
		CD2C8CA0.Text = "Lưu";
		CD2C8CA0.UseVisualStyleBackColor = false;
		CD2C8CA0.Click += CD2C8CA0_Click;
		A0AB7383.Fixed = true;
		A0AB7383.Horizontal = true;
		A0AB7383.TargetControl = bunifuCustomLabel1;
		A0AB7383.Vertical = true;
		metroButton1.Cursor = Cursors.Hand;
		metroButton1.Location = new Point(349, 55);
		metroButton1.Name = "metroButton1";
		metroButton1.Size = new Size(61, 25);
		metroButton1.TabIndex = 37;
		metroButton1.Text = "Chọn";
		metroButton1.Click += F58A573D;
		txtPathFolder.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		txtPathFolder.Location = new Point(147, 56);
		txtPathFolder.Name = "txtPathFolder";
		txtPathFolder.Size = new Size(196, 23);
		txtPathFolder.TabIndex = 35;
		D8938F1D.AutoSize = true;
		D8938F1D.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		D8938F1D.Location = new Point(31, 59);
		D8938F1D.Name = "label1";
		D8938F1D.Size = new Size(93, 16);
		D8938F1D.TabIndex = 36;
		D8938F1D.Text = "Nơi lưu Avatar:";
		ckbUseProxy.AutoSize = true;
		ckbUseProxy.Cursor = Cursors.Hand;
		ckbUseProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ckbUseProxy.Location = new Point(34, 85);
		ckbUseProxy.Name = "ckbUseProxy";
		ckbUseProxy.Size = new Size(281, 20);
		ckbUseProxy.TabIndex = 38;
		ckbUseProxy.Text = "Sử dụng proxy đã gán mỗi tài khoản để chạy";
		ckbUseProxy.UseVisualStyleBackColor = true;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(449, 166);
		base.Controls.Add(ckbUseProxy);
		base.Controls.Add(D8938F1D);
		base.Controls.Add(txtPathFolder);
		base.Controls.Add(metroButton1);
		base.Controls.Add(btnCancel);
		base.Controls.Add(CD2C8CA0);
		base.Controls.Add(EB99B6AF);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fDownloadAvatar";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += fDownloadAvatar_Load;
		EB99B6AF.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)DB27AF16).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
