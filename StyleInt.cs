public struct StyleInt : IStyleValue<int>, IEquatable<StyleInt> // TypeDefIndex: 4714
{	// Fields
	private StyleKeyword m_Keyword; // 0x0
	private int m_Value; // 0x4
	private int m_Specificity; // 0x8

	// Properties
	public int value { get; }
	internal int specificity { get; }
	public StyleKeyword keyword { get; }

	// Methods

	// RVA: 0x13AB90 Offset: 0x139F90 VA: 0x18013AB90 Slot: 4
	public int get_value() { }

	// RVA: 0x13AB80 Offset: 0x139F80 VA: 0x18013AB80
	internal int get_specificity() { }

	// RVA: 0x13A500 Offset: 0x139900 VA: 0x18013A500 Slot: 5
	public StyleKeyword get_keyword() { }

	// RVA: 0x13AB60 Offset: 0x139F60 VA: 0x18013AB60
	public void .ctor(int v) { }

	// RVA: 0x13AB70 Offset: 0x139F70 VA: 0x18013AB70
	internal void .ctor(int v, StyleKeyword keyword) { }

	// RVA: 0xECD630 Offset: 0xECCA30 VA: 0x180ECD630
	public static bool op_Equality(StyleInt lhs, StyleInt rhs) { }

	// RVA: 0xECD680 Offset: 0xECCA80 VA: 0x180ECD680
	public static StyleInt op_Implicit(int v) { }

	// RVA: 0x13A950 Offset: 0x139D50 VA: 0x18013A950 Slot: 6
	public bool Equals(StyleInt other) { }

	// RVA: 0x13A9B0 Offset: 0x139DB0 VA: 0x18013A9B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13AAA0 Offset: 0x139EA0 VA: 0x18013AAA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13AB00 Offset: 0x139F00 VA: 0x18013AB00 Slot: 3
	public override string ToString() { }

}

