using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GClass14 : CheckBox
{
	private Color E5B48F21 = Color.MediumSlateBlue;

	private Color FE2889A7 = Color.WhiteSmoke;

	private Color color_0 = Color.Gray;

	private Color color_1 = Color.Gainsboro;

	private bool bool_0 = true;

	private IContainer E2B4F310 = null;

	public Color AC1798A0
	{
		get
		{
			return E5B48F21;
		}
		set
		{
			E5B48F21 = value;
			Invalidate();
		}
	}

	public Color FCB37134
	{
		get
		{
			return FE2889A7;
		}
		set
		{
			FE2889A7 = value;
			Invalidate();
		}
	}

	public Color Color_0
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			Invalidate();
		}
	}

	public Color Color_1
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
			Invalidate();
		}
	}

	[Browsable(false)]
	public override string Text
	{
		get
		{
			return base.Text;
		}
		set
		{
		}
	}

	[DefaultValue(true)]
	public bool C590748A
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			Invalidate();
		}
	}

	public GClass14()
	{
		MinimumSize = new Size(45, 22);
	}

	private GraphicsPath method_0()
	{
		int num = base.Height - 1;
		Rectangle rect = new Rectangle(0, 0, num, num);
		Rectangle rect2 = new Rectangle(base.Width - num - 2, 0, num, num);
		GraphicsPath graphicsPath = new GraphicsPath();
		graphicsPath.StartFigure();
		graphicsPath.AddArc(rect, 90f, 180f);
		graphicsPath.AddArc(rect2, 270f, 180f);
		graphicsPath.CloseFigure();
		return graphicsPath;
	}

	protected override void OnPaint(PaintEventArgs C139A63F)
	{
		int num = base.Height - 5;
		C139A63F.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		C139A63F.Graphics.Clear(base.Parent.BackColor);
		if (base.Checked)
		{
			if (bool_0)
			{
				C139A63F.Graphics.FillPath(new SolidBrush(E5B48F21), method_0());
			}
			else
			{
				C139A63F.Graphics.DrawPath(new Pen(E5B48F21, 2f), method_0());
			}
			C139A63F.Graphics.FillEllipse(new SolidBrush(FE2889A7), new Rectangle(base.Width - base.Height + 1, 2, num, num));
		}
		else
		{
			if (bool_0)
			{
				C139A63F.Graphics.FillPath(new SolidBrush(color_0), method_0());
			}
			else
			{
				C139A63F.Graphics.DrawPath(new Pen(color_0, 2f), method_0());
			}
			C139A63F.Graphics.FillEllipse(new SolidBrush(color_1), new Rectangle(2, 2, num, num));
		}
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && E2B4F310 != null)
		{
			E2B4F310.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void method_1()
	{
		E2B4F310 = new Container();
	}
}
