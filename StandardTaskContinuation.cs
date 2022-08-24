internal class StandardTaskContinuation : TaskContinuation // TypeDefIndex: 876
{
	internal readonly Task m_task; 
	internal readonly TaskContinuationOptions m_options; 
	private readonly TaskScheduler m_taskScheduler; 


	internal void .ctor(Task task, TaskContinuationOptions options, TaskScheduler scheduler) { }

	internal override void Run(Task completedTask, bool bCanInlineContinuationTask) { }

}

