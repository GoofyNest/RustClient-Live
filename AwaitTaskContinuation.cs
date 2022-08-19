internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem // TypeDefIndex: 881
{	// Fields
	private readonly ExecutionContext m_capturedContext; // 0x10
	protected readonly Action m_action; // 0x18
	private static ContextCallback s_invokeActionCallback; // 0x0

	// Properties
	internal static bool IsValidLocationForInlining { get; }

	// Methods

	// RVA: 0x148A610 Offset: 0x1489A10 VA: 0x18148A610
	internal void .ctor(Action action, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x148A570 Offset: 0x1489970 VA: 0x18148A570
	internal void .ctor(Action action, bool flowExecutionContext) { }

	// RVA: 0x1489BB0 Offset: 0x1488FB0 VA: 0x181489BB0
	protected Task CreateTask(Action<object> action, object state, TaskScheduler scheduler) { }

	// RVA: 0x148A290 Offset: 0x1489690 VA: 0x18148A290 Slot: 4
	internal override void Run(Task task, bool canInlineContinuationTask) { }

	// RVA: 0x148A6C0 Offset: 0x1489AC0 VA: 0x18148A6C0
	internal static bool get_IsValidLocationForInlining() { }

	// RVA: 0x1489CF0 Offset: 0x14890F0 VA: 0x181489CF0
	private void ExecuteWorkItemHelper() { }

	// RVA: 0x148A350 Offset: 0x1489750 VA: 0x18148A350 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x1489F40 Offset: 0x1489340 VA: 0x181489F40
	private static void InvokeAction(object state) { }

	// RVA: 0x1489E00 Offset: 0x1489200 VA: 0x181489E00
	protected static ContextCallback GetInvokeActionCallback() { }

	// RVA: 0x1489FA0 Offset: 0x14893A0 VA: 0x181489FA0
	protected void RunCallback(ContextCallback callback, object state, ref Task currentTask) { }

	// RVA: 0x148A130 Offset: 0x1489530 VA: 0x18148A130
	internal static void RunOrScheduleAction(Action action, bool allowInlining, ref Task currentTask) { }

	// RVA: 0x148A4E0 Offset: 0x14898E0 VA: 0x18148A4E0
	internal static void UnsafeScheduleAction(Action action, Task task) { }

	// RVA: 0x148A380 Offset: 0x1489780 VA: 0x18148A380
	protected static void ThrowAsyncIfNecessary(Exception exc) { }

}

private sealed class AwaitTaskContinuation.<>c // TypeDefIndex: 882
{	// Fields
	public static readonly AwaitTaskContinuation.<>c <>9; // 0x0
	public static WaitCallback <>9__17_0; // 0x8

	// Methods

	// RVA: 0x149ED50 Offset: 0x149E150 VA: 0x18149ED50
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x149EBD0 Offset: 0x149DFD0 VA: 0x18149EBD0
	internal void <ThrowAsyncIfNecessary>b__17_0(object s) { }

}

