internal sealed class NotesBuilder // TypeDefIndex: 7458
{
	private readonly NoteDetectionSettings _noteDetectionSettings;


	public void .ctor(NoteDetectionSettings noteDetectionSettings) { }

	[IteratorStateMachineAttribute]
	public IEnumerable<Note> GetNotesLazy(IEnumerable<TimedEvent> timedEvents, bool collectTimedEvents = False, List<TimedEvent> collectedTimedEvents) { }

	[IteratorStateMachineAttribute]
	public IEnumerable<Note> GetNotesLazy(IEnumerable<Tuple<TimedEvent, int>> timedEvents, bool collectTimedEvents = False, List<Tuple<TimedEvent, int>> collectedTimedEvents) { }

	private static int GetNoteEventId(NoteEvent noteEvent) { }

}

private class NotesBuilder.NoteDescriptor // TypeDefIndex: 7459
{
	[CompilerGeneratedAttribute]
	private readonly TimedEvent <NoteOnTimedEvent>k__BackingField;
	[CompilerGeneratedAttribute]
	private TimedEvent <NoteOffTimedEvent>k__BackingField;

	public TimedEvent NoteOnTimedEvent { get; }
	public TimedEvent NoteOffTimedEvent { get; set; }
	public bool IsCompleted { get; }


	public void .ctor(TimedEvent noteOnTimedEvent) { }

	[CompilerGeneratedAttribute]
	public TimedEvent get_NoteOnTimedEvent() { }

	[CompilerGeneratedAttribute]
	public TimedEvent get_NoteOffTimedEvent() { }

	[CompilerGeneratedAttribute]
	public void set_NoteOffTimedEvent(TimedEvent value) { }

	public bool get_IsCompleted() { }

	public Note GetNote() { }

}

private abstract class NotesBuilder.NoteOnsHolderBase<TDescriptor> // TypeDefIndex: 7460
{
	private readonly NoteStartDetectionPolicy _noteStartDetectionPolicy;
	private readonly Stack<LinkedListNode<TDescriptor>> _nodesStack;
	private readonly Queue<LinkedListNode<TDescriptor>> _nodesQueue;

	public int Count { get; }


	public void .ctor(NoteStartDetectionPolicy noteStartDetectionPolicy) { }
	/* GenericInstMethod :
	|
	|-NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor>..ctor
	|-NotesBuilder.NoteOnsHolderBase<object>..ctor
	*/

	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor>.get_Count
	|-NotesBuilder.NoteOnsHolderBase<object>.get_Count
	*/

	public void Add(LinkedListNode<TDescriptor> noteOnNode) { }
	/* GenericInstMethod :
	|
	|-NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor>.Add
	|-NotesBuilder.NoteOnsHolderBase<object>.Add
	*/

	public LinkedListNode<TDescriptor> GetNext() { }
	/* GenericInstMethod :
	|
	|-NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor>.GetNext
	|-NotesBuilder.NoteOnsHolderBase<object>.GetNext
	*/

}

private sealed class NotesBuilder.NoteOnsHolder : NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor> // TypeDefIndex: 7461
{

	public void .ctor(NoteStartDetectionPolicy noteStartDetectionPolicy) { }

}

private sealed class NotesBuilder.<GetNotesLazy>d__7 : IEnumerable<Note>, IEnumerable, IEnumerator<Note>, IDisposable, IEnumerator // TypeDefIndex: 7462
{
	private int <>1__state;
	private Note <>2__current;
	private int <>l__initialThreadId;
	private IEnumerable<TimedEvent> timedEvents;
	public IEnumerable<TimedEvent> <>3__timedEvents;
	private bool collectTimedEvents;
	public bool <>3__collectTimedEvents;
	private List<TimedEvent> collectedTimedEvents;
	public List<TimedEvent> <>3__collectedTimedEvents;
	public NotesBuilder <>4__this;
	private LinkedList<NotesBuilder.NoteDescriptor> <notesDescriptors>5__2;
	private Dictionary<int, NotesBuilder.NoteOnsHolder> <notesDescriptorsNodes>5__3;
	private IEnumerator<TimedEvent> <>7__wrap3;
	private LinkedListNode<NotesBuilder.NoteDescriptor> <n>5__5;
	private LinkedList.Enumerator<NotesBuilder.NoteDescriptor> <>7__wrap5;

	private Note System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.Note>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	private void <>m__Finally2() { }

	[DebuggerHiddenAttribute]
	private Note System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.Note>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute]
	private IEnumerator<Note> System.Collections.Generic.IEnumerable<Melanchall.DryWetMidi.Interaction.Note>.GetEnumerator() { }

	[DebuggerHiddenAttribute]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

private sealed class NotesBuilder.<GetNotesLazy>d__8 : IEnumerable<Note>, IEnumerable, IEnumerator<Note>, IDisposable, IEnumerator // TypeDefIndex: 7463
{
	private int <>1__state;
	private Note <>2__current;
	private int <>l__initialThreadId;
	public NotesBuilder <>4__this;
	private IEnumerable<Tuple<TimedEvent, int>> timedEvents;
	public IEnumerable<Tuple<TimedEvent, int>> <>3__timedEvents;
	private bool collectTimedEvents;
	public bool <>3__collectTimedEvents;
	private List<Tuple<TimedEvent, int>> collectedTimedEvents;
	public List<Tuple<TimedEvent, int>> <>3__collectedTimedEvents;
	private LinkedList<NotesBuilder.NoteDescriptor> <notesDescriptors>5__2;
	private Dictionary<Tuple<int, int>, NotesBuilder.NoteOnsHolder> <notesDescriptorsNodes>5__3;
	private bool <respectEventsCollectionIndex>5__4;
	private IEnumerator<Tuple<TimedEvent, int>> <>7__wrap4;
	private LinkedListNode<NotesBuilder.NoteDescriptor> <n>5__6;
	private LinkedList.Enumerator<NotesBuilder.NoteDescriptor> <>7__wrap6;

	private Note System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.Note>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	private void <>m__Finally2() { }

	[DebuggerHiddenAttribute]
	private Note System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.Note>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute]
	private IEnumerator<Note> System.Collections.Generic.IEnumerable<Melanchall.DryWetMidi.Interaction.Note>.GetEnumerator() { }

	[DebuggerHiddenAttribute]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

