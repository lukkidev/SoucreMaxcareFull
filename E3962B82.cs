using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class E3962B82 : Form
{
	private IContainer D71FDB86 = null;

	private BunifuCards bunifuCards1;

	private Panel F2A5661E;

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

	private ToolStripMenuItem A988A8BC;

	private ToolStripMenuItem toolStripMenuItem_1;

	private DataGridView F00DC0B8;

	private DataGridViewTextBoxColumn cSTT;

	private DataGridViewTextBoxColumn cTuKhoa;

	private DataGridViewImageColumn cNoiDung;

	public E3962B82()
	{
		D0206181();
		F7AB102E.D6B70A35(this);
		method_0();
	}

	private void AC9D4F84()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		foreach (DataGridViewColumn column in F00DC0B8.Columns)
		{
			F7AB102E.smethod_3(column);
		}
	}

	private void method_0()
	{
		new Random();
		F00DC0B8.Rows.Add(F00DC0B8.RowCount + 1, "[r1]", C50FB39E.Bitmap_50);
		F00DC0B8.Rows.Add(F00DC0B8.RowCount + 1, "[r2]", C50FB39E.Bitmap_51);
		F00DC0B8.Rows.Add(F00DC0B8.RowCount + 1, "[r3]", C50FB39E.C4A41925);
		F00DC0B8.Rows.Add(F00DC0B8.RowCount + 1, "[r4]", C50FB39E.AA3B5992);
		F00DC0B8.Rows.Add(F00DC0B8.RowCount + 1, "[r5]", C50FB39E.B92D01A3);
		F00DC0B8.Rows.Add(F00DC0B8.RowCount + 1, "[r6]", C50FB39E.Bitmap_52);
		F00DC0B8.Rows.Add(F00DC0B8.RowCount + 1, "[r7]", C50FB39E.F93DCDAE);
		F00DC0B8.Rows.Add(F00DC0B8.RowCount + 1, "[r8]", C50FB39E.Bitmap_53);
		F00DC0B8.Rows.Add(F00DC0B8.RowCount + 1, "[d]", C50FB39E.F731AF8A);
		F00DC0B8.Rows.Add(F00DC0B8.RowCount + 1, "[t]", C50FB39E.Bitmap_54);
		F00DC0B8.Rows.Add(F00DC0B8.RowCount + 1, "[n*]", C50FB39E.Bitmap_55);
		F00DC0B8.Rows.Add(F00DC0B8.RowCount + 1, "[s*]", C50FB39E.B6980B29);
		F00DC0B8.Rows.Add(F00DC0B8.RowCount + 1, "[q***]", C50FB39E.FD0CF90E);
	}

	private void D089C5B8(object sender, EventArgs e)
	{
	}

	private void BF292C3A(object sender, PaintEventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	protected override void Dispose(bool D9AAC00E)
	{
		if (D9AAC00E && D71FDB86 != null)
		{
			D71FDB86.Dispose();
		}
		base.Dispose(D9AAC00E);
	}

	private void D0206181()
	{
		D71FDB86 = new Container();
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		bunifuCards1 = new BunifuCards();
		F2A5661E = new Panel();
		F00DC0B8 = new DataGridView();
		cSTT = new DataGridViewTextBoxColumn();
		cTuKhoa = new DataGridViewTextBoxColumn();
		cNoiDung = new DataGridViewImageColumn();
		bunifuCards2 = new BunifuCards();
		pnlHeader = new Panel();
		button2 = new Button();
		pictureBox1 = new PictureBox();
		btnMinimize = new Button();
		bunifuCustomLabel1 = new BunifuCustomLabel();
		contextMenuStrip1 = new ContextMenuStrip(D71FDB86);
		toolStripMenuItem_0 = new ToolStripMenuItem();
		A988A8BC = new ToolStripMenuItem();
		toolStripMenuItem_1 = new ToolStripMenuItem();
		bunifuDragControl_0 = new BunifuDragControl(D71FDB86);
		toolTip_0 = new ToolTip(D71FDB86);
		F2A5661E.SuspendLayout();
		((ISupportInitialize)F00DC0B8).BeginInit();
		bunifuCards2.SuspendLayout();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		contextMenuStrip1.SuspendLayout();
		SuspendLayout();
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 5;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.SaddleBrown;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(0, 0);
		bunifuCards1.Margin = new Padding(3, 4, 3, 4);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(243, 47);
		bunifuCards1.TabIndex = 12;
		F2A5661E.BackColor = Color.White;
		F2A5661E.BorderStyle = BorderStyle.FixedSingle;
		F2A5661E.Controls.Add(F00DC0B8);
		F2A5661E.Controls.Add(bunifuCards2);
		F2A5661E.Dock = DockStyle.Fill;
		F2A5661E.Location = new Point(0, 0);
		F2A5661E.Margin = new Padding(3, 4, 3, 4);
		F2A5661E.Name = "panel1";
		F2A5661E.Size = new Size(572, 503);
		F2A5661E.TabIndex = 37;
		F2A5661E.Paint += BF292C3A;
		F00DC0B8.AllowUserToAddRows = false;
		F00DC0B8.AllowUserToDeleteRows = false;
		F00DC0B8.AllowUserToResizeRows = false;
		F00DC0B8.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
		F00DC0B8.BackgroundColor = Color.White;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = SystemColors.Control;
		dataGridViewCellStyle.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		F00DC0B8.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		F00DC0B8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		F00DC0B8.Columns.AddRange(cSTT, cTuKhoa, cNoiDung);
		F00DC0B8.Location = new Point(11, 43);
		F00DC0B8.Name = "dgv";
		F00DC0B8.ReadOnly = true;
		F00DC0B8.RowHeadersVisible = false;
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.ForeColor = Color.Black;
		dataGridViewCellStyle2.SelectionBackColor = Color.White;
		dataGridViewCellStyle2.SelectionForeColor = Color.Black;
		F00DC0B8.RowsDefaultCellStyle = dataGridViewCellStyle2;
		F00DC0B8.RowTemplate.Resizable = DataGridViewTriState.True;
		F00DC0B8.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		F00DC0B8.Size = new Size(547, 447);
		F00DC0B8.TabIndex = 75;
		cSTT.HeaderText = "STT";
		cSTT.Name = "cSTT";
		cSTT.ReadOnly = true;
		cSTT.SortMode = DataGridViewColumnSortMode.NotSortable;
		cSTT.Width = 40;
		cTuKhoa.HeaderText = "Từ khóa";
		cTuKhoa.Name = "cTuKhoa";
		cTuKhoa.ReadOnly = true;
		cTuKhoa.Width = 80;
		cNoiDung.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		cNoiDung.HeaderText = "Nội dung random";
		cNoiDung.Name = "cNoiDung";
		cNoiDung.ReadOnly = true;
		cNoiDung.Resizable = DataGridViewTriState.True;
		cNoiDung.SortMode = DataGridViewColumnSortMode.Automatic;
		bunifuCards2.BackColor = Color.White;
		bunifuCards2.BorderRadius = 0;
		bunifuCards2.BottomSahddow = true;
		bunifuCards2.color = Color.SaddleBrown;
		bunifuCards2.Controls.Add(pnlHeader);
		bunifuCards2.Dock = DockStyle.Top;
		bunifuCards2.LeftSahddow = false;
		bunifuCards2.Location = new Point(0, 0);
		bunifuCards2.Name = "bunifuCards2";
		bunifuCards2.RightSahddow = true;
		bunifuCards2.ShadowDepth = 20;
		bunifuCards2.Size = new Size(570, 37);
		bunifuCards2.TabIndex = 43;
		pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button2);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(570, 31);
		pnlHeader.TabIndex = 9;
		button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button2.Cursor = Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = FlatStyle.Flat;
		button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button2.ForeColor = Color.White;
		button2.Image = C50FB39E.Bitmap_12;
		button2.Location = new Point(539, 1);
		button2.Name = "button2";
		button2.Size = new Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += button2_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		btnMinimize.Cursor = Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = FlatStyle.Flat;
		btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = Color.White;
		btnMinimize.Location = new Point(899, 1);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new Size(30, 30);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(570, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Hướng dẫn random nội dung";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		contextMenuStrip1.Items.AddRange(new ToolStripItem[3] { toolStripMenuItem_0, A988A8BC, toolStripMenuItem_1 });
		contextMenuStrip1.Name = "contextMenuStrip1";
		contextMenuStrip1.Size = new Size(153, 70);
		toolStripMenuItem_0.Name = "thêmMớiToolStripMenuItem";
		toolStripMenuItem_0.Size = new Size(152, 22);
		toolStripMenuItem_0.Text = "Thêm chủ đề";
		A988A8BC.Name = "sửaToolStripMenuItem";
		A988A8BC.Size = new Size(152, 22);
		A988A8BC.Text = "Sửa tên chủ đề";
		toolStripMenuItem_1.Name = "xóaToolStripMenuItem";
		toolStripMenuItem_1.Size = new Size(152, 22);
		toolStripMenuItem_1.Text = "Xóa chủ đề";
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(572, 503);
		base.Controls.Add(F2A5661E);
		base.Controls.Add(bunifuCards1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHuongDanRandom";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Cấu hình chung";
		base.Load += D089C5B8;
		F2A5661E.ResumeLayout(performLayout: false);
		((ISupportInitialize)F00DC0B8).EndInit();
		bunifuCards2.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		contextMenuStrip1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
