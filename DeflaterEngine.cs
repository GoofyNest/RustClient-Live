internal class DeflaterEngine : DeflaterConstants // TypeDefIndex: 5660
{
	private static int TOO_FAR; 
	private int ins_h; 
	private short[] head; 
	private short[] prev; 
	private int matchStart; 
	private int matchLen; 
	private bool prevAvailable; 
	private int blockStart; 
	private int strstart; 
	private int lookahead; 
	private byte[] window; 
	private DeflateStrategy strategy; 
	private int max_chain; 
	private int max_lazy; 
	private int niceLength; 
	private int goodLength; 
	private int comprFunc; 
	private byte[] inputBuf; 
	private int totalIn; 
	private int inputOff; 
	private int inputEnd; 
	private DeflaterPending pending; 
	private DeflaterHuffman huffman; 
	private Adler32 adler; 

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

