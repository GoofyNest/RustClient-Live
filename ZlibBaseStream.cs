internal class ZlibBaseStream : Stream // TypeDefIndex: 7004
{
	protected internal ZlibCodec _z;
	protected internal ZlibBaseStream.StreamMode _streamMode;
	protected internal FlushType _flushMode;
	protected internal ZlibStreamFlavor _flavor;
	protected internal CompressionMode _compressionMode;
	protected internal CompressionLevel _level;
	protected internal bool _leaveOpen;
	protected internal byte[] _workingBuffer;
	protected internal int _bufferSize;
	protected internal byte[] _buf1;
	protected internal Stream _stream;
	protected internal CompressionStrategy Strategy;
	private CRC32 crc;
	protected internal string _GzipFileName;
	protected internal string _GzipComment;
	protected internal DateTime _GzipMtime;
	protected internal int _gzipHeaderByteCount;
	private bool nomoreinput;

	internal int Crc32 { get; }
	protected internal bool _wantCompress { get; }
	private ZlibCodec z { get; }
	private byte[] workingBuffer { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }


	internal int get_Crc32() { }

	public void .ctor(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen) { }

	protected internal bool get__wantCompress() { }

	private ZlibCodec get_z() { }

	private byte[] get_workingBuffer() { }

	public override void Write(byte[] buffer, int offset, int count) { }

	private void finish() { }

	private void end() { }

	public override void Close() { }

	public override void Flush() { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public override void SetLength(long value) { }

	private string ReadZeroTerminatedString() { }

	private int _ReadAndValidateGzipHeader() { }

	public override int Read(byte[] buffer, int offset, int count) { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public override void set_Position(long value) { }

	public static void CompressBuffer(byte[] b, Stream compressor) { }

	public static byte[] UncompressBuffer(byte[] compressed, Stream decompressor) { }

}

internal enum ZlibBaseStream.StreamMode // TypeDefIndex: 7005
{
	public int value__;
	public const ZlibBaseStream.StreamMode Writer = 0;
	public const ZlibBaseStream.StreamMode Reader = 1;
	public const ZlibBaseStream.StreamMode Undefined = 2;

}

