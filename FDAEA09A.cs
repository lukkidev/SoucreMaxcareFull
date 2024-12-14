using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class FDAEA09A : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string C738B2BF;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private EFBBE9AB efbbe9AB_0;

	private IContainer E6168EBB = null;

	private BunifuDragControl DCBB1C2C;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards BB893A0C;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel D9BA9E30;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label BE1FC4BD;

	private Label D3B2D70C;

	private Panel plTuongTacBaiViet;

	private Panel panel2;

	private TabControl tabOptionsPost;

	private TabPage tabPage1;

	private Label FC92743A;

	private Label label3;

	private NumericUpDown E4B75CBE;

	private NumericUpDown nudSoLuongTo;

	private TabPage B1399B1B;

	private Label label8;

	private Label label9;

	private NumericUpDown nudThoiGianFrom;

	private NumericUpDown E72CAA1E;

	private ComboBox A281B22B;

	private Label label4;

	public FDAEA09A(string string_2, int int_1 = 0, string string_3 = "")
	{
		E8AF4E1C();
		bool_0 = false;
		string_0 = string_2;
		string_1 = string_3;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Bài viết trên tường";
		Class147.smethod_8(text, text2);
		string text3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDBaiVietTrenTuong");
			C738B2BF = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_3);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void CF03D3A8(object sender, EventArgs e)
	{
		F83CAD1B();
		try
		{
			A281B22B.SelectedIndex = gclass11_0.method_2("cbbOptionsPost");
			E4B75CBE.Value = gclass11_0.method_2("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass11_0.method_2("nudSoLuongTo", 2);
			nudThoiGianFrom.Value = gclass11_0.method_2("nudThoiGianFrom", 30);
			E72CAA1E.Value = gclass11_0.method_2("nudThoiGianTo", 30);
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
			efbbe9AB_0 = new EFBBE9AB(gclass11_0);
			plTuongTacBaiViet.Controls.Add(efbbe9AB_0);
		}
		catch
		{
		}
	}

	private void F83CAD1B()
	{
		List<string> list_ = new List<string> { "Giơ\u0301i ha\u0323n sô\u0301 ba\u0300i viê\u0301t tương ta\u0301c", "Giơ\u0301i ha\u0323n thơ\u0300i gian tương ta\u0301c" };
		GClass8.smethod_22(A281B22B, list_);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = efbbe9AB_0.F0B0B700();
		gClass.method_4("cbbOptionsPost", A281B22B.SelectedIndex);
		gClass.method_4("nudSoLuongFrom", E4B75CBE.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudThoiGianFrom", nudThoiGianFrom.Value);
		gClass.method_4("nudThoiGianTo", E72CAA1E.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		string string_ = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, C738B2BF, string_))
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

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
		}
	}

	private void D516D0AA(object sender, EventArgs e)
	{
		tabOptionsPost.SelectedIndex = A281B22B.SelectedIndex;
	}

	protected override void Dispose(bool FDBBFFB3)
	{
		if (FDBBFFB3 && E6168EBB != null)
		{
			E6168EBB.Dispose();
		}
		base.Dispose(FDBBFFB3);
	}

	private void E8AF4E1C()
	{
		E6168EBB = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FDAEA09A));
		DCBB1C2C = new BunifuDragControl(E6168EBB);
		D9BA9E30 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(E6168EBB);
		pnlHeader = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		plTuongTacBaiViet = new Panel();
		nudDelayTo = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		label7 = new Label();
		BE1FC4BD = new Label();
		D3B2D70C = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		BB893A0C = new BunifuCards();
		panel2 = new Panel();
		tabOptionsPost = new TabControl();
		tabPage1 = new TabPage();
		FC92743A = new Label();
		label3 = new Label();
		E4B75CBE = new NumericUpDown();
		nudSoLuongTo = new NumericUpDown();
		B1399B1B = new TabPage();
		label8 = new Label();
		label9 = new Label();
		nudThoiGianFrom = new NumericUpDown();
		E72CAA1E = new NumericUpDown();
		A281B22B = new ComboBox();
		label4 = new Label();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		BB893A0C.SuspendLayout();
		panel2.SuspendLayout();
		tabOptionsPost.SuspendLayout();
		tabPage1.SuspendLayout();
		((ISupportInitialize)E4B75CBE).BeginInit();
		((ISupportInitialize)nudSoLuongTo).BeginInit();
		B1399B1B.SuspendLayout();
		((ISupportInitialize)nudThoiGianFrom).BeginInit();
		((ISupportInitialize)E72CAA1E).BeginInit();
		SuspendLayout();
		DCBB1C2C.Fixed = true;
		DCBB1C2C.Horizontal = true;
		DCBB1C2C.TargetControl = D9BA9E30;
		DCBB1C2C.Vertical = true;
		D9BA9E30.BackColor = Color.Transparent;
		D9BA9E30.Cursor = Cursors.SizeAll;
		D9BA9E30.Dock = DockStyle.Fill;
		D9BA9E30.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		D9BA9E30.ForeColor = Color.Black;
		D9BA9E30.Location = new Point(0, 0);
		D9BA9E30.Name = "bunifuCustomLabel1";
		D9BA9E30.Size = new Size(717, 31);
		D9BA9E30.TabIndex = 12;
		D9BA9E30.Text = "Cấu hình Bài viết trên tường";
		D9BA9E30.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(D9BA9E30);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(717, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(686, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += button1_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += pictureBox1_Click;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(panel2);
		panel1.Controls.Add(plTuongTacBaiViet);
		panel1.Controls.Add(A281B22B);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(BE1FC4BD);
		panel1.Controls.Add(D3B2D70C);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(BB893A0C);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(720, 493);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		plTuongTacBaiViet.BorderStyle = BorderStyle.FixedSingle;
		plTuongTacBaiViet.Location = new Point(32, 169);
		plTuongTacBaiViet.Name = "plTuongTacBaiViet";
		plTuongTacBaiViet.Size = new Size(657, 266);
		plTuongTacBaiViet.TabIndex = 204;
		nudDelayTo.Location = new Point(238, 140);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 198;
		nudDelayFrom.Location = new Point(141, 140);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 197;
		txtTenHanhDong.Location = new Point(141, 52);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(153, 23);
		txtTenHanhDong.TabIndex = 194;
		label7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label7.Location = new Point(203, 142);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 203;
		label7.Text = ">";
		label7.TextAlign = ContentAlignment.MiddleCenter;
		BE1FC4BD.AutoSize = true;
		BE1FC4BD.Location = new Point(29, 142);
		BE1FC4BD.Name = "label5";
		BE1FC4BD.Size = new Size(87, 16);
		BE1FC4BD.TabIndex = 201;
		BE1FC4BD.Text = "Gia\u0303n ca\u0301ch (s):";
		D3B2D70C.AutoSize = true;
		D3B2D70C.Location = new Point(29, 55);
		D3B2D70C.Name = "label1";
		D3B2D70C.Size = new Size(98, 16);
		D3B2D70C.TabIndex = 199;
		D3B2D70C.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(368, 450);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 10;
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
		btnAdd.Location = new Point(261, 450);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		BB893A0C.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		BB893A0C.BackColor = Color.White;
		BB893A0C.BorderRadius = 0;
		BB893A0C.BottomSahddow = true;
		BB893A0C.color = Color.DarkViolet;
		BB893A0C.Controls.Add(pnlHeader);
		BB893A0C.LeftSahddow = false;
		BB893A0C.Location = new Point(1, 0);
		BB893A0C.Name = "bunifuCards1";
		BB893A0C.RightSahddow = true;
		BB893A0C.ShadowDepth = 20;
		BB893A0C.Size = new Size(717, 37);
		BB893A0C.TabIndex = 28;
		panel2.Controls.Add(tabOptionsPost);
		panel2.Location = new Point(30, 111);
		panel2.Name = "panel2";
		panel2.Size = new Size(266, 23);
		panel2.TabIndex = 202;
		tabOptionsPost.Alignment = TabAlignment.Bottom;
		tabOptionsPost.Controls.Add(tabPage1);
		tabOptionsPost.Controls.Add(B1399B1B);
		tabOptionsPost.Location = new Point(-5, -5);
		tabOptionsPost.Name = "tabOptionsPost";
		tabOptionsPost.SelectedIndex = 0;
		tabOptionsPost.Size = new Size(276, 54);
		tabOptionsPost.TabIndex = 198;
		tabPage1.Controls.Add(FC92743A);
		tabPage1.Controls.Add(label3);
		tabPage1.Controls.Add(E4B75CBE);
		tabPage1.Controls.Add(nudSoLuongTo);
		tabPage1.Location = new Point(4, 4);
		tabPage1.Name = "tabPage1";
		tabPage1.Padding = new Padding(3);
		tabPage1.Size = new Size(268, 25);
		tabPage1.TabIndex = 0;
		tabPage1.Text = "tabPage1";
		tabPage1.UseVisualStyleBackColor = true;
		FC92743A.AutoSize = true;
		FC92743A.Location = new Point(0, 3);
		FC92743A.Name = "label2";
		FC92743A.Size = new Size(84, 16);
		FC92743A.TabIndex = 32;
		FC92743A.Text = "Sô\u0301 lươ\u0323ng ba\u0300i:";
		label3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label3.Location = new Point(174, 3);
		label3.Name = "label3";
		label3.Size = new Size(29, 16);
		label3.TabIndex = 1;
		label3.Text = ">";
		label3.TextAlign = ContentAlignment.MiddleCenter;
		E4B75CBE.Location = new Point(112, 1);
		E4B75CBE.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E4B75CBE.Name = "nudSoLuongFrom";
		E4B75CBE.Size = new Size(56, 23);
		E4B75CBE.TabIndex = 0;
		nudSoLuongTo.Location = new Point(209, 1);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		B1399B1B.Controls.Add(label8);
		B1399B1B.Controls.Add(label9);
		B1399B1B.Controls.Add(nudThoiGianFrom);
		B1399B1B.Controls.Add(E72CAA1E);
		B1399B1B.Location = new Point(4, 4);
		B1399B1B.Name = "tabPage2";
		B1399B1B.Padding = new Padding(3);
		B1399B1B.Size = new Size(268, 25);
		B1399B1B.TabIndex = 1;
		B1399B1B.Text = "tabPage2";
		B1399B1B.UseVisualStyleBackColor = true;
		label8.AutoSize = true;
		label8.Location = new Point(0, 3);
		label8.Name = "label8";
		label8.Size = new Size(85, 16);
		label8.TabIndex = 40;
		label8.Text = "Thơ\u0300i gian (s):";
		label9.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label9.Location = new Point(174, 3);
		label9.Name = "label9";
		label9.Size = new Size(29, 16);
		label9.TabIndex = 41;
		label9.Text = ">";
		label9.TextAlign = ContentAlignment.MiddleCenter;
		nudThoiGianFrom.Location = new Point(112, 1);
		nudThoiGianFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudThoiGianFrom.Name = "nudThoiGianFrom";
		nudThoiGianFrom.Size = new Size(56, 23);
		nudThoiGianFrom.TabIndex = 38;
		E72CAA1E.Location = new Point(209, 1);
		E72CAA1E.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E72CAA1E.Name = "nudThoiGianTo";
		E72CAA1E.Size = new Size(56, 23);
		E72CAA1E.TabIndex = 39;
		A281B22B.Cursor = Cursors.Hand;
		A281B22B.DropDownStyle = ComboBoxStyle.DropDownList;
		A281B22B.DropDownWidth = 200;
		A281B22B.FormattingEnabled = true;
		A281B22B.Location = new Point(141, 81);
		A281B22B.Name = "cbbOptionsPost";
		A281B22B.Size = new Size(153, 24);
		A281B22B.TabIndex = 200;
		A281B22B.SelectedIndexChanged += D516D0AA;
		label4.AutoSize = true;
		label4.Location = new Point(29, 84);
		label4.Name = "label4";
		label4.Size = new Size(64, 16);
		label4.TabIndex = 201;
		label4.Text = "Tu\u0300y cho\u0323n:";
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(720, 493);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDBaiVietTrenTuong";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += CF03D3A8;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		BB893A0C.ResumeLayout(performLayout: false);
		panel2.ResumeLayout(performLayout: false);
		tabOptionsPost.ResumeLayout(performLayout: false);
		tabPage1.ResumeLayout(performLayout: false);
		tabPage1.PerformLayout();
		((ISupportInitialize)E4B75CBE).EndInit();
		((ISupportInitialize)nudSoLuongTo).EndInit();
		B1399B1B.ResumeLayout(performLayout: false);
		B1399B1B.PerformLayout();
		((ISupportInitialize)nudThoiGianFrom).EndInit();
		((ISupportInitialize)E72CAA1E).EndInit();
		ResumeLayout(performLayout: false);
	}
}
