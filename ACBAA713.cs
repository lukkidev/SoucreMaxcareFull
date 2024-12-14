using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[CompilerGenerated]
[DebuggerDisplay("\\{ r = {r}, key = {key} }", Type = "<Anonymous Type>")]
internal sealed class ACBAA713<T, U>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly T C115368A;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly U gparam_0;

	public T EEAD6F95 => C115368A;

	public U C7296323 => gparam_0;

	[DebuggerHidden]
	public ACBAA713(T gparam_1, U gparam_2)
	{
		C115368A = gparam_1;
		gparam_0 = gparam_2;
	}

	[DebuggerHidden]
	public override bool Equals(object ACB3769F)
	{
		global::ACBAA713<T, U> aCBAA = ACB3769F as global::ACBAA713<T, U>;
		return this == aCBAA || (aCBAA != null && EqualityComparer<T>.Default.Equals(C115368A, aCBAA.C115368A) && EqualityComparer<U>.Default.Equals(gparam_0, aCBAA.gparam_0));
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (822916899 + EqualityComparer<T>.Default.GetHashCode(C115368A)) * -1521134295 + EqualityComparer<U>.Default.GetHashCode(gparam_0);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		object[] array = new object[2];
		T c115368A = C115368A;
		array[0] = ((c115368A != null) ? c115368A.ToString() : null);
		U val = gparam_0;
		array[1] = ((val != null) ? val.ToString() : null);
		return string.Format(null, "{{ r = {0}, key = {1} }}", array);
	}
}
