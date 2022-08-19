public struct DateTime : IComparable, IFormattable, IConvertible, ISerializable, IComparable<DateTime>, IEquatable<DateTime> // TypeDefIndex: 197
{	// Fields
	private const long TicksPerMillisecond = 10000;
	private const long TicksPerSecond = 10000000;
	private const long TicksPerMinute = 600000000;
	private const long TicksPerHour = 36000000000;
	private const long TicksPerDay = 864000000000;
	private const int MillisPerSecond = 1000;
	private const int MillisPerMinute = 60000;
	private const int MillisPerHour = 3600000;
	private const int MillisPerDay = 86400000;
	private const int DaysPerYear = 365;
	private const int DaysPer4Years = 1461;
	private const int DaysPer100Years = 36524;
	private const int DaysPer400Years = 146097;
	private const int DaysTo1601 = 584388;
	private const int DaysTo1899 = 693593;
	internal const int DaysTo1970 = 719162;
	private const int DaysTo10000 = 3652059;
	internal const long MinTicks = 0;
	internal const long MaxTicks = 3155378975999999999;
	private const long MaxMillis = 315537897600000;
	private const long FileTimeOffset = 504911232000000000;
	private const long DoubleDateOffset = 599264352000000000;
	private const long OADateMinAsTicks = 31241376000000000;
	private const double OADateMinAsDouble = -657435;
	private const double OADateMaxAsDouble = 2958466;
	private const int DatePartYear = 0;
	private const int DatePartDayOfYear = 1;
	private const int DatePartMonth = 2;
	private const int DatePartDay = 3;
	private static readonly int[] DaysToMonth365; // 0x0
	private static readonly int[] DaysToMonth366; // 0x8
	public static readonly DateTime MinValue; // 0x10
	public static readonly DateTime MaxValue; // 0x18
	private const ulong TicksMask = 4611686018427387903;
	private const ulong FlagsMask = 13835058055282163712;
	private const ulong LocalMask = 9223372036854775808;
	private const long TicksCeiling = 4611686018427387904;
	private const ulong KindUnspecified = 0;
	private const ulong KindUtc = 4611686018427387904;
	private const ulong KindLocal = 9223372036854775808;
	private const ulong KindLocalAmbiguousDst = 13835058055282163712;
	private const int KindShift = 62;
	private const string TicksField = "ticks";
	private const string DateDataField = "dateData";
	private ulong dateData; // 0x0

	// Properties
	internal long InternalTicks { get; }
	private ulong InternalKind { get; }
	public DateTime Date { get; }
	public int Day { get; }
	public DayOfWeek DayOfWeek { get; }
	public int Hour { get; }
	public DateTimeKind Kind { get; }
	public int Millisecond { get; }
	public int Minute { get; }
	public int Month { get; }
	public static DateTime Now { get; }
	public static DateTime UtcNow { get; }
	public int Second { get; }
	public long Ticks { get; }
	public TimeSpan TimeOfDay { get; }
	public int Year { get; }

	// Methods

	// RVA: 0x20CAA0 Offset: 0x20BEA0 VA: 0x18020CAA0
	public void .ctor(long ticks) { }

	// RVA: 0x1D2D40 Offset: 0x1D2140 VA: 0x1801D2D40
	private void .ctor(ulong dateData) { }

	// RVA: 0x20CAB0 Offset: 0x20BEB0 VA: 0x18020CAB0
	public void .ctor(long ticks, DateTimeKind kind) { }

	// RVA: 0x20CD60 Offset: 0x20C160 VA: 0x18020CD60
	internal void .ctor(long ticks, DateTimeKind kind, bool isAmbiguousDst) { }

	// RVA: 0x20CE80 Offset: 0x20C280 VA: 0x18020CE80
	public void .ctor(int year, int month, int day) { }

	// RVA: 0x20CAE0 Offset: 0x20BEE0 VA: 0x18020CAE0
	public void .ctor(int year, int month, int day, int hour, int minute, int second) { }

	// RVA: 0x20CD70 Offset: 0x20C170 VA: 0x18020CD70
	public void .ctor(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind) { }

	// RVA: 0x20CB80 Offset: 0x20BF80 VA: 0x18020CB80
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	// RVA: 0x20CE70 Offset: 0x20C270 VA: 0x18020CE70
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind) { }

	// RVA: 0x20CAC0 Offset: 0x20BEC0 VA: 0x18020CAC0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x20D010 Offset: 0x20C410 VA: 0x18020D010
	internal long get_InternalTicks() { }

	// RVA: 0x20CFF0 Offset: 0x20C3F0 VA: 0x18020CFF0
	private ulong get_InternalKind() { }

	// RVA: 0x20BEE0 Offset: 0x20B2E0 VA: 0x18020BEE0
	public DateTime Add(TimeSpan value) { }

	// RVA: 0x20BEF0 Offset: 0x20B2F0 VA: 0x18020BEF0
	private DateTime Add(double value, int scale) { }

	// RVA: 0x20BDB0 Offset: 0x20B1B0 VA: 0x18020BDB0
	public DateTime AddDays(double value) { }

	// RVA: 0x20BDD0 Offset: 0x20B1D0 VA: 0x18020BDD0
	public DateTime AddHours(double value) { }

	// RVA: 0x20BDF0 Offset: 0x20B1F0 VA: 0x18020BDF0
	public DateTime AddMilliseconds(double value) { }

	// RVA: 0x20BE00 Offset: 0x20B200 VA: 0x18020BE00
	public DateTime AddMonths(int months) { }

	// RVA: 0x20BE10 Offset: 0x20B210 VA: 0x18020BE10
	public DateTime AddSeconds(double value) { }

	// RVA: 0x20BE30 Offset: 0x20B230 VA: 0x18020BE30
	public DateTime AddTicks(long value) { }

	// RVA: 0x20BE40 Offset: 0x20B240 VA: 0x18020BE40
	public DateTime AddYears(int value) { }

	// RVA: 0x179EB70 Offset: 0x179DF70 VA: 0x18179EB70
	public static int Compare(DateTime t1, DateTime t2) { }

	// RVA: 0x20BF30 Offset: 0x20B330 VA: 0x18020BF30 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x20BF00 Offset: 0x20B300 VA: 0x18020BF00 Slot: 24
	public int CompareTo(DateTime value) { }

	// RVA: 0x179EB90 Offset: 0x179DF90 VA: 0x18179EB90
	private static long DateToTicks(int year, int month, int day) { }

	// RVA: 0x17A0B40 Offset: 0x179FF40 VA: 0x1817A0B40
	private static long TimeToTicks(int hour, int minute, int second) { }

	// RVA: 0x179ED80 Offset: 0x179E180 VA: 0x18179ED80
	public static int DaysInMonth(int year, int month) { }

	// RVA: 0x179EEE0 Offset: 0x179E2E0 VA: 0x18179EEE0
	internal static long DoubleDateToTicks(double value) { }

	// RVA: 0x20C030 Offset: 0x20B430 VA: 0x18020C030 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x20C010 Offset: 0x20B410 VA: 0x18020C010 Slot: 25
	public bool Equals(DateTime value) { }

	// RVA: 0x179F1B0 Offset: 0x179E5B0 VA: 0x18179F1B0
	public static DateTime FromBinary(long dateData) { }

	// RVA: 0x179F110 Offset: 0x179E510 VA: 0x18179F110
	internal static DateTime FromBinaryRaw(long dateData) { }

	// RVA: 0x179F4E0 Offset: 0x179E8E0 VA: 0x18179F4E0
	public static DateTime FromFileTime(long fileTime) { }

	// RVA: 0x179F420 Offset: 0x179E820 VA: 0x18179F420
	public static DateTime FromFileTimeUtc(long fileTime) { }

	// RVA: 0x179F5E0 Offset: 0x179E9E0 VA: 0x18179F5E0
	public static DateTime FromOADate(double d) { }

	// RVA: 0x20C290 Offset: 0x20B690 VA: 0x18020C290 Slot: 23
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x179FF20 Offset: 0x179F320 VA: 0x18179FF20
	public static DateTime SpecifyKind(DateTime value, DateTimeKind kind) { }

	// RVA: 0x20C340 Offset: 0x20B740 VA: 0x18020C340
	public long ToBinary() { }

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	internal long ToBinaryRaw() { }

	// RVA: 0x20CF00 Offset: 0x20C300 VA: 0x18020CF00
	public DateTime get_Date() { }

	// RVA: 0x20C0C0 Offset: 0x20B4C0 VA: 0x18020C0C0
	private int GetDatePart(int part) { }

	// RVA: 0x20CF90 Offset: 0x20C390 VA: 0x18020CF90
	public int get_Day() { }

	// RVA: 0x20CF40 Offset: 0x20C340 VA: 0x18020CF40
	public DayOfWeek get_DayOfWeek() { }

	// RVA: 0x20C0D0 Offset: 0x20B4D0 VA: 0x18020C0D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x20CFA0 Offset: 0x20C3A0 VA: 0x18020CFA0
	public int get_Hour() { }

	// RVA: 0x20D030 Offset: 0x20C430 VA: 0x18020D030
	public DateTimeKind get_Kind() { }

	// RVA: 0x20D060 Offset: 0x20C460 VA: 0x18020D060
	public int get_Millisecond() { }

	// RVA: 0x20D0B0 Offset: 0x20C4B0 VA: 0x18020D0B0
	public int get_Minute() { }

	// RVA: 0x20D100 Offset: 0x20C500 VA: 0x18020D100
	public int get_Month() { }

	// RVA: 0x17A2830 Offset: 0x17A1C30 VA: 0x1817A2830
	public static DateTime get_Now() { }

	// RVA: 0x17A2AB0 Offset: 0x17A1EB0 VA: 0x1817A2AB0
	public static DateTime get_UtcNow() { }

	// RVA: 0x179F9C0 Offset: 0x179EDC0 VA: 0x18179F9C0
	internal static long GetSystemTimeAsFileTime() { }

	// RVA: 0x20D110 Offset: 0x20C510 VA: 0x18020D110
	public int get_Second() { }

	// RVA: 0x20D010 Offset: 0x20C410 VA: 0x18020D010
	public long get_Ticks() { }

	// RVA: 0x20D160 Offset: 0x20C560 VA: 0x18020D160
	public TimeSpan get_TimeOfDay() { }

	// RVA: 0x20D190 Offset: 0x20C590 VA: 0x18020D190
	public int get_Year() { }

	// RVA: 0x179F9D0 Offset: 0x179EDD0 VA: 0x18179F9D0
	public static bool IsLeapYear(int year) { }

	// RVA: 0x179FE90 Offset: 0x179F290 VA: 0x18179FE90
	public static DateTime Parse(string s, IFormatProvider provider) { }

	// RVA: 0x179FDE0 Offset: 0x179F1E0 VA: 0x18179FDE0
	public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles) { }

	// RVA: 0x179FAB0 Offset: 0x179EEB0 VA: 0x18179FAB0
	public static DateTime ParseExact(string s, string format, IFormatProvider provider) { }

	// RVA: 0x179FD10 Offset: 0x179F110 VA: 0x18179FD10
	public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style) { }

	// RVA: 0x179FB60 Offset: 0x179EF60 VA: 0x18179FB60
	public static DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style) { }

	// RVA: 0x20C100 Offset: 0x20B500 VA: 0x18020C100
	public TimeSpan Subtract(DateTime value) { }

	// RVA: 0x17A0A10 Offset: 0x179FE10 VA: 0x1817A0A10
	private static double TicksToOADate(long value) { }

	// RVA: 0x20C560 Offset: 0x20B960 VA: 0x18020C560
	public double ToOADate() { }

	// RVA: 0x20C3E0 Offset: 0x20B7E0 VA: 0x18020C3E0
	public long ToFileTime() { }

	// RVA: 0x20C3D0 Offset: 0x20B7D0 VA: 0x18020C3D0
	public long ToFileTimeUtc() { }

	// RVA: 0x20C4A0 Offset: 0x20B8A0 VA: 0x18020C4A0
	public DateTime ToLocalTime() { }

	// RVA: 0x20C4B0 Offset: 0x20B8B0 VA: 0x18020C4B0
	internal DateTime ToLocalTime(bool throwOnOverflow) { }

	// RVA: 0x20C4C0 Offset: 0x20B8C0 VA: 0x18020C4C0
	public string ToLongTimeString() { }

	// RVA: 0x20C6E0 Offset: 0x20BAE0 VA: 0x18020C6E0
	public string ToShortDateString() { }

	// RVA: 0x20C780 Offset: 0x20BB80 VA: 0x18020C780
	public string ToShortTimeString() { }

	// RVA: 0x20CA00 Offset: 0x20BE00 VA: 0x18020CA00 Slot: 3
	public override string ToString() { }

	// RVA: 0x20C820 Offset: 0x20BC20 VA: 0x18020C820
	public string ToString(string format) { }

	// RVA: 0x20C8C0 Offset: 0x20BCC0 VA: 0x18020C8C0 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x20C960 Offset: 0x20BD60 VA: 0x18020C960 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x20CA90 Offset: 0x20BE90 VA: 0x18020CA90
	public DateTime ToUniversalTime() { }

	// RVA: 0x17A1870 Offset: 0x17A0C70 VA: 0x1817A1870
	public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result) { }

	// RVA: 0x17A17A0 Offset: 0x17A0BA0 VA: 0x1817A17A0
	public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result) { }

	// RVA: 0x17A2B30 Offset: 0x17A1F30 VA: 0x1817A2B30
	public static DateTime op_Addition(DateTime d, TimeSpan t) { }

	// RVA: 0x17A2CB0 Offset: 0x17A20B0 VA: 0x1817A2CB0
	public static DateTime op_Subtraction(DateTime d, TimeSpan t) { }

	// RVA: 0x17A2D70 Offset: 0x17A2170 VA: 0x1817A2D70
	public static TimeSpan op_Subtraction(DateTime d1, DateTime d2) { }

	// RVA: 0x17A2BF0 Offset: 0x17A1FF0 VA: 0x1817A2BF0
	public static bool op_Equality(DateTime d1, DateTime d2) { }

	// RVA: 0x17A2C50 Offset: 0x17A2050 VA: 0x1817A2C50
	public static bool op_Inequality(DateTime d1, DateTime d2) { }

	// RVA: 0x17A2C90 Offset: 0x17A2090 VA: 0x1817A2C90
	public static bool op_LessThan(DateTime t1, DateTime t2) { }

	// RVA: 0x17A2C70 Offset: 0x17A2070 VA: 0x1817A2C70
	public static bool op_LessThanOrEqual(DateTime t1, DateTime t2) { }

	// RVA: 0x17A2C30 Offset: 0x17A2030 VA: 0x1817A2C30
	public static bool op_GreaterThan(DateTime t1, DateTime t2) { }

	// RVA: 0x17A2C10 Offset: 0x17A2010 VA: 0x1817A2C10
	public static bool op_GreaterThanOrEqual(DateTime t1, DateTime t2) { }

	// RVA: 0x20C0F0 Offset: 0x20B4F0 VA: 0x18020C0F0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x20C120 Offset: 0x20B520 VA: 0x18020C120 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x20C140 Offset: 0x20B540 VA: 0x18020C140 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x20C1B0 Offset: 0x20B5B0 VA: 0x18020C1B0 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x20C130 Offset: 0x20B530 VA: 0x18020C130 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x20C180 Offset: 0x20B580 VA: 0x18020C180 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x20C260 Offset: 0x20B660 VA: 0x18020C260 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x20C190 Offset: 0x20B590 VA: 0x18020C190 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x20C270 Offset: 0x20B670 VA: 0x18020C270 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x20C1A0 Offset: 0x20B5A0 VA: 0x18020C1A0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x20C280 Offset: 0x20B680 VA: 0x18020C280 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x20C1C0 Offset: 0x20B5C0 VA: 0x18020C1C0 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x20C170 Offset: 0x20B570 VA: 0x18020C170 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x20C150 Offset: 0x20B550 VA: 0x18020C150 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x20C1D0 Offset: 0x20B5D0 VA: 0x18020C1D0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x17A1550 Offset: 0x17A0950 VA: 0x1817A1550
	internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result) { }

	// RVA: 0x17A1A10 Offset: 0x17A0E10 VA: 0x1817A1A10
	private static void .cctor() { }

}

