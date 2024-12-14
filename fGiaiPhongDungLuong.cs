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

public class fGiaiPhongDungLuong : Form
{
	[CompilerGenerated]
	private sealed class Class68
	{
		public Label label_0;

		public string string_0;

		internal void method_0()
		{
			label_0.Text = string_0;
		}
	}

	[CompilerGenerated]
	private sealed class Class69
	{
		public Label label_0;

		internal void method_0()
		{
			label_0.Visible = true;
		}
	}

	[CompilerGenerated]
	private sealed class F59F8536
	{
		public bool bool_0;

		public Label DD3BD423;

		internal void method_0()
		{
			if (bool_0)
			{
				DD3BD423.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			}
			else
			{
				DD3BD423.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class70
	{
		public List<string> list_0;

		public fGiaiPhongDungLuong D0BE0F88;
	}

	[CompilerGenerated]
	private sealed class AD0C4A0E
	{
		public int int_0;

		public int int_1;

		public Class70 class70_0;
	}

	[CompilerGenerated]
	private sealed class DC8AE9B8
	{
		public int F223C330;

		public AD0C4A0E ad0C4A0E_0;

		internal void method_0()
		{
			try
			{
				string string_ = GClass25.smethod_2() + "\\" + ad0C4A0E_0.class70_0.list_0[F223C330];
				GClass8.smethod_67(string_);
				Interlocked.Increment(ref ad0C4A0E_0.int_0);
				ad0C4A0E_0.class70_0.D0BE0F88.method_1(ad0C4A0E_0.class70_0.D0BE0F88.lblStatusDonDepProfileRac, F7AB102E.smethod_0("Đang chạy") + $" {ad0C4A0E_0.int_0}/{ad0C4A0E_0.class70_0.list_0.Count}...");
				Interlocked.Decrement(ref ad0C4A0E_0.int_1);
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class A5A083A8
	{
		public int BB9DB71C;

		public List<string> E50FAFBB;

		public int int_0;

		public fGiaiPhongDungLuong fGiaiPhongDungLuong_0;
	}

	[CompilerGenerated]
	private sealed class Class71
	{
		public string DFBA1697;

		public A5A083A8 a5A083A8_0;

		internal void method_0()
		{
			try
			{
				string string_ = GClass25.smethod_2() + "\\" + DFBA1697;
				GClass8.BF940611(string_);
				Interlocked.Increment(ref a5A083A8_0.BB9DB71C);
				a5A083A8_0.fGiaiPhongDungLuong_0.method_1(a5A083A8_0.fGiaiPhongDungLuong_0.E5962719, F7AB102E.smethod_0("Đang chạy") + $" {a5A083A8_0.BB9DB71C}/{a5A083A8_0.E50FAFBB.Count}...");
				Interlocked.Decrement(ref a5A083A8_0.int_0);
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class B489C2B5
	{
		public List<string> list_0;

		public int int_0;

		public int E3190F0E;

		public fGiaiPhongDungLuong fGiaiPhongDungLuong_0;
	}

	[CompilerGenerated]
	private sealed class D2AFC013
	{
		public int int_0;

		public B489C2B5 b489C2B5_0;

		internal void AABDFC37()
		{
			try
			{
				GClass8.smethod_67(b489C2B5_0.list_0[int_0]);
				Interlocked.Increment(ref b489C2B5_0.int_0);
				b489C2B5_0.fGiaiPhongDungLuong_0.method_1(b489C2B5_0.fGiaiPhongDungLuong_0.B3A9912B, F7AB102E.smethod_0("Đang chạy") + $" {b489C2B5_0.int_0}/{b489C2B5_0.list_0.Count}...");
				Interlocked.Decrement(ref b489C2B5_0.E3190F0E);
			}
			catch
			{
			}
		}
	}

	private bool bool_0 = false;

	private bool D03E2E9B = false;

	private IContainer D20FF1A5 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button E18C832E;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox A7ADC234;

	private Label lblXoaFileRac;

	private Label lblDonDepProfileRac;

	private Label DFA78DA7;

	private Label lblStatusXoaFileRac;

	private Label lblStatusDonDepProfileRac;

	private Label E5962719;

	private Label B3A9912B;

	private Label E0AC57A5;

	public fGiaiPhongDungLuong(bool bool_1 = false)
	{
		B3AFDF27();
		bool_0 = bool_1;
		F7AB102E.D6B70A35(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E18C832E_Click(object sender, EventArgs e)
	{
		E18C832E.Invoke((Action)delegate
		{
			E18C832E.Enabled = false;
		});
		D03E2E9B = true;
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

	private void method_1(Label label_0, string FF945607)
	{
		try
		{
			Invoke((Action)delegate
			{
				label_0.Text = FF945607;
			});
		}
		catch
		{
		}
	}

	private void C2BA883E(Label AE10F09D)
	{
		try
		{
			Invoke((Action)delegate
			{
				AE10F09D.Visible = true;
			});
		}
		catch
		{
		}
	}

	private void method_2(Label DEA6BAAB, bool bool_1 = true)
	{
		try
		{
			Invoke((Action)delegate
			{
				if (bool_1)
				{
					DEA6BAAB.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
				}
				else
				{
					DEA6BAAB.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
				}
			});
		}
		catch
		{
		}
	}

	private void EAA87080(object sender, EventArgs e)
	{
		GClass8.smethod_41("chromedriver");
		new Thread((ThreadStart)delegate
		{
			try
			{
				method_2(lblXoaFileRac);
				method_1(lblStatusXoaFileRac, F7AB102E.smethod_0("Đang chạy") + "...");
				C2BA883E(lblStatusXoaFileRac);
				GClass8.smethod_67("log");
				GClass8.smethod_67("log_capture");
				GClass8.smethod_67("Plugins");
				GClass8.smethod_67("golike");
				GClass8.smethod_71("logJob.txt");
				if (!D03E2E9B)
				{
					method_1(lblStatusXoaFileRac, F7AB102E.smethod_0("Hoàn thành!"));
					method_2(lblXoaFileRac, bool_1: false);
					method_2(lblDonDepProfileRac);
					method_1(lblStatusDonDepProfileRac, "");
					C2BA883E(lblStatusDonDepProfileRac);
					int num = GClass25.smethod_0("configGeneral").method_2("nudHideThread", 10);
					List<string> list = Directory.GetDirectories(GClass25.smethod_2()).ToList();
					List<string> list2 = method_0();
					List<string> list_ = new List<string>();
					string text = "";
					for (int i = 0; i < list.Count; i++)
					{
						text = list[i].Substring(list[i].LastIndexOf("\\") + 1);
						if (!list2.Contains(text))
						{
							list_.Add(text);
						}
					}
					try
					{
						int int_4 = 0;
						int int_3 = 0;
						int num2 = 0;
						while (num2 < list_.Count && !D03E2E9B)
						{
							if (int_4 < num)
							{
								Interlocked.Increment(ref int_4);
								int F223C330 = num2++;
								new Thread((ThreadStart)delegate
								{
									try
									{
										string string_2 = GClass25.smethod_2() + "\\" + list_[F223C330];
										GClass8.smethod_67(string_2);
										Interlocked.Increment(ref int_3);
										method_1(lblStatusDonDepProfileRac, F7AB102E.smethod_0("Đang chạy") + $" {int_3}/{list_.Count}...");
										Interlocked.Decrement(ref int_4);
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
						while (int_4 > 0)
						{
							GClass8.smethod_53(1.0);
						}
					}
					catch
					{
					}
					if (!D03E2E9B)
					{
						method_1(lblStatusDonDepProfileRac, F7AB102E.smethod_0("Hoàn thành!"));
						method_2(lblDonDepProfileRac, bool_1: false);
						method_2(DFA78DA7);
						method_1(E5962719, "");
						C2BA883E(E5962719);
						int int_2 = 0;
						int BB9DB71C = 0;
						List<string> E50FAFBB = method_0();
						int num3 = 0;
						while (num3 < E50FAFBB.Count && !D03E2E9B)
						{
							if (int_2 < num)
							{
								Interlocked.Increment(ref int_2);
								string DFBA1697 = E50FAFBB[num3++];
								new Thread((ThreadStart)delegate
								{
									try
									{
										string string_ = GClass25.smethod_2() + "\\" + DFBA1697;
										GClass8.BF940611(string_);
										Interlocked.Increment(ref BB9DB71C);
										method_1(E5962719, F7AB102E.smethod_0("Đang chạy") + $" {BB9DB71C}/{E50FAFBB.Count}...");
										Interlocked.Decrement(ref int_2);
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
						while (int_2 > 0)
						{
							GClass8.smethod_53(1.0);
						}
						if (!D03E2E9B)
						{
							method_1(E5962719, F7AB102E.smethod_0("Hoàn thành!"));
							method_2(DFA78DA7, bool_1: false);
							method_2(E0AC57A5);
							method_1(B3A9912B, "");
							C2BA883E(B3A9912B);
							try
							{
								int E3190F0E = 0;
								int int_ = 0;
								List<string> list_0 = Directory.GetDirectories(Path.GetTempPath()).ToList();
								int num4 = 0;
								while (num4 < list_0.Count && !D03E2E9B)
								{
									if (E3190F0E < num)
									{
										Interlocked.Increment(ref E3190F0E);
										int int_0 = num4++;
										new Thread((ThreadStart)delegate
										{
											try
											{
												GClass8.smethod_67(list_0[int_0]);
												Interlocked.Increment(ref int_);
												method_1(B3A9912B, F7AB102E.smethod_0("Đang chạy") + $" {int_}/{list_0.Count}...");
												Interlocked.Decrement(ref E3190F0E);
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
								while (E3190F0E > 0)
								{
									GClass8.smethod_53(1.0);
								}
							}
							catch
							{
							}
							GClass8.smethod_85();
						}
					}
				}
				if (bool_0 && !D03E2E9B)
				{
					GClass8.C539C921();
				}
				Invoke((Action)delegate
				{
					Close();
				});
			}
			catch (Exception ex)
			{
				GClass29.smethod_0("Error:\n" + ex.ToString());
			}
		}).Start();
	}

	protected override void Dispose(bool A1A8D8AA)
	{
		if (A1A8D8AA && D20FF1A5 != null)
		{
			D20FF1A5.Dispose();
		}
		base.Dispose(A1A8D8AA);
	}

	private void B3AFDF27()
	{
		D20FF1A5 = new Container();
		bunifuCards1 = new BunifuCards();
		pnlHeader = new Panel();
		A7ADC234 = new PictureBox();
		btnMinimize = new Button();
		bunifuCustomLabel1 = new BunifuCustomLabel();
		E18C832E = new Button();
		bunifuDragControl_0 = new BunifuDragControl(D20FF1A5);
		lblXoaFileRac = new Label();
		lblDonDepProfileRac = new Label();
		DFA78DA7 = new Label();
		lblStatusXoaFileRac = new Label();
		lblStatusDonDepProfileRac = new Label();
		E5962719 = new Label();
		B3A9912B = new Label();
		E0AC57A5 = new Label();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)A7ADC234).BeginInit();
		SuspendLayout();
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.SaddleBrown;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.Dock = DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(373, 38);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(A7ADC234);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(373, 32);
		pnlHeader.TabIndex = 9;
		A7ADC234.Cursor = Cursors.Default;
		A7ADC234.Image = C50FB39E.Bitmap_5;
		A7ADC234.Location = new Point(3, 2);
		A7ADC234.Name = "pictureBox1";
		A7ADC234.Size = new Size(34, 27);
		A7ADC234.SizeMode = PictureBoxSizeMode.Zoom;
		A7ADC234.TabIndex = 17;
		A7ADC234.TabStop = false;
		btnMinimize.Cursor = Cursors.Hand;
		btnMinimize.Dock = DockStyle.Right;
		btnMinimize.Enabled = false;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = FlatStyle.Flat;
		btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = Color.White;
		btnMinimize.Image = C50FB39E.Bitmap_12;
		btnMinimize.Location = new Point(341, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += btnMinimize_Click;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(373, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Giải phóng dung lượng";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		E18C832E.Anchor = AnchorStyles.Bottom;
		E18C832E.BackColor = Color.Maroon;
		E18C832E.Cursor = Cursors.Hand;
		E18C832E.FlatAppearance.BorderSize = 0;
		E18C832E.FlatStyle = FlatStyle.Flat;
		E18C832E.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		E18C832E.ForeColor = Color.White;
		E18C832E.Location = new Point(142, 191);
		E18C832E.Name = "btnCancel";
		E18C832E.Size = new Size(92, 29);
		E18C832E.TabIndex = 4;
		E18C832E.Text = "Dừng";
		E18C832E.UseVisualStyleBackColor = false;
		E18C832E.Click += E18C832E_Click;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		lblXoaFileRac.AutoSize = true;
		lblXoaFileRac.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lblXoaFileRac.Location = new Point(35, 71);
		lblXoaFileRac.Name = "lblXoaFileRac";
		lblXoaFileRac.Size = new Size(90, 16);
		lblXoaFileRac.TabIndex = 5;
		lblXoaFileRac.Text = "1. Xóa File rác";
		lblDonDepProfileRac.AutoSize = true;
		lblDonDepProfileRac.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lblDonDepProfileRac.Location = new Point(35, 95);
		lblDonDepProfileRac.Name = "lblDonDepProfileRac";
		lblDonDepProfileRac.Size = new Size(131, 16);
		lblDonDepProfileRac.TabIndex = 5;
		lblDonDepProfileRac.Text = "2. Dọn dẹp profile rác";
		DFA78DA7.AutoSize = true;
		DFA78DA7.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		DFA78DA7.Location = new Point(35, 119);
		DFA78DA7.Name = "lblXoaCacheProfile";
		DFA78DA7.Size = new Size(123, 16);
		DFA78DA7.TabIndex = 5;
		DFA78DA7.Text = "3. Xóa Cache profile";
		lblStatusXoaFileRac.AutoSize = true;
		lblStatusXoaFileRac.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lblStatusXoaFileRac.ForeColor = Color.DarkGreen;
		lblStatusXoaFileRac.Location = new Point(200, 71);
		lblStatusXoaFileRac.Name = "lblStatusXoaFileRac";
		lblStatusXoaFileRac.Size = new Size(79, 16);
		lblStatusXoaFileRac.TabIndex = 5;
		lblStatusXoaFileRac.Text = "Đang chạy...";
		lblStatusXoaFileRac.Visible = false;
		lblStatusDonDepProfileRac.AutoSize = true;
		lblStatusDonDepProfileRac.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lblStatusDonDepProfileRac.ForeColor = Color.DarkGreen;
		lblStatusDonDepProfileRac.Location = new Point(200, 95);
		lblStatusDonDepProfileRac.Name = "lblStatusDonDepProfileRac";
		lblStatusDonDepProfileRac.Size = new Size(102, 16);
		lblStatusDonDepProfileRac.TabIndex = 5;
		lblStatusDonDepProfileRac.Text = "Đang chạy 0/0...";
		lblStatusDonDepProfileRac.Visible = false;
		E5962719.AutoSize = true;
		E5962719.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		E5962719.ForeColor = Color.DarkGreen;
		E5962719.Location = new Point(200, 119);
		E5962719.Name = "lblStatusXoaCacheProfile";
		E5962719.Size = new Size(102, 16);
		E5962719.TabIndex = 5;
		E5962719.Text = "Đang chạy 0/0...";
		E5962719.Visible = false;
		B3A9912B.AutoSize = true;
		B3A9912B.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		B3A9912B.ForeColor = Color.DarkGreen;
		B3A9912B.Location = new Point(200, 144);
		B3A9912B.Name = "lblStatusXoaTemp";
		B3A9912B.Size = new Size(102, 16);
		B3A9912B.TabIndex = 5;
		B3A9912B.Text = "Đang chạy 0/0...";
		B3A9912B.Visible = false;
		E0AC57A5.AutoSize = true;
		E0AC57A5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		E0AC57A5.Location = new Point(35, 144);
		E0AC57A5.Name = "lblXoaTemp";
		E0AC57A5.Size = new Size(81, 16);
		E0AC57A5.TabIndex = 5;
		E0AC57A5.Text = "4. Xóa Temp";
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(373, 232);
		base.Controls.Add(E0AC57A5);
		base.Controls.Add(DFA78DA7);
		base.Controls.Add(B3A9912B);
		base.Controls.Add(lblDonDepProfileRac);
		base.Controls.Add(E5962719);
		base.Controls.Add(lblStatusDonDepProfileRac);
		base.Controls.Add(lblStatusXoaFileRac);
		base.Controls.Add(lblXoaFileRac);
		base.Controls.Add(E18C832E);
		base.Controls.Add(bunifuCards1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fGiaiPhongDungLuong";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += EAA87080;
		bunifuCards1.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)A7ADC234).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[CompilerGenerated]
	private void method_3()
	{
		E18C832E.Enabled = false;
	}

	[CompilerGenerated]
	private void method_4()
	{
		try
		{
			method_2(lblXoaFileRac);
			method_1(lblStatusXoaFileRac, F7AB102E.smethod_0("Đang chạy") + "...");
			C2BA883E(lblStatusXoaFileRac);
			GClass8.smethod_67("log");
			GClass8.smethod_67("log_capture");
			GClass8.smethod_67("Plugins");
			GClass8.smethod_67("golike");
			GClass8.smethod_71("logJob.txt");
			if (!D03E2E9B)
			{
				method_1(lblStatusXoaFileRac, F7AB102E.smethod_0("Hoàn thành!"));
				method_2(lblXoaFileRac, bool_1: false);
				method_2(lblDonDepProfileRac);
				method_1(lblStatusDonDepProfileRac, "");
				C2BA883E(lblStatusDonDepProfileRac);
				int num = GClass25.smethod_0("configGeneral").method_2("nudHideThread", 10);
				List<string> list = Directory.GetDirectories(GClass25.smethod_2()).ToList();
				List<string> list2 = method_0();
				List<string> list_ = new List<string>();
				string text = "";
				for (int i = 0; i < list.Count; i++)
				{
					text = list[i].Substring(list[i].LastIndexOf("\\") + 1);
					if (!list2.Contains(text))
					{
						list_.Add(text);
					}
				}
				try
				{
					int int_4 = 0;
					int int_3 = 0;
					int num2 = 0;
					while (num2 < list_.Count && !D03E2E9B)
					{
						if (int_4 < num)
						{
							Interlocked.Increment(ref int_4);
							int F223C330 = num2++;
							new Thread((ThreadStart)delegate
							{
								try
								{
									string string_2 = GClass25.smethod_2() + "\\" + list_[F223C330];
									GClass8.smethod_67(string_2);
									Interlocked.Increment(ref int_3);
									method_1(lblStatusDonDepProfileRac, F7AB102E.smethod_0("Đang chạy") + $" {int_3}/{list_.Count}...");
									Interlocked.Decrement(ref int_4);
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
					while (int_4 > 0)
					{
						GClass8.smethod_53(1.0);
					}
				}
				catch
				{
				}
				if (!D03E2E9B)
				{
					method_1(lblStatusDonDepProfileRac, F7AB102E.smethod_0("Hoàn thành!"));
					method_2(lblDonDepProfileRac, bool_1: false);
					method_2(DFA78DA7);
					method_1(E5962719, "");
					C2BA883E(E5962719);
					int int_2 = 0;
					int BB9DB71C = 0;
					List<string> E50FAFBB = method_0();
					int num3 = 0;
					while (num3 < E50FAFBB.Count && !D03E2E9B)
					{
						if (int_2 < num)
						{
							Interlocked.Increment(ref int_2);
							string DFBA1697 = E50FAFBB[num3++];
							new Thread((ThreadStart)delegate
							{
								try
								{
									string string_ = GClass25.smethod_2() + "\\" + DFBA1697;
									GClass8.BF940611(string_);
									Interlocked.Increment(ref BB9DB71C);
									method_1(E5962719, F7AB102E.smethod_0("Đang chạy") + $" {BB9DB71C}/{E50FAFBB.Count}...");
									Interlocked.Decrement(ref int_2);
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
					while (int_2 > 0)
					{
						GClass8.smethod_53(1.0);
					}
					if (!D03E2E9B)
					{
						method_1(E5962719, F7AB102E.smethod_0("Hoàn thành!"));
						method_2(DFA78DA7, bool_1: false);
						method_2(E0AC57A5);
						method_1(B3A9912B, "");
						C2BA883E(B3A9912B);
						try
						{
							int E3190F0E = 0;
							int int_ = 0;
							List<string> list_0 = Directory.GetDirectories(Path.GetTempPath()).ToList();
							int num4 = 0;
							while (num4 < list_0.Count && !D03E2E9B)
							{
								if (E3190F0E < num)
								{
									Interlocked.Increment(ref E3190F0E);
									int int_0 = num4++;
									new Thread((ThreadStart)delegate
									{
										try
										{
											GClass8.smethod_67(list_0[int_0]);
											Interlocked.Increment(ref int_);
											method_1(B3A9912B, F7AB102E.smethod_0("Đang chạy") + $" {int_}/{list_0.Count}...");
											Interlocked.Decrement(ref E3190F0E);
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
							while (E3190F0E > 0)
							{
								GClass8.smethod_53(1.0);
							}
						}
						catch
						{
						}
						GClass8.smethod_85();
					}
				}
			}
			if (bool_0 && !D03E2E9B)
			{
				GClass8.C539C921();
			}
			Invoke((Action)delegate
			{
				Close();
			});
		}
		catch (Exception ex)
		{
			GClass29.smethod_0("Error:\n" + ex.ToString());
		}
	}

	[CompilerGenerated]
	private void F207408F()
	{
		Close();
	}
}
