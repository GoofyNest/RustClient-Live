internal class CFObject : IDisposable // TypeDefIndex: 2513
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IntPtr <Handle>k__BackingField; // 0x10

	// Properties
	public IntPtr Handle { get; set; }

	// Methods

	// RVA: 0x120D4A0 Offset: 0x120C8A0 VA: 0x18120D4A0
	public static extern IntPtr dlopen(string path, int mode) { }

	// RVA: 0x120D540 Offset: 0x120C940 VA: 0x18120D540
	private static extern IntPtr dlsym(IntPtr handle, string symbol) { }

	// RVA: 0x120D420 Offset: 0x120C820 VA: 0x18120D420
	public static extern void dlclose(IntPtr handle) { }

	// RVA: 0x120D260 Offset: 0x120C660 VA: 0x18120D260
	public static IntPtr GetIndirect(IntPtr handle, string symbol) { }

	// RVA: 0x120D1D0 Offset: 0x120C5D0 VA: 0x18120D1D0
	public static IntPtr GetCFObjectHandle(IntPtr handle, string symbol) { }

	// RVA: 0x120D370 Offset: 0x120C770 VA: 0x18120D370
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0xD782B0 Offset: 0xD776B0 VA: 0x180D782B0 Slot: 1
	protected override void Finalize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 5
	public IntPtr get_Handle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B1160 Offset: 0x8B0560 VA: 0x1808B1160
	private void set_Handle(IntPtr value) { }

	// RVA: 0x120D020 Offset: 0x120C420 VA: 0x18120D020
	internal static extern IntPtr CFRetain(IntPtr handle) { }

	// RVA: 0x120D2F0 Offset: 0x120C6F0 VA: 0x18120D2F0
	private void Retain() { }

	// RVA: 0x120CFA0 Offset: 0x120C3A0 VA: 0x18120CFA0
	internal static extern void CFRelease(IntPtr handle) { }

	// RVA: 0x120D270 Offset: 0x120C670 VA: 0x18120D270
	private void Release() { }

	// RVA: 0x120D110 Offset: 0x120C510 VA: 0x18120D110 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x120D0A0 Offset: 0x120C4A0 VA: 0x18120D0A0 Slot: 4
	public void Dispose() { }

}

