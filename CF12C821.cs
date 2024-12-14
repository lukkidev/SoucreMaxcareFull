using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class CF12C821 : Form
{
	public static bool bool_0;

	private IContainer A5930BA4 = null;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl BE92FC04;

	private BunifuCards bunifuCards1;

	private Button btnClose;

	private PictureBox E5340792;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel panel2;

	private RichTextBox txtPass;

	private Label lblTitle;

	public CF12C821()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		bool_0 = false;
	}

	private void method_0()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(btnCancel);
	}

	private void method_1(object sender, EventArgs e)
	{
		Close();
	}

	private void E80DBEA1(object sender, EventArgs e)
	{
		GClass25.smethod_0("configGeneral").method_4("txtCheckPass", txtPass.Text.Trim());
		GClass25.B3B73732("configGeneral");
		bool_0 = true;
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void CF12C821_Load(object sender, EventArgs e)
	{
		txtPass.Text = GClass25.smethod_0("configGeneral").C0288288("txtCheckPass");
		C111A632(null, null);
	}

	private void C111A632(object sender, EventArgs e)
	{
	}

	private void B71A4A0F(object sender, EventArgs e)
	{
		Close();
	}

	private void txtPass_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtPass, lblTitle);
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && A5930BA4 != null)
		{
			A5930BA4.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		A5930BA4 = new System.ComponentModel.Container();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		BE92FC04 = new Bunifu.Framework.UI.BunifuDragControl(A5930BA4);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		btnClose = new System.Windows.Forms.Button();
		E5340792 = new System.Windows.Forms.PictureBox();
		panel2 = new System.Windows.Forms.Panel();
		txtPass = new System.Windows.Forms.RichTextBox();
		lblTitle = new System.Windows.Forms.Label();
		bunifuCards1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)E5340792).BeginInit();
		panel2.SuspendLayout();
		SuspendLayout();
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(172, 251);
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
		btnAdd.Location = new System.Drawing.Point(68, 251);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(E80DBEA1);
		BE92FC04.Fixed = true;
		BE92FC04.Horizontal = true;
		BE92FC04.TargetControl = bunifuCustomLabel1;
		BE92FC04.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(330, 38);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Check Pass";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(btnClose);
		bunifuCards1.Controls.Add(E5340792);
		bunifuCards1.Controls.Add(bunifuCustomLabel1);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(330, 38);
		bunifuCards1.TabIndex = 29;
		btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
		btnClose.FlatAppearance.BorderSize = 0;
		btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnClose.ForeColor = System.Drawing.Color.White;
		btnClose.Image = C50FB39E.Bitmap_13;
		btnClose.Location = new System.Drawing.Point(298, 5);
		btnClose.Name = "btnClose";
		btnClose.Size = new System.Drawing.Size(30, 30);
		btnClose.TabIndex = 77;
		btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnClose.UseVisualStyleBackColor = true;
		btnClose.Click += new System.EventHandler(B71A4A0F);
		E5340792.Cursor = System.Windows.Forms.Cursors.Default;
		E5340792.Image = C50FB39E.Bitmap_5;
		E5340792.Location = new System.Drawing.Point(2, 6);
		E5340792.Name = "pictureBox1";
		E5340792.Size = new System.Drawing.Size(34, 27);
		E5340792.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		E5340792.TabIndex = 76;
		E5340792.TabStop = false;
		panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel2.Controls.Add(txtPass);
		panel2.Controls.Add(lblTitle);
		panel2.Controls.Add(bunifuCards1);
		panel2.Dock = System.Windows.Forms.DockStyle.Fill;
		panel2.Location = new System.Drawing.Point(0, 0);
		panel2.Name = "panel2";
		panel2.Size = new System.Drawing.Size(332, 292);
		panel2.TabIndex = 30;
		txtPass.Location = new System.Drawing.Point(34, 69);
		txtPass.Name = "txtPass";
		txtPass.Size = new System.Drawing.Size(267, 170);
		txtPass.TabIndex = 31;
		txtPass.Text = "";
		txtPass.WordWrap = false;
		txtPass.TextChanged += new System.EventHandler(txtPass_TextChanged);
		lblTitle.AutoSize = true;
		lblTitle.Location = new System.Drawing.Point(31, 50);
		lblTitle.Name = "lblTitle";
		lblTitle.Size = new System.Drawing.Size(122, 16);
		lblTitle.TabIndex = 30;
		lblTitle.Text = "Danh sách pass (0):";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(332, 292);
		base.Controls.Add(btnCancel);
		base.Controls.Add(btnAdd);
		base.Controls.Add(panel2);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhCheckPass";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(CF12C821_Load);
		bunifuCards1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)E5340792).EndInit();
		panel2.ResumeLayout(false);
		panel2.PerformLayout();
		ResumeLayout(false);
	}
}
