using System;
using System.Runtime.InteropServices;

internal class F03E54BC
{
	public const int CE92BA89 = 13369376;

	[DllImport("gdi32.dll")]
	public static extern bool BitBlt(IntPtr CA15CAB6, int int_0, int int_1, int int_2, int int_3, IntPtr F230100C, int int_4, int B427B739, int int_5);

	[DllImport("gdi32.dll")]
	public static extern IntPtr CreateCompatibleBitmap(IntPtr intptr_0, int int_0, int int_1);

	[DllImport("gdi32.dll")]
	public static extern IntPtr CreateCompatibleDC(IntPtr FE8C8F14);

	[DllImport("gdi32.dll")]
	public static extern bool DeleteDC(IntPtr intptr_0);

	[DllImport("gdi32.dll")]
	public static extern bool DeleteObject(IntPtr B52B9A1A);

	[DllImport("gdi32.dll")]
	public static extern IntPtr SelectObject(IntPtr F0BA8AB9, IntPtr intptr_0);
}
