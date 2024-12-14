using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class EB3B3C1A : Form
{
	private GClass11 F89BEC3B;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private List<CheckBox> E42B543A;

	private IContainer F6BF95AE = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private TextBox txtTenHanhDong;

	private Label A381CE13;

	private Label label5;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards EA38D183;

	private Panel FB3D9920;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel FBAD6FAC;

	private CheckBox F211E008;

	private Label D4217631;

	private NumericUpDown nudTimeTo;

	private NumericUpDown F300CA24;

	private Label D3A02716;

	private Label label3;

	private Panel D3B2AF26;

	private RichTextBox D42B49BC;

	private CheckBox ckbSendAnh;

	private CheckBox ckbComment;

	private Label D3130901;

	private NumericUpDown nudSoLuongUidFrom;

	private NumericUpDown BD96E7B8;

	private Label label66;

	private Panel plCommentText;

	private CheckBox ckbAutoDeleteComment;

	private Panel panel3;

	private RadioButton rbCommentTheoThuTu;

	private RadioButton rbCommentNgauNhien;

	private Label CE38E018;

	private RichTextBox txtComment;

	private Label lblComment;

	private ComboBox cbbTuyChonNoiDung;

	private Button DDA49DA8;

	private Label DB1B7C0F;

	private TextBox D78F0299;

	private Label label12;

	private CheckBox ckbTuDongXoaUid;

	private Panel plInteract;

	private CheckBox FE1B7833;

	private CheckBox ckbSad;

	private CheckBox B315E007;

	private CheckBox FC87A10F;

	private CheckBox ckbCare;

	private CheckBox ckbLove;

	private CheckBox FA3CBAAE;

	private Panel panel7;

	private RadioButton radioButton3;

	private RadioButton ED25D286;

	private Label label26;

	private CheckBox ckbUuTienMbasic;

	public EB3B3C1A(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Phản hồi bình luận";
		if (Class147.smethod_7("", text).Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\",\"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_4);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		F89BEC3B = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
		E42B543A = new List<CheckBox> { FA3CBAAE, ckbLove, ckbCare, FC87A10F, B315E007, ckbSad, FE1B7833 };
	}

	private void EB3B3C1A_Load(object sender, EventArgs e)
	{
		B6A6F3B4();
		try
		{
			F300CA24.Value = F89BEC3B.method_2("nudTimeFrom", 3);
			nudTimeTo.Value = F89BEC3B.method_2("nudTimeTo", 5);
			nudDelayFrom.Value = F89BEC3B.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = F89BEC3B.method_2("nudDelayTo", 5);
			nudSoLuongUidFrom.Value = F89BEC3B.method_2("nudSoLuongUidFrom", 1);
			BD96E7B8.Value = F89BEC3B.method_2("nudSoLuongUidTo", 1);
			F211E008.Checked = F89BEC3B.method_3("ckbInteract");
			string text = F89BEC3B.C0288288("typeReaction", "Like");
			List<string> list = text.Split('|').ToList();
			for (int i = 0; i < list.Count; i++)
			{
				foreach (CheckBox item in E42B543A)
				{
					if (item.Name.Substring(3) == list[i])
					{
						item.Checked = true;
					}
				}
			}
			ckbComment.Checked = F89BEC3B.method_3("ckbComment");
			txtComment.Text = F89BEC3B.C0288288("txtComment");
			D42B49BC.Text = F89BEC3B.C0288288("txtIdPost");
			ckbTuDongXoaUid.Checked = F89BEC3B.method_3("ckbTuDongXoaUid");
			ckbUuTienMbasic.Checked = F89BEC3B.method_3("ckbUuTienMbasic");
			ckbSendAnh.Checked = F89BEC3B.method_3("ckbSendAnh");
			D78F0299.Text = F89BEC3B.C0288288("txtAnh");
			cbbTuyChonNoiDung.SelectedIndex = F89BEC3B.method_2("typeNganCach");
			if (F89BEC3B.method_2("typeComment") == 1)
			{
				rbCommentNgauNhien.Checked = true;
			}
			else
			{
				rbCommentTheoThuTu.Checked = true;
			}
			ckbAutoDeleteComment.Checked = F89BEC3B.method_3("ckbAutoDeleteComment");
		}
		catch
		{
		}
		C01A4D87();
	}

	private void B6A6F3B4()
	{
		List<string> list_ = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		GClass8.smethod_22(cbbTuyChonNoiDung, list_);
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
			GClass29.smethod_0(F7AB102E.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		List<string> e03C713E = D42B49BC.Lines.ToList();
		e03C713E = GClass8.smethod_36(e03C713E);
		GClass11 gClass = new GClass11();
		gClass.method_4("nudTimeFrom", F300CA24.Value);
		gClass.method_4("nudTimeTo", nudTimeTo.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		gClass.method_4("nudSoLuongUidFrom", nudSoLuongUidFrom.Value);
		gClass.method_4("nudSoLuongUidTo", BD96E7B8.Value);
		gClass.method_4("ckbInteract", F211E008.Checked);
		string text2 = "";
		for (int i = 0; i < E42B543A.Count; i++)
		{
			if (E42B543A[i].Checked)
			{
				text2 = text2 + E42B543A[i].Name.Substring(3) + "|";
			}
		}
		gClass.method_4("typeReaction", text2.TrimEnd('|'));
		gClass.method_4("ckbComment", ckbComment.Checked);
		gClass.method_4("txtComment", txtComment.Text.Trim());
		gClass.method_4("txtIdPost", D42B49BC.Text.Trim());
		gClass.method_4("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
		gClass.method_4("ckbUuTienMbasic", ckbUuTienMbasic.Checked);
		gClass.method_4("ckbSendAnh", ckbSendAnh.Checked);
		gClass.method_4("txtAnh", D78F0299.Text.Trim());
		gClass.method_4("typeNganCach", cbbTuyChonNoiDung.SelectedIndex);
		int num = 0;
		if (rbCommentNgauNhien.Checked)
		{
			num = 1;
		}
		gClass.method_4("typeComment", num);
		gClass.method_4("ckbAutoDeleteComment", ckbAutoDeleteComment.Checked);
		string text3 = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1(F7AB102E.smethod_0("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, text3))
				{
					bool_0 = true;
					Close();
				}
				else
				{
					GClass29.smethod_0(F7AB102E.smethod_0("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
				}
			}
		}
		else if (GClass29.smethod_1(F7AB102E.smethod_0("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?")) == DialogResult.Yes)
		{
			if (Class147.smethod_13(string_2, text, text3))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				GClass29.smethod_0(F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void D6154205(object sender, EventArgs e)
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

	private void E8A1B608(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtComment.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			lblComment.Text = string.Format(F7AB102E.smethod_0("Nội dung bình luận ({0}):"), e03C713E.Count.ToString());
		}
		catch
		{
		}
	}

	private void C01A4D87()
	{
		B7BB2499(null, null);
		ckbComment_CheckedChanged(null, null);
		method_4(null, null);
		method_5(null, null);
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plCommentText.Enabled = ckbComment.Checked;
	}

	private void D42B49BC_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(D42B49BC, D4217631);
	}

	private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
	{
		D3B2AF26.Enabled = ckbSendAnh.Checked;
	}

	private void panel1_Click(object sender, EventArgs e)
	{
	}

	private void C12D80A5(object sender, EventArgs e)
	{
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void BE9A0F16(object sender, EventArgs e)
	{
	}

	private void CE38E018_Click(object sender, EventArgs e)
	{
	}

	private void D1A6EC35(object sender, EventArgs e)
	{
	}

	private void method_1(object sender, EventArgs e)
	{
		plCommentText.Height = 195;
	}

	private void FC33AF9C(object sender, EventArgs e)
	{
		plCommentText.Height = 267;
	}

	private void BE3ED03B(object sender, EventArgs e)
	{
		GClass29.smethod_0(F7AB102E.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		txtComment.Focus();
	}

	private void C60AEEA3(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHelpNhapComment());
		txtComment.Focus();
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtComment, lblComment, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void method_2(object sender, EventArgs e)
	{
		GClass29.smethod_0(F7AB102E.smethod_0("Có thể dùng [u] để thay thế tên của người đăng bài!"));
	}

	private void method_3(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.smethod_33(new E3962B82());
	}

	private void method_4(object sender, EventArgs e)
	{
	}

	private void method_5(object sender, EventArgs e)
	{
	}

	private void C2BB0CAD(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtComment, lblComment);
	}

	private void C634650D(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtComment, lblComment, 1);
	}

	private void DDA49DA8_Click(object sender, EventArgs e)
	{
		if (cbbTuyChonNoiDung.SelectedIndex == 0)
		{
			GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			GClass8.smethod_33(new fHelpNhapComment());
		}
		txtComment.Focus();
	}

	private void cbbTuyChonNoiDung_SelectedIndexChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtComment, lblComment, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void B7BB2499(object sender, EventArgs e)
	{
		plInteract.Enabled = F211E008.Checked;
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && F6BF95AE != null)
		{
			F6BF95AE.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		F6BF95AE = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EB3B3C1A));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(F6BF95AE);
		FBAD6FAC = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(F6BF95AE);
		FB3D9920 = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		ckbTuDongXoaUid = new System.Windows.Forms.CheckBox();
		plCommentText = new System.Windows.Forms.Panel();
		cbbTuyChonNoiDung = new System.Windows.Forms.ComboBox();
		DDA49DA8 = new System.Windows.Forms.Button();
		DB1B7C0F = new System.Windows.Forms.Label();
		ckbAutoDeleteComment = new System.Windows.Forms.CheckBox();
		panel3 = new System.Windows.Forms.Panel();
		rbCommentTheoThuTu = new System.Windows.Forms.RadioButton();
		rbCommentNgauNhien = new System.Windows.Forms.RadioButton();
		CE38E018 = new System.Windows.Forms.Label();
		txtComment = new System.Windows.Forms.RichTextBox();
		lblComment = new System.Windows.Forms.Label();
		D3130901 = new System.Windows.Forms.Label();
		nudSoLuongUidFrom = new System.Windows.Forms.NumericUpDown();
		BD96E7B8 = new System.Windows.Forms.NumericUpDown();
		label66 = new System.Windows.Forms.Label();
		D3B2AF26 = new System.Windows.Forms.Panel();
		D78F0299 = new System.Windows.Forms.TextBox();
		label12 = new System.Windows.Forms.Label();
		D42B49BC = new System.Windows.Forms.RichTextBox();
		ckbSendAnh = new System.Windows.Forms.CheckBox();
		ckbComment = new System.Windows.Forms.CheckBox();
		D4217631 = new System.Windows.Forms.Label();
		F211E008 = new System.Windows.Forms.CheckBox();
		nudTimeTo = new System.Windows.Forms.NumericUpDown();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		F300CA24 = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		D3A02716 = new System.Windows.Forms.Label();
		A381CE13 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		EA38D183 = new Bunifu.Framework.UI.BunifuCards();
		plInteract = new System.Windows.Forms.Panel();
		FE1B7833 = new System.Windows.Forms.CheckBox();
		ckbSad = new System.Windows.Forms.CheckBox();
		B315E007 = new System.Windows.Forms.CheckBox();
		FC87A10F = new System.Windows.Forms.CheckBox();
		ckbCare = new System.Windows.Forms.CheckBox();
		ckbLove = new System.Windows.Forms.CheckBox();
		FA3CBAAE = new System.Windows.Forms.CheckBox();
		panel7 = new System.Windows.Forms.Panel();
		radioButton3 = new System.Windows.Forms.RadioButton();
		ED25D286 = new System.Windows.Forms.RadioButton();
		label26 = new System.Windows.Forms.Label();
		ckbUuTienMbasic = new System.Windows.Forms.CheckBox();
		FB3D9920.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plCommentText.SuspendLayout();
		panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongUidFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)BD96E7B8).BeginInit();
		D3B2AF26.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudTimeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)F300CA24).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		EA38D183.SuspendLayout();
		plInteract.SuspendLayout();
		panel7.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = FBAD6FAC;
		bunifuDragControl_0.Vertical = true;
		FBAD6FAC.BackColor = System.Drawing.Color.Transparent;
		FBAD6FAC.Cursor = System.Windows.Forms.Cursors.SizeAll;
		FBAD6FAC.Dock = System.Windows.Forms.DockStyle.Fill;
		FBAD6FAC.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		FBAD6FAC.ForeColor = System.Drawing.Color.Black;
		FBAD6FAC.Location = new System.Drawing.Point(0, 0);
		FBAD6FAC.Name = "bunifuCustomLabel1";
		FBAD6FAC.Size = new System.Drawing.Size(665, 31);
		FBAD6FAC.TabIndex = 12;
		FBAD6FAC.Text = "Cấu hình Phản hồi bình luận";
		FBAD6FAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = FB3D9920;
		bunifuDragControl_1.Vertical = true;
		FB3D9920.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		FB3D9920.BackColor = System.Drawing.Color.White;
		FB3D9920.Controls.Add(button1);
		FB3D9920.Controls.Add(pictureBox1);
		FB3D9920.Controls.Add(FBAD6FAC);
		FB3D9920.Cursor = System.Windows.Forms.Cursors.SizeAll;
		FB3D9920.Location = new System.Drawing.Point(0, 3);
		FB3D9920.Name = "pnlHeader";
		FB3D9920.Size = new System.Drawing.Size(665, 31);
		FB3D9920.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(634, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(C12D80A5);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(ckbUuTienMbasic);
		panel1.Controls.Add(plInteract);
		panel1.Controls.Add(ckbTuDongXoaUid);
		panel1.Controls.Add(plCommentText);
		panel1.Controls.Add(D3130901);
		panel1.Controls.Add(nudSoLuongUidFrom);
		panel1.Controls.Add(BD96E7B8);
		panel1.Controls.Add(label66);
		panel1.Controls.Add(D3B2AF26);
		panel1.Controls.Add(D42B49BC);
		panel1.Controls.Add(ckbSendAnh);
		panel1.Controls.Add(ckbComment);
		panel1.Controls.Add(D4217631);
		panel1.Controls.Add(F211E008);
		panel1.Controls.Add(nudTimeTo);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(F300CA24);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(D3A02716);
		panel1.Controls.Add(A381CE13);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(EA38D183);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(668, 502);
		panel1.TabIndex = 0;
		panel1.Click += new System.EventHandler(panel1_Click);
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		ckbTuDongXoaUid.AutoSize = true;
		ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuDongXoaUid.Location = new System.Drawing.Point(30, 394);
		ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		ckbTuDongXoaUid.Size = new System.Drawing.Size(190, 20);
		ckbTuDongXoaUid.TabIndex = 172;
		ckbTuDongXoaUid.Text = "Tự động xóa ID đã tương tác";
		ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		plCommentText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plCommentText.Controls.Add(cbbTuyChonNoiDung);
		plCommentText.Controls.Add(DDA49DA8);
		plCommentText.Controls.Add(DB1B7C0F);
		plCommentText.Controls.Add(ckbAutoDeleteComment);
		plCommentText.Controls.Add(panel3);
		plCommentText.Controls.Add(CE38E018);
		plCommentText.Controls.Add(txtComment);
		plCommentText.Controls.Add(lblComment);
		plCommentText.Location = new System.Drawing.Point(321, 163);
		plCommentText.Name = "plCommentText";
		plCommentText.Size = new System.Drawing.Size(312, 219);
		plCommentText.TabIndex = 164;
		cbbTuyChonNoiDung.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		cbbTuyChonNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTuyChonNoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTuyChonNoiDung.FormattingEnabled = true;
		cbbTuyChonNoiDung.Location = new System.Drawing.Point(70, 169);
		cbbTuyChonNoiDung.Name = "cbbTuyChonNoiDung";
		cbbTuyChonNoiDung.Size = new System.Drawing.Size(203, 24);
		cbbTuyChonNoiDung.TabIndex = 198;
		cbbTuyChonNoiDung.SelectedIndexChanged += new System.EventHandler(cbbTuyChonNoiDung_SelectedIndexChanged);
		DDA49DA8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		DDA49DA8.Cursor = System.Windows.Forms.Cursors.Hand;
		DDA49DA8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DDA49DA8.Location = new System.Drawing.Point(279, 168);
		DDA49DA8.Name = "btnHuongDanNhapNoiDung";
		DDA49DA8.Size = new System.Drawing.Size(26, 26);
		DDA49DA8.TabIndex = 197;
		DDA49DA8.Text = "?";
		DDA49DA8.UseVisualStyleBackColor = true;
		DDA49DA8.Click += new System.EventHandler(DDA49DA8_Click);
		DB1B7C0F.AutoSize = true;
		DB1B7C0F.Location = new System.Drawing.Point(4, 172);
		DB1B7C0F.Name = "label8";
		DB1B7C0F.Size = new System.Drawing.Size(64, 16);
		DB1B7C0F.TabIndex = 196;
		DB1B7C0F.Text = "Tùy chọn:";
		ckbAutoDeleteComment.AutoSize = true;
		ckbAutoDeleteComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAutoDeleteComment.Location = new System.Drawing.Point(8, 195);
		ckbAutoDeleteComment.Name = "ckbAutoDeleteComment";
		ckbAutoDeleteComment.Size = new System.Drawing.Size(225, 20);
		ckbAutoDeleteComment.TabIndex = 176;
		ckbAutoDeleteComment.Text = "Tự động xóa nội dung đã bình luận";
		ckbAutoDeleteComment.UseVisualStyleBackColor = true;
		panel3.Controls.Add(rbCommentTheoThuTu);
		panel3.Controls.Add(rbCommentNgauNhien);
		panel3.Location = new System.Drawing.Point(67, 300);
		panel3.Name = "panel3";
		panel3.Size = new System.Drawing.Size(200, 43);
		panel3.TabIndex = 43;
		rbCommentTheoThuTu.AutoSize = true;
		rbCommentTheoThuTu.Checked = true;
		rbCommentTheoThuTu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbCommentTheoThuTu.Location = new System.Drawing.Point(3, 2);
		rbCommentTheoThuTu.Name = "rbCommentTheoThuTu";
		rbCommentTheoThuTu.Size = new System.Drawing.Size(201, 20);
		rbCommentTheoThuTu.TabIndex = 3;
		rbCommentTheoThuTu.TabStop = true;
		rbCommentTheoThuTu.Text = "Comment theo thứ tự nội dung";
		rbCommentTheoThuTu.UseVisualStyleBackColor = true;
		rbCommentTheoThuTu.CheckedChanged += new System.EventHandler(BE9A0F16);
		rbCommentNgauNhien.AutoSize = true;
		rbCommentNgauNhien.Cursor = System.Windows.Forms.Cursors.Hand;
		rbCommentNgauNhien.Location = new System.Drawing.Point(3, 23);
		rbCommentNgauNhien.Name = "rbCommentNgauNhien";
		rbCommentNgauNhien.Size = new System.Drawing.Size(200, 20);
		rbCommentNgauNhien.TabIndex = 3;
		rbCommentNgauNhien.Text = "Comment ngẫu nhiên nội dung";
		rbCommentNgauNhien.UseVisualStyleBackColor = true;
		rbCommentNgauNhien.CheckedChanged += new System.EventHandler(D1A6EC35);
		CE38E018.AutoSize = true;
		CE38E018.Location = new System.Drawing.Point(4, 302);
		CE38E018.Name = "label13";
		CE38E018.Size = new System.Drawing.Size(64, 16);
		CE38E018.TabIndex = 2;
		CE38E018.Text = "Tùy chọn:";
		CE38E018.Click += new System.EventHandler(CE38E018_Click);
		txtComment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtComment.Location = new System.Drawing.Point(7, 25);
		txtComment.Name = "txtComment";
		txtComment.Size = new System.Drawing.Size(298, 137);
		txtComment.TabIndex = 1;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		lblComment.AutoSize = true;
		lblComment.Location = new System.Drawing.Point(3, 5);
		lblComment.Name = "lblComment";
		lblComment.Size = new System.Drawing.Size(139, 16);
		lblComment.TabIndex = 0;
		lblComment.Text = "Nội dung bình luận (0):";
		D3130901.AutoSize = true;
		D3130901.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		D3130901.Location = new System.Drawing.Point(27, 80);
		D3130901.Name = "label49";
		D3130901.Size = new System.Drawing.Size(107, 16);
		D3130901.TabIndex = 169;
		D3130901.Text = "Sô\u0301 lươ\u0323ng ID/Nick:";
		nudSoLuongUidFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudSoLuongUidFrom.Location = new System.Drawing.Point(134, 78);
		nudSoLuongUidFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongUidFrom.Name = "nudSoLuongUidFrom";
		nudSoLuongUidFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongUidFrom.TabIndex = 167;
		nudSoLuongUidFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		BD96E7B8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		BD96E7B8.Location = new System.Drawing.Point(231, 78);
		BD96E7B8.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		BD96E7B8.Name = "nudSoLuongUidTo";
		BD96E7B8.Size = new System.Drawing.Size(56, 23);
		BD96E7B8.TabIndex = 168;
		BD96E7B8.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		label66.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		label66.Location = new System.Drawing.Point(196, 80);
		label66.Name = "label66";
		label66.Size = new System.Drawing.Size(29, 16);
		label66.TabIndex = 171;
		label66.Text = ">";
		label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D3B2AF26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D3B2AF26.Controls.Add(D78F0299);
		D3B2AF26.Controls.Add(label12);
		D3B2AF26.Enabled = false;
		D3B2AF26.Location = new System.Drawing.Point(321, 409);
		D3B2AF26.Name = "plAnh";
		D3B2AF26.Size = new System.Drawing.Size(312, 31);
		D3B2AF26.TabIndex = 166;
		D78F0299.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		D78F0299.Location = new System.Drawing.Point(91, 3);
		D78F0299.Name = "txtAnh";
		D78F0299.Size = new System.Drawing.Size(216, 23);
		D78F0299.TabIndex = 161;
		label12.AutoSize = true;
		label12.Location = new System.Drawing.Point(4, 6);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(73, 16);
		label12.TabIndex = 160;
		label12.Text = "Folder ảnh:";
		D42B49BC.Location = new System.Drawing.Point(30, 154);
		D42B49BC.Name = "txtIdPost";
		D42B49BC.Size = new System.Drawing.Size(257, 234);
		D42B49BC.TabIndex = 1;
		D42B49BC.Text = "";
		D42B49BC.WordWrap = false;
		D42B49BC.TextChanged += new System.EventHandler(D42B49BC_TextChanged);
		ckbSendAnh.AutoSize = true;
		ckbSendAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbSendAnh.Location = new System.Drawing.Point(321, 387);
		ckbSendAnh.Name = "ckbSendAnh";
		ckbSendAnh.Size = new System.Drawing.Size(103, 20);
		ckbSendAnh.TabIndex = 165;
		ckbSendAnh.Text = "Bình luận ảnh";
		ckbSendAnh.UseVisualStyleBackColor = true;
		ckbSendAnh.CheckedChanged += new System.EventHandler(ckbSendAnh_CheckedChanged);
		ckbComment.AutoSize = true;
		ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbComment.Location = new System.Drawing.Point(321, 141);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new System.Drawing.Size(127, 20);
		ckbComment.TabIndex = 163;
		ckbComment.Text = "Bi\u0300nh luâ\u0323n văn bản";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		D4217631.AutoSize = true;
		D4217631.Location = new System.Drawing.Point(27, 135);
		D4217631.Name = "label2";
		D4217631.Size = new System.Drawing.Size(167, 16);
		D4217631.TabIndex = 40;
		D4217631.Text = "Danh sa\u0301ch ID Comment (0):";
		F211E008.AutoSize = true;
		F211E008.Cursor = System.Windows.Forms.Cursors.Hand;
		F211E008.Location = new System.Drawing.Point(321, 80);
		F211E008.Name = "ckbInteract";
		F211E008.Size = new System.Drawing.Size(99, 20);
		F211E008.TabIndex = 5;
		F211E008.Text = "Thả cảm xúc";
		F211E008.UseVisualStyleBackColor = true;
		F211E008.CheckedChanged += new System.EventHandler(B7BB2499);
		nudTimeTo.Location = new System.Drawing.Point(505, 50);
		nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeTo.Name = "nudTimeTo";
		nudTimeTo.Size = new System.Drawing.Size(51, 23);
		nudTimeTo.TabIndex = 4;
		nudDelayTo.Location = new System.Drawing.Point(231, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		F300CA24.Location = new System.Drawing.Point(427, 50);
		F300CA24.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F300CA24.Name = "nudTimeFrom";
		F300CA24.Size = new System.Drawing.Size(51, 23);
		F300CA24.TabIndex = 3;
		nudDelayFrom.Location = new System.Drawing.Point(134, 107);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		txtTenHanhDong.Location = new System.Drawing.Point(134, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(153, 23);
		txtTenHanhDong.TabIndex = 0;
		D3A02716.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D3A02716.Location = new System.Drawing.Point(478, 52);
		D3A02716.Name = "label9";
		D3A02716.Size = new System.Drawing.Size(29, 16);
		D3A02716.TabIndex = 38;
		D3A02716.Text = ">";
		D3A02716.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		A381CE13.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A381CE13.Location = new System.Drawing.Point(196, 109);
		A381CE13.Name = "label7";
		A381CE13.Size = new System.Drawing.Size(29, 16);
		A381CE13.TabIndex = 38;
		A381CE13.Text = ">";
		A381CE13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(318, 52);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(103, 16);
		label3.TabIndex = 34;
		label3.Text = "Xem bài viết (s):";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 109);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(87, 16);
		label5.TabIndex = 34;
		label5.Text = "Gia\u0303n ca\u0301ch (s):";
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
		btnCancel.Location = new System.Drawing.Point(321, 457);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(D6154205);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(214, 457);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		EA38D183.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		EA38D183.BackColor = System.Drawing.Color.White;
		EA38D183.BorderRadius = 0;
		EA38D183.BottomSahddow = true;
		EA38D183.color = System.Drawing.Color.DarkViolet;
		EA38D183.Controls.Add(FB3D9920);
		EA38D183.LeftSahddow = false;
		EA38D183.Location = new System.Drawing.Point(1, 0);
		EA38D183.Name = "bunifuCards1";
		EA38D183.RightSahddow = true;
		EA38D183.ShadowDepth = 20;
		EA38D183.Size = new System.Drawing.Size(665, 37);
		EA38D183.TabIndex = 28;
		plInteract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plInteract.Controls.Add(FE1B7833);
		plInteract.Controls.Add(ckbSad);
		plInteract.Controls.Add(B315E007);
		plInteract.Controls.Add(FC87A10F);
		plInteract.Controls.Add(ckbCare);
		plInteract.Controls.Add(ckbLove);
		plInteract.Controls.Add(FA3CBAAE);
		plInteract.Controls.Add(panel7);
		plInteract.Controls.Add(label26);
		plInteract.Location = new System.Drawing.Point(321, 102);
		plInteract.Name = "plInteract";
		plInteract.Size = new System.Drawing.Size(312, 33);
		plInteract.TabIndex = 184;
		FE1B7833.Cursor = System.Windows.Forms.Cursors.Hand;
		FE1B7833.Image = C50FB39E.ABB95605;
		FE1B7833.Location = new System.Drawing.Point(266, 1);
		FE1B7833.Name = "ckbAngry";
		FE1B7833.Size = new System.Drawing.Size(40, 30);
		FE1B7833.TabIndex = 179;
		FE1B7833.Tag = "Angry";
		FE1B7833.UseVisualStyleBackColor = true;
		ckbSad.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbSad.Image = C50FB39E.Bitmap_163;
		ckbSad.Location = new System.Drawing.Point(222, 1);
		ckbSad.Name = "ckbSad";
		ckbSad.Size = new System.Drawing.Size(40, 30);
		ckbSad.TabIndex = 178;
		ckbSad.Tag = "Sad";
		ckbSad.UseVisualStyleBackColor = true;
		B315E007.Cursor = System.Windows.Forms.Cursors.Hand;
		B315E007.Image = C50FB39E.F10C2BBC;
		B315E007.Location = new System.Drawing.Point(178, 1);
		B315E007.Name = "ckbWow";
		B315E007.Size = new System.Drawing.Size(40, 30);
		B315E007.TabIndex = 177;
		B315E007.Tag = "Wow";
		B315E007.UseVisualStyleBackColor = true;
		FC87A10F.Cursor = System.Windows.Forms.Cursors.Hand;
		FC87A10F.Image = C50FB39E.Bitmap_47;
		FC87A10F.Location = new System.Drawing.Point(134, 1);
		FC87A10F.Name = "ckbHaha";
		FC87A10F.Size = new System.Drawing.Size(40, 30);
		FC87A10F.TabIndex = 176;
		FC87A10F.Tag = "Haha";
		FC87A10F.UseVisualStyleBackColor = true;
		ckbCare.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCare.Image = C50FB39E.Bitmap_14;
		ckbCare.Location = new System.Drawing.Point(90, 1);
		ckbCare.Name = "ckbCare";
		ckbCare.Size = new System.Drawing.Size(40, 30);
		ckbCare.TabIndex = 175;
		ckbCare.Tag = "Care";
		ckbCare.UseVisualStyleBackColor = true;
		ckbLove.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLove.Image = C50FB39E.Bitmap_153;
		ckbLove.Location = new System.Drawing.Point(46, 1);
		ckbLove.Name = "ckbLove";
		ckbLove.Size = new System.Drawing.Size(40, 30);
		ckbLove.TabIndex = 174;
		ckbLove.Tag = "Love";
		ckbLove.UseVisualStyleBackColor = true;
		FA3CBAAE.Cursor = System.Windows.Forms.Cursors.Hand;
		FA3CBAAE.Image = C50FB39E.F2069B3C;
		FA3CBAAE.Location = new System.Drawing.Point(2, 1);
		FA3CBAAE.Name = "ckbLike";
		FA3CBAAE.Size = new System.Drawing.Size(40, 30);
		FA3CBAAE.TabIndex = 173;
		FA3CBAAE.Tag = "Like";
		FA3CBAAE.UseVisualStyleBackColor = true;
		panel7.Controls.Add(radioButton3);
		panel7.Controls.Add(ED25D286);
		panel7.Location = new System.Drawing.Point(67, 300);
		panel7.Name = "panel7";
		panel7.Size = new System.Drawing.Size(200, 43);
		panel7.TabIndex = 43;
		radioButton3.AutoSize = true;
		radioButton3.Checked = true;
		radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
		radioButton3.Location = new System.Drawing.Point(3, 2);
		radioButton3.Name = "radioButton3";
		radioButton3.Size = new System.Drawing.Size(201, 20);
		radioButton3.TabIndex = 3;
		radioButton3.TabStop = true;
		radioButton3.Text = "Comment theo thứ tự nội dung";
		radioButton3.UseVisualStyleBackColor = true;
		ED25D286.AutoSize = true;
		ED25D286.Cursor = System.Windows.Forms.Cursors.Hand;
		ED25D286.Location = new System.Drawing.Point(3, 23);
		ED25D286.Name = "radioButton4";
		ED25D286.Size = new System.Drawing.Size(200, 20);
		ED25D286.TabIndex = 3;
		ED25D286.Text = "Comment ngẫu nhiên nội dung";
		ED25D286.UseVisualStyleBackColor = true;
		label26.AutoSize = true;
		label26.Location = new System.Drawing.Point(4, 302);
		label26.Name = "label26";
		label26.Size = new System.Drawing.Size(64, 16);
		label26.TabIndex = 2;
		label26.Text = "Tùy chọn:";
		ckbUuTienMbasic.AutoSize = true;
		ckbUuTienMbasic.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbUuTienMbasic.Location = new System.Drawing.Point(30, 420);
		ckbUuTienMbasic.Name = "ckbUuTienMbasic";
		ckbUuTienMbasic.Size = new System.Drawing.Size(173, 20);
		ckbUuTienMbasic.TabIndex = 185;
		ckbUuTienMbasic.Text = "Ưu tiên chạy bằng mbasic";
		ckbUuTienMbasic.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(668, 502);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDPhanHoiBinhLuan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(EB3B3C1A_Load);
		FB3D9920.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plCommentText.ResumeLayout(false);
		plCommentText.PerformLayout();
		panel3.ResumeLayout(false);
		panel3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongUidFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)BD96E7B8).EndInit();
		D3B2AF26.ResumeLayout(false);
		D3B2AF26.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudTimeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)F300CA24).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		EA38D183.ResumeLayout(false);
		plInteract.ResumeLayout(false);
		plInteract.PerformLayout();
		panel7.ResumeLayout(false);
		panel7.PerformLayout();
		ResumeLayout(false);
	}
}
