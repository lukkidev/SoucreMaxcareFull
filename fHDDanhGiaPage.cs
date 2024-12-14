using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDDanhGiaPage : Form
{
	private GClass11 ACA67B3F;

	private string string_0;

	private string string_1;

	private string C6A6509E;

	private int int_0;

	public static bool E9B43794;

	private IContainer CD98A71E = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox A5B6691D;

	private Label FB351237;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards B13C9D12;

	private Panel E7B13A1A;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label lblComment;

	private RichTextBox txtComment;

	private Button DF98163F;

	private Label lblUid;

	private TextBox FD0BD2AB;

	private CheckBox C2AD0DBA;

	private ComboBox C11E28B0;

	private Button btnHuongDanNhapNoiDung;

	private Label FA1AC016;

	public fHDDanhGiaPage(string string_2, int CB24AE11 = 0, string C68C8303 = "")
	{
		InitializeComponent();
		E9B43794 = false;
		string_0 = string_2;
		C6A6509E = C68C8303;
		int_0 = CB24AE11;
		string text = base.Name.Substring(1);
		string text2 = "Đánh giá Page";
		Class147.smethod_8(text, text2);
		string text3 = "";
		switch (CB24AE11)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			A5B6691D.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(C68C8303);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = "Câ\u0323p nhâ\u0323t";
			A5B6691D.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		ACA67B3F = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void fHDDanhGiaPage_Load(object sender, EventArgs e)
	{
		A12E471A();
		try
		{
			FD0BD2AB.Text = ACA67B3F.C0288288("txtUid");
			txtComment.Text = ACA67B3F.C0288288("txtComment");
			C11E28B0.SelectedIndex = ACA67B3F.method_2("typeNganCach");
			C2AD0DBA.Checked = ACA67B3F.method_3("ckbTuDongXoaNoiDung");
		}
		catch
		{
		}
		method_0();
	}

	private void A12E471A()
	{
		List<string> list_ = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		GClass8.smethod_22(C11E28B0, list_);
	}

	private void DF98163F_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C937CD23(object sender, EventArgs e)
	{
		string text = A5B6691D.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> e03C713E = txtComment.Lines.ToList();
		e03C713E = GClass8.smethod_36(e03C713E);
		if (e03C713E.Count == 0)
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung đánh giá!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("txtUid", FD0BD2AB.Text.Trim());
		gClass.method_4("txtComment", txtComment.Text.Trim());
		gClass.method_4("typeNganCach", C11E28B0.SelectedIndex);
		gClass.method_4("ckbTuDongXoaNoiDung", C2AD0DBA.Checked);
		string string_ = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, string_))
				{
					E9B43794 = true;
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
			if (Class147.smethod_13(C6A6509E, text, string_))
			{
				E9B43794 = true;
				Close();
			}
			else
			{
				GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void D41B4694(object sender, EventArgs e)
	{
		Close();
	}

	private void BF311126(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void F9973F9E(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtComment, lblComment, C11E28B0.SelectedIndex);
	}

	private void method_0()
	{
		method_2(null, null);
		method_1(null, null);
		method_3(null, null);
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void ED811439(object sender, EventArgs e)
	{
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void method_3(object sender, EventArgs e)
	{
	}

	private void btnHuongDanNhapNoiDung_Click(object sender, EventArgs e)
	{
		if (C11E28B0.SelectedIndex == 0)
		{
			GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			GClass8.smethod_33(new fHelpNhapComment());
		}
		txtComment.Focus();
	}

	private void C11E28B0_SelectedIndexChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtComment, lblComment, C11E28B0.SelectedIndex);
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && CD98A71E != null)
		{
			CD98A71E.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		CD98A71E = new System.ComponentModel.Container();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(CD98A71E);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(CD98A71E);
		E7B13A1A = new System.Windows.Forms.Panel();
		DF98163F = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		C11E28B0 = new System.Windows.Forms.ComboBox();
		btnHuongDanNhapNoiDung = new System.Windows.Forms.Button();
		FA1AC016 = new System.Windows.Forms.Label();
		C2AD0DBA = new System.Windows.Forms.CheckBox();
		txtComment = new System.Windows.Forms.RichTextBox();
		FD0BD2AB = new System.Windows.Forms.TextBox();
		lblComment = new System.Windows.Forms.Label();
		lblUid = new System.Windows.Forms.Label();
		A5B6691D = new System.Windows.Forms.TextBox();
		FB351237 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		B13C9D12 = new Bunifu.Framework.UI.BunifuCards();
		E7B13A1A.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		B13C9D12.SuspendLayout();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(343, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Đánh giá Page";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = E7B13A1A;
		bunifuDragControl_1.Vertical = true;
		E7B13A1A.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		E7B13A1A.BackColor = System.Drawing.Color.White;
		E7B13A1A.Controls.Add(DF98163F);
		E7B13A1A.Controls.Add(pictureBox1);
		E7B13A1A.Controls.Add(bunifuCustomLabel1);
		E7B13A1A.Cursor = System.Windows.Forms.Cursors.SizeAll;
		E7B13A1A.Location = new System.Drawing.Point(0, 3);
		E7B13A1A.Name = "pnlHeader";
		E7B13A1A.Size = new System.Drawing.Size(343, 31);
		E7B13A1A.TabIndex = 9;
		DF98163F.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		DF98163F.Cursor = System.Windows.Forms.Cursors.Hand;
		DF98163F.FlatAppearance.BorderSize = 0;
		DF98163F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		DF98163F.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		DF98163F.ForeColor = System.Drawing.Color.White;
		DF98163F.Image = C50FB39E.Bitmap_12;
		DF98163F.Location = new System.Drawing.Point(310, 0);
		DF98163F.Name = "btnMinimize";
		DF98163F.Size = new System.Drawing.Size(32, 32);
		DF98163F.TabIndex = 78;
		DF98163F.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		DF98163F.UseVisualStyleBackColor = true;
		DF98163F.Click += new System.EventHandler(DF98163F_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(ED811439);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(C11E28B0);
		panel1.Controls.Add(btnHuongDanNhapNoiDung);
		panel1.Controls.Add(FA1AC016);
		panel1.Controls.Add(C2AD0DBA);
		panel1.Controls.Add(txtComment);
		panel1.Controls.Add(FD0BD2AB);
		panel1.Controls.Add(lblComment);
		panel1.Controls.Add(lblUid);
		panel1.Controls.Add(A5B6691D);
		panel1.Controls.Add(FB351237);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(B13C9D12);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(346, 350);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(BF311126);
		C11E28B0.Cursor = System.Windows.Forms.Cursors.Hand;
		C11E28B0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		C11E28B0.FormattingEnabled = true;
		C11E28B0.Location = new System.Drawing.Point(89, 244);
		C11E28B0.Name = "cbbTuyChonNoiDung";
		C11E28B0.Size = new System.Drawing.Size(193, 24);
		C11E28B0.TabIndex = 198;
		C11E28B0.SelectedIndexChanged += new System.EventHandler(C11E28B0_SelectedIndexChanged);
		btnHuongDanNhapNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		btnHuongDanNhapNoiDung.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnHuongDanNhapNoiDung.Location = new System.Drawing.Point(288, 243);
		btnHuongDanNhapNoiDung.Name = "btnHuongDanNhapNoiDung";
		btnHuongDanNhapNoiDung.Size = new System.Drawing.Size(26, 26);
		btnHuongDanNhapNoiDung.TabIndex = 197;
		btnHuongDanNhapNoiDung.Text = "?";
		btnHuongDanNhapNoiDung.UseVisualStyleBackColor = true;
		btnHuongDanNhapNoiDung.Click += new System.EventHandler(btnHuongDanNhapNoiDung_Click);
		FA1AC016.AutoSize = true;
		FA1AC016.Location = new System.Drawing.Point(23, 247);
		FA1AC016.Name = "label8";
		FA1AC016.Size = new System.Drawing.Size(64, 16);
		FA1AC016.TabIndex = 196;
		FA1AC016.Text = "Tùy chọn:";
		C2AD0DBA.AutoSize = true;
		C2AD0DBA.Cursor = System.Windows.Forms.Cursors.Hand;
		C2AD0DBA.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		C2AD0DBA.Location = new System.Drawing.Point(27, 274);
		C2AD0DBA.Name = "ckbTuDongXoaNoiDung";
		C2AD0DBA.Size = new System.Drawing.Size(219, 20);
		C2AD0DBA.TabIndex = 130;
		C2AD0DBA.Text = "Tư\u0323 đô\u0323ng xo\u0301a nô\u0323i dung đa\u0303 sư\u0309 du\u0323ng";
		C2AD0DBA.UseVisualStyleBackColor = true;
		txtComment.Location = new System.Drawing.Point(27, 128);
		txtComment.Name = "txtComment";
		txtComment.Size = new System.Drawing.Size(287, 111);
		txtComment.TabIndex = 106;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(F9973F9E);
		FD0BD2AB.Location = new System.Drawing.Point(134, 78);
		FD0BD2AB.Name = "txtUid";
		FD0BD2AB.Size = new System.Drawing.Size(180, 23);
		FD0BD2AB.TabIndex = 129;
		lblComment.AutoSize = true;
		lblComment.Location = new System.Drawing.Point(23, 108);
		lblComment.Name = "lblComment";
		lblComment.Size = new System.Drawing.Size(136, 16);
		lblComment.TabIndex = 0;
		lblComment.Text = "Nội dung đánh giá (0):";
		lblUid.AutoSize = true;
		lblUid.Location = new System.Drawing.Point(23, 81);
		lblUid.Name = "lblUid";
		lblUid.Size = new System.Drawing.Size(55, 16);
		lblUid.TabIndex = 126;
		lblUid.Text = "Id Page:";
		A5B6691D.Location = new System.Drawing.Point(134, 49);
		A5B6691D.Name = "txtTenHanhDong";
		A5B6691D.Size = new System.Drawing.Size(180, 23);
		A5B6691D.TabIndex = 0;
		FB351237.AutoSize = true;
		FB351237.Location = new System.Drawing.Point(23, 52);
		FB351237.Name = "label1";
		FB351237.Size = new System.Drawing.Size(98, 16);
		FB351237.TabIndex = 31;
		FB351237.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(177, 308);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 12;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(D41B4694);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(79, 308);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 11;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(C937CD23);
		B13C9D12.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		B13C9D12.BackColor = System.Drawing.Color.White;
		B13C9D12.BorderRadius = 0;
		B13C9D12.BottomSahddow = true;
		B13C9D12.color = System.Drawing.Color.DarkViolet;
		B13C9D12.Controls.Add(E7B13A1A);
		B13C9D12.LeftSahddow = false;
		B13C9D12.Location = new System.Drawing.Point(1, 0);
		B13C9D12.Name = "bunifuCards1";
		B13C9D12.RightSahddow = true;
		B13C9D12.ShadowDepth = 20;
		B13C9D12.Size = new System.Drawing.Size(343, 37);
		B13C9D12.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(346, 350);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDanhGiaPage";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDDanhGiaPage_Load);
		E7B13A1A.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		B13C9D12.ResumeLayout(false);
		ResumeLayout(false);
	}
}
