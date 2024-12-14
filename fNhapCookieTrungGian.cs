using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fNhapCookieTrungGian : Form
{
	public static bool bool_0;

	private IContainer C5295C96 = null;

	private BunifuCards A92453A8;

	private Panel F9299D9D;

	private BunifuCustomLabel A297F70E;

	private Button A49F2588;

	private Button btnCancel;

	private Button A087302F;

	private BunifuDragControl F79422B5;

	private PictureBox pictureBox1;

	private Label A3959534;

	private TextBox B48AF1BC;

	private Button B03C1B07;

	public fNhapCookieTrungGian()
	{
		DF3A8826();
		F7AB102E.D6B70A35(this);
		bool_0 = false;
	}

	private void A8B88C90()
	{
		F7AB102E.smethod_1(A297F70E);
		F7AB102E.smethod_1(A3959534);
		F7AB102E.smethod_1(A3959534);
		F7AB102E.smethod_1(A087302F);
		F7AB102E.smethod_1(btnCancel);
	}

	private void BABB50A4(object sender, EventArgs e)
	{
		Close();
	}

	private void A087302F_Click(object sender, EventArgs e)
	{
		GClass25.smethod_0("configGeneral").method_4("cookie", B48AF1BC.Text);
		GClass25.B3B73732("configGeneral");
		bool_0 = true;
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fNhapCookieTrungGian_Load(object sender, EventArgs e)
	{
		B48AF1BC.Text = GClass25.smethod_0("configGeneral").C0288288("cookie");
	}

	private void B03C1B07_Click(object sender, EventArgs e)
	{
		if (Class14.C5302E20(B48AF1BC.Text, "", "", 0).StartsWith("1|"))
		{
			GClass29.smethod_0("Cookie live!");
		}
		else
		{
			GClass29.smethod_0("Cookie die!");
		}
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && C5295C96 != null)
		{
			C5295C96.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void DF3A8826()
	{
		C5295C96 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fNhapCookieTrungGian));
		A92453A8 = new BunifuCards();
		F9299D9D = new Panel();
		pictureBox1 = new PictureBox();
		A49F2588 = new Button();
		A297F70E = new BunifuCustomLabel();
		btnCancel = new Button();
		A087302F = new Button();
		F79422B5 = new BunifuDragControl(C5295C96);
		A3959534 = new Label();
		B48AF1BC = new TextBox();
		B03C1B07 = new Button();
		A92453A8.SuspendLayout();
		F9299D9D.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		A92453A8.BackColor = Color.White;
		A92453A8.BorderRadius = 0;
		A92453A8.BottomSahddow = true;
		A92453A8.color = Color.SaddleBrown;
		A92453A8.Controls.Add(F9299D9D);
		A92453A8.Dock = DockStyle.Top;
		A92453A8.LeftSahddow = false;
		A92453A8.Location = new Point(0, 0);
		A92453A8.Name = "bunifuCards1";
		A92453A8.RightSahddow = true;
		A92453A8.ShadowDepth = 20;
		A92453A8.Size = new Size(449, 34);
		A92453A8.TabIndex = 0;
		F9299D9D.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		F9299D9D.BackColor = Color.White;
		F9299D9D.Controls.Add(pictureBox1);
		F9299D9D.Controls.Add(A49F2588);
		F9299D9D.Controls.Add(A297F70E);
		F9299D9D.Location = new Point(0, 3);
		F9299D9D.Name = "pnlHeader";
		F9299D9D.Size = new Size(449, 28);
		F9299D9D.TabIndex = 9;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 17;
		pictureBox1.TabStop = false;
		A49F2588.Cursor = Cursors.Hand;
		A49F2588.Dock = DockStyle.Right;
		A49F2588.FlatAppearance.BorderSize = 0;
		A49F2588.FlatStyle = FlatStyle.Flat;
		A49F2588.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		A49F2588.ForeColor = Color.White;
		A49F2588.Image = (Image)componentResourceManager.GetObject("btnMinimize.Image");
		A49F2588.Location = new Point(417, 0);
		A49F2588.Name = "btnMinimize";
		A49F2588.Size = new Size(32, 28);
		A49F2588.TabIndex = 9;
		A49F2588.TextImageRelation = TextImageRelation.ImageBeforeText;
		A49F2588.UseVisualStyleBackColor = true;
		A49F2588.Click += BABB50A4;
		A297F70E.BackColor = Color.Transparent;
		A297F70E.Cursor = Cursors.SizeAll;
		A297F70E.Dock = DockStyle.Fill;
		A297F70E.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		A297F70E.ForeColor = Color.Black;
		A297F70E.Location = new Point(0, 0);
		A297F70E.Name = "bunifuCustomLabel1";
		A297F70E.Size = new Size(449, 28);
		A297F70E.TabIndex = 1;
		A297F70E.Text = "Nhập Cookie trung gian";
		A297F70E.TextAlign = ContentAlignment.MiddleCenter;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(230, 112);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		A087302F.BackColor = Color.FromArgb(53, 120, 229);
		A087302F.Cursor = Cursors.Hand;
		A087302F.FlatAppearance.BorderSize = 0;
		A087302F.FlatStyle = FlatStyle.Flat;
		A087302F.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		A087302F.ForeColor = Color.White;
		A087302F.Location = new Point(126, 112);
		A087302F.Name = "btnAdd";
		A087302F.Size = new Size(92, 29);
		A087302F.TabIndex = 3;
		A087302F.Text = "Lưu";
		A087302F.UseVisualStyleBackColor = false;
		A087302F.Click += A087302F_Click;
		F79422B5.Fixed = true;
		F79422B5.Horizontal = true;
		F79422B5.TargetControl = A297F70E;
		F79422B5.Vertical = true;
		A3959534.AutoSize = true;
		A3959534.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		A3959534.Location = new Point(31, 61);
		A3959534.Name = "label2";
		A3959534.Size = new Size(112, 16);
		A3959534.TabIndex = 36;
		A3959534.Text = "Cookie trung gian:";
		B48AF1BC.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		B48AF1BC.Location = new Point(147, 58);
		B48AF1BC.Name = "txtCookie";
		B48AF1BC.Size = new Size(196, 23);
		B48AF1BC.TabIndex = 35;
		B03C1B07.Cursor = Cursors.Hand;
		B03C1B07.Location = new Point(349, 58);
		B03C1B07.Name = "btnCheckLiveTokenTg";
		B03C1B07.Size = new Size(65, 23);
		B03C1B07.TabIndex = 37;
		B03C1B07.Text = "Kiểm tra";
		B03C1B07.Click += B03C1B07_Click;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(449, 159);
		base.Controls.Add(A3959534);
		base.Controls.Add(B48AF1BC);
		base.Controls.Add(B03C1B07);
		base.Controls.Add(btnCancel);
		base.Controls.Add(A087302F);
		base.Controls.Add(A92453A8);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fNhapCookieTrungGian";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += fNhapCookieTrungGian_Load;
		A92453A8.ResumeLayout(performLayout: false);
		F9299D9D.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
