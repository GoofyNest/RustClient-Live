internal static class MusicalTimeSpanParser // TypeDefIndex: 7495
{
	private static readonly Dictionary<string, Tuple<int, int>> Fractions; 
	private static readonly Dictionary<string, Tuple<int, int>> Tuplets; 
	private static readonly string FractionGroup; 
	private static readonly string FractionMnemonicGroup; 
	private static readonly string TupletGroup; 
	private static readonly string TupletMnemonicGroup; 
	private static readonly string DotsGroup; 
	private static readonly string[] Patterns; 


	internal static ParsingResult TryParse(string input, out MusicalTimeSpan timeSpan) { }

	private static string GetMnemonicGroup(string groupName, IEnumerable<string> mnemonics) { }

	private static void .cctor() { }

}

