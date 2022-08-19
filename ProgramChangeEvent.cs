public sealed class ProgramChangeEvent : ChannelEvent // TypeDefIndex: 7529
{	// Properties
	public SevenBitNumber ProgramNumber { get; }

	// Methods

	// RVA: 0x139FB40 Offset: 0x139EF40 VA: 0x18139FB40
	public void .ctor() { }

	// RVA: 0x139FB60 Offset: 0x139EF60 VA: 0x18139FB60
	public SevenBitNumber get_ProgramNumber() { }

	// RVA: 0x1390BF0 Offset: 0x138FFF0 VA: 0x181390BF0 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x139F9D0 Offset: 0x139EDD0 VA: 0x18139F9D0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x139FA40 Offset: 0x139EE40 VA: 0x18139FA40 Slot: 3
	public override string ToString() { }

}

