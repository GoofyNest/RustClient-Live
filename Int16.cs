public struct Int16 : IComparable, IFormattable, IConvertible, IComparable<short>, IEquatable<short> // TypeDefIndex: 257
{
	internal short m_value; 
public const short MaxValue = 32767;
public const short MinValue = -32768;


public int CompareTo(object value) { }

public int CompareTo(short value) { }

public override bool Equals(object obj) { }

public bool Equals(short obj) { }

public override int GetHashCode() { }

public override string ToString() { }

public string ToString(IFormatProvider provider) { }

public string ToString(string format, IFormatProvider provider) { }

private string ToString(string format, NumberFormatInfo info) { }

public static short Parse(string s, IFormatProvider provider) { }

public static short Parse(string s, NumberStyles style, IFormatProvider provider) { }

private static short Parse(string s, NumberStyles style, NumberFormatInfo info) { }

public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out short result) { }

private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out short result) { }

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

