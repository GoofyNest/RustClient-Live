internal static class TimeSpanFormat // TypeDefIndex: 720
{
	internal static readonly TimeSpanFormat.FormatLiterals PositiveInvariantFormatLiterals;
	internal static readonly TimeSpanFormat.FormatLiterals NegativeInvariantFormatLiterals;


	private static string IntToString(int n, int digits) { }

	internal static string Format(TimeSpan value, string format, IFormatProvider formatProvider) { }

	private static string FormatStandard(TimeSpan value, bool isInvariant, string format, TimeSpanFormat.Pattern pattern) { }

	internal static string FormatCustomized(TimeSpan value, string format, DateTimeFormatInfo dtfi) { }

	private static void .cctor() { }

}

internal enum TimeSpanFormat.Pattern // TypeDefIndex: 721
{
	public int value__;
	public const TimeSpanFormat.Pattern None = 0;
	public const TimeSpanFormat.Pattern Minimum = 1;
	public const TimeSpanFormat.Pattern Full = 2;

}

internal struct TimeSpanFormat.FormatLiterals // TypeDefIndex: 722
{
	internal string AppCompatLiteral;
	internal int dd;
	internal int hh;
	internal int mm;
	internal int ss;
	internal int ff;
	private string[] literals;

	internal string Start { get; }
	internal string DayHourSep { get; }
	internal string HourMinuteSep { get; }
	internal string MinuteSecondSep { get; }
	internal string SecondFractionSep { get; }
	internal string End { get; }


	internal string get_Start() { }

	internal string get_DayHourSep() { }

	internal string get_HourMinuteSep() { }

	internal string get_MinuteSecondSep() { }

	internal string get_SecondFractionSep() { }

	internal string get_End() { }

	internal static TimeSpanFormat.FormatLiterals InitInvariant(bool isNegative) { }

	internal void Init(string format, bool useInvariantFieldLengths) { }

}

