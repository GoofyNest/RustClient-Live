public class Regex : ISerializable // TypeDefIndex: 2600
{	protected internal string pattern; // 0x10
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

	public RegexOptions Options { get; }
	public TimeSpan MatchTimeout { get; }
	public bool RightToLeft { get; }


	protected void .ctor() { }

	public void .ctor(string pattern) { }

	public void .ctor(string pattern, RegexOptions options) { }

	private void .ctor(string pattern, RegexOptions options, TimeSpan matchTimeout, bool useCache) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	private static TimeSpan InitDefaultMatchTimeout() { }

	public static string Escape(string str) { }

	public RegexOptions get_Options() { }

	public TimeSpan get_MatchTimeout() { }

	public bool get_RightToLeft() { }

	public override string ToString() { }

	public string GroupNameFromNumber(int i) { }

	public int GroupNumberFromName(string name) { }

	public static bool IsMatch(string input, string pattern) { }

	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	public bool IsMatch(string input) { }

	public bool IsMatch(string input, int startat) { }

	public static Match Match(string input, string pattern) { }

	public static Match Match(string input, string pattern, RegexOptions options) { }

	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	public Match Match(string input) { }

	public Match Match(string input, int startat) { }

	public static MatchCollection Matches(string input, string pattern) { }

	public static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	public MatchCollection Matches(string input) { }

	public MatchCollection Matches(string input, int startat) { }

	public string Replace(string input, string replacement) { }

	public string Replace(string input, string replacement, int count, int startat) { }

	protected void InitializeReferences() { }

	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	private static CachedCodeEntry LookupCachedAndUpdate(string key) { }

	private CachedCodeEntry CacheCode(string key) { }

	protected bool UseOptionR() { }

	internal bool UseOptionInvariant() { }

	private static void .cctor() { }

}

