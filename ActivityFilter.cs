internal sealed class ActivityFilter : IDisposable // TypeDefIndex: 1614
{	// Fields
	private ConcurrentDictionary<Guid, int> m_activeActivities; // 0x10
	private ConcurrentDictionary<Guid, Tuple<Guid, int>> m_rootActiveActivities; // 0x18
	private Guid m_providerGuid; // 0x20
	private int m_eventId; // 0x30
	private int m_samplingFreq; // 0x34
	private int m_curSampleCount; // 0x38
	private int m_perEventSourceSessionId; // 0x3C
	private ActivityFilter m_next; // 0x40
	private Action<Guid> m_myActivityDelegate; // 0x48

	// Methods

	// RVA: 0xD60680 Offset: 0xD5FA80 VA: 0x180D60680
	public static void DisableFilter(ref ActivityFilter filterList, EventSource source) { }

	// RVA: 0xD61590 Offset: 0xD60990 VA: 0x180D61590
	public static void UpdateFilter(ref ActivityFilter filterList, EventSource source, int perEventSourceSessionId, string startEvents) { }

	// RVA: 0xD61050 Offset: 0xD60450 VA: 0x180D61050
	public static bool PassesActivityFilter(ActivityFilter filterList, Guid* childActivityID, bool triggeringEvent, EventSource source, int eventId) { }

	// RVA: 0xD60C90 Offset: 0xD60090 VA: 0x180D60C90
	public static void FlowActivityIfNeeded(ActivityFilter filterList, Guid* currentActivityId, Guid* childActivityID) { }

	// RVA: 0xD618C0 Offset: 0xD60CC0 VA: 0x180D618C0
	public static void UpdateKwdTriggers(ActivityFilter activityFilter, Guid sourceGuid, EventSource source, EventKeywords sessKeywords) { }

	[IteratorStateMachineAttribute] // RVA: 0x76E60 Offset: 0x76260 VA: 0x180076E60
	// RVA: 0xD60FC0 Offset: 0xD603C0 VA: 0x180D60FC0
	public IEnumerable<Tuple<int, int>> GetFilterAsTuple(Guid sourceGuid) { }

	// RVA: 0xD609D0 Offset: 0xD5FDD0 VA: 0x180D609D0 Slot: 4
	public void Dispose() { }

	// RVA: 0xD61A50 Offset: 0xD60E50 VA: 0x180D61A50
	private void .ctor(EventSource source, int perEventSourceSessionId, int eventId, int samplingFreq, ActivityFilter existingFilter) { }

	// RVA: 0xD60BA0 Offset: 0xD5FFA0 VA: 0x180D60BA0
	private static void EnsureActivityCleanupDelegate(ActivityFilter filterList) { }

	// RVA: 0xD60F20 Offset: 0xD60320 VA: 0x180D60F20
	private static Action<Guid> GetActivityDyingDelegate(ActivityFilter filterList) { }

	// RVA: 0xD60AA0 Offset: 0xD5FEA0 VA: 0x180D60AA0
	private static bool EnableFilter(ref ActivityFilter filterList, EventSource source, int perEventSourceSessionId, int eventId, int samplingFreq) { }

	// RVA: 0xD61440 Offset: 0xD60840 VA: 0x180D61440
	private static void TrimActiveActivityStore(ConcurrentDictionary<Guid, int> activities) { }

	// RVA: 0xD60F00 Offset: 0xD60300 VA: 0x180D60F00
	private static ConcurrentDictionary<Guid, int> GetActiveActivities(ActivityFilter filterList) { }

}

private sealed class ActivityFilter.<GetFilterAsTuple>d__7 : IEnumerable<Tuple<int, int>>, IEnumerable, IEnumerator<Tuple<int, int>>, IDisposable, IEnumerator // TypeDefIndex: 1615
{	// Fields
	private int <>1__state; // 0x10
	private Tuple<int, int> <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public ActivityFilter <>4__this; // 0x28
	private Guid sourceGuid; // 0x30
	public Guid <>3__sourceGuid; // 0x40
	private ActivityFilter <af>5__1; // 0x50

	// Properties
	private Tuple<int, int> System.Collections.Generic.IEnumerator<System.Tuple<System.Int32,System.Int32>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD824F0 Offset: 0xD818F0 VA: 0x180D824F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0xD822B0 Offset: 0xD816B0 VA: 0x180D822B0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	private Tuple<int, int> System.Collections.Generic.IEnumerator<System.Tuple<System.Int32,System.Int32>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD824A0 Offset: 0xD818A0 VA: 0x180D824A0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD823F0 Offset: 0xD817F0 VA: 0x180D823F0 Slot: 4
	private IEnumerator<Tuple<int, int>> System.Collections.Generic.IEnumerable<System.Tuple<System.Int32,System.Int32>>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD823F0 Offset: 0xD817F0 VA: 0x180D823F0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

private sealed class ActivityFilter.<>c__DisplayClass11_0 // TypeDefIndex: 1616
{	// Fields
	public ActivityFilter filterList; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xD825E0 Offset: 0xD819E0 VA: 0x180D825E0
	internal void <GetActivityDyingDelegate>b__0(Guid oldActivity) { }

}

private sealed class ActivityFilter.<>c__DisplayClass13_0 // TypeDefIndex: 1617
{	// Fields
	public int tickNow; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xD82690 Offset: 0xD81A90 VA: 0x180D82690
	internal int <TrimActiveActivityStore>b__0(KeyValuePair<Guid, int> x, KeyValuePair<Guid, int> y) { }

}

