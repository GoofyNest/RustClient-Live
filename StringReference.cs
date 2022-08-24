internal struct StringReference // TypeDefIndex: 5936
{
	private readonly char[] _chars; 
	private readonly int _startIndex; 
	private readonly int _length; 

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

