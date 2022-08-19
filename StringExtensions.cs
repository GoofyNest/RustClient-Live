public static class StringExtensions // TypeDefIndex: 4846
{	// Fields
	private static readonly Regex regexSplitQuotes; // 0x0
	private static char[] spaceOrQuote; // 0x8
	private static char[] FilenameDelim; // 0x10
	private static readonly char[] _badCharacters; // 0x18

	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x226B4A0 Offset: 0x226A8A0 VA: 0x18226B4A0
	public static string QuoteSafe(string str) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x226B800 Offset: 0x226AC00 VA: 0x18226B800
	public static string[] SplitQuotesStrings(string input, int maxCount = 2147483647) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x226BB00 Offset: 0x226AF00 VA: 0x18226BB00
	public static Decimal ToDecimal(string str, Decimal Default) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x226BB80 Offset: 0x226AF80 VA: 0x18226BB80
	public static float ToFloat(string str, float Default = 0) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x226BC70 Offset: 0x226B070 VA: 0x18226BC70
	public static int ToInt(string str, int Default = 0) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x226B9C0 Offset: 0x226ADC0 VA: 0x18226B9C0
	public static bool ToBool(string str) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x226C010 Offset: 0x226B410 VA: 0x18226C010
	public static string Truncate(string str, int maxLength, string appendage) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x226BE50 Offset: 0x226B250 VA: 0x18226BE50
	public static string TruncateFilename(string str, int maxLength, string appendage) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x226B470 Offset: 0x226A870 VA: 0x18226B470
	public static bool Contains(string source, string toCheck, StringComparison comp) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x226B660 Offset: 0x226AA60 VA: 0x18226B660
	public static string Snippet(string source, string find, int padding) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x226B550 Offset: 0x226A950 VA: 0x18226B550
	public static string RemoveBadCharacters(string str) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x226B3F0 Offset: 0x226A7F0 VA: 0x18226B3F0
	public static string Base64Encode(string plainText) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x226B370 Offset: 0x226A770 VA: 0x18226B370
	public static string Base64Decode(string base64EncodedData) { }

	// RVA: 0x226C090 Offset: 0x226B490 VA: 0x18226C090
	private static void .cctor() { }

}

private sealed class StringExtensions.<>c // TypeDefIndex: 4847
{	// Fields
	public static readonly StringExtensions.<>c <>9; // 0x0
	public static Func<char, bool> <>9__14_0; // 0x8

	// Methods

	// RVA: 0x226C2C0 Offset: 0x226B6C0 VA: 0x18226C2C0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x226C240 Offset: 0x226B640 VA: 0x18226C240
	internal bool <RemoveBadCharacters>b__14_0(char x) { }

}

public static class StringExtensions // TypeDefIndex: 5604
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21B7BB0 Offset: 0x21B6FB0 VA: 0x1821B7BB0
	public static string BBCodeToUnity(string x) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21B7DF0 Offset: 0x21B71F0 VA: 0x1821B7DF0
	public static Vector3 ToVector3(string str) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21B7C20 Offset: 0x21B7020 VA: 0x1821B7C20
	public static Color ToColor(string str) { }

}

