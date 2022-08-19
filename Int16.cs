public struct Int16 : IComparable, IFormattable, IConvertible, IComparable<short>, IEquatable<short> // TypeDefIndex: 257
{	// Fields
	internal short m_value; // 0x0
	public const short MaxValue = 32767;
	public const short MinValue = -32768;

	// Methods

	// RVA: 0x1FA110 Offset: 0x1F9510 VA: 0x1801FA110 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1FA100 Offset: 0x1F9500 VA: 0x1801FA100 Slot: 23
	public int CompareTo(short value) { }

	// RVA: 0x1FA1E0 Offset: 0x1F95E0 VA: 0x1801FA1E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F34B0 Offset: 0x1F28B0 VA: 0x1801F34B0 Slot: 24
	public bool Equals(short obj) { }

	// RVA: 0x1FA270 Offset: 0x1F9670 VA: 0x1801FA270 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1FA810 Offset: 0x1F9C10 VA: 0x1801FA810 Slot: 3
	public override string ToString() { }

	// RVA: 0x1FA7D0 Offset: 0x1F9BD0 VA: 0x1801FA7D0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1FA840 Offset: 0x1F9C40 VA: 0x1801FA840 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1FA800 Offset: 0x1F9C00 VA: 0x1801FA800
	private string ToString(string format, NumberFormatInfo info) { }

	// RVA: 0x166CE20 Offset: 0x166C220 VA: 0x18166CE20
	public static short Parse(string s, IFormatProvider provider) { }

	// RVA: 0x166CE50 Offset: 0x166C250 VA: 0x18166CE50
	public static short Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x166CEA0 Offset: 0x166C2A0 VA: 0x18166CEA0
	private static short Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x166D3B0 Offset: 0x166C7B0 VA: 0x18166D3B0
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out short result) { }

	// RVA: 0x166D330 Offset: 0x166C730 VA: 0x18166D330
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out short result) { }

	// RVA: 0x1FA280 Offset: 0x1F9680 VA: 0x1801FA280 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1FA290 Offset: 0x1F9690 VA: 0x1801FA290 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1FA350 Offset: 0x1F9750 VA: 0x1801FA350 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1FA560 Offset: 0x1F9960 VA: 0x1801FA560 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1FA2F0 Offset: 0x1F96F0 VA: 0x1801FA2F0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x120F10 Offset: 0x120310 VA: 0x180120F10 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1FA6B0 Offset: 0x1F9AB0 VA: 0x1801FA6B0 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1FA4A0 Offset: 0x1F98A0 VA: 0x1801FA4A0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1FA710 Offset: 0x1F9B10 VA: 0x1801FA710 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1FA500 Offset: 0x1F9900 VA: 0x1801FA500 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1FA770 Offset: 0x1F9B70 VA: 0x1801FA770 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1FA5C0 Offset: 0x1F99C0 VA: 0x1801FA5C0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1FA440 Offset: 0x1F9840 VA: 0x1801FA440 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1FA3C0 Offset: 0x1F97C0 VA: 0x1801FA3C0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1FA3B0 Offset: 0x1F97B0 VA: 0x1801FA3B0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1FA620 Offset: 0x1F9A20 VA: 0x1801FA620 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

