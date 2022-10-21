internal class PendingBuffer // TypeDefIndex: 5668
{
	protected byte[] buf; 
	private int start; 
	private int end; 
	private uint bits; 
	private int bitCount; 

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

