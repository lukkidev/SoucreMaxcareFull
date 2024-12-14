using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class B5B56C91 : Form
{
	private GClass11 E50E3A3C = null;

	private string C28D3C8F;

	private string string_0;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer C8B1FCA3 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label F89A4F29;

	private Label label1;

	private Button btnCancel;

	private Button D8395984;

	private BunifuCards BAA93F30;

	private Panel pnlHeader;

	private Button AD949FB2;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private NumericUpDown nudSoLuongBaiTo;

	private NumericUpDown nudSoLuongBaiFrom;

	private Label label8;

	private Label label3;

	private CheckBox ckbOnlyDeleteTagPost;

	public B5B56C91(string string_2, int E627AA97 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		C28D3C8F = string_2;
		string_1 = string_3;
		int_0 = E627AA97;
		if (Class147.smethod_7("", "HDXoaBaiTuong").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDXoaBaiTuong', 'Xóa bài trên tươ\u0300ng');");
		}
		string text = "";
		switch (E627AA97)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDXoaBaiTuong");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			D8395984.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		E50E3A3C = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void CCB8541F(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongBaiFrom.Value = E50E3A3C.method_2("nudSoLuongBaiFrom", 3);
			nudSoLuongBaiTo.Value = E50E3A3C.method_2("nudSoLuongBaiTo", 3);
			nudDelayFrom.Value = E50E3A3C.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = E50E3A3C.method_2("nudDelayTo", 5);
			ckbOnlyDeleteTagPost.Checked = E50E3A3C.method_3("ckbOnlyDeleteTagPost");
		}
		catch
		{
		}
	}

	private void D1BEC432(object sender, EventArgs e)
	{
		Close();
	}

	private void AD108523(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongBaiFrom", nudSoLuongBaiFrom.Value);
		gClass.method_4("nudSoLuongBaiTo", nudSoLuongBaiTo.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		gClass.method_4("ckbOnlyDeleteTagPost", ckbOnlyDeleteTagPost.Checked);
		string string_ = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(C28D3C8F, text, string_0, string_))
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

	private void BD37E73A(object sender, EventArgs e)
	{
		Close();
	}

	private void C099E6B2(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool B180F19D)
	{
		if (B180F19D && C8B1FCA3 != null)
		{
			C8B1FCA3.Dispose();
		}
		base.Dispose(B180F19D);
	}

	private void InitializeComponent()
	{
		C8B1FCA3 = new System.ComponentModel.Container();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(C8B1FCA3);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(C8B1FCA3);
		pnlHeader = new System.Windows.Forms.Panel();
		AD949FB2 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		ckbOnlyDeleteTagPost = new System.Windows.Forms.CheckBox();
		nudSoLuongBaiTo = new System.Windows.Forms.NumericUpDown();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongBaiFrom = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		label8 = new System.Windows.Forms.Label();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label7 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		F89A4F29 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		D8395984 = new System.Windows.Forms.Button();
		BAA93F30 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		BAA93F30.SuspendLayout();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(315, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Xóa bài viết trên tươ\u0300ng";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(AD949FB2);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(315, 31);
		pnlHeader.TabIndex = 9;
		AD949FB2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		AD949FB2.Cursor = System.Windows.Forms.Cursors.Hand;
		AD949FB2.FlatAppearance.BorderSize = 0;
		AD949FB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		AD949FB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		AD949FB2.ForeColor = System.Drawing.Color.White;
		AD949FB2.Image = C50FB39E.Bitmap_12;
		AD949FB2.Location = new System.Drawing.Point(284, 1);
		AD949FB2.Name = "button1";
		AD949FB2.Size = new System.Drawing.Size(30, 30);
		AD949FB2.TabIndex = 77;
		AD949FB2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		AD949FB2.UseVisualStyleBackColor = true;
		AD949FB2.Click += new System.EventHandler(D1BEC432);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(ckbOnlyDeleteTagPost);
		panel1.Controls.Add(nudSoLuongBaiTo);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudSoLuongBaiFrom);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(label8);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(F89A4F29);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(D8395984);
		panel1.Controls.Add(BAA93F30);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(318, 204);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(C099E6B2);
		ckbOnlyDeleteTagPost.AutoSize = true;
		ckbOnlyDeleteTagPost.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbOnlyDeleteTagPost.Location = new System.Drawing.Point(132, 135);
		ckbOnlyDeleteTagPost.Name = "ckbOnlyDeleteTagPost";
		ckbOnlyDeleteTagPost.Size = new System.Drawing.Size(160, 20);
		ckbOnlyDeleteTagPost.TabIndex = 39;
		ckbOnlyDeleteTagPost.Text = "Chỉ xóa bài viết gắn thẻ";
		ckbOnlyDeleteTagPost.UseVisualStyleBackColor = true;
		nudSoLuongBaiTo.Location = new System.Drawing.Point(229, 78);
		nudSoLuongBaiTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongBaiTo.Name = "nudSoLuongBaiTo";
		nudSoLuongBaiTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongBaiTo.TabIndex = 4;
		nudDelayTo.Location = new System.Drawing.Point(229, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudSoLuongBaiFrom.Location = new System.Drawing.Point(132, 78);
		nudSoLuongBaiFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongBaiFrom.Name = "nudSoLuongBaiFrom";
		nudSoLuongBaiFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongBaiFrom.TabIndex = 3;
		nudDelayFrom.Location = new System.Drawing.Point(132, 107);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		label8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label8.Location = new System.Drawing.Point(194, 80);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(29, 16);
		label8.TabIndex = 38;
		label8.Text = ">";
		label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(153, 23);
		txtTenHanhDong.TabIndex = 0;
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label7.Location = new System.Drawing.Point(194, 109);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = ">";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(27, 80);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(84, 16);
		label3.TabIndex = 34;
		label3.Text = "Số lượng bài:";
		F89A4F29.AutoSize = true;
		F89A4F29.Location = new System.Drawing.Point(27, 109);
		F89A4F29.Name = "label5";
		F89A4F29.Size = new System.Drawing.Size(87, 16);
		F89A4F29.TabIndex = 34;
		F89A4F29.Text = "Gia\u0303n ca\u0301ch (s):";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(167, 165);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(BD37E73A);
		D8395984.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		D8395984.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		D8395984.Cursor = System.Windows.Forms.Cursors.Hand;
		D8395984.FlatAppearance.BorderSize = 0;
		D8395984.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D8395984.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D8395984.ForeColor = System.Drawing.Color.White;
		D8395984.Location = new System.Drawing.Point(60, 165);
		D8395984.Name = "btnAdd";
		D8395984.Size = new System.Drawing.Size(92, 29);
		D8395984.TabIndex = 9;
		D8395984.Text = "Thêm";
		D8395984.UseVisualStyleBackColor = false;
		D8395984.Click += new System.EventHandler(AD108523);
		BAA93F30.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		BAA93F30.BackColor = System.Drawing.Color.White;
		BAA93F30.BorderRadius = 0;
		BAA93F30.BottomSahddow = true;
		BAA93F30.color = System.Drawing.Color.DarkViolet;
		BAA93F30.Controls.Add(pnlHeader);
		BAA93F30.LeftSahddow = false;
		BAA93F30.Location = new System.Drawing.Point(1, 0);
		BAA93F30.Name = "bunifuCards1";
		BAA93F30.RightSahddow = true;
		BAA93F30.ShadowDepth = 20;
		BAA93F30.Size = new System.Drawing.Size(315, 37);
		BAA93F30.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(318, 204);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDXoaBaiTuong";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(CCB8541F);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		BAA93F30.ResumeLayout(false);
		ResumeLayout(false);
	}
}
