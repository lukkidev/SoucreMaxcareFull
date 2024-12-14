using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDChucMungSinhNhat : Form
{
	private JObject D022D2A3;

	private string string_0;

	private string string_1;

	private string string_2;

	private int E030FBB5;

	public static bool bool_0;

	private IContainer C635A43E = null;

	private BunifuDragControl D1A1CB3B;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown A722278E;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label label4;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel F0834D9B;

	private Label label8;

	private Label lblStatus;

	private TextBox F420EC30;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label D219CFB0;

	private Label label6;

	private Label BF8C4DB6;

	private RadioButton rbDangBai;

	private RadioButton rbNhanTin;

	private Label F5078716;

	public fHDChucMungSinhNhat(string string_3, int E83814B8 = 0, string D797DA31 = "")
	{
		AF9E6291();
		bool_0 = false;
		string_0 = string_3;
		string_2 = D797DA31;
		E030FBB5 = E83814B8;
		string json = "";
		switch (E83814B8)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDChucMungSinhNhat");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(D797DA31);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		D022D2A3 = JObject.Parse(json);
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(F0834D9B);
		F7AB102E.smethod_1(label1);
		F7AB102E.smethod_1(label2);
		F7AB102E.smethod_1(label3);
		F7AB102E.smethod_1(label4);
		F7AB102E.smethod_1(BF8C4DB6);
		F7AB102E.smethod_1(D219CFB0);
		F7AB102E.smethod_1(label6);
		F7AB102E.smethod_1(F5078716);
		F7AB102E.smethod_1(rbNhanTin);
		F7AB102E.smethod_1(rbDangBai);
		F7AB102E.smethod_1(lblStatus);
		F7AB102E.smethod_1(label8);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(btnCancel);
	}

	private void fHDChucMungSinhNhat_Load(object sender, EventArgs e)
	{
		try
		{
			A722278E.Value = Convert.ToInt32(D022D2A3["nudSoLuongFrom"]);
			nudSoLuongTo.Value = Convert.ToInt32(D022D2A3["nudSoLuongTo"]);
			nudDelayFrom.Value = Convert.ToInt32(D022D2A3["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(D022D2A3["nudDelayTo"]);
			if (Convert.ToInt32(D022D2A3["typeAction"]) == 0)
			{
				rbNhanTin.Checked = true;
			}
			else
			{
				rbDangBai.Checked = true;
			}
			F420EC30.Text = D022D2A3["txtContent"]!.ToString();
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DF00F691(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> e03C713E = F420EC30.Lines.ToList();
		e03C713E = GClass8.smethod_36(e03C713E);
		if (e03C713E.Count == 0)
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung tin nhă\u0301n/ba\u0300i viê\u0301t!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", A722278E.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		if (rbNhanTin.Checked)
		{
			gClass.method_4("typeAction", 0);
		}
		else
		{
			gClass.method_4("typeAction", 1);
		}
		gClass.method_4("txtContent", F420EC30.Text.Trim());
		string text2 = gClass.method_7();
		if (E030FBB5 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, text2))
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
			if (Class147.smethod_13(string_2, text, text2))
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

	private void B9BD252A(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void F420EC30_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = F420EC30.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			lblStatus.Text = string.Format(F7AB102E.smethod_0("Danh sa\u0301ch tin nhă\u0301n/ba\u0300i viê\u0301t ({0}):"), e03C713E.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		GClass29.smethod_0("Có thể dùng [u] để thay thế tên của người nhận!");
	}

	protected override void Dispose(bool DBAD2783)
	{
		if (DBAD2783 && C635A43E != null)
		{
			C635A43E.Dispose();
		}
		base.Dispose(DBAD2783);
	}

	private void AF9E6291()
	{
		C635A43E = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDChucMungSinhNhat));
		D1A1CB3B = new BunifuDragControl(C635A43E);
		F0834D9B = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(C635A43E);
		pnlHeader = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		rbDangBai = new RadioButton();
		rbNhanTin = new RadioButton();
		F5078716 = new Label();
		F420EC30 = new TextBox();
		nudDelayTo = new NumericUpDown();
		label8 = new Label();
		lblStatus = new Label();
		nudDelayFrom = new NumericUpDown();
		D219CFB0 = new Label();
		label6 = new Label();
		BF8C4DB6 = new Label();
		nudSoLuongTo = new NumericUpDown();
		A722278E = new NumericUpDown();
		txtTenHanhDong = new TextBox();
		label3 = new Label();
		label4 = new Label();
		label2 = new Label();
		label1 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		bunifuCards1 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		((ISupportInitialize)nudSoLuongTo).BeginInit();
		((ISupportInitialize)A722278E).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		D1A1CB3B.Fixed = true;
		D1A1CB3B.Horizontal = true;
		D1A1CB3B.TargetControl = F0834D9B;
		D1A1CB3B.Vertical = true;
		F0834D9B.BackColor = Color.Transparent;
		F0834D9B.Cursor = Cursors.SizeAll;
		F0834D9B.Dock = DockStyle.Fill;
		F0834D9B.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		F0834D9B.ForeColor = Color.Black;
		F0834D9B.Location = new Point(0, 0);
		F0834D9B.Name = "bunifuCustomLabel1";
		F0834D9B.Size = new Size(359, 31);
		F0834D9B.TabIndex = 12;
		F0834D9B.Text = "Cấu hình Chúc mừng sinh nhật";
		F0834D9B.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(F0834D9B);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(359, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(328, 1);
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
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(rbDangBai);
		panel1.Controls.Add(rbNhanTin);
		panel1.Controls.Add(F5078716);
		panel1.Controls.Add(F420EC30);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(label8);
		panel1.Controls.Add(lblStatus);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(D219CFB0);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(BF8C4DB6);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(A722278E);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(362, 408);
		panel1.TabIndex = 0;
		panel1.Paint += B9BD252A;
		rbDangBai.AutoSize = true;
		rbDangBai.Cursor = Cursors.Hand;
		rbDangBai.Location = new Point(229, 141);
		rbDangBai.Name = "rbDangBai";
		rbDangBai.Size = new Size(76, 20);
		rbDangBai.TabIndex = 91;
		rbDangBai.Text = "Đăng ba\u0300i";
		rbDangBai.UseVisualStyleBackColor = true;
		rbNhanTin.AutoSize = true;
		rbNhanTin.Checked = true;
		rbNhanTin.Cursor = Cursors.Hand;
		rbNhanTin.Location = new Point(132, 141);
		rbNhanTin.Name = "rbNhanTin";
		rbNhanTin.Size = new Size(72, 20);
		rbNhanTin.TabIndex = 90;
		rbNhanTin.TabStop = true;
		rbNhanTin.Text = "Nhă\u0301n tin";
		rbNhanTin.UseVisualStyleBackColor = true;
		F5078716.AutoSize = true;
		F5078716.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		F5078716.Location = new Point(28, 141);
		F5078716.Name = "label28";
		F5078716.Size = new Size(66, 16);
		F5078716.TabIndex = 92;
		F5078716.Text = "Hi\u0300nh thư\u0301c:";
		F420EC30.Location = new Point(31, 191);
		F420EC30.Multiline = true;
		F420EC30.Name = "txtContent";
		F420EC30.ScrollBars = ScrollBars.Both;
		F420EC30.Size = new Size(295, 138);
		F420EC30.TabIndex = 5;
		F420EC30.WordWrap = false;
		F420EC30.TextChanged += F420EC30_TextChanged;
		nudDelayTo.Location = new Point(229, 111);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		label8.AutoSize = true;
		label8.Location = new Point(28, 332);
		label8.Name = "label8";
		label8.Size = new Size(265, 16);
		label8.TabIndex = 0;
		label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Location = new Point(27, 169);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new Size(188, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Danh sa\u0301ch tin nhă\u0301n/ba\u0300i viê\u0301t (0):";
		nudDelayFrom.Location = new Point(132, 111);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		D219CFB0.Location = new Point(194, 113);
		D219CFB0.Name = "label7";
		D219CFB0.Size = new Size(29, 16);
		D219CFB0.TabIndex = 46;
		D219CFB0.Text = "đê\u0301n";
		D219CFB0.TextAlign = ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new Point(286, 113);
		label6.Name = "label6";
		label6.Size = new Size(30, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		BF8C4DB6.AutoSize = true;
		BF8C4DB6.Location = new Point(27, 113);
		BF8C4DB6.Name = "label5";
		BF8C4DB6.Size = new Size(89, 16);
		BF8C4DB6.TabIndex = 44;
		BF8C4DB6.Text = "Thơ\u0300i gian chơ\u0300:";
		nudSoLuongTo.Location = new Point(229, 80);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		A722278E.Location = new Point(132, 80);
		A722278E.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A722278E.Name = "nudSoLuongFrom";
		A722278E.Size = new Size(56, 23);
		A722278E.TabIndex = 1;
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label3.Location = new Point(194, 82);
		label3.Name = "label3";
		label3.Size = new Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new Point(286, 82);
		label4.Name = "label4";
		label4.Size = new Size(28, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0323n";
		label2.AutoSize = true;
		label2.Location = new Point(27, 82);
		label2.Name = "label2";
		label2.Size = new Size(88, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(185, 363);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(78, 363);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += DF00F691;
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
		base.ClientSize = new Size(362, 408);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDChucMungSinhNhat";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDChucMungSinhNhat_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		((ISupportInitialize)nudSoLuongTo).EndInit();
		((ISupportInitialize)A722278E).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
