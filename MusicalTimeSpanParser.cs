internal static class MusicalTimeSpanParser // TypeDefIndex: 7488
{	// Fields
	private static readonly Dictionary<string, Tuple<int, int>> Fractions; // 0x0
	private static readonly Dictionary<string, Tuple<int, int>> Tuplets; // 0x8
	private static readonly string FractionGroup; // 0x10
	private static readonly string FractionMnemonicGroup; // 0x18
	private static readonly string TupletGroup; // 0x20
	private static readonly string TupletMnemonicGroup; // 0x28
	private static readonly string DotsGroup; // 0x30
	private static readonly string[] Patterns; // 0x38

	// Methods

	// RVA: 0x21F7D70 Offset: 0x21F7170 VA: 0x1821F7D70
	internal static ParsingResult TryParse(string input, out MusicalTimeSpan timeSpan) { }

	// RVA: 0x21F7B00 Offset: 0x21F6F00 VA: 0x1821F7B00
	private static string GetMnemonicGroup(string groupName, IEnumerable<string> mnemonics) { }

	// RVA: 0x21F83D0 Offset: 0x21F77D0 VA: 0x1821F83D0
	private static void .cctor() { }

}

