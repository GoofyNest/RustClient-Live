public struct Byte : IComparable, IFormattable, IConvertible, IComparable<byte>, IEquatable<byte> // TypeDefIndex: 181
{	// Fields
	private byte m_value; // 0x0
	public const byte MaxValue = 255;
	public const byte MinValue = 0;

	// Methods

	// RVA: 0x1F2BB0 Offset: 0x1F1FB0 VA: 0x1801F2BB0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1F2BA0 Offset: 0x1F1FA0 VA: 0x1801F2BA0 Slot: 23
	public int CompareTo(byte value) { }

	// RVA: 0x1F2C80 Offset: 0x1F2080 VA: 0x1801F2C80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1DF340 Offset: 0x1DE740 VA: 0x1801DF340 Slot: 24
	public bool Equals(byte obj) { }

	// RVA: 0x14CAA0 Offset: 0x14BEA0 VA: 0x18014CAA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x158E6C0 Offset: 0x158DAC0 VA: 0x18158E6C0
	public static byte Parse(string s, IFormatProvider provider) { }

	// RVA: 0x158E6F0 Offset: 0x158DAF0 VA: 0x18158E6F0
	public static byte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x158E5D0 Offset: 0x158D9D0 VA: 0x18158E5D0
	private static byte Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x158EEF0 Offset: 0x158E2F0 VA: 0x18158EEF0
	public static bool TryParse(string s, out byte result) { }

	// RVA: 0x158EE10 Offset: 0x158E210 VA: 0x18158EE10
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out byte result) { }

	// RVA: 0x158EEA0 Offset: 0x158E2A0 VA: 0x18158EEA0
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out byte result) { }

	// RVA: 0x1F3290 Offset: 0x1F2690 VA: 0x1801F3290 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F32C0 Offset: 0x1F26C0 VA: 0x1801F32C0
	public string ToString(string format) { }

	// RVA: 0x1F3260 Offset: 0x1F2660 VA: 0x1801F3260 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1F3300 Offset: 0x1F2700 VA: 0x1801F3300 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1F2D10 Offset: 0x1F2110 VA: 0x1801F2D10 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1F2D20 Offset: 0x1F2120 VA: 0x1801F2D20 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1F2D80 Offset: 0x1F2180 VA: 0x1801F2D80 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1F2FF0 Offset: 0x1F23F0 VA: 0x1801F2FF0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x14CAA0 Offset: 0x14BEA0 VA: 0x18014CAA0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1F2ED0 Offset: 0x1F22D0 VA: 0x1801F2ED0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1F3140 Offset: 0x1F2540 VA: 0x1801F3140 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1F2F30 Offset: 0x1F2330 VA: 0x1801F2F30 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1F31A0 Offset: 0x1F25A0 VA: 0x1801F31A0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1F2F90 Offset: 0x1F2390 VA: 0x1801F2F90 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1F3200 Offset: 0x1F2600 VA: 0x1801F3200 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1F3050 Offset: 0x1F2450 VA: 0x1801F3050 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1F2E70 Offset: 0x1F2270 VA: 0x1801F2E70 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1F2DF0 Offset: 0x1F21F0 VA: 0x1801F2DF0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1F2DE0 Offset: 0x1F21E0 VA: 0x1801F2DE0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1F30B0 Offset: 0x1F24B0 VA: 0x1801F30B0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

