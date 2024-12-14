using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fChiTietBaiViet : Form
{
	private IContainer F594750C = null;

	private BunifuCards FE8DC4B0;

	private Panel panel1;

	private BunifuDragControl F93E3B93;

	private ToolTip BD07A802;

	private BunifuCards bunifuCards2;

	private Panel F298CE00;

	private Button button2;

	private PictureBox pictureBox1;

	private Button btnMinimize;

	private BunifuCustomLabel bunifuCustomLabel1;

	private ContextMenuStrip E287C1AD;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private Label lblNanh;

	private DataGridView C181EF0B;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private TextBox B3A59E2D;

	private Label label5;

	private TextBox A4335123;

	private Label label4;

	private Label label2;

	private TextBox txtName;

	public fChiTietBaiViet(int int_0)
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		List<BBA6CAB0> list = Class15.smethod_19(int_0.ToString());
		foreach (BBA6CAB0 item in list)
		{
			B3A59E2D.Text = item.String_0;
			txtName.Text = item.BA2E9E33;
			A4335123.Text = item.String_1;
			string[] array = item.EF0AA8B3.Split('|');
			lblNanh.Text = "Ảnh (" + (array.Length - 1) + "):";
			item.D52B6012.Split('|');
			for (int i = 0; i < array.Length - 1; i++)
			{
				C181EF0B.Rows.Add(array[i]);
			}
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		Close();
	}

	private void fChiTietBaiViet_Load(object sender, EventArgs e)
	{
	}

	private void CB294BB2(object sender, EventArgs e)
	{
	}

	private void FF366C92(object sender, PaintEventArgs e)
	{
	}

	private void B10F58AA(object sender, EventArgs e)
	{
		Close();
	}

	private void F7B3AF02(object sender, EventArgs e)
	{
	}

	private void D7844D88(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			Process.Start(C181EF0B.SelectedRows[0].Cells[0].Value.ToString());
		}
		catch (Exception)
		{
			GClass29.smethod_0("Link ảnh không tồn tại!");
		}
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void method_2(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void CC01AB31(object sender, DataGridViewCellEventArgs e)
	{
	}

	protected override void Dispose(bool C7BC0509)
	{
		if (C7BC0509 && F594750C != null)
		{
			F594750C.Dispose();
		}
		base.Dispose(C7BC0509);
	}

	private void InitializeComponent()
	{
		F594750C = new System.ComponentModel.Container();
		FE8DC4B0 = new Bunifu.Framework.UI.BunifuCards();
		panel1 = new System.Windows.Forms.Panel();
		lblNanh = new System.Windows.Forms.Label();
		bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		F298CE00 = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		C181EF0B = new System.Windows.Forms.DataGridView();
		dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		B3A59E2D = new System.Windows.Forms.TextBox();
		label5 = new System.Windows.Forms.Label();
		A4335123 = new System.Windows.Forms.TextBox();
		label4 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		txtName = new System.Windows.Forms.TextBox();
		E287C1AD = new System.Windows.Forms.ContextMenuStrip(F594750C);
		toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		F93E3B93 = new Bunifu.Framework.UI.BunifuDragControl(F594750C);
		BD07A802 = new System.Windows.Forms.ToolTip(F594750C);
		panel1.SuspendLayout();
		bunifuCards2.SuspendLayout();
		F298CE00.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)C181EF0B).BeginInit();
		E287C1AD.SuspendLayout();
		SuspendLayout();
		FE8DC4B0.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		FE8DC4B0.BackColor = System.Drawing.Color.White;
		FE8DC4B0.BorderRadius = 5;
		FE8DC4B0.BottomSahddow = true;
		FE8DC4B0.color = System.Drawing.Color.SaddleBrown;
		FE8DC4B0.LeftSahddow = false;
		FE8DC4B0.Location = new System.Drawing.Point(0, 0);
		FE8DC4B0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		FE8DC4B0.Name = "bunifuCards1";
		FE8DC4B0.RightSahddow = true;
		FE8DC4B0.ShadowDepth = 20;
		FE8DC4B0.Size = new System.Drawing.Size(36, 47);
		FE8DC4B0.TabIndex = 12;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(lblNanh);
		panel1.Controls.Add(bunifuCards2);
		panel1.Controls.Add(C181EF0B);
		panel1.Controls.Add(B3A59E2D);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(A4335123);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(txtName);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(365, 342);
		panel1.TabIndex = 37;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(FF366C92);
		lblNanh.AutoSize = true;
		lblNanh.Location = new System.Drawing.Point(6, 100);
		lblNanh.Name = "lblNanh";
		lblNanh.Size = new System.Drawing.Size(56, 16);
		lblNanh.TabIndex = 50;
		lblNanh.Text = "Ảnh (0):";
		lblNanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuCards2.BackColor = System.Drawing.Color.White;
		bunifuCards2.BorderRadius = 0;
		bunifuCards2.BottomSahddow = true;
		bunifuCards2.color = System.Drawing.Color.SaddleBrown;
		bunifuCards2.Controls.Add(F298CE00);
		bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards2.LeftSahddow = false;
		bunifuCards2.Location = new System.Drawing.Point(0, 0);
		bunifuCards2.Name = "bunifuCards2";
		bunifuCards2.RightSahddow = true;
		bunifuCards2.ShadowDepth = 20;
		bunifuCards2.Size = new System.Drawing.Size(363, 37);
		bunifuCards2.TabIndex = 43;
		F298CE00.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		F298CE00.BackColor = System.Drawing.Color.White;
		F298CE00.Controls.Add(button2);
		F298CE00.Controls.Add(pictureBox1);
		F298CE00.Controls.Add(btnMinimize);
		F298CE00.Controls.Add(bunifuCustomLabel1);
		F298CE00.Cursor = System.Windows.Forms.Cursors.SizeAll;
		F298CE00.Location = new System.Drawing.Point(0, 3);
		F298CE00.Name = "pnlHeader";
		F298CE00.Size = new System.Drawing.Size(363, 31);
		F298CE00.TabIndex = 9;
		button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button2.ForeColor = System.Drawing.Color.White;
		button2.Image = C50FB39E.Bitmap_12;
		button2.Location = new System.Drawing.Point(332, 1);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(B10F58AA);
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(363, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Chi tiết bài viết";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C181EF0B.AllowUserToAddRows = false;
		C181EF0B.AllowUserToDeleteRows = false;
		C181EF0B.AllowUserToResizeColumns = false;
		C181EF0B.AllowUserToResizeRows = false;
		C181EF0B.BackgroundColor = System.Drawing.Color.White;
		C181EF0B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		C181EF0B.ColumnHeadersVisible = false;
		C181EF0B.Columns.AddRange(dataGridViewTextBoxColumn4);
		C181EF0B.Cursor = System.Windows.Forms.Cursors.Hand;
		C181EF0B.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		C181EF0B.Location = new System.Drawing.Point(85, 97);
		C181EF0B.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		C181EF0B.Name = "dgvPic";
		C181EF0B.RowHeadersVisible = false;
		C181EF0B.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		C181EF0B.Size = new System.Drawing.Size(270, 76);
		C181EF0B.TabIndex = 42;
		C181EF0B.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(CC01AB31);
		C181EF0B.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(D7844D88);
		dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn4.DataPropertyName = "Day";
		dataGridViewTextBoxColumn4.FillWeight = 57.38708f;
		dataGridViewTextBoxColumn4.HeaderText = "Đường dẫn";
		dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
		B3A59E2D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B3A59E2D.Location = new System.Drawing.Point(85, 41);
		B3A59E2D.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		B3A59E2D.Name = "txtChuDe";
		B3A59E2D.ReadOnly = true;
		B3A59E2D.Size = new System.Drawing.Size(270, 23);
		B3A59E2D.TabIndex = 46;
		label5.AutoSize = true;
		label5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label5.ForeColor = System.Drawing.SystemColors.ControlText;
		label5.Location = new System.Drawing.Point(6, 72);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(56, 16);
		label5.TabIndex = 44;
		label5.Text = "Tiêu đề:";
		label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		A4335123.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A4335123.Location = new System.Drawing.Point(85, 181);
		A4335123.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		A4335123.Multiline = true;
		A4335123.Name = "txtConten";
		A4335123.ReadOnly = true;
		A4335123.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		A4335123.Size = new System.Drawing.Size(270, 149);
		A4335123.TabIndex = 48;
		A4335123.WordWrap = false;
		label4.AutoSize = true;
		label4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label4.ForeColor = System.Drawing.SystemColors.ControlText;
		label4.Location = new System.Drawing.Point(6, 44);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(53, 16);
		label4.TabIndex = 43;
		label4.Text = "Chủ đề:";
		label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label2.ForeColor = System.Drawing.SystemColors.ControlText;
		label2.Location = new System.Drawing.Point(6, 184);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(63, 16);
		label2.TabIndex = 45;
		label2.Text = "Nội dung:";
		label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		txtName.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		txtName.Location = new System.Drawing.Point(85, 69);
		txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		txtName.Name = "txtName";
		txtName.ReadOnly = true;
		txtName.Size = new System.Drawing.Size(270, 23);
		txtName.TabIndex = 47;
		E287C1AD.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { toolStripMenuItem_0, toolStripMenuItem_1, toolStripMenuItem_2 });
		E287C1AD.Name = "contextMenuStrip1";
		E287C1AD.Size = new System.Drawing.Size(153, 70);
		toolStripMenuItem_0.Name = "thêmMớiToolStripMenuItem";
		toolStripMenuItem_0.Size = new System.Drawing.Size(152, 22);
		toolStripMenuItem_0.Text = "Thêm chủ đề";
		toolStripMenuItem_1.Name = "sửaToolStripMenuItem";
		toolStripMenuItem_1.Size = new System.Drawing.Size(152, 22);
		toolStripMenuItem_1.Text = "Sửa tên chủ đề";
		toolStripMenuItem_2.Name = "xóaToolStripMenuItem";
		toolStripMenuItem_2.Size = new System.Drawing.Size(152, 22);
		toolStripMenuItem_2.Text = "Xóa chủ đề";
		F93E3B93.Fixed = true;
		F93E3B93.Horizontal = true;
		F93E3B93.TargetControl = bunifuCustomLabel1;
		F93E3B93.Vertical = true;
		BD07A802.AutomaticDelay = 0;
		BD07A802.AutoPopDelay = 10000;
		BD07A802.InitialDelay = 200;
		BD07A802.ReshowDelay = 40;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(365, 342);
		base.Controls.Add(panel1);
		base.Controls.Add(FE8DC4B0);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fChiTietBaiViet";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fChiTietBaiViet_Load);
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		bunifuCards2.ResumeLayout(false);
		F298CE00.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)C181EF0B).EndInit();
		E287C1AD.ResumeLayout(false);
		ResumeLayout(false);
	}
}
