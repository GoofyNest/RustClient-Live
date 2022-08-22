internal class PendingBuffer // TypeDefIndex: 5663
{	protected byte[] buf; // 0x10
	private int start; // 0x18
	private int end; // 0x1C
	private uint bits; // 0x20
	private int bitCount; // 0x24

	public int BitCount { get; }
	public bool IsFlushed { get; }


	public void .ctor(int bufsize) { }

	public void Reset() { }

	public void WriteShort(int s) { }

	public void WriteBlock(byte[] block, int offset, int len) { }

	public int get_BitCount() { }

	public void AlignToByte() { }

	public void WriteBits(int b, int count) { }

	public void WriteShortMSB(int s) { }

	public bool get_IsFlushed() { }

	public int Flush(byte[] output, int offset, int length) { }

}

