internal static class TimeSpanFormat // TypeDefIndex: 720
{	// Fields
	internal static readonly TimeSpanFormat.FormatLiterals PositiveInvariantFormatLiterals; // 0x0
	internal static readonly TimeSpanFormat.FormatLiterals NegativeInvariantFormatLiterals; // 0x28

	// Methods

	// RVA: 0x1385E80 Offset: 0x1385280 VA: 0x181385E80
	private static string IntToString(int n, int digits) { }

	// RVA: 0x1385C70 Offset: 0x1385070 VA: 0x181385C70
	internal static string Format(TimeSpan value, string format, IFormatProvider formatProvider) { }

	// RVA: 0x1385650 Offset: 0x1384A50 VA: 0x181385650
	private static string FormatStandard(TimeSpan value, bool isInvariant, string format, TimeSpanFormat.Pattern pattern) { }

	// RVA: 0x1384BF0 Offset: 0x1383FF0 VA: 0x181384BF0
	internal static string FormatCustomized(TimeSpan value, string format, DateTimeFormatInfo dtfi) { }

	// RVA: 0x1385EB0 Offset: 0x13852B0 VA: 0x181385EB0
	private static void .cctor() { }

}

internal enum TimeSpanFormat.Pattern // TypeDefIndex: 721
{	// Fields
	public int value__; // 0x0
	public const TimeSpanFormat.Pattern None = 0;
	public const TimeSpanFormat.Pattern Minimum = 1;
	public const TimeSpanFormat.Pattern Full = 2;

}

internal struct TimeSpanFormat.FormatLiterals // TypeDefIndex: 722
{	// Fields
	internal string AppCompatLiteral; // 0x0
	internal int dd; // 0x8
	internal int hh; // 0xC
	internal int mm; // 0x10
	internal int ss; // 0x14
	internal int ff; // 0x18
	private string[] literals; // 0x20

	// Properties
	internal string Start { get; }
	internal string DayHourSep { get; }
	internal string HourMinuteSep { get; }
	internal string MinuteSecondSep { get; }
	internal string SecondFractionSep { get; }
	internal string End { get; }

	// Methods

	// RVA: 0x1EC7A0 Offset: 0x1EBBA0 VA: 0x1801EC7A0
	internal string get_Start() { }

	// RVA: 0x1EC660 Offset: 0x1EBA60 VA: 0x1801EC660
	internal string get_DayHourSep() { }

	// RVA: 0x1EC6E0 Offset: 0x1EBAE0 VA: 0x1801EC6E0
	internal string get_HourMinuteSep() { }

	// RVA: 0x1EC720 Offset: 0x1EBB20 VA: 0x1801EC720
	internal string get_MinuteSecondSep() { }

	// RVA: 0x1EC760 Offset: 0x1EBB60 VA: 0x1801EC760
	internal string get_SecondFractionSep() { }

	// RVA: 0x1EC6A0 Offset: 0x1EBAA0 VA: 0x1801EC6A0
	internal string get_End() { }

	// RVA: 0x1378A10 Offset: 0x1377E10 VA: 0x181378A10
	internal static TimeSpanFormat.FormatLiterals InitInvariant(bool isNegative) { }

	// RVA: 0x1EC650 Offset: 0x1EBA50 VA: 0x1801EC650
	internal void Init(string format, bool useInvariantFieldLengths) { }

}

