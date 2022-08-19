internal static class TimeSpanParse // TypeDefIndex: 723
{	// Fields
	private static readonly TimeSpanParse.TimeSpanToken zero; // 0x130BF

	// Methods

	// RVA: 0x138A440 Offset: 0x1389840 VA: 0x18138A440
	private static bool TryTimeToTicks(bool positive, TimeSpanParse.TimeSpanToken days, TimeSpanParse.TimeSpanToken hours, TimeSpanParse.TimeSpanToken minutes, TimeSpanParse.TimeSpanToken seconds, TimeSpanParse.TimeSpanToken fraction, out long result) { }

	// RVA: 0x1385F50 Offset: 0x1385350 VA: 0x181385F50
	internal static TimeSpan Parse(string input, IFormatProvider formatProvider) { }

	// RVA: 0x1389E10 Offset: 0x1389210 VA: 0x181389E10
	private static bool TryParseTimeSpan(string input, TimeSpanParse.TimeSpanStandardStyles style, IFormatProvider formatProvider, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1386010 Offset: 0x1385410 VA: 0x181386010
	private static bool ProcessTerminalState(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1386200 Offset: 0x1385600 VA: 0x181386200
	private static bool ProcessTerminal_DHMSF(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1386B00 Offset: 0x1385F00 VA: 0x181386B00
	private static bool ProcessTerminal_HMS_F_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x13883F0 Offset: 0x13877F0 VA: 0x1813883F0
	private static bool ProcessTerminal_HM_S_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x13899F0 Offset: 0x1388DF0 VA: 0x1813899F0
	private static bool ProcessTerminal_HM(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x13866E0 Offset: 0x1385AE0 VA: 0x1813866E0
	private static bool ProcessTerminal_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x138A680 Offset: 0x1389A80 VA: 0x18138A680
	private static void .cctor() { }

}

private enum TimeSpanParse.TimeSpanThrowStyle // TypeDefIndex: 724
{	// Fields
	public int value__; // 0x0
	public const TimeSpanParse.TimeSpanThrowStyle None = 0;
	public const TimeSpanParse.TimeSpanThrowStyle All = 1;

}

private enum TimeSpanParse.ParseFailureKind // TypeDefIndex: 725
{	// Fields
	public int value__; // 0x0
	public const TimeSpanParse.ParseFailureKind None = 0;
	public const TimeSpanParse.ParseFailureKind ArgumentNull = 1;
	public const TimeSpanParse.ParseFailureKind Format = 2;
	public const TimeSpanParse.ParseFailureKind FormatWithParameter = 3;
	public const TimeSpanParse.ParseFailureKind Overflow = 4;

}

private enum TimeSpanParse.TimeSpanStandardStyles // TypeDefIndex: 726
{	// Fields
	public int value__; // 0x0
	public const TimeSpanParse.TimeSpanStandardStyles None = 0;
	public const TimeSpanParse.TimeSpanStandardStyles Invariant = 1;
	public const TimeSpanParse.TimeSpanStandardStyles Localized = 2;
	public const TimeSpanParse.TimeSpanStandardStyles RequireFull = 4;
	public const TimeSpanParse.TimeSpanStandardStyles Any = 3;

}

private enum TimeSpanParse.TTT // TypeDefIndex: 727
{	// Fields
	public int value__; // 0x0
	public const TimeSpanParse.TTT None = 0;
	public const TimeSpanParse.TTT End = 1;
	public const TimeSpanParse.TTT Num = 2;
	public const TimeSpanParse.TTT Sep = 3;
	public const TimeSpanParse.TTT NumOverflow = 4;

}

private struct TimeSpanParse.TimeSpanToken // TypeDefIndex: 728
{	// Fields
	internal TimeSpanParse.TTT ttt; // 0x0
	internal int num; // 0x4
	internal int zeroes; // 0x8
	internal string sep; // 0x10

	// Methods

	// RVA: 0x1ED830 Offset: 0x1ECC30 VA: 0x1801ED830
	public void .ctor(int number) { }

	// RVA: 0x1ED820 Offset: 0x1ECC20 VA: 0x1801ED820
	public bool IsInvalidNumber(int maxValue, int maxPrecision) { }

}

private struct TimeSpanParse.TimeSpanTokenizer // TypeDefIndex: 729
{	// Fields
	private int m_pos; // 0x0
	private string m_value; // 0x8

	// Properties
	internal bool EOL { get; }
	internal char NextChar { get; }
	internal char CurrentChar { get; }

	// Methods

	// RVA: 0x1ED8F0 Offset: 0x1ECCF0 VA: 0x1801ED8F0
	internal void Init(string input) { }

	// RVA: 0x1ED8E0 Offset: 0x1ECCE0 VA: 0x1801ED8E0
	internal void Init(string input, int startPosition) { }

	// RVA: 0x1ED8C0 Offset: 0x1ECCC0 VA: 0x1801ED8C0
	internal TimeSpanParse.TimeSpanToken GetNextToken() { }

	// RVA: 0x1ED950 Offset: 0x1ECD50 VA: 0x1801ED950
	internal bool get_EOL() { }

	// RVA: 0x1ED980 Offset: 0x1ECD80 VA: 0x1801ED980
	internal char get_NextChar() { }

	// RVA: 0x1ED910 Offset: 0x1ECD10 VA: 0x1801ED910
	internal char get_CurrentChar() { }

}

private struct TimeSpanParse.TimeSpanRawInfo // TypeDefIndex: 730
{	// Fields
	internal TimeSpanParse.TTT lastSeenTTT; // 0x0
	internal int tokenCount; // 0x4
	internal int SepCount; // 0x8
	internal int NumCount; // 0xC
	internal string[] literals; // 0x10
	internal TimeSpanParse.TimeSpanToken[] numbers; // 0x18
	private TimeSpanFormat.FormatLiterals m_posLoc; // 0x20
	private TimeSpanFormat.FormatLiterals m_negLoc; // 0x48
	private bool m_posLocInit; // 0x70
	private bool m_negLocInit; // 0x71
	private string m_fullPosPattern; // 0x78
	private string m_fullNegPattern; // 0x80

	// Properties
	internal TimeSpanFormat.FormatLiterals PositiveInvariant { get; }
	internal TimeSpanFormat.FormatLiterals NegativeInvariant { get; }
	internal TimeSpanFormat.FormatLiterals PositiveLocalized { get; }
	internal TimeSpanFormat.FormatLiterals NegativeLocalized { get; }

	// Methods

	// RVA: 0x1ED530 Offset: 0x1EC930 VA: 0x1801ED530
	internal TimeSpanFormat.FormatLiterals get_PositiveInvariant() { }

	// RVA: 0x1ED4A0 Offset: 0x1EC8A0 VA: 0x1801ED4A0
	internal TimeSpanFormat.FormatLiterals get_NegativeInvariant() { }

	// RVA: 0x1ED550 Offset: 0x1EC950 VA: 0x1801ED550
	internal TimeSpanFormat.FormatLiterals get_PositiveLocalized() { }

	// RVA: 0x1ED4C0 Offset: 0x1EC8C0 VA: 0x1801ED4C0
	internal TimeSpanFormat.FormatLiterals get_NegativeLocalized() { }

	// RVA: 0x1ED240 Offset: 0x1EC640 VA: 0x1801ED240
	internal bool FullAppCompatMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED450 Offset: 0x1EC850 VA: 0x1801ED450
	internal bool PartialAppCompatMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED400 Offset: 0x1EC800 VA: 0x1801ED400
	internal bool FullMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED300 Offset: 0x1EC700 VA: 0x1801ED300
	internal bool FullDMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED340 Offset: 0x1EC740 VA: 0x1801ED340
	internal bool FullHMMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED280 Offset: 0x1EC680 VA: 0x1801ED280
	internal bool FullDHMMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED3C0 Offset: 0x1EC7C0 VA: 0x1801ED3C0
	internal bool FullHMSMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED2C0 Offset: 0x1EC6C0 VA: 0x1801ED2C0
	internal bool FullDHMSMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED380 Offset: 0x1EC780 VA: 0x1801ED380
	internal bool FullHMSFMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1ED440 Offset: 0x1EC840 VA: 0x1801ED440
	internal void Init(DateTimeFormatInfo dtfi) { }

	// RVA: 0x1ED490 Offset: 0x1EC890 VA: 0x1801ED490
	internal bool ProcessToken(ref TimeSpanParse.TimeSpanToken tok, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1ED230 Offset: 0x1EC630 VA: 0x1801ED230
	private bool AddSep(string sep, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1ED200 Offset: 0x1EC600 VA: 0x1801ED200
	private bool AddNum(TimeSpanParse.TimeSpanToken num, ref TimeSpanParse.TimeSpanResult result) { }

}

private struct TimeSpanParse.TimeSpanResult // TypeDefIndex: 731
{	// Fields
	internal TimeSpan parsedTimeSpan; // 0x0
	internal TimeSpanParse.TimeSpanThrowStyle throwStyle; // 0x8
	internal TimeSpanParse.ParseFailureKind m_failure; // 0xC
	internal string m_failureMessageID; // 0x10
	internal object m_failureMessageFormatArgument; // 0x18
	internal string m_failureArgumentName; // 0x20

	// Methods

	// RVA: 0x1ED5F0 Offset: 0x1EC9F0 VA: 0x1801ED5F0
	internal void Init(TimeSpanParse.TimeSpanThrowStyle canThrow) { }

	// RVA: 0x1ED620 Offset: 0x1ECA20 VA: 0x1801ED620
	internal void SetFailure(TimeSpanParse.ParseFailureKind failure, string failureMessageID) { }

	// RVA: 0x1ED600 Offset: 0x1ECA00 VA: 0x1801ED600
	internal void SetFailure(TimeSpanParse.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x1ED650 Offset: 0x1ECA50 VA: 0x1801ED650
	internal void SetFailure(TimeSpanParse.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName) { }

	// RVA: 0x1ED5E0 Offset: 0x1EC9E0 VA: 0x1801ED5E0
	internal Exception GetTimeSpanParseException() { }

}