public enum DateTimeKind // TypeDefIndex: 198
{	// Fields
	public int value__; // 0x0
	public const DateTimeKind Unspecified = 0;
	public const DateTimeKind Utc = 1;
	public const DateTimeKind Local = 2;

}

public struct DateTimeOffset : IComparable, IFormattable, ISerializable, IDeserializationCallback, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset> // TypeDefIndex: 199
{	// Fields
	public static readonly DateTimeOffset MinValue; // 0x0
	public static readonly DateTimeOffset MaxValue; // 0x10
	private DateTime m_dateTime; // 0x0
	private short m_offsetMinutes; // 0x8

	// Properties
	public static DateTimeOffset Now { get; }
	public static DateTimeOffset UtcNow { get; }
	public DateTime DateTime { get; }
	public DateTime UtcDateTime { get; }
	public DateTime LocalDateTime { get; }
	private DateTime ClockDateTime { get; }
	public int Day { get; }
	public int Hour { get; }
	public int Minute { get; }
	public int Month { get; }
	public TimeSpan Offset { get; }
	public int Second { get; }
	public long Ticks { get; }
	public int Year { get; }

	// Methods

	// RVA: 0x20B7C0 Offset: 0x20ABC0 VA: 0x18020B7C0
	public void .ctor(long ticks, TimeSpan offset) { }

	// RVA: 0x20B940 Offset: 0x20AD40 VA: 0x18020B940
	public void .ctor(DateTime dateTime) { }

	// RVA: 0x20B930 Offset: 0x20AD30 VA: 0x18020B930
	public void .ctor(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x1792540 Offset: 0x1791940 VA: 0x181792540
	public static DateTimeOffset get_Now() { }

	// RVA: 0x17926E0 Offset: 0x1791AE0 VA: 0x1817926E0
	public static DateTimeOffset get_UtcNow() { }

	// RVA: 0x20B960 Offset: 0x20AD60 VA: 0x18020B960
	public DateTime get_DateTime() { }

	// RVA: 0x20BB80 Offset: 0x20AF80 VA: 0x18020BB80
	public DateTime get_UtcDateTime() { }

	// RVA: 0x20BA00 Offset: 0x20AE00 VA: 0x18020BA00
	public DateTime get_LocalDateTime() { }

	// RVA: 0x20B950 Offset: 0x20AD50 VA: 0x18020B950
	private DateTime get_ClockDateTime() { }

	// RVA: 0x20B970 Offset: 0x20AD70 VA: 0x18020B970
	public int get_Day() { }

	// RVA: 0x20B9A0 Offset: 0x20ADA0 VA: 0x18020B9A0
	public int get_Hour() { }

	// RVA: 0x20BA30 Offset: 0x20AE30 VA: 0x18020BA30
	public int get_Minute() { }

	// RVA: 0x20BA90 Offset: 0x20AE90 VA: 0x18020BA90
	public int get_Month() { }

	// RVA: 0x20BAC0 Offset: 0x20AEC0 VA: 0x18020BAC0
	public TimeSpan get_Offset() { }

	// RVA: 0x20BAF0 Offset: 0x20AEF0 VA: 0x18020BAF0
	public int get_Second() { }

	// RVA: 0x20BB50 Offset: 0x20AF50 VA: 0x18020BB50
	public long get_Ticks() { }

	// RVA: 0x20BB90 Offset: 0x20AF90 VA: 0x18020BB90
	public int get_Year() { }

	// RVA: 0x1790850 Offset: 0x178FC50 VA: 0x181790850
	public static int Compare(DateTimeOffset first, DateTimeOffset second) { }

	// RVA: 0x20B1C0 Offset: 0x20A5C0 VA: 0x18020B1C0 Slot: 4
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0x20AEB0 Offset: 0x20A2B0 VA: 0x18020AEB0 Slot: 8
	public int CompareTo(DateTimeOffset other) { }

	// RVA: 0x20B070 Offset: 0x20A470 VA: 0x18020B070 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x20AFD0 Offset: 0x20A3D0 VA: 0x18020AFD0 Slot: 9
	public bool Equals(DateTimeOffset other) { }

	// RVA: 0x20B380 Offset: 0x20A780 VA: 0x18020B380 Slot: 7
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x20B390 Offset: 0x20A790 VA: 0x18020B390 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x20B7D0 Offset: 0x20ABD0 VA: 0x18020B7D0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x20B190 Offset: 0x20A590 VA: 0x18020B190 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1790BA0 Offset: 0x178FFA0 VA: 0x181790BA0
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider) { }

