internal struct StringBuffer // TypeDefIndex: 5964
{
	private char[] _buffer; 
	private int _position; 

	public int Position { get; set; }
	public bool IsEmpty { get; }
	public char[] InternalBuffer { get; }


	public int get_Position() { }

	public void set_Position(int value) { }

	public bool get_IsEmpty() { }

	public void .ctor(IArrayPool<char> bufferPool, int initalSize) { }

	private void .ctor(char[] buffer) { }

	public void Append(IArrayPool<char> bufferPool, char value) { }

	public void Append(IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count) { }

	public void Clear(IArrayPool<char> bufferPool) { }

	private void EnsureSize(IArrayPool<char> bufferPool, int appendLength) { }

	public override string ToString() { }

	public string ToString(int start, int length) { }

	public char[] get_InternalBuffer() { }

}

