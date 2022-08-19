internal class LazyAsyncResult : IAsyncResult // TypeDefIndex: 2919
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static LazyAsyncResult.ThreadContext t_ThreadContext; // 0x80000000
	private object m_AsyncObject; // 0x10
	private object m_AsyncState; // 0x18
	private AsyncCallback m_AsyncCallback; // 0x20
	private object m_Result; // 0x28
	private int m_IntCompleted; // 0x30
	private bool m_UserEvent; // 0x34
	private object m_Event; // 0x38

	// Properties
	private static LazyAsyncResult.ThreadContext CurrentThreadContext { get; }
	internal object AsyncObject { get; }
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }
	internal bool InternalPeekCompleted { get; }

	// Methods

	// RVA: 0x1340930 Offset: 0x133FD30 VA: 0x181340930
	private static LazyAsyncResult.ThreadContext get_CurrentThreadContext() { }

	// RVA: 0x1340790 Offset: 0x133FB90 VA: 0x181340790
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal object get_AsyncObject() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x1340860 Offset: 0x133FC60 VA: 0x181340860 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x1340180 Offset: 0x133F580 VA: 0x181340180
	private bool LazilyCreateEvent(out ManualResetEvent waitHandle) { }

	// RVA: 0x1340900 Offset: 0x133FD00 VA: 0x181340900 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x13409C0 Offset: 0x133FDC0 VA: 0x1813409C0 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x13409B0 Offset: 0x133FDB0 VA: 0x1813409B0
	internal bool get_InternalPeekCompleted() { }

	// RVA: 0x13402F0 Offset: 0x133F6F0 VA: 0x1813402F0
	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	// RVA: 0x1340130 Offset: 0x133F530 VA: 0x181340130
	internal void InvokeCallback(object result) { }

	// RVA: 0x133FF50 Offset: 0x133F350 VA: 0x18133FF50 Slot: 8
	protected virtual void Complete(IntPtr userToken) { }

	// RVA: 0x13406D0 Offset: 0x133FAD0 VA: 0x1813406D0
	private void WorkerThreadComplete(object state) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	protected virtual void Cleanup() { }

	// RVA: 0x1340120 Offset: 0x133F520 VA: 0x181340120
	internal object InternalWaitForCompletion() { }

	// RVA: 0x1340470 Offset: 0x133F870 VA: 0x181340470
	private object WaitForCompletion(bool snap) { }

}

private class LazyAsyncResult.ThreadContext // TypeDefIndex: 2920
{	// Fields
	internal int m_NestedIOCount; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

