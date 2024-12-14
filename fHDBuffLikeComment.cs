using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDBuffLikeComment : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string string_1;

	private string A82694A9;

	private int int_0;

	public static bool bool_0;

	private List<CheckBox> list_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label label5;

	private Label DD37038A;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel DA06A4A6;

	private CheckBox DB1DFE18;

	private Label label2;

	private NumericUpDown nudTimeTo;

	private NumericUpDown nudTimeFrom;

	private Label label9;

	private Label label3;

	private Panel plCommentText;

	private RichTextBox AAA5AE20;

	private Label lblComment;

	private Panel plAnh;

	private TextBox txtAnh;

	private RichTextBox C988E5B6;

	private CheckBox ckbSendAnh;

	private CheckBox E2805E1A;

	private Label label12;

	private Label label49;

	private NumericUpDown nudSoLuongUidFrom;

	private NumericUpDown nudSoLuongUidTo;

	private Label D7923A37;

	private RadioButton B0BABB92;

	private RadioButton rbCommentTheoThuTu;

	private Label label13;

	private Button btnDown;

	private Button btnUp;

	private Panel panel3;

	private CheckBox ckbAutoDeleteComment;

	private Panel plTag;

	private NumericUpDown nudSoLuongTagTo;

	private Label label16;

	private NumericUpDown nudSoLuongTagFrom;

	private Label label14;

	private CheckBox ckbTag;

	private CheckBox ckbChiTagTenViet;

	private ComboBox cbbTuyChonNoiDung;

	private Button btnHuongDanNhapNoiDung;

	private Label label8;

	private CheckBox EB2300BC;

	private Panel panel2;

	private Panel plInteract;

	private CheckBox ckbAngry;

	private CheckBox F409E031;

	private CheckBox ckbWow;

	private CheckBox ckbHaha;

	private CheckBox ckbCare;

	private CheckBox ckbLove;

	private CheckBox ckbLike;

	private Panel panel7;

	private RadioButton radioButton3;

	private RadioButton BE92BC0A;

	private Label label26;

	private CheckBox ckbInteract;

	private Panel plContentShare;

	private ComboBox C000CD86;

	private Button button2;

	private Label E10A25AD;

	private CheckBox ckbAutoDeleteContentShare;

	private Panel panel6;

	private RadioButton radioButton1;

	private RadioButton D6BC5A82;

	private Label F0881DBF;

	private RichTextBox FD2BF70D;

	private Label EAB3D483;

	private CheckBox CBBECE1C;

	private Panel DB06920E;

	private ComboBox cbbTuyChonNoiDungEdit;

	private Button button3;

	private Label label4;

	private RichTextBox txtCommentEdit;

	private Label AA0D7399;

	private Label E5B0E71A;

	private Label B703C392;

	private NumericUpDown FDAEEB2D;

	private NumericUpDown E7093213;

	private CheckBox ckbEditComment;

	private CheckBox ckbUuTienMbasic;

	private Panel plShareMess;

	private Panel panel5;

	private RadioButton radioButton5;

	private RadioButton radioButton6;

	private Label EBA3B800;

	private RichTextBox C0B8E915;

	private Label lblContentShareMess;

	private CheckBox DD8A8300;

	private Label B80E0701;

	private Label BDB1968B;

	private Label label20;

	private NumericUpDown nudDelayMessFrom;

	private NumericUpDown nudDelayMessTo;

	private Label label21;

	private NumericUpDown nudSoLuongMessTo;

	private NumericUpDown nudSoLuongMessFrom;

	private ComboBox cbbTuyChonNoiDungShareMess;

	private Button button4;

	private Label EDB86792;

	private CheckBox ckbAutoDeleteContentShareMess;

	private Panel plDeleteComment;

	private Label label25;

	private Label CA3B1A86;

	private NumericUpDown DA245CB8;

	private NumericUpDown nudDelayDeleteTo;

	private CheckBox ckbDeleteComment;

	public fHDBuffLikeComment(string string_2, int int_1 = 0, string A9378CAB = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_2;
		A82694A9 = A9378CAB;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Tương ta\u0301c ba\u0300i viê\u0301t";
		Class147.smethod_8(text, text2);
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
			DataTable dataTable = Class147.F3057616(A9378CAB);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
		list_0 = new List<CheckBox> { ckbLike, ckbLove, ckbCare, ckbHaha, ckbWow, F409E031, ckbAngry };
	}

	private void fHDBuffLikeComment_Load(object sender, EventArgs e)
	{
		method_0();
		D5A1C68F();
		method_1();
		method_2();
		try
		{
			nudSoLuongUidFrom.Value = gclass11_0.method_2("nudSoLuongUidFrom", 1);
			nudSoLuongUidTo.Value = gclass11_0.method_2("nudSoLuongUidTo", 1);
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
			C988E5B6.Text = gclass11_0.C0288288("txtIdPost");
			EB2300BC.Checked = gclass11_0.method_3("ckbTuDongXoa");
			ckbUuTienMbasic.Checked = gclass11_0.method_3("ckbUuTienMbasic");
			nudTimeFrom.Value = gclass11_0.method_2("nudTimeFrom", 3);
			nudTimeTo.Value = gclass11_0.method_2("nudTimeTo", 5);
			ckbInteract.Checked = gclass11_0.method_3("ckbInteract");
			string text = gclass11_0.C0288288("typeReaction", "Like");
			if (GClass8.smethod_44(text.Replace("|", "")))
			{
				List<string> list = new List<string> { "Like", "Love", "Care", "Haha", "Wow", "Sad", "Angry" };
				for (int i = 0; i < list.Count; i++)
				{
					text = text.Replace(i.ToString(), list[i]);
				}
			}
			List<string> list2 = text.Split('|').ToList();
			for (int j = 0; j < list2.Count; j++)
			{
				foreach (CheckBox item in list_0)
				{
					if (item.Name.Substring(3) == list2[j])
					{
						item.Checked = true;
					}
				}
			}
			E2805E1A.Checked = gclass11_0.method_3("ckbComment");
			AAA5AE20.Text = gclass11_0.C0288288("txtComment");
			cbbTuyChonNoiDung.SelectedIndex = gclass11_0.method_2("typeNganCach");
			ckbAutoDeleteComment.Checked = gclass11_0.method_3("ckbAutoDeleteComment");
			CBBECE1C.Checked = gclass11_0.method_3("ckbRunAPI");
			ckbTag.Checked = gclass11_0.method_3("ckbTag");
			nudSoLuongTagFrom.Value = gclass11_0.method_2("nudSoLuongTagFrom", 3);
			nudSoLuongTagTo.Value = gclass11_0.method_2("nudSoLuongTagTo", 5);
			ckbChiTagTenViet.Checked = gclass11_0.method_3("ckbChiTagTenViet");
			ckbSendAnh.Checked = gclass11_0.method_3("ckbSendAnh");
			txtAnh.Text = gclass11_0.C0288288("txtAnh");
			if (gclass11_0.method_2("typeComment") == 1)
			{
				B0BABB92.Checked = true;
			}
			else
			{
				rbCommentTheoThuTu.Checked = true;
			}
			DB1DFE18.Checked = gclass11_0.method_3("ckbShareWall");
			FD2BF70D.Text = gclass11_0.C0288288("txtContentShare");
			C000CD86.SelectedIndex = gclass11_0.method_2("cbbTuyChonNoiDungShare");
			ckbAutoDeleteContentShare.Checked = gclass11_0.method_3("ckbAutoDeleteContentShare");
			DD8A8300.Checked = gclass11_0.method_3("ckbShareMess");
			nudSoLuongMessFrom.Value = gclass11_0.method_2("nudSoLuongMessFrom", 1);
			nudSoLuongMessTo.Value = gclass11_0.method_2("nudSoLuongMessTo", 1);
			nudDelayMessFrom.Value = gclass11_0.method_2("nudDelayMessFrom", 3);
			nudDelayMessTo.Value = gclass11_0.method_2("nudDelayMessTo", 5);
			C0B8E915.Text = gclass11_0.C0288288("txtContentShareMess");
			cbbTuyChonNoiDungShareMess.SelectedIndex = gclass11_0.method_2("cbbTuyChonNoiDungShareMess");
			ckbAutoDeleteContentShareMess.Checked = gclass11_0.method_3("ckbAutoDeleteContentShareMess");
			ckbDeleteComment.Checked = gclass11_0.method_3("ckbDeleteComment");
			DA245CB8.Value = gclass11_0.method_2("nudDelayDeleteFrom", 1);
			nudDelayDeleteTo.Value = gclass11_0.method_2("nudDelayDeleteTo", 1);
			ckbEditComment.Checked = gclass11_0.method_3("ckbEditComment");
			FDAEEB2D.Value = gclass11_0.method_2("nudDelayEditFrom", 1);
			E7093213.Value = gclass11_0.method_2("nudDelayEditTo", 1);
			txtCommentEdit.Text = gclass11_0.C0288288("txtCommentEdit");
			cbbTuyChonNoiDungEdit.SelectedIndex = gclass11_0.method_2("cbbTuyChonNoiDungEdit");
		}
		catch
		{
		}
		D5371386();
	}

	private void method_0()
	{
		List<string> list = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		GClass8.smethod_22(cbbTuyChonNoiDung, list);
	}

	private void D5A1C68F()
	{
		List<string> list = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		GClass8.smethod_22(cbbTuyChonNoiDungEdit, list);
	}

	private void method_1()
	{
		List<string> list = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		GClass8.smethod_22(C000CD86, list);
	}

	private void method_2()
	{
		List<string> list = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		GClass8.smethod_22(cbbTuyChonNoiDungShareMess, list);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FB8A0401(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongUidFrom", nudSoLuongUidFrom.Value);
		gClass.method_4("nudSoLuongUidTo", nudSoLuongUidTo.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		gClass.method_4("txtIdPost", C988E5B6.Text.Trim());
		gClass.method_4("ckbTuDongXoa", EB2300BC.Checked);
		gClass.method_4("ckbUuTienMbasic", ckbUuTienMbasic.Checked);
		gClass.method_4("nudTimeFrom", nudTimeFrom.Value);
		gClass.method_4("nudTimeTo", nudTimeTo.Value);
		gClass.method_4("ckbInteract", ckbInteract.Checked);
		string text2 = "";
		for (int i = 0; i < list_0.Count; i++)
		{
			if (list_0[i].Checked)
			{
				text2 = text2 + list_0[i].Name.Substring(3) + "|";
			}
		}
		gClass.method_4("typeReaction", text2.TrimEnd('|'));
		gClass.method_4("ckbComment", E2805E1A.Checked);
		gClass.method_4("txtComment", AAA5AE20.Text.Trim());
		gClass.method_4("typeNganCach", cbbTuyChonNoiDung.SelectedIndex);
		gClass.method_4("ckbAutoDeleteComment", ckbAutoDeleteComment.Checked);
		gClass.method_4("ckbRunAPI", CBBECE1C.Checked);
		gClass.method_4("ckbTag", ckbTag.Checked);
		gClass.method_4("nudSoLuongTagFrom", nudSoLuongTagFrom.Value);
		gClass.method_4("nudSoLuongTagTo", nudSoLuongTagTo.Value);
		gClass.method_4("ckbChiTagTenViet", ckbChiTagTenViet.Checked);
		gClass.method_4("ckbSendAnh", ckbSendAnh.Checked);
		gClass.method_4("txtAnh", txtAnh.Text.Trim());
		int num = 0;
		if (B0BABB92.Checked)
		{
			num = 1;
		}
		gClass.method_4("typeComment", num);
		gClass.method_4("ckbShareWall", DB1DFE18.Checked);
		gClass.method_4("txtContentShare", FD2BF70D.Text.Trim());
		gClass.method_4("cbbTuyChonNoiDungShare", C000CD86.SelectedIndex);
		gClass.method_4("ckbAutoDeleteContentShare", ckbAutoDeleteContentShare.Checked);
		gClass.method_4("ckbShareMess", DD8A8300.Checked);
		gClass.method_4("nudSoLuongMessFrom", nudSoLuongMessFrom.Value);
		gClass.method_4("nudSoLuongMessTo", nudSoLuongMessTo.Value);
		gClass.method_4("nudDelayMessFrom", nudDelayMessFrom.Value);
		gClass.method_4("nudDelayMessTo", nudDelayMessTo.Value);
		gClass.method_4("txtContentShareMess", C0B8E915.Text.Trim());
		gClass.method_4("cbbTuyChonNoiDungShareMess", cbbTuyChonNoiDungShareMess.SelectedIndex);
		gClass.method_4("ckbAutoDeleteContentShareMess", ckbAutoDeleteContentShareMess.Checked);
		gClass.method_4("ckbDeleteComment", ckbDeleteComment.Checked);
		gClass.method_4("nudDelayDeleteFrom", DA245CB8.Value);
		gClass.method_4("nudDelayDeleteTo", nudDelayDeleteTo.Value);
		gClass.method_4("ckbEditComment", ckbEditComment.Checked);
		gClass.method_4("nudDelayEditFrom", FDAEEB2D.Value);
		gClass.method_4("nudDelayEditTo", E7093213.Value);
		gClass.method_4("txtCommentEdit", txtCommentEdit.Text.Trim());
		gClass.method_4("cbbTuyChonNoiDungEdit", cbbTuyChonNoiDungEdit.SelectedIndex);
		string string_ = gClass.method_7();
		if (int_0 == 0)
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
			if (Class147.smethod_13(A82694A9, text, string_))
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

	private void AAA5AE20_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(AAA5AE20, lblComment, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void D5371386()
	{
		ckbInteract_CheckedChanged(null, null);
		E2805E1A_CheckedChanged(null, null);
		ckbTag_CheckedChanged(null, null);
		AAA5AE20_TextChanged(null, null);
		CBBECE1C_CheckedChanged(null, null);
		DB1DFE18_CheckedChanged(null, null);
		B18FF180(null, null);
		DD8A8300_CheckedChanged(null, null);
		ckbDeleteComment_CheckedChanged(null, null);
	}

	private void ckbInteract_CheckedChanged(object sender, EventArgs e)
	{
		plInteract.Enabled = ckbInteract.Checked;
	}

	private void E2805E1A_CheckedChanged(object sender, EventArgs e)
	{
		plCommentText.Enabled = E2805E1A.Checked;
	}

	private void AA8EE421(object sender, EventArgs e)
	{
		GClass8.smethod_60(C988E5B6, label2);
	}

	private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = ckbSendAnh.Checked;
	}

	private void panel1_Click(object sender, EventArgs e)
	{
	}

	private void AE27C8BD(object sender, EventArgs e)
	{
	}

	private void C719C417(object sender, EventArgs e)
	{
	}

	private void radioButton1_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void F72B9019(object sender, EventArgs e)
	{
	}

	private void D6BC5A82_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		plCommentText.Height = 276;
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		plCommentText.Height = 358;
		ckbEditComment.Visible = false;
		DB06920E.Visible = false;
	}

	private void ckbTag_CheckedChanged(object sender, EventArgs e)
	{
		plTag.Enabled = ckbTag.Checked;
	}

	private void cbbTuyChonNoiDung_SelectedIndexChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(AAA5AE20, lblComment, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void btnHuongDanNhapNoiDung_Click(object sender, EventArgs e)
	{
		if (cbbTuyChonNoiDung.SelectedIndex == 0)
		{
			GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			GClass8.smethod_33(new fHelpNhapComment());
		}
		AAA5AE20.Focus();
	}

	private void CBBECE1C_CheckedChanged(object sender, EventArgs e)
	{
		ckbSendAnh.Enabled = !CBBECE1C.Checked;
		ckbTag.Enabled = !CBBECE1C.Checked;
		if (CBBECE1C.Checked)
		{
			ckbSendAnh.Checked = false;
			ckbTag.Checked = false;
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		if (C000CD86.SelectedIndex == 0)
		{
			GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			GClass8.smethod_33(new fHelpNhapComment());
		}
		FD2BF70D.Focus();
	}

	private void D788E382(object sender, EventArgs e)
	{
		GClass8.smethod_60(FD2BF70D, EAB3D483, C000CD86.SelectedIndex);
	}

	private void DB1DFE18_CheckedChanged(object sender, EventArgs e)
	{
		plContentShare.Enabled = DB1DFE18.Checked;
	}

	private void C000CD86_SelectedIndexChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(FD2BF70D, EAB3D483, C000CD86.SelectedIndex);
	}

	private void B18FF180(object sender, EventArgs e)
	{
		DB06920E.Enabled = ckbEditComment.Checked;
	}

	private void A418EC91(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtCommentEdit, AA0D7399, cbbTuyChonNoiDungEdit.SelectedIndex);
	}

	private void cbbTuyChonNoiDungEdit_SelectedIndexChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtCommentEdit, AA0D7399, cbbTuyChonNoiDungEdit.SelectedIndex);
	}

	private void button3_Click(object sender, EventArgs e)
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

	private void DD8A8300_CheckedChanged(object sender, EventArgs e)
	{
		plShareMess.Enabled = DD8A8300.Checked;
	}

	private void C0B8E915_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(C0B8E915, lblContentShareMess, cbbTuyChonNoiDungShareMess.SelectedIndex);
	}

	private void A582E027(object sender, EventArgs e)
	{
		if (cbbTuyChonNoiDungShareMess.SelectedIndex == 0)
		{
			GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			GClass8.smethod_33(new fHelpNhapComment());
		}
		C0B8E915.Focus();
	}

	private void cbbTuyChonNoiDungShareMess_SelectedIndexChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(C0B8E915, lblContentShareMess, cbbTuyChonNoiDungShareMess.SelectedIndex);
	}

	private void ckbDeleteComment_CheckedChanged(object sender, EventArgs e)
	{
		plDeleteComment.Enabled = ckbDeleteComment.Checked;
	}

	private void D19F018C(object sender, PaintEventArgs e)
	{
	}

	protected override void Dispose(bool E414A794)
	{
		if (E414A794 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(E414A794);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDBuffLikeComment));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		DA06A4A6 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		plInteract = new System.Windows.Forms.Panel();
		ckbAngry = new System.Windows.Forms.CheckBox();
		F409E031 = new System.Windows.Forms.CheckBox();
		ckbWow = new System.Windows.Forms.CheckBox();
		ckbHaha = new System.Windows.Forms.CheckBox();
		ckbCare = new System.Windows.Forms.CheckBox();
		ckbLove = new System.Windows.Forms.CheckBox();
		ckbLike = new System.Windows.Forms.CheckBox();
		panel7 = new System.Windows.Forms.Panel();
		radioButton3 = new System.Windows.Forms.RadioButton();
		BE92BC0A = new System.Windows.Forms.RadioButton();
		label26 = new System.Windows.Forms.Label();
		plCommentText = new System.Windows.Forms.Panel();
		DB06920E = new System.Windows.Forms.Panel();
		cbbTuyChonNoiDungEdit = new System.Windows.Forms.ComboBox();
		button3 = new System.Windows.Forms.Button();
		label4 = new System.Windows.Forms.Label();
		txtCommentEdit = new System.Windows.Forms.RichTextBox();
		AA0D7399 = new System.Windows.Forms.Label();
		E5B0E71A = new System.Windows.Forms.Label();
		B703C392 = new System.Windows.Forms.Label();
		FDAEEB2D = new System.Windows.Forms.NumericUpDown();
		E7093213 = new System.Windows.Forms.NumericUpDown();
		ckbEditComment = new System.Windows.Forms.CheckBox();
		cbbTuyChonNoiDung = new System.Windows.Forms.ComboBox();
		btnHuongDanNhapNoiDung = new System.Windows.Forms.Button();
		plTag = new System.Windows.Forms.Panel();
		ckbChiTagTenViet = new System.Windows.Forms.CheckBox();
		nudSoLuongTagTo = new System.Windows.Forms.NumericUpDown();
		label16 = new System.Windows.Forms.Label();
		nudSoLuongTagFrom = new System.Windows.Forms.NumericUpDown();
		label14 = new System.Windows.Forms.Label();
		label8 = new System.Windows.Forms.Label();
		ckbTag = new System.Windows.Forms.CheckBox();
		ckbAutoDeleteComment = new System.Windows.Forms.CheckBox();
		btnDown = new System.Windows.Forms.Button();
		btnUp = new System.Windows.Forms.Button();
		AAA5AE20 = new System.Windows.Forms.RichTextBox();
		lblComment = new System.Windows.Forms.Label();
		panel3 = new System.Windows.Forms.Panel();
		rbCommentTheoThuTu = new System.Windows.Forms.RadioButton();
		B0BABB92 = new System.Windows.Forms.RadioButton();
		label13 = new System.Windows.Forms.Label();
		plDeleteComment = new System.Windows.Forms.Panel();
		label25 = new System.Windows.Forms.Label();
		CA3B1A86 = new System.Windows.Forms.Label();
		DA245CB8 = new System.Windows.Forms.NumericUpDown();
		nudDelayDeleteTo = new System.Windows.Forms.NumericUpDown();
		ckbDeleteComment = new System.Windows.Forms.CheckBox();
		ckbInteract = new System.Windows.Forms.CheckBox();
		CBBECE1C = new System.Windows.Forms.CheckBox();
		ckbSendAnh = new System.Windows.Forms.CheckBox();
		panel2 = new System.Windows.Forms.Panel();
		label2 = new System.Windows.Forms.Label();
		C988E5B6 = new System.Windows.Forms.RichTextBox();
		EB2300BC = new System.Windows.Forms.CheckBox();
		plAnh = new System.Windows.Forms.Panel();
		txtAnh = new System.Windows.Forms.TextBox();
		label12 = new System.Windows.Forms.Label();
		label49 = new System.Windows.Forms.Label();
		nudSoLuongUidFrom = new System.Windows.Forms.NumericUpDown();
		nudSoLuongUidTo = new System.Windows.Forms.NumericUpDown();
		D7923A37 = new System.Windows.Forms.Label();
		E2805E1A = new System.Windows.Forms.CheckBox();
		nudTimeTo = new System.Windows.Forms.NumericUpDown();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudTimeFrom = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label9 = new System.Windows.Forms.Label();
		label7 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		DD37038A = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		ckbUuTienMbasic = new System.Windows.Forms.CheckBox();
		plContentShare = new System.Windows.Forms.Panel();
		C000CD86 = new System.Windows.Forms.ComboBox();
		button2 = new System.Windows.Forms.Button();
		E10A25AD = new System.Windows.Forms.Label();
		ckbAutoDeleteContentShare = new System.Windows.Forms.CheckBox();
		panel6 = new System.Windows.Forms.Panel();
		radioButton1 = new System.Windows.Forms.RadioButton();
		D6BC5A82 = new System.Windows.Forms.RadioButton();
		F0881DBF = new System.Windows.Forms.Label();
		FD2BF70D = new System.Windows.Forms.RichTextBox();
		EAB3D483 = new System.Windows.Forms.Label();
		plShareMess = new System.Windows.Forms.Panel();
		cbbTuyChonNoiDungShareMess = new System.Windows.Forms.ComboBox();
		button4 = new System.Windows.Forms.Button();
		EDB86792 = new System.Windows.Forms.Label();
		ckbAutoDeleteContentShareMess = new System.Windows.Forms.CheckBox();
		panel5 = new System.Windows.Forms.Panel();
		radioButton5 = new System.Windows.Forms.RadioButton();
		radioButton6 = new System.Windows.Forms.RadioButton();
		EBA3B800 = new System.Windows.Forms.Label();
		C0B8E915 = new System.Windows.Forms.RichTextBox();
		lblContentShareMess = new System.Windows.Forms.Label();
		B80E0701 = new System.Windows.Forms.Label();
		BDB1968B = new System.Windows.Forms.Label();
		nudSoLuongMessFrom = new System.Windows.Forms.NumericUpDown();
		nudSoLuongMessTo = new System.Windows.Forms.NumericUpDown();
		label20 = new System.Windows.Forms.Label();
		label21 = new System.Windows.Forms.Label();
		nudDelayMessTo = new System.Windows.Forms.NumericUpDown();
		nudDelayMessFrom = new System.Windows.Forms.NumericUpDown();
		DB1DFE18 = new System.Windows.Forms.CheckBox();
		DD8A8300 = new System.Windows.Forms.CheckBox();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plInteract.SuspendLayout();
		panel7.SuspendLayout();
		plCommentText.SuspendLayout();
		DB06920E.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)FDAEEB2D).BeginInit();
		((System.ComponentModel.ISupportInitialize)E7093213).BeginInit();
		plTag.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTagTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTagFrom).BeginInit();
		panel3.SuspendLayout();
		plDeleteComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)DA245CB8).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayDeleteTo).BeginInit();
		panel2.SuspendLayout();
		plAnh.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongUidFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongUidTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		plContentShare.SuspendLayout();
		panel6.SuspendLayout();
		plShareMess.SuspendLayout();
		panel5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongMessFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongMessTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayMessTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayMessFrom).BeginInit();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = DA06A4A6;
		bunifuDragControl_0.Vertical = true;
		DA06A4A6.BackColor = System.Drawing.Color.Transparent;
		DA06A4A6.Cursor = System.Windows.Forms.Cursors.SizeAll;
		DA06A4A6.Dock = System.Windows.Forms.DockStyle.Fill;
		DA06A4A6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DA06A4A6.ForeColor = System.Drawing.Color.Black;
		DA06A4A6.Location = new System.Drawing.Point(0, 0);
		DA06A4A6.Name = "bunifuCustomLabel1";
		DA06A4A6.Size = new System.Drawing.Size(1000, 31);
		DA06A4A6.TabIndex = 12;
		DA06A4A6.Text = "Câ\u0301u hi\u0300nh Tương ta\u0301c ba\u0300i viê\u0301t chi\u0309 đi\u0323nh";
		DA06A4A6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(DA06A4A6);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(1000, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(969, 1);
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
		pictureBox1.Click += new System.EventHandler(AE27C8BD);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(plInteract);
		panel1.Controls.Add(plCommentText);
		panel1.Controls.Add(ckbInteract);
		panel1.Controls.Add(CBBECE1C);
		panel1.Controls.Add(ckbSendAnh);
		panel1.Controls.Add(panel2);
		panel1.Controls.Add(plAnh);
		panel1.Controls.Add(label49);
		panel1.Controls.Add(nudSoLuongUidFrom);
		panel1.Controls.Add(nudSoLuongUidTo);
		panel1.Controls.Add(D7923A37);
		panel1.Controls.Add(E2805E1A);
		panel1.Controls.Add(nudTimeTo);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudTimeFrom);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label9);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(DD37038A);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Controls.Add(ckbUuTienMbasic);
		panel1.Controls.Add(plContentShare);
		panel1.Controls.Add(plShareMess);
		panel1.Controls.Add(DB1DFE18);
		panel1.Controls.Add(DD8A8300);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(1003, 490);
		panel1.TabIndex = 0;
		panel1.Click += new System.EventHandler(panel1_Click);
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		plInteract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plInteract.Controls.Add(ckbAngry);
		plInteract.Controls.Add(F409E031);
		plInteract.Controls.Add(ckbWow);
		plInteract.Controls.Add(ckbHaha);
		plInteract.Controls.Add(ckbCare);
		plInteract.Controls.Add(ckbLove);
		plInteract.Controls.Add(ckbLike);
		plInteract.Controls.Add(panel7);
		plInteract.Controls.Add(label26);
		plInteract.Location = new System.Drawing.Point(317, 99);
		plInteract.Name = "plInteract";
		plInteract.Size = new System.Drawing.Size(312, 33);
		plInteract.TabIndex = 182;
		ckbAngry.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAngry.Image = C50FB39E.ABB95605;
		ckbAngry.Location = new System.Drawing.Point(266, 1);
		ckbAngry.Name = "ckbAngry";
		ckbAngry.Size = new System.Drawing.Size(40, 30);
		ckbAngry.TabIndex = 179;
		ckbAngry.Tag = "Angry";
		ckbAngry.UseVisualStyleBackColor = true;
		F409E031.Cursor = System.Windows.Forms.Cursors.Hand;
		F409E031.Image = C50FB39E.Bitmap_163;
		F409E031.Location = new System.Drawing.Point(222, 1);
		F409E031.Name = "ckbSad";
		F409E031.Size = new System.Drawing.Size(40, 30);
		F409E031.TabIndex = 178;
		F409E031.Tag = "Sad";
		F409E031.UseVisualStyleBackColor = true;
		ckbWow.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbWow.Image = C50FB39E.F10C2BBC;
		ckbWow.Location = new System.Drawing.Point(178, 1);
		ckbWow.Name = "ckbWow";
		ckbWow.Size = new System.Drawing.Size(40, 30);
		ckbWow.TabIndex = 177;
		ckbWow.Tag = "Wow";
		ckbWow.UseVisualStyleBackColor = true;
		ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHaha.Image = C50FB39E.Bitmap_47;
		ckbHaha.Location = new System.Drawing.Point(134, 1);
		ckbHaha.Name = "ckbHaha";
		ckbHaha.Size = new System.Drawing.Size(40, 30);
		ckbHaha.TabIndex = 176;
		ckbHaha.Tag = "Haha";
		ckbHaha.UseVisualStyleBackColor = true;
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
		ckbLike.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLike.Image = C50FB39E.F2069B3C;
		ckbLike.Location = new System.Drawing.Point(2, 1);
		ckbLike.Name = "ckbLike";
		ckbLike.Size = new System.Drawing.Size(40, 30);
		ckbLike.TabIndex = 173;
		ckbLike.Tag = "Like";
		ckbLike.UseVisualStyleBackColor = true;
		panel7.Controls.Add(radioButton3);
		panel7.Controls.Add(BE92BC0A);
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
		BE92BC0A.AutoSize = true;
		BE92BC0A.Cursor = System.Windows.Forms.Cursors.Hand;
		BE92BC0A.Location = new System.Drawing.Point(3, 23);
		BE92BC0A.Name = "radioButton4";
		BE92BC0A.Size = new System.Drawing.Size(200, 20);
		BE92BC0A.TabIndex = 3;
		BE92BC0A.Text = "Comment ngẫu nhiên nội dung";
		BE92BC0A.UseVisualStyleBackColor = true;
		label26.AutoSize = true;
		label26.Location = new System.Drawing.Point(4, 302);
		label26.Name = "label26";
		label26.Size = new System.Drawing.Size(64, 16);
		label26.TabIndex = 2;
		label26.Text = "Tùy chọn:";
		plCommentText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plCommentText.Controls.Add(DB06920E);
		plCommentText.Controls.Add(ckbEditComment);
		plCommentText.Controls.Add(cbbTuyChonNoiDung);
		plCommentText.Controls.Add(btnHuongDanNhapNoiDung);
		plCommentText.Controls.Add(plTag);
		plCommentText.Controls.Add(label8);
		plCommentText.Controls.Add(ckbTag);
		plCommentText.Controls.Add(ckbAutoDeleteComment);
		plCommentText.Controls.Add(btnDown);
		plCommentText.Controls.Add(btnUp);
		plCommentText.Controls.Add(AAA5AE20);
		plCommentText.Controls.Add(lblComment);
		plCommentText.Controls.Add(panel3);
		plCommentText.Controls.Add(label13);
		plCommentText.Controls.Add(plDeleteComment);
		plCommentText.Controls.Add(ckbDeleteComment);
		plCommentText.Location = new System.Drawing.Point(661, 99);
		plCommentText.Name = "plCommentText";
		plCommentText.Size = new System.Drawing.Size(311, 276);
		plCommentText.TabIndex = 164;
		plCommentText.Paint += new System.Windows.Forms.PaintEventHandler(D19F018C);
		DB06920E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		DB06920E.Controls.Add(cbbTuyChonNoiDungEdit);
		DB06920E.Controls.Add(button3);
		DB06920E.Controls.Add(label4);
		DB06920E.Controls.Add(txtCommentEdit);
		DB06920E.Controls.Add(AA0D7399);
		DB06920E.Controls.Add(E5B0E71A);
		DB06920E.Controls.Add(B703C392);
		DB06920E.Controls.Add(FDAEEB2D);
		DB06920E.Controls.Add(E7093213);
		DB06920E.Location = new System.Drawing.Point(6, 298);
		DB06920E.Name = "plEditComment";
		DB06920E.Size = new System.Drawing.Size(298, 218);
		DB06920E.TabIndex = 198;
		cbbTuyChonNoiDungEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		cbbTuyChonNoiDungEdit.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTuyChonNoiDungEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTuyChonNoiDungEdit.FormattingEnabled = true;
		cbbTuyChonNoiDungEdit.Location = new System.Drawing.Point(69, 186);
		cbbTuyChonNoiDungEdit.Name = "cbbTuyChonNoiDungEdit";
		cbbTuyChonNoiDungEdit.Size = new System.Drawing.Size(189, 24);
		cbbTuyChonNoiDungEdit.TabIndex = 195;
		cbbTuyChonNoiDungEdit.SelectedIndexChanged += new System.EventHandler(cbbTuyChonNoiDungEdit_SelectedIndexChanged);
		button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		button3.Cursor = System.Windows.Forms.Cursors.Hand;
		button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button3.Location = new System.Drawing.Point(264, 185);
		button3.Name = "button3";
		button3.Size = new System.Drawing.Size(26, 26);
		button3.TabIndex = 194;
		button3.Text = "?";
		button3.UseVisualStyleBackColor = true;
		button3.Click += new System.EventHandler(button3_Click);
		label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(3, 189);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(64, 16);
		label4.TabIndex = 193;
		label4.Text = "Tùy chọn:";
		txtCommentEdit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtCommentEdit.Location = new System.Drawing.Point(7, 53);
		txtCommentEdit.Name = "txtCommentEdit";
		txtCommentEdit.Size = new System.Drawing.Size(283, 128);
		txtCommentEdit.TabIndex = 1;
		txtCommentEdit.Text = "";
		txtCommentEdit.WordWrap = false;
		txtCommentEdit.TextChanged += new System.EventHandler(A418EC91);
		AA0D7399.AutoSize = true;
		AA0D7399.Location = new System.Drawing.Point(4, 32);
		AA0D7399.Name = "lblCommentEdit";
		AA0D7399.Size = new System.Drawing.Size(139, 16);
		AA0D7399.TabIndex = 0;
		AA0D7399.Text = "Nội dung bình luận (0):";
		E5B0E71A.AutoSize = true;
		E5B0E71A.Location = new System.Drawing.Point(4, 6);
		E5B0E71A.Name = "label6";
		E5B0E71A.Size = new System.Drawing.Size(92, 16);
		E5B0E71A.TabIndex = 34;
		E5B0E71A.Text = "Delay time (s):";
		B703C392.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B703C392.Location = new System.Drawing.Point(170, 6);
		B703C392.Name = "label10";
		B703C392.Size = new System.Drawing.Size(29, 16);
		B703C392.TabIndex = 38;
		B703C392.Text = ">";
		B703C392.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		FDAEEB2D.Location = new System.Drawing.Point(102, 4);
		FDAEEB2D.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		FDAEEB2D.Name = "nudDelayEditFrom";
		FDAEEB2D.Size = new System.Drawing.Size(56, 23);
		FDAEEB2D.TabIndex = 5;
		E7093213.Location = new System.Drawing.Point(209, 4);
		E7093213.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		E7093213.Name = "nudDelayEditTo";
		E7093213.Size = new System.Drawing.Size(56, 23);
		E7093213.TabIndex = 6;
		ckbEditComment.AutoSize = true;
		ckbEditComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbEditComment.Location = new System.Drawing.Point(6, 276);
		ckbEditComment.Name = "ckbEditComment";
		ckbEditComment.Size = new System.Drawing.Size(159, 20);
		ckbEditComment.TabIndex = 197;
		ckbEditComment.Text = "Sửa nội dung comment";
		ckbEditComment.UseVisualStyleBackColor = true;
		ckbEditComment.CheckedChanged += new System.EventHandler(B18FF180);
		cbbTuyChonNoiDung.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		cbbTuyChonNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTuyChonNoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTuyChonNoiDung.FormattingEnabled = true;
		cbbTuyChonNoiDung.Location = new System.Drawing.Point(69, 223);
		cbbTuyChonNoiDung.Name = "cbbTuyChonNoiDung";
		cbbTuyChonNoiDung.Size = new System.Drawing.Size(202, 24);
		cbbTuyChonNoiDung.TabIndex = 180;
		cbbTuyChonNoiDung.SelectedIndexChanged += new System.EventHandler(cbbTuyChonNoiDung_SelectedIndexChanged);
		btnHuongDanNhapNoiDung.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		btnHuongDanNhapNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		btnHuongDanNhapNoiDung.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnHuongDanNhapNoiDung.Location = new System.Drawing.Point(277, 222);
		btnHuongDanNhapNoiDung.Name = "btnHuongDanNhapNoiDung";
		btnHuongDanNhapNoiDung.Size = new System.Drawing.Size(26, 26);
		btnHuongDanNhapNoiDung.TabIndex = 179;
		btnHuongDanNhapNoiDung.Text = "?";
		btnHuongDanNhapNoiDung.UseVisualStyleBackColor = true;
		btnHuongDanNhapNoiDung.Click += new System.EventHandler(btnHuongDanNhapNoiDung_Click);
		plTag.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		plTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plTag.Controls.Add(ckbChiTagTenViet);
		plTag.Controls.Add(nudSoLuongTagTo);
		plTag.Controls.Add(label16);
		plTag.Controls.Add(nudSoLuongTagFrom);
		plTag.Controls.Add(label14);
		plTag.Location = new System.Drawing.Point(25, 298);
		plTag.Name = "plTag";
		plTag.Size = new System.Drawing.Size(275, 54);
		plTag.TabIndex = 167;
		ckbChiTagTenViet.AutoSize = true;
		ckbChiTagTenViet.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbChiTagTenViet.Location = new System.Drawing.Point(6, 31);
		ckbChiTagTenViet.Name = "ckbChiTagTenViet";
		ckbChiTagTenViet.Size = new System.Drawing.Size(112, 20);
		ckbChiTagTenViet.TabIndex = 168;
		ckbChiTagTenViet.Text = "Chỉ tag tên việt";
		ckbChiTagTenViet.UseVisualStyleBackColor = true;
		nudSoLuongTagTo.Location = new System.Drawing.Point(156, 4);
		nudSoLuongTagTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTagTo.Name = "nudSoLuongTagTo";
		nudSoLuongTagTo.Size = new System.Drawing.Size(51, 23);
		nudSoLuongTagTo.TabIndex = 174;
		label16.AutoSize = true;
		label16.Location = new System.Drawing.Point(3, 6);
		label16.Name = "label16";
		label16.Size = new System.Drawing.Size(63, 16);
		label16.TabIndex = 175;
		label16.Text = "Số lượng:";
		nudSoLuongTagFrom.Location = new System.Drawing.Point(70, 4);
		nudSoLuongTagFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTagFrom.Name = "nudSoLuongTagFrom";
		nudSoLuongTagFrom.Size = new System.Drawing.Size(51, 23);
		nudSoLuongTagFrom.TabIndex = 173;
		label14.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label14.Location = new System.Drawing.Point(125, 6);
		label14.Name = "label14";
		label14.Size = new System.Drawing.Size(29, 16);
		label14.TabIndex = 177;
		label14.Text = ">";
		label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(3, 226);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(64, 16);
		label8.TabIndex = 178;
		label8.Text = "Tùy chọn:";
		ckbTag.AutoSize = true;
		ckbTag.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTag.Location = new System.Drawing.Point(6, 276);
		ckbTag.Name = "ckbTag";
		ckbTag.Size = new System.Drawing.Size(91, 20);
		ckbTag.TabIndex = 166;
		ckbTag.Text = "Tag bạn bè";
		ckbTag.UseVisualStyleBackColor = true;
		ckbTag.CheckedChanged += new System.EventHandler(ckbTag_CheckedChanged);
		ckbAutoDeleteComment.AutoSize = true;
		ckbAutoDeleteComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAutoDeleteComment.Location = new System.Drawing.Point(6, 250);
		ckbAutoDeleteComment.Name = "ckbAutoDeleteComment";
		ckbAutoDeleteComment.Size = new System.Drawing.Size(169, 20);
		ckbAutoDeleteComment.TabIndex = 176;
		ckbAutoDeleteComment.Text = "Xóa nội dung đã sư\u0309 du\u0323ng";
		ckbAutoDeleteComment.UseVisualStyleBackColor = true;
		btnDown.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		btnDown.BackgroundImage = C50FB39E.Bitmap_89;
		btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnDown.Location = new System.Drawing.Point(254, -1);
		btnDown.Name = "btnDown";
		btnDown.Size = new System.Drawing.Size(25, 25);
		btnDown.TabIndex = 40;
		btnDown.Click += new System.EventHandler(btnDown_Click);
		btnUp.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		btnUp.BackgroundImage = C50FB39E.Bitmap_74;
		btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnUp.Location = new System.Drawing.Point(285, -1);
		btnUp.Name = "btnUp";
		btnUp.Size = new System.Drawing.Size(25, 25);
		btnUp.TabIndex = 41;
		btnUp.Click += new System.EventHandler(btnUp_Click);
		AAA5AE20.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		AAA5AE20.Location = new System.Drawing.Point(6, 25);
		AAA5AE20.Name = "txtComment";
		AAA5AE20.Size = new System.Drawing.Size(297, 191);
		AAA5AE20.TabIndex = 1;
		AAA5AE20.Text = "";
		AAA5AE20.WordWrap = false;
		AAA5AE20.TextChanged += new System.EventHandler(AAA5AE20_TextChanged);
		lblComment.AutoSize = true;
		lblComment.Location = new System.Drawing.Point(2, 5);
		lblComment.Name = "lblComment";
		lblComment.Size = new System.Drawing.Size(139, 16);
		lblComment.TabIndex = 0;
		lblComment.Text = "Nội dung bình luận (0):";
		panel3.Controls.Add(rbCommentTheoThuTu);
		panel3.Controls.Add(B0BABB92);
		panel3.Location = new System.Drawing.Point(75, 108);
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
		rbCommentTheoThuTu.CheckedChanged += new System.EventHandler(radioButton1_CheckedChanged);
		B0BABB92.AutoSize = true;
		B0BABB92.Cursor = System.Windows.Forms.Cursors.Hand;
		B0BABB92.Location = new System.Drawing.Point(3, 23);
		B0BABB92.Name = "rbCommentNgauNhien";
		B0BABB92.Size = new System.Drawing.Size(200, 20);
		B0BABB92.TabIndex = 3;
		B0BABB92.Text = "Comment ngẫu nhiên nội dung";
		B0BABB92.UseVisualStyleBackColor = true;
		B0BABB92.CheckedChanged += new System.EventHandler(D6BC5A82_CheckedChanged);
		label13.AutoSize = true;
		label13.Location = new System.Drawing.Point(12, 110);
		label13.Name = "label13";
		label13.Size = new System.Drawing.Size(64, 16);
		label13.TabIndex = 2;
		label13.Text = "Tùy chọn:";
		label13.Click += new System.EventHandler(F72B9019);
		plDeleteComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plDeleteComment.Controls.Add(label25);
		plDeleteComment.Controls.Add(CA3B1A86);
		plDeleteComment.Controls.Add(DA245CB8);
		plDeleteComment.Controls.Add(nudDelayDeleteTo);
		plDeleteComment.Location = new System.Drawing.Point(10, 49);
		plDeleteComment.Name = "plDeleteComment";
		plDeleteComment.Size = new System.Drawing.Size(287, 32);
		plDeleteComment.TabIndex = 200;
		label25.AutoSize = true;
		label25.Location = new System.Drawing.Point(4, 6);
		label25.Name = "label25";
		label25.Size = new System.Drawing.Size(92, 16);
		label25.TabIndex = 34;
		label25.Text = "Delay time (s):";
		CA3B1A86.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CA3B1A86.Location = new System.Drawing.Point(170, 6);
		CA3B1A86.Name = "label27";
		CA3B1A86.Size = new System.Drawing.Size(29, 16);
		CA3B1A86.TabIndex = 38;
		CA3B1A86.Text = ">";
		CA3B1A86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		DA245CB8.Location = new System.Drawing.Point(102, 4);
		DA245CB8.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		DA245CB8.Name = "nudDelayDeleteFrom";
		DA245CB8.Size = new System.Drawing.Size(56, 23);
		DA245CB8.TabIndex = 5;
		nudDelayDeleteTo.Location = new System.Drawing.Point(209, 4);
		nudDelayDeleteTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayDeleteTo.Name = "nudDelayDeleteTo";
		nudDelayDeleteTo.Size = new System.Drawing.Size(56, 23);
		nudDelayDeleteTo.TabIndex = 6;
		ckbDeleteComment.AutoSize = true;
		ckbDeleteComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbDeleteComment.Location = new System.Drawing.Point(10, 27);
		ckbDeleteComment.Name = "ckbDeleteComment";
		ckbDeleteComment.Size = new System.Drawing.Size(105, 20);
		ckbDeleteComment.TabIndex = 199;
		ckbDeleteComment.Text = "Xo\u0301a comment";
		ckbDeleteComment.UseVisualStyleBackColor = true;
		ckbDeleteComment.CheckedChanged += new System.EventHandler(ckbDeleteComment_CheckedChanged);
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(317, 77);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(99, 20);
		ckbInteract.TabIndex = 181;
		ckbInteract.Text = "Thả cảm xúc";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += new System.EventHandler(ckbInteract_CheckedChanged);
		CBBECE1C.AutoSize = true;
		CBBECE1C.Cursor = System.Windows.Forms.Cursors.Hand;
		CBBECE1C.Location = new System.Drawing.Point(565, 136);
		CBBECE1C.Name = "ckbRunAPI";
		CBBECE1C.Size = new System.Drawing.Size(99, 20);
		CBBECE1C.TabIndex = 176;
		CBBECE1C.Text = "Run API (ẩn)";
		CBBECE1C.UseVisualStyleBackColor = true;
		CBBECE1C.CheckedChanged += new System.EventHandler(CBBECE1C_CheckedChanged);
		ckbSendAnh.AutoSize = true;
		ckbSendAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbSendAnh.Location = new System.Drawing.Point(661, 381);
		ckbSendAnh.Name = "ckbSendAnh";
		ckbSendAnh.Size = new System.Drawing.Size(103, 20);
		ckbSendAnh.TabIndex = 165;
		ckbSendAnh.Text = "Bi\u0300nh luâ\u0323n a\u0309nh";
		ckbSendAnh.UseVisualStyleBackColor = true;
		ckbSendAnh.CheckedChanged += new System.EventHandler(ckbSendAnh_CheckedChanged);
		panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel2.Controls.Add(label2);
		panel2.Controls.Add(C988E5B6);
		panel2.Controls.Add(EB2300BC);
		panel2.Location = new System.Drawing.Point(30, 135);
		panel2.Name = "panel2";
		panel2.Size = new System.Drawing.Size(252, 273);
		panel2.TabIndex = 181;
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(3, 4);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(176, 16);
		label2.TabIndex = 40;
		label2.Text = "Nhâ\u0323p Id hoă\u0323c link ba\u0300i viê\u0301t (0):";
		C988E5B6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		C988E5B6.Location = new System.Drawing.Point(6, 24);
		C988E5B6.Name = "txtIdPost";
		C988E5B6.Size = new System.Drawing.Size(238, 220);
		C988E5B6.TabIndex = 1;
		C988E5B6.Text = "";
		C988E5B6.WordWrap = false;
		C988E5B6.TextChanged += new System.EventHandler(AA8EE421);
		EB2300BC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		EB2300BC.AutoSize = true;
		EB2300BC.Cursor = System.Windows.Forms.Cursors.Hand;
		EB2300BC.Location = new System.Drawing.Point(6, 247);
		EB2300BC.Name = "ckbTuDongXoa";
		EB2300BC.Size = new System.Drawing.Size(192, 20);
		EB2300BC.TabIndex = 176;
		EB2300BC.Text = "Xóa link ba\u0300i viê\u0301t đã tương tác";
		EB2300BC.UseVisualStyleBackColor = true;
		plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plAnh.Controls.Add(txtAnh);
		plAnh.Controls.Add(label12);
		plAnh.Enabled = false;
		plAnh.Location = new System.Drawing.Point(661, 403);
		plAnh.Name = "plAnh";
		plAnh.Size = new System.Drawing.Size(311, 31);
		plAnh.TabIndex = 166;
		txtAnh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtAnh.Location = new System.Drawing.Point(86, 3);
		txtAnh.Name = "txtAnh";
		txtAnh.Size = new System.Drawing.Size(220, 23);
		txtAnh.TabIndex = 155;
		label12.AutoSize = true;
		label12.Location = new System.Drawing.Point(3, 6);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(73, 16);
		label12.TabIndex = 39;
		label12.Text = "Folder ảnh:";
		label12.Click += new System.EventHandler(C719C417);
		label49.AutoSize = true;
		label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label49.Location = new System.Drawing.Point(27, 79);
		label49.Name = "label49";
		label49.Size = new System.Drawing.Size(84, 16);
		label49.TabIndex = 169;
		label49.Text = "Sô\u0301 lươ\u0323ng ba\u0300i:";
		nudSoLuongUidFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudSoLuongUidFrom.Location = new System.Drawing.Point(129, 77);
		nudSoLuongUidFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongUidFrom.Name = "nudSoLuongUidFrom";
		nudSoLuongUidFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongUidFrom.TabIndex = 167;
		nudSoLuongUidFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		nudSoLuongUidTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudSoLuongUidTo.Location = new System.Drawing.Point(226, 77);
		nudSoLuongUidTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongUidTo.Name = "nudSoLuongUidTo";
		nudSoLuongUidTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongUidTo.TabIndex = 168;
		nudSoLuongUidTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		D7923A37.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		D7923A37.Location = new System.Drawing.Point(191, 79);
		D7923A37.Name = "label66";
		D7923A37.Size = new System.Drawing.Size(29, 16);
		D7923A37.TabIndex = 171;
		D7923A37.Text = ">";
		D7923A37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		E2805E1A.AutoSize = true;
		E2805E1A.Cursor = System.Windows.Forms.Cursors.Hand;
		E2805E1A.Location = new System.Drawing.Point(661, 77);
		E2805E1A.Name = "ckbComment";
		E2805E1A.Size = new System.Drawing.Size(127, 20);
		E2805E1A.TabIndex = 163;
		E2805E1A.Text = "Bi\u0300nh luâ\u0323n văn bản";
		E2805E1A.UseVisualStyleBackColor = true;
		E2805E1A.CheckedChanged += new System.EventHandler(E2805E1A_CheckedChanged);
		nudTimeTo.Location = new System.Drawing.Point(498, 50);
		nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeTo.Name = "nudTimeTo";
		nudTimeTo.Size = new System.Drawing.Size(51, 23);
		nudTimeTo.TabIndex = 4;
		nudDelayTo.Location = new System.Drawing.Point(226, 106);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudTimeFrom.Location = new System.Drawing.Point(420, 50);
		nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeFrom.Name = "nudTimeFrom";
		nudTimeFrom.Size = new System.Drawing.Size(51, 23);
		nudTimeFrom.TabIndex = 3;
		nudDelayFrom.Location = new System.Drawing.Point(129, 106);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		txtTenHanhDong.Location = new System.Drawing.Point(129, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(153, 23);
		txtTenHanhDong.TabIndex = 0;
		label9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label9.Location = new System.Drawing.Point(471, 52);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(29, 16);
		label9.TabIndex = 38;
		label9.Text = ">";
		label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label7.Location = new System.Drawing.Point(191, 108);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = ">";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(314, 52);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(103, 16);
		label3.TabIndex = 34;
		label3.Text = "Xem bài viết (s):";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 108);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(87, 16);
		label5.TabIndex = 34;
		label5.Text = "Gia\u0303n ca\u0301ch (s):";
		DD37038A.AutoSize = true;
		DD37038A.Location = new System.Drawing.Point(27, 52);
		DD37038A.Name = "label1";
		DD37038A.Size = new System.Drawing.Size(98, 16);
		DD37038A.TabIndex = 31;
		DD37038A.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(508, 448);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(401, 448);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(FB8A0401);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(1000, 37);
		bunifuCards1.TabIndex = 28;
		ckbUuTienMbasic.AutoSize = true;
		ckbUuTienMbasic.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbUuTienMbasic.Location = new System.Drawing.Point(30, 414);
		ckbUuTienMbasic.Name = "ckbUuTienMbasic";
		ckbUuTienMbasic.Size = new System.Drawing.Size(173, 20);
		ckbUuTienMbasic.TabIndex = 176;
		ckbUuTienMbasic.Text = "Ưu tiên chạy bằng mbasic";
		ckbUuTienMbasic.UseVisualStyleBackColor = true;
		plContentShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plContentShare.Controls.Add(C000CD86);
		plContentShare.Controls.Add(button2);
		plContentShare.Controls.Add(E10A25AD);
		plContentShare.Controls.Add(ckbAutoDeleteContentShare);
		plContentShare.Controls.Add(panel6);
		plContentShare.Controls.Add(F0881DBF);
		plContentShare.Controls.Add(FD2BF70D);
		plContentShare.Controls.Add(EAB3D483);
		plContentShare.Location = new System.Drawing.Point(317, 159);
		plContentShare.Name = "plContentShare";
		plContentShare.Size = new System.Drawing.Size(312, 275);
		plContentShare.TabIndex = 164;
		C000CD86.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		C000CD86.Cursor = System.Windows.Forms.Cursors.Hand;
		C000CD86.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		C000CD86.FormattingEnabled = true;
		C000CD86.Location = new System.Drawing.Point(69, 225);
		C000CD86.Name = "cbbTuyChonNoiDungShare";
		C000CD86.Size = new System.Drawing.Size(203, 24);
		C000CD86.TabIndex = 180;
		C000CD86.SelectedIndexChanged += new System.EventHandler(C000CD86_SelectedIndexChanged);
		button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(278, 224);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(26, 26);
		button2.TabIndex = 179;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		E10A25AD.AutoSize = true;
		E10A25AD.Location = new System.Drawing.Point(3, 228);
		E10A25AD.Name = "label15";
		E10A25AD.Size = new System.Drawing.Size(64, 16);
		E10A25AD.TabIndex = 178;
		E10A25AD.Text = "Tùy chọn:";
		ckbAutoDeleteContentShare.AutoSize = true;
		ckbAutoDeleteContentShare.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAutoDeleteContentShare.Location = new System.Drawing.Point(6, 252);
		ckbAutoDeleteContentShare.Name = "ckbAutoDeleteContentShare";
		ckbAutoDeleteContentShare.Size = new System.Drawing.Size(169, 20);
		ckbAutoDeleteContentShare.TabIndex = 176;
		ckbAutoDeleteContentShare.Text = "Xóa nội dung đã sư\u0309 du\u0323ng";
		ckbAutoDeleteContentShare.UseVisualStyleBackColor = true;
		panel6.Controls.Add(radioButton1);
		panel6.Controls.Add(D6BC5A82);
		panel6.Location = new System.Drawing.Point(67, 383);
		panel6.Name = "panel6";
		panel6.Size = new System.Drawing.Size(200, 43);
		panel6.TabIndex = 43;
		radioButton1.AutoSize = true;
		radioButton1.Checked = true;
		radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
		radioButton1.Location = new System.Drawing.Point(3, 2);
		radioButton1.Name = "radioButton1";
		radioButton1.Size = new System.Drawing.Size(201, 20);
		radioButton1.TabIndex = 3;
		radioButton1.TabStop = true;
		radioButton1.Text = "Comment theo thứ tự nội dung";
		radioButton1.UseVisualStyleBackColor = true;
		radioButton1.CheckedChanged += new System.EventHandler(radioButton1_CheckedChanged);
		D6BC5A82.AutoSize = true;
		D6BC5A82.Cursor = System.Windows.Forms.Cursors.Hand;
		D6BC5A82.Location = new System.Drawing.Point(3, 23);
		D6BC5A82.Name = "radioButton2";
		D6BC5A82.Size = new System.Drawing.Size(200, 20);
		D6BC5A82.TabIndex = 3;
		D6BC5A82.Text = "Comment ngẫu nhiên nội dung";
		D6BC5A82.UseVisualStyleBackColor = true;
		D6BC5A82.CheckedChanged += new System.EventHandler(D6BC5A82_CheckedChanged);
		F0881DBF.AutoSize = true;
		F0881DBF.Location = new System.Drawing.Point(4, 385);
		F0881DBF.Name = "label17";
		F0881DBF.Size = new System.Drawing.Size(64, 16);
		F0881DBF.TabIndex = 2;
		F0881DBF.Text = "Tùy chọn:";
		F0881DBF.Click += new System.EventHandler(F72B9019);
		FD2BF70D.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		FD2BF70D.Location = new System.Drawing.Point(6, 25);
		FD2BF70D.Name = "txtContentShare";
		FD2BF70D.Size = new System.Drawing.Size(298, 194);
		FD2BF70D.TabIndex = 1;
		FD2BF70D.Text = "";
		FD2BF70D.WordWrap = false;
		FD2BF70D.TextChanged += new System.EventHandler(D788E382);
		EAB3D483.AutoSize = true;
		EAB3D483.Location = new System.Drawing.Point(2, 5);
		EAB3D483.Name = "lblContentShare";
		EAB3D483.Size = new System.Drawing.Size(119, 16);
		EAB3D483.TabIndex = 0;
		EAB3D483.Text = "Nội dung share (0):";
		plShareMess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plShareMess.Controls.Add(cbbTuyChonNoiDungShareMess);
		plShareMess.Controls.Add(button4);
		plShareMess.Controls.Add(EDB86792);
		plShareMess.Controls.Add(ckbAutoDeleteContentShareMess);
		plShareMess.Controls.Add(panel5);
		plShareMess.Controls.Add(EBA3B800);
		plShareMess.Controls.Add(C0B8E915);
		plShareMess.Controls.Add(lblContentShareMess);
		plShareMess.Controls.Add(B80E0701);
		plShareMess.Controls.Add(BDB1968B);
		plShareMess.Controls.Add(nudSoLuongMessFrom);
		plShareMess.Controls.Add(nudSoLuongMessTo);
		plShareMess.Controls.Add(label20);
		plShareMess.Controls.Add(label21);
		plShareMess.Controls.Add(nudDelayMessTo);
		plShareMess.Controls.Add(nudDelayMessFrom);
		plShareMess.Location = new System.Drawing.Point(317, 159);
		plShareMess.Name = "plShareMess";
		plShareMess.Size = new System.Drawing.Size(312, 275);
		plShareMess.TabIndex = 182;
		cbbTuyChonNoiDungShareMess.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		cbbTuyChonNoiDungShareMess.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTuyChonNoiDungShareMess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTuyChonNoiDungShareMess.FormattingEnabled = true;
		cbbTuyChonNoiDungShareMess.Location = new System.Drawing.Point(72, 221);
		cbbTuyChonNoiDungShareMess.Name = "cbbTuyChonNoiDungShareMess";
		cbbTuyChonNoiDungShareMess.Size = new System.Drawing.Size(202, 24);
		cbbTuyChonNoiDungShareMess.TabIndex = 184;
		cbbTuyChonNoiDungShareMess.SelectedIndexChanged += new System.EventHandler(cbbTuyChonNoiDungShareMess_SelectedIndexChanged);
		button4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button4.Cursor = System.Windows.Forms.Cursors.Hand;
		button4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button4.Location = new System.Drawing.Point(280, 220);
		button4.Name = "button4";
		button4.Size = new System.Drawing.Size(26, 26);
		button4.TabIndex = 183;
		button4.Text = "?";
		button4.UseVisualStyleBackColor = true;
		button4.Click += new System.EventHandler(A582E027);
		EDB86792.AutoSize = true;
		EDB86792.Location = new System.Drawing.Point(6, 224);
		EDB86792.Name = "label23";
		EDB86792.Size = new System.Drawing.Size(64, 16);
		EDB86792.TabIndex = 182;
		EDB86792.Text = "Tùy chọn:";
		ckbAutoDeleteContentShareMess.AutoSize = true;
		ckbAutoDeleteContentShareMess.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAutoDeleteContentShareMess.Location = new System.Drawing.Point(9, 249);
		ckbAutoDeleteContentShareMess.Name = "ckbAutoDeleteContentShareMess";
		ckbAutoDeleteContentShareMess.Size = new System.Drawing.Size(169, 20);
		ckbAutoDeleteContentShareMess.TabIndex = 181;
		ckbAutoDeleteContentShareMess.Text = "Xóa nội dung đã sư\u0309 du\u0323ng";
		ckbAutoDeleteContentShareMess.UseVisualStyleBackColor = true;
		panel5.Controls.Add(radioButton5);
		panel5.Controls.Add(radioButton6);
		panel5.Location = new System.Drawing.Point(67, 383);
		panel5.Name = "panel5";
		panel5.Size = new System.Drawing.Size(200, 43);
		panel5.TabIndex = 43;
		radioButton5.AutoSize = true;
		radioButton5.Checked = true;
		radioButton5.Cursor = System.Windows.Forms.Cursors.Hand;
		radioButton5.Location = new System.Drawing.Point(3, 2);
		radioButton5.Name = "radioButton5";
		radioButton5.Size = new System.Drawing.Size(201, 20);
		radioButton5.TabIndex = 3;
		radioButton5.TabStop = true;
		radioButton5.Text = "Comment theo thứ tự nội dung";
		radioButton5.UseVisualStyleBackColor = true;
		radioButton6.AutoSize = true;
		radioButton6.Cursor = System.Windows.Forms.Cursors.Hand;
		radioButton6.Location = new System.Drawing.Point(3, 23);
		radioButton6.Name = "radioButton6";
		radioButton6.Size = new System.Drawing.Size(200, 20);
		radioButton6.TabIndex = 3;
		radioButton6.Text = "Comment ngẫu nhiên nội dung";
		radioButton6.UseVisualStyleBackColor = true;
		EBA3B800.AutoSize = true;
		EBA3B800.Location = new System.Drawing.Point(4, 385);
		EBA3B800.Name = "label18";
		EBA3B800.Size = new System.Drawing.Size(64, 16);
		EBA3B800.TabIndex = 2;
		EBA3B800.Text = "Tùy chọn:";
		C0B8E915.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		C0B8E915.Location = new System.Drawing.Point(8, 82);
		C0B8E915.Name = "txtContentShareMess";
		C0B8E915.Size = new System.Drawing.Size(298, 134);
		C0B8E915.TabIndex = 1;
		C0B8E915.Text = "";
		C0B8E915.WordWrap = false;
		C0B8E915.TextChanged += new System.EventHandler(C0B8E915_TextChanged);
		lblContentShareMess.AutoSize = true;
		lblContentShareMess.Location = new System.Drawing.Point(6, 62);
		lblContentShareMess.Name = "lblContentShareMess";
		lblContentShareMess.Size = new System.Drawing.Size(119, 16);
		lblContentShareMess.TabIndex = 0;
		lblContentShareMess.Text = "Nội dung share (0):";
		B80E0701.AutoSize = true;
		B80E0701.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		B80E0701.Location = new System.Drawing.Point(6, 7);
		B80E0701.Name = "label22";
		B80E0701.Size = new System.Drawing.Size(63, 16);
		B80E0701.TabIndex = 169;
		B80E0701.Text = "Sô\u0301 lươ\u0323ng:";
		BDB1968B.AutoSize = true;
		BDB1968B.Location = new System.Drawing.Point(6, 36);
		BDB1968B.Name = "label11";
		BDB1968B.Size = new System.Drawing.Size(87, 16);
		BDB1968B.TabIndex = 34;
		BDB1968B.Text = "Gia\u0303n ca\u0301ch (s):";
		nudSoLuongMessFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudSoLuongMessFrom.Location = new System.Drawing.Point(108, 5);
		nudSoLuongMessFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongMessFrom.Name = "nudSoLuongMessFrom";
		nudSoLuongMessFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongMessFrom.TabIndex = 167;
		nudSoLuongMessFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		nudSoLuongMessTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudSoLuongMessTo.Location = new System.Drawing.Point(205, 5);
		nudSoLuongMessTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongMessTo.Name = "nudSoLuongMessTo";
		nudSoLuongMessTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongMessTo.TabIndex = 168;
		nudSoLuongMessTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		label20.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label20.Location = new System.Drawing.Point(170, 36);
		label20.Name = "label20";
		label20.Size = new System.Drawing.Size(29, 16);
		label20.TabIndex = 38;
		label20.Text = ">";
		label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label21.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		label21.Location = new System.Drawing.Point(170, 7);
		label21.Name = "label21";
		label21.Size = new System.Drawing.Size(29, 16);
		label21.TabIndex = 171;
		label21.Text = ">";
		label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudDelayMessTo.Location = new System.Drawing.Point(205, 34);
		nudDelayMessTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayMessTo.Name = "nudDelayMessTo";
		nudDelayMessTo.Size = new System.Drawing.Size(56, 23);
		nudDelayMessTo.TabIndex = 4;
		nudDelayMessFrom.Location = new System.Drawing.Point(108, 34);
		nudDelayMessFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayMessFrom.Name = "nudDelayMessFrom";
		nudDelayMessFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayMessFrom.TabIndex = 3;
		DB1DFE18.AutoSize = true;
		DB1DFE18.Cursor = System.Windows.Forms.Cursors.Hand;
		DB1DFE18.Location = new System.Drawing.Point(317, 137);
		DB1DFE18.Name = "ckbShareWall";
		DB1DFE18.Size = new System.Drawing.Size(87, 20);
		DB1DFE18.TabIndex = 6;
		DB1DFE18.Text = "Share wall";
		DB1DFE18.UseVisualStyleBackColor = true;
		DB1DFE18.CheckedChanged += new System.EventHandler(DB1DFE18_CheckedChanged);
		DD8A8300.AutoSize = true;
		DD8A8300.Cursor = System.Windows.Forms.Cursors.Hand;
		DD8A8300.Location = new System.Drawing.Point(317, 137);
		DD8A8300.Name = "ckbShareMess";
		DD8A8300.Size = new System.Drawing.Size(94, 20);
		DD8A8300.TabIndex = 181;
		DD8A8300.Text = "Share mess";
		DD8A8300.UseVisualStyleBackColor = true;
		DD8A8300.CheckedChanged += new System.EventHandler(DD8A8300_CheckedChanged);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1003, 490);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBuffLikeComment";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDBuffLikeComment_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plInteract.ResumeLayout(false);
		plInteract.PerformLayout();
		panel7.ResumeLayout(false);
		panel7.PerformLayout();
		plCommentText.ResumeLayout(false);
		plCommentText.PerformLayout();
		DB06920E.ResumeLayout(false);
		DB06920E.PerformLayout();
		((System.ComponentModel.ISupportInitialize)FDAEEB2D).EndInit();
		((System.ComponentModel.ISupportInitialize)E7093213).EndInit();
		plTag.ResumeLayout(false);
		plTag.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTagTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTagFrom).EndInit();
		panel3.ResumeLayout(false);
		panel3.PerformLayout();
		plDeleteComment.ResumeLayout(false);
		plDeleteComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)DA245CB8).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayDeleteTo).EndInit();
		panel2.ResumeLayout(false);
		panel2.PerformLayout();
		plAnh.ResumeLayout(false);
		plAnh.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongUidFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongUidTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		plContentShare.ResumeLayout(false);
		plContentShare.PerformLayout();
		panel6.ResumeLayout(false);
		panel6.PerformLayout();
		plShareMess.ResumeLayout(false);
		plShareMess.PerformLayout();
		panel5.ResumeLayout(false);
		panel5.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongMessFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongMessTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayMessTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayMessFrom).EndInit();
		ResumeLayout(false);
	}
}
