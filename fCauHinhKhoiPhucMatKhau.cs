using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhKhoiPhucMatKhau : Form
{
	public static bool bool_0;

	private IContainer CE181CA3 = null;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl D19F7E08;

	private RadioButton C0161D2B;

	private RadioButton rbPassTuDat;

	private TextBox A13FBE24;

	private BunifuCards bunifuCards1;

	private Button btnClose;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel A09F14BD;

	private CheckBox CA0D7AB2;

	private CheckBox EA9E391B;

	private CheckBox ckbQuenMatKhauByChrome;

	public fCauHinhKhoiPhucMatKhau()
	{
		EE9C7300();
		F7AB102E.D6B70A35(this);
		bool_0 = false;
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		int num = 0;
		if (C0161D2B.Checked)
		{
			num = 1;
		}
		GClass25.smethod_0("configGeneral").method_4("typePass", num);
		GClass25.smethod_0("configGeneral").method_4("txtPass", A13FBE24.Text.Trim());
		GClass25.smethod_0("configGeneral").method_4("ckbKillSession", EA9E391B.Checked);
		GClass25.smethod_0("configGeneral").method_4("ckbKhongSuDungProfile", CA0D7AB2.Checked);
		GClass25.smethod_0("configGeneral").method_4("ckbQuenMatKhauByChrome", ckbQuenMatKhauByChrome.Checked);
		GClass25.B3B73732("configGeneral");
		bool_0 = true;
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fCauHinhKhoiPhucMatKhau_Load(object sender, EventArgs e)
	{
		if (GClass25.smethod_0("configGeneral").method_2("typePass") == 0)
		{
			rbPassTuDat.Checked = true;
		}
		else
		{
			C0161D2B.Checked = true;
		}
		A13FBE24.Text = GClass25.smethod_0("configGeneral").C0288288("txtPass");
		EA9E391B.Checked = GClass25.smethod_0("configGeneral").method_3("ckbKillSession");
		CA0D7AB2.Checked = GClass25.smethod_0("configGeneral").method_3("ckbKhongSuDungProfile");
		ckbQuenMatKhauByChrome.Checked = GClass25.smethod_0("configGeneral").method_3("ckbQuenMatKhauByChrome");
		rbPassTuDat_CheckedChanged(null, null);
	}

	private void rbPassTuDat_CheckedChanged(object sender, EventArgs e)
	{
		A13FBE24.Enabled = rbPassTuDat.Checked;
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		Close();
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && CE181CA3 != null)
		{
			CE181CA3.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void EE9C7300()
	{
		CE181CA3 = new Container();
		btnCancel = new Button();
		btnAdd = new Button();
		D19F7E08 = new BunifuDragControl(CE181CA3);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		C0161D2B = new RadioButton();
		rbPassTuDat = new RadioButton();
		A13FBE24 = new TextBox();
		bunifuCards1 = new BunifuCards();
		btnClose = new Button();
		pictureBox1 = new PictureBox();
		A09F14BD = new Panel();
		EA9E391B = new CheckBox();
		ckbQuenMatKhauByChrome = new CheckBox();
		CA0D7AB2 = new CheckBox();
		bunifuCards1.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		A09F14BD.SuspendLayout();
		SuspendLayout();
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(172, 188);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(68, 188);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		D19F7E08.Fixed = true;
		D19F7E08.Horizontal = true;
		D19F7E08.TargetControl = bunifuCustomLabel1;
		D19F7E08.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(330, 38);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Khôi phục mật khẩu";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		C0161D2B.AutoSize = true;
		C0161D2B.Cursor = Cursors.Hand;
		C0161D2B.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		C0161D2B.Location = new Point(27, 81);
		C0161D2B.Name = "rbPassNgauNhien";
		C0161D2B.Size = new Size(144, 20);
		C0161D2B.TabIndex = 5;
		C0161D2B.TabStop = true;
		C0161D2B.Text = "Mâ\u0323t khâ\u0309u ngẫu nhiên";
		C0161D2B.UseVisualStyleBackColor = true;
		rbPassTuDat.AutoSize = true;
		rbPassTuDat.Cursor = Cursors.Hand;
		rbPassTuDat.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		rbPassTuDat.Location = new Point(27, 55);
		rbPassTuDat.Name = "rbPassTuDat";
		rbPassTuDat.Size = new Size(130, 20);
		rbPassTuDat.TabIndex = 6;
		rbPassTuDat.TabStop = true;
		rbPassTuDat.Text = "Mâ\u0323t khâ\u0309u chỉ định:";
		rbPassTuDat.UseVisualStyleBackColor = true;
		rbPassTuDat.CheckedChanged += rbPassTuDat_CheckedChanged;
		A13FBE24.Location = new Point(163, 54);
		A13FBE24.Name = "txtPass";
		A13FBE24.Size = new Size(132, 23);
		A13FBE24.TabIndex = 7;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(btnClose);
		bunifuCards1.Controls.Add(pictureBox1);
		bunifuCards1.Controls.Add(bunifuCustomLabel1);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(330, 38);
		bunifuCards1.TabIndex = 29;
		btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		btnClose.Cursor = Cursors.Hand;
		btnClose.FlatAppearance.BorderSize = 0;
		btnClose.FlatStyle = FlatStyle.Flat;
		btnClose.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnClose.ForeColor = Color.White;
		btnClose.Image = C50FB39E.Bitmap_13;
		btnClose.Location = new Point(298, 5);
		btnClose.Name = "btnClose";
		btnClose.Size = new Size(30, 30);
		btnClose.TabIndex = 77;
		btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnClose.UseVisualStyleBackColor = true;
		btnClose.Click += btnClose_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(2, 6);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		A09F14BD.BorderStyle = BorderStyle.FixedSingle;
		A09F14BD.Controls.Add(A13FBE24);
		A09F14BD.Controls.Add(EA9E391B);
		A09F14BD.Controls.Add(ckbQuenMatKhauByChrome);
		A09F14BD.Controls.Add(CA0D7AB2);
		A09F14BD.Controls.Add(rbPassTuDat);
		A09F14BD.Controls.Add(C0161D2B);
		A09F14BD.Controls.Add(bunifuCards1);
		A09F14BD.Dock = DockStyle.Fill;
		A09F14BD.Location = new Point(0, 0);
		A09F14BD.Name = "panel2";
		A09F14BD.Size = new Size(332, 229);
		A09F14BD.TabIndex = 30;
		EA9E391B.AutoSize = true;
		EA9E391B.Cursor = Cursors.Hand;
		EA9E391B.Location = new Point(27, 107);
		EA9E391B.Name = "ckbKillSession";
		EA9E391B.Size = new Size(144, 20);
		EA9E391B.TabIndex = 30;
		EA9E391B.Text = "Đăng xuất thiết bị cũ";
		EA9E391B.UseVisualStyleBackColor = true;
		ckbQuenMatKhauByChrome.AutoSize = true;
		ckbQuenMatKhauByChrome.Cursor = Cursors.Hand;
		ckbQuenMatKhauByChrome.Location = new Point(27, 159);
		ckbQuenMatKhauByChrome.Name = "ckbQuenMatKhauByChrome";
		ckbQuenMatKhauByChrome.Size = new Size(192, 20);
		ckbQuenMatKhauByChrome.TabIndex = 30;
		ckbQuenMatKhauByChrome.Text = "Quên mâ\u0323t khâ\u0309u bă\u0300ng chrome";
		ckbQuenMatKhauByChrome.UseVisualStyleBackColor = true;
		ckbQuenMatKhauByChrome.Visible = false;
		CA0D7AB2.AutoSize = true;
		CA0D7AB2.Cursor = Cursors.Hand;
		CA0D7AB2.Location = new Point(27, 133);
		CA0D7AB2.Name = "ckbKhongSuDungProfile";
		CA0D7AB2.Size = new Size(198, 20);
		CA0D7AB2.TabIndex = 30;
		CA0D7AB2.Text = "Không sử dụng profile chrome";
		CA0D7AB2.UseVisualStyleBackColor = true;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(332, 229);
		base.Controls.Add(btnCancel);
		base.Controls.Add(btnAdd);
		base.Controls.Add(A09F14BD);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fCauHinhKhoiPhucMatKhau";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += fCauHinhKhoiPhucMatKhau_Load;
		bunifuCards1.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		A09F14BD.ResumeLayout(performLayout: false);
		A09F14BD.PerformLayout();
		ResumeLayout(performLayout: false);
	}
}
