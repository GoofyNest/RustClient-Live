public sealed class SmpteOffsetEvent : MetaEvent // TypeDefIndex: 7547
{	// Fields
	private SmpteData _smpteData; // 0x20

	// Properties
	public SmpteFormat Format { get; set; }
	public byte Hours { get; set; }
	public byte Minutes { get; set; }
	public byte Seconds { get; set; }
	public byte Frames { get; set; }
	public byte SubFrames { get; set; }

	// Methods

	// RVA: 0x13A19C0 Offset: 0x13A0DC0 VA: 0x1813A19C0
	public void .ctor() { }

	// RVA: 0x13A1A30 Offset: 0x13A0E30 VA: 0x1813A1A30
	public void .ctor(SmpteFormat format, byte hours, byte minutes, byte seconds, byte frames, byte subFrames) { }

	// RVA: 0x13A1B80 Offset: 0x13A0F80 VA: 0x1813A1B80
	public SmpteFormat get_Format() { }

	// RVA: 0x13A1C40 Offset: 0x13A1040 VA: 0x1813A1C40
	public void set_Format(SmpteFormat value) { }

	// RVA: 0x13A1BC0 Offset: 0x13A0FC0 VA: 0x1813A1BC0
	public byte get_Hours() { }

	// RVA: 0x13A1CC0 Offset: 0x13A10C0 VA: 0x1813A1CC0
	public void set_Hours(byte value) { }

	// RVA: 0x13A1BE0 Offset: 0x13A0FE0 VA: 0x1813A1BE0
	public byte get_Minutes() { }

	// RVA: 0x13A1CE0 Offset: 0x13A10E0 VA: 0x1813A1CE0
	public void set_Minutes(byte value) { }

	// RVA: 0x13A1C00 Offset: 0x13A1000 VA: 0x1813A1C00
	public byte get_Seconds() { }

	// RVA: 0x13A1D00 Offset: 0x13A1100 VA: 0x1813A1D00
	public void set_Seconds(byte value) { }

	// RVA: 0x13A1BA0 Offset: 0x13A0FA0 VA: 0x1813A1BA0
	public byte get_Frames() { }

	// RVA: 0x13A1CA0 Offset: 0x13A10A0 VA: 0x1813A1CA0
	public void set_Frames(byte value) { }

	// RVA: 0x13A1C20 Offset: 0x13A1020 VA: 0x1813A1C20
	public byte get_SubFrames() { }

	// RVA: 0x13A1D20 Offset: 0x13A1120 VA: 0x1813A1D20
	public void set_SubFrames(byte value) { }

	// RVA: 0x13A1450 Offset: 0x13A0850 VA: 0x1813A1450
	private byte ProcessValue(byte value, string property, byte max, InvalidMetaEventParameterValuePolicy policy) { }

	// RVA: 0x13A1530 Offset: 0x13A0930 VA: 0x1813A1530 Slot: 6
	protected override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

	// RVA: 0x13A1290 Offset: 0x13A0690 VA: 0x1813A1290 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x13A1650 Offset: 0x13A0A50 VA: 0x1813A1650 Slot: 3
	public override string ToString() { }

}

private sealed class SmpteOffsetEvent.<>c__DisplayClass22_0 // TypeDefIndex: 7548
{	// Fields
	public SmpteOffsetEvent <>4__this; // 0x10
	public ReadingSettings settings; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13A5190 Offset: 0x13A4590 VA: 0x1813A5190
	internal byte <ReadContent>b__0(byte value, string propertyName, byte max) { }

}

