internal sealed class NotesBuilder // TypeDefIndex: 7440
{	private readonly NoteDetectionSettings _noteDetectionSettings; // 0x10


	public void .ctor(NoteDetectionSettings noteDetectionSettings) { }

	[IteratorStateMachineAttribute] // RVA: 0x9ECB0 Offset: 0x9E0B0 VA: 0x18009ECB0
	public IEnumerable<Note> GetNotesLazy(IEnumerable<TimedEvent> timedEvents, bool collectTimedEvents = False, List<TimedEvent> collectedTimedEvents) { }

	[IteratorStateMachineAttribute] // RVA: 0x9EE00 Offset: 0x9E200 VA: 0x18009EE00
	public IEnumerable<Note> GetNotesLazy(IEnumerable<Tuple<TimedEvent, int>> timedEvents, bool collectTimedEvents = False, List<Tuple<TimedEvent, int>> collectedTimedEvents) { }

	private static int GetNoteEventId(NoteEvent noteEvent) { }

}

private class NotesBuilder.NoteDescriptor // TypeDefIndex: 7441
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly TimedEvent <NoteOnTimedEvent>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TimedEvent <NoteOffTimedEvent>k__BackingField; // 0x18

	public TimedEvent NoteOnTimedEvent { get; }
	public TimedEvent NoteOffTimedEvent { get; set; }
	public bool IsCompleted { get; }


	public void .ctor(TimedEvent noteOnTimedEvent) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public TimedEvent get_NoteOnTimedEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public TimedEvent get_NoteOffTimedEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_NoteOffTimedEvent(TimedEvent value) { }

	public bool get_IsCompleted() { }

	public Note GetNote() { }

}

private abstract class NotesBuilder.NoteOnsHolderBase<TDescriptor> // TypeDefIndex: 7442
{	private readonly NoteStartDetectionPolicy _noteStartDetectionPolicy; // 0x0
	private readonly Stack<LinkedListNode<TDescriptor>> _nodesStack; // 0x0
	private readonly Queue<LinkedListNode<TDescriptor>> _nodesQueue; // 0x0

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

private sealed class NotesBuilder.NoteOnsHolder : NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor> // TypeDefIndex: 7443
{
	public void .ctor(NoteStartDetectionPolicy noteStartDetectionPolicy) { }

}

private sealed class NotesBuilder.<GetNotesLazy>d__7 : IEnumerable<Note>, IEnumerable, IEnumerator<Note>, IDisposable, IEnumerator // TypeDefIndex: 7444
{	private int <>1__state; // 0x10
	private Note <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private IEnumerable<TimedEvent> timedEvents; // 0x28
	public IEnumerable<TimedEvent> <>3__timedEvents; // 0x30
	private bool collectTimedEvents; // 0x38
	public bool <>3__collectTimedEvents; // 0x39
	private List<TimedEvent> collectedTimedEvents; // 0x40
	public List<TimedEvent> <>3__collectedTimedEvents; // 0x48
	public NotesBuilder <>4__this; // 0x50
	private LinkedList<NotesBuilder.NoteDescriptor> <notesDescriptors>5__2; // 0x58
	private Dictionary<int, NotesBuilder.NoteOnsHolder> <notesDescriptorsNodes>5__3; // 0x60
	private IEnumerator<TimedEvent> <>7__wrap3; // 0x68
	private LinkedListNode<NotesBuilder.NoteDescriptor> <n>5__5; // 0x70
	private LinkedList.Enumerator<NotesBuilder.NoteDescriptor> <>7__wrap5; // 0x78

	private Note System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.Note>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	private void <>m__Finally2() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Note System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.Note>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IEnumerator<Note> System.Collections.Generic.IEnumerable<Melanchall.DryWetMidi.Interaction.Note>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

private sealed class NotesBuilder.<GetNotesLazy>d__8 : IEnumerable<Note>, IEnumerable, IEnumerator<Note>, IDisposable, IEnumerator // TypeDefIndex: 7445
{	private int <>1__state; // 0x10
	private Note <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public NotesBuilder <>4__this; // 0x28
	private IEnumerable<Tuple<TimedEvent, int>> timedEvents; // 0x30
	public IEnumerable<Tuple<TimedEvent, int>> <>3__timedEvents; // 0x38
	private bool collectTimedEvents; // 0x40
	public bool <>3__collectTimedEvents; // 0x41
	private List<Tuple<TimedEvent, int>> collectedTimedEvents; // 0x48
	public List<Tuple<TimedEvent, int>> <>3__collectedTimedEvents; // 0x50
	private LinkedList<NotesBuilder.NoteDescriptor> <notesDescriptors>5__2; // 0x58
	private Dictionary<Tuple<int, int>, NotesBuilder.NoteOnsHolder> <notesDescriptorsNodes>5__3; // 0x60
	private bool <respectEventsCollectionIndex>5__4; // 0x68
	private IEnumerator<Tuple<TimedEvent, int>> <>7__wrap4; // 0x70
	private LinkedListNode<NotesBuilder.NoteDescriptor> <n>5__6; // 0x78
	private LinkedList.Enumerator<NotesBuilder.NoteDescriptor> <>7__wrap6; // 0x80

	private Note System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.Note>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	private void <>m__Finally2() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Note System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.Note>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IEnumerator<Note> System.Collections.Generic.IEnumerable<Melanchall.DryWetMidi.Interaction.Note>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

