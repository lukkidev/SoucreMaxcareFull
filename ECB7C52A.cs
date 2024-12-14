using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class ECB7C52A : Form
{
	private IContainer icontainer_0 = null;

	private ToolTip toolTip_0;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl F3BDA997;

	private GroupBox groupBox1;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private PictureBox B0865DBC;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button button1;

	public DataGridView dtgvKichBan;

	private Panel panel1;

	private Button D496061B;

	private Button F7A00510;

	private GroupBox B1AA8889;

	private Label C8355B90;

	private Button CC95BC09;

	private Button btnSave;

	private Label CA01959E;

	private Label D2979534;

	private Label D43BB58A;

	public DataGridView dtgvKichBanChoose;

	private DataGridViewTextBoxColumn cStt;

	private DataGridViewTextBoxColumn cIdKichBan;

	private DataGridViewTextBoxColumn F4035A1E;

	private DataGridViewTextBoxColumn cSTTChoose;

	private DataGridViewTextBoxColumn D702CAA3;

	private DataGridViewTextBoxColumn E386E9A1;

	public ECB7C52A()
	{
		E0BD0020();
		F7AB102E.D6B70A35(this);
	}

	private void ECB7C52A_Load(object sender, EventArgs e)
	{
		BF0CCF08();
		BF0CCF08(GClass25.smethod_0("configInteractGeneral").C5A69DA0("lstIdKichBan"));
	}

	private void BF0CCF08(List<string> list_0 = null)
	{
		try
		{
			if (list_0 != null && list_0.Count > 0)
			{
				dtgvKichBanChoose.Rows.Clear();
				for (int i = 0; i < list_0.Count; i++)
				{
					DataTable dataTable = Class147.smethod_1(list_0[i]);
					if (dataTable.Rows.Count > 0)
					{
						DataRow dataRow = dataTable.Rows[0];
						dtgvKichBanChoose.Rows.Add(dtgvKichBanChoose.RowCount + 1, dataRow["Id_KichBan"], dataRow["TenKichBan"]);
					}
				}
				return;
			}
			dtgvKichBan.Rows.Clear();
			DataTable dataTable2 = Class147.CD078893();
			if (dataTable2.Rows.Count > 0)
			{
				for (int j = 0; j < dataTable2.Rows.Count; j++)
				{
					DataRow dataRow2 = dataTable2.Rows[j];
					dtgvKichBan.Rows.Add(j + 1, dataRow2["Id_KichBan"], dataRow2["TenKichBan"]);
				}
			}
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA);
		}
	}

	private void CD85443D(object sender, EventArgs e)
	{
		Close();
	}

	public void BF2C9E0E(ref DataGridView BA104B93, int int_0, int int_1)
	{
		string text = "";
		for (int i = 1; i < BA104B93.Columns.Count; i++)
		{
			text = GClass27.smethod_2(BA104B93, int_0, i);
			GClass27.smethod_4(BA104B93, int_0, i, GClass27.smethod_2(BA104B93, int_1, i));
			GClass27.smethod_4(BA104B93, int_1, i, text);
		}
	}

	private void D496061B_Click(object sender, EventArgs e)
	{
		int index = dtgvKichBanChoose.SelectedRows[0].Index;
		if (index != 0)
		{
			string text = GClass27.smethod_3(dtgvKichBanChoose, index - 1, "cIdKichBanChoose");
			string text2 = GClass27.smethod_3(dtgvKichBanChoose, index, "cIdKichBanChoose");
			if (text + text2 != "")
			{
				BF2C9E0E(ref dtgvKichBanChoose, index, index - 1);
				dtgvKichBanChoose.Rows[index - 1].Selected = true;
			}
		}
	}

	private void F7A00510_Click(object sender, EventArgs e)
	{
		int index = dtgvKichBanChoose.SelectedRows[0].Index;
		if (index != dtgvKichBanChoose.RowCount - 1)
		{
			string text = GClass27.smethod_3(dtgvKichBanChoose, index + 1, "cIdKichBanChoose");
			string text2 = GClass27.smethod_3(dtgvKichBanChoose, index, "cIdKichBanChoose");
			if (text + text2 != "")
			{
				BF2C9E0E(ref dtgvKichBanChoose, index, index + 1);
				dtgvKichBanChoose.Rows[index + 1].Selected = true;
			}
		}
	}

	private void BF035A03(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void CC95BC09_Click(object sender, EventArgs e)
	{
		Close();
	}

	private bool method_0(string string_0)
	{
		bool result = false;
		for (int i = 0; i < dtgvKichBanChoose.RowCount; i++)
		{
			if (string_0 == dtgvKichBanChoose.Rows[i].Cells[1].Value.ToString())
			{
				result = true;
				break;
			}
		}
		return result;
	}

	private void dtgvKichBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		int num = Convert.ToInt32(dtgvKichBan.SelectedRows[0].Cells[1].Value);
		string text = dtgvKichBan.SelectedRows[0].Cells[2].Value.ToString();
		if (!method_0(num.ToString()))
		{
			dtgvKichBanChoose.Rows.Add(dtgvKichBanChoose.RowCount + 1, num, text);
		}
	}

	private void dtgvKichBanChoose_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		dtgvKichBanChoose.Rows.RemoveAt(dtgvKichBanChoose.SelectedRows[0].Index);
		for (int i = 0; i < dtgvKichBanChoose.RowCount; i++)
		{
			GClass27.smethod_5(dtgvKichBanChoose, i, "cSTTChoose", i + 1);
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dtgvKichBanChoose.RowCount; i++)
			{
				list.Add(GClass27.smethod_3(dtgvKichBanChoose, i, "cIdKichBanChoose"));
			}
			GClass25.smethod_0("configInteractGeneral").method_5("lstIdKichBan", list);
			GClass25.B3B73732("configInteractGeneral");
			Close();
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA);
			GClass29.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!", 3);
		}
	}

	private void dtgvKichBanChoose_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
	{
		CA01959E.Text = dtgvKichBanChoose.RowCount.ToString();
	}

	private void dtgvKichBanChoose_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		CA01959E.Text = dtgvKichBanChoose.RowCount.ToString();
	}

	protected override void Dispose(bool C900300F)
	{
		if (C900300F && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C900300F);
	}

	private void E0BD0020()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ECB7C52A));
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		toolTip_0 = new ToolTip(icontainer_0);
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		F3BDA997 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		button1 = new Button();
		B0865DBC = new PictureBox();
		groupBox1 = new GroupBox();
		C8355B90 = new Label();
		dtgvKichBan = new DataGridView();
		cStt = new DataGridViewTextBoxColumn();
		cIdKichBan = new DataGridViewTextBoxColumn();
		F4035A1E = new DataGridViewTextBoxColumn();
		bunifuCards1 = new BunifuCards();
		panel1 = new Panel();
		CC95BC09 = new Button();
		btnSave = new Button();
		B1AA8889 = new GroupBox();
		CA01959E = new Label();
		D2979534 = new Label();
		D43BB58A = new Label();
		F7A00510 = new Button();
		dtgvKichBanChoose = new DataGridView();
		cSTTChoose = new DataGridViewTextBoxColumn();
		D702CAA3 = new DataGridViewTextBoxColumn();
		E386E9A1 = new DataGridViewTextBoxColumn();
		D496061B = new Button();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)B0865DBC).BeginInit();
		groupBox1.SuspendLayout();
		((ISupportInitialize)dtgvKichBan).BeginInit();
		bunifuCards1.SuspendLayout();
		panel1.SuspendLayout();
		B1AA8889.SuspendLayout();
		((ISupportInitialize)dtgvKichBanChoose).BeginInit();
		SuspendLayout();
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		toolTip_0.ToolTipTitle = "Chú thích";
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(696, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Chọn danh sách kịch bản chạy";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		F3BDA997.Fixed = true;
		F3BDA997.Horizontal = true;
		F3BDA997.TargetControl = pnlHeader;
		F3BDA997.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(B0865DBC);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(696, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(667, 2);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += CD85443D;
		B0865DBC.Cursor = Cursors.Default;
		B0865DBC.Image = C50FB39E.Bitmap_5;
		B0865DBC.Location = new Point(3, 2);
		B0865DBC.Name = "pictureBox1";
		B0865DBC.Size = new Size(34, 27);
		B0865DBC.SizeMode = PictureBoxSizeMode.Zoom;
		B0865DBC.TabIndex = 76;
		B0865DBC.TabStop = false;
		groupBox1.BackColor = Color.White;
		groupBox1.Controls.Add(C8355B90);
		groupBox1.Controls.Add(dtgvKichBan);
		groupBox1.Location = new Point(12, 41);
		groupBox1.Margin = new Padding(3, 4, 3, 4);
		groupBox1.Name = "groupBox1";
		groupBox1.Padding = new Padding(3, 4, 3, 4);
		groupBox1.Size = new Size(308, 302);
		groupBox1.TabIndex = 1;
		groupBox1.TabStop = false;
		groupBox1.Text = "Danh sách kịch bản";
		C8355B90.AutoSize = true;
		C8355B90.ForeColor = Color.Red;
		C8355B90.Location = new Point(3, 281);
		C8355B90.Name = "label2";
		C8355B90.Size = new Size(192, 16);
		C8355B90.TabIndex = 81;
		C8355B90.Text = "(Click đúp vào kịch bản để chọn)";
		dtgvKichBan.AllowUserToAddRows = false;
		dtgvKichBan.AllowUserToDeleteRows = false;
		dtgvKichBan.AllowUserToResizeRows = false;
		dtgvKichBan.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = SystemColors.Control;
		dataGridViewCellStyle.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		dtgvKichBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		dtgvKichBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dtgvKichBan.Columns.AddRange(cStt, cIdKichBan, F4035A1E);
		dtgvKichBan.EditMode = DataGridViewEditMode.EditProgrammatically;
		dtgvKichBan.Location = new Point(6, 20);
		dtgvKichBan.MultiSelect = false;
		dtgvKichBan.Name = "dtgvKichBan";
		dtgvKichBan.RowHeadersVisible = false;
		dtgvKichBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dtgvKichBan.Size = new Size(296, 258);
		dtgvKichBan.TabIndex = 76;
		dtgvKichBan.CellDoubleClick += dtgvKichBan_CellDoubleClick;
		cStt.HeaderText = "STT";
		cStt.Name = "cStt";
		cStt.Width = 35;
		cIdKichBan.HeaderText = "Id kịch bản";
		cIdKichBan.Name = "cIdKichBan";
		cIdKichBan.Visible = false;
		F4035A1E.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		F4035A1E.HeaderText = "Tên kịch bản";
		F4035A1E.Name = "cTenKichBan";
		F4035A1E.SortMode = DataGridViewColumnSortMode.NotSortable;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(699, 37);
		bunifuCards1.TabIndex = 12;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(CC95BC09);
		panel1.Controls.Add(btnSave);
		panel1.Controls.Add(bunifuCards1);
		panel1.Controls.Add(B1AA8889);
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(702, 391);
		panel1.TabIndex = 13;
		panel1.Paint += BF035A03;
		CC95BC09.BackColor = Color.Maroon;
		CC95BC09.Cursor = Cursors.Hand;
		CC95BC09.FlatAppearance.BorderSize = 0;
		CC95BC09.FlatStyle = FlatStyle.Flat;
		CC95BC09.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		CC95BC09.ForeColor = Color.White;
		CC95BC09.Location = new Point(359, 350);
		CC95BC09.Margin = new Padding(3, 4, 3, 4);
		CC95BC09.Name = "btnCancel";
		CC95BC09.Size = new Size(92, 29);
		CC95BC09.TabIndex = 22;
		CC95BC09.Text = "Đóng";
		CC95BC09.UseVisualStyleBackColor = false;
		CC95BC09.Click += CC95BC09_Click;
		btnSave.BackColor = Color.FromArgb(53, 120, 229);
		btnSave.Cursor = Cursors.Hand;
		btnSave.FlatAppearance.BorderSize = 0;
		btnSave.FlatStyle = FlatStyle.Flat;
		btnSave.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnSave.ForeColor = Color.White;
		btnSave.Location = new Point(252, 350);
		btnSave.Margin = new Padding(3, 4, 3, 4);
		btnSave.Name = "btnSave";
		btnSave.Size = new Size(92, 29);
		btnSave.TabIndex = 21;
		btnSave.Text = "Lưu";
		btnSave.UseVisualStyleBackColor = false;
		btnSave.Click += btnSave_Click;
		B1AA8889.BackColor = Color.White;
		B1AA8889.Controls.Add(CA01959E);
		B1AA8889.Controls.Add(D2979534);
		B1AA8889.Controls.Add(D43BB58A);
		B1AA8889.Controls.Add(F7A00510);
		B1AA8889.Controls.Add(dtgvKichBanChoose);
		B1AA8889.Controls.Add(D496061B);
		B1AA8889.Location = new Point(325, 40);
		B1AA8889.Margin = new Padding(3, 4, 3, 4);
		B1AA8889.Name = "groupBox2";
		B1AA8889.Padding = new Padding(3, 4, 3, 4);
		B1AA8889.Size = new Size(363, 302);
		B1AA8889.TabIndex = 1;
		B1AA8889.TabStop = false;
		B1AA8889.Text = "Kịch bản cần chạy";
		CA01959E.AutoSize = true;
		CA01959E.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 163);
		CA01959E.ForeColor = Color.Blue;
		CA01959E.Location = new Point(297, 281);
		CA01959E.Name = "lblCountAcc";
		CA01959E.Size = new Size(15, 16);
		CA01959E.TabIndex = 82;
		CA01959E.Text = "0";
		D2979534.AutoSize = true;
		D2979534.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 163);
		D2979534.Location = new Point(255, 281);
		D2979534.Name = "label7";
		D2979534.Size = new Size(43, 16);
		D2979534.TabIndex = 83;
		D2979534.Text = "Tổng:";
		D43BB58A.AutoSize = true;
		D43BB58A.ForeColor = Color.Red;
		D43BB58A.Location = new Point(4, 282);
		D43BB58A.Name = "label1";
		D43BB58A.Size = new Size(185, 16);
		D43BB58A.TabIndex = 81;
		D43BB58A.Text = "(Click đúp vào kịch bản để xóa)";
		F7A00510.Cursor = Cursors.Hand;
		F7A00510.Image = C50FB39E.Bitmap_87;
		F7A00510.Location = new Point(314, 64);
		F7A00510.Name = "button3";
		F7A00510.Size = new Size(41, 38);
		F7A00510.TabIndex = 78;
		F7A00510.UseVisualStyleBackColor = true;
		F7A00510.Click += F7A00510_Click;
		dtgvKichBanChoose.AllowUserToAddRows = false;
		dtgvKichBanChoose.AllowUserToDeleteRows = false;
		dtgvKichBanChoose.AllowUserToResizeRows = false;
		dtgvKichBanChoose.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = SystemColors.Control;
		dataGridViewCellStyle2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
		dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
		dtgvKichBanChoose.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		dtgvKichBanChoose.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dtgvKichBanChoose.Columns.AddRange(cSTTChoose, D702CAA3, E386E9A1);
		dtgvKichBanChoose.EditMode = DataGridViewEditMode.EditProgrammatically;
		dtgvKichBanChoose.Location = new Point(6, 20);
		dtgvKichBanChoose.MultiSelect = false;
		dtgvKichBanChoose.Name = "dtgvKichBanChoose";
		dtgvKichBanChoose.RowHeadersVisible = false;
		dtgvKichBanChoose.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dtgvKichBanChoose.Size = new Size(302, 258);
		dtgvKichBanChoose.TabIndex = 76;
		dtgvKichBanChoose.CellDoubleClick += dtgvKichBanChoose_CellDoubleClick;
		dtgvKichBanChoose.RowsAdded += dtgvKichBanChoose_RowsAdded;
		dtgvKichBanChoose.RowsRemoved += dtgvKichBanChoose_RowsRemoved;
		cSTTChoose.HeaderText = "STT";
		cSTTChoose.Name = "cSTTChoose";
		cSTTChoose.Width = 35;
		D702CAA3.HeaderText = "Id kịch bản";
		D702CAA3.Name = "cIdKichBanChoose";
		D702CAA3.Visible = false;
		E386E9A1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		E386E9A1.HeaderText = "Tên kịch bản";
		E386E9A1.Name = "cTenKichBanChoose";
		E386E9A1.SortMode = DataGridViewColumnSortMode.NotSortable;
		D496061B.Cursor = Cursors.Hand;
		D496061B.Image = C50FB39E.Bitmap_140;
		D496061B.Location = new Point(314, 19);
		D496061B.Name = "button2";
		D496061B.Size = new Size(41, 38);
		D496061B.TabIndex = 78;
		D496061B.UseVisualStyleBackColor = true;
		D496061B.Click += D496061B_Click;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(702, 391);
		base.Controls.Add(groupBox1);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fChonKichBan";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Cấu hình tương tác";
		base.Load += ECB7C52A_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)B0865DBC).EndInit();
		groupBox1.ResumeLayout(performLayout: false);
		groupBox1.PerformLayout();
		((ISupportInitialize)dtgvKichBan).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		panel1.ResumeLayout(performLayout: false);
		B1AA8889.ResumeLayout(performLayout: false);
		B1AA8889.PerformLayout();
		((ISupportInitialize)dtgvKichBanChoose).EndInit();
		ResumeLayout(performLayout: false);
	}
}
