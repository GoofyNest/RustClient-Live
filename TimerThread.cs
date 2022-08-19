internal static class TimerThread // TypeDefIndex: 2924
{	// Fields
	private static LinkedList<WeakReference> s_Queues; // 0x0
	private static LinkedList<WeakReference> s_NewQueues; // 0x8
	private static int s_ThreadState; // 0x10
	private static AutoResetEvent s_ThreadReadyEvent; // 0x18
	private static ManualResetEvent s_ThreadShutdownEvent; // 0x20
	private static WaitHandle[] s_ThreadEvents; // 0x28
	private static Hashtable s_QueuesCache; // 0x30

	// Methods

	// RVA: 0x10072A0 Offset: 0x10066A0 VA: 0x1810072A0
	private static void .cctor() { }

	// RVA: 0x1006E90 Offset: 0x1006290 VA: 0x181006E90
	internal static TimerThread.Queue CreateQueue(int durationMilliseconds) { }

	// RVA: 0x1007210 Offset: 0x1006610 VA: 0x181007210
	private static void StopTimerThread() { }

	// RVA: 0x1007130 Offset: 0x1006530 VA: 0x181007130
	private static void OnDomainUnload(object sender, EventArgs e) { }

}

internal abstract class TimerThread.Queue // TypeDefIndex: 2925
{	// Fields
	private readonly int m_DurationMilliseconds; // 0x10

	// Methods

	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	internal void .ctor(int durationMilliseconds) { }

}

internal abstract class TimerThread.Timer : IDisposable // TypeDefIndex: 2926
{	// Fields
	private readonly int m_StartTimeMilliseconds; // 0x10
	private readonly int m_DurationMilliseconds; // 0x14

	// Methods

	// RVA: 0x1007550 Offset: 0x1006950 VA: 0x181007550
	internal void .ctor(int durationMilliseconds) { }

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract bool Cancel();

	// RVA: 0x95B120 Offset: 0x95A520 VA: 0x18095B120 Slot: 4
	public void Dispose() { }

}

internal sealed class TimerThread.Callback : MulticastDelegate // TypeDefIndex: 2927
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFF1E70 Offset: 0xFF1270 VA: 0x180FF1E70 Slot: 12
	public virtual void Invoke(TimerThread.Timer timer, int timeNoticed, object context) { }

	// RVA: 0xFF1DE0 Offset: 0xFF11E0 VA: 0x180FF1DE0 Slot: 13
	public virtual IAsyncResult BeginInvoke(TimerThread.Timer timer, int timeNoticed, object context, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private class TimerThread.TimerQueue : TimerThread.Queue // TypeDefIndex: 2928
{	// Fields
	private readonly TimerThread.TimerNode m_Timers; // 0x18

	// Methods

	// RVA: 0x1006DD0 Offset: 0x10061D0 VA: 0x181006DD0
	internal void .ctor(int durationMilliseconds) { }

}

private class TimerThread.InfiniteTimerQueue : TimerThread.Queue // TypeDefIndex: 2929
{	// Methods

	// RVA: 0xFF4190 Offset: 0xFF3590 VA: 0x180FF4190
	internal void .ctor() { }

}

private class TimerThread.TimerNode : TimerThread.Timer // TypeDefIndex: 2930
{	// Fields
	private TimerThread.TimerNode.TimerState m_TimerState; // 0x18
	private TimerThread.Callback m_Callback; // 0x20
	private object m_Context; // 0x28
	private object m_QueueLock; // 0x30
	private TimerThread.TimerNode next; // 0x38
	private TimerThread.TimerNode prev; // 0x40

	// Properties
	internal TimerThread.TimerNode Next { get; set; }
	internal TimerThread.TimerNode Prev { get; set; }

	// Methods

	// RVA: 0x1006DA0 Offset: 0x10061A0 VA: 0x181006DA0
	internal void .ctor() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	internal TimerThread.TimerNode get_Next() { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	internal void set_Next(TimerThread.TimerNode value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	internal TimerThread.TimerNode get_Prev() { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	internal void set_Prev(TimerThread.TimerNode value) { }

	// RVA: 0x1006C20 Offset: 0x1006020 VA: 0x181006C20 Slot: 5
	internal override bool Cancel() { }

}

private enum TimerThread.TimerNode.TimerState // TypeDefIndex: 2931
{	// Fields
	public int value__; // 0x0
	public const TimerThread.TimerNode.TimerState Ready = 0;
	public const TimerThread.TimerNode.TimerState Fired = 1;
	public const TimerThread.TimerNode.TimerState Cancelled = 2;
	public const TimerThread.TimerNode.TimerState Sentinel = 3;

}

