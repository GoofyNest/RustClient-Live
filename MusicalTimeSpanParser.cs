internal static class MusicalTimeSpanParser // TypeDefIndex: 7488
{	private static readonly Dictionary<string, Tuple<int, int>> Fractions; // 0x0
	private static readonly Dictionary<string, Tuple<int, int>> Tuplets; // 0x8
	private static readonly string FractionGroup; // 0x10
	private static readonly string FractionMnemonicGroup; // 0x18
	private static readonly string TupletGroup; // 0x20
	private static readonly string TupletMnemonicGroup; // 0x28
	private static readonly string DotsGroup; // 0x30
	private static readonly string[] Patterns; // 0x38


	internal static ParsingResult TryParse(string input, out MusicalTimeSpan timeSpan) { }

	private static string GetMnemonicGroup(string groupName, IEnumerable<string> mnemonics) { }

	private static void .cctor() { }

}

