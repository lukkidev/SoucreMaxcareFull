using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public static class GClass23
{
	[Serializable]
	[CompilerGenerated]
	private sealed class AA88CA12
	{
		public static readonly AA88CA12 _003C_003E9 = new AA88CA12();

		public static Func<KeyValuePair<string, List<string>>, string> _003C_003E9__10_0;

		public static Func<KeyValuePair<string, List<string>>, List<string>> _003C_003E9__10_1;

		public static Func<string, bool> _003C_003E9__12_0;

		internal string method_0(KeyValuePair<string, List<string>> D780333C)
		{
			return D780333C.Key;
		}

		internal List<string> method_1(KeyValuePair<string, List<string>> keyValuePair_0)
		{
			return new List<string>(keyValuePair_0.Value);
		}

		internal bool method_2(string B91F1291)
		{
			return !string.IsNullOrWhiteSpace(B91F1291);
		}
	}

	[CompilerGenerated]
	private sealed class Class79
	{
		public Control B5ACD21B;

		public bool EC28E29C;

		internal void D021B52B()
		{
			B5ACD21B.Enabled = EC28E29C;
		}
	}

	[CompilerGenerated]
	private sealed class F515A827
	{
		public Control F092D22C;

		public string string_0;

		internal void EE0177B8()
		{
			F092D22C.Text = string_0;
		}
	}

	[CompilerGenerated]
	private sealed class Class80
	{
		public RichTextBox DD9E580A;

		internal void method_0(object sender, EventArgs e)
		{
			DD9E580A.SelectAll();
		}

		internal void EF88D39C(object sender, EventArgs e)
		{
			DD9E580A.Copy();
		}

		internal void C7A41732(object sender, EventArgs e)
		{
			DD9E580A.Cut();
		}

		internal void method_1(object sender, EventArgs e)
		{
			DD9E580A.Paste();
		}
	}

	public static Bitmap D0336384(this string string_0)
	{
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			MemoryStream memoryStream = new MemoryStream(array, 0, array.Length);
			memoryStream.Write(array, 0, array.Length);
			Image original = Image.FromStream(memoryStream, useEmbeddedColorManagement: true);
			return new Bitmap(original);
		}
		catch
		{
		}
		return null;
	}

	public static void C22B543F(this Control control_0, bool bool_0 = true)
	{
		try
		{
			control_0.Invoke((MethodInvoker)delegate
			{
				control_0.Enabled = bool_0;
			});
		}
		catch
		{
		}
	}

	public static void smethod_0(this Control control_0, string D73D18AC)
	{
		try
		{
			control_0.Invoke((MethodInvoker)delegate
			{
				control_0.Text = D73D18AC;
			});
		}
		catch
		{
		}
	}

	public static string E0050019(this string string_0)
	{
		return WebUtility.UrlEncode(string_0);
	}

	public static string smethod_1(this string string_0)
	{
		return WebUtility.HtmlDecode(string_0);
	}

	public static void A294D626(this Form form_0)
	{
		if (form_0.WindowState == FormWindowState.Maximized)
		{
			form_0.WindowState = FormWindowState.Normal;
			return;
		}
		Rectangle workingArea = Screen.FromHandle(form_0.Handle).WorkingArea;
		workingArea.Location = new Point(0, 0);
		form_0.MaximumSize = workingArea.Size;
		form_0.WindowState = FormWindowState.Maximized;
	}

	public static void smethod_2(this Control D3163933, string string_0 = "Search...")
	{
		D3163933.Tag = string_0;
		if (D3163933.Text == "" || D3163933.Text == string_0)
		{
			D3163933.Text = string_0;
			D3163933.ForeColor = Color.Gray;
		}
		D3163933.Leave += smethod_4;
		D3163933.Enter += smethod_3;
	}

	private static void smethod_3(object sender, EventArgs e)
	{
		Control control = sender as Control;
		if (control.Text == control.Tag.ToString())
		{
			control.Text = "";
			control.ForeColor = Color.Black;
		}
	}

	private static void smethod_4(object sender, EventArgs e)
	{
		Control control = sender as Control;
		if (control.Text == "")
		{
			control.Text = control.Tag.ToString();
			control.ForeColor = Color.Gray;
		}
	}

	public static void ECAFEDB6(this RichTextBox richTextBox_0)
	{
		ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
		ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem("Select All");
		ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem("Copy");
		ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem("Cut");
		ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem("Paste");
		toolStripMenuItem.Click += delegate
		{
			richTextBox_0.SelectAll();
		};
		toolStripMenuItem2.Click += delegate
		{
			richTextBox_0.Copy();
		};
		toolStripMenuItem3.Click += delegate
		{
			richTextBox_0.Cut();
		};
		toolStripMenuItem4.Click += delegate
		{
			richTextBox_0.Paste();
		};
		contextMenuStrip.Items.Add(toolStripMenuItem);
		contextMenuStrip.Items.Add(toolStripMenuItem2);
		contextMenuStrip.Items.Add(toolStripMenuItem3);
		contextMenuStrip.Items.Add(toolStripMenuItem4);
		richTextBox_0.ContextMenuStrip = contextMenuStrip;
	}

	public static Dictionary<string, List<string>> smethod_5(this Dictionary<string, List<string>> dictionary_0)
	{
		return dictionary_0.ToDictionary((KeyValuePair<string, List<string>> D780333C) => D780333C.Key, (KeyValuePair<string, List<string>> keyValuePair_0) => new List<string>(keyValuePair_0.Value));
	}

	public static List<string> smethod_6(this RichTextBox richTextBox_0)
	{
		return richTextBox_0.Text.Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
	}

	public static List<string> smethod_7(this List<string> list_0)
	{
		return list_0.Where((string B91F1291) => !string.IsNullOrWhiteSpace(B91F1291)).ToList();
	}
}
