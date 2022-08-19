internal class FtpDataStream : Stream, IDisposable // TypeDefIndex: 2997
{	// Fields
	private FtpWebRequest request; // 0x28
	private Stream networkStream; // 0x30
	private bool disposed; // 0x38
	private bool isRead; // 0x39
	private int totalRead; // 0x3C

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x132CAA0 Offset: 0x132BEA0 VA: 0x18132CAA0
	internal void .ctor(FtpWebRequest request, Stream stream, bool isRead) { }

	// RVA: 0x8B1130 Offset: 0x8B0530 VA: 0x1808B1130 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x132CB80 Offset: 0x132BF80 VA: 0x18132CB80 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x132CB90 Offset: 0x132BF90 VA: 0x18132CB90 Slot: 10
	public override long get_Length() { }

	// RVA: 0x132CBE0 Offset: 0x132BFE0 VA: 0x18132CBE0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x132CC30 Offset: 0x132C030 VA: 0x18132CC30 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x132BFB0 Offset: 0x132B3B0 VA: 0x18132BFB0 Slot: 16
	public override void Close() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 18
	public override void Flush() { }

	// RVA: 0x132C6B0 Offset: 0x132BAB0 VA: 0x18132C6B0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x132C700 Offset: 0x132BB00 VA: 0x18132C700 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x132C350 Offset: 0x132B750 VA: 0x18132C350
	private int ReadInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x132BB20 Offset: 0x132AF20 VA: 0x18132BB20 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x132C090 Offset: 0x132B490 VA: 0x18132C090 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x132C500 Offset: 0x132B900 VA: 0x18132C500 Slot: 27
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x132C7C0 Offset: 0x132BBC0 VA: 0x18132C7C0
	private void WriteInternal(byte[] buffer, int offset, int size) { }

	// RVA: 0x132BD20 Offset: 0x132B120 VA: 0x18132BD20 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x132C200 Offset: 0x132B600 VA: 0x18132C200 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x132C8F0 Offset: 0x132BCF0 VA: 0x18132C8F0 Slot: 29
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0xFF5580 Offset: 0xFF4980 VA: 0x180FF5580 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x132C750 Offset: 0x132BB50 VA: 0x18132C750 Slot: 6
	private void System.IDisposable.Dispose() { }

	// RVA: 0x132BFD0 Offset: 0x132B3D0 VA: 0x18132BFD0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x132BF20 Offset: 0x132B320 VA: 0x18132BF20
	private void CheckDisposed() { }

}

private sealed class FtpDataStream.WriteDelegate : MulticastDelegate // TypeDefIndex: 2998
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1344630 Offset: 0x1343A30 VA: 0x181344630 Slot: 12
	public virtual void Invoke(byte[] buffer, int offset, int size) { }

	// RVA: 0x1344590 Offset: 0x1343990 VA: 0x181344590 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int size, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class FtpDataStream.ReadDelegate : MulticastDelegate // TypeDefIndex: 2999
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1343920 Offset: 0x1342D20 VA: 0x181343920 Slot: 12
	public virtual int Invoke(byte[] buffer, int offset, int size) { }

	// RVA: 0x1343880 Offset: 0x1342C80 VA: 0x181343880 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int size, AsyncCallback callback, object object) { }

	// RVA: 0xB95EA0 Offset: 0xB952A0 VA: 0x180B95EA0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

