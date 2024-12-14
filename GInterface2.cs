using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ComImport]
[Guid("41904400-BE18-11D3-A28B-00104BD35090")]
[TypeIdentifier]
[CompilerGenerated]
public interface GInterface2 : GInterface1
{
	void _VtblGap1_4();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1002)]
	[return: MarshalAs(UnmanagedType.IDispatch)]
	object imethod_0([In][MarshalAs(UnmanagedType.BStr)] string D4A46891);
}
