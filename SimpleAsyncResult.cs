internal class SimpleAsyncResult : IAsyncResult // TypeDefIndex: 3022
{
	private ManualResetEvent handle; 
	private bool synch; 
	private bool isCompleted; 
	private readonly SimpleAsyncCallback cb; 
	private object state; 
	private bool callbackDone; 
	private Exception exc; 
	private object locker; 
	private Nullable<bool> user_read_synch; 

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
{
	public AsyncCallback cb; 
	public SimpleAsyncResult <>4__this; 


	public void .ctor() { }

	internal void <.ctor>

}

private sealed class SimpleAsyncResult.<>c__DisplayClass11_0 // TypeDefIndex: 3024
{
	public Func<SimpleAsyncResult, bool> func; 
	public object locker; 
	public SimpleAsyncCallback callback; 


	public void .ctor() { }

	internal bool <RunWithLock>

	internal void <RunWithLock>

}

