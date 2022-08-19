public sealed class SongSelectEvent : SystemCommonEvent // TypeDefIndex: 7564
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SevenBitNumber <Number>k__BackingField; // 0x20

	// Properties
	public SevenBitNumber Number { get; set; }

	// Methods

	// RVA: 0x13A2970 Offset: 0x13A1D70 VA: 0x1813A2970
	public void .ctor() { }

	// RVA: 0x13A2990 Offset: 0x13A1D90 VA: 0x1813A2990
	public void .ctor(SevenBitNumber number) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	public SevenBitNumber get_Number() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7D99E0 Offset: 0x7D8DE0 VA: 0x1807D99E0
	public void set_Number(SevenBitNumber value) { }

	// RVA: 0x13A2770 Offset: 0x13A1B70 VA: 0x1813A2770 Slot: 4
	internal override void Read(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A2710 Offset: 0x13A1B10 VA: 0x1813A2710 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A2910 Offset: 0x13A1D10 VA: 0x1813A2910 Slot: 3
	public override string ToString() { }

}

