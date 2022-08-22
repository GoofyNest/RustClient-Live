internal class IOSelectorJob : IThreadPoolWorkItem // TypeDefIndex: 2595
{	private IOOperation operation; // 0x10
	private IOAsyncCallback callback; // 0x18
	private IOAsyncResult state; // 0x20


	public void .ctor(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) { }

	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	public void MarkDisposed() { }

}

