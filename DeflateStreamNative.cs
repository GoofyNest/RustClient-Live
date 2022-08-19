internal class DeflateStreamNative // TypeDefIndex: 2865
{	// Fields
	private DeflateStreamNative.UnmanagedReadOrWrite feeder; // 0x10
	private Stream base_stream; // 0x18
	private DeflateStreamNative.SafeDeflateStreamHandle z_stream; // 0x20
	private GCHandle data; // 0x28
	private bool disposed; // 0x2C
	private byte[] io_buffer; // 0x30

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	private void .ctor() { }

	// RVA: 0x1558AE0 Offset: 0x1557EE0 VA: 0x181558AE0
	public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip) { }

	// RVA: 0x1558D50 Offset: 0x1558150 VA: 0x181558D50 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1558CA0 Offset: 0x15580A0 VA: 0x181558CA0
	public void Dispose(bool disposing) { }

	// RVA: 0x1558E10 Offset: 0x1558210 VA: 0x181558E10
	public void Flush() { }

	// RVA: 0x1558FA0 Offset: 0x15583A0 VA: 0x181558FA0
	public int ReadZStream(IntPtr buffer, int length) { }

	// RVA: 0x1559660 Offset: 0x1558A60 VA: 0x181559660
	public void WriteZStream(IntPtr buffer, int length) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0xB2F70 Offset: 0xB2370 VA: 0x1800B2F70
	// RVA: 0x1559180 Offset: 0x1558580 VA: 0x181559180
	private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x1559050 Offset: 0x1558450 VA: 0x181559050
	private int UnmanagedRead(IntPtr buffer, int length) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0xB3090 Offset: 0xB2490 VA: 0x1800B3090
	// RVA: 0x1559480 Offset: 0x1558880 VA: 0x181559480
	private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x1559330 Offset: 0x1558730 VA: 0x181559330
	private int UnmanagedWrite(IntPtr buffer, int length) { }

	// RVA: 0x1558900 Offset: 0x1557D00 VA: 0x181558900
	private static void CheckResult(int result, string where) { }

	// RVA: 0x1558A30 Offset: 0x1557E30 VA: 0x181558A30
	private static extern DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, DeflateStreamNative.UnmanagedReadOrWrite feeder, IntPtr data) { }

	// RVA: 0x1558A20 Offset: 0x1557E20 VA: 0x181558A20
	private static extern int CloseZStream(IntPtr stream) { }

	// RVA: 0x1558EB0 Offset: 0x15582B0 VA: 0x181558EB0
	private static extern int Flush(DeflateStreamNative.SafeDeflateStreamHandle stream) { }

	// RVA: 0x1558F20 Offset: 0x1558320 VA: 0x181558F20
	private static extern int ReadZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

	// RVA: 0x1559710 Offset: 0x1558B10 VA: 0x181559710
	private static extern int WriteZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

}

private sealed class DeflateStreamNative.UnmanagedReadOrWrite : MulticastDelegate // TypeDefIndex: 2866
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15645D0 Offset: 0x15639D0 VA: 0x1815645D0 Slot: 12
	public virtual int Invoke(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x1564530 Offset: 0x1563930 VA: 0x181564530 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr buffer, int length, IntPtr data, AsyncCallback callback, object object) { }

	// RVA: 0xB95EA0 Offset: 0xB952A0 VA: 0x180B95EA0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

private sealed class DeflateStreamNative.SafeDeflateStreamHandle : SafeHandle // TypeDefIndex: 2867
{	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x1563DD0 Offset: 0x15631D0 VA: 0x181563DD0 Slot: 5
	public override bool get_IsInvalid() { }

	// RVA: 0x1563D90 Offset: 0x1563190 VA: 0x181563D90
	private void .ctor() { }

	// RVA: 0x1563D70 Offset: 0x1563170 VA: 0x181563D70 Slot: 7
	protected override bool ReleaseHandle() { }

}

