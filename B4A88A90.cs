using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class B4A88A90 : Form
{
	private IContainer icontainer_0 = null;

	private BunifuCards C1B16DA1;

	private Panel pnlHeader;

	private BunifuCustomLabel DA263D3B;

	private Button btnMinimize;

	private Button C62F6B29;

	private Button btnAdd;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuCustomLabel lblStatus;

	private PictureBox pictureBox1;

	private CheckBox ckbToken;

	private CheckBox A4310F1C;

	private CheckBox B68FF2B1;

	private CheckBox D21FD527;

	private CheckBox ckbBanBe;

	private CheckBox FF9B2333;

	private CheckBox ckbNgaySinh;

	private CheckBox ckbGioiTinh;

	private CheckBox ckbMatKhau;

	private CheckBox ckbMatKhauMail;

	private CheckBox DD310910;

	private CheckBox ckbMa2FA;

	private CheckBox ckbUseragent;

	private CheckBox ADAC5D2C;

	private CheckBox ckbNgayTao;

	private CheckBox ckbAvatar;

	private CheckBox ckbProfile;

	private CheckBox ckbTinhTrang;

	private CheckBox ckbGhiChu;

	private CheckBox ckbThuMuc;

	private CheckBox ckbFollow;

	private CheckBox ckbInteractEnd;

	private CheckBox ckbMailRecovery;

	private CheckBox ckbPhone;

	private CheckBox D694D49E;

	private CheckBox ckbDating;

	private CheckBox E3BD74B6;

	private CheckBox ckbBM;

	private CheckBox ckbHometown;

	private CheckBox CA057925;

	private CheckBox ckbWallPosts;

	private CheckBox ckbFbBlock;

	private CheckBox ckbJob;

	private CheckBox ckbStatus282;

	private CheckBox ckbEmailFull;

	private CheckBox ckbKichBan;

	private Button button1;

	private CheckBox ckbPassMailRecovery;

	private CheckBox D687CEB2;

	public B4A88A90()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
	}

	private void AD820C02(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			ckbKichBan.Visible = true;
		}
		else
		{
			Close();
		}
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		GClass25.smethod_0("configDatagridview").method_4("cToken", ckbToken.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbCookie", A4310F1C.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbEmail", B68FF2B1.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbEmailFull", ckbEmailFull.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbTen", D21FD527.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbBanBe", ckbBanBe.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbNhom", FF9B2333.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbPagePro5", D687CEB2.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbNgaySinh", ckbNgaySinh.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbGioiTinh", ckbGioiTinh.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbMatKhau", ckbMatKhau.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbMatKhauMail", ckbMatKhauMail.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbOAuth2", DD310910.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbMa2FA", ckbMa2FA.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbUseragent", ckbUseragent.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbProxy", ADAC5D2C.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbNgayTao", ckbNgayTao.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbAvatar", ckbAvatar.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbProfile", ckbProfile.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbTinhTrang", ckbTinhTrang.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbThuMuc", ckbThuMuc.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbGhiChu", ckbGhiChu.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbStatus282", ckbStatus282.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbFollow", ckbFollow.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbInteractEnd", ckbInteractEnd.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbMailRecovery", ckbMailRecovery.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbPassMailRecovery", ckbPassMailRecovery.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbPhone", ckbPhone.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbHometown", ckbHometown.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbLocation", D694D49E.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbCurrentCity", CA057925.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbJob", ckbJob.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbDating", ckbDating.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbAds", E3BD74B6.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbBM", ckbBM.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbWallPosts", ckbWallPosts.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbFbBlock", ckbFbBlock.Checked);
		GClass25.smethod_0("configDatagridview").method_4("ckbKichBan", ckbKichBan.Checked);
		if (ckbMa2FA.Checked && !Class57.smethod_3())
		{
			GClass25.smethod_0("configDatagridview").method_4("ckbMa2FA", false);
		}
		GClass25.B3B73732("configDatagridview");
		Close();
	}

	private void C62F6B29_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void lblStatus_Click(object sender, EventArgs e)
	{
	}

	private void B4A88A90_Load(object sender, EventArgs e)
	{
		ckbToken.Checked = GClass25.smethod_0("configDatagridview").method_3("cToken");
		A4310F1C.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbCookie");
		B68FF2B1.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbEmail");
		ckbEmailFull.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbEmailFull");
		D21FD527.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbTen");
		ckbBanBe.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbBanBe");
		FF9B2333.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbNhom");
		D687CEB2.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbPagePro5");
		ckbNgaySinh.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbNgaySinh");
		ckbGioiTinh.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbGioiTinh");
		ckbMatKhau.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbMatKhau");
		ckbMatKhauMail.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbMatKhauMail");
		DD310910.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbOAuth2");
		ckbMa2FA.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbMa2FA");
		ckbUseragent.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbUseragent");
		ADAC5D2C.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbProxy");
		ckbNgayTao.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbNgayTao");
		ckbAvatar.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbAvatar");
		ckbProfile.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbProfile");
		ckbTinhTrang.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbTinhTrang");
		ckbThuMuc.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbThuMuc");
		ckbGhiChu.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbGhiChu");
		ckbStatus282.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbStatus282");
		ckbFollow.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbFollow");
		ckbInteractEnd.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbInteractEnd");
		ckbMailRecovery.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbMailRecovery");
		ckbPassMailRecovery.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbPassMailRecovery");
		ckbPhone.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbPhone");
		ckbHometown.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbHometown");
		D694D49E.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbLocation");
		CA057925.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbCurrentCity");
		ckbJob.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbJob");
		ckbDating.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbDating");
		E3BD74B6.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbAds");
		ckbBM.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbBM");
		ckbWallPosts.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbWallPosts");
		ckbFbBlock.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbFbBlock");
		ckbKichBan.Checked = GClass25.smethod_0("configDatagridview").method_3("ckbKichBan");
		B68FF2B1_CheckedChanged(null, null);
	}

	private void B68FF2B1_CheckedChanged(object sender, EventArgs e)
	{
		if (!B68FF2B1.Checked)
		{
			ckbEmailFull.Enabled = false;
			ckbEmailFull.Checked = false;
		}
		else
		{
			ckbEmailFull.Enabled = true;
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		List<string> list = new List<string> { "ckbMatKhau", "ckbTen", "ckbProxy", "ckbInteractEnd", "ckbTinhTrang", "ckbThuMuc", "ckbEmail" };
		List<CheckBox> list2 = base.Controls.OfType<CheckBox>().ToList();
		foreach (CheckBox item in list2)
		{
			item.Checked = list.Contains(item.Name);
		}
	}

	protected override void Dispose(bool FF8AA8BD)
	{
		if (FF8AA8BD && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(FF8AA8BD);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B4A88A90));
		C1B16DA1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		DA263D3B = new Bunifu.Framework.UI.BunifuCustomLabel();
		C62F6B29 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		lblStatus = new Bunifu.Framework.UI.BunifuCustomLabel();
		ckbToken = new System.Windows.Forms.CheckBox();
		A4310F1C = new System.Windows.Forms.CheckBox();
		B68FF2B1 = new System.Windows.Forms.CheckBox();
		D21FD527 = new System.Windows.Forms.CheckBox();
		ckbBanBe = new System.Windows.Forms.CheckBox();
		FF9B2333 = new System.Windows.Forms.CheckBox();
		ckbNgaySinh = new System.Windows.Forms.CheckBox();
		ckbGioiTinh = new System.Windows.Forms.CheckBox();
		ckbMatKhau = new System.Windows.Forms.CheckBox();
		ckbMatKhauMail = new System.Windows.Forms.CheckBox();
		DD310910 = new System.Windows.Forms.CheckBox();
		ckbMa2FA = new System.Windows.Forms.CheckBox();
		ckbUseragent = new System.Windows.Forms.CheckBox();
		ADAC5D2C = new System.Windows.Forms.CheckBox();
		ckbNgayTao = new System.Windows.Forms.CheckBox();
		ckbAvatar = new System.Windows.Forms.CheckBox();
		ckbProfile = new System.Windows.Forms.CheckBox();
		ckbTinhTrang = new System.Windows.Forms.CheckBox();
		ckbGhiChu = new System.Windows.Forms.CheckBox();
		ckbThuMuc = new System.Windows.Forms.CheckBox();
		ckbFollow = new System.Windows.Forms.CheckBox();
		ckbInteractEnd = new System.Windows.Forms.CheckBox();
		ckbMailRecovery = new System.Windows.Forms.CheckBox();
		ckbPhone = new System.Windows.Forms.CheckBox();
		D694D49E = new System.Windows.Forms.CheckBox();
		ckbDating = new System.Windows.Forms.CheckBox();
		E3BD74B6 = new System.Windows.Forms.CheckBox();
		ckbBM = new System.Windows.Forms.CheckBox();
		ckbHometown = new System.Windows.Forms.CheckBox();
		CA057925 = new System.Windows.Forms.CheckBox();
		ckbWallPosts = new System.Windows.Forms.CheckBox();
		ckbFbBlock = new System.Windows.Forms.CheckBox();
		ckbJob = new System.Windows.Forms.CheckBox();
		ckbStatus282 = new System.Windows.Forms.CheckBox();
		ckbEmailFull = new System.Windows.Forms.CheckBox();
		ckbKichBan = new System.Windows.Forms.CheckBox();
		button1 = new System.Windows.Forms.Button();
		ckbPassMailRecovery = new System.Windows.Forms.CheckBox();
		D687CEB2 = new System.Windows.Forms.CheckBox();
		C1B16DA1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		C1B16DA1.BackColor = System.Drawing.Color.White;
		C1B16DA1.BorderRadius = 0;
		C1B16DA1.BottomSahddow = true;
		C1B16DA1.color = System.Drawing.Color.SaddleBrown;
		C1B16DA1.Controls.Add(pnlHeader);
		C1B16DA1.Dock = System.Windows.Forms.DockStyle.Top;
		C1B16DA1.LeftSahddow = false;
		C1B16DA1.Location = new System.Drawing.Point(0, 0);
		C1B16DA1.Name = "bunifuCards1";
		C1B16DA1.RightSahddow = true;
		C1B16DA1.ShadowDepth = 20;
		C1B16DA1.Size = new System.Drawing.Size(613, 38);
		C1B16DA1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(DA263D3B);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(613, 32);
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
		btnMinimize.Location = new System.Drawing.Point(581, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(AD820C02);
		DA263D3B.BackColor = System.Drawing.Color.Transparent;
		DA263D3B.Cursor = System.Windows.Forms.Cursors.SizeAll;
		DA263D3B.Dock = System.Windows.Forms.DockStyle.Fill;
		DA263D3B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DA263D3B.ForeColor = System.Drawing.Color.Black;
		DA263D3B.Location = new System.Drawing.Point(0, 0);
		DA263D3B.Name = "bunifuCustomLabel1";
		DA263D3B.Size = new System.Drawing.Size(613, 32);
		DA263D3B.TabIndex = 1;
		DA263D3B.Text = "Câ\u0301u hi\u0300nh hiê\u0309n thi\u0323";
		DA263D3B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C62F6B29.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		C62F6B29.BackColor = System.Drawing.Color.Maroon;
		C62F6B29.Cursor = System.Windows.Forms.Cursors.Hand;
		C62F6B29.FlatAppearance.BorderSize = 0;
		C62F6B29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C62F6B29.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C62F6B29.ForeColor = System.Drawing.Color.White;
		C62F6B29.Location = new System.Drawing.Point(369, 294);
		C62F6B29.Name = "btnCancel";
		C62F6B29.Size = new System.Drawing.Size(92, 29);
		C62F6B29.TabIndex = 4;
		C62F6B29.Text = "Đo\u0301ng";
		C62F6B29.UseVisualStyleBackColor = false;
		C62F6B29.Click += new System.EventHandler(C62F6B29_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(265, 294);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = DA263D3B;
		bunifuDragControl_0.Vertical = true;
		lblStatus.BackColor = System.Drawing.Color.Transparent;
		lblStatus.Cursor = System.Windows.Forms.Cursors.SizeAll;
		lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblStatus.ForeColor = System.Drawing.Color.Black;
		lblStatus.Location = new System.Drawing.Point(51, 41);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(384, 32);
		lblStatus.TabIndex = 21;
		lblStatus.Text = "Vui lo\u0300ng cho\u0323n như\u0303ng cô\u0323t câ\u0300n hiê\u0309n thi\u0323!";
		lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		lblStatus.Click += new System.EventHandler(lblStatus_Click);
		ckbToken.AutoSize = true;
		ckbToken.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbToken.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbToken.Location = new System.Drawing.Point(31, 137);
		ckbToken.Name = "ckbToken";
		ckbToken.Size = new System.Drawing.Size(61, 20);
		ckbToken.TabIndex = 22;
		ckbToken.Text = "Token";
		ckbToken.UseVisualStyleBackColor = true;
		A4310F1C.AutoSize = true;
		A4310F1C.Cursor = System.Windows.Forms.Cursors.Hand;
		A4310F1C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A4310F1C.Location = new System.Drawing.Point(31, 163);
		A4310F1C.Name = "ckbCookie";
		A4310F1C.Size = new System.Drawing.Size(64, 20);
		A4310F1C.TabIndex = 22;
		A4310F1C.Text = "Cookie";
		A4310F1C.UseVisualStyleBackColor = true;
		B68FF2B1.AutoSize = true;
		B68FF2B1.Cursor = System.Windows.Forms.Cursors.Hand;
		B68FF2B1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B68FF2B1.Location = new System.Drawing.Point(31, 189);
		B68FF2B1.Name = "ckbEmail";
		B68FF2B1.Size = new System.Drawing.Size(57, 20);
		B68FF2B1.TabIndex = 22;
		B68FF2B1.Text = "Email";
		B68FF2B1.UseVisualStyleBackColor = true;
		B68FF2B1.CheckedChanged += new System.EventHandler(B68FF2B1_CheckedChanged);
		D21FD527.AutoSize = true;
		D21FD527.Cursor = System.Windows.Forms.Cursors.Hand;
		D21FD527.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D21FD527.Location = new System.Drawing.Point(158, 85);
		D21FD527.Name = "ckbTen";
		D21FD527.Size = new System.Drawing.Size(48, 20);
		D21FD527.TabIndex = 22;
		D21FD527.Text = "Tên";
		D21FD527.UseVisualStyleBackColor = true;
		ckbBanBe.AutoSize = true;
		ckbBanBe.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbBanBe.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbBanBe.Location = new System.Drawing.Point(158, 137);
		ckbBanBe.Name = "ckbBanBe";
		ckbBanBe.Size = new System.Drawing.Size(65, 20);
		ckbBanBe.TabIndex = 22;
		ckbBanBe.Text = "Ba\u0323n be\u0300";
		ckbBanBe.UseVisualStyleBackColor = true;
		FF9B2333.AutoSize = true;
		FF9B2333.Cursor = System.Windows.Forms.Cursors.Hand;
		FF9B2333.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		FF9B2333.Location = new System.Drawing.Point(158, 163);
		FF9B2333.Name = "ckbNhom";
		FF9B2333.Size = new System.Drawing.Size(59, 20);
		FF9B2333.TabIndex = 22;
		FF9B2333.Text = "Nho\u0301m";
		FF9B2333.UseVisualStyleBackColor = true;
		ckbNgaySinh.AutoSize = true;
		ckbNgaySinh.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbNgaySinh.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbNgaySinh.Location = new System.Drawing.Point(265, 85);
		ckbNgaySinh.Name = "ckbNgaySinh";
		ckbNgaySinh.Size = new System.Drawing.Size(81, 20);
		ckbNgaySinh.TabIndex = 22;
		ckbNgaySinh.Text = "Nga\u0300y sinh";
		ckbNgaySinh.UseVisualStyleBackColor = true;
		ckbGioiTinh.AutoSize = true;
		ckbGioiTinh.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbGioiTinh.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbGioiTinh.Location = new System.Drawing.Point(265, 137);
		ckbGioiTinh.Name = "ckbGioiTinh";
		ckbGioiTinh.Size = new System.Drawing.Size(72, 20);
		ckbGioiTinh.TabIndex = 22;
		ckbGioiTinh.Text = "Giơ\u0301i ti\u0301nh";
		ckbGioiTinh.UseVisualStyleBackColor = true;
		ckbMatKhau.AutoSize = true;
		ckbMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbMatKhau.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbMatKhau.Location = new System.Drawing.Point(31, 85);
		ckbMatKhau.Name = "ckbMatKhau";
		ckbMatKhau.Size = new System.Drawing.Size(78, 20);
		ckbMatKhau.TabIndex = 22;
		ckbMatKhau.Text = "Mâ\u0323t khâ\u0309u";
		ckbMatKhau.UseVisualStyleBackColor = true;
		ckbMatKhauMail.AutoSize = true;
		ckbMatKhauMail.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbMatKhauMail.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbMatKhauMail.Location = new System.Drawing.Point(31, 215);
		ckbMatKhauMail.Name = "ckbMatKhauMail";
		ckbMatKhauMail.Size = new System.Drawing.Size(106, 20);
		ckbMatKhauMail.TabIndex = 22;
		ckbMatKhauMail.Text = "Mâ\u0323t khâ\u0309u mail";
		ckbMatKhauMail.UseVisualStyleBackColor = true;
		DD310910.AutoSize = true;
		DD310910.Cursor = System.Windows.Forms.Cursors.Hand;
		DD310910.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		DD310910.Location = new System.Drawing.Point(158, 215);
		DD310910.Name = "ckbOAuth2";
		DD310910.Size = new System.Drawing.Size(68, 20);
		DD310910.TabIndex = 22;
		DD310910.Text = "OAuth2";
		DD310910.UseVisualStyleBackColor = true;
		ckbMa2FA.AutoSize = true;
		ckbMa2FA.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbMa2FA.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbMa2FA.Location = new System.Drawing.Point(31, 111);
		ckbMa2FA.Name = "ckbMa2FA";
		ckbMa2FA.Size = new System.Drawing.Size(69, 20);
		ckbMa2FA.TabIndex = 22;
		ckbMa2FA.Text = "Ma\u0303 2FA";
		ckbMa2FA.UseVisualStyleBackColor = true;
		ckbUseragent.AutoSize = true;
		ckbUseragent.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbUseragent.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbUseragent.Location = new System.Drawing.Point(265, 163);
		ckbUseragent.Name = "ckbUseragent";
		ckbUseragent.Size = new System.Drawing.Size(84, 20);
		ckbUseragent.TabIndex = 22;
		ckbUseragent.Text = "Useragent";
		ckbUseragent.UseVisualStyleBackColor = true;
		ADAC5D2C.AutoSize = true;
		ADAC5D2C.Cursor = System.Windows.Forms.Cursors.Hand;
		ADAC5D2C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ADAC5D2C.Location = new System.Drawing.Point(265, 189);
		ADAC5D2C.Name = "ckbProxy";
		ADAC5D2C.Size = new System.Drawing.Size(57, 20);
		ADAC5D2C.TabIndex = 22;
		ADAC5D2C.Text = "Proxy";
		ADAC5D2C.UseVisualStyleBackColor = true;
		ckbNgayTao.AutoSize = true;
		ckbNgayTao.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbNgayTao.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbNgayTao.Location = new System.Drawing.Point(265, 215);
		ckbNgayTao.Name = "ckbNgayTao";
		ckbNgayTao.Size = new System.Drawing.Size(76, 20);
		ckbNgayTao.TabIndex = 22;
		ckbNgayTao.Text = "Nga\u0300y ta\u0323o";
		ckbNgayTao.UseVisualStyleBackColor = true;
		ckbAvatar.AutoSize = true;
		ckbAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAvatar.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbAvatar.Location = new System.Drawing.Point(265, 241);
		ckbAvatar.Name = "ckbAvatar";
		ckbAvatar.Size = new System.Drawing.Size(63, 20);
		ckbAvatar.TabIndex = 22;
		ckbAvatar.Text = "Avatar";
		ckbAvatar.UseVisualStyleBackColor = true;
		ckbProfile.AutoSize = true;
		ckbProfile.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbProfile.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbProfile.Location = new System.Drawing.Point(373, 85);
		ckbProfile.Name = "ckbProfile";
		ckbProfile.Size = new System.Drawing.Size(62, 20);
		ckbProfile.TabIndex = 22;
		ckbProfile.Text = "Profile";
		ckbProfile.UseVisualStyleBackColor = true;
		ckbTinhTrang.AutoSize = true;
		ckbTinhTrang.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTinhTrang.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbTinhTrang.Location = new System.Drawing.Point(373, 137);
		ckbTinhTrang.Name = "ckbTinhTrang";
		ckbTinhTrang.Size = new System.Drawing.Size(85, 20);
		ckbTinhTrang.TabIndex = 22;
		ckbTinhTrang.Text = "Ti\u0300nh tra\u0323ng";
		ckbTinhTrang.UseVisualStyleBackColor = true;
		ckbGhiChu.AutoSize = true;
		ckbGhiChu.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbGhiChu.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbGhiChu.Location = new System.Drawing.Point(373, 189);
		ckbGhiChu.Name = "ckbGhiChu";
		ckbGhiChu.Size = new System.Drawing.Size(68, 20);
		ckbGhiChu.TabIndex = 22;
		ckbGhiChu.Text = "Ghi chú";
		ckbGhiChu.UseVisualStyleBackColor = true;
		ckbThuMuc.AutoSize = true;
		ckbThuMuc.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbThuMuc.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbThuMuc.Location = new System.Drawing.Point(373, 163);
		ckbThuMuc.Name = "ckbThuMuc";
		ckbThuMuc.Size = new System.Drawing.Size(77, 20);
		ckbThuMuc.TabIndex = 22;
		ckbThuMuc.Text = "Thư mục";
		ckbThuMuc.UseVisualStyleBackColor = true;
		ckbFollow.AutoSize = true;
		ckbFollow.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbFollow.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbFollow.Location = new System.Drawing.Point(158, 111);
		ckbFollow.Name = "ckbFollow";
		ckbFollow.Size = new System.Drawing.Size(76, 20);
		ckbFollow.TabIndex = 22;
		ckbFollow.Text = "Theo do\u0303i";
		ckbFollow.UseVisualStyleBackColor = true;
		ckbInteractEnd.AutoSize = true;
		ckbInteractEnd.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteractEnd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbInteractEnd.Location = new System.Drawing.Point(373, 111);
		ckbInteractEnd.Name = "ckbInteractEnd";
		ckbInteractEnd.Size = new System.Drawing.Size(111, 20);
		ckbInteractEnd.TabIndex = 22;
		ckbInteractEnd.Text = "Tương ta\u0301c cuô\u0301i";
		ckbInteractEnd.UseVisualStyleBackColor = true;
		ckbMailRecovery.AutoSize = true;
		ckbMailRecovery.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbMailRecovery.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbMailRecovery.Location = new System.Drawing.Point(30, 241);
		ckbMailRecovery.Name = "ckbMailRecovery";
		ckbMailRecovery.Size = new System.Drawing.Size(107, 20);
		ckbMailRecovery.TabIndex = 22;
		ckbMailRecovery.Text = "Mail khôi phục";
		ckbMailRecovery.UseVisualStyleBackColor = true;
		ckbPhone.AutoSize = true;
		ckbPhone.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbPhone.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbPhone.Location = new System.Drawing.Point(265, 111);
		ckbPhone.Name = "ckbPhone";
		ckbPhone.Size = new System.Drawing.Size(61, 20);
		ckbPhone.TabIndex = 22;
		ckbPhone.Text = "Phone";
		ckbPhone.UseVisualStyleBackColor = true;
		D694D49E.AutoSize = true;
		D694D49E.Cursor = System.Windows.Forms.Cursors.Hand;
		D694D49E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D694D49E.Location = new System.Drawing.Point(496, 111);
		D694D49E.Name = "ckbLocation";
		D694D49E.Size = new System.Drawing.Size(73, 20);
		D694D49E.TabIndex = 22;
		D694D49E.Text = "Location";
		D694D49E.UseVisualStyleBackColor = true;
		ckbDating.AutoSize = true;
		ckbDating.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbDating.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbDating.Location = new System.Drawing.Point(373, 215);
		ckbDating.Name = "ckbDating";
		ckbDating.Size = new System.Drawing.Size(62, 20);
		ckbDating.TabIndex = 22;
		ckbDating.Text = "Dating";
		ckbDating.UseVisualStyleBackColor = true;
		E3BD74B6.AutoSize = true;
		E3BD74B6.Cursor = System.Windows.Forms.Cursors.Hand;
		E3BD74B6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		E3BD74B6.Location = new System.Drawing.Point(496, 85);
		E3BD74B6.Name = "ckbAds";
		E3BD74B6.Size = new System.Drawing.Size(47, 20);
		E3BD74B6.TabIndex = 22;
		E3BD74B6.Text = "Ads";
		E3BD74B6.UseVisualStyleBackColor = true;
		ckbBM.AutoSize = true;
		ckbBM.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbBM.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbBM.Location = new System.Drawing.Point(547, 85);
		ckbBM.Name = "ckbBM";
		ckbBM.Size = new System.Drawing.Size(43, 20);
		ckbBM.TabIndex = 22;
		ckbBM.Text = "BM";
		ckbBM.UseVisualStyleBackColor = true;
		ckbHometown.AutoSize = true;
		ckbHometown.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHometown.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbHometown.Location = new System.Drawing.Point(496, 137);
		ckbHometown.Name = "ckbHometown";
		ckbHometown.Size = new System.Drawing.Size(87, 20);
		ckbHometown.TabIndex = 22;
		ckbHometown.Text = "Hometown";
		ckbHometown.UseVisualStyleBackColor = true;
		CA057925.AutoSize = true;
		CA057925.Cursor = System.Windows.Forms.Cursors.Hand;
		CA057925.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		CA057925.Location = new System.Drawing.Point(496, 163);
		CA057925.Name = "ckbCurrentCity";
		CA057925.Size = new System.Drawing.Size(94, 20);
		CA057925.TabIndex = 22;
		CA057925.Text = "Current City";
		CA057925.UseVisualStyleBackColor = true;
		ckbWallPosts.AutoSize = true;
		ckbWallPosts.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbWallPosts.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbWallPosts.Location = new System.Drawing.Point(496, 241);
		ckbWallPosts.Name = "ckbWallPosts";
		ckbWallPosts.Size = new System.Drawing.Size(85, 20);
		ckbWallPosts.TabIndex = 22;
		ckbWallPosts.Text = "Wall posts";
		ckbWallPosts.UseVisualStyleBackColor = true;
		ckbFbBlock.AutoSize = true;
		ckbFbBlock.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbFbBlock.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbFbBlock.Location = new System.Drawing.Point(496, 215);
		ckbFbBlock.Name = "ckbFbBlock";
		ckbFbBlock.Size = new System.Drawing.Size(73, 20);
		ckbFbBlock.TabIndex = 22;
		ckbFbBlock.Text = "Fb Block";
		ckbFbBlock.UseVisualStyleBackColor = true;
		ckbJob.AutoSize = true;
		ckbJob.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbJob.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbJob.Location = new System.Drawing.Point(496, 189);
		ckbJob.Name = "ckbJob";
		ckbJob.Size = new System.Drawing.Size(45, 20);
		ckbJob.TabIndex = 22;
		ckbJob.Text = "Job";
		ckbJob.UseVisualStyleBackColor = true;
		ckbStatus282.AutoSize = true;
		ckbStatus282.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbStatus282.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbStatus282.Location = new System.Drawing.Point(373, 241);
		ckbStatus282.Name = "ckbStatus282";
		ckbStatus282.Size = new System.Drawing.Size(87, 20);
		ckbStatus282.TabIndex = 22;
		ckbStatus282.Text = "Status 282";
		ckbStatus282.UseVisualStyleBackColor = true;
		ckbEmailFull.AutoSize = true;
		ckbEmailFull.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbEmailFull.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbEmailFull.Location = new System.Drawing.Point(85, 189);
		ckbEmailFull.Name = "ckbEmailFull";
		ckbEmailFull.Size = new System.Drawing.Size(46, 20);
		ckbEmailFull.TabIndex = 22;
		ckbEmailFull.Text = "Full";
		ckbEmailFull.UseVisualStyleBackColor = true;
		ckbKichBan.AutoSize = true;
		ckbKichBan.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbKichBan.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbKichBan.Location = new System.Drawing.Point(496, 376);
		ckbKichBan.Name = "ckbKichBan";
		ckbKichBan.Size = new System.Drawing.Size(74, 20);
		ckbKichBan.TabIndex = 22;
		ckbKichBan.Text = "Kịch bản";
		ckbKichBan.UseVisualStyleBackColor = true;
		ckbKichBan.Visible = false;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		button1.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Location = new System.Drawing.Point(133, 294);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(119, 29);
		button1.TabIndex = 3;
		button1.Text = "Hiê\u0309n thi\u0323 tô\u0301i ưu";
		button1.UseVisualStyleBackColor = false;
		button1.Click += new System.EventHandler(button1_Click);
		ckbPassMailRecovery.AutoSize = true;
		ckbPassMailRecovery.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbPassMailRecovery.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbPassMailRecovery.Location = new System.Drawing.Point(30, 267);
		ckbPassMailRecovery.Name = "ckbPassMailRecovery";
		ckbPassMailRecovery.Size = new System.Drawing.Size(138, 20);
		ckbPassMailRecovery.TabIndex = 23;
		ckbPassMailRecovery.Text = "Pass mail khôi phu\u0323c";
		ckbPassMailRecovery.UseVisualStyleBackColor = true;
		D687CEB2.AutoSize = true;
		D687CEB2.Cursor = System.Windows.Forms.Cursors.Hand;
		D687CEB2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D687CEB2.Location = new System.Drawing.Point(158, 189);
		D687CEB2.Name = "ckbPagePro5";
		D687CEB2.Size = new System.Drawing.Size(54, 20);
		D687CEB2.TabIndex = 22;
		D687CEB2.Text = "Page";
		D687CEB2.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(613, 335);
		base.Controls.Add(ckbPassMailRecovery);
		base.Controls.Add(ckbNgaySinh);
		base.Controls.Add(ckbThuMuc);
		base.Controls.Add(ckbPhone);
		base.Controls.Add(ckbBM);
		base.Controls.Add(E3BD74B6);
		base.Controls.Add(ckbDating);
		base.Controls.Add(ckbFbBlock);
		base.Controls.Add(ckbKichBan);
		base.Controls.Add(ckbWallPosts);
		base.Controls.Add(ckbJob);
		base.Controls.Add(CA057925);
		base.Controls.Add(ckbHometown);
		base.Controls.Add(D694D49E);
		base.Controls.Add(ckbMailRecovery);
		base.Controls.Add(ckbStatus282);
		base.Controls.Add(ckbGhiChu);
		base.Controls.Add(ckbInteractEnd);
		base.Controls.Add(ckbTinhTrang);
		base.Controls.Add(ckbProfile);
		base.Controls.Add(ckbAvatar);
		base.Controls.Add(ckbNgayTao);
		base.Controls.Add(ADAC5D2C);
		base.Controls.Add(ckbUseragent);
		base.Controls.Add(ckbMa2FA);
		base.Controls.Add(DD310910);
		base.Controls.Add(ckbMatKhauMail);
		base.Controls.Add(ckbMatKhau);
		base.Controls.Add(ckbGioiTinh);
		base.Controls.Add(D687CEB2);
		base.Controls.Add(FF9B2333);
		base.Controls.Add(ckbFollow);
		base.Controls.Add(ckbBanBe);
		base.Controls.Add(D21FD527);
		base.Controls.Add(ckbEmailFull);
		base.Controls.Add(B68FF2B1);
		base.Controls.Add(A4310F1C);
		base.Controls.Add(ckbToken);
		base.Controls.Add(lblStatus);
		base.Controls.Add(C62F6B29);
		base.Controls.Add(button1);
		base.Controls.Add(btnAdd);
		base.Controls.Add(C1B16DA1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhHienThi";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(B4A88A90_Load);
		C1B16DA1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
