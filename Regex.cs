public class Regex : ISerializable // TypeDefIndex: 2600
{	// Fields
	protected internal string pattern; // 0x10
	protected internal RegexRunnerFactory factory; // 0x18
	protected internal RegexOptions roptions; // 0x20
	private static readonly TimeSpan MaximumMatchTimeout; // 0x0
	public static readonly TimeSpan InfiniteMatchTimeout; // 0x8
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	protected internal TimeSpan internalMatchTimeout; // 0x28
	private const string DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT";
	internal static readonly TimeSpan FallbackDefaultMatchTimeout; // 0x10
	internal static readonly TimeSpan DefaultMatchTimeout; // 0x18
	protected internal Hashtable caps; // 0x30
	protected internal Hashtable capnames; // 0x38
	protected internal string[] capslist; // 0x40
	protected internal int capsize; // 0x48
	internal ExclusiveReference runnerref; // 0x50
	internal SharedReference replref; // 0x58
	internal RegexCode code; // 0x60
	internal bool refsInitialized; // 0x68
	internal static LinkedList<CachedCodeEntry> livecode; // 0x20
	internal static int cacheSize; // 0x28
	internal const int MaxOptionShift = 10;

	// Properties
	public RegexOptions Options { get; }
	public TimeSpan MatchTimeout { get; }
	public bool RightToLeft { get; }

	// Methods

	// RVA: 0x14D1190 Offset: 0x14D0590 VA: 0x1814D1190
	protected void .ctor() { }

	// RVA: 0x14D0900 Offset: 0x14CFD00 VA: 0x1814D0900
	public void .ctor(string pattern) { }

	// RVA: 0x14D0FA0 Offset: 0x14D03A0 VA: 0x1814D0FA0
	public void .ctor(string pattern, RegexOptions options) { }

	// RVA: 0x14D0990 Offset: 0x14CFD90 VA: 0x1814D0990
	private void .ctor(string pattern, RegexOptions options, TimeSpan matchTimeout, bool useCache) { }

	// RVA: 0x14D1040 Offset: 0x14D0440 VA: 0x1814D1040
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14D0590 Offset: 0x14CF990 VA: 0x1814D0590 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x14D0660 Offset: 0x14CFA60 VA: 0x1814D0660
	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	// RVA: 0x14CEBB0 Offset: 0x14CDFB0 VA: 0x1814CEBB0
	private static TimeSpan InitDefaultMatchTimeout() { }

	// RVA: 0x14CE890 Offset: 0x14CDC90 VA: 0x1814CE890
	public static string Escape(string str) { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public RegexOptions get_Options() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public TimeSpan get_MatchTimeout() { }

	// RVA: 0x14D0650 Offset: 0x14CFA50 VA: 0x1814D0650
	public bool get_RightToLeft() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 3
	public override string ToString() { }

	// RVA: 0x14CE920 Offset: 0x14CDD20 VA: 0x1814CE920
	public string GroupNameFromNumber(int i) { }

	// RVA: 0x14CEA90 Offset: 0x14CDE90 VA: 0x1814CEA90
	public int GroupNumberFromName(string name) { }

	// RVA: 0x14CEF50 Offset: 0x14CE350 VA: 0x1814CEF50
	public static bool IsMatch(string input, string pattern) { }

	// RVA: 0x14CF1B0 Offset: 0x14CE5B0 VA: 0x1814CF1B0
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x14CF0D0 Offset: 0x14CE4D0 VA: 0x1814CF0D0
	public bool IsMatch(string input) { }

	// RVA: 0x14CEEA0 Offset: 0x14CE2A0 VA: 0x1814CEEA0
	public bool IsMatch(string input, int startat) { }

	// RVA: 0x14CF670 Offset: 0x14CEA70 VA: 0x1814CF670
	public static Match Match(string input, string pattern) { }

	// RVA: 0x14CF540 Offset: 0x14CE940 VA: 0x1814CF540
	public static Match Match(string input, string pattern, RegexOptions options) { }

	// RVA: 0x14CF7D0 Offset: 0x14CEBD0 VA: 0x1814CF7D0
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x14CF700 Offset: 0x14CEB00 VA: 0x1814CF700
	public Match Match(string input) { }

	// RVA: 0x14CF5D0 Offset: 0x14CE9D0 VA: 0x1814CF5D0
	public Match Match(string input, int startat) { }

	// RVA: 0x14CFAC0 Offset: 0x14CEEC0 VA: 0x1814CFAC0
	public static MatchCollection Matches(string input, string pattern) { }

	// RVA: 0x14CFB50 Offset: 0x14CEF50 VA: 0x1814CFB50
	public static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x14CF910 Offset: 0x14CED10 VA: 0x1814CF910
	public MatchCollection Matches(string input) { }

	// RVA: 0x14CFD60 Offset: 0x14CF160 VA: 0x1814CFD60
	public MatchCollection Matches(string input, int startat) { }

	// RVA: 0x14CFEF0 Offset: 0x14CF2F0 VA: 0x1814CFEF0
	public string Replace(string input, string replacement) { }

	// RVA: 0x14CFFA0 Offset: 0x14CF3A0 VA: 0x1814CFFA0
	public string Replace(string input, string replacement, int count, int startat) { }

	// RVA: 0x14CEDD0 Offset: 0x14CE1D0 VA: 0x1814CEDD0
	protected void InitializeReferences() { }

	// RVA: 0x14D0160 Offset: 0x14CF560 VA: 0x1814D0160
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	// RVA: 0x14CF300 Offset: 0x14CE700 VA: 0x1814CF300
	private static CachedCodeEntry LookupCachedAndUpdate(string key) { }

	// RVA: 0x14CE470 Offset: 0x14CD870 VA: 0x1814CE470
	private CachedCodeEntry CacheCode(string key) { }

	// RVA: 0x14D0650 Offset: 0x14CFA50 VA: 0x1814D0650
	protected bool UseOptionR() { }

	// RVA: 0x14D0640 Offset: 0x14CFA40 VA: 0x1814D0640
	internal bool UseOptionInvariant() { }

	// RVA: 0x14D07D0 Offset: 0x14CFBD0 VA: 0x1814D07D0
	private static void .cctor() { }

}

