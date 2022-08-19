internal struct StringReference // TypeDefIndex: 5936
{	// Fields
	private readonly char[] _chars; // 0x0
	private readonly int _startIndex; // 0x8
	private readonly int _length; // 0xC

	// Properties
	public char Item { get; }
	public char[] Chars { get; }
	public int StartIndex { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x211B80 Offset: 0x210F80 VA: 0x180211B80
	public char get_Item(int i) { }

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public char[] get_Chars() { }

	// RVA: 0x122CA0 Offset: 0x1220A0 VA: 0x180122CA0
	public int get_StartIndex() { }

	// RVA: 0x1AE2C0 Offset: 0x1AD6C0 VA: 0x1801AE2C0
	public int get_Length() { }

	// RVA: 0xF9C90 Offset: 0xF9090 VA: 0x1800F9C90
	public void .ctor(char[] chars, int startIndex, int length) { }

	// RVA: 0x211B50 Offset: 0x210F50 VA: 0x180211B50 Slot: 3
	public override string ToString() { }

}

