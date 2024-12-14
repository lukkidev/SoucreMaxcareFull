using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fQuanLyNhom : Form
{
	public bool B892D835 = false;

	private List<string> DE93C819;

	private List<string> A5A9C62A = new List<string>();

	private List<string> list_0 = new List<string>();

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private BunifuDragControl AE971A00;

	private PictureBox pictureBox1;

	private ContextMenuStrip EC1D0097;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem D5245E33;

	private ToolStripMenuItem tinhTrangToolStripMenuItem;

	private ToolStripMenuItem D538AABC;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem toolStripMenuItem_3;

	private ToolStripMenuItem toolStripMenuItem_4;

	private ToolStripMenuItem FF80B406;

	private ToolStripMenuItem falseToolStripMenuItem;

	private StatusStrip DDA3BA24;

	private ToolStripStatusLabel toolStripStatusLabel4;

	private ToolStripStatusLabel lblCountHighline;

	private ToolStripStatusLabel CA1B9317;

	private ToolStripStatusLabel E09D9B3D;

	private ToolStripStatusLabel toolStripStatusLabel2;

	private ToolStripStatusLabel lblCountTotal;

	private DataGridViewTextBoxColumn cKiemDuyet;

	private DataGridViewTextBoxColumn cThanhVien;

	private DataGridViewTextBoxColumn cTen;

	private DataGridViewTextBoxColumn cId;

	private DataGridViewTextBoxColumn cStt;

	private DataGridViewCheckBoxColumn cChose;

	public DataGridView dtgvAcc;

	private Label D9B1CA20;

	private ComboBox cbbKiemDuyet;

	public fQuanLyNhom(List<string> F3972789)
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		DE93C819 = F3972789;
	}

	private void F8A82ABA(object sender, EventArgs e)
	{
		Close();
	}

	private void fQuanLyNhom_Load(object sender, EventArgs e)
	{
		method_2();
		method_0();
	}

	private void method_0()
	{
		try
		{
			list_0 = new List<string>();
			A5A9C62A = new List<string>();
			string path = GClass25.smethod_0("configBackupGroup").C0288288("txtFolderPath", GClass28.smethod_0()) + "\\\\backupgroup";
			List<string> list = Directory.GetFiles(path).ToList();
			if (DE93C819.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(list[i]);
					if (!DE93C819.Contains(fileNameWithoutExtension))
					{
						list.RemoveAt(i--);
					}
				}
			}
			for (int j = 0; j < list.Count; j++)
			{
				string path2 = list[j];
				List<string> list2 = File.ReadAllText(path2).Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
				for (int k = 0; k < list2.Count; k++)
				{
					string text = list2[k].Replace(" |", " *").Replace("| ", "* ");
					if (text.Split('|').Length < 4)
					{
						for (int num = 0; num < 4 - text.Split('|').Length; num++)
						{
							text += "|";
						}
					}
					if (!list_0.Contains(text.Split('|')[0]))
					{
						list_0.Add(text.Split('|')[0]);
						A5A9C62A.Add(text);
					}
				}
			}
			dtgvAcc.Rows.Clear();
			for (int l = 0; l < A5A9C62A.Count; l++)
			{
				string text2 = A5A9C62A[l];
				dtgvAcc.Rows.Add(false, dtgvAcc.RowCount + 1, text2.Split('|')[0], text2.Split('|')[1], text2.Split('|')[2], text2.Split('|')[3].ToUpper());
			}
			method_5();
		}
		catch
		{
		}
	}

	private void method_1()
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			method_3(i, "cStt", i + 1);
		}
	}

	private void method_2()
	{
		List<string> list = new List<string> { "Tất cả", "Kiểm duyệt", "Không kiểm duyệt" };
		GClass8.smethod_22(cbbKiemDuyet, list);
	}

	private void toolStripMenuItem_4_Click(object sender, EventArgs e)
	{
		method_0();
	}

	public void method_3(int F293EB06, string B6810294, object object_0)
	{
		GClass27.smethod_5(dtgvAcc, F293EB06, B6810294, object_0);
	}

	public string method_4(int CC9CF400, string A984062B)
	{
		return GClass27.smethod_3(dtgvAcc, CC9CF400, A984062B);
	}

	private void method_5()
	{
		try
		{
			lblCountTotal.Text = dtgvAcc.RowCount.ToString();
		}
		catch
		{
		}
	}

	private void CB301005(int int_0 = -1)
	{
		if (int_0 == -1)
		{
			int_0 = 0;
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					int_0++;
				}
			}
		}
		E09D9B3D.Text = int_0.ToString();
	}

	private void B291D124(object sender, EventArgs e)
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			method_3(i, "cChose", true);
		}
		CB301005(dtgvAcc.RowCount);
	}

	private void D538AABC_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			method_3(i, "cChose", false);
		}
		CB301005(0);
	}

	private void D5245E33_Click(object sender, EventArgs e)
	{
		DataGridViewSelectedRowCollection selectedRows = dtgvAcc.SelectedRows;
		for (int i = 0; i < selectedRows.Count; i++)
		{
			method_3(selectedRows[i].Index, "cChose", true);
		}
		CB301005();
	}

	private void FF80B406_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			method_3(i, "cChose", method_4(i, "cKiemDuyet").ToLower() == "true");
		}
		CB301005();
	}

	private void B28C2E90(object sender, EventArgs e)
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			method_3(i, "cChose", method_4(i, "cKiemDuyet").ToLower() == "false");
		}
		CB301005();
	}

	private void F50A6289(object sender, EventArgs e)
	{
		try
		{
			string text = "";
			if (E09D9B3D.Text == "0")
			{
				GClass29.smethod_0(F7AB102E.smethod_0("Vui lòng chọn những dòng muốn copy!"), 3);
				return;
			}
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					text = text + method_4(i, "cId") + "\r\n";
				}
			}
			GClass8.smethod_27(text.TrimEnd('\r', '\n'));
		}
		catch
		{
		}
	}

	private void cbbKiemDuyet_SelectedIndexChanged(object sender, EventArgs e)
	{
		dtgvAcc.Rows.Clear();
		if (cbbKiemDuyet.SelectedIndex == 0)
		{
			for (int i = 0; i < A5A9C62A.Count; i++)
			{
				string text = A5A9C62A[i];
				dtgvAcc.Rows.Add(false, dtgvAcc.RowCount + 1, text.Split('|')[0], text.Split('|')[1], text.Split('|')[2], text.Split('|')[3].ToUpper());
			}
		}
		else if (cbbKiemDuyet.SelectedIndex == 1)
		{
			for (int j = 0; j < A5A9C62A.Count; j++)
			{
				string text2 = A5A9C62A[j];
				if (text2.Split('|')[3].ToLower() == "true")
				{
					dtgvAcc.Rows.Add(false, dtgvAcc.RowCount + 1, text2.Split('|')[0], text2.Split('|')[1], text2.Split('|')[2], text2.Split('|')[3].ToUpper());
				}
			}
		}
		else if (cbbKiemDuyet.SelectedIndex == 2)
		{
			for (int k = 0; k < A5A9C62A.Count; k++)
			{
				string text3 = A5A9C62A[k];
				if (text3.Split('|')[3].ToLower() == "false")
				{
					dtgvAcc.Rows.Add(false, dtgvAcc.RowCount + 1, text3.Split('|')[0], text3.Split('|')[1], text3.Split('|')[2], text3.Split('|')[3].ToUpper());
				}
			}
		}
		CB301005(0);
		method_5();
	}

	private void dtgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex == 0)
		{
			try
			{
				dtgvAcc.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value);
				CB301005();
			}
			catch
			{
			}
		}
	}

	private void dtgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			dtgvAcc.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value);
			CB301005();
		}
		catch
		{
		}
	}

	private void dtgvAcc_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void D83BDA2E(object sender, KeyEventArgs e)
	{
		if (e.KeyValue == 32)
		{
			for (int i = 0; i < dtgvAcc.SelectedRows.Count; i++)
			{
				int index = dtgvAcc.SelectedRows[i].Index;
				method_3(index, "cChose", !Convert.ToBoolean(method_4(index, "cChose")));
			}
			CB301005();
		}
	}

	private void C609D799(object sender, EventArgs e)
	{
		lblCountHighline.Text = dtgvAcc.SelectedRows.Count.ToString();
	}

	private void dtgvAcc_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
	{
		List<string> list = new List<string> { "cStt", "cThanhVien" };
		if (list.Contains(e.Column.Name))
		{
			string text = "";
			text = ((e.CellValue1.ToString().Trim() == "") ? "-2" : ((!GClass8.smethod_44(e.CellValue1.ToString())) ? "-1" : e.CellValue1.ToString()));
			string text2 = "";
			text2 = ((e.CellValue2.ToString().Trim() == "") ? "-2" : ((!GClass8.smethod_44(e.CellValue2.ToString())) ? "-1" : e.CellValue2.ToString()));
			e.SortResult = int.Parse(text).CompareTo(int.Parse(text2));
			e.Handled = true;
		}
		else
		{
			e.SortResult = ((e.CellValue1.ToString() == "") ? "" : e.CellValue1.ToString()).CompareTo((e.CellValue2.ToString() == "") ? "" : e.CellValue2.ToString());
			e.Handled = true;
		}
	}

	private void toolStripMenuItem_3_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			DataObject dataObject = (DataObject)Clipboard.GetDataObject();
			string[] array = dataObject.GetData(DataFormats.Text).ToString().Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (text.Split('|').Length > 1 && !list_0.Contains(text.Split('|')[0]))
				{
					list_0.Add(text.Split('|')[0]);
					A5A9C62A.Add(text.Split('|')[0] + "|||" + text.Split('|')[1]);
					list.Add(text.Split('|')[0] + "|||" + text.Split('|')[1]);
					dtgvAcc.Rows.Add(false, dtgvAcc.RowCount + 1, text.Split('|')[0], "", "", text.Split('|')[1].ToUpper());
				}
			}
			File.AppendAllLines("backupgroup\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt", list);
			method_5();
		}
		catch
		{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLyNhom));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		AE971A00 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		EC1D0097 = new System.Windows.Forms.ContextMenuStrip(icontainer_0);
		toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		D5245E33 = new System.Windows.Forms.ToolStripMenuItem();
		tinhTrangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		FF80B406 = new System.Windows.Forms.ToolStripMenuItem();
		falseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		D538AABC = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
		DDA3BA24 = new System.Windows.Forms.StatusStrip();
		toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
		lblCountHighline = new System.Windows.Forms.ToolStripStatusLabel();
		CA1B9317 = new System.Windows.Forms.ToolStripStatusLabel();
		E09D9B3D = new System.Windows.Forms.ToolStripStatusLabel();
		toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
		lblCountTotal = new System.Windows.Forms.ToolStripStatusLabel();
		cKiemDuyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cChose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		dtgvAcc = new System.Windows.Forms.DataGridView();
		D9B1CA20 = new System.Windows.Forms.Label();
		cbbKiemDuyet = new System.Windows.Forms.ComboBox();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		EC1D0097.SuspendLayout();
		DDA3BA24.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)dtgvAcc).BeginInit();
		SuspendLayout();
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(906, 38);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(906, 32);
		pnlHeader.TabIndex = 9;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
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
		btnMinimize.Location = new System.Drawing.Point(874, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(F8A82ABA);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(906, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Quản lý nhóm";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		AE971A00.Fixed = true;
		AE971A00.Horizontal = true;
		AE971A00.TargetControl = bunifuCustomLabel1;
		AE971A00.Vertical = true;
		EC1D0097.Items.AddRange(new System.Windows.Forms.ToolStripItem[5] { toolStripMenuItem_0, D538AABC, toolStripMenuItem_2, toolStripMenuItem_3, toolStripMenuItem_4 });
		EC1D0097.Name = "ctmsAcc";
		EC1D0097.Size = new System.Drawing.Size(180, 114);
		toolStripMenuItem_0.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { toolStripMenuItem_1, D5245E33, tinhTrangToolStripMenuItem });
		toolStripMenuItem_0.Image = (System.Drawing.Image)resources.GetObject("chọnLiveToolStripMenuItem.Image");
		toolStripMenuItem_0.Name = "chọnLiveToolStripMenuItem";
		toolStripMenuItem_0.Size = new System.Drawing.Size(179, 22);
		toolStripMenuItem_0.Text = "Chọn";
		toolStripMenuItem_1.Image = (System.Drawing.Image)resources.GetObject("tấtCảToolStripMenuItem.Image");
		toolStripMenuItem_1.Name = "tấtCảToolStripMenuItem";
		toolStripMenuItem_1.Size = new System.Drawing.Size(134, 22);
		toolStripMenuItem_1.Text = "Tất cả";
		toolStripMenuItem_1.Click += new System.EventHandler(B291D124);
		D5245E33.Image = (System.Drawing.Image)resources.GetObject("liveToolStripMenuItem.Image");
		D5245E33.Name = "liveToolStripMenuItem";
		D5245E33.Size = new System.Drawing.Size(134, 22);
		D5245E33.Text = "Bôi đen";
		D5245E33.Click += new System.EventHandler(D5245E33_Click);
		tinhTrangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { FF80B406, falseToolStripMenuItem });
		tinhTrangToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("tinhTrangToolStripMenuItem.Image");
		tinhTrangToolStripMenuItem.Name = "tinhTrangToolStripMenuItem";
		tinhTrangToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
		tinhTrangToolStripMenuItem.Text = "Kiểm duyệt";
		FF80B406.Name = "trueToolStripMenuItem";
		FF80B406.Size = new System.Drawing.Size(100, 22);
		FF80B406.Text = "True";
		FF80B406.Click += new System.EventHandler(FF80B406_Click);
		falseToolStripMenuItem.Name = "falseToolStripMenuItem";
		falseToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
		falseToolStripMenuItem.Text = "False";
		falseToolStripMenuItem.Click += new System.EventHandler(B28C2E90);
		D538AABC.Image = (System.Drawing.Image)resources.GetObject("bỏChọnTấtCảToolStripMenuItem.Image");
		D538AABC.Name = "bỏChọnTấtCảToolStripMenuItem";
		D538AABC.Size = new System.Drawing.Size(179, 22);
		D538AABC.Text = "Bỏ chọn tất cả";
		D538AABC.Click += new System.EventHandler(D538AABC_Click);
		toolStripMenuItem_2.Image = C50FB39E.CF1D56A0;
		toolStripMenuItem_2.Name = "copyIDNhómToolStripMenuItem";
		toolStripMenuItem_2.Size = new System.Drawing.Size(179, 22);
		toolStripMenuItem_2.Text = "Copy ID nhóm";
		toolStripMenuItem_2.Click += new System.EventHandler(F50A6289);
		toolStripMenuItem_3.Image = C50FB39E.Bitmap_81;
		toolStripMenuItem_3.Name = "pasteIDKiểmDuyệtToolStripMenuItem";
		toolStripMenuItem_3.Size = new System.Drawing.Size(179, 22);
		toolStripMenuItem_3.Text = "Paste ID|Kiểm duyệt";
		toolStripMenuItem_3.Click += new System.EventHandler(toolStripMenuItem_3_Click);
		toolStripMenuItem_4.Image = (System.Drawing.Image)resources.GetObject("tảiLạiDanhSáchToolStripMenuItem.Image");
		toolStripMenuItem_4.Name = "tảiLạiDanhSáchToolStripMenuItem";
		toolStripMenuItem_4.Size = new System.Drawing.Size(179, 22);
		toolStripMenuItem_4.Text = "Tải lại danh sách";
		toolStripMenuItem_4.Click += new System.EventHandler(toolStripMenuItem_4_Click);
		DDA3BA24.BackColor = System.Drawing.SystemColors.Control;
		DDA3BA24.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		DDA3BA24.Items.AddRange(new System.Windows.Forms.ToolStripItem[6] { toolStripStatusLabel4, lblCountHighline, CA1B9317, E09D9B3D, toolStripStatusLabel2, lblCountTotal });
		DDA3BA24.Location = new System.Drawing.Point(0, 558);
		DDA3BA24.Name = "statusStrip1";
		DDA3BA24.Size = new System.Drawing.Size(906, 22);
		DDA3BA24.SizingGrip = false;
		DDA3BA24.TabIndex = 10;
		DDA3BA24.Text = "statusStrip1";
		toolStripStatusLabel4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		toolStripStatusLabel4.Name = "toolStripStatusLabel4";
		toolStripStatusLabel4.Size = new System.Drawing.Size(59, 17);
		toolStripStatusLabel4.Text = "Bôi đen:";
		lblCountHighline.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblCountHighline.ForeColor = System.Drawing.Color.Blue;
		lblCountHighline.Name = "lblCountHighline";
		lblCountHighline.Size = new System.Drawing.Size(15, 17);
		lblCountHighline.Text = "0";
		CA1B9317.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CA1B9317.Name = "toolStripStatusLabel5";
		CA1B9317.Size = new System.Drawing.Size(65, 17);
		CA1B9317.Text = "Đã chọn:";
		E09D9B3D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E09D9B3D.ForeColor = System.Drawing.Color.FromArgb(0, 64, 0);
		E09D9B3D.Name = "lblCountSelect";
		E09D9B3D.Size = new System.Drawing.Size(15, 17);
		E09D9B3D.Text = "0";
		toolStripStatusLabel2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		toolStripStatusLabel2.Name = "toolStripStatusLabel2";
		toolStripStatusLabel2.Size = new System.Drawing.Size(52, 17);
		toolStripStatusLabel2.Text = "Tất cả:";
		lblCountTotal.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblCountTotal.ForeColor = System.Drawing.Color.Maroon;
		lblCountTotal.Name = "lblCountTotal";
		lblCountTotal.Size = new System.Drawing.Size(15, 17);
		lblCountTotal.Text = "0";
		cKiemDuyet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		cKiemDuyet.HeaderText = "Kiểm duyệt";
		cKiemDuyet.MinimumWidth = 200;
		cKiemDuyet.Name = "cKiemDuyet";
		cThanhVien.HeaderText = "Thành viên";
		cThanhVien.Name = "cThanhVien";
		cThanhVien.Width = 120;
		cTen.HeaderText = "Tên nhóm";
		cTen.Name = "cTen";
		cTen.Width = 200;
		cId.HeaderText = "ID Nhóm";
		cId.Name = "cId";
		cId.Width = 120;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		cStt.DefaultCellStyle = dataGridViewCellStyle;
		cStt.HeaderText = "STT";
		cStt.Name = "cStt";
		cStt.Width = 50;
		cChose.HeaderText = "Chọn";
		cChose.Name = "cChose";
		cChose.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		cChose.Width = 40;
		dtgvAcc.AllowUserToAddRows = false;
		dtgvAcc.AllowUserToDeleteRows = false;
		dtgvAcc.AllowUserToResizeRows = false;
		dtgvAcc.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		dtgvAcc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		dtgvAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		dtgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dtgvAcc.Columns.AddRange(cChose, cStt, cId, cTen, cThanhVien, cKiemDuyet);
		dtgvAcc.ContextMenuStrip = EC1D0097;
		dtgvAcc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		dtgvAcc.Location = new System.Drawing.Point(12, 72);
		dtgvAcc.Name = "dtgvAcc";
		dtgvAcc.RowHeadersVisible = false;
		dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dtgvAcc.RowsDefaultCellStyle = dataGridViewCellStyle3;
		dtgvAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		dtgvAcc.Size = new System.Drawing.Size(882, 483);
		dtgvAcc.TabIndex = 5;
		dtgvAcc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellClick);
		dtgvAcc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellDoubleClick);
		dtgvAcc.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellValueChanged);
		dtgvAcc.SelectionChanged += new System.EventHandler(C609D799);
		dtgvAcc.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(dtgvAcc_SortCompare);
		dtgvAcc.KeyDown += new System.Windows.Forms.KeyEventHandler(D83BDA2E);
		D9B1CA20.AutoSize = true;
		D9B1CA20.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D9B1CA20.Location = new System.Drawing.Point(10, 44);
		D9B1CA20.Name = "label1";
		D9B1CA20.Size = new System.Drawing.Size(55, 16);
		D9B1CA20.TabIndex = 6;
		D9B1CA20.Text = "Hiển thị:";
		cbbKiemDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbKiemDuyet.DropDownWidth = 350;
		cbbKiemDuyet.FormattingEnabled = true;
		cbbKiemDuyet.ItemHeight = 16;
		cbbKiemDuyet.Items.AddRange(new object[3] { "Toàn bộ", "Nhóm không kiểm duyệt", "Nhóm kiểm duyệt" });
		cbbKiemDuyet.Location = new System.Drawing.Point(71, 41);
		cbbKiemDuyet.Name = "cbbKiemDuyet";
		cbbKiemDuyet.Size = new System.Drawing.Size(184, 24);
		cbbKiemDuyet.TabIndex = 7;
		cbbKiemDuyet.SelectedIndexChanged += new System.EventHandler(cbbKiemDuyet_SelectedIndexChanged);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(906, 580);
		base.Controls.Add(DDA3BA24);
		base.Controls.Add(cbbKiemDuyet);
		base.Controls.Add(D9B1CA20);
		base.Controls.Add(dtgvAcc);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fQuanLyNhom";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(fQuanLyNhom_Load);
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		EC1D0097.ResumeLayout(false);
		DDA3BA24.ResumeLayout(false);
		DDA3BA24.PerformLayout();
		((System.ComponentModel.ISupportInitialize)dtgvAcc).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
