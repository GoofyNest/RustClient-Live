public static class StringExtensions // TypeDefIndex: 4846
{
	private static readonly Regex regexSplitQuotes; 
	private static char[] spaceOrQuote; 
	private static char[] FilenameDelim; 
	private static readonly char[] _badCharacters; 


	[ExtensionAttribute] 
	public static string QuoteSafe(string str) { }

	[ExtensionAttribute] 
	public static string[] SplitQuotesStrings(string input, int maxCount = 2147483647) { }

	[ExtensionAttribute] 
	public static Decimal ToDecimal(string str, Decimal Default) { }

	[ExtensionAttribute] 
	public static float ToFloat(string str, float Default = 0) { }

	[ExtensionAttribute] 
	public static int ToInt(string str, int Default = 0) { }

	[ExtensionAttribute] 
	public static bool ToBool(string str) { }

	[ExtensionAttribute] 
	public static string Truncate(string str, int maxLength, string appendage) { }

	[ExtensionAttribute] 
	public static string TruncateFilename(string str, int maxLength, string appendage) { }

	[ExtensionAttribute] 
	public static bool Contains(string source, string toCheck, StringComparison comp) { }

	[ExtensionAttribute] 
	public static string Snippet(string source, string find, int padding) { }

	[ExtensionAttribute] 
	public static string RemoveBadCharacters(string str) { }

	[ExtensionAttribute] 
	public static string Base64Encode(string plainText) { }

	[ExtensionAttribute] 
	public static string Base64Decode(string base64EncodedData) { }

	private static void .cctor() { }

}

private sealed class StringExtensions.<>c // TypeDefIndex: 4847
{
	public static readonly StringExtensions.<>c <>9; 
	public static Func<char, bool> <>9__14_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <RemoveBadCharacters>b__14_0(char x) { }

}

public static class StringExtensions // TypeDefIndex: 5604
{

	[ExtensionAttribute] 
	public static string BBCodeToUnity(string x) { }

	[ExtensionAttribute] 
	public static Vector3 ToVector3(string str) { }

	[ExtensionAttribute] 
	public static Color ToColor(string str) { }

}

