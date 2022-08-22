internal struct StringReference // TypeDefIndex: 5936
{	private readonly char[] _chars; // 0x0
	private readonly int _startIndex; // 0x8
	private readonly int _length; // 0xC

	public char Item { get; }
	public char[] Chars { get; }
	public int StartIndex { get; }
	public int Length { get; }


	public char get_Item(int i) { }

	public char[] get_Chars() { }

	public int get_StartIndex() { }

	public int get_Length() { }

	public void .ctor(char[] chars, int startIndex, int length) { }

	public override string ToString() { }

}

