internal static class TimeSpanFormat // TypeDefIndex: 720
{	internal static readonly TimeSpanFormat.FormatLiterals PositiveInvariantFormatLiterals; // 0x0
	internal static readonly TimeSpanFormat.FormatLiterals NegativeInvariantFormatLiterals; // 0x28


	private static string IntToString(int n, int digits) { }

	internal static string Format(TimeSpan value, string format, IFormatProvider formatProvider) { }

	private static string FormatStandard(TimeSpan value, bool isInvariant, string format, TimeSpanFormat.Pattern pattern) { }

	internal static string FormatCustomized(TimeSpan value, string format, DateTimeFormatInfo dtfi) { }

	private static void .cctor() { }

}

internal enum TimeSpanFormat.Pattern // TypeDefIndex: 721
{	public int value__; // 0x0
	public const TimeSpanFormat.Pattern None = 0;
	public const TimeSpanFormat.Pattern Minimum = 1;
	public const TimeSpanFormat.Pattern Full = 2;

}

internal struct TimeSpanFormat.FormatLiterals // TypeDefIndex: 722
{	internal string AppCompatLiteral; // 0x0
	internal int dd; // 0x8
	internal int hh; // 0xC
	internal int mm; // 0x10
	internal int ss; // 0x14
	internal int ff; // 0x18
	private string[] literals; // 0x20

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

