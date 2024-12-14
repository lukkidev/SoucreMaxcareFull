using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fSuaChuDe : Form
{
	private IContainer icontainer_0 = null;

	private BunifuCards CFA15207;

	private Panel panel1;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip toolTip_0;

	private BunifuCards bunifuCards2;

	private Panel pnlHeader;

	private Button button2;

	private PictureBox pictureBox1;

	private Button btnMinimize;

	private BunifuCustomLabel bunifuCustomLabel1;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private Label D72BE795;

	private Button btnCancel;

	private Button BC27FC39;

	private TextBox E1A5DF8F;

	private Label label1;

	private TextBox D03FC8A0;

	public fSuaChuDe(string string_0)
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		D03FC8A0.Text = string_0;
	}

	private void fSuaChuDe_Load(object sender, EventArgs e)
	{
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void A8BB0F13(object sender, EventArgs e)
	{
		Close();
	}

	private void DC0E1BA6(object sender, EventArgs e)
	{
	}

	private void BC27FC39_Click(object sender, EventArgs e)
	{
		List<string> list = Class15.smethod_20();
		string string_ = D03FC8A0.Text;
		string text = E1A5DF8F.Text;
		if (text == "")
		{
			GClass29.smethod_0("Vui lòng nhập tên chủ đề mới!", 2);
		}
		else if (!list.Contains(text))
		{
			Class15.smethod_24(string_, text);
			if (GClass29.smethod_1("Cập nhật thành công, bạn có muốn đóng cửa sổ?") == DialogResult.Yes)
			{
				Close();
			}
		}
		else
		{
			GClass29.smethod_0("Tên chủ đề đã tồn tại, vui lòng đổi tên khác!", 2);
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fSuaChuDe_FormClosing(object sender, FormClosingEventArgs e)
	{
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
		CFA15207 = new Bunifu.Framework.UI.BunifuCards();
		panel1 = new System.Windows.Forms.Panel();
		label1 = new System.Windows.Forms.Label();
		D72BE795 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		D03FC8A0 = new System.Windows.Forms.TextBox();
		BC27FC39 = new System.Windows.Forms.Button();
		E1A5DF8F = new System.Windows.Forms.TextBox();
		bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(icontainer_0);
		toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		toolTip_0 = new System.Windows.Forms.ToolTip(icontainer_0);
		panel1.SuspendLayout();
		bunifuCards2.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		contextMenuStrip1.SuspendLayout();
		SuspendLayout();
		CFA15207.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		CFA15207.BackColor = System.Drawing.Color.White;
		CFA15207.BorderRadius = 5;
		CFA15207.BottomSahddow = true;
		CFA15207.color = System.Drawing.Color.SaddleBrown;
		CFA15207.LeftSahddow = false;
		CFA15207.Location = new System.Drawing.Point(0, 0);
		CFA15207.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		CFA15207.Name = "bunifuCards1";
		CFA15207.RightSahddow = true;
		CFA15207.ShadowDepth = 20;
		CFA15207.Size = new System.Drawing.Size(0, 47);
		CFA15207.TabIndex = 12;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(label1);
		panel1.Controls.Add(D72BE795);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(D03FC8A0);
		panel1.Controls.Add(BC27FC39);
		panel1.Controls.Add(E1A5DF8F);
		panel1.Controls.Add(bunifuCards2);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(329, 164);
		panel1.TabIndex = 37;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		label1.AutoSize = true;
		label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label1.Location = new System.Drawing.Point(28, 49);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(94, 16);
		label1.TabIndex = 47;
		label1.Text = "Tên chủ đề cũ:";
		D72BE795.AutoSize = true;
		D72BE795.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		D72BE795.Location = new System.Drawing.Point(28, 78);
		D72BE795.Name = "label2";
		D72BE795.Size = new System.Drawing.Size(102, 16);
		D72BE795.TabIndex = 47;
		D72BE795.Text = "Tên chủ đề mới:";
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(173, 116);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 46;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		D03FC8A0.Lines = new string[0];
		D03FC8A0.Location = new System.Drawing.Point(138, 46);
		D03FC8A0.MaxLength = 32767;
		D03FC8A0.Name = "txtChude";
		D03FC8A0.PasswordChar = '\0';
		D03FC8A0.ReadOnly = true;
		D03FC8A0.ScrollBars = System.Windows.Forms.ScrollBars.None;
		D03FC8A0.SelectedText = "";
		D03FC8A0.SelectionLength = 0;
		D03FC8A0.SelectionStart = 0;
		D03FC8A0.ShortcutsEnabled = true;
		D03FC8A0.Size = new System.Drawing.Size(153, 23);
		D03FC8A0.TabIndex = 44;
		BC27FC39.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		BC27FC39.Cursor = System.Windows.Forms.Cursors.Hand;
		BC27FC39.FlatAppearance.BorderSize = 0;
		BC27FC39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BC27FC39.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		BC27FC39.ForeColor = System.Drawing.Color.White;
		BC27FC39.Location = new System.Drawing.Point(69, 116);
		BC27FC39.Name = "btnAdd";
		BC27FC39.Size = new System.Drawing.Size(92, 29);
		BC27FC39.TabIndex = 45;
		BC27FC39.Text = "Cập nhật";
		BC27FC39.UseVisualStyleBackColor = false;
		BC27FC39.Click += new System.EventHandler(BC27FC39_Click);
		E1A5DF8F.Lines = new string[0];
		E1A5DF8F.Location = new System.Drawing.Point(138, 75);
		E1A5DF8F.MaxLength = 32767;
		E1A5DF8F.Name = "txtNewChuDe";
		E1A5DF8F.PasswordChar = '\0';
		E1A5DF8F.ScrollBars = System.Windows.Forms.ScrollBars.None;
		E1A5DF8F.SelectedText = "";
		E1A5DF8F.SelectionLength = 0;
		E1A5DF8F.SelectionStart = 0;
		E1A5DF8F.ShortcutsEnabled = true;
		E1A5DF8F.Size = new System.Drawing.Size(153, 23);
		E1A5DF8F.TabIndex = 44;
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
		bunifuCards2.Size = new System.Drawing.Size(327, 37);
		bunifuCards2.TabIndex = 43;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button2);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(327, 31);
		pnlHeader.TabIndex = 9;
		button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button2.ForeColor = System.Drawing.Color.White;
		button2.Image = C50FB39E.Bitmap_12;
		button2.Location = new System.Drawing.Point(296, 1);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(A8BB0F13);
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
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(327, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cập nhật chủ đề";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { toolStripMenuItem_0, toolStripMenuItem_1, toolStripMenuItem_2 });
		contextMenuStrip1.Name = "contextMenuStrip1";
		contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
		toolStripMenuItem_0.Name = "thêmMớiToolStripMenuItem";
		toolStripMenuItem_0.Size = new System.Drawing.Size(152, 22);
		toolStripMenuItem_0.Text = "Thêm chủ đề";
		toolStripMenuItem_1.Name = "sửaToolStripMenuItem";
		toolStripMenuItem_1.Size = new System.Drawing.Size(152, 22);
		toolStripMenuItem_1.Text = "Sửa tên chủ đề";
		toolStripMenuItem_2.Name = "xóaToolStripMenuItem";
		toolStripMenuItem_2.Size = new System.Drawing.Size(152, 22);
		toolStripMenuItem_2.Text = "Xóa chủ đề";
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(329, 164);
		base.Controls.Add(panel1);
		base.Controls.Add(CFA15207);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fSuaChuDe";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(fSuaChuDe_FormClosing);
		base.Load += new System.EventHandler(fSuaChuDe_Load);
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		bunifuCards2.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		contextMenuStrip1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
