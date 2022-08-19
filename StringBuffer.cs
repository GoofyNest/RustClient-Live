internal struct StringBuffer // TypeDefIndex: 5960
{	// Fields
	private char[] _buffer; // 0x0
	private int _position; // 0x8

	// Properties
	public int Position { get; set; }
	public bool IsEmpty { get; }
	public char[] InternalBuffer { get; }

	// Methods

	// RVA: 0x122CA0 Offset: 0x1220A0 VA: 0x180122CA0
	public int get_Position() { }

	// RVA: 0x19DDE0 Offset: 0x19D1E0 VA: 0x18019DDE0
	public void set_Position(int value) { }

	// RVA: 0x1186B0 Offset: 0x117AB0 VA: 0x1801186B0
	public bool get_IsEmpty() { }

	// RVA: 0x211950 Offset: 0x210D50 VA: 0x180211950
	public void .ctor(IArrayPool<char> bufferPool, int initalSize) { }

	// RVA: 0x2119E0 Offset: 0x210DE0 VA: 0x1802119E0
	private void .ctor(char[] buffer) { }

	// RVA: 0x211500 Offset: 0x210900 VA: 0x180211500
	public void Append(IArrayPool<char> bufferPool, char value) { }

	// RVA: 0x211640 Offset: 0x210A40 VA: 0x180211640
	public void Append(IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count) { }

	// RVA: 0x211780 Offset: 0x210B80 VA: 0x180211780
	public void Clear(IArrayPool<char> bufferPool) { }

	// RVA: 0x211810 Offset: 0x210C10 VA: 0x180211810
	private void EnsureSize(IArrayPool<char> bufferPool, int appendLength) { }

	// RVA: 0x211920 Offset: 0x210D20 VA: 0x180211920 Slot: 3
	public override string ToString() { }

	// RVA: 0x2118F0 Offset: 0x210CF0 VA: 0x1802118F0
	public string ToString(int start, int length) { }

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public char[] get_InternalBuffer() { }

}

