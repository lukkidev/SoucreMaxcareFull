using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;
using WindowsFormsControlLibrary1;

public class A6BA4B90 : Form
{
	private enum Enum0
	{
		A0062908,
		const_1,
		const_2
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class C419E793
	{
		public static readonly C419E793 _003C_003E9 = new C419E793();

		public static Func<DataGridViewRow, int> _003C_003E9__23_0;

		internal int method_0(DataGridViewRow dataGridViewRow_0)
		{
			return dataGridViewRow_0.Index;
		}
	}

	[CompilerGenerated]
	private sealed class Class19
	{
		public string BD15542D;

		public Func<string, bool> func_0;

		internal bool method_0(string string_0)
		{
			return string_0.Contains(BD15542D.Substring(BD15542D.IndexOf('@') - 1, 3)) && string_0.StartsWith(BD15542D.Substring(0, 1)) && string_0.EndsWith(BD15542D.Substring(BD15542D.LastIndexOf('.')));
		}
	}

	[CompilerGenerated]
	private sealed class AB393811
	{
		public A6BA4B90 C8B64F05;

		public string string_0;

		internal void method_0()
		{
			if (!C8B64F05.F5948F3E.Visible)
			{
				C8B64F05.F5948F3E.Visible = true;
			}
		}

		internal void method_1()
		{
			C8B64F05.EF36EA35.Text = string_0;
		}
	}

	[CompilerGenerated]
	private sealed class Class20
	{
		public string string_0;

		public A6BA4B90 a6BA4B90_0;

		internal void method_0()
		{
			try
			{
				if (string_0 == "start")
				{
					a6BA4B90_0.C3BBF8AC.Enabled = false;
					GClass27.E68A6883(a6BA4B90_0.EB3CF7AF, bool_0: false);
				}
				else if (string_0 == "stop")
				{
					a6BA4B90_0.C3BBF8AC.Enabled = true;
					GClass27.E68A6883(a6BA4B90_0.EB3CF7AF, bool_0: true);
				}
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class21
	{
		public A6BA4B90 a6BA4B90_0;

		public int int_0;

		public int int_1;

		public int E0338E84;

		public bool C932A337;

		internal void method_0()
		{
			a6BA4B90_0.method_34("start");
			int num = 0;
			while (num < a6BA4B90_0.EB3CF7AF.Rows.Count && !Class57.smethod_5())
			{
				if (Convert.ToBoolean(a6BA4B90_0.EB3CF7AF.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Class22 CS_0024_003C_003E8__locals0 = new Class22
						{
							class21_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class21_0.a6BA4B90_0.A1BF1713(CS_0024_003C_003E8__locals0.int_0, F7AB102E.smethod_0("Đang kiểm tra..."));
							switch (CS_0024_003C_003E8__locals0.class21_0.E0338E84)
							{
							case 0:
								CS_0024_003C_003E8__locals0.class21_0.a6BA4B90_0.method_39(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 1:
								CS_0024_003C_003E8__locals0.class21_0.a6BA4B90_0.C8168394(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 2:
								CS_0024_003C_003E8__locals0.class21_0.a6BA4B90_0.method_40(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 3:
								CS_0024_003C_003E8__locals0.class21_0.a6BA4B90_0.method_41(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 4:
								CS_0024_003C_003E8__locals0.class21_0.a6BA4B90_0.method_37(CS_0024_003C_003E8__locals0.int_0);
								break;
							case 5:
								CS_0024_003C_003E8__locals0.class21_0.a6BA4B90_0.method_36(CS_0024_003C_003E8__locals0.int_0, CS_0024_003C_003E8__locals0.class21_0.C932A337);
								break;
							case 6:
								CS_0024_003C_003E8__locals0.class21_0.a6BA4B90_0.method_42(CS_0024_003C_003E8__locals0.int_0, CS_0024_003C_003E8__locals0.class21_0.C932A337);
								break;
							case 7:
								CS_0024_003C_003E8__locals0.class21_0.a6BA4B90_0.method_38(CS_0024_003C_003E8__locals0.int_0);
								break;
							}
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class21_0.int_0);
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
			while (int_0 > 0 && Environment.TickCount - tickCount <= 60000)
			{
				GClass8.smethod_53(1.0);
			}
			a6BA4B90_0.method_34("stop");
		}
	}

	[CompilerGenerated]
	private sealed class Class22
	{
		public int int_0;

		public Class21 class21_0;

		internal void method_0()
		{
			class21_0.a6BA4B90_0.A1BF1713(int_0, F7AB102E.smethod_0("Đang kiểm tra..."));
			switch (class21_0.E0338E84)
			{
			case 0:
				class21_0.a6BA4B90_0.method_39(int_0);
				break;
			case 1:
				class21_0.a6BA4B90_0.C8168394(int_0);
				break;
			case 2:
				class21_0.a6BA4B90_0.method_40(int_0);
				break;
			case 3:
				class21_0.a6BA4B90_0.method_41(int_0);
				break;
			case 4:
				class21_0.a6BA4B90_0.method_37(int_0);
				break;
			case 5:
				class21_0.a6BA4B90_0.method_36(int_0, class21_0.C932A337);
				break;
			case 6:
				class21_0.a6BA4B90_0.method_42(int_0, class21_0.C932A337);
				break;
			case 7:
				class21_0.a6BA4B90_0.method_38(int_0);
				break;
			}
			Interlocked.Decrement(ref class21_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class23
	{
		public A6BA4B90 a6BA4B90_0;

		public int BE19539E;

		public int int_0;

		internal void method_0()
		{
			a6BA4B90_0.method_34("start");
			int num = 0;
			while (num < a6BA4B90_0.EB3CF7AF.Rows.Count)
			{
				Application.DoEvents();
				if (Class57.smethod_5())
				{
					break;
				}
				if (Convert.ToBoolean(a6BA4B90_0.EB3CF7AF.Rows[num].Cells["cChose"].Value))
				{
					if (BE19539E < int_0)
					{
						B9B552BC CS_0024_003C_003E8__locals0 = new B9B552BC
						{
							class23_0 = this
						};
						Interlocked.Increment(ref BE19539E);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class23_0.a6BA4B90_0.A1BF1713(CS_0024_003C_003E8__locals0.int_0, F7AB102E.smethod_0("Đang kiểm tra..."));
							CS_0024_003C_003E8__locals0.class23_0.a6BA4B90_0.F01A3609(CS_0024_003C_003E8__locals0.int_0);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class23_0.BE19539E);
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
			while (BE19539E > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			a6BA4B90_0.method_34("stop");
		}
	}

	[CompilerGenerated]
	private sealed class B9B552BC
	{
		public int int_0;

		public Class23 class23_0;

		internal void A527FC35()
		{
			class23_0.a6BA4B90_0.A1BF1713(int_0, F7AB102E.smethod_0("Đang kiểm tra..."));
			class23_0.a6BA4B90_0.F01A3609(int_0);
			Interlocked.Decrement(ref class23_0.BE19539E);
		}
	}

	[CompilerGenerated]
	private sealed class AD07212B
	{
		public int int_0;

		public int int_1;

		public A6BA4B90 a6BA4B90_0;

		internal void method_0()
		{
			int num = 0;
			while (num < a6BA4B90_0.EB3CF7AF.Rows.Count)
			{
				if (Convert.ToBoolean(a6BA4B90_0.EB3CF7AF.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Class24 CS_0024_003C_003E8__locals0 = new Class24
						{
							E12F1085 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.C6077038 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.E12F1085.a6BA4B90_0.A1BF1713(CS_0024_003C_003E8__locals0.C6077038, F7AB102E.smethod_0("Đang xo\u0301a profile..."));
							CS_0024_003C_003E8__locals0.E12F1085.a6BA4B90_0.CE90948F(CS_0024_003C_003E8__locals0.C6077038);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.E12F1085.int_0);
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
	private sealed class Class24
	{
		public int C6077038;

		public AD07212B E12F1085;

		internal void method_0()
		{
			E12F1085.a6BA4B90_0.A1BF1713(C6077038, F7AB102E.smethod_0("Đang xo\u0301a profile..."));
			E12F1085.a6BA4B90_0.CE90948F(C6077038);
			Interlocked.Decrement(ref E12F1085.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class25
	{
		public A6BA4B90 a6BA4B90_0;

		public int int_0;

		public int int_1;

		public string FBB24EB5;

		internal void method_0()
		{
			int num = 0;
			while (num < a6BA4B90_0.EB3CF7AF.RowCount)
			{
				if (Convert.ToBoolean(a6BA4B90_0.method_60(num, "cChose")))
				{
					if (int_0 < int_1)
					{
						C1A79C98 CS_0024_003C_003E8__locals0 = new C1A79C98
						{
							class25_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.EF310B39 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class25_0.a6BA4B90_0.A1BF1713(CS_0024_003C_003E8__locals0.EF310B39, "Check profile...");
							CS_0024_003C_003E8__locals0.class25_0.a6BA4B90_0.B08E7E97(CS_0024_003C_003E8__locals0.EF310B39, CS_0024_003C_003E8__locals0.class25_0.FBB24EB5);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class25_0.int_0);
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
	private sealed class C1A79C98
	{
		public int EF310B39;

		public Class25 class25_0;

		internal void BD132423()
		{
			class25_0.a6BA4B90_0.A1BF1713(EF310B39, "Check profile...");
			class25_0.a6BA4B90_0.B08E7E97(EF310B39, class25_0.FBB24EB5);
			Interlocked.Decrement(ref class25_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class D90498BF
	{
		public A6BA4B90 E1BF0F1C;

		public int DDAE529F;

		public int int_0;

		public string EA1E5A94;

		internal void D3348390()
		{
			try
			{
				int num = 0;
				while (num < E1BF0F1C.EB3CF7AF.Rows.Count)
				{
					if (Convert.ToBoolean(E1BF0F1C.EB3CF7AF.Rows[num].Cells["cChose"].Value))
					{
						if (DDAE529F < int_0)
						{
							Class26 CS_0024_003C_003E8__locals0 = new Class26
							{
								d90498BF_0 = this
							};
							Interlocked.Increment(ref DDAE529F);
							CS_0024_003C_003E8__locals0.int_0 = num++;
							new Thread((ThreadStart)delegate
							{
								try
								{
									CS_0024_003C_003E8__locals0.d90498BF_0.E1BF0F1C.B6A11EAF(CS_0024_003C_003E8__locals0.int_0, CS_0024_003C_003E8__locals0.d90498BF_0.EA1E5A94);
									Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.d90498BF_0.DDAE529F);
								}
								catch (Exception ex2)
								{
									GClass8.smethod_62(null, ex2.ToString());
								}
							}).Start();
						}
						else
						{
							GClass8.smethod_53(1.0);
						}
					}
					else
					{
						num++;
					}
				}
				while (DDAE529F > 0)
				{
					GClass8.smethod_53(1.0);
				}
			}
			catch (Exception ex)
			{
				GClass8.smethod_62(null, ex.ToString());
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class26
	{
		public int int_0;

		public D90498BF d90498BF_0;

		internal void method_0()
		{
			try
			{
				d90498BF_0.E1BF0F1C.B6A11EAF(int_0, d90498BF_0.EA1E5A94);
				Interlocked.Decrement(ref d90498BF_0.DDAE529F);
			}
			catch (Exception ex)
			{
				GClass8.smethod_62(null, ex.ToString());
			}
		}
	}

	[CompilerGenerated]
	private sealed class B0AAC894
	{
		public A6BA4B90 a6BA4B90_0;

		public int C2060185;

		public int int_0;

		internal void A80CDB3A()
		{
			try
			{
				int num = 0;
				while (num < a6BA4B90_0.EB3CF7AF.Rows.Count)
				{
					if (Convert.ToBoolean(a6BA4B90_0.EB3CF7AF.Rows[num].Cells["cChose"].Value))
					{
						if (C2060185 < int_0)
						{
							D50C6611 CS_0024_003C_003E8__locals0 = new D50C6611
							{
								b0AAC894_0 = this
							};
							Interlocked.Increment(ref C2060185);
							CS_0024_003C_003E8__locals0.int_0 = num++;
							new Thread((ThreadStart)delegate
							{
								try
								{
									string input = GClass27.smethod_3(CS_0024_003C_003E8__locals0.b0AAC894_0.a6BA4B90_0.EB3CF7AF, CS_0024_003C_003E8__locals0.int_0, "cCookies");
									string text = GClass27.smethod_3(CS_0024_003C_003E8__locals0.b0AAC894_0.a6BA4B90_0.EB3CF7AF, CS_0024_003C_003E8__locals0.int_0, "cUid");
									if (text == "")
									{
										text = Regex.Match(input, "c_user=(\\d+)").Groups[1].Value;
									}
									if (File.Exists("backup\\" + text + "\\" + text + ".html"))
									{
										Process.Start(GClass28.smethod_0() + "\\backup\\" + text + "\\" + text + ".html");
									}
									else
									{
										GClass27.smethod_5(CS_0024_003C_003E8__locals0.b0AAC894_0.a6BA4B90_0.EB3CF7AF, CS_0024_003C_003E8__locals0.int_0, "cStatus", F7AB102E.smethod_0("Chưa tạo html!"));
									}
									Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.b0AAC894_0.C2060185);
								}
								catch (Exception ex2)
								{
									GClass8.smethod_62(null, ex2.ToString());
								}
							}).Start();
						}
						else
						{
							GClass8.smethod_53(1.0);
						}
					}
					else
					{
						num++;
					}
				}
				while (C2060185 > 0)
				{
					GClass8.smethod_53(1.0);
				}
			}
			catch (Exception ex)
			{
				GClass8.smethod_62(null, ex.ToString());
			}
		}
	}

	[CompilerGenerated]
	private sealed class D50C6611
	{
		public int int_0;

		public B0AAC894 b0AAC894_0;

		internal void method_0()
		{
			try
			{
				string input = GClass27.smethod_3(b0AAC894_0.a6BA4B90_0.EB3CF7AF, int_0, "cCookies");
				string text = GClass27.smethod_3(b0AAC894_0.a6BA4B90_0.EB3CF7AF, int_0, "cUid");
				if (text == "")
				{
					text = Regex.Match(input, "c_user=(\\d+)").Groups[1].Value;
				}
				if (File.Exists("backup\\" + text + "\\" + text + ".html"))
				{
					Process.Start(GClass28.smethod_0() + "\\backup\\" + text + "\\" + text + ".html");
				}
				else
				{
					GClass27.smethod_5(b0AAC894_0.a6BA4B90_0.EB3CF7AF, int_0, "cStatus", F7AB102E.smethod_0("Chưa tạo html!"));
				}
				Interlocked.Decrement(ref b0AAC894_0.C2060185);
			}
			catch (Exception ex)
			{
				GClass8.smethod_62(null, ex.ToString());
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class27
	{
		public A6BA4B90 a6BA4B90_0;

		public int int_0;

		public int int_1;

		internal void BDAE88A7()
		{
			a6BA4B90_0.method_34("start");
			int num = 0;
			while (num < a6BA4B90_0.EB3CF7AF.Rows.Count)
			{
				Application.DoEvents();
				if (Class57.smethod_5())
				{
					break;
				}
				if (Convert.ToBoolean(a6BA4B90_0.EB3CF7AF.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						ED162E17 CS_0024_003C_003E8__locals0 = new ED162E17
						{
							class27_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.A0AFA20D = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class27_0.a6BA4B90_0.A1BF1713(CS_0024_003C_003E8__locals0.A0AFA20D, F7AB102E.smethod_0("Đang kiểm tra..."));
							CS_0024_003C_003E8__locals0.class27_0.a6BA4B90_0.method_52(CS_0024_003C_003E8__locals0.A0AFA20D);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class27_0.int_0);
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
			a6BA4B90_0.method_34("stop");
		}
	}

	[CompilerGenerated]
	private sealed class ED162E17
	{
		public int A0AFA20D;

		public Class27 class27_0;

		internal void method_0()
		{
			class27_0.a6BA4B90_0.A1BF1713(A0AFA20D, F7AB102E.smethod_0("Đang kiểm tra..."));
			class27_0.a6BA4B90_0.method_52(A0AFA20D);
			Interlocked.Decrement(ref class27_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class AF30D91E
	{
		public int B62CEBAB;

		public int CEB1961B;

		public A6BA4B90 a6BA4B90_0;

		internal void method_0()
		{
			a6BA4B90_0.method_34("start");
			int num = 0;
			while (num < a6BA4B90_0.EB3CF7AF.Rows.Count)
			{
				Application.DoEvents();
				if (Class57.smethod_5())
				{
					break;
				}
				if (Convert.ToBoolean(a6BA4B90_0.EB3CF7AF.Rows[num].Cells["cChose"].Value))
				{
					if (B62CEBAB < CEB1961B)
					{
						FE12162C CS_0024_003C_003E8__locals0 = new FE12162C
						{
							E7153733 = this
						};
						Interlocked.Increment(ref B62CEBAB);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.E7153733.a6BA4B90_0.A1BF1713(CS_0024_003C_003E8__locals0.int_0, F7AB102E.smethod_0("Đang ta\u0323o Shortcut..."));
							try
							{
								CS_0024_003C_003E8__locals0.E7153733.a6BA4B90_0.EB3CF7AF.Rows[CS_0024_003C_003E8__locals0.int_0].Cells["cId"].Value.ToString();
								string text = CS_0024_003C_003E8__locals0.E7153733.a6BA4B90_0.EB3CF7AF.Rows[CS_0024_003C_003E8__locals0.int_0].Cells["cUid"].Value.ToString();
								string text2 = CS_0024_003C_003E8__locals0.E7153733.a6BA4B90_0.EB3CF7AF.Rows[CS_0024_003C_003E8__locals0.int_0].Cells["cName"].Value.ToString();
								string string_ = ((text2 == "") ? text : (text2 + "_" + text));
								string text3 = GClass25.smethod_0("configGeneral").C0288288("txbPathProfile") + "\\" + text;
								if (GClass25.smethod_0("configGeneral").method_3("ckbUsePortable") && Directory.Exists(GClass25.smethod_0("configGeneral").C0288288("txbPathProfile") + "\\" + text + "\\Data\\profile"))
								{
									text3 = GClass25.smethod_0("configGeneral").C0288288("txbPathProfile") + "\\" + text + "\\Data\\profile";
								}
								GClass8.smethod_32(text3);
								bool flag;
								if (!(flag = CS_0024_003C_003E8__locals0.E7153733.a6BA4B90_0.method_53(text3, string_)))
								{
									string_ = text;
									flag = CS_0024_003C_003E8__locals0.E7153733.a6BA4B90_0.method_53(text3, string_);
								}
								if (!flag)
								{
									CS_0024_003C_003E8__locals0.E7153733.a6BA4B90_0.A1BF1713(CS_0024_003C_003E8__locals0.int_0, F7AB102E.smethod_0("Lô\u0303i ta\u0323o Shortcut!"));
								}
								else
								{
									CS_0024_003C_003E8__locals0.E7153733.a6BA4B90_0.A1BF1713(CS_0024_003C_003E8__locals0.int_0, F7AB102E.smethod_0("Ta\u0323o Shortcut thành công!"));
								}
							}
							catch
							{
								CS_0024_003C_003E8__locals0.E7153733.a6BA4B90_0.A1BF1713(CS_0024_003C_003E8__locals0.int_0, F7AB102E.smethod_0("Lỗi!"));
							}
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.E7153733.B62CEBAB);
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
			while (B62CEBAB > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			a6BA4B90_0.method_34("stop");
		}
	}

	[CompilerGenerated]
	private sealed class FE12162C
	{
		public int int_0;

		public AF30D91E E7153733;

		internal void method_0()
		{
			E7153733.a6BA4B90_0.A1BF1713(int_0, F7AB102E.smethod_0("Đang ta\u0323o Shortcut..."));
			try
			{
				E7153733.a6BA4B90_0.EB3CF7AF.Rows[int_0].Cells["cId"].Value.ToString();
				string text = E7153733.a6BA4B90_0.EB3CF7AF.Rows[int_0].Cells["cUid"].Value.ToString();
				string text2 = E7153733.a6BA4B90_0.EB3CF7AF.Rows[int_0].Cells["cName"].Value.ToString();
				string string_ = ((text2 == "") ? text : (text2 + "_" + text));
				string text3 = GClass25.smethod_0("configGeneral").C0288288("txbPathProfile") + "\\" + text;
				if (GClass25.smethod_0("configGeneral").method_3("ckbUsePortable") && Directory.Exists(GClass25.smethod_0("configGeneral").C0288288("txbPathProfile") + "\\" + text + "\\Data\\profile"))
				{
					text3 = GClass25.smethod_0("configGeneral").C0288288("txbPathProfile") + "\\" + text + "\\Data\\profile";
				}
				GClass8.smethod_32(text3);
				bool flag;
				if (!(flag = E7153733.a6BA4B90_0.method_53(text3, string_)))
				{
					string_ = text;
					flag = E7153733.a6BA4B90_0.method_53(text3, string_);
				}
				if (!flag)
				{
					E7153733.a6BA4B90_0.A1BF1713(int_0, F7AB102E.smethod_0("Lô\u0303i ta\u0323o Shortcut!"));
				}
				else
				{
					E7153733.a6BA4B90_0.A1BF1713(int_0, F7AB102E.smethod_0("Ta\u0323o Shortcut thành công!"));
				}
			}
			catch
			{
				E7153733.a6BA4B90_0.A1BF1713(int_0, F7AB102E.smethod_0("Lỗi!"));
			}
			Interlocked.Decrement(ref E7153733.B62CEBAB);
		}
	}

	[CompilerGenerated]
	private sealed class Class28
	{
		public int A6B80904;

		public int CD06FB0D;

		public A6BA4B90 a6BA4B90_0;

		internal void method_0()
		{
			int num = 0;
			while (num < a6BA4B90_0.EB3CF7AF.Rows.Count)
			{
				if (Convert.ToBoolean(a6BA4B90_0.EB3CF7AF.Rows[num].Cells["cChose"].Value))
				{
					if (A6B80904 < CD06FB0D)
					{
						Class29 CS_0024_003C_003E8__locals0 = new Class29
						{
							C8234118 = this
						};
						Interlocked.Increment(ref A6B80904);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.C8234118.a6BA4B90_0.A1BF1713(CS_0024_003C_003E8__locals0.int_0, F7AB102E.smethod_0("Đang xo\u0301a Cache Profile..."));
							CS_0024_003C_003E8__locals0.C8234118.a6BA4B90_0.F1A2A699(CS_0024_003C_003E8__locals0.int_0);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.C8234118.A6B80904);
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
	private sealed class Class29
	{
		public int int_0;

		public Class28 C8234118;

		internal void method_0()
		{
			C8234118.a6BA4B90_0.A1BF1713(int_0, F7AB102E.smethod_0("Đang xo\u0301a Cache Profile..."));
			C8234118.a6BA4B90_0.F1A2A699(int_0);
			Interlocked.Decrement(ref C8234118.A6B80904);
		}
	}

	[CompilerGenerated]
	private sealed class B1B951B4
	{
		public A6BA4B90 ED25790C;

		public List<string> D50DF324;

		internal void C717991E()
		{
			try
			{
				string text = "";
				for (int i = 0; i < ED25790C.EB3CF7AF.RowCount; i++)
				{
					text = ED25790C.method_60(i, "cGhiChu");
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
						if (text != "" && !D50DF324.Contains(text))
						{
							D50DF324.Add(text);
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
	private sealed class Class30
	{
		public A6BA4B90 B6320915;

		public int int_0;

		public int C4AB4828;

		internal void method_0()
		{
			B6320915.method_34("start");
			int num = 0;
			while (num < B6320915.EB3CF7AF.Rows.Count && !Class57.smethod_5())
			{
				if (Convert.ToBoolean(B6320915.EB3CF7AF.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < C4AB4828)
					{
						Class31 CS_0024_003C_003E8__locals0 = new Class31
						{
							class30_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.FE18DE35 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class30_0.B6320915.A1BF1713(CS_0024_003C_003E8__locals0.FE18DE35, F7AB102E.smethod_0("Đang kiểm tra..."));
							try
							{
								string text = CS_0024_003C_003E8__locals0.class30_0.B6320915.method_60(CS_0024_003C_003E8__locals0.FE18DE35, "cEmail");
								string text2 = CS_0024_003C_003E8__locals0.class30_0.B6320915.method_60(CS_0024_003C_003E8__locals0.FE18DE35, "cPassMail");
								if (text == "" || text2 == "")
								{
									CS_0024_003C_003E8__locals0.class30_0.B6320915.A1BF1713(CS_0024_003C_003E8__locals0.FE18DE35, F7AB102E.smethod_0("Không tìm thấy mail!"));
									return;
								}
								string text3 = CS_0024_003C_003E8__locals0.class30_0.B6320915.method_28(6, text, text2, 0, "", "");
								if (text3 != "" && text3 != "fail")
								{
									CS_0024_003C_003E8__locals0.class30_0.B6320915.F0A99AA5(CS_0024_003C_003E8__locals0.FE18DE35, "cEmail", text3, "email");
									CS_0024_003C_003E8__locals0.class30_0.B6320915.A1BF1713(CS_0024_003C_003E8__locals0.FE18DE35, F7AB102E.smethod_0("Lấy thành công!"));
								}
								else
								{
									CS_0024_003C_003E8__locals0.class30_0.B6320915.A1BF1713(CS_0024_003C_003E8__locals0.FE18DE35, F7AB102E.smethod_0("Lấy thất bại!"));
								}
							}
							catch (Exception ex)
							{
								GClass29.smethod_0(ex.ToString());
								CS_0024_003C_003E8__locals0.class30_0.B6320915.A1BF1713(CS_0024_003C_003E8__locals0.FE18DE35, F7AB102E.smethod_0("Lỗi!"));
							}
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class30_0.int_0);
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
			_ = Environment.TickCount;
			while (int_0 > 0)
			{
				GClass8.smethod_53(1.0);
			}
			B6320915.method_34("stop");
		}
	}

	[CompilerGenerated]
	private sealed class Class31
	{
		public int FE18DE35;

		public Class30 class30_0;

		internal void method_0()
		{
			class30_0.B6320915.A1BF1713(FE18DE35, F7AB102E.smethod_0("Đang kiểm tra..."));
			try
			{
				string text = class30_0.B6320915.method_60(FE18DE35, "cEmail");
				string text2 = class30_0.B6320915.method_60(FE18DE35, "cPassMail");
				if (text == "" || text2 == "")
				{
					class30_0.B6320915.A1BF1713(FE18DE35, F7AB102E.smethod_0("Không tìm thấy mail!"));
					return;
				}
				string text3 = class30_0.B6320915.method_28(6, text, text2, 0, "", "");
				if (text3 != "" && text3 != "fail")
				{
					class30_0.B6320915.F0A99AA5(FE18DE35, "cEmail", text3, "email");
					class30_0.B6320915.A1BF1713(FE18DE35, F7AB102E.smethod_0("Lấy thành công!"));
				}
				else
				{
					class30_0.B6320915.A1BF1713(FE18DE35, F7AB102E.smethod_0("Lấy thất bại!"));
				}
			}
			catch (Exception ex)
			{
				GClass29.smethod_0(ex.ToString());
				class30_0.B6320915.A1BF1713(FE18DE35, F7AB102E.smethod_0("Lỗi!"));
			}
			Interlocked.Decrement(ref class30_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class32
	{
		public string A529C30E;

		public object object_0;

		public A6BA4B90 F6229728;

		internal void E3BE8481()
		{
			string a529C30E = A529C30E;
			string text = a529C30E;
			switch (C43AF739.smethod_0(text))
			{
			case 67270472u:
				if (text == "nudDelayGetJob")
				{
					object_0 = 5;
				}
				break;
			case 52101475u:
				if (text == "ckbCheckProxy")
				{
					object_0 = F6229728.ckbCheckProxy.Checked;
				}
				break;
			case 152793916u:
				if (text == "rbChayBangChrome")
				{
					object_0 = F6229728.rbChayBangChrome.Checked;
				}
				break;
			case 127089650u:
				if (text == "nudMaxJobToday")
				{
					object_0 = F6229728.A63DDA9B.Value;
				}
				break;
			case 556307290u:
				if (text == "ckbCheckToken")
				{
					object_0 = F6229728.F49B67B7.Checked;
				}
				break;
			case 515982676u:
				if (text == "ckbGetTokenWhenDie")
				{
					object_0 = F6229728.D30C68B8.Checked;
				}
				break;
			case 852229013u:
				if (text == "nudDelayOpenChromeFrom")
				{
					object_0 = F6229728.FD9C2193.Value;
				}
				break;
			case 746707643u:
				if (text == "rbChayBangToken")
				{
					object_0 = F6229728.rbChayBangToken.Checked;
				}
				break;
			case 974388905u:
				if (text == "nudBreakTimeJob")
				{
					object_0 = F6229728.nudBreakTimeJob.Value;
				}
				break;
			case 891328588u:
				if (text == "txtApiKey")
				{
					object_0 = F6229728.txtApiKey.Text.Trim();
				}
				break;
			case 1413853044u:
				if (text == "nudMaxChrome")
				{
					if (F6229728.rbChayBangChrome.Checked)
					{
						object_0 = F6229728.F40A5030.Value;
					}
					else
					{
						object_0 = F6229728.nudMaxChrome.Value;
					}
				}
				break;
			case 1379533532u:
				if (text == "cbbFacebookWeb")
				{
					object_0 = F6229728.cbbFacebookWeb.SelectedIndex;
				}
				break;
			case 1497969250u:
				if (text == "nudDelayTo")
				{
					object_0 = F6229728.nudDelayTo.Value;
				}
				break;
			case 1429197780u:
				if (text == "rbChayBangCookie")
				{
					object_0 = F6229728.rbChayBangCookie.Checked;
				}
				break;
			case 1616992167u:
				if (text == "nudMaxJobFailLienTiep")
				{
					object_0 = F6229728.F18113B8.Value;
				}
				break;
			case 1566765699u:
				if (text == "cbbTypeLogin")
				{
					object_0 = F6229728.EE3D8093.SelectedIndex;
				}
				break;
			case 1522640821u:
				if (text == "ckbUnlock956")
				{
					object_0 = false;
				}
				break;
			case 1978863315u:
				if (text == "cbbChangeIP")
				{
					object_0 = F6229728.cbbChangeIP.SelectedIndex;
				}
				break;
			case 1649225820u:
				if (text == "nudTimeoutGetJob")
				{
					object_0 = F6229728.nudTimeoutGetJob.Value;
				}
				break;
			case 2202188651u:
				if (text == "nudDelayFrom")
				{
					object_0 = F6229728.AF0B1AB0.Value;
				}
				break;
			case 1998700759u:
				if (text == "ckbRepeatAll")
				{
					object_0 = F6229728.B50940A9.Checked;
				}
				break;
			case 2434389140u:
				if (text == "jobType")
				{
					object_0 = F6229728.method_74();
				}
				break;
			case 2206630411u:
				if (text == "typeRunBy")
				{
					if (F6229728.rbChayBangCookie.Checked)
					{
						object_0 = 1;
					}
					else if (F6229728.rbChayBangChrome.Checked)
					{
						object_0 = 2;
					}
					else if (F6229728.rbChayBangToken.Checked)
					{
						object_0 = 0;
					}
				}
				break;
			case 2873782386u:
				if (text == "cbbGetTokenBy")
				{
					object_0 = F6229728.cbbGetTokenBy.SelectedValue.ToString();
				}
				break;
			case 2688776952u:
				if (text == "nudThread")
				{
					object_0 = F6229728.F40A5030.Value;
				}
				break;
			case 3117465753u:
				if (text == "ckbShowImageInteract")
				{
					object_0 = F6229728.ckbShowImageInteract.Checked;
				}
				break;
			case 3046996904u:
				if (text == "ckbChayBangPageProfile")
				{
					object_0 = F6229728.ckbChayBangPageProfile.Checked;
				}
				break;
			case 3505163287u:
				if (text == "cbbTypeGetToken")
				{
					object_0 = F6229728.EF1D13BA.SelectedIndex;
				}
				break;
			case 3205543473u:
				if (text == "cbbServer")
				{
					object_0 = F6229728.cbbServer.SelectedIndex;
				}
				break;
			case 3780799556u:
				if (text == "nudDelayOpenChromeTo")
				{
					object_0 = F6229728.nudDelayOpenChromeTo.Value;
				}
				break;
			case 3592451558u:
				if (text == "nudBreakTime")
				{
					object_0 = F6229728.F62E8310.Value;
				}
				break;
			case 4132434353u:
				if (text == "ckbHideBrowser")
				{
					object_0 = F6229728.ckbHideBrowser.Checked;
				}
				break;
			case 4122074087u:
				if (text == "ckbBreakTime")
				{
					object_0 = F6229728.CEBA2D85.Checked;
				}
				break;
			case 3835769819u:
				if (text == "ckbCheckLiveUid")
				{
					object_0 = F6229728.ckbCheckLiveUid.Checked;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class33
	{
		public int int_0;

		public A6BA4B90 F5BC0597;

		internal void method_0()
		{
			try
			{
				F5BC0597.dictionary_28[int_0].FB2B639E();
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class34
	{
		public Control control_0;

		public MethodInvoker methodInvoker_0;

		internal void C99D0B8A()
		{
			try
			{
				B722682F CS_0024_003C_003E8__locals0 = new B722682F
				{
					class34_0 = this,
					FD35A3B3 = control_0.Text
				};
				control_0.Invoke((MethodInvoker)delegate
				{
					control_0.Enabled = false;
				});
				CS_0024_003C_003E8__locals0.C78A29BC = 5;
				CS_0024_003C_003E8__locals0.int_0 = Environment.TickCount;
				while ((Environment.TickCount - CS_0024_003C_003E8__locals0.int_0) / 1000 - CS_0024_003C_003E8__locals0.C78A29BC < 0)
				{
					control_0.Invoke((MethodInvoker)delegate
					{
						CS_0024_003C_003E8__locals0.class34_0.control_0.Text = "Đợi " + (CS_0024_003C_003E8__locals0.C78A29BC - (Environment.TickCount - CS_0024_003C_003E8__locals0.int_0) / 1000) + "s...";
					});
					GClass8.smethod_53(0.5);
				}
				control_0.Invoke((MethodInvoker)delegate
				{
					CS_0024_003C_003E8__locals0.class34_0.control_0.Text = CS_0024_003C_003E8__locals0.FD35A3B3;
					CS_0024_003C_003E8__locals0.class34_0.control_0.Enabled = true;
				});
			}
			catch (Exception)
			{
			}
		}

		internal void method_0()
		{
			control_0.Enabled = false;
		}
	}

	[CompilerGenerated]
	private sealed class B722682F
	{
		public int C78A29BC;

		public int int_0;

		public string FD35A3B3;

		public Class34 class34_0;

		internal void D88287A3()
		{
			class34_0.control_0.Text = "Đợi " + (C78A29BC - (Environment.TickCount - int_0) / 1000) + "s...";
		}

		internal void method_0()
		{
			class34_0.control_0.Text = FD35A3B3;
			class34_0.control_0.Enabled = true;
		}
	}

	[CompilerGenerated]
	private sealed class Class35
	{
		public A6BA4B90 D5855503;

		public List<string> list_0;

		internal void method_0()
		{
			try
			{
				string text = "";
				string text2 = "";
				for (int i = 0; i < D5855503.EB3CF7AF.RowCount; i++)
				{
					text = D5855503.method_60(i, "cStatus").Trim();
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
						if (text != "" && !list_0.Contains(text))
						{
							list_0.Add(text);
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		internal void method_1()
		{
			try
			{
				string text = "";
				for (int i = 0; i < D5855503.EB3CF7AF.RowCount; i++)
				{
					text = D5855503.method_60(i, "cInfo");
					if (!text.Equals("") && !list_0.Contains(text))
					{
						list_0.Add(text);
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class36
	{
		public int int_0;

		public A6BA4B90 ED955B8C;
	}

	[CompilerGenerated]
	private sealed class F7BABB0E
	{
		public int int_0;

		public Class36 class36_0;

		internal void method_0()
		{
			class36_0.ED955B8C.A1BF1713(int_0, F7AB102E.smethod_0("Đang xo\u0301a profile..."));
			class36_0.ED955B8C.CE90948F(int_0);
			Interlocked.Decrement(ref class36_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class C03E813A
	{
		public GClass11 gclass11_0;

		public A6BA4B90 E1B5E312;

		public MethodInvoker methodInvoker_0;

		internal void F4A00532()
		{
			E1B5E312.E3942017();
		}
	}

	[CompilerGenerated]
	private sealed class Class37
	{
		public int int_0;

		public List<int> list_0;

		public int int_1;

		public bool bool_0;

		public C03E813A c03E813A_0;

		public ThreadStart threadStart_0;

		public ThreadStart threadStart_1;

		internal void F22DFD94()
		{
			try
			{
				if (c03E813A_0.gclass11_0.method_3("Interact"))
				{
                    Class38 CS_0024_003C_003E8__locals0 = new Class38();
                    CS_0024_003C_003E8__locals0.A88E1A87 = this;
                    List<string> list = new List<string>();
					CS_0024_003C_003E8__locals0.CD3CE331 = "";
					string text = "";
					int num = GClass25.smethod_0("configInteractGeneral").method_2("nudSoLuotChay", 1);
					if (num == 0)
					{
						num = 1;
					}
					for (int i = 0; i < num; i++)
					{
						list = new List<string>();
						if (GClass25.smethod_0("configInteractGeneral").method_3("ckbRepeatAll"))
						{
							text = ((num > 1) ? string.Format(F7AB102E.smethod_0("Lượt {0}/{1}. "), i + 1, num) : "");
							if (GClass25.smethod_0("configInteractGeneral").method_3("RepeatAllVIP"))
							{
								list = GClass25.smethod_0("configInteractGeneral").C5A69DA0("lstIdKichBan");
								if (GClass25.smethod_0("configInteractGeneral").method_3("ckbRandomKichBan"))
								{
									list = GClass8.smethod_35(list);
									list = GClass8.smethod_35(list);
									list = GClass8.smethod_35(list);
								}
							}
							else
							{
								list.Add(GClass25.smethod_0("configInteractGeneral").C0288288("cbbKichBan"));
							}
						}
						else
						{
							list.Add(GClass25.smethod_0("configInteractGeneral").C0288288("cbbKichBan"));
						}
						for (int j = 0; j < list.Count; j++)
						{
							if (GClass25.smethod_0("configInteractGeneral").method_3("ckbXoaCache"))
							{
								Thread thread = new Thread(new Class39
								{
									class38_0 = CS_0024_003C_003E8__locals0,
									CC2C6927 = 0,
									int_0 = GClass25.smethod_0("configGeneral").method_2("nudHideThread", 10)
								}.DEA6B100);
								thread.IsBackground = true;
								thread.Start();
							}
							if (Class57.smethod_5())
							{
								break;
							}
							CS_0024_003C_003E8__locals0.CD3CE331 = list[j];
							if (text != "")
							{
								c03E813A_0.E1B5E312.method_32(text + string.Format(F7AB102E.smethod_0("Kịch bản") + ": {0}...", Class147.E1199583(CS_0024_003C_003E8__locals0.CD3CE331)));
							}
							if (GClass25.smethod_0("configInteractGeneral").method_3("ckbRandomThuTuTaiKhoan"))
							{
								c03E813A_0.E1B5E312.EB3CF7AF.Invoke((MethodInvoker)delegate
								{
									c03E813A_0.E1B5E312.E3942017();
								});
							}
							c03E813A_0.E1B5E312.dictionary_0 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDThamGiaNhomUid");
							c03E813A_0.E1B5E312.dictionary_1 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDThamGiaNhomUidv2");
							c03E813A_0.E1B5E312.dictionary_23 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDKetBanVoiBanBeCuaUid");
							c03E813A_0.E1B5E312.dictionary_2 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDKetBanTepUid");
							c03E813A_0.E1B5E312.dictionary_3 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDKetBanTepUidv2");
							c03E813A_0.E1B5E312.dictionary_4 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDBaiVietProfile");
							c03E813A_0.E1B5E312.dictionary_5 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDSpamBaiViet");
							c03E813A_0.E1B5E312.dictionary_6 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDSpamBaiVietv2");
							c03E813A_0.E1B5E312.A3B286B4 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDSpamBaiViet", "txtComment");
							c03E813A_0.E1B5E312.dictionary_7 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDSpamBaiVietv2", "txtComment");
							c03E813A_0.E1B5E312.dictionary_8 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDBuffTinNhanProfile");
							c03E813A_0.E1B5E312.E2ACA8BF = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDKetBanTepUidNew", "txtLink");
							c03E813A_0.E1B5E312.B931FABE = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDBuffLikeComment", "txtComment");
							c03E813A_0.E1B5E312.D61C6110 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDBuffLikeComment", "txtComment");
							c03E813A_0.E1B5E312.dictionary_9 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDDangStatus", "txtNoiDung");
							c03E813A_0.E1B5E312.F725FAA3 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDDangStatus", "txtNoiDung");
							c03E813A_0.E1B5E312.E6B1DEA5 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDDangStatusV2", "txtNoiDung");
							c03E813A_0.E1B5E312.dictionary_10 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDDangStatusV2", "txtNoiDung");
							c03E813A_0.E1B5E312.CD146FB9 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDPhanHoiBinhLuan");
							c03E813A_0.E1B5E312.dictionary_11 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDBuffLikeComment", "txtIdPost");
							c03E813A_0.E1B5E312.BE3A6DAD = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDDangBaiTheoID", "txtIdPost");
							c03E813A_0.E1B5E312.dictionary_12 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDBuffFollowLikePage");
							c03E813A_0.E1B5E312.dictionary_13 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDShareBaiTut", "txtLinkChiaSe");
							c03E813A_0.E1B5E312.A0840D3F = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDLinkToInstagram", "txtBio");
							c03E813A_0.E1B5E312.dictionary_14 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDLinkToInstagram", "txtBio");
							c03E813A_0.E1B5E312.dictionary_15 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDReviewPage");
							c03E813A_0.E1B5E312.dictionary_16 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDNhanTinBanBe", "txtTinNhan");
							c03E813A_0.E1B5E312.dictionary_17 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDNhanTinBanBe", "txtTinNhan");
							c03E813A_0.E1B5E312.dictionary_18 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDDangBai", "lstNhomTuNhap");
							c03E813A_0.E1B5E312.dictionary_19 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDDangBai", "txtIdPost");
							c03E813A_0.E1B5E312.dictionary_20 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDTuongTacLivestream", "txtComment");
							c03E813A_0.E1B5E312.dictionary_21 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDDangBai", "txtNoiDung");
							c03E813A_0.E1B5E312.dictionary_22 = new Dictionary<string, List<string>>();
							c03E813A_0.E1B5E312.A5362C12 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDAddMail", "lstHotmail");
							c03E813A_0.E1B5E312.A11D612D = new Dictionary<string, Dictionary<string, int>>();
							c03E813A_0.E1B5E312.dictionary_26 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDPhanHoiBinhLuan", "txtComment");
							c03E813A_0.E1B5E312.BAAAB69C = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDDangReel", "txtNoiDung");
							c03E813A_0.E1B5E312.FC17EB12 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDShareBai", "txtNoiDung");
							c03E813A_0.E1B5E312.dictionary_24 = c03E813A_0.E1B5E312.method_15(CS_0024_003C_003E8__locals0.CD3CE331, "HDChaySpam", "txtIdPost");
							c03E813A_0.E1B5E312.dictionary_25 = c03E813A_0.E1B5E312.BA226595(CS_0024_003C_003E8__locals0.CD3CE331, "HDChaySpam", "txtComment");
							c03E813A_0.E1B5E312.method_16();
							if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 8 && GClass25.smethod_0("configGeneral").method_2("typeRunXproxy") == 1)
							{
								for (int k = 0; k < c03E813A_0.E1B5E312.F8B76B18.Count; k++)
								{
									(c03E813A_0.E1B5E312.F8B76B18[k] as Class9).method_0();
								}
							}
							if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 14)
							{
								for (int l = 0; l < c03E813A_0.E1B5E312.list_0.Count; l++)
								{
									c03E813A_0.E1B5E312.list_0[l].method_4();
								}
							}
                            Thread thread2 = new Thread(CS_0024_003C_003E8__locals0.threadStart_0 ?? (CS_0024_003C_003E8__locals0.threadStart_0 = new ThreadStart(CS_0024_003C_003E8__locals0.method_0)));
                            thread2.IsBackground = true;
                            thread2.IsBackground = true;
							thread2.Start();
							if (GClass25.smethod_0("configInteractGeneral").method_3("ckbGioiHanThoiGianChayKichBan"))
							{
								int num2 = Class57.random_0.Next(GClass25.smethod_0("configInteractGeneral").method_2("nudThoiGianChayKichBanFrom"), GClass25.smethod_0("configInteractGeneral").method_2("nudThoiGianChayKichBanTo") + 1);
								if (!thread2.Join(num2 * 60000))
								{
									thread2.Abort();
									for (int m = 0; m < c03E813A_0.E1B5E312.A235CA9E.Count; m++)
									{
										c03E813A_0.E1B5E312.A235CA9E[m].Abort();
										while (c03E813A_0.E1B5E312.A235CA9E[m].IsAlive)
										{
											Thread.Sleep(1000);
										}
									}
									while (thread2.IsAlive)
									{
										Thread.Sleep(1000);
									}
								}
							}
							else
							{
								thread2.Join();
							}
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.dictionary_0);
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.dictionary_1);
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.dictionary_23);
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.dictionary_2);
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.dictionary_3);
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.dictionary_4);
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.dictionary_5);
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.dictionary_6);
							c03E813A_0.E1B5E312.method_14(c03E813A_0.E1B5E312.B931FABE, bool_2: true, "txtComment");
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.A3B286B4, "txtComment");
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.dictionary_7, "txtComment");
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.dictionary_8);
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.E2ACA8BF, "txtLink");
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.dictionary_11, "txtIdPost");
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.BE3A6DAD, "txtIdPost");
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.dictionary_12);
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.dictionary_13, "txtLinkChiaSe");
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.A0840D3F, "txtBio");
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.dictionary_15);
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.dictionary_18, "lstNhomTuNhap");
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.dictionary_19, "txtIdPost");
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.dictionary_20, "txtComment");
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.dictionary_21, "txtNoiDung");
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.A5362C12, "lstHotmail");
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.dictionary_26, "txtComment");
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.BAAAB69C, "txtNoiDung");
							c03E813A_0.E1B5E312.method_13(c03E813A_0.E1B5E312.FC17EB12, "txtNoiDung");
							c03E813A_0.E1B5E312.EE9F1135(c03E813A_0.E1B5E312.dictionary_24, "txtIdPost");
							c03E813A_0.E1B5E312.method_14(c03E813A_0.E1B5E312.dictionary_25, bool_2: true, "txtComment");
							if (Class57.smethod_5())
							{
								break;
							}
							if (j + 1 >= list.Count)
							{
								continue;
							}
							int num3 = Class57.random_0.Next(GClass25.smethod_0("configInteractGeneral").method_2("nudDelayKichBanFrom"), GClass25.smethod_0("configInteractGeneral").method_2("nudDelayKichBanTo") + 1);
							int tickCount = Environment.TickCount;
							while ((Environment.TickCount - tickCount) / 1000 - num3 < 0)
							{
								c03E813A_0.E1B5E312.method_32(text + string.Format(F7AB102E.smethod_0("Chạy kịch bản tiếp theo sau {time} giây...").Replace("{time}", (num3 - (Environment.TickCount - tickCount) / 1000).ToString())));
								GClass8.smethod_53(0.5);
								if (Class57.smethod_5())
								{
									break;
								}
							}
						}
						if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbRepeatAll") || Class57.smethod_5())
						{
							break;
						}
						if (i + 1 < num)
						{
							int num4 = Class57.random_0.Next(GClass25.smethod_0("configInteractGeneral").method_2("nudDelayTurnFrom"), GClass25.smethod_0("configInteractGeneral").method_2("nudDelayTurnTo") + 1) * 60;
							int tickCount2 = Environment.TickCount;
							while ((Environment.TickCount - tickCount2) / 1000 - num4 < 0)
							{
								c03E813A_0.E1B5E312.method_32(text + string.Format(F7AB102E.smethod_0("Chạy lượt tiếp theo sau {time} giây...").Replace("{time}", (num4 - (Environment.TickCount - tickCount2) / 1000).ToString())));
								GClass8.smethod_53(0.5);
								if (Class57.smethod_5())
								{
									break;
								}
							}
						}
						if (Class57.smethod_5())
						{
							break;
						}
					}
				}
				else if (c03E813A_0.gclass11_0.method_3("OpenBrowser"))
				{
					if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 8 && GClass25.smethod_0("configGeneral").method_2("typeRunXproxy") == 1)
					{
						for (int n = 0; n < c03E813A_0.E1B5E312.F8B76B18.Count; n++)
						{
							(c03E813A_0.E1B5E312.F8B76B18[n] as Class9).method_0();
						}
					}
					if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 14)
					{
						for (int num5 = 0; num5 < c03E813A_0.E1B5E312.list_0.Count; num5++)
						{
							c03E813A_0.E1B5E312.list_0[num5].method_4();
						}
					}
					Thread thread3 = new Thread((ThreadStart)delegate
					{
						try
						{
							int num15 = 0;
							while (num15 < c03E813A_0.E1B5E312.EB3CF7AF.Rows.Count && !Class57.smethod_5())
							{
								if (Convert.ToBoolean(c03E813A_0.E1B5E312.EB3CF7AF.Rows[num15].Cells["cChose"].Value))
								{
									if (Class57.smethod_5() || c03E813A_0.E1B5E312.A235CA9E.Count >= int_0)
									{
										break;
									}
									F1BB3721 CS_0024_003C_003E8__locals0 = new F1BB3721
									{
										class37_0 = this
									};
									if (Class57.smethod_5())
									{
										break;
									}
									CS_0024_003C_003E8__locals0.int_0 = num15++;
									Thread thread6 = new Thread((ThreadStart)delegate
									{
										int int_ = GClass8.smethod_58(ref CS_0024_003C_003E8__locals0.class37_0.list_0);
										try
										{
											CS_0024_003C_003E8__locals0.class37_0.c03E813A_0.E1B5E312.method_18(CS_0024_003C_003E8__locals0.int_0, int_, "", CS_0024_003C_003E8__locals0.class37_0.c03E813A_0.gclass11_0);
										}
										catch (Exception f4295AA2)
										{
											GClass8.BFBDF687(null, f4295AA2);
										}
									})
									{
										Name = CS_0024_003C_003E8__locals0.int_0.ToString()
									};
									c03E813A_0.E1B5E312.A235CA9E.Add(thread6);
									GClass8.smethod_53(1.0);
									thread6.Start();
								}
								else
								{
									num15++;
								}
							}
							for (int num16 = 0; num16 < c03E813A_0.E1B5E312.A235CA9E.Count; num16++)
							{
								c03E813A_0.E1B5E312.A235CA9E[num16].Join();
							}
						}
						catch (ThreadAbortException ex3)
						{
							if (ex3.ToString().Contains("Thread was being aborted."))
							{
							}
						}
					});
					thread3.IsBackground = true;
					thread3.Start();
					thread3.Join();
				}
				else
				{
					if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 8 && GClass25.smethod_0("configGeneral").method_2("typeRunXproxy") == 1)
					{
						for (int num6 = 0; num6 < c03E813A_0.E1B5E312.F8B76B18.Count; num6++)
						{
							(c03E813A_0.E1B5E312.F8B76B18[num6] as Class9).method_0();
						}
					}
					if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 14)
					{
						for (int num7 = 0; num7 < c03E813A_0.E1B5E312.list_0.Count; num7++)
						{
							c03E813A_0.E1B5E312.list_0[num7].method_4();
						}
					}
					Thread thread4 = new Thread((ThreadStart)delegate
					{
						try
						{
							int num8 = 0;
							while (num8 < c03E813A_0.E1B5E312.EB3CF7AF.Rows.Count && !Class57.smethod_5())
							{
								if (Convert.ToBoolean(c03E813A_0.E1B5E312.EB3CF7AF.Rows[num8].Cells["cChose"].Value))
								{
									if (Class57.smethod_5())
									{
										break;
									}
									if (c03E813A_0.E1B5E312.A235CA9E.Count < int_0)
									{
										Class42 CS_0024_003C_003E8__locals0 = new Class42
										{
											class37_0 = this
										};
										if (Class57.smethod_5())
										{
											break;
										}
										CS_0024_003C_003E8__locals0.int_0 = num8++;
										Thread thread5 = new Thread((ThreadStart)delegate
										{
											int num14 = GClass8.smethod_58(ref CS_0024_003C_003E8__locals0.class37_0.list_0);
											try
											{
												CS_0024_003C_003E8__locals0.class37_0.c03E813A_0.E1B5E312.method_18(CS_0024_003C_003E8__locals0.int_0, num14, "", CS_0024_003C_003E8__locals0.class37_0.c03E813A_0.gclass11_0);
												GClass8.EA9695BD(ref CS_0024_003C_003E8__locals0.class37_0.list_0, num14);
												if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbRepeatAll") || CS_0024_003C_003E8__locals0.class37_0.c03E813A_0.E1B5E312.C5151C09(CS_0024_003C_003E8__locals0.int_0) != "Live" || CS_0024_003C_003E8__locals0.class37_0.c03E813A_0.E1B5E312.E01F1137(CS_0024_003C_003E8__locals0.int_0).ToLower().Contains("checkpoint") || CS_0024_003C_003E8__locals0.class37_0.c03E813A_0.E1B5E312.E01F1137(CS_0024_003C_003E8__locals0.int_0).ToLower().Contains("invalid username or password") || CS_0024_003C_003E8__locals0.class37_0.c03E813A_0.E1B5E312.E01F1137(CS_0024_003C_003E8__locals0.int_0).ToLower().Contains("Proxy chưa ủy quyền!".ToLower()))
												{
													CS_0024_003C_003E8__locals0.class37_0.c03E813A_0.E1B5E312.method_58(CS_0024_003C_003E8__locals0.int_0, "cChose", false);
												}
											}
											catch (Exception ex2)
											{
												if (ex2.ToString().Contains("Thread was being aborted."))
												{
													GClass8.EA9695BD(ref CS_0024_003C_003E8__locals0.class37_0.list_0, num14);
													if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbRepeatAll"))
													{
														CS_0024_003C_003E8__locals0.class37_0.c03E813A_0.E1B5E312.method_58(CS_0024_003C_003E8__locals0.int_0, "cChose", false);
													}
												}
											}
										})
										{
											Name = CS_0024_003C_003E8__locals0.int_0.ToString()
										};
										c03E813A_0.E1B5E312.A235CA9E.Add(thread5);
										GClass8.smethod_53(1.0);
										thread5.Start();
									}
									else
									{
										if (Class57.smethod_5())
										{
											break;
										}
										if ((GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 7 && GClass25.smethod_0("configGeneral").method_3("ckbWaitDoneAllTinsoft")) || (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 8 && GClass25.smethod_0("configGeneral").method_3("ckbWaitDoneAllXproxy")) || (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 10 && GClass25.smethod_0("configGeneral").method_3("ckbWaitDoneAllTMProxy")))
										{
											for (int num9 = 0; num9 < c03E813A_0.E1B5E312.A235CA9E.Count; num9++)
											{
												c03E813A_0.E1B5E312.A235CA9E[num9].Join();
												c03E813A_0.E1B5E312.A235CA9E.RemoveAt(num9--);
											}
										}
										else if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") != 1 && GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") != 2)
										{
											for (int num10 = 0; num10 < c03E813A_0.E1B5E312.A235CA9E.Count; num10++)
											{
												if (!c03E813A_0.E1B5E312.A235CA9E[num10].IsAlive)
												{
													c03E813A_0.E1B5E312.A235CA9E.RemoveAt(num10--);
												}
											}
										}
										else
										{
											for (int num11 = 0; num11 < c03E813A_0.E1B5E312.A235CA9E.Count; num11++)
											{
												c03E813A_0.E1B5E312.A235CA9E[num11].Join();
												c03E813A_0.E1B5E312.A235CA9E.RemoveAt(num11--);
											}
											if (Class57.smethod_5())
											{
												break;
											}
											Interlocked.Increment(ref int_1);
											if (int_1 >= GClass25.smethod_0("configGeneral").method_2("ip_nudChangeIpCount", 1))
											{
												for (int num12 = 0; num12 < 3; num12++)
												{
													bool_0 = GClass8.DB05192A(GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp"), GClass25.smethod_0("configGeneral").method_2("typeDcom"), GClass25.smethod_0("configGeneral").C0288288("ip_txtProfileNameDcom"), GClass25.smethod_0("configGeneral").C0288288("txtUrlHilink"), GClass25.smethod_0("configGeneral").method_2("ip_cbbHostpot"), GClass25.smethod_0("configGeneral").C0288288("ip_txtNordVPN"));
													if (bool_0)
													{
														break;
													}
												}
												if (!bool_0)
												{
													GClass29.smethod_0("Không thê\u0309 đô\u0309i ip!", 2);
													Class57.A39EDD1D(bool_9: true);
													return;
												}
												int_1 = 0;
											}
										}
									}
								}
								else
								{
									num8++;
								}
								if (Class57.smethod_5())
								{
									break;
								}
							}
							for (int num13 = 0; num13 < c03E813A_0.E1B5E312.A235CA9E.Count; num13++)
							{
								c03E813A_0.E1B5E312.A235CA9E[num13].Join();
							}
						}
						catch (ThreadAbortException ex)
						{
							if (ex.ToString().Contains("Thread was being aborted."))
							{
							}
						}
					});
					thread4.IsBackground = true;
					thread4.Start();
					thread4.Join();
				}
			}
			catch (Exception f4295AA)
			{
				GClass8.BFBDF687(null, f4295AA);
			}
			c03E813A_0.E1B5E312.method_33();
			c03E813A_0.E1B5E312.method_34("stop");
			c03E813A_0.E1B5E312.A2AD659F = false;
		}

		internal void DA9D1D9D()
		{
			try
			{
				int num = 0;
				while (num < c03E813A_0.E1B5E312.EB3CF7AF.Rows.Count && !Class57.smethod_5())
				{
					if (Convert.ToBoolean(c03E813A_0.E1B5E312.EB3CF7AF.Rows[num].Cells["cChose"].Value))
					{
						if (Class57.smethod_5() || c03E813A_0.E1B5E312.A235CA9E.Count >= int_0)
						{
							break;
						}
						F1BB3721 CS_0024_003C_003E8__locals0 = new F1BB3721
						{
							class37_0 = this
						};
						if (Class57.smethod_5())
						{
							break;
						}
						CS_0024_003C_003E8__locals0.int_0 = num++;
						Thread thread = new Thread((ThreadStart)delegate
						{
							int int_ = GClass8.smethod_58(ref CS_0024_003C_003E8__locals0.class37_0.list_0);
							try
							{
								CS_0024_003C_003E8__locals0.class37_0.c03E813A_0.E1B5E312.method_18(CS_0024_003C_003E8__locals0.int_0, int_, "", CS_0024_003C_003E8__locals0.class37_0.c03E813A_0.gclass11_0);
							}
							catch (Exception f4295AA)
							{
								GClass8.BFBDF687(null, f4295AA);
							}
						})
						{
							Name = CS_0024_003C_003E8__locals0.int_0.ToString()
						};
						c03E813A_0.E1B5E312.A235CA9E.Add(thread);
						GClass8.smethod_53(1.0);
						thread.Start();
					}
					else
					{
						num++;
					}
				}
				for (int i = 0; i < c03E813A_0.E1B5E312.A235CA9E.Count; i++)
				{
					c03E813A_0.E1B5E312.A235CA9E[i].Join();
				}
			}
			catch (ThreadAbortException ex)
			{
				if (ex.ToString().Contains("Thread was being aborted."))
				{
				}
			}
		}

		internal void method_0()
		{
			try
			{
				int num = 0;
				while (num < c03E813A_0.E1B5E312.EB3CF7AF.Rows.Count && !Class57.smethod_5())
				{
					if (Convert.ToBoolean(c03E813A_0.E1B5E312.EB3CF7AF.Rows[num].Cells["cChose"].Value))
					{
						if (Class57.smethod_5())
						{
							break;
						}
						if (c03E813A_0.E1B5E312.A235CA9E.Count < int_0)
						{
							Class42 CS_0024_003C_003E8__locals0 = new Class42
							{
								class37_0 = this
							};
							if (Class57.smethod_5())
							{
								break;
							}
							CS_0024_003C_003E8__locals0.int_0 = num++;
							Thread thread = new Thread((ThreadStart)delegate
							{
								int num2 = GClass8.smethod_58(ref CS_0024_003C_003E8__locals0.class37_0.list_0);
								try
								{
									CS_0024_003C_003E8__locals0.class37_0.c03E813A_0.E1B5E312.method_18(CS_0024_003C_003E8__locals0.int_0, num2, "", CS_0024_003C_003E8__locals0.class37_0.c03E813A_0.gclass11_0);
									GClass8.EA9695BD(ref CS_0024_003C_003E8__locals0.class37_0.list_0, num2);
									if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbRepeatAll") || CS_0024_003C_003E8__locals0.class37_0.c03E813A_0.E1B5E312.C5151C09(CS_0024_003C_003E8__locals0.int_0) != "Live" || CS_0024_003C_003E8__locals0.class37_0.c03E813A_0.E1B5E312.E01F1137(CS_0024_003C_003E8__locals0.int_0).ToLower().Contains("checkpoint") || CS_0024_003C_003E8__locals0.class37_0.c03E813A_0.E1B5E312.E01F1137(CS_0024_003C_003E8__locals0.int_0).ToLower().Contains("invalid username or password") || CS_0024_003C_003E8__locals0.class37_0.c03E813A_0.E1B5E312.E01F1137(CS_0024_003C_003E8__locals0.int_0).ToLower().Contains("Proxy chưa ủy quyền!".ToLower()))
									{
										CS_0024_003C_003E8__locals0.class37_0.c03E813A_0.E1B5E312.method_58(CS_0024_003C_003E8__locals0.int_0, "cChose", false);
									}
								}
								catch (Exception ex2)
								{
									if (ex2.ToString().Contains("Thread was being aborted."))
									{
										GClass8.EA9695BD(ref CS_0024_003C_003E8__locals0.class37_0.list_0, num2);
										if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbRepeatAll"))
										{
											CS_0024_003C_003E8__locals0.class37_0.c03E813A_0.E1B5E312.method_58(CS_0024_003C_003E8__locals0.int_0, "cChose", false);
										}
									}
								}
							})
							{
								Name = CS_0024_003C_003E8__locals0.int_0.ToString()
							};
							c03E813A_0.E1B5E312.A235CA9E.Add(thread);
							GClass8.smethod_53(1.0);
							thread.Start();
						}
						else
						{
							if (Class57.smethod_5())
							{
								break;
							}
							if ((GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 7 && GClass25.smethod_0("configGeneral").method_3("ckbWaitDoneAllTinsoft")) || (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 8 && GClass25.smethod_0("configGeneral").method_3("ckbWaitDoneAllXproxy")) || (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 10 && GClass25.smethod_0("configGeneral").method_3("ckbWaitDoneAllTMProxy")))
							{
								for (int i = 0; i < c03E813A_0.E1B5E312.A235CA9E.Count; i++)
								{
									c03E813A_0.E1B5E312.A235CA9E[i].Join();
									c03E813A_0.E1B5E312.A235CA9E.RemoveAt(i--);
								}
							}
							else if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") != 1 && GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") != 2)
							{
								for (int j = 0; j < c03E813A_0.E1B5E312.A235CA9E.Count; j++)
								{
									if (!c03E813A_0.E1B5E312.A235CA9E[j].IsAlive)
									{
										c03E813A_0.E1B5E312.A235CA9E.RemoveAt(j--);
									}
								}
							}
							else
							{
								for (int k = 0; k < c03E813A_0.E1B5E312.A235CA9E.Count; k++)
								{
									c03E813A_0.E1B5E312.A235CA9E[k].Join();
									c03E813A_0.E1B5E312.A235CA9E.RemoveAt(k--);
								}
								if (Class57.smethod_5())
								{
									break;
								}
								Interlocked.Increment(ref int_1);
								if (int_1 >= GClass25.smethod_0("configGeneral").method_2("ip_nudChangeIpCount", 1))
								{
									for (int l = 0; l < 3; l++)
									{
										bool_0 = GClass8.DB05192A(GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp"), GClass25.smethod_0("configGeneral").method_2("typeDcom"), GClass25.smethod_0("configGeneral").C0288288("ip_txtProfileNameDcom"), GClass25.smethod_0("configGeneral").C0288288("txtUrlHilink"), GClass25.smethod_0("configGeneral").method_2("ip_cbbHostpot"), GClass25.smethod_0("configGeneral").C0288288("ip_txtNordVPN"));
										if (bool_0)
										{
											break;
										}
									}
									if (!bool_0)
									{
										GClass29.smethod_0("Không thê\u0309 đô\u0309i ip!", 2);
										Class57.A39EDD1D(bool_9: true);
										return;
									}
									int_1 = 0;
								}
							}
						}
					}
					else
					{
						num++;
					}
					if (Class57.smethod_5())
					{
						break;
					}
				}
				for (int m = 0; m < c03E813A_0.E1B5E312.A235CA9E.Count; m++)
				{
					c03E813A_0.E1B5E312.A235CA9E[m].Join();
				}
			}
			catch (ThreadAbortException ex)
			{
				if (ex.ToString().Contains("Thread was being aborted."))
				{
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class38
	{
		public string CD3CE331;

		public Class37 A88E1A87;

		public ThreadStart threadStart_0;

		internal void method_0()
		{
			try
			{
				int num = 0;
				while (num < A88E1A87.c03E813A_0.E1B5E312.EB3CF7AF.Rows.Count && !Class57.smethod_5())
				{
					if (Convert.ToBoolean(A88E1A87.c03E813A_0.E1B5E312.EB3CF7AF.Rows[num].Cells["cChose"].Value))
					{
						if (Class57.smethod_5())
						{
							break;
						}
						if (A88E1A87.c03E813A_0.E1B5E312.A235CA9E.Count < A88E1A87.int_0)
						{
							Class41 CS_0024_003C_003E8__locals0 = new Class41
							{
								class38_0 = this
							};
							if (Class57.smethod_5())
							{
								break;
							}
							CS_0024_003C_003E8__locals0.A209A0BB = num++;
							Thread thread = new Thread((ThreadStart)delegate
							{
								int num2 = GClass8.smethod_58(ref CS_0024_003C_003E8__locals0.class38_0.A88E1A87.list_0);
								try
								{
									CS_0024_003C_003E8__locals0.class38_0.A88E1A87.c03E813A_0.E1B5E312.method_18(CS_0024_003C_003E8__locals0.A209A0BB, num2, CS_0024_003C_003E8__locals0.class38_0.CD3CE331, CS_0024_003C_003E8__locals0.class38_0.A88E1A87.c03E813A_0.gclass11_0);
									GClass8.EA9695BD(ref CS_0024_003C_003E8__locals0.class38_0.A88E1A87.list_0, num2);
									bool flag = false;
									if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbRepeatAll"))
									{
										flag = true;
									}
									else
									{
										string text = CS_0024_003C_003E8__locals0.class38_0.A88E1A87.c03E813A_0.E1B5E312.C5151C09(CS_0024_003C_003E8__locals0.A209A0BB);
										if (text != "Live")
										{
											flag = true;
										}
										if (!flag)
										{
											string text2 = CS_0024_003C_003E8__locals0.class38_0.A88E1A87.c03E813A_0.E1B5E312.E01F1137(CS_0024_003C_003E8__locals0.A209A0BB).ToLower();
											flag = text2.Contains("checkpoint") || text2.Contains("invalid username or password") || text2.Contains("Proxy chưa ủy quyền!".ToLower()) || text2.Contains("fb block") || text2.Contains("Max Job Today".ToLower());
										}
									}
									if (flag)
									{
										CS_0024_003C_003E8__locals0.class38_0.A88E1A87.c03E813A_0.E1B5E312.method_58(CS_0024_003C_003E8__locals0.A209A0BB, "cChose", false);
									}
								}
								catch (Exception ex2)
								{
									if (ex2.ToString().Contains("Thread was being aborted."))
									{
										GClass8.EA9695BD(ref CS_0024_003C_003E8__locals0.class38_0.A88E1A87.list_0, num2);
										if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbRepeatAll"))
										{
											CS_0024_003C_003E8__locals0.class38_0.A88E1A87.c03E813A_0.E1B5E312.method_58(CS_0024_003C_003E8__locals0.A209A0BB, "cChose", false);
										}
									}
								}
							})
							{
								Name = CS_0024_003C_003E8__locals0.A209A0BB.ToString()
							};
							A88E1A87.c03E813A_0.E1B5E312.A235CA9E.Add(thread);
							GClass8.smethod_53(1.0);
							thread.Start();
						}
						else
						{
							if (Class57.smethod_5())
							{
								break;
							}
							if ((GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 7 && GClass25.smethod_0("configGeneral").method_3("ckbWaitDoneAllTinsoft")) || (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 8 && GClass25.smethod_0("configGeneral").method_3("ckbWaitDoneAllXproxy")) || (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 10 && GClass25.smethod_0("configGeneral").method_3("ckbWaitDoneAllTMProxy")))
							{
								for (int i = 0; i < A88E1A87.c03E813A_0.E1B5E312.A235CA9E.Count; i++)
								{
									A88E1A87.c03E813A_0.E1B5E312.A235CA9E[i].Join();
									A88E1A87.c03E813A_0.E1B5E312.A235CA9E.RemoveAt(i--);
								}
							}
							else if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") != 1 && GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") != 2)
							{
								for (int j = 0; j < A88E1A87.c03E813A_0.E1B5E312.A235CA9E.Count; j++)
								{
									if (!A88E1A87.c03E813A_0.E1B5E312.A235CA9E[j].IsAlive)
									{
										A88E1A87.c03E813A_0.E1B5E312.A235CA9E.RemoveAt(j--);
									}
								}
							}
							else
							{
								for (int k = 0; k < A88E1A87.c03E813A_0.E1B5E312.A235CA9E.Count; k++)
								{
									A88E1A87.c03E813A_0.E1B5E312.A235CA9E[k].Join();
									A88E1A87.c03E813A_0.E1B5E312.A235CA9E.RemoveAt(k--);
								}
								if (Class57.smethod_5())
								{
									break;
								}
								Interlocked.Increment(ref A88E1A87.int_1);
								if (A88E1A87.int_1 >= GClass25.smethod_0("configGeneral").method_2("ip_nudChangeIpCount", 1))
								{
									for (int l = 0; l < 3; l++)
									{
										A88E1A87.bool_0 = GClass8.DB05192A(GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp"), GClass25.smethod_0("configGeneral").method_2("typeDcom"), GClass25.smethod_0("configGeneral").C0288288("ip_txtProfileNameDcom"), GClass25.smethod_0("configGeneral").C0288288("txtUrlHilink"), GClass25.smethod_0("configGeneral").method_2("ip_cbbHostpot"), GClass25.smethod_0("configGeneral").C0288288("ip_txtNordVPN"));
										if (A88E1A87.bool_0)
										{
											break;
										}
									}
									if (!A88E1A87.bool_0)
									{
										GClass29.smethod_0("Không thê\u0309 đô\u0309i ip!", 2);
										Class57.A39EDD1D(bool_9: true);
										return;
									}
									A88E1A87.int_1 = 0;
								}
							}
						}
					}
					else
					{
						num++;
					}
					if (Class57.smethod_5())
					{
						break;
					}
				}
				for (int m = 0; m < A88E1A87.c03E813A_0.E1B5E312.A235CA9E.Count; m++)
				{
					A88E1A87.c03E813A_0.E1B5E312.A235CA9E[m].Join();
				}
			}
			catch (ThreadAbortException ex)
			{
				if (ex.ToString().Contains("Thread was being aborted."))
				{
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class39
	{
		public int CC2C6927;

		public int int_0;

		public Class38 class38_0;

		internal void DEA6B100()
		{
			int num = 0;
			while (num < class38_0.A88E1A87.c03E813A_0.E1B5E312.EB3CF7AF.Rows.Count)
			{
				if (Convert.ToBoolean(class38_0.A88E1A87.c03E813A_0.E1B5E312.EB3CF7AF.Rows[num].Cells["cChose"].Value))
				{
					if (CC2C6927 < int_0)
					{
						Class40 CS_0024_003C_003E8__locals0 = new Class40
						{
							class39_0 = this
						};
						Interlocked.Increment(ref CC2C6927);
						CS_0024_003C_003E8__locals0.E0856D06 = num++;
						Thread thread = new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class39_0.class38_0.A88E1A87.c03E813A_0.E1B5E312.A1BF1713(CS_0024_003C_003E8__locals0.E0856D06, F7AB102E.smethod_0("Đang xo\u0301a Cache Profile..."));
							CS_0024_003C_003E8__locals0.class39_0.class38_0.A88E1A87.c03E813A_0.E1B5E312.F1A2A699(CS_0024_003C_003E8__locals0.E0856D06);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class39_0.CC2C6927);
						});
						thread.IsBackground = true;
						thread.Start();
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
	private sealed class Class40
	{
		public int E0856D06;

		public Class39 class39_0;

		internal void method_0()
		{
			class39_0.class38_0.A88E1A87.c03E813A_0.E1B5E312.A1BF1713(E0856D06, F7AB102E.smethod_0("Đang xo\u0301a Cache Profile..."));
			class39_0.class38_0.A88E1A87.c03E813A_0.E1B5E312.F1A2A699(E0856D06);
			Interlocked.Decrement(ref class39_0.CC2C6927);
		}
	}

	[CompilerGenerated]
	private sealed class Class41
	{
		public int A209A0BB;

		public Class38 class38_0;

		internal void method_0()
		{
			int num = GClass8.smethod_58(ref class38_0.A88E1A87.list_0);
			try
			{
				class38_0.A88E1A87.c03E813A_0.E1B5E312.method_18(A209A0BB, num, class38_0.CD3CE331, class38_0.A88E1A87.c03E813A_0.gclass11_0);
				GClass8.EA9695BD(ref class38_0.A88E1A87.list_0, num);
				bool flag = false;
				if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbRepeatAll"))
				{
					flag = true;
				}
				else
				{
					string text = class38_0.A88E1A87.c03E813A_0.E1B5E312.C5151C09(A209A0BB);
					if (text != "Live")
					{
						flag = true;
					}
					if (!flag)
					{
						string text2 = class38_0.A88E1A87.c03E813A_0.E1B5E312.E01F1137(A209A0BB).ToLower();
						flag = text2.Contains("checkpoint") || text2.Contains("invalid username or password") || text2.Contains("Proxy chưa ủy quyền!".ToLower()) || text2.Contains("fb block") || text2.Contains("Max Job Today".ToLower());
					}
				}
				if (flag)
				{
					class38_0.A88E1A87.c03E813A_0.E1B5E312.method_58(A209A0BB, "cChose", false);
				}
			}
			catch (Exception ex)
			{
				if (ex.ToString().Contains("Thread was being aborted."))
				{
					GClass8.EA9695BD(ref class38_0.A88E1A87.list_0, num);
					if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbRepeatAll"))
					{
						class38_0.A88E1A87.c03E813A_0.E1B5E312.method_58(A209A0BB, "cChose", false);
					}
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class F1BB3721
	{
		public int int_0;

		public Class37 class37_0;

		internal void method_0()
		{
			int int_ = GClass8.smethod_58(ref class37_0.list_0);
			try
			{
				class37_0.c03E813A_0.E1B5E312.method_18(int_0, int_, "", class37_0.c03E813A_0.gclass11_0);
			}
			catch (Exception f4295AA)
			{
				GClass8.BFBDF687(null, f4295AA);
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class42
	{
		public int int_0;

		public Class37 class37_0;

		internal void D49F2992()
		{
			int num = GClass8.smethod_58(ref class37_0.list_0);
			try
			{
				class37_0.c03E813A_0.E1B5E312.method_18(int_0, num, "", class37_0.c03E813A_0.gclass11_0);
				GClass8.EA9695BD(ref class37_0.list_0, num);
				if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbRepeatAll") || class37_0.c03E813A_0.E1B5E312.C5151C09(int_0) != "Live" || class37_0.c03E813A_0.E1B5E312.E01F1137(int_0).ToLower().Contains("checkpoint") || class37_0.c03E813A_0.E1B5E312.E01F1137(int_0).ToLower().Contains("invalid username or password") || class37_0.c03E813A_0.E1B5E312.E01F1137(int_0).ToLower().Contains("Proxy chưa ủy quyền!".ToLower()))
				{
					class37_0.c03E813A_0.E1B5E312.method_58(int_0, "cChose", false);
				}
			}
			catch (Exception ex)
			{
				if (ex.ToString().Contains("Thread was being aborted."))
				{
					GClass8.EA9695BD(ref class37_0.list_0, num);
					if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbRepeatAll"))
					{
						class37_0.c03E813A_0.E1B5E312.method_58(int_0, "cChose", false);
					}
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class43
	{
		public string string_0;

		internal bool method_0(KeyValuePair<string, List<string>> keyValuePair_0)
		{
			return keyValuePair_0.Value.Contains(string_0);
		}
	}

	private GClass11 B1A9102B;

	private List<Thread> A235CA9E = null;

	private List<FC9552BB> F8B76B18 = null;

	private List<GClass5> list_0 = null;

	private Dictionary<string, List<string>> dictionary_0 = null;

	private Dictionary<string, List<string>> dictionary_1 = null;

	private Dictionary<string, List<string>> dictionary_2 = null;

	private Dictionary<string, List<string>> dictionary_3 = null;

	private Dictionary<string, List<string>> dictionary_4 = null;

	private Dictionary<string, List<string>> dictionary_5 = null;

	private Dictionary<string, List<string>> dictionary_6 = null;

	private Dictionary<string, List<string>> B928E63C = null;

	private Dictionary<string, List<string>> A3B286B4 = null;

	private Dictionary<string, List<string>> dictionary_7 = null;

	private Dictionary<string, List<string>> dictionary_8 = null;

	private Dictionary<string, List<string>> E2ACA8BF = null;

	private Dictionary<string, List<string>> B931FABE = null;

	private Dictionary<string, List<string>> D61C6110 = null;

	private Dictionary<string, List<string>> dictionary_9 = null;

	private Dictionary<string, List<string>> F725FAA3 = null;

	private Dictionary<string, List<string>> E6B1DEA5 = null;

	private Dictionary<string, List<string>> dictionary_10 = null;

	private Dictionary<string, List<string>> CD146FB9 = null;

	private Dictionary<string, List<string>> dictionary_11 = null;

	private Dictionary<string, List<string>> BE3A6DAD = null;

	private Dictionary<string, List<string>> dictionary_12 = null;

	private Dictionary<string, List<string>> dictionary_13 = null;

	private Dictionary<string, List<string>> A0840D3F = null;

	private Dictionary<string, List<string>> dictionary_14 = null;

	private Dictionary<string, List<string>> dictionary_15 = null;

	private Dictionary<string, List<string>> dictionary_16 = null;

	private Dictionary<string, List<string>> dictionary_17 = null;

	private Dictionary<string, List<string>> dictionary_18 = null;

	private Dictionary<string, List<string>> dictionary_19 = null;

	private Dictionary<string, List<string>> dictionary_20 = null;

	private Dictionary<string, List<string>> dictionary_21 = null;

	private Dictionary<string, List<string>> dictionary_22 = null;

	private Dictionary<string, List<string>> A5362C12 = null;

	private Dictionary<string, List<string>> dictionary_23 = null;

	private Dictionary<string, List<string>> BAAAB69C = null;

	private Dictionary<string, List<string>> FC17EB12 = null;

	private Dictionary<string, Dictionary<string, List<string>>> dictionary_24 = null;

	private Dictionary<string, List<string>> dictionary_25 = null;

	private Dictionary<string, Dictionary<string, int>> A11D612D = null;

	private Dictionary<string, List<string>> dictionary_26 = null;

	private object EEB7322B = new object();

	private object object_0 = new object();

	private List<string> A0B1CC2A = new List<string>();

	private Dictionary<string, List<string>> dictionary_27 = new Dictionary<string, List<string>>();

	private object object_1 = new object();

	private object D5052698 = new object();

	private int FD8F4B3F = -1;

	private bool bool_0 = true;

	private object object_2 = new object();

	private object object_3 = new object();

	private object object_4 = new object();

	private object object_5 = new object();

	private object object_6 = new object();

	private int int_0 = -1;

	private bool CF9F8596 = true;

	private bool A2AD659F = false;

	private List<string> list_1 = new List<string>();

	private bool bool_1 = false;

	private int int_1 = 0;

	private List<CheckBox> list_2 = null;

	public object object_7 = new object();

	public int int_2 = 0;

	public object object_8 = new object();

	private int int_3 = 0;

	private Dictionary<int, E31BC589> dictionary_28 = new Dictionary<int, E31BC589>();

	private IContainer icontainer_0 = null;

	public static string string_0 = "";

	private BunifuDragControl bunifuDragControl_0;

	private BunifuCards bunifuCards1;

	private Panel C00C0E9C;

	private PictureBox pictureBox1;

	private Button C90B629E;

	private Button BF851712;

	private Button btnClose;

	private BunifuCustomLabel bunifuCustomLabel1;

	private MenuStrip menuStrip1;

	private ContextMenuStrip ctmsAcc;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem E10A271D;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem B303123E;

	private ToolStripMenuItem A824BF38;

	private ToolStripMenuItem cookieToolStripMenuItem;

	private ToolStripMenuItem uidPassToolStripMenuItem;

	private ToolStripMenuItem D281F59B;

	private ToolStripMenuItem A51845B4;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem checkCookieToolStripMenuItem;

	private ToolStripMenuItem B789AA08;

	private ToolStripMenuItem AD85CC0E;

	private ToolStripMenuItem passToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_3;

	private ToolStripMenuItem toolStripMenuItem_4;

	private ToolStripMenuItem toolStripMenuItem_5;

	private ToolStripMenuItem toolStripMenuItem_6;

	private ToolStripMenuItem mnuChucNang;

	private ToolStripMenuItem mailPassMailToolStripMenuItem;

	private ToolStripMenuItem uidPassTokenCookieMailPassMailToolStripMenuItem;

	private ToolStripMenuItem E784828B;

	private ToolStripMenuItem C498B099;

	private ToolStripMenuItem mailToolStripMenuItem;

	private ToolStripMenuItem AB28FC9F;

	private ToolStripMenuItem fAToolStripMenuItem;

	private ToolStripMenuItem tinhTrangToolStripMenuItem;

	private ToolStripMenuItem locTrungToolStripMenuItem;

	private ToolStripMenuItem uidPass2FaToolStripMenuItem;

	private BunifuDragControl D81FA988;

	private ToolTip E9372C3C;

	private ToolStripMenuItem toolStripMenuItem_7;

	private ToolStripMenuItem toolStripMenuItem_8;

	private ToolStripMenuItem toolStripMenuItem_9;

	private ToolStripMenuItem F586C109;

	private ToolStripMenuItem D8123B8B;

	private ToolStripMenuItem toolStripMenuItem_10;

	private Panel F5948F3E;

	private Label EF36EA35;

	private ToolStripMenuItem uidToolStripMenuItem;

	private ToolStripMenuItem checkAvatarToolStripMenuItem;

	private ToolStripMenuItem DCB311B2;

	private ToolStripMenuItem checkProfileToolStripMenuItem1;

	private ToolStripMenuItem checkInfoUIDToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_11;

	private ToolStripMenuItem toolStripMenuItem_12;

	private ToolStripMenuItem toolStripMenuItem_13;

	private ToolStripMenuItem checkHotmailToolStripMenuItem;

	private ToolStripMenuItem checkProxyToolStripMenuItem1;

	private ToolStripMenuItem lToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_14;

	private ToolStripMenuItem checkLiveUidToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_15;

	private ToolStripMenuItem E00A8821;

	private ToolStripMenuItem toolStripMenuItem_16;

	private ToolStripMenuItem emailPassMailMailKpToolStripMenuItem;

	private StatusStrip EA0BF912;

	private ToolStripStatusLabel toolStripStatusLabel4;

	private ToolStripStatusLabel E71E4104;

	private ToolStripStatusLabel CF1A928E;

	private ToolStripStatusLabel lblCountSelect;

	private ToolStripStatusLabel toolStripStatusLabel7;

	private ToolStripStatusLabel lblCountTotal;

	private Button metroButton1;

	private Panel EF907231;

	private Button C0290281;

	private ComboBox DC2BDDA5;

	private BunifuCustomTextbox txbSearch;

	private Panel C3BBF8AC;

	private Button btnLoadAcc;

	private Label label1;

	private Button btnEditFile;

	private Button button9;

	private Button FA856528;

	private Label label2;

	private Button FEAB929D;

	private ComboBox cbbThuMuc;

	private ComboBox cbbTinhTrang;

	private Panel panel1;

	private StatusStrip statusStrip1;

	private ToolStripMenuItem toolStripMenuItem_17;

	private ToolStripMenuItem toolStripMenuItem_18;

	private ToolStripMenuItem B396C512;

	private ToolStripMenuItem C8A8A0A5;

	private ToolStripMenuItem testSpinTextToolStripMenuItem;

	private ToolStripMenuItem getTokenEAAAAUToolStripMenuItem;

	private ToolStripMenuItem getTokenEAAAAUBToolStripMenuItem;

	private ToolStripMenuItem BF379492;

	private ToolStripMenuItem checkStatusXproxyToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_19;

	private ToolStripMenuItem toolStripMenuItem_20;

	private ToolStripMenuItem checkNameVNToolStripMenuItem;

	private ToolStripMenuItem A7BA973D;

	private ToolStripMenuItem toolStripMenuItem1;

	private LinkLabel D99BA487;

	private CheckBox ckbUnlock956;

	private TextBox txtApiKey;

	private Label FB1741A8;

	private CheckBox ckbLike;

	private Button button2;

	private Button D9927D91;

	private Button btnInteract;

	private CheckBox ckbFollow;

	private CheckBox ckbCommentfb;

	private CheckBox ckbShare;

	private CheckBox FE0EEC0F;

	private CheckBox ckbLike_Comment;

	private CheckBox ckbJoin_Group;

	private CheckBox ckbCheckAll;

	private ComboBox EF1D13BA;

	private Button B706E7AC;

	private NumericUpDown nudDelayTo;

	private NumericUpDown A63DDA9B;

	private NumericUpDown F18113B8;

	private NumericUpDown AF0B1AB0;

	private Label label7;

	private Label label13;

	private Label B3A671B1;

	private Label BD8A7F88;

	private Label E62B17A7;

	private Label E4B49E18;

	private Label label4;

	private NumericUpDown FD9C2193;

	private Label label20;

	private Label label29;

	private CheckBox ckbHideBrowser;

	private CheckBox ckbShowImageInteract;

	private Label label6;

	private ComboBox EE3D8093;

	private Label label8;

	private ComboBox cbbFacebookWeb;

	private ComboBox cbbChangeIP;

	private Label label9;

	private NumericUpDown nudDelayOpenChromeTo;

	public DataGridView EB3CF7AF;

	private ToolStripMenuItem profileToolStripMenuItem;

	private ToolStripMenuItem checkProfileToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_21;

	private ToolStripMenuItem B005D087;

	private ToolStripMenuItem toolStripMenuItem_22;

	private ToolStripMenuItem A900291F;

	private Button btnHienCaiDat;

	private NumericUpDown nudMaxChrome;

	private Label E604DA36;

	private ToolStripMenuItem checkGolikeToolStripMenuItem;

	private NumericUpDown F40A5030;

	private Label C129E939;

	private ToolStripStatusLabel C5B60C89;

	private ToolStripStatusLabel lblCountRunning;

	private ToolStripStatusLabel CF8E9634;

	private ToolStripStatusLabel lblCountChrome;

	private NumericUpDown nudBreakTimeJob;

	private Label DFB28682;

	private CheckBox CEBA2D85;

	private NumericUpDown F62E8310;

	private Label label24;

	private Panel plBreakTime;

	private CheckBox B50940A9;

	private CheckBox ckbCheckLiveUid;

	private NumericUpDown nudTimeoutGetJob;

	private Label C7BBA9A1;

	private CheckBox ckbCheckProxy;

	private CheckBox F49B67B7;

	private CheckBox D30C68B8;

	private CheckBox ckbChayBangPageProfile;

	private CheckBox EF91F21A;

	private GroupBox grChonJob;

	private ToolStripMenuItem BD1D0DA4;

	private ToolStripMenuItem toolStripMenuItem2;

	private ToolStripMenuItem toolStripMenuItem4;

	private ToolStripMenuItem toolStripMenuItem5;

	private ToolStripMenuItem toolStripMenuItem6;

	private ToolStripMenuItem A48F96AF;

	private ToolStripMenuItem C1233E0A;

	private ToolStripMenuItem C9B47E80;

	private ToolStripMenuItem toolStripMenuItem10;

	private ToolStripMenuItem toolStripMenuItem11;

	private ToolStripMenuItem toolStripMenuItem12;

	private ToolStripMenuItem toolStripMenuItem13;

	private ToolStripMenuItem toolStripMenuItem14;

	private ToolStripMenuItem toolStripMenuItem15;

	private ToolStripMenuItem toolStripMenuItem16;

	private ToolStripMenuItem toolStripMenuItem17;

	private ToolStripMenuItem E53062A2;

	private ToolStripMenuItem AF26FD8B;

	private ToolStripMenuItem CB1F2182;

	private CheckBox ckbLikePage_PageProfile;

	private Label lblServer;

	private ComboBox cbbServer;

	private CheckBox D3011989;

	private Label F98E5B8A;

	private Panel plChayBangToken;

	private Label label19;

	private Label label10;

	private ComboBox cbbGetTokenBy;

	private TabControl tabControl1;

	private TabPage BB832C28;

	private TabPage tabPage3;

	private GroupBox CB30E000;

	private GroupBox B38E60B4;

	private GroupBox grRunBy;

	private GroupBox A739F720;

	private CheckBox ckbAngry;

	private CheckBox ckbHaha;

	private CheckBox F7BC6739;

	private CheckBox ckbCare;

	private CheckBox D69B8981;

	private CheckBox ckbLove;

	private CheckBox ckbCommentfb_via_female2;

	private CheckBox ckbCommentfb_via_male2;

	private CheckBox A73F6F03;

	private CheckBox ckbCommentfb_full_avatar2;

	private DataGridViewCheckBoxColumn cChose;

	private DataGridViewTextBoxColumn cStt;

	private DataGridViewTextBoxColumn cId;

	private DataGridViewTextBoxColumn FD886B35;

	private DataGridViewTextBoxColumn F2BE232E;

	private DataGridViewTextBoxColumn DC2D399A;

	private DataGridViewTextBoxColumn E128C7A9;

	private DataGridViewTextBoxColumn cCookies;

	private DataGridViewTextBoxColumn A4209E84;

	private DataGridViewTextBoxColumn cEmail2;

	private DataGridViewTextBoxColumn cPassMail;

	private DataGridViewTextBoxColumn cMailRecovery;

	private DataGridViewTextBoxColumn cPassMailRecovery;

	private DataGridViewTextBoxColumn CABFF297;

	private DataGridViewTextBoxColumn cName;

	private DataGridViewTextBoxColumn cFollow;

	private DataGridViewTextBoxColumn cFriend;

	private DataGridViewTextBoxColumn cGroup;

	private DataGridViewTextBoxColumn cPage;

	private DataGridViewTextBoxColumn cPagePro5;

	private DataGridViewTextBoxColumn E23A412F;

	private DataGridViewTextBoxColumn cGender;

	private DataGridViewTextBoxColumn cOAuth2;

	private DataGridViewTextBoxColumn CFB06338;

	private DataGridViewTextBoxColumn cProxy;

	private DataGridViewTextBoxColumn F7AF4722;

	private DataGridViewTextBoxColumn cAvatar;

	private DataGridViewTextBoxColumn cProfile;

	private DataGridViewTextBoxColumn cThuMuc;

	private DataGridViewTextBoxColumn cInteractEnd;

	private DataGridViewTextBoxColumn BBB2678F;

	private DataGridViewTextBoxColumn D61BBD3F;

	private DataGridViewTextBoxColumn cStatus282;

	private DataGridViewTextBoxColumn cLocation;

	private DataGridViewTextBoxColumn cHometown;

	private DataGridViewTextBoxColumn cCurrentCity;

	private DataGridViewTextBoxColumn cDating;

	private DataGridViewTextBoxColumn A2919486;

	private DataGridViewTextBoxColumn cBM;

	private DataGridViewTextBoxColumn cWallPosts;

	private DataGridViewTextBoxColumn C7A5BE91;

	private DataGridViewTextBoxColumn EA8C022B;

	private DataGridViewTextBoxColumn cKichBan;

	private DataGridViewTextBoxColumn cStatus;

	private Panel plKey;

	private Label lblKey;

	private TextBox C413DEAD;

	private Button E2035928;

	private Button btnDown;

	private RadioButton rbChayBangCookie;

	private RadioButton rbChayBangChrome;

	private RadioButton rbChayBangToken;

	public A6BA4B90(string string_1)
	{
		InitializeComponent();
		B1A9102B = new GClass11("golike");
		FA15011F();
		txbSearch.smethod_2();
		ckbLikePage_PageProfile.Visible = Class57.bool_0;
		ckbChayBangPageProfile.Visible = false;
		bunifuCustomLabel1.Text = string_1;
		tabControl1.SelectedIndex = 1;
		method_0();
	}

	private void method_0()
	{
		F7AB102E.D6B70A35(this);
		F7AB102E.smethod_4(ctmsAcc);
	}

	protected override void OnLoad(EventArgs DBB7669F)
	{
		Application.Idle += method_1;
	}

	private void method_1(object sender, EventArgs e)
	{
		Application.Idle -= method_1;
		method_2();
		method_64();
		AC37B195(1);
		E78EEE83(EB221108());
		menuStrip1.Cursor = Cursors.Hand;
		list_2 = new List<CheckBox>
		{
			ckbLike, ckbLove, ckbCare, ckbHaha, D69B8981, F7BC6739, ckbAngry, ckbFollow, FE0EEC0F, ckbJoin_Group,
			ckbLike_Comment, ckbCommentfb, ckbShare, D3011989, EF91F21A, A73F6F03, ckbCommentfb_via_male2, ckbCommentfb_via_female2, ckbCommentfb_full_avatar2
		};
		FBBA90BD();
		method_3();
		ckbChayBangPageProfile.Checked = false;
		F69F0991(null, null);
		ckbUnlock956_CheckedChanged(null, null);
		DE07A521(null, null);
		cbbServer.SelectedIndexChanged += cbbServer_SelectedIndexChanged;
	}

	private void FBBA90BD()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Không đổi IP");
		dictionary.Add("1", "Proxy");
		GClass8.smethod_23(cbbChangeIP, dictionary);
	}

	private void method_2()
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
		DC2BDDA5.DataSource = new BindingSource(dataSource, null);
		DC2BDDA5.ValueMember = "Key";
		DC2BDDA5.DisplayMember = "Value";
	}

	private void AC37B195(int int_4 = -1)
	{
		bool_0 = false;
		DataTable dataSource = Class15.smethod_1(bool_0: true);
		cbbThuMuc.DataSource = dataSource;
		cbbThuMuc.ValueMember = "id";
		cbbThuMuc.DisplayMember = "name";
		if (int_4 != -1 && cbbThuMuc.Items.Count >= int_4)
		{
			cbbThuMuc.SelectedIndex = int_4;
		}
		else if (cbbThuMuc.Items.Count == 2)
		{
			cbbThuMuc.SelectedIndex = -1;
		}
		bool_0 = true;
	}

	private void E78EEE83(List<string> list_3 = null)
	{
		try
		{
			DataTable dataSource = Class15.E62BDA25(list_3);
			cbbTinhTrang.DataSource = dataSource;
			cbbTinhTrang.ValueMember = "id";
			cbbTinhTrang.DisplayMember = "name";
		}
		catch
		{
		}
	}

	private void method_3()
	{
		txtApiKey.Text = B1A9102B.C0288288("txtApiKey");
		AF0B1AB0.Value = ((B1A9102B.method_2("nudDelayFrom", 10) < 10) ? 10 : B1A9102B.method_2("nudDelayFrom", 10));
		nudDelayTo.Value = ((B1A9102B.method_2("nudDelayTo", 10) < 10) ? 10 : B1A9102B.method_2("nudDelayTo", 10));
		F18113B8.Value = B1A9102B.method_2("nudMaxJobFailLienTiep", 5);
		A63DDA9B.Value = B1A9102B.method_2("nudMaxJobToday", 100);
		ckbChayBangPageProfile.Checked = B1A9102B.method_3("ckbChayBangPageProfile");
		nudTimeoutGetJob.Value = B1A9102B.method_2("nudTimeoutGetJob", 300);
		ckbCheckProxy.Checked = true;
		ckbCheckLiveUid.Checked = true;
		F49B67B7.Checked = true;
		B50940A9.Checked = B1A9102B.method_3("ckbRepeatAll", bool_0: true);
		ckbUnlock956.Checked = false;
		D30C68B8.Checked = B1A9102B.method_3("ckbGetTokenWhenDie", bool_0: true);
		CEBA2D85.Checked = B1A9102B.method_3("ckbBreakTime");
		nudBreakTimeJob.Value = B1A9102B.method_2("nudBreakTimeJob", 10);
		F62E8310.Value = B1A9102B.method_2("nudBreakTime", 60);
		if (Class57.DE24BEB7)
		{
			cbbServer.SelectedIndex = B1A9102B.method_2("cbbServer");
		}
		else
		{
			cbbServer.SelectedIndex = 0;
			cbbServer.Enabled = false;
		}
		List<string> list = B1A9102B.C0288288("jobType").Split(',').ToList();
		for (int i = 0; i < list_2.Count; i++)
		{
			list_2[i].Checked = list.Contains(list_2[i].Name.Substring(3).ToLower());
		}
		C413DEAD.Text = B1A9102B.C0288288("txtKey");
		F40A5030.Value = B1A9102B.method_2("nudThread", 10);
		nudMaxChrome.Value = B1A9102B.method_2("nudMaxChrome", 10);
		ckbShowImageInteract.Checked = B1A9102B.method_3("ckbShowImageInteract");
		ckbHideBrowser.Checked = B1A9102B.method_3("ckbHideBrowser");
		FD9C2193.Value = B1A9102B.method_2("nudDelayOpenChromeFrom", 1);
		nudDelayOpenChromeTo.Value = B1A9102B.method_2("nudDelayOpenChromeTo", 1);
		EE3D8093.SelectedIndex = B1A9102B.method_2("cbbTypeLogin", 3);
		cbbFacebookWeb.SelectedIndex = B1A9102B.method_2("cbbFacebookWeb");
		cbbChangeIP.SelectedIndex = B1A9102B.method_2("cbbChangeIP", 1);
		switch (B1A9102B.method_2("typeRunBy"))
		{
		case 0:
			rbChayBangToken.Checked = true;
			break;
		case 1:
			rbChayBangCookie.Checked = true;
			break;
		case 2:
			rbChayBangChrome.Checked = true;
			break;
		}
		plChayBangToken.Enabled = rbChayBangToken.Checked;
		EF1D13BA.SelectedIndex = B1A9102B.method_2("cbbTypeGetToken", 1);
		try
		{
			cbbGetTokenBy.SelectedValue = B1A9102B.C0288288("cbbGetTokenBy", "uid");
		}
		catch (Exception)
		{
			cbbGetTokenBy.SelectedIndex = 0;
		}
		method_81();
		if (B1A9102B.method_3("hideSettings"))
		{
			C53947BC(null, null);
		}
	}

	private void A6A691B6()
	{
		try
		{
			B1A9102B.method_4("txtApiKey", txtApiKey.Text);
			B1A9102B.method_4("nudDelayFrom", AF0B1AB0.Value);
			B1A9102B.method_4("nudDelayTo", nudDelayTo.Value);
			B1A9102B.method_4("nudMaxJobFailLienTiep", F18113B8.Value);
			B1A9102B.method_4("nudMaxJobToday", A63DDA9B.Value);
			B1A9102B.method_4("ckbChayBangPageProfile", ckbChayBangPageProfile.Checked);
			B1A9102B.method_4("nudTimeoutGetJob", nudTimeoutGetJob.Value);
			B1A9102B.method_4("ckbCheckProxy", ckbCheckProxy.Checked);
			B1A9102B.method_4("ckbCheckLiveUid", ckbCheckLiveUid.Checked);
			B1A9102B.method_4("ckbCheckToken", F49B67B7.Checked);
			B1A9102B.method_4("ckbRepeatAll", B50940A9.Checked);
			B1A9102B.method_4("ckbUnlock956", ckbUnlock956.Checked);
			B1A9102B.method_4("ckbGetTokenWhenDie", D30C68B8.Checked);
			B1A9102B.method_4("ckbBreakTime", CEBA2D85.Checked);
			B1A9102B.method_4("nudBreakTimeJob", nudBreakTimeJob.Value);
			B1A9102B.method_4("nudBreakTime", F62E8310.Value);
			B1A9102B.method_4("cbbServer", cbbServer.SelectedIndex);
			string text = method_74();
			B1A9102B.method_4("jobType", text);
			B1A9102B.method_4("txtKey", C413DEAD.Text);
			B1A9102B.method_4("nudThread", F40A5030.Value);
			B1A9102B.method_4("nudMaxChrome", nudMaxChrome.Value);
			B1A9102B.method_4("ckbShowImageInteract", ckbShowImageInteract.Checked);
			B1A9102B.method_4("ckbHideBrowser", ckbHideBrowser.Checked);
			B1A9102B.method_4("nudDelayOpenChromeFrom", FD9C2193.Value);
			B1A9102B.method_4("nudDelayOpenChromeTo", nudDelayOpenChromeTo.Value);
			B1A9102B.method_4("cbbTypeLogin", EE3D8093.SelectedIndex);
			B1A9102B.method_4("cbbFacebookWeb", cbbFacebookWeb.SelectedIndex);
			B1A9102B.method_4("cbbChangeIP", cbbChangeIP.SelectedIndex);
			int num = 0;
			if (rbChayBangCookie.Checked)
			{
				num = 1;
			}
			else if (rbChayBangChrome.Checked)
			{
				num = 2;
			}
			B1A9102B.method_4("typeRunBy", num);
			B1A9102B.method_4("cbbTypeGetToken", EF1D13BA.SelectedIndex);
			B1A9102B.method_4("cbbGetTokenBy", cbbGetTokenBy.SelectedValue);
			B1A9102B.method_6();
			FA15011F();
		}
		catch (Exception)
		{
		}
	}

	private void A4889F90(object sender, EventArgs e)
	{
		A6A691B6();
		Close();
	}

	private void BF851712_Click(object sender, EventArgs e)
	{
		this.A294D626();
	}

	private void EB169C8B(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	public void CC348FB5(object sender, EventArgs e)
	{
		string text = "";
		if (cbbThuMuc.SelectedValue != null)
		{
			text = cbbThuMuc.SelectedValue.ToString();
		}
		AC37B195();
		if (text != "999999" && text != "-2")
		{
			FD8F4B3F = -1;
			cbbThuMuc.SelectedValue = text;
			return;
		}
		bool_0 = false;
		cbbThuMuc.SelectedValue = text;
		bool_0 = true;
		E78EEE83(fChonThuMuc.list_0);
	}

	private List<string> EB221108()
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

	private void method_4(List<string> list_3 = null, string string_1 = "")
	{
		try
		{
			EB3CF7AF.Rows.Clear();
			if (string_1 == "[Tất cả tình trạng]" || string_1 == F7AB102E.smethod_0("[Tất cả tình trạng]"))
			{
				string_1 = "";
			}
			DataTable dataTable_ = Class15.E2B3A014(list_3, string_1);
			method_5(dataTable_);
		}
		catch (Exception)
		{
		}
	}

	private void method_5(DataTable dataTable_0)
	{
		GClass27.CB1F923E(EB3CF7AF, dataTable_0);
		E6042218(0);
		A517E201();
		E280B5BE();
	}

	private void button9_Click(object sender, EventArgs e)
	{
		try
		{
			string text = "";
			if (cbbThuMuc.SelectedValue != null)
			{
				text = cbbThuMuc.SelectedValue.ToString();
			}
			CDB179A2 cDB179A = new CDB179A2(text);
			GClass8.smethod_33(cDB179A);
			if (cDB179A.bool_0 || cDB179A.bool_1)
			{
				AC37B195();
				FD8F4B3F = -1;
				if (cDB179A.bool_0)
				{
					cbbThuMuc.SelectedValue = cDB179A.int_0;
				}
				else
				{
					cbbThuMuc.SelectedValue = text;
				}
			}
		}
		catch
		{
		}
	}

	private void method_6(string string_1)
	{
		switch (string_1)
		{
		case "ToggleCheck":
		{
			for (int k = 0; k < EB3CF7AF.SelectedRows.Count; k++)
			{
				int index = EB3CF7AF.SelectedRows[k].Index;
				method_58(index, "cChose", !Convert.ToBoolean(method_60(index, "cChose")));
			}
			E6042218();
			break;
		}
		case "SelectHighline":
		{
			DataGridViewSelectedRowCollection selectedRows = EB3CF7AF.SelectedRows;
			for (int j = 0; j < selectedRows.Count; j++)
			{
				method_58(selectedRows[j].Index, "cChose", true);
			}
			E6042218();
			break;
		}
		case "UnAll":
		{
			for (int l = 0; l < EB3CF7AF.RowCount; l++)
			{
				method_58(l, "cChose", false);
			}
			E6042218(0);
			break;
		}
		case "All":
		{
			for (int i = 0; i < EB3CF7AF.RowCount; i++)
			{
				method_58(i, "cChose", true);
			}
			E6042218(EB3CF7AF.RowCount);
			break;
		}
		}
	}

	private void method_7(string string_1)
	{
		if (method_54())
		{
			try
			{
				List<string> values = method_8(string_1);
				GClass8.smethod_27(string.Join("\r\n", values));
			}
			catch
			{
			}
		}
	}

	private List<string> method_8(string string_1)
	{
		List<string> list = new List<string>();
		try
		{
			List<string> list2 = string_1.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
			for (int i = 0; i < EB3CF7AF.RowCount; i++)
			{
				if (!Convert.ToBoolean(EB3CF7AF.Rows[i].Cells["cChose"].Value))
				{
					continue;
				}
				List<string> list3 = new List<string>();
				for (int j = 0; j < list2.Count; j++)
				{
					string text = method_60(i, list2[j]);
					if (list2[j] == "cProxy" && text.Length > 2)
					{
						if (text[text.Length - 2].ToString() == "*")
						{
							text = text.Substring(0, text.Length - 2);
						}
					}
					else if (list2[j] == "cMa2Fa")
					{
						text = GClass8.smethod_66(method_60(i, "cFa2"));
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

	private void F1AE779A(string CE2D5024)
	{
		try
		{
			List<string> values = method_9(CE2D5024);
			GClass8.smethod_27(string.Join("\r\n", values));
		}
		catch
		{
		}
	}

	private List<string> method_9(string string_1)
	{
		List<string> list = new List<string>();
		try
		{
			List<string> list2 = string_1.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
			List<DataGridViewRow> list3 = (from DataGridViewRow dataGridViewRow_0 in EB3CF7AF.SelectedRows
				orderby dataGridViewRow_0.Index
				select dataGridViewRow_0).ToList();
			for (int i = 0; i < list3.Count; i++)
			{
				int index = list3[i].Index;
				List<string> list4 = new List<string>();
				for (int j = 0; j < list2.Count; j++)
				{
					string text = method_60(index, list2[j]);
					if (list2[j] == "cProxy" && text.Length > 2)
					{
						if (text[text.Length - 2].ToString() == "*")
						{
							text = text.Substring(0, text.Length - 2);
						}
					}
					else if (list2[j] == "cMa2Fa")
					{
						text = GClass8.smethod_66(method_60(index, "cFa2"));
					}
					list4.Add(text);
				}
				list.Add(string.Join("|", list4));
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	private void B789AA08_Click(object sender, EventArgs e)
	{
		method_6("All");
	}

	private void E10A271D_Click(object sender, EventArgs e)
	{
		method_6("SelectHighline");
	}

	private void AD85CC0E_Click(object sender, EventArgs e)
	{
		method_6("UnAll");
	}

	private void A824BF38_Click(object sender, EventArgs e)
	{
		method_7("cToken");
	}

	private void cookieToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_7("cCookies");
	}

	private void FA348D03(object sender, EventArgs e)
	{
		method_7("cUid");
	}

	private void passToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_7("cPassword");
	}

	private void uidPassToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_7("cUid|cPassword");
	}

	private void EC2039A7(object sender, EventArgs e)
	{
		method_7("cUid|cPassword|cToken|cCookies");
	}

	private void FEAB929D_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fAddFile());
		if (fAddFile.C13CD985)
		{
			AC37B195();
			cbbThuMuc.SelectedIndex = cbbThuMuc.Items.Count - 2;
		}
	}

	private void ctmsAcc_Opening(object sender, CancelEventArgs e)
	{
		toolStripMenuItem_2.DropDownItems.Clear();
		DataTable dataTable = Class15.E888F681();
		int num = 0;
		for (int i = 0; i < dataTable.Rows.Count; i++)
		{
			DataRow dataRow = dataTable.Rows[i];
			string text = "";
			if (dataRow["id"].ToString() != text)
			{
				toolStripMenuItem_2.DropDownItems.Add(dataRow["Ten"].ToString());
				toolStripMenuItem_2.DropDownItems[i - num].Tag = dataRow["id"];
				toolStripMenuItem_2.DropDownItems[i - num].Click += method_11;
			}
			else
			{
				num++;
			}
		}
		E784828B.DropDownItems.Clear();
		List<string> list_0 = new List<string>();
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				string text3 = "";
				string text4 = "";
				for (int m = 0; m < EB3CF7AF.RowCount; m++)
				{
					text3 = method_60(m, "cStatus").Trim();
					if (text3 != "")
					{
						text4 = Regex.Match(text3, "\\(IP: (.*?)\\)", RegexOptions.Singleline).Value;
						if (text4 != "")
						{
							text3 = text3.Replace(text4, "").Trim();
						}
						text4 = Regex.Match(text3, "\\[(.*?)\\]").Value;
						if (text4 != "")
						{
							text3 = text3.Replace(text4, "").Trim();
						}
						if (text3 != "" && !list_0.Contains(text3))
						{
							list_0.Add(text3);
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
		for (int j = 0; j < list_0.Count; j++)
		{
			E784828B.DropDownItems.Add(list_0[j]);
			E784828B.DropDownItems[j].Click += method_10;
		}
		tinhTrangToolStripMenuItem.DropDownItems.Clear();
		list_0 = new List<string>();
		thread = new Thread((ThreadStart)delegate
		{
			try
			{
				string text2 = "";
				for (int l = 0; l < EB3CF7AF.RowCount; l++)
				{
					text2 = method_60(l, "cInfo");
					if (!text2.Equals("") && !list_0.Contains(text2))
					{
						list_0.Add(text2);
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
		for (int k = 0; k < list_0.Count; k++)
		{
			tinhTrangToolStripMenuItem.DropDownItems.Add(list_0[k]);
			tinhTrangToolStripMenuItem.DropDownItems[k].Click += E481440F;
		}
		BF379492.DropDownItems.Clear();
		bool_1 = true;
	}

	private void E481440F(object sender, EventArgs e)
	{
		EE142AB8("cInfo", (sender as ToolStripMenuItem).Text);
	}

	private void method_10(object sender, EventArgs e)
	{
		EE142AB8("cStatus", (sender as ToolStripMenuItem).Text);
	}

	private void EE142AB8(string CD9E571E, string BE2F6615)
	{
		for (int i = 0; i < EB3CF7AF.RowCount; i++)
		{
			EB3CF7AF.Rows[i].Cells["cChose"].Value = method_60(i, CD9E571E).Contains(BE2F6615);
		}
		E6042218();
	}

	private void method_11(object sender, EventArgs e)
	{
		if (method_54())
		{
			ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
			if (GClass29.smethod_1(string.Format(F7AB102E.smethod_0("Bạn có thực sự muốn chuyển {0} tài khoản sang thư mục [{1}]?"), lblCountSelect.Text, toolStripMenuItem.Text)) == DialogResult.Yes)
			{
				method_12(toolStripMenuItem.Tag.ToString());
			}
		}
	}

	private void method_12(string string_1)
	{
		try
		{
			List<string> list = new List<string>();
			for (int i = 0; i < EB3CF7AF.RowCount; i++)
			{
				if (Convert.ToBoolean(EB3CF7AF.Rows[i].Cells["cChose"].Value))
				{
					list.Add(EB3CF7AF.Rows[i].Cells["cId"].Value.ToString());
				}
			}
			if (Class15.DB0FC1AC(list, "idfile", string_1))
			{
				for (int j = 0; j < EB3CF7AF.RowCount; j++)
				{
					if (Convert.ToBoolean(EB3CF7AF.Rows[j].Cells["cChose"].Value))
					{
						EB3CF7AF.Rows.RemoveAt(j--);
					}
				}
				A517E201();
				CA0EAB0F();
				E6042218(0);
				E280B5BE();
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

	private void D5AE0395(bool CCA02B07)
	{
		List<string> list = new List<string>();
		for (int i = 0; i < EB3CF7AF.RowCount; i++)
		{
			if (Convert.ToBoolean(EB3CF7AF.Rows[i].Cells["cChose"].Value))
			{
				list.Add(EB3CF7AF.Rows[i].Cells["cId"].Value.ToString());
			}
		}
		if (list.Count == 0)
		{
			GClass29.smethod_0("Vui lòng chọn tài khoản cần xóa!");
		}
		else
		{
			if (GClass29.smethod_1(string.Format(F7AB102E.smethod_0("Bạn có muốn xóa {0} tài khoản đã chọn?"), AB0B20AA()) + "\r\n\r\n" + F7AB102E.smethod_0("(Ta\u0300i khoa\u0309n sau khi xo\u0301a se\u0303 đươ\u0323c lưu ta\u0323i mu\u0323c [Ta\u0300i khoa\u0309n đa\u0303 xo\u0301a])")) != DialogResult.Yes)
			{
				return;
			}
			if (CCA02B07)
			{
				int int_ = 0;
				int num = 0;
				while (num < EB3CF7AF.Rows.Count)
				{
					if (Convert.ToBoolean(EB3CF7AF.Rows[num].Cells["cChose"].Value))
					{
						if (int_ < 10)
						{
							Interlocked.Increment(ref int_);
							int int_0 = num++;
							Thread thread = new Thread((ThreadStart)delegate
							{
								A1BF1713(int_0, F7AB102E.smethod_0("Đang xo\u0301a profile..."));
								CE90948F(int_0);
								Interlocked.Decrement(ref int_);
							});
							thread.IsBackground = true;
							thread.Start();
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
				while (int_ > 0)
				{
					GClass8.smethod_53(1.0);
				}
			}
			if (Class15.A7BEDD3C(list))
			{
				for (int j = 0; j < EB3CF7AF.RowCount; j++)
				{
					if (Convert.ToBoolean(EB3CF7AF.Rows[j].Cells["cChose"].Value))
					{
						EB3CF7AF.Rows.RemoveAt(j--);
					}
				}
				CA0EAB0F();
				E280B5BE();
				E6042218(0);
			}
			else
			{
				GClass29.smethod_0("Xóa thất bại, vui lòng thử lại sau!", 2);
			}
		}
	}

	private Dictionary<string, List<string>> BA226595(string D895063E, string string_1, string string_2 = "txtUid")
	{
		Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
		try
		{
			List<string> list = Class147.smethod_15(D895063E, string_1);
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					string text = list[i];
					GClass11 gClass = new GClass11(Class147.smethod_16(text), bool_0: true);
					List<string> list2 = new List<string>();
					list2 = ((!new List<string> { "txtUid", "lstNhomTuNhap", "txtLinkChiaSe", "txtIdPost", "txtLink" }.Contains(string_2)) ? gClass.C5A69DA0(string_2, gClass.method_2("typeNganCach")) : gClass.C5A69DA0(string_2));
					dictionary.Add(text, list2);
				}
			}
		}
		catch
		{
		}
		return dictionary;
	}

	private void method_13(Dictionary<string, List<string>> dictionary_29, string string_1 = "txtUid")
	{
		if (dictionary_29.Count <= 0)
		{
			return;
		}
		foreach (KeyValuePair<string, List<string>> item in dictionary_29)
		{
			string key = item.Key;
			List<string> value = item.Value;
			GClass11 gClass = new GClass11(Class147.smethod_16(key), bool_0: true);
			gClass.method_5(string_1, value);
			Class147.smethod_13(key, "", gClass.method_7());
		}
	}

	private void method_14(Dictionary<string, List<string>> dictionary_29, bool bool_2, string string_1 = "txtUid")
	{
		if (dictionary_29.Count <= 0)
		{
			return;
		}
		foreach (KeyValuePair<string, List<string>> item in dictionary_29)
		{
			string key = item.Key;
			List<string> value = item.Value;
			GClass11 gClass = new GClass11(Class147.smethod_16(key), bool_0: true);
			if (bool_2 && gClass.method_3("ckbAutoDeleteComment"))
			{
				gClass.method_5(string_1, value);
				Class147.smethod_13(key, "", gClass.method_7());
			}
		}
	}

	private Dictionary<string, Dictionary<string, List<string>>> method_15(string AE8F372D, string E53B1EB2, string string_1 = "txtUid")
	{
		Dictionary<string, Dictionary<string, List<string>>> dictionary = new Dictionary<string, Dictionary<string, List<string>>>();
		try
		{
			List<string> list = Class147.smethod_15(AE8F372D, E53B1EB2);
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					string text = list[i];
					GClass11 gClass = new GClass11(Class147.smethod_16(text), bool_0: true);
					List<string> list2 = new List<string>();
					list2 = ((!new List<string> { "txtUid", "lstNhomTuNhap", "txtLinkChiaSe", "txtIdPost", "txtLink" }.Contains(string_1)) ? gClass.C5A69DA0(string_1, gClass.method_2("typeNganCach")) : gClass.C5A69DA0(string_1));
					Dictionary<string, List<string>> dictionary2 = new Dictionary<string, List<string>>();
					for (int j = 0; j < list2.Count; j++)
					{
						if (list2[j].Contains("_"))
						{
							string key = list2[j].Split('_')[0];
							if (!dictionary2.ContainsKey(key))
							{
								dictionary2.Add(key, new List<string>());
							}
							dictionary2[key].Add(list2[j]);
						}
					}
					dictionary.Add(text, dictionary2);
				}
			}
		}
		catch
		{
		}
		return dictionary;
	}

	private void EE9F1135(Dictionary<string, Dictionary<string, List<string>>> dictionary_29, string string_1 = "txtUid")
	{
		if (dictionary_29.Count <= 0)
		{
			return;
		}
		foreach (KeyValuePair<string, Dictionary<string, List<string>>> item in dictionary_29)
		{
			string key = item.Key;
			Dictionary<string, List<string>> value = item.Value;
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, List<string>> item2 in value)
			{
				list.AddRange(item2.Value);
			}
			GClass11 gClass = new GClass11(Class147.smethod_16(key), bool_0: true);
			gClass.method_5(string_1, list);
			Class147.smethod_13(key, "", gClass.method_7());
		}
	}

	private bool B38E643A(string string_1, string string_2)
	{
		try
		{
			string text = string_1.Split(':')[1];
			string text2 = string_2.Split(':')[1];
			if (text.Substring(1) == text2.Substring(1))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private void method_16()
	{
		B928E63C = new Dictionary<string, List<string>>();
		try
		{
			string text = GClass25.smethod_0("configGeneral").C0288288("pathResult", "output\\resultSpam");
			if (text == "output\\resultSpam")
			{
				GClass8.smethod_32("output");
				GClass8.smethod_32("output\\resultSpam");
			}
		}
		catch
		{
		}
	}

	private bool B3345E8F(string B2169C37)
	{
		foreach (KeyValuePair<string, List<string>> item in B928E63C)
		{
			if (item.Value.Contains(B2169C37))
			{
				return true;
			}
		}
		return false;
	}

	private void D4327FBE(GClass11 DDBCAD0E = null)
	{
		try
		{
			if (!method_54())
			{
				return;
			}
			int int_0 = GClass25.smethod_0("configGeneral").method_2("nudInteractThread", 3);
			if (DDBCAD0E.method_3("OpenBrowser"))
			{
				int_0 = AB0B20AA();
			}
			F8B76B18 = B522ADA4(ref int_0);
			if (F8B76B18 != null && F8B76B18.Count == 0)
			{
				GClass29.smethod_0("Proxy không đủ, vui lòng cấu hình lại!", 2);
				return;
			}
			List<int> list_0 = new List<int>();
			for (int i = 0; i < int_0; i++)
			{
				list_0.Add(0);
			}
			method_34("start");
			dictionary_27 = new Dictionary<string, List<string>>();
			A2AD659F = true;
			Class57.A39EDD1D(bool_9: false);
			int int_1 = 0;
			bool bool_0 = false;
			int_2 = 0;
			A235CA9E = new List<Thread>();
			string CD3CE331;
			Thread thread = new Thread((ThreadStart)delegate
			{
				try
				{
					if (DDBCAD0E.method_3("Interact"))
					{
						List<string> list = new List<string>();
						CD3CE331 = "";
						string text = "";
						int num = GClass25.smethod_0("configInteractGeneral").method_2("nudSoLuotChay", 1);
						if (num == 0)
						{
							num = 1;
						}
						for (int j = 0; j < num; j++)
						{
							list = new List<string>();
							if (GClass25.smethod_0("configInteractGeneral").method_3("ckbRepeatAll"))
							{
								text = ((num > 1) ? string.Format(F7AB102E.smethod_0("Lượt {0}/{1}. "), j + 1, num) : "");
								if (GClass25.smethod_0("configInteractGeneral").method_3("RepeatAllVIP"))
								{
									list = GClass25.smethod_0("configInteractGeneral").C5A69DA0("lstIdKichBan");
									if (GClass25.smethod_0("configInteractGeneral").method_3("ckbRandomKichBan"))
									{
										list = GClass8.smethod_35(list);
										list = GClass8.smethod_35(list);
										list = GClass8.smethod_35(list);
									}
								}
								else
								{
									list.Add(GClass25.smethod_0("configInteractGeneral").C0288288("cbbKichBan"));
								}
							}
							else
							{
								list.Add(GClass25.smethod_0("configInteractGeneral").C0288288("cbbKichBan"));
							}
							for (int k = 0; k < list.Count; k++)
							{
								if (GClass25.smethod_0("configInteractGeneral").method_3("ckbXoaCache"))
								{
									int CC2C6927 = 0;
									int int_2 = GClass25.smethod_0("configGeneral").method_2("nudHideThread", 10);
									Thread thread2 = new Thread((ThreadStart)delegate
									{
										int num25 = 0;
										while (num25 < EB3CF7AF.Rows.Count)
										{
											if (Convert.ToBoolean(EB3CF7AF.Rows[num25].Cells["cChose"].Value))
											{
												if (CC2C6927 < int_2)
												{
													Interlocked.Increment(ref CC2C6927);
													int E0856D6 = num25++;
													Thread thread9 = new Thread((ThreadStart)delegate
													{
														A1BF1713(E0856D6, F7AB102E.smethod_0("Đang xo\u0301a Cache Profile..."));
														F1A2A699(E0856D6);
														Interlocked.Decrement(ref CC2C6927);
													});
													thread9.IsBackground = true;
													thread9.Start();
												}
												else
												{
													Application.DoEvents();
													Thread.Sleep(200);
												}
											}
											else
											{
												num25++;
											}
										}
									});
									thread2.IsBackground = true;
									thread2.Start();
								}
								if (Class57.smethod_5())
								{
									break;
								}
								CD3CE331 = list[k];
								if (text != "")
								{
									method_32(text + string.Format(F7AB102E.smethod_0("Kịch bản") + ": {0}...", Class147.E1199583(CD3CE331)));
								}
								if (GClass25.smethod_0("configInteractGeneral").method_3("ckbRandomThuTuTaiKhoan"))
								{
									EB3CF7AF.Invoke((MethodInvoker)delegate
									{
										E3942017();
									});
								}
								dictionary_0 = BA226595(CD3CE331, "HDThamGiaNhomUid");
								dictionary_1 = BA226595(CD3CE331, "HDThamGiaNhomUidv2");
								dictionary_23 = BA226595(CD3CE331, "HDKetBanVoiBanBeCuaUid");
								dictionary_2 = BA226595(CD3CE331, "HDKetBanTepUid");
								dictionary_3 = BA226595(CD3CE331, "HDKetBanTepUidv2");
								dictionary_4 = BA226595(CD3CE331, "HDBaiVietProfile");
								dictionary_5 = BA226595(CD3CE331, "HDSpamBaiViet");
								dictionary_6 = BA226595(CD3CE331, "HDSpamBaiVietv2");
								A3B286B4 = BA226595(CD3CE331, "HDSpamBaiViet", "txtComment");
								dictionary_7 = BA226595(CD3CE331, "HDSpamBaiVietv2", "txtComment");
								dictionary_8 = BA226595(CD3CE331, "HDBuffTinNhanProfile");
								E2ACA8BF = BA226595(CD3CE331, "HDKetBanTepUidNew", "txtLink");
								B931FABE = BA226595(CD3CE331, "HDBuffLikeComment", "txtComment");
								D61C6110 = BA226595(CD3CE331, "HDBuffLikeComment", "txtComment");
								dictionary_9 = BA226595(CD3CE331, "HDDangStatus", "txtNoiDung");
								F725FAA3 = BA226595(CD3CE331, "HDDangStatus", "txtNoiDung");
								E6B1DEA5 = BA226595(CD3CE331, "HDDangStatusV2", "txtNoiDung");
								dictionary_10 = BA226595(CD3CE331, "HDDangStatusV2", "txtNoiDung");
								CD146FB9 = BA226595(CD3CE331, "HDPhanHoiBinhLuan");
								dictionary_11 = BA226595(CD3CE331, "HDBuffLikeComment", "txtIdPost");
								BE3A6DAD = BA226595(CD3CE331, "HDDangBaiTheoID", "txtIdPost");
								dictionary_12 = BA226595(CD3CE331, "HDBuffFollowLikePage");
								dictionary_13 = BA226595(CD3CE331, "HDShareBaiTut", "txtLinkChiaSe");
								A0840D3F = BA226595(CD3CE331, "HDLinkToInstagram", "txtBio");
								dictionary_14 = BA226595(CD3CE331, "HDLinkToInstagram", "txtBio");
								dictionary_15 = BA226595(CD3CE331, "HDReviewPage");
								dictionary_16 = BA226595(CD3CE331, "HDNhanTinBanBe", "txtTinNhan");
								dictionary_17 = BA226595(CD3CE331, "HDNhanTinBanBe", "txtTinNhan");
								dictionary_18 = BA226595(CD3CE331, "HDDangBai", "lstNhomTuNhap");
								dictionary_19 = BA226595(CD3CE331, "HDDangBai", "txtIdPost");
								dictionary_20 = BA226595(CD3CE331, "HDTuongTacLivestream", "txtComment");
								dictionary_21 = BA226595(CD3CE331, "HDDangBai", "txtNoiDung");
								dictionary_22 = new Dictionary<string, List<string>>();
								A5362C12 = BA226595(CD3CE331, "HDAddMail", "lstHotmail");
								A11D612D = new Dictionary<string, Dictionary<string, int>>();
								dictionary_26 = BA226595(CD3CE331, "HDPhanHoiBinhLuan", "txtComment");
								BAAAB69C = BA226595(CD3CE331, "HDDangReel", "txtNoiDung");
								FC17EB12 = BA226595(CD3CE331, "HDShareBai", "txtNoiDung");
								dictionary_24 = method_15(CD3CE331, "HDChaySpam", "txtIdPost");
								dictionary_25 = BA226595(CD3CE331, "HDChaySpam", "txtComment");
								method_16();
								if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 8 && GClass25.smethod_0("configGeneral").method_2("typeRunXproxy") == 1)
								{
									for (int l = 0; l < F8B76B18.Count; l++)
									{
										(F8B76B18[l] as Class9).method_0();
									}
								}
								if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 14)
								{
									for (int m = 0; m < this.list_0.Count; m++)
									{
										this.list_0[m].method_4();
									}
								}
								Thread thread3 = new Thread((ThreadStart)delegate
								{
									try
									{
										int num18 = 0;
										while (num18 < EB3CF7AF.Rows.Count && !Class57.smethod_5())
										{
											if (Convert.ToBoolean(EB3CF7AF.Rows[num18].Cells["cChose"].Value))
											{
												if (Class57.smethod_5())
												{
													break;
												}
												if (A235CA9E.Count < int_0)
												{
													if (Class57.smethod_5())
													{
														break;
													}
													int A209A0BB = num18++;
													Thread thread8 = new Thread((ThreadStart)delegate
													{
														int num24 = GClass8.smethod_58(ref list_0);
														try
														{
															method_18(A209A0BB, num24, CD3CE331, DDBCAD0E);
															GClass8.EA9695BD(ref list_0, num24);
															bool flag = false;
															if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbRepeatAll"))
															{
																flag = true;
															}
															else
															{
																string text2 = C5151C09(A209A0BB);
																if (text2 != "Live")
																{
																	flag = true;
																}
																if (!flag)
																{
																	string text3 = E01F1137(A209A0BB).ToLower();
																	flag = text3.Contains("checkpoint") || text3.Contains("invalid username or password") || text3.Contains("Proxy chưa ủy quyền!".ToLower()) || text3.Contains("fb block") || text3.Contains("Max Job Today".ToLower());
																}
															}
															if (flag)
															{
																method_58(A209A0BB, "cChose", false);
															}
														}
														catch (Exception ex5)
														{
															if (ex5.ToString().Contains("Thread was being aborted."))
															{
																GClass8.EA9695BD(ref list_0, num24);
																if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbRepeatAll"))
																{
																	method_58(A209A0BB, "cChose", false);
																}
															}
														}
													})
													{
														Name = A209A0BB.ToString()
													};
													A235CA9E.Add(thread8);
													GClass8.smethod_53(1.0);
													thread8.Start();
												}
												else
												{
													if (Class57.smethod_5())
													{
														break;
													}
													if ((GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 7 && GClass25.smethod_0("configGeneral").method_3("ckbWaitDoneAllTinsoft")) || (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 8 && GClass25.smethod_0("configGeneral").method_3("ckbWaitDoneAllXproxy")) || (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 10 && GClass25.smethod_0("configGeneral").method_3("ckbWaitDoneAllTMProxy")))
													{
														for (int num19 = 0; num19 < A235CA9E.Count; num19++)
														{
															A235CA9E[num19].Join();
															A235CA9E.RemoveAt(num19--);
														}
													}
													else if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") != 1 && GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") != 2)
													{
														for (int num20 = 0; num20 < A235CA9E.Count; num20++)
														{
															if (!A235CA9E[num20].IsAlive)
															{
																A235CA9E.RemoveAt(num20--);
															}
														}
													}
													else
													{
														for (int num21 = 0; num21 < A235CA9E.Count; num21++)
														{
															A235CA9E[num21].Join();
															A235CA9E.RemoveAt(num21--);
														}
														if (Class57.smethod_5())
														{
															break;
														}
														Interlocked.Increment(ref int_1);
														if (int_1 >= GClass25.smethod_0("configGeneral").method_2("ip_nudChangeIpCount", 1))
														{
															for (int num22 = 0; num22 < 3; num22++)
															{
																bool_0 = GClass8.DB05192A(GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp"), GClass25.smethod_0("configGeneral").method_2("typeDcom"), GClass25.smethod_0("configGeneral").C0288288("ip_txtProfileNameDcom"), GClass25.smethod_0("configGeneral").C0288288("txtUrlHilink"), GClass25.smethod_0("configGeneral").method_2("ip_cbbHostpot"), GClass25.smethod_0("configGeneral").C0288288("ip_txtNordVPN"));
																if (bool_0)
																{
																	break;
																}
															}
															if (!bool_0)
															{
																GClass29.smethod_0("Không thê\u0309 đô\u0309i ip!", 2);
																Class57.A39EDD1D(bool_9: true);
																return;
															}
															int_1 = 0;
														}
													}
												}
											}
											else
											{
												num18++;
											}
											if (Class57.smethod_5())
											{
												break;
											}
										}
										for (int num23 = 0; num23 < A235CA9E.Count; num23++)
										{
											A235CA9E[num23].Join();
										}
									}
									catch (ThreadAbortException ex4)
									{
										if (ex4.ToString().Contains("Thread was being aborted."))
										{
										}
									}
								});
								thread3.IsBackground = true;
								thread3.Start();
								if (GClass25.smethod_0("configInteractGeneral").method_3("ckbGioiHanThoiGianChayKichBan"))
								{
									int num2 = Class57.random_0.Next(GClass25.smethod_0("configInteractGeneral").method_2("nudThoiGianChayKichBanFrom"), GClass25.smethod_0("configInteractGeneral").method_2("nudThoiGianChayKichBanTo") + 1);
									if (!thread3.Join(num2 * 60000))
									{
										thread3.Abort();
										for (int n = 0; n < A235CA9E.Count; n++)
										{
											A235CA9E[n].Abort();
											while (A235CA9E[n].IsAlive)
											{
												Thread.Sleep(1000);
											}
										}
										while (thread3.IsAlive)
										{
											Thread.Sleep(1000);
										}
									}
								}
								else
								{
									thread3.Join();
								}
								method_13(dictionary_0);
								method_13(dictionary_1);
								method_13(dictionary_23);
								method_13(dictionary_2);
								method_13(dictionary_3);
								method_13(dictionary_4);
								method_13(dictionary_5);
								method_13(dictionary_6);
								method_14(B931FABE, bool_2: true, "txtComment");
								method_13(A3B286B4, "txtComment");
								method_13(dictionary_7, "txtComment");
								method_13(dictionary_8);
								method_13(E2ACA8BF, "txtLink");
								method_13(dictionary_11, "txtIdPost");
								method_13(BE3A6DAD, "txtIdPost");
								method_13(dictionary_12);
								method_13(dictionary_13, "txtLinkChiaSe");
								method_13(A0840D3F, "txtBio");
								method_13(dictionary_15);
								method_13(dictionary_18, "lstNhomTuNhap");
								method_13(dictionary_19, "txtIdPost");
								method_13(dictionary_20, "txtComment");
								method_13(dictionary_21, "txtNoiDung");
								method_13(A5362C12, "lstHotmail");
								method_13(dictionary_26, "txtComment");
								method_13(BAAAB69C, "txtNoiDung");
								method_13(FC17EB12, "txtNoiDung");
								EE9F1135(dictionary_24, "txtIdPost");
								method_14(dictionary_25, bool_2: true, "txtComment");
								if (Class57.smethod_5())
								{
									break;
								}
								if (k + 1 < list.Count)
								{
									int num3 = Class57.random_0.Next(GClass25.smethod_0("configInteractGeneral").method_2("nudDelayKichBanFrom"), GClass25.smethod_0("configInteractGeneral").method_2("nudDelayKichBanTo") + 1);
									int tickCount = Environment.TickCount;
									while ((Environment.TickCount - tickCount) / 1000 - num3 < 0)
									{
										method_32(text + string.Format(F7AB102E.smethod_0("Chạy kịch bản tiếp theo sau {time} giây...").Replace("{time}", (num3 - (Environment.TickCount - tickCount) / 1000).ToString())));
										GClass8.smethod_53(0.5);
										if (Class57.smethod_5())
										{
											break;
										}
									}
								}
							}
							if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbRepeatAll") || Class57.smethod_5())
							{
								break;
							}
							if (j + 1 < num)
							{
								int num4 = Class57.random_0.Next(GClass25.smethod_0("configInteractGeneral").method_2("nudDelayTurnFrom"), GClass25.smethod_0("configInteractGeneral").method_2("nudDelayTurnTo") + 1) * 60;
								int tickCount2 = Environment.TickCount;
								while ((Environment.TickCount - tickCount2) / 1000 - num4 < 0)
								{
									method_32(text + string.Format(F7AB102E.smethod_0("Chạy lượt tiếp theo sau {time} giây...").Replace("{time}", (num4 - (Environment.TickCount - tickCount2) / 1000).ToString())));
									GClass8.smethod_53(0.5);
									if (Class57.smethod_5())
									{
										break;
									}
								}
							}
							if (Class57.smethod_5())
							{
								break;
							}
						}
					}
					else if (DDBCAD0E.method_3("OpenBrowser"))
					{
						if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 8 && GClass25.smethod_0("configGeneral").method_2("typeRunXproxy") == 1)
						{
							for (int num5 = 0; num5 < F8B76B18.Count; num5++)
							{
								(F8B76B18[num5] as Class9).method_0();
							}
						}
						if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 14)
						{
							for (int num6 = 0; num6 < this.list_0.Count; num6++)
							{
								this.list_0[num6].method_4();
							}
						}
						Thread thread4 = new Thread((ThreadStart)delegate
						{
							try
							{
								int num16 = 0;
								while (num16 < EB3CF7AF.Rows.Count && !Class57.smethod_5())
								{
									if (Convert.ToBoolean(EB3CF7AF.Rows[num16].Cells["cChose"].Value))
									{
										if (Class57.smethod_5() || A235CA9E.Count >= int_0)
										{
											break;
										}
										if (Class57.smethod_5())
										{
											break;
										}
										int int_4 = num16++;
										Thread thread7 = new Thread((ThreadStart)delegate
										{
											int int_5 = GClass8.smethod_58(ref list_0);
											try
											{
												method_18(int_4, int_5, "", DDBCAD0E);
											}
											catch (Exception f4295AA3)
											{
												GClass8.BFBDF687(null, f4295AA3);
											}
										})
										{
											Name = int_4.ToString()
										};
										A235CA9E.Add(thread7);
										GClass8.smethod_53(1.0);
										thread7.Start();
									}
									else
									{
										num16++;
									}
								}
								for (int num17 = 0; num17 < A235CA9E.Count; num17++)
								{
									A235CA9E[num17].Join();
								}
							}
							catch (ThreadAbortException ex3)
							{
								if (ex3.ToString().Contains("Thread was being aborted."))
								{
								}
							}
						});
						thread4.IsBackground = true;
						thread4.Start();
						thread4.Join();
					}
					else
					{
						if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 8 && GClass25.smethod_0("configGeneral").method_2("typeRunXproxy") == 1)
						{
							for (int num7 = 0; num7 < F8B76B18.Count; num7++)
							{
								(F8B76B18[num7] as Class9).method_0();
							}
						}
						if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 14)
						{
							for (int num8 = 0; num8 < this.list_0.Count; num8++)
							{
								this.list_0[num8].method_4();
							}
						}
						Thread thread5 = new Thread((ThreadStart)delegate
						{
							try
							{
								int num9 = 0;
								while (num9 < EB3CF7AF.Rows.Count && !Class57.smethod_5())
								{
									if (Convert.ToBoolean(EB3CF7AF.Rows[num9].Cells["cChose"].Value))
									{
										if (Class57.smethod_5())
										{
											break;
										}
										if (A235CA9E.Count < int_0)
										{
											if (Class57.smethod_5())
											{
												break;
											}
											int int_3 = num9++;
											Thread thread6 = new Thread((ThreadStart)delegate
											{
												int num15 = GClass8.smethod_58(ref list_0);
												try
												{
													method_18(int_3, num15, "", DDBCAD0E);
													GClass8.EA9695BD(ref list_0, num15);
													if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbRepeatAll") || C5151C09(int_3) != "Live" || E01F1137(int_3).ToLower().Contains("checkpoint") || E01F1137(int_3).ToLower().Contains("invalid username or password") || E01F1137(int_3).ToLower().Contains("Proxy chưa ủy quyền!".ToLower()))
													{
														method_58(int_3, "cChose", false);
													}
												}
												catch (Exception ex2)
												{
													if (ex2.ToString().Contains("Thread was being aborted."))
													{
														GClass8.EA9695BD(ref list_0, num15);
														if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbRepeatAll"))
														{
															method_58(int_3, "cChose", false);
														}
													}
												}
											})
											{
												Name = int_3.ToString()
											};
											A235CA9E.Add(thread6);
											GClass8.smethod_53(1.0);
											thread6.Start();
										}
										else
										{
											if (Class57.smethod_5())
											{
												break;
											}
											if ((GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 7 && GClass25.smethod_0("configGeneral").method_3("ckbWaitDoneAllTinsoft")) || (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 8 && GClass25.smethod_0("configGeneral").method_3("ckbWaitDoneAllXproxy")) || (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 10 && GClass25.smethod_0("configGeneral").method_3("ckbWaitDoneAllTMProxy")))
											{
												for (int num10 = 0; num10 < A235CA9E.Count; num10++)
												{
													A235CA9E[num10].Join();
													A235CA9E.RemoveAt(num10--);
												}
											}
											else if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") != 1 && GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") != 2)
											{
												for (int num11 = 0; num11 < A235CA9E.Count; num11++)
												{
													if (!A235CA9E[num11].IsAlive)
													{
														A235CA9E.RemoveAt(num11--);
													}
												}
											}
											else
											{
												for (int num12 = 0; num12 < A235CA9E.Count; num12++)
												{
													A235CA9E[num12].Join();
													A235CA9E.RemoveAt(num12--);
												}
												if (Class57.smethod_5())
												{
													break;
												}
												Interlocked.Increment(ref int_1);
												if (int_1 >= GClass25.smethod_0("configGeneral").method_2("ip_nudChangeIpCount", 1))
												{
													for (int num13 = 0; num13 < 3; num13++)
													{
														bool_0 = GClass8.DB05192A(GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp"), GClass25.smethod_0("configGeneral").method_2("typeDcom"), GClass25.smethod_0("configGeneral").C0288288("ip_txtProfileNameDcom"), GClass25.smethod_0("configGeneral").C0288288("txtUrlHilink"), GClass25.smethod_0("configGeneral").method_2("ip_cbbHostpot"), GClass25.smethod_0("configGeneral").C0288288("ip_txtNordVPN"));
														if (bool_0)
														{
															break;
														}
													}
													if (!bool_0)
													{
														GClass29.smethod_0("Không thê\u0309 đô\u0309i ip!", 2);
														Class57.A39EDD1D(bool_9: true);
														return;
													}
													int_1 = 0;
												}
											}
										}
									}
									else
									{
										num9++;
									}
									if (Class57.smethod_5())
									{
										break;
									}
								}
								for (int num14 = 0; num14 < A235CA9E.Count; num14++)
								{
									A235CA9E[num14].Join();
								}
							}
							catch (ThreadAbortException ex)
							{
								if (ex.ToString().Contains("Thread was being aborted."))
								{
								}
							}
						});
						thread5.IsBackground = true;
						thread5.Start();
						thread5.Join();
					}
				}
				catch (Exception f4295AA2)
				{
					GClass8.BFBDF687(null, f4295AA2);
				}
				method_33();
				method_34("stop");
				A2AD659F = false;
			});
			thread.IsBackground = true;
			thread.Start();
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA);
			method_34("stop");
			A2AD659F = false;
		}
	}

	private bool F9A25F89(GClass3 gclass3_0)
	{
		return true;
	}

	private int method_17(int C3B79D2D, string string_1, GClass3 CF3B599D, List<string> E7ABE200, int F7055309, int int_4, int A4A3A8B1, int C6A45CAC, int int_5, int int_6, bool A3A54213, string CB0C3D84)
	{
		int result = 0;
		try
		{
			int num = Class57.random_0.Next(F7055309, int_4 + 1);
			for (int i = 0; i < num; i++)
			{
				A1BF1713(C3B79D2D, string_1 + F7AB102E.smethod_0("Đang") + $" {CB0C3D84} ({i}/{num})...");
				if (E7ABE200.Count == 0)
				{
					break;
				}
				string text = E7ABE200[Class57.random_0.Next(0, E7ABE200.Count)];
				E7ABE200.Remove(text);
				if (!CF3B599D.method_1())
				{
					CF3B599D.method_10(text);
					int num2 = Class57.random_0.Next(A4A3A8B1, C6A45CAC + 1);
					int num3 = Convert.ToInt32(CF3B599D.BEA5E4BB("var count=0; document.querySelectorAll('a').forEach(e=>{if(e.getAttribute('href')!=null && e.getAttribute('href')!='') count++}); return count+''").ToString());
					for (int j = 0; j < num2; j++)
					{
						if (num3 == 0)
						{
							break;
						}
						int num4 = Class57.random_0.Next(1, num3 + 1);
						CF3B599D.method_32("a|" + num4);
						CF3B599D.method_41(2, 3);
						CF3B599D.method_16("a|" + num4);
						CF3B599D.method_40(3.0);
						int num5 = Class57.random_0.Next(1, 3);
						for (int k = 0; k < num5; k++)
						{
							CF3B599D.method_7(Class57.random_0.Next(100, 300));
							CF3B599D.method_41(2, 3);
						}
						if (CF3B599D.method_9() != text)
						{
							CF3B599D.method_12();
							CF3B599D.method_41(2, 3);
						}
					}
					int num6 = Class57.random_0.Next(int_5, int_6 + 1);
					if (A3A54213)
					{
						int tickCount = Environment.TickCount;
						int num7 = 1;
						do
						{
							num7 = ((Class57.random_0.Next(1, 1000) % 6 != 0) ? 1 : (-1));
							CF3B599D.method_7(num7 * Class57.random_0.Next(100, 300));
							CF3B599D.method_41(2, 3);
						}
						while (Environment.TickCount - tickCount < num6 * 1000);
					}
					else
					{
						CF3B599D.method_40(num6);
					}
					continue;
				}
				return -2;
			}
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(CF3B599D, f4295AA, "HDSearchGoogle");
			result = -1;
		}
		return result;
	}

	private void method_18(int C58B4601, int int_4, string string_1, GClass11 C2B70190)
	{
		if (C2B70190 == null)
		{
			C2B70190 = new GClass11();
		}
		int num = 0;
		if (C2B70190.method_3("Interact") && GClass25.smethod_0("configInteractGeneral").method_3("ckbGioiHanThoiGianChayTaiKhoan"))
		{
			num = Class57.random_0.Next(GClass25.smethod_0("configInteractGeneral").method_2("nudThoiGianChayTaiKhoanFrom"), GClass25.smethod_0("configInteractGeneral").method_2("nudThoiGianChayTaiKhoanTo") + 1);
		}
		AABDF09D aABDF09D = new AABDF09D(Thread.CurrentThread, num);
		string string_2 = "";
		GClass3 gClass = null;
		int num2 = 0;
		string string_3 = "";
		int int_5 = 0;
		string string_4 = "";
		Class9 class9_ = null;
		D0AA71A1 d0AA71A1_ = null;
		GClass6 gclass6_ = null;
		A8322F29 A9A4CFA = null;
		bool flag = false;
		bool flag2 = false;
		string text = "";
		int num3 = 0;
		bool flag3 = false;
		string text2 = "";
		int num4 = 0;
		int num5 = 0;
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
		int num6 = -1;
		int num7 = -1;
		int num8 = -1;
		string text17 = "";
		string text18 = method_60(C58B4601, "cUid");
		string text19 = method_60(C58B4601, "cId");
		string text20 = method_60(C58B4601, "cEmail");
		string text21 = method_60(C58B4601, "cPassMail");
		string string_5 = method_60(C58B4601, "cOAuth2");
		string text22 = method_60(C58B4601, "cMailRecovery");
		string string_6 = method_60(C58B4601, "cPassMailRecovery");
		string cCBE39A = method_60(C58B4601, "cFa2");
		string string_7 = method_60(C58B4601, "cPassword");
		string text23 = method_60(C58B4601, "cCookies");
		string text24 = method_60(C58B4601, "cToken");
		string dEB56B = method_60(C58B4601, "cUseragent");
		if (C2B70190.method_3("Unlock956") && (C2B70190.method_2("TypeUnlock956") == 2 || C2B70190.method_2("TypeUnlock956") == 3))
		{
			dEB56B = "";
		}
		if (text18 == "")
		{
			text18 = Regex.Match(text23, "c_user=(\\d+)").Groups[1].Value;
		}
		try
		{
			if (GClass25.smethod_0("configInteractGeneral").method_3("ckbCheckLiveUid") && GClass8.smethod_42(text18) && Class14.EABAA59C(text18).StartsWith("0|") && C2B70190.method_3("Interact"))
			{
				A1BF1713(C58B4601, F7AB102E.smethod_0("Tài khoản Die!"));
				FD062316(C58B4601, "Die");
				num3 = 1;
			}
			else if (Class57.smethod_5())
			{
				A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Đã dừng!"));
				num3 = 1;
			}
			else
			{
				method_19(C58B4601, ref string_2, ref int_5, ref string_3, ref string_4, ref class9_, ref A9A4CFA, ref d0AA71A1_, ref gclass6_);
				if (Class57.smethod_5())
				{
					A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Đã dừng!"));
					num3 = 1;
				}
				else
				{
					if (!GClass25.smethod_0("configGeneral").method_3("ckbKhongCheckIP"))
					{
						if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 0 || GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 1 || GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 2 || GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 9)
						{
							if (string_2 != "")
							{
								string_3 = "(IP: " + string_2.Split(':')[0] + ") ";
							}
							A1BF1713(C58B4601, string_3 + "Check IP...");
							bool flag4 = false;
							int num9 = 0;
							while (num9 < 30)
							{
								GClass8.smethod_53(1.0);
								string_4 = GClass8.smethod_59(string_2, int_5);
								if (!(string_4 != ""))
								{
									if (!Class57.smethod_5())
									{
										num9++;
										continue;
									}
									goto IL_042b;
								}
								flag4 = true;
								break;
							}
							if (!flag4)
							{
								if (string_2 != "")
								{
									A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Không thể kết nối proxy!"));
								}
								else
								{
									A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Không có kết nối Internet!"));
								}
								num3 = 1;
								goto IL_1ec7;
							}
						}
						string_3 = "(IP: " + string_2 + "=>" + string_4 + ") ";
					}
					if (Class57.smethod_5())
					{
						A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Đã dừng!"));
						num3 = 1;
					}
					else
					{
						try
						{
							string text25 = "";
							if (!C2B70190.method_3("RecoverPass"))
							{
								goto IL_06d6;
							}
							A1BF1713(C58B4601, string_3 + "Check Email|Passmail...");
							A1BF1713(C58B4601, string_3 + "Gư\u0309i yêu câ\u0300u khôi phục mật khẩu...");
							num2 = method_21(text20, string_2, int_5);
							switch (num2)
							{
							case 0:
								A1BF1713(C58B4601, string_3 + "Mail chưa đăng ky\u0301 Fb!");
								break;
							case 1:
								A1BF1713(C58B4601, string_3 + "Gư\u0309i yêu câ\u0300u tha\u0300nh công!");
								break;
							case 2:
								A1BF1713(C58B4601, string_3 + "Lô\u0303i gửi yêu cầu!");
								break;
							case 3:
								A1BF1713(C58B4601, string_3 + "Gư\u0309i yêu câ\u0300u thâ\u0301t ba\u0323i!");
								break;
							case 4:
								A1BF1713(C58B4601, string_3 + "Chặn tính năng!");
								break;
							}
							if (num2 == 1)
							{
								int num10 = 0;
								while (true)
								{
									if (num10 >= 2)
									{
										goto IL_0669;
									}
									A1BF1713(C58B4601, string_3 + "Get otp...");
									text25 = method_28(2, text20, text21, 60, text18, "");
									if (!(text25 == "fail"))
									{
										if (!text25.StartsWith("https") && num10 != 1)
										{
											A1BF1713(C58B4601, string_3 + "Gư\u0309i yêu câ\u0300u khôi phục mật khẩu (2)...");
											method_21(text20, string_2, int_5);
											num10++;
											continue;
										}
										goto IL_0669;
									}
									A1BF1713(C58B4601, string_3 + "Không lấy được otp!");
									num3 = 1;
									goto end_IL_04f6;
									IL_0669:
									if (!(text25 == "") && text25.StartsWith("https"))
									{
										A1BF1713(C58B4601, string_3 + "Get otp thành công!");
										break;
									}
									A1BF1713(C58B4601, string_3 + "Không lấy được otp!");
									num3 = 1;
									goto end_IL_04f6;
								}
								goto IL_06d6;
							}
							num3 = 1;
							goto end_IL_04f6;
							IL_06d6:
							A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Chờ đến lượt..."));
							lock (object_7)
							{
								if (int_2 > 0)
								{
									int num11 = Class57.random_0.Next(GClass25.smethod_0("configGeneral").method_2("nudDelayOpenChromeFrom", 1), GClass25.smethod_0("configGeneral").method_2("nudDelayOpenChromeTo", 1) + 1);
									if (num11 > 0)
									{
										int tickCount = Environment.TickCount;
										while ((Environment.TickCount - tickCount) / 1000 - num11 < 0)
										{
											A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Mở tri\u0300nh duyê\u0323t sau") + " {time}s...".Replace("{time}", (num11 - (Environment.TickCount - tickCount) / 1000).ToString()));
											GClass8.smethod_53(0.5);
											if (!Class57.smethod_5())
											{
												continue;
											}
											A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Đã dừng!"));
											num3 = 1;
											goto IL_1ec7;
										}
									}
								}
								else
								{
									int_2++;
								}
							}
							A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Đang mơ\u0309 tri\u0300nh duyê\u0323t..."));
							string text26 = "data:,";
							Point b0B3B9A;
							Point d780F8B;
							if (C2B70190.method_3("OpenBrowser"))
							{
								text26 = "";
								if (GClass25.smethod_0("configOpenBrowser").method_3("ckbAddChromeIntoForm"))
								{
									b0B3B9A = new Point(-1000, 0);
									d780F8B = new Point(GClass25.smethod_0("configOpenBrowser").method_2("nudWidthChrome") + 16, GClass25.smethod_0("configOpenBrowser").method_2("nudHeighChrome"));
								}
								else
								{
									b0B3B9A = GClass8.smethod_57(int_4, GClass25.smethod_0("configOpenBrowser").method_2("cbbColumnChrome", 3), GClass25.smethod_0("configOpenBrowser").method_2("cbbRowChrome", 2));
									d780F8B = GClass8.smethod_56(GClass25.smethod_0("configOpenBrowser").method_2("cbbColumnChrome", 3), GClass25.smethod_0("configOpenBrowser").method_2("cbbRowChrome", 2));
								}
							}
							else if (GClass25.smethod_0("configGeneral").method_3("ckbAddChromeIntoForm"))
							{
								if (text26 == "")
								{
									b0B3B9A = new Point(-1000, 0);
									d780F8B = new Point(GClass25.smethod_0("configGeneral").method_2("nudWidthChrome") + 16, GClass25.smethod_0("configGeneral").method_2("nudHeighChrome") + 132);
								}
								else
								{
									b0B3B9A = new Point(-1000, 0);
									d780F8B = new Point(GClass25.smethod_0("configGeneral").method_2("nudWidthChrome") + 33, GClass25.smethod_0("configGeneral").method_2("nudHeighChrome") + 39);
								}
							}
							else
							{
								b0B3B9A = GClass8.smethod_57(int_4, GClass25.smethod_0("configGeneral").method_2("cbbColumnChrome", 3), GClass25.smethod_0("configGeneral").method_2("cbbRowChrome", 2));
								d780F8B = GClass8.smethod_56(GClass25.smethod_0("configGeneral").method_2("cbbColumnChrome", 3), GClass25.smethod_0("configGeneral").method_2("cbbRowChrome", 2));
							}
							string text27 = GClass25.smethod_2();
							string text28 = "";
							if (text27 != "" && text18 != "")
							{
								text28 = text27 + "\\" + text18;
							}
							if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbCreateProfile"))
							{
								text28 = "";
							}
							if (C2B70190.method_3("OpenBrowser") && !GClass25.smethod_0("configOpenBrowser").method_3("isUseProfile"))
							{
								text28 = "";
							}
							gClass = new GClass3
							{
								int_0 = C58B4601,
								Boolean_2 = !GClass25.smethod_0("configGeneral").method_3("ckbShowImageInteract"),
								DEB56B05 = dEB56B,
								String_0 = text28,
								D780F8B7 = d780F8B,
								B0B3B9A3 = b0B3B9A,
								String_8 = string_2,
								Int32_1 = int_5,
								Boolean_3 = true,
								String_9 = text26
							};
							gClass.D491453C = C58B4601;
							gClass.String_1 = text19;
							gClass.String_2 = text18;
							gClass.String_3 = string_7;
							gClass.CCBE39A8 = cCBE39A;
							gClass.String_4 = text23;
							gClass.String_5 = text24;
							gClass.D32E1816 = text20;
							gClass.String_6 = text21;
							gClass.String_7 = string_5;
							if (C2B70190.method_3("Unlock956"))
							{
								gClass.F89E3721 = true;
							}
							if (Class57.smethod_5())
							{
								A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Đã dừng!"));
								num3 = 1;
							}
							else
							{
								int num12 = 0;
								while (true)
								{
									var (flag5, text29) = gClass.method_0();
									string text32;
									bool flag7;
									if (flag5)
									{
										if (!GClass25.smethod_0("configGeneral").method_3("ckbKhongCheckIP") && !gClass.CE97BD33())
										{
											gClass.B7841719();
											num12++;
											if (num12 >= 3)
											{
												A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Lỗi kết nối proxy!"));
												num3 = 1;
												break;
											}
											continue;
										}
										method_65(gClass);
										if (C2B70190.method_3("OpenBrowser"))
										{
											if (GClass25.smethod_0("configOpenBrowser").method_3("ckbAddChromeIntoForm"))
											{
												fViewChrome.fViewChrome_0.method_1(gClass.int_0, gClass.D780F8B7.X, gClass.D780F8B7.Y - 10);
												fViewChrome.fViewChrome_0.method_0(gClass.EC234D1D.MainWindowHandle, gClass.int_0, gClass.D780F8B7.X + 17, gClass.D780F8B7.Y, -10, 0);
											}
										}
										else if (GClass25.smethod_0("configGeneral").method_3("ckbAddChromeIntoForm"))
										{
											if (text26 != "")
											{
												fViewChrome.fViewChrome_0.method_1(gClass.int_0, gClass.D780F8B7.X - 33, gClass.D780F8B7.Y - 39);
												fViewChrome.fViewChrome_0.method_0(gClass.EC234D1D.MainWindowHandle, gClass.int_0, gClass.D780F8B7.X, gClass.D780F8B7.Y);
											}
											else
											{
												fViewChrome.fViewChrome_0.method_1(gClass.int_0, gClass.D780F8B7.X - 16, gClass.D780F8B7.Y - 132);
												fViewChrome.fViewChrome_0.method_0(gClass.EC234D1D.MainWindowHandle, gClass.int_0, gClass.D780F8B7.X + 17, gClass.D780F8B7.Y, -10, -125);
											}
										}
										if (C2B70190.method_3("RecoverPass"))
										{
											int num13 = 0;
											int num14 = 3;
											while (true)
											{
												IL_0f18:
												gClass.method_10(text25);
												gClass.method_63();
												bool flag6 = false;
												int num15 = 0;
												while (true)
												{
													if (num15 < 60)
													{
														if (!gClass.CD003D3F("[name=\"password_new\"]"))
														{
															if (!gClass.CD003D3F("[href*=\"/login/identify/?ctx=recover\"]"))
															{
																if (!gClass.method_127())
																{
																	gClass.method_40(1.0);
																	num15++;
																	continue;
																}
																A1BF1713(C58B4601, "Checkpoint!");
																FD062316(C58B4601, "Checkpoint");
																num3 = 1;
																break;
															}
															if (gClass.CD003D3F("[href*=\"/help/177066345680802\"]"))
															{
																A1BF1713(C58B4601, string_3 + "Fb Block!");
																num3 = 1;
																break;
															}
															num13++;
															if (num13 >= num14)
															{
																A1BF1713(C58B4601, string_3 + "Không lấy được otp!");
																num3 = 1;
																break;
															}
															A1BF1713(C58B4601, string_3 + "Get otp...");
															text25 = method_28(2, text20, text21, 60, text18, text25);
															if (text25.StartsWith("https"))
															{
																goto IL_0f18;
															}
														}
														else
														{
															flag6 = true;
														}
													}
													if (flag6)
													{
														flag6 = false;
														gClass.method_40(2.0);
														string text30 = C093FA07();
														gClass.method_20("[name=\"password_new\"]", text30);
														gClass.method_41(2, 3);
														gClass.method_16("[value=\"kill_sessions\"]");
														gClass.method_24("[name=\"password_new\"]");
														method_59(text19, "pass", C58B4601, "cPassword", text30);
														gClass.String_3 = text30;
														for (int i = 0; i < 60; i++)
														{
															string text31 = gClass.method_9();
															if (!text31.Contains("facebook.com/si/actor_experience/actor_gateway"))
															{
																if (!(gClass.method_13(0.0, new List<string> { "[name=\"approvals_code\"]", "#MComposer", "[href*=\"facebook.com/secure_account_learn_more\"]", "[name=\"manage-sessions\"]" }) != ""))
																{
																	if (!gClass.CD003D3F("[name=\"submit_action\"]"))
																	{
																		if (gClass.CD003D3F("[data-sigil=\"m_login_email\"]"))
																		{
																			break;
																		}
																		if (!gClass.method_127())
																		{
																			gClass.method_40(1.0);
																			continue;
																		}
																		FD062316(C58B4601, "Checkpoint");
																		flag6 = true;
																		break;
																	}
																	gClass.method_41(2, 3);
																	gClass.method_16("[name=\"submit_action\"]");
																	if (gClass.CD003D3F("[value=\"OK\"]", 10.0))
																	{
																		gClass.method_41(2, 3);
																		gClass.method_16("[value=\"OK\"]");
																	}
																	flag6 = true;
																	break;
																}
																flag6 = true;
																break;
															}
															flag6 = true;
															break;
														}
													}
													if (flag6)
													{
														FD062316(C58B4601, "Live");
														method_62(C58B4601, 2);
														A1BF1713(C58B4601, string_3 + "Khôi phục mật khẩu thành công!");
													}
													else
													{
														method_62(C58B4601, 1);
														A1BF1713(C58B4601, string_3 + "Khôi phục mật khẩu thất bại!");
													}
													num3 = 1;
													break;
												}
												break;
											}
											break;
										}
										A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Đang đăng nhâ\u0323p..."));
										text32 = "https://www.facebook.com/";
										switch (GClass25.smethod_0("configInteractGeneral").method_2("typeBrowserLogin"))
										{
										case 2:
											text32 = "https://mbasic.facebook.com";
											break;
										case 0:
											text32 = "https://m.facebook.com/";
											break;
										}
										if (C2B70190.method_3("Unlock956") && (C2B70190.method_2("TypeUnlock956") == 2 || C2B70190.method_2("TypeUnlock956") == 3))
										{
											text32 = "https://www.facebook.com/";
										}
										if (!gClass.method_9().Contains("facebook.com"))
										{
											gClass.method_10(text32);
											if (gClass.method_36().Contains("i_user"))
											{
												gClass.method_35("i_user");
												gClass.method_10(text32);
												gClass.method_52(d780F8B.X, d780F8B.Y);
												gClass.method_50(b0B3B9A.X, b0B3B9A.Y);
											}
										}
										if (gClass.String_8 != "")
										{
											gClass.method_40(2.0);
											if (gClass.C12B8625() == "<html><head></head><body></body></html>")
											{
												A1BF1713(C58B4601, string_3 + "Proxy yêu cầu User/Pass!");
												num3 = 1;
												break;
											}
										}
										flag7 = false;
										if (text28.Trim() != "")
										{
											gClass.method_59();
											switch (gClass.method_131(text32))
											{
											case -3:
												gClass.GEnum3_0 = GEnum3.const_5;
												goto end_IL_04f6;
											case -2:
												gClass.GEnum3_0 = GEnum3.DC10881C;
												goto end_IL_04f6;
											case 1:
												flag = true;
												goto IL_139d;
											case 2:
												break;
											default:
												goto IL_139d;
											}
											gClass.GEnum3_0 = GEnum3.E02E9820;
											if (flag2 = !GClass8.smethod_42(text18))
											{
												text = text18;
												text18 = gClass.method_37();
												F0A99AA5(C58B4601, "cUid", text18, "uid");
											}
											if (C2B70190.method_3("Unlock956"))
											{
												flag7 = true;
												goto IL_17b2;
											}
											if (!method_25(gClass, C58B4601, string_3))
											{
												num3 = 1;
												break;
											}
											flag = true;
										}
										goto IL_139d;
									}
									A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Lỗi mở trình duyệt!") + ((text29 != "") ? (" (" + text29 + ")") : ""));
									num3 = 1;
									break;
									IL_139d:
									string text33;
									if (!flag)
									{
										int num16 = GClass25.smethod_0("configInteractGeneral").method_2("typeLogin");
										switch (num16)
										{
										case 1:
											A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Đăng nhâ\u0323p bă\u0300ng email|pass..."));
											goto default;
										case 2:
										case 3:
											A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Đăng nhâ\u0323p bă\u0300ng cookie..."));
											goto default;
										case 0:
											A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Đăng nhâ\u0323p bă\u0300ng uid|pass..."));
											goto default;
										default:
										{
											text33 = gClass.method_129(num16, text32);
											if (num16 != 3 || new List<string> { "1", "2", "8" }.Contains(text33))
											{
												break;
											}
											num16 = 0;
											int num17 = 0;
											int num18 = 0;
											goto case 0;
										}
										}
										string text34 = text33;
										string text35 = text34;
										uint num19 = C43AF739.smethod_0(text35);
										if (num19 <= 856466825)
										{
											if (num19 <= 382537041)
											{
												if (num19 != 365759422)
												{
													if (num19 == 382537041 && text35 == "-3")
													{
														gClass.GEnum3_0 = GEnum3.const_5;
														break;
													}
												}
												else if (text35 == "-2")
												{
													gClass.GEnum3_0 = GEnum3.DC10881C;
													goto IL_1791;
												}
												goto IL_1756;
											}
											if (num19 != 806133968)
											{
												if (num19 != 822911587)
												{
													if (num19 != 856466825 || !(text35 == "6"))
													{
														goto IL_1756;
													}
													A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Mã 2fa không đúng!"));
												}
												else
												{
													if (!(text35 == "4"))
													{
														goto IL_1756;
													}
													A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Tài khoản không đúng!"));
												}
											}
											else
											{
												if (!(text35 == "5"))
												{
													goto IL_1756;
												}
												A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Mật khẩu không đúng!"));
												FD062316(C58B4601, "Changed pass");
											}
										}
										else if (num19 <= 890022063)
										{
											if (num19 != 873244444)
											{
												if (num19 != 890022063 || !(text35 == "0"))
												{
													goto IL_1756;
												}
												A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Đăng nhập thất bại!"));
											}
											else
											{
												if (!(text35 == "1"))
												{
													goto IL_1756;
												}
												flag = true;
											}
										}
										else if (num19 != 906799682)
										{
											if (num19 != 923577301)
											{
												if (num19 != 1024243015 || !(text35 == "8"))
												{
													goto IL_1756;
												}
												FD062316(C58B4601, "Live");
												method_62(C58B4601, 2);
												if (GClass25.smethod_0("configInteractGeneral").method_3("ckbGetCookie") || text23 == "")
												{
													text23 = gClass.method_36();
													if (text23 != "")
													{
														F0A99AA5(C58B4601, "cCookies", text23, "cookie1");
													}
												}
												A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Account Novery!"));
											}
											else
											{
												if (!(text35 == "2"))
												{
													goto IL_1756;
												}
												gClass.GEnum3_0 = GEnum3.E02E9820;
												if (flag2 = !GClass8.smethod_42(text18))
												{
													text = text18;
													text18 = gClass.method_37();
													Class15.EB34450D(text19, "uid", text18);
													method_58(C58B4601, "cUid", text18);
												}
												if (C2B70190.method_3("Unlock956"))
												{
													flag7 = true;
													goto IL_17b2;
												}
												flag = method_25(gClass, C58B4601, string_3);
											}
										}
										else
										{
											if (!(text35 == "3"))
											{
												goto IL_1756;
											}
											if (num16 != 2)
											{
												A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Không có 2fa!"));
											}
											else
											{
												flag = true;
											}
										}
									}
									goto IL_1791;
									IL_1756:
									A1BF1713(C58B4601, string_3 + text33);
									goto IL_1791;
									IL_17b2:
									if (C2B70190.method_3("Unlock956"))
									{
										if (flag7)
										{
											gClass.GEnum3_0 = GEnum3.BAA111A3;
											bool flag8;
											if (flag8 = method_25(gClass, C58B4601, string_3, C2B70190.method_3("Unlock956"), C2B70190.method_2("TypeUnlock956")))
											{
												FD062316(C58B4601, "Live");
												A1BF1713(C58B4601, "Unlock checkpoint success!");
											}
											method_62(C58B4601, (!flag8) ? 1 : 2);
										}
										else if (flag)
										{
											FD062316(C58B4601, "Live");
											A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Đăng nhâ\u0323p tha\u0300nh công!"));
											method_62(C58B4601, 2);
										}
										if (GClass25.smethod_0("configInteractGeneral").method_3("ckbGetCookie") || text23 == "")
										{
											text23 = gClass.method_36();
											if (text23 != "")
											{
												F0A99AA5(C58B4601, "cCookies", text23, "cookie1");
											}
										}
										num3 = 1;
										break;
									}
									FD062316(C58B4601, "Live");
									A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Đăng nhâ\u0323p tha\u0300nh công!"));
									method_62(C58B4601, 2);
									if (!gClass.CD003D3F("[href=\"/\"]"))
									{
										gClass.method_59();
										if (gClass.method_9().Contains("facebook.com/si/actor_experience/actor_gateway") && gClass.CD003D3F("[data-nt=\"NT:IMAGE\"]", 15.0))
										{
											gClass.method_19("[data-nt=\"NT:IMAGE\"]");
											gClass.method_40(2.0);
										}
										if (gClass.CD003D3F("[data-cookiebanner=\"accept_button\"]"))
										{
											gClass.method_19("[data-cookiebanner=\"accept_button\"]");
										}
										if (gClass.AFABF4B7() == 2)
										{
											gClass.BB963890(0, "[href^=\"/a/preferences.php?fast_switch_site\"]");
										}
										if (gClass.method_9().StartsWith("https://free.facebook.com/") || gClass.CD003D3F("[href^=\"/upsell/advanced_upsell/in_line\"]"))
										{
											gClass.BB963890(0, "[href^=\"/upsell/advanced_upsell/in_line\"]");
											gClass.BB963890(5, "#upsell_upgrade_confirm_button");
										}
									}
									if (GClass25.smethod_0("configInteractGeneral").method_3("ckbGetCookie") || text23 == "")
									{
										text23 = gClass.method_36();
										if (text23 != "")
										{
											F0A99AA5(C58B4601, "cCookies", text23, "cookie1");
										}
									}
									if (text18 != gClass.method_37())
									{
										gClass.BFB4D2B2(text18);
									}
									if (flag2 = !GClass8.smethod_42(text18))
									{
										text = text18;
										text18 = gClass.method_37();
										Class15.EB34450D(text19, "uid", text18);
										method_58(C58B4601, "cUid", text18);
									}
									method_65(gClass);
									if (C2B70190.method_3("OpenBrowser"))
									{
										num3 = 1;
										break;
									}
									if (GClass25.smethod_0("configInteractGeneral").method_3("ckbDisableChatSettings"))
									{
										gClass.method_80();
									}
									if (GClass25.smethod_0("configInteractGeneral").method_3("ckbCheckBanBeGoiY") && text5 == "")
									{
										A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Check gợi ý kết bạn..."));
										text5 = "Yes";
										gClass.method_10("https://m.facebook.com/friends/center/suggestions/?mff_nav=1&ref=bookmarks");
										if (gClass.BEA5E4BB("return document.querySelectorAll('[data-sigil=\"m-add-friend-button-container\"]>div>div>div>a').length+''").ToString() == "0")
										{
											text5 = "No";
										}
									}
									if (GClass25.smethod_0("configInteractGeneral").method_3("ckbCheckSpam"))
									{
										string text36 = gClass.D129B30F("https://mbasic.facebook.com/support/?ref=settings");
										if (text36.Contains("background-color: #4a90e2"))
										{
											flag3 = true;
										}
									}
									if (GClass25.smethod_0("configInteractGeneral").method_3("ckbAllowFollow"))
									{
										A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Cho phe\u0301p ngươ\u0300i kha\u0301c follow..."));
										gClass.A3962EA2();
										method_31();
									}
									if (GClass25.smethod_0("configInteractGeneral").method_3("ckbReviewTag"))
									{
										A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Bật duyệt bài viết..."));
										F9A25F89(gClass);
										method_31();
									}
									if (GClass25.smethod_0("configInteractGeneral").method_3("ckbBatThongBaoDangNhap"))
									{
										A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Bật thông báo đăng nhập..."));
										method_29(gClass, C58B4601);
										method_31();
									}
									if (GClass25.smethod_0("configInteractGeneral").method_3("ckbCapNhatThongTin"))
									{
										try
										{
											A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Cập nhật thông tin..."));
											B0A6BA0A(gClass, C58B4601, string_2, int_5);
											gClass.method_40(2.0);
										}
										catch (Exception ex)
										{
											GClass8.smethod_62(null, ex.ToString());
										}
									}
									if (GClass25.smethod_0("configInteractGeneral").method_3("ckbGetToken"))
									{
										switch (GClass25.smethod_0("configInteractGeneral").method_2("typeToken"))
										{
										case 0:
											text24 = gClass.method_82();
											break;
										case 1:
											text24 = gClass.method_83();
											break;
										case 2:
											text24 = gClass.method_81();
											break;
										}
										if (text24 != "")
										{
											Class15.EB34450D(text19, "token", text24);
											method_58(C58B4601, "cToken", text24);
										}
									}
									if (GClass25.smethod_0("configInteractGeneral").method_3("ckbWallPosts"))
									{
										A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Check Wall posts..."));
										gClass.method_10("https://mbasic.facebook.com/me?v=timeline");
										int num20 = gClass.E22B0917("#structured_composer_async_container>section>article");
										if (num20 >= 0)
										{
											if (gClass.CD003D3F("[href^=\"/profile/timeline/stream/?cursor=\"]"))
											{
												F0A99AA5(C58B4601, "cWallPosts", num20 + "+", "wallPosts");
											}
											else
											{
												F0A99AA5(C58B4601, "cWallPosts", num20.ToString() ?? "", "wallPosts");
											}
										}
									}
									if (GClass25.smethod_0("configInteractGeneral").method_3("ckbCauHinhTaiKhoan"))
									{
										A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Cấu hình tài khoản..."));
										DC0F7A13(gClass);
										gClass.method_40(2.0);
									}
									if (GClass25.smethod_0("configInteractGeneral").method_3("ckbCongKhaiBanBe"))
									{
										A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Cấu hình tài khoản..."));
										AB2FBD3B(gClass);
										gClass.method_40(2.0);
									}
									if (GClass25.smethod_0("configInteractGeneral").method_3("ckbLogOut"))
									{
										A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Đăng xuất..."));
										CFBAAA89(gClass);
									}
									break;
									IL_1791:
									if (!flag)
									{
										method_62(C58B4601, 1);
										method_30(gClass, text18, 1);
										num3 = 1;
										break;
									}
									goto IL_17b2;
								}
							}
							end_IL_04f6:;
						}
						catch (Exception f4295AA)
						{
							A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Lô\u0303i không xa\u0301c đi\u0323nh!"));
							num3 = 1;
							GClass8.BFBDF687(gClass, f4295AA, F7AB102E.smethod_0("Lô\u0303i không xa\u0301c đi\u0323nh!"));
						}
					}
				}
			}
			goto IL_1ec7;
			IL_1ec7:
			string text37 = "";
			if (num3 == 1)
			{
				if (gClass != null)
				{
					if (gClass.GEnum3_0 == GEnum3.E02E9820)
					{
						method_30(gClass, text18, 0);
					}
					switch (gClass.GEnum3_0)
					{
					default:
						text37 = E01F1137(C58B4601);
						break;
					case GEnum3.DC10881C:
					case GEnum3.E02E9820:
					case GEnum3.const_5:
						method_62(C58B4601, 1);
						text37 = GClass33.smethod_0(gClass.GEnum3_0);
						text23 = gClass.method_36();
						break;
					}
				}
				else
				{
					text37 = E01F1137(C58B4601);
				}
			}
			else if (GClass8.smethod_42(text18) && Class14.EABAA59C(text18).StartsWith("0|"))
			{
				FD062316(C58B4601, "Die");
				text37 = F7AB102E.smethod_0("Tài khoản Die!");
			}
			else
			{
				gClass.GEnum3_0 = GEnum3.BAA111A3;
				gClass.method_123(DB2A5F10: true);
				switch (gClass.GEnum3_0)
				{
				case GEnum3.DC10881C:
				case GEnum3.E02E9820:
				case GEnum3.const_5:
					method_62(C58B4601, 1);
					text37 = GClass33.smethod_0(gClass.GEnum3_0);
					text23 = gClass.method_36();
					break;
				}
			}
			if (C2B70190.method_3("OpenBrowser"))
			{
				if (!flag && GClass25.smethod_0("configOpenBrowser").method_3("isAutoCloseChromeLoginFail"))
				{
					method_24(C58B4601, string_3, gClass);
				}
				else
				{
					if (GClass25.smethod_0("configOpenBrowser").method_3("ckbAutoOpenLink"))
					{
						gClass.method_10(GClass25.smethod_0("configOpenBrowser").C0288288("txtLink"));
					}
					if (GClass25.smethod_0("configOpenBrowser").method_3("ckbLoginHotmail") && (text20.Contains("hotmail") || text20.Contains("outlook")))
					{
						gClass.method_38("https://outlook.live.com");
						string json = gClass.F7060B1F(text20, text21, text22, string_6);
						JObject jObject = JObject.Parse(json);
						if (!Convert.ToBoolean(jObject["success"]))
						{
							text37 = string_3 + jObject["error"]!.ToString() + "!";
						}
						else
						{
							if (jObject["mailRecover"]!.ToString() != "" && jObject["mailRecover"]!.ToString() != text22)
							{
								text22 = jObject["mailRecover"]!.ToString();
								string_6 = jObject["passMailRecover"]!.ToString();
								F0A99AA5(C58B4601, "cMailRecovery", text22, "mailrecovery");
								F0A99AA5(C58B4601, "cPassMailRecovery", string_6, "passmailrecovery");
							}
							if (text21 != jObject["passmail"]!.ToString())
							{
								text21 = jObject["passmail"]!.ToString();
								F0A99AA5(C58B4601, "cPassMail", text21, "passmail");
							}
							text37 = string_3 + "Login hotmail success!";
						}
					}
				}
			}
			else
			{
				try
				{
					if (gClass != null)
					{
						if (!gClass.method_1() && GClass25.smethod_0("configGeneral").method_3("ckbDelayCloseChrome"))
						{
							int int_6 = Class57.random_0.Next(GClass25.smethod_0("configGeneral").method_2("nudDelayCloseChromeFrom"), GClass25.smethod_0("configGeneral").method_2("nudDelayCloseChromeTo") + 1);
							A1BF1713(C58B4601, string_3 + "Đóng tri\u0300nh duyê\u0323t sau {time}s...", int_6);
						}
						method_24(C58B4601, string_3, gClass);
					}
				}
				catch
				{
				}
			}
			string text38 = "";
			if (text3 != "")
			{
				text38 = text38 + "- " + text3;
			}
			if (text4 != "")
			{
				text38 = text38 + "- " + text4;
			}
			if (text5 != "")
			{
				text38 = text38 + "- " + F7AB102E.smethod_0("Gợi ý Kb: ") + text5;
			}
			if (text6 != "")
			{
				text38 = text38 + "- " + F7AB102E.smethod_0("Xóa Sđt: ") + text6;
			}
			if (text7 != "")
			{
				text38 = text38 + "- Add mail: " + text7;
			}
			if (text8 != "")
			{
				text38 = text38 + "- Xóa mail: " + text8;
			}
			if (text9 != "")
			{
				text38 = text38 + "- Đổi pass: " + text9;
			}
			if (text10 != "")
			{
				text38 = text38 + "- Đổi tên: " + text10;
			}
			if (text11 != "")
			{
				text38 = text38 + "- Up avatar: " + text11;
			}
			if (text12 != "")
			{
				text38 = text38 + "- Up cover: " + text12;
			}
			if (text13 != "")
			{
				text38 = text38 + "- 2FA: " + text13;
			}
			if (text14 != "")
			{
				text38 = text38 + "- Tạo page: " + text14;
			}
			if (text16 != "")
			{
				text38 = text38 + "- Share page: " + text16;
			}
			if (gClass != null && gClass.DA0E8786)
			{
				text38 += "- Fb Block";
				F0A99AA5(C58B4601, "cFbBlock", "Yes", "fbBlock");
			}
			if (num6 > -1)
			{
				text38 = text38 + "- Share: " + num6;
			}
			if (num8 > -1)
			{
				text38 = text38 + "- Job success: " + num8;
				method_57(C58B4601, num8);
			}
			if (text17 != "")
			{
				text38 = text38 + " (" + text17 + ")";
			}
			if (num7 > -1 && Class57.bool_0)
			{
				text38 = text38 + "- Comment: " + num7;
			}
			if (text15 != "")
			{
				text38 = text38 + "- Unlink Instagram: " + text15;
			}
			string text39 = text37;
			string text40 = text39;
			if (!(text40 == ""))
			{
				A1BF1713(C58B4601, string_3 + text37);
			}
			else
			{
				string text41 = "";
				switch (num5)
				{
				case 1:
					text41 += " -Like page success!";
					break;
				case 2:
					text41 += " -Like page fail!";
					break;
				}
				switch (num4)
				{
				case 1:
					text41 += " -Follow success!";
					break;
				case 2:
					text41 += " -Follow fail!";
					break;
				}
				A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Đã tương tác xong!") + (flag3 ? "- Facebook spam!" : "") + text41 + ((text2 != "") ? ("- " + text2) : "") + text38 + " [" + aABDF09D.method_0() + "(s)]");
				F0A99AA5(C58B4601, "cInteractEnd", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "interactEnd");
				if (C5151C09(C58B4601) != "Changed pass")
				{
					FD062316(C58B4601, "Live");
				}
			}
			if (flag2 && Directory.Exists(GClass25.smethod_0("configGeneral").C0288288("txbPathProfile") + "\\" + text) && text != "")
			{
				string text42 = GClass25.smethod_0("configGeneral").C0288288("txbPathProfile") + "\\" + text;
				string text43 = GClass25.smethod_0("configGeneral").C0288288("txbPathProfile") + "\\" + text18;
				if (!GClass8.EF9599B0(text42, text43) && GClass8.B41DE232(text42, text43))
				{
					GClass8.smethod_67(text42);
				}
			}
			method_20(class9_, A9A4CFA, d0AA71A1_, gclass6_);
			goto end_IL_0243;
			IL_042b:
			A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Đã dừng!"));
			num3 = 1;
			goto IL_1ec7;
			end_IL_0243:;
		}
		catch (Exception ex2)
		{
			if (ex2.ToString().Contains("Thread was being aborted."))
			{
				try
				{
					method_24(C58B4601, string_3, gClass);
					A1BF1713(C58B4601, string_3 + F7AB102E.smethod_0("Đã tương tác xong!") + " [" + aABDF09D.method_0() + "(s)]");
					method_58(C58B4601, "cInteractEnd", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
					Class15.EB34450D(text19, "interactEnd", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
					method_20(class9_, A9A4CFA, d0AA71A1_, gclass6_);
				}
				catch (Exception)
				{
				}
			}
		}
	}

	private List<FC9552BB> B522ADA4(ref int DDBED9AB)
	{
		List<FC9552BB> list = new List<FC9552BB>();
		int num = GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp");
		switch (num)
		{
		case 8:
		{
			List<string> list3 = GClass25.smethod_0("configGeneral").C5A69DA0("txtListProxy");
			if (list3.Count != 0)
			{
				for (int j = 0; j < list3.Count; j++)
				{
					list.Add(new Class9(GClass25.smethod_0("configGeneral").C0288288("txtServiceURLXProxy"), list3[j], GClass25.smethod_0("configGeneral").method_2("typeProxy"), GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPXProxy")));
				}
				if (list.Count * GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPXProxy") < DDBED9AB)
				{
					DDBED9AB = list.Count * GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPXProxy");
				}
			}
			break;
		}
		default:
		{
			List<string> list5 = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiKey_" + num);
			int num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIP_" + num, -1);
			if (num2 == -1)
			{
				switch (num)
				{
				case 7:
					list5 = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiProxy");
					num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPTinsoft", 1);
					break;
				case 10:
					list5 = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiKeyTMProxy");
					num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPTMProxy", 1);
					break;
				case 11:
					list5 = GClass25.smethod_0("configGeneral").C5A69DA0("txtListProxyv6");
					num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPProxyv6", 1);
					break;
				case 12:
					list5 = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiShopLike");
					num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPShopLike", 1);
					break;
				case 15:
					list5 = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiKeyProxyFb");
					num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPProxyFb", 1);
					break;
				case 16:
					list5 = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiKeyWWProxy");
					num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPWWProxy", 1);
					break;
				case 17:
					list5 = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiKeyKiotProxy");
					num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPKiotProxy", 1);
					break;
				case 18:
					list5 = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiKeyFProxy");
					num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPFProxy", 1);
					break;
				case 19:
					list5 = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiKeyNetProxy");
					num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPNetProxy", 1);
					break;
				case 20:
					list5 = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiKeyRaiProxy");
					num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPRaiProxy", 1);
					break;
				case 21:
					list5 = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiKeyNortonProxy");
					num2 = GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPNortonProxy", 1);
					break;
				}
			}
			if (list5.Count != 0)
			{
				for (int l = 0; l < list5.Count; l++)
				{
					list.Add(new A8322F29(list5[l], num2));
				}
				if (list.Count * num2 < DDBED9AB)
				{
					DDBED9AB = list.Count * num2;
				}
			}
			break;
		}
		case 13:
		{
			List<string> list4 = GClass25.smethod_0("configGeneral").C5A69DA0("txtApiKeyMinProxy");
			if (list4.Count != 0)
			{
				for (int k = 0; k < list4.Count; k++)
				{
					list.Add(new D0AA71A1(GClass25.smethod_0("configGeneral").method_2("typeMin"), list4[k], GClass25.smethod_0("configGeneral").method_2("typeProxyMin"), GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPMinProxy")));
				}
				if (list.Count * GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPMinProxy") < DDBED9AB)
				{
					DDBED9AB = list.Count * GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPMinProxy");
				}
			}
			break;
		}
		case 14:
		{
			List<string> list2 = GClass25.smethod_0("configGeneral").C5A69DA0("txtListObcProxy");
			if (list2.Count == 0)
			{
				break;
			}
			list_0 = new List<GClass5>();
			Dictionary<string, List<string>> source = GClass5.smethod_0(GClass25.smethod_0("configGeneral").C0288288("txtLinkWebObcProxy"));
			for (int i = 0; i < list2.Count; i++)
			{
				string string_0 = list2[i].Split(':')[1];
				string key = source.FirstOrDefault((KeyValuePair<string, List<string>> keyValuePair_0) => keyValuePair_0.Value.Contains(string_0)).Key;
				if (!string.IsNullOrEmpty(key))
				{
					GClass5 gClass = GClass5.smethod_1(list_0, key);
					if (gClass == null)
					{
						gClass = new GClass5(key);
						list_0.Add(gClass);
					}
					GClass6 gClass2 = new GClass6(GClass25.smethod_0("configGeneral").C0288288("txtLinkWebObcProxy"), list2[i], 0, GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPObcProxy"), key);
					list.Add(gClass2);
					gClass.method_1(gClass2);
				}
			}
			if (list.Count * GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPObcProxy") < DDBED9AB)
			{
				DDBED9AB = list.Count * GClass25.smethod_0("configGeneral").method_2("nudLuongPerIPObcProxy");
			}
			break;
		}
		case 0:
		case 1:
		case 2:
		case 9:
			list = null;
			break;
		}
		return list;
	}

	private void method_19(int int_4, ref string string_1, ref int int_5, ref string string_2, ref string string_3, ref Class9 class9_0, ref A8322F29 A9A4CFA6, ref D0AA71A1 d0AA71A1_0, ref GClass6 gclass6_0)
	{
		while (true)
		{
			IL_0cb0:
			bool flag2;
			int num;
			switch (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp"))
			{
			case 8:
				A1BF1713(int_4, "Get Proxy...");
				lock (EEB7322B)
				{
					if (GClass25.smethod_0("configGeneral").method_2("typeRunXproxy") == 0)
					{
						while (!Class57.smethod_5())
						{
							class9_0 = null;
							while (!Class57.smethod_5())
							{
								foreach (Class9 item in F8B76B18)
								{
									if (item.bool_0 && (class9_0 == null || item.DBA0C4A7 < class9_0.DBA0C4A7))
									{
										class9_0 = item;
									}
								}
								if (class9_0.DBA0C4A7 != class9_0.int_2)
								{
									break;
								}
							}
							if (Class57.smethod_5())
							{
								break;
							}
							if (class9_0.bool_0)
							{
								bool flag3 = false;
								if (class9_0.DBA0C4A7 > 0)
								{
									flag3 = true;
								}
								else
								{
									switch (class9_0.D4B3360B())
									{
									case 0:
										class9_0.bool_0 = false;
										break;
									case 1:
										flag3 = true;
										break;
									}
								}
								if (flag3)
								{
									string_1 = class9_0.string_0;
									int_5 = class9_0.int_0;
									class9_0.int_1++;
									class9_0.DBA0C4A7++;
									break;
								}
							}
							else
							{
								class9_0.bool_0 = false;
							}
						}
					}
					else
					{
						while (!Class57.smethod_5())
						{
							class9_0 = null;
							List<Class9> list3 = new List<Class9>();
							foreach (Class9 item2 in F8B76B18)
							{
								if (item2.bool_0)
								{
									if (item2.DBA0C4A7 < item2.int_2)
									{
										list3.Add(item2);
									}
									else if (item2.int_1 == 0)
									{
										item2.method_0();
										item2.DBA0C4A7 = 0;
									}
								}
							}
							for (int k = 0; k < list3.Count; k++)
							{
								if (list3[k].method_1(0))
								{
									class9_0 = list3[k];
									break;
								}
							}
							if (class9_0 != null)
							{
								string_1 = class9_0.string_0;
								int_5 = class9_0.int_0;
								class9_0.int_1++;
								class9_0.DBA0C4A7++;
								break;
							}
						}
					}
					if (Class57.smethod_5())
					{
						return;
					}
					if (GClass25.smethod_0("configGeneral").method_2("nudDelayCheckIP") > 0)
					{
						A1BF1713(int_4, string_2 + "Delay after change ip {time}s...", GClass25.smethod_0("configGeneral").method_2("nudDelayCheckIP"));
					}
					bool flag4 = true;
					if (!GClass25.smethod_0("configGeneral").method_3("ckbKhongCheckIP"))
					{
						string_2 = "(IP: " + string_1 + ") ";
						A1BF1713(int_4, string_2 + "Check IP...");
						string_3 = GClass8.smethod_59(string_1, int_5);
						if (string_3 == "")
						{
							class9_0.bool_0 = false;
							flag4 = false;
						}
					}
					if (!flag4)
					{
						class9_0.int_1--;
						class9_0.DBA0C4A7--;
						continue;
					}
					return;
				}
			case 13:
				A1BF1713(int_4, F7AB102E.smethod_0("Đang lấy Api MinProxy..."));
				int_5 = ((GClass25.smethod_0("configGeneral").method_2("typeProxyMin") >= 2) ? 1 : 0);
				d0AA71A1_0 = null;
				flag2 = false;
				num = 0;
				if (Class57.smethod_5())
				{
					return;
				}
				lock (EEB7322B)
				{
					while (!Class57.smethod_5())
					{
						foreach (D0AA71A1 item3 in F8B76B18)
						{
							if (item3.int_3 != 0)
							{
								if (d0AA71A1_0 == null || item3.AD29C081 < d0AA71A1_0.AD29C081)
								{
									d0AA71A1_0 = item3;
								}
								continue;
							}
							d0AA71A1_0 = item3;
							break;
						}
						if (d0AA71A1_0.AD29C081 < d0AA71A1_0.int_4)
						{
							break;
						}
					}
					if (d0AA71A1_0 != null)
					{
						d0AA71A1_0.int_3++;
						d0AA71A1_0.AD29C081++;
						num = d0AA71A1_0.AD29C081;
						goto IL_06cb;
					}
				}
				goto IL_0930;
			case 14:
				A1BF1713(int_4, "Get Proxy...");
				lock (EEB7322B)
				{
					if (GClass25.smethod_0("configGeneral").method_2("typeRunObcProxy") == 0)
					{
						while (!Class57.smethod_5())
						{
							gclass6_0 = null;
							List<GClass6> list = new List<GClass6>();
							foreach (GClass6 item4 in F8B76B18)
							{
								if (item4.F9B6CAB2)
								{
									if (item4.C7BFB190 < item4.int_1)
									{
										list.Add(item4);
									}
									else if (item4.C6B64DA2 == 0)
									{
										item4.method_0();
										item4.C7BFB190 = 0;
									}
								}
							}
							for (int i = 0; i < list.Count; i++)
							{
								if (list[i].D99A0B34(0))
								{
									gclass6_0 = list[i];
									break;
								}
							}
							if (gclass6_0 != null)
							{
								string_1 = gclass6_0.string_1;
								int_5 = gclass6_0.int_0;
								gclass6_0.C6B64DA2++;
								gclass6_0.C7BFB190++;
								break;
							}
						}
					}
					else
					{
						while (!Class57.smethod_5())
						{
							gclass6_0 = null;
							List<GClass6> list2 = new List<GClass6>();
							foreach (GClass5 item5 in list_0)
							{
								if (item5.method_5())
								{
									item5.method_4();
									list2.AddRange(item5.method_2());
								}
								else
								{
									list2.AddRange(item5.method_3());
								}
							}
							for (int j = 0; j < list2.Count; j++)
							{
								if (list2[j].D99A0B34(0))
								{
									gclass6_0 = list2[j];
									break;
								}
							}
							if (gclass6_0 != null)
							{
								string_1 = gclass6_0.string_1;
								int_5 = gclass6_0.int_0;
								gclass6_0.C6B64DA2++;
								gclass6_0.C7BFB190++;
								break;
							}
						}
					}
					if (Class57.smethod_5())
					{
						A1BF1713(int_4, string_2 + F7AB102E.smethod_0("Đã dừng!"));
						return;
					}
					if (GClass25.smethod_0("configGeneral").method_2("nudDelayCheckIP") > 0)
					{
						A1BF1713(int_4, string_2 + "Delay after change ip {time}s...", GClass25.smethod_0("configGeneral").method_2("nudDelayCheckIP"));
					}
					bool flag = true;
					if (!GClass25.smethod_0("configGeneral").method_3("ckbKhongCheckIP"))
					{
						string_2 = "(IP: " + string_1 + ") ";
						A1BF1713(int_4, string_2 + "Check IP...");
						string_3 = GClass8.smethod_59(string_1, int_5);
						if (string_3 == "")
						{
							gclass6_0.F9B6CAB2 = false;
							flag = false;
						}
					}
					if (!flag)
					{
						gclass6_0.C6B64DA2--;
						gclass6_0.C7BFB190--;
						continue;
					}
					return;
				}
			case 9:
				if (GClass25.smethod_0("configGeneral").method_2("cbbProxy") == 0)
				{
					string_1 = method_60(int_4, "cProxy");
					int_5 = (string_1.EndsWith("*1") ? 1 : 0);
					if (string_1.EndsWith("*0") || string_1.EndsWith("*1"))
					{
						string_1 = string_1.Substring(0, string_1.Length - 2);
					}
				}
				else
				{
					string_1 = GClass25.smethod_0("configGeneral").C5A69DA0("txtProxy").smethod_6();
					if (string_1 == null)
					{
						string_1 = "";
					}
					int_5 = GClass25.smethod_0("configGeneral").method_2("cbbProxyType");
				}
				return;
			case 0:
			case 1:
			case 2:
				return;
				IL_06cb:
				A1BF1713(int_4, F7AB102E.smethod_0("Đang lấy Proxy từ API..."));
				if (num > 1)
				{
					int num2 = 0;
					while (d0AA71A1_0.BB10CE1A)
					{
						GClass8.smethod_53(1.0);
						num2++;
						if (num2 > 60)
						{
							break;
						}
					}
					string_1 = d0AA71A1_0.method_2();
				}
				else
				{
					while (!Class57.smethod_5())
					{
						switch (d0AA71A1_0.F6956018())
						{
						case 0:
							A1BF1713(int_4, F7AB102E.smethod_0("Đang lấy Proxy từ API: Chờ " + d0AA71A1_0.D8271EA4 + " s"));
							if (d0AA71A1_0.D8271EA4 > 10)
							{
								GClass8.smethod_53(10.0);
							}
							else if (d0AA71A1_0.D8271EA4 > 0)
							{
								GClass8.smethod_53(d0AA71A1_0.D8271EA4);
							}
							goto IL_07c9;
						case 1:
							string_1 = d0AA71A1_0.BC2790A7;
							d0AA71A1_0.BB10CE1A = false;
							goto IL_07c9;
						default:
							goto IL_07c9;
						case -2:
							A1BF1713(int_4, F7AB102E.smethod_0("Api không đúng"));
							lock (EEB7322B)
							{
								F8B76B18.Remove(d0AA71A1_0);
							}
							break;
						case -1:
							A1BF1713(int_4, F7AB102E.smethod_0("Api hết hạn"));
							lock (EEB7322B)
							{
								F8B76B18.Remove(d0AA71A1_0);
							}
							break;
						}
						goto IL_0cb0;
						IL_07c9:
						if (string_1 != "")
						{
							break;
						}
					}
				}
				if (!(string_1 == ""))
				{
					flag2 = true;
					if (GClass25.smethod_0("configGeneral").method_2("nudDelayCheckIP") > 0)
					{
						A1BF1713(int_4, string_2 + "Delay check IP {time}s...", GClass25.smethod_0("configGeneral").method_2("nudDelayCheckIP"));
					}
					if (!GClass25.smethod_0("configGeneral").method_3("ckbKhongCheckIP"))
					{
						string_2 = "(IP: " + string_1 + ") ";
						A1BF1713(int_4, string_2 + "Check IP...");
						string_3 = GClass8.smethod_59(string_1, int_5);
						if (string_3 == "")
						{
							flag2 = false;
						}
					}
				}
				goto IL_0930;
				IL_0930:
				if (!flag2)
				{
					d0AA71A1_0.int_3--;
					d0AA71A1_0.AD29C081--;
					continue;
				}
				return;
			}
			A1BF1713(int_4, "Get Proxy...");
			lock (EEB7322B)
			{
				while (!Class57.smethod_5())
				{
					A9A4CFA6 = null;
					while (!Class57.smethod_5())
					{
						foreach (A8322F29 item6 in F8B76B18)
						{
							if (A9A4CFA6 == null || item6.F2A3993B < A9A4CFA6.F2A3993B)
							{
								A9A4CFA6 = item6;
							}
						}
						if (A9A4CFA6.F2A3993B != A9A4CFA6.C43E85AC)
						{
							break;
						}
					}
					if (Class57.smethod_5())
					{
						break;
					}
					if (A9A4CFA6.F2A3993B > 0 || A9A4CFA6.method_1())
					{
						string_1 = A9A4CFA6.String_1;
						if (string_1 == "")
						{
							string_1 = A9A4CFA6.method_2();
						}
						A9A4CFA6.D092EB86++;
						A9A4CFA6.F2A3993B++;
						break;
					}
				}
				if (Class57.smethod_5())
				{
					return;
				}
				if (GClass25.smethod_0("configGeneral").method_2("nudDelayCheckIP") > 0)
				{
					A1BF1713(int_4, string_2 + "Delay after change ip {time}s...", GClass25.smethod_0("configGeneral").method_2("nudDelayCheckIP"));
				}
				bool flag5 = true;
				if (!GClass25.smethod_0("configGeneral").method_3("ckbKhongCheckIP"))
				{
					string_2 = "(IP: " + string_1.Split(':')[0] + ") ";
					A1BF1713(int_4, string_2 + "Check IP...");
					string_3 = GClass8.smethod_59(string_1);
					if (string_3 == "")
					{
						flag5 = false;
					}
				}
				if (!flag5)
				{
					A9A4CFA6.D092EB86--;
					A9A4CFA6.F2A3993B--;
					continue;
				}
				return;
			}
		}
	}

	private void method_20(Class9 class9_0, A8322F29 DDB143A0, D0AA71A1 F6B6A21D, GClass6 BB0B0923)
	{
		lock (object_0)
		{
			switch (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp"))
			{
			case 8:
				class9_0?.E0232229();
				break;
			default:
				DDB143A0?.method_0();
				break;
			case 13:
				F6B6A21D?.method_1();
				break;
			case 14:
				BB0B0923?.CAA6C2B8();
				break;
			case 0:
			case 1:
			case 2:
			case 9:
				break;
			}
		}
	}

	private int method_21(string D9BEA010, string string_1, int int_4)
	{
		try
		{
			F3958F9B f3958F9B = new F3958F9B("", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36", string_1, int_4);
			string text = f3958F9B.method_0("https://m.facebook.com/login/identify/?ctx=recover&c=https%3A%2F%2Fm.facebook.com%2F&multiple_results=0&ars=facebook_login&lwv=100&_rdr");
			string value = Regex.Match(text, "name=\"lsd\" value=\"(.*?)\"").Groups[1].Value;
			string value2 = Regex.Match(text, "name=\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
			if (text.Contains("cookie-policy-manage-dialog-accept-button"))
			{
				return 3;
			}
			string bFA79D3C = "lsd=" + value + "&jazoest=" + value2 + "&email=" + WebUtility.UrlEncode(D9BEA010) + "&did_submit=T%C3%ACm+ki%E1%BA%BFm";
			string text2 = f3958F9B.A6321D97("https://m.facebook.com/login/identify/?ctx=recover&c=%2Flogin%2F&search_attempts=1&ars=facebook_login&alternate_search=0&show_friend_search_filtered_list=0&birth_month_search=0&city_search=0", bFA79D3C);
			if (text2.Contains("login_identify_search_error_msg"))
			{
				return 0;
			}
			if (text2.Contains("571927962827151"))
			{
				return 4;
			}
			text2 = f3958F9B.method_0("https://m.facebook.com/recover/initiate/?c=%2Flogin%2F&fl=initiate_view&ctx=msite_initiate_view");
			value = Regex.Match(text2, "name=\"lsd\" value=\"(.*?)\"").Groups[1].Value;
			value2 = Regex.Match(text2, "name=\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
			text2 = f3958F9B.A6321D97("https://m.facebook.com/ajax/recover/initiate/?c=%2Flogin%2F&sr=0", "lsd=" + value + "&jazoest=" + value2 + "&recover_method=send_email&reset_action=Ti%E1%BA%BFp+t%E1%BB%A5c");
			if (text2.Contains("name=\"n\"") && text2.Contains(WebUtility.UrlEncode(D9BEA010)))
			{
				return 1;
			}
			return 3;
		}
		catch
		{
		}
		return 2;
	}

	public void method_22(int B3922635, string E3830983, string string_1, string A6B49CBC, int int_4)
	{
		var (text, text2) = Class14.C600032E(string_1, A6B49CBC, int_4);
		if (text2 != "")
		{
			FD062316(B3922635, text2);
		}
		if (text == "")
		{
			text = text2;
		}
		A1BF1713(B3922635, E3830983 + text + "!");
		string text3 = (text2 + text).ToLower();
		if (text3.Contains("live"))
		{
			method_62(B3922635, 2);
		}
		else if (text3.Contains("checkpoint"))
		{
			method_62(B3922635, 1);
		}
	}

	public void B4A21198(int F0AAB630, string A19B1B94, F3958F9B f3958F9B_0)
	{
		string a723BA = method_60(F0AAB630, "cUid");
		string b12D5A3C = method_60(F0AAB630, "cEmail");
		string text = method_60(F0AAB630, "cPassMail");
		string b0A94F = method_60(F0AAB630, "cOAuth2");
		string string_ = method_60(F0AAB630, "cBirthday");
		A1BF1713(F0AAB630, A19B1B94 + "Unlock 956...");
		var (text2, text3, text4) = Class14.AC88689B(F0AAB630, A19B1B94, f3958F9B_0, a723BA, b12D5A3C, text, b0A94F, string_);
		A1BF1713(F0AAB630, A19B1B94 + text2 + "!");
		if (text3 != "")
		{
			FD062316(F0AAB630, text3);
		}
		if (text4 != "")
		{
			F0A99AA5(F0AAB630, "cPassword", text4, "pass");
		}
		string text5 = (text3 + text2).ToLower();
		if (!text5.Contains("live") && !text5.Contains("success"))
		{
			if (text5.Contains("checkpoint"))
			{
				method_62(F0AAB630, 1);
			}
		}
		else
		{
			method_62(F0AAB630, 2);
		}
	}

	private int method_23(GClass3 B62CBEB6, string D5261D9E = "")
	{
		string text = B62CBEB6.D789C71C(B62CBEB6.method_9());
		if (D5261D9E == "")
		{
			D5261D9E = B62CBEB6.D129B30F(text);
		}
		string string_ = text + Regex.Match(D5261D9E, "(/checkpoint/1501092823525282/logout/.*?)\"").Groups[1].Value.Replace("&amp;", "&");
		D5261D9E = B62CBEB6.D129B30F(string_);
		string value = Regex.Match(D5261D9E, "sau (\\d+) ngày").Groups[1].Value;
		if (value == "")
		{
			value = Regex.Match(D5261D9E, "are (\\d+) days").Groups[1].Value;
		}
		if (GClass8.smethod_44(value))
		{
			return Convert.ToInt32(value);
		}
		return -1;
	}

	private void method_24(int int_4, string string_1, GClass3 gclass3_0)
	{
		try
		{
			if (gclass3_0 != null)
			{
				A1BF1713(int_4, string_1 + "Close chrome...");
				gclass3_0.B7841719();
				if (GClass25.smethod_0("configGeneral").method_3("ckbAddChromeIntoForm"))
				{
					fViewChrome.fViewChrome_0.E0AACC8E(gclass3_0.int_0);
				}
			}
		}
		catch
		{
		}
	}

	private bool method_25(GClass3 B82DF423, int int_4, string F6375029, bool bool_2 = false, int int_5 = 2)
	{
		string text = "";
		string text2 = method_60(int_4, "cPassword");
		string text3 = "[href*=\"facebook.com/security/2fac/setup/intro/\"]";
		if (B82DF423.CD003D3F(text3))
		{
			if (!(text2 == ""))
			{
				int num = 0;
				int num2 = 3;
				string text4 = "";
				int tickCount = Environment.TickCount;
				do
				{
					string text5 = B82DF423.method_13(0.0, new List<string> { "[type=\"submit\"]" });
					string text6 = text5;
					string text7 = text6;
					if (text7 == "[type=\"submit\"]")
					{
						if (B82DF423.CD003D3F("[href^=\"/security/2fac/setup/turn_off/\"]"))
						{
							if (text4 != "")
							{
								F0A99AA5(int_4, "cFa2", text4, "fa2");
								return true;
							}
							if (B82DF423.CD003D3F("[href*=\"/security/2fac/setup/qrcode/generate/\"]"))
							{
								text5 = "[href*=\"/security/2fac/setup/qrcode/generate/\"]";
								string value = Regex.Match(B82DF423.method_9(), "https://(.*?)facebook.com").Value;
								string text8 = B82DF423.method_4(text5, "href");
								if (!text8.StartsWith("http"))
								{
									text8 = value + text8;
								}
								B82DF423.method_10(text8);
							}
						}
						else if (B82DF423.CD003D3F("[name=\"pass\"]"))
						{
							if (B82DF423.BEA5E4BB("return document.querySelector('[data-sigil=\"marea\"] .mfsm').innerText").ToString() != "")
							{
								FD062316(int_4, "Changed pass");
								A1BF1713(int_4, F6375029 + F7AB102E.smethod_0("Mật khẩu không đúng!"));
								return false;
							}
							B82DF423.method_20("[name=\"pass\"]", text2);
							B82DF423.method_40(2.0);
							B82DF423.method_16("[name=\"save\"]");
						}
						else if (B82DF423.CD003D3F("[name=\"code\"]"))
						{
							string text9 = GClass8.smethod_66(text4);
							if (text9 == "")
							{
								break;
							}
							if (text9 != "")
							{
								B82DF423.method_20("[name=\"code\"]", text9);
								B82DF423.method_40(1.0);
								B82DF423.method_16("#submit_code_button");
								B82DF423.method_40(2.0);
							}
						}
						else if (B82DF423.CD003D3F("[href^=\"otpauth://totp/ID:\"]"))
						{
							text5 = "[href^=\"otpauth://totp/ID:\"]";
							for (int i = 0; i < 3; i++)
							{
								text4 = B82DF423.BEA5E4BB("return document.querySelector('" + text5 + "').href.match(new RegExp('secret=(.*?)&'))[1]").ToString().Replace(" ", "");
								if (text4 != "")
								{
									break;
								}
								B82DF423.method_11();
								B82DF423.method_40(2.0);
							}
							if (text4 == "")
							{
								break;
							}
							B82DF423.method_19("#qr_confirm_button");
						}
						else if (B82DF423.CD003D3F("[href*=\"/security/2fac/setup/qrcode/generate/\"]"))
						{
							text5 = "[href*=\"/security/2fac/setup/qrcode/generate/\"]";
							string value2 = Regex.Match(B82DF423.method_9(), "https://(.*?)facebook.com").Value;
							string text10 = B82DF423.method_4(text5, "href");
							if (!text10.StartsWith("http"))
							{
								text10 = value2 + text10;
							}
							B82DF423.method_10(text10);
						}
						else
						{
							text = B82DF423.method_9();
							if (text.Contains("1501092823525282") || text.Contains("828281030927956") || text.Contains("465803052217681") || (text.Contains("facebook.com/nt/screen/?params=") && text.Contains("checkpoint")))
							{
								goto IL_063b;
							}
							if (B82DF423.CD003D3F("#MComposer"))
							{
								if (text4 != "")
								{
									F0A99AA5(int_4, "cFa2", text4, "fa2");
								}
								return true;
							}
							if (B82DF423.CD003D3F(text3))
							{
								B82DF423.method_16(text3);
							}
							else
							{
								B82DF423.method_19(text5);
							}
						}
					}
					else if (B82DF423.CD003D3F("[href=\"/\"]"))
					{
						if (num >= num2)
						{
							break;
						}
						num++;
						B82DF423.method_12();
					}
					else if (B82DF423.method_127())
					{
						goto IL_063b;
					}
					B82DF423.method_40(2.0);
				}
				while (Environment.TickCount - tickCount < 300000);
			}
			FD062316(int_4, "Checkpoint: Bật 2FA");
			A1BF1713(int_4, F6375029 + "Checkpoint: Bật 2FA");
			return false;
		}
		string text11 = "[name=\"password_new\"]";
		bool flag;
		string text12;
		if (B82DF423.CD003D3F(text11))
		{
			flag = false;
			text12 = "";
			string text13 = "[name=\"password_old\"]";
			string text14 = "[name=\"password_confirm\"]";
			if (B82DF423.CD003D3F(text13))
			{
				if (text2 == "")
				{
					goto IL_05e6;
				}
				B82DF423.method_20(text13, text2);
				B82DF423.method_40(1.0);
			}
			text12 = GClass8.smethod_52(10);
			B82DF423.method_20(text11, text12);
			B82DF423.method_40(1.0);
			B82DF423.method_20(text14, text12);
			B82DF423.method_40(1.0);
			B82DF423.method_60();
			B82DF423.method_24(text14);
			int tickCount2 = Environment.TickCount;
			int num3 = 30;
			while (true)
			{
				if (!B82DF423.BB1DB70A(0) && B82DF423.CD003D3F(text11))
				{
					if ((B82DF423.CD003D3F(text11) && B82DF423.method_5(text11) == "") || Environment.TickCount - tickCount2 > num3 * 1000)
					{
						break;
					}
					B82DF423.method_40(1.0);
					continue;
				}
				flag = true;
				break;
			}
			goto IL_05e6;
		}
		goto IL_063b;
		IL_063b:
		string text15 = "";
		int num4 = 0;
		if (bool_2 && B82DF423.CD003D3F("[href*=\"facebook.com/secure_account_learn_more\"]"))
		{
			bool flag2;
			if (flag2 = method_27(B82DF423, int_4, F6375029))
			{
				FD062316(int_4, "Live");
				A1BF1713(int_4, "Unlock checkpoint success!");
			}
			method_62(int_4, (!flag2) ? 1 : 2);
			return flag2;
		}
		if (B82DF423.CD003D3F("#checkpointButtonGetStarted-actual-button"))
		{
			B82DF423.method_10("https://d.facebook.com/");
			string text16 = GClass8.smethod_51(6) + GClass8.smethod_52(4) + GClass8.smethod_51(5);
			if (GClass25.smethod_0("configGeneral").method_2("typePass") == 0)
			{
				text16 = GClass25.smethod_0("configGeneral").C0288288("txtPass").A3A66D03(2);
			}
			bool flag3 = false;
			int tickCount3 = Environment.TickCount;
			int num5 = 300;
			while (true)
			{
				string text17 = B82DF423.method_13(0.0, new List<string> { "[value=\"someone_accessed\"]", "[name=\"submit[Get Started]\"]", "[name=\"submit[Continue]\"]", "[name=\"new_cp\"]", "[name=\"code\"]", "[name=\"submit[Go to News Feed]\"]" });
				switch (text17)
				{
				case "[value=\"someone_accessed\"]":
					B82DF423.method_19(text17);
					B82DF423.method_40(1.0);
					B82DF423.method_16("[type=\"submit\"]");
					break;
				case "[name=\"submit[Continue]\"]":
					if (B82DF423.CD003D3F("[name=\"password_new\"]"))
					{
						B82DF423.method_20("[name=\"password_new\"]", text16);
						B82DF423.method_40(1.0);
						method_59(B82DF423.String_1, "pass", int_4, "cPassword", text16);
						B82DF423.String_3 = text16;
						if (B82DF423.CD003D3F("[name=\"password_confirm\"]"))
						{
							B82DF423.method_20("[name=\"password_confirm\"]", text16);
							B82DF423.method_40(1.0);
						}
						if (B82DF423.CD003D3F("[name=\"password_old\"]"))
						{
							if (flag3 && B82DF423.BEA5E4BB("return document.querySelector('[name=\"password_old\"]').value;").ToString() == "")
							{
								method_59(B82DF423.String_1, "pass", int_4, "cPassword", text2);
								B82DF423.String_3 = text2;
								FD062316(int_4, "Changed pass");
								A1BF1713(int_4, F6375029 + F7AB102E.smethod_0("Mật khẩu không đúng!"));
								return false;
							}
							flag3 = true;
							B82DF423.method_20("[name=\"password_old\"]", B82DF423.String_3);
							B82DF423.method_40(1.0);
						}
						B82DF423.method_16(text17);
					}
					else
					{
						B82DF423.method_16(text17);
					}
					break;
				case "[name=\"submit[Get Started]\"]":
					B82DF423.method_16(text17);
					B82DF423.method_40(2.0);
					B82DF423.method_31("[name=\"submit[Continue]\"][disabled]", 30);
					break;
				case "[name=\"submit[Go to News Feed]\"]":
					B82DF423.method_16(text17);
					FD062316(int_4, "Live");
					A1BF1713(int_4, "Đăng nhập thành công!");
					return true;
				}
				if (Environment.TickCount - tickCount3 > num5 * 1000)
				{
					break;
				}
				B82DF423.method_40(2.0);
			}
		}
		text = B82DF423.method_9();
		if (B82DF423.method_9().Contains("checkpoint/disabled"))
		{
			text15 = "vhh";
		}
		else if (text.Contains("facebook.com/si/actor_experience/actor_gateway/nt") && B82DF423.AFABF4B7(text) != 3)
		{
			B82DF423.method_10("https://d.facebook.com/");
			if (!B82DF423.method_9().Contains("checkpoint/disabled"))
			{
				goto IL_0cd3;
			}
			text15 = "vhh";
		}
		else
		{
			if (text.Contains("828281030927956"))
			{
				goto IL_0cd3;
			}
			if (B82DF423.CD003D3F("#SupportFormRow\\\\.382907505152522"))
			{
				text15 = "Change name";
			}
			else
			{
				B82DF423.method_10(B82DF423.method_9().Replace("www", "m").Replace("mbasic", "m")
					.Replace("d", "m"));
				if (!B82DF423.method_9().Contains("checkpoint/disabled"))
				{
					if (B82DF423.AFABF4B7() != 2)
					{
						B82DF423.method_10("https://m.facebook.com/");
					}
					goto IL_0cd3;
				}
				text15 = "vhh";
			}
		}
		goto IL_0f8a;
		IL_0f8a:
		FD062316(int_4, "Checkpoint: " + text15);
		A1BF1713(int_4, F6375029 + "Checkpoint: " + text15);
		return false;
		IL_0cd3:
		while (true)
		{
			num4++;
			text = B82DF423.method_9();
			if (!text.Contains("facebook.com/si/actor_experience/actor_gateway/nt") || B82DF423.AFABF4B7(text) != 3)
			{
				if (!text.Contains("checkpoint/disabled"))
				{
					if (!text.Contains("1501092823525282"))
					{
						if (!text.Contains("828281030927956"))
						{
							if (!B82DF423.CD003D3F("[name=\"verification_method\"]"))
							{
								if (num4 == 1)
								{
									if (B82DF423.AFABF4B7() != 3)
									{
										B82DF423.method_10("https://d.facebook.com/");
									}
									continue;
								}
								string text18 = B82DF423.method_13(5.0, new List<string> { "[name=\"email\"]", "#checkpoint_title" });
								if (!(text18 == "[name=\"email\"]"))
								{
									if (text18 == "#checkpoint_title")
									{
										if (B82DF423.CD003D3F("[name=\"submit[Go to Support Inbox]\"]"))
										{
											B82DF423.method_16("[name=\"submit[Go to Support Inbox]\"]");
											B82DF423.method_40(2.0);
											B82DF423.method_12();
											B82DF423.method_40(2.0);
											continue;
										}
										if (B82DF423.CD003D3F("#checkpointSubmitButton>[name=\"submit[Yes]\"]"))
										{
											B82DF423.method_16("#checkpointSubmitButton>[name=\"submit[Yes]\"]");
											B82DF423.method_40(2.0);
											if (B82DF423.CD003D3F("[name=\"new_password\"],[name=\"password_new\"]"))
											{
												string text19 = GClass8.smethod_81();
												B82DF423.method_20("[name=\"new_password\"],[name=\"password_new\"]", text19);
												F0A99AA5(int_4, "cPassword", text19, "pass");
												B82DF423.String_3 = text19;
												B82DF423.method_40(1.0);
												B82DF423.method_60();
												if (B82DF423.CD003D3F("[name=\"new_password\"],[name=\"password_new\"]"))
												{
													B82DF423.method_24("[name=\"new_password\"],[name=\"password_new\"]");
												}
												B82DF423.BB1DB70A(30);
											}
											continue;
										}
										text15 = "login";
										break;
									}
									if (!Regex.IsMatch(B82DF423.C12B8625(), "/friends/") && !B82DF423.CD003D3F("a[href*='/friends/']") && !B82DF423.method_9().StartsWith("https://m.facebook.com/home.php"))
									{
										text15 = "unknow";
										break;
									}
									FD062316(int_4, "Live");
									A1BF1713(int_4, "Đăng nhập thành công!");
									return true;
								}
								text15 = "unknow";
								break;
							}
							List<string> list = B82DF423.BEA5E4BB("var s='';document.getElementsByName('verification_method').forEach(element => {s+=element.value+'|'}); return s;").ToString().TrimEnd('|')
								.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries)
								.ToList();
							for (int j = 0; j < list.Count; j++)
							{
								text15 = text15 + Class14.smethod_7(list[j]) + "-";
							}
							text15 = text15.TrimEnd('-');
							break;
						}
						if (bool_2)
						{
							text15 = "956";
							FD062316(int_4, "Checkpoint: " + text15);
							bool flag4 = false;
							if (int_5 == 1)
							{
								flag4 = method_26(B82DF423, int_4, F6375029);
							}
							if (int_5 == 2)
							{
								flag4 = C4944B32(B82DF423, int_4, F6375029);
							}
							if (flag4)
							{
								FD062316(int_4, "Live");
								A1BF1713(int_4, "Unlock checkpoint success!");
							}
							method_62(int_4, (!flag4) ? 1 : 2);
							return flag4;
						}
						if (B82DF423.C12B8625().Contains("/help/203305893040179"))
						{
							text15 = "956-Tìm hiểu thêm";
							break;
						}
						text15 = "956-Bắt đầu";
						B82DF423.method_9();
						int num6 = B82DF423.AFABF4B7();
						if (num6 != 3)
						{
							B82DF423.method_10("https://d.facebook.com/");
							B82DF423.method_40(2.0);
							if (!B82DF423.C12B8625().Contains("/x/checkpoint/828281030927956/stepper/"))
							{
								text15 = "956-Tìm hiểu thêm";
							}
						}
						break;
					}
					text15 = "282";
					string text20 = B82DF423.C12B8625();
					if (!text20.Contains("Chúng tôi đã nhận được thông tin của bạn") && !text20.Contains("bạn đã không tán thành với quyết định") && !text20.Contains("Đã yêu cầu xem xét"))
					{
						int num7 = method_23(B82DF423, B82DF423.C12B8625());
						if (num7 > 0)
						{
							text15 = "282" + ((num7 == -1) ? "" : $"-{num7} ngày");
						}
					}
					else
					{
						text15 = "282-Đợi xét duyệt!";
					}
					break;
				}
				text15 = "vhh";
				break;
			}
			text15 = "spam";
			break;
		}
		goto IL_0f8a;
		IL_05e6:
		if (flag)
		{
			method_59(B82DF423.String_1, "pass", int_4, "cPassword", text12);
			B82DF423.String_3 = text12;
			return true;
		}
		FD062316(int_4, "Checkpoint: Đổi pass");
		A1BF1713(int_4, F6375029 + "Checkpoint: Đổi pass");
		return false;
	}

	private bool method_26(GClass3 gclass3_0, int int_4, string string_1)
	{
		return false;
	}

	private bool method_27(GClass3 gclass3_0, int C32FE48C, string string_1)
	{
		string string_2 = method_60(C32FE48C, "cUid").ToLower();
		string text = method_60(C32FE48C, "cPassword");
		string BD15542D = method_60(C32FE48C, "cEmail").ToLower();
		string b40C6AA = method_60(C32FE48C, "cPassMail");
		string string_3 = method_60(C32FE48C, "cOAuth2");
		GClass3 gClass = new GClass3
		{
			Boolean_2 = true,
			D780F8B7 = GClass8.smethod_56(5, 2),
			B0B3B9A3 = new Point(-2000, 0),
			Boolean_3 = true,
			String_9 = "data:,"
		};
		A1BF1713(C32FE48C, string_1 + "Unlock checkpoint...");
		gclass3_0.method_52();
		if (gclass3_0.AFABF4B7() != 1)
		{
			gclass3_0.method_10("https://www.facebook.com");
		}
		string text2 = "";
		string text3 = "";
		int num = 0;
		int num2 = 3;
		bool result = false;
		int tickCount = Environment.TickCount;
		int num3 = 600000;
		while (true)
		{
			string text4 = gclass3_0.method_13(0.0, new List<string> { "#checkpointSubmitButton[name=\"submit[Continue]\"]", "#checkpointSubmitButton[name=\"submit[Yes]\"]", "[name=\"password_new\"]", "[href=\"/help/117450615006715\"]" });
			switch (text4)
			{
			case "#checkpointSubmitButton[name=\"submit[Continue]\"]":
				if (gclass3_0.CD003D3F("[name=\"verification_method\"]"))
				{
					List<string> list = gclass3_0.BEA5E4BB("var s='';document.getElementsByName('verification_method').forEach(element => {s+=element.value+'|'}); return s;").ToString().TrimEnd('|')
						.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries)
						.ToList();
					string text6 = "";
					for (int i = 0; i < list.Count; i++)
					{
						text6 = text6 + Class14.smethod_7(list[i]) + "-";
					}
					text6 = text6.TrimEnd('-');
					FD062316(C32FE48C, "Checkpoint: " + text6);
					if (!list.Contains("37"))
					{
						A1BF1713(C32FE48C, string_1 + "Checkpoint: " + text6);
						break;
					}
					if (BD15542D.IndexOf('@') <= 0)
					{
						A1BF1713(C32FE48C, "Unlock checkpoint fail (Mail không hợp lệ)!");
						break;
					}
					gclass3_0.method_19("[name=\"verification_method\"][value=\"37\"]");
					gclass3_0.method_16("#checkpointSubmitButton");
				}
				else
				{
					if (gclass3_0.CD003D3F("[name=\"send_code\"]"))
					{
						if (gclass3_0.CD003D3F("[name=\"captcha_response\"]"))
						{
							num++;
							if (num >= num2)
							{
								A1BF1713(C32FE48C, string_1 + F7AB102E.smethod_0("Không lấy được otp!"));
								return false;
							}
							string text7 = Class98.A1A49D95(1, BD15542D, b40C6AA, string_3, 60, string_2, text3);
							if (text7 == "fail" && text7 == "fail")
							{
								A1BF1713(C32FE48C, string_1 + F7AB102E.smethod_0("Không thể kết nối mail!"));
								return false;
							}
							if (text7 == "")
							{
								gclass3_0.method_16("[name=\"send_code\"]");
								goto IL_03b5;
							}
							gclass3_0.method_28("[name=\"captcha_response\"]");
							gclass3_0.method_20("[name=\"captcha_response\"]", text7);
							gclass3_0.method_40(1.0);
						}
						if (gclass3_0.CD003D3F("input[name=\"eindex\"]"))
						{
							List<string> list2 = gclass3_0.BEA5E4BB("arr = []; document.querySelectorAll('input[name=\"eindex\"]').forEach(e => arr.push(e.value)); return arr.join('|');").ToString().Split('|')
								.ToList();
							if (list2[0].Contains("@"))
							{
								string text8 = list2.Where((string string_0) => string_0.Contains(BD15542D.Substring(BD15542D.IndexOf('@') - 1, 3)) && string_0.StartsWith(BD15542D.Substring(0, 1)) && string_0.EndsWith(BD15542D.Substring(BD15542D.LastIndexOf('.')))).FirstOrDefault();
								if (string.IsNullOrEmpty(text8))
								{
									A1BF1713(C32FE48C, string_1 + F7AB102E.smethod_0("Fb bắt xác minh email không có trên tool") + "!");
									return false;
								}
								text3 = Class98.A1A49D95(1, BD15542D, b40C6AA, string_3, 0, string_2, "");
								if (text3 == "fail" && text3 == "fail")
								{
									A1BF1713(C32FE48C, string_1 + F7AB102E.smethod_0("Không thể kết nối mail!"));
									return false;
								}
								gclass3_0.method_19("input[name=\"eindex\"][value=\"" + text8 + "\"]");
								gclass3_0.method_40(1.0);
							}
						}
					}
					gclass3_0.method_16(text4);
				}
				goto IL_03b5;
			default:
			{
				string text5 = gclass3_0.method_9();
				if (!text5.Contains("828281030927956"))
				{
					if (!text5.Contains("1501092823525282"))
					{
						if (!text5.Contains("465803052217681"))
						{
							if (gclass3_0.method_46())
							{
								result = true;
								break;
							}
							goto IL_03b5;
						}
						FD062316(C32FE48C, "Checkpoint: login");
						A1BF1713(C32FE48C, string_1 + "Unlock checkpoint fail");
						break;
					}
					FD062316(C32FE48C, "Checkpoint: 282");
					A1BF1713(C32FE48C, string_1 + "Checkpoint: 282");
					break;
				}
				FD062316(C32FE48C, "Checkpoint: 956");
				A1BF1713(C32FE48C, string_1 + "Checkpoint 956!");
				method_62(C32FE48C, 1);
				break;
			}
			case "[name=\"password_new\"]":
				if (!(text2 != ""))
				{
					text2 = GClass8.smethod_81();
					if (gclass3_0.CD003D3F("[name=\"password_old\"]"))
					{
						gclass3_0.method_28("[name=\"password_old\"]");
						gclass3_0.method_20("[name=\"password_old\"]", text);
						gclass3_0.method_40(1.0);
					}
					gclass3_0.method_28(text4);
					gclass3_0.method_20(text4, text2);
					gclass3_0.method_40(1.0);
					gclass3_0.method_28("[name=\"password_confirm\"]");
					gclass3_0.method_20("[name=\"password_confirm\"]", text2);
					F0A99AA5(C32FE48C, "cPassword", text2, "pass");
					gclass3_0.String_3 = text2;
					gclass3_0.method_16("#checkpointSubmitButton[name=\"submit[Next]\"]");
					goto IL_03b5;
				}
				F0A99AA5(C32FE48C, "cPassword", text, "pass");
				gclass3_0.String_3 = text;
				A1BF1713(C32FE48C, "Unlock checkpoint fail (Lỗi đổi pass mới)!");
				break;
			case "#checkpointSubmitButton[name=\"submit[Yes]\"]":
				gclass3_0.method_16(text4);
				goto IL_03b5;
			case "[href=\"/help/117450615006715\"]":
				{
					FD062316(C32FE48C, "Checkpoint: login");
					A1BF1713(C32FE48C, "Unlock checkpoint fail (Không phương thức giải)!");
					break;
				}
				IL_03b5:
				if (Environment.TickCount - tickCount < num3)
				{
					goto IL_03c9;
				}
				A1BF1713(C32FE48C, "Unlock checkpoint fail (Timeout)!");
				break;
			}
			break;
			IL_03c9:
			gclass3_0.method_40(2.0);
			gclass3_0.method_31("#checkpointSubmitButton[disabled]", 30);
		}
		gclass3_0.method_53();
		gClass.B7841719();
		return result;
	}

	private bool C4944B32(GClass3 gclass3_0, int E885B2B5, string D525A996)
	{
		string string_ = method_60(E885B2B5, "cUid").ToLower();
		string text = method_60(E885B2B5, "cEmail").ToLower();
		string string_2 = method_60(E885B2B5, "cPassMail");
		string text2 = method_60(E885B2B5, "cBirthday");
		string text3 = "";
		string text4 = "";
		string text5 = "";
		int num = 0;
		A1BF1713(E885B2B5, D525A996 + "Unlock 956...");
		gclass3_0.method_48();
		gclass3_0.method_52();
		gclass3_0.method_10("https://facebook.com/");
		string text6 = "";
		string text7 = "";
		int num2 = 0;
		int num3 = 3;
		bool result = false;
		int tickCount = Environment.TickCount;
		int num4 = 600000;
		while (true)
		{
			string text8 = gclass3_0.method_9();
			if (!text8.Contains("1501092823525282"))
			{
				string text9 = gclass3_0.method_13(3.0, new List<string> { "[role=\"progressbar\"]", "[aria-label=\"Close\"]", "[aria-label=\"Next\"]", "[aria-label=\"Get started\"],[aria-label=\"Get Started\"],[aria-label=\"Start security steps\"]", "[aria-label=\"Get code\"]", "[aria-label=\"Type or paste code\"]", "[aria-label=\"Enter new password\"]", "[aria-label=\"Back to Facebook\"]" });
				string text10 = text9;
				string text11 = text10;
				uint num5 = C43AF739.smethod_0(text11);
				if (num5 <= 2009751771)
				{
					if (num5 <= 361401288)
					{
						if (num5 != 171915157)
						{
							if (num5 != 361401288 || !(text11 == "[aria-label=\"Close\"]"))
							{
								goto IL_069c;
							}
							if (gclass3_0.CD003D3F("[href*=\"facebook.com/help/contact/571927962827151\"]"))
							{
								A1BF1713(E885B2B5, "Checkpoint: 956 (fb block)");
								FD062316(E885B2B5, "Checkpoint: 956 (fb block)");
								break;
							}
							gclass3_0.method_19(text9);
						}
						else
						{
							if (!(text11 == "[aria-label=\"Type or paste code\"]"))
							{
								goto IL_069c;
							}
							num2++;
							if (num2 >= num3)
							{
								A1BF1713(E885B2B5, D525A996 + F7AB102E.smethod_0("Không lấy được otp!"));
								return false;
							}
							string text12 = method_28(1, text, string_2, 60, string_, text6);
							if (text12 == "fail")
							{
								A1BF1713(E885B2B5, D525A996 + F7AB102E.smethod_0("Không thể kết nối mail!"));
								return false;
							}
							if (text12 == "")
							{
								gclass3_0.method_19("//*[contains(text(),\"Resend code\")]");
							}
							else
							{
								gclass3_0.method_28("input[type=\"text\"]");
								gclass3_0.method_20("input[type=\"text\"]", text12);
								gclass3_0.method_40(1.0);
								gclass3_0.method_16("[aria-label=\"Submit\"]");
							}
						}
					}
					else if (num5 != 1880862350)
					{
						if (num5 != 2009751771 || !(text11 == "[aria-label=\"Enter new password\"]"))
						{
							goto IL_069c;
						}
						string text13 = "";
						string text14 = "";
						for (int i = 0; i < 5; i++)
						{
							if (!(text13 != ""))
							{
								goto IL_033a;
							}
							gclass3_0.method_19("[aria-label=\"Save changes\"],[aria-label=\"Confirm password\"]");
							bool flag = false;
							int num6 = 0;
							while (true)
							{
								if (num6 < 60)
								{
									if (!gclass3_0.CD003D3F("//*[contains(text(),\"Your new login\")]"))
									{
										if (gclass3_0.CD003D3F("//*[contains(text(),\"Error performing query\")]") || gclass3_0.CD003D3F("//*[contains(text(),\"Something went wrong\")]"))
										{
											break;
										}
										if (!gclass3_0.CD003D3F("[aria-label=\"Close\"]"))
										{
											gclass3_0.method_40(1.0);
											num6++;
											continue;
										}
										gclass3_0.method_16("[aria-label=\"Close\"]");
									}
									else
									{
										flag = true;
									}
								}
								if (!flag)
								{
									goto IL_033a;
								}
								goto IL_08e6;
							}
							goto IL_09a4;
							IL_033a:
							if (!(text14 != gclass3_0.BEA5E4BB("return document.documentElement.innerText;").ToString()))
							{
								continue;
							}
							if (!gclass3_0.method_9().Contains("1501092823525282"))
							{
								text13 = GClass8.smethod_81();
								gclass3_0.method_28("input[type=\"password\"]");
								gclass3_0.method_20("input[type=\"password\"]", text13);
								F0A99AA5(E885B2B5, "cPassword", text13, "pass");
								gclass3_0.String_3 = text13;
								gclass3_0.method_40(1.0);
								text14 = gclass3_0.BEA5E4BB("return document.documentElement.innerText;").ToString();
								continue;
							}
							goto IL_09c6;
						}
					}
					else if (!(text11 == "[role=\"progressbar\"]"))
					{
						goto IL_069c;
					}
				}
				else
				{
					if (num5 > 3945430151u)
					{
						if (num5 != 4110097059u)
						{
							if (num5 == 4257646734u && text11 == "[aria-label=\"Back to Facebook\"]")
							{
								if (gclass3_0.method_46())
								{
									result = true;
								}
								else
								{
									A1BF1713(E885B2B5, "Unlock checkpoint fail (1)!");
								}
								break;
							}
						}
						else if (text11 == "[aria-label=\"Get started\"],[aria-label=\"Get Started\"],[aria-label=\"Start security steps\"]")
						{
							if (!gclass3_0.C439D0A9("help us confirm your identity"))
							{
								gclass3_0.method_19(text9);
								goto IL_08e6;
							}
							text7 = text7 + ((text7 == "") ? "" : "-") + "Identity";
							A1BF1713(E885B2B5, "Checkpoint: 956 (" + text7 + ")");
							FD062316(E885B2B5, "Checkpoint: 956 (" + text7 + ")");
							break;
						}
						goto IL_069c;
					}
					if (num5 != 2281100875u)
					{
						if (num5 != 3945430151u || !(text11 == "[aria-label=\"Get code\"]"))
						{
							goto IL_069c;
						}
						string text15 = text.Substring(text.IndexOf('@') - 1, 3);
						if (!gclass3_0.CD003D3F("//*[contains(text(),\"" + text15 + "\")]"))
						{
							A1BF1713(E885B2B5, D525A996 + F7AB102E.smethod_0("Fb bắt xác minh email không có trên tool") + "!");
							return false;
						}
						text6 = method_28(1, text, string_2, 0, string_, "");
						if (text6 == "fail")
						{
							A1BF1713(E885B2B5, D525A996 + F7AB102E.smethod_0("Không thể kết nối mail!"));
							return false;
						}
						gclass3_0.method_19("//*[contains(text(),\"" + text15 + "\")]");
						gclass3_0.method_40(1.0);
						gclass3_0.method_19(text9);
					}
					else
					{
						if (!(text11 == "[aria-label=\"Next\"]"))
						{
							goto IL_069c;
						}
						if (gclass3_0.CD003D3F("//*[text()=\"Enter your birthday\" or text()=\"Enter your date of birth\"]"))
						{
							if (text2 == "" || text2.Split('/').Length < 3)
							{
								A1BF1713(E885B2B5, "Checkpoint ngày sinh (Không có ngày sinh)!");
								break;
							}
							num++;
							if (num == 1)
							{
								text3 = text2.Split('/')[1];
								text4 = text2.Split('/')[0];
								text5 = text2.Split('/')[2];
							}
							else
							{
								if (num != 2)
								{
									A1BF1713(E885B2B5, "Checkpoint ngày sinh (Sai ngày sinh)!");
									break;
								}
								text3 = text2.Split('/')[0];
								text4 = text2.Split('/')[1];
								text5 = text2.Split('/')[2];
							}
							if (text3.Length == 1)
							{
								text3 = "0" + text3;
							}
							if (text4.Length == 1)
							{
								text4 = "0" + text4;
							}
							gclass3_0.method_28("[aria-label=\"day\"] input[type=\"text\"]");
							gclass3_0.method_20("[aria-label=\"day\"] input[type=\"text\"]", text3);
							gclass3_0.method_40(1.0);
							gclass3_0.method_28("[aria-label=\"month\"] input[type=\"text\"]");
							gclass3_0.method_20("[aria-label=\"month\"] input[type=\"text\"]", text4);
							gclass3_0.method_40(1.0);
							gclass3_0.method_28("[aria-label=\"year\"] input[type=\"text\"]");
							gclass3_0.method_20("[aria-label=\"year\"] input[type=\"text\"]", text5);
							gclass3_0.method_40(1.0);
						}
						gclass3_0.method_19(text9);
					}
				}
				goto IL_08e6;
			}
			FD062316(E885B2B5, "Checkpoint: 282");
			A1BF1713(E885B2B5, D525A996 + "Checkpoint: 282");
			break;
			IL_08e6:
			if (Environment.TickCount - tickCount < num4)
			{
				gclass3_0.method_40(2.0);
				continue;
			}
			A1BF1713(E885B2B5, "Unlock checkpoint fail (Timeout)!");
			GClass8.BFBDF687(gclass3_0, null, "Unlock 956");
			break;
			IL_09c6:
			FD062316(E885B2B5, "Checkpoint: 282");
			A1BF1713(E885B2B5, D525A996 + "Checkpoint: 282");
			break;
			IL_09a4:
			if (gclass3_0.method_46())
			{
				result = true;
			}
			else
			{
				A1BF1713(E885B2B5, "Unlock checkpoint fail (3)!");
			}
			break;
			IL_069c:
			if (gclass3_0.CD003D3F("//*[contains(text(),\"verification challenge\")]"))
			{
				if (gclass3_0.BEA5E4BB("return document.querySelector('input[type=\"text\"]').value+'';").ToString() != "")
				{
					gclass3_0.method_11();
				}
				else
				{
					int num7 = GClass25.smethod_0("configCheckpoint").method_2("typeCaptcha");
					string text16 = GClass25.smethod_0("configCheckpoint").C0288288("txtCaptcha_" + num7);
					if (text16 == "" && !GClass24.smethod_2(GClass25.smethod_0("configCheckpoint").C0288288("txtCaptcha_4")))
					{
						A1BF1713(E885B2B5, "Facebook bắt giải captcha!");
						break;
					}
					string text17 = gclass3_0.BEA5E4BB("var img=document.querySelector('[src*=\"/captcha/tfbimage/\"]');var d=document.createElement('canvas');d.height=70;d.width=280;var ctx=d.getContext('2d');ctx.drawImage(img,0,0);var x=d.toDataURL(); return x").ToString().Replace("data:image/png;base64,", "");
					if (text17 == "")
					{
						gclass3_0.method_11();
					}
					else
					{
						string text18 = DABBB41F.D390252C(num7, text16, text17);
						if (text18 != "")
						{
							gclass3_0.method_20("input[type=\"text\"]", text18);
							gclass3_0.method_40(1.0);
							gclass3_0.method_16("[aria-label=\"Confirm\"]");
						}
						else
						{
							gclass3_0.method_11();
						}
					}
				}
			}
			else
			{
				if (gclass3_0.CD003D3F("//*[text()=\"No longer available\"]"))
				{
					A1BF1713(E885B2B5, "Không có phương thức giải!");
					break;
				}
				if (!gclass3_0.CD003D3F("//*[contains(text(),\"t remove anything\") or contains(text(),\"t Remove Anything\")]"))
				{
					if (gclass3_0.CD003D3F("//*[text()=\"Enter your birthday\" or text()=\"Enter your date of birth\"]"))
					{
						text7 = "Birthday";
						if (text2.Split('/').Length == 3)
						{
							gclass3_0.method_19("//*[text()=\"Enter your birthday\" or text()=\"Enter your date of birth\"]");
							goto IL_08e6;
						}
					}
					if (gclass3_0.CD003D3F("//*[text()=\"Get a code by email\"]"))
					{
						text7 = text7 + ((text7 == "") ? "" : "-") + "Otp mail";
						if (text != "")
						{
							gclass3_0.method_19("//*[text()=\"Get a code by email\"]");
							goto IL_08e6;
						}
					}
					if (gclass3_0.CD003D3F("//*[text()=\"Confirm your identity\"]"))
					{
						text7 = text7 + ((text7 == "") ? "" : "-") + "Identity";
					}
					if (gclass3_0.CD003D3F("//*[text()=\"Get a code on your phone\"]"))
					{
						text7 = text7 + ((text7 == "") ? "" : "-") + "Phone";
					}
					if (gclass3_0.CD003D3F("//*[text()=\"Verify your credit card\"]"))
					{
						text7 = text7 + ((text7 == "") ? "" : "-") + "Verify card";
					}
					if (text7 != "")
					{
						A1BF1713(E885B2B5, "Checkpoint: 956 (" + text7 + ")");
						FD062316(E885B2B5, "Checkpoint: 956 (" + text7 + ")");
					}
					else if (gclass3_0.method_46())
					{
						result = true;
					}
					else
					{
						A1BF1713(E885B2B5, "Unlock checkpoint fail (2)!");
					}
					break;
				}
				gclass3_0.method_19("//*[contains(text(),\"t remove anything\") or contains(text(),\"t Remove Anything\")]");
			}
			goto IL_08e6;
		}
		gclass3_0.method_53();
		return result;
	}

	private string method_28(int int_4, string string_1, string string_2, int int_5, string string_3, string EF89F214)
	{
		return "";
	}

	private void AB2FBD3B(GClass3 gclass3_0)
	{
		try
		{
			gclass3_0.method_10("https://m.facebook.com/settings/how_people_find_and_contact_you/");
			gclass3_0.method_40(1.0);
			if (!gclass3_0.CD003D3F("[data-store*=\"8787365733\"]", 15.0))
			{
				return;
			}
			gclass3_0.method_16("[data-store*=\"8787365733\"]");
			gclass3_0.method_40(1.0);
			if (gclass3_0.CD003D3F("[name=\"privacyx\"]", 15.0))
			{
				if (!gclass3_0.method_16("[name=\"privacyx\"]"))
				{
					gclass3_0.BEA5E4BB("document.querySelector('[name=\"privacyx\"]').click()");
				}
				gclass3_0.method_40(3.0);
			}
		}
		catch
		{
		}
	}

	private void DC0F7A13(GClass3 gclass3_0)
	{
		try
		{
			gclass3_0.method_10("https://m.facebook.com/settings/how_people_find_and_contact_you/");
			gclass3_0.method_40(1.0);
			if (gclass3_0.CD003D3F("[data-store*=\"8787540733\"]", 20.0))
			{
				gclass3_0.method_16("[data-store*=\"8787540733\"]");
				gclass3_0.method_40(1.0);
				if (gclass3_0.CD003D3F("[name=\"privacyx\"]", 15.0))
				{
					if (!gclass3_0.method_16("[name=\"privacyx\"]"))
					{
						gclass3_0.BEA5E4BB("document.querySelector('[name=\"privacyx\"]').click()");
					}
					gclass3_0.method_40(3.0);
				}
			}
			gclass3_0.method_10("https://m.facebook.com/settings/framework/msite/posts/?entry_point=unknown");
			gclass3_0.method_40(1.0);
			if (gclass3_0.CD003D3F("#root [role=\"button\"]", 15.0))
			{
				gclass3_0.method_16("#root [role=\"button\"]");
				gclass3_0.method_40(1.0);
				if (gclass3_0.CD003D3F("[name=\"privacyx\"]", 15.0))
				{
					if (!gclass3_0.method_16("[name=\"privacyx\"]"))
					{
						gclass3_0.BEA5E4BB("document.querySelector('[name=\"privacyx\"]').click()");
					}
					gclass3_0.method_40(3.0);
				}
			}
			gclass3_0.method_10("https://m.facebook.com/privacy/touch/timeline_and_tagging");
			gclass3_0.method_40(1.0);
			if (gclass3_0.CD003D3F("[data-store*=\"10153940308610734\"]", 15.0))
			{
				gclass3_0.method_16("[data-store*=\"10153940308610734\"]");
				gclass3_0.method_40(1.0);
				if (gclass3_0.CD003D3F("[data-store*=\"286958161406148\"]", 15.0))
				{
					if (!gclass3_0.method_16("[data-store*=\"286958161406148\"]"))
					{
						gclass3_0.BEA5E4BB("document.querySelector('[data-store*=\"286958161406148\"]').click()");
					}
					gclass3_0.method_40(3.0);
				}
			}
			gclass3_0.method_10("https://m.facebook.com/privacy/touch/timeline_and_tagging");
			if (gclass3_0.CD003D3F("[data-store*=\"8787530733\"]", 15.0))
			{
				gclass3_0.method_16("[data-store*=\"8787530733\"]");
				gclass3_0.method_40(1.0);
				if (gclass3_0.CD003D3F("[value=\"286958161406148\"]", 15.0))
				{
					gclass3_0.BE358C3C("[value=\"286958161406148\"]");
					gclass3_0.method_40(3.0);
				}
			}
		}
		catch
		{
		}
	}

	private int method_29(GClass3 B038F32A, int D1A05A0D)
	{
		int result = 1;
		string string_ = method_60(D1A05A0D, "cPassword");
		try
		{
			B038F32A.method_10("https://m.facebook.com/login_alerts/settings/");
			method_31();
			for (int i = 0; i < 2; i++)
			{
				if (!B038F32A.CD003D3F("article [data-sigil=\"touchable\"] a", 5.0))
				{
					continue;
				}
				B038F32A.method_16("article [data-sigil=\"touchable\"] a|" + i);
				B038F32A.method_40(1.0);
				if (B038F32A.CD003D3F("fieldset label:nth-child(1) [checked=\"1\"]", 5.0))
				{
					B038F32A.method_16("fieldset label:nth-child(1)");
					B038F32A.method_40(1.0);
					B038F32A.method_16("[type=\"submit\"]");
					B038F32A.method_40(1.0);
					if (B038F32A.CD003D3F("[type=\"password\"]", 5.0))
					{
						B038F32A.method_20("[type=\"password\"]", string_);
						method_31();
						B038F32A.method_16("[type=\"submit\"]");
						method_31();
					}
				}
			}
		}
		catch
		{
		}
		return result;
	}

	private void method_30(GClass3 C0ACC201, string string_1, int B116E797)
	{
		try
		{
			if (C0ACC201 != null)
			{
				string text = GClass28.smethod_0() + "\\log_capture";
				switch (B116E797)
				{
				case 0:
					text += "\\checkpoint";
					break;
				case 1:
					text += "\\loginfail";
					break;
				case 2:
					text += "\\disconnect";
					break;
				}
				GClass8.smethod_32(text);
				C0ACC201.method_33(text, string_1);
				File.WriteAllText(text + "\\" + string_1 + ".txt", C0ACC201.method_9());
				File.WriteAllText(text + "\\" + string_1 + ".html", C0ACC201.C12B8625());
			}
		}
		catch
		{
		}
	}

	private void CFBAAA89(GClass3 gclass3_0)
	{
		try
		{
			if (!gclass3_0.method_85())
			{
				gclass3_0.method_74(bool_9: false, E82BB1BF: true);
			}
		}
		catch
		{
		}
	}

	private void method_31(int int_4 = 0)
	{
		GClass8.smethod_53(Class57.random_0.Next(int_4 + 1, int_4 + 3));
	}

	private void method_32(string E225513F)
	{
		F5948F3E.Invoke((MethodInvoker)delegate
		{
			if (!F5948F3E.Visible)
			{
				F5948F3E.Visible = true;
			}
		});
		EF36EA35.Invoke((MethodInvoker)delegate
		{
			EF36EA35.Text = E225513F;
		});
	}

	private void method_33()
	{
		F5948F3E.Invoke((MethodInvoker)delegate
		{
			if (F5948F3E.Visible)
			{
				F5948F3E.Visible = false;
			}
		});
	}

	private void method_34(string string_1)
	{
		Invoke((MethodInvoker)delegate
		{
			try
			{
				if (string_1 == "start")
				{
					C3BBF8AC.Enabled = false;
					GClass27.E68A6883(EB3CF7AF, bool_0: false);
				}
				else if (string_1 == "stop")
				{
					C3BBF8AC.Enabled = true;
					GClass27.E68A6883(EB3CF7AF, bool_0: true);
				}
			}
			catch (Exception)
			{
			}
		});
	}

	private void CA2DE33A(object sender, KeyEventArgs e)
	{
		if (e.KeyValue == 32)
		{
			method_6("ToggleCheck");
		}
	}

	private void toolStripMenuItem_5_Click(object sender, EventArgs e)
	{
		CC348FB5(null, null);
	}

	private void D907633E(object sender, EventArgs e)
	{
		int selectedIndex = cbbThuMuc.SelectedIndex;
		if (GClass29.smethod_1(string.Format(F7AB102E.smethod_0("Bạn có thực sự muốn xóa thư mục [{0}] không?"), cbbThuMuc.Text)) == DialogResult.Yes)
		{
			if (Class15.smethod_3(cbbThuMuc.SelectedValue.ToString()))
			{
				GClass29.smethod_0(string.Format(F7AB102E.smethod_0("Xoá thành công thư mục [{0}] !"), cbbThuMuc.Text));
				AC37B195();
				cbbThuMuc.SelectedIndex = selectedIndex - 1;
			}
			else
			{
				GClass29.smethod_0(string.Format(F7AB102E.smethod_0("Không thể xóa thư mục [{0}] !"), cbbThuMuc.Text), 2);
			}
		}
	}

	private void BB10033A(object sender, EventArgs e)
	{
		if (!bool_0 || cbbThuMuc.SelectedValue == null || !E887EC9A.C323DB3B(cbbThuMuc.SelectedValue.ToString()) || (cbbThuMuc.SelectedValue.ToString() != "999999" && FD8F4B3F == cbbThuMuc.SelectedIndex))
		{
			return;
		}
		string text = cbbThuMuc.SelectedValue.ToString();
		string text2 = text;
		if (!(text2 == "-2"))
		{
			if (!(text2 == "999999"))
			{
				E78EEE83(EB221108());
			}
			else
			{
				GClass8.smethod_33(new fChonThuMuc());
				if (fChonThuMuc.bool_1 && fChonThuMuc.list_0 != null && fChonThuMuc.list_0.Count != 0)
				{
					E78EEE83(fChonThuMuc.list_0);
				}
				else
				{
					bool_0 = false;
					cbbThuMuc.SelectedIndex = ((FD8F4B3F == -1) ? 1 : FD8F4B3F);
					bool_0 = true;
				}
			}
		}
		else
		{
			E78EEE83();
		}
		FD8F4B3F = cbbThuMuc.SelectedIndex;
		if (cbbThuMuc.SelectedValue != null)
		{
			string text3 = cbbThuMuc.SelectedValue.ToString();
			if (!(text3 == "-2") && !(text3 == "999999"))
			{
				FA856528.BackColor = Color.White;
				FA856528.Enabled = true;
				btnEditFile.BackColor = Color.White;
				btnEditFile.Enabled = true;
			}
			else
			{
				FA856528.BackColor = Color.Gray;
				FA856528.Enabled = false;
				btnEditFile.BackColor = Color.Gray;
				btnEditFile.Enabled = false;
			}
		}
	}

	private void mailPassMailToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_7("cEmail|cPassMail");
	}

	private void uidPassTokenCookieMailPassMailToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_7("cUid|cPassword|cToken|cCookies|cEmail|cPassMail");
	}

	private void E280B5BE()
	{
		try
		{
			lblCountTotal.Text = EB3CF7AF.Rows.Count.ToString();
		}
		catch
		{
		}
	}

	public void E6042218(int int_4 = -1)
	{
		try
		{
			if (int_4 == -1)
			{
				int_4 = 0;
				for (int i = 0; i < EB3CF7AF.Rows.Count; i++)
				{
					if (Convert.ToBoolean(EB3CF7AF.Rows[i].Cells["cChose"].Value))
					{
						int_4++;
					}
				}
			}
			lblCountSelect.Text = int_4.ToString();
		}
		catch (Exception)
		{
		}
	}

	private void method_35(int CAAC3E1B, bool bool_2 = false)
	{
		int int_0 = 0;
		int int_1 = GClass25.smethod_0("configGeneral").method_2("nudHideThread", 10);
		GClass25.smethod_0("configGeneral").C0288288("token");
		Class57.A39EDD1D(bool_9: false);
		new Thread((ThreadStart)delegate
		{
			method_34("start");
			int num = 0;
			while (num < EB3CF7AF.Rows.Count && !Class57.smethod_5())
			{
				if (Convert.ToBoolean(EB3CF7AF.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int int_2 = num++;
						new Thread((ThreadStart)delegate
						{
							A1BF1713(int_2, F7AB102E.smethod_0("Đang kiểm tra..."));
							switch (CAAC3E1B)
							{
							case 0:
								method_39(int_2);
								break;
							case 1:
								C8168394(int_2);
								break;
							case 2:
								method_40(int_2);
								break;
							case 3:
								method_41(int_2);
								break;
							case 4:
								method_37(int_2);
								break;
							case 5:
								method_36(int_2, bool_2);
								break;
							case 6:
								method_42(int_2, bool_2);
								break;
							case 7:
								method_38(int_2);
								break;
							}
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
			while (int_0 > 0 && Environment.TickCount - tickCount <= 60000)
			{
				GClass8.smethod_53(1.0);
			}
			method_34("stop");
		}).Start();
	}

	private void method_36(int A0978716, bool F6B30009)
	{
		try
		{
			string b512372F = method_60(A0978716, "cId");
			string text = method_60(A0978716, "cUid");
			string text2 = "";
			int num = 0;
			if (F6B30009)
			{
				text2 = method_60(A0978716, "cProxy");
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
					A1BF1713(A0978716, F7AB102E.smethod_0("Tài khoản Die!"));
					FD062316(A0978716, "Die");
				}
				else
				{
					A1BF1713(A0978716, F7AB102E.smethod_0("Không check đươ\u0323c!"));
				}
			}
			else if (text4.StartsWith("1|"))
			{
				string[] array = text4.Split('|');
				string text5 = array[1];
				string text6 = array[2];
				string text7 = array[3];
				Class15.C888252E(b512372F, "name|friends|dateCreateAcc", text5 + "|" + text6 + "|" + text7);
				method_58(A0978716, "cName", text5);
				method_58(A0978716, "cFriend", text6);
				method_58(A0978716, "cDateCreateAcc", text7);
				FD062316(A0978716, "Live");
				text3 = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t thông tin tha\u0300nh công!");
				A1BF1713(A0978716, text3);
			}
			else
			{
				A1BF1713(A0978716, F7AB102E.smethod_0("Không check đươ\u0323c!"));
			}
		}
		catch
		{
			A1BF1713(A0978716, F7AB102E.smethod_0("Không check đươ\u0323c!"));
		}
	}

	private void method_37(int int_4)
	{
		try
		{
			string text = method_60(int_4, "cEmail");
			string text2 = method_60(int_4, "cPassMail");
			string f215712E = method_60(int_4, "cOAuth2");
			if (!(text == "") && !(text2 == ""))
			{
				if (GClass21.A3BD3C81(text, text2, f215712E))
				{
					A1BF1713(int_4, F7AB102E.smethod_0("Success!"));
					method_62(int_4, 2);
				}
				else
				{
					A1BF1713(int_4, F7AB102E.smethod_0("Fail!"));
					method_62(int_4, 1);
				}
			}
			else
			{
				A1BF1713(int_4, F7AB102E.smethod_0("Không tìm thấy mail!"));
			}
		}
		catch (Exception)
		{
			A1BF1713(int_4, F7AB102E.smethod_0("Lỗi!"));
		}
	}

	private void method_38(int BAA32E18)
	{
		try
		{
			string text = method_60(BAA32E18, "cName");
			string text2 = "";
			text2 = ((text.Trim() == "") ? F7AB102E.smethod_0("Không tìm thấy tên!") : ((!GClass8.smethod_68(text)) ? F7AB102E.smethod_0("No") : F7AB102E.smethod_0("Yes")));
			A1BF1713(BAA32E18, text2);
		}
		catch
		{
			A1BF1713(BAA32E18, F7AB102E.smethod_0("Không check đươ\u0323c!"));
		}
	}

	private void method_39(int int_4)
	{
		try
		{
			method_60(int_4, "cId");
			string cA02E40A = method_60(int_4, "cUid");
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
			A1BF1713(int_4, text2);
			if (text != "")
			{
				FD062316(int_4, text);
			}
		}
		catch
		{
			A1BF1713(int_4, F7AB102E.smethod_0("Không check đươ\u0323c!"));
		}
	}

	private void C8168394(int int_4)
	{
		try
		{
			string text = "";
			method_60(int_4, "cId");
			string text2 = method_60(int_4, "cCookies");
			string text3 = method_60(int_4, "cToken");
			if (text3.Trim() == "")
			{
				A1BF1713(int_4, F7AB102E.smethod_0("Token trô\u0301ng!"));
				return;
			}
			string a72F = method_60(int_4, "cUseragent").Trim();
			string text4 = "";
			int num = 0;
			if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 9)
			{
				text4 = method_60(int_4, "cProxy");
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
			A1BF1713(int_4, text5);
			if (text != "")
			{
				FD062316(int_4, text);
			}
		}
		catch
		{
			A1BF1713(int_4, F7AB102E.smethod_0("Không check đươ\u0323c!"));
		}
	}

	private void method_40(int int_4)
	{
		try
		{
			string text = "";
			method_60(int_4, "cId");
			string text2 = method_60(int_4, "cCookies");
			if (text2.Trim() == "")
			{
				A1BF1713(int_4, F7AB102E.smethod_0("Cookie trô\u0301ng!"));
				return;
			}
			string string_ = method_60(int_4, "cUseragent").Trim();
			string text3 = "";
			int bB8B = 0;
			if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 9)
			{
				text3 = method_60(int_4, "cProxy");
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
			A1BF1713(int_4, text4);
			if (text != "")
			{
				FD062316(int_4, text);
			}
		}
		catch
		{
			A1BF1713(int_4, F7AB102E.smethod_0("Không check đươ\u0323c!"));
		}
	}

	private void method_41(int D7ACB000)
	{
		EB3CF7AF.Rows[D7ACB000].Cells["cId"].Value.ToString();
		string text = method_60(D7ACB000, "cCookies");
		if (text.Trim() == "")
		{
			A1BF1713(D7ACB000, F7AB102E.smethod_0("Cookie trô\u0301ng!"));
			return;
		}
		method_60(D7ACB000, "cUseragent").Trim();
		string text2 = "";
		int int_ = 0;
		if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 9)
		{
			text2 = method_60(D7ACB000, "cProxy");
			int_ = (text2.EndsWith("*1") ? 1 : 0);
			if (text2.EndsWith("*0") || text2.EndsWith("*1"))
			{
				text2 = text2.Substring(0, text2.Length - 2);
			}
		}
		A1BF1713(D7ACB000, F7AB102E.smethod_0("Checking..."));
		method_22(D7ACB000, "", text, text2, int_);
	}

	private void C498B099_Click(object sender, EventArgs e)
	{
		method_35(0);
	}

	private void toolStripMenuItem_4_Click(object sender, EventArgs e)
	{
		if (GClass29.smethod_1("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?") == DialogResult.Yes)
		{
			method_35(1);
		}
	}

	private void toolStripMenuItem_3_Click(object sender, EventArgs e)
	{
		method_35(3);
	}

	private void mailToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_7("cEmail");
	}

	private void C0290281_Click(object sender, EventArgs e)
	{
		try
		{
			if (DC2BDDA5.SelectedIndex == -1)
			{
				GClass29.smethod_0("Vui lòng chọn kiểu tìm kiếm!", 3);
				return;
			}
			string columnName = DC2BDDA5.SelectedValue.ToString();
			string text = txbSearch.Text.Trim();
			if (text == "")
			{
				GClass29.smethod_0("Vui lòng nhập nội dung tìm kiếm!", 3);
				return;
			}
			List<int> list = new List<int>();
			text = GClass8.smethod_70(text.ToLower());
			for (int i = 0; i < EB3CF7AF.RowCount; i++)
			{
				string text2 = EB3CF7AF.Rows[i].Cells[columnName].Value.ToString();
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
				num = EB3CF7AF.CurrentRow.Index;
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
			EB3CF7AF.CurrentCell = EB3CF7AF.Rows[index2].Cells[columnName];
			EB3CF7AF.ClearSelection();
			EB3CF7AF.Rows[index2].Selected = true;
		}
		catch (Exception)
		{
		}
	}

	private void AB28FC9F_Click(object sender, EventArgs e)
	{
		if (Class57.smethod_3())
		{
			method_7("cUid|cPassword|cToken|cCookies|cEmail|cPassMail|cFa2");
		}
	}

	private void CA0EAB0F()
	{
		for (int i = 0; i < EB3CF7AF.RowCount; i++)
		{
			method_58(i, "cSTT", i + 1);
		}
	}

	private void fAToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Class57.smethod_3())
		{
			method_7("cFa2");
		}
	}

	private void toolStripMenuItem_19_Click(object sender, EventArgs e)
	{
		method_35(6);
	}

	private void method_42(int D52E5228, bool D186220A)
	{
		try
		{
			string text = "";
			int f8BA9D = 0;
			if (D186220A)
			{
				text = method_60(D52E5228, "cProxy");
				f8BA9D = (text.EndsWith("*1") ? 1 : 0);
				if (text.EndsWith("*0") || text.EndsWith("*1"))
				{
					text = text.Substring(0, text.Length - 2);
				}
			}
			string text2 = EB3CF7AF.Rows[D52E5228].Cells["cUid"].Value.ToString();
			switch (Class14.F4B2E309(text2, text, f8BA9D))
			{
			case "2":
				A1BF1713(D52E5228, F7AB102E.smethod_0("Không check được!"));
				break;
			case "1":
				A1BF1713(D52E5228, F7AB102E.smethod_0("Đa\u0303 co\u0301 avatar!"));
				F0A99AA5(D52E5228, "cAvatar", "Yes", "avatar");
				break;
			case "0":
				A1BF1713(D52E5228, F7AB102E.smethod_0("Không co\u0301 avatar!"));
				F0A99AA5(D52E5228, "cAvatar", "No", "avatar");
				break;
			}
		}
		catch
		{
			A1BF1713(D52E5228, "Lỗi!");
		}
	}

	private void method_43(object sender, EventArgs e)
	{
		int BE19539E = 0;
		int int_0 = GClass25.smethod_0("configGeneral").method_2("nudHideThread", 10);
		Class57.A39EDD1D(bool_9: false);
		new Thread((ThreadStart)delegate
		{
			method_34("start");
			int num = 0;
			while (num < EB3CF7AF.Rows.Count)
			{
				Application.DoEvents();
				if (Class57.smethod_5())
				{
					break;
				}
				if (Convert.ToBoolean(EB3CF7AF.Rows[num].Cells["cChose"].Value))
				{
					if (BE19539E < int_0)
					{
						Interlocked.Increment(ref BE19539E);
						int int_ = num++;
						new Thread((ThreadStart)delegate
						{
							A1BF1713(int_, F7AB102E.smethod_0("Đang kiểm tra..."));
							F01A3609(int_);
							Interlocked.Decrement(ref BE19539E);
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
			while (BE19539E > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			method_34("stop");
		}).Start();
	}

	private void F01A3609(int int_4)
	{
		string text = EB3CF7AF.Rows[int_4].Cells["cCookies"].Value.ToString();
		EB3CF7AF.Rows[int_4].Cells["cId"].Value.ToString();
		string string_ = method_60(int_4, "cUseragent").Trim();
		string text2 = "";
		int bB8B = 0;
		if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 9)
		{
			text2 = method_60(int_4, "cProxy");
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
		A1BF1713(int_4, text3);
	}

	private void locTrungToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			for (int i = 0; i < EB3CF7AF.RowCount; i++)
			{
				if (Convert.ToBoolean(EB3CF7AF.Rows[i].Cells["cChose"].Value))
				{
					string item = method_60(i, "cUid");
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
			DataTable dataTable = Class15.C52782A9(a6826E);
			dataTable.DefaultView.Sort = "uid ASC";
			dataTable = dataTable.DefaultView.ToTable();
			EB3CF7AF.Rows.Clear();
			method_5(dataTable);
		}
		catch (Exception)
		{
		}
	}

	private void toolStripMenuItem_21_Click(object sender, EventArgs e)
	{
		if (GClass29.smethod_1(string.Format(F7AB102E.smethod_0("Bạn có chắc muốn xóa Profile của {0} tài khoản?"), AB0B20AA())) != DialogResult.Yes)
		{
			return;
		}
		int int_0 = 0;
		int int_1 = GClass25.smethod_0("configGeneral").method_2("nudHideThread", 10);
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < EB3CF7AF.Rows.Count)
			{
				if (Convert.ToBoolean(EB3CF7AF.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int C6077038 = num++;
						new Thread((ThreadStart)delegate
						{
							A1BF1713(C6077038, F7AB102E.smethod_0("Đang xo\u0301a profile..."));
							CE90948F(C6077038);
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

	private void CE90948F(int int_4)
	{
		try
		{
			string e00DDFA = EB3CF7AF.Rows[int_4].Cells["cId"].Value.ToString();
			string text = EB3CF7AF.Rows[int_4].Cells["cUid"].Value.ToString();
			if (text.Trim() == "")
			{
				A1BF1713(int_4, F7AB102E.smethod_0("Chưa tạo profile!"));
				return;
			}
			string path = GClass25.smethod_0("configGeneral").C0288288("txbPathProfile") + "\\" + text;
			if (Directory.Exists(path))
			{
				Directory.Delete(path, recursive: true);
				A1BF1713(int_4, F7AB102E.smethod_0("Xóa profile thành công!"));
				method_58(int_4, "cProfile", "No");
				Class15.EB34450D(e00DDFA, "profile", "No");
			}
			else
			{
				A1BF1713(int_4, F7AB102E.smethod_0("Chưa tạo profile!"));
			}
		}
		catch
		{
			A1BF1713(int_4, F7AB102E.smethod_0("Xóa profile thất bại!"));
		}
	}

	private void checkProfileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		int int_0 = 0;
		int int_1 = 10;
		string FBB24EB5 = GClass25.smethod_2();
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < EB3CF7AF.RowCount)
			{
				if (Convert.ToBoolean(method_60(num, "cChose")))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int EF310B39 = num++;
						new Thread((ThreadStart)delegate
						{
							A1BF1713(EF310B39, "Check profile...");
							B08E7E97(EF310B39, FBB24EB5);
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

	private void B08E7E97(int int_4, string ACB5F399)
	{
		try
		{
			string e00DDFA = method_60(int_4, "cId");
			string text = method_60(int_4, "cUid");
			ACB5F399 = ACB5F399 + "\\" + text;
			if (Directory.Exists(ACB5F399))
			{
				A1BF1713(int_4, F7AB102E.smethod_0("Đã có profile!"));
				method_58(int_4, "cProfile", "Yes");
				Class15.EB34450D(e00DDFA, "profile", "Yes");
			}
			else
			{
				A1BF1713(int_4, F7AB102E.smethod_0("Chưa tạo profile!"));
				method_58(int_4, "cProfile", "No");
				Class15.EB34450D(e00DDFA, "profile", "No");
			}
		}
		catch
		{
		}
	}

	private void B005D087_Click(object sender, EventArgs e)
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

	private void pictureBox1_DoubleClick(object sender, EventArgs e)
	{
		GClass8.smethod_41("chrome");
	}

	private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
	{
	}

	private void uidPass2FaToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Class57.smethod_3())
		{
			method_7("cUid|cPassword|cFa2");
		}
	}

	private void C03D6297(object sender, EventArgs e)
	{
		GClass11 FE0C4A = new GClass11();
		GClass8.smethod_33(new fCauHinhChung(ref FE0C4A));
		if (FE0C4A.method_3("isChangePathDatabase"))
		{
			AC37B195();
			FD8F4B3F = -1;
			cbbThuMuc.SelectedIndex = -1;
			cbbThuMuc.SelectedIndex = 0;
		}
	}

	private void toolStripMenuItem_7_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = method_8("cUid|cPassword|cToken|cCookies|cEmail|cEmail2|cPassMail|cFa2|cUseragent|cProxy|cName|cGender|cFollow|cFriend|cGroup|cBirthday|cDateCreateAcc|cGhiChu|cLocation|cMailRecovery|cPassMailRecovery|cInteractEnd|cDating|cAds|cBM");
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

	private void C7861389(object sender, EventArgs e)
	{
		method_7("cMa2Fa");
	}

	private void E784828B_Click(object sender, EventArgs e)
	{
	}

	private void method_44(int int_4)
	{
		try
		{
			string b512372F = method_60(int_4, "cId");
			string text = method_60(int_4, "cCookies");
			method_60(int_4, "cToken");
			string string_ = method_60(int_4, "cUseragent").Trim();
			string text2 = "";
			int num = 0;
			if (GClass25.smethod_0("configGeneral").method_2("ip_iTypeChangeIp") == 9)
			{
				text2 = method_60(int_4, "cProxy");
				num = (text2.EndsWith("*1") ? 1 : 0);
				if (text2.EndsWith("*0") || text2.EndsWith("*1"))
				{
					text2 = text2.Substring(0, text2.Length - 2);
				}
			}
			string text3 = "";
			string text4 = "";
			if (text == "")
			{
				text3 = F7AB102E.smethod_0("Cookie trô\u0301ng");
			}
			else
			{
				string text5 = Class14.A2A4FE27(text, string_, text2, num);
				if (text5 == "-1")
				{
					text3 = "Cookie die";
				}
				else
				{
					string[] array = text5.Split('|');
					if (Convert.ToBoolean(array[0]))
					{
						text4 = "Live";
						Class15.C888252E(b512372F, "name|gender|birthday|friends|groups" + ((array[5] != "") ? "|email" : ""), array[1] + "|" + array[2] + "|" + array[3] + "|" + array[6] + "|" + array[7] + ((array[5] != "") ? ("|" + array[5]) : ""));
						method_58(int_4, "cName", array[1]);
						method_58(int_4, "cGender", array[2]);
						method_58(int_4, "cBirthday", array[3]);
						if (array[5] != "")
						{
							method_58(int_4, "cEmail", array[5]);
						}
						method_58(int_4, "cFriend", array[6]);
						method_58(int_4, "cGroup", array[7]);
						text3 = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t thông tin tha\u0300nh công!");
					}
					else
					{
						text4 = "Die";
						text3 = F7AB102E.smethod_0("Tài khoản die!");
					}
				}
			}
			A1BF1713(int_4, text3);
			if (text4 != "")
			{
				FD062316(int_4, text4);
			}
		}
		catch
		{
			A1BF1713(int_4, F7AB102E.smethod_0("Không check đươ\u0323c!"));
		}
	}

	private bool method_45(int int_4, string string_1)
	{
		try
		{
			string text = method_60(int_4, "cId");
			string text2 = method_60(int_4, "cUid");
			string text3 = "";
			string text4 = Class14.BD0DD421(text2, string_1);
			if (text4 == "-1")
			{
				A1BF1713(int_4, F7AB102E.smethod_0("Không check đươ\u0323c!"));
				return false;
			}
			string[] array = text4.Split('|');
			if (Convert.ToBoolean(array[0]))
			{
				Class15.C888252E(text, "name|gender", array[1] + "|" + array[2]);
				method_58(int_4, "cName", array[1]);
				method_58(int_4, "cGender", array[2]);
				if (array[6] != "")
				{
					method_58(int_4, "cFriend", array[6]);
					Class15.EB34450D(text, "friends", array[6]);
				}
				if (array[7] != "")
				{
					method_58(int_4, "cGroup", array[7]);
					Class15.EB34450D(text, "groups", array[7]);
				}
				FD062316(int_4, "Live");
				text3 = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t thông tin tha\u0300nh công!");
			}
			else
			{
				FD062316(int_4, "Die");
				text3 = F7AB102E.smethod_0("Tài khoản Die!");
			}
			A1BF1713(int_4, text3);
		}
		catch
		{
			A1BF1713(int_4, F7AB102E.smethod_0("Không check đươ\u0323c!"));
		}
		return true;
	}

	private void method_46(GClass3 EFBCA822, int int_4)
	{
		try
		{
			EFBCA822.method_48("vi_VN");
			EFBCA822.method_10("https://m.facebook.com/account_status");
			string text = EFBCA822.BEA5E4BB("return document.querySelector('[data-nt=\"NT:DECOR\"]').innerText.split('\\n').filter(e => e.includes('không thể'))[0]??''").ToString();
			if (text != "")
			{
				F0A99AA5(int_4, "cGhiChu", "(" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ") " + text, "ghiChu");
			}
		}
		catch (Exception)
		{
		}
	}

	private void B0A6BA0A(GClass3 gclass3_0, int F19499B8, string A98D330E, int int_4)
	{
		try
		{
			string a7A2882F = gclass3_0.method_37();
			string text = "";
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
			if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbName"))
			{
				text = "-";
			}
			if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbGender"))
			{
				text5 = "-";
			}
			if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbBirthday"))
			{
				text9 = "-";
			}
			if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbNgayTao"))
			{
				text13 = "-";
			}
			if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbEmail"))
			{
				text12 = "-";
			}
			if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbFriend"))
			{
				text2 = "-";
			}
			if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbGroup"))
			{
				text6 = "-";
			}
			if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbPage"))
			{
				text3 = "-";
			}
			if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbPagePro5"))
			{
				text4 = "-";
			}
			if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbFollow"))
			{
				text10 = "-";
			}
			if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbPhone"))
			{
				text14 = "-";
			}
			if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbHometown"))
			{
				text7 = "-";
			}
			if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbLocation"))
			{
				text8 = "-";
			}
			if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbAvatar"))
			{
				text16 = "-";
			}
			if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbDating"))
			{
				text11 = "-";
			}
			if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbAds"))
			{
				text15 = "-";
			}
			if (!GClass25.smethod_0("configInteractGeneral").method_3("ckbBM"))
			{
				text17 = "-";
			}
			string text18 = "";
			if (text16 == "")
			{
				string text19 = Class14.F4B2E309(a7A2882F);
				if (text19 == "0")
				{
					text16 = "No";
				}
				else if (text19 == "1")
				{
					text16 = "Yes";
				}
				F0A99AA5(F19499B8, "cAvatar", text16, "avatar", bool_2: false);
			}
			if (text == "" || text2 == "" || text13 == "")
			{
				string text20 = Class14.A61BB104(a7A2882F, A98D330E, int_4);
				if (text20.StartsWith("1|"))
				{
					string[] array = text20.Split('|');
					if (text == "")
					{
						text = array[1];
						F0A99AA5(F19499B8, "cName", text, "name", bool_2: false);
					}
					if (text2 == "")
					{
						text2 = array[2];
						if (text2 == "0")
						{
							text2 = "";
						}
						F0A99AA5(F19499B8, "cFriend", text2, "friends", bool_2: false);
					}
					if (text13 == "")
					{
						text13 = array[3];
						F0A99AA5(F19499B8, "cDateCreateAcc", text13, "dateCreateAcc", bool_2: false);
					}
				}
			}
			if (text14 == "" || text9 == "" || text5 == "")
			{
				if (!gclass3_0.method_9().StartsWith("https://mbasic.facebook.com/"))
				{
					gclass3_0.method_10("https://mbasic.facebook.com/");
				}
				if (text14 == "")
				{
					F0A99AA5(F19499B8, "cPhone", text14, "phone");
				}
				if (text9 == "" || text5 == "")
				{
					string text21 = gclass3_0.BEA5E4BB(GClass8.A2307E3B("YXN5bmMgZnVuY3Rpb24gUmVxdWVzdEdldCh1cmwpIHsKICAgIHZhciBvdXRwdXQgPSAnJzsKICAgIHRyeSB7CiAgICAgICAgdmFyIHJlc3BvbnNlID0gYXdhaXQgZmV0Y2godXJsKTsKICAgICAgICBpZiAocmVzcG9uc2Uub2spIHsKICAgICAgICAgICAgdmFyIGJvZHkgPSBhd2FpdCByZXNwb25zZS50ZXh0KCk7CiAgICAgICAgICAgIHJldHVybiBib2R5OwogICAgICAgIH0KICAgIH0gY2F0Y2ggeyB9CiAgICByZXR1cm4gb3V0cHV0Owp9OwoKdmFyIGh0bWwgPSBhd2FpdCBSZXF1ZXN0R2V0KCdodHRwczovL21iYXNpYy5mYWNlYm9vay5jb20vcHJvZmlsZS9lZGl0L2luZm90YWIvc2VjdGlvbi9mb3Jtcy8/c2VjdGlvbj1iYXNpYy1pbmZvJyk7Cmh0bWwgPSB1bmVzY2FwZShodG1sKS5yZXBsYWNlKC8mYW1wOy9nLCAnJicpCgp2YXIgZWwgPSBkb2N1bWVudC5jcmVhdGVFbGVtZW50KCdodG1sJyk7CmVsLmlubmVySFRNTCA9IGh0bWw7Cgp2YXIgYmlydGhkYXkgPSBlbC5xdWVyeVNlbGVjdG9yKCdbbmFtZT0iYmlydGhkYXlfbW9udGgiXT5vcHRpb25bc2VsZWN0ZWQ9IjEiXScpLnZhbHVlICsgJy8nICsgZWwucXVlcnlTZWxlY3RvcignW25hbWU9ImJpcnRoZGF5X2RheSJdPm9wdGlvbltzZWxlY3RlZD0iMSJdJykudmFsdWUgKyAnLycgKwplbC5xdWVyeVNlbGVjdG9yKCdbbmFtZT0iYmlydGhkYXlfeWVhciJdPm9wdGlvbltzZWxlY3RlZD0iMSJdJykudmFsdWU7CnZhciBnZW5kZXIgPSBlbC5xdWVyeVNlbGVjdG9yKCdpbnB1dFtjaGVja2VkPSIxIl1bbmFtZT0iZ2VuZGVyIl0nKS52YWx1ZT09MT8nZmVtYWxlJzonbWFsZSc7CnJldHVybiBiaXJ0aGRheSsnfCcrZ2VuZGVyOw==")).ToString();
					if (text21.Split('|').Length > 1)
					{
						if (text9 == "")
						{
							text9 = text21.Split('|')[0];
							F0A99AA5(F19499B8, "cBirthday", text9, "birthday", bool_2: false);
						}
						if (text5 == "")
						{
							text5 = text21.Split('|')[1];
							F0A99AA5(F19499B8, "cGender", text5, "gender", bool_2: false);
						}
					}
				}
			}
			if (text == "" || text12 == "" || text10 == "" || text2 == "")
			{
				if (!gclass3_0.method_9().StartsWith("https://mobile.facebook.com/"))
				{
					gclass3_0.method_10("https://mobile.facebook.com/");
				}
				if (text18 == "")
				{
					text18 = gclass3_0.B8B3CA97();
				}
				if (text == "" || text12 == "")
				{
					string text22 = gclass3_0.BEA5E4BB(GClass8.A2307E3B("YXN5bmMgZnVuY3Rpb24gUmVxdWVzdEdldCh1cmwpIHsKICAgIHZhciBvdXRwdXQgPSAnJzsKICAgIHRyeSB7CiAgICAgICAgdmFyIHJlc3BvbnNlID0gYXdhaXQgZmV0Y2godXJsKTsKICAgICAgICBpZiAocmVzcG9uc2Uub2spIHsKICAgICAgICAgICAgdmFyIGJvZHkgPSBhd2FpdCByZXNwb25zZS50ZXh0KCk7CiAgICAgICAgICAgIHJldHVybiBib2R5OwogICAgICAgIH0KICAgIH0gY2F0Y2ggeyB9CiAgICByZXR1cm4gb3V0cHV0Owp9OwoKdmFyIGh0bWwgPSBhd2FpdCBSZXF1ZXN0R2V0KCdodHRwczovL21vYmlsZS5mYWNlYm9vay5jb20vcHJvZmlsZS5waHA/dj1pbmZvJyk7Cmh0bWwgPSB1bmVzY2FwZShodG1sKS5yZXBsYWNlKC8mYW1wOy9nLCAnJicpCgp2YXIgZWwgPSBkb2N1bWVudC5jcmVhdGVFbGVtZW50KCdodG1sJyk7CmVsLmlubmVySFRNTCA9IGh0bWw7Cgp2YXIgZW1haWwgPSBlbC5xdWVyeVNlbGVjdG9yKCdbaHJlZio9Im1haWx0bzoiXScpIT1udWxsP2VsLnF1ZXJ5U2VsZWN0b3IoJ1tocmVmKj0ibWFpbHRvOiJdJykuaW5uZXJUZXh0OiIiOwp2YXIgbmFtZSA9IGh0bWwubWF0Y2gobmV3IFJlZ0V4cCgnPHRpdGxlPiguKj8pPC90aXRsZT4nKSlbMV07CnJldHVybiBlbWFpbCsnfCcrbmFtZTsK")).ToString();
					if (text22.Split('|').Length > 1)
					{
						if (text12 == "")
						{
							text12 = text22.Split('|')[0];
							F0A99AA5(F19499B8, "cEmail", text12, "email", bool_2: false);
						}
						if (text == "")
						{
							text = text22.Split('|')[1];
							F0A99AA5(F19499B8, "cName", text, "name", bool_2: false);
						}
					}
				}
				if (text10 == "")
				{
					text10 = gclass3_0.BEA5E4BB(GClass8.A2307E3B("YXN5bmMgZnVuY3Rpb24gUmVxdWVzdEdldCh1cmwpIHsKICAgIHZhciBvdXRwdXQgPSAnJzsKICAgIHRyeSB7CiAgICAgICAgdmFyIHJlc3BvbnNlID0gYXdhaXQgZmV0Y2godXJsKTsKICAgICAgICBpZiAocmVzcG9uc2Uub2spIHsKICAgICAgICAgICAgdmFyIGJvZHkgPSBhd2FpdCByZXNwb25zZS50ZXh0KCk7CiAgICAgICAgICAgIHJldHVybiBib2R5OwogICAgICAgIH0KICAgIH0gY2F0Y2ggeyB9CiAgICByZXR1cm4gb3V0cHV0Owp9OwoKdmFyIGh0bWwgPSBhd2FpdCBSZXF1ZXN0R2V0KCdodHRwczovL21vYmlsZS5mYWNlYm9vay5jb20vbWU/dj1mb2xsb3dlcnMnKTsKaHRtbCA9IHVuZXNjYXBlKGh0bWwpLnJlcGxhY2UoLyZhbXA7L2csICcmJykKCnZhciBlbCA9IGRvY3VtZW50LmNyZWF0ZUVsZW1lbnQoJ2h0bWwnKTsKZWwuaW5uZXJIVE1MID0gaHRtbDsKCnZhciBmb2xsb3cgPSBlbC5xdWVyeVNlbGVjdG9yKCdbZGF0YS1zaWdpbD0icHJvZmlsZS1jYXJkLWhlYWRlciJdIHNwYW4nKS5pbm5lclRleHQucmVwbGFjZUFsbCgnLicsJycpLnJlcGxhY2VBbGwoJywnLCcnKTsKcmV0dXJuIGZvbGxvdzs=")).ToString();
					F0A99AA5(F19499B8, "cFollow", text10, "follow", bool_2: false);
				}
				if (text2 == "")
				{
					text2 = gclass3_0.BEA5E4BB(GClass8.A2307E3B("YXN5bmMgZnVuY3Rpb24gUmVxdWVzdEdldCh1cmwpIHsKICAgIHZhciBvdXRwdXQgPSAnJzsKICAgIHRyeSB7CiAgICAgICAgdmFyIHJlc3BvbnNlID0gYXdhaXQgZmV0Y2godXJsKTsKICAgICAgICBpZiAocmVzcG9uc2Uub2spIHsKICAgICAgICAgICAgdmFyIGJvZHkgPSBhd2FpdCByZXNwb25zZS50ZXh0KCk7CiAgICAgICAgICAgIHJldHVybiBib2R5OwogICAgICAgIH0KICAgIH0gY2F0Y2ggeyB9CiAgICByZXR1cm4gb3V0cHV0Owp9OwoKdmFyIGh0bWwgPSBhd2FpdCBSZXF1ZXN0R2V0KCdodHRwczovL21vYmlsZS5mYWNlYm9vay5jb20vZnJpZW5kcy9jZW50ZXIvZnJpZW5kcy8/bWZmX25hdj0xJyk7Cmh0bWwgPSB1bmVzY2FwZShodG1sKS5yZXBsYWNlKC8mYW1wOy9nLCAnJicpCgp2YXIgZWwgPSBkb2N1bWVudC5jcmVhdGVFbGVtZW50KCdodG1sJyk7CmVsLmlubmVySFRNTCA9IGh0bWw7Cgp2YXIgZnJpZW5kID0gZWwucXVlcnlTZWxlY3RvcignI2ZyaWVuZHNfY2VudGVyX21haW4gaGVhZGVyPmgzJykuaW5uZXJUZXh0LnJlcGxhY2VBbGwoJy4nLCcnKS5yZXBsYWNlQWxsKCcsJywnJykuc3BsaXQoJyAnKVswXTsKcmV0dXJuIGZyaWVuZDsK")).ToString();
					F0A99AA5(F19499B8, "cFriend", text2, "friends", bool_2: false);
				}
			}
			if (text6 == "" || text7 == "" || text8 == "" || text11 == "" || text12 == "" || text4 == "")
			{
				if (!gclass3_0.method_9().StartsWith("https://www.facebook.com/"))
				{
					gclass3_0.method_10("https://www.facebook.com/api/graphql/");
				}
				if (text12 == "")
				{
					text12 = gclass3_0.A30A3019().FirstOrDefault();
					if (string.IsNullOrEmpty(text12))
					{
						text12 = "";
					}
					F0A99AA5(F19499B8, "cEmail", text12, "email", bool_2: false);
				}
				if (text6 == "")
				{
					if (text18 == "")
					{
						text18 = gclass3_0.B8B3CA97();
					}
					text6 = gclass3_0.F6B2B404(text18);
					F0A99AA5(F19499B8, "cGroup", text6, "groups", bool_2: false);
				}
				if (text11 == "")
				{
					text11 = gclass3_0.method_68();
					F0A99AA5(F19499B8, "cDating", text11, "dating", bool_2: false);
				}
				if (text8 == "")
				{
					gclass3_0.method_48();
					text8 = gclass3_0.method_70();
					F0A99AA5(F19499B8, "cLocation", text8, "location", bool_2: false);
				}
				if (text4 == "")
				{
					text4 = gclass3_0.method_79().Count.ToString();
					F0A99AA5(F19499B8, "cPagePro5", text4, "pagePro5", bool_2: false);
				}
				if (text7 == "")
				{
					gclass3_0.method_48();
					text7 = gclass3_0.method_69();
					F0A99AA5(F19499B8, "cHometown", text7.Split('|')[0], "hometown", bool_2: false);
					F0A99AA5(F19499B8, "cCurrentCity", text7.Split('|')[1], "currentCity", bool_2: false);
				}
			}
			if (!(text2 == "") && !(text6 == "") && !(text3 == "") && !(text15 == "") && !(text17 == "") && !(text13 == ""))
			{
				return;
			}
			string text23 = gclass3_0.method_81();
			if (text23 == "")
			{
				return;
			}
			if (!gclass3_0.method_9().StartsWith("https://graph.facebook.com/"))
			{
				gclass3_0.method_10("https://graph.facebook.com/");
			}
			if (text2 == "" || text13 == "")
			{
				string text24 = gclass3_0.method_67(text23);
				if (text24.Contains('|'))
				{
					if (text13 == "")
					{
						text13 = text24.Split('|')[0];
						text13 = GClass8.smethod_30(Convert.ToDouble(text13)).ToString("dd/MM/yyyy HH:mm:ss tt");
						F0A99AA5(F19499B8, "cDateCreateAcc", text13, "dateCreateAcc", bool_2: false);
					}
					if (text2 == "")
					{
						text2 = text24.Split('|')[1];
						F0A99AA5(F19499B8, "cFriend", text2, "friends", bool_2: false);
					}
				}
			}
			if (text2 == "" || text3 == "" || text15 == "")
			{
				string text25 = gclass3_0.ABB255BA(text23, text2, text3, text15);
				if (text25 != "")
				{
					try
					{
						JObject jObject = JObject.Parse(text25);
						if (text2 == "")
						{
							text2 = jObject["friend"]!.ToString();
							F0A99AA5(F19499B8, "cFriend", text2, "friends", bool_2: false);
						}
						if (text3 == "")
						{
							text3 = jObject["page"]!.ToString();
							F0A99AA5(F19499B8, "cPage", text3, "pages", bool_2: false);
						}
						if (text15 == "")
						{
							text15 = jObject["ads"]!.ToString();
							F0A99AA5(F19499B8, "cAds", text15.Replace("|", "*"), "ads", bool_2: false);
						}
					}
					catch (Exception)
					{
					}
				}
			}
			if (text6 == "")
			{
				text6 = gclass3_0.method_65(text23);
				F0A99AA5(F19499B8, "cGroup", text6, "groups", bool_2: false);
			}
			if (text17 == "")
			{
				text17 = gclass3_0.method_66(text23);
				F0A99AA5(F19499B8, "cBM", text17, "bm", bool_2: false);
			}
		}
		catch
		{
		}
	}

	private List<string> method_47(List<string> F223C83C, int int_4 = 50, string string_1 = ",")
	{
		int num = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)F223C83C.Count * 1.0 / (double)int_4)));
		List<string> list = new List<string>();
		for (int i = 0; i < num; i++)
		{
			list.Add(string.Join(string_1, F223C83C.GetRange(int_4 * i, (int_4 * i + int_4 <= F223C83C.Count) ? int_4 : (F223C83C.Count % int_4))));
		}
		return list;
	}

	private void method_48(object sender, EventArgs e)
	{
		string EA1E5A94 = Class57.string_1;
		int DDAE529F = 0;
		int int_0 = 10;
		new Thread((ThreadStart)delegate
		{
			try
			{
				int num = 0;
				while (num < EB3CF7AF.Rows.Count)
				{
					if (Convert.ToBoolean(EB3CF7AF.Rows[num].Cells["cChose"].Value))
					{
						if (DDAE529F < int_0)
						{
							Interlocked.Increment(ref DDAE529F);
							int int_ = num++;
							new Thread((ThreadStart)delegate
							{
								try
								{
									B6A11EAF(int_, EA1E5A94);
									Interlocked.Decrement(ref DDAE529F);
								}
								catch (Exception ex2)
								{
									GClass8.smethod_62(null, ex2.ToString());
								}
							}).Start();
						}
						else
						{
							GClass8.smethod_53(1.0);
						}
					}
					else
					{
						num++;
					}
				}
				while (DDAE529F > 0)
				{
					GClass8.smethod_53(1.0);
				}
			}
			catch (Exception ex)
			{
				GClass8.smethod_62(null, ex.ToString());
			}
		}).Start();
	}

	private void B6A11EAF(int FF9A4399, string string_1, bool bool_2 = false, string C28C6783 = "")
	{
		try
		{
			string text = "";
			string input = GClass27.smethod_3(EB3CF7AF, FF9A4399, "cCookie");
			string text2 = EB3CF7AF.Rows[FF9A4399].Cells["cUid"].Value.ToString();
			if (text2 == "")
			{
				text2 = Regex.Match(input, "c_user=(\\d+)").Groups[1].Value;
			}
			text = ((!File.Exists("backup\\" + text2 + "\\ngaysinh.txt")) ? "||" : File.ReadAllText("backup\\" + text2 + "\\ngaysinh.txt"));
			GClass27.smethod_5(EB3CF7AF, FF9A4399, "cStatus", F7AB102E.smethod_0("Đang tạo file Html..."));
			if (text2 != "")
			{
				string text3 = text.Split('|')[2].Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("'", "\\'");
				string text4 = text.Split('|')[1];
				if (text3 == "")
				{
					text3 = "NoName";
				}
				if (text4 == "")
				{
					text4 = "00/00/0000";
				}
				string_1 = string_1.Replace("{{uid}}", text2).Replace("{{birthday}}", text4).Replace("{{name}}", text3);
				string text5 = "backup\\" + text2;
				if (!Directory.Exists(text5))
				{
					return;
				}
				if (File.Exists(text5 + "\\lscomment.txt"))
				{
					string text6 = "";
					List<string> list = File.ReadAllLines(text5 + "\\lscomment.txt").ToList();
					int count = list.Count;
					for (int i = 0; i < count; i++)
					{
						text6 = text6 + "\"" + list[i].Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("'", "\\'") + "\",";
					}
					if (text6 != "")
					{
						text6 = text6.Remove(text6.Length - 1, 1);
						string_1 = string_1.Replace("{comments}", text6);
					}
					else
					{
						string_1 = string_1.Replace("{comments}", "");
					}
				}
				else
				{
					string_1 = string_1.Replace("{comments}", "");
				}
				if (File.Exists(text5 + "\\banbeinbox.txt"))
				{
					string text7 = "";
					List<string> list2 = File.ReadAllLines(text5 + "\\banbeinbox.txt").ToList();
					int count2 = list2.Count;
					for (int j = 0; j < count2; j++)
					{
						text7 = text7 + "\"" + list2[j].Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("'", "\\'") + "\",";
					}
					if (text7 != "")
					{
						text7 = text7.Remove(text7.Length - 1, 1);
						string_1 = string_1.Replace("{messages}", text7);
					}
					else
					{
						string_1 = string_1.Replace("{messages}", "");
					}
				}
				else
				{
					string_1 = string_1.Replace("{messages}", "");
				}
				if (File.Exists(text5 + "\\" + text2 + ".txt"))
				{
					string text8 = "";
					string text9 = "";
					string text10 = File.ReadAllText(text5 + "\\" + text2 + ".txt");
					string[] array = text10.Split(new string[1] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
					for (int k = 0; k < array.Length; k++)
					{
						string[] array2 = array[k].Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
						if (array2.Length != 0)
						{
							text9 = "";
							for (int l = 0; l < array2.Length; l++)
							{
								string[] array3 = array2[l].Split('*');
								text9 = text9 + "\"" + array3[2].Split('|')[0] + "\",";
							}
							text9 = text9.Remove(text9.Length - 1, 1);
							text8 = text8 + "{\"uid\":\"" + array2[0].Split('*')[0] + "\",\"name\":\"" + array2[0].Split('*')[1] + "\",\"photos\":[" + text9 + "],\"show\":true},";
						}
					}
					text8 = text8.Remove(text8.Length - 1, 1);
					string_1 = string_1.Replace("{photos}", text8);
				}
				else
				{
					string_1 = string_1.Replace("{photos}", "");
				}
				File.WriteAllText(text5 + "\\" + text2 + ".html", string_1);
				GClass27.smethod_5(EB3CF7AF, FF9A4399, "cStatus", F7AB102E.smethod_0("Ta\u0323o tha\u0300nh công!"));
				return;
			}
			GClass27.smethod_5(EB3CF7AF, FF9A4399, "cStatus", F7AB102E.smethod_0("Không co\u0301 uid!"));
		}
		catch
		{
			GClass27.smethod_5(EB3CF7AF, FF9A4399, "cStatus", F7AB102E.smethod_0("Lô\u0303i ta\u0323o file!"));
		}
	}

	private bool method_49(string string_1, string B69A7E2C, string string_2 = "backup\\")
	{
		bool result = false;
		try
		{
			string text = "";
			text = ((!File.Exists(string_2 + "\\" + string_1 + "\\ngaysinh.txt")) ? "||" : File.ReadAllText(string_2 + "\\" + string_1 + "\\ngaysinh.txt"));
			if (string_1 != "")
			{
				string text2 = text.Split('|')[2].Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("'", "\\'");
				string text3 = text.Split('|')[1];
				if (text2 == "")
				{
					text2 = "NoName";
				}
				if (text3 == "")
				{
					text3 = "00/00/0000";
				}
				B69A7E2C = B69A7E2C.Replace("{{uid}}", string_1).Replace("{{birthday}}", text3).Replace("{{name}}", text2);
				string text4 = string_2 + "\\" + string_1;
				if (Directory.Exists(text4))
				{
					if (File.Exists(text4 + "\\lscomment.txt"))
					{
						string text5 = "";
						List<string> list = File.ReadAllLines(text4 + "\\lscomment.txt").ToList();
						int count = list.Count;
						for (int i = 0; i < count; i++)
						{
							text5 = text5 + "\"" + list[i].Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("'", "\\'") + "\",";
						}
						if (text5 != "")
						{
							text5 = text5.Remove(text5.Length - 1, 1);
							B69A7E2C = B69A7E2C.Replace("{comments}", text5);
						}
						else
						{
							B69A7E2C = B69A7E2C.Replace("{comments}", "");
						}
					}
					else
					{
						B69A7E2C = B69A7E2C.Replace("{comments}", "");
					}
					if (File.Exists(text4 + "\\banbeinbox.txt"))
					{
						string text6 = "";
						List<string> list2 = File.ReadAllLines(text4 + "\\banbeinbox.txt").ToList();
						int count2 = list2.Count;
						for (int j = 0; j < count2; j++)
						{
							text6 = text6 + "\"" + list2[j].Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("'", "\\'") + "\",";
						}
						if (text6 != "")
						{
							text6 = text6.Remove(text6.Length - 1, 1);
							B69A7E2C = B69A7E2C.Replace("{messages}", text6);
						}
						else
						{
							B69A7E2C = B69A7E2C.Replace("{messages}", "");
						}
					}
					else
					{
						B69A7E2C = B69A7E2C.Replace("{messages}", "");
					}
					if (File.Exists(text4 + "\\" + string_1 + ".txt"))
					{
						string text7 = "";
						string text8 = "";
						string text9 = File.ReadAllText(text4 + "\\" + string_1 + ".txt");
						string[] array = text9.Split(new string[1] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
						for (int k = 0; k < array.Length; k++)
						{
							string[] array2 = array[k].Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
							if (array2.Length != 0)
							{
								text8 = "";
								for (int l = 0; l < array2.Length; l++)
								{
									string[] array3 = array2[l].Split('*');
									text8 = text8 + "\"" + array3[2].Split('|')[0] + "\",";
								}
								text8 = text8.Remove(text8.Length - 1, 1);
								text7 = text7 + "{\"uid\":\"" + array2[0].Split('*')[0] + "\",\"name\":\"" + array2[0].Split('*')[1] + "\",\"photos\":[" + text8 + "],\"show\":true},";
							}
						}
						text7 = text7.Remove(text7.Length - 1, 1);
						B69A7E2C = B69A7E2C.Replace("{photos}", text7);
					}
					else
					{
						B69A7E2C = B69A7E2C.Replace("{photos}", "");
					}
					File.WriteAllText(text4 + "\\" + string_1 + ".html", B69A7E2C);
					result = true;
					return result;
				}
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	private void method_50(object sender, EventArgs e)
	{
		int C2060185 = 0;
		int int_0 = 10;
		new Thread((ThreadStart)delegate
		{
			try
			{
				int num = 0;
				while (num < EB3CF7AF.Rows.Count)
				{
					if (Convert.ToBoolean(EB3CF7AF.Rows[num].Cells["cChose"].Value))
					{
						if (C2060185 < int_0)
						{
							Interlocked.Increment(ref C2060185);
							int int_ = num++;
							new Thread((ThreadStart)delegate
							{
								try
								{
									string input = GClass27.smethod_3(EB3CF7AF, int_, "cCookies");
									string text = GClass27.smethod_3(EB3CF7AF, int_, "cUid");
									if (text == "")
									{
										text = Regex.Match(input, "c_user=(\\d+)").Groups[1].Value;
									}
									if (File.Exists("backup\\" + text + "\\" + text + ".html"))
									{
										Process.Start(GClass28.smethod_0() + "\\backup\\" + text + "\\" + text + ".html");
									}
									else
									{
										GClass27.smethod_5(EB3CF7AF, int_, "cStatus", F7AB102E.smethod_0("Chưa tạo html!"));
									}
									Interlocked.Decrement(ref C2060185);
								}
								catch (Exception ex2)
								{
									GClass8.smethod_62(null, ex2.ToString());
								}
							}).Start();
						}
						else
						{
							GClass8.smethod_53(1.0);
						}
					}
					else
					{
						num++;
					}
				}
				while (C2060185 > 0)
				{
					GClass8.smethod_53(1.0);
				}
			}
			catch (Exception ex)
			{
				GClass8.smethod_62(null, ex.ToString());
			}
		}).Start();
	}

	private void A81D73BC(object sender, EventArgs e)
	{
		GClass8.smethod_33(new DA3DAB8C());
		string text = DA3DAB8C.string_0;
		if (text == "")
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < EB3CF7AF.Rows.Count; i++)
		{
			try
			{
				if (!Convert.ToBoolean(EB3CF7AF.Rows[i].Cells["cChose"].Value))
				{
					continue;
				}
				string text2 = EB3CF7AF.Rows[i].Cells["cUid"].Value.ToString();
				try
				{
					if (File.Exists(GClass28.smethod_0() + "\\backup\\" + text2 + "\\" + text2 + ".html"))
					{
						File.Copy("backup\\" + text2 + "\\" + text2 + ".html", text + "\\" + text2 + ".html");
						num++;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
		}
		GClass29.smethod_0(string.Format(F7AB102E.smethod_0("Copy thành công {0} tệp backup html!"), num));
	}

	private void method_51(object sender, EventArgs e)
	{
		D314DFA9(GClass25.FEB70BB9());
	}

	private void F42E5299(object sender, DataGridViewSortCompareEventArgs e)
	{
		GClass27.D6A30D83(e);
	}

	private void toolStripMenuItem_9_Click(object sender, EventArgs e)
	{
		string text = GClass25.smethod_0("configDatagridview").method_7();
		GClass8.smethod_33(new B4A88A90());
		if (GClass25.smethod_0("configDatagridview").method_7() != text)
		{
			method_64();
		}
	}

	private void DCB311B2_Click(object sender, EventArgs e)
	{
		int int_0 = 0;
		int int_1 = GClass25.smethod_0("configGeneral").method_2("nudHideThread", 10);
		Class57.A39EDD1D(bool_9: false);
		new Thread((ThreadStart)delegate
		{
			method_34("start");
			int num = 0;
			while (num < EB3CF7AF.Rows.Count)
			{
				Application.DoEvents();
				if (Class57.smethod_5())
				{
					break;
				}
				if (Convert.ToBoolean(EB3CF7AF.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int A0AFA20D = num++;
						new Thread((ThreadStart)delegate
						{
							A1BF1713(A0AFA20D, F7AB102E.smethod_0("Đang kiểm tra..."));
							method_52(A0AFA20D);
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
			method_34("stop");
		}).Start();
	}

	private void method_52(int int_4)
	{
		try
		{
			string text = EB3CF7AF.Rows[int_4].Cells["cProxy"].Value.ToString();
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
				A1BF1713(int_4, "Proxy Die!");
			}
			else
			{
				A1BF1713(int_4, "Proxy Live!");
			}
		}
		catch
		{
			A1BF1713(int_4, "Lỗi!");
		}
	}

	private void F586C109_Click(object sender, EventArgs e)
	{
		method_7("cUseragent");
	}

	private void D8123B8B_Click(object sender, EventArgs e)
	{
		method_7("cProxy");
	}

	private string C093FA07()
	{
		string text = GClass8.smethod_51(6) + GClass8.smethod_52(4) + GClass8.smethod_51(5);
		if (GClass25.smethod_0("configGeneral").method_2("typePass") == 0)
		{
			text = GClass25.smethod_0("configGeneral").C0288288("txtPass");
		}
		return text.A3A66D03(1);
	}

	private void metroButton1_Click(object sender, EventArgs e)
	{
		GClass8.smethod_41("chromedriver");
	}

	private void pictureBox1_Click(object sender, EventArgs e)
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

	private void AB8D3DA4(object sender, EventArgs e)
	{
		if (!CF9F8596 || cbbTinhTrang.SelectedValue == null || !E887EC9A.C323DB3B(cbbTinhTrang.SelectedValue.ToString()) || (cbbTinhTrang.SelectedValue.ToString() != "-1" && int_0 == cbbTinhTrang.SelectedIndex))
		{
			return;
		}
		string text = cbbThuMuc.SelectedValue.ToString();
		string text2 = text;
		if (!(text2 == "-2"))
		{
			if (!(text2 == "999999"))
			{
				method_4(EB221108(), cbbTinhTrang.Text);
			}
			else
			{
				method_4(fChonThuMuc.list_0, cbbTinhTrang.Text);
			}
		}
		else
		{
			method_4(null, cbbTinhTrang.Text);
		}
		int_0 = cbbTinhTrang.SelectedIndex;
	}

	private void A6265216(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fCauHinhTaoShortcut());
		if (!fCauHinhTaoShortcut.bool_0)
		{
			return;
		}
		int B62CEBAB = 0;
		int CEB1961B = GClass25.smethod_0("configGeneral").method_2("nudHideThread", 10);
		Class57.A39EDD1D(bool_9: false);
		new Thread((ThreadStart)delegate
		{
			method_34("start");
			int num = 0;
			while (num < EB3CF7AF.Rows.Count)
			{
				Application.DoEvents();
				if (Class57.smethod_5())
				{
					break;
				}
				if (Convert.ToBoolean(EB3CF7AF.Rows[num].Cells["cChose"].Value))
				{
					if (B62CEBAB < CEB1961B)
					{
						Interlocked.Increment(ref B62CEBAB);
						int int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							A1BF1713(int_0, F7AB102E.smethod_0("Đang ta\u0323o Shortcut..."));
							try
							{
								EB3CF7AF.Rows[int_0].Cells["cId"].Value.ToString();
								string text = EB3CF7AF.Rows[int_0].Cells["cUid"].Value.ToString();
								string text2 = EB3CF7AF.Rows[int_0].Cells["cName"].Value.ToString();
								string string_ = ((text2 == "") ? text : (text2 + "_" + text));
								string text3 = GClass25.smethod_0("configGeneral").C0288288("txbPathProfile") + "\\" + text;
								if (GClass25.smethod_0("configGeneral").method_3("ckbUsePortable") && Directory.Exists(GClass25.smethod_0("configGeneral").C0288288("txbPathProfile") + "\\" + text + "\\Data\\profile"))
								{
									text3 = GClass25.smethod_0("configGeneral").C0288288("txbPathProfile") + "\\" + text + "\\Data\\profile";
								}
								GClass8.smethod_32(text3);
								bool flag;
								if (!(flag = method_53(text3, string_)))
								{
									string_ = text;
									flag = method_53(text3, string_);
								}
								if (!flag)
								{
									A1BF1713(int_0, F7AB102E.smethod_0("Lô\u0303i ta\u0323o Shortcut!"));
								}
								else
								{
									A1BF1713(int_0, F7AB102E.smethod_0("Ta\u0323o Shortcut thành công!"));
								}
							}
							catch
							{
								A1BF1713(int_0, F7AB102E.smethod_0("Lỗi!"));
							}
							Interlocked.Decrement(ref B62CEBAB);
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
			while (B62CEBAB > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			method_34("stop");
		}).Start();
	}

	private bool method_53(string D787E507, string string_1)
	{
		try
		{
			string_1 = GClass8.smethod_70(string_1);
			if (D787E507.StartsWith("profiles\\"))
			{
				D787E507 = GClass28.smethod_0() + "\\" + D787E507;
			}
			string text = GClass28.smethod_0() + "\\images\\chrome.ico";
			if (!File.Exists(text))
			{
				using FileStream outputStream = new FileStream(text, FileMode.Create);
				C50FB39E.C8AAE33B.Save(outputStream);
			}
			if (GClass8.CF3A2293(string_1, GClass25.smethod_0("configInteractGeneral").C0288288("txtPathShortcut"), D787E507, text, GClass25.smethod_0("configInteractGeneral").C0288288("txtPathChromeOrigin")))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private void A4B4959A(object sender, EventArgs e)
	{
		D5AE0395(CCA02B07: false);
	}

	private void EA115A3B(object sender, EventArgs e)
	{
		method_35(4);
	}

	private void E3942017(int A915653C = 1)
	{
		try
		{
			for (int i = 0; i < A915653C; i++)
			{
				if (EB3CF7AF.RowCount <= 1)
				{
					continue;
				}
				List<DataGridViewRow> list = new List<DataGridViewRow>();
				foreach (DataGridViewRow item in (IEnumerable)EB3CF7AF.Rows)
				{
					list.Add(item);
				}
				int num = list.Count;
				while (num > 1)
				{
					num--;
					int index = Class57.random_0.Next(num + 1);
					DataGridViewRow value = list[index];
					list[index] = list[num];
					list[num] = value;
				}
				EB3CF7AF.Rows.Clear();
				foreach (DataGridViewRow item2 in list)
				{
					EB3CF7AF.Rows.Add(item2);
				}
			}
		}
		catch
		{
		}
	}

	public int AB0B20AA()
	{
		int result = 0;
		try
		{
			result = Convert.ToInt32(lblCountSelect.Text);
		}
		catch
		{
		}
		return result;
	}

	private bool method_54()
	{
		if (AB0B20AA() == 0)
		{
			GClass29.smethod_0("Vui lòng chọn tài khoản muốn sử dụng chức năng này!", 3);
			return false;
		}
		return true;
	}

	private void toolStripMenuItem_22_Click(object sender, EventArgs e)
	{
		if (GClass29.smethod_1(string.Format(F7AB102E.smethod_0("Bạn có chắc muốn xóa Cache Profile của {0} tài khoản?"), AB0B20AA())) != DialogResult.Yes)
		{
			return;
		}
		int A6B80904 = 0;
		int CD06FB0D = GClass25.smethod_0("configGeneral").method_2("nudHideThread", 10);
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < EB3CF7AF.Rows.Count)
			{
				if (Convert.ToBoolean(EB3CF7AF.Rows[num].Cells["cChose"].Value))
				{
					if (A6B80904 < CD06FB0D)
					{
						Interlocked.Increment(ref A6B80904);
						int int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							A1BF1713(int_0, F7AB102E.smethod_0("Đang xo\u0301a Cache Profile..."));
							F1A2A699(int_0);
							Interlocked.Decrement(ref A6B80904);
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

	private void F1A2A699(int int_4)
	{
		try
		{
			EB3CF7AF.Rows[int_4].Cells["cId"].Value.ToString();
			string text = EB3CF7AF.Rows[int_4].Cells["cUid"].Value.ToString();
			if (text.Trim() == "")
			{
				A1BF1713(int_4, F7AB102E.smethod_0("Chưa tạo profile!"));
				return;
			}
			string text2 = GClass25.smethod_0("configGeneral").C0288288("txbPathProfile") + "\\" + text;
			if (Directory.Exists(text2))
			{
				GClass8.smethod_67(text2 + "\\Default\\Cache");
				GClass8.smethod_67(text2 + "\\Default\\Code Cache");
				GClass8.smethod_67(text2 + "\\OptimizationGuidePredictionModels");
				GClass8.smethod_67(text2 + "\\Default\\optimization_guide_prediction_model_downloads");
				GClass8.smethod_67(text2 + "\\SwReporter");
				GClass8.smethod_67(text2 + "\\pnacl");
				A1BF1713(int_4, F7AB102E.smethod_0("Xóa Cache Profile thành công!"));
			}
			else
			{
				A1BF1713(int_4, F7AB102E.smethod_0("Chưa tạo profile!"));
			}
		}
		catch
		{
			A1BF1713(int_4, F7AB102E.smethod_0("Xóa Cache Profile thất bại!"));
		}
	}

	private void toolStripMenuItem_12_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new B314B89F());
	}

	private void D217CC29(object sender, EventArgs e)
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

	private void CBA9DA8E(object sender, EventArgs e)
	{
	}

	private void checkHotmailToolStripMenuItem_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fTienIchCheckImapHotmail());
	}

	private void EB3CF7AF_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			if (e.RowIndex > -1)
			{
				EB3CF7AF.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(EB3CF7AF.CurrentRow.Cells["cChose"].Value);
				E6042218();
			}
		}
		catch
		{
		}
	}

	private void BAA6999D(object sender, EventArgs e)
	{
		List<string> list = EB221108();
		if (list != null && list.Count == 1)
		{
			fEditFile fEditFile2 = new fEditFile(list[0], cbbThuMuc.Text);
			fEditFile2.ShowInTaskbar = false;
			fEditFile2.ShowDialog();
			int selectedIndex = cbbThuMuc.SelectedIndex;
			if (fEditFile2.A0A227BD)
			{
				AC37B195();
				FD8F4B3F = -1;
				cbbThuMuc.SelectedIndex = selectedIndex;
			}
		}
	}

	private void checkProxyToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fTienIchCheckProxy());
	}

	private void AA8D789E(object sender, EventArgs e)
	{
		fLocTheoDanhSachUid fLocTheoDanhSachUid2 = new fLocTheoDanhSachUid();
		GClass8.smethod_33(fLocTheoDanhSachUid2);
		if (fLocTheoDanhSachUid2.list_0.Count > 0)
		{
			List<string> a6826E = GClass8.smethod_28(fLocTheoDanhSachUid2.list_0);
			DataTable dataTable_ = Class15.C52782A9(a6826E);
			EB3CF7AF.Rows.Clear();
			method_5(dataTable_);
			method_6("All");
		}
	}

	public void A1BF1713(int int_4, string string_1, int int_5 = -1)
	{
		switch (int_5)
		{
		case -1:
			GClass27.smethod_5(EB3CF7AF, int_4, "cStatus", string_1);
			return;
		case 0:
			return;
		}
		int tickCount = Environment.TickCount;
		while (true)
		{
			int num = int_5 - (Environment.TickCount - tickCount) / 1000;
			if (num > 0 && !Class57.smethod_5())
			{
				GClass27.smethod_5(EB3CF7AF, int_4, "cStatus", string_1.Replace("{time}", num.ToString()));
				GClass8.smethod_53(0.5);
				continue;
			}
			break;
		}
	}

	public void method_55(int int_4, string string_1, int F199BC33, int int_5)
	{
		int int_6 = Class57.random_0.Next(F199BC33, int_5 + 1);
		A1BF1713(int_4, string_1, int_6);
	}

	public void FD062316(int D611DB87, string D124D931)
	{
		GClass27.smethod_5(EB3CF7AF, D611DB87, "cInfo", D124D931);
		A517E201(D611DB87);
		Class15.EB34450D(method_60(D611DB87, "cId"), "info", D124D931);
	}

	public int method_56(int F29C5D0F)
	{
		string text = method_60(F29C5D0F, "cJob").Trim();
		if (text == "")
		{
			return 0;
		}
		string text2 = Regex.Match(text, "\\((.*?)\\)").Groups[1].Value;
		if (text2.Contains(" "))
		{
			text2 = text2.Replace(" ", "/");
		}
		string text3 = DateTime.Now.ToString("dd/MM/yyyy");
		if (text2 != text3)
		{
			return 0;
		}
		return Convert.ToInt32(text.Split(' ')[1].Trim());
	}

	public void method_57(int int_4, int int_5)
	{
		int num = method_56(int_4);
		string eC2D049B = "(" + DateTime.Now.ToString("dd/MM/yyyy") + ") " + (int_5 + num);
		F0A99AA5(int_4, "cJob", eC2D049B, "job");
	}

	public void method_58(int int_4, string string_1, object C6A74F9C, bool bool_2 = true)
	{
		if ((!(string_1 == "cUid") || !(C6A74F9C.ToString().Trim() == "")) && (bool_2 || !(C6A74F9C.ToString().Trim() == "")))
		{
			GClass27.smethod_5(EB3CF7AF, int_4, string_1, C6A74F9C);
		}
	}

	public void AA9E0AA9(int int_4, int int_5, object object_9)
	{
		GClass27.smethod_4(EB3CF7AF, int_4, int_5, object_9);
	}

	public void method_59(string string_1, string string_2, int AB368D32, string D9057DA8, string string_3, bool bool_2 = true)
	{
		if ((bool_2 || !(string_3.ToString().Trim() == "")) && !(string_3 == "-2"))
		{
			GClass27.smethod_5(EB3CF7AF, AB368D32, D9057DA8, string_3);
			Class15.EB34450D(string_1, string_2, string_3);
		}
	}

	public void F0A99AA5(int int_4, string AD22C59F, string EC2D049B, string string_1, bool bool_2 = true)
	{
		method_59(method_60(int_4, "cId"), string_1, int_4, AD22C59F, EC2D049B, bool_2);
	}

	public string E01F1137(int F28DE08C)
	{
		string text = GClass27.smethod_3(EB3CF7AF, F28DE08C, "cStatus");
		if (text.StartsWith("("))
		{
			return text.Substring(text.IndexOf(')') + 1).Trim();
		}
		return text;
	}

	public string C5151C09(int B207B119)
	{
		return GClass27.smethod_3(EB3CF7AF, B207B119, "cInfo");
	}

	public string method_60(int int_4, string string_1)
	{
		return GClass27.smethod_3(EB3CF7AF, int_4, string_1);
	}

	public string method_61(int A683E485, int int_4)
	{
		return GClass27.smethod_2(EB3CF7AF, A683E485, int_4);
	}

	public void A517E201(int CF3E3E0E = -1)
	{
		GClass27.smethod_0(EB3CF7AF, CF3E3E0E);
	}

	public void method_62(int int_4, int B9A14228)
	{
		GClass27.E012E0A4(EB3CF7AF, int_4, B9A14228);
	}

	public int method_63(int BC8719A5)
	{
		Color backColor = EB3CF7AF.Rows[BC8719A5].DefaultCellStyle.BackColor;
		if (backColor == Color.White)
		{
			return 0;
		}
		if (backColor == Color.FromArgb(255, 182, 193))
		{
			return 1;
		}
		if (backColor == Color.FromArgb(212, 237, 182))
		{
			return 2;
		}
		return -1;
	}

	private void method_64()
	{
		EB3CF7AF.Columns["cToken"].Visible = GClass25.smethod_0("configDatagridview").method_3("cToken");
		EB3CF7AF.Columns["cCookies"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbCookie");
		EB3CF7AF.Columns["cEmail"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbEmail");
		EB3CF7AF.Columns["cEmail2"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbEmailFull");
		EB3CF7AF.Columns["cName"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbTen");
		EB3CF7AF.Columns["cFriend"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbBanBe");
		EB3CF7AF.Columns["cGroup"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbNhom");
		EB3CF7AF.Columns["cPage"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbPage");
		EB3CF7AF.Columns["cPagePro5"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbPagePro5");
		EB3CF7AF.Columns["cBirthday"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbNgaySinh");
		EB3CF7AF.Columns["cGender"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbGioiTinh");
		EB3CF7AF.Columns["cPassword"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbMatKhau");
		EB3CF7AF.Columns["cPassMail"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbMatKhauMail");
		EB3CF7AF.Columns["cOAuth2"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbOAuth2");
		EB3CF7AF.Columns["cFa2"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbMa2FA");
		EB3CF7AF.Columns["cUseragent"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbUseragent");
		EB3CF7AF.Columns["cProxy"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbProxy");
		EB3CF7AF.Columns["cDateCreateAcc"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbNgayTao");
		EB3CF7AF.Columns["cAvatar"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbAvatar");
		EB3CF7AF.Columns["cProfile"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbProfile");
		EB3CF7AF.Columns["cInfo"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbTinhTrang");
		EB3CF7AF.Columns["cThuMuc"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbThuMuc");
		EB3CF7AF.Columns["cGhiChu"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbGhiChu");
		EB3CF7AF.Columns["cFollow"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbFollow");
		EB3CF7AF.Columns["cInteractEnd"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbInteractEnd");
		EB3CF7AF.Columns["cMailRecovery"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbMailRecovery");
		EB3CF7AF.Columns["cPassMailRecovery"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbPassMailRecovery");
		EB3CF7AF.Columns["cPhone"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbPhone");
		EB3CF7AF.Columns["cHometown"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbHometown");
		EB3CF7AF.Columns["cCurrentCity"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbCurrentCity");
		EB3CF7AF.Columns["cJob"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbJob");
		EB3CF7AF.Columns["cLocation"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbLocation");
		EB3CF7AF.Columns["cDating"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbDating");
		EB3CF7AF.Columns["cAds"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbAds");
		EB3CF7AF.Columns["cBM"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbBM");
		EB3CF7AF.Columns["cWallPosts"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbWallPosts");
		EB3CF7AF.Columns["cFbBlock"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbFbBlock");
		EB3CF7AF.Columns["cStatus282"].Visible = GClass25.smethod_0("configDatagridview").method_3("ckbStatus282");
	}

	private void toolStripMenuItem_14_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new D9AAEB9A());
		if (D9AAEB9A.bool_0)
		{
			CC348FB5(null, null);
		}
	}

	private void EB3CF7AF_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if (A2AD659F && e.ColumnIndex == 0)
		{
			E6042218();
		}
	}

	private void A900291F_Click(object sender, EventArgs e)
	{
		D314DFA9(GClass25.smethod_2());
	}

	private void D314DFA9(string F59609BA)
	{
		GClass8.smethod_33(new DA3DAB8C());
		string text = DA3DAB8C.string_0;
		if (text == "")
		{
			return;
		}
		List<string> list = new List<string>();
		for (int i = 0; i < EB3CF7AF.Rows.Count; i++)
		{
			try
			{
				if (Convert.ToBoolean(method_60(i, "cChose")))
				{
					string text2 = method_60(i, "cUid");
					list.Add(F59609BA + "\\" + text2 + "|" + text + "\\" + text2);
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

	private void checkLiveUidToolStripMenuItem_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fTienIchCheckLiveUid());
	}

	private void toolStripMenuItem_15_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fMoTrinhDuyet());
	}

	private bool method_65(GClass3 DDB9AC17)
	{
		if (GClass25.smethod_0("configDebug").method_3("ckbModeDev"))
		{
			new fAutoChrome(DDB9AC17.Int32_2, DDB9AC17.A294ABA3).ShowDialog();
			return true;
		}
		return false;
	}

	private void E63B019F(object sender, EventArgs e)
	{
		GClass11 gClass = new GClass11();
		gClass.method_4("OpenBrowser", true);
		D4327FBE(gClass);
	}

	private void method_66(object sender, EventArgs e)
	{
	}

	private void D222E1AF(object sender, EventArgs e)
	{
		try
		{
			GClass8.smethod_33(new fClearBackup());
		}
		catch (Exception ex)
		{
			GClass29.smethod_0(ex.ToString(), 3);
		}
	}

	private void toolStripMenuItem_16_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fContact());
	}

	private void method_67(object sender, EventArgs e)
	{
		GClass8.smethod_33(new DA3DAB8C());
		string text = DA3DAB8C.string_0;
		if (text == "")
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < EB3CF7AF.Rows.Count; i++)
		{
			try
			{
				if (!Convert.ToBoolean(EB3CF7AF.Rows[i].Cells["cChose"].Value))
				{
					continue;
				}
				string text2 = EB3CF7AF.Rows[i].Cells["cUid"].Value.ToString();
				try
				{
					if (File.Exists(GClass28.smethod_0() + "\\backup\\" + text2 + "\\" + text2 + ".txt"))
					{
						File.Copy("backup\\" + text2 + "\\" + text2 + ".txt", text + "\\" + text2 + ".txt");
						num++;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
		}
		GClass29.smethod_0(string.Format(F7AB102E.smethod_0("Copy thành công {0} tệp backup txt!"), num));
	}

	private void ED804089(object sender, EventArgs e)
	{
		E71E4104.Text = EB3CF7AF.SelectedRows.Count.ToString();
	}

	private void FC335E91(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex == 0 && e.RowIndex > -1)
		{
			try
			{
				EB3CF7AF.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(EB3CF7AF.CurrentRow.Cells["cChose"].Value);
				E6042218();
			}
			catch
			{
			}
		}
	}

	private void method_68(object sender, EventArgs e)
	{
	}

	private void A901862C(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fGiaiPhongDungLuong());
	}

	private void method_69(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fGiaiPhongDungLuong(bool_1: true));
	}

	private void A7BA973D_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < EB3CF7AF.RowCount; i++)
		{
			if (Convert.ToBoolean(EB3CF7AF.Rows[i].Cells["cChose"].Value))
			{
				EB3CF7AF.Rows.RemoveAt(i--);
			}
		}
		CA0EAB0F();
		E280B5BE();
		E6042218(0);
	}

	private void emailPassMailMailKpToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_7("cEmail|cPassMail|cMailRecovery");
	}

	private void txbSearch_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			C0290281_Click(null, null);
		}
	}

	private void toolStripMenuItem_17_Click(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		int num = 0;
		for (int i = 0; i < EB3CF7AF.RowCount; i++)
		{
			if (!Convert.ToBoolean(EB3CF7AF.Rows[i].Cells["cChose"].Value))
			{
				continue;
			}
			try
			{
				string item = method_60(i, "cUid");
				if (list2.Contains(item))
				{
					list.Add(EB3CF7AF.Rows[i].Cells["cId"].Value.ToString());
					EB3CF7AF.Rows.RemoveAt(i);
					i--;
					num++;
				}
				else
				{
					list2.Add(item);
				}
			}
			catch
			{
			}
		}
		Class15.A7BEDD3C(list);
		CA0EAB0F();
		E280B5BE();
		E6042218();
		GClass29.smethod_0($"Đã loại bỏ {num} tài khoản bị trùng!");
	}

	private void toolStripMenuItem_18_Click(object sender, EventArgs e)
	{
		method_35(5);
	}

	private void A5AFFD08(object sender, EventArgs e)
	{
		method_35(5, bool_2: true);
	}

	private void C8A8A0A5_Click(object sender, EventArgs e)
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
			for (int i = 0; i < EB3CF7AF.RowCount; i++)
			{
				string text = method_60(i, "cEmail");
				if (text != "" && text.Contains("@"))
				{
					text = text.Substring(text.IndexOf('@'));
					method_58(i, "cChose", list.Contains(text));
				}
			}
		}
		else
		{
			for (int j = 0; j < EB3CF7AF.RowCount; j++)
			{
				string item = method_60(j, "cUid");
				string item2 = method_60(j, "cEmail");
				method_58(j, "cChose", list.Contains(item) || list.Contains(item2));
			}
		}
		E6042218();
	}

	private void ABBC5528(object sender, EventArgs e)
	{
		this.A294D626();
	}

	private void A6AAEF89(object sender, EventArgs e)
	{
		GClass8.smethod_33(new BF19FE85());
	}

	private void DE2AF0A4(object sender, EventArgs e)
	{
		GClass11 gClass = new GClass11();
		gClass.method_4("GetTokenEAAAAU", true);
		D4327FBE(gClass);
	}

	private void A3BB69B1(object sender, EventArgs e)
	{
		GClass11 gClass = new GClass11();
		gClass.method_4("GetTokenEAAAAU", true);
		gClass.method_4("Bat2FA", true);
		D4327FBE(gClass);
	}

	private void BF379492_MouseEnter(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			return;
		}
		bool_1 = false;
		BF379492.DropDownItems.Clear();
		List<string> D50DF324 = new List<string>();
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				string text = "";
				for (int j = 0; j < EB3CF7AF.RowCount; j++)
				{
					text = method_60(j, "cGhiChu");
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
						if (text != "" && !D50DF324.Contains(text))
						{
							D50DF324.Add(text);
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
		for (int i = 0; i < D50DF324.Count; i++)
		{
			BF379492.DropDownItems.Add(D50DF324[i]);
			BF379492.DropDownItems[i].Click += method_70;
		}
	}

	private void method_70(object sender, EventArgs e)
	{
		EE142AB8("cGhiChu", (sender as ToolStripMenuItem).Text);
	}

	private void method_71(object sender, EventArgs e)
	{
		if (method_54())
		{
			GClass8.smethod_33(new C4B7D633());
			if (C4B7D633.bool_0)
			{
				GClass11 gClass = new GClass11();
				gClass.method_4("Unlock956", true);
				gClass.method_4("TypeUnlock956", 2);
				D4327FBE(gClass);
			}
		}
	}

	private void F980742C(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fTienIchCheckStatusXProxy());
	}

	private void method_72(object sender, EventArgs e)
	{
		if (method_54())
		{
			GClass8.smethod_33(new fImportProxy());
		}
	}

	private void DF9BDB01(object sender, EventArgs e)
	{
		if (method_54())
		{
			GClass8.smethod_33(new fImportUseragent());
		}
	}

	private void method_73(object sender, EventArgs e)
	{
		int int_0 = 0;
		int C4AB4828 = GClass25.smethod_0("configGeneral").method_2("nudHideThread", 10);
		GClass25.smethod_0("configGeneral").C0288288("token");
		Class57.A39EDD1D(bool_9: false);
		new Thread((ThreadStart)delegate
		{
			method_34("start");
			int num = 0;
			while (num < EB3CF7AF.Rows.Count && !Class57.smethod_5())
			{
				if (Convert.ToBoolean(EB3CF7AF.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < C4AB4828)
					{
						Interlocked.Increment(ref int_0);
						int FE18DE35 = num++;
						new Thread((ThreadStart)delegate
						{
							A1BF1713(FE18DE35, F7AB102E.smethod_0("Đang kiểm tra..."));
							try
							{
								string text = method_60(FE18DE35, "cEmail");
								string text2 = method_60(FE18DE35, "cPassMail");
								if (text == "" || text2 == "")
								{
									A1BF1713(FE18DE35, F7AB102E.smethod_0("Không tìm thấy mail!"));
									return;
								}
								string text3 = method_28(6, text, text2, 0, "", "");
								if (text3 != "" && text3 != "fail")
								{
									F0A99AA5(FE18DE35, "cEmail", text3, "email");
									A1BF1713(FE18DE35, F7AB102E.smethod_0("Lấy thành công!"));
								}
								else
								{
									A1BF1713(FE18DE35, F7AB102E.smethod_0("Lấy thất bại!"));
								}
							}
							catch (Exception ex)
							{
								GClass29.smethod_0(ex.ToString());
								A1BF1713(FE18DE35, F7AB102E.smethod_0("Lỗi!"));
							}
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
			_ = Environment.TickCount;
			while (int_0 > 0)
			{
				GClass8.smethod_53(1.0);
			}
			method_34("stop");
		}).Start();
	}

	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		E6183B02 e6183B = new E6183B02();
		GClass8.smethod_33(e6183B);
		if (e6183B.string_0 != "" && method_54() && GClass29.smethod_1(string.Format(F7AB102E.smethod_0("Bạn có thực sự muốn chuyển {0} tài khoản sang thư mục [{1}]?"), lblCountSelect.Text, e6183B.C5A7AC9D)) == DialogResult.Yes)
		{
			method_12(e6183B.string_0);
		}
	}

	private void toolStripMenuItem_20_Click(object sender, EventArgs e)
	{
		method_35(6, bool_2: true);
	}

	private void checkNameVNToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_35(7);
	}

	private void bunifuCustomLabel1_DoubleClick(object sender, EventArgs e)
	{
		int_1++;
		if (int_1 >= 3)
		{
			int_1 = 0;
			new fCauHinhDebug().ShowDialog();
		}
	}

	private void toolStripMenuItem1_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < EB3CF7AF.RowCount; i++)
		{
			if (!Convert.ToBoolean(EB3CF7AF.Rows[i].Cells["cChose"].Value))
			{
				EB3CF7AF.Rows.RemoveAt(i--);
			}
		}
		CA0EAB0F();
		E280B5BE();
	}

	private void ckbUnlock956_CheckedChanged(object sender, EventArgs e)
	{
		D99BA487.Enabled = ckbUnlock956.Checked;
	}

	private void F69F0991(object sender, EventArgs e)
	{
	}

	private void CF2D2631(object sender, EventArgs e)
	{
		foreach (CheckBox item in list_2)
		{
			item.Checked = ckbCheckAll.Checked && item.Enabled;
		}
	}

	private string method_74()
	{
		string text = "";
		foreach (CheckBox item in list_2)
		{
			text = ((!ckbChayBangPageProfile.Checked) ? (text + (item.Checked ? (item.Name.Substring(3).ToLower() + ",") : "")) : (text + (item.Checked ? (item.Text + "_pageprofile,") : "")));
		}
		return text.TrimEnd(',');
	}

	public object E9B4CF8B(string string_1)
	{
		object object_0 = null;
		Invoke((MethodInvoker)delegate
		{
			string text = string_1;
			string text2 = text;
			switch (C43AF739.smethod_0(text2))
			{
			case 67270472u:
				if (text2 == "nudDelayGetJob")
				{
					object_0 = 5;
				}
				break;
			case 52101475u:
				if (text2 == "ckbCheckProxy")
				{
					object_0 = ckbCheckProxy.Checked;
				}
				break;
			case 152793916u:
				if (text2 == "rbChayBangChrome")
				{
					object_0 = rbChayBangChrome.Checked;
				}
				break;
			case 127089650u:
				if (text2 == "nudMaxJobToday")
				{
					object_0 = A63DDA9B.Value;
				}
				break;
			case 556307290u:
				if (text2 == "ckbCheckToken")
				{
					object_0 = F49B67B7.Checked;
				}
				break;
			case 515982676u:
				if (text2 == "ckbGetTokenWhenDie")
				{
					object_0 = D30C68B8.Checked;
				}
				break;
			case 852229013u:
				if (text2 == "nudDelayOpenChromeFrom")
				{
					object_0 = FD9C2193.Value;
				}
				break;
			case 746707643u:
				if (text2 == "rbChayBangToken")
				{
					object_0 = rbChayBangToken.Checked;
				}
				break;
			case 974388905u:
				if (text2 == "nudBreakTimeJob")
				{
					object_0 = nudBreakTimeJob.Value;
				}
				break;
			case 891328588u:
				if (text2 == "txtApiKey")
				{
					object_0 = txtApiKey.Text.Trim();
				}
				break;
			case 1413853044u:
				if (text2 == "nudMaxChrome")
				{
					if (rbChayBangChrome.Checked)
					{
						object_0 = F40A5030.Value;
					}
					else
					{
						object_0 = nudMaxChrome.Value;
					}
				}
				break;
			case 1379533532u:
				if (text2 == "cbbFacebookWeb")
				{
					object_0 = cbbFacebookWeb.SelectedIndex;
				}
				break;
			case 1497969250u:
				if (text2 == "nudDelayTo")
				{
					object_0 = nudDelayTo.Value;
				}
				break;
			case 1429197780u:
				if (text2 == "rbChayBangCookie")
				{
					object_0 = rbChayBangCookie.Checked;
				}
				break;
			case 1616992167u:
				if (text2 == "nudMaxJobFailLienTiep")
				{
					object_0 = F18113B8.Value;
				}
				break;
			case 1566765699u:
				if (text2 == "cbbTypeLogin")
				{
					object_0 = EE3D8093.SelectedIndex;
				}
				break;
			case 1522640821u:
				if (text2 == "ckbUnlock956")
				{
					object_0 = false;
				}
				break;
			case 1978863315u:
				if (text2 == "cbbChangeIP")
				{
					object_0 = cbbChangeIP.SelectedIndex;
				}
				break;
			case 1649225820u:
				if (text2 == "nudTimeoutGetJob")
				{
					object_0 = nudTimeoutGetJob.Value;
				}
				break;
			case 2202188651u:
				if (text2 == "nudDelayFrom")
				{
					object_0 = AF0B1AB0.Value;
				}
				break;
			case 1998700759u:
				if (text2 == "ckbRepeatAll")
				{
					object_0 = B50940A9.Checked;
				}
				break;
			case 2434389140u:
				if (text2 == "jobType")
				{
					object_0 = method_74();
				}
				break;
			case 2206630411u:
				if (text2 == "typeRunBy")
				{
					if (rbChayBangCookie.Checked)
					{
						object_0 = 1;
					}
					else if (rbChayBangChrome.Checked)
					{
						object_0 = 2;
					}
					else if (rbChayBangToken.Checked)
					{
						object_0 = 0;
					}
				}
				break;
			case 2873782386u:
				if (text2 == "cbbGetTokenBy")
				{
					object_0 = cbbGetTokenBy.SelectedValue.ToString();
				}
				break;
			case 2688776952u:
				if (text2 == "nudThread")
				{
					object_0 = F40A5030.Value;
				}
				break;
			case 3117465753u:
				if (text2 == "ckbShowImageInteract")
				{
					object_0 = ckbShowImageInteract.Checked;
				}
				break;
			case 3046996904u:
				if (text2 == "ckbChayBangPageProfile")
				{
					object_0 = ckbChayBangPageProfile.Checked;
				}
				break;
			case 3505163287u:
				if (text2 == "cbbTypeGetToken")
				{
					object_0 = EF1D13BA.SelectedIndex;
				}
				break;
			case 3205543473u:
				if (text2 == "cbbServer")
				{
					object_0 = cbbServer.SelectedIndex;
				}
				break;
			case 3780799556u:
				if (text2 == "nudDelayOpenChromeTo")
				{
					object_0 = nudDelayOpenChromeTo.Value;
				}
				break;
			case 3592451558u:
				if (text2 == "nudBreakTime")
				{
					object_0 = F62E8310.Value;
				}
				break;
			case 4132434353u:
				if (text2 == "ckbHideBrowser")
				{
					object_0 = ckbHideBrowser.Checked;
				}
				break;
			case 4122074087u:
				if (text2 == "ckbBreakTime")
				{
					object_0 = CEBA2D85.Checked;
				}
				break;
			case 3835769819u:
				if (text2 == "ckbCheckLiveUid")
				{
					object_0 = ckbCheckLiveUid.Checked;
				}
				break;
			}
		});
		return object_0;
	}

	public int B190710B()
	{
		return int_3;
	}

	public void method_75()
	{
		if (int_3 != 0)
		{
			int_3--;
			method_77();
		}
	}

	public void method_76()
	{
		int_3++;
		method_77();
	}

	private void method_77()
	{
		try
		{
			Invoke((MethodInvoker)delegate
			{
				lblCountChrome.Text = int_3.ToString();
			});
		}
		catch (Exception)
		{
		}
	}

	private void method_78()
	{
		try
		{
			lock (dictionary_28)
			{
				Invoke((MethodInvoker)delegate
				{
					lblCountRunning.Text = dictionary_28.Count.ToString();
				});
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_79(int BF87C4BB)
	{
		try
		{
			lock (dictionary_28)
			{
				dictionary_28.Remove(BF87C4BB);
				if (dictionary_28.Count == 0)
				{
					GClass27.E68A6883(EB3CF7AF, bool_0: true);
					C3BBF8AC.C22B543F();
					ckbChayBangPageProfile.C22B543F();
					grRunBy.C22B543F();
				}
			}
			method_78();
		}
		catch (Exception)
		{
		}
	}

	private void BD0C5384(object sender, EventArgs e)
	{
		Class57.A39EDD1D(bool_9: false);
		A6A691B6();
		if (!method_54())
		{
			return;
		}
		GClass27.E68A6883(EB3CF7AF, bool_0: false);
		C3BBF8AC.C22B543F(bool_0: false);
		ckbChayBangPageProfile.C22B543F(bool_0: false);
		grRunBy.C22B543F(bool_0: false);
		int_2 = 0;
		new Thread((ThreadStart)delegate
		{
			try
			{
				btnInteract.C22B543F(bool_0: false);
				while (true)
				{
					try
					{
						A235CA9E = new List<Thread>();
						for (int i = 0; i < EB3CF7AF.RowCount; i++)
						{
							if (Class57.smethod_5())
							{
								break;
							}
							if (Convert.ToBoolean(EB3CF7AF.Rows[i].Cells["cChose"].Value) && !dictionary_28.ContainsKey(i))
							{
								if ((decimal)dictionary_28.Count >= F40A5030.Value)
								{
									GClass8.smethod_53(1.0);
									i--;
								}
								else
								{
									if (Class57.smethod_5())
									{
										break;
									}
									int int_0 = i;
									dictionary_28.Add(int_0, new E31BC589(this, int_0));
									Thread thread = new Thread((ThreadStart)delegate
									{
										try
										{
											dictionary_28[int_0].FB2B639E();
										}
										catch (Exception)
										{
										}
									})
									{
										IsBackground = true
									};
									A235CA9E.Add(thread);
									thread.Start();
									method_78();
									GClass8.smethod_53(0.1);
								}
							}
						}
						if (!Class57.smethod_5() && Convert.ToBoolean(B50940A9.Checked))
						{
							for (int j = 0; j < A235CA9E.Count; j++)
							{
								A235CA9E[j].Join();
							}
							if (Convert.ToBoolean(B50940A9.Checked) && AB0B20AA() != 0)
							{
								continue;
							}
						}
					}
					catch (Exception)
					{
						continue;
					}
					break;
				}
				btnInteract.C22B543F();
			}
			catch (Exception ex2)
			{
				GClass29.smethod_0("btnInteract_Click\n" + ex2.ToString());
			}
		}).Start();
	}

	private void B6B78532(Control FD29398A)
	{
		string FD35A3B3;
		int C78A29BC;
		int int_0;
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				FD35A3B3 = FD29398A.Text;
				FD29398A.Invoke((MethodInvoker)delegate
				{
					FD29398A.Enabled = false;
				});
				C78A29BC = 5;
				int_0 = Environment.TickCount;
				while ((Environment.TickCount - int_0) / 1000 - C78A29BC < 0)
				{
					FD29398A.Invoke((MethodInvoker)delegate
					{
						FD29398A.Text = "Đợi " + (C78A29BC - (Environment.TickCount - int_0) / 1000) + "s...";
					});
					GClass8.smethod_53(0.5);
				}
				FD29398A.Invoke((MethodInvoker)delegate
				{
					FD29398A.Text = FD35A3B3;
					FD29398A.Enabled = true;
				});
			}
			catch (Exception)
			{
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void method_80(object sender, EventArgs e)
	{
	}

	private void D38B1C9D(object sender, EventArgs e)
	{
		string text = txtApiKey.Text.Trim();
		string eD = D32B691F.CBAB1D17(text);
		GClass29.smethod_0(eD);
	}

	private void D99BA487_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.smethod_33(new C4B7D633("956"));
	}

	private void txtApiKey_TextChanged(object sender, EventArgs e)
	{
	}

	private void AB95ECA2(object sender, EventArgs e)
	{
		B6B78532(sender as Control);
		for (int i = 0; i < EB3CF7AF.Rows.Count; i++)
		{
			if (Convert.ToBoolean(EB3CF7AF.Rows[i].Cells["cChose"].Value))
			{
				int key = i;
				if (dictionary_28.ContainsKey(key))
				{
					dictionary_28[key].CD326A89();
				}
			}
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		B6B78532(sender as Control);
		foreach (KeyValuePair<int, E31BC589> item in dictionary_28)
		{
			item.Value.CD326A89();
		}
		Class57.A39EDD1D(bool_9: true);
	}

	private void C53947BC(object sender, EventArgs e)
	{
		if (!(btnHienCaiDat.Text == "Hiện cài đặt") && !(btnHienCaiDat.Text == F7AB102E.smethod_0("Hiện cài đặt")))
		{
			B1A9102B.method_4("hideSettings", true);
			btnHienCaiDat.Text = F7AB102E.smethod_0("Hiện cài đặt");
			EB3CF7AF.Location = new Point(EB3CF7AF.Location.X, EB3CF7AF.Location.Y - 239);
			EB3CF7AF.Size = new Size(EB3CF7AF.Size.Width, EB3CF7AF.Size.Height + 239);
			grChonJob.Visible = false;
		}
		else
		{
			B1A9102B.method_4("hideSettings", false);
			btnHienCaiDat.Text = F7AB102E.smethod_0("Ẩn cài đặt");
			EB3CF7AF.Location = new Point(EB3CF7AF.Location.X, EB3CF7AF.Location.Y + 239);
			EB3CF7AF.Size = new Size(EB3CF7AF.Size.Width, EB3CF7AF.Size.Height - 239);
			grChonJob.Visible = true;
		}
	}

	private void checkGolikeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		GClass8.smethod_33(new FD08DB8D());
	}

	private void DE07A521(object sender, EventArgs e)
	{
		plBreakTime.Enabled = CEBA2D85.Checked;
	}

	private void ckbChayBangPageProfile_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void toolStripMenuItem4_Click(object sender, EventArgs e)
	{
		F1AE779A("cUid");
	}

	private void toolStripMenuItem5_Click(object sender, EventArgs e)
	{
		F1AE779A("cPassword");
	}

	private void D8B059B6(object sender, EventArgs e)
	{
		F1AE779A("cToken");
	}

	private void A3B95D0C(object sender, EventArgs e)
	{
		F1AE779A("cCookies");
	}

	private void F68BCBA6(object sender, EventArgs e)
	{
		F1AE779A("cEmail");
	}

	private void D420C231(object sender, EventArgs e)
	{
		if (Class57.smethod_3())
		{
			F1AE779A("cFa2");
		}
	}

	private void toolStripMenuItem10_Click(object sender, EventArgs e)
	{
		F1AE779A("cMa2Fa");
	}

	private void toolStripMenuItem11_Click(object sender, EventArgs e)
	{
		F1AE779A("cUid|cPassword");
	}

	private void C0AAAABC(object sender, EventArgs e)
	{
		if (Class57.smethod_3())
		{
			F1AE779A("cUid|cPassword|cFa2");
		}
	}

	private void D9147292(object sender, EventArgs e)
	{
		F1AE779A("cEmail|cPassMail");
	}

	private void C81928AB(object sender, EventArgs e)
	{
		F1AE779A("cEmail|cPassMail|cMailRecovery");
	}

	private void toolStripMenuItem15_Click(object sender, EventArgs e)
	{
		F1AE779A("cUid|cPassword|cToken|cCookies");
	}

	private void toolStripMenuItem16_Click(object sender, EventArgs e)
	{
		F1AE779A("cUid|cPassword|cToken|cCookies|cEmail|cPassMail");
	}

	private void toolStripMenuItem17_Click(object sender, EventArgs e)
	{
		if (Class57.smethod_3())
		{
			F1AE779A("cUid|cPassword|cToken|cCookies|cEmail|cPassMail|cFa2");
		}
	}

	private void E53062A2_Click(object sender, EventArgs e)
	{
		F1AE779A("cUseragent");
	}

	private void AF26FD8B_Click(object sender, EventArgs e)
	{
		F1AE779A("cProxy");
	}

	private void CB1F2182_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = method_9("cUid|cPassword|cToken|cCookies|cEmail|cEmail2|cPassMail|cFa2|cUseragent|cProxy|cName|cGender|cFollow|cFriend|cGroup|cBirthday|cDateCreateAcc|cGhiChu|cLocation|cMailRecovery|cInteractEnd|cDating|cAds|cBM");
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

	private void cbbServer_SelectedIndexChanged(object sender, EventArgs e)
	{
		string eD = "Vui lo\u0300ng cho\u0323n server tương ư\u0301ng vơ\u0301i ta\u0300i nguyên:\n1. Server Viê\u0323t Nam: Du\u0300ng ta\u0300i nguyên Viê\u0323t (tên Viê\u0323t + avatar Viê\u0323t)\n2. Server Philippines: Du\u0300ng ta\u0300i nguyên Philippines (tên Philippines + avatar Philippines)\n3. Server US: Du\u0300ng ta\u0300i nguyên US (tên US + avatar US)\n3. Server Thailand: Du\u0300ng ta\u0300i nguyên Thailand (tên Thailand + avatar Thailand)\n\nNê\u0301u sư\u0309 du\u0323ng ta\u0300i nguyên không đu\u0301ng vơ\u0301i server thi\u0300 se\u0303 bi\u0323 trư\u0300 toa\u0300n bô\u0323 xu va\u0300 kho\u0301a ta\u0300i khoa\u0309n vi\u0303nh viê\u0303n!";
		GClass29.smethod_0(eD, 2);
	}

	private void method_81()
	{
		List<string> list = new List<string> { "job_all" };
		if (rbChayBangChrome.Checked)
		{
			list.AddRange("commentfb,commentfb_via2,commentfb_via_male2,commentfb_via_female2,commentfb_full_avatar2".Split(','));
		}
		else if (rbChayBangCookie.Checked)
		{
			list.AddRange("like,love,care,haha,wow,sad,angry,like_comment,follow,like_page,join_group,review_page".Split(','));
		}
		else if (rbChayBangToken.Checked)
		{
			if (EF1D13BA.SelectedIndex == 0)
			{
				list.AddRange("like,love,haha,wow,sad,angry,like_comment,commentfb,commentfb_via2,commentfb_via_male2,commentfb_via_female2,commentfb_full_avatar2,share,follow,like_page,join_group".Split(','));
			}
			else if (EF1D13BA.SelectedIndex == 1)
			{
				list.AddRange("like,love,haha,wow,sad,angry,like_comment,commentfb,commentfb_via2,commentfb_via_male2,commentfb_via_female2,commentfb_full_avatar2,share,follow,like_page,join_group".Split(','));
			}
			else
			{
				if (EF1D13BA.SelectedIndex != 2)
				{
					return;
				}
				list.AddRange("like,love,haha,wow,sad,angry,like_comment,share,follow,like_page".Split(','));
			}
		}
		list = list.Distinct().ToList();
		foreach (CheckBox item in list_2)
		{
			if (list.Contains(item.Name.Substring(3).ToLower()))
			{
				item.Enabled = true;
				continue;
			}
			item.Enabled = false;
			item.Checked = false;
		}
	}

	private void EF1D13BA_SelectedIndexChanged(object sender, EventArgs e)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		switch (EF1D13BA.SelectedIndex)
		{
		case 1:
			dictionary.Add("uid", "Uid|Pass");
			dictionary.Add("chrome", "Chrome");
			dictionary.Add("cookie", "Cookie");
			break;
		case 0:
		case 2:
			dictionary.Add("chrome", "Chrome");
			dictionary.Add("cookie", "Cookie");
			break;
		}
		GClass8.smethod_23(cbbGetTokenBy, dictionary);
		method_81();
	}

	private void EF290A91(CheckBox checkBox_0)
	{
	}

	private void E2035928_Click(object sender, EventArgs e)
	{
		string dAAF728A = C413DEAD.Text.Trim();
		string text = FA15011F(dAAF728A);
		if (text == "")
		{
			GClass29.smethod_0("Key không hợp lệ!", 3);
		}
		else
		{
			GClass29.smethod_0(text);
		}
	}

	private string FA15011F(string DAAF728A = null)
	{
		Class57.bool_1 = false;
		Class57.bool_2 = false;
		Class57.bool_3 = false;
		Class57.bool_4 = false;
		Class57.bool_5 = false;
		Class57.bool_6 = false;
		Class57.bool_7 = false;
		Class57.int_0 = -2;
		ckbCommentfb_full_avatar2.Visible = Class57.bool_2;
		A73F6F03.Visible = Class57.bool_1;
		if (DAAF728A == null)
		{
			DAAF728A = B1A9102B.C0288288("txtKey");
		}
		DAAF728A = GClass8.A2307E3B(DAAF728A);
		if (DAAF728A.Split('|').Length < 3)
		{
			return "";
		}
		List<string> list = new List<string>();
		string text = DAAF728A.Split('|')[0];
		if (GClass8.smethod_44(text))
		{
			Class57.int_0 = -Convert.ToInt32(text);
		}
		list.Add("URL: apiv" + -Class57.int_0);
		string text2 = DAAF728A.Split('|')[1];
		list.Add("SERVER: " + text2);
		switch (text2)
		{
		default:
			list.Remove("SERVER: " + text2);
			list.Add("SERVER: ");
			break;
		case "phi":
			Class57.bool_7 = true;
			break;
		case "thai_via":
			Class57.bool_6 = true;
			break;
		case "thai_thuong":
			Class57.bool_5 = true;
			break;
		case "indo":
			Class57.bool_4 = true;
			break;
		}
		List<string> list2 = new List<string>();
		string text3 = DAAF728A.Split('|')[2];
		if (text3.Contains("comment_via"))
		{
			Class57.bool_1 = true;
			list2.Add("comment_via");
		}
		if (text3.Contains("comment_avatar"))
		{
			Class57.bool_2 = true;
			list2.Add("comment_avatar");
		}
		if (text3.Contains("review_page"))
		{
			Class57.bool_3 = true;
			list2.Add("review_page");
		}
		list.Add("JOB: " + string.Join(",", list2));
		ckbCommentfb_full_avatar2.Visible = Class57.bool_2;
		A73F6F03.Visible = Class57.bool_1;
		return string.Join("\n", list);
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			plKey.Visible = true;
		}
	}

	private void rbChayBangToken_CheckedChanged(object sender, EventArgs e)
	{
		plChayBangToken.Enabled = rbChayBangToken.Checked;
		method_81();
	}

	private void D3BB493A(object sender, EventArgs e)
	{
		method_81();
	}

	private void rbChayBangChrome_CheckedChanged(object sender, EventArgs e)
	{
		method_81();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A6BA4B90));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		ctmsAcc = new System.Windows.Forms.ContextMenuStrip(icontainer_0);
		toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		B789AA08 = new System.Windows.Forms.ToolStripMenuItem();
		E10A271D = new System.Windows.Forms.ToolStripMenuItem();
		tinhTrangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		E784828B = new System.Windows.Forms.ToolStripMenuItem();
		C8A8A0A5 = new System.Windows.Forms.ToolStripMenuItem();
		BF379492 = new System.Windows.Forms.ToolStripMenuItem();
		AD85CC0E = new System.Windows.Forms.ToolStripMenuItem();
		A7BA973D = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		B303123E = new System.Windows.Forms.ToolStripMenuItem();
		uidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		passToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		A824BF38 = new System.Windows.Forms.ToolStripMenuItem();
		cookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		mailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		fAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_8 = new System.Windows.Forms.ToolStripMenuItem();
		uidPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		uidPass2FaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		mailPassMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		emailPassMailMailKpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		D281F59B = new System.Windows.Forms.ToolStripMenuItem();
		uidPassTokenCookieMailPassMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		AB28FC9F = new System.Windows.Forms.ToolStripMenuItem();
		F586C109 = new System.Windows.Forms.ToolStripMenuItem();
		D8123B8B = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_7 = new System.Windows.Forms.ToolStripMenuItem();
		BD1D0DA4 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
		A48F96AF = new System.Windows.Forms.ToolStripMenuItem();
		C1233E0A = new System.Windows.Forms.ToolStripMenuItem();
		C9B47E80 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
		E53062A2 = new System.Windows.Forms.ToolStripMenuItem();
		AF26FD8B = new System.Windows.Forms.ToolStripMenuItem();
		CB1F2182 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		E00A8821 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_15 = new System.Windows.Forms.ToolStripMenuItem();
		A51845B4 = new System.Windows.Forms.ToolStripMenuItem();
		checkCookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		C498B099 = new System.Windows.Forms.ToolStripMenuItem();
		checkInfoUIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_18 = new System.Windows.Forms.ToolStripMenuItem();
		B396C512 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
		checkAvatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_19 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_20 = new System.Windows.Forms.ToolStripMenuItem();
		checkProfileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_10 = new System.Windows.Forms.ToolStripMenuItem();
		DCB311B2 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_6 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_14 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		mnuChucNang = new System.Windows.Forms.ToolStripMenuItem();
		lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		locTrungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_17 = new System.Windows.Forms.ToolStripMenuItem();
		checkNameVNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		checkProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_21 = new System.Windows.Forms.ToolStripMenuItem();
		B005D087 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_22 = new System.Windows.Forms.ToolStripMenuItem();
		A900291F = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_5 = new System.Windows.Forms.ToolStripMenuItem();
		getTokenEAAAAUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		getTokenEAAAAUBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		C00C0E9C = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		C90B629E = new System.Windows.Forms.Button();
		BF851712 = new System.Windows.Forms.Button();
		btnClose = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		menuStrip1 = new System.Windows.Forms.MenuStrip();
		toolStripMenuItem_9 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_11 = new System.Windows.Forms.ToolStripMenuItem();
		checkLiveUidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		checkProxyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		checkHotmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_12 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_13 = new System.Windows.Forms.ToolStripMenuItem();
		checkStatusXproxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		testSpinTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		checkGolikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_16 = new System.Windows.Forms.ToolStripMenuItem();
		D81FA988 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		E9372C3C = new System.Windows.Forms.ToolTip(icontainer_0);
		FEAB929D = new System.Windows.Forms.Button();
		FA856528 = new System.Windows.Forms.Button();
		btnEditFile = new System.Windows.Forms.Button();
		btnLoadAcc = new System.Windows.Forms.Button();
		btnInteract = new System.Windows.Forms.Button();
		F5948F3E = new System.Windows.Forms.Panel();
		EF36EA35 = new System.Windows.Forms.Label();
		EA0BF912 = new System.Windows.Forms.StatusStrip();
		toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
		E71E4104 = new System.Windows.Forms.ToolStripStatusLabel();
		CF1A928E = new System.Windows.Forms.ToolStripStatusLabel();
		lblCountSelect = new System.Windows.Forms.ToolStripStatusLabel();
		toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
		lblCountTotal = new System.Windows.Forms.ToolStripStatusLabel();
		metroButton1 = new System.Windows.Forms.Button();
		EF907231 = new System.Windows.Forms.Panel();
		C0290281 = new System.Windows.Forms.Button();
		DC2BDDA5 = new System.Windows.Forms.ComboBox();
		txbSearch = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
		C3BBF8AC = new System.Windows.Forms.Panel();
		cbbTinhTrang = new System.Windows.Forms.ComboBox();
		label1 = new System.Windows.Forms.Label();
		button9 = new System.Windows.Forms.Button();
		label2 = new System.Windows.Forms.Label();
		cbbThuMuc = new System.Windows.Forms.ComboBox();
		panel1 = new System.Windows.Forms.Panel();
		EB3CF7AF = new System.Windows.Forms.DataGridView();
		cChose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
		FD886B35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		F2BE232E = new System.Windows.Forms.DataGridViewTextBoxColumn();
		DC2D399A = new System.Windows.Forms.DataGridViewTextBoxColumn();
		E128C7A9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cCookies = new System.Windows.Forms.DataGridViewTextBoxColumn();
		A4209E84 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cEmail2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cPassMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cMailRecovery = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cPassMailRecovery = new System.Windows.Forms.DataGridViewTextBoxColumn();
		CABFF297 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cFollow = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cFriend = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cPagePro5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		E23A412F = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cOAuth2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		CFB06338 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cProxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
		F7AF4722 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cAvatar = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cProfile = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cThuMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cInteractEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
		BBB2678F = new System.Windows.Forms.DataGridViewTextBoxColumn();
		D61BBD3F = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cStatus282 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cHometown = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cCurrentCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cDating = new System.Windows.Forms.DataGridViewTextBoxColumn();
		A2919486 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cWallPosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
		C7A5BE91 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		EA8C022B = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cKichBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
		tabControl1 = new System.Windows.Forms.TabControl();
		BB832C28 = new System.Windows.Forms.TabPage();
		B38E60B4 = new System.Windows.Forms.GroupBox();
		C129E939 = new System.Windows.Forms.Label();
		B50940A9 = new System.Windows.Forms.CheckBox();
		label9 = new System.Windows.Forms.Label();
		F40A5030 = new System.Windows.Forms.NumericUpDown();
		cbbChangeIP = new System.Windows.Forms.ComboBox();
		CB30E000 = new System.Windows.Forms.GroupBox();
		ckbShowImageInteract = new System.Windows.Forms.CheckBox();
		nudDelayOpenChromeTo = new System.Windows.Forms.NumericUpDown();
		label6 = new System.Windows.Forms.Label();
		cbbFacebookWeb = new System.Windows.Forms.ComboBox();
		EE3D8093 = new System.Windows.Forms.ComboBox();
		label29 = new System.Windows.Forms.Label();
		nudMaxChrome = new System.Windows.Forms.NumericUpDown();
		label8 = new System.Windows.Forms.Label();
		E604DA36 = new System.Windows.Forms.Label();
		FD9C2193 = new System.Windows.Forms.NumericUpDown();
		ckbHideBrowser = new System.Windows.Forms.CheckBox();
		label20 = new System.Windows.Forms.Label();
		ckbUnlock956 = new System.Windows.Forms.CheckBox();
		D99BA487 = new System.Windows.Forms.LinkLabel();
		ckbCheckProxy = new System.Windows.Forms.CheckBox();
		F49B67B7 = new System.Windows.Forms.CheckBox();
		ckbCheckLiveUid = new System.Windows.Forms.CheckBox();
		tabPage3 = new System.Windows.Forms.TabPage();
		grRunBy = new System.Windows.Forms.GroupBox();
		rbChayBangToken = new System.Windows.Forms.RadioButton();
		rbChayBangCookie = new System.Windows.Forms.RadioButton();
		plChayBangToken = new System.Windows.Forms.Panel();
		label19 = new System.Windows.Forms.Label();
		label10 = new System.Windows.Forms.Label();
		cbbGetTokenBy = new System.Windows.Forms.ComboBox();
		D30C68B8 = new System.Windows.Forms.CheckBox();
		EF1D13BA = new System.Windows.Forms.ComboBox();
		rbChayBangChrome = new System.Windows.Forms.RadioButton();
		A739F720 = new System.Windows.Forms.GroupBox();
		FB1741A8 = new System.Windows.Forms.Label();
		F98E5B8A = new System.Windows.Forms.Label();
		B706E7AC = new System.Windows.Forms.Button();
		ckbChayBangPageProfile = new System.Windows.Forms.CheckBox();
		B3A671B1 = new System.Windows.Forms.Label();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		BD8A7F88 = new System.Windows.Forms.Label();
		plBreakTime = new System.Windows.Forms.Panel();
		nudBreakTimeJob = new System.Windows.Forms.NumericUpDown();
		label24 = new System.Windows.Forms.Label();
		DFB28682 = new System.Windows.Forms.Label();
		F62E8310 = new System.Windows.Forms.NumericUpDown();
		label13 = new System.Windows.Forms.Label();
		A63DDA9B = new System.Windows.Forms.NumericUpDown();
		E62B17A7 = new System.Windows.Forms.Label();
		txtApiKey = new System.Windows.Forms.TextBox();
		C7BBA9A1 = new System.Windows.Forms.Label();
		CEBA2D85 = new System.Windows.Forms.CheckBox();
		label7 = new System.Windows.Forms.Label();
		F18113B8 = new System.Windows.Forms.NumericUpDown();
		E4B49E18 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		nudTimeoutGetJob = new System.Windows.Forms.NumericUpDown();
		AF0B1AB0 = new System.Windows.Forms.NumericUpDown();
		grChonJob = new System.Windows.Forms.GroupBox();
		btnDown = new System.Windows.Forms.Button();
		plKey = new System.Windows.Forms.Panel();
		lblKey = new System.Windows.Forms.Label();
		C413DEAD = new System.Windows.Forms.TextBox();
		E2035928 = new System.Windows.Forms.Button();
		ckbCheckAll = new System.Windows.Forms.CheckBox();
		lblServer = new System.Windows.Forms.Label();
		ckbCommentfb_via_male2 = new System.Windows.Forms.CheckBox();
		ckbCommentfb_via_female2 = new System.Windows.Forms.CheckBox();
		ckbLikePage_PageProfile = new System.Windows.Forms.CheckBox();
		cbbServer = new System.Windows.Forms.ComboBox();
		ckbFollow = new System.Windows.Forms.CheckBox();
		D3011989 = new System.Windows.Forms.CheckBox();
		A73F6F03 = new System.Windows.Forms.CheckBox();
		ckbCommentfb_full_avatar2 = new System.Windows.Forms.CheckBox();
		ckbCommentfb = new System.Windows.Forms.CheckBox();
		ckbJoin_Group = new System.Windows.Forms.CheckBox();
		EF91F21A = new System.Windows.Forms.CheckBox();
		ckbAngry = new System.Windows.Forms.CheckBox();
		ckbHaha = new System.Windows.Forms.CheckBox();
		F7BC6739 = new System.Windows.Forms.CheckBox();
		ckbCare = new System.Windows.Forms.CheckBox();
		D69B8981 = new System.Windows.Forms.CheckBox();
		ckbLove = new System.Windows.Forms.CheckBox();
		ckbLike = new System.Windows.Forms.CheckBox();
		ckbLike_Comment = new System.Windows.Forms.CheckBox();
		ckbShare = new System.Windows.Forms.CheckBox();
		FE0EEC0F = new System.Windows.Forms.CheckBox();
		button2 = new System.Windows.Forms.Button();
		D9927D91 = new System.Windows.Forms.Button();
		btnHienCaiDat = new System.Windows.Forms.Button();
		statusStrip1 = new System.Windows.Forms.StatusStrip();
		CF8E9634 = new System.Windows.Forms.ToolStripStatusLabel();
		lblCountRunning = new System.Windows.Forms.ToolStripStatusLabel();
		C5B60C89 = new System.Windows.Forms.ToolStripStatusLabel();
		lblCountChrome = new System.Windows.Forms.ToolStripStatusLabel();
		ctmsAcc.SuspendLayout();
		C00C0E9C.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		bunifuCards1.SuspendLayout();
		menuStrip1.SuspendLayout();
		F5948F3E.SuspendLayout();
		EF907231.SuspendLayout();
		C3BBF8AC.SuspendLayout();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)EB3CF7AF).BeginInit();
		tabControl1.SuspendLayout();
		BB832C28.SuspendLayout();
		B38E60B4.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)F40A5030).BeginInit();
		CB30E000.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayOpenChromeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudMaxChrome).BeginInit();
		((System.ComponentModel.ISupportInitialize)FD9C2193).BeginInit();
		tabPage3.SuspendLayout();
		grRunBy.SuspendLayout();
		plChayBangToken.SuspendLayout();
		A739F720.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		plBreakTime.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudBreakTimeJob).BeginInit();
		((System.ComponentModel.ISupportInitialize)F62E8310).BeginInit();
		((System.ComponentModel.ISupportInitialize)A63DDA9B).BeginInit();
		((System.ComponentModel.ISupportInitialize)F18113B8).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeoutGetJob).BeginInit();
		((System.ComponentModel.ISupportInitialize)AF0B1AB0).BeginInit();
		grChonJob.SuspendLayout();
		plKey.SuspendLayout();
		statusStrip1.SuspendLayout();
		SuspendLayout();
		ctmsAcc.Items.AddRange(new System.Windows.Forms.ToolStripItem[14]
		{
			toolStripMenuItem_0, AD85CC0E, A7BA973D, toolStripMenuItem1, B303123E, BD1D0DA4, toolStripMenuItem_1, A51845B4, checkCookieToolStripMenuItem, toolStripMenuItem_6,
			toolStripMenuItem_2, mnuChucNang, profileToolStripMenuItem, toolStripMenuItem_5
		});
		ctmsAcc.Name = "ctmsAcc";
		ctmsAcc.Size = new System.Drawing.Size(181, 312);
		ctmsAcc.Opening += new System.ComponentModel.CancelEventHandler(ctmsAcc_Opening);
		toolStripMenuItem_0.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[6] { B789AA08, E10A271D, tinhTrangToolStripMenuItem, E784828B, C8A8A0A5, BF379492 });
		toolStripMenuItem_0.Image = (System.Drawing.Image)resources.GetObject("chọnLiveToolStripMenuItem.Image");
		toolStripMenuItem_0.Name = "chọnLiveToolStripMenuItem";
		toolStripMenuItem_0.Size = new System.Drawing.Size(180, 22);
		toolStripMenuItem_0.Text = "Chọn";
		B789AA08.Image = (System.Drawing.Image)resources.GetObject("tấtCảToolStripMenuItem.Image");
		B789AA08.Name = "tấtCảToolStripMenuItem";
		B789AA08.Size = new System.Drawing.Size(128, 22);
		B789AA08.Text = "Tất cả";
		B789AA08.Click += new System.EventHandler(B789AA08_Click);
		E10A271D.Image = (System.Drawing.Image)resources.GetObject("liveToolStripMenuItem.Image");
		E10A271D.Name = "liveToolStripMenuItem";
		E10A271D.Size = new System.Drawing.Size(128, 22);
		E10A271D.Text = "Bôi đen";
		E10A271D.Click += new System.EventHandler(E10A271D_Click);
		tinhTrangToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("tinhTrangToolStripMenuItem.Image");
		tinhTrangToolStripMenuItem.Name = "tinhTrangToolStripMenuItem";
		tinhTrangToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
		tinhTrangToolStripMenuItem.Text = "Ti\u0300nh tra\u0323ng";
		E784828B.Image = (System.Drawing.Image)resources.GetObject("trạngTháiToolStripMenuItem.Image");
		E784828B.Name = "trạngTháiToolStripMenuItem";
		E784828B.Size = new System.Drawing.Size(128, 22);
		E784828B.Text = "Trạng thái";
		E784828B.Click += new System.EventHandler(E784828B_Click);
		C8A8A0A5.Image = (System.Drawing.Image)resources.GetObject("chDanhSáchTheoUIDEmailToolStripMenuItem.Image");
		C8A8A0A5.Name = "chDanhSáchTheoUIDEmailToolStripMenuItem";
		C8A8A0A5.Size = new System.Drawing.Size(128, 22);
		C8A8A0A5.Text = "Theo Uid";
		C8A8A0A5.Click += new System.EventHandler(C8A8A0A5_Click);
		BF379492.Image = (System.Drawing.Image)resources.GetObject("ghiChúToolStripMenuItem.Image");
		BF379492.Name = "ghiChúToolStripMenuItem";
		BF379492.Size = new System.Drawing.Size(128, 22);
		BF379492.Text = "Ghi chu\u0301";
		BF379492.MouseEnter += new System.EventHandler(BF379492_MouseEnter);
		AD85CC0E.Image = (System.Drawing.Image)resources.GetObject("bỏChọnTấtCảToolStripMenuItem.Image");
		AD85CC0E.Name = "bỏChọnTấtCảToolStripMenuItem";
		AD85CC0E.Size = new System.Drawing.Size(180, 22);
		AD85CC0E.Text = "Bỏ chọn tất cả";
		AD85CC0E.Click += new System.EventHandler(AD85CC0E_Click);
		A7BA973D.Image = (System.Drawing.Image)resources.GetObject("ẩnKhỏiDanhSachToolStripMenuItem.Image");
		A7BA973D.Name = "ẩnKhỏiDanhSachToolStripMenuItem";
		A7BA973D.Size = new System.Drawing.Size(180, 22);
		A7BA973D.Text = "Ẩn dòng tích chọn";
		A7BA973D.Click += new System.EventHandler(A7BA973D_Click);
		toolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem1.Image");
		toolStripMenuItem1.Name = "toolStripMenuItem1";
		toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
		toolStripMenuItem1.Text = "Ẩn dòng không tích";
		toolStripMenuItem1.Click += new System.EventHandler(toolStripMenuItem1_Click);
		B303123E.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[17]
		{
			uidToolStripMenuItem, passToolStripMenuItem, A824BF38, cookieToolStripMenuItem, mailToolStripMenuItem, fAToolStripMenuItem, toolStripMenuItem_8, uidPassToolStripMenuItem, uidPass2FaToolStripMenuItem, mailPassMailToolStripMenuItem,
			emailPassMailMailKpToolStripMenuItem, D281F59B, uidPassTokenCookieMailPassMailToolStripMenuItem, AB28FC9F, F586C109, D8123B8B, toolStripMenuItem_7
		});
		B303123E.Image = (System.Drawing.Image)resources.GetObject("copyToolStripMenuItem.Image");
		B303123E.Name = "copyToolStripMenuItem";
		B303123E.Size = new System.Drawing.Size(180, 22);
		B303123E.Text = "Copy";
		uidToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidToolStripMenuItem.Image");
		uidToolStripMenuItem.Name = "uidToolStripMenuItem";
		uidToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		uidToolStripMenuItem.Text = "Uid";
		uidToolStripMenuItem.Click += new System.EventHandler(FA348D03);
		passToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("passToolStripMenuItem.Image");
		passToolStripMenuItem.Name = "passToolStripMenuItem";
		passToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		passToolStripMenuItem.Text = "Pass";
		passToolStripMenuItem.Click += new System.EventHandler(passToolStripMenuItem_Click);
		A824BF38.Image = (System.Drawing.Image)resources.GetObject("tokenToolStripMenuItem.Image");
		A824BF38.Name = "tokenToolStripMenuItem";
		A824BF38.Size = new System.Drawing.Size(289, 22);
		A824BF38.Text = "Token";
		A824BF38.Click += new System.EventHandler(A824BF38_Click);
		cookieToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("cookieToolStripMenuItem.Image");
		cookieToolStripMenuItem.Name = "cookieToolStripMenuItem";
		cookieToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		cookieToolStripMenuItem.Text = "Cookie";
		cookieToolStripMenuItem.Click += new System.EventHandler(cookieToolStripMenuItem_Click);
		mailToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("mailToolStripMenuItem.Image");
		mailToolStripMenuItem.Name = "mailToolStripMenuItem";
		mailToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		mailToolStripMenuItem.Text = "Email";
		mailToolStripMenuItem.Click += new System.EventHandler(mailToolStripMenuItem_Click);
		fAToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("fAToolStripMenuItem.Image");
		fAToolStripMenuItem.Name = "fAToolStripMenuItem";
		fAToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		fAToolStripMenuItem.Text = "2FA";
		fAToolStripMenuItem.Click += new System.EventHandler(fAToolStripMenuItem_Click);
		toolStripMenuItem_8.Image = (System.Drawing.Image)resources.GetObject("maBaoMât6SôToolStripMenuItem.Image");
		toolStripMenuItem_8.Name = "maBaoMât6SôToolStripMenuItem";
		toolStripMenuItem_8.Size = new System.Drawing.Size(289, 22);
		toolStripMenuItem_8.Text = "Ma\u0303 ba\u0309o mâ\u0323t 6 sô\u0301 từ 2FA";
		toolStripMenuItem_8.Click += new System.EventHandler(C7861389);
		uidPassToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidPassToolStripMenuItem.Image");
		uidPassToolStripMenuItem.Name = "uidPassToolStripMenuItem";
		uidPassToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		uidPassToolStripMenuItem.Text = "Uid|Pass";
		uidPassToolStripMenuItem.Click += new System.EventHandler(uidPassToolStripMenuItem_Click);
		uidPass2FaToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidPass2FaToolStripMenuItem.Image");
		uidPass2FaToolStripMenuItem.Name = "uidPass2FaToolStripMenuItem";
		uidPass2FaToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		uidPass2FaToolStripMenuItem.Text = "Uid|Pass|2Fa";
		uidPass2FaToolStripMenuItem.Click += new System.EventHandler(uidPass2FaToolStripMenuItem_Click);
		mailPassMailToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("mailPassMailToolStripMenuItem.Image");
		mailPassMailToolStripMenuItem.Name = "mailPassMailToolStripMenuItem";
		mailPassMailToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		mailPassMailToolStripMenuItem.Text = "Mail|Pass mail";
		mailPassMailToolStripMenuItem.Click += new System.EventHandler(mailPassMailToolStripMenuItem_Click);
		emailPassMailMailKpToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("emailPassMailMailKpToolStripMenuItem.Image");
		emailPassMailMailKpToolStripMenuItem.Name = "emailPassMailMailKpToolStripMenuItem";
		emailPassMailMailKpToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		emailPassMailMailKpToolStripMenuItem.Text = "Email|PassMail|MailKp";
		emailPassMailMailKpToolStripMenuItem.Click += new System.EventHandler(emailPassMailMailKpToolStripMenuItem_Click);
		D281F59B.Image = (System.Drawing.Image)resources.GetObject("uidPassTokenCookieToolStripMenuItem.Image");
		D281F59B.Name = "uidPassTokenCookieToolStripMenuItem";
		D281F59B.Size = new System.Drawing.Size(289, 22);
		D281F59B.Text = "Uid|Pass|Token|Cookie";
		D281F59B.Click += new System.EventHandler(EC2039A7);
		uidPassTokenCookieMailPassMailToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidPassTokenCookieMailPassMailToolStripMenuItem.Image");
		uidPassTokenCookieMailPassMailToolStripMenuItem.Name = "uidPassTokenCookieMailPassMailToolStripMenuItem";
		uidPassTokenCookieMailPassMailToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		uidPassTokenCookieMailPassMailToolStripMenuItem.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail";
		uidPassTokenCookieMailPassMailToolStripMenuItem.Click += new System.EventHandler(uidPassTokenCookieMailPassMailToolStripMenuItem_Click);
		AB28FC9F.Image = (System.Drawing.Image)resources.GetObject("uidPassTokenCookieMailPassMail2faToolStripMenuItem.Image");
		AB28FC9F.Name = "uidPassTokenCookieMailPassMail2faToolStripMenuItem";
		AB28FC9F.Size = new System.Drawing.Size(289, 22);
		AB28FC9F.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail|2fa";
		AB28FC9F.Click += new System.EventHandler(AB28FC9F_Click);
		F586C109.Image = (System.Drawing.Image)resources.GetObject("useragentToolStripMenuItem1.Image");
		F586C109.Name = "useragentToolStripMenuItem1";
		F586C109.Size = new System.Drawing.Size(289, 22);
		F586C109.Text = "Useragent";
		F586C109.Click += new System.EventHandler(F586C109_Click);
		D8123B8B.Image = (System.Drawing.Image)resources.GetObject("proxyToolStripMenuItem1.Image");
		D8123B8B.Name = "proxyToolStripMenuItem1";
		D8123B8B.Size = new System.Drawing.Size(289, 22);
		D8123B8B.Text = "Proxy";
		D8123B8B.Click += new System.EventHandler(D8123B8B_Click);
		toolStripMenuItem_7.Image = (System.Drawing.Image)resources.GetObject("đinhDangKhacToolStripMenuItem.Image");
		toolStripMenuItem_7.Name = "đinhDangKhacToolStripMenuItem";
		toolStripMenuItem_7.Size = new System.Drawing.Size(289, 22);
		toolStripMenuItem_7.Text = "Other...";
		toolStripMenuItem_7.Click += new System.EventHandler(toolStripMenuItem_7_Click);
		BD1D0DA4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[1] { toolStripMenuItem2 });
		BD1D0DA4.Image = (System.Drawing.Image)resources.GetObject("dongBôiĐenToolStripMenuItem.Image");
		BD1D0DA4.Name = "dongBôiĐenToolStripMenuItem";
		BD1D0DA4.Size = new System.Drawing.Size(180, 22);
		BD1D0DA4.Text = "Do\u0300ng bôi đen";
		toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[17]
		{
			toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6, A48F96AF, C1233E0A, C9B47E80, toolStripMenuItem10, toolStripMenuItem11, toolStripMenuItem12, toolStripMenuItem13,
			toolStripMenuItem14, toolStripMenuItem15, toolStripMenuItem16, toolStripMenuItem17, E53062A2, AF26FD8B, CB1F2182
		});
		toolStripMenuItem2.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem2.Image");
		toolStripMenuItem2.Name = "toolStripMenuItem2";
		toolStripMenuItem2.Size = new System.Drawing.Size(102, 22);
		toolStripMenuItem2.Text = "Copy";
		toolStripMenuItem4.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem4.Image");
		toolStripMenuItem4.Name = "toolStripMenuItem4";
		toolStripMenuItem4.Size = new System.Drawing.Size(289, 22);
		toolStripMenuItem4.Text = "Uid";
		toolStripMenuItem4.Click += new System.EventHandler(toolStripMenuItem4_Click);
		toolStripMenuItem5.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem5.Image");
		toolStripMenuItem5.Name = "toolStripMenuItem5";
		toolStripMenuItem5.Size = new System.Drawing.Size(289, 22);
		toolStripMenuItem5.Text = "Pass";
		toolStripMenuItem5.Click += new System.EventHandler(toolStripMenuItem5_Click);
		toolStripMenuItem6.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem6.Image");
		toolStripMenuItem6.Name = "toolStripMenuItem6";
		toolStripMenuItem6.Size = new System.Drawing.Size(289, 22);
		toolStripMenuItem6.Text = "Token";
		toolStripMenuItem6.Click += new System.EventHandler(D8B059B6);
		A48F96AF.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem7.Image");
		A48F96AF.Name = "toolStripMenuItem7";
		A48F96AF.Size = new System.Drawing.Size(289, 22);
		A48F96AF.Text = "Cookie";
		A48F96AF.Click += new System.EventHandler(A3B95D0C);
		C1233E0A.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem8.Image");
		C1233E0A.Name = "toolStripMenuItem8";
		C1233E0A.Size = new System.Drawing.Size(289, 22);
		C1233E0A.Text = "Email";
		C1233E0A.Click += new System.EventHandler(F68BCBA6);
		C9B47E80.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem9.Image");
		C9B47E80.Name = "toolStripMenuItem9";
		C9B47E80.Size = new System.Drawing.Size(289, 22);
		C9B47E80.Text = "2FA";
		C9B47E80.Click += new System.EventHandler(D420C231);
		toolStripMenuItem10.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem10.Image");
		toolStripMenuItem10.Name = "toolStripMenuItem10";
		toolStripMenuItem10.Size = new System.Drawing.Size(289, 22);
		toolStripMenuItem10.Text = "Ma\u0303 ba\u0309o mâ\u0323t 6 sô\u0301 từ 2FA";
		toolStripMenuItem10.Click += new System.EventHandler(toolStripMenuItem10_Click);
		toolStripMenuItem11.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem11.Image");
		toolStripMenuItem11.Name = "toolStripMenuItem11";
		toolStripMenuItem11.Size = new System.Drawing.Size(289, 22);
		toolStripMenuItem11.Text = "Uid|Pass";
		toolStripMenuItem11.Click += new System.EventHandler(toolStripMenuItem11_Click);
		toolStripMenuItem12.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem12.Image");
		toolStripMenuItem12.Name = "toolStripMenuItem12";
		toolStripMenuItem12.Size = new System.Drawing.Size(289, 22);
		toolStripMenuItem12.Text = "Uid|Pass|2Fa";
		toolStripMenuItem12.Click += new System.EventHandler(C0AAAABC);
		toolStripMenuItem13.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem13.Image");
		toolStripMenuItem13.Name = "toolStripMenuItem13";
		toolStripMenuItem13.Size = new System.Drawing.Size(289, 22);
		toolStripMenuItem13.Text = "Mail|Pass mail";
		toolStripMenuItem13.Click += new System.EventHandler(D9147292);
		toolStripMenuItem14.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem14.Image");
		toolStripMenuItem14.Name = "toolStripMenuItem14";
		toolStripMenuItem14.Size = new System.Drawing.Size(289, 22);
		toolStripMenuItem14.Text = "Email|PassMail|MailKp";
		toolStripMenuItem14.Click += new System.EventHandler(C81928AB);
		toolStripMenuItem15.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem15.Image");
		toolStripMenuItem15.Name = "toolStripMenuItem15";
		toolStripMenuItem15.Size = new System.Drawing.Size(289, 22);
		toolStripMenuItem15.Text = "Uid|Pass|Token|Cookie";
		toolStripMenuItem15.Click += new System.EventHandler(toolStripMenuItem15_Click);
		toolStripMenuItem16.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem16.Image");
		toolStripMenuItem16.Name = "toolStripMenuItem16";
		toolStripMenuItem16.Size = new System.Drawing.Size(289, 22);
		toolStripMenuItem16.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail";
		toolStripMenuItem16.Click += new System.EventHandler(toolStripMenuItem16_Click);
		toolStripMenuItem17.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem17.Image");
		toolStripMenuItem17.Name = "toolStripMenuItem17";
		toolStripMenuItem17.Size = new System.Drawing.Size(289, 22);
		toolStripMenuItem17.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail|2fa";
		toolStripMenuItem17.Click += new System.EventHandler(toolStripMenuItem17_Click);
		E53062A2.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem18.Image");
		E53062A2.Name = "toolStripMenuItem18";
		E53062A2.Size = new System.Drawing.Size(289, 22);
		E53062A2.Text = "Useragent";
		E53062A2.Click += new System.EventHandler(E53062A2_Click);
		AF26FD8B.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem19.Image");
		AF26FD8B.Name = "toolStripMenuItem19";
		AF26FD8B.Size = new System.Drawing.Size(289, 22);
		AF26FD8B.Text = "Proxy";
		AF26FD8B.Click += new System.EventHandler(AF26FD8B_Click);
		CB1F2182.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem20.Image");
		CB1F2182.Name = "toolStripMenuItem20";
		CB1F2182.Size = new System.Drawing.Size(289, 22);
		CB1F2182.Text = "Other...";
		CB1F2182.Click += new System.EventHandler(CB1F2182_Click);
		toolStripMenuItem_1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { E00A8821, toolStripMenuItem_15 });
		toolStripMenuItem_1.Image = (System.Drawing.Image)resources.GetObject("mởTrìnhDuyệtToolStripMenuItem.Image");
		toolStripMenuItem_1.Name = "mởTrìnhDuyệtToolStripMenuItem";
		toolStripMenuItem_1.Size = new System.Drawing.Size(180, 22);
		toolStripMenuItem_1.Text = "Mở trình duyệt";
		E00A8821.Name = "mởLuônToolStripMenuItem";
		E00A8821.Size = new System.Drawing.Size(181, 22);
		E00A8821.Text = "Tiến hành mở";
		E00A8821.Click += new System.EventHandler(E63B019F);
		toolStripMenuItem_15.Name = "càiĐặtCấuHìnhMởToolStripMenuItem";
		toolStripMenuItem_15.Size = new System.Drawing.Size(181, 22);
		toolStripMenuItem_15.Text = "Cài đặt cấu hình mở";
		toolStripMenuItem_15.Click += new System.EventHandler(toolStripMenuItem_15_Click);
		A51845B4.Image = (System.Drawing.Image)resources.GetObject("xóaTàiKhoảnToolStripMenuItem.Image");
		A51845B4.Name = "xóaTàiKhoảnToolStripMenuItem";
		A51845B4.Size = new System.Drawing.Size(180, 22);
		A51845B4.Text = "Xóa ta\u0300i khoa\u0309n";
		A51845B4.Click += new System.EventHandler(A4B4959A);
		checkCookieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[8] { C498B099, checkInfoUIDToolStripMenuItem, toolStripMenuItem_4, toolStripMenuItem_3, checkAvatarToolStripMenuItem, checkProfileToolStripMenuItem1, toolStripMenuItem_10, DCB311B2 });
		checkCookieToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("checkCookieToolStripMenuItem.Image");
		checkCookieToolStripMenuItem.Name = "checkCookieToolStripMenuItem";
		checkCookieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		checkCookieToolStripMenuItem.Text = "Kiểm tra tài khoản";
		checkCookieToolStripMenuItem.Click += new System.EventHandler(CBA9DA8E);
		C498B099.Name = "kiểmTraWallToolStripMenuItem";
		C498B099.Size = new System.Drawing.Size(199, 22);
		C498B099.Text = "Check Wall";
		C498B099.ToolTipText = "Không cần dùng token";
		C498B099.Click += new System.EventHandler(C498B099_Click);
		checkInfoUIDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { toolStripMenuItem_18, B396C512 });
		checkInfoUIDToolStripMenuItem.Name = "checkInfoUIDToolStripMenuItem";
		checkInfoUIDToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
		checkInfoUIDToolStripMenuItem.Text = "Check Info Uid";
		checkInfoUIDToolStripMenuItem.ToolTipText = "Không cần dùng token\r\nCâ\u0323p nhâ\u0323t thông tin: Ho\u0323 tên, Giớ\u0301i ti\u0301nh, [Email], [Ba\u0323n be\u0300], [Nho\u0301m], [Nga\u0300y sinh]";
		toolStripMenuItem_18.Name = "sửDụngIPMáyToolStripMenuItem";
		toolStripMenuItem_18.Size = new System.Drawing.Size(190, 22);
		toolStripMenuItem_18.Text = "Không đổi IP";
		toolStripMenuItem_18.Click += new System.EventHandler(toolStripMenuItem_18_Click);
		B396C512.Name = "sửDụngProxyĐãGánToolStripMenuItem";
		B396C512.Size = new System.Drawing.Size(190, 22);
		B396C512.Text = "Sử dụng proxy đã gán";
		B396C512.Click += new System.EventHandler(A5AFFD08);
		toolStripMenuItem_4.Name = "kiểmTraTokenToolStripMenuItem";
		toolStripMenuItem_4.Size = new System.Drawing.Size(199, 22);
		toolStripMenuItem_4.Text = "Check Token";
		toolStripMenuItem_4.Click += new System.EventHandler(toolStripMenuItem_4_Click);
		toolStripMenuItem_3.Name = "kiểmTraCookieToolStripMenuItem";
		toolStripMenuItem_3.Size = new System.Drawing.Size(199, 22);
		toolStripMenuItem_3.Text = "Check Cookie";
		toolStripMenuItem_3.Click += new System.EventHandler(toolStripMenuItem_3_Click);
		checkAvatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { toolStripMenuItem_19, toolStripMenuItem_20 });
		checkAvatarToolStripMenuItem.Name = "checkAvatarToolStripMenuItem";
		checkAvatarToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
		checkAvatarToolStripMenuItem.Text = "Check Avatar";
		toolStripMenuItem_19.Name = "khôngĐổiIPToolStripMenuItem";
		toolStripMenuItem_19.Size = new System.Drawing.Size(190, 22);
		toolStripMenuItem_19.Text = "Không đổi IP";
		toolStripMenuItem_19.Click += new System.EventHandler(toolStripMenuItem_19_Click);
		toolStripMenuItem_20.Name = "sửDụngProxyĐãGánToolStripMenuItem1";
		toolStripMenuItem_20.Size = new System.Drawing.Size(190, 22);
		toolStripMenuItem_20.Text = "Sử dụng proxy đã gán";
		toolStripMenuItem_20.Click += new System.EventHandler(toolStripMenuItem_20_Click);
		checkProfileToolStripMenuItem1.Name = "checkProfileToolStripMenuItem1";
		checkProfileToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
		checkProfileToolStripMenuItem1.Text = "Check Profile";
		checkProfileToolStripMenuItem1.Click += new System.EventHandler(checkProfileToolStripMenuItem_Click);
		toolStripMenuItem_10.Name = "kiểmTraMailpassMailToolStripMenuItem";
		toolStripMenuItem_10.Size = new System.Drawing.Size(199, 22);
		toolStripMenuItem_10.Text = "Check Connect hotmail";
		toolStripMenuItem_10.Click += new System.EventHandler(EA115A3B);
		DCB311B2.Name = "checkProxyToolStripMenuItem";
		DCB311B2.Size = new System.Drawing.Size(199, 22);
		DCB311B2.Text = "Check Proxy";
		DCB311B2.Click += new System.EventHandler(DCB311B2_Click);
		toolStripMenuItem_6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[1] { toolStripMenuItem_14 });
		toolStripMenuItem_6.Image = (System.Drawing.Image)resources.GetObject("cậpNhậtDữLiệuToolStripMenuItem.Image");
		toolStripMenuItem_6.Name = "cậpNhậtDữLiệuToolStripMenuItem";
		toolStripMenuItem_6.Size = new System.Drawing.Size(180, 22);
		toolStripMenuItem_6.Text = "Cập nhật dữ liệu";
		toolStripMenuItem_14.Image = (System.Drawing.Image)resources.GetObject("cậpToolStripMenuItem.Image");
		toolStripMenuItem_14.Name = "cậpToolStripMenuItem";
		toolStripMenuItem_14.Size = new System.Drawing.Size(175, 22);
		toolStripMenuItem_14.Text = "Cập nhật hàng loạt";
		toolStripMenuItem_14.Click += new System.EventHandler(toolStripMenuItem_14_Click);
		toolStripMenuItem_2.Image = (System.Drawing.Image)resources.GetObject("chuyểnThưMụcToolStripMenuItem.Image");
		toolStripMenuItem_2.Name = "chuyểnThưMụcToolStripMenuItem";
		toolStripMenuItem_2.Size = new System.Drawing.Size(180, 22);
		toolStripMenuItem_2.Text = "Chuyển thư mục";
		toolStripMenuItem_2.Click += new System.EventHandler(toolStripMenuItem_2_Click);
		mnuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { lToolStripMenuItem, locTrungToolStripMenuItem, toolStripMenuItem_17, checkNameVNToolStripMenuItem });
		mnuChucNang.Image = (System.Drawing.Image)resources.GetObject("mnuChucNang.Image");
		mnuChucNang.Name = "mnuChucNang";
		mnuChucNang.Size = new System.Drawing.Size(180, 22);
		mnuChucNang.Text = "Chức năng";
		lToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("lToolStripMenuItem.Image");
		lToolStripMenuItem.Name = "lToolStripMenuItem";
		lToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
		lToolStripMenuItem.Text = "Lọc tài khoản theo Uid";
		lToolStripMenuItem.Click += new System.EventHandler(AA8D789E);
		locTrungToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("locTrungToolStripMenuItem.Image");
		locTrungToolStripMenuItem.Name = "locTrungToolStripMenuItem";
		locTrungToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
		locTrungToolStripMenuItem.Text = "Lọc tài khoản trùng nhau";
		locTrungToolStripMenuItem.Click += new System.EventHandler(locTrungToolStripMenuItem_Click);
		toolStripMenuItem_17.Image = (System.Drawing.Image)resources.GetObject("xóaTàiKhoảnTrùngNhauToolStripMenuItem.Image");
		toolStripMenuItem_17.Name = "xóaTàiKhoảnTrùngNhauToolStripMenuItem";
		toolStripMenuItem_17.Size = new System.Drawing.Size(208, 22);
		toolStripMenuItem_17.Text = "Xóa tài khoản trùng nhau";
		toolStripMenuItem_17.Click += new System.EventHandler(toolStripMenuItem_17_Click);
		checkNameVNToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("checkNameVNToolStripMenuItem.Image");
		checkNameVNToolStripMenuItem.Name = "checkNameVNToolStripMenuItem";
		checkNameVNToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
		checkNameVNToolStripMenuItem.Text = "Check name VN";
		checkNameVNToolStripMenuItem.Click += new System.EventHandler(checkNameVNToolStripMenuItem_Click);
		profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[5] { checkProfileToolStripMenuItem, toolStripMenuItem_21, B005D087, toolStripMenuItem_22, A900291F });
		profileToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("profileToolStripMenuItem.Image");
		profileToolStripMenuItem.Name = "profileToolStripMenuItem";
		profileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		profileToolStripMenuItem.Text = "Profile Chrome";
		checkProfileToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("checkProfileToolStripMenuItem.Image");
		checkProfileToolStripMenuItem.Name = "checkProfileToolStripMenuItem";
		checkProfileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
		checkProfileToolStripMenuItem.Text = "Check profile";
		checkProfileToolStripMenuItem.Click += new System.EventHandler(checkProfileToolStripMenuItem_Click);
		toolStripMenuItem_21.Image = (System.Drawing.Image)resources.GetObject("xóaProfileToolStripMenuItem.Image");
		toolStripMenuItem_21.Name = "xóaProfileToolStripMenuItem";
		toolStripMenuItem_21.Size = new System.Drawing.Size(167, 22);
		toolStripMenuItem_21.Text = "Xóa profile";
		toolStripMenuItem_21.Click += new System.EventHandler(toolStripMenuItem_21_Click);
		B005D087.Image = (System.Drawing.Image)resources.GetObject("donDepProfileToolStripMenuItem.Image");
		B005D087.Name = "donDepProfileToolStripMenuItem";
		B005D087.Size = new System.Drawing.Size(167, 22);
		B005D087.Text = "Do\u0323n de\u0323p profile";
		B005D087.Click += new System.EventHandler(B005D087_Click);
		toolStripMenuItem_22.Image = (System.Drawing.Image)resources.GetObject("xóaCacheToolStripMenuItem.Image");
		toolStripMenuItem_22.Name = "xóaCacheToolStripMenuItem";
		toolStripMenuItem_22.Size = new System.Drawing.Size(167, 22);
		toolStripMenuItem_22.Text = "Xóa Cache Profile";
		toolStripMenuItem_22.Click += new System.EventHandler(toolStripMenuItem_22_Click);
		A900291F.Image = (System.Drawing.Image)resources.GetObject("copyProfileToolStripMenuItem.Image");
		A900291F.Name = "copyProfileToolStripMenuItem";
		A900291F.Size = new System.Drawing.Size(167, 22);
		A900291F.Text = "Copy Profile";
		A900291F.Click += new System.EventHandler(A900291F_Click);
		toolStripMenuItem_5.Image = (System.Drawing.Image)resources.GetObject("tảiLạiDanhSáchToolStripMenuItem.Image");
		toolStripMenuItem_5.Name = "tảiLạiDanhSáchToolStripMenuItem";
		toolStripMenuItem_5.Size = new System.Drawing.Size(180, 22);
		toolStripMenuItem_5.Text = "Tải lại danh sách";
		toolStripMenuItem_5.Click += new System.EventHandler(toolStripMenuItem_5_Click);
		getTokenEAAAAUToolStripMenuItem.Name = "getTokenEAAAAUToolStripMenuItem";
		getTokenEAAAAUToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
		getTokenEAAAAUToolStripMenuItem.Text = "Get Token EAAAAU";
		getTokenEAAAAUToolStripMenuItem.Click += new System.EventHandler(DE2AF0A4);
		getTokenEAAAAUBToolStripMenuItem.Name = "getTokenEAAAAUBToolStripMenuItem";
		getTokenEAAAAUBToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
		getTokenEAAAAUBToolStripMenuItem.Text = "Get Token EAAAAU + Bật 2FA";
		getTokenEAAAAUBToolStripMenuItem.Click += new System.EventHandler(A3BB69B1);
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = C00C0E9C;
		bunifuDragControl_0.Vertical = true;
		C00C0E9C.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		C00C0E9C.BackColor = System.Drawing.Color.White;
		C00C0E9C.Controls.Add(pictureBox1);
		C00C0E9C.Controls.Add(C90B629E);
		C00C0E9C.Controls.Add(BF851712);
		C00C0E9C.Controls.Add(btnClose);
		C00C0E9C.Controls.Add(bunifuCustomLabel1);
		C00C0E9C.Cursor = System.Windows.Forms.Cursors.SizeAll;
		C00C0E9C.Location = new System.Drawing.Point(2, 5);
		C00C0E9C.Name = "pnlHeader";
		C00C0E9C.Size = new System.Drawing.Size(1135, 29);
		C00C0E9C.TabIndex = 0;
		C00C0E9C.DoubleClick += new System.EventHandler(ABBC5528);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(6, 1);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 12;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		pictureBox1.DoubleClick += new System.EventHandler(pictureBox1_DoubleClick);
		C90B629E.Cursor = System.Windows.Forms.Cursors.Hand;
		C90B629E.Dock = System.Windows.Forms.DockStyle.Right;
		C90B629E.FlatAppearance.BorderSize = 0;
		C90B629E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C90B629E.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C90B629E.ForeColor = System.Drawing.Color.White;
		C90B629E.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		C90B629E.Location = new System.Drawing.Point(1039, 0);
		C90B629E.Name = "btnMinimize";
		C90B629E.Size = new System.Drawing.Size(32, 29);
		C90B629E.TabIndex = 0;
		C90B629E.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		C90B629E.UseVisualStyleBackColor = true;
		C90B629E.Click += new System.EventHandler(EB169C8B);
		BF851712.Cursor = System.Windows.Forms.Cursors.Hand;
		BF851712.Dock = System.Windows.Forms.DockStyle.Right;
		BF851712.FlatAppearance.BorderSize = 0;
		BF851712.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BF851712.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		BF851712.ForeColor = System.Drawing.Color.White;
		BF851712.Image = (System.Drawing.Image)resources.GetObject("btnMaximize.Image");
		BF851712.Location = new System.Drawing.Point(1071, 0);
		BF851712.Name = "btnMaximize";
		BF851712.Size = new System.Drawing.Size(32, 29);
		BF851712.TabIndex = 1;
		BF851712.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		BF851712.UseVisualStyleBackColor = true;
		BF851712.Click += new System.EventHandler(BF851712_Click);
		btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
		btnClose.Dock = System.Windows.Forms.DockStyle.Right;
		btnClose.FlatAppearance.BorderSize = 0;
		btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnClose.ForeColor = System.Drawing.Color.White;
		btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
		btnClose.Location = new System.Drawing.Point(1103, 0);
		btnClose.Name = "btnClose";
		btnClose.Size = new System.Drawing.Size(32, 29);
		btnClose.TabIndex = 2;
		btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnClose.UseVisualStyleBackColor = true;
		btnClose.Click += new System.EventHandler(A4889F90);
		bunifuCustomLabel1.AutoSize = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(43, 6);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(0, 16);
		bunifuCustomLabel1.TabIndex = 3;
		bunifuCustomLabel1.DoubleClick += new System.EventHandler(bunifuCustomLabel1_DoubleClick);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(C00C0E9C);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(1138, 38);
		bunifuCards1.TabIndex = 0;
		menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		menuStrip1.AutoSize = false;
		menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
		menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { toolStripMenuItem_9, toolStripMenuItem_11, toolStripMenuItem_16 });
		menuStrip1.Location = new System.Drawing.Point(1, 37);
		menuStrip1.Name = "menuStrip1";
		menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
		menuStrip1.Size = new System.Drawing.Size(1136, 25);
		menuStrip1.Stretch = false;
		menuStrip1.TabIndex = 1;
		menuStrip1.Text = "menuStrip1";
		toolStripMenuItem_9.Image = (System.Drawing.Image)resources.GetObject("thoátToolStripMenuItem.Image");
		toolStripMenuItem_9.Name = "thoátToolStripMenuItem";
		toolStripMenuItem_9.Size = new System.Drawing.Size(131, 21);
		toolStripMenuItem_9.Text = "Câ\u0301u hi\u0300nh hiê\u0309n thi\u0323";
		toolStripMenuItem_9.Click += new System.EventHandler(toolStripMenuItem_9_Click);
		toolStripMenuItem_11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[8] { checkLiveUidToolStripMenuItem, checkProxyToolStripMenuItem1, checkHotmailToolStripMenuItem, toolStripMenuItem_12, toolStripMenuItem_13, checkStatusXproxyToolStripMenuItem, testSpinTextToolStripMenuItem, checkGolikeToolStripMenuItem });
		toolStripMenuItem_11.Image = (System.Drawing.Image)resources.GetObject("tiệnÍchToolStripMenuItem.Image");
		toolStripMenuItem_11.Name = "tiệnÍchToolStripMenuItem";
		toolStripMenuItem_11.Size = new System.Drawing.Size(80, 21);
		toolStripMenuItem_11.Text = "Tiện ích";
		checkLiveUidToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("checkLiveUidToolStripMenuItem.Image");
		checkLiveUidToolStripMenuItem.Name = "checkLiveUidToolStripMenuItem";
		checkLiveUidToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
		checkLiveUidToolStripMenuItem.Text = "Check Live Uid";
		checkLiveUidToolStripMenuItem.Click += new System.EventHandler(checkLiveUidToolStripMenuItem_Click);
		checkProxyToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("checkProxyToolStripMenuItem1.Image");
		checkProxyToolStripMenuItem1.Name = "checkProxyToolStripMenuItem1";
		checkProxyToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
		checkProxyToolStripMenuItem1.Text = "Check Proxy";
		checkProxyToolStripMenuItem1.Click += new System.EventHandler(checkProxyToolStripMenuItem1_Click);
		checkHotmailToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("checkHotmailToolStripMenuItem.Image");
		checkHotmailToolStripMenuItem.Name = "checkHotmailToolStripMenuItem";
		checkHotmailToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
		checkHotmailToolStripMenuItem.Text = "Check Connect hotmail";
		checkHotmailToolStripMenuItem.Click += new System.EventHandler(checkHotmailToolStripMenuItem_Click);
		toolStripMenuItem_12.Image = (System.Drawing.Image)resources.GetObject("lọcTrùngDữLiệuToolStripMenuItem.Image");
		toolStripMenuItem_12.Name = "lọcTrùngDữLiệuToolStripMenuItem";
		toolStripMenuItem_12.Size = new System.Drawing.Size(204, 22);
		toolStripMenuItem_12.Text = "Lọc trùng dữ liệu";
		toolStripMenuItem_12.Click += new System.EventHandler(toolStripMenuItem_12_Click);
		toolStripMenuItem_13.Image = (System.Drawing.Image)resources.GetObject("xửLýChuỗiOnlineToolStripMenuItem.Image");
		toolStripMenuItem_13.Name = "xửLýChuỗiOnlineToolStripMenuItem";
		toolStripMenuItem_13.Size = new System.Drawing.Size(204, 22);
		toolStripMenuItem_13.Text = "Xử lý chuỗi cơ bản";
		toolStripMenuItem_13.Click += new System.EventHandler(D217CC29);
		checkStatusXproxyToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("checkStatusXproxyToolStripMenuItem.Image");
		checkStatusXproxyToolStripMenuItem.Name = "checkStatusXproxyToolStripMenuItem";
		checkStatusXproxyToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
		checkStatusXproxyToolStripMenuItem.Text = "Check Xproxy";
		checkStatusXproxyToolStripMenuItem.Click += new System.EventHandler(F980742C);
		testSpinTextToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("testSpinTextToolStripMenuItem.Image");
		testSpinTextToolStripMenuItem.Name = "testSpinTextToolStripMenuItem";
		testSpinTextToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
		testSpinTextToolStripMenuItem.Text = "Test Spin Content";
		testSpinTextToolStripMenuItem.Click += new System.EventHandler(A6AAEF89);
		checkGolikeToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("checkGolikeToolStripMenuItem.Image");
		checkGolikeToolStripMenuItem.Name = "checkGolikeToolStripMenuItem";
		checkGolikeToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
		checkGolikeToolStripMenuItem.Text = "Test Welike";
		checkGolikeToolStripMenuItem.Click += new System.EventHandler(checkGolikeToolStripMenuItem_Click);
		toolStripMenuItem_16.Image = (System.Drawing.Image)resources.GetObject("liênHệToolStripMenuItem.Image");
		toolStripMenuItem_16.Name = "liênHệToolStripMenuItem";
		toolStripMenuItem_16.Size = new System.Drawing.Size(76, 21);
		toolStripMenuItem_16.Text = "Liên hệ";
		toolStripMenuItem_16.Click += new System.EventHandler(toolStripMenuItem_16_Click);
		D81FA988.Fixed = true;
		D81FA988.Horizontal = true;
		D81FA988.TargetControl = bunifuCustomLabel1;
		D81FA988.Vertical = true;
		E9372C3C.AutomaticDelay = 0;
		E9372C3C.AutoPopDelay = 30000;
		E9372C3C.InitialDelay = 0;
		E9372C3C.ReshowDelay = 40;
		FEAB929D.BackgroundImage = (System.Drawing.Image)resources.GetObject("AddFileAccount.BackgroundImage");
		FEAB929D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		FEAB929D.Cursor = System.Windows.Forms.Cursors.Hand;
		FEAB929D.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		FEAB929D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		FEAB929D.Location = new System.Drawing.Point(395, 2);
		FEAB929D.Name = "AddFileAccount";
		FEAB929D.Size = new System.Drawing.Size(25, 25);
		FEAB929D.TabIndex = 4;
		E9372C3C.SetToolTip(FEAB929D, "Thêm thư mục");
		FEAB929D.Click += new System.EventHandler(FEAB929D_Click);
		FA856528.BackColor = System.Drawing.Color.White;
		FA856528.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnDeleteFile.BackgroundImage");
		FA856528.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		FA856528.Cursor = System.Windows.Forms.Cursors.Hand;
		FA856528.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		FA856528.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		FA856528.Location = new System.Drawing.Point(457, 2);
		FA856528.Name = "btnDeleteFile";
		FA856528.Size = new System.Drawing.Size(25, 25);
		FA856528.TabIndex = 5;
		E9372C3C.SetToolTip(FA856528, "Xóa thư mục");
		FA856528.UseVisualStyleBackColor = false;
		FA856528.Click += new System.EventHandler(D907633E);
		btnEditFile.BackColor = System.Drawing.Color.White;
		btnEditFile.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnEditFile.BackgroundImage");
		btnEditFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		btnEditFile.Cursor = System.Windows.Forms.Cursors.Hand;
		btnEditFile.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnEditFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnEditFile.Location = new System.Drawing.Point(426, 2);
		btnEditFile.Name = "btnEditFile";
		btnEditFile.Size = new System.Drawing.Size(25, 25);
		btnEditFile.TabIndex = 5;
		E9372C3C.SetToolTip(btnEditFile, "Sửa tên thư mục");
		btnEditFile.UseVisualStyleBackColor = false;
		btnEditFile.Click += new System.EventHandler(BAA6999D);
		btnLoadAcc.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnLoadAcc.BackgroundImage");
		btnLoadAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
		btnLoadAcc.Cursor = System.Windows.Forms.Cursors.Hand;
		btnLoadAcc.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnLoadAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnLoadAcc.Location = new System.Drawing.Point(489, 2);
		btnLoadAcc.Name = "btnLoadAcc";
		btnLoadAcc.Size = new System.Drawing.Size(25, 25);
		btnLoadAcc.TabIndex = 6;
		E9372C3C.SetToolTip(btnLoadAcc, "Load lại danh sách");
		btnLoadAcc.Click += new System.EventHandler(CC348FB5);
		btnInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		btnInteract.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnInteract.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
		btnInteract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnInteract.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnInteract.Image = (System.Drawing.Image)resources.GetObject("btnInteract.Image");
		btnInteract.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		btnInteract.Location = new System.Drawing.Point(8, 109);
		btnInteract.Name = "btnInteract";
		btnInteract.Size = new System.Drawing.Size(117, 32);
		btnInteract.TabIndex = 13;
		btnInteract.Text = "Chạy đã chọn";
		btnInteract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		E9372C3C.SetToolTip(btnInteract, "Bă\u0301t đâ\u0300u cha\u0323y tương ta\u0301c");
		btnInteract.UseVisualStyleBackColor = false;
		btnInteract.Click += new System.EventHandler(BD0C5384);
		F5948F3E.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		F5948F3E.BackColor = System.Drawing.Color.Gainsboro;
		F5948F3E.Controls.Add(EF36EA35);
		F5948F3E.Location = new System.Drawing.Point(763, 36);
		F5948F3E.Name = "plTrangThai";
		F5948F3E.Size = new System.Drawing.Size(373, 26);
		F5948F3E.TabIndex = 10;
		F5948F3E.Visible = false;
		EF36EA35.Dock = System.Windows.Forms.DockStyle.Fill;
		EF36EA35.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EF36EA35.Location = new System.Drawing.Point(0, 0);
		EF36EA35.Name = "lblTrangThai";
		EF36EA35.Size = new System.Drawing.Size(373, 26);
		EF36EA35.TabIndex = 0;
		EF36EA35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		EA0BF912.AccessibleName = "New item selection";
		EA0BF912.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
		EA0BF912.AutoSize = false;
		EA0BF912.BackColor = System.Drawing.SystemColors.Control;
		EA0BF912.Dock = System.Windows.Forms.DockStyle.None;
		EA0BF912.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EA0BF912.Location = new System.Drawing.Point(0, 0);
		EA0BF912.Name = "miniToolStrip";
		EA0BF912.Size = new System.Drawing.Size(1222, 22);
		EA0BF912.SizingGrip = false;
		EA0BF912.TabIndex = 9;
		toolStripStatusLabel4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		toolStripStatusLabel4.Name = "toolStripStatusLabel4";
		toolStripStatusLabel4.Size = new System.Drawing.Size(59, 17);
		toolStripStatusLabel4.Text = "Bôi đen:";
		E71E4104.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E71E4104.ForeColor = System.Drawing.Color.Blue;
		E71E4104.Name = "lblCountHighline";
		E71E4104.Size = new System.Drawing.Size(15, 17);
		E71E4104.Text = "0";
		CF1A928E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CF1A928E.Name = "toolStripStatusLabel5";
		CF1A928E.Size = new System.Drawing.Size(65, 17);
		CF1A928E.Text = "Đã chọn:";
		lblCountSelect.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblCountSelect.ForeColor = System.Drawing.Color.FromArgb(0, 64, 0);
		lblCountSelect.Name = "lblCountSelect";
		lblCountSelect.Size = new System.Drawing.Size(15, 17);
		lblCountSelect.Text = "0";
		toolStripStatusLabel7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		toolStripStatusLabel7.Name = "toolStripStatusLabel7";
		toolStripStatusLabel7.Size = new System.Drawing.Size(52, 17);
		toolStripStatusLabel7.Text = "Tất cả:";
		lblCountTotal.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblCountTotal.ForeColor = System.Drawing.Color.Maroon;
		lblCountTotal.Name = "lblCountTotal";
		lblCountTotal.Size = new System.Drawing.Size(15, 17);
		lblCountTotal.Text = "0";
		metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		metroButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
		metroButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		metroButton1.Location = new System.Drawing.Point(997, 71);
		metroButton1.Name = "metroButton1";
		metroButton1.Size = new System.Drawing.Size(130, 32);
		metroButton1.TabIndex = 7;
		metroButton1.Text = "Close Chromedriver";
		metroButton1.Click += new System.EventHandler(metroButton1_Click);
		EF907231.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		EF907231.Controls.Add(C0290281);
		EF907231.Controls.Add(DC2BDDA5);
		EF907231.Controls.Add(txbSearch);
		EF907231.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EF907231.Location = new System.Drawing.Point(8, 72);
		EF907231.Name = "panel2";
		EF907231.Size = new System.Drawing.Size(323, 31);
		EF907231.TabIndex = 10;
		C0290281.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		C0290281.BackgroundImage = (System.Drawing.Image)resources.GetObject("BtnSearch.BackgroundImage");
		C0290281.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		C0290281.Cursor = System.Windows.Forms.Cursors.Hand;
		C0290281.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		C0290281.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C0290281.Location = new System.Drawing.Point(294, 3);
		C0290281.Name = "BtnSearch";
		C0290281.Size = new System.Drawing.Size(24, 23);
		C0290281.TabIndex = 3;
		C0290281.Click += new System.EventHandler(C0290281_Click);
		DC2BDDA5.Cursor = System.Windows.Forms.Cursors.Hand;
		DC2BDDA5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		DC2BDDA5.DropDownWidth = 100;
		DC2BDDA5.FormattingEnabled = true;
		DC2BDDA5.Location = new System.Drawing.Point(3, 3);
		DC2BDDA5.Name = "cbbSearch";
		DC2BDDA5.Size = new System.Drawing.Size(86, 24);
		DC2BDDA5.TabIndex = 0;
		txbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txbSearch.BorderColor = System.Drawing.Color.SeaGreen;
		txbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
		txbSearch.Location = new System.Drawing.Point(95, 3);
		txbSearch.Name = "txbSearch";
		txbSearch.Size = new System.Drawing.Size(193, 23);
		txbSearch.TabIndex = 1;
		txbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(txbSearch_KeyDown);
		C3BBF8AC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C3BBF8AC.Controls.Add(cbbTinhTrang);
		C3BBF8AC.Controls.Add(btnLoadAcc);
		C3BBF8AC.Controls.Add(label1);
		C3BBF8AC.Controls.Add(btnEditFile);
		C3BBF8AC.Controls.Add(button9);
		C3BBF8AC.Controls.Add(FA856528);
		C3BBF8AC.Controls.Add(label2);
		C3BBF8AC.Controls.Add(FEAB929D);
		C3BBF8AC.Controls.Add(cbbThuMuc);
		C3BBF8AC.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C3BBF8AC.Location = new System.Drawing.Point(337, 72);
		C3BBF8AC.Name = "plQuanLyThuMuc";
		C3BBF8AC.Size = new System.Drawing.Size(654, 31);
		C3BBF8AC.TabIndex = 10;
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
		cbbTinhTrang.SelectedIndexChanged += new System.EventHandler(AB8D3DA4);
		label1.AutoSize = true;
		label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label1.Location = new System.Drawing.Point(-1, 6);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(63, 16);
		label1.TabIndex = 0;
		label1.Text = "Thư mục:";
		button9.BackColor = System.Drawing.Color.White;
		button9.Cursor = System.Windows.Forms.Cursors.Hand;
		button9.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button9.Image = (System.Drawing.Image)resources.GetObject("button9.Image");
		button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		button9.Location = new System.Drawing.Point(521, 1);
		button9.Name = "button9";
		button9.Size = new System.Drawing.Size(130, 27);
		button9.TabIndex = 7;
		button9.Text = "Nhập tài khoản";
		button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		button9.UseVisualStyleBackColor = true;
		button9.Click += new System.EventHandler(button9_Click);
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
		cbbThuMuc.SelectedIndexChanged += new System.EventHandler(BB10033A);
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(EB3CF7AF);
		panel1.Controls.Add(tabControl1);
		panel1.Controls.Add(button2);
		panel1.Controls.Add(D9927D91);
		panel1.Controls.Add(btnInteract);
		panel1.Controls.Add(C3BBF8AC);
		panel1.Controls.Add(EF907231);
		panel1.Controls.Add(btnHienCaiDat);
		panel1.Controls.Add(metroButton1);
		panel1.Controls.Add(statusStrip1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(1139, 647);
		panel1.TabIndex = 11;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		EB3CF7AF.AllowUserToAddRows = false;
		EB3CF7AF.AllowUserToDeleteRows = false;
		EB3CF7AF.AllowUserToResizeRows = false;
		EB3CF7AF.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		EB3CF7AF.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		EB3CF7AF.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		EB3CF7AF.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		EB3CF7AF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		EB3CF7AF.Columns.AddRange(cChose, cStt, cId, FD886B35, F2BE232E, DC2D399A, E128C7A9, cCookies, A4209E84, cEmail2, cPassMail, cMailRecovery, cPassMailRecovery, CABFF297, cName, cFollow, cFriend, cGroup, cPage, cPagePro5, E23A412F, cGender, cOAuth2, CFB06338, cProxy, F7AF4722, cAvatar, cProfile, cThuMuc, cInteractEnd, BBB2678F, D61BBD3F, cStatus282, cLocation, cHometown, cCurrentCity, cDating, A2919486, cBM, cWallPosts, C7A5BE91, EA8C022B, cKichBan, cStatus);
		EB3CF7AF.ContextMenuStrip = ctmsAcc;
		EB3CF7AF.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		EB3CF7AF.Location = new System.Drawing.Point(8, 386);
		EB3CF7AF.Name = "dtgvAcc";
		EB3CF7AF.RowHeadersVisible = false;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EB3CF7AF.RowsDefaultCellStyle = dataGridViewCellStyle2;
		EB3CF7AF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		EB3CF7AF.Size = new System.Drawing.Size(1119, 234);
		EB3CF7AF.TabIndex = 202;
		EB3CF7AF.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(FC335E91);
		EB3CF7AF.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(EB3CF7AF_CellDoubleClick);
		EB3CF7AF.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(EB3CF7AF_CellValueChanged);
		EB3CF7AF.SelectionChanged += new System.EventHandler(ED804089);
		EB3CF7AF.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(F42E5299);
		EB3CF7AF.KeyDown += new System.Windows.Forms.KeyEventHandler(CA2DE33A);
		cChose.HeaderText = "Chọn";
		cChose.Name = "cChose";
		cChose.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		cChose.Width = 40;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		cStt.DefaultCellStyle = dataGridViewCellStyle3;
		cStt.HeaderText = "STT";
		cStt.Name = "cStt";
		cStt.Width = 35;
		cId.HeaderText = "Id";
		cId.Name = "cId";
		cId.Visible = false;
		cId.Width = 90;
		FD886B35.HeaderText = "UID";
		FD886B35.Name = "cUid";
		FD886B35.Width = 80;
		F2BE232E.HeaderText = "Mật khẩu";
		F2BE232E.Name = "cPassword";
		F2BE232E.Visible = false;
		F2BE232E.Width = 85;
		DC2D399A.HeaderText = "Mã 2FA";
		DC2D399A.Name = "cFa2";
		DC2D399A.Width = 80;
		E128C7A9.HeaderText = "Token";
		E128C7A9.Name = "cToken";
		E128C7A9.Width = 70;
		cCookies.HeaderText = "Cookie";
		cCookies.Name = "cCookies";
		cCookies.Width = 70;
		A4209E84.HeaderText = "Email";
		A4209E84.Name = "cEmail";
		A4209E84.Width = 60;
		cEmail2.HeaderText = "Email full";
		cEmail2.Name = "cEmail2";
		cPassMail.HeaderText = "Mật khẩu mail";
		cPassMail.Name = "cPassMail";
		cPassMail.Visible = false;
		cPassMail.Width = 120;
		cMailRecovery.HeaderText = "Email khôi phục";
		cMailRecovery.Name = "cMailRecovery";
		cMailRecovery.Visible = false;
		cMailRecovery.Width = 125;
		cPassMailRecovery.HeaderText = "Pass mail khôi phu\u0323c";
		cPassMailRecovery.Name = "cPassMailRecovery";
		cPassMailRecovery.Visible = false;
		cPassMailRecovery.Width = 150;
		CABFF297.HeaderText = "Phone";
		CABFF297.Name = "cPhone";
		CABFF297.Visible = false;
		CABFF297.Width = 90;
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
		E23A412F.HeaderText = "Nga\u0300y sinh";
		E23A412F.Name = "cBirthday";
		E23A412F.Width = 90;
		cGender.HeaderText = "Giới Tính";
		cGender.Name = "cGender";
		cGender.Width = 82;
		cOAuth2.HeaderText = "OAuth2";
		cOAuth2.Name = "cOAuth2";
		cOAuth2.Visible = false;
		cOAuth2.Width = 70;
		CFB06338.HeaderText = "Useragent";
		CFB06338.Name = "cUseragent";
		CFB06338.Visible = false;
		CFB06338.Width = 70;
		cProxy.HeaderText = "Proxy";
		cProxy.Name = "cProxy";
		cProxy.Visible = false;
		cProxy.Width = 55;
		F7AF4722.HeaderText = "Nga\u0300y ta\u0323o";
		F7AF4722.Name = "cDateCreateAcc";
		F7AF4722.Visible = false;
		F7AF4722.Width = 85;
		cAvatar.HeaderText = "Avatar";
		cAvatar.Name = "cAvatar";
		cAvatar.Visible = false;
		cAvatar.Width = 50;
		cProfile.HeaderText = "Profile";
		cProfile.Name = "cProfile";
		cProfile.Visible = false;
		cProfile.Width = 50;
		cThuMuc.HeaderText = "Thư mục";
		cThuMuc.Name = "cThuMuc";
		cThuMuc.Visible = false;
		cInteractEnd.HeaderText = "Lâ\u0300n tương ta\u0301c cuô\u0301i";
		cInteractEnd.Name = "cInteractEnd";
		cInteractEnd.Visible = false;
		cInteractEnd.Width = 160;
		BBB2678F.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
		BBB2678F.HeaderText = "Tình Trạng";
		BBB2678F.Name = "cInfo";
		BBB2678F.Visible = false;
		D61BBD3F.HeaderText = "Ghi Chú";
		D61BBD3F.Name = "cGhiChu";
		D61BBD3F.Visible = false;
		D61BBD3F.Width = 90;
		cStatus282.HeaderText = "Status 282";
		cStatus282.Name = "cStatus282";
		cStatus282.Visible = false;
		cLocation.HeaderText = "Location";
		cLocation.Name = "cLocation";
		cLocation.Visible = false;
		cLocation.Width = 80;
		cHometown.HeaderText = "Hometown";
		cHometown.Name = "cHometown";
		cHometown.Visible = false;
		cHometown.Width = 90;
		cCurrentCity.HeaderText = "Current City";
		cCurrentCity.Name = "cCurrentCity";
		cCurrentCity.Visible = false;
		cDating.HeaderText = "Dating";
		cDating.Name = "cDating";
		cDating.Visible = false;
		A2919486.HeaderText = "Ads";
		A2919486.Name = "cAds";
		A2919486.Visible = false;
		cBM.HeaderText = "BM";
		cBM.Name = "cBM";
		cBM.Visible = false;
		cWallPosts.HeaderText = "Wall Posts";
		cWallPosts.Name = "cWallPosts";
		cWallPosts.Visible = false;
		C7A5BE91.HeaderText = "Fb Block";
		C7A5BE91.Name = "cFbBlock";
		C7A5BE91.Width = 80;
		EA8C022B.HeaderText = "Job";
		EA8C022B.Name = "cJob";
		EA8C022B.Visible = false;
		cKichBan.HeaderText = "Kịch bản";
		cKichBan.Name = "cKichBan";
		cKichBan.Visible = false;
		cKichBan.Width = 80;
		cStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		cStatus.HeaderText = "Trạng Thái";
		cStatus.MinimumWidth = 200;
		cStatus.Name = "cStatus";
		tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		tabControl1.Controls.Add(BB832C28);
		tabControl1.Controls.Add(tabPage3);
		tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
		tabControl1.Location = new System.Drawing.Point(8, 147);
		tabControl1.Name = "tabControl1";
		tabControl1.SelectedIndex = 0;
		tabControl1.Size = new System.Drawing.Size(1119, 233);
		tabControl1.TabIndex = 205;
		BB832C28.Controls.Add(B38E60B4);
		BB832C28.Controls.Add(CB30E000);
		BB832C28.Controls.Add(ckbUnlock956);
		BB832C28.Controls.Add(D99BA487);
		BB832C28.Controls.Add(ckbCheckProxy);
		BB832C28.Controls.Add(F49B67B7);
		BB832C28.Controls.Add(ckbCheckLiveUid);
		BB832C28.Location = new System.Drawing.Point(4, 25);
		BB832C28.Name = "tabPage1";
		BB832C28.Padding = new System.Windows.Forms.Padding(3);
		BB832C28.Size = new System.Drawing.Size(1111, 204);
		BB832C28.TabIndex = 0;
		BB832C28.Text = "Câ\u0301u hi\u0300nh chung";
		BB832C28.UseVisualStyleBackColor = true;
		B38E60B4.Controls.Add(C129E939);
		B38E60B4.Controls.Add(B50940A9);
		B38E60B4.Controls.Add(label9);
		B38E60B4.Controls.Add(F40A5030);
		B38E60B4.Controls.Add(cbbChangeIP);
		B38E60B4.Location = new System.Drawing.Point(6, 6);
		B38E60B4.Name = "groupBox2";
		B38E60B4.Size = new System.Drawing.Size(362, 192);
		B38E60B4.TabIndex = 203;
		B38E60B4.TabStop = false;
		B38E60B4.Text = "Câ\u0301u hi\u0300nh chung";
		C129E939.AutoSize = true;
		C129E939.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C129E939.Location = new System.Drawing.Point(7, 23);
		C129E939.Name = "label17";
		C129E939.Size = new System.Drawing.Size(170, 16);
		C129E939.TabIndex = 33;
		C129E939.Text = "Sô\u0301 ta\u0300i khoa\u0309n cha\u0323y đô\u0300ng thơ\u0300i:";
		B50940A9.AutoSize = true;
		B50940A9.Cursor = System.Windows.Forms.Cursors.Hand;
		B50940A9.Location = new System.Drawing.Point(10, 82);
		B50940A9.Name = "ckbRepeatAll";
		B50940A9.Size = new System.Drawing.Size(174, 20);
		B50940A9.TabIndex = 94;
		B50940A9.Text = "Chạy lại toàn bộ tài khoản";
		B50940A9.UseVisualStyleBackColor = true;
		label9.AutoSize = true;
		label9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label9.Location = new System.Drawing.Point(7, 53);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(128, 16);
		label9.TabIndex = 201;
		label9.Text = "Tùy chọn thay đổi IP:";
		F40A5030.Location = new System.Drawing.Point(182, 21);
		F40A5030.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		F40A5030.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		F40A5030.Name = "nudThread";
		F40A5030.Size = new System.Drawing.Size(167, 23);
		F40A5030.TabIndex = 151;
		F40A5030.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		cbbChangeIP.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbChangeIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbChangeIP.FormattingEnabled = true;
		cbbChangeIP.Location = new System.Drawing.Point(182, 50);
		cbbChangeIP.Name = "cbbChangeIP";
		cbbChangeIP.Size = new System.Drawing.Size(167, 24);
		cbbChangeIP.TabIndex = 200;
		CB30E000.Controls.Add(ckbShowImageInteract);
		CB30E000.Controls.Add(nudDelayOpenChromeTo);
		CB30E000.Controls.Add(label6);
		CB30E000.Controls.Add(cbbFacebookWeb);
		CB30E000.Controls.Add(EE3D8093);
		CB30E000.Controls.Add(label29);
		CB30E000.Controls.Add(nudMaxChrome);
		CB30E000.Controls.Add(label8);
		CB30E000.Controls.Add(E604DA36);
		CB30E000.Controls.Add(FD9C2193);
		CB30E000.Controls.Add(ckbHideBrowser);
		CB30E000.Controls.Add(label20);
		CB30E000.Location = new System.Drawing.Point(374, 6);
		CB30E000.Name = "groupBox1";
		CB30E000.Size = new System.Drawing.Size(365, 192);
		CB30E000.TabIndex = 202;
		CB30E000.TabStop = false;
		CB30E000.Text = "Câ\u0301u hi\u0300nh chrome";
		ckbShowImageInteract.AutoSize = true;
		ckbShowImageInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbShowImageInteract.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbShowImageInteract.Location = new System.Drawing.Point(14, 22);
		ckbShowImageInteract.Name = "ckbShowImageInteract";
		ckbShowImageInteract.Size = new System.Drawing.Size(175, 20);
		ckbShowImageInteract.TabIndex = 112;
		ckbShowImageInteract.Text = "Hiê\u0323n a\u0309nh khi dùng chrome";
		ckbShowImageInteract.UseVisualStyleBackColor = true;
		nudDelayOpenChromeTo.Location = new System.Drawing.Point(302, 76);
		nudDelayOpenChromeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayOpenChromeTo.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		nudDelayOpenChromeTo.Name = "nudDelayOpenChromeTo";
		nudDelayOpenChromeTo.Size = new System.Drawing.Size(51, 23);
		nudDelayOpenChromeTo.TabIndex = 151;
		nudDelayOpenChromeTo.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(11, 107);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(100, 16);
		label6.TabIndex = 196;
		label6.Text = "Kiểu đăng nhâ\u0323p:";
		cbbFacebookWeb.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbFacebookWeb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbFacebookWeb.DropDownWidth = 120;
		cbbFacebookWeb.FormattingEnabled = true;
		cbbFacebookWeb.Items.AddRange(new object[4] { "m.fb", "www", "mbasic", "www->m.fb" });
		cbbFacebookWeb.Location = new System.Drawing.Point(192, 135);
		cbbFacebookWeb.Name = "cbbFacebookWeb";
		cbbFacebookWeb.Size = new System.Drawing.Size(161, 24);
		cbbFacebookWeb.TabIndex = 199;
		EE3D8093.Cursor = System.Windows.Forms.Cursors.Hand;
		EE3D8093.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		EE3D8093.DropDownWidth = 120;
		EE3D8093.FormattingEnabled = true;
		EE3D8093.Items.AddRange(new object[4] { "Uid|Pass", "Email|Pass", "Cookie", "Cookie>Pass" });
		EE3D8093.Location = new System.Drawing.Point(192, 105);
		EE3D8093.Name = "cbbTypeLogin";
		EE3D8093.Size = new System.Drawing.Size(161, 24);
		EE3D8093.TabIndex = 198;
		label29.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label29.Location = new System.Drawing.Point(263, 78);
		label29.Name = "label29";
		label29.Size = new System.Drawing.Size(23, 16);
		label29.TabIndex = 33;
		label29.Text = ">";
		label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudMaxChrome.Location = new System.Drawing.Point(192, 47);
		nudMaxChrome.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudMaxChrome.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		nudMaxChrome.Name = "nudMaxChrome";
		nudMaxChrome.Size = new System.Drawing.Size(51, 23);
		nudMaxChrome.TabIndex = 151;
		nudMaxChrome.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(11, 138);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(110, 16);
		label8.TabIndex = 197;
		label8.Text = "Trang đăng nhâ\u0323p:";
		E604DA36.AutoSize = true;
		E604DA36.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		E604DA36.Location = new System.Drawing.Point(11, 49);
		E604DA36.Name = "label16";
		E604DA36.Size = new System.Drawing.Size(175, 16);
		E604DA36.TabIndex = 33;
		E604DA36.Text = "Số tab chrome mơ\u0309 đô\u0300ng thơ\u0300i:";
		FD9C2193.Location = new System.Drawing.Point(192, 76);
		FD9C2193.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		FD9C2193.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		FD9C2193.Name = "nudDelayOpenChromeFrom";
		FD9C2193.Size = new System.Drawing.Size(51, 23);
		FD9C2193.TabIndex = 151;
		FD9C2193.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		ckbHideBrowser.AutoSize = true;
		ckbHideBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHideBrowser.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbHideBrowser.Location = new System.Drawing.Point(271, 24);
		ckbHideBrowser.Name = "ckbHideBrowser";
		ckbHideBrowser.Size = new System.Drawing.Size(88, 20);
		ckbHideBrowser.TabIndex = 112;
		ckbHideBrowser.Text = "Ẩn chrome";
		ckbHideBrowser.UseVisualStyleBackColor = true;
		ckbHideBrowser.Visible = false;
		label20.AutoSize = true;
		label20.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label20.Location = new System.Drawing.Point(11, 78);
		label20.Name = "label20";
		label20.Size = new System.Drawing.Size(156, 16);
		label20.TabIndex = 33;
		label20.Text = "Gia\u0303n ca\u0301ch mơ\u0309 chrome (s):";
		ckbUnlock956.AutoSize = true;
		ckbUnlock956.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbUnlock956.Location = new System.Drawing.Point(745, 220);
		ckbUnlock956.Name = "ckbUnlock956";
		ckbUnlock956.Size = new System.Drawing.Size(152, 20);
		ckbUnlock956.TabIndex = 69;
		ckbUnlock956.Text = "Unlock checkpoint 956";
		ckbUnlock956.UseVisualStyleBackColor = true;
		ckbUnlock956.CheckedChanged += new System.EventHandler(ckbUnlock956_CheckedChanged);
		D99BA487.AutoSize = true;
		D99BA487.Cursor = System.Windows.Forms.Cursors.Hand;
		D99BA487.Location = new System.Drawing.Point(895, 221);
		D99BA487.Name = "lblUnlock956";
		D99BA487.Size = new System.Drawing.Size(57, 16);
		D99BA487.TabIndex = 70;
		D99BA487.TabStop = true;
		D99BA487.Text = "Cấu hình";
		D99BA487.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(D99BA487_LinkClicked);
		ckbCheckProxy.AutoSize = true;
		ckbCheckProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCheckProxy.Enabled = false;
		ckbCheckProxy.Location = new System.Drawing.Point(1036, 220);
		ckbCheckProxy.Name = "ckbCheckProxy";
		ckbCheckProxy.Size = new System.Drawing.Size(95, 20);
		ckbCheckProxy.TabIndex = 94;
		ckbCheckProxy.Text = "Check proxy";
		ckbCheckProxy.UseVisualStyleBackColor = true;
		F49B67B7.AutoSize = true;
		F49B67B7.Cursor = System.Windows.Forms.Cursors.Hand;
		F49B67B7.Enabled = false;
		F49B67B7.Location = new System.Drawing.Point(1036, 276);
		F49B67B7.Name = "ckbCheckToken";
		F49B67B7.Size = new System.Drawing.Size(95, 20);
		F49B67B7.TabIndex = 94;
		F49B67B7.Text = "Check token";
		F49B67B7.UseVisualStyleBackColor = true;
		ckbCheckLiveUid.AutoSize = true;
		ckbCheckLiveUid.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCheckLiveUid.Enabled = false;
		ckbCheckLiveUid.Location = new System.Drawing.Point(1036, 248);
		ckbCheckLiveUid.Name = "ckbCheckLiveUid";
		ckbCheckLiveUid.Size = new System.Drawing.Size(87, 20);
		ckbCheckLiveUid.TabIndex = 94;
		ckbCheckLiveUid.Text = "Check wall";
		ckbCheckLiveUid.UseVisualStyleBackColor = true;
		tabPage3.Controls.Add(grRunBy);
		tabPage3.Controls.Add(A739F720);
		tabPage3.Controls.Add(grChonJob);
		tabPage3.Location = new System.Drawing.Point(4, 25);
		tabPage3.Name = "tabPage3";
		tabPage3.Padding = new System.Windows.Forms.Padding(3);
		tabPage3.Size = new System.Drawing.Size(1111, 204);
		tabPage3.TabIndex = 2;
		tabPage3.Text = "Câ\u0301u hi\u0300nh job";
		tabPage3.UseVisualStyleBackColor = true;
		grRunBy.Controls.Add(rbChayBangToken);
		grRunBy.Controls.Add(rbChayBangCookie);
		grRunBy.Controls.Add(plChayBangToken);
		grRunBy.Controls.Add(rbChayBangChrome);
		grRunBy.Location = new System.Drawing.Point(340, 6);
		grRunBy.Name = "grRunBy";
		grRunBy.Size = new System.Drawing.Size(272, 193);
		grRunBy.TabIndex = 208;
		grRunBy.TabStop = false;
		rbChayBangToken.AutoSize = true;
		rbChayBangToken.Location = new System.Drawing.Point(9, 17);
		rbChayBangToken.Name = "rbChayBangToken";
		rbChayBangToken.Size = new System.Drawing.Size(120, 20);
		rbChayBangToken.TabIndex = 99;
		rbChayBangToken.TabStop = true;
		rbChayBangToken.Text = "Cha\u0323y bă\u0300ng token";
		rbChayBangToken.UseVisualStyleBackColor = true;
		rbChayBangToken.CheckedChanged += new System.EventHandler(rbChayBangToken_CheckedChanged);
		rbChayBangCookie.AutoSize = true;
		rbChayBangCookie.Location = new System.Drawing.Point(9, 135);
		rbChayBangCookie.Name = "rbChayBangCookie";
		rbChayBangCookie.Size = new System.Drawing.Size(125, 20);
		rbChayBangCookie.TabIndex = 99;
		rbChayBangCookie.TabStop = true;
		rbChayBangCookie.Text = "Cha\u0323y bă\u0300ng cookie";
		rbChayBangCookie.UseVisualStyleBackColor = true;
		rbChayBangCookie.CheckedChanged += new System.EventHandler(D3BB493A);
		plChayBangToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plChayBangToken.Controls.Add(label19);
		plChayBangToken.Controls.Add(label10);
		plChayBangToken.Controls.Add(cbbGetTokenBy);
		plChayBangToken.Controls.Add(D30C68B8);
		plChayBangToken.Controls.Add(EF1D13BA);
		plChayBangToken.Location = new System.Drawing.Point(9, 39);
		plChayBangToken.Name = "plChayBangToken";
		plChayBangToken.Size = new System.Drawing.Size(255, 90);
		plChayBangToken.TabIndex = 97;
		label19.AutoSize = true;
		label19.Location = new System.Drawing.Point(3, 37);
		label19.Name = "label19";
		label19.Size = new System.Drawing.Size(98, 16);
		label19.TabIndex = 61;
		label19.Text = "Lâ\u0301y token bă\u0300ng:";
		label10.AutoSize = true;
		label10.Location = new System.Drawing.Point(3, 7);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(100, 16);
		label10.TabIndex = 61;
		label10.Text = "Cho\u0323n loại token:";
		cbbGetTokenBy.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbGetTokenBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbGetTokenBy.FormattingEnabled = true;
		cbbGetTokenBy.Items.AddRange(new object[3] { "Chrome", "Cookie", "Uid|Pass" });
		cbbGetTokenBy.Location = new System.Drawing.Point(107, 34);
		cbbGetTokenBy.Name = "cbbGetTokenBy";
		cbbGetTokenBy.Size = new System.Drawing.Size(143, 24);
		cbbGetTokenBy.TabIndex = 74;
		D30C68B8.AutoSize = true;
		D30C68B8.Cursor = System.Windows.Forms.Cursors.Hand;
		D30C68B8.Location = new System.Drawing.Point(6, 64);
		D30C68B8.Name = "ckbGetTokenWhenDie";
		D30C68B8.Size = new System.Drawing.Size(222, 20);
		D30C68B8.TabIndex = 94;
		D30C68B8.Text = "Tự động lấy lại token khi token die";
		D30C68B8.UseVisualStyleBackColor = true;
		EF1D13BA.Cursor = System.Windows.Forms.Cursors.Hand;
		EF1D13BA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		EF1D13BA.FormattingEnabled = true;
		EF1D13BA.Items.AddRange(new object[3] { "EAAG", "EAAAAU", "EAABs" });
		EF1D13BA.Location = new System.Drawing.Point(107, 4);
		EF1D13BA.Name = "cbbTypeGetToken";
		EF1D13BA.Size = new System.Drawing.Size(143, 24);
		EF1D13BA.TabIndex = 74;
		EF1D13BA.SelectedIndexChanged += new System.EventHandler(EF1D13BA_SelectedIndexChanged);
		rbChayBangChrome.AutoSize = true;
		rbChayBangChrome.Location = new System.Drawing.Point(9, 161);
		rbChayBangChrome.Name = "rbChayBangChrome";
		rbChayBangChrome.Size = new System.Drawing.Size(132, 20);
		rbChayBangChrome.TabIndex = 99;
		rbChayBangChrome.TabStop = true;
		rbChayBangChrome.Text = "Cha\u0323y bă\u0300ng chrome";
		rbChayBangChrome.UseVisualStyleBackColor = true;
		rbChayBangChrome.CheckedChanged += new System.EventHandler(rbChayBangChrome_CheckedChanged);
		A739F720.Controls.Add(FB1741A8);
		A739F720.Controls.Add(F98E5B8A);
		A739F720.Controls.Add(B706E7AC);
		A739F720.Controls.Add(ckbChayBangPageProfile);
		A739F720.Controls.Add(B3A671B1);
		A739F720.Controls.Add(nudDelayTo);
		A739F720.Controls.Add(BD8A7F88);
		A739F720.Controls.Add(plBreakTime);
		A739F720.Controls.Add(label13);
		A739F720.Controls.Add(A63DDA9B);
		A739F720.Controls.Add(E62B17A7);
		A739F720.Controls.Add(txtApiKey);
		A739F720.Controls.Add(C7BBA9A1);
		A739F720.Controls.Add(CEBA2D85);
		A739F720.Controls.Add(label7);
		A739F720.Controls.Add(F18113B8);
		A739F720.Controls.Add(E4B49E18);
		A739F720.Controls.Add(label4);
		A739F720.Controls.Add(nudTimeoutGetJob);
		A739F720.Controls.Add(AF0B1AB0);
		A739F720.Location = new System.Drawing.Point(6, 6);
		A739F720.Name = "groupBox3";
		A739F720.Size = new System.Drawing.Size(328, 193);
		A739F720.TabIndex = 207;
		A739F720.TabStop = false;
		FB1741A8.AutoSize = true;
		FB1741A8.Location = new System.Drawing.Point(10, 19);
		FB1741A8.Name = "label15";
		FB1741A8.Size = new System.Drawing.Size(47, 16);
		FB1741A8.TabIndex = 49;
		FB1741A8.Text = "Token:";
		F98E5B8A.AutoSize = true;
		F98E5B8A.Location = new System.Drawing.Point(285, 76);
		F98E5B8A.Name = "label5";
		F98E5B8A.Size = new System.Drawing.Size(30, 16);
		F98E5B8A.TabIndex = 83;
		F98E5B8A.Text = "giây";
		B706E7AC.Cursor = System.Windows.Forms.Cursors.Hand;
		B706E7AC.Location = new System.Drawing.Point(226, 15);
		B706E7AC.Name = "button3";
		B706E7AC.Size = new System.Drawing.Size(56, 25);
		B706E7AC.TabIndex = 91;
		B706E7AC.Text = "Check";
		B706E7AC.UseVisualStyleBackColor = true;
		B706E7AC.Click += new System.EventHandler(D38B1C9D);
		ckbChayBangPageProfile.AutoSize = true;
		ckbChayBangPageProfile.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbChayBangPageProfile.Location = new System.Drawing.Point(13, 202);
		ckbChayBangPageProfile.Name = "ckbChayBangPageProfile";
		ckbChayBangPageProfile.Size = new System.Drawing.Size(148, 20);
		ckbChayBangPageProfile.TabIndex = 95;
		ckbChayBangPageProfile.Text = "Chạy bằng page pro5";
		ckbChayBangPageProfile.UseVisualStyleBackColor = true;
		ckbChayBangPageProfile.CheckedChanged += new System.EventHandler(ckbChayBangPageProfile_CheckedChanged);
		B3A671B1.AutoSize = true;
		B3A671B1.Location = new System.Drawing.Point(285, 134);
		B3A671B1.Name = "label12";
		B3A671B1.Size = new System.Drawing.Size(31, 16);
		B3A671B1.TabIndex = 82;
		B3A671B1.Text = "jobs";
		nudDelayTo.Location = new System.Drawing.Point(226, 45);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Minimum = new decimal(new int[4] { 10, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 80;
		nudDelayTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		BD8A7F88.AutoSize = true;
		BD8A7F88.Location = new System.Drawing.Point(285, 47);
		BD8A7F88.Name = "label14";
		BD8A7F88.Size = new System.Drawing.Size(30, 16);
		BD8A7F88.TabIndex = 83;
		BD8A7F88.Text = "giây";
		plBreakTime.Controls.Add(nudBreakTimeJob);
		plBreakTime.Controls.Add(label24);
		plBreakTime.Controls.Add(DFB28682);
		plBreakTime.Controls.Add(F62E8310);
		plBreakTime.Location = new System.Drawing.Point(100, 160);
		plBreakTime.Name = "plBreakTime";
		plBreakTime.Size = new System.Drawing.Size(215, 25);
		plBreakTime.TabIndex = 93;
		nudBreakTimeJob.Location = new System.Drawing.Point(9, 1);
		nudBreakTimeJob.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudBreakTimeJob.Name = "nudBreakTimeJob";
		nudBreakTimeJob.Size = new System.Drawing.Size(41, 23);
		nudBreakTimeJob.TabIndex = 78;
		nudBreakTimeJob.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		label24.AutoSize = true;
		label24.Location = new System.Drawing.Point(52, 3);
		label24.Name = "label24";
		label24.Size = new System.Drawing.Size(70, 16);
		label24.TabIndex = 88;
		label24.Text = "job sẽ nghỉ";
		DFB28682.AutoSize = true;
		DFB28682.Location = new System.Drawing.Point(185, 3);
		DFB28682.Name = "label22";
		DFB28682.Size = new System.Drawing.Size(30, 16);
		DFB28682.TabIndex = 83;
		DFB28682.Text = "giây";
		F62E8310.Location = new System.Drawing.Point(126, 1);
		F62E8310.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F62E8310.Name = "nudBreakTime";
		F62E8310.Size = new System.Drawing.Size(56, 23);
		F62E8310.TabIndex = 78;
		F62E8310.Value = new decimal(new int[4] { 60, 0, 0, 0 });
		label13.AutoSize = true;
		label13.Location = new System.Drawing.Point(285, 105);
		label13.Name = "label13";
		label13.Size = new System.Drawing.Size(31, 16);
		label13.TabIndex = 81;
		label13.Text = "jobs";
		A63DDA9B.Location = new System.Drawing.Point(226, 103);
		A63DDA9B.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A63DDA9B.Name = "nudMaxJobToday";
		A63DDA9B.Size = new System.Drawing.Size(56, 23);
		A63DDA9B.TabIndex = 76;
		E62B17A7.AutoSize = true;
		E62B17A7.Location = new System.Drawing.Point(10, 105);
		E62B17A7.Name = "label3";
		E62B17A7.Size = new System.Drawing.Size(174, 16);
		E62B17A7.TabIndex = 86;
		E62B17A7.Text = "Số job tối đa/tài khoản/ngày:";
		txtApiKey.Location = new System.Drawing.Point(63, 16);
		txtApiKey.Name = "txtApiKey";
		txtApiKey.Size = new System.Drawing.Size(159, 23);
		txtApiKey.TabIndex = 48;
		txtApiKey.TextChanged += new System.EventHandler(txtApiKey_TextChanged);
		C7BBA9A1.AutoSize = true;
		C7BBA9A1.Location = new System.Drawing.Point(10, 76);
		C7BBA9A1.Name = "label18";
		C7BBA9A1.Size = new System.Drawing.Size(131, 16);
		C7BBA9A1.TabIndex = 87;
		C7BBA9A1.Text = "Thơ\u0300i gian chơ\u0300 lâ\u0301y job:";
		CEBA2D85.AutoSize = true;
		CEBA2D85.Cursor = System.Windows.Forms.Cursors.Hand;
		CEBA2D85.Location = new System.Drawing.Point(13, 162);
		CEBA2D85.Name = "ckbBreakTime";
		CEBA2D85.Size = new System.Drawing.Size(86, 20);
		CEBA2D85.TabIndex = 92;
		CEBA2D85.Text = "Chạy được";
		CEBA2D85.UseVisualStyleBackColor = true;
		CEBA2D85.CheckedChanged += new System.EventHandler(DE07A521);
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label7.Location = new System.Drawing.Point(197, 47);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 90;
		label7.Text = ">";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F18113B8.Location = new System.Drawing.Point(226, 132);
		F18113B8.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F18113B8.Name = "nudMaxJobFailLienTiep";
		F18113B8.Size = new System.Drawing.Size(56, 23);
		F18113B8.TabIndex = 77;
		E4B49E18.AutoSize = true;
		E4B49E18.Location = new System.Drawing.Point(10, 134);
		E4B49E18.Name = "label11";
		E4B49E18.Size = new System.Drawing.Size(132, 16);
		E4B49E18.TabIndex = 87;
		E4B49E18.Text = "Dừng khi fail liên tiếp:";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(10, 47);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(99, 16);
		label4.TabIndex = 88;
		label4.Text = "Nghỉ giữa 2 job:";
		nudTimeoutGetJob.Location = new System.Drawing.Point(226, 74);
		nudTimeoutGetJob.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeoutGetJob.Minimum = new decimal(new int[4] { 10, 0, 0, 0 });
		nudTimeoutGetJob.Name = "nudTimeoutGetJob";
		nudTimeoutGetJob.Size = new System.Drawing.Size(56, 23);
		nudTimeoutGetJob.TabIndex = 78;
		nudTimeoutGetJob.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		AF0B1AB0.Location = new System.Drawing.Point(140, 45);
		AF0B1AB0.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		AF0B1AB0.Minimum = new decimal(new int[4] { 10, 0, 0, 0 });
		AF0B1AB0.Name = "nudDelayFrom";
		AF0B1AB0.Size = new System.Drawing.Size(56, 23);
		AF0B1AB0.TabIndex = 78;
		AF0B1AB0.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		grChonJob.Controls.Add(btnDown);
		grChonJob.Controls.Add(plKey);
		grChonJob.Controls.Add(ckbCheckAll);
		grChonJob.Controls.Add(lblServer);
		grChonJob.Controls.Add(ckbCommentfb_via_male2);
		grChonJob.Controls.Add(ckbCommentfb_via_female2);
		grChonJob.Controls.Add(ckbLikePage_PageProfile);
		grChonJob.Controls.Add(cbbServer);
		grChonJob.Controls.Add(ckbFollow);
		grChonJob.Controls.Add(D3011989);
		grChonJob.Controls.Add(A73F6F03);
		grChonJob.Controls.Add(ckbCommentfb_full_avatar2);
		grChonJob.Controls.Add(ckbCommentfb);
		grChonJob.Controls.Add(ckbJoin_Group);
		grChonJob.Controls.Add(EF91F21A);
		grChonJob.Controls.Add(ckbAngry);
		grChonJob.Controls.Add(ckbHaha);
		grChonJob.Controls.Add(F7BC6739);
		grChonJob.Controls.Add(ckbCare);
		grChonJob.Controls.Add(D69B8981);
		grChonJob.Controls.Add(ckbLove);
		grChonJob.Controls.Add(ckbLike);
		grChonJob.Controls.Add(ckbLike_Comment);
		grChonJob.Controls.Add(ckbShare);
		grChonJob.Controls.Add(FE0EEC0F);
		grChonJob.Location = new System.Drawing.Point(618, 6);
		grChonJob.Name = "grChonJob";
		grChonJob.Size = new System.Drawing.Size(487, 193);
		grChonJob.TabIndex = 204;
		grChonJob.TabStop = false;
		grChonJob.Text = "                   ";
		btnDown.BackgroundImage = C50FB39E.FF97E5B3;
		btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnDown.Location = new System.Drawing.Point(462, 8);
		btnDown.Name = "btnDown";
		btnDown.Size = new System.Drawing.Size(25, 25);
		btnDown.TabIndex = 204;
		btnDown.Click += new System.EventHandler(btnDown_Click);
		plKey.Controls.Add(lblKey);
		plKey.Controls.Add(C413DEAD);
		plKey.Controls.Add(E2035928);
		plKey.Location = new System.Drawing.Point(7, 155);
		plKey.Name = "plKey";
		plKey.Size = new System.Drawing.Size(452, 27);
		plKey.TabIndex = 203;
		plKey.Visible = false;
		lblKey.AutoSize = true;
		lblKey.Location = new System.Drawing.Point(3, 5);
		lblKey.Name = "lblKey";
		lblKey.Size = new System.Drawing.Size(32, 16);
		lblKey.TabIndex = 201;
		lblKey.Text = "Key:";
		C413DEAD.Location = new System.Drawing.Point(41, 2);
		C413DEAD.Name = "txtKey";
		C413DEAD.Size = new System.Drawing.Size(346, 23);
		C413DEAD.TabIndex = 202;
		E2035928.Cursor = System.Windows.Forms.Cursors.Hand;
		E2035928.Location = new System.Drawing.Point(393, 1);
		E2035928.Name = "btnCheckKey";
		E2035928.Size = new System.Drawing.Size(56, 25);
		E2035928.TabIndex = 91;
		E2035928.Text = "Check";
		E2035928.UseVisualStyleBackColor = true;
		E2035928.Click += new System.EventHandler(E2035928_Click);
		ckbCheckAll.AutoSize = true;
		ckbCheckAll.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCheckAll.Location = new System.Drawing.Point(12, -1);
		ckbCheckAll.Name = "ckbCheckAll";
		ckbCheckAll.Size = new System.Drawing.Size(78, 20);
		ckbCheckAll.TabIndex = 1;
		ckbCheckAll.Text = "Chọn Job";
		ckbCheckAll.UseVisualStyleBackColor = true;
		ckbCheckAll.CheckedChanged += new System.EventHandler(CF2D2631);
		lblServer.AutoSize = true;
		lblServer.Location = new System.Drawing.Point(9, 269);
		lblServer.Name = "lblServer";
		lblServer.Size = new System.Drawing.Size(50, 16);
		lblServer.TabIndex = 2;
		lblServer.Text = "Server:";
		ckbCommentfb_via_male2.AutoSize = true;
		ckbCommentfb_via_male2.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCommentfb_via_male2.Location = new System.Drawing.Point(6, 199);
		ckbCommentfb_via_male2.Name = "ckbCommentfb_via_male2";
		ckbCommentfb_via_male2.Size = new System.Drawing.Size(128, 20);
		ckbCommentfb_via_male2.TabIndex = 0;
		ckbCommentfb_via_male2.Text = "comment via nam";
		ckbCommentfb_via_male2.UseVisualStyleBackColor = true;
		ckbCommentfb_via_female2.AutoSize = true;
		ckbCommentfb_via_female2.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCommentfb_via_female2.Location = new System.Drawing.Point(140, 199);
		ckbCommentfb_via_female2.Name = "ckbCommentfb_via_female2";
		ckbCommentfb_via_female2.Size = new System.Drawing.Size(118, 20);
		ckbCommentfb_via_female2.TabIndex = 0;
		ckbCommentfb_via_female2.Text = "comment via nư\u0303";
		ckbCommentfb_via_female2.UseVisualStyleBackColor = true;
		ckbLikePage_PageProfile.AutoSize = true;
		ckbLikePage_PageProfile.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLikePage_PageProfile.Location = new System.Drawing.Point(367, 238);
		ckbLikePage_PageProfile.Name = "ckbLikePage_PageProfile";
		ckbLikePage_PageProfile.Size = new System.Drawing.Size(151, 20);
		ckbLikePage_PageProfile.TabIndex = 0;
		ckbLikePage_PageProfile.Text = "like_page_pageprofile";
		ckbLikePage_PageProfile.UseVisualStyleBackColor = true;
		ckbLikePage_PageProfile.Visible = false;
		cbbServer.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbServer.FormattingEnabled = true;
		cbbServer.Items.AddRange(new object[6] { "Viê\u0323t Nam", "Philippines", "US", "Thailand", "Thailand Via", "Indonesia" });
		cbbServer.Location = new System.Drawing.Point(63, 266);
		cbbServer.Name = "cbbServer";
		cbbServer.Size = new System.Drawing.Size(137, 24);
		cbbServer.TabIndex = 200;
		ckbFollow.AutoSize = true;
		ckbFollow.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbFollow.Location = new System.Drawing.Point(275, 51);
		ckbFollow.Name = "ckbFollow";
		ckbFollow.Size = new System.Drawing.Size(60, 20);
		ckbFollow.TabIndex = 0;
		ckbFollow.Text = "follow";
		ckbFollow.UseVisualStyleBackColor = true;
		D3011989.AutoSize = true;
		D3011989.Cursor = System.Windows.Forms.Cursors.Hand;
		D3011989.Location = new System.Drawing.Point(104, 77);
		D3011989.Name = "ckbReview_Page";
		D3011989.Size = new System.Drawing.Size(96, 20);
		D3011989.TabIndex = 0;
		D3011989.Text = "review page";
		D3011989.UseVisualStyleBackColor = true;
		A73F6F03.AutoSize = true;
		A73F6F03.Cursor = System.Windows.Forms.Cursors.Hand;
		A73F6F03.Location = new System.Drawing.Point(344, 77);
		A73F6F03.Name = "ckbCommentfb_via2";
		A73F6F03.Size = new System.Drawing.Size(99, 20);
		A73F6F03.TabIndex = 0;
		A73F6F03.Text = "comment via";
		A73F6F03.UseVisualStyleBackColor = true;
		ckbCommentfb_full_avatar2.AutoSize = true;
		ckbCommentfb_full_avatar2.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCommentfb_full_avatar2.Location = new System.Drawing.Point(206, 77);
		ckbCommentfb_full_avatar2.Name = "ckbCommentfb_full_avatar2";
		ckbCommentfb_full_avatar2.Size = new System.Drawing.Size(142, 20);
		ckbCommentfb_full_avatar2.TabIndex = 0;
		ckbCommentfb_full_avatar2.Text = "Comment full avatar";
		ckbCommentfb_full_avatar2.UseVisualStyleBackColor = true;
		ckbCommentfb.AutoSize = true;
		ckbCommentfb.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCommentfb.Location = new System.Drawing.Point(73, 51);
		ckbCommentfb.Name = "ckbCommentfb";
		ckbCommentfb.Size = new System.Drawing.Size(79, 20);
		ckbCommentfb.TabIndex = 0;
		ckbCommentfb.Text = "comment";
		ckbCommentfb.UseVisualStyleBackColor = true;
		ckbJoin_Group.AutoSize = true;
		ckbJoin_Group.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbJoin_Group.Location = new System.Drawing.Point(12, 77);
		ckbJoin_Group.Name = "ckbJoin_Group";
		ckbJoin_Group.Size = new System.Drawing.Size(84, 20);
		ckbJoin_Group.TabIndex = 0;
		ckbJoin_Group.Text = "join group";
		ckbJoin_Group.UseVisualStyleBackColor = true;
		EF91F21A.AutoSize = true;
		EF91F21A.Cursor = System.Windows.Forms.Cursors.Hand;
		EF91F21A.ForeColor = System.Drawing.Color.DarkGreen;
		EF91F21A.Location = new System.Drawing.Point(12, 103);
		EF91F21A.Name = "ckbJob_All";
		EF91F21A.Size = new System.Drawing.Size(128, 20);
		EF91F21A.TabIndex = 0;
		EF91F21A.Text = "Cha\u0323y ca\u0309 job ngoa\u0323i";
		EF91F21A.UseVisualStyleBackColor = true;
		ckbAngry.AutoSize = true;
		ckbAngry.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAngry.Location = new System.Drawing.Point(406, 25);
		ckbAngry.Name = "ckbAngry";
		ckbAngry.Size = new System.Drawing.Size(58, 20);
		ckbAngry.TabIndex = 0;
		ckbAngry.Text = "angry";
		ckbAngry.UseVisualStyleBackColor = true;
		ckbHaha.AutoSize = true;
		ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHaha.Location = new System.Drawing.Point(205, 25);
		ckbHaha.Name = "ckbHaha";
		ckbHaha.Size = new System.Drawing.Size(54, 20);
		ckbHaha.TabIndex = 0;
		ckbHaha.Text = "haha";
		ckbHaha.UseVisualStyleBackColor = true;
		F7BC6739.AutoSize = true;
		F7BC6739.Cursor = System.Windows.Forms.Cursors.Hand;
		F7BC6739.Location = new System.Drawing.Point(344, 25);
		F7BC6739.Name = "ckbSad";
		F7BC6739.Size = new System.Drawing.Size(46, 20);
		F7BC6739.TabIndex = 0;
		F7BC6739.Text = "sad";
		F7BC6739.UseVisualStyleBackColor = true;
		ckbCare.AutoSize = true;
		ckbCare.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCare.Location = new System.Drawing.Point(138, 25);
		ckbCare.Name = "ckbCare";
		ckbCare.Size = new System.Drawing.Size(51, 20);
		ckbCare.TabIndex = 0;
		ckbCare.Text = "care";
		ckbCare.UseVisualStyleBackColor = true;
		D69B8981.AutoSize = true;
		D69B8981.Cursor = System.Windows.Forms.Cursors.Hand;
		D69B8981.Location = new System.Drawing.Point(275, 25);
		D69B8981.Name = "ckbWow";
		D69B8981.Size = new System.Drawing.Size(53, 20);
		D69B8981.TabIndex = 0;
		D69B8981.Text = "wow";
		D69B8981.UseVisualStyleBackColor = true;
		ckbLove.AutoSize = true;
		ckbLove.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLove.Location = new System.Drawing.Point(73, 25);
		ckbLove.Name = "ckbLove";
		ckbLove.Size = new System.Drawing.Size(49, 20);
		ckbLove.TabIndex = 0;
		ckbLove.Text = "love";
		ckbLove.UseVisualStyleBackColor = true;
		ckbLike.AutoSize = true;
		ckbLike.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLike.Location = new System.Drawing.Point(12, 25);
		ckbLike.Name = "ckbLike";
		ckbLike.Size = new System.Drawing.Size(45, 20);
		ckbLike.TabIndex = 0;
		ckbLike.Text = "like";
		ckbLike.UseVisualStyleBackColor = true;
		ckbLike_Comment.AutoSize = true;
		ckbLike_Comment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLike_Comment.Location = new System.Drawing.Point(158, 51);
		ckbLike_Comment.Name = "ckbLike_Comment";
		ckbLike_Comment.Size = new System.Drawing.Size(102, 20);
		ckbLike_Comment.TabIndex = 0;
		ckbLike_Comment.Text = "like comment";
		ckbLike_Comment.UseVisualStyleBackColor = true;
		ckbShare.AutoSize = true;
		ckbShare.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbShare.Location = new System.Drawing.Point(12, 51);
		ckbShare.Name = "ckbShare";
		ckbShare.Size = new System.Drawing.Size(58, 20);
		ckbShare.TabIndex = 0;
		ckbShare.Text = "share";
		ckbShare.UseVisualStyleBackColor = true;
		FE0EEC0F.AutoSize = true;
		FE0EEC0F.Cursor = System.Windows.Forms.Cursors.Hand;
		FE0EEC0F.Location = new System.Drawing.Point(344, 51);
		FE0EEC0F.Name = "ckbLike_Page";
		FE0EEC0F.Size = new System.Drawing.Size(77, 20);
		FE0EEC0F.TabIndex = 0;
		FE0EEC0F.Text = "like page";
		FE0EEC0F.UseVisualStyleBackColor = true;
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
		button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button2.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
		button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		button2.Location = new System.Drawing.Point(256, 109);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(111, 32);
		button2.TabIndex = 13;
		button2.Text = "Dừng tất cả";
		button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		button2.UseVisualStyleBackColor = false;
		button2.Click += new System.EventHandler(button2_Click);
		D9927D91.Cursor = System.Windows.Forms.Cursors.Hand;
		D9927D91.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		D9927D91.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
		D9927D91.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D9927D91.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D9927D91.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		D9927D91.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		D9927D91.Location = new System.Drawing.Point(131, 109);
		D9927D91.Name = "button1";
		D9927D91.Size = new System.Drawing.Size(119, 32);
		D9927D91.TabIndex = 13;
		D9927D91.Text = "Dừng đã chọn";
		D9927D91.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		D9927D91.UseVisualStyleBackColor = false;
		D9927D91.Click += new System.EventHandler(AB95ECA2);
		btnHienCaiDat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		btnHienCaiDat.Cursor = System.Windows.Forms.Cursors.Hand;
		btnHienCaiDat.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnHienCaiDat.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
		btnHienCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnHienCaiDat.Location = new System.Drawing.Point(997, 109);
		btnHienCaiDat.Name = "btnHienCaiDat";
		btnHienCaiDat.Size = new System.Drawing.Size(130, 32);
		btnHienCaiDat.TabIndex = 7;
		btnHienCaiDat.Text = "Ẩn cài đặt";
		btnHienCaiDat.Click += new System.EventHandler(C53947BC);
		statusStrip1.BackColor = System.Drawing.SystemColors.Control;
		statusStrip1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[10] { toolStripStatusLabel4, E71E4104, CF1A928E, lblCountSelect, toolStripStatusLabel7, lblCountTotal, CF8E9634, lblCountRunning, C5B60C89, lblCountChrome });
		statusStrip1.Location = new System.Drawing.Point(0, 623);
		statusStrip1.Name = "statusStrip1";
		statusStrip1.Size = new System.Drawing.Size(1137, 22);
		statusStrip1.SizingGrip = false;
		statusStrip1.TabIndex = 9;
		statusStrip1.Text = "statusStrip1";
		statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(statusStrip1_ItemClicked);
		CF8E9634.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CF8E9634.Name = "toolStripStatusLabel1";
		CF8E9634.Size = new System.Drawing.Size(66, 17);
		CF8E9634.Text = "Account:";
		lblCountRunning.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblCountRunning.ForeColor = System.Drawing.Color.Green;
		lblCountRunning.Name = "lblCountRunning";
		lblCountRunning.Size = new System.Drawing.Size(15, 17);
		lblCountRunning.Text = "0";
		C5B60C89.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C5B60C89.Name = "toolStripStatusLabel2";
		C5B60C89.Size = new System.Drawing.Size(61, 17);
		C5B60C89.Text = "Chrome:";
		lblCountChrome.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblCountChrome.ForeColor = System.Drawing.Color.RoyalBlue;
		lblCountChrome.Name = "lblCountChrome";
		lblCountChrome.Size = new System.Drawing.Size(15, 17);
		lblCountChrome.Text = "0";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(1139, 647);
		base.Controls.Add(F5948F3E);
		base.Controls.Add(bunifuCards1);
		base.Controls.Add(menuStrip1);
		base.Controls.Add(panel1);
		DoubleBuffered = true;
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MainMenuStrip = menuStrip1;
		base.Name = "fGolike";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "MAX CARE";
		ctmsAcc.ResumeLayout(false);
		C00C0E9C.ResumeLayout(false);
		C00C0E9C.PerformLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		bunifuCards1.ResumeLayout(false);
		menuStrip1.ResumeLayout(false);
		menuStrip1.PerformLayout();
		F5948F3E.ResumeLayout(false);
		EF907231.ResumeLayout(false);
		EF907231.PerformLayout();
		C3BBF8AC.ResumeLayout(false);
		C3BBF8AC.PerformLayout();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)EB3CF7AF).EndInit();
		tabControl1.ResumeLayout(false);
		BB832C28.ResumeLayout(false);
		BB832C28.PerformLayout();
		B38E60B4.ResumeLayout(false);
		B38E60B4.PerformLayout();
		((System.ComponentModel.ISupportInitialize)F40A5030).EndInit();
		CB30E000.ResumeLayout(false);
		CB30E000.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayOpenChromeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudMaxChrome).EndInit();
		((System.ComponentModel.ISupportInitialize)FD9C2193).EndInit();
		tabPage3.ResumeLayout(false);
		grRunBy.ResumeLayout(false);
		grRunBy.PerformLayout();
		plChayBangToken.ResumeLayout(false);
		plChayBangToken.PerformLayout();
		A739F720.ResumeLayout(false);
		A739F720.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		plBreakTime.ResumeLayout(false);
		plBreakTime.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudBreakTimeJob).EndInit();
		((System.ComponentModel.ISupportInitialize)F62E8310).EndInit();
		((System.ComponentModel.ISupportInitialize)A63DDA9B).EndInit();
		((System.ComponentModel.ISupportInitialize)F18113B8).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeoutGetJob).EndInit();
		((System.ComponentModel.ISupportInitialize)AF0B1AB0).EndInit();
		grChonJob.ResumeLayout(false);
		grChonJob.PerformLayout();
		plKey.ResumeLayout(false);
		plKey.PerformLayout();
		statusStrip1.ResumeLayout(false);
		statusStrip1.PerformLayout();
		ResumeLayout(false);
	}

	[CompilerGenerated]
	private void method_82()
	{
		if (F5948F3E.Visible)
		{
			F5948F3E.Visible = false;
		}
	}

	[CompilerGenerated]
	private void method_83()
	{
		lblCountChrome.Text = int_3.ToString();
	}

	[CompilerGenerated]
	private void method_84()
	{
		lblCountRunning.Text = dictionary_28.Count.ToString();
	}

	[CompilerGenerated]
	private void method_85()
	{
		try
		{
			btnInteract.C22B543F(bool_0: false);
			while (true)
			{
				try
				{
					A235CA9E = new List<Thread>();
					for (int i = 0; i < EB3CF7AF.RowCount; i++)
					{
						if (Class57.smethod_5())
						{
							break;
						}
						if (!Convert.ToBoolean(EB3CF7AF.Rows[i].Cells["cChose"].Value) || dictionary_28.ContainsKey(i))
						{
							continue;
						}
						if ((decimal)dictionary_28.Count >= F40A5030.Value)
						{
							GClass8.smethod_53(1.0);
							i--;
							continue;
						}
						if (Class57.smethod_5())
						{
							break;
						}
						int int_0 = i;
						dictionary_28.Add(int_0, new E31BC589(this, int_0));
						Thread thread = new Thread((ThreadStart)delegate
						{
							try
							{
								dictionary_28[int_0].FB2B639E();
							}
							catch (Exception)
							{
							}
						})
						{
							IsBackground = true
						};
						A235CA9E.Add(thread);
						thread.Start();
						method_78();
						GClass8.smethod_53(0.1);
					}
					if (!Class57.smethod_5() && Convert.ToBoolean(B50940A9.Checked))
					{
						for (int j = 0; j < A235CA9E.Count; j++)
						{
							A235CA9E[j].Join();
						}
						if (Convert.ToBoolean(B50940A9.Checked) && AB0B20AA() != 0)
						{
							continue;
						}
					}
				}
				catch (Exception)
				{
					continue;
				}
				break;
			}
			btnInteract.C22B543F();
		}
		catch (Exception ex2)
		{
			GClass29.smethod_0("btnInteract_Click\n" + ex2.ToString());
		}
	}
}
