public class DeflateStream : Stream // TypeDefIndex: 2862
{	// Fields
	private Stream base_stream; // 0x28
	private CompressionMode mode; // 0x30
	private bool leaveOpen; // 0x34
	private bool disposed; // 0x35
	private DeflateStreamNative native; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1725B70 Offset: 0x1724F70 VA: 0x181725B70
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x1725B50 Offset: 0x1724F50 VA: 0x181725B50
	internal void .ctor(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) { }

	// RVA: 0x1725B90 Offset: 0x1724F90 VA: 0x181725B90
	internal void .ctor(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip) { }

	// RVA: 0x17251C0 Offset: 0x17245C0 VA: 0x1817251C0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x17255D0 Offset: 0x17249D0 VA: 0x1817255D0
	private int ReadInternal(byte[] array, int offset, int count) { }

	// RVA: 0x1725620 Offset: 0x1724A20 VA: 0x181725620 Slot: 27
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x17258E0 Offset: 0x1724CE0 VA: 0x1817258E0
	private void WriteInternal(byte[] array, int offset, int count) { }

	// RVA: 0x1725930 Offset: 0x1724D30 VA: 0x181725930 Slot: 29
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x1725510 Offset: 0x1724910 VA: 0x181725510 Slot: 18
	public override void Flush() { }

	// RVA: 0x1724D20 Offset: 0x1724120 VA: 0x181724D20 Slot: 19
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1724F70 Offset: 0x1724370 VA: 0x181724F70 Slot: 22
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1725250 Offset: 0x1724650 VA: 0x181725250 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x17253B0 Offset: 0x17247B0 VA: 0x1817253B0 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1725840 Offset: 0x1724C40 VA: 0x181725840 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1725890 Offset: 0x1724C90 VA: 0x181725890 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x1725CF0 Offset: 0x17250F0 VA: 0x181725CF0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1725D30 Offset: 0x1725130 VA: 0x181725D30 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x1725D70 Offset: 0x1725170 VA: 0x181725D70 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1725DC0 Offset: 0x17251C0 VA: 0x181725DC0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1725E10 Offset: 0x1725210 VA: 0x181725E10 Slot: 12
	public override void set_Position(long value) { }

}

private sealed class DeflateStream.ReadMethod : MulticastDelegate // TypeDefIndex: 2863
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1343920 Offset: 0x1342D20 VA: 0x181343920 Slot: 12
	public virtual int Invoke(byte[] array, int offset, int count) { }

	// RVA: 0x1563AC0 Offset: 0x1562EC0 VA: 0x181563AC0 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0xB95EA0 Offset: 0xB952A0 VA: 0x180B95EA0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

private sealed class DeflateStream.WriteMethod : MulticastDelegate // TypeDefIndex: 2864
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1344630 Offset: 0x1343A30 VA: 0x181344630 Slot: 12
	public virtual void Invoke(byte[] array, int offset, int count) { }

	// RVA: 0x1564A30 Offset: 0x1563E30 VA: 0x181564A30 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

