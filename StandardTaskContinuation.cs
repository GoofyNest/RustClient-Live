internal class StandardTaskContinuation : TaskContinuation // TypeDefIndex: 876
{	// Fields
	internal readonly Task m_task; // 0x10
	internal readonly TaskContinuationOptions m_options; // 0x18
	private readonly TaskScheduler m_taskScheduler; // 0x20

	// Methods

	// RVA: 0x1495FE0 Offset: 0x14953E0 VA: 0x181495FE0
	internal void .ctor(Task task, TaskContinuationOptions options, TaskScheduler scheduler) { }

	// RVA: 0x1495ED0 Offset: 0x14952D0 VA: 0x181495ED0 Slot: 4
	internal override void Run(Task completedTask, bool bCanInlineContinuationTask) { }

}

