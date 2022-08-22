internal sealed class CompletionActionInvoker : IThreadPoolWorkItem // TypeDefIndex: 860
{	private readonly ITaskCompletionAction m_action; // 0x10
	private readonly Task m_completingTask; // 0x18


	internal void .ctor(ITaskCompletionAction action, Task completingTask) { }

	public void ExecuteWorkItem() { }

	public void MarkAborted(ThreadAbortException tae) { }

}

