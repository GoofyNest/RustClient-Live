public struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable // TypeDefIndex: 312
{
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
	public static readonly TimeSpan Zero; 
	public static readonly TimeSpan MaxValue; 
	public static readonly TimeSpan MinValue; 
	internal long _ticks; 
	private static bool _legacyConfigChecked; 
	private static bool _legacyMode; 

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


	public void .ctor(long ticks) { }

	public void .ctor(int hours, int minutes, int seconds) { }

	public void .ctor(int days, int hours, int minutes, int seconds, int milliseconds) { }

	public long get_Ticks() { }

	public int get_Days() { }

	public int get_Hours() { }

	public int get_Milliseconds() { }

	public int get_Minutes() { }

	public int get_Seconds() { }

	public double get_TotalHours() { }

	public double get_TotalMilliseconds() { }

	public double get_TotalMinutes() { }

	public double get_TotalSeconds() { }

	public TimeSpan Add(TimeSpan ts) { }

	public static int Compare(TimeSpan t1, TimeSpan t2) { }

	public int CompareTo(object value) { }

	public int CompareTo(TimeSpan value) { }

	public static TimeSpan FromDays(double value) { }

	public override bool Equals(object value) { }

	public bool Equals(TimeSpan obj) { }

	public override int GetHashCode() { }

	public static TimeSpan FromHours(double value) { }

	private static TimeSpan Interval(double value, int scale) { }

	public static TimeSpan FromMilliseconds(double value) { }

	public static TimeSpan FromMinutes(double value) { }

	public TimeSpan Negate() { }

	public static TimeSpan FromSeconds(double value) { }

	public TimeSpan Subtract(TimeSpan ts) { }

	public static TimeSpan FromTicks(long value) { }

	internal static long TimeToTicks(int hour, int minute, int second) { }

	public static TimeSpan Parse(string s) { }

	public static TimeSpan Parse(string input, IFormatProvider formatProvider) { }

	public override string ToString() { }

	public string ToString(string format) { }

	public string ToString(string format, IFormatProvider formatProvider) { }

	public static TimeSpan op_Subtraction(TimeSpan t1, TimeSpan t2) { }

	public static TimeSpan op_Addition(TimeSpan t1, TimeSpan t2) { }

	public static bool op_Equality(TimeSpan t1, TimeSpan t2) { }

	public static bool op_Inequality(TimeSpan t1, TimeSpan t2) { }

	public static bool op_LessThan(TimeSpan t1, TimeSpan t2) { }

	public static bool op_LessThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	public static bool op_GreaterThan(TimeSpan t1, TimeSpan t2) { }

	public static bool op_GreaterThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	private static bool GetLegacyFormatMode() { }

	private static bool get_LegacyMode() { }

	private static void .cctor() { }

}

