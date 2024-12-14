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

public class E62E1719 : Form
{
	[CompilerGenerated]
	private sealed class Class93
	{
		public int int_0;

		public int int_1;

		public E62E1719 D92F6691;

		public int int_2;

		public Action action_0;

		internal void AC18DCB0()
		{
			try
			{
				if (Class52.smethod_0())
				{
					int num = 0;
					while (num < D92F6691.list_0.Count)
					{
						E493FCA6 CS_0024_003C_003E8__locals0 = new E493FCA6
						{
							class93_0 = this
						};
						if (int_0 >= int_1)
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							try
							{
								Class52.smethod_4(CS_0024_003C_003E8__locals0.class93_0.D92F6691.list_0[CS_0024_003C_003E8__locals0.int_0]);
								Interlocked.Increment(ref CS_0024_003C_003E8__locals0.class93_0.int_2);
								CS_0024_003C_003E8__locals0.class93_0.D92F6691.AE045E95(string.Format(F7AB102E.smethod_0("Đang dọn dẹp profile {0}/{1}..."), CS_0024_003C_003E8__locals0.class93_0.int_2, CS_0024_003C_003E8__locals0.class93_0.D92F6691.list_0.Count));
								Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class93_0.int_0);
							}
							catch
							{
							}
						}).Start();
					}
				}
				else
				{
					int num2 = 0;
					while (num2 < D92F6691.list_0.Count)
					{
						Class94 CS_0024_003C_003E8__locals1 = new Class94
						{
							class93_0 = this
						};
						if (int_0 >= int_1)
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals1.int_0 = num2++;
						new Thread((ThreadStart)delegate
						{
							try
							{
								string path = GClass25.smethod_2() + "\\" + CS_0024_003C_003E8__locals1.class93_0.D92F6691.list_0[CS_0024_003C_003E8__locals1.int_0];
								Directory.Delete(path, recursive: true);
								Interlocked.Increment(ref CS_0024_003C_003E8__locals1.class93_0.int_2);
								CS_0024_003C_003E8__locals1.class93_0.D92F6691.AE045E95(string.Format(F7AB102E.smethod_0("Đang dọn dẹp profile {0}/{1}..."), CS_0024_003C_003E8__locals1.class93_0.int_2, CS_0024_003C_003E8__locals1.class93_0.D92F6691.list_0.Count));
								Interlocked.Decrement(ref CS_0024_003C_003E8__locals1.class93_0.int_0);
							}
							catch
							{
							}
						}).Start();
					}
				}
				while (int_0 > 0)
				{
					GClass8.smethod_53(1.0);
				}
				D92F6691.Invoke((Action)delegate
				{
					D92F6691.Close();
					GClass29.smethod_0("Đã dọn dẹp profile xong!");
				});
			}
			catch
			{
			}
		}

		internal void method_0()
		{
			D92F6691.Close();
			GClass29.smethod_0("Đã dọn dẹp profile xong!");
		}
	}

	[CompilerGenerated]
	private sealed class E493FCA6
	{
		public int int_0;

		public Class93 class93_0;

		internal void method_0()
		{
			try
			{
				Class52.smethod_4(class93_0.D92F6691.list_0[int_0]);
				Interlocked.Increment(ref class93_0.int_2);
				class93_0.D92F6691.AE045E95(string.Format(F7AB102E.smethod_0("Đang dọn dẹp profile {0}/{1}..."), class93_0.int_2, class93_0.D92F6691.list_0.Count));
				Interlocked.Decrement(ref class93_0.int_0);
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class94
	{
		public int int_0;

		public Class93 class93_0;

		internal void D002B527()
		{
			try
			{
				string path = GClass25.smethod_2() + "\\" + class93_0.D92F6691.list_0[int_0];
				Directory.Delete(path, recursive: true);
				Interlocked.Increment(ref class93_0.int_2);
				class93_0.D92F6691.AE045E95(string.Format(F7AB102E.smethod_0("Đang dọn dẹp profile {0}/{1}..."), class93_0.int_2, class93_0.D92F6691.list_0.Count));
				Interlocked.Decrement(ref class93_0.int_0);
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class E93653A7
	{
		public E62E1719 D8832BBF;

		public string D2B4A787;

		internal void method_0()
		{
			D8832BBF.FE3042A9.Text = D2B4A787;
		}
	}

	private List<string> list_0 = new List<string>();

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel C78CFCA9;

	private Button btnMinimize;

	private Button btnCancel;

	private Button C93DA60F;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuCustomLabel FE3042A9;

	private PictureBox pictureBox1;

	public E62E1719()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C93DA60F_Click(object sender, EventArgs e)
	{
		C93DA60F.Enabled = false;
		btnCancel.Enabled = false;
		int int_2 = 0;
		AE045E95(string.Format(F7AB102E.smethod_0("Đang dọn dẹp profile {0}/{1}..."), int_2, list_0.Count));
		int int_0 = 0;
		int int_1 = 20;
		new Thread((ThreadStart)delegate
		{
			try
			{
				if (Class52.smethod_0())
				{
					int num = 0;
					while (num < list_0.Count)
					{
						if (int_0 >= int_1)
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
						Interlocked.Increment(ref int_0);
						int int_4 = num++;
						new Thread((ThreadStart)delegate
						{
							try
							{
								Class52.smethod_4(list_0[int_4]);
								Interlocked.Increment(ref int_2);
								AE045E95(string.Format(F7AB102E.smethod_0("Đang dọn dẹp profile {0}/{1}..."), int_2, list_0.Count));
								Interlocked.Decrement(ref int_0);
							}
							catch
							{
							}
						}).Start();
					}
				}
				else
				{
					int num2 = 0;
					while (num2 < list_0.Count)
					{
						if (int_0 >= int_1)
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
						Interlocked.Increment(ref int_0);
						int int_3 = num2++;
						new Thread((ThreadStart)delegate
						{
							try
							{
								string path = GClass25.smethod_2() + "\\" + list_0[int_3];
								Directory.Delete(path, recursive: true);
								Interlocked.Increment(ref int_2);
								AE045E95(string.Format(F7AB102E.smethod_0("Đang dọn dẹp profile {0}/{1}..."), int_2, list_0.Count));
								Interlocked.Decrement(ref int_0);
							}
							catch
							{
							}
						}).Start();
					}
				}
				while (int_0 > 0)
				{
					GClass8.smethod_53(1.0);
				}
				Invoke((Action)delegate
				{
					Close();
					GClass29.smethod_0("Đã dọn dẹp profile xong!");
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

	private void FE3042A9_Click(object sender, EventArgs e)
	{
	}

	private List<string> ADA0FF0B()
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

	private void AE045E95(string F020BB20)
	{
		Invoke((Action)delegate
		{
			FE3042A9.Text = F020BB20;
		});
	}

	private void E62E1719_Load(object sender, EventArgs e)
	{
		new Thread((ThreadStart)delegate
		{
			try
			{
				List<string> list = ADA0FF0B();
				if (Class52.smethod_0())
				{
					Dictionary<string, string> dictionary = Class52.smethod_2();
					foreach (KeyValuePair<string, string> item in dictionary)
					{
						if (!list.Contains(item.Key))
						{
							list_0.Add(item.Value);
						}
					}
				}
				else
				{
					List<string> list2 = Directory.GetDirectories(GClass25.smethod_2()).ToList();
					string text = "";
					for (int i = 0; i < list2.Count; i++)
					{
						text = list2[i].Substring(list2[i].LastIndexOf("\\") + 1);
						if (!list.Contains(text))
						{
							list_0.Add(text);
						}
					}
				}
				if (list_0.Count > 0)
				{
					Invoke((Action)delegate
					{
						FE3042A9.Text = string.Format(F7AB102E.smethod_0("Tìm thấy {0} profile rác!"), list_0.Count) + "\r\n" + F7AB102E.smethod_0("Bạn có muốn dọn dẹp?");
						C93DA60F.Visible = true;
						btnCancel.Visible = true;
					});
				}
				else
				{
					Invoke((Action)delegate
					{
						Close();
						GClass29.smethod_0("Không có profile rác!");
					});
				}
			}
			catch (Exception)
			{
			}
		}).Start();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E62E1719));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		C78CFCA9 = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		C93DA60F = new System.Windows.Forms.Button();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		FE3042A9 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
		bunifuCards1.Size = new System.Drawing.Size(396, 38);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(C78CFCA9);
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
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		C78CFCA9.BackColor = System.Drawing.Color.Transparent;
		C78CFCA9.Cursor = System.Windows.Forms.Cursors.SizeAll;
		C78CFCA9.Dock = System.Windows.Forms.DockStyle.Fill;
		C78CFCA9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C78CFCA9.ForeColor = System.Drawing.Color.Black;
		C78CFCA9.Location = new System.Drawing.Point(0, 0);
		C78CFCA9.Name = "bunifuCustomLabel1";
		C78CFCA9.Size = new System.Drawing.Size(396, 32);
		C78CFCA9.TabIndex = 1;
		C78CFCA9.Text = "Dọn dẹp profile";
		C78CFCA9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
		C93DA60F.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		C93DA60F.Cursor = System.Windows.Forms.Cursors.Hand;
		C93DA60F.FlatAppearance.BorderSize = 0;
		C93DA60F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C93DA60F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C93DA60F.ForeColor = System.Drawing.Color.White;
		C93DA60F.Location = new System.Drawing.Point(100, 105);
		C93DA60F.Name = "btnAdd";
		C93DA60F.Size = new System.Drawing.Size(92, 29);
		C93DA60F.TabIndex = 3;
		C93DA60F.Text = "Đồng ý";
		C93DA60F.UseVisualStyleBackColor = false;
		C93DA60F.Visible = false;
		C93DA60F.Click += new System.EventHandler(C93DA60F_Click);
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = C78CFCA9;
		bunifuDragControl_0.Vertical = true;
		FE3042A9.BackColor = System.Drawing.Color.Transparent;
		FE3042A9.Cursor = System.Windows.Forms.Cursors.SizeAll;
		FE3042A9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		FE3042A9.ForeColor = System.Drawing.Color.Black;
		FE3042A9.Location = new System.Drawing.Point(-1, 57);
		FE3042A9.Name = "lblStatus";
		FE3042A9.Size = new System.Drawing.Size(396, 32);
		FE3042A9.TabIndex = 21;
		FE3042A9.Text = "Đang quét profile...";
		FE3042A9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		FE3042A9.Click += new System.EventHandler(FE3042A9_Click);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(396, 145);
		base.Controls.Add(FE3042A9);
		base.Controls.Add(btnCancel);
		base.Controls.Add(C93DA60F);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fClearProfile";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(E62E1719_Load);
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
	}

	[CompilerGenerated]
	private void F32089B2()
	{
		try
		{
			List<string> list = ADA0FF0B();
			if (Class52.smethod_0())
			{
				Dictionary<string, string> dictionary = Class52.smethod_2();
				foreach (KeyValuePair<string, string> item in dictionary)
				{
					if (!list.Contains(item.Key))
					{
						list_0.Add(item.Value);
					}
				}
			}
			else
			{
				List<string> list2 = Directory.GetDirectories(GClass25.smethod_2()).ToList();
				string text = "";
				for (int i = 0; i < list2.Count; i++)
				{
					text = list2[i].Substring(list2[i].LastIndexOf("\\") + 1);
					if (!list.Contains(text))
					{
						list_0.Add(text);
					}
				}
			}
			if (list_0.Count > 0)
			{
				Invoke((Action)delegate
				{
					FE3042A9.Text = string.Format(F7AB102E.smethod_0("Tìm thấy {0} profile rác!"), list_0.Count) + "\r\n" + F7AB102E.smethod_0("Bạn có muốn dọn dẹp?");
					C93DA60F.Visible = true;
					btnCancel.Visible = true;
				});
			}
			else
			{
				Invoke((Action)delegate
				{
					Close();
					GClass29.smethod_0("Không có profile rác!");
				});
			}
		}
		catch (Exception)
		{
		}
	}

	[CompilerGenerated]
	private void method_0()
	{
		FE3042A9.Text = string.Format(F7AB102E.smethod_0("Tìm thấy {0} profile rác!"), list_0.Count) + "\r\n" + F7AB102E.smethod_0("Bạn có muốn dọn dẹp?");
		C93DA60F.Visible = true;
		btnCancel.Visible = true;
	}

	[CompilerGenerated]
	private void AB265232()
	{
		Close();
		GClass29.smethod_0("Không có profile rác!");
	}
}
