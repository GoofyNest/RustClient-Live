public sealed class ZlibCodec // TypeDefIndex: 6966
{	public byte[] InputBuffer; // 0x10
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


	public void .ctor() { }

	public int InitializeInflate(bool expectRfc1950Header) { }

	public int InitializeInflate(int windowBits, bool expectRfc1950Header) { }

	public int Inflate(FlushType flush) { }

	public int EndInflate() { }

	public int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header) { }

	private int _InternalInitializeDeflate(bool wantRfc1950Header) { }

	public int Deflate(FlushType flush) { }

	public int EndDeflate() { }

	internal void flush_pending() { }

	internal int read_buf(byte[] buf, int start, int size) { }

}

