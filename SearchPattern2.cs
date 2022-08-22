internal class SearchPattern2 // TypeDefIndex: 2855
{	private SearchPattern2.Op ops; // 0x10
	private bool ignore; // 0x18
	private bool hasWildcard; // 0x19
	private string pattern; // 0x20
	internal static readonly char[] WildcardChars; // 0x0
	internal static readonly char[] InvalidChars; // 0x8

	public bool HasWildcard { get; }


	public void .ctor(string pattern) { }

	public void .ctor(string pattern, bool ignore) { }

	public bool get_HasWildcard() { }

	private void Compile(string pattern) { }

	private static void .cctor() { }

}

private class SearchPattern2.Op // TypeDefIndex: 2856
{	public SearchPattern2.OpCode Code; // 0x10
	public string Argument; // 0x18
	public SearchPattern2.Op Next; // 0x20


	public void .ctor(SearchPattern2.OpCode code) { }

}

private enum SearchPattern2.OpCode // TypeDefIndex: 2857
{	public int value__; // 0x0
	public const SearchPattern2.OpCode ExactString = 0;
	public const SearchPattern2.OpCode AnyChar = 1;
	public const SearchPattern2.OpCode AnyString = 2;
	public const SearchPattern2.OpCode End = 3;
	public const SearchPattern2.OpCode True = 4;

}