	// RVA: 0x1790DE0 Offset: 0x17901E0 VA: 0x181790DE0
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles) { }

	// RVA: 0x1790A80 Offset: 0x178FE80 VA: 0x181790A80
	public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles) { }

	// RVA: 0x20B770 Offset: 0x20AB70 VA: 0x18020B770
	public long ToUnixTimeSeconds() { }

	// RVA: 0x20B720 Offset: 0x20AB20 VA: 0x18020B720
	public long ToUnixTimeMilliseconds() { }

	// RVA: 0x20B510 Offset: 0x20A910 VA: 0x18020B510 Slot: 3
	public override string ToString() { }

	// RVA: 0x20B430 Offset: 0x20A830 VA: 0x18020B430
	public string ToString(IFormatProvider formatProvider) { }

	// RVA: 0x20B5F0 Offset: 0x20A9F0 VA: 0x18020B5F0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x20B6E0 Offset: 0x20AAE0 VA: 0x18020B6E0
	public DateTimeOffset ToUniversalTime() { }

	// RVA: 0x1791840 Offset: 0x1790C40 VA: 0x181791840
	public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	// RVA: 0x1791490 Offset: 0x1790890 VA: 0x181791490
	public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	// RVA: 0x17915E0 Offset: 0x17909E0 VA: 0x1817915E0
	public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	// RVA: 0x1791B50 Offset: 0x1790F50 VA: 0x181791B50
	private static short ValidateOffset(TimeSpan offset) { }

	// RVA: 0x1791A90 Offset: 0x1790E90 VA: 0x181791A90
	private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x1791C60 Offset: 0x1791060 VA: 0x181791C60
	private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName) { }

	// RVA: 0x1792860 Offset: 0x1791C60 VA: 0x181792860
	public static DateTimeOffset op_Implicit(DateTime dateTime) { }

	// RVA: 0x1792910 Offset: 0x1791D10 VA: 0x181792910
	public static TimeSpan op_Subtraction(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x17927D0 Offset: 0x1791BD0 VA: 0x1817927D0
	public static bool op_Equality(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x1792880 Offset: 0x1791C80 VA: 0x181792880
	public static bool op_Inequality(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x1791D90 Offset: 0x1791190 VA: 0x181791D90
	private static void .cctor() { }

}

internal static class DateTimeFormat // TypeDefIndex: 225
{	// Fields
	internal static readonly TimeSpan NullOffset; // 0x0
	internal static char[] allStandardFormats; // 0x8
	internal static string[] fixedNumberFormats; // 0x10

	// Methods

	// RVA: 0x178F760 Offset: 0x178EB60 VA: 0x18178F760
	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len) { }

	// RVA: 0x178F7E0 Offset: 0x178EBE0 VA: 0x18178F7E0
	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len, bool overrideLengthLimit) { }

	// RVA: 0x178FFF0 Offset: 0x178F3F0 VA: 0x18178FFF0
	private static void HebrewFormatDigits(StringBuilder outputBuffer, int digits) { }

	// RVA: 0x1790360 Offset: 0x178F760 VA: 0x181790360
	internal static int ParseRepeatPattern(string format, int pos, char patternChar) { }

	// RVA: 0x178F720 Offset: 0x178EB20 VA: 0x18178F720
	private static string FormatDayOfWeek(int dayOfWeek, int repeat, DateTimeFormatInfo dtfi) { }

	// RVA: 0x178F9A0 Offset: 0x178EDA0 VA: 0x18178F9A0
	private static string FormatMonth(int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	// RVA: 0x178F8E0 Offset: 0x178ECE0 VA: 0x18178F8E0
	private static string FormatHebrewMonthName(DateTime time, int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	// RVA: 0x17901C0 Offset: 0x178F5C0 VA: 0x1817901C0
	internal static int ParseQuoteString(string format, int pos, StringBuilder result) { }

	// RVA: 0x1790180 Offset: 0x178F580 VA: 0x181790180
	internal static int ParseNextChar(string format, int pos) { }

	// RVA: 0x1790070 Offset: 0x178F470 VA: 0x181790070
	private static bool IsUseGenitiveForm(string format, int index, int tokenLen, char patternToMatch) { }

	// RVA: 0x178E480 Offset: 0x178D880 VA: 0x18178E480
	private static string FormatCustomized(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset) { }

	// RVA: 0x178E0F0 Offset: 0x178D4F0 VA: 0x18178E0F0
	private static void FormatCustomizedTimeZone(DateTime dateTime, TimeSpan offset, string format, int tokenLen, bool timeOnly, StringBuilder result) { }

	// RVA: 0x178DEC0 Offset: 0x178D2C0 VA: 0x18178DEC0
	private static void FormatCustomizedRoundripTimeZone(DateTime dateTime, TimeSpan offset, StringBuilder result) { }

	// RVA: 0x178FCD0 Offset: 0x178F0D0 VA: 0x18178FCD0
	internal static string GetRealFormat(string format, DateTimeFormatInfo dtfi) { }

	// RVA: 0x178D840 Offset: 0x178CC40 VA: 0x18178D840
	private static string ExpandPredefinedFormat(string format, ref DateTime dateTime, ref DateTimeFormatInfo dtfi, ref TimeSpan offset) { }

	// RVA: 0x178F9E0 Offset: 0x178EDE0 VA: 0x18178F9E0
	internal static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi) { }

	// RVA: 0x178FA70 Offset: 0x178EE70 VA: 0x18178FA70
	internal static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal static void InvalidFormatForLocal(string format, DateTime dateTime) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal static void InvalidFormatForUtc(string format, DateTime dateTime) { }

	// RVA: 0x17903E0 Offset: 0x178F7E0 VA: 0x1817903E0
	private static void .cctor() { }

}

internal static class DateTimeParse // TypeDefIndex: 226
{	// Fields
	internal static DateTimeParse.MatchNumberDelegate m_hebrewNumberParser; // 0x0
	private static DateTimeParse.DS[][] dateParsingStates; // 0x8

	// Methods

	// RVA: 0x1799FF0 Offset: 0x17993F0 VA: 0x181799FF0
	internal static DateTime ParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style) { }

	// RVA: 0x1799D90 Offset: 0x1799190 VA: 0x181799D90
	internal static DateTime ParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, out TimeSpan offset) { }

	// RVA: 0x179CA40 Offset: 0x179BE40 VA: 0x18179CA40
	internal static bool TryParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result) { }

	// RVA: 0x179C690 Offset: 0x179BA90 VA: 0x18179C690
	internal static bool TryParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset) { }

	// RVA: 0x179C900 Offset: 0x179BD00 VA: 0x18179C900
	internal static bool TryParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

	// RVA: 0x1799C60 Offset: 0x1799060 VA: 0x181799C60
	internal static DateTime ParseExactMultiple(string s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style) { }

	// RVA: 0x179C500 Offset: 0x179B900 VA: 0x18179C500
	internal static bool TryParseExactMultiple(string s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset) { }

	// RVA: 0x179C1E0 Offset: 0x179B5E0 VA: 0x18179C1E0
	internal static bool TryParseExactMultiple(string s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

	// RVA: 0x1798240 Offset: 0x1797640 VA: 0x181798240
	private static bool MatchWord(ref __DTString str, string target) { }

	// RVA: 0x1796470 Offset: 0x1795870 VA: 0x181796470
	private static bool GetTimeZoneName(ref __DTString str) { }

	// RVA: 0x17969F0 Offset: 0x1795DF0 VA: 0x1817969F0
	internal static bool IsDigit(char ch) { }

	// RVA: 0x179A340 Offset: 0x1799740 VA: 0x18179A340
	private static bool ParseFraction(ref __DTString str, out double result) { }

	// RVA: 0x179AE20 Offset: 0x179A220 VA: 0x18179AE20
	private static bool ParseTimeZone(ref __DTString str, ref TimeSpan result) { }

	// RVA: 0x1796890 Offset: 0x1795C90 VA: 0x181796890
	private static bool HandleTimeZone(ref __DTString str, ref DateTimeResult result) { }

	// RVA: 0x1796A10 Offset: 0x1795E10 VA: 0x181796A10
	private static bool Lex(DateTimeParse.DS dps, ref __DTString str, ref DateTimeToken dtok, ref DateTimeRawInfo raw, ref DateTimeResult result, ref DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	// RVA: 0x179D8D0 Offset: 0x179CCD0 VA: 0x18179D8D0
	private static bool VerifyValidPunctuation(ref __DTString str) { }

	// RVA: 0x1796510 Offset: 0x1795910 VA: 0x181796510
	private static bool GetYearMonthDayOrder(string datePattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x1796740 Offset: 0x1795B40 VA: 0x181796740
	private static bool GetYearMonthOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x1796120 Offset: 0x1795520 VA: 0x181796120
	private static bool GetMonthDayOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x179C130 Offset: 0x179B530 VA: 0x18179C130
	private static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear) { }

	// RVA: 0x179C0B0 Offset: 0x179B4B0 VA: 0x18179C0B0
	private static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day) { }

	// RVA: 0x179BF30 Offset: 0x179B330 VA: 0x18179BF30
	private static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year) { }

	// RVA: 0x179BE70 Offset: 0x179B270 VA: 0x18179BE70
	private static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year) { }

	// RVA: 0x179BFF0 Offset: 0x179B3F0 VA: 0x18179BFF0
	private static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month) { }

	// RVA: 0x1795F00 Offset: 0x1795300 VA: 0x181795F00
	private static void GetDefaultYear(ref DateTimeResult result, ref DateTimeStyles styles) { }

	// RVA: 0x1795800 Offset: 0x1794C00 VA: 0x181795800
	private static bool GetDayOfNN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1795160 Offset: 0x1794560 VA: 0x181795160
	private static bool GetDayOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1794C40 Offset: 0x1794040 VA: 0x181794C40
	private static bool GetDayOfMN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1795FA0 Offset: 0x17953A0 VA: 0x181795FA0
	private static bool GetHebrewDayOfNM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1794ED0 Offset: 0x17942D0 VA: 0x181794ED0
	private static bool GetDayOfNM(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1794830 Offset: 0x1793C30 VA: 0x181794830
	private static bool GetDayOfMNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1795C20 Offset: 0x1795020 VA: 0x181795C20
	private static bool GetDayOfYNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1795620 Offset: 0x1794A20 VA: 0x181795620
	private static bool GetDayOfNNY(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x17959E0 Offset: 0x1794DE0 VA: 0x1817959E0
	private static bool GetDayOfYMN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1795DC0 Offset: 0x17951C0 VA: 0x181795DC0
	private static bool GetDayOfYN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1795AE0 Offset: 0x1794EE0 VA: 0x181795AE0
	private static bool GetDayOfYM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x17929E0 Offset: 0x1791DE0 VA: 0x1817929E0
	private static void AdjustTimeMark(DateTimeFormatInfo dtfi, ref DateTimeRawInfo raw) { }

	// RVA: 0x17929A0 Offset: 0x1791DA0 VA: 0x1817929A0
	private static bool AdjustHour(ref int hour, DateTimeParse.TM timeMark) { }

	// RVA: 0x17963E0 Offset: 0x17957E0 VA: 0x1817963E0
	private static bool GetTimeOfN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x1796350 Offset: 0x1795750 VA: 0x181796350
	private static bool GetTimeOfNN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x17962B0 Offset: 0x17956B0 VA: 0x1817962B0
	private static bool GetTimeOfNNN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x17940E0 Offset: 0x17934E0 VA: 0x1817940E0
	private static bool GetDateOfDSN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x1794170 Offset: 0x1793570 VA: 0x181794170
	private static bool GetDateOfNDS(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x1794230 Offset: 0x1793630 VA: 0x181794230
	private static bool GetDateOfNNDS(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179B380 Offset: 0x179A780 VA: 0x18179B380
	private static bool ProcessDateTimeSuffix(ref DateTimeResult result, ref DateTimeRawInfo raw, ref DateTimeToken dtok) { }

	// RVA: 0x179B460 Offset: 0x179A860 VA: 0x18179B460
	internal static bool ProcessHebrewTerminalState(DateTimeParse.DS dps, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179B8E0 Offset: 0x179ACE0 VA: 0x18179B8E0
	internal static bool ProcessTerminaltState(DateTimeParse.DS dps, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x179B130 Offset: 0x179A530 VA: 0x18179B130
	internal static DateTime Parse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	// RVA: 0x179B250 Offset: 0x179A650 VA: 0x18179B250
	internal static DateTime Parse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out TimeSpan offset) { }

	// RVA: 0x179D620 Offset: 0x179CA20 VA: 0x18179D620
	internal static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result) { }

	// RVA: 0x179D750 Offset: 0x179CB50 VA: 0x18179D750
	internal static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result, out TimeSpan offset) { }

	// RVA: 0x179CD30 Offset: 0x179C130 VA: 0x18179CD30
	internal static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, ref DateTimeResult result) { }

	// RVA: 0x1793210 Offset: 0x1792610 VA: 0x181793210
	private static bool DetermineTimeZoneAdjustments(ref DateTimeResult result, DateTimeStyles styles, bool bTimeOnly) { }

	// RVA: 0x1793010 Offset: 0x1792410 VA: 0x181793010
	private static bool DateTimeOffsetTimeZonePostProcessing(ref DateTimeResult result, DateTimeStyles styles) { }

	// RVA: 0x1792C70 Offset: 0x1792070 VA: 0x181792C70
	private static bool AdjustTimeZoneToUniversal(ref DateTimeResult result) { }

	// RVA: 0x1792A50 Offset: 0x1791E50 VA: 0x181792A50
	private static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly) { }

	// RVA: 0x179A420 Offset: 0x1799820 VA: 0x18179A420
	private static bool ParseISO8601(ref DateTimeRawInfo raw, ref __DTString str, DateTimeStyles styles, ref DateTimeResult result) { }

	// RVA: 0x1797EC0 Offset: 0x17972C0 VA: 0x181797EC0
	internal static bool MatchHebrewDigits(ref __DTString str, int digitLen, out int number) { }

	// RVA: 0x1799A80 Offset: 0x1798E80 VA: 0x181799A80
	internal static bool ParseDigits(ref __DTString str, int digitLen, out int result) { }

	// RVA: 0x1799BB0 Offset: 0x1798FB0 VA: 0x181799BB0
	internal static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result) { }

	// RVA: 0x179A200 Offset: 0x1799600 VA: 0x18179A200
	private static bool ParseFractionExact(ref __DTString str, int maxDigitLen, ref double result) { }

	// RVA: 0x179AA40 Offset: 0x1799E40 VA: 0x18179AA40
	private static bool ParseSign(ref __DTString str, ref bool result) { }

	// RVA: 0x179AAA0 Offset: 0x1799EA0 VA: 0x18179AAA0
	private static bool ParseTimeZoneOffset(ref __DTString str, int len, ref TimeSpan result) { }

	// RVA: 0x1797A50 Offset: 0x1796E50 VA: 0x181797A50
	private static bool MatchAbbreviatedMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x1797FA0 Offset: 0x17973A0 VA: 0x181797FA0
	private static bool MatchMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x1797970 Offset: 0x1796D70 VA: 0x181797970
	private static bool MatchAbbreviatedDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x1797C60 Offset: 0x1797060 VA: 0x181797C60
	private static bool MatchDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x1797D40 Offset: 0x1797140 VA: 0x181797D40
	private static bool MatchEraName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x1798130 Offset: 0x1797530 VA: 0x181798130
	private static bool MatchTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result) { }

	// RVA: 0x1797BB0 Offset: 0x1796FB0 VA: 0x181797BB0
	private static bool MatchAbbreviatedTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result) { }

	// RVA: 0x1792F60 Offset: 0x1792360 VA: 0x181792F60
	private static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref DateTimeResult result) { }

	// RVA: 0x17944D0 Offset: 0x17938D0 VA: 0x1817944D0
	private static DateTime GetDateTimeNow(ref DateTimeResult result, ref DateTimeStyles styles) { }

	// RVA: 0x1792D30 Offset: 0x1792130 VA: 0x181792D30
	private static bool CheckDefaultDateTime(ref DateTimeResult result, ref Calendar cal, DateTimeStyles styles) { }

	// RVA: 0x1793A40 Offset: 0x1792E40 VA: 0x181793A40
	private static string ExpandPredefinedFormat(string format, ref DateTimeFormatInfo dtfi, ref ParsingInfo parseInfo, ref DateTimeResult result) { }

	// RVA: 0x1798380 Offset: 0x1797780 VA: 0x181798380
	private static bool ParseByFormat(ref __DTString str, ref __DTString format, ref ParsingInfo parseInfo, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	// RVA: 0x179CC60 Offset: 0x179C060 VA: 0x18179CC60
	internal static bool TryParseQuoteString(string format, int pos, StringBuilder result, out int returnValue) { }

	// RVA: 0x1793410 Offset: 0x1792810 VA: 0x181793410
	private static bool DoStrictParse(string s, string formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	// RVA: 0x1794640 Offset: 0x1793A40 VA: 0x181794640
	private static Exception GetDateTimeParseException(ref DateTimeResult result) { }

	// RVA: 0x179DA40 Offset: 0x179CE40 VA: 0x18179DA40
	private static void .cctor() { }

}

internal sealed class DateTimeParse.MatchNumberDelegate : MulticastDelegate // TypeDefIndex: 227
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17A5870 Offset: 0x17A4C70 VA: 0x1817A5870 Slot: 12
	public virtual bool Invoke(ref __DTString str, int digitLen, out int result) { }

	// RVA: 0x17A57C0 Offset: 0x17A4BC0 VA: 0x1817A57C0 Slot: 13
	public virtual IAsyncResult BeginInvoke(ref __DTString str, int digitLen, out int result, AsyncCallback callback, object object) { }

	// RVA: 0x1759DA0 Offset: 0x17591A0 VA: 0x181759DA0 Slot: 14
	public virtual bool EndInvoke(ref __DTString str, out int result, IAsyncResult __result) { }

}

