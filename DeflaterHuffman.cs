internal class DeflaterHuffman // TypeDefIndex: 5660
{	private static int BUFSIZE; // 0x0
	private static int LITERAL_NUM; // 0x4
	private static int DIST_NUM; // 0x8
	private static int BITLEN_NUM; // 0xC
	private static int REP_3_6; // 0x10
	private static int REP_3_10; // 0x14
	private static int REP_11_138; // 0x18
	private static int EOF_SYMBOL; // 0x1C
	private static int[] BL_ORDER; // 0x20
	private static byte[] bit4Reverse; // 0x28
	public DeflaterPending pending; // 0x10
	private DeflaterHuffman.Tree literalTree; // 0x18
	private DeflaterHuffman.Tree distTree; // 0x20
	private DeflaterHuffman.Tree blTree; // 0x28
	private short[] d_buf; // 0x30
	private byte[] l_buf; // 0x38
	private int last_lit; // 0x40
	private int extra_bits; // 0x44
	private static short[] staticLCodes; // 0x30
	private static byte[] staticLLength; // 0x38
	private static short[] staticDCodes; // 0x40
	private static byte[] staticDLength; // 0x48


	public static short BitReverse(int toReverse) { }

	private static void .cctor() { }

	public void .ctor(DeflaterPending pending) { }

	public void Reset() { }

	private int Lcode(int len) { }

	private int Dcode(int distance) { }

	public void SendAllTrees(int blTreeCodes) { }

	public void CompressBlock() { }

	public void FlushStoredBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock) { }

	public void FlushBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock) { }

	public bool IsFull() { }

	public bool TallyLit(int lit) { }

	public bool TallyDist(int dist, int len) { }

}

internal class DeflaterHuffman.Tree // TypeDefIndex: 5661
{	public short[] freqs; // 0x10
	public byte[] length; // 0x18
	public int minNumCodes; // 0x20
	public int numCodes; // 0x24
	private short[] codes; // 0x28
	private int[] bl_counts; // 0x30
	private int maxLength; // 0x38
	private DeflaterHuffman dh; // 0x40


	public void .ctor(DeflaterHuffman dh, int elems, int minCodes, int maxLength) { }

	public void Reset() { }

	public void WriteSymbol(int code) { }

	public void SetStaticCodes(short[] stCodes, byte[] stLength) { }

	public void BuildCodes() { }

	private void BuildLength(int[] childs) { }

	public void BuildTree() { }

	public int GetEncodedLength() { }

	public void CalcBLFreq(DeflaterHuffman.Tree blTree) { }

	public void WriteTree(DeflaterHuffman.Tree blTree) { }

}

