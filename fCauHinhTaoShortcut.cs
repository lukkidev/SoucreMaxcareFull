using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhTaoShortcut : Form
{
	public static bool bool_0;

	private string A424723F = "";

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel AA3C8899;

	private Button btnMinimize;

	private Button F03D2D02;

	private Button btnAdd;

	private BunifuDragControl B805F536;

	private PictureBox B21878B0;

	private Label label1;

	private TextBox txtPathShortcut;

	private Button metroButton1;

	private Label F88F6483;

	private TextBox txtPathChromeOrigin;

	private Button metroButton2;

	public fCauHinhTaoShortcut()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		bool_0 = false;
		string text = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
		string text2 = "C:\\Program Files (x64)\\Google\\Chrome\\Application\\chrome.exe";
		string text3 = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";
		if (!File.Exists(text))
		{
			if (!File.Exists(text2))
			{
				if (File.Exists(text3))
				{
					A424723F = text3;
				}
			}
			else
			{
				A424723F = text2;
			}
		}
		else
		{
			A424723F = text;
		}
	}

	private void D0A2BDA9()
	{
		F7AB102E.smethod_1(AA3C8899);
		F7AB102E.smethod_1(label1);
		F7AB102E.smethod_1(metroButton1);
		F7AB102E.smethod_1(F88F6483);
		F7AB102E.smethod_1(metroButton2);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(F03D2D02);
	}

	private void F93E782D(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		if (txtPathShortcut.Text.Trim() == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p đươ\u0300ng dâ\u0303n đê\u0301n Thư mu\u0323c lưu Shortcut!", 3);
			return;
		}
		if (txtPathChromeOrigin.Text.Trim() == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p đươ\u0300ng dâ\u0303n đê\u0301n chrome.exe!", 3);
			return;
		}
		if (!txtPathChromeOrigin.Text.Trim().EndsWith("chrome.exe"))
		{
			GClass29.smethod_0("Đươ\u0300ng dâ\u0303n đê\u0301n chrome.exe không hơ\u0323p lê\u0323!", 3);
			return;
		}
		GClass25.smethod_0("configInteractGeneral").method_4("txtPathShortcut", txtPathShortcut.Text.Trim());
		GClass25.smethod_0("configInteractGeneral").method_4("txtPathChromeOrigin", txtPathChromeOrigin.Text.Trim());
		GClass25.B3B73732("configInteractGeneral");
		bool_0 = true;
		Close();
	}

	private void F03D2D02_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C4082EBE(object sender, EventArgs e)
	{
	}

	private void fCauHinhTaoShortcut_Load(object sender, EventArgs e)
	{
		txtPathShortcut.Text = GClass25.smethod_0("configInteractGeneral").C0288288("txtPathShortcut");
		if (txtPathShortcut.Text.Trim() == "" || !Directory.Exists(txtPathShortcut.Text.Trim()))
		{
			txtPathShortcut.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		}
		if (File.Exists(GClass25.smethod_0("configInteractGeneral").C0288288("txtPathChromeOrigin")))
		{
			txtPathChromeOrigin.Text = GClass25.smethod_0("configInteractGeneral").C0288288("txtPathChromeOrigin");
		}
		else
		{
			txtPathChromeOrigin.Text = A424723F;
		}
	}

	private void metroButton1_Click(object sender, EventArgs e)
	{
		string value = GClass8.smethod_40();
		if (!string.IsNullOrEmpty(value))
		{
			txtPathShortcut.Text = value;
		}
	}

	private void F0891681(object sender, EventArgs e)
	{
		txtPathChromeOrigin.Text = GClass8.AD2D2BA4(F7AB102E.smethod_0("Cho\u0323n File"), "");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhTaoShortcut));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		B21878B0 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		AA3C8899 = new Bunifu.Framework.UI.BunifuCustomLabel();
		F03D2D02 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		B805F536 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		label1 = new System.Windows.Forms.Label();
		txtPathShortcut = new System.Windows.Forms.TextBox();
		metroButton1 = new System.Windows.Forms.Button();
		F88F6483 = new System.Windows.Forms.Label();
		txtPathChromeOrigin = new System.Windows.Forms.TextBox();
		metroButton2 = new System.Windows.Forms.Button();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)B21878B0).BeginInit();
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
		bunifuCards1.Size = new System.Drawing.Size(594, 38);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(B21878B0);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(AA3C8899);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(594, 32);
		pnlHeader.TabIndex = 9;
		B21878B0.Cursor = System.Windows.Forms.Cursors.Default;
		B21878B0.Image = C50FB39E.Bitmap_5;
		B21878B0.Location = new System.Drawing.Point(3, 2);
		B21878B0.Name = "pictureBox1";
		B21878B0.Size = new System.Drawing.Size(34, 27);
		B21878B0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		B21878B0.TabIndex = 17;
		B21878B0.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(562, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(F93E782D);
		AA3C8899.BackColor = System.Drawing.Color.Transparent;
		AA3C8899.Cursor = System.Windows.Forms.Cursors.SizeAll;
		AA3C8899.Dock = System.Windows.Forms.DockStyle.Fill;
		AA3C8899.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		AA3C8899.ForeColor = System.Drawing.Color.Black;
		AA3C8899.Location = new System.Drawing.Point(0, 0);
		AA3C8899.Name = "bunifuCustomLabel1";
		AA3C8899.Size = new System.Drawing.Size(594, 32);
		AA3C8899.TabIndex = 1;
		AA3C8899.Text = "Câ\u0301u hi\u0300nh ta\u0323o Shortcut Chrome";
		AA3C8899.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F03D2D02.BackColor = System.Drawing.Color.Maroon;
		F03D2D02.Cursor = System.Windows.Forms.Cursors.Hand;
		F03D2D02.FlatAppearance.BorderSize = 0;
		F03D2D02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		F03D2D02.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F03D2D02.ForeColor = System.Drawing.Color.White;
		F03D2D02.Location = new System.Drawing.Point(303, 139);
		F03D2D02.Name = "btnCancel";
		F03D2D02.Size = new System.Drawing.Size(92, 29);
		F03D2D02.TabIndex = 4;
		F03D2D02.Text = "Đo\u0301ng";
		F03D2D02.UseVisualStyleBackColor = false;
		F03D2D02.Click += new System.EventHandler(F03D2D02_Click);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(199, 139);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		B805F536.Fixed = true;
		B805F536.Horizontal = true;
		B805F536.TargetControl = AA3C8899;
		B805F536.Vertical = true;
		label1.AutoSize = true;
		label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label1.Location = new System.Drawing.Point(33, 60);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(104, 16);
		label1.TabIndex = 5;
		label1.Text = "Nơi lưu Shortcut:";
		txtPathShortcut.Location = new System.Drawing.Point(157, 58);
		txtPathShortcut.Name = "txtPathShortcut";
		txtPathShortcut.Size = new System.Drawing.Size(352, 23);
		txtPathShortcut.TabIndex = 6;
		metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton1.Location = new System.Drawing.Point(515, 58);
		metroButton1.Name = "metroButton1";
		metroButton1.Size = new System.Drawing.Size(47, 24);
		metroButton1.TabIndex = 7;
		metroButton1.Text = "Cho\u0323n";
		metroButton1.Click += new System.EventHandler(metroButton1_Click);
		F88F6483.AutoSize = true;
		F88F6483.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		F88F6483.Location = new System.Drawing.Point(33, 91);
		F88F6483.Name = "label2";
		F88F6483.Size = new System.Drawing.Size(124, 16);
		F88F6483.TabIndex = 5;
		F88F6483.Text = "Đươ\u0300ng dâ\u0303n Chrome:";
		txtPathChromeOrigin.Location = new System.Drawing.Point(157, 89);
		txtPathChromeOrigin.Name = "txtPathChromeOrigin";
		txtPathChromeOrigin.Size = new System.Drawing.Size(352, 23);
		txtPathChromeOrigin.TabIndex = 6;
		txtPathChromeOrigin.Text = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
		metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton2.Location = new System.Drawing.Point(515, 89);
		metroButton2.Name = "metroButton2";
		metroButton2.Size = new System.Drawing.Size(47, 24);
		metroButton2.TabIndex = 7;
		metroButton2.Text = "Cho\u0323n";
		metroButton2.Click += new System.EventHandler(F0891681);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(594, 187);
		base.Controls.Add(metroButton2);
		base.Controls.Add(metroButton1);
		base.Controls.Add(txtPathChromeOrigin);
		base.Controls.Add(F88F6483);
		base.Controls.Add(txtPathShortcut);
		base.Controls.Add(label1);
		base.Controls.Add(F03D2D02);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhTaoShortcut";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(fCauHinhTaoShortcut_Load);
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)B21878B0).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
