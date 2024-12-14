using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fSuaBaiViet : Form
{
	private int int_0;

	private IContainer icontainer_0 = null;

	private BunifuCards CE09D512;

	private Panel panel1;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip toolTip_0;

	private ContextMenuStrip F82A5E27;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem F3BB60BE;

	private ToolStripMenuItem toolStripMenuItem_1;

	private Label label1;

	private ComboBox cbbChuDe;

	private BunifuCards DEB97691;

	private Panel pnlHeader;

	private Button button2;

	private PictureBox D30C9CA2;

	private BunifuCustomLabel CF1E831F;

	private Label lblNanh;

	private DataGridView dgvPic;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private TextBox txtName;

	private Label label2;

	private Label label5;

	private Button btnCancel;

	private Button A8AB339C;

	private Button EC860028;

	private Button EEBB072C;

	private Label D5B40B27;

	private RichTextBox A3B251BD;

	public fSuaBaiViet(int int_1)
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		method_0();
		int_0 = int_1;
		List<BBA6CAB0> list = Class15.smethod_19(int_1.ToString());
		foreach (BBA6CAB0 item in list)
		{
			cbbChuDe.Text = item.String_0;
			txtName.Text = item.BA2E9E33;
			A3B251BD.Text = item.String_1;
			string[] array = item.EF0AA8B3.Split('|');
			lblNanh.Text = "Ảnh (" + (array.Length - 1) + "):";
			item.D52B6012.Split('|');
			for (int i = 0; i < array.Length - 1; i++)
			{
				dgvPic.Rows.Add(array[i]);
			}
		}
	}

	private void method_0()
	{
		List<string> list = Class15.smethod_20();
		for (int i = 0; i < list.Count; i++)
		{
			cbbChuDe.Items.Add(list[i]);
		}
		try
		{
			cbbChuDe.SelectedIndex = 0;
		}
		catch
		{
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		Close();
	}

	private void fSuaBaiViet_Load(object sender, EventArgs e)
	{
	}

	private void BD2D9D97(object sender, EventArgs e)
	{
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C4AA6910(object sender, EventArgs e)
	{
		if (txtName.Text != "")
		{
			string text = "";
			if (dgvPic.Rows.Count != 0)
			{
				for (int i = 0; i < dgvPic.Rows.Count; i++)
				{
					text = text + dgvPic.Rows[i].Cells[0].Value.ToString() + "|";
				}
			}
			string d52B = "";
			BBA6CAB0 bba6CAB0_ = new BBA6CAB0
			{
				BA2E9E33 = txtName.Text,
				EF0AA8B3 = text,
				D52B6012 = d52B,
				String_1 = A3B251BD.Text
			};
			Class15.B200A787(int_0, bba6CAB0_);
			if (GClass29.smethod_1("Cập nhập thành công. Bạn có muốn thoát?") == DialogResult.Yes)
			{
				Close();
			}
		}
		else
		{
			GClass29.smethod_0("Chưa nhập tiêu đề");
		}
	}

	private void E79AB784(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
		openFileDialog.FilterIndex = 0;
		openFileDialog.Multiselect = true;
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			string[] fileNames = openFileDialog.FileNames;
			for (int i = 0; i < fileNames.Length; i++)
			{
				dgvPic.Rows.Add(fileNames[i]);
			}
			lblNanh.Text = "Ảnh (" + dgvPic.Rows.Count + "):";
		}
	}

	private void D210F404(object sender, EventArgs e)
	{
		foreach (DataGridViewRow selectedRow in dgvPic.SelectedRows)
		{
			dgvPic.Rows.RemoveAt(selectedRow.Index);
		}
		lblNanh.Text = "Ảnh (" + dgvPic.Rows.Count + "):";
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void AD183097(object sender, DataGridViewCellEventArgs e)
	{
		Process.Start(dgvPic.SelectedRows[0].Cells[0].Value.ToString());
	}

	private void cbbChuDe_Click(object sender, EventArgs e)
	{
	}

	private void fSuaBaiViet_FormClosed(object sender, FormClosedEventArgs e)
	{
		List<string> F5A94B = new List<string>();
		new fChonBaiViet(ref F5A94B);
	}

	private void A493D02B(object sender, EventArgs e)
	{
	}

	private void method_2(object sender, EventArgs e)
	{
		GClass8.smethod_33(new B586A01D());
		cbbChuDe.Items.Clear();
		method_0();
	}

	private void method_3(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.smethod_33(new E3962B82());
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
		CE09D512 = new Bunifu.Framework.UI.BunifuCards();
		panel1 = new System.Windows.Forms.Panel();
		A3B251BD = new System.Windows.Forms.RichTextBox();
		D5B40B27 = new System.Windows.Forms.Label();
		EEBB072C = new System.Windows.Forms.Button();
		EC860028 = new System.Windows.Forms.Button();
		btnCancel = new System.Windows.Forms.Button();
		A8AB339C = new System.Windows.Forms.Button();
		lblNanh = new System.Windows.Forms.Label();
		dgvPic = new System.Windows.Forms.DataGridView();
		dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		txtName = new System.Windows.Forms.TextBox();
		label2 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		cbbChuDe = new System.Windows.Forms.ComboBox();
		DEB97691 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		D30C9CA2 = new System.Windows.Forms.PictureBox();
		CF1E831F = new Bunifu.Framework.UI.BunifuCustomLabel();
		F82A5E27 = new System.Windows.Forms.ContextMenuStrip(icontainer_0);
		toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		F3BB60BE = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		toolTip_0 = new System.Windows.Forms.ToolTip(icontainer_0);
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)dgvPic).BeginInit();
		DEB97691.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)D30C9CA2).BeginInit();
		F82A5E27.SuspendLayout();
		SuspendLayout();
		CE09D512.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		CE09D512.BackColor = System.Drawing.Color.White;
		CE09D512.BorderRadius = 5;
		CE09D512.BottomSahddow = true;
		CE09D512.color = System.Drawing.Color.SaddleBrown;
		CE09D512.LeftSahddow = false;
		CE09D512.Location = new System.Drawing.Point(0, 0);
		CE09D512.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		CE09D512.Name = "bunifuCards1";
		CE09D512.RightSahddow = true;
		CE09D512.ShadowDepth = 20;
		CE09D512.Size = new System.Drawing.Size(46, 47);
		CE09D512.TabIndex = 12;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(A3B251BD);
		panel1.Controls.Add(D5B40B27);
		panel1.Controls.Add(EEBB072C);
		panel1.Controls.Add(EC860028);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(A8AB339C);
		panel1.Controls.Add(lblNanh);
		panel1.Controls.Add(dgvPic);
		panel1.Controls.Add(txtName);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(cbbChuDe);
		panel1.Controls.Add(DEB97691);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(375, 414);
		panel1.TabIndex = 37;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		A3B251BD.Location = new System.Drawing.Point(89, 184);
		A3B251BD.Name = "txtConten";
		A3B251BD.Size = new System.Drawing.Size(271, 149);
		A3B251BD.TabIndex = 119;
		A3B251BD.Text = "";
		A3B251BD.WordWrap = false;
		D5B40B27.AutoSize = true;
		D5B40B27.Location = new System.Drawing.Point(86, 336);
		D5B40B27.Name = "label8";
		D5B40B27.Size = new System.Drawing.Size(134, 16);
		D5B40B27.TabIndex = 117;
		D5B40B27.Text = "Spin nội dung {a|b|c}";
		EEBB072C.BackgroundImage = C50FB39E.D222F9AF;
		EEBB072C.Cursor = System.Windows.Forms.Cursors.Hand;
		EEBB072C.Location = new System.Drawing.Point(330, 148);
		EEBB072C.Name = "metroButton3";
		EEBB072C.Size = new System.Drawing.Size(30, 30);
		EEBB072C.TabIndex = 113;
		EEBB072C.Click += new System.EventHandler(D210F404);
		EC860028.BackgroundImage = C50FB39E.FF2D7E0B;
		EC860028.Cursor = System.Windows.Forms.Cursors.Hand;
		EC860028.Location = new System.Drawing.Point(330, 109);
		EC860028.Name = "metroButton2";
		EC860028.Size = new System.Drawing.Size(30, 30);
		EC860028.TabIndex = 113;
		EC860028.Click += new System.EventHandler(E79AB784);
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(192, 370);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 103;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		A8AB339C.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		A8AB339C.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		A8AB339C.Cursor = System.Windows.Forms.Cursors.Hand;
		A8AB339C.FlatAppearance.BorderSize = 0;
		A8AB339C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A8AB339C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A8AB339C.ForeColor = System.Drawing.Color.White;
		A8AB339C.Location = new System.Drawing.Point(85, 370);
		A8AB339C.Name = "button1";
		A8AB339C.Size = new System.Drawing.Size(92, 29);
		A8AB339C.TabIndex = 102;
		A8AB339C.Text = "Cập nhật";
		A8AB339C.UseVisualStyleBackColor = false;
		A8AB339C.Click += new System.EventHandler(C4AA6910);
		lblNanh.AutoSize = true;
		lblNanh.Location = new System.Drawing.Point(11, 109);
		lblNanh.Name = "lblNanh";
		lblNanh.Size = new System.Drawing.Size(56, 16);
		lblNanh.TabIndex = 90;
		lblNanh.Text = "Ảnh (0):";
		lblNanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		dgvPic.AllowUserToAddRows = false;
		dgvPic.AllowUserToDeleteRows = false;
		dgvPic.AllowUserToResizeColumns = false;
		dgvPic.AllowUserToResizeRows = false;
		dgvPic.BackgroundColor = System.Drawing.Color.White;
		dgvPic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dgvPic.ColumnHeadersVisible = false;
		dgvPic.Columns.AddRange(dataGridViewTextBoxColumn4);
		dgvPic.Cursor = System.Windows.Forms.Cursors.Hand;
		dgvPic.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		dgvPic.Location = new System.Drawing.Point(90, 109);
		dgvPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		dgvPic.Name = "dgvPic";
		dgvPic.RowHeadersVisible = false;
		dgvPic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		dgvPic.Size = new System.Drawing.Size(236, 69);
		dgvPic.TabIndex = 83;
		dgvPic.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(AD183097);
		dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn4.DataPropertyName = "Day";
		dataGridViewTextBoxColumn4.FillWeight = 57.38708f;
		dataGridViewTextBoxColumn4.HeaderText = "Đường dẫn";
		dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
		txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
		txtName.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		txtName.Location = new System.Drawing.Point(90, 78);
		txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		txtName.Name = "txtName";
		txtName.Size = new System.Drawing.Size(269, 23);
		txtName.TabIndex = 87;
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label2.ForeColor = System.Drawing.SystemColors.ControlText;
		label2.Location = new System.Drawing.Point(11, 187);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(63, 16);
		label2.TabIndex = 86;
		label2.Text = "Nội dung:";
		label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		label5.AutoSize = true;
		label5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label5.ForeColor = System.Drawing.SystemColors.ControlText;
		label5.Location = new System.Drawing.Point(11, 81);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(56, 16);
		label5.TabIndex = 85;
		label5.Text = "Tiêu đề:";
		label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(11, 50);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(53, 16);
		label1.TabIndex = 81;
		label1.Text = "Chủ đề:";
		cbbChuDe.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbChuDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbChuDe.Enabled = false;
		cbbChuDe.FormattingEnabled = true;
		cbbChuDe.Location = new System.Drawing.Point(90, 47);
		cbbChuDe.Name = "cbbChuDe";
		cbbChuDe.Size = new System.Drawing.Size(269, 24);
		cbbChuDe.TabIndex = 80;
		cbbChuDe.SelectedIndexChanged += new System.EventHandler(A493D02B);
		cbbChuDe.Click += new System.EventHandler(cbbChuDe_Click);
		DEB97691.BackColor = System.Drawing.Color.White;
		DEB97691.BorderRadius = 0;
		DEB97691.BottomSahddow = true;
		DEB97691.color = System.Drawing.Color.SaddleBrown;
		DEB97691.Controls.Add(pnlHeader);
		DEB97691.Dock = System.Windows.Forms.DockStyle.Top;
		DEB97691.LeftSahddow = false;
		DEB97691.Location = new System.Drawing.Point(0, 0);
		DEB97691.Name = "bunifuCards2";
		DEB97691.RightSahddow = true;
		DEB97691.ShadowDepth = 20;
		DEB97691.Size = new System.Drawing.Size(373, 37);
		DEB97691.TabIndex = 43;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button2);
		pnlHeader.Controls.Add(D30C9CA2);
		pnlHeader.Controls.Add(CF1E831F);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(373, 31);
		pnlHeader.TabIndex = 9;
		button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button2.ForeColor = System.Drawing.Color.White;
		button2.Image = C50FB39E.Bitmap_12;
		button2.Location = new System.Drawing.Point(342, 1);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		D30C9CA2.Cursor = System.Windows.Forms.Cursors.Default;
		D30C9CA2.Image = C50FB39E.Bitmap_5;
		D30C9CA2.Location = new System.Drawing.Point(3, 2);
		D30C9CA2.Name = "pictureBox1";
		D30C9CA2.Size = new System.Drawing.Size(34, 27);
		D30C9CA2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		D30C9CA2.TabIndex = 76;
		D30C9CA2.TabStop = false;
		CF1E831F.BackColor = System.Drawing.Color.Transparent;
		CF1E831F.Cursor = System.Windows.Forms.Cursors.SizeAll;
		CF1E831F.Dock = System.Windows.Forms.DockStyle.Fill;
		CF1E831F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CF1E831F.ForeColor = System.Drawing.Color.Black;
		CF1E831F.Location = new System.Drawing.Point(0, 0);
		CF1E831F.Name = "bunifuCustomLabel1";
		CF1E831F.Size = new System.Drawing.Size(373, 31);
		CF1E831F.TabIndex = 12;
		CF1E831F.Text = "Sửa bình luận";
		CF1E831F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F82A5E27.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { toolStripMenuItem_0, F3BB60BE, toolStripMenuItem_1 });
		F82A5E27.Name = "contextMenuStrip1";
		F82A5E27.Size = new System.Drawing.Size(153, 70);
		toolStripMenuItem_0.Name = "thêmMớiToolStripMenuItem";
		toolStripMenuItem_0.Size = new System.Drawing.Size(152, 22);
		toolStripMenuItem_0.Text = "Thêm chủ đề";
		F3BB60BE.Name = "sửaToolStripMenuItem";
		F3BB60BE.Size = new System.Drawing.Size(152, 22);
		F3BB60BE.Text = "Sửa tên chủ đề";
		toolStripMenuItem_1.Name = "xóaToolStripMenuItem";
		toolStripMenuItem_1.Size = new System.Drawing.Size(152, 22);
		toolStripMenuItem_1.Text = "Xóa chủ đề";
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = CF1E831F;
		bunifuDragControl_0.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(375, 414);
		base.Controls.Add(panel1);
		base.Controls.Add(CE09D512);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fSuaBaiViet";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "Cấu hình chung";
		base.FormClosed += new System.Windows.Forms.FormClosedEventHandler(fSuaBaiViet_FormClosed);
		base.Load += new System.EventHandler(fSuaBaiViet_Load);
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)dgvPic).EndInit();
		DEB97691.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)D30C9CA2).EndInit();
		F82A5E27.ResumeLayout(false);
		ResumeLayout(false);
	}
}
