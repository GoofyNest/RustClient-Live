internal static class TimeSpanParse // TypeDefIndex: 723
{	private static readonly TimeSpanParse.TimeSpanToken zero; // 0x130BF


	private static bool TryTimeToTicks(bool positive, TimeSpanParse.TimeSpanToken days, TimeSpanParse.TimeSpanToken hours, TimeSpanParse.TimeSpanToken minutes, TimeSpanParse.TimeSpanToken seconds, TimeSpanParse.TimeSpanToken fraction, out long result) { }

	internal static TimeSpan Parse(string input, IFormatProvider formatProvider) { }

	private static bool TryParseTimeSpan(string input, TimeSpanParse.TimeSpanStandardStyles style, IFormatProvider formatProvider, ref TimeSpanParse.TimeSpanResult result) { }

	private static bool ProcessTerminalState(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	private static bool ProcessTerminal_DHMSF(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	private static bool ProcessTerminal_HMS_F_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	private static bool ProcessTerminal_HM_S_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	private static bool ProcessTerminal_HM(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	private static bool ProcessTerminal_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	private static void .cctor() { }

}

private enum TimeSpanParse.TimeSpanThrowStyle // TypeDefIndex: 724
{	public int value__; // 0x0
	public const TimeSpanParse.TimeSpanThrowStyle None = 0;
	public const TimeSpanParse.TimeSpanThrowStyle All = 1;

}

private enum TimeSpanParse.ParseFailureKind // TypeDefIndex: 725
{	public int value__; // 0x0
	public const TimeSpanParse.ParseFailureKind None = 0;
	public const TimeSpanParse.ParseFailureKind ArgumentNull = 1;
	public const TimeSpanParse.ParseFailureKind Format = 2;
	public const TimeSpanParse.ParseFailureKind FormatWithParameter = 3;
	public const TimeSpanParse.ParseFailureKind Overflow = 4;

}

private enum TimeSpanParse.TimeSpanStandardStyles // TypeDefIndex: 726
{	public int value__; // 0x0
	public const TimeSpanParse.TimeSpanStandardStyles None = 0;
	public const TimeSpanParse.TimeSpanStandardStyles Invariant = 1;
	public const TimeSpanParse.TimeSpanStandardStyles Localized = 2;
	public const TimeSpanParse.TimeSpanStandardStyles RequireFull = 4;
	public const TimeSpanParse.TimeSpanStandardStyles Any = 3;

}

private enum TimeSpanParse.TTT // TypeDefIndex: 727
{	public int value__; // 0x0
	public const TimeSpanParse.TTT None = 0;
	public const TimeSpanParse.TTT End = 1;
	public const TimeSpanParse.TTT Num = 2;
	public const TimeSpanParse.TTT Sep = 3;
	public const TimeSpanParse.TTT NumOverflow = 4;

}

private struct TimeSpanParse.TimeSpanToken // TypeDefIndex: 728
{	internal TimeSpanParse.TTT ttt; // 0x0
	internal int num; // 0x4
	internal int zeroes; // 0x8
	internal string sep; // 0x10


	public void .ctor(int number) { }

	public bool IsInvalidNumber(int maxValue, int maxPrecision) { }

}

private struct TimeSpanParse.TimeSpanTokenizer // TypeDefIndex: 729
{	private int m_pos; // 0x0
	private string m_value; // 0x8

	internal bool EOL { get; }
	internal char NextChar { get; }
	internal char CurrentChar { get; }


	internal void Init(string input) { }

	internal void Init(string input, int startPosition) { }

	internal TimeSpanParse.TimeSpanToken GetNextToken() { }

	internal bool get_EOL() { }

	internal char get_NextChar() { }

	internal char get_CurrentChar() { }

}

private struct TimeSpanParse.TimeSpanRawInfo // TypeDefIndex: 730
{	internal TimeSpanParse.TTT lastSeenTTT; // 0x0
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

	internal TimeSpanFormat.FormatLiterals PositiveInvariant { get; }
	internal TimeSpanFormat.FormatLiterals NegativeInvariant { get; }
	internal TimeSpanFormat.FormatLiterals PositiveLocalized { get; }
	internal TimeSpanFormat.FormatLiterals NegativeLocalized { get; }


	internal TimeSpanFormat.FormatLiterals get_PositiveInvariant() { }

	internal TimeSpanFormat.FormatLiterals get_NegativeInvariant() { }

	internal TimeSpanFormat.FormatLiterals get_PositiveLocalized() { }

	internal TimeSpanFormat.FormatLiterals get_NegativeLocalized() { }

	internal bool FullAppCompatMatch(TimeSpanFormat.FormatLiterals pattern) { }

	internal bool PartialAppCompatMatch(TimeSpanFormat.FormatLiterals pattern) { }

	internal bool FullMatch(TimeSpanFormat.FormatLiterals pattern) { }

	internal bool FullDMatch(TimeSpanFormat.FormatLiterals pattern) { }

	internal bool FullHMMatch(TimeSpanFormat.FormatLiterals pattern) { }

	internal bool FullDHMMatch(TimeSpanFormat.FormatLiterals pattern) { }

	internal bool FullHMSMatch(TimeSpanFormat.FormatLiterals pattern) { }

	internal bool FullDHMSMatch(TimeSpanFormat.FormatLiterals pattern) { }

	internal bool FullHMSFMatch(TimeSpanFormat.FormatLiterals pattern) { }

	internal void Init(DateTimeFormatInfo dtfi) { }

	internal bool ProcessToken(ref TimeSpanParse.TimeSpanToken tok, ref TimeSpanParse.TimeSpanResult result) { }

	private bool AddSep(string sep, ref TimeSpanParse.TimeSpanResult result) { }

	private bool AddNum(TimeSpanParse.TimeSpanToken num, ref TimeSpanParse.TimeSpanResult result) { }

}

private struct TimeSpanParse.TimeSpanResult // TypeDefIndex: 731
{	internal TimeSpan parsedTimeSpan; // 0x0
	internal TimeSpanParse.TimeSpanThrowStyle throwStyle; // 0x8
	internal TimeSpanParse.ParseFailureKind m_failure; // 0xC
	internal string m_failureMessageID; // 0x10
	internal object m_failureMessageFormatArgument; // 0x18
	internal string m_failureArgumentName; // 0x20


	internal void Init(TimeSpanParse.TimeSpanThrowStyle canThrow) { }

	internal void SetFailure(TimeSpanParse.ParseFailureKind failure, string failureMessageID) { }

	internal void SetFailure(TimeSpanParse.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	internal void SetFailure(TimeSpanParse.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName) { }

	internal Exception GetTimeSpanParseException() { }

}