internal enum DateTimeParse.DTT // TypeDefIndex: 228
{	// Fields
	public int value__; // 0x0
	public const DateTimeParse.DTT End = 0;
	public const DateTimeParse.DTT NumEnd = 1;
	public const DateTimeParse.DTT NumAmpm = 2;
	public const DateTimeParse.DTT NumSpace = 3;
	public const DateTimeParse.DTT NumDatesep = 4;
	public const DateTimeParse.DTT NumTimesep = 5;
	public const DateTimeParse.DTT MonthEnd = 6;
	public const DateTimeParse.DTT MonthSpace = 7;
	public const DateTimeParse.DTT MonthDatesep = 8;
	public const DateTimeParse.DTT NumDatesuff = 9;
	public const DateTimeParse.DTT NumTimesuff = 10;
	public const DateTimeParse.DTT DayOfWeek = 11;
	public const DateTimeParse.DTT YearSpace = 12;
	public const DateTimeParse.DTT YearDateSep = 13;
	public const DateTimeParse.DTT YearEnd = 14;
	public const DateTimeParse.DTT TimeZone = 15;
	public const DateTimeParse.DTT Era = 16;
	public const DateTimeParse.DTT NumUTCTimeMark = 17;
	public const DateTimeParse.DTT Unk = 18;
	public const DateTimeParse.DTT NumLocalTimeMark = 19;
	public const DateTimeParse.DTT Max = 20;

}

internal enum DateTimeParse.TM // TypeDefIndex: 229
{	// Fields
	public int value__; // 0x0
	public const DateTimeParse.TM NotSet = -1;
	public const DateTimeParse.TM AM = 0;
	public const DateTimeParse.TM PM = 1;

}

