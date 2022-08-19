public static class TimedEventsManagingUtilities // TypeDefIndex: 7459
{	// Methods

	[IteratorStateMachineAttribute] // RVA: 0xA2910 Offset: 0xA1D10 VA: 0x1800A2910
	[ExtensionAttribute] // RVA: 0xA2910 Offset: 0xA1D10 VA: 0x1800A2910
	// RVA: 0x21FDEB0 Offset: 0x21FD2B0 VA: 0x1821FDEB0
	internal static IEnumerable<Tuple<TimedEvent, int>> GetTimedEventsLazy(EventsCollection[] eventsCollections, int eventsCount, bool cloneEvent = True) { }

	[IteratorStateMachineAttribute] // RVA: 0xA2AD0 Offset: 0xA1ED0 VA: 0x1800A2AD0
	[ExtensionAttribute] // RVA: 0xA2AD0 Offset: 0xA1ED0 VA: 0x1800A2AD0
	// RVA: 0x21FDF40 Offset: 0x21FD340 VA: 0x1821FDF40
	internal static IEnumerable<TimedEvent> GetTimedEventsLazy(IEnumerable<MidiEvent> events, bool cloneEvent = True) { }

}

private sealed class TimedEventsManagingUtilities.<>c // TypeDefIndex: 7460
{	// Fields
	public static readonly TimedEventsManagingUtilities.<>c <>9; // 0x0
	public static Func<EventsCollection, int> <>9__26_0; // 0x8

	// Methods

	// RVA: 0x21FFFE0 Offset: 0x21FF3E0 VA: 0x1821FFFE0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x21FFED0 Offset: 0x21FF2D0 VA: 0x1821FFED0
	internal int <GetTimedEventsLazy>b__26_0(EventsCollection c) { }

}

private sealed class TimedEventsManagingUtilities.<GetTimedEventsLazy>d__26 : IEnumerable<Tuple<TimedEvent, int>>, IEnumerable, IEnumerator<Tuple<TimedEvent, int>>, IDisposable, IEnumerator // TypeDefIndex: 7461
{	// Fields
	private int <>1__state; // 0x10
	private Tuple<TimedEvent, int> <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private EventsCollection[] eventsCollections; // 0x28
	public EventsCollection[] <>3__eventsCollections; // 0x30
	private bool cloneEvent; // 0x38
	public bool <>3__cloneEvent; // 0x39
	private int eventsCount; // 0x3C
	public int <>3__eventsCount; // 0x40
	private int <eventsCollectionsCount>5__2; // 0x44
	private int[] <eventsCollectionIndices>5__3; // 0x48
	private int[] <eventsCollectionMaxIndices>5__4; // 0x50
	private long[] <eventsCollectionTimes>5__5; // 0x58
	private IEnumerator<TimedEvent> <>7__wrap5; // 0x60
	private int <i>5__7; // 0x68
	private int <eventsCollectionIndex>5__8; // 0x6C
	private long <minTime>5__9; // 0x70

	// Properties
	private Tuple<TimedEvent, int> System.Collections.Generic.IEnumerator<System.Tuple<Melanchall.DryWetMidi.Interaction.TimedEvent,System.Int32>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD824F0 Offset: 0xD818F0 VA: 0x180D824F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21FF960 Offset: 0x21FED60 VA: 0x1821FF960 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x21FF290 Offset: 0x21FE690 VA: 0x1821FF290 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x21FFA10 Offset: 0x21FEE10 VA: 0x1821FFA10
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	private Tuple<TimedEvent, int> System.Collections.Generic.IEnumerator<System.Tuple<Melanchall.DryWetMidi.Interaction.TimedEvent,System.Int32>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21FF910 Offset: 0x21FED10 VA: 0x1821FF910 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21FF860 Offset: 0x21FEC60 VA: 0x1821FF860 Slot: 4
	private IEnumerator<Tuple<TimedEvent, int>> System.Collections.Generic.IEnumerable<System.Tuple<Melanchall.DryWetMidi.Interaction.TimedEvent,System.Int32>>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21FF860 Offset: 0x21FEC60 VA: 0x1821FF860 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

private sealed class TimedEventsManagingUtilities.<GetTimedEventsLazy>d__27 : IEnumerable<TimedEvent>, IEnumerable, IEnumerator<TimedEvent>, IDisposable, IEnumerator // TypeDefIndex: 7462
{	// Fields
	private int <>1__state; // 0x10
	private TimedEvent <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private IEnumerable<MidiEvent> events; // 0x28
	public IEnumerable<MidiEvent> <>3__events; // 0x30
	private bool cloneEvent; // 0x38
	public bool <>3__cloneEvent; // 0x39
	private long <time>5__2; // 0x40
	private IEnumerator<MidiEvent> <>7__wrap2; // 0x48

	// Properties
	private TimedEvent System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.TimedEvent>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD824F0 Offset: 0xD818F0 VA: 0x180D824F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21FFDB0 Offset: 0x21FF1B0 VA: 0x1821FFDB0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x21FFA60 Offset: 0x21FEE60 VA: 0x1821FFA60 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x21FFE60 Offset: 0x21FF260 VA: 0x1821FFE60
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	private TimedEvent System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.TimedEvent>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21FFD60 Offset: 0x21FF160 VA: 0x1821FFD60 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21FFCB0 Offset: 0x21FF0B0 VA: 0x1821FFCB0 Slot: 4
	private IEnumerator<TimedEvent> System.Collections.Generic.IEnumerable<Melanchall.DryWetMidi.Interaction.TimedEvent>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21FFCB0 Offset: 0x21FF0B0 VA: 0x1821FFCB0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

