public struct Double : IComparable, IFormattable, IConvertible, IComparable<double>, IEquatable<double> // TypeDefIndex: 208
{	// Fields
	internal double m_value; // 0x0
	public const double MinValue = -1,79769313486232E+308;
	public const double MaxValue = 1,79769313486232E+308;
	public const double Epsilon = 4,94065645841247E-324;
	public const double NegativeInfinity = -∞;
	public const double PositiveInfinity = ∞;
	public const double NaN = ¤¤¤;
	internal static double NegativeZero; // 0x0

	// Methods

	// RVA: 0x10CF350 Offset: 0x10CE750 VA: 0x1810CF350
	public static bool IsInfinity(double d) { }

	// RVA: 0x10CF3D0 Offset: 0x10CE7D0 VA: 0x1810CF3D0
	public static bool IsPositiveInfinity(double d) { }

	// RVA: 0x10CF3B0 Offset: 0x10CE7B0 VA: 0x1810CF3B0
	public static bool IsNegativeInfinity(double d) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x10CF380 Offset: 0x10CE780 VA: 0x1810CF380
	public static bool IsNaN(double d) { }

	// RVA: 0x10CF2D0 Offset: 0x10CE6D0 VA: 0x1810CF2D0
	public static bool IsFinite(double d) { }

	// RVA: 0x19E890 Offset: 0x19DC90 VA: 0x18019E890 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x19E760 Offset: 0x19DB60 VA: 0x18019E760 Slot: 23
	public int CompareTo(double value) { }

	// RVA: 0x19EB10 Offset: 0x19DF10 VA: 0x18019EB10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x19EA20 Offset: 0x19DE20 VA: 0x18019EA20 Slot: 24
	public bool Equals(double obj) { }

	// RVA: 0x19EC30 Offset: 0x19E030 VA: 0x18019EC30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19F220 Offset: 0x19E620 VA: 0x18019F220 Slot: 3
	public override string ToString() { }

	// RVA: 0x19F1A0 Offset: 0x19E5A0 VA: 0x18019F1A0
	public string ToString(string format) { }

	// RVA: 0x19F1E0 Offset: 0x19E5E0 VA: 0x18019F1E0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x19F160 Offset: 0x19E560 VA: 0x18019F160 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x10CF3F0 Offset: 0x10CE7F0 VA: 0x1810CF3F0
	public static double Parse(string s) { }

	// RVA: 0x10CF4F0 Offset: 0x10CE8F0 VA: 0x1810CF4F0
	public static double Parse(string s, IFormatProvider provider) { }

	// RVA: 0x10CF460 Offset: 0x10CE860 VA: 0x1810CF460
	public static double Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x10CF570 Offset: 0x10CE970 VA: 0x1810CF570
	private static double Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x10CF960 Offset: 0x10CED60 VA: 0x1810CF960
	public static bool TryParse(string s, out double result) { }

	// RVA: 0x10CF810 Offset: 0x10CEC10 VA: 0x1810CF810
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result) { }

	// RVA: 0x10CFA90 Offset: 0x10CEE90 VA: 0x1810CFA90
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out double result) { }

	// RVA: 0x19EC40 Offset: 0x19E040 VA: 0x18019EC40 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x19EC50 Offset: 0x19E050 VA: 0x18019EC50 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x19ED10 Offset: 0x19E110 VA: 0x18019ED10 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x19EEE0 Offset: 0x19E2E0 VA: 0x18019EEE0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x19ECB0 Offset: 0x19E0B0 VA: 0x18019ECB0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x19EDC0 Offset: 0x19E1C0 VA: 0x18019EDC0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x19F040 Offset: 0x19E440 VA: 0x18019F040 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x19EE20 Offset: 0x19E220 VA: 0x18019EE20 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x19F0A0 Offset: 0x19E4A0 VA: 0x18019F0A0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x19EE80 Offset: 0x19E280 VA: 0x18019EE80 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x19F100 Offset: 0x19E500 VA: 0x18019F100 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x19EF40 Offset: 0x19E340 VA: 0x18019EF40 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x19EDB0 Offset: 0x19E1B0 VA: 0x18019EDB0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x19ED30 Offset: 0x19E130 VA: 0x18019ED30 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x19ED20 Offset: 0x19E120 VA: 0x18019ED20 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x19EFA0 Offset: 0x19E3A0 VA: 0x18019EFA0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x10CFB80 Offset: 0x10CEF80 VA: 0x1810CFB80
	private static void .cctor() { }

}

