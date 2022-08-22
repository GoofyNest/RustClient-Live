internal sealed class UnitySynchronizationContext : SynchronizationContext // TypeDefIndex: 3536
{	private readonly List<UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue; // 0x18
	private readonly List<UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork; // 0x20
	private readonly int m_MainThreadID; // 0x28
	private int m_TrackedCount; // 0x2C


	private void .ctor(int mainThreadID) { }

	private void .ctor(List<UnitySynchronizationContext.WorkRequest> queue, int mainThreadID) { }

	public override void Send(SendOrPostCallback callback, object state) { }

	public override void OperationStarted() { }

	public override void OperationCompleted() { }

	public override void Post(SendOrPostCallback callback, object state) { }

	public override SynchronizationContext CreateCopy() { }

	private void Exec() { }

	private bool HasPendingTasks() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void InitializeSynchronizationContext() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void ExecuteTasks() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static bool ExecutePendingTasks(long millisecondsTimeout) { }

}

private struct UnitySynchronizationContext.WorkRequest // TypeDefIndex: 3537
{	private readonly SendOrPostCallback m_DelagateCallback; // 0x0
	private readonly object m_DelagateState; // 0x8
	private readonly ManualResetEvent m_WaitHandle; // 0x10


	public void .ctor(SendOrPostCallback callback, object state, ManualResetEvent waitHandle) { }

	public void Invoke() { }

}

