public struct Boolean : IComparable, IConvertible, IComparable<bool>, IEquatable<bool> // TypeDefIndex: 179
{	// Fields
	private bool m_value; // 0x0
	internal const int True = 1;
	internal const int False = 0;
	internal const string TrueLiteral = "True";
	internal const string FalseLiteral = "False";
	public static readonly string TrueString; // 0x0
	public static readonly string FalseString; // 0x8

	// Methods

	// RVA: 0x1F2600 Offset: 0x1F1A00 VA: 0x1801F2600 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1F2B60 Offset: 0x1F1F60 VA: 0x1801F2B60 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F2B20 Offset: 0x1F1F20 VA: 0x1801F2B20 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1F2570 Offset: 0x1F1970 VA: 0x1801F2570 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1DF340 Offset: 0x1DE740 VA: 0x1801DF340 Slot: 23
	public bool Equals(bool obj) { }

	// RVA: 0x1F2480 Offset: 0x1F1880 VA: 0x1801F2480 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x1F2460 Offset: 0x1F1860 VA: 0x1801F2460 Slot: 22
	public int CompareTo(bool value) { }

	// RVA: 0x158CEB0 Offset: 0x158C2B0 VA: 0x18158CEB0
	public static bool Parse(string value) { }

	// RVA: 0x158D2F0 Offset: 0x158C6F0 VA: 0x18158D2F0
	public static bool TryParse(string value, out bool result) { }

	// RVA: 0x158D1C0 Offset: 0x158C5C0 VA: 0x18158D1C0
	private static string TrimWhiteSpaceAndNull(string value) { }

	// RVA: 0x1F2610 Offset: 0x1F1A10 VA: 0x1801F2610 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1F2620 Offset: 0x1F1A20 VA: 0x1801F2620 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1F2690 Offset: 0x1F1A90 VA: 0x1801F2690 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1F28B0 Offset: 0x1F1CB0 VA: 0x1801F28B0 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1F2630 Offset: 0x1F1A30 VA: 0x1801F2630 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1F2790 Offset: 0x1F1B90 VA: 0x1801F2790 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1F2A00 Offset: 0x1F1E00 VA: 0x1801F2A00 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1F27F0 Offset: 0x1F1BF0 VA: 0x1801F27F0 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1F2A60 Offset: 0x1F1E60 VA: 0x1801F2A60 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1F2850 Offset: 0x1F1C50 VA: 0x1801F2850 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1F2AC0 Offset: 0x1F1EC0 VA: 0x1801F2AC0 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1F2910 Offset: 0x1F1D10 VA: 0x1801F2910 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1F2730 Offset: 0x1F1B30 VA: 0x1801F2730 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1F26B0 Offset: 0x1F1AB0 VA: 0x1801F26B0 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1F26A0 Offset: 0x1F1AA0 VA: 0x1801F26A0 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1F2970 Offset: 0x1F1D70 VA: 0x1801F2970 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x158D530 Offset: 0x158C930 VA: 0x18158D530
	private static void .cctor() { }

}

