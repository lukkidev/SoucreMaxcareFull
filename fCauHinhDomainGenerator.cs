using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhDomainGenerator : Form
{
	public static bool bool_0;

	private IContainer D329DC07 = null;

	private Button A5A05712;

	private Button btnAdd;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuCards A81FA717;

	private Button B78B7536;

	private PictureBox pictureBox1;

	private BunifuCustomLabel B801B9AF;

	private Panel E91B5C85;

	private RichTextBox txtPass;

	private Label A8B3C899;

	public fCauHinhDomainGenerator()
	{
		F0BB0DB6();
		F7AB102E.D6B70A35(this);
		bool_0 = false;
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		List<string> first = txtPass.smethod_6();
		first = first.Except(new List<string> { "hotmail.com", "outlook.com" }).ToList();
		GClass25.smethod_0("configGeneral").method_5("txtGeneratorDomain", first);
		GClass25.B3B73732("configGeneral");
		bool_0 = true;
		Close();
	}

	private void A5A05712_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B9047B9F(object sender, EventArgs e)
	{
		txtPass.Text = GClass25.smethod_0("configGeneral").C0288288("txtGeneratorDomain");
		method_0(null, null);
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void B78B7536_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void txtPass_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtPass, A8B3C899);
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && D329DC07 != null)
		{
			D329DC07.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void F0BB0DB6()
	{
		D329DC07 = new Container();
		A5A05712 = new Button();
		btnAdd = new Button();
		bunifuDragControl_0 = new BunifuDragControl(D329DC07);
		B801B9AF = new BunifuCustomLabel();
		A81FA717 = new BunifuCards();
		B78B7536 = new Button();
		pictureBox1 = new PictureBox();
		E91B5C85 = new Panel();
		txtPass = new RichTextBox();
		A8B3C899 = new Label();
		A81FA717.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		E91B5C85.SuspendLayout();
		SuspendLayout();
		A5A05712.Anchor = AnchorStyles.Bottom;
		A5A05712.BackColor = Color.Maroon;
		A5A05712.Cursor = Cursors.Hand;
		A5A05712.FlatAppearance.BorderSize = 0;
		A5A05712.FlatStyle = FlatStyle.Flat;
		A5A05712.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		A5A05712.ForeColor = Color.White;
		A5A05712.Location = new Point(172, 251);
		A5A05712.Name = "btnCancel";
		A5A05712.Size = new Size(92, 29);
		A5A05712.TabIndex = 4;
		A5A05712.Text = "Đo\u0301ng";
		A5A05712.UseVisualStyleBackColor = false;
		A5A05712.Click += A5A05712_Click;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(68, 251);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = B801B9AF;
		bunifuDragControl_0.Vertical = true;
		B801B9AF.BackColor = Color.Transparent;
		B801B9AF.Cursor = Cursors.SizeAll;
		B801B9AF.Dock = DockStyle.Fill;
		B801B9AF.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		B801B9AF.ForeColor = Color.Black;
		B801B9AF.Location = new Point(0, 0);
		B801B9AF.Name = "bunifuCustomLabel1";
		B801B9AF.Size = new Size(330, 38);
		B801B9AF.TabIndex = 12;
		B801B9AF.Text = "Cấu hình Domain Generator";
		B801B9AF.TextAlign = ContentAlignment.MiddleCenter;
		A81FA717.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		A81FA717.BackColor = Color.White;
		A81FA717.BorderRadius = 0;
		A81FA717.BottomSahddow = true;
		A81FA717.color = Color.DarkViolet;
		A81FA717.Controls.Add(B78B7536);
		A81FA717.Controls.Add(pictureBox1);
		A81FA717.Controls.Add(B801B9AF);
		A81FA717.LeftSahddow = false;
		A81FA717.Location = new Point(1, 0);
		A81FA717.Name = "bunifuCards1";
		A81FA717.RightSahddow = true;
		A81FA717.ShadowDepth = 20;
		A81FA717.Size = new Size(330, 38);
		A81FA717.TabIndex = 29;
		B78B7536.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		B78B7536.Cursor = Cursors.Hand;
		B78B7536.FlatAppearance.BorderSize = 0;
		B78B7536.FlatStyle = FlatStyle.Flat;
		B78B7536.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		B78B7536.ForeColor = Color.White;
		B78B7536.Image = C50FB39E.Bitmap_13;
		B78B7536.Location = new Point(298, 5);
		B78B7536.Name = "btnClose";
		B78B7536.Size = new Size(30, 30);
		B78B7536.TabIndex = 77;
		B78B7536.TextImageRelation = TextImageRelation.ImageBeforeText;
		B78B7536.UseVisualStyleBackColor = true;
		B78B7536.Click += B78B7536_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(2, 6);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		E91B5C85.BorderStyle = BorderStyle.FixedSingle;
		E91B5C85.Controls.Add(txtPass);
		E91B5C85.Controls.Add(A8B3C899);
		E91B5C85.Controls.Add(A81FA717);
		E91B5C85.Dock = DockStyle.Fill;
		E91B5C85.Location = new Point(0, 0);
		E91B5C85.Name = "panel2";
		E91B5C85.Size = new Size(332, 292);
		E91B5C85.TabIndex = 30;
		txtPass.Location = new Point(34, 69);
		txtPass.Name = "txtPass";
		txtPass.Size = new Size(267, 170);
		txtPass.TabIndex = 31;
		txtPass.Text = "";
		txtPass.WordWrap = false;
		txtPass.TextChanged += txtPass_TextChanged;
		A8B3C899.AutoSize = true;
		A8B3C899.Location = new Point(31, 50);
		A8B3C899.Name = "lblTitle";
		A8B3C899.Size = new Size(138, 16);
		A8B3C899.TabIndex = 30;
		A8B3C899.Text = "Danh sách domain (0):";
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(332, 292);
		base.Controls.Add(A5A05712);
		base.Controls.Add(btnAdd);
		base.Controls.Add(E91B5C85);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fCauHinhDomainGenerator";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += B9047B9F;
		A81FA717.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		E91B5C85.ResumeLayout(performLayout: false);
		E91B5C85.PerformLayout();
		ResumeLayout(performLayout: false);
	}
}
