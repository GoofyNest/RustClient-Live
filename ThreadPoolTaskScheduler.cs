internal sealed class ThreadPoolTaskScheduler : TaskScheduler // TypeDefIndex: 893
{	private static readonly ParameterizedThreadStart s_longRunningThreadWork; // 0x2B0AAB0

	internal override bool RequiresAtomicStartTransition { get; }


	internal void .ctor() { }

	private static void LongRunningThreadWork(object obj) { }

	protected internal override void QueueTask(Task task) { }

	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	protected internal override bool TryDequeue(Task task) { }

	internal override void NotifyWorkItemProgress() { }

	internal override bool get_RequiresAtomicStartTransition() { }

	private static void .cctor() { }

}

