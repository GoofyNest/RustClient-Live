internal class DeflaterHuffman // TypeDefIndex: 5660
{	// Fields
	private static int BUFSIZE; // 0x0
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

	// Methods

	// RVA: 0x13A8570 Offset: 0x13A7970 VA: 0x1813A8570
	public static short BitReverse(int toReverse) { }

	// RVA: 0x13A9A20 Offset: 0x13A8E20 VA: 0x1813A9A20
	private static void .cctor() { }

	// RVA: 0x13A9FA0 Offset: 0x13A93A0 VA: 0x1813A9FA0
	public void .ctor(DeflaterPending pending) { }

	// RVA: 0x13A9000 Offset: 0x13A8400 VA: 0x1813A9000
	public void Reset() { }

	// RVA: 0x13A8FD0 Offset: 0x13A83D0 VA: 0x1813A8FD0
	private int Lcode(int len) { }

	// RVA: 0x13A8910 Offset: 0x13A7D10 VA: 0x1813A8910
	private int Dcode(int distance) { }

	// RVA: 0x13A9050 Offset: 0x13A8450 VA: 0x1813A9050
	public void SendAllTrees(int blTreeCodes) { }

	// RVA: 0x13A8690 Offset: 0x13A7A90 VA: 0x1813A8690
	public void CompressBlock() { }

	// RVA: 0x13A8E70 Offset: 0x13A8270 VA: 0x1813A8E70
	public void FlushStoredBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock) { }

	// RVA: 0x13A8930 Offset: 0x13A7D30 VA: 0x1813A8930
	public void FlushBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock) { }

	// RVA: 0x13A8F60 Offset: 0x13A8360 VA: 0x1813A8F60
	public bool IsFull() { }

	// RVA: 0x13A9910 Offset: 0x13A8D10 VA: 0x1813A9910
	public bool TallyLit(int lit) { }

	// RVA: 0x13A9750 Offset: 0x13A8B50 VA: 0x1813A9750
	public bool TallyDist(int dist, int len) { }

}

internal class DeflaterHuffman.Tree // TypeDefIndex: 5661
{	// Fields
	public short[] freqs; // 0x10
	public byte[] length; // 0x18
	public int minNumCodes; // 0x20
	public int numCodes; // 0x24
	private short[] codes; // 0x28
	private int[] bl_counts; // 0x30
	private int maxLength; // 0x38
	private DeflaterHuffman dh; // 0x40

	// Methods

	// RVA: 0x13C85B0 Offset: 0x13C79B0 VA: 0x1813C85B0
	public void .ctor(DeflaterHuffman dh, int elems, int minCodes, int maxLength) { }

	// RVA: 0x13C81B0 Offset: 0x13C75B0 VA: 0x1813C81B0
	public void Reset() { }

	// RVA: 0x13C8280 Offset: 0x13C7680 VA: 0x1813C8280
	public void WriteSymbol(int code) { }

	// RVA: 0x13C8240 Offset: 0x13C7640 VA: 0x1813C8240
	public void SetStaticCodes(short[] stCodes, byte[] stLength) { }

	// RVA: 0x13C6D60 Offset: 0x13C6160 VA: 0x1813C6D60
	public void BuildCodes() { }

	// RVA: 0x13C7000 Offset: 0x13C6400 VA: 0x1813C7000
	private void BuildLength(int[] childs) { }

	// RVA: 0x13C7530 Offset: 0x13C6930 VA: 0x1813C7530
	public void BuildTree() { }

	// RVA: 0x13C8120 Offset: 0x13C7520 VA: 0x1813C8120
	public int GetEncodedLength() { }

	// RVA: 0x13C7E60 Offset: 0x13C7260 VA: 0x1813C7E60
	public void CalcBLFreq(DeflaterHuffman.Tree blTree) { }

	// RVA: 0x13C8300 Offset: 0x13C7700 VA: 0x1813C8300
	public void WriteTree(DeflaterHuffman.Tree blTree) { }

}

