public struct StyleFloat : IStyleValue<float>, IEquatable<StyleFloat> // TypeDefIndex: 4712
{	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private float m_Value; // 0x4
	private int m_Specificity; // 0x8

	// Properties
	public float value { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x13A730 Offset: 0x139B30 VA: 0x18013A730 Slot: 4
	public float get_value() { }

	// RVA: 0x13A500 Offset: 0x139900 VA: 0x18013A500 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x13A700 Offset: 0x139B00 VA: 0x18013A700
	public void .ctor(float v) { }

	// RVA: 0x13A710 Offset: 0x139B10 VA: 0x18013A710
	internal void .ctor(float v, StyleKeyword keyword) { }

	// RVA: 0xECD4A0 Offset: 0xECC8A0 VA: 0x180ECD4A0
	public static bool op_Equality(StyleFloat lhs, StyleFloat rhs) { }

	// RVA: 0xECD4D0 Offset: 0xECC8D0 VA: 0x180ECD4D0
	public static StyleFloat op_Implicit(float v) { }

	// RVA: 0x13A550 Offset: 0x139950 VA: 0x18013A550 Slot: 6
	public bool Equals(StyleFloat other) { }

	// RVA: 0x13A590 Offset: 0x139990 VA: 0x18013A590 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13A640 Offset: 0x139A40 VA: 0x18013A640 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13A6A0 Offset: 0x139AA0 VA: 0x18013A6A0 Slot: 3
	public override string ToString() { }

}

