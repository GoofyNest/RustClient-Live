internal sealed class NotesBuilder // TypeDefIndex: 7440
{	// Fields
	private readonly NoteDetectionSettings _noteDetectionSettings; // 0x10

	// Methods

	// RVA: 0x21FB470 Offset: 0x21FA870 VA: 0x1821FB470
	public void .ctor(NoteDetectionSettings noteDetectionSettings) { }

	[IteratorStateMachineAttribute] // RVA: 0x9ECB0 Offset: 0x9E0B0 VA: 0x18009ECB0
	// RVA: 0x21FB2F0 Offset: 0x21FA6F0 VA: 0x1821FB2F0
	public IEnumerable<Note> GetNotesLazy(IEnumerable<TimedEvent> timedEvents, bool collectTimedEvents = False, List<TimedEvent> collectedTimedEvents) { }

	[IteratorStateMachineAttribute] // RVA: 0x9EE00 Offset: 0x9E200 VA: 0x18009EE00
	// RVA: 0x21FB3B0 Offset: 0x21FA7B0 VA: 0x1821FB3B0
	public IEnumerable<Note> GetNotesLazy(IEnumerable<Tuple<TimedEvent, int>> timedEvents, bool collectTimedEvents = False, List<Tuple<TimedEvent, int>> collectedTimedEvents) { }

	// RVA: 0x21FB250 Offset: 0x21FA650 VA: 0x1821FB250
	private static int GetNoteEventId(NoteEvent noteEvent) { }

}

private class NotesBuilder.NoteDescriptor // TypeDefIndex: 7441
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly TimedEvent <NoteOnTimedEvent>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TimedEvent <NoteOffTimedEvent>k__BackingField; // 0x18

	// Properties
	public TimedEvent NoteOnTimedEvent { get; }
	public TimedEvent NoteOffTimedEvent { get; set; }
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(TimedEvent noteOnTimedEvent) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public TimedEvent get_NoteOnTimedEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public TimedEvent get_NoteOffTimedEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_NoteOffTimedEvent(TimedEvent value) { }

	// RVA: 0x17C5ED0 Offset: 0x17C52D0 VA: 0x1817C5ED0
	public bool get_IsCompleted() { }

	// RVA: 0x21F9FC0 Offset: 0x21F93C0 VA: 0x1821F9FC0
	public Note GetNote() { }

}

private abstract class NotesBuilder.NoteOnsHolderBase<TDescriptor> // TypeDefIndex: 7442
{	// Fields
	private readonly NoteStartDetectionPolicy _noteStartDetectionPolicy; // 0x0
	private readonly Stack<LinkedListNode<TDescriptor>> _nodesStack; // 0x0
	private readonly Queue<LinkedListNode<TDescriptor>> _nodesQueue; // 0x0

	// Properties
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(NoteStartDetectionPolicy noteStartDetectionPolicy) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F52C0 Offset: 0x17F46C0 VA: 0x1817F52C0
	|-NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor>..ctor
	|-NotesBuilder.NoteOnsHolderBase<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F53C0 Offset: 0x17F47C0 VA: 0x1817F53C0
	|-NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor>.get_Count
	|-NotesBuilder.NoteOnsHolderBase<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void Add(LinkedListNode<TDescriptor> noteOnNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F51E0 Offset: 0x17F45E0 VA: 0x1817F51E0
	|-NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor>.Add
	|-NotesBuilder.NoteOnsHolderBase<object>.Add
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<TDescriptor> GetNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17F5250 Offset: 0x17F4650 VA: 0x1817F5250
	|-NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor>.GetNext
	|-NotesBuilder.NoteOnsHolderBase<object>.GetNext
	*/

}

private sealed class NotesBuilder.NoteOnsHolder : NotesBuilder.NoteOnsHolderBase<NotesBuilder.NoteDescriptor> // TypeDefIndex: 7443
{	// Methods

	// RVA: 0x21FA040 Offset: 0x21F9440 VA: 0x1821FA040
	public void .ctor(NoteStartDetectionPolicy noteStartDetectionPolicy) { }

}

private sealed class NotesBuilder.<GetNotesLazy>d__7 : IEnumerable<Note>, IEnumerable, IEnumerator<Note>, IDisposable, IEnumerator // TypeDefIndex: 7444
{	// Fields
	private int <>1__state; // 0x10
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

	// Properties
	private Note System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.Note>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD824F0 Offset: 0xD818F0 VA: 0x180D824F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21FE720 Offset: 0x21FDB20 VA: 0x1821FE720 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x21FDFC0 Offset: 0x21FD3C0 VA: 0x1821FDFC0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x21FE850 Offset: 0x21FDC50 VA: 0x1821FE850
	private void <>m__Finally1() { }

	// RVA: 0x21FE8A0 Offset: 0x21FDCA0 VA: 0x1821FE8A0
	private void <>m__Finally2() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	private Note System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.Note>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21FE6D0 Offset: 0x21FDAD0 VA: 0x1821FE6D0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21FE600 Offset: 0x21FDA00 VA: 0x1821FE600 Slot: 4
	private IEnumerator<Note> System.Collections.Generic.IEnumerable<Melanchall.DryWetMidi.Interaction.Note>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21FE600 Offset: 0x21FDA00 VA: 0x1821FE600 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

private sealed class NotesBuilder.<GetNotesLazy>d__8 : IEnumerable<Note>, IEnumerable, IEnumerator<Note>, IDisposable, IEnumerator // TypeDefIndex: 7445
{	// Fields
	private int <>1__state; // 0x10
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

	// Properties
	private Note System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.Note>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD824F0 Offset: 0xD818F0 VA: 0x180D824F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21FF0C0 Offset: 0x21FE4C0 VA: 0x1821FF0C0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x21FE8E0 Offset: 0x21FDCE0 VA: 0x1821FE8E0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x21FF1F0 Offset: 0x21FE5F0 VA: 0x1821FF1F0
	private void <>m__Finally1() { }

	// RVA: 0x21FF240 Offset: 0x21FE640 VA: 0x1821FF240
	private void <>m__Finally2() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	private Note System.Collections.Generic.IEnumerator<Melanchall.DryWetMidi.Interaction.Note>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21FF070 Offset: 0x21FE470 VA: 0x1821FF070 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21FEFA0 Offset: 0x21FE3A0 VA: 0x1821FEFA0 Slot: 4
	private IEnumerator<Note> System.Collections.Generic.IEnumerable<Melanchall.DryWetMidi.Interaction.Note>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21FEFA0 Offset: 0x21FE3A0 VA: 0x1821FEFA0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

