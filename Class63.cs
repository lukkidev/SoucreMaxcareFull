using System.Runtime.InteropServices;

internal class Class63
{
	[DllImport("wininet.dll")]
	private static extern bool InternetGetConnectedState(out int int_0, int F8A90A96);

	public static bool smethod_0()
	{
		int int_;
		return InternetGetConnectedState(out int_, 0);
	}
}
