using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class D9AAEB9A : Form
{
	[CompilerGenerated]
	private sealed class Class64
	{
		public Label B09D7E0C;

		internal void DABC258D()
		{
			int num = Convert.ToInt32(B09D7E0C.Text);
			B09D7E0C.Text = (num + 1).ToString();
		}
	}

	[CompilerGenerated]
	private sealed class Class65
	{
		public D9AAEB9A d9AAEB9A_0;

		public string F212B3A5;

		internal void BC26600B()
		{
			d9AAEB9A_0.lblStatus.Text = F212B3A5;
		}
	}

	public static bool bool_0;

	private List<ComboBox> list_0;

	private JArray E1BBED2C = new JArray();

	private List<string> list_1 = new List<string>();

	private List<string> list_2 = new List<string>();

	private List<string> C992DA0A = new List<string>();

	private List<string> list_3 = new List<string>();

	private IContainer icontainer_0 = null;

	private Button btnAdd;

	private Button A03562BF;

	private Label label8;

	private ComboBox E802642C;

	private BunifuDragControl F7BDAF8A;

	private BunifuDragControl bunifuDragControl_0;

	private RichTextBox txbAccount;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Panel pnlHeader;

	private BunifuCards bunifuCards1;

	private ContextMenuStrip ctmsAcc;

	private ToolStripMenuItem F5AD6813;

	private ToolStripMenuItem B39CBC0B;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem E92DF91A;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem D60B2326;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem E034F09C;

	private ToolStripMenuItem toolStripMenuItem_3;

	private Label label3;

	private Label lblSuccess;

	private Label lblError;

	private Label F4AEC30C;

	private Label label4;

	private Label label7;

	private Label lblStatus;

	private PictureBox B3380C3E;

	private Button btnMinimize;

	private PictureBox B5AB3F96;

	private Panel plDinhDangNhap;

	private Label C7BF3C2F;

	private ComboBox cbbDinhDang1;

	private ComboBox B09DD6A5;

	private ComboBox cbbDinhDang3;

	private ComboBox cbbDinhDang4;

	private Label label14;

	private ComboBox cbbDinhDang5;

	private Label B6846636;

	private ComboBox BF26B59A;

	private Label A1080583;

	private ComboBox cbbDinhDang6;

	private Label D8955880;

	private ComboBox cbbDinhDang7;

	private Label label11;

	private Label label9;

	private Label label10;

	private ComboBox AA044112;

	private Label label2;

	private Label DE285487;

	private ComboBox B4B75A2B;

	private Label label15;

	private ComboBox cbbDinhDang11;

	private Label label6;

	private ComboBox D8887010;

	private Label label16;

	private ComboBox B6021A83;

	public D9AAEB9A()
	{
		InitializeComponent();
		list_0 = new List<ComboBox>
		{
			cbbDinhDang1, B09DD6A5, cbbDinhDang3, cbbDinhDang4, cbbDinhDang5, cbbDinhDang6, cbbDinhDang7, BF26B59A, B4B75A2B, D8887010,
			cbbDinhDang11, B6021A83
		};
		bool_0 = false;
		F7AB102E.D6B70A35(this);
	}

	private void ED822B06(object sender, EventArgs e)
	{
		Close();
	}

	private void AABBE122(object sender, EventArgs e)
	{
		list_2 = new List<string>();
		C992DA0A = new List<string>();
		try
		{
			List<string> e03C713E = txbAccount.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			if (e03C713E.Count == 0)
			{
				GClass29.smethod_0("Vui lòng nhâ\u0323p thông tin ta\u0300i khoa\u0309n!");
				txbAccount.Focus();
				return;
			}
			string text = E802642C.Text;
			if (E802642C.SelectedIndex != E802642C.Items.Count - 1)
			{
				goto IL_0129;
			}
			bool flag = false;
			for (int i = 0; i < list_0.Count; i++)
			{
				if (list_0[i].SelectedIndex > -1)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				GClass29.smethod_0("Vui lo\u0300ng cho\u0323n đi\u0323nh da\u0323ng ta\u0300i khoa\u0309n!");
				return;
			}
			text = "Uid|";
			for (int j = 0; j < list_0.Count; j++)
			{
				text = text + list_0[j].Text + "|";
			}
			text = text.TrimEnd('|');
			goto IL_0129;
			IL_0129:
			lblSuccess.Text = "0";
			lblError.Text = "0";
			list_1 = new List<string>();
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
					string text20 = "";
					for (int l = 0; l < list.Count; l++)
					{
						string text21 = list[l];
						string text22 = text21;
						uint num = C43AF739.smethod_0(text22);
						if (num <= 2152741479u)
						{
							if (num <= 953496446)
							{
								if (num <= 747205759)
								{
									if (num != 339788125)
									{
										if (num != 746320690)
										{
											if (num != 747205759 || !(text22 == "Tương tác cuối"))
											{
												continue;
											}
											goto IL_0304;
										}
										if (!(text22 == "Giơ\u0301i ti\u0301nh"))
										{
											continue;
										}
										goto IL_04a5;
									}
									if (!(text22 == "Note"))
									{
										continue;
									}
								}
								else
								{
									if (num != 776692014)
									{
										if (num != 798471697)
										{
											if (num == 953496446 && text22 == "Client_id")
											{
												text20 = array[l];
											}
											continue;
										}
										if (!(text22 == "Last Interact"))
										{
											continue;
										}
										goto IL_0304;
									}
									if (!(text22 == "Ghi chú"))
									{
										continue;
									}
								}
								text17 = array[l];
								continue;
							}
							if (num <= 1335761915)
							{
								switch (num)
								{
								case 1335761915u:
									if (text22 == "Proxy" && array[l].Trim() != "")
									{
										text10 = array[l] + "*0";
									}
									break;
								case 1127555431u:
									if (text22 == "Email")
									{
										text6 = array[l];
									}
									break;
								case 976575442u:
									if (text22 == "Token")
									{
										text4 = array[l];
									}
									break;
								}
								continue;
							}
							if (num <= 1674345338)
							{
								if (num != 1439766491)
								{
									if (num != 1674345338 || !(text22 == "Friends"))
									{
										continue;
									}
									goto IL_063d;
								}
								if (!(text22 == "Email recover"))
								{
									continue;
								}
							}
							else
							{
								if (num != 1802569846)
								{
									if (num != 2152741479u || !(text22 == "Pass mail khôi phục"))
									{
										continue;
									}
									goto IL_067d;
								}
								if (!(text22 == "Mail khôi phục"))
								{
									continue;
								}
							}
							text15 = array[l];
							continue;
						}
						if (num <= 3243292492u)
						{
							if (num <= 2804681632u)
							{
								if (num == 2249983736u)
								{
									if (text22 == "2FA")
									{
										text8 = array[l];
									}
									continue;
								}
								if (num != 2589850865u)
								{
									if (num != 2804681632u || !(text22 == "Gender"))
									{
										continue;
									}
									goto IL_04a5;
								}
								if (!(text22 == "Ngày sinh"))
								{
									continue;
								}
							}
							else
							{
								if (num <= 3183131359u)
								{
									if (num != 2958674405u)
									{
										if (num == 3183131359u && text22 == "Cookie")
										{
											text5 = array[l];
										}
										continue;
									}
									if (!(text22 == "Ngày tạo"))
									{
										continue;
									}
									goto IL_05eb;
								}
								if (num == 3209957741u)
								{
									if (text22 == "Uid")
									{
										text2 = array[l];
									}
									continue;
								}
								if (num != 3243292492u || !(text22 == "Birthday"))
								{
									continue;
								}
							}
							text11 = array[l];
							continue;
						}
						if (num <= 3611366992u)
						{
							if (num != 3444637862u)
							{
								if (num != 3578917853u)
								{
									if (num == 3611366992u && text22 == "Pass Email")
									{
										text7 = array[l].Replace("'", "''");
									}
									continue;
								}
								if (!(text22 == "Date created"))
								{
									continue;
								}
								goto IL_05eb;
							}
							if (text22 == "Refresh_token")
							{
								text19 = array[l];
							}
							continue;
						}
						if (num <= 3763899592u)
						{
							if (num != 3646757383u)
							{
								if (num != 3763899592u || !(text22 == "Bạn bè"))
								{
									continue;
								}
								goto IL_063d;
							}
							if (text22 == "Useragent")
							{
								text9 = array[l];
							}
							continue;
						}
						if (num != 3797654840u)
						{
							if (num != 4067830019u || !(text22 == "Pass mail recover"))
							{
								continue;
							}
							goto IL_067d;
						}
						if (text22 == "Pass")
						{
							text3 = array[l].Replace("'", "''");
						}
						continue;
						IL_05eb:
						text14 = array[l];
						continue;
						IL_063d:
						text12 = array[l];
						continue;
						IL_04a5:
						text13 = array[l];
						continue;
						IL_067d:
						text16 = array[l];
						continue;
						IL_0304:
						text18 = array[l];
					}
					list_1.Add(text2 + "|" + text3 + "|" + text4 + "|" + text5 + "|" + text6 + "|" + text7 + "|" + text8 + "|" + text9 + "|" + text10 + "|" + text11 + "|" + text12 + "|" + text13 + "|" + text14 + "|" + text15 + "|" + text16 + "|" + text17 + "|" + text18 + "|" + text19 + "|" + text20);
					list_2.Add(e03C713E[k]);
					JObject jObject = Class15.B90DCC85(text2 + "|" + text3 + "|" + text4 + "|" + text5 + "|" + text6 + "|" + text7 + "|" + text8 + "|" + text9 + "|" + text10 + "|" + text11 + "|" + text12 + "|" + text13 + "|" + text14 + "|" + text15 + "|" + text16 + "|" + text17 + "|" + text18 + "|" + text19 + "|" + text20);
					if (jObject != null)
					{
						E1BBED2C.Add(jObject);
						continue;
					}
					method_1(lblError);
					C992DA0A.Add(e03C713E[k]);
				}
				catch
				{
					method_1(lblError);
					C992DA0A.Add(e03C713E[k]);
				}
			}
			btnAdd.C22B543F(bool_0: false);
			method_0(F7AB102E.smethod_0("Đang cập nhật dữ liệu..."));
			if (text.StartsWith("Email"))
			{
				if (Class15.smethod_5(E1BBED2C, "email"))
				{
					lblSuccess.smethod_0(E1BBED2C.Count.ToString());
				}
			}
			else if (Class15.smethod_5(E1BBED2C))
			{
				lblSuccess.smethod_0(E1BBED2C.Count.ToString());
			}
			btnAdd.C22B543F();
			method_0(F7AB102E.smethod_0("Cập nhật dữ liệu xong!"));
			GClass29.smethod_0("Cập nhật dữ liệu xong!");
			bool_0 = true;
		}
		catch (Exception exception_)
		{
			GClass29.smethod_0("Đa\u0303 co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!");
			GClass8.smethod_62(exception_, "UpdateAccount");
		}
	}

	private void method_0(string string_0)
	{
		Application.DoEvents();
		lblStatus.Invoke((MethodInvoker)delegate
		{
			lblStatus.Text = string_0;
		});
	}

	private void txbAccount_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txbAccount.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			F4AEC30C.Text = e03C713E.Count.ToString();
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
			F21C4B24(list);
		}
		catch
		{
		}
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

	private void F21C4B24(List<string> list_4)
	{
		list_4 = list_4.smethod_7();
		string item = string.Join("|", list_4);
		if (list_3.Contains(item))
		{
			E802642C.Text = item;
			return;
		}
		if (list_4.Count > 0 && list_4[0] == "Uid")
		{
			list_4.RemoveAt(0);
		}
		E802642C.SelectedIndex = E802642C.Items.Count - 1;
		int num = ((list_4.Count < list_0.Count) ? list_4.Count : list_0.Count);
		for (int i = 0; i < num; i++)
		{
			list_0[i].Text = list_4[i];
		}
		for (int j = num; j < list_0.Count; j++)
		{
			list_0[j].Text = "";
		}
	}

	private void method_1(Label B60DAEB1)
	{
		Application.DoEvents();
		lock (B60DAEB1)
		{
			B60DAEB1.Invoke((MethodInvoker)delegate
			{
				int num = Convert.ToInt32(B60DAEB1.Text);
				B60DAEB1.Text = (num + 1).ToString();
			});
		}
	}

	private void E802642C_SelectedIndexChanged(object sender, EventArgs e)
	{
		plDinhDangNhap.Visible = E802642C.SelectedIndex == E802642C.Items.Count - 1;
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void cbbDinhDang7_SelectedIndexChanged(object sender, EventArgs e)
	{
		bool visible = false;
		for (int i = 0; i < list_0.Count; i++)
		{
			if (list_0[i].Text == "Proxy")
			{
				visible = true;
				break;
			}
		}
		label2.Visible = visible;
		AA044112.Visible = visible;
	}

	private void CF3BD901(object sender, EventArgs e)
	{
		foreach (ComboBox item in list_0)
		{
			GClass8.smethod_22(item, new List<string>
			{
				"", "Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy",
				"Ngày sinh", "Bạn bè", "Giơ\u0301i ti\u0301nh", "Ngày tạo", "Mail khôi phục", "Pass mail khôi phục", "Ghi chú", "Tương tác cuối"
			});
			item.SelectedIndex = 0;
			item.DropDownWidth = 100;
		}
		AA044112.SelectedIndex = 0;
		list_3 = new List<string> { "Uid|Pass", "Uid|Pass|2FA", "Uid|Pass|Token|Cookie", "Uid|Pass|Token|Cookie|Email|Pass Email", "Uid|Pass|Token|Cookie|Email|Pass Email|2FA", "Email|Pass Email", "Email|Pass Email|Mail khôi phục", "Email|Pass Email|Mail khôi phục|Pass mail khôi phục", "Email|Refresh_token|Client_id", "Email|Pass Email|Refresh_token|Client_id" };
		C50767AF();
	}

	private void C50767AF()
	{
		E802642C.Items.Clear();
		for (int i = 0; i < list_3.Count; i++)
		{
			E802642C.Items.Add(list_3[i]);
		}
		E802642C.Items.Add("Other...");
		E802642C.SelectedIndex = 0;
	}

	protected override void Dispose(bool AA2CC61F)
	{
		if (AA2CC61F && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(AA2CC61F);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(D9AAEB9A));
		btnAdd = new System.Windows.Forms.Button();
		A03562BF = new System.Windows.Forms.Button();
		label8 = new System.Windows.Forms.Label();
		E802642C = new System.Windows.Forms.ComboBox();
		F7BDAF8A = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		B5AB3F96 = new System.Windows.Forms.PictureBox();
		B3380C3E = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		txbAccount = new System.Windows.Forms.RichTextBox();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		ctmsAcc = new System.Windows.Forms.ContextMenuStrip(icontainer_0);
		F5AD6813 = new System.Windows.Forms.ToolStripMenuItem();
		B39CBC0B = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		E92DF91A = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		D60B2326 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		E034F09C = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
		label3 = new System.Windows.Forms.Label();
		lblSuccess = new System.Windows.Forms.Label();
		lblError = new System.Windows.Forms.Label();
		F4AEC30C = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label7 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		plDinhDangNhap = new System.Windows.Forms.Panel();
		label16 = new System.Windows.Forms.Label();
		label15 = new System.Windows.Forms.Label();
		DE285487 = new System.Windows.Forms.Label();
		B6021A83 = new System.Windows.Forms.ComboBox();
		cbbDinhDang11 = new System.Windows.Forms.ComboBox();
		B4B75A2B = new System.Windows.Forms.ComboBox();
		AA044112 = new System.Windows.Forms.ComboBox();
		label2 = new System.Windows.Forms.Label();
		C7BF3C2F = new System.Windows.Forms.Label();
		cbbDinhDang1 = new System.Windows.Forms.ComboBox();
		B09DD6A5 = new System.Windows.Forms.ComboBox();
		cbbDinhDang3 = new System.Windows.Forms.ComboBox();
		cbbDinhDang4 = new System.Windows.Forms.ComboBox();
		label14 = new System.Windows.Forms.Label();
		cbbDinhDang5 = new System.Windows.Forms.ComboBox();
		label6 = new System.Windows.Forms.Label();
		B6846636 = new System.Windows.Forms.Label();
		D8887010 = new System.Windows.Forms.ComboBox();
		BF26B59A = new System.Windows.Forms.ComboBox();
		A1080583 = new System.Windows.Forms.Label();
		cbbDinhDang6 = new System.Windows.Forms.ComboBox();
		D8955880 = new System.Windows.Forms.Label();
		cbbDinhDang7 = new System.Windows.Forms.ComboBox();
		label11 = new System.Windows.Forms.Label();
		label9 = new System.Windows.Forms.Label();
		label10 = new System.Windows.Forms.Label();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)B5AB3F96).BeginInit();
		((System.ComponentModel.ISupportInitialize)B3380C3E).BeginInit();
		bunifuCards1.SuspendLayout();
		ctmsAcc.SuspendLayout();
		plDinhDangNhap.SuspendLayout();
		SuspendLayout();
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(482, 460);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(97, 31);
		btnAdd.TabIndex = 13;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(AABBE122);
		A03562BF.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		A03562BF.BackColor = System.Drawing.Color.Maroon;
		A03562BF.Cursor = System.Windows.Forms.Cursors.Hand;
		A03562BF.FlatAppearance.BorderSize = 0;
		A03562BF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A03562BF.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A03562BF.ForeColor = System.Drawing.Color.White;
		A03562BF.Location = new System.Drawing.Point(599, 460);
		A03562BF.Name = "btnCancel";
		A03562BF.Size = new System.Drawing.Size(97, 31);
		A03562BF.TabIndex = 14;
		A03562BF.Text = "Đo\u0301ng";
		A03562BF.UseVisualStyleBackColor = false;
		A03562BF.Click += new System.EventHandler(ED822B06);
		label8.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label8.Location = new System.Drawing.Point(9, 367);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(97, 14);
		label8.TabIndex = 39;
		label8.Text = "Chọn định dạng:";
		label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		E802642C.Cursor = System.Windows.Forms.Cursors.Hand;
		E802642C.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		E802642C.DropDownWidth = 320;
		E802642C.FormattingEnabled = true;
		E802642C.Location = new System.Drawing.Point(112, 364);
		E802642C.Name = "cbbDinhDangNhap";
		E802642C.Size = new System.Drawing.Size(269, 24);
		E802642C.TabIndex = 40;
		E802642C.SelectedIndexChanged += new System.EventHandler(E802642C_SelectedIndexChanged);
		F7BDAF8A.Fixed = true;
		F7BDAF8A.Horizontal = true;
		F7BDAF8A.TargetControl = bunifuCustomLabel1;
		F7BDAF8A.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(1179, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cập nhật dữ liệu";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(B5AB3F96);
		pnlHeader.Controls.Add(B3380C3E);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(1179, 31);
		pnlHeader.TabIndex = 9;
		B5AB3F96.Cursor = System.Windows.Forms.Cursors.Default;
		B5AB3F96.Image = C50FB39E.Bitmap_5;
		B5AB3F96.Location = new System.Drawing.Point(2, 3);
		B5AB3F96.Name = "pictureBox2";
		B5AB3F96.Size = new System.Drawing.Size(34, 27);
		B5AB3F96.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		B5AB3F96.TabIndex = 79;
		B5AB3F96.TabStop = false;
		B3380C3E.Cursor = System.Windows.Forms.Cursors.Default;
		B3380C3E.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		B3380C3E.Location = new System.Drawing.Point(-156, 2);
		B3380C3E.Name = "pictureBox1";
		B3380C3E.Size = new System.Drawing.Size(34, 27);
		B3380C3E.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		B3380C3E.TabIndex = 78;
		B3380C3E.TabStop = false;
		btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(1147, 1);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(30, 30);
		btnMinimize.TabIndex = 77;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		txbAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txbAccount.Location = new System.Drawing.Point(12, 77);
		txbAccount.Name = "txbAccount";
		txbAccount.Size = new System.Drawing.Size(1147, 277);
		txbAccount.TabIndex = 48;
		txbAccount.Text = "";
		txbAccount.WordWrap = false;
		txbAccount.TextChanged += new System.EventHandler(txbAccount_TextChanged);
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(1179, 37);
		bunifuCards1.TabIndex = 49;
		ctmsAcc.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ctmsAcc.Items.AddRange(new System.Windows.Forms.ToolStripItem[5] { F5AD6813, D60B2326, toolStripMenuItem_2, E034F09C, toolStripMenuItem_3 });
		ctmsAcc.Name = "ctmsAcc";
		ctmsAcc.Size = new System.Drawing.Size(179, 114);
		F5AD6813.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { B39CBC0B, toolStripMenuItem_0, E92DF91A, toolStripMenuItem_1 });
		F5AD6813.Name = "chọnToolStripMenuItem1";
		F5AD6813.Size = new System.Drawing.Size(178, 22);
		F5AD6813.Text = "Chọn";
		B39CBC0B.Name = "tấtCảToolStripMenuItem1";
		B39CBC0B.Size = new System.Drawing.Size(143, 22);
		B39CBC0B.Text = "Tất cả";
		toolStripMenuItem_0.Name = "bôiĐenToolStripMenuItem1";
		toolStripMenuItem_0.Size = new System.Drawing.Size(143, 22);
		toolStripMenuItem_0.Text = "Bôi đen";
		E92DF91A.Name = "tàiKhoản0ToolStripMenuItem";
		E92DF91A.Size = new System.Drawing.Size(143, 22);
		E92DF91A.Text = "Tài khoản=0";
		toolStripMenuItem_1.Name = "tàiKhoản1ToolStripMenuItem";
		toolStripMenuItem_1.Size = new System.Drawing.Size(143, 22);
		toolStripMenuItem_1.Text = "Tài khoản=1";
		D60B2326.Name = "toolStripMenuItem2";
		D60B2326.Size = new System.Drawing.Size(178, 22);
		D60B2326.Text = "Bỏ chọn tất cả";
		toolStripMenuItem_2.Name = "tạoThiếtBịToolStripMenuItem";
		toolStripMenuItem_2.Size = new System.Drawing.Size(178, 22);
		toolStripMenuItem_2.Text = "Tạo thiết bị";
		E034F09C.Name = "xóaThiếtBịToolStripMenuItem";
		E034F09C.Size = new System.Drawing.Size(178, 22);
		E034F09C.Text = "Xóa thiết bị";
		toolStripMenuItem_3.Name = "loadDanhSachThiêtBiToolStripMenuItem1";
		toolStripMenuItem_3.Size = new System.Drawing.Size(178, 22);
		toolStripMenuItem_3.Text = "Làm mới danh sa\u0301ch";
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		label3.Location = new System.Drawing.Point(698, 58);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(87, 16);
		label3.TabIndex = 55;
		label3.Text = "Tha\u0300nh công:";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		lblSuccess.AutoSize = true;
		lblSuccess.BackColor = System.Drawing.SystemColors.Control;
		lblSuccess.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblSuccess.ForeColor = System.Drawing.Color.FromArgb(53, 120, 229);
		lblSuccess.Location = new System.Drawing.Point(781, 55);
		lblSuccess.Name = "lblSuccess";
		lblSuccess.Size = new System.Drawing.Size(19, 19);
		lblSuccess.TabIndex = 50;
		lblSuccess.Text = "0";
		lblError.AutoSize = true;
		lblError.BackColor = System.Drawing.SystemColors.Control;
		lblError.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblError.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
		lblError.Location = new System.Drawing.Point(904, 55);
		lblError.Name = "lblError";
		lblError.Size = new System.Drawing.Size(19, 19);
		lblError.TabIndex = 51;
		lblError.Text = "0";
		F4AEC30C.AutoSize = true;
		F4AEC30C.BackColor = System.Drawing.SystemColors.Control;
		F4AEC30C.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F4AEC30C.ForeColor = System.Drawing.Color.Teal;
		F4AEC30C.Location = new System.Drawing.Point(1064, 56);
		F4AEC30C.Name = "lblTotal";
		F4AEC30C.Size = new System.Drawing.Size(19, 19);
		F4AEC30C.TabIndex = 53;
		F4AEC30C.Text = "0";
		label4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		label4.Location = new System.Drawing.Point(855, 58);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(52, 16);
		label4.TabIndex = 56;
		label4.Text = "Lỗi:";
		label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		label7.Location = new System.Drawing.Point(1004, 58);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(63, 16);
		label7.TabIndex = 59;
		label7.Text = "Tô\u0309ng sô\u0301:";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblStatus.ForeColor = System.Drawing.Color.DarkGreen;
		lblStatus.Location = new System.Drawing.Point(12, 44);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(227, 28);
		lblStatus.TabIndex = 60;
		lblStatus.Text = "Nhập thông tin tài khoản:";
		lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		plDinhDangNhap.Controls.Add(label16);
		plDinhDangNhap.Controls.Add(label15);
		plDinhDangNhap.Controls.Add(DE285487);
		plDinhDangNhap.Controls.Add(B6021A83);
		plDinhDangNhap.Controls.Add(cbbDinhDang11);
		plDinhDangNhap.Controls.Add(B4B75A2B);
		plDinhDangNhap.Controls.Add(AA044112);
		plDinhDangNhap.Controls.Add(label2);
		plDinhDangNhap.Controls.Add(C7BF3C2F);
		plDinhDangNhap.Controls.Add(cbbDinhDang1);
		plDinhDangNhap.Controls.Add(B09DD6A5);
		plDinhDangNhap.Controls.Add(cbbDinhDang3);
		plDinhDangNhap.Controls.Add(cbbDinhDang4);
		plDinhDangNhap.Controls.Add(label14);
		plDinhDangNhap.Controls.Add(cbbDinhDang5);
		plDinhDangNhap.Controls.Add(label6);
		plDinhDangNhap.Controls.Add(B6846636);
		plDinhDangNhap.Controls.Add(D8887010);
		plDinhDangNhap.Controls.Add(BF26B59A);
		plDinhDangNhap.Controls.Add(A1080583);
		plDinhDangNhap.Controls.Add(cbbDinhDang6);
		plDinhDangNhap.Controls.Add(D8955880);
		plDinhDangNhap.Controls.Add(cbbDinhDang7);
		plDinhDangNhap.Controls.Add(label11);
		plDinhDangNhap.Controls.Add(label9);
		plDinhDangNhap.Controls.Add(label10);
		plDinhDangNhap.Location = new System.Drawing.Point(12, 392);
		plDinhDangNhap.Name = "plDinhDangNhap";
		plDinhDangNhap.Size = new System.Drawing.Size(1157, 62);
		plDinhDangNhap.TabIndex = 61;
		label16.AutoSize = true;
		label16.Font = new System.Drawing.Font("Tahoma", 12f);
		label16.Location = new System.Drawing.Point(1057, 7);
		label16.Name = "label16";
		label16.Size = new System.Drawing.Size(15, 19);
		label16.TabIndex = 128;
		label16.Text = "|";
		label15.AutoSize = true;
		label15.Font = new System.Drawing.Font("Tahoma", 12f);
		label15.Location = new System.Drawing.Point(961, 6);
		label15.Name = "label15";
		label15.Size = new System.Drawing.Size(15, 19);
		label15.TabIndex = 128;
		label15.Text = "|";
		DE285487.AutoSize = true;
		DE285487.Font = new System.Drawing.Font("Tahoma", 12f);
		DE285487.Location = new System.Drawing.Point(774, 4);
		DE285487.Name = "label5";
		DE285487.Size = new System.Drawing.Size(15, 19);
		DE285487.TabIndex = 128;
		DE285487.Text = "|";
		B6021A83.Cursor = System.Windows.Forms.Cursors.Hand;
		B6021A83.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		B6021A83.FormattingEnabled = true;
		B6021A83.Location = new System.Drawing.Point(1072, 7);
		B6021A83.Name = "cbbDinhDang12";
		B6021A83.Size = new System.Drawing.Size(78, 24);
		B6021A83.TabIndex = 127;
		cbbDinhDang11.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang11.FormattingEnabled = true;
		cbbDinhDang11.Location = new System.Drawing.Point(976, 6);
		cbbDinhDang11.Name = "cbbDinhDang11";
		cbbDinhDang11.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang11.TabIndex = 127;
		B4B75A2B.Cursor = System.Windows.Forms.Cursors.Hand;
		B4B75A2B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		B4B75A2B.FormattingEnabled = true;
		B4B75A2B.Location = new System.Drawing.Point(789, 4);
		B4B75A2B.Name = "cbbDinhDang9";
		B4B75A2B.Size = new System.Drawing.Size(78, 24);
		B4B75A2B.TabIndex = 127;
		AA044112.Cursor = System.Windows.Forms.Cursors.Hand;
		AA044112.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		AA044112.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		AA044112.FormattingEnabled = true;
		AA044112.Items.AddRange(new object[2] { "HTTP", "Sock5" });
		AA044112.Location = new System.Drawing.Point(85, 33);
		AA044112.Name = "cbbTypeProxy";
		AA044112.Size = new System.Drawing.Size(130, 24);
		AA044112.TabIndex = 126;
		AA044112.Visible = false;
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label2.Location = new System.Drawing.Point(7, 36);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(70, 16);
		label2.TabIndex = 125;
		label2.Text = "Loại proxy:";
		label2.Visible = false;
		C7BF3C2F.AutoSize = true;
		C7BF3C2F.Font = new System.Drawing.Font("Tahoma", 12f);
		C7BF3C2F.Location = new System.Drawing.Point(5, 3);
		C7BF3C2F.Name = "label1";
		C7BF3C2F.Size = new System.Drawing.Size(39, 19);
		C7BF3C2F.TabIndex = 42;
		C7BF3C2F.Text = "Uid|";
		cbbDinhDang1.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang1.FormattingEnabled = true;
		cbbDinhDang1.Location = new System.Drawing.Point(44, 3);
		cbbDinhDang1.Name = "cbbDinhDang1";
		cbbDinhDang1.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang1.TabIndex = 40;
		cbbDinhDang1.SelectedIndexChanged += new System.EventHandler(cbbDinhDang7_SelectedIndexChanged);
		B09DD6A5.Cursor = System.Windows.Forms.Cursors.Hand;
		B09DD6A5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		B09DD6A5.FormattingEnabled = true;
		B09DD6A5.Location = new System.Drawing.Point(137, 3);
		B09DD6A5.Name = "cbbDinhDang2";
		B09DD6A5.Size = new System.Drawing.Size(78, 24);
		B09DD6A5.TabIndex = 40;
		B09DD6A5.SelectedIndexChanged += new System.EventHandler(cbbDinhDang7_SelectedIndexChanged);
		cbbDinhDang3.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang3.FormattingEnabled = true;
		cbbDinhDang3.Location = new System.Drawing.Point(230, 3);
		cbbDinhDang3.Name = "cbbDinhDang3";
		cbbDinhDang3.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang3.TabIndex = 40;
		cbbDinhDang3.SelectedIndexChanged += new System.EventHandler(cbbDinhDang7_SelectedIndexChanged);
		cbbDinhDang4.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang4.FormattingEnabled = true;
		cbbDinhDang4.Location = new System.Drawing.Point(323, 3);
		cbbDinhDang4.Name = "cbbDinhDang4";
		cbbDinhDang4.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang4.TabIndex = 40;
		cbbDinhDang4.SelectedIndexChanged += new System.EventHandler(cbbDinhDang7_SelectedIndexChanged);
		label14.AutoSize = true;
		label14.Font = new System.Drawing.Font("Tahoma", 12f);
		label14.Location = new System.Drawing.Point(587, 3);
		label14.Name = "label14";
		label14.Size = new System.Drawing.Size(15, 19);
		label14.TabIndex = 41;
		label14.Text = "|";
		cbbDinhDang5.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang5.FormattingEnabled = true;
		cbbDinhDang5.Location = new System.Drawing.Point(416, 3);
		cbbDinhDang5.Name = "cbbDinhDang5";
		cbbDinhDang5.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang5.TabIndex = 40;
		cbbDinhDang5.SelectedIndexChanged += new System.EventHandler(cbbDinhDang7_SelectedIndexChanged);
		label6.AutoSize = true;
		label6.Font = new System.Drawing.Font("Tahoma", 12f);
		label6.Location = new System.Drawing.Point(867, 5);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(15, 19);
		label6.TabIndex = 41;
		label6.Text = "|";
		B6846636.AutoSize = true;
		B6846636.Font = new System.Drawing.Font("Tahoma", 12f);
		B6846636.Location = new System.Drawing.Point(680, 3);
		B6846636.Name = "label17";
		B6846636.Size = new System.Drawing.Size(15, 19);
		B6846636.TabIndex = 41;
		B6846636.Text = "|";
		D8887010.Cursor = System.Windows.Forms.Cursors.Hand;
		D8887010.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		D8887010.FormattingEnabled = true;
		D8887010.Location = new System.Drawing.Point(882, 5);
		D8887010.Name = "cbbDinhDang10";
		D8887010.Size = new System.Drawing.Size(78, 24);
		D8887010.TabIndex = 40;
		D8887010.SelectedIndexChanged += new System.EventHandler(cbbDinhDang7_SelectedIndexChanged);
		BF26B59A.Cursor = System.Windows.Forms.Cursors.Hand;
		BF26B59A.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		BF26B59A.FormattingEnabled = true;
		BF26B59A.Location = new System.Drawing.Point(695, 3);
		BF26B59A.Name = "cbbDinhDang8";
		BF26B59A.Size = new System.Drawing.Size(78, 24);
		BF26B59A.TabIndex = 40;
		BF26B59A.SelectedIndexChanged += new System.EventHandler(cbbDinhDang7_SelectedIndexChanged);
		A1080583.AutoSize = true;
		A1080583.Font = new System.Drawing.Font("Tahoma", 12f);
		A1080583.Location = new System.Drawing.Point(494, 3);
		A1080583.Name = "label13";
		A1080583.Size = new System.Drawing.Size(15, 19);
		A1080583.TabIndex = 41;
		A1080583.Text = "|";
		cbbDinhDang6.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang6.FormattingEnabled = true;
		cbbDinhDang6.Location = new System.Drawing.Point(509, 3);
		cbbDinhDang6.Name = "cbbDinhDang6";
		cbbDinhDang6.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang6.TabIndex = 40;
		cbbDinhDang6.SelectedIndexChanged += new System.EventHandler(cbbDinhDang7_SelectedIndexChanged);
		D8955880.AutoSize = true;
		D8955880.Font = new System.Drawing.Font("Tahoma", 12f);
		D8955880.Location = new System.Drawing.Point(401, 3);
		D8955880.Name = "label12";
		D8955880.Size = new System.Drawing.Size(15, 19);
		D8955880.TabIndex = 41;
		D8955880.Text = "|";
		cbbDinhDang7.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang7.FormattingEnabled = true;
		cbbDinhDang7.Location = new System.Drawing.Point(602, 3);
		cbbDinhDang7.Name = "cbbDinhDang7";
		cbbDinhDang7.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang7.TabIndex = 40;
		cbbDinhDang7.SelectedIndexChanged += new System.EventHandler(cbbDinhDang7_SelectedIndexChanged);
		label11.AutoSize = true;
		label11.Font = new System.Drawing.Font("Tahoma", 12f);
		label11.Location = new System.Drawing.Point(308, 3);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(15, 19);
		label11.TabIndex = 41;
		label11.Text = "|";
		label9.AutoSize = true;
		label9.Font = new System.Drawing.Font("Tahoma", 12f);
		label9.Location = new System.Drawing.Point(122, 3);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(15, 19);
		label9.TabIndex = 41;
		label9.Text = "|";
		label10.AutoSize = true;
		label10.Font = new System.Drawing.Font("Tahoma", 12f);
		label10.Location = new System.Drawing.Point(215, 3);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(15, 19);
		label10.TabIndex = 41;
		label10.Text = "|";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1179, 502);
		base.Controls.Add(plDinhDangNhap);
		base.Controls.Add(lblStatus);
		base.Controls.Add(label3);
		base.Controls.Add(lblSuccess);
		base.Controls.Add(lblError);
		base.Controls.Add(F4AEC30C);
		base.Controls.Add(label4);
		base.Controls.Add(label7);
		base.Controls.Add(btnAdd);
		base.Controls.Add(A03562BF);
		base.Controls.Add(txbAccount);
		base.Controls.Add(bunifuCards1);
		base.Controls.Add(E802642C);
		base.Controls.Add(label8);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCapNhatDuLieu";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Nhập tài khoản";
		base.Load += new System.EventHandler(CF3BD901);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)B5AB3F96).EndInit();
		((System.ComponentModel.ISupportInitialize)B3380C3E).EndInit();
		bunifuCards1.ResumeLayout(false);
		ctmsAcc.ResumeLayout(false);
		plDinhDangNhap.ResumeLayout(false);
		plDinhDangNhap.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}
}
