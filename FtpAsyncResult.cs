internal class FtpAsyncResult : IAsyncResult // TypeDefIndex: 2996
{	private FtpWebResponse response; // 0x10
	private ManualResetEvent waitHandle; // 0x18
	private Exception exception; // 0x20
	private AsyncCallback callback; // 0x28
	private Stream stream; // 0x30
	private object state; // 0x38
	private bool completed; // 0x40
	private bool synch; // 0x41
	private object locker; // 0x48

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

