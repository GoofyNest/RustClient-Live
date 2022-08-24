internal class FtpAsyncResult : IAsyncResult // TypeDefIndex: 2996
{
	private FtpWebResponse response; 
	private ManualResetEvent waitHandle; 
	private Exception exception; 
	private AsyncCallback callback; 
	private Stream stream; 
	private object state; 
	private bool completed; 
	private bool synch; 
	private object locker; 

	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }
	internal bool GotException { get; }
	internal Exception Exception { get; }
	internal FtpWebResponse Response { get; }
	internal Stream Stream { get; set; }


	public void .ctor(AsyncCallback callback, object state) { }

	public object get_AsyncState() { }

	public WaitHandle get_AsyncWaitHandle() { }

	public bool get_CompletedSynchronously() { }

	public bool get_IsCompleted() { }

	internal bool get_GotException() { }

	internal Exception get_Exception() { }

	internal FtpWebResponse get_Response() { }

	internal Stream get_Stream() { }

	internal void set_Stream(Stream value) { }

	internal bool WaitUntilComplete(int timeout, bool exitContext) { }

	internal void SetCompleted(bool synch, Exception exc, FtpWebResponse response) { }

	internal void SetCompleted(bool synch, FtpWebResponse response) { }

	internal void SetCompleted(bool synch, Exception exc) { }

	internal void DoCallback() { }

}

