public abstract class TaskScheduler // TypeDefIndex: 886
{
	private static ConditionalWeakTable<TaskScheduler, object> s_activeTaskSchedulers;
	private static readonly TaskScheduler s_defaultTaskScheduler;
	internal static int s_taskSchedulerIdCounter;
	private int m_taskSchedulerId;
	private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException;
	private static readonly object _unobservedTaskExceptionLockObject;

	internal virtual bool RequiresAtomicStartTransition { get; }
	public static TaskScheduler Default { get; }
	public static TaskScheduler Current { get; }
	internal static TaskScheduler InternalCurrent { get; }
	public int Id { get; }


	protected internal abstract void QueueTask(Task task);

	protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);

	internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued) { }

	protected internal virtual bool TryDequeue(Task task) { }

	internal virtual void NotifyWorkItemProgress() { }

	internal virtual bool get_RequiresAtomicStartTransition() { }

	internal void InternalQueueTask(Task task) { }

	protected void .ctor() { }

	private void AddToActiveTaskSchedulers() { }

	public static TaskScheduler get_Default() { }

	public static TaskScheduler get_Current() { }

	internal static TaskScheduler get_InternalCurrent() { }

	public int get_Id() { }

	internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea) { }

	private static void .cctor() { }

}

