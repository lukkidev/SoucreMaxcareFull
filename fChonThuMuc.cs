using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fChonThuMuc : Form
{
	private bool bool_0 = false;

	public static List<string> list_0;

	public static List<string> E025E18D;

	public static bool bool_1;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel B43BC28C;

	private BunifuCustomLabel FAAB8486;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl CC9FBC99;

	private PictureBox pictureBox1;

	private Label label1;

	private Label lblCountTotal;

	private Label label3;

	private Label lblCountChoose;

	private Label label2;

	public DataGridView dtgvAcc;

	private CheckBox F5017502;

	private DataGridViewCheckBoxColumn E51FC99D;

	private DataGridViewTextBoxColumn B49C0235;

	private DataGridViewTextBoxColumn B394781C;

	private DataGridViewTextBoxColumn cThuMuc;

	private Button button4;

	private Button button5;

	public fChonThuMuc(bool bool_2 = false)
	{
		InitializeComponent();
		bool_1 = false;
		bool_0 = bool_2;
		F7AB102E.D6B70A35(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		bool_1 = true;
		if (bool_0)
		{
			E025E18D = new List<string>();
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					E025E18D.Add(GClass27.smethod_3(dtgvAcc, i, "cId"));
				}
			}
			if (E025E18D.Count == 0)
			{
				GClass29.smethod_0("Vui lòng chọn ít nhất 1 thư mục!", 2);
				return;
			}
		}
		else
		{
			list_0 = new List<string>();
			for (int j = 0; j < dtgvAcc.Rows.Count; j++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[j].Cells["cChose"].Value))
				{
					list_0.Add(GClass27.smethod_3(dtgvAcc, j, "cId"));
				}
			}
			if (list_0.Count == 0)
			{
				GClass29.smethod_0("Vui lòng chọn ít nhất 1 thư mục!", 2);
				return;
			}
		}
		Close();
	}

	private void B8A4E22F(object sender, EventArgs e)
	{
		Close();
	}

	private void fChonThuMuc_Load(object sender, EventArgs e)
	{
		if (bool_0)
		{
			if (E025E18D == null)
			{
				E025E18D = new List<string>();
			}
			method_0(E025E18D);
		}
		else
		{
			if (list_0 == null)
			{
				list_0 = new List<string>();
			}
			method_0(list_0);
		}
	}

	private void method_0(List<string> list_1 = null)
	{
		try
		{
			DataTable dataTable = ((!bool_0) ? Class15.smethod_1() : Class15.smethod_1(bool_0: false, bool_1: true));
			if (list_1 != null && list_1.Count > 0)
			{
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					if (list_1.Contains(dataTable.Rows[i]["id"].ToString()))
					{
						dtgvAcc.Rows.Add(true, i + 1, dataTable.Rows[i]["id"], dataTable.Rows[i]["name"]);
					}
					else
					{
						dtgvAcc.Rows.Add(false, i + 1, dataTable.Rows[i]["id"], dataTable.Rows[i]["name"]);
					}
				}
			}
			else
			{
				for (int j = 0; j < dataTable.Rows.Count; j++)
				{
					dtgvAcc.Rows.Add(false, j + 1, dataTable.Rows[j]["id"], dataTable.Rows[j]["name"]);
				}
			}
			method_1();
			method_2();
			if (E1B6F69E() == dtgvAcc.RowCount)
			{
				F5017502.Checked = true;
			}
			else
			{
				F5017502.Checked = false;
			}
		}
		catch (Exception exception_)
		{
			GClass8.smethod_62(exception_, "LoadListFiles");
			GClass29.smethod_0("Có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void method_1()
	{
		try
		{
			lblCountChoose.Text = E1B6F69E().ToString();
		}
		catch
		{
		}
	}

	private void AF97AA3B(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex == 0 && e.RowIndex > -1)
		{
			method_1();
			if (E1B6F69E() == dtgvAcc.RowCount)
			{
				F5017502.Checked = true;
			}
			else
			{
				F5017502.Checked = false;
			}
		}
	}

	private void method_2()
	{
		try
		{
			lblCountTotal.Text = dtgvAcc.Rows.Count.ToString();
		}
		catch
		{
		}
	}

	private void dtgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			if (Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value))
			{
				dtgvAcc.CurrentRow.Cells["cChose"].Value = false;
			}
			else
			{
				dtgvAcc.CurrentRow.Cells["cChose"].Value = true;
			}
		}
		catch
		{
		}
	}

	private int E1B6F69E()
	{
		int num = 0;
		for (int i = 0; i < dtgvAcc.Rows.Count; i++)
		{
			if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
			{
				num++;
			}
		}
		return num;
	}

	private void BD871325(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex != 0 || e.RowIndex <= -1)
		{
			return;
		}
		try
		{
			if (Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value))
			{
				dtgvAcc.CurrentRow.Cells["cChose"].Value = false;
			}
			else
			{
				dtgvAcc.CurrentRow.Cells["cChose"].Value = true;
			}
		}
		catch
		{
		}
	}

	private void B4BEB784(object sender, EventArgs e)
	{
		if (F5017502.Checked)
		{
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				GClass27.smethod_5(dtgvAcc, i, "cChose", true);
			}
		}
		else
		{
			for (int j = 0; j < dtgvAcc.Rows.Count; j++)
			{
				GClass27.smethod_5(dtgvAcc, j, "cChose", false);
			}
		}
	}

	private void button5_Click(object sender, EventArgs e)
	{
		int index = dtgvAcc.SelectedRows[0].Index;
		if (index == 0)
		{
			return;
		}
		string text = GClass27.smethod_3(dtgvAcc, index - 1, "cId");
		string text2 = GClass27.smethod_3(dtgvAcc, index, "cId");
		if (text + text2 != "")
		{
			if (Class15.smethod_30(text, text2))
			{
				GClass8.smethod_79(ref dtgvAcc, index, index - 1, 2);
				dtgvAcc.ClearSelection();
				dtgvAcc.Rows[index - 1].Selected = true;
			}
			else
			{
				GClass29.smethod_0("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void button4_Click(object sender, EventArgs e)
	{
		int index = dtgvAcc.SelectedRows[0].Index;
		if (index == dtgvAcc.RowCount - 1)
		{
			return;
		}
		string text = GClass27.smethod_3(dtgvAcc, index + 1, "cId");
		string text2 = GClass27.smethod_3(dtgvAcc, index, "cId");
		if (text + text2 != "")
		{
			if (Class15.smethod_30(text, text2))
			{
				GClass8.smethod_79(ref dtgvAcc, index, index + 1, 2);
				dtgvAcc.ClearSelection();
				dtgvAcc.Rows[index + 1].Selected = true;
			}
			else
			{
				GClass29.smethod_0("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void dtgvAcc_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyValue == 32)
		{
			for (int i = 0; i < dtgvAcc.SelectedRows.Count; i++)
			{
				int index = dtgvAcc.SelectedRows[i].Index;
				GClass27.smethod_5(dtgvAcc, index, "cChose", !Convert.ToBoolean(GClass27.smethod_3(dtgvAcc, index, "cChose")));
			}
			E1B6F69E();
		}
	}

	protected override void Dispose(bool C2A16BA5)
	{
		if (C2A16BA5 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C2A16BA5);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChonThuMuc));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		B43BC28C = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		FAAB8486 = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		CC9FBC99 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		label1 = new System.Windows.Forms.Label();
		lblCountTotal = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		lblCountChoose = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		dtgvAcc = new System.Windows.Forms.DataGridView();
		E51FC99D = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		B49C0235 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		B394781C = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cThuMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
		F5017502 = new System.Windows.Forms.CheckBox();
		button4 = new System.Windows.Forms.Button();
		button5 = new System.Windows.Forms.Button();
		bunifuCards1.SuspendLayout();
		B43BC28C.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)dtgvAcc).BeginInit();
		SuspendLayout();
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.Controls.Add(B43BC28C);
		bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(487, 34);
		bunifuCards1.TabIndex = 0;
		B43BC28C.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		B43BC28C.BackColor = System.Drawing.Color.White;
		B43BC28C.Controls.Add(pictureBox1);
		B43BC28C.Controls.Add(btnMinimize);
		B43BC28C.Controls.Add(FAAB8486);
		B43BC28C.Location = new System.Drawing.Point(0, 3);
		B43BC28C.Name = "pnlHeader";
		B43BC28C.Size = new System.Drawing.Size(487, 28);
		B43BC28C.TabIndex = 9;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 17;
		pictureBox1.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(455, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 28);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		FAAB8486.BackColor = System.Drawing.Color.Transparent;
		FAAB8486.Cursor = System.Windows.Forms.Cursors.SizeAll;
		FAAB8486.Dock = System.Windows.Forms.DockStyle.Fill;
		FAAB8486.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		FAAB8486.ForeColor = System.Drawing.Color.Black;
		FAAB8486.Location = new System.Drawing.Point(0, 0);
		FAAB8486.Name = "bunifuCustomLabel1";
		FAAB8486.Size = new System.Drawing.Size(487, 28);
		FAAB8486.TabIndex = 1;
		FAAB8486.Text = "Chọn Danh sách thư mục";
		FAAB8486.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(248, 374);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(B8A4E22F);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(144, 374);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		CC9FBC99.Fixed = true;
		CC9FBC99.Horizontal = true;
		CC9FBC99.TargetControl = FAAB8486;
		CC9FBC99.Vertical = true;
		label1.AutoSize = true;
		label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label1.Location = new System.Drawing.Point(263, 346);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(58, 16);
		label1.TabIndex = 6;
		label1.Text = "Tổng số:";
		lblCountTotal.AutoSize = true;
		lblCountTotal.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblCountTotal.ForeColor = System.Drawing.Color.DarkRed;
		lblCountTotal.Location = new System.Drawing.Point(321, 347);
		lblCountTotal.Name = "lblCountTotal";
		lblCountTotal.Size = new System.Drawing.Size(14, 16);
		lblCountTotal.TabIndex = 6;
		lblCountTotal.Text = "0";
		label3.AutoSize = true;
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(128, 346);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(59, 16);
		label3.TabIndex = 6;
		label3.Text = "Đã chọn:";
		lblCountChoose.AutoSize = true;
		lblCountChoose.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblCountChoose.ForeColor = System.Drawing.Color.DarkGreen;
		lblCountChoose.Location = new System.Drawing.Point(186, 347);
		lblCountChoose.Name = "lblCountChoose";
		lblCountChoose.Size = new System.Drawing.Size(14, 16);
		lblCountChoose.TabIndex = 6;
		lblCountChoose.Text = "0";
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label2.ForeColor = System.Drawing.Color.DarkRed;
		label2.Location = new System.Drawing.Point(12, 320);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(177, 16);
		label2.TabIndex = 6;
		label2.Text = "(Click đúp vào dòng để chọn!)";
		dtgvAcc.AllowUserToAddRows = false;
		dtgvAcc.AllowUserToDeleteRows = false;
		dtgvAcc.AllowUserToResizeRows = false;
		dtgvAcc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		dtgvAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		dtgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dtgvAcc.Columns.AddRange(E51FC99D, B49C0235, B394781C, cThuMuc);
		dtgvAcc.Location = new System.Drawing.Point(15, 40);
		dtgvAcc.Name = "dtgvAcc";
		dtgvAcc.ReadOnly = true;
		dtgvAcc.RowHeadersVisible = false;
		dtgvAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		dtgvAcc.Size = new System.Drawing.Size(415, 277);
		dtgvAcc.TabIndex = 7;
		dtgvAcc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(BD871325);
		dtgvAcc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellDoubleClick);
		dtgvAcc.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(AF97AA3B);
		dtgvAcc.KeyDown += new System.Windows.Forms.KeyEventHandler(dtgvAcc_KeyDown);
		E51FC99D.HeaderText = "";
		E51FC99D.Name = "cChose";
		E51FC99D.ReadOnly = true;
		E51FC99D.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		E51FC99D.Width = 30;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		B49C0235.DefaultCellStyle = dataGridViewCellStyle2;
		B49C0235.HeaderText = "STT";
		B49C0235.Name = "cStt";
		B49C0235.ReadOnly = true;
		B49C0235.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		B49C0235.Width = 35;
		B394781C.HeaderText = "Id";
		B394781C.Name = "cId";
		B394781C.ReadOnly = true;
		B394781C.Visible = false;
		B394781C.Width = 90;
		cThuMuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		cThuMuc.HeaderText = "Thư mục";
		cThuMuc.Name = "cThuMuc";
		cThuMuc.ReadOnly = true;
		F5017502.AutoSize = true;
		F5017502.Cursor = System.Windows.Forms.Cursors.Hand;
		F5017502.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		F5017502.Location = new System.Drawing.Point(25, 45);
		F5017502.Name = "checkBox1";
		F5017502.Size = new System.Drawing.Size(15, 14);
		F5017502.TabIndex = 8;
		F5017502.UseVisualStyleBackColor = true;
		F5017502.Click += new System.EventHandler(B4BEB784);
		button4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button4.Cursor = System.Windows.Forms.Cursors.Hand;
		button4.Image = C50FB39E.Bitmap_87;
		button4.Location = new System.Drawing.Point(436, 85);
		button4.Name = "button4";
		button4.Size = new System.Drawing.Size(41, 38);
		button4.TabIndex = 81;
		button4.UseVisualStyleBackColor = true;
		button4.Click += new System.EventHandler(button4_Click);
		button5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button5.Cursor = System.Windows.Forms.Cursors.Hand;
		button5.Image = C50FB39E.Bitmap_140;
		button5.Location = new System.Drawing.Point(436, 40);
		button5.Name = "button5";
		button5.Size = new System.Drawing.Size(41, 38);
		button5.TabIndex = 82;
		button5.UseVisualStyleBackColor = true;
		button5.Click += new System.EventHandler(button5_Click);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(487, 415);
		base.Controls.Add(button4);
		base.Controls.Add(button5);
		base.Controls.Add(F5017502);
		base.Controls.Add(dtgvAcc);
		base.Controls.Add(lblCountChoose);
		base.Controls.Add(label2);
		base.Controls.Add(lblCountTotal);
		base.Controls.Add(label3);
		base.Controls.Add(label1);
		base.Controls.Add(btnCancel);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fChonThuMuc";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(fChonThuMuc_Load);
		bunifuCards1.ResumeLayout(false);
		B43BC28C.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)dtgvAcc).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
