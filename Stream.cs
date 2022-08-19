public abstract class Stream : MarshalByRefObject, IDisposable // TypeDefIndex: 638
{	// Fields
	public static readonly Stream Null; // 0x0
	private const int _DefaultCopyBufferSize = 81920;
	private Stream.ReadWriteTask _activeReadWriteTask; // 0x18
	private SemaphoreSlim _asyncActiveSemaphore; // 0x20

	// Properties
	public abstract bool CanRead { get; }
	public abstract bool CanSeek { get; }
	public abstract bool CanWrite { get; }
	public abstract long Length { get; }
	public abstract long Position { get; set; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public virtual int ReadTimeout { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public virtual int WriteTimeout { get; }

	// Methods

	// RVA: 0x162DF60 Offset: 0x162D360 VA: 0x18162DF60
	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_CanRead();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_CanSeek();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_CanWrite();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract long get_Length();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long get_Position();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void set_Position(long value);

	// RVA: 0x162EB30 Offset: 0x162DF30 VA: 0x18162EB30 Slot: 13
	public virtual int get_ReadTimeout() { }

	// RVA: 0x162EBA0 Offset: 0x162DFA0 VA: 0x18162EBA0 Slot: 14
	public virtual int get_WriteTimeout() { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x162D6B0 Offset: 0x162CAB0 VA: 0x18162D6B0
	public Task CopyToAsync(Stream destination) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x162D620 Offset: 0x162CA20 VA: 0x18162D620
	public Task CopyToAsync(Stream destination, int bufferSize) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x162D2A0 Offset: 0x162C6A0 VA: 0x18162D2A0 Slot: 15
	public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3BC0 Offset: 0xA2FC0 VA: 0x1800A3BC0
	// RVA: 0x162D160 Offset: 0x162C560 VA: 0x18162D160
	private Task CopyToAsyncInternal(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	// RVA: 0x162D730 Offset: 0x162CB30 VA: 0x18162D730
	public void CopyTo(Stream destination) { }

	// RVA: 0x162E060 Offset: 0x162D460 VA: 0x18162E060
	private void InternalCopyTo(Stream destination, int bufferSize) { }

	// RVA: 0x162D0F0 Offset: 0x162C4F0 VA: 0x18162D0F0 Slot: 16
	public virtual void Close() { }

	// RVA: 0x15ADF60 Offset: 0x15AD360 VA: 0x1815ADF60 Slot: 6
	public void Dispose() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 17
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void Flush();

	// RVA: 0x162CB70 Offset: 0x162BF70 VA: 0x18162CB70 Slot: 19
	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x162C950 Offset: 0x162BD50 VA: 0x18162C950
	internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x162D9E0 Offset: 0x162CDE0 VA: 0x18162D9E0 Slot: 20
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x162E120 Offset: 0x162D520 VA: 0x18162E120 Slot: 21
	public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x162C570 Offset: 0x162B970 VA: 0x18162C570
	private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x162CDC0 Offset: 0x162C1C0 VA: 0x18162CDC0 Slot: 22
	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x162CBA0 Offset: 0x162BFA0 VA: 0x18162CBA0
	internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x162E430 Offset: 0x162D830 VA: 0x18162E430
	private void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x162E620 Offset: 0x162DA20 VA: 0x18162E620
	private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x162DCB0 Offset: 0x162D0B0 VA: 0x18162DCB0 Slot: 23
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x162E700 Offset: 0x162DB00 VA: 0x18162E700
	public Task WriteAsync(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x162E7A0 Offset: 0x162DBA0 VA: 0x18162E7A0 Slot: 24
	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x162C760 Offset: 0x162BB60 VA: 0x18162C760
	private Task BeginEndWriteAsync(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract long Seek(long offset, SeekOrigin origin);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void SetLength(long value);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract int Read([In] [Out] byte[] buffer, int offset, int count);

	// RVA: 0x162E380 Offset: 0x162D780 VA: 0x18162E380 Slot: 28
	public virtual int ReadByte() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void Write(byte[] buffer, int offset, int count);

	// RVA: 0x162E9F0 Offset: 0x162DDF0 VA: 0x18162E9F0 Slot: 30
	public virtual void WriteByte(byte value) { }

	// RVA: 0x162CDF0 Offset: 0x162C1F0 VA: 0x18162CDF0
	internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x162CFD0 Offset: 0x162C3D0 VA: 0x18162CFD0
	internal static int BlockingEndRead(IAsyncResult asyncResult) { }

	// RVA: 0x162CEE0 Offset: 0x162C2E0 VA: 0x18162CEE0
	internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x162D060 Offset: 0x162C460 VA: 0x18162D060
	internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x162EA90 Offset: 0x162DE90 VA: 0x18162EA90
	private static void .cctor() { }

}

private struct Stream.ReadWriteParameters // TypeDefIndex: 639
{	// Fields
	internal byte[] Buffer; // 0x0
	internal int Offset; // 0x8
	internal int Count; // 0xC

}

private sealed class Stream.ReadWriteTask : Task<int>, ITaskCompletionAction // TypeDefIndex: 640
{	// Fields
	internal readonly bool _isRead; // 0x58
	internal Stream _stream; // 0x60
	internal byte[] _buffer; // 0x68
	internal int _offset; // 0x70
	internal int _count; // 0x74
	private AsyncCallback _callback; // 0x78
	private ExecutionContext _context; // 0x80
	private static ContextCallback s_invokeAsyncCallback; // 0x0

	// Methods

	// RVA: 0x1629340 Offset: 0x1628740 VA: 0x181629340
	internal void ClearBeginState() { }

	// RVA: 0x1629590 Offset: 0x1628990 VA: 0x181629590
	public void .ctor(bool isRead, Func<object, int> function, object state, Stream stream, byte[] buffer, int offset, int count, AsyncCallback callback) { }

	// RVA: 0x1629380 Offset: 0x1628780 VA: 0x181629380
	private static void InvokeAsyncCallback(object completedTask) { }

	// RVA: 0x1629410 Offset: 0x1628810 VA: 0x181629410 Slot: 20
	private void System.Threading.Tasks.ITaskCompletionAction.Invoke(Task completingTask) { }

}

private sealed class Stream.NullStream : Stream // TypeDefIndex: 641
{	// Fields
	private static Task<int> s_nullReadTask; // 0x13000

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1624230 Offset: 0x1623630 VA: 0x181624230
	internal void .ctor() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 10
	public override long get_Length() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 11
	public override long get_Position() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 18
	public override void Flush() { }

	// RVA: 0x1623DF0 Offset: 0x16231F0 VA: 0x181623DF0 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1623ED0 Offset: 0x16232D0 VA: 0x181623ED0 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1623E60 Offset: 0x1623260 VA: 0x181623E60 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1623FD0 Offset: 0x16233D0 VA: 0x181623FD0 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 27
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x16240D0 Offset: 0x16234D0 VA: 0x1816240D0 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x513D90 Offset: 0x513190 VA: 0x180513D90 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x16241A0 Offset: 0x16235A0 VA: 0x1816241A0 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 26
	public override void SetLength(long length) { }

}

internal sealed class Stream.SynchronousAsyncResult : IAsyncResult // TypeDefIndex: 642
{	// Fields
	private readonly object _stateObject; // 0x10
	private readonly bool _isWrite; // 0x18
	private ManualResetEvent _waitHandle; // 0x20
	private ExceptionDispatchInfo _exceptionInfo; // 0x28
	private bool _endXxxCalled; // 0x30
	private int _bytesRead; // 0x34

	// Properties
	public bool IsCompleted { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public object AsyncState { get; }
	public bool CompletedSynchronously { get; }

	// Methods

	// RVA: 0x162FDA0 Offset: 0x162F1A0 VA: 0x18162FDA0
	internal void .ctor(int bytesRead, object asyncStateObject) { }

	// RVA: 0x162FDE0 Offset: 0x162F1E0 VA: 0x18162FDE0
	internal void .ctor(object asyncStateObject) { }

	// RVA: 0x162FD30 Offset: 0x162F130 VA: 0x18162FD30
	internal void .ctor(Exception ex, object asyncStateObject, bool isWrite) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x162FE20 Offset: 0x162F220 VA: 0x18162FE20 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x162FD10 Offset: 0x162F110 VA: 0x18162FD10
	internal void ThrowIfError() { }

	// RVA: 0x162CFD0 Offset: 0x162C3D0 VA: 0x18162CFD0
	internal static int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x162D060 Offset: 0x162C460 VA: 0x18162D060
	internal static void EndWrite(IAsyncResult asyncResult) { }

}

private sealed class Stream.SynchronousAsyncResult.<>c // TypeDefIndex: 643
{	// Fields
	public static readonly Stream.SynchronousAsyncResult.<>c <>9; // 0x0
	public static Func<ManualResetEvent> <>9__12_0; // 0x8

	// Methods

	// RVA: 0x16325F0 Offset: 0x16319F0 VA: 0x1816325F0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1632480 Offset: 0x1631880 VA: 0x181632480
	internal ManualResetEvent <get_AsyncWaitHandle>b__12_0() { }

}

private sealed class Stream.<>c // TypeDefIndex: 644
{	// Fields
	public static readonly Stream.<>c <>9; // 0x0
	public static Func<SemaphoreSlim> <>9__4_0; // 0x8
	public static Func<object, int> <>9__39_0; // 0x10
	public static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, object, IAsyncResult> <>9__43_0; // 0x18
	public static Func<Stream, IAsyncResult, int> <>9__43_1; // 0x20
	public static Func<object, int> <>9__46_0; // 0x28
	public static Action<Task, object> <>9__47_0; // 0x30
	public static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, object, IAsyncResult> <>9__53_0; // 0x38
	public static Func<Stream, IAsyncResult, VoidTaskResult> <>9__53_1; // 0x40

	// Methods

	// RVA: 0x1632590 Offset: 0x1631990 VA: 0x181632590
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1631D70 Offset: 0x1631170 VA: 0x181631D70
	internal SemaphoreSlim <EnsureAsyncActiveSemaphoreInitialized>b__4_0() { }

	// RVA: 0x1631B20 Offset: 0x1630F20 VA: 0x181631B20
	internal int <BeginReadInternal>b__39_0(object <p0>) { }

	// RVA: 0x16319D0 Offset: 0x1630DD0 VA: 0x1816319D0
	internal IAsyncResult <BeginEndReadAsync>b__43_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) { }

	// RVA: 0x1631A40 Offset: 0x1630E40 VA: 0x181631A40
	internal int <BeginEndReadAsync>b__43_1(Stream stream, IAsyncResult asyncResult) { }

	// RVA: 0x1631C50 Offset: 0x1631050 VA: 0x181631C50
	internal int <BeginWriteInternal>b__46_0(object <p0>) { }

	// RVA: 0x1631DC0 Offset: 0x16311C0 VA: 0x181631DC0
	internal void <RunReadWriteTaskWhenReady>b__47_0(Task t, object state) { }

	// RVA: 0x1631A70 Offset: 0x1630E70 VA: 0x181631A70
	internal IAsyncResult <BeginEndWriteAsync>b__53_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) { }

	// RVA: 0x1631AE0 Offset: 0x1630EE0 VA: 0x181631AE0
	internal VoidTaskResult <BeginEndWriteAsync>b__53_1(Stream stream, IAsyncResult asyncResult) { }

}

private struct Stream.<CopyToAsyncInternal>d__27 : IAsyncStateMachine // TypeDefIndex: 645
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public int bufferSize; // 0x20
	public Stream destination; // 0x28
	private byte[] <buffer>5__1; // 0x30
	private int <bytesRead>5__2; // 0x38
	public CancellationToken cancellationToken; // 0x40
	public Stream <>4__this; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__2; // 0x60

	// Methods

	// RVA: 0x1F6430 Offset: 0x1F5830 VA: 0x1801F6430 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

