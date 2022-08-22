internal class LazyAsyncResult : IAsyncResult // TypeDefIndex: 2919
{	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static LazyAsyncResult.ThreadContext t_ThreadContext; // 0x80000000
	private object m_AsyncObject; // 0x10
	private object m_AsyncState; // 0x18
	private AsyncCallback m_AsyncCallback; // 0x20
	private object m_Result; // 0x28
	private int m_IntCompleted; // 0x30
	private bool m_UserEvent; // 0x34
	private object m_Event; // 0x38

	private static LazyAsyncResult.ThreadContext CurrentThreadContext { get; }
	internal object AsyncObject { get; }
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }
	internal bool InternalPeekCompleted { get; }


	private static LazyAsyncResult.ThreadContext get_CurrentThreadContext() { }

	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	internal object get_AsyncObject() { }

	public object get_AsyncState() { }

	public WaitHandle get_AsyncWaitHandle() { }

	private bool LazilyCreateEvent(out ManualResetEvent waitHandle) { }

	public bool get_CompletedSynchronously() { }

	public bool get_IsCompleted() { }

	internal bool get_InternalPeekCompleted() { }

	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	internal void InvokeCallback(object result) { }

	protected virtual void Complete(IntPtr userToken) { }

	private void WorkerThreadComplete(object state) { }

	protected virtual void Cleanup() { }

	internal object InternalWaitForCompletion() { }

	private object WaitForCompletion(bool snap) { }

}

private class LazyAsyncResult.ThreadContext // TypeDefIndex: 2920
{	internal int m_NestedIOCount; // 0x10


	public void .ctor() { }

}

