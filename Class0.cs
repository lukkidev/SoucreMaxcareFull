using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
[DebuggerDisplay("\\{ <>h__TransparentIdentifier0 = {<>h__TransparentIdentifier0}, value = {value} }", Type = "<Anonymous Type>")]
internal sealed class Class0<B235382C, DBBF2CA6>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly B235382C gparam_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly DBBF2CA6 FB07B29A;

	public B235382C BA238E0F => gparam_0;

	public DBBF2CA6 Prop_0 => FB07B29A;

	[DebuggerHidden]
	public Class0(B235382C gparam_1, DBBF2CA6 gparam_2)
	{
		gparam_0 = gparam_1;
		FB07B29A = gparam_2;
	}

	[DebuggerHidden]
	public override bool Equals(object B8950028)
	{
		Class0<B235382C, DBBF2CA6> @class = B8950028 as Class0<B235382C, DBBF2CA6>;
		return this == @class || (@class != null && EqualityComparer<B235382C>.Default.Equals(gparam_0, @class.gparam_0) && EqualityComparer<DBBF2CA6>.Default.Equals(FB07B29A, @class.FB07B29A));
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (1251718248 + EqualityComparer<B235382C>.Default.GetHashCode(gparam_0)) * -1521134295 + EqualityComparer<DBBF2CA6>.Default.GetHashCode(FB07B29A);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[2];
		B235382C val = gparam_0;
		array[0] = ((val != null) ? val.ToString() : null);
		DBBF2CA6 fB07B29A = FB07B29A;
		array[1] = ((fB07B29A != null) ? fB07B29A.ToString() : null);
		return string.Format(null, "{{ <>h__TransparentIdentifier0 = {0}, value = {1} }}", array);
	}
}
