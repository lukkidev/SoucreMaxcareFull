using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fNhapDuLieu2 : Form
{
	private string EE034434 = "";

	private Random random_0 = new Random();

	private bool bool_0 = false;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel DC92AF2F;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip toolTip_0;

	private BunifuCards E53833BB;

	private Panel pnlHeader;

	private Button DD8544A9;

	private PictureBox D8A06996;

	private Button D3B00A2E;

	private BunifuCustomLabel lblTitle;

	private Button btnSave;

	private TextBox F81CAB2E;

	private GroupBox A50142AD;

	private GroupBox groupBox2;

	public DataGridView ACB20234;

	private Button btnAdd;

	private DataGridViewTextBoxColumn cSTT;

	private DataGridViewTextBoxColumn cName;

	private DataGridViewButtonColumn cChiTiet;

	private DataGridViewButtonColumn cSua;

	private DataGridViewButtonColumn cXoa;

	private Button C626899B;

	public fNhapDuLieu2(string string_0, string string_1)
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		EE034434 = string_0;
		lblTitle.Text = string_1;
	}

	private void B31A2C9F()
	{
		F7AB102E.smethod_1(lblTitle);
		F7AB102E.smethod_1(A50142AD);
		F7AB102E.smethod_1(groupBox2);
		foreach (DataGridViewColumn column in ACB20234.Columns)
		{
			F7AB102E.smethod_3(column);
		}
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(btnSave);
		F7AB102E.smethod_1(C626899B);
	}

	private void fNhapDuLieu2_Load(object sender, EventArgs e)
	{
		GClass8.smethod_32(EE034434);
		method_1(EE034434);
	}

	private void method_0(int int_0)
	{
		F81CAB2E.Lines = File.ReadAllLines(GClass27.smethod_3(ACB20234, int_0, "cName"));
	}

	private void method_1(string string_0)
	{
		int num = -1;
		switch (ACB20234.RowCount)
		{
		default:
			num = ACB20234.SelectedRows[0].Index;
			break;
		case 1:
			num = 0;
			break;
		case 0:
			break;
		}
		ACB20234.Rows.Clear();
		List<string> list = GClass8.smethod_80(string_0);
		for (int i = 0; i < list.Count; i++)
		{
			ACB20234.Rows.Add(i + 1, list[i], F7AB102E.smethod_0("Chi tiê\u0301t"), F7AB102E.smethod_0("Sư\u0309a"), F7AB102E.smethod_0("Xo\u0301a"));
		}
		if (num == -1 && ACB20234.RowCount > 0)
		{
			num = 0;
		}
		else if (num + 1 > ACB20234.RowCount)
		{
			num = ACB20234.RowCount - 1;
		}
		if (num == -1)
		{
			F81CAB2E.Text = "";
			return;
		}
		GClass8.D204BB36(ACB20234);
		ACB20234.Rows[num].Selected = true;
		method_0(num);
	}

	private void DC92AF2F_Paint(object sender, PaintEventArgs e)
	{
	}

	private void DD8544A9_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_2(int int_0)
	{
		if (int_0 == 1)
		{
			ACB20234.Enabled = false;
			btnAdd.Enabled = false;
			btnSave.Enabled = true;
			C626899B.Enabled = true;
			F81CAB2E.ReadOnly = false;
			F81CAB2E.Focus();
		}
		else
		{
			ACB20234.Enabled = true;
			btnAdd.Enabled = true;
			btnSave.Enabled = false;
			C626899B.Enabled = false;
			F81CAB2E.ReadOnly = true;
		}
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			string text = "";
			string text2;
			do
			{
				text2 = DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss_") + GClass8.smethod_51(3) + ".txt";
			}
			while (File.Exists(text2));
			text = EE034434 + "\\" + text2;
			GClass8.smethod_31(text);
			F81CAB2E.Lines = File.ReadAllLines(text);
			ACB20234.Rows.Add(ACB20234.RowCount + 1, text, F7AB102E.smethod_0("Chi tiê\u0301t"), F7AB102E.smethod_0("Sư\u0309a"), F7AB102E.smethod_0("Xo\u0301a"));
			GClass8.D204BB36(ACB20234);
			ACB20234.Rows[ACB20234.RowCount - 1].Selected = true;
			method_2(1);
			bool_0 = true;
		}
		catch
		{
			GClass29.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void F003089A(object sender, EventArgs e)
	{
	}

	private void ACB20234_MouseHover(object sender, EventArgs e)
	{
	}

	private void ACB20234_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
	{
		string name = ACB20234.Columns[e.ColumnIndex].Name;
		if (name != "cChiTiet" && name != "cSua" && name != "cXoa")
		{
			ACB20234.Cursor = Cursors.Default;
		}
		else if (e.RowIndex < ACB20234.RowCount)
		{
			ACB20234.Cursor = Cursors.Hand;
		}
	}

	private void BE358C0B(object sender, DataGridViewCellEventArgs e)
	{
		DataGridView dataGridView = (DataGridView)sender;
		if (!(dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) || e.RowIndex < 0)
		{
			return;
		}
		switch (dataGridView.Columns[e.ColumnIndex].Name)
		{
		case "cXoa":
			if (GClass29.smethod_1("Bạn có muốn xóa?") == DialogResult.Yes)
			{
				File.Delete(GClass27.smethod_3(ACB20234, e.RowIndex, "cName"));
				method_1(EE034434);
			}
			break;
		case "cSua":
			F81CAB2E.Lines = File.ReadAllLines(GClass27.smethod_3(ACB20234, e.RowIndex, "cName"));
			bool_0 = false;
			method_2(1);
			break;
		case "cChiTiet":
			method_0(e.RowIndex);
			break;
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		try
		{
			string text = ACB20234.SelectedRows[0].Cells["cName"].Value.ToString();
			GClass8.smethod_31(text);
			if (F81CAB2E.Text.Trim() == "")
			{
				GClass29.smethod_0("Vui lòng nhập nội dung cần lưu!", 3);
			}
			else if (GClass29.smethod_1("Bạn có muốn lưu lại?") == DialogResult.Yes)
			{
				File.WriteAllLines(text, F81CAB2E.Lines);
				GClass29.smethod_0("Lưu thành công!");
				method_2(2);
			}
		}
		catch
		{
			GClass29.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void C626899B_Click(object sender, EventArgs e)
	{
		try
		{
			string text = ACB20234.SelectedRows[0].Cells["cName"].Value.ToString();
			GClass8.smethod_31(text);
			if (GClass29.smethod_1("Bạn có muốn hủy?") == DialogResult.Yes)
			{
				if (bool_0)
				{
					File.Delete(text);
				}
				method_2(2);
				method_1(EE034434);
			}
		}
		catch
		{
			GClass29.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		DC92AF2F = new System.Windows.Forms.Panel();
		A50142AD = new System.Windows.Forms.GroupBox();
		ACB20234 = new System.Windows.Forms.DataGridView();
		cSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
		cSua = new System.Windows.Forms.DataGridViewButtonColumn();
		cXoa = new System.Windows.Forms.DataGridViewButtonColumn();
		btnAdd = new System.Windows.Forms.Button();
		groupBox2 = new System.Windows.Forms.GroupBox();
		F81CAB2E = new System.Windows.Forms.TextBox();
		btnSave = new System.Windows.Forms.Button();
		E53833BB = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		DD8544A9 = new System.Windows.Forms.Button();
		D8A06996 = new System.Windows.Forms.PictureBox();
		D3B00A2E = new System.Windows.Forms.Button();
		lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		toolTip_0 = new System.Windows.Forms.ToolTip(icontainer_0);
		C626899B = new System.Windows.Forms.Button();
		DC92AF2F.SuspendLayout();
		A50142AD.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)ACB20234).BeginInit();
		groupBox2.SuspendLayout();
		E53833BB.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)D8A06996).BeginInit();
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
		bunifuCards1.Size = new System.Drawing.Size(425, 47);
		bunifuCards1.TabIndex = 12;
		DC92AF2F.BackColor = System.Drawing.Color.White;
		DC92AF2F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		DC92AF2F.Controls.Add(A50142AD);
		DC92AF2F.Controls.Add(groupBox2);
		DC92AF2F.Controls.Add(E53833BB);
		DC92AF2F.Dock = System.Windows.Forms.DockStyle.Fill;
		DC92AF2F.Location = new System.Drawing.Point(0, 0);
		DC92AF2F.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		DC92AF2F.Name = "panel1";
		DC92AF2F.Size = new System.Drawing.Size(754, 388);
		DC92AF2F.TabIndex = 37;
		DC92AF2F.Paint += new System.Windows.Forms.PaintEventHandler(DC92AF2F_Paint);
		A50142AD.Controls.Add(ACB20234);
		A50142AD.Controls.Add(btnAdd);
		A50142AD.Location = new System.Drawing.Point(3, 43);
		A50142AD.Name = "groupBox1";
		A50142AD.Size = new System.Drawing.Size(284, 339);
		A50142AD.TabIndex = 50;
		A50142AD.TabStop = false;
		A50142AD.Text = " Danh sa\u0301ch nô\u0323i dung";
		ACB20234.AllowUserToAddRows = false;
		ACB20234.AllowUserToDeleteRows = false;
		ACB20234.AllowUserToResizeRows = false;
		ACB20234.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		ACB20234.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		ACB20234.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		ACB20234.Columns.AddRange(cSTT, cName, cChiTiet, cSua, cXoa);
		ACB20234.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		ACB20234.Location = new System.Drawing.Point(6, 22);
		ACB20234.Name = "dtgvDanhSach";
		ACB20234.RowHeadersVisible = false;
		ACB20234.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		ACB20234.Size = new System.Drawing.Size(272, 277);
		ACB20234.TabIndex = 76;
		ACB20234.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(BE358C0B);
		ACB20234.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(ACB20234_CellMouseEnter);
		ACB20234.MouseHover += new System.EventHandler(ACB20234_MouseHover);
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		cSTT.DefaultCellStyle = dataGridViewCellStyle2;
		cSTT.HeaderText = "STT";
		cSTT.Name = "cSTT";
		cSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		cSTT.Width = 40;
		cName.HeaderText = "Tên file";
		cName.Name = "cName";
		cName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		cName.Visible = false;
		cChiTiet.HeaderText = "Chi tiê\u0301t";
		cChiTiet.Name = "cChiTiet";
		cChiTiet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		cChiTiet.Width = 80;
		cSua.HeaderText = "Sư\u0309a";
		cSua.Name = "cSua";
		cSua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		cSua.Width = 71;
		cXoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		cXoa.HeaderText = "Xo\u0301a";
		cXoa.Name = "cXoa";
		cXoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		btnAdd.BackColor = System.Drawing.Color.Green;
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(186, 303);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 45;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		groupBox2.Controls.Add(F81CAB2E);
		groupBox2.Controls.Add(C626899B);
		groupBox2.Controls.Add(btnSave);
		groupBox2.Location = new System.Drawing.Point(293, 43);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new System.Drawing.Size(455, 339);
		groupBox2.TabIndex = 50;
		groupBox2.TabStop = false;
		groupBox2.Text = "Chi tiê\u0301t";
		F81CAB2E.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		F81CAB2E.Location = new System.Drawing.Point(5, 22);
		F81CAB2E.Multiline = true;
		F81CAB2E.Name = "txtContent";
		F81CAB2E.ReadOnly = true;
		F81CAB2E.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		F81CAB2E.Size = new System.Drawing.Size(444, 277);
		F81CAB2E.TabIndex = 48;
		F81CAB2E.WordWrap = false;
		F81CAB2E.TextChanged += new System.EventHandler(F003089A);
		btnSave.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
		btnSave.Enabled = false;
		btnSave.FlatAppearance.BorderSize = 0;
		btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnSave.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnSave.ForeColor = System.Drawing.Color.White;
		btnSave.Location = new System.Drawing.Point(256, 304);
		btnSave.Name = "btnSave";
		btnSave.Size = new System.Drawing.Size(92, 29);
		btnSave.TabIndex = 45;
		btnSave.Text = "Lưu";
		btnSave.UseVisualStyleBackColor = false;
		btnSave.Click += new System.EventHandler(btnSave_Click);
		E53833BB.BackColor = System.Drawing.Color.White;
		E53833BB.BorderRadius = 0;
		E53833BB.BottomSahddow = true;
		E53833BB.color = System.Drawing.Color.SaddleBrown;
		E53833BB.Controls.Add(pnlHeader);
		E53833BB.Dock = System.Windows.Forms.DockStyle.Top;
		E53833BB.LeftSahddow = false;
		E53833BB.Location = new System.Drawing.Point(0, 0);
		E53833BB.Name = "bunifuCards2";
		E53833BB.RightSahddow = true;
		E53833BB.ShadowDepth = 20;
		E53833BB.Size = new System.Drawing.Size(752, 37);
		E53833BB.TabIndex = 43;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(DD8544A9);
		pnlHeader.Controls.Add(D8A06996);
		pnlHeader.Controls.Add(D3B00A2E);
		pnlHeader.Controls.Add(lblTitle);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(752, 31);
		pnlHeader.TabIndex = 9;
		DD8544A9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		DD8544A9.Cursor = System.Windows.Forms.Cursors.Hand;
		DD8544A9.FlatAppearance.BorderSize = 0;
		DD8544A9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		DD8544A9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		DD8544A9.ForeColor = System.Drawing.Color.White;
		DD8544A9.Image = C50FB39E.Bitmap_12;
		DD8544A9.Location = new System.Drawing.Point(721, 1);
		DD8544A9.Name = "button2";
		DD8544A9.Size = new System.Drawing.Size(30, 30);
		DD8544A9.TabIndex = 77;
		DD8544A9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		DD8544A9.UseVisualStyleBackColor = true;
		DD8544A9.Click += new System.EventHandler(DD8544A9_Click);
		D8A06996.Cursor = System.Windows.Forms.Cursors.Default;
		D8A06996.Image = C50FB39E.Bitmap_5;
		D8A06996.Location = new System.Drawing.Point(3, 2);
		D8A06996.Name = "pictureBox1";
		D8A06996.Size = new System.Drawing.Size(34, 27);
		D8A06996.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		D8A06996.TabIndex = 76;
		D8A06996.TabStop = false;
		D3B00A2E.Cursor = System.Windows.Forms.Cursors.Hand;
		D3B00A2E.FlatAppearance.BorderSize = 0;
		D3B00A2E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D3B00A2E.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D3B00A2E.ForeColor = System.Drawing.Color.White;
		D3B00A2E.Location = new System.Drawing.Point(899, 1);
		D3B00A2E.Name = "btnMinimize";
		D3B00A2E.Size = new System.Drawing.Size(30, 30);
		D3B00A2E.TabIndex = 9;
		D3B00A2E.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		D3B00A2E.UseVisualStyleBackColor = true;
		lblTitle.BackColor = System.Drawing.Color.Transparent;
		lblTitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
		lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
		lblTitle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblTitle.ForeColor = System.Drawing.Color.Black;
		lblTitle.Location = new System.Drawing.Point(0, 0);
		lblTitle.Name = "lblTitle";
		lblTitle.Size = new System.Drawing.Size(752, 31);
		lblTitle.TabIndex = 12;
		lblTitle.Text = "Nhập nội dung comment";
		lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = lblTitle;
		bunifuDragControl_0.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		C626899B.BackColor = System.Drawing.Color.FromArgb(128, 64, 0);
		C626899B.Cursor = System.Windows.Forms.Cursors.Hand;
		C626899B.Enabled = false;
		C626899B.FlatAppearance.BorderSize = 0;
		C626899B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C626899B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C626899B.ForeColor = System.Drawing.Color.White;
		C626899B.Location = new System.Drawing.Point(357, 304);
		C626899B.Name = "btnHuy";
		C626899B.Size = new System.Drawing.Size(92, 29);
		C626899B.TabIndex = 45;
		C626899B.Text = "Hủy";
		C626899B.UseVisualStyleBackColor = false;
		C626899B.Click += new System.EventHandler(C626899B_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(754, 388);
		base.Controls.Add(DC92AF2F);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fNhapDuLieu2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fNhapDuLieu2_Load);
		DC92AF2F.ResumeLayout(false);
		A50142AD.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)ACB20234).EndInit();
		groupBox2.ResumeLayout(false);
		groupBox2.PerformLayout();
		E53833BB.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)D8A06996).EndInit();
		ResumeLayout(false);
	}
}
