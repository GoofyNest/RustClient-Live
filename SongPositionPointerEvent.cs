public sealed class SongPositionPointerEvent : SystemCommonEvent // TypeDefIndex: 7563
{	// Fields
	private SevenBitNumber _lsb; // 0x20
	private SevenBitNumber _msb; // 0x21

	// Properties
	public ushort PointerValue { get; set; }

	// Methods

	// RVA: 0x13A2540 Offset: 0x13A1940 VA: 0x1813A2540
	public void .ctor() { }

	// RVA: 0x13A23E0 Offset: 0x13A17E0 VA: 0x1813A23E0
	public void .ctor(ushort pointerValue) { }

	// RVA: 0x13A2560 Offset: 0x13A1960 VA: 0x1813A2560
	public ushort get_PointerValue() { }

	// RVA: 0x13A25C0 Offset: 0x13A19C0 VA: 0x1813A25C0
	public void set_PointerValue(ushort value) { }

	// RVA: 0x13A2110 Offset: 0x13A1510 VA: 0x1813A2110
	private SevenBitNumber ProcessValue(byte value, string property, InvalidSystemCommonEventParameterValuePolicy policy) { }

	// RVA: 0x13A2280 Offset: 0x13A1680 VA: 0x1813A2280 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A1F40 Offset: 0x13A1340 VA: 0x1813A1F40 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A2330 Offset: 0x13A1730 VA: 0x1813A2330 Slot: 3
	public override string ToString() { }

}

