internal class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 1835
{	// Fields
	private CharEntityEncoderFallback parent; // 0x30
	private string charEntity; // 0x38
	private int charEntityIndex; // 0x40

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x12DE380 Offset: 0x12DD780 VA: 0x1812DE380
	internal void .ctor(CharEntityEncoderFallback parent) { }

	// RVA: 0x12DE080 Offset: 0x12DD480 VA: 0x1812DE080 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x12DDD80 Offset: 0x12DD180 VA: 0x1812DDD80 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x12DE2F0 Offset: 0x12DD6F0 VA: 0x1812DE2F0 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x12DE340 Offset: 0x12DD740 VA: 0x1812DE340 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x12DE400 Offset: 0x12DD800 VA: 0x1812DE400 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x12DE360 Offset: 0x12DD760 VA: 0x1812DE360 Slot: 9
	public override void Reset() { }

	// RVA: 0x12DE370 Offset: 0x12DD770 VA: 0x1812DE370
	private int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate) { }

}

