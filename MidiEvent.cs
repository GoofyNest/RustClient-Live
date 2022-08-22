public abstract class MidiEvent // TypeDefIndex: 7517
{	internal long _deltaTime; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly MidiEventType <EventType>k__BackingField; // 0x18

	public MidiEventType EventType { get; }
	public long DeltaTime { get; set; }


	public void .ctor(MidiEventType eventType) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public MidiEventType get_EventType() { }

	public long get_DeltaTime() { }

	public void set_DeltaTime(long value) { }

	internal abstract void Read(MidiReader reader, ReadingSettings settings, int size);

	protected abstract MidiEvent CloneEvent();

	public MidiEvent Clone() { }

}

