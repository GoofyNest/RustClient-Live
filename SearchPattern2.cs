internal class SearchPattern2 // TypeDefIndex: 2855
{	// Fields
	private SearchPattern2.Op ops; // 0x10
	private bool ignore; // 0x18
	private bool hasWildcard; // 0x19
	private string pattern; // 0x20
	internal static readonly char[] WildcardChars; // 0x0
	internal static readonly char[] InvalidChars; // 0x8

	// Properties
	public bool HasWildcard { get; }

	// Methods

	// RVA: 0x1564280 Offset: 0x1563680 VA: 0x181564280
	public void .ctor(string pattern) { }

	// RVA: 0x15642D0 Offset: 0x15636D0 VA: 0x1815642D0
	public void .ctor(string pattern, bool ignore) { }

	// RVA: 0xFA2050 Offset: 0xFA1450 VA: 0x180FA2050
	public bool get_HasWildcard() { }

	// RVA: 0x1563E10 Offset: 0x1563210 VA: 0x181563E10
	private void Compile(string pattern) { }

	// RVA: 0x1564120 Offset: 0x1563520 VA: 0x181564120
	private static void .cctor() { }

}

private class SearchPattern2.Op // TypeDefIndex: 2856
{	// Fields
	public SearchPattern2.OpCode Code; // 0x10
	public string Argument; // 0x18
	public SearchPattern2.Op Next; // 0x20

	// Methods

	// RVA: 0x15639B0 Offset: 0x1562DB0 VA: 0x1815639B0
	public void .ctor(SearchPattern2.OpCode code) { }

}

private enum SearchPattern2.OpCode // TypeDefIndex: 2857
{	// Fields
	public int value__; // 0x0
	public const SearchPattern2.OpCode ExactString = 0;
	public const SearchPattern2.OpCode AnyChar = 1;
	public const SearchPattern2.OpCode AnyString = 2;
	public const SearchPattern2.OpCode End = 3;
	public const SearchPattern2.OpCode True = 4;

}

