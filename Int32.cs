public struct Int32 : IComparable, IFormattable, IConvertible, IComparable<int>, IEquatable<int> // TypeDefIndex: 258
{
	internal int m_value;
	public const int MaxValue = 2147483647;
	public const int MinValue = -2147483648;


	public int CompareTo(object value) { }

	public int CompareTo(int value) { }

	public override bool Equals(object obj) { }

	public bool Equals(int obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public string ToString(string format) { }

	public string ToString(IFormatProvider provider) { }

	public string ToString(string format, IFormatProvider provider) { }

	public static int Parse(string s) { }

	public static int Parse(string s, NumberStyles style) { }

	public static int Parse(string s, IFormatProvider provider) { }

	public static int Parse(string s, NumberStyles style, IFormatProvider provider) { }

	public static bool TryParse(string s, out int result) { }

	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out int result) { }

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