internal enum DateTimeParse.DS // TypeDefIndex: 230
{	// Fields
	public int value__; // 0x0
	public const DateTimeParse.DS BEGIN = 0;
	public const DateTimeParse.DS N = 1;
	public const DateTimeParse.DS NN = 2;
	public const DateTimeParse.DS D_Nd = 3;
	public const DateTimeParse.DS D_NN = 4;
	public const DateTimeParse.DS D_NNd = 5;
	public const DateTimeParse.DS D_M = 6;
	public const DateTimeParse.DS D_MN = 7;
	public const DateTimeParse.DS D_NM = 8;
	public const DateTimeParse.DS D_MNd = 9;
	public const DateTimeParse.DS D_NDS = 10;
	public const DateTimeParse.DS D_Y = 11;
	public const DateTimeParse.DS D_YN = 12;
	public const DateTimeParse.DS D_YNd = 13;
	public const DateTimeParse.DS D_YM = 14;
	public const DateTimeParse.DS D_YMd = 15;
	public const DateTimeParse.DS D_S = 16;
	public const DateTimeParse.DS T_S = 17;
	public const DateTimeParse.DS T_Nt = 18;
	public const DateTimeParse.DS T_NNt = 19;
	public const DateTimeParse.DS ERROR = 20;
	public const DateTimeParse.DS DX_NN = 21;
	public const DateTimeParse.DS DX_NNN = 22;
	public const DateTimeParse.DS DX_MN = 23;
	public const DateTimeParse.DS DX_NM = 24;
	public const DateTimeParse.DS DX_MNN = 25;
	public const DateTimeParse.DS DX_DS = 26;
	public const DateTimeParse.DS DX_DSN = 27;
	public const DateTimeParse.DS DX_NDS = 28;
	public const DateTimeParse.DS DX_NNDS = 29;
	public const DateTimeParse.DS DX_YNN = 30;
	public const DateTimeParse.DS DX_YMN = 31;
	public const DateTimeParse.DS DX_YN = 32;
	public const DateTimeParse.DS DX_YM = 33;
	public const DateTimeParse.DS TX_N = 34;
	public const DateTimeParse.DS TX_NN = 35;
	public const DateTimeParse.DS TX_NNN = 36;
	public const DateTimeParse.DS TX_TS = 37;
	public const DateTimeParse.DS DX_NNY = 38;

}

internal struct DateTimeToken // TypeDefIndex: 234
{	// Fields
	internal DateTimeParse.DTT dtt; // 0x0
	internal TokenType suffix; // 0x4
	internal int num; // 0x8

}

internal struct DateTimeRawInfo // TypeDefIndex: 235
{	// Fields
	private int* num; // 0x0
	internal int numCount; // 0x8
	internal int month; // 0xC
	internal int year; // 0x10
	internal int dayOfWeek; // 0x14
	internal int era; // 0x18
	internal DateTimeParse.TM timeMark; // 0x1C
	internal double fraction; // 0x20
	internal bool hasSameDateAndTimeSeparators; // 0x28
	internal bool timeZone; // 0x29

	// Methods

	// RVA: 0x20BBF0 Offset: 0x20AFF0 VA: 0x18020BBF0
	internal void Init(int* numberBuffer) { }

	// RVA: 0x20BBC0 Offset: 0x20AFC0 VA: 0x18020BBC0
	internal void AddNumber(int value) { }

	// RVA: 0x20BBE0 Offset: 0x20AFE0 VA: 0x18020BBE0
	internal int GetNumber(int index) { }

}

internal struct DateTimeResult // TypeDefIndex: 238
{	// Fields
	internal int Year; // 0x0
	internal int Month; // 0x4
	internal int Day; // 0x8
	internal int Hour; // 0xC
	internal int Minute; // 0x10
	internal int Second; // 0x14
	internal double fraction; // 0x18
	internal int era; // 0x20
	internal ParseFlags flags; // 0x24
	internal TimeSpan timeZoneOffset; // 0x28
	internal Calendar calendar; // 0x30
	internal DateTime parsedDate; // 0x38
	internal ParseFailureKind failure; // 0x40
	internal string failureMessageID; // 0x48
	internal object failureMessageFormatArgument; // 0x50
	internal string failureArgumentName; // 0x58

	// Methods

	// RVA: 0x20BCC0 Offset: 0x20B0C0 VA: 0x18020BCC0
	internal void Init() { }

	// RVA: 0x20BCF0 Offset: 0x20B0F0 VA: 0x18020BCF0
	internal void SetDate(int year, int month, int day) { }

	// RVA: 0x20BD00 Offset: 0x20B100 VA: 0x18020BD00
	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x20BD40 Offset: 0x20B140 VA: 0x18020BD40
	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName) { }

}

internal enum DateTimeFormatFlags // TypeDefIndex: 694
{	// Fields
	public int value__; // 0x0
	public const DateTimeFormatFlags None = 0;
	public const DateTimeFormatFlags UseGenitiveMonth = 1;
	public const DateTimeFormatFlags UseLeapYearMonth = 2;
	public const DateTimeFormatFlags UseSpacesInMonthNames = 4;
	public const DateTimeFormatFlags UseHebrewRule = 8;
	public const DateTimeFormatFlags UseSpacesInDayNames = 16;
	public const DateTimeFormatFlags UseDigitPrefixInTokens = 32;
	public const DateTimeFormatFlags NotInitialized = -1;

}

public sealed class DateTimeFormatInfo : ICloneable, IFormatProvider // TypeDefIndex: 695
{	// Fields
	private static DateTimeFormatInfo invariantInfo; // 0x0
	private CultureData m_cultureData; // 0x10
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	internal string m_name; // 0x18
	private string m_langName; // 0x20
	private CompareInfo m_compareInfo; // 0x28
	private CultureInfo m_cultureInfo; // 0x30
	internal string amDesignator; // 0x38
	internal string pmDesignator; // 0x40
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	internal string dateSeparator; // 0x48
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	internal string generalShortTimePattern; // 0x50
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	internal string generalLongTimePattern; // 0x58
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	internal string timeSeparator; // 0x60
	internal string monthDayPattern; // 0x68
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	internal string dateTimeOffsetPattern; // 0x70
	internal const string rfc1123Pattern = "ddd, dd MMM yyyy HH\':\'mm\':\'ss \'GMT\'";
	internal const string sortableDateTimePattern = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss";
	internal const string universalSortableDateTimePattern = "yyyy\'-\'MM\'-\'dd HH\':\'mm\':\'ss\'Z\'";
	internal Calendar calendar; // 0x78
	internal int firstDayOfWeek; // 0x80
	internal int calendarWeekRule; // 0x84
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	internal string fullDateTimePattern; // 0x88
	internal string[] abbreviatedDayNames; // 0x90
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	internal string[] m_superShortDayNames; // 0x98
	internal string[] dayNames; // 0xA0
	internal string[] abbreviatedMonthNames; // 0xA8
	internal string[] monthNames; // 0xB0
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	internal string[] genitiveMonthNames; // 0xB8
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	internal string[] m_genitiveAbbreviatedMonthNames; // 0xC0
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	internal string[] leapYearMonthNames; // 0xC8
	internal string longDatePattern; // 0xD0
	internal string shortDatePattern; // 0xD8
	internal string yearMonthPattern; // 0xE0
	internal string longTimePattern; // 0xE8
	internal string shortTimePattern; // 0xF0
	[OptionalFieldAttribute] // RVA: 0xA9A10 Offset: 0xA8E10 VA: 0x1800A9A10
	private string[] allYearMonthPatterns; // 0xF8
	internal string[] allShortDatePatterns; // 0x100
	internal string[] allLongDatePatterns; // 0x108
	internal string[] allShortTimePatterns; // 0x110
	internal string[] allLongTimePatterns; // 0x118
	internal string[] m_eraNames; // 0x120
	internal string[] m_abbrevEraNames; // 0x128
	internal string[] m_abbrevEnglishEraNames; // 0x130
	internal int[] optionalCalendars; // 0x138
	private const int DEFAULT_ALL_DATETIMES_SIZE = 132;
	internal bool m_isReadOnly; // 0x140
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	internal DateTimeFormatFlags formatFlags; // 0x144
	internal static bool preferExistingTokens; // 0x8
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	private int CultureID; // 0x148
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	private bool m_useUserOverride; // 0x14C
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	private bool bUseCalendarInfo; // 0x14D
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	private int nDataItem; // 0x150
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	internal bool m_isDefaultCalendar; // 0x154
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	private static Hashtable s_calendarNativeNames; // 0x10
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	internal string[] m_dateWords; // 0x158
	private string m_fullTimeSpanPositivePattern; // 0x160
	private string m_fullTimeSpanNegativePattern; // 0x168
	internal const DateTimeStyles InvalidDateTimeStyles = -256;
	private TokenHashValue[] m_dtfiTokenHash; // 0x170
	private const int TOKEN_HASH_SIZE = 199;
	private const int SECOND_PRIME = 197;
	private const string dateSeparatorOrTimeZoneOffset = "-";
	private const string invariantDateSeparator = "/";
	private const string invariantTimeSeparator = ":";
	internal const string IgnorablePeriod = ".";
	internal const string IgnorableComma = ",";
	internal const string CJKYearSuff = "年";
	internal const string CJKMonthSuff = "月";
	internal const string CJKDaySuff = "日";
	internal const string KoreanYearSuff = "년";
	internal const string KoreanMonthSuff = "월";
	internal const string KoreanDaySuff = "일";
	internal const string KoreanHourSuff = "시";
	internal const string KoreanMinuteSuff = "분";
	internal const string KoreanSecondSuff = "초";
	internal const string CJKHourSuff = "時";
	internal const string ChineseHourSuff = "时";
	internal const string CJKMinuteSuff = "分";
	internal const string CJKSecondSuff = "秒";
	internal const string LocalTimeMark = "T";
	internal const string KoreanLangName = "ko";
	internal const string JapaneseLangName = "ja";
	internal const string EnglishLangName = "en";
	private static DateTimeFormatInfo s_jajpDTFI; // 0x18
	private static DateTimeFormatInfo s_zhtwDTFI; // 0x20

