public struct TaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 1290
{	// Fields
	private readonly Task m_task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0xF1380 Offset: 0xF0780 VA: 0x1800F1380
	internal void .ctor(Task task) { }

	// RVA: 0x14BF50 Offset: 0x14B350 VA: 0x18014BF50
	public bool get_IsCompleted() { }

	// RVA: 0x14C890 Offset: 0x14BC90 VA: 0x18014C890 Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0x14C8C0 Offset: 0x14BCC0 VA: 0x18014C8C0 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x14BEE0 Offset: 0x14B2E0 VA: 0x18014BEE0
	public void GetResult() { }

	// RVA: 0xFF0E60 Offset: 0xFF0260 VA: 0x180FF0E60
	internal static void ValidateEnd(Task task) { }

	// RVA: 0xFF0AB0 Offset: 0xFEFEB0 VA: 0x180FF0AB0
	private static void HandleNonSuccessAndDebuggerNotification(Task task) { }

	// RVA: 0xFF0D10 Offset: 0xFF0110 VA: 0x180FF0D10
	private static void ThrowForNonSuccess(Task task) { }

	// RVA: 0xFF0C10 Offset: 0xFF0010 VA: 0x180FF0C10
	internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext) { }

}

