using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDDangBai : Form
{
	private F31742AD f31742AD_0;

	private ucTuongTacBaiViet ucTuongTacBaiViet_0;

	private GClass11 gclass11_0;

	private string FB103737;

	private string FB2EC5B0;

	private string string_0;

	private int B41BBBAE;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button D7B29C96;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button E7056313;

	private PictureBox pictureBox1;

	private BunifuCustomLabel B8B3B194;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudDelayFrom;

	private Label C2271A37;

	private Label B5AB5B2B;

	private Panel plAnh;

	private Label E3226592;

	private NumericUpDown nudSoLuongAnhTo;

	private Label label2;

	private NumericUpDown nudSoLuongAnhFrom;

	private Label D90473BD;

	private TextBox C5095EA0;

	private CheckBox F0A9628C;

	private CheckBox ckbUseBackground;

	private CheckBox ckbAnh;

	private CheckBox A1A9DF83;

	private CheckBox ckbXoaNhomDaDang;

	private GroupBox grTuyChon;

	private Panel plDangBaiLenPage;

	private Label label21;

	private NumericUpDown nudCountPageTo;

	private Label label23;

	private NumericUpDown AF1E2127;

	private Panel plDangBaiLenNhom;

	private CheckBox B8182C33;

	private CheckBox ckbUuTienNhomNhieuThanhVien;

	private LinkLabel lblTuongTacNhom;

	private CheckBox ckbOnlyDangNhomKhongKiemDuyet;

	private Panel C0032632;

	private Panel A73ACE32;

	private RichTextBox txtNhomTuNhap;

	private CheckBox AF031B1B;

	private RadioButton rbTuNhap;

	private RadioButton BBA770A1;

	private Label label12;

	private NumericUpDown C4ADA994;

	private CheckBox ckbTuongTac;

	private NumericUpDown nudCountGroupFrom;

	private Label B6A1A897;

	private Label label26;

	private CheckBox ckbDangBaiLenPage;

	private CheckBox A8384EA2;

	private CheckBox ckbDangBaiLenTuong;

	private Panel plVanBan;

	private ComboBox cbbTuyChonNoiDung;

	private Button btnHuongDanNhapNoiDung;

	private RichTextBox txtNoiDung;

	private Label FF327600;

	private Label B1887639;

	private Panel C30C9507;

	private Label CE23E58A;

	private NumericUpDown nudCountWallTo;

	private Label label5;

	private NumericUpDown nudCountWallFrom;

	private GroupBox AD98C02F;

	private CheckBox ckbCopyPost;

	private Panel plCopyPost;

	private Label CF05581F;

	private RichTextBox C8953F88;

	private CheckBox ckbThemVaoCuoiNoiDung;

	private LinkLabel linkLabel2;

	private RichTextBox B9245B1A;

	private Label C718EBAB;

	private CheckBox E496D426;

	private CheckBox C72EC50B;

	private CheckBox AEA04D23;

	private Panel plNotUseAvatar;

	private CheckBox ckbXoaHashtag;

	private CheckBox ckbUuTienMbasic;

	private LinkLabel lblTuongTacBaiViet;

	private CheckBox ckbTuongTacBaiVietDaDang;

	private Button A58A07BF;

	private Button btnUp;

	public fHDDangBai(string CCABB51D, int C8884E27 = 0, string D5285435 = "")
	{
		A3356230();
		bool_0 = false;
		FB103737 = CCABB51D;
		string_0 = D5285435;
		B41BBBAE = C8884E27;
		string text = base.Name.Substring(1);
		string text2 = "Đăng bài";
		if (Class147.smethod_7("", text).Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\",\"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string string_ = "";
		switch (C8884E27)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			string_ = dataTable2.Rows[0]["CauHinh"].ToString();
			FB2EC5B0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(D5285435);
			string_ = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(string_, bool_0: true);
		F7AB102E.D6B70A35(this);
		f31742AD_0 = new F31742AD(gclass11_0)
		{
			Visible = false
		};
		base.Controls.Add(f31742AD_0);
		f31742AD_0.smethod_0(bool_0: true);
		ucTuongTacBaiViet_0 = new ucTuongTacBaiViet(gclass11_0)
		{
			Visible = false
		};
		base.Controls.Add(ucTuongTacBaiViet_0);
		ucTuongTacBaiViet_0.smethod_0(bool_0: true);
	}

	private void fHDDangBai_Load(object sender, EventArgs e)
	{
		F92BEBAB();
		try
		{
			nudDelayFrom.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
			A1A9DF83.Checked = gclass11_0.method_3("ckbVanBan");
			txtNoiDung.Text = gclass11_0.C0288288("txtNoiDung");
			cbbTuyChonNoiDung.SelectedIndex = gclass11_0.method_2("typeNganCach");
			ckbUseBackground.Checked = gclass11_0.method_3("ckbUseBackground");
			C72EC50B.Checked = gclass11_0.method_3("ckbXoaNoiDung");
			ckbAnh.Checked = gclass11_0.method_3("ckbAnh");
			nudSoLuongAnhFrom.Value = gclass11_0.method_2("nudSoLuongAnhFrom", 1);
			nudSoLuongAnhTo.Value = gclass11_0.method_2("nudSoLuongAnhTo", 1);
			F0A9628C.Checked = gclass11_0.method_3("ckbUseAvatar");
			C5095EA0.Text = gclass11_0.C0288288("txtPathAnh");
			AEA04D23.Checked = gclass11_0.method_3("ckbXoaAnh");
			ckbDangBaiLenTuong.Checked = gclass11_0.method_3("ckbDangBaiLenTuong");
			nudCountWallFrom.Value = gclass11_0.method_2("nudCountWallFrom", 1);
			nudCountWallTo.Value = gclass11_0.method_2("nudCountWallTo", 1);
			A8384EA2.Checked = gclass11_0.method_3("ckbDangBaiLenNhom");
			nudCountGroupFrom.Value = gclass11_0.method_2("nudCountGroupFrom", 1);
			C4ADA994.Value = gclass11_0.method_2("nudCountGroupTo", 1);
			ckbUuTienMbasic.Checked = gclass11_0.method_3("ckbUuTienMbasic", bool_0: true);
			if (gclass11_0.method_2("typePost") == 0)
			{
				BBA770A1.Checked = true;
			}
			else
			{
				rbTuNhap.Checked = true;
			}
			txtNhomTuNhap.Text = gclass11_0.C0288288("lstNhomTuNhap");
			AF031B1B.Checked = gclass11_0.method_3("ckbChiDangNhomDaThamGia");
			ckbXoaNhomDaDang.Checked = gclass11_0.method_3("ckbXoaNhomDaDang");
			ckbOnlyDangNhomKhongKiemDuyet.Checked = gclass11_0.method_3("ckbOnlyDangNhomKhongKiemDuyet");
			ckbUuTienNhomNhieuThanhVien.Checked = gclass11_0.method_3("ckbUuTienNhomNhieuThanhVien");
			B8182C33.Checked = gclass11_0.method_3("ckbKhongDangTrung");
			ckbTuongTac.Checked = gclass11_0.method_3("ckbTuongTac");
			ckbTuongTacBaiVietDaDang.Checked = gclass11_0.method_3("ckbTuongTacBaiVietDaDang");
			ckbDangBaiLenPage.Checked = gclass11_0.method_3("ckbDangBaiLenPage");
			AF1E2127.Value = gclass11_0.method_2("nudCountPageFrom", 1);
			nudCountPageTo.Value = gclass11_0.method_2("nudCountPageTo", 1);
			ckbCopyPost.Checked = gclass11_0.method_3("ckbCopyPost");
			C8953F88.Text = gclass11_0.C0288288("txtIdPost");
			E496D426.Checked = gclass11_0.method_3("ckbXoaIdPostDaDung");
			ckbXoaHashtag.Checked = gclass11_0.method_3("ckbXoaHashtag");
			ckbThemVaoCuoiNoiDung.Checked = gclass11_0.method_3("ckbThemVaoCuoiNoiDung");
			B9245B1A.Text = gclass11_0.C0288288("txtNoiDungThemVaoCuoi");
		}
		catch (Exception)
		{
		}
		method_0();
	}

	private void F92BEBAB()
	{
		List<string> list_ = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		GClass8.smethod_22(cbbTuyChonNoiDung, list_);
	}

	private void E9BE753B(object sender, EventArgs e)
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
		gclass11_0.method_4("nudDelayFrom", nudDelayFrom.Value);
		gclass11_0.method_4("nudDelayTo", nudDelayTo.Value);
		gclass11_0.method_4("ckbVanBan", A1A9DF83.Checked);
		gclass11_0.method_4("ckbXoaNoiDung", C72EC50B.Checked);
		gclass11_0.method_4("txtNoiDung", txtNoiDung.Text.Trim());
		gclass11_0.method_4("typeNganCach", cbbTuyChonNoiDung.SelectedIndex);
		gclass11_0.method_4("ckbUseBackground", ckbUseBackground.Checked);
		gclass11_0.method_4("ckbAnh", ckbAnh.Checked);
		gclass11_0.method_4("nudSoLuongAnhFrom", nudSoLuongAnhFrom.Value);
		gclass11_0.method_4("nudSoLuongAnhTo", nudSoLuongAnhTo.Value);
		gclass11_0.method_4("ckbUseAvatar", F0A9628C.Checked);
		gclass11_0.method_4("txtPathAnh", C5095EA0.Text.Trim());
		gclass11_0.method_4("ckbXoaAnh", AEA04D23.Checked);
		gclass11_0.method_4("ckbDangBaiLenTuong", ckbDangBaiLenTuong.Checked);
		gclass11_0.method_4("nudCountWallFrom", nudCountWallFrom.Value);
		gclass11_0.method_4("nudCountWallTo", nudCountWallTo.Value);
		gclass11_0.method_4("ckbDangBaiLenNhom", A8384EA2.Checked);
		gclass11_0.method_4("nudCountGroupFrom", nudCountGroupFrom.Value);
		gclass11_0.method_4("nudCountGroupTo", C4ADA994.Value);
		gclass11_0.method_4("ckbUuTienMbasic", ckbUuTienMbasic.Checked);
		int num = 0;
		if (rbTuNhap.Checked)
		{
			num = 1;
		}
		gclass11_0.method_4("typePost", num);
		gclass11_0.method_4("lstNhomTuNhap", txtNhomTuNhap.Text);
		gclass11_0.method_4("ckbChiDangNhomDaThamGia", AF031B1B.Checked);
		gclass11_0.method_4("ckbXoaNhomDaDang", ckbXoaNhomDaDang.Checked);
		gclass11_0.method_4("ckbOnlyDangNhomKhongKiemDuyet", ckbOnlyDangNhomKhongKiemDuyet.Checked);
		gclass11_0.method_4("ckbUuTienNhomNhieuThanhVien", ckbUuTienNhomNhieuThanhVien.Checked);
		gclass11_0.method_4("ckbKhongDangTrung", B8182C33.Checked);
		gclass11_0.method_4("ckbTuongTac", ckbTuongTac.Checked);
		gclass11_0.method_4("ckbTuongTacBaiVietDaDang", ckbTuongTacBaiVietDaDang.Checked);
		gclass11_0.method_4("ckbDangBaiLenPage", ckbDangBaiLenPage.Checked);
		gclass11_0.method_4("nudCountPageFrom", AF1E2127.Value);
		gclass11_0.method_4("nudCountPageTo", nudCountPageTo.Value);
		gclass11_0.method_4("ckbCopyPost", ckbCopyPost.Checked);
		gclass11_0.method_4("txtIdPost", C8953F88.Text.Trim());
		gclass11_0.method_4("ckbXoaIdPostDaDung", E496D426.Checked);
		gclass11_0.method_4("ckbXoaHashtag", ckbXoaHashtag.Checked);
		gclass11_0.method_4("ckbThemVaoCuoiNoiDung", ckbThemVaoCuoiNoiDung.Checked);
		gclass11_0.method_4("txtNoiDungThemVaoCuoi", B9245B1A.Text.Trim());
		string text2 = gclass11_0.method_7();
		if (B41BBBAE == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(FB103737, text, FB2EC5B0, text2))
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
			if (Class147.smethod_13(string_0, text, text2))
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

	private void F381218B(object sender, EventArgs e)
	{
		Close();
	}

	private void CE3E1FA2(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void method_0()
	{
		A8384EA2_CheckedChanged(null, null);
		E4A63B1A(null, null);
		A1A9DF83_CheckedChanged(null, null);
		ckbAnh_CheckedChanged(null, null);
		F0A9628C_CheckedChanged(null, null);
		rbTuNhap_CheckedChanged(null, null);
		ckbTuongTac_CheckedChanged(null, null);
		ckbTuongTacBaiVietDaDang_CheckedChanged(null, null);
		ckbDangBaiLenTuong_CheckedChanged(null, null);
		D020FF24(null, null);
		ckbThemVaoCuoiNoiDung_CheckedChanged(null, null);
	}

	private void A1A9DF83_CheckedChanged(object sender, EventArgs e)
	{
		plVanBan.Enabled = A1A9DF83.Checked;
		ckbUseBackground_CheckedChanged(null, null);
	}

	private void ckbAnh_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = ckbAnh.Checked;
		if (ckbAnh.Checked)
		{
			ckbUseBackground.Checked = false;
		}
	}

	private void txtNoiDung_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtNoiDung, B1887639, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void A5A18B26(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.smethod_33(new E3962B82());
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
		txtNoiDung.Focus();
	}

	private void E3AF2E8E(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtNoiDung, B1887639, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void A8384EA2_CheckedChanged(object sender, EventArgs e)
	{
		plDangBaiLenNhom.Enabled = A8384EA2.Checked;
	}

	private void rbTuNhap_CheckedChanged(object sender, EventArgs e)
	{
		A73ACE32.Enabled = rbTuNhap.Checked;
		if (rbTuNhap.Checked)
		{
			if (!AF031B1B.Checked)
			{
				ckbOnlyDangNhomKhongKiemDuyet.Checked = false;
				ckbOnlyDangNhomKhongKiemDuyet.Enabled = false;
				ckbUuTienNhomNhieuThanhVien.Checked = false;
				ckbUuTienNhomNhieuThanhVien.Enabled = false;
			}
		}
		else
		{
			ckbOnlyDangNhomKhongKiemDuyet.Enabled = true;
			ckbUuTienNhomNhieuThanhVien.Enabled = true;
		}
	}

	private void F323AFB5(object sender, EventArgs e)
	{
		GClass8.E814B702(sender as RichTextBox, rbTuNhap);
	}

	private void B4289791(object sender, EventArgs e)
	{
		if (!AF031B1B.Checked)
		{
			ckbOnlyDangNhomKhongKiemDuyet.Checked = false;
			ckbOnlyDangNhomKhongKiemDuyet.Enabled = false;
			ckbUuTienNhomNhieuThanhVien.Checked = false;
			ckbUuTienNhomNhieuThanhVien.Enabled = false;
		}
		else
		{
			ckbOnlyDangNhomKhongKiemDuyet.Enabled = true;
			ckbUuTienNhomNhieuThanhVien.Enabled = true;
		}
	}

	private void ckbTuongTac_CheckedChanged(object sender, EventArgs e)
	{
		lblTuongTacNhom.Enabled = ckbTuongTac.Checked;
	}

	private void lblTuongTacNhom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.BFBFBD05(f31742AD_0, this);
	}

	private void E4A63B1A(object sender, EventArgs e)
	{
		plDangBaiLenPage.Enabled = ckbDangBaiLenPage.Checked;
	}

	private void F0A9628C_CheckedChanged(object sender, EventArgs e)
	{
		plNotUseAvatar.Enabled = !F0A9628C.Checked;
	}

	private void ckbUseBackground_CheckedChanged(object sender, EventArgs e)
	{
		if (A1A9DF83.Checked && ckbUseBackground.Checked)
		{
			ckbAnh.Checked = false;
			ckbAnh.Enabled = false;
		}
		else
		{
			ckbAnh.Enabled = true;
		}
	}

	private void ckbDangBaiLenTuong_CheckedChanged(object sender, EventArgs e)
	{
		C30C9507.Enabled = ckbDangBaiLenTuong.Checked;
	}

	private void C8953F88_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(C8953F88, CF05581F);
	}

	private void D020FF24(object sender, EventArgs e)
	{
		plCopyPost.Enabled = ckbCopyPost.Checked;
		if (ckbCopyPost.Checked)
		{
			A1A9DF83.Checked = false;
			ckbAnh.Checked = false;
		}
		A1A9DF83.Enabled = !ckbCopyPost.Checked;
		ckbAnh.Enabled = !ckbCopyPost.Checked;
	}

	private void ckbThemVaoCuoiNoiDung_CheckedChanged(object sender, EventArgs e)
	{
		B9245B1A.Enabled = ckbThemVaoCuoiNoiDung.Checked;
	}

	private void plAnh_Paint(object sender, PaintEventArgs e)
	{
	}

	private void ckbUuTienMbasic_CheckedChanged(object sender, EventArgs e)
	{
		ckbUseBackground.Enabled = !ckbUuTienMbasic.Checked;
		if (ckbUuTienMbasic.Checked)
		{
			ckbUseBackground.Checked = false;
		}
	}

	private void B50FA096(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.BFBFBD05(ucTuongTacBaiViet_0, this);
	}

	private void ckbTuongTacBaiVietDaDang_CheckedChanged(object sender, EventArgs e)
	{
		lblTuongTacBaiViet.Enabled = ckbTuongTacBaiVietDaDang.Checked;
	}

	private void F11714B0(object sender, EventArgs e)
	{
		grTuyChon.Height = 477;
	}

	private void A58A07BF_Click(object sender, EventArgs e)
	{
		grTuyChon.Height = 501;
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void A3356230()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDDangBai));
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		B8B3B194 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		E7056313 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		AD98C02F = new GroupBox();
		ckbCopyPost = new CheckBox();
		A1A9DF83 = new CheckBox();
		plCopyPost = new Panel();
		ckbXoaHashtag = new CheckBox();
		E496D426 = new CheckBox();
		ckbThemVaoCuoiNoiDung = new CheckBox();
		CF05581F = new Label();
		linkLabel2 = new LinkLabel();
		B9245B1A = new RichTextBox();
		C8953F88 = new RichTextBox();
		C718EBAB = new Label();
		plVanBan = new Panel();
		C72EC50B = new CheckBox();
		cbbTuyChonNoiDung = new ComboBox();
		btnHuongDanNhapNoiDung = new Button();
		txtNoiDung = new RichTextBox();
		ckbUseBackground = new CheckBox();
		FF327600 = new Label();
		B1887639 = new Label();
		ckbAnh = new CheckBox();
		plAnh = new Panel();
		plNotUseAvatar = new Panel();
		C5095EA0 = new TextBox();
		E3226592 = new Label();
		nudSoLuongAnhFrom = new NumericUpDown();
		AEA04D23 = new CheckBox();
		D90473BD = new Label();
		nudSoLuongAnhTo = new NumericUpDown();
		label2 = new Label();
		F0A9628C = new CheckBox();
		grTuyChon = new GroupBox();
		A58A07BF = new Button();
		btnUp = new Button();
		ckbUuTienMbasic = new CheckBox();
		C30C9507 = new Panel();
		CE23E58A = new Label();
		nudCountWallTo = new NumericUpDown();
		label5 = new Label();
		nudCountWallFrom = new NumericUpDown();
		plDangBaiLenPage = new Panel();
		label21 = new Label();
		nudCountPageTo = new NumericUpDown();
		label23 = new Label();
		AF1E2127 = new NumericUpDown();
		plDangBaiLenNhom = new Panel();
		B8182C33 = new CheckBox();
		ckbUuTienNhomNhieuThanhVien = new CheckBox();
		lblTuongTacBaiViet = new LinkLabel();
		lblTuongTacNhom = new LinkLabel();
		ckbOnlyDangNhomKhongKiemDuyet = new CheckBox();
		C0032632 = new Panel();
		A73ACE32 = new Panel();
		txtNhomTuNhap = new RichTextBox();
		AF031B1B = new CheckBox();
		ckbXoaNhomDaDang = new CheckBox();
		rbTuNhap = new RadioButton();
		BBA770A1 = new RadioButton();
		label12 = new Label();
		C4ADA994 = new NumericUpDown();
		ckbTuongTacBaiVietDaDang = new CheckBox();
		ckbTuongTac = new CheckBox();
		nudCountGroupFrom = new NumericUpDown();
		B6A1A897 = new Label();
		label26 = new Label();
		ckbDangBaiLenPage = new CheckBox();
		A8384EA2 = new CheckBox();
		ckbDangBaiLenTuong = new CheckBox();
		nudDelayTo = new NumericUpDown();
		nudDelayFrom = new NumericUpDown();
		C2271A37 = new Label();
		B5AB5B2B = new Label();
		btnAdd = new Button();
		txtTenHanhDong = new TextBox();
		label1 = new Label();
		D7B29C96 = new Button();
		bunifuCards1 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		AD98C02F.SuspendLayout();
		plCopyPost.SuspendLayout();
		plVanBan.SuspendLayout();
		plAnh.SuspendLayout();
		plNotUseAvatar.SuspendLayout();
		((ISupportInitialize)nudSoLuongAnhFrom).BeginInit();
		((ISupportInitialize)nudSoLuongAnhTo).BeginInit();
		grTuyChon.SuspendLayout();
		C30C9507.SuspendLayout();
		((ISupportInitialize)nudCountWallTo).BeginInit();
		((ISupportInitialize)nudCountWallFrom).BeginInit();
		plDangBaiLenPage.SuspendLayout();
		((ISupportInitialize)nudCountPageTo).BeginInit();
		((ISupportInitialize)AF1E2127).BeginInit();
		plDangBaiLenNhom.SuspendLayout();
		C0032632.SuspendLayout();
		A73ACE32.SuspendLayout();
		((ISupportInitialize)C4ADA994).BeginInit();
		((ISupportInitialize)nudCountGroupFrom).BeginInit();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = B8B3B194;
		bunifuDragControl_0.Vertical = true;
		B8B3B194.BackColor = Color.Transparent;
		B8B3B194.Cursor = Cursors.SizeAll;
		B8B3B194.Dock = DockStyle.Fill;
		B8B3B194.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		B8B3B194.ForeColor = Color.Black;
		B8B3B194.Location = new Point(0, 0);
		B8B3B194.Name = "bunifuCustomLabel1";
		B8B3B194.Size = new Size(978, 31);
		B8B3B194.TabIndex = 12;
		B8B3B194.Text = "Cấu hình Đăng bài";
		B8B3B194.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(E7056313);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(B8B3B194);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(978, 31);
		pnlHeader.TabIndex = 9;
		E7056313.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		E7056313.Cursor = Cursors.Hand;
		E7056313.FlatAppearance.BorderSize = 0;
		E7056313.FlatStyle = FlatStyle.Flat;
		E7056313.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		E7056313.ForeColor = Color.White;
		E7056313.Image = (Image)componentResourceManager.GetObject("button1.Image");
		E7056313.Location = new Point(947, 1);
		E7056313.Name = "button1";
		E7056313.Size = new Size(30, 30);
		E7056313.TabIndex = 0;
		E7056313.TextImageRelation = TextImageRelation.ImageBeforeText;
		E7056313.UseVisualStyleBackColor = true;
		E7056313.Click += E9BE753B;
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
		panel1.Controls.Add(AD98C02F);
		panel1.Controls.Add(grTuyChon);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(C2271A37);
		panel1.Controls.Add(B5AB5B2B);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(D7B29C96);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(981, 643);
		panel1.TabIndex = 0;
		panel1.Paint += CE3E1FA2;
		AD98C02F.Controls.Add(ckbCopyPost);
		AD98C02F.Controls.Add(A1A9DF83);
		AD98C02F.Controls.Add(plCopyPost);
		AD98C02F.Controls.Add(plVanBan);
		AD98C02F.Controls.Add(ckbAnh);
		AD98C02F.Controls.Add(plAnh);
		AD98C02F.Location = new Point(30, 107);
		AD98C02F.Name = "groupBox1";
		AD98C02F.Size = new Size(600, 477);
		AD98C02F.TabIndex = 72;
		AD98C02F.TabStop = false;
		AD98C02F.Text = "Nội dung";
		ckbCopyPost.AutoSize = true;
		ckbCopyPost.Cursor = Cursors.Hand;
		ckbCopyPost.Location = new Point(356, 22);
		ckbCopyPost.Name = "ckbCopyPost";
		ckbCopyPost.Size = new Size(124, 20);
		ckbCopyPost.TabIndex = 66;
		ckbCopyPost.Text = "Sao chép bài viết";
		ckbCopyPost.UseVisualStyleBackColor = true;
		ckbCopyPost.CheckedChanged += D020FF24;
		A1A9DF83.AutoSize = true;
		A1A9DF83.Cursor = Cursors.Hand;
		A1A9DF83.Location = new Point(9, 22);
		A1A9DF83.Name = "ckbVanBan";
		A1A9DF83.Size = new Size(76, 20);
		A1A9DF83.TabIndex = 66;
		A1A9DF83.Text = "Nội dung";
		A1A9DF83.UseVisualStyleBackColor = true;
		A1A9DF83.CheckedChanged += A1A9DF83_CheckedChanged;
		plCopyPost.BorderStyle = BorderStyle.FixedSingle;
		plCopyPost.Controls.Add(ckbXoaHashtag);
		plCopyPost.Controls.Add(E496D426);
		plCopyPost.Controls.Add(ckbThemVaoCuoiNoiDung);
		plCopyPost.Controls.Add(CF05581F);
		plCopyPost.Controls.Add(linkLabel2);
		plCopyPost.Controls.Add(B9245B1A);
		plCopyPost.Controls.Add(C8953F88);
		plCopyPost.Controls.Add(C718EBAB);
		plCopyPost.Location = new Point(356, 45);
		plCopyPost.Name = "plCopyPost";
		plCopyPost.Size = new Size(236, 422);
		plCopyPost.TabIndex = 71;
		ckbXoaHashtag.Anchor = AnchorStyles.Bottom;
		ckbXoaHashtag.AutoSize = true;
		ckbXoaHashtag.Cursor = Cursors.Hand;
		ckbXoaHashtag.Location = new Point(6, 246);
		ckbXoaHashtag.Name = "ckbXoaHashtag";
		ckbXoaHashtag.Size = new Size(201, 20);
		ckbXoaHashtag.TabIndex = 66;
		ckbXoaHashtag.Text = "Xo\u0301a hashtag co\u0301 trong nô\u0323i dung";
		ckbXoaHashtag.UseVisualStyleBackColor = true;
		ckbXoaHashtag.CheckedChanged += ckbThemVaoCuoiNoiDung_CheckedChanged;
		E496D426.Anchor = AnchorStyles.Bottom;
		E496D426.AutoSize = true;
		E496D426.Cursor = Cursors.Hand;
		E496D426.Location = new Point(6, 222);
		E496D426.Name = "ckbXoaIdPostDaDung";
		E496D426.Size = new Size(158, 20);
		E496D426.TabIndex = 66;
		E496D426.Text = "Xóa Id bài viết đã dùng";
		E496D426.UseVisualStyleBackColor = true;
		E496D426.CheckedChanged += ckbThemVaoCuoiNoiDung_CheckedChanged;
		ckbThemVaoCuoiNoiDung.Anchor = AnchorStyles.Bottom;
		ckbThemVaoCuoiNoiDung.AutoSize = true;
		ckbThemVaoCuoiNoiDung.Cursor = Cursors.Hand;
		ckbThemVaoCuoiNoiDung.Location = new Point(6, 272);
		ckbThemVaoCuoiNoiDung.Name = "ckbThemVaoCuoiNoiDung";
		ckbThemVaoCuoiNoiDung.Size = new Size(163, 20);
		ckbThemVaoCuoiNoiDung.TabIndex = 66;
		ckbThemVaoCuoiNoiDung.Text = "Thêm vào cuối nội dung";
		ckbThemVaoCuoiNoiDung.UseVisualStyleBackColor = true;
		ckbThemVaoCuoiNoiDung.CheckedChanged += ckbThemVaoCuoiNoiDung_CheckedChanged;
		CF05581F.AutoSize = true;
		CF05581F.Location = new Point(1, 4);
		CF05581F.Name = "lblIdPost";
		CF05581F.Size = new Size(152, 16);
		CF05581F.TabIndex = 179;
		CF05581F.Text = "Danh sách Id bài viết (0):";
		linkLabel2.Anchor = AnchorStyles.Bottom;
		linkLabel2.AutoSize = true;
		linkLabel2.Cursor = Cursors.Hand;
		linkLabel2.Location = new Point(150, 401);
		linkLabel2.Name = "linkLabel2";
		linkLabel2.Size = new Size(81, 16);
		linkLabel2.TabIndex = 183;
		linkLabel2.TabStop = true;
		linkLabel2.Text = "Random icon";
		linkLabel2.LinkClicked += A5A18B26;
		B9245B1A.Anchor = AnchorStyles.Bottom;
		B9245B1A.Location = new Point(6, 294);
		B9245B1A.Name = "txtNoiDungThemVaoCuoi";
		B9245B1A.Size = new Size(224, 105);
		B9245B1A.TabIndex = 180;
		B9245B1A.Text = "";
		B9245B1A.WordWrap = false;
		B9245B1A.TextChanged += C8953F88_TextChanged;
		C8953F88.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		C8953F88.Location = new Point(5, 24);
		C8953F88.Name = "txtIdPost";
		C8953F88.Size = new Size(224, 192);
		C8953F88.TabIndex = 180;
		C8953F88.Text = "";
		C8953F88.WordWrap = false;
		C8953F88.TextChanged += C8953F88_TextChanged;
		C718EBAB.Anchor = AnchorStyles.Bottom;
		C718EBAB.AutoSize = true;
		C718EBAB.Location = new Point(3, 401);
		C718EBAB.Name = "label6";
		C718EBAB.Size = new Size(143, 16);
		C718EBAB.TabIndex = 178;
		C718EBAB.Text = "(Spin nội dung {a|b|c})";
		plVanBan.BorderStyle = BorderStyle.FixedSingle;
		plVanBan.Controls.Add(C72EC50B);
		plVanBan.Controls.Add(cbbTuyChonNoiDung);
		plVanBan.Controls.Add(btnHuongDanNhapNoiDung);
		plVanBan.Controls.Add(txtNoiDung);
		plVanBan.Controls.Add(ckbUseBackground);
		plVanBan.Controls.Add(FF327600);
		plVanBan.Controls.Add(B1887639);
		plVanBan.Location = new Point(26, 45);
		plVanBan.Name = "plVanBan";
		plVanBan.Size = new Size(307, 286);
		plVanBan.TabIndex = 71;
		C72EC50B.Anchor = AnchorStyles.Bottom;
		C72EC50B.AutoSize = true;
		C72EC50B.Cursor = Cursors.Hand;
		C72EC50B.Location = new Point(6, 261);
		C72EC50B.Name = "ckbXoaNoiDung";
		C72EC50B.Size = new Size(169, 20);
		C72EC50B.TabIndex = 185;
		C72EC50B.Text = "Xóa nội dung đã sử dụng";
		C72EC50B.UseVisualStyleBackColor = true;
		cbbTuyChonNoiDung.Anchor = AnchorStyles.Bottom;
		cbbTuyChonNoiDung.Cursor = Cursors.Hand;
		cbbTuyChonNoiDung.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbTuyChonNoiDung.FormattingEnabled = true;
		cbbTuyChonNoiDung.Location = new Point(80, 233);
		cbbTuyChonNoiDung.Name = "cbbTuyChonNoiDung";
		cbbTuyChonNoiDung.Size = new Size(190, 24);
		cbbTuyChonNoiDung.TabIndex = 184;
		cbbTuyChonNoiDung.SelectedIndexChanged += E3AF2E8E;
		btnHuongDanNhapNoiDung.Anchor = AnchorStyles.Bottom;
		btnHuongDanNhapNoiDung.Cursor = Cursors.Hand;
		btnHuongDanNhapNoiDung.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnHuongDanNhapNoiDung.Location = new Point(274, 232);
		btnHuongDanNhapNoiDung.Name = "btnHuongDanNhapNoiDung";
		btnHuongDanNhapNoiDung.Size = new Size(26, 26);
		btnHuongDanNhapNoiDung.TabIndex = 182;
		btnHuongDanNhapNoiDung.Text = "?";
		btnHuongDanNhapNoiDung.UseVisualStyleBackColor = true;
		btnHuongDanNhapNoiDung.Click += btnHuongDanNhapNoiDung_Click;
		txtNoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		txtNoiDung.Location = new Point(5, 24);
		txtNoiDung.Name = "txtNoiDung";
		txtNoiDung.Size = new Size(295, 202);
		txtNoiDung.TabIndex = 180;
		txtNoiDung.Text = "";
		txtNoiDung.WordWrap = false;
		txtNoiDung.TextChanged += txtNoiDung_TextChanged;
		ckbUseBackground.AutoSize = true;
		ckbUseBackground.Cursor = Cursors.Hand;
		ckbUseBackground.Location = new Point(162, 3);
		ckbUseBackground.Name = "ckbUseBackground";
		ckbUseBackground.Size = new Size(144, 20);
		ckbUseBackground.TabIndex = 64;
		ckbUseBackground.Text = "Sử dụng Background";
		ckbUseBackground.UseVisualStyleBackColor = true;
		ckbUseBackground.CheckedChanged += ckbUseBackground_CheckedChanged;
		FF327600.Anchor = AnchorStyles.Bottom;
		FF327600.AutoSize = true;
		FF327600.Location = new Point(3, 236);
		FF327600.Name = "label9";
		FF327600.Size = new Size(64, 16);
		FF327600.TabIndex = 181;
		FF327600.Text = "Tùy chọn:";
		B1887639.AutoSize = true;
		B1887639.Location = new Point(1, 4);
		B1887639.Name = "lblNoiDung";
		B1887639.Size = new Size(136, 16);
		B1887639.TabIndex = 179;
		B1887639.Text = "Nội dung đăng bài (0):";
		ckbAnh.AutoSize = true;
		ckbAnh.Cursor = Cursors.Hand;
		ckbAnh.Location = new Point(9, 338);
		ckbAnh.Name = "ckbAnh";
		ckbAnh.Size = new Size(48, 20);
		ckbAnh.TabIndex = 65;
		ckbAnh.Text = "A\u0309nh";
		ckbAnh.UseVisualStyleBackColor = true;
		ckbAnh.CheckedChanged += ckbAnh_CheckedChanged;
		plAnh.BorderStyle = BorderStyle.FixedSingle;
		plAnh.Controls.Add(plNotUseAvatar);
		plAnh.Controls.Add(F0A9628C);
		plAnh.Location = new Point(26, 360);
		plAnh.Name = "plAnh";
		plAnh.Size = new Size(307, 107);
		plAnh.TabIndex = 69;
		plAnh.Paint += plAnh_Paint;
		plNotUseAvatar.Controls.Add(C5095EA0);
		plNotUseAvatar.Controls.Add(E3226592);
		plNotUseAvatar.Controls.Add(nudSoLuongAnhFrom);
		plNotUseAvatar.Controls.Add(AEA04D23);
		plNotUseAvatar.Controls.Add(D90473BD);
		plNotUseAvatar.Controls.Add(nudSoLuongAnhTo);
		plNotUseAvatar.Controls.Add(label2);
		plNotUseAvatar.Location = new Point(-1, -1);
		plNotUseAvatar.Name = "plNotUseAvatar";
		plNotUseAvatar.Size = new Size(307, 81);
		plNotUseAvatar.TabIndex = 34;
		C5095EA0.Location = new Point(83, 5);
		C5095EA0.Name = "txtPathAnh";
		C5095EA0.Size = new Size(218, 23);
		C5095EA0.TabIndex = 1;
		E3226592.AutoSize = true;
		E3226592.Location = new Point(4, 8);
		E3226592.Name = "label3";
		E3226592.Size = new Size(73, 16);
		E3226592.TabIndex = 0;
		E3226592.Text = "Folder ảnh:";
		nudSoLuongAnhFrom.Location = new Point(83, 33);
		nudSoLuongAnhFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongAnhFrom.Name = "nudSoLuongAnhFrom";
		nudSoLuongAnhFrom.Size = new Size(45, 23);
		nudSoLuongAnhFrom.TabIndex = 3;
		AEA04D23.AutoSize = true;
		AEA04D23.Cursor = Cursors.Hand;
		AEA04D23.Location = new Point(7, 60);
		AEA04D23.Name = "ckbXoaAnh";
		AEA04D23.Size = new Size(141, 20);
		AEA04D23.TabIndex = 33;
		AEA04D23.Text = "Xóa ảnh đã sử dụng";
		AEA04D23.UseVisualStyleBackColor = true;
		AEA04D23.CheckedChanged += F0A9628C_CheckedChanged;
		D90473BD.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		D90473BD.Location = new Point(130, 35);
		D90473BD.Name = "label10";
		D90473BD.Size = new Size(29, 16);
		D90473BD.TabIndex = 0;
		D90473BD.Text = ">";
		D90473BD.TextAlign = ContentAlignment.MiddleCenter;
		nudSoLuongAnhTo.Location = new Point(161, 33);
		nudSoLuongAnhTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongAnhTo.Name = "nudSoLuongAnhTo";
		nudSoLuongAnhTo.Size = new Size(45, 23);
		nudSoLuongAnhTo.TabIndex = 3;
		label2.AutoSize = true;
		label2.Location = new Point(4, 35);
		label2.Name = "label2";
		label2.Size = new Size(74, 16);
		label2.TabIndex = 0;
		label2.Text = "Sô\u0301 a\u0309nh/bài:";
		F0A9628C.AutoSize = true;
		F0A9628C.Cursor = Cursors.Hand;
		F0A9628C.Location = new Point(6, 82);
		F0A9628C.Name = "ckbUseAvatar";
		F0A9628C.Size = new Size(196, 20);
		F0A9628C.TabIndex = 33;
		F0A9628C.Text = "Sử dụng avatar làm ảnh đăng";
		F0A9628C.UseVisualStyleBackColor = true;
		F0A9628C.CheckedChanged += F0A9628C_CheckedChanged;
		grTuyChon.Controls.Add(A58A07BF);
		grTuyChon.Controls.Add(btnUp);
		grTuyChon.Controls.Add(ckbUuTienMbasic);
		grTuyChon.Controls.Add(C30C9507);
		grTuyChon.Controls.Add(plDangBaiLenPage);
		grTuyChon.Controls.Add(plDangBaiLenNhom);
		grTuyChon.Controls.Add(ckbDangBaiLenPage);
		grTuyChon.Controls.Add(A8384EA2);
		grTuyChon.Controls.Add(ckbDangBaiLenTuong);
		grTuyChon.Location = new Point(636, 107);
		grTuyChon.Name = "grTuyChon";
		grTuyChon.Size = new Size(310, 477);
		grTuyChon.TabIndex = 70;
		grTuyChon.TabStop = false;
		grTuyChon.Text = "Tùy chọn";
		A58A07BF.BackgroundImage = C50FB39E.Bitmap_89;
		A58A07BF.Cursor = Cursors.Hand;
		A58A07BF.FlatAppearance.BorderColor = Color.Silver;
		A58A07BF.FlatStyle = FlatStyle.Flat;
		A58A07BF.Location = new Point(254, 8);
		A58A07BF.Name = "btnDown";
		A58A07BF.Size = new Size(25, 25);
		A58A07BF.TabIndex = 199;
		A58A07BF.Click += A58A07BF_Click;
		btnUp.BackgroundImage = C50FB39E.Bitmap_74;
		btnUp.Cursor = Cursors.Hand;
		btnUp.FlatAppearance.BorderColor = Color.Silver;
		btnUp.FlatStyle = FlatStyle.Flat;
		btnUp.Location = new Point(285, 8);
		btnUp.Name = "btnUp";
		btnUp.Size = new Size(25, 25);
		btnUp.TabIndex = 200;
		btnUp.Click += F11714B0;
		ckbUuTienMbasic.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		ckbUuTienMbasic.AutoSize = true;
		ckbUuTienMbasic.Cursor = Cursors.Hand;
		ckbUuTienMbasic.Location = new Point(9, 451);
		ckbUuTienMbasic.Name = "ckbUuTienMbasic";
		ckbUuTienMbasic.Size = new Size(173, 20);
		ckbUuTienMbasic.TabIndex = 198;
		ckbUuTienMbasic.Text = "Ưu tiên chạy bằng mbasic";
		ckbUuTienMbasic.UseVisualStyleBackColor = true;
		ckbUuTienMbasic.CheckedChanged += ckbUuTienMbasic_CheckedChanged;
		C30C9507.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		C30C9507.BorderStyle = BorderStyle.FixedSingle;
		C30C9507.Controls.Add(CE23E58A);
		C30C9507.Controls.Add(nudCountWallTo);
		C30C9507.Controls.Add(label5);
		C30C9507.Controls.Add(nudCountWallFrom);
		C30C9507.Location = new Point(29, 44);
		C30C9507.Name = "plDangBaiLenTuong";
		C30C9507.Size = new Size(270, 31);
		C30C9507.TabIndex = 1;
		CE23E58A.AutoSize = true;
		CE23E58A.Location = new Point(3, 5);
		CE23E58A.Name = "label4";
		CE23E58A.Size = new Size(84, 16);
		CE23E58A.TabIndex = 49;
		CE23E58A.Text = "Số lượng bài:";
		nudCountWallTo.Location = new Point(187, 3);
		nudCountWallTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountWallTo.Name = "nudCountWallTo";
		nudCountWallTo.Size = new Size(56, 23);
		nudCountWallTo.TabIndex = 48;
		label5.AutoSize = true;
		label5.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label5.Location = new Point(166, 5);
		label5.Name = "label5";
		label5.Size = new Size(18, 16);
		label5.TabIndex = 51;
		label5.Text = ">";
		nudCountWallFrom.Location = new Point(108, 3);
		nudCountWallFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountWallFrom.Name = "nudCountWallFrom";
		nudCountWallFrom.Size = new Size(56, 23);
		nudCountWallFrom.TabIndex = 47;
		plDangBaiLenPage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		plDangBaiLenPage.BorderStyle = BorderStyle.FixedSingle;
		plDangBaiLenPage.Controls.Add(label21);
		plDangBaiLenPage.Controls.Add(nudCountPageTo);
		plDangBaiLenPage.Controls.Add(label23);
		plDangBaiLenPage.Controls.Add(AF1E2127);
		plDangBaiLenPage.Location = new Point(29, 562);
		plDangBaiLenPage.Name = "plDangBaiLenPage";
		plDangBaiLenPage.Size = new Size(270, 27);
		plDangBaiLenPage.TabIndex = 1;
		label21.AutoSize = true;
		label21.Location = new Point(3, 3);
		label21.Name = "label21";
		label21.Size = new Size(95, 16);
		label21.TabIndex = 49;
		label21.Text = "Số lượng page:";
		nudCountPageTo.Location = new Point(187, 1);
		nudCountPageTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountPageTo.Name = "nudCountPageTo";
		nudCountPageTo.Size = new Size(56, 23);
		nudCountPageTo.TabIndex = 48;
		label23.AutoSize = true;
		label23.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label23.Location = new Point(166, 3);
		label23.Name = "label23";
		label23.Size = new Size(18, 16);
		label23.TabIndex = 51;
		label23.Text = ">";
		AF1E2127.Location = new Point(108, 1);
		AF1E2127.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		AF1E2127.Name = "nudCountPageFrom";
		AF1E2127.Size = new Size(56, 23);
		AF1E2127.TabIndex = 47;
		plDangBaiLenNhom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		plDangBaiLenNhom.BorderStyle = BorderStyle.FixedSingle;
		plDangBaiLenNhom.Controls.Add(B8182C33);
		plDangBaiLenNhom.Controls.Add(ckbUuTienNhomNhieuThanhVien);
		plDangBaiLenNhom.Controls.Add(lblTuongTacBaiViet);
		plDangBaiLenNhom.Controls.Add(lblTuongTacNhom);
		plDangBaiLenNhom.Controls.Add(ckbOnlyDangNhomKhongKiemDuyet);
		plDangBaiLenNhom.Controls.Add(C0032632);
		plDangBaiLenNhom.Controls.Add(label12);
		plDangBaiLenNhom.Controls.Add(C4ADA994);
		plDangBaiLenNhom.Controls.Add(ckbTuongTacBaiVietDaDang);
		plDangBaiLenNhom.Controls.Add(ckbTuongTac);
		plDangBaiLenNhom.Controls.Add(nudCountGroupFrom);
		plDangBaiLenNhom.Controls.Add(B6A1A897);
		plDangBaiLenNhom.Controls.Add(label26);
		plDangBaiLenNhom.Location = new Point(29, 103);
		plDangBaiLenNhom.Name = "plDangBaiLenNhom";
		plDangBaiLenNhom.Size = new Size(270, 343);
		plDangBaiLenNhom.TabIndex = 1;
		B8182C33.AutoSize = true;
		B8182C33.Cursor = Cursors.Hand;
		B8182C33.Location = new Point(6, 290);
		B8182C33.Name = "ckbKhongDangTrung";
		B8182C33.Size = new Size(163, 20);
		B8182C33.TabIndex = 2;
		B8182C33.Text = "Không đăng trùng nhóm";
		B8182C33.UseVisualStyleBackColor = true;
		ckbUuTienNhomNhieuThanhVien.AutoSize = true;
		ckbUuTienNhomNhieuThanhVien.Cursor = Cursors.Hand;
		ckbUuTienNhomNhieuThanhVien.Location = new Point(6, 264);
		ckbUuTienNhomNhieuThanhVien.Name = "ckbUuTienNhomNhieuThanhVien";
		ckbUuTienNhomNhieuThanhVien.Size = new Size(250, 20);
		ckbUuTienNhomNhieuThanhVien.TabIndex = 1;
		ckbUuTienNhomNhieuThanhVien.Text = "Ưu tiên đăng nhóm có nhiều thành viên";
		ckbUuTienNhomNhieuThanhVien.UseVisualStyleBackColor = true;
		lblTuongTacBaiViet.AutoSize = true;
		lblTuongTacBaiViet.Cursor = Cursors.Hand;
		lblTuongTacBaiViet.Location = new Point(209, 343);
		lblTuongTacBaiViet.Name = "lblTuongTacBaiViet";
		lblTuongTacBaiViet.Size = new Size(47, 16);
		lblTuongTacBaiViet.TabIndex = 183;
		lblTuongTacBaiViet.TabStop = true;
		lblTuongTacBaiViet.Text = "Cài đặt";
		lblTuongTacBaiViet.LinkClicked += B50FA096;
		lblTuongTacNhom.AutoSize = true;
		lblTuongTacNhom.Cursor = Cursors.Hand;
		lblTuongTacNhom.Location = new Point(209, 317);
		lblTuongTacNhom.Name = "lblTuongTacNhom";
		lblTuongTacNhom.Size = new Size(47, 16);
		lblTuongTacNhom.TabIndex = 183;
		lblTuongTacNhom.TabStop = true;
		lblTuongTacNhom.Text = "Cài đặt";
		lblTuongTacNhom.LinkClicked += lblTuongTacNhom_LinkClicked;
		ckbOnlyDangNhomKhongKiemDuyet.AutoSize = true;
		ckbOnlyDangNhomKhongKiemDuyet.Cursor = Cursors.Hand;
		ckbOnlyDangNhomKhongKiemDuyet.Location = new Point(6, 238);
		ckbOnlyDangNhomKhongKiemDuyet.Name = "ckbOnlyDangNhomKhongKiemDuyet";
		ckbOnlyDangNhomKhongKiemDuyet.Size = new Size(216, 20);
		ckbOnlyDangNhomKhongKiemDuyet.TabIndex = 0;
		ckbOnlyDangNhomKhongKiemDuyet.Text = "Chỉ đăng nhóm không kiểm duyệt";
		ckbOnlyDangNhomKhongKiemDuyet.UseVisualStyleBackColor = true;
		C0032632.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		C0032632.BorderStyle = BorderStyle.FixedSingle;
		C0032632.Controls.Add(A73ACE32);
		C0032632.Controls.Add(rbTuNhap);
		C0032632.Controls.Add(BBA770A1);
		C0032632.Location = new Point(6, 52);
		C0032632.Name = "panel3";
		C0032632.Size = new Size(257, 182);
		C0032632.TabIndex = 67;
		A73ACE32.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		A73ACE32.BorderStyle = BorderStyle.FixedSingle;
		A73ACE32.Controls.Add(txtNhomTuNhap);
		A73ACE32.Controls.Add(AF031B1B);
		A73ACE32.Controls.Add(ckbXoaNhomDaDang);
		A73ACE32.Location = new Point(22, 49);
		A73ACE32.Name = "plTuNhap";
		A73ACE32.Size = new Size(230, 128);
		A73ACE32.TabIndex = 193;
		txtNhomTuNhap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		txtNhomTuNhap.Location = new Point(3, 3);
		txtNhomTuNhap.Name = "txtNhomTuNhap";
		txtNhomTuNhap.Size = new Size(222, 76);
		txtNhomTuNhap.TabIndex = 34;
		txtNhomTuNhap.Text = "";
		txtNhomTuNhap.WordWrap = false;
		txtNhomTuNhap.TextChanged += F323AFB5;
		AF031B1B.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		AF031B1B.AutoSize = true;
		AF031B1B.Cursor = Cursors.Hand;
		AF031B1B.Location = new Point(3, 82);
		AF031B1B.Name = "ckbChiDangNhomDaThamGia";
		AF031B1B.Size = new Size(184, 20);
		AF031B1B.TabIndex = 33;
		AF031B1B.Text = "Chỉ đăng nhóm đã tham gia";
		AF031B1B.UseVisualStyleBackColor = true;
		AF031B1B.CheckedChanged += B4289791;
		ckbXoaNhomDaDang.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		ckbXoaNhomDaDang.AutoSize = true;
		ckbXoaNhomDaDang.Cursor = Cursors.Hand;
		ckbXoaNhomDaDang.Location = new Point(3, 104);
		ckbXoaNhomDaDang.Name = "ckbXoaNhomDaDang";
		ckbXoaNhomDaDang.Size = new Size(150, 20);
		ckbXoaNhomDaDang.TabIndex = 33;
		ckbXoaNhomDaDang.Text = "Xóa ID nhóm đã đăng";
		ckbXoaNhomDaDang.UseVisualStyleBackColor = true;
		rbTuNhap.AutoSize = true;
		rbTuNhap.Cursor = Cursors.Hand;
		rbTuNhap.Location = new Point(3, 27);
		rbTuNhap.Name = "rbTuNhap";
		rbTuNhap.Size = new Size(197, 20);
		rbTuNhap.TabIndex = 1;
		rbTuNhap.Text = "Nhóm do người dùng nhập (0)";
		rbTuNhap.UseVisualStyleBackColor = true;
		rbTuNhap.CheckedChanged += rbTuNhap_CheckedChanged;
		BBA770A1.AutoSize = true;
		BBA770A1.Checked = true;
		BBA770A1.Cursor = Cursors.Hand;
		BBA770A1.Location = new Point(3, 3);
		BBA770A1.Name = "rbRandom";
		BBA770A1.Size = new Size(197, 20);
		BBA770A1.TabIndex = 0;
		BBA770A1.TabStop = true;
		BBA770A1.Text = "Ngẫu nhiên nhóm đã tham gia";
		BBA770A1.UseVisualStyleBackColor = true;
		label12.AutoSize = true;
		label12.Location = new Point(3, 31);
		label12.Name = "label12";
		label12.Size = new Size(100, 16);
		label12.TabIndex = 66;
		label12.Text = "Tùy chọn nhóm:";
		C4ADA994.Location = new Point(187, 4);
		C4ADA994.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C4ADA994.Name = "nudCountGroupTo";
		C4ADA994.Size = new Size(56, 23);
		C4ADA994.TabIndex = 53;
		ckbTuongTacBaiVietDaDang.AutoSize = true;
		ckbTuongTacBaiVietDaDang.Cursor = Cursors.Hand;
		ckbTuongTacBaiVietDaDang.Location = new Point(6, 342);
		ckbTuongTacBaiVietDaDang.Name = "ckbTuongTacBaiVietDaDang";
		ckbTuongTacBaiVietDaDang.Size = new Size(179, 20);
		ckbTuongTacBaiVietDaDang.TabIndex = 57;
		ckbTuongTacBaiVietDaDang.Text = "Tương tác ba\u0300i viê\u0301t đa\u0303 đăng";
		ckbTuongTacBaiVietDaDang.UseVisualStyleBackColor = true;
		ckbTuongTacBaiVietDaDang.CheckedChanged += ckbTuongTacBaiVietDaDang_CheckedChanged;
		ckbTuongTac.AutoSize = true;
		ckbTuongTac.Cursor = Cursors.Hand;
		ckbTuongTac.Location = new Point(6, 316);
		ckbTuongTac.Name = "ckbTuongTac";
		ckbTuongTac.Size = new Size(206, 20);
		ckbTuongTac.TabIndex = 57;
		ckbTuongTac.Text = "Tương tác nhóm trước khi đăng";
		ckbTuongTac.UseVisualStyleBackColor = true;
		ckbTuongTac.CheckedChanged += ckbTuongTac_CheckedChanged;
		nudCountGroupFrom.Location = new Point(108, 4);
		nudCountGroupFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountGroupFrom.Name = "nudCountGroupFrom";
		nudCountGroupFrom.Size = new Size(56, 23);
		nudCountGroupFrom.TabIndex = 52;
		B6A1A897.AutoSize = true;
		B6A1A897.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		B6A1A897.Location = new Point(166, 6);
		B6A1A897.Name = "label24";
		B6A1A897.Size = new Size(18, 16);
		B6A1A897.TabIndex = 56;
		B6A1A897.Text = ">";
		label26.AutoSize = true;
		label26.Location = new Point(3, 6);
		label26.Name = "label26";
		label26.Size = new Size(99, 16);
		label26.TabIndex = 54;
		label26.Text = "Số lượng nhóm:";
		ckbDangBaiLenPage.AutoSize = true;
		ckbDangBaiLenPage.Cursor = Cursors.Hand;
		ckbDangBaiLenPage.Location = new Point(9, 540);
		ckbDangBaiLenPage.Name = "ckbDangBaiLenPage";
		ckbDangBaiLenPage.Size = new Size(130, 20);
		ckbDangBaiLenPage.TabIndex = 0;
		ckbDangBaiLenPage.Text = "Đăng bài lên page";
		ckbDangBaiLenPage.UseVisualStyleBackColor = true;
		ckbDangBaiLenPage.CheckedChanged += E4A63B1A;
		A8384EA2.AutoSize = true;
		A8384EA2.Cursor = Cursors.Hand;
		A8384EA2.Location = new Point(9, 81);
		A8384EA2.Name = "ckbDangBaiLenNhom";
		A8384EA2.Size = new Size(134, 20);
		A8384EA2.TabIndex = 0;
		A8384EA2.Text = "Đăng bài lên nhóm";
		A8384EA2.UseVisualStyleBackColor = true;
		A8384EA2.CheckedChanged += A8384EA2_CheckedChanged;
		ckbDangBaiLenTuong.AutoSize = true;
		ckbDangBaiLenTuong.Cursor = Cursors.Hand;
		ckbDangBaiLenTuong.Location = new Point(9, 22);
		ckbDangBaiLenTuong.Name = "ckbDangBaiLenTuong";
		ckbDangBaiLenTuong.Size = new Size(135, 20);
		ckbDangBaiLenTuong.TabIndex = 0;
		ckbDangBaiLenTuong.Text = "Đăng bài lên tường";
		ckbDangBaiLenTuong.UseVisualStyleBackColor = true;
		ckbDangBaiLenTuong.CheckedChanged += ckbDangBaiLenTuong_CheckedChanged;
		nudDelayTo.Location = new Point(228, 78);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(56, 23);
		nudDelayTo.TabIndex = 58;
		nudDelayFrom.Location = new Point(131, 78);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(56, 23);
		nudDelayFrom.TabIndex = 57;
		C2271A37.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C2271A37.Location = new Point(193, 80);
		C2271A37.Name = "label20";
		C2271A37.Size = new Size(29, 16);
		C2271A37.TabIndex = 61;
		C2271A37.Text = ">";
		C2271A37.TextAlign = ContentAlignment.MiddleCenter;
		B5AB5B2B.AutoSize = true;
		B5AB5B2B.Location = new Point(27, 80);
		B5AB5B2B.Name = "label15";
		B5AB5B2B.Size = new Size(87, 16);
		B5AB5B2B.TabIndex = 59;
		B5AB5B2B.Text = "Gia\u0303n ca\u0301ch (s):";
		btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(395, 600);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		txtTenHanhDong.Location = new Point(131, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(153, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new Point(27, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		D7B29C96.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		D7B29C96.BackColor = Color.Maroon;
		D7B29C96.Cursor = Cursors.Hand;
		D7B29C96.FlatAppearance.BorderSize = 0;
		D7B29C96.FlatStyle = FlatStyle.Flat;
		D7B29C96.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		D7B29C96.ForeColor = Color.White;
		D7B29C96.Location = new Point(494, 600);
		D7B29C96.Name = "btnCancel";
		D7B29C96.Size = new Size(92, 29);
		D7B29C96.TabIndex = 4;
		D7B29C96.Text = "Đóng";
		D7B29C96.UseVisualStyleBackColor = false;
		D7B29C96.Click += F381218B;
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
		bunifuCards1.Size = new Size(978, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(981, 643);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDDangBai";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDDangBai_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		AD98C02F.ResumeLayout(performLayout: false);
		AD98C02F.PerformLayout();
		plCopyPost.ResumeLayout(performLayout: false);
		plCopyPost.PerformLayout();
		plVanBan.ResumeLayout(performLayout: false);
		plVanBan.PerformLayout();
		plAnh.ResumeLayout(performLayout: false);
		plAnh.PerformLayout();
		plNotUseAvatar.ResumeLayout(performLayout: false);
		plNotUseAvatar.PerformLayout();
		((ISupportInitialize)nudSoLuongAnhFrom).EndInit();
		((ISupportInitialize)nudSoLuongAnhTo).EndInit();
		grTuyChon.ResumeLayout(performLayout: false);
		grTuyChon.PerformLayout();
		C30C9507.ResumeLayout(performLayout: false);
		C30C9507.PerformLayout();
		((ISupportInitialize)nudCountWallTo).EndInit();
		((ISupportInitialize)nudCountWallFrom).EndInit();
		plDangBaiLenPage.ResumeLayout(performLayout: false);
		plDangBaiLenPage.PerformLayout();
		((ISupportInitialize)nudCountPageTo).EndInit();
		((ISupportInitialize)AF1E2127).EndInit();
		plDangBaiLenNhom.ResumeLayout(performLayout: false);
		plDangBaiLenNhom.PerformLayout();
		C0032632.ResumeLayout(performLayout: false);
		C0032632.PerformLayout();
		A73ACE32.ResumeLayout(performLayout: false);
		A73ACE32.PerformLayout();
		((ISupportInitialize)C4ADA994).EndInit();
		((ISupportInitialize)nudCountGroupFrom).EndInit();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
