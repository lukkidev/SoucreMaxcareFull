using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fNhapMailAdd : Form
{
	private string string_0 = "configschange\\addmail\\hotmail.txt";

	private string CD039E0F = "";

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel panel1;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip FCA094A9;

	private BunifuCards bunifuCards2;

	private Panel pnlHeader;

	private Button button2;

	private PictureBox pictureBox1;

	private Button btnMinimize;

	private BunifuCustomLabel lblTitle;

	private Label CB974805;

	private Button btnCancel;

	private Button btnAdd;

	private Label BC95E29F;

	private RichTextBox txtComment;

	private Label label3;

	private Label E3217797;

	private Label label2;

	private Label label1;

	public fNhapMailAdd()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		GClass8.smethod_31(string_0);
	}

	private void C1011780()
	{
		F7AB102E.smethod_1(lblTitle);
		F7AB102E.smethod_1(CB974805);
		F7AB102E.smethod_1(BC95E29F);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(btnCancel);
	}

	private void method_0(object sender, EventArgs e)
	{
		Close();
	}

	private void fNhapMailAdd_Load(object sender, EventArgs e)
	{
		txtComment.Lines = File.ReadAllLines(string_0);
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void CBB69EBD(object sender, PaintEventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			File.WriteAllText(string_0, txtComment.Text.Trim());
			if (GClass29.smethod_1("Lưu thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?") == DialogResult.Yes)
			{
				Close();
			}
		}
		catch
		{
			GClass29.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void C418FA00(object sender, EventArgs e)
	{
		Close();
	}

	private void B08D6103(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtComment.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			CB974805.Text = "Danh sách Email (" + e03C713E.Count + "):";
		}
		catch
		{
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

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		panel1 = new System.Windows.Forms.Panel();
		txtComment = new System.Windows.Forms.RichTextBox();
		BC95E29F = new System.Windows.Forms.Label();
		CB974805 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		FCA094A9 = new System.Windows.Forms.ToolTip(icontainer_0);
		label1 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		E3217797 = new System.Windows.Forms.Label();
		panel1.SuspendLayout();
		bunifuCards2.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 5;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(234, 47);
		bunifuCards1.TabIndex = 12;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(label3);
		panel1.Controls.Add(E3217797);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(txtComment);
		panel1.Controls.Add(BC95E29F);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(CB974805);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards2);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(563, 364);
		panel1.TabIndex = 37;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(CBB69EBD);
		txtComment.Location = new System.Drawing.Point(16, 64);
		txtComment.Name = "txtComment";
		txtComment.Size = new System.Drawing.Size(528, 231);
		txtComment.TabIndex = 50;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(B08D6103);
		BC95E29F.AutoSize = true;
		BC95E29F.Location = new System.Drawing.Point(13, 299);
		BC95E29F.Name = "lblFooter";
		BC95E29F.Size = new System.Drawing.Size(134, 16);
		BC95E29F.TabIndex = 49;
		BC95E29F.Text = "(Mỗi nội dung 1 dòng)";
		CB974805.AutoSize = true;
		CB974805.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		CB974805.Location = new System.Drawing.Point(13, 45);
		CB974805.Name = "lblStatus";
		CB974805.Size = new System.Drawing.Size(128, 16);
		CB974805.TabIndex = 47;
		CB974805.Text = "Danh sách Email (0):";
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(286, 321);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 46;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(C418FA00);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(182, 321);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 45;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		bunifuCards2.BackColor = System.Drawing.Color.White;
		bunifuCards2.BorderRadius = 0;
		bunifuCards2.BottomSahddow = true;
		bunifuCards2.color = System.Drawing.Color.SaddleBrown;
		bunifuCards2.Controls.Add(pnlHeader);
		bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards2.LeftSahddow = false;
		bunifuCards2.Location = new System.Drawing.Point(0, 0);
		bunifuCards2.Name = "bunifuCards2";
		bunifuCards2.RightSahddow = true;
		bunifuCards2.ShadowDepth = 20;
		bunifuCards2.Size = new System.Drawing.Size(561, 37);
		bunifuCards2.TabIndex = 43;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button2);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(lblTitle);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(561, 31);
		pnlHeader.TabIndex = 9;
		button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button2.ForeColor = System.Drawing.Color.White;
		button2.Image = C50FB39E.Bitmap_12;
		button2.Location = new System.Drawing.Point(530, 1);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Location = new System.Drawing.Point(899, 1);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(30, 30);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		lblTitle.BackColor = System.Drawing.Color.Transparent;
		lblTitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
		lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
		lblTitle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblTitle.ForeColor = System.Drawing.Color.Black;
		lblTitle.Location = new System.Drawing.Point(0, 0);
		lblTitle.Name = "lblTitle";
		lblTitle.Size = new System.Drawing.Size(561, 31);
		lblTitle.TabIndex = 12;
		lblTitle.Text = "Nhâ\u0323p danh sa\u0301ch Email cần add";
		lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = lblTitle;
		bunifuDragControl_0.Vertical = true;
		FCA094A9.AutomaticDelay = 0;
		FCA094A9.AutoPopDelay = 10000;
		FCA094A9.InitialDelay = 200;
		FCA094A9.ReshowDelay = 40;
		label1.AutoSize = true;
		label1.BackColor = System.Drawing.Color.Transparent;
		label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label1.ForeColor = System.Drawing.Color.DarkRed;
		label1.Location = new System.Drawing.Point(187, 45);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(103, 16);
		label1.TabIndex = 47;
		label1.Text = "Định dạng nhập:";
		label2.AutoSize = true;
		label2.ForeColor = System.Drawing.Color.DarkGreen;
		label2.Location = new System.Drawing.Point(286, 45);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(102, 16);
		label2.TabIndex = 51;
		label2.Text = "Email|Pass Mail ";
		label3.AutoSize = true;
		label3.BackColor = System.Drawing.Color.Transparent;
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label3.ForeColor = System.Drawing.Color.DarkRed;
		label3.Location = new System.Drawing.Point(381, 45);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(35, 16);
		label3.TabIndex = 47;
		label3.Text = "hoặc";
		E3217797.AutoSize = true;
		E3217797.ForeColor = System.Drawing.Color.DarkGreen;
		E3217797.Location = new System.Drawing.Point(414, 45);
		E3217797.Name = "label4";
		E3217797.Size = new System.Drawing.Size(133, 16);
		E3217797.TabIndex = 51;
		E3217797.Text = "Email|Pass Mail|Imap";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(563, 364);
		base.Controls.Add(panel1);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fNhapMailAdd";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fNhapMailAdd_Load);
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		bunifuCards2.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
	}
}
