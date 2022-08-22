public struct SqlDateTime : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4343
{	private bool m_fNotNull; // 0x0
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

	public bool IsNull { get; }
	public DateTime Value { get; }
	public int DayTicks { get; }
	public int TimeTicks { get; }


	private void .ctor(bool fNull) { }

	public void .ctor(DateTime value) { }

	public void .ctor(int dayTicks, int timeTicks) { }

	public bool get_IsNull() { }

	private static TimeSpan ToTimeSpan(SqlDateTime value) { }

	private static DateTime ToDateTime(SqlDateTime value) { }

	private static SqlDateTime FromTimeSpan(TimeSpan value) { }

	private static SqlDateTime FromDateTime(DateTime value) { }

	public DateTime get_Value() { }

	public int get_DayTicks() { }

	public int get_TimeTicks() { }

	public static SqlDateTime op_Implicit(DateTime value) { }

	public override string ToString() { }

	public static SqlBoolean op_Equality(SqlDateTime x, SqlDateTime y) { }

	public static SqlBoolean op_LessThan(SqlDateTime x, SqlDateTime y) { }

	public static SqlBoolean op_GreaterThan(SqlDateTime x, SqlDateTime y) { }

	public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y) { }

	public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y) { }

	public int CompareTo(object value) { }

	public int CompareTo(SqlDateTime value) { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	private static void .cctor() { }

}

