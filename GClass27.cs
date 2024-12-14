using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class GClass27
{
	[CompilerGenerated]
	private sealed class Class95
	{
		public DataGridView A50F8E1F;

		public bool bool_0;

		internal void method_0()
		{
			foreach (DataGridViewColumn column in A50F8E1F.Columns)
			{
				column.SortMode = (bool_0 ? DataGridViewColumnSortMode.Automatic : DataGridViewColumnSortMode.NotSortable);
			}
		}
	}

	[CompilerGenerated]
	private sealed class D30D4BB7
	{
		public string string_0;

		public DataGridView A6A1EABD;

		public int int_0;

		public int int_1;

		internal void method_0()
		{
			string_0 = A6A1EABD.Rows[int_0].Cells[int_1].Value.ToString();
		}
	}

	[CompilerGenerated]
	private sealed class Class96
	{
		public string CDA1758C;

		public DataGridView dataGridView_0;

		public int int_0;

		public string string_0;

		internal void method_0()
		{
			CDA1758C = dataGridView_0.Rows[int_0].Cells[string_0].Value.ToString();
		}
	}

	[CompilerGenerated]
	private sealed class F501981B
	{
		public DataGridView dataGridView_0;

		public int int_0;

		public int int_1;

		public object EDAB928A;

		internal void method_0()
		{
			dataGridView_0.Rows[int_0].Cells[int_1].Value = EDAB928A;
		}
	}

	[CompilerGenerated]
	private sealed class Class97
	{
		public DataGridView dataGridView_0;

		public int int_0;

		public string B923360C;

		public object F42A3928;

		internal void method_0()
		{
			dataGridView_0.Rows[int_0].Cells[B923360C].Value = F42A3928;
		}
	}

	private static Dictionary<DataGridView, bool> EB379E83 = new Dictionary<DataGridView, bool>();

	public static void E68A6883(DataGridView dataGridView_0, bool bool_0)
	{
		try
		{
			if (!EB379E83.ContainsKey(dataGridView_0))
			{
				EB379E83.Add(dataGridView_0, value: true);
			}
			if (EB379E83[dataGridView_0] == bool_0)
			{
				return;
			}
			dataGridView_0.Invoke((MethodInvoker)delegate
			{
				foreach (DataGridViewColumn column in dataGridView_0.Columns)
				{
					column.SortMode = (bool_0 ? DataGridViewColumnSortMode.Automatic : DataGridViewColumnSortMode.NotSortable);
				}
			});
			EB379E83[dataGridView_0] = bool_0;
		}
		catch (Exception)
		{
		}
	}

	public static void smethod_0(DataGridView dataGridView_0, int int_0)
	{
		if (int_0 == -1)
		{
			for (int i = 0; i < dataGridView_0.RowCount; i++)
			{
				E012E0A4(dataGridView_0, i, -1);
			}
		}
		else
		{
			E012E0A4(dataGridView_0, int_0, -1);
		}
	}

	public static void E012E0A4(DataGridView dataGridView_0, int int_0, int int_1)
	{
		if (int_1 == -1)
		{
			string text = smethod_3(dataGridView_0, int_0, "cInfo");
			if (text == "Live")
			{
				int_1 = 2;
			}
			else if (text.Contains("Die") || text.Contains("Checkpoint") || text.Contains("Changed pass"))
			{
				int_1 = 1;
			}
		}
		switch (GClass25.smethod_0("configGeneral").method_2("typePhanBietMau"))
		{
		case 0:
			switch (int_1)
			{
			case 0:
				dataGridView_0.Rows[int_0].DefaultCellStyle.BackColor = Color.White;
				break;
			case 1:
				dataGridView_0.Rows[int_0].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
				break;
			case 2:
				dataGridView_0.Rows[int_0].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
				break;
			}
			break;
		case 1:
			switch (int_1)
			{
			case 0:
				dataGridView_0.Rows[int_0].DefaultCellStyle.ForeColor = Color.Black;
				break;
			case 1:
				dataGridView_0.Rows[int_0].DefaultCellStyle.ForeColor = Color.Red;
				break;
			case 2:
				dataGridView_0.Rows[int_0].DefaultCellStyle.ForeColor = Color.Green;
				break;
			}
			break;
		}
	}

	public static void smethod_1(DataGridView dataGridView_0, int int_0, string string_0, int int_1 = 0, string E11493A6 = "Đơ\u0323i {time} giây...")
	{
		try
		{
			int tickCount = Environment.TickCount;
			while (true)
			{
				int num = int_1 - (Environment.TickCount - tickCount) / 1000;
				if (num > 0)
				{
					smethod_5(dataGridView_0, int_0, string_0, E11493A6.Replace("{time}", num.ToString()));
					GClass8.smethod_53(0.5);
					continue;
				}
				break;
			}
		}
		catch
		{
		}
	}

	public static string smethod_2(DataGridView DF221B3A, int int_0, int A22D3DA5)
	{
		string string_0 = "";
		try
		{
			if (DF221B3A.Rows[int_0].Cells[A22D3DA5].Value == null)
			{
				return "";
			}
			try
			{
				string_0 = DF221B3A.Rows[int_0].Cells[A22D3DA5].Value.ToString();
			}
			catch
			{
				DF221B3A.Invoke((MethodInvoker)delegate
				{
					string_0 = DF221B3A.Rows[int_0].Cells[A22D3DA5].Value.ToString();
				});
			}
		}
		catch
		{
		}
		return string_0;
	}

	public static string smethod_3(DataGridView dataGridView_0, int BF07A102, string F1A803B2)
	{
		string CDA1758C = "";
		try
		{
			if (dataGridView_0.Rows[BF07A102].Cells[F1A803B2].Value == null)
			{
				return "";
			}
			try
			{
				CDA1758C = dataGridView_0.Rows[BF07A102].Cells[F1A803B2].Value.ToString();
			}
			catch
			{
				dataGridView_0.Invoke((MethodInvoker)delegate
				{
					CDA1758C = dataGridView_0.Rows[BF07A102].Cells[F1A803B2].Value.ToString();
				});
			}
		}
		catch
		{
		}
		return CDA1758C;
	}

	public static void smethod_4(DataGridView C7062BA3, int F58B1122, int F1A7B932, object object_0)
	{
		try
		{
			try
			{
				C7062BA3.Invoke((MethodInvoker)delegate
				{
					C7062BA3.Rows[F58B1122].Cells[F1A7B932].Value = object_0;
				});
			}
			catch
			{
				C7062BA3.Rows[F58B1122].Cells[F1A7B932].Value = object_0;
			}
		}
		catch
		{
		}
	}

	public static void smethod_5(DataGridView B4333A20, int C43E40A8, string string_0, object BB1C838D)
	{
		try
		{
			if (Class81.bool_0 && string_0 == "cStatus")
			{
				string string_ = smethod_3(B4333A20, C43E40A8, "cId");
				Class81.smethod_0(string_, BB1C838D.ToString());
			}
			try
			{
				B4333A20.Invoke((MethodInvoker)delegate
				{
					B4333A20.Rows[C43E40A8].Cells[string_0].Value = BB1C838D;
				});
			}
			catch
			{
				B4333A20.Rows[C43E40A8].Cells[string_0].Value = BB1C838D;
			}
		}
		catch
		{
		}
	}

	public static void CB1F923E(DataGridView dataGridView_0, DataTable dataTable_0, bool FC226794 = false)
	{
		if (FC226794)
		{
			for (int i = 0; i < dataTable_0.Rows.Count; i++)
			{
				DataRow dataRow = dataTable_0.Rows[i];
				dataGridView_0.Rows.Add(false, dataGridView_0.RowCount + 1, dataRow["id"], dataRow["uid"], dataRow["token"], dataRow["cookie1"], dataRow["email"], dataRow["phone"], dataRow["name"], dataRow["follow"], dataRow["friends"], dataRow["groups"], dataRow["pages"], dataRow["pagePro5"], dataRow["birthday"], dataRow["gender"], dataRow["pass"], dataRow["mailrecovery"], dataRow["passmail"], dataRow["backup"], dataRow["fa2"], dataRow["useragent"], dataRow["proxy"], dataRow["dateCreateAcc"], dataRow["avatar"], dataRow["profile"], dataRow["nameFile"], dataRow["interactEnd"], dataRow["info"], dataRow["ghiChu"], dataRow["location"], dataRow["hometown"], dataRow["currentCity"], dataRow["dating"], dataRow["ads"], dataRow["bm"], dataRow["wallPosts"], dataRow["fbBlock"], dataRow["job"], dataRow["dateDelete"], Class81.F7B1DA8C(dataRow["id"].ToString()));
			}
			return;
		}
		for (int j = 0; j < dataTable_0.Rows.Count; j++)
		{
			DataRow dataRow2 = dataTable_0.Rows[j];
			dataGridView_0.Rows.Add(false, dataGridView_0.RowCount + 1, dataRow2["id"], dataRow2["uid"], dataRow2["pass"], dataRow2["fa2"], dataRow2["token"], dataRow2["cookie1"], dataRow2["email"], dataRow2["email2"], dataRow2["passmail"], dataRow2["mailrecovery"], dataRow2["passmailrecovery"], dataRow2["phone"], dataRow2["name"], dataRow2["follow"], dataRow2["friends"], dataRow2["groups"], dataRow2["pages"], dataRow2["pagePro5"], dataRow2["birthday"], dataRow2["gender"], dataRow2["backup"], dataRow2["useragent"], dataRow2["proxy"], dataRow2["dateCreateAcc"], dataRow2["avatar"], dataRow2["profile"], dataRow2["nameFile"], dataRow2["interactEnd"], dataRow2["info"], dataRow2["ghiChu"], dataRow2["status282"], dataRow2["location"], dataRow2["hometown"], dataRow2["currentCity"], dataRow2["dating"], dataRow2["ads"], dataRow2["bm"], dataRow2["wallPosts"], dataRow2["fbBlock"], dataRow2["job"], dataRow2["kichban"], Class81.F7B1DA8C(dataRow2["id"].ToString()));
		}
	}

	internal static void D6A30D83(DataGridViewSortCompareEventArgs dataGridViewSortCompareEventArgs_0)
	{
		try
		{
			List<string> list = new List<string> { "cStt", "cFriend", "cGroup", "cFollow", "cPage", "cPagePro5", "cBM" };
			string text = dataGridViewSortCompareEventArgs_0.CellValue1.ToString().Trim();
			string text2 = dataGridViewSortCompareEventArgs_0.CellValue2.ToString().Trim();
			if (text == "" || text2 == "")
			{
				dataGridViewSortCompareEventArgs_0.SortResult = text.CompareTo(text2);
				dataGridViewSortCompareEventArgs_0.Handled = true;
				return;
			}
			if (list.Contains(dataGridViewSortCompareEventArgs_0.Column.Name))
			{
				if (!GClass8.smethod_44(text))
				{
					text = ((text != "") ? "-1" : "-2");
				}
				if (!GClass8.smethod_44(text2))
				{
					text2 = ((text2 != "") ? "-1" : "-2");
				}
				dataGridViewSortCompareEventArgs_0.SortResult = int.Parse(text).CompareTo(int.Parse(text2));
			}
			else if (dataGridViewSortCompareEventArgs_0.Column.Name == "cWallPosts")
			{
				dataGridViewSortCompareEventArgs_0.SortResult = int.Parse(text.Replace("+", "")).CompareTo(int.Parse(text2.Replace("+", "")));
			}
			else if (dataGridViewSortCompareEventArgs_0.Column.Name == "cInteractEnd")
			{
				dataGridViewSortCompareEventArgs_0.SortResult = GClass8.smethod_65(text).CompareTo(GClass8.smethod_65(text2));
			}
			else if (dataGridViewSortCompareEventArgs_0.Column.Name == "cDateDelete")
			{
				dataGridViewSortCompareEventArgs_0.SortResult = GClass8.smethod_65(text, "HH:mm:ss dd/MM/yyyy").CompareTo(GClass8.smethod_65(text2, "HH:mm:ss dd/MM/yyyy"));
			}
			else if (dataGridViewSortCompareEventArgs_0.Column.Name == "cJob")
			{
				string[] array = dataGridViewSortCompareEventArgs_0.CellValue1.ToString().Split(' ');
				string[] array2 = dataGridViewSortCompareEventArgs_0.CellValue2.ToString().Split(' ');
				string text3 = array[0].Trim().Substring(1, 10);
				string text4 = array2[0].Trim().Substring(1, 10);
				int num = int.Parse(array[1].Trim());
				int value = int.Parse(array2[1].Trim());
				if (text3 == text4)
				{
					dataGridViewSortCompareEventArgs_0.SortResult = num.CompareTo(value);
				}
				else
				{
					DateTime dateTime = DateTime.ParseExact(text3, "dd/MM/yyyy", CultureInfo.InvariantCulture);
					DateTime value2 = DateTime.ParseExact(text4, "dd/MM/yyyy", CultureInfo.InvariantCulture);
					dataGridViewSortCompareEventArgs_0.SortResult = dateTime.CompareTo(value2);
				}
			}
			else if (dataGridViewSortCompareEventArgs_0.Column.Name == "cStatus282")
			{
				string[] array3 = dataGridViewSortCompareEventArgs_0.CellValue1.ToString().Split('-');
				string[] array4 = dataGridViewSortCompareEventArgs_0.CellValue2.ToString().Split('-');
				string text5 = array3[0].Trim();
				string text6 = array4[0].Trim();
				if (text5 == text6)
				{
					int num2 = 0;
					int num3 = 0;
					if (array3.Count() > 2)
					{
						num2 = int.Parse(array3[2].Trim().Split(' ')[0]);
					}
					if (array4.Count() > 2)
					{
						num3 = int.Parse(array4[2].Trim().Split(' ')[0]);
					}
					if (num2 != num3)
					{
						dataGridViewSortCompareEventArgs_0.SortResult = num2.CompareTo(num3);
					}
					else
					{
						string s = array3[1].Trim();
						string s2 = array4[1].Trim();
						DateTime dateTime2 = DateTime.ParseExact(s, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
						DateTime value3 = DateTime.ParseExact(s2, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
						dataGridViewSortCompareEventArgs_0.SortResult = dateTime2.CompareTo(value3);
					}
				}
				else
				{
					dataGridViewSortCompareEventArgs_0.SortResult = text5.CompareTo(text6);
				}
			}
			else if (dataGridViewSortCompareEventArgs_0.Column.Name == "cStatus")
			{
				string text7 = text;
				string strB = text2;
				if (text.StartsWith("("))
				{
					text7 = text.Substring(text.IndexOf(")") + 1).Trim();
				}
				if (text2.StartsWith("("))
				{
					strB = text2.Substring(text2.IndexOf(")") + 1).Trim();
				}
				dataGridViewSortCompareEventArgs_0.SortResult = text7.CompareTo(strB);
			}
			else if (dataGridViewSortCompareEventArgs_0.Column.Name == "cBirthday")
			{
				dataGridViewSortCompareEventArgs_0.SortResult = GClass8.smethod_65(text, "M/d/yyyy").CompareTo(GClass8.smethod_65(text2, "M/d/yyyy"));
			}
			else if (dataGridViewSortCompareEventArgs_0.Column.Name == "cDateCreateAcc")
			{
				text = Regex.Match(text, "2\\d{3}").Value;
				text2 = Regex.Match(text2, "2\\d{3}").Value;
				if (!GClass8.smethod_44(text))
				{
					text = ((text != "") ? "-1" : "-2");
				}
				if (!GClass8.smethod_44(text2))
				{
					text2 = ((text2 != "") ? "-1" : "-2");
				}
				dataGridViewSortCompareEventArgs_0.SortResult = int.Parse(text).CompareTo(int.Parse(text2));
			}
			else if (!(dataGridViewSortCompareEventArgs_0.Column.Name == "cEmail") && !(dataGridViewSortCompareEventArgs_0.Column.Name == "cMailRecovery"))
			{
				dataGridViewSortCompareEventArgs_0.SortResult = text.CompareTo(text2);
			}
			else
			{
				string text8 = "";
				string strB2 = "";
				if (text.Contains("@"))
				{
					text8 = text.Split('@')[1];
				}
				if (text2.Contains("@"))
				{
					strB2 = text2.Split('@')[1];
				}
				dataGridViewSortCompareEventArgs_0.SortResult = text8.CompareTo(strB2);
			}
		}
		catch (Exception)
		{
			dataGridViewSortCompareEventArgs_0.SortResult = 0;
		}
		dataGridViewSortCompareEventArgs_0.Handled = true;
	}
}
