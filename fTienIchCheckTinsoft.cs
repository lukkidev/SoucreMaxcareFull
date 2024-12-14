using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTienIchCheckTinsoft : Form
{
	[CompilerGenerated]
	private sealed class Class87
	{
		public fTienIchCheckTinsoft E1B85F20;

		public int E20961B4;

		internal void method_0()
		{
			try
			{
				for (int i = 0; i < E1B85F20.B401EA34.RowCount; i++)
				{
					Thread thread = new Thread(new D9A2B92D
					{
						class87_0 = this,
						int_0 = i
					}.ED0AEC25);
					thread.IsBackground = true;
					thread.Start();
				}
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class D9A2B92D
	{
		public int int_0;

		public Class87 class87_0;

		internal void ED0AEC25()
		{
			try
			{
				string text = class87_0.E1B85F20.B401EA34.Rows[int_0].Cells["cProxy"].Value.ToString();
				string bB1C838D = "";
				switch (class87_0.E20961B4)
				{
				case 0:
					bB1C838D = GClass8.smethod_1("http://proxy.tinsoftsv.com/api/getKeyInfo.php?key=" + text);
					break;
				case 1:
					bB1C838D = GClass8.smethod_1("http://proxy.tinsoftsv.com/api/getProxy.php?key=" + text);
					break;
				case 2:
					bB1C838D = GClass8.smethod_1("http://proxy.tinsoftsv.com/api/changeProxy.php?key=" + text + "&location=0");
					break;
				}
				GClass27.smethod_5(class87_0.E1B85F20.B401EA34, int_0, "cStatus", bB1C838D);
			}
			catch
			{
			}
		}
	}

	private bool bool_0 = false;

	public static List<string> list_0;

	public static List<string> FAAFEEA3;

	public static bool AD8352BB;

	private IContainer DB14EC11 = null;

	private BunifuCards B9324517;

	private Panel pnlHeader;

	private BunifuCustomLabel AD83C8A5;

	private Button btnMinimize;

	private BunifuDragControl C213E199;

	private PictureBox DC21C7B2;

	public DataGridView B401EA34;

	private RichTextBox txtListProxy;

	private Label label17;

	private Label B4171915;

	private DataGridViewTextBoxColumn cStt;

	private DataGridViewTextBoxColumn cProxy;

	private DataGridViewTextBoxColumn cStatus;

	private Button C339EBA0;

	private Button button1;

	private Button A90AEE3A;

	public fTienIchCheckTinsoft(bool A9984199 = false)
	{
		C3AD8AA3();
		AD8352BB = false;
		bool_0 = A9984199;
		F7AB102E.D6B70A35(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void AF96C887(object sender, EventArgs e)
	{
		AD8352BB = true;
		if (bool_0)
		{
			FAAFEEA3 = new List<string>();
			for (int i = 0; i < B401EA34.Rows.Count; i++)
			{
				if (Convert.ToBoolean(B401EA34.Rows[i].Cells["cChose"].Value))
				{
					FAAFEEA3.Add(GClass27.smethod_3(B401EA34, i, "cId"));
				}
			}
			if (FAAFEEA3.Count == 0)
			{
				GClass29.smethod_0(F7AB102E.smethod_0("Vui lòng chọn ít nhất 1 thư mục!"), 2);
				return;
			}
		}
		else
		{
			list_0 = new List<string>();
			for (int j = 0; j < B401EA34.Rows.Count; j++)
			{
				if (Convert.ToBoolean(B401EA34.Rows[j].Cells["cChose"].Value))
				{
					list_0.Add(GClass27.smethod_3(B401EA34, j, "cId"));
				}
			}
			if (list_0.Count == 0)
			{
				GClass29.smethod_0(F7AB102E.smethod_0("Vui lòng chọn ít nhất 1 thư mục!"), 2);
				return;
			}
		}
		Close();
	}

	private void E7BABCAB(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			if (Convert.ToBoolean(B401EA34.CurrentRow.Cells["cChose"].Value))
			{
				B401EA34.CurrentRow.Cells["cChose"].Value = false;
			}
			else
			{
				B401EA34.CurrentRow.Cells["cChose"].Value = true;
			}
		}
		catch
		{
		}
	}

	private int F886A823()
	{
		int num = 0;
		for (int i = 0; i < B401EA34.Rows.Count; i++)
		{
			if (Convert.ToBoolean(B401EA34.Rows[i].Cells["cChose"].Value))
			{
				num++;
			}
		}
		return num;
	}

	private void A03A4AA7(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex != 0)
		{
			return;
		}
		try
		{
			if (Convert.ToBoolean(B401EA34.CurrentRow.Cells["cChose"].Value))
			{
				B401EA34.CurrentRow.Cells["cChose"].Value = false;
			}
			else
			{
				B401EA34.CurrentRow.Cells["cChose"].Value = true;
			}
		}
		catch
		{
		}
	}

	private void txtListProxy_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtListProxy, label17);
	}

	private void method_0(int int_0)
	{
		if (txtListProxy.Text.Trim() == "")
		{
			GClass29.smethod_0("Vui lòng nhập proxy trước!", 3);
			txtListProxy.Focus();
			return;
		}
		List<string> e03C713E = txtListProxy.Lines.ToList();
		e03C713E = GClass8.smethod_36(e03C713E);
		B401EA34.Rows.Clear();
		for (int i = 0; i < e03C713E.Count; i++)
		{
			B401EA34.Rows.Add(i + 1, e03C713E[i], "Đang check...");
		}
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				for (int j = 0; j < B401EA34.RowCount; j++)
				{
					int int_ = j;
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						try
						{
							string text = B401EA34.Rows[int_].Cells["cProxy"].Value.ToString();
							string bB1C838D = "";
							switch (int_0)
							{
							case 0:
								bB1C838D = GClass8.smethod_1("http://proxy.tinsoftsv.com/api/getKeyInfo.php?key=" + text);
								break;
							case 1:
								bB1C838D = GClass8.smethod_1("http://proxy.tinsoftsv.com/api/getProxy.php?key=" + text);
								break;
							case 2:
								bB1C838D = GClass8.smethod_1("http://proxy.tinsoftsv.com/api/changeProxy.php?key=" + text + "&location=0");
								break;
							}
							GClass27.smethod_5(B401EA34, int_, "cStatus", bB1C838D);
						}
						catch
						{
						}
					});
					thread2.IsBackground = true;
					thread2.Start();
				}
			}
			catch
			{
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void C339EBA0_Click(object sender, EventArgs e)
	{
		method_0(0);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		method_0(1);
	}

	private void E3142B87(object sender, EventArgs e)
	{
		method_0(2);
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && DB14EC11 != null)
		{
			DB14EC11.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void C3AD8AA3()
	{
		DB14EC11 = new Container();
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		B9324517 = new BunifuCards();
		pnlHeader = new Panel();
		DC21C7B2 = new PictureBox();
		btnMinimize = new Button();
		AD83C8A5 = new BunifuCustomLabel();
		C213E199 = new BunifuDragControl(DB14EC11);
		B401EA34 = new DataGridView();
		cStt = new DataGridViewTextBoxColumn();
		cProxy = new DataGridViewTextBoxColumn();
		cStatus = new DataGridViewTextBoxColumn();
		txtListProxy = new RichTextBox();
		label17 = new Label();
		B4171915 = new Label();
		C339EBA0 = new Button();
		button1 = new Button();
		A90AEE3A = new Button();
		B9324517.SuspendLayout();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)DC21C7B2).BeginInit();
		((ISupportInitialize)B401EA34).BeginInit();
		SuspendLayout();
		B9324517.BackColor = Color.White;
		B9324517.BorderRadius = 0;
		B9324517.BottomSahddow = true;
		B9324517.color = Color.SaddleBrown;
		B9324517.Controls.Add(pnlHeader);
		B9324517.Dock = DockStyle.Top;
		B9324517.LeftSahddow = false;
		B9324517.Location = new Point(0, 0);
		B9324517.Name = "bunifuCards1";
		B9324517.RightSahddow = true;
		B9324517.ShadowDepth = 20;
		B9324517.Size = new Size(675, 34);
		B9324517.TabIndex = 0;
		pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(DC21C7B2);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(AD83C8A5);
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(675, 28);
		pnlHeader.TabIndex = 9;
		DC21C7B2.Cursor = Cursors.Default;
		DC21C7B2.Image = C50FB39E.Bitmap_5;
		DC21C7B2.Location = new Point(3, 2);
		DC21C7B2.Name = "pictureBox1";
		DC21C7B2.Size = new Size(34, 27);
		DC21C7B2.SizeMode = PictureBoxSizeMode.Zoom;
		DC21C7B2.TabIndex = 17;
		DC21C7B2.TabStop = false;
		btnMinimize.Cursor = Cursors.Hand;
		btnMinimize.Dock = DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = FlatStyle.Flat;
		btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = Color.White;
		btnMinimize.Image = C50FB39E.Bitmap_12;
		btnMinimize.Location = new Point(643, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new Size(32, 28);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += btnMinimize_Click;
		AD83C8A5.BackColor = Color.Transparent;
		AD83C8A5.Cursor = Cursors.SizeAll;
		AD83C8A5.Dock = DockStyle.Fill;
		AD83C8A5.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		AD83C8A5.ForeColor = Color.Black;
		AD83C8A5.Location = new Point(0, 0);
		AD83C8A5.Name = "bunifuCustomLabel1";
		AD83C8A5.Size = new Size(675, 28);
		AD83C8A5.TabIndex = 1;
		AD83C8A5.Text = "Check status Tinsoft";
		AD83C8A5.TextAlign = ContentAlignment.MiddleCenter;
		C213E199.Fixed = true;
		C213E199.Horizontal = true;
		C213E199.TargetControl = AD83C8A5;
		C213E199.Vertical = true;
		B401EA34.AllowUserToAddRows = false;
		B401EA34.AllowUserToDeleteRows = false;
		B401EA34.AllowUserToResizeRows = false;
		B401EA34.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		B401EA34.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = SystemColors.Control;
		dataGridViewCellStyle.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		B401EA34.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		B401EA34.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		B401EA34.Columns.AddRange(cStt, cProxy, cStatus);
		B401EA34.Location = new Point(15, 318);
		B401EA34.Name = "dtgv";
		B401EA34.ReadOnly = true;
		B401EA34.RowHeadersVisible = false;
		B401EA34.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		B401EA34.Size = new Size(644, 211);
		B401EA34.TabIndex = 7;
		B401EA34.CellClick += A03A4AA7;
		B401EA34.CellDoubleClick += E7BABCAB;
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
		cStt.DefaultCellStyle = dataGridViewCellStyle2;
		cStt.HeaderText = "STT";
		cStt.Name = "cStt";
		cStt.ReadOnly = true;
		cStt.Resizable = DataGridViewTriState.False;
		cStt.Width = 35;
		cProxy.HeaderText = "Proxy";
		cProxy.Name = "cProxy";
		cProxy.ReadOnly = true;
		cProxy.Width = 90;
		cStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		cStatus.HeaderText = "Status";
		cStatus.Name = "cStatus";
		cStatus.ReadOnly = true;
		txtListProxy.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		txtListProxy.BorderStyle = BorderStyle.FixedSingle;
		txtListProxy.Font = new Font("Tahoma", 9.75f);
		txtListProxy.Location = new Point(15, 68);
		txtListProxy.Name = "txtListProxy";
		txtListProxy.Size = new Size(644, 182);
		txtListProxy.TabIndex = 146;
		txtListProxy.Text = "";
		txtListProxy.WordWrap = false;
		txtListProxy.TextChanged += txtListProxy_TextChanged;
		label17.AutoSize = true;
		label17.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label17.Location = new Point(12, 49);
		label17.Name = "label17";
		label17.Size = new Size(103, 16);
		label17.TabIndex = 145;
		label17.Text = "Nhập Apikey (0):";
		B4171915.AutoSize = true;
		B4171915.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		B4171915.Location = new Point(12, 299);
		B4171915.Name = "label1";
		B4171915.Size = new Size(55, 16);
		B4171915.TabIndex = 145;
		B4171915.Text = "Kết quả:";
		C339EBA0.BackColor = Color.Green;
		C339EBA0.Cursor = Cursors.Hand;
		C339EBA0.FlatAppearance.BorderSize = 0;
		C339EBA0.FlatStyle = FlatStyle.Flat;
		C339EBA0.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C339EBA0.ForeColor = Color.White;
		C339EBA0.Location = new Point(147, 256);
		C339EBA0.Name = "btnCheck";
		C339EBA0.Size = new Size(114, 33);
		C339EBA0.TabIndex = 147;
		C339EBA0.Text = "Get key info";
		C339EBA0.UseVisualStyleBackColor = false;
		C339EBA0.Click += C339EBA0_Click;
		button1.BackColor = Color.Green;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Location = new Point(283, 256);
		button1.Name = "button1";
		button1.Size = new Size(104, 33);
		button1.TabIndex = 147;
		button1.Text = "Get proxy";
		button1.UseVisualStyleBackColor = false;
		button1.Click += button1_Click;
		A90AEE3A.BackColor = Color.Green;
		A90AEE3A.Cursor = Cursors.Hand;
		A90AEE3A.FlatAppearance.BorderSize = 0;
		A90AEE3A.FlatStyle = FlatStyle.Flat;
		A90AEE3A.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		A90AEE3A.ForeColor = Color.White;
		A90AEE3A.Location = new Point(407, 256);
		A90AEE3A.Name = "button2";
		A90AEE3A.Size = new Size(108, 33);
		A90AEE3A.TabIndex = 147;
		A90AEE3A.Text = "Change proxy";
		A90AEE3A.UseVisualStyleBackColor = false;
		A90AEE3A.Click += E3142B87;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(675, 547);
		base.Controls.Add(A90AEE3A);
		base.Controls.Add(button1);
		base.Controls.Add(C339EBA0);
		base.Controls.Add(txtListProxy);
		base.Controls.Add(B4171915);
		base.Controls.Add(label17);
		base.Controls.Add(B401EA34);
		base.Controls.Add(B9324517);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fTienIchCheckTinsoft";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fAddFile";
		B9324517.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)DC21C7B2).EndInit();
		((ISupportInitialize)B401EA34).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
