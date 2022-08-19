internal static class ParsingUtilities // TypeDefIndex: 7632
{	// Methods

	// RVA: 0x139F150 Offset: 0x139E550 VA: 0x18139F150
	public static string GetNonnegativeIntegerNumberGroup(string groupName) { }

	// RVA: 0x139F100 Offset: 0x139E500 VA: 0x18139F100
	public static string GetNonnegativeDoubleNumberGroup(string groupName) { }

	// RVA: 0x139F1A0 Offset: 0x139E5A0 VA: 0x18139F1A0
	public static Match Match(string input, IEnumerable<string> patterns, bool ignoreCase = True) { }

	// RVA: 0x139F620 Offset: 0x139EA20 VA: 0x18139F620
	public static bool ParseNonnegativeInt(Match match, string groupName, int defaultValue, out int value) { }

	// RVA: 0x139F500 Offset: 0x139E900 VA: 0x18139F500
	public static bool ParseNonnegativeDouble(Match match, string groupName, double defaultValue, out double value) { }

	// RVA: 0x139F6C0 Offset: 0x139EAC0 VA: 0x18139F6C0
	public static bool ParseNonnegativeLong(Match match, string groupName, long defaultValue, out long value) { }

	// RVA: 0x139F450 Offset: 0x139E850 VA: 0x18139F450
	private static bool ParseInt(Match match, string groupName, int defaultValue, NumberStyles numberStyle, out int value) { }

	// RVA: 0x139F320 Offset: 0x139E720 VA: 0x18139F320
	private static bool ParseDouble(Match match, string groupName, double defaultValue, NumberStyles numberStyle, out double value) { }

}

private sealed class ParsingUtilities.<>c__DisplayClass8_0 // TypeDefIndex: 7633
{	// Fields
	public string input; // 0x10
	public bool ignoreCase; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13A5390 Offset: 0x13A4790 VA: 0x1813A5390
	internal Match <Match>b__0(string p) { }

}

private sealed class ParsingUtilities.<>c // TypeDefIndex: 7634
{	// Fields
	public static readonly ParsingUtilities.<>c <>9; // 0x0
	public static Func<Match, bool> <>9__8_1; // 0x8

	// Methods

	// RVA: 0x13A54B0 Offset: 0x13A48B0 VA: 0x1813A54B0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13A4EB0 Offset: 0x13A42B0 VA: 0x1813A4EB0
	internal bool <Match>b__8_1(Match m) { }

}

