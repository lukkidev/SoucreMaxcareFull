using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class A1276B03 : Form
{
	private GClass11 gclass11_0 = null;

	private string string_0;

	private string string_1;

	private string string_2;

	private int CD20EDB3;

	public static bool D7224B0E;

	private IContainer B3B91A02 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel B2BE9E2C;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private TextBox FEA65E20;

	private Label label7;

	private Label label5;

	private Label F10171B3;

	private Button FC3CC1AE;

	private Button B4097F80;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel C08C2B0B;

	public A1276B03(string C4BA0819, int int_0 = 0, string string_3 = "")
	{
		InitializeComponent();
		D7224B0E = false;
		string_0 = C4BA0819;
		string_2 = string_3;
		CD20EDB3 = int_0;
		if (Class147.smethod_7("", "HDNghiGiaiLao").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDNghiGiaiLao', 'Nghỉ giải lao');");
		}
		string text = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDNghiGiaiLao");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			FEA65E20.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			B4097F80.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			FEA65E20.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void A1276B03_Load(object sender, EventArgs e)
	{
		try
		{
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
		}
		catch
		{
		}
	}

	private void B7B17CA9(object sender, EventArgs e)
	{
		Close();
	}

	private void CB9234B0(object sender, EventArgs e)
	{
		string text = FEA65E20.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		string text2 = gClass.method_7();
		if (CD20EDB3 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, text2))
				{
					D7224B0E = true;
					Close();
				}
				else
				{
					GClass29.smethod_0("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
				}
			}
		}
		else if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") == DialogResult.Yes)
		{
			if (Class147.smethod_13(string_2, text, text2))
			{
				D7224B0E = true;
				Close();
			}
			else
			{
				GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void FC3CC1AE_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B2BE9E2C_Paint(object sender, PaintEventArgs e)
	{
		if (B2BE9E2C.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, B2BE9E2C.ClientSize.Width - num, B2BE9E2C.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && B3B91A02 != null)
		{
			B3B91A02.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		B3B91A02 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A1276B03));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(B3B91A02);
		C08C2B0B = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(B3B91A02);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		B2BE9E2C = new System.Windows.Forms.Panel();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		FEA65E20 = new System.Windows.Forms.TextBox();
		label7 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		F10171B3 = new System.Windows.Forms.Label();
		FC3CC1AE = new System.Windows.Forms.Button();
		B4097F80 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		B2BE9E2C.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = C08C2B0B;
		bunifuDragControl_0.Vertical = true;
		C08C2B0B.BackColor = System.Drawing.Color.Transparent;
		C08C2B0B.Cursor = System.Windows.Forms.Cursors.SizeAll;
		C08C2B0B.Dock = System.Windows.Forms.DockStyle.Fill;
		C08C2B0B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C08C2B0B.ForeColor = System.Drawing.Color.Black;
		C08C2B0B.Location = new System.Drawing.Point(0, 0);
		C08C2B0B.Name = "bunifuCustomLabel1";
		C08C2B0B.Size = new System.Drawing.Size(323, 31);
		C08C2B0B.TabIndex = 12;
		C08C2B0B.Text = "Cấu hình Nghỉ giải lao";
		C08C2B0B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(C08C2B0B);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(323, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(292, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(B7B17CA9);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		B2BE9E2C.BackColor = System.Drawing.Color.White;
		B2BE9E2C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		B2BE9E2C.Controls.Add(nudDelayTo);
		B2BE9E2C.Controls.Add(nudDelayFrom);
		B2BE9E2C.Controls.Add(FEA65E20);
		B2BE9E2C.Controls.Add(label7);
		B2BE9E2C.Controls.Add(label5);
		B2BE9E2C.Controls.Add(F10171B3);
		B2BE9E2C.Controls.Add(FC3CC1AE);
		B2BE9E2C.Controls.Add(B4097F80);
		B2BE9E2C.Controls.Add(bunifuCards1);
		B2BE9E2C.Cursor = System.Windows.Forms.Cursors.Arrow;
		B2BE9E2C.Dock = System.Windows.Forms.DockStyle.Fill;
		B2BE9E2C.Location = new System.Drawing.Point(0, 0);
		B2BE9E2C.Name = "panel1";
		B2BE9E2C.Size = new System.Drawing.Size(326, 160);
		B2BE9E2C.TabIndex = 0;
		B2BE9E2C.Paint += new System.Windows.Forms.PaintEventHandler(B2BE9E2C_Paint);
		nudDelayTo.Location = new System.Drawing.Point(234, 78);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(137, 78);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		FEA65E20.Location = new System.Drawing.Point(137, 49);
		FEA65E20.Name = "txtTenHanhDong";
		FEA65E20.Size = new System.Drawing.Size(153, 23);
		FEA65E20.TabIndex = 0;
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label7.Location = new System.Drawing.Point(199, 80);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = ">";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 80);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(109, 16);
		label5.TabIndex = 34;
		label5.Text = "Thơ\u0300i gian chơ\u0300 (s):";
		F10171B3.AutoSize = true;
		F10171B3.Location = new System.Drawing.Point(27, 52);
		F10171B3.Name = "label1";
		F10171B3.Size = new System.Drawing.Size(98, 16);
		F10171B3.TabIndex = 31;
		F10171B3.Text = "Tên ha\u0300nh đô\u0323ng:";
		FC3CC1AE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		FC3CC1AE.BackColor = System.Drawing.Color.Maroon;
		FC3CC1AE.Cursor = System.Windows.Forms.Cursors.Hand;
		FC3CC1AE.FlatAppearance.BorderSize = 0;
		FC3CC1AE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		FC3CC1AE.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		FC3CC1AE.ForeColor = System.Drawing.Color.White;
		FC3CC1AE.Location = new System.Drawing.Point(172, 116);
		FC3CC1AE.Name = "btnCancel";
		FC3CC1AE.Size = new System.Drawing.Size(92, 29);
		FC3CC1AE.TabIndex = 10;
		FC3CC1AE.Text = "Đóng";
		FC3CC1AE.UseVisualStyleBackColor = false;
		FC3CC1AE.Click += new System.EventHandler(FC3CC1AE_Click);
		B4097F80.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		B4097F80.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		B4097F80.Cursor = System.Windows.Forms.Cursors.Hand;
		B4097F80.FlatAppearance.BorderSize = 0;
		B4097F80.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B4097F80.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B4097F80.ForeColor = System.Drawing.Color.White;
		B4097F80.Location = new System.Drawing.Point(65, 116);
		B4097F80.Name = "btnAdd";
		B4097F80.Size = new System.Drawing.Size(92, 29);
		B4097F80.TabIndex = 9;
		B4097F80.Text = "Thêm";
		B4097F80.UseVisualStyleBackColor = false;
		B4097F80.Click += new System.EventHandler(CB9234B0);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(323, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(326, 160);
		base.Controls.Add(B2BE9E2C);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDNghiGiaiLao";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(A1276B03_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		B2BE9E2C.ResumeLayout(false);
		B2BE9E2C.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
