public sealed class PhotoCaptureFrame : IDisposable // TypeDefIndex: 3615
{	// Fields
	private IntPtr m_NativePtr; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private int <dataLength>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private bool <hasLocationData>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private CapturePixelFormat <pixelFormat>k__BackingField; // 0x20

	// Properties
	public int dataLength { get; set; }
	private bool hasLocationData { set; }
	private CapturePixelFormat pixelFormat { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public int get_dataLength() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8E20 Offset: 0x7E8220 VA: 0x1807E8E20
	private void set_dataLength(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8E40 Offset: 0x7E8240 VA: 0x1807E8E40
	private void set_hasLocationData(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x69CC40 Offset: 0x69C040 VA: 0x18069CC40
	private void set_pixelFormat(CapturePixelFormat value) { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21736C0 Offset: 0x2172AC0 VA: 0x1821736C0
	private int GetDataLength() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2173700 Offset: 0x2172B00 VA: 0x182173700
	private bool GetHasLocationData() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2173680 Offset: 0x2172A80 VA: 0x182173680
	private CapturePixelFormat GetCapturePixelFormat() { }

	// RVA: 0x2173740 Offset: 0x2172B40 VA: 0x182173740
	internal void .ctor(IntPtr nativePtr) { }

	// RVA: 0x21734B0 Offset: 0x21728B0 VA: 0x1821734B0
	private void Cleanup() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0xDBEE0 Offset: 0xDB2E0 VA: 0x1800DBEE0
	[NativeNameAttribute] // RVA: 0xDBEE0 Offset: 0xDB2E0 VA: 0x1800DBEE0
	[NativeConditionalAttribute] // RVA: 0xDBEE0 Offset: 0xDB2E0 VA: 0x1800DBEE0
	// RVA: 0x2173550 Offset: 0x2172950 VA: 0x182173550
	private void Dispose_Internal() { }

	// RVA: 0x2173590 Offset: 0x2172990 VA: 0x182173590 Slot: 4
	public void Dispose() { }

	// RVA: 0x21735F0 Offset: 0x21729F0 VA: 0x1821735F0 Slot: 1
	protected override void Finalize() { }

}

