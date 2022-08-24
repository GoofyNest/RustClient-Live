internal class IOSelectorJob : IThreadPoolWorkItem // TypeDefIndex: 2595
{
	private IOOperation operation; 
	private IOAsyncCallback callback; 
	private IOAsyncResult state; 


public void .ctor(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) { }

private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

public void MarkDisposed() { }

}

