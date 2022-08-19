internal abstract class TaskContinuation // TypeDefIndex: 875
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void Run(Task completedTask, bool bCanInlineContinuationTask);

	// RVA: 0x16022E0 Offset: 0x16016E0 VA: 0x1816022E0
	protected static void InlineIfPossibleOrElseQueue(Task task, bool needsProtection) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

