using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhTaiAnhTuNhom : Form
{
	public bool bool_0 = false;

	private IContainer D6A1218C = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel CF09F6B2;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private NumericUpDown nudSoLuong;

	private Label F20E0F0E;

	private TextBox F33D9139;

	private Label label2;

	private Label EDA09A0F;

	private RichTextBox txtIdNhom;

	public fCauHinhTaiAnhTuNhom()
	{
		InitializeComponent();
		bool_0 = false;
		F7AB102E.D6B70A35(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		GClass25.smethod_0("configTaiAnhTuNhom").method_4("txtIdNhom", txtIdNhom.Text.Trim());
		GClass25.smethod_0("configTaiAnhTuNhom").method_4("nudSoLuong", nudSoLuong.Value);
		GClass25.smethod_0("configTaiAnhTuNhom").method_4("txtFolderPath", F33D9139.Text.Trim());
		GClass25.B3B73732("configTaiAnhTuNhom");
		bool_0 = true;
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fCauHinhTaiAnhTuNhom_Load(object sender, EventArgs e)
	{
		txtIdNhom.Text = GClass25.smethod_0("configTaiAnhTuNhom").C0288288("txtIdNhom");
		nudSoLuong.Value = GClass25.smethod_0("configTaiAnhTuNhom").method_2("nudSoLuong", 100);
		F33D9139.Text = GClass25.smethod_0("configTaiAnhTuNhom").C0288288("txtFolderPath");
	}

	private void EDA09A0F_Click(object sender, EventArgs e)
	{
	}

	private void nudSoLuong_ValueChanged(object sender, EventArgs e)
	{
	}

	private void D22502B2(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtIdNhom, EDA09A0F);
	}

	protected override void Dispose(bool A02BEB16)
	{
		if (A02BEB16 && D6A1218C != null)
		{
			D6A1218C.Dispose();
		}
		base.Dispose(A02BEB16);
	}

	private void InitializeComponent()
	{
		D6A1218C = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhTaiAnhTuNhom));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		CF09F6B2 = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(D6A1218C);
		nudSoLuong = new System.Windows.Forms.NumericUpDown();
		F20E0F0E = new System.Windows.Forms.Label();
		F33D9139 = new System.Windows.Forms.TextBox();
		label2 = new System.Windows.Forms.Label();
		EDA09A0F = new System.Windows.Forms.Label();
		txtIdNhom = new System.Windows.Forms.RichTextBox();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
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
		bunifuCards1.Size = new System.Drawing.Size(296, 38);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(CF09F6B2);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(296, 32);
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
		btnMinimize.Location = new System.Drawing.Point(264, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		CF09F6B2.BackColor = System.Drawing.Color.Transparent;
		CF09F6B2.Cursor = System.Windows.Forms.Cursors.SizeAll;
		CF09F6B2.Dock = System.Windows.Forms.DockStyle.Fill;
		CF09F6B2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CF09F6B2.ForeColor = System.Drawing.Color.Black;
		CF09F6B2.Location = new System.Drawing.Point(0, 0);
		CF09F6B2.Name = "bunifuCustomLabel1";
		CF09F6B2.Size = new System.Drawing.Size(296, 32);
		CF09F6B2.TabIndex = 1;
		CF09F6B2.Text = "Câ\u0301u hi\u0300nh Ta\u0309i a\u0309nh tư\u0300 nho\u0301m";
		CF09F6B2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(156, 278);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(52, 278);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = CF09F6B2;
		bunifuDragControl_0.Vertical = true;
		nudSoLuong.Location = new System.Drawing.Point(156, 211);
		nudSoLuong.Maximum = new decimal(new int[4] { 9999999, 0, 0, 0 });
		nudSoLuong.Name = "nudSoLuong";
		nudSoLuong.Size = new System.Drawing.Size(112, 23);
		nudSoLuong.TabIndex = 1;
		nudSoLuong.ValueChanged += new System.EventHandler(nudSoLuong_ValueChanged);
		F20E0F0E.AutoSize = true;
		F20E0F0E.Location = new System.Drawing.Point(25, 213);
		F20E0F0E.Name = "label1";
		F20E0F0E.Size = new System.Drawing.Size(125, 16);
		F20E0F0E.TabIndex = 0;
		F20E0F0E.Text = "Sô\u0301 lươ\u0323ng a\u0309nh/nho\u0301m:";
		F20E0F0E.Click += new System.EventHandler(EDA09A0F_Click);
		F33D9139.Location = new System.Drawing.Point(93, 240);
		F33D9139.Name = "txtFolderPath";
		F33D9139.Size = new System.Drawing.Size(175, 23);
		F33D9139.TabIndex = 1;
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(24, 243);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(70, 16);
		label2.TabIndex = 0;
		label2.Text = "Folder lưu:";
		EDA09A0F.AutoSize = true;
		EDA09A0F.Location = new System.Drawing.Point(25, 51);
		EDA09A0F.Name = "lblIdNhom";
		EDA09A0F.Size = new System.Drawing.Size(143, 16);
		EDA09A0F.TabIndex = 0;
		EDA09A0F.Text = "Danh sa\u0301ch Id nho\u0301m (0):";
		EDA09A0F.Click += new System.EventHandler(EDA09A0F_Click);
		txtIdNhom.Location = new System.Drawing.Point(28, 71);
		txtIdNhom.Name = "txtIdNhom";
		txtIdNhom.Size = new System.Drawing.Size(240, 134);
		txtIdNhom.TabIndex = 5;
		txtIdNhom.Text = "";
		txtIdNhom.WordWrap = false;
		txtIdNhom.TextChanged += new System.EventHandler(D22502B2);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(296, 320);
		base.Controls.Add(txtIdNhom);
		base.Controls.Add(F33D9139);
		base.Controls.Add(label2);
		base.Controls.Add(nudSoLuong);
		base.Controls.Add(EDA09A0F);
		base.Controls.Add(F20E0F0E);
		base.Controls.Add(btnCancel);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhTaiAnhTuNhom";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(fCauHinhTaiAnhTuNhom_Load);
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
