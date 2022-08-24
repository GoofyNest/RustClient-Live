internal abstract class IOAsyncResult : IAsyncResult // TypeDefIndex: 2594
{
	private AsyncCallback async_callback; 
	private object async_state; 
	private ManualResetEvent wait_handle; 
	private bool completed_synchronously; 
	private bool completed; 

public AsyncCallback AsyncCallback { get; }
public object AsyncState { get; }
public WaitHandle AsyncWaitHandle { get; }
public bool CompletedSynchronously { get; set; }
public bool IsCompleted { get; set; }


protected void .ctor(AsyncCallback async_callback, object async_state) { }

public AsyncCallback get_AsyncCallback() { }

public object get_AsyncState() { }

public WaitHandle get_AsyncWaitHandle() { }

public bool get_CompletedSynchronously() { }

protected void set_CompletedSynchronously(bool value) { }

public bool get_IsCompleted() { }

protected void set_IsCompleted(bool value) { }

internal abstract void CompleteDisposed();

}

