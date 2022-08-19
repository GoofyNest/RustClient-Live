public abstract class MidiEvent // TypeDefIndex: 7517
{	// Fields
	internal long _deltaTime; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly MidiEventType <EventType>k__BackingField; // 0x18

	// Properties
	public MidiEventType EventType { get; }
	public long DeltaTime { get; set; }

	// Methods

	// RVA: 0x1390B10 Offset: 0x138FF10 VA: 0x181390B10
	public void .ctor(MidiEventType eventType) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	public MidiEventType get_EventType() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public long get_DeltaTime() { }

	// RVA: 0x139B140 Offset: 0x139A540 VA: 0x18139B140
	public void set_DeltaTime(long value) { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void Read(MidiReader reader, ReadingSettings settings, int size);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract MidiEvent CloneEvent();

	// RVA: 0x139B100 Offset: 0x139A500 VA: 0x18139B100
	public MidiEvent Clone() { }

}

