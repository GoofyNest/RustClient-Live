internal class DeflaterEngine : DeflaterConstants // TypeDefIndex: 5659
{	private static int TOO_FAR; // 0x0
	private int ins_h; // 0x10
	private short[] head; // 0x18
	private short[] prev; // 0x20
	private int matchStart; // 0x28
	private int matchLen; // 0x2C
	private bool prevAvailable; // 0x30
	private int blockStart; // 0x34
	private int strstart; // 0x38
	private int lookahead; // 0x3C
	private byte[] window; // 0x40
	private DeflateStrategy strategy; // 0x48
	private int max_chain; // 0x4C
	private int max_lazy; // 0x50
	private int niceLength; // 0x54
	private int goodLength; // 0x58
	private int comprFunc; // 0x5C
	private byte[] inputBuf; // 0x60
	private int totalIn; // 0x68
	private int inputOff; // 0x6C
	private int inputEnd; // 0x70
	private DeflaterPending pending; // 0x78
	private DeflaterHuffman huffman; // 0x80
	private Adler32 adler; // 0x88

	public int Adler { get; }
	public int TotalIn { get; }
	public DeflateStrategy Strategy { set; }


	public void .ctor(DeflaterPending pending) { }

	public void Reset() { }

	public void ResetAdler() { }

	public int get_Adler() { }

	public int get_TotalIn() { }

	public void set_Strategy(DeflateStrategy value) { }

	public void SetLevel(int lvl) { }

	private void UpdateHash() { }

	private int InsertString() { }

	private void SlideWindow() { }

	public void FillWindow() { }

	private bool FindLongestMatch(int curMatch) { }

	private bool DeflateStored(bool flush, bool finish) { }

	private bool DeflateFast(bool flush, bool finish) { }

	private bool DeflateSlow(bool flush, bool finish) { }

	public bool Deflate(bool flush, bool finish) { }

	public void SetInput(byte[] buf, int off, int len) { }

	public bool NeedsInput() { }

	private static void .cctor() { }

}

