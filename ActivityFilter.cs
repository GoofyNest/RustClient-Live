internal sealed class ActivityFilter : IDisposable // TypeDefIndex: 1614
{	private ConcurrentDictionary<Guid, int> m_activeActivities; // 0x10
	private ConcurrentDictionary<Guid, Tuple<Guid, int>> m_rootActiveActivities; // 0x18
	private Guid m_providerGuid; // 0x20
	private int m_eventId; // 0x30
	private int m_samplingFreq; // 0x34
	private int m_curSampleCount; // 0x38
	private int m_perEventSourceSessionId; // 0x3C
	private ActivityFilter m_next; // 0x40
	private Action<Guid> m_myActivityDelegate; // 0x48


	public static void DisableFilter(ref ActivityFilter filterList, EventSource source) { }

	public static void UpdateFilter(ref ActivityFilter filterList, EventSource source, int perEventSourceSessionId, string startEvents) { }

	public static bool PassesActivityFilter(ActivityFilter filterList, Guid* childActivityID, bool triggeringEvent, EventSource source, int eventId) { }

	public static void FlowActivityIfNeeded(ActivityFilter filterList, Guid* currentActivityId, Guid* childActivityID) { }

	public static void UpdateKwdTriggers(ActivityFilter activityFilter, Guid sourceGuid, EventSource source, EventKeywords sessKeywords) { }

	[IteratorStateMachineAttribute] // RVA: 0x76E60 Offset: 0x76260 VA: 0x180076E60
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
{	private int <>1__state; // 0x10
	private Tuple<int, int> <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public ActivityFilter <>4__this; // 0x28
	private Guid sourceGuid; // 0x30
	public Guid <>3__sourceGuid; // 0x40
	private ActivityFilter <af>5__1; // 0x50

	private Tuple<int, int> System.Collections.Generic.IEnumerator<System.Tuple<System.Int32,System.Int32>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Tuple<int, int> System.Collections.Generic.IEnumerator<System.Tuple<System.Int32,System.Int32>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IEnumerator<Tuple<int, int>> System.Collections.Generic.IEnumerable<System.Tuple<System.Int32,System.Int32>>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

private sealed class ActivityFilter.<>c__DisplayClass11_0 // TypeDefIndex: 1616
{	public ActivityFilter filterList; // 0x10


	public void .ctor() { }

	internal void <GetActivityDyingDelegate>b__0(Guid oldActivity) { }

}

private sealed class ActivityFilter.<>c__DisplayClass13_0 // TypeDefIndex: 1617
{	public int tickNow; // 0x10


	public void .ctor() { }

	internal int <TrimActiveActivityStore>b__0(KeyValuePair<Guid, int> x, KeyValuePair<Guid, int> y) { }

}

