internal class DeflaterEngine : DeflaterConstants // TypeDefIndex: 5659
{	// Fields
	private static int TOO_FAR; // 0x0
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

	// Properties
	public int Adler { get; }
	public int TotalIn { get; }
	public DeflateStrategy Strategy { set; }

	// Methods

	// RVA: 0x13A8260 Offset: 0x13A7660 VA: 0x1813A8260
	public void .ctor(DeflaterPending pending) { }

	// RVA: 0x13A7B20 Offset: 0x13A6F20 VA: 0x1813A7B20
	public void Reset() { }

	// RVA: 0x13A7AF0 Offset: 0x13A6EF0 VA: 0x1813A7AF0
	public void ResetAdler() { }

	// RVA: 0x13A8550 Offset: 0x13A7950 VA: 0x1813A8550
	public int get_Adler() { }

	// RVA: 0x7E3980 Offset: 0x7E2D80 VA: 0x1807E3980
	public int get_TotalIn() { }

	// RVA: 0x5B1C90 Offset: 0x5B1090 VA: 0x1805B1C90
	public void set_Strategy(DeflateStrategy value) { }

	// RVA: 0x13A7D30 Offset: 0x13A7130 VA: 0x1813A7D30
	public void SetLevel(int lvl) { }

	// RVA: 0x13A81B0 Offset: 0x13A75B0 VA: 0x1813A81B0
	private void UpdateHash() { }

	// RVA: 0x13A7A10 Offset: 0x13A6E10 VA: 0x1813A7A10
	private int InsertString() { }

	// RVA: 0x13A80C0 Offset: 0x13A74C0 VA: 0x1813A80C0
	private void SlideWindow() { }

	// RVA: 0x13A7380 Offset: 0x13A6780 VA: 0x1813A7380
	public void FillWindow() { }

	// RVA: 0x13A74A0 Offset: 0x13A68A0 VA: 0x1813A74A0
	private bool FindLongestMatch(int curMatch) { }

	// RVA: 0x13A6FD0 Offset: 0x13A63D0 VA: 0x1813A6FD0
	private bool DeflateStored(bool flush, bool finish) { }

	// RVA: 0x13A6970 Offset: 0x13A5D70 VA: 0x1813A6970
	private bool DeflateFast(bool flush, bool finish) { }

	// RVA: 0x13A6C80 Offset: 0x13A6080 VA: 0x1813A6C80
	private bool DeflateSlow(bool flush, bool finish) { }

	// RVA: 0x13A7140 Offset: 0x13A6540 VA: 0x1813A7140
	public bool Deflate(bool flush, bool finish) { }

	// RVA: 0x13A7C40 Offset: 0x13A7040 VA: 0x1813A7C40
	public void SetInput(byte[] buf, int off, int len) { }

	// RVA: 0x13A7AE0 Offset: 0x13A6EE0 VA: 0x1813A7AE0
	public bool NeedsInput() { }

	// RVA: 0x13A8220 Offset: 0x13A7620 VA: 0x1813A8220
	private static void .cctor() { }

}

