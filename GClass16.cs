using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public static class GClass16
{
	private static Dictionary<Control, bool> dictionary_0 = new Dictionary<Control, bool>();

	private static Size CC88F825;

	public static void smethod_0(this Control control_0, bool bool_0)
	{
		if (bool_0)
		{
			if (!dictionary_0.ContainsKey(control_0))
			{
				dictionary_0.Add(control_0, value: false);
				control_0.MouseDown += smethod_1;
				control_0.MouseMove += smethod_2;
			}
		}
		else if (dictionary_0.ContainsKey(control_0))
		{
			control_0.MouseDown -= smethod_1;
			control_0.MouseMove -= smethod_2;
			dictionary_0.Remove(control_0);
		}
	}

	private static void smethod_1(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			CC88F825 = new Size(e.Location);
			dictionary_0[(Control)sender] = true;
			(sender as Control).BringToFront();
		}
	}

	private static void smethod_2(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left && dictionary_0[(Control)sender])
		{
			Point point = e.Location - CC88F825;
			((Control)sender).Left += point.X;
			((Control)sender).Top += point.Y;
		}
	}
}
