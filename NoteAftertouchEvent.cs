public sealed class NoteAftertouchEvent : ChannelEvent // TypeDefIndex: 7524
{	// Properties
	public SevenBitNumber NoteNumber { get; }
	public SevenBitNumber AftertouchValue { get; }

	// Methods

	// RVA: 0x139E7A0 Offset: 0x139DBA0 VA: 0x18139E7A0
	public void .ctor() { }

	// RVA: 0x139E860 Offset: 0x139DC60 VA: 0x18139E860
	public SevenBitNumber get_NoteNumber() { }

	// RVA: 0x139E7C0 Offset: 0x139DBC0 VA: 0x18139E7C0
	public SevenBitNumber get_AftertouchValue() { }

	// RVA: 0x1391B80 Offset: 0x1390F80 VA: 0x181391B80 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x139E590 Offset: 0x139D990 VA: 0x18139E590 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x139E600 Offset: 0x139DA00 VA: 0x18139E600 Slot: 3
	public override string ToString() { }

}

