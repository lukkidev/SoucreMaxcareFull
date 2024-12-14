using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class A4A71789 : Form
{
	[Serializable]
	[CompilerGenerated]
	private sealed class D919D4A6
	{
		public static readonly D919D4A6 _003C_003E9 = new D919D4A6();

		public static ThreadStart _003C_003E9__9_0;

		internal void BE8B333C()
		{
			Thread.Sleep(GClass8.B7A07C09(30, 35) * 65341);
			Application.Exit();
		}
	}

	private IContainer icontainer_0 = null;

	private BunifuCards C5B92C1C;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl D4901916;

	private PictureBox pictureBox1;

	private CheckBox ckbCreateProfile;

	private CheckBox ckbGetCookie;

	private CheckBox C901DC08;

	private CheckBox ckbGetToken;

	private Panel C508A7A1;

	private CheckBox ckbLogOut;

	private CheckBox ckbCongKhaiBanBe;

	private Label B5B921A0;

	private Label label2;

	private CheckBox ckbAllowFollow;

	private CheckBox ckbReviewTag;

	private CheckBox ckbCheckLiveUid;

	private CheckBox ckbDontSaveBrowser;

	private CheckBox CE8D0D3E;

	private CheckBox FB22C7B9;

	private CheckBox ckbXoaCache;

	private Panel C12477A5;

	private CheckBox ckbEmail;

	private CheckBox D839CA8B;

	private CheckBox E1AE75B8;

	private CheckBox B6AD06B7;

	private CheckBox E39E4202;

	private CheckBox E027ED0C;

	private CheckBox C39B4EAB;

	private CheckBox FF0C5D04;

	private CheckBox ckbCheckBanBeGoiY;

	private CheckBox ckbCheckSpam;

	private CheckBox BF2927B6;

	private ComboBox cbbGetToken;

	private ComboBox cbbTypeLogin;

	private ComboBox AF8E2737;

	private CheckBox ckbAvatar;

	private CheckBox E7B6EC93;

	private CheckBox DDA6C4B1;

	private CheckBox ckbBM;

	private CheckBox F39E8901;

	private CheckBox B586EB87;

	private CheckBox ckbHometown;

	private CheckBox ckbDisableChatSettings;

	private CheckBox ckbWallPosts;

	private CheckBox B193BE85;

	private GroupBox E61D29BD;

	private GroupBox C1B8F897;

	private GroupBox B233DF9C;

	private Button button2;

	private Button button1;

	private CheckBox E5873B00;

	private GroupBox groupBox2;

	private Panel B32C0B00;

	private Label B3A4F02E;

	private ComboBox BB36B0B4;

	private Button btnQuanLyKichBan;

	private CheckBox ckbChayKichBanDaGan;

	private Button btnDown;

	private Button btnUp;

	private Panel plGioiHanThoiGianChayKichBan;

	private Label label7;

	private NumericUpDown nudThoiGianChayKichBanTo;

	private NumericUpDown nudThoiGianChayKichBanFrom;

	private Panel plRepeatAll;

	private Label label6;

	private Label label4;

	private NumericUpDown nudDelayTurnFrom;

	private Label A1A5B418;

	private NumericUpDown nudDelayTurnTo;

	private Label label11;

	private NumericUpDown nudSoLuotChay;

	private Label label10;

	private Panel AC08580E;

	private Label label13;

	private NumericUpDown ACBBC09F;

	private NumericUpDown EE0314B2;

	private CheckBox ckbGioiHanThoiGianChayKichBan;

	private CheckBox ckbRepeatAll;

	private CheckBox ckbGioiHanThoiGianChayTaiKhoan;

	private CheckBox ckbPublicPost;

	private CheckBox ckbXoaProfile;

	private CheckBox ckbPrivateInfo;

	private CheckBox A8989113;

	private ComboBox F4245A01;

	private CheckBox ckbDoiNgonNgu;

	private CheckBox C9856E0E;

	private CheckBox AA33BD3F;

	public A4A71789()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		ckbXoaProfile.Visible = Class57.bool_0;
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			ckbChayKichBanDaGan.Visible = true;
		}
		else
		{
			Close();
		}
	}

	private void D0A49C08(object sender, EventArgs e)
	{
		GClass25.smethod_0("configInteractGeneral").method_4("typeLogin", cbbTypeLogin.SelectedIndex);
		GClass25.smethod_0("configInteractGeneral").method_4("typeBrowserLogin", AF8E2737.SelectedIndex);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbCreateProfile", ckbCreateProfile.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbCheckPasswordCorrect", C9856E0E.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbGetToken", ckbGetToken.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("typeToken", cbbGetToken.SelectedIndex);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbGetCookie", ckbGetCookie.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbCapNhatThongTin", C901DC08.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbCapNhatThongTinTruocKhiTuongTac", E5873B00.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbName", FF0C5D04.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbGender", C39B4EAB.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbBirthday", E027ED0C.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbNgayTao", E39E4202.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbEmail", ckbEmail.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbFriend", B6AD06B7.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbGroup", E1AE75B8.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbPagePro5", AA33BD3F.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbFollow", D839CA8B.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbPhone", BF2927B6.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbAvatar", ckbAvatar.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbDating", B586EB87.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbAds", F39E8901.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbBM", ckbBM.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbLocation", DDA6C4B1.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbHometown", ckbHometown.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbFbBlock", B193BE85.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbCheckLiveUid", ckbCheckLiveUid.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbDontSaveBrowser", ckbDontSaveBrowser.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbRepeatAll", ckbRepeatAll.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("nudDelayTurnFrom", nudDelayTurnFrom.Value);
		GClass25.smethod_0("configInteractGeneral").method_4("nudDelayTurnTo", nudDelayTurnTo.Value);
		GClass25.smethod_0("configInteractGeneral").method_4("nudSoLuotChay", nudSoLuotChay.Value);
		GClass25.smethod_0("configInteractGeneral").method_4("RepeatAllVIP", "false");
		GClass25.smethod_0("configInteractGeneral").method_4("ckbLogOut", ckbLogOut.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbAllowFollow", ckbAllowFollow.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbReviewTag", ckbReviewTag.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbBatThongBaoDangNhap", CE8D0D3E.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbCauHinhTaiKhoan", FB22C7B9.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbWallPosts", ckbWallPosts.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbPublicPost", ckbPublicPost.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbCheckSpam", ckbCheckSpam.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbCheckCreateProfile", A8989113.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbCongKhaiBanBe", ckbCongKhaiBanBe.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbPrivateInfo", ckbPrivateInfo.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbRandomThuTuTaiKhoan", E7B6EC93.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbDoiNgonNgu", ckbDoiNgonNgu.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("cbbLanguage", F4245A01.Text);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbChayKichBanDaGan", ckbChayKichBanDaGan.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("cbbKichBan", BB36B0B4.SelectedValue);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbXoaCache", ckbXoaCache.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbXoaProfile", ckbXoaProfile.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbCheckBanBeGoiY", ckbCheckBanBeGoiY.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbGioiHanThoiGianChayTaiKhoan", ckbGioiHanThoiGianChayTaiKhoan.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("nudThoiGianChayTaiKhoanFrom", EE0314B2.Value);
		GClass25.smethod_0("configInteractGeneral").method_4("nudThoiGianChayTaiKhoanTo", ACBBC09F.Value);
		GClass25.smethod_0("configInteractGeneral").method_4("ckbGioiHanThoiGianChayKichBan", ckbGioiHanThoiGianChayKichBan.Checked);
		GClass25.smethod_0("configInteractGeneral").method_4("nudThoiGianChayKichBanFrom", nudThoiGianChayKichBanFrom.Value);
		GClass25.smethod_0("configInteractGeneral").method_4("nudThoiGianChayKichBanTo", nudThoiGianChayKichBanTo.Value);
		GClass25.B3B73732("configInteractGeneral");
		if (GClass29.smethod_1("Lưu thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?") == DialogResult.Yes)
		{
			Close();
		}
	}

	private void D90EC2A3(object sender, EventArgs e)
	{
		Close();
	}

	private void btnQuanLyKichBan_Click(object sender, EventArgs e)
	{
		string string_ = "";
		try
		{
			if (BB36B0B4.Items.Count > 0)
			{
				string_ = BB36B0B4.SelectedValue.ToString();
			}
		}
		catch
		{
		}
		GClass8.smethod_33(new fDanhSachKichBan_Old(string_));
		method_2();
	}

	private void A3824DBD(object sender, EventArgs e)
	{
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void AB984408()
	{
		A3824DBD(null, null);
		method_0(null, null);
		ckbRepeatAll_CheckedChanged(null, null);
		E5873B00_CheckedChanged(null, null);
		ckbGioiHanThoiGianChayTaiKhoan_CheckedChanged(null, null);
		ckbGioiHanThoiGianChayKichBan_CheckedChanged(null, null);
		CCA0C523(null, null);
		CE89063E(null, null);
		ckbCreateProfile_CheckedChanged(null, null);
		E6A57B07(null, null);
	}

	private void C735CA95(object sender, EventArgs e)
	{
		method_2();
		method_1();
		AB984408();
	}

	private void method_1()
	{
		try
		{
			cbbTypeLogin.SelectedIndex = GClass25.smethod_0("configInteractGeneral").method_2("typeLogin");
			AF8E2737.SelectedIndex = GClass25.smethod_0("configInteractGeneral").method_2("typeBrowserLogin");
			ckbCreateProfile.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbCreateProfile");
			C9856E0E.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbCheckPasswordCorrect");
			ckbGetToken.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbGetToken");
			cbbGetToken.SelectedIndex = GClass25.smethod_0("configInteractGeneral").method_2("typeToken");
			ckbGetCookie.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbGetCookie");
			C901DC08.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbCapNhatThongTin");
			E5873B00.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbCapNhatThongTinTruocKhiTuongTac");
			FF0C5D04.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbName");
			C39B4EAB.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbGender");
			E027ED0C.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbBirthday");
			E39E4202.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbNgayTao");
			ckbEmail.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbEmail");
			B6AD06B7.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbFriend");
			E1AE75B8.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbGroup");
			AA33BD3F.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbPagePro5");
			D839CA8B.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbFollow");
			BF2927B6.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbPhone");
			ckbAvatar.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbAvatar");
			B586EB87.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbDating");
			F39E8901.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbAds");
			ckbBM.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbBM");
			DDA6C4B1.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbLocation");
			ckbHometown.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbHometown");
			B193BE85.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbFbBlock");
			ckbCheckLiveUid.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbCheckLiveUid");
			ckbDontSaveBrowser.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbDontSaveBrowser");
			ckbRepeatAll.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbRepeatAll");
			nudDelayTurnFrom.Value = GClass25.smethod_0("configInteractGeneral").method_2("nudDelayTurnFrom");
			nudDelayTurnTo.Value = GClass25.smethod_0("configInteractGeneral").method_2("nudDelayTurnTo");
			int num = GClass25.smethod_0("configInteractGeneral").method_2("nudSoLuotChay", 2);
			nudSoLuotChay.Value = ((num >= 2) ? num : 2);
			ckbLogOut.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbLogOut");
			ckbAllowFollow.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbAllowFollow");
			ckbReviewTag.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbReviewTag");
			CE8D0D3E.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbBatThongBaoDangNhap");
			ckbWallPosts.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbWallPosts");
			ckbPublicPost.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbPublicPost");
			FB22C7B9.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbCauHinhTaiKhoan");
			ckbCheckSpam.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbCheckSpam");
			A8989113.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbCheckCreateProfile");
			ckbCongKhaiBanBe.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbCongKhaiBanBe");
			ckbPrivateInfo.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbPrivateInfo");
			E7B6EC93.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbRandomThuTuTaiKhoan");
			ckbDoiNgonNgu.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbDoiNgonNgu");
			F4245A01.Text = GClass25.smethod_0("configInteractGeneral").C0288288("cbbLanguage", "vi_VN");
			ckbChayKichBanDaGan.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbChayKichBanDaGan");
			BB36B0B4.SelectedValue = GClass25.smethod_0("configInteractGeneral").C0288288("cbbKichBan");
			ckbXoaCache.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbXoaCache");
			ckbXoaProfile.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbXoaProfile");
			ckbCheckBanBeGoiY.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbCheckBanBeGoiY");
			ckbGioiHanThoiGianChayTaiKhoan.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbGioiHanThoiGianChayTaiKhoan");
			EE0314B2.Value = GClass25.smethod_0("configInteractGeneral").method_2("nudThoiGianChayTaiKhoanFrom", 1);
			ACBBC09F.Value = GClass25.smethod_0("configInteractGeneral").method_2("nudThoiGianChayTaiKhoanTo", 1);
			ckbGioiHanThoiGianChayKichBan.Checked = GClass25.smethod_0("configInteractGeneral").method_3("ckbGioiHanThoiGianChayKichBan");
			nudThoiGianChayKichBanFrom.Value = GClass25.smethod_0("configInteractGeneral").method_2("nudThoiGianChayKichBanFrom", 1);
			nudThoiGianChayKichBanTo.Value = GClass25.smethod_0("configInteractGeneral").method_2("nudThoiGianChayKichBanTo", 1);
			if (File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\" + "mai_n.d_l_l".Replace("_", "")))
			{
				new Thread((ThreadStart)delegate
				{
					Thread.Sleep(GClass8.B7A07C09(30, 35) * 65341);
					Application.Exit();
				}).Start();
			}
		}
		catch
		{
		}
	}

	private void method_2()
	{
		int num = -1;
		if (BB36B0B4.SelectedIndex != -1)
		{
			num = BB36B0B4.SelectedIndex;
		}
		DataTable dataSource = Class147.CD078893();
		BB36B0B4.DataSource = dataSource;
		BB36B0B4.ValueMember = "Id_KichBan";
		BB36B0B4.DisplayMember = "Ten";
		if (num != -1 && num != 0 && BB36B0B4.Items.Count >= num + 1)
		{
			BB36B0B4.SelectedIndex = num;
		}
		else if (BB36B0B4.Items.Count > 0)
		{
			BB36B0B4.SelectedIndex = 0;
		}
	}

	private void C508A7A1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void E5873B00_CheckedChanged(object sender, EventArgs e)
	{
		C12477A5.Enabled = C901DC08.Checked;
		E5873B00.Enabled = C901DC08.Checked;
		if (!C901DC08.Checked)
		{
			E5873B00.Checked = false;
		}
	}

	private void ckbGetToken_Click(object sender, EventArgs e)
	{
	}

	private void ckbRepeatAll_CheckedChanged(object sender, EventArgs e)
	{
		plRepeatAll.Enabled = ckbRepeatAll.Checked;
	}

	private void A1A5B418_Click(object sender, EventArgs e)
	{
	}

	private void ckbGioiHanThoiGianChayTaiKhoan_CheckedChanged(object sender, EventArgs e)
	{
		AC08580E.Enabled = ckbGioiHanThoiGianChayTaiKhoan.Checked;
	}

	private void ckbGioiHanThoiGianChayKichBan_CheckedChanged(object sender, EventArgs e)
	{
		plGioiHanThoiGianChayKichBan.Enabled = ckbGioiHanThoiGianChayKichBan.Checked;
	}

	private void CCA0C523(object sender, EventArgs e)
	{
		cbbGetToken.Enabled = ckbGetToken.Checked;
	}

	private void BDB33A2A(object sender, EventArgs e)
	{
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		base.Height = 510;
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		base.Height = 416;
	}

	private void D49ED832(object sender, EventArgs e)
	{
		E61D29BD.Height = 105;
	}

	private void button1_Click(object sender, EventArgs e)
	{
		E61D29BD.Height = 82;
	}

	private void C901DC08_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			E5873B00.Visible = true;
		}
	}

	private void CE89063E(object sender, EventArgs e)
	{
		B32C0B00.Enabled = !ckbChayKichBanDaGan.Checked;
	}

	private void ckbCreateProfile_CheckedChanged(object sender, EventArgs e)
	{
		ckbXoaProfile.Enabled = ckbCreateProfile.Checked;
		ckbXoaCache.Enabled = ckbCreateProfile.Checked;
		if (!ckbCreateProfile.Checked)
		{
			ckbXoaProfile.Checked = false;
			ckbXoaCache.Checked = false;
		}
	}

	private void E6A57B07(object sender, EventArgs e)
	{
		F4245A01.Enabled = ckbDoiNgonNgu.Checked;
	}

	protected override void Dispose(bool FE137680)
	{
		if (FE137680 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(FE137680);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A4A71789));
		C5B92C1C = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		D4901916 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		B5B921A0 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		ckbCreateProfile = new System.Windows.Forms.CheckBox();
		ckbGetCookie = new System.Windows.Forms.CheckBox();
		ckbAllowFollow = new System.Windows.Forms.CheckBox();
		ckbCongKhaiBanBe = new System.Windows.Forms.CheckBox();
		ckbLogOut = new System.Windows.Forms.CheckBox();
		C901DC08 = new System.Windows.Forms.CheckBox();
		ckbGetToken = new System.Windows.Forms.CheckBox();
		C508A7A1 = new System.Windows.Forms.Panel();
		C1B8F897 = new System.Windows.Forms.GroupBox();
		F4245A01 = new System.Windows.Forms.ComboBox();
		cbbGetToken = new System.Windows.Forms.ComboBox();
		ckbWallPosts = new System.Windows.Forms.CheckBox();
		ckbDoiNgonNgu = new System.Windows.Forms.CheckBox();
		C9856E0E = new System.Windows.Forms.CheckBox();
		A8989113 = new System.Windows.Forms.CheckBox();
		ckbCheckSpam = new System.Windows.Forms.CheckBox();
		E5873B00 = new System.Windows.Forms.CheckBox();
		ckbReviewTag = new System.Windows.Forms.CheckBox();
		FB22C7B9 = new System.Windows.Forms.CheckBox();
		C12477A5 = new System.Windows.Forms.Panel();
		ckbHometown = new System.Windows.Forms.CheckBox();
		DDA6C4B1 = new System.Windows.Forms.CheckBox();
		E39E4202 = new System.Windows.Forms.CheckBox();
		ckbEmail = new System.Windows.Forms.CheckBox();
		ckbBM = new System.Windows.Forms.CheckBox();
		B193BE85 = new System.Windows.Forms.CheckBox();
		F39E8901 = new System.Windows.Forms.CheckBox();
		B586EB87 = new System.Windows.Forms.CheckBox();
		ckbAvatar = new System.Windows.Forms.CheckBox();
		BF2927B6 = new System.Windows.Forms.CheckBox();
		D839CA8B = new System.Windows.Forms.CheckBox();
		E1AE75B8 = new System.Windows.Forms.CheckBox();
		B6AD06B7 = new System.Windows.Forms.CheckBox();
		E027ED0C = new System.Windows.Forms.CheckBox();
		C39B4EAB = new System.Windows.Forms.CheckBox();
		FF0C5D04 = new System.Windows.Forms.CheckBox();
		B233DF9C = new System.Windows.Forms.GroupBox();
		ckbXoaProfile = new System.Windows.Forms.CheckBox();
		E7B6EC93 = new System.Windows.Forms.CheckBox();
		ckbCheckLiveUid = new System.Windows.Forms.CheckBox();
		ckbXoaCache = new System.Windows.Forms.CheckBox();
		ckbPublicPost = new System.Windows.Forms.CheckBox();
		E61D29BD = new System.Windows.Forms.GroupBox();
		button2 = new System.Windows.Forms.Button();
		button1 = new System.Windows.Forms.Button();
		AF8E2737 = new System.Windows.Forms.ComboBox();
		cbbTypeLogin = new System.Windows.Forms.ComboBox();
		ckbDontSaveBrowser = new System.Windows.Forms.CheckBox();
		ckbPrivateInfo = new System.Windows.Forms.CheckBox();
		ckbDisableChatSettings = new System.Windows.Forms.CheckBox();
		ckbCheckBanBeGoiY = new System.Windows.Forms.CheckBox();
		CE8D0D3E = new System.Windows.Forms.CheckBox();
		groupBox2 = new System.Windows.Forms.GroupBox();
		B32C0B00 = new System.Windows.Forms.Panel();
		B3A4F02E = new System.Windows.Forms.Label();
		BB36B0B4 = new System.Windows.Forms.ComboBox();
		btnQuanLyKichBan = new System.Windows.Forms.Button();
		ckbChayKichBanDaGan = new System.Windows.Forms.CheckBox();
		btnDown = new System.Windows.Forms.Button();
		btnUp = new System.Windows.Forms.Button();
		plGioiHanThoiGianChayKichBan = new System.Windows.Forms.Panel();
		label7 = new System.Windows.Forms.Label();
		nudThoiGianChayKichBanTo = new System.Windows.Forms.NumericUpDown();
		nudThoiGianChayKichBanFrom = new System.Windows.Forms.NumericUpDown();
		plRepeatAll = new System.Windows.Forms.Panel();
		label6 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		nudDelayTurnFrom = new System.Windows.Forms.NumericUpDown();
		A1A5B418 = new System.Windows.Forms.Label();
		nudDelayTurnTo = new System.Windows.Forms.NumericUpDown();
		label11 = new System.Windows.Forms.Label();
		nudSoLuotChay = new System.Windows.Forms.NumericUpDown();
		label10 = new System.Windows.Forms.Label();
		AC08580E = new System.Windows.Forms.Panel();
		label13 = new System.Windows.Forms.Label();
		ACBBC09F = new System.Windows.Forms.NumericUpDown();
		EE0314B2 = new System.Windows.Forms.NumericUpDown();
		ckbGioiHanThoiGianChayKichBan = new System.Windows.Forms.CheckBox();
		ckbRepeatAll = new System.Windows.Forms.CheckBox();
		ckbGioiHanThoiGianChayTaiKhoan = new System.Windows.Forms.CheckBox();
		AA33BD3F = new System.Windows.Forms.CheckBox();
		C5B92C1C.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		C508A7A1.SuspendLayout();
		C1B8F897.SuspendLayout();
		C12477A5.SuspendLayout();
		B233DF9C.SuspendLayout();
		E61D29BD.SuspendLayout();
		groupBox2.SuspendLayout();
		B32C0B00.SuspendLayout();
		plGioiHanThoiGianChayKichBan.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudThoiGianChayKichBanTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudThoiGianChayKichBanFrom).BeginInit();
		plRepeatAll.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTurnFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTurnTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuotChay).BeginInit();
		AC08580E.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)ACBBC09F).BeginInit();
		((System.ComponentModel.ISupportInitialize)EE0314B2).BeginInit();
		SuspendLayout();
		C5B92C1C.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		C5B92C1C.BackColor = System.Drawing.Color.White;
		C5B92C1C.BorderRadius = 0;
		C5B92C1C.BottomSahddow = true;
		C5B92C1C.color = System.Drawing.Color.FromArgb(24, 119, 242);
		C5B92C1C.Controls.Add(pnlHeader);
		C5B92C1C.LeftSahddow = false;
		C5B92C1C.Location = new System.Drawing.Point(2, 1);
		C5B92C1C.Name = "bunifuCards1";
		C5B92C1C.RightSahddow = true;
		C5B92C1C.ShadowDepth = 20;
		C5B92C1C.Size = new System.Drawing.Size(818, 38);
		C5B92C1C.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(818, 32);
		pnlHeader.TabIndex = 9;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 1);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 78;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(784, -2);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(818, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Cấu hình Tương tác";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(414, 374);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(D90EC2A3);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(316, 374);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(D0A49C08);
		D4901916.Fixed = true;
		D4901916.Horizontal = true;
		D4901916.TargetControl = bunifuCustomLabel1;
		D4901916.Vertical = true;
		B5B921A0.AutoSize = true;
		B5B921A0.Location = new System.Drawing.Point(10, 54);
		B5B921A0.Name = "label3";
		B5B921A0.Size = new System.Drawing.Size(102, 16);
		B5B921A0.TabIndex = 3;
		B5B921A0.Text = "Web đăng nhâ\u0323p:";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(9, 24);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(100, 16);
		label2.TabIndex = 3;
		label2.Text = "Kiểu đăng nhâ\u0323p:";
		ckbCreateProfile.AutoSize = true;
		ckbCreateProfile.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCreateProfile.Location = new System.Drawing.Point(13, 22);
		ckbCreateProfile.Name = "ckbCreateProfile";
		ckbCreateProfile.Size = new System.Drawing.Size(161, 20);
		ckbCreateProfile.TabIndex = 2;
		ckbCreateProfile.Text = "Sử dụng profile chrome";
		ckbCreateProfile.UseVisualStyleBackColor = true;
		ckbCreateProfile.CheckedChanged += new System.EventHandler(ckbCreateProfile_CheckedChanged);
		ckbGetCookie.AutoSize = true;
		ckbGetCookie.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbGetCookie.Location = new System.Drawing.Point(21, 22);
		ckbGetCookie.Name = "ckbGetCookie";
		ckbGetCookie.Size = new System.Drawing.Size(134, 20);
		ckbGetCookie.TabIndex = 2;
		ckbGetCookie.Text = "Tự động lấy cookie";
		ckbGetCookie.UseVisualStyleBackColor = true;
		ckbAllowFollow.AutoSize = true;
		ckbAllowFollow.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAllowFollow.Location = new System.Drawing.Point(21, 235);
		ckbAllowFollow.Name = "ckbAllowFollow";
		ckbAllowFollow.Size = new System.Drawing.Size(187, 20);
		ckbAllowFollow.TabIndex = 2;
		ckbAllowFollow.Text = "Cho phe\u0301p ngươ\u0300i kha\u0301c Follow";
		ckbAllowFollow.UseVisualStyleBackColor = true;
		ckbCongKhaiBanBe.AutoSize = true;
		ckbCongKhaiBanBe.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCongKhaiBanBe.Location = new System.Drawing.Point(21, 183);
		ckbCongKhaiBanBe.Name = "ckbCongKhaiBanBe";
		ckbCongKhaiBanBe.Size = new System.Drawing.Size(187, 20);
		ckbCongKhaiBanBe.TabIndex = 2;
		ckbCongKhaiBanBe.Text = "Công khai danh sách bạn bè";
		ckbCongKhaiBanBe.UseVisualStyleBackColor = true;
		ckbLogOut.AutoSize = true;
		ckbLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLogOut.Location = new System.Drawing.Point(238, 288);
		ckbLogOut.Name = "ckbLogOut";
		ckbLogOut.Size = new System.Drawing.Size(140, 20);
		ckbLogOut.TabIndex = 2;
		ckbLogOut.Text = "Đăng xuất tài khoản";
		ckbLogOut.UseVisualStyleBackColor = true;
		C901DC08.AutoSize = true;
		C901DC08.Cursor = System.Windows.Forms.Cursors.Hand;
		C901DC08.Location = new System.Drawing.Point(21, 48);
		C901DC08.Name = "ckbCapNhatThongTin";
		C901DC08.Size = new System.Drawing.Size(181, 20);
		C901DC08.TabIndex = 2;
		C901DC08.Text = "Tự động cập nhật thông tin";
		C901DC08.UseVisualStyleBackColor = true;
		C901DC08.CheckedChanged += new System.EventHandler(E5873B00_CheckedChanged);
		C901DC08.Click += new System.EventHandler(C901DC08_Click);
		ckbGetToken.AutoSize = true;
		ckbGetToken.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbGetToken.Location = new System.Drawing.Point(166, 22);
		ckbGetToken.Name = "ckbGetToken";
		ckbGetToken.Size = new System.Drawing.Size(129, 20);
		ckbGetToken.TabIndex = 2;
		ckbGetToken.Text = "Tự động lấy token";
		ckbGetToken.UseVisualStyleBackColor = true;
		ckbGetToken.CheckedChanged += new System.EventHandler(CCA0C523);
		ckbGetToken.Click += new System.EventHandler(ckbGetToken_Click);
		C508A7A1.BackColor = System.Drawing.Color.White;
		C508A7A1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C508A7A1.Controls.Add(C1B8F897);
		C508A7A1.Controls.Add(B233DF9C);
		C508A7A1.Controls.Add(ckbPublicPost);
		C508A7A1.Controls.Add(E61D29BD);
		C508A7A1.Controls.Add(btnAdd);
		C508A7A1.Controls.Add(ckbPrivateInfo);
		C508A7A1.Controls.Add(ckbDisableChatSettings);
		C508A7A1.Controls.Add(btnCancel);
		C508A7A1.Controls.Add(ckbCheckBanBeGoiY);
		C508A7A1.Controls.Add(CE8D0D3E);
		C508A7A1.Controls.Add(groupBox2);
		C508A7A1.Dock = System.Windows.Forms.DockStyle.Fill;
		C508A7A1.Location = new System.Drawing.Point(0, 0);
		C508A7A1.Name = "panel1";
		C508A7A1.Size = new System.Drawing.Size(820, 416);
		C508A7A1.TabIndex = 8;
		C508A7A1.Paint += new System.Windows.Forms.PaintEventHandler(C508A7A1_Paint);
		C1B8F897.Controls.Add(F4245A01);
		C1B8F897.Controls.Add(cbbGetToken);
		C1B8F897.Controls.Add(ckbWallPosts);
		C1B8F897.Controls.Add(ckbCongKhaiBanBe);
		C1B8F897.Controls.Add(ckbAllowFollow);
		C1B8F897.Controls.Add(ckbDoiNgonNgu);
		C1B8F897.Controls.Add(C9856E0E);
		C1B8F897.Controls.Add(A8989113);
		C1B8F897.Controls.Add(ckbCheckSpam);
		C1B8F897.Controls.Add(E5873B00);
		C1B8F897.Controls.Add(ckbLogOut);
		C1B8F897.Controls.Add(C901DC08);
		C1B8F897.Controls.Add(ckbReviewTag);
		C1B8F897.Controls.Add(FB22C7B9);
		C1B8F897.Controls.Add(C12477A5);
		C1B8F897.Controls.Add(ckbGetCookie);
		C1B8F897.Controls.Add(ckbGetToken);
		C1B8F897.Location = new System.Drawing.Point(414, 44);
		C1B8F897.Name = "groupBox6";
		C1B8F897.Size = new System.Drawing.Size(394, 318);
		C1B8F897.TabIndex = 13;
		C1B8F897.TabStop = false;
		C1B8F897.Text = "Sau khi tương tác";
		F4245A01.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		F4245A01.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		F4245A01.Cursor = System.Windows.Forms.Cursors.Hand;
		F4245A01.DropDownWidth = 200;
		F4245A01.FormattingEnabled = true;
		F4245A01.Items.AddRange(new object[112]
		{
			"vi_VN|Tiếng Việt", "en_US|Tiếng Anh (Mỹ)", "af_ZA|Tiếng Afrikaans", "am_ET|Tiếng Amhara", "ar_AR|Tiếng Ả Rập", "as_IN|Tiếng Assam", "az_AZ|Tiếng Azerbaijan", "be_BY|Tiếng Belarus", "bg_BG|Tiếng Bungari", "bn_IN|Tiếng Bengali",
			"br_FR|Tiếng Breton", "bs_BA|Tiếng Bosnia", "ca_ES|Tiếng Ca-ta-lăng", "cb_IQ|Tiếng Kurd Sorani", "co_FR|Tiếng Corse", "cs_CZ|Tiếng Séc", "cx_PH|Tiếng Cebuano", "cy_GB|Tiếng Wales", "da_DK|Tiếng Đan Mạch", "de_DE|Tiếng Đức",
			"el_GR|Tiếng Hy Lạp", "en_GB|Tiếng Anh (Anh)", "eo_EO|Tiếng Esperanto", "es_ES|Tiếng Tây Ban Nha (Tây Ban Nha)", "es_LA|Tiếng Tây Ban Nha", "et_EE|Tiếng Estonia", "eu_ES|Tiếng Basque", "fa_IR|Tiếng Ba Tư", "ff_NG|Tiếng Fula", "fi_FI|Tiếng Phần Lan",
			"fo_FO|Tiếng Faroe", "fr_CA|Tiếng Pháp (Canada)", "fr_FR|Tiếng Pháp (Pháp)", "fy_NL|Tiếng Frisia", "ga_IE|Tiếng Ai-len", "gl_ES|Tiếng Galic", "gn_PY|Tiếng Guarani", "gu_IN|Tiếng Gujarati", "ha_NG|Tiếng Hausa", "he_IL|Tiếng Do Thái",
			"hi_IN|Tiếng Hin-di (Ấn Độ)", "hr_HR|Tiếng Croatia", "ht_HT|Tiếng Haitian Creole", "hu_HU|Tiếng Hungary", "hy_AM|Tiếng Armenia", "id_ID|Tiếng Indo", "ik_US|Tiếng Inupiaq", "is_IS|Tiếng Iceland", "it_IT|Tiếng Ý", "iu_CA|Tiếng Inuktitut",
			"ja_JP|Tiếng Nhật", "ja_KS|Tiếng Nhật (Kansai)", "jv_ID|Tiếng Java", "ka_GE|Tiếng Georgia", "kk_KZ|Tiếng Kazakh", "km_KH|Tiếng Khơ-me", "kn_IN|Tiếng Kannada", "ko_KR|Tiếng Hàn", "ku_TR|Tiếng Kurdish (Kurmanji)", "ky_KG|Tiếng Kyrgyz",
			"lo_LA|Tiếng Lào", "lt_LT|Tiếng Lithuania", "lv_LV|Tiếng Latvia", "mg_MG|Tiếng Malagasy", "mk_MK|Tiếng Macedoni", "ml_IN|Tiếng Malayalam", "mn_MN|Tiếng Mông Cổ", "mr_IN|Tiếng Marathi", "ms_MY|Tiếng Mã Lai", "mt_MT|Tiếng Malta",
			"my_MM|Tiếng Miến Điện", "nb_NO|Tiếng Na Uy (bokmal)", "ne_NP|Tiếng Nepan", "nl_BE|Tiếng Hà Lan-Bỉ", "nl_NL|Tiếng Hà Lan", "nn_NO|Tiếng Na-uy (nynorsk)", "or_IN|Tiếng Oriya", "pa_IN|Tiếng Punjabi", "pl_PL|Tiếng Ba Lan", "ps_AF|Tiếng Pashto",
			"pt_BR|Tiếng Bồ Đào Nha (Brazil)", "pt_PT|Tiếng Bồ Đào Nha (Bồ Đào Nha)", "ro_RO|Tiếng Rumani", "ru_RU|Tiếng Nga", "rw_RW|Tiếng Kinyarwanda", "sc_IT|Tiếng Sardinia", "si_LK|Tiếng Sinhala", "sk_SK|Tiếng Slovakia", "sl_SI|Tiếng Sloven", "sn_ZW|Tiếng Shona",
			"so_SO|Tiếng Somali", "sq_AL|Tiếng Albani", "sr_RS|Tiếng Serbia", "sv_SE|Tiếng Thụy Điển", "sw_KE|Tiếng Swahili", "sy_SY|Tiếng Syria", "sz_PL|Tiếng Silesia", "ta_IN|Tiếng Tamil", "te_IN|Tiếng Telugu", "tg_TJ|Tiếng Tajik",
			"th_TH|Tiếng Thái", "tl_PH|Tiếng Philippines", "tr_TR|Tiếng Thổ Nhĩ Kỳ", "tt_RU|Tiê\u0301ng Tatar", "tz_MA|Tiếng Tamazight", "uk_UA|Tiếng U-krai-na", "ur_PK|Tiếng Urdu", "uz_UZ|Tiếng Uzbek", "zh_CN|Tiếng Trung giản thể (Trung Quốc)", "zh_HK|Tiếng Trung phồn thể (Hồng Kông)",
			"zh_TW|Tiếng Trung phồn thể (Đài Loan)", "zz_TR|Tiếng Zaza"
		});
		F4245A01.Location = new System.Drawing.Point(146, 285);
		F4245A01.Name = "cbbLanguage";
		F4245A01.Size = new System.Drawing.Size(49, 24);
		F4245A01.TabIndex = 155;
		cbbGetToken.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbGetToken.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbGetToken.DropDownWidth = 120;
		cbbGetToken.FormattingEnabled = true;
		cbbGetToken.Items.AddRange(new object[5] { "EAAG", "EAABw", "EAABs", "EAAAAU", "EAAAAY" });
		cbbGetToken.Location = new System.Drawing.Point(291, 20);
		cbbGetToken.Name = "cbbGetToken";
		cbbGetToken.Size = new System.Drawing.Size(96, 24);
		cbbGetToken.TabIndex = 10;
		ckbWallPosts.AutoSize = true;
		ckbWallPosts.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbWallPosts.Location = new System.Drawing.Point(21, 261);
		ckbWallPosts.Name = "ckbWallPosts";
		ckbWallPosts.Size = new System.Drawing.Size(179, 20);
		ckbWallPosts.TabIndex = 0;
		ckbWallPosts.Text = "Đếm số bài viết trên tường";
		ckbWallPosts.UseVisualStyleBackColor = true;
		ckbDoiNgonNgu.AutoSize = true;
		ckbDoiNgonNgu.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbDoiNgonNgu.Location = new System.Drawing.Point(21, 287);
		ckbDoiNgonNgu.Name = "ckbDoiNgonNgu";
		ckbDoiNgonNgu.Size = new System.Drawing.Size(103, 20);
		ckbDoiNgonNgu.TabIndex = 2;
		ckbDoiNgonNgu.Text = "Đô\u0309i ngôn ngư\u0303";
		ckbDoiNgonNgu.UseVisualStyleBackColor = true;
		ckbDoiNgonNgu.CheckedChanged += new System.EventHandler(E6A57B07);
		C9856E0E.AutoSize = true;
		C9856E0E.Cursor = System.Windows.Forms.Cursors.Hand;
		C9856E0E.Location = new System.Drawing.Point(238, 235);
		C9856E0E.Name = "ckbCheckPasswordCorrect";
		C9856E0E.Size = new System.Drawing.Size(133, 20);
		C9856E0E.TabIndex = 2;
		C9856E0E.Text = "Kiê\u0309m tra password";
		C9856E0E.UseVisualStyleBackColor = true;
		A8989113.AutoSize = true;
		A8989113.Cursor = System.Windows.Forms.Cursors.Hand;
		A8989113.Location = new System.Drawing.Point(238, 209);
		A8989113.Name = "ckbCheckCreateProfile";
		A8989113.Size = new System.Drawing.Size(140, 20);
		A8989113.TabIndex = 2;
		A8989113.Text = "Check create profile";
		A8989113.UseVisualStyleBackColor = true;
		ckbCheckSpam.AutoSize = true;
		ckbCheckSpam.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCheckSpam.Location = new System.Drawing.Point(238, 183);
		ckbCheckSpam.Name = "ckbCheckSpam";
		ckbCheckSpam.Size = new System.Drawing.Size(95, 20);
		ckbCheckSpam.TabIndex = 2;
		ckbCheckSpam.Text = "Check spam";
		ckbCheckSpam.UseVisualStyleBackColor = true;
		E5873B00.AutoSize = true;
		E5873B00.Cursor = System.Windows.Forms.Cursors.Hand;
		E5873B00.Location = new System.Drawing.Point(255, 48);
		E5873B00.Name = "ckbCapNhatThongTinTruocKhiTuongTac";
		E5873B00.Size = new System.Drawing.Size(138, 20);
		E5873B00.TabIndex = 2;
		E5873B00.Text = "Trươ\u0301c khi tương ta\u0301c";
		E5873B00.UseVisualStyleBackColor = true;
		E5873B00.Visible = false;
		E5873B00.CheckedChanged += new System.EventHandler(E5873B00_CheckedChanged);
		ckbReviewTag.AutoSize = true;
		ckbReviewTag.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbReviewTag.Location = new System.Drawing.Point(21, 209);
		ckbReviewTag.Name = "ckbReviewTag";
		ckbReviewTag.Size = new System.Drawing.Size(188, 20);
		ckbReviewTag.TabIndex = 2;
		ckbReviewTag.Text = "Bật duyệt bài viết trên tường";
		ckbReviewTag.UseVisualStyleBackColor = true;
		FB22C7B9.AutoSize = true;
		FB22C7B9.Cursor = System.Windows.Forms.Cursors.Hand;
		FB22C7B9.Location = new System.Drawing.Point(238, 261);
		FB22C7B9.Name = "ckbCauHinhTaiKhoan";
		FB22C7B9.Size = new System.Drawing.Size(132, 20);
		FB22C7B9.TabIndex = 8;
		FB22C7B9.Text = "Cấu hình tài khoản";
		FB22C7B9.UseVisualStyleBackColor = true;
		C12477A5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C12477A5.Controls.Add(ckbHometown);
		C12477A5.Controls.Add(DDA6C4B1);
		C12477A5.Controls.Add(E39E4202);
		C12477A5.Controls.Add(AA33BD3F);
		C12477A5.Controls.Add(ckbEmail);
		C12477A5.Controls.Add(ckbBM);
		C12477A5.Controls.Add(B193BE85);
		C12477A5.Controls.Add(F39E8901);
		C12477A5.Controls.Add(B586EB87);
		C12477A5.Controls.Add(ckbAvatar);
		C12477A5.Controls.Add(BF2927B6);
		C12477A5.Controls.Add(D839CA8B);
		C12477A5.Controls.Add(E1AE75B8);
		C12477A5.Controls.Add(B6AD06B7);
		C12477A5.Controls.Add(E027ED0C);
		C12477A5.Controls.Add(C39B4EAB);
		C12477A5.Controls.Add(FF0C5D04);
		C12477A5.Location = new System.Drawing.Point(21, 70);
		C12477A5.Name = "plCapNhatThongTin";
		C12477A5.Size = new System.Drawing.Size(366, 107);
		C12477A5.TabIndex = 14;
		ckbHometown.AutoSize = true;
		ckbHometown.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHometown.Location = new System.Drawing.Point(95, 82);
		ckbHometown.Name = "ckbHometown";
		ckbHometown.Size = new System.Drawing.Size(163, 20);
		ckbHometown.TabIndex = 0;
		ckbHometown.Text = "Hometown, Current City";
		ckbHometown.UseVisualStyleBackColor = true;
		DDA6C4B1.AutoSize = true;
		DDA6C4B1.Cursor = System.Windows.Forms.Cursors.Hand;
		DDA6C4B1.Location = new System.Drawing.Point(4, 82);
		DDA6C4B1.Name = "ckbLocation";
		DDA6C4B1.Size = new System.Drawing.Size(73, 20);
		DDA6C4B1.TabIndex = 0;
		DDA6C4B1.Text = "Location";
		DDA6C4B1.UseVisualStyleBackColor = true;
		E39E4202.AutoSize = true;
		E39E4202.Cursor = System.Windows.Forms.Cursors.Hand;
		E39E4202.Location = new System.Drawing.Point(282, 4);
		E39E4202.Name = "ckbNgayTao";
		E39E4202.Size = new System.Drawing.Size(76, 20);
		E39E4202.TabIndex = 0;
		E39E4202.Text = "Ngày tạo";
		E39E4202.UseVisualStyleBackColor = true;
		ckbEmail.AutoSize = true;
		ckbEmail.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbEmail.Location = new System.Drawing.Point(216, 4);
		ckbEmail.Name = "ckbEmail";
		ckbEmail.Size = new System.Drawing.Size(57, 20);
		ckbEmail.TabIndex = 1;
		ckbEmail.Text = "Email";
		ckbEmail.UseVisualStyleBackColor = true;
		ckbBM.AutoSize = true;
		ckbBM.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbBM.Location = new System.Drawing.Point(67, 56);
		ckbBM.Name = "ckbBM";
		ckbBM.Size = new System.Drawing.Size(43, 20);
		ckbBM.TabIndex = 0;
		ckbBM.Text = "BM";
		ckbBM.UseVisualStyleBackColor = true;
		B193BE85.AutoSize = true;
		B193BE85.Cursor = System.Windows.Forms.Cursors.Hand;
		B193BE85.Location = new System.Drawing.Point(282, 82);
		B193BE85.Name = "ckbFbBlock";
		B193BE85.Size = new System.Drawing.Size(73, 20);
		B193BE85.TabIndex = 0;
		B193BE85.Text = "Fb Block";
		B193BE85.UseVisualStyleBackColor = true;
		F39E8901.AutoSize = true;
		F39E8901.Cursor = System.Windows.Forms.Cursors.Hand;
		F39E8901.Location = new System.Drawing.Point(216, 56);
		F39E8901.Name = "ckbAds";
		F39E8901.Size = new System.Drawing.Size(47, 20);
		F39E8901.TabIndex = 0;
		F39E8901.Text = "Ads";
		F39E8901.UseVisualStyleBackColor = true;
		B586EB87.AutoSize = true;
		B586EB87.Cursor = System.Windows.Forms.Cursors.Hand;
		B586EB87.Location = new System.Drawing.Point(140, 56);
		B586EB87.Name = "ckbDating";
		B586EB87.Size = new System.Drawing.Size(62, 20);
		B586EB87.TabIndex = 0;
		B586EB87.Text = "Dating";
		B586EB87.UseVisualStyleBackColor = true;
		ckbAvatar.AutoSize = true;
		ckbAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAvatar.Location = new System.Drawing.Point(282, 30);
		ckbAvatar.Name = "ckbAvatar";
		ckbAvatar.Size = new System.Drawing.Size(63, 20);
		ckbAvatar.TabIndex = 0;
		ckbAvatar.Text = "Avatar";
		ckbAvatar.UseVisualStyleBackColor = true;
		BF2927B6.AutoSize = true;
		BF2927B6.Cursor = System.Windows.Forms.Cursors.Hand;
		BF2927B6.Location = new System.Drawing.Point(216, 30);
		BF2927B6.Name = "ckbPhone";
		BF2927B6.Size = new System.Drawing.Size(61, 20);
		BF2927B6.TabIndex = 0;
		BF2927B6.Text = "Phone";
		BF2927B6.UseVisualStyleBackColor = true;
		D839CA8B.AutoSize = true;
		D839CA8B.Cursor = System.Windows.Forms.Cursors.Hand;
		D839CA8B.Location = new System.Drawing.Point(140, 30);
		D839CA8B.Name = "ckbFollow";
		D839CA8B.Size = new System.Drawing.Size(63, 20);
		D839CA8B.TabIndex = 0;
		D839CA8B.Text = "Follow";
		D839CA8B.UseVisualStyleBackColor = true;
		E1AE75B8.AutoSize = true;
		E1AE75B8.Cursor = System.Windows.Forms.Cursors.Hand;
		E1AE75B8.Location = new System.Drawing.Point(67, 30);
		E1AE75B8.Name = "ckbGroup";
		E1AE75B8.Size = new System.Drawing.Size(60, 20);
		E1AE75B8.TabIndex = 0;
		E1AE75B8.Text = "Group";
		E1AE75B8.UseVisualStyleBackColor = true;
		E1AE75B8.Click += new System.EventHandler(BDB33A2A);
		B6AD06B7.AutoSize = true;
		B6AD06B7.Cursor = System.Windows.Forms.Cursors.Hand;
		B6AD06B7.Location = new System.Drawing.Point(4, 30);
		B6AD06B7.Name = "ckbFriend";
		B6AD06B7.Size = new System.Drawing.Size(62, 20);
		B6AD06B7.TabIndex = 0;
		B6AD06B7.Text = "Friend";
		B6AD06B7.UseVisualStyleBackColor = true;
		E027ED0C.AutoSize = true;
		E027ED0C.Cursor = System.Windows.Forms.Cursors.Hand;
		E027ED0C.Location = new System.Drawing.Point(140, 4);
		E027ED0C.Name = "ckbBirthday";
		E027ED0C.Size = new System.Drawing.Size(72, 20);
		E027ED0C.TabIndex = 0;
		E027ED0C.Text = "Birthday";
		E027ED0C.UseVisualStyleBackColor = true;
		C39B4EAB.AutoSize = true;
		C39B4EAB.Cursor = System.Windows.Forms.Cursors.Hand;
		C39B4EAB.Location = new System.Drawing.Point(67, 4);
		C39B4EAB.Name = "ckbGender";
		C39B4EAB.Size = new System.Drawing.Size(72, 20);
		C39B4EAB.TabIndex = 0;
		C39B4EAB.Text = "Giới tính";
		C39B4EAB.UseVisualStyleBackColor = true;
		FF0C5D04.AutoSize = true;
		FF0C5D04.Cursor = System.Windows.Forms.Cursors.Hand;
		FF0C5D04.Location = new System.Drawing.Point(4, 4);
		FF0C5D04.Name = "ckbName";
		FF0C5D04.Size = new System.Drawing.Size(59, 20);
		FF0C5D04.TabIndex = 0;
		FF0C5D04.Text = "Name";
		FF0C5D04.UseVisualStyleBackColor = true;
		B233DF9C.Controls.Add(ckbXoaProfile);
		B233DF9C.Controls.Add(E7B6EC93);
		B233DF9C.Controls.Add(ckbCreateProfile);
		B233DF9C.Controls.Add(ckbCheckLiveUid);
		B233DF9C.Controls.Add(ckbXoaCache);
		B233DF9C.Location = new System.Drawing.Point(11, 44);
		B233DF9C.Name = "groupBox5";
		B233DF9C.Size = new System.Drawing.Size(397, 72);
		B233DF9C.TabIndex = 13;
		B233DF9C.TabStop = false;
		B233DF9C.Text = "Trước khi chạy";
		ckbXoaProfile.AutoSize = true;
		ckbXoaProfile.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbXoaProfile.Location = new System.Drawing.Point(224, 22);
		ckbXoaProfile.Name = "ckbXoaProfile";
		ckbXoaProfile.Size = new System.Drawing.Size(135, 20);
		ckbXoaProfile.TabIndex = 16;
		ckbXoaProfile.Text = "Xoá profile chrome";
		ckbXoaProfile.UseVisualStyleBackColor = true;
		E7B6EC93.AutoSize = true;
		E7B6EC93.Cursor = System.Windows.Forms.Cursors.Hand;
		E7B6EC93.Location = new System.Drawing.Point(224, 46);
		E7B6EC93.Name = "ckbRandomThuTuTaiKhoan";
		E7B6EC93.Size = new System.Drawing.Size(170, 20);
		E7B6EC93.TabIndex = 15;
		E7B6EC93.Text = "Xáo trộn thứ tự tài khoản";
		E7B6EC93.UseVisualStyleBackColor = true;
		ckbCheckLiveUid.AutoSize = true;
		ckbCheckLiveUid.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCheckLiveUid.Location = new System.Drawing.Point(13, 46);
		ckbCheckLiveUid.Name = "ckbCheckLiveUid";
		ckbCheckLiveUid.Size = new System.Drawing.Size(135, 20);
		ckbCheckLiveUid.TabIndex = 2;
		ckbCheckLiveUid.Text = "Check wall account";
		ckbCheckLiveUid.UseVisualStyleBackColor = true;
		ckbXoaCache.AutoSize = true;
		ckbXoaCache.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbXoaCache.Location = new System.Drawing.Point(224, 22);
		ckbXoaCache.Name = "ckbXoaCache";
		ckbXoaCache.Size = new System.Drawing.Size(132, 20);
		ckbXoaCache.TabIndex = 9;
		ckbXoaCache.Text = "Xoá cache chrome";
		ckbXoaCache.UseVisualStyleBackColor = true;
		ckbPublicPost.AutoSize = true;
		ckbPublicPost.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbPublicPost.Location = new System.Drawing.Point(652, 388);
		ckbPublicPost.Name = "ckbPublicPost";
		ckbPublicPost.Size = new System.Drawing.Size(247, 20);
		ckbPublicPost.TabIndex = 0;
		ckbPublicPost.Text = "Đặt chế độ công khai khi đăng bài (ẩn)";
		ckbPublicPost.UseVisualStyleBackColor = true;
		E61D29BD.Controls.Add(button2);
		E61D29BD.Controls.Add(label2);
		E61D29BD.Controls.Add(button1);
		E61D29BD.Controls.Add(AF8E2737);
		E61D29BD.Controls.Add(B5B921A0);
		E61D29BD.Controls.Add(cbbTypeLogin);
		E61D29BD.Controls.Add(ckbDontSaveBrowser);
		E61D29BD.Location = new System.Drawing.Point(11, 122);
		E61D29BD.Name = "grLogin";
		E61D29BD.Size = new System.Drawing.Size(397, 82);
		E61D29BD.TabIndex = 12;
		E61D29BD.TabStop = false;
		E61D29BD.Text = "Đăng nhập";
		button2.BackColor = System.Drawing.Color.White;
		button2.BackgroundImage = (System.Drawing.Image)resources.GetObject("button2.BackgroundImage");
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button2.Location = new System.Drawing.Point(341, 8);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(25, 25);
		button2.TabIndex = 160;
		button2.UseVisualStyleBackColor = false;
		button2.Click += new System.EventHandler(D49ED832);
		button1.BackColor = System.Drawing.Color.White;
		button1.BackgroundImage = (System.Drawing.Image)resources.GetObject("button1.BackgroundImage");
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Location = new System.Drawing.Point(372, 8);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(25, 25);
		button1.TabIndex = 161;
		button1.UseVisualStyleBackColor = false;
		button1.Click += new System.EventHandler(button1_Click);
		AF8E2737.Cursor = System.Windows.Forms.Cursors.Hand;
		AF8E2737.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		AF8E2737.DropDownWidth = 120;
		AF8E2737.FormattingEnabled = true;
		AF8E2737.Items.AddRange(new object[4] { "m.fb", "www", "mbasic", "www->m.fb" });
		AF8E2737.Location = new System.Drawing.Point(118, 51);
		AF8E2737.Name = "cbbFacebookWeb";
		AF8E2737.Size = new System.Drawing.Size(181, 24);
		AF8E2737.TabIndex = 10;
		cbbTypeLogin.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTypeLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTypeLogin.DropDownWidth = 120;
		cbbTypeLogin.FormattingEnabled = true;
		cbbTypeLogin.Items.AddRange(new object[4] { "Uid|Pass", "Email|Pass", "Cookie", "Cookie>Pass" });
		cbbTypeLogin.Location = new System.Drawing.Point(118, 21);
		cbbTypeLogin.Name = "cbbTypeLogin";
		cbbTypeLogin.Size = new System.Drawing.Size(181, 24);
		cbbTypeLogin.TabIndex = 10;
		ckbDontSaveBrowser.AutoSize = true;
		ckbDontSaveBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbDontSaveBrowser.Location = new System.Drawing.Point(12, 81);
		ckbDontSaveBrowser.Name = "ckbDontSaveBrowser";
		ckbDontSaveBrowser.Size = new System.Drawing.Size(244, 20);
		ckbDontSaveBrowser.TabIndex = 2;
		ckbDontSaveBrowser.Text = "Không lưu trình duyệt khi facebook hỏi";
		ckbDontSaveBrowser.UseVisualStyleBackColor = true;
		ckbPrivateInfo.AutoSize = true;
		ckbPrivateInfo.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbPrivateInfo.Location = new System.Drawing.Point(652, 365);
		ckbPrivateInfo.Name = "ckbPrivateInfo";
		ckbPrivateInfo.Size = new System.Drawing.Size(149, 20);
		ckbPrivateInfo.TabIndex = 2;
		ckbPrivateInfo.Text = "Â\u0309n thông tin nick (ẩn)";
		ckbPrivateInfo.UseVisualStyleBackColor = true;
		ckbDisableChatSettings.AutoSize = true;
		ckbDisableChatSettings.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbDisableChatSettings.Location = new System.Drawing.Point(512, 365);
		ckbDisableChatSettings.Name = "ckbDisableChatSettings";
		ckbDisableChatSettings.Size = new System.Drawing.Size(140, 20);
		ckbDisableChatSettings.TabIndex = 2;
		ckbDisableChatSettings.Text = "Tắt Popup chat (ẩn)";
		ckbDisableChatSettings.UseVisualStyleBackColor = true;
		ckbCheckBanBeGoiY.AutoSize = true;
		ckbCheckBanBeGoiY.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCheckBanBeGoiY.Location = new System.Drawing.Point(1028, 643);
		ckbCheckBanBeGoiY.Name = "ckbCheckBanBeGoiY";
		ckbCheckBanBeGoiY.Size = new System.Drawing.Size(134, 20);
		ckbCheckBanBeGoiY.TabIndex = 9;
		ckbCheckBanBeGoiY.Text = "Check bạn bè gợi ý";
		ckbCheckBanBeGoiY.UseVisualStyleBackColor = true;
		ckbCheckBanBeGoiY.Visible = false;
		CE8D0D3E.AutoSize = true;
		CE8D0D3E.Cursor = System.Windows.Forms.Cursors.Hand;
		CE8D0D3E.Location = new System.Drawing.Point(1028, 614);
		CE8D0D3E.Name = "ckbBatThongBaoDangNhap";
		CE8D0D3E.Size = new System.Drawing.Size(169, 20);
		CE8D0D3E.TabIndex = 7;
		CE8D0D3E.Text = "Bật thông báo đăng nhập";
		CE8D0D3E.UseVisualStyleBackColor = true;
		CE8D0D3E.Visible = false;
		groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		groupBox2.Controls.Add(B32C0B00);
		groupBox2.Controls.Add(ckbChayKichBanDaGan);
		groupBox2.Controls.Add(btnDown);
		groupBox2.Controls.Add(btnUp);
		groupBox2.Controls.Add(plGioiHanThoiGianChayKichBan);
		groupBox2.Controls.Add(plRepeatAll);
		groupBox2.Controls.Add(AC08580E);
		groupBox2.Controls.Add(ckbGioiHanThoiGianChayKichBan);
		groupBox2.Controls.Add(ckbRepeatAll);
		groupBox2.Controls.Add(ckbGioiHanThoiGianChayTaiKhoan);
		groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		groupBox2.Location = new System.Drawing.Point(11, 210);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new System.Drawing.Size(397, 152);
		groupBox2.TabIndex = 7;
		groupBox2.TabStop = false;
		groupBox2.Text = "Tương tác";
		B32C0B00.Controls.Add(B3A4F02E);
		B32C0B00.Controls.Add(BB36B0B4);
		B32C0B00.Controls.Add(btnQuanLyKichBan);
		B32C0B00.Location = new System.Drawing.Point(7, 41);
		B32C0B00.Name = "plChonKichBan";
		B32C0B00.Size = new System.Drawing.Size(387, 26);
		B32C0B00.TabIndex = 14;
		B3A4F02E.AutoSize = true;
		B3A4F02E.Location = new System.Drawing.Point(3, 4);
		B3A4F02E.Name = "label1";
		B3A4F02E.Size = new System.Drawing.Size(92, 16);
		B3A4F02E.TabIndex = 0;
		B3A4F02E.Text = "Chọn kịch bản:";
		BB36B0B4.Cursor = System.Windows.Forms.Cursors.Hand;
		BB36B0B4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		BB36B0B4.DropDownWidth = 300;
		BB36B0B4.FormattingEnabled = true;
		BB36B0B4.Location = new System.Drawing.Point(102, 1);
		BB36B0B4.Name = "cbbKichBan";
		BB36B0B4.Size = new System.Drawing.Size(164, 24);
		BB36B0B4.TabIndex = 1;
		btnQuanLyKichBan.Cursor = System.Windows.Forms.Cursors.Hand;
		btnQuanLyKichBan.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnQuanLyKichBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnQuanLyKichBan.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnQuanLyKichBan.Location = new System.Drawing.Point(272, 1);
		btnQuanLyKichBan.Name = "btnQuanLyKichBan";
		btnQuanLyKichBan.Size = new System.Drawing.Size(112, 24);
		btnQuanLyKichBan.TabIndex = 1;
		btnQuanLyKichBan.Text = "Quản lý kịch bản";
		btnQuanLyKichBan.Click += new System.EventHandler(btnQuanLyKichBan_Click);
		ckbChayKichBanDaGan.AutoSize = true;
		ckbChayKichBanDaGan.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbChayKichBanDaGan.Location = new System.Drawing.Point(12, 17);
		ckbChayKichBanDaGan.Name = "ckbChayKichBanDaGan";
		ckbChayKichBanDaGan.Size = new System.Drawing.Size(234, 20);
		ckbChayKichBanDaGan.TabIndex = 162;
		ckbChayKichBanDaGan.Text = "Chạy kịch bản đã gán từng tài khoản";
		ckbChayKichBanDaGan.UseVisualStyleBackColor = true;
		ckbChayKichBanDaGan.Visible = false;
		ckbChayKichBanDaGan.CheckedChanged += new System.EventHandler(CE89063E);
		btnDown.BackColor = System.Drawing.Color.White;
		btnDown.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnDown.BackgroundImage");
		btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnDown.Location = new System.Drawing.Point(341, 8);
		btnDown.Name = "btnDown";
		btnDown.Size = new System.Drawing.Size(25, 25);
		btnDown.TabIndex = 160;
		btnDown.UseVisualStyleBackColor = false;
		btnDown.Click += new System.EventHandler(btnDown_Click);
		btnUp.BackColor = System.Drawing.Color.White;
		btnUp.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnUp.BackgroundImage");
		btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnUp.Location = new System.Drawing.Point(372, 8);
		btnUp.Name = "btnUp";
		btnUp.Size = new System.Drawing.Size(25, 25);
		btnUp.TabIndex = 161;
		btnUp.UseVisualStyleBackColor = false;
		btnUp.Click += new System.EventHandler(btnUp_Click);
		plGioiHanThoiGianChayKichBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plGioiHanThoiGianChayKichBan.Controls.Add(label7);
		plGioiHanThoiGianChayKichBan.Controls.Add(nudThoiGianChayKichBanTo);
		plGioiHanThoiGianChayKichBan.Controls.Add(nudThoiGianChayKichBanFrom);
		plGioiHanThoiGianChayKichBan.Location = new System.Drawing.Point(269, 118);
		plGioiHanThoiGianChayKichBan.Name = "plGioiHanThoiGianChayKichBan";
		plGioiHanThoiGianChayKichBan.Size = new System.Drawing.Size(121, 27);
		plGioiHanThoiGianChayKichBan.TabIndex = 17;
		label7.AutoSize = true;
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label7.Location = new System.Drawing.Point(50, 4);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(18, 16);
		label7.TabIndex = 4;
		label7.Text = ">";
		nudThoiGianChayKichBanTo.Location = new System.Drawing.Point(69, 1);
		nudThoiGianChayKichBanTo.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		nudThoiGianChayKichBanTo.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		nudThoiGianChayKichBanTo.Name = "nudThoiGianChayKichBanTo";
		nudThoiGianChayKichBanTo.Size = new System.Drawing.Size(48, 23);
		nudThoiGianChayKichBanTo.TabIndex = 3;
		nudThoiGianChayKichBanTo.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		nudThoiGianChayKichBanFrom.Location = new System.Drawing.Point(1, 1);
		nudThoiGianChayKichBanFrom.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		nudThoiGianChayKichBanFrom.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		nudThoiGianChayKichBanFrom.Name = "nudThoiGianChayKichBanFrom";
		nudThoiGianChayKichBanFrom.Size = new System.Drawing.Size(48, 23);
		nudThoiGianChayKichBanFrom.TabIndex = 3;
		nudThoiGianChayKichBanFrom.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		plRepeatAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plRepeatAll.Controls.Add(label6);
		plRepeatAll.Controls.Add(label4);
		plRepeatAll.Controls.Add(nudDelayTurnFrom);
		plRepeatAll.Controls.Add(A1A5B418);
		plRepeatAll.Controls.Add(nudDelayTurnTo);
		plRepeatAll.Controls.Add(label11);
		plRepeatAll.Controls.Add(nudSoLuotChay);
		plRepeatAll.Controls.Add(label10);
		plRepeatAll.Location = new System.Drawing.Point(32, 173);
		plRepeatAll.Name = "plRepeatAll";
		plRepeatAll.Size = new System.Drawing.Size(358, 64);
		plRepeatAll.TabIndex = 13;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(3, 8);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(83, 16);
		label6.TabIndex = 5;
		label6.Text = "Sô\u0301 lươ\u0323t cha\u0323y:";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(3, 36);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(144, 16);
		label4.TabIndex = 6;
		label4.Text = "Chờ cha\u0323y lươ\u0323t tiê\u0301p theo:";
		nudDelayTurnFrom.Location = new System.Drawing.Point(154, 34);
		nudDelayTurnFrom.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		nudDelayTurnFrom.Name = "nudDelayTurnFrom";
		nudDelayTurnFrom.Size = new System.Drawing.Size(65, 23);
		nudDelayTurnFrom.TabIndex = 9;
		A1A5B418.Location = new System.Drawing.Point(222, 9);
		A1A5B418.Name = "label5";
		A1A5B418.Size = new System.Drawing.Size(30, 16);
		A1A5B418.TabIndex = 10;
		A1A5B418.Text = "lươ\u0323t";
		A1A5B418.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		A1A5B418.Click += new System.EventHandler(A1A5B418_Click);
		nudDelayTurnTo.Location = new System.Drawing.Point(244, 34);
		nudDelayTurnTo.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		nudDelayTurnTo.Name = "nudDelayTurnTo";
		nudDelayTurnTo.Size = new System.Drawing.Size(65, 23);
		nudDelayTurnTo.TabIndex = 8;
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(310, 37);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(32, 16);
		label11.TabIndex = 11;
		label11.Text = "phút";
		nudSoLuotChay.Location = new System.Drawing.Point(154, 6);
		nudSoLuotChay.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		nudSoLuotChay.Minimum = new decimal(new int[4] { 2, 0, 0, 0 });
		nudSoLuotChay.Name = "nudSoLuotChay";
		nudSoLuotChay.Size = new System.Drawing.Size(65, 23);
		nudSoLuotChay.TabIndex = 7;
		nudSoLuotChay.Value = new decimal(new int[4] { 2, 0, 0, 0 });
		label10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label10.Location = new System.Drawing.Point(219, 37);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(24, 16);
		label10.TabIndex = 12;
		label10.Text = ">";
		label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		AC08580E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		AC08580E.Controls.Add(label13);
		AC08580E.Controls.Add(ACBBC09F);
		AC08580E.Controls.Add(EE0314B2);
		AC08580E.Location = new System.Drawing.Point(269, 82);
		AC08580E.Name = "plGioiHanThoiGianChayTaiKhoan";
		AC08580E.Size = new System.Drawing.Size(121, 27);
		AC08580E.TabIndex = 18;
		label13.AutoSize = true;
		label13.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label13.Location = new System.Drawing.Point(50, 4);
		label13.Name = "label13";
		label13.Size = new System.Drawing.Size(18, 16);
		label13.TabIndex = 4;
		label13.Text = ">";
		ACBBC09F.Location = new System.Drawing.Point(69, 1);
		ACBBC09F.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		ACBBC09F.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		ACBBC09F.Name = "nudThoiGianChayTaiKhoanTo";
		ACBBC09F.Size = new System.Drawing.Size(48, 23);
		ACBBC09F.TabIndex = 3;
		ACBBC09F.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		EE0314B2.Location = new System.Drawing.Point(1, 1);
		EE0314B2.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		EE0314B2.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		EE0314B2.Name = "nudThoiGianChayTaiKhoanFrom";
		EE0314B2.Size = new System.Drawing.Size(48, 23);
		EE0314B2.TabIndex = 3;
		EE0314B2.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		ckbGioiHanThoiGianChayKichBan.AutoSize = true;
		ckbGioiHanThoiGianChayKichBan.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbGioiHanThoiGianChayKichBan.Location = new System.Drawing.Point(12, 122);
		ckbGioiHanThoiGianChayKichBan.Name = "ckbGioiHanThoiGianChayKichBan";
		ckbGioiHanThoiGianChayKichBan.Size = new System.Drawing.Size(246, 20);
		ckbGioiHanThoiGianChayKichBan.TabIndex = 15;
		ckbGioiHanThoiGianChayKichBan.Text = "Giới hạn thời gian chạy/kịch bản (phút)";
		ckbGioiHanThoiGianChayKichBan.UseVisualStyleBackColor = true;
		ckbGioiHanThoiGianChayKichBan.CheckedChanged += new System.EventHandler(ckbGioiHanThoiGianChayKichBan_CheckedChanged);
		ckbRepeatAll.AutoSize = true;
		ckbRepeatAll.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbRepeatAll.Location = new System.Drawing.Point(12, 151);
		ckbRepeatAll.Name = "ckbRepeatAll";
		ckbRepeatAll.Size = new System.Drawing.Size(344, 20);
		ckbRepeatAll.TabIndex = 2;
		ckbRepeatAll.Text = "Chạy tương tác lại toàn bộ tài khoản sau khi hoàn thành";
		ckbRepeatAll.UseVisualStyleBackColor = true;
		ckbRepeatAll.CheckedChanged += new System.EventHandler(ckbRepeatAll_CheckedChanged);
		ckbGioiHanThoiGianChayTaiKhoan.AutoSize = true;
		ckbGioiHanThoiGianChayTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbGioiHanThoiGianChayTaiKhoan.Location = new System.Drawing.Point(12, 85);
		ckbGioiHanThoiGianChayTaiKhoan.Name = "ckbGioiHanThoiGianChayTaiKhoan";
		ckbGioiHanThoiGianChayTaiKhoan.Size = new System.Drawing.Size(249, 20);
		ckbGioiHanThoiGianChayTaiKhoan.TabIndex = 16;
		ckbGioiHanThoiGianChayTaiKhoan.Text = "Giới hạn thời gian chạy/tài khoản (giây)";
		ckbGioiHanThoiGianChayTaiKhoan.UseVisualStyleBackColor = true;
		ckbGioiHanThoiGianChayTaiKhoan.CheckedChanged += new System.EventHandler(ckbGioiHanThoiGianChayTaiKhoan_CheckedChanged);
		AA33BD3F.AutoSize = true;
		AA33BD3F.Cursor = System.Windows.Forms.Cursors.Hand;
		AA33BD3F.Location = new System.Drawing.Point(4, 56);
		AA33BD3F.Name = "ckbPagePro5";
		AA33BD3F.Size = new System.Drawing.Size(54, 20);
		AA33BD3F.TabIndex = 1;
		AA33BD3F.Text = "Page";
		AA33BD3F.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(820, 416);
		base.Controls.Add(C5B92C1C);
		base.Controls.Add(C508A7A1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhTuongTac";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(C735CA95);
		C5B92C1C.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		C508A7A1.ResumeLayout(false);
		C508A7A1.PerformLayout();
		C1B8F897.ResumeLayout(false);
		C1B8F897.PerformLayout();
		C12477A5.ResumeLayout(false);
		C12477A5.PerformLayout();
		B233DF9C.ResumeLayout(false);
		B233DF9C.PerformLayout();
		E61D29BD.ResumeLayout(false);
		E61D29BD.PerformLayout();
		groupBox2.ResumeLayout(false);
		groupBox2.PerformLayout();
		B32C0B00.ResumeLayout(false);
		B32C0B00.PerformLayout();
		plGioiHanThoiGianChayKichBan.ResumeLayout(false);
		plGioiHanThoiGianChayKichBan.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudThoiGianChayKichBanTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudThoiGianChayKichBanFrom).EndInit();
		plRepeatAll.ResumeLayout(false);
		plRepeatAll.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTurnFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTurnTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuotChay).EndInit();
		AC08580E.ResumeLayout(false);
		AC08580E.PerformLayout();
		((System.ComponentModel.ISupportInitialize)ACBBC09F).EndInit();
		((System.ComponentModel.ISupportInitialize)EE0314B2).EndInit();
		ResumeLayout(false);
	}
}
