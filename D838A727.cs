using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class D838A727 : Form
{
	private IContainer AA8D288C = null;

	private BunifuCards bunifuCards1;

	private Panel B6A29A1A;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip toolTip_0;

	private ContextMenuStrip E834712A;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private Button metroButton1;

	private Label AD2B7D1A;

	private ComboBox A5079088;

	private BunifuCards bunifuCards2;

	private Panel pnlHeader;

	private Button button2;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private DataGridView dgvPic;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private TextBox txtName;

	private Label CBA75030;

	private Label B7871028;

	private Button C20099A3;

	private Button button1;

	private Label lblNanh;

	private Button F7004900;

	private Button metroButton2;

	private RichTextBox txtConten;

	private Label D0088725;

	public D838A727(int ADA71A97)
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		C4A9A1B3();
		A5079088.SelectedIndex = ADA71A97;
	}

	private void C4A9A1B3()
	{
		List<string> list = Class15.smethod_20();
		for (int i = 0; i < list.Count; i++)
		{
			A5079088.Items.Add(list[i]);
		}
		try
		{
			A5079088.SelectedIndex = 0;
		}
		catch
		{
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		Close();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void metroButton1_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new B586A01D());
		A5079088.Items.Clear();
		C4A9A1B3();
	}

	private void metroButton2_Click(object sender, EventArgs e)
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

	private void F7004900_Click(object sender, EventArgs e)
	{
		foreach (DataGridViewRow selectedRow in dgvPic.SelectedRows)
		{
			dgvPic.Rows.RemoveAt(selectedRow.Index);
		}
		lblNanh.Text = "Ảnh (" + dgvPic.Rows.Count + "):";
	}

	private void button1_Click(object sender, EventArgs e)
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
			string string_ = A5079088.SelectedItem.ToString();
			BBA6CAB0 f19D0B = new BBA6CAB0
			{
				BA2E9E33 = txtName.Text,
				EF0AA8B3 = text,
				D52B6012 = d52B,
				BF907F85 = DateTime.Now.ToString("dd/MM/yyyy"),
				String_1 = txtConten.Text
			};
			Class15.smethod_25(string_, f19D0B);
			DialogResult dialogResult = GClass29.smethod_1("Thêm thành công. Bạn muốn có muốn đóng cửa sổ không?");
			if (dialogResult == DialogResult.Yes)
			{
				Close();
			}
		}
		else
		{
			GClass29.smethod_0("Chưa nhập tiêu đề!", 2);
		}
	}

	private void C20099A3_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B992E320(object sender, DataGridViewCellEventArgs e)
	{
		Process.Start(dgvPic.SelectedRows[0].Cells[0].Value.ToString());
	}

	private void A5079088_Click(object sender, EventArgs e)
	{
	}

	private void B6A29A1A_Paint(object sender, PaintEventArgs e)
	{
	}

	private void method_1(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void DD81D8B2(object sender, EventArgs e)
	{
	}

	private void D795E71E(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.smethod_33(new E3962B82());
	}

	protected override void Dispose(bool CA1697BE)
	{
		if (CA1697BE && AA8D288C != null)
		{
			AA8D288C.Dispose();
		}
		base.Dispose(CA1697BE);
	}

	private void InitializeComponent()
	{
		AA8D288C = new System.ComponentModel.Container();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		B6A29A1A = new System.Windows.Forms.Panel();
		txtConten = new System.Windows.Forms.RichTextBox();
		F7004900 = new System.Windows.Forms.Button();
		metroButton2 = new System.Windows.Forms.Button();
		lblNanh = new System.Windows.Forms.Label();
		C20099A3 = new System.Windows.Forms.Button();
		button1 = new System.Windows.Forms.Button();
		dgvPic = new System.Windows.Forms.DataGridView();
		dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		txtName = new System.Windows.Forms.TextBox();
		CBA75030 = new System.Windows.Forms.Label();
		B7871028 = new System.Windows.Forms.Label();
		metroButton1 = new System.Windows.Forms.Button();
		AD2B7D1A = new System.Windows.Forms.Label();
		A5079088 = new System.Windows.Forms.ComboBox();
		bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		E834712A = new System.Windows.Forms.ContextMenuStrip(AA8D288C);
		toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(AA8D288C);
		toolTip_0 = new System.Windows.Forms.ToolTip(AA8D288C);
		D0088725 = new System.Windows.Forms.Label();
		B6A29A1A.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)dgvPic).BeginInit();
		bunifuCards2.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		E834712A.SuspendLayout();
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
		bunifuCards1.Size = new System.Drawing.Size(43, 47);
		bunifuCards1.TabIndex = 12;
		B6A29A1A.BackColor = System.Drawing.Color.White;
		B6A29A1A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		B6A29A1A.Controls.Add(D0088725);
		B6A29A1A.Controls.Add(txtConten);
		B6A29A1A.Controls.Add(F7004900);
		B6A29A1A.Controls.Add(metroButton2);
		B6A29A1A.Controls.Add(lblNanh);
		B6A29A1A.Controls.Add(C20099A3);
		B6A29A1A.Controls.Add(button1);
		B6A29A1A.Controls.Add(dgvPic);
		B6A29A1A.Controls.Add(txtName);
		B6A29A1A.Controls.Add(CBA75030);
		B6A29A1A.Controls.Add(B7871028);
		B6A29A1A.Controls.Add(metroButton1);
		B6A29A1A.Controls.Add(AD2B7D1A);
		B6A29A1A.Controls.Add(A5079088);
		B6A29A1A.Controls.Add(bunifuCards2);
		B6A29A1A.Dock = System.Windows.Forms.DockStyle.Fill;
		B6A29A1A.Location = new System.Drawing.Point(0, 0);
		B6A29A1A.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		B6A29A1A.Name = "panel1";
		B6A29A1A.Size = new System.Drawing.Size(372, 411);
		B6A29A1A.TabIndex = 37;
		B6A29A1A.Paint += new System.Windows.Forms.PaintEventHandler(B6A29A1A_Paint);
		txtConten.Location = new System.Drawing.Point(76, 187);
		txtConten.Name = "txtConten";
		txtConten.Size = new System.Drawing.Size(271, 149);
		txtConten.TabIndex = 120;
		txtConten.Text = "";
		txtConten.WordWrap = false;
		F7004900.BackgroundImage = C50FB39E.D222F9AF;
		F7004900.Cursor = System.Windows.Forms.Cursors.Hand;
		F7004900.Location = new System.Drawing.Point(317, 149);
		F7004900.Name = "metroButton3";
		F7004900.Size = new System.Drawing.Size(30, 30);
		F7004900.TabIndex = 114;
		F7004900.Click += new System.EventHandler(F7004900_Click);
		metroButton2.BackgroundImage = C50FB39E.FF2D7E0B;
		metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton2.Location = new System.Drawing.Point(317, 110);
		metroButton2.Name = "metroButton2";
		metroButton2.Size = new System.Drawing.Size(30, 30);
		metroButton2.TabIndex = 115;
		metroButton2.Click += new System.EventHandler(metroButton2_Click);
		lblNanh.AutoSize = true;
		lblNanh.Location = new System.Drawing.Point(6, 110);
		lblNanh.Name = "lblNanh";
		lblNanh.Size = new System.Drawing.Size(56, 16);
		lblNanh.TabIndex = 109;
		lblNanh.Text = "Ảnh (0):";
		lblNanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C20099A3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		C20099A3.BackColor = System.Drawing.Color.Maroon;
		C20099A3.Cursor = System.Windows.Forms.Cursors.Hand;
		C20099A3.FlatAppearance.BorderSize = 0;
		C20099A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C20099A3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C20099A3.ForeColor = System.Drawing.Color.White;
		C20099A3.Location = new System.Drawing.Point(184, 369);
		C20099A3.Name = "btnCancel";
		C20099A3.Size = new System.Drawing.Size(92, 29);
		C20099A3.TabIndex = 108;
		C20099A3.Text = "Đóng";
		C20099A3.UseVisualStyleBackColor = false;
		C20099A3.Click += new System.EventHandler(C20099A3_Click);
		button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		button1.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Location = new System.Drawing.Point(77, 369);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(92, 29);
		button1.TabIndex = 107;
		button1.Text = "Lưu";
		button1.UseVisualStyleBackColor = false;
		button1.Click += new System.EventHandler(button1_Click);
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
		dgvPic.Location = new System.Drawing.Point(77, 109);
		dgvPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		dgvPic.Name = "dgvPic";
		dgvPic.RowHeadersVisible = false;
		dgvPic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		dgvPic.Size = new System.Drawing.Size(234, 70);
		dgvPic.TabIndex = 83;
		dgvPic.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(B992E320);
		dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn4.DataPropertyName = "Day";
		dataGridViewTextBoxColumn4.FillWeight = 57.38708f;
		dataGridViewTextBoxColumn4.HeaderText = "Đường dẫn";
		dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
		txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
		txtName.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		txtName.Location = new System.Drawing.Point(77, 78);
		txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		txtName.Name = "txtName";
		txtName.Size = new System.Drawing.Size(270, 23);
		txtName.TabIndex = 87;
		CBA75030.AutoSize = true;
		CBA75030.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		CBA75030.ForeColor = System.Drawing.SystemColors.ControlText;
		CBA75030.Location = new System.Drawing.Point(6, 187);
		CBA75030.Name = "label2";
		CBA75030.Size = new System.Drawing.Size(63, 16);
		CBA75030.TabIndex = 86;
		CBA75030.Text = "Nội dung:";
		CBA75030.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		B7871028.AutoSize = true;
		B7871028.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B7871028.ForeColor = System.Drawing.SystemColors.ControlText;
		B7871028.Location = new System.Drawing.Point(6, 81);
		B7871028.Name = "label5";
		B7871028.Size = new System.Drawing.Size(56, 16);
		B7871028.TabIndex = 85;
		B7871028.Text = "Tiêu đề:";
		B7871028.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton1.Location = new System.Drawing.Point(254, 46);
		metroButton1.Name = "metroButton1";
		metroButton1.Size = new System.Drawing.Size(93, 25);
		metroButton1.TabIndex = 82;
		metroButton1.Text = "Quản lý chủ đề";
		metroButton1.Click += new System.EventHandler(metroButton1_Click);
		AD2B7D1A.AutoSize = true;
		AD2B7D1A.Location = new System.Drawing.Point(6, 50);
		AD2B7D1A.Name = "label1";
		AD2B7D1A.Size = new System.Drawing.Size(53, 16);
		AD2B7D1A.TabIndex = 81;
		AD2B7D1A.Text = "Chủ đề:";
		A5079088.Cursor = System.Windows.Forms.Cursors.Hand;
		A5079088.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		A5079088.FormattingEnabled = true;
		A5079088.Location = new System.Drawing.Point(77, 47);
		A5079088.Name = "cbbChuDe";
		A5079088.Size = new System.Drawing.Size(171, 24);
		A5079088.TabIndex = 80;
		A5079088.Click += new System.EventHandler(A5079088_Click);
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
		bunifuCards2.Size = new System.Drawing.Size(370, 37);
		bunifuCards2.TabIndex = 43;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button2);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(370, 31);
		pnlHeader.TabIndex = 9;
		button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button2.ForeColor = System.Drawing.Color.White;
		button2.Image = C50FB39E.Bitmap_12;
		button2.Location = new System.Drawing.Point(339, 1);
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
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(370, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Thêm bình luận";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuCustomLabel1.Click += new System.EventHandler(DD81D8B2);
		E834712A.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { toolStripMenuItem_0, toolStripMenuItem_1, toolStripMenuItem_2 });
		E834712A.Name = "contextMenuStrip1";
		E834712A.Size = new System.Drawing.Size(153, 70);
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
		D0088725.AutoSize = true;
		D0088725.Location = new System.Drawing.Point(74, 339);
		D0088725.Name = "label8";
		D0088725.Size = new System.Drawing.Size(134, 16);
		D0088725.TabIndex = 121;
		D0088725.Text = "Spin nội dung {a|b|c}";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(372, 411);
		base.Controls.Add(B6A29A1A);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fThemBaiViet";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		B6A29A1A.ResumeLayout(false);
		B6A29A1A.PerformLayout();
		((System.ComponentModel.ISupportInitialize)dgvPic).EndInit();
		bunifuCards2.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		E834712A.ResumeLayout(false);
		ResumeLayout(false);
	}
}
