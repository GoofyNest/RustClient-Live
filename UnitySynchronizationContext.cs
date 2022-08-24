internal sealed class UnitySynchronizationContext : SynchronizationContext // TypeDefIndex: 3536
{
	private readonly List<UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue; 
	private readonly List<UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork; 
	private readonly int m_MainThreadID; 
	private int m_TrackedCount; 


	private void .ctor(int mainThreadID) { }

	private void .ctor(List<UnitySynchronizationContext.WorkRequest> queue, int mainThreadID) { }

	public override void Send(SendOrPostCallback callback, object state) { }

	public override void OperationStarted() { }

	public override void OperationCompleted() { }

	public override void Post(SendOrPostCallback callback, object state) { }

	public override SynchronizationContext CreateCopy() { }

	private void Exec() { }

	private bool HasPendingTasks() { }

	[RequiredByNativeCodeAttribute] 
	private static void InitializeSynchronizationContext() { }

	[RequiredByNativeCodeAttribute] 
	private static void ExecuteTasks() { }

	[RequiredByNativeCodeAttribute] 
	private static bool ExecutePendingTasks(long millisecondsTimeout) { }

}

private struct UnitySynchronizationContext.WorkRequest // TypeDefIndex: 3537
{
	private readonly SendOrPostCallback m_DelagateCallback; 
	private readonly object m_DelagateState; 
	private readonly ManualResetEvent m_WaitHandle; 


	public void .ctor(SendOrPostCallback callback, object state, ManualResetEvent waitHandle) { }

	public void Invoke() { }

}

