using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

public class AABDF09D
{
	[CompilerGenerated]
	private sealed class Class4
	{
		public AABDF09D aabdf09D_0;

		public int CB9DBA91;

		internal void method_0()
		{
			try
			{
				while (Environment.TickCount - aabdf09D_0.Int32_0 < CB9DBA91 * 1000 && aabdf09D_0.Thread_0.IsAlive)
				{
					Thread.Sleep(1000);
				}
				aabdf09D_0.Thread_0.Abort();
				while (aabdf09D_0.Thread_0.IsAlive)
				{
					Thread.Sleep(1000);
				}
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal Thread C82FFA90;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int F81FF7BE;

	private Thread Thread_0
	{
		[CompilerGenerated]
		get
		{
			return C82FFA90;
		}
		[CompilerGenerated]
		set
		{
			C82FFA90 = value;
		}
	}

	private int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return F81FF7BE;
		}
		[CompilerGenerated]
		set
		{
			F81FF7BE = value;
		}
	}

	public AABDF09D(Thread E3ADC3AD, int int_0 = 0)
	{
		AABDF09D aabdf09D_0 = this;
		Thread_0 = E3ADC3AD;
		Int32_0 = Environment.TickCount;
		if (int_0 <= 0)
		{
			return;
		}
		new Thread((ThreadStart)delegate
		{
			try
			{
				while (Environment.TickCount - aabdf09D_0.Int32_0 < int_0 * 1000 && aabdf09D_0.Thread_0.IsAlive)
				{
					Thread.Sleep(1000);
				}
				aabdf09D_0.Thread_0.Abort();
				while (aabdf09D_0.Thread_0.IsAlive)
				{
					Thread.Sleep(1000);
				}
			}
			catch (Exception)
			{
			}
		}).Start();
	}

	public string method_0()
	{
		return GClass8.smethod_24((Environment.TickCount - Int32_0) / 1000);
	}
}
