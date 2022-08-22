public sealed class Timer : MarshalByRefObject, IDisposable // TypeDefIndex: 832
{	private static readonly Timer.Scheduler scheduler; // 0x0
	private TimerCallback callback; // 0x18
	private object state; // 0x20
	private long due_time_ms; // 0x28
	private long period_ms; // 0x30
	private long next_run; // 0x38
	private bool disposed; // 0x40
	private const long MaxValue = 4294967294;


	public void .ctor(TimerCallback callback, object state, int dueTime, int period) { }

	public void .ctor(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period) { }

	private void Init(TimerCallback callback, object state, long dueTime, long period) { }

	public bool Change(int dueTime, int period) { }

	public bool Change(TimeSpan dueTime, TimeSpan period) { }

	public void Dispose() { }

	private bool Change(long dueTime, long period, bool first) { }

	internal void KeepRootedWhileScheduled() { }

	private static long GetTimeMonotonic() { }

	private static void .cctor() { }

}

private sealed class Timer.TimerComparer : IComparer // TypeDefIndex: 833
{
	public int Compare(object x, object y) { }

	public void .ctor() { }

}

private sealed class Timer.Scheduler // TypeDefIndex: 834
{	private static Timer.Scheduler instance; // 0x0
	private SortedList list; // 0x10
	private ManualResetEvent changed; // 0x18

	public static Timer.Scheduler Instance { get; }


	private static void .cctor() { }

	public static Timer.Scheduler get_Instance() { }

	private void .ctor() { }

	public void Remove(Timer timer) { }

	public void Change(Timer timer, long new_next_run) { }

	private int FindByDueTime(long nr) { }

	private void Add(Timer timer) { }

	private int InternalRemove(Timer timer) { }

	private static void TimerCB(object o) { }

	private void SchedulerThread() { }

	private void ShrinkIfNeeded(List<Timer> list, int initial) { }

}

