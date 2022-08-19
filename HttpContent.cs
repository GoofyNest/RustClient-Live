public abstract class HttpContent : IDisposable // TypeDefIndex: 5744
{	// Fields
	private HttpContent.FixedMemoryStream buffer; // 0x10
	private Stream stream; // 0x18
	private bool disposed; // 0x20
	private HttpContentHeaders headers; // 0x28

	// Properties
	public HttpContentHeaders Headers { get; }
	internal Nullable<long> LoadedBufferLength { get; }

	// Methods

	// RVA: 0x1086290 Offset: 0x1085690 VA: 0x181086290
	public HttpContentHeaders get_Headers() { }

	// RVA: 0x1086360 Offset: 0x1085760 VA: 0x181086360
	internal Nullable<long> get_LoadedBufferLength() { }

	// RVA: 0x1085A40 Offset: 0x1084E40 VA: 0x181085A40
	internal void CopyTo(Stream stream) { }

	// RVA: 0x10858E0 Offset: 0x1084CE0 VA: 0x1810858E0
	public Task CopyToAsync(Stream stream) { }

	// RVA: 0x1085980 Offset: 0x1084D80 VA: 0x181085980
	public Task CopyToAsync(Stream stream, TransportContext context) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1A20 Offset: 0xD0E20 VA: 0x1800D1A20
	// RVA: 0x1085AF0 Offset: 0x1084EF0 VA: 0x181085AF0 Slot: 5
	protected virtual Task<Stream> CreateContentReadStreamAsync() { }

	// RVA: 0x1085BF0 Offset: 0x1084FF0 VA: 0x181085BF0
	private static HttpContent.FixedMemoryStream CreateFixedMemoryStream(long maxBufferSize) { }

	// RVA: 0xFDFAC0 Offset: 0xFDEEC0 VA: 0x180FDFAC0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1085C50 Offset: 0x1085050 VA: 0x181085C50 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1085EF0 Offset: 0x10852F0 VA: 0x181085EF0
	public Task LoadIntoBufferAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0xD1C40 Offset: 0xD1040 VA: 0x1800D1C40
	// RVA: 0x1085F00 Offset: 0x1085300 VA: 0x181085F00
	public Task LoadIntoBufferAsync(long maxBufferSize) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1DC0 Offset: 0xD11C0 VA: 0x1800D1DC0
	// RVA: 0x1086010 Offset: 0x1085410 VA: 0x181086010
	public Task<Stream> ReadAsStreamAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0xD1F60 Offset: 0xD1360 VA: 0x1800D1F60
	// RVA: 0x1086110 Offset: 0x1085510 VA: 0x181086110
	public Task<string> ReadAsStringAsync() { }

	// RVA: 0x1085C70 Offset: 0x1085070 VA: 0x181085C70
	private static Encoding GetEncodingFromBuffer(byte[] buffer, int length, ref int preambleLength) { }

	// RVA: 0x1086210 Offset: 0x1085610 VA: 0x181086210
	private static int StartsWith(byte[] array, int length, byte[] value) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected internal abstract Task SerializeToStreamAsync(Stream stream, TransportContext context);

	// RVA: -1 Offset: -1 Slot: 8
	protected internal abstract bool TryComputeLength(out long length);

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

private sealed class HttpContent.FixedMemoryStream : MemoryStream // TypeDefIndex: 5745
{	// Fields
	private readonly long maxSize; // 0x50

	// Methods

	// RVA: 0x1083370 Offset: 0x1082770 VA: 0x181083370
	public void .ctor(long maxSize) { }

	// RVA: 0x1083210 Offset: 0x1082610 VA: 0x181083210
	private void CheckOverflow(int count) { }

	// RVA: 0x10832D0 Offset: 0x10826D0 VA: 0x1810832D0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x1083310 Offset: 0x1082710 VA: 0x181083310 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

}

private struct HttpContent.<CreateContentReadStreamAsync>d__12 : IAsyncStateMachine // TypeDefIndex: 5746
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x19DE00 Offset: 0x19D200 VA: 0x18019DE00 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19DE10 Offset: 0x19D210 VA: 0x18019DE10 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct HttpContent.<LoadIntoBufferAsync>d__17 : IAsyncStateMachine // TypeDefIndex: 5747
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	public long maxBufferSize; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x19DEC0 Offset: 0x19D2C0 VA: 0x18019DEC0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct HttpContent.<ReadAsStreamAsync>d__18 : IAsyncStateMachine // TypeDefIndex: 5748
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__1; // 0x28

	// Methods

	// RVA: 0x19DED0 Offset: 0x19D2D0 VA: 0x18019DED0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19DEE0 Offset: 0x19D2E0 VA: 0x18019DEE0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct HttpContent.<ReadAsStringAsync>d__20 : IAsyncStateMachine // TypeDefIndex: 5749
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x19DF30 Offset: 0x19D330 VA: 0x18019DF30 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19DF40 Offset: 0x19D340 VA: 0x18019DF40 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

