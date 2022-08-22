internal class StandardTaskContinuation : TaskContinuation // TypeDefIndex: 876
{	internal readonly Task m_task; // 0x10
	internal readonly TaskContinuationOptions m_options; // 0x18
	private readonly TaskScheduler m_taskScheduler; // 0x20


	internal void .ctor(Task task, TaskContinuationOptions options, TaskScheduler scheduler) { }

	internal override void Run(Task completedTask, bool bCanInlineContinuationTask) { }

}

