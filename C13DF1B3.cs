using System;
using System.Runtime.InteropServices;
using System.Windows;

public class C13DF1B3
{
	public const int int_0 = 3;

	public const int int_1 = 6;

	[DllImport("user32.dll", SetLastError = true)]
	public static extern long SetParent(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool MoveWindow(IntPtr D48D7124, int int_2, int ED24278F, int int_3, int int_4, bool A9365B38);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool SetForegroundWindow(IntPtr EB12FA92);

	[DllImport("user32.dll")]
	public static extern bool GetWindowRect(IntPtr intptr_0, ref Rect C0174C00);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ShowWindow(IntPtr intptr_0, int int_2);
}
