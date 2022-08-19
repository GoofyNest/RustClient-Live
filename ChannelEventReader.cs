internal sealed class ChannelEventReader : IEventReader // TypeDefIndex: 7552
{	// Methods

	// RVA: 0x1390FC0 Offset: 0x13903C0 VA: 0x181390FC0 Slot: 4
	public MidiEvent Read(MidiReader reader, ReadingSettings settings, byte currentStatusByte) { }

	// RVA: 0x1390DD0 Offset: 0x13901D0 VA: 0x181390DD0
	private void ReactOnUnknownChannelEvent(FourBitNumber statusByte, FourBitNumber channel, MidiReader reader, ReadingSettings settings) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

