using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using WindowsFormsControlLibrary1;

public class DC9EAA81 : Form
{
	[CompilerGenerated]
	private sealed class Class44
	{
		public DC9EAA81 B0A6C1A2;

		public List<string> A10DF136;

		internal void method_0()
		{
			try
			{
				string text = "";
				for (int i = 0; i < B0A6C1A2.FC2E01A0.RowCount; i++)
				{
					text = B0A6C1A2.EA892A22(i, "cGhiChu");
					if (text != "")
					{
						string value = Regex.Match(text, "\\((.*?)\\)", RegexOptions.Singleline).Value;
						if (value != "")
						{
							text = text.Replace(value, "").Trim();
						}
						value = Regex.Match(text, "\\[(.*?)\\]").Value;
						if (value != "")
						{
							text = text.Replace(value, "").Trim();
						}
						if (text.StartsWith("282-") && text.Split('-').Length > 1)
						{
							text = text.Split('-')[0] + "-" + text.Split('-')[1];
						}
						if (text != "" && !A10DF136.Contains(text))
						{
							A10DF136.Add(text);
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class45
	{
		public DC9EAA81 dc9EAA81_0;

		public List<string> A8372694;

		internal void method_0()
		{
			try
			{
				string text = "";
				string text2 = "";
				for (int i = 0; i < dc9EAA81_0.FC2E01A0.RowCount; i++)
				{
					text = dc9EAA81_0.EA892A22(i, "cStatus").Trim();
					if (text != "")
					{
						text2 = Regex.Match(text, "\\(IP: (.*?)\\)", RegexOptions.Singleline).Value;
						if (text2 != "")
						{
							text = text.Replace(text2, "").Trim();
						}
						text2 = Regex.Match(text, "\\[(.*?)\\]").Value;
						if (text2 != "")
						{
							text = text.Replace(text2, "").Trim();
						}
						if (text != "" && !A8372694.Contains(text))
						{
							A8372694.Add(text);
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		internal void FA88572F()
		{
			try
			{
				string text = "";
				for (int i = 0; i < dc9EAA81_0.FC2E01A0.RowCount; i++)
				{
					text = dc9EAA81_0.EA892A22(i, "cInfo");
					if (!text.Equals("") && !A8372694.Contains(text))
					{
						A8372694.Add(text);
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class D6A50714
	{
		public string string_0;

		public DC9EAA81 dc9EAA81_0;

		internal void method_0()
		{
			try
			{
				if (string_0 == "start")
				{
					dc9EAA81_0.FB151835.Enabled = false;
					dc9EAA81_0.method_11();
				}
				else if (string_0 == "stop")
				{
					dc9EAA81_0.FB151835.Enabled = true;
					dc9EAA81_0.method_12();
				}
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class46
	{
		public DC9EAA81 dc9EAA81_0;

		public int B52F0313;

		public int int_0;

		public int int_1;

		public bool D3A991B4;

		internal void A90BF2BF()
		{
			dc9EAA81_0.CA0E65A6("start");
			int num = 0;
			while (num < dc9EAA81_0.FC2E01A0.Rows.Count && !dc9EAA81_0.bool_0)
			{
				if (Convert.ToBoolean(dc9EAA81_0.FC2E01A0.Rows[num].Cells["cChose"].Value))
				{
					if (B52F0313 < int_0)
					{
						A8BCB3A0 CS_0024_003C_003E8__locals0 = new A8BCB3A0
						{
							class46_0 = this
						};
						Interlocked.Increment(ref B52F0313);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class46_0.dc9EAA81_0.method_28(CS_0024_003C_003E8__locals0.int_0, F7AB102E.smethod_0("Đang kiểm tra..."));
							switch (CS_0024_003C_003E8__locals0.class46_0.int_1)
							{
							case 0:
								CS_0024_003C_003E8__locals0.class46_0.dc9EAA81_0.method_18(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 1:
								CS_0024_003C_003E8__locals0.class46_0.dc9EAA81_0.method_19(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 2:
								CS_0024_003C_003E8__locals0.class46_0.dc9EAA81_0.C0865019(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 3:
								CS_0024_003C_003E8__locals0.class46_0.dc9EAA81_0.DFB581AF(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 4:
								CS_0024_003C_003E8__locals0.class46_0.dc9EAA81_0.method_17(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 5:
								CS_0024_003C_003E8__locals0.class46_0.dc9EAA81_0.E017789E(CS_0024_003C_003E8__locals0.int_0, CS_0024_003C_003E8__locals0.class46_0.D3A991B4);
								break;
							case 6:
								CS_0024_003C_003E8__locals0.class46_0.dc9EAA81_0.A582E60A(CS_0024_003C_003E8__locals0.int_0, CS_0024_003C_003E8__locals0.class46_0.D3A991B4);
								break;
							case 7:
								CS_0024_003C_003E8__locals0.class46_0.dc9EAA81_0.A9822318(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 8:
								CS_0024_003C_003E8__locals0.class46_0.dc9EAA81_0.BA905F87(CS_0024_003C_003E8__locals0.int_0);
								break;
							}
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class46_0.B52F0313);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (B52F0313 > 0 && Environment.TickCount - tickCount <= 60000)
			{
				GClass8.smethod_53(1.0);
			}
			dc9EAA81_0.CA0E65A6("stop");
		}
	}

	[CompilerGenerated]
	private sealed class A8BCB3A0
	{
		public int int_0;

		public Class46 class46_0;

		internal void method_0()
		{
			class46_0.dc9EAA81_0.method_28(int_0, F7AB102E.smethod_0("Đang kiểm tra..."));
			switch (class46_0.int_1)
			{
			case 0:
				class46_0.dc9EAA81_0.method_18(int_0);
				break;
			case 1:
				class46_0.dc9EAA81_0.method_19(int_0);
				break;
			case 2:
				class46_0.dc9EAA81_0.C0865019(int_0);
				break;
			case 3:
				class46_0.dc9EAA81_0.DFB581AF(int_0);
				break;
			case 4:
				class46_0.dc9EAA81_0.method_17(int_0);
				break;
			case 5:
				class46_0.dc9EAA81_0.E017789E(int_0, class46_0.D3A991B4);
				break;
			case 6:
				class46_0.dc9EAA81_0.A582E60A(int_0, class46_0.D3A991B4);
				break;
			case 7:
				class46_0.dc9EAA81_0.A9822318(int_0);
				break;
			case 8:
				class46_0.dc9EAA81_0.BA905F87(int_0);
				break;
			}
			Interlocked.Decrement(ref class46_0.B52F0313);
		}
	}

	[CompilerGenerated]
	private sealed class A833C108
	{
		public DC9EAA81 dc9EAA81_0;

		public int CEAAA9B2;

		public int CC14F79A;

		internal void method_0()
		{
			dc9EAA81_0.CA0E65A6("start");
			int num = 0;
			while (num < dc9EAA81_0.FC2E01A0.Rows.Count)
			{
				Application.DoEvents();
				if (dc9EAA81_0.bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(dc9EAA81_0.FC2E01A0.Rows[num].Cells["cChose"].Value))
				{
					if (CEAAA9B2 < CC14F79A)
					{
						Class47 CS_0024_003C_003E8__locals0 = new Class47
						{
							C8AEEABF = this
						};
						Interlocked.Increment(ref CEAAA9B2);
						CS_0024_003C_003E8__locals0.B0901818 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.C8AEEABF.dc9EAA81_0.method_28(CS_0024_003C_003E8__locals0.B0901818, F7AB102E.smethod_0("Đang kiểm tra..."));
							CS_0024_003C_003E8__locals0.C8AEEABF.dc9EAA81_0.method_21(CS_0024_003C_003E8__locals0.B0901818);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.C8AEEABF.CEAAA9B2);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (CEAAA9B2 > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			dc9EAA81_0.CA0E65A6("stop");
		}
	}

	[CompilerGenerated]
	private sealed class Class47
	{
		public int B0901818;

		public A833C108 C8AEEABF;

		internal void method_0()
		{
			C8AEEABF.dc9EAA81_0.method_28(B0901818, F7AB102E.smethod_0("Đang kiểm tra..."));
			C8AEEABF.dc9EAA81_0.method_21(B0901818);
			Interlocked.Decrement(ref C8AEEABF.CEAAA9B2);
		}
	}

	[CompilerGenerated]
	private sealed class Class48
	{
		public int int_0;

		public int E4838AB5;

		public DC9EAA81 FF829B8C;

		internal void method_0()
		{
			int num = 0;
			while (num < FF829B8C.FC2E01A0.Rows.Count)
			{
				if (Convert.ToBoolean(FF829B8C.FC2E01A0.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < E4838AB5)
					{
						Class49 CS_0024_003C_003E8__locals0 = new Class49
						{
							class48_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class48_0.FF829B8C.method_28(CS_0024_003C_003E8__locals0.int_0, F7AB102E.smethod_0("Đang xo\u0301a profile..."));
							CS_0024_003C_003E8__locals0.class48_0.FF829B8C.method_22(CS_0024_003C_003E8__locals0.int_0);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class48_0.int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class49
	{
		public int int_0;

		public Class48 class48_0;

		internal void method_0()
		{
			class48_0.FF829B8C.method_28(int_0, F7AB102E.smethod_0("Đang xo\u0301a profile..."));
			class48_0.FF829B8C.method_22(int_0);
			Interlocked.Decrement(ref class48_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class A91D2A36
	{
		public DC9EAA81 dc9EAA81_0;

		public int A609AFA4;

		public int int_0;

		public string string_0;

		internal void BE2846A0()
		{
			int num = 0;
			while (num < dc9EAA81_0.FC2E01A0.RowCount)
			{
				if (Convert.ToBoolean(dc9EAA81_0.EA892A22(num, "cChose")))
				{
					if (A609AFA4 < int_0)
					{
						Class50 CS_0024_003C_003E8__locals0 = new Class50
						{
							a91D2A36_0 = this
						};
						Interlocked.Increment(ref A609AFA4);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.a91D2A36_0.dc9EAA81_0.method_28(CS_0024_003C_003E8__locals0.int_0, "Check profile...");
							CS_0024_003C_003E8__locals0.a91D2A36_0.dc9EAA81_0.method_23(CS_0024_003C_003E8__locals0.int_0, CS_0024_003C_003E8__locals0.a91D2A36_0.string_0);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.a91D2A36_0.A609AFA4);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class50
	{
		public int int_0;

		public A91D2A36 a91D2A36_0;

		internal void BCAC5330()
		{
			a91D2A36_0.dc9EAA81_0.method_28(int_0, "Check profile...");
			a91D2A36_0.dc9EAA81_0.method_23(int_0, a91D2A36_0.string_0);
			Interlocked.Decrement(ref a91D2A36_0.A609AFA4);
		}
	}

	[CompilerGenerated]
	private sealed class FA250C37
	{
		public DC9EAA81 dc9EAA81_0;

		public int int_0;

		public int E39B7A8E;

		internal void CE3BC008()
		{
			dc9EAA81_0.CA0E65A6("start");
			int num = 0;
			while (num < dc9EAA81_0.FC2E01A0.Rows.Count)
			{
				Application.DoEvents();
				if (dc9EAA81_0.bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(dc9EAA81_0.FC2E01A0.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < E39B7A8E)
					{
						Class51 CS_0024_003C_003E8__locals0 = new Class51
						{
							fa250C37_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.C8ADF09D = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.fa250C37_0.dc9EAA81_0.method_28(CS_0024_003C_003E8__locals0.C8ADF09D, F7AB102E.smethod_0("Đang kiểm tra..."));
							CS_0024_003C_003E8__locals0.fa250C37_0.dc9EAA81_0.method_24(CS_0024_003C_003E8__locals0.C8ADF09D);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.fa250C37_0.int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (int_0 > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			dc9EAA81_0.CA0E65A6("stop");
		}
	}

	[CompilerGenerated]
	private sealed class Class51
	{
		public int C8ADF09D;

		public FA250C37 fa250C37_0;

		internal void D112D28E()
		{
			fa250C37_0.dc9EAA81_0.method_28(C8ADF09D, F7AB102E.smethod_0("Đang kiểm tra..."));
			fa250C37_0.dc9EAA81_0.method_24(C8ADF09D);
			Interlocked.Decrement(ref fa250C37_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class E41BFD37
	{
		public int int_0;

		public int int_1;

		public DC9EAA81 dc9EAA81_0;

		internal void C4A3E7A3()
		{
			int num = 0;
			while (num < dc9EAA81_0.FC2E01A0.Rows.Count)
			{
				if (Convert.ToBoolean(dc9EAA81_0.FC2E01A0.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						A4811610 CS_0024_003C_003E8__locals0 = new A4811610
						{
							e41BFD37_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.EC90CA37 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.e41BFD37_0.dc9EAA81_0.method_28(CS_0024_003C_003E8__locals0.EC90CA37, F7AB102E.smethod_0("Đang xo\u0301a Cache Profile..."));
							CS_0024_003C_003E8__locals0.e41BFD37_0.dc9EAA81_0.method_26(CS_0024_003C_003E8__locals0.EC90CA37);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.e41BFD37_0.int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class A4811610
	{
		public int EC90CA37;

		public E41BFD37 e41BFD37_0;

		internal void method_0()
		{
			e41BFD37_0.dc9EAA81_0.method_28(EC90CA37, F7AB102E.smethod_0("Đang xo\u0301a Cache Profile..."));
			e41BFD37_0.dc9EAA81_0.method_26(EC90CA37);
			Interlocked.Decrement(ref e41BFD37_0.int_0);
		}
	}

	private bool bool_0;

	private int int_0 = 0;

	private object F590988F = new object();

	private int int_1 = -1;

	private bool bool_1 = true;

	private object object_0 = new object();

	private int int_2 = -1;

	private bool bool_2 = true;

	private bool bool_3 = false;

	private bool A6AF1E8F = false;

	private int int_3 = 0;

	private IContainer icontainer_0 = null;

	public static string string_0 = "";

	private BunifuDragControl FFA5C41A;

	private BunifuCards bunifuCards1;

	private Panel FD09ABAC;

	private PictureBox A2BB4E19;

	private Button btnMinimize;

	private Button btnMaximize;

	private Button C2BBE483;

	private BunifuCustomLabel bunifuCustomLabel1;

	private MenuStrip menuStrip1;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ContextMenuStrip ctmsAcc;

	private ToolStripMenuItem D0BECAB7;

	private ToolStripMenuItem B290909B;

	private ToolStripMenuItem copyToolStripMenuItem;

	private ToolStripMenuItem tokenToolStripMenuItem;

	private ToolStripMenuItem FA0E751D;

	private ToolStripMenuItem C936D995;

	private ToolStripMenuItem F51CC91A;

	private ToolStripMenuItem CE0B252D;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem F693C913;

	private ToolStripMenuItem FD258E2F;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem DC84E9A5;

	private ToolStripMenuItem C105F23A;

	private ToolStripMenuItem C1A39D9F;

	private ToolStripMenuItem B481618B;

	private ToolStripMenuItem E02B1B0D;

	private ToolStripMenuItem profileToolStripMenuItem;

	private ToolStripMenuItem A22EEC0C;

	private ToolStripMenuItem AF329D23;

	private ToolStripMenuItem mailToolStripMenuItem;

	private ToolStripMenuItem uidPassTokenCookieMailPassMail2faToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_3;

	private ToolStripMenuItem checkProfileToolStripMenuItem;

	private ToolStripMenuItem fAToolStripMenuItem;

	private ToolStripMenuItem tinhTrangToolStripMenuItem;

	private ToolStripMenuItem locTrungToolStripMenuItem;

	private ToolStripMenuItem uidPass2FaToolStripMenuItem;

	private BunifuDragControl DF87A63E;

	private ToolTip D0084038;

	private ToolStripMenuItem DF938226;

	private ToolStripMenuItem toolStripMenuItem_4;

	private ToolStripMenuItem D9AA529A;

	private ToolStripMenuItem toolStripMenuItem_5;

	private ToolStripMenuItem useragentToolStripMenuItem1;

	private ToolStripMenuItem proxyToolStripMenuItem1;

	private ToolStripMenuItem B51C071B;

	private ToolStripMenuItem uidToolStripMenuItem;

	private ToolStripMenuItem checkAvatarToolStripMenuItem;

	private ToolStripMenuItem checkProxyToolStripMenuItem;

	private ToolStripMenuItem checkProfileToolStripMenuItem1;

	private ToolStripMenuItem checkInfoUIDToolStripMenuItem;

	private ToolStripMenuItem BE0E1BBB;

	private ToolStripMenuItem toolStripMenuItem_6;

	private ToolStripMenuItem toolStripMenuItem_7;

	private ToolStripMenuItem toolStripMenuItem_8;

	private ToolStripMenuItem checkHotmailToolStripMenuItem;

	private ToolStripMenuItem FA179E81;

	private ToolStripMenuItem lToolStripMenuItem;

	private ToolStripMenuItem BD992F3E;

	private ToolStripMenuItem toolStripMenuItem_9;

	private ToolStripMenuItem F0B54B2A;

	private StatusStrip miniToolStrip;

	private ToolStripStatusLabel DCB7C820;

	private ToolStripStatusLabel lblCountHighline;

	private ToolStripStatusLabel E68E9BA2;

	private ToolStripStatusLabel D9AF668F;

	private ToolStripStatusLabel toolStripStatusLabel7;

	private ToolStripStatusLabel B59CD508;

	private Panel panel2;

	private Button BtnSearch;

	private ComboBox cbbSearch;

	private BunifuCustomTextbox txbSearch;

	private Panel FB151835;

	private Label D9970838;

	private Label label2;

	private ComboBox cbbThuMuc;

	private ComboBox cbbTinhTrang;

	private Panel FB1FEA84;

	private StatusStrip A2B3B43D;

	public DataGridView FC2E01A0;

	private ToolStripMenuItem toolStripMenuItem_10;

	private ToolStripMenuItem toolStripMenuItem_11;

	private ToolStripMenuItem A7883BB7;

	private ToolStripMenuItem D81B60BF;

	private ToolStripMenuItem getTokenEAAAAUToolStripMenuItem;

	private ToolStripMenuItem getTokenEAAAAUBToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_12;

	private ToolStripMenuItem checkStatusXproxyToolStripMenuItem;

	private ToolStripMenuItem D581D426;

	private ToolStripMenuItem toolStripMenuItem_13;

	private Button B907A795;

	private Button F328AC2B;

	private Button BC32F63B;

	private ToolStripMenuItem C436F517;

	private ToolStripMenuItem toolStripMenuItem_14;

	private ToolStripMenuItem toolStripMenuItem1;

	private ToolStripMenuItem toolStripMenuItem2;

	private DataGridViewCheckBoxColumn cChose;

	private DataGridViewTextBoxColumn cStt;

	private DataGridViewTextBoxColumn B83CE197;

	private DataGridViewTextBoxColumn cUid;

	private DataGridViewTextBoxColumn cToken;

	private DataGridViewTextBoxColumn cCookies;

	private DataGridViewTextBoxColumn C8055AB4;

	private DataGridViewTextBoxColumn cPhone;

	private DataGridViewTextBoxColumn cName;

	private DataGridViewTextBoxColumn cFollow;

	private DataGridViewTextBoxColumn cFriend;

	private DataGridViewTextBoxColumn cGroup;

	private DataGridViewTextBoxColumn cPage;

	private DataGridViewTextBoxColumn cPagePro5;

	private DataGridViewTextBoxColumn cBirthday;

	private DataGridViewTextBoxColumn BA9EB309;

	private DataGridViewTextBoxColumn cPassword;

	private DataGridViewTextBoxColumn cMailRecovery;

	private DataGridViewTextBoxColumn EB3E7D28;

	private DataGridViewTextBoxColumn cOAuth2;

	private DataGridViewTextBoxColumn D19A288B;

	private DataGridViewTextBoxColumn DB88FDA0;

	private DataGridViewTextBoxColumn cProxy;

	private DataGridViewTextBoxColumn E72E22AF;

	private DataGridViewTextBoxColumn E6B52429;

	private DataGridViewTextBoxColumn D4B1EA2B;

	private DataGridViewTextBoxColumn FD19ABA8;

	private DataGridViewTextBoxColumn B18DBE2F;

	private DataGridViewTextBoxColumn C6A02F16;

	private DataGridViewTextBoxColumn cGhiChu;

	private DataGridViewTextBoxColumn CCAD2D81;

	private DataGridViewTextBoxColumn C8958DBC;

	private DataGridViewTextBoxColumn CD39963D;

	private DataGridViewTextBoxColumn A9AB0298;

	private DataGridViewTextBoxColumn cAds;

	private DataGridViewTextBoxColumn DA351814;

	private DataGridViewTextBoxColumn cWallPosts;

	private DataGridViewTextBoxColumn cFbBlock;

	private DataGridViewTextBoxColumn cJob;

	private DataGridViewTextBoxColumn cDateDelete;

	private DataGridViewTextBoxColumn cStatus;

	public DC9EAA81()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		F7AB102E.smethod_4(ctmsAcc);
		txbSearch.smethod_2();
	}

	protected override void OnLoad(EventArgs EF9DD48E)
	{
		Application.Idle += method_0;
	}

	private void method_0(object sender, EventArgs e)
	{
		Application.Idle -= method_0;
		D13CC590();
		F524900B();
		method_1(1);
		method_2();
		menuStrip1.Cursor = Cursors.Hand;
	}

	private void D13CC590()
	{
		Dictionary<string, string> dataSource = new Dictionary<string, string>
		{
			{ "cUid", "UID" },
			{
				"cPassword",
				F7AB102E.smethod_0("Mật khẩu")
			},
			{
				"cName",
				F7AB102E.smethod_0("Tên")
			},
			{
				"cBirthday",
				F7AB102E.smethod_0("Ngày sinh")
			},
			{
				"cGender",
				F7AB102E.smethod_0("Giới tính")
			},
			{ "cToken", "Token" },
			{ "cCookies", "Cookie" },
			{ "cEmail", "Email" },
			{ "cPassMail", "Pass email" },
			{ "cFa2", "2FA" },
			{
				"cGhiChu",
				F7AB102E.smethod_0("Ghi chu\u0301")
			},
			{
				"cInteractEnd",
				F7AB102E.smethod_0("Tương ta\u0301c cuô\u0301i")
			}
		};
		cbbSearch.DataSource = new BindingSource(dataSource, null);
		cbbSearch.ValueMember = "Key";
		cbbSearch.DisplayMember = "Value";
	}

	private void method_1(int FDAE7289 = -1)
	{
		bool_1 = false;
		DataTable dataSource = Class15.smethod_1(bool_0: true, bool_1: true);
		cbbThuMuc.DataSource = dataSource;
		cbbThuMuc.ValueMember = "id";
		cbbThuMuc.DisplayMember = "name";
		if (FDAE7289 != -1 && cbbThuMuc.Items.Count >= FDAE7289)
		{
			cbbThuMuc.SelectedIndex = FDAE7289;
		}
		else if (cbbThuMuc.Items.Count == 2)
		{
			cbbThuMuc.SelectedIndex = -1;
		}
		bool_1 = true;
	}

	private void method_2(List<string> list_0 = null)
	{
		try
		{
			DataTable dataSource = Class15.E62BDA25(list_0, A3966D0C: false);
			cbbTinhTrang.DataSource = dataSource;
			cbbTinhTrang.ValueMember = "id";
			cbbTinhTrang.DisplayMember = "name";
		}
		catch
		{
		}
	}

	private void C2BBE483_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnMaximize_Click(object sender, EventArgs e)
	{
		this.A294D626();
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	public void B907A795_Click(object sender, EventArgs e)
	{
		try
		{
			string text = "";
			if (cbbThuMuc.SelectedValue != null)
			{
				text = cbbThuMuc.SelectedValue.ToString();
			}
			method_1();
			if (text != "999999" && text != "-2")
			{
				int_1 = -1;
				cbbThuMuc.SelectedValue = text;
				return;
			}
			bool_1 = false;
			cbbThuMuc.SelectedValue = text;
			bool_1 = true;
			method_2(fChonThuMuc.list_0);
		}
		catch (Exception)
		{
		}
	}

	private List<string> method_3()
	{
		List<string> result = null;
		try
		{
			string text = cbbThuMuc.SelectedValue.ToString();
			string text2 = text;
			if (!(text2 == "-2"))
			{
				result = ((text2 == "999999") ? GClass26.F1136602(fChonThuMuc.list_0) : new List<string> { cbbThuMuc.SelectedValue.ToString() });
			}
		}
		catch
		{
		}
		return result;
	}

	private void method_4(List<string> list_0 = null, string string_1 = "")
	{
		try
		{
			FC2E01A0.Rows.Clear();
			if (string_1 == "[Tất cả tình trạng]" || string_1 == F7AB102E.smethod_0("[Tất cả tình trạng]"))
			{
				string_1 = "";
			}
			DataTable e204F7BB = Class15.E2B3A014(list_0, string_1, bool_0: false);
			CE3DBF9F(e204F7BB);
		}
		catch (Exception)
		{
		}
	}

	private void CE3DBF9F(DataTable E204F7BB)
	{
		GClass27.CB1F923E(FC2E01A0, E204F7BB, FC226794: true);
		method_15(0);
		method_34();
		method_14();
	}

	private void method_5(string string_1)
	{
		switch (string_1)
		{
		case "ToggleCheck":
		{
			for (int k = 0; k < FC2E01A0.SelectedRows.Count; k++)
			{
				int index = FC2E01A0.SelectedRows[k].Index;
				method_30(index, "cChose", !Convert.ToBoolean(EA892A22(index, "cChose")));
			}
			method_15();
			break;
		}
		case "SelectHighline":
		{
			DataGridViewSelectedRowCollection selectedRows = FC2E01A0.SelectedRows;
			for (int j = 0; j < selectedRows.Count; j++)
			{
				method_30(selectedRows[j].Index, "cChose", true);
			}
			method_15();
			break;
		}
		case "UnAll":
		{
			for (int l = 0; l < FC2E01A0.RowCount; l++)
			{
				method_30(l, "cChose", false);
			}
			method_15(0);
			break;
		}
		case "All":
		{
			for (int i = 0; i < FC2E01A0.RowCount; i++)
			{
				method_30(i, "cChose", true);
			}
			method_15(FC2E01A0.RowCount);
			break;
		}
		}
	}

	private void method_6(string BB049990)
	{
		if (D12766B9())
		{
			try
			{
				List<string> values = FC0ABC3C(BB049990);
				GClass8.smethod_27(string.Join("\r\n", values));
			}
			catch
			{
			}
		}
	}

	private List<string> FC0ABC3C(string string_1)
	{
		List<string> list = new List<string>();
		try
		{
			List<string> list2 = string_1.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
			for (int i = 0; i < FC2E01A0.RowCount; i++)
			{
				if (!Convert.ToBoolean(FC2E01A0.Rows[i].Cells["cChose"].Value))
				{
					continue;
				}
				List<string> list3 = new List<string>();
				for (int j = 0; j < list2.Count; j++)
				{
					string text = EA892A22(i, list2[j]);
					if (list2[j] == "cProxy" && text.Length > 2)
					{
						if (text[text.Length - 2].ToString() == "*")
						{
							text = text.Substring(0, text.Length - 2);
						}
					}
					else if (list2[j] == "cMa2Fa")
					{
						text = GClass8.smethod_66(EA892A22(i, "cFa2"));
					}
					list3.Add(text);
				}
				list.Add(string.Join("|", list3));
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		method_5("All");
	}

	private void B290909B_Click(object sender, EventArgs e)
	{
		method_5("SelectHighline");
	}

	private void A32B19B0(object sender, EventArgs e)
	{
		method_5("UnAll");
	}

	private void tokenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_6("cToken");
	}

	private void FA0E751D_Click(object sender, EventArgs e)
	{
		method_6("cCookies");
	}

	private void uidToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_6("cUid");
	}

	private void FD258E2F_Click(object sender, EventArgs e)
	{
		method_6("cPassword");
	}

	private void C936D995_Click(object sender, EventArgs e)
	{
		method_6("cUid|cPassword");
	}

	private void F51CC91A_Click(object sender, EventArgs e)
	{
		method_6("cUid|cPassword|cToken|cCookies");
	}

	private void method_7(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fAddFile());
		if (fAddFile.C13CD985)
		{
			method_1();
			cbbThuMuc.SelectedIndex = cbbThuMuc.Items.Count - 2;
		}
	}

	private void ctmsAcc_Opening(object sender, CancelEventArgs e)
	{
		A22EEC0C.DropDownItems.Clear();
		List<string> A8372694 = new List<string>();
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				string text2 = "";
				string text3 = "";
				for (int l = 0; l < FC2E01A0.RowCount; l++)
				{
					text2 = EA892A22(l, "cStatus").Trim();
					if (text2 != "")
					{
						text3 = Regex.Match(text2, "\\(IP: (.*?)\\)", RegexOptions.Singleline).Value;
						if (text3 != "")
						{
							text2 = text2.Replace(text3, "").Trim();
						}
						text3 = Regex.Match(text2, "\\[(.*?)\\]").Value;
						if (text3 != "")
						{
							text2 = text2.Replace(text3, "").Trim();
						}
						if (text2 != "" && !A8372694.Contains(text2))
						{
							A8372694.Add(text2);
						}
					}
				}
			}
			catch (Exception)
			{
			}
		});
		thread.Start();
		if (!thread.Join(5000))
		{
			thread.Abort();
		}
		for (int i = 0; i < A8372694.Count; i++)
		{
			A22EEC0C.DropDownItems.Add(A8372694[i]);
			A22EEC0C.DropDownItems[i].Click += D4B0AD2F;
		}
		tinhTrangToolStripMenuItem.DropDownItems.Clear();
		A8372694 = new List<string>();
		thread = new Thread((ThreadStart)delegate
		{
			try
			{
				string text = "";
				for (int k = 0; k < FC2E01A0.RowCount; k++)
				{
					text = EA892A22(k, "cInfo");
					if (!text.Equals("") && !A8372694.Contains(text))
					{
						A8372694.Add(text);
					}
				}
			}
			catch (Exception)
			{
			}
		});
		thread.Start();
		if (!thread.Join(5000))
		{
			thread.Abort();
		}
		for (int j = 0; j < A8372694.Count; j++)
		{
			tinhTrangToolStripMenuItem.DropDownItems.Add(A8372694[j]);
			tinhTrangToolStripMenuItem.DropDownItems[j].Click += method_8;
		}
		toolStripMenuItem_12.DropDownItems.Clear();
		A6AF1E8F = true;
	}

	private void method_8(object sender, EventArgs e)
	{
		method_9("cInfo", (sender as ToolStripMenuItem).Text);
	}

	private void D4B0AD2F(object sender, EventArgs e)
	{
		method_9("cStatus", (sender as ToolStripMenuItem).Text);
	}

	private void method_9(string string_1, string string_2)
	{
		for (int i = 0; i < FC2E01A0.RowCount; i++)
		{
			FC2E01A0.Rows[i].Cells["cChose"].Value = EA892A22(i, string_1).Contains(string_2);
		}
		method_15();
	}

	private void method_10(string FC0619BC)
	{
		try
		{
			List<string> list = new List<string>();
			for (int i = 0; i < FC2E01A0.RowCount; i++)
			{
				if (Convert.ToBoolean(FC2E01A0.Rows[i].Cells["cChose"].Value))
				{
					list.Add(FC2E01A0.Rows[i].Cells["cId"].Value.ToString());
				}
			}
			if (Class15.DB0FC1AC(list, "idfile", FC0619BC))
			{
				for (int j = 0; j < FC2E01A0.RowCount; j++)
				{
					if (Convert.ToBoolean(FC2E01A0.Rows[j].Cells["cChose"].Value))
					{
						FC2E01A0.Rows.RemoveAt(j--);
					}
				}
				method_34();
				B2B3FFA2();
				method_15(0);
				method_14();
				GClass29.smethod_0(string.Format(F7AB102E.smethod_0("Chuyển thành công {0} tài khoản!"), list.Count));
			}
			else
			{
				GClass29.smethod_0("Chuyển thất bại, vui lòng thử lại sau!", 2);
			}
		}
		catch
		{
		}
	}

	private void method_11()
	{
		try
		{
			FC2E01A0.Invoke((MethodInvoker)delegate
			{
				foreach (DataGridViewColumn column in FC2E01A0.Columns)
				{
					column.SortMode = DataGridViewColumnSortMode.NotSortable;
				}
			});
		}
		catch (Exception)
		{
		}
	}

	private void method_12()
	{
		try
		{
			FC2E01A0.Invoke((MethodInvoker)delegate
			{
				foreach (DataGridViewColumn column in FC2E01A0.Columns)
				{
					column.SortMode = DataGridViewColumnSortMode.Automatic;
				}
			});
		}
		catch
		{
		}
	}

	private void method_13(int int_4, string string_1, string string_2, string F728F792, int int_5)
	{
		try
		{
			F3958F9B f3958F9B = new F3958F9B(string_2, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36", F728F792, int_5);
			string text = f3958F9B.method_0("https://d.facebook.com/");
			string text2 = f3958F9B.method_4();
			if (text2.Contains("checkpoint/disabled"))
			{
				method_28(int_4, string_1 + "Vô hiệu hóa!");
				DB007029(int_4, "Checkpoint: vhh");
				FD18E799(int_4, 1);
			}
			else if (text2.Contains("828281030927956"))
			{
				string text3 = "956";
				if (GClass8.smethod_91(text))
				{
					text3 += "-Bắt đầu";
				}
				else if (GClass8.C23C7090(text))
				{
					text3 += "-Tìm hiểu thêm";
				}
				method_28(int_4, string_1 + "Checkpoint " + text3 + "!");
				DB007029(int_4, "Checkpoint: " + text3);
				FD18E799(int_4, 1);
			}
			else if (text2.Contains("1501092823525282"))
			{
				DB007029(int_4, "Checkpoint: 282");
				method_28(int_4, string_1 + "Checkpoint 282!");
			}
			else if (!text.Contains("facebook.com/login.php") && !text.Contains("name=\"login\"") && !text.Contains("/login/device-based/validate-pin/"))
			{
				if (!text2.Contains("facebook.com/gettingstarted") && (!text.Contains("href=\"/menu/bookmarks/") || !text.Contains("id=\"mbasic_logout_button\"")) && (!text.Contains("id=\"MComposer\"") || !text.Contains("id=\"MBackNavBar\"")))
				{
					if (text.Contains("confirmation") && !text.Contains("preconfirmation"))
					{
						method_28(int_4, string_1 + "Novery Live!");
						FD18E799(int_4, 2);
					}
					else
					{
						method_28(int_4, string_1 + "Dạng Checkpoint khác!");
						FD18E799(int_4, 1);
					}
				}
				else
				{
					DB007029(int_4, "Live");
					method_28(int_4, "Tài khoản live!");
					FD18E799(int_4, 2);
				}
			}
			else
			{
				method_28(int_4, string_1 + "No login!");
				FD18E799(int_4, 2);
			}
		}
		catch (Exception)
		{
			method_28(int_4, string_1 + "Không check được!");
		}
	}

	private void BA905F87(int int_4)
	{
		string text = EA892A22(int_4, "cCookies");
		if (text.Trim() == "")
		{
			method_28(int_4, F7AB102E.smethod_0("Cookie trô\u0301ng!"));
			return;
		}
		EA892A22(int_4, "cUseragent").Trim();
		string text2 = "";
		int num = 0;
		if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 9)
		{
			text2 = EA892A22(int_4, "cProxy");
			num = (text2.EndsWith("*1") ? 1 : 0);
			if (text2.EndsWith("*0") || text2.EndsWith("*1"))
			{
				text2 = text2.Substring(0, text2.Length - 2);
			}
		}
		method_28(int_4, F7AB102E.smethod_0("Checking..."));
		try
		{
			F3958F9B f3958F9B = new F3958F9B(text, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36", text2, num);
			string input = f3958F9B.method_0("https://d.facebook.com/");
			string value = Regex.Match(text, "c_user=(\\d+)").Groups[1].Value;
			string value2 = Regex.Match(input, "name=\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
			string value3 = Regex.Match(input, "name=\"lsd\" value=\"(.*?)\"").Groups[1].Value;
			string text3 = "av=" + value + "&__user=" + value + "&__a=1&__dyn=&__csr=&__req=&__hs=&dpr=&__ccg=&__rev=&__s=&__hsi=&__comet_req=15&fb_dtsg=" + value2 + "&jazoest=22037&lsd=" + value3 + "&__spin_r=&__spin_b=&__spin_t=&fb_api_caller_class=RelayModern";
			string text4 = "https://www.facebook.com/api/graphql/";
			string bFA79D3C = text3 + "&fb_api_req_friendly_name=useUFACSubmitActionMutation&variables=%7B%22input%22%3A%7B%22client_mutation_id%22%3A%221%22%2C%22actor_id%22%3A%22" + value + "%22%2C%22action%22%3A%22APPEAL_HACKED_DISABLED_OPTIONS_MENU%22%2C%22enrollment_id%22%3Anull%7D%2C%22scale%22%3A1%7D&server_timestamps=true&doc_id=6666461530033597";
			input = f3958F9B.A6321D97(text4, bFA79D3C);
			method_28(int_4, "Done!");
		}
		catch (Exception)
		{
			method_28(int_4, "Fail!");
		}
	}

	private void CA0E65A6(string string_1)
	{
		Invoke((MethodInvoker)delegate
		{
			try
			{
				if (string_1 == "start")
				{
					FB151835.Enabled = false;
					method_11();
				}
				else if (string_1 == "stop")
				{
					FB151835.Enabled = true;
					method_12();
				}
			}
			catch (Exception)
			{
			}
		});
	}

	private void FC2E01A0_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyValue == 32)
		{
			method_5("ToggleCheck");
		}
	}

	private void C78EA98A(object sender, EventArgs e)
	{
		B907A795_Click(null, null);
	}

	private void cbbThuMuc_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1 || cbbThuMuc.SelectedValue == null || !E887EC9A.C323DB3B(cbbThuMuc.SelectedValue.ToString()) || (cbbThuMuc.SelectedValue.ToString() != "999999" && int_1 == cbbThuMuc.SelectedIndex))
		{
			return;
		}
		string text = cbbThuMuc.SelectedValue.ToString();
		string text2 = text;
		if (!(text2 == "-2"))
		{
			if (!(text2 == "999999"))
			{
				method_2(method_3());
			}
			else
			{
				GClass8.smethod_33(new fChonThuMuc(bool_2: true));
				if (fChonThuMuc.bool_1 && fChonThuMuc.E025E18D != null && fChonThuMuc.E025E18D.Count != 0)
				{
					method_2(fChonThuMuc.E025E18D);
				}
				else
				{
					bool_1 = false;
					cbbThuMuc.SelectedIndex = ((int_1 == -1) ? 1 : int_1);
					bool_1 = true;
				}
			}
		}
		else
		{
			method_2();
		}
		int_1 = cbbThuMuc.SelectedIndex;
	}

	private void B481618B_Click(object sender, EventArgs e)
	{
		method_6("cEmail|cPassMail");
	}

	private void E02B1B0D_Click(object sender, EventArgs e)
	{
		method_6("cUid|cPassword|cToken|cCookies|cEmail|cPassMail");
	}

	private void method_14()
	{
		try
		{
			B59CD508.Text = FC2E01A0.Rows.Count.ToString();
		}
		catch
		{
		}
	}

	private void method_15(int A124C6BD = -1)
	{
		if (A124C6BD == -1)
		{
			A124C6BD = 0;
			for (int i = 0; i < FC2E01A0.Rows.Count; i++)
			{
				if (Convert.ToBoolean(FC2E01A0.Rows[i].Cells["cChose"].Value))
				{
					A124C6BD++;
				}
			}
		}
		D9AF668F.Text = A124C6BD.ToString();
	}

	private void method_16(int int_4, bool bool_4 = false)
	{
		int B52F313 = 0;
		int int_5 = GClass25.smethod_0("configGeneral").method_2("nudHideThread", 10);
		GClass25.smethod_0("configGeneral").C0288288("token");
		bool_0 = false;
		new Thread((ThreadStart)delegate
		{
			CA0E65A6("start");
			int num = 0;
			while (num < FC2E01A0.Rows.Count && !bool_0)
			{
				if (Convert.ToBoolean(FC2E01A0.Rows[num].Cells["cChose"].Value))
				{
					if (B52F313 < int_5)
					{
						Interlocked.Increment(ref B52F313);
						int int_6 = num++;
						new Thread((ThreadStart)delegate
						{
							method_28(int_6, F7AB102E.smethod_0("Đang kiểm tra..."));
							switch (int_4)
							{
							case 0:
								method_18(int_6);
								break;
							case 1:
								method_19(int_6);
								break;
							case 2:
								C0865019(int_6);
								break;
							case 3:
								DFB581AF(int_6);
								break;
							case 4:
								method_17(int_6);
								break;
							case 5:
								E017789E(int_6, bool_4);
								break;
							case 6:
								A582E60A(int_6, bool_4);
								break;
							case 7:
								A9822318(int_6);
								break;
							case 8:
								BA905F87(int_6);
								break;
							}
							Interlocked.Decrement(ref B52F313);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (B52F313 > 0 && Environment.TickCount - tickCount <= 60000)
			{
				GClass8.smethod_53(1.0);
			}
			CA0E65A6("stop");
		}).Start();
	}

	private void E017789E(int int_4, bool bool_4)
	{
		try
		{
			string b512372F = EA892A22(int_4, "cId");
			string text = EA892A22(int_4, "cUid");
			string text2 = "";
			int num = 0;
			if (bool_4)
			{
				text2 = EA892A22(int_4, "cProxy");
				num = (text2.EndsWith("*1") ? 1 : 0);
				if (text2.EndsWith("*0") || text2.EndsWith("*1"))
				{
					text2 = text2.Substring(0, text2.Length - 2);
				}
			}
			string text3 = "";
			string text4 = Class14.A61BB104(text, text2, num);
			if (text4.StartsWith("0|"))
			{
				if (Class14.EABAA59C(text).StartsWith("0|"))
				{
					method_28(int_4, F7AB102E.smethod_0("Tài khoản Die!"));
					DB007029(int_4, "Die");
				}
				else
				{
					method_28(int_4, F7AB102E.smethod_0("Không check đươ\u0323c!"));
				}
			}
			else if (text4.StartsWith("1|"))
			{
				string[] array = text4.Split('|');
				string text5 = array[1];
				string text6 = array[2];
				string text7 = array[3];
				Class15.C888252E(b512372F, "name|friends|dateCreateAcc", text5 + "|" + text6 + "|" + text7);
				method_30(int_4, "cName", text5);
				method_30(int_4, "cFriend", text6);
				method_30(int_4, "cDateCreateAcc", text7);
				DB007029(int_4, "Live");
				text3 = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t thông tin tha\u0300nh công!");
				method_28(int_4, text3);
			}
			else
			{
				method_28(int_4, F7AB102E.smethod_0("Không check đươ\u0323c!"));
			}
		}
		catch
		{
			method_28(int_4, F7AB102E.smethod_0("Không check đươ\u0323c!"));
		}
	}

	private void method_17(int int_4)
	{
		try
		{
			string text = EA892A22(int_4, "cEmail");
			string text2 = EA892A22(int_4, "cPassMail");
			string f215712E = EA892A22(int_4, "cOAuth2");
			if (!(text == "") && !(text2 == ""))
			{
				if (GClass21.A3BD3C81(text, text2, f215712E))
				{
					method_28(int_4, F7AB102E.smethod_0("Success!"));
					FD18E799(int_4, 2);
				}
				else
				{
					method_28(int_4, F7AB102E.smethod_0("Fail!"));
					FD18E799(int_4, 1);
				}
			}
			else
			{
				method_28(int_4, F7AB102E.smethod_0("Không tìm thấy mail!"));
			}
		}
		catch (Exception)
		{
			method_28(int_4, F7AB102E.smethod_0("Lỗi!"));
		}
	}

	private void A9822318(int A43B0390)
	{
		try
		{
			string text = EA892A22(A43B0390, "cName");
			string text2 = "";
			text2 = ((text.Trim() == "") ? F7AB102E.smethod_0("Không tìm thấy tên!") : ((!GClass8.smethod_68(text)) ? F7AB102E.smethod_0("No") : F7AB102E.smethod_0("Yes")));
			method_28(A43B0390, text2);
		}
		catch
		{
			method_28(A43B0390, F7AB102E.smethod_0("Không check đươ\u0323c!"));
		}
	}

	private void method_18(int EC229F80)
	{
		try
		{
			EA892A22(EC229F80, "cId");
			string cA02E40A = EA892A22(EC229F80, "cUid");
			string text = "";
			string text2 = "";
			string text3 = Class14.EABAA59C(cA02E40A);
			if (text3.StartsWith("0|"))
			{
				text = "Die";
				text2 = "Wall die";
			}
			else if (text3.StartsWith("1|"))
			{
				text = "Live";
				text2 = "Wall live";
			}
			else
			{
				text2 = F7AB102E.smethod_0("Không check được!");
			}
			method_28(EC229F80, text2);
			if (text != "")
			{
				DB007029(EC229F80, text);
			}
		}
		catch
		{
			method_28(EC229F80, F7AB102E.smethod_0("Không check đươ\u0323c!"));
		}
	}

	private void method_19(int B622BF3A)
	{
		try
		{
			string text = "";
			EA892A22(B622BF3A, "cId");
			string text2 = EA892A22(B622BF3A, "cCookies");
			string text3 = EA892A22(B622BF3A, "cToken");
			if (text3.Trim() == "")
			{
				method_28(B622BF3A, F7AB102E.smethod_0("Token trô\u0301ng!"));
				return;
			}
			string a72F = EA892A22(B622BF3A, "cUseragent").Trim();
			string text4 = "";
			int num = 0;
			if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 9)
			{
				text4 = EA892A22(B622BF3A, "cProxy");
				num = (text4.EndsWith("*1") ? 1 : 0);
				if (text4.EndsWith("*0") || text4.EndsWith("*1"))
				{
					text4 = text4.Substring(0, text4.Length - 2);
				}
			}
			string text5 = "";
			if (!Class14.smethod_6(text2, text3, a72F, text4, num))
			{
				text5 = "Token die";
			}
			else
			{
				text = "Live";
				text5 = "Token live";
			}
			method_28(B622BF3A, text5);
			if (text != "")
			{
				DB007029(B622BF3A, text);
			}
		}
		catch
		{
			method_28(B622BF3A, F7AB102E.smethod_0("Không check đươ\u0323c!"));
		}
	}

	private void C0865019(int int_4)
	{
		try
		{
			string text = "";
			EA892A22(int_4, "cId");
			string text2 = EA892A22(int_4, "cCookies");
			if (text2.Trim() == "")
			{
				method_28(int_4, F7AB102E.smethod_0("Cookie trô\u0301ng!"));
				return;
			}
			string string_ = EA892A22(int_4, "cUseragent").Trim();
			string text3 = "";
			int bB8B = 0;
			if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 9)
			{
				text3 = EA892A22(int_4, "cProxy");
				bB8B = (text3.EndsWith("*1") ? 1 : 0);
				if (text3.EndsWith("*0") || text3.EndsWith("*1"))
				{
					text3 = text3.Substring(0, text3.Length - 2);
				}
			}
			string text4 = "";
			if (!Class14.C5302E20(text2, string_, text3, bB8B).StartsWith("1|"))
			{
				text4 = "Cookie die";
			}
			else
			{
				text = "Live";
				text4 = "Cookie live";
			}
			method_28(int_4, text4);
			if (text != "")
			{
				DB007029(int_4, text);
			}
		}
		catch
		{
			method_28(int_4, F7AB102E.smethod_0("Không check đươ\u0323c!"));
		}
	}

	private void DFB581AF(int int_4)
	{
		FC2E01A0.Rows[int_4].Cells["cId"].Value.ToString();
		string text = EA892A22(int_4, "cCookies");
		if (text.Trim() == "")
		{
			method_28(int_4, F7AB102E.smethod_0("Cookie trô\u0301ng!"));
			return;
		}
		EA892A22(int_4, "cUseragent").Trim();
		string text2 = "";
		int int_5 = 0;
		if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 9)
		{
			text2 = EA892A22(int_4, "cProxy");
			int_5 = (text2.EndsWith("*1") ? 1 : 0);
			if (text2.EndsWith("*0") || text2.EndsWith("*1"))
			{
				text2 = text2.Substring(0, text2.Length - 2);
			}
		}
		method_28(int_4, F7AB102E.smethod_0("Checking..."));
		method_13(int_4, "", text, text2, int_5);
	}

	private void CC885936(object sender, EventArgs e)
	{
		method_16(0);
	}

	private void DC380B11(object sender, EventArgs e)
	{
		if (GClass29.smethod_1("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?") == DialogResult.Yes)
		{
			method_16(1);
		}
	}

	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		method_16(3);
	}

	private void mailToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_6("cEmail");
	}

	private void BtnSearch_Click(object sender, EventArgs e)
	{
		try
		{
			if (cbbSearch.SelectedIndex == -1)
			{
				GClass29.smethod_0("Vui lòng chọn kiểu tìm kiếm!", 3);
				return;
			}
			string columnName = cbbSearch.SelectedValue.ToString();
			string text = txbSearch.Text.Trim();
			if (text == "")
			{
				GClass29.smethod_0("Vui lòng nhập nội dung tìm kiếm!", 3);
				return;
			}
			List<int> list = new List<int>();
			text = GClass8.smethod_70(text.ToLower());
			for (int i = 0; i < FC2E01A0.RowCount; i++)
			{
				string text2 = FC2E01A0.Rows[i].Cells[columnName].Value.ToString();
				text2 = GClass8.smethod_70(text2.ToLower());
				text = GClass8.smethod_70(text.ToLower());
				if (text2.Contains(text))
				{
					list.Add(i);
				}
			}
			int index = 0;
			int num = -1;
			try
			{
				num = FC2E01A0.CurrentRow.Index;
			}
			catch
			{
				num = -1;
			}
			if (list.Count <= 0)
			{
				return;
			}
			if (num >= list[list.Count - 1])
			{
				index = 0;
			}
			else
			{
				for (int j = 0; j < list.Count; j++)
				{
					if (num < list[j])
					{
						index = j;
						break;
					}
				}
			}
			int index2 = list[index];
			FC2E01A0.CurrentCell = FC2E01A0.Rows[index2].Cells[columnName];
			FC2E01A0.ClearSelection();
			FC2E01A0.Rows[index2].Selected = true;
		}
		catch (Exception)
		{
		}
	}

	private void E19E068E(object sender, EventArgs e)
	{
		if (Class57.smethod_3())
		{
			method_6("cUid|cPassword|cToken|cCookies|cEmail|cPassMail|cFa2");
		}
	}

	private void B2B3FFA2()
	{
		for (int i = 0; i < FC2E01A0.RowCount; i++)
		{
			method_30(i, "cSTT", i + 1);
		}
	}

	private void E70D2A17(object sender, EventArgs e)
	{
		if (Class57.smethod_3())
		{
			method_6("cFa2");
		}
	}

	private void A3AFBF1C(object sender, EventArgs e)
	{
		method_16(6);
	}

	private void A582E60A(int EF8ACAAA, bool DCB06894)
	{
		try
		{
			string text = "";
			int f8BA9D = 0;
			if (DCB06894)
			{
				text = EA892A22(EF8ACAAA, "cProxy");
				f8BA9D = (text.EndsWith("*1") ? 1 : 0);
				if (text.EndsWith("*0") || text.EndsWith("*1"))
				{
					text = text.Substring(0, text.Length - 2);
				}
			}
			string text2 = FC2E01A0.Rows[EF8ACAAA].Cells["cUid"].Value.ToString();
			switch (Class14.F4B2E309(text2, text, f8BA9D))
			{
			case "2":
				method_28(EF8ACAAA, F7AB102E.smethod_0("Không check được!"));
				break;
			case "1":
				method_28(EF8ACAAA, F7AB102E.smethod_0("Đa\u0303 co\u0301 avatar!"));
				method_32(EF8ACAAA, "cAvatar", "Yes", "avatar");
				break;
			case "0":
				method_28(EF8ACAAA, F7AB102E.smethod_0("Không co\u0301 avatar!"));
				method_32(EF8ACAAA, "cAvatar", "No", "avatar");
				break;
			}
		}
		catch
		{
			method_28(EF8ACAAA, "Lỗi!");
		}
	}

	private void method_20(object sender, EventArgs e)
	{
		int CEAAA9B2 = 0;
		int CC14F79A = GClass25.smethod_0("configGeneral").method_2("nudHideThread", 10);
		bool_0 = false;
		new Thread((ThreadStart)delegate
		{
			CA0E65A6("start");
			int num = 0;
			while (num < FC2E01A0.Rows.Count)
			{
				Application.DoEvents();
				if (bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(FC2E01A0.Rows[num].Cells["cChose"].Value))
				{
					if (CEAAA9B2 < CC14F79A)
					{
						Interlocked.Increment(ref CEAAA9B2);
						int B901818 = num++;
						new Thread((ThreadStart)delegate
						{
							method_28(B901818, F7AB102E.smethod_0("Đang kiểm tra..."));
							method_21(B901818);
							Interlocked.Decrement(ref CEAAA9B2);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (CEAAA9B2 > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			CA0E65A6("stop");
		}).Start();
	}

	private void method_21(int AA3205B3)
	{
		string text = FC2E01A0.Rows[AA3205B3].Cells["cCookies"].Value.ToString();
		FC2E01A0.Rows[AA3205B3].Cells["cId"].Value.ToString();
		string string_ = EA892A22(AA3205B3, "cUseragent").Trim();
		string text2 = "";
		int bB8B = 0;
		if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 9)
		{
			text2 = EA892A22(AA3205B3, "cProxy");
			bB8B = (text2.EndsWith("*1") ? 1 : 0);
			if (text2.EndsWith("*0") || text2.EndsWith("*1"))
			{
				text2 = text2.Substring(0, text2.Length - 2);
			}
		}
		string text3 = "";
		if (text == "")
		{
			text3 = "Cookie trống!";
		}
		else
		{
			string text4 = Class14.C5302E20(text, string_, text2, bB8B);
			if (text4.Split('|')[0] == "1")
			{
				text3 = ((!(text4.Split('|')[1] == "1")) ? (text3 + F7AB102E.smethod_0("Chưa veri!")) : (text3 + F7AB102E.smethod_0("Đa\u0303 veri!")));
			}
			else if (text4.Split('|')[0] == "0")
			{
				text3 += "Cookie Die!";
			}
			else if (text4.Split('|')[0] == "2")
			{
				text3 += F7AB102E.smethod_0("Lô\u0303i khi check!");
			}
		}
		method_28(AA3205B3, text3);
	}

	private void locTrungToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			for (int i = 0; i < FC2E01A0.RowCount; i++)
			{
				if (Convert.ToBoolean(FC2E01A0.Rows[i].Cells["cChose"].Value))
				{
					string item = EA892A22(i, "cUid");
					if (list2.Contains(item))
					{
						list.Add(item);
					}
					else
					{
						list2.Add(item);
					}
				}
			}
			if (list.Count == 0)
			{
				GClass29.smethod_0("Không có tài khoản trùng nhau!");
				return;
			}
			List<string> a6826E = GClass8.smethod_28(list);
			DataTable dataTable = Class15.C52782A9(a6826E, bool_0: false);
			dataTable.DefaultView.Sort = "uid ASC";
			dataTable = dataTable.DefaultView.ToTable();
			FC2E01A0.Rows.Clear();
			CE3DBF9F(dataTable);
		}
		catch (Exception)
		{
		}
	}

	private void E1802BB4(object sender, EventArgs e)
	{
		if (GClass29.smethod_1(string.Format(F7AB102E.smethod_0("Bạn có chắc muốn xóa Profile của {0} tài khoản?"), method_25())) != DialogResult.Yes)
		{
			return;
		}
		int int_0 = 0;
		int E4838AB5 = GClass25.smethod_0("configGeneral").method_2("nudHideThread", 10);
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < FC2E01A0.Rows.Count)
			{
				if (Convert.ToBoolean(FC2E01A0.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < E4838AB5)
					{
						Interlocked.Increment(ref int_0);
						int int_ = num++;
						new Thread((ThreadStart)delegate
						{
							method_28(int_, F7AB102E.smethod_0("Đang xo\u0301a profile..."));
							method_22(int_);
							Interlocked.Decrement(ref int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}).Start();
	}

	private void method_22(int int_4)
	{
		try
		{
			string e00DDFA = FC2E01A0.Rows[int_4].Cells["cId"].Value.ToString();
			string text = FC2E01A0.Rows[int_4].Cells["cUid"].Value.ToString();
			if (text.Trim() == "")
			{
				method_28(int_4, F7AB102E.smethod_0("Chưa tạo profile!"));
				return;
			}
			string path = GClass25.smethod_2() + "\\" + text;
			if (Directory.Exists(path))
			{
				Directory.Delete(path, recursive: true);
				method_28(int_4, F7AB102E.smethod_0("Xóa profile thành công!"));
				method_30(int_4, "cProfile", "No");
				Class15.EB34450D(e00DDFA, "profile", "No");
			}
			else
			{
				method_28(int_4, F7AB102E.smethod_0("Chưa tạo profile!"));
			}
		}
		catch
		{
			method_28(int_4, F7AB102E.smethod_0("Xóa profile thất bại!"));
		}
	}

	private void checkProfileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		int A609AFA4 = 0;
		int int_0 = 10;
		string string_0 = GClass25.smethod_2();
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < FC2E01A0.RowCount)
			{
				if (Convert.ToBoolean(EA892A22(num, "cChose")))
				{
					if (A609AFA4 < int_0)
					{
						Interlocked.Increment(ref A609AFA4);
						int int_ = num++;
						new Thread((ThreadStart)delegate
						{
							method_28(int_, "Check profile...");
							method_23(int_, string_0);
							Interlocked.Decrement(ref A609AFA4);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}).Start();
	}

	private void method_23(int int_4, string string_1)
	{
		try
		{
			string e00DDFA = EA892A22(int_4, "cId");
			string text = EA892A22(int_4, "cUid");
			string_1 = string_1 + "\\" + text;
			if (Directory.Exists(string_1))
			{
				method_28(int_4, F7AB102E.smethod_0("Đã có profile!"));
				method_30(int_4, "cProfile", "Yes");
				Class15.EB34450D(e00DDFA, "profile", "Yes");
			}
			else
			{
				method_28(int_4, F7AB102E.smethod_0("Chưa tạo profile!"));
				method_30(int_4, "cProfile", "No");
				Class15.EB34450D(e00DDFA, "profile", "No");
			}
		}
		catch
		{
		}
	}

	private void C19E3318(object sender, EventArgs e)
	{
		try
		{
			GClass8.smethod_33(new E62E1719());
		}
		catch (Exception ex)
		{
			GClass29.smethod_0(ex.ToString(), 3);
		}
	}

	private void FB09ED8D(object sender, EventArgs e)
	{
		GClass8.smethod_41("chrome");
	}

	private void A2B3B43D_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
	{
	}

	private void uidPass2FaToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Class57.smethod_3())
		{
			method_6("cUid|cPassword|cFa2");
		}
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		GClass11 FE0C4A = new GClass11();
		GClass8.smethod_33(new fCauHinhChung(ref FE0C4A));
		if (FE0C4A.method_3("isChangePathDatabase"))
		{
			method_1();
			int_1 = -1;
			cbbThuMuc.SelectedIndex = -1;
			cbbThuMuc.SelectedIndex = 0;
		}
	}

	private void DF938226_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = FC0ABC3C("cUid|cPassword|cToken|cCookies|cEmail|cEmail2|cPassMail|cFa2|cUseragent|cProxy|cName|cGender|cFollow|cFriend|cGroup|cBirthday|cDateCreateAcc|cGhiChu|cLocation|cMailRecovery|cInteractEnd|cDating|cAds|cBM");
			if (list.Count <= 0)
			{
				GClass29.smethod_0("Vui lòng chọn danh sách tài khoản muốn copy thông tin!", 3);
			}
			else
			{
				GClass8.smethod_33(new C991D19B(list));
			}
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA, "Error Copy");
		}
	}

	private void D8A4AD1F(object sender, EventArgs e)
	{
		method_6("cMa2Fa");
	}

	private void BBA57B27(object sender, EventArgs e)
	{
	}

	private void D81DBA02(object sender, DataGridViewSortCompareEventArgs e)
	{
		GClass27.D6A30D83(e);
	}

	private void toolStripMenuItem_5_Click(object sender, EventArgs e)
	{
		string text = GClass25.smethod_0("configDatagridview").method_7();
		GClass8.smethod_33(new B4A88A90());
		if (GClass25.smethod_0("configDatagridview").method_7() != text)
		{
			F524900B();
		}
	}

	private void AEB15804(object sender, EventArgs e)
	{
		int int_0 = 0;
		int E39B7A8E = GClass25.smethod_0("configGeneral").method_2("nudHideThread", 10);
		bool_0 = false;
		new Thread((ThreadStart)delegate
		{
			CA0E65A6("start");
			int num = 0;
			while (num < FC2E01A0.Rows.Count)
			{
				Application.DoEvents();
				if (bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(FC2E01A0.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < E39B7A8E)
					{
						Interlocked.Increment(ref int_0);
						int C8ADF09D = num++;
						new Thread((ThreadStart)delegate
						{
							method_28(C8ADF09D, F7AB102E.smethod_0("Đang kiểm tra..."));
							method_24(C8ADF09D);
							Interlocked.Decrement(ref int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (int_0 > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			CA0E65A6("stop");
		}).Start();
	}

	private void method_24(int int_4)
	{
		try
		{
			string text = FC2E01A0.Rows[int_4].Cells["cProxy"].Value.ToString();
			int num = 0;
			if (text.EndsWith("*1"))
			{
				num = 1;
			}
			text = text.Substring(0, text.Length - 2);
			int num2 = 0;
			int num3 = 0;
			string text2 = "";
			bool flag = false;
			for (int i = 0; i < 10; i++)
			{
				text2 = GClass8.smethod_59(text, num);
				if (text2 != "")
				{
					num2++;
					if (num2 == 3)
					{
						flag = true;
						break;
					}
				}
				else
				{
					num3++;
					if (num3 == 3)
					{
						break;
					}
				}
			}
			if (!flag)
			{
				method_28(int_4, "Proxy Die!");
			}
			else
			{
				method_28(int_4, "Proxy Live!");
			}
		}
		catch
		{
			method_28(int_4, "Lỗi!");
		}
	}

	private void DFA673A3(object sender, EventArgs e)
	{
		method_6("cUseragent");
	}

	private void proxyToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		method_6("cProxy");
	}

	private void A2BB4E19_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Alt)
		{
			try
			{
				Process.Start(GClass28.smethod_0());
			}
			catch
			{
			}
		}
	}

	private void cbbTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_2 || cbbTinhTrang.SelectedValue == null || !E887EC9A.C323DB3B(cbbTinhTrang.SelectedValue.ToString()) || (cbbTinhTrang.SelectedValue.ToString() != "-1" && int_2 == cbbTinhTrang.SelectedIndex))
		{
			return;
		}
		string text = cbbThuMuc.SelectedValue.ToString();
		string text2 = text;
		if (!(text2 == "-2"))
		{
			if (!(text2 == "999999"))
			{
				method_4(method_3(), cbbTinhTrang.Text);
			}
			else
			{
				method_4(fChonThuMuc.E025E18D, cbbTinhTrang.Text);
			}
		}
		else
		{
			method_4(null, cbbTinhTrang.Text);
		}
		int_2 = cbbTinhTrang.SelectedIndex;
	}

	private void AE8AE3AE(object sender, EventArgs e)
	{
		method_16(4);
	}

	public int method_25()
	{
		int result = 0;
		try
		{
			result = Convert.ToInt32(D9AF668F.Text);
		}
		catch
		{
		}
		return result;
	}

	private bool D12766B9()
	{
		if (method_25() == 0)
		{
			GClass29.smethod_0("Vui lòng chọn tài khoản muốn sử dụng chức năng này!", 3);
			return false;
		}
		return true;
	}

	private void BE0E1BBB_Click(object sender, EventArgs e)
	{
		if (GClass29.smethod_1(string.Format(F7AB102E.smethod_0("Bạn có chắc muốn xóa Cache Profile của {0} tài khoản?"), method_25())) != DialogResult.Yes)
		{
			return;
		}
		int int_0 = 0;
		int int_1 = GClass25.smethod_0("configGeneral").method_2("nudHideThread", 10);
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < FC2E01A0.Rows.Count)
			{
				if (Convert.ToBoolean(FC2E01A0.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int EC90CA37 = num++;
						new Thread((ThreadStart)delegate
						{
							method_28(EC90CA37, F7AB102E.smethod_0("Đang xo\u0301a Cache Profile..."));
							method_26(EC90CA37);
							Interlocked.Decrement(ref int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}).Start();
	}

	private void method_26(int EB176AA1)
	{
		try
		{
			FC2E01A0.Rows[EB176AA1].Cells["cId"].Value.ToString();
			string text = FC2E01A0.Rows[EB176AA1].Cells["cUid"].Value.ToString();
			if (text.Trim() == "")
			{
				method_28(EB176AA1, F7AB102E.smethod_0("Chưa tạo profile!"));
				return;
			}
			string text2 = GClass25.smethod_2() + "\\" + text;
			if (Directory.Exists(text2))
			{
				GClass8.smethod_67(text2 + "\\Default\\Cache");
				GClass8.smethod_67(text2 + "\\Default\\Code Cache");
				GClass8.smethod_67(text2 + "\\OptimizationGuidePredictionModels");
				GClass8.smethod_67(text2 + "\\Default\\optimization_guide_prediction_model_downloads");
				GClass8.smethod_67(text2 + "\\SwReporter");
				GClass8.smethod_67(text2 + "\\pnacl");
				method_28(EB176AA1, F7AB102E.smethod_0("Xóa Cache Profile thành công!"));
			}
			else
			{
				method_28(EB176AA1, F7AB102E.smethod_0("Chưa tạo profile!"));
			}
		}
		catch
		{
			method_28(EB176AA1, F7AB102E.smethod_0("Xóa Cache Profile thất bại!"));
		}
	}

	private void A9345DBA(object sender, EventArgs e)
	{
		GClass8.smethod_33(new B314B89F());
	}

	private void B99C1580(object sender, EventArgs e)
	{
		try
		{
			Process.Start("chrome.exe", "https://app.minsoftware.vn/textfree.html");
		}
		catch
		{
			Process.Start("https://app.minsoftware.vn/textfree.html");
		}
	}

	private void CE0B252D_Click(object sender, EventArgs e)
	{
	}

	private void checkHotmailToolStripMenuItem_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fTienIchCheckImapHotmail());
	}

	private void C30241AF(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			if (e.RowIndex > -1)
			{
				FC2E01A0.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(FC2E01A0.CurrentRow.Cells["cChose"].Value);
				method_15();
			}
		}
		catch
		{
		}
	}

	private void method_27(object sender, EventArgs e)
	{
		List<string> list = method_3();
		if (list != null && list.Count == 1)
		{
			fEditFile fEditFile2 = new fEditFile(list[0], cbbThuMuc.Text);
			fEditFile2.ShowInTaskbar = false;
			fEditFile2.ShowDialog();
			int selectedIndex = cbbThuMuc.SelectedIndex;
			if (fEditFile2.A0A227BD)
			{
				method_1();
				int_1 = -1;
				cbbThuMuc.SelectedIndex = selectedIndex;
			}
		}
	}

	private void FA179E81_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fTienIchCheckProxy());
	}

	private void lToolStripMenuItem_Click(object sender, EventArgs e)
	{
		fLocTheoDanhSachUid fLocTheoDanhSachUid2 = new fLocTheoDanhSachUid();
		GClass8.smethod_33(fLocTheoDanhSachUid2);
		if (fLocTheoDanhSachUid2.list_0.Count > 0)
		{
			List<string> a6826E = GClass8.smethod_28(fLocTheoDanhSachUid2.list_0);
			DataTable e204F7BB = Class15.C52782A9(a6826E, bool_0: false);
			FC2E01A0.Rows.Clear();
			CE3DBF9F(e204F7BB);
		}
	}

	public void method_28(int F402D1A3, string AC822F88, int AA3F5E13 = -1)
	{
		switch (AA3F5E13)
		{
		default:
			GClass27.smethod_1(FC2E01A0, F402D1A3, "cStatus", AA3F5E13, AC822F88);
			break;
		case -1:
			GClass27.smethod_5(FC2E01A0, F402D1A3, "cStatus", AC822F88);
			break;
		case 0:
			break;
		}
	}

	public void method_29(int int_4, string C2B01A3D, int int_5, int D611C11F)
	{
		int aA3F5E = Class57.random_0.Next(int_5, D611C11F + 1);
		method_28(int_4, C2B01A3D, aA3F5E);
	}

	public void DB007029(int A984D78C, string string_1)
	{
		GClass27.smethod_5(FC2E01A0, A984D78C, "cInfo", string_1);
		method_34(A984D78C);
		Class15.EB34450D(EA892A22(A984D78C, "cId"), "info", string_1);
	}

	public void method_30(int B9AB0715, string string_1, object object_1, bool bool_4 = true)
	{
		if ((!(string_1 == "cUid") || !(object_1.ToString().Trim() == "")) && (bool_4 || !(object_1.ToString().Trim() == "")))
		{
			GClass27.smethod_5(FC2E01A0, B9AB0715, string_1, object_1);
		}
	}

	public void method_31(string string_1, string string_2, int int_4, string string_3, string FB9F1AB4, bool bool_4 = true)
	{
		if ((bool_4 || !(FB9F1AB4.ToString().Trim() == "")) && !(FB9F1AB4 == "-2"))
		{
			GClass27.smethod_5(FC2E01A0, int_4, string_3, FB9F1AB4);
			Class15.EB34450D(string_1, string_2, FB9F1AB4);
		}
	}

	public void method_32(int F83A9E16, string D885D523, string string_1, string D68629A3, bool C80E2705 = true)
	{
		method_31(EA892A22(F83A9E16, "cId"), D68629A3, F83A9E16, D885D523, string_1, C80E2705);
	}

	public string method_33(int int_4)
	{
		return GClass27.smethod_3(FC2E01A0, int_4, "cInfo");
	}

	public string EA892A22(int CCB1F6BD, string string_1)
	{
		return GClass27.smethod_3(FC2E01A0, CCB1F6BD, string_1);
	}

	private void method_34(int BD06EC0C = -1)
	{
		GClass27.smethod_0(FC2E01A0, BD06EC0C);
	}

	private void FD18E799(int int_4, int int_5)
	{
		GClass27.E012E0A4(FC2E01A0, int_4, int_5);
	}

	private void F524900B()
	{
		FC2E01A0.Columns["cToken"].Visible = GClass25.smethod_0("configDatagridview").method_3("cToken");
		FC2E01A0.Columns["cCookies"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbCookie");
		FC2E01A0.Columns["cEmail"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbEmail");
		FC2E01A0.Columns["cName"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbTen");
		FC2E01A0.Columns["cFriend"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbBanBe");
		FC2E01A0.Columns["cGroup"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbNhom");
		FC2E01A0.Columns["cPage"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbPage");
		FC2E01A0.Columns["cPagePro5"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbPagePro5");
		FC2E01A0.Columns["cBirthday"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbNgaySinh");
		FC2E01A0.Columns["cGender"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbGioiTinh");
		FC2E01A0.Columns["cPassword"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbMatKhau");
		FC2E01A0.Columns["cPassMail"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbMatKhauMail");
		FC2E01A0.Columns["cOAuth2"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbOAuth2");
		FC2E01A0.Columns["cFa2"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbMa2FA");
		FC2E01A0.Columns["cUseragent"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbUseragent");
		FC2E01A0.Columns["cProxy"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbProxy");
		FC2E01A0.Columns["cDateCreateAcc"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbNgayTao");
		FC2E01A0.Columns["cAvatar"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbAvatar");
		FC2E01A0.Columns["cProfile"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbProfile");
		FC2E01A0.Columns["cInfo"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbTinhTrang");
		FC2E01A0.Columns["cThuMuc"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbThuMuc");
		FC2E01A0.Columns["cGhiChu"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbGhiChu");
		FC2E01A0.Columns["cFollow"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbFollow");
		FC2E01A0.Columns["cInteractEnd"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbInteractEnd");
		FC2E01A0.Columns["cMailRecovery"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbMailRecovery");
		FC2E01A0.Columns["cPhone"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbPhone");
		FC2E01A0.Columns["cHometown"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbHometown");
		FC2E01A0.Columns["cCurrentCity"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbCurrentCity");
		FC2E01A0.Columns["cJob"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbJob");
		FC2E01A0.Columns["cLocation"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbLocation");
		FC2E01A0.Columns["cDating"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbDating");
		FC2E01A0.Columns["cAds"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbAds");
		FC2E01A0.Columns["cBM"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbBM");
		FC2E01A0.Columns["cWallPosts"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbWallPosts");
		FC2E01A0.Columns["cFbBlock"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbFbBlock");
	}

	private void FC2E01A0_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if (bool_3 && e.ColumnIndex == 0)
		{
			method_15();
		}
	}

	private void FBA8F9A2(string string_1)
	{
		GClass8.smethod_33(new DA3DAB8C());
		string text = DA3DAB8C.string_0;
		if (text == "")
		{
			return;
		}
		List<string> list = new List<string>();
		for (int i = 0; i < FC2E01A0.Rows.Count; i++)
		{
			try
			{
				if (Convert.ToBoolean(EA892A22(i, "cChose")))
				{
					string text2 = EA892A22(i, "cUid");
					list.Add(string_1 + "\\" + text2 + "|" + text + "\\" + text2);
				}
			}
			catch
			{
			}
		}
		if (list.Count > 0)
		{
			GClass8.smethod_33(new fShowProgressBar(list));
			GClass29.smethod_0("Đa\u0303 copy dư\u0303 liê\u0323u xong!");
		}
	}

	private void BD992F3E_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fTienIchCheckLiveUid());
	}

	private void DA36E508(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fContact());
	}

	private void FC2E01A0_SelectionChanged(object sender, EventArgs e)
	{
		lblCountHighline.Text = FC2E01A0.SelectedRows.Count.ToString();
	}

	private void FC2E01A0_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex == 0 && e.RowIndex > -1)
		{
			try
			{
				FC2E01A0.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(FC2E01A0.CurrentRow.Cells["cChose"].Value);
				method_15();
			}
			catch
			{
			}
		}
	}

	private void method_35(object sender, EventArgs e)
	{
		for (int i = 0; i < FC2E01A0.RowCount; i++)
		{
			if (Convert.ToBoolean(FC2E01A0.Rows[i].Cells["cChose"].Value))
			{
				FC2E01A0.Rows.RemoveAt(i--);
			}
		}
		B2B3FFA2();
		method_14();
		method_15(0);
	}

	private void F0B54B2A_Click(object sender, EventArgs e)
	{
		method_6("cEmail|cPassMail|cMailRecovery");
	}

	private void txbSearch_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			BtnSearch_Click(null, null);
		}
	}

	private void toolStripMenuItem_10_Click(object sender, EventArgs e)
	{
		method_16(5);
	}

	private void D3B35212(object sender, EventArgs e)
	{
		method_16(5, bool_4: true);
	}

	private void A7883BB7_Click(object sender, EventArgs e)
	{
		fLocTheoDanhSachUid fLocTheoDanhSachUid2 = new fLocTheoDanhSachUid();
		GClass8.smethod_33(fLocTheoDanhSachUid2);
		List<string> list = GClass8.smethod_28(fLocTheoDanhSachUid2.list_0);
		if (list.Count <= 0)
		{
			return;
		}
		if (list[0].StartsWith("@"))
		{
			for (int i = 0; i < FC2E01A0.RowCount; i++)
			{
				string text = EA892A22(i, "cEmail");
				if (text != "" && text.Contains("@"))
				{
					text = text.Substring(text.IndexOf('@'));
					method_30(i, "cChose", list.Contains(text));
				}
			}
		}
		else
		{
			for (int j = 0; j < FC2E01A0.RowCount; j++)
			{
				string item = EA892A22(j, "cUid");
				string item2 = EA892A22(j, "cEmail");
				method_30(j, "cChose", list.Contains(item) || list.Contains(item2));
			}
		}
		method_15();
	}

	private void D69DFD38(object sender, EventArgs e)
	{
		this.A294D626();
	}

	private void D81B60BF_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new BF19FE85());
	}

	private void toolStripMenuItem_12_MouseEnter(object sender, EventArgs e)
	{
		if (!A6AF1E8F)
		{
			return;
		}
		A6AF1E8F = false;
		toolStripMenuItem_12.DropDownItems.Clear();
		List<string> A10DF136 = new List<string>();
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				string text = "";
				for (int j = 0; j < FC2E01A0.RowCount; j++)
				{
					text = EA892A22(j, "cGhiChu");
					if (text != "")
					{
						string value = Regex.Match(text, "\\((.*?)\\)", RegexOptions.Singleline).Value;
						if (value != "")
						{
							text = text.Replace(value, "").Trim();
						}
						value = Regex.Match(text, "\\[(.*?)\\]").Value;
						if (value != "")
						{
							text = text.Replace(value, "").Trim();
						}
						if (text.StartsWith("282-") && text.Split('-').Length > 1)
						{
							text = text.Split('-')[0] + "-" + text.Split('-')[1];
						}
						if (text != "" && !A10DF136.Contains(text))
						{
							A10DF136.Add(text);
						}
					}
				}
			}
			catch (Exception)
			{
			}
		});
		thread.Start();
		if (!thread.Join(5000))
		{
			thread.Abort();
		}
		for (int i = 0; i < A10DF136.Count; i++)
		{
			toolStripMenuItem_12.DropDownItems.Add(A10DF136[i]);
			toolStripMenuItem_12.DropDownItems[i].Click += method_36;
		}
	}

	private void method_36(object sender, EventArgs e)
	{
		method_9("cGhiChu", (sender as ToolStripMenuItem).Text);
	}

	private void checkStatusXproxyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fTienIchCheckStatusXProxy());
	}

	private void toolStripMenuItem_13_Click(object sender, EventArgs e)
	{
		method_16(6, bool_4: true);
	}

	private void EAAAFC1C(object sender, EventArgs e)
	{
		int_3++;
		if (int_3 >= 3)
		{
			int_3 = 0;
			new fCauHinhDebug().ShowDialog();
		}
	}

	private void FEBB8A85(object sender, EventArgs e)
	{
		E188DEB9();
	}

	private void E188DEB9()
	{
		if (!D12766B9())
		{
			return;
		}
		GClass8.smethod_33(new fCauHinhKhoiPhucTaiKhoan());
		if (fCauHinhKhoiPhucTaiKhoan.bool_0)
		{
			try
			{
				if (fCauHinhKhoiPhucTaiKhoan.int_0 == 0)
				{
					List<string> list = new List<string>();
					List<string> list2 = new List<string>();
					for (int i = 0; i < FC2E01A0.RowCount; i++)
					{
						if (Convert.ToBoolean(FC2E01A0.Rows[i].Cells["cChose"].Value))
						{
							string text = GClass27.smethod_3(FC2E01A0, i, "cId");
							string item = Class15.smethod_16(text);
							list.Add(text);
							list2.Add(item);
							FC2E01A0.Rows.RemoveAt(i--);
						}
					}
					B2B3FFA2();
					Class15.smethod_11(list2, "active", "1");
					if (Class15.DB0FC1AC(list, "active", "1"))
					{
						GClass29.smethod_0(string.Format(F7AB102E.smethod_0("Đa\u0303 khôi phu\u0323c tha\u0300nh công {0} ta\u0300i khoa\u0309n!"), list.Count));
					}
					else
					{
						GClass29.smethod_0("Lô\u0303i khôi phu\u0323c ta\u0300i khoa\u0309n, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
					}
				}
				else
				{
					string b69D49A = fCauHinhKhoiPhucTaiKhoan.string_0;
					List<string> list3 = new List<string>();
					for (int j = 0; j < FC2E01A0.RowCount; j++)
					{
						if (Convert.ToBoolean(FC2E01A0.Rows[j].Cells["cChose"].Value))
						{
							string item2 = GClass27.smethod_3(FC2E01A0, j, "cId");
							list3.Add(item2);
							FC2E01A0.Rows.RemoveAt(j--);
						}
					}
					B2B3FFA2();
					if (Class15.DB0FC1AC(list3, "idFile", b69D49A) && Class15.DB0FC1AC(list3, "active", "1"))
					{
						GClass29.smethod_0(string.Format(F7AB102E.smethod_0("Đa\u0303 khôi phu\u0323c tha\u0300nh công {0} ta\u0300i khoa\u0309n!"), list3.Count));
					}
					else
					{
						GClass29.smethod_0("Lô\u0303i khôi phu\u0323c ta\u0300i khoa\u0309n, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
					}
				}
			}
			catch (Exception f4295AA)
			{
				GClass8.BFBDF687(null, f4295AA, "Khoi Phuc Tai Khoan");
			}
		}
		method_14();
		method_15();
	}

	private void C5B8E6A8()
	{
		if (!D12766B9())
		{
			return;
		}
		List<string> list = new List<string>();
		for (int i = 0; i < FC2E01A0.RowCount; i++)
		{
			if (Convert.ToBoolean(FC2E01A0.Rows[i].Cells["cChose"].Value))
			{
				list.Add(FC2E01A0.Rows[i].Cells["cId"].Value.ToString());
			}
		}
		if (list.Count == 0)
		{
			GClass29.smethod_0("Vui lòng chọn tài khoản cần xóa!", 3);
			return;
		}
		if (GClass29.smethod_1(string.Format(F7AB102E.smethod_0("Bạn có thực sự muốn xóa {0} tài khoản đã chọn?"), list.Count) + "\r\n\r\n" + F7AB102E.smethod_0("Chu\u0301 y\u0301: Ta\u0300i khoa\u0309n đa\u0303 xo\u0301a thi\u0300 không thê\u0309 khôi phu\u0323c la\u0323i đươ\u0323c nư\u0303a!")) == DialogResult.Yes)
		{
			if (!Class15.A7BEDD3C(list, C1A3C025: true))
			{
				GClass29.smethod_0("Xóa thất bại, vui lòng thử lại sau!", 2);
				return;
			}
			for (int j = 0; j < FC2E01A0.RowCount; j++)
			{
				if (Convert.ToBoolean(FC2E01A0.Rows[j].Cells["cChose"].Value))
				{
					FC2E01A0.Rows.RemoveAt(j--);
				}
			}
			Class15.smethod_6();
			B2B3FFA2();
		}
		method_14();
		method_15();
	}

	private void F328AC2B_Click(object sender, EventArgs e)
	{
		C5B8E6A8();
	}

	private void C436F517_Click(object sender, EventArgs e)
	{
		E188DEB9();
	}

	private void AB2BCD8F(object sender, EventArgs e)
	{
		C5B8E6A8();
	}

	private void toolStripMenuItem1_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < FC2E01A0.RowCount; i++)
		{
			if (Convert.ToBoolean(FC2E01A0.Rows[i].Cells["cChose"].Value))
			{
				FC2E01A0.Rows.RemoveAt(i--);
			}
		}
		B2B3FFA2();
		method_14();
		method_15(0);
	}

	private void F7B0B6A7(object sender, EventArgs e)
	{
		for (int i = 0; i < FC2E01A0.RowCount; i++)
		{
			if (!Convert.ToBoolean(FC2E01A0.Rows[i].Cells["cChose"].Value))
			{
				FC2E01A0.Rows.RemoveAt(i--);
			}
		}
		B2B3FFA2();
		method_14();
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
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DC9EAA81));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		ctmsAcc = new System.Windows.Forms.ContextMenuStrip(icontainer_0);
		D0BECAB7 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		B290909B = new System.Windows.Forms.ToolStripMenuItem();
		tinhTrangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		A22EEC0C = new System.Windows.Forms.ToolStripMenuItem();
		A7883BB7 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_12 = new System.Windows.Forms.ToolStripMenuItem();
		F693C913 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		C436F517 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_14 = new System.Windows.Forms.ToolStripMenuItem();
		copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		uidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		FD258E2F = new System.Windows.Forms.ToolStripMenuItem();
		tokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		FA0E751D = new System.Windows.Forms.ToolStripMenuItem();
		mailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		fAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
		C936D995 = new System.Windows.Forms.ToolStripMenuItem();
		uidPass2FaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		B481618B = new System.Windows.Forms.ToolStripMenuItem();
		F0B54B2A = new System.Windows.Forms.ToolStripMenuItem();
		F51CC91A = new System.Windows.Forms.ToolStripMenuItem();
		E02B1B0D = new System.Windows.Forms.ToolStripMenuItem();
		uidPassTokenCookieMailPassMail2faToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		useragentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		proxyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		DF938226 = new System.Windows.Forms.ToolStripMenuItem();
		CE0B252D = new System.Windows.Forms.ToolStripMenuItem();
		AF329D23 = new System.Windows.Forms.ToolStripMenuItem();
		checkInfoUIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_10 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_11 = new System.Windows.Forms.ToolStripMenuItem();
		DC84E9A5 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		checkAvatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		D581D426 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_13 = new System.Windows.Forms.ToolStripMenuItem();
		checkProfileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		B51C071B = new System.Windows.Forms.ToolStripMenuItem();
		checkProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		C1A39D9F = new System.Windows.Forms.ToolStripMenuItem();
		lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		locTrungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		checkProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
		D9AA529A = new System.Windows.Forms.ToolStripMenuItem();
		BE0E1BBB = new System.Windows.Forms.ToolStripMenuItem();
		C105F23A = new System.Windows.Forms.ToolStripMenuItem();
		getTokenEAAAAUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		getTokenEAAAAUBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		FFA5C41A = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		FD09ABAC = new System.Windows.Forms.Panel();
		A2BB4E19 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		btnMaximize = new System.Windows.Forms.Button();
		C2BBE483 = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		menuStrip1 = new System.Windows.Forms.MenuStrip();
		toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_5 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_6 = new System.Windows.Forms.ToolStripMenuItem();
		BD992F3E = new System.Windows.Forms.ToolStripMenuItem();
		FA179E81 = new System.Windows.Forms.ToolStripMenuItem();
		checkHotmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_7 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_8 = new System.Windows.Forms.ToolStripMenuItem();
		checkStatusXproxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		D81B60BF = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_9 = new System.Windows.Forms.ToolStripMenuItem();
		DF87A63E = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		D0084038 = new System.Windows.Forms.ToolTip(icontainer_0);
		B907A795 = new System.Windows.Forms.Button();
		miniToolStrip = new System.Windows.Forms.StatusStrip();
		DCB7C820 = new System.Windows.Forms.ToolStripStatusLabel();
		lblCountHighline = new System.Windows.Forms.ToolStripStatusLabel();
		E68E9BA2 = new System.Windows.Forms.ToolStripStatusLabel();
		D9AF668F = new System.Windows.Forms.ToolStripStatusLabel();
		toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
		B59CD508 = new System.Windows.Forms.ToolStripStatusLabel();
		panel2 = new System.Windows.Forms.Panel();
		BtnSearch = new System.Windows.Forms.Button();
		cbbSearch = new System.Windows.Forms.ComboBox();
		txbSearch = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
		FB151835 = new System.Windows.Forms.Panel();
		cbbTinhTrang = new System.Windows.Forms.ComboBox();
		D9970838 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		cbbThuMuc = new System.Windows.Forms.ComboBox();
		FB1FEA84 = new System.Windows.Forms.Panel();
		F328AC2B = new System.Windows.Forms.Button();
		BC32F63B = new System.Windows.Forms.Button();
		A2B3B43D = new System.Windows.Forms.StatusStrip();
		FC2E01A0 = new System.Windows.Forms.DataGridView();
		cChose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		B83CE197 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cUid = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cCookies = new System.Windows.Forms.DataGridViewTextBoxColumn();
		C8055AB4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cFollow = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cFriend = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cPagePro5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
		BA9EB309 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cMailRecovery = new System.Windows.Forms.DataGridViewTextBoxColumn();
		EB3E7D28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cOAuth2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		D19A288B = new System.Windows.Forms.DataGridViewTextBoxColumn();
		DB88FDA0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cProxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
		E72E22AF = new System.Windows.Forms.DataGridViewTextBoxColumn();
		E6B52429 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		D4B1EA2B = new System.Windows.Forms.DataGridViewTextBoxColumn();
		FD19ABA8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		B18DBE2F = new System.Windows.Forms.DataGridViewTextBoxColumn();
		C6A02F16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
		CCAD2D81 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		C8958DBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
		CD39963D = new System.Windows.Forms.DataGridViewTextBoxColumn();
		A9AB0298 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cAds = new System.Windows.Forms.DataGridViewTextBoxColumn();
		DA351814 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cWallPosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cFbBlock = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cDateDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
		ctmsAcc.SuspendLayout();
		FD09ABAC.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)A2BB4E19).BeginInit();
		bunifuCards1.SuspendLayout();
		menuStrip1.SuspendLayout();
		panel2.SuspendLayout();
		FB151835.SuspendLayout();
		FB1FEA84.SuspendLayout();
		A2B3B43D.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)FC2E01A0).BeginInit();
		SuspendLayout();
		ctmsAcc.Items.AddRange(new System.Windows.Forms.ToolStripItem[11]
		{
			D0BECAB7, F693C913, toolStripMenuItem1, toolStripMenuItem2, C436F517, toolStripMenuItem_14, copyToolStripMenuItem, CE0B252D, C1A39D9F, profileToolStripMenuItem,
			C105F23A
		});
		ctmsAcc.Name = "ctmsAcc";
		ctmsAcc.Size = new System.Drawing.Size(198, 246);
		ctmsAcc.Opening += new System.ComponentModel.CancelEventHandler(ctmsAcc_Opening);
		D0BECAB7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[6] { toolStripMenuItem_1, B290909B, tinhTrangToolStripMenuItem, A22EEC0C, A7883BB7, toolStripMenuItem_12 });
		D0BECAB7.Image = (System.Drawing.Image)resources.GetObject("chọnLiveToolStripMenuItem.Image");
		D0BECAB7.Name = "chọnLiveToolStripMenuItem";
		D0BECAB7.Size = new System.Drawing.Size(197, 22);
		D0BECAB7.Text = "Chọn";
		toolStripMenuItem_1.Image = (System.Drawing.Image)resources.GetObject("tấtCảToolStripMenuItem.Image");
		toolStripMenuItem_1.Name = "tấtCảToolStripMenuItem";
		toolStripMenuItem_1.Size = new System.Drawing.Size(128, 22);
		toolStripMenuItem_1.Text = "Tất cả";
		toolStripMenuItem_1.Click += new System.EventHandler(toolStripMenuItem_1_Click);
		B290909B.Image = (System.Drawing.Image)resources.GetObject("liveToolStripMenuItem.Image");
		B290909B.Name = "liveToolStripMenuItem";
		B290909B.Size = new System.Drawing.Size(128, 22);
		B290909B.Text = "Bôi đen";
		B290909B.Click += new System.EventHandler(B290909B_Click);
		tinhTrangToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("tinhTrangToolStripMenuItem.Image");
		tinhTrangToolStripMenuItem.Name = "tinhTrangToolStripMenuItem";
		tinhTrangToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
		tinhTrangToolStripMenuItem.Text = "Ti\u0300nh tra\u0323ng";
		A22EEC0C.Image = (System.Drawing.Image)resources.GetObject("trạngTháiToolStripMenuItem.Image");
		A22EEC0C.Name = "trạngTháiToolStripMenuItem";
		A22EEC0C.Size = new System.Drawing.Size(128, 22);
		A22EEC0C.Text = "Trạng thái";
		A22EEC0C.Click += new System.EventHandler(BBA57B27);
		A7883BB7.Image = C50FB39E.Bitmap_20;
		A7883BB7.Name = "chDanhSáchTheoUIDEmailToolStripMenuItem";
		A7883BB7.Size = new System.Drawing.Size(128, 22);
		A7883BB7.Text = "Theo Uid";
		A7883BB7.Click += new System.EventHandler(A7883BB7_Click);
		toolStripMenuItem_12.Image = (System.Drawing.Image)resources.GetObject("ghiChúToolStripMenuItem.Image");
		toolStripMenuItem_12.Name = "ghiChúToolStripMenuItem";
		toolStripMenuItem_12.Size = new System.Drawing.Size(128, 22);
		toolStripMenuItem_12.Text = "Ghi chu\u0301";
		toolStripMenuItem_12.MouseEnter += new System.EventHandler(toolStripMenuItem_12_MouseEnter);
		F693C913.Image = (System.Drawing.Image)resources.GetObject("bỏChọnTấtCảToolStripMenuItem.Image");
		F693C913.Name = "bỏChọnTấtCảToolStripMenuItem";
		F693C913.Size = new System.Drawing.Size(197, 22);
		F693C913.Text = "Bỏ chọn tất cả";
		F693C913.Click += new System.EventHandler(A32B19B0);
		toolStripMenuItem1.Image = C50FB39E.B027EBA7;
		toolStripMenuItem1.Name = "toolStripMenuItem1";
		toolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
		toolStripMenuItem1.Text = "Ẩn dòng tích chọn";
		toolStripMenuItem1.Click += new System.EventHandler(toolStripMenuItem1_Click);
		toolStripMenuItem2.Image = C50FB39E.B027EBA7;
		toolStripMenuItem2.Name = "toolStripMenuItem2";
		toolStripMenuItem2.Size = new System.Drawing.Size(197, 22);
		toolStripMenuItem2.Text = "Ẩn dòng không tích";
		toolStripMenuItem2.Click += new System.EventHandler(F7B0B6A7);
		C436F517.Image = C50FB39E.Bitmap_134;
		C436F517.Name = "khôiPhucTaiKhoanToolStripMenuItem";
		C436F517.Size = new System.Drawing.Size(197, 22);
		C436F517.Text = "Khôi phu\u0323c ta\u0300i khoa\u0309n";
		C436F517.Click += new System.EventHandler(C436F517_Click);
		toolStripMenuItem_14.Image = C50FB39E.Bitmap_82;
		toolStripMenuItem_14.Name = "xóaTàiKhoảnToolStripMenuItem";
		toolStripMenuItem_14.Size = new System.Drawing.Size(197, 22);
		toolStripMenuItem_14.Text = "Xóa ta\u0300i khoa\u0309n vi\u0303nh viê\u0303n";
		toolStripMenuItem_14.Click += new System.EventHandler(AB2BCD8F);
		copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[17]
		{
			uidToolStripMenuItem, FD258E2F, tokenToolStripMenuItem, FA0E751D, mailToolStripMenuItem, fAToolStripMenuItem, toolStripMenuItem_4, C936D995, uidPass2FaToolStripMenuItem, B481618B,
			F0B54B2A, F51CC91A, E02B1B0D, uidPassTokenCookieMailPassMail2faToolStripMenuItem, useragentToolStripMenuItem1, proxyToolStripMenuItem1, DF938226
		});
		copyToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("copyToolStripMenuItem.Image");
		copyToolStripMenuItem.Name = "copyToolStripMenuItem";
		copyToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
		copyToolStripMenuItem.Text = "Copy";
		uidToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidToolStripMenuItem.Image");
		uidToolStripMenuItem.Name = "uidToolStripMenuItem";
		uidToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		uidToolStripMenuItem.Text = "Uid";
		uidToolStripMenuItem.Click += new System.EventHandler(uidToolStripMenuItem_Click);
		FD258E2F.Image = (System.Drawing.Image)resources.GetObject("passToolStripMenuItem.Image");
		FD258E2F.Name = "passToolStripMenuItem";
		FD258E2F.Size = new System.Drawing.Size(289, 22);
		FD258E2F.Text = "Pass";
		FD258E2F.Click += new System.EventHandler(FD258E2F_Click);
		tokenToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("tokenToolStripMenuItem.Image");
		tokenToolStripMenuItem.Name = "tokenToolStripMenuItem";
		tokenToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		tokenToolStripMenuItem.Text = "Token";
		tokenToolStripMenuItem.Click += new System.EventHandler(tokenToolStripMenuItem_Click);
		FA0E751D.Image = (System.Drawing.Image)resources.GetObject("cookieToolStripMenuItem.Image");
		FA0E751D.Name = "cookieToolStripMenuItem";
		FA0E751D.Size = new System.Drawing.Size(289, 22);
		FA0E751D.Text = "Cookie";
		FA0E751D.Click += new System.EventHandler(FA0E751D_Click);
		mailToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("mailToolStripMenuItem.Image");
		mailToolStripMenuItem.Name = "mailToolStripMenuItem";
		mailToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		mailToolStripMenuItem.Text = "Email";
		mailToolStripMenuItem.Click += new System.EventHandler(mailToolStripMenuItem_Click);
		fAToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("fAToolStripMenuItem.Image");
		fAToolStripMenuItem.Name = "fAToolStripMenuItem";
		fAToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		fAToolStripMenuItem.Text = "2FA";
		fAToolStripMenuItem.Click += new System.EventHandler(E70D2A17);
		toolStripMenuItem_4.Image = (System.Drawing.Image)resources.GetObject("maBaoMât6SôToolStripMenuItem.Image");
		toolStripMenuItem_4.Name = "maBaoMât6SôToolStripMenuItem";
		toolStripMenuItem_4.Size = new System.Drawing.Size(289, 22);
		toolStripMenuItem_4.Text = "Ma\u0303 ba\u0309o mâ\u0323t 6 sô\u0301 từ 2FA";
		toolStripMenuItem_4.Click += new System.EventHandler(D8A4AD1F);
		C936D995.Image = (System.Drawing.Image)resources.GetObject("uidPassToolStripMenuItem.Image");
		C936D995.Name = "uidPassToolStripMenuItem";
		C936D995.Size = new System.Drawing.Size(289, 22);
		C936D995.Text = "Uid|Pass";
		C936D995.Click += new System.EventHandler(C936D995_Click);
		uidPass2FaToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidPass2FaToolStripMenuItem.Image");
		uidPass2FaToolStripMenuItem.Name = "uidPass2FaToolStripMenuItem";
		uidPass2FaToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		uidPass2FaToolStripMenuItem.Text = "Uid|Pass|2Fa";
		uidPass2FaToolStripMenuItem.Click += new System.EventHandler(uidPass2FaToolStripMenuItem_Click);
		B481618B.Image = (System.Drawing.Image)resources.GetObject("mailPassMailToolStripMenuItem.Image");
		B481618B.Name = "mailPassMailToolStripMenuItem";
		B481618B.Size = new System.Drawing.Size(289, 22);
		B481618B.Text = "Mail|Pass mail";
		B481618B.Click += new System.EventHandler(B481618B_Click);
		F0B54B2A.Image = C50FB39E.EF32278F;
		F0B54B2A.Name = "emailPassMailMailKpToolStripMenuItem";
		F0B54B2A.Size = new System.Drawing.Size(289, 22);
		F0B54B2A.Text = "Email|PassMail|MailKp";
		F0B54B2A.Click += new System.EventHandler(F0B54B2A_Click);
		F51CC91A.Image = (System.Drawing.Image)resources.GetObject("uidPassTokenCookieToolStripMenuItem.Image");
		F51CC91A.Name = "uidPassTokenCookieToolStripMenuItem";
		F51CC91A.Size = new System.Drawing.Size(289, 22);
		F51CC91A.Text = "Uid|Pass|Token|Cookie";
		F51CC91A.Click += new System.EventHandler(F51CC91A_Click);
		E02B1B0D.Image = (System.Drawing.Image)resources.GetObject("uidPassTokenCookieMailPassMailToolStripMenuItem.Image");
		E02B1B0D.Name = "uidPassTokenCookieMailPassMailToolStripMenuItem";
		E02B1B0D.Size = new System.Drawing.Size(289, 22);
		E02B1B0D.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail";
		E02B1B0D.Click += new System.EventHandler(E02B1B0D_Click);
		uidPassTokenCookieMailPassMail2faToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidPassTokenCookieMailPassMail2faToolStripMenuItem.Image");
		uidPassTokenCookieMailPassMail2faToolStripMenuItem.Name = "uidPassTokenCookieMailPassMail2faToolStripMenuItem";
		uidPassTokenCookieMailPassMail2faToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		uidPassTokenCookieMailPassMail2faToolStripMenuItem.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail|2fa";
		uidPassTokenCookieMailPassMail2faToolStripMenuItem.Click += new System.EventHandler(E19E068E);
		useragentToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("useragentToolStripMenuItem1.Image");
		useragentToolStripMenuItem1.Name = "useragentToolStripMenuItem1";
		useragentToolStripMenuItem1.Size = new System.Drawing.Size(289, 22);
		useragentToolStripMenuItem1.Text = "Useragent";
		useragentToolStripMenuItem1.Click += new System.EventHandler(DFA673A3);
		proxyToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("proxyToolStripMenuItem1.Image");
		proxyToolStripMenuItem1.Name = "proxyToolStripMenuItem1";
		proxyToolStripMenuItem1.Size = new System.Drawing.Size(289, 22);
		proxyToolStripMenuItem1.Text = "Proxy";
		proxyToolStripMenuItem1.Click += new System.EventHandler(proxyToolStripMenuItem1_Click);
		DF938226.Image = (System.Drawing.Image)resources.GetObject("đinhDangKhacToolStripMenuItem.Image");
		DF938226.Name = "đinhDangKhacToolStripMenuItem";
		DF938226.Size = new System.Drawing.Size(289, 22);
		DF938226.Text = "Other...";
		DF938226.Click += new System.EventHandler(DF938226_Click);
		CE0B252D.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[8] { AF329D23, checkInfoUIDToolStripMenuItem, DC84E9A5, toolStripMenuItem_2, checkAvatarToolStripMenuItem, checkProfileToolStripMenuItem1, B51C071B, checkProxyToolStripMenuItem });
		CE0B252D.Image = (System.Drawing.Image)resources.GetObject("checkCookieToolStripMenuItem.Image");
		CE0B252D.Name = "checkCookieToolStripMenuItem";
		CE0B252D.Size = new System.Drawing.Size(197, 22);
		CE0B252D.Text = "Kiểm tra tài khoản";
		CE0B252D.Click += new System.EventHandler(CE0B252D_Click);
		AF329D23.Name = "kiểmTraWallToolStripMenuItem";
		AF329D23.Size = new System.Drawing.Size(199, 22);
		AF329D23.Text = "Check Wall";
		AF329D23.ToolTipText = "Không cần dùng token";
		AF329D23.Click += new System.EventHandler(CC885936);
		checkInfoUIDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { toolStripMenuItem_10, toolStripMenuItem_11 });
		checkInfoUIDToolStripMenuItem.Name = "checkInfoUIDToolStripMenuItem";
		checkInfoUIDToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
		checkInfoUIDToolStripMenuItem.Text = "Check Info Uid";
		checkInfoUIDToolStripMenuItem.ToolTipText = "Không cần dùng token\r\nCâ\u0323p nhâ\u0323t thông tin: Ho\u0323 tên, Giớ\u0301i ti\u0301nh, [Email], [Ba\u0323n be\u0300], [Nho\u0301m], [Nga\u0300y sinh]";
		toolStripMenuItem_10.Name = "sửDụngIPMáyToolStripMenuItem";
		toolStripMenuItem_10.Size = new System.Drawing.Size(190, 22);
		toolStripMenuItem_10.Text = "Không đổi IP";
		toolStripMenuItem_10.Click += new System.EventHandler(toolStripMenuItem_10_Click);
		toolStripMenuItem_11.Name = "sửDụngProxyĐãGánToolStripMenuItem";
		toolStripMenuItem_11.Size = new System.Drawing.Size(190, 22);
		toolStripMenuItem_11.Text = "Sử dụng proxy đã gán";
		toolStripMenuItem_11.Click += new System.EventHandler(D3B35212);
		DC84E9A5.Name = "kiểmTraTokenToolStripMenuItem";
		DC84E9A5.Size = new System.Drawing.Size(199, 22);
		DC84E9A5.Text = "Check Token";
		DC84E9A5.Click += new System.EventHandler(DC380B11);
		toolStripMenuItem_2.Name = "kiểmTraCookieToolStripMenuItem";
		toolStripMenuItem_2.Size = new System.Drawing.Size(199, 22);
		toolStripMenuItem_2.Text = "Check Cookie";
		toolStripMenuItem_2.Click += new System.EventHandler(toolStripMenuItem_2_Click);
		checkAvatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { D581D426, toolStripMenuItem_13 });
		checkAvatarToolStripMenuItem.Name = "checkAvatarToolStripMenuItem";
		checkAvatarToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
		checkAvatarToolStripMenuItem.Text = "Check Avatar";
		D581D426.Name = "khôngĐổiIPToolStripMenuItem";
		D581D426.Size = new System.Drawing.Size(190, 22);
		D581D426.Text = "Không đổi IP";
		D581D426.Click += new System.EventHandler(A3AFBF1C);
		toolStripMenuItem_13.Name = "sửDụngProxyĐãGánToolStripMenuItem1";
		toolStripMenuItem_13.Size = new System.Drawing.Size(190, 22);
		toolStripMenuItem_13.Text = "Sử dụng proxy đã gán";
		toolStripMenuItem_13.Click += new System.EventHandler(toolStripMenuItem_13_Click);
		checkProfileToolStripMenuItem1.Name = "checkProfileToolStripMenuItem1";
		checkProfileToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
		checkProfileToolStripMenuItem1.Text = "Check Profile";
		checkProfileToolStripMenuItem1.Click += new System.EventHandler(checkProfileToolStripMenuItem_Click);
		B51C071B.Name = "kiểmTraMailpassMailToolStripMenuItem";
		B51C071B.Size = new System.Drawing.Size(199, 22);
		B51C071B.Text = "Check Connect hotmail";
		B51C071B.Click += new System.EventHandler(AE8AE3AE);
		checkProxyToolStripMenuItem.Name = "checkProxyToolStripMenuItem";
		checkProxyToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
		checkProxyToolStripMenuItem.Text = "Check Proxy";
		checkProxyToolStripMenuItem.Click += new System.EventHandler(AEB15804);
		C1A39D9F.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { lToolStripMenuItem, locTrungToolStripMenuItem });
		C1A39D9F.Image = (System.Drawing.Image)resources.GetObject("mnuChucNang.Image");
		C1A39D9F.Name = "mnuChucNang";
		C1A39D9F.Size = new System.Drawing.Size(197, 22);
		C1A39D9F.Text = "Chức năng";
		lToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("lToolStripMenuItem.Image");
		lToolStripMenuItem.Name = "lToolStripMenuItem";
		lToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
		lToolStripMenuItem.Text = "Lọc tài khoản theo Uid";
		lToolStripMenuItem.Click += new System.EventHandler(lToolStripMenuItem_Click);
		locTrungToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("locTrungToolStripMenuItem.Image");
		locTrungToolStripMenuItem.Name = "locTrungToolStripMenuItem";
		locTrungToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
		locTrungToolStripMenuItem.Text = "Lọc tài khoản trùng nhau";
		locTrungToolStripMenuItem.Click += new System.EventHandler(locTrungToolStripMenuItem_Click);
		profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { checkProfileToolStripMenuItem, toolStripMenuItem_3, D9AA529A, BE0E1BBB });
		profileToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("profileToolStripMenuItem.Image");
		profileToolStripMenuItem.Name = "profileToolStripMenuItem";
		profileToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
		profileToolStripMenuItem.Text = "Profile Chrome";
		checkProfileToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("checkProfileToolStripMenuItem.Image");
		checkProfileToolStripMenuItem.Name = "checkProfileToolStripMenuItem";
		checkProfileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
		checkProfileToolStripMenuItem.Text = "Check profile";
		checkProfileToolStripMenuItem.Click += new System.EventHandler(checkProfileToolStripMenuItem_Click);
		toolStripMenuItem_3.Image = (System.Drawing.Image)resources.GetObject("xóaProfileToolStripMenuItem.Image");
		toolStripMenuItem_3.Name = "xóaProfileToolStripMenuItem";
		toolStripMenuItem_3.Size = new System.Drawing.Size(167, 22);
		toolStripMenuItem_3.Text = "Xóa profile";
		toolStripMenuItem_3.Click += new System.EventHandler(E1802BB4);
		D9AA529A.Image = (System.Drawing.Image)resources.GetObject("donDepProfileToolStripMenuItem.Image");
		D9AA529A.Name = "donDepProfileToolStripMenuItem";
		D9AA529A.Size = new System.Drawing.Size(167, 22);
		D9AA529A.Text = "Do\u0323n de\u0323p profile";
		D9AA529A.Click += new System.EventHandler(C19E3318);
		BE0E1BBB.Image = (System.Drawing.Image)resources.GetObject("xóaCacheToolStripMenuItem.Image");
		BE0E1BBB.Name = "xóaCacheToolStripMenuItem";
		BE0E1BBB.Size = new System.Drawing.Size(167, 22);
		BE0E1BBB.Text = "Xóa Cache Profile";
		BE0E1BBB.Click += new System.EventHandler(BE0E1BBB_Click);
		C105F23A.Image = (System.Drawing.Image)resources.GetObject("tảiLạiDanhSáchToolStripMenuItem.Image");
		C105F23A.Name = "tảiLạiDanhSáchToolStripMenuItem";
		C105F23A.Size = new System.Drawing.Size(197, 22);
		C105F23A.Text = "Tải lại danh sách";
		C105F23A.Click += new System.EventHandler(C78EA98A);
		getTokenEAAAAUToolStripMenuItem.Name = "getTokenEAAAAUToolStripMenuItem";
		getTokenEAAAAUToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
		getTokenEAAAAUToolStripMenuItem.Text = "Get Token EAAAAU";
		getTokenEAAAAUBToolStripMenuItem.Name = "getTokenEAAAAUBToolStripMenuItem";
		getTokenEAAAAUBToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
		getTokenEAAAAUBToolStripMenuItem.Text = "Get Token EAAAAU + Bật 2FA";
		FFA5C41A.Fixed = true;
		FFA5C41A.Horizontal = true;
		FFA5C41A.TargetControl = FD09ABAC;
		FFA5C41A.Vertical = true;
		FD09ABAC.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		FD09ABAC.BackColor = System.Drawing.Color.White;
		FD09ABAC.Controls.Add(A2BB4E19);
		FD09ABAC.Controls.Add(btnMinimize);
		FD09ABAC.Controls.Add(btnMaximize);
		FD09ABAC.Controls.Add(C2BBE483);
		FD09ABAC.Controls.Add(bunifuCustomLabel1);
		FD09ABAC.Cursor = System.Windows.Forms.Cursors.SizeAll;
		FD09ABAC.Location = new System.Drawing.Point(2, 5);
		FD09ABAC.Name = "pnlHeader";
		FD09ABAC.Size = new System.Drawing.Size(1220, 29);
		FD09ABAC.TabIndex = 0;
		FD09ABAC.DoubleClick += new System.EventHandler(D69DFD38);
		A2BB4E19.Cursor = System.Windows.Forms.Cursors.Arrow;
		A2BB4E19.Image = C50FB39E.Bitmap_5;
		A2BB4E19.Location = new System.Drawing.Point(6, 1);
		A2BB4E19.Name = "pictureBox1";
		A2BB4E19.Size = new System.Drawing.Size(34, 27);
		A2BB4E19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		A2BB4E19.TabIndex = 12;
		A2BB4E19.TabStop = false;
		A2BB4E19.Click += new System.EventHandler(A2BB4E19_Click);
		A2BB4E19.DoubleClick += new System.EventHandler(FB09ED8D);
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(1124, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 29);
		btnMinimize.TabIndex = 0;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMaximize.FlatAppearance.BorderSize = 0;
		btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMaximize.ForeColor = System.Drawing.Color.White;
		btnMaximize.Image = (System.Drawing.Image)resources.GetObject("btnMaximize.Image");
		btnMaximize.Location = new System.Drawing.Point(1156, 0);
		btnMaximize.Name = "btnMaximize";
		btnMaximize.Size = new System.Drawing.Size(32, 29);
		btnMaximize.TabIndex = 1;
		btnMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMaximize.UseVisualStyleBackColor = true;
		btnMaximize.Click += new System.EventHandler(btnMaximize_Click);
		C2BBE483.Cursor = System.Windows.Forms.Cursors.Hand;
		C2BBE483.Dock = System.Windows.Forms.DockStyle.Right;
		C2BBE483.FlatAppearance.BorderSize = 0;
		C2BBE483.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C2BBE483.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C2BBE483.ForeColor = System.Drawing.Color.White;
		C2BBE483.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
		C2BBE483.Location = new System.Drawing.Point(1188, 0);
		C2BBE483.Name = "btnClose";
		C2BBE483.Size = new System.Drawing.Size(32, 29);
		C2BBE483.TabIndex = 2;
		C2BBE483.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		C2BBE483.UseVisualStyleBackColor = true;
		C2BBE483.Click += new System.EventHandler(C2BBE483_Click);
		bunifuCustomLabel1.AutoSize = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(43, 6);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(185, 16);
		bunifuCustomLabel1.TabIndex = 3;
		bunifuCustomLabel1.Text = "Danh sách tài khoản đã xóa";
		bunifuCustomLabel1.DoubleClick += new System.EventHandler(EAAAFC1C);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkRed;
		bunifuCards1.Controls.Add(FD09ABAC);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(1223, 38);
		bunifuCards1.TabIndex = 0;
		menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		menuStrip1.AutoSize = false;
		menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
		menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] { toolStripMenuItem_0, toolStripMenuItem_5, toolStripMenuItem_6, toolStripMenuItem_9 });
		menuStrip1.Location = new System.Drawing.Point(1, 37);
		menuStrip1.Name = "menuStrip1";
		menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
		menuStrip1.Size = new System.Drawing.Size(1221, 25);
		menuStrip1.Stretch = false;
		menuStrip1.TabIndex = 1;
		menuStrip1.Text = "menuStrip1";
		toolStripMenuItem_0.Image = (System.Drawing.Image)resources.GetObject("hệThốngToolStripMenuItem.Image");
		toolStripMenuItem_0.Name = "hệThốngToolStripMenuItem";
		toolStripMenuItem_0.Size = new System.Drawing.Size(123, 21);
		toolStripMenuItem_0.Text = "Câ\u0301u hi\u0300nh chung";
		toolStripMenuItem_0.Click += new System.EventHandler(toolStripMenuItem_0_Click);
		toolStripMenuItem_5.Image = (System.Drawing.Image)resources.GetObject("thoátToolStripMenuItem.Image");
		toolStripMenuItem_5.Name = "thoátToolStripMenuItem";
		toolStripMenuItem_5.Size = new System.Drawing.Size(131, 21);
		toolStripMenuItem_5.Text = "Câ\u0301u hi\u0300nh hiê\u0309n thi\u0323";
		toolStripMenuItem_5.Click += new System.EventHandler(toolStripMenuItem_5_Click);
		toolStripMenuItem_6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[7] { BD992F3E, FA179E81, checkHotmailToolStripMenuItem, toolStripMenuItem_7, toolStripMenuItem_8, checkStatusXproxyToolStripMenuItem, D81B60BF });
		toolStripMenuItem_6.Image = (System.Drawing.Image)resources.GetObject("tiệnÍchToolStripMenuItem.Image");
		toolStripMenuItem_6.Name = "tiệnÍchToolStripMenuItem";
		toolStripMenuItem_6.Size = new System.Drawing.Size(80, 21);
		toolStripMenuItem_6.Text = "Tiện ích";
		BD992F3E.Image = (System.Drawing.Image)resources.GetObject("checkLiveUidToolStripMenuItem.Image");
		BD992F3E.Name = "checkLiveUidToolStripMenuItem";
		BD992F3E.Size = new System.Drawing.Size(204, 22);
		BD992F3E.Text = "Check Live Uid";
		BD992F3E.Click += new System.EventHandler(BD992F3E_Click);
		FA179E81.Image = (System.Drawing.Image)resources.GetObject("checkProxyToolStripMenuItem1.Image");
		FA179E81.Name = "checkProxyToolStripMenuItem1";
		FA179E81.Size = new System.Drawing.Size(204, 22);
		FA179E81.Text = "Check Proxy";
		FA179E81.Click += new System.EventHandler(FA179E81_Click);
		checkHotmailToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("checkHotmailToolStripMenuItem.Image");
		checkHotmailToolStripMenuItem.Name = "checkHotmailToolStripMenuItem";
		checkHotmailToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
		checkHotmailToolStripMenuItem.Text = "Check Connect hotmail";
		checkHotmailToolStripMenuItem.Click += new System.EventHandler(checkHotmailToolStripMenuItem_Click);
		toolStripMenuItem_7.Image = (System.Drawing.Image)resources.GetObject("lọcTrùngDữLiệuToolStripMenuItem.Image");
		toolStripMenuItem_7.Name = "lọcTrùngDữLiệuToolStripMenuItem";
		toolStripMenuItem_7.Size = new System.Drawing.Size(204, 22);
		toolStripMenuItem_7.Text = "Lọc trùng dữ liệu";
		toolStripMenuItem_7.Click += new System.EventHandler(A9345DBA);
		toolStripMenuItem_8.Image = (System.Drawing.Image)resources.GetObject("xửLýChuỗiOnlineToolStripMenuItem.Image");
		toolStripMenuItem_8.Name = "xửLýChuỗiOnlineToolStripMenuItem";
		toolStripMenuItem_8.Size = new System.Drawing.Size(204, 22);
		toolStripMenuItem_8.Text = "Xử lý chuỗi cơ bản";
		toolStripMenuItem_8.Click += new System.EventHandler(B99C1580);
		checkStatusXproxyToolStripMenuItem.Image = C50FB39E.Bitmap_28;
		checkStatusXproxyToolStripMenuItem.Name = "checkStatusXproxyToolStripMenuItem";
		checkStatusXproxyToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
		checkStatusXproxyToolStripMenuItem.Text = "Check Xproxy";
		checkStatusXproxyToolStripMenuItem.Click += new System.EventHandler(checkStatusXproxyToolStripMenuItem_Click);
		D81B60BF.Image = C50FB39E.Bitmap_15;
		D81B60BF.Name = "testSpinTextToolStripMenuItem";
		D81B60BF.Size = new System.Drawing.Size(204, 22);
		D81B60BF.Text = "Test Spin Content";
		D81B60BF.Click += new System.EventHandler(D81B60BF_Click);
		toolStripMenuItem_9.Image = (System.Drawing.Image)resources.GetObject("liênHệToolStripMenuItem.Image");
		toolStripMenuItem_9.Name = "liênHệToolStripMenuItem";
		toolStripMenuItem_9.Size = new System.Drawing.Size(76, 21);
		toolStripMenuItem_9.Text = "Liên hệ";
		toolStripMenuItem_9.Click += new System.EventHandler(DA36E508);
		DF87A63E.Fixed = true;
		DF87A63E.Horizontal = true;
		DF87A63E.TargetControl = bunifuCustomLabel1;
		DF87A63E.Vertical = true;
		D0084038.AutomaticDelay = 0;
		D0084038.AutoPopDelay = 30000;
		D0084038.InitialDelay = 0;
		D0084038.ReshowDelay = 40;
		B907A795.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnLoadAcc.BackgroundImage");
		B907A795.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
		B907A795.Cursor = System.Windows.Forms.Cursors.Hand;
		B907A795.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		B907A795.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B907A795.Location = new System.Drawing.Point(395, 2);
		B907A795.Name = "btnLoadAcc";
		B907A795.Size = new System.Drawing.Size(25, 25);
		B907A795.TabIndex = 6;
		D0084038.SetToolTip(B907A795, "Load lại danh sách");
		B907A795.Click += new System.EventHandler(B907A795_Click);
		miniToolStrip.AccessibleName = "New item selection";
		miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
		miniToolStrip.AutoSize = false;
		miniToolStrip.BackColor = System.Drawing.SystemColors.Control;
		miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
		miniToolStrip.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		miniToolStrip.Location = new System.Drawing.Point(0, 0);
		miniToolStrip.Name = "miniToolStrip";
		miniToolStrip.Size = new System.Drawing.Size(1222, 22);
		miniToolStrip.SizingGrip = false;
		miniToolStrip.TabIndex = 9;
		DCB7C820.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DCB7C820.Name = "toolStripStatusLabel4";
		DCB7C820.Size = new System.Drawing.Size(59, 17);
		DCB7C820.Text = "Bôi đen:";
		lblCountHighline.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblCountHighline.ForeColor = System.Drawing.Color.Blue;
		lblCountHighline.Name = "lblCountHighline";
		lblCountHighline.Size = new System.Drawing.Size(15, 17);
		lblCountHighline.Text = "0";
		E68E9BA2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E68E9BA2.Name = "toolStripStatusLabel5";
		E68E9BA2.Size = new System.Drawing.Size(65, 17);
		E68E9BA2.Text = "Đã chọn:";
		D9AF668F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D9AF668F.ForeColor = System.Drawing.Color.FromArgb(0, 64, 0);
		D9AF668F.Name = "lblCountSelect";
		D9AF668F.Size = new System.Drawing.Size(15, 17);
		D9AF668F.Text = "0";
		toolStripStatusLabel7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		toolStripStatusLabel7.Name = "toolStripStatusLabel7";
		toolStripStatusLabel7.Size = new System.Drawing.Size(52, 17);
		toolStripStatusLabel7.Text = "Tất cả:";
		B59CD508.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B59CD508.ForeColor = System.Drawing.Color.Maroon;
		B59CD508.Name = "lblCountTotal";
		B59CD508.Size = new System.Drawing.Size(15, 17);
		B59CD508.Text = "0";
		panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel2.Controls.Add(BtnSearch);
		panel2.Controls.Add(cbbSearch);
		panel2.Controls.Add(txbSearch);
		panel2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		panel2.Location = new System.Drawing.Point(8, 71);
		panel2.Name = "panel2";
		panel2.Size = new System.Drawing.Size(269, 31);
		panel2.TabIndex = 10;
		BtnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		BtnSearch.BackgroundImage = C50FB39E.Bitmap_123;
		BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
		BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BtnSearch.Location = new System.Drawing.Point(240, 3);
		BtnSearch.Name = "BtnSearch";
		BtnSearch.Size = new System.Drawing.Size(24, 23);
		BtnSearch.TabIndex = 3;
		BtnSearch.Click += new System.EventHandler(BtnSearch_Click);
		cbbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbSearch.DropDownWidth = 100;
		cbbSearch.FormattingEnabled = true;
		cbbSearch.Location = new System.Drawing.Point(3, 3);
		cbbSearch.Name = "cbbSearch";
		cbbSearch.Size = new System.Drawing.Size(86, 24);
		cbbSearch.TabIndex = 0;
		txbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txbSearch.BorderColor = System.Drawing.Color.SeaGreen;
		txbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
		txbSearch.Location = new System.Drawing.Point(95, 3);
		txbSearch.Name = "txbSearch";
		txbSearch.Size = new System.Drawing.Size(139, 23);
		txbSearch.TabIndex = 1;
		txbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(txbSearch_KeyDown);
		FB151835.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		FB151835.Controls.Add(cbbTinhTrang);
		FB151835.Controls.Add(B907A795);
		FB151835.Controls.Add(D9970838);
		FB151835.Controls.Add(label2);
		FB151835.Controls.Add(cbbThuMuc);
		FB151835.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		FB151835.Location = new System.Drawing.Point(283, 71);
		FB151835.Name = "plQuanLyThuMuc";
		FB151835.Size = new System.Drawing.Size(424, 31);
		FB151835.TabIndex = 10;
		cbbTinhTrang.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTinhTrang.DropDownWidth = 300;
		cbbTinhTrang.FormattingEnabled = true;
		cbbTinhTrang.ItemHeight = 16;
		cbbTinhTrang.Items.AddRange(new object[1] { "[Tất cả tình trạng]" });
		cbbTinhTrang.Location = new System.Drawing.Point(268, 3);
		cbbTinhTrang.Name = "cbbTinhTrang";
		cbbTinhTrang.Size = new System.Drawing.Size(121, 24);
		cbbTinhTrang.TabIndex = 3;
		cbbTinhTrang.SelectedIndexChanged += new System.EventHandler(cbbTinhTrang_SelectedIndexChanged);
		D9970838.AutoSize = true;
		D9970838.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D9970838.Location = new System.Drawing.Point(-1, 6);
		D9970838.Name = "label1";
		D9970838.Size = new System.Drawing.Size(63, 16);
		D9970838.TabIndex = 0;
		D9970838.Text = "Thư mục:";
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label2.Location = new System.Drawing.Point(232, 5);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(31, 16);
		label2.TabIndex = 2;
		label2.Text = "Lọc:";
		cbbThuMuc.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbThuMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbThuMuc.DropDownWidth = 350;
		cbbThuMuc.FormattingEnabled = true;
		cbbThuMuc.ItemHeight = 16;
		cbbThuMuc.Location = new System.Drawing.Point(63, 3);
		cbbThuMuc.Name = "cbbThuMuc";
		cbbThuMuc.Size = new System.Drawing.Size(167, 24);
		cbbThuMuc.TabIndex = 1;
		cbbThuMuc.SelectedIndexChanged += new System.EventHandler(cbbThuMuc_SelectedIndexChanged);
		FB1FEA84.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		FB1FEA84.Controls.Add(F328AC2B);
		FB1FEA84.Controls.Add(BC32F63B);
		FB1FEA84.Controls.Add(FB151835);
		FB1FEA84.Controls.Add(panel2);
		FB1FEA84.Controls.Add(A2B3B43D);
		FB1FEA84.Controls.Add(FC2E01A0);
		FB1FEA84.Dock = System.Windows.Forms.DockStyle.Fill;
		FB1FEA84.Location = new System.Drawing.Point(0, 0);
		FB1FEA84.Name = "panel1";
		FB1FEA84.Size = new System.Drawing.Size(1224, 610);
		FB1FEA84.TabIndex = 11;
		F328AC2B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		F328AC2B.BackColor = System.Drawing.Color.White;
		F328AC2B.Cursor = System.Windows.Forms.Cursors.Hand;
		F328AC2B.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		F328AC2B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		F328AC2B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		F328AC2B.Image = C50FB39E.Bitmap_82;
		F328AC2B.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		F328AC2B.Location = new System.Drawing.Point(1011, 70);
		F328AC2B.Name = "button3";
		F328AC2B.Size = new System.Drawing.Size(201, 32);
		F328AC2B.TabIndex = 13;
		F328AC2B.Text = "Xo\u0301a ta\u0300i khoa\u0309n vi\u0303nh viê\u0303n";
		F328AC2B.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		F328AC2B.UseVisualStyleBackColor = true;
		F328AC2B.Click += new System.EventHandler(F328AC2B_Click);
		BC32F63B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		BC32F63B.BackColor = System.Drawing.Color.White;
		BC32F63B.Cursor = System.Windows.Forms.Cursors.Hand;
		BC32F63B.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		BC32F63B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BC32F63B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		BC32F63B.Image = C50FB39E.Bitmap_134;
		BC32F63B.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		BC32F63B.Location = new System.Drawing.Point(847, 70);
		BC32F63B.Name = "button9";
		BC32F63B.Size = new System.Drawing.Size(158, 32);
		BC32F63B.TabIndex = 14;
		BC32F63B.Text = "Khôi phu\u0323c ta\u0300i khoa\u0309n";
		BC32F63B.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		BC32F63B.UseVisualStyleBackColor = true;
		BC32F63B.Click += new System.EventHandler(FEBB8A85);
		A2B3B43D.BackColor = System.Drawing.SystemColors.Control;
		A2B3B43D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A2B3B43D.Items.AddRange(new System.Windows.Forms.ToolStripItem[6] { DCB7C820, lblCountHighline, E68E9BA2, D9AF668F, toolStripStatusLabel7, B59CD508 });
		A2B3B43D.Location = new System.Drawing.Point(0, 586);
		A2B3B43D.Name = "statusStrip1";
		A2B3B43D.Size = new System.Drawing.Size(1222, 22);
		A2B3B43D.SizingGrip = false;
		A2B3B43D.TabIndex = 9;
		A2B3B43D.Text = "statusStrip1";
		A2B3B43D.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(A2B3B43D_ItemClicked);
		FC2E01A0.AllowUserToAddRows = false;
		FC2E01A0.AllowUserToDeleteRows = false;
		FC2E01A0.AllowUserToResizeRows = false;
		FC2E01A0.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		FC2E01A0.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		FC2E01A0.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		FC2E01A0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		FC2E01A0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		FC2E01A0.Columns.AddRange(cChose, cStt, B83CE197, cUid, cToken, cCookies, C8055AB4, cPhone, cName, cFollow, cFriend, cGroup, cPage, cPagePro5, cBirthday, BA9EB309, cPassword, cMailRecovery, EB3E7D28, cOAuth2, D19A288B, DB88FDA0, cProxy, E72E22AF, E6B52429, D4B1EA2B, FD19ABA8, B18DBE2F, C6A02F16, cGhiChu, CCAD2D81, C8958DBC, CD39963D, A9AB0298, cAds, DA351814, cWallPosts, cFbBlock, cJob, cDateDelete, cStatus);
		FC2E01A0.ContextMenuStrip = ctmsAcc;
		FC2E01A0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		FC2E01A0.Location = new System.Drawing.Point(8, 108);
		FC2E01A0.Name = "dtgvAcc";
		FC2E01A0.RowHeadersVisible = false;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		FC2E01A0.RowsDefaultCellStyle = dataGridViewCellStyle2;
		FC2E01A0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		FC2E01A0.Size = new System.Drawing.Size(1204, 475);
		FC2E01A0.TabIndex = 0;
		FC2E01A0.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(FC2E01A0_CellClick);
		FC2E01A0.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(C30241AF);
		FC2E01A0.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(FC2E01A0_CellValueChanged);
		FC2E01A0.SelectionChanged += new System.EventHandler(FC2E01A0_SelectionChanged);
		FC2E01A0.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(D81DBA02);
		FC2E01A0.KeyDown += new System.Windows.Forms.KeyEventHandler(FC2E01A0_KeyDown);
		cChose.HeaderText = "Chọn";
		cChose.Name = "cChose";
		cChose.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		cChose.Width = 40;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		cStt.DefaultCellStyle = dataGridViewCellStyle3;
		cStt.HeaderText = "STT";
		cStt.Name = "cStt";
		cStt.Width = 35;
		B83CE197.HeaderText = "Id";
		B83CE197.Name = "cId";
		B83CE197.Visible = false;
		B83CE197.Width = 90;
		cUid.HeaderText = "UID";
		cUid.Name = "cUid";
		cUid.Width = 80;
		cToken.HeaderText = "Token";
		cToken.Name = "cToken";
		cToken.Width = 70;
		cCookies.HeaderText = "Cookie";
		cCookies.Name = "cCookies";
		cCookies.Width = 70;
		C8055AB4.HeaderText = "Email";
		C8055AB4.Name = "cEmail";
		C8055AB4.Width = 60;
		cPhone.HeaderText = "Phone";
		cPhone.Name = "cPhone";
		cPhone.Visible = false;
		cPhone.Width = 90;
		cName.HeaderText = "Tên";
		cName.Name = "cName";
		cName.Width = 70;
		cFollow.HeaderText = "Theo do\u0303i";
		cFollow.Name = "cFollow";
		cFollow.Visible = false;
		cFollow.Width = 85;
		cFriend.HeaderText = "Ba\u0323n be\u0300";
		cFriend.Name = "cFriend";
		cFriend.Width = 75;
		cGroup.HeaderText = "Nho\u0301m";
		cGroup.Name = "cGroup";
		cGroup.Visible = false;
		cGroup.Width = 60;
		cPage.HeaderText = "Page";
		cPage.Name = "cPage";
		cPage.Visible = false;
		cPage.Width = 60;
		cPagePro5.HeaderText = "Page pro5";
		cPagePro5.Name = "cPagePro5";
		cPagePro5.Visible = false;
		cBirthday.HeaderText = "Nga\u0300y sinh";
		cBirthday.Name = "cBirthday";
		cBirthday.Width = 90;
		BA9EB309.HeaderText = "Giới Tính";
		BA9EB309.Name = "cGender";
		BA9EB309.Width = 82;
		cPassword.HeaderText = "Mật khẩu";
		cPassword.Name = "cPassword";
		cPassword.Visible = false;
		cPassword.Width = 85;
		cMailRecovery.HeaderText = "Email khôi phục";
		cMailRecovery.Name = "cMailRecovery";
		cMailRecovery.Visible = false;
		cMailRecovery.Width = 125;
		EB3E7D28.HeaderText = "Mật khẩu mail";
		EB3E7D28.Name = "cPassMail";
		EB3E7D28.Visible = false;
		EB3E7D28.Width = 120;
		cOAuth2.HeaderText = "OAuth2";
		cOAuth2.Name = "cOAuth2";
		cOAuth2.Visible = false;
		cOAuth2.Width = 70;
		D19A288B.HeaderText = "Mã 2FA";
		D19A288B.Name = "cFa2";
		D19A288B.Width = 80;
		DB88FDA0.HeaderText = "Useragent";
		DB88FDA0.Name = "cUseragent";
		DB88FDA0.Visible = false;
		DB88FDA0.Width = 70;
		cProxy.HeaderText = "Proxy";
		cProxy.Name = "cProxy";
		cProxy.Visible = false;
		cProxy.Width = 55;
		E72E22AF.HeaderText = "Nga\u0300y ta\u0323o";
		E72E22AF.Name = "cDateCreateAcc";
		E72E22AF.Visible = false;
		E72E22AF.Width = 85;
		E6B52429.HeaderText = "Avatar";
		E6B52429.Name = "cAvatar";
		E6B52429.Visible = false;
		E6B52429.Width = 50;
		D4B1EA2B.HeaderText = "Profile";
		D4B1EA2B.Name = "cProfile";
		D4B1EA2B.Visible = false;
		D4B1EA2B.Width = 50;
		FD19ABA8.HeaderText = "Thư mục";
		FD19ABA8.Name = "cThuMuc";
		FD19ABA8.Visible = false;
		B18DBE2F.HeaderText = "Lâ\u0300n tương ta\u0301c cuô\u0301i";
		B18DBE2F.Name = "cInteractEnd";
		B18DBE2F.Visible = false;
		B18DBE2F.Width = 160;
		C6A02F16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
		C6A02F16.HeaderText = "Tình Trạng";
		C6A02F16.Name = "cInfo";
		C6A02F16.Visible = false;
		cGhiChu.HeaderText = "Ghi Chú";
		cGhiChu.Name = "cGhiChu";
		cGhiChu.Visible = false;
		cGhiChu.Width = 90;
		CCAD2D81.HeaderText = "Location";
		CCAD2D81.Name = "cLocation";
		CCAD2D81.Visible = false;
		CCAD2D81.Width = 80;
		C8958DBC.HeaderText = "Hometown";
		C8958DBC.Name = "cHometown";
		C8958DBC.Visible = false;
		C8958DBC.Width = 90;
		CD39963D.HeaderText = "Current City";
		CD39963D.Name = "cCurrentCity";
		CD39963D.Visible = false;
		A9AB0298.HeaderText = "Dating";
		A9AB0298.Name = "cDating";
		A9AB0298.Visible = false;
		cAds.HeaderText = "Ads";
		cAds.Name = "cAds";
		cAds.Visible = false;
		DA351814.HeaderText = "BM";
		DA351814.Name = "cBM";
		DA351814.Visible = false;
		cWallPosts.HeaderText = "Wall Posts";
		cWallPosts.Name = "cWallPosts";
		cWallPosts.Visible = false;
		cFbBlock.HeaderText = "Fb Block";
		cFbBlock.Name = "cFbBlock";
		cFbBlock.Visible = false;
		cJob.HeaderText = "Job";
		cJob.Name = "cJob";
		cJob.Visible = false;
		cDateDelete.HeaderText = "Thơ\u0300i gian xo\u0301a";
		cDateDelete.Name = "cDateDelete";
		cDateDelete.Width = 115;
		cStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		cStatus.HeaderText = "Trạng Thái";
		cStatus.MinimumWidth = 200;
		cStatus.Name = "cStatus";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(1224, 610);
		base.Controls.Add(bunifuCards1);
		base.Controls.Add(menuStrip1);
		base.Controls.Add(FB1FEA84);
		DoubleBuffered = true;
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MainMenuStrip = menuStrip1;
		base.Name = "fTaiKhoanDaXoa";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "MAX CARE";
		ctmsAcc.ResumeLayout(false);
		FD09ABAC.ResumeLayout(false);
		FD09ABAC.PerformLayout();
		((System.ComponentModel.ISupportInitialize)A2BB4E19).EndInit();
		bunifuCards1.ResumeLayout(false);
		menuStrip1.ResumeLayout(false);
		menuStrip1.PerformLayout();
		panel2.ResumeLayout(false);
		panel2.PerformLayout();
		FB151835.ResumeLayout(false);
		FB151835.PerformLayout();
		FB1FEA84.ResumeLayout(false);
		FB1FEA84.PerformLayout();
		A2B3B43D.ResumeLayout(false);
		A2B3B43D.PerformLayout();
		((System.ComponentModel.ISupportInitialize)FC2E01A0).EndInit();
		ResumeLayout(false);
	}

	[CompilerGenerated]
	private void method_37()
	{
		foreach (DataGridViewColumn column in FC2E01A0.Columns)
		{
			column.SortMode = DataGridViewColumnSortMode.NotSortable;
		}
	}

	[CompilerGenerated]
	private void F4B8DC81()
	{
		foreach (DataGridViewColumn column in FC2E01A0.Columns)
		{
			column.SortMode = DataGridViewColumnSortMode.Automatic;
		}
	}
}
