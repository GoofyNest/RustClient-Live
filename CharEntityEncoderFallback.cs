internal class CharEntityEncoderFallback : EncoderFallback // TypeDefIndex: 1834
{	// Fields
	private CharEntityEncoderFallbackBuffer fallbackBuffer; // 0x18
	private int[] textContentMarks; // 0x20
	private int endMarkPos; // 0x28
	private int curMarkPos; // 0x2C
	private int startOffset; // 0x30

	// Properties
	public override int MaxCharCount { get; }
	internal int StartOffset { set; }

	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	internal void .ctor() { }

	// RVA: 0x12DE490 Offset: 0x12DD890 VA: 0x1812DE490 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0xB9AAF0 Offset: 0xB99EF0 VA: 0x180B9AAF0 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0xA17E80 Offset: 0xA17280 VA: 0x180A17E80
	internal void set_StartOffset(int value) { }

	// RVA: 0x12DE560 Offset: 0x12DD960 VA: 0x1812DE560
	internal void Reset(int[] textContentMarks, int endMarkPos) { }

	// RVA: 0x12DE430 Offset: 0x12DD830 VA: 0x1812DE430
	internal bool CanReplaceAt(int index) { }

}

