internal static class ParsingUtilities // TypeDefIndex: 7632
{
	public static string GetNonnegativeIntegerNumberGroup(string groupName) { }

	public static string GetNonnegativeDoubleNumberGroup(string groupName) { }

	public static Match Match(string input, IEnumerable<string> patterns, bool ignoreCase = True) { }

	public static bool ParseNonnegativeInt(Match match, string groupName, int defaultValue, out int value) { }

	public static bool ParseNonnegativeDouble(Match match, string groupName, double defaultValue, out double value) { }

	public static bool ParseNonnegativeLong(Match match, string groupName, long defaultValue, out long value) { }

	private static bool ParseInt(Match match, string groupName, int defaultValue, NumberStyles numberStyle, out int value) { }

	private static bool ParseDouble(Match match, string groupName, double defaultValue, NumberStyles numberStyle, out double value) { }

}

private sealed class ParsingUtilities.<>c__DisplayClass8_0 // TypeDefIndex: 7633
{	public string input; // 0x10
	public bool ignoreCase; // 0x18


	public void .ctor() { }

	internal Match <Match>b__0(string p) { }

}

private sealed class ParsingUtilities.<>c // TypeDefIndex: 7634
{	public static readonly ParsingUtilities.<>c <>9; // 0x0
	public static Func<Match, bool> <>9__8_1; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <Match>b__8_1(Match m) { }

}

