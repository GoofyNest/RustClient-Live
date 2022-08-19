public struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable // TypeDefIndex: 312
{	// Fields
	public const long TicksPerMillisecond = 10000;
	private const double MillisecondsPerTick = 0,0001;
	public const long TicksPerSecond = 10000000;
	private const double SecondsPerTick = 1E-07;
	public const long TicksPerMinute = 600000000;
	private const double MinutesPerTick = 1,66666666666667E-09;
	public const long TicksPerHour = 36000000000;
	private const double HoursPerTick = 2,77777777777778E-11;
	public const long TicksPerDay = 864000000000;
	private const double DaysPerTick = 1,15740740740741E-12;
	private const int MillisPerSecond = 1000;
	private const int MillisPerMinute = 60000;
	private const int MillisPerHour = 3600000;
	private const int MillisPerDay = 86400000;
	internal const long MaxSeconds = 922337203685;
	internal const long MinSeconds = -922337203685;
	internal const long MaxMilliSeconds = 922337203685477;
	internal const long MinMilliSeconds = -922337203685477;
	internal const long TicksPerTenthSecond = 1000000;
	public static readonly TimeSpan Zero; // 0x0
	public static readonly TimeSpan MaxValue; // 0x8
	public static readonly TimeSpan MinValue; // 0x10
	internal long _ticks; // 0x0
	private static bool _legacyConfigChecked; // 0x18
	private static bool _legacyMode; // 0x19

	// Properties
	public long Ticks { get; }
	public int Days { get; }
	public int Hours { get; }
	public int Milliseconds { get; }
	public int Minutes { get; }
	public int Seconds { get; }
	public double TotalHours { get; }
	public double TotalMilliseconds { get; }
	public double TotalMinutes { get; }
	public double TotalSeconds { get; }
	private static bool LegacyMode { get; }

	// Methods

	// RVA: 0x1D2D40 Offset: 0x1D2140 VA: 0x1801D2D40
	public void .ctor(long ticks) { }

	// RVA: 0x1F5E20 Offset: 0x1F5220 VA: 0x1801F5E20
	public void .ctor(int hours, int minutes, int seconds) { }

	// RVA: 0x1F5E10 Offset: 0x1F5210 VA: 0x1801F5E10
	public void .ctor(int days, int hours, int minutes, int seconds, int milliseconds) { }

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public long get_Ticks() { }

	// RVA: 0x1F5E30 Offset: 0x1F5230 VA: 0x1801F5E30
	public int get_Days() { }

	// RVA: 0x1F5E50 Offset: 0x1F5250 VA: 0x1801F5E50
	public int get_Hours() { }

	// RVA: 0x1F5E90 Offset: 0x1F5290 VA: 0x1801F5E90
	public int get_Milliseconds() { }

	// RVA: 0x1F5EE0 Offset: 0x1F52E0 VA: 0x1801F5EE0
	public int get_Minutes() { }

	// RVA: 0x1F5F30 Offset: 0x1F5330 VA: 0x1801F5F30
	public int get_Seconds() { }

	// RVA: 0x1F5F80 Offset: 0x1F5380 VA: 0x1801F5F80
	public double get_TotalHours() { }

	// RVA: 0x1F5FA0 Offset: 0x1F53A0 VA: 0x1801F5FA0
	public double get_TotalMilliseconds() { }

	// RVA: 0x1F5FE0 Offset: 0x1F53E0 VA: 0x1801F5FE0
	public double get_TotalMinutes() { }

	// RVA: 0x1F6000 Offset: 0x1F5400 VA: 0x1801F6000
	public double get_TotalSeconds() { }

	// RVA: 0x1F58D0 Offset: 0x1F4CD0 VA: 0x1801F58D0
	public TimeSpan Add(TimeSpan ts) { }

	// RVA: 0x1609AC0 Offset: 0x1608EC0 VA: 0x181609AC0
	public static int Compare(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1F5900 Offset: 0x1F4D00 VA: 0x1801F5900 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1F58E0 Offset: 0x1F4CE0 VA: 0x1801F58E0 Slot: 5
	public int CompareTo(TimeSpan value) { }

	// RVA: 0x1609B80 Offset: 0x1608F80 VA: 0x181609B80
	public static TimeSpan FromDays(double value) { }

	// RVA: 0x1F59F0 Offset: 0x1F4DF0 VA: 0x1801F59F0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1F59E0 Offset: 0x1F4DE0 VA: 0x1801F59E0 Slot: 6
	public bool Equals(TimeSpan obj) { }

	// RVA: 0x1F5A80 Offset: 0x1F4E80 VA: 0x1801F5A80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1609BE0 Offset: 0x1608FE0 VA: 0x181609BE0
	public static TimeSpan FromHours(double value) { }

	// RVA: 0x1609DB0 Offset: 0x16091B0 VA: 0x181609DB0
	private static TimeSpan Interval(double value, int scale) { }

	// RVA: 0x1609C40 Offset: 0x1609040 VA: 0x181609C40
	public static TimeSpan FromMilliseconds(double value) { }

	// RVA: 0x1609CA0 Offset: 0x16090A0 VA: 0x181609CA0
	public static TimeSpan FromMinutes(double value) { }

	// RVA: 0x1F5A90 Offset: 0x1F4E90 VA: 0x1801F5A90
	public TimeSpan Negate() { }

	// RVA: 0x1609D00 Offset: 0x1609100 VA: 0x181609D00
	public static TimeSpan FromSeconds(double value) { }

	// RVA: 0x1F5B50 Offset: 0x1F4F50 VA: 0x1801F5B50
	public TimeSpan Subtract(TimeSpan ts) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	public static TimeSpan FromTicks(long value) { }

	// RVA: 0x160A110 Offset: 0x1609510 VA: 0x18160A110
	internal static long TimeToTicks(int hour, int minute, int second) { }

	// RVA: 0x160A010 Offset: 0x1609410 VA: 0x18160A010
	public static TimeSpan Parse(string s) { }

	// RVA: 0x1609FA0 Offset: 0x16093A0 VA: 0x181609FA0
	public static TimeSpan Parse(string input, IFormatProvider formatProvider) { }

	// RVA: 0x1F5B60 Offset: 0x1F4F60 VA: 0x1801F5B60 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F5BC0 Offset: 0x1F4FC0 VA: 0x1801F5BC0
	public string ToString(string format) { }

	// RVA: 0x1F5C30 Offset: 0x1F5030 VA: 0x1801F5C30 Slot: 7
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x160A870 Offset: 0x1609C70 VA: 0x18160A870
	public static TimeSpan op_Subtraction(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x160A810 Offset: 0x1609C10 VA: 0x18160A810
	public static TimeSpan op_Addition(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0xAE1170 Offset: 0xAE0570 VA: 0x180AE1170
	public static bool op_Equality(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x129EBD0 Offset: 0x129DFD0 VA: 0x18129EBD0
	public static bool op_Inequality(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x160A860 Offset: 0x1609C60 VA: 0x18160A860
	public static bool op_LessThan(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x160A850 Offset: 0x1609C50 VA: 0x18160A850
	public static bool op_LessThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x160A840 Offset: 0x1609C40 VA: 0x18160A840
	public static bool op_GreaterThan(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x160A830 Offset: 0x1609C30 VA: 0x18160A830
	public static bool op_GreaterThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x1609D70 Offset: 0x1609170 VA: 0x181609D70
	private static bool GetLegacyFormatMode() { }

	// RVA: 0x160A570 Offset: 0x1609970 VA: 0x18160A570
	private static bool get_LegacyMode() { }

	// RVA: 0x160A2A0 Offset: 0x16096A0 VA: 0x18160A2A0
	private static void .cctor() { }

}

