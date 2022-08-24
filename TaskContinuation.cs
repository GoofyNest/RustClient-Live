internal abstract class TaskContinuation // TypeDefIndex: 875
{

	internal abstract void Run(Task completedTask, bool bCanInlineContinuationTask);

	protected static void InlineIfPossibleOrElseQueue(Task task, bool needsProtection) { }

	protected void .ctor() { }

}

