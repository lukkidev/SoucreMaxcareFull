using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class F7AB102E
{
	[Serializable]
	[CompilerGenerated]
	private sealed class B6839614
	{
		public static readonly B6839614 _003C_003E9 = new B6839614();

		public static Func<Control, IEnumerable<Control>> _003C_003E9__4_0;

		internal IEnumerable<Control> CB220E93(Control control_0)
		{
			return BD966827(control_0);
		}
	}

	public static string smethod_0(string C42F3F0E)
	{
		string text = "";
		if (Class57.smethod_2() == "VN")
		{
			return C42F3F0E;
		}
		if (C42F3F0E == "")
		{
			return C42F3F0E;
		}
		text = B8969228(C42F3F0E);
		if (text == "")
		{
			text = C42F3F0E;
		}
		return text;
	}

	public static void smethod_1(Control D330E3B0, string string_0 = "VN")
	{
		if (D330E3B0.Text.ToLower().Contains("(ẩn)"))
		{
			if (Class57.bool_0)
			{
				D330E3B0.Text = D330E3B0.Text.Replace("(ẩn)", "");
			}
			else
			{
				D330E3B0.Visible = false;
			}
		}
		D330E3B0.Text = smethod_0(D330E3B0.Text);
	}

	public static void smethod_2(ToolStripItem EF32CA8D, string DC07691C = "VN")
	{
		if (EF32CA8D.Text.ToLower().Contains("(ẩn)"))
		{
			if (Class57.bool_0)
			{
				EF32CA8D.Text = EF32CA8D.Text.Replace("(ẩn)", "");
			}
			else
			{
				EF32CA8D.Visible = false;
			}
		}
		EF32CA8D.Text = smethod_0(EF32CA8D.Text);
	}

	public static void smethod_3(DataGridViewColumn F70F1997, string string_0 = "VN")
	{
		F70F1997.HeaderText = smethod_0(F70F1997.HeaderText);
	}

	public static IEnumerable<Control> BD966827(Control control_0)
	{
		IEnumerable<Control> enumerable = control_0.Controls.Cast<Control>();
		return enumerable.SelectMany((Control control_0) => BD966827(control_0)).Concat(enumerable);
	}

	public static void D6B70A35(Control C5B46BBB)
	{
		IEnumerable<Control> enumerable = BD966827(C5B46BBB);
		foreach (Control item in enumerable)
		{
			if (item is DataGridView)
			{
				foreach (DataGridViewColumn column in (item as DataGridView).Columns)
				{
					smethod_3(column);
				}
			}
			else if (item is MenuStrip)
			{
				foreach (ToolStripMenuItem item2 in (item as MenuStrip).Items)
				{
					smethod_2(item2);
					if (item2.HasDropDownItems)
					{
						CABB5527(item2);
					}
				}
			}
			else if (item is StatusStrip)
			{
				foreach (ToolStripItem item3 in (item as StatusStrip).Items)
				{
					smethod_2(item3);
				}
			}
			else if (item is RichTextBox)
			{
				(item as RichTextBox).ECAFEDB6();
				smethod_1(item);
			}
			else
			{
				smethod_1(item);
			}
		}
	}

	public static void smethod_4(ContextMenuStrip CFB4CC02)
	{
		foreach (ToolStripMenuItem item in CFB4CC02.Items)
		{
			smethod_2(item);
			if (item.HasDropDownItems)
			{
				CABB5527(item);
			}
		}
	}

	public static void CABB5527(ToolStripMenuItem toolStripMenuItem_0)
	{
		foreach (ToolStripMenuItem dropDownItem in toolStripMenuItem_0.DropDownItems)
		{
			smethod_2(dropDownItem);
			if (dropDownItem.HasDropDownItems)
			{
				CABB5527(dropDownItem);
			}
		}
	}

	public static void B53A59B1()
	{
		GClass11 gClass = new GClass11("configLanguage");
		Dictionary<string, object> dictionary = gClass.method_0();
		GClass11 gClass2 = new GClass11("configLanguage_VN");
		foreach (KeyValuePair<string, object> item in dictionary)
		{
			gClass2.method_4(item.Value.ToString(), item.Key);
		}
		gClass2.method_6();
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetLanguage(byte[] B3992F1B);

	public static string B8969228(string string_0)
	{
		byte[] b3992F1B = GClass8.smethod_11(string_0);
		return GClass8.smethod_10(GetLanguage(b3992F1B));
	}
}
