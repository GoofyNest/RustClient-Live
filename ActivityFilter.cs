internal sealed class ActivityFilter : IDisposable // TypeDefIndex: 1614
{
	private ConcurrentDictionary<Guid, int> m_activeActivities;
	private ConcurrentDictionary<Guid, Tuple<Guid, int>> m_rootActiveActivities;
	private Guid m_providerGuid;
	private int m_eventId;
	private int m_samplingFreq;
	private int m_curSampleCount;
	private int m_perEventSourceSessionId;
	private ActivityFilter m_next;
	private Action<Guid> m_myActivityDelegate;


	public static void DisableFilter(ref ActivityFilter filterList, EventSource source) { }

	public static void UpdateFilter(ref ActivityFilter filterList, EventSource source, int perEventSourceSessionId, string startEvents) { }

	public static bool PassesActivityFilter(ActivityFilter filterList, Guid* childActivityID, bool triggeringEvent, EventSource source, int eventId) { }

	public static void FlowActivityIfNeeded(ActivityFilter filterList, Guid* currentActivityId, Guid* childActivityID) { }

	public static void UpdateKwdTriggers(ActivityFilter activityFilter, Guid sourceGuid, EventSource source, EventKeywords sessKeywords) { }

	[IteratorStateMachineAttribute]
	public IEnumerable<Tuple<int, int>> GetFilterAsTuple(Guid sourceGuid) { }

	public void Dispose() { }

	private void .ctor(EventSource source, int perEventSourceSessionId, int eventId, int samplingFreq, ActivityFilter existingFilter) { }

	private static void EnsureActivityCleanupDelegate(ActivityFilter filterList) { }

	private static Action<Guid> GetActivityDyingDelegate(ActivityFilter filterList) { }

	private static bool EnableFilter(ref ActivityFilter filterList, EventSource source, int perEventSourceSessionId, int eventId, int samplingFreq) { }

	private static void TrimActiveActivityStore(ConcurrentDictionary<Guid, int> activities) { }

	private static ConcurrentDictionary<Guid, int> GetActiveActivities(ActivityFilter filterList) { }

}

private sealed class ActivityFilter.<GetFilterAsTuple>d__7 : IEnumerable<Tuple<int, int>>, IEnumerable, IEnumerator<Tuple<int, int>>, IDisposable, IEnumerator // TypeDefIndex: 1615
{
	private int <>1__state;
	private Tuple<int, int> <>2__current;
	private int <>l__initialThreadId;
	public ActivityFilter <>4__this;
	private Guid sourceGuid;
	public Guid <>3__sourceGuid;
	private ActivityFilter <af>5__1;

	private Tuple<int, int> System.Collections.Generic.IEnumerator<System.Tuple<System.Int32,System.Int32>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute]
	private Tuple<int, int> System.Collections.Generic.IEnumerator<System.Tuple<System.Int32,System.Int32>>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute]
	private IEnumerator<Tuple<int, int>> System.Collections.Generic.IEnumerable<System.Tuple<System.Int32,System.Int32>>.GetEnumerator() { }

	[DebuggerHiddenAttribute]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

private sealed class ActivityFilter.<>c__DisplayClass11_0 // TypeDefIndex: 1616
{
	public ActivityFilter filterList;


	public void .ctor() { }

	internal void <GetActivityDyingDelegate>

}

private sealed class ActivityFilter.<>c__DisplayClass13_0 // TypeDefIndex: 1617
{
	public int tickNow;


	public void .ctor() { }

	internal int <TrimActiveActivityStore>

}

