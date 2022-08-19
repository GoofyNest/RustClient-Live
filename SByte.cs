public struct SByte : IComparable, IFormattable, IConvertible, IComparable<sbyte>, IEquatable<sbyte> // TypeDefIndex: 296
{	// Fields
	private sbyte m_value; // 0x0
	public const sbyte MaxValue = 127;
	public const sbyte MinValue = -128;

	// Methods

	// RVA: 0x1DF1E0 Offset: 0x1DE5E0 VA: 0x1801DF1E0 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x1DF1D0 Offset: 0x1DE5D0 VA: 0x1801DF1D0 Slot: 23
	public int CompareTo(sbyte value) { }

	// RVA: 0x1DF2B0 Offset: 0x1DE6B0 VA: 0x1801DF2B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1DF340 Offset: 0x1DE740 VA: 0x1801DF340 Slot: 24
	public bool Equals(sbyte obj) { }

	// RVA: 0x1DF350 Offset: 0x1DE750 VA: 0x1801DF350 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1DF9D0 Offset: 0x1DEDD0 VA: 0x1801DF9D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1DF900 Offset: 0x1DED00 VA: 0x1801DF900 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1DF930 Offset: 0x1DED30 VA: 0x1801DF930 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1DF860 Offset: 0x1DEC60 VA: 0x1801DF860
	private string ToString(string format, NumberFormatInfo info) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x129EDC0 Offset: 0x129E1C0 VA: 0x18129EDC0
	public static sbyte Parse(string s, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x129ED70 Offset: 0x129E170 VA: 0x18129ED70
	public static sbyte Parse(string s, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x129EDF0 Offset: 0x129E1F0 VA: 0x18129EDF0
	private static sbyte Parse(string s, NumberStyles style, NumberFormatInfo info) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x129F190 Offset: 0x129E590 VA: 0x18129F190
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out sbyte result) { }

	// RVA: 0x129F110 Offset: 0x129E510 VA: 0x18129F110
	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out sbyte result) { }

	// RVA: 0x1DF360 Offset: 0x1DE760 VA: 0x1801DF360 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x1DF370 Offset: 0x1DE770 VA: 0x1801DF370 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1DF430 Offset: 0x1DE830 VA: 0x1801DF430 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x14CAA0 Offset: 0x14BEA0 VA: 0x18014CAA0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1DF3D0 Offset: 0x1DE7D0 VA: 0x1801DF3D0 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1DF580 Offset: 0x1DE980 VA: 0x1801DF580 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1DF740 Offset: 0x1DEB40 VA: 0x1801DF740 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1DF5E0 Offset: 0x1DE9E0 VA: 0x1801DF5E0 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1DF7A0 Offset: 0x1DEBA0 VA: 0x1801DF7A0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1DF5F0 Offset: 0x1DE9F0 VA: 0x1801DF5F0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1DF800 Offset: 0x1DEC00 VA: 0x1801DF800 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1DF650 Offset: 0x1DEA50 VA: 0x1801DF650 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1DF520 Offset: 0x1DE920 VA: 0x1801DF520 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1DF4A0 Offset: 0x1DE8A0 VA: 0x1801DF4A0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1DF490 Offset: 0x1DE890 VA: 0x1801DF490 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1DF6B0 Offset: 0x1DEAB0 VA: 0x1801DF6B0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

}