	// Properties
	private string CultureName { get; }
	private CultureInfo Culture { get; }
	private string LanguageName { get; }
	public static DateTimeFormatInfo InvariantInfo { get; }
	public static DateTimeFormatInfo CurrentInfo { get; }
	public string AMDesignator { get; }
	public Calendar Calendar { get; set; }
	private int[] OptionalCalendars { get; }
	internal string[] EraNames { get; }
	internal string[] AbbreviatedEraNames { get; }
	internal string[] AbbreviatedEnglishEraNames { get; }
	public string DateSeparator { get; }
	public string FullDateTimePattern { get; }
	public string LongDatePattern { get; set; }
	public string LongTimePattern { get; set; }
	public string MonthDayPattern { get; }
	public string PMDesignator { get; }
	public string RFC1123Pattern { get; }
	public string ShortDatePattern { get; set; }
	public string ShortTimePattern { get; set; }
	public string SortableDateTimePattern { get; }
	internal string GeneralShortTimePattern { get; }
	internal string GeneralLongTimePattern { get; }
	internal string DateTimeOffsetPattern { get; }
	public string TimeSeparator { get; }
	public string UniversalSortableDateTimePattern { get; }
	public string YearMonthPattern { get; set; }
	public string[] AbbreviatedDayNames { get; }
	public string[] DayNames { get; }
	public string[] AbbreviatedMonthNames { get; }
	public string[] MonthNames { get; }
	internal bool HasSpacesInMonthNames { get; }
	internal bool HasSpacesInDayNames { get; }
	private string[] AllYearMonthPatterns { get; }
	private string[] AllShortDatePatterns { get; }
	private string[] AllShortTimePatterns { get; }
	private string[] AllLongDatePatterns { get; }
	private string[] AllLongTimePatterns { get; }
	private string[] UnclonedYearMonthPatterns { get; }
	private string[] UnclonedShortDatePatterns { get; }
	private string[] UnclonedLongDatePatterns { get; }
	private string[] UnclonedShortTimePatterns { get; }
	private string[] UnclonedLongTimePatterns { get; }
	public bool IsReadOnly { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public string[] MonthGenitiveNames { get; }
	internal string FullTimeSpanPositivePattern { get; }
	internal string FullTimeSpanNegativePattern { get; }
	internal CompareInfo CompareInfo { get; }
	internal DateTimeFormatFlags FormatFlags { get; }
	internal bool HasForceTwoDigitYears { get; }
	internal bool HasYearMonthAdjustment { get; }

	// Methods

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	private static bool InitPreferExistingTokens() { }

	// RVA: 0x16DFF40 Offset: 0x16DF340 VA: 0x1816DFF40
	private string get_CultureName() { }

	// RVA: 0x16DFF80 Offset: 0x16DF380 VA: 0x1816DFF80
	private CultureInfo get_Culture() { }

	// RVA: 0x16E1140 Offset: 0x16E0540 VA: 0x1816E1140
	private string get_LanguageName() { }

	// RVA: 0x16E1880 Offset: 0x16E0C80 VA: 0x1816E1880
	private string[] internalGetAbbreviatedDayOfWeekNames() { }

	// RVA: 0x16E1960 Offset: 0x16E0D60 VA: 0x1816E1960
	private string[] internalGetDayOfWeekNames() { }

	// RVA: 0x16E18F0 Offset: 0x16E0CF0 VA: 0x1816E18F0
	private string[] internalGetAbbreviatedMonthNames() { }

	// RVA: 0x16E1D60 Offset: 0x16E1160 VA: 0x1816E1D60
	private string[] internalGetMonthNames() { }

	// RVA: 0x16DF6B0 Offset: 0x16DEAB0 VA: 0x1816DF6B0
	public void .ctor() { }

	// RVA: 0x16DF7E0 Offset: 0x16DEBE0 VA: 0x1816DF7E0
	internal void .ctor(CultureData cultureData, Calendar cal) { }

	// RVA: 0x16DDB00 Offset: 0x16DCF00 VA: 0x1816DDB00
	private void InitializeOverridableProperties(CultureData cultureData, int calendarID) { }

	[OnDeserializedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x16DE390 Offset: 0x16DD790 VA: 0x1816DE390
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x16DEB70 Offset: 0x16DDF70 VA: 0x1816DEB70
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x16E0F00 Offset: 0x16E0300 VA: 0x1816E0F00
	public static DateTimeFormatInfo get_InvariantInfo() { }

	// RVA: 0x16E0040 Offset: 0x16DF440 VA: 0x1816E0040
	public static DateTimeFormatInfo get_CurrentInfo() { }

	// RVA: 0x16DD220 Offset: 0x16DC620 VA: 0x1816DD220
	public static DateTimeFormatInfo GetInstance(IFormatProvider provider) { }

	// RVA: 0x16DD190 Offset: 0x16DC590 VA: 0x1816DD190 Slot: 5
	public object GetFormat(Type formatType) { }

	// RVA: 0x16DAFB0 Offset: 0x16DA3B0 VA: 0x1816DAFB0 Slot: 4
	public object Clone() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public string get_AMDesignator() { }

	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0
	public Calendar get_Calendar() { }

	// RVA: 0x16E1DD0 Offset: 0x16E11D0 VA: 0x1816E1DD0
	public void set_Calendar(Calendar value) { }

	// RVA: 0x16E1450 Offset: 0x16E0850 VA: 0x1816E1450
	private int[] get_OptionalCalendars() { }

	// RVA: 0x16E0450 Offset: 0x16DF850 VA: 0x1816E0450
	internal string[] get_EraNames() { }

	// RVA: 0x16DD030 Offset: 0x16DC430 VA: 0x1816DD030
	public string GetEraName(int era) { }

	// RVA: 0x16DF930 Offset: 0x16DED30 VA: 0x1816DF930
	internal string[] get_AbbreviatedEraNames() { }

	// RVA: 0x16DC570 Offset: 0x16DB970 VA: 0x1816DC570
	public string GetAbbreviatedEraName(int era) { }

	// RVA: 0x16DF8C0 Offset: 0x16DECC0 VA: 0x1816DF8C0
	internal string[] get_AbbreviatedEnglishEraNames() { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public string get_DateSeparator() { }

	// RVA: 0x16E09D0 Offset: 0x16DFDD0 VA: 0x1816E09D0
	public string get_FullDateTimePattern() { }

	// RVA: 0x16E1180 Offset: 0x16E0580 VA: 0x1816E1180
	public string get_LongDatePattern() { }

	// RVA: 0x16E21D0 Offset: 0x16E15D0 VA: 0x1816E21D0
	public void set_LongDatePattern(string value) { }

	// RVA: 0x16E11E0 Offset: 0x16E05E0 VA: 0x1816E11E0
	public string get_LongTimePattern() { }

	// RVA: 0x16E22E0 Offset: 0x16E16E0 VA: 0x1816E22E0
	public void set_LongTimePattern(string value) { }

	// RVA: 0x16E1280 Offset: 0x16E0680 VA: 0x1816E1280
	public string get_MonthDayPattern() { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public string get_PMDesignator() { }

	// RVA: 0x16E14A0 Offset: 0x16E08A0 VA: 0x1816E14A0
	public string get_RFC1123Pattern() { }

	// RVA: 0x16E14D0 Offset: 0x16E08D0 VA: 0x1816E14D0
	public string get_ShortDatePattern() { }

	// RVA: 0x16E2410 Offset: 0x16E1810 VA: 0x1816E2410
	public void set_ShortDatePattern(string value) { }

	// RVA: 0x16E1530 Offset: 0x16E0930 VA: 0x1816E1530
	public string get_ShortTimePattern() { }

	// RVA: 0x16E2540 Offset: 0x16E1940 VA: 0x1816E2540
	public void set_ShortTimePattern(string value) { }

	// RVA: 0x16E15D0 Offset: 0x16E09D0 VA: 0x1816E15D0
	public string get_SortableDateTimePattern() { }

	// RVA: 0x16E0D80 Offset: 0x16E0180 VA: 0x1816E0D80
	internal string get_GeneralShortTimePattern() { }

	// RVA: 0x16E0CA0 Offset: 0x16E00A0 VA: 0x1816E0CA0
	internal string get_GeneralLongTimePattern() { }

	// RVA: 0x16E0140 Offset: 0x16DF540 VA: 0x1816E0140
	internal string get_DateTimeOffsetPattern() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public string get_TimeSeparator() { }

	// RVA: 0x16E17F0 Offset: 0x16E0BF0 VA: 0x1816E17F0
	public string get_UniversalSortableDateTimePattern() { }

	// RVA: 0x16E1820 Offset: 0x16E0C20 VA: 0x1816E1820
	public string get_YearMonthPattern() { }

	// RVA: 0x16E2650 Offset: 0x16E1A50 VA: 0x1816E2650
	public void set_YearMonthPattern(string value) { }

	// RVA: 0x16DF840 Offset: 0x16DEC40 VA: 0x1816DF840
	public string[] get_AbbreviatedDayNames() { }

	// RVA: 0x16E03D0 Offset: 0x16DF7D0 VA: 0x1816E03D0
	public string[] get_DayNames() { }

	// RVA: 0x16DF9A0 Offset: 0x16DEDA0 VA: 0x1816DF9A0
	public string[] get_AbbreviatedMonthNames() { }

	// RVA: 0x16E13D0 Offset: 0x16E07D0 VA: 0x1816E13D0
	public string[] get_MonthNames() { }

	// RVA: 0x16E0EC0 Offset: 0x16E02C0 VA: 0x1816E0EC0
	internal bool get_HasSpacesInMonthNames() { }

	// RVA: 0x16E0EA0 Offset: 0x16E02A0 VA: 0x1816E0EA0
	internal bool get_HasSpacesInDayNames() { }

	// RVA: 0x16E1B40 Offset: 0x16E0F40 VA: 0x1816E1B40
	internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated) { }

	// RVA: 0x16E19D0 Offset: 0x16E0DD0 VA: 0x1816E19D0
	private string[] internalGetGenitiveMonthNames(bool abbreviated) { }

	// RVA: 0x16E1AC0 Offset: 0x16E0EC0 VA: 0x1816E1AC0
	internal string[] internalGetLeapYearMonthNames() { }

	// RVA: 0x16DC420 Offset: 0x16DB820 VA: 0x1816DC420
	public string GetAbbreviatedDayName(DayOfWeek dayofweek) { }

	// RVA: 0x16DCD70 Offset: 0x16DC170 VA: 0x1816DCD70
	private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString) { }

	// RVA: 0x16DC850 Offset: 0x16DBC50 VA: 0x1816DC850
	public string[] GetAllDateTimePatterns(char format) { }

	// RVA: 0x16DCEE0 Offset: 0x16DC2E0 VA: 0x1816DCEE0
	public string GetDayName(DayOfWeek dayofweek) { }

	// RVA: 0x16DC6F0 Offset: 0x16DBAF0 VA: 0x1816DC6F0
	public string GetAbbreviatedMonthName(int month) { }

	// RVA: 0x16DD860 Offset: 0x16DCC60 VA: 0x1816DD860
	public string GetMonthName(int month) { }

	// RVA: 0x16DD5E0 Offset: 0x16DC9E0 VA: 0x1816DD5E0
	private static string[] GetMergedPatterns(string[] patterns, string defaultPattern) { }

	// RVA: 0x16DFD60 Offset: 0x16DF160 VA: 0x1816DFD60
	private string[] get_AllYearMonthPatterns() { }

	// RVA: 0x16DFBC0 Offset: 0x16DEFC0 VA: 0x1816DFBC0
	private string[] get_AllShortDatePatterns() { }

	// RVA: 0x16DFCA0 Offset: 0x16DF0A0 VA: 0x1816DFCA0
	private string[] get_AllShortTimePatterns() { }

	// RVA: 0x16DFA20 Offset: 0x16DEE20 VA: 0x1816DFA20
	private string[] get_AllLongDatePatterns() { }

	// RVA: 0x16DFB00 Offset: 0x16DEF00 VA: 0x1816DFB00
	private string[] get_AllLongTimePatterns() { }

	// RVA: 0x16E1780 Offset: 0x16E0B80 VA: 0x1816E1780
	private string[] get_UnclonedYearMonthPatterns() { }

	// RVA: 0x16E16C0 Offset: 0x16E0AC0 VA: 0x1816E16C0
	private string[] get_UnclonedShortDatePatterns() { }

	// RVA: 0x16E1600 Offset: 0x16E0A00 VA: 0x1816E1600
	private string[] get_UnclonedLongDatePatterns() { }

	// RVA: 0x16E1730 Offset: 0x16E0B30 VA: 0x1816E1730
	private string[] get_UnclonedShortTimePatterns() { }

	// RVA: 0x16E1670 Offset: 0x16E0A70 VA: 0x1816E1670
	private string[] get_UnclonedLongTimePatterns() { }

	// RVA: 0x16E1130 Offset: 0x16E0530 VA: 0x1816E1130
	public bool get_IsReadOnly() { }

	// RVA: 0x16E12F0 Offset: 0x16E06F0 VA: 0x1816E12F0
	public string[] get_MonthGenitiveNames() { }

	// RVA: 0x16E0BE0 Offset: 0x16DFFE0 VA: 0x1816E0BE0
	internal string get_FullTimeSpanPositivePattern() { }

	// RVA: 0x16E0AC0 Offset: 0x16DFEC0 VA: 0x1816E0AC0
	internal string get_FullTimeSpanNegativePattern() { }

	// RVA: 0x16DFE40 Offset: 0x16DF240 VA: 0x1816DFE40
	internal CompareInfo get_CompareInfo() { }

	// RVA: 0x16DF430 Offset: 0x16DE830 VA: 0x1816DF430
	internal static void ValidateStyles(DateTimeStyles style, string parameterName) { }

	// RVA: 0x16E04C0 Offset: 0x16DF8C0 VA: 0x1816E04C0
	internal DateTimeFormatFlags get_FormatFlags() { }

	// RVA: 0x16E0E60 Offset: 0x16E0260 VA: 0x1816E0E60
	internal bool get_HasForceTwoDigitYears() { }

	// RVA: 0x16E0EE0 Offset: 0x16E02E0 VA: 0x1816E0EE0
	internal bool get_HasYearMonthAdjustment() { }

	// RVA: 0x16DF550 Offset: 0x16DE950 VA: 0x1816DF550
	internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName) { }

	// RVA: 0x16DD4A0 Offset: 0x16DC8A0 VA: 0x1816DD4A0
	internal static DateTimeFormatInfo GetJapaneseCalendarDTFI() { }

	// RVA: 0x16DD9C0 Offset: 0x16DCDC0 VA: 0x1816DD9C0
	internal static DateTimeFormatInfo GetTaiwanCalendarDTFI() { }

	// RVA: 0x16DAF80 Offset: 0x16DA380 VA: 0x1816DAF80
	private void ClearTokenHashTable() { }

	// RVA: 0x16DB0B0 Offset: 0x16DA4B0 VA: 0x1816DB0B0
	internal TokenHashValue[] CreateTokenHashTable() { }

	// RVA: 0x16DAEB0 Offset: 0x16DA2B0 VA: 0x1816DAEB0
	private void AddMonthNames(TokenHashValue[] temp, string monthPostfix) { }

	// RVA: 0x16DF210 Offset: 0x16DE610 VA: 0x1816DF210
	private static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number) { }

