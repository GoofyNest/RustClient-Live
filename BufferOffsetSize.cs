internal class BufferOffsetSize // TypeDefIndex: 2530
{	public byte[] Buffer; // 0x10
	public int Offset; // 0x18
	public int Size; // 0x1C
	public int TotalBytes; // 0x20
	public bool Complete; // 0x24

	public int EndOffset { get; }
	public int Remaining { get; }


	public int get_EndOffset() { }

	public int get_Remaining() { }

	public void .ctor(byte[] buffer, int offset, int size) { }

	public override string ToString() { }

}

internal class BufferOffsetSize // TypeDefIndex: 2913
{	internal byte[] Buffer; // 0x10
	internal int Offset; // 0x18
	internal int Size; // 0x1C


	internal void .ctor(byte[] buffer, int offset, int size, bool copyBuffer) { }

}

