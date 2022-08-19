internal sealed class UnitySynchronizationContext : SynchronizationContext // TypeDefIndex: 3536
{	// Fields
	private readonly List<UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue; // 0x18
	private readonly List<UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork; // 0x20
	private readonly int m_MainThreadID; // 0x28
	private int m_TrackedCount; // 0x2C

	// Methods

	// RVA: 0x217C2E0 Offset: 0x217B6E0 VA: 0x18217C2E0
	private void .ctor(int mainThreadID) { }

	// RVA: 0x217C230 Offset: 0x217B630 VA: 0x18217C230
	private void .ctor(List<UnitySynchronizationContext.WorkRequest> queue, int mainThreadID) { }

	// RVA: 0x217BFD0 Offset: 0x217B3D0 VA: 0x18217BFD0 Slot: 4
	public override void Send(SendOrPostCallback callback, object state) { }

	// RVA: 0x217BE80 Offset: 0x217B280 VA: 0x18217BE80 Slot: 6
	public override void OperationStarted() { }

	// RVA: 0x217BE70 Offset: 0x217B270 VA: 0x18217BE70 Slot: 7
	public override void OperationCompleted() { }

	// RVA: 0x217BE90 Offset: 0x217B290 VA: 0x18217BE90 Slot: 5
	public override void Post(SendOrPostCallback callback, object state) { }

	// RVA: 0x217B8F0 Offset: 0x217ACF0 VA: 0x18217B8F0 Slot: 8
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x217B9C0 Offset: 0x217ADC0 VA: 0x18217B9C0
	private void Exec() { }

	// RVA: 0x217BD00 Offset: 0x217B100 VA: 0x18217BD00
	private bool HasPendingTasks() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x217BD60 Offset: 0x217B160 VA: 0x18217BD60
	private static void InitializeSynchronizationContext() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x217BCB0 Offset: 0x217B0B0 VA: 0x18217BCB0
	private static void ExecuteTasks() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x217BB70 Offset: 0x217AF70 VA: 0x18217BB70
	private static bool ExecutePendingTasks(long millisecondsTimeout) { }

}

private struct UnitySynchronizationContext.WorkRequest // TypeDefIndex: 3537
{	// Fields
	private readonly SendOrPostCallback m_DelagateCallback; // 0x0
	private readonly object m_DelagateState; // 0x8
	private readonly ManualResetEvent m_WaitHandle; // 0x10

	// Methods

	// RVA: 0xF5B60 Offset: 0xF4F60 VA: 0x1800F5B60
	public void .ctor(SendOrPostCallback callback, object state, ManualResetEvent waitHandle) { }

	// RVA: 0x2369D0 Offset: 0x235DD0 VA: 0x1802369D0
	public void Invoke() { }

}

