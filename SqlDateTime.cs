public struct SqlDateTime : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4343
{
	private bool m_fNotNull; 
	private int m_day; 
	private int m_time; 
	private static readonly double s_SQLTicksPerMillisecond; 
	public static readonly int SQLTicksPerSecond; 
	public static readonly int SQLTicksPerMinute; 
	public static readonly int SQLTicksPerHour; 
	private static readonly int s_SQLTicksPerDay; 
	private static readonly long s_ticksPerSecond; 
	private static readonly DateTime s_SQLBaseDate; 
	private static readonly long s_SQLBaseDateTicks; 
	private static readonly int s_minYear; 
	private static readonly int s_maxYear; 
	private static readonly int s_minDay; 
	private static readonly int s_maxDay; 
	private static readonly int s_minTime; 
	private static readonly int s_maxTime; 
	private static readonly int s_dayBase; 
	private static readonly int[] s_daysToMonth365; 
	private static readonly int[] s_daysToMonth366; 
	private static readonly DateTime s_minDateTime; 
	private static readonly DateTime s_maxDateTime; 
	private static readonly TimeSpan s_minTimeSpan; 
	private static readonly TimeSpan s_maxTimeSpan; 
	private static readonly string s_ISO8601_DateTimeFormat; 
	private static readonly string[] s_dateTimeFormats; 
	public static readonly SqlDateTime MinValue; 
	public static readonly SqlDateTime MaxValue; 
	public static readonly SqlDateTime Null; 

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

