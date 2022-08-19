internal sealed class ThreadPoolTaskScheduler : TaskScheduler // TypeDefIndex: 893
{	// Fields
	private static readonly ParameterizedThreadStart s_longRunningThreadWork; // 0x2B0AAB0

	// Properties
	internal override bool RequiresAtomicStartTransition { get; }

	// Methods

	// RVA: 0x1605A40 Offset: 0x1604E40 VA: 0x181605A40
	internal void .ctor() { }

	// RVA: 0x1605620 Offset: 0x1604A20 VA: 0x181605620
	private static void LongRunningThreadWork(object obj) { }

	// RVA: 0x1605770 Offset: 0x1604B70 VA: 0x181605770 Slot: 4
	protected internal override void QueueTask(Task task) { }

	// RVA: 0x16058D0 Offset: 0x1604CD0 VA: 0x1816058D0 Slot: 5
	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x16058C0 Offset: 0x1604CC0 VA: 0x1816058C0 Slot: 6
	protected internal override bool TryDequeue(Task task) { }

	// RVA: 0x16056D0 Offset: 0x1604AD0 VA: 0x1816056D0 Slot: 7
	internal override void NotifyWorkItemProgress() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 8
	internal override bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x16059D0 Offset: 0x1604DD0 VA: 0x1816059D0
	private static void .cctor() { }

}

