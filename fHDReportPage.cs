using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDReportPage : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool D532B183;

	private IContainer EB34C917 = null;

	private BunifuDragControl DD03423E;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown AB045E8D;

	private TextBox A6BF0E14;

	private Label CF01D08E;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button D40E8386;

	private PictureBox E6AA1DB7;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown AD96158F;

	private NumericUpDown B5AA52BA;

	private Label label7;

	private Label label5;

	private Label CAAF4F8C;

	private RichTextBox CC9AD82A;

	public fHDReportPage(string AC916FA7, int int_1 = 0, string string_3 = "")
	{
		FC1E3ABA();
		D532B183 = false;
		string_0 = AC916FA7;
		string_2 = string_3;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Report page";
		Class147.smethod_8(text, text2);
		string text3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			A6BF0E14.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_3);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			A6BF0E14.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void A3B55B39(object sender, EventArgs e)
	{
		try
		{
			AB045E8D.Value = gclass11_0.method_2("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass11_0.method_2("nudSoLuongTo", 1);
			B5AA52BA.Value = gclass11_0.method_2("nudDelayFrom", 10);
			AD96158F.Value = gclass11_0.method_2("nudDelayTo", 15);
			CC9AD82A.Text = gclass11_0.C0288288("txtId");
		}
		catch
		{
		}
	}

	private void D40E8386_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A13BB73D(object sender, EventArgs e)
	{
		string text = A6BF0E14.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", AB045E8D.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudDelayFrom", B5AA52BA.Value);
		gClass.method_4("nudDelayTo", AD96158F.Value);
		gClass.method_4("txtId", CC9AD82A.Text);
		string text2 = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, text2))
				{
					D532B183 = true;
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
				D532B183 = true;
				Close();
			}
			else
			{
				GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
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

	private void EB1F6BAD(object sender, EventArgs e)
	{
		GClass8.smethod_60(CC9AD82A, CAAF4F8C);
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && EB34C917 != null)
		{
			EB34C917.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void FC1E3ABA()
	{
		EB34C917 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDReportPage));
		DD03423E = new BunifuDragControl(EB34C917);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(EB34C917);
		pnlHeader = new Panel();
		D40E8386 = new Button();
		E6AA1DB7 = new PictureBox();
		panel1 = new Panel();
		CAAF4F8C = new Label();
		CC9AD82A = new RichTextBox();
		AD96158F = new NumericUpDown();
		B5AA52BA = new NumericUpDown();
		label7 = new Label();
		label5 = new Label();
		nudSoLuongTo = new NumericUpDown();
		AB045E8D = new NumericUpDown();
		A6BF0E14 = new TextBox();
		CF01D08E = new Label();
		label2 = new Label();
		label1 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		bunifuCards1 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)E6AA1DB7).BeginInit();
		panel1.SuspendLayout();
		((ISupportInitialize)AD96158F).BeginInit();
		((ISupportInitialize)B5AA52BA).BeginInit();
		((ISupportInitialize)nudSoLuongTo).BeginInit();
		((ISupportInitialize)AB045E8D).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		DD03423E.Fixed = true;
		DD03423E.Horizontal = true;
		DD03423E.TargetControl = bunifuCustomLabel1;
		DD03423E.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(314, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Report page";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(D40E8386);
		pnlHeader.Controls.Add(E6AA1DB7);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(314, 31);
		pnlHeader.TabIndex = 9;
		D40E8386.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		D40E8386.Cursor = Cursors.Hand;
		D40E8386.FlatAppearance.BorderSize = 0;
		D40E8386.FlatStyle = FlatStyle.Flat;
		D40E8386.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		D40E8386.ForeColor = Color.White;
		D40E8386.Image = (Image)componentResourceManager.GetObject("button1.Image");
		D40E8386.Location = new Point(283, 1);
		D40E8386.Name = "button1";
		D40E8386.Size = new Size(30, 30);
		D40E8386.TabIndex = 77;
		D40E8386.TextImageRelation = TextImageRelation.ImageBeforeText;
		D40E8386.UseVisualStyleBackColor = true;
		D40E8386.Click += D40E8386_Click;
		E6AA1DB7.Cursor = Cursors.Default;
		E6AA1DB7.Image = C50FB39E.Bitmap_5;
		E6AA1DB7.Location = new Point(3, 2);
		E6AA1DB7.Name = "pictureBox1";
		E6AA1DB7.Size = new Size(34, 27);
		E6AA1DB7.SizeMode = PictureBoxSizeMode.Zoom;
		E6AA1DB7.TabIndex = 76;
		E6AA1DB7.TabStop = false;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(CAAF4F8C);
		panel1.Controls.Add(CC9AD82A);
		panel1.Controls.Add(AD96158F);
		panel1.Controls.Add(B5AA52BA);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(AB045E8D);
		panel1.Controls.Add(A6BF0E14);
		panel1.Controls.Add(CF01D08E);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(317, 347);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		CAAF4F8C.AutoSize = true;
		CAAF4F8C.Location = new Point(27, 77);
		CAAF4F8C.Name = "lblId";
		CAAF4F8C.Size = new Size(193, 16);
		CAAF4F8C.TabIndex = 49;
		CAAF4F8C.Text = "Danh sách Id hoặc link page (0):";
		CC9AD82A.Location = new Point(30, 96);
		CC9AD82A.Name = "txtId";
		CC9AD82A.Size = new Size(255, 195);
		CC9AD82A.TabIndex = 48;
		CC9AD82A.Text = "";
		CC9AD82A.WordWrap = false;
		CC9AD82A.TextChanged += EB1F6BAD;
		AD96158F.Location = new Point(229, 135);
		AD96158F.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		AD96158F.Name = "nudDelayTo";
		AD96158F.Size = new Size(56, 23);
		AD96158F.TabIndex = 4;
		AD96158F.Visible = false;
		B5AA52BA.Location = new Point(132, 135);
		B5AA52BA.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		B5AA52BA.Name = "nudDelayFrom";
		B5AA52BA.Size = new Size(56, 23);
		B5AA52BA.TabIndex = 3;
		B5AA52BA.Visible = false;
		label7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label7.Location = new Point(194, 137);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = ">";
		label7.TextAlign = ContentAlignment.MiddleCenter;
		label7.Visible = false;
		label5.AutoSize = true;
		label5.Location = new Point(27, 137);
		label5.Name = "label5";
		label5.Size = new Size(87, 16);
		label5.TabIndex = 44;
		label5.Text = "Gia\u0303n ca\u0301ch (s):";
		label5.Visible = false;
		nudSoLuongTo.Location = new Point(229, 106);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudSoLuongTo.Visible = false;
		AB045E8D.Location = new Point(132, 106);
		AB045E8D.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		AB045E8D.Name = "nudSoLuongFrom";
		AB045E8D.Size = new Size(56, 23);
		AB045E8D.TabIndex = 1;
		AB045E8D.Visible = false;
		A6BF0E14.Location = new Point(132, 49);
		A6BF0E14.Name = "txtTenHanhDong";
		A6BF0E14.Size = new Size(153, 23);
		A6BF0E14.TabIndex = 0;
		CF01D08E.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		CF01D08E.Location = new Point(194, 108);
		CF01D08E.Name = "label3";
		CF01D08E.Size = new Size(29, 16);
		CF01D08E.TabIndex = 37;
		CF01D08E.Text = ">";
		CF01D08E.TextAlign = ContentAlignment.MiddleCenter;
		CF01D08E.Visible = false;
		label2.AutoSize = true;
		label2.Location = new Point(27, 108);
		label2.Name = "label2";
		label2.Size = new Size(63, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng:";
		label2.Visible = false;
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(164, 304);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(57, 304);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += A13BB73D;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(314, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(317, 347);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDReportPage";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += A3B55B39;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)E6AA1DB7).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		((ISupportInitialize)AD96158F).EndInit();
		((ISupportInitialize)B5AA52BA).EndInit();
		((ISupportInitialize)nudSoLuongTo).EndInit();
		((ISupportInitialize)AB045E8D).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
