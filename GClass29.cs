using System.Windows.Forms;

public class GClass29
{
	public static void smethod_0(object ED954904, int DD068134 = 1)
	{
		MessageBoxIcon icon = MessageBoxIcon.None;
		switch (DD068134)
		{
		case 1:
			icon = MessageBoxIcon.Asterisk;
			break;
		case 2:
			icon = MessageBoxIcon.Hand;
			break;
		case 3:
			icon = MessageBoxIcon.Exclamation;
			break;
		case 4:
			icon = MessageBoxIcon.Exclamation;
			break;
		}
		MessageBox.Show(F7AB102E.smethod_0(ED954904.ToString()), "MINSoftware", MessageBoxButtons.OK, icon);
	}

	public static DialogResult smethod_1(string string_0)
	{
		return MessageBox.Show(F7AB102E.smethod_0(string_0), "MINSoftware", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
	}
}
