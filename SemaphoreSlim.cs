public class SemaphoreSlim : IDisposable // TypeDefIndex: 759
{
	private int m_currentCount;
	private readonly int m_maxCount;
	private int m_waitCount;
	private object m_lockObj;
	private ManualResetEvent m_waitHandle;
	private SemaphoreSlim.TaskNode m_asyncHead;
	private SemaphoreSlim.TaskNode m_asyncTail;
	private static readonly Task<bool> s_trueTask;
	private const int NO_MAXIMUM = 2147483647;
	private static Action<object> s_cancellationTokenCanceledEventHandler;


	public void .ctor(int initialCount, int maxCount) { }

	public void Wait() { }

	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken) { }

	public Task WaitAsync() { }

	public Task<bool> WaitAsync(int millisecondsTimeout) { }

	public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken) { }

	private SemaphoreSlim.TaskNode CreateAndAddAsyncWaiter() { }

	private bool RemoveAsyncWaiter(SemaphoreSlim.TaskNode task) { }

	[AsyncStateMachineAttribute]
	private Task<bool> WaitUntilCountOrTimeoutAsync(SemaphoreSlim.TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken) { }

	public int Release() { }

	public int Release(int releaseCount) { }

	private static void QueueWaiterTask(SemaphoreSlim.TaskNode waiterTask) { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	private static void CancellationTokenCanceledEventHandler(object obj) { }

	private void CheckDispose() { }

	private static string GetResourceString(string str) { }

	private static void .cctor() { }

}

private sealed class SemaphoreSlim.TaskNode : Task<bool>, IThreadPoolWorkItem // TypeDefIndex: 760
{
	internal SemaphoreSlim.TaskNode Prev;
	internal SemaphoreSlim.TaskNode Next;


	internal void .ctor() { }

	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

}

private struct SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__31 : IAsyncStateMachine // TypeDefIndex: 761
{
	public int <>1__state;
	public AsyncTaskMethodBuilder<bool> <>t__builder;
	public CancellationToken cancellationToken;
	public SemaphoreSlim.TaskNode asyncWaiter;
	public int millisecondsTimeout;
	private CancellationTokenSource <cts>5__1;
	public SemaphoreSlim <>4__this;
	private object <>7__wrap1;
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1;
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__2;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

