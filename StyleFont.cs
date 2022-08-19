public struct StyleFont : IStyleValue<Font>, IEquatable<StyleFont> // TypeDefIndex: 4713
{	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private Font m_Value; // 0x8
	private int m_Specificity; // 0x10

	// Properties
	public Font value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x13A920 Offset: 0x139D20 VA: 0x18013A920 Slot: 4
	public Font get_value() { }

	// RVA: 0x13A500 Offset: 0x139900 VA: 0x18013A500 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0xECD580 Offset: 0xECC980 VA: 0x180ECD580
	public static bool op_Equality(StyleFont lhs, StyleFont rhs) { }

	// RVA: 0x13A830 Offset: 0x139C30 VA: 0x18013A830 Slot: 6
	public bool Equals(StyleFont other) { }

	// RVA: 0x13A740 Offset: 0x139B40 VA: 0x18013A740 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13A8B0 Offset: 0x139CB0 VA: 0x18013A8B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13A8C0 Offset: 0x139CC0 VA: 0x18013A8C0 Slot: 3
	public override string ToString() { }

}

