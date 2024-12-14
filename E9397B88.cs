using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class E9397B88 : Form
{
	private GClass11 EE3D7592;

	private string A8818E2A;

	private string string_0;

	private string DD21D490;

	private int int_0;

	public static bool EAA1BF88;

	private IContainer icontainer_0 = null;

	private BunifuDragControl DB0CF8B5;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private TextBox CF2A2539;

	private Label AB00DCA0;

	private Label label4;

	private Label label2;

	private Label F231B384;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards AE2625BD;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label label7;

	private Label label6;

	private Label D4B9E035;

	private RichTextBox AF342895;

	private Label B8A24CB4;

	private ComboBox cbbTypeHuyKetBan;

	private Panel plDieuKienID;

	private RichTextBox E0A52684;

	private Label lblUidHuyKetBan;

	private Label label12;

	public E9397B88(string string_1, int EB872029 = 0, string string_2 = "")
	{
		E12FF712();
		EAA1BF88 = false;
		A8818E2A = string_1;
		DD21D490 = string_2;
		int_0 = EB872029;
		string string_3 = "";
		switch (EB872029)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDHuyKetBan");
			string_3 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			CF2A2539.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_2);
			string_3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			CF2A2539.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		EE3D7592 = new GClass11(string_3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void A90F1119(object sender, EventArgs e)
	{
		method_0();
		try
		{
			nudSoLuongFrom.Value = EE3D7592.method_2("nudSoLuongFrom");
			nudSoLuongTo.Value = EE3D7592.method_2("nudSoLuongTo");
			nudDelayFrom.Value = EE3D7592.method_2("nudDelayFrom");
			nudDelayTo.Value = EE3D7592.method_2("nudDelayTo");
			cbbTypeHuyKetBan.SelectedIndex = EE3D7592.method_2("cbbTypeHuyKetBan");
			E0A52684.Text = EE3D7592.C0288288("txtUidHuyKetBan");
			AF342895.Text = EE3D7592.C0288288("txtUidKhongHuyKetBan");
		}
		catch
		{
		}
	}

	private void method_0()
	{
		List<string> list_ = new List<string> { "Ngẫu nhiên danh sách bạn", "Hủy kết bạn với tài khoản tên ngoại", "Hủy kết bạn theo UID" };
		GClass8.smethod_22(cbbTypeHuyKetBan, list_);
	}

	private void E384C105(object sender, EventArgs e)
	{
		Close();
	}

	private void B100748F(object sender, EventArgs e)
	{
		string text = CF2A2539.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		gClass.method_4("cbbTypeHuyKetBan", cbbTypeHuyKetBan.SelectedIndex);
		gClass.method_4("txtUidHuyKetBan", E0A52684.Text);
		gClass.method_4("txtUidKhongHuyKetBan", AF342895.Text);
		string text2 = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(A8818E2A, text, string_0, text2))
				{
					EAA1BF88 = true;
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
			if (Class147.smethod_13(DD21D490, text, text2))
			{
				EAA1BF88 = true;
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

	private void C711A925(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void A30369BB(object sender, EventArgs e)
	{
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void B791622B(object sender, EventArgs e)
	{
		GClass8.smethod_60(AF342895, B8A24CB4);
	}

	private void AA273220(object sender, EventArgs e)
	{
	}

	private void cbbTypeHuyKetBan_SelectedIndexChanged(object sender, EventArgs e)
	{
		plDieuKienID.Enabled = cbbTypeHuyKetBan.SelectedIndex == 2;
	}

	private void B39ACD3E(object sender, EventArgs e)
	{
		GClass8.smethod_60(E0A52684, lblUidHuyKetBan);
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void E12FF712()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(E9397B88));
		DB0CF8B5 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		plDieuKienID = new Panel();
		E0A52684 = new RichTextBox();
		lblUidHuyKetBan = new Label();
		cbbTypeHuyKetBan = new ComboBox();
		label12 = new Label();
		label2 = new Label();
		label4 = new Label();
		AF342895 = new RichTextBox();
		AB00DCA0 = new Label();
		nudSoLuongFrom = new NumericUpDown();
		nudSoLuongTo = new NumericUpDown();
		nudDelayTo = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		label7 = new Label();
		label6 = new Label();
		B8A24CB4 = new Label();
		D4B9E035 = new Label();
		CF2A2539 = new TextBox();
		F231B384 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		AE2625BD = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plDieuKienID.SuspendLayout();
		((ISupportInitialize)nudSoLuongFrom).BeginInit();
		((ISupportInitialize)nudSoLuongTo).BeginInit();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		AE2625BD.SuspendLayout();
		SuspendLayout();
		DB0CF8B5.Fixed = true;
		DB0CF8B5.Horizontal = true;
		DB0CF8B5.TargetControl = bunifuCustomLabel1;
		DB0CF8B5.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(651, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Hủy kết bạn";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(651, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(620, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += E384C105;
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
		panel1.Controls.Add(plDieuKienID);
		panel1.Controls.Add(cbbTypeHuyKetBan);
		panel1.Controls.Add(label12);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(AF342895);
		panel1.Controls.Add(AB00DCA0);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(B8A24CB4);
		panel1.Controls.Add(D4B9E035);
		panel1.Controls.Add(CF2A2539);
		panel1.Controls.Add(F231B384);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(AE2625BD);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(654, 425);
		panel1.TabIndex = 0;
		panel1.Paint += C711A925;
		plDieuKienID.BorderStyle = BorderStyle.FixedSingle;
		plDieuKienID.Controls.Add(E0A52684);
		plDieuKienID.Controls.Add(lblUidHuyKetBan);
		plDieuKienID.Location = new Point(30, 170);
		plDieuKienID.Name = "plDieuKienID";
		plDieuKienID.Size = new Size(295, 188);
		plDieuKienID.TabIndex = 52;
		E0A52684.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		E0A52684.Location = new Point(6, 22);
		E0A52684.Name = "txtUidHuyKetBan";
		E0A52684.Size = new Size(284, 161);
		E0A52684.TabIndex = 1;
		E0A52684.Text = "";
		E0A52684.WordWrap = false;
		E0A52684.TextChanged += B39ACD3E;
		lblUidHuyKetBan.AutoSize = true;
		lblUidHuyKetBan.Location = new Point(3, 3);
		lblUidHuyKetBan.Name = "lblUidHuyKetBan";
		lblUidHuyKetBan.Size = new Size(114, 16);
		lblUidHuyKetBan.TabIndex = 0;
		lblUidHuyKetBan.Text = "Danh sách Uid (0):";
		cbbTypeHuyKetBan.Cursor = Cursors.Hand;
		cbbTypeHuyKetBan.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbTypeHuyKetBan.DropDownWidth = 220;
		cbbTypeHuyKetBan.FormattingEnabled = true;
		cbbTypeHuyKetBan.Location = new Point(132, 140);
		cbbTypeHuyKetBan.Name = "cbbTypeHuyKetBan";
		cbbTypeHuyKetBan.Size = new Size(193, 24);
		cbbTypeHuyKetBan.TabIndex = 124;
		cbbTypeHuyKetBan.SelectedIndexChanged += cbbTypeHuyKetBan_SelectedIndexChanged;
		label12.AutoSize = true;
		label12.Location = new Point(27, 143);
		label12.Name = "label12";
		label12.Size = new Size(64, 16);
		label12.TabIndex = 122;
		label12.Text = "Tùy chọn:";
		label2.AutoSize = true;
		label2.Location = new Point(27, 80);
		label2.Name = "label2";
		label2.Size = new Size(63, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng:";
		label4.AutoSize = true;
		label4.Location = new Point(284, 80);
		label4.Name = "label4";
		label4.Size = new Size(28, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0323n";
		AF342895.BorderStyle = BorderStyle.FixedSingle;
		AF342895.Location = new Point(364, 101);
		AF342895.Name = "txtUidKhongHuyKetBan";
		AF342895.Size = new Size(257, 257);
		AF342895.TabIndex = 117;
		AF342895.Text = "";
		AF342895.WordWrap = false;
		AF342895.TextChanged += B791622B;
		AB00DCA0.Location = new Point(192, 80);
		AB00DCA0.Name = "label3";
		AB00DCA0.Size = new Size(29, 16);
		AB00DCA0.TabIndex = 37;
		AB00DCA0.Text = "đê\u0301n";
		AB00DCA0.TextAlign = ContentAlignment.MiddleCenter;
		nudSoLuongFrom.Location = new Point(132, 78);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		nudSoLuongTo.Location = new Point(226, 78);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudDelayTo.Location = new Point(226, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudDelayFrom.Location = new Point(132, 107);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		label7.Location = new Point(192, 109);
		label7.Name = "label7";
		label7.Size = new Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		label7.TextAlign = ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new Point(285, 109);
		label6.Name = "label6";
		label6.Size = new Size(30, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		B8A24CB4.AutoSize = true;
		B8A24CB4.Location = new Point(361, 82);
		B8A24CB4.Name = "label10";
		B8A24CB4.Size = new Size(222, 16);
		B8A24CB4.TabIndex = 44;
		B8A24CB4.Text = "Danh sách UID bạn bè cần giữ lại (0):";
		B8A24CB4.Click += AA273220;
		D4B9E035.AutoSize = true;
		D4B9E035.Location = new Point(27, 109);
		D4B9E035.Name = "label5";
		D4B9E035.Size = new Size(89, 16);
		D4B9E035.TabIndex = 44;
		D4B9E035.Text = "Thơ\u0300i gian chơ\u0300:";
		CF2A2539.Location = new Point(132, 49);
		CF2A2539.Name = "txtTenHanhDong";
		CF2A2539.Size = new Size(194, 23);
		CF2A2539.TabIndex = 0;
		F231B384.AutoSize = true;
		F231B384.Location = new Point(27, 52);
		F231B384.Name = "label1";
		F231B384.Size = new Size(98, 16);
		F231B384.TabIndex = 31;
		F231B384.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(349, 378);
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
		btnAdd.Location = new Point(242, 378);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += B100748F;
		AE2625BD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		AE2625BD.BackColor = Color.White;
		AE2625BD.BorderRadius = 0;
		AE2625BD.BottomSahddow = true;
		AE2625BD.color = Color.DarkViolet;
		AE2625BD.Controls.Add(pnlHeader);
		AE2625BD.LeftSahddow = false;
		AE2625BD.Location = new Point(1, 0);
		AE2625BD.Name = "bunifuCards1";
		AE2625BD.RightSahddow = true;
		AE2625BD.ShadowDepth = 20;
		AE2625BD.Size = new Size(651, 37);
		AE2625BD.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(654, 425);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDHuyKetBan";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += A90F1119;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		plDieuKienID.ResumeLayout(performLayout: false);
		plDieuKienID.PerformLayout();
		((ISupportInitialize)nudSoLuongFrom).EndInit();
		((ISupportInitialize)nudSoLuongTo).EndInit();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		AE2625BD.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
