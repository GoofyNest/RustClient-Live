public sealed class TimeSignatureEvent : MetaEvent // TypeDefIndex: 7550
{	// Fields
	private byte _denominator; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private byte <Numerator>k__BackingField; // 0x21
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private byte <ClocksPerClick>k__BackingField; // 0x22
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private byte <ThirtySecondNotesPerBeat>k__BackingField; // 0x23

	// Properties
	public byte Numerator { get; set; }
	public byte Denominator { get; set; }
	public byte ClocksPerClick { get; set; }
	public byte ThirtySecondNotesPerBeat { get; set; }

	// Methods

	// RVA: 0x13A4520 Offset: 0x13A3920 VA: 0x1813A4520
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0BB90 Offset: 0xB0AF90 VA: 0x180B0BB90
	public byte get_Numerator() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x139E1C0 Offset: 0x139D5C0 VA: 0x18139E1C0
	public void set_Numerator(byte value) { }

	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	public byte get_Denominator() { }

	// RVA: 0x13A4560 Offset: 0x13A3960 VA: 0x1813A4560
	public void set_Denominator(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0BBA0 Offset: 0xB0AFA0 VA: 0x180B0BBA0
	public byte get_ClocksPerClick() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE2ADA0 Offset: 0xE2A1A0 VA: 0x180E2ADA0
	public void set_ClocksPerClick(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13A4550 Offset: 0x13A3950 VA: 0x1813A4550
	public byte get_ThirtySecondNotesPerBeat() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13A4680 Offset: 0x13A3A80 VA: 0x1813A4680
	public void set_ThirtySecondNotesPerBeat(byte value) { }

	// RVA: 0x13A4120 Offset: 0x13A3520 VA: 0x1813A4120 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A40A0 Offset: 0x13A34A0 VA: 0x1813A40A0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A42F0 Offset: 0x13A36F0 VA: 0x1813A42F0 Slot: 3
	public override string ToString() { }

}

