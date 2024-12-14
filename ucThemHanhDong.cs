using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class ucThemHanhDong : UserControl
{
	private fThemHanhDong BB12938C;

	private string string_0;

	private IContainer icontainer_0 = null;

	private GroupBox groupBox5;

	private PictureBox C809C09E;

	private Panel BB948F33;

	private Button metroButton2;

	private Button metroButton12;

	private Button metroButton11;

	private Button metroButton10;

	private Button metroButton22;

	private Button metroButton73;

	private Button metroButton72;

	private Button D88EA501;

	private Button E2A07211;

	private Button btnAddMail;

	private Button metroButton49;

	private Button metroButton46;

	private GroupBox D2A617A2;

	private PictureBox pictureBox7;

	private Panel panel8;

	private Button metroButton75;

	private Button A7B80909;

	private Button metroButton71;

	private Button CEAB4812;

	private Button BE05E4B1;

	private Button AF389797;

	private Button metroButton63;

	private Button E9322F82;

	private Button metroButton57;

	private Button button1;

	private Button metroButton32;

	private Button D72A9E18;

	private Button metroButton28;

	private GroupBox groupBox4;

	private Panel panel5;

	private Button metroButton38;

	private Button ED1B243A;

	private Button metroButton14;

	private Button metroButton21;

	private Button metroButton15;

	private Button metroButton13;

	private Button metroButton18;

	private Button metroButton17;

	private Button metroButton16;

	private Button metroButton39;

	private Button B31F890F;

	private Button metroButton41;

	private PictureBox E108F50F;

	private GroupBox AD29E11B;

	private PictureBox A5829D05;

	private Panel BF2E7CB1;

	private Button metroButton26;

	private Button BC0FD707;

	private Button DC1CDE32;

	private Button F42D2D33;

	private Button D01EA6A0;

	private Button CC358A9F;

	private Button metroButton36;

	private Button metroButton20;

	private Button metroButton37;

	private Button metroButton24;

	private Button DA3CA4AA;

	private Button metroButton56;

	private GroupBox D939322B;

	private Panel A398EF2A;

	private Button metroButton59;

	private Button metroButton8;

	private Button metroButton7;

	private Button C986AAA1;

	private Button EB841C89;

	private Button BA3A9F28;

	private Button C229FFBE;

	private PictureBox pictureBox3;

	private GroupBox groupBox2;

	private Panel panel3;

	private Button D3861214;

	private Button A619EBB3;

	private Button metroButton62;

	private Button metroButton76;

	private Button metroButton65;

	private Button metroButton69;

	private Button metroButton77;

	private Button DCAD758A;

	private Button E7886636;

	private Button EA1D0280;

	private PictureBox E431420F;

	private Button F1B9760E;

	private Button EF9025BE;

	private Button E895569B;

	private Button button11;

	private Button C42BAA9F;

	private Button F81B9D85;

	private Button DF9A2B3C;

	private Button E80B919C;

	public ucThemHanhDong(fThemHanhDong fThemHanhDong_0)
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		BB12938C = fThemHanhDong_0;
		string_0 = fThemHanhDong_0.string_0;
		EF9025BE.Visible = Class57.bool_0;
		BE05E4B1.Visible = !Class57.bool_0;
	}

	private void A619EBB3_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDDocThongBao(string_0));
		if (fHDDocThongBao.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void metroButton62_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDXemStory(string_0));
		if (fHDXemStory.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void metroButton65_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDXemWatch(string_0));
		if (fHDXemWatch.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void metroButton69_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDChocBanBe(string_0));
		if (fHDChocBanBe.DD8091A7)
		{
			BB12938C.Close();
		}
	}

	private void ED91D816(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDChucMungSinhNhat(string_0));
		if (fHDChucMungSinhNhat.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void metroButton76_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDDangStatus(string_0));
		if (fHDDangStatus.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void metroButton77_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDDangStory(string_0));
		if (fHDDangStory.EB95E78F)
		{
			BB12938C.Close();
		}
	}

	private void metroButton8_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new F49201A9(string_0));
		if (F49201A9.AB829622)
		{
			BB12938C.Close();
		}
	}

	private void B8981395(object sender, EventArgs e)
	{
		GClass8.smethod_33(new A52F8229(string_0));
		if (A52F8229.D81D80A2)
		{
			BB12938C.Close();
		}
	}

	private void BA3A9F28_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDBaiVietNhom(string_0));
		if (fHDBaiVietNhom.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void C4BF9EA5(object sender, EventArgs e)
	{
		GClass8.smethod_33(new AD243E2E(string_0));
		if (AD243E2E.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void A69DE4B4(object sender, EventArgs e)
	{
		GClass8.smethod_33(new FDAEA09A(string_0));
		if (FDAEA09A.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void EB841C89_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new A1276B03(string_0));
		if (A1276B03.D7224B0E)
		{
			BB12938C.Close();
		}
	}

	private void D60F6C01(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDChaySeeding(string_0));
		if (fHDChaySeeding.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void E499B339(object sender, EventArgs e)
	{
		GClass8.smethod_33(new D82E829C(string_0));
		if (D82E829C.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void metroButton13_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new F78F2213(string_0));
		if (F78F2213.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void E5951D9C(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDXacNhanKetBan(string_0));
		if (fHDXacNhanKetBan.ACA1A2AC)
		{
			BB12938C.Close();
		}
	}

	private void B31F890F_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDKetBanTepUid(string_0));
		if (fHDKetBanTepUid.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void BC837299(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDHuyLoiMoiKetBan(string_0));
		if (fHDHuyLoiMoiKetBan.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void metroButton17_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new E9397B88(string_0));
		if (E9397B88.EAA1BF88)
		{
			BB12938C.Close();
		}
	}

	private void E3B28D1D(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDKetBanThanhVienNhom(string_0));
		if (fHDKetBanThanhVienNhom.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void metroButton41_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDKetBanVoiBanCuaBanBe(string_0));
		if (fHDKetBanVoiBanCuaBanBe.EE22CB0E)
		{
			BB12938C.Close();
		}
	}

	private void F48D10B2(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDKetBanVoiBanBeCuaUid(string_0));
		if (fHDKetBanVoiBanBeCuaUid.A2A0E122)
		{
			BB12938C.Close();
		}
	}

	private void F38685B7(object sender, EventArgs e)
	{
		GClass8.smethod_33(new B0835B0A(string_0));
		if (B0835B0A.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void B30BBF32(object sender, EventArgs e)
	{
		GClass8.smethod_33(new BD963B00(string_0));
		if (BD963B00.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void BEA70B3D(object sender, EventArgs e)
	{
		GClass8.smethod_33(new B7360A13(string_0));
		if (B7360A13.CB17C7A0)
		{
			BB12938C.Close();
		}
	}

	private void metroButton26_Click(object sender, EventArgs e)
	{
		try
		{
			GClass8.smethod_33(new fHDBuffLikeComment(string_0));
			if (fHDBuffLikeComment.bool_0)
			{
				BB12938C.Close();
			}
		}
		catch (Exception exception_)
		{
			GClass8.smethod_62(exception_, "metroButton26_Click");
			GClass29.smethod_0("Đã có lỗi xảy ra, vui lòng liên hệ Admin!", 2);
		}
	}

	private void F42D2D33_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new D0129A91(string_0));
		if (D0129A91.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void D01EA6A0_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDBuffFollowLikePage(string_0));
		if (fHDBuffFollowLikePage.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void A0178022(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDBuffTinNhanProfile(string_0));
		if (fHDBuffTinNhanProfile.E50B7319)
		{
			BB12938C.Close();
		}
	}

	private void metroButton24_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new A6AEB23C(string_0));
		if (A6AEB23C.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void ED8862B7(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDDangBai(string_0));
		if (fHDDangBai.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void metroButton37_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			GClass8.smethod_33(new fHDShareBaiTut(string_0));
			if (fHDShareBaiTut.bool_0)
			{
				BB12938C.Close();
			}
		}
		else
		{
			GClass8.smethod_33(new C3079B9D(string_0));
			if (C3079B9D.bool_0)
			{
				BB12938C.Close();
			}
		}
	}

	private void CC358A9F_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new EB3B3C1A(string_0));
		if (EB3B3C1A.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void BC0FD707_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDDangStatusV2(string_0));
		if (fHDDangStatusV2.D93A4CA8)
		{
			BB12938C.Close();
		}
	}

	private void DC1CDE32_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new DBA4A1B0(string_0));
		if (DBA4A1B0.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void metroButton56_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new D282E117(string_0));
		if (D282E117.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void metroButton20_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDMoiBanBeVaoNhom(string_0));
		if (fHDMoiBanBeVaoNhom.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void metroButton2_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDDoiMatKhau(string_0));
		if (fHDDoiMatKhau.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void metroButton49_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDXoaSdt(string_0));
		if (fHDXoaSdt.C13EAFA1)
		{
			BB12938C.Close();
		}
	}

	private void btnAddMail_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new DA0D4B0D(string_0));
		if (DA0D4B0D.E7831214)
		{
			BB12938C.Close();
		}
	}

	private void DF19803A(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDDoiTen(string_0));
		if (fHDDoiTen.BC264AAD)
		{
			BB12938C.Close();
		}
	}

	private void metroButton10_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new C5214BA0(string_0));
		if (C5214BA0.AF20E8A1)
		{
			BB12938C.Close();
		}
	}

	private void metroButton11_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new FB245815(string_0));
		if (FB245815.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void metroButton12_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new EF90CFAC(string_0));
		if (EF90CFAC.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void FEBBED94(object sender, EventArgs e)
	{
		GClass8.smethod_33(new BABC2880(string_0));
		if (BABC2880.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void D88EA501_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new CAB700BC(string_0));
		if (CAB700BC.E78D2A04)
		{
			BB12938C.Close();
		}
	}

	private void metroButton72_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDXoaThietBiTinCay(string_0));
		if (fHDXoaThietBiTinCay.A0AC0C13)
		{
			BB12938C.Close();
		}
	}

	private void metroButton73_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDDangXuatThietBiCu(string_0));
		if (fHDDangXuatThietBiCu.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void metroButton22_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDRoiNhom(string_0));
		if (fHDRoiNhom.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void DD89B2AF(object sender, EventArgs e)
	{
		GClass8.smethod_33(new AF9E4E34(string_0));
		if (AF9E4E34.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void FD211B36(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDTruyCapWebsite(string_0));
		if (fHDTruyCapWebsite.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void metroButton57_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDHuyLikePage(string_0));
		if (fHDHuyLikePage.A708DA8E)
		{
			BB12938C.Close();
		}
	}

	private void metroButton63_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new AE162A09(string_0));
		if (AE162A09.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void AF389797_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDHuyLienKetInstagram(string_0));
		if (fHDHuyLienKetInstagram.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void E9322F82_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new B5B56C91(string_0));
		if (B5B56C91.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void metroButton75_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDKhangSpam(string_0));
		if (fHDKhangSpam.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void A7B80909_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new A3202D8D(string_0));
		if (A3202D8D.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void CEAB4812_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new C69E6685(string_0));
		if (C69E6685.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void EDABBFAA(object sender, EventArgs e)
	{
		GClass8.smethod_33(new BA26EC99(string_0));
		if (BA26EC99.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void method_0(object sender, LinkLabelLinkClickedEventArgs e)
	{
		BB12938C.Width = 1372;
		base.Width += 198;
		(sender as Control).Visible = false;
	}

	private void metroButton46_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDTuongTacNhomv2(string_0));
		if (fHDTuongTacNhomv2.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void C52CEB04(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDKichHoatPageVhh(string_0));
		if (fHDKichHoatPageVhh.bool_0)
		{
			BB12938C.Close();
		}
	}

	private void EA1D0280_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDDangReel(string_0));
		if (fHDDangReel.C721C088)
		{
			BB12938C.Close();
		}
	}

	private void EF9025BE_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDSharePage(string_0));
		if (fHDSharePage.B72DD8B9)
		{
			BB12938C.Close();
		}
	}

	private void A239CC94(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDTuongTacBaiVietTuKhoa(string_0));
		if (fHDTuongTacBaiVietTuKhoa.F70E8C2A)
		{
			BB12938C.Close();
		}
	}

	private void button11_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDDanhGiaPage(string_0));
		if (fHDDanhGiaPage.E9B43794)
		{
			BB12938C.Close();
		}
	}

	private void C42BAA9F_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDReportPage(string_0));
		if (fHDReportPage.D532B183)
		{
			BB12938C.Close();
		}
	}

	private void DF9A2B3C_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new A38C25A7(string_0));
		if (A38C25A7.AA8340A6)
		{
			BB12938C.Close();
		}
	}

	private void F10FE923(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHDScriptGemLogin(string_0));
		if (fHDScriptGemLogin.C9899115)
		{
			BB12938C.Close();
		}
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		groupBox5 = new System.Windows.Forms.GroupBox();
		C809C09E = new System.Windows.Forms.PictureBox();
		BB948F33 = new System.Windows.Forms.Panel();
		metroButton2 = new System.Windows.Forms.Button();
		metroButton12 = new System.Windows.Forms.Button();
		metroButton11 = new System.Windows.Forms.Button();
		metroButton10 = new System.Windows.Forms.Button();
		metroButton22 = new System.Windows.Forms.Button();
		metroButton73 = new System.Windows.Forms.Button();
		metroButton72 = new System.Windows.Forms.Button();
		D88EA501 = new System.Windows.Forms.Button();
		E2A07211 = new System.Windows.Forms.Button();
		btnAddMail = new System.Windows.Forms.Button();
		metroButton49 = new System.Windows.Forms.Button();
		metroButton46 = new System.Windows.Forms.Button();
		D2A617A2 = new System.Windows.Forms.GroupBox();
		pictureBox7 = new System.Windows.Forms.PictureBox();
		panel8 = new System.Windows.Forms.Panel();
		metroButton75 = new System.Windows.Forms.Button();
		A7B80909 = new System.Windows.Forms.Button();
		metroButton71 = new System.Windows.Forms.Button();
		AF389797 = new System.Windows.Forms.Button();
		metroButton63 = new System.Windows.Forms.Button();
		E9322F82 = new System.Windows.Forms.Button();
		metroButton57 = new System.Windows.Forms.Button();
		button1 = new System.Windows.Forms.Button();
		metroButton32 = new System.Windows.Forms.Button();
		D72A9E18 = new System.Windows.Forms.Button();
		metroButton28 = new System.Windows.Forms.Button();
		CEAB4812 = new System.Windows.Forms.Button();
		EF9025BE = new System.Windows.Forms.Button();
		C42BAA9F = new System.Windows.Forms.Button();
		BE05E4B1 = new System.Windows.Forms.Button();
		F1B9760E = new System.Windows.Forms.Button();
		groupBox4 = new System.Windows.Forms.GroupBox();
		panel5 = new System.Windows.Forms.Panel();
		metroButton38 = new System.Windows.Forms.Button();
		ED1B243A = new System.Windows.Forms.Button();
		metroButton14 = new System.Windows.Forms.Button();
		metroButton21 = new System.Windows.Forms.Button();
		metroButton15 = new System.Windows.Forms.Button();
		metroButton13 = new System.Windows.Forms.Button();
		metroButton18 = new System.Windows.Forms.Button();
		metroButton17 = new System.Windows.Forms.Button();
		metroButton16 = new System.Windows.Forms.Button();
		metroButton39 = new System.Windows.Forms.Button();
		B31F890F = new System.Windows.Forms.Button();
		metroButton41 = new System.Windows.Forms.Button();
		E108F50F = new System.Windows.Forms.PictureBox();
		AD29E11B = new System.Windows.Forms.GroupBox();
		A5829D05 = new System.Windows.Forms.PictureBox();
		BF2E7CB1 = new System.Windows.Forms.Panel();
		E895569B = new System.Windows.Forms.Button();
		DC1CDE32 = new System.Windows.Forms.Button();
		F42D2D33 = new System.Windows.Forms.Button();
		metroButton26 = new System.Windows.Forms.Button();
		button11 = new System.Windows.Forms.Button();
		D01EA6A0 = new System.Windows.Forms.Button();
		CC358A9F = new System.Windows.Forms.Button();
		metroButton36 = new System.Windows.Forms.Button();
		metroButton20 = new System.Windows.Forms.Button();
		metroButton37 = new System.Windows.Forms.Button();
		metroButton24 = new System.Windows.Forms.Button();
		DA3CA4AA = new System.Windows.Forms.Button();
		metroButton56 = new System.Windows.Forms.Button();
		BC0FD707 = new System.Windows.Forms.Button();
		D939322B = new System.Windows.Forms.GroupBox();
		A398EF2A = new System.Windows.Forms.Panel();
		E80B919C = new System.Windows.Forms.Button();
		metroButton59 = new System.Windows.Forms.Button();
		metroButton8 = new System.Windows.Forms.Button();
		metroButton7 = new System.Windows.Forms.Button();
		C986AAA1 = new System.Windows.Forms.Button();
		BA3A9F28 = new System.Windows.Forms.Button();
		EB841C89 = new System.Windows.Forms.Button();
		C229FFBE = new System.Windows.Forms.Button();
		F81B9D85 = new System.Windows.Forms.Button();
		DF9A2B3C = new System.Windows.Forms.Button();
		pictureBox3 = new System.Windows.Forms.PictureBox();
		groupBox2 = new System.Windows.Forms.GroupBox();
		panel3 = new System.Windows.Forms.Panel();
		D3861214 = new System.Windows.Forms.Button();
		A619EBB3 = new System.Windows.Forms.Button();
		metroButton62 = new System.Windows.Forms.Button();
		metroButton65 = new System.Windows.Forms.Button();
		metroButton69 = new System.Windows.Forms.Button();
		metroButton77 = new System.Windows.Forms.Button();
		EA1D0280 = new System.Windows.Forms.Button();
		metroButton76 = new System.Windows.Forms.Button();
		DCAD758A = new System.Windows.Forms.Button();
		E7886636 = new System.Windows.Forms.Button();
		E431420F = new System.Windows.Forms.PictureBox();
		groupBox5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C809C09E).BeginInit();
		BB948F33.SuspendLayout();
		D2A617A2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
		panel8.SuspendLayout();
		groupBox4.SuspendLayout();
		panel5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)E108F50F).BeginInit();
		AD29E11B.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)A5829D05).BeginInit();
		BF2E7CB1.SuspendLayout();
		D939322B.SuspendLayout();
		A398EF2A.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
		groupBox2.SuspendLayout();
		panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)E431420F).BeginInit();
		SuspendLayout();
		groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		groupBox5.Controls.Add(C809C09E);
		groupBox5.Controls.Add(BB948F33);
		groupBox5.Location = new System.Drawing.Point(784, 3);
		groupBox5.Name = "groupBox5";
		groupBox5.Size = new System.Drawing.Size(189, 472);
		groupBox5.TabIndex = 8;
		groupBox5.TabStop = false;
		groupBox5.Text = "Chức năng Đổi thông tin";
		C809C09E.Image = C50FB39E.ED08033B;
		C809C09E.Location = new System.Drawing.Point(18, 22);
		C809C09E.Name = "pictureBox5";
		C809C09E.Size = new System.Drawing.Size(151, 83);
		C809C09E.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		C809C09E.TabIndex = 1;
		C809C09E.TabStop = false;
		BB948F33.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		BB948F33.AutoScroll = true;
		BB948F33.Controls.Add(metroButton2);
		BB948F33.Controls.Add(metroButton12);
		BB948F33.Controls.Add(metroButton11);
		BB948F33.Controls.Add(metroButton10);
		BB948F33.Controls.Add(metroButton22);
		BB948F33.Controls.Add(metroButton73);
		BB948F33.Controls.Add(metroButton72);
		BB948F33.Controls.Add(D88EA501);
		BB948F33.Controls.Add(E2A07211);
		BB948F33.Controls.Add(btnAddMail);
		BB948F33.Controls.Add(metroButton49);
		BB948F33.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		BB948F33.Location = new System.Drawing.Point(1, 120);
		BB948F33.Name = "panel6";
		BB948F33.Size = new System.Drawing.Size(187, 347);
		BB948F33.TabIndex = 14;
		metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton2.Location = new System.Drawing.Point(12, 0);
		metroButton2.Name = "metroButton2";
		metroButton2.Size = new System.Drawing.Size(162, 26);
		metroButton2.TabIndex = 8;
		metroButton2.Text = "Đổi mật khẩu";
		metroButton2.Click += new System.EventHandler(metroButton2_Click);
		metroButton12.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton12.Location = new System.Drawing.Point(12, 174);
		metroButton12.Name = "metroButton12";
		metroButton12.Size = new System.Drawing.Size(162, 26);
		metroButton12.TabIndex = 8;
		metroButton12.Text = "Bật - Tắt 2FA";
		metroButton12.Click += new System.EventHandler(metroButton12_Click);
		metroButton11.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton11.Location = new System.Drawing.Point(12, 145);
		metroButton11.Name = "metroButton11";
		metroButton11.Size = new System.Drawing.Size(162, 26);
		metroButton11.TabIndex = 8;
		metroButton11.Text = "Up Cover";
		metroButton11.Click += new System.EventHandler(metroButton11_Click);
		metroButton10.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton10.Location = new System.Drawing.Point(12, 116);
		metroButton10.Name = "metroButton10";
		metroButton10.Size = new System.Drawing.Size(162, 26);
		metroButton10.TabIndex = 8;
		metroButton10.Text = "Up Avatar";
		metroButton10.Click += new System.EventHandler(metroButton10_Click);
		metroButton22.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton22.Location = new System.Drawing.Point(12, 290);
		metroButton22.Name = "metroButton22";
		metroButton22.Size = new System.Drawing.Size(162, 26);
		metroButton22.TabIndex = 2;
		metroButton22.Text = "Rời nhóm";
		metroButton22.Click += new System.EventHandler(metroButton22_Click);
		metroButton73.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton73.Location = new System.Drawing.Point(12, 261);
		metroButton73.Name = "metroButton73";
		metroButton73.Size = new System.Drawing.Size(162, 26);
		metroButton73.TabIndex = 8;
		metroButton73.Text = "Đăng xuất thiết bị cũ";
		metroButton73.Click += new System.EventHandler(metroButton73_Click);
		metroButton72.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton72.Location = new System.Drawing.Point(12, 232);
		metroButton72.Name = "metroButton72";
		metroButton72.Size = new System.Drawing.Size(162, 26);
		metroButton72.TabIndex = 8;
		metroButton72.Text = "Xóa thiết bị tin cậy";
		metroButton72.Click += new System.EventHandler(metroButton72_Click);
		D88EA501.Cursor = System.Windows.Forms.Cursors.Hand;
		D88EA501.Location = new System.Drawing.Point(12, 203);
		D88EA501.Name = "metroButton4";
		D88EA501.Size = new System.Drawing.Size(162, 26);
		D88EA501.TabIndex = 8;
		D88EA501.Text = "Cập nhật thông tin";
		D88EA501.Click += new System.EventHandler(D88EA501_Click);
		E2A07211.Cursor = System.Windows.Forms.Cursors.Hand;
		E2A07211.Location = new System.Drawing.Point(12, 87);
		E2A07211.Name = "metroButton3";
		E2A07211.Size = new System.Drawing.Size(162, 26);
		E2A07211.TabIndex = 8;
		E2A07211.Text = "Đổi tên";
		E2A07211.Click += new System.EventHandler(DF19803A);
		btnAddMail.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAddMail.Location = new System.Drawing.Point(12, 58);
		btnAddMail.Name = "btnAddMail";
		btnAddMail.Size = new System.Drawing.Size(162, 26);
		btnAddMail.TabIndex = 8;
		btnAddMail.Text = "Add Mail";
		btnAddMail.Click += new System.EventHandler(btnAddMail_Click);
		metroButton49.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton49.Location = new System.Drawing.Point(12, 29);
		metroButton49.Name = "metroButton49";
		metroButton49.Size = new System.Drawing.Size(162, 26);
		metroButton49.TabIndex = 8;
		metroButton49.Text = "Xóa Sđt";
		metroButton49.Click += new System.EventHandler(metroButton49_Click);
		metroButton46.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton46.Location = new System.Drawing.Point(12, 87);
		metroButton46.Name = "metroButton46";
		metroButton46.Size = new System.Drawing.Size(165, 26);
		metroButton46.TabIndex = 9;
		metroButton46.Text = "Bài viết Nhóm (www)";
		metroButton46.Click += new System.EventHandler(metroButton46_Click);
		D2A617A2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		D2A617A2.Controls.Add(pictureBox7);
		D2A617A2.Controls.Add(panel8);
		D2A617A2.Location = new System.Drawing.Point(979, 3);
		D2A617A2.Name = "groupBox6";
		D2A617A2.Size = new System.Drawing.Size(189, 472);
		D2A617A2.TabIndex = 10;
		D2A617A2.TabStop = false;
		D2A617A2.Text = "Chư\u0301c năng kha\u0301c";
		pictureBox7.Image = C50FB39E.Bitmap_3;
		pictureBox7.Location = new System.Drawing.Point(18, 22);
		pictureBox7.Name = "pictureBox7";
		pictureBox7.Size = new System.Drawing.Size(151, 83);
		pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		pictureBox7.TabIndex = 1;
		pictureBox7.TabStop = false;
		panel8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		panel8.AutoScroll = true;
		panel8.Controls.Add(metroButton75);
		panel8.Controls.Add(A7B80909);
		panel8.Controls.Add(metroButton71);
		panel8.Controls.Add(AF389797);
		panel8.Controls.Add(metroButton63);
		panel8.Controls.Add(E9322F82);
		panel8.Controls.Add(metroButton57);
		panel8.Controls.Add(button1);
		panel8.Controls.Add(metroButton32);
		panel8.Controls.Add(D72A9E18);
		panel8.Controls.Add(metroButton28);
		panel8.Controls.Add(CEAB4812);
		panel8.Controls.Add(EF9025BE);
		panel8.Controls.Add(C42BAA9F);
		panel8.Controls.Add(BE05E4B1);
		panel8.Controls.Add(F1B9760E);
		panel8.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		panel8.Location = new System.Drawing.Point(1, 120);
		panel8.Name = "panel8";
		panel8.Size = new System.Drawing.Size(187, 347);
		panel8.TabIndex = 14;
		metroButton75.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton75.Location = new System.Drawing.Point(12, 174);
		metroButton75.Name = "metroButton75";
		metroButton75.Size = new System.Drawing.Size(162, 26);
		metroButton75.TabIndex = 13;
		metroButton75.Text = "Kháng spam";
		metroButton75.Click += new System.EventHandler(metroButton75_Click);
		A7B80909.Cursor = System.Windows.Forms.Cursors.Hand;
		A7B80909.Location = new System.Drawing.Point(12, 203);
		A7B80909.Name = "metroButton60";
		A7B80909.Size = new System.Drawing.Size(162, 26);
		A7B80909.TabIndex = 7;
		A7B80909.Text = "Chế độ chuyên nghiệp";
		A7B80909.Click += new System.EventHandler(A7B80909_Click);
		metroButton71.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton71.Location = new System.Drawing.Point(12, 174);
		metroButton71.Name = "metroButton71";
		metroButton71.Size = new System.Drawing.Size(162, 26);
		metroButton71.TabIndex = 7;
		metroButton71.Text = "Report";
		metroButton71.Visible = false;
		AF389797.Cursor = System.Windows.Forms.Cursors.Hand;
		AF389797.Location = new System.Drawing.Point(12, 116);
		AF389797.Name = "button9";
		AF389797.Size = new System.Drawing.Size(162, 26);
		AF389797.TabIndex = 10;
		AF389797.Text = "Hủy liên kết Instagram";
		AF389797.Click += new System.EventHandler(AF389797_Click);
		metroButton63.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton63.Location = new System.Drawing.Point(12, 87);
		metroButton63.Name = "metroButton63";
		metroButton63.Size = new System.Drawing.Size(162, 26);
		metroButton63.TabIndex = 10;
		metroButton63.Text = "Liên kết Instagram";
		metroButton63.Click += new System.EventHandler(metroButton63_Click);
		E9322F82.Cursor = System.Windows.Forms.Cursors.Hand;
		E9322F82.Location = new System.Drawing.Point(12, 145);
		E9322F82.Name = "metroButton30";
		E9322F82.Size = new System.Drawing.Size(162, 26);
		E9322F82.TabIndex = 3;
		E9322F82.Text = "Xóa bài trên tường";
		E9322F82.Click += new System.EventHandler(E9322F82_Click);
		metroButton57.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton57.Location = new System.Drawing.Point(12, 58);
		metroButton57.Name = "metroButton57";
		metroButton57.Size = new System.Drawing.Size(162, 26);
		metroButton57.TabIndex = 6;
		metroButton57.Text = "Hủy like page";
		metroButton57.Click += new System.EventHandler(metroButton57_Click);
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.Location = new System.Drawing.Point(12, 174);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(162, 26);
		button1.TabIndex = 8;
		button1.Text = "Kết bạn vip";
		metroButton32.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton32.Location = new System.Drawing.Point(12, 0);
		metroButton32.Name = "metroButton32";
		metroButton32.Size = new System.Drawing.Size(162, 26);
		metroButton32.TabIndex = 0;
		metroButton32.Text = "Ti\u0300m kiê\u0301m Google";
		metroButton32.Click += new System.EventHandler(DD89B2AF);
		D72A9E18.Cursor = System.Windows.Forms.Cursors.Hand;
		D72A9E18.Location = new System.Drawing.Point(12, 29);
		D72A9E18.Name = "metroButton33";
		D72A9E18.Size = new System.Drawing.Size(162, 26);
		D72A9E18.TabIndex = 0;
		D72A9E18.Text = "Truy cập Website";
		D72A9E18.Click += new System.EventHandler(FD211B36);
		metroButton28.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton28.Location = new System.Drawing.Point(12, 0);
		metroButton28.Name = "metroButton28";
		metroButton28.Size = new System.Drawing.Size(162, 26);
		metroButton28.TabIndex = 2;
		metroButton28.Text = "Backup dư\u0303 liê\u0323u";
		CEAB4812.Cursor = System.Windows.Forms.Cursors.Hand;
		CEAB4812.Location = new System.Drawing.Point(12, 232);
		CEAB4812.Name = "button3";
		CEAB4812.Size = new System.Drawing.Size(162, 26);
		CEAB4812.TabIndex = 7;
		CEAB4812.Text = "Tạo page";
		CEAB4812.Click += new System.EventHandler(CEAB4812_Click);
		EF9025BE.Cursor = System.Windows.Forms.Cursors.Hand;
		EF9025BE.Location = new System.Drawing.Point(12, 290);
		EF9025BE.Name = "btnShareAdminPage";
		EF9025BE.Size = new System.Drawing.Size(162, 26);
		EF9025BE.TabIndex = 10;
		EF9025BE.Text = "Share Admin Page";
		EF9025BE.Visible = false;
		EF9025BE.Click += new System.EventHandler(EF9025BE_Click);
		C42BAA9F.Cursor = System.Windows.Forms.Cursors.Hand;
		C42BAA9F.Location = new System.Drawing.Point(12, 290);
		C42BAA9F.Name = "button7";
		C42BAA9F.Size = new System.Drawing.Size(162, 26);
		C42BAA9F.TabIndex = 2;
		C42BAA9F.Text = "Report page";
		C42BAA9F.Visible = false;
		C42BAA9F.Click += new System.EventHandler(C42BAA9F_Click);
		BE05E4B1.Cursor = System.Windows.Forms.Cursors.Hand;
		BE05E4B1.Location = new System.Drawing.Point(12, 261);
		BE05E4B1.Name = "button6";
		BE05E4B1.Size = new System.Drawing.Size(162, 26);
		BE05E4B1.TabIndex = 10;
		BE05E4B1.Text = "Unlock profile";
		BE05E4B1.Click += new System.EventHandler(EDABBFAA);
		F1B9760E.Cursor = System.Windows.Forms.Cursors.Hand;
		F1B9760E.Location = new System.Drawing.Point(12, 261);
		F1B9760E.Name = "btnKichHoatPageVhh";
		F1B9760E.Size = new System.Drawing.Size(162, 26);
		F1B9760E.TabIndex = 7;
		F1B9760E.Text = "Ki\u0301ch hoa\u0323t page vhh";
		F1B9760E.Click += new System.EventHandler(C52CEB04);
		groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		groupBox4.Controls.Add(panel5);
		groupBox4.Controls.Add(E108F50F);
		groupBox4.Location = new System.Drawing.Point(395, 3);
		groupBox4.Name = "groupBox4";
		groupBox4.Size = new System.Drawing.Size(189, 472);
		groupBox4.TabIndex = 7;
		groupBox4.TabStop = false;
		groupBox4.Text = "Chức năng Bạn bè - Nhóm";
		panel5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		panel5.AutoScroll = true;
		panel5.Controls.Add(metroButton38);
		panel5.Controls.Add(ED1B243A);
		panel5.Controls.Add(metroButton14);
		panel5.Controls.Add(metroButton21);
		panel5.Controls.Add(metroButton15);
		panel5.Controls.Add(metroButton13);
		panel5.Controls.Add(metroButton18);
		panel5.Controls.Add(metroButton17);
		panel5.Controls.Add(metroButton16);
		panel5.Controls.Add(metroButton39);
		panel5.Controls.Add(B31F890F);
		panel5.Controls.Add(metroButton41);
		panel5.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		panel5.Location = new System.Drawing.Point(1, 120);
		panel5.Name = "panel5";
		panel5.Size = new System.Drawing.Size(187, 347);
		panel5.TabIndex = 14;
		metroButton38.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton38.Location = new System.Drawing.Point(12, 261);
		metroButton38.Name = "metroButton38";
		metroButton38.Size = new System.Drawing.Size(162, 26);
		metroButton38.TabIndex = 3;
		metroButton38.Text = "Tham gia nhóm theo gợi ý";
		metroButton38.Click += new System.EventHandler(F38685B7);
		ED1B243A.Cursor = System.Windows.Forms.Cursors.Hand;
		ED1B243A.Location = new System.Drawing.Point(12, 290);
		ED1B243A.Name = "metroButton23";
		ED1B243A.Size = new System.Drawing.Size(162, 26);
		ED1B243A.TabIndex = 0;
		ED1B243A.Text = "Tham gia nhóm từ khóa";
		ED1B243A.Click += new System.EventHandler(B30BBF32);
		metroButton14.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton14.Location = new System.Drawing.Point(12, 0);
		metroButton14.Name = "metroButton14";
		metroButton14.Size = new System.Drawing.Size(162, 26);
		metroButton14.TabIndex = 0;
		metroButton14.Text = "Kết bạn theo từ khóa";
		metroButton14.Click += new System.EventHandler(E499B339);
		metroButton21.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton21.Location = new System.Drawing.Point(12, 319);
		metroButton21.Name = "metroButton21";
		metroButton21.Size = new System.Drawing.Size(162, 26);
		metroButton21.TabIndex = 1;
		metroButton21.Text = "Tham gia nhóm chi\u0309 đi\u0323nh";
		metroButton21.Click += new System.EventHandler(BEA70B3D);
		metroButton15.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton15.Location = new System.Drawing.Point(12, 116);
		metroButton15.Name = "metroButton15";
		metroButton15.Size = new System.Drawing.Size(162, 26);
		metroButton15.TabIndex = 5;
		metroButton15.Text = "Hủy lời mời đã gửi";
		metroButton15.Click += new System.EventHandler(BC837299);
		metroButton13.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton13.Location = new System.Drawing.Point(12, 29);
		metroButton13.Name = "metroButton13";
		metroButton13.Size = new System.Drawing.Size(162, 26);
		metroButton13.TabIndex = 1;
		metroButton13.Text = "Kết bạn theo gợi ý";
		metroButton13.Click += new System.EventHandler(metroButton13_Click);
		metroButton18.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton18.Location = new System.Drawing.Point(12, 58);
		metroButton18.Name = "metroButton18";
		metroButton18.Size = new System.Drawing.Size(162, 26);
		metroButton18.TabIndex = 2;
		metroButton18.Text = "Xác nhận kết bạn";
		metroButton18.Click += new System.EventHandler(E5951D9C);
		metroButton17.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton17.Location = new System.Drawing.Point(12, 145);
		metroButton17.Name = "metroButton17";
		metroButton17.Size = new System.Drawing.Size(162, 26);
		metroButton17.TabIndex = 6;
		metroButton17.Text = "Hủy kết bạn";
		metroButton17.Click += new System.EventHandler(metroButton17_Click);
		metroButton16.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton16.Location = new System.Drawing.Point(12, 174);
		metroButton16.Name = "metroButton16";
		metroButton16.Size = new System.Drawing.Size(162, 26);
		metroButton16.TabIndex = 3;
		metroButton16.Text = "Kết bạn thành viên nhóm";
		metroButton16.Click += new System.EventHandler(E3B28D1D);
		metroButton39.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton39.Location = new System.Drawing.Point(12, 232);
		metroButton39.Name = "metroButton39";
		metroButton39.Size = new System.Drawing.Size(162, 26);
		metroButton39.TabIndex = 6;
		metroButton39.Text = "Kết bạn với bạn bè của UID";
		metroButton39.Click += new System.EventHandler(F48D10B2);
		B31F890F.Cursor = System.Windows.Forms.Cursors.Hand;
		B31F890F.Location = new System.Drawing.Point(12, 87);
		B31F890F.Name = "metroButton9";
		B31F890F.Size = new System.Drawing.Size(162, 26);
		B31F890F.TabIndex = 4;
		B31F890F.Text = "Kết bạn theo tệp UID";
		B31F890F.Click += new System.EventHandler(B31F890F_Click);
		metroButton41.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton41.Location = new System.Drawing.Point(12, 203);
		metroButton41.Name = "metroButton41";
		metroButton41.Size = new System.Drawing.Size(162, 26);
		metroButton41.TabIndex = 6;
		metroButton41.Text = "Kết bạn với bạn của bạn bè";
		metroButton41.Click += new System.EventHandler(metroButton41_Click);
		E108F50F.Image = C50FB39E.Bitmap_43;
		E108F50F.Location = new System.Drawing.Point(18, 22);
		E108F50F.Name = "pictureBox4";
		E108F50F.Size = new System.Drawing.Size(151, 83);
		E108F50F.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		E108F50F.TabIndex = 1;
		E108F50F.TabStop = false;
		AD29E11B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		AD29E11B.Controls.Add(A5829D05);
		AD29E11B.Controls.Add(BF2E7CB1);
		AD29E11B.Location = new System.Drawing.Point(590, 3);
		AD29E11B.Name = "groupBox3";
		AD29E11B.Size = new System.Drawing.Size(189, 472);
		AD29E11B.TabIndex = 11;
		AD29E11B.TabStop = false;
		AD29E11B.Text = "Chư\u0301c năng Seeding";
		A5829D05.Image = C50FB39E.Bitmap_164;
		A5829D05.Location = new System.Drawing.Point(18, 22);
		A5829D05.Name = "pictureBox6";
		A5829D05.Size = new System.Drawing.Size(151, 83);
		A5829D05.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		A5829D05.TabIndex = 1;
		A5829D05.TabStop = false;
		BF2E7CB1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		BF2E7CB1.AutoScroll = true;
		BF2E7CB1.Controls.Add(E895569B);
		BF2E7CB1.Controls.Add(DC1CDE32);
		BF2E7CB1.Controls.Add(F42D2D33);
		BF2E7CB1.Controls.Add(metroButton26);
		BF2E7CB1.Controls.Add(button11);
		BF2E7CB1.Controls.Add(D01EA6A0);
		BF2E7CB1.Controls.Add(CC358A9F);
		BF2E7CB1.Controls.Add(metroButton36);
		BF2E7CB1.Controls.Add(metroButton20);
		BF2E7CB1.Controls.Add(metroButton37);
		BF2E7CB1.Controls.Add(metroButton24);
		BF2E7CB1.Controls.Add(DA3CA4AA);
		BF2E7CB1.Controls.Add(metroButton56);
		BF2E7CB1.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		BF2E7CB1.Location = new System.Drawing.Point(1, 120);
		BF2E7CB1.Name = "panel7";
		BF2E7CB1.Size = new System.Drawing.Size(187, 347);
		BF2E7CB1.TabIndex = 14;
		E895569B.Cursor = System.Windows.Forms.Cursors.Hand;
		E895569B.Location = new System.Drawing.Point(11, 232);
		E895569B.Name = "button10";
		E895569B.Size = new System.Drawing.Size(165, 26);
		E895569B.TabIndex = 0;
		E895569B.Text = "Tương tác bài viết từ khóa";
		E895569B.Click += new System.EventHandler(A239CC94);
		DC1CDE32.Cursor = System.Windows.Forms.Cursors.Hand;
		DC1CDE32.Location = new System.Drawing.Point(11, 261);
		DC1CDE32.Name = "metroButton48";
		DC1CDE32.Size = new System.Drawing.Size(165, 26);
		DC1CDE32.TabIndex = 8;
		DC1CDE32.Text = "Tương tác Livestream";
		DC1CDE32.Click += new System.EventHandler(DC1CDE32_Click);
		F42D2D33.Cursor = System.Windows.Forms.Cursors.Hand;
		F42D2D33.Location = new System.Drawing.Point(11, 116);
		F42D2D33.Name = "metroButton25";
		F42D2D33.Size = new System.Drawing.Size(78, 26);
		F42D2D33.TabIndex = 1;
		F42D2D33.Text = "Follow";
		F42D2D33.Click += new System.EventHandler(F42D2D33_Click);
		metroButton26.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton26.Location = new System.Drawing.Point(11, 203);
		metroButton26.Name = "metroButton26";
		metroButton26.Size = new System.Drawing.Size(165, 26);
		metroButton26.TabIndex = 0;
		metroButton26.Text = "Tương ta\u0301c ba\u0300i viê\u0301t chi\u0309 đi\u0323nh";
		metroButton26.Click += new System.EventHandler(metroButton26_Click);
		button11.Cursor = System.Windows.Forms.Cursors.Hand;
		button11.Location = new System.Drawing.Point(11, 145);
		button11.Name = "button11";
		button11.Size = new System.Drawing.Size(165, 26);
		button11.TabIndex = 1;
		button11.Text = "Đánh giá Page";
		button11.Click += new System.EventHandler(button11_Click);
		D01EA6A0.Cursor = System.Windows.Forms.Cursors.Hand;
		D01EA6A0.Location = new System.Drawing.Point(93, 116);
		D01EA6A0.Name = "metroButton31";
		D01EA6A0.Size = new System.Drawing.Size(83, 26);
		D01EA6A0.TabIndex = 1;
		D01EA6A0.Text = "Like page";
		D01EA6A0.Click += new System.EventHandler(D01EA6A0_Click);
		CC358A9F.Cursor = System.Windows.Forms.Cursors.Hand;
		CC358A9F.Location = new System.Drawing.Point(11, 174);
		CC358A9F.Name = "metroButton70";
		CC358A9F.Size = new System.Drawing.Size(165, 26);
		CC358A9F.TabIndex = 6;
		CC358A9F.Text = "Phản hồi bình luận";
		CC358A9F.Click += new System.EventHandler(CC358A9F_Click);
		metroButton36.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton36.Location = new System.Drawing.Point(11, 0);
		metroButton36.Name = "metroButton36";
		metroButton36.Size = new System.Drawing.Size(165, 26);
		metroButton36.TabIndex = 2;
		metroButton36.Text = "Đăng bài";
		metroButton36.Click += new System.EventHandler(ED8862B7);
		metroButton20.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton20.Location = new System.Drawing.Point(11, 319);
		metroButton20.Name = "metroButton20";
		metroButton20.Size = new System.Drawing.Size(165, 26);
		metroButton20.TabIndex = 3;
		metroButton20.Text = "Mời bạn bè vào nhóm";
		metroButton20.Click += new System.EventHandler(metroButton20_Click);
		metroButton37.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton37.Location = new System.Drawing.Point(11, 29);
		metroButton37.Name = "metroButton37";
		metroButton37.Size = new System.Drawing.Size(165, 26);
		metroButton37.TabIndex = 2;
		metroButton37.Text = "Share bài";
		metroButton37.Click += new System.EventHandler(metroButton37_Click);
		metroButton24.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton24.Location = new System.Drawing.Point(11, 87);
		metroButton24.Name = "metroButton24";
		metroButton24.Size = new System.Drawing.Size(165, 26);
		metroButton24.TabIndex = 3;
		metroButton24.Text = "Spam bài viết";
		metroButton24.Click += new System.EventHandler(metroButton24_Click);
		DA3CA4AA.Cursor = System.Windows.Forms.Cursors.Hand;
		DA3CA4AA.Location = new System.Drawing.Point(11, 58);
		DA3CA4AA.Name = "metroButton27";
		DA3CA4AA.Size = new System.Drawing.Size(165, 26);
		DA3CA4AA.TabIndex = 3;
		DA3CA4AA.Text = "Nhắn tin";
		DA3CA4AA.Click += new System.EventHandler(A0178022);
		metroButton56.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton56.Location = new System.Drawing.Point(11, 290);
		metroButton56.Name = "metroButton56";
		metroButton56.Size = new System.Drawing.Size(165, 26);
		metroButton56.TabIndex = 3;
		metroButton56.Text = "Mời bạn bè like page";
		metroButton56.Click += new System.EventHandler(metroButton56_Click);
		BC0FD707.Cursor = System.Windows.Forms.Cursors.Hand;
		BC0FD707.Location = new System.Drawing.Point(12, 202);
		BC0FD707.Name = "metroButton45";
		BC0FD707.Size = new System.Drawing.Size(162, 26);
		BC0FD707.TabIndex = 8;
		BC0FD707.Text = "Đăng status v2";
		BC0FD707.Click += new System.EventHandler(BC0FD707_Click);
		D939322B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		D939322B.Controls.Add(A398EF2A);
		D939322B.Controls.Add(pictureBox3);
		D939322B.Location = new System.Drawing.Point(197, 3);
		D939322B.Name = "groupBox1";
		D939322B.Size = new System.Drawing.Size(192, 472);
		D939322B.TabIndex = 6;
		D939322B.TabStop = false;
		D939322B.Text = "Tương tác bài viết";
		A398EF2A.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		A398EF2A.AutoScroll = true;
		A398EF2A.Controls.Add(E80B919C);
		A398EF2A.Controls.Add(metroButton59);
		A398EF2A.Controls.Add(metroButton46);
		A398EF2A.Controls.Add(metroButton8);
		A398EF2A.Controls.Add(metroButton7);
		A398EF2A.Controls.Add(C986AAA1);
		A398EF2A.Controls.Add(BA3A9F28);
		A398EF2A.Controls.Add(EB841C89);
		A398EF2A.Controls.Add(C229FFBE);
		A398EF2A.Controls.Add(F81B9D85);
		A398EF2A.Controls.Add(DF9A2B3C);
		A398EF2A.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A398EF2A.Location = new System.Drawing.Point(1, 120);
		A398EF2A.Name = "panel4";
		A398EF2A.Size = new System.Drawing.Size(190, 347);
		A398EF2A.TabIndex = 14;
		E80B919C.BackColor = System.Drawing.Color.DeepSkyBlue;
		E80B919C.Cursor = System.Windows.Forms.Cursors.Hand;
		E80B919C.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		E80B919C.ForeColor = System.Drawing.Color.Black;
		E80B919C.Location = new System.Drawing.Point(12, 232);
		E80B919C.Name = "btnChayJobKiemTien";
		E80B919C.Size = new System.Drawing.Size(165, 26);
		E80B919C.TabIndex = 14;
		E80B919C.Text = "Script GemLogin";
		E80B919C.UseVisualStyleBackColor = false;
		E80B919C.Click += new System.EventHandler(F10FE923);
		metroButton59.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton59.Location = new System.Drawing.Point(12, 145);
		metroButton59.Name = "metroButton59";
		metroButton59.Size = new System.Drawing.Size(165, 26);
		metroButton59.TabIndex = 4;
		metroButton59.Text = "Bài viết trên tường";
		metroButton59.Click += new System.EventHandler(A69DE4B4);
		metroButton8.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton8.Location = new System.Drawing.Point(12, 0);
		metroButton8.Name = "metroButton8";
		metroButton8.Size = new System.Drawing.Size(165, 26);
		metroButton8.TabIndex = 0;
		metroButton8.Text = "Bài viết Newsfeed";
		metroButton8.Click += new System.EventHandler(metroButton8_Click);
		metroButton7.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton7.Location = new System.Drawing.Point(12, 29);
		metroButton7.Name = "metroButton7";
		metroButton7.Size = new System.Drawing.Size(165, 26);
		metroButton7.TabIndex = 1;
		metroButton7.Text = "Bài viết Bạn bè";
		metroButton7.Click += new System.EventHandler(B8981395);
		C986AAA1.Cursor = System.Windows.Forms.Cursors.Hand;
		C986AAA1.Location = new System.Drawing.Point(12, 116);
		C986AAA1.Name = "metroButton5";
		C986AAA1.Size = new System.Drawing.Size(165, 26);
		C986AAA1.TabIndex = 3;
		C986AAA1.Text = "Bài viết Fanpage";
		C986AAA1.Click += new System.EventHandler(C4BF9EA5);
		BA3A9F28.Cursor = System.Windows.Forms.Cursors.Hand;
		BA3A9F28.Location = new System.Drawing.Point(12, 58);
		BA3A9F28.Name = "metroButton6";
		BA3A9F28.Size = new System.Drawing.Size(165, 26);
		BA3A9F28.TabIndex = 2;
		BA3A9F28.Text = "Bài viết Nhóm";
		BA3A9F28.Click += new System.EventHandler(BA3A9F28_Click);
		EB841C89.Cursor = System.Windows.Forms.Cursors.Hand;
		EB841C89.Location = new System.Drawing.Point(12, 174);
		EB841C89.Name = "metroButton35";
		EB841C89.Size = new System.Drawing.Size(165, 26);
		EB841C89.TabIndex = 0;
		EB841C89.Text = "Nghỉ giải lao";
		EB841C89.Click += new System.EventHandler(EB841C89_Click);
		C229FFBE.Cursor = System.Windows.Forms.Cursors.Hand;
		C229FFBE.Location = new System.Drawing.Point(12, 175);
		C229FFBE.Name = "metroButton66";
		C229FFBE.Size = new System.Drawing.Size(165, 26);
		C229FFBE.TabIndex = 13;
		C229FFBE.Text = "Công khai bài gắn thẻ (ẩn)";
		C229FFBE.Visible = false;
		F81B9D85.Cursor = System.Windows.Forms.Cursors.Hand;
		F81B9D85.Location = new System.Drawing.Point(12, 174);
		F81B9D85.Name = "button8";
		F81B9D85.Size = new System.Drawing.Size(165, 26);
		F81B9D85.TabIndex = 13;
		F81B9D85.Text = "Kiếm tiền Golike";
		F81B9D85.Click += new System.EventHandler(D60F6C01);
		DF9A2B3C.Cursor = System.Windows.Forms.Cursors.Hand;
		DF9A2B3C.Location = new System.Drawing.Point(12, 145);
		DF9A2B3C.Name = "button5";
		DF9A2B3C.Size = new System.Drawing.Size(165, 26);
		DF9A2B3C.TabIndex = 4;
		DF9A2B3C.Text = "Uptop ba\u0300i viê\u0301t";
		DF9A2B3C.Click += new System.EventHandler(DF9A2B3C_Click);
		pictureBox3.Image = C50FB39E.B4A1BE8A;
		pictureBox3.Location = new System.Drawing.Point(18, 22);
		pictureBox3.Name = "pictureBox3";
		pictureBox3.Size = new System.Drawing.Size(151, 83);
		pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		pictureBox3.TabIndex = 1;
		pictureBox3.TabStop = false;
		groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		groupBox2.Controls.Add(panel3);
		groupBox2.Controls.Add(E431420F);
		groupBox2.Location = new System.Drawing.Point(3, 4);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new System.Drawing.Size(189, 472);
		groupBox2.TabIndex = 5;
		groupBox2.TabStop = false;
		groupBox2.Text = "Tương tác cá nhân";
		panel3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		panel3.AutoScroll = true;
		panel3.Controls.Add(D3861214);
		panel3.Controls.Add(BC0FD707);
		panel3.Controls.Add(A619EBB3);
		panel3.Controls.Add(metroButton62);
		panel3.Controls.Add(metroButton65);
		panel3.Controls.Add(metroButton69);
		panel3.Controls.Add(metroButton77);
		panel3.Controls.Add(EA1D0280);
		panel3.Controls.Add(metroButton76);
		panel3.Controls.Add(DCAD758A);
		panel3.Controls.Add(E7886636);
		panel3.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		panel3.Location = new System.Drawing.Point(1, 120);
		panel3.Name = "panel3";
		panel3.Size = new System.Drawing.Size(187, 347);
		panel3.TabIndex = 14;
		D3861214.Cursor = System.Windows.Forms.Cursors.Hand;
		D3861214.Location = new System.Drawing.Point(12, 115);
		D3861214.Name = "metroButton78";
		D3861214.Size = new System.Drawing.Size(162, 26);
		D3861214.TabIndex = 5;
		D3861214.Text = "Chúc mừng sinh nhật";
		D3861214.Click += new System.EventHandler(ED91D816);
		A619EBB3.Cursor = System.Windows.Forms.Cursors.Hand;
		A619EBB3.Location = new System.Drawing.Point(12, 0);
		A619EBB3.Name = "metroButton61";
		A619EBB3.Size = new System.Drawing.Size(162, 26);
		A619EBB3.TabIndex = 0;
		A619EBB3.Text = "Đọc thông báo";
		A619EBB3.Click += new System.EventHandler(A619EBB3_Click);
		metroButton62.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton62.Location = new System.Drawing.Point(12, 29);
		metroButton62.Name = "metroButton62";
		metroButton62.Size = new System.Drawing.Size(162, 26);
		metroButton62.TabIndex = 1;
		metroButton62.Text = "Xem Story";
		metroButton62.Click += new System.EventHandler(metroButton62_Click);
		metroButton65.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton65.Location = new System.Drawing.Point(12, 58);
		metroButton65.Name = "metroButton65";
		metroButton65.Size = new System.Drawing.Size(162, 26);
		metroButton65.TabIndex = 2;
		metroButton65.Text = "Xem Watch";
		metroButton65.Click += new System.EventHandler(metroButton65_Click);
		metroButton69.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton69.Location = new System.Drawing.Point(12, 86);
		metroButton69.Name = "metroButton69";
		metroButton69.Size = new System.Drawing.Size(162, 26);
		metroButton69.TabIndex = 4;
		metroButton69.Text = "Chọc bạn bè";
		metroButton69.Click += new System.EventHandler(metroButton69_Click);
		metroButton77.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton77.Location = new System.Drawing.Point(12, 144);
		metroButton77.Name = "metroButton77";
		metroButton77.Size = new System.Drawing.Size(162, 26);
		metroButton77.TabIndex = 2;
		metroButton77.Text = "Đăng story";
		metroButton77.Click += new System.EventHandler(metroButton77_Click);
		EA1D0280.Cursor = System.Windows.Forms.Cursors.Hand;
		EA1D0280.Location = new System.Drawing.Point(12, 231);
		EA1D0280.Name = "btnDangReel";
		EA1D0280.Size = new System.Drawing.Size(162, 26);
		EA1D0280.TabIndex = 2;
		EA1D0280.Text = "Đăng reel";
		EA1D0280.Click += new System.EventHandler(EA1D0280_Click);
		metroButton76.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton76.Location = new System.Drawing.Point(12, 173);
		metroButton76.Name = "metroButton76";
		metroButton76.Size = new System.Drawing.Size(162, 26);
		metroButton76.TabIndex = 2;
		metroButton76.Text = "Đăng status";
		metroButton76.Click += new System.EventHandler(metroButton76_Click);
		DCAD758A.Cursor = System.Windows.Forms.Cursors.Hand;
		DCAD758A.Location = new System.Drawing.Point(12, 173);
		DCAD758A.Name = "button4";
		DCAD758A.Size = new System.Drawing.Size(162, 26);
		DCAD758A.TabIndex = 7;
		DCAD758A.Text = "Share page (ẩn)";
		E7886636.Cursor = System.Windows.Forms.Cursors.Hand;
		E7886636.Location = new System.Drawing.Point(12, 173);
		E7886636.Name = "button2";
		E7886636.Size = new System.Drawing.Size(162, 26);
		E7886636.TabIndex = 7;
		E7886636.Text = "Uptop Post (ẩn)";
		E431420F.Image = C50FB39E.Bitmap_4;
		E431420F.Location = new System.Drawing.Point(18, 22);
		E431420F.Name = "pictureBox2";
		E431420F.Size = new System.Drawing.Size(151, 83);
		E431420F.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		E431420F.TabIndex = 1;
		E431420F.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(groupBox5);
		base.Controls.Add(D2A617A2);
		base.Controls.Add(groupBox4);
		base.Controls.Add(AD29E11B);
		base.Controls.Add(D939322B);
		base.Controls.Add(groupBox2);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "ucThemHanhDong";
		base.Size = new System.Drawing.Size(1174, 476);
		groupBox5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)C809C09E).EndInit();
		BB948F33.ResumeLayout(false);
		D2A617A2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
		panel8.ResumeLayout(false);
		groupBox4.ResumeLayout(false);
		panel5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)E108F50F).EndInit();
		AD29E11B.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)A5829D05).EndInit();
		BF2E7CB1.ResumeLayout(false);
		D939322B.ResumeLayout(false);
		A398EF2A.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
		groupBox2.ResumeLayout(false);
		panel3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)E431420F).EndInit();
		ResumeLayout(false);
	}
}
