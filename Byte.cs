public struct Byte : IComparable, IFormattable, IConvertible, IComparable<byte>, IEquatable<byte> // TypeDefIndex: 181
{
	private byte m_value; 
	public const byte MaxValue = 255;
	public const byte MinValue = 0;


	public int CompareTo(object value) { }

	public int CompareTo(byte value) { }

	public override bool Equals(object obj) { }

	public bool Equals(byte obj) { }

	public override int GetHashCode() { }

	public static byte Parse(string s, IFormatProvider provider) { }

	public static byte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	private static byte Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	public static bool TryParse(string s, out byte result) { }

	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out byte result) { }

	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out byte result) { }

	public override string ToString() { }

	public string ToString(string format) { }

	public string ToString(IFormatProvider provider) { }

	public string ToString(string format, IFormatProvider provider) { }

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

