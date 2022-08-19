public struct Int32 : IComparable, IFormattable, IConvertible, IComparable<int>, IEquatable<int> // TypeDefIndex: 258
{	// Fields
	internal int m_value; // 0x0
	public const int MaxValue = 2147483647;
	public const int MinValue = -2147483648;

	// Methods

	// RVA: 0x1FA880 Offset: 0x1F9C80 VA: 0x1801FA880 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1FA980 Offset: 0x1F9D80 VA: 0x1801FA980 Slot: 23
	public int CompareTo(int value) { }

	// RVA: 0x1FA9A0 Offset: 0x1F9DA0 VA: 0x1801FA9A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E4EF0 Offset: 0x1E42F0 VA: 0x1801E4EF0 Slot: 24
	public bool Equals(int obj) { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1FAF60 Offset: 0x1FA360 VA: 0x1801FAF60 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FAFC0 Offset: 0x1FA3C0 VA: 0x1801FAFC0
	public string ToString(string format) { }

	// RVA: 0x1FAF90 Offset: 0x1FA390 VA: 0x1801FAF90 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1FB000 Offset: 0x1FA400 VA: 0x1801FB000 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x166D620 Offset: 0x166CA20 VA: 0x18166D620
	public static int Parse(string s) { }

	// RVA: 0x166D680 Offset: 0x166CA80 VA: 0x18166D680
	public static int Parse(string s, NumberStyles style) { }

	// RVA: 0x166D650 Offset: 0x166CA50 VA: 0x18166D650
	public static int Parse(string s, IFormatProvider provider) { }

	// RVA: 0x166D5D0 Offset: 0x166C9D0 VA: 0x18166D5D0
	public static int Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x166D860 Offset: 0x166CC60 VA: 0x18166D860
	public static bool TryParse(string s, out int result) { }

	// RVA: 0x166D8A0 Offset: 0x166CCA0 VA: 0x18166D8A0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out int result) { }

	// RVA: 0x1FAA20 Offset: 0x1F9E20 VA: 0x1801FAA20 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1FAA30 Offset: 0x1F9E30 VA: 0x1801FAA30 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1FAAF0 Offset: 0x1F9EF0 VA: 0x1801FAAF0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1FACF0 Offset: 0x1FA0F0 VA: 0x1801FACF0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1FAA90 Offset: 0x1F9E90 VA: 0x1801FAA90 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1FAC30 Offset: 0x1FA030 VA: 0x1801FAC30 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1FAE40 Offset: 0x1FA240 VA: 0x1801FAE40 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1FAEA0 Offset: 0x1FA2A0 VA: 0x1801FAEA0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1FAC90 Offset: 0x1FA090 VA: 0x1801FAC90 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1FAF00 Offset: 0x1FA300 VA: 0x1801FAF00 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1FAD50 Offset: 0x1FA150 VA: 0x1801FAD50 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1FABD0 Offset: 0x1F9FD0 VA: 0x1801FABD0 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1FAB60 Offset: 0x1F9F60 VA: 0x1801FAB60 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1FAB50 Offset: 0x1F9F50 VA: 0x1801FAB50 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1FADB0 Offset: 0x1FA1B0 VA: 0x1801FADB0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

