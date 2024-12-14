using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDShareBaiTut : Form
{
	private GClass11 F7AC0B98;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private List<string> AC36E481 = new List<string>();

	private IContainer EDB77008 = null;

	private BunifuDragControl E1BCD305;

	private BunifuDragControl AF02EF8F;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards E1B681AE;

	private Panel C6A9FF07;

	private Button A0AD8519;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox ckbVanBan;

	private Panel plVanBan;

	private Label FEB6209C;

	private RichTextBox txtNoiDung;

	private Button C5163018;

	private Button btnUp;

	private NumericUpDown BD12C535;

	private NumericUpDown B12B6C06;

	private Label label20;

	private Label label19;

	private Label label15;

	private GroupBox F6857D08;

	private Panel plDangBaiLenPage;

	private Label D089A992;

	private Label label22;

	private NumericUpDown nudCountPageTo;

	private Label label23;

	private NumericUpDown nudCountPageFrom;

	private Panel E515B63D;

	private NumericUpDown nudCountGroupTo;

	private NumericUpDown nudCountGroupFrom;

	private Label label24;

	private Label label25;

	private Label label26;

	private CheckBox ckbShareBaiLenPage;

	private CheckBox ckbShareBaiLenNhom;

	private CheckBox BC06330F;

	private Button AE8FCD14;

	private Button button2;

	private RadioButton rbNganCachKyTu;

	private RadioButton rbNganCachMoiDong;

	private Label F9836811;

	private Label B325931F;

	private Label label2;

	private CheckBox ckbOnlyShareNhomKhongKiemDuyet;

	private CheckBox ckbKhongPhaiLinkFacebook;

	private RadioButton rbShareVip;

	private RadioButton AC8EB237;

	private Label D201273C;

	private Panel B23176AC;

	private Label B69F3E2B;

	private Label label6;

	private Label label53;

	private NumericUpDown DDA4D5B3;

	private NumericUpDown nudTuongTacDelayTo;

	private Label label7;

	private NumericUpDown nudTuongTacFrom;

	private Label EBB35203;

	private CheckBox ckbTuongTacComment;

	private NumericUpDown nudTuongTacDelayFrom;

	private Label label51;

	private CheckBox ckbTuongTacLike;

	private Label label50;

	private CheckBox A490EE1A;

	private Panel A91C399C;

	private Button button4;

	private Button C2A41016;

	private RadioButton radioButton1;

	private RadioButton E0AB6B9D;

	private Label label4;

	private Label BE85FA1C;

	private RichTextBox B697E3B2;

	private Label D2BDAD29;

	private LinkLabel linkLabel1;

	private Button C8A9380B;

	private Button button7;

	private LinkLabel linkLabel2;

	private Panel panel4;

	private CheckBox D08BE489;

	private CheckBox ckbUuTienNhomNhieuThanhVien;

	private CheckBox ckbCauHinhNangCao;

	private Panel panel3;

	private Button button8;

	private RadioButton B20A9F2F;

	private RadioButton rbRandom;

	private Label EFBE9FBD;

	private CheckBox AEBB9837;

	private Panel panel5;

	private Label E101523D;

	private NumericUpDown D2301A97;

	private NumericUpDown nudTimeWatchFrom;

	private Label AF3707A6;

	private Label label13;

	private RadioButton rbShareTut;

	private RichTextBox B723F59B;

	private NumericUpDown nudTimeWaitTo1;

	private NumericUpDown nudTimeWaitFrom1;

	private Label label18;

	private Label label17;

	private Label EE31271E;

	private NumericUpDown nudTimeWaitTo2;

	private NumericUpDown nudTimeWaitFrom2;

	private Label label29;

	private Label label28;

	private Label label27;

	private RadioButton rbToken;

	private RadioButton E698AF86;

	private RadioButton F086D320;

	private Label label30;

	private ToolTip toolTip_0;

	private CheckBox ckbXoaBai;

	public fHDShareBaiTut(string AD23E614, int int_1 = 0, string string_3 = "")
	{
		B735CEAB();
		bool_0 = false;
		string_0 = AD23E614;
		string_2 = string_3;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Share bài";
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
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
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
		F7AC0B98 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(label1);
		F7AB102E.smethod_1(label15);
		F7AB102E.smethod_1(label20);
		F7AB102E.smethod_1(label19);
		F7AB102E.smethod_1(F6857D08);
		F7AB102E.smethod_1(BC06330F);
		F7AB102E.smethod_1(ckbShareBaiLenNhom);
		F7AB102E.smethod_1(label26);
		F7AB102E.smethod_1(label24);
		F7AB102E.smethod_1(label25);
		F7AB102E.smethod_1(ckbOnlyShareNhomKhongKiemDuyet);
		F7AB102E.smethod_1(ckbShareBaiLenPage);
		F7AB102E.smethod_1(D089A992);
		F7AB102E.smethod_1(label23);
		F7AB102E.smethod_1(label22);
		F7AB102E.smethod_1(label2);
		F7AB102E.smethod_1(ckbVanBan);
		F7AB102E.smethod_1(FEB6209C);
		F7AB102E.smethod_1(B325931F);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(btnCancel);
		F7AB102E.smethod_1(rbNganCachMoiDong);
		F7AB102E.smethod_1(rbNganCachKyTu);
	}

	private void fHDShareBaiTut_Load(object sender, EventArgs e)
	{
		try
		{
			B12B6C06.Value = F7AC0B98.method_2("nudDelayFrom", 3);
			BD12C535.Value = F7AC0B98.method_2("nudDelayTo", 5);
			BC06330F.Checked = F7AC0B98.method_3("ckbShareBaiLenTuong");
			ckbShareBaiLenNhom.Checked = F7AC0B98.method_3("ckbShareBaiLenNhom");
			nudCountGroupFrom.Value = F7AC0B98.method_2("nudCountGroupFrom", 1);
			nudCountGroupTo.Value = F7AC0B98.method_2("nudCountGroupTo", 1);
			nudTimeWaitFrom1.Value = F7AC0B98.method_2("nudTimeWaitFrom1", 1);
			nudTimeWaitTo1.Value = F7AC0B98.method_2("nudTimeWaitTo1", 1);
			nudTimeWaitFrom2.Value = F7AC0B98.method_2("nudTimeWaitFrom2", 10);
			nudTimeWaitTo2.Value = F7AC0B98.method_2("nudTimeWaitTo2", 10);
			switch (F7AC0B98.method_2("typeLoad"))
			{
			case 0:
				F086D320.Checked = true;
				break;
			case 1:
				E698AF86.Checked = true;
				break;
			case 2:
				rbToken.Checked = true;
				break;
			}
			if (F7AC0B98.method_2("typeShare") == 0)
			{
				rbRandom.Checked = true;
			}
			else
			{
				B20A9F2F.Checked = true;
			}
			AEBB9837.Checked = F7AC0B98.method_3("ckbXemVideo");
			nudTimeWatchFrom.Value = F7AC0B98.method_2("nudTimeWatchFrom");
			D2301A97.Value = F7AC0B98.method_2("nudTimeWatchTo");
			AC36E481 = F7AC0B98.C5A69DA0("lstNhomTuNhap");
			ckbCauHinhNangCao.Checked = F7AC0B98.method_3("ckbCauHinhNangCao");
			ckbOnlyShareNhomKhongKiemDuyet.Checked = F7AC0B98.method_3("ckbOnlyShareNhomKhongKiemDuyet");
			ckbUuTienNhomNhieuThanhVien.Checked = F7AC0B98.method_3("ckbUuTienNhomNhieuThanhVien");
			D08BE489.Checked = F7AC0B98.method_3("ckbKhongShareTrung");
			ckbXoaBai.Checked = F7AC0B98.method_3("ckbXoaBai");
			A490EE1A.Checked = F7AC0B98.method_3("ckbTuongTac");
			nudTuongTacFrom.Value = F7AC0B98.method_2("nudTuongTacFrom", 3);
			DDA4D5B3.Value = F7AC0B98.method_2("nudTuongTacTo", 5);
			nudTuongTacDelayFrom.Value = F7AC0B98.method_2("nudTuongTacDelayFrom", 5);
			nudTuongTacDelayTo.Value = F7AC0B98.method_2("nudTuongTacDelayTo", 7);
			ckbTuongTacLike.Checked = F7AC0B98.method_3("ckbTuongTacLike");
			ckbTuongTacComment.Checked = F7AC0B98.method_3("ckbTuongTacComment");
			B697E3B2.Text = F7AC0B98.C0288288("txtComment");
			ckbShareBaiLenPage.Checked = F7AC0B98.method_3("ckbShareBaiLenPage");
			nudCountPageFrom.Value = F7AC0B98.method_2("nudCountPageFrom", 1);
			nudCountPageTo.Value = F7AC0B98.method_2("nudCountPageTo", 1);
			B723F59B.Text = F7AC0B98.C0288288("txtLinkChiaSe");
			switch (F7AC0B98.method_2("kieuShare"))
			{
			case 0:
				AC8EB237.Checked = true;
				break;
			case 1:
				rbShareVip.Checked = true;
				break;
			default:
				rbShareTut.Checked = true;
				break;
			}
			ckbKhongPhaiLinkFacebook.Checked = F7AC0B98.method_3("ckbKhongPhaiLinkFacebook");
			ckbVanBan.Checked = F7AC0B98.method_3("ckbVanBan");
			txtNoiDung.Text = F7AC0B98.C0288288("txtNoiDung");
			if (F7AC0B98.method_2("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
		}
		catch (Exception)
		{
		}
		A49A6083();
	}

	private void A0AD8519_Click(object sender, EventArgs e)
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
		GClass11 gClass = new GClass11();
		gClass.method_4("nudDelayFrom", B12B6C06.Value);
		gClass.method_4("nudDelayTo", BD12C535.Value);
		gClass.method_4("ckbShareBaiLenTuong", BC06330F.Checked);
		gClass.method_4("ckbShareBaiLenNhom", ckbShareBaiLenNhom.Checked);
		gClass.method_4("nudCountGroupFrom", nudCountGroupFrom.Value);
		gClass.method_4("nudCountGroupTo", nudCountGroupTo.Value);
		gClass.method_4("nudTimeWaitFrom1", nudTimeWaitFrom1.Value);
		gClass.method_4("nudTimeWaitTo1", nudTimeWaitTo1.Value);
		gClass.method_4("nudTimeWaitFrom2", nudTimeWaitFrom2.Value);
		gClass.method_4("nudTimeWaitTo2", nudTimeWaitFrom2.Value);
		int num = 0;
		if (E698AF86.Checked)
		{
			num = 1;
		}
		else if (rbToken.Checked)
		{
			num = 2;
		}
		gClass.method_4("typeLoad", num);
		int num2 = 0;
		if (B20A9F2F.Checked)
		{
			num2 = 1;
		}
		gClass.method_4("typeShare", num2);
		gClass.method_4("ckbXemVideo", AEBB9837.Checked);
		gClass.method_4("nudTimeWatchFrom", nudTimeWatchFrom.Value);
		gClass.method_4("nudTimeWatchTo", D2301A97.Value);
		gClass.method_5("lstNhomTuNhap", AC36E481);
		gClass.method_4("ckbCauHinhNangCao", ckbCauHinhNangCao.Checked);
		gClass.method_4("ckbOnlyShareNhomKhongKiemDuyet", ckbOnlyShareNhomKhongKiemDuyet.Checked);
		gClass.method_4("ckbUuTienNhomNhieuThanhVien", ckbUuTienNhomNhieuThanhVien.Checked);
		gClass.method_4("ckbKhongShareTrung", D08BE489.Checked);
		gClass.method_4("ckbXoaBai", ckbXoaBai.Checked);
		gClass.method_4("ckbTuongTac", A490EE1A.Checked);
		gClass.method_4("nudTuongTacFrom", nudTuongTacFrom.Value);
		gClass.method_4("nudTuongTacTo", nudTuongTacFrom.Value);
		gClass.method_4("nudTuongTacDelayFrom", nudTuongTacDelayFrom.Value);
		gClass.method_4("nudTuongTacDelayTo", nudTuongTacDelayTo.Value);
		gClass.method_4("ckbTuongTacLike", ckbTuongTacLike.Checked);
		gClass.method_4("ckbTuongTacComment", ckbTuongTacComment.Checked);
		gClass.method_4("txtComment", B697E3B2.Text);
		gClass.method_4("ckbShareBaiLenPage", ckbShareBaiLenPage.Checked);
		gClass.method_4("nudCountPageFrom", nudCountPageFrom.Value);
		gClass.method_4("nudCountPageTo", nudCountPageTo.Value);
		gClass.method_4("txtLinkChiaSe", B723F59B.Text.Trim());
		int num3 = 0;
		if (rbShareVip.Checked)
		{
			num3 = 1;
		}
		else if (rbShareTut.Checked)
		{
			num3 = 2;
		}
		gClass.method_4("kieuShare", num3);
		gClass.method_4("ckbKhongPhaiLinkFacebook", ckbKhongPhaiLinkFacebook.Checked);
		gClass.method_4("ckbVanBan", ckbVanBan.Checked);
		gClass.method_4("txtNoiDung", txtNoiDung.Text.Trim());
		int num4 = 0;
		if (rbNganCachKyTu.Checked)
		{
			num4 = 1;
		}
		gClass.method_4("typeNganCach", num4);
		string text2 = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1(F7AB102E.smethod_0("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, text2))
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
			if (Class147.smethod_13(string_2, text, text2))
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

	private void A49A6083()
	{
		method_1(null, null);
		CF05EC9A(null, null);
		A137A33A(null, null);
		D111059A(null, null);
		ckbShareBaiLenPage_CheckedChanged(null, null);
		ckbVanBan_CheckedChanged(null, null);
		D8B8540F(null, null);
		E698AF86_CheckedChanged(null, null);
		DB2B2E11(null, null);
		ckbTuongTacComment_CheckedChanged(null, null);
		B20A9F2F_CheckedChanged(null, null);
		ckbCauHinhNangCao_CheckedChanged(null, null);
		AEBB9837_CheckedChanged(null, null);
	}

	private void ckbVanBan_CheckedChanged(object sender, EventArgs e)
	{
		plVanBan.Enabled = ckbVanBan.Checked;
	}

	private void DEA828B4(object sender, EventArgs e)
	{
		B888BD14();
	}

	private void B888BD14()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? txtNoiDung.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtNoiDung.Lines.ToList());
			list = GClass8.smethod_36(list);
			FEB6209C.Text = string.Format(F7AB102E.smethod_0("Danh sa\u0301ch nô\u0323i dung ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void AC193BB4(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			btnUp.Visible = true;
			C5163018.Visible = true;
		}
	}

	private void C5163018_Click(object sender, EventArgs e)
	{
		plVanBan.Height = 216;
	}

	private void EB809135(object sender, EventArgs e)
	{
		plVanBan.Height = 169;
	}

	private void D111059A(object sender, EventArgs e)
	{
		E515B63D.Enabled = ckbShareBaiLenNhom.Checked;
	}

	private void ckbShareBaiLenPage_CheckedChanged(object sender, EventArgs e)
	{
		plDangBaiLenPage.Enabled = ckbShareBaiLenPage.Checked;
	}

	private void E0A6B2A4(object sender, EventArgs e)
	{
		GClass29.smethod_0(F7AB102E.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		txtNoiDung.Focus();
	}

	private void AE8FCD14_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHelpNhapComment());
		txtNoiDung.Focus();
	}

	private void EDA995B4(object sender, EventArgs e)
	{
		B888BD14();
	}

	private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
	{
		B888BD14();
	}

	private void A137A33A(object sender, EventArgs e)
	{
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void CF05EC9A(object sender, EventArgs e)
	{
	}

	private void B723F59B_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(B723F59B, label2);
	}

	private void E698AF86_CheckedChanged(object sender, EventArgs e)
	{
		ckbKhongPhaiLinkFacebook.Enabled = !rbShareVip.Checked;
		if (rbShareVip.Checked)
		{
			ckbKhongPhaiLinkFacebook.Checked = false;
		}
	}

	private void ckbKhongPhaiLinkFacebook_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void D8B8540F(object sender, EventArgs e)
	{
	}

	private void DB2B2E11(object sender, EventArgs e)
	{
		B23176AC.Enabled = A490EE1A.Checked;
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void ckbTuongTacComment_CheckedChanged(object sender, EventArgs e)
	{
		A91C399C.Enabled = ckbTuongTacComment.Checked;
	}

	private void B697E3B2_TextChanged(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		list = B697E3B2.Lines.ToList();
		list = GClass8.smethod_36(list);
		D2BDAD29.Text = string.Format(F7AB102E.smethod_0("Danh sa\u0301ch comment ({0}):"), list.Count.ToString());
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.smethod_33(new E3962B82());
	}

	private void C8A9380B_Click(object sender, EventArgs e)
	{
		GClass29.smethod_0(F7AB102E.smethod_0("Có thể dùng [u] để thay thế tên của người nhận tin nhắn!"));
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.smethod_33(new E3962B82());
	}

	private void button7_Click(object sender, EventArgs e)
	{
		GClass29.smethod_0(F7AB102E.smethod_0("Có thể dùng [u] để thay thế tên của người nhận tin nhắn!"));
	}

	private void B20A9F2F_CheckedChanged(object sender, EventArgs e)
	{
		button8.Enabled = B20A9F2F.Checked;
	}

	private void ckbCauHinhNangCao_CheckedChanged(object sender, EventArgs e)
	{
		panel4.Enabled = ckbCauHinhNangCao.Checked;
	}

	private void C437DA39(object sender, EventArgs e)
	{
		string path = Guid.NewGuid().ToString() + ".txt";
		GClass8.smethod_33(new fNhapDuLieu1(path, "Nhâ\u0323p danh sa\u0301ch ID nho\u0301m", "Danh sa\u0301ch ID nho\u0301m", "(Mô\u0303i nô\u0323i dung 1 do\u0300ng)", AC36E481));
		AC36E481 = File.ReadAllLines(path).ToList();
		try
		{
			File.Delete(path);
		}
		catch
		{
		}
	}

	private void AEBB9837_CheckedChanged(object sender, EventArgs e)
	{
		panel5.Enabled = AEBB9837.Checked;
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && EDB77008 != null)
		{
			EDB77008.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void B735CEAB()
	{
		EDB77008 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDShareBaiTut));
		E1BCD305 = new BunifuDragControl(EDB77008);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		AF02EF8F = new BunifuDragControl(EDB77008);
		C6A9FF07 = new Panel();
		A0AD8519 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		B723F59B = new RichTextBox();
		panel5 = new Panel();
		E101523D = new Label();
		D2301A97 = new NumericUpDown();
		nudTimeWatchFrom = new NumericUpDown();
		AF3707A6 = new Label();
		label13 = new Label();
		AEBB9837 = new CheckBox();
		rbShareTut = new RadioButton();
		rbShareVip = new RadioButton();
		AC8EB237 = new RadioButton();
		D201273C = new Label();
		ckbKhongPhaiLinkFacebook = new CheckBox();
		label2 = new Label();
		F6857D08 = new GroupBox();
		plDangBaiLenPage = new Panel();
		D089A992 = new Label();
		label22 = new Label();
		nudCountPageTo = new NumericUpDown();
		label23 = new Label();
		nudCountPageFrom = new NumericUpDown();
		E515B63D = new Panel();
		panel4 = new Panel();
		ckbXoaBai = new CheckBox();
		D08BE489 = new CheckBox();
		ckbUuTienNhomNhieuThanhVien = new CheckBox();
		ckbOnlyShareNhomKhongKiemDuyet = new CheckBox();
		ckbCauHinhNangCao = new CheckBox();
		panel3 = new Panel();
		button8 = new Button();
		B20A9F2F = new RadioButton();
		rbRandom = new RadioButton();
		rbToken = new RadioButton();
		EFBE9FBD = new Label();
		E698AF86 = new RadioButton();
		B23176AC = new Panel();
		A91C399C = new Panel();
		button7 = new Button();
		linkLabel2 = new LinkLabel();
		button4 = new Button();
		C2A41016 = new Button();
		radioButton1 = new RadioButton();
		E0AB6B9D = new RadioButton();
		label4 = new Label();
		BE85FA1C = new Label();
		B697E3B2 = new RichTextBox();
		D2BDAD29 = new Label();
		B69F3E2B = new Label();
		label6 = new Label();
		label53 = new Label();
		DDA4D5B3 = new NumericUpDown();
		nudTuongTacDelayTo = new NumericUpDown();
		label7 = new Label();
		nudTuongTacFrom = new NumericUpDown();
		EBB35203 = new Label();
		ckbTuongTacComment = new CheckBox();
		nudTuongTacDelayFrom = new NumericUpDown();
		label51 = new Label();
		ckbTuongTacLike = new CheckBox();
		label50 = new Label();
		F086D320 = new RadioButton();
		label30 = new Label();
		A490EE1A = new CheckBox();
		nudTimeWaitTo2 = new NumericUpDown();
		nudTimeWaitTo1 = new NumericUpDown();
		nudCountGroupTo = new NumericUpDown();
		nudTimeWaitFrom2 = new NumericUpDown();
		nudTimeWaitFrom1 = new NumericUpDown();
		nudCountGroupFrom = new NumericUpDown();
		label29 = new Label();
		label18 = new Label();
		label24 = new Label();
		label28 = new Label();
		label17 = new Label();
		label25 = new Label();
		label27 = new Label();
		EE31271E = new Label();
		label26 = new Label();
		ckbShareBaiLenPage = new CheckBox();
		ckbShareBaiLenNhom = new CheckBox();
		BC06330F = new CheckBox();
		BD12C535 = new NumericUpDown();
		B12B6C06 = new NumericUpDown();
		label20 = new Label();
		label19 = new Label();
		label15 = new Label();
		plVanBan = new Panel();
		C8A9380B = new Button();
		linkLabel1 = new LinkLabel();
		AE8FCD14 = new Button();
		button2 = new Button();
		rbNganCachKyTu = new RadioButton();
		rbNganCachMoiDong = new RadioButton();
		F9836811 = new Label();
		B325931F = new Label();
		C5163018 = new Button();
		btnUp = new Button();
		txtNoiDung = new RichTextBox();
		FEB6209C = new Label();
		btnAdd = new Button();
		ckbVanBan = new CheckBox();
		txtTenHanhDong = new TextBox();
		label1 = new Label();
		btnCancel = new Button();
		E1B681AE = new BunifuCards();
		toolTip_0 = new ToolTip(EDB77008);
		C6A9FF07.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		panel5.SuspendLayout();
		((ISupportInitialize)D2301A97).BeginInit();
		((ISupportInitialize)nudTimeWatchFrom).BeginInit();
		F6857D08.SuspendLayout();
		plDangBaiLenPage.SuspendLayout();
		((ISupportInitialize)nudCountPageTo).BeginInit();
		((ISupportInitialize)nudCountPageFrom).BeginInit();
		E515B63D.SuspendLayout();
		panel4.SuspendLayout();
		panel3.SuspendLayout();
		B23176AC.SuspendLayout();
		A91C399C.SuspendLayout();
		((ISupportInitialize)DDA4D5B3).BeginInit();
		((ISupportInitialize)nudTuongTacDelayTo).BeginInit();
		((ISupportInitialize)nudTuongTacFrom).BeginInit();
		((ISupportInitialize)nudTuongTacDelayFrom).BeginInit();
		((ISupportInitialize)nudTimeWaitTo2).BeginInit();
		((ISupportInitialize)nudTimeWaitTo1).BeginInit();
		((ISupportInitialize)nudCountGroupTo).BeginInit();
		((ISupportInitialize)nudTimeWaitFrom2).BeginInit();
		((ISupportInitialize)nudTimeWaitFrom1).BeginInit();
		((ISupportInitialize)nudCountGroupFrom).BeginInit();
		((ISupportInitialize)BD12C535).BeginInit();
		((ISupportInitialize)B12B6C06).BeginInit();
		plVanBan.SuspendLayout();
		E1B681AE.SuspendLayout();
		SuspendLayout();
		E1BCD305.Fixed = true;
		E1BCD305.Horizontal = true;
		E1BCD305.TargetControl = bunifuCustomLabel1;
		E1BCD305.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(1097, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Share bài";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		AF02EF8F.Fixed = true;
		AF02EF8F.Horizontal = true;
		AF02EF8F.TargetControl = C6A9FF07;
		AF02EF8F.Vertical = true;
		C6A9FF07.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		C6A9FF07.BackColor = Color.White;
		C6A9FF07.Controls.Add(A0AD8519);
		C6A9FF07.Controls.Add(pictureBox1);
		C6A9FF07.Controls.Add(bunifuCustomLabel1);
		C6A9FF07.Cursor = Cursors.SizeAll;
		C6A9FF07.Location = new Point(0, 3);
		C6A9FF07.Name = "pnlHeader";
		C6A9FF07.Size = new Size(1097, 31);
		C6A9FF07.TabIndex = 9;
		A0AD8519.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		A0AD8519.Cursor = Cursors.Hand;
		A0AD8519.FlatAppearance.BorderSize = 0;
		A0AD8519.FlatStyle = FlatStyle.Flat;
		A0AD8519.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		A0AD8519.ForeColor = Color.White;
		A0AD8519.Image = (Image)componentResourceManager.GetObject("button1.Image");
		A0AD8519.Location = new Point(1066, 1);
		A0AD8519.Name = "button1";
		A0AD8519.Size = new Size(30, 30);
		A0AD8519.TabIndex = 0;
		A0AD8519.TextImageRelation = TextImageRelation.ImageBeforeText;
		A0AD8519.UseVisualStyleBackColor = true;
		A0AD8519.Click += A0AD8519_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += AC193BB4;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(B723F59B);
		panel1.Controls.Add(panel5);
		panel1.Controls.Add(AEBB9837);
		panel1.Controls.Add(rbShareTut);
		panel1.Controls.Add(rbShareVip);
		panel1.Controls.Add(AC8EB237);
		panel1.Controls.Add(D201273C);
		panel1.Controls.Add(ckbKhongPhaiLinkFacebook);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(F6857D08);
		panel1.Controls.Add(BD12C535);
		panel1.Controls.Add(B12B6C06);
		panel1.Controls.Add(label20);
		panel1.Controls.Add(label19);
		panel1.Controls.Add(label15);
		panel1.Controls.Add(plVanBan);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(ckbVanBan);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(E1B681AE);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(1100, 612);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		B723F59B.Location = new Point(14, 136);
		B723F59B.Name = "txtLinkChiaSe";
		B723F59B.Size = new Size(378, 98);
		B723F59B.TabIndex = 71;
		B723F59B.Text = "";
		B723F59B.TextChanged += B723F59B_TextChanged;
		panel5.BorderStyle = BorderStyle.FixedSingle;
		panel5.Controls.Add(E101523D);
		panel5.Controls.Add(D2301A97);
		panel5.Controls.Add(nudTimeWatchFrom);
		panel5.Controls.Add(AF3707A6);
		panel5.Controls.Add(label13);
		panel5.Location = new Point(33, 284);
		panel5.Name = "panel5";
		panel5.Size = new Size(298, 30);
		panel5.TabIndex = 70;
		E101523D.AutoSize = true;
		E101523D.Location = new Point(5, 6);
		E101523D.Name = "label14";
		E101523D.Size = new Size(93, 16);
		E101523D.TabIndex = 61;
		E101523D.Text = "Thời gian xem:";
		D2301A97.Location = new Point(204, 3);
		D2301A97.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D2301A97.Name = "nudTimeWatchTo";
		D2301A97.Size = new Size(56, 23);
		D2301A97.TabIndex = 58;
		nudTimeWatchFrom.Location = new Point(107, 3);
		nudTimeWatchFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeWatchFrom.Name = "nudTimeWatchFrom";
		nudTimeWatchFrom.Size = new Size(56, 23);
		nudTimeWatchFrom.TabIndex = 57;
		AF3707A6.AutoSize = true;
		AF3707A6.Location = new Point(169, 5);
		AF3707A6.Name = "label12";
		AF3707A6.Size = new Size(28, 16);
		AF3707A6.TabIndex = 60;
		AF3707A6.Text = "đê\u0301n";
		label13.AutoSize = true;
		label13.Location = new Point(263, 5);
		label13.Name = "label13";
		label13.Size = new Size(30, 16);
		label13.TabIndex = 59;
		label13.Text = "giây";
		AEBB9837.AutoSize = true;
		AEBB9837.Cursor = Cursors.Hand;
		AEBB9837.Location = new Point(14, 263);
		AEBB9837.Name = "ckbXemVideo";
		AEBB9837.Size = new Size(176, 20);
		AEBB9837.TabIndex = 69;
		AEBB9837.Text = "Xem video trước khi share";
		AEBB9837.UseVisualStyleBackColor = true;
		AEBB9837.CheckedChanged += AEBB9837_CheckedChanged;
		rbShareTut.AutoSize = true;
		rbShareTut.Cursor = Cursors.Hand;
		rbShareTut.Location = new Point(276, 237);
		rbShareTut.Name = "rbShareTut";
		rbShareTut.Size = new Size(121, 20);
		rbShareTut.TabIndex = 68;
		rbShareTut.TabStop = true;
		rbShareTut.Text = "Post bài thay link";
		rbShareTut.UseVisualStyleBackColor = true;
		rbShareTut.CheckedChanged += E698AF86_CheckedChanged;
		rbShareVip.AutoSize = true;
		rbShareVip.Cursor = Cursors.Hand;
		rbShareVip.Location = new Point(194, 237);
		rbShareVip.Name = "rbShareVip";
		rbShareVip.Size = new Size(81, 20);
		rbShareVip.TabIndex = 68;
		rbShareVip.TabStop = true;
		rbShareVip.Text = "Share Vip";
		rbShareVip.UseVisualStyleBackColor = true;
		rbShareVip.CheckedChanged += E698AF86_CheckedChanged;
		AC8EB237.AutoSize = true;
		AC8EB237.Checked = true;
		AC8EB237.Cursor = Cursors.Hand;
		AC8EB237.Location = new Point(90, 237);
		AC8EB237.Name = "rbShareThuong";
		AC8EB237.Size = new Size(103, 20);
		AC8EB237.TabIndex = 67;
		AC8EB237.TabStop = true;
		AC8EB237.Text = "Share thường";
		AC8EB237.UseVisualStyleBackColor = true;
		AC8EB237.CheckedChanged += D8B8540F;
		D201273C.AutoSize = true;
		D201273C.Location = new Point(11, 239);
		D201273C.Name = "label3";
		D201273C.Size = new Size(72, 16);
		D201273C.TabIndex = 66;
		D201273C.Text = "Kiểu share:";
		ckbKhongPhaiLinkFacebook.AutoSize = true;
		ckbKhongPhaiLinkFacebook.Cursor = Cursors.Hand;
		ckbKhongPhaiLinkFacebook.Location = new Point(14, 318);
		ckbKhongPhaiLinkFacebook.Name = "ckbKhongPhaiLinkFacebook";
		ckbKhongPhaiLinkFacebook.Size = new Size(264, 20);
		ckbKhongPhaiLinkFacebook.TabIndex = 65;
		ckbKhongPhaiLinkFacebook.Text = "Link cần chia sẻ không phải của Facebook";
		ckbKhongPhaiLinkFacebook.UseVisualStyleBackColor = true;
		ckbKhongPhaiLinkFacebook.CheckedChanged += ckbKhongPhaiLinkFacebook_CheckedChanged;
		label2.AutoSize = true;
		label2.Location = new Point(11, 116);
		label2.Name = "label2";
		label2.Size = new Size(136, 16);
		label2.TabIndex = 64;
		label2.Text = "Link bài cần share (0):";
		F6857D08.Controls.Add(plDangBaiLenPage);
		F6857D08.Controls.Add(E515B63D);
		F6857D08.Controls.Add(ckbShareBaiLenPage);
		F6857D08.Controls.Add(ckbShareBaiLenNhom);
		F6857D08.Controls.Add(BC06330F);
		F6857D08.Location = new Point(407, 94);
		F6857D08.Name = "groupBox2";
		F6857D08.Size = new Size(679, 462);
		F6857D08.TabIndex = 62;
		F6857D08.TabStop = false;
		F6857D08.Text = "Tùy chọn share";
		plDangBaiLenPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		plDangBaiLenPage.BorderStyle = BorderStyle.FixedSingle;
		plDangBaiLenPage.Controls.Add(D089A992);
		plDangBaiLenPage.Controls.Add(label22);
		plDangBaiLenPage.Controls.Add(nudCountPageTo);
		plDangBaiLenPage.Controls.Add(label23);
		plDangBaiLenPage.Controls.Add(nudCountPageFrom);
		plDangBaiLenPage.Location = new Point(33, 430);
		plDangBaiLenPage.Name = "plDangBaiLenPage";
		plDangBaiLenPage.Size = new Size(312, 27);
		plDangBaiLenPage.TabIndex = 1;
		D089A992.AutoSize = true;
		D089A992.Location = new Point(3, 3);
		D089A992.Name = "label21";
		D089A992.Size = new Size(95, 16);
		D089A992.TabIndex = 49;
		D089A992.Text = "Số lượng page:";
		label22.AutoSize = true;
		label22.Location = new Point(264, 3);
		label22.Name = "label22";
		label22.Size = new Size(35, 16);
		label22.TabIndex = 50;
		label22.Text = "page";
		nudCountPageTo.Location = new Point(205, 1);
		nudCountPageTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountPageTo.Name = "nudCountPageTo";
		nudCountPageTo.Size = new Size(56, 23);
		nudCountPageTo.TabIndex = 48;
		label23.AutoSize = true;
		label23.Location = new Point(170, 3);
		label23.Name = "label23";
		label23.Size = new Size(28, 16);
		label23.TabIndex = 51;
		label23.Text = "đê\u0301n";
		nudCountPageFrom.Location = new Point(108, 1);
		nudCountPageFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountPageFrom.Name = "nudCountPageFrom";
		nudCountPageFrom.Size = new Size(56, 23);
		nudCountPageFrom.TabIndex = 47;
		E515B63D.BorderStyle = BorderStyle.FixedSingle;
		E515B63D.Controls.Add(panel4);
		E515B63D.Controls.Add(ckbCauHinhNangCao);
		E515B63D.Controls.Add(panel3);
		E515B63D.Controls.Add(rbToken);
		E515B63D.Controls.Add(EFBE9FBD);
		E515B63D.Controls.Add(E698AF86);
		E515B63D.Controls.Add(B23176AC);
		E515B63D.Controls.Add(F086D320);
		E515B63D.Controls.Add(label30);
		E515B63D.Controls.Add(A490EE1A);
		E515B63D.Controls.Add(nudTimeWaitTo2);
		E515B63D.Controls.Add(nudTimeWaitTo1);
		E515B63D.Controls.Add(nudCountGroupTo);
		E515B63D.Controls.Add(nudTimeWaitFrom2);
		E515B63D.Controls.Add(nudTimeWaitFrom1);
		E515B63D.Controls.Add(nudCountGroupFrom);
		E515B63D.Controls.Add(label29);
		E515B63D.Controls.Add(label18);
		E515B63D.Controls.Add(label24);
		E515B63D.Controls.Add(label28);
		E515B63D.Controls.Add(label17);
		E515B63D.Controls.Add(label25);
		E515B63D.Controls.Add(label27);
		E515B63D.Controls.Add(EE31271E);
		E515B63D.Controls.Add(label26);
		E515B63D.Location = new Point(33, 72);
		E515B63D.Name = "plDangBaiLenNhom";
		E515B63D.Size = new Size(637, 329);
		E515B63D.TabIndex = 1;
		panel4.BorderStyle = BorderStyle.FixedSingle;
		panel4.Controls.Add(ckbXoaBai);
		panel4.Controls.Add(D08BE489);
		panel4.Controls.Add(ckbUuTienNhomNhieuThanhVien);
		panel4.Controls.Add(ckbOnlyShareNhomKhongKiemDuyet);
		panel4.Location = new Point(19, 210);
		panel4.Name = "panel4";
		panel4.Size = new Size(287, 107);
		panel4.TabIndex = 69;
		ckbXoaBai.AutoSize = true;
		ckbXoaBai.Cursor = Cursors.Hand;
		ckbXoaBai.Location = new Point(3, 81);
		ckbXoaBai.Name = "ckbXoaBai";
		ckbXoaBai.Size = new Size(247, 20);
		ckbXoaBai.TabIndex = 2;
		ckbXoaBai.Text = "Xóa bài khi đăng vào nhóm kiểm duyệt";
		ckbXoaBai.UseVisualStyleBackColor = true;
		D08BE489.AutoSize = true;
		D08BE489.Cursor = Cursors.Hand;
		D08BE489.Location = new Point(3, 55);
		D08BE489.Name = "ckbKhongShareTrung";
		D08BE489.Size = new Size(167, 20);
		D08BE489.TabIndex = 2;
		D08BE489.Text = "Không share trùng nhóm";
		D08BE489.UseVisualStyleBackColor = true;
		ckbUuTienNhomNhieuThanhVien.AutoSize = true;
		ckbUuTienNhomNhieuThanhVien.Cursor = Cursors.Hand;
		ckbUuTienNhomNhieuThanhVien.Location = new Point(3, 29);
		ckbUuTienNhomNhieuThanhVien.Name = "ckbUuTienNhomNhieuThanhVien";
		ckbUuTienNhomNhieuThanhVien.Size = new Size(254, 20);
		ckbUuTienNhomNhieuThanhVien.TabIndex = 1;
		ckbUuTienNhomNhieuThanhVien.Text = "Ưu tiên share nhóm có nhiều thành viên";
		ckbUuTienNhomNhieuThanhVien.UseVisualStyleBackColor = true;
		ckbOnlyShareNhomKhongKiemDuyet.AutoSize = true;
		ckbOnlyShareNhomKhongKiemDuyet.Cursor = Cursors.Hand;
		ckbOnlyShareNhomKhongKiemDuyet.Location = new Point(3, 3);
		ckbOnlyShareNhomKhongKiemDuyet.Name = "ckbOnlyShareNhomKhongKiemDuyet";
		ckbOnlyShareNhomKhongKiemDuyet.Size = new Size(220, 20);
		ckbOnlyShareNhomKhongKiemDuyet.TabIndex = 0;
		ckbOnlyShareNhomKhongKiemDuyet.Text = "Chỉ share nhóm không kiểm duyệt";
		ckbOnlyShareNhomKhongKiemDuyet.UseVisualStyleBackColor = true;
		ckbCauHinhNangCao.AutoSize = true;
		ckbCauHinhNangCao.Location = new Point(6, 187);
		ckbCauHinhNangCao.Name = "ckbCauHinhNangCao";
		ckbCauHinhNangCao.Size = new Size(132, 20);
		ckbCauHinhNangCao.TabIndex = 68;
		ckbCauHinhNangCao.Text = "Cấu hình nâng cao";
		ckbCauHinhNangCao.UseVisualStyleBackColor = true;
		ckbCauHinhNangCao.CheckedChanged += ckbCauHinhNangCao_CheckedChanged;
		panel3.BorderStyle = BorderStyle.FixedSingle;
		panel3.Controls.Add(button8);
		panel3.Controls.Add(B20A9F2F);
		panel3.Controls.Add(rbRandom);
		panel3.Location = new Point(19, 130);
		panel3.Name = "panel3";
		panel3.Size = new Size(287, 54);
		panel3.TabIndex = 67;
		button8.Cursor = Cursors.Hand;
		button8.Location = new Point(207, 27);
		button8.Name = "button8";
		button8.Size = new Size(75, 23);
		button8.TabIndex = 2;
		button8.Text = "Nhập";
		button8.UseVisualStyleBackColor = true;
		button8.Click += C437DA39;
		B20A9F2F.AutoSize = true;
		B20A9F2F.Cursor = Cursors.Hand;
		B20A9F2F.Location = new Point(3, 29);
		B20A9F2F.Name = "rbTuNhap";
		B20A9F2F.Size = new Size(176, 20);
		B20A9F2F.TabIndex = 1;
		B20A9F2F.Text = "Nhóm do người dùng nhập";
		B20A9F2F.UseVisualStyleBackColor = true;
		B20A9F2F.CheckedChanged += B20A9F2F_CheckedChanged;
		rbRandom.AutoSize = true;
		rbRandom.Checked = true;
		rbRandom.Cursor = Cursors.Hand;
		rbRandom.Location = new Point(3, 3);
		rbRandom.Name = "rbRandom";
		rbRandom.Size = new Size(197, 20);
		rbRandom.TabIndex = 0;
		rbRandom.TabStop = true;
		rbRandom.Text = "Ngẫu nhiên nhóm đã tham gia";
		rbRandom.UseVisualStyleBackColor = true;
		rbToken.AutoSize = true;
		rbToken.Cursor = Cursors.Hand;
		rbToken.Location = new Point(271, 85);
		rbToken.Name = "rbToken";
		rbToken.Size = new Size(60, 20);
		rbToken.TabIndex = 68;
		rbToken.TabStop = true;
		rbToken.Text = "Token";
		toolTip_0.SetToolTip(rbToken, "Cân bằng giữa 2 loại cookie");
		rbToken.UseVisualStyleBackColor = true;
		rbToken.CheckedChanged += E698AF86_CheckedChanged;
		EFBE9FBD.AutoSize = true;
		EFBE9FBD.Location = new Point(3, 111);
		EFBE9FBD.Name = "label11";
		EFBE9FBD.Size = new Size(154, 16);
		EFBE9FBD.TabIndex = 66;
		EFBE9FBD.Text = "Tùy chọn nhóm để share:";
		E698AF86.AutoSize = true;
		E698AF86.Cursor = Cursors.Hand;
		E698AF86.Location = new Point(173, 85);
		E698AF86.Name = "rbCookieV2";
		E698AF86.Size = new Size(82, 20);
		E698AF86.TabIndex = 68;
		E698AF86.TabStop = true;
		E698AF86.Text = "Cookie V2";
		toolTip_0.SetToolTip(E698AF86, "Load nhóm chuẩn, dễ die nick");
		E698AF86.UseVisualStyleBackColor = true;
		E698AF86.CheckedChanged += E698AF86_CheckedChanged;
		B23176AC.BorderStyle = BorderStyle.FixedSingle;
		B23176AC.Controls.Add(A91C399C);
		B23176AC.Controls.Add(B69F3E2B);
		B23176AC.Controls.Add(label6);
		B23176AC.Controls.Add(label53);
		B23176AC.Controls.Add(DDA4D5B3);
		B23176AC.Controls.Add(nudTuongTacDelayTo);
		B23176AC.Controls.Add(label7);
		B23176AC.Controls.Add(nudTuongTacFrom);
		B23176AC.Controls.Add(EBB35203);
		B23176AC.Controls.Add(ckbTuongTacComment);
		B23176AC.Controls.Add(nudTuongTacDelayFrom);
		B23176AC.Controls.Add(label51);
		B23176AC.Controls.Add(ckbTuongTacLike);
		B23176AC.Controls.Add(label50);
		B23176AC.Location = new Point(340, 30);
		B23176AC.Name = "plInteractGroup";
		B23176AC.Size = new Size(290, 277);
		B23176AC.TabIndex = 65;
		A91C399C.BorderStyle = BorderStyle.FixedSingle;
		A91C399C.Controls.Add(button7);
		A91C399C.Controls.Add(linkLabel2);
		A91C399C.Controls.Add(button4);
		A91C399C.Controls.Add(C2A41016);
		A91C399C.Controls.Add(radioButton1);
		A91C399C.Controls.Add(E0AB6B9D);
		A91C399C.Controls.Add(label4);
		A91C399C.Controls.Add(BE85FA1C);
		A91C399C.Controls.Add(B697E3B2);
		A91C399C.Controls.Add(D2BDAD29);
		A91C399C.Location = new Point(8, 101);
		A91C399C.Name = "panel2";
		A91C399C.Size = new Size(275, 168);
		A91C399C.TabIndex = 104;
		button7.Cursor = Cursors.Help;
		button7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button7.Location = new Point(244, 144);
		button7.Name = "button7";
		button7.Size = new Size(23, 23);
		button7.TabIndex = 192;
		button7.Text = "?";
		button7.UseVisualStyleBackColor = true;
		button7.Click += button7_Click;
		linkLabel2.AutoSize = true;
		linkLabel2.Cursor = Cursors.Hand;
		linkLabel2.Location = new Point(164, 147);
		linkLabel2.Name = "linkLabel2";
		linkLabel2.Size = new Size(81, 16);
		linkLabel2.TabIndex = 191;
		linkLabel2.TabStop = true;
		linkLabel2.Text = "Random icon";
		linkLabel2.LinkClicked += linkLabel2_LinkClicked;
		button4.Cursor = Cursors.Help;
		button4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button4.Location = new Point(230, 189);
		button4.Name = "button4";
		button4.Size = new Size(21, 23);
		button4.TabIndex = 44;
		button4.Text = "?";
		button4.UseVisualStyleBackColor = true;
		C2A41016.Cursor = Cursors.Help;
		C2A41016.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C2A41016.Location = new Point(230, 166);
		C2A41016.Name = "button5";
		C2A41016.Size = new Size(21, 23);
		C2A41016.TabIndex = 45;
		C2A41016.Text = "?";
		C2A41016.UseVisualStyleBackColor = true;
		radioButton1.AutoSize = true;
		radioButton1.Cursor = Cursors.Hand;
		radioButton1.Location = new Point(71, 189);
		radioButton1.Name = "radioButton1";
		radioButton1.Size = new Size(159, 20);
		radioButton1.TabIndex = 42;
		radioButton1.Text = "Nội dung có nhiều dòng";
		radioButton1.UseVisualStyleBackColor = true;
		E0AB6B9D.AutoSize = true;
		E0AB6B9D.Checked = true;
		E0AB6B9D.Cursor = Cursors.Hand;
		E0AB6B9D.Location = new Point(71, 168);
		E0AB6B9D.Name = "radioButton2";
		E0AB6B9D.Size = new Size(155, 20);
		E0AB6B9D.TabIndex = 43;
		E0AB6B9D.TabStop = true;
		E0AB6B9D.Text = "Nội dung chỉ có 1 dòng";
		E0AB6B9D.UseVisualStyleBackColor = true;
		label4.AutoSize = true;
		label4.Location = new Point(6, 168);
		label4.Name = "label4";
		label4.Size = new Size(64, 16);
		label4.TabIndex = 41;
		label4.Text = "Tùy chọn:";
		BE85FA1C.AutoSize = true;
		BE85FA1C.Location = new Point(5, 147);
		BE85FA1C.Name = "label10";
		BE85FA1C.Size = new Size(143, 16);
		BE85FA1C.TabIndex = 40;
		BE85FA1C.Text = "(Spin nội dung {a|b|c})";
		B697E3B2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		B697E3B2.Location = new Point(7, 26);
		B697E3B2.Name = "txtComment";
		B697E3B2.Size = new Size(260, 119);
		B697E3B2.TabIndex = 34;
		B697E3B2.Text = "";
		B697E3B2.WordWrap = false;
		B697E3B2.TextChanged += B697E3B2_TextChanged;
		D2BDAD29.AutoSize = true;
		D2BDAD29.Location = new Point(3, 5);
		D2BDAD29.Name = "lblComment";
		D2BDAD29.Size = new Size(149, 16);
		D2BDAD29.TabIndex = 0;
		D2BDAD29.Text = "Danh sa\u0301ch comment (0):";
		B69F3E2B.AutoSize = true;
		B69F3E2B.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		B69F3E2B.Location = new Point(3, 6);
		B69F3E2B.Name = "label5";
		B69F3E2B.Size = new Size(109, 16);
		B69F3E2B.TabIndex = 99;
		B69F3E2B.Text = "Sô\u0301 ba\u0300i viết/nhóm:";
		label6.AutoSize = true;
		label6.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label6.Location = new Point(160, 7);
		label6.Name = "label6";
		label6.Size = new Size(28, 16);
		label6.TabIndex = 103;
		label6.Text = "đê\u0301n";
		label53.AutoSize = true;
		label53.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label53.Location = new Point(160, 33);
		label53.Name = "label53";
		label53.Size = new Size(28, 16);
		label53.TabIndex = 103;
		label53.Text = "đê\u0301n";
		DDA4D5B3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		DDA4D5B3.Location = new Point(190, 4);
		DDA4D5B3.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		DDA4D5B3.Name = "nudTuongTacTo";
		DDA4D5B3.Size = new Size(47, 23);
		DDA4D5B3.TabIndex = 94;
		DDA4D5B3.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		nudTuongTacDelayTo.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		nudTuongTacDelayTo.Location = new Point(190, 30);
		nudTuongTacDelayTo.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		nudTuongTacDelayTo.Name = "nudTuongTacDelayTo";
		nudTuongTacDelayTo.Size = new Size(47, 23);
		nudTuongTacDelayTo.TabIndex = 94;
		nudTuongTacDelayTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		label7.AutoSize = true;
		label7.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label7.Location = new Point(240, 7);
		label7.Name = "label7";
		label7.Size = new Size(24, 16);
		label7.TabIndex = 102;
		label7.Text = "bài";
		nudTuongTacFrom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		nudTuongTacFrom.Location = new Point(113, 3);
		nudTuongTacFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		nudTuongTacFrom.Name = "nudTuongTacFrom";
		nudTuongTacFrom.Size = new Size(42, 23);
		nudTuongTacFrom.TabIndex = 92;
		nudTuongTacFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		EBB35203.AutoSize = true;
		EBB35203.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		EBB35203.Location = new Point(240, 32);
		EBB35203.Name = "label52";
		EBB35203.Size = new Size(30, 16);
		EBB35203.TabIndex = 102;
		EBB35203.Text = "giây";
		ckbTuongTacComment.AutoSize = true;
		ckbTuongTacComment.Cursor = Cursors.Hand;
		ckbTuongTacComment.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		ckbTuongTacComment.Location = new Point(113, 79);
		ckbTuongTacComment.Name = "ckbTuongTacComment";
		ckbTuongTacComment.Size = new Size(81, 20);
		ckbTuongTacComment.TabIndex = 96;
		ckbTuongTacComment.Text = "Comment";
		ckbTuongTacComment.UseVisualStyleBackColor = true;
		ckbTuongTacComment.CheckedChanged += ckbTuongTacComment_CheckedChanged;
		nudTuongTacDelayFrom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		nudTuongTacDelayFrom.Location = new Point(113, 30);
		nudTuongTacDelayFrom.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		nudTuongTacDelayFrom.Name = "nudTuongTacDelayFrom";
		nudTuongTacDelayFrom.Size = new Size(42, 23);
		nudTuongTacDelayFrom.TabIndex = 93;
		nudTuongTacDelayFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		label51.AutoSize = true;
		label51.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label51.Location = new Point(3, 33);
		label51.Name = "label51";
		label51.Size = new Size(99, 16);
		label51.TabIndex = 101;
		label51.Text = "Thơ\u0300i gian delay:";
		ckbTuongTacLike.AutoSize = true;
		ckbTuongTacLike.Cursor = Cursors.Hand;
		ckbTuongTacLike.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		ckbTuongTacLike.Location = new Point(113, 58);
		ckbTuongTacLike.Name = "ckbTuongTacLike";
		ckbTuongTacLike.Size = new Size(48, 20);
		ckbTuongTacLike.TabIndex = 95;
		ckbTuongTacLike.Text = "Like";
		ckbTuongTacLike.UseVisualStyleBackColor = true;
		label50.AutoSize = true;
		label50.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label50.Location = new Point(3, 59);
		label50.Name = "label50";
		label50.Size = new Size(93, 16);
		label50.TabIndex = 100;
		label50.Text = "Loa\u0323i tương ta\u0301c:";
		F086D320.AutoSize = true;
		F086D320.Checked = true;
		F086D320.Cursor = Cursors.Hand;
		F086D320.Location = new Point(85, 85);
		F086D320.Name = "rbCookieV1";
		F086D320.Size = new Size(82, 20);
		F086D320.TabIndex = 67;
		F086D320.TabStop = true;
		F086D320.Text = "Cookie V1";
		toolTip_0.SetToolTip(F086D320, "Ít die nick, k ổn định");
		F086D320.UseVisualStyleBackColor = true;
		F086D320.CheckedChanged += D8B8540F;
		label30.AutoSize = true;
		label30.Location = new Point(6, 87);
		label30.Name = "label30";
		label30.Size = new Size(75, 16);
		label30.TabIndex = 66;
		label30.Text = "Load nhóm:";
		A490EE1A.AutoSize = true;
		A490EE1A.Cursor = Cursors.Hand;
		A490EE1A.Location = new Point(340, 7);
		A490EE1A.Name = "ckbTuongTac";
		A490EE1A.Size = new Size(210, 20);
		A490EE1A.TabIndex = 57;
		A490EE1A.Text = "Tương tác nhóm trước khi share";
		A490EE1A.UseVisualStyleBackColor = true;
		A490EE1A.CheckedChanged += DB2B2E11;
		nudTimeWaitTo2.Location = new Point(219, 58);
		nudTimeWaitTo2.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeWaitTo2.Name = "nudTimeWaitTo2";
		nudTimeWaitTo2.Size = new Size(56, 23);
		nudTimeWaitTo2.TabIndex = 53;
		nudTimeWaitTo1.Location = new Point(219, 32);
		nudTimeWaitTo1.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeWaitTo1.Name = "nudTimeWaitTo1";
		nudTimeWaitTo1.Size = new Size(56, 23);
		nudTimeWaitTo1.TabIndex = 53;
		nudCountGroupTo.Location = new Point(219, 6);
		nudCountGroupTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountGroupTo.Name = "nudCountGroupTo";
		nudCountGroupTo.Size = new Size(56, 23);
		nudCountGroupTo.TabIndex = 53;
		nudTimeWaitFrom2.Location = new Point(122, 58);
		nudTimeWaitFrom2.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeWaitFrom2.Name = "nudTimeWaitFrom2";
		nudTimeWaitFrom2.Size = new Size(56, 23);
		nudTimeWaitFrom2.TabIndex = 52;
		nudTimeWaitFrom1.Location = new Point(122, 32);
		nudTimeWaitFrom1.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeWaitFrom1.Name = "nudTimeWaitFrom1";
		nudTimeWaitFrom1.Size = new Size(56, 23);
		nudTimeWaitFrom1.TabIndex = 52;
		nudCountGroupFrom.Location = new Point(122, 6);
		nudCountGroupFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountGroupFrom.Name = "nudCountGroupFrom";
		nudCountGroupFrom.Size = new Size(56, 23);
		nudCountGroupFrom.TabIndex = 52;
		label29.AutoSize = true;
		label29.Location = new Point(184, 60);
		label29.Name = "label29";
		label29.Size = new Size(28, 16);
		label29.TabIndex = 56;
		label29.Text = "đê\u0301n";
		label18.AutoSize = true;
		label18.Location = new Point(184, 34);
		label18.Name = "label18";
		label18.Size = new Size(28, 16);
		label18.TabIndex = 56;
		label18.Text = "đê\u0301n";
		label24.AutoSize = true;
		label24.Location = new Point(184, 8);
		label24.Name = "label24";
		label24.Size = new Size(28, 16);
		label24.TabIndex = 56;
		label24.Text = "đê\u0301n";
		label28.AutoSize = true;
		label28.Location = new Point(278, 60);
		label28.Name = "label28";
		label28.Size = new Size(30, 16);
		label28.TabIndex = 55;
		label28.Text = "giây";
		label17.AutoSize = true;
		label17.Location = new Point(278, 34);
		label17.Name = "label17";
		label17.Size = new Size(30, 16);
		label17.TabIndex = 55;
		label17.Text = "giây";
		label25.AutoSize = true;
		label25.Location = new Point(278, 8);
		label25.Name = "label25";
		label25.Size = new Size(39, 16);
		label25.TabIndex = 55;
		label25.Text = "nhóm";
		label27.AutoSize = true;
		label27.Location = new Point(3, 60);
		label27.Name = "label27";
		label27.Size = new Size(109, 16);
		label27.TabIndex = 54;
		label27.Text = "Khoảng cách edit:";
		toolTip_0.SetToolTip(label27, "Thời gian chờ giữa 2 lần edit");
		EE31271E.AutoSize = true;
		EE31271E.Location = new Point(3, 34);
		EE31271E.Name = "label16";
		EE31271E.Size = new Size(82, 16);
		EE31271E.TabIndex = 54;
		EE31271E.Text = "Chờ sửa link:";
		toolTip_0.SetToolTip(EE31271E, "Thời gian chờ sau khi đăng m.fb");
		label26.AutoSize = true;
		label26.Location = new Point(3, 8);
		label26.Name = "label26";
		label26.Size = new Size(99, 16);
		label26.TabIndex = 54;
		label26.Text = "Số lượng nhóm:";
		ckbShareBaiLenPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		ckbShareBaiLenPage.AutoSize = true;
		ckbShareBaiLenPage.Cursor = Cursors.Hand;
		ckbShareBaiLenPage.Location = new Point(10, 407);
		ckbShareBaiLenPage.Name = "ckbShareBaiLenPage";
		ckbShareBaiLenPage.Size = new Size(134, 20);
		ckbShareBaiLenPage.TabIndex = 0;
		ckbShareBaiLenPage.Text = "Share bài lên page";
		ckbShareBaiLenPage.UseVisualStyleBackColor = true;
		ckbShareBaiLenPage.CheckedChanged += ckbShareBaiLenPage_CheckedChanged;
		ckbShareBaiLenNhom.AutoSize = true;
		ckbShareBaiLenNhom.Cursor = Cursors.Hand;
		ckbShareBaiLenNhom.Location = new Point(10, 48);
		ckbShareBaiLenNhom.Name = "ckbShareBaiLenNhom";
		ckbShareBaiLenNhom.Size = new Size(138, 20);
		ckbShareBaiLenNhom.TabIndex = 0;
		ckbShareBaiLenNhom.Text = "Share bài lên nhóm";
		ckbShareBaiLenNhom.UseVisualStyleBackColor = true;
		ckbShareBaiLenNhom.CheckedChanged += D111059A;
		BC06330F.AutoSize = true;
		BC06330F.Cursor = Cursors.Hand;
		BC06330F.Location = new Point(10, 22);
		BC06330F.Name = "ckbShareBaiLenTuong";
		BC06330F.Size = new Size(139, 20);
		BC06330F.TabIndex = 0;
		BC06330F.Text = "Share bài lên tường";
		BC06330F.UseVisualStyleBackColor = true;
		BC06330F.CheckedChanged += A137A33A;
		BD12C535.Location = new Point(235, 79);
		BD12C535.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		BD12C535.Name = "nudDelayTo";
		BD12C535.Size = new Size(56, 23);
		BD12C535.TabIndex = 58;
		B12B6C06.Location = new Point(138, 79);
		B12B6C06.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		B12B6C06.Name = "nudDelayFrom";
		B12B6C06.Size = new Size(56, 23);
		B12B6C06.TabIndex = 57;
		label20.AutoSize = true;
		label20.Location = new Point(200, 81);
		label20.Name = "label20";
		label20.Size = new Size(28, 16);
		label20.TabIndex = 61;
		label20.Text = "đê\u0301n";
		label19.AutoSize = true;
		label19.Location = new Point(294, 81);
		label19.Name = "label19";
		label19.Size = new Size(30, 16);
		label19.TabIndex = 60;
		label19.Text = "giây";
		label15.AutoSize = true;
		label15.Location = new Point(11, 81);
		label15.Name = "label15";
		label15.Size = new Size(120, 16);
		label15.TabIndex = 59;
		label15.Text = "Khoảng cách share:";
		plVanBan.BorderStyle = BorderStyle.FixedSingle;
		plVanBan.Controls.Add(C8A9380B);
		plVanBan.Controls.Add(linkLabel1);
		plVanBan.Controls.Add(AE8FCD14);
		plVanBan.Controls.Add(button2);
		plVanBan.Controls.Add(rbNganCachKyTu);
		plVanBan.Controls.Add(rbNganCachMoiDong);
		plVanBan.Controls.Add(F9836811);
		plVanBan.Controls.Add(B325931F);
		plVanBan.Controls.Add(C5163018);
		plVanBan.Controls.Add(btnUp);
		plVanBan.Controls.Add(txtNoiDung);
		plVanBan.Controls.Add(FEB6209C);
		plVanBan.Location = new Point(33, 371);
		plVanBan.Name = "plVanBan";
		plVanBan.Size = new Size(359, 169);
		plVanBan.TabIndex = 33;
		C8A9380B.Cursor = Cursors.Help;
		C8A9380B.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C8A9380B.Location = new Point(328, 145);
		C8A9380B.Name = "button6";
		C8A9380B.Size = new Size(23, 23);
		C8A9380B.TabIndex = 191;
		C8A9380B.Text = "?";
		C8A9380B.UseVisualStyleBackColor = true;
		C8A9380B.Click += C8A9380B_Click;
		linkLabel1.AutoSize = true;
		linkLabel1.Cursor = Cursors.Hand;
		linkLabel1.Location = new Point(245, 148);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new Size(81, 16);
		linkLabel1.TabIndex = 190;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "Random icon";
		linkLabel1.LinkClicked += linkLabel1_LinkClicked;
		AE8FCD14.Cursor = Cursors.Help;
		AE8FCD14.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		AE8FCD14.Location = new Point(230, 189);
		AE8FCD14.Name = "button3";
		AE8FCD14.Size = new Size(21, 23);
		AE8FCD14.TabIndex = 44;
		AE8FCD14.Text = "?";
		AE8FCD14.UseVisualStyleBackColor = true;
		AE8FCD14.Click += AE8FCD14_Click;
		button2.Cursor = Cursors.Help;
		button2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button2.Location = new Point(230, 166);
		button2.Name = "button2";
		button2.Size = new Size(21, 23);
		button2.TabIndex = 45;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += E0A6B2A4;
		rbNganCachKyTu.AutoSize = true;
		rbNganCachKyTu.Cursor = Cursors.Hand;
		rbNganCachKyTu.Location = new Point(71, 189);
		rbNganCachKyTu.Name = "rbNganCachKyTu";
		rbNganCachKyTu.Size = new Size(159, 20);
		rbNganCachKyTu.TabIndex = 42;
		rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		rbNganCachKyTu.UseVisualStyleBackColor = true;
		rbNganCachKyTu.CheckedChanged += rbNganCachKyTu_CheckedChanged;
		rbNganCachMoiDong.AutoSize = true;
		rbNganCachMoiDong.Checked = true;
		rbNganCachMoiDong.Cursor = Cursors.Hand;
		rbNganCachMoiDong.Location = new Point(71, 168);
		rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		rbNganCachMoiDong.Size = new Size(155, 20);
		rbNganCachMoiDong.TabIndex = 43;
		rbNganCachMoiDong.TabStop = true;
		rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		rbNganCachMoiDong.UseVisualStyleBackColor = true;
		rbNganCachMoiDong.CheckedChanged += EDA995B4;
		F9836811.AutoSize = true;
		F9836811.Location = new Point(6, 168);
		F9836811.Name = "label9";
		F9836811.Size = new Size(64, 16);
		F9836811.TabIndex = 41;
		F9836811.Text = "Tùy chọn:";
		B325931F.AutoSize = true;
		B325931F.Location = new Point(5, 147);
		B325931F.Name = "label8";
		B325931F.Size = new Size(143, 16);
		B325931F.TabIndex = 40;
		B325931F.Text = "(Spin nội dung {a|b|c})";
		C5163018.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		C5163018.BackgroundImage = C50FB39E.Bitmap_89;
		C5163018.Cursor = Cursors.Hand;
		C5163018.FlatAppearance.BorderColor = Color.Silver;
		C5163018.FlatStyle = FlatStyle.Flat;
		C5163018.Location = new Point(302, -1);
		C5163018.Name = "btnDown";
		C5163018.Size = new Size(25, 25);
		C5163018.TabIndex = 38;
		C5163018.Click += C5163018_Click;
		btnUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		btnUp.BackgroundImage = C50FB39E.Bitmap_74;
		btnUp.Cursor = Cursors.Hand;
		btnUp.FlatAppearance.BorderColor = Color.Silver;
		btnUp.FlatStyle = FlatStyle.Flat;
		btnUp.Location = new Point(333, -1);
		btnUp.Name = "btnUp";
		btnUp.Size = new Size(25, 25);
		btnUp.TabIndex = 39;
		btnUp.Click += EB809135;
		txtNoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		txtNoiDung.Location = new Point(7, 26);
		txtNoiDung.Name = "txtNoiDung";
		txtNoiDung.Size = new Size(344, 119);
		txtNoiDung.TabIndex = 34;
		txtNoiDung.Text = "";
		txtNoiDung.WordWrap = false;
		txtNoiDung.TextChanged += DEA828B4;
		FEB6209C.AutoSize = true;
		FEB6209C.Location = new Point(3, 5);
		FEB6209C.Name = "lblStatus";
		FEB6209C.Size = new Size(145, 16);
		FEB6209C.TabIndex = 0;
		FEB6209C.Text = "Danh sa\u0301ch nô\u0323i dung (0):";
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(453, 570);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		ckbVanBan.AutoSize = true;
		ckbVanBan.Cursor = Cursors.Hand;
		ckbVanBan.Location = new Point(14, 344);
		ckbVanBan.Name = "ckbVanBan";
		ckbVanBan.Size = new Size(112, 20);
		ckbVanBan.TabIndex = 32;
		ckbVanBan.Text = "Nội dung share";
		ckbVanBan.UseVisualStyleBackColor = true;
		ckbVanBan.CheckedChanged += ckbVanBan_CheckedChanged;
		txtTenHanhDong.Location = new Point(138, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(193, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new Point(11, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(563, 570);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		E1B681AE.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		E1B681AE.BackColor = Color.White;
		E1B681AE.BorderRadius = 0;
		E1B681AE.BottomSahddow = true;
		E1B681AE.color = Color.DarkViolet;
		E1B681AE.Controls.Add(C6A9FF07);
		E1B681AE.LeftSahddow = false;
		E1B681AE.Location = new Point(1, 0);
		E1B681AE.Name = "bunifuCards1";
		E1B681AE.RightSahddow = true;
		E1B681AE.ShadowDepth = 20;
		E1B681AE.Size = new Size(1097, 37);
		E1B681AE.TabIndex = 28;
		toolTip_0.AutomaticDelay = 100;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(1100, 612);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDShareBaiTut";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDShareBaiTut_Load;
		C6A9FF07.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		panel5.ResumeLayout(performLayout: false);
		panel5.PerformLayout();
		((ISupportInitialize)D2301A97).EndInit();
		((ISupportInitialize)nudTimeWatchFrom).EndInit();
		F6857D08.ResumeLayout(performLayout: false);
		F6857D08.PerformLayout();
		plDangBaiLenPage.ResumeLayout(performLayout: false);
		plDangBaiLenPage.PerformLayout();
		((ISupportInitialize)nudCountPageTo).EndInit();
		((ISupportInitialize)nudCountPageFrom).EndInit();
		E515B63D.ResumeLayout(performLayout: false);
		E515B63D.PerformLayout();
		panel4.ResumeLayout(performLayout: false);
		panel4.PerformLayout();
		panel3.ResumeLayout(performLayout: false);
		panel3.PerformLayout();
		B23176AC.ResumeLayout(performLayout: false);
		B23176AC.PerformLayout();
		A91C399C.ResumeLayout(performLayout: false);
		A91C399C.PerformLayout();
		((ISupportInitialize)DDA4D5B3).EndInit();
		((ISupportInitialize)nudTuongTacDelayTo).EndInit();
		((ISupportInitialize)nudTuongTacFrom).EndInit();
		((ISupportInitialize)nudTuongTacDelayFrom).EndInit();
		((ISupportInitialize)nudTimeWaitTo2).EndInit();
		((ISupportInitialize)nudTimeWaitTo1).EndInit();
		((ISupportInitialize)nudCountGroupTo).EndInit();
		((ISupportInitialize)nudTimeWaitFrom2).EndInit();
		((ISupportInitialize)nudTimeWaitFrom1).EndInit();
		((ISupportInitialize)nudCountGroupFrom).EndInit();
		((ISupportInitialize)BD12C535).EndInit();
		((ISupportInitialize)B12B6C06).EndInit();
		plVanBan.ResumeLayout(performLayout: false);
		plVanBan.PerformLayout();
		E1B681AE.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
