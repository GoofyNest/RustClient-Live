internal sealed class SmpteData // TypeDefIndex: 7618
{	// Fields
	private static readonly Dictionary<SmpteFormat, byte> MaxFrames; // 0x0
	private static readonly SmpteFormat[] Formats; // 0x8
	private SmpteFormat _format; // 0x10
	private byte _hours; // 0x11
	private byte _minutes; // 0x12
	private byte _seconds; // 0x13
	private byte _frames; // 0x14
	private byte _subFrames; // 0x15

	// Properties
	public SmpteFormat Format { get; set; }
	public byte Hours { get; set; }
	public byte Minutes { get; set; }
	public byte Seconds { get; set; }
	public byte Frames { get; set; }
	public byte SubFrames { get; set; }

	// Methods

	// RVA: 0x13A0F00 Offset: 0x13A0300 VA: 0x1813A0F00
	public void .ctor() { }

	// RVA: 0x13A0E30 Offset: 0x13A0230 VA: 0x1813A0E30
	public void .ctor(SmpteFormat format, byte hours, byte minutes, byte seconds, byte frames, byte subFrames) { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public SmpteFormat get_Format() { }

	// RVA: 0x13A0F20 Offset: 0x13A0320 VA: 0x1813A0F20
	public void set_Format(SmpteFormat value) { }

	// RVA: 0xF86260 Offset: 0xF85660 VA: 0x180F86260
	public byte get_Hours() { }

	// RVA: 0x13A1050 Offset: 0x13A0450 VA: 0x1813A1050
	public void set_Hours(byte value) { }

	// RVA: 0xF99010 Offset: 0xF98410 VA: 0x180F99010
	public byte get_Minutes() { }

	// RVA: 0x13A10E0 Offset: 0x13A04E0 VA: 0x1813A10E0
	public void set_Minutes(byte value) { }

	// RVA: 0x13A0F10 Offset: 0x13A0310 VA: 0x1813A0F10
	public byte get_Seconds() { }

	// RVA: 0x13A1170 Offset: 0x13A0570 VA: 0x1813A1170
	public void set_Seconds(byte value) { }

	// RVA: 0x9EF9E0 Offset: 0x9EEDE0 VA: 0x1809EF9E0
	public byte get_Frames() { }

	// RVA: 0x13A0F70 Offset: 0x13A0370 VA: 0x1813A0F70
	public void set_Frames(byte value) { }

	// RVA: 0x139FE10 Offset: 0x139F210 VA: 0x18139FE10
	public byte get_SubFrames() { }

	// RVA: 0x13A1200 Offset: 0x13A0600 VA: 0x1813A1200
	public void set_SubFrames(byte value) { }

	// RVA: 0x13A0A30 Offset: 0x139FE30 VA: 0x1813A0A30
	public static SmpteData Read(Func<byte> byteReader, Func<byte, string, byte, byte> valueProcessor) { }

	// RVA: 0x13A0990 Offset: 0x139FD90 VA: 0x1813A0990
	internal static SmpteFormat GetFormat(byte formatAndHours) { }

	// RVA: 0x13A0A20 Offset: 0x139FE20 VA: 0x1813A0A20
	internal static byte GetHours(byte formatAndHours) { }

	// RVA: 0x13A0D30 Offset: 0x13A0130 VA: 0x1813A0D30
	private static void .cctor() { }

}

