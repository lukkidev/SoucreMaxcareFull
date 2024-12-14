using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fClearBackup : Form
{
	[CompilerGenerated]
	private sealed class Class66
	{
		public int int_0;

		public int EB8BAF86;

		public string BD95013F;

		public fClearBackup fClearBackup_0;

		public int int_1;

		public Action A63D5113;

		internal void method_0()
		{
			try
			{
				int num = 0;
				while (num < fClearBackup_0.list_0.Count)
				{
					if (int_0 < EB8BAF86)
					{
						Class67 CS_0024_003C_003E8__locals0 = new Class67
						{
							C33E5BAA = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							try
							{
								string path = CS_0024_003C_003E8__locals0.C33E5BAA.BD95013F + "\\" + CS_0024_003C_003E8__locals0.C33E5BAA.fClearBackup_0.list_0[CS_0024_003C_003E8__locals0.int_0];
								Directory.Delete(path, recursive: true);
								Interlocked.Increment(ref CS_0024_003C_003E8__locals0.C33E5BAA.int_1);
								CS_0024_003C_003E8__locals0.C33E5BAA.fClearBackup_0.FC34E594(string.Format(F7AB102E.smethod_0("Đang dọn dẹp backup {0}/{1}..."), CS_0024_003C_003E8__locals0.C33E5BAA.int_1, CS_0024_003C_003E8__locals0.C33E5BAA.fClearBackup_0.list_0.Count));
								Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.C33E5BAA.int_0);
							}
							catch
							{
							}
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				while (int_0 > 0)
				{
					GClass8.smethod_53(1.0);
				}
				fClearBackup_0.Invoke((Action)delegate
				{
					fClearBackup_0.Close();
					GClass29.smethod_0("Đã dọn dẹp file backup xong!");
				});
			}
			catch
			{
			}
		}

		internal void method_1()
		{
			fClearBackup_0.Close();
			GClass29.smethod_0("Đã dọn dẹp file backup xong!");
		}
	}

	[CompilerGenerated]
	private sealed class Class67
	{
		public int int_0;

		public Class66 C33E5BAA;

		internal void method_0()
		{
			try
			{
				string path = C33E5BAA.BD95013F + "\\" + C33E5BAA.fClearBackup_0.list_0[int_0];
				Directory.Delete(path, recursive: true);
				Interlocked.Increment(ref C33E5BAA.int_1);
				C33E5BAA.fClearBackup_0.FC34E594(string.Format(F7AB102E.smethod_0("Đang dọn dẹp backup {0}/{1}..."), C33E5BAA.int_1, C33E5BAA.fClearBackup_0.list_0.Count));
				Interlocked.Decrement(ref C33E5BAA.int_0);
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class BF0FDDA5
	{
		public fClearBackup fClearBackup_0;

		public string string_0;

		internal void method_0()
		{
			fClearBackup_0.lblStatus.Text = string_0;
		}
	}

	private List<string> list_0 = new List<string>();

	private IContainer FF1C0623 = null;

	private BunifuCards E71014A1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuCustomLabel lblStatus;

	private PictureBox pictureBox1;

	public fClearBackup()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
	}

	private void F7275C07()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(lblStatus);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(btnCancel);
	}

	private void FAA7F08D(object sender, EventArgs e)
	{
		Close();
	}

	private void F287EF3B(object sender, EventArgs e)
	{
		btnAdd.Enabled = false;
		btnCancel.Enabled = false;
		FC34E594(string.Format(F7AB102E.smethod_0("Đang dọn dẹp backup {0}/{1}..."), 0, list_0.Count));
		int int_0 = 0;
		int EB8BAF86 = 20;
		int int_1 = 0;
		string BD95013F = GClass28.smethod_0() + "\\backup";
		new Thread((ThreadStart)delegate
		{
			try
			{
				int num = 0;
				while (num < list_0.Count)
				{
					if (int_0 < EB8BAF86)
					{
						Interlocked.Increment(ref int_0);
						int int_2 = num++;
						new Thread((ThreadStart)delegate
						{
							try
							{
								string path = BD95013F + "\\" + list_0[int_2];
								Directory.Delete(path, recursive: true);
								Interlocked.Increment(ref int_1);
								FC34E594(string.Format(F7AB102E.smethod_0("Đang dọn dẹp backup {0}/{1}..."), int_1, list_0.Count));
								Interlocked.Decrement(ref int_0);
							}
							catch
							{
							}
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				while (int_0 > 0)
				{
					GClass8.smethod_53(1.0);
				}
				Invoke((Action)delegate
				{
					Close();
					GClass29.smethod_0("Đã dọn dẹp file backup xong!");
				});
			}
			catch
			{
			}
		}).Start();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void lblStatus_Click(object sender, EventArgs e)
	{
	}

	private List<string> method_0()
	{
		List<string> list = new List<string>();
		try
		{
			DataTable dataTable = Class15.smethod_13();
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				list.Add(dataTable.Rows[i]["uid"].ToString());
			}
		}
		catch
		{
		}
		return list;
	}

	private void FC34E594(string E79286B9)
	{
		Invoke((Action)delegate
		{
			lblStatus.Text = E79286B9;
		});
	}

	private void fClearBackup_Load(object sender, EventArgs e)
	{
		new Thread((ThreadStart)delegate
		{
			try
			{
				List<string> list = Directory.GetDirectories(GClass28.smethod_0() + "\\backup").ToList();
				List<string> list2 = method_0();
				string text = "";
				for (int i = 0; i < list.Count; i++)
				{
					text = list[i].Substring(list[i].LastIndexOf("\\") + 1);
					if (!list2.Contains(text))
					{
						list_0.Add(text);
					}
				}
				if (list_0.Count > 0)
				{
					Invoke((Action)delegate
					{
						lblStatus.Text = string.Format(F7AB102E.smethod_0("Tìm thấy {0} file backup rác!"), list_0.Count) + "\r\n" + F7AB102E.smethod_0("Bạn có muốn dọn dẹp?");
						btnAdd.Visible = true;
						btnCancel.Visible = true;
					});
				}
				else
				{
					Invoke((Action)delegate
					{
						Close();
						GClass29.smethod_0("Không có file backup rác!");
					});
				}
			}
			catch
			{
			}
		}).Start();
	}

	protected override void Dispose(bool F29BDB0F)
	{
		if (F29BDB0F && FF1C0623 != null)
		{
			FF1C0623.Dispose();
		}
		base.Dispose(F29BDB0F);
	}

	private void InitializeComponent()
	{
		FF1C0623 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fClearBackup));
		E71014A1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(FF1C0623);
		lblStatus = new Bunifu.Framework.UI.BunifuCustomLabel();
		E71014A1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		E71014A1.BackColor = System.Drawing.Color.White;
		E71014A1.BorderRadius = 0;
		E71014A1.BottomSahddow = true;
		E71014A1.color = System.Drawing.Color.SaddleBrown;
		E71014A1.Controls.Add(pnlHeader);
		E71014A1.Dock = System.Windows.Forms.DockStyle.Top;
		E71014A1.LeftSahddow = false;
		E71014A1.Location = new System.Drawing.Point(0, 0);
		E71014A1.Name = "bunifuCards1";
		E71014A1.RightSahddow = true;
		E71014A1.ShadowDepth = 20;
		E71014A1.Size = new System.Drawing.Size(396, 38);
		E71014A1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(396, 32);
		pnlHeader.TabIndex = 9;
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
		btnMinimize.Location = new System.Drawing.Point(364, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(FAA7F08D);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(396, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Dọn dẹp backup";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(204, 105);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Hủy";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Visible = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(100, 105);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Đồng ý";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Visible = false;
		btnAdd.Click += new System.EventHandler(F287EF3B);
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		lblStatus.BackColor = System.Drawing.Color.Transparent;
		lblStatus.Cursor = System.Windows.Forms.Cursors.SizeAll;
		lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblStatus.ForeColor = System.Drawing.Color.Black;
		lblStatus.Location = new System.Drawing.Point(-1, 57);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(396, 32);
		lblStatus.TabIndex = 21;
		lblStatus.Text = "Đang quét file backup...";
		lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		lblStatus.Click += new System.EventHandler(lblStatus_Click);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(396, 145);
		base.Controls.Add(lblStatus);
		base.Controls.Add(btnCancel);
		base.Controls.Add(btnAdd);
		base.Controls.Add(E71014A1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fClearBackup";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(fClearBackup_Load);
		E71014A1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
	}

	[CompilerGenerated]
	private void C40396AC()
	{
		try
		{
			List<string> list = Directory.GetDirectories(GClass28.smethod_0() + "\\backup").ToList();
			List<string> list2 = method_0();
			string text = "";
			for (int i = 0; i < list.Count; i++)
			{
				text = list[i].Substring(list[i].LastIndexOf("\\") + 1);
				if (!list2.Contains(text))
				{
					list_0.Add(text);
				}
			}
			if (list_0.Count > 0)
			{
				Invoke((Action)delegate
				{
					lblStatus.Text = string.Format(F7AB102E.smethod_0("Tìm thấy {0} file backup rác!"), list_0.Count) + "\r\n" + F7AB102E.smethod_0("Bạn có muốn dọn dẹp?");
					btnAdd.Visible = true;
					btnCancel.Visible = true;
				});
			}
			else
			{
				Invoke((Action)delegate
				{
					Close();
					GClass29.smethod_0("Không có file backup rác!");
				});
			}
		}
		catch
		{
		}
	}

	[CompilerGenerated]
	private void AE2AE197()
	{
		lblStatus.Text = string.Format(F7AB102E.smethod_0("Tìm thấy {0} file backup rác!"), list_0.Count) + "\r\n" + F7AB102E.smethod_0("Bạn có muốn dọn dẹp?");
		btnAdd.Visible = true;
		btnCancel.Visible = true;
	}

	[CompilerGenerated]
	private void EB3F90B1()
	{
		Close();
		GClass29.smethod_0("Không có file backup rác!");
	}
}
