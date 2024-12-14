using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fDanhSachKichBan_Old : Form
{
	private string string_0 = "";

	private IContainer E204CD2D = null;

	private ToolTip toolTip_0;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private GroupBox groupBox1;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private PictureBox pictureBox1;

	private BunifuCustomLabel F4362BA7;

	private Button button1;

	private GroupBox groupBox2;

	public DataGridView BF02BD30;

	public DataGridView dtgvHanhDong;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem toolStripMenuItem_3;

	private ContextMenuStrip contextMenuStrip1_1;

	private ToolStripMenuItem toolStripMenuItem1;

	private ToolStripMenuItem toolStripMenuItem3;

	private ToolStripMenuItem CC35B995;

	private ToolStripMenuItem toolStripMenuItem2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	private DataGridViewTextBoxColumn cId_HanhDong;

	private DataGridViewTextBoxColumn cTenHanhDong;

	private DataGridViewTextBoxColumn DBB4BCB7;

	private Panel panel1;

	private DataGridViewTextBoxColumn BDAADD98;

	private DataGridViewTextBoxColumn cId_KichBan;

	private DataGridViewTextBoxColumn cTenKichBan;

	private SplitContainer splitContainer1;

	private GroupBox groupBox3;

	private Label label1;

	private Panel plCountAction;

	private NumericUpDown nudCountActionTo;

	private NumericUpDown DD35D092;

	private Label label2;

	private Button E286198C;

	private Button button7;

	private Button button6;

	private Button DA13D69F;

	private Button button4;

	private Button btnQuanLyKichBan;

	private Button button9;

	private Button button10;

	private Button button11;

	private Button C4BB98AD;

	private Button DC109C00;

	private Button button14;

	private ComboBox cbbCountAction;

	private Label C5A66E3C;

	private CheckBox B9AD5524;

	private Button btnSave;

	public fDanhSachKichBan_Old(string string_1)
	{
		AF88A73B();
		F7AB102E.D6B70A35(this);
		F7AB102E.smethod_4(contextMenuStrip1);
		F7AB102E.smethod_4(contextMenuStrip1_1);
		string_0 = string_1;
	}

	private void fDanhSachKichBan_Old_Load(object sender, EventArgs e)
	{
		method_9();
		E8873719(string_0);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		method_6();
	}

	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		CDB800BC();
	}

	private void CC35B995_Click(object sender, EventArgs e)
	{
		BF816E89();
	}

	public void method_0(ref DataGridView dataGridView_0, int A28969BB, int int_0)
	{
		string text = "";
		for (int i = 1; i < dataGridView_0.Columns.Count; i++)
		{
			text = GClass27.smethod_2(dataGridView_0, A28969BB, i);
			GClass27.smethod_4(dataGridView_0, A28969BB, i, GClass27.smethod_2(dataGridView_0, int_0, i));
			GClass27.smethod_4(dataGridView_0, int_0, i, text);
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		int index = dtgvHanhDong.SelectedRows[0].Index;
		if (index == 0)
		{
			return;
		}
		string text = GClass27.smethod_3(dtgvHanhDong, index - 1, "cId_HanhDong");
		string text2 = GClass27.smethod_3(dtgvHanhDong, index, "cId_HanhDong");
		if (text + text2 != "")
		{
			if (Class147.smethod_14(text, text2))
			{
				method_0(ref dtgvHanhDong, index, index - 1);
				dtgvHanhDong.Rows[index - 1].Selected = true;
			}
			else
			{
				GClass29.smethod_0("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		int index = dtgvHanhDong.SelectedRows[0].Index;
		if (index == dtgvHanhDong.RowCount - 1)
		{
			return;
		}
		string text = GClass27.smethod_3(dtgvHanhDong, index + 1, "cId_HanhDong");
		string text2 = GClass27.smethod_3(dtgvHanhDong, index, "cId_HanhDong");
		if (text + text2 != "")
		{
			if (Class147.smethod_14(text, text2))
			{
				method_0(ref dtgvHanhDong, index, index + 1);
				dtgvHanhDong.Rows[index + 1].Selected = true;
			}
			else
			{
				GClass29.smethod_0("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		method_7();
	}

	private void DFA000A1(object sender, EventArgs e)
	{
		method_4();
	}

	private void toolStripMenuItem_3_Click(object sender, EventArgs e)
	{
		method_8();
	}

	private void BF02BD30_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex > -1)
		{
			method_3();
		}
	}

	private void toolStripMenuItem3_Click(object sender, EventArgs e)
	{
		method_5();
	}

	private void DBB6E72C(object sender, EventArgs e)
	{
		B306CF0B();
	}

	private void dtgvHanhDong_KeyDown(object sender, KeyEventArgs e)
	{
		switch (e.KeyCode)
		{
		case Keys.Delete:
			BF816E89();
			break;
		case Keys.Insert:
		case Keys.F1:
			method_4();
			break;
		case Keys.F2:
			method_5();
			break;
		case Keys.F5:
			method_3();
			break;
		case Keys.D:
			if (e.Modifiers == Keys.Control)
			{
				B306CF0B();
			}
			break;
		}
	}

	private void B306CF0B()
	{
		try
		{
			if (dtgvHanhDong.RowCount == 0)
			{
				GClass29.smethod_0("Vui lòng thêm hành động trước!", 3);
				return;
			}
			DataGridViewRow dataGridViewRow = dtgvHanhDong.SelectedRows[0];
			string text = dataGridViewRow.Cells["cId_HanhDong"].Value.ToString();
			string text2 = dataGridViewRow.Cells["cTenHanhDong"].Value.ToString();
			string text3 = text2 + " - Copy";
			int num = 2;
			while (Class147.smethod_11(text3))
			{
				text3 = text2 + $" - Copy ({num++})";
			}
			if (Class147.B7065637(text, text3))
			{
				DataTable dataTable = Class147.smethod_10();
				dtgvHanhDong.Rows.Add(dtgvHanhDong.RowCount + 1, dataTable.Rows[0]["Id_HanhDong"], dataTable.Rows[0]["TenHanhDong"], dataTable.Rows[0]["MoTa"]);
			}
			else
			{
				GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
		catch
		{
		}
	}

	private void method_3()
	{
		try
		{
			dtgvHanhDong.Rows.Clear();
			if (BF02BD30.RowCount != 0)
			{
				DataGridViewRow dataGridViewRow = BF02BD30.SelectedRows[0];
				string text = dataGridViewRow.Cells["cId_KichBan"].Value.ToString();
				DataTable dataTable = Class147.smethod_9(text);
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					dtgvHanhDong.Rows.Add(dtgvHanhDong.RowCount + 1, dataTable.Rows[i]["Id_HanhDong"], dataTable.Rows[i]["TenHanhDong"], dataTable.Rows[i]["MoTa"]);
				}
				string string_ = Class147.C594AD33(text);
				GClass11 gClass = new GClass11(string_, bool_0: true);
				cbbCountAction.SelectedIndex = gClass.method_2("cbbCountAction");
				DD35D092.Value = gClass.method_2("nudCountActionFrom", 1);
				nudCountActionTo.Value = gClass.method_2("nudCountActionTo", 1);
				B9AD5524.Checked = gClass.method_3("ckbRandomAction");
				D92BDF1F(null, null);
			}
		}
		catch
		{
		}
	}

	private void BF816E89()
	{
		try
		{
			if (dtgvHanhDong.RowCount == 0)
			{
				GClass29.smethod_0("Vui lòng thêm hành động trước!", 3);
			}
			else
			{
				if (GClass29.smethod_1("Bạn có chắc muốn xóa hoạt động này?") != DialogResult.Yes)
				{
					return;
				}
				DataGridViewRow dataGridViewRow = dtgvHanhDong.SelectedRows[0];
				if (Class147.B5BAE58E(dataGridViewRow.Cells["cId_HanhDong"].Value.ToString()))
				{
					int index = dataGridViewRow.Index;
					for (int i = index; i < dtgvHanhDong.Rows.Count - 1; i++)
					{
						method_0(ref dtgvHanhDong, i, i + 1);
					}
					dtgvHanhDong.Rows.RemoveAt(dtgvHanhDong.Rows.Count - 1);
				}
				else
				{
					GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
				}
				return;
			}
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA);
			GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
		}
	}

	private void method_4()
	{
		try
		{
			if (BF02BD30.RowCount == 0)
			{
				GClass29.smethod_0("Vui lòng thêm kịch bản trước!", 3);
				return;
			}
			DataGridViewRow dataGridViewRow = BF02BD30.SelectedRows[0];
			string text = dataGridViewRow.Cells["cId_KichBan"].Value.ToString();
			int count = Class147.smethod_9(text).Rows.Count;
			GClass8.smethod_33(new fThemHanhDong(text));
			DataTable dataTable = Class147.smethod_9(text);
			int count2 = dataTable.Rows.Count;
			if (count2 > count)
			{
				dtgvHanhDong.Rows.Add(dtgvHanhDong.RowCount + 1, dataTable.Rows[count2 - 1]["Id_HanhDong"], dataTable.Rows[count2 - 1]["TenHanhDong"], dataTable.Rows[count2 - 1]["MoTa"]);
			}
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA);
			GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
		}
	}

	private void method_5()
	{
		try
		{
			if (dtgvHanhDong.RowCount == 0)
			{
				GClass29.smethod_0("Vui lòng thêm hành động trước!", 3);
				return;
			}
			DataGridViewRow dataGridViewRow = dtgvHanhDong.SelectedRows[0];
			string text = dataGridViewRow.Cells["cId_HanhDong"].Value.ToString();
			DataTable dataTable = Class147.F3057616(text);
			Form form = null;
			string text2 = dataTable.Rows[0]["TenTuongTac"].ToString();
			string text3 = text2;
			string text4 = text3;
			switch (C43AF739.smethod_0(text4))
			{
			case 111113161u:
				if (text4 == "HDDoiNgonNgu")
				{
					form = new BABC2880("", 1, text);
				}
				break;
			case 80860474u:
				if (text4 == "HDUnlockProfile")
				{
					form = new BA26EC99("", 1, text);
				}
				break;
			case 170588456u:
				if (text4 == "HDShareBai")
				{
					form = new C3079B9D("", 1, text);
				}
				break;
			case 167896116u:
				if (text4 == "HDTuongTacBaiVietTuKhoa")
				{
					form = new fHDTuongTacBaiVietTuKhoa("", 1, text);
				}
				break;
			case 152310871u:
				if (text4 == "HDUpCover")
				{
					form = new FB245815("", 1, text);
				}
				break;
			case 311671696u:
				if (text4 == "HDKetBanGoiY")
				{
					form = new F78F2213("", 1, text);
				}
				break;
			case 271171672u:
				if (text4 == "HDTruyCapWebsite")
				{
					form = new fHDTruyCapWebsite("", 1, text);
				}
				break;
			case 532292684u:
				if (text4 == "HDBuffLikeComment")
				{
					form = new fHDBuffLikeComment("", 1, text);
				}
				break;
			case 516966741u:
				if (text4 == "HDDangReel")
				{
					form = new fHDDangReel("", 1, text);
				}
				break;
			case 327820411u:
				if (text4 == "HDBuffTinNhanProfile")
				{
					form = new fHDBuffTinNhanProfile("", 1, text);
				}
				break;
			case 614517095u:
				if (text4 == "HDReport")
				{
					form = new fHDReport("", 1, text);
				}
				break;
			case 582938346u:
				if (text4 == "HDXemStory")
				{
					form = new fHDXemStory("", 1, text);
				}
				break;
			case 935513960u:
				if (text4 == "HDMoiLikePage")
				{
					form = new D282E117("", 1, text);
				}
				break;
			case 852508141u:
				if (text4 == "HDKetBanTepUid")
				{
					form = new fHDKetBanTepUid("", 1, text);
				}
				break;
			case 786238800u:
				if (text4 == "HDXemWatch")
				{
					form = new fHDXemWatch("", 1, text);
				}
				break;
			case 1340375996u:
				if (text4 == "HDBatCheDoChuyenNghiep")
				{
					form = new A3202D8D("", 1, text);
				}
				break;
			case 1005065709u:
				if (text4 == "HDLoginMail")
				{
					form = new fHDLoginMail("", 1, text);
				}
				break;
			case 1470935067u:
				if (text4 == "HDDangStatus")
				{
					form = new fHDDangStatus("", 1, text);
				}
				break;
			case 1467610808u:
				if (text4 == "HDLinkToInstagram")
				{
					form = new AE162A09("", 1, text);
				}
				break;
			case 1411668073u:
				if (text4 == "HDChangeSoThich")
				{
					form = new fHDChangeSoThich("", 1, text);
				}
				break;
			case 1591506910u:
				if (text4 == "HDTuongTacNhomv2")
				{
					form = new fHDTuongTacNhomv2("", 1, text);
				}
				break;
			case 1529746060u:
				if (text4 == "HDReportPage")
				{
					form = new fHDReportPage("", 1, text);
				}
				break;
			case 1697418988u:
				if (text4 == "HDTimKiemGoogle")
				{
					form = new AF9E4E34("", 1, text);
				}
				break;
			case 1653385921u:
				if (text4 == "HDNghiGiaiLao")
				{
					form = new A1276B03("", 1, text);
				}
				break;
			case 1640113110u:
				if (text4 == "HDKetBanVoiBanCuaBanBe")
				{
					form = new fHDKetBanVoiBanCuaBanBe("", 1, text);
				}
				break;
			case 1742384383u:
				if (text4 == "HDChangeTenPhu")
				{
					form = new fHDChangeTenPhu("", 1, text);
				}
				break;
			case 1723758688u:
				if (text4 == "HDXoaBaiTuong")
				{
					form = new B5B56C91("", 1, text);
				}
				break;
			case 1906272025u:
				if (text4 == "HDKetBanVoiBanBeCuaUid")
				{
					form = new fHDKetBanVoiBanBeCuaUid("", 1, text);
				}
				break;
			case 1884305945u:
				if (text4 == "HDDocThongBao")
				{
					form = new fHDDocThongBao("", 1, text);
				}
				break;
			case 1823818229u:
				if (text4 == "HDUpAvatar")
				{
					form = new C5214BA0("", 1, text);
				}
				break;
			case 1984335833u:
				if (text4 == "HDBaiVietBanBe")
				{
					form = new A52F8229("", 1, text);
				}
				break;
			case 1952866892u:
				if (text4 == "HDKetBanTheoTuKhoa")
				{
					form = new D82E829C("", 1, text);
				}
				break;
			case 2030328732u:
				if (text4 == "HDOnOff2FA")
				{
					form = new EF90CFAC("", 1, text);
				}
				break;
			case 2004466602u:
				if (text4 == "HDDoiTen")
				{
					form = new fHDDoiTen("", 1, text);
				}
				break;
			case 1999692336u:
				if (text4 == "HDVerify")
				{
					form = new B2312C9C("", 1, text);
				}
				break;
			case 2081285240u:
				if (text4 == "HDChocBanBe")
				{
					form = new fHDChocBanBe("", 1, text);
				}
				break;
			case 2079252553u:
				if (text4 == "HDPhanHoiBinhLuan")
				{
					form = new EB3B3C1A("", 1, text);
				}
				break;
			case 2065195933u:
				if (text4 == "HDBuffFollowLikePage")
				{
					form = new fHDBuffFollowLikePage("", 1, text);
				}
				break;
			case 2255824322u:
				if (text4 == "HDXoaNhatKyHoatDong")
				{
					form = new fHDXoaNhatKyHoatDong("", 1, text);
				}
				break;
			case 2230339588u:
				if (text4 == "HDBuffFollowCaNhan")
				{
					form = new D0129A91("", 1, text);
				}
				break;
			case 2117563667u:
				if (text4 == "HDKhangSpam")
				{
					form = new fHDKhangSpam("", 1, text);
				}
				break;
			case 2416405417u:
				if (text4 == "HDHuyLikePage")
				{
					form = new fHDHuyLikePage("", 1, text);
				}
				break;
			case 2277183375u:
				if (text4 == "HDRoiNhom")
				{
					form = new fHDRoiNhom("", 1, text);
				}
				break;
			case 2483578584u:
				if (text4 == "HDBuffViewVideo")
				{
					form = new CB1D4BA7("", 1, text);
				}
				break;
			case 2433475627u:
				if (text4 == "HDChaySeeding")
				{
					form = new fHDChaySeeding("", 1, text);
				}
				break;
			case 2421286761u:
				if (text4 == "HDBaiVietNhom")
				{
					form = new fHDBaiVietNhom("", 1, text);
				}
				break;
			case 2553440797u:
				if (text4 == "HDCapNhatThongTin")
				{
					form = new CAB700BC("", 1, text);
				}
				break;
			case 2540878680u:
				if (text4 == "HDThamGiaNhomTuKhoa")
				{
					form = new BD963B00("", 1, text);
				}
				break;
			case 2703861858u:
				if (text4 == "HDChucMungSinhNhat")
				{
					form = new fHDChucMungSinhNhat("", 1, text);
				}
				break;
			case 2680847194u:
				if (text4 == "HDScriptGemLogin")
				{
					form = new fHDScriptGemLogin("", 1, text);
				}
				break;
			case 2653710823u:
				if (text4 == "HDSharePage")
				{
					form = new fHDSharePage("", 1, text);
				}
				break;
			case 2837141903u:
				if (text4 == "HDBaiVietFanpage")
				{
					form = new AD243E2E("", 1, text);
				}
				break;
			case 2821037716u:
				if (text4 == "HDHuyKetBan")
				{
					form = new E9397B88("", 1, text);
				}
				break;
			case 2924758840u:
				if (text4 == "HDMoiBanBeVaoNhom")
				{
					form = new fHDMoiBanBeVaoNhom("", 1, text);
				}
				break;
			case 2922412940u:
				if (text4 == "HDTaoPage")
				{
					form = new C69E6685("", 1, text);
				}
				break;
			case 2837258301u:
				if (text4 == "HDKichHoatPageVhh")
				{
					form = new fHDKichHoatPageVhh("", 1, text);
				}
				break;
			case 3169819074u:
				if (text4 == "HDCongKhaiBaiVietGanThe")
				{
					form = new fHDCongKhaiBaiVietGanThe("", 1, text);
				}
				break;
			case 3099572506u:
				if (text4 == "HDDangXuatThietBiCu")
				{
					form = new fHDDangXuatThietBiCu("", 1, text);
				}
				break;
			case 2944435598u:
				if (text4 == "HDThamGiaNhomUid")
				{
					form = new B7360A13("", 1, text);
				}
				break;
			case 3375859832u:
				if (text4 == "HDDanhGiaPage")
				{
					form = new fHDDanhGiaPage("", 1, text);
				}
				break;
			case 3372854657u:
				if (text4 == "HDGiaiCheckpoint")
				{
					form = new fHDGiaiCheckpoint("", 1, text);
				}
				break;
			case 3255732838u:
				if (text4 == "HDDoiMatKhau")
				{
					form = new fHDDoiMatKhau("", 1, text);
				}
				break;
			case 3598280146u:
				if (text4 == "HDKetBanNewfeed")
				{
					form = new fHDKetBanNewfeed("", 1, text);
				}
				break;
			case 3427768725u:
				if (text4 == "HDBaiVietTrenTuong")
				{
					form = new FDAEA09A("", 1, text);
				}
				break;
			case 3671364376u:
				if (text4 == "HDThamGiaNhomGoiY")
				{
					form = new B0835B0A("", 1, text);
				}
				break;
			case 3656368709u:
				if (text4 == "HDUptopBaiViet")
				{
					form = new A38C25A7("", 1, text);
				}
				break;
			case 3609367991u:
				if (text4 == "HDAddMail")
				{
					form = new DA0D4B0D("", 1, text);
				}
				break;
			case 3732058847u:
				if (text4 == "HDDangStatusV2")
				{
					form = new fHDDangStatusV2("", 1, text);
				}
				break;
			case 3677432718u:
				if (text4 == "HDDangStory")
				{
					form = new fHDDangStory("", 1, text);
				}
				break;
			case 3870903183u:
				if (text4 == "HDKetBanVip")
				{
					form = new fHDKetBanVip("", 1, text);
				}
				break;
			case 3850864715u:
				if (text4 == "HDDangBai")
				{
					form = new fHDDangBai("", 1, text);
				}
				break;
			case 3742679556u:
				if (text4 == "HDBaiVietNewsfeed")
				{
					form = new F49201A9("", 1, text);
				}
				break;
			case 3917587807u:
				if (text4 == "HDHuyLoiMoiKetBan")
				{
					form = new fHDHuyLoiMoiKetBan("", 1, text);
				}
				break;
			case 3877387086u:
				if (text4 == "HDTuongTacLivestream")
				{
					form = new DBA4A1B0("", 1, text);
				}
				break;
			case 4062736188u:
				if (text4 == "HDXoaSdt")
				{
					form = new fHDXoaSdt("", 1, text);
				}
				break;
			case 4054725761u:
				if (text4 == "HDXemStoryChiDinh")
				{
					form = new AA365D0E("", 1, text);
				}
				break;
			case 3921961843u:
				if (text4 == "HDXoaTinNhan")
				{
					form = new fHDXoaTinNhan("", 1, text);
				}
				break;
			case 4167715081u:
				if (text4 == "HDHuyLienKetInstagram")
				{
					form = new fHDHuyLienKetInstagram("", 1, text);
				}
				break;
			case 4136680805u:
				if (text4 == "HDShareBaiTut")
				{
					form = new fHDShareBaiTut("", 1, text);
				}
				break;
			case 4095834327u:
				if (text4 == "HDXacNhanKetBan")
				{
					form = new fHDXacNhanKetBan("", 1, text);
				}
				break;
			case 4226158249u:
				if (text4 == "HDKetBanThanhVienNhom")
				{
					form = new fHDKetBanThanhVienNhom("", 1, text);
				}
				break;
			case 4198930712u:
				if (text4 == "HDXoaThietBiTinCay")
				{
					form = new fHDXoaThietBiTinCay("", 1, text);
				}
				break;
			case 4189681400u:
				if (text4 == "HDSpamBaiViet")
				{
					form = new A6AEB23C("", 1, text);
				}
				break;
			}
			if (form != null)
			{
				GClass8.smethod_33(form);
			}
			dataTable = Class147.F3057616(text);
			GClass27.smethod_5(dtgvHanhDong, dataGridViewRow.Index, "cTenHanhDong", dataTable.Rows[0]["TenHanhDong"].ToString());
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA);
			GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
		}
	}

	private void BF02BD30_KeyDown(object sender, KeyEventArgs e)
	{
		switch (e.KeyCode)
		{
		case Keys.Delete:
			CDB800BC();
			break;
		case Keys.Insert:
		case Keys.F1:
			method_7();
			break;
		case Keys.F2:
			method_6();
			break;
		case Keys.F5:
			E8873719();
			break;
		case Keys.D:
			if (e.Modifiers == Keys.Control)
			{
				method_8();
			}
			break;
		}
	}

	private void E8873719(string string_1 = "")
	{
		try
		{
			BF02BD30.Rows.Clear();
			DataTable dataTable = Class147.CD078893();
			if (dataTable.Rows.Count > 0)
			{
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					DataRow dataRow = dataTable.Rows[i];
					BF02BD30.Rows.Add(i + 1, dataRow["Id_KichBan"], dataRow["TenKichBan"]);
				}
			}
			if (string_1 != "")
			{
				for (int j = 0; j < BF02BD30.RowCount; j++)
				{
					if (GClass27.smethod_3(BF02BD30, j, "cId_KichBan") == string_1)
					{
						BF02BD30.Rows[j].Selected = true;
						break;
					}
				}
			}
			method_3();
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA);
		}
	}

	private void CDB800BC()
	{
		try
		{
			if (BF02BD30.RowCount == 0)
			{
				GClass29.smethod_0("Vui lòng thêm kịch bản trước!", 3);
			}
			else
			{
				if (GClass29.smethod_1("Bạn có chắc muốn xóa kịch bản này?") != DialogResult.Yes)
				{
					return;
				}
				DataGridViewRow dataGridViewRow = BF02BD30.SelectedRows[0];
				if (Class147.smethod_5(dataGridViewRow.Cells["cId_KichBan"].Value.ToString()))
				{
					int index = dataGridViewRow.Index;
					for (int i = index; i < BF02BD30.Rows.Count - 1; i++)
					{
						method_0(ref BF02BD30, i, i + 1);
					}
					BF02BD30.Rows.RemoveAt(BF02BD30.Rows.Count - 1);
					method_3();
				}
				else
				{
					GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
				}
				return;
			}
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA);
			GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
		}
	}

	private void method_6()
	{
		try
		{
			if (BF02BD30.RowCount == 0)
			{
				GClass29.smethod_0("Vui lòng thêm kịch bản trước!", 3);
				return;
			}
			DataGridViewRow dataGridViewRow = BF02BD30.SelectedRows[0];
			string text = dataGridViewRow.Cells["cId_KichBan"].Value.ToString();
			GClass8.smethod_33(new fThemKichBan(1, text));
			string bB1C838D = Class147.smethod_1(text).Rows[0]["TenKichBan"].ToString();
			GClass27.smethod_5(BF02BD30, dataGridViewRow.Index, "cTenKichBan", bB1C838D);
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA);
			GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
		}
	}

	private void method_7()
	{
		try
		{
			string text = "";
			try
			{
				text = Class147.smethod_2().Rows[0]["Id_KichBan"].ToString();
			}
			catch
			{
			}
			GClass8.smethod_33(new fThemKichBan(0));
			DataTable dataTable = Class147.smethod_2();
			string text2 = "";
			try
			{
				text2 = dataTable.Rows[0]["Id_KichBan"].ToString();
			}
			catch
			{
			}
			if (text != text2)
			{
				BF02BD30.Rows.Add(BF02BD30.RowCount + 1, dataTable.Rows[0]["Id_KichBan"], dataTable.Rows[0]["TenKichBan"]);
			}
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA);
			GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
		}
	}

	private void method_8()
	{
		try
		{
			if (BF02BD30.RowCount == 0)
			{
				GClass29.smethod_0("Vui lòng thêm kịch bản trước!", 3);
				return;
			}
			DataGridViewRow dataGridViewRow = BF02BD30.SelectedRows[0];
			string text = dataGridViewRow.Cells["cId_KichBan"].Value.ToString();
			string text2 = dataGridViewRow.Cells["cTenKichBan"].Value.ToString();
			string text3 = text2 + " - Copy";
			int num = 2;
			while (Class147.smethod_3(text3))
			{
				text3 = text2 + $" - Copy ({num++})";
			}
			if (Class147.smethod_6(text, text3))
			{
				DataTable dataTable = Class147.smethod_2();
				BF02BD30.Rows.Add(BF02BD30.RowCount + 1, dataTable.Rows[0]["Id_KichBan"], dataTable.Rows[0]["TenKichBan"]);
			}
			else
			{
				GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
		catch
		{
		}
	}

	private void BF02BD30_KeyUp(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		Keys keys = keyCode;
		if (keys == Keys.Up || keys == Keys.Down)
		{
			method_3();
		}
	}

	private void C420D4A8(object sender, PaintEventArgs e)
	{
	}

	private void D116B123(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void btnQuanLyKichBan_Click(object sender, EventArgs e)
	{
		method_7();
	}

	private void C12BC9AA(object sender, EventArgs e)
	{
		method_6();
	}

	private void AC871892(object sender, EventArgs e)
	{
		CDB800BC();
	}

	private void button6_Click(object sender, EventArgs e)
	{
		method_8();
	}

	private void EDB04D2B(object sender, EventArgs e)
	{
		method_4();
	}

	private void DC109C00_Click(object sender, EventArgs e)
	{
		method_5();
	}

	private void C8BEEF34(object sender, EventArgs e)
	{
		BF816E89();
	}

	private void button11_Click(object sender, EventArgs e)
	{
		B306CF0B();
	}

	private void F20DAF9B(object sender, EventArgs e)
	{
		int index = dtgvHanhDong.SelectedRows[0].Index;
		if (index == 0)
		{
			return;
		}
		string text = GClass27.smethod_3(dtgvHanhDong, index - 1, "cId_HanhDong");
		string text2 = GClass27.smethod_3(dtgvHanhDong, index, "cId_HanhDong");
		if (text + text2 != "")
		{
			if (Class147.smethod_14(text, text2))
			{
				method_0(ref dtgvHanhDong, index, index - 1);
				dtgvHanhDong.Rows[index - 1].Selected = true;
			}
			else
			{
				GClass29.smethod_0("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void button9_Click(object sender, EventArgs e)
	{
		int index = dtgvHanhDong.SelectedRows[0].Index;
		if (index == dtgvHanhDong.RowCount - 1)
		{
			return;
		}
		string text = GClass27.smethod_3(dtgvHanhDong, index + 1, "cId_HanhDong");
		string text2 = GClass27.smethod_3(dtgvHanhDong, index, "cId_HanhDong");
		if (text + text2 != "")
		{
			if (Class147.smethod_14(text, text2))
			{
				method_0(ref dtgvHanhDong, index, index + 1);
				dtgvHanhDong.Rows[index + 1].Selected = true;
			}
			else
			{
				GClass29.smethod_0("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void BD92359D(object sender, EventArgs e)
	{
		int index = BF02BD30.SelectedRows[0].Index;
		if (index == 0)
		{
			return;
		}
		string text = GClass27.smethod_3(BF02BD30, index - 1, "cId_KichBan");
		string text2 = GClass27.smethod_3(BF02BD30, index, "cId_KichBan");
		if (text + text2 != "")
		{
			if (Class147.E416FA1A(text, text2))
			{
				GClass8.smethod_79(ref BF02BD30, index, index - 1);
				BF02BD30.Rows[index - 1].Selected = true;
			}
			else
			{
				GClass29.smethod_0("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void CA073123(object sender, EventArgs e)
	{
		int index = BF02BD30.SelectedRows[0].Index;
		if (index == BF02BD30.RowCount - 1)
		{
			return;
		}
		string text = GClass27.smethod_3(BF02BD30, index + 1, "cId_KichBan");
		string text2 = GClass27.smethod_3(BF02BD30, index, "cId_KichBan");
		if (text + text2 != "")
		{
			if (Class147.E416FA1A(text, text2))
			{
				GClass8.smethod_79(ref BF02BD30, index, index + 1);
				BF02BD30.Rows[index + 1].Selected = true;
			}
			else
			{
				GClass29.smethod_0("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void D92BDF1F(object sender, EventArgs e)
	{
		plCountAction.Visible = cbbCountAction.SelectedValue.ToString() == "1";
	}

	private void method_9()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Tâ\u0301t ca\u0309");
		dictionary.Add("1", "Tu\u0300y chi\u0309nh");
		cbbCountAction.DataSource = new BindingSource(dictionary, null);
		cbbCountAction.DisplayMember = "Value";
		cbbCountAction.ValueMember = "Key";
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		try
		{
			GClass11 gClass = new GClass11();
			gClass.method_4("cbbCountAction", cbbCountAction.SelectedIndex);
			gClass.method_4("nudCountActionFrom", DD35D092.Value);
			gClass.method_4("nudCountActionTo", nudCountActionTo.Value);
			gClass.method_4("ckbRandomAction", B9AD5524.Checked);
			DataGridViewRow dataGridViewRow = BF02BD30.SelectedRows[0];
			string e4A5E = dataGridViewRow.Cells["cId_KichBan"].Value.ToString();
			Class147.D606CE11(e4A5E, gClass.method_7());
			GClass29.smethod_0("Lưu thành công!");
		}
		catch (Exception ex)
		{
			GClass29.smethod_0("Lỗi Lưu cấu hình kịch bản!\r\n" + ex.ToString(), 2);
		}
	}

	protected override void Dispose(bool F3853405)
	{
		if (F3853405 && E204CD2D != null)
		{
			E204CD2D.Dispose();
		}
		base.Dispose(F3853405);
	}

	private void AF88A73B()
	{
		E204CD2D = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fDanhSachKichBan_Old));
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		toolTip_0 = new ToolTip(E204CD2D);
		bunifuDragControl_0 = new BunifuDragControl(E204CD2D);
		F4362BA7 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(E204CD2D);
		pnlHeader = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		groupBox1 = new GroupBox();
		E286198C = new Button();
		button7 = new Button();
		button6 = new Button();
		DA13D69F = new Button();
		button4 = new Button();
		btnQuanLyKichBan = new Button();
		BF02BD30 = new DataGridView();
		BDAADD98 = new DataGridViewTextBoxColumn();
		cId_KichBan = new DataGridViewTextBoxColumn();
		cTenKichBan = new DataGridViewTextBoxColumn();
		contextMenuStrip1 = new ContextMenuStrip(E204CD2D);
		toolStripMenuItem_0 = new ToolStripMenuItem();
		toolStripMenuItem_1 = new ToolStripMenuItem();
		toolStripMenuItem_2 = new ToolStripMenuItem();
		toolStripMenuItem_3 = new ToolStripMenuItem();
		bunifuCards1 = new BunifuCards();
		groupBox2 = new GroupBox();
		button9 = new Button();
		button10 = new Button();
		button11 = new Button();
		C4BB98AD = new Button();
		DC109C00 = new Button();
		button14 = new Button();
		groupBox3 = new GroupBox();
		label1 = new Label();
		plCountAction = new Panel();
		nudCountActionTo = new NumericUpDown();
		DD35D092 = new NumericUpDown();
		label2 = new Label();
		dtgvHanhDong = new DataGridView();
		dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		cId_HanhDong = new DataGridViewTextBoxColumn();
		cTenHanhDong = new DataGridViewTextBoxColumn();
		DBB4BCB7 = new DataGridViewTextBoxColumn();
		contextMenuStrip1_1 = new ContextMenuStrip(E204CD2D);
		toolStripMenuItem1 = new ToolStripMenuItem();
		toolStripMenuItem3 = new ToolStripMenuItem();
		CC35B995 = new ToolStripMenuItem();
		toolStripMenuItem2 = new ToolStripMenuItem();
		panel1 = new Panel();
		splitContainer1 = new SplitContainer();
		cbbCountAction = new ComboBox();
		C5A66E3C = new Label();
		B9AD5524 = new CheckBox();
		btnSave = new Button();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		groupBox1.SuspendLayout();
		((ISupportInitialize)BF02BD30).BeginInit();
		contextMenuStrip1.SuspendLayout();
		bunifuCards1.SuspendLayout();
		groupBox2.SuspendLayout();
		groupBox3.SuspendLayout();
		plCountAction.SuspendLayout();
		((ISupportInitialize)nudCountActionTo).BeginInit();
		((ISupportInitialize)DD35D092).BeginInit();
		((ISupportInitialize)dtgvHanhDong).BeginInit();
		contextMenuStrip1_1.SuspendLayout();
		panel1.SuspendLayout();
		((ISupportInitialize)splitContainer1).BeginInit();
		splitContainer1.Panel1.SuspendLayout();
		splitContainer1.Panel2.SuspendLayout();
		splitContainer1.SuspendLayout();
		SuspendLayout();
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		toolTip_0.ToolTipTitle = "Chú thích";
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = F4362BA7;
		bunifuDragControl_0.Vertical = true;
		F4362BA7.BackColor = Color.Transparent;
		F4362BA7.Cursor = Cursors.SizeAll;
		F4362BA7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		F4362BA7.ForeColor = Color.Black;
		F4362BA7.Location = new Point(0, 0);
		F4362BA7.Name = "bunifuCustomLabel1";
		F4362BA7.Size = new Size(951, 31);
		F4362BA7.TabIndex = 12;
		F4362BA7.Text = "Qua\u0309n ly\u0301 ki\u0323ch ba\u0309n";
		F4362BA7.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(F4362BA7);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(986, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(957, 2);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += button1_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		groupBox1.BackColor = Color.White;
		groupBox1.Controls.Add(E286198C);
		groupBox1.Controls.Add(button7);
		groupBox1.Controls.Add(button6);
		groupBox1.Controls.Add(DA13D69F);
		groupBox1.Controls.Add(button4);
		groupBox1.Controls.Add(btnQuanLyKichBan);
		groupBox1.Controls.Add(BF02BD30);
		groupBox1.Dock = DockStyle.Fill;
		groupBox1.Location = new Point(0, 0);
		groupBox1.Margin = new Padding(3, 4, 3, 4);
		groupBox1.Name = "groupBox1";
		groupBox1.Padding = new Padding(3, 4, 3, 4);
		groupBox1.Size = new Size(330, 517);
		groupBox1.TabIndex = 1;
		groupBox1.TabStop = false;
		groupBox1.Text = "Danh sách kịch bản";
		E286198C.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		E286198C.Cursor = Cursors.Hand;
		E286198C.FlatAppearance.BorderColor = Color.Silver;
		E286198C.FlatStyle = FlatStyle.Flat;
		E286198C.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		E286198C.Image = C50FB39E.Bitmap_86;
		E286198C.Location = new Point(297, 15);
		E286198C.Name = "button8";
		E286198C.Padding = new Padding(3);
		E286198C.Size = new Size(27, 27);
		E286198C.TabIndex = 77;
		E286198C.Click += CA073123;
		button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button7.Cursor = Cursors.Hand;
		button7.FlatAppearance.BorderColor = Color.Silver;
		button7.FlatStyle = FlatStyle.Flat;
		button7.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button7.Image = C50FB39E.A89A3403;
		button7.Location = new Point(265, 15);
		button7.Name = "button7";
		button7.Padding = new Padding(3);
		button7.Size = new Size(27, 27);
		button7.TabIndex = 77;
		button7.Click += BD92359D;
		button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button6.Cursor = Cursors.Hand;
		button6.FlatAppearance.BorderColor = Color.Silver;
		button6.FlatStyle = FlatStyle.Flat;
		button6.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button6.Image = C50FB39E.Bitmap_77;
		button6.Location = new Point(232, 15);
		button6.Name = "button6";
		button6.Padding = new Padding(3);
		button6.Size = new Size(27, 27);
		button6.TabIndex = 77;
		button6.Click += button6_Click;
		DA13D69F.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		DA13D69F.Cursor = Cursors.Hand;
		DA13D69F.FlatAppearance.BorderColor = Color.Silver;
		DA13D69F.FlatStyle = FlatStyle.Flat;
		DA13D69F.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		DA13D69F.Image = C50FB39E.Bitmap_85;
		DA13D69F.Location = new Point(199, 15);
		DA13D69F.Name = "button5";
		DA13D69F.Padding = new Padding(3);
		DA13D69F.Size = new Size(27, 27);
		DA13D69F.TabIndex = 77;
		DA13D69F.Click += AC871892;
		button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button4.Cursor = Cursors.Hand;
		button4.FlatAppearance.BorderColor = Color.Silver;
		button4.FlatStyle = FlatStyle.Flat;
		button4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button4.Image = C50FB39E.CA8AD9BF;
		button4.Location = new Point(166, 15);
		button4.Name = "button4";
		button4.Padding = new Padding(3);
		button4.Size = new Size(27, 27);
		button4.TabIndex = 77;
		button4.Click += C12BC9AA;
		btnQuanLyKichBan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		btnQuanLyKichBan.Cursor = Cursors.Hand;
		btnQuanLyKichBan.FlatAppearance.BorderColor = Color.Silver;
		btnQuanLyKichBan.FlatStyle = FlatStyle.Flat;
		btnQuanLyKichBan.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnQuanLyKichBan.Image = C50FB39E.F9BC3CA9;
		btnQuanLyKichBan.Location = new Point(133, 15);
		btnQuanLyKichBan.Name = "btnQuanLyKichBan";
		btnQuanLyKichBan.Padding = new Padding(3);
		btnQuanLyKichBan.Size = new Size(27, 27);
		btnQuanLyKichBan.TabIndex = 77;
		btnQuanLyKichBan.Click += btnQuanLyKichBan_Click;
		BF02BD30.AllowUserToAddRows = false;
		BF02BD30.AllowUserToDeleteRows = false;
		BF02BD30.AllowUserToResizeRows = false;
		BF02BD30.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		BF02BD30.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = SystemColors.Control;
		dataGridViewCellStyle.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		BF02BD30.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		BF02BD30.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		BF02BD30.Columns.AddRange(BDAADD98, cId_KichBan, cTenKichBan);
		BF02BD30.ContextMenuStrip = contextMenuStrip1;
		BF02BD30.EditMode = DataGridViewEditMode.EditProgrammatically;
		BF02BD30.Location = new Point(6, 48);
		BF02BD30.MultiSelect = false;
		BF02BD30.Name = "dtgvKichBan";
		BF02BD30.RowHeadersVisible = false;
		BF02BD30.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		BF02BD30.Size = new Size(318, 462);
		BF02BD30.TabIndex = 76;
		BF02BD30.CellClick += BF02BD30_CellClick;
		BF02BD30.KeyDown += BF02BD30_KeyDown;
		BF02BD30.KeyUp += BF02BD30_KeyUp;
		BDAADD98.HeaderText = "STT";
		BDAADD98.Name = "cStt";
		BDAADD98.Width = 35;
		cId_KichBan.HeaderText = "Column1";
		cId_KichBan.Name = "cId_KichBan";
		cId_KichBan.Visible = false;
		cTenKichBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		cTenKichBan.HeaderText = "Tên kịch bản";
		cTenKichBan.Name = "cTenKichBan";
		cTenKichBan.SortMode = DataGridViewColumnSortMode.NotSortable;
		contextMenuStrip1.Items.AddRange(new ToolStripItem[4] { toolStripMenuItem_0, toolStripMenuItem_1, toolStripMenuItem_2, toolStripMenuItem_3 });
		contextMenuStrip1.Name = "contextMenuStrip1";
		contextMenuStrip1.Size = new Size(162, 92);
		toolStripMenuItem_0.Image = C50FB39E.F9BC3CA9;
		toolStripMenuItem_0.Name = "thêmMớiToolStripMenuItem";
		toolStripMenuItem_0.Size = new Size(161, 22);
		toolStripMenuItem_0.Text = "Thêm ki\u0323ch ba\u0309n";
		toolStripMenuItem_0.Click += toolStripMenuItem_0_Click;
		toolStripMenuItem_1.Image = C50FB39E.CA8AD9BF;
		toolStripMenuItem_1.Name = "sửaToolStripMenuItem";
		toolStripMenuItem_1.Size = new Size(161, 22);
		toolStripMenuItem_1.Text = "Sửa tên ki\u0323ch ba\u0309n";
		toolStripMenuItem_1.Click += toolStripMenuItem_1_Click;
		toolStripMenuItem_2.Image = C50FB39E.Bitmap_85;
		toolStripMenuItem_2.Name = "xóaToolStripMenuItem";
		toolStripMenuItem_2.Size = new Size(161, 22);
		toolStripMenuItem_2.Text = "Xóa ki\u0323ch ba\u0309n";
		toolStripMenuItem_2.Click += toolStripMenuItem_2_Click;
		toolStripMenuItem_3.Image = C50FB39E.Bitmap_77;
		toolStripMenuItem_3.Name = "nhânBảnToolStripMenuItem";
		toolStripMenuItem_3.Size = new Size(161, 22);
		toolStripMenuItem_3.Text = "Nhân bản";
		toolStripMenuItem_3.Click += toolStripMenuItem_3_Click;
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
		bunifuCards1.Size = new Size(989, 37);
		bunifuCards1.TabIndex = 12;
		groupBox2.BackColor = Color.White;
		groupBox2.Controls.Add(button9);
		groupBox2.Controls.Add(button10);
		groupBox2.Controls.Add(button11);
		groupBox2.Controls.Add(C4BB98AD);
		groupBox2.Controls.Add(DC109C00);
		groupBox2.Controls.Add(button14);
		groupBox2.Controls.Add(groupBox3);
		groupBox2.Controls.Add(dtgvHanhDong);
		groupBox2.Dock = DockStyle.Fill;
		groupBox2.Location = new Point(0, 0);
		groupBox2.Margin = new Padding(3, 4, 3, 4);
		groupBox2.Name = "groupBox2";
		groupBox2.Padding = new Padding(3, 4, 3, 4);
		groupBox2.Size = new Size(639, 517);
		groupBox2.TabIndex = 1;
		groupBox2.TabStop = false;
		groupBox2.Text = "Danh sách hành động";
		button9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button9.Cursor = Cursors.Hand;
		button9.FlatAppearance.BorderColor = Color.Silver;
		button9.FlatStyle = FlatStyle.Flat;
		button9.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button9.Image = C50FB39E.DB8D273E;
		button9.Location = new Point(606, 15);
		button9.Name = "button9";
		button9.Padding = new Padding(3);
		button9.Size = new Size(27, 27);
		button9.TabIndex = 84;
		button9.Click += button9_Click;
		button10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button10.Cursor = Cursors.Hand;
		button10.FlatAppearance.BorderColor = Color.Silver;
		button10.FlatStyle = FlatStyle.Flat;
		button10.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button10.Image = C50FB39E.Bitmap_139;
		button10.Location = new Point(574, 15);
		button10.Name = "button10";
		button10.Padding = new Padding(3);
		button10.Size = new Size(27, 27);
		button10.TabIndex = 85;
		button10.Click += F20DAF9B;
		button11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button11.Cursor = Cursors.Hand;
		button11.FlatAppearance.BorderColor = Color.Silver;
		button11.FlatStyle = FlatStyle.Flat;
		button11.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button11.Image = C50FB39E.CF1D56A0;
		button11.Location = new Point(541, 15);
		button11.Name = "button11";
		button11.Padding = new Padding(3);
		button11.Size = new Size(27, 27);
		button11.TabIndex = 86;
		button11.Click += button11_Click;
		C4BB98AD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		C4BB98AD.Cursor = Cursors.Hand;
		C4BB98AD.FlatAppearance.BorderColor = Color.Silver;
		C4BB98AD.FlatStyle = FlatStyle.Flat;
		C4BB98AD.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C4BB98AD.Image = C50FB39E.Bitmap_84;
		C4BB98AD.Location = new Point(508, 15);
		C4BB98AD.Name = "button12";
		C4BB98AD.Padding = new Padding(3);
		C4BB98AD.Size = new Size(27, 27);
		C4BB98AD.TabIndex = 87;
		C4BB98AD.Click += C8BEEF34;
		DC109C00.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		DC109C00.Cursor = Cursors.Hand;
		DC109C00.FlatAppearance.BorderColor = Color.Silver;
		DC109C00.FlatStyle = FlatStyle.Flat;
		DC109C00.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		DC109C00.Image = C50FB39E.AD967FA0;
		DC109C00.Location = new Point(475, 15);
		DC109C00.Name = "button13";
		DC109C00.Padding = new Padding(3);
		DC109C00.Size = new Size(27, 27);
		DC109C00.TabIndex = 88;
		DC109C00.Click += DC109C00_Click;
		button14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button14.Cursor = Cursors.Hand;
		button14.FlatAppearance.BorderColor = Color.Silver;
		button14.FlatStyle = FlatStyle.Flat;
		button14.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button14.Image = C50FB39E.D98F4328;
		button14.Location = new Point(442, 15);
		button14.Name = "button14";
		button14.Padding = new Padding(3);
		button14.Size = new Size(27, 27);
		button14.TabIndex = 89;
		button14.Click += EDB04D2B;
		groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		groupBox3.Controls.Add(B9AD5524);
		groupBox3.Controls.Add(cbbCountAction);
		groupBox3.Controls.Add(label1);
		groupBox3.Controls.Add(plCountAction);
		groupBox3.Controls.Add(btnSave);
		groupBox3.Location = new Point(6, 432);
		groupBox3.Name = "groupBox3";
		groupBox3.Size = new Size(627, 78);
		groupBox3.TabIndex = 83;
		groupBox3.TabStop = false;
		groupBox3.Text = "Cấu hình kịch bản";
		label1.AutoSize = true;
		label1.Location = new Point(6, 23);
		label1.Name = "label1";
		label1.Size = new Size(121, 16);
		label1.TabIndex = 79;
		label1.Text = "Sô\u0301 ha\u0300nh đô\u0323ng cha\u0323y:";
		plCountAction.BorderStyle = BorderStyle.FixedSingle;
		plCountAction.Controls.Add(nudCountActionTo);
		plCountAction.Controls.Add(DD35D092);
		plCountAction.Controls.Add(C5A66E3C);
		plCountAction.Controls.Add(label2);
		plCountAction.Location = new Point(311, 17);
		plCountAction.Name = "plCountAction";
		plCountAction.Size = new Size(188, 31);
		plCountAction.TabIndex = 81;
		nudCountActionTo.Location = new Point(71, 3);
		nudCountActionTo.Maximum = new decimal(new int[4] { 9999999, 0, 0, 0 });
		nudCountActionTo.Name = "nudCountActionTo";
		nudCountActionTo.Size = new Size(43, 23);
		nudCountActionTo.TabIndex = 0;
		DD35D092.Location = new Point(2, 3);
		DD35D092.Maximum = new decimal(new int[4] { 9999999, 0, 0, 0 });
		DD35D092.Name = "nudCountActionFrom";
		DD35D092.Size = new Size(43, 23);
		DD35D092.TabIndex = 0;
		label2.AutoSize = true;
		label2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label2.Location = new Point(49, 5);
		label2.Name = "label2";
		label2.Size = new Size(18, 16);
		label2.TabIndex = 79;
		label2.Text = ">";
		dtgvHanhDong.AllowUserToAddRows = false;
		dtgvHanhDong.AllowUserToDeleteRows = false;
		dtgvHanhDong.AllowUserToResizeRows = false;
		dtgvHanhDong.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		dtgvHanhDong.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = SystemColors.Control;
		dataGridViewCellStyle2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
		dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
		dtgvHanhDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		dtgvHanhDong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dtgvHanhDong.Columns.AddRange(dataGridViewTextBoxColumn1, cId_HanhDong, cTenHanhDong, DBB4BCB7);
		dtgvHanhDong.ContextMenuStrip = contextMenuStrip1_1;
		dtgvHanhDong.EditMode = DataGridViewEditMode.EditProgrammatically;
		dtgvHanhDong.Location = new Point(6, 48);
		dtgvHanhDong.MultiSelect = false;
		dtgvHanhDong.Name = "dtgvHanhDong";
		dtgvHanhDong.RowHeadersVisible = false;
		dtgvHanhDong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dtgvHanhDong.Size = new Size(627, 378);
		dtgvHanhDong.TabIndex = 77;
		dtgvHanhDong.KeyDown += dtgvHanhDong_KeyDown;
		dataGridViewTextBoxColumn1.HeaderText = "STT";
		dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
		dataGridViewTextBoxColumn1.Width = 35;
		cId_HanhDong.HeaderText = "Column1";
		cId_HanhDong.Name = "cId_HanhDong";
		cId_HanhDong.Visible = false;
		cTenHanhDong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		cTenHanhDong.HeaderText = "Tên hành động";
		cTenHanhDong.Name = "cTenHanhDong";
		cTenHanhDong.SortMode = DataGridViewColumnSortMode.NotSortable;
		DBB4BCB7.HeaderText = "Loại tương tác";
		DBB4BCB7.Name = "cTheLoai";
		DBB4BCB7.Width = 175;
		contextMenuStrip1_1.Items.AddRange(new ToolStripItem[4] { toolStripMenuItem1, toolStripMenuItem3, CC35B995, toolStripMenuItem2 });
		contextMenuStrip1_1.Name = "contextMenuStrip1";
		contextMenuStrip1_1.Size = new Size(166, 92);
		toolStripMenuItem1.Image = C50FB39E.D98F4328;
		toolStripMenuItem1.Name = "toolStripMenuItem1";
		toolStripMenuItem1.Size = new Size(165, 22);
		toolStripMenuItem1.Text = "Thêm ha\u0300nh đô\u0323ng";
		toolStripMenuItem1.Click += DFA000A1;
		toolStripMenuItem3.Image = C50FB39E.AD967FA0;
		toolStripMenuItem3.Name = "toolStripMenuItem3";
		toolStripMenuItem3.Size = new Size(165, 22);
		toolStripMenuItem3.Text = "Sửa ha\u0300nh đô\u0323ng";
		toolStripMenuItem3.Click += toolStripMenuItem3_Click;
		CC35B995.Image = C50FB39E.Bitmap_84;
		CC35B995.Name = "toolStripMenuItem4";
		CC35B995.Size = new Size(165, 22);
		CC35B995.Text = "Xóa ha\u0300nh đô\u0323ng";
		CC35B995.Click += CC35B995_Click;
		toolStripMenuItem2.Image = C50FB39E.CF1D56A0;
		toolStripMenuItem2.Name = "toolStripMenuItem2";
		toolStripMenuItem2.Size = new Size(165, 22);
		toolStripMenuItem2.Text = "Nhân bản";
		toolStripMenuItem2.Click += DBB6E72C;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(splitContainer1);
		panel1.Controls.Add(bunifuCards1);
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(992, 565);
		panel1.TabIndex = 13;
		panel1.Paint += D116B123;
		splitContainer1.Location = new Point(4, 40);
		splitContainer1.Name = "splitContainer1";
		splitContainer1.Panel1.Controls.Add(groupBox1);
		splitContainer1.Panel2.Controls.Add(groupBox2);
		splitContainer1.Size = new Size(984, 517);
		splitContainer1.SplitterDistance = 330;
		splitContainer1.SplitterWidth = 15;
		splitContainer1.TabIndex = 13;
		cbbCountAction.Cursor = Cursors.Hand;
		cbbCountAction.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbCountAction.FormattingEnabled = true;
		cbbCountAction.Location = new Point(133, 20);
		cbbCountAction.Name = "cbbCountAction";
		cbbCountAction.Size = new Size(172, 24);
		cbbCountAction.TabIndex = 82;
		cbbCountAction.SelectedIndexChanged += D92BDF1F;
		C5A66E3C.AutoSize = true;
		C5A66E3C.Location = new Point(117, 6);
		C5A66E3C.Name = "label3";
		C5A66E3C.Size = new Size(67, 16);
		C5A66E3C.TabIndex = 79;
		C5A66E3C.Text = "hành động";
		B9AD5524.AutoSize = true;
		B9AD5524.Cursor = Cursors.Hand;
		B9AD5524.Location = new Point(9, 51);
		B9AD5524.Name = "ckbRandomAction";
		B9AD5524.Size = new Size(178, 20);
		B9AD5524.TabIndex = 83;
		B9AD5524.Text = "Xáo trộn thứ tự hành động";
		B9AD5524.UseVisualStyleBackColor = true;
		btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		btnSave.Cursor = Cursors.Hand;
		btnSave.FlatAppearance.BorderColor = Color.Silver;
		btnSave.FlatStyle = FlatStyle.Flat;
		btnSave.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnSave.Location = new Point(523, 17);
		btnSave.Name = "btnSave";
		btnSave.Padding = new Padding(3);
		btnSave.Size = new Size(98, 54);
		btnSave.TabIndex = 77;
		btnSave.Text = "Lưu";
		btnSave.Click += btnSave_Click;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(992, 565);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fDanhSachKichBan_Old";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Cấu hình tương tác";
		base.Load += fDanhSachKichBan_Old_Load;
		base.Paint += C420D4A8;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		groupBox1.ResumeLayout(performLayout: false);
		((ISupportInitialize)BF02BD30).EndInit();
		contextMenuStrip1.ResumeLayout(performLayout: false);
		bunifuCards1.ResumeLayout(performLayout: false);
		groupBox2.ResumeLayout(performLayout: false);
		groupBox3.ResumeLayout(performLayout: false);
		groupBox3.PerformLayout();
		plCountAction.ResumeLayout(performLayout: false);
		plCountAction.PerformLayout();
		((ISupportInitialize)nudCountActionTo).EndInit();
		((ISupportInitialize)DD35D092).EndInit();
		((ISupportInitialize)dtgvHanhDong).EndInit();
		contextMenuStrip1_1.ResumeLayout(performLayout: false);
		panel1.ResumeLayout(performLayout: false);
		splitContainer1.Panel1.ResumeLayout(performLayout: false);
		splitContainer1.Panel2.ResumeLayout(performLayout: false);
		((ISupportInitialize)splitContainer1).EndInit();
		splitContainer1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
