public struct Single : IComparable, IFormattable, IConvertible, IComparable<float>, IEquatable<float> // TypeDefIndex: 299
{	internal float m_value; // 0x0
	public const float MinValue = -3,402823E+38;
	public const float Epsilon = 1,401298E-45;
	public const float MaxValue = 3,402823E+38;
	public const float PositiveInfinity = ∞;
	public const float NegativeInfinity = -∞;
	public const float NaN = ¤¤¤;


	public static bool IsInfinity(float f) { }

	public static bool IsPositiveInfinity(float f) { }

	public static bool IsNegativeInfinity(float f) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	public static bool IsNaN(float f) { }

	public static bool IsFinite(float f) { }

	public int CompareTo(object value) { }

	public int CompareTo(float value) { }

	public override bool Equals(object obj) { }

	public bool Equals(float obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public string ToString(IFormatProvider provider) { }

	public string ToString(string format) { }

	public string ToString(string format, IFormatProvider provider) { }

	public static float Parse(string s) { }

	public static float Parse(string s, IFormatProvider provider) { }

	public static float Parse(string s, NumberStyles style, IFormatProvider provider) { }

	private static float Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	public static bool TryParse(string s, out float result) { }

	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result) { }

	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out float result) { }

	public TypeCode GetTypeCode() { }

	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

