public sealed class ZlibCodec // TypeDefIndex: 7006
{
	public byte[] InputBuffer;
	public int NextIn;
	public int AvailableBytesIn;
	public long TotalBytesIn;
	public byte[] OutputBuffer;
	public int NextOut;
	public int AvailableBytesOut;
	public long TotalBytesOut;
	public string Message;
	internal DeflateManager dstate;
	internal InflateManager istate;
	internal uint _Adler32;
	public CompressionLevel CompressLevel;
	public int WindowBits;
	public CompressionStrategy Strategy;


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

