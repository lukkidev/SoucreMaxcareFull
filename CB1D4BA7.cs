using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class CB1D4BA7 : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string string_1;

	private string C024809A;

	private int int_0;

	public static bool E9302500;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown nudTimeTo;

	private NumericUpDown F3B755B8;

	private TextBox txtTenHanhDong;

	private Label BD8D52A1;

	private Label D51BBC82;

	private Label E8BDC40D;

	private Label label1;

	private Button C220BD98;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox AD9FEBAB;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label AE150734;

	private RichTextBox E613AEBB;

	public CB1D4BA7(string FA39B99B, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		E9302500 = false;
		string_0 = FA39B99B;
		C024809A = string_2;
		int_0 = int_1;
		if (Class147.smethod_7("", "HDBuffViewVideo").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDBuffViewVideo', 'Buff View Video');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDBuffViewVideo");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_2);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void CB1D4BA7_Load(object sender, EventArgs e)
	{
		try
		{
			F3B755B8.Value = gclass11_0.method_2("nudTimeFrom", 30);
			nudTimeTo.Value = gclass11_0.method_2("nudTimeTo", 30);
			E613AEBB.Text = gclass11_0.C0288288("txtUid");
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B2300184(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> e03C713E = E613AEBB.Lines.ToList();
		e03C713E = GClass8.smethod_36(e03C713E);
		if (e03C713E.Count == 0)
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Uid ca\u0301 nhân!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudTimeFrom", F3B755B8.Value);
		gClass.method_4("nudTimeTo", nudTimeTo.Value);
		gClass.method_4("txtUid", E613AEBB.Text.Trim());
		string string_ = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, string_))
				{
					E9302500 = true;
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
			if (Class147.smethod_13(C024809A, text, string_))
			{
				E9302500 = true;
				Close();
			}
			else
			{
				GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void C220BD98_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = E613AEBB.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			AE150734.Text = string.Format(F7AB102E.smethod_0("Nhập danh sách ID Video ({0}):"), e03C713E.Count.ToString());
		}
		catch
		{
		}
	}

	private void E613AEBB_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(E613AEBB, AE150734);
	}

	protected override void Dispose(bool B482ED19)
	{
		if (B482ED19 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B482ED19);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		AD9FEBAB = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		AE150734 = new System.Windows.Forms.Label();
		nudTimeTo = new System.Windows.Forms.NumericUpDown();
		F3B755B8 = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		BD8D52A1 = new System.Windows.Forms.Label();
		D51BBC82 = new System.Windows.Forms.Label();
		E8BDC40D = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		C220BD98 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		E613AEBB = new System.Windows.Forms.RichTextBox();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)AD9FEBAB).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudTimeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)F3B755B8).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Buff View Video";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(AD9FEBAB);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(359, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = C50FB39E.Bitmap_12;
		button1.Location = new System.Drawing.Point(328, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		AD9FEBAB.Cursor = System.Windows.Forms.Cursors.Default;
		AD9FEBAB.Image = C50FB39E.Bitmap_5;
		AD9FEBAB.Location = new System.Drawing.Point(3, 2);
		AD9FEBAB.Name = "pictureBox1";
		AD9FEBAB.Size = new System.Drawing.Size(34, 27);
		AD9FEBAB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		AD9FEBAB.TabIndex = 76;
		AD9FEBAB.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(E613AEBB);
		panel1.Controls.Add(AE150734);
		panel1.Controls.Add(nudTimeTo);
		panel1.Controls.Add(F3B755B8);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(BD8D52A1);
		panel1.Controls.Add(D51BBC82);
		panel1.Controls.Add(E8BDC40D);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(C220BD98);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 392);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		AE150734.AutoSize = true;
		AE150734.Location = new System.Drawing.Point(27, 105);
		AE150734.Name = "label2";
		AE150734.Size = new System.Drawing.Size(203, 16);
		AE150734.TabIndex = 40;
		AE150734.Text = "Nhập danh sách ID/Link Video (0):";
		nudTimeTo.Location = new System.Drawing.Point(231, 78);
		nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeTo.Name = "nudTimeTo";
		nudTimeTo.Size = new System.Drawing.Size(56, 23);
		nudTimeTo.TabIndex = 4;
		F3B755B8.Location = new System.Drawing.Point(134, 78);
		F3B755B8.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F3B755B8.Name = "nudTimeFrom";
		F3B755B8.Size = new System.Drawing.Size(56, 23);
		F3B755B8.TabIndex = 3;
		txtTenHanhDong.Location = new System.Drawing.Point(134, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		BD8D52A1.Location = new System.Drawing.Point(196, 80);
		BD8D52A1.Name = "label7";
		BD8D52A1.Size = new System.Drawing.Size(29, 16);
		BD8D52A1.TabIndex = 38;
		BD8D52A1.Text = "đê\u0301n";
		BD8D52A1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D51BBC82.AutoSize = true;
		D51BBC82.Location = new System.Drawing.Point(289, 80);
		D51BBC82.Name = "label6";
		D51BBC82.Size = new System.Drawing.Size(30, 16);
		D51BBC82.TabIndex = 36;
		D51BBC82.Text = "giây";
		E8BDC40D.AutoSize = true;
		E8BDC40D.Location = new System.Drawing.Point(27, 80);
		E8BDC40D.Name = "label5";
		E8BDC40D.Size = new System.Drawing.Size(93, 16);
		E8BDC40D.TabIndex = 34;
		E8BDC40D.Text = "Thời gian xem:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		C220BD98.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		C220BD98.BackColor = System.Drawing.Color.Maroon;
		C220BD98.Cursor = System.Windows.Forms.Cursors.Hand;
		C220BD98.FlatAppearance.BorderSize = 0;
		C220BD98.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C220BD98.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C220BD98.ForeColor = System.Drawing.Color.White;
		C220BD98.Location = new System.Drawing.Point(188, 350);
		C220BD98.Name = "btnCancel";
		C220BD98.Size = new System.Drawing.Size(92, 29);
		C220BD98.TabIndex = 10;
		C220BD98.Text = "Đóng";
		C220BD98.UseVisualStyleBackColor = false;
		C220BD98.Click += new System.EventHandler(C220BD98_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(81, 350);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(B2300184);
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
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		E613AEBB.Location = new System.Drawing.Point(31, 125);
		E613AEBB.Name = "txtUid";
		E613AEBB.Size = new System.Drawing.Size(297, 216);
		E613AEBB.TabIndex = 41;
		E613AEBB.Text = "";
		E613AEBB.WordWrap = false;
		E613AEBB.TextChanged += new System.EventHandler(E613AEBB_TextChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 392);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBuffViewVideo";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(CB1D4BA7_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)AD9FEBAB).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudTimeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)F3B755B8).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
