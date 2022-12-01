internal static class TimerThread // TypeDefIndex: 2924
{
	private static LinkedList<WeakReference> s_Queues;
	private static LinkedList<WeakReference> s_NewQueues;
	private static int s_ThreadState;
	private static AutoResetEvent s_ThreadReadyEvent;
	private static ManualResetEvent s_ThreadShutdownEvent;
	private static WaitHandle[] s_ThreadEvents;
	private static Hashtable s_QueuesCache;


	private static void .cctor() { }

	internal static TimerThread.Queue CreateQueue(int durationMilliseconds) { }

	private static void StopTimerThread() { }

	private static void OnDomainUnload(object sender, EventArgs e) { }

}

internal abstract class TimerThread.Queue // TypeDefIndex: 2925
{
	private readonly int m_DurationMilliseconds;


	internal void .ctor(int durationMilliseconds) { }

}

internal abstract class TimerThread.Timer : IDisposable // TypeDefIndex: 2926
{
	private readonly int m_StartTimeMilliseconds;
	private readonly int m_DurationMilliseconds;


	internal void .ctor(int durationMilliseconds) { }

	internal abstract bool Cancel();

	public void Dispose() { }

}

internal sealed class TimerThread.Callback : MulticastDelegate // TypeDefIndex: 2927
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(TimerThread.Timer timer, int timeNoticed, object context) { }

	public virtual IAsyncResult BeginInvoke(TimerThread.Timer timer, int timeNoticed, object context, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

private class TimerThread.TimerQueue : TimerThread.Queue // TypeDefIndex: 2928
{
	private readonly TimerThread.TimerNode m_Timers;


	internal void .ctor(int durationMilliseconds) { }

}

private class TimerThread.InfiniteTimerQueue : TimerThread.Queue // TypeDefIndex: 2929
{

	internal void .ctor() { }

}

private class TimerThread.TimerNode : TimerThread.Timer // TypeDefIndex: 2930
{
	private TimerThread.TimerNode.TimerState m_TimerState;
	private TimerThread.Callback m_Callback;
	private object m_Context;
	private object m_QueueLock;
	private TimerThread.TimerNode next;
	private TimerThread.TimerNode prev;

	internal TimerThread.TimerNode Next { get; set; }
	internal TimerThread.TimerNode Prev { get; set; }


	internal void .ctor() { }

	internal TimerThread.TimerNode get_Next() { }

	internal void set_Next(TimerThread.TimerNode value) { }

	internal TimerThread.TimerNode get_Prev() { }

	internal void set_Prev(TimerThread.TimerNode value) { }

	internal override bool Cancel() { }

}

private enum TimerThread.TimerNode.TimerState // TypeDefIndex: 2931
{
	public int value__;
	public const TimerThread.TimerNode.TimerState Ready = 0;
	public const TimerThread.TimerNode.TimerState Fired = 1;
	public const TimerThread.TimerNode.TimerState Cancelled = 2;
	public const TimerThread.TimerNode.TimerState Sentinel = 3;

}

