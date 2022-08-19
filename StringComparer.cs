public abstract class StringComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string> // TypeDefIndex: 303
{	// Fields
	private static readonly StringComparer _invariantCulture; // 0x0
	private static readonly StringComparer _invariantCultureIgnoreCase; // 0x8
	private static readonly StringComparer _ordinal; // 0x10
	private static readonly StringComparer _ordinalIgnoreCase; // 0x18

	// Properties
	public static StringComparer InvariantCultureIgnoreCase { get; }
	public static StringComparer CurrentCultureIgnoreCase { get; }
	public static StringComparer Ordinal { get; }
	public static StringComparer OrdinalIgnoreCase { get; }

	// Methods

	// RVA: 0x18AB3E0 Offset: 0x18AA7E0 VA: 0x1818AB3E0
	public static StringComparer get_InvariantCultureIgnoreCase() { }

	// RVA: 0x18AB360 Offset: 0x18AA760 VA: 0x1818AB360
	public static StringComparer get_CurrentCultureIgnoreCase() { }

	// RVA: 0x18AB4A0 Offset: 0x18AA8A0 VA: 0x1818AB4A0
	public static StringComparer get_Ordinal() { }

	// RVA: 0x18AB440 Offset: 0x18AA840 VA: 0x1818AB440
	public static StringComparer get_OrdinalIgnoreCase() { }

	// RVA: 0x18AAFE0 Offset: 0x18AA3E0 VA: 0x1818AAFE0
	public static StringComparer Create(CultureInfo culture, bool ignoreCase) { }

	// RVA: 0x18AAE20 Offset: 0x18AA220 VA: 0x1818AAE20 Slot: 4
	public int Compare(object x, object y) { }

	// RVA: 0x18AB080 Offset: 0x18AA480 VA: 0x1818AB080 Slot: 5
	public bool Equals(object x, object y) { }

	// RVA: 0x18AB160 Offset: 0x18AA560 VA: 0x1818AB160 Slot: 6
	public int GetHashCode(object obj) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int Compare(string x, string y);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool Equals(string x, string y);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int GetHashCode(string obj);

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x18AB210 Offset: 0x18AA610 VA: 0x1818AB210
	private static void .cctor() { }

}

