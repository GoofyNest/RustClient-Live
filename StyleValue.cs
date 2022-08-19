internal struct StyleValue // TypeDefIndex: 4726
{	// Fields
	public StylePropertyID id; // 0x0
	public StyleKeyword keyword; // 0x4
	public float number; // 0x8
	public Length length; // 0x8
	public Color color; // 0x8
	public GCHandle resource; // 0x8

	// Methods

	// RVA: 0xECFE30 Offset: 0xECF230 VA: 0x180ECFE30
	public static StyleValue Create(StylePropertyID id) { }

	// RVA: 0xECFDC0 Offset: 0xECF1C0 VA: 0x180ECFDC0
	public static StyleValue Create(StylePropertyID id, StyleKeyword keyword) { }

	// RVA: 0xECFDF0 Offset: 0xECF1F0 VA: 0x180ECFDF0
	public static StyleValue Create(StylePropertyID id, float number) { }

	// RVA: 0xECFE90 Offset: 0xECF290 VA: 0x180ECFE90
	public static StyleValue Create(StylePropertyID id, int number) { }

	// RVA: 0xECFE60 Offset: 0xECF260 VA: 0x180ECFE60
	public static StyleValue Create(StylePropertyID id, Color color) { }

}

