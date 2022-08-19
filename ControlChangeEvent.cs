public sealed class ControlChangeEvent : ChannelEvent // TypeDefIndex: 7523
{	// Properties
	public SevenBitNumber ControlNumber { get; }
	public SevenBitNumber ControlValue { get; }

	// Methods

	// RVA: 0x1391D70 Offset: 0x1391170 VA: 0x181391D70
	public void .ctor() { }

	// RVA: 0x1391D90 Offset: 0x1391190 VA: 0x181391D90
	public SevenBitNumber get_ControlNumber() { }

	// RVA: 0x1391E30 Offset: 0x1391230 VA: 0x181391E30
	public SevenBitNumber get_ControlValue() { }

	// RVA: 0x1391B80 Offset: 0x1390F80 VA: 0x181391B80 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x1391B10 Offset: 0x1390F10 VA: 0x181391B10 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x1391BD0 Offset: 0x1390FD0 VA: 0x181391BD0 Slot: 3
	public override string ToString() { }

}

