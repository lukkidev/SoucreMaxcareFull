using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDChangeSoThich : Form
{
	private GClass11 C988E792 = null;

	private string string_0;

	private string string_1;

	private string DFB697B8;

	private int A7BA5424;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl E398FF94;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown CB076D86;

	private TextBox txtTenHanhDong;

	private Label C40B7C17;

	private Label label6;

	private Label label5;

	private Label C487A2A4;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel EE3E8694;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private Label label8;

	private Label label4;

	private Label F0927A2F;

	private RichTextBox txtTuKhoa;

	private Label label2;

	public fHDChangeSoThich(string F1B69C0D, int int_0 = 0, string F621C319 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = F1B69C0D;
		DFB697B8 = F621C319;
		A7BA5424 = int_0;
		if (Class147.smethod_7("", "HDChangeSoThich").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDChangeSoThich', 'Thay đổi sở thích');");
		}
		string text = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDChangeSoThich");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(F621C319);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		C988E792 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(EE3E8694);
		F7AB102E.smethod_1(C487A2A4);
		F7AB102E.smethod_1(label5);
		F7AB102E.smethod_1(C40B7C17);
		F7AB102E.smethod_1(label6);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(btnCancel);
	}

	private void fHDChangeSoThich_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = C988E792.method_2("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = C988E792.method_2("nudSoLuongTo", 1);
			CB076D86.Value = C988E792.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = C988E792.method_2("nudDelayTo", 5);
			txtTuKhoa.Text = C988E792.C0288288("txtTuKhoa");
		}
		catch
		{
		}
		txtTuKhoa_TextChanged(null, null);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A98AE4A8(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudDelayFrom", CB076D86.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		gClass.method_4("txtTuKhoa", txtTuKhoa.Text.Trim());
		string string_ = gClass.method_7();
		if (A7BA5424 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, string_))
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
			if (Class147.smethod_13(DFB697B8, text, string_))
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

	private void BB8AEF20(object sender, EventArgs e)
	{
		Close();
	}

	private void EFBB7880(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void txtTuKhoa_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtTuKhoa.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			label2.Text = string.Format(F7AB102E.smethod_0("Danh sa\u0301ch từ khóa ({0}):"), e03C713E.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool A89474A7)
	{
		if (A89474A7 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(A89474A7);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		EE3E8694 = new Bunifu.Framework.UI.BunifuCustomLabel();
		E398FF94 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		button1 = new System.Windows.Forms.Button();
		panel1 = new System.Windows.Forms.Panel();
		txtTuKhoa = new System.Windows.Forms.RichTextBox();
		label2 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		CB076D86 = new System.Windows.Forms.NumericUpDown();
		label8 = new System.Windows.Forms.Label();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label4 = new System.Windows.Forms.Label();
		C40B7C17 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		F0927A2F = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		C487A2A4 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)CB076D86).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = EE3E8694;
		bunifuDragControl_0.Vertical = true;
		EE3E8694.BackColor = System.Drawing.Color.Transparent;
		EE3E8694.Cursor = System.Windows.Forms.Cursors.SizeAll;
		EE3E8694.Dock = System.Windows.Forms.DockStyle.Fill;
		EE3E8694.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		EE3E8694.ForeColor = System.Drawing.Color.Black;
		EE3E8694.Location = new System.Drawing.Point(0, 0);
		EE3E8694.Name = "bunifuCustomLabel1";
		EE3E8694.Size = new System.Drawing.Size(357, 31);
		EE3E8694.TabIndex = 12;
		EE3E8694.Text = "Cấu hình Thay đổi sở thích";
		EE3E8694.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		E398FF94.Fixed = true;
		E398FF94.Horizontal = true;
		E398FF94.TargetControl = pnlHeader;
		E398FF94.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(EE3E8694);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(357, 31);
		pnlHeader.TabIndex = 9;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = C50FB39E.Bitmap_12;
		button1.Location = new System.Drawing.Point(324, 5);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(txtTuKhoa);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(CB076D86);
		panel1.Controls.Add(label8);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(C40B7C17);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(F0927A2F);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(C487A2A4);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(359, 418);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(EFBB7880);
		txtTuKhoa.Location = new System.Drawing.Point(30, 156);
		txtTuKhoa.Name = "txtTuKhoa";
		txtTuKhoa.Size = new System.Drawing.Size(296, 201);
		txtTuKhoa.TabIndex = 41;
		txtTuKhoa.Text = "";
		txtTuKhoa.WordWrap = false;
		txtTuKhoa.TextChanged += new System.EventHandler(txtTuKhoa_TextChanged);
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 136);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(139, 16);
		label2.TabIndex = 43;
		label2.Text = "Danh sa\u0301ch từ khóa (0):";
		nudSoLuongTo.Location = new System.Drawing.Point(216, 78);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 4;
		nudDelayTo.Location = new System.Drawing.Point(216, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 78);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 3;
		CB076D86.Location = new System.Drawing.Point(132, 107);
		CB076D86.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		CB076D86.Name = "nudDelayFrom";
		CB076D86.Size = new System.Drawing.Size(56, 23);
		CB076D86.TabIndex = 3;
		label8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label8.Location = new System.Drawing.Point(188, 80);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(29, 16);
		label8.TabIndex = 38;
		label8.Text = ">";
		label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(274, 80);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(51, 16);
		label4.TabIndex = 36;
		label4.Text = "sở thích";
		C40B7C17.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C40B7C17.Location = new System.Drawing.Point(188, 109);
		C40B7C17.Name = "label7";
		C40B7C17.Size = new System.Drawing.Size(29, 16);
		C40B7C17.TabIndex = 38;
		C40B7C17.Text = ">";
		C40B7C17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(274, 109);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		F0927A2F.AutoSize = true;
		F0927A2F.Location = new System.Drawing.Point(27, 80);
		F0927A2F.Name = "label3";
		F0927A2F.Size = new System.Drawing.Size(63, 16);
		F0927A2F.TabIndex = 34;
		F0927A2F.Text = "Số lượng:";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 109);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(89, 16);
		label5.TabIndex = 34;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		C487A2A4.AutoSize = true;
		C487A2A4.Location = new System.Drawing.Point(27, 52);
		C487A2A4.Name = "label1";
		C487A2A4.Size = new System.Drawing.Size(98, 16);
		C487A2A4.TabIndex = 31;
		C487A2A4.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(183, 376);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(BB8AEF20);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(76, 376);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(A98AE4A8);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(button1);
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(357, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(359, 418);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDChangeSoThich";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDChangeSoThich_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)CB076D86).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
