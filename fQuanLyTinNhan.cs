using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fQuanLyTinNhan : Form
{
	[CompilerGenerated]
	private sealed class F42C4787
	{
		public GClass3 D11D58B8;

		public Control control_0;

		internal void method_0()
		{
			SetParent(D11D58B8.EC234D1D.MainWindowHandle, control_0.Handle);
			MoveWindow(D11D58B8.EC234D1D.MainWindowHandle, -10, 0, control_0.Size.Width + 20, control_0.Size.Height + 20, A892C8B8: false);
		}
	}

	[CompilerGenerated]
	private sealed class Class72
	{
		public string E185C184;

		public fQuanLyTinNhan E92B1E8F;

		internal void method_0()
		{
			E92B1E8F.tabMain.TabPages.Remove(E92B1E8F.tabMain.TabPages[E185C184]);
		}
	}

	[CompilerGenerated]
	private sealed class Class73
	{
		public int int_0;

		public List<int> list_0;

		public fQuanLyTinNhan fQuanLyTinNhan_0;

		internal void method_0()
		{
			try
			{
				int num = 0;
				while (num < list_0.Count && fQuanLyTinNhan_0.list_1.Count < int_0)
				{
					Class74 CS_0024_003C_003E8__locals0 = new Class74
					{
						class73_0 = this,
						int_0 = list_0[num++]
					};
					if (CS_0024_003C_003E8__locals0.int_0 != 0)
					{
						Thread.Sleep(Class57.random_0.Next(GClass25.smethod_0("configGeneral").method_2("nudDelayOpenChromeFrom"), GClass25.smethod_0("configGeneral").method_2("nudDelayOpenChromeTo") + 1) * 1000);
					}
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							CS_0024_003C_003E8__locals0.class73_0.fQuanLyTinNhan_0.C5983231(CS_0024_003C_003E8__locals0.int_0);
						}
						catch (Exception f4295AA2)
						{
							GClass8.BFBDF687(null, f4295AA2);
						}
					})
					{
						Name = CS_0024_003C_003E8__locals0.int_0.ToString()
					};
					fQuanLyTinNhan_0.list_1.Add(thread);
					GClass8.smethod_53(1.0);
					thread.Start();
				}
				for (int i = 0; i < fQuanLyTinNhan_0.list_1.Count; i++)
				{
					fQuanLyTinNhan_0.list_1[i].Join();
				}
			}
			catch (Exception f4295AA)
			{
				GClass8.BFBDF687(null, f4295AA);
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class74
	{
		public int int_0;

		public Class73 class73_0;

		internal void method_0()
		{
			try
			{
				class73_0.fQuanLyTinNhan_0.C5983231(int_0);
			}
			catch (Exception f4295AA)
			{
				GClass8.BFBDF687(null, f4295AA);
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class75
	{
		public fQuanLyTinNhan fQuanLyTinNhan_0;

		public TabPage tabPage_0;

		internal void F087860F()
		{
			fQuanLyTinNhan_0.tabMain.ItemSize = new Size(0, 1);
			fQuanLyTinNhan_0.tabMain.TabPages.Add(tabPage_0);
		}
	}

	[CompilerGenerated]
	private sealed class DE1E379C
	{
		public string string_0;

		public fQuanLyTinNhan fQuanLyTinNhan_0;

		public MethodInvoker methodInvoker_0;

		internal void method_0()
		{
			fQuanLyTinNhan_0.tabMain.TabPages.Remove(fQuanLyTinNhan_0.tabMain.TabPages[string_0]);
		}
	}

	private List<string> list_0 = new List<string>();

	private List<Thread> list_1 = null;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private ToolTip C38F1E94;

	private Panel pnlHeader;

	private PictureBox pictureBox1;

	private Button button2;

	private Button C083B3B2;

	private Button btnMinimize;

	private BunifuCustomLabel F7BBFDBF;

	private BunifuCards bunifuCards1;

	private Panel panel1;

	private TabControl tabMain;

	public DataGridView dgvTaiKhoan;

	private ContextMenuStrip D9A5F132;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private Panel D9B5AC97;

	private ToolStripMenuItem toolStripMenuItem_2;

	private DataGridViewTextBoxColumn cStt;

	private DataGridViewImageColumn cAvatar;

	private DataGridViewTextBoxColumn FE819AA1;

	private DataGridViewTextBoxColumn cUid;

	private DataGridViewTextBoxColumn E390CEAB;

	private DataGridViewTextBoxColumn cFa2;

	private DataGridViewTextBoxColumn cCookies;

	private DataGridViewTextBoxColumn cProxy;

	private DataGridViewTextBoxColumn cGhiChu;

	private DataGridViewTextBoxColumn cId;

	[DllImport("user32.dll", SetLastError = true)]
	public static extern long SetParent(IntPtr D429D4B9, IntPtr AD0FA1A3);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool MoveWindow(IntPtr intptr_0, int C8A6428C, int AD007B8C, int int_0, int B71C6000, bool A892C8B8);

	public fQuanLyTinNhan(List<string> list_2)
	{
		InitializeComponent();
		GClass8.smethod_32("avatar");
		list_0 = list_2;
		base.Width = Screen.PrimaryScreen.WorkingArea.Width;
		base.Height = Screen.PrimaryScreen.WorkingArea.Height;
		F7AB102E.D6B70A35(this);
	}

	public int method_0()
	{
		int result = 0;
		try
		{
			result = dgvTaiKhoan.SelectedRows.Count;
		}
		catch
		{
		}
		return result;
	}

	public void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C083B3B2_Click(object sender, EventArgs e)
	{
		if (base.WindowState == FormWindowState.Maximized)
		{
			base.WindowState = FormWindowState.Normal;
			return;
		}
		Rectangle workingArea = Screen.FromHandle(base.Handle).WorkingArea;
		workingArea.Location = new Point(0, 0);
		base.MaximizedBounds = workingArea;
		base.WindowState = FormWindowState.Maximized;
	}

	public void C907A8BF(int int_0, string string_0, object object_0, bool A71E693C = true)
	{
		if (A71E693C || !(object_0.ToString().Trim() == ""))
		{
			GClass27.smethod_5(dgvTaiKhoan, int_0, string_0, object_0);
		}
	}

	public string C4346112(int int_0, string string_0)
	{
		return GClass27.smethod_3(dgvTaiKhoan, int_0, string_0);
	}

	private void D1A9D3B9(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void A226CA93()
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			string[] array = list_0[i].Split('|');
			dgvTaiKhoan.Rows.Add(dgvTaiKhoan.RowCount + 1, Image.FromFile("images\\no_avatar.png"), array[0] + "\r\n" + array[5], array[0], array[1], array[2], array[3], array[4], array[6], array[7]);
		}
	}

	private void fQuanLyTinNhan_Load(object sender, EventArgs e)
	{
		A226CA93();
	}

	private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void method_1(GClass3 D18E5D8C, Control F1BCB232)
	{
		Invoke((MethodInvoker)delegate
		{
			SetParent(D18E5D8C.EC234D1D.MainWindowHandle, F1BCB232.Handle);
			MoveWindow(D18E5D8C.EC234D1D.MainWindowHandle, -10, 0, F1BCB232.Size.Width + 20, F1BCB232.Size.Height + 20, A892C8B8: false);
		});
	}

	public int method_2(int DC87C826, string string_0, string string_1, string D99AA407, TabPage tabPage_0, string string_2 = "", string F714CAA6 = "")
	{
		int result = 0;
		int num = 0;
		try
		{
			if (string_0 == "")
			{
				string_0 = Regex.Match(string_2, "c_user=(\\d+)").Groups[1].Value;
			}
			GClass3 gClass = null;
			bool flag = false;
			string text = "";
			if (string_0 != "")
			{
				text = GClass25.smethod_2() + "\\" + string_0;
				if (!Directory.Exists(text))
				{
					text = "";
				}
			}
			gClass = new GClass3
			{
				Boolean_2 = false,
				D780F8B7 = new Point(300, 500),
				B0B3B9A3 = new Point(0, -1000),
				String_0 = text
			};
			gClass.D491453C = DC87C826;
			gClass.String_2 = string_0;
			gClass.String_3 = string_1;
			gClass.CCBE39A8 = D99AA407;
			gClass.String_4 = string_2;
			if (F714CAA6 != "")
			{
				int int32_ = 0;
				if (F714CAA6.EndsWith("*1"))
				{
					int32_ = 1;
				}
				if (F714CAA6.EndsWith("*0") || F714CAA6.EndsWith("*1"))
				{
					F714CAA6 = F714CAA6.Substring(0, F714CAA6.Length - 2);
				}
				gClass.String_8 = F714CAA6;
				gClass.Int32_1 = int32_;
			}
			do
			{
				(bool success, string error) tuple = gClass.method_0();
				var (flag2, _) = tuple;
				_ = tuple.error;
				if (!flag2)
				{
					break;
				}
				if (!GClass25.smethod_0("configGeneral").method_3("ckbKhongCheckIP") && !gClass.CE97BD33())
				{
					gClass.B7841719();
					num++;
					continue;
				}
				method_1(gClass, tabPage_0);
				if (!(flag = gClass.method_131("https://m.facebook.com/") == 1))
				{
					if (string_0 != "" && string_1 != "")
					{
						flag = gClass.method_129(-1, "https://m.facebook.com/") == "1";
					}
					else if (string_2 != "")
					{
						flag = GClass10.smethod_5(gClass, string_2, "https://m.facebook.com/") == "1";
					}
				}
				if (!flag)
				{
					method_3(DC87C826, 1);
					string E185C184 = dgvTaiKhoan.Rows[DC87C826].Cells[3].Value.ToString();
					tabMain.Invoke((MethodInvoker)delegate
					{
						tabMain.TabPages.Remove(tabMain.TabPages[E185C184]);
					});
					break;
				}
				method_3(DC87C826, 2);
				gClass.method_10("https://www.facebook.com/messages/t");
				string text2 = Class14.smethod_2(string_0, "avatar");
				if (File.Exists(text2))
				{
					dgvTaiKhoan.Rows[DC87C826].Cells[1].Value = Image.FromFile(text2);
				}
				break;
			}
			while (num < 3);
		}
		catch (Exception)
		{
		}
		return result;
	}

	private void method_3(int int_0, int D3A94D9B)
	{
		switch (D3A94D9B)
		{
		case 1:
			dgvTaiKhoan.Rows[int_0].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
			break;
		case 2:
			dgvTaiKhoan.Rows[int_0].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
			break;
		case 3:
			dgvTaiKhoan.Rows[int_0].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
			break;
		}
	}

	private void method_4(string string_0, string string_1)
	{
		try
		{
			using WebClient webClient = new WebClient();
			byte[] buffer = webClient.DownloadData(string_0);
			using MemoryStream stream = new MemoryStream(buffer);
			using Image image = Image.FromStream(stream);
			try
			{
				image.Save(string_1 + ".png", ImageFormat.Png);
			}
			catch
			{
				image.Save(string_1 + ".jpg", ImageFormat.Jpeg);
			}
		}
		catch
		{
		}
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		try
		{
			list_1 = new List<Thread>();
			List<int> list_0 = new List<int>();
			foreach (DataGridViewRow selectedRow in dgvTaiKhoan.SelectedRows)
			{
				list_0.Add(selectedRow.Index);
			}
			int int_0 = list_0.Count;
			new Thread((ThreadStart)delegate
			{
				try
				{
					int num = 0;
					while (num < list_0.Count && list_1.Count < int_0)
					{
						int int_ = list_0[num++];
						if (int_ != 0)
						{
							Thread.Sleep(Class57.random_0.Next(GClass25.smethod_0("configGeneral").method_2("nudDelayOpenChromeFrom"), GClass25.smethod_0("configGeneral").method_2("nudDelayOpenChromeTo") + 1) * 1000);
						}
						Thread thread = new Thread((ThreadStart)delegate
						{
							try
							{
								C5983231(int_);
							}
							catch (Exception f4295AA3)
							{
								GClass8.BFBDF687(null, f4295AA3);
							}
						})
						{
							Name = int_.ToString()
						};
						list_1.Add(thread);
						GClass8.smethod_53(1.0);
						thread.Start();
					}
					for (int i = 0; i < list_1.Count; i++)
					{
						list_1[i].Join();
					}
				}
				catch (Exception f4295AA2)
				{
					GClass8.BFBDF687(null, f4295AA2);
				}
			}).Start();
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA);
		}
	}

	private void C5983231(int int_0)
	{
		int num = 0;
		string string_ = dgvTaiKhoan.Rows[int_0].Cells[6].Value.ToString();
		string text = dgvTaiKhoan.Rows[int_0].Cells[3].Value.ToString();
		string string_2 = dgvTaiKhoan.Rows[int_0].Cells[4].Value.ToString();
		string d99AA = dgvTaiKhoan.Rows[int_0].Cells[5].Value.ToString();
		string f714CAA = dgvTaiKhoan.Rows[int_0].Cells[7].Value.ToString();
		TabPage tabPage_0 = new TabPage();
		tabPage_0.Name = text;
		tabPage_0.Text = text;
		tabPage_0.BackColor = Color.White;
		tabPage_0.ForeColor = Color.White;
		for (int i = 0; i < tabMain.TabPages.Count; i++)
		{
			if (tabMain.TabPages[i].Name.ToString() == tabPage_0.Name)
			{
				num++;
				break;
			}
		}
		if (num == 0)
		{
			tabMain.Invoke((MethodInvoker)delegate
			{
				tabMain.ItemSize = new Size(0, 1);
				tabMain.TabPages.Add(tabPage_0);
			});
			method_2(int_0, text, string_2, d99AA, tabPage_0, string_, f714CAA);
		}
	}

	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		try
		{
			string string_0 = "";
			for (int i = 0; i < dgvTaiKhoan.SelectedRows.Count; i++)
			{
				string_0 = dgvTaiKhoan.SelectedRows[i].Cells[3].Value.ToString();
				if (tabMain.TabPages.Contains(tabMain.TabPages[string_0]))
				{
					tabMain.Invoke((MethodInvoker)delegate
					{
						tabMain.TabPages.Remove(tabMain.TabPages[string_0]);
					});
					method_3(dgvTaiKhoan.SelectedRows[i].Index, 3);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void A596900B(object sender, DataGridViewCellEventArgs e)
	{
		string text = dgvTaiKhoan.SelectedRows[0].Cells[3].Value.ToString();
		int num = 0;
		while (true)
		{
			if (num < tabMain.TabPages.Count)
			{
				if (tabMain.TabPages[num].Name.ToString() == text)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		tabMain.SelectedTab = tabMain.TabPages[text];
	}

	private void D139A190(object sender, PaintEventArgs e)
	{
	}

	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		method_5("Notes");
	}

	private void method_5(string CF2D9E14)
	{
		try
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dgvTaiKhoan.SelectedRows.Count; i++)
			{
				list.Add(C4346112(dgvTaiKhoan.SelectedRows[i].Index, "cId"));
			}
			if (list.Count == 0)
			{
				GClass29.smethod_0("Vui lo\u0300ng cho\u0323n ta\u0300i khoa\u0309n câ\u0300n câ\u0323p nhâ\u0323t!", 3);
			}
			else
			{
				GClass8.smethod_33(new fUpdateData2(this, CF2D9E14));
			}
		}
		catch
		{
		}
	}

	protected override void Dispose(bool CF28FB80)
	{
		if (CF28FB80 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(CF28FB80);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		button2 = new System.Windows.Forms.Button();
		C083B3B2 = new System.Windows.Forms.Button();
		btnMinimize = new System.Windows.Forms.Button();
		F7BBFDBF = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		C38F1E94 = new System.Windows.Forms.ToolTip(icontainer_0);
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		panel1 = new System.Windows.Forms.Panel();
		D9B5AC97 = new System.Windows.Forms.Panel();
		tabMain = new System.Windows.Forms.TabControl();
		dgvTaiKhoan = new System.Windows.Forms.DataGridView();
		cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cAvatar = new System.Windows.Forms.DataGridViewImageColumn();
		FE819AA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cUid = new System.Windows.Forms.DataGridViewTextBoxColumn();
		E390CEAB = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cFa2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cCookies = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cProxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
		D9A5F132 = new System.Windows.Forms.ContextMenuStrip(icontainer_0);
		toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		bunifuCards1.SuspendLayout();
		panel1.SuspendLayout();
		D9B5AC97.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
		D9A5F132.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(button2);
		pnlHeader.Controls.Add(C083B3B2);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(F7BBFDBF);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(1080, 29);
		pnlHeader.TabIndex = 0;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(6, 1);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 12;
		pictureBox1.TabStop = false;
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.Dock = System.Windows.Forms.DockStyle.Right;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button2.ForeColor = System.Drawing.Color.White;
		button2.Image = C50FB39E.A6154D89;
		button2.Location = new System.Drawing.Point(984, 0);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(32, 29);
		button2.TabIndex = 0;
		button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(D1A9D3B9);
		C083B3B2.Cursor = System.Windows.Forms.Cursors.Hand;
		C083B3B2.Dock = System.Windows.Forms.DockStyle.Right;
		C083B3B2.Enabled = false;
		C083B3B2.FlatAppearance.BorderSize = 0;
		C083B3B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C083B3B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C083B3B2.ForeColor = System.Drawing.Color.White;
		C083B3B2.Image = C50FB39E.CB977EAE;
		C083B3B2.Location = new System.Drawing.Point(1016, 0);
		C083B3B2.Name = "button1";
		C083B3B2.Size = new System.Drawing.Size(32, 29);
		C083B3B2.TabIndex = 1;
		C083B3B2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		C083B3B2.UseVisualStyleBackColor = true;
		C083B3B2.Click += new System.EventHandler(C083B3B2_Click);
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = C50FB39E.Bitmap_12;
		btnMinimize.Location = new System.Drawing.Point(1048, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 29);
		btnMinimize.TabIndex = 2;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		F7BBFDBF.AutoSize = true;
		F7BBFDBF.BackColor = System.Drawing.Color.Transparent;
		F7BBFDBF.Cursor = System.Windows.Forms.Cursors.SizeAll;
		F7BBFDBF.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F7BBFDBF.ForeColor = System.Drawing.Color.Black;
		F7BBFDBF.Location = new System.Drawing.Point(43, 6);
		F7BBFDBF.Name = "bunifuCustomLabel1";
		F7BBFDBF.Size = new System.Drawing.Size(177, 16);
		F7BBFDBF.TabIndex = 3;
		F7BBFDBF.Text = "Quản lý tin nhắn hàng loạt";
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = F7BBFDBF;
		bunifuDragControl_1.Vertical = true;
		C38F1E94.AutomaticDelay = 0;
		C38F1E94.AutoPopDelay = 30000;
		C38F1E94.InitialDelay = 0;
		C38F1E94.ReshowDelay = 40;
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.RoyalBlue;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, -1);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(1081, 38);
		bunifuCards1.TabIndex = 0;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(D9B5AC97);
		panel1.Controls.Add(dgvTaiKhoan);
		panel1.Controls.Add(bunifuCards1);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(1082, 565);
		panel1.TabIndex = 8;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(D139A190);
		D9B5AC97.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		D9B5AC97.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D9B5AC97.Controls.Add(tabMain);
		D9B5AC97.Location = new System.Drawing.Point(7, 39);
		D9B5AC97.Name = "panel2";
		D9B5AC97.Size = new System.Drawing.Size(693, 519);
		D9B5AC97.TabIndex = 8;
		tabMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
		tabMain.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		tabMain.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		tabMain.Location = new System.Drawing.Point(0, 0);
		tabMain.Multiline = true;
		tabMain.Name = "tabMain";
		tabMain.SelectedIndex = 0;
		tabMain.Size = new System.Drawing.Size(693, 518);
		tabMain.TabIndex = 7;
		dgvTaiKhoan.AllowUserToAddRows = false;
		dgvTaiKhoan.AllowUserToDeleteRows = false;
		dgvTaiKhoan.AllowUserToResizeColumns = false;
		dgvTaiKhoan.AllowUserToResizeRows = false;
		dgvTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dgvTaiKhoan.Columns.AddRange(cStt, cAvatar, FE819AA1, cUid, E390CEAB, cFa2, cCookies, cProxy, cGhiChu, cId);
		dgvTaiKhoan.ContextMenuStrip = D9A5F132;
		dgvTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle2;
		dgvTaiKhoan.Location = new System.Drawing.Point(706, 39);
		dgvTaiKhoan.Name = "dgvTaiKhoan";
		dgvTaiKhoan.ReadOnly = true;
		dgvTaiKhoan.RowHeadersVisible = false;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dgvTaiKhoan.RowsDefaultCellStyle = dataGridViewCellStyle3;
		dgvTaiKhoan.RowTemplate.Height = 50;
		dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		dgvTaiKhoan.Size = new System.Drawing.Size(369, 519);
		dgvTaiKhoan.TabIndex = 6;
		dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(A596900B);
		dgvTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvTaiKhoan_CellContentClick);
		cStt.HeaderText = "STT";
		cStt.Name = "cStt";
		cStt.ReadOnly = true;
		cStt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		cStt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		cStt.Width = 40;
		cAvatar.FillWeight = 50f;
		cAvatar.HeaderText = "Avatar";
		cAvatar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
		cAvatar.Name = "cAvatar";
		cAvatar.ReadOnly = true;
		cAvatar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		cAvatar.Width = 70;
		FE819AA1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		FE819AA1.DefaultCellStyle = dataGridViewCellStyle4;
		FE819AA1.HeaderText = "Tài khoản";
		FE819AA1.Name = "cTaiKhoan";
		FE819AA1.ReadOnly = true;
		FE819AA1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		FE819AA1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		cUid.HeaderText = "Uid";
		cUid.Name = "cUid";
		cUid.ReadOnly = true;
		cUid.Visible = false;
		E390CEAB.HeaderText = "Password";
		E390CEAB.Name = "cPassword";
		E390CEAB.ReadOnly = true;
		E390CEAB.Visible = false;
		cFa2.HeaderText = "2fa";
		cFa2.Name = "cFa2";
		cFa2.ReadOnly = true;
		cFa2.Visible = false;
		cCookies.HeaderText = "Cookie";
		cCookies.Name = "cCookies";
		cCookies.ReadOnly = true;
		cCookies.Visible = false;
		cProxy.HeaderText = "Proxy";
		cProxy.Name = "cProxy";
		cProxy.ReadOnly = true;
		cProxy.Visible = false;
		cGhiChu.HeaderText = "Ghi chú";
		cGhiChu.Name = "cGhiChu";
		cGhiChu.ReadOnly = true;
		cId.HeaderText = "Id";
		cId.Name = "cId";
		cId.ReadOnly = true;
		cId.Visible = false;
		D9A5F132.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { toolStripMenuItem_0, toolStripMenuItem_1, toolStripMenuItem_2 });
		D9A5F132.Name = "contextMenuStrip1";
		D9A5F132.Size = new System.Drawing.Size(165, 70);
		toolStripMenuItem_0.Image = C50FB39E.Bitmap_109;
		toolStripMenuItem_0.Name = "hiểnThịToolStripMenuItem";
		toolStripMenuItem_0.Size = new System.Drawing.Size(164, 22);
		toolStripMenuItem_0.Text = "Mở trình duyệt";
		toolStripMenuItem_0.Click += new System.EventHandler(toolStripMenuItem_0_Click);
		toolStripMenuItem_1.Image = C50FB39E.Bitmap_133;
		toolStripMenuItem_1.Name = "đóngToolStripMenuItem";
		toolStripMenuItem_1.Size = new System.Drawing.Size(164, 22);
		toolStripMenuItem_1.Text = "Đóng trình duyệt";
		toolStripMenuItem_1.Click += new System.EventHandler(toolStripMenuItem_1_Click);
		toolStripMenuItem_2.Image = C50FB39E.Bitmap_78;
		toolStripMenuItem_2.Name = "sửaGhiChúToolStripMenuItem";
		toolStripMenuItem_2.Size = new System.Drawing.Size(164, 22);
		toolStripMenuItem_2.Text = "Sửa ghi chú";
		toolStripMenuItem_2.Click += new System.EventHandler(toolStripMenuItem_2_Click);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(1082, 565);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fQuanLyTinNhan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Quản lý tin nhắn";
		base.Load += new System.EventHandler(fQuanLyTinNhan_Load);
		pnlHeader.ResumeLayout(false);
		pnlHeader.PerformLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		bunifuCards1.ResumeLayout(false);
		panel1.ResumeLayout(false);
		D9B5AC97.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
		D9A5F132.ResumeLayout(false);
		ResumeLayout(false);
	}
}
