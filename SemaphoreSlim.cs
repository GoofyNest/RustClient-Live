public class SemaphoreSlim : IDisposable // TypeDefIndex: 759
{	// Fields
	private int m_currentCount; // 0x10
	private readonly int m_maxCount; // 0x14
	private int m_waitCount; // 0x18
	private object m_lockObj; // 0x20
	private ManualResetEvent m_waitHandle; // 0x28
	private SemaphoreSlim.TaskNode m_asyncHead; // 0x30
	private SemaphoreSlim.TaskNode m_asyncTail; // 0x38
	private static readonly Task<bool> s_trueTask; // 0x0
	private const int NO_MAXIMUM = 2147483647;
	private static Action<object> s_cancellationTokenCanceledEventHandler; // 0x8

	// Methods

	// RVA: 0x14951B0 Offset: 0x14945B0 VA: 0x1814951B0
	public void .ctor(int initialCount, int maxCount) { }

	// RVA: 0x14950E0 Offset: 0x14944E0 VA: 0x1814950E0
	public void Wait() { }

	// RVA: 0x1494BC0 Offset: 0x1493FC0 VA: 0x181494BC0
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1494B10 Offset: 0x1493F10 VA: 0x181494B10
	private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken) { }

	// RVA: 0x14949C0 Offset: 0x1493DC0 VA: 0x1814949C0
	public Task WaitAsync() { }

	// RVA: 0x14949B0 Offset: 0x1493DB0 VA: 0x1814949B0
	public Task<bool> WaitAsync(int millisecondsTimeout) { }

	// RVA: 0x1494490 Offset: 0x1493890 VA: 0x181494490
	public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1493DE0 Offset: 0x14931E0 VA: 0x181493DE0
	private SemaphoreSlim.TaskNode CreateAndAddAsyncWaiter() { }

	// RVA: 0x14943A0 Offset: 0x14937A0 VA: 0x1814943A0
	private bool RemoveAsyncWaiter(SemaphoreSlim.TaskNode task) { }

	[AsyncStateMachineAttribute] // RVA: 0xB2AF0 Offset: 0xB1EF0 VA: 0x1800B2AF0
	// RVA: 0x14949D0 Offset: 0x1493DD0 VA: 0x1814949D0
	private Task<bool> WaitUntilCountOrTimeoutAsync(SemaphoreSlim.TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1494010 Offset: 0x1493410 VA: 0x181494010
	public int Release() { }

	// RVA: 0x1494020 Offset: 0x1493420 VA: 0x181494020
	public int Release(int releaseCount) { }

	// RVA: 0x1494000 Offset: 0x1493400 VA: 0x181494000
	private static void QueueWaiterTask(SemaphoreSlim.TaskNode waiterTask) { }

	// RVA: 0x1493F80 Offset: 0x1493380 VA: 0x181493F80 Slot: 4
	public void Dispose() { }

	// RVA: 0x1493ED0 Offset: 0x14932D0 VA: 0x181493ED0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1493B10 Offset: 0x1492F10 VA: 0x181493B10
	private static void CancellationTokenCanceledEventHandler(object obj) { }

	// RVA: 0x1493D40 Offset: 0x1493140 VA: 0x181493D40
	private void CheckDispose() { }

	// RVA: 0x1493FF0 Offset: 0x14933F0 VA: 0x181493FF0
	private static string GetResourceString(string str) { }

	// RVA: 0x14950F0 Offset: 0x14944F0 VA: 0x1814950F0
	private static void .cctor() { }

}

private sealed class SemaphoreSlim.TaskNode : Task<bool>, IThreadPoolWorkItem // TypeDefIndex: 760
{	// Fields
	internal SemaphoreSlim.TaskNode Prev; // 0x58
	internal SemaphoreSlim.TaskNode Next; // 0x60

	// Methods

	// RVA: 0x14969E0 Offset: 0x1495DE0 VA: 0x1814969E0
	internal void .ctor() { }

	// RVA: 0x14969A0 Offset: 0x1495DA0 VA: 0x1814969A0 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

}

private struct SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31 : IAsyncStateMachine // TypeDefIndex: 761
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public SemaphoreSlim.TaskNode asyncWaiter; // 0x28
	public int millisecondsTimeout; // 0x30
	private CancellationTokenSource <cts>5__1; // 0x38
	public SemaphoreSlim <>4__this; // 0x40
	private object <>7__wrap1; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__2; // 0x60

	// Methods

	// RVA: 0x1F0980 Offset: 0x1EFD80 VA: 0x1801F0980 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1F0990 Offset: 0x1EFD90 VA: 0x1801F0990 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

