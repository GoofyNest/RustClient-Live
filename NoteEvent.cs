public abstract class NoteEvent : ChannelEvent // TypeDefIndex: 7525
{	// Properties
	public SevenBitNumber NoteNumber { get; set; }
	public SevenBitNumber Velocity { get; set; }

	// Methods

	// RVA: 0x1390B10 Offset: 0x138FF10 VA: 0x181390B10
	protected void .ctor(MidiEventType eventType) { }

	// RVA: 0x139EA40 Offset: 0x139DE40 VA: 0x18139EA40
	public SevenBitNumber get_NoteNumber() { }

	// RVA: 0x139EB80 Offset: 0x139DF80 VA: 0x18139EB80
	public void set_NoteNumber(SevenBitNumber value) { }

	// RVA: 0x139EAE0 Offset: 0x139DEE0 VA: 0x18139EAE0
	public SevenBitNumber get_Velocity() { }

	// RVA: 0x139EBE0 Offset: 0x139DFE0 VA: 0x18139EBE0
	public void set_Velocity(SevenBitNumber value) { }

	// RVA: 0x1391B80 Offset: 0x1390F80 VA: 0x181391B80 Slot: 4
	internal sealed override void Read(MidiReader reader, ReadingSettings settings, int size) { }

}

