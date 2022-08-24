internal sealed class CompletionActionInvoker : IThreadPoolWorkItem // TypeDefIndex: 860
{
	private readonly ITaskCompletionAction m_action; 
	private readonly Task m_completingTask; 


internal void .ctor(ITaskCompletionAction action, Task completingTask) { }

public void ExecuteWorkItem() { }

public void MarkAborted(ThreadAbortException tae) { }

}

