internal class SimpleAsyncResult : IAsyncResult // TypeDefIndex: 3022
{	private ManualResetEvent handle; // 0x10
	private bool synch; // 0x18
	private bool isCompleted; // 0x19
	private readonly SimpleAsyncCallback cb; // 0x20
	private object state; // 0x28
	private bool callbackDone; // 0x30
	private Exception exc; // 0x38
	private object locker; // 0x40
	private Nullable<bool> user_read_synch; // 0x48

	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	internal bool CompletedSynchronouslyPeek { get; }
	public bool IsCompleted { get; }
	internal bool GotException { get; }
	internal Exception Exception { get; }


	private void .ctor(SimpleAsyncCallback cb) { }

	protected void .ctor(AsyncCallback cb, object state) { }

	public static void Run(Func<SimpleAsyncResult, bool> func, SimpleAsyncCallback callback) { }

	public static void RunWithLock(object locker, Func<SimpleAsyncResult, bool> func, SimpleAsyncCallback callback) { }

	protected void Reset_internal() { }

	internal void SetCompleted(bool synch, Exception e) { }

	internal void SetCompleted(bool synch) { }

	private void SetCompleted_internal(bool synch, Exception e) { }

	protected void SetCompleted_internal(bool synch) { }

	private void DoCallback_private() { }

	protected void DoCallback_internal() { }

	internal void WaitUntilComplete() { }

	internal bool WaitUntilComplete(int timeout, bool exitContext) { }

	public object get_AsyncState() { }

	public WaitHandle get_AsyncWaitHandle() { }

	public bool get_CompletedSynchronously() { }

	internal bool get_CompletedSynchronouslyPeek() { }

	public bool get_IsCompleted() { }

	internal bool get_GotException() { }

	internal Exception get_Exception() { }

}

private sealed class SimpleAsyncResult.<>c__DisplayClass9_0 // TypeDefIndex: 3023
{	public AsyncCallback cb; // 0x10
	public SimpleAsyncResult <>4__this; // 0x18


	public void .ctor() { }

	internal void <.ctor>b__0(SimpleAsyncResult result) { }

}

private sealed class SimpleAsyncResult.<>c__DisplayClass11_0 // TypeDefIndex: 3024
{	public Func<SimpleAsyncResult, bool> func; // 0x10
	public object locker; // 0x18
	public SimpleAsyncCallback callback; // 0x20


	public void .ctor() { }

	internal bool <RunWithLock>b__0(SimpleAsyncResult inner) { }

	internal void <RunWithLock>b__1(SimpleAsyncResult inner) { }

}