	// RVA: 0x16DE370 Offset: 0x16DD770 VA: 0x1816DE370
	private static bool IsHebrewChar(char ch) { }

	// RVA: 0x16DEDC0 Offset: 0x16DE1C0 VA: 0x1816DEDC0
	internal bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str) { }

	// RVA: 0x16DDD30 Offset: 0x16DD130 VA: 0x1816DDD30
	private void InsertAtCurrentHashNode(TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe) { }

	// RVA: 0x16DDF80 Offset: 0x16DD380 VA: 0x1816DDF80
	private void InsertHash(TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue) { }

	// RVA: 0x16DF670 Offset: 0x16DEA70 VA: 0x1816DF670
	private static void .cctor() { }

}

internal class DateTimeFormatInfoScanner // TypeDefIndex: 699
{	// Fields
	internal List<string> m_dateWords; // 0x10
	private static Dictionary<string, string> s_knownWords; // 0x0
	private DateTimeFormatInfoScanner.FoundDatePattern m_ymdFlags; // 0x18

	// Properties
	private static Dictionary<string, string> KnownWords { get; }

	// Methods

	// RVA: 0x16DAB90 Offset: 0x16D9F90 VA: 0x1816DAB90
	private static Dictionary<string, string> get_KnownWords() { }

	// RVA: 0x16DAA50 Offset: 0x16D9E50 VA: 0x1816DAA50
	internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex) { }

	// RVA: 0x16D98B0 Offset: 0x16D8CB0 VA: 0x1816D98B0
	internal void AddDateWordOrPostfix(string formatPostfix, string str) { }

	// RVA: 0x16D9A80 Offset: 0x16D8E80 VA: 0x1816D9A80
	internal int AddDateWords(string pattern, int index, string formatPostfix) { }

	// RVA: 0x16DA9E0 Offset: 0x16D9DE0 VA: 0x1816DA9E0
	internal static int ScanRepeatChar(string pattern, char ch, int index, out int count) { }

	// RVA: 0x16D9CB0 Offset: 0x16D90B0 VA: 0x1816D9CB0
	internal void AddIgnorableSymbols(string text) { }

	// RVA: 0x16DA7A0 Offset: 0x16D9BA0 VA: 0x1816DA7A0
	internal void ScanDateWord(string pattern) { }

	// RVA: 0x16DA1C0 Offset: 0x16D95C0 VA: 0x1816DA1C0
	internal string[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi) { }

	// RVA: 0x16DA540 Offset: 0x16D9940 VA: 0x1816DA540
	internal static FORMATFLAGS GetFormatFlagGenitiveMonth(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x16DA6E0 Offset: 0x16D9AE0 VA: 0x1816DA6E0
	internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x16DA6A0 Offset: 0x16D9AA0 VA: 0x1816DA6A0
	internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(string[] dayNames, string[] abbrevDayNames) { }

	// RVA: 0x16DA690 Offset: 0x16D9A90 VA: 0x1816DA690
	internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID) { }

	// RVA: 0x16DA100 Offset: 0x16D9500 VA: 0x1816DA100
	private static bool EqualStringArrays(string[] array1, string[] array2) { }

	// RVA: 0x16DA020 Offset: 0x16D9420 VA: 0x1816DA020
	private static bool ArrayElementsHaveSpace(string[] array) { }

	// RVA: 0x16D9D80 Offset: 0x16D9180 VA: 0x1816D9D80
	private static bool ArrayElementsBeginWithDigit(string[] array) { }

	// RVA: 0x16DAB20 Offset: 0x16D9F20 VA: 0x1816DAB20
	public void .ctor() { }

}

private enum DateTimeFormatInfoScanner.FoundDatePattern // TypeDefIndex: 700
{	// Fields
	public int value__; // 0x0
	public const DateTimeFormatInfoScanner.FoundDatePattern None = 0;
	public const DateTimeFormatInfoScanner.FoundDatePattern FoundYearPatternFlag = 1;
	public const DateTimeFormatInfoScanner.FoundDatePattern FoundMonthPatternFlag = 2;
	public const DateTimeFormatInfoScanner.FoundDatePattern FoundDayPatternFlag = 4;
	public const DateTimeFormatInfoScanner.FoundDatePattern FoundYMDPatternFlag = 7;

}

public enum DateTimeStyles // TypeDefIndex: 701
{	// Fields
	public int value__; // 0x0
	public const DateTimeStyles None = 0;
	public const DateTimeStyles AllowLeadingWhite = 1;
	public const DateTimeStyles AllowTrailingWhite = 2;
	public const DateTimeStyles AllowInnerWhite = 4;
	public const DateTimeStyles AllowWhiteSpaces = 7;
	public const DateTimeStyles NoCurrentDateDefault = 8;
	public const DateTimeStyles AdjustToUniversal = 16;
	public const DateTimeStyles AssumeLocal = 32;
	public const DateTimeStyles AssumeUniversal = 64;
	public const DateTimeStyles RoundtripKind = 128;

}

public sealed class DateTimeConstantAttribute : CustomConstantAttribute // TypeDefIndex: 1303
{	// Fields
	private DateTime date; // 0x10

	// Properties
	public override object Value { get; }

	// Methods

	// RVA: 0xFE0B50 Offset: 0xFDFF50 VA: 0x180FE0B50 Slot: 7
	public override object get_Value() { }

}

internal sealed class DateTimeTypeInfo : TraceLoggingTypeInfo<DateTime> // TypeDefIndex: 1571
{	// Methods

	// RVA: 0xD644B0 Offset: 0xD638B0 VA: 0x180D644B0 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0xD64460 Offset: 0xD63860 VA: 0x180D64460 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref DateTime value) { }

	// RVA: 0xD64540 Offset: 0xD63940 VA: 0x180D64540
	public void .ctor() { }

}

internal sealed class DateTimeOffsetTypeInfo : TraceLoggingTypeInfo<DateTimeOffset> // TypeDefIndex: 1572
{	// Methods

	// RVA: 0xD64360 Offset: 0xD63760 VA: 0x180D64360 Slot: 4
	public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

	// RVA: 0xD642E0 Offset: 0xD636E0 VA: 0x180D642E0 Slot: 7
	public override void WriteData(TraceLoggingDataCollector collector, ref DateTimeOffset value) { }

	// RVA: 0xD64420 Offset: 0xD63820 VA: 0x180D64420
	public void .ctor() { }

}

internal class DateTimeFacetsChecker : FacetsChecker // TypeDefIndex: 2251
{	// Methods

