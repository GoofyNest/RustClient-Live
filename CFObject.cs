internal class CFObject : IDisposable // TypeDefIndex: 2513
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IntPtr <Handle>k__BackingField; // 0x10

	public IntPtr Handle { get; set; }


	public static extern IntPtr dlopen(string path, int mode) { }

	private static extern IntPtr dlsym(IntPtr handle, string symbol) { }

	public static extern void dlclose(IntPtr handle) { }

	public static IntPtr GetIndirect(IntPtr handle, string symbol) { }

	public static IntPtr GetCFObjectHandle(IntPtr handle, string symbol) { }

	public void .ctor(IntPtr handle, bool own) { }

	protected override void Finalize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public IntPtr get_Handle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Handle(IntPtr value) { }

	internal static extern IntPtr CFRetain(IntPtr handle) { }

	private void Retain() { }

	internal static extern void CFRelease(IntPtr handle) { }

	private void Release() { }

	protected virtual void Dispose(bool disposing) { }

	public void Dispose() { }

}

