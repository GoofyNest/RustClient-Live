public sealed class Timer : MarshalByRefObject, IDisposable // TypeDefIndex: 832
{	// Fields
	private static readonly Timer.Scheduler scheduler; // 0x0
	private TimerCallback callback; // 0x18
	private object state; // 0x20
	private long due_time_ms; // 0x28
	private long period_ms; // 0x30
	private long next_run; // 0x38
	private bool disposed; // 0x40
	private const long MaxValue = 4294967294;

	// Methods

	// RVA: 0x16159B0 Offset: 0x1614DB0 VA: 0x1816159B0
	public void .ctor(TimerCallback callback, object state, int dueTime, int period) { }

	// RVA: 0x1615A80 Offset: 0x1614E80 VA: 0x181615A80
	public void .ctor(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x1615840 Offset: 0x1614C40 VA: 0x181615840
	private void Init(TimerCallback callback, object state, long dueTime, long period) { }

	// RVA: 0x1615700 Offset: 0x1614B00 VA: 0x181615700
	public bool Change(int dueTime, int period) { }

	// RVA: 0x1615720 Offset: 0x1614B20 VA: 0x181615720
	public bool Change(TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x16157A0 Offset: 0x1614BA0 VA: 0x1816157A0 Slot: 6
	public void Dispose() { }

	// RVA: 0x16154C0 Offset: 0x16148C0 VA: 0x1816154C0
	private bool Change(long dueTime, long period, bool first) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal void KeepRootedWhileScheduled() { }

	// RVA: 0x1615830 Offset: 0x1614C30 VA: 0x181615830
	private static long GetTimeMonotonic() { }

	// RVA: 0x1615900 Offset: 0x1614D00 VA: 0x181615900
	private static void .cctor() { }

}

private sealed class Timer.TimerComparer : IComparer // TypeDefIndex: 833
{	// Methods

	// RVA: 0x1615420 Offset: 0x1614820 VA: 0x181615420 Slot: 4
	public int Compare(object x, object y) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class Timer.Scheduler // TypeDefIndex: 834
{	// Fields
	private static Timer.Scheduler instance; // 0x0
	private SortedList list; // 0x10
	private ManualResetEvent changed; // 0x18

	// Properties
	public static Timer.Scheduler Instance { get; }

	// Methods

	// RVA: 0x1601EF0 Offset: 0x16012F0 VA: 0x181601EF0
	private static void .cctor() { }

	// RVA: 0x1602120 Offset: 0x1601520 VA: 0x181602120
	public static Timer.Scheduler get_Instance() { }

	// RVA: 0x1601F50 Offset: 0x1601350 VA: 0x181601F50
	private void .ctor() { }

	// RVA: 0x1601740 Offset: 0x1600B40 VA: 0x181601740
	public void Remove(Timer timer) { }

	// RVA: 0x16013C0 Offset: 0x16007C0 VA: 0x1816013C0
	public void Change(Timer timer, long new_next_run) { }

	// RVA: 0x1601580 Offset: 0x1600980 VA: 0x181601580
	private int FindByDueTime(long nr) { }

	// RVA: 0x1601270 Offset: 0x1600670 VA: 0x181601270
	private void Add(Timer timer) { }

	// RVA: 0x16016E0 Offset: 0x1600AE0 VA: 0x1816016E0
	private int InternalRemove(Timer timer) { }

	// RVA: 0x1601E80 Offset: 0x1601280 VA: 0x181601E80
	private static void TimerCB(object o) { }

	// RVA: 0x1601820 Offset: 0x1600C20 VA: 0x181601820
	private void SchedulerThread() { }

	// RVA: 0x1601E00 Offset: 0x1601200 VA: 0x181601E00
	private void ShrinkIfNeeded(List<Timer> list, int initial) { }

}

