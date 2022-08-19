public struct Single : IComparable, IFormattable, IConvertible, IComparable<float>, IEquatable<float> // TypeDefIndex: 299
{	// Fields
	internal float m_value; // 0x0
	public const float MinValue = -3,402823E+38;
	public const float Epsilon = 1,401298E-45;
	public const float MaxValue = 3,402823E+38;
	public const float PositiveInfinity = ∞;
	public const float NegativeInfinity = -∞;
	public const float NaN = ¤¤¤;

	// Methods

	// RVA: 0x18AA3A0 Offset: 0x18A97A0 VA: 0x1818AA3A0
	public static bool IsInfinity(float f) { }

	// RVA: 0x18AA400 Offset: 0x18A9800 VA: 0x1818AA400
	public static bool IsPositiveInfinity(float f) { }

	// RVA: 0x18AA3E0 Offset: 0x18A97E0 VA: 0x1818AA3E0
	public static bool IsNegativeInfinity(float f) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x18AA3C0 Offset: 0x18A97C0 VA: 0x1818AA3C0
	public static bool IsNaN(float f) { }

	// RVA: 0x18AA380 Offset: 0x18A9780 VA: 0x1818AA380
	public static bool IsFinite(float f) { }

	// RVA: 0x214540 Offset: 0x213940 VA: 0x180214540 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x214680 Offset: 0x213A80 VA: 0x180214680 Slot: 23
	public int CompareTo(float value) { }

	// RVA: 0x214720 Offset: 0x213B20 VA: 0x180214720 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2146E0 Offset: 0x213AE0 VA: 0x1802146E0 Slot: 24
	public bool Equals(float obj) { }

	// RVA: 0x2147E0 Offset: 0x213BE0 VA: 0x1802147E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x214D50 Offset: 0x214150 VA: 0x180214D50 Slot: 3
	public override string ToString() { }

	// RVA: 0x214D80 Offset: 0x214180 VA: 0x180214D80 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x214D10 Offset: 0x214110 VA: 0x180214D10
	public string ToString(string format) { }

	// RVA: 0x214DC0 Offset: 0x2141C0 VA: 0x180214DC0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x18AA450 Offset: 0x18A9850 VA: 0x1818AA450
	public static float Parse(string s) { }

	// RVA: 0x18AA420 Offset: 0x18A9820 VA: 0x1818AA420
	public static float Parse(string s, IFormatProvider provider) { }

	// RVA: 0x18AA480 Offset: 0x18A9880 VA: 0x1818AA480
	public static float Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x18AA4D0 Offset: 0x18A98D0 VA: 0x1818AA4D0
	private static float Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x18AA960 Offset: 0x18A9D60 VA: 0x1818AA960
	public static bool TryParse(string s, out float result) { }

	// RVA: 0x18AA900 Offset: 0x18A9D00 VA: 0x1818AA900
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result) { }

	// RVA: 0x18AA770 Offset: 0x18A9B70 VA: 0x1818AA770
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out float result) { }

	// RVA: 0x214800 Offset: 0x213C00 VA: 0x180214800 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x214810 Offset: 0x213C10 VA: 0x180214810 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x2148D0 Offset: 0x213CD0 VA: 0x1802148D0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x214AF0 Offset: 0x213EF0 VA: 0x180214AF0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x214870 Offset: 0x213C70 VA: 0x180214870 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x2149D0 Offset: 0x213DD0 VA: 0x1802149D0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x214BF0 Offset: 0x213FF0 VA: 0x180214BF0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x214A30 Offset: 0x213E30 VA: 0x180214A30 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x214C50 Offset: 0x214050 VA: 0x180214C50 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x214A90 Offset: 0x213E90 VA: 0x180214A90 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x214CB0 Offset: 0x2140B0 VA: 0x180214CB0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0xF2270 Offset: 0xF1670 VA: 0x1800F2270 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x214970 Offset: 0x213D70 VA: 0x180214970 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x2148F0 Offset: 0x213CF0 VA: 0x1802148F0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x2148E0 Offset: 0x213CE0 VA: 0x1802148E0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x214B50 Offset: 0x213F50 VA: 0x180214B50 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

