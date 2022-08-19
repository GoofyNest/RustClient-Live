public sealed class TrackChunk : MidiChunk // TypeDefIndex: 7511
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly EventsCollection <Events>k__BackingField; // 0x18

	// Properties
	public EventsCollection Events { get; }

	// Methods

	// RVA: 0x13A4D50 Offset: 0x13A4150 VA: 0x1813A4D50
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public EventsCollection get_Events() { }

	// RVA: 0x13A47D0 Offset: 0x13A3BD0 VA: 0x1813A47D0 Slot: 4
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, uint size) { }

	// RVA: 0x13A4CC0 Offset: 0x13A40C0 VA: 0x1813A4CC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x13A4970 Offset: 0x13A3D70 VA: 0x1813A4970
	private MidiEvent ReadEvent(MidiReader reader, ReadingSettings settings, ref Nullable<byte> channelEventStatusByte, out long deltaTime) { }

}

