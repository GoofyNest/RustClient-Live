internal sealed class CompletionActionInvoker : IThreadPoolWorkItem // TypeDefIndex: 860
{	// Fields
	private readonly ITaskCompletionAction m_action; // 0x10
	private readonly Task m_completingTask; // 0x18

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	internal void .ctor(ITaskCompletionAction action, Task completingTask) { }

	// RVA: 0x148CF10 Offset: 0x148C310 VA: 0x18148CF10 Slot: 4
	public void ExecuteWorkItem() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	public void MarkAborted(ThreadAbortException tae) { }

}

