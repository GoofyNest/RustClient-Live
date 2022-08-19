public sealed class ZlibCodec // TypeDefIndex: 6966
{	// Fields
	public byte[] InputBuffer; // 0x10
	public int NextIn; // 0x18
	public int AvailableBytesIn; // 0x1C
	public long TotalBytesIn; // 0x20
	public byte[] OutputBuffer; // 0x28
	public int NextOut; // 0x30
	public int AvailableBytesOut; // 0x34
	public long TotalBytesOut; // 0x38
	public string Message; // 0x40
	internal DeflateManager dstate; // 0x48
	internal InflateManager istate; // 0x50
	internal uint _Adler32; // 0x58
	public CompressionLevel CompressLevel; // 0x5C
	public int WindowBits; // 0x60
	public CompressionStrategy Strategy; // 0x64

	// Methods

	// RVA: 0x21D3850 Offset: 0x21D2C50 VA: 0x1821D3850
	public void .ctor() { }

	// RVA: 0x21D3530 Offset: 0x21D2930 VA: 0x1821D3530
	public int InitializeInflate(bool expectRfc1950Header) { }

	// RVA: 0x21D3610 Offset: 0x21D2A10 VA: 0x1821D3610
	public int InitializeInflate(int windowBits, bool expectRfc1950Header) { }

	// RVA: 0x21D3350 Offset: 0x21D2750 VA: 0x1821D3350
	public int Inflate(FlushType flush) { }

	// RVA: 0x21D3270 Offset: 0x21D2670 VA: 0x1821D3270
	public int EndInflate() { }

	// RVA: 0x21D33D0 Offset: 0x21D27D0 VA: 0x1821D33D0
	public int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header) { }

	// RVA: 0x21D36F0 Offset: 0x21D2AF0 VA: 0x1821D36F0
	private int _InternalInitializeDeflate(bool wantRfc1950Header) { }

	// RVA: 0x21D3170 Offset: 0x21D2570 VA: 0x1821D3170
	public int Deflate(FlushType flush) { }

	// RVA: 0x21D31F0 Offset: 0x21D25F0 VA: 0x1821D31F0
	public int EndDeflate() { }

	// RVA: 0x21D3870 Offset: 0x21D2C70 VA: 0x1821D3870
	internal void flush_pending() { }

	// RVA: 0x21D3A20 Offset: 0x21D2E20 VA: 0x1821D3A20
	internal int read_buf(byte[] buf, int start, int size) { }

}

