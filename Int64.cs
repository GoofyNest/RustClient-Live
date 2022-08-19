public struct Int64 : IComparable, IFormattable, IConvertible, IComparable<long>, IEquatable<long> // TypeDefIndex: 259
{	// Fields
	internal long m_value; // 0x0
	public const long MaxValue = 9223372036854775807;
	public const long MinValue = -9223372036854775808;

	// Methods

	// RVA: 0x1FB060 Offset: 0x1FA460 VA: 0x1801FB060 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1FB040 Offset: 0x1FA440 VA: 0x1801FB040 Slot: 23
	public int CompareTo(long value) { }

	// RVA: 0x1FB160 Offset: 0x1FA560 VA: 0x1801FB160 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F59E0 Offset: 0x1F4DE0 VA: 0x1801F59E0 Slot: 24
	public bool Equals(long obj) { }

	// RVA: 0x1F5A80 Offset: 0x1F4E80 VA: 0x1801F5A80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1FB7B0 Offset: 0x1FABB0 VA: 0x1801FB7B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FB740 Offset: 0x1FAB40 VA: 0x1801FB740 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1FB770 Offset: 0x1FAB70 VA: 0x1801FB770
	public string ToString(string format) { }

	// RVA: 0x1FB7E0 Offset: 0x1FABE0 VA: 0x1801FB7E0 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x166DB10 Offset: 0x166CF10 VA: 0x18166DB10
	public static long Parse(string s) { }

	// RVA: 0x166DAE0 Offset: 0x166CEE0 VA: 0x18166DAE0
	public static long Parse(string s, IFormatProvider provider) { }

	// RVA: 0x166DA90 Offset: 0x166CE90 VA: 0x18166DA90
	public static long Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x166DCF0 Offset: 0x166D0F0 VA: 0x18166DCF0
	public static bool TryParse(string s, out long result) { }

	// RVA: 0x166DD30 Offset: 0x166D130 VA: 0x18166DD30
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result) { }

	// RVA: 0x1FB1F0 Offset: 0x1FA5F0 VA: 0x1801FB1F0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1FB200 Offset: 0x1FA600 VA: 0x1801FB200 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1FB2C0 Offset: 0x1FA6C0 VA: 0x1801FB2C0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1FB4D0 Offset: 0x1FA8D0 VA: 0x1801FB4D0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1FB260 Offset: 0x1FA660 VA: 0x1801FB260 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1FB410 Offset: 0x1FA810 VA: 0x1801FB410 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1FB620 Offset: 0x1FAA20 VA: 0x1801FB620 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1FB470 Offset: 0x1FA870 VA: 0x1801FB470 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1FB680 Offset: 0x1FAA80 VA: 0x1801FB680 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1FB6E0 Offset: 0x1FAAE0 VA: 0x1801FB6E0 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1FB530 Offset: 0x1FA930 VA: 0x1801FB530 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1FB3B0 Offset: 0x1FA7B0 VA: 0x1801FB3B0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1FB330 Offset: 0x1FA730 VA: 0x1801FB330 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1FB320 Offset: 0x1FA720 VA: 0x1801FB320 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1FB590 Offset: 0x1FA990 VA: 0x1801FB590 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

