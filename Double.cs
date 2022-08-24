public struct Double : IComparable, IFormattable, IConvertible, IComparable<double>, IEquatable<double> // TypeDefIndex: 208
{
	internal double m_value; 
	public const double MinValue = -1,79769313486232E+308;
	public const double MaxValue = 1,79769313486232E+308;
	public const double Epsilon = 4,94065645841247E-324;
	public const double NegativeInfinity = -∞;
	public const double PositiveInfinity = ∞;
	public const double NaN = ¤¤¤;
	internal static double NegativeZero; 


	public static bool IsInfinity(double d) { }

	public static bool IsPositiveInfinity(double d) { }

	public static bool IsNegativeInfinity(double d) { }

	[ReliabilityContractAttribute] 
	public static bool IsNaN(double d) { }

	public static bool IsFinite(double d) { }

	public int CompareTo(object value) { }

	public int CompareTo(double value) { }

	public override bool Equals(object obj) { }

	public bool Equals(double obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public string ToString(string format) { }

	public string ToString(IFormatProvider provider) { }

	public string ToString(string format, IFormatProvider provider) { }

	public static double Parse(string s) { }

	public static double Parse(string s, IFormatProvider provider) { }

	public static double Parse(string s, NumberStyles style, IFormatProvider provider) { }

	private static double Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	public static bool TryParse(string s, out double result) { }

	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result) { }

	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out double result) { }

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

	private static void .cctor() { }

}

