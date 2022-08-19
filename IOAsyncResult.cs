internal abstract class IOAsyncResult : IAsyncResult // TypeDefIndex: 2594
{	// Fields
	private AsyncCallback async_callback; // 0x10
	private object async_state; // 0x18
	private ManualResetEvent wait_handle; // 0x20
	private bool completed_synchronously; // 0x28
	private bool completed; // 0x29

	// Properties
	public AsyncCallback AsyncCallback { get; }
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; set; }
	public bool IsCompleted { get; set; }

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	protected void .ctor(AsyncCallback async_callback, object async_state) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public AsyncCallback get_AsyncCallback() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x15606E0 Offset: 0x155FAE0 VA: 0x1815606E0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x9775C0 Offset: 0x9769C0 VA: 0x1809775C0 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x9775D0 Offset: 0x9769D0 VA: 0x1809775D0
	protected void set_CompletedSynchronously(bool value) { }

	// RVA: 0x754350 Offset: 0x753750 VA: 0x180754350 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x15607F0 Offset: 0x155FBF0 VA: 0x1815607F0
	protected void set_IsCompleted(bool value) { }

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void CompleteDisposed();

}

