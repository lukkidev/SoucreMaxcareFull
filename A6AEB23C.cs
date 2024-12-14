using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class A6AEB23C : Form
{
	private GClass11 FF23C0BB;

	private string C4BA928A;

	private string string_0;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private List<CheckBox> E025E60C;

	private IContainer F2A15F2B = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown A28CF436;

	private NumericUpDown nudSoLuongBaiVietTo;

	private NumericUpDown nudDelayFrom;

	private NumericUpDown nudSoLuongBaiVietFrom;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label label3;

	private Label label5;

	private Label CD25C43C;

	private Button btnCancel;

	private Button F38E9100;

	private BunifuCards bunifuCards1;

	private Panel C98EA995;

	private Button FD3D5732;

	private PictureBox B703D837;

	private BunifuCustomLabel CC953FAB;

	private Panel plComment;

	private Label D53452A8;

	private CheckBox ckbComment;

	private CheckBox BC3AB01A;

	private CheckBox ckbShareWall;

	private Label label49;

	private NumericUpDown nudSoLuongUidFrom;

	private Label label19;

	private NumericUpDown BF252DA5;

	private Label FC95B188;

	private RichTextBox txtUid;

	private Panel plAnh;

	private CheckBox ckbSendAnh;

	private RichTextBox E9956007;

	private CheckBox ckbTuDongXoaUid;

	private TextBox txtAnh;

	private Label F312F7B6;

	private CheckBox AB06DBA9;

	private Button C0175C82;

	private Button btnUp;

	private Panel panel2;

	private NumericUpDown nudBoQuaTo;

	private NumericUpDown nudBoQuaFrom;

	private Label label8;

	private Label label11;

	private CheckBox FB981CAB;

	private CheckBox ckbTuDongThamGiaNhom;

	private CheckBox ckbKhongCommentTrungBaiCu;

	private Panel plInteract;

	private CheckBox ckbGian;

	private CheckBox ckbBuon;

	private CheckBox ckbWow;

	private CheckBox ckbHaha;

	private CheckBox ckbThuong;

	private CheckBox ckbTym;

	private CheckBox A5AD450B;

	private Panel panel7;

	private RadioButton radioButton3;

	private RadioButton radioButton4;

	private Label B732229D;

	private Label AB0DF309;

	private Label lblUid;

	private ComboBox cbbTuyChonNoiDung;

	private Button F83B8E31;

	private Label FD03E382;

	private ComboBox BF8A139E;

	private CheckBox ckbRunAPI;

	private Panel plEditComment;

	private ComboBox cbbTuyChonNoiDungEdit;

	private Button A196C991;

	private Label F4BA3723;

	private RichTextBox txtCommentEdit;

	private Label DFB05A88;

	private Label label9;

	private Label B620433D;

	private NumericUpDown BF090438;

	private NumericUpDown nudDelayEditTo;

	private CheckBox ckbEditComment;

	private CheckBox ckbUuTienMbasic;

	public A6AEB23C(string string_2, int int_1 = 0, string D792A92E = "")
	{
		InitializeComponent();
		bool_0 = false;
		C4BA928A = string_2;
		string_1 = D792A92E;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Spam bài viết";
		Class147.smethod_8(text, text2);
		string text3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(D792A92E);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			F38E9100.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		FF23C0BB = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
		E025E60C = new List<CheckBox> { A5AD450B, ckbTym, ckbThuong, ckbHaha, ckbWow, ckbBuon, ckbGian };
	}

	private void A6AEB23C_Load(object sender, EventArgs e)
	{
		method_0();
		E7277E10();
		try
		{
			nudSoLuongUidFrom.Value = FF23C0BB.method_2("nudSoLuongUidFrom", 1);
			BF252DA5.Value = FF23C0BB.method_2("nudSoLuongUidTo", 1);
			nudSoLuongBaiVietFrom.Value = FF23C0BB.method_2("nudSoLuongBaiVietFrom", 1);
			nudSoLuongBaiVietTo.Value = FF23C0BB.method_2("nudSoLuongBaiVietTo", 1);
			nudDelayFrom.Value = FF23C0BB.method_2("nudDelayFrom", 3);
			A28CF436.Value = FF23C0BB.method_2("nudDelayTo", 5);
			BF8A139E.SelectedIndex = FF23C0BB.method_2("typeID", 1);
			txtUid.Text = FF23C0BB.C0288288("txtUid");
			BC3AB01A.Checked = FF23C0BB.method_3("ckbInteract");
			string text = FF23C0BB.C0288288("typeReaction", "0");
			for (int i = 0; i < E025E60C.Count; i++)
			{
				E025E60C[i].Checked = text.Split('|').Contains(i.ToString());
			}
			ckbShareWall.Checked = FF23C0BB.method_3("ckbShareWall");
			ckbRunAPI.Checked = FF23C0BB.method_3("ckbRunAPI");
			ckbComment.Checked = FF23C0BB.method_3("ckbComment");
			E9956007.Text = FF23C0BB.C0288288("txtComment");
			AB06DBA9.Checked = FF23C0BB.method_3("ckbAutoDeleteComment");
			ckbSendAnh.Checked = FF23C0BB.method_3("ckbSendAnh");
			txtAnh.Text = FF23C0BB.C0288288("txtAnh");
			ckbTuDongXoaUid.Checked = FF23C0BB.method_3("ckbTuDongXoaUid");
			ckbKhongCommentTrungBaiCu.Checked = FF23C0BB.method_3("ckbKhongCommentTrungBaiCu");
			FB981CAB.Checked = FF23C0BB.method_3("ckbBoQua");
			nudBoQuaFrom.Value = FF23C0BB.method_2("nudBoQuaFrom", 1);
			nudBoQuaTo.Value = FF23C0BB.method_2("nudBoQuaTo", 1);
			ckbTuDongThamGiaNhom.Checked = FF23C0BB.method_3("ckbTuDongThamGiaNhom");
			cbbTuyChonNoiDung.SelectedIndex = FF23C0BB.method_2("typeNganCach");
			ckbEditComment.Checked = FF23C0BB.method_3("ckbEditComment");
			BF090438.Value = FF23C0BB.method_2("nudDelayEditFrom", 1);
			nudDelayEditTo.Value = FF23C0BB.method_2("nudDelayEditTo", 1);
			txtCommentEdit.Text = FF23C0BB.C0288288("txtCommentEdit");
			cbbTuyChonNoiDungEdit.SelectedIndex = FF23C0BB.method_2("cbbTuyChonNoiDungEdit");
			ckbUuTienMbasic.Checked = FF23C0BB.method_3("ckbUuTienMbasic");
		}
		catch
		{
		}
		method_1();
	}

	private void method_0()
	{
		List<string> list_ = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		GClass8.smethod_22(cbbTuyChonNoiDung, list_);
	}

	private void E7277E10()
	{
		List<string> list_ = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		GClass8.smethod_22(cbbTuyChonNoiDungEdit, list_);
	}

	private void FD3D5732_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void BEA0F627(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongUidFrom", nudSoLuongUidFrom.Value);
		gClass.method_4("nudSoLuongUidTo", BF252DA5.Value);
		gClass.method_4("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
		gClass.method_4("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", A28CF436.Value);
		gClass.method_4("typeListUid", 0);
		gClass.method_4("typeID", BF8A139E.SelectedIndex);
		gClass.method_4("txtUid", txtUid.Text.Trim());
		gClass.method_4("ckbInteract", BC3AB01A.Checked);
		string text2 = "";
		for (int i = 0; i < E025E60C.Count; i++)
		{
			if (E025E60C[i].Checked)
			{
				text2 = text2 + i + "|";
			}
		}
		gClass.method_4("typeReaction", text2.TrimEnd('|'));
		gClass.method_4("ckbShareWall", ckbShareWall.Checked);
		gClass.method_4("ckbRunAPI", ckbRunAPI.Checked);
		gClass.method_4("ckbComment", ckbComment.Checked);
		gClass.method_4("txtComment", E9956007.Text.Trim());
		gClass.method_4("ckbAutoDeleteComment", AB06DBA9.Checked);
		gClass.method_4("ckbSendAnh", ckbSendAnh.Checked);
		gClass.method_4("txtAnh", txtAnh.Text.Trim());
		gClass.method_4("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
		gClass.method_4("ckbKhongCommentTrungBaiCu", ckbKhongCommentTrungBaiCu.Checked);
		gClass.method_4("ckbBoQua", FB981CAB.Checked);
		gClass.method_4("nudBoQuaFrom", nudBoQuaFrom.Value);
		gClass.method_4("nudBoQuaTo", nudBoQuaTo.Value);
		gClass.method_4("ckbTuDongThamGiaNhom", ckbTuDongThamGiaNhom.Checked);
		gClass.method_4("typeNganCach", cbbTuyChonNoiDung.SelectedIndex);
		gClass.method_4("ckbEditComment", ckbEditComment.Checked);
		gClass.method_4("nudDelayEditFrom", BF090438.Value);
		gClass.method_4("nudDelayEditTo", nudDelayEditTo.Value);
		gClass.method_4("txtCommentEdit", txtCommentEdit.Text.Trim());
		gClass.method_4("cbbTuyChonNoiDungEdit", cbbTuyChonNoiDungEdit.SelectedIndex);
		gClass.method_4("ckbUuTienMbasic", ckbUuTienMbasic.Checked);
		string string_ = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(C4BA928A, text, string_0, string_))
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

	private void F8372F18(object sender, EventArgs e)
	{
		GClass8.smethod_60(E9956007, D53452A8, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void method_1()
	{
		C93A7CAE(null, null);
		ckbComment_CheckedChanged(null, null);
		FB981CAB_CheckedChanged(null, null);
		ckbRunAPI_CheckedChanged(null, null);
		ckbEditComment_CheckedChanged(null, null);
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void A5BA550D(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtUid, lblUid);
	}

	private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = ckbSendAnh.Checked;
	}

	private void C0175C82_Click(object sender, EventArgs e)
	{
		plComment.Height = 436;
		base.Height = 657;
	}

	private void CD0E960D(object sender, EventArgs e)
	{
		plComment.Height = 189;
		base.Height = 491;
	}

	private void FB981CAB_CheckedChanged(object sender, EventArgs e)
	{
		panel2.Enabled = FB981CAB.Checked;
	}

	private void C93A7CAE(object sender, EventArgs e)
	{
		plInteract.Enabled = BC3AB01A.Checked;
	}

	private void cbbTuyChonNoiDung_SelectedIndexChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(E9956007, D53452A8, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void F83B8E31_Click(object sender, EventArgs e)
	{
		if (cbbTuyChonNoiDung.SelectedIndex == 0)
		{
			GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			GClass8.smethod_33(new fHelpNhapComment());
		}
		E9956007.Focus();
	}

	private void ckbRunAPI_CheckedChanged(object sender, EventArgs e)
	{
		BC3AB01A.Enabled = !ckbRunAPI.Checked;
		ckbSendAnh.Enabled = !ckbRunAPI.Checked;
		if (ckbRunAPI.Checked)
		{
			BC3AB01A.Checked = false;
			ckbSendAnh.Checked = false;
		}
	}

	private void A196C991_Click(object sender, EventArgs e)
	{
		if (cbbTuyChonNoiDungEdit.SelectedIndex == 0)
		{
			GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			GClass8.smethod_33(new fHelpNhapComment());
		}
		txtCommentEdit.Focus();
	}

	private void AE97D234(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtCommentEdit, DFB05A88, cbbTuyChonNoiDungEdit.SelectedIndex);
	}

	private void cbbTuyChonNoiDungEdit_SelectedIndexChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtCommentEdit, DFB05A88, cbbTuyChonNoiDungEdit.SelectedIndex);
	}

	private void ckbEditComment_CheckedChanged(object sender, EventArgs e)
	{
		plEditComment.Enabled = ckbEditComment.Checked;
	}

	protected override void Dispose(bool FF00C4B0)
	{
		if (FF00C4B0 && F2A15F2B != null)
		{
			F2A15F2B.Dispose();
		}
		base.Dispose(FF00C4B0);
	}

	private void InitializeComponent()
	{
		F2A15F2B = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A6AEB23C));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(F2A15F2B);
		CC953FAB = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(F2A15F2B);
		C98EA995 = new System.Windows.Forms.Panel();
		FD3D5732 = new System.Windows.Forms.Button();
		B703D837 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		plComment = new System.Windows.Forms.Panel();
		plEditComment = new System.Windows.Forms.Panel();
		cbbTuyChonNoiDungEdit = new System.Windows.Forms.ComboBox();
		A196C991 = new System.Windows.Forms.Button();
		F4BA3723 = new System.Windows.Forms.Label();
		txtCommentEdit = new System.Windows.Forms.RichTextBox();
		DFB05A88 = new System.Windows.Forms.Label();
		label9 = new System.Windows.Forms.Label();
		B620433D = new System.Windows.Forms.Label();
		BF090438 = new System.Windows.Forms.NumericUpDown();
		nudDelayEditTo = new System.Windows.Forms.NumericUpDown();
		cbbTuyChonNoiDung = new System.Windows.Forms.ComboBox();
		F83B8E31 = new System.Windows.Forms.Button();
		FD03E382 = new System.Windows.Forms.Label();
		C0175C82 = new System.Windows.Forms.Button();
		btnUp = new System.Windows.Forms.Button();
		E9956007 = new System.Windows.Forms.RichTextBox();
		D53452A8 = new System.Windows.Forms.Label();
		ckbEditComment = new System.Windows.Forms.CheckBox();
		AB06DBA9 = new System.Windows.Forms.CheckBox();
		ckbUuTienMbasic = new System.Windows.Forms.CheckBox();
		ckbRunAPI = new System.Windows.Forms.CheckBox();
		BF8A139E = new System.Windows.Forms.ComboBox();
		AB0DF309 = new System.Windows.Forms.Label();
		lblUid = new System.Windows.Forms.Label();
		plInteract = new System.Windows.Forms.Panel();
		ckbGian = new System.Windows.Forms.CheckBox();
		ckbBuon = new System.Windows.Forms.CheckBox();
		ckbWow = new System.Windows.Forms.CheckBox();
		ckbHaha = new System.Windows.Forms.CheckBox();
		ckbThuong = new System.Windows.Forms.CheckBox();
		ckbTym = new System.Windows.Forms.CheckBox();
		A5AD450B = new System.Windows.Forms.CheckBox();
		panel7 = new System.Windows.Forms.Panel();
		radioButton3 = new System.Windows.Forms.RadioButton();
		radioButton4 = new System.Windows.Forms.RadioButton();
		B732229D = new System.Windows.Forms.Label();
		ckbTuDongThamGiaNhom = new System.Windows.Forms.CheckBox();
		panel2 = new System.Windows.Forms.Panel();
		nudBoQuaTo = new System.Windows.Forms.NumericUpDown();
		nudBoQuaFrom = new System.Windows.Forms.NumericUpDown();
		label8 = new System.Windows.Forms.Label();
		label11 = new System.Windows.Forms.Label();
		FB981CAB = new System.Windows.Forms.CheckBox();
		plAnh = new System.Windows.Forms.Panel();
		txtAnh = new System.Windows.Forms.TextBox();
		F312F7B6 = new System.Windows.Forms.Label();
		ckbSendAnh = new System.Windows.Forms.CheckBox();
		txtUid = new System.Windows.Forms.RichTextBox();
		label49 = new System.Windows.Forms.Label();
		nudSoLuongUidFrom = new System.Windows.Forms.NumericUpDown();
		label19 = new System.Windows.Forms.Label();
		BF252DA5 = new System.Windows.Forms.NumericUpDown();
		FC95B188 = new System.Windows.Forms.Label();
		ckbComment = new System.Windows.Forms.CheckBox();
		ckbKhongCommentTrungBaiCu = new System.Windows.Forms.CheckBox();
		ckbTuDongXoaUid = new System.Windows.Forms.CheckBox();
		ckbShareWall = new System.Windows.Forms.CheckBox();
		BC3AB01A = new System.Windows.Forms.CheckBox();
		A28CF436 = new System.Windows.Forms.NumericUpDown();
		nudSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		nudSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label7 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		CD25C43C = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		F38E9100 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		C98EA995.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)B703D837).BeginInit();
		panel1.SuspendLayout();
		plComment.SuspendLayout();
		plEditComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)BF090438).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayEditTo).BeginInit();
		plInteract.SuspendLayout();
		panel7.SuspendLayout();
		panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudBoQuaTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudBoQuaFrom).BeginInit();
		plAnh.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongUidFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)BF252DA5).BeginInit();
		((System.ComponentModel.ISupportInitialize)A28CF436).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = CC953FAB;
		bunifuDragControl_0.Vertical = true;
		CC953FAB.BackColor = System.Drawing.Color.Transparent;
		CC953FAB.Cursor = System.Windows.Forms.Cursors.SizeAll;
		CC953FAB.Dock = System.Windows.Forms.DockStyle.Fill;
		CC953FAB.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CC953FAB.ForeColor = System.Drawing.Color.Black;
		CC953FAB.Location = new System.Drawing.Point(0, 0);
		CC953FAB.Name = "bunifuCustomLabel1";
		CC953FAB.Size = new System.Drawing.Size(663, 31);
		CC953FAB.TabIndex = 12;
		CC953FAB.Text = "Cấu hình Spam bài viết";
		CC953FAB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = C98EA995;
		bunifuDragControl_1.Vertical = true;
		C98EA995.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		C98EA995.BackColor = System.Drawing.Color.White;
		C98EA995.Controls.Add(FD3D5732);
		C98EA995.Controls.Add(B703D837);
		C98EA995.Controls.Add(CC953FAB);
		C98EA995.Cursor = System.Windows.Forms.Cursors.SizeAll;
		C98EA995.Location = new System.Drawing.Point(0, 3);
		C98EA995.Name = "pnlHeader";
		C98EA995.Size = new System.Drawing.Size(663, 31);
		C98EA995.TabIndex = 9;
		FD3D5732.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		FD3D5732.Cursor = System.Windows.Forms.Cursors.Hand;
		FD3D5732.FlatAppearance.BorderSize = 0;
		FD3D5732.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		FD3D5732.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		FD3D5732.ForeColor = System.Drawing.Color.White;
		FD3D5732.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		FD3D5732.Location = new System.Drawing.Point(632, 1);
		FD3D5732.Name = "button1";
		FD3D5732.Size = new System.Drawing.Size(30, 30);
		FD3D5732.TabIndex = 77;
		FD3D5732.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		FD3D5732.UseVisualStyleBackColor = true;
		FD3D5732.Click += new System.EventHandler(FD3D5732_Click);
		B703D837.Cursor = System.Windows.Forms.Cursors.Default;
		B703D837.Image = C50FB39E.Bitmap_5;
		B703D837.Location = new System.Drawing.Point(3, 2);
		B703D837.Name = "pictureBox1";
		B703D837.Size = new System.Drawing.Size(34, 27);
		B703D837.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		B703D837.TabIndex = 76;
		B703D837.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(plComment);
		panel1.Controls.Add(ckbUuTienMbasic);
		panel1.Controls.Add(ckbRunAPI);
		panel1.Controls.Add(BF8A139E);
		panel1.Controls.Add(AB0DF309);
		panel1.Controls.Add(lblUid);
		panel1.Controls.Add(plInteract);
		panel1.Controls.Add(ckbTuDongThamGiaNhom);
		panel1.Controls.Add(panel2);
		panel1.Controls.Add(FB981CAB);
		panel1.Controls.Add(plAnh);
		panel1.Controls.Add(ckbSendAnh);
		panel1.Controls.Add(txtUid);
		panel1.Controls.Add(label49);
		panel1.Controls.Add(nudSoLuongUidFrom);
		panel1.Controls.Add(label19);
		panel1.Controls.Add(BF252DA5);
		panel1.Controls.Add(FC95B188);
		panel1.Controls.Add(ckbComment);
		panel1.Controls.Add(ckbKhongCommentTrungBaiCu);
		panel1.Controls.Add(ckbTuDongXoaUid);
		panel1.Controls.Add(ckbShareWall);
		panel1.Controls.Add(BC3AB01A);
		panel1.Controls.Add(A28CF436);
		panel1.Controls.Add(nudSoLuongBaiVietTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(nudSoLuongBaiVietFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(CD25C43C);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(F38E9100);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(666, 518);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(plEditComment);
		plComment.Controls.Add(cbbTuyChonNoiDung);
		plComment.Controls.Add(F83B8E31);
		plComment.Controls.Add(FD03E382);
		plComment.Controls.Add(C0175C82);
		plComment.Controls.Add(btnUp);
		plComment.Controls.Add(E9956007);
		plComment.Controls.Add(D53452A8);
		plComment.Controls.Add(ckbEditComment);
		plComment.Controls.Add(AB06DBA9);
		plComment.Location = new System.Drawing.Point(320, 163);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(313, 216);
		plComment.TabIndex = 10;
		plEditComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plEditComment.Controls.Add(cbbTuyChonNoiDungEdit);
		plEditComment.Controls.Add(A196C991);
		plEditComment.Controls.Add(F4BA3723);
		plEditComment.Controls.Add(txtCommentEdit);
		plEditComment.Controls.Add(DFB05A88);
		plEditComment.Controls.Add(label9);
		plEditComment.Controls.Add(B620433D);
		plEditComment.Controls.Add(BF090438);
		plEditComment.Controls.Add(nudDelayEditTo);
		plEditComment.Location = new System.Drawing.Point(7, 254);
		plEditComment.Name = "plEditComment";
		plEditComment.Size = new System.Drawing.Size(298, 218);
		plEditComment.TabIndex = 196;
		cbbTuyChonNoiDungEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		cbbTuyChonNoiDungEdit.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTuyChonNoiDungEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTuyChonNoiDungEdit.FormattingEnabled = true;
		cbbTuyChonNoiDungEdit.Location = new System.Drawing.Point(69, 186);
		cbbTuyChonNoiDungEdit.Name = "cbbTuyChonNoiDungEdit";
		cbbTuyChonNoiDungEdit.Size = new System.Drawing.Size(189, 24);
		cbbTuyChonNoiDungEdit.TabIndex = 195;
		cbbTuyChonNoiDungEdit.SelectedIndexChanged += new System.EventHandler(cbbTuyChonNoiDungEdit_SelectedIndexChanged);
		A196C991.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		A196C991.Cursor = System.Windows.Forms.Cursors.Hand;
		A196C991.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A196C991.Location = new System.Drawing.Point(264, 185);
		A196C991.Name = "button2";
		A196C991.Size = new System.Drawing.Size(26, 26);
		A196C991.TabIndex = 194;
		A196C991.Text = "?";
		A196C991.UseVisualStyleBackColor = true;
		A196C991.Click += new System.EventHandler(A196C991_Click);
		F4BA3723.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		F4BA3723.AutoSize = true;
		F4BA3723.Location = new System.Drawing.Point(3, 189);
		F4BA3723.Name = "label4";
		F4BA3723.Size = new System.Drawing.Size(64, 16);
		F4BA3723.TabIndex = 193;
		F4BA3723.Text = "Tùy chọn:";
		txtCommentEdit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtCommentEdit.Location = new System.Drawing.Point(7, 53);
		txtCommentEdit.Name = "txtCommentEdit";
		txtCommentEdit.Size = new System.Drawing.Size(283, 128);
		txtCommentEdit.TabIndex = 1;
		txtCommentEdit.Text = "";
		txtCommentEdit.WordWrap = false;
		txtCommentEdit.TextChanged += new System.EventHandler(AE97D234);
		DFB05A88.AutoSize = true;
		DFB05A88.Location = new System.Drawing.Point(4, 32);
		DFB05A88.Name = "lblCommentEdit";
		DFB05A88.Size = new System.Drawing.Size(139, 16);
		DFB05A88.TabIndex = 0;
		DFB05A88.Text = "Nội dung bình luận (0):";
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(4, 6);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(92, 16);
		label9.TabIndex = 34;
		label9.Text = "Delay time (s):";
		B620433D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B620433D.Location = new System.Drawing.Point(170, 6);
		B620433D.Name = "label13";
		B620433D.Size = new System.Drawing.Size(29, 16);
		B620433D.TabIndex = 38;
		B620433D.Text = ">";
		B620433D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		BF090438.Location = new System.Drawing.Point(102, 4);
		BF090438.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		BF090438.Name = "nudDelayEditFrom";
		BF090438.Size = new System.Drawing.Size(56, 23);
		BF090438.TabIndex = 5;
		nudDelayEditTo.Location = new System.Drawing.Point(209, 4);
		nudDelayEditTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayEditTo.Name = "nudDelayEditTo";
		nudDelayEditTo.Size = new System.Drawing.Size(56, 23);
		nudDelayEditTo.TabIndex = 6;
		cbbTuyChonNoiDung.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		cbbTuyChonNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTuyChonNoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTuyChonNoiDung.FormattingEnabled = true;
		cbbTuyChonNoiDung.Location = new System.Drawing.Point(69, 158);
		cbbTuyChonNoiDung.Name = "cbbTuyChonNoiDung";
		cbbTuyChonNoiDung.Size = new System.Drawing.Size(204, 24);
		cbbTuyChonNoiDung.TabIndex = 195;
		cbbTuyChonNoiDung.SelectedIndexChanged += new System.EventHandler(cbbTuyChonNoiDung_SelectedIndexChanged);
		F83B8E31.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		F83B8E31.Cursor = System.Windows.Forms.Cursors.Hand;
		F83B8E31.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F83B8E31.Location = new System.Drawing.Point(279, 157);
		F83B8E31.Name = "btnHuongDanNhapNoiDung";
		F83B8E31.Size = new System.Drawing.Size(26, 26);
		F83B8E31.TabIndex = 194;
		F83B8E31.Text = "?";
		F83B8E31.UseVisualStyleBackColor = true;
		F83B8E31.Click += new System.EventHandler(F83B8E31_Click);
		FD03E382.AutoSize = true;
		FD03E382.Location = new System.Drawing.Point(3, 161);
		FD03E382.Name = "label2";
		FD03E382.Size = new System.Drawing.Size(64, 16);
		FD03E382.TabIndex = 193;
		FD03E382.Text = "Tùy chọn:";
		C0175C82.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		C0175C82.BackgroundImage = C50FB39E.Bitmap_89;
		C0175C82.Cursor = System.Windows.Forms.Cursors.Hand;
		C0175C82.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		C0175C82.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C0175C82.Location = new System.Drawing.Point(256, -1);
		C0175C82.Name = "btnDown";
		C0175C82.Size = new System.Drawing.Size(25, 25);
		C0175C82.TabIndex = 191;
		C0175C82.Visible = false;
		C0175C82.Click += new System.EventHandler(C0175C82_Click);
		btnUp.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		btnUp.BackgroundImage = C50FB39E.Bitmap_74;
		btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnUp.Location = new System.Drawing.Point(287, -1);
		btnUp.Name = "btnUp";
		btnUp.Size = new System.Drawing.Size(25, 25);
		btnUp.TabIndex = 192;
		btnUp.Visible = false;
		btnUp.Click += new System.EventHandler(CD0E960D);
		E9956007.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		E9956007.Location = new System.Drawing.Point(7, 25);
		E9956007.Name = "txtComment";
		E9956007.Size = new System.Drawing.Size(298, 128);
		E9956007.TabIndex = 1;
		E9956007.Text = "";
		E9956007.WordWrap = false;
		E9956007.TextChanged += new System.EventHandler(F8372F18);
		D53452A8.AutoSize = true;
		D53452A8.Location = new System.Drawing.Point(3, 5);
		D53452A8.Name = "lblComment";
		D53452A8.Size = new System.Drawing.Size(139, 16);
		D53452A8.TabIndex = 0;
		D53452A8.Text = "Nội dung bình luận (0):";
		ckbEditComment.AutoSize = true;
		ckbEditComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbEditComment.Location = new System.Drawing.Point(7, 232);
		ckbEditComment.Name = "ckbEditComment";
		ckbEditComment.Size = new System.Drawing.Size(159, 20);
		ckbEditComment.TabIndex = 8;
		ckbEditComment.Text = "Sửa nội dung comment";
		ckbEditComment.UseVisualStyleBackColor = true;
		ckbEditComment.CheckedChanged += new System.EventHandler(ckbEditComment_CheckedChanged);
		AB06DBA9.AutoSize = true;
		AB06DBA9.Cursor = System.Windows.Forms.Cursors.Hand;
		AB06DBA9.Location = new System.Drawing.Point(7, 188);
		AB06DBA9.Name = "ckbAutoDeleteComment";
		AB06DBA9.Size = new System.Drawing.Size(169, 20);
		AB06DBA9.TabIndex = 8;
		AB06DBA9.Text = "Xóa nội dung đã sư\u0309 du\u0323ng";
		AB06DBA9.UseVisualStyleBackColor = true;
		ckbUuTienMbasic.AutoSize = true;
		ckbUuTienMbasic.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbUuTienMbasic.Location = new System.Drawing.Point(320, 445);
		ckbUuTienMbasic.Name = "ckbUuTienMbasic";
		ckbUuTienMbasic.Size = new System.Drawing.Size(173, 20);
		ckbUuTienMbasic.TabIndex = 197;
		ckbUuTienMbasic.Text = "Ưu tiên chạy bằng mbasic";
		ckbUuTienMbasic.UseVisualStyleBackColor = true;
		ckbRunAPI.AutoSize = true;
		ckbRunAPI.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbRunAPI.Location = new System.Drawing.Point(448, 141);
		ckbRunAPI.Name = "ckbRunAPI";
		ckbRunAPI.Size = new System.Drawing.Size(99, 20);
		ckbRunAPI.TabIndex = 196;
		ckbRunAPI.Text = "Run API (ẩn)";
		ckbRunAPI.UseVisualStyleBackColor = true;
		ckbRunAPI.CheckedChanged += new System.EventHandler(ckbRunAPI_CheckedChanged);
		BF8A139E.Cursor = System.Windows.Forms.Cursors.Hand;
		BF8A139E.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		BF8A139E.FormattingEnabled = true;
		BF8A139E.Items.AddRange(new object[3] { "Profile", "Group", "Page" });
		BF8A139E.Location = new System.Drawing.Point(135, 166);
		BF8A139E.Name = "cbbLoaiDoiTuong";
		BF8A139E.Size = new System.Drawing.Size(153, 24);
		BF8A139E.TabIndex = 195;
		AB0DF309.AutoSize = true;
		AB0DF309.Location = new System.Drawing.Point(27, 169);
		AB0DF309.Name = "label10";
		AB0DF309.Size = new System.Drawing.Size(93, 16);
		AB0DF309.TabIndex = 186;
		AB0DF309.Text = "Loại đối tượng:";
		lblUid.AutoSize = true;
		lblUid.Location = new System.Drawing.Point(27, 193);
		lblUid.Name = "lblUid";
		lblUid.Size = new System.Drawing.Size(140, 16);
		lblUid.TabIndex = 182;
		lblUid.Text = "Nhập danh sách ID (0):";
		plInteract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plInteract.Controls.Add(ckbGian);
		plInteract.Controls.Add(ckbBuon);
		plInteract.Controls.Add(ckbWow);
		plInteract.Controls.Add(ckbHaha);
		plInteract.Controls.Add(ckbThuong);
		plInteract.Controls.Add(ckbTym);
		plInteract.Controls.Add(A5AD450B);
		plInteract.Controls.Add(panel7);
		plInteract.Controls.Add(B732229D);
		plInteract.Location = new System.Drawing.Point(320, 102);
		plInteract.Name = "plInteract";
		plInteract.Size = new System.Drawing.Size(312, 33);
		plInteract.TabIndex = 181;
		ckbGian.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbGian.Image = C50FB39E.ABB95605;
		ckbGian.Location = new System.Drawing.Point(266, 1);
		ckbGian.Name = "ckbGian";
		ckbGian.Size = new System.Drawing.Size(40, 30);
		ckbGian.TabIndex = 179;
		ckbGian.UseVisualStyleBackColor = true;
		ckbBuon.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbBuon.Image = C50FB39E.Bitmap_163;
		ckbBuon.Location = new System.Drawing.Point(222, 1);
		ckbBuon.Name = "ckbBuon";
		ckbBuon.Size = new System.Drawing.Size(40, 30);
		ckbBuon.TabIndex = 178;
		ckbBuon.UseVisualStyleBackColor = true;
		ckbWow.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbWow.Image = C50FB39E.F10C2BBC;
		ckbWow.Location = new System.Drawing.Point(178, 1);
		ckbWow.Name = "ckbWow";
		ckbWow.Size = new System.Drawing.Size(40, 30);
		ckbWow.TabIndex = 177;
		ckbWow.UseVisualStyleBackColor = true;
		ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHaha.Image = C50FB39E.Bitmap_47;
		ckbHaha.Location = new System.Drawing.Point(134, 1);
		ckbHaha.Name = "ckbHaha";
		ckbHaha.Size = new System.Drawing.Size(40, 30);
		ckbHaha.TabIndex = 176;
		ckbHaha.UseVisualStyleBackColor = true;
		ckbThuong.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbThuong.Image = C50FB39E.Bitmap_14;
		ckbThuong.Location = new System.Drawing.Point(90, 1);
		ckbThuong.Name = "ckbThuong";
		ckbThuong.Size = new System.Drawing.Size(40, 30);
		ckbThuong.TabIndex = 175;
		ckbThuong.UseVisualStyleBackColor = true;
		ckbTym.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTym.Image = C50FB39E.Bitmap_153;
		ckbTym.Location = new System.Drawing.Point(46, 1);
		ckbTym.Name = "ckbTym";
		ckbTym.Size = new System.Drawing.Size(40, 30);
		ckbTym.TabIndex = 174;
		ckbTym.UseVisualStyleBackColor = true;
		A5AD450B.Checked = true;
		A5AD450B.CheckState = System.Windows.Forms.CheckState.Checked;
		A5AD450B.Cursor = System.Windows.Forms.Cursors.Hand;
		A5AD450B.Image = C50FB39E.F2069B3C;
		A5AD450B.Location = new System.Drawing.Point(2, 1);
		A5AD450B.Name = "ckbLike";
		A5AD450B.Size = new System.Drawing.Size(40, 30);
		A5AD450B.TabIndex = 173;
		A5AD450B.UseVisualStyleBackColor = true;
		panel7.Controls.Add(radioButton3);
		panel7.Controls.Add(radioButton4);
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
		radioButton4.AutoSize = true;
		radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
		radioButton4.Location = new System.Drawing.Point(3, 23);
		radioButton4.Name = "radioButton4";
		radioButton4.Size = new System.Drawing.Size(200, 20);
		radioButton4.TabIndex = 3;
		radioButton4.Text = "Comment ngẫu nhiên nội dung";
		radioButton4.UseVisualStyleBackColor = true;
		B732229D.AutoSize = true;
		B732229D.Location = new System.Drawing.Point(4, 302);
		B732229D.Name = "label26";
		B732229D.Size = new System.Drawing.Size(64, 16);
		B732229D.TabIndex = 2;
		B732229D.Text = "Tùy chọn:";
		ckbTuDongThamGiaNhom.AutoSize = true;
		ckbTuDongThamGiaNhom.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuDongThamGiaNhom.Location = new System.Drawing.Point(320, 445);
		ckbTuDongThamGiaNhom.Name = "ckbTuDongThamGiaNhom";
		ckbTuDongThamGiaNhom.Size = new System.Drawing.Size(286, 20);
		ckbTuDongThamGiaNhom.TabIndex = 167;
		ckbTuDongThamGiaNhom.Text = "Tự động tham gia nhóm (Nếu chưa tham gia)";
		ckbTuDongThamGiaNhom.UseVisualStyleBackColor = true;
		ckbTuDongThamGiaNhom.Visible = false;
		panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel2.Controls.Add(nudBoQuaTo);
		panel2.Controls.Add(nudBoQuaFrom);
		panel2.Controls.Add(label8);
		panel2.Controls.Add(label11);
		panel2.Location = new System.Drawing.Point(97, 410);
		panel2.Name = "panel2";
		panel2.Size = new System.Drawing.Size(191, 29);
		panel2.TabIndex = 166;
		nudBoQuaTo.Location = new System.Drawing.Point(72, 2);
		nudBoQuaTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudBoQuaTo.Name = "nudBoQuaTo";
		nudBoQuaTo.Size = new System.Drawing.Size(35, 23);
		nudBoQuaTo.TabIndex = 40;
		nudBoQuaFrom.Location = new System.Drawing.Point(2, 2);
		nudBoQuaFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudBoQuaFrom.Name = "nudBoQuaFrom";
		nudBoQuaFrom.Size = new System.Drawing.Size(35, 23);
		nudBoQuaFrom.TabIndex = 39;
		label8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label8.Location = new System.Drawing.Point(39, 4);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(29, 16);
		label8.TabIndex = 42;
		label8.Text = ">";
		label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(113, 4);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(73, 16);
		label11.TabIndex = 41;
		label11.Text = "bài viết đầu";
		FB981CAB.AutoSize = true;
		FB981CAB.Cursor = System.Windows.Forms.Cursors.Hand;
		FB981CAB.Location = new System.Drawing.Point(31, 414);
		FB981CAB.Name = "ckbBoQua";
		FB981CAB.Size = new System.Drawing.Size(70, 20);
		FB981CAB.TabIndex = 164;
		FB981CAB.Text = "Bỏ qua:";
		FB981CAB.UseVisualStyleBackColor = true;
		FB981CAB.CheckedChanged += new System.EventHandler(FB981CAB_CheckedChanged);
		plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plAnh.Controls.Add(txtAnh);
		plAnh.Controls.Add(F312F7B6);
		plAnh.Enabled = false;
		plAnh.Location = new System.Drawing.Point(320, 408);
		plAnh.Name = "plAnh";
		plAnh.Size = new System.Drawing.Size(313, 31);
		plAnh.TabIndex = 162;
		txtAnh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtAnh.Location = new System.Drawing.Point(90, 3);
		txtAnh.Name = "txtAnh";
		txtAnh.Size = new System.Drawing.Size(218, 23);
		txtAnh.TabIndex = 159;
		F312F7B6.AutoSize = true;
		F312F7B6.Location = new System.Drawing.Point(3, 6);
		F312F7B6.Name = "label12";
		F312F7B6.Size = new System.Drawing.Size(73, 16);
		F312F7B6.TabIndex = 158;
		F312F7B6.Text = "Folder ảnh:";
		ckbSendAnh.AutoSize = true;
		ckbSendAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbSendAnh.Location = new System.Drawing.Point(320, 385);
		ckbSendAnh.Name = "ckbSendAnh";
		ckbSendAnh.Size = new System.Drawing.Size(103, 20);
		ckbSendAnh.TabIndex = 161;
		ckbSendAnh.Text = "Bình luận ảnh";
		ckbSendAnh.UseVisualStyleBackColor = true;
		ckbSendAnh.CheckedChanged += new System.EventHandler(ckbSendAnh_CheckedChanged);
		txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtUid.Location = new System.Drawing.Point(31, 212);
		txtUid.Name = "txtUid";
		txtUid.Size = new System.Drawing.Size(257, 167);
		txtUid.TabIndex = 117;
		txtUid.Text = "";
		txtUid.WordWrap = false;
		txtUid.TextChanged += new System.EventHandler(A5BA550D);
		label49.AutoSize = true;
		label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label49.Location = new System.Drawing.Point(27, 81);
		label49.Name = "label49";
		label49.Size = new System.Drawing.Size(79, 16);
		label49.TabIndex = 92;
		label49.Text = "Sô\u0301 lươ\u0323ng ID:";
		nudSoLuongUidFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudSoLuongUidFrom.Location = new System.Drawing.Point(135, 79);
		nudSoLuongUidFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongUidFrom.Name = "nudSoLuongUidFrom";
		nudSoLuongUidFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongUidFrom.TabIndex = 1;
		nudSoLuongUidFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		label19.AutoSize = true;
		label19.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label19.Location = new System.Drawing.Point(27, 110);
		label19.Name = "label19";
		label19.Size = new System.Drawing.Size(89, 16);
		label19.TabIndex = 101;
		label19.Text = "Sô\u0301 ba\u0300i viết/ID:";
		BF252DA5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		BF252DA5.Location = new System.Drawing.Point(232, 79);
		BF252DA5.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		BF252DA5.Name = "nudSoLuongUidTo";
		BF252DA5.Size = new System.Drawing.Size(56, 23);
		BF252DA5.TabIndex = 2;
		BF252DA5.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		FC95B188.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		FC95B188.Location = new System.Drawing.Point(197, 81);
		FC95B188.Name = "label66";
		FC95B188.Size = new System.Drawing.Size(29, 16);
		FC95B188.TabIndex = 105;
		FC95B188.Text = ">";
		FC95B188.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		ckbComment.AutoSize = true;
		ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbComment.Location = new System.Drawing.Point(320, 141);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new System.Drawing.Size(127, 20);
		ckbComment.TabIndex = 9;
		ckbComment.Text = "Bi\u0300nh luâ\u0323n văn bản";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		ckbKhongCommentTrungBaiCu.AutoSize = true;
		ckbKhongCommentTrungBaiCu.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbKhongCommentTrungBaiCu.Location = new System.Drawing.Point(31, 445);
		ckbKhongCommentTrungBaiCu.Name = "ckbKhongCommentTrungBaiCu";
		ckbKhongCommentTrungBaiCu.Size = new System.Drawing.Size(190, 20);
		ckbKhongCommentTrungBaiCu.TabIndex = 8;
		ckbKhongCommentTrungBaiCu.Text = "Không comment trùng bài cũ";
		ckbKhongCommentTrungBaiCu.UseVisualStyleBackColor = true;
		ckbTuDongXoaUid.AutoSize = true;
		ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuDongXoaUid.Location = new System.Drawing.Point(31, 386);
		ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		ckbTuDongXoaUid.Size = new System.Drawing.Size(190, 20);
		ckbTuDongXoaUid.TabIndex = 8;
		ckbTuDongXoaUid.Text = "Tự động xóa ID đã tương tác";
		ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		ckbShareWall.AutoSize = true;
		ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbShareWall.Location = new System.Drawing.Point(553, 141);
		ckbShareWall.Name = "ckbShareWall";
		ckbShareWall.Size = new System.Drawing.Size(87, 20);
		ckbShareWall.TabIndex = 8;
		ckbShareWall.Text = "Share wall";
		ckbShareWall.UseVisualStyleBackColor = true;
		BC3AB01A.AutoSize = true;
		BC3AB01A.Cursor = System.Windows.Forms.Cursors.Hand;
		BC3AB01A.Location = new System.Drawing.Point(321, 80);
		BC3AB01A.Name = "ckbInteract";
		BC3AB01A.Size = new System.Drawing.Size(99, 20);
		BC3AB01A.TabIndex = 7;
		BC3AB01A.Text = "Thả cảm xúc";
		BC3AB01A.UseVisualStyleBackColor = true;
		BC3AB01A.CheckedChanged += new System.EventHandler(C93A7CAE);
		A28CF436.Location = new System.Drawing.Point(232, 137);
		A28CF436.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		A28CF436.Name = "nudDelayTo";
		A28CF436.Size = new System.Drawing.Size(56, 23);
		A28CF436.TabIndex = 6;
		nudSoLuongBaiVietTo.Location = new System.Drawing.Point(232, 108);
		nudSoLuongBaiVietTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBaiVietTo.Name = "nudSoLuongBaiVietTo";
		nudSoLuongBaiVietTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongBaiVietTo.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(135, 137);
		nudDelayFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 5;
		nudSoLuongBaiVietFrom.Location = new System.Drawing.Point(135, 108);
		nudSoLuongBaiVietFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBaiVietFrom.Name = "nudSoLuongBaiVietFrom";
		nudSoLuongBaiVietFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongBaiVietFrom.TabIndex = 3;
		txtTenHanhDong.Location = new System.Drawing.Point(135, 50);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(153, 23);
		txtTenHanhDong.TabIndex = 0;
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label7.Location = new System.Drawing.Point(197, 139);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = ">";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(197, 110);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = ">";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 139);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(87, 16);
		label5.TabIndex = 34;
		label5.Text = "Gia\u0303n ca\u0301ch (s):";
		CD25C43C.AutoSize = true;
		CD25C43C.Location = new System.Drawing.Point(27, 53);
		CD25C43C.Name = "label1";
		CD25C43C.Size = new System.Drawing.Size(98, 16);
		CD25C43C.TabIndex = 31;
		CD25C43C.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(310, 476);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 12;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		F38E9100.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		F38E9100.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		F38E9100.Cursor = System.Windows.Forms.Cursors.Hand;
		F38E9100.FlatAppearance.BorderSize = 0;
		F38E9100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		F38E9100.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F38E9100.ForeColor = System.Drawing.Color.White;
		F38E9100.Location = new System.Drawing.Point(203, 476);
		F38E9100.Name = "btnAdd";
		F38E9100.Size = new System.Drawing.Size(92, 29);
		F38E9100.TabIndex = 11;
		F38E9100.Text = "Thêm";
		F38E9100.UseVisualStyleBackColor = false;
		F38E9100.Click += new System.EventHandler(BEA0F627);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(C98EA995);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(663, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(666, 518);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDSpamBaiViet";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(A6AEB23C_Load);
		C98EA995.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)B703D837).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		plEditComment.ResumeLayout(false);
		plEditComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)BF090438).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayEditTo).EndInit();
		plInteract.ResumeLayout(false);
		plInteract.PerformLayout();
		panel7.ResumeLayout(false);
		panel7.PerformLayout();
		panel2.ResumeLayout(false);
		panel2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudBoQuaTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudBoQuaFrom).EndInit();
		plAnh.ResumeLayout(false);
		plAnh.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongUidFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)BF252DA5).EndInit();
		((System.ComponentModel.ISupportInitialize)A28CF436).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
