using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTruyCapWebsite : Form
{
	private GClass11 gclass11_0 = null;

	private string string_0;

	private string CCA0AAB3;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button AD38CA92;

	private PictureBox ACB21A3A;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label CD897D83;

	private RichTextBox txtLinkWeb;

	private NumericUpDown AA1CFA1E;

	private NumericUpDown D7108F13;

	private NumericUpDown nudCountLinkClickFrom;

	private NumericUpDown D5A8C638;

	private Label label17;

	private Label label13;

	private Label label16;

	private Label label11;

	private Label label15;

	private Label label9;

	private CheckBox A2A782A2;

	private NumericUpDown nudCountTimeScrollTo;

	private Label label2;

	private Label label3;

	private Label label4;

	private NumericUpDown nudCountTimeScrollFrom;

	public fHDTruyCapWebsite(string string_2, int int_1 = 0, string string_3 = "")
	{
		DCAA1D27();
		bool_0 = false;
		string_0 = string_2;
		string_1 = string_3;
		int_0 = int_1;
		if (Class147.smethod_7("", "HDTruyCapWebsite").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTruyCapWebsite', 'Truy cập Website');");
		}
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDTruyCapWebsite");
			CCA0AAB3 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void AB9F98A1(object sender, EventArgs e)
	{
		try
		{
			D5A8C638.Value = gclass11_0.method_2("nudCountLinkFrom", 1);
			D7108F13.Value = gclass11_0.method_2("nudCountLinkTo", 1);
			nudCountLinkClickFrom.Value = gclass11_0.method_2("nudCountLinkClickFrom", 3);
			AA1CFA1E.Value = gclass11_0.method_2("nudCountLinkClickTo", 5);
			nudCountTimeScrollFrom.Value = gclass11_0.method_2("nudCountTimeScrollFrom", 30);
			nudCountTimeScrollTo.Value = gclass11_0.method_2("nudCountTimeScrollTo", 30);
			txtLinkWeb.Text = gclass11_0.C0288288("txtLinkWeb");
			A2A782A2.Checked = gclass11_0.method_3("ckbLuot", bool_0: true);
		}
		catch
		{
		}
	}

	private void AD38CA92_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C52A8D9E(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudCountLinkFrom", D5A8C638.Value);
		gClass.method_4("nudCountLinkTo", D7108F13.Value);
		gClass.method_4("nudCountLinkClickFrom", nudCountLinkClickFrom.Value);
		gClass.method_4("nudCountLinkClickTo", AA1CFA1E.Value);
		gClass.method_4("nudCountTimeScrollFrom", nudCountTimeScrollFrom.Value);
		gClass.method_4("nudCountTimeScrollTo", nudCountTimeScrollTo.Value);
		gClass.method_4("txtLinkWeb", txtLinkWeb.Text.Trim());
		gClass.method_4("ckbLuot", A2A782A2.Checked);
		string string_ = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, CCA0AAB3, string_))
				{
					bool_0 = true;
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
			if (Class147.smethod_13(string_1, text, string_))
			{
				bool_0 = true;
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

	private void C0119833(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtLinkWeb.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			CD897D83.Text = string.Format(F7AB102E.smethod_0("Danh sa\u0301ch Link Web ({0}):"), e03C713E.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool D0A77B13)
	{
		if (D0A77B13 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(D0A77B13);
	}

	private void DCAA1D27()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDTruyCapWebsite));
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		AD38CA92 = new Button();
		ACB21A3A = new PictureBox();
		panel1 = new Panel();
		nudCountTimeScrollTo = new NumericUpDown();
		label2 = new Label();
		label3 = new Label();
		A2A782A2 = new CheckBox();
		label4 = new Label();
		txtLinkWeb = new RichTextBox();
		nudCountTimeScrollFrom = new NumericUpDown();
		CD897D83 = new Label();
		AA1CFA1E = new NumericUpDown();
		D7108F13 = new NumericUpDown();
		nudCountLinkClickFrom = new NumericUpDown();
		D5A8C638 = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		label17 = new Label();
		label13 = new Label();
		label16 = new Label();
		label11 = new Label();
		label15 = new Label();
		label9 = new Label();
		label1 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		bunifuCards1 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)ACB21A3A).BeginInit();
		panel1.SuspendLayout();
		((ISupportInitialize)nudCountTimeScrollTo).BeginInit();
		((ISupportInitialize)nudCountTimeScrollFrom).BeginInit();
		((ISupportInitialize)AA1CFA1E).BeginInit();
		((ISupportInitialize)D7108F13).BeginInit();
		((ISupportInitialize)nudCountLinkClickFrom).BeginInit();
		((ISupportInitialize)D5A8C638).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Truy cập Website";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(AD38CA92);
		pnlHeader.Controls.Add(ACB21A3A);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(359, 31);
		pnlHeader.TabIndex = 9;
		AD38CA92.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		AD38CA92.Cursor = Cursors.Hand;
		AD38CA92.FlatAppearance.BorderSize = 0;
		AD38CA92.FlatStyle = FlatStyle.Flat;
		AD38CA92.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		AD38CA92.ForeColor = Color.White;
		AD38CA92.Image = (Image)componentResourceManager.GetObject("button1.Image");
		AD38CA92.Location = new Point(328, 1);
		AD38CA92.Name = "button1";
		AD38CA92.Size = new Size(30, 30);
		AD38CA92.TabIndex = 77;
		AD38CA92.TextImageRelation = TextImageRelation.ImageBeforeText;
		AD38CA92.UseVisualStyleBackColor = true;
		AD38CA92.Click += AD38CA92_Click;
		ACB21A3A.Cursor = Cursors.Default;
		ACB21A3A.Image = C50FB39E.Bitmap_5;
		ACB21A3A.Location = new Point(3, 2);
		ACB21A3A.Name = "pictureBox1";
		ACB21A3A.Size = new Size(34, 27);
		ACB21A3A.SizeMode = PictureBoxSizeMode.Zoom;
		ACB21A3A.TabIndex = 76;
		ACB21A3A.TabStop = false;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(nudCountTimeScrollTo);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(A2A782A2);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(txtLinkWeb);
		panel1.Controls.Add(nudCountTimeScrollFrom);
		panel1.Controls.Add(CD897D83);
		panel1.Controls.Add(AA1CFA1E);
		panel1.Controls.Add(D7108F13);
		panel1.Controls.Add(nudCountLinkClickFrom);
		panel1.Controls.Add(D5A8C638);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label17);
		panel1.Controls.Add(label13);
		panel1.Controls.Add(label16);
		panel1.Controls.Add(label11);
		panel1.Controls.Add(label15);
		panel1.Controls.Add(label9);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(362, 419);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		nudCountTimeScrollTo.Location = new Point(263, 316);
		nudCountTimeScrollTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountTimeScrollTo.Name = "nudCountTimeScrollTo";
		nudCountTimeScrollTo.Size = new Size(36, 23);
		nudCountTimeScrollTo.TabIndex = 2;
		label2.AutoSize = true;
		label2.Location = new Point(28, 318);
		label2.Name = "label2";
		label2.Size = new Size(120, 16);
		label2.TabIndex = 32;
		label2.Text = "Thời gian trên web:";
		label3.AutoSize = true;
		label3.Location = new Point(299, 318);
		label3.Name = "label3";
		label3.Size = new Size(30, 16);
		label3.TabIndex = 35;
		label3.Text = "giây";
		A2A782A2.AutoSize = true;
		A2A782A2.Checked = true;
		A2A782A2.CheckState = CheckState.Checked;
		A2A782A2.Cursor = Cursors.Hand;
		A2A782A2.Location = new Point(30, 343);
		A2A782A2.Name = "ckbLuot";
		A2A782A2.Size = new Size(157, 20);
		A2A782A2.TabIndex = 43;
		A2A782A2.Text = "Tự động lướt trên Web";
		A2A782A2.UseVisualStyleBackColor = true;
		label4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label4.Location = new Point(231, 318);
		label4.Name = "label4";
		label4.Size = new Size(29, 16);
		label4.TabIndex = 37;
		label4.Text = ">";
		label4.TextAlign = ContentAlignment.MiddleCenter;
		txtLinkWeb.Location = new Point(30, 94);
		txtLinkWeb.Name = "txtLinkWeb";
		txtLinkWeb.Size = new Size(298, 160);
		txtLinkWeb.TabIndex = 42;
		txtLinkWeb.Text = "";
		txtLinkWeb.WordWrap = false;
		txtLinkWeb.TextChanged += C0119833;
		nudCountTimeScrollFrom.Location = new Point(192, 316);
		nudCountTimeScrollFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountTimeScrollFrom.Name = "nudCountTimeScrollFrom";
		nudCountTimeScrollFrom.Size = new Size(36, 23);
		nudCountTimeScrollFrom.TabIndex = 1;
		CD897D83.AutoSize = true;
		CD897D83.Location = new Point(27, 75);
		CD897D83.Name = "lblStatus";
		CD897D83.Size = new Size(148, 16);
		CD897D83.TabIndex = 0;
		CD897D83.Text = "Danh sa\u0301ch Link Web (0):";
		AA1CFA1E.Location = new Point(263, 288);
		AA1CFA1E.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		AA1CFA1E.Name = "nudCountLinkClickTo";
		AA1CFA1E.Size = new Size(36, 23);
		AA1CFA1E.TabIndex = 2;
		D7108F13.Location = new Point(263, 260);
		D7108F13.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D7108F13.Name = "nudCountLinkTo";
		D7108F13.Size = new Size(36, 23);
		D7108F13.TabIndex = 2;
		nudCountLinkClickFrom.Location = new Point(192, 288);
		nudCountLinkClickFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLinkClickFrom.Name = "nudCountLinkClickFrom";
		nudCountLinkClickFrom.Size = new Size(36, 23);
		nudCountLinkClickFrom.TabIndex = 1;
		D5A8C638.Location = new Point(192, 260);
		D5A8C638.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D5A8C638.Name = "nudCountLinkFrom";
		D5A8C638.Size = new Size(36, 23);
		D5A8C638.TabIndex = 1;
		txtTenHanhDong.Location = new Point(134, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label17.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label17.Location = new Point(231, 290);
		label17.Name = "label17";
		label17.Size = new Size(29, 16);
		label17.TabIndex = 37;
		label17.Text = ">";
		label17.TextAlign = ContentAlignment.MiddleCenter;
		label13.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label13.Location = new Point(231, 262);
		label13.Name = "label13";
		label13.Size = new Size(29, 16);
		label13.TabIndex = 37;
		label13.Text = ">";
		label13.TextAlign = ContentAlignment.MiddleCenter;
		label16.AutoSize = true;
		label16.Location = new Point(299, 290);
		label16.Name = "label16";
		label16.Size = new Size(26, 16);
		label16.TabIndex = 35;
		label16.Text = "link";
		label11.AutoSize = true;
		label11.Location = new Point(299, 262);
		label11.Name = "label11";
		label11.Size = new Size(26, 16);
		label11.TabIndex = 35;
		label11.Text = "link";
		label15.AutoSize = true;
		label15.Location = new Point(28, 290);
		label15.Name = "label15";
		label15.Size = new Size(164, 16);
		label15.TabIndex = 34;
		label15.Text = "Click random link trên web:";
		label9.AutoSize = true;
		label9.Location = new Point(27, 262);
		label9.Name = "label9";
		label9.Size = new Size(152, 16);
		label9.TabIndex = 32;
		label9.Text = "Sô\u0301 link web cần truy cập:";
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(189, 375);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(82, 375);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += C52A8D9E;
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
		bunifuCards1.Size = new Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(362, 419);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDTruyCapWebsite";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += AB9F98A1;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)ACB21A3A).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		((ISupportInitialize)nudCountTimeScrollTo).EndInit();
		((ISupportInitialize)nudCountTimeScrollFrom).EndInit();
		((ISupportInitialize)AA1CFA1E).EndInit();
		((ISupportInitialize)D7108F13).EndInit();
		((ISupportInitialize)nudCountLinkClickFrom).EndInit();
		((ISupportInitialize)D5A8C638).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
