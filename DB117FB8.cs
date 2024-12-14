using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class DB117FB8 : Form
{
	public static bool E133C7A1;

	private IContainer F1039A89 = null;

	private BunifuCards E4859D12;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button FE2B1230;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private Label F78AB8BC;

	private TextBox txtToken;

	private Button btnCheckLiveTokenTg;

	private Label EE3F8EBB;

	private TextBox txtCookie;

	public DB117FB8()
	{
		FA32E688();
		F7AB102E.D6B70A35(this);
		E133C7A1 = false;
	}

	private void E12CA596(object sender, EventArgs e)
	{
		Close();
	}

	private void FE2B1230_Click(object sender, EventArgs e)
	{
		GClass25.smethod_0("configGeneral").method_4("cookie", txtCookie.Text);
		GClass25.smethod_0("configGeneral").method_4("token", txtToken.Text);
		GClass25.B3B73732("configGeneral");
		E133C7A1 = true;
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DB117FB8_Load(object sender, EventArgs e)
	{
		txtCookie.Text = GClass25.smethod_0("configGeneral").C0288288("cookie");
		txtToken.Text = GClass25.smethod_0("configGeneral").C0288288("token");
	}

	private void AD9B36BD(object sender, EventArgs e)
	{
		string text = "";
		text = (Class14.smethod_6(txtCookie.Text, txtToken.Text, "", "") ? "Live" : ((!Class14.C5302E20(txtCookie.Text, "", "", 0).StartsWith("1|")) ? "Cookie die" : "Token die"));
		GClass29.smethod_0(text + "!");
	}

	protected override void Dispose(bool E78B08BB)
	{
		if (E78B08BB && F1039A89 != null)
		{
			F1039A89.Dispose();
		}
		base.Dispose(E78B08BB);
	}

	private void FA32E688()
	{
		F1039A89 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DB117FB8));
		E4859D12 = new BunifuCards();
		pnlHeader = new Panel();
		pictureBox1 = new PictureBox();
		btnMinimize = new Button();
		bunifuCustomLabel1 = new BunifuCustomLabel();
		btnCancel = new Button();
		FE2B1230 = new Button();
		bunifuDragControl_0 = new BunifuDragControl(F1039A89);
		F78AB8BC = new Label();
		txtToken = new TextBox();
		btnCheckLiveTokenTg = new Button();
		EE3F8EBB = new Label();
		txtCookie = new TextBox();
		E4859D12.SuspendLayout();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		E4859D12.BackColor = Color.White;
		E4859D12.BorderRadius = 0;
		E4859D12.BottomSahddow = true;
		E4859D12.color = Color.SaddleBrown;
		E4859D12.Controls.Add(pnlHeader);
		E4859D12.Dock = DockStyle.Top;
		E4859D12.LeftSahddow = false;
		E4859D12.Location = new Point(0, 0);
		E4859D12.Name = "bunifuCards1";
		E4859D12.RightSahddow = true;
		E4859D12.ShadowDepth = 20;
		E4859D12.Size = new Size(449, 34);
		E4859D12.TabIndex = 0;
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
		btnMinimize.Click += E12CA596;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(449, 28);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Nhập Token trung gian";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(230, 143);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		FE2B1230.Anchor = AnchorStyles.Bottom;
		FE2B1230.BackColor = Color.FromArgb(53, 120, 229);
		FE2B1230.Cursor = Cursors.Hand;
		FE2B1230.FlatAppearance.BorderSize = 0;
		FE2B1230.FlatStyle = FlatStyle.Flat;
		FE2B1230.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		FE2B1230.ForeColor = Color.White;
		FE2B1230.Location = new Point(126, 143);
		FE2B1230.Name = "btnAdd";
		FE2B1230.Size = new Size(92, 29);
		FE2B1230.TabIndex = 3;
		FE2B1230.Text = "Lưu";
		FE2B1230.UseVisualStyleBackColor = false;
		FE2B1230.Click += FE2B1230_Click;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		F78AB8BC.AutoSize = true;
		F78AB8BC.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		F78AB8BC.Location = new Point(26, 95);
		F78AB8BC.Name = "label2";
		F78AB8BC.Size = new Size(109, 16);
		F78AB8BC.TabIndex = 36;
		F78AB8BC.Text = "Token trung gian:";
		txtToken.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		txtToken.Location = new Point(142, 92);
		txtToken.Name = "txtToken";
		txtToken.Size = new Size(196, 23);
		txtToken.TabIndex = 35;
		btnCheckLiveTokenTg.Cursor = Cursors.Hand;
		btnCheckLiveTokenTg.Location = new Point(344, 62);
		btnCheckLiveTokenTg.Name = "btnCheckLiveTokenTg";
		btnCheckLiveTokenTg.Size = new Size(65, 54);
		btnCheckLiveTokenTg.TabIndex = 37;
		btnCheckLiveTokenTg.Text = "Kiểm tra";
		btnCheckLiveTokenTg.Click += AD9B36BD;
		EE3F8EBB.AutoSize = true;
		EE3F8EBB.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		EE3F8EBB.Location = new Point(26, 66);
		EE3F8EBB.Name = "label1";
		EE3F8EBB.Size = new Size(112, 16);
		EE3F8EBB.TabIndex = 39;
		EE3F8EBB.Text = "Cookie trung gian:";
		txtCookie.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		txtCookie.Location = new Point(142, 63);
		txtCookie.Name = "txtCookie";
		txtCookie.Size = new Size(196, 23);
		txtCookie.TabIndex = 38;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(449, 190);
		base.Controls.Add(EE3F8EBB);
		base.Controls.Add(txtCookie);
		base.Controls.Add(F78AB8BC);
		base.Controls.Add(txtToken);
		base.Controls.Add(btnCheckLiveTokenTg);
		base.Controls.Add(btnCancel);
		base.Controls.Add(FE2B1230);
		base.Controls.Add(E4859D12);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fNhapTokenTrungGian";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += DB117FB8_Load;
		E4859D12.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
