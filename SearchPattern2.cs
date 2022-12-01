internal class SearchPattern2 // TypeDefIndex: 2855
{
	private SearchPattern2.Op ops;
	private bool ignore;
	private bool hasWildcard;
	private string pattern;
	internal static readonly char[] WildcardChars;
	internal static readonly char[] InvalidChars;

	public bool HasWildcard { get; }


	public void .ctor(string pattern) { }

	public void .ctor(string pattern, bool ignore) { }

	public bool get_HasWildcard() { }

	private void Compile(string pattern) { }

	private static void .cctor() { }

}

private class SearchPattern2.Op // TypeDefIndex: 2856
{
	public SearchPattern2.OpCode Code;
	public string Argument;
	public SearchPattern2.Op Next;


	public void .ctor(SearchPattern2.OpCode code) { }

}

private enum SearchPattern2.OpCode // TypeDefIndex: 2857
{
	public int value__;
	public const SearchPattern2.OpCode ExactString = 0;
	public const SearchPattern2.OpCode AnyChar = 1;
	public const SearchPattern2.OpCode AnyString = 2;
	public const SearchPattern2.OpCode End = 3;
	public const SearchPattern2.OpCode True = 4;

}

