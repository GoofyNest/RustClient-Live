public class CryptoStream : Stream, IDisposable // TypeDefIndex: 949
{
	private Stream _stream; 
	private ICryptoTransform _Transform; 
	private byte[] _InputBuffer; 
	private int _InputBufferIndex; 
	private int _InputBlockSize; 
	private byte[] _OutputBuffer; 
	private int _OutputBufferIndex; 
	private int _OutputBlockSize; 
	private CryptoStreamMode _transformMode; 
	private bool _canRead; 
	private bool _canWrite; 
	private bool _finalBlockTransformed; 

public override bool CanRead { get; }
public override bool CanSeek { get; }
public override bool CanWrite { get; }
public override long Length { get; }
public override long Position { get; set; }
public bool HasFlushedFinalBlock { get; }


public void .ctor(Stream stream, ICryptoTransform transform, CryptoStreamMode mode) { }

public override bool get_CanRead() { }

public override bool get_CanSeek() { }

public override bool get_CanWrite() { }

public override long get_Length() { }

public override long get_Position() { }

public override void set_Position(long value) { }

public bool get_HasFlushedFinalBlock() { }

public void FlushFinalBlock() { }

public override void Flush() { }

public override long Seek(long offset, SeekOrigin origin) { }

public override void SetLength(long value) { }

public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] 
private Task<int> ReadAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

public override void Write(byte[] buffer, int offset, int count) { }

public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] 
private Task WriteAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

public void Clear() { }

protected override void Dispose(bool disposing) { }

private void InitializeBuffer() { }

}

private struct CryptoStream.HopToThreadPoolAwaitable : INotifyCompletion // TypeDefIndex: 950
{
public bool IsCompleted { get; }


public CryptoStream.HopToThreadPoolAwaitable GetAwaiter() { }

public bool get_IsCompleted() { }

public void OnCompleted(Action continuation) { }

public void GetResult() { }

}

private struct CryptoStream.<ReadAsyncInternal>d__34 : IAsyncStateMachine // TypeDefIndex: 951
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<int> <>t__builder; 
	public CryptoStream <>4__this; 
	public int count; 
	public int offset; 
	public byte[] buffer; 
	public CancellationToken cancellationToken; 
	private byte[] <tempInputBuffer>5__1; 
	private int <currentOutputIndex>5__2; 
	private int <bytesToDeliver>5__3; 
	private SemaphoreSlim <sem>5__4; 
	private CryptoStream.HopToThreadPoolAwaitable <>u__1; 
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; 
	private int <>7__wrap1; 
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__3; 


private void MoveNext() { }

	[DebuggerHiddenAttribute] 
private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct CryptoStream.<WriteAsyncInternal>d__37 : IAsyncStateMachine // TypeDefIndex: 952
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public CryptoStream <>4__this; 
	public int count; 
	public int offset; 
	public byte[] buffer; 
	public CancellationToken cancellationToken; 
	private int <bytesToWrite>5__1; 
	private int <currentInputIndex>5__2; 
	private int <numWholeBlocksInBytes>5__3; 
	private SemaphoreSlim <sem>5__4; 
	private CryptoStream.HopToThreadPoolAwaitable <>u__1; 
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; 


private void MoveNext() { }

	[DebuggerHiddenAttribute] 
private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

