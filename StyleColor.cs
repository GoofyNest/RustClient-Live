public struct StyleColor : IStyleValue<Color>, IEquatable<StyleColor> // TypeDefIndex: 4710
{	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private Color m_Value; // 0x4
	private int m_Specificity; // 0x14

	// Properties
	public Color value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x13A510 Offset: 0x139910 VA: 0x18013A510 Slot: 4
	public Color get_value() { }

	// RVA: 0x13A500 Offset: 0x139900 VA: 0x18013A500 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x13A4D0 Offset: 0x1398D0 VA: 0x18013A4D0
	public void .ctor(Color v) { }

	// RVA: 0x13A4E0 Offset: 0x1398E0 VA: 0x18013A4E0
	internal void .ctor(Color v, StyleKeyword keyword) { }

	// RVA: 0xECD3F0 Offset: 0xECC7F0 VA: 0x180ECD3F0
	public static bool op_Equality(StyleColor lhs, StyleColor rhs) { }

	// RVA: 0xECD470 Offset: 0xECC870 VA: 0x180ECD470
	public static StyleColor op_Implicit(Color v) { }

	// RVA: 0x13A380 Offset: 0x139780 VA: 0x18013A380 Slot: 6
	public bool Equals(StyleColor other) { }

	// RVA: 0x13A280 Offset: 0x139680 VA: 0x18013A280 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13A410 Offset: 0x139810 VA: 0x18013A410 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13A470 Offset: 0x139870 VA: 0x18013A470 Slot: 3
	public override string ToString() { }

}

