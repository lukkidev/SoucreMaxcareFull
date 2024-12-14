using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GClass15 : Button
{
	public int AA82AA3D = 30;

	public GClass15()
	{
		BackColor = Color.OrangeRed;
		base.FlatStyle = FlatStyle.Flat;
		base.FlatAppearance.BorderColor = Color.Black;
		base.FlatAppearance.BorderSize = 1;
		base.Width = 140;
		base.Height = 45;
	}

	private GraphicsPath method_0(RectangleF F63D4028, int int_0)
	{
		float num = (float)int_0 / 2f;
		GraphicsPath graphicsPath = new GraphicsPath();
		graphicsPath.AddArc(F63D4028.X, F63D4028.Y, int_0, int_0, 180f, 90f);
		graphicsPath.AddLine(F63D4028.X + num, F63D4028.Y, F63D4028.Width - num, F63D4028.Y);
		graphicsPath.AddArc(F63D4028.X + F63D4028.Width - (float)int_0, F63D4028.Y, int_0, int_0, 270f, 90f);
		graphicsPath.AddLine(F63D4028.Width, F63D4028.Y + num, F63D4028.Width, F63D4028.Height - num);
		graphicsPath.AddArc(F63D4028.X + F63D4028.Width - (float)int_0, F63D4028.Y + F63D4028.Height - (float)int_0, int_0, int_0, 0f, 90f);
		graphicsPath.AddLine(F63D4028.Width - num, F63D4028.Height, F63D4028.X + num, F63D4028.Height);
		graphicsPath.AddArc(F63D4028.X, F63D4028.Y + F63D4028.Height - (float)int_0, int_0, int_0, 90f, 90f);
		graphicsPath.AddLine(F63D4028.X, F63D4028.Height - num, F63D4028.X, F63D4028.Y + num);
		graphicsPath.CloseFigure();
		return graphicsPath;
	}

	protected override void OnPaint(PaintEventArgs C139A63F)
	{
		base.OnPaint(C139A63F);
		RectangleF f63D = new RectangleF(0f, 0f, base.Width, base.Height);
		using GraphicsPath path = method_0(f63D, AA82AA3D);
		base.Region = new Region(path);
		using Pen pen = new Pen(Color.CadetBlue, 1.75f);
		pen.Alignment = PenAlignment.Inset;
		C139A63F.Graphics.DrawPath(pen, path);
	}
}
