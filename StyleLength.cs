public struct StyleLength : IStyleValue<Length>, IEquatable<StyleLength> // TypeDefIndex: 4715
{	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private Length m_Value; // 0x4
	private int m_Specificity; // 0xC

	// Properties
	public Length value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x13AD60 Offset: 0x13A160 VA: 0x18013AD60 Slot: 4
	public Length get_value() { }

	// RVA: 0x13A500 Offset: 0x139900 VA: 0x18013A500 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x13AD50 Offset: 0x13A150 VA: 0x18013AD50
	internal void .ctor(Length v, StyleKeyword keyword) { }

	// RVA: 0xECD710 Offset: 0xECCB10 VA: 0x180ECD710
	public static bool op_Equality(StyleLength lhs, StyleLength rhs) { }

	// RVA: 0x13AC80 Offset: 0x13A080 VA: 0x18013AC80 Slot: 6
	public bool Equals(StyleLength other) { }

	// RVA: 0x13ABA0 Offset: 0x139FA0 VA: 0x18013ABA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13ACE0 Offset: 0x13A0E0 VA: 0x18013ACE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13ACF0 Offset: 0x13A0F0 VA: 0x18013ACF0 Slot: 3
	public override string ToString() { }

}