	// RVA: 0x152EB30 Offset: 0x152DF30 VA: 0x18152EB30 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x152E700 Offset: 0x152DB00 VA: 0x18152E700 Slot: 10
	internal override Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x152ECF0 Offset: 0x152E0F0 VA: 0x18152ECF0 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x152EBB0 Offset: 0x152DFB0 VA: 0x18152EBB0
	private bool MatchEnumeration(DateTime value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

internal sealed class DateTimeOffsetStorage : DataStorage // TypeDefIndex: 4384
{
// Namespace: System.Data.Common
internal sealed class DateTimeOffsetStorage : DataStorage // TypeDefIndex: 4384
	// Fields
	private static readonly DateTimeOffset s_defaultValue; // 0x0
	private DateTimeOffset[] _values; // 0x50

	// Methods

	// RVA: 0x1274040 Offset: 0x1273440 VA: 0x181274040
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1272F40 Offset: 0x1272340 VA: 0x181272F40 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x12735D0 Offset: 0x12729D0 VA: 0x1812735D0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1273410 Offset: 0x1272810 VA: 0x181273410 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1273870 Offset: 0x1272C70 VA: 0x181273870 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1273AD0 Offset: 0x1272ED0 VA: 0x181273AD0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1273BC0 Offset: 0x1272FC0 VA: 0x181273BC0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1273E90 Offset: 0x1273290 VA: 0x181273E90 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1273D10 Offset: 0x1273110 VA: 0x181273D10 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1273900 Offset: 0x1272D00 VA: 0x181273900 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x12737E0 Offset: 0x1272BE0 VA: 0x1812737E0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1273B80 Offset: 0x1272F80 VA: 0x181273B80 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1273980 Offset: 0x1272D80 VA: 0x181273980 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1273DF0 Offset: 0x12731F0 VA: 0x181273DF0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1273FD0 Offset: 0x12733D0 VA: 0x181273FD0
	private static void .cctor() { }

}

internal sealed class DateTimeStorage : DataStorage // TypeDefIndex: 4385
{	// Fields
	private static readonly DateTime s_defaultValue; // 0x0
	private DateTime[] _values; // 0x50

	// Methods

	// RVA: 0x12755C0 Offset: 0x12749C0 VA: 0x1812755C0
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1274150 Offset: 0x1273550 VA: 0x181274150 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1274780 Offset: 0x1273B80 VA: 0x181274780 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x12745F0 Offset: 0x12739F0 VA: 0x1812745F0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1274A20 Offset: 0x1273E20 VA: 0x181274A20 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1274D40 Offset: 0x1274140 VA: 0x181274D40 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1274E20 Offset: 0x1274220 VA: 0x181274E20 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1275270 Offset: 0x1274670 VA: 0x181275270 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1274F40 Offset: 0x1274340 VA: 0x181274F40 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1274B00 Offset: 0x1273F00 VA: 0x181274B00 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1274930 Offset: 0x1273D30 VA: 0x181274930 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1274DE0 Offset: 0x12741E0 VA: 0x181274DE0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1274BB0 Offset: 0x1273FB0 VA: 0x181274BB0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1275020 Offset: 0x1274420 VA: 0x181275020 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1275550 Offset: 0x1274950 VA: 0x181275550
	private static void .cctor() { }

}

public enum DateTimeZoneHandling // TypeDefIndex: 5867
{	// Fields
	public int value__; // 0x0
	public const DateTimeZoneHandling Local = 0;
	public const DateTimeZoneHandling Utc = 1;
	public const DateTimeZoneHandling Unspecified = 2;
	public const DateTimeZoneHandling RoundtripKind = 3;

}

internal struct DateTimeParser // TypeDefIndex: 5916
{	// Fields
	public int Year; // 0x0
	public int Month; // 0x4
	public int Day; // 0x8
	public int Hour; // 0xC
	public int Minute; // 0x10
	public int Second; // 0x14
	public int Fraction; // 0x18
	public int ZoneHour; // 0x1C
	public int ZoneMinute; // 0x20
	public ParserTimeZone Zone; // 0x24
	private char[] _text; // 0x28
	private int _end; // 0x30
	private static readonly int[] Power10; // 0x0
	private static readonly int Lzyyyy; // 0x8
	private static readonly int Lzyyyy_; // 0xC
	private static readonly int Lzyyyy_MM; // 0x10
	private static readonly int Lzyyyy_MM_; // 0x14
	private static readonly int Lzyyyy_MM_dd; // 0x18
	private static readonly int Lzyyyy_MM_ddT; // 0x1C
	private static readonly int LzHH; // 0x20
	private static readonly int LzHH_; // 0x24
	private static readonly int LzHH_mm; // 0x28
	private static readonly int LzHH_mm_; // 0x2C
	private static readonly int LzHH_mm_ss; // 0x30
	private static readonly int Lz_; // 0x34
	private static readonly int Lz_zz; // 0x38

	// Methods

	// RVA: 0x17FDA10 Offset: 0x17FCE10 VA: 0x1817FDA10
	private static void .cctor() { }

	// RVA: 0x2111F0 Offset: 0x2105F0 VA: 0x1802111F0
	public bool Parse(char[] text, int startIndex, int length) { }

	// RVA: 0x211180 Offset: 0x210580 VA: 0x180211180
	private bool ParseDate(int start) { }

	// RVA: 0x211190 Offset: 0x210590 VA: 0x180211190
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x2111D0 Offset: 0x2105D0 VA: 0x1802111D0
	private bool ParseTime(ref int start) { }

	// RVA: 0x2111E0 Offset: 0x2105E0 VA: 0x1802111E0
	private bool ParseZone(int start) { }

	// RVA: 0x211120 Offset: 0x210520 VA: 0x180211120
	private bool Parse4Digit(int start, out int num) { }

	// RVA: 0x211110 Offset: 0x210510 VA: 0x180211110
	private bool Parse2Digit(int start, out int num) { }

	// RVA: 0x211130 Offset: 0x210530 VA: 0x180211130
	private bool ParseChar(int start, char ch) { }

}

internal static class DateTimeUtils // TypeDefIndex: 5949
{	// Fields
	internal static readonly long InitialJavaScriptDateTicks; // 0x0
	private static readonly int[] DaysToMonth365; // 0x8
	private static readonly int[] DaysToMonth366; // 0x10

	// Methods

	// RVA: 0x1801200 Offset: 0x1800600 VA: 0x181801200
	private static void .cctor() { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x17FE4E0 Offset: 0x17FD8E0 VA: 0x1817FE4E0
	public static TimeSpan GetUtcOffset(DateTime d) { }

	// RVA: 0x17FE550 Offset: 0x17FD950 VA: 0x1817FE550
	public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind) { }

	// RVA: 0x17FE120 Offset: 0x17FD520 VA: 0x1817FE120
	internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone) { }

	// RVA: 0xE576C0 Offset: 0xE56AC0 VA: 0x180E576C0
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0xE57730 Offset: 0xE56B30 VA: 0x180E57730
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0x17FE700 Offset: 0x17FDB00 VA: 0x1817FE700
	private static long ToUniversalTicks(DateTime dateTime) { }

	// RVA: 0x17FE5E0 Offset: 0x17FD9E0 VA: 0x1817FE5E0
	private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x17FDC40 Offset: 0x17FD040 VA: 0x1817FDC40
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x17FDCB0 Offset: 0x17FD0B0 VA: 0x1817FDCB0
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime) { }

	// RVA: 0x17FDDF0 Offset: 0x17FD1F0 VA: 0x1817FDDF0
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc) { }

	// RVA: 0x1800330 Offset: 0x17FF730 VA: 0x181800330
	private static long UniversialTicksToJavaScriptTicks(long universialTicks) { }

	// RVA: 0x17FDF10 Offset: 0x17FD310 VA: 0x1817FDF10
	internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks) { }

	// RVA: 0x17FE880 Offset: 0x17FDC80 VA: 0x1817FE880
	internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	// RVA: 0x17FEF00 Offset: 0x17FE300 VA: 0x1817FEF00
	internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt) { }

	// RVA: 0x17FE020 Offset: 0x17FD420 VA: 0x1817FE020
	private static DateTime CreateDateTime(DateTimeParser dateTimeParser) { }

	// RVA: 0x17FFAF0 Offset: 0x17FEEF0 VA: 0x1817FFAF0
	internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x17FF830 Offset: 0x17FEC30 VA: 0x1817FF830
	internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x17FF210 Offset: 0x17FE610 VA: 0x1817FF210
	internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x17FF550 Offset: 0x17FE950 VA: 0x1817FF550
	internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x17FFE50 Offset: 0x17FF250 VA: 0x1817FFE50
	private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind) { }

	// RVA: 0x17FECD0 Offset: 0x17FE0D0 VA: 0x1817FECD0
	private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	// RVA: 0x17FE790 Offset: 0x17FDB90 VA: 0x1817FE790
	private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x17FF0B0 Offset: 0x17FE4B0 VA: 0x1817FF0B0
	private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt) { }

	// RVA: 0x17FEE40 Offset: 0x17FE240 VA: 0x1817FEE40
	private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x18001A0 Offset: 0x17FF5A0 VA: 0x1818001A0
	private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset) { }

	// RVA: 0x1800760 Offset: 0x17FFB60 VA: 0x181800760
	internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0x18008D0 Offset: 0x17FFCD0 VA: 0x1818008D0
	internal static int WriteDateTimeString(char[] chars, int start, DateTime value, Nullable<TimeSpan> offset, DateTimeKind kind, DateFormatHandling format) { }

	// RVA: 0x1800CA0 Offset: 0x18000A0 VA: 0x181800CA0
	internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt) { }

	// RVA: 0x17FDFA0 Offset: 0x17FD3A0 VA: 0x1817FDFA0
	private static void CopyIntToCharArray(char[] chars, int start, int value, int digits) { }

	// RVA: 0x1800530 Offset: 0x17FF930 VA: 0x181800530
	internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format) { }

	// RVA: 0x18003B0 Offset: 0x17FF7B0 VA: 0x1818003B0
	internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0x17FE2F0 Offset: 0x17FD6F0 VA: 0x1817FE2F0
	private static void GetDateValues(DateTime td, out int year, out int month, out int day) { }

}

public abstract class DateTimeConverterBase : JsonConverter // TypeDefIndex: 6101
{	// Methods

	// RVA: 0xF835E0 Offset: 0xF829E0 VA: 0x180F835E0 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

