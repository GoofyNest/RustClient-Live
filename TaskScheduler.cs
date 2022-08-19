public abstract class TaskScheduler // TypeDefIndex: 886
{	// Fields
	private static ConditionalWeakTable<TaskScheduler, object> s_activeTaskSchedulers; // 0x0
	private static readonly TaskScheduler s_defaultTaskScheduler; // 0x8
	internal static int s_taskSchedulerIdCounter; // 0x10
	private int m_taskSchedulerId; // 0x10
	private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException; // 0x18
	private static readonly object _unobservedTaskExceptionLockObject; // 0x20

	// Properties
	internal virtual bool RequiresAtomicStartTransition { get; }
	public static TaskScheduler Default { get; }
	public static TaskScheduler Current { get; }
	internal static TaskScheduler InternalCurrent { get; }
	public int Id { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected internal abstract void QueueTask(Task task);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);

	// RVA: 0x16045D0 Offset: 0x16039D0 VA: 0x1816045D0
	internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 6
	protected internal virtual bool TryDequeue(Task task) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	internal virtual void NotifyWorkItemProgress() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 8
	internal virtual bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x1604450 Offset: 0x1603850 VA: 0x181604450
	internal void InternalQueueTask(Task task) { }

	// RVA: 0x1604880 Offset: 0x1603C80 VA: 0x181604880
	protected void .ctor() { }

	// RVA: 0x1604360 Offset: 0x1603760 VA: 0x181604360
	private void AddToActiveTaskSchedulers() { }

	// RVA: 0x1604A90 Offset: 0x1603E90 VA: 0x181604A90
	public static TaskScheduler get_Default() { }

	// RVA: 0x16049C0 Offset: 0x1603DC0 VA: 0x1816049C0
	public static TaskScheduler get_Current() { }

	// RVA: 0x1604BA0 Offset: 0x1603FA0 VA: 0x181604BA0
	internal static TaskScheduler get_InternalCurrent() { }

	// RVA: 0x1604AF0 Offset: 0x1603EF0 VA: 0x181604AF0
	public int get_Id() { }

	// RVA: 0x1604480 Offset: 0x1603880 VA: 0x181604480
	internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea) { }

	// RVA: 0x16047E0 Offset: 0x1603BE0 VA: 0x1816047E0
	private static void .cctor() { }

}

