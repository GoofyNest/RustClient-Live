public abstract class Stream : MarshalByRefObject, IDisposable // TypeDefIndex: 638
{
	public static readonly Stream Null; 
private const int _DefaultCopyBufferSize = 81920;
	private Stream.ReadWriteTask _activeReadWriteTask; 
	private SemaphoreSlim _asyncActiveSemaphore; 

public abstract bool CanRead { get; }
public abstract bool CanSeek { get; }
public abstract bool CanWrite { get; }
public abstract long Length { get; }
public abstract long Position { get; set; }
	[ComVisibleAttribute] 
public virtual int ReadTimeout { get; }
	[ComVisibleAttribute] 
public virtual int WriteTimeout { get; }


internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized() { }

public abstract bool get_CanRead();

public abstract bool get_CanSeek();

public abstract bool get_CanWrite();

public abstract long get_Length();

public abstract long get_Position();

public abstract void set_Position(long value);

public virtual int get_ReadTimeout() { }

public virtual int get_WriteTimeout() { }

	[ComVisibleAttribute] 
public Task CopyToAsync(Stream destination) { }

	[ComVisibleAttribute] 
public Task CopyToAsync(Stream destination, int bufferSize) { }

	[ComVisibleAttribute] 
public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] 
private Task CopyToAsyncInternal(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

public void CopyTo(Stream destination) { }

private void InternalCopyTo(Stream destination, int bufferSize) { }

public virtual void Close() { }

public void Dispose() { }

protected virtual void Dispose(bool disposing) { }

public abstract void Flush();

public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

public virtual int EndRead(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] 
public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count) { }

public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

private void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask) { }

private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask) { }

public virtual void EndWrite(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] 
public Task WriteAsync(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] 
public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

private Task BeginEndWriteAsync(byte[] buffer, int offset, int count) { }

public abstract long Seek(long offset, SeekOrigin origin);

public abstract void SetLength(long value);

public abstract int Read([In] [Out] byte[] buffer, int offset, int count);

public virtual int ReadByte() { }

public abstract void Write(byte[] buffer, int offset, int count);

public virtual void WriteByte(byte value) { }

internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

internal static int BlockingEndRead(IAsyncResult asyncResult) { }

internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

protected void .ctor() { }

private static void .cctor() { }

}

private struct Stream.ReadWriteParameters // TypeDefIndex: 639
{
	internal byte[] Buffer; 
	internal int Offset; 
	internal int Count; 

}

private sealed class Stream.ReadWriteTask : Task<int>, ITaskCompletionAction // TypeDefIndex: 640
{
	internal readonly bool _isRead; 
	internal Stream _stream; 
	internal byte[] _buffer; 
	internal int _offset; 
	internal int _count; 
	private AsyncCallback _callback; 
	private ExecutionContext _context; 
	private static ContextCallback s_invokeAsyncCallback; 


internal void ClearBeginState() { }

public void .ctor(bool isRead, Func<object, int> function, object state, Stream stream, byte[] buffer, int offset, int count, AsyncCallback callback) { }

private static void InvokeAsyncCallback(object completedTask) { }

private void System.Threading.Tasks.ITaskCompletionAction.Invoke(Task completingTask) { }

}

private sealed class Stream.NullStream : Stream // TypeDefIndex: 641
{
	private static Task<int> s_nullReadTask; 

public override bool CanRead { get; }
public override bool CanWrite { get; }
public override bool CanSeek { get; }
public override long Length { get; }
public override long Position { get; set; }


internal void .ctor() { }

public override bool get_CanRead() { }

public override bool get_CanWrite() { }

public override bool get_CanSeek() { }

public override long get_Length() { }

public override long get_Position() { }

public override void set_Position(long value) { }

protected override void Dispose(bool disposing) { }

public override void Flush() { }

public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

public override int EndRead(IAsyncResult asyncResult) { }

public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

public override void EndWrite(IAsyncResult asyncResult) { }

public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] 
public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

public override int ReadByte() { }

public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] 
public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

public override void WriteByte(byte value) { }

public override long Seek(long offset, SeekOrigin origin) { }

public override void SetLength(long length) { }

}

internal sealed class Stream.SynchronousAsyncResult : IAsyncResult // TypeDefIndex: 642
{
	private readonly object _stateObject; 
	private readonly bool _isWrite; 
	private ManualResetEvent _waitHandle; 
	private ExceptionDispatchInfo _exceptionInfo; 
	private bool _endXxxCalled; 
	private int _bytesRead; 

public bool IsCompleted { get; }
public WaitHandle AsyncWaitHandle { get; }
public object AsyncState { get; }
public bool CompletedSynchronously { get; }


internal void .ctor(int bytesRead, object asyncStateObject) { }

internal void .ctor(object asyncStateObject) { }

internal void .ctor(Exception ex, object asyncStateObject, bool isWrite) { }

public bool get_IsCompleted() { }

public WaitHandle get_AsyncWaitHandle() { }

public object get_AsyncState() { }

public bool get_CompletedSynchronously() { }

internal void ThrowIfError() { }

internal static int EndRead(IAsyncResult asyncResult) { }

internal static void EndWrite(IAsyncResult asyncResult) { }

}

private sealed class Stream.SynchronousAsyncResult.<>c // TypeDefIndex: 643
{
	public static readonly Stream.SynchronousAsyncResult.<>c <>9; 
	public static Func<ManualResetEvent> <>9__12_0; 


private static void .cctor() { }

public void .ctor() { }

internal ManualResetEvent <get_AsyncWaitHandle>b__12_0() { }

}

private sealed class Stream.<>c // TypeDefIndex: 644
{
	public static readonly Stream.<>c <>9; 
	public static Func<SemaphoreSlim> <>9__4_0; 
	public static Func<object, int> <>9__39_0; 
	public static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, object, IAsyncResult> <>9__43_0; 
	public static Func<Stream, IAsyncResult, int> <>9__43_1; 
	public static Func<object, int> <>9__46_0; 
	public static Action<Task, object> <>9__47_0; 
	public static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, object, IAsyncResult> <>9__53_0; 
	public static Func<Stream, IAsyncResult, VoidTaskResult> <>9__53_1; 


private static void .cctor() { }

public void .ctor() { }

internal SemaphoreSlim <EnsureAsyncActiveSemaphoreInitialized>b__4_0() { }

internal int <BeginReadInternal>b__39_0(object <p0>) { }

internal IAsyncResult <BeginEndReadAsync>b__43_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) { }

internal int <BeginEndReadAsync>b__43_1(Stream stream, IAsyncResult asyncResult) { }

internal int <BeginWriteInternal>b__46_0(object <p0>) { }

internal void <RunReadWriteTaskWhenReady>b__47_0(Task t, object state) { }

internal IAsyncResult <BeginEndWriteAsync>b__53_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) { }

internal VoidTaskResult <BeginEndWriteAsync>b__53_1(Stream stream, IAsyncResult asyncResult) { }

}

private struct Stream.<CopyToAsyncInternal>d__27 : IAsyncStateMachine // TypeDefIndex: 645
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public int bufferSize; 
	public Stream destination; 
	private byte[] <buffer>5__1; 
	private int <bytesRead>5__2; 
	public CancellationToken cancellationToken; 
	public Stream <>4__this; 
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; 
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__2; 


private void MoveNext() { }

	[DebuggerHiddenAttribute] 
private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

