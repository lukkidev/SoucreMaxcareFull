using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDChangeTenPhu : Form
{
	private GClass11 CD164C85 = null;

	private string string_0;

	private string string_1;

	private string string_2;

	private int B90A6C10;

	public static bool F71F40BC;

	private IContainer F79F26A0 = null;

	private BunifuDragControl BAB35D21;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private TextBox A3265E08;

	private Label label1;

	private Button E609EE87;

	private Button C9151993;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private RichTextBox txtTenPhu;

	private Label label2;

	public fHDChangeTenPhu(string string_3, int D00CBF1D = 0, string string_4 = "")
	{
		BCA5CBBA();
		F71F40BC = false;
		string_0 = string_3;
		string_2 = string_4;
		B90A6C10 = D00CBF1D;
		if (Class147.smethod_7("", "HDChangeTenPhu").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDChangeTenPhu', 'Thay đổi tên phụ');");
		}
		string text = "";
		switch (D00CBF1D)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDChangeTenPhu");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			A3265E08.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_4);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			C9151993.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			A3265E08.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		CD164C85 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(label1);
		F7AB102E.smethod_1(C9151993);
		F7AB102E.smethod_1(E609EE87);
	}

	private void D89EA99C(object sender, EventArgs e)
	{
		try
		{
			txtTenPhu.Text = CD164C85.C0288288("txtTenPhu");
		}
		catch
		{
		}
		txtTenPhu_TextChanged(null, null);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C9151993_Click(object sender, EventArgs e)
	{
		string text = A3265E08.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("txtTenPhu", txtTenPhu.Text.Trim());
		string text2 = gClass.method_7();
		if (B90A6C10 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, text2))
				{
					F71F40BC = true;
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
				F71F40BC = true;
				Close();
			}
			else
			{
				GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void EAB99B94(object sender, EventArgs e)
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

	private void txtTenPhu_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtTenPhu.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			label2.Text = string.Format(F7AB102E.smethod_0("Danh sa\u0301ch tên phụ ({0}):"), e03C713E.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool D1B95338)
	{
		if (D1B95338 && F79F26A0 != null)
		{
			F79F26A0.Dispose();
		}
		base.Dispose(D1B95338);
	}

	private void BCA5CBBA()
	{
		F79F26A0 = new Container();
		BAB35D21 = new BunifuDragControl(F79F26A0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(F79F26A0);
		pnlHeader = new Panel();
		pictureBox1 = new PictureBox();
		button1 = new Button();
		panel1 = new Panel();
		txtTenPhu = new RichTextBox();
		label2 = new Label();
		A3265E08 = new TextBox();
		label1 = new Label();
		E609EE87 = new Button();
		C9151993 = new Button();
		bunifuCards1 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		BAB35D21.Fixed = true;
		BAB35D21.Horizontal = true;
		BAB35D21.TargetControl = bunifuCustomLabel1;
		BAB35D21.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(358, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Thay đổi tên phụ";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(358, 31);
		pnlHeader.TabIndex = 9;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = C50FB39E.Bitmap_12;
		button1.Location = new Point(325, 5);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += button1_Click;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(txtTenPhu);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(A3265E08);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(E609EE87);
		panel1.Controls.Add(C9151993);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(360, 348);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		txtTenPhu.Location = new Point(30, 95);
		txtTenPhu.Name = "txtTenPhu";
		txtTenPhu.Size = new Size(296, 189);
		txtTenPhu.TabIndex = 41;
		txtTenPhu.Text = "";
		txtTenPhu.WordWrap = false;
		txtTenPhu.TextChanged += txtTenPhu_TextChanged;
		label2.AutoSize = true;
		label2.Location = new Point(27, 75);
		label2.Name = "label2";
		label2.Size = new Size(139, 16);
		label2.TabIndex = 43;
		label2.Text = "Danh sa\u0301ch tên phụ (0):";
		A3265E08.Location = new Point(132, 49);
		A3265E08.Name = "txtTenHanhDong";
		A3265E08.Size = new Size(194, 23);
		A3265E08.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		E609EE87.Anchor = AnchorStyles.Bottom;
		E609EE87.BackColor = Color.Maroon;
		E609EE87.Cursor = Cursors.Hand;
		E609EE87.FlatAppearance.BorderSize = 0;
		E609EE87.FlatStyle = FlatStyle.Flat;
		E609EE87.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		E609EE87.ForeColor = Color.White;
		E609EE87.Location = new Point(187, 303);
		E609EE87.Name = "btnCancel";
		E609EE87.Size = new Size(92, 29);
		E609EE87.TabIndex = 10;
		E609EE87.Text = "Đóng";
		E609EE87.UseVisualStyleBackColor = false;
		E609EE87.Click += EAB99B94;
		C9151993.Anchor = AnchorStyles.Bottom;
		C9151993.BackColor = Color.FromArgb(53, 120, 229);
		C9151993.Cursor = Cursors.Hand;
		C9151993.FlatAppearance.BorderSize = 0;
		C9151993.FlatStyle = FlatStyle.Flat;
		C9151993.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C9151993.ForeColor = Color.White;
		C9151993.Location = new Point(80, 303);
		C9151993.Name = "btnAdd";
		C9151993.Size = new Size(92, 29);
		C9151993.TabIndex = 9;
		C9151993.Text = "Thêm";
		C9151993.UseVisualStyleBackColor = false;
		C9151993.Click += C9151993_Click;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(button1);
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(358, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(360, 348);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDChangeTenPhu";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += D89EA99C;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
