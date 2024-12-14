using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class B586A01D : Form
{
	private IContainer E13CB41E = null;

	private BunifuCards E22E4829;

	private Panel D0B6E1B8;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip toolTip_0;

	private GroupBox groupBox2;

	public DataGridView dgvChuDe;

	private Label FB373A0F;

	private Label label7;

	private BunifuCards bunifuCards2;

	private Panel pnlHeader;

	private Button C6929D1E;

	private PictureBox pictureBox1;

	private Button btnMinimize;

	private BunifuCustomLabel BB8C43B9;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private ContextMenuStrip B32CD381;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem C62A652C;

	private ToolStripMenuItem EE12A119;

	private ToolStripMenuItem F9B9E636;

	public B586A01D()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		method_0();
	}

	private void method_0()
	{
		List<string> list = Class15.smethod_20();
		for (int i = 0; i < list.Count; i++)
		{
			dgvChuDe.Rows.Add(i + 1, list[i]);
		}
		FB373A0F.Text = list.Count().ToString();
	}

	private void EB0AB034(object sender, EventArgs e)
	{
		Close();
	}

	private void D0B6E1B8_Paint(object sender, PaintEventArgs e)
	{
	}

	private void C6929D1E_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void B21A990F(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fThemChuDe());
		dgvChuDe.Rows.Clear();
		method_0();
	}

	private void C62A652C_Click(object sender, EventArgs e)
	{
		string string_ = dgvChuDe.SelectedRows[0].Cells[1].Value.ToString();
		GClass8.smethod_33(new fSuaChuDe(string_));
		dgvChuDe.Rows.Clear();
		method_0();
	}

	private void EF8FC89D(object sender, EventArgs e)
	{
	}

	private void C59A36B4(object sender, EventArgs e)
	{
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void FE3F583F(object sender, EventArgs e)
	{
	}

	private void toolTip_0_Popup(object sender, PopupEventArgs e)
	{
	}

	private void EE12A119_Click(object sender, EventArgs e)
	{
		if (GClass29.smethod_1("Bạn có muốn xóa chủ đề này không?") == DialogResult.Yes)
		{
			string string_ = dgvChuDe.SelectedRows[0].Cells[1].Value.ToString();
			Class15.smethod_22(string_);
			Class15.smethod_23(string_);
			dgvChuDe.Rows.Clear();
			method_0();
		}
	}

	private void F9B9E636_Click(object sender, EventArgs e)
	{
		dgvChuDe.Rows.Clear();
		method_0();
	}

	private void dgvChuDe_Click(object sender, EventArgs e)
	{
	}

	private void F5AFDB28(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void C693EE21(object sender, EventArgs e)
	{
	}

	private void groupBox2_Enter(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool E13673A6)
	{
		if (E13673A6 && E13CB41E != null)
		{
			E13CB41E.Dispose();
		}
		base.Dispose(E13673A6);
	}

	private void InitializeComponent()
	{
		E13CB41E = new System.ComponentModel.Container();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		E22E4829 = new Bunifu.Framework.UI.BunifuCards();
		D0B6E1B8 = new System.Windows.Forms.Panel();
		bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		C6929D1E = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		BB8C43B9 = new Bunifu.Framework.UI.BunifuCustomLabel();
		groupBox2 = new System.Windows.Forms.GroupBox();
		FB373A0F = new System.Windows.Forms.Label();
		label7 = new System.Windows.Forms.Label();
		dgvChuDe = new System.Windows.Forms.DataGridView();
		dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		B32CD381 = new System.Windows.Forms.ContextMenuStrip(E13CB41E);
		toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		C62A652C = new System.Windows.Forms.ToolStripMenuItem();
		EE12A119 = new System.Windows.Forms.ToolStripMenuItem();
		F9B9E636 = new System.Windows.Forms.ToolStripMenuItem();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(E13CB41E);
		toolTip_0 = new System.Windows.Forms.ToolTip(E13CB41E);
		D0B6E1B8.SuspendLayout();
		bunifuCards2.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)dgvChuDe).BeginInit();
		B32CD381.SuspendLayout();
		SuspendLayout();
		E22E4829.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		E22E4829.BackColor = System.Drawing.Color.White;
		E22E4829.BorderRadius = 5;
		E22E4829.BottomSahddow = true;
		E22E4829.color = System.Drawing.Color.SaddleBrown;
		E22E4829.LeftSahddow = false;
		E22E4829.Location = new System.Drawing.Point(0, 0);
		E22E4829.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		E22E4829.Name = "bunifuCards1";
		E22E4829.RightSahddow = true;
		E22E4829.ShadowDepth = 20;
		E22E4829.Size = new System.Drawing.Size(0, 47);
		E22E4829.TabIndex = 12;
		D0B6E1B8.BackColor = System.Drawing.Color.White;
		D0B6E1B8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D0B6E1B8.Controls.Add(bunifuCards2);
		D0B6E1B8.Controls.Add(groupBox2);
		D0B6E1B8.Dock = System.Windows.Forms.DockStyle.Fill;
		D0B6E1B8.Location = new System.Drawing.Point(0, 0);
		D0B6E1B8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		D0B6E1B8.Name = "panel1";
		D0B6E1B8.Size = new System.Drawing.Size(329, 317);
		D0B6E1B8.TabIndex = 37;
		D0B6E1B8.Paint += new System.Windows.Forms.PaintEventHandler(D0B6E1B8_Paint);
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
		pnlHeader.Controls.Add(C6929D1E);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(BB8C43B9);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(327, 31);
		pnlHeader.TabIndex = 9;
		C6929D1E.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		C6929D1E.Cursor = System.Windows.Forms.Cursors.Hand;
		C6929D1E.FlatAppearance.BorderSize = 0;
		C6929D1E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C6929D1E.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C6929D1E.ForeColor = System.Drawing.Color.White;
		C6929D1E.Image = C50FB39E.ECB90B92;
		C6929D1E.Location = new System.Drawing.Point(296, 1);
		C6929D1E.Name = "button2";
		C6929D1E.Size = new System.Drawing.Size(30, 30);
		C6929D1E.TabIndex = 77;
		C6929D1E.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		C6929D1E.UseVisualStyleBackColor = true;
		C6929D1E.Click += new System.EventHandler(C6929D1E_Click);
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
		BB8C43B9.BackColor = System.Drawing.Color.Transparent;
		BB8C43B9.Cursor = System.Windows.Forms.Cursors.SizeAll;
		BB8C43B9.Dock = System.Windows.Forms.DockStyle.Fill;
		BB8C43B9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		BB8C43B9.ForeColor = System.Drawing.Color.Black;
		BB8C43B9.Location = new System.Drawing.Point(0, 0);
		BB8C43B9.Name = "bunifuCustomLabel1";
		BB8C43B9.Size = new System.Drawing.Size(327, 31);
		BB8C43B9.TabIndex = 12;
		BB8C43B9.Text = "Danh sách chủ đề";
		BB8C43B9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		groupBox2.BackColor = System.Drawing.Color.White;
		groupBox2.Controls.Add(FB373A0F);
		groupBox2.Controls.Add(label7);
		groupBox2.Controls.Add(dgvChuDe);
		groupBox2.Location = new System.Drawing.Point(6, 40);
		groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
		groupBox2.Name = "groupBox2";
		groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
		groupBox2.Size = new System.Drawing.Size(311, 269);
		groupBox2.TabIndex = 41;
		groupBox2.TabStop = false;
		groupBox2.Text = "Danh sách chủ đề";
		groupBox2.Enter += new System.EventHandler(groupBox2_Enter);
		FB373A0F.AutoSize = true;
		FB373A0F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		FB373A0F.ForeColor = System.Drawing.Color.Blue;
		FB373A0F.Location = new System.Drawing.Point(273, 248);
		FB373A0F.Name = "lblCountChuDe";
		FB373A0F.Size = new System.Drawing.Size(16, 16);
		FB373A0F.TabIndex = 78;
		FB373A0F.Text = "0";
		FB373A0F.Click += new System.EventHandler(C59A36B4);
		label7.AutoSize = true;
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		label7.Location = new System.Drawing.Point(231, 248);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(44, 16);
		label7.TabIndex = 79;
		label7.Text = "Tổng:";
		label7.Click += new System.EventHandler(EF8FC89D);
		dgvChuDe.AllowUserToAddRows = false;
		dgvChuDe.AllowUserToDeleteRows = false;
		dgvChuDe.AllowUserToResizeRows = false;
		dgvChuDe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		dgvChuDe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		dgvChuDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dgvChuDe.Columns.AddRange(dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn4);
		dgvChuDe.ContextMenuStrip = B32CD381;
		dgvChuDe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		dgvChuDe.Location = new System.Drawing.Point(9, 23);
		dgvChuDe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		dgvChuDe.MultiSelect = false;
		dgvChuDe.Name = "dgvChuDe";
		dgvChuDe.RowHeadersVisible = false;
		dgvChuDe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		dgvChuDe.Size = new System.Drawing.Size(293, 221);
		dgvChuDe.TabIndex = 76;
		dgvChuDe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(F5AFDB28);
		dgvChuDe.Click += new System.EventHandler(dgvChuDe_Click);
		dataGridViewTextBoxColumn1.HeaderText = "STT";
		dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
		dataGridViewTextBoxColumn1.Width = 35;
		dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn4.HeaderText = "Tên chủ đề";
		dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
		B32CD381.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] { toolStripMenuItem_0, C62A652C, EE12A119, F9B9E636 });
		B32CD381.Name = "contextMenuStrip1";
		B32CD381.Size = new System.Drawing.Size(179, 92);
		toolStripMenuItem_0.Name = "thêmMớiToolStripMenuItem";
		toolStripMenuItem_0.Size = new System.Drawing.Size(178, 22);
		toolStripMenuItem_0.Text = "Thêm chủ đề";
		toolStripMenuItem_0.Click += new System.EventHandler(B21A990F);
		C62A652C.Name = "sửaToolStripMenuItem";
		C62A652C.Size = new System.Drawing.Size(178, 22);
		C62A652C.Text = "Sửa tên chủ đề";
		C62A652C.Click += new System.EventHandler(C62A652C_Click);
		EE12A119.Name = "xóaToolStripMenuItem";
		EE12A119.Size = new System.Drawing.Size(178, 22);
		EE12A119.Text = "Xóa chủ đề";
		EE12A119.Click += new System.EventHandler(EE12A119_Click);
		F9B9E636.Name = "tảiLạiToolStripMenuItem";
		F9B9E636.Size = new System.Drawing.Size(178, 22);
		F9B9E636.Text = "Làm mới danh sách";
		F9B9E636.Click += new System.EventHandler(F9B9E636_Click);
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = BB8C43B9;
		bunifuDragControl_0.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		toolTip_0.Popup += new System.Windows.Forms.PopupEventHandler(toolTip_0_Popup);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(329, 317);
		base.Controls.Add(D0B6E1B8);
		base.Controls.Add(E22E4829);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fDanhSachChuDe";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(C693EE21);
		D0B6E1B8.ResumeLayout(false);
		bunifuCards2.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		groupBox2.ResumeLayout(false);
		groupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)dgvChuDe).EndInit();
		B32CD381.ResumeLayout(false);
		ResumeLayout(false);
	}
}
