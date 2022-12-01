internal class BufferOffsetSize // TypeDefIndex: 2530
{
	public byte[] Buffer;
	public int Offset;
	public int Size;
	public int TotalBytes;
	public bool Complete;

	public int EndOffset { get; }
	public int Remaining { get; }


	public int get_EndOffset() { }

	public int get_Remaining() { }

	public void .ctor(byte[] buffer, int offset, int size) { }

	public override string ToString() { }

}

internal class BufferOffsetSize // TypeDefIndex: 2913
{
	internal byte[] Buffer;
	internal int Offset;
	internal int Size;


	internal void .ctor(byte[] buffer, int offset, int size, bool copyBuffer) { }

}

