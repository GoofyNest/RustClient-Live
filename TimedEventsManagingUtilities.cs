public static class TimedEventsManagingUtilities // TypeDefIndex: 7477
{

	[IteratorStateMachineAttribute]
	[ExtensionAttribute]
	internal static IEnumerable<Tuple<TimedEvent, int>> GetTimedEventsLazy(EventsCollection[] eventsCollections, int eventsCount, bool cloneEvent = True) { }

	[IteratorStateMachineAttribute]
	[ExtensionAttribute]
	internal static IEnumerable<TimedEvent> GetTimedEventsLazy(IEnumerable<MidiEvent> events, bool cloneEvent = True) { }

}

private sealed class TimedEventsManagingUtilities.<>c // TypeDefIndex: 7478
{
	public static readonly TimedEventsManagingUtilities.<>c <>9;
	public static Func<EventsCollection, int> <>9__26_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal int <GetTimedEventsLazy>

}

private sealed class TimedEventsManagingUtilities.<GetTimedEventsLazy>d__26 : IEnumerable<Tuple<TimedEvent, int>>, IEnumerable, IEnumerator<Tuple<TimedEvent, int>>, IDisposable, IEnumerator // TypeDefIndex: 7479
{
	private int <>1__state;
	private Tuple<TimedEvent, int> <>2__current;
	private int <>l__initialThreadId;
	private EventsCollection[] eventsCollections;
	public EventsCollection[] <>3__eventsCollections;
	private bool cloneEvent;
	public bool <>3__cloneEvent;
	private int eventsCount;
	public int <>3__eventsCount;
	private int <eventsCollectionsCount>5__2;
	private int[] <eventsCollectionIndices>5__3;
	private int[] <eventsCollectionMaxIndices>5__4;
	private long[] <eventsCollectionTimes>5__5;
	private IEnumerator<TimedEvent> <>7__wrap5;
	private int <i>5__7;
	private int <eventsCollectionIndex>5__8;
	private long <minTime>5__9;

	private Tuple<TimedEvent, int> System.Collections.Generic.IEnumerator<System.Tuple<Melanchall.DryWetMidi.Interaction.TimedEvent,System.Int32>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute]
	private Tuple<TimedEvent, int> System.Collections.Generic.IEnumerator<System.Tuple<Melanchall.DryWetMidi.Interaction.TimedEvent,System.Int32>>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute]
	private IEnumerator<Tuple<TimedEvent, int>> System.Collections.Generic.IEnumerable<System.Tuple<Melanchall.DryWetMidi.Interaction.TimedEvent,System.Int32>>.GetEnumerator() { }

	[DebuggerHiddenAttribute]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

private sealed class TimedEventsManagingUtilities.<GetTimedEventsLazy>d__27 : IEnumerable<TimedEvent>, IEnumerable, IEnumerator<TimedEvent>, IDisposable, IEnumerator // TypeDefIndex: 7480
{
	private int <>1__state;
	private TimedEvent <>2__current;
	private int <>l__initialThreadId;
	private IEnumerable<MidiEvent> events;
	public IEnumerable<MidiEvent> <>3__events;
	private bool cloneEvent;
	public bool <>3__cloneEvent;
	private long <time>5__2;
	private IEnumerator<MidiEvent> <>7__wrap2;

	private TimedEvent System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.TimedEvent>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute]
	private TimedEvent System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.TimedEvent>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute]
	private IEnumerator<TimedEvent> System.Collections.Generic.IEnumerable<Melanchall.DryWetMidi.Interaction.TimedEvent>.GetEnumerator() { }

	[DebuggerHiddenAttribute]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

