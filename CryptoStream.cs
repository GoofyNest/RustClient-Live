public class CryptoStream : Stream, IDisposable // TypeDefIndex: 949
{	// Fields
	private Stream _stream; // 0x28
	private ICryptoTransform _Transform; // 0x30
	private byte[] _InputBuffer; // 0x38
	private int _InputBufferIndex; // 0x40
	private int _InputBlockSize; // 0x44
	private byte[] _OutputBuffer; // 0x48
	private int _OutputBufferIndex; // 0x50
	private int _OutputBlockSize; // 0x54
	private CryptoStreamMode _transformMode; // 0x58
	private bool _canRead; // 0x5C
	private bool _canWrite; // 0x5D
	private bool _finalBlockTransformed; // 0x5E

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public bool HasFlushedFinalBlock { get; }

	// Methods

	// RVA: 0x16F70E0 Offset: 0x16F64E0 VA: 0x1816F70E0
	public void .ctor(Stream stream, ICryptoTransform transform, CryptoStreamMode mode) { }

	// RVA: 0x15ECC10 Offset: 0x15EC010 VA: 0x1815ECC10 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x15ECC00 Offset: 0x15EC000 VA: 0x1815ECC00 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x16F7390 Offset: 0x16F6790 VA: 0x1816F7390 Slot: 10
	public override long get_Length() { }

	// RVA: 0x16F7400 Offset: 0x16F6800 VA: 0x1816F7400 Slot: 11
	public override long get_Position() { }

	// RVA: 0x16F7470 Offset: 0x16F6870 VA: 0x1816F7470 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x15ECBF0 Offset: 0x15EBFF0 VA: 0x1815ECBF0
	public bool get_HasFlushedFinalBlock() { }

	// RVA: 0x16F5A60 Offset: 0x16F4E60 VA: 0x1816F5A60
	public void FlushFinalBlock() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 18
	public override void Flush() { }

	// RVA: 0x16F6760 Offset: 0x16F5B60 VA: 0x1816F6760 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x16F67D0 Offset: 0x16F5BD0 VA: 0x1816F67D0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x16F61D0 Offset: 0x16F55D0 VA: 0x1816F61D0 Slot: 27
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	// RVA: 0x16F5E40 Offset: 0x16F5240 VA: 0x1816F5E40 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xC8D40 Offset: 0xC8140 VA: 0x1800C8D40
	// RVA: 0x16F5CF0 Offset: 0x16F50F0 VA: 0x1816F5CF0
	private Task<int> ReadAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x16F6CF0 Offset: 0x16F60F0 VA: 0x1816F6CF0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x16F6980 Offset: 0x16F5D80 VA: 0x1816F6980 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xC8E80 Offset: 0xC8280 VA: 0x1800C8E80
	// RVA: 0x16F6840 Offset: 0x16F5C40 VA: 0x1816F6840
	private Task WriteAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x15ADF60 Offset: 0x15AD360 VA: 0x1815ADF60
	public void Clear() { }

	// RVA: 0x16F58E0 Offset: 0x16F4CE0 VA: 0x1816F58E0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16F5C40 Offset: 0x16F5040 VA: 0x1816F5C40
	private void InitializeBuffer() { }

}

private struct CryptoStream.HopToThreadPoolAwaitable : INotifyCompletion // TypeDefIndex: 950
{	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x14CAA0 Offset: 0x14BEA0 VA: 0x18014CAA0
	public CryptoStream.HopToThreadPoolAwaitable GetAwaiter() { }

	// RVA: 0x207390 Offset: 0x206790 VA: 0x180207390
	public bool get_IsCompleted() { }

	// RVA: 0x207330 Offset: 0x206730 VA: 0x180207330 Slot: 4
	public void OnCompleted(Action continuation) { }

	// RVA: 0xF1DA0 Offset: 0xF11A0 VA: 0x1800F1DA0
	public void GetResult() { }

}

private struct CryptoStream.<ReadAsyncInternal>d__34 : IAsyncStateMachine // TypeDefIndex: 951
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public CryptoStream <>4__this; // 0x20
	public int count; // 0x28
	public int offset; // 0x2C
	public byte[] buffer; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private byte[] <tempInputBuffer>5__1; // 0x40
	private int <currentOutputIndex>5__2; // 0x48
	private int <bytesToDeliver>5__3; // 0x4C
	private SemaphoreSlim <sem>5__4; // 0x50
	private CryptoStream.HopToThreadPoolAwaitable <>u__1; // 0x58
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x60
	private int <>7__wrap1; // 0x70
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__3; // 0x78

	// Methods

	// RVA: 0x2073A0 Offset: 0x2067A0 VA: 0x1802073A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2073B0 Offset: 0x2067B0 VA: 0x1802073B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct CryptoStream.<WriteAsyncInternal>d__37 : IAsyncStateMachine // TypeDefIndex: 952
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CryptoStream <>4__this; // 0x20
	public int count; // 0x28
	public int offset; // 0x2C
	public byte[] buffer; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private int <bytesToWrite>5__1; // 0x40
	private int <currentInputIndex>5__2; // 0x44
	private int <numWholeBlocksInBytes>5__3; // 0x48
	private SemaphoreSlim <sem>5__4; // 0x50
	private CryptoStream.HopToThreadPoolAwaitable <>u__1; // 0x58
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x60

	// Methods

	// RVA: 0x207400 Offset: 0x206800 VA: 0x180207400 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

