using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class CDB179A2 : Form
{
	[CompilerGenerated]
	private sealed class C00C8A9E
	{
		public bool bool_0;

		public int B4AB6620;

		public string string_0;

		public List<string> C31CDBB1;

		public CDB179A2 cdb179A2_0;

		internal void E6B04DAE()
		{
			try
			{
				cdb179A2_0.btnAdd.Invoke((MethodInvoker)delegate
				{
					cdb179A2_0.btnAdd.Enabled = false;
				});
				cdb179A2_0.ADB5D5B6(F7AB102E.smethod_0("Chuẩn bị thêm tài khoản..."), cdb179A2_0.CF1A430E);
				if (bool_0)
				{
					int num = 0;
					while (num < cdb179A2_0.CB82B986.Count)
					{
						if (cdb179A2_0.list_1.Count < B4AB6620)
						{
							Class58 CS_0024_003C_003E8__locals0 = new Class58
							{
								AD813324 = this,
								int_0 = num++
							};
							cdb179A2_0.ADB5D5B6($"Check info {CS_0024_003C_003E8__locals0.int_0 + 1}/{cdb179A2_0.CB82B986.Count}...", cdb179A2_0.CF1A430E);
							Thread thread = new Thread((ThreadStart)delegate
							{
								try
								{
									string text3 = CS_0024_003C_003E8__locals0.AD813324.cdb179A2_0.CB82B986[CS_0024_003C_003E8__locals0.int_0];
									if (text3 != "")
									{
										string text4 = CS_0024_003C_003E8__locals0.AD813324.cdb179A2_0.method_2(CS_0024_003C_003E8__locals0.AD813324.string_0, text3, CS_0024_003C_003E8__locals0.AD813324.bool_0);
										if (text4 != "")
										{
											lock (CS_0024_003C_003E8__locals0.AD813324.C31CDBB1)
											{
												CS_0024_003C_003E8__locals0.AD813324.C31CDBB1.Add(text4);
											}
										}
									}
								}
								catch (Exception)
								{
								}
							});
							cdb179A2_0.list_1.Add(thread);
							thread.Start();
							continue;
						}
						for (int i = 0; i < cdb179A2_0.list_1.Count; i++)
						{
							if (!cdb179A2_0.list_1[i].IsAlive)
							{
								cdb179A2_0.list_1.RemoveAt(i--);
							}
						}
					}
					for (int j = 0; j < cdb179A2_0.list_1.Count; j++)
					{
						cdb179A2_0.list_1[j].Join();
					}
				}
				else
				{
					for (int k = 0; k < cdb179A2_0.CB82B986.Count; k++)
					{
						try
						{
							string text = cdb179A2_0.CB82B986[k];
							if (text != "")
							{
								string text2 = cdb179A2_0.method_2(string_0, text, bool_0);
								if (text2 != "")
								{
									C31CDBB1.Add(text2);
								}
							}
						}
						catch
						{
						}
					}
				}
				cdb179A2_0.ADB5D5B6(F7AB102E.smethod_0("Đang thêm tài khoản..."), cdb179A2_0.CF1A430E);
				if (C31CDBB1.Count >= 0)
				{
					C31CDBB1 = Class15.smethod_8(C31CDBB1);
					for (int l = 0; l < C31CDBB1.Count; l++)
					{
						cdb179A2_0.method_3(cdb179A2_0.lblSuccess, Class53.smethod_1(C31CDBB1[l]));
					}
				}
				cdb179A2_0.ADB5D5B6((Convert.ToInt32(cdb179A2_0.lblTotal.Text) - Convert.ToInt32(cdb179A2_0.lblSuccess.Text)).ToString() ?? "", cdb179A2_0.EE2F529D);
				cdb179A2_0.btnAdd.C22B543F();
				cdb179A2_0.ADB5D5B6(F7AB102E.smethod_0("Thêm tài khoản thành công!"), cdb179A2_0.CF1A430E);
				GClass29.smethod_0("Thêm tài khoản thành công!");
				cdb179A2_0.bool_0 = true;
				cdb179A2_0.int_0 = Convert.ToInt32(string_0);
			}
			catch (Exception f4295AA)
			{
				GClass8.BFBDF687(null, f4295AA, "AddAccount");
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class58
	{
		public int int_0;

		public C00C8A9E AD813324;

		internal void method_0()
		{
			try
			{
				string text = AD813324.cdb179A2_0.CB82B986[int_0];
				if (!(text != ""))
				{
					return;
				}
				string text2 = AD813324.cdb179A2_0.method_2(AD813324.string_0, text, AD813324.bool_0);
				if (text2 != "")
				{
					lock (AD813324.C31CDBB1)
					{
						AD813324.C31CDBB1.Add(text2);
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class59
	{
		public Label D184680C;

		public string string_0;

		internal void DA2D9CB9()
		{
			Application.DoEvents();
			D184680C.Text = string_0;
		}
	}

	[CompilerGenerated]
	private sealed class Class60
	{
		public Label C1BE090B;

		public int int_0;

		internal void C319A7A2()
		{
			Application.DoEvents();
			C1BE090B.Text = (Convert.ToInt32(C1BE090B.Text) + ((int_0 == -1) ? 1 : int_0)).ToString();
		}

		internal void method_0()
		{
			Application.DoEvents();
			C1BE090B.Text = (Convert.ToInt32(C1BE090B.Text) + int_0).ToString();
		}
	}

	public bool bool_0 = false;

	public int int_0 = -1;

	public bool bool_1 = false;

	private List<ComboBox> list_0;

	private int int_1 = 0;

	private List<string> CB82B986 = new List<string>();

	private List<Thread> list_1 = null;

	private object object_0 = new object();

	private List<string> E3AA909C = new List<string>();

	private string B0B6EA3B = GClass28.smethod_0() + "\\settings\\inputformat.txt";

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Button btnAdd;

	private Button D90BDC2C;

	private Label lblSuccess;

	private Label EE2F529D;

	private Label lblTotal;

	private Label label3;

	private Label E2111F0F;

	private Label FFA58EA5;

	private Label CF1A430E;

	private Label label8;

	private ComboBox cbbDinhDangNhap;

	private ComboBox cbbDinhDang1;

	private Label label9;

	private ComboBox cbbDinhDang2;

	private Label BB9AFF91;

	private ComboBox B7921518;

	private Label label11;

	private ComboBox C630AE0C;

	private Label B6202296;

	private ComboBox cbbDinhDang5;

	private Label label13;

	private ComboBox cbbDinhDang6;

	private Label label14;

	private ComboBox cbbDinhDang7;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel plDinhDangNhap;

	private PictureBox CC3567A1;

	private Label DA24193B;

	private ComboBox cbbThuMuc;

	private Button button1;

	private RichTextBox txbAccount;

	private Label label18;

	private Label F7029E01;

	private ComboBox cbbDinhDang8;

	private ComboBox B8185333;

	private Button F8A2C734;

	private Button E79701A2;

	private Label label19;

	private Label label1;

	private ComboBox cbbDinhDang10;

	private ComboBox D1BABF1E;

	private Panel pnlHeader;

	private Button btnMinimize;

	private BunifuCustomLabel A2A5E905;

	private Button metroButton1;

	private Button CF1FA11F;

	private Panel E095F13C;

	private CheckBox C4040892;

	public CDB179A2(string BB0C2C83)
	{
		AD09B689();
		F7AB102E.D6B70A35(this);
		method_1();
		if (BB0C2C83 != "" && BB0C2C83 != "-2" && BB0C2C83 != "999999")
		{
			cbbThuMuc.SelectedValue = BB0C2C83;
		}
		cbbDinhDangNhap.SelectedIndex = 0;
		bool_1 = false;
		bool_0 = false;
		int_0 = -1;
		method_0();
	}

	private void method_0()
	{
		list_0 = new List<ComboBox>
		{
			cbbDinhDang1, cbbDinhDang2, B7921518, C630AE0C, cbbDinhDang5, cbbDinhDang6, cbbDinhDang7, cbbDinhDang8, B8185333, cbbDinhDang10,
			D1BABF1E
		};
		foreach (ComboBox item in list_0)
		{
			GClass8.smethod_22(item, new List<string>
			{
				"", "Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy",
				"Birthday", "Bạn bè", "Ngày tạo", "Mail khôi phục", "Pass mail khôi phục", "Ghi chú", "Location", "Refresh_token", "Client_id"
			});
			item.SelectedIndex = -1;
			item.DropDownWidth = 100;
		}
	}

	private void method_1()
	{
		int_1 = cbbThuMuc.SelectedIndex;
		DataTable dataTable = Class15.smethod_1();
		if (dataTable.Rows.Count > 0)
		{
			cbbThuMuc.DataSource = dataTable;
			cbbThuMuc.ValueMember = "id";
			cbbThuMuc.DisplayMember = "name";
			if (int_1 == -1)
			{
				int_1 = 0;
			}
			cbbThuMuc.SelectedIndex = int_1;
		}
	}

	private void D90BDC2C_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txbAccount.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			if (e03C713E.Count == 0)
			{
				GClass29.smethod_0(F7AB102E.smethod_0("Vui lòng nhâ\u0323p thông tin ta\u0300i khoa\u0309n!"), 3);
				txbAccount.Focus();
				return;
			}
			if (cbbThuMuc.SelectedValue == null)
			{
				GClass29.smethod_0(F7AB102E.smethod_0("Vui lòng cho\u0323n thư mu\u0323c!"), 3);
				return;
			}
			string string_0 = cbbThuMuc.SelectedValue.ToString();
			bool bool_0 = C4040892.Checked;
			string text = cbbDinhDangNhap.Text;
			if (cbbDinhDangNhap.SelectedIndex != cbbDinhDangNhap.Items.Count - 1)
			{
				goto IL_0172;
			}
			bool flag = false;
			for (int i = 0; i < list_0.Count; i++)
			{
				if (list_0[i].SelectedIndex > 0)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				GClass29.smethod_0("Vui lo\u0300ng cho\u0323n đi\u0323nh da\u0323ng ta\u0300i khoa\u0309n!", 3);
				return;
			}
			text = "";
			for (int j = 0; j < list_0.Count; j++)
			{
				text = text + list_0[j].Text + "|";
			}
			text = text.TrimEnd('|');
			goto IL_0172;
			IL_0172:
			if (text == "")
			{
				GClass29.smethod_0("Vui lo\u0300ng cho\u0323n đi\u0323nh da\u0323ng ta\u0300i khoa\u0309n!");
				return;
			}
			int B4AB6620 = 100;
			if (e03C713E.Count < 100)
			{
				B4AB6620 = e03C713E.Count;
			}
			lblSuccess.Text = "0";
			EE2F529D.Text = "0";
			CB82B986 = new List<string>();
			List<string> list = text.Split('|').ToList();
			for (int k = 0; k < e03C713E.Count; k++)
			{
				string[] array = e03C713E[k].Split('|');
				try
				{
					string text2 = "";
					string text3 = "";
					string text4 = "";
					string text5 = "";
					string text6 = "";
					string text7 = "";
					string text8 = "";
					string text9 = "";
					string text10 = "";
					string text11 = "";
					string text12 = "";
					string text13 = "";
					string text14 = "";
					string text15 = "";
					string text16 = "";
					string text17 = "";
					string text18 = "";
					string text19 = "";
                    for (int l = 0; l < list.Count; l++)
                    {
                        string text21 = list[l];
                        switch (text21)
                        {
                            case "Client_id":
                                text19 = array[l];
                                break;
                            case "Ghi chú":
                            case "Note":
                                text16 = array[l];
                                break;
                            case "Proxy":
                                if (!string.IsNullOrWhiteSpace(array[l]))
                                {
                                    text10 = array[l] + "*0";
                                }
                                break;
                            case "Email":
                                text6 = array[l];
                                break;
                            case "Token":
                                text4 = array[l];
                                break;
                            case "Friends":
                            case "Bạn bè":
                                text12 = array[l];
                                break;
                            case "Location":
                                text17 = array[l];
                                break;
                            case "Email recover":
                                text15 = array[l];
                                break;
                            case "2FA":
                                text8 = array[l];
                                break;
                            case "Mail khôi phục":
                            case "Pass mail khôi phục":
                            case "Pass mail recover":
                                text14 = array[l];
                                break;
                            case "Cookie":
                                text5 = array[l];
                                break;
                            case "Ngày tạo":
                            case "Date created":
                                text13 = array[l];
                                break;
                            case "Ngày sinh":
                            case "Birthday":
                                text11 = array[l];
                                break;
                            case "Uid":
                                text2 = array[l];
                                break;
                            case "Useragent":
                                text9 = array[l];
                                break;
                            case "Pass Email":
                                text7 = array[l].Replace("'", "''");
                                break;
                            case "Pass":
                                text3 = array[l].Replace("'", "''");
                                break;
                            case "Refresh_token":
                                text18 = array[l];
                                break;
                            default:
                                // Không xử lý các trường hợp không khớp
                                break;
                        }
                    }

                    CB82B986.Add(text2 + "|" + text3 + "|" + text4 + "|" + text5 + "|" + text6 + "|" + text7 + "|" + text8 + "|" + text9 + "|" + text10 + "|" + text11 + "|" + text12 + "|" + text13 + "|" + text14 + "|" + text15 + "|" + text16 + "|" + text17 + "|" + text18 + "|" + text19);
				}
				catch
				{
					method_3(EE2F529D);
				}
			}
			List<string> C31CDBB1 = new List<string>();
			list_1 = new List<Thread>();
			new Thread((ThreadStart)delegate
			{
				try
				{
					btnAdd.Invoke((MethodInvoker)delegate
					{
						btnAdd.Enabled = false;
					});
					ADB5D5B6(F7AB102E.smethod_0("Chuẩn bị thêm tài khoản..."), CF1A430E);
					if (bool_0)
					{
						int num2 = 0;
						while (num2 < CB82B986.Count)
						{
							if (list_1.Count < B4AB6620)
							{
								int int_0 = num2++;
								ADB5D5B6($"Check info {int_0 + 1}/{CB82B986.Count}...", CF1A430E);
								Thread thread = new Thread((ThreadStart)delegate
								{
									try
									{
										string text24 = CB82B986[int_0];
										if (text24 != "")
										{
											string text25 = method_2(string_0, text24, bool_0);
											if (text25 != "")
											{
												lock (C31CDBB1)
												{
													C31CDBB1.Add(text25);
												}
											}
										}
									}
									catch (Exception)
									{
									}
								});
								list_1.Add(thread);
								thread.Start();
							}
							else
							{
								for (int m = 0; m < list_1.Count; m++)
								{
									if (!list_1[m].IsAlive)
									{
										list_1.RemoveAt(m--);
									}
								}
							}
						}
						for (int n = 0; n < list_1.Count; n++)
						{
							list_1[n].Join();
						}
					}
					else
					{
						for (int num3 = 0; num3 < CB82B986.Count; num3++)
						{
							try
							{
								string text22 = CB82B986[num3];
								if (text22 != "")
								{
									string text23 = method_2(string_0, text22, bool_0);
									if (text23 != "")
									{
										C31CDBB1.Add(text23);
									}
								}
							}
							catch
							{
							}
						}
					}
					ADB5D5B6(F7AB102E.smethod_0("Đang thêm tài khoản..."), CF1A430E);
					if (C31CDBB1.Count >= 0)
					{
						C31CDBB1 = Class15.smethod_8(C31CDBB1);
						for (int num4 = 0; num4 < C31CDBB1.Count; num4++)
						{
							method_3(lblSuccess, Class53.smethod_1(C31CDBB1[num4]));
						}
					}
					ADB5D5B6((Convert.ToInt32(lblTotal.Text) - Convert.ToInt32(lblSuccess.Text)).ToString() ?? "", EE2F529D);
					btnAdd.C22B543F();
					ADB5D5B6(F7AB102E.smethod_0("Thêm tài khoản thành công!"), CF1A430E);
					GClass29.smethod_0("Thêm tài khoản thành công!");
					this.bool_0 = true;
					this.int_0 = Convert.ToInt32(string_0);
				}
				catch (Exception f4295AA2)
				{
					GClass8.BFBDF687(null, f4295AA2, "AddAccount");
				}
			}).Start();
		}
		catch (Exception f4295AA)
		{
			GClass29.smethod_0("Đa\u0303 co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			GClass8.BFBDF687(null, f4295AA, "AddAccount");
		}
	}

	private string method_2(string string_0, string E53FE826, bool EB982D81)
	{
		try
		{
			string[] array = E53FE826.Split('|');
			string text = array[0];
			string string_ = array[1];
			string b4AD46B = array[2];
			string text2 = array[3];
			string string_2 = array[4];
			string string_3 = array[5];
			string string_4 = array[6];
			string c531A = array[7];
			string string_5 = array[8];
			string fA83289E = array[9];
			string string_6 = array[10];
			string eB320F = array[11];
			string string_7 = array[12];
			string b717ADAF = array[13];
			string string_8 = "";
			string string_9 = "";
			string cA06689F = "";
			string string_10 = "unknow";
			string string_11 = array[14];
			string string_12 = array[15];
			string string_13 = (array[16] + "|" + array[17]).Trim('|');
			if (text == "")
			{
				text = Regex.Match(text2, "c_user=(\\d+)").Groups[1].Value;
			}
			if (EB982D81 && text != "")
			{
				string text3 = Class14.A61BB104(text);
				if (text3.StartsWith("0|"))
				{
					if (Class14.EABAA59C(text).StartsWith("0|"))
					{
						string_10 = "Die";
					}
				}
				else if (text3.StartsWith("1|"))
				{
					string[] array2 = text3.Split('|');
					string_8 = array2[1];
					string_6 = array2[2];
					eB320F = array2[3];
					string_10 = "Live";
				}
			}
			return Class15.smethod_9(text, string_, b4AD46B, text2, string_2, string_8, string_6, string_9, fA83289E, cA06689F, string_10, string_4, string_0, string_3, c531A, string_5, eB320F, string_7, b717ADAF, string_11, string_12, string_13);
		}
		catch (Exception)
		{
		}
		return "";
	}

	private void ADB5D5B6(string string_0, Label EB84E6A3)
	{
		EB84E6A3.Invoke((MethodInvoker)delegate
		{
			Application.DoEvents();
			EB84E6A3.Text = string_0;
		});
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetFormatInput(byte[] byte_0);

	public static string smethod_0(string string_0)
	{
		string text = GClass8.smethod_10(GetFormatInput(GClass8.smethod_11(string_0)));
		if (Class57.smethod_2() == "VN")
		{
			text = text.Replace("Email recover", "Mail khôi phục");
		}
		return text;
	}

	private void txbAccount_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txbAccount.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			lblTotal.Text = e03C713E.Count.ToString();
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			int num = e03C713E.Count;
			if (num > 10)
			{
				num = 10;
			}
			for (int i = 0; i < num; i++)
			{
				string string_ = e03C713E[i];
				list2 = smethod_0(string_).Split('|').ToList();
				if (list.Count == 0)
				{
					list = new List<string>(list2);
				}
				else
				{
					if (list.Count < list2.Count)
					{
						_ = list.Count;
					}
					else
						_ = list2.Count;
					for (int j = 0; j < list.Count; j++)
					{
						if (list[j] == "" && list2[j] != "")
						{
							list[j] = list2[j];
						}
					}
				}
				if (!list.Contains(""))
				{
					break;
				}
			}
			C2041319(list);
		}
		catch
		{
		}
	}

	private void C2041319(List<string> list_2)
	{
		string item = string.Join("|", list_2);
		if (E3AA909C.Contains(item))
		{
			cbbDinhDangNhap.Text = item;
			return;
		}
		cbbDinhDangNhap.SelectedIndex = cbbDinhDangNhap.Items.Count - 1;
		int num = ((list_2.Count < list_0.Count) ? list_2.Count : list_0.Count);
		for (int i = 0; i < num; i++)
		{
			list_0[i].Text = list_2[i];
		}
		for (int j = num; j < list_0.Count; j++)
		{
			list_0[j].Text = "";
		}
	}

	private void method_3(Label label_0, int A4351C2F = -1)
	{
		if (A4351C2F == -1)
		{
			label_0.Invoke((MethodInvoker)delegate
			{
				Application.DoEvents();
				label_0.Text = (Convert.ToInt32(label_0.Text) + ((A4351C2F == -1) ? 1 : A4351C2F)).ToString();
			});
		}
		else
		{
			label_0.Invoke((MethodInvoker)delegate
			{
				Application.DoEvents();
				label_0.Text = (Convert.ToInt32(label_0.Text) + A4351C2F).ToString();
			});
		}
	}

	private void cbbDinhDangNhap_SelectedIndexChanged(object sender, EventArgs e)
	{
		plDinhDangNhap.Visible = cbbDinhDangNhap.SelectedIndex == cbbDinhDangNhap.Items.Count - 1;
		if (plDinhDangNhap.Visible)
		{
			AF15B6B5();
		}
	}

	private void B024EDAF(object sender, EventArgs e)
	{
		fAddFile form_ = new fAddFile();
		GClass8.smethod_33(form_);
		if (fAddFile.C13CD985)
		{
			method_1();
			cbbThuMuc.SelectedIndex = cbbThuMuc.Items.Count - 1;
			bool_1 = true;
		}
	}

	private bool method_4()
	{
		return false;
	}

	private void C32657BF(object sender, EventArgs e)
	{
		if (method_4())
		{
			GClass29.smethod_0("Tu\u0300y cho\u0323n na\u0300y đa\u0303 tô\u0300n ta\u0323i, vui lo\u0300ng cho\u0323n tu\u0300y cho\u0323n kha\u0301c!", 3);
			(sender as ComboBox).SelectedIndex = -1;
		}
	}

	private void cbbThuMuc_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void F8A2C734_Click(object sender, EventArgs e)
	{
		method_5();
	}

	private void DF383B80(object sender, EventArgs e)
	{
		CE8C02A0();
	}

	private void method_5()
	{
		try
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				list_0[i].SelectedIndex = -1;
			}
		}
		catch
		{
		}
	}

	private void CE8C02A0()
	{
		try
		{
			string text = "";
			for (int i = 0; i < list_0.Count; i++)
			{
				text = text + list_0[i].SelectedIndex + "|";
			}
			text = text.TrimEnd('|');
			GClass25.smethod_0("configFormat").method_4("pasteFormat", text);
			GClass25.smethod_0("configFormat").method_6();
		}
		catch
		{
		}
	}

	private void AF15B6B5()
	{
		try
		{
			string text = GClass25.smethod_0("configFormat").C0288288("pasteFormat");
			if (text != "")
			{
				for (int i = 0; i < list_0.Count; i++)
				{
					list_0[i].SelectedIndex = Convert.ToInt32(text.Split('|')[i]);
				}
			}
		}
		catch
		{
		}
	}

	private void CF1FA11F_Click(object sender, EventArgs e)
	{
		AAADE329 aAADE = new AAADE329();
		GClass8.smethod_33(aAADE);
		string text = aAADE.string_0.Trim();
		if (text != "" && !E3AA909C.Contains(text))
		{
			E3AA909C.Add(text);
			File.WriteAllLines(B0B6EA3B, E3AA909C);
			method_6();
			cbbDinhDangNhap.SelectedIndex = cbbDinhDangNhap.Items.Count - 2;
		}
	}

	private void metroButton1_Click(object sender, EventArgs e)
	{
		int selectedIndex = cbbDinhDangNhap.SelectedIndex;
		if (selectedIndex != -1 && selectedIndex != cbbDinhDangNhap.Items.Count - 1)
		{
			string text = cbbDinhDangNhap.Text;
			if (GClass29.smethod_1(string.Format(F7AB102E.smethod_0("Ba\u0323n co\u0301 muô\u0301n xóa định dạng \"{0}\"?"), text)) == DialogResult.Yes)
			{
				E3AA909C.Remove(text);
				File.WriteAllLines(B0B6EA3B, E3AA909C);
				method_6();
				cbbDinhDangNhap.SelectedIndex = ((selectedIndex != 0 || cbbDinhDangNhap.Items.Count <= 0) ? (selectedIndex - 1) : 0);
			}
		}
		else
		{
			GClass29.smethod_0("Không thể xóa định dạng này!", 3);
		}
	}

	private void D62532BF(object sender, EventArgs e)
	{
		GClass8.smethod_31(B0B6EA3B);
		E3AA909C = File.ReadAllText(B0B6EA3B).Split(new string[2] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
		if (E3AA909C.Count == 0)
		{
			E3AA909C = new List<string> { "Uid|Pass|2FA", "Cookie", "Uid|Pass", "Uid|Pass|Token|Cookie", "Uid|Pass|Token|Cookie|Email|Pass Email", "Uid|Pass|Token|Cookie|Email|Pass Email|2FA" };
		}
		method_6();
	}

	private void method_6()
	{
		cbbDinhDangNhap.Items.Clear();
		for (int i = 0; i < E3AA909C.Count; i++)
		{
			cbbDinhDangNhap.Items.Add(E3AA909C[i]);
		}
		cbbDinhDangNhap.Items.Add("Other...");
		cbbDinhDangNhap.SelectedIndex = 0;
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void AD09B689()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(CDB179A2));
		bunifuCards1 = new BunifuCards();
		pnlHeader = new Panel();
		CC3567A1 = new PictureBox();
		btnMinimize = new Button();
		A2A5E905 = new BunifuCustomLabel();
		btnAdd = new Button();
		D90BDC2C = new Button();
		lblSuccess = new Label();
		EE2F529D = new Label();
		lblTotal = new Label();
		label3 = new Label();
		E2111F0F = new Label();
		FFA58EA5 = new Label();
		CF1A430E = new Label();
		label8 = new Label();
		cbbDinhDangNhap = new ComboBox();
		cbbDinhDang1 = new ComboBox();
		label9 = new Label();
		cbbDinhDang2 = new ComboBox();
		BB9AFF91 = new Label();
		B7921518 = new ComboBox();
		label11 = new Label();
		C630AE0C = new ComboBox();
		B6202296 = new Label();
		cbbDinhDang5 = new ComboBox();
		label13 = new Label();
		cbbDinhDang6 = new ComboBox();
		label14 = new Label();
		cbbDinhDang7 = new ComboBox();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		bunifuDragControl_1 = new BunifuDragControl(icontainer_0);
		plDinhDangNhap = new Panel();
		F8A2C734 = new Button();
		E79701A2 = new Button();
		label19 = new Label();
		label18 = new Label();
		label1 = new Label();
		cbbDinhDang10 = new ComboBox();
		F7029E01 = new Label();
		cbbDinhDang8 = new ComboBox();
		D1BABF1E = new ComboBox();
		B8185333 = new ComboBox();
		DA24193B = new Label();
		cbbThuMuc = new ComboBox();
		button1 = new Button();
		txbAccount = new RichTextBox();
		metroButton1 = new Button();
		CF1FA11F = new Button();
		E095F13C = new Panel();
		C4040892 = new CheckBox();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)CC3567A1).BeginInit();
		plDinhDangNhap.SuspendLayout();
		E095F13C.SuspendLayout();
		SuspendLayout();
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
		bunifuCards1.Size = new Size(1142, 37);
		bunifuCards1.TabIndex = 11;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(CC3567A1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(A2A5E905);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(1142, 31);
		pnlHeader.TabIndex = 9;
		CC3567A1.Cursor = Cursors.Default;
		CC3567A1.Image = C50FB39E.Bitmap_5;
		CC3567A1.Location = new Point(3, 2);
		CC3567A1.Name = "pictureBox1";
		CC3567A1.Size = new Size(34, 27);
		CC3567A1.SizeMode = PictureBoxSizeMode.Zoom;
		CC3567A1.TabIndex = 76;
		CC3567A1.TabStop = false;
		btnMinimize.Anchor = AnchorStyles.Right;
		btnMinimize.Cursor = Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = FlatStyle.Flat;
		btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = Color.White;
		btnMinimize.Image = (Image)componentResourceManager.GetObject("btnMinimize.Image");
		btnMinimize.Location = new Point(1110, 2);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new Size(30, 30);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += D90BDC2C_Click;
		A2A5E905.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		A2A5E905.BackColor = Color.Transparent;
		A2A5E905.Cursor = Cursors.SizeAll;
		A2A5E905.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		A2A5E905.ForeColor = Color.Black;
		A2A5E905.Location = new Point(0, 0);
		A2A5E905.Name = "bunifuCustomLabel1";
		A2A5E905.Size = new Size(1104, 31);
		A2A5E905.TabIndex = 12;
		A2A5E905.Text = "Nhập Tài Khoản";
		A2A5E905.TextAlign = ContentAlignment.MiddleCenter;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(459, 480);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(107, 31);
		btnAdd.TabIndex = 13;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		D90BDC2C.Anchor = AnchorStyles.Bottom;
		D90BDC2C.BackColor = Color.Maroon;
		D90BDC2C.Cursor = Cursors.Hand;
		D90BDC2C.FlatAppearance.BorderSize = 0;
		D90BDC2C.FlatStyle = FlatStyle.Flat;
		D90BDC2C.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		D90BDC2C.ForeColor = Color.White;
		D90BDC2C.Location = new Point(573, 480);
		D90BDC2C.Name = "btnCancel";
		D90BDC2C.Size = new Size(107, 31);
		D90BDC2C.TabIndex = 14;
		D90BDC2C.Text = "Đo\u0301ng";
		D90BDC2C.UseVisualStyleBackColor = false;
		D90BDC2C.Click += D90BDC2C_Click;
		lblSuccess.AutoSize = true;
		lblSuccess.BackColor = SystemColors.Control;
		lblSuccess.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		lblSuccess.ForeColor = Color.FromArgb(53, 120, 229);
		lblSuccess.Location = new Point(106, 51);
		lblSuccess.Name = "lblSuccess";
		lblSuccess.Size = new Size(19, 19);
		lblSuccess.TabIndex = 23;
		lblSuccess.Text = "0";
		EE2F529D.AutoSize = true;
		EE2F529D.BackColor = SystemColors.Control;
		EE2F529D.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		EE2F529D.ForeColor = Color.FromArgb(192, 64, 0);
		EE2F529D.Location = new Point(528, 51);
		EE2F529D.Name = "lblError";
		EE2F529D.Size = new Size(19, 19);
		EE2F529D.TabIndex = 24;
		EE2F529D.Text = "0";
		lblTotal.AutoSize = true;
		lblTotal.BackColor = SystemColors.Control;
		lblTotal.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		lblTotal.ForeColor = Color.Teal;
		lblTotal.Location = new Point(910, 51);
		lblTotal.Name = "lblTotal";
		lblTotal.Size = new Size(19, 19);
		lblTotal.TabIndex = 26;
		lblTotal.Text = "0";
		label3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 163);
		label3.Location = new Point(22, 53);
		label3.Name = "label3";
		label3.RightToLeft = RightToLeft.No;
		label3.Size = new Size(87, 16);
		label3.TabIndex = 34;
		label3.Text = "Tha\u0300nh công:";
		label3.TextAlign = ContentAlignment.MiddleRight;
		E2111F0F.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 163);
		E2111F0F.Location = new Point(480, 53);
		E2111F0F.Name = "label4";
		E2111F0F.RightToLeft = RightToLeft.No;
		E2111F0F.Size = new Size(52, 16);
		E2111F0F.TabIndex = 35;
		E2111F0F.Text = "Lỗi:";
		E2111F0F.TextAlign = ContentAlignment.MiddleRight;
		FFA58EA5.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 163);
		FFA58EA5.Location = new Point(851, 53);
		FFA58EA5.Name = "label7";
		FFA58EA5.RightToLeft = RightToLeft.No;
		FFA58EA5.Size = new Size(63, 16);
		FFA58EA5.TabIndex = 38;
		FFA58EA5.Text = "Tô\u0309ng sô\u0301:";
		FFA58EA5.TextAlign = ContentAlignment.MiddleRight;
		CF1A430E.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		CF1A430E.Location = new Point(12, 86);
		CF1A430E.Name = "lblStatus";
		CF1A430E.Size = new Size(1023, 28);
		CF1A430E.TabIndex = 27;
		CF1A430E.TextAlign = ContentAlignment.MiddleCenter;
		label8.AutoSize = true;
		label8.Location = new Point(12, 397);
		label8.Name = "label8";
		label8.Size = new Size(102, 16);
		label8.TabIndex = 39;
		label8.Text = "Định dạng nhập:";
		cbbDinhDangNhap.Cursor = Cursors.Hand;
		cbbDinhDangNhap.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbDinhDangNhap.FormattingEnabled = true;
		cbbDinhDangNhap.Items.AddRange(new object[7] { "Uid|Pass|2FA", "Cookie", "Uid|Pass", "Uid|Pass|Token|Cookie", "Uid|Pass|Token|Cookie|Email|Pass Email", "Uid|Pass|Token|Cookie|Email|Pass Email|2FA", "Other..." });
		cbbDinhDangNhap.Location = new Point(115, 394);
		cbbDinhDangNhap.Name = "cbbDinhDangNhap";
		cbbDinhDangNhap.Size = new Size(269, 24);
		cbbDinhDangNhap.TabIndex = 40;
		cbbDinhDangNhap.SelectedIndexChanged += cbbDinhDangNhap_SelectedIndexChanged;
		cbbDinhDang1.Cursor = Cursors.Hand;
		cbbDinhDang1.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbDinhDang1.DropDownWidth = 100;
		cbbDinhDang1.FormattingEnabled = true;
		cbbDinhDang1.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		cbbDinhDang1.Location = new Point(3, 3);
		cbbDinhDang1.Name = "cbbDinhDang1";
		cbbDinhDang1.Size = new Size(78, 24);
		cbbDinhDang1.TabIndex = 40;
		cbbDinhDang1.SelectedIndexChanged += C32657BF;
		label9.AutoSize = true;
		label9.Font = new Font("Tahoma", 12f);
		label9.Location = new Point(81, 3);
		label9.Name = "label9";
		label9.Size = new Size(15, 19);
		label9.TabIndex = 41;
		label9.Text = "|";
		cbbDinhDang2.Cursor = Cursors.Hand;
		cbbDinhDang2.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbDinhDang2.DropDownWidth = 100;
		cbbDinhDang2.FormattingEnabled = true;
		cbbDinhDang2.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		cbbDinhDang2.Location = new Point(96, 3);
		cbbDinhDang2.Name = "cbbDinhDang2";
		cbbDinhDang2.Size = new Size(78, 24);
		cbbDinhDang2.TabIndex = 40;
		cbbDinhDang2.SelectedIndexChanged += C32657BF;
		BB9AFF91.AutoSize = true;
		BB9AFF91.Font = new Font("Tahoma", 12f);
		BB9AFF91.Location = new Point(174, 3);
		BB9AFF91.Name = "label10";
		BB9AFF91.Size = new Size(15, 19);
		BB9AFF91.TabIndex = 41;
		BB9AFF91.Text = "|";
		B7921518.Cursor = Cursors.Hand;
		B7921518.DropDownStyle = ComboBoxStyle.DropDownList;
		B7921518.DropDownWidth = 100;
		B7921518.FormattingEnabled = true;
		B7921518.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		B7921518.Location = new Point(189, 3);
		B7921518.Name = "cbbDinhDang3";
		B7921518.Size = new Size(78, 24);
		B7921518.TabIndex = 40;
		B7921518.SelectedIndexChanged += C32657BF;
		label11.AutoSize = true;
		label11.Font = new Font("Tahoma", 12f);
		label11.Location = new Point(267, 3);
		label11.Name = "label11";
		label11.Size = new Size(15, 19);
		label11.TabIndex = 41;
		label11.Text = "|";
		C630AE0C.Cursor = Cursors.Hand;
		C630AE0C.DropDownStyle = ComboBoxStyle.DropDownList;
		C630AE0C.DropDownWidth = 100;
		C630AE0C.FormattingEnabled = true;
		C630AE0C.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		C630AE0C.Location = new Point(282, 3);
		C630AE0C.Name = "cbbDinhDang4";
		C630AE0C.Size = new Size(78, 24);
		C630AE0C.TabIndex = 40;
		C630AE0C.SelectedIndexChanged += C32657BF;
		B6202296.AutoSize = true;
		B6202296.Font = new Font("Tahoma", 12f);
		B6202296.Location = new Point(360, 3);
		B6202296.Name = "label12";
		B6202296.Size = new Size(15, 19);
		B6202296.TabIndex = 41;
		B6202296.Text = "|";
		cbbDinhDang5.Cursor = Cursors.Hand;
		cbbDinhDang5.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbDinhDang5.DropDownWidth = 100;
		cbbDinhDang5.FormattingEnabled = true;
		cbbDinhDang5.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		cbbDinhDang5.Location = new Point(375, 3);
		cbbDinhDang5.Name = "cbbDinhDang5";
		cbbDinhDang5.Size = new Size(78, 24);
		cbbDinhDang5.TabIndex = 40;
		cbbDinhDang5.SelectedIndexChanged += C32657BF;
		label13.AutoSize = true;
		label13.Font = new Font("Tahoma", 12f);
		label13.Location = new Point(453, 3);
		label13.Name = "label13";
		label13.Size = new Size(15, 19);
		label13.TabIndex = 41;
		label13.Text = "|";
		cbbDinhDang6.Cursor = Cursors.Hand;
		cbbDinhDang6.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbDinhDang6.DropDownWidth = 100;
		cbbDinhDang6.FormattingEnabled = true;
		cbbDinhDang6.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		cbbDinhDang6.Location = new Point(468, 3);
		cbbDinhDang6.Name = "cbbDinhDang6";
		cbbDinhDang6.Size = new Size(78, 24);
		cbbDinhDang6.TabIndex = 40;
		cbbDinhDang6.SelectedIndexChanged += C32657BF;
		label14.AutoSize = true;
		label14.Font = new Font("Tahoma", 12f);
		label14.Location = new Point(546, 3);
		label14.Name = "label14";
		label14.Size = new Size(15, 19);
		label14.TabIndex = 41;
		label14.Text = "|";
		cbbDinhDang7.Cursor = Cursors.Hand;
		cbbDinhDang7.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbDinhDang7.DropDownWidth = 100;
		cbbDinhDang7.FormattingEnabled = true;
		cbbDinhDang7.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		cbbDinhDang7.Location = new Point(561, 3);
		cbbDinhDang7.Name = "cbbDinhDang7";
		cbbDinhDang7.Size = new Size(78, 24);
		cbbDinhDang7.TabIndex = 40;
		cbbDinhDang7.SelectedIndexChanged += C32657BF;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = A2A5E905;
		bunifuDragControl_0.Vertical = true;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		plDinhDangNhap.BorderStyle = BorderStyle.FixedSingle;
		plDinhDangNhap.Controls.Add(F8A2C734);
		plDinhDangNhap.Controls.Add(E79701A2);
		plDinhDangNhap.Controls.Add(cbbDinhDang1);
		plDinhDangNhap.Controls.Add(cbbDinhDang2);
		plDinhDangNhap.Controls.Add(B7921518);
		plDinhDangNhap.Controls.Add(C630AE0C);
		plDinhDangNhap.Controls.Add(label19);
		plDinhDangNhap.Controls.Add(label18);
		plDinhDangNhap.Controls.Add(label14);
		plDinhDangNhap.Controls.Add(cbbDinhDang5);
		plDinhDangNhap.Controls.Add(label1);
		plDinhDangNhap.Controls.Add(cbbDinhDang10);
		plDinhDangNhap.Controls.Add(F7029E01);
		plDinhDangNhap.Controls.Add(cbbDinhDang8);
		plDinhDangNhap.Controls.Add(label13);
		plDinhDangNhap.Controls.Add(D1BABF1E);
		plDinhDangNhap.Controls.Add(cbbDinhDang6);
		plDinhDangNhap.Controls.Add(B8185333);
		plDinhDangNhap.Controls.Add(B6202296);
		plDinhDangNhap.Controls.Add(cbbDinhDang7);
		plDinhDangNhap.Controls.Add(label11);
		plDinhDangNhap.Controls.Add(label9);
		plDinhDangNhap.Controls.Add(BB9AFF91);
		plDinhDangNhap.Location = new Point(115, 420);
		plDinhDangNhap.Name = "plDinhDangNhap";
		plDinhDangNhap.Size = new Size(1016, 32);
		plDinhDangNhap.TabIndex = 46;
		F8A2C734.BackColor = Color.DarkOrange;
		F8A2C734.Cursor = Cursors.Hand;
		F8A2C734.FlatAppearance.BorderSize = 0;
		F8A2C734.FlatStyle = FlatStyle.Flat;
		F8A2C734.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		F8A2C734.ForeColor = Color.White;
		F8A2C734.Location = new Point(379, 35);
		F8A2C734.Name = "button2";
		F8A2C734.Size = new Size(121, 29);
		F8A2C734.TabIndex = 43;
		F8A2C734.Text = "Reset định dạng";
		F8A2C734.UseVisualStyleBackColor = false;
		F8A2C734.Click += F8A2C734_Click;
		E79701A2.BackColor = Color.FromArgb(53, 120, 229);
		E79701A2.Cursor = Cursors.Hand;
		E79701A2.FlatAppearance.BorderSize = 0;
		E79701A2.FlatStyle = FlatStyle.Flat;
		E79701A2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		E79701A2.ForeColor = Color.White;
		E79701A2.Location = new Point(516, 35);
		E79701A2.Name = "button3";
		E79701A2.Size = new Size(120, 29);
		E79701A2.TabIndex = 42;
		E79701A2.Text = "Lưu định dạng";
		E79701A2.UseVisualStyleBackColor = false;
		E79701A2.Click += DF383B80;
		label19.AutoSize = true;
		label19.Font = new Font("Tahoma", 12f);
		label19.Location = new Point(919, 3);
		label19.Name = "label19";
		label19.Size = new Size(15, 19);
		label19.TabIndex = 41;
		label19.Text = "|";
		label18.AutoSize = true;
		label18.Font = new Font("Tahoma", 12f);
		label18.Location = new Point(732, 3);
		label18.Name = "label18";
		label18.Size = new Size(15, 19);
		label18.TabIndex = 41;
		label18.Text = "|";
		label1.AutoSize = true;
		label1.Font = new Font("Tahoma", 12f);
		label1.Location = new Point(826, 5);
		label1.Name = "label1";
		label1.Size = new Size(15, 19);
		label1.TabIndex = 41;
		label1.Text = "|";
		cbbDinhDang10.Cursor = Cursors.Hand;
		cbbDinhDang10.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbDinhDang10.DropDownWidth = 100;
		cbbDinhDang10.FormattingEnabled = true;
		cbbDinhDang10.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		cbbDinhDang10.Location = new Point(841, 3);
		cbbDinhDang10.Name = "cbbDinhDang10";
		cbbDinhDang10.Size = new Size(78, 24);
		cbbDinhDang10.TabIndex = 40;
		cbbDinhDang10.SelectedIndexChanged += C32657BF;
		F7029E01.AutoSize = true;
		F7029E01.Font = new Font("Tahoma", 12f);
		F7029E01.Location = new Point(639, 3);
		F7029E01.Name = "label17";
		F7029E01.Size = new Size(15, 19);
		F7029E01.TabIndex = 41;
		F7029E01.Text = "|";
		cbbDinhDang8.Cursor = Cursors.Hand;
		cbbDinhDang8.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbDinhDang8.DropDownWidth = 100;
		cbbDinhDang8.FormattingEnabled = true;
		cbbDinhDang8.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		cbbDinhDang8.Location = new Point(654, 3);
		cbbDinhDang8.Name = "cbbDinhDang8";
		cbbDinhDang8.Size = new Size(78, 24);
		cbbDinhDang8.TabIndex = 40;
		cbbDinhDang8.SelectedIndexChanged += C32657BF;
		D1BABF1E.Cursor = Cursors.Hand;
		D1BABF1E.DropDownStyle = ComboBoxStyle.DropDownList;
		D1BABF1E.DropDownWidth = 100;
		D1BABF1E.FormattingEnabled = true;
		D1BABF1E.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		D1BABF1E.Location = new Point(934, 3);
		D1BABF1E.Name = "cbbDinhDang11";
		D1BABF1E.Size = new Size(78, 24);
		D1BABF1E.TabIndex = 40;
		D1BABF1E.SelectedIndexChanged += C32657BF;
		B8185333.Cursor = Cursors.Hand;
		B8185333.DropDownStyle = ComboBoxStyle.DropDownList;
		B8185333.DropDownWidth = 100;
		B8185333.FormattingEnabled = true;
		B8185333.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		B8185333.Location = new Point(747, 3);
		B8185333.Name = "cbbDinhDang9";
		B8185333.Size = new Size(78, 24);
		B8185333.TabIndex = 40;
		B8185333.SelectedIndexChanged += C32657BF;
		DA24193B.AutoSize = true;
		DA24193B.Location = new Point(12, 368);
		DA24193B.Name = "label16";
		DA24193B.Size = new Size(92, 16);
		DA24193B.TabIndex = 39;
		DA24193B.Text = "Cho\u0323n thư mu\u0323c:";
		cbbThuMuc.Cursor = Cursors.Hand;
		cbbThuMuc.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbThuMuc.DropDownWidth = 269;
		cbbThuMuc.FormattingEnabled = true;
		cbbThuMuc.Location = new Point(115, 365);
		cbbThuMuc.Name = "cbbThuMuc";
		cbbThuMuc.Size = new Size(268, 24);
		cbbThuMuc.TabIndex = 40;
		cbbThuMuc.SelectedIndexChanged += cbbThuMuc_SelectedIndexChanged;
		button1.Cursor = Cursors.Hand;
		button1.Location = new Point(389, 364);
		button1.Name = "button1";
		button1.Size = new Size(58, 26);
		button1.TabIndex = 45;
		button1.Text = "Thêm";
		button1.UseVisualStyleBackColor = true;
		button1.Click += B024EDAF;
		txbAccount.BorderStyle = BorderStyle.FixedSingle;
		txbAccount.Location = new Point(13, 120);
		txbAccount.Name = "txbAccount";
		txbAccount.Size = new Size(1118, 238);
		txbAccount.TabIndex = 48;
		txbAccount.Text = "";
		txbAccount.WordWrap = false;
		txbAccount.TextChanged += txbAccount_TextChanged;
		metroButton1.BackgroundImage = C50FB39E.B22D2F19;
		metroButton1.BackgroundImageLayout = ImageLayout.None;
		metroButton1.Cursor = Cursors.Hand;
		metroButton1.FlatAppearance.BorderColor = Color.Silver;
		metroButton1.FlatStyle = FlatStyle.Flat;
		metroButton1.Location = new Point(421, 393);
		metroButton1.Name = "metroButton1";
		metroButton1.Size = new Size(25, 25);
		metroButton1.TabIndex = 50;
		metroButton1.Click += metroButton1_Click;
		CF1FA11F.BackgroundImage = (Image)componentResourceManager.GetObject("AddFileAccount.BackgroundImage");
		CF1FA11F.BackgroundImageLayout = ImageLayout.None;
		CF1FA11F.Cursor = Cursors.Hand;
		CF1FA11F.FlatAppearance.BorderColor = Color.Silver;
		CF1FA11F.FlatStyle = FlatStyle.Flat;
		CF1FA11F.Location = new Point(390, 393);
		CF1FA11F.Name = "AddFileAccount";
		CF1FA11F.Size = new Size(25, 25);
		CF1FA11F.TabIndex = 51;
		CF1FA11F.Click += CF1FA11F_Click;
		E095F13C.BorderStyle = BorderStyle.FixedSingle;
		E095F13C.Controls.Add(C4040892);
		E095F13C.Dock = DockStyle.Fill;
		E095F13C.Location = new Point(0, 0);
		E095F13C.Name = "panel1";
		E095F13C.Size = new Size(1143, 524);
		E095F13C.TabIndex = 52;
		C4040892.AutoSize = true;
		C4040892.Cursor = Cursors.Hand;
		C4040892.Location = new Point(12, 455);
		C4040892.Name = "ckbCheckThongTin";
		C4040892.Size = new Size(255, 20);
		C4040892.TabIndex = 0;
		C4040892.Text = "Check thông tin (Tên, Bạn bè, Ngày tạo)";
		C4040892.UseVisualStyleBackColor = true;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(1143, 524);
		base.Controls.Add(metroButton1);
		base.Controls.Add(CF1FA11F);
		base.Controls.Add(txbAccount);
		base.Controls.Add(plDinhDangNhap);
		base.Controls.Add(button1);
		base.Controls.Add(cbbThuMuc);
		base.Controls.Add(cbbDinhDangNhap);
		base.Controls.Add(DA24193B);
		base.Controls.Add(label8);
		base.Controls.Add(FFA58EA5);
		base.Controls.Add(E2111F0F);
		base.Controls.Add(label3);
		base.Controls.Add(CF1A430E);
		base.Controls.Add(lblTotal);
		base.Controls.Add(EE2F529D);
		base.Controls.Add(lblSuccess);
		base.Controls.Add(D90BDC2C);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		base.Controls.Add(E095F13C);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fImportAccount";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Nhập tài khoản";
		base.Load += D62532BF;
		bunifuCards1.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)CC3567A1).EndInit();
		plDinhDangNhap.ResumeLayout(performLayout: false);
		plDinhDangNhap.PerformLayout();
		E095F13C.ResumeLayout(performLayout: false);
		E095F13C.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	[CompilerGenerated]
	private void C62F8B3B()
	{
		btnAdd.Enabled = false;
	}
}
