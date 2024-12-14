using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fNhapDuLieu3 : Form
{
	private string string_0 = "";

	private string string_1 = "";

	public string string_2 = "";

	public int int_0 = 0;

	private IContainer C421E902 = null;

	private BunifuCards bunifuCards1;

	private Panel panel1;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip B1044F10;

	private BunifuCards bunifuCards2;

	private Panel E4A05BAC;

	private Button button2;

	private PictureBox pictureBox1;

	private Button A094FFA1;

	private BunifuCustomLabel B30C6600;

	private Label FFB22A8D;

	private Button B3B7C7B8;

	private Button btnAdd;

	private Label A48ED88F;

	private RichTextBox txtComment;

	private Button B09D0D0A;

	private Button button1;

	private RadioButton A594CE14;

	private RadioButton F8BF5619;

	private Label label9;

	public fNhapDuLieu3(string FB94C3B7, string string_3 = "Nhập danh sách Uid cần clone", string string_4 = "Danh sách Uid", string string_5 = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})", List<string> FF854A83 = null)
	{
		InitializeComponent();
		GClass8.smethod_31(FB94C3B7);
		string_0 = FB94C3B7;
		string_1 = string_4;
		B30C6600.Text = string_3;
		FFB22A8D.Text = string_4 + " (0):";
		A48ED88F.Text = string_5;
		if (FF854A83 != null)
		{
			File.WriteAllLines(FB94C3B7, FF854A83);
			txtComment.Lines = FF854A83.ToArray();
		}
		else
		{
			txtComment.Lines = File.ReadAllLines(FB94C3B7);
		}
		txtComment_TextChanged(null, null);
		F7AB102E.D6B70A35(this);
	}

	public fNhapDuLieu3(string string_3, int int_1, string string_4 = "Nhập danh sách Uid cần clone", string string_5 = "Danh sách Uid", string string_6 = "(Spin nội dung {a|b|c})")
	{
		InitializeComponent();
		string_2 = string_3;
		int_0 = int_1;
		string_1 = string_5;
		B30C6600.Text = string_4;
		FFB22A8D.Text = string_5 + " (0):";
		A48ED88F.Text = string_6;
		F7AB102E.D6B70A35(this);
	}

	private void fNhapDuLieu3_Load(object sender, EventArgs e)
	{
		if (int_0 == 0)
		{
			F8BF5619.Checked = true;
		}
		else
		{
			A594CE14.Checked = true;
		}
		if (string_0 != "")
		{
			txtComment.Lines = File.ReadAllLines(string_0);
		}
		else
		{
			txtComment.Text = string_2;
		}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			if (string_0 != "")
			{
				File.WriteAllText(string_0, txtComment.Text.Trim());
			}
			else
			{
				string_2 = txtComment.Text;
				int_0 = ((!F8BF5619.Checked) ? 1 : 0);
			}
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

	private void B3B7C7B8_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		int c639ED = ((!F8BF5619.Checked) ? 1 : 0);
		GClass8.smethod_60(txtComment, FFB22A8D, c639ED);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		GClass29.smethod_0(F7AB102E.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!"));
	}

	private void B09D0D0A_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHelpNhapComment());
	}

	private void BF30A50D(object sender, EventArgs e)
	{
		txtComment_TextChanged(null, null);
	}

	private void A594CE14_CheckedChanged(object sender, EventArgs e)
	{
		txtComment_TextChanged(null, null);
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && C421E902 != null)
		{
			C421E902.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		C421E902 = new System.ComponentModel.Container();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		panel1 = new System.Windows.Forms.Panel();
		B09D0D0A = new System.Windows.Forms.Button();
		button1 = new System.Windows.Forms.Button();
		A594CE14 = new System.Windows.Forms.RadioButton();
		F8BF5619 = new System.Windows.Forms.RadioButton();
		label9 = new System.Windows.Forms.Label();
		txtComment = new System.Windows.Forms.RichTextBox();
		A48ED88F = new System.Windows.Forms.Label();
		FFB22A8D = new System.Windows.Forms.Label();
		B3B7C7B8 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		E4A05BAC = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		A094FFA1 = new System.Windows.Forms.Button();
		B30C6600 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(C421E902);
		B1044F10 = new System.Windows.Forms.ToolTip(C421E902);
		panel1.SuspendLayout();
		bunifuCards2.SuspendLayout();
		E4A05BAC.SuspendLayout();
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
		panel1.Controls.Add(B09D0D0A);
		panel1.Controls.Add(button1);
		panel1.Controls.Add(A594CE14);
		panel1.Controls.Add(F8BF5619);
		panel1.Controls.Add(label9);
		panel1.Controls.Add(txtComment);
		panel1.Controls.Add(A48ED88F);
		panel1.Controls.Add(FFB22A8D);
		panel1.Controls.Add(B3B7C7B8);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards2);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(563, 355);
		panel1.TabIndex = 37;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		B09D0D0A.Cursor = System.Windows.Forms.Cursors.Help;
		B09D0D0A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B09D0D0A.Location = new System.Drawing.Point(237, 274);
		B09D0D0A.Name = "button3";
		B09D0D0A.Size = new System.Drawing.Size(21, 23);
		B09D0D0A.TabIndex = 198;
		B09D0D0A.Text = "?";
		B09D0D0A.UseVisualStyleBackColor = true;
		B09D0D0A.Click += new System.EventHandler(B09D0D0A_Click);
		button1.Cursor = System.Windows.Forms.Cursors.Help;
		button1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button1.Location = new System.Drawing.Point(237, 251);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(21, 23);
		button1.TabIndex = 199;
		button1.Text = "?";
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		A594CE14.AutoSize = true;
		A594CE14.Cursor = System.Windows.Forms.Cursors.Hand;
		A594CE14.Location = new System.Drawing.Point(78, 275);
		A594CE14.Name = "rbNganCachKyTu";
		A594CE14.Size = new System.Drawing.Size(159, 20);
		A594CE14.TabIndex = 197;
		A594CE14.Text = "Nội dung có nhiều dòng";
		A594CE14.UseVisualStyleBackColor = true;
		A594CE14.CheckedChanged += new System.EventHandler(A594CE14_CheckedChanged);
		F8BF5619.AutoSize = true;
		F8BF5619.Checked = true;
		F8BF5619.Cursor = System.Windows.Forms.Cursors.Hand;
		F8BF5619.Location = new System.Drawing.Point(78, 253);
		F8BF5619.Name = "rbNganCachMoiDong";
		F8BF5619.Size = new System.Drawing.Size(155, 20);
		F8BF5619.TabIndex = 196;
		F8BF5619.TabStop = true;
		F8BF5619.Text = "Nội dung chỉ có 1 dòng";
		F8BF5619.UseVisualStyleBackColor = true;
		F8BF5619.CheckedChanged += new System.EventHandler(BF30A50D);
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(13, 253);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(64, 16);
		label9.TabIndex = 195;
		label9.Text = "Tùy chọn:";
		txtComment.Location = new System.Drawing.Point(16, 64);
		txtComment.Name = "txtComment";
		txtComment.Size = new System.Drawing.Size(528, 186);
		txtComment.TabIndex = 50;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		A48ED88F.AutoSize = true;
		A48ED88F.Location = new System.Drawing.Point(404, 253);
		A48ED88F.Name = "lblFooter";
		A48ED88F.Size = new System.Drawing.Size(143, 16);
		A48ED88F.TabIndex = 49;
		A48ED88F.Text = "(Spin nội dung {a|b|c})";
		FFB22A8D.AutoSize = true;
		FFB22A8D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		FFB22A8D.Location = new System.Drawing.Point(13, 45);
		FFB22A8D.Name = "lblStatus";
		FFB22A8D.Size = new System.Drawing.Size(139, 16);
		FFB22A8D.TabIndex = 47;
		FFB22A8D.Text = "Nội dung bình luận (0):";
		B3B7C7B8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		B3B7C7B8.BackColor = System.Drawing.Color.Maroon;
		B3B7C7B8.Cursor = System.Windows.Forms.Cursors.Hand;
		B3B7C7B8.FlatAppearance.BorderSize = 0;
		B3B7C7B8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B3B7C7B8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B3B7C7B8.ForeColor = System.Drawing.Color.White;
		B3B7C7B8.Location = new System.Drawing.Point(287, 313);
		B3B7C7B8.Name = "btnCancel";
		B3B7C7B8.Size = new System.Drawing.Size(92, 29);
		B3B7C7B8.TabIndex = 46;
		B3B7C7B8.Text = "Đóng";
		B3B7C7B8.UseVisualStyleBackColor = false;
		B3B7C7B8.Click += new System.EventHandler(B3B7C7B8_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(183, 313);
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
		bunifuCards2.Controls.Add(E4A05BAC);
		bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards2.LeftSahddow = false;
		bunifuCards2.Location = new System.Drawing.Point(0, 0);
		bunifuCards2.Name = "bunifuCards2";
		bunifuCards2.RightSahddow = true;
		bunifuCards2.ShadowDepth = 20;
		bunifuCards2.Size = new System.Drawing.Size(561, 37);
		bunifuCards2.TabIndex = 43;
		E4A05BAC.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		E4A05BAC.BackColor = System.Drawing.Color.White;
		E4A05BAC.Controls.Add(button2);
		E4A05BAC.Controls.Add(pictureBox1);
		E4A05BAC.Controls.Add(A094FFA1);
		E4A05BAC.Controls.Add(B30C6600);
		E4A05BAC.Cursor = System.Windows.Forms.Cursors.SizeAll;
		E4A05BAC.Location = new System.Drawing.Point(0, 3);
		E4A05BAC.Name = "pnlHeader";
		E4A05BAC.Size = new System.Drawing.Size(561, 31);
		E4A05BAC.TabIndex = 9;
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
		A094FFA1.Cursor = System.Windows.Forms.Cursors.Hand;
		A094FFA1.FlatAppearance.BorderSize = 0;
		A094FFA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A094FFA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A094FFA1.ForeColor = System.Drawing.Color.White;
		A094FFA1.Location = new System.Drawing.Point(899, 1);
		A094FFA1.Name = "btnMinimize";
		A094FFA1.Size = new System.Drawing.Size(30, 30);
		A094FFA1.TabIndex = 9;
		A094FFA1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		A094FFA1.UseVisualStyleBackColor = true;
		B30C6600.BackColor = System.Drawing.Color.Transparent;
		B30C6600.Cursor = System.Windows.Forms.Cursors.SizeAll;
		B30C6600.Dock = System.Windows.Forms.DockStyle.Fill;
		B30C6600.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B30C6600.ForeColor = System.Drawing.Color.Black;
		B30C6600.Location = new System.Drawing.Point(0, 0);
		B30C6600.Name = "lblTitle";
		B30C6600.Size = new System.Drawing.Size(561, 31);
		B30C6600.TabIndex = 12;
		B30C6600.Text = "Nhập nội dung comment";
		B30C6600.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = B30C6600;
		bunifuDragControl_0.Vertical = true;
		B1044F10.AutomaticDelay = 0;
		B1044F10.AutoPopDelay = 10000;
		B1044F10.InitialDelay = 200;
		B1044F10.ReshowDelay = 40;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(563, 355);
		base.Controls.Add(panel1);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fNhapDuLieu3";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fNhapDuLieu3_Load);
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		bunifuCards2.ResumeLayout(false);
		E4A05BAC.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
	}
}
