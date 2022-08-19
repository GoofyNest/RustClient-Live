public class RemotingSurrogateSelector : ISurrogateSelector // TypeDefIndex: 1257
{	// Fields
	private static Type s_cachedTypeObjRef; // 0x0
	private static ObjRefSurrogate _objRefSurrogate; // 0x8
	private static RemotingSurrogate _objRemotingSurrogate; // 0x10
	private ISurrogateSelector _next; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1486980 Offset: 0x1485D80 VA: 0x181486980 Slot: 5
	public virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout) { }

	// RVA: 0x1486B80 Offset: 0x1485F80 VA: 0x181486B80
	private static void .cctor() { }

}

