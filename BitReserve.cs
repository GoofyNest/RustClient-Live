internal sealed class BitReserve // TypeDefIndex: 7383
{	private const int BUFSIZE = 32768;
	private const int BUFSIZE_MASK = 32767;
	private int[] _Buffer; // 0x10
	private int _Offset; // 0x18
	private int _Totbit; // 0x1C
	private int _BufByteIdx; // 0x20


	internal void .ctor() { }

	private void InitBlock() { }

	internal int HssTell() { }

	internal int ReadBits(int n) { }

	internal int ReadOneBit() { }

	internal void PutBuffer(int val) { }

	internal void RewindStreamBits(int bitCount) { }

	internal void RewindStreamBytes(int byteCount) { }

}

