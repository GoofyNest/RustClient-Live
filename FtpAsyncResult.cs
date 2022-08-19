internal class FtpAsyncResult : IAsyncResult // TypeDefIndex: 2996
{	// Fields
	private FtpWebResponse response; // 0x10
	private ManualResetEvent waitHandle; // 0x18
	private Exception exception; // 0x20
	private AsyncCallback callback; // 0x28
	private Stream stream; // 0x30
	private object state; // 0x38
	private bool completed; // 0x40
	private bool synch; // 0x41
	private object locker; // 0x48

	// Properties
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }
	internal bool GotException { get; }
	internal Exception Exception { get; }
	internal FtpWebResponse Response { get; }
	internal Stream Stream { get; set; }

	// Methods

	// RVA: 0x132B8B0 Offset: 0x132ACB0 VA: 0x18132B8B0
	public void .ctor(AsyncCallback callback, object state) { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x132B950 Offset: 0x132AD50 VA: 0x18132B950 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0xEE1D40 Offset: 0xEE1140 VA: 0x180EE1D40 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x132BA60 Offset: 0x132AE60 VA: 0x18132BA60 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x1230020 Offset: 0x122F420 VA: 0x181230020
	internal bool get_GotException() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal Exception get_Exception() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal FtpWebResponse get_Response() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	internal Stream get_Stream() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	internal void set_Stream(Stream value) { }

	// RVA: 0x132B830 Offset: 0x132AC30 VA: 0x18132B830
	internal bool WaitUntilComplete(int timeout, bool exitContext) { }

	// RVA: 0x132B740 Offset: 0x132AB40 VA: 0x18132B740
	internal void SetCompleted(bool synch, Exception exc, FtpWebResponse response) { }

	// RVA: 0x132B700 Offset: 0x132AB00 VA: 0x18132B700
	internal void SetCompleted(bool synch, FtpWebResponse response) { }

	// RVA: 0x132B720 Offset: 0x132AB20 VA: 0x18132B720
	internal void SetCompleted(bool synch, Exception exc) { }

	// RVA: 0x132B690 Offset: 0x132AA90 VA: 0x18132B690
	internal void DoCallback() { }

}

