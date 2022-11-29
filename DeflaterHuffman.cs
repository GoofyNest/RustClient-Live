internal class DeflaterHuffman // TypeDefIndex: 5667
{
	private static int BUFSIZE; 
	private static int LITERAL_NUM; 
	private static int DIST_NUM; 
	private static int BITLEN_NUM; 
	private static int REP_3_6; 
	private static int REP_3_10; 
	private static int REP_11_138; 
	private static int EOF_SYMBOL; 
	private static int[] BL_ORDER; 
	private static byte[] bit4Reverse; 
	public DeflaterPending pending; 
	private DeflaterHuffman.Tree literalTree; 
	private DeflaterHuffman.Tree distTree; 
	private DeflaterHuffman.Tree blTree; 
	private short[] d_buf; 
	private byte[] l_buf; 
	private int last_lit; 
	private int extra_bits; 
	private static short[] staticLCodes; 
	private static byte[] staticLLength; 
	private static short[] staticDCodes; 
	private static byte[] staticDLength; 


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

internal class DeflaterHuffman.Tree // TypeDefIndex: 5668
{
	public short[] freqs; 
	public byte[] length; 
	public int minNumCodes; 
	public int numCodes; 
	private short[] codes; 
	private int[] bl_counts; 
	private int maxLength; 
	private DeflaterHuffman dh; 


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

