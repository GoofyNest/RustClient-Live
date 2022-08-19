public sealed class PitchBendEvent : ChannelEvent // TypeDefIndex: 7528
{	// Properties
	public ushort PitchValue { get; }

	// Methods

	// RVA: 0x139F860 Offset: 0x139EC60 VA: 0x18139F860
	public void .ctor() { }

	// RVA: 0x139F880 Offset: 0x139EC80 VA: 0x18139F880
	public ushort get_PitchValue() { }

	// RVA: 0x1391B80 Offset: 0x1390F80 VA: 0x181391B80 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x139F760 Offset: 0x139EB60 VA: 0x18139F760 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x139F7D0 Offset: 0x139EBD0 VA: 0x18139F7D0 Slot: 3
	public override string ToString() { }

}

