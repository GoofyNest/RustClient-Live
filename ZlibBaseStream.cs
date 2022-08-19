internal class ZlibBaseStream : Stream // TypeDefIndex: 6964
{	// Fields
	protected internal ZlibCodec _z; // 0x28
	protected internal ZlibBaseStream.StreamMode _streamMode; // 0x30
	protected internal FlushType _flushMode; // 0x34
	protected internal ZlibStreamFlavor _flavor; // 0x38
	protected internal CompressionMode _compressionMode; // 0x3C
	protected internal CompressionLevel _level; // 0x40
	protected internal bool _leaveOpen; // 0x44
	protected internal byte[] _workingBuffer; // 0x48
	protected internal int _bufferSize; // 0x50
	protected internal byte[] _buf1; // 0x58
	protected internal Stream _stream; // 0x60
	protected internal CompressionStrategy Strategy; // 0x68
	private CRC32 crc; // 0x70
	protected internal string _GzipFileName; // 0x78
	protected internal string _GzipComment; // 0x80
	protected internal DateTime _GzipMtime; // 0x88
	protected internal int _gzipHeaderByteCount; // 0x90
	private bool nomoreinput; // 0x94

	// Properties
	internal int Crc32 { get; }
	protected internal bool _wantCompress { get; }
	private ZlibCodec z { get; }
	private byte[] workingBuffer { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x21D2D70 Offset: 0x21D2170 VA: 0x1821D2D70
	internal int get_Crc32() { }

	// RVA: 0x21D22D0 Offset: 0x21D16D0 VA: 0x1821D22D0
	public void .ctor(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen) { }

	// RVA: 0x21D2E00 Offset: 0x21D2200 VA: 0x1821D2E00
	protected internal bool get__wantCompress() { }

	// RVA: 0x21D2E70 Offset: 0x21D2270 VA: 0x1821D2E70
	private ZlibCodec get_z() { }

	// RVA: 0x21D2E10 Offset: 0x21D2210 VA: 0x1821D2E10
	private byte[] get_workingBuffer() { }

	// RVA: 0x21D1B40 Offset: 0x21D0F40 VA: 0x1821D1B40 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x21D2570 Offset: 0x21D1970 VA: 0x1821D2570
	private void finish() { }

	// RVA: 0x21D23F0 Offset: 0x21D17F0 VA: 0x1821D23F0
	private void end() { }

	// RVA: 0x21D0E90 Offset: 0x21D0290 VA: 0x1821D0E90 Slot: 16
	public override void Close() { }

	// RVA: 0x21D11C0 Offset: 0x21D05C0 VA: 0x1821D11C0 Slot: 18
	public override void Flush() { }

	// RVA: 0x21D18B0 Offset: 0x21D0CB0 VA: 0x1821D18B0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x21D1900 Offset: 0x21D0D00 VA: 0x1821D1900 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x21D11F0 Offset: 0x21D05F0 VA: 0x1821D11F0
	private string ReadZeroTerminatedString() { }

	// RVA: 0x21D1EE0 Offset: 0x21D12E0 VA: 0x1821D1EE0
	private int _ReadAndValidateGzipHeader() { }

	// RVA: 0x21D1370 Offset: 0x21D0770 VA: 0x1821D1370 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x21D2CE0 Offset: 0x21D20E0 VA: 0x1821D2CE0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x21D2D10 Offset: 0x21D2110 VA: 0x1821D2D10 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x21D2D40 Offset: 0x21D2140 VA: 0x1821D2D40 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x21D2D80 Offset: 0x21D2180 VA: 0x1821D2D80 Slot: 10
	public override long get_Length() { }

	// RVA: 0x21D2DB0 Offset: 0x21D21B0 VA: 0x1821D2DB0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x21D3120 Offset: 0x21D2520 VA: 0x1821D3120 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x21D10D0 Offset: 0x21D04D0 VA: 0x1821D10D0
	public static void CompressBuffer(byte[] b, Stream compressor) { }

	// RVA: 0x21D1930 Offset: 0x21D0D30 VA: 0x1821D1930
	public static byte[] UncompressBuffer(byte[] compressed, Stream decompressor) { }

}

internal enum ZlibBaseStream.StreamMode // TypeDefIndex: 6965
{	// Fields
	public int value__; // 0x0
	public const ZlibBaseStream.StreamMode Writer = 0;
	public const ZlibBaseStream.StreamMode Reader = 1;
	public const ZlibBaseStream.StreamMode Undefined = 2;

}

