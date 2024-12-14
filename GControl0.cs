using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GControl0 : UserControl
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_0 = "";

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_1 = "Nha\u0303n";

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object B8848C05;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string DAB573BC = "";

	private IContainer icontainer_0 = null;

	private string String_0
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	private string String_1
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	private object Object_0
	{
		[CompilerGenerated]
		get
		{
			return B8848C05;
		}
		[CompilerGenerated]
		set
		{
			B8848C05 = value;
		}
	}

	private string D0B32536
	{
		[CompilerGenerated]
		get
		{
			return DAB573BC;
		}
		[CompilerGenerated]
		set
		{
			DAB573BC = value;
		}
	}

	public GControl0()
	{
		E0356636();
	}

	public virtual void vmethod_0(string E61EF5BE)
	{
		String_1 = E61EF5BE;
	}

	public virtual void E80DAA2A(string string_2)
	{
		String_0 = string_2;
	}

	public virtual void E71C8ABA(object D08A2AB1)
	{
		Object_0 = D08A2AB1;
	}

	public virtual void vmethod_1(object D33B5813)
	{
	}

	public void method_0(string string_2)
	{
		D0B32536 = string_2;
	}

	public string method_1()
	{
		return String_1;
	}

	public string BB3F4406()
	{
		return String_0;
	}

	public object method_2()
	{
		if (Object_0 == null)
		{
			return "";
		}
		if (Object_0 is string)
		{
			return (string)Object_0;
		}
		if (Object_0 is bool)
		{
			return (bool)Object_0;
		}
		if (Object_0 is int)
		{
			return (int)Object_0;
		}
		return Object_0;
	}

	public virtual string vmethod_2()
	{
		return D0B32536;
	}

	public virtual string vmethod_3()
	{
		return "";
	}

	public virtual object vmethod_4()
	{
		return null;
	}

	public virtual string vmethod_5()
	{
		return "";
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void E0356636()
	{
		icontainer_0 = new Container();
		base.AutoScaleMode = AutoScaleMode.Font;
	}
}
