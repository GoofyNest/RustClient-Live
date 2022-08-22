internal class DeflateStreamNative // TypeDefIndex: 2865
{	private DeflateStreamNative.UnmanagedReadOrWrite feeder; // 0x10
	private Stream base_stream; // 0x18
	private DeflateStreamNative.SafeDeflateStreamHandle z_stream; // 0x20
	private GCHandle data; // 0x28
	private bool disposed; // 0x2C
	private byte[] io_buffer; // 0x30


	private void .ctor() { }

	public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip) { }

	protected override void Finalize() { }

	public void Dispose(bool disposing) { }

	public void Flush() { }

	public int ReadZStream(IntPtr buffer, int length) { }

	public void WriteZStream(IntPtr buffer, int length) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0xB2F70 Offset: 0xB2370 VA: 0x1800B2F70
	private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data) { }

	private int UnmanagedRead(IntPtr buffer, int length) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0xB3090 Offset: 0xB2490 VA: 0x1800B3090
	private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data) { }

	private int UnmanagedWrite(IntPtr buffer, int length) { }

	private static void CheckResult(int result, string where) { }

	private static extern DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, DeflateStreamNative.UnmanagedReadOrWrite feeder, IntPtr data) { }

	private static extern int CloseZStream(IntPtr stream) { }

	private static extern int Flush(DeflateStreamNative.SafeDeflateStreamHandle stream) { }

	private static extern int ReadZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

	private static extern int WriteZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

}

private sealed class DeflateStreamNative.UnmanagedReadOrWrite : MulticastDelegate // TypeDefIndex: 2866
{
	public void .ctor(object object, IntPtr method) { }

	public virtual int Invoke(IntPtr buffer, int length, IntPtr data) { }

	public virtual IAsyncResult BeginInvoke(IntPtr buffer, int length, IntPtr data, AsyncCallback callback, object object) { }

	public virtual int EndInvoke(IAsyncResult result) { }

}

private sealed class DeflateStreamNative.SafeDeflateStreamHandle : SafeHandle // TypeDefIndex: 2867
{	public override bool IsInvalid { get; }


	public override bool get_IsInvalid() { }

	private void .ctor() { }

	protected override bool ReleaseHandle() { }

}

