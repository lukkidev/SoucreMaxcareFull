using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTienIchCheckStatusXProxy : Form
{
	[CompilerGenerated]
	private sealed class Class88
	{
		public string B10C4A03;

		public fTienIchCheckStatusXProxy fTienIchCheckStatusXProxy_0;

		internal void method_0()
		{
			try
			{
				if (B10C4A03 == "")
				{
					for (int i = 0; i < fTienIchCheckStatusXProxy_0.A704C009.RowCount; i++)
					{
						Thread thread = new Thread(new A4BD5C97
						{
							CABC31A2 = this,
							int_0 = i
						}.method_0);
						thread.IsBackground = true;
						thread.Start();
					}
				}
				else if (B10C4A03.StartsWith("http"))
				{
					for (int j = 0; j < fTienIchCheckStatusXProxy_0.A704C009.RowCount; j++)
					{
						Thread thread2 = new Thread(new FBBD5693
						{
							A88DB6B2 = this,
							int_0 = j
						}.method_0);
						thread2.IsBackground = true;
						thread2.Start();
					}
				}
				else
				{
					for (int k = 0; k < fTienIchCheckStatusXProxy_0.A704C009.RowCount; k++)
					{
						Thread thread3 = new Thread(new Class89
						{
							class88_0 = this,
							int_0 = k
						}.CA319638);
						thread3.IsBackground = true;
						thread3.Start();
					}
				}
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class A4BD5C97
	{
		public int int_0;

		public Class88 CABC31A2;

		internal void method_0()
		{
			try
			{
				string string_ = CABC31A2.fTienIchCheckStatusXProxy_0.A704C009.Rows[int_0].Cells["cProxy"].Value.ToString();
				string bB1C838D = GClass8.smethod_59(string_);
				GClass27.smethod_5(CABC31A2.fTienIchCheckStatusXProxy_0.A704C009, int_0, "cStatus", bB1C838D);
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class FBBD5693
	{
		public int int_0;

		public Class88 A88DB6B2;

		internal void method_0()
		{
			try
			{
				string text = A88DB6B2.fTienIchCheckStatusXProxy_0.A704C009.Rows[int_0].Cells["cProxy"].Value.ToString();
				string string_ = A88DB6B2.B10C4A03 + "/status?proxy=" + text;
				string bB1C838D = new F3958F9B().method_0(string_);
				GClass27.smethod_5(A88DB6B2.fTienIchCheckStatusXProxy_0.A704C009, int_0, "cStatus", bB1C838D);
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class89
	{
		public int int_0;

		public Class88 class88_0;

		internal void CA319638()
		{
			try
			{
				string text = class88_0.fTienIchCheckStatusXProxy_0.A704C009.Rows[int_0].Cells["cProxy"].Value.ToString();
				string string_ = "https://api.proxyv6.net/api/check-list-proxy?api_key=" + class88_0.B10C4A03;
				string text2 = text.Split(':')[2] + ":" + text.Split(':')[3] + "@" + text.Split(':')[0] + ":" + text.Split(':')[1];
				string bFA79D3C = "{\"proxies\": [\"" + text2 + "\"]}";
				F3958F9B f3958F9B = new F3958F9B();
				string bB1C838D = f3958F9B.A6321D97(string_, bFA79D3C, "application/json");
				GClass27.smethod_5(class88_0.fTienIchCheckStatusXProxy_0.A704C009, int_0, "cStatus", bB1C838D);
			}
			catch
			{
			}
		}
	}

	private bool bool_0 = false;

	public static List<string> EB34480B;

	public static List<string> list_0;

	public static bool bool_1;

	private IContainer D985C9A4 = null;

	private BunifuCards FA3D548B;

	private Panel pnlHeader;

	private BunifuCustomLabel C1BBD63F;

	private Button A33E64B8;

	private BunifuDragControl AD876822;

	private PictureBox pictureBox1;

	public DataGridView A704C009;

	private RichTextBox FD37083E;

	private Label label17;

	private Label E1BA331B;

	private DataGridViewTextBoxColumn cStt;

	private DataGridViewTextBoxColumn AA9A88BB;

	private DataGridViewTextBoxColumn cStatus;

	private Button btnCheck;

	private Label label2;

	private TextBox txtUrl;

	public fTienIchCheckStatusXProxy(bool AAB65C11 = false)
	{
		InitializeComponent();
		bool_1 = false;
		bool_0 = AAB65C11;
		F7AB102E.D6B70A35(this);
	}

	private void EF1A7C1D(object sender, EventArgs e)
	{
		Close();
	}

	private void C43AADAF(object sender, EventArgs e)
	{
		bool_1 = true;
		if (bool_0)
		{
			list_0 = new List<string>();
			for (int i = 0; i < A704C009.Rows.Count; i++)
			{
				if (Convert.ToBoolean(A704C009.Rows[i].Cells["cChose"].Value))
				{
					list_0.Add(GClass27.smethod_3(A704C009, i, "cId"));
				}
			}
			if (list_0.Count == 0)
			{
				GClass29.smethod_0(F7AB102E.smethod_0("Vui lòng chọn ít nhất 1 thư mục!"), 2);
				return;
			}
		}
		else
		{
			EB34480B = new List<string>();
			for (int j = 0; j < A704C009.Rows.Count; j++)
			{
				if (Convert.ToBoolean(A704C009.Rows[j].Cells["cChose"].Value))
				{
					EB34480B.Add(GClass27.smethod_3(A704C009, j, "cId"));
				}
			}
			if (EB34480B.Count == 0)
			{
				GClass29.smethod_0(F7AB102E.smethod_0("Vui lòng chọn ít nhất 1 thư mục!"), 2);
				return;
			}
		}
		Close();
	}

	private void A704C009_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			if (Convert.ToBoolean(A704C009.CurrentRow.Cells["cChose"].Value))
			{
				A704C009.CurrentRow.Cells["cChose"].Value = false;
			}
			else
			{
				A704C009.CurrentRow.Cells["cChose"].Value = true;
			}
		}
		catch
		{
		}
	}

	private int CEB7D038()
	{
		int num = 0;
		for (int i = 0; i < A704C009.Rows.Count; i++)
		{
			if (Convert.ToBoolean(A704C009.Rows[i].Cells["cChose"].Value))
			{
				num++;
			}
		}
		return num;
	}

	private void AD056A21(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex != 0)
		{
			return;
		}
		try
		{
			if (Convert.ToBoolean(A704C009.CurrentRow.Cells["cChose"].Value))
			{
				A704C009.CurrentRow.Cells["cChose"].Value = false;
			}
			else
			{
				A704C009.CurrentRow.Cells["cChose"].Value = true;
			}
		}
		catch
		{
		}
	}

	private void BA141D1E(object sender, EventArgs e)
	{
		GClass8.smethod_60(FD37083E, label17);
	}

	private void btnCheck_Click(object sender, EventArgs e)
	{
		if (FD37083E.Text.Trim() == "")
		{
			GClass29.smethod_0("Vui lòng nhập proxy trước!", 3);
			FD37083E.Focus();
			return;
		}
		string B10C4A3 = txtUrl.Text.Trim().TrimEnd('/');
		List<string> e03C713E = FD37083E.Lines.ToList();
		e03C713E = GClass8.smethod_36(e03C713E);
		A704C009.Rows.Clear();
		for (int i = 0; i < e03C713E.Count; i++)
		{
			A704C009.Rows.Add(i + 1, e03C713E[i], "Đang check...");
		}
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				if (B10C4A3 == "")
				{
					for (int j = 0; j < A704C009.RowCount; j++)
					{
						int int_ = j;
						Thread thread2 = new Thread((ThreadStart)delegate
						{
							try
							{
								string string_3 = A704C009.Rows[int_].Cells["cProxy"].Value.ToString();
								string bB1C838D3 = GClass8.smethod_59(string_3);
								GClass27.smethod_5(A704C009, int_, "cStatus", bB1C838D3);
							}
							catch
							{
							}
						});
						thread2.IsBackground = true;
						thread2.Start();
					}
				}
				else if (B10C4A3.StartsWith("http"))
				{
					for (int k = 0; k < A704C009.RowCount; k++)
					{
						int int_2 = k;
						Thread thread3 = new Thread((ThreadStart)delegate
						{
							try
							{
								string text3 = A704C009.Rows[int_2].Cells["cProxy"].Value.ToString();
								string string_2 = B10C4A3 + "/status?proxy=" + text3;
								string bB1C838D2 = new F3958F9B().method_0(string_2);
								GClass27.smethod_5(A704C009, int_2, "cStatus", bB1C838D2);
							}
							catch
							{
							}
						});
						thread3.IsBackground = true;
						thread3.Start();
					}
				}
				else
				{
					for (int l = 0; l < A704C009.RowCount; l++)
					{
						int int_0 = l;
						Thread thread4 = new Thread((ThreadStart)delegate
						{
							try
							{
								string text = A704C009.Rows[int_0].Cells["cProxy"].Value.ToString();
								string string_ = "https://api.proxyv6.net/api/check-list-proxy?api_key=" + B10C4A3;
								string text2 = text.Split(':')[2] + ":" + text.Split(':')[3] + "@" + text.Split(':')[0] + ":" + text.Split(':')[1];
								string bFA79D3C = "{\"proxies\": [\"" + text2 + "\"]}";
								F3958F9B f3958F9B = new F3958F9B();
								string bB1C838D = f3958F9B.A6321D97(string_, bFA79D3C, "application/json");
								GClass27.smethod_5(A704C009, int_0, "cStatus", bB1C838D);
							}
							catch
							{
							}
						});
						thread4.IsBackground = true;
						thread4.Start();
					}
				}
			}
			catch
			{
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	protected override void Dispose(bool C502EB2F)
	{
		if (C502EB2F && D985C9A4 != null)
		{
			D985C9A4.Dispose();
		}
		base.Dispose(C502EB2F);
	}

	private void InitializeComponent()
	{
		D985C9A4 = new System.ComponentModel.Container();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		FA3D548B = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		A33E64B8 = new System.Windows.Forms.Button();
		C1BBD63F = new Bunifu.Framework.UI.BunifuCustomLabel();
		AD876822 = new Bunifu.Framework.UI.BunifuDragControl(D985C9A4);
		A704C009 = new System.Windows.Forms.DataGridView();
		cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		AA9A88BB = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
		FD37083E = new System.Windows.Forms.RichTextBox();
		label17 = new System.Windows.Forms.Label();
		E1BA331B = new System.Windows.Forms.Label();
		btnCheck = new System.Windows.Forms.Button();
		label2 = new System.Windows.Forms.Label();
		txtUrl = new System.Windows.Forms.TextBox();
		FA3D548B.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)A704C009).BeginInit();
		SuspendLayout();
		FA3D548B.BackColor = System.Drawing.Color.White;
		FA3D548B.BorderRadius = 0;
		FA3D548B.BottomSahddow = true;
		FA3D548B.color = System.Drawing.Color.SaddleBrown;
		FA3D548B.Controls.Add(pnlHeader);
		FA3D548B.Dock = System.Windows.Forms.DockStyle.Top;
		FA3D548B.LeftSahddow = false;
		FA3D548B.Location = new System.Drawing.Point(0, 0);
		FA3D548B.Name = "bunifuCards1";
		FA3D548B.RightSahddow = true;
		FA3D548B.ShadowDepth = 20;
		FA3D548B.Size = new System.Drawing.Size(530, 34);
		FA3D548B.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(A33E64B8);
		pnlHeader.Controls.Add(C1BBD63F);
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(530, 28);
		pnlHeader.TabIndex = 9;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 17;
		pictureBox1.TabStop = false;
		A33E64B8.Cursor = System.Windows.Forms.Cursors.Hand;
		A33E64B8.Dock = System.Windows.Forms.DockStyle.Right;
		A33E64B8.FlatAppearance.BorderSize = 0;
		A33E64B8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A33E64B8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A33E64B8.ForeColor = System.Drawing.Color.White;
		A33E64B8.Image = C50FB39E.Bitmap_12;
		A33E64B8.Location = new System.Drawing.Point(498, 0);
		A33E64B8.Name = "btnMinimize";
		A33E64B8.Size = new System.Drawing.Size(32, 28);
		A33E64B8.TabIndex = 9;
		A33E64B8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		A33E64B8.UseVisualStyleBackColor = true;
		A33E64B8.Click += new System.EventHandler(EF1A7C1D);
		C1BBD63F.BackColor = System.Drawing.Color.Transparent;
		C1BBD63F.Cursor = System.Windows.Forms.Cursors.SizeAll;
		C1BBD63F.Dock = System.Windows.Forms.DockStyle.Fill;
		C1BBD63F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C1BBD63F.ForeColor = System.Drawing.Color.Black;
		C1BBD63F.Location = new System.Drawing.Point(0, 0);
		C1BBD63F.Name = "bunifuCustomLabel1";
		C1BBD63F.Size = new System.Drawing.Size(530, 28);
		C1BBD63F.TabIndex = 1;
		C1BBD63F.Text = "Check status XProxy";
		C1BBD63F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		AD876822.Fixed = true;
		AD876822.Horizontal = true;
		AD876822.TargetControl = C1BBD63F;
		AD876822.Vertical = true;
		A704C009.AllowUserToAddRows = false;
		A704C009.AllowUserToDeleteRows = false;
		A704C009.AllowUserToResizeRows = false;
		A704C009.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		A704C009.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		A704C009.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		A704C009.Columns.AddRange(cStt, AA9A88BB, cStatus);
		A704C009.Location = new System.Drawing.Point(15, 318);
		A704C009.Name = "dtgv";
		A704C009.ReadOnly = true;
		A704C009.RowHeadersVisible = false;
		A704C009.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		A704C009.Size = new System.Drawing.Size(499, 211);
		A704C009.TabIndex = 7;
		A704C009.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(AD056A21);
		A704C009.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(A704C009_CellDoubleClick);
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		cStt.DefaultCellStyle = dataGridViewCellStyle2;
		cStt.HeaderText = "STT";
		cStt.Name = "cStt";
		cStt.ReadOnly = true;
		cStt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		cStt.Width = 35;
		AA9A88BB.HeaderText = "Proxy";
		AA9A88BB.Name = "cProxy";
		AA9A88BB.ReadOnly = true;
		AA9A88BB.Width = 90;
		cStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		cStatus.HeaderText = "Status";
		cStatus.Name = "cStatus";
		cStatus.ReadOnly = true;
		FD37083E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		FD37083E.Font = new System.Drawing.Font("Tahoma", 9.75f);
		FD37083E.Location = new System.Drawing.Point(15, 92);
		FD37083E.Name = "txtListProxy";
		FD37083E.Size = new System.Drawing.Size(499, 158);
		FD37083E.TabIndex = 146;
		FD37083E.Text = "";
		FD37083E.WordWrap = false;
		FD37083E.TextChanged += new System.EventHandler(BA141D1E);
		label17.AutoSize = true;
		label17.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label17.Location = new System.Drawing.Point(12, 73);
		label17.Name = "label17";
		label17.Size = new System.Drawing.Size(97, 16);
		label17.TabIndex = 145;
		label17.Text = "Nhập Proxy (0):";
		E1BA331B.AutoSize = true;
		E1BA331B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		E1BA331B.Location = new System.Drawing.Point(12, 299);
		E1BA331B.Name = "label1";
		E1BA331B.Size = new System.Drawing.Size(55, 16);
		E1BA331B.TabIndex = 145;
		E1BA331B.Text = "Kết quả:";
		btnCheck.BackColor = System.Drawing.Color.Green;
		btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCheck.FlatAppearance.BorderSize = 0;
		btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCheck.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCheck.ForeColor = System.Drawing.Color.White;
		btnCheck.Location = new System.Drawing.Point(223, 261);
		btnCheck.Name = "btnCheck";
		btnCheck.Size = new System.Drawing.Size(82, 33);
		btnCheck.TabIndex = 147;
		btnCheck.Text = "Check";
		btnCheck.UseVisualStyleBackColor = false;
		btnCheck.Click += new System.EventHandler(btnCheck_Click);
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label2.Location = new System.Drawing.Point(12, 48);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(34, 16);
		label2.TabIndex = 145;
		label2.Text = "URL:";
		txtUrl.Font = new System.Drawing.Font("Tahoma", 9.75f);
		txtUrl.Location = new System.Drawing.Point(53, 47);
		txtUrl.Name = "txtUrl";
		txtUrl.Size = new System.Drawing.Size(461, 23);
		txtUrl.TabIndex = 148;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(530, 547);
		base.Controls.Add(txtUrl);
		base.Controls.Add(btnCheck);
		base.Controls.Add(FD37083E);
		base.Controls.Add(label2);
		base.Controls.Add(E1BA331B);
		base.Controls.Add(label17);
		base.Controls.Add(A704C009);
		base.Controls.Add(FA3D548B);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fTienIchCheckStatusXProxy";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		FA3D548B.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)A704C009).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
