public sealed class SetTempoEvent : MetaEvent // TypeDefIndex: 7546
{	// Fields
	private long _microsecondsPerBeat; // 0x20

	// Properties
	public long MicrosecondsPerQuarterNote { get; set; }

	// Methods

	// RVA: 0x13A05D0 Offset: 0x139F9D0 VA: 0x1813A05D0
	public void .ctor() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public long get_MicrosecondsPerQuarterNote() { }

	// RVA: 0x13A0600 Offset: 0x139FA00 VA: 0x1813A0600
	public void set_MicrosecondsPerQuarterNote(long value) { }

	// RVA: 0x13A03A0 Offset: 0x139F7A0 VA: 0x1813A03A0 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A0330 Offset: 0x139F730 VA: 0x1813A0330 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A0570 Offset: 0x139F970 VA: 0x1813A0570 Slot: 3
	public override string ToString() { }

}

