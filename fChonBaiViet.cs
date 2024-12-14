using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fChonBaiViet : Form
{
	private bool bool_0 = false;

	private List<string> list_0 = new List<string>();

	private IContainer CA2827A7 = null;

	private BunifuCards bunifuCards1;

	private Panel panel1;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip FAB79536;

	private Button btnCancel;

	private Button D500872F;

	private GroupBox groupBox2;

	private GroupBox FD098A09;

	public DataGridView dgvDSBaiViet;

	private Button FF11088A;

	private Label DDBC9C1C;

	private ComboBox cbbChuDe;

	private Label lblCountAcc;

	private Label label7;

	private BunifuCards bunifuCards2;

	private Panel D403EEA7;

	private PictureBox pictureBox1;

	private Button E0A06714;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label B1832F9E;

	public DataGridView dgvBaiVietDaChon;

	private ContextMenuStrip A321C014;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem F4BF1C8B;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem C208D310;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem toolStripMenuItem_3;

	private Label label3;

	private DataGridViewTextBoxColumn cStt1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

	private DataGridViewTextBoxColumn cId;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

	private DataGridViewTextBoxColumn Column1;

	private DataGridViewTextBoxColumn AD29931C;

	private DataGridViewTextBoxColumn C21B4B94;

	private DataGridViewTextBoxColumn A0311F27;

	private DataGridViewTextBoxColumn E10FC988;

	private DataGridViewTextBoxColumn cAnh;

	private DataGridViewTextBoxColumn B418130F;

	public fChonBaiViet(ref List<string> F5A94B22)
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		method_2();
		list_0 = F5A94B22;
		method_0();
	}

	private void method_0()
	{
		if (list_0.Count <= 0)
		{
			return;
		}
		dgvBaiVietDaChon.Rows.Clear();
		for (int i = 0; i < list_0.Count; i++)
		{
			try
			{
				BBA6CAB0 bBA6CAB = method_1(list_0[i]);
				dgvBaiVietDaChon.Rows.Add(i + 1, bBA6CAB.String_0, bBA6CAB.Int32_0, bBA6CAB.BA2E9E33, bBA6CAB.EF0AA8B3.Split('|').Length - 1, bBA6CAB.D52B6012.Split('|').Length - 1);
			}
			catch
			{
				list_0.RemoveAt(i--);
			}
		}
	}

	private BBA6CAB0 method_1(string string_0)
	{
		BBA6CAB0 result = new BBA6CAB0();
		try
		{
			result = Class15.smethod_19(string_0)[0];
		}
		catch
		{
		}
		return result;
	}

	private void method_2(bool F404793A = false)
	{
		int selectedIndex = cbbChuDe.SelectedIndex;
		cbbChuDe.Items.Clear();
		List<string> list = Class15.smethod_20();
		for (int i = 0; i < list.Count; i++)
		{
			cbbChuDe.Items.Add(list[i]);
		}
		if (cbbChuDe.Items.Count == 0)
		{
			cbbChuDe.SelectedIndex = -1;
		}
		else if (cbbChuDe.Items.Count == 1)
		{
			cbbChuDe.SelectedIndex = 0;
		}
		else if (selectedIndex == -1)
		{
			cbbChuDe.SelectedIndex = 0;
		}
		else if (cbbChuDe.Items.Count - 1 < selectedIndex)
		{
			cbbChuDe.SelectedIndex = cbbChuDe.Items.Count - 1;
		}
		else
		{
			cbbChuDe.SelectedIndex = selectedIndex;
		}
		method_3(F404793A);
		method_0();
	}

	private void method_3(bool BC9E19B3 = true)
	{
		try
		{
			dgvDSBaiViet.Rows.Clear();
			List<BBA6CAB0> list = new List<BBA6CAB0>();
			list = (BC9E19B3 ? Class15.smethod_21() : Class15.smethod_21(cbbChuDe.SelectedItem.ToString()));
			BBA6CAB0 bBA6CAB = new BBA6CAB0();
			for (int i = 0; i < list.Count; i++)
			{
				bBA6CAB = list[i];
				dgvDSBaiViet.Rows.Add(i + 1, bBA6CAB.String_0, bBA6CAB.Int32_0, bBA6CAB.BA2E9E33, bBA6CAB.EF0AA8B3.Split('|').Length - 1, bBA6CAB.D52B6012.Split('|').Length - 1);
			}
		}
		catch
		{
		}
	}

	private void E3AE00B1(object sender, EventArgs e)
	{
		Close();
	}

	private void fChonBaiViet_Load(object sender, EventArgs e)
	{
	}

	private void D500872F_Click(object sender, EventArgs e)
	{
		list_0.Clear();
		for (int i = 0; i < dgvBaiVietDaChon.RowCount; i++)
		{
			list_0.Add(dgvBaiVietDaChon.Rows[i].Cells["cId"].Value.ToString());
		}
		if (GClass29.smethod_1("Lưu thành công, bạn có muốn đóng cửa sổ?") == DialogResult.Yes)
		{
			Close();
		}
	}

	private void C40D0613(object sender, PaintEventArgs e)
	{
	}

	private void method_4(object sender, EventArgs e)
	{
		Close();
	}

	private void FF11088A_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new B586A01D());
		method_2(bool_0);
	}

	private void A98353A0(object sender, EventArgs e)
	{
		try
		{
			int count = Class15.smethod_21().Count;
			GClass8.smethod_33(new D838A727(cbbChuDe.SelectedIndex));
			int count2 = Class15.smethod_21().Count;
			if (count2 > count)
			{
				BBA6CAB0 bBA6CAB = Class15.E53433A4()[0];
				dgvDSBaiViet.Rows.Add(dgvDSBaiViet.RowCount + 1, bBA6CAB.String_0, bBA6CAB.Int32_0, bBA6CAB.BA2E9E33, bBA6CAB.EF0AA8B3.Split('|').Length - 1, bBA6CAB.D52B6012.Split('|').Length - 1);
			}
		}
		catch
		{
		}
	}

	private void F4BF1C8B_Click(object sender, EventArgs e)
	{
		try
		{
			DataGridViewRow dataGridViewRow = dgvDSBaiViet.SelectedRows[0];
			int int_ = Convert.ToInt32(dataGridViewRow.Cells[2].Value);
			GClass8.smethod_33(new fSuaBaiViet(int_));
			BBA6CAB0 bBA6CAB = Class15.smethod_19(int_.ToString())[0];
			GClass8.B3866B9B(dgvDSBaiViet, dataGridViewRow.Index, "cTieuDe", bBA6CAB.BA2E9E33);
			GClass8.B3866B9B(dgvDSBaiViet, dataGridViewRow.Index, "cAnh", bBA6CAB.EF0AA8B3.Split('|').Length - 1);
			GClass8.B3866B9B(dgvDSBaiViet, dataGridViewRow.Index, "cVideo", bBA6CAB.D52B6012.Split('|').Length - 1);
			method_0();
		}
		catch
		{
		}
	}

	private bool method_5(string string_0)
	{
		bool result = false;
		for (int i = 0; i < dgvBaiVietDaChon.Rows.Count; i++)
		{
			if (string_0 == dgvBaiVietDaChon.Rows[i].Cells[2].Value.ToString())
			{
				result = true;
				break;
			}
		}
		return result;
	}

	private void dgvDSBaiViet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		int num = Convert.ToInt32(dgvDSBaiViet.SelectedRows[0].Cells[2].Value);
		List<BBA6CAB0> list = Class15.smethod_19(num.ToString());
		BBA6CAB0 bBA6CAB = new BBA6CAB0();
		for (int i = 0; i < list.Count; i++)
		{
			if (method_5(num.ToString()))
			{
				break;
			}
			bBA6CAB = list[i];
			dgvBaiVietDaChon.Rows.Add(dgvBaiVietDaChon.Rows.Count + 1, bBA6CAB.String_0, bBA6CAB.Int32_0, bBA6CAB.BA2E9E33, bBA6CAB.EF0AA8B3.Split('|').Length - 1, bBA6CAB.D52B6012.Split('|').Length - 1);
			list_0.Add(bBA6CAB.Int32_0.ToString());
		}
		lblCountAcc.Text = dgvBaiVietDaChon.Rows.Count.ToString();
	}

	private void C51A4533(object sender, EventArgs e)
	{
		try
		{
			int int_ = Convert.ToInt32(dgvDSBaiViet.SelectedRows[0].Cells[2].Value);
			fChiTietBaiViet fChiTietBaiViet2 = new fChiTietBaiViet(int_);
			fChiTietBaiViet2.Show();
		}
		catch
		{
		}
	}

	private void DDA37838()
	{
		for (int i = 0; i < dgvBaiVietDaChon.RowCount; i++)
		{
			GClass8.B3866B9B(dgvBaiVietDaChon, i, "cStt1", i + 1);
		}
	}

	private void DE9FEB16(object sender, EventArgs e)
	{
		dgvDSBaiViet.Rows.Clear();
		List<BBA6CAB0> list = Class15.smethod_21(cbbChuDe.SelectedItem.ToString());
		BBA6CAB0 bBA6CAB = new BBA6CAB0();
		for (int i = 0; i < list.Count; i++)
		{
			try
			{
				bBA6CAB = list[i];
				dgvDSBaiViet.Rows.Add(i + 1, bBA6CAB.String_0, bBA6CAB.Int32_0, bBA6CAB.BA2E9E33, bBA6CAB.EF0AA8B3.Split('|').Length - 1, bBA6CAB.D52B6012.Split('|').Length - 1);
			}
			catch
			{
			}
		}
	}

	private void C208D310_Click(object sender, EventArgs e)
	{
		method_3(bool_0);
	}

	private void method_6(object sender, EventArgs e)
	{
	}

	private void toolStripMenuItem_3_Click(object sender, EventArgs e)
	{
		bool_0 = true;
		dgvDSBaiViet.Rows.Clear();
		method_3(bool_0);
	}

	private void method_7(object sender, EventArgs e)
	{
	}

	private void F3AC7624(object sender, DataGridViewCellEventArgs e)
	{
		foreach (DataGridViewRow selectedRow in dgvBaiVietDaChon.SelectedRows)
		{
			dgvBaiVietDaChon.Rows.RemoveAt(selectedRow.Index);
		}
		lblCountAcc.Text = dgvBaiVietDaChon.Rows.Count.ToString();
	}

	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		try
		{
			DataGridViewRow dataGridViewRow = dgvDSBaiViet.SelectedRows[0];
			if (dataGridViewRow != null && GClass29.smethod_1("Bạn có muốn xóa bài viết này không?") == DialogResult.Yes)
			{
				int dB = Convert.ToInt32(dataGridViewRow.Cells[2].Value);
				Class15.CC321085(dB);
				dgvDSBaiViet.Rows.Remove(dataGridViewRow);
				method_0();
			}
		}
		catch
		{
		}
	}

	private void E3A3E88E(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void C6A05134(object sender, CancelEventArgs e)
	{
	}

	private void E5BDA48E(object sender, DataGridViewRowsAddedEventArgs e)
	{
		DDA37838();
		lblCountAcc.Text = dgvBaiVietDaChon.Rows.Count.ToString();
	}

	private void dgvBaiVietDaChon_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		DDA37838();
		lblCountAcc.Text = dgvBaiVietDaChon.Rows.Count.ToString();
	}

	private void cbbChuDe_SelectedIndexChanged(object sender, EventArgs e)
	{
		bool_0 = false;
		method_3(bool_0);
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && CA2827A7 != null)
		{
			CA2827A7.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		CA2827A7 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChonBaiViet));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		panel1 = new System.Windows.Forms.Panel();
		bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		D403EEA7 = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		E0A06714 = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		groupBox2 = new System.Windows.Forms.GroupBox();
		label3 = new System.Windows.Forms.Label();
		lblCountAcc = new System.Windows.Forms.Label();
		label7 = new System.Windows.Forms.Label();
		dgvBaiVietDaChon = new System.Windows.Forms.DataGridView();
		cStt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		FD098A09 = new System.Windows.Forms.GroupBox();
		B1832F9E = new System.Windows.Forms.Label();
		FF11088A = new System.Windows.Forms.Button();
		DDBC9C1C = new System.Windows.Forms.Label();
		cbbChuDe = new System.Windows.Forms.ComboBox();
		dgvDSBaiViet = new System.Windows.Forms.DataGridView();
		AD29931C = new System.Windows.Forms.DataGridViewTextBoxColumn();
		C21B4B94 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		A0311F27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		E10FC988 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
		B418130F = new System.Windows.Forms.DataGridViewTextBoxColumn();
		A321C014 = new System.Windows.Forms.ContextMenuStrip(CA2827A7);
		toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		F4BF1C8B = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		C208D310 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
		btnCancel = new System.Windows.Forms.Button();
		D500872F = new System.Windows.Forms.Button();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(CA2827A7);
		FAB79536 = new System.Windows.Forms.ToolTip(CA2827A7);
		panel1.SuspendLayout();
		bunifuCards2.SuspendLayout();
		D403EEA7.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)dgvBaiVietDaChon).BeginInit();
		FD098A09.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)dgvDSBaiViet).BeginInit();
		A321C014.SuspendLayout();
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
		bunifuCards1.Size = new System.Drawing.Size(270, 47);
		bunifuCards1.TabIndex = 12;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(bunifuCards2);
		panel1.Controls.Add(groupBox2);
		panel1.Controls.Add(FD098A09);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(D500872F);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(927, 517);
		panel1.TabIndex = 37;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(C40D0613);
		bunifuCards2.BackColor = System.Drawing.Color.White;
		bunifuCards2.BorderRadius = 0;
		bunifuCards2.BottomSahddow = true;
		bunifuCards2.color = System.Drawing.Color.SaddleBrown;
		bunifuCards2.Controls.Add(D403EEA7);
		bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards2.LeftSahddow = false;
		bunifuCards2.Location = new System.Drawing.Point(0, 0);
		bunifuCards2.Name = "bunifuCards2";
		bunifuCards2.RightSahddow = true;
		bunifuCards2.ShadowDepth = 20;
		bunifuCards2.Size = new System.Drawing.Size(925, 37);
		bunifuCards2.TabIndex = 43;
		D403EEA7.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		D403EEA7.BackColor = System.Drawing.Color.White;
		D403EEA7.Controls.Add(pictureBox1);
		D403EEA7.Controls.Add(E0A06714);
		D403EEA7.Controls.Add(bunifuCustomLabel1);
		D403EEA7.Cursor = System.Windows.Forms.Cursors.SizeAll;
		D403EEA7.Location = new System.Drawing.Point(0, 3);
		D403EEA7.Name = "pnlHeader";
		D403EEA7.Size = new System.Drawing.Size(925, 31);
		D403EEA7.TabIndex = 9;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(0, 4);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		E0A06714.Cursor = System.Windows.Forms.Cursors.Hand;
		E0A06714.FlatAppearance.BorderSize = 0;
		E0A06714.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E0A06714.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		E0A06714.ForeColor = System.Drawing.Color.White;
		E0A06714.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		E0A06714.Location = new System.Drawing.Point(896, 3);
		E0A06714.Name = "btnMinimize";
		E0A06714.Size = new System.Drawing.Size(30, 30);
		E0A06714.TabIndex = 9;
		E0A06714.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		E0A06714.UseVisualStyleBackColor = true;
		E0A06714.Click += new System.EventHandler(E3AE00B1);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(925, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Chọn bình luận";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		groupBox2.BackColor = System.Drawing.Color.White;
		groupBox2.Controls.Add(label3);
		groupBox2.Controls.Add(lblCountAcc);
		groupBox2.Controls.Add(label7);
		groupBox2.Controls.Add(dgvBaiVietDaChon);
		groupBox2.Location = new System.Drawing.Point(465, 40);
		groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
		groupBox2.Name = "groupBox2";
		groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
		groupBox2.Size = new System.Drawing.Size(454, 423);
		groupBox2.TabIndex = 41;
		groupBox2.TabStop = false;
		groupBox2.Text = "Bình luận cần sử dụng";
		label3.AutoSize = true;
		label3.ForeColor = System.Drawing.Color.Red;
		label3.Location = new System.Drawing.Point(6, 401);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(166, 16);
		label3.TabIndex = 80;
		label3.Text = "(Click đúp vào dòng để xóa)";
		lblCountAcc.AutoSize = true;
		lblCountAcc.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		lblCountAcc.ForeColor = System.Drawing.Color.Blue;
		lblCountAcc.Location = new System.Drawing.Point(349, 401);
		lblCountAcc.Name = "lblCountAcc";
		lblCountAcc.Size = new System.Drawing.Size(15, 16);
		lblCountAcc.TabIndex = 78;
		lblCountAcc.Text = "0";
		label7.AutoSize = true;
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		label7.Location = new System.Drawing.Point(307, 401);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(43, 16);
		label7.TabIndex = 79;
		label7.Text = "Tổng:";
		dgvBaiVietDaChon.AllowUserToAddRows = false;
		dgvBaiVietDaChon.AllowUserToDeleteRows = false;
		dgvBaiVietDaChon.AllowUserToResizeRows = false;
		dgvBaiVietDaChon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		dgvBaiVietDaChon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		dgvBaiVietDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dgvBaiVietDaChon.Columns.AddRange(cStt1, dataGridViewTextBoxColumn2, cId, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, Column1);
		dgvBaiVietDaChon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		dgvBaiVietDaChon.Location = new System.Drawing.Point(6, 52);
		dgvBaiVietDaChon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		dgvBaiVietDaChon.MultiSelect = false;
		dgvBaiVietDaChon.Name = "dgvBaiVietDaChon";
		dgvBaiVietDaChon.RowHeadersVisible = false;
		dgvBaiVietDaChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		dgvBaiVietDaChon.Size = new System.Drawing.Size(444, 345);
		dgvBaiVietDaChon.TabIndex = 76;
		dgvBaiVietDaChon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(F3AC7624);
		dgvBaiVietDaChon.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(E5BDA48E);
		dgvBaiVietDaChon.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(dgvBaiVietDaChon_RowsRemoved);
		cStt1.HeaderText = "STT";
		cStt1.Name = "cStt1";
		cStt1.Width = 35;
		dataGridViewTextBoxColumn2.HeaderText = "Chủ đề";
		dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
		cId.HeaderText = "ID Bài viết";
		cId.Name = "cId";
		cId.Visible = false;
		cId.Width = 90;
		dataGridViewTextBoxColumn4.HeaderText = "Tiêu đề";
		dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
		dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		dataGridViewTextBoxColumn4.Width = 230;
		dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewTextBoxColumn5.HeaderText = "Ảnh";
		dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
		Column1.HeaderText = "Video";
		Column1.Name = "Column1";
		Column1.Visible = false;
		Column1.Width = 50;
		FD098A09.BackColor = System.Drawing.Color.White;
		FD098A09.Controls.Add(B1832F9E);
		FD098A09.Controls.Add(FF11088A);
		FD098A09.Controls.Add(DDBC9C1C);
		FD098A09.Controls.Add(cbbChuDe);
		FD098A09.Controls.Add(dgvDSBaiViet);
		FD098A09.Location = new System.Drawing.Point(3, 39);
		FD098A09.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
		FD098A09.Name = "groupBox1";
		FD098A09.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
		FD098A09.Size = new System.Drawing.Size(456, 423);
		FD098A09.TabIndex = 42;
		FD098A09.TabStop = false;
		FD098A09.Text = "Danh sách bình luận";
		B1832F9E.AutoSize = true;
		B1832F9E.ForeColor = System.Drawing.Color.Red;
		B1832F9E.Location = new System.Drawing.Point(7, 401);
		B1832F9E.Name = "label2";
		B1832F9E.Size = new System.Drawing.Size(173, 16);
		B1832F9E.TabIndex = 80;
		B1832F9E.Text = "(Click đúp vào dòng để chọn)";
		FF11088A.Cursor = System.Windows.Forms.Cursors.Hand;
		FF11088A.Location = new System.Drawing.Point(341, 23);
		FF11088A.Name = "metroButton1";
		FF11088A.Size = new System.Drawing.Size(109, 25);
		FF11088A.TabIndex = 79;
		FF11088A.Text = "Quản lý chủ đề";
		FF11088A.Click += new System.EventHandler(FF11088A_Click);
		DDBC9C1C.AutoSize = true;
		DDBC9C1C.Location = new System.Drawing.Point(8, 27);
		DDBC9C1C.Name = "label1";
		DDBC9C1C.Size = new System.Drawing.Size(52, 16);
		DDBC9C1C.TabIndex = 78;
		DDBC9C1C.Text = "Chủ đề:";
		cbbChuDe.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbChuDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbChuDe.FormattingEnabled = true;
		cbbChuDe.Location = new System.Drawing.Point(64, 23);
		cbbChuDe.Name = "cbbChuDe";
		cbbChuDe.Size = new System.Drawing.Size(271, 24);
		cbbChuDe.TabIndex = 77;
		cbbChuDe.SelectedIndexChanged += new System.EventHandler(cbbChuDe_SelectedIndexChanged);
		dgvDSBaiViet.AllowUserToAddRows = false;
		dgvDSBaiViet.AllowUserToDeleteRows = false;
		dgvDSBaiViet.AllowUserToResizeRows = false;
		dgvDSBaiViet.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		dgvDSBaiViet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		dgvDSBaiViet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dgvDSBaiViet.Columns.AddRange(AD29931C, C21B4B94, A0311F27, E10FC988, cAnh, B418130F);
		dgvDSBaiViet.ContextMenuStrip = A321C014;
		dgvDSBaiViet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		dgvDSBaiViet.Location = new System.Drawing.Point(10, 54);
		dgvDSBaiViet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		dgvDSBaiViet.MultiSelect = false;
		dgvDSBaiViet.Name = "dgvDSBaiViet";
		dgvDSBaiViet.RowHeadersVisible = false;
		dgvDSBaiViet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		dgvDSBaiViet.Size = new System.Drawing.Size(440, 343);
		dgvDSBaiViet.TabIndex = 76;
		dgvDSBaiViet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(E3A3E88E);
		dgvDSBaiViet.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvDSBaiViet_CellDoubleClick);
		AD29931C.HeaderText = "STT";
		AD29931C.Name = "cStt";
		AD29931C.Width = 35;
		C21B4B94.HeaderText = "Chủ đề";
		C21B4B94.Name = "cChuDe";
		A0311F27.HeaderText = "ID Bài viết";
		A0311F27.Name = "cIdBaiViet";
		A0311F27.Visible = false;
		A0311F27.Width = 90;
		E10FC988.HeaderText = "Tiêu đề";
		E10FC988.Name = "cTieuDe";
		E10FC988.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		E10FC988.Width = 230;
		cAnh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		cAnh.HeaderText = "Ảnh";
		cAnh.Name = "cAnh";
		B418130F.HeaderText = "Video";
		B418130F.Name = "cVideo";
		B418130F.Visible = false;
		B418130F.Width = 50;
		A321C014.Items.AddRange(new System.Windows.Forms.ToolStripItem[6] { toolStripMenuItem_0, F4BF1C8B, toolStripMenuItem_1, toolStripMenuItem_2, C208D310, toolStripMenuItem_3 });
		A321C014.Name = "contextMenuStrip1";
		A321C014.Size = new System.Drawing.Size(202, 136);
		A321C014.Opening += new System.ComponentModel.CancelEventHandler(C6A05134);
		toolStripMenuItem_0.Name = "thêmBàiViếtToolStripMenuItem";
		toolStripMenuItem_0.Size = new System.Drawing.Size(201, 22);
		toolStripMenuItem_0.Text = "Thêm bình luận";
		toolStripMenuItem_0.Click += new System.EventHandler(A98353A0);
		F4BF1C8B.Name = "sửaBàiViếtToolStripMenuItem";
		F4BF1C8B.Size = new System.Drawing.Size(201, 22);
		F4BF1C8B.Text = "Sửa bình luận";
		F4BF1C8B.Click += new System.EventHandler(F4BF1C8B_Click);
		toolStripMenuItem_1.Name = "xóaBàiViếtToolStripMenuItem";
		toolStripMenuItem_1.Size = new System.Drawing.Size(201, 22);
		toolStripMenuItem_1.Text = "Xóa bình luận";
		toolStripMenuItem_1.Click += new System.EventHandler(toolStripMenuItem_1_Click);
		toolStripMenuItem_2.Name = "chiTiếtBàiViếtToolStripMenuItem";
		toolStripMenuItem_2.Size = new System.Drawing.Size(201, 22);
		toolStripMenuItem_2.Text = "Chi tiết bình luận";
		toolStripMenuItem_2.Click += new System.EventHandler(C51A4533);
		C208D310.Name = "làmMớiDanhSáchToolStripMenuItem";
		C208D310.Size = new System.Drawing.Size(201, 22);
		C208D310.Text = "Làm mới danh sách";
		C208D310.Click += new System.EventHandler(C208D310_Click);
		toolStripMenuItem_3.Name = "hiểnThịTấtCảBàiViếtToolStripMenuItem";
		toolStripMenuItem_3.Size = new System.Drawing.Size(201, 22);
		toolStripMenuItem_3.Text = "Hiển thị tất cả bình luận";
		toolStripMenuItem_3.Click += new System.EventHandler(toolStripMenuItem_3_Click);
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(468, 473);
		btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 20;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(E3AE00B1);
		D500872F.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		D500872F.Cursor = System.Windows.Forms.Cursors.Hand;
		D500872F.FlatAppearance.BorderSize = 0;
		D500872F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D500872F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D500872F.ForeColor = System.Drawing.Color.White;
		D500872F.Location = new System.Drawing.Point(361, 473);
		D500872F.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		D500872F.Name = "btnSave";
		D500872F.Size = new System.Drawing.Size(92, 29);
		D500872F.TabIndex = 19;
		D500872F.Text = "Lưu";
		D500872F.UseVisualStyleBackColor = false;
		D500872F.Click += new System.EventHandler(D500872F_Click);
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		FAB79536.AutomaticDelay = 0;
		FAB79536.AutoPopDelay = 10000;
		FAB79536.InitialDelay = 200;
		FAB79536.ReshowDelay = 40;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(927, 517);
		base.Controls.Add(panel1);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fChonBaiViet";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fChonBaiViet_Load);
		panel1.ResumeLayout(false);
		bunifuCards2.ResumeLayout(false);
		D403EEA7.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		groupBox2.ResumeLayout(false);
		groupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)dgvBaiVietDaChon).EndInit();
		FD098A09.ResumeLayout(false);
		FD098A09.PerformLayout();
		((System.ComponentModel.ISupportInitialize)dgvDSBaiViet).EndInit();
		A321C014.ResumeLayout(false);
		ResumeLayout(false);
	}
}
