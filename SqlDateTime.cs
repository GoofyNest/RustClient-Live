public struct SqlDateTime : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4343
{	// Fields
	private bool m_fNotNull; // 0x0
	private int m_day; // 0x4
	private int m_time; // 0x8
	private static readonly double s_SQLTicksPerMillisecond; // 0x0
	public static readonly int SQLTicksPerSecond; // 0x8
	public static readonly int SQLTicksPerMinute; // 0xC
	public static readonly int SQLTicksPerHour; // 0x10
	private static readonly int s_SQLTicksPerDay; // 0x14
	private static readonly long s_ticksPerSecond; // 0x18
	private static readonly DateTime s_SQLBaseDate; // 0x20
	private static readonly long s_SQLBaseDateTicks; // 0x28
	private static readonly int s_minYear; // 0x30
	private static readonly int s_maxYear; // 0x34
	private static readonly int s_minDay; // 0x38
	private static readonly int s_maxDay; // 0x3C
	private static readonly int s_minTime; // 0x40
	private static readonly int s_maxTime; // 0x44
	private static readonly int s_dayBase; // 0x48
	private static readonly int[] s_daysToMonth365; // 0x50
	private static readonly int[] s_daysToMonth366; // 0x58
	private static readonly DateTime s_minDateTime; // 0x60
	private static readonly DateTime s_maxDateTime; // 0x68
	private static readonly TimeSpan s_minTimeSpan; // 0x70
	private static readonly TimeSpan s_maxTimeSpan; // 0x78
	private static readonly string s_ISO8601_DateTimeFormat; // 0x80
	private static readonly string[] s_dateTimeFormats; // 0x88
	public static readonly SqlDateTime MinValue; // 0x90
	public static readonly SqlDateTime MaxValue; // 0x9C
	public static readonly SqlDateTime Null; // 0xA8

	// Properties
	public bool IsNull { get; }
	public DateTime Value { get; }
	public int DayTicks { get; }
	public int TimeTicks { get; }

	// Methods

	// RVA: 0x138F30 Offset: 0x138330 VA: 0x180138F30
	private void .ctor(bool fNull) { }

	// RVA: 0x138F50 Offset: 0x138350 VA: 0x180138F50
	public void .ctor(DateTime value) { }

	// RVA: 0x138F40 Offset: 0x138340 VA: 0x180138F40
	public void .ctor(int dayTicks, int timeTicks) { }

	// RVA: 0x117FE0 Offset: 0x1173E0 VA: 0x180117FE0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0xEB3290 Offset: 0xEB2690 VA: 0x180EB3290
	private static TimeSpan ToTimeSpan(SqlDateTime value) { }

	// RVA: 0xEB3180 Offset: 0xEB2580 VA: 0x180EB3180
	private static DateTime ToDateTime(SqlDateTime value) { }

	// RVA: 0xEB2BE0 Offset: 0xEB1FE0 VA: 0x180EB2BE0
	private static SqlDateTime FromTimeSpan(TimeSpan value) { }

	// RVA: 0xEB2AB0 Offset: 0xEB1EB0 VA: 0x180EB2AB0
	private static SqlDateTime FromDateTime(DateTime value) { }

	// RVA: 0x139020 Offset: 0x138420 VA: 0x180139020
	public DateTime get_Value() { }

	// RVA: 0x138F60 Offset: 0x138360 VA: 0x180138F60
	public int get_DayTicks() { }

	// RVA: 0x138FC0 Offset: 0x1383C0 VA: 0x180138FC0
	public int get_TimeTicks() { }

	// RVA: 0xEB3ED0 Offset: 0xEB32D0 VA: 0x180EB3ED0
	public static SqlDateTime op_Implicit(DateTime value) { }

	// RVA: 0x138E70 Offset: 0x138270 VA: 0x180138E70 Slot: 3
	public override string ToString() { }

	// RVA: 0xEB3CF0 Offset: 0xEB30F0 VA: 0x180EB3CF0
	public static SqlBoolean op_Equality(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xEB3F00 Offset: 0xEB3300 VA: 0x180EB3F00
	public static SqlBoolean op_LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xEB3DC0 Offset: 0xEB31C0 VA: 0x180EB3DC0
	public static SqlBoolean op_GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xEB2EE0 Offset: 0xEB22E0 VA: 0x180EB2EE0
	public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xEB2E50 Offset: 0xEB2250 VA: 0x180EB2E50
	public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x138B10 Offset: 0x137F10 VA: 0x180138B10 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x138C30 Offset: 0x138030 VA: 0x180138C30
	public int CompareTo(SqlDateTime value) { }

	// RVA: 0x138C60 Offset: 0x138060 VA: 0x180138C60 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x138C70 Offset: 0x138070 VA: 0x180138C70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117C10 Offset: 0x117010 VA: 0x180117C10 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x138D40 Offset: 0x138140 VA: 0x180138D40 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x138D50 Offset: 0x138150 VA: 0x180138D50 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xEB2DF0 Offset: 0xEB21F0 VA: 0x180EB2DF0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xEB3330 Offset: 0xEB2730 VA: 0x180EB3330
	private static void .cctor() { }

}

