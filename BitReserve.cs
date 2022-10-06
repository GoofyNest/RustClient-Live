internal sealed class BitReserve // TypeDefIndex: 7390
{
	private const int BUFSIZE = 32768;
	private const int BUFSIZE_MASK = 32767;
	private int[] _Buffer; 
	private int _Offset; 
	private int _Totbit; 
	private int _BufByteIdx; 


	internal void .ctor() { }

	private void InitBlock() { }

	internal int HssTell() { }

	internal int ReadBits(int n) { }

	internal int ReadOneBit() { }

	internal void PutBuffer(int val) { }

	internal void RewindStreamBits(int bitCount) { }

	internal void RewindStreamBytes(int byteCount) { }

}

